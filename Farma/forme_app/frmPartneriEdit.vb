Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmPartneriEdit


    Private Sub frmPartneriEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()
    End Sub

    Private Sub pocetak()
        txtAdresa.Text = _partner_adresa
        txtMaticni.Text = _partner_maticni
        txtMesto.Text = _partner_mesto
        txtNaziv.Text = _partner_naziv
        txtPib.Text = _partner_pib
        txtRegistarski.Text = _partner_registarski
        txtSifra.Text = _partner_sifra
        txtZR.Text = _partner_zr
        chkDobavljac.Checked = _partner_dobavljac
        chkKupac.Checked = _partner_kupac
        chkProizvodjac.Checked = _partner_proizvodjac
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
                .CommandText = "app_partneri_update"
                .Parameters.AddWithValue("@id_partner", _id_partner)
                .Parameters.AddWithValue("@partner_sifra", txtSifra.Text)
                .Parameters.AddWithValue("@partner_naziv", txtNaziv.Text)
                .Parameters.AddWithValue("@partner_adresa", txtAdresa.Text)
                .Parameters.AddWithValue("@partner_mesto", txtMesto.Text)
                .Parameters.AddWithValue("@partner_pib", txtPib.Text)
                .Parameters.AddWithValue("@partner_maticni", txtMaticni.Text)
                .Parameters.AddWithValue("@partner_registarski", txtRegistarski.Text)
                .Parameters.AddWithValue("@partner_zr", txtZR.Text)
                .Parameters.AddWithValue("@partner_proizvodjac", chkProizvodjac.Checked)
                .Parameters.AddWithValue("@partner_dobavljac", chkDobavljac.Checked)
                .Parameters.AddWithValue("@partner_kupac", chkKupac.Checked)
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

End Class