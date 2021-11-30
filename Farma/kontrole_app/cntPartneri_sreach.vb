Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO

Public Class cntPartneri_sreach

#Region "dekleracija"
    Shared upit As String = ""
    Shared upit_sifra As String = ""
    Shared upit_naziv As String = ""
    Shared upit_adresa As String = ""
    Shared upit_mesto As String = ""
    Shared upit_opstina As String = ""
    Shared upit_proizvodjac As String = ""
    Shared upit_dobavljac As String = ""
    Shared upit_kupac As String = ""

    Shared sql_start As String = _
                "SELECT * FROM dbo.app_partneri"

    Shared sql As String = ""
    Private _pocetak As Boolean = True
    Shared _poABCedi As Boolean = False
    Private aktivan_chk As Boolean
#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntPartneri_sreach_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        popuni_mesta()
        popuni_opstine()

        txtSifra.Enabled = False
        txtSifra.BackColor = Color.Lavender
        txtNaziv.Enabled = False
        txtNaziv.BackColor = Color.Lavender
        txtAdresa.Enabled = False
        txtAdresa.BackColor = Color.Lavender
        cmbMesto.Enabled = False
        cmbMesto.BackColor = Color.Lavender
        cmbOpstina.Enabled = False
        cmbOpstina.BackColor = Color.Lavender

        chkDobavljac.CheckState = CheckState.Unchecked
        chkKupac.CheckState = CheckState.Unchecked
        chkProizvodjac.CheckState = CheckState.Unchecked
        chkABC.CheckState = CheckState.Unchecked
        chkAdresa.CheckState = CheckState.Unchecked
        chkMesto.CheckState = CheckState.Unchecked
        chkNaziv.CheckState = CheckState.Unchecked
        chkOpstina.CheckState = CheckState.Unchecked
        chkSifra.CheckState = CheckState.Unchecked

        _lCount = labCount

        mPanel.Dock = DockStyle.Fill
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
            'selektuj_mesto(_partner_mesto, Selekcija.po_nazivu)
            cmbMesto.SelectedText = _partner_mesto
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
            'selektuj_mesto(_partner_mesto, Selekcija.po_nazivu)
            cmbOpstina.SelectedText = _partner_opstina
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Shared Sub filter()
        On Error Resume Next

        upit = ""
        sql = ""

        If upit_sifra <> "" And upit <> "" Then
            upit = upit & " and " & upit_sifra
        Else
            If upit_sifra <> "" Then upit = upit_sifra
        End If

        If upit_naziv <> "" And upit <> "" Then
            upit = upit & " and " & upit_naziv
        Else
            If upit_naziv <> "" Then upit = upit_naziv
        End If

        If upit_mesto <> "" And upit <> "" Then
            upit = upit & " and " & upit_mesto
        Else
            If upit_mesto <> "" Then upit = upit_mesto
        End If

        If upit_opstina <> "" And upit <> "" Then
            upit = upit & " and " & upit_opstina
        Else
            If upit_opstina <> "" Then upit = upit_opstina
        End If

        If upit_adresa <> "" And upit <> "" Then
            upit = upit & " and " & upit_adresa
        Else
            If upit_adresa <> "" Then upit = upit_adresa
        End If

        If upit_proizvodjac <> "" And upit <> "" Then
            upit = upit & " and " & upit_proizvodjac
        Else
            If upit_proizvodjac <> "" Then upit = upit_proizvodjac
        End If

        If upit_dobavljac <> "" And upit <> "" Then
            upit = upit & " and " & upit_dobavljac
        Else
            If upit_dobavljac <> "" Then upit = upit_dobavljac
        End If

        If upit_kupac <> "" And upit <> "" Then
            upit = upit & " and " & upit_kupac
        Else
            If upit_kupac <> "" Then upit = upit_kupac
        End If

        sql = sql_start
        If upit <> "" Then
            sql += " WHERE " & upit
        End If
        If _poABCedi Then
            sql += " ORDER BY app_partneri.partner_naziv"
        Else
            sql += " ORDER BY app_partneri.partner_sifra"
        End If

        Lista()

    End Sub

    Shared Sub Lista()

        _lista.Visible = True
        _lista.Items.Clear()

        If sql <> "" Then
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
                    DR = .ExecuteReader
                End With

                While DR.Read
                    Dim podatak As New ListViewItem(CStr(DR.Item("partner_sifra")))

                    podatak.SubItems.Add(DR.Item("partner_naziv").ToString)
                    podatak.SubItems.Add(DR.Item("partner_mesto").ToString)
                    podatak.SubItems.Add(DR.Item("partner_pib").ToString)
                    If Not IsDBNull(DR.Item("partner_proizvodjac")) Then
                        podatak.SubItems.Add(da_ne(DR.Item("partner_proizvodjac")).ToString)
                    Else
                        podatak.SubItems.Add("")
                    End If
                    If Not IsDBNull(DR.Item("partner_dobavljac")) Then
                        podatak.SubItems.Add(da_ne(DR.Item("partner_dobavljac")).ToString)
                    Else
                        podatak.SubItems.Add("")
                    End If
                    If Not IsDBNull(DR.Item("partner_kupac")) Then
                        podatak.SubItems.Add(da_ne(DR.Item("partner_kupac")).ToString)
                    Else
                        podatak.SubItems.Add("")
                    End If

                    _lista.Items.AddRange(New ListViewItem() {podatak})

                End While
                DR.Close()
            End If

            CM.Dispose()
            CN.Close()
        End If

        _lCount.Text = _lista.Items.Count.ToString + " zapisa"

    End Sub

    Shared Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function

    Private Sub chkABC_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkABC.CheckedChanged
        filter()
    End Sub

    Private Sub chkSifra_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSifra.CheckedChanged
        Select Case chkSifra.CheckState
            Case CheckState.Checked
                txtSifra.Enabled = True
                txtSifra.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                txtSifra.Enabled = False
                txtSifra.BackColor = Color.Lavender
                upit_sifra = ""
                txtSifra.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub chkNaziv_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNaziv.CheckedChanged
        Select Case chkNaziv.CheckState
            Case CheckState.Checked
                txtNaziv.Enabled = True
                txtNaziv.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                txtNaziv.Enabled = False
                txtNaziv.BackColor = Color.Lavender
                upit_naziv = ""
                txtNaziv.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub chkAdresa_ClientSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAdresa.ClientSizeChanged
        Select Case chkAdresa.CheckState
            Case CheckState.Checked
                txtAdresa.Enabled = True
                txtAdresa.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                txtAdresa.Enabled = False
                txtAdresa.BackColor = Color.Lavender
                upit_adresa = ""
                txtAdresa.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub chkOpstina_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkOpstina.CheckedChanged
        Select Case chkOpstina.CheckState
            Case CheckState.Checked
                cmbOpstina.Enabled = True
                cmbOpstina.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbOpstina.Enabled = False
                cmbOpstina.BackColor = Color.Lavender
                upit_opstina = ""
                cmbOpstina.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub chkMesto_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMesto.CheckedChanged
        Select Case chkMesto.CheckState
            Case CheckState.Checked
                cmbMesto.Enabled = True
                cmbMesto.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbMesto.Enabled = False
                cmbMesto.BackColor = Color.Lavender
                upit_mesto = ""
                cmbMesto.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub txtSifra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSifra.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtSifra.Text <> "" Then
                upit_sifra = "app_partneri.partner_sifra LIKE N'%" & txtSifra.Text & "%'"
            Else
                upit_sifra = ""
            End If
            filter()
        End If
    End Sub
    Private Sub txtSifra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSifra.TextChanged
        If txtSifra.Text <> "" Then
            upit_sifra = "app_partneri.partner_sifra LIKE N'%" & txtSifra.Text & "%'"
        Else
            upit_sifra = ""
        End If
        filter()
    End Sub

    Private Sub txtNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNaziv.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtNaziv.Text <> "" Then
                upit_naziv = "app_partneri.partner_naziv LIKE N'" & txtNaziv.Text & "%'"
            Else
                upit_naziv = ""
            End If
            filter()
        End If
    End Sub
    Private Sub txtNaziv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNaziv.TextChanged
        If txtNaziv.Text <> "" Then
            upit_naziv = "app_partneri.partner_naziv LIKE N'" & txtNaziv.Text & "%'"
        Else
            upit_naziv = ""
        End If
    End Sub

    Private Sub txtAdresa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdresa.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtAdresa.Text <> "" Then
                upit_adresa = "app_partneri.partner_adresa LIKE N'%" & txtAdresa.Text & "%'"
            Else
                upit_adresa = ""
            End If
            filter()
        End If
    End Sub
    Private Sub txtAdresa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdresa.TextChanged
        If txtAdresa.Text <> "" Then
            upit_adresa = "app_partneri.partner_adresa LIKE N'%" & txtAdresa.Text & "%'"
        Else
            upit_adresa = ""
        End If
    End Sub

    Private Sub cmbOpstina_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbOpstina.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbOpstina.Text <> "" Then
                upit_opstina = "app_partneri.partner_opstina LIKE N'%" & cmbOpstina.Text & "%'"
            Else
                upit_opstina = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbOpstina_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOpstina.SelectedIndexChanged
        If cmbOpstina.Text <> "" Then
            upit_opstina = "app_partneri.partner_opstina LIKE N'%" & cmbOpstina.Text & "%'"
        Else
            upit_opstina = ""
        End If
    End Sub

    Private Sub cmbMesto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMesto.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbMesto.Text <> "" Then
                upit_mesto = "app_partneri.partner_mesto LIKE N'%" & cmbMesto.Text & "%'"
            Else
                upit_mesto = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbMesto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMesto.SelectedIndexChanged
        If cmbMesto.Text <> "" Then
            upit_mesto = "app_partneri.partner_mesto LIKE N'%" & cmbMesto.Text & "%'"
        Else
            upit_mesto = ""
        End If
    End Sub

    Private Sub chkProizvodjac_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProizvodjac.CheckedChanged
        Select Case chkProizvodjac.CheckState
            Case CheckState.Checked
                upit_proizvodjac = "app_partneri.partner_proizvodjac = 1"
            Case CheckState.Unchecked
                upit_proizvodjac = "" ' "app_partneri.partner_proizvodjac = 0"
        End Select
    End Sub

    Private Sub chkDobavljac_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDobavljac.CheckedChanged
        Select Case chkDobavljac.CheckState
            Case CheckState.Checked
                upit_dobavljac = "app_partneri.partner_dobavljac = 1"
            Case CheckState.Unchecked
                upit_dobavljac = "" ' "app_partneri.partner_dobavljac = 0"
        End Select
    End Sub

    Private Sub chkKupac_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkKupac.CheckedChanged
        Select Case chkKupac.CheckState
            Case CheckState.Checked
                upit_kupac = "app_partneri.partner_kupac = 1"
            Case CheckState.Unchecked
                upit_kupac = "" ' "app_partneri.partner_kupac = 0"
        End Select
    End Sub

    Private Sub proveri_formu()
        Dim mChack As Object

        aktivan_chk = False
        For Each mChack In mPanel2.Controls
            If mChack.name = "chkNaziv" Or mChack.name = "chkSifra" Or mChack.name = "chkAdresa" _
                    Or mChack.name = "chkOpstina" Or mChack.name = "chkMesto" Then
                If mChack.CheckState = CheckState.Checked Then
                    aktivan_chk = True
                End If
            End If
        Next
        If aktivan_chk = False Then
            _lista.Items.Clear()
            _lista.Visible = False
        End If
    End Sub

    Private Sub btnPronadji_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPronadji.Click
        filter()
    End Sub


#Region "STAMPANJE"
    Shared Sub prn()
        filter()

        pripremi()
        _raport = Imena.tabele.app_partneri.ToString

        Dim mForm As New frmPrint
        mForm.Show()
    End Sub

    Shared Sub pripremi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Dim xmlw As XmlTextWriter = Nothing
        Dim putanja As String = _win_temp_path ' My.Application.Info.DirectoryPath & "\izvestaji\app\"
        Dim fajl As String = putanja & "rptPartneri.xml"

        Dim fi As FileInfo = New FileInfo(fajl)

        If fi.Exists Then fi.Delete()

        xmlw = New XmlTextWriter(fajl, Nothing)

        CN.Open()
        If CN.State = ConnectionState.Open Then

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from app_partneri"  '_sql
                DR = .ExecuteReader
            End With

            _partner_sifra = ""
            _partner_naziv = ""
            _partner_adresa = ""
            _partner_opstina = ""
            _partner_mesto = ""
            _partner_drazava = ""
            _partner_pib = ""
            _partner_maticni = ""
            _partner_registarski = ""
            _partner_delatnost = ""
            Dim _proizvodjac As String = ""
            Dim _dobavljac As String = ""
            Dim _kupac As String = ""
            Dim _aktivan As String = ""

            xmlw.Formatting = Formatting.Indented
            xmlw.WriteStartDocument()
            xmlw.WriteStartElement("partner")
            Do While DR.Read

                If Not IsDBNull(DR.Item("partner_sifra")) Then
                    _partner_sifra = RTrim(DR.Item("partner_sifra"))
                Else
                    _partner_sifra = ""
                End If
                If Not IsDBNull(DR.Item("partner_naziv")) Then
                    _partner_naziv = RTrim(DR.Item("partner_naziv"))
                Else
                    _partner_naziv = ""
                End If
                If Not IsDBNull(DR.Item("partner_adresa")) Then
                    _partner_adresa = RTrim(DR.Item("partner_adresa"))
                Else
                    _partner_adresa = ""
                End If
                If Not IsDBNull(DR.Item("partner_opstina")) Then
                    _partner_opstina = RTrim(DR.Item("partner_opstina"))
                Else
                    _partner_opstina = ""
                End If
                If Not IsDBNull(DR.Item("partner_mesto")) Then
                    _partner_mesto = RTrim(DR.Item("partner_mesto"))
                Else
                    _partner_mesto = ""
                End If
                If Not IsDBNull(DR.Item("partner_drazava")) Then
                    _partner_drazava = RTrim(DR.Item("partner_drazava"))
                Else
                    _partner_drazava = ""
                End If
                If Not IsDBNull(DR.Item("partner_pib")) Then
                    _partner_pib = RTrim(DR.Item("partner_pib"))
                Else
                    _partner_pib = ""
                End If
                If Not IsDBNull(DR.Item("partner_maticni")) Then
                    _partner_maticni = RTrim(DR.Item("partner_maticni"))
                Else
                    _partner_maticni = ""
                End If
                If Not IsDBNull(DR.Item("partner_registarski")) Then
                    _partner_registarski = RTrim(DR.Item("partner_registarski"))
                Else
                    _partner_registarski = ""
                End If
                If Not IsDBNull(DR.Item("partner_delatnost")) Then
                    _partner_delatnost = RTrim(DR.Item("partner_delatnost"))
                Else
                    _partner_delatnost = ""
                End If
                If Not IsDBNull(DR.Item("partner_proizvodjac")) Then
                    _proizvodjac = da_ne(DR.Item("partner_proizvodjac"))
                Else
                    _proizvodjac = ""
                End If
                If Not IsDBNull(DR.Item("partner_dobavljac")) Then
                    _dobavljac = da_ne(DR.Item("partner_dobavljac"))
                Else
                    _dobavljac = ""
                End If
                If Not IsDBNull(DR.Item("partner_kupac")) Then
                    _kupac = da_ne(DR.Item("partner_kupac"))
                Else
                    _kupac = ""
                End If
                If Not IsDBNull(DR.Item("partner_aktivan")) Then
                    _aktivan = da_ne(DR.Item("partner_aktivan"))
                Else
                    _aktivan = ""
                End If

                xmlw.WriteStartElement("podatak")
                xmlw.WriteElementString("sifra", _partner_sifra)
                xmlw.WriteElementString("naziv", _partner_naziv)
                xmlw.WriteElementString("adresa", _partner_adresa)
                xmlw.WriteElementString("opstina", _partner_opstina)
                xmlw.WriteElementString("mesto", _partner_mesto)
                xmlw.WriteElementString("drazava", _partner_drazava)
                xmlw.WriteElementString("pib", _partner_pib)
                xmlw.WriteElementString("maticni", _partner_maticni)
                xmlw.WriteElementString("registarski", _partner_registarski)
                xmlw.WriteElementString("delatnost", _partner_delatnost)
                xmlw.WriteElementString("proizvodjac", _proizvodjac)
                xmlw.WriteElementString("dobavljac", _dobavljac)
                xmlw.WriteElementString("kupac", _kupac)
                xmlw.WriteElementString("aktivan", _aktivan)
                xmlw.WriteEndElement()
            Loop
            xmlw.WriteEndElement()
            xmlw.WriteEndDocument()
            xmlw.Flush()
            xmlw.Close()

            DR.Close()
            CM.Dispose()

        End If
        CN.Close()
    End Sub

#End Region



End Class
