Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntTrebovanje_search

    Private upit As String = ""
    Private upit_broj As String = ""
    Private upit_magacin As String = ""
    Private upit_datum As String = ""

    Shared sql_start As String = _
                "SELECT DISTINCT dbo.rm_trebovanje_head.treb_broj, dbo.rm_trebovanje_head.treb_datum, " & _
                    "dbo.rm_trebovanje_head.treb_vrednost, dbo.rm_trebovanje_head.treb_zakljuceno, " & _
                    "dbo.rm_magacin.magacin_sifra, dbo.rm_magacin.magacin_naziv " & _
                "FROM dbo.rm_trebovanje_head INNER JOIN " & _
                    "dbo.rm_magacin ON dbo.rm_trebovanje_head.id_magacin = dbo.rm_magacin.id_magacin"

    Shared sql As String = ""
    Private _pocetak As Boolean = True
    Private _poABCedi As Boolean = False
    Private aktivan_chk As Boolean

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntTrebovanje_search_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        popuni_Magacine()

        txtBroj.Enabled = False
        cmbMagacin.Enabled = False
        cmbMagacin.BackColor = Color.Lavender

        chkBroj.CheckState = CheckState.Unchecked
        chkDatum.CheckState = CheckState.Unchecked
        chkMagacin.CheckState = CheckState.Unchecked

        _lCount = labCount
        mPanel.Dock = DockStyle.Fill
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

    Private Sub filter()
        On Error Resume Next

        upit = ""
        sql = ""

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

        sql = sql_start
        If upit <> "" Then
            sql += " WHERE " & upit & " ORDER BY rm_trebovanje_head.treb_datum DESC," & _
                                                 " rm_trebovanje_head.treb_broj DESC"
        End If

        Lista()

    End Sub

    Shared Sub Lista()

        _lista.Visible = True
        _lista.Items.Clear()

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
                    Dim podatak As New ListViewItem(CStr(DR.Item("treb_broj")))

                    podatak.SubItems.Add(DR.Item("treb_datum"))
                    podatak.SubItems.Add(DR.Item("magacin_naziv").ToString)
                    podatak.SubItems.Add(DR.Item("treb_vrednost").ToString)

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

    Private Sub chkSve_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSve.CheckedChanged
        upit_broj = ""
        upit_magacin = ""
        upit_datum = ""
        Select Case chkSve.CheckState
            Case CheckState.Checked
                chkBroj.Checked = False
                chkDatum.Checked = False
                chkMagacin.Checked = False

                chkBroj.Enabled = False
                chkDatum.Enabled = False
                chkMagacin.Enabled = False
                sql = sql_start + " ORDER BY rm_trebovanje_head.treb_datum DESC"
                'filter()
                Lista()
            Case CheckState.Unchecked
                chkBroj.Enabled = True
                chkDatum.Enabled = True
                chkMagacin.Enabled = True
                _lista.Items.Clear()
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
                upit_broj = "rm_trebovanje_head.treb_broj = " & txtBroj.Text '& "%'"
            Else
                upit_broj = ""
            End If
            filter()
        End If
    End Sub
    Private Sub txtBroj_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBroj.TextChanged
        If txtBroj.Text <> "" Then
            upit_broj = "rm_trebovanje_head.treb_broj = " & txtBroj.Text '& "%'"
        Else
            upit_broj = ""
        End If
        'filter()
    End Sub

    Private Sub datDatum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datDatum.KeyPress
        If e.KeyChar = Chr(13) Then
            upit_datum = "rm_trebovanje_head.treb_datum = '" & _
                                 datDatum.Value.Month.ToString & "/" & _
                                 datDatum.Value.Day.ToString & "/" & _
                                 datDatum.Value.Year.ToString & "'"
            filter()
        End If
    End Sub
    Private Sub datDatum_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles datDatum.ValueChanged
        upit_datum = "rm_trebovanje_head.treb_datum = '" & _
                              datDatum.Value.Month.ToString & "/" & _
                        datDatum.Value.Day.ToString & "/" & _
                        datDatum.Value.Year.ToString & "'" '& _

        filter()
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

End Class
