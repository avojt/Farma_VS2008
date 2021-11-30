Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntSeme
    Private upit As String = ""
    Private upit_sifra As String = ""
    Private upit_naziv As String = ""
    Private sql As String = "SELECT * FROM dbo.fn_sema_za_knjizenje_head order by sifra"
    Private _pocetak As Boolean = True

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntSeme_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lista()
    End Sub

    Private Sub txtSifra_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSifra.TextChanged
        If txtSifra.Text <> "" Then
            upit_sifra = "dbo.fn_sema_za_knjizenje_head.sifra like '" & txtSifra.Text & "%'"
        Else
            upit_sifra = ""
        End If
        filter()
    End Sub

    Private Sub txtNaziv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNaziv.TextChanged
        If txtNaziv.Text <> "" Then
            upit_naziv = "dbo.fn_sema_za_knjizenje_head.naziv like '" & txtNaziv.Text & "%'"
        Else
            upit_naziv = ""
        End If
        filter()
    End Sub

    Private Sub filter()

        On Error Resume Next
        If Not _pocetak Then
            If upit_sifra <> "" Then upit = upit_sifra

            If upit_naziv <> "" And upit <> "" Then
                upit = upit & " and " & upit_naziv
            Else
                If upit_naziv <> "" Then upit = upit_naziv
            End If

            If upit <> "" Then
                sql = "SELECT * FROM dbo.fn_sema_za_knjizenje_head where " & upit & " order by sifra"
            End If

            lista()

        End If
        upit = ""
        sql = "SELECT * FROM dbo.fn_sema_za_knjizenje_head order by sifra"
    End Sub

    Private Sub lista()

        lvSeme.Items.Clear()

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
                Dim podatak As New ListViewItem(CStr(DR.Item("sifra")))
                podatak.SubItems.Add(DR.Item("naziv"))

                lvSeme.Items.AddRange(New ListViewItem() {podatak})
            End While
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()

        _lista = lvSeme

    End Sub

    Private Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function

    Shared bukmark As String = "" 'broj potvrde
    Private Sub lvSeme_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvSeme.Click
        If lvSeme.SelectedItems.Count > 0 Then
            bukmark = lvSeme.SelectedItems.Item(0).Text
        End If
    End Sub

    Shared Sub myUpdate()
        If bukmark = "" Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            selektuj_semu(bukmark)
            Dim myChild As New frmSemaEdit
            myChild.Show()
        End If
    End Sub

    Shared Sub myDelete()
        If bukmark = 0 Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            Dim poruka As String = "Da li ste sigurno da želite da izbrišete zapis sa sifrom " & RTrim(bukmark) & " ?"
            If MsgBox(poruka, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim CN As SqlConnection = New SqlConnection(CNNString)
                Dim CM As New SqlCommand

                selektuj_semu(bukmark)

                CN.Open()
                If CN.State = ConnectionState.Open Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "fn_sema_za_knjizenje_stavka_delete_semu"
                        .Parameters.AddWithValue("@id_sema", _id_sema)
                        .ExecuteScalar()
                    End With
                    CM.Dispose()
                End If

                If CN.State = ConnectionState.Open Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "fn_sema_za_knjizenje_head_delete"
                        .Parameters.AddWithValue("@id_sema", _id_sema)
                        .ExecuteScalar()
                    End With
                    CM.Dispose()
                End If
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub picRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRefresh.Click
        sql = "SELECT * FROM dbo.fn_sema_za_knjizenje_head order by sifra"
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



End Class
