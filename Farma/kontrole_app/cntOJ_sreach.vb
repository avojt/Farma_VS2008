Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO

Public Class cntOJ_sreach

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
                "SELECT DISTINCT * FROM dbo.app_organizacione_jedinice"

    'Shared sql_start As String = _
    '           "SELECT * FROM dbo.app_organizacione_jedinice"

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

    Private Sub cntOJ_sreach_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

        upit = ""
        sql = ""

        If upit_sifra <> "" Then upit = upit_sifra

        If upit_naziv <> "" And upit <> "" Then
            upit = upit & " and " & upit_naziv
        Else
            If upit_naziv <> "" Then upit = upit_naziv
        End If

        If upit_adresa <> "" And upit <> "" Then
            upit = upit & " and " & upit_adresa
        Else
            If upit_adresa <> "" Then upit = upit_adresa
        End If

        If upit_opstina <> "" And upit <> "" Then
            upit = upit & " and " & upit_opstina
        Else
            If upit_opstina <> "" Then upit = upit_opstina
        End If

        If upit_mesto <> "" And upit <> "" Then
            upit = upit & " and " & upit_mesto
        Else
            If upit_mesto <> "" Then upit = upit_mesto
        End If

        sql = sql_start
        If upit <> "" Then
            sql += " WHERE " & upit
        End If
        If _poABCedi Then sql += " ORDER BY dbo.app_organizacione_jedinice.oj_sifra"
        lista()

    End Sub

    Shared Sub lista()
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
                    Dim podatak As New ListViewItem(CStr(DR.Item("oj_sifra")))
                    'podatak.SubItems.Add(DR.Item("sifra_stara").ToString)
                    podatak.SubItems.Add(DR.Item("oj_naziv").ToString)
                    podatak.SubItems.Add(DR.Item("oj_adresa").ToString)
                    selektuj_grad(DR.Item("id_grad"), Selekcija.po_id)
                    podatak.SubItems.Add(_grad_naziv)
                    selektuj_opstine(DR.Item("id_opstine"), Selekcija.po_id)
                    podatak.SubItems.Add(_opstina_naziv)
                    podatak.SubItems.Add(mesto_naziv(DR.Item("id_mesta").ToString))
                    'podatak.SubItems.Add(da_ne(DR.Item("oj_strukturna").ToString))
                    podatak.SubItems.Add(vrstaOJ_naziv(DR.Item("id_vrsta").ToString))

                    _lista.Items.AddRange(New ListViewItem() {podatak})

                End While
                DR.Close()
            End If

            CM.Dispose()
            CN.Close()
        End If

        '_lCount.Text = _lista.Items.Count.ToString + " zapisa"

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
                upit_sifra = "app_organizacione_jedinice.oj_sifra LIKE N'" & txtSifra.Text & "%'"
            Else
                upit_sifra = ""
            End If
            filter()
        End If
    End Sub
    Private Sub txtSifra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSifra.TextChanged
        If txtSifra.Text <> "" Then
            upit_sifra = "app_organizacione_jedinice.oj_sifra LIKE N'" & txtSifra.Text & "%'"
        Else
            upit_sifra = ""
        End If
        'filter()
    End Sub

    Private Sub txtNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNaziv.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtNaziv.Text <> "" Then
                upit_naziv = "app_organizacione_jedinice.oj_naziv LIKE N'" & txtNaziv.Text & "%'"
            Else
                upit_naziv = ""
            End If
            filter()
        End If
    End Sub
    Private Sub txtNaziv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNaziv.TextChanged
        If txtNaziv.Text <> "" Then
            upit_naziv = "app_organizacione_jedinice.oj_naziv LIKE N'" & txtNaziv.Text & "%'"
        Else
            upit_naziv = ""
        End If
    End Sub

    Private Sub txtAdresa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdresa.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtAdresa.Text <> "" Then
                upit_adresa = "app_organizacione_jedinice.oj_adresa LIKE N'" & txtAdresa.Text & "%'"
            Else
                upit_adresa = ""
            End If
            filter()
        End If
    End Sub
    Private Sub txtAdresa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdresa.TextChanged
        If txtAdresa.Text <> "" Then
            upit_adresa = "app_organizacione_jedinice.oj_adresa LIKE N'" & txtAdresa.Text & "%'"
        Else
            upit_adresa = ""
        End If
    End Sub

    Private Sub cmbOpstina_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbOpstina.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbOpstina.Text <> "" Then
                selektuj_opstine(cmbOpstina.Text, Selekcija.po_nazivu)
                upit_opstina = "app_organizacione_jedinice.id_opstine = " & _id_opstina
            Else
                upit_opstina = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbOpstina_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOpstina.SelectedIndexChanged
        If cmbOpstina.Text <> "" Then
            selektuj_opstine(cmbOpstina.Text, Selekcija.po_nazivu)
            upit_opstina = "app_organizacione_jedinice.id_opstine = " & _id_opstina
        Else
            upit_opstina = ""
        End If
    End Sub

    Private Sub cmbMesto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMesto.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbMesto.Text <> "" Then
                selektuj_mesto(cmbMesto.Text, Selekcija.po_nazivu)
                upit_mesto = "app_organizacione_jedinice.id_mesta =" & _id_mesto
            Else
                upit_mesto = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbMesto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMesto.SelectedIndexChanged
        If cmbMesto.Text <> "" Then
            upit_mesto = "app_organizacione_jedinice.id_mesta =" & _id_mesto
        Else
            upit_mesto = ""
        End If
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
        _raport = Imena.tabele.app_organizacione_jedinice.ToString

        Dim mForm As New frmPrint
        mForm.Show()
    End Sub

    Shared Sub pripremi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Dim xmlw As XmlTextWriter = Nothing
        Dim putanja As String = _win_temp_path ' My.Application.Info.DirectoryPath & "\izvestaji\app\"
        Dim fajl As String = putanja & "rptOJ.xml"

        Dim fi As FileInfo = New FileInfo(fajl)

        If fi.Exists Then fi.Delete()

        xmlw = New XmlTextWriter(fajl, Nothing)

        CN.Open()
        If CN.State = ConnectionState.Open Then

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from app_organizacione_jedinice"  '_sql
                DR = .ExecuteReader
            End With

            _oj_sifra = ""
            _oj_naziv = ""
            _oj_adresa = ""
            '_id_grad = ""
            '_id_opstina = ""
            '_id_mesto = ""
            '_id_vrsta = ""
            Dim _strukturna As String = ""
            Dim _aktivan As String = ""

            xmlw.Formatting = Formatting.Indented
            xmlw.WriteStartDocument()
            xmlw.WriteStartElement("oj")

            Do While DR.Read
                If Not IsDBNull(DR.Item("oj_sifra")) Then
                    _oj_sifra = RTrim(DR.Item("oj_sifra"))
                Else
                    _oj_sifra = ""
                End If
                If Not IsDBNull(DR.Item("oj_naziv")) Then
                    _oj_naziv = RTrim(DR.Item("oj_naziv"))
                Else
                    _oj_naziv = ""
                End If
                If Not IsDBNull(DR.Item("oj_adresa")) Then
                    _oj_adresa = RTrim(DR.Item("oj_adresa"))
                Else
                    _oj_adresa = ""
                End If
                selektuj_grad(DR.Item("id_grad"), Selekcija.po_id)
                selektuj_opstine(DR.Item("id_opstine"), Selekcija.po_id)
                If Not IsDBNull(DR.Item("id_mesta")) Then
                    selektuj_mesto(DR.Item("id_mesta"), Selekcija.po_id)
                Else
                    _mesto_naziv = ""
                End If

                If Not IsDBNull(DR.Item("id_vrsta")) Then
                    selektuj_vrstu_oj(DR.Item("id_vrsta"), Selekcija.po_id)
                Else
                    _vrsta_oj_naziv = ""
                End If

                If Not IsDBNull(DR.Item("oj_strukturna")) Then
                    _strukturna = da_ne(DR.Item("oj_strukturna"))
                Else
                    _strukturna = ""
                End If
                If Not IsDBNull(DR.Item("oj_aktivan")) Then
                    _aktivan = da_ne(DR.Item("oj_aktivan"))
                Else
                    _aktivan = ""
                End If

                xmlw.WriteStartElement("podatak")
                xmlw.WriteElementString("sifra", _oj_sifra)
                xmlw.WriteElementString("naziv", _oj_naziv)
                xmlw.WriteElementString("adresa", _oj_adresa)
                xmlw.WriteElementString("grad", _grad_naziv)
                xmlw.WriteElementString("opstina", _opstina_naziv)
                xmlw.WriteElementString("mesto", _mesto_naziv)
                xmlw.WriteElementString("vrsta", _vrsta_oj_naziv)
                xmlw.WriteElementString("strukturna", _strukturna)
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
