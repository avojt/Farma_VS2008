Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntRobno_izlaz_search
    Private upit As String = ""

    Private upit_broj As String = ""
    Private upit_magacin As String = ""
    Private upit_datum As String = ""
    Private upit_dobavljac As String = ""
    Private upit_zakljcene As String = ""

    Shared sql_start As String = ""

    Shared sql As String = ""
    Private _pocetak As Boolean = True
    Private _poABCedi As Boolean = False
    Private aktivan_chk As Boolean
    Shared _sve As Boolean = True

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntRobno_izlaz_search_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        popuni_Magacine()
        popuni_oj()
        popuni_vrste_dokumenta()

        txtBroj.Enabled = False
        cmbMagacin.Enabled = False
        cmbMagacin.BackColor = Color.Lavender
        cmbDobavljac.Enabled = False
        cmbDobavljac.BackColor = Color.Lavender

        chkSve.CheckState = CheckState.Checked
        chkBroj.CheckState = CheckState.Unchecked
        chkDatum.CheckState = CheckState.Unchecked
        chkMagacin.CheckState = CheckState.Unchecked
        chkDobavljac.CheckState = CheckState.Unchecked

        rbtZaklj.Checked = False
        rbtNezaklj.Checked = True

        _lCount = labCount

        mPanel.Dock = DockStyle.Fill
        'mPanel.Anchor = AnchorStyles.Left
        'mPanel.Anchor = AnchorStyles.Right

    End Sub

    Private Sub popuni_vrste_dokumenta()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbVrstaDok.Items.Clear()
        cmbVrstaDok.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_vrste_dokumenata.* from dbo.app_vrste_dokumenata where vrsta_dok_strana_knjizenja = 'POT' order by vrsta_dok_naziv"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbVrstaDok.Items.Add(DR.Item("vrsta_dok_naziv"))
            Loop
            DR.Close()
        End If
        If cmbVrstaDok.Items.Count > 0 Then
            cmbVrstaDok.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_Magacine()
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

        cmbDobavljac.Items.Clear()
        cmbDobavljac.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_organizacione_jedinice.* from dbo.app_organizacione_jedinice"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbDobavljac.Items.Add(DR.Item("oj_naziv"))
            Loop
            DR.Close()
        End If
        If cmbDobavljac.Items.Count > 0 Then
            cmbDobavljac.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub filter()
        'On Error Resume Next
        sql = sql_start
        upit = ""

        If rbtZaklj.Checked = True Then
            upit_zakljcene = "rm_izlazni_dokument_head.dok_zakljucen = 1"
        End If
        If rbtNezaklj.Checked = True Then
            upit_zakljcene = "rm_izlazni_dokument_head.dok_zakljucen = 0"
        End If

        If Not _sve Then

            If cmbVrstaDok.Text <> "" Then
                sql += " where rm_izlazni_dokument_head.id_vrsta_dokumenta = " & mRob_Dokument.dokumenta_id
                'Else
                '    sql = sql_start '+ " where rm_izlazni_dokument_head.id_vrsta_dokumenta = " & mRob_Dokument.dokumenta_id
            End If

            If chkMagacin.Checked Then
                If cmbMagacin.Text <> "" Then
                    upit_magacin = "dbo.rm_magacin.magacin_naziv = N'" & cmbMagacin.Text & "'"
                Else
                    upit_magacin = ""
                End If
            End If

            If chkBroj.Checked Then
                If txtBroj.Text <> "" Then
                    upit_broj = "rm_izlazni_dokument_head.dok_broj = " & txtBroj.Text '& "%'"
                Else
                    upit_broj = ""
                End If
            End If

            If chkDatum.Checked Then
                upit_datum = "rm_izlazni_dokument_head.dok_datum = '" & _
                                       datDatum.Value.Month.ToString & "/" & _
                                       datDatum.Value.Day.ToString & "/" & _
                                       datDatum.Value.Year.ToString & "'" '& _
            End If

            If chkDobavljac.Checked Then
                If cmbDobavljac.Text <> "" Then
                    upit_dobavljac = "app_partneri.partner_naziv = N'" & cmbDobavljac.Text & "'"
                Else
                    upit_dobavljac = ""
                End If
            End If

            If upit_magacin <> "" And upit <> "" Then
                upit = upit & " and " & upit_magacin
            Else
                If upit_magacin <> "" Then upit = upit_magacin
            End If

            If upit_datum <> "" And upit <> "" Then
                upit = upit & " and " & upit_datum
            Else
                If upit_datum <> "" Then upit = upit_datum
            End If

            If upit_broj <> "" And upit <> "" Then
                upit = upit & " and " & upit_broj
            Else
                If upit_broj <> "" Then upit = upit_broj
            End If

            If upit_dobavljac <> "" And upit <> "" Then
                upit = upit & " and " & upit_dobavljac
            Else
                If upit_dobavljac <> "" Then upit = upit_dobavljac
            End If

        End If

        If upit_zakljcene <> "" And upit <> "" Then
            upit = upit & " and " & upit_zakljcene
        Else
            If upit_zakljcene <> "" Then upit = upit_zakljcene
        End If

        sql = sql_start
        If upit <> "" Then
            sql += " where " & upit
        End If

        Lista()

    End Sub

    Shared Sub Lista()

        _lista.Visible = True
        _lista.Items.Clear()
        _lista.Columns.Clear()

        _lista.Columns.Add("Broj", 55, HorizontalAlignment.Left)
        _lista.Columns.Add("Datum", 80, HorizontalAlignment.Left)
        _lista.Columns.Add("Mag.naziv", 250, HorizontalAlignment.Left)
        _lista.Columns.Add("Part.naziv", 150, HorizontalAlignment.Left)
        _lista.Columns.Add("Ukupno", 90, HorizontalAlignment.Right)
        _lista.Columns.Add("Zaklj.", 60, HorizontalAlignment.Center)
        If _sve Then
            _lista.Columns.Add("Vr.Dokumenta", 90, HorizontalAlignment.Center)
        End If
        _lista.Columns.Add("ID", 2, HorizontalAlignment.Center)

        If sql <> "" Then
            Dim CN As SqlConnection = New SqlConnection(CNNString)
            Dim CM As New SqlCommand
            Dim DR As SqlDataReader

            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = sql
                    DR = .ExecuteReader
                End With

                While DR.Read
                    Dim podatak As New ListViewItem(CStr(DR.Item("dok_broj")))
                    podatak.SubItems.Add(DR.Item("dok_datum"))
                    podatak.SubItems.Add(DR.Item("magacin_naziv").ToString)
                    podatak.SubItems.Add(DR.Item("oj_naziv").ToString)
                    podatak.SubItems.Add(DR.Item("dok_ukupno").ToString)
                    podatak.SubItems.Add(da_ne(DR.Item("dok_zakljucen")))
                    If _sve Then
                        podatak.SubItems.Add(DR.Item("vrsta_dok_naziv").ToString)
                    End If
                    podatak.SubItems.Add(DR.Item("id_dokument"))

                    _lista.Items.AddRange(New ListViewItem() {podatak})

                End While
                DR.Close()
            End If

            CM.Dispose()
            CN.Close()
        End If

        If Not _lCount Is Nothing Then
            _lCount.Text = _lista.Items.Count.ToString + " zapisa"
        End If

    End Sub

    Shared Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function

    'Private Sub rbtZaklj_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtZaklj.CheckedChanged
    '    Select Case rbtZaklj.Checked
    '        Case True
    '            rbtNezaklj.Checked = False
    '            upit_zakljcene = "rm_izlazni_dokument_head.dok_zakljucen = 1"
    '        Case False
    '            upit_zakljcene = ""
    '    End Select
    '    'filter()
    'End Sub

    'Private Sub rbtNezaklj_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNezaklj.CheckedChanged
    '    Select Case rbtNezaklj.Checked
    '        Case True
    '            rbtZaklj.Checked = False
    '            upit_zakljcene = "rm_izlazni_dokument_head.dok_zakljucen = 0"
    '        Case False
    '            upit_zakljcene = ""
    '    End Select
    '    'filter()
    'End Sub

    Private Sub chkSve_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSve.CheckedChanged
        upit_broj = ""
        upit_magacin = ""
        upit_datum = ""
        upit_dobavljac = ""
        Select Case chkSve.CheckState
            Case CheckState.Checked
                chkBroj.Checked = False
                chkDatum.Checked = False
                chkDobavljac.Checked = False
                chkMagacin.Checked = False

                chkBroj.Enabled = False
                chkDatum.Enabled = False
                chkDobavljac.Enabled = False
                chkMagacin.Enabled = False

                cmbVrstaDok.Text = ""
                cmbVrstaDok.Enabled = False

                sql = sql_start + " ORDER BY rm_izlazni_dokument_head.dok_datum DESC"
                filter()
                'Lista()
                _sve = True
            Case CheckState.Unchecked
                chkBroj.Enabled = True
                chkDatum.Enabled = True
                chkDobavljac.Enabled = True
                chkMagacin.Enabled = True
                cmbVrstaDok.Enabled = True
                _lista.Items.Clear()
                _sve = False
        End Select
        'proveri_formu()
    End Sub

    Private Sub chkBroj_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkBroj.CheckedChanged
        Select Case chkBroj.CheckState
            Case CheckState.Checked
                txtBroj.Enabled = True
                txtBroj.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                txtBroj.Enabled = False
                txtBroj.BackColor = Color.Lavender
                upit_magacin = ""
                txtBroj.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub chkDatum_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDatum.CheckedChanged
        Select Case chkDatum.CheckState
            Case CheckState.Checked
                datDatum.Enabled = True
                datDatum.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                datDatum.Enabled = False
                datDatum.BackColor = Color.Lavender
                datDatum.Value = Today
                upit_datum = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub chkDobavljac_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDobavljac.CheckedChanged
        Select Case chkDobavljac.CheckState
            Case CheckState.Checked
                cmbDobavljac.Enabled = True
                cmbDobavljac.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbDobavljac.Enabled = False
                cmbDobavljac.BackColor = Color.Lavender
                upit_magacin = ""
                cmbDobavljac.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub chkMagacin_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMagacin.CheckedChanged
        Select Case chkMagacin.CheckState
            Case CheckState.Checked
                cmbMagacin.Enabled = True
                cmbMagacin.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbMagacin.Enabled = False
                cmbMagacin.BackColor = Color.Lavender
                upit_magacin = ""
                cmbMagacin.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub cmbMagacin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMagacin.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbMagacin.Text <> "" Then
                upit_magacin = "dbo.rm_magacin.magacin_naziv = N'" & cmbMagacin.Text & "'"
            Else
                upit_magacin = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbMagacin_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMagacin.SelectedIndexChanged
        If cmbMagacin.Text <> "" Then
            upit_magacin = "dbo.rm_magacin.magacin_naziv = N'" & cmbMagacin.Text & "'"
        Else
            upit_magacin = ""
        End If
    End Sub

    Private Sub txtBroj_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBroj.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtBroj.Text <> "" Then
                upit_broj = "rm_izlazni_dokument_head.dok_broj = " & txtBroj.Text '& "%'"
            Else
                upit_broj = ""
            End If
            filter()
        End If
    End Sub
    Private Sub txtBroj_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBroj.TextChanged
        If txtBroj.Text <> "" Then
            upit_broj = "rm_izlazni_dokument_head.dok_broj = " & txtBroj.Text '& "%'"
        Else
            upit_broj = ""
        End If
        'filter()
    End Sub

    Private Sub datDatum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datDatum.KeyPress
        If e.KeyChar = Chr(13) Then
            upit_datum = "rm_izlazni_dokument_head.dok_datum = '" & _
                                 datDatum.Value.Month.ToString & "/" & _
                                 datDatum.Value.Day.ToString & "/" & _
                                 datDatum.Value.Year.ToString & "'"
            filter()
        End If
    End Sub
    Private Sub datDatum_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles datDatum.ValueChanged
        upit_datum = "rm_izlazni_dokument_head.dok_datum = '" & _
                                datDatum.Value.Month.ToString & "/" & _
                                datDatum.Value.Day.ToString & "/" & _
                                datDatum.Value.Year.ToString & "'" '& _
        'filter()
    End Sub

    Private Sub cmbDobavljac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbDobavljac.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbDobavljac.Text <> "" Then
                upit_dobavljac = "app_organizacione_jedinice.oj_naziv = N'" & cmbDobavljac.Text & "'"
            Else
                upit_dobavljac = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbDobavljac_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDobavljac.SelectedIndexChanged
        If cmbDobavljac.Text <> "" Then
            upit_dobavljac = "app_organizacione_jedinice.oj_naziv = N'" & cmbDobavljac.Text & "'"
        Else
            upit_dobavljac = ""
        End If
    End Sub

    Private Sub chkABC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkABC.CheckedChanged
        Select Case chkABC.CheckState
            Case CheckState.Checked
                _poABCedi = True
            Case CheckState.Unchecked
                _poABCedi = False
        End Select
    End Sub
    Private Sub chkABC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkABC.KeyPress
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

    Private Sub proveri_formu()
        'Dim mCont As Control ' CheckBox
        Dim mChack As Object

        aktivan_chk = False
        For Each mChack In mPanel2.Controls
            If mChack.name = "chkMagacin" Or mChack.name = "chkDatum" _
                    Or mChack.name = "chkBroj" Or mChack.name = "chkDobavljac" Then
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

    Private Sub cmbVrstaDok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbVrstaDok.KeyPress
        cmbMagacin.Select()
    End Sub

    Private Sub cmbVrstaDok_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVrstaDok.SelectedIndexChanged

        If cmbVrstaDok.Text <> "" Then
            'Label3.Visible = False
            'txtBroj.Visible = True

            _dok_kolone = New String() {}

            mRob_Dokument.tabela = Imena.tabele.rm_ulazni_dokument_head.ToString
            mRob_Dokument.KonamdTekst = "rm_izlazni_dokument_head"
            selektuj_VrsteDokumenta(cmbVrstaDok.Text, Selekcija.po_nazivu)
            mRob_Dokument.dokumenta_id = _id_vrsta_dok
            ReDim _dok_kolone(2)
            _dok_kolone.SetValue("dok_", 0)
            _dok_kolone.SetValue("dokument", 1)
            _dok_kolone.SetValue("dok_st", 2)

        End If

        sql_start = "SELECT " & _
            "rm_izlazni_dokument_head.id_dokument, " & _
            "rm_izlazni_dokument_head.dok_broj, " & _
            "rm_izlazni_dokument_head.dok_datum, " & _
            "rm_izlazni_dokument_head.dok_ukupno, " & _
            "rm_izlazni_dokument_head.dok_pdv_osnovica, " & _
            "rm_izlazni_dokument_head.dok_pdv, " & _
            "rm_izlazni_dokument_head.dok_svega, " & _
            "rm_izlazni_dokument_head.dok_zakljucen, " & _
            "rm_magacin.magacin_sifra, " & _
            "rm_magacin.magacin_naziv, " & _
            "app_organizacione_jedinice.oj_sifra, " & _
            "app_organizacione_jedinice.oj_naziv, " & _
            "app_vrste_dokumenata.vrsta_dok_naziv " & _
            "FROM rm_izlazni_dokument_head " & _
            "LEFT OUTER JOIN rm_magacin ON rm_izlazni_dokument_head.id_magacina = rm_magacin.id_magacin " & _
            "LEFT OUTER JOIN app_organizacione_jedinice ON rm_izlazni_dokument_head.id_partner = app_organizacione_jedinice.id_orgjed " & _
            "LEFT OUTER JOIN app_vrste_dokumenata ON rm_izlazni_dokument_head.id_vrsta_dokumenta = app_vrste_dokumenata.id_vrsta_dok"
    End Sub

#Region "STAMPANJE"
    Shared Sub prn()
        If _lista.SelectedItems.Count > 0 Then
            selektuj_dokument_izl(_lista.SelectedItems(0).SubItems(0).Text, Selekcija.po_sifri)
            dokument_izl_print()
            _raport = Imena.tabele.rm_izlazni_dokument.ToString

            Dim mForm As New frmPrint
            mForm.Show()
        End If
    End Sub

#End Region

End Class
