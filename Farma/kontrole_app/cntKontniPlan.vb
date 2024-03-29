Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntKontniPlan
    Private _pocetak As Boolean = True

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntKontniPlan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

    Private Sub lvLista_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvLista.MouseDoubleClick
        '_nal_broj = _lista.SelectedItems.Item(0).SubItems(1).Text
        '_nal_vrsta = _lista.SelectedItems.Item(0).Text
        selektuj_konto(RTrim(bukmark), Selekcija.po_sifri)

        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntKontniPlan_edit
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_nalog + My.Resources.text_edit
        cntMeniFinansijsko.podesi_boje_linkova(_mPanKonta_meni)
        _mLinkKonta_edit.BackColor = Color.GhostWhite
        _mLinkKonta_edit.LinkColor = Color.MidnightBlue
    End Sub

    Shared Sub myUpdate()
        If bukmark = "" Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmenite", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            selektuj_konto(RTrim(bukmark), Selekcija.po_sifri)
            mdiMain.zatvori_kontrolu_desno()
            Dim myControl As New cntKontniPlan_edit
            myControl.Parent = mdiMain.splRadni.Panel2
            myControl.Dock = DockStyle.Fill
            myControl.Show()

            _labHead.Text = Ispisi_label() + My.Resources.text_konta + My.Resources.text_edit
            cntMeniFinansijsko.podesi_boje_linkova(_mPanKonta_meni)
            _mLinkKonta_edit.BackColor = Color.GhostWhite
            _mLinkKonta_edit.LinkColor = Color.MidnightBlue
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

                selektuj_konto(RTrim(bukmark), Selekcija.po_sifri)

                CN.Open()
                If CN.State = ConnectionState.Open Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "app_konto_delete"
                        .Parameters.AddWithValue("@id_konto", _id_konto)
                        .ExecuteScalar()
                    End With
                    CM.Dispose()
                End If
                cntKontniPlan_search.lista()
            Else
                Exit Sub
            End If
        End If
    End Sub

End Class
