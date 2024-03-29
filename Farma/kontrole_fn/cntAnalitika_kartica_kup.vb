Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntAnalitika_kartica_kup
    Private upit As String = ""
    Private upit_partnerOD As String = ""
    Private upit_partnerDO As String = ""
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
                    "dbo.fn_nalog_stavka.stavka_valuta " & _
                "FROM dbo.fn_nalog_stavka INNER JOIN " & _
                    "dbo.fn_nalog_head ON dbo.fn_nalog_stavka.id_nalog = dbo.fn_nalog_head.id_nalog "

    Shared sql As String = ""
    Private _pocetak As Boolean = True
    Private aktivan_chk As Boolean
    Private ima_promena As Boolean
    Private _stampac As Boolean = False

    Private konto As String = ""
    Private analitika As String = ""
    Private partneri As String = ""
    Private duguje As Single = 0
    Private potrazuje As Single = 0
    Private saldo As Single = 0
    Private poc_stanje As Single = 0

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntAnalitika_kartica_kup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        _lCount = labCount
        lPartnerOD.Text = ""
        lPartnerDO.Text = ""
        lKontoOD.Text = ""
        lKontoDO.Text = ""

        popuni_partnere()
        popuni_konta()

        cmbPartnerOD.Enabled = False
        cmbPartnerOD.BackColor = Color.Lavender
        cmbPartnerDO.Enabled = False
        cmbPartnerDO.BackColor = Color.Lavender
        cmbKontoOD.Enabled = False
        cmbKontoOD.BackColor = Color.Lavender
        cmbKontoDO.Enabled = False
        cmbKontoDO.BackColor = Color.Lavender

        datDatOD.Enabled = False
        datDatDO.Enabled = False

        chkDatum.CheckState = CheckState.Checked
        chkPartner.CheckState = CheckState.Checked
        chkKonto.CheckState = CheckState.Checked

        upit_partnerOD = "stavka_analitika >= N'3000'"
        upit_partnerDO = "stavka_analitika < N'4000'"

        upit_kontoOD = "stavka_konto >= N'122110'"
        upit_kontoDO = "stavka_konto < N'122120'"

        upit_datumOD = "nal_datum >= '1/1/" & Today.Year.ToString & "'"
        upit_datumDO = "nal_datum <= '" & Today.Month.ToString & "/" & _
                                    Today.Day.ToString & "/" & _
                                    Today.Year.ToString & "'"
        upit_datOD = CDate("1/1/" & Now.Year.ToString).Date
        upit_datDO = Today

        mPanel.Dock = DockStyle.Fill
        '_lista.Visible = True
        '_lista.Items.Clear()
        _lista.Columns.Clear()
    End Sub

    Private Sub popuni_partnere()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbPartnerOD.Items.Clear()
        'cmbPartnerOD.Items.Add("")

        cmbPartnerDO.Items.Clear()
        'cmbPartnerDO.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_partneri.* from dbo.app_partneri where partner_sifra >= '3000' and partner_sifra < '4000'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbPartnerOD.Items.Add(DR.Item("partner_sifra"))
                cmbPartnerDO.Items.Add(DR.Item("partner_sifra"))
            Loop
            DR.Close()
        End If
        If cmbPartnerOD.Items.Count > 0 Then
            cmbPartnerOD.SelectedIndex = 0
        End If
        If cmbPartnerDO.Items.Count > 0 Then
            cmbPartnerDO.SelectedIndex = cmbPartnerDO.Items.Count - 1
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_konta()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbKontoOD.Items.Clear()
        'cmbKontoOD.Items.Add("")

        cmbKontoDO.Items.Clear()
        'cmbKontoDO.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_konto.* from dbo.app_konto where Konto_Sifra >= '122110' and Konto_Sifra < '122120' order by Konto_Sifra"
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
            sql = sql_start & " WHERE " & upit
        Else
            sql = sql_start
        End If

        'If _stampac Then
        '    Lista_prn()
        '    _stampac = False
        'Else
        Lista()
        'End If

    End Sub

    Private Sub Lista()
        Try
            _lista.Columns.Clear()
            _lista.Columns.Add("Datum", 85, HorizontalAlignment.Left)
            _lista.Columns.Add("Vrsta", 70, HorizontalAlignment.Left)
            _lista.Columns.Add("Broj", 70, HorizontalAlignment.Left)
            _lista.Columns.Add("Konto", 70, HorizontalAlignment.Left)
            _lista.Columns.Add("Analitika", 60, HorizontalAlignment.Left)
            _lista.Columns.Add("Duguje", 100, HorizontalAlignment.Right)
            _lista.Columns.Add("Potražuje", 100, HorizontalAlignment.Right)
            _lista.Columns.Add("Saldo", 100, HorizontalAlignment.Right)
            _lista.Columns.Add("Poč. Stanje", 100, HorizontalAlignment.Right)

            Dim CN As SqlConnection = New SqlConnection(CNNString)
            Dim CM As New SqlCommand
            Dim DR As SqlDataReader

            _lista.Visible = True
            _lista.Items.Clear()

            upit = ""
            If chkKonto.CheckState = CheckState.Checked Then
                If upit_kontoOD <> "" And upit <> "" Then
                    upit = upit & " and " & "Konto_Sifra >= N'" & cmbKontoOD.Text & "'"
                Else
                    If upit_kontoOD <> "" Then upit = "Konto_Sifra >= N'" & RTrim(cmbKontoOD.Text) & "'"
                End If

                If upit_kontoDO <> "" And upit <> "" Then
                    upit = upit & " and " & "Konto_Sifra <= N'" & RTrim(cmbKontoDO.Text) & "'"
                Else
                    If upit_kontoDO <> "" Then upit = "Konto_Sifra <= N'" & RTrim(cmbKontoDO.Text) & "'"
                End If
            Else
                If upit_kontoOD <> "" And upit <> "" Then
                    upit = upit & " and " & "Konto_Sifra >= N'122110'"
                Else
                    upit = "Konto_Sifra >= N'122110'"
                End If

                If upit_kontoDO <> "" And upit <> "" Then
                    upit = upit & " and " & "Konto_Sifra < N'122120'"
                Else
                    upit = "Konto_Sifra < N'122120'"
                End If
            End If

            CN.Open()
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prn_Finansijsko_delete"
                .ExecuteScalar()
            End With
            CM.Dispose()

            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = "select * from app_konto" & " WHERE " & upit
                    DR = .ExecuteReader
                End With

                While DR.Read
                    If _stampac Then
                        pAnalitika_prn(DR.Item("Konto_Sifra"))
                    Else
                        pAnalitika(DR.Item("Konto_Sifra"))
                    End If
                End While
                DR.Close()
            End If
            CM.Dispose()
            CN.Close()

            _lCount.Text = "od " & Format(upit_datOD, "D") & _
                           " do " & Format(upit_datDO, "D")

            If _stampac Then
                _raport = Imena.tabele.fn_analitika_kartica.ToString
                Dim mForm As New frmPrint
                mForm.Show()
            End If
            _stampac = False

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

    Private Sub donos(ByVal _konto, ByVal _partner)
        duguje = 0
        potrazuje = 0
        saldo = 0
        poc_stanje = 0

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                Dim dat As Date = Format(DateAdd(DateInterval.Day, -1, upit_datOD).Date, "u")
                .CommandText = sql_start & "WHERE stavka_konto = N'" & _konto & "' AND stavka_analitika = N'" & _partner & "'" & _
                            " AND nal_datum >= '1/1/" & Now.Year.ToString & "'" & _
                            " AND nal_datum <= '" & dat.Month.ToString & "/" & _
                                                    dat.Day.ToString & "/" & _
                                                    dat.Year.ToString & "'"

                DR = .ExecuteReader
            End With
            Do While DR.Read
                duguje += DR.Item("stavka_duguje")
                potrazuje += DR.Item("stavka_potrazuje")
                saldo += DR.Item("stavka_duguje") - DR.Item("stavka_potrazuje")
            Loop
            DR.Close()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql_start & "WHERE stavka_konto = N'" & _konto & "' AND stavka_analitika = N'" & _partner & "'" & _
                            "AND nal_datum = '1/1/" & Today.Year.ToString & "'" '& _
                '"AND stavka_analitika >= N'4000'"
                DR = .ExecuteReader
            End With
            poc_stanje = 0
            While DR.Read
                poc_stanje += DR.Item("stavka_duguje") - DR.Item("stavka_potrazuje")
            End While
            DR.Close()
            CM.Dispose()
        End If

    End Sub

    Private Sub pAnalitika(ByVal _konto)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim i As Integer = 0
        Dim _od As Integer = 1
        Dim _do As Integer = 3999

        If chkPartner.CheckState = CheckState.Checked Then
            _od = CInt(cmbPartnerOD.Text)
            _do = CInt(cmbPartnerDO.Text)
        End If

        CN.Open()
        If CN.State = ConnectionState.Open Then
            For i = _od To _do
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = sql & " and dbo.fn_nalog_stavka.stavka_konto='" & _konto & "' and stavka_analitika = '" & i & "'"
                    DR = .ExecuteReader
                End With

                Dim _donos As Boolean = True
                If DR.HasRows Then
                    While DR.Read
                        Dim donos_duguje As Single = 0
                        Dim donos_potrazuje As Single = 0
                        Dim donos_saldo As Single = 0

                        If _donos Then
                            donos(_konto, i)
                            _donos = False

                            Dim podatak As New ListViewItem("DONOS")
                            If chkDatum.CheckState = CheckState.Checked Then
                                podatak.SubItems.Add(CDate("1/1/" & Today.Year.ToString).Date)
                                podatak.SubItems.Add(DateAdd(DateInterval.Day, -1, upit_datOD.Date))
                            Else
                                podatak.SubItems.Add("-")
                                podatak.SubItems.Add("-")
                            End If
                            podatak.SubItems.Add(" ")
                            podatak.SubItems.Add(" ")
                            podatak.SubItems.Add(Format(duguje, "##,##0.00").ToString)
                            podatak.SubItems.Add(Format(potrazuje, "##,##0.00").ToString)
                            podatak.SubItems.Add(Format(duguje - potrazuje, "##,##0.00").ToString)
                            podatak.SubItems.Add(Format(poc_stanje, "##,##0.00").ToString)

                            podatak.ForeColor = Color.RoyalBlue
                            _lista.Items.AddRange(New ListViewItem() {podatak})
                        End If

                        'lista
                        Dim podatak1 As New ListViewItem(CStr(DR.Item("nal_datum")))
                        podatak1.SubItems.Add(DR.Item("nal_vrsta"))
                        podatak1.SubItems.Add(DR.Item("nal_broj"))
                        podatak1.SubItems.Add(DR.Item("stavka_konto"))
                        podatak1.SubItems.Add(DR.Item("stavka_analitika"))
                        podatak1.SubItems.Add(Format(DR.Item("stavka_duguje"), "##,##0.00").ToString)
                        podatak1.SubItems.Add(Format(DR.Item("stavka_potrazuje"), "##,##0.00").ToString)
                        podatak1.SubItems.Add(Format(DR.Item("stavka_duguje") - DR.Item("stavka_potrazuje"), "##,##0.00").ToString)
                        podatak1.SubItems.Add(Format(poc_stanje, "##,##0.00").ToString)

                        _lista.Items.AddRange(New ListViewItem() {podatak1})
                    End While

                    Dim podatak3 As New ListViewItem("")
                    podatak3.SubItems.Add("")
                    podatak3.SubItems.Add("")
                    podatak3.SubItems.Add("")
                    podatak3.SubItems.Add("")
                    podatak3.SubItems.Add("")
                    podatak3.SubItems.Add("")
                    podatak3.SubItems.Add("")
                    podatak3.SubItems.Add("")

                    _lista.Items.AddRange(New ListViewItem() {podatak3})
                End If
                DR.Close()
                CM.Dispose()
            Next
        End If
        CN.Close()
    End Sub

    Private Sub pAnalitika_prn(ByVal _konto)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim i As Integer = 0
        Dim _od As Integer = 3000
        Dim _do As Integer = 3999

        If chkPartner.CheckState = CheckState.Checked Then
            _od = CInt(cmbPartnerOD.Text)
            _do = CInt(cmbPartnerDO.Text)
        End If

        CN.Open()
        If CN.State = ConnectionState.Open Then
            For i = _od To _do
                Dim _ima_promet As Boolean = False
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = "SELECT dbo.fn_nalog_head.nal_broj, dbo.fn_nalog_head.nal_datum,  " & _
                                        "dbo.fn_nalog_stavka.stavka_rb, dbo.fn_nalog_stavka.stavka_opis_sifra, " & _
                                        "dbo.fn_nalog_stavka.stavka_opis, dbo.fn_nalog_stavka.stavka_konto, " & _
                                        "dbo.fn_nalog_stavka.stavka_analitika, dbo.fn_nalog_stavka.stavka_duguje, " & _
                                        "dbo.fn_nalog_stavka.stavka_potrazuje, dbo.fn_nalog_head.nal_vrsta, " & _
                                        "dbo.fn_nalog_stavka.stavka_brDok, dbo.fn_nalog_stavka.stavka_datDok, " & _
                                        "dbo.fn_nalog_stavka.stavka_valuta " & _
                                    "FROM dbo.fn_nalog_stavka INNER JOIN " & _
                                        "dbo.fn_nalog_head ON dbo.fn_nalog_stavka.id_nalog = dbo.fn_nalog_head.id_nalog " & _
                                    "WHERE nal_datum >='01/01/" & Today.Year.ToString & "'" & _
                                    " and dbo.fn_nalog_stavka.stavka_konto='" & RTrim(_konto) & "' and stavka_analitika = '" & i & "'"
                    DR = .ExecuteReader
                End With
                If DR.HasRows Then _ima_promet = True
                DR.Close()

                If _ima_promet Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.Text
                        .CommandText = sql & " and dbo.fn_nalog_stavka.stavka_konto='" & _konto & "' and stavka_analitika = '" & i & "'"
                        DR = .ExecuteReader
                    End With

                    Dim _donos As Boolean = True
                    Dim donos_duguje As Single = 0
                    Dim donos_potrazuje As Single = 0
                    Dim donos_saldo As Single = 0

                    selektuj_partnera(i, Selekcija.po_sifri)

                    If _donos Then
                        donos(_konto, i)
                        _donos = False

                        Dim _opis As String = ""
                        If chkDatum.CheckState = CheckState.Checked Then
                            _opis = "DONOS od " & CDate("1/1/" & Today.Year.ToString).Date & " do " & _
                                    DateAdd(DateInterval.Day, -1, upit_datOD.Date)
                        Else
                            _opis = "DONOS od - do -"
                        End If

                        upisi_prn_finansijsko(upit_datOD, upit_datDO, "", "", _
                                CDate("1/1/" & Today.Year.ToString).Date, _
                                0, 0, 0, False, False, "", "", _opis, "", "", _
                                _konto, i, _partner_naziv, duguje, potrazuje, _
                                saldo, 0, 0, 0, 0, 0, Today, 0, 0, 0, "", "")
                    End If

                    If DR.HasRows Then
                        While DR.Read
                            upisi_prn_finansijsko(upit_datOD, upit_datDO, DR.Item("nal_vrsta"), DR.Item("nal_broj"), _
                                DR.Item("nal_datum"), 0, 0, 0, False, False, _
                                DR.Item("stavka_rb"), "", DR.Item("stavka_opis"), _
                                "", "", DR.Item("stavka_konto"), DR.Item("stavka_analitika"), _partner_naziv, _
                                DR.Item("stavka_duguje"), DR.Item("stavka_potrazuje"), _
                                DR.Item("stavka_duguje") - DR.Item("stavka_potrazuje"), 0, 0, poc_stanje, _
                                0, 0, Today, 0, 0, 0, DR.Item("stavka_brDok"), DR.Item("stavka_datDok"))
                        End While
                    End If
                    DR.Close()
                    CM.Dispose()
                End If
            Next
        End If
        CN.Close()

        '_raport = Imena.tabele.fn_analitika_kartica.ToString
        'Dim mForm As New frmPrint
        'mForm.Show()

    End Sub

    Private Sub chkKonto_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkKonto.CheckedChanged
        Select Case chkKonto.CheckState
            Case CheckState.Checked
                cmbKontoOD.Enabled = True
                cmbKontoOD.BackColor = Color.GhostWhite
                cmbKontoDO.Enabled = True
                cmbKontoDO.BackColor = Color.GhostWhite
                popuni_konta()
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

    Private Sub chkPartner_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPartner.CheckedChanged
        Select Case chkPartner.CheckState
            Case CheckState.Checked
                cmbPartnerOD.Enabled = True
                cmbPartnerOD.BackColor = Color.GhostWhite
                cmbPartnerDO.Enabled = True
                cmbPartnerDO.BackColor = Color.GhostWhite
                popuni_partnere()
            Case CheckState.Unchecked
                cmbPartnerOD.Enabled = False
                cmbPartnerOD.BackColor = Color.Lavender
                cmbPartnerDO.Enabled = False
                cmbPartnerDO.BackColor = Color.Lavender
                upit_partnerOD = "stavka_analitika >= N'3000'"
                upit_partnerDO = ""
                cmbPartnerOD.Text = ""
                cmbPartnerDO.Text = ""
        End Select
        proveri_formu()
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
                upit_datOD = CDate("1/1/" & Now.Year.ToString).Date
                upit_datDO = Today
        End Select
        proveri_formu()
    End Sub

    Private Sub cmbKontoOD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbKontoOD.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbKontoOD.Text <> "" Then
                upit_kontoOD = "stavka_konto >= N'" & RTrim(cmbKontoOD.Text) & "'"
            Else
                upit_kontoOD = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbKontoOD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKontoOD.SelectedIndexChanged
        If cmbKontoOD.Text <> "" Then
            upit_kontoOD = "stavka_konto >= N'" & RTrim(cmbKontoOD.Text) & "'"
        Else
            upit_kontoOD = ""
        End If
        cmbKontoDO.SelectedItem = cmbKontoOD.Text
        konto_text(cmbKontoOD.Text, "OD")
    End Sub

    Private Sub cmbKontoDO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbKontoDO.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbKontoDO.Text <> "" Then
                upit_kontoDO = "stavka_konto <= N'" & RTrim(cmbKontoDO.Text) & "'"
            Else
                upit_kontoDO = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbKontoDO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKontoDO.SelectedIndexChanged
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

    Private Sub cmbPartner_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPartnerOD.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbPartnerOD.Text <> "" Then
                upit_partnerOD = "stavka_analitika >= N'" & RTrim(cmbPartnerOD.Text) & "'"
            Else
                upit_partnerOD = "stavka_analitika >= N'3000'"
            End If
            filter()
        End If
    End Sub
    Private Sub cmbPartner_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPartnerOD.SelectedIndexChanged
        If cmbPartnerOD.Text <> "" Then
            upit_partnerOD = "stavka_analitika >= N'" & RTrim(cmbPartnerOD.Text) & "'"
        Else
            upit_partnerOD = "stavka_analitika >= N'3000'"
        End If
        cmbPartnerDO.SelectedItem = cmbPartnerOD.Text
        partner_text(cmbPartnerOD.Text, "OD")
    End Sub

    Private Sub cmbPartnerDO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPartnerDO.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbPartnerDO.Text <> "" Then
                upit_partnerDO = "stavka_analitika <= N'" & RTrim(cmbPartnerDO.Text) & "'"
            Else
                upit_partnerDO = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbPartnerDO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPartnerDO.SelectedIndexChanged
        If cmbPartnerDO.Text <> "" Then
            upit_partnerDO = "stavka_analitika <= N'" & RTrim(cmbPartnerDO.Text) & "'"
        Else
            upit_partnerDO = ""
        End If
        partner_text(cmbPartnerDO.Text, "DO")
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

    Private Sub proveri_formu()
        'Dim mCont As Control ' CheckBox
        Dim mChack As Object

        aktivan_chk = False
        For Each mChack In mPanel2.Controls
            If mChack.name = "chkSve" Or mChack.name = "chkVrsta" _
                    Or mChack.name = "chkDatum" Or mChack.name = "chkBroj" Then
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

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        _stampac = True
        filter()
    End Sub

End Class
