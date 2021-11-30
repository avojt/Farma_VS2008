Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmOjEdit
    Private _pocetak As Boolean = True
    Private sql_opstina As String = "SELECT dbo.app_opstine.* FROM dbo.app_opstine"
    Private sql_mesta As String = "SELECT dbo.app_mesta.* FROM dbo.app_mesta"

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmOjEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()
        popuni_gradove()
        popuni_opstine()
        popuni_vrstu()
    End Sub

    Private Sub pocetak()

        txtAdreas.Text = _oj_adresa
        txtNaziv.Text = _oj_naziv
        txtSifra.Text = Nadji_rb(Imena.tabele.app_organizacione_jedinice.ToString, 1)
        txtNaziv.Select()

        _pocetak = False

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
                .CommandText = "app_organizacione_jedinice_update"
                .Parameters.AddWithValue("@oj_sifra", txtSifra)
                .Parameters.AddWithValue("@oj_naziv", txtNaziv.Text)
                .Parameters.AddWithValue("@oj_adresa", txtAdreas.Text)
                selektuj_grad(cmbGrad.Text, Selekcija.po_nazivu)
                .Parameters.AddWithValue("@id_mesto", _id_grad)
                selektuj_opstine(cmbOpstina.Text, Selekcija.po_nazivu)
                .Parameters.AddWithValue("@id_opstine", _id_opstina)
                .Parameters.AddWithValue("@id_vrsta", vrstaOJ_id(cmbVrsta.Text))
                .Parameters.AddWithValue("@oj_strukturna", chkStrukturna.CheckState)
                .Parameters.AddWithValue("@aktivan", _oj_aktivan)
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

    Private Sub popuni_gradove()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbGrad.Items.Clear()
        cmbGrad.Items.Add(" ")

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
            selektuj_grad(_id_grad, Selekcija.po_id)
            cmbGrad.SelectedText = _grad_naziv
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_opstine()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbOpstina.Items.Clear()
        cmbOpstina.Items.Add(" ")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql_opstina
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbOpstina.Items.Add(DR.Item("opstine_naziv"))
            Loop
            DR.Close()
        End If
        If cmbOpstina.Items.Count = 1 Then
            sql_opstina = "SELECT dbo.app_opstine.* FROM dbo.app_opstine"
            popuni_opstine()
        End If
        If cmbOpstina.Items.Count > 0 Then
            selektuj_opstine(_id_opstina, Selekcija.po_id)
            cmbOpstina.SelectedText = _opstina_naziv
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_mesta()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbMesto.Items.Clear()
        cmbMesto.Items.Add(" ")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql_mesta
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbMesto.Items.Add(DR.Item("mesto_naziv"))
            Loop
            DR.Close()
        End If
        If cmbMesto.Items.Count = 1 Then
            sql_mesta = "SELECT dbo.app_mesta.* FROM dbo.app_mesta"
            popuni_mesta()
        End If
        If cmbMesto.Items.Count > 0 Then
            cmbMesto.SelectedText = mesto_naziv(_id_mesto)
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_vrstu()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbVrsta.Items.Clear()
        cmbVrsta.Items.Add(" ")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_vrsta_oj.* from dbo.app_vrsta_oj"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbVrsta.Items.Add(DR.Item("vrsta_oj_naziv"))
            Loop
            DR.Close()
        End If
        If cmbVrsta.Items.Count > 0 Then
            cmbVrsta.SelectedText = vrstaOJ_naziv(_id_vrsta)
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub txtNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNaziv.KeyPress
        If e.KeyChar = Chr(13) Then
            txtAdreas.Select()
        End If
    End Sub

    Private Sub txtAdreas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdreas.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbGrad.Select()
        End If
    End Sub

    Private Sub cmbGrad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbGrad.SelectedIndexChanged
        selektuj_grad(cmbGrad.Text, Selekcija.po_nazivu)
        If _id_grad <> 0 Then
            sql_opstina = "SELECT dbo.app_opstine.* FROM dbo.app_opstine where dbo.app_opstine.id_grad = " & _id_grad
            popuni_opstine()
        End If
    End Sub

    Private Sub cmbGrad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbGrad.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbOpstina.Select()
        End If
    End Sub

    Private Sub cmbGrad_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbGrad.DropDownClosed
        cmbOpstina.Select()
    End Sub

    Private Sub cmbOpstina_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOpstina.DropDownClosed
        cmbMesto.Select()
    End Sub

    Private Sub cmbOpstina_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbOpstina.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbMesto.Select()
        End If
    End Sub

    Private Sub cmbMesto_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMesto.DropDown
        cmbVrsta.Select()
    End Sub

    Private Sub cmbMesto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMesto.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbVrsta.Select()
        End If
    End Sub

    Private Sub cmbVrsta_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbVrsta.DropDownClosed
        chkStrukturna.Select()
    End Sub

    Private Sub cmbVrsta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbVrsta.KeyPress
        If e.KeyChar = Chr(13) Then
            chkStrukturna.Select()
        End If
    End Sub

End Class