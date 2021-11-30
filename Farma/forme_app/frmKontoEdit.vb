Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmKontoEdit

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmKontoEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()
    End Sub

    Private Sub pocetak()
        txtKonto.Text = _konto
        txtNaziv.Text = _konto_naziv
        chkDevizni.Checked = _konto_devizni
        chkDozvoljeno.Checked = _konto_dozvoljeno
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
                .CommandText = "fn_konta_update"
                .Parameters.AddWithValue("@id_konto", _id_konto)
                .Parameters.AddWithValue("@konto", txtKonto.Text)
                .Parameters.AddWithValue("@naziv", txtNaziv.Text)
                .Parameters.AddWithValue("@dozvoljeno_knjizenje", chkDozvoljeno.Checked)
                .Parameters.AddWithValue("@devizni", chkDevizni.Checked)
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