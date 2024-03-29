Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmRacuniEdit
    Private kol As Single = 1
    Private cena As Single = 0
    Private c_cena As Single = 0
    Private pdv As Single = 1
    Private c_pdv As Integer = 18
    Private rabat As Single = 0
    Private neoporezivo As Single = 0
    Private skol As Single = 1
    Private scena As Single = 0
    Private spdv As Single = 0
    Private srab As Single = 0
    Private valuta As Integer = 0
    Private sifra As String = ""
    Private naziv As String = ""

    Private _pocetak As Boolean = True
    Private _citam_stavke As Boolean = True
    Private _popunjavam_robu As Boolean = True
    Private _promenjen_rabat As Boolean = False
    Private _promenjena_cena As Boolean = False
    Private indeks As Integer = 0


    Private Sub frmRacuniEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.app_pdv' table. You can move, or remove it, as needed.
        Me.App_pdvTableAdapter.Fill(Me.DataSet1.app_pdv)
        'TODO: This line of code loads data into the 'DataSet1.rm_artikli' table. You can move, or remove it, as needed.
        Me.Rm_artikliTableAdapter.Fill(Me.DataSet1.rm_artikli)

        pocetak()
        _pocetak = False
        popuni_stavke()

    End Sub

    Private Sub pocetak()
        txtSifra.Text = _sifra_racun '(Imena.tabele.rm_racun_head.ToString)
        'txtValuta.Text = _valuta
        txtIznosCena.Text = _cena
        txtOsnovica.Text = _iznos - _pdv
        txtIznosPdv.Text = _pdv
        txtIznosRabat.Text = _rabat
        txtIznosZanaplatu.Text = _iznos
        txtNapomena.Text = _napomena

        dateFakturisanja.Value = _datum_fakturisanja
        datePromet.Value = _datum_prometa

        popuni_parnere()
        popuni_odlozeno()

        If _izdat Then zatvori_formu()

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
                .CommandText = "select dbo.app_partneri.* from dbo.app_partneri"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbPartneri.Items.Add(DR.Item("naziv"))
            Loop
            DR.Close()
        End If
        If cmbPartneri.Items.Count > 0 Then
            cmbPartneri.SelectedText = Partner_naziv(_id_partner)
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
            cmbOdlozeno.SelectedText = _valuta
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
                .CommandText = "rm_racun_head_update"
                .Parameters.AddWithValue("@id_racun_head", _id_racun)
                .Parameters.AddWithValue("@sifra", txtSifra.Text)
                .Parameters.AddWithValue("@id_partner", Partner_id(cmbPartneri.Text))
                .Parameters.AddWithValue("@datum_fakturisanja", dateFakturisanja.Value.Date)
                .Parameters.AddWithValue("@datum_valuta", dateValuta.Value.Date)
                .Parameters.AddWithValue("@valuta", CDec(cmbOdlozeno.Text))
                .Parameters.AddWithValue("@datum_prometa", datePromet.Value.Date)
                .Parameters.AddWithValue("@iznos_cena", CDec(txtIznosCena.Text))
                .Parameters.AddWithValue("@iznos_rabat", CDec(txtIznosRabat.Text))
                .Parameters.AddWithValue("@iznos_pdv", CDec(txtIznosPdv.Text))
                .Parameters.AddWithValue("@iznos_zanaplatu", CDec(txtIznosZanaplatu.Text))
                .Parameters.AddWithValue("@napomena", txtNapomena.Text)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub snimi_stavku()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim i, n As Integer

        '_id_racun = Nadji_id(Imena.tabele.rm_racun_head.ToString)
        'dgStavke.Rows.GetFirstRow(0, 0)

        CN.Open()
        If _id_racun_stavka.Length > dgStavke.Rows.Count - 1 Then
            n = _id_racun_stavka.Length - 1
        Else
            n = dgStavke.Rows.Count - 2
        End If
        For i = 0 To n
            If (i <= dgStavke.Rows.Count - 2 Or Not _id_racun_stavka.Length > dgStavke.Rows.Count - 1) Or _id_racun_stavka.Length = 0 Then
                If i > _id_racun_stavka.Length - 1 Then '_id_racun_stavka(i) = 0 Then
                    CM = New SqlCommand()
                    If CN.State = ConnectionState.Open Then
                        With CM
                            .Connection = CN
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "rm_racun_stavka_add"
                            .Parameters.AddWithValue("@id_racun_head", _id_racun) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                            .Parameters.AddWithValue("@rb", dgStavke.Rows(i).Cells(0).Value)
                            .Parameters.AddWithValue("@sifra", dgStavke.Rows(i).Cells(1).Value)
                            .Parameters.AddWithValue("@stavka", dgStavke.Rows(i).Cells(2).Value)
                            .Parameters.AddWithValue("@kolicina", CSng(dgStavke.Rows(i).Cells(3).Value))
                            .Parameters.AddWithValue("@cena", CSng(dgStavke.Rows(i).Cells(4).Value))
                            .Parameters.AddWithValue("@rabat", CSng(dgStavke.Rows(i).Cells(5).Value))
                            .Parameters.AddWithValue("@pdv", CInt(dgStavke.Rows(i).Cells(6).Value))
                            .Parameters.AddWithValue("@zanaplatu", CSng(dgStavke.Rows(i).Cells(7).Value))
                            .ExecuteScalar()
                        End With
                    End If
                    CM.Dispose()
                Else
                    CM = New SqlCommand()
                    If CN.State = ConnectionState.Open Then
                        With CM
                            .Connection = CN
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "rm_racun_stavka_update"
                            .Parameters.AddWithValue("@id_racun_stavka", _id_racun_stavka(i)) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                            .Parameters.AddWithValue("@rb", dgStavke.Rows(i).Cells(0).Value)
                            .Parameters.AddWithValue("@sifra", dgStavke.Rows(i).Cells(1).Value)
                            .Parameters.AddWithValue("@stavka", dgStavke.Rows(i).Cells(2).Value)
                            .Parameters.AddWithValue("@kolicina", CSng(dgStavke.Rows(i).Cells(3).Value))
                            .Parameters.AddWithValue("@cena", CSng(dgStavke.Rows(i).Cells(4).Value))
                            .Parameters.AddWithValue("@rabat", CSng(dgStavke.Rows(i).Cells(5).Value))
                            .Parameters.AddWithValue("@pdv", CInt(dgStavke.Rows(i).Cells(6).Value))
                            .Parameters.AddWithValue("@zanaplatu", CSng(dgStavke.Rows(i).Cells(7).Value))
                            .ExecuteScalar()
                        End With
                    End If
                    CM.Dispose()
                End If
            Else
                CM = New SqlCommand()
                If CN.State = ConnectionState.Open Then
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "rm_racun_stavka_delete"
                        .Parameters.AddWithValue("@id_racun_stavka", _id_racun_stavka(i)) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                        .ExecuteScalar()
                    End With
                End If
                CM.Dispose()
            End If
        Next
        CN.Close()
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Select Case e.ClickedItem.Name
            Case "tlbSnimi"
                snimi_head()
                snimi_stavku()
                'pocetak()
                dgStavke.Rows.Clear()
                popuni_stavke()
            Case "tlbPovratnica"
                napravi_povratnicu()
                'stanje()
                'proveri_stanje(_nazivi, dgStavke.Rows.Count - 1)
            Case "tlbStanje"
                stanje()
                proveri_stanje(_nazivi, dgStavke.Rows.Count - 1)
            Case "tlbIzdaj"
                stanje()
                izdaj_robu(_nazivi, dgStavke.Rows.Count - 1)
                izdat()
            Case "tlbProknjizi"
                proknjizi()
            Case "tlbEnd"
                Me.Dispose()
        End Select
    End Sub

#Region "Grid 1"

    Private Sub dgStavke_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        If dgStavke.CurrentRow.Displayed Then

            popuni_robu(RTrim(dgStavke.CurrentRow.Cells(1).Value.ToString))
            'dgStavke.CurrentRow.Tag = naziv
            dgStavke.CurrentRow.Cells(1).ToolTipText = naziv
        End If
    End Sub

    Private Sub dgStavke_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

        If Not _pocetak Then
            With dgStavke
                Try
                    '.Rows(e.RowIndex).Cells(0).Value = e.RowIndex + 1
                    indeks = e.RowIndex
                    Select Case e.ColumnIndex
                        Case 1
                            _popunjavam_robu = True
                            indeks = e.RowIndex
                            redni_broj()
                            If Not IsNothing(.Rows(e.RowIndex).Cells(1).Value) Then
                                If .Rows(e.RowIndex).Cells(1).Value.ToString <> "" Then

                                    popuni_robu(RTrim(dgStavke.Rows(e.RowIndex).Cells(1).Value.ToString))
                                    '.Rows(e.RowIndex).Cells(1).ToolTipText = naziv

                                    .Rows(e.RowIndex).Cells(2).Value = naziv
                                    .Rows(e.RowIndex).Cells(3).Value = 1
                                    .Rows(e.RowIndex).Cells(4).Value = c_cena
                                    .Rows(e.RowIndex).Cells(5).Value = 0
                                    .Rows(e.RowIndex).Cells(6).Value = c_pdv
                                    '.Rows(e.RowIndex).Cells(7).Value = 0
                                    _popunjavam_robu = False

                                Else
                                    cena = 0
                                End If
                            End If
                        Case 4
                            _promenjena_cena = True
                        Case 5
                            _promenjen_rabat = True
                    End Select

                    If Not _popunjavam_robu Then
                        If Not IsNothing(.Rows(e.RowIndex).Cells(3).Value) Then
                            If .Rows(e.RowIndex).Cells(3).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(3).Value.ToString) Then
                                kol = CSng(.Rows(e.RowIndex).Cells(3).Value)
                            Else
                                kol = 1
                            End If
                        End If
                        If Not IsNothing(.Rows(e.RowIndex).Cells(4).Value) Then
                            If .Rows(e.RowIndex).Cells(4).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(4).Value.ToString) Then
                                cena = CSng(.Rows(e.RowIndex).Cells(4).Value)
                            Else
                                cena = 0
                            End If
                        End If
                        If Not IsNothing(.Rows(e.RowIndex).Cells(5).Value) Then
                            If .Rows(e.RowIndex).Cells(5).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(5).Value.ToString) Then
                                rabat = CSng(.Rows(e.RowIndex).Cells(4).Value) * CSng(.Rows(e.RowIndex).Cells(5).Value) / 100
                            Else
                                rabat = 0
                            End If
                        End If
                        If Not IsNothing(.Rows(e.RowIndex).Cells(6).Value) Then
                            If .Rows(e.RowIndex).Cells(6).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(6).Value.ToString) Then
                                pdv = 1 + (CSng(.Rows(e.RowIndex).Cells(6).Value) / 100)
                            Else
                                pdv = 1
                            End If
                        End If
                    Else
                        'cena = c_cena
                        pdv = 1 + (c_pdv / 100)
                        'rabat = 0
                    End If

                    'If _promenjena_cena Then
                    '    cena = CSng(.Rows(e.RowIndex).Cells(4).Value)
                    '    _promenjena_cena = False
                    'ElseIf _promenjen_rabat Then
                    '    rabat = rabat = CSng(.Rows(e.RowIndex).Cells(4).Value) * CSng(.Rows(e.RowIndex).Cells(5).Value) / 100
                    '    _promenjen_rabat = False
                    'End If

                    .Rows(e.RowIndex).Cells(7).Value = Format(kol * (cena - rabat) * pdv, 3)

                    _promenjena_cena = False
                    _promenjen_rabat = False

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

    Private Sub dgStavke_CellValueNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValueEventArgs)
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

    Private Sub dgStavke_CellValuePushed(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValueEventArgs)
        store.Add(e.RowIndex, CInt(e.Value))
    End Sub

    Dim newRowNeeded As Boolean
    Private Sub dgStavke_NewRowNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs)
        newRowNeeded = True
        dgStavke.Rows.Add(e.Row)
        dgStavke.Rows(e.Row.Index).Cells(2).Value = 1 'kolicina
        dgStavke.Rows(e.Row.Index).Cells(3).Value = 0 'cena
        dgStavke.Rows(e.Row.Index).Cells(4).Value = 0 'rabat
        dgStavke.Rows(e.Row.Index).Cells(6).Value = 0 'iznos
        pdv = 1
    End Sub

    Private Sub dgStavke_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs)
        preracunaj()
    End Sub

#End Region

    Private Sub redni_broj()
        Dim i As Integer

        For i = 0 To dgStavke.RowCount - 2
            dgStavke.Rows(i).Cells(0).Value = i + 1
        Next
    End Sub

    Private Sub dateFakturisanja_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If valuta > 0 Then
            datePromet.Value = DateSerial(dateFakturisanja.Value.Year, dateFakturisanja.Value.Month, dateFakturisanja.Value.Day + valuta)
        Else
            datePromet.Value = dateFakturisanja.Value
        End If
    End Sub

    Private Function popuni_cenu(ByVal _roba As String) As Decimal
        If Not _citam_stavke Then
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
                    popuni_cenu = DR.Item("cena")
                    c_pdv = DR.Item("pdv")
                Loop
            End If
            CM.Dispose()
            CN.Close()
        Else
            Exit Function
        End If
    End Function

    Private Sub popuni_robu(ByVal _roba As String)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        sifra = ""
        naziv = ""
        c_cena = 0
        'trenutna_kolicina = 0
        c_pdv = 1

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli where sifra = '" & _roba & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                sifra = RTrim(DR.Item("sifra"))
                naziv = DR.Item("naziv")
                c_cena = DR.Item("cena")
                'trenutna_kolicina = DR.Item("kolicina")
                c_pdv = CSng(DR.Item("pdv"))
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_stavke()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.racun_stavka.* from dbo.racun_stavka where dbo.racun_stavka.id_racun_head = " & _id_racun
                .ExecuteScalar()
                DR = .ExecuteReader
            End With
            'Dim 'conn As New SqlConnection()
            'conn.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Northwind.mdf;Integrated Security=True;User Instance=True"

            _broj_stavki = 0
            Do While DR.Read
                _broj_stavki += 1
            Loop
            DR.Close()

            _id_racun_stavka = New Integer() {}
            ReDim _id_racun_stavka(_broj_stavki - 1)

            With dgStavke
                Dim i As Integer = 0
                DR = CM.ExecuteReader
                Do While DR.Read
                    .Rows.Add(1)
                    If Not IsDBNull(DR.Item("id_racun_stavka")) Then _id_racun_stavka.SetValue(DR.Item("id_racun_stavka"), i)
                    'If Not IsDBNull(DR.Item("rb")) Then .Rows(i).Cells(0).Value = DR.Item("rb")

                    If Not IsDBNull(DR.Item("sifra")) Then
                        popuni_robu(RTrim(DR.Item("sifra")))
                        If sifra <> "" Then
                            .Rows(i).Cells(1).Value = RTrim(sifra)
                        Else
                            .Rows(i).Cells(1).Value = DBNull.Value
                        End If
                    End If

                    If Not IsDBNull(DR.Item("stavka")) Then .Rows(i).Cells(2).Value = DR.Item("stavka")
                    If Not IsDBNull(DR.Item("kolicina")) Then .Rows(i).Cells(3).Value = DR.Item("kolicina")
                    If Not IsDBNull(DR.Item("cena")) Then .Rows(i).Cells(4).Value = DR.Item("cena")
                    If Not IsDBNull(DR.Item("rabat")) Then .Rows(i).Cells(5).Value = DR.Item("rabat")
                    If Not IsDBNull(DR.Item("pdv")) Then .Rows(i).Cells(6).Value = DR.Item("pdv")
                    If Not IsDBNull(DR.Item("zanaplatu")) Then .Rows(i).Cells(7).Value = DR.Item("zanaplatu")
                    i += 1
                Loop
            End With
        End If

        CM.Dispose()
        CN.Close()
        _citam_stavke = False
    End Sub

    Private Sub stanje()
        Dim i As Integer
        For i = 0 To dgStavke.Rows.Count - 2
            _nazivi.SetValue(dgStavke.Rows(i).Cells(1).Value.ToString, i, 0)
            _nazivi.SetValue(dgStavke.Rows(i).Cells(3).Value.ToString, i, 1)
        Next
    End Sub

    Private Sub izdat()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_racun_izdaj"
                .Parameters.AddWithValue("@id_racun_head", _id_racun)
                .Parameters.AddWithValue("@izdat", 1)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        _izdat = True
        zatvori_formu()
    End Sub

    Private Sub zatvori_formu()
        If _izdat Then
            Panel1.Enabled = False
            dgStavke.AllowUserToAddRows = False
            dgStavke.Enabled = False

            ToolStrip1.Items(0).Enabled = False
            ToolStrip1.Items(1).Enabled = False
            ToolStrip1.Items(2).Enabled = False

            txtNapomena.Enabled = False
            txtIznosCena.Enabled = False
            txtIznosPdv.Enabled = False
            txtIznosRabat.Enabled = False
            txtIznosZanaplatu.Enabled = False
            txtOsnovica.Enabled = False
        End If
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
                spdv += kol * (cen * (1 - (rab / 100))) * (pdv / 100) '((kol * (cen * (1 - (rab / 100)))) * pdv / 100)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'If Not _unesen Then
        txtIznosCena.Text = Format(scena, "##,##0.00")
        txtIznosRabat.Text = Format(srab, "##,##0.00")
        txtOsnovica.Text = Format((scena - srab), "##,##0.00")
        txtIznosPdv.Text = Format((spdv), "##,##0.00")
        txtIznosZanaplatu.Text = Format((scena - srab + spdv), "##,##0.00")
        'End If


    End Sub

    Private Sub cmbOdlozeno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cmbOdlozeno.Text <> "" And jeste_broj(cmbOdlozeno.Text) Then
            valuta = CInt(cmbOdlozeno.Text)
            dateValuta.Value = DateSerial(dateFakturisanja.Value.Year, dateFakturisanja.Value.Month, dateFakturisanja.Value.Day + valuta)
        Else
            valuta = 0
            dateValuta.Value = dateFakturisanja.Value
        End If
    End Sub

    Private Sub napravi_povratnicu()
        Dim i As Integer
        Try
            For i = 0 To dgStavke.Rows.Count - 2
                _artikli.SetValue(dgStavke.Rows(i).Cells(1).Value.ToString, i, 0)
                _artikli.SetValue(dgStavke.Rows(i).Cells(3).Value.ToString, i, 1)
                _artikli.SetValue(dgStavke.Rows(i).Cells(4).Value.ToString, i, 2)
                _artikli.SetValue(dgStavke.Rows(i).Cells(5).Value.ToString, i, 3)
                _artikli.SetValue(dgStavke.Rows(i).Cells(6).Value.ToString, i, 4)
            Next
            _partner_naziv = cmbPartneri.Text
            _id_racun = Nadji_id(Imena.tabele.rm_racun_head.ToString)
            _datum_fakturisanja = dateFakturisanja.Value.Date
            '_po_racunu_br = Nadji_rb(Imena.tabele.rm_povratnica_head.ToString)
            '_kalkulacija_datum = Today
            _broj_stavki = dgStavke.Rows.Count - 1
            '_po_racunu_br = txtSifra.Text

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'unesi()

        '_povratnica_iz_racuna = True
        ''_unesen = True
        ''zatvori_formu()
        'Dim mForm As New frmPovratnicaUnos
        'mForm.Show()
    End Sub

    Private Sub proknjizi()
        _sema_sifra = "irn-r"
        _partner_sifra = Partner_sifra(cmbPartneri.Text)
        _osnovica = CSng(txtOsnovica.Text)
        _pdv_iznos = CSng(txtIznosPdv.Text)
        _iznos = CSng(txtIznosZanaplatu.Text)
        _opis = "Racun rb." & txtSifra.Text
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
        'Me.RobaTableAdapter.Update(Me.DataSet1.rm_artikli)
        'Me.RobaTableAdapter.Fill(Me.DataSet1.rm_artikli)
        If _novi_artikl Then
            dgStavke.Rows(indeks).Cells(1).Value = _novi_artikl_sifra
            '_prod_cena_promenjena = False
            _novi_artikl = False
        End If
        popuni_parnere()
    End Sub

End Class