Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntAnalitika_pregled_po_kontima
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
    Private _ima_promet As Boolean = False
    Private _stampac As Boolean = False

    Private konto As String = ""
    Private analitika As String = ""
    Private partneri As String = ""
    Private duguje As Single = 0
    Private potrazuje As Single = 0
    Private saldo As Single = 0
    Private poc_stanje As Single = 0
    Private broj_cifara As Integer = 0
    Private sintetika As Boolean = False


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntAnalitika_pregled_po_kontima_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _lCount = labCount
        lKontoOD.Text = ""
        lKontoDO.Text = ""

        popuni_konta()

        txtKontoOD.Text = ""
        txtKontoOD.Enabled = False
        txtKontoDO.Text = ""
        txtKontoDO.Enabled = False
        txtBrojCifaraAn.Text = "6"
        txtBrojCifaraSn.Text = "4"

        cmbKontoOD.Enabled = False
        cmbKontoOD.BackColor = Color.Lavender
        cmbKontoDO.Enabled = False
        cmbKontoDO.BackColor = Color.Lavender

        datDatOD.Enabled = False
        datDatDO.Enabled = False

        chkDatum.CheckState = CheckState.Checked
        chkKonto.CheckState = CheckState.Checked

        rbtAnalitika.Checked = False
        rbtSintetika.Checked = True

        upit_kontoOD = ""
        upit_kontoDO = ""

        upit_datumOD = "nal_datum >= '1/1/" & Today.Year.ToString & "'"
        upit_datumDO = "nal_datum <= '" & Today.Month.ToString & "/" & _
                                    Today.Day.ToString & "/" & _
                                    Today.Year.ToString & "'"
        upit_datOD = CDate("1/1/" & Now.Year.ToString).Date
        upit_datDO = Today

        mPanel.Dock = DockStyle.Fill
        '_lista.Visible = False
        '_lista.Items.Clear()
        _lista.Columns.Clear()
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
            Dim CN As SqlConnection = New SqlConnection(CNNString)
            Dim CM As New SqlCommand
            Dim DR As SqlDataReader
            Dim uradjeno As String = ""
            Dim uradjen_donos As String = ""
            Dim svedeno As String = ""
            Dim _donos As Boolean = True
            Dim opis As String = ""
            Dim sufix As String = ""

            _lista.Columns.Clear()
            _lista.Columns.Add("Konto", 85, HorizontalAlignment.Left)
            _lista.Columns.Add("Naziv konta", 250, HorizontalAlignment.Left)
            _lista.Columns.Add("Duguje", 100, HorizontalAlignment.Right)
            _lista.Columns.Add("Potražuje", 100, HorizontalAlignment.Right)
            _lista.Columns.Add("Saldo", 100, HorizontalAlignment.Right)
            _lista.Columns.Add("Poč. Stanje", 100, HorizontalAlignment.Right)
            _lista.Visible = True
            _lista.Items.Clear()

            upit = ""
            If chkKonto.CheckState = CheckState.Checked Then
                If upit <> "" Then
                    upit = upit & " and " & "Konto_Sifra >= N'" & cmbKontoOD.Text & "'"
                Else
                    upit = "Konto_Sifra >= N'" & RTrim(cmbKontoOD.Text) & "'"
                End If

                If upit <> "" Then
                    upit = upit & " and " & "Konto_Sifra <= N'" & RTrim(cmbKontoDO.Text) & "'"
                Else
                    upit = "Konto_Sifra <= N'" & RTrim(cmbKontoDO.Text) & "'"
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

                konto = ""

                While DR.Read
                    Dim _sql_promet As String = ""
                    If sintetika Then

                        svedeno = Mid(DR.Item("Konto_Sifra"), 1, broj_cifara) & "00"
                        konto = Mid(DR.Item("Konto_Sifra"), 1, broj_cifara)
                        sufix = "00"
                        _sql_promet = sql_start & _
                            " WHERE dbo.fn_nalog_stavka.stavka_konto LIKE N'" & konto & _
                            "%' AND dbo.fn_nalog_head.nal_datum >= '1/1/" & Today.Year.ToString & _
                            "' and dbo.fn_nalog_head.nal_datum <= '" & _
                                                datDatDO.Value.Month.ToString & "/" & _
                                                datDatDO.Value.Day.ToString & "/" & _
                                                datDatDO.Value.Year.ToString & "'"

                        If txtBrojCifaraSn.Text = "" Then
                            broj_cifara = Len(RTrim(DR.Item("Konto_Sifra").ToString))
                        Else
                            broj_cifara = txtBrojCifaraSn.Text
                        End If
                    Else
                        konto = RTrim(DR.Item("Konto_Sifra"))
                        sufix = ""
                        _sql_promet = sql_start & " WHERE dbo.fn_nalog_stavka.stavka_konto = N'" & konto & "' AND dbo.fn_nalog_head.nal_datum >= '1/1/" & Today.Year.ToString & "' and dbo.fn_nalog_head.nal_datum <= '12/31/" & Today.Year.ToString & "'"

                        If txtBrojCifaraAn.Text = "" Then
                            broj_cifara = Len(RTrim(DR.Item("Konto_Sifra").ToString))
                        Else
                            broj_cifara = txtBrojCifaraAn.Text
                        End If

                        Select Case Len(Mid(DR.Item("Konto_Sifra"), 1, broj_cifara))
                            Case 5
                                svedeno = Mid(DR.Item("Konto_Sifra"), 1, broj_cifara) & "0"
                            Case Is > 5
                                svedeno = Mid(DR.Item("Konto_Sifra"), 1, broj_cifara)
                        End Select
                    End If

                    If ima_promet(_sql_promet) Then
                       
                        If uradjeno <> konto Then ' Mid(DR.Item("Konto_Sifra"), 1, broj_cifara) Then

                            Dim a As String = Mid(DR.Item("Konto_Sifra"), 1, broj_cifara)
                            If uradjen_donos <> konto Then _donos = True

                            _donos = True
                            If _donos Then
                                If upit_datOD > CDate("1/1/" & Today.Year.ToString).Date Then
                                    If uradjen_donos <> svedeno Then
                                        If ima_promet(_sql_promet) Then
                                            donos(konto)
                                            _donos = False

                                            If _stampac Then
                                                upisi_prn_finansijsko(upit_datOD, upit_datDO, _
                                                        "", "", Today, 0, 0, 0, False, False, _
                                                        "", "", "DONOS 1.1." & Today.Year.ToString & " - " & datDatDO.Value.Date, _
                                                        Mid(DR.Item("Konto_Sifra"), 1, 1), Mid(DR.Item("Konto_Sifra"), 1, 2), _
                                                        svedeno, svedeno, "", duguje, potrazuje, saldo, _
                                                        0, 0, poc_stanje, 0, 0, Today, _
                                                        0, 0, 0, "", "")
                                            Else
                                                Dim podatak As New ListViewItem("DONOS")
                                                podatak.SubItems.Add("")
                                                podatak.SubItems.Add(Format(duguje, "##,##0.00").ToString)
                                                podatak.SubItems.Add(Format(potrazuje, "##,##0.00").ToString)
                                                podatak.SubItems.Add(Format(duguje - potrazuje, "##,##0.00").ToString)
                                                podatak.SubItems.Add(Format(poc_stanje, "##,##0.00").ToString)

                                                podatak.ForeColor = Color.RoyalBlue
                                                _lista.Items.AddRange(New ListViewItem() {podatak})
                                            End If
                                        End If
                                    End If
                                    uradjen_donos = svedeno
                                End If

                            End If

                            pAnalitika(konto)
                            selektuj_konto(konto, Selekcija.po_sifri)

                            If _ima_promet Then
                                If _stampac Then
                                    Dim ko As String = RTrim(DR.Item("Konto_Sifra"))
                                    upisi_prn_finansijsko(upit_datOD, upit_datDO, _
                                            "", "", Today, 0, 0, 0, False, False, _
                                            "", "", _konto_naziv, Mid(DR.Item("Konto_Sifra"), 1, 1), Mid(DR.Item("Konto_Sifra"), 1, 2), _
                                            svedeno, konto & sufix, "", _
                                            duguje, potrazuje, saldo, 0, 0, _
                                            poc_stanje, 0, 0, Today, 0, 0, 0, "", "")
                                    _ima_promet = False
                                Else
                                    Dim podatak1 As New ListViewItem(opis)
                                    podatak1.SubItems.Add(_konto_naziv)
                                    podatak1.SubItems.Add(Format(duguje, "##,##0.00").ToString)
                                    podatak1.SubItems.Add(Format(potrazuje, "##,##0.00").ToString)
                                    podatak1.SubItems.Add(Format(saldo, "##,##0.00").ToString)
                                    podatak1.SubItems.Add(Format(poc_stanje, "##,##0.00").ToString)
                                    _lista.Items.AddRange(New ListViewItem() {podatak1})
                                End If
                            End If
                        End If
                    End If

                    uradjeno = Mid(DR.Item("Konto_Sifra"), 1, broj_cifara)
                End While
                DR.Close()
                CM.Dispose()
                CN.Close()

                _lCount.Text = "od " & Format(upit_datOD, "D") & _
                               " do " & Format(upit_datDO, "D")

                If _stampac Then
                    If sintetika Then
                        _raport = Imena.tabele.fn_analitika_pregled_po_kontima_sintetika.ToString
                    Else
                        _raport = Imena.tabele.fn_analitika_pregled_po_kontima_analitika.ToString
                    End If
                    Dim mForm As New frmPrint
                    mForm.Show()
                End If
                _stampac = False
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

    Private Sub donos(ByVal _konto)
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
                .CommandText = sql_start & "WHERE stavka_konto LIKE N'" & RTrim(_konto) & "%'" & _
                            " AND dbo.fn_nalog_head.nal_datum >= '1/1/" & Now.Year.ToString & "'" & _
                            " AND dbo.fn_nalog_head.nal_datum <= '" & dat.Month.ToString & "/" & _
                                                    dat.Day.ToString & "/" & _
                                                    dat.Year.ToString & "'"

                DR = .ExecuteReader
            End With
           
            While DR.Read
                duguje += DR.Item("stavka_duguje")
                potrazuje += DR.Item("stavka_potrazuje")
                saldo += DR.Item("stavka_duguje") - DR.Item("stavka_potrazuje")
            End While
            DR.Close()
            CM.Dispose()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql_start & "WHERE stavka_konto LIKE N'" & _konto & "%'" & _
                            "AND nal_datum = '1/1/" & Today.Year.ToString & "'" '& _
                DR = .ExecuteReader
            End With
            poc_stanje = 0
           
            While DR.Read
                poc_stanje += DR.Item("stavka_duguje") - DR.Item("stavka_potrazuje")
            End While
            DR.Close()
            CM.Dispose()
        End If
        CN.Close()
    End Sub

    Private Sub pAnalitika(ByVal _konto)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim i As Integer = 0

        CN.Open()
        If CN.State = ConnectionState.Open Then
            duguje = 0
            potrazuje = 0
            saldo = 0
            poc_stanje = 0

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                If sintetika Then
                    .CommandText = sql & " and dbo.fn_nalog_stavka.stavka_konto LIKE N'" & RTrim(_konto) & "%'"
                Else
                    .CommandText = sql & " and dbo.fn_nalog_stavka.stavka_konto = N'" & RTrim(_konto) & "'"
                End If
                DR = .ExecuteReader
            End With

            If DR.HasRows Then
                _ima_promet = True
                While DR.Read
                    duguje += DR.Item("stavka_duguje")
                    potrazuje += DR.Item("stavka_potrazuje")
                    saldo += DR.Item("stavka_duguje") - DR.Item("stavka_potrazuje")
                End While
            End If
            DR.Close()
            CM.Dispose()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql_start & " and dbo.fn_nalog_stavka.stavka_konto = N'" & RTrim(_konto) & "' AND nal_datum = '1/1/" & Today.Year.ToString & "'"
                DR = .ExecuteReader
            End With

            If DR.HasRows Then
                _ima_promet = True
                While DR.Read
                    poc_stanje += DR.Item("stavka_duguje") - DR.Item("stavka_potrazuje")
                End While
            End If
            DR.Close()
            CM.Dispose()
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
                'txtKontoOD.Text = ""
                'txtKontoDO.Text = ""
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
                upit_datOD = CDate("1/1/" & Now.Year.ToString).Date
                upit_datDO = Today
        End Select
        proveri_formu()
    End Sub

    Private Sub cmbKontoOD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbKontoOD.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbKontoOD.Text <> "" Then
                upit_kontoOD = "stavka_konto >= N'" & RTrim(cmbKontoOD.Text) & "%'"
            Else
                upit_kontoOD = ""
            End If
            'filter()
            cmbKontoDO.Select()
            cmbKontoDO.Text = cmbKontoOD.Text
            konto_text(cmbKontoOD.Text, "OD")
        End If
    End Sub
    Private Sub cmbKontoOD_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbKontoOD.SelectedIndexChanged
        If cmbKontoOD.Text <> "" Then
            upit_kontoOD = "stavka_konto >= N'" & RTrim(cmbKontoOD.Text) & "%'"
        Else
            upit_kontoOD = ""
        End If
        cmbKontoDO.Text = cmbKontoOD.Text
        konto_text(cmbKontoOD.Text, "OD")
    End Sub

    Private Sub cmbKontoDO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbKontoDO.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbKontoDO.Text <> "" Then
                upit_kontoDO = "stavka_konto <= N'" & RTrim(cmbKontoDO.Text) & "%'"
            Else
                upit_kontoDO = ""
            End If
            'filter()
            konto_text(cmbKontoDO.Text, "DO")
        End If
    End Sub
    Private Sub cmbKontoDO_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbKontoDO.SelectedIndexChanged
        If cmbKontoDO.Text <> "" Then
            upit_kontoDO = "stavka_konto <= N'" & RTrim(cmbKontoDO.Text) & "%'"
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
                .CommandText = "select * from app_konto where Konto_Sifra LIKE '" & RTrim(_konto) & "%'"
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

    Private Sub txtBrojCifaraSn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBrojCifaraSn.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtBrojCifaraSn.Text <> "" Then
                If txtBrojCifaraSn.Text <= "4" Then
                    MsgBox("Za svodjenja na 6 ili više cifara koristite 'ANALITIČKI' pregled.", MsgBoxStyle.OkOnly)
                Else
                    broj_cifara = RTrim(txtBrojCifaraSn.Text)
                    btnOK.Select()
                End If
            Else
                'broj_cifara = 4
            End If
        End If
    End Sub
    Private Sub txtBrojCifaraSn_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBrojCifaraSn.TextChanged
        If txtBrojCifaraSn.Text <> "" Then
            If txtBrojCifaraSn.Text >= "6" Then
                MsgBox("Za svodjenja na 4 ili manje cifara koristite 'SINTETIČKI' pregled.", MsgBoxStyle.OkOnly)
            Else
                broj_cifara = RTrim(txtBrojCifaraSn.Text)
            End If
        Else
            'broj_cifara = 4
        End If
    End Sub

    Private Sub txtBrojCifaraAn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBrojCifaraAn.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtBrojCifaraAn.Text <> "" Then
                If txtBrojCifaraAn.Text <= "4" Then
                    MsgBox("Za svodjenja na 4 ili manje cifara koristite 'SINTETIČKI' pregled.", MsgBoxStyle.OkOnly)
                Else
                    broj_cifara = RTrim(txtBrojCifaraAn.Text)
                    btnOK.Select()
                End If
                broj_cifara = RTrim(txtBrojCifaraAn.Text)
            Else
                'broj_cifara = 6
            End If
        End If
    End Sub
    Private Sub txtBrojCifaraAn_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBrojCifaraAn.TextChanged
        If txtBrojCifaraAn.Text <> "" Then
            If txtBrojCifaraAn.Text <= "4" Then
                MsgBox("Za svodjenja na 4 ili manje cifara koristite 'SINTETIČKI' pregled.", MsgBoxStyle.OkOnly)
            Else
                broj_cifara = RTrim(txtBrojCifaraAn.Text)
            End If
        Else
            'broj_cifara = 6
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

    Private Sub rbtSintetika_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtSintetika.CheckedChanged
        Select Case rbtSintetika.Checked
            Case True
                sintetika = True
                broj_cifara = 4
                txtBrojCifaraSn.Text = 4
                txtBrojCifaraSn.Enabled = True
                txtBrojCifaraSn.BackColor = Color.GhostWhite
                txtBrojCifaraAn.Text = ""
                txtBrojCifaraAn.Enabled = False
                txtBrojCifaraAn.BackColor = Color.Lavender
                Label5.Enabled = False
            Case False
                sintetika = False
                broj_cifara = 0
                txtBrojCifaraSn.Text = ""
                txtBrojCifaraSn.Enabled = False
                txtBrojCifaraSn.BackColor = Color.Lavender
                txtBrojCifaraAn.Text = 6
                txtBrojCifaraAn.Enabled = True
                txtBrojCifaraAn.BackColor = Color.GhostWhite
                Label5.Enabled = True
        End Select
    End Sub

    Private Sub rbtAnalitika_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAnalitika.CheckedChanged
        Select Case rbtAnalitika.Checked
            Case True
                sintetika = False
                broj_cifara = 0
                txtBrojCifaraSn.Text = ""
                txtBrojCifaraSn.Enabled = False
                txtBrojCifaraSn.BackColor = Color.Lavender
                txtBrojCifaraAn.Text = 6
                txtBrojCifaraAn.Enabled = True
                txtBrojCifaraAn.BackColor = Color.GhostWhite
                Label5.Enabled = True
            Case False
                sintetika = True
                broj_cifara = 4
                txtBrojCifaraSn.Text = 4
                txtBrojCifaraSn.Enabled = True
                txtBrojCifaraSn.BackColor = Color.GhostWhite
                txtBrojCifaraAn.Text = ""
                txtBrojCifaraAn.Enabled = False
                txtBrojCifaraAn.BackColor = Color.Lavender
                Label5.Enabled = False
        End Select
    End Sub

 
End Class
