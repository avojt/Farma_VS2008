Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntSpecifikacija_lager

#Region "dekleracija"
    Private upit_m As String = ""
    Private upit_dp As String = ""
    Private upit_datum As String = ""
    Private upit_magacin As String = ""
    Private upit_grupa As String = ""
    Private upit_sortirano As String = ""

    Shared sql As String = ""

    Private sql_magacin As String = _
        "SELECT DISTINCT " & _
            "dbo.rm_magacin_promene.mag_datum_promene, " & _
            "dbo.rm_magacin_promene_stavka.mag_art_stanje, " & _
            "dbo.rm_magacin_promene_stavka.mag_suma_stanje, " & _
            "dbo.rm_artikli.id_artikl, " & _
            "dbo.rm_artikli.artikl_sifra, " & _
            "dbo.rm_artikli.artikl_naziv, " & _
            "dbo.rm_artikli.jkl, " & _
            "dbo.rm_artikli.id_jm, " & _
            "dbo.rm_artikli_cene.cena_nab_zadnja, " & _
            "dbo.app_jm.jm_oznaka, " & _
            "dbo.app_artikl_grupa.gr_artikla_sifra, " & _
            "dbo.app_artikl_grupa.gr_artikla_naziv " & _
        "FROM dbo.rm_artikli INNER JOIN " & _
            "dbo.rm_magacin_promene_stavka INNER JOIN " & _
            "dbo.rm_magacin_promene ON dbo.rm_magacin_promene_stavka.id_promene = dbo.rm_magacin_promene.id_promene ON " & _
            "dbo.rm_artikli.id_artikl = dbo.rm_magacin_promene_stavka.id_artikl INNER JOIN " & _
            "dbo.rm_artikli_cene ON dbo.rm_artikli.id_artikl = dbo.rm_artikli_cene.id_artikl INNER JOIN " & _
            "dbo.app_artikl_grupa ON dbo.rm_artikli.id_grup_artikla = dbo.app_artikl_grupa.id_grup_artikla INNER JOIN " & _
            "dbo.app_jm ON dbo.rm_artikli.id_jm = dbo.app_jm.id_jm LEFT OUTER JOIN " & _
            "dbo.rm_magacin ON dbo.rm_magacin_promene.id_magacin = dbo.rm_magacin.id_magacin"

    Private sql_dp As String = _
        "SELECT DISTINCT " & _
            "dbo.rm_dnevni_promet_head.dp_datum_promene, " & _
            "dbo.rm_dnevni_promet_head.dp_zakljucen, " & _
            "dbo.rm_dnevni_promet_stavka.dp_art_stanje, " & _
            "dbo.rm_dnevni_promet_stavka.dp_suma_stanje, " & _
            "dbo.rm_magacin.magacin_naziv, " & _
            "dbo.rm_artikli.id_artikl, " & _
            "dbo.rm_artikli.artikl_sifra, " & _
            "dbo.rm_artikli.artikl_naziv, " & _
            "dbo.rm_artikli.jkl, " & _
            "dbo.rm_artikli_cene.cena_nab_zadnja, " & _
            "dbo.app_artikl_grupa.gr_artikla_sifra, " & _
            "dbo.app_artikl_grupa.gr_artikla_naziv, " & _
            "dbo.app_jm.jm_oznaka, dbo.rm_dnevni_promet_stavka.id_artikl " & _
        "FROM dbo.rm_artikli LEFT OUTER JOIN " & _
            "dbo.app_artikl_grupa ON dbo.rm_artikli.id_grup_artikla = dbo.app_artikl_grupa.id_grup_artikla LEFT OUTER JOIN " & _
            "dbo.app_jm ON dbo.rm_artikli.id_jm = dbo.app_jm.id_jm LEFT OUTER JOIN " & _
            "dbo.rm_artikli_cene ON dbo.rm_artikli.id_artikl = dbo.rm_artikli_cene.id_artikl RIGHT OUTER JOIN " & _
            "dbo.rm_dnevni_promet_stavka LEFT OUTER JOIN " & _
            "dbo.rm_dnevni_promet_head ON dbo.rm_dnevni_promet_stavka.id_dnevni_promet = dbo.rm_dnevni_promet_head.id_dnevni_promet ON " & _
            "dbo.rm_artikli.id_artikl = dbo.rm_dnevni_promet_stavka.id_artikl LEFT OUTER JOIN " & _
            "dbo.rm_magacin ON dbo.rm_dnevni_promet_head.id_magacin = dbo.rm_magacin.id_magacin " & _
        "WHERE (dbo.rm_dnevni_promet_head.dp_zakljucen = 0)"

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

    Private _cena As Decimal
    Private _stanje As Decimal
    Private _saldo As Decimal
    Private _jm As String = ""
    Private _grupa_art As String = ""
#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntSpecifikacija_lager_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        mPanel.Dock = DockStyle.Fill

        popuni_magacine()
        popuni_grupe()
        popuni_vrste_dokumenta()

        cmbMagacin.Enabled = True
        cmbMagacin.BackColor = Color.GhostWhite
        cmbGrupa.Enabled = False
        cmbGrupa.BackColor = Color.Lavender
        cmbVrDok.Enabled = False
        cmbVrDok.BackColor = Color.Lavender

        datDatumOd.Enabled = True
        datDatumOd.Value = Today ' CDate("1/" & Today.Month.ToString & "/" & Today.Year.ToString)

        chkDatum.CheckState = CheckState.Checked
        chkMagacin.CheckState = CheckState.Checked
        chkGrupa.CheckState = CheckState.Unchecked
        chkSortirano.CheckState = CheckState.Unchecked

        rbtEkran.Checked = True
        rbtPrinter.Checked = False
        rbtExcel.Checked = False
        rbtHtml.Checked = False
        rbtPdf.Checked = False
        rbtWord.Checked = False

        _text_magacin = "Svi"
        _text_datum = datDatumOd.Value.Date
        _text_grupa = "Sve"
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

        cmbGrupa.Items.Clear()
        cmbGrupa.Items.Add("")

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

            If upit_datum <> "" And upit_m <> "" And upit_dp <> "" Then
                upit_m = upit_m & " and dbo.rm_magacin_promene.mag_datum_promene <= '" & upit_datum
                upit_dp = upit_dp & " and dbo.rm_dnevni_promet_head.dp_datum_promene <= '" & upit_datum
            Else
                If upit_datum <> "" Then
                    upit_m = " dbo.rm_magacin_promene.mag_datum_promene <= '" & upit_datum
                    upit_dp = " dbo.rm_dnevni_promet_head.dp_datum_promene <= '" & upit_datum
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

            'If upit <> "" Then
            'sql = sql_detaljno & " WHERE " & upit & " ORDER BY id_promene"
            'sql = sql_dp & " and " & upit '& " ORDER BY id_promene"
            If _ekran Then Lista()
            If _printer Then stampanje()
            'If _Excel Then
            'If _html Then
            'If _pdf Then
            'If _word Then
            'End If
        Else
            MsgBox("Magacin morate obavezno uneti", MsgBoxStyle.OkOnly)
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

            listView1.Columns.Add("Šifra", 70, HorizontalAlignment.Left)
            listView1.Columns.Add("Naziv", 250, HorizontalAlignment.Left)
            listView1.Columns.Add("jkl", 70, HorizontalAlignment.Left)
            listView1.Columns.Add("jm", 50, HorizontalAlignment.Center)
            listView1.Columns.Add("Cena", 80, HorizontalAlignment.Right)
            listView1.Columns.Add("Stanje", 80, HorizontalAlignment.Right)
            listView1.Columns.Add("Saldo", 80, HorizontalAlignment.Right)

            Dim myControl As New cntLista

            Dim i As Integer = 0
            Dim interval As Integer = DateDiff(DateInterval.Day, datDatumOd.Value, Today)
            Dim s_stanje As Single = 0
            Dim s_saldo As Single = 0
            Dim u_saldo As Single = 0

            Dim CN As SqlConnection = New SqlConnection(CNNString)
            Dim CM As New SqlCommand
            Dim DR As SqlDataReader

            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = "select * from rm_artikli" ' sql_magacin & " and " & upit
                    DR = .ExecuteReader
                End With
                Do While DR.Read
                    _cena = 0

                    sumiraj(sql_magacin & " where " & upit_m & " and dbo.rm_artikli.id_artikl = " & DR.Item("id_artikl").ToString, 1)
                    s_stanje += _stanje
                    s_saldo += _saldo

                    sumiraj(sql_dp & " and " & upit_dp & " and dbo.rm_artikli.id_artikl = " & DR.Item("id_artikl").ToString, 2)
                    s_stanje += _stanje
                    s_saldo += _saldo

                    If s_stanje <> 0 Then
                        Dim podatak As New ListViewItem(DR.Item("artikl_sifra").ToString)
                        podatak.SubItems.Add(DR.Item("artikl_naziv").ToString)
                        podatak.SubItems.Add(DR.Item("jkl").ToString)
                        podatak.SubItems.Add(_jm)
                        podatak.SubItems.Add(Format(_cena, "##,##0.00").ToString)
                        podatak.SubItems.Add(Format(s_stanje, "##,##0").ToString)
                        podatak.SubItems.Add(Format(s_saldo, "##,##0.00").ToString)
                        listView1.Items.AddRange(New ListViewItem() {podatak})
                    End If

                    u_saldo += s_saldo
                    s_stanje = 0
                    s_saldo = 0
                Loop
                DR.Close()
                CM.Dispose()
            End If

            'UKUPNO
            Dim podatak1 As New ListViewItem("UKUPNO")
            podatak1.SubItems.Add(" ")
            podatak1.SubItems.Add(" ")
            podatak1.SubItems.Add(" ")
            podatak1.SubItems.Add(" ")
            podatak1.SubItems.Add(" ")
            podatak1.SubItems.Add(Format(u_saldo, "##,##0.00").ToString)
            podatak1.ForeColor = Color.RoyalBlue
            listView1.Items.AddRange(New ListViewItem() {podatak1})

            mdiMain.zatvori_kontrolu_desno()

            _forma_zapovratak = Me

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

    Private Sub sumiraj(ByVal sql As String, ByVal poz_stanje As Integer)
        '_cena = 0
        _stanje = 0
        _saldo = 0

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
                _stanje = DR.Item(poz_stanje)
                _saldo = _stanje * _cena
                _jm = DR.Item("jm_oznaka")
            Loop
            DR.Close()
            CM.Dispose()
        End If
    End Sub

    Private Sub chkDatum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDatum.CheckedChanged
        Select Case chkDatum.CheckState
            Case CheckState.Checked
                datDatumOd.Enabled = True
                datDatumOd.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                datDatumOd.Enabled = False
                datDatumOd.BackColor = Color.Lavender
                datDatumOd.Value = Today
                upit_datum = ""
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

    Private Sub chkGrupa_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkGrupa.CheckedChanged
        Select Case chkGrupa.CheckState
            Case CheckState.Checked
                cmbGrupa.Enabled = True
                cmbGrupa.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbGrupa.Enabled = False
                cmbGrupa.BackColor = Color.Lavender
                cmbGrupa.Text = ""
                upit_grupa = ""
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
                upit_sortirano = ""
        End Select
    End Sub

    Private Sub chkABC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case chkABC.CheckState
            Case CheckState.Checked
                _poABCedi = True
            Case CheckState.Unchecked
                _poABCedi = False
        End Select
    End Sub
    Private Sub chkABC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub datDatumOd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datDatumOd.KeyPress
        If e.KeyChar = Chr(13) Then
            upit_datum = datDatumOd.Value.Month.ToString & "/" & _
                                 datDatumOd.Value.Day.ToString & "/" & _
                                 datDatumOd.Value.Year.ToString & "'"
            _text_datum = datDatumOd.Value.Date.ToString
        End If
    End Sub
    Private Sub datDatumOd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datDatumOd.ValueChanged
        upit_datum = datDatumOd.Value.Month.ToString & "/" & _
                                datDatumOd.Value.Day.ToString & "/" & _
                                datDatumOd.Value.Year.ToString & "'"
        _text_datum = datDatumOd.Value.Date.ToString
    End Sub

    Private Sub cmbMagacin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMagacin.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbMagacin.Text <> "" Then
                selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)
                upit_magacin = "magacin_naziv = N'" & cmbMagacin.Text & "'"
                labMagacin.Text = cmbMagacin.Text
                _text_magacin = cmbMagacin.Text '+ " - PROIZVODJAČ: " + cmbPartner.Text
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
            _text_magacin = cmbMagacin.Text '+ " - PROIZVODJAČ: " + cmbPartner.Text
        Else
            upit_magacin = ""
        End If
    End Sub

    Private Sub cmbGrupa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbGrupa.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbGrupa.Text <> "" Then
                upit_grupa = "gr_artikla_naziv = N'" & cmbGrupa.Text & "'"
                _text_grupa = cmbGrupa.Text
            Else
                upit_grupa = ""
                _text_grupa = "Sve"
            End If
            filter()
        End If
    End Sub
    Private Sub cmbGrupa_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbGrupa.SelectedIndexChanged
        If cmbGrupa.Text <> "" Then
            upit_grupa = "gr_artikla_naziv = N'" & cmbGrupa.Text & "'"
            _text_oj = cmbGrupa.Text
        Else
            upit_grupa = ""
            _text_oj = "Sve"
        End If
    End Sub

    Private Sub cmbVrDok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbVrDok.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbVrDok.Text <> "" Then
                upit_sortirano = "ORDER id_vrsta_dok = " & cmbVrDok.Text
            Else
                upit_sortirano = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbVrDok_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVrDok.SelectedIndexChanged
        If cmbVrDok.Text <> "" Then
            upit_sortirano = "id_vrsta_dok = " & cmbVrDok.Text
        Else
            upit_sortirano = ""
        End If
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
        Dim s_stanje As Single = 0
        Dim s_saldo As Single = 0

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
                .CommandText = "select * from rm_artikli" ' sql_magacin & " and " & upit
                DR = .ExecuteReader
            End With
            Do While DR.Read
                _cena = 0

                sumiraj(sql_magacin & " where " & upit_m & " and dbo.rm_artikli.id_artikl = " & DR.Item("id_artikl").ToString, 1)
                s_stanje += _stanje
                s_saldo += _saldo

                sumiraj(sql_dp & " and " & upit_dp & " and dbo.rm_artikli.id_artikl = " & DR.Item("id_artikl").ToString, 2)
                s_stanje += _stanje
                s_saldo += _saldo

                If s_stanje <> 0 Then
                    unesi_promet_prn(id_promene, datDatumOd.Value.Date, Today, _
                          datDatumOd.Value.Date, _id_magacin, cmbMagacin.Text, _
                          "", "", "", "", "", DR.Item("artikl_sifra"), DR.Item("artikl_naziv"), DR.Item("jkl"), _
                          0, 0, s_stanje, _cena, 0, 0, s_saldo, "", "", "", _text_grupa)
                End If

                s_stanje = 0
                s_saldo = 0
            Loop
            DR.Close()
            CM.Dispose()
        End If
        CM.Dispose()
        CN.Close()

        _raport = Imena.tabele.rm_specifikacija_lager.ToString
        Dim mForm As New frmPrint
        mForm.Show()

    End Sub

#End Region

    
End Class
