Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntOtvorene_stavke_ispravke
    Private upit As String = ""
    Private upit_analitika As String = ""
    Private upit_analitikaOD As String = ""
    Private upit_analitikaDO As String = ""
    Private upit_kontoOD As String = ""
    Private upit_kontoDO As String = ""
    Private upit_datumOD As String = ""
    Private upit_datumDO As String = ""
    Private upit_datOD As Date = Today
    Private upit_datDO As Date = Today
    Shared sql_start As String = "SELECT * FROM dbo.fn_otvorene_stavke"
    Shared sql As String = ""

    Shared sql_nalog As String = ""
    Shared sql_start_nalog As String = _
                "SELECT dbo.fn_nalog_head.nal_broj, dbo.fn_nalog_head.nal_datum,  " & _
                    "dbo.fn_nalog_stavka.stavka_rb, dbo.fn_nalog_stavka.stavka_opis_sifra, " & _
                    "dbo.fn_nalog_stavka.stavka_opis, dbo.fn_nalog_stavka.stavka_konto, " & _
                    "dbo.fn_nalog_stavka.stavka_analitika, dbo.fn_nalog_stavka.stavka_duguje, " & _
                    "dbo.fn_nalog_stavka.stavka_potrazuje, dbo.fn_nalog_head.nal_vrsta, " & _
                    "dbo.fn_nalog_stavka.stavka_brDok, dbo.fn_nalog_stavka.stavka_datDok, " & _
                    "dbo.fn_nalog_stavka.stavka_valuta, dbo.fn_nalog_stavka.id_stavka " & _
                "FROM dbo.fn_nalog_stavka INNER JOIN " & _
                    "dbo.fn_nalog_head ON dbo.fn_nalog_stavka.id_nalog = dbo.fn_nalog_head.id_nalog "

    Private _pocetak As Boolean = True
    Private aktivan_chk As Boolean
    Private kupci As Boolean
    Private _stampac As Boolean = False

    Private konto() As String
    Private analitika() As Integer
    Private dodati() As Integer
    Private id_razvezani() As Integer
    Private id_stavke() As Integer
    Private duguje As Single = 0
    Private potrazuje As Single = 0
    Private saldo_dug As Single = 0
    Private saldo_pot As Single = 0
    Private saldo As Single = 0
    Private _pozicija_an As Integer = 0
    Private _pozicija_kon As Integer = 0
    Private veza_broj As Integer
    Private preg_povezanih As Boolean = False

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntOtvorene_stavke_ispravke_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mPanel.Dock = DockStyle.Fill
        Spliter_tabele.Dock = DockStyle.Fill
        Spliter_tabele.SplitterDistance = (Spliter_tabele.Width / 2) - 2

        cmbAnalitikaOD.Enabled = False
        cmbAnalitikaOD.BackColor = Color.Lavender
        
        cmbKontoOD.Enabled = False
        cmbKontoOD.BackColor = Color.Lavender

        chkKupci.CheckState = CheckState.Checked
        chkDobavljaci.CheckState = CheckState.Unchecked

        pocetak()
    End Sub

    Private Sub pocetak()
        _lCount = labCount
        lPartnerOD.Text = ""
        lKontoOD.Text = ""
        labAnalitika.Text = ""
        labPartner.Text = ""

        chkKonto.CheckState = CheckState.Checked
        chkAnalitika.CheckState = CheckState.Checked
        chkDatum.CheckState = CheckState.Checked

        popuni_partnere()
        popuni_konta()

        If kupci Then
            upit_analitika = "analitika >= N'3000'"
        Else
            upit_analitika = "analitika >= N'4000'"
        End If
        If kupci Then
            upit_kontoOD = "konto >= N'122111'"
        Else
            upit_kontoOD = "konto >= N'252111'"
        End If

        upit_datOD = CDate("1/1/" & Now.Year.ToString).Date

        btnDesnoAn.Enabled = False
        btnLevoAn.Enabled = False

        preg_povezanih = True
        btnPovezi.Enabled = False

        'red_broj = Nadji_rb("fn_otvorene_stavke", 1)
    End Sub

    Private Sub popuni_partnere()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbAnalitikaOD.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                If kupci Then
                    .CommandText = "select dbo.app_partneri.* from dbo.app_partneri where partner_kupac = 1 and partner_sifra >= '3000' and partner_sifra < '4000'"
                Else
                    .CommandText = "select dbo.app_partneri.* from dbo.app_partneri where partner_dobavljac = 1" ' partner_sifra >= '4000' and partner_sifra < '5000'"
                End If
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbAnalitikaOD.Items.Add(DR.Item("partner_sifra"))
            Loop
            DR.Close()
        End If
        If cmbAnalitikaOD.Items.Count > 0 Then
            cmbAnalitikaOD.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_konta()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbKontoOD.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                If kupci Then
                    .CommandText = "select dbo.app_konto.* from dbo.app_konto where Konto_Sifra >= N'122111' and Konto_Sifra <= N'122122' order by Konto_Sifra"
                Else
                    .CommandText = "select dbo.app_konto.* from dbo.app_konto where Konto_Sifra >= N'252111' and Konto_Sifra <= N'252211' order by Konto_Sifra"
                End If
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbKontoOD.Items.Add(DR.Item("Konto_Sifra"))
            Loop
            DR.Close()
        End If
        If cmbKontoOD.Items.Count > 0 Then
            cmbKontoOD.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub filter()
        upit = ""
        sql = ""

        If upit_analitika <> "" And upit <> "" Then
            upit = upit & " and " & upit_analitika
        Else
            If upit_analitika <> "" Then upit = upit_analitika
        End If

        If upit_kontoOD <> "" And upit <> "" Then
            upit = upit & " and " & upit_kontoOD
        Else
            If upit_kontoOD <> "" Then upit = upit_kontoOD
        End If

        If preg_povezanih Then
            If upit <> "" Then
                sql = sql_start & " WHERE " & upit '& " and stavka_zatvorena = 1"
            Else
                sql = sql_start
            End If
        Else
            If upit <> "" Then
                sql = sql_start_nalog & " WHERE " & upit & " and stavka_zatvorena = 0"
            Else
                sql = sql_start_nalog & " and stavka_zatvorena = 0"
            End If
        End If

        izdvoj_analitiku()

        'If Not _stampac Then
        '    'Lista()
        'End If

    End Sub

    Private Sub izdvoj_analitiku()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        With CM
            .Connection = CN
            .CommandType = CommandType.Text
            .CommandText = sql
            DR = .ExecuteReader
        End With

        _broj_stavki = 0
        Do While DR.Read
            _broj_stavki += 1
        Loop
        DR.Close()
        'CM.Dispose()

        If _broj_stavki > 0 Then
            DR = CM.ExecuteReader
            Dim i As Integer = 0
            If preg_povezanih Then
                analitika = New Integer() {}
                ReDim analitika(_broj_stavki - 1)

                id_razvezani = New Integer() {}
                ReDim id_razvezani(_broj_stavki - 1)

                id_stavke = New Integer() {}
                ReDim id_stavke(_broj_stavki - 1)

                Dim ubacen As Integer = 0
                Do While DR.Read
                    If ubacen <> DR.Item("vezni_broj") Then
                        analitika.SetValue(DR.Item("vezni_broj"), i)
                        ubacen = DR.Item("vezni_broj")
                        i += 1
                    End If
                    veza_broj = DR.Item("vezni_broj")
                Loop
            Else
                dodati = New Integer() {}
                ReDim dodati((_broj_stavki * 2) - 1)

                'Do While DR.Read
                '    If ima_promet(sql_start_nalog & " and stavka_analitika = N'" & RTrim(cmbAnalitikaOD.Text) & "'") Then
                '        'analitika_dodaj.SetValue(RTrim(cmbAnalitikaOD.Text), i)
                '        i += 1
                '    End If
                'Loop
            End If

            DR.Close()
            CM.Dispose()
            _pozicija_an = 0

            If Not _stampac Then
                dugmeta_analitika()
                postavi_analitiku(_pozicija_an)
            End If

        Else
            labPartner.Text = "Analitika nema promena u zadatom periodu."
        End If
    End Sub

    Private Sub postavi_analitiku(ByVal pozicija)
        If preg_povezanih Then
            If analitika.Length > 0 Then
                If analitika(pozicija) <> 0 Then
                    sql = sql_start & " where analitika = N'" & RTrim(cmbAnalitikaOD.Text) & "' and vezni_broj = " & analitika(pozicija)
                    labAnalitika.Text = cmbAnalitikaOD.Text ' analitika(pozicija)
                    labPartner.Text = "Broj: " & analitika(pozicija)
                End If
            End If
        End If
        Lista()
    End Sub

    Private Sub Lista()
        Try
            lvLista_duguje.CheckBoxes = True
            lvLista_potrazuje.CheckBoxes = True

            Dim CN As SqlConnection = New SqlConnection(CNNString)
            Dim CM As New SqlCommand
            Dim DR As SqlDataReader

            If preg_povezanih Then
                lvLista_duguje.Items.Clear()
                lvLista_potrazuje.Items.Clear()
            End If

            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = sql '& " and stavka_analitika = N'" & analitika(_pozicija_an) & "' and stavka_konto = N'" & konto(_pozicija_kon) & "'"
                    DR = .ExecuteReader
                End With

                If preg_povezanih Then
                    saldo_dug = 0
                    saldo_pot = 0
                    saldo = 0
                End If
                Dim i As Integer = 0
                While DR.Read
                    If preg_povezanih Then
                        If DR.Item("id_dug") <> 0 Then
                            selektuj_nalog_stavka(DR.Item("id_dug"), Selekcija.po_id)
                        Else
                            selektuj_nalog_stavka(DR.Item("id_pot"), Selekcija.po_id)
                        End If
                        selektuj_nalog(_id_nalog, Selekcija.po_id)

                        Dim podatak As New ListViewItem(DR.Item("vezni_broj").ToString)
                        podatak.SubItems.Add(_nal_datum)
                        podatak.SubItems.Add(_nal_vrsta)
                        podatak.SubItems.Add(_nal_broj)
                        podatak.SubItems.Add(RTrim(_stavka_datDok))
                        podatak.SubItems.Add(RTrim(_stavka_brDok))

                        If DR.Item("id_dug") <> 0 Then
                            podatak.SubItems.Add(Format(_stavka_duguje, "##,##0.00").ToString)
                            podatak.SubItems.Add(DR.Item("id_dug"))
                            podatak.SubItems.Add(DR.Item("id_os"))
                            podatak.Checked = True
                            lvLista_duguje.Items.AddRange(New ListViewItem() {podatak})
                        Else
                            podatak.SubItems.Add(Format(_stavka_potrazuje, "##,##0.00").ToString)
                            podatak.SubItems.Add(DR.Item("id_pot"))
                            podatak.SubItems.Add(DR.Item("id_os"))
                            podatak.Checked = True
                            lvLista_potrazuje.Items.AddRange(New ListViewItem() {podatak})
                        End If
                        veza_broj = DR.Item("vezni_broj")
                    Else
                        Dim podatak As New ListViewItem(" ")
                        podatak.SubItems.Add(DR.Item("nal_datum"))
                        podatak.SubItems.Add(RTrim(DR.Item("nal_vrsta")))
                        podatak.SubItems.Add(RTrim(DR.Item("nal_broj")))
                        podatak.SubItems.Add(RTrim(DR.Item("stavka_datDok")))
                        podatak.SubItems.Add(RTrim(DR.Item("stavka_brDok")))

                        If DR.Item("stavka_duguje") <> 0 Then
                            podatak.SubItems.Add(Format(DR.Item("stavka_duguje"), "##,##0.00").ToString)
                            podatak.SubItems.Add(DR.Item("id_stavka"))
                            podatak.SubItems.Add("")
                            lvLista_duguje.Items.AddRange(New ListViewItem() {podatak})
                            dodati.SetValue(DR.Item("id_stavka"), i * 2)
                            dodati.SetValue(0, (i * 2) + 1)
                        Else
                            podatak.SubItems.Add(Format(DR.Item("stavka_potrazuje"), "##,##0.00").ToString)
                            podatak.SubItems.Add(DR.Item("id_stavka"))
                            podatak.SubItems.Add("")
                            lvLista_potrazuje.Items.AddRange(New ListViewItem() {podatak})
                            dodati.SetValue(DR.Item("id_stavka"), i * 2)
                            dodati.SetValue(1, (i * 2) + 1)
                        End If
                        i += 1
                    End If
                End While
                DR.Close()
            End If
            CM.Dispose()
            CN.Close()

            _lCount.Text = "od " & Format(upit_datOD, "D")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Shared Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function

    Private Sub chkKonto_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkKonto.CheckedChanged
        Select Case chkKonto.CheckState
            Case CheckState.Checked
                cmbKontoOD.Enabled = True
                cmbKontoOD.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbKontoOD.Enabled = False
                cmbKontoOD.BackColor = Color.Lavender
                upit_kontoOD = ""
                cmbKontoOD.Text = ""
        End Select
    End Sub

    Private Sub chkAnalitika_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAnalitika.CheckedChanged
        Select Case chkAnalitika.CheckState
            Case CheckState.Checked
                cmbAnalitikaOD.Enabled = True
                cmbAnalitikaOD.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbAnalitikaOD.Enabled = False
                cmbAnalitikaOD.BackColor = Color.Lavender
                If kupci Then
                    upit_analitika = "stavka_analitika = N'3000'"
                Else
                    upit_analitika = "stavka_analitika = N'4000'"
                End If
                cmbAnalitikaOD.Text = ""
        End Select
    End Sub

    Private Sub chkDatum_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDatum.CheckedChanged
        'Select Case chkDatum.CheckState
        '    Case CheckState.Checked
        '        datDatOD.Enabled = True
        '        datDatOD.BackColor = Color.GhostWhite
        '        datDatOD.Value = CDate("1/1/" & Now.Year.ToString).Date
        '    Case CheckState.Unchecked
        '        datDatOD.Enabled = False
        '        datDatOD.BackColor = Color.Lavender
        '        datDatOD.Value = Today
        '        upit_datumOD = "nal_datum >= '1/1/" & Now.Year.ToString & "'"
        'End Select
    End Sub

    Private Sub chkDobavljaci_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDobavljaci.CheckedChanged
        Select Case chkDobavljaci.CheckState
            Case CheckState.Checked
                kupci = False
                chkKupci.CheckState = CheckState.Unchecked
            Case CheckState.Unchecked
                kupci = True
                chkKupci.CheckState = CheckState.Checked
        End Select
        pocetak()
    End Sub

    Private Sub chkKupci_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkKupci.CheckedChanged
        Select Case chkKupci.CheckState
            Case CheckState.Checked
                kupci = True
                chkDobavljaci.CheckState = CheckState.Unchecked
            Case CheckState.Unchecked
                kupci = False
                chkDobavljaci.CheckState = CheckState.Checked
        End Select
        pocetak()
    End Sub

    Private Sub cmbKontoOD_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbKontoOD.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbKontoOD.Text <> "" Then
                If preg_povezanih Then
                    upit_kontoOD = "konto = N'" & RTrim(cmbKontoOD.Text) & "'"
                Else
                    upit_kontoOD = "stavka_konto >= N'" & RTrim(cmbKontoOD.Text) & "'"
                End If
            Else
                upit_kontoOD = ""
            End If
            filter()
        End If
    End Sub

    Private Sub cmbKontoOD_SelectedIndexChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbKontoOD.SelectedIndexChanged
        If cmbKontoOD.Text <> "" Then
            If preg_povezanih Then
                upit_kontoOD = "konto = N'" & RTrim(cmbKontoOD.Text) & "'"
            Else
                upit_kontoOD = "stavka_konto >= N'" & RTrim(cmbKontoOD.Text) & "'"
            End If
        Else
            upit_kontoOD = ""
        End If
        'cmbKontoDO.SelectedItem = cmbKontoOD.Text
        konto_text(cmbKontoOD.Text, "OD")
    End Sub

    Private Sub konto_text(ByVal _konto, ByVal _OD_DO)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from app_konto where Konto_Sifra = '" & RTrim(_konto) & "'"
                DR = .ExecuteReader
            End With

            Do While DR.Read
                Select Case _OD_DO
                    Case "OD"
                        lKontoOD.Text = DR.Item("Naziv")
                End Select
            Loop
            DR.Close()
        End If
    End Sub

    Private Sub cmbPartner_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbAnalitikaOD.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbAnalitikaOD.Text <> "" Then
                If preg_povezanih Then
                    upit_analitika = "analitika = N'" & RTrim(cmbAnalitikaOD.Text) & "'"
                Else
                    upit_analitika = "stavka_analitika >= N'" & RTrim(cmbAnalitikaOD.Text) & "'"
                End If
            Else
                upit_analitika = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbPartner_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAnalitikaOD.SelectedIndexChanged
        If cmbAnalitikaOD.Text <> "" Then
            If preg_povezanih Then
                upit_analitika = "analitika = N'" & RTrim(cmbAnalitikaOD.Text) & "'"
            Else
                upit_analitika = "stavka_analitika >= N'" & RTrim(cmbAnalitikaOD.Text) & "'"
            End If
        Else
            upit_analitika = ""
        End If
        'cmbAnalitikaDO.SelectedItem = cmbAnalitikaOD.Text
        partner_text(cmbAnalitikaOD.Text, "OD")
    End Sub

    Private Sub partner_text(ByVal _sifra, ByVal _OD_DO)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from app_partneri where partner_sifra = '" & RTrim(_sifra) & "'"
                DR = .ExecuteReader
            End With

            Do While DR.Read
                Select Case _OD_DO
                    Case "OD"
                        lPartnerOD.Text = DR.Item("partner_naziv")
                End Select
            Loop
            DR.Close()
        End If
    End Sub

    Private Sub datDatOD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datDatOD.KeyPress
        'If e.KeyChar = Chr(13) Then
        '    upit_datumOD = "nal_datum >= '" & _
        '                         datDatOD.Value.Month.ToString & "/" & _
        '                         datDatOD.Value.Day.ToString & "/" & _
        '                         datDatOD.Value.Year.ToString & "'"
        '    upit_datOD = datDatOD.Value
        '    filter()
        'End If
    End Sub
    Private Sub datDatOD_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles datDatOD.ValueChanged
        'upit_datumOD = "nal_datum >= '" & _
        '               datDatOD.Value.Month.ToString & "/" & _
        '               datDatOD.Value.Day.ToString & "/" & _
        '               datDatOD.Value.Year.ToString & "'" '& _
        'upit_datOD = datDatOD.Value
        ''filter()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        '_stampac = True
        preg_povezanih = True

        lvLista_duguje.Items.Clear()
        lvLista_potrazuje.Items.Clear()

        If cmbKontoOD.Text <> "" Then
            upit_kontoOD = "konto = N'" & RTrim(cmbKontoOD.Text) & "'"
        Else
            upit_kontoOD = ""
        End If

        If cmbAnalitikaOD.Text <> "" Then
            upit_analitika = "analitika = N'" & RTrim(cmbAnalitikaOD.Text) & "'"
        Else
            upit_analitika = ""
        End If

        filter()
    End Sub

    Private Sub btnDesno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesnoAn.Click
        _pozicija_an = _pozicija_an + 1
        postavi_analitiku(_pozicija_an)
        dugmeta_analitika()
        'Lista()
    End Sub

    Private Sub btnLevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLevoAn.Click
        _pozicija_an = _pozicija_an - 1
        postavi_analitiku(_pozicija_an)
        dugmeta_analitika()
        'Lista()
        'veza_broj = rb_os(labKonto.Text, labAnalitika.Text)
    End Sub

    Private Sub dugmeta_analitika()
        If _pozicija_an > 0 Then
            btnLevoAn.Enabled = True
        Else
            btnLevoAn.Enabled = False
        End If
        If _pozicija_an = analitika.Length - 1 Then
            btnDesnoAn.Enabled = False
        Else
            btnDesnoAn.Enabled = True
        End If
    End Sub

    Private Sub lvLista_potrazuje_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lvLista_potrazuje.ItemCheck
        Dim i As Integer = 0
        Dim pozicija As Integer = 0
        For i = 0 To id_razvezani.Length - 1
            If id_razvezani(i) <> 0 Then
                pozicija += 1
            End If
        Next
        If e.NewValue = CheckState.Checked Then
            saldo_pot += CSng(lvLista_potrazuje.Items(e.Index).SubItems(6).Text)
            lvLista_potrazuje.Items(e.Index).Text = veza_broj
            If preg_povezanih Then
                id_razvezani.SetValue(CInt(lvLista_potrazuje.Items(e.Index).SubItems(8).Text), pozicija)
                id_stavke.SetValue(CInt(lvLista_potrazuje.Items(e.Index).SubItems(7).Text), pozicija)
            End If
        Else
            saldo_pot -= CSng(lvLista_potrazuje.Items(e.Index).SubItems(6).Text)
            lvLista_potrazuje.Items(e.Index).Text = ""
            If preg_povezanih Then
                For i = 0 To id_razvezani.Length - 1
                    If id_razvezani(i) = CInt(lvLista_potrazuje.Items(e.Index).SubItems(8).Text) Then
                        id_razvezani.SetValue(0, i)
                        id_stavke.SetValue(0, i)
                    End If
                Next
            End If
        End If
        presaberi()
    End Sub

    Private Sub lvLista_duguje_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lvLista_duguje.ItemCheck
        Dim i As Integer = 0
        Dim pozicija As Integer = 0
        For i = 0 To id_razvezani.Length - 1
            If id_razvezani(i) <> 0 Then
                pozicija += 1
            End If
        Next
        If e.NewValue = CheckState.Checked Then
            saldo_dug += lvLista_duguje.Items(e.Index).SubItems(6).Text
            lvLista_duguje.Items(e.Index).Text = veza_broj
            'id_razvezani.SetValue(CInt(lvLista_duguje.Items(e.Index).SubItems(8).Text), pozicija)
            'id_stavke.SetValue(CInt(lvLista_duguje.Items(e.Index).SubItems(7).Text), pozicija)
            If preg_povezanih Then
                For i = 0 To id_razvezani.Length - 1
                    If id_razvezani(i) = CInt(lvLista_duguje.Items(e.Index).SubItems(8).Text) Then
                        id_razvezani.SetValue(0, i)
                        id_stavke.SetValue(0, i)
                    End If
                Next
            End If
        Else
            saldo_dug -= lvLista_duguje.Items(e.Index).SubItems(6).Text
            lvLista_duguje.Items(e.Index).Text = ""
            If preg_povezanih Then
                id_razvezani.SetValue(CInt(lvLista_duguje.Items(e.Index).SubItems(8).Text), pozicija)
                id_stavke.SetValue(CInt(lvLista_duguje.Items(e.Index).SubItems(7).Text), pozicija)
            End If
            'For i = 0 To id_razvezani.Length - 1
            '    If id_razvezani(i) = CInt(lvLista_duguje.Items(e.Index).SubItems(8).Text) Then
            '        id_razvezani.SetValue(0, i)
            '        id_stavke.SetValue(0, i)
            '    End If
            'Next
        End If
        presaberi()
    End Sub

    Private Sub presaberi()
        txtSum_duguje.Text = Format(saldo_dug, "##,##0.00")
        txtSum_potrazuje.Text = Format(saldo_pot, "##,##0.00")
        txtSaldo.Text = Format(saldo_dug - saldo_pot, "##,##0.00")
    End Sub

    Private Sub btnPovezi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPovezi.Click
        povezi()
        btnPovezi.Enabled = False
    End Sub

    Private Sub povezi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim i As Integer = 0

        CN.Open()
        If CN.State = ConnectionState.Open Then
            For i = 0 To (dodati.Length / 2) - 1 ' lvLista_duguje.Items.Count - 1
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "fn_otvorene_stavke_add"
                    .Parameters.AddWithValue("@vezni_broj", veza_broj)
                    .Parameters.AddWithValue("@konto", RTrim(cmbKontoOD.Text))
                    .Parameters.AddWithValue("@analitika", RTrim(cmbAnalitikaOD.Text))  'labAnalitika.Text)
                    If dodati((i * 2) + 1) = 0 Then
                        .Parameters.AddWithValue("@id_dug", dodati(i * 2))
                        .Parameters.AddWithValue("@id_pot", "")
                    Else
                        .Parameters.AddWithValue("@id_dug", "")
                        .Parameters.AddWithValue("@id_pot", dodati(i * 2))
                    End If
                    .Parameters.AddWithValue("@saldo", CSng(txtSaldo.Text))
                    .ExecuteScalar()
                End With
                CM.Dispose()
                zakljuci(dodati(i * 2))
            Next
        End If
        CN.Close()
    End Sub

    Private Sub zakljuci(ByVal id As Integer)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "fn_nalog_stavka_zatvori"
                .Parameters.AddWithValue("@id_stavka", id)
                .Parameters.AddWithValue("@stavka_zatvorena", 1)
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If
        CN.Close()
    End Sub

    Public Function rb_os(ByVal _konto As String, ByVal _analitika As String) As Integer
        Dim CN As System.Data.SqlClient.SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        rb_os = 0
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.fn_otvorene_stavke where" & _
                            " dbo.fn_otvorene_stavke.konto = N'" & _konto & _
                            "' and dbo.fn_otvorene_stavke.analitika = N'" & _analitika & "'"
                DR = .ExecuteReader
            End With
            Try
                Do While DR.Read()
                    If Not IsDBNull(DR.Item("red_broj")) And Not RTrim(DR.Item("red_broj").ToString) = "" Then
                        If DR.Item("red_broj") > rb_os Then rb_os = DR.Item("red_broj")
                    End If
                Loop
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                MsgBox(ex.Message, MsgBoxStyle.OkOnly)
            End Try
        End If
        CM.Dispose()
        CN.Close()
        rb_os += 1
    End Function

    Private Sub btnZavrsi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZavrsi.Click
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = _mSpliter.Height - 5 ' 575

        Dim myControl As New cntOtvorene_stavke
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_otvorene_stavke '+ My.Resources.text_search
    End Sub

    Private Sub btnOdvezi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOdvezi.Click
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim i As Integer = 0

        For i = 0 To id_stavke.Length - 1
            CN.Open()
            If CN.State = ConnectionState.Open Then
                If id_stavke(i) <> 0 Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "fn_nalog_stavka_zatvori"
                        .Parameters.AddWithValue("@id_stavka", id_stavke(i))
                        .Parameters.AddWithValue("@stavka_zatvorena", 0)
                        .ExecuteScalar()
                    End With
                    CM.Dispose()
                End If

                If id_razvezani(i) <> 0 Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "fn_otvorene_stavke_delete"
                        .Parameters.AddWithValue("@id_os", id_razvezani(i))
                        .ExecuteScalar()
                    End With
                    CM.Dispose()
                End If
            End If
            CN.Close()

            id_razvezani.SetValue(0, i)
            id_stavke.SetValue(0, i)
        Next
        btnDodaj.Enabled = True
        preg_povezanih = True
        filter()
    End Sub

    Private Sub btnDodaj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDodaj.Click
        preg_povezanih = False

        If cmbKontoOD.Text <> "" Then
            upit_kontoOD = "stavka_konto = N'" & RTrim(cmbKontoOD.Text) & "'"
        Else
            upit_kontoOD = ""
        End If

        If cmbAnalitikaOD.Text <> "" Then
            upit_analitika = "stavka_analitika = N'" & RTrim(cmbAnalitikaOD.Text) & "'"
        Else
            upit_analitika = ""
        End If

        filter()
        btnDodaj.Enabled = False
        btnPovezi.Enabled = True

    End Sub

    Private Sub btnDesnoK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnLevoK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub datDatDO_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub datDatDO_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

End Class
