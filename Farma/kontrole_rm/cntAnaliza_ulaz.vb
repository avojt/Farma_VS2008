Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntAnaliza_ulaz

#Region "dekleracija"
    Private upit As String = ""
    Private upit_datum_od As String = ""
    Private upit_datum_do As String = ""
    Private upit_magacin As String = ""
    Private upit_oj As String = ""
    Private upit_partner As String = ""
    Private upit_vrdok As String = ""
    Private upit_sortirano As String = ""

    Shared sql As String = ""

    Private sql_detaljno As String = _
           "SELECT DISTINCT " & _
               "dbo.rm_magacin_promene.mag_datum_promene, dbo.rm_magacin_promene.id_magacin, " & _
               "dbo.rm_magacin.magacin_naziv, dbo.app_vrste_dokumenata.vrsta_dok_naziv, " & _
               "dbo.rm_artikli.artikl_sifra, dbo.rm_artikli.artikl_naziv, " & _
               "dbo.app_partneri.partner_naziv, dbo.rm_magacin_promene_stavka.id_artikl, " & _
               "dbo.rm_magacin_promene.mag_broj_dok, dbo.app_organizacione_jedinice.oj_naziv, " & _
               "dbo.rm_magacin_promene_stavka.mag_art_ulaz, dbo.rm_magacin_promene_stavka.mag_art_izlaz, " & _
               "dbo.rm_magacin_promene_stavka.mag_art_stanje, dbo.rm_magacin_promene_stavka.mag_art_cena, " & _
               "dbo.rm_magacin_promene_stavka.mag_suma_ulaz, dbo.rm_magacin_promene_stavka.mag_suma_izlaz, " & _
               "dbo.rm_magacin_promene_stavka.mag_suma_stanje, dbo.app_jm.jm_oznaka, dbo.rm_magacin_promene.id_promene " & _
            "FROM dbo.app_jm RIGHT OUTER JOIN " & _
               "dbo.rm_artikli ON dbo.app_jm.id_jm = dbo.rm_artikli.id_jm RIGHT OUTER JOIN " & _
               "dbo.app_vrste_dokumenata RIGHT OUTER JOIN " & _
               "dbo.app_organizacione_jedinice RIGHT OUTER JOIN " & _
               "dbo.rm_magacin RIGHT OUTER JOIN " & _
               "dbo.rm_magacin_promene_stavka INNER JOIN " & _
               "dbo.rm_magacin_promene ON " & _
               "dbo.rm_magacin_promene_stavka.id_promene = dbo.rm_magacin_promene.id_promene ON " & _
               "dbo.rm_magacin.id_magacin = dbo.rm_magacin_promene.id_magacin ON " & _
               "dbo.app_organizacione_jedinice.id_orgjed = dbo.rm_magacin_promene.id_oj LEFT OUTER JOIN " & _
               "dbo.app_partneri ON dbo.rm_magacin_promene.id_partner = dbo.app_partneri.id_partner ON " & _
               "dbo.app_vrste_dokumenata.id_vrsta_dok = dbo.rm_magacin_promene.id_vrsta_dok ON " & _
               "dbo.rm_artikli.id_artikl = dbo.rm_magacin_promene_stavka.id_artikl " & _
           "WHERE dbo.rm_magacin_promene_stavka.mag_art_izlaz = 0"

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
    Private _detaljno As Boolean = False

    Private _cena As Single
    Private _ulaz As Single
    Private _izlaz As Single
    Private _stanje As Single
    Private _duguje As Single
    Private _potrazuje As Single
    Private _saldo As Single
    Private _grupa_art As String = ""
#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntAnaliza_ulaz_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mPanel.Dock = DockStyle.Fill

        popuni_magacine()
        popuni_oj()
        popuni_partnere()
        popuni_vrste_dokumenta()

        cmbMagacin.Enabled = False
        cmbMagacin.BackColor = Color.Lavender
        cmbOJ.Enabled = False
        cmbOJ.BackColor = Color.Lavender
        cmbPartner.Enabled = False
        cmbPartner.BackColor = Color.Lavender
        cmbVrDok.Enabled = False
        cmbVrDok.BackColor = Color.Lavender

        datDatumOd.Enabled = True
        datDatumDo.Enabled = True
        datDatumOd.Value = CDate("1/" & Today.Month.ToString & "/" & Today.Year.ToString)
        datDatumDo.Value = Today

        chkDatum.CheckState = CheckState.Checked
        chkMagacin.CheckState = CheckState.Unchecked
        chkOJ.CheckState = CheckState.Unchecked
        chkPartner.CheckState = CheckState.Unchecked
        chkSortirano.CheckState = CheckState.Unchecked

        rbtEkran.Checked = True
        rbtPrinter.Checked = False
        rbtExcel.Checked = False
        rbtHtml.Checked = False
        rbtPdf.Checked = False
        rbtWord.Checked = False

        _text_magacin = "Svi"
        _text_partner = "Svi"
        _text_oj = "Svi"
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

    Private Sub popuni_oj()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbOJ.Items.Clear()
        cmbOJ.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.app_organizacione_jedinice"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbOJ.Items.Add(DR.Item("oj_naziv"))
            Loop
            DR.Close()
        End If
        If cmbOJ.Items.Count > 0 Then
            cmbOJ.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_partnere()
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
                .CommandText = "select * from dbo.app_partneri"
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

        upit = ""
        sql = sql_detaljno

        If upit_datum_od <> "" And upit <> "" Then
            upit = upit & " and " & upit_datum_od
        Else
            If upit_datum_od <> "" Then upit = upit_datum_od
        End If

        If upit_datum_do <> "" And upit <> "" Then
            upit = upit & " and " & upit_datum_do
        Else
            If upit_datum_do <> "" Then upit = upit_datum_do
        End If

        If upit_magacin <> "" And upit <> "" Then
            upit = upit & " and " & upit_magacin
        Else
            If upit_magacin <> "" Then upit = upit_magacin
        End If

        If upit_oj <> "" And upit <> "" Then
            upit = upit & " and " & upit_oj
        Else
            If upit_oj <> "" Then upit = upit_oj
        End If

        If upit_partner <> "" And upit <> "" Then
            upit = upit & " and " & upit_partner
        Else
            If upit_partner <> "" Then upit = upit_partner
        End If

        If upit_vrdok <> "" And upit <> "" Then
            upit = upit & " and " & upit_vrdok
        Else
            If upit_vrdok <> "" Then upit = upit_vrdok
        End If

        If upit <> "" Then
            'sql = sql_detaljno & " WHERE " & upit & " ORDER BY id_promene"
            sql = sql_detaljno & " and " & upit & " ORDER BY id_promene"
            If _ekran Then Lista()
            If _printer Then stampanje()
            'If _Excel Then
            'If _html Then
            'If _pdf Then
            'If _word Then
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

            listView1.Columns.Add("Naziv", 220, HorizontalAlignment.Left)
            listView1.Columns.Add("Cena", 70, HorizontalAlignment.Right)
            listView1.Columns.Add("Ulaz", 70, HorizontalAlignment.Right)
            'listView1.Columns.Add("Stanje", 80, HorizontalAlignment.Right)
            listView1.Columns.Add("Duguje", 90, HorizontalAlignment.Right)
            'listView1.Columns.Add("Saldo", 100, HorizontalAlignment.Right)

            Dim CN As SqlConnection = New SqlConnection(CNNString)
            Dim CM As New SqlCommand
            Dim DR As SqlDataReader
            Dim myControl As New cntLista

            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = "select * from rm_artikli"
                    DR = .ExecuteReader
                End With

                Do While DR.Read
                    sumiraj(DR.Item("id_artikl"), _id_magacin, True)

                    If _ulaz <> 0 Then

                        Dim podatak As New ListViewItem(DR.Item("artikl_naziv").ToString)
                        podatak.SubItems.Add(CSng(_cena).ToString)
                        podatak.SubItems.Add(_ulaz)
                        'podatak.SubItems.Add(_stanje)
                        podatak.SubItems.Add(CSng(_duguje.ToString).ToString)
                        'podatak.SubItems.Add(CSng(_saldo.ToString).ToString)

                        listView1.Items.AddRange(New ListViewItem() {podatak})
                    End If
                Loop
            End If

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

                Dim a As String = Now.Year.ToString
                .CommandText = sql_detaljno & " and " & upit & _
                                    " and dbo.rm_magacin_promene_stavka.id_artikl = " & id_art '& _
                '" ORDER BY id_promene"
                '" and mag_datum_promene >= '" & "01/01/" & Now.Year.ToString & "'" & _
                '" and mag_datum_promene <= '" & datDatumOd.Value.Month.ToString & "/" & _
                'datDatumOd.Value.Day.ToString & "/" & _
                'datDatumOd.Value.Year.ToString & "'" & _

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

    Private Sub chkOJ_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkOJ.CheckedChanged
        Select Case chkOJ.CheckState
            Case CheckState.Checked
                cmbOJ.Enabled = True
                cmbOJ.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbOJ.Enabled = False
                cmbOJ.BackColor = Color.Lavender
                cmbOJ.Text = ""
                upit_oj = ""
        End Select
    End Sub

    Private Sub chkPartner_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPartner.CheckedChanged
        Select Case chkPartner.CheckState
            Case CheckState.Checked
                cmbPartner.Enabled = True
                cmbPartner.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbPartner.Enabled = False
                cmbPartner.BackColor = Color.Lavender
                cmbPartner.Text = ""
                upit_partner = ""
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
            upit_datum_od = "dbo.rm_magacin_promene.mag_datum_promene >= '" & _
                                 datDatumOd.Value.Month.ToString & "/" & _
                                 datDatumOd.Value.Day.ToString & "/" & _
                                 datDatumOd.Value.Year.ToString & "'"
        End If
    End Sub
    Private Sub datDatumOd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datDatumOd.ValueChanged
        upit_datum_od = "dbo.rm_magacin_promene.mag_datum_promene >= '" & _
                                datDatumOd.Value.Month.ToString & "/" & _
                                datDatumOd.Value.Day.ToString & "/" & _
                                datDatumOd.Value.Year.ToString & "'"
    End Sub

    Private Sub datDatumDo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datDatumDo.KeyPress
        If e.KeyChar = Chr(13) Then
            upit_datum_do = "dbo.rm_magacin_promene.mag_datum_promene <= '" & _
                                 datDatumDo.Value.Month.ToString & "/" & _
                                 datDatumDo.Value.Day.ToString & "/" & _
                                 datDatumDo.Value.Year.ToString & "'"
        End If
    End Sub
    Private Sub datDatumDo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datDatumDo.ValueChanged
        upit_datum_do = "dbo.rm_magacin_promene.mag_datum_promene <= '" & _
                                datDatumDo.Value.Month.ToString & "/" & _
                                datDatumDo.Value.Day.ToString & "/" & _
                                datDatumDo.Value.Year.ToString & "'"
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

    Private Sub cmbPartner_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPartner.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbPartner.Text <> "" Then
                upit_partner = "partner_naziv = N'" & cmbPartner.Text & "'"
                _text_partner = cmbPartner.Text
            Else
                upit_partner = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbPartner_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPartner.SelectedIndexChanged
        If cmbPartner.Text <> "" Then
            upit_partner = "partner_naziv = N'" & cmbPartner.Text & "'"
            _text_partner = cmbPartner.Text
        Else
            upit_partner = ""
        End If
    End Sub

    Private Sub cmbOJ_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbOJ.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbOJ.Text <> "" Then
                upit_oj = "oj_naziv = N'" & cmbPartner.Text & "'"
                _text_oj = cmbOJ.Text
            Else
                upit_oj = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbOJ_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOJ.SelectedIndexChanged
        If cmbOJ.Text <> "" Then
            upit_oj = "oj_naziv = N'" & cmbOJ.Text & "'"
            _text_oj = cmbOJ.Text
        Else
            upit_oj = ""
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
                sumiraj(DR.Item("id_artikl"), _id_magacin, True)

                If _ulaz <> 0 Then
                    unesi_promet_prn(id_promene, mag_datum_promene_od, mag_datum_promene_do, _
                          Today, _id_magacin, _magacin_naziv, "", _
                          "", _text_oj, _text_partner, _
                          DR.Item("id_artikl"), DR.Item("artikl_sifra"), DR.Item("artikl_naziv"), DR.Item("jkl"), _
                          _ulaz, 0, _stanje, _
                          _cena, _duguje, 0, _
                          _saldo, "", "", "", _grupa_art)
                End If
            Loop
            DR.Close()
            CM.Dispose()
        End If
        CN.Close()

        _raport = Imena.tabele.rm_analiza_ulaz.ToString
        Dim mForm As New frmPrint
        mForm.Show()
    End Sub

#End Region

End Class
