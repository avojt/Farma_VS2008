Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntIzvestaji_neslaganja

#Region "dekleracija"
    Private upit As String = ""
    Private upit_datum_od As String = ""
    Private upit_datum_do As String = ""
    Private upit_magacin As String = ""
    Private upit_grupa As String = ""
    Private upit_vrdok As String = ""
    Private upit_m As String = ""
    Private upit_dp As String = ""

    Shared sql As String = ""

    Private sql_magacin As String = _
        "SELECT DISTINCT " & _
            "dbo.rm_magacin.magacin_sifra, " & _
            "dbo.rm_magacin.magacin_naziv, " & _
            "dbo.rm_magacin_promene.mag_datum_promene, " & _
            "dbo.rm_magacin_promene_stavka.mag_art_ulaz, " & _
            "dbo.rm_magacin_promene_stavka.mag_art_izlaz, " & _
            "dbo.rm_magacin_promene_stavka.mag_art_stanje, " & _
            "dbo.rm_magacin_promene_stavka.mag_suma_ulaz, " & _
            "dbo.rm_magacin_promene_stavka.mag_suma_izlaz, " & _
            "dbo.rm_magacin_promene_stavka.mag_suma_stanje, " & _
            "dbo.rm_artikli_cene.cena_nab_zadnja, " & _
            "dbo.rm_artikli.artikl_sifra, " & _
            "dbo.rm_artikli.artikl_naziv, " & _
            "dbo.rm_artikli.jkl, " & _
            "dbo.app_jm.jm_oznaka, " & _
            "dbo.app_artikl_grupa.gr_artikla_sifra, " & _
            "dbo.app_artikl_grupa.gr_artikla_naziv, " & _
            "dbo.app_partneri.partner_naziv " & _
        "FROM dbo.app_partneri RIGHT OUTER JOIN " & _
            "dbo.rm_magacin_promene_stavka LEFT OUTER JOIN " & _
            "dbo.rm_artikli LEFT OUTER JOIN " & _
            "dbo.rm_artikli_cene RIGHT OUTER JOIN " & _
            "dbo.rm_magacin INNER JOIN " & _
            "dbo.rm_magacin_promene ON dbo.rm_magacin.id_magacin = dbo.rm_magacin_promene.id_magacin ON " & _
            "dbo.rm_artikli_cene.id_magacin = dbo.rm_magacin_promene.id_magacin ON dbo.rm_artikli.id_artikl = dbo.rm_artikli_cene.id_artikl LEFT OUTER JOIN " & _
            "dbo.app_jm ON dbo.rm_artikli.id_jm = dbo.app_jm.id_jm LEFT OUTER JOIN " & _
            "dbo.app_artikl_grupa ON dbo.rm_artikli.id_grup_artikla = dbo.app_artikl_grupa.id_grup_artikla ON " & _
            "dbo.rm_magacin_promene_stavka.id_artikl = dbo.rm_artikli.id_artikl AND " & _
            "dbo.rm_magacin_promene_stavka.id_promene = dbo.rm_magacin_promene.id_promene ON " & _
            "dbo.app_partneri.id_partner = dbo.rm_magacin_promene.id_partner"

    Private sql_dp As String = _
        "SELECT DISTINCT " & _
             "dbo.rm_magacin.magacin_sifra, " & _
             "dbo.rm_magacin.magacin_naziv, " & _
             "dbo.rm_dnevni_promet_head.dp_datum_promene, " & _
             "dbo.rm_dnevni_promet_head.dp_zakljucen, " & _
             "dbo.rm_dnevni_promet_stavka.id_artikl, " & _
             "dbo.rm_artikli.artikl_sifra, " & _
             "dbo.rm_artikli.artikl_naziv, " & _
             "dbo.rm_artikli.jkl, " & _
             "dbo.rm_artikli_cene.cena_nab_zadnja, " & _
             "dbo.rm_dnevni_promet_stavka.dp_art_ulaz, " & _
             "dbo.rm_dnevni_promet_stavka.dp_art_izlaz, " & _
             "dbo.rm_dnevni_promet_stavka.dp_art_stanje, " & _
             "dbo.rm_dnevni_promet_stavka.dp_suma_ulaz, " & _
             "dbo.rm_dnevni_promet_stavka.dp_suma_izlaz, " & _
             "dbo.rm_dnevni_promet_stavka.dp_suma_stanje, " & _
             "dbo.app_artikl_grupa.gr_artikla_sifra, " & _
             "dbo.app_artikl_grupa.gr_artikla_naziv, " & _
             "dbo.app_jm.jm_oznaka, " & _
             "dbo.app_partneri.partner_naziv " & _
        "FROM dbo.rm_dnevni_promet_stavka LEFT OUTER JOIN " & _
             "dbo.app_partneri RIGHT OUTER JOIN " & _
             "dbo.rm_dnevni_promet_head ON dbo.app_partneri.id_partner = dbo.rm_dnevni_promet_head.id_partner ON " & _
             "dbo.rm_dnevni_promet_stavka.id_dnevni_promet = dbo.rm_dnevni_promet_head.id_dnevni_promet LEFT OUTER JOIN " & _
             "dbo.rm_artikli LEFT OUTER JOIN " & _
             "dbo.app_artikl_grupa ON dbo.rm_artikli.id_grup_artikla = dbo.app_artikl_grupa.id_grup_artikla LEFT OUTER JOIN " & _
             "dbo.app_jm ON dbo.rm_artikli.id_jm = dbo.app_jm.id_jm LEFT OUTER JOIN " & _
             "dbo.rm_artikli_cene ON dbo.rm_artikli.id_artikl = dbo.rm_artikli_cene.id_artikl ON " & _
             "dbo.rm_dnevni_promet_stavka.id_artikl = dbo.rm_artikli.id_artikl LEFT OUTER JOIN " & _
             "dbo.rm_magacin ON dbo.rm_dnevni_promet_head.id_magacin = dbo.rm_magacin.id_magacin " & _
        "WHERE (dbo.rm_dnevni_promet_head.dp_zakljucen = 0)"

    'Private sql_lager As String = _
    '    "SELECT DISTINCT " & _
    '        "dbo.rm_magacin.id_magacin, dbo.rm_magacin.magacin_sifra, dbo.rm_magacin.magacin_naziv, " & _
    '        "dbo.rm_artikli.artikl_sifra, dbo.rm_artikli.artikl_naziv, dbo.app_jm.jm_oznaka, " & _
    '        "dbo.app_artikl_grupa.gr_artikla_sifra, dbo.app_artikl_grupa.gr_artikla_naziv, " & _
    '        "dbo.rm_magacin_promene_stavka.mag_art_ulaz, dbo.rm_magacin_promene_stavka.mag_art_izlaz, " & _
    '        "dbo.rm_magacin_promene_stavka.mag_art_stanje, dbo.rm_magacin_promene_stavka.mag_art_cena, " & _
    '        "dbo.rm_magacin_promene_stavka.mag_suma_ulaz, dbo.rm_magacin_promene_stavka.mag_suma_izlaz, " & _
    '        "dbo.rm_magacin_promene_stavka.mag_suma_stanje, dbo.rm_dnevni_promet_head.dp_zakljucen, " & _
    '        "dbo.rm_dnevni_promet_stavka.dp_art_ulaz, dbo.rm_dnevni_promet_stavka.dp_art_izlaz, " & _
    '        "dbo.rm_dnevni_promet_stavka.dp_art_stanje, dbo.rm_dnevni_promet_stavka.dp_art_cena, " & _
    '        "dbo.rm_dnevni_promet_stavka.dp_suma_ulaz, dbo.rm_dnevni_promet_stavka.dp_suma_izlaz, " & _
    '        "dbo.rm_dnevni_promet_stavka.dp_suma_stanje " & _
    '    "FROM dbo.rm_magacin RIGHT OUTER JOIN " & _
    '        "dbo.rm_dnevni_promet_stavka ON dbo.rm_magacin.id_magacin = dbo.rm_dnevni_promet_stavka.id_magacin RIGHT OUTER JOIN " & _
    '        "dbo.app_artikl_grupa INNER JOIN " & _
    '        "dbo.rm_artikli ON dbo.app_artikl_grupa.id_grup_artikla = dbo.rm_artikli.id_grup_artikla INNER JOIN " & _
    '        "dbo.app_jm ON dbo.rm_artikli.id_jm = dbo.app_jm.id_jm LEFT OUTER JOIN " & _
    '        "dbo.rm_magacin_promene_stavka ON dbo.rm_artikli.id_artikl = dbo.rm_magacin_promene_stavka.id_artikl ON " & _
    '        "dbo.rm_magacin.id_magacin = dbo.rm_magacin_promene_stavka.id_magacin AND " & _
    '        "dbo.rm_dnevni_promet_stavka.id_artikl = dbo.rm_artikli.id_artikl LEFT OUTER JOIN " & _
    '        "dbo.rm_dnevni_promet_head ON dbo.rm_dnevni_promet_stavka.id_dnevni_promet = dbo.rm_dnevni_promet_head.id_dnevni_promet " & _
    '    "WHERE (dbo.rm_dnevni_promet_head.dp_zakljucen = 0)"

    'Private sql_detaljno As String = _
    '     "SELECT DISTINCT " & _
    '        "dbo.rm_magacin.magacin_sifra, dbo.rm_magacin.magacin_sifra, dbo.rm_magacin.magacin_naziv, " & _
    '        "dbo.rm_magacin_promene.mag_datum_promene, dbo.app_vrste_dokumenata.vrsta_dok_naziv, " & _
    '        "dbo.rm_magacin_promene.mag_broj_dok, dbo.rm_artikli.id_artikl, dbo.rm_artikli.artikl_sifra, " & _
    '        "dbo.rm_artikli.artikl_naziv, dbo.app_artikl_grupa.gr_artikla_naziv, dbo.rm_artikli_cene.cena_nab_zadnja, " & _
    '        "dbo.rm_magacin_promene_stavka.mag_art_cena, dbo.rm_magacin_promene_stavka.mag_art_ulaz, " & _
    '        "dbo.rm_magacin_promene_stavka.mag_art_izlaz, dbo.rm_magacin_promene_stavka.mag_art_stanje, " & _
    '        "dbo.rm_magacin_promene_stavka.mag_suma_ulaz, dbo.rm_magacin_promene_stavka.mag_suma_izlaz, " & _
    '        "dbo.rm_magacin_promene_stavka.mag_suma_stanje, dbo.rm_magacin_promene_stavka.mag_stanje " & _
    '    "FROM dbo.rm_artikli INNER JOIN " & _
    '        "dbo.rm_artikli_cene ON dbo.rm_artikli.id_artikl = dbo.rm_artikli_cene.id_artikl INNER JOIN " & _
    '        "dbo.app_artikl_grupa ON dbo.rm_artikli.id_grup_artikla = dbo.app_artikl_grupa.id_grup_artikla " & _
    '        "RIGHT OUTER JOIN dbo.rm_magacin_promene INNER JOIN dbo.rm_magacin_promene_stavka " & _
    '        "ON dbo.rm_magacin_promene.id_promene = dbo.rm_magacin_promene_stavka.id_promene LEFT OUTER JOIN " & _
    '        "dbo.app_vrste_dokumenata ON  " & _
    '        "dbo.rm_magacin_promene.id_vrsta_dok = dbo.app_vrste_dokumenata.id_vrsta_dok ON " & _
    '        "dbo.rm_artikli.id_artikl = dbo.rm_magacin_promene_stavka.id_artikl LEFT OUTER JOIN " & _
    '        "dbo.rm_magacin ON dbo.rm_magacin_promene.id_magacin = dbo.rm_magacin.id_magacin"

    Private _pocetak As Boolean = True
    Private _poABCedi As Boolean = False
    Private _poArtiklu As Boolean = False
    Private aktivan_chk As Boolean
    Private stanje As Single

    Private _ekran As Boolean = False
    Private _printer As Boolean = False
    Private _excell As Boolean = False
    Private _word As Boolean = False
    Private _pdf As Boolean = False
    Private _html As Boolean = False
    Private _kumulativ As Boolean = True
    Private _neslaganje As Boolean = False

    Private _cena As Single
    Private _ulaz As Single
    Private _izlaz As Single
    Private _stanje As Single
    Private _duguje As Single
    Private _potrazuje As Single
    Private _saldo As Single

    Private _cenaLag As Single
    Private _ulazLag As Single
    Private _izlazLag As Single
    Private _stanjeLag As Single
    Private _dugujeLag As Single
    Private _potrazujeLag As Single
    Private _saldoLag As Single

    Private _opis As String = ""
    Private _grupa_art As String = ""
    Private _jm As String = ""
#End Region


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntIzvestaji_neslaganja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mPanel.Dock = DockStyle.Fill

        popuni_magacine()
        popuni_grupe()
        popuni_vrste_dokumenta()

        cmbMagacin.Enabled = True
        cmbMagacin.BackColor = Color.GhostWhite
        cmbVrDok.Enabled = False
        cmbVrDok.BackColor = Color.Lavender

        datDatumOd.Enabled = True
        datDatumDo.Enabled = True
        datDatumOd.Value = CDate("1/" & Today.Month.ToString & "/" & Today.Year.ToString)
        datDatumDo.Value = Today

        chkDatum.CheckState = CheckState.Checked
        chkMagacin.CheckState = CheckState.Checked

        rbtSaneslaganjem.Checked = True
        rbtEkran.Checked = True
        rbtPrinter.Checked = False
        rbtExcel.Checked = False
        rbtHtml.Checked = False
        rbtPdf.Checked = False
        rbtWord.Checked = False
    End Sub

    Private Sub popuni_magacine()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbMagacin.Items.Clear()
        cmbMagacin.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_magacin.* from dbo.rm_magacin"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbMagacin.Items.Add(DR.Item("magacin_naziv"))
            Loop
            DR.Close()
        End If
        If cmbMagacin.Items.Count > 0 Then
            cmbMagacin.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_grupe()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbGrupaArtikla.Items.Clear()
        cmbGrupaArtikla.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.app_artikl_grupa"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbGrupaArtikla.Items.Add(DR.Item("gr_artikla_naziv"))
            Loop
            DR.Close()
        End If
        If cmbGrupaArtikla.Items.Count > 0 Then
            cmbGrupaArtikla.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_vrste_dokumenta()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbVrDok.Items.Clear()
        cmbVrDok.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_vrste_dokumenata.* from dbo.app_vrste_dokumenata"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbVrDok.Items.Add(DR.Item("vrsta_dok_naziv"))
            Loop
            DR.Close()
        End If
        If cmbVrDok.Items.Count > 0 Then
            cmbVrDok.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub filter()

        If upit_magacin <> "" Then
            upit_m = ""
            upit_dp = ""

            If upit_datum_od <> "" And upit_m <> "" And upit_dp <> "" Then
                upit_m = upit_m & " and dbo.rm_magacin_promene.mag_datum_promene >= '" & upit_datum_od
                upit_dp = upit_dp & " and dbo.rm_dnevni_promet_head.dp_datum_promene >= '" & upit_datum_od
            Else
                If upit_datum_od <> "" Then
                    upit_m = " dbo.rm_magacin_promene.mag_datum_promene >= '" & upit_datum_od
                    upit_dp = " dbo.rm_dnevni_promet_head.dp_datum_promene >= '" & upit_datum_od
                End If
            End If

            If upit_datum_do <> "" And upit_m <> "" And upit_dp <> "" Then
                upit_m = upit_m & " and dbo.rm_magacin_promene.mag_datum_promene <= '" & upit_datum_do
                upit_dp = upit_dp & " and dbo.rm_dnevni_promet_head.dp_datum_promene <= '" & upit_datum_do
            Else
                If upit_datum_do <> "" Then
                    upit_m = " dbo.rm_magacin_promene.mag_datum_promene <= '" & upit_datum_do
                    upit_dp = " dbo.rm_dnevni_promet_head.dp_datum_promene <= '" & upit_datum_do
                End If
            End If

            If upit_grupa <> "" And upit_m <> "" And upit_dp <> "" Then
                upit_m = upit_m & " and " & upit_grupa
                upit_dp = upit_dp & " and " & upit_grupa
            Else
                If upit_grupa <> "" Then
                    upit_m = upit_grupa
                    upit_dp = upit_grupa
                End If
            End If

            If upit_magacin <> "" And upit_m <> "" And upit_dp <> "" Then
                upit_m = upit_m & " and " & upit_magacin
                upit_dp = upit_dp & " and " & upit_magacin
            Else
                If upit_magacin <> "" Then
                    upit_m = upit_magacin
                    upit_dp = upit_magacin
                End If
            End If

            If upit_vrdok <> "" And upit <> "" Then
                upit_m = upit & " and " & upit_vrdok
                upit_dp = upit & " and " & upit_vrdok
            Else
                If upit_vrdok <> "" Then
                    upit_m = upit_vrdok
                    upit_dp = upit_vrdok
                End If
            End If

            'If upit <> "" Then
            'sql = sql_detaljno & " WHERE " & upit '& " ORDER BY id_promene"
            If _ekran Then Lista()
            If _printer Then stampanje()
            'If _Excel Then
            'If _html Then
            'If _pdf Then
            'If _word Then
            'End If
        Else
        MsgBox("Magacin morate obavezno izabrati", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub Lista()

        Try
            Dim listView1 As New ListView()
            listView1.View = View.Details
            listView1.LabelEdit = True
            listView1.AllowColumnReorder = False
            listView1.FullRowSelect = True
            listView1.GridLines = True
            listView1.Dock = DockStyle.Fill
            listView1.BringToFront()
            listView1.ForeColor = Color.MidnightBlue

            listView1.Columns.Add("Šifra", 60, HorizontalAlignment.Left)
            listView1.Columns.Add("Naziv", 150, HorizontalAlignment.Left)
            listView1.Columns.Add("Opis", 100, HorizontalAlignment.Left)
            listView1.Columns.Add("Cena zaliha", 70, HorizontalAlignment.Right)
            listView1.Columns.Add("Ulaz", 70, HorizontalAlignment.Right)
            listView1.Columns.Add("Izlaz", 70, HorizontalAlignment.Right)
            listView1.Columns.Add("Stanje", 80, HorizontalAlignment.Right)
            listView1.Columns.Add("Duguje", 90, HorizontalAlignment.Right)
            listView1.Columns.Add("Potrazuje", 90, HorizontalAlignment.Right)
            listView1.Columns.Add("Saldo", 100, HorizontalAlignment.Right)

            Dim CN As SqlConnection = New SqlConnection(CNNString)
            Dim CM As New SqlCommand
            Dim DR As SqlDataReader
            Dim myControl As New cntLista

            Dim s_ulaz As Single = 0
            Dim s_izlaz As Single = 0
            Dim s_stanje As Single = 0
            Dim s_duguje As Single = 0
            Dim s_potrazuje As Single = 0
            Dim s_saldo As Single = 0

            Dim sdp_ulaz As Single = 0
            Dim sdp_izlaz As Single = 0
            Dim sdp_stanje As Single = 0
            Dim sdp_duguje As Single = 0
            Dim sdp_potrazuje As Single = 0
            Dim sdp_saldo As Single = 0

            Dim u_duguje As Single = 0
            Dim u_potrazuje As Single = 0
            Dim u_saldo As Single = 0


            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = "select * from rm_artikli"
                    DR = .ExecuteReader
                End With
                'Dim donos As Boolean = True
                Do While DR.Read
                    _cena = 0

                    'sumiraj(DR.Item("id_artikl"), _id_magacin, False)

                    sumiraj_lager(sql_magacin & " where " & upit_m & " and dbo.rm_artikli.id_artikl = " & DR.Item("id_artikl").ToString, 3, 4, 5)
                    s_ulaz += _ulaz
                    s_izlaz += _izlaz
                    s_stanje += _stanje
                    s_duguje += _duguje
                    s_potrazuje += _potrazuje
                    s_saldo += _saldo

                    sumiraj_lager(sql_dp & " and " & upit_dp & " and dbo.rm_artikli.id_artikl = " & DR.Item("id_artikl").ToString, 9, 10, 11)
                    sdp_ulaz = s_ulaz + _ulaz
                    sdp_izlaz = s_izlaz + _izlaz
                    sdp_stanje = s_stanje + _stanje
                    sdp_duguje = s_duguje + _duguje
                    sdp_potrazuje = s_potrazuje + _potrazuje
                    sdp_saldo = s_saldo + _saldo

                    If s_stanje <> sdp_stanje Then
                        Dim podatak As New ListViewItem(DR.Item("artikl_sifra").ToString)
                        podatak.SubItems.Add(DR.Item("artikl_naziv").ToString)
                        podatak.SubItems.Add("Magacin")
                        podatak.SubItems.Add(Format(_cena, "##,##0.00").ToString)
                        podatak.SubItems.Add(Format(s_ulaz, "##,##0").ToString)
                        podatak.SubItems.Add(Format(s_izlaz, "##,##0").ToString)
                        podatak.SubItems.Add(Format(s_stanje, "##,##0").ToString)
                        podatak.SubItems.Add(Format(s_duguje, "##,##0.00").ToString)
                        podatak.SubItems.Add(Format(s_potrazuje, "##,##0.00").ToString)
                        podatak.SubItems.Add(Format(s_saldo, "##,##0.00").ToString)
                        listView1.Items.AddRange(New ListViewItem() {podatak})

                        Dim podatak1 As New ListViewItem(DR.Item("artikl_sifra").ToString)
                        podatak1.SubItems.Add(DR.Item("artikl_naziv").ToString)
                        podatak1.SubItems.Add("Lager")
                        podatak1.SubItems.Add(Format(_cena, "##,##0.00").ToString)
                        podatak1.SubItems.Add(Format(sdp_ulaz, "##,##0").ToString)
                        podatak1.SubItems.Add(Format(sdp_izlaz, "##,##0").ToString)
                        podatak1.SubItems.Add(Format(sdp_stanje, "##,##0").ToString)
                        podatak1.SubItems.Add(Format(sdp_duguje, "##,##0.00").ToString)
                        podatak1.SubItems.Add(Format(sdp_potrazuje, "##,##0.00").ToString)
                        podatak1.SubItems.Add(Format(sdp_saldo, "##,##0.00").ToString)
                        listView1.Items.AddRange(New ListViewItem() {podatak1})
                    End If

                    'If (_ulaz <> 0 Or _izlaz <> 0) And _
                    '    (_ulazLag <> 0 Or _izlazLag <> 0) And _
                    '    (_ulaz <> _ulazLag Or _izlaz <> _izlazLag Or _stanje <> _stanjeLag) Then

                    'End If
                    u_duguje += s_duguje
                    u_potrazuje += s_potrazuje
                    u_saldo += s_saldo
                    s_ulaz = 0
                    s_izlaz = 0
                    s_stanje = 0
                    s_duguje = 0
                    s_potrazuje = 0
                    s_saldo = 0
                    sdp_ulaz = 0
                    sdp_izlaz = 0
                    sdp_stanje = 0
                    sdp_duguje = 0
                    sdp_potrazuje = 0
                    sdp_saldo = 0
                Loop
            End If

            _forma_zapovratak = Me

            mdiMain.zatvori_kontrolu_desno()

            listView1.Dock = DockStyle.Fill

            myControl.Parent = mdiMain.splRadni.Panel2
            myControl.Dock = DockStyle.Fill
            myControl.Panel.Controls.Add(listView1)
            myControl.Panel.SetRow(listView1, 1)
            myControl.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub sumiraj(ByVal id_art As Integer, ByVal id_mag As Integer, ByVal detaljno As Boolean)

        _cena = 0
        _ulaz = 0
        _izlaz = 0
        _stanje = 0
        _duguje = 0
        _potrazuje = 0
        _saldo = 0

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "SELECT * " & _
                                "FROM rm_magacin_promene LEFT OUTER JOIN " & _
                                "rm_magacin_promene_stavka " & _
                                "ON rm_magacin_promene.id_promene = rm_magacin_promene_stavka.id_promene " & _
                                "WHERE rm_magacin_promene_stavka.id_magacin = " & id_mag & _
                                " and id_artikl = " & id_art & _
                                " and mag_datum_promene >= '" & datDatumOd.Value.Month.ToString & "/" & _
                                                                datDatumOd.Value.Day.ToString & "/" & _
                                                                datDatumOd.Value.Year.ToString & "'" & _
                                " and mag_datum_promene <= '" & datDatumDo.Value.Month.ToString & "/" & _
                                                                datDatumDo.Value.Day.ToString & "/" & _
                                                                datDatumDo.Value.Year.ToString & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                _ulaz += DR.Item("mag_art_ulaz")
                _izlaz += DR.Item("mag_art_izlaz")
                _stanje = DR.Item("mag_art_stanje")
                _duguje += DR.Item("mag_suma_ulaz")
                _potrazuje += DR.Item("mag_suma_izlaz")
                _saldo = DR.Item("mag_suma_stanje")
                _cena = DR.Item("mag_art_cena")
            Loop
        End If
    End Sub

    Private Sub sumiraj_lager(ByVal sql As String, ByVal poz_ulaz As Integer, ByVal poz_izlaz As Integer, _
                    ByVal poz_stanje As Integer)
        '_cena = 0
        _ulaz = 0
        _izlaz = 0
        _stanje = 0
        _duguje = 0
        _potrazuje = 0
        _saldo = 0
        '_jm = ""

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql
                DR = .ExecuteReader
            End With
            Do While DR.Read
                _cena = DR.Item("cena_nab_zadnja")
                If DR.Item(poz_ulaz) <> 0 Then _ulaz += DR.Item(poz_ulaz)
                If DR.Item(poz_izlaz) <> 0 Then _izlaz += DR.Item(poz_izlaz)
                If DR.Item(poz_stanje) <> 0 Then _stanje = DR.Item(poz_stanje)
                _duguje = _cena * _ulaz
                _potrazuje = _cena * _izlaz
                _saldo = _stanje * _cena
                If DR.Item("jm_oznaka") <> "" Then _jm = DR.Item("jm_oznaka")
            Loop
            DR.Close()
            CM.Dispose()
        End If
    End Sub

    Shared Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function

    Private Sub chkDatum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDatum.CheckedChanged
        Select Case chkDatum.CheckState
            Case CheckState.Checked
                datDatumOd.Enabled = True
                datDatumOd.BackColor = Color.GhostWhite
                datDatumDo.Enabled = True
                datDatumDo.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                datDatumOd.Enabled = False
                datDatumOd.BackColor = Color.Lavender
                datDatumDo.Value = Today
                datDatumDo.Enabled = False
                datDatumDo.BackColor = Color.Lavender
                datDatumOd.Value = Today
                upit_datum_od = ""
                upit_datum_do = ""
        End Select
        'proveri_formu()
    End Sub

    Private Sub chkMagacin_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMagacin.CheckedChanged
        Select Case chkMagacin.CheckState
            Case CheckState.Checked
                cmbMagacin.Enabled = True
                cmbMagacin.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbMagacin.Enabled = False
                cmbMagacin.BackColor = Color.Lavender
                cmbMagacin.Text = ""
                upit_magacin = ""
        End Select
    End Sub

    Private Sub chkSortirano_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSortirano.CheckedChanged
        Select Case chkSortirano.Checked
            Case CheckState.Checked
                cmbVrDok.Enabled = True
                cmbVrDok.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbVrDok.Enabled = False
                cmbVrDok.BackColor = Color.Lavender
                cmbVrDok.Text = ""
                'upit_sortirano = ""
        End Select
    End Sub

    'Private Sub chkABC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Select Case chkABC.CheckState
    '        Case CheckState.Checked
    '            _poABCedi = True
    '        Case CheckState.Unchecked
    '            _poABCedi = False
    '    End Select
    'End Sub
    'Private Sub chkABC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If e.KeyChar = Chr(13) Then
    '        Select Case chkABC.CheckState
    '            Case CheckState.Checked
    '                _poABCedi = True
    '            Case CheckState.Unchecked
    '                _poABCedi = True
    '        End Select
    '        filter()
    '    End If
    'End Sub

    Private Sub datDatumOd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datDatumOd.KeyPress
        If e.KeyChar = Chr(13) Then
            upit_datum_od = datDatumOd.Value.Month.ToString & "/" & _
                                 datDatumOd.Value.Day.ToString & "/" & _
                                 datDatumOd.Value.Year.ToString & "'"
            'filter()
        End If
    End Sub
    Private Sub datDatumOd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datDatumOd.ValueChanged
        upit_datum_od = datDatumOd.Value.Month.ToString & "/" & _
                                datDatumOd.Value.Day.ToString & "/" & _
                                datDatumOd.Value.Year.ToString & "'"
        'filter()
    End Sub

    Private Sub datDatumDo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datDatumDo.KeyPress
        If e.KeyChar = Chr(13) Then
            upit_datum_do = datDatumDo.Value.Month.ToString & "/" & _
                                 datDatumDo.Value.Day.ToString & "/" & _
                                 datDatumDo.Value.Year.ToString & "'"
            'filter()
        End If
    End Sub
    Private Sub datDatumDo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datDatumDo.ValueChanged
        upit_datum_do = datDatumDo.Value.Month.ToString & "/" & _
                                datDatumDo.Value.Day.ToString & "/" & _
                                datDatumDo.Value.Year.ToString & "'"
        'filter()
    End Sub

    Private Sub cmbMagacin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMagacin.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbMagacin.Text <> "" Then
                upit_magacin = "magacin_naziv = N'" & cmbMagacin.Text & "'"
                labMagacin.Text = cmbMagacin.Text
                _text_magacin = cmbMagacin.Text
            Else
                upit_magacin = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbMagacin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMagacin.SelectedIndexChanged
        If cmbMagacin.Text <> "" Then
            selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)
            upit_magacin = "magacin_naziv = N'" & cmbMagacin.Text & "'"
            labMagacin.Text = cmbMagacin.Text
            _text_magacin = cmbMagacin.Text
        Else
            upit_magacin = ""
        End If
    End Sub

    Private Sub cmbGrupaArtikla_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbGrupaArtikla.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbGrupaArtikla.Text <> "" Then
                upit_grupa = "gr_artikla_naziv = N'" & cmbGrupaArtikla.Text & "'"
            Else
                upit_grupa = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbGrupaArtikla_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGrupaArtikla.SelectedIndexChanged
        If cmbGrupaArtikla.Text <> "" Then
            upit_grupa = "gr_artikla_naziv = N'" & cmbGrupaArtikla.Text & "'"
        Else
            upit_grupa = ""
        End If
    End Sub

    Private Sub cmbVrDok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbVrDok.KeyPress
        If e.KeyChar = Chr(13) Then
            'If cmbVrDok.Text <> "" Then
            '    upit_sortirano = "ORDER id_vrsta_dok = " & cmbVrDok.Text
            'Else
            '    upit_sortirano = ""
            'End If
            filter()
        End If
    End Sub
    Private Sub cmbVrDok_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVrDok.SelectedIndexChanged
        'If cmbVrDok.Text <> "" Then
        '    upit_sortirano = "id_vrsta_dok = " & cmbVrDok.Text
        'Else
        '    upit_sortirano = ""
        'End If
    End Sub

    Private Sub rbtEkran_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtEkran.CheckedChanged
        Select Case rbtEkran.Checked
            Case True
                _ekran = True
            Case False
                _ekran = False
        End Select
    End Sub

    Private Sub rbtPrinter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPrinter.CheckedChanged
        Select Case rbtPrinter.Checked
            Case True
                _printer = True
            Case False
                _printer = False
        End Select
    End Sub

    Private Sub rbtHtml_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtHtml.CheckedChanged
        Select Case rbtHtml.Checked
            Case True
                _html = True
            Case False
                _html = False
        End Select
    End Sub

    Private Sub rbtPdf_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPdf.CheckedChanged
        Select Case rbtPdf.Checked
            Case True
                _pdf = True
            Case False
                _pdf = False
        End Select
    End Sub

    Private Sub rbtWord_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtWord.CheckedChanged
        Select Case rbtWord.Checked
            Case True
                _word = True
            Case False
                _word = False
        End Select
    End Sub

    Private Sub rbtExcel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtExcel.CheckedChanged
        Select Case rbtExcel.Checked
            Case True
                _excell = True
            Case False
                _excell = False
        End Select
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        filter()
    End Sub

#Region "STAMPANJE"

    Private id_promene As Integer = 0
    Private mag_datum_promene_od As Date '= datDatumOd.Value
    Private mag_datum_promene_do As Date '= datDatumDo.Value
    Private mag_datum_promene As Date = Today

    Private Sub stampanje()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Dim s_ulaz As Single = 0
        Dim s_izlaz As Single = 0
        Dim s_stanje As Single = 0
        Dim s_duguje As Single = 0
        Dim s_potrazuje As Single = 0
        Dim s_saldo As Single = 0

        Dim sdp_ulaz As Single = 0
        Dim sdp_izlaz As Single = 0
        Dim sdp_stanje As Single = 0
        Dim sdp_duguje As Single = 0
        Dim sdp_potrazuje As Single = 0
        Dim sdp_saldo As Single = 0

        Dim u_duguje As Single = 0
        Dim u_potrazuje As Single = 0
        Dim u_saldo As Single = 0

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prn_promet_delete"
                .ExecuteScalar()
            End With
            CM.Dispose()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from rm_artikli"
                DR = .ExecuteReader
            End With

            mag_datum_promene_od = datDatumOd.Value
            mag_datum_promene_do = datDatumDo.Value

            Do While DR.Read
                'sumiraj(DR.Item("id_artikl"), _id_magacin, False)

                sumiraj_lager(sql_magacin & " where " & upit_m & " and dbo.rm_artikli.id_artikl = " & DR.Item("id_artikl").ToString, 3, 4, 5)
                s_ulaz += _ulaz
                s_izlaz += _izlaz
                s_stanje += _stanje
                s_duguje += _duguje
                s_potrazuje += _potrazuje
                s_saldo += _saldo

                sumiraj_lager(sql_dp & " and " & upit_dp & " and dbo.rm_artikli.id_artikl = " & DR.Item("id_artikl").ToString, 9, 10, 11)
                sdp_ulaz = s_ulaz + _ulaz
                sdp_izlaz = s_izlaz + _izlaz
                sdp_stanje = s_stanje + _stanje
                sdp_duguje = s_duguje + _duguje
                sdp_potrazuje = s_potrazuje + _potrazuje
                sdp_saldo = s_saldo + _saldo

                If s_saldo <> sdp_saldo Then

                    unesi_promet_prn(id_promene, mag_datum_promene_od, mag_datum_promene_do, _
                          Today, _id_magacin, _magacin_naziv, "", _
                          "", "", "", DR.Item("id_artikl"), DR.Item("artikl_sifra"), _
                          DR.Item("artikl_naziv"), DR.Item("jkl"), _
                          s_ulaz, s_izlaz, s_stanje, _cena, s_duguje, s_potrazuje, _
                          s_saldo, "", "Stanje - Magacin", "", _grupa_art)

                    unesi_promet_prn(id_promene, mag_datum_promene_od, mag_datum_promene_do, _
                          Today, _id_magacin, _magacin_naziv, "", _
                          "", "", "", DR.Item("id_artikl"), DR.Item("artikl_sifra"), _
                          DR.Item("artikl_naziv"), DR.Item("jkl"), _
                          sdp_ulaz, sdp_izlaz, sdp_stanje, _
                          _cena, sdp_duguje, sdp_potrazuje, _
                          sdp_saldo, "", "Stanje - Lager", "", _grupa_art)
                End If
                s_ulaz = 0
                s_izlaz = 0
                s_stanje = 0
                s_duguje = 0
                s_potrazuje = 0
                s_saldo = 0
                sdp_ulaz = 0
                sdp_izlaz = 0
                sdp_stanje = 0
                sdp_duguje = 0
                sdp_potrazuje = 0
                sdp_saldo = 0
            Loop
            DR.Close()
            CM.Dispose()
        End If
        CN.Close()
        _raport = Imena.tabele.rm_promet_neslaganje.ToString
        Dim mForm As New frmPrint
        mForm.Show()
    End Sub

#End Region

End Class
