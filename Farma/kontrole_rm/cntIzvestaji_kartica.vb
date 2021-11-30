Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntIzvestaji_kartica

#Region "dekleracija"
    Private upit As String = ""
    Private upit_datum_od As String = ""
    Private upit_datum_do As String = ""
    Private upit_magacin As String = ""
    Private upit_artikl As String = ""
    Private upit_grupa_art As String = ""
    Private upit_vrdok As String = ""
    Private upit_zakljuceno As String = ""
    Private upit_sortirano As String = ""

    Shared sql As String = ""

    Private sql_detaljno As String = _
           "SELECT DISTINCT " & _
               "dbo.rm_magacin_promene.mag_datum_promene, dbo.rm_magacin_promene.id_magacin, " & _
               "dbo.rm_magacin.magacin_naziv, dbo.app_vrste_dokumenata.vrsta_dok_naziv, " & _
               "dbo.rm_magacin_promene.mag_broj_dok, dbo.app_organizacione_jedinice.oj_naziv, " & _
               "dbo.app_partneri.partner_naziv, dbo.rm_magacin_promene_stavka.id_artikl, dbo.rm_artikli.artikl_sifra, dbo.rm_artikli.artikl_naziv, " & _
               "dbo.rm_magacin_promene_stavka.mag_art_ulaz, dbo.rm_magacin_promene_stavka.mag_art_izlaz, " & _
               "dbo.rm_magacin_promene_stavka.mag_art_stanje, dbo.rm_magacin_promene_stavka.mag_art_cena, " & _
               "dbo.rm_magacin_promene_stavka.mag_suma_ulaz, dbo.rm_magacin_promene_stavka.mag_suma_izlaz, " & _
               "dbo.rm_magacin_promene_stavka.mag_suma_stanje, dbo.app_jm.jm_oznaka, dbo.rm_magacin_promene.id_promene " & _
            "FROM  dbo.app_jm RIGHT OUTER JOIN " & _
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
               "dbo.rm_artikli.id_artikl = dbo.rm_magacin_promene_stavka.id_artikl"

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
#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntIzvestaji_kartica_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mPanel.Dock = DockStyle.Fill

        popuni_magacine()
        popuni_artikle()
        popuni_vrste_dokumenta()

        cmbMagacin.Enabled = False
        cmbMagacin.BackColor = Color.Lavender
        cmbVrDok.Enabled = False
        cmbVrDok.BackColor = Color.Lavender
        cmbArtikl.Enabled = False
        cmbArtikl.BackColor = Color.Lavender

        datDatumOd.Enabled = True
        datDatumDo.Enabled = True
        datDatumOd.Value = CDate("1/" & Today.Month.ToString & "/" & Today.Year.ToString)
        datDatumDo.Value = Today

        chkDatum.CheckState = CheckState.Checked
        chkMagacin.CheckState = CheckState.Unchecked
        chkArtikl.CheckState = CheckState.Unchecked

        chkDetaljno.CheckState = CheckState.Checked

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

    Private Sub popuni_artikle()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbArtikl.Items.Clear()
        cmbArtikl.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.rm_artikli order by artikl_naziv"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbArtikl.Items.Add(DR.Item("artikl_naziv"))
            Loop
            DR.Close()
        End If
        If cmbArtikl.Items.Count > 0 Then
            cmbArtikl.SelectedIndex = 0
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

        If upit_artikl <> "" And upit <> "" Then
            upit = upit & " and " & upit_artikl
        Else
            If upit_artikl <> "" Then upit = upit_artikl
        End If

        If upit_vrdok <> "" And upit <> "" Then
            upit = upit & " and " & upit_vrdok
        Else
            If upit_vrdok <> "" Then upit = upit_vrdok
        End If

        If upit_zakljuceno <> "" And upit <> "" Then
            upit = upit & " and " & upit_zakljuceno
        Else
            If upit_zakljuceno <> "" Then upit = upit_zakljuceno
        End If

        If upit <> "" Then
            sql = sql_detaljno & " WHERE " & upit & " ORDER BY id_promene"
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

            If _detaljno Then
                listView1.Columns.Add("Datum", 70, HorizontalAlignment.Left)
                listView1.Columns.Add("Šifra dok.", 60, HorizontalAlignment.Left)
                listView1.Columns.Add("OJ/Partner", 185, HorizontalAlignment.Left)
                listView1.Columns.Add("Cena", 60, HorizontalAlignment.Right)
                listView1.Columns.Add("Ulaz", 55, HorizontalAlignment.Right)
                listView1.Columns.Add("Izlaz", 55, HorizontalAlignment.Right)
                listView1.Columns.Add("Stanje", 65, HorizontalAlignment.Right)
                listView1.Columns.Add("Duguje", 90, HorizontalAlignment.Right)
                listView1.Columns.Add("Potrazuje", 90, HorizontalAlignment.Right)
                listView1.Columns.Add("Saldo", 90, HorizontalAlignment.Right)
            ElseIf _kumulativ Then
                listView1.Columns.Add("Šifra", 60, HorizontalAlignment.Left)
                listView1.Columns.Add("Naziv", 120, HorizontalAlignment.Left)
                'listView1.Columns.Add("Magacin", 90, HorizontalAlignment.Left)
                listView1.Columns.Add("Ulaz", 55, HorizontalAlignment.Right)
                listView1.Columns.Add("Izlaz", 55, HorizontalAlignment.Right)
                listView1.Columns.Add("Stanje", 65, HorizontalAlignment.Right)
                listView1.Columns.Add("Duguje", 90, HorizontalAlignment.Right)
                listView1.Columns.Add("Potrazuje", 90, HorizontalAlignment.Right)
                listView1.Columns.Add("Saldo", 90, HorizontalAlignment.Right)
            End If

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
                    .CommandText = sql
                    DR = .ExecuteReader
                End With
                Dim donos As Boolean = True
                Do While DR.Read
                    If _detaljno Then
                        If donos Then

                            sumiraj(DR.Item("id_artikl"), DR.Item("id_magacin"), True)

                            Dim podatak1 As New ListViewItem(" ")
                            podatak1.SubItems.Add("DONOS")
                            podatak1.SubItems.Add("01.01." & Now.Year & " - " & DateAdd(DateInterval.Day, -1, datDatumOd.Value.Date)) ' & "." & datDatumOd.Value.Date.Month & "." & datDatumOd.Value.Date.Year)
                            podatak1.SubItems.Add(_cena)
                            podatak1.SubItems.Add(CInt(_ulaz).ToString)
                            podatak1.SubItems.Add(CInt(_izlaz).ToString)
                            podatak1.SubItems.Add(CInt(_stanje).ToString)
                            podatak1.SubItems.Add(_duguje.ToString)
                            podatak1.SubItems.Add(_potrazuje.ToString)
                            podatak1.SubItems.Add(_saldo.ToString)

                            podatak1.ForeColor = Color.RoyalBlue
                            listView1.Items.AddRange(New ListViewItem() {podatak1})

                            donos = False
                        End If

                        Dim podatak As New ListViewItem(CStr(CDate(DR.Item("mag_datum_promene")).Date))
                        podatak.SubItems.Add(DR.Item("mag_broj_dok").ToString)
                        If DR.Item("oj_naziv").ToString <> "" Then
                            podatak.SubItems.Add(DR.Item("oj_naziv").ToString)
                        Else
                            If DR.Item("partner_naziv").ToString <> "" Then
                                podatak.SubItems.Add(DR.Item("partner_naziv").ToString)
                            Else
                                podatak.SubItems.Add("")
                            End If
                        End If
                        podatak.SubItems.Add(DR.Item("mag_art_cena").ToString)
                        podatak.SubItems.Add(CInt(DR.Item("mag_art_ulaz")).ToString)
                        podatak.SubItems.Add(CInt(DR.Item("mag_art_izlaz")).ToString)
                        podatak.SubItems.Add(CInt(DR.Item("mag_art_stanje")).ToString)
                        podatak.SubItems.Add(DR.Item("mag_suma_ulaz").ToString)
                        podatak.SubItems.Add(DR.Item("mag_suma_izlaz").ToString)
                        podatak.SubItems.Add(DR.Item("mag_suma_stanje").ToString)

                        listView1.Items.AddRange(New ListViewItem() {podatak})

                    ElseIf _kumulativ Then

                        sumiraj(DR.Item("id_artikl"), DR.Item("id_magacin"), False)

                        Dim podatak As New ListViewItem(DR.Item("artikl_sifra").ToString)
                        podatak.SubItems.Add(DR.Item("artikl_naziv").ToString)
                        podatak.SubItems.Add(_ulaz)
                        podatak.SubItems.Add(_izlaz)
                        podatak.SubItems.Add(_stanje)
                        podatak.SubItems.Add(_duguje.ToString)
                        podatak.SubItems.Add(_potrazuje.ToString)
                        podatak.SubItems.Add(_saldo.ToString)

                        listView1.Items.AddRange(New ListViewItem() {podatak})

                        _forma_zapovratak = Me

                        mdiMain.zatvori_kontrolu_desno()

                        listView1.Dock = DockStyle.Fill

                        myControl.Parent = mdiMain.splRadni.Panel2
                        myControl.Dock = DockStyle.Fill
                        myControl.Panel.Controls.Add(listView1)
                        myControl.Panel.SetRow(listView1, 0)
                        myControl.Show()

                        Exit Sub
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
                If detaljno Then
                    Dim a As String = Now.Year.ToString
                    .CommandText = "SELECT * " & _
                                   "FROM rm_magacin_promene LEFT OUTER JOIN " & _
                                   "rm_magacin_promene_stavka " & _
                                   "ON rm_magacin_promene.id_promene = rm_magacin_promene_stavka.id_promene " & _
                                   "WHERE rm_magacin_promene_stavka.id_magacin = " & id_mag & _
                                    " and id_artikl = " & id_art & _
                                    " and mag_datum_promene >= '" & "01/01/" & Now.Year.ToString & "'" & _
                                    " and mag_datum_promene <= '" & datDatumOd.Value.Month.ToString & "/" & _
                                                                    datDatumOd.Value.Day.ToString & "/" & _
                                                                    datDatumOd.Value.Year.ToString & "'"
                Else
                    .CommandText = "select * from rm_magacin_promene_stavka where id_magacin = " & id_mag & " and id_artikl = " & id_art
                End If
                DR = .ExecuteReader
            End With
            Do While DR.Read
                _ulaz += DR.Item("mag_art_ulaz")
                _izlaz += DR.Item("mag_art_izlaz")
                _stanje = DR.Item("mag_art_stanje")
                _duguje += DR.Item("mag_suma_ulaz")
                _potrazuje += DR.Item("mag_suma_izlaz")
                _saldo = DR.Item("mag_suma_stanje")
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

    Private Sub chkArtikl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkArtikl.CheckedChanged
        Select Case chkArtikl.CheckState
            Case CheckState.Checked
                cmbArtikl.Enabled = True
                cmbArtikl.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbArtikl.Enabled = False
                cmbArtikl.BackColor = Color.Lavender
                cmbArtikl.Text = ""
                upit_artikl = ""
        End Select
        'proveri_formu()
    End Sub

    Private Sub chkKumulativ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkKumulativ.CheckedChanged
        Select Case chkKumulativ.CheckState
            Case CheckState.Checked
                _kumulativ = True
                _detaljno = False
                chkDetaljno.CheckState = CheckState.Unchecked
            Case CheckState.Unchecked
                _kumulativ = False
                _detaljno = True
        End Select
    End Sub

    Private Sub chkDetaljno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDetaljno.CheckedChanged
        Select Case chkDetaljno.CheckState
            Case CheckState.Checked
                _kumulativ = False
                _detaljno = True
                chkKumulativ.CheckState = CheckState.Unchecked
            Case CheckState.Unchecked
                _kumulativ = True
                _detaljno = False
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
            'filter()
        End If
    End Sub
    Private Sub datDatumOd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datDatumOd.ValueChanged
        upit_datum_od = "dbo.rm_magacin_promene.mag_datum_promene >= '" & _
                                datDatumOd.Value.Month.ToString & "/" & _
                                datDatumOd.Value.Day.ToString & "/" & _
                                datDatumOd.Value.Year.ToString & "'"
        'filter()
    End Sub

    Private Sub datDatumDo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datDatumDo.KeyPress
        If e.KeyChar = Chr(13) Then
            upit_datum_do = "dbo.rm_magacin_promene.mag_datum_promene <= '" & _
                                 datDatumDo.Value.Month.ToString & "/" & _
                                 datDatumDo.Value.Day.ToString & "/" & _
                                 datDatumDo.Value.Year.ToString & "'"
            'filter()
        End If
    End Sub
    Private Sub datDatumDo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datDatumDo.ValueChanged
        upit_datum_do = "dbo.rm_magacin_promene.mag_datum_promene <= '" & _
                                datDatumDo.Value.Month.ToString & "/" & _
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
            upit_magacin = "magacin_naziv = N'" & cmbMagacin.Text & "'"
            labMagacin.Text = cmbMagacin.Text
            _text_magacin = cmbMagacin.Text
        Else
            upit_magacin = ""
        End If
    End Sub

    Private Sub cmbArtikl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbArtikl.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbArtikl.Text <> "" Then
                upit_artikl = "artikl_naziv = N'" & cmbArtikl.Text & "'"
                labArtikl.Text = cmbArtikl.Text
            Else
                upit_artikl = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbArtikl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbArtikl.SelectedIndexChanged
        If cmbArtikl.Text <> "" Then
            upit_artikl = "artikl_naziv = N'" & cmbArtikl.Text & "'"
            labArtikl.Text = cmbArtikl.Text
        Else
            upit_artikl = ""
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
                .CommandText = sql
                DR = .ExecuteReader
            End With

            Dim id_promene As Integer = 0
            Dim mag_datum_promene_od As Date = Today
            Dim mag_datum_promene_do As Date = Today
            Dim mag_datum_promene As Date = Today
            Dim id_magacin As Integer = 0
            Dim magacin_naziv As String = ""
            Dim vrsta_dok_naziv As String = ""
            Dim mag_broj_dok As String = ""
            Dim oj_naziv As String = ""
            Dim partner_naziv As String = ""
            Dim id_artikl As Integer = 0
            Dim artikl_sifra As String = ""
            Dim jkl As String = ""
            Dim artikl_naziv As String = ""
            Dim mag_art_ulaz As Single = 0
            Dim mag_art_izlaz As Single = 0
            Dim mag_art_stanje As Single = 0
            Dim mag_art_cena As Single = 0
            Dim mag_suma_ulaz As Single = 0
            Dim mag_suma_izlaz As Single = 0
            Dim mag_suma_stanje As Single = 0
            Dim jm_oznaka As String = ""

            _raport = Imena.tabele.rm_promet_art_detaljno.ToString

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_promene")) Then id_promene = DR.Item("id_promene")
                mag_datum_promene_od = datDatumOd.Value.Date
                mag_datum_promene_do = datDatumDo.Value.Date
                If Not IsDBNull(DR.Item("mag_datum_promene")) Then mag_datum_promene = DR.Item("mag_datum_promene")
                If Not IsDBNull(DR.Item("id_magacin")) Then id_magacin = DR.Item("id_magacin")
                If Not IsDBNull(DR.Item("magacin_naziv")) Then magacin_naziv = DR.Item("magacin_naziv")
                If Not IsDBNull(DR.Item("vrsta_dok_naziv")) Then vrsta_dok_naziv = DR.Item("vrsta_dok_naziv")
                If Not IsDBNull(DR.Item("mag_broj_dok")) Then mag_broj_dok = DR.Item("mag_broj_dok")
                If Not IsDBNull(DR.Item("oj_naziv")) Then oj_naziv = DR.Item("oj_naziv")
                If Not IsDBNull(DR.Item("partner_naziv")) Then partner_naziv = DR.Item("partner_naziv")
                If Not IsDBNull(DR.Item("id_artikl")) Then id_artikl = DR.Item("id_artikl")
                If Not IsDBNull(DR.Item("artikl_sifra")) Then artikl_sifra = DR.Item("artikl_sifra")
                If Not IsDBNull(DR.Item("artikl_naziv")) Then artikl_naziv = DR.Item("artikl_naziv")
                If Not IsDBNull(DR.Item("mag_art_ulaz")) Then mag_art_ulaz = DR.Item("mag_art_ulaz")
                If Not IsDBNull(DR.Item("mag_art_izlaz")) Then mag_art_izlaz = DR.Item("mag_art_izlaz")
                If Not IsDBNull(DR.Item("mag_art_stanje")) Then mag_art_stanje = DR.Item("mag_art_stanje")
                If Not IsDBNull(DR.Item("mag_art_cena")) Then mag_art_cena = DR.Item("mag_art_cena")
                If Not IsDBNull(DR.Item("mag_suma_ulaz")) Then mag_suma_ulaz = DR.Item("mag_suma_ulaz")
                If Not IsDBNull(DR.Item("mag_suma_izlaz")) Then mag_suma_izlaz = DR.Item("mag_suma_izlaz")
                If Not IsDBNull(DR.Item("mag_suma_stanje")) Then mag_suma_stanje = DR.Item("mag_suma_stanje")
                If Not IsDBNull(DR.Item("jm_oznaka")) Then jm_oznaka = DR.Item("jm_oznaka")

                If _kumulativ Then
                    sumiraj(DR.Item("id_artikl"), DR.Item("id_magacin"), False)

                    unesi_promet_prn(id_promene, mag_datum_promene_od, mag_datum_promene_do, _
                        mag_datum_promene, id_magacin, magacin_naziv, vrsta_dok_naziv, _
                        mag_broj_dok, oj_naziv, partner_naziv, _
                        id_artikl, artikl_sifra, artikl_naziv, jkl, _
                        _ulaz, _izlaz, _stanje, _
                        mag_art_cena, _duguje, _potrazuje, _
                        _saldo, jm_oznaka, "", "", _grupa_art)

                    _raport = Imena.tabele.rm_promet_art_kumulativ.ToString

                    Exit Do
                End If
                unesi_promet_prn(id_promene, mag_datum_promene_od, mag_datum_promene_do, _
                       mag_datum_promene, id_magacin, magacin_naziv, vrsta_dok_naziv, _
                       mag_broj_dok, oj_naziv, partner_naziv, _
                       id_artikl, artikl_sifra, artikl_naziv, jkl, _
                       mag_art_ulaz, mag_art_izlaz, mag_art_stanje, _
                       mag_art_cena, mag_suma_ulaz, mag_suma_izlaz, _
                       mag_suma_stanje, jm_oznaka, "", "", _grupa_art)
            Loop
            DR.Close()
            CM.Dispose()
        End If
        CN.Close()

        Dim mForm As New frmPrint
        mForm.Show()
    End Sub

#End Region


    
    
End Class
