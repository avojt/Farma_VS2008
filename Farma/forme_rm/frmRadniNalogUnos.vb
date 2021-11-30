Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmRadniNalogUnos
    Private mesto As String = ""
    Private telefon As String = ""
    Private adresa As String = ""
    Private sifra As String = ""
    Private naziv As String = ""

    Private _pocetak As Boolean = True

    Private Sub frmRadniNalogUnos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataSet11.rm_artikli' table. You can move, or remove it, as needed.
        Me.Rm_artikliTableAdapter.Fill(Me.DataSet11.rm_artikli)

        pocetak()
        _pocetak = False
    End Sub

    Private Sub pocetak()
        txtSifra.Text = Nadji_rb(Imena.tabele.rm_radni_nalog_head.ToString, 1)
        txtAdresa.Text = ""
        txtKm.Text = 0
        txtKontakt.Text = ""
        txtMesto.Text = ""
        txtObjekat.Text = ""
        txtOpis.Text = ""
        txtRegistracija.Text = ""
        txtTelefon.Text = ""
        txtVremePolaska.Text = ""
        txtVremePovratka.Text = ""
        txtVozilo.Text = ""

        datePolazak.Value = Today
        datePovratak.Value = Today

        chkIspitivanje.Checked = False
        chkMontaza.Checked = False
        chkPopravka.Checked = False
        chkPreventiva.Checked = False
        chkServisiranje.Checked = False

        popuni_parnere()
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
                .CommandText = "rm_radni_nalog_head_add"
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
                .Parameters.AddWithValue("@potvrda", 0)
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

        _id_radni_nalog = Nadji_id(Imena.tabele.rm_radni_nalog_head.ToString)
        'dgStavke.Rows.GetFirstRow(0, 0)
        For i = 0 To dgStavke.Rows.Count - 2
            CN.Open()
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
            CN.Close()
        Next
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Select Case e.ClickedItem.Name
            Case "tlbSnimi"
                snimi_head()
                snimi_stavku()
                pocetak()
                dgStavke.Rows.Clear()
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
        txtMesto.Text = mesto
        txtAdresa.Text = adresa
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
            cmbPartneri.SelectedIndex = 0
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
                _nazivi.SetValue(dgStavke.Rows(i).Cells(2).Value.ToString, i, 1)
                dgStavke.Rows.GetNextRow(i, Windows.Forms.DataGridViewElementStates.Selected)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

End Class