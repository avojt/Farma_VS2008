Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntNaselja
   Private _pocetak As Boolean = True

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub cntNaselja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        spSpliter.Dock = DockStyle.Fill
        _mSpliter = spSpliter
        _lista = Me.lvLista
        _lista.Dock = DockStyle.Fill
    End Sub

    Shared bukmark As String = 0 'broj potvrde
    Private Sub lvLista_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLista.Click
        If lvLista.SelectedItems.Count > 0 Then
            bukmark = RTrim(lvLista.SelectedItems.Item(0).Text)
        End If
    End Sub

    'Shared Sub myUpdate()
    '    If bukmark = "" Then
    '        MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
    '        Exit Sub
    '    Else
    '        Dim _naziv As String = _lista.SelectedItems.Item(0).Text
    '        Select Case _naselja
    '            Case Imena.naselja.grad
    '                selektuj_grad(RTrim(_naziv), Selekcija.po_nazivu)
    '            Case Imena.naselja.mesto
    '                selektuj_mesto(RTrim(_naziv), Selekcija.po_nazivu)
    '            Case Imena.naselja.opstina
    '                selektuj_opstine(RTrim(_naziv), Selekcija.po_nazivu)
    '        End Select
    '    End If
    'End Sub

    Shared Sub myDelete()
        If bukmark = "" Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            Dim poruka As String = "Da li ste sigurno da želite da izbrišete zapis sa nazivom " & bukmark & " ?"
            If MsgBox(poruka, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim _naziv As String = _lista.SelectedItems.Item(0).Text
                Dim CN As SqlConnection = New SqlConnection(CNNString)
                Dim CM As New SqlCommand

                Select Case _naselja
                    Case Imena.naselja.grad
                        selektuj_grad(RTrim(_naziv), Selekcija.po_nazivu)
                        CN.Open()
                        If CN.State = ConnectionState.Open Then
                            CM = New SqlCommand()
                            With CM
                                .Connection = CN
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "app_gradovi_delete"
                                .Parameters.AddWithValue("@id_grad", _id_grad)
                                .ExecuteScalar()
                            End With
                            CM.Dispose()
                        End If
                    Case Imena.naselja.opstina
                        selektuj_opstine(RTrim(_naziv), Selekcija.po_nazivu)
                        CN.Open()
                        If CN.State = ConnectionState.Open Then
                            CM = New SqlCommand()
                            With CM
                                .Connection = CN
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "app_opstine_delete"
                                .Parameters.AddWithValue("@id_opstine", _id_opstina)
                                .ExecuteScalar()
                            End With
                            CM.Dispose()
                        End If
                    Case Imena.naselja.mesto
                        selektuj_mesto(RTrim(_naziv), Selekcija.po_nazivu)
                        CN.Open()
                        If CN.State = ConnectionState.Open Then
                            CM = New SqlCommand()
                            With CM
                                .Connection = CN
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "app_mesta_delete"
                                .Parameters.AddWithValue("@id_mesta", _id_mesto)
                                .ExecuteScalar()
                            End With
                            CM.Dispose()
                        End If
                End Select
            Else
                Exit Sub
            End If
        End If
    End Sub

 

End Class
