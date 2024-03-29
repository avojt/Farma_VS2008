Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmRadniNalogEdit
    Private mesto As String = ""
    Private telefon As String = ""
    Private adresa As String = ""
    Private sifra As String = ""
    Private naziv As String = ""

    Private _pocetak As Boolean = True


    Private Sub frmRadniNalogEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataSet1.rm_artikli' table. You can move, or remove it, as needed.
        Me.Rm_artikliTableAdapter.Fill(Me.DataSet1.rm_artikli)

        pocetak()
        _pocetak = False
        popuni_stavke()
    End Sub

    Private Sub pocetak()
        '_id_radni_nalog = tId
        '_naziv_partnera = ""

        txtSifra.Text = _broj
        txtAdresa.Text = _adresa_nalog
        txtKm.Text = _kilometraza
        txtKontakt.Text = _kontakt_nalog
        txtMesto.Text = _grad_nalog
        txtObjekat.Text = _objekat
        txtOpis.Text = _opis
        txtRegistracija.Text = _vozilo_registracija
        txtTelefon.Text = _telefon_nalog
        txtVremePolaska.Text = _polazak_vreme
        txtVremePovratka.Text = _povratak_vreme
        txtVozilo.Text = _vozilo_naziv

        datePolazak.Value = _polazak_datum
        datePovratak.Value = _povratak_datum

        chkIspitivanje.Checked = _ispitivanje
        chkMontaza.Checked = _montaza
        chkPopravka.Checked = _popravka
        chkPreventiva.Checked = _preventiva
        chkServisiranje.Checked = _servis

        popuni_parnere()
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
                .CommandText = "select dbo.radni_nalog_materijal.* from dbo.radni_nalog_materijal where dbo.radni_nalog_materijal.id_radninalog = " & _id_radni_nalog
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            _broj_stavki = 0
            Do While DR.Read
                _broj_stavki += 1
            Loop
            DR.Close()

            _id_radni_nalog_materijal = New Integer() {}
            ReDim _id_radni_nalog_materijal(_broj_stavki - 1)

            With dgStavke
                Dim i As Integer = 0
                DR = CM.ExecuteReader

                Do While DR.Read
                    .Rows.Add(1)
                    If Not IsDBNull(DR.Item("id_materijal")) Then _id_radni_nalog_materijal.SetValue(DR.Item("id_materijal"), i)
                    'If Not IsDBNull(DR.Item("rb")) Then .Rows(i).Cells(0).Value = DR.Item("rb")

                    If Not IsDBNull(DR.Item("materijal")) Then
                        popuni_robu(RTrim(DR.Item("materijal")))
                        If naziv <> "" Then
                            .Rows(i).Cells(1).Value = RTrim(naziv)
                        Else
                            .Rows(i).Cells(1).Value = DBNull.Value
                        End If
                    End If

                    'If Not IsDBNull(DR.Item("materijal")) Then .Rows(i).Cells(1).Value = DR.Item("materijal")
                    If Not IsDBNull(DR.Item("kolicina")) Then .Rows(i).Cells(2).Value = DR.Item("kolicina")
                    i += 1
                Loop
            End With
        End If

        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_robu(ByVal _roba As String)
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
                sifra = RTrim(DR.Item("sifra"))
                naziv = DR.Item("naziv")
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
                .CommandText = "rm_radni_nalog_head_update"
                .Parameters.AddWithValue("@id_radninalog", _id_radni_nalog)
                .Parameters.AddWithValue("@broj", txtSifra.Text)
                .Parameters.AddWithValue("@firma", cmbPartneri.Text) ' Partner(cmbPartneri.Text))
                .Parameters.AddWithValue("@mesto", txtMesto.Text)
                .Parameters.AddWithValue("@objekat", txtObjekat.Text)
                .Parameters.AddWithValue("@adresa", txtAdresa.Text)
                .Parameters.AddWithValue("@telefon", txtTelefon.Text)
                .Parameters.AddWithValue("@kontakt", txtKontakt.Text)
                .Parameters.AddWithValue("@monatza", chkMontaza.CheckState)
                .Parameters.AddWithValue("@popravka", chkPopravka.CheckState)
                .Parameters.AddWithValue("@servisiranje", chkServisiranje.CheckState)
                .Parameters.AddWithValue("@ispitivanje", chkIspitivanje.CheckState)
                .Parameters.AddWithValue("@preventiva", chkPreventiva.CheckState)
                .Parameters.AddWithValue("@polazak_datum", datePolazak.Value.Date)
                .Parameters.AddWithValue("@polazak_vreme", txtVremePolaska.Text)
                .Parameters.AddWithValue("@povratak_datum", datePovratak.Value.Date)
                .Parameters.AddWithValue("@povratak_vreme", txtVremePovratka.Text)
                .Parameters.AddWithValue("@vozilo_naziv", txtVozilo.Text)
                .Parameters.AddWithValue("@vozilo_registracija", txtRegistracija.Text)
                .Parameters.AddWithValue("@kilometraza", txtKm.Text)
                .Parameters.AddWithValue("@opis", txtOpis.Text)
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


        CN.Open()
        If _id_radni_nalog_materijal.Length > dgStavke.Rows.Count - 1 Then
            n = _id_radni_nalog_materijal.Length - 1
        Else
            n = dgStavke.Rows.Count - 2
        End If

        For i = 0 To n
            If (i <= dgStavke.Rows.Count - 2 Or Not _id_radni_nalog_materijal.Length > dgStavke.Rows.Count - 1) Or _id_radni_nalog_materijal.Length = 0 Then
                If i > _id_radni_nalog_materijal.Length - 1 Then '_id_racun_stavka(i) = 0 Then
                    CM = New SqlCommand()
                    If CN.State = ConnectionState.Open Then
                        With CM
                            .Connection = CN
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "rm_radni_nalog_materijal_add"
                            .Parameters.AddWithValue("@id_radninalog", _id_radni_nalog) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                            .Parameters.AddWithValue("@rb", dgStavke.Rows(i).Cells(0).Value)
                            .Parameters.AddWithValue("@materijal", dgStavke.Rows(i).Cells(1).Value)
                            .Parameters.AddWithValue("@kolicina", dgStavke.Rows(i).Cells(2).Value)
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
                            .CommandText = "rm_radni_nalog_materijal_update"
                            .Parameters.AddWithValue("@id_materijal", _id_radni_nalog_materijal(i)) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                            '.Parameters.AddWithValue("@id_radninalog", _id_radni_nalog) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                            .Parameters.AddWithValue("@rb", dgStavke.Rows(i).Cells(0).Value)
                            .Parameters.AddWithValue("@materijal", dgStavke.Rows(i).Cells(1).Value)
                            .Parameters.AddWithValue("@kolicina", dgStavke.Rows(i).Cells(2).Value)
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
                        .CommandText = "rm_radni_nalog_materijal_delete"
                        .Parameters.AddWithValue("@id_materijal", _id_radni_nalog_materijal(i)) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
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
            Case "tlbStanje"
                stanje()
                proveri_stanje(_nazivi, dgStavke.Rows.Count - 1)
            Case "tlbEnd"
                Me.Dispose()
        End Select
    End Sub

#Region "partneri"

    Private Sub cmbPartneri_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPartneri.SelectedValueChanged
        selektuj_partnera(cmbPartneri.Text, Selekcija.po_nazivu)
        txtMesto.Text = _partner_mesto
        txtAdresa.Text = _partner_adresa
        txtTelefon.Text = telefon
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
            cmbPartneri.SelectedText = _partner_naziv
        End If
        CM.Dispose()
        CN.Close()
    End Sub

#End Region

#Region "Grid 1"

    Private Sub dgStavke_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgStavke.MouseHover
        If dgStavke.CurrentRow.Displayed Then

            popuni_robu(RTrim(dgStavke.CurrentRow.Cells(1).Value.ToString))
            'dgStavke.CurrentRow.Tag = naziv
            dgStavke.CurrentRow.Cells(1).ToolTipText = naziv
        End If
    End Sub

    Private Sub dgStavke_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgStavke.CellValueChanged
        If Not _pocetak Then
            With dgStavke
                Try
                    '.Rows(e.RowIndex).Cells(0).Value = e.RowIndex + 1
                    redni_broj()
                    popuni_robu(RTrim(dgStavke.Rows(e.RowIndex).Cells(1).Value.ToString))
                    .Rows(e.RowIndex).Cells(1).ToolTipText = naziv

                    If Not IsNothing(dgStavke.Rows(e.RowIndex).Cells(1).Value) Then
                        If dgStavke.Rows(e.RowIndex).Cells(1).Value.ToString <> "" Then
                            If IsNothing(dgStavke.Rows(e.RowIndex).Cells(2).Value) Then
                                dgStavke.Rows(e.RowIndex).Cells(2).Value = 1
                            Else
                                If dgStavke.Rows(e.RowIndex).Cells(2).Value.ToString = "" _
                                    Then dgStavke.Rows(e.RowIndex).Cells(2).Value = 1
                            End If
                        End If
                    End If
                    If Not IsNothing(dgStavke.Rows(e.RowIndex).Cells(2).Value) Then
                        If Not dgStavke.Rows(e.RowIndex).Cells(2).Value.ToString <> "" _
                            And Not jeste_broj(dgStavke.Rows(e.RowIndex).Cells(2).Value.ToString) _
                            Then dgStavke.Rows(e.RowIndex).Cells(2).Value = 1
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End With
        End If
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
    End Sub

#End Region

    Private Sub redni_broj()
        Dim i As Integer

        For i = 0 To dgStavke.RowCount - 2
            dgStavke.Rows(i).Cells(0).Value = i + 1
        Next
    End Sub

    Private Sub stanje()
        Dim i As Integer
        Try
            dgStavke.Rows.GetFirstRow(0, 0)
            For i = 0 To dgStavke.Rows.Count - 2
                _nazivi.SetValue(dgStavke.Rows(i).Cells(1).Value.ToString, i, 0)
                _nazivi.SetValue(dgStavke.Rows(i).Cells(3).Value.ToString, i, 1)
                dgStavke.Rows.GetNextRow(i, Windows.Forms.DataGridViewElementStates.Selected)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class