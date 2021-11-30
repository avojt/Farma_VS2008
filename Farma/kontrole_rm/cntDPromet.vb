Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntDPromet

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntDPromet_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        spSpliter.Dock = DockStyle.Fill
        _mSpliter = spSpliter
        _lista = Me.lvLista
        _listaArt = Me.lvArtikl
    End Sub

    Shared bukmark As String = 0 'broj potvrde
    Private Sub lvLista_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLista.Click
        If lvLista.SelectedItems.Count > 0 Then
            bukmark = lvLista.SelectedItems.Item(0).Text
        End If
    End Sub

    Shared bukmark1 As String = 0
    Private Sub lvArtikl_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvArtikl.Click
        If lvArtikl.SelectedItems.Count > 0 Then
            bukmark1 = RTrim(lvArtikl.SelectedItems.Item(0).SubItems(4).Text)  'sifra artikla
        End If
    End Sub

    Shared Sub myDelete()
        If bukmark = "" Then
            MsgBox("Prvo morate izabrati stavku koji ћelite da izmenite", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            Dim poruka As String = My.Resources.text_brisanje & bukmark & " ?"
            If MsgBox(poruka, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                'selektuj_intDost_izlaz(bukmark, Selekcija.po_sifri)
                brisi_Dokument_stavke()
                brisi_Dokument_pdv()
                brisi_Dokument()
            Else
                Exit Sub
            End If
        End If

        'cntIntDostavUlaz_search.Lista()

    End Sub

    Shared Sub brisi_Dokument()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_knjizno_zaduzenje_izlaz_head_delete"
                    .Parameters.AddWithValue("@id_kz_iz", _id_kz_iz)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
            CN.Close()
        Catch ex As Exception
            Dim a As String = My.Resources.text_greska
            MsgBox(a & ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Shared Sub brisi_Dokument_stavke()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_knjizno_zaduzenje_izlaz_stavka_del_dokument"
                    .Parameters.AddWithValue("@id_kz_iz", _id_kz_iz)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox("Doљlo je do greške prilikom izvršenja naredbe: " & ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Shared Sub brisi_Dokument_pdv()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_knjizno_zaduzenje_izlaz_pdv_delete"
                    .Parameters.AddWithValue("@id_kz_iz", _id_kz_iz)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox("Došlo je do greške prilikom izvršenja naredbe: " & ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Shared Sub prn()
        'selektuj_kz_izlaz(bukmark, Selekcija.po_sifri)
        'kz_izlaz_print()
        _raport = Imena.tabele.rm_knjizno_zaduzenje_izlaz.ToString

        Dim mForm As New frmPrint
        mForm.Show()
    End Sub

End Class
