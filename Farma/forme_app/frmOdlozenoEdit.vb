Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmOdlozenoEdit

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pocetak()
    End Sub

    Private Sub pocetak()
        txtSifra.Text = _odlozeno_sifra
        txtOpis.Text = _odlozeno_opis
        txtOdlozeno.Text = _odlozeno_odlozeno
        txtOpis.Focus()
    End Sub

    Private Sub snimi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        'Dim DR As SqlDataReader
        'Dim DA As SqlDataAdapter = New SqlDataAdapter(CM)

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "app_odlozeno_update"
                .Parameters.AddWithValue("@id_odlozeno", _id_odlozeno)
                .Parameters.AddWithValue("@sifra", txtSifra.Text)
                .Parameters.AddWithValue("@opis", txtOpis.Text)
                .Parameters.AddWithValue("@odlozeno", txtOdlozeno.Text)
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
                pocetak()
            Case "tlbEnd"
                Me.Close()
        End Select
    End Sub

End Class