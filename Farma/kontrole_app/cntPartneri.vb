Option Strict Off
Option Explicit On

Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class cntPartneri
    Private _pocetak As Boolean = True

    Private Sub cniPartneri_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        spSpliter.Dock = DockStyle.Fill
        _mSpliter = spSpliter
        _lista = Me.lvLista
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
        End If

        cntPartneri_sreach.Lista()
    End Sub

End Class

