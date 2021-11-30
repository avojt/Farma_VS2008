Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntPovezana_konta
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
    'Private analitika() As String
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

    Private Sub cntPovezana_konta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mPanel.Dock = DockStyle.Fill
        Spliter_tabele.Dock = DockStyle.Fill
        Spliter_tabele.SplitterDistance = (Spliter_tabele.Width / 2) - 2

        cmbKontoOD.Enabled = False
        cmbKontoOD.BackColor = Color.Lavender
        cmbKontoDO.Enabled = False
        cmbKontoDO.BackColor = Color.Lavender

        pocetak()
    End Sub

    Private Sub pocetak()
        _lCount = labCount
        lKontoOD.Text = ""
        lKontoDO.Text = ""
        labKonto.Text = ""
        labKNaziv.Text = ""

        chkKonto.CheckState = CheckState.Checked
        chkDatum.CheckState = CheckState.Checked

        popuni_konta()

        upit_kontoOD = "stavka_konto >= N'0'"
        upit_kontoDO = "stavka_konto < N'9999999'"

        upit_datOD = CDate("1/1/" & Now.Year.ToString).Date
        upit_datDO = CDate("31/12/" & Now.Year.ToString).Date

        btnDesnoK.Enabled = False
        btnLevoK.Enabled = False

        'red_broj = Nadji_rb("fn_otvorene_stavke", 1)
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
                .CommandText = "select dbo.app_konto.* from dbo.app_konto" ' where Konto_Sifra >= N'122111' and Konto_Sifra <= N'122122' order by Konto_Sifra"
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

    Private Sub filter_duguje()
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
            sql = sql_start & " WHERE " & upit & " and stavka_duguje <> 0 and stavka_konto = N'" & RTrim(cmbKontoOD.Text) & "' and stavka_konto_povezan = 0"
        Else
            sql = sql_start
        End If

        'izdvoj_konta_duguje()

        If Not _stampac Then
            Lista_duguje()
        End If

    End Sub

    Private Sub postavi_konta(ByVal pozicija)
        'If konto.Length > 0 Then
        '    selektuj_konto(konto(pozicija), Selekcija.po_sifri)
        '    labKonto.Text = konto(pozicija)
        '    labKNaziv.Text = _konto_naziv
        'End If
        selektuj_konto(RTrim(cmbKontoOD.Text), Selekcija.po_sifri)
        labKonto.Text = RTrim(cmbKontoOD.Text)
        labKNaziv.Text = _konto_naziv

        'Lista()
    End Sub

    Private Sub Lista_duguje()
        Try
            'If _ima_promet Then
            lvLista_duguje.CheckBoxes = True
            'lvLista_potrazuje.CheckBoxes = True

            Dim CN As SqlConnection = New SqlConnection(CNNString)
            Dim CM As New SqlCommand
            Dim DR As SqlDataReader

            lvLista_duguje.Items.Clear()
            'lvLista_potrazuje.Items.Clear()

            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = sql '& " and stavka_analitika = N'" & analitika(_pozicija_an) & "' and stavka_konto = N'" & konto(_pozicija_kon) & "'"
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
                    podatak.SubItems.Add(Format(DR.Item("stavka_duguje"), "##,##0.00").ToString)
                    podatak.SubItems.Add(DR.Item("id_stavka"))
                    lvLista_duguje.Items.AddRange(New ListViewItem() {podatak})
                End While
                DR.Close()
            End If
            CM.Dispose()
            CN.Close()

            postavi_konta(_pozicija_kon)

            _lCount.Text = "od " & Format(upit_datOD, "D") & _
                         " do " & Format(upit_datDO, "D")

            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub filter_potrazuje()
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
            sql = sql_start & " WHERE " & upit & " and stavka_potrazuje <> 0 and stavka_konto = N'" & RTrim(cmbKontoDO.Text) & "' and stavka_konto_povezan = 0"
        Else
            sql = sql_start
        End If

        'izdvoj_konta_duguje()

        If Not _stampac Then
            Lista_potrazuje()
        End If

    End Sub

    Private Sub postavi_potrazuje(ByVal pozicija)
        If konto.Length > 0 Then
            selektuj_konto(konto(pozicija), Selekcija.po_sifri)
            labKonto.Text = konto(pozicija)
            labKNaziv.Text = _konto_naziv
        End If

        'Lista()
    End Sub

    Private Sub Lista_potrazuje()
        Try
            'If _ima_promet Then
            'lvLista_duguje.CheckBoxes = True
            lvLista_potrazuje.CheckBoxes = True

            Dim CN As SqlConnection = New SqlConnection(CNNString)
            Dim CM As New SqlCommand
            Dim DR As SqlDataReader

            'lvLista_duguje.Items.Clear()
            lvLista_potrazuje.Items.Clear()

            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = sql '& " and stavka_analitika = N'" & analitika(_pozicija_an) & "' and stavka_konto = N'" & konto(_pozicija_kon) & "'"
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
                    podatak.SubItems.Add(Format(DR.Item("stavka_potrazuje"), "##,##0.00").ToString)
                    podatak.SubItems.Add(DR.Item("id_stavka"))
                    lvLista_potrazuje.Items.AddRange(New ListViewItem() {podatak})
                End While
                DR.Close()
            End If
            CM.Dispose()
            CN.Close()

            postavi_konta(_pozicija_kon)

            _lCount.Text = "od " & Format(upit_datOD, "D") & _
                         " do " & Format(upit_datDO, "D")

            'End If
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

    Private Sub cmbKontoOD_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbKontoOD.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbKontoOD.Text <> "" Then
                upit_kontoOD = "stavka_konto >= N'" & RTrim(cmbKontoOD.Text) & "'"
            Else
                upit_kontoOD = ""
            End If
            filter_duguje()
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
            filter_duguje()
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

    Private Sub datDatOD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datDatOD.KeyPress
        If e.KeyChar = Chr(13) Then
            upit_datumOD = "nal_datum >= '" & _
                                 datDatOD.Value.Month.ToString & "/" & _
                                 datDatOD.Value.Day.ToString & "/" & _
                                 datDatOD.Value.Year.ToString & "'"
            upit_datOD = datDatOD.Value
            filter_duguje()
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
            filter_duguje()
        End If
    End Sub
    Private Sub datDatDO_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles datDatDO.ValueChanged
        upit_datumDO = "nal_datum <= '" & _
                                  datDatDO.Value.Month.ToString & "/" & _
                                  datDatDO.Value.Day.ToString & "/" & _
                                  datDatDO.Value.Year.ToString & "'"
        upit_datDO = datDatDO.Value
    End Sub

    Private Sub btnDuguje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDuguje.Click
        _stampac = False
        preg_povezanih = False
        filter_duguje()
        veza_broj = rb_pk(cmbKontoOD.Text)
    End Sub

    Private Sub btnPotrazuje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPotrazuje.Click
        _stampac = False
        preg_povezanih = False
        filter_potrazuje()
        veza_broj = rb_pk(cmbKontoDO.Text)
    End Sub

    Private Sub btnLevoK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLevoK.Click
        _pozicija_kon = _pozicija_kon - 1
        postavi_konta(_pozicija_kon)
        dugmeta_konta()
        Lista_duguje()
        veza_broj = rb_pk(labKonto.Text)
    End Sub

    Private Sub btnDesnoK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesnoK.Click
        _pozicija_kon = _pozicija_kon + 1
        postavi_konta(_pozicija_kon)
        dugmeta_konta()
        Lista_duguje()
        veza_broj = rb_pk(labKonto.Text)
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
                        .CommandText = "fn_povezana_konta_add"
                        .Parameters.AddWithValue("@vezni_broj", veza_broj)
                        .Parameters.AddWithValue("@konto", cmbKontoOD.Text)
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
                        .CommandText = "fn_povezana_konta_add"
                        .Parameters.AddWithValue("@vezni_broj", veza_broj)
                        .Parameters.AddWithValue("@konto", cmbKontoDO.Text)
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
                .CommandText = "fn_nalog_stavka_konto_povezan"
                .Parameters.AddWithValue("@id_stavka", id)
                .Parameters.AddWithValue("@stavka_konto_povezan", 1)
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If
        CN.Close()
    End Sub

    Public Function rb_pk(ByVal _konto As String) As Integer
        Dim CN As System.Data.SqlClient.SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        rb_pk = 0
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.fn_povezana_konta where" & _
                            " dbo.fn_povezana_konta.konto = N'" & _konto & "'"
                DR = .ExecuteReader
            End With
            Try
                Do While DR.Read()
                    If Not IsDBNull(DR.Item("vezni_broj")) And Not RTrim(DR.Item("vezni_broj").ToString) = "" Then
                        If DR.Item("vezni_broj") > rb_pk Then rb_pk = DR.Item("vezni_broj")
                    End If
                Loop
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                MsgBox(ex.Message, MsgBoxStyle.OkOnly)
            End Try
        End If
        CM.Dispose()
        CN.Close()
        rb_pk += 1
    End Function

    Private Sub btnPreg_pov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreg_pov.Click
        Dim i As Integer = 0
        Dim j As Integer = 0

        preg_povezanih = True
        _stampac = True
        filter_duguje()

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prn_povezana_konta_delete"
                .ExecuteScalar()
            End With
        End If

        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.fn_povezana_konta where konto >= N'" & RTrim(cmbKontoOD.Text) & _
                                "' and konto <= N'" & RTrim(cmbKontoDO.Text) & "'"
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
        filter_duguje()

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prn_povezana_konta_delete"
                .ExecuteScalar()
            End With
        End If

        For i = 0 To konto.Length - 1
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = sql & " and stavka_konto = N'" & konto(i) & "'"
                    DR = .ExecuteReader
                End With
                selektuj_konto(konto(i), Selekcija.po_sifri)
                While DR.Read
                    unesi(upit_datOD, upit_datDO, DR.Item("nal_datum"), RTrim(DR.Item("nal_vrsta")), _
                          RTrim(DR.Item("nal_broj")), konto(i), _konto_naziv, "", _partner_naziv, _
                          RTrim(DR.Item("stavka_rb")), DR.Item("stavka_opis"), RTrim(DR.Item("stavka_datDok")), _
                          RTrim(DR.Item("stavka_brDok")), veza_broj, DR.Item("stavka_duguje"), DR.Item("stavka_potrazuje"), _
                          DR.Item("stavka_duguje") - DR.Item("stavka_potrazuje"))
                End While
                DR.Close()
            End If
            CM.Dispose()
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

        Dim myControl As New cntPovezana_konta_ispravke
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_povezana_konta + My.Resources.text_edit
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

End Class
