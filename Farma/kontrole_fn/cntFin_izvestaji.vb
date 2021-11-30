Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntFin_izvestaji
    Private _pocetak As Boolean = True


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntAnalitika_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        spSpliter.Dock = DockStyle.Fill
        _mSpliter = spSpliter
        _lista = Me.lvLista

        _pocetak = False
    End Sub

    Shared bukmark As String = 0 'vrsta
    Private Sub lvLista_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLista.Click
        If lvLista.SelectedItems.Count > 0 Then
            bukmark = RTrim(lvLista.SelectedItems.Item(0).Text)
        End If
    End Sub
    'Private Sub lvLista_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvLista.MouseDoubleClick
    '    _nal_broj = _lista.SelectedItems.Item(0).SubItems(1).Text
    '    _nal_vrsta = _lista.SelectedItems.Item(0).Text
    '    selektuj_nalog(RTrim(_nal_broj), Selekcija.po_sifri, _nal_vrsta)

    '    mdiMain.zatvori_kontrolu_desno()
    '    Dim myControl As New cntNalog_edit
    '    myControl.Parent = mdiMain.splRadni.Panel2
    '    myControl.Dock = DockStyle.Fill
    '    myControl.Show()

    '    _labHead.Text = Ispisi_label() + My.Resources.text_nalog + My.Resources.text_edit
    '    cntMeniFinansijsko.podesi_boje_linkova(_mPanNalog_meni)
    '    _mLinkNalog_edit.BackColor = Color.GhostWhite
    '    _mLinkNalog_edit.LinkColor = Color.MidnightBlue

    'End Sub

    Shared Sub prn()
        If _lista.SelectedItems.Count = 0 Then
            Dim i As Integer = 0
            For i = 0 To _lista.Items.Count - 1
                _nal_broj = _lista.Items(0).SubItems(1).Text
                _nal_vrsta = _lista.Items(0).Text
                selektuj_nalog(RTrim(_nal_broj), Selekcija.po_sifri, RTrim(_nal_vrsta))
                nalog_print()
                _nal_print_all = True
            Next
        Else
            _nal_broj = _lista.SelectedItems.Item(0).SubItems(1).Text
            _nal_vrsta = _lista.SelectedItems.Item(0).Text
            selektuj_nalog(RTrim(_nal_broj), Selekcija.po_sifri, _nal_vrsta)
            nalog_print()
        End If

        _raport = Imena.tabele.fn_nalog.ToString

        Dim mForm As New frmPrint
        mForm.Show()
    End Sub

End Class
