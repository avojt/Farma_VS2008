Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntNalog_search

    Private upit As String = ""
    Private upit_broj As String = ""
    Private upit_vrsta As String = ""
    Private upit_datum As String = ""
    Private upit_zakljcene As String = ""

    Shared sql_start As String = _
                "SELECT * FROM fn_nalog_head"

    Shared sql As String = ""
    Private _pocetak As Boolean = True
    Private aktivan_chk As Boolean

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntNalog_search_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        popuni_vrste()

        txtBroj.Enabled = False
        cmbVrsta.Enabled = False
        cmbVrsta.BackColor = Color.Lavender
        datDatum.Enabled = False

        chkBroj.CheckState = CheckState.Unchecked
        chkDatum.CheckState = CheckState.Unchecked
        chkVrsta.CheckState = CheckState.Unchecked

        rbtZaklj.Checked = False
        rbtNezaklj.Checked = False

        _lCount = labCount

        mPanel.Dock = DockStyle.Fill
    End Sub

    Private Sub popuni_vrste()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbVrsta.Items.Clear()
        cmbVrsta.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.fn_nalog_vrste.* from dbo.fn_nalog_vrste"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbVrsta.Items.Add(DR.Item("vrsta_oznaka"))
            Loop
            DR.Close()
        End If
        If cmbVrsta.Items.Count > 0 Then
            cmbVrsta.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub filter()
        On Error Resume Next

        upit = ""
        sql = ""

        If upit_vrsta <> "" And upit <> "" Then
            upit = upit & " and " & upit_vrsta
        Else
            If upit_vrsta <> "" Then upit = upit_vrsta
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

        If upit_zakljcene <> "" And upit <> "" Then
            upit = upit & " and " & upit_zakljcene
        Else
            If upit_zakljcene <> "" Then upit = upit_zakljcene
        End If

        If upit <> "" Then
            sql = sql_start & " WHERE " & upit
        Else
            sql = sql_start
        End If

        Lista()

    End Sub

    Shared Sub Lista()

        _lista.Visible = True
        _lista.Items.Clear()

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
                Dim podatak As New ListViewItem(CStr(DR.Item("nal_vrsta")))

                podatak.SubItems.Add(DR.Item("nal_broj"))
                podatak.SubItems.Add(DR.Item("nal_datum"))
                podatak.SubItems.Add(Format(DR.Item("nal_duguje"), "##,##0.00").ToString)
                podatak.SubItems.Add(Format(DR.Item("nal_potrazuje"), "##,##0.00").ToString)
                podatak.SubItems.Add(Format((CSng(DR.Item("nal_duguje")) - CSng(DR.Item("nal_potrazuje"))), "##,##0.00").ToString)
                podatak.SubItems.Add(da_ne(DR.Item("nal_proknjizen").ToString))
                If Not IsDBNull(DR.Item("nal_napomena")) And DR.Item("nal_napomena").ToString <> "" Then
                    podatak.SubItems.Add(DR.Item("nal_napomena").ToString)
                Else
                    podatak.SubItems.Add("Aktivan")
                End If

                _lista.Items.AddRange(New ListViewItem() {podatak})

            End While
            DR.Close()
        End If

        CM.Dispose()
        CN.Close()

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
                upit_zakljcene = "fn_nalog_head.nal_proknjizen = 1"
            Case False
                upit_zakljcene = ""
        End Select
        filter()
    End Sub

    Private Sub rbtNezaklj_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNezaklj.CheckedChanged
        Select Case rbtNezaklj.Checked
            Case True
                rbtZaklj.Checked = False
                upit_zakljcene = "fn_nalog_head.nal_proknjizen = 0"
            Case False
                upit_zakljcene = ""
        End Select
        filter()
    End Sub

    Private Sub chkSve_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSve.CheckedChanged
        upit_broj = ""
        upit_datum = ""
        upit_vrsta = ""
        Select Case chkSve.CheckState
            Case CheckState.Checked
                chkBroj.Checked = False
                chkDatum.Checked = False
                chkVrsta.Checked = False

                chkBroj.Enabled = False
                chkDatum.Enabled = False
                chkVrsta.Enabled = False

                sql = sql_start '+ " ORDER BY rm_kalkulacija_head.kalk_datum DESC"
                filter()
            Case CheckState.Unchecked
                chkBroj.Enabled = True
                chkDatum.Enabled = True
                chkVrsta.Enabled = True
                _lista.Items.Clear()
        End Select
    End Sub

    Private Sub chkBroj_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkBroj.CheckedChanged
        Select Case chkBroj.CheckState
            Case CheckState.Checked
                txtBroj.Enabled = True
                txtBroj.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                txtBroj.Enabled = False
                txtBroj.BackColor = Color.Lavender
                upit_broj = ""
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

    Private Sub chkVrsta_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkVrsta.CheckedChanged
        Select Case chkVrsta.CheckState
            Case CheckState.Checked
                cmbVrsta.Enabled = True
                cmbVrsta.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbVrsta.Enabled = False
                cmbVrsta.BackColor = Color.Lavender
                cmbVrsta.Text = ""
                upit_vrsta = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub cmbVrsta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbVrsta.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbVrsta.Text <> "" Then
                upit_vrsta = "dbo.fn_nalog_head.nal_vrsta = N'" & cmbVrsta.Text & "'"
            Else
                upit_vrsta = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbVrsta_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbVrsta.SelectedIndexChanged
        If cmbVrsta.Text <> "" Then
            upit_vrsta = "dbo.fn_nalog_head.nal_vrsta = N'" & cmbVrsta.Text & "'"
        Else
            upit_vrsta = ""
        End If
    End Sub

    Private Sub txtBroj_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBroj.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtBroj.Text <> "" Then
                upit_broj = "fn_nalog_head.nal_broj = " & txtBroj.Text '& "%'"
            Else
                upit_broj = ""
            End If
            filter()
        End If
    End Sub
    Private Sub txtBroj_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBroj.TextChanged
        If txtBroj.Text <> "" Then
            upit_broj = "fn_nalog_head.nal_broj = " & txtBroj.Text '& "%'"
        Else
            upit_broj = ""
        End If
        'filter()
    End Sub

    Private Sub datDatum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datDatum.KeyPress
        If e.KeyChar = Chr(13) Then
            upit_datum = "fn_nalog_head.nal_datum = '" & _
                                 datDatum.Value.Month.ToString & "/" & _
                                 datDatum.Value.Day.ToString & "/" & _
                                 datDatum.Value.Year.ToString & "'"
            filter()
        End If
    End Sub
    Private Sub datDatum_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles datDatum.ValueChanged
        upit_datum = "fn_nalog_head.nal_datum = '" & _
                              datDatum.Value.Month.ToString & "/" & _
                        datDatum.Value.Day.ToString & "/" & _
                        datDatum.Value.Year.ToString & "'" '& _
        '" ##:##:##"

        'filter()
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

End Class
