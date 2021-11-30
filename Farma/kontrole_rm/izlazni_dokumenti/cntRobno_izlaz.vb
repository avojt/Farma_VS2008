Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntRobno_izlaz

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntRobno_izlaz_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        spSpliter.Dock = DockStyle.Fill
        _mSpliter = spSpliter
        _lista = Me.lvLista

    End Sub

    Shared bukmark As String = 0 'broj potvrde
    Private Sub lvLista_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLista.Click
        If lvLista.SelectedItems.Count > 0 Then
            bukmark = lvLista.SelectedItems.Item(0).Text
            If _sve Then
                _id_dokument = _lista.SelectedItems.Item(0).SubItems(7).Text
            Else
                _id_dokument = _lista.SelectedItems.Item(0).SubItems(6).Text
            End If
        End If
    End Sub
    Private Sub lvLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLista.DoubleClick
        If lvLista.SelectedItems.Count > 0 Then
            '_id_dokument = _lista.SelectedItems.Item(0).SubItems(6).Text ' _lista.SelectedItems.Item(0).SubItems(1).Text
            'selektuj_dokument_izl(RTrim(_id_dokument), Selekcija.po_sifri)
            If _sve Then
                _id_dokument = _lista.SelectedItems.Item(0).SubItems(7).Text
            Else
                _id_dokument = _lista.SelectedItems.Item(0).SubItems(6).Text
            End If
            selektuj_dokument_izl(_id_dokument, Selekcija.po_id)

            mdiMain.zatvori_kontrolu_desno()
            Dim myControl As New cntRobno_izlaz_edit
            myControl.Parent = mdiMain.splRadni.Panel2
            myControl.Dock = DockStyle.Fill
            myControl.Show()

            _labHead.Text = Ispisi_label() + My.Resources.text_robno + My.Resources.text_edit
            cntMeniRobno.podesi_boje_linkova(_mPanIzlazRobe_meni)
            _mLinkIzlazRobe_edit.BackColor = Color.GhostWhite
            _mLinkIzlazRobe_edit.LinkColor = Color.MidnightBlue
            cntMeniRobno.disable_linkove(_mPanIzlazRobe_meni)
            cntMeniRobno.disable_buttons(_mTableButtons)
        End If
    End Sub

    Shared Sub myDelete()
        If bukmark = "" Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            Dim poruka As String = "Da li ste sigurno da želite da izbrišete zapis sa sifrom " & bukmark & " ?"
            If MsgBox(poruka, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                selektuj_dokument_izl(bukmark, Selekcija.po_sifri)
                brisi_Dokument_stavke()
                brisi_Dokument_pdv()
                brisi_Dokument()
            Else
                Exit Sub
            End If
        End If

        cntRobno_izlaz_search.Lista()

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
                    .CommandText = "rm_izlazni_dokument_head_update"
                    .Parameters.AddWithValue("@id_dokument", _id_dokument)
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
                    .CommandText = "rm_izlazni_dokument_stavka_del_dok"
                    .Parameters.AddWithValue("@id_dokument", _id_dokument)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox("Došlo je do greške prilikom izvršenja naredbe: " & ex.Message, MsgBoxStyle.OkOnly)
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
                    .CommandText = "rm_izlazni_dokument_pdv_delete"
                    .Parameters.AddWithValue("@id_dokument", _id_dokument)
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
        selektuj_dokument_izl(bukmark, Selekcija.po_sifri)
        dokument_izl_print()
        _raport = Imena.tabele.rm_izlazni_dokument.ToString

        Dim mForm As New frmPrint
        mForm.Show()
    End Sub


End Class
