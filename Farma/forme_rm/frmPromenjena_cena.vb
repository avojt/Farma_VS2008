Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmPromenjena_cena

    Private opcija As String = ""
    Private sifra As String = ""
    Private naziv As String = ""
    Private jm As String = ""
    Private nabavna As Single = _artikl_nabavna
    Private rabat As Integer = _artikl_rabat
    Private pdv As Integer = 0
    Private cena As Single = _artikl_cena
    Private euro As Single = 0
    Private kolicina As Single = 0 '_roba_kolicina
    Private min_kolicina As Single = 0
    Private kategorija As String = ""
    Private nova_sifra As String = ""

    Private Sub frmPromenjena_cena_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()
    End Sub

    Private Sub frmPromenjena_cena_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.BringToFront()
    End Sub

    Private Sub pocetak()
        chkNivelacija.Checked = False
        chkNoviArtikl.Checked = False

    End Sub

    Private Sub chkNivelacija_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNivelacija.CheckedChanged
        Select Case chkNivelacija.CheckState
            Case CheckState.Checked
                chkNoviArtikl.Checked = False
                opcija = "nivelacija"
            Case CheckState.Unchecked
                chkNoviArtikl.Checked = True
                opcija = "artikl"
        End Select
    End Sub

    Private Sub chkNoviArtikl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNoviArtikl.CheckedChanged
        Select Case chkNoviArtikl.CheckState
            Case CheckState.Checked
                chkNivelacija.Checked = False
                opcija = "artikl"
            Case CheckState.Unchecked
                chkNivelacija.Checked = True
                opcija = "nivelacija"
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If chkNivelacija.CheckState = CheckState.Unchecked And chkNoviArtikl.CheckState = CheckState.Unchecked Then
            MsgBox("Morate izabrati jednu od ponudjFarmah opcija", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            Select Case opcija.ToString
                Case "artikl"
                    nadji_artikl(_artikl_sifra)
                    nova_sifra = RTrim(_artikl_sifra) & InputBox("Izaberite nastavak za novu šifru")
                    snimi()
                Case "nivelacija"

            End Select
        End If
        Me.Dispose()
    End Sub

    Private Sub nadji_artikl(ByVal _sifra As String)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli where sifra = '" & _sifra & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                'sifra = DR.Item("sifra")
                naziv = DR.Item("naziv")
                jm = DR.Item("jm")
                'nabavna = DR.Item("nabavna")
                'rabat = DR.Item("rabat")
                pdv = DR.Item("pdv")
                'cena = DR.Item("cena")
                If Not IsDBNull(DR.Item("euro")) Then euro = DR.Item("euro")
                pdv = DR.Item("pdv")
                min_kolicina = DR.Item("min_kolicina")
                kategorija = DR.Item("kategorija")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
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
                .CommandText = "rm_artikli_add"
                .Parameters.AddWithValue("@sifra", nova_sifra)
                .Parameters.AddWithValue("@naziv", naziv)
                .Parameters.AddWithValue("@jm", jm)
                .Parameters.AddWithValue("@nabavna", nabavna)
                .Parameters.AddWithValue("@rabat", rabat)
                .Parameters.AddWithValue("@pdv", pdv)
                .Parameters.AddWithValue("@cena", cena)
                .Parameters.AddWithValue("@euro", euro)
                .Parameters.AddWithValue("@kolicina", 0)
                .Parameters.AddWithValue("@min_kolicina", min_kolicina)
                .Parameters.AddWithValue("@kategorija", kategorija)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
        _novi_artikl = True
        _novi_artikl_sifra = nova_sifra
    End Sub

    Private Sub btnOdustani_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOdustani.Click

        Me.Dispose()
    End Sub
End Class