Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntRacuni
    Private upit_broj As String = ""
    Private upit_partner As String = ""
    Private upit_datum_fakturisanja As String = ""
    Private upit_iznos As String = ""
    Private upit As String = ""

    Private upit_broj_pred As String = ""
    Private upit_partner_pred As String = ""
    Private upit_datum_fakturisanja_pred As String = ""
    Private upit_iznos_pred As String = ""
    Private upit_pred As String = ""

    Private upit_broj_povrat As String = ""
    Private upit_partner_povrat As String = ""
    Private upit_datum_fakturisanja_povrat As String = ""
    Private upit_iznos_povrat As String = ""
    Private upit_povrat As String = ""

    Private sql As String = "SELECT * FROM dbo.rm_racun_head"
    Private sql_pred As String = "SELECT * FROM dbo.rm_predracun_head"
    Private sql_povratnica As String = "SELECT * FROM dbo.rm_povratnica_head"

    Private _pocetak As Boolean = True

    Private Sub cntRacuni_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TableLayoutPanel3.Dock = DockStyle.Fill
        pocetak()
        _pocetak = False
        lista_pred()
    End Sub

    Private Sub pocetak()
        txtBroj1.Text = ""
        txtIznos1.Text = ""
        popuni_parnere_racuni()
        cmbPartneri1.SelectedIndex = 0
    End Sub

    Private Sub tabControl_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabControl.TabIndexChanged
        Select Case tabControl.SelectedIndex   'tabControl1.TabIndex
            Case 0 ' "tabPredracuni"
                _tab = Imena.tabele.rm_predracun.ToString
                pocetak()
                lista_pred()
            Case 1 '"tabRacuni"
                _tab = Imena.tabele.rm_racun.ToString
                pocetak()
                lista()
            Case 2 '"tabRacuni"
                _tab = Imena.tabele.rm_povratnica.ToString
                pocetak()
                lista_povratnica()
        End Select
    End Sub

    Private Sub tabControl1_SelectedIndexChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabControl.SelectedIndexChanged
        Select Case tabControl.SelectedIndex   'tabControl1.TabIndex
            Case 0 ' "tabPredracuni"
                _tab = Imena.tabele.rm_predracun.ToString
                pocetak()
                lista_pred()
            Case 1 '"tabRacuni"
                _tab = Imena.tabele.rm_racun.ToString
                pocetak()
                lista()
            Case 2 '"tabRacuni"
                _tab = Imena.tabele.rm_povratnica.ToString
                pocetak()
                lista_povratnica()
        End Select
    End Sub

    Shared Sub myUpdate()
        If bukmark = 0 Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            Select Case _tab
                Case Imena.tabele.rm_racun.ToString
                    selektuj_racun(bukmark)
                    Dim myChild As New frmRacuniEdit
                    myChild.Show()
                Case Imena.tabele.rm_predracun.ToString
                    selektuj_predracun(bukmark)
                    Dim myChild As New frmPredracunEdit
                    myChild.Show()
                Case Imena.tabele.rm_povratnica.ToString
                    'selektuj_povratnicu(bukmark)
                    'Dim myChild As New frmPovratnicaEdit
                    'myChild.Show()
            End Select
        End If
    End Sub

    Shared Sub myDelete()
        If bukmark = 0 Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            Dim poruka As String = "Da li ste sigurno da želite da izbrišete zapis sa sifrom " & bukmark & " ?"
            If MsgBox(poruka, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Select Case _tab
                    Case Imena.tabele.rm_racun.ToString
                        selektuj_racun(bukmark)

                        Dim CN As SqlConnection = New SqlConnection(CNNString)
                        Dim CM As New SqlCommand

                        CN.Open()
                        If CN.State = ConnectionState.Open Then
                            CM = New SqlCommand()
                            With CM
                                .Connection = CN
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "rm_racun_stavka_delete_racun"
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
                                .CommandText = "rm_racun_head_delete"
                                .Parameters.AddWithValue("@id_racun_head", _id_racun)
                                .ExecuteScalar()
                            End With
                            CM.Dispose()
                        End If

                    Case Imena.tabele.rm_predracun.ToString
                        selektuj_predracun(bukmark)

                        Dim CN As SqlConnection = New SqlConnection(CNNString)
                        Dim CM As New SqlCommand

                        CN.Open()
                        If CN.State = ConnectionState.Open Then
                            CM = New SqlCommand()
                            With CM
                                .Connection = CN
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "rm_predracun_stavka_delete_predracun"
                                .Parameters.AddWithValue("@id_predracun_head", _id_predracun)
                                .ExecuteScalar()
                            End With
                            CM.Dispose()
                        End If

                        If CN.State = ConnectionState.Open Then
                            CM = New SqlCommand()
                            With CM
                                .Connection = CN
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "rm_predracun_head_delete"
                                .Parameters.AddWithValue("@id_predracun_head", _id_predracun)
                                .ExecuteScalar()
                            End With
                            CM.Dispose()
                        End If

                    Case Imena.tabele.rm_povratnica.ToString
                        'selektuj_povratnicu(bukmark)

                        'Dim CN As SqlConnection = New SqlConnection(CNNString)
                        'Dim CM As New SqlCommand

                        'CN.Open()
                        'If CN.State = ConnectionState.Open Then
                        '    CM = New SqlCommand()
                        '    'With CM
                        '    '    .Connection = CN
                        '    '    .CommandType = CommandType.StoredProcedure
                        '    '    .CommandText = "rm_povratnica_stavka_delete_povratnicu"
                        '    '    .Parameters.AddWithValue("@id_povratnica_head", _id_povratnica)
                        '    '    .ExecuteScalar()
                        '    'End With
                        '    CM.Dispose()
                        'End If

                        'If CN.State = ConnectionState.Open Then
                        '    CM = New SqlCommand()
                        '    'With CM
                        '    '    .Connection = CN
                        '    '    .CommandType = CommandType.StoredProcedure
                        '    '    .CommandText = "rm_povratnica_head_delete"
                        '    '    .Parameters.AddWithValue("@id_povratnica_head", _id_povratnica)
                        '    '    .ExecuteScalar()
                        '    'End With
                        '    CM.Dispose()
                        'End If

                End Select
            Else
                Exit Sub
            End If
        End If
    End Sub

    Shared Sub racun_prn()
        If bukmark = 0 Then
            MsgBox("Prvo morate izabrati stavku koji želite da štampate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            selektuj_racun(bukmark)
            racun_print()
        End If
    End Sub

    Shared Sub povratnica_prn()
        If bukmark = 0 Then
            MsgBox("Prvo morate izabrati stavku koji želite da štampate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            'selektuj_povratnicu(bukmark)
            'povratnica_print()
        End If
    End Sub

    Private Sub popuni_parnere_racuni()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbPartneri1.Items.Clear()
        cmbPartneri1.Items.Add(" ")
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
                cmbPartneri1.Items.Add(DR.Item("partner_naziv"))
            Loop
            DR.Close()
        End If
        If cmbPartneri1.Items.Count > 0 Then
            cmbPartneri1.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Function Partner(ByVal _partner) As Integer
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_partneri.* from dbo.app_partneri where naziv = '" & _partner & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                Partner = DR.Item("id_partner")
            Loop
        End If
        CM.Dispose()
        CN.Close()
    End Function

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

            If upit <> "" Then
                Select Case _tab
                    Case Imena.tabele.rm_predracun.ToString
                        sql_pred = "SELECT * FROM dbo.rm_predracun_head where dbo.rm_predracun_head." & upit
                        lista_pred()
                    Case Imena.tabele.rm_racun.ToString
                        sql = "SELECT * FROM dbo.rm_racun_head where dbo.rm_racun_head." & upit
                        lista()
                End Select
                'sql = "SELECT * FROM dbo.rm_racun_head where dbo.rm_racun_head." & upit
            End If
            'lista()

        End If
        upit = ""
        upit_datum_fakturisanja = ""
        sql = "SELECT * FROM dbo.rm_racun_head"
        sql_pred = "SELECT * FROM dbo.rm_predracun_head"
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
                .CommandText = sql
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            While DR.Read
                Dim podatak As New ListViewItem(CStr(DR.Item("sifra")), 0)
                podatak.SubItems.Add(Partner_naziv(DR.Item("id_partner")))
                podatak.SubItems.Add(DR.Item("datum_fakturisanja"))
                podatak.SubItems.Add(DR.Item("datum_prometa"))
                podatak.SubItems.Add(DR.Item("valuta"))
                podatak.SubItems.Add(DR.Item("iznos_cena"))
                podatak.SubItems.Add(DR.Item("iznos_rabat"))
                podatak.SubItems.Add(DR.Item("iznos_pdv"))
                podatak.SubItems.Add(DR.Item("iznos_zanaplatu"))
                podatak.SubItems.Add(DR.Item("napomena"))
                podatak.SubItems.Add(da_ne(DR.Item("izdat")))
                podatak.SubItems.Add(da_ne(DR.Item("placeno")))

                lvRacuni.Items.AddRange(New ListViewItem() {podatak}) ', item2, item3})
            End While
            DR.Close()
        End If

        CM.Dispose()
        CN.Close()

        _lista = lvRacuni
    End Sub

    Private Sub filter_pred()

        On Error Resume Next
        If Not _pocetak Then
            If upit_broj_pred <> "" Then upit_pred = upit_broj_pred

            If upit_partner_pred <> "" And upit_pred <> "" Then
                upit_pred = upit_pred & " and " & upit_partner_pred
            Else
                If upit_partner_pred <> "" Then upit_pred = upit_partner_pred
            End If

            If upit_datum_fakturisanja_pred <> "" And upit_pred <> "" Then
                upit_pred = upit_pred & " and " & upit_datum_fakturisanja_pred
            Else
                If upit_datum_fakturisanja_pred <> "" Then upit_pred = upit_datum_fakturisanja_pred
            End If

            If upit_iznos_pred <> "" And upit_pred <> "" Then
                upit_pred = upit_pred & " and " & upit_iznos_pred
            Else
                If upit_iznos_pred <> "" Then upit_pred = upit_iznos_pred
            End If

            If upit_pred <> "" Then
                sql_pred = "SELECT * FROM dbo.rm_predracun_head where dbo.rm_predracun_head." & upit
            End If
            lista_pred()

        End If
        upit_pred = ""
        sql_pred = "SELECT * FROM dbo.rm_predracun_head"
    End Sub

    Private Sub lista_pred()

        lvPredracuni.Items.Clear()

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql_pred
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            While DR.Read
                Dim podatak As New ListViewItem(CStr(DR.Item("sifra")), 0)
                podatak.SubItems.Add(Partner_naziv(DR.Item("id_partner")))
                podatak.SubItems.Add(DR.Item("datum_fakturisanja"))
                podatak.SubItems.Add(DR.Item("datum_prometa"))
                podatak.SubItems.Add(DR.Item("valuta"))
                podatak.SubItems.Add(DR.Item("iznos_cena"))
                podatak.SubItems.Add(DR.Item("iznos_rabat"))
                podatak.SubItems.Add(DR.Item("iznos_pdv"))
                podatak.SubItems.Add(DR.Item("iznos_zanaplatu"))
                podatak.SubItems.Add(DR.Item("napomena").ToString)

                lvPredracuni.Items.AddRange(New ListViewItem() {podatak}) ', item2, item3})
            End While
            DR.Close()
        End If

        CM.Dispose()
        CN.Close()

        _lista = lvPredracuni
    End Sub

    Private Sub filter_povratnica()

        On Error Resume Next
        If Not _pocetak Then
            If upit_broj_povrat <> "" Then upit_povrat = upit_broj_povrat

            If upit_partner_povrat <> "" And upit_povrat <> "" Then
                upit_pred = upit_povrat & " and " & upit_partner_povrat
            Else
                If upit_partner_povrat <> "" Then upit_povrat = upit_partner_povrat
            End If

            If upit_datum_fakturisanja_povrat <> "" And upit_povrat <> "" Then
                upit_povrat = upit_povrat & " and " & upit_datum_fakturisanja_povrat
            Else
                If upit_datum_fakturisanja_povrat <> "" Then upit_povrat = upit_datum_fakturisanja_povrat
            End If

            If upit_iznos_povrat <> "" And upit_povrat <> "" Then
                upit_pred = upit_povrat & " and " & upit_iznos_povrat
            Else
                If upit_iznos_povrat <> "" Then upit_povrat = upit_iznos_povrat
            End If

            If upit_povrat <> "" Then
                sql_povratnica = "SELECT * FROM dbo.rm_povratnica_head where dbo.rm_povratnica_head." & upit_povrat
            End If
            lista_povratnica()

        End If
        upit_povrat = ""
        sql_povratnica = "SELECT * FROM dbo.rm_povratnica_head"
    End Sub

    Private Sub lista_povratnica()

        lvPovratnice.Items.Clear()

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql_povratnica
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            While DR.Read
                Dim podatak As New ListViewItem(CStr(DR.Item("sifra")), 0)
                podatak.SubItems.Add(Partner_naziv(DR.Item("id_partner")))
                podatak.SubItems.Add(DR.Item("datum_fakturisanja"))
                podatak.SubItems.Add(DR.Item("datum_prometa"))
                podatak.SubItems.Add(DR.Item("valuta"))
                podatak.SubItems.Add(DR.Item("iznos_cena"))
                podatak.SubItems.Add(DR.Item("iznos_rabat"))
                podatak.SubItems.Add(DR.Item("iznos_pdv"))
                podatak.SubItems.Add(DR.Item("iznos_zanaplatu"))
                podatak.SubItems.Add(DR.Item("napomena").ToString)
                podatak.SubItems.Add(DR.Item("po_racunu_br").ToString)
                podatak.SubItems.Add(DR.Item("od_datuma").ToString)

                lvPovratnice.Items.AddRange(New ListViewItem() {podatak}) ', item2, item3})
            End While
            DR.Close()
        End If

        CM.Dispose()
        CN.Close()

        _lista = lvPredracuni
    End Sub

    Shared Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function

    Shared bukmark As Integer
    Private Sub lvRacuni_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvRacuni.Click
        bukmark = lvRacuni.SelectedItems.Item(0).Text
        _id = bukmark
    End Sub
    Private Sub lvPredracuni_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvPredracuni.Click
        bukmark = lvPredracuni.SelectedItems.Item(0).Text
        _id = bukmark
    End Sub
    Private Sub lvPovratnice_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvPovratnice.Click
        bukmark = lvPovratnice.SelectedItems.Item(0).Text
        _id = bukmark
    End Sub

    Private Sub txtBroj1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBroj1.TextChanged
        If Not _pocetak Then
            If txtBroj1.Text <> "" Then
                upit_broj = "sifra = " & txtBroj1.Text '& "%"
            Else
                upit_broj = ""
            End If
            filter()
        End If
    End Sub

    Private Sub cmbPartneri1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPartneri1.SelectedIndexChanged
        If Not _pocetak Then
            If cmbPartneri1.Text <> " " Then
                upit_partner = "id_partner = " & Partner(cmbPartneri1.Text)
            Else
                upit_partner = ""
            End If
            filter()
        End If
    End Sub

    Private Sub dateFakturisanje1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateFakturisanje1.ValueChanged
        If Not _pocetak Then
            upit_datum_fakturisanja = "datum_fakturisanja = '" & _
                dateFakturisanje1.Value.Month.ToString & "/" & _
                dateFakturisanje1.Value.Day.ToString & "/" & _
                dateFakturisanje1.Value.Year.ToString & "'"
            filter()
        End If
    End Sub

    Private Sub txtIznos1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIznos1.TextChanged
        If Not _pocetak Then
            If txtIznos1.Text <> "" And jeste_broj(txtIznos1.Text) Then
                upit_iznos = "iznos_zanaplatu > " & txtIznos1.Text
            Else
                upit_iznos = ""
            End If
            filter()
        End If
    End Sub

    Private Sub picRefresh1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRefresh1.Click
        Select Case _tab
            Case Imena.tabele.rm_predracun.ToString
                sql_pred = "SELECT * FROM dbo.rm_predracun_head"
                lista_pred()
            Case Imena.tabele.rm_racun.ToString
                sql = "SELECT * FROM dbo.rm_racun_head"
                lista()
            Case Imena.tabele.rm_povratnica.ToString
                sql_povratnica = "SELECT * FROM dbo.rm_povratnica_head"
                lista_povratnica()
        End Select
        pocetak()
    End Sub

    Private Sub picRefresh1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRefresh1.MouseHover
        picRefresh1.Image = Global.Farma.My.Resources.Resources.reload
        picRefresh1.Cursor = Cursors.Hand
    End Sub

    Private Sub picRefresh1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRefresh1.MouseLeave
        picRefresh1.Image = Global.Farma.My.Resources.Resources.reload1
        picRefresh1.Cursor = Cursors.Default
    End Sub

    
    
   
End Class
