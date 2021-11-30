Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntOtvorene_stavke
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

    Shared sql_start As String = _
                "SELECT dbo.fn_nalog_head.nal_broj, dbo.fn_nalog_head.nal_datum,  " & _
                    "dbo.fn_nalog_stavka.stavka_rb, dbo.fn_nalog_stavka.stavka_opis_sifra, " & _
                    "dbo.fn_nalog_stavka.stavka_opis, dbo.fn_nalog_stavka.stavka_konto, " & _
                    "dbo.fn_nalog_stavka.stavka_analitika, dbo.fn_nalog_stavka.stavka_duguje, " & _
                    "dbo.fn_nalog_stavka.stavka_potrazuje, dbo.fn_nalog_head.nal_vrsta, " & _
                    "dbo.fn_nalog_stavka.stavka_brDok, dbo.fn_nalog_stavka.stavka_datDok, " & _
                    "dbo.fn_nalog_stavka.stavka_valuta, dbo.fn_nalog_stavka.id_stavka " & _
                "FROM dbo.fn_nalog_stavka INNER JOIN " & _
                    "dbo.fn_nalog_head ON dbo.fn_nalog_stavka.id_nalog = dbo.fn_nalog_head.id_nalog "

    Shared sql As String = ""
    Private _pocetak As Boolean = True
    Private aktivan_chk As Boolean
    Private kupci As Boolean
    Private _stampac As Boolean = False

    Private konto() As String
    Private analitika() As String
    Private duguje As Single = 0
    Private potrazuje As Single = 0
    Private saldo_dug As Single = 0
    Private saldo_pot As Single = 0
    Private saldo As Single = 0
    Private _pozicija_an As Integer = 0
    Private _pozicija_kon As Integer = 0
    Private veza_broj As Integer
    Private preg_povezanih As Boolean = False
    Private _ima_promet As Boolean = False


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntOtvorene_stavke_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        mPanel.Dock = DockStyle.Fill
        Spliter_tabele.Dock = DockStyle.Fill
        Spliter_tabele.SplitterDistance = (Spliter_tabele.Width / 2) - 2

        cmbAnalitikaOD.Enabled = False
        cmbAnalitikaOD.BackColor = Color.Lavender
        cmbAnalitikaDO.Enabled = False
        cmbAnalitikaDO.BackColor = Color.Lavender
        cmbKontoOD.Enabled = False
        cmbKontoOD.BackColor = Color.Lavender
        cmbKontoDO.Enabled = False
        cmbKontoDO.BackColor = Color.Lavender

        chkKupci.CheckState = CheckState.Checked
        chkDobavljaci.CheckState = CheckState.Unchecked

        pocetak()
    End Sub

    Private Sub pocetak()
        _lCount = labCount
        lPartnerOD.Text = ""
        lPartnerDO.Text = ""
        lKontoOD.Text = ""
        lKontoDO.Text = ""
        labAnalitika.Text = ""
        labKonto.Text = ""
        labKNaziv.Text = ""
        labPartner.Text = ""

        

        'datDatOD.Enabled = False
        'datDatDO.Enabled = False

        chkKonto.CheckState = CheckState.Checked
        chkAnalitika.CheckState = CheckState.Checked
        chkDatum.CheckState = CheckState.Checked

        popuni_partnere()
        popuni_konta()

        If kupci Then
            upit_analitikaOD = "stavka_analitika >= N'3000'"
            upit_analitikaDO = "stavka_analitika < N'4000'"
        Else
            upit_analitikaOD = "stavka_analitika >= N'4000'"
            upit_analitikaDO = "stavka_analitika < N'6000'"
        End If
        If kupci Then
            upit_kontoOD = "stavka_konto >= N'122111'"
            upit_kontoDO = "stavka_konto < N'122211'"
        Else
            upit_kontoOD = "stavka_konto >= N'252111'"
            upit_kontoDO = "stavka_konto < N'252211'"
        End If


        'upit_datumOD = "nal_datum >= '1/1/" & Today.Year.ToString & "'"
        'upit_datumDO = "nal_datum <= '" & Today.Month.ToString & "/" & _
        '                            Today.Day.ToString & "/" & _
        '                            Today.Year.ToString & "'"
        upit_datOD = CDate("1/1/" & Now.Year.ToString).Date
        upit_datDO = CDate("31/12/" & Now.Year.ToString).Date

        btnDesnoAn.Enabled = False
        btnLevoAn.Enabled = False
        btnDesnoK.Enabled = False
        btnLevoK.Enabled = False

        'red_broj = Nadji_rb("fn_otvorene_stavke", 1)
    End Sub

    Private Sub popuni_partnere()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbAnalitikaOD.Items.Clear()
        cmbAnalitikaDO.Items.Clear()

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
                cmbAnalitikaDO.Items.Add(DR.Item("partner_sifra"))
            Loop
            DR.Close()
        End If
        If cmbAnalitikaOD.Items.Count > 0 Then
            cmbAnalitikaOD.SelectedIndex = 0
        End If
        If cmbAnalitikaDO.Items.Count > 0 Then
            cmbAnalitikaDO.SelectedIndex = cmbAnalitikaDO.Items.Count - 1
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_konta()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbKontoOD.Items.Clear()
        cmbKontoDO.Items.Clear()

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
                cmbKontoDO.Items.Add(DR.Item("Konto_Sifra"))
            Loop
            DR.Close()
        End If
        If cmbKontoOD.Items.Count > 0 Then
            cmbKontoOD.SelectedIndex = 0
        End If
        If cmbKontoDO.Items.Count > 0 Then
            cmbKontoDO.SelectedIndex = cmbKontoDO.Items.Count - 1
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub filter()
        upit = ""
        sql = ""

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

        If upit <> "" Then
            If preg_povezanih Then
                sql = sql_start & " WHERE " & upit & " and stavka_zatvorena = 1"
            Else
                sql = sql_start & " WHERE " & upit & " and stavka_zatvorena = 0"
            End If
        Else
            sql = sql_start
        End If

        izdvoj_analitiku()
        izdvoj_konta()

        If Not _stampac Then
            Lista()
        End If

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
            .CommandText = "select dbo.app_partneri.* from dbo.app_partneri " & _
                           "where dbo.app_partneri.partner_sifra >= N'" & RTrim(cmbAnalitikaOD.Text) & _
                           "' and dbo.app_partneri.partner_sifra <= N'" & RTrim(cmbAnalitikaDO.Text) & "'"
            DR = .ExecuteReader
        End With

        _broj_stavki = 0

        Do While DR.Read
            If ima_promet(sql & " and stavka_analitika = N'" & RTrim(DR.Item("partner_sifra")) & "'") Then
                _broj_stavki += 1
            End If
        Loop

        DR.Close()
        CM.Dispose()

        If _broj_stavki > 0 Then
            analitika = New String() {}
            ReDim analitika(_broj_stavki - 1)

            DR = CM.ExecuteReader
            Dim i As Integer = 0
            Do While DR.Read
                If ima_promet(sql & " and stavka_analitika = N'" & RTrim(DR.Item("partner_sifra")) & "'") Then
                    analitika.SetValue(RTrim(DR.Item("partner_sifra")), i)
                    i += 1
                End If
            Loop
            DR.Close()
            CM.Dispose()
            _pozicija_an = 0
            If Not _stampac Then
                dugmeta_analitika()
                postavi_analitiku(_pozicija_an)
            End If
            _ima_promet = True
        Else
            _ima_promet = False
            labPartner.Text = "Analitika nema otvorenih stavki u zadatom periodu."
        End If
    End Sub

    Private Sub postavi_analitiku(ByVal pozicija)
        If analitika.Length > 0 Then
            selektuj_partnera(analitika(pozicija), Selekcija.po_sifri)
            labAnalitika.Text = analitika(pozicija)
            labPartner.Text = _partner_naziv
        End If
        'Lista()
    End Sub

    Private Sub izdvoj_konta()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        With CM
            .Connection = CN
            .CommandType = CommandType.Text
            .CommandText = "select dbo.app_konto.* from dbo.app_konto " & _
                           "where dbo.app_konto.Konto_Sifra >= N'" & RTrim(cmbKontoOD.Text) & _
                           "' and dbo.app_konto.Konto_Sifra <= N'" & RTrim(cmbKontoDO.Text) & "'"
            DR = .ExecuteReader
        End With
        CM.Dispose()

        _broj_stavki = 0
        Do While DR.Read
            If ima_promet(sql & " and stavka_konto = N'" & RTrim(DR.Item("Konto_Sifra")) & "'") Then
                _broj_stavki += 1
            End If
        Loop
        DR.Close()

        konto = New String() {}
        ReDim konto(_broj_stavki - 1)

        DR = CM.ExecuteReader
        Dim i As Integer = 0
        Do While DR.Read
            If ima_promet(sql & " and stavka_konto = N'" & RTrim(DR.Item("Konto_Sifra")) & "'") Then
                konto.SetValue(RTrim(DR.Item("Konto_Sifra")), i)
                i += 1
            End If
        Loop
        DR.Close()
        CM.Dispose()
        _pozicija_kon = 0
        If Not _stampac Then
            dugmeta_konta()
            postavi_konta(_pozicija_kon)
        End If

    End Sub

    Private Sub postavi_konta(ByVal pozicija)
        If konto.Length > 0 Then
            selektuj_konto(konto(pozicija), Selekcija.po_sifri)
            labKonto.Text = konto(pozicija)
            labKNaziv.Text = _konto_naziv
        End If

        'Lista()
    End Sub

    Private Sub Lista()
        Try
            If _ima_promet Then
                lvLista_duguje.CheckBoxes = True
                lvLista_potrazuje.CheckBoxes = True

                Dim CN As SqlConnection = New SqlConnection(CNNString)
                Dim CM As New SqlCommand
                Dim DR As SqlDataReader

                lvLista_duguje.Items.Clear()
                lvLista_potrazuje.Items.Clear()
                dgDuguje.Rows.Clear()

                CN.Open()
                CM = New SqlCommand()
                If CN.State = ConnectionState.Open Then
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.Text
                        .CommandText = sql & " and stavka_analitika = N'" & analitika(_pozicija_an) & "' and stavka_konto = N'" & konto(_pozicija_kon) & "'"
                        DR = .ExecuteReader
                    End With

                    saldo_dug = 0
                    saldo_pot = 0
                    saldo = 0

                    While DR.Read
                        Dim podatak As New ListViewItem(" ")
                        podatak.SubItems.Add(DR.Item("nal_datum"))
                        podatak.SubItems.Add(RTrim(DR.Item("nal_vrsta")))
                        podatak.SubItems.Add(RTrim(DR.Item("nal_broj")))
                        podatak.SubItems.Add(RTrim(DR.Item("stavka_datDok")))
                        podatak.SubItems.Add(RTrim(DR.Item("stavka_brDok")))

                        If DR.Item("stavka_duguje") <> 0 Then
                            podatak.SubItems.Add(Format(DR.Item("stavka_duguje"), "##,##0.00").ToString)
                            podatak.SubItems.Add(DR.Item("id_stavka"))
                            lvLista_duguje.Items.AddRange(New ListViewItem() {podatak})
                        Else
                            podatak.SubItems.Add(Format(DR.Item("stavka_potrazuje"), "##,##0.00").ToString)
                            podatak.SubItems.Add(DR.Item("id_stavka"))
                            lvLista_potrazuje.Items.AddRange(New ListViewItem() {podatak})
                        End If
                    End While
                    DR.Close()
                End If
                CM.Dispose()
                CN.Close()

                _lCount.Text = "od " & Format(upit_datOD, "D") & _
                             " do " & Format(upit_datDO, "D")

            End If
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
                cmbKontoDO.Enabled = True
                cmbKontoDO.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbKontoOD.Enabled = False
                cmbKontoOD.BackColor = Color.Lavender
                cmbKontoDO.Enabled = False
                cmbKontoDO.BackColor = Color.Lavender
                upit_kontoOD = ""
                upit_kontoDO = ""
                cmbKontoOD.Text = ""
                cmbKontoDO.Text = ""
        End Select
    End Sub

    Private Sub chkAnalitika_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAnalitika.CheckedChanged
        Select Case chkAnalitika.CheckState
            Case CheckState.Checked
                cmbAnalitikaOD.Enabled = True
                cmbAnalitikaOD.BackColor = Color.GhostWhite
                cmbAnalitikaDO.Enabled = True
                cmbAnalitikaDO.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbAnalitikaOD.Enabled = False
                cmbAnalitikaOD.BackColor = Color.Lavender
                cmbAnalitikaDO.Enabled = False
                cmbAnalitikaDO.BackColor = Color.Lavender
                If kupci Then
                    upit_analitikaOD = "stavka_analitika >= N'3000'"
                    upit_analitikaDO = ""
                Else
                    upit_analitikaOD = "stavka_analitika >= N'4000'"
                    upit_analitikaDO = ""
                End If
                cmbAnalitikaOD.Text = ""
                cmbAnalitikaDO.Text = ""
        End Select
    End Sub

    Private Sub chkDatum_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDatum.CheckedChanged
        Select Case chkDatum.CheckState
            Case CheckState.Checked
                datDatOD.Enabled = True
                datDatOD.BackColor = Color.GhostWhite
                datDatOD.Value = CDate("1/1/" & Now.Year.ToString).Date
                datDatDO.Enabled = True
                datDatDO.BackColor = Color.GhostWhite
                datDatDO.Value = CDate("31/12/" & Now.Year.ToString).Date
            Case CheckState.Unchecked
                datDatOD.Enabled = False
                datDatOD.BackColor = Color.Lavender
                datDatDO.Enabled = False
                datDatDO.BackColor = Color.Lavender
                datDatOD.Value = Today
                datDatDO.Value = Today
                upit_datumOD = "nal_datum >= '1/1/" & Now.Year.ToString & "'"
                upit_datumDO = "nal_datum <= '" & Today.Month.ToString & "/" & _
                                    Today.Day.ToString & "/" & _
                                    Today.Year.ToString & "'"
        End Select
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
                upit_kontoOD = "stavka_konto >= N'" & RTrim(cmbKontoOD.Text) & "'"
            Else
                upit_kontoOD = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbKontoOD_SelectedIndexChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbKontoOD.SelectedIndexChanged
        If cmbKontoOD.Text <> "" Then
            upit_kontoOD = "stavka_konto >= N'" & RTrim(cmbKontoOD.Text) & "'"
        Else
            upit_kontoOD = ""
        End If
        cmbKontoDO.SelectedItem = cmbKontoOD.Text
        konto_text(cmbKontoOD.Text, "OD")
    End Sub

    Private Sub cmbKontoDO_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbKontoDO.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbKontoDO.Text <> "" Then
                upit_kontoDO = "stavka_konto <= N'" & RTrim(cmbKontoDO.Text) & "'"
            Else
                upit_kontoDO = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbKontoDO_SelectedIndexChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbKontoDO.SelectedIndexChanged
        If cmbKontoDO.Text <> "" Then
            upit_kontoDO = "stavka_konto <= N'" & RTrim(cmbKontoDO.Text) & "'"
        Else
            upit_kontoDO = ""
        End If
        konto_text(cmbKontoDO.Text, "DO")
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
                    Case "DO"
                        lKontoDO.Text = DR.Item("Naziv")
                End Select
            Loop
            DR.Close()
        End If
    End Sub

    Private Sub cmbPartner_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbAnalitikaOD.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbAnalitikaOD.Text <> "" Then
                upit_analitikaOD = "stavka_analitika >= N'" & RTrim(cmbAnalitikaOD.Text) & "'"
            Else
                upit_analitikaOD = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbPartner_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAnalitikaOD.SelectedIndexChanged
        If cmbAnalitikaOD.Text <> "" Then
            upit_analitikaOD = "stavka_analitika >= N'" & RTrim(cmbAnalitikaOD.Text) & "'"
        Else
            upit_analitikaOD = ""
        End If
        cmbAnalitikaDO.SelectedItem = cmbAnalitikaOD.Text
        partner_text(cmbAnalitikaOD.Text, "OD")
    End Sub

    Private Sub cmbPartnerDO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbAnalitikaDO.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbAnalitikaDO.Text <> "" Then
                upit_analitikaDO = "stavka_analitika <= N'" & RTrim(cmbAnalitikaDO.Text) & "'"
            Else
                upit_analitikaDO = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbPartnerDO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAnalitikaDO.SelectedIndexChanged
        If cmbAnalitikaDO.Text <> "" Then
            upit_analitikaDO = "stavka_analitika <= N'" & RTrim(cmbAnalitikaDO.Text) & "'"
        Else
            upit_analitikaDO = ""
        End If
        partner_text(cmbAnalitikaDO.Text, "DO")
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
                    Case "DO"
                        lPartnerDO.Text = DR.Item("partner_naziv")
                End Select
            Loop
            DR.Close()
        End If
    End Sub

    Private Sub datDatOD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datDatOD.KeyPress
        If e.KeyChar = Chr(13) Then
            upit_datumOD = "nal_datum >= '" & _
                                 datDatOD.Value.Month.ToString & "/" & _
                                 datDatOD.Value.Day.ToString & "/" & _
                                 datDatOD.Value.Year.ToString & "'"
            upit_datOD = datDatOD.Value
            filter()
        End If
    End Sub
    Private Sub datDatOD_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles datDatOD.ValueChanged
        upit_datumOD = "nal_datum >= '" & _
                       datDatOD.Value.Month.ToString & "/" & _
                       datDatOD.Value.Day.ToString & "/" & _
                       datDatOD.Value.Year.ToString & "'" '& _
        upit_datOD = datDatOD.Value
        'filter()
    End Sub

    Private Sub datDatDO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datDatDO.KeyPress
        If e.KeyChar = Chr(13) Then
            upit_datumDO = "nal_datum <= '" & _
                                 datDatDO.Value.Month.ToString & "/" & _
                                 datDatDO.Value.Day.ToString & "/" & _
                                 datDatDO.Value.Year.ToString & "'"
            upit_datDO = datDatDO.Value
            filter()
        End If
    End Sub
    Private Sub datDatDO_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles datDatDO.ValueChanged
        upit_datumDO = "nal_datum <= '" & _
                                  datDatDO.Value.Month.ToString & "/" & _
                                  datDatDO.Value.Day.ToString & "/" & _
                                  datDatDO.Value.Year.ToString & "'"
        upit_datDO = datDatDO.Value
    End Sub

    Private Sub btnPronadji_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPronadji.Click
        filter()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        '_stampac = True
        preg_povezanih = False
        filter()
        veza_broj = rb_os(labKonto.Text, labAnalitika.Text)
    End Sub

    Private Sub btnDesno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesnoAn.Click
        _pozicija_an = _pozicija_an + 1
        postavi_analitiku(_pozicija_an)
        dugmeta_analitika()
        Lista()
        veza_broj = rb_os(labKonto.Text, labAnalitika.Text)
    End Sub

    Private Sub btnLevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLevoAn.Click
        _pozicija_an = _pozicija_an - 1
        postavi_analitiku(_pozicija_an)
        dugmeta_analitika()
        Lista()
        veza_broj = rb_os(labKonto.Text, labAnalitika.Text)
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

    Private Sub btnLevoK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLevoK.Click
        _pozicija_kon = _pozicija_kon - 1
        postavi_konta(_pozicija_kon)
        dugmeta_konta()
        Lista()
        veza_broj = rb_os(labKonto.Text, labAnalitika.Text)
    End Sub

    Private Sub btnDesnoK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesnoK.Click
        _pozicija_kon = _pozicija_kon + 1
        postavi_konta(_pozicija_kon)
        dugmeta_konta()
        Lista()
        veza_broj = rb_os(labKonto.Text, labAnalitika.Text)
    End Sub

    Private Sub dugmeta_konta()
        If _pozicija_kon > 0 Then
            btnLevoK.Enabled = True
        Else
            btnLevoK.Enabled = False
        End If
        If _pozicija_kon = konto.Length - 1 Then
            btnDesnoK.Enabled = False
        Else
            btnDesnoK.Enabled = True
        End If
    End Sub

    Private Sub lvLista_potrazuje_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lvLista_potrazuje.ItemCheck
        If e.NewValue = CheckState.Checked Then
            Dim a As Integer = e.Index
            saldo_pot += CSng(lvLista_potrazuje.Items(e.Index).SubItems(6).Text)
            lvLista_potrazuje.Items(e.Index).Text = veza_broj
        Else
            saldo_pot -= CSng(lvLista_potrazuje.Items(e.Index).SubItems(6).Text)
            lvLista_potrazuje.Items(e.Index).Text = ""
        End If
        presaberi()
    End Sub

    Private Sub lvLista_duguje_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lvLista_duguje.ItemCheck
        If e.NewValue = CheckState.Checked Then
            saldo_dug += lvLista_duguje.Items(e.Index).SubItems(6).Text
            lvLista_duguje.Items(e.Index).Text = veza_broj
        Else
            saldo_dug -= lvLista_duguje.Items(e.Index).SubItems(6).Text
            lvLista_duguje.Items(e.Index).Text = ""
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
    End Sub

    Private Sub povezi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim i As Integer = 0

        CN.Open()
        If CN.State = ConnectionState.Open Then
            For i = 0 To lvLista_duguje.Items.Count - 1
                If lvLista_duguje.Items(i).Checked = True Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "fn_otvorene_stavke_add"
                        .Parameters.AddWithValue("@vezni_broj", veza_broj)
                        .Parameters.AddWithValue("@konto", labKonto.Text)
                        .Parameters.AddWithValue("@analitika", labAnalitika.Text)
                        .Parameters.AddWithValue("@id_dug", lvLista_duguje.Items(i).SubItems(7).Text)
                        .Parameters.AddWithValue("@id_pot", "")
                        .Parameters.AddWithValue("@saldo", CSng(txtSaldo.Text))
                        .ExecuteScalar()
                    End With
                    CM.Dispose()
                    zakljuci(CInt(lvLista_duguje.Items(i).SubItems(7).Text))
                End If
            Next
            For i = 0 To lvLista_potrazuje.Items.Count - 1
                If lvLista_potrazuje.Items(i).Checked = True Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "fn_otvorene_stavke_add"
                        .Parameters.AddWithValue("@vezni_broj", veza_broj)
                        .Parameters.AddWithValue("@konto", labKonto.Text)
                        .Parameters.AddWithValue("@analitika", labAnalitika.Text)
                        .Parameters.AddWithValue("@id_dug", "")
                        .Parameters.AddWithValue("@id_pot", lvLista_potrazuje.Items(i).SubItems(7).Text)
                        .Parameters.AddWithValue("@saldo", CSng(txtSaldo.Text))
                        .ExecuteScalar()
                    End With
                    CM.Dispose()
                    zakljuci(CInt(lvLista_potrazuje.Items(i).SubItems(7).Text))
                End If
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
                    If Not IsDBNull(DR.Item("vezni_broj")) And Not RTrim(DR.Item("vezni_broj").ToString) = "" Then
                        If DR.Item("vezni_broj") > rb_os Then rb_os = DR.Item("vezni_broj")
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

    Private Sub btnPreg_pov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreg_pov.Click
        Dim i As Integer = 0
        Dim j As Integer = 0

        preg_povezanih = True
        _stampac = True
        filter()

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prn_otvorene_stavke_delete"
                .ExecuteScalar()
            End With
        End If

        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.fn_otvorene_stavke where konto >= N'" & RTrim(cmbKontoOD.Text) & _
                                "' and konto <= N'" & RTrim(cmbKontoDO.Text) & "' and analitika >= N'" & RTrim(cmbAnalitikaOD.Text) & _
                                "' and analitika <= N'" & RTrim(cmbAnalitikaDO.Text) & "'"
                DR = .ExecuteReader
            End With

            While DR.Read
                If DR.Item("id_dug") <> 0 Then
                    selektuj_nalog_stavka(DR.Item("id_dug"), Selekcija.po_id)
                ElseIf DR.Item("id_pot") <> 0 Then
                    selektuj_nalog_stavka(DR.Item("id_pot"), Selekcija.po_id)
                End If
                selektuj_nalog(_id_nalog, Selekcija.po_id)
                selektuj_konto(RTrim(DR.Item("konto")), Selekcija.po_sifri)
                selektuj_partnera(RTrim(DR.Item("analitika")), Selekcija.po_sifri)

                unesi(upit_datOD, upit_datDO, _nal_datum, RTrim(_nal_vrsta), _
                      _nal_broj, _konto_Sifra, _konto_naziv, RTrim(_partner_sifra), _partner_naziv, _
                      _stavka_rb, RTrim(_stavka_opis), RTrim(_stavka_datDok), _
                      _stavka_brDok, DR.Item("red_broj"), _stavka_duguje, _stavka_potrazuje, _
                      _stavka_duguje - _stavka_potrazuje)

            End While
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()

        If _stampac Then
            _raport = Imena.tabele.fn_otvorene_stavke_zat.ToString
            Dim mForm As New frmPrint
            mForm.Show()
        End If
        _stampac = False

    End Sub

    Private Sub btnPreg_nepov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreg_nepov.Click
        Dim i As Integer = 0
        Dim j As Integer = 0

        preg_povezanih = False
        _stampac = True
        filter()

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prn_otvorene_stavke_delete"
                .ExecuteScalar()
            End With
        End If

        For i = 0 To konto.Length - 1
            For j = 0 To analitika.Length - 1
                CM = New SqlCommand()
                If CN.State = ConnectionState.Open Then
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.Text
                        .CommandText = sql & " and stavka_analitika = N'" & analitika(j) & "' and stavka_konto = N'" & konto(i) & "'"
                        DR = .ExecuteReader
                    End With
                    selektuj_konto(konto(i), Selekcija.po_sifri)
                    selektuj_partnera(analitika(j), Selekcija.po_sifri)
                    While DR.Read
                        unesi(upit_datOD, upit_datDO, DR.Item("nal_datum"), RTrim(DR.Item("nal_vrsta")), _
                              RTrim(DR.Item("nal_broj")), konto(i), _konto_naziv, analitika(j), _partner_naziv, _
                              RTrim(DR.Item("stavka_rb")), DR.Item("stavka_opis"), RTrim(DR.Item("stavka_datDok")), _
                              RTrim(DR.Item("stavka_brDok")), veza_broj, DR.Item("stavka_duguje"), DR.Item("stavka_potrazuje"), _
                              DR.Item("stavka_duguje") - DR.Item("stavka_potrazuje"))

                    End While
                    DR.Close()
                End If
                CM.Dispose()
            Next j
        Next i
        CN.Close()

        If _stampac Then
            _raport = Imena.tabele.fn_otvorene_stavke_otv.ToString
            Dim mForm As New frmPrint
            mForm.Show()
        End If
        _stampac = False

    End Sub

    Private Sub btnIspravka_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIspravka.Click
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = _mSpliter.Height - 5 ' 575

        Dim myControl As New cntOtvorene_stavke_ispravke
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_otvorene_stavke '+ My.Resources.text_search
    End Sub

    Private Sub unesi(ByVal datum_od, ByVal datum_do, ByVal nalog_datum, ByVal nalog_vrsta, _
            ByVal nalog_broj, ByVal stavka_konto, ByVal stavka_konto_naziv, ByVal stavka_analitika, _
            ByVal stavka_anait_naziv, ByVal stavka_broj, ByVal stavka_opis, ByVal stavka_dat_dok, _
            ByVal stavka_broj_dok, ByVal stavka_vezni_broj, ByVal stavka_duguje, _
            ByVal stavka_potrazuje, ByVal stavka_saldo)

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prn_otvorene_stavke_add"
                .Parameters.AddWithValue("@datum_od", datum_od)
                .Parameters.AddWithValue("@datum_do", datum_do)
                .Parameters.AddWithValue("@nalog_datum", nalog_datum)
                .Parameters.AddWithValue("@nalog_vrsta", nalog_vrsta)
                .Parameters.AddWithValue("@nalog_broj", nalog_broj)
                .Parameters.AddWithValue("@stavka_konto", stavka_konto)
                .Parameters.AddWithValue("@stavka_konto_naziv", stavka_konto_naziv)
                .Parameters.AddWithValue("@stavka_analitika", stavka_analitika)
                .Parameters.AddWithValue("@stavka_anait_naziv", stavka_anait_naziv)
                .Parameters.AddWithValue("@stavka_broj", stavka_broj)
                .Parameters.AddWithValue("@stavka_opis", stavka_opis)
                .Parameters.AddWithValue("@stavka_dat_dok", stavka_dat_dok)
                .Parameters.AddWithValue("@stavka_broj_dok", stavka_broj_dok)
                .Parameters.AddWithValue("@stavka_vezni_broj", stavka_vezni_broj)
                .Parameters.AddWithValue("@stavka_duguje", stavka_duguje)
                .Parameters.AddWithValue("@stavka_potrazuje", stavka_potrazuje)
                .Parameters.AddWithValue("@stavka_saldo", stavka_saldo)
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If
        CN.Close()
    End Sub

    Private Sub btnIzvod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzvod.Click
        Izvod(Imena.tabele.fn_otvorene_stavke_izvod.ToString)
        _stampac = False
    End Sub

    Private Sub btnSaglasnost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaglasnost.Click
        Izvod(Imena.tabele.fn_otvorene_stavke_saglasnost.ToString)
        _stampac = False
    End Sub

    Private Sub Izvod(ByVal _ime_raporta)
        Dim i As Integer = 0
        Dim j As Integer = 0

        _stampac = True
        upit = ""
        sql = ""

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

        If upit <> "" Then
            sql = sql_start & " WHERE " & upit '& " and stavka_zatvorena = 0"
        Else
            sql = sql_start '& " and stavka_zatvorena = 0"
        End If

        izdvoj_analitiku()
        izdvoj_konta()

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prn_otvorene_stavke_delete"
                .ExecuteScalar()
            End With
        End If

        Dim ima_upis As Boolean = False
        If konto.Length > 0 Then
            For i = 0 To konto.Length - 1
                If analitika.Length > 0 Then
                    For j = 0 To analitika.Length - 1
                        If CN.State = ConnectionState.Open Then
                            CM = New SqlCommand()
                            With CM
                                .Connection = CN
                                .CommandType = CommandType.Text
                                .CommandText = sql & " and stavka_analitika = N'" & analitika(j) & "' and stavka_konto = N'" & konto(i) & "' and stavka_zatvorena = 1"
                                DR = .ExecuteReader
                            End With
                            selektuj_konto(konto(i), Selekcija.po_sifri)
                            selektuj_partnera(analitika(j), Selekcija.po_sifri)

                            Dim duguje As Single = 0
                            Dim potrazuje As Single = 0
                            Dim saldo As Single = 0

                            While DR.Read
                                duguje += DR.Item("stavka_duguje")
                                potrazuje += DR.Item("stavka_potrazuje")
                            End While
                            saldo = duguje - potrazuje
                            If duguje <> 0 And potrazuje <> 0 Then
                                unesi(upit_datOD, upit_datDO, upit_datDO, "", _
                                      "", konto(i), _konto_naziv, analitika(j), _partner_naziv, _
                                      "", "kumulativ", "", _
                                      "", "", duguje, potrazuje, _
                                      saldo)
                                ima_upis = True
                            End If
                            DR.Close()
                            CM.Dispose()

                            CM = New SqlCommand()
                            With CM
                                .Connection = CN
                                .CommandType = CommandType.Text
                                .CommandText = sql & " and stavka_analitika = N'" & analitika(j) & "' and stavka_konto = N'" & konto(i) & "' and stavka_zatvorena = 0"
                                DR = .ExecuteReader
                            End With
                            While DR.Read
                                unesi(upit_datOD, upit_datDO, DR.Item("nal_datum"), RTrim(DR.Item("nal_vrsta")), _
                                      RTrim(DR.Item("nal_broj")), konto(i), _konto_naziv, analitika(j), _partner_naziv, _
                                      RTrim(DR.Item("stavka_rb")), DR.Item("stavka_opis"), RTrim(DR.Item("stavka_datDok")), _
                                      RTrim(DR.Item("stavka_brDok")), veza_broj, DR.Item("stavka_duguje"), DR.Item("stavka_potrazuje"), _
                                      DR.Item("stavka_duguje") - DR.Item("stavka_potrazuje"))
                            End While
                            DR.Close()
                            CM.Dispose()
                        End If

                    Next j
                End If
            Next i
            If ima_upis Then
                If _stampac Then
                    _raport = _ime_raporta
                    Dim mForm As New frmPrint
                    mForm.Show()
                End If
            End If
        End If
        CN.Close()
    End Sub
End Class
