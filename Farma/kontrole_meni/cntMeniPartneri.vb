Option Strict Off
Option Explicit On

Public Class cntMeniPartneri
    Private _visina As Integer = 144

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntMeniPartneri_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()
        podesi_boje()

        If Not _povratak Then
            _korak_nazad.SetValue(Me.Name.ToString, zadnji_zapis(_korak_nazad))
            _korak_labHead.SetValue(Me.Name.ToString, zadnji_zapis(_korak_labHead))
        End If
        _labHead.Text = Ispisi_label()
        _povratak = False
    End Sub

    Private Sub pocetak()
        podesi_kontrole()
        podesi_visinu()

    End Sub

    Private Sub podesi_kontrole()

        _mPanPartneri_kontejn = panPartneri_Kontejner
        _mPanPartneri_meni = panPartneri_meni
        _mLinkPartneri_search = linkPartneri_search

        _mPanOJ_kontejn = panOJ_Kontejner
        _mPanOJ_meni = panOJ_meni
        _mLinkOJ_search = linkOJ_search

        _mPanNaselja_kontejn = panNaselja_Kontejner
        _mPanNaselja_meni = panNaselja_meni
        _mLinkNaselja_search = linkNaselja_search

        _mTableButtons = tableButtons
    End Sub

    Private Sub podesi_visinu()
        With _mTableButtons
            .Height = _visina
            .RowStyles.Item(1).Height = 8
            .RowStyles.Item(3).Height = 8
            .RowStyles.Item(5).Height = 8
        End With
    End Sub

    Private Sub podesi_boje()
        Dim tControl As Control
        For Each tControl In _mTableButtons.Controls
            If tControl.Name Like "btn*" Then
                tControl.BackColor = Color.MintCream
                tControl.Enabled = True
            End If
            If tControl.Name Like "pan*" Then
                tControl.BackColor = Color.LightSteelBlue
                tControl.Enabled = True
            End If

        Next
    End Sub

    Shared Sub podesi_boje_linkova(ByVal _panel As TableLayoutPanel)
        Dim tLink As LinkLabel
        For Each tLink In _panel.Controls
            tLink.BackColor = Color.LightSteelBlue
            tLink.LinkColor = Color.MidnightBlue
            tLink.BorderStyle = Windows.Forms.BorderStyle.None
        Next
    End Sub

    Shared Sub disable_linkove(ByVal _panel As TableLayoutPanel)
        Dim tLink As LinkLabel
        For Each tLink In _panel.Controls
            tLink.Enabled = False
        Next
    End Sub

    Shared Sub enable_linkove(ByVal _panel As TableLayoutPanel)
        Dim tLink As LinkLabel
        For Each tLink In _panel.Controls
            tLink.Enabled = True
        Next
    End Sub

    Shared Sub disable_buttons(ByVal _panel As TableLayoutPanel)
        Dim tButton As Button
        For Each tButton In _panel.Controls
            tButton.Enabled = False
        Next
    End Sub

    Shared Sub enable_buttons(ByVal _panel As TableLayoutPanel)
        Dim tButton As Button
        For Each tButton In _panel.Controls
            tButton.Enabled = True
        Next
    End Sub

#Region "partneri"
    Private Sub btnPartneri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPartneri.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntPartneri
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnPartneri.BackColor = Color.LightSteelBlue
        btnPartneri.Enabled = False

        _labHead.Text = Ispisi_label() + My.Resources.text_partneri

        podesi_visinu()
        _mTableButtons.RowStyles.Item(1).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(1).Height

        ID_vrsta_dokumenta = 0
    End Sub

    Private Sub linkPartneri_search_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPartneri_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 310

        Dim myControl As New cntPartneri_sreach
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_partneri + My.Resources.text_search
        podesi_boje_linkova(panPartneri_meni)
        linkPartneri_search.BackColor = Color.GhostWhite
        linkPartneri_search.ForeColor = Color.MidnightBlue

    End Sub

    Private Sub linkPartneri_add_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPartneri_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntPartneri_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_partneri + My.Resources.text_add
        podesi_boje_linkova(panPartneri_meni)
        linkPartneri_add.BackColor = Color.GhostWhite
        linkPartneri_add.LinkColor = Color.MidnightBlue
        disable_linkove(panPartneri_meni)
    End Sub

    Private Sub linkPartneri_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPartneri_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati stavku")
                Exit Sub
            Else
                _partner_sifra = _lista.SelectedItems.Item(0).Text ' _lista.SelectedItems.Item(0).SubItems(1).Text
                selektuj_partnera(_partner_sifra, Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntPartneri_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + My.Resources.text_partneri + My.Resources.text_edit
                podesi_boje_linkova(panPartneri_meni)
                linkPartneri_edit.BackColor = Color.GhostWhite
                linkPartneri_edit.LinkColor = Color.MidnightBlue
                disable_linkove(panPartneri_meni)
            End If
        End If
    End Sub

    Private Sub linkPartneri_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPartneri_del.LinkClicked
        cntPartneri.myDelete()
    End Sub

    Private Sub linkPartneri_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPartneri_print.LinkClicked
        cntPartneri_sreach.prn()
    End Sub

#End Region

#Region "OJ"
    Private Sub btnOJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOJ.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntOJ
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnOJ.BackColor = Color.LightSteelBlue
        btnOJ.Enabled = False

        _labHead.Text = Ispisi_label() + My.Resources.text_oj

        podesi_visinu()
        _mTableButtons.RowStyles.Item(3).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(3).Height

        ID_vrsta_dokumenta = 0
    End Sub
    Private Sub linkOJ_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkOJ_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 240

        Dim myControl As New cntOJ_sreach
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_oj + My.Resources.text_search
        podesi_boje_linkova(panOJ_meni)
        linkOJ_search.BackColor = Color.GhostWhite
        linkOJ_search.ForeColor = Color.MidnightBlue
    End Sub
    Private Sub linkOJUnos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkOJUnos.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntOJ_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_oj + My.Resources.text_add
        podesi_boje_linkova(panOJ_meni)
        linkOJUnos.BackColor = Color.GhostWhite
        linkOJUnos.LinkColor = Color.MidnightBlue
        disable_linkove(panOJ_meni)
    End Sub

    Private Sub linkOJEdit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkOJEdit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati stavku")
                Exit Sub
            Else
                _oj_sifra = _lista.SelectedItems.Item(0).Text ' _lista.SelectedItems.Item(0).SubItems(1).Text
                selektuj_oj(RTrim(_oj_sifra), Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntOJ_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + " : ORG.JEDINICE" + " - ažuriranje"
                podesi_boje_linkova(panOJ_meni)
                linkOJEdit.BackColor = Color.GhostWhite
                linkOJEdit.LinkColor = Color.MidnightBlue
                disable_linkove(panOJ_meni)
            End If
        End If
    End Sub

    Private Sub linkOJBrisanje_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkOJBrisanje.LinkClicked
        cntOJ.myDelete()
    End Sub

    Private Sub linkOJPrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkOJPrint.LinkClicked
        cntOJ_sreach.prn()
    End Sub

#End Region

#Region "Naselja"

    Private Sub btnNaselja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNaselja.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntNaselja
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnNaselja.BackColor = Color.LightSteelBlue
        btnNaselja.Enabled = False

        _labHead.Text = Ispisi_label() + My.Resources.text_naselja

        podesi_visinu()
        _mTableButtons.RowStyles.Item(5).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(5).Height

        ID_vrsta_dokumenta = 0
    End Sub

    Private Sub linkNaselja_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkNaselja_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 205

        Dim myControl As New cntNaselja_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_naselja + My.Resources.text_search
        podesi_boje_linkova(_mPanNaselja_meni)
        linkNaselja_search.BackColor = Color.GhostWhite
        linkNaselja_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkNaseljaUnos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkNaseljaUnos.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntNaselja_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_naselja + My.Resources.text_add
        podesi_boje_linkova(panNaselja_meni)
        linkNaseljaUnos.BackColor = Color.GhostWhite
        linkNaseljaUnos.LinkColor = Color.MidnightBlue
        disable_linkove(panNaselja_meni)
    End Sub

    Private Sub linkNaseljaEdit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkNaseljaEdit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati stavku")
                Exit Sub
            Else
                If _naselja <> "" Then
                    Dim _naziv As String = _lista.SelectedItems.Item(0).Text
                    Select Case _naselja
                        Case Imena.naselja.grad
                            selektuj_grad(RTrim(_naziv), Selekcija.po_nazivu)
                        Case Imena.naselja.mesto
                            selektuj_mesto(RTrim(_naziv), Selekcija.po_nazivu)
                        Case Imena.naselja.opstina
                            selektuj_opstine(RTrim(_naziv), Selekcija.po_nazivu)
                    End Select

                    mdiMain.zatvori_kontrolu_desno()
                    Dim myControl As New cntNaselja_edit
                    myControl.Parent = mdiMain.splRadni.Panel2
                    myControl.Dock = DockStyle.Fill
                    myControl.Show()

                    _labHead.Text = Ispisi_label() + My.Resources.text_naselja + My.Resources.text_print
                    podesi_boje_linkova(_mPanNaselja_meni)
                    linkNaseljaEdit.BackColor = Color.GhostWhite
                    linkNaseljaEdit.LinkColor = Color.MidnightBlue
                    disable_linkove(panNaselja_meni)
                Else
                    MsgBox("Niste izabrali tip naselja. Pokušajte ponovo.")
                End If
            End If
        End If
    End Sub

    Private Sub linkNaseljaBrisanje_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkNaseljaBrisanje.LinkClicked
        cntNaselja.myDelete()
    End Sub

    Private Sub linkNaseljaPrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkNaseljaPrint.LinkClicked
        'Dim myControl As New cntNaselja_search
        If IsNothing(_mCntNaselja_search) Then
            Dim myControl As New cntNaselja_search
            myControl.Parent = _mSpliter.Panel1
            myControl.Dock = DockStyle.Fill
            myControl.Show()
        End If
        cntNaselja_search.prn()
    End Sub

#End Region

    Private Sub btnNazad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNazad.Click
        mdiMain.zatvori_kontrolu_levo()
        mdiMain.zatvori_kontrolu_desno()

        _povratak = True
        If zadnji_zapis(_korak_nazad) <> 0 And zadnji_zapis(_korak_labHead) <> 0 Then
            _korak_nazad.SetValue("", zadnji_zapis(_korak_nazad) - 1)
            _korak_labHead.SetValue("", zadnji_zapis(_korak_labHead) - 1)
        End If
        If Not _korak_nazad(zadnji_zapis(_korak_nazad)) Is Nothing Or _
            _korak_nazad(zadnji_zapis(_korak_nazad)).ToString <> "" Then

            _forma_zapovratak = predhodna_forma(_korak_nazad(zadnji_zapis(_korak_nazad) - 1))
            _forma_zapovratak.Parent = mdiMain.splGlavni.Panel1
            _forma_zapovratak.Dock = DockStyle.Fill
            _forma_zapovratak.Show()
        End If

        ID_vrsta_dokumenta = 0
    End Sub

End Class
