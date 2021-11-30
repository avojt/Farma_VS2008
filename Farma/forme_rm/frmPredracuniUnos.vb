Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmPredracuniUnos
    Private kol As Single = 1
    Private cena As Single = 0
    Private pdv As Single = 1
    Private c_pdv As Integer = 18
    Private rabat As Single = 0
    Private skol As Single = 1
    Private scena As Single = 0
    Private spdv As Single = 0
    Private srab As Single = 0
    Private valuta As Integer = 0
    Private ztroskovi As Single = 0
    Private ztr_pdv As Integer = 0
    Private neoporezivo As Single = 0
    Private sifra As String = ""
    Private naziv As String = ""

    Private _pocetak As Boolean = True

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmPredracuniUnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.rm_artikli' table. You can move, or remove it, as needed.
        Me.Rm_artikliTableAdapter.Fill(Me.DataSet1.rm_artikli)
        'TODO: This line of code loads data into the 'DataSet1.app_pdv' table. You can move, or remove it, as needed.
        Me.App_pdvTableAdapter.Fill(Me.DataSet1.app_pdv)

        pocetak()
    End Sub

    Private Sub frmPredracuniUnos_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        _ponuda_iz_robe = False
    End Sub


    Private Sub pocetak()
        txtSifra.Text = Nadji_rb(Imena.tabele.rm_predracun_head.ToString, 1)
        txtIznosCena.Text = 0
        txtOsnovica.Text = 0
        txtIznosPdv.Text = 0
        txtIznosRabat.Text = 0
        txtIznosZanaplatu.Text = 0
        txtNapomena.Text = ""

        dateFakturisanja.Value = Today
        dateValuta.Value = Today

        popuni_parnere()
        popuni_odlozeno()

        If _ponuda_iz_robe Then
            _pocetak = False
            popuni_stavke()
        End If

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
                .CommandText = "rm_predracun_head_add"
                .Parameters.AddWithValue("@sifra", txtSifra.Text)
                .Parameters.AddWithValue("@id_partner", Partner_id(cmbPartneri.Text))
                .Parameters.AddWithValue("@datum_fakturisanja", dateFakturisanja.Value)
                .Parameters.AddWithValue("@datum_prometa", dateValuta.Value)
                .Parameters.AddWithValue("@valuta", CDec(cmbOdlozeno.Text))
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
        Dim i As Integer

        _id_predracun = Nadji_id(Imena.tabele.rm_predracun_head.ToString)
        dgStavke.Rows.GetFirstRow(0, 0)
        For i = 0 To dgStavke.Rows.Count - 2
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_predracun_stavka_add"
                    .Parameters.AddWithValue("@id_predracun_head", _id_predracun) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                    .Parameters.AddWithValue("@rb", CInt(dgStavke.Rows(i).Cells(0).Value))
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

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Select Case e.ClickedItem.Name
            Case "tlbSnimi"
                snimi_head()
                snimi_stavku()
                pocetak()
                dgStavke.Rows.Clear()
            Case "tlbStanje"
                stanje()
                'Case "tlbURacun"

            Case "tlbEnd"
                Me.Dispose()
        End Select
    End Sub

#Region "Grid 1"

    Private Sub dgStavke_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgStavke.MouseHover
        'If dgStavke.CurrentRow.Displayed Then

        '    popuni_robu(RTrim(dgStavke.CurrentRow.Cells(1).Value.ToString))
        '    'dgStavke.CurrentRow.Tag = naziv
        '    dgStavke.CurrentRow.Cells(1).ToolTipText = naziv
        'End If
    End Sub

    Private Sub dgStavke_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgStavke.CellValueChanged
        If Not _pocetak Then
            With dgStavke
                Try
                    '.Rows(e.RowIndex).Cells(0).Value = e.RowIndex + 1
                    redni_broj()
                    If Not IsNothing(dgStavke.Rows(e.RowIndex).Cells(1).Value) Then
                        If dgStavke.Rows(e.RowIndex).Cells(1).Value.ToString <> "" Then
                            'popuni_pdv(dgStavke.Rows(e.RowIndex).Cells(1).Value.ToString)
                            popuni_robu(RTrim(dgStavke.Rows(e.RowIndex).Cells(1).Value.ToString))
                            '.Rows(e.RowIndex).Cells(1).ToolTipText = naziv

                            If IsNothing(dgStavke.Rows(e.RowIndex).Cells(2).Value) Then
                                dgStavke.Rows(e.RowIndex).Cells(2).Value = naziv
                            Else
                                If dgStavke.Rows(e.RowIndex).Cells(2).Value.ToString <> "" Then
                                    naziv = dgStavke.Rows(e.RowIndex).Cells(2).Value
                                Else
                                    dgStavke.Rows(e.RowIndex).Cells(2).Value = naziv
                                End If
                            End If

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
                                    'rabat = dgStavke.Rows(e.RowIndex).Cells(5).Value
                                Else
                                    dgStavke.Rows(e.RowIndex).Cells(5).Value = 0
                                End If
                            End If

                            If IsNothing(dgStavke.Rows(e.RowIndex).Cells(6).Value) Then
                                dgStavke.Rows(e.RowIndex).Cells(6).Value = 0
                            Else
                                If dgStavke.Rows(e.RowIndex).Cells(6).Value.ToString <> "" _
                                    And jeste_broj(dgStavke.Rows(e.RowIndex).Cells(6).Value.ToString) Then
                                    pdv = 1 + (CDec(dgStavke.Rows(e.RowIndex).Cells(6).Value) / 100)
                                    'rabat = dgStavke.Rows(e.RowIndex).Cells(5).Value
                                Else
                                    dgStavke.Rows(e.RowIndex).Cells(6).Value = c_pdv
                                End If
                            End If

                        Else
                            cena = 0
                        End If
                    End If

                    .Rows(e.RowIndex).Cells(7).Value = kol * (cena - rabat) * pdv
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

    Private Function popuni_cenu(ByVal _roba As String) As Decimal
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
    End Function

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
                .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli where sifra = '" & _roba & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                sifra = DR.Item("sifra")
                naziv = DR.Item("naziv")
                cena = DR.Item("cena")
                'trenutna_kolicina = DR.Item("kolicina")
                c_pdv = DR.Item("pdv")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub stanje()
        Dim i As Integer
        Try
            dgStavke.Rows.GetFirstRow(0, 0)
            For i = 0 To dgStavke.Rows.Count - 2
                _nazivi.SetValue(dgStavke.Rows(i).Cells(2).Value.ToString, i, 0)
                _nazivi.SetValue(dgStavke.Rows(i).Cells(3).Value.ToString, i, 1)
                dgStavke.Rows.GetNextRow(i, Windows.Forms.DataGridViewElementStates.Selected)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        proveri_stanje(_nazivi, dgStavke.Rows.Count - 1)
    End Sub

    Private Sub popuni_stavke()
        With dgStavke
            Dim i As Integer
            For i = 0 To (_artikl_lista_ponude.Length / 3) - 1
                .Rows.Add(1)
                If Not IsDBNull(_artikl_lista_ponude(i * 3)) Then .Rows(i).Cells(1).Value = _artikl_lista_ponude(i * 3) '.ToString
                'If Not IsDBNull(DR.Item("kolicina")) Then .Rows(i).Cells(2).Value = DR.Item("kolicina")
                'If Not IsDBNull(_roba_lista_ponude((i * 3) + 1)) Then .Rows(i).Cells(4).Value = CSng(_roba_lista_ponude((i * 3) + 1))
                'If Not IsDBNull(DR.Item("rabat")) Then .Rows(i).Cells(4).Value = DR.Item("rabat")
                'If Not IsDBNull(_roba_lista_ponude((i * 3) + 2)) Then .Rows(i).Cells(6).Value = CInt(_roba_lista_ponude((i * 3) + 2))
                'If Not IsDBNull(_roba_lista_ponude((i * 3) + 1)) Then .Rows(i).Cells(6).Value = CInt(_roba_lista_ponude((i * 3) + 1))
                'If Not IsDBNull(DR.Item("zanaplatu")) Then .Rows(i).Cells(6).Value = DR.Item("zanaplatu")
            Next
        End With

        '_citam_stavke = False
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

        If Not _unesen Then
            txtIznosCena.Text = Format(scena, "##,##0.00")
            txtIznosRabat.Text = Format(srab, "##,##0.00")
            txtOsnovica.Text = Format(scena - srab, "##,##0.00") + ztroskovi
            txtIznosPdv.Text = Format(spdv, "##,##0.00") + ztr_pdv
            txtIznosZanaplatu.Text = Format(scena - srab + spdv, "##,##0.00") + ztroskovi + ztr_pdv + neoporezivo
        End If

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

End Class

