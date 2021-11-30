Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntKategorije

    Private sql As String = "SELECT * FROM dbo.app_artikl_kategorizacija"

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lista()
    End Sub

    Private Sub lista()

        lvKategorije.Items.Clear()

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql
                DR = .ExecuteReader
            End With

            While DR.Read
                Dim podatak As New ListViewItem(CStr(DR.Item("kategorija_sifra")), 0)
                podatak.SubItems.Add(DR.Item("kategorija_naziv"))

                lvKategorije.Items.AddRange(New ListViewItem() {podatak}) ', item2, item3})
            End While
            DR.Close()
        End If

        CM.Dispose()
        CN.Close()

        _lista = lvKategorije
    End Sub

    Private Sub picRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRefresh.Click
        sql = "SELECT * FROM dbo.app_artikl_kategorizacija"
        lista()
    End Sub

    Private Sub picRefresh_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRefresh.MouseHover
        picRefresh.Image = Global.Farma.My.Resources.Resources.reload
        picRefresh.Cursor = Cursors.Hand
    End Sub

    Private Sub picRefresh_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRefresh.MouseLeave
        picRefresh.Image = Global.Farma.My.Resources.Resources.reload1
        picRefresh.Cursor = Cursors.Default
    End Sub

    Shared Sub myUpdate()
        If bukmark = 0 Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            selektuj_kategoriju(bukmark)
            Dim myChild As New frmKategorijeEdit
            myChild.Show()
        End If
    End Sub

    Shared Sub myDelete()
        If bukmark = 0 Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            Dim poruka As String = "Da li ste sigurno da želite da izbrišete zapis sa sifrom " & bukmark & " ?"
            If MsgBox(poruka, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim CN As SqlConnection = New SqlConnection(CNNString)
                Dim CM As New SqlCommand

                CN.Open()
                If CN.State = ConnectionState.Open Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "rm_kategorizacija_delete"
                        .Parameters.AddWithValue("@sifra", _lista.SelectedItems.Item(0).Text)
                        .ExecuteScalar()
                    End With
                    CM.Dispose()
                End If
            Else
                Exit Sub
            End If
        End If
    End Sub

    Shared bukmark As String
    Private Sub lvKategorije_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvKategorije.Click
        bukmark = lvKategorije.SelectedItems.Item(0).Text
    End Sub
End Class
