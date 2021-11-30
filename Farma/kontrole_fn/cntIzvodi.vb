Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient
Imports System.Globalization
Imports Microsoft.VisualBasic

Public Class cntIzvodi

    Private upit As String = ""
    Private upit_broj_izvod As String = ""
    Private upit_datum_izvod As String = ""

    Private sql_izvod As String = "SELECT * FROM dbo.fn_izvodi_head"

    Private _pocetak As Boolean = True

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntIzvodi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        listaIzvod()
        _pocetak = False
    End Sub

    Private Sub filter_Izvod()

        On Error Resume Next
        If Not _pocetak Then
            If upit_broj_izvod <> "" Then upit = upit_broj_izvod

            If upit_datum_izvod <> "" And upit <> "" Then
                upit = upit & " and " & upit_datum_izvod
            Else
                If upit_datum_izvod <> "" Then upit = upit_datum_izvod
            End If

            If upit <> "" Then
                sql_izvod = "SELECT * FROM dbo.fn_izvodi_head where dbo.fn_izvodi_head." & upit
            End If

            listaIzvod()

        End If
        upit = ""
        sql_izvod = "SELECT * FROM dbo.fn_izvodi_head"
    End Sub
    Private Sub listaIzvod()

        lvIzvodi.Items.Clear()

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim _stanje As Single = 0

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql_izvod
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            While DR.Read
                Dim podatak As New ListViewItem(CStr(DR.Item("broj")), 0)
                podatak.SubItems.Add(DR.Item("datum"))
                podatak.SubItems.Add(DR.Item("svega_duguje"))
                podatak.SubItems.Add(DR.Item("svega_potrazuje"))

                podatak.SubItems.Add(_stanje + DR.Item("svega_potrazuje") - DR.Item("svega_duguje"))

                lvIzvodi.Items.AddRange(New ListViewItem() {podatak}) ', item2, item3})
            End While
            DR.Close()
        End If

        CM.Dispose()
        CN.Close()

        _lista = lvIzvodi
    End Sub

    Private Sub txtBrojIzvod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBrojIzvod.TextChanged
        If Not _pocetak Then
            If txtBrojIzvod.Text <> "" Then
                upit_broj_izvod = "broj = '" & txtBrojIzvod.Text & "'"
            Else
                upit_broj_izvod = ""
            End If
            filter_Izvod()
        End If
    End Sub
    Private Sub dateIzvod_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateIzvod.ValueChanged
        If Not _pocetak Then
            upit_datum_izvod = "datum = '" & dateIzvod.Value.Month.ToString & _
                                            "/" & dateIzvod.Value.Day.ToString & _
                                            "/" & dateIzvod.Value.Year.ToString & "'" '.ToString("d") & "#'"
            filter_Izvod()
        End If
    End Sub

    Shared Sub myUpdate()
        If bukmark = 0 Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            selektuj_izvod(bukmark)
            Dim myChild As New frmIzvodiEdit
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
                selektuj_izvod(bukmark)
                brisi_izvod_stavke(_id_izvod)
                brisi_izvod(bukmark)
            End If
        End If
    End Sub

    Shared bukmark As Integer = 0
    Private Sub lvIzvodi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvIzvodi.Click
        bukmark = lvIzvodi.SelectedItems.Item(0).Text
        _id = bukmark
        _tab = Imena.tabele.fn_izvodi
    End Sub

    Shared Sub brisi_izvod(ByVal _bukmark)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "fn_izvod_head_delete"
                    .Parameters.AddWithValue("@broj", _bukmark)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox("Došlo je do greške prilikom izvršenja naredbe: " & ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Shared Sub brisi_izvod_stavke(ByVal _bukmark)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "fn_izvodi_stavke_del_izvod"
                    .Parameters.AddWithValue("@id_izvod", _bukmark)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox("Došlo je do greške prilikom izvršenja naredbe: " & ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub picRefreshIzvod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRefreshIzvod.Click
        sql_izvod = "SELECT * FROM dbo.fn_izvodi_head"
        listaIzvod()
    End Sub
    Private Sub picRefreshIzvod_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRefreshIzvod.MouseHover
        picRefreshIzvod.Image = Global.Farma.My.Resources.Resources.reload
        picRefreshIzvod.Cursor = Cursors.Default
    End Sub
    Private Sub picRefreshIzvod_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRefreshIzvod.MouseLeave
        picRefreshIzvod.Image = Global.Farma.My.Resources.Resources.reload1
        picRefreshIzvod.Cursor = Cursors.Default
    End Sub

End Class
