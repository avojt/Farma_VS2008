Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class cntUlazniRacuni
    Private upit_broj As String = ""
    Private upit_partner As String = ""
    Private upit_broj_fakture As String = ""
    Private upit_datum_fakturisanja As String = ""
    Private upit_iznos As String = ""
    Private upit As String = ""

    Private sql As String = "SELECT * FROM dbo.rm_ulazni_racuni_head"

    Private _pocetak As Boolean = True


    Private Sub cntUlazniRacuni_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Ulazni_racuni_headTableAdapter.Fill(Me.DataSet1.ulazni_racuni_head)

        popuni_parnere()
        pocetak()
        lista()
        _pocetak = False
    End Sub

    Private Sub pocetak()
        txtBrFaktura.Text = ""
        txtBroj.Text = ""
        txtIznos.Text = ""
        cmbPartneri.SelectedIndex = 0
    End Sub

    'Private Sub Ulazni_racuni_headBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Validate()
    '    Me.Ulazni_racuni_headBindingSource.EndEdit()
    '    Me.Ulazni_racuni_headTableAdapter.Update(Me.DataSet1.ulazni_racuni_head)

    'End Sub

    Shared Sub myUpdate()
        If bukmark = 0 Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            selektuj_ulazni_racun(bukmark)
            Dim myChild As New frmUlazniRacuniEdit
            myChild.Show()
        End If
    End Sub

    Shared Sub myDelete()

        If bukmark = 0 Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            Dim poruka As String = "Da li ste sigurno da želite da izbrišete zapis sa sifrom " & bukmark & " ?"
            If MsgBox(poruka, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim CN As SqlConnection = New SqlConnection(CNNString)
                Dim CM As New SqlCommand

                selektuj_ulazni_racun(bukmark)

                CN.Open()
                If CN.State = ConnectionState.Open Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "rm_ulazni_racuni_stavka_delete_racun"
                        .Parameters.AddWithValue("@id_racun_head", _id_racun)
                        .ExecuteScalar()
                    End With
                    CM.Dispose()
                End If

                If CN.State = ConnectionState.Open Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "rm_ulazni_racuni_head_delete"
                        .Parameters.AddWithValue("@id_racun_head", _id_racun)
                        .ExecuteScalar()
                    End With
                    CM.Dispose()
                End If
                CN.Close()

                '_mBindingSource.Filter = ""

                'CM = New SqlCommand()
                'With CM
                '    .Connection = CN
                '    .CommandType = CommandType.Text
                '    .CommandText = "select dbo.rm_radni_nalog_head.* from dbo.rm_radni_nalog_head"
                '    .ExecuteScalar()
                'End With

                '_mTableAdapter.SelectCommand = CM
                '_mTableAdapter.Fill(_mDataSet)
                'CM.Dispose()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub popuni_parnere()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbPartneri.Items.Clear()
        cmbPartneri.Items.Add(" ")
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

    Shared bukmark As Integer
    Private Sub lvRacuni_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvRacuni.Click
        bukmark = lvRacuni.SelectedItems.Item(0).Text
        _id = bukmark
    End Sub


    Private Sub filter()

        On Error Resume Next
        If Not _pocetak Then
            If upit_broj <> "" Then upit = upit_broj

            If upit_partner <> "" And upit <> "" Then
                upit = upit & " and " & upit_partner
            Else
                If upit_partner <> "" Then upit = upit_partner
            End If

            If upit_datum_fakturisanja <> "" And upit <> "" Then
                upit = upit & " and " & upit_datum_fakturisanja
            Else
                If upit_datum_fakturisanja <> "" Then upit = upit_datum_fakturisanja
            End If

            If upit_iznos <> "" And upit <> "" Then
                upit = upit & " and " & upit_iznos
            Else
                If upit_iznos <> "" Then upit = upit_iznos
            End If

            If upit_broj_fakture <> "" And upit <> "" Then
                upit = upit & " and " & upit_broj_fakture
            Else
                If upit_broj_fakture <> "" Then upit = upit_broj_fakture
            End If

            If upit <> "" Then
                sql = "SELECT * FROM dbo.rm_ulazni_racuni_head where dbo.rm_ulazni_racuni_head." & upit
            End If
            lista()

            'Me.Ulazni_racuni_headBindingSource.Filter = upit
            'Me.Ulazni_racuni_headTableAdapter.Update(Me.DataSet1.ulazni_racuni_head)
            'Me.Ulazni_racuni_headTableAdapter.Fill(Me.DataSet1.ulazni_racuni_head)

        End If
        upit = ""
        sql = "SELECT * FROM dbo.rm_ulazni_racuni_head"
    End Sub

    Private Sub lista()

        lvRacuni.Items.Clear()

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = Sql
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            While DR.Read
                Dim podatak As New ListViewItem(CStr(DR.Item("sifra")), 0)
                podatak.SubItems.Add(Partner_naziv(DR.Item("id_partner")))
                podatak.SubItems.Add(DR.Item("br_fakture"))
                podatak.SubItems.Add(DR.Item("datum_fakturisanja"))
                podatak.SubItems.Add(DR.Item("datum_valuta"))
                podatak.SubItems.Add(DR.Item("iznos_cena"))
                podatak.SubItems.Add(DR.Item("iznos_rabat"))
                podatak.SubItems.Add(DR.Item("iznos_pdv"))
                podatak.SubItems.Add(DR.Item("iznos_zanaplatu"))
                podatak.SubItems.Add(DR.Item("napomena"))
                podatak.SubItems.Add(da_ne(DR.Item("unesen")))
                podatak.SubItems.Add(da_ne(DR.Item("placeno")))

                lvRacuni.Items.AddRange(New ListViewItem() {podatak}) ', item2, item3})
            End While
            DR.Close()
        End If

        CM.Dispose()
        CN.Close()

        _lista = lvRacuni
    End Sub

    Shared Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function

    Private Sub txtBroj_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBroj.TextChanged
        If Not _pocetak Then
            If txtBroj.Text <> "" Then
                upit_broj = "sifra = " & txtBroj.Text
            Else
                upit_broj = ""
            End If
            filter()
        End If
    End Sub

    Private Sub dateFakturisanje_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateFakturisanje.ValueChanged
        If Not _pocetak Then
            upit_datum_fakturisanja = "datum_fakturisanja = '" & _
                dateFakturisanje.Value.Month.ToString & "/" & _
                dateFakturisanje.Value.Day.ToString & "/" & _
                dateFakturisanje.Value.Year.ToString & "'"
            filter()
        End If
    End Sub

    Private Sub txtIznos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIznos.TextChanged
        If Not _pocetak Then
            If txtIznos.Text <> "" And jeste_broj(txtIznos.Text) Then
                upit_iznos = "iznos_zanaplatu > " & txtIznos.Text
            Else
                upit_iznos = ""
            End If
            filter()
        End If
    End Sub

    Private Sub cmbPartneri_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPartneri.SelectedIndexChanged
        If Not _pocetak Then
            If cmbPartneri.Text <> " " Then
                upit_partner = "id_partner = " & Partner_id(cmbPartneri.Text)
            Else
                upit_partner = ""
            End If
            filter()
        End If
    End Sub

    Private Sub txtBrFaktura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBrFaktura.TextChanged
        If Not _pocetak Then
            If txtIznos.Text <> "" Then
                upit_broj_fakture = "br_fakture = '" & txtIznos.Text & "'"
            Else
                upit_broj_fakture = ""
            End If
            filter()
        End If
    End Sub

    'Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim CN As SqlConnection = New SqlConnection(CNNString)
    '    Dim CM As New SqlCommand

    '    CN.Open()
    '    CM = New SqlCommand()
    '    If CN.State = ConnectionState.Open Then
    '        With CM
    '            .Connection = CN
    '            .CommandType = CommandType.StoredProcedure
    '            .CommandText = "ulazni_racun_stavka_delete_racun"
    '            .Parameters.AddWithValue("@id_racun_head", Ulazni_racuni_headDataGridView.CurrentRow.Cells(0).Value)
    '            .ExecuteScalar()
    '        End With
    '    End If

    '    Me.Validate()
    '    Me.Ulazni_racuni_headBindingSource.EndEdit()
    '    Me.Ulazni_racuni_headTableAdapter.Delete(Ulazni_racuni_headDataGridView.CurrentRow.Cells(0).Value, _
    '                                     Ulazni_racuni_headDataGridView.CurrentRow.Cells(1).Value, _
    '                                     Ulazni_racuni_headDataGridView.CurrentRow.Cells(2).Value, _
    '                                     Ulazni_racuni_headDataGridView.CurrentRow.Cells(3).Value, _
    '                                     Ulazni_racuni_headDataGridView.CurrentRow.Cells(4).Value, _
    '                                     Ulazni_racuni_headDataGridView.CurrentRow.Cells(5).Value, _
    '                                     Ulazni_racuni_headDataGridView.CurrentRow.Cells(6).Value, _
    '                                     Ulazni_racuni_headDataGridView.CurrentRow.Cells(7).Value, _
    '                                     Ulazni_racuni_headDataGridView.CurrentRow.Cells(8).Value, _
    '                                     Ulazni_racuni_headDataGridView.CurrentRow.Cells(9).Value, _
    '                                     Ulazni_racuni_headDataGridView.CurrentRow.Cells(10).Value, _
    '                                     Ulazni_racuni_headDataGridView.CurrentRow.Cells(11).Value, _
    '                                     Ulazni_racuni_headDataGridView.CurrentRow.Cells(12).Value)
    '    Me.Ulazni_racuni_headTableAdapter.Update(Me.DataSet1.ulazni_racuni_head)
    'End Sub

    'Private Sub BindingNavigatorRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Ulazni_racuni_headBindingSource.Filter = ""
    '    Me.Ulazni_racuni_headTableAdapter.Fill(Me.DataSet1.ulazni_racuni_head)
    'End Sub

    Private Sub picRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRefresh.Click
        sql = "SELECT * FROM dbo.rm_ulazni_racuni_head"
        lista()
        pocetak()
    End Sub
   
    Private Sub picRefresh_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRefresh.MouseHover
        picRefresh.Image = Global.Farma.My.Resources.Resources.reload
        picRefresh.Cursor = Cursors.Hand
    End Sub

    Private Sub picRefresh_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRefresh.MouseLeave
        picRefresh.Image = Global.Farma.My.Resources.Resources.reload1
        picRefresh.Cursor = Cursors.Default
    End Sub
End Class
