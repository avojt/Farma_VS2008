Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmPartneriUnos
    Private pozicija As Integer = 0
    Private sql_opstina As String = "SELECT dbo.app_opstine.* FROM dbo.app_opstine"
    Private sql_mesta As String = "SELECT dbo.app_mesta.* FROM dbo.app_mesta"


    Private Sub frmPartneriUnos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()
    End Sub

    Private Sub pocetak()
        txtAdresa.Text = ""
        txtMaticni.Text = ""
        txtNaziv.Text = ""
        txtPib.Text = ""
        txtRegistarski.Text = ""
        txtSifra.Text = ""
        'txtTelefon.Text = ""
        txtZR.Text = ""
        chkDobavljac.Checked = False
        chkKupac.Checked = False
        chkProizvodjac.Checked = False

        popuni_gradove()
        popuni_mesta()
        popuni_opstine()

        txtSifra.Select()

        dgTelKontakt.Rows.Clear()
        dgKontakt.Rows.Clear()
        dgTelefoni.Rows.Clear()
        dgKontakt.Visible = False
        dgTelefoni.Visible = False
        dgTelKontakt.Visible = False

        Me.Bounds = New Rectangle(New Point(100, 100), New Size(445, 360))
        btnTelefoni.Text = ">"
        btnKontakti.Text = ">"

        pozicija = 0
        Dim i As Integer
        For i = 0 To (_kontakt_telefoni.Length / 3) - 1
            _kontakt_telefoni.SetValue("", i, 0)
            _kontakt_telefoni.SetValue("", i, 1)
            _kontakt_telefoni.SetValue("", i, 2)
        Next
    End Sub

    Private Sub popuni_mesta()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbMesto.Items.Clear()
        cmbMesto.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_mesta.* from dbo.app_mesta"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbMesto.Items.Add(DR.Item("mesto_naziv"))
            Loop
            DR.Close()
        End If
        If cmbMesto.Items.Count > 0 Then
            cmbMesto.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub
    Private Sub popuni_opstine()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbOpstina.Items.Clear()
        cmbOpstina.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_opstine.* from dbo.app_opstine"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbOpstina.Items.Add(DR.Item("opstine_naziv"))
            Loop
            DR.Close()
        End If
        If cmbOpstina.Items.Count > 0 Then
            cmbOpstina.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub
    Private Sub popuni_gradove()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbGrad.Items.Clear()
        cmbGrad.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_gradovi.* from dbo.app_gradovi"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbGrad.Items.Add(DR.Item("grad_naziv"))
            Loop
            DR.Close()
        End If
        If cmbGrad.Items.Count > 0 Then
            cmbGrad.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub snimi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "app_partneri_add"
                .Parameters.AddWithValue("@partner_sifra", txtSifra.Text)
                .Parameters.AddWithValue("@partner_naziv", txtNaziv.Text)
                .Parameters.AddWithValue("@partner_adresa", txtAdresa.Text)
                .Parameters.AddWithValue("@partner_mesto", cmbMesto.Text)
                .Parameters.AddWithValue("@partner_pib", txtPib.Text)
                .Parameters.AddWithValue("@partner_maticni", txtMaticni.Text)
                .Parameters.AddWithValue("@partner_registarski", txtRegistarski.Text)
                .Parameters.AddWithValue("@partner_zr", txtZR.Text)
                .Parameters.AddWithValue("@partner_proizvodjac", chkProizvodjac.Checked)
                .Parameters.AddWithValue("@partner_dobavljac", chkDobavljac.Checked)
                .Parameters.AddWithValue("@partner_kupac", chkKupac.Checked)
                .ExecuteScalar()
            End With
            CM.Dispose()

            If dgTelefoni.RowCount > 1 Then
                Dim i As Integer
                For i = 0 To dgTelefoni.Rows.Count - 2
                    CM = New SqlCommand()
                    _id_partner = Nadji_id(Imena.tabele.app_partneri.ToString)
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "app_partneri_telefon_add"
                        .Parameters.AddWithValue("@id_partner", _id_partner)
                        .Parameters.AddWithValue("@telefon", dgTelefoni.Rows(i).Cells(0).Value)
                        .Parameters.AddWithValue("@vrsta", dgTelefoni.Rows(i).Cells(0).Value)
                        .ExecuteScalar()
                    End With
                    CM.Dispose()
                Next
            End If

            If dgKontakt.RowCount > 1 Then
                Dim i As Integer
                For i = 0 To dgKontakt.Rows.Count - 2
                    CM = New SqlCommand()
                    _id_partner = Nadji_id(Imena.tabele.app_partneri.ToString)

                    Dim ime As String = ""
                    If Not IsDBNull(dgKontakt.Rows(i).Cells(0)) And CStr(dgKontakt.Rows(i).Cells(0).Value) <> "" Then
                        ime = CStr(dgKontakt.Rows(i).Cells(0).Value)
                    End If

                    Dim prezime As String = ""
                    If Not IsDBNull(dgKontakt.Rows(i).Cells(1)) And CStr(dgKontakt.Rows(i).Cells(1).Value) <> "" Then
                        prezime = CStr(dgKontakt.Rows(i).Cells(1).Value)
                    End If

                    Dim pozic As String = ""
                    If Not IsDBNull(dgKontakt.Rows(i).Cells(2)) And CStr(dgKontakt.Rows(i).Cells(2).Value) <> "" Then
                        pozic = CStr(dgKontakt.Rows(i).Cells(2).Value)
                    End If

                    'Dim rodjendan As Date= CDate(Today)
                    'If Not IsDBNull(dgKontakt.Rows(i).Cells(3)) And dgKontakt.Rows(i).Cells(3).Value.ToString <> "" Then
                    '    rodjendan = CDate(dgKontakt.Rows(i).Cells(3).Value)
                    'End If
                    Dim ostalo As String = ""
                    If Not IsDBNull(dgKontakt.Rows(i).Cells(4)) And CStr(dgKontakt.Rows(i).Cells(4).Value) <> "" Then
                        ostalo = CStr(dgKontakt.Rows(i).Cells(4).Value)
                    End If

                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "app_partneri_kontakt_add"
                        .Parameters.AddWithValue("@id_partner", _id_partner)
                        .Parameters.AddWithValue("@ime", ime)
                        .Parameters.AddWithValue("@prezime", prezime)
                        .Parameters.AddWithValue("@pozicija", pozic)
                        '.Parameters.AddWithValue("@rodjendan", rodjendan)
                        .Parameters.AddWithValue("@ostalo", ostalo)
                        .ExecuteScalar()
                    End With
                    CM.Dispose()



                    Dim j As Integer
                    For j = 0 To (_kontakt_telefoni.Length / 3) - 1
                        If Not _kontakt_telefoni(j, 0) = Nothing And _kontakt_telefoni(j, 0) = CStr(i) Then
                            CM = New SqlCommand()
                            _id_kontakt = Nadji_id(Imena.tabele.app_partneri_kontakt.ToString)
                            Dim tel As String = ""
                            If Not IsDBNull(_kontakt_telefoni(j, 1)) And CStr(_kontakt_telefoni(j, 1)) <> "" Then
                                tel = CStr(_kontakt_telefoni(j, 1))
                            End If
                            Dim vrsta As String = ""
                            If Not IsDBNull(_kontakt_telefoni(j, 2)) And CStr(_kontakt_telefoni(j, 2)) <> "" Then
                                vrsta = CStr(_kontakt_telefoni(j, 2))
                            End If
                            With CM
                                .Connection = CN
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "app_partneri_kontakt_telefon_add"
                                .Parameters.AddWithValue("@id_kontakt", _id_kontakt)
                                .Parameters.AddWithValue("@telefon", tel)
                                .Parameters.AddWithValue("@vrsta", vrsta)
                                .ExecuteScalar()
                            End With
                            CM.Dispose()
                        End If
                    Next

                Next
            End If
            CN.Close()
        End If
        pocetak()
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Select Case e.ClickedItem.Name
            Case "tlbSnimi"
                snimi()
                pocetak()
            Case "tlbEnd"
                Me.Close()
        End Select
    End Sub

    Private Sub btnTelefoni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTelefoni.Click
        If btnTelefoni.Text = ">" Then
            Me.Bounds = New Rectangle(New Point(100, 100), New Size(790, 360))

            dgTelefoni.Visible = True
            dgTelefoni.Bounds = New Rectangle(New Point(422, 42), New Size(325, 270))
            btnTelefoni.Text = "<"
        Else
            Me.Bounds = New Rectangle(New Point(100, 100), New Size(445, 360))

            dgTelefoni.Visible = False
            btnTelefoni.Text = ">"
        End If

    End Sub

    Private Sub btnKontakti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKontakti.Click
        If btnKontakti.Text = ">" Then
            Me.Bounds = New Rectangle(New Point(100, 100), New Size(790, 520))

            dgTelKontakt.Visible = True
            dgTelKontakt.Bounds = New Rectangle(New Point(422, 42), New Size(325, 270))

            dgKontakt.Visible = True
            dgKontakt.Bounds = New Rectangle(New Point(10, 330), New Size(750, 145))

            btnKontakti.Text = "<"
        Else
            Me.Bounds = New Rectangle(New Point(100, 100), New Size(445, 360))

            dgTelKontakt.Visible = False
            dgKontakt.Visible = False

            btnKontakti.Text = ">"
        End If
    End Sub

    Private Sub dgKontakt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgKontakt.Click
        Dim i As Integer
        dgTelKontakt.Rows.Clear()
        For i = 0 To (_kontakt_telefoni.Length / 3) - 1
            If Not _kontakt_telefoni(i, 0) = "" And _kontakt_telefoni(i, 0) = CStr(dgKontakt.CurrentRow.Index) Then
                Dim j As Integer = 0
                With dgTelKontakt
                    .Rows.Add(1)
                    .Rows(j).Cells(0).Value = _kontakt_telefoni(i, 1)
                    .Rows(j).Cells(1).Value = _kontakt_telefoni(i, 2)
                    j += 1
                End With
            End If
        Next
    End Sub

    Private Sub dgKontakt_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgKontakt.RowLeave
        'dgTelKontakt.Rows.Clear()
        'pozicija = dgKontakt.CurrentRow.Index
    End Sub

    Private Sub dgTelKontakt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTelKontakt.Leave
        If dgTelKontakt.RowCount > 1 Then
            Dim i, j As Integer
            pozicija = 0
            For i = 0 To (_kontakt_telefoni.Length / 3) - 1
                If Not _kontakt_telefoni(i, 0) = "" Then pozicija += 1
            Next

            Dim broj_zapisa As Integer = 0
            For i = 0 To (_kontakt_telefoni.Length / 3) - 1
                If _kontakt_telefoni(i, 0) = CStr(dgKontakt.CurrentRow.Index) Then broj_zapisa += 1
            Next
            Select Case broj_zapisa - dgTelKontakt.RowCount - 2
                Case Is = 0
                    'presnimi postojece
                Case Is < 0
                    'presnimi postojece i
                    'ubaci novi broj
                Case Is > 0
                    'uporedi sve pa razliku obrisi
            End Select

            For i = 0 To dgTelKontakt.RowCount - 2
                For j = 0 To (_kontakt_telefoni.Length / 3) - 1
                    If Not IsDBNull(dgTelKontakt.Rows(i).Cells(0)) And CStr(dgTelKontakt.Rows(i).Cells(0).Value) <> "" Then
                        _kontakt_telefoni.SetValue(CStr(dgKontakt.CurrentRow.Index), i + pozicija, 0)
                        _kontakt_telefoni.SetValue(dgTelKontakt.Rows(i).Cells(0).Value, i + pozicija, 1)
                        _kontakt_telefoni.SetValue(dgTelKontakt.Rows(i).Cells(1).Value, i + pozicija, 2)
                    End If
                Next j
            Next i
        End If
    End Sub

#Region "key press"
    Private Sub txtSifra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSifra.KeyPress
        If e.KeyChar = Chr(13) Then
            txtNaziv.Select()
        End If
    End Sub

    Private Sub txtNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNaziv.KeyPress
        If e.KeyChar = Chr(13) Then
            txtAdresa.Select()
        End If
    End Sub

    Private Sub txtAdresa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdresa.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbGrad.Select()
        End If
    End Sub

    Private Sub cmbGrad_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbGrad.DropDownClosed
        cmbOpstina.Select()
    End Sub

    Private Sub cmbGrad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbGrad.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbOpstina.Select()
        End If
    End Sub

    Private Sub cmbGrad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbGrad.SelectedIndexChanged
        selektuj_grad(cmbGrad.Text, Selekcija.po_nazivu)
        If _id_grad <> 0 Then
            sql_opstina = "SELECT dbo.app_opstine.* FROM dbo.app_opstine where dbo.app_opstine.id_grad = " & _id_grad
            popuni_opstine()
        End If
    End Sub

    Private Sub cmbOpstina_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOpstina.DropDownClosed
        cmbMesto.Select()
    End Sub

    Private Sub cmbOpstina_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbOpstina.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbMesto.Select()
        End If
    End Sub

    Private Sub cmbOpstina_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOpstina.SelectedIndexChanged
        If cmbOpstina.Text <> 0 Then
            selektuj_opstine(cmbOpstina.Text, Selekcija.po_nazivu)
            sql_mesta = "SELECT dbo.app_mesta.* FROM dbo.app_mesta where dbo.app_mesta.id_opstine = " & _id_opstina
            popuni_mesta()
        End If
    End Sub

    Private Sub cmbMesto_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMesto.DropDown
        txtPib.Select()
    End Sub

    Private Sub cmbMesto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMesto.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPib.Select()
        End If
    End Sub

    Private Sub txtPib_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPib.KeyPress
        If e.KeyChar = Chr(13) Then
            txtRegistarski.Select()
        End If
    End Sub

    Private Sub txtRegistarski_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRegistarski.KeyPress
        If e.KeyChar = Chr(13) Then
            txtMaticni.Select()
        End If
    End Sub

    Private Sub txtMaticni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMaticni.KeyPress
        If e.KeyChar = Chr(13) Then
            txtZR.Select()
        End If
    End Sub

    Private Sub txtZR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtZR.KeyPress
        If e.KeyChar = Chr(13) Then
            chkProizvodjac.Select()
        End If
    End Sub

    Private Sub chkProizvodjac_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkProizvodjac.CheckedChanged
        chkDobavljac.Select()
    End Sub

    Private Sub chkProizvodjac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkProizvodjac.KeyPress
        If e.KeyChar = Chr(13) Then
            chkDobavljac.Select()
        End If
    End Sub

    Private Sub chkDobavljac_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDobavljac.CheckedChanged
        chkKupac.Select()
    End Sub

    Private Sub chkDobavljac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkDobavljac.KeyPress
        If e.KeyChar = Chr(13) Then
            chkKupac.Select()
        End If
    End Sub

#End Region

End Class