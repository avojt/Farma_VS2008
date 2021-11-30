Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO

Public Class cntJKL_search
    Private upit As String = ""
    Private upit_sifra As String = ""
    Private upit_naziv As String = ""
    Private sql_start As String = "SELECT * FROM dbo.app_jkl" 'order by jkl_sifra"
    Private sql As String = ""
    Private _pocetak As Boolean = True
    Private aktivan_chk As Boolean

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntJKL_search_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        txtSifra.Enabled = False
        txtSifra.BackColor = Color.Lavender
        txtNaziv.Enabled = False
        txtNaziv.BackColor = Color.Lavender
    End Sub

    Private Sub filter()
        On Error Resume Next
      
        upit = ""
        sql = ""
        If upit_naziv <> "" And upit <> "" Then
            upit = upit & " and " & upit_naziv
        Else
            If upit_naziv <> "" Then upit = upit_naziv
        End If

        If upit_sifra <> "" And upit <> "" Then
            upit = upit & " and " & upit_sifra
        Else
            If upit_sifra <> "" Then upit = upit_sifra
        End If

        sql = sql_start
        If upit <> "" Then
            sql += " WHERE " & upit & " order by jkl_sifra"

        End If
        'If chkABC.Checked Then
        '    sql += " ORDER BY app_partneri.partner_naziv" 'ASC" DESC" 'ascending
        'Else
        '    sql += " ORDER BY app_partneri.partner_sifra"
        'End If

        Lista()

    End Sub

    Private Sub Lista()

        _lista.Visible = True
        _lista.Items.Clear()

        If sql <> "" Then
            Dim CN As SqlConnection = New SqlConnection(CNNString)
            Dim CM As New SqlCommand
            Dim DR As SqlDataReader

            Try
                CN.Open()
                If CN.State = ConnectionState.Open Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.Text
                        .CommandText = sql
                        DR = .ExecuteReader
                    End With

                    While DR.Read
                        Dim podatak As New ListViewItem(CStr(DR.Item("jkl_sifra")))
                        podatak.SubItems.Add(DR.Item("jkl_naziv").ToString)
                        podatak.SubItems.Add(DR.Item("jkl_pozitivna_lista").ToString)

                        _lista.Items.AddRange(New ListViewItem() {podatak})
                    End While
                    DR.Close()
                End If
                CM.Dispose()
                CN.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly)
            End Try
        End If

        labCount.Text = _lista.Items.Count.ToString + " zapisa"

    End Sub

    Private Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function

    Private Sub chkNaziv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNaziv.CheckedChanged
        Select Case chkNaziv.CheckState
            Case CheckState.Checked
                txtNaziv.Enabled = True
                txtNaziv.BackColor = Color.GhostWhite
                aktivan_chk = True
            Case CheckState.Unchecked
                txtNaziv.Enabled = False
                txtNaziv.BackColor = Color.Lavender
                aktivan_chk = False
                txtNaziv.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub txtNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNaziv.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtNaziv.Text <> "" Then
                upit_naziv = "jkl_naziv LIKE N'%" & txtNaziv.Text & "%'"
            Else
                upit_naziv = ""
            End If
            filter()
        End If
    End Sub
    Private Sub txtNaziv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNaziv.TextChanged
        If txtNaziv.Text <> "" Then
            upit_naziv = "jkl_naziv LIKE N'%" & txtNaziv.Text & "%'"
        Else
            upit_naziv = ""
        End If
        'filter()
    End Sub

    Private Sub chkSifra_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSifra.CheckedChanged
        Select Case chkSifra.CheckState
            Case CheckState.Checked
                txtSifra.Enabled = True
                txtSifra.BackColor = Color.GhostWhite
                aktivan_chk = True
            Case CheckState.Unchecked
                txtSifra.Enabled = False
                txtSifra.BackColor = Color.Lavender
                aktivan_chk = False
                txtSifra.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub txtSifra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSifra.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtSifra.Text <> "" Then
                upit_sifra = "jkl_sifra LIKE N'" & txtSifra.Text & "%'"
            Else
                upit_sifra = ""
            End If
            filter()
        End If
    End Sub
    Private Sub txtSifra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSifra.TextChanged
        If txtSifra.Text <> "" Then
            upit_sifra = "jkl_sifra LIKE N'" & txtSifra.Text & "%'"
        Else
            upit_sifra = ""
        End If
    End Sub

    Private Sub proveri_formu()
        Dim mChack As Object

        aktivan_chk = False
        For Each mChack In mPanel2.Controls
            If mChack.name = "chkNaziv" Or mChack.name = "chkSifra" Then
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
