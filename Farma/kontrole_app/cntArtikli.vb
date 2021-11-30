Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntArtikli
    
    Private _pocetak As Boolean = True

    Private Sub cntArtikli_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
    Private Sub lvLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLista.DoubleClick
        If lvLista.SelectedItems.Count > 0 Then
            _artikl_sifra = _lista.SelectedItems.Item(0).SubItems(0).Text
            selektuj_artikl(RTrim(_artikl_sifra), Selekcija.po_sifri)

            mdiMain.zatvori_kontrolu_desno()
            Dim myControl As New cntArtiklEdit
            myControl.Parent = mdiMain.splRadni.Panel2
            myControl.Dock = DockStyle.Fill
            myControl.Show()

            _labHead.Text = Ispisi_label() + " : artikli" + " - ažuriranje"
            cntMeniArtikli.podesi_boje_linkova(_mPanArtikli_meni)
            _mLinkArtikli_edit.BackColor = Color.GhostWhite
            _mLinkArtikli_edit.LinkColor = Color.MidnightBlue
            cntMeniArtikli.disable_linkove(_mPanArtikli_meni)
            'cntMeniArtikli.disable_buttons(_mTableButtons)
        End If
    End Sub

    Shared Sub myDelete()
        If bukmark = "" Then
            MsgBox("Prvo morate izabrati stavku koji želite da izbrišete", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            Dim poruka As String = "Da li ste sigurno da želite da izbrišete zapis sa šifrom " & bukmark & " ?"
            If MsgBox(poruka, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim CN As SqlConnection = New SqlConnection(CNNString)
                Dim CM As New SqlCommand

                selektuj_artikl(RTrim(bukmark), Selekcija.po_sifri)

                CN.Open()
                If CN.State = ConnectionState.Open Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "rm_artikli_delete"
                        .Parameters.AddWithValue("@id_artikl", _id_artikl)
                        .ExecuteScalar()
                    End With
                    CM.Dispose()
                End If
            Else
                Exit Sub
            End If
        End If

        cntArtikli_search.Lista()

    End Sub

End Class
