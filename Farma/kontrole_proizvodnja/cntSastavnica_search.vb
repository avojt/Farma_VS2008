Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO

Public Class cntSastavnica_search

    Shared upit As String = ""

    Shared upit_naziv As String = ""
    Shared upit_datum As String = ""
    Shared upit_zakljcene As String = ""

    Shared sql_start As String = "SELECT * FROM pr_sastavnica_head"

    Shared sql As String = ""
    Private _pocetak As Boolean = True
    Private _poABCedi As Boolean = False
    Private aktivan_chk As Boolean
    Shared _chSve As CheckBox

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntSastavnica_search_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'popuni_naziv()

        cmbNaziv.Enabled = False
        cmbNaziv.BackColor = Color.Lavender

        chkDatum.CheckState = CheckState.Unchecked
        chkNaziv.CheckState = CheckState.Unchecked

        rbtZaklj.Checked = False
        rbtNezaklj.Checked = False

        _lCount = labCount
        _chSve = chkSve

        _mCntSastavnica_search = Me

        mPanel.Dock = DockStyle.Fill
        'mPanel.Anchor = AnchorStyles.Left
        'mPanel.Anchor = AnchorStyles.Right

    End Sub

    Private Sub popuni_naziv()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbNaziv.Items.Clear()
        'cmbVrstaDok.Items.Add("")
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.pr_sastavnica_head"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbNaziv.Items.Add(DR.Item("sas_art_naziv"))
            Loop
            DR.Close()
        End If
        If cmbNaziv.Items.Count > 0 Then
            cmbNaziv.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Shared Sub filter()
        'On Error Resume Next
        If _chSve.Checked = True Then
            sql = sql_start
        Else
            upit = ""
            sql = sql_start

            If upit_naziv <> "" And upit <> "" Then
                upit = upit & " and " & upit_naziv
            Else
                If upit_naziv <> "" Then upit = upit_naziv
            End If

            If upit_datum <> "" And upit <> "" Then
                upit = upit & " and " & upit_datum
            Else
                If upit_datum <> "" Then upit = upit_datum
            End If

            If upit_zakljcene <> "" And upit <> "" Then
                upit = upit & " and " & upit_zakljcene
            Else
                If upit_zakljcene <> "" Then upit = upit_zakljcene
            End If

            If upit <> "" Then
                sql += " WHERE " & upit '& " ORDER BY " & _
                '        mRob_Dokument.KonamdTekst & "_head." & _dok_kolone(0) & "datum DESC, " & _
                '        mRob_Dokument.KonamdTekst & "_head." & _dok_kolone(0) & "broj DESC"
            End If

        End If

        Lista()

    End Sub

    Shared Sub Lista()

        _lista.Visible = True
        _lista.Items.Clear()
        '_lista.Columns.Clear()

        '_lista.Columns.Add("Broj", 55, HorizontalAlignment.Left)
        '_lista.Columns.Add("Datum", 80, HorizontalAlignment.Left)
        '_lista.Columns.Add("Mag.naziv", 250, HorizontalAlignment.Right)
        '_lista.Columns.Add("Stara vred.", 100, HorizontalAlignment.Right)
        '_lista.Columns.Add("Nova vred.", 100, HorizontalAlignment.Right)
        '_lista.Columns.Add("Razlika", 100, HorizontalAlignment.Right)

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
                    Dim podatak As New ListViewItem(CStr(DR.Item("sas_art_sifra")))
                    podatak.SubItems.Add(DR.Item("sas_art_naziv").ToString)
                    podatak.SubItems.Add(DR.Item("sas_datum_unosa"))
                    podatak.SubItems.Add(DR.Item("sas_datum_prestanka"))

                    _lista.Items.AddRange(New ListViewItem() {podatak})

                End While
                DR.Close()
            End If
            CM.Dispose()
            CN.Close()
        End If

        _lCount.Text = _lista.Items.Count.ToString + " zapisa"

    End Sub

    Shared Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function

    Private Sub rbtZaklj_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtZaklj.CheckedChanged
        Select Case rbtZaklj.Checked
            Case True
                rbtNezaklj.Checked = False
                upit_zakljcene = mRob_Dokument.KonamdTekst & "_head." & _dok_kolone(0) & "zakljucena = 1"
            Case False
                upit_zakljcene = ""
        End Select
        filter()
    End Sub

    Private Sub rbtNezaklj_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNezaklj.CheckedChanged
        Select Case rbtNezaklj.Checked
            Case True
                rbtZaklj.Checked = False
                upit_zakljcene = mRob_Dokument.KonamdTekst & "_head." & _dok_kolone(0) & "zakljucena = 0"
            Case False
                upit_zakljcene = ""
        End Select
        filter()
    End Sub

    Private Sub chkSve_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSve.CheckedChanged
        upit_naziv = ""
        upit_datum = ""
        Select Case chkSve.CheckState
            Case CheckState.Checked
                chkDatum.Checked = False
                chkNaziv.Checked = False

                chkDatum.Enabled = False
                chkNaziv.Enabled = False
                sql = sql_start + " ORDER BY dbo.pr_sastavnica_head.sas_art_naziv"
                filter()
                'Lista()
            Case CheckState.Unchecked
                chkDatum.Enabled = True
                chkNaziv.Enabled = True
                _lista.Items.Clear()
        End Select
        'proveri_formu()
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

    Private Sub chkNaziv_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNaziv.CheckedChanged
        Select Case chkNaziv.CheckState
            Case CheckState.Checked
                cmbNaziv.Enabled = True
                cmbNaziv.BackColor = Color.GhostWhite
                popuni_naziv()
            Case CheckState.Unchecked
                cmbNaziv.Enabled = False
                cmbNaziv.BackColor = Color.Lavender
                cmbNaziv.Items.Clear()
                upit_naziv = ""
                cmbNaziv.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub cmbNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbNaziv.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbNaziv.Text <> "" Then
                upit_naziv = "dbo.pr_sastavnica_head.sas_art_naziv = N'" & cmbNaziv.Text & "'"
            Else
                upit_naziv = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbNaziv_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbNaziv.SelectedIndexChanged
        If cmbNaziv.Text <> "" Then
            upit_naziv = "dbo.pr_sastavnica_head.sas_art_naziv = N'" & cmbNaziv.Text & "'"
        Else
            upit_naziv = ""
        End If
    End Sub

    Private Sub datDatum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datDatum.KeyPress
        If e.KeyChar = Chr(13) Then
            upit_datum = "dbo.pr_sastavnica_head.sas_datum_unosa = '" & _
                                 datDatum.Value.Month.ToString & "/" & _
                                 datDatum.Value.Day.ToString & "/" & _
                                 datDatum.Value.Year.ToString & "'"
            filter()
        End If
    End Sub
    Private Sub datDatum_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles datDatum.ValueChanged
        upit_datum = "pr_sastavnica_head.sas_datum_unosa = '" & _
                                datDatum.Value.Month.ToString & "/" & _
                                datDatum.Value.Day.ToString & "/" & _
                                datDatum.Value.Year.ToString & "'" '& _
        '" ##:##:##"

        'filter()
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
            selektuj_sastavnicu(RTrim(_lista.SelectedItems.Item(0).Text), Selekcija.po_sifri)

            'sastavnica_print()
            pripremi()
            _raport = Imena.tabele.pr_sastavnica.ToString

            Dim mForm As New frmPrint
            mForm.Show()
        Else
            MsgBox("Morate izbrati jedan zapis")
        End If
    End Sub

    Shared Sub pripremi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Dim xmlw As XmlTextWriter = Nothing
        Dim putanja As String = _win_temp_path ' My.Application.Info.DirectoryPath & "\izvestaji\app\"
        Dim fajl As String = putanja & "rptSastavnica.xml"

        Dim fi As FileInfo = New FileInfo(fajl)

        If fi.Exists Then fi.Delete()

        xmlw = New XmlTextWriter(fajl, Nothing)

        CN.Open()
        If CN.State = ConnectionState.Open Then

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.pr_sastavnica_stavka where dbo.pr_sastavnica_stavka.id_sastavnica = " & _id_sastavnica
                DR = .ExecuteReader
            End With

            xmlw.Formatting = Formatting.Indented
            xmlw.WriteStartDocument()
            xmlw.WriteStartElement("sastavnica")

            Do While DR.Read

                xmlw.WriteStartElement("podatak")
                xmlw.WriteElementString("sifra", _sas_art_sifra)
                xmlw.WriteElementString("naziv", _sas_art_naziv)
                xmlw.WriteElementString("cena", Format(_sas_art_cena, "#,##0.00"))
                xmlw.WriteElementString("jm_recept", _sas_jm_recept)
                xmlw.WriteElementString("kolicina", Format(_sas_kolicina, "#,##0.00000"))
                xmlw.WriteElementString("odobrena", da_ne(_sas_odobrena))
                xmlw.WriteElementString("datum_unosa", _sas_datum_unosa.Date)
                If _sas_datum_prestanka.Year.ToString = "1900" Then
                    xmlw.WriteElementString("datum_prestanka", "-")
                Else
                    xmlw.WriteElementString("datum_prestanka", _sas_datum_prestanka.Date)
                End If
                xmlw.WriteElementString("ukupno", Format(_sas_ukupno, "#,##0.00"))
                xmlw.WriteElementString("vrednost", Format(_sas_vrednost, "#,##0.00"))
                xmlw.WriteElementString("radna_taksa", Format(_sas_radna_taksa, "#,##0.00"))

                If Not IsDBNull(DR.Item("sas_st_rb")) Then
                    xmlw.WriteElementString("st_rb", DR.Item("sas_st_rb"))
                Else
                    xmlw.WriteElementString("st_rb", " ")
                End If

                If Not IsDBNull(DR.Item("sas_st_sifra")) Then
                    xmlw.WriteElementString("st_sifra", DR.Item("sas_st_sifra"))
                Else
                    xmlw.WriteElementString("st_sifra", " ")
                End If

                If Not IsDBNull(DR.Item("sas_st_naziv")) Then
                    xmlw.WriteElementString("st_naziv", DR.Item("sas_st_naziv"))
                Else
                    xmlw.WriteElementString("st_naziv", " ")
                End If

                If Not IsDBNull(DR.Item("sas_st_radna_taksa")) Then
                    xmlw.WriteElementString("st_radna_taksa", Format(DR.Item("sas_st_radna_taksa"), "#,##0.00"))
                Else
                    xmlw.WriteElementString("st_radna_taksa", " ")
                End If

                If Not IsDBNull(DR.Item("sas_st_jm")) Then
                    xmlw.WriteElementString("st_jm", DR.Item("sas_st_jm"))
                Else
                    xmlw.WriteElementString("st_jm", " ")
                End If

                If Not IsDBNull(DR.Item("sas_st_kolicina")) Then
                    xmlw.WriteElementString("st_kolicina", Format(DR.Item("sas_st_kolicina"), "#,##0.00000"))
                Else
                    xmlw.WriteElementString("st_kolicina", " ")
                End If

                If Not IsDBNull(DR.Item("sas_st_jm_skladistenja")) Then
                    xmlw.WriteElementString("st_jm_skladistenja", DR.Item("sas_st_jm_skladistenja"))
                Else
                    xmlw.WriteElementString("st_jm_skladistenja", " ")
                End If

                If Not IsDBNull(DR.Item("sas_st_kolicina_skladistenja")) Then
                    xmlw.WriteElementString("st_kolicina_skladistenja", Format(DR.Item("sas_st_kolicina_skladistenja"), "#,##0.00000"))
                Else
                    xmlw.WriteElementString("st_kolicina_skladistenja", " ")
                End If

                If Not IsDBNull(DR.Item("sas_st_cena")) Then
                    xmlw.WriteElementString("st_cena", Format(DR.Item("sas_st_cena"), "#,##0.00"))
                Else
                    xmlw.WriteElementString("st_cena", " ")
                End If

                If Not IsDBNull(DR.Item("sas_st_vrednist")) Then
                    xmlw.WriteElementString("st_vrednist", Format(DR.Item("sas_st_vrednist"), "#,##0.00"))
                Else
                    xmlw.WriteElementString("st_vrednist", " ")
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

#End Region


End Class
