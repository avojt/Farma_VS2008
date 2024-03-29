Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO

Public Class cntArtikli_search

#Region "dekleracija"
    Shared upit As String = ""
    Shared upit_sifra As String = ""
    Shared upit_lek As String = ""
    Shared upit_grupa As String = ""
    Shared upit_genericko As String = ""
    Shared upit_datumOD As String = ""
    Shared upit_datumDO As String = ""
    Shared upit_proizvodjac As String = ""
    Shared upit_lista As String = ""

    Shared sql_start As String = _
                "SELECT DISTINCT " & _
                    "dbo.rm_artikli.artikl_sifra, dbo.rm_artikli.artikl_naziv, dbo.rm_artikli.jkl, " & _
                    "dbo.rm_artikli.artikl_genericko_ime, dbo.app_artikl_grupa.gr_artikla_sifra, " & _
                    "dbo.app_artikl_grupa.gr_artikla_naziv, dbo.app_partneri.partner_naziv, dbo.app_fo.fo_sifra, " & _
                    "dbo.app_fo.fo_naziv, dbo.app_jm.jm_oznaka, " & _
                    "dbo.app_pozitivna_lista.jkl_sifra, dbo.app_pozitivna_lista.L1, " & _
                    "dbo.app_pozitivna_lista.l1_datum_OD, dbo.app_pozitivna_lista.l1_datum_DO " & _
                "FROM dbo.rm_magacin_promene INNER JOIN " & _
                    "dbo.rm_magacin_promene_stavka ON dbo.rm_magacin_promene.id_promene = dbo.rm_magacin_promene_stavka.id_promene RIGHT OUTER JOIN " & _
                    "dbo.rm_artikli ON dbo.rm_magacin_promene_stavka.id_artikl = dbo.rm_artikli.id_artikl LEFT OUTER JOIN " & _
                    "dbo.app_pozitivna_lista ON dbo.rm_artikli.jkl = dbo.app_pozitivna_lista.jkl_sifra LEFT OUTER JOIN " & _
                    "dbo.app_fo ON dbo.rm_artikli.id_fo = dbo.app_fo.id_fo LEFT OUTER JOIN " & _
                    "dbo.app_partneri ON dbo.rm_artikli.id_proizvodjac = dbo.app_partneri.id_partner LEFT OUTER JOIN " & _
                    "dbo.app_jm ON dbo.rm_artikli.id_jm = dbo.app_jm.id_jm LEFT OUTER JOIN " & _
                    "dbo.app_artikl_grupa ON dbo.rm_artikli.id_grup_artikla = dbo.app_artikl_grupa.id_grup_artikla"
    '"dbo.rm_magacin_promene.mag_datum_promene " & _

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

    Private Sub cntSearch_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        popuni_grupe()
        popuni_genericko()
        popuni_proizvodjace()

        txtNaziv.Enabled = False
        txtNaziv.BackColor = Color.Lavender
        cmbGrupa.Enabled = False
        cmbGrupa.BackColor = Color.Lavender
        cmbPartner.Enabled = False
        cmbPartner.BackColor = Color.Lavender
        cmbGenericko.Enabled = False
        cmbGenericko.BackColor = Color.Lavender

        chkGrupa.CheckState = CheckState.Unchecked
        chkNaziv.CheckState = CheckState.Unchecked
        chkProizvodjac.CheckState = CheckState.Unchecked
        chkGenericko.CheckState = CheckState.Unchecked

        rbtSvi_lista.Checked = True
        rbtL1.Checked = False
        rbtL2.Checked = False

        rbtSvi.Checked = True
        rbtAtivni.Checked = False
        rbtAtivniPeriod.Checked = False

        dateDatumOd.Value = "01/01/" & Now.Year.ToString
        dateDatumDo.Value = Today

        _lCount = labCount

        mPanel.Dock = DockStyle.Fill


    End Sub

    Private Sub popuni_grupe()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbGrupa.Items.Clear()
        cmbGrupa.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_artikl_grupa.* from dbo.app_artikl_grupa"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbGrupa.Items.Add(DR.Item("gr_artikla_naziv"))
            Loop
            DR.Close()
        End If
        If cmbGrupa.Items.Count > 0 Then
            cmbGrupa.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_genericko()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbGenericko.Items.Clear()
        cmbGenericko.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_genericko_ime.* from dbo.app_genericko_ime"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbGenericko.Items.Add(DR.Item("genericko_sifra") + " - " + DR.Item("genericko_ime"))
            Loop
            DR.Close()
        End If
        If cmbGenericko.Items.Count > 0 Then
            cmbGenericko.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_proizvodjace()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbPartner.Items.Clear()
        cmbPartner.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_partneri.* from dbo.app_partneri where dbo.app_partneri.partner_proizvodjac = 1"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbPartner.Items.Add(DR.Item("partner_naziv"))
            Loop
            DR.Close()
        End If
        If cmbPartner.Items.Count > 0 Then
            cmbPartner.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Shared Sub filter()
        On Error Resume Next

        upit = ""
        sql = ""

        If upit_lek <> "" And upit <> "" Then
            upit = upit & " and " & upit_lek
        Else
            If upit_lek <> "" Then upit = upit_lek
        End If

        If upit_grupa <> "" And upit <> "" Then
            upit = upit & " and " & upit_grupa
        Else
            If upit_grupa <> "" Then upit = upit_grupa
        End If

        If upit_genericko <> "" And upit <> "" Then
            upit = upit & " and " & upit_genericko
        Else
            If upit_genericko <> "" Then upit = upit_genericko
        End If

        If upit_proizvodjac <> "" And upit <> "" Then
            upit = upit & " and " & upit_proizvodjac
        Else
            If upit_proizvodjac <> "" Then upit = upit_proizvodjac
        End If

        If upit_datumOD <> "" And upit <> "" Then
            upit = upit & " and " & upit_datumOD
        Else
            If upit_datumOD <> "" Then upit = upit_datumOD
        End If

        If upit_datumDO <> "" And upit <> "" Then
            upit = upit & " and " & upit_datumDO
        Else
            If upit_datumDO <> "" Then upit = upit_datumDO
        End If

        If upit_lista <> "" And upit <> "" Then
            upit = upit & " and " & upit_lista
        Else
            If upit_lista <> "" Then upit = upit_lista
        End If

        sql = sql_start
        If upit <> "" Then
            sql += " WHERE " & upit
        End If
        If _poABCedi Then sql += " ORDER BY rm_artikli.artikl_naziv" 'ASC" DESC" 'ascending

        Lista()

        _sql_za_print = sql

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
                    Dim podatak As New ListViewItem(CStr(DR.Item("artikl_sifra")))

                    podatak.SubItems.Add(DR.Item("artikl_naziv").ToString)
                    podatak.SubItems.Add(DR.Item("gr_artikla_sifra").ToString)
                    podatak.SubItems.Add(DR.Item("gr_artikla_naziv").ToString)
                    podatak.SubItems.Add(DR.Item("jkl").ToString)
                    podatak.SubItems.Add(DR.Item("artikl_genericko_ime").ToString)
                    If Not IsDBNull(DR.Item("L1")) Then
                        podatak.SubItems.Add(da_ne(DR.Item("L1")))
                    Else
                        podatak.SubItems.Add("")
                    End If
                    'podatak.SubItems.Add(da_ne(DR.Item("L1")))
                    podatak.SubItems.Add(DR.Item("jm_oznaka").ToString)
                    podatak.SubItems.Add(DR.Item("fo_sifra").ToString)
                    podatak.SubItems.Add(DR.Item("fo_naziv").ToString)
                    podatak.SubItems.Add(DR.Item("partner_naziv").ToString)

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

    Private Sub chkNaziv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNaziv.CheckedChanged
        Select Case chkNaziv.CheckState
            Case CheckState.Checked
                txtNaziv.Enabled = True
                txtNaziv.BackColor = Color.GhostWhite
                'aktivan_chk1 = True
            Case CheckState.Unchecked
                txtNaziv.Enabled = False
                txtNaziv.BackColor = Color.Lavender
                'aktivan_chk1 = False
                upit_lek = ""
                txtNaziv.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub chkGrupa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGrupa.CheckedChanged
        Select Case chkGrupa.CheckState
            Case CheckState.Checked
                cmbGrupa.Enabled = True
                cmbGrupa.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbGrupa.Enabled = False
                cmbGrupa.BackColor = Color.Lavender
                upit_grupa = ""
                cmbGrupa.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub chkGenericko_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGenericko.CheckedChanged
        Select Case chkGenericko.CheckState
            Case CheckState.Checked
                cmbGenericko.Enabled = True
                cmbGenericko.BackColor = Color.GhostWhite
                'aktivan_chk3 = True
            Case CheckState.Unchecked
                cmbGenericko.Enabled = False
                cmbGenericko.BackColor = Color.Lavender
                'aktivan_chk3 = False
                upit_genericko = ""
                cmbGenericko.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub chkProizvodjac_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProizvodjac.CheckedChanged
        Select Case chkProizvodjac.CheckState
            Case CheckState.Checked
                cmbPartner.Enabled = True
                cmbPartner.BackColor = Color.GhostWhite
                'aktivan_chk4 = True
            Case CheckState.Unchecked
                cmbPartner.Enabled = False
                cmbPartner.BackColor = Color.Lavender
                'aktivan_chk4 = False
                upit_proizvodjac = ""
                cmbPartner.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub txtNaziv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNaziv.TextChanged
        If txtNaziv.Text <> "" Then
            upit_lek = "rm_artikli.artikl_naziv LIKE N'%" & txtNaziv.Text & "%'"
        Else
            upit_lek = ""
        End If
        'filter()

    End Sub
    Private Sub txtNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNaziv.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtNaziv.Text <> "" Then
                upit_lek = "rm_artikli.artikl_naziv LIKE N'%" & txtNaziv.Text & "%'"
            Else
                upit_lek = ""
            End If
            filter()
        End If
    End Sub

    Private Sub rbtSvi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtSvi.CheckedChanged
        Select Case rbtSvi.Checked
            Case True
                upit_datumOD = ""
                upit_datumDO = ""
            Case False
                upit_datumOD = ""
                upit_datumDO = ""
        End Select
    End Sub
    Private Sub rbtSvi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rbtSvi.KeyPress
        If e.KeyChar = Chr(13) Then
            Select Case rbtSvi.Checked
                Case True
                    upit_datumOD = ""
                    upit_datumDO = ""
                Case False
                    upit_datumOD = ""
                    upit_datumDO = ""
            End Select
            filter()
        End If
    End Sub

    Private Sub rbtAtivni_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAtivni.CheckedChanged
        Select Case rbtAtivni.Checked
            Case True
                upit_datumOD = "dbo.rm_magacin_promene.mag_datum_promene >= '01/01/" & Year(Now) & "'"
            Case False
                upit_datumOD = ""
        End Select
        'filter()
    End Sub
    Private Sub rbtAtivniPeriod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAtivniPeriod.CheckedChanged
        Select Case rbtAtivni.Checked
            Case True
                upit_datumOD = "dbo.rm_magacin_promene.mag_datum_promene >= '01/01/" & Year(Now) & "'"
            Case False
                upit_datumOD = ""
        End Select
        'filter()
    End Sub

    Private Sub dateDatumOd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateDatumOd.ValueChanged
        Select Case rbtAtivniPeriod.Checked
            Case True
                upit_datumOD = "dbo.rm_magacin_promene.mag_datum_promene >= '" & _
                              dateDatumOd.Value.Month.ToString & "/" & _
                              dateDatumOd.Value.Day.ToString & "/" & _
                              dateDatumOd.Value.Year.ToString & "'"
            Case False
                upit_datumOD = ""
        End Select
        'filter()
    End Sub
    Private Sub dateDatumDo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateDatumDo.ValueChanged
        Select Case rbtAtivniPeriod.Checked
            Case True
                upit_datumDO = "dbo.rm_magacin_promene.mag_datum_promene <= '" & _
                             dateDatumDo.Value.Month.ToString & "/" & _
                             dateDatumDo.Value.Day.ToString & "/" & _
                             dateDatumDo.Value.Year.ToString & "'"
            Case False
                upit_datumDO = ""
        End Select
        'filter()
    End Sub

    Private Sub cmbGrupa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGrupa.SelectedIndexChanged
        If cmbGrupa.Text <> "" Then
            upit_grupa = "dbo.app_artikl_grupa.gr_artikla_naziv = N'" & cmbGrupa.Text & "'"
        Else
            upit_grupa = ""
        End If
        'filter()
    End Sub

    Private Sub cmbGenericko_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGenericko.SelectedIndexChanged
        If cmbGenericko.Text <> "" Then
            upit_genericko = "dbo.rm_artikli.artikl_genericko_ime = N'" & cmbGenericko.Text & "'"
        Else
            upit_genericko = ""
        End If
        'filter()
    End Sub

    Private Sub cmbPartner_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPartner.SelectedIndexChanged
        If cmbPartner.Text <> "" Then
            upit_proizvodjac = "partner_naziv = N'" & cmbPartner.Text & "'"
        Else
            upit_proizvodjac = ""
        End If
        'filter()
    End Sub

    Private Sub chkABC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkABC.CheckedChanged
        Select Case chkABC.CheckState
            Case CheckState.Checked
                _poABCedi = True
            Case CheckState.Unchecked
                _poABCedi = False
        End Select
    End Sub
    Private Sub chkABC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkABC.KeyPress
        If e.KeyChar = Chr(13) Then
            Select Case chkABC.CheckState
                Case CheckState.Checked
                    _poABCedi = True
                Case CheckState.Unchecked
                    _poABCedi = True
            End Select
            filter()
        End If
    End Sub

    Private Sub rbtSvi_lista_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtSvi_lista.CheckedChanged
        Select Case rbtSvi_lista.Checked
            Case True
                upit_lista = ""
            Case False
                upit_lista = ""
        End Select
    End Sub
    Private Sub rbtSvi_lista_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rbtSvi_lista.KeyPress
        If e.KeyChar = Chr(13) Then
            Select Case rbtSvi_lista.Checked
                Case True
                    upit_lista = ""
                Case False
                    upit_lista = ""
            End Select
            filter()
        End If
    End Sub

    Private Sub rbtL1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtL1.CheckedChanged
        Select Case rbtL1.Checked
            Case True
                upit_lista = "app_pozitivna_lista.L1 = 1"
            Case False
                upit_lista = ""
        End Select
    End Sub
    Private Sub rbtL1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rbtL1.KeyPress
        If e.KeyChar = Chr(13) Then
            Select Case rbtL1.Checked
                Case True
                    upit_lista = "app_pozitivna_lista.L1 = 1"
                Case False
                    upit_lista = ""
            End Select
            filter()
        End If
    End Sub

    Private Sub rbtL2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtL2.CheckedChanged
        Select Case rbtL2.Checked
            Case True
                upit_lista = "app_pozitivna_lista.L1 = 0"
            Case False
                upit_lista = ""
        End Select
    End Sub
    Private Sub rbtL2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rbtL2.KeyPress
        If e.KeyChar = Chr(13) Then
            Select Case rbtL2.Checked
                Case True
                    upit_lista = "app_pozitivna_lista.L1 = 0"
                Case False
                    upit_lista = ""
            End Select
            filter()
        End If
    End Sub

    Private Sub proveri_formu()
        'Dim mCont As Control ' CheckBox
        Dim mChack As Object

        aktivan_chk = False
        For Each mChack In mPanel2.Controls
            If mChack.name = "chkNaziv" Or mChack.name = "chkGrupa" Or mChack.name = "chkGenericko" _
                    Or mChack.name = "chkVrsta" Or mChack.name = "chkProizvodjac" Then
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
        _raport = Imena.tabele.rm_artikli.ToString

        Dim mForm As New frmPrint
        mForm.Show()
    End Sub

    Shared Sub pripremi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Dim xmlw As XmlTextWriter = Nothing
        Dim putanja As String = _win_temp_path ' My.Application.Info.DirectoryPath & "\izvestaji\app\"
        Dim fajl As String = putanja & "rptArtikli_all.xml"

        Dim fi As FileInfo = New FileInfo(fajl)

        If fi.Exists Then fi.Delete()

        xmlw = New XmlTextWriter(fajl, Nothing)

        CN.Open()
        If CN.State = ConnectionState.Open Then

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from rm_artikli"  '_sql
                DR = .ExecuteReader
            End With

            _magacin_sifra = ""
            _magacin_naziv = ""
            _artikl_sifra = ""
            _artikl_naziv = ""
            _jkl_sifra = ""
            _jm_oznaka = ""
            _gr_art_skraceno = ""
            _pdv_stopa = 0
            _magacin_stanje = 0

            xmlw.Formatting = Formatting.Indented
            xmlw.WriteStartDocument()
            xmlw.WriteStartElement("artikl")

            Do While DR.Read
                If _print_all Then
                    If Not IsDBNull(DR.Item("magacin_sifra")) Then _magacin_sifra = DR.Item("magacin_sifra")
                    If Not IsDBNull(DR.Item("magacin_naziv")) Then _magacin_naziv = DR.Item("magacin_naziv")
                End If

                If Not IsDBNull(DR.Item("artikl_sifra")) Then
                    _artikl_sifra = RTrim(DR.Item("artikl_sifra"))
                Else
                    _artikl_sifra = ""
                End If

                If Not IsDBNull(DR.Item("artikl_naziv")) Then
                    _artikl_naziv = RTrim(DR.Item("artikl_naziv"))
                Else
                    _artikl_naziv = ""
                End If

                If Not IsDBNull(DR.Item("jkl")) Then
                    _jkl_sifra = RTrim(DR.Item("jkl"))
                Else
                    _jkl_sifra = ""
                End If

                xmlw.WriteStartElement("podatak")
                xmlw.WriteElementString("sifra", _artikl_sifra)
                xmlw.WriteElementString("naziv", _artikl_naziv)
                xmlw.WriteElementString("jkl", _jkl_sifra)
                xmlw.WriteElementString("grupa", _gr_art_skraceno)
                xmlw.WriteElementString("jm", _jm_oznaka)
                xmlw.WriteElementString("stopa", _pdv_stopa)
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

    Shared Sub unesi(ByVal _magacin_sifra, ByVal _magacin_naziv, ByVal _artikl_sifra, ByVal _artikl_naziv, ByVal _jkl_sifra, ByVal _jm_oznaka, ByVal _gr_art_skraceno, ByVal _pdv_stopa, ByVal _magacin_stanje)
        'Dim CN As SqlConnection = New SqlConnection(CNNString)
        'Dim CM As New SqlCommand

        'CN.Open()
        'If CN.State = ConnectionState.Open Then
        '    CM = New SqlCommand()
        '    With CM
        '        .Connection = CN
        '        .CommandType = CommandType.StoredProcedure
        '        .CommandText = "prn_artikli_add"
        '        .Parameters.AddWithValue("@magacin_sifra", _magacin_sifra)
        '        .Parameters.AddWithValue("@magacin_naziv", _magacin_naziv)
        '        .Parameters.AddWithValue("@artikl_sifra", _artikl_sifra)
        '        .Parameters.AddWithValue("@artikl_naziv", _artikl_naziv)
        '        .Parameters.AddWithValue("@jkl_sifra", _jkl_sifra)
        '        .Parameters.AddWithValue("@jm_oznaka", _jm_oznaka)
        '        .Parameters.AddWithValue("@grupa_skraceno", _gr_art_skraceno)
        '        .Parameters.AddWithValue("@pdv_stopa", _pdv_stopa)
        '        .Parameters.AddWithValue("@magacin_stanje", _magacin_stanje)
        '        .ExecuteScalar()
        '    End With
        '    CM.Dispose()
        'End If
        'CN.Close()
    End Sub

#End Region

End Class
