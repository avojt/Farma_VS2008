Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmPutniNalogUnos
    Private _pocetak As Boolean = True

    Private Sub frmPutniNalogUnos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        labOrganizacija.Text = "Farma d.o.o. - Niš"
        pocetak()
    End Sub

    Private Sub pocetak()
        txtAkontacija.Text = 0
        txtBroj.Text = Nadji_rb(Imena.tabele.fn_putni_nalog.ToString, 1)
        txtDnevnica.Text = 0
        txtMesto.Text = ""
        txtNaTeret.Text = ""
        txtPrevoz.Text = ""
        txtRadnik.Text = ""
        txtRadnoMesto.Text = ""
        txtZadatak.Text = ""

        dateDana.Value = Today
        dateZadrzavanje.Value = Today

        txtRadnik.Select()

    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Select Case e.ClickedItem.Name
            Case "tlbSnimi"
                snimi_radni_nalog()
                pocetak()
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
                .CommandText = "fn_putni_nalog_add"
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
