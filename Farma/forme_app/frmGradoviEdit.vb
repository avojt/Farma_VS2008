Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmGradoviEdit

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmGradoviEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()
    End Sub

    Private Sub pocetak()
        txtNaziv.Text = _grad_naziv
        txtPorJed.Text = _grad_pj
        txtPttBroj.Text = _grad_ptt
        txtNaziv.Focus()
    End Sub

    Private Sub snimi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "app_gradovi_update"
                .Parameters.AddWithValue("@id_grad", _id_grad)
                .Parameters.AddWithValue("@grad_naziv", txtNaziv.Text)
                .Parameters.AddWithValue("@grad_ptt_br", txtPttBroj.Text)
                .Parameters.AddWithValue("@grad_porjed", txtPorJed.Text)
                .Parameters.AddWithValue("@grad_aktivan", 0)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Select Case e.ClickedItem.Name
            Case "tlbSnimi"
                snimi()
                'pocetak()
            Case "tlbEnd"
                Me.Close()
        End Select
    End Sub

    Private Sub txtNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNaziv.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPttBroj.Select()
        End If
    End Sub
    Private Sub txtPttBroj_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPttBroj.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPorJed.Select()
        End If
    End Sub
    Private Sub txtPorJed_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPorJed.KeyPress
        If e.KeyChar = Chr(13) Then
            txtNaziv.Select()
        End If
    End Sub

End Class