Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntJKL
    Private upit As String = ""
    Private upit_sifra As String = ""
    Private upit_naziv As String = ""
    Private sql As String = ""
    Private sql_start As String = "SELECT * FROM dbo.app_jkl order by jkl_sifra"
    Private _pocetak As Boolean = True

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntJKL_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        spSpliter.SplitterDistance = 175
        spSpliter.Panel1Collapsed = True
        _mSpliter = spSpliter
        _mSpliter_zatvoren = True
        _lista = lvJkl

        sql = sql_start
        _pocetak = False

        'lista()

    End Sub

    Shared Sub myUpdate()
        If bukmark = "" Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            'selektuj_jkl(RTrim(bukmark))
            'Dim myChild As New frmJklEdit
            'myChild.Show()
        End If
    End Sub

    Shared Sub myDelete()
        If bukmark = 0 Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            Dim poruka As String = "Da li ste sigurno da želite da izbrišete zapis sa sifrom " & bukmark & " ?"
            If MsgBox(poruka, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
               
                selektuj_jkl(bukmark, Selekcija.po_sifri)

                Dim CN As SqlConnection = New SqlConnection(CNNString)
                Dim CM As New SqlCommand

                CN.Open()
                If CN.State = ConnectionState.Open Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "app_jkl_delete"
                        .Parameters.AddWithValue("@id_jkl", _id_jkl)
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
    Private Sub lvJkl_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvJkl.Click
        bukmark = lvJkl.SelectedItems.Item(0).Text
        _id = bukmark
    End Sub

    Private Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function


End Class
