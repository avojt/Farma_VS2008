Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO

Public Class cntLab_Dn_search
    Shared upit As String = ""

    Shared upit_lab_dn As String = ""
    Shared upit_treb As String = ""
    Shared upit_broj As String = ""
    Shared upit_datum As String = ""
    Shared upit_datumDO As String = ""
    Shared upit_datumOD As String = ""
    Shared upit_zakljcene As String = ""

    Shared sql_start_ld As String = "SELECT * FROM dbo.pr_lab_dn_head"
    Shared sql_start_treb As String = "SELECT * FROM dbo.pr_trebovanje"

    Shared sql_ld As String = ""
    Shared sql_treb As String = ""
    Private _pocetak As Boolean = True
    Shared _poABCedi As Boolean = False
    Private aktivan_chk As Boolean
    Shared _Nezaklj As RadioButton
    Shared _Zaklj As RadioButton
    Shared _Datum As CheckBox
    Shared _Do As CheckBox

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub clsProizvodnja_search_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        chkDatum.CheckState = CheckState.Unchecked
        chkDo.CheckState = CheckState.Unchecked

        chkBroj.CheckState = CheckState.Unchecked
        chkLab_Dn.CheckState = CheckState.Unchecked
        chkTrebovanje.CheckState = CheckState.Unchecked

        chkSve.CheckState = CheckState.Checked

        rbtZaklj.Checked = False
        rbtNezaklj.Checked = True

        _lCount = labCount

        mPanel.Dock = DockStyle.Fill

        datDatumOD.Enabled = False
        datDatumDO.Enabled = False
        _datumOD = datDatumOD
        _datumDO = datDatumDO
        _Nezaklj = rbtNezaklj
        _Zaklj = rbtZaklj
        _Datum = chkDatum
        _Do = chkDo

        _mCntLab_Dn_search = Me
    End Sub

    Shared Sub filter()
        'On Error Resume Next
        upit = ""
        sql_ld = sql_start_ld
        sql_treb = sql_start_treb

        If _Nezaklj.Checked = True Then
            upit_zakljcene = "dbo.pr_lab_dn_head.lab_dn_zakljuen = 0"
        End If
        If _Zaklj.Checked = True Then
            upit_zakljcene = "dbo.pr_lab_dn_head.lab_dn_zakljuen = 1"
        End If

        If Not _sve Then
            If _Datum.Checked And _Do.Checked Then
                upit = "dbo.pr_lab_dn_head.lab_dn_datum >= '" & _
                            _datumOD.Value.Month.ToString & "/" & _
                            _datumOD.Value.Day.ToString & "/" & _
                            _datumOD.Value.Year.ToString & "' AND " & _
                       "dbo.pr_lab_dn_head.lab_dn_datum <= '" & _
                            _datumDO.Value.Month.ToString & "/" & _
                            _datumDO.Value.Day.ToString & "/" & _
                            _datumDO.Value.Year.ToString & "'"
            Else
                If upit_datumOD <> "" And upit <> "" Then
                    upit = upit & " AND " & upit_datumOD
                Else
                    If upit_datumOD <> "" Then upit = upit_datumOD
                End If
                If upit_datumDO <> "" And upit <> "" Then
                    upit = upit & " AND " & upit_datumDO
                Else
                    If upit_datumDO <> "" Then upit = upit_datumDO
                End If
            End If
        End If

        If upit_zakljcene <> "" And upit <> "" Then
            upit = upit & " and " & upit_zakljcene
        Else
            If upit_zakljcene <> "" Then upit = upit_zakljcene
        End If

        If upit <> "" Then
            If sql_ld <> sql_start_ld Then
                sql_ld += " and " & upit
            Else
                sql_ld += " where " & upit
            End If
            'If sql_treb <> sql_start_treb Then
            '    sql_treb += " and " & upit
            'Else
            '    sql_treb += " where " & upit
            'End If
        End If

        Lista()

    End Sub

    Shared Sub Lista()

        _lista.Visible = True
        _lista.Items.Clear()

        If sql_ld <> "" Then
            Dim CN As SqlConnection = New SqlConnection(CNNString)
            Dim CM As New SqlCommand
            Dim DR As SqlDataReader

            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = sql_ld
                    DR = .ExecuteReader
                End With

                While DR.Read
                    If _lab_dnev Then
                        Dim podatak As New ListViewItem(CStr(DR.Item("lab_dn_broj")))
                        podatak.SubItems.Add(DR.Item("lab_dn_datum"))
                        podatak.SubItems.Add("LAB.DNEVNIK")
                        podatak.SubItems.Add(" ")
                        podatak.SubItems.Add(" ")
                        podatak.SubItems.Add(da_ne(DR.Item("lab_dn_zakljuen")))
                        podatak.SubItems.Add(" ")

                        _lista.Items.AddRange(New ListViewItem() {podatak})
                    End If
                    
                    If _trebovanje Then
                        trebovanje(DR.Item("lab_dn_broj"))
                    End If
                End While
                DR.Close()
            End If
            CM.Dispose()
            CN.Close()
        End If

        _lCount.Text = _lista.Items.Count.ToString + " zapisa"

    End Sub

    Shared Sub trebovanje(ByVal broj)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM dbo.pr_trebovanje where treb_broj = " & broj
                DR = .ExecuteReader
            End With

            While DR.Read
                Dim podatak As New ListViewItem(CStr(DR.Item("treb_broj")))
                podatak.SubItems.Add(DR.Item("treb_datum"))
                podatak.SubItems.Add("TREBOVANJE")
                podatak.SubItems.Add(" ")
                podatak.SubItems.Add(" ")
                podatak.SubItems.Add(da_ne(DR.Item("treb_zakljuen")))
                podatak.SubItems.Add(" ")

                _lista.Items.AddRange(New ListViewItem() {podatak})

            End While
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
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
    '            upit_zakljcene = "dbo.pr_lab_dn_head.lab_dn_zakljuen = 1"
    '        Case False
    '            upit_zakljcene = ""
    '    End Select
    '    'filter()
    'End Sub

    'Private Sub rbtNezaklj_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNezaklj.CheckedChanged
    '    Select Case rbtNezaklj.Checked
    '        Case True
    '            rbtZaklj.Checked = False
    '            upit_zakljcene = "dbo.pr_lab_dn_head.lab_dn_zakljuen = 0"
    '        Case False
    '            upit_zakljcene = ""
    '    End Select
    '    'filter()
    'End Sub

    Private Sub chkSve_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSve.CheckedChanged
        upit_lab_dn = ""
        upit_treb = ""
        upit_broj = ""
        upit_datum = ""
        upit_zakljcene = ""
        _trebovanje = True
        _lab_dnev = True
        Select Case chkSve.CheckState
            Case CheckState.Checked
                chkDatum.Checked = False
                chkDo.Checked = False
                chkBroj.Checked = False
                chkLab_Dn.Checked = False
                chkTrebovanje.Checked = False

                chkDatum.Enabled = False
                chkDo.Enabled = False
                chkBroj.Enabled = False
                chkLab_Dn.Enabled = False
                chkTrebovanje.Enabled = False

                sql_ld = sql_start_ld + " ORDER BY dbo.pr_lab_dn_head.lab_dn_broj"
                sql_treb = sql_start_treb + " ORDER BY dbo.pr_trebovanje.treb_broj"
                'filter()
                _sve = True
            Case CheckState.Unchecked
                chkDatum.Enabled = True
                chkDo.Enabled = True
                chkBroj.Enabled = True
                chkLab_Dn.Enabled = True
                chkTrebovanje.Enabled = True

                _lista.Items.Clear()
                _sve = False
        End Select
        'proveri_formu()
    End Sub

    Private Sub chkLab_Dn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLab_Dn.CheckedChanged
        upit_lab_dn = ""
        upit_treb = ""
        upit_broj = ""
        upit_datum = ""
        upit_zakljcene = ""
        upit_datum = ""
        Select Case chkLab_Dn.CheckState
            Case CheckState.Checked
                _trebovanje = False
                _lab_dnev = True
                chkTrebovanje.Checked = False
                sql_ld = sql_start_ld + " ORDER BY dbo.pr_lab_dn_head.lab_dn_broj"
                sql_treb = sql_start_treb + " ORDER BY dbo.pr_trebovanje.treb_broj"
                'filter()
            Case CheckState.Unchecked
                _lista.Items.Clear()
                _trebovanje = True
                _lab_dnev = False
        End Select
        'proveri_formu()
    End Sub

    Private Sub chkTrebovanje_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTrebovanje.CheckedChanged
        Select Case chkTrebovanje.CheckState
            Case CheckState.Checked
                _trebovanje = True
                _lab_dnev = False
                chkLab_Dn.Checked = False
                txtBroj.Enabled = True
                txtBroj.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                _lista.Items.Clear()
                _trebovanje = False
                _lab_dnev = True
        End Select
        proveri_formu()
    End Sub

    Private Sub chkDatum_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDatum.CheckedChanged
        Select Case chkDatum.CheckState
            Case CheckState.Checked
                datDatumOD.Enabled = True
                datDatumOD.BackColor = Color.GhostWhite
                chkDo.Enabled = True
            Case CheckState.Unchecked
                datDatumOD.Enabled = False
                datDatumOD.BackColor = Color.Lavender
                datDatumOD.Value = Today

                datDatumDO.Enabled = False
                datDatumDO.BackColor = Color.Lavender
                datDatumDO.Value = Today

                chkDo.Enabled = False

                upit_datumDO = ""
                upit_datumOD = ""
        End Select
        'proveri_formu()
    End Sub

    Private Sub chkDo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDo.CheckedChanged
        Select Case chkDo.CheckState
            Case CheckState.Checked
                datDatumDO.Enabled = True
                datDatumDO.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                datDatumDO.Enabled = False
                datDatumDO.BackColor = Color.Lavender
                datDatumDO.Value = Today

                upit_datumDO = ""
        End Select
        'proveri_formu()
    End Sub

    Private Sub datDatum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datDatumOD.KeyPress
        If e.KeyChar = Chr(13) Then
            upit_datumOD = "dbo.pr_lab_dn_head.lab_dn_datum = '" & _
                                 datDatumOD.Value.Month.ToString & "/" & _
                                 datDatumOD.Value.Day.ToString & "/" & _
                                 datDatumOD.Value.Year.ToString & "'"
            'filter()
        End If
    End Sub
    Private Sub datDatum_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles datDatumOD.ValueChanged
        upit_datumOD = "dbo.pr_lab_dn_head.lab_dn_datum = '" & _
                                datDatumOD.Value.Month.ToString & "/" & _
                                datDatumOD.Value.Day.ToString & "/" & _
                                datDatumOD.Value.Year.ToString & "'"

    End Sub

    Private Sub datDatumDO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datDatumDO.KeyPress
        If e.KeyChar = Chr(13) Then
            upit_datumDO = "dbo.pr_lab_dn_head.lab_dn_datum <= '" & _
                                 datDatumDO.Value.Month.ToString & "/" & _
                                 datDatumDO.Value.Day.ToString & "/" & _
                                 datDatumDO.Value.Year.ToString & "'"
            'filter()
        End If
    End Sub
    Private Sub datDatumDO_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles datDatumDO.ValueChanged
        upit_datumDO = "dbo.pr_lab_dn_head.lab_dn_datum <= '" & _
                                       datDatumDO.Value.Month.ToString & "/" & _
                                       datDatumDO.Value.Day.ToString & "/" & _
                                       datDatumDO.Value.Year.ToString & "'"

    End Sub

    Private Sub proveri_formu()
        Dim mChack As Object

        aktivan_chk = False
        For Each mChack In mPanel2.Controls
            If mChack.name = "chkNaziv" Or mChack.name = "chkDatum" Then
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


#Region "STAMPANJE"
    Shared Sub prn()
        If _lista.SelectedItems.Count > 0 Then
            selektuj_lab_dn(_lista.SelectedItems.Item(0).Text, Selekcija.po_sifri)

            If _lab_dnev And _trebovanje Then
                MsgBox("Možete štampati samo Dnevnik Laboratorijske izrade", MsgBoxStyle.OkOnly)

                'lab_dn_print()
                pripremi_dn_print()
                _raport = Imena.tabele.pr_lab_dn.ToString

                Dim mForm As New frmPrint
                mForm.Show()
            Else
                If _lab_dnev And Not _trebovanje Then
                    'lab_dn_print()
                    pripremi_dn_print()
                    _raport = Imena.tabele.pr_lab_dn.ToString

                    Dim mForm As New frmPrint
                    mForm.Show()
                End If

                If Not _lab_dnev And _trebovanje Then
                    'lab_dn_trebovanje_print()
                    pripremi_dn_trebovanje_print()
                    _raport = Imena.tabele.pr_lab_dn_trebovanje.ToString

                    Dim mForm1 As New frmPrint
                    mForm1.Show()
                End If
            End If
        Else
            MsgBox("Morate izbrati jedan zapis")
        End If
    End Sub

    Shared Sub pripremi_dn_print()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Dim xmlw As XmlTextWriter = Nothing
        Dim putanja As String = _win_temp_path ' My.Application.Info.DirectoryPath & "\izvestaji\app\"
        Dim fajl As String = putanja & "rptLab_dn.xml"

        Dim fi As FileInfo = New FileInfo(fajl)

        If fi.Exists Then fi.Delete()

        xmlw = New XmlTextWriter(fajl, Nothing)

        CN.Open()
        If CN.State = ConnectionState.Open Then

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "SELECT " & _
                                    "dbo.pr_lab_dn_stavka.lab_dn_st_rb, " & _
                                    "dbo.pr_lab_dn_stavka.lab_dn_st_sifra, " & _
                                    "dbo.pr_lab_dn_stavka.lab_dn_st_naziv, " & _
                                    "dbo.pr_lab_dn_stavka.lab_dn_st_jm, " & _
                                    "dbo.pr_lab_dn_stavka.lab_dn_st_kolicina, " & _
                                    "dbo.pr_lab_dn_stavka.lab_dn_st_cena, " & _
                                    "dbo.pr_lab_dn_stavka.lab_dn_st_vrednost, " & _
                                    "dbo.pr_lab_dn_stavka.lab_dn_st_rad_taksa " & _
                              "FROM dbo.pr_lab_dn_stavka " & _
                              "WHERE dbo.pr_lab_dn_stavka.id_lab_dn = " & _id_lab_dn
                DR = .ExecuteReader
            End With

            xmlw.Formatting = Formatting.Indented
            xmlw.WriteStartDocument()
            xmlw.WriteStartElement("lab_dn")

            Do While DR.Read

                xmlw.WriteStartElement("podatak")
                xmlw.WriteElementString("lab_dn_broj", _lab_dn_broj)
                xmlw.WriteElementString("lab_dn_datum_od", Today)
                xmlw.WriteElementString("lab_dn_datum", _lab_dn_datum)
                xmlw.WriteElementString("lab_dn_vred_preparata", Format(_lab_dn_vred_preparata, "#,##0.00"))
                xmlw.WriteElementString("lab_dn_vred_materijala", Format(_lab_dn_vred_materijala, "#,##0.00"))
                xmlw.WriteElementString("lab_dn_radna_taksa", Format(_lab_dn_radna_taksa, "#,##0.00"))
                xmlw.WriteElementString("lab_dn_zakljuen", _lab_dn_zakljuen)

                If Not IsDBNull(DR.Item("lab_dn_st_rb")) Then
                    xmlw.WriteElementString("st_rb", DR.Item("lab_dn_st_rb"))
                Else
                    xmlw.WriteElementString("st_rb", " ")
                End If

                If Not IsDBNull(DR.Item("lab_dn_st_sifra")) Then
                    xmlw.WriteElementString("st_sifra", DR.Item("lab_dn_st_sifra"))
                Else
                    xmlw.WriteElementString("st_sifra", " ")
                End If

                If Not IsDBNull(DR.Item("lab_dn_st_naziv")) Then
                    xmlw.WriteElementString("st_naziv", DR.Item("lab_dn_st_naziv"))
                Else
                    xmlw.WriteElementString("st_naziv", " ")
                End If

                If Not IsDBNull(DR.Item("lab_dn_st_kolicina")) Then
                    xmlw.WriteElementString("st_kolicina", Format(DR.Item("lab_dn_st_kolicina"), "#,##0.00000"))
                Else
                    xmlw.WriteElementString("st_kolicina", " ")
                End If

                If Not IsDBNull(DR.Item("lab_dn_st_cena")) Then
                    xmlw.WriteElementString("st_cena", DR.Item("lab_dn_st_cena"))
                Else
                    xmlw.WriteElementString("st_cena", " ")
                End If

                If Not IsDBNull(DR.Item("lab_dn_st_vrednost")) Then
                    xmlw.WriteElementString("st_vrednist", Format(DR.Item("lab_dn_st_vrednost"), "#,##0.00"))
                Else
                    xmlw.WriteElementString("st_vrednist", " ")
                End If

                If Not IsDBNull(DR.Item("lab_dn_st_rad_taksa")) Then
                    xmlw.WriteElementString("st_rad_taksa", DR.Item("lab_dn_st_rad_taksa"))
                Else
                    xmlw.WriteElementString("st_rad_taksa", " ")
                End If

                xmlw.WriteEndElement()
            Loop
            xmlw.WriteEndElement()
            xmlw.WriteEndDocument()
            xmlw.Flush()
            xmlw.Close()

            DR.Close()
            CM.Dispose()

        End If
        CN.Close()

    End Sub

    Shared Sub pripremi_dn_trebovanje_print()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Dim xmlw As XmlTextWriter = Nothing
        Dim putanja As String = _win_temp_path
        Dim fajl As String = putanja & "rptLab_dn_trebovanje.xml"

        Dim fi As FileInfo = New FileInfo(fajl)

        If fi.Exists Then fi.Delete()

        xmlw = New XmlTextWriter(fajl, Nothing)

        CN.Open()
        If CN.State = ConnectionState.Open Then

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "SELECT DISTINCT " & _
                                    "dbo.pr_lab_dn_stavka_utroseno.id_magacin, " & _
                                    "dbo.pr_lab_dn_stavka_utroseno.lab_dn_st_ut_sifra, " & _
                                    "dbo.pr_lab_dn_stavka_utroseno.lab_dn_st_ut_naziv, " & _
                                    "dbo.pr_lab_dn_stavka_utroseno.lab_dn_st_ut_kolicina, " & _
                                    "dbo.pr_lab_dn_stavka_utroseno.lab_dn_st_ut_kol_sklad, " & _
                                    "dbo.pr_lab_dn_stavka_utroseno.lab_dn_st_ut_cena, " & _
                                    "dbo.pr_lab_dn_stavka_utroseno.lab_dn_st_ut_vrednost, " & _
                                    "dbo.pr_lab_dn_stavka_utroseno.lab_dn_st_ut_rad_taksa " & _
                                "FROM dbo.pr_lab_dn_stavka_utroseno " & _
                                "WHERE dbo.pr_lab_dn_stavka_utroseno.id_lab_dn = " & _id_lab_dn
                DR = .ExecuteReader
            End With

            xmlw.Formatting = Formatting.Indented
            xmlw.WriteStartDocument()
            xmlw.WriteStartElement("dn_trebovanje")

            Do While DR.Read

                xmlw.WriteStartElement("podatak")
                xmlw.WriteElementString("lab_dn_broj", _lab_dn_broj)
                xmlw.WriteElementString("lab_dn_datum", _lab_dn_datum)
                xmlw.WriteElementString("lab_dn_vred_preparata", Format(_lab_dn_vred_preparata, "#,##0.00"))
                xmlw.WriteElementString("lab_dn_vred_materijala", Format(_lab_dn_vred_materijala, "#,##0.00"))
                xmlw.WriteElementString("lab_dn_radna_taksa", Format(_lab_dn_radna_taksa, "#,##0.00"))
                xmlw.WriteElementString("lab_dn_zakljuen", _lab_dn_zakljuen)

                selektuj_magacin(DR.Item("id_magacin"), Selekcija.po_id)
                xmlw.WriteElementString("magacin_naziv", _magacin_naziv)

                If Not IsDBNull(DR.Item("lab_dn_st_ut_sifra")) Then
                    xmlw.WriteElementString("st_sifra", DR.Item("lab_dn_st_ut_sifra"))
                Else
                    xmlw.WriteElementString("st_sifra", " ")
                End If

                If Not IsDBNull(DR.Item("lab_dn_st_ut_naziv")) Then
                    xmlw.WriteElementString("st_naziv", DR.Item("lab_dn_st_ut_naziv"))
                Else
                    xmlw.WriteElementString("st_naziv", " ")
                End If

                If Not IsDBNull(DR.Item("lab_dn_st_ut_kolicina")) Then
                    xmlw.WriteElementString("st_kolicina", DR.Item("lab_dn_st_ut_kolicina"))
                Else
                    xmlw.WriteElementString("st_kolicina", " ")
                End If

                If Not IsDBNull(DR.Item("lab_dn_st_ut_kol_sklad")) Then
                    xmlw.WriteElementString("st_kolicina_sklad", Format(DR.Item("lab_dn_st_ut_kol_sklad"), "#,##0.00000"))
                Else
                    xmlw.WriteElementString("st_kolicina_sklad", " ")
                End If

                If Not IsDBNull(DR.Item("lab_dn_st_ut_cena")) Then
                    xmlw.WriteElementString("st_cena", DR.Item("lab_dn_st_ut_cena"))
                Else
                    xmlw.WriteElementString("st_cena", " ")
                End If

                If Not IsDBNull(DR.Item("lab_dn_st_ut_vrednost")) Then
                    xmlw.WriteElementString("st_vrednist", Format(DR.Item("lab_dn_st_ut_vrednost"), "#,##0.00"))
                Else
                    xmlw.WriteElementString("st_vrednist", " ")
                End If

                If Not IsDBNull(DR.Item("lab_dn_st_ut_rad_taksa")) Then
                    xmlw.WriteElementString("st_rad_taksa", DR.Item("lab_dn_st_ut_rad_taksa"))
                Else
                    xmlw.WriteElementString("st_rad_taksa", " ")
                End If

                xmlw.WriteEndElement()
            Loop
            xmlw.WriteEndElement()
            xmlw.WriteEndDocument()
            xmlw.Flush()
            xmlw.Close()

            DR.Close()
            CM.Dispose()

        End If
        CN.Close()

    End Sub

    Shared Sub rekapitulacija()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim i As Integer
        Dim dat_od As Date
        Dim dat_do As Date

        Dim xmlw As XmlTextWriter = Nothing
        Dim putanja As String = _win_temp_path ' My.Application.Info.DirectoryPath & "\izvestaji\app\"
        Dim fajl As String = putanja & "rptLab_dn_rekapit.xml"

        Dim fi As FileInfo = New FileInfo(fajl)
        If fi.Exists Then fi.Delete()

        xmlw = New XmlTextWriter(fajl, Nothing)

        CN.Open()
        If _datumOD.Enabled And _datumDO.Enabled Then
            dat_od = _datumOD.Value.Date
            dat_do = _datumDO.Value.Date
        Else
            dat_od = "01/01/" & Now.Year
            dat_do = "31/12/" & Now.Year
        End If

        CM = New SqlCommand()
        With CM
            .Connection = CN
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM dbo.pr_lab_dn_head " & _
                           "WHERE dbo.pr_lab_dn_head.lab_dn_datum >= '" & _
                                dat_od.Date.Month.ToString & "/" & _
                                dat_od.Date.Day.ToString & "/" & _
                                dat_od.Date.Year.ToString & "'" & _
                           "AND dbo.pr_lab_dn_head.lab_dn_datum <= '" & _
                                dat_do.Date.Month.ToString & "/" & _
                                dat_do.Date.Day.ToString & "/" & _
                                dat_do.Date.Year.ToString & "'"
            DR = .ExecuteReader
        End With

        vr_suma_preparata = 0
        vr_suma_taksa = 0
        vr_suma_materijal = 0

        xmlw.Formatting = Formatting.Indented
        xmlw.WriteStartDocument()
        xmlw.WriteStartElement("lab_dn_rekapit")

        Do While DR.Read
            xmlw.WriteStartElement("podatak")
            xmlw.WriteElementString("lab_dn_broj", RTrim(DR.Item("lab_dn_broj")))
            xmlw.WriteElementString("lab_dn_datum_od", dat_od)
            xmlw.WriteElementString("lab_dn_datum", dat_do)
            xmlw.WriteElementString("lab_dn_vred_preparata", Format(DR.Item("lab_dn_vred_preparata"), "#,##0.00"))
            xmlw.WriteElementString("lab_dn_vred_materijala", Format(DR.Item("lab_dn_vred_materijala"), "#,##0.00"))
            xmlw.WriteElementString("lab_dn_radna_taksa", Format(DR.Item("lab_dn_radna_taksa"), "#,##0.00"))
            xmlw.WriteElementString("lab_dn_zakljuen", DR.Item("lab_dn_zakljuen"))

            rekapitulacija_stavka(DR.Item("id_lab_dn"))

            For i = 0 To n - 1
                xmlw.WriteStartElement("red")
                xmlw.WriteElementString("lab_dn_st_rb", st_rb(i))
                xmlw.WriteElementString("lab_dn_st_sifra", RTrim(st_sifra(i)))
                xmlw.WriteElementString("lab_dn_st_naziv", st_naziv(i))
                xmlw.WriteElementString("lab_dn_st_kolicina", Format(st_kol(i), "#,##0.00"))
                xmlw.WriteElementString("lab_dn_st_cena", Format(st_cena(i), "#,##0.00"))
                xmlw.WriteElementString("lab_dn_st_preparata", Format(st_preparata(i), "#,##0.00"))
                xmlw.WriteElementString("lab_dn_st_rad_taksa", Format(st_radna_taksa(i), "#,##0.00"))
                xmlw.WriteElementString("suma_preparata", Format(suma_preparata, "#,##0.00"))
                xmlw.WriteElementString("suma_taksa", Format(suma_taksa, "#,##0.00"))
                xmlw.WriteElementString("suma_materijal", Format(suma_materijal, "#,##0.00"))
                xmlw.WriteEndElement()
            Next

            'vr_suma_preparata = 0
            'vr_suma_taksa = 0
            'vr_suma_materijal = 0

            rekapit_print_st_utroseno(DR.Item("id_lab_dn"), DR.Item("id_magacin"))

            vr_suma_preparata += suma_preparata
            vr_suma_taksa += suma_taksa
            vr_suma_materijal += suma_materijal
            'vr_suma_materijal += s_suma_materijal
            xmlw.WriteElementString("vr_suma_preparata", Format(vr_suma_preparata, "#,##0.00"))
            xmlw.WriteElementString("vr_suma_taksa", Format(vr_suma_taksa, "#,##0.00"))
            xmlw.WriteElementString("vr_suma_materijal", Format(vr_suma_materijal, "#,##0.00"))

            xmlw.WriteEndElement()
        Loop


        xmlw.WriteEndElement()
        xmlw.WriteEndDocument()
        xmlw.Flush()
        xmlw.Close()

        DR.Close()
        CM.Dispose()

        _raport = Imena.tabele.pr_lab_dn_rekapitulacija.ToString
        Dim mForm As New frmPrint
        mForm.Show()

    End Sub

    Shared n As Integer
    Shared st_rb() As String = New String(50) {}
    Shared st_sifra() As String = New String(50) {}
    Shared st_naziv() As String = New String(50) {}
    Shared st_cena() As Single = New Single(50) {}
    Shared st_radna_taksa() As Single = New Single(50) {}
    Shared st_kol() As Single = New Single(50) {}
    Shared st_preparata() As Single = New Single(50) {}
    Shared suma_preparata As Single = 0
    Shared suma_taksa As Single = 0
    Shared suma_materijal As Single = 0
    Shared s_suma_materijal As Single = 0
    Shared vr_suma_preparata As Single = 0
    Shared vr_suma_taksa As Single = 0
    Shared vr_suma_materijal As Single = 0

    Shared Sub rekapitulacija_stavka(ByVal id_lab_dn)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        If CN.State = ConnectionState.Open Then

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "SELECT * " & _
                               "FROM dbo.pr_lab_dn_stavka " & _
                               "WHERE dbo.pr_lab_dn_stavka.id_lab_dn = " & id_lab_dn
                DR = .ExecuteReader
            End With
            n = 0
            suma_preparata = 0
            suma_taksa = 0
            Do While DR.Read
                If Not IsDBNull(DR.Item("id_lab_dn")) Then st_rb.SetValue(DR.Item("id_lab_dn").ToString, n)
                If Not IsDBNull(DR.Item("lab_dn_st_sifra")) Then st_sifra.SetValue(DR.Item("lab_dn_st_sifra"), n)
                If Not IsDBNull(DR.Item("lab_dn_st_naziv")) Then st_naziv.SetValue(DR.Item("lab_dn_st_naziv"), n)
                If Not IsDBNull(DR.Item("lab_dn_st_kolicina")) Then st_kol.SetValue(CSng(DR.Item("lab_dn_st_kolicina")), n)
                If Not IsDBNull(DR.Item("lab_dn_st_cena")) Then st_cena.SetValue(CSng(DR.Item("lab_dn_st_cena")), n)
                If Not IsDBNull(DR.Item("lab_dn_st_vrednost")) Then
                    st_preparata.SetValue(CSng(DR.Item("lab_dn_st_vrednost")), n)
                    suma_preparata += CSng(DR.Item("lab_dn_st_vrednost"))
                End If
                If Not IsDBNull(DR.Item("lab_dn_st_rad_taksa")) Then
                    st_radna_taksa.SetValue(CSng(DR.Item("lab_dn_st_rad_taksa")), n)
                    suma_taksa += CSng(DR.Item("lab_dn_st_rad_taksa"))
                End If
                'suma_materijal = suma_preparata - suma_taksa
                n += 1
            Loop
            DR.Close()
            CM.Dispose()
        End If
    End Sub

    Shared Sub rekapit_print_st_utroseno(ByVal id_lab_dn, ByVal id_magacin)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Dim xmlw As XmlTextWriter = Nothing
        Dim putanja As String = _win_temp_path ' My.Application.Info.DirectoryPath & "\izvestaji\app\"
        Dim fajl As String = putanja & "rptLab_dn_utroseno.xml"

        Dim fi As FileInfo = New FileInfo(fajl)
        If fi.Exists Then fi.Delete()

        suma_materijal = 0
        's_suma_materijal = 0
        xmlw = New XmlTextWriter(fajl, Nothing)

        CN.Open()
        If CN.State = ConnectionState.Open Then

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "SELECT * " & _
                               "FROM dbo.pr_lab_dn_stavka_utroseno " & _
                               "WHERE dbo.pr_lab_dn_stavka_utroseno.id_lab_dn = " & id_lab_dn
                DR = .ExecuteReader
            End With

            xmlw.Formatting = Formatting.Indented
            xmlw.WriteStartDocument()
            xmlw.WriteStartElement("lab_dn_utroseno")

            Do While DR.Read
                xmlw.WriteStartElement("podatak")
                selektuj_magacin(DR.Item("id_magacin"), Selekcija.po_id)
                xmlw.WriteElementString("ut_mag_sifra", RTrim(_magacin_sifra))
                xmlw.WriteElementString("ut_mag_naziv", RTrim(_magacin_naziv))
                xmlw.WriteElementString("ut_sifra", RTrim(DR.Item("lab_dn_st_ut_sifra")))
                xmlw.WriteElementString("ut_naziv", RTrim(DR.Item("lab_dn_st_ut_naziv")))
                xmlw.WriteElementString("ut_kolicina", Format(DR.Item("lab_dn_st_ut_kolicina"), "#,##0.00"))
                xmlw.WriteElementString("ut_kol_sklad", Format(DR.Item("lab_dn_st_ut_kol_sklad"), "#,##0.00"))
                xmlw.WriteElementString("ut_cena", Format(DR.Item("lab_dn_st_ut_cena"), "#,##0.00"))
                xmlw.WriteElementString("ut_vrednost", Format(DR.Item("lab_dn_st_ut_vrednost"), "#,##0.00"))
                suma_materijal += DR.Item("lab_dn_st_ut_vrednost")
                's_suma_materijal += DR.Item("lab_dn_st_ut_vrednost")
                xmlw.WriteElementString("suma_materijal", Format(suma_materijal, "#,##0.00"))
                xmlw.WriteElementString("ut_rad_taksa", Format(DR.Item("lab_dn_st_ut_rad_taksa"), "#,##0.00"))
                xmlw.WriteEndElement()
            Loop
            xmlw.WriteEndElement()
            xmlw.WriteEndDocument()
            xmlw.Flush()
            xmlw.Close()

            DR.Close()
            CM.Dispose()
        End If
    End Sub

    Shared Sub dnevnik()
        If _sve Then

        Else
            If _lista.SelectedItems.Count > 0 Then
                selektuj_lab_dn(RTrim(_lista.SelectedItems.Item(0).Text), Selekcija.po_sifri)

                If _lab_dnev And _trebovanje Then
                    MsgBox("Možete štampati samo Dnevnik Laboratorijske izrade", MsgBoxStyle.OkOnly)

                    'lab_dn_print()
                    pripremi_dn_print()
                    _raport = Imena.tabele.pr_lab_dn.ToString

                    Dim mForm As New frmPrint
                    mForm.Show()
                Else
                    If _lab_dnev And Not _trebovanje Then

                        'lab_dn_print()
                        pripremi_dn_print()
                        _raport = Imena.tabele.pr_lab_dn.ToString

                        Dim mForm As New frmPrint
                        mForm.Show()
                    End If

                    If Not _lab_dnev And _trebovanje Then
                        'lab_dn_trebovanje_print()
                        pripremi_dn_trebovanje_print()
                        _raport = Imena.tabele.pr_lab_dn_trebovanje.ToString

                        Dim mForm1 As New frmPrint
                        mForm1.Show()
                    End If
                End If

            End If
        End If

    End Sub

#End Region

End Class
