Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmKategorijeEdit

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmKategorijeEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()
    End Sub

    Private Sub pocetak()
        txtSifra.Text = _kategorija_sifra ' "00" & CStr(Nadji_rb(Imena.tabele.rm_kategorizacija.ToString))
        txtNaziv.Text = _kategorija_naziv
        txtNaziv.Focus()
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
                .CommandText = "rm_kategorizacija_update"
                .Parameters.AddWithValue("@id_kategorija", _id_kategorija)
                .Parameters.AddWithValue("@sifra", txtSifra.Text)
                .Parameters.AddWithValue("@naziv", txtNaziv.Text)
                .Parameters.AddWithValue("@prefix", txtPrefix.Text)
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