Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntMaticniPodaci
    Private _pocetak As Boolean = True
    Shared sql_start As String = _
                   "SELECT DISTINCT * FROM dbo.app_info_co"

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntMaticniPodaci_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tlbMain.Dock = DockStyle.Fill
        pocetak()
    End Sub

    Private Sub pocetak()

        popuni_grad()
        popuni_mesta()
        popuni_opstine()

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbMesto.Items.Clear()
        cmbMesto.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql_start
                DR = .ExecuteReader
            End With
            Do While DR.Read
                If Not IsDBNull(DR.Item("adresa")) Then txtAdresa.Text = DR.Item("adresa")
                If Not IsDBNull(DR.Item("grad")) Then cmbGrad.SelectedText = DR.Item("grad")
                If Not IsDBNull(DR.Item("opstina")) Then cmbMesto.SelectedText = DR.Item("opstina")
                If Not IsDBNull(DR.Item("opstina")) Then cmbOpstina.SelectedText = DR.Item("opstina")
                If Not IsDBNull(DR.Item("mail")) Then txtMail.Text = DR.Item("mail")
                If Not IsDBNull(DR.Item("maticni")) Then txtMaticni.Text = DR.Item("maticni")
                If Not IsDBNull(DR.Item("naziv")) Then txtNaziv.Text = DR.Item("naziv")
                If Not IsDBNull(DR.Item("pib")) Then txtPIB.Text = DR.Item("pib")
                If Not IsDBNull(DR.Item("registarski")) Then txtRegistarski.Text = DR.Item("registarski")
                If Not IsDBNull(DR.Item("sifra")) Then txtSifra.Text = DR.Item("sifra")
                If Not IsDBNull(DR.Item("sif_delatnosti")) Then txtSifraDel.Text = DR.Item("sif_delatnosti")
                If Not IsDBNull(DR.Item("web")) Then txtWeb.Text = DR.Item("web")
            Loop
            DR.Close()
        End If


    End Sub

    Private Sub popuni_mesta()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbMesto.Items.Clear()
        cmbMesto.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_mesta.* from dbo.app_mesta"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbMesto.Items.Add(DR.Item("mesto_naziv"))
            Loop
            DR.Close()
        End If
        If cmbMesto.Items.Count > 0 Then
            'selektuj_mesto(_partner_mesto, Selekcija.po_nazivu)
            cmbMesto.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_opstine()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbOpstina.Items.Clear()
        cmbOpstina.Items.Add("")

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
                cmbOpstina.Items.Add(DR.Item("opstine_naziv"))
            Loop
            DR.Close()
        End If
        If cmbOpstina.Items.Count > 0 Then
            'selektuj_mesto(_partner_mesto, Selekcija.po_nazivu)
            cmbOpstina.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_grad()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbGrad.Items.Clear()
        cmbGrad.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_gradovi.* from dbo.app_gradovi"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbGrad.Items.Add(DR.Item("grad_naziv"))
            Loop
            DR.Close()
        End If
        If cmbGrad.Items.Count > 0 Then
            cmbGrad.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub myUpdate()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "app_info_co_update"
                .Parameters.AddWithValue("@id_co", _id_partner)
                .Parameters.AddWithValue("@sifra", txtSifra.Text)
                .Parameters.AddWithValue("@naziv", txtNaziv.Text)
                .Parameters.AddWithValue("@adresa", txtAdresa.Text)
                .Parameters.AddWithValue("@opstina", cmbOpstina.Text)
                .Parameters.AddWithValue("@grad", cmbGrad.Text)
                .Parameters.AddWithValue("@pib", txtPIB.Text)
                .Parameters.AddWithValue("@sif_delatnosti", txtSifraDel.Text)
                .Parameters.AddWithValue("@maticni", txtMaticni.Text)
                .Parameters.AddWithValue("@registarski", txtRegistarski.Text)
                .Parameters.AddWithValue("@web", txtWeb.Text)
                .Parameters.AddWithValue("@mail", txtMail.Text)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Shared Sub myDelete()

        Dim poruka As String = "Da li ste sigurno da želite da izbrišete zapis sa sifrom " '& bukmark & " ?"
        If MsgBox(poruka, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Dim CN As SqlConnection = New SqlConnection(CNNString)
            Dim CM As New SqlCommand

            selektuj_partnera(_lista.SelectedItems.Item(0).Text, Selekcija.po_sifri)

            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "app_partneri_delete"
                    .Parameters.AddWithValue("@id_partner", _id_partner)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
        Else
            Exit Sub
        End If
        cntPartneri_sreach.Lista()
    End Sub

    Shared Sub prn()
        'selektuj_partnera(bukmark, Selekcija.po_sifri)
        'partner_print()
        _raport = Imena.tabele.app_partneri.ToString

        Dim mForm As New frmPrint
        mForm.Show()
    End Sub


    Private Sub btnSnimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSnimi.Click
        myUpdate()
    End Sub
End Class
