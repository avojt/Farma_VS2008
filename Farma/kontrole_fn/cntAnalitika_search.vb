Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntAnalitika_search

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
                "SELECT dbo.fn_nalog_head.nal_broj, dbo.fn_nalog_head.nal_datum, " & _
                    "dbo.fn_nalog_stavka.stavka_rb, dbo.fn_nalog_stavka.stavka_opis_sifra, " & _
                    "dbo.fn_nalog_stavka.stavka_opis, dbo.fn_nalog_stavka.stavka_konto, " & _
                    "dbo.fn_nalog_stavka.stavka_analitika, dbo.fn_nalog_stavka.stavka_duguje, " & _
                    "dbo.fn_nalog_stavka.stavka_potrazuje, dbo.fn_nalog_head.nal_vrsta " & _
                "FROM dbo.fn_nalog_stavka INNER JOIN " & _
                    "dbo.fn_nalog_head ON dbo.fn_nalog_stavka.id_nalog = dbo.fn_nalog_head.id_nalog "
    '"WHERE dbo.fn_nalog_stavka.stavka_analitika IS NOT NULL) OR " & _
    '"(dbo.fn_nalog_stavka.stavka_analitika <> N'')"

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

    Private Sub cntAnalitika_search_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

        chkDatum.CheckState = CheckState.Unchecked
        chkPartner.CheckState = CheckState.Unchecked
        chkKonto.CheckState = CheckState.Unchecked

        datDatOD.Enabled = False
        datDatDO.Enabled = False

        _lCount = labCount

        upit_partnerOD = "partner_sifra >= N'4000'"
        upit_datumOD = "nal_datum >= '01/01/" & Now.Year.ToString & "'"
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
        cmbPartnerOD.Items.Add("")

        cmbPartnerDO.Items.Clear()
        cmbPartnerDO.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_partneri.* from dbo.app_partneri"
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
            cmbPartnerDO.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_konta()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbKontoOD.Items.Clear()
        cmbKontoOD.Items.Add("")

        cmbKontoDO.Items.Clear()
        cmbKontoDO.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_konto.* from dbo.app_konto order by Konto_Sifra"
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
            cmbKontoDO.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub filter()
        'On Error Resume Next

        upit = ""
        sql = ""

        If upit_kontoOD <> "" And upit <> "" Then
            upit = upit & " and " & upit_kontoOD
        Else
            If upit_kontoOD <> "" Then upit = upit_kontoOD
        End If

        If upit_kontoDO <> "" And upit <> "" Then
            upit = upit & " and " & upit_kontoDO
        Else
            If upit_kontoDO <> "" Then upit = upit_kontoDO
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

        If upit <> "" Then
            sql = sql_start & " WHERE " & upit
        Else
            sql = sql_start
        End If

        If _stampac Then
            Lista_prn()
            _stampac = False
        Else
            Lista()
        End If

    End Sub

    Private Sub Lista()
        Try
            _lista.Columns.Clear()

            _lista.Columns.Add("Konto", 70, HorizontalAlignment.Left)
            _lista.Columns.Add("Analitika", 60, HorizontalAlignment.Left)
            _lista.Columns.Add("Dobavljači u zemlji-analitika", 250, HorizontalAlignment.Left)
            _lista.Columns.Add("Duguje", 110, HorizontalAlignment.Right)
            _lista.Columns.Add("Potražuje", 110, HorizontalAlignment.Right)
            _lista.Columns.Add("Saldo", 110, HorizontalAlignment.Right)
            _lista.Columns.Add("Početno Stanje", 110, HorizontalAlignment.Right)

            Dim CN As SqlConnection = New SqlConnection(CNNString)
            Dim CM As New SqlCommand
            Dim DR As SqlDataReader

            _lista.Visible = True
            _lista.Items.Clear()

            upit = ""
            If upit_partnerOD <> "" And upit <> "" Then
                upit = upit & " and " & upit_partnerOD
            Else
                If upit_partnerOD <> "" Then upit = upit_partnerOD
            End If

            If upit_partnerDO <> "" And upit <> "" Then
                upit = upit & " and " & upit_partnerDO
            Else
                If upit_partnerDO <> "" Then upit = upit_partnerDO
            End If

            If upit = "" Then upit = "partner_sifra >= N'4000'"

            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = "select * from app_partneri" & " WHERE " & upit ' where partner_sifra >= 4000"
                    DR = .ExecuteReader
                End With

                While DR.Read

                    suma_partner(DR.Item("partner_sifra"))
                    If ima_promena Then
                        Dim podatak As New ListViewItem(konto)

                        podatak.SubItems.Add(DR.Item("partner_sifra"))
                        podatak.SubItems.Add(DR.Item("partner_naziv"))
                        podatak.SubItems.Add(Format(duguje, "##,##0.00").ToString)
                        podatak.SubItems.Add(Format(potrazuje, "##,##0.00").ToString)
                        podatak.SubItems.Add(Format(duguje - potrazuje, "##,##0.00").ToString)
                        podatak.SubItems.Add(Format(poc_stanje, "##,##0.00").ToString)

                        _lista.Items.AddRange(New ListViewItem() {podatak})
                    End If
                End While
                DR.Close()
            End If
            CM.Dispose()
            CN.Close()

            '_lCount.Text = _lista.Items.Count.ToString + " zapisa"
            Dim _od() As String = Split(upit_datumOD, " >= ", 2)
            Dim _do() As String = Split(upit_datumDO, " <= ", 2)
            _lCount.Text = "od " & _od(1) & " do " & _do(1)

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

    Private Sub donos()
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
                .CommandText = "SELECT dbo.fn_nalog_head.nal_broj, dbo.fn_nalog_head.nal_datum, " & _
                                    "dbo.fn_nalog_stavka.stavka_rb, dbo.fn_nalog_stavka.stavka_opis_sifra, " & _
                                    "dbo.fn_nalog_stavka.stavka_opis, dbo.fn_nalog_stavka.stavka_konto, " & _
                                    "dbo.fn_nalog_stavka.stavka_analitika, dbo.fn_nalog_stavka.stavka_duguje, " & _
                                    "dbo.fn_nalog_stavka.stavka_potrazuje, dbo.fn_nalog_head.nal_vrsta " & _
                                "FROM dbo.fn_nalog_stavka INNER JOIN " & _
                                    "dbo.fn_nalog_head ON dbo.fn_nalog_stavka.id_nalog = dbo.fn_nalog_head.id_nalog " & _
                                "WHERE dbo.fn_nalog_head.nal_datum >= '01/01/" & Now.Year.ToString & "' " & _
                                    "AND dbo.fn_nalog_head.nal_datum <= '" & datDatOD.Value.Month.ToString & "/" & _
                                                                            datDatOD.Value.Day.ToString & "/" & _
                                                                            datDatOD.Value.Year.ToString & "'" & _
                                    "AND stavka_analitika >= N'4000'"
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
                .CommandText = "SELECT dbo.fn_nalog_head.nal_broj, dbo.fn_nalog_head.nal_datum, " & _
                                    "dbo.fn_nalog_stavka.stavka_rb, dbo.fn_nalog_stavka.stavka_opis_sifra, " & _
                                    "dbo.fn_nalog_stavka.stavka_opis, dbo.fn_nalog_stavka.stavka_konto, " & _
                                    "dbo.fn_nalog_stavka.stavka_analitika, dbo.fn_nalog_stavka.stavka_duguje, " & _
                                    "dbo.fn_nalog_stavka.stavka_potrazuje, dbo.fn_nalog_head.nal_vrsta " & _
                                "FROM dbo.fn_nalog_stavka INNER JOIN " & _
                                    "dbo.fn_nalog_head ON dbo.fn_nalog_stavka.id_nalog = dbo.fn_nalog_head.id_nalog " & _
                                "WHERE dbo.fn_nalog_head.nal_datum >= '01/01/" & Now.Year.ToString & "'" & _
                                    "AND stavka_analitika >= N'4000'"
                DR = .ExecuteReader
            End With
            While DR.Read
                poc_stanje += DR.Item("stavka_duguje") - DR.Item("stavka_potrazuje")
            End While
            DR.Close()
            CM.Dispose()
        End If
    End Sub

    Private Sub suma_partner(ByVal _analitika)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        konto = ""
        partneri = ""
        duguje = 0
        potrazuje = 0
        saldo = 0
        poc_stanje = 0

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql & " and stavka_analitika = '" & RTrim(_analitika) & "'"
                DR = .ExecuteReader
            End With
            If DR.HasRows Then
                ima_promena = True
                While DR.Read
                    konto = DR.Item("stavka_konto")
                    duguje = DR.Item("stavka_duguje")
                    potrazuje = DR.Item("stavka_potrazuje")
                    saldo = DR.Item("stavka_duguje") - DR.Item("stavka_potrazuje")
                End While
                DR.Close()
                CM.Dispose()

                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = "SELECT dbo.fn_nalog_head.nal_broj, dbo.fn_nalog_head.nal_datum, " & _
                                        "dbo.fn_nalog_stavka.stavka_rb, dbo.fn_nalog_stavka.stavka_opis_sifra, " & _
                                        "dbo.fn_nalog_stavka.stavka_opis, dbo.fn_nalog_stavka.stavka_konto, " & _
                                        "dbo.fn_nalog_stavka.stavka_analitika, dbo.fn_nalog_stavka.stavka_duguje, " & _
                                        "dbo.fn_nalog_stavka.stavka_potrazuje, dbo.fn_nalog_head.nal_vrsta " & _
                                    "FROM dbo.fn_nalog_stavka INNER JOIN " & _
                                        "dbo.fn_nalog_head ON dbo.fn_nalog_stavka.id_nalog = dbo.fn_nalog_head.id_nalog " & _
                                    "WHERE dbo.fn_nalog_head.nal_datum = '01/01/" & Year(Today) & "' " & _
                                        "AND dbo.fn_nalog_stavka.stavka_analitika = N'" & RTrim(_analitika) & "'"
                    DR = .ExecuteReader
                End With
                While DR.Read
                    poc_stanje += DR.Item("stavka_duguje") - DR.Item("stavka_potrazuje")
                End While
                DR.Close()
                CM.Dispose()
            Else
                ima_promena = False
            End If
        End If
        CN.Close()
    End Sub

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
        End Select
    End Sub

    Private Sub chkPartner_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPartner.CheckedChanged
        Select Case chkPartner.CheckState
            Case CheckState.Checked
                cmbPartnerOD.Enabled = True
                cmbPartnerOD.BackColor = Color.GhostWhite
                cmbPartnerDO.Enabled = True
                cmbPartnerDO.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbPartnerOD.Enabled = False
                cmbPartnerOD.BackColor = Color.Lavender
                cmbPartnerDO.Enabled = False
                cmbPartnerDO.BackColor = Color.Lavender
                upit_partnerOD = "partner_sifra >= N'4000'"
                upit_partnerDO = "" '"partner_sifra <= N'" & RTrim(cmbPartnerDO.Text) & "'"
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
                datDatDO.Enabled = True
                datDatDO.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                datDatOD.Enabled = False
                datDatOD.BackColor = Color.Lavender
                datDatDO.Enabled = False
                datDatDO.BackColor = Color.Lavender
                datDatOD.Value = Today
                datDatDO.Value = Today
                upit_datumOD = "nal_datum >= '01/01/" & Now.Year.ToString & "'"
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
    End Sub

    Private Sub cmbPartner_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPartnerOD.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbPartnerOD.Text <> "" Then
                upit_partnerOD = "partner_sifra >= N'" & RTrim(cmbPartnerOD.Text) & "'"
            Else
                upit_partnerOD = "partner_sifra >= N'4000'"
            End If
            filter()
        End If
    End Sub
    Private Sub cmbPartner_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPartnerOD.SelectedIndexChanged
        If cmbPartnerOD.Text <> "" Then
            upit_partnerOD = "partner_sifra >= N'" & RTrim(cmbPartnerOD.Text) & "'"
        Else
            upit_partnerOD = "partner_sifra >= N'4000'"
        End If
        cmbPartnerDO.SelectedItem = cmbPartnerOD.Text
    End Sub

    Private Sub cmbPartnerDO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPartnerDO.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbPartnerDO.Text <> "" Then
                upit_partnerDO = "partner_sifra <= N'" & RTrim(cmbPartnerDO.Text) & "'"
            Else
                upit_partnerDO = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbPartnerDO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPartnerDO.SelectedIndexChanged
        If cmbPartnerDO.Text <> "" Then
            upit_partnerDO = "partner_sifra <= N'" & RTrim(cmbPartnerDO.Text) & "'"
        Else
            upit_partnerDO = ""
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

    Private Sub Lista_prn()

        _lista.Visible = True
        _lista.Items.Clear()

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        With CM
            .Connection = CN
            .CommandType = CommandType.StoredProcedure
            .CommandText = "prn_Finansijsko_delete"
            .ExecuteScalar()
        End With
        CM.Dispose()

        upit = ""
        If upit_partnerOD <> "" And upit <> "" Then
            upit = upit & " and " & upit_partnerOD
        Else
            If upit_partnerOD <> "" Then upit = upit_partnerOD
        End If

        If upit_partnerDO <> "" And upit <> "" Then
            upit = upit & " and " & upit_partnerDO
        Else
            If upit_partnerDO <> "" Then upit = upit_partnerDO
        End If

        If upit = "" Then upit = "partner_sifra >= N'4000'"

        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from app_partneri" & " WHERE " & upit ' where partner_sifra >= 4000"
                DR = .ExecuteReader
            End With

            While DR.Read

                suma_partner_prn(DR.Item("partner_sifra"))
                If ima_promena Then
                    upisi_prn_finansijsko(upit_datOD, upit_datDO, "", "", Today, _
                        0, 0, 0, False, False, "", "", "", "", "", konto, DR.Item("partner_sifra"), _
                        DR.Item("partner_naziv"), duguje, potrazuje, duguje - potrazuje, _
                        0, 0, poc_stanje, 0, 0, Today, 0, 0, 0, "", "")
                End If
            End While
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()

        _raport = Imena.tabele.fn_analitika_kumulativ.ToString
        Dim mForm As New frmPrint
        mForm.Show()

    End Sub

    Private Sub suma_partner_prn(ByVal _analitika)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        konto = ""
        partneri = ""
        duguje = 0
        potrazuje = 0
        saldo = 0
        poc_stanje = 0

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql & " and stavka_analitika = '" & RTrim(_analitika) & "'"
                DR = .ExecuteReader
            End With
            If DR.HasRows Then
                ima_promena = True
                While DR.Read
                    konto = DR.Item("stavka_konto")
                    duguje = DR.Item("stavka_duguje")
                    potrazuje = DR.Item("stavka_potrazuje")
                    saldo = DR.Item("stavka_duguje") - DR.Item("stavka_potrazuje")
                End While
                DR.Close()
                CM.Dispose()

                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = "SELECT dbo.fn_nalog_head.nal_broj, dbo.fn_nalog_head.nal_datum, " & _
                                        "dbo.fn_nalog_stavka.stavka_rb, dbo.fn_nalog_stavka.stavka_opis_sifra, " & _
                                        "dbo.fn_nalog_stavka.stavka_opis, dbo.fn_nalog_stavka.stavka_konto, " & _
                                        "dbo.fn_nalog_stavka.stavka_analitika, dbo.fn_nalog_stavka.stavka_duguje, " & _
                                        "dbo.fn_nalog_stavka.stavka_potrazuje, dbo.fn_nalog_head.nal_vrsta " & _
                                    "FROM dbo.fn_nalog_stavka INNER JOIN " & _
                                        "dbo.fn_nalog_head ON dbo.fn_nalog_stavka.id_nalog = dbo.fn_nalog_head.id_nalog " & _
                                    "WHERE dbo.fn_nalog_head.nal_datum = '01/01/" & Year(Today) & "' " & _
                                        "AND dbo.fn_nalog_stavka.stavka_analitika = N'" & RTrim(_analitika) & "'"
                    DR = .ExecuteReader
                End With
                While DR.Read
                    poc_stanje += DR.Item("stavka_duguje") - DR.Item("stavka_potrazuje")
                End While
                DR.Close()
                CM.Dispose()
            Else
                ima_promena = False
            End If
        End If
        CN.Close()
    End Sub

End Class
