Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntNalog
    Private _pocetak As Boolean = True

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntFinansijsko_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        spSpliter.Dock = DockStyle.Fill
        'spSpliter.Panel1Collapsed = True
        _mSpliter = spSpliter
        '_mSpliter_zatvoren = True
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
            Dim poruka As String = "Da li ste sigurno da želite da izbrišete zapis sa sifrom " & _
                                    _lista.SelectedItems.Item(0).Text & "-" & _
                                    _lista.SelectedItems.Item(0).SubItems(1).Text & " ?"
            If MsgBox(poruka, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                _nal_broj = _lista.SelectedItems.Item(0).SubItems(1).Text
                _nal_vrsta = _lista.SelectedItems.Item(0).Text
                selektuj_nalog(RTrim(_nal_broj), _nal_vrsta, Selekcija.po_sifri)

                brisi_nalog_stavke()
                brisi_nalog()
            Else
                Exit Sub
            End If
        End If

        cntNalog_search.Lista()

    End Sub

    Shared Sub brisi_nalog()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "fn_nalog_head_delete"
                    .Parameters.AddWithValue("@id_nalog", _id_nalog)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox("Došlo je do greške prilikom izvršenja naredbe: " & ex.Message, MsgBoxStyle.OkOnly)
        Finally
            CN.Close()
        End Try
    End Sub
    Shared Sub brisi_nalog_stavke()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "fn_nalog_stavka_del_nalog"
                    .Parameters.AddWithValue("@id_nalog", _id_nalog)
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
        selektuj_kalkulaciju(bukmark, Selekcija.po_sifri)
        kalkulacija_print()
        _raport = Imena.tabele.rm_kalkulacija.ToString

        Dim mForm As New frmPrint
        mForm.Show()
    End Sub

End Class
