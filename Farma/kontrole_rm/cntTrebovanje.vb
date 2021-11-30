Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntTrebovanje

    Private _pocetak As Boolean = True

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub cntTrebovanje_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        spSpliter.Dock = DockStyle.Fill
        _mSpliter = spSpliter
        _lista = Me.lvLista

        _pocetak = False
    End Sub

    Shared bukmark As String = 0 'broj potvrde
    Private Sub lvLista_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLista.Click
        If lvLista.SelectedItems.Count > 0 Then
            bukmark = lvLista.SelectedItems.Item(0).Text
        End If
    End Sub

    Shared Sub myDelete()
        If bukmark = "" Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            Dim poruka As String = "Da li ste sigurno da želite da izbrišete zapis sa sifrom " & bukmark & " ?"
            If MsgBox(poruka, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                selektuj_trebovanje(bukmark, Selekcija.po_sifri)
                brisi_Dokument_stavke()
                brisi_Dokument()
            Else
                Exit Sub
            End If
        End If

        cntTrebovanje_search.Lista()

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
                    .CommandText = "rm_trebovanje_head_delete"
                    .Parameters.AddWithValue("@id_trebovanje", _id_trebovanje)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox("Došlo je do greške prilikom izvršenja naredbe: " & ex.Message, MsgBoxStyle.OkOnly)
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
                    .CommandText = "rm_trebovanje_stavka_del_dok"
                    .Parameters.AddWithValue("@id_trebovanje", _id_trebovanje)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox("Došlo je do greške prilikom izvršenja naredbe: " & ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
    'Shared Sub brisi_Dokument_pdv()
    '    Dim CN As SqlConnection = New SqlConnection(CNNString)
    '    Dim CM As New SqlCommand

    '    Try
    '        CN.Open()
    '        If CN.State = ConnectionState.Open Then
    '            CM = New SqlCommand()
    '            With CM
    '                .Connection = CN
    '                .CommandType = CommandType.StoredProcedure
    '                .CommandText = "rm_knjizno_odobrenje_u_pdv_delete"
    '                .Parameters.AddWithValue("@id_knjod_ulaz", _id_knjod_ulaz)
    '                .ExecuteScalar()
    '            End With
    '            CM.Dispose()
    '        End If
    '        CN.Close()
    '    Catch ex As Exception
    '        MsgBox("Došlo je do greške prilikom izvršenja naredbe: " & ex.Message, MsgBoxStyle.OkOnly)
    '    End Try
    'End Sub

    Shared Sub prn()
        selektuj_trebovanje(bukmark, Selekcija.po_sifri)
        trebovanje_print()
        _raport = Imena.tabele.rm_trebovanje.ToString
        Dim mForm As New frmPrint
        mForm.Show()
    End Sub

End Class
