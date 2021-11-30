Public Class cntMeniMaticniPodaci

    Private _visina As Integer = 220

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntMeniMaticniPodaci_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()
        If Not _povratak Then
            _korak_nazad.SetValue(Me.Name.ToString, zadnji_zapis(_korak_nazad))
            _korak_labHead.SetValue(Me.Name.ToString, zadnji_zapis(_korak_labHead))
        End If
        _labHead.Text = Ispisi_label()
        _lStatus.Text = Ispisi_label()
        _povratak = False
    End Sub

    Private Sub pocetak()
        '    panGlavni.Height = 226
        podesi_kontrole()
        podesi_visinu()
        podesi_boje()
    End Sub

    Private Sub podesi_kontrole()

        _mPanArtikli_kontejn = panArtikli_Kontejner
        _mPanArtikli_meni = panArtikli_meni
        _mLinkArtikli_search = linkArtikli_search

        _mPanPDV_kontejn = panPDV_Kontejner
        _mPanPDV_meni = panPDV_meni
        _mLinkPDV_search = linkPDV_search

        _mPanPartneri_kontejn = panPartneri_Kontejner
        _mPanPartneri_meni = panPartneri_meni
        _mLinkPartneri_search = linkPartneri_search

        _mPanKonta_kontejn = panKonta_kontejner
        _mPanKonta_meni = panKonta_meni
        _mLinkKonta_search = linkKonta_search
        _mLinkKonta_edit = linkKonta_edit

        _mTableButtons = tableButtons
    End Sub

    Private Sub podesi_visinu()
        With _mTableButtons
            .Height = _visina
            .RowStyles.Item(1).Height = 8
            .RowStyles.Item(3).Height = 8
            .RowStyles.Item(5).Height = 8
            .RowStyles.Item(7).Height = 8
            .RowStyles.Item(9).Height = 8
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

#Region "ARTIKLI"
    Private Sub btnArtikli_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnArtikli.Click
        mdiMain.zatvori_kontrolu_levo()
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl As New cntMeniArtikli
        myControl.Parent = mdiMain.splGlavni.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

    End Sub
#End Region

#Region "PDV"
    Private Sub btnPdv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPdv.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntPDV
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnPdv.BackColor = Color.LightSteelBlue
        btnPdv.Enabled = False

        _labHead.Text = Ispisi_label() + " : PDV"

        podesi_visinu()
        _mTableButtons.RowStyles.Item(3).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(3).Height
    End Sub

    Private Sub linkPDV_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPDV_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 190

        Dim myControl As New cntPDV_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : PDV" + " - pretraga"
        podesi_boje_linkova(panPDV_meni)
        linkPDV_search.BackColor = Color.GhostWhite
        linkPDV_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkPDV_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPDV_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntPDV_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : PDV" + " - unos"
        podesi_boje_linkova(panPDV_meni)
        linkPDV_add.BackColor = Color.GhostWhite '_panGenerIme_meni dodeljen
        linkPDV_add.LinkColor = Color.MidnightBlue '_panGenerIme_meni dodeljen
        disable_linkove(panPDV_meni)
    End Sub

    Private Sub linkPDV_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPDV_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati zapis")
                Exit Sub
            Else
                _pdv_sifra = RTrim(_lista.SelectedItems.Item(0).SubItems(0).Text)
                selektuj_pdv(_pdv_sifra, Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntPDV_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + " : PDV" + " - ažuriranje"
                podesi_boje_linkova(panPDV_meni)
                linkPDV_edit.BackColor = Color.GhostWhite
                linkPDV_edit.LinkColor = Color.MidnightBlue
                disable_linkove(panPDV_meni)
            End If
        End If
    End Sub

    Private Sub linkPDV_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPDV_del.LinkClicked
        cntPDV.myDelete()
    End Sub

    Private Sub linkPDV_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPDV_print.LinkClicked
        cntPDV_search.prn()
    End Sub
#End Region

#Region "PARTNERI"
    Private Sub btnPartneri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPartneri.Click
        mdiMain.zatvori_kontrolu_levo()
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl As New cntMeniPartneri
        myControl.Parent = mdiMain.splGlavni.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

    End Sub
#End Region

#Region "KONTA"
    Private Sub btnKonta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKonta.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntKontniPlan
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnKonta.BackColor = Color.LightSteelBlue
        btnKonta.Enabled = False

        _labHead.Text = Ispisi_label() + My.Resources.text_konta

        podesi_visinu()
        _mTableButtons.RowStyles.Item(7).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(7).Height
        'tableButtons.Height = 220 '_mTableButtons.Height + 32 + 8

        ID_vrsta_dokumenta = 0 ' vrsta_dokumenta.kalkulacija
    End Sub

    Private Sub linkKonta_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKonta_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 180

        Dim myControl As New cntKontniPlan_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_konta + My.Resources.text_search
        podesi_boje_linkova(panKonta_meni)
        linkKonta_search.BackColor = Color.GhostWhite
        linkKonta_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkKonta_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKonta_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntKontniPlan_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_konta + My.Resources.text_add
        podesi_boje_linkova(panKonta_meni)
        linkKonta_add.BackColor = Color.GhostWhite
        linkKonta_add.LinkColor = Color.MidnightBlue
        disable_linkove(panKonta_meni)
    End Sub

    Private Sub linkKonta_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKonta_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati stavku")
                Exit Sub
            Else
                _konto_Sifra = _lista.SelectedItems.Item(0).Text ' _lista.SelectedItems.Item(0).SubItems(1).Text
                selektuj_konto(RTrim(_konto_Sifra), Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntKontniPlan_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + My.Resources.text_konta + My.Resources.text_edit
                podesi_boje_linkova(panKonta_meni)
                linkKonta_edit.BackColor = Color.GhostWhite
                linkKonta_edit.LinkColor = Color.MidnightBlue
                disable_linkove(panKonta_meni)
            End If
        End If
    End Sub

    Private Sub linkKonta_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKonta_del.LinkClicked
        cntKontniPlan.myDelete()
    End Sub

    Private Sub linkKonta_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKonta_print.LinkClicked
        cntKontniPlan_search.prn()
    End Sub
#End Region

#Region "INFO"
    Private Sub btnInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfo.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl As New cntMaticniPodaci
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        podesi_boje()
        btnInfo.BackColor = Color.LightSteelBlue
        btnInfo.Enabled = False

        _labHead.Text = Ispisi_label() + "PREDUZEĆE" ' My.Resources.text_konta

        podesi_visinu()
        '_mTableButtons.RowStyles.Item(9).Height = 112
        '_mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(9).Height

        ID_vrsta_dokumenta = 0
    End Sub

    'Private Sub linkOdlozenoUnos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '    Dim mForm As New frmOdlozenoUnos
    '    mForm.Show()
    'End Sub

    'Private Sub linkOdlozenoEdit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '    cntOdlozeno.myUpdate()
    'End Sub

    'Private Sub linkOdlozenoBrisanje_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '    cntOdlozeno.myDelete()
    'End Sub

    'Private Sub linkOdlozenoPrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '    '_raport = Imena.tabele.fn_putni_nalog.ToString
    '    'Dim mForm As New frmPrint
    '    'mForm.Show()
    'End Sub
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
    End Sub

End Class
