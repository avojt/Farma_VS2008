Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntOJ
    Private _pocetak As Boolean = True

    Private Sub cntOJ_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        spSpliter.Dock = DockStyle.Fill
        _mSpliter = spSpliter
        _lista = Me.lvLista
    End Sub

    Shared bukmark As String = 0 'broj potvrde
    Private Sub lvLista_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLista.Click
        If lvLista.SelectedItems.Count > 0 Then
            bukmark = RTrim(lvLista.SelectedItems.Item(0).Text)
        End If
    End Sub

    Private Sub lvLista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvLista.SelectedIndexChanged

    End Sub
    Shared Sub myUpdate()
        If bukmark = "" Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            selektuj_oj(RTrim(bukmark), Selekcija.po_sifri)
            Dim myChild As New cntOJ_edit
            myChild.Show()
        End If
    End Sub

    Shared Sub myDelete()
        If _lista.SelectedItems.Item(0).Text = "" Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            Dim poruka As String = "Da li ste sigurno da želite da izbrišete zapis sa sifrom " & RTrim(_lista.SelectedItems.Item(0).Text) & " ?"
            If MsgBox(poruka, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim CN As SqlConnection = New SqlConnection(CNNString)
                Dim CM As New SqlCommand

                selektuj_oj(RTrim(_lista.SelectedItems.Item(0).Text), Selekcija.po_sifri)

                CN.Open()
                If CN.State = ConnectionState.Open Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "app_organizacione_jedinice_delete"
                        .Parameters.AddWithValue("@id_orgjed", _id_oj)
                        .ExecuteScalar()
                    End With
                    CM.Dispose()
                End If
            Else
                Exit Sub
            End If
        End If

        cntOJ_sreach.lista()

    End Sub



End Class
