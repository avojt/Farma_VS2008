Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmUlazniRacuniUnos
    Private kol As Single = 1
    Private cena As Single = 0
    Private pdv As Single = 1
    Private c_pdv As Integer = 18
    Private rabat As Single = 0
    Private ztroskovi As Single = 0
    Private ztr_pdv As Integer = 0
    Private neoporezivo As Single = 0
    Private osnovica As Single = 0
    Private skol As Single = 1
    Private scena As Single = 0
    Private spdv As Single = 0
    Private srab As Single = 0
    Private valuta As Integer = 0
    Private sifra As String = ""
    Private naziv As String = ""
    Private indeks As Integer = 0

    Private _pocetak As Boolean = True
    Private _snimljeno As Boolean = False
    Private _prod_cena_promenjena As Boolean = False

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmUlazniRacuni_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.app_pdv' table. You can move, or remove it, as needed.
        Me.App_pdvTableAdapter.Fill(Me.DataSet1.app_pdv)
        'TODO: This line of code loads data into the 'DataSet1.rm_artikli' table. You can move, or remove it, as needed.
        Me.Rm_artikliTableAdapter.Fill(Me.DataSet1.rm_artikli)

        pocetak()
        _pocetak = False
    End Sub

    Private Sub pocetak()
        txtSifra.Text = Nadji_rb(Imena.tabele.rm_ulazni_racuni_head.ToString, 1)
        txtIznosCena.Text = 0
        txtOsnovica.Text = 0
        txtIznosPdv.Text = 0
        txtIznosRabat.Text = 0
        txtIznosZanaplatu.Text = 0
        txtNapomena.Text = ""
        txtNeoporezivo.Text = 0
        txtZTroskovi.Text = 0
        txtBrFakture.Text = ""

        dateFakturisanja.Value = Today
        dateValuta.Value = Today

        popuni_parnere()
        popuni_combo_pdv()
        popuni_odlozeno()

    End Sub

    Private Sub popuni_parnere()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbPartneri.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_partneri.* from dbo.app_partneri where partner_dobavljac = 1"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbPartneri.Items.Add(DR.Item("partner_naziv"))
            Loop
            DR.Close()
        End If
        If cmbPartneri.Items.Count > 0 Then
            cmbPartneri.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_odlozeno()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbOdlozeno.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_odlozeno.* from dbo.app_odlozeno"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbOdlozeno.Items.Add(DR.Item("odlozeno"))
            Loop
            DR.Close()
        End If
        If cmbOdlozeno.Items.Count > 0 Then
            cmbOdlozeno.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_pdv(ByVal _roba As String) 'As Decimal
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli where naziv = '" & _roba & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                'popuni_cenu = DR.Item("cena")
                c_pdv = DR.Item("pdv")
            Loop
        End If
        CM.Dispose()
        CN.Close()
    End Sub


    Private Sub popuni_combo_pdv()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbPDV.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_pdv.* from dbo.app_pdv"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbPDV.Items.Add(DR.Item("pdv_stopa"))
            Loop
            DR.Close()
        End If
        If cmbPDV.Items.Count > 0 Then
            cmbPDV.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_robu(ByVal _roba As String)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        sifra = ""
        naziv = ""
        cena = 0
        'trenutna_kolicina = 0
        c_pdv = 1

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli where artikl_sifra = '" & _roba & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                sifra = DR.Item("artikl_sifra")
                naziv = DR.Item("artikl_naziv")
                'cena = DR.Item("cena")
                'trenutna_kolicina = DR.Item("kolicina")
                c_pdv = DR.Item("pdv")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub snimi_head()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        'Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_ulazni_racuni_head_add"
                .Parameters.AddWithValue("@sifra", txtSifra.Text)
                .Parameters.AddWithValue("@id_partner", Partner_id(cmbPartneri.Text))
                .Parameters.AddWithValue("@br_fakture", txtBrFakture.Text)
                .Parameters.AddWithValue("@datum_fakturisanja", dateFakturisanja.Value)
                .Parameters.AddWithValue("@datum_valuta", dateValuta.Value)
                .Parameters.AddWithValue("@valuta", CDec(cmbOdlozeno.Text))
                .Parameters.AddWithValue("@iznos_cena", CDec(txtIznosCena.Text))
                .Parameters.AddWithValue("@iznos_rabat", CDec(txtIznosRabat.Text))
                .Parameters.AddWithValue("@iznos_neoporezovan", neoporezivo)
                .Parameters.AddWithValue("@iznos_ztroskovi", ztroskovi)
                .Parameters.AddWithValue("@ztroskovi_pdv", ztr_pdv)
                .Parameters.AddWithValue("@iznos_pdv", CDec(txtIznosPdv.Text))
                .Parameters.AddWithValue("@iznos_zanaplatu", CDec(txtIznosZanaplatu.Text))
                .Parameters.AddWithValue("@napomena", txtNapomena.Text)
                .Parameters.AddWithValue("@unesen", 0)
                .Parameters.AddWithValue("@placeno", 0)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub snimi_stavku()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim i As Integer

        _id_racun = Nadji_id(Imena.tabele.rm_ulazni_racuni_head.ToString)
        dgStavke.Rows.GetFirstRow(0, 0)
        For i = 0 To dgStavke.Rows.Count - 2
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_ulazni_racuni_stavka_add"
                    .Parameters.AddWithValue("@id_racun_head", _id_racun) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                    .Parameters.AddWithValue("@rb", dgStavke.Rows(i).Cells(0).Value)
                    .Parameters.AddWithValue("@sifra", dgStavke.Rows(i).Cells(1).Value)
                    .Parameters.AddWithValue("@stavka", dgStavke.Rows(i).Cells(2).Value)
                    .Parameters.AddWithValue("@kolicina", CDec(dgStavke.Rows(i).Cells(3).Value))
                    .Parameters.AddWithValue("@cena", CDec(dgStavke.Rows(i).Cells(4).Value))
                    .Parameters.AddWithValue("@rabat", CDec(dgStavke.Rows(i).Cells(5).Value))
                    .Parameters.AddWithValue("@pdv", CInt(dgStavke.Rows(i).Cells(6).Value))
                    .Parameters.AddWithValue("@zanaplatu", CDec(dgStavke.Rows(i).Cells(7).Value))
                    .ExecuteScalar()
                End With
            End If
            CM.Dispose()
            CN.Close()
        Next
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Select Case e.ClickedItem.Name
            Case "tlbSnimi"
                snimi_head()
                snimi_stavku()
                _snimljeno = True
                pocetak()
                dgStavke.Rows.Clear()
            Case "tlbStanje"
                stanje()
                proveri_stanje(_nazivi, dgStavke.Rows.Count - 1)
            Case "tlbKalkulacija"
                'napravi_kalkulaciju()
                If Not _snimljeno Then
                    snimi_head()
                    snimi_stavku()
                End If
                'unesi()
                'pocetak()
                'dgStavke.Rows.Clear()
            Case "tlbUbaci"
                '    stanje()
                '    unesi_racun()
            Case "tlbProknjizi"
                proknjizi()
            Case "tlbEnd"
                Me.Dispose()
        End Select
    End Sub

#Region "Grid 1"

    Private Sub dgStavke_MouseCaptureChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgStavke.MouseCaptureChanged
        If Not IsNothing(dgStavke.CurrentCell) Then
            If Not IsDBNull(dgStavke.CurrentCell) Then
                Select Case dgStavke.CurrentCell.ColumnIndex
                    Case 1
                        If IsDBNull(dgStavke) Then
                            Exit Sub
                        Else
                            If dgStavke.CurrentCell.IsInEditMode Then
                                If Not IsNothing(dgStavke.CurrentCell.FormattedValue.ToString) Then
                                    Dim a As String = dgStavke.CurrentCell.GetEditedFormattedValue(dgStavke.CurrentRow.Index, DataGridViewDataErrorContexts.Display)
                                    popuni_robu(RTrim(dgStavke.CurrentCell.GetEditedFormattedValue(dgStavke.CurrentRow.Index, DataGridViewDataErrorContexts.Display)))
                                    dgStavke.CurrentCell.ToolTipText = naziv
                                End If
                            End If
                        End If
                End Select
            End If
        End If
    End Sub

    'Private Sub dgStavke_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgStavke.MouseHover
    '    If Not IsNothing(dgStavke.CurrentCell) Then
    '        If Not IsDBNull(dgStavke.CurrentCell) Then
    '            Select Case dgStavke.CurrentCell.ColumnIndex
    '                Case 1
    '                    If IsDBNull(dgStavke) Then
    '                        Exit Sub
    '                    Else
    '                        If dgStavke.CurrentCell.IsInEditMode Then
    '                            If Not IsNothing(dgStavke.CurrentCell.FormattedValue.ToString) Then
    '                                Dim a As String = RTrim(dgStavke.CurrentCell.GetEditedFormattedValue(dgStavke.CurrentRow.Index, DataGridViewDataErrorContexts.Display))
    '                                popuni_robu(RTrim(dgStavke.CurrentCell.GetEditedFormattedValue(dgStavke.CurrentRow.Index, DataGridViewDataErrorContexts.Display)))
    '                                dgStavke.CurrentCell.ToolTipText = naziv
    '                            End If
    '                        End If
    '                    End If
    '            End Select
    '        End If
    '    End If
    'End Sub

    Private Sub dgStavke_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgStavke.CellValueChanged
        If Not _pocetak Then
            With dgStavke
                Try
                    indeks = e.RowIndex
                    redni_broj()
                    If Not IsNothing(dgStavke.Rows(e.RowIndex).Cells(1).Value) Then
                        If dgStavke.Rows(e.RowIndex).Cells(1).Value.ToString <> "" Then

                            popuni_robu(RTrim(dgStavke.Rows(e.RowIndex).Cells(1).Value.ToString))
                            .Rows(e.RowIndex).Cells(1).ToolTipText = naziv

                            dgStavke.Rows(e.RowIndex).Cells(2).Value = naziv

                            If IsNothing(dgStavke.Rows(e.RowIndex).Cells(3).Value) Then
                                dgStavke.Rows(e.RowIndex).Cells(3).Value = 1
                            Else
                                If dgStavke.Rows(e.RowIndex).Cells(3).Value.ToString <> "" _
                                    And jeste_broj(dgStavke.Rows(e.RowIndex).Cells(3).Value.ToString) Then
                                    kol = dgStavke.Rows(e.RowIndex).Cells(3).Value
                                Else
                                    dgStavke.Rows(e.RowIndex).Cells(3).Value = 1
                                End If
                            End If

                            If IsNothing(dgStavke.Rows(e.RowIndex).Cells(4).Value) Then
                                dgStavke.Rows(e.RowIndex).Cells(4).Value = cena
                            Else
                                If dgStavke.Rows(e.RowIndex).Cells(4).Value.ToString <> "" _
                                    And jeste_broj(dgStavke.Rows(e.RowIndex).Cells(4).Value.ToString) Then
                                    cena = dgStavke.Rows(e.RowIndex).Cells(4).Value
                                Else
                                    dgStavke.Rows(e.RowIndex).Cells(4).Value = cena
                                End If
                            End If

                            If IsNothing(dgStavke.Rows(e.RowIndex).Cells(5).Value) Then
                                dgStavke.Rows(e.RowIndex).Cells(5).Value = 0
                            Else
                                If dgStavke.Rows(e.RowIndex).Cells(5).Value.ToString <> "" _
                                    And jeste_broj(dgStavke.Rows(e.RowIndex).Cells(5).Value.ToString) Then
                                    rabat = cena * CDec(dgStavke.Rows(e.RowIndex).Cells(5).Value) / 100
                                Else
                                    dgStavke.Rows(e.RowIndex).Cells(5).Value = 0
                                End If
                            End If

                            If IsNothing(dgStavke.Rows(e.RowIndex).Cells(6).Value) Then
                                dgStavke.Rows(e.RowIndex).Cells(6).Value = c_pdv
                            Else
                                If dgStavke.Rows(e.RowIndex).Cells(6).Value.ToString <> "" _
                                    And jeste_broj(dgStavke.Rows(e.RowIndex).Cells(6).Value.ToString) Then
                                    pdv = 1 + (CDec(dgStavke.Rows(e.RowIndex).Cells(6).Value) / 100)
                                Else
                                    dgStavke.Rows(e.RowIndex).Cells(6).Value = c_pdv
                                End If
                            End If
                        Else
                            cena = 0
                        End If
                    End If

                    .Rows(e.RowIndex).Cells(7).Value = Format(kol * (cena - rabat) * pdv, 3)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End With
        End If

        preracunaj()

    End Sub
    Dim store As System.Collections.Generic.Dictionary(Of Integer, Integer) = _
        New System.Collections.Generic.Dictionary(Of Integer, Integer)

    Const initialValue As Integer = -1

    Private Sub dgStavke_CellValueNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValueEventArgs) Handles dgStavke.CellValueNeeded
        ' If this is the row for new records, no values are needed.
        If e.RowIndex = Me.dgStavke.RowCount - 1 Then
            Return
        End If
        If store.ContainsKey(e.RowIndex) Then
            e.Value = store(e.RowIndex)
        ElseIf newRowNeeded AndAlso e.RowIndex = dgStavke.RowCount Then ' numberOfRows Then
            If dgStavke.IsCurrentCellInEditMode Then
                e.Value = initialValue
            Else
                e.Value = String.Empty
            End If
        Else
            e.Value = e.RowIndex
        End If
    End Sub

    Private Sub dgStavke_CellValuePushed(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValueEventArgs) Handles dgStavke.CellValuePushed
        store.Add(e.RowIndex, CInt(e.Value))
    End Sub

    Dim newRowNeeded As Boolean
    Private Sub dgStavke_NewRowNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgStavke.NewRowNeeded
        newRowNeeded = True
        dgStavke.Rows.Add(e.Row)
        dgStavke.Rows(e.Row.Index).Cells(2).Value = 1 'kolicina
        dgStavke.Rows(e.Row.Index).Cells(3).Value = 0 'cena
        dgStavke.Rows(e.Row.Index).Cells(4).Value = 0 'rabat
        dgStavke.Rows(e.Row.Index).Cells(6).Value = 0 'iznos
        pdv = 1
    End Sub

    Private Sub dgStavke_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgStavke.RowsRemoved
        preracunaj()
    End Sub

#End Region

    Private Sub redni_broj()
        Dim i As Integer

        For i = 0 To dgStavke.RowCount - 2
            dgStavke.Rows(i).Cells(0).Value = i + 1
        Next
    End Sub

    Private Sub dateFakturisanja_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateFakturisanja.ValueChanged
        If valuta > 0 Then
            dateValuta.Value = DateSerial(dateFakturisanja.Value.Year, dateFakturisanja.Value.Month, dateFakturisanja.Value.Day + valuta)
        Else
            dateValuta.Value = dateFakturisanja.Value
        End If
    End Sub

    Private Sub stanje()
        Dim i As Integer
        Try
            'dgStavke.Rows.GetFirstRow(0, 0)
            For i = 0 To dgStavke.Rows.Count - 2
                _nazivi.SetValue(dgStavke.Rows(i).Cells(2).Value.ToString, i, 0)
                _nazivi.SetValue(dgStavke.Rows(i).Cells(3).Value.ToString, i, 1)
                dgStavke.Rows.GetNextRow(i, Windows.Forms.DataGridViewElementStates.Selected)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub unesi_racun()
        Dim i As Integer
        Try
            For i = 0 To dgStavke.Rows.Count - 2
                Dim CN As SqlConnection = New SqlConnection(CNNString)
                Dim CM As New SqlCommand
                Dim DR As SqlDataReader

                CN.Open()
                CM = New SqlCommand()
                If CN.State = ConnectionState.Open Then
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.Text
                        .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli where dbo.rm_artikli.naziv = '" & _nazivi(i, 0) & "'"
                        DR = .ExecuteReader
                    End With
                    Do While DR.Read
                        roba(DR.Item("id_roba"), DR.Item("kolicina") + _nazivi(i, 1))
                    Loop
                End If
                CM.Dispose()
                CN.Close()
            Next
            unesi()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub roba(ByVal id, ByVal kol)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_artikli_promena_stanja"
                .Parameters.AddWithValue("@id_roba", id)
                .Parameters.AddWithValue("@kolicina", kol)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub unesi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_unesi_racun"
                .Parameters.AddWithValue("@id_racun_head", _id_racun)
                .Parameters.AddWithValue("@unesen", 1)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        _unesen = True
        zatvori_formu()
    End Sub

    Private Sub zatvori_formu()
        If _unesen Then
            Panel1.Enabled = False
            dgStavke.AllowUserToAddRows = False
            dgStavke.Enabled = False

            ToolStrip1.Items(0).Enabled = False
            ToolStrip1.Items(1).Enabled = False
            ToolStrip1.Items(2).Enabled = False
            ToolStrip1.Items(3).Enabled = False
            ToolStrip1.Items(4).Enabled = False

            txtNapomena.Enabled = False
            txtIznosCena.Enabled = False
            txtIznosPdv.Enabled = False
            txtIznosRabat.Enabled = False
            txtIznosZanaplatu.Enabled = False
            txtOsnovica.Enabled = False
            txtNeoporezivo.Enabled = False
            txtZTroskovi.Enabled = False

        End If
    End Sub

    'Private Sub napravi_kalkulaciju()
    '    Dim i As Integer
    '    Try
    '        For i = 0 To dgStavke.Rows.Count - 2
    '            _artikli.SetValue(dgStavke.Rows(i).Cells(1).Value.ToString, i, 0)
    '            _artikli.SetValue(dgStavke.Rows(i).Cells(3).Value.ToString, i, 1)
    '            _artikli.SetValue(dgStavke.Rows(i).Cells(4).Value.ToString, i, 2)
    '            _artikli.SetValue(dgStavke.Rows(i).Cells(5).Value.ToString, i, 3)
    '            _artikli.SetValue(dgStavke.Rows(i).Cells(6).Value.ToString, i, 4)
    '        Next
    '        _partner_naziv = cmbPartneri.Text
    '        _id_racun = txtSifra.Text
    '        _datum_fakturisanja = dateFakturisanja.Value.Date
    '        _kalk_broj = Nadji_rb(Imena.tabele.rm_kalkulacija_head.ToString, 1)
    '        _kalk_datum_kalk = Today
    '        _kalkulacija_broj_stavki = dgStavke.Rows.Count - 1
    '        _broj_racuna = txtBrFakture.Text

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    '    'unesi()

    '    _kalk_iz_racuna = True
    '    zatvori_formu()
    '    'Dim mForm As New frmKalkulacijaUnos
    '    'mForm.Show()

    'End Sub

    Private Sub txtZTroskovi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZTroskovi.TextChanged
        If jeste_broj(txtZTroskovi.Text) Then
            ztroskovi = CDec(txtZTroskovi.Text)
            'txtOsnovica.Text = CDec(txtOsnovica.Text) + CDec(txtZTroskovi.Text)
        Else
            ztroskovi = 0
        End If
        preracunaj()
    End Sub

    Private Sub txtOsnovica_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOsnovica.TextChanged
        If jeste_broj(txtOsnovica.Text) Then
            osnovica = CDec(txtOsnovica.Text)
        Else
            osnovica = 0
        End If
        preracunaj()
    End Sub

    Private Sub txtNeoporezivo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNeoporezivo.TextChanged
        If jeste_broj(txtNeoporezivo.Text) Then
            neoporezivo = CDec(txtNeoporezivo.Text)
        Else
            neoporezivo = 0
        End If
        preracunaj()
    End Sub

    Private Sub cmbPDV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPDV.SelectedIndexChanged
        If jeste_broj(cmbPDV.Text) Then
            ztr_pdv = CDec(cmbPDV.Text)
        Else
            ztr_pdv = 0
        End If
        preracunaj()
    End Sub

    Private Sub preracunaj()
        Dim i As Integer

        cena = 0
        rabat = 0
        pdv = 0
        scena = 0
        srab = 0
        spdv = 0

        Try
            For i = 0 To dgStavke.Rows.Count - 2
                Dim kol As Single = CDec(dgStavke.Rows(i).Cells(3).Value)
                Dim cen As Single = CDec(dgStavke.Rows(i).Cells(4).Value)
                Dim rab As Single = CDec(dgStavke.Rows(i).Cells(5).Value)
                Dim pdv As Single = CDec(dgStavke.Rows(i).Cells(6).Value)
                scena = scena + (kol * cen)
                srab = srab + (kol * cen * rab / 100)
                spdv = spdv + ((kol * (cen * (1 - (rab / 100)))) * pdv / 100)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'If Not _unesen Then
        txtIznosCena.Text = Format(scena, "##,##0.00")
        txtIznosRabat.Text = Format(srab, "##,##0.00")
        txtOsnovica.Text = Format((scena - srab) + ztroskovi, "##,##0.00")
        txtIznosPdv.Text = Format((spdv) + ztr_pdv, "##,##0.00")
        txtIznosZanaplatu.Text = Format((scena - srab + spdv) + ztroskovi + ztr_pdv + neoporezivo, "##,##0.00")
        'End If

    End Sub

    Private Sub cmbOdlozeno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOdlozeno.SelectedIndexChanged
        If cmbOdlozeno.Text <> "" And jeste_broj(cmbOdlozeno.Text) Then
            valuta = CInt(cmbOdlozeno.Text)
            dateValuta.Value = DateSerial(dateFakturisanja.Value.Year, dateFakturisanja.Value.Month, dateFakturisanja.Value.Day + valuta)
        Else
            valuta = 0
            dateValuta.Value = dateFakturisanja.Value
        End If
    End Sub

    Private Sub proknjizi()
        _sema_sifra = "urn-r"
        _partner_sifra = Partner_sifra(cmbPartneri.Text)
        _osnovica = CSng(txtOsnovica.Text)
        _pdv_iznos = CSng(txtIznosPdv.Text)
        _iznos = CSng(txtIznosZanaplatu.Text)
        _opis = "Racun rb." & txtBrFakture.Text
        _po_semi = True

        Dim mForm As New cntNalog_add
        mForm.Show()
    End Sub

    Private Sub btnNoviPartner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoviPartner.Click
        'Dim mForm As New frmPartneriUnos
        'mForm.Show()
    End Sub

    Private Sub btnNoviArtkl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoviArtkl.Click
        Dim mForm As New cntArtikliUnos
        mForm.Show()
    End Sub

    Private Sub btnOsvezi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOsvezi.Click
        Me.Rm_artikliTableAdapter.Update(Me.DataSet1.rm_artikli)
        Me.Rm_artikliTableAdapter.Fill(Me.DataSet1.rm_artikli)
        If _novi_artikl Then
            dgStavke.Rows(indeks).Cells(1).Value = _novi_artikl_sifra
            _prod_cena_promenjena = False
            _novi_artikl = False
        End If
        popuni_parnere()
    End Sub

    

End Class