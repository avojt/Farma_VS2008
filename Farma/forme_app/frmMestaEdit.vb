Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmMestaEdit

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmMestaEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()
    End Sub

    Private Sub pocetak()
        txtNaziv.Text = _mesto_naziv
        txtPorJed.Text = _mesto_pj
        txtPttBroj.Text = _mesto_ptt
        txtNaziv.Focus()
        popuni_opstine()
    End Sub

    Private Sub popuni_opstine()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbOpstine.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_opstine.* from dbo.app_opstine"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbOpstine.Items.Add(DR.Item("opstine_naziv"))
            Loop
            DR.Close()
        End If
        If cmbOpstine.Items.Count > 0 Then
            selektuj_opstine(_id_opstina, Selekcija.po_id)
            cmbOpstine.SelectedText = _opstina_naziv
        End If
        CM.Dispose()
        CN.Close()
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
                .CommandText = "app_mesta_update"
                .Parameters.AddWithValue("@id_mesta", _id_mesto)
                selektuj_opstine(cmbOpstine.Text, Selekcija.po_nazivu)
                .Parameters.AddWithValue("@id_opstine", _id_opstina)
                .Parameters.AddWithValue("@mesto_naziv", txtNaziv.Text)
                .Parameters.AddWithValue("@mesto_ptt_br", txtPttBroj.Text)
                .Parameters.AddWithValue("@mesto_porjed", txtPorJed.Text)
                .Parameters.AddWithValue("@mesto_aktivan", _mesto_aktivan)
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
            cmbOpstine.Select()
        End If
    End Sub

    Private Sub cmbOpstine_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOpstine.DropDownClosed
        txtPttBroj.Select()
    End Sub

    Private Sub cmbOpstine_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbOpstine.KeyPress
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