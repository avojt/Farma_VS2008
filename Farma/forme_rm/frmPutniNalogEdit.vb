Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmPutniNalogEdit

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmPutniNalogEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        labOrganizacija.Text = "Farma d.o.o. - Niš"
        pocetak()
    End Sub

    Private Sub pocetak()
        txtAkontacija.Text = _pnalog_akontacija
        txtBroj.Text = _pnalog_broj
        txtDnevnica.Text = _pnalog_dnevnica
        txtMesto.Text = _pnalog_mesto
        txtNaTeret.Text = _pnalog_nateret
        txtPrevoz.Text = _pnalog_prevoz
        txtRadnik.Text = _pnalog_radnik
        txtRadnoMesto.Text = _pnalog_radno_mesto
        txtZadatak.Text = _pnalog_zadatak

        dateDana.Value = _pnalog_dana
        dateZadrzavanje.Value = _pnalog_zadrzavanje

        txtRadnik.Select()

    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Select Case e.ClickedItem.Name
            Case "tlbSnimi"
                snimi_radni_nalog()
                'pocetak()
            Case "tlbIzdaj"

            Case "tlbEnd"
                Me.Dispose()
        End Select
    End Sub

    Private Sub snimi_radni_nalog()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        'Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "fn_putni_nalog_update"
                .Parameters.AddWithValue("@id_pnalog", _id_pnalog)
                .Parameters.AddWithValue("@broj", txtBroj.Text)
                .Parameters.AddWithValue("@naziv_organizacije", labOrganizacija.Text)
                .Parameters.AddWithValue("@radnik", txtRadnik.Text)
                .Parameters.AddWithValue("@radno_mesto", txtRadnoMesto.Text)
                .Parameters.AddWithValue("@dana", dateDana.Value.Date)
                .Parameters.AddWithValue("@mesto", txtMesto.Text)
                .Parameters.AddWithValue("@zadatak", txtZadatak.Text)
                .Parameters.AddWithValue("@prevoz", txtPrevoz.Text)
                .Parameters.AddWithValue("@dnevnica", CDec(txtDnevnica.Text))
                .Parameters.AddWithValue("@zadrzavanje", dateZadrzavanje.Value.Date)
                .Parameters.AddWithValue("@nateret", txtNaTeret.Text)
                .Parameters.AddWithValue("@akontacija", CDec(txtAkontacija.Text))
                .Parameters.AddWithValue("@racun", 0)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
    End Sub

End Class