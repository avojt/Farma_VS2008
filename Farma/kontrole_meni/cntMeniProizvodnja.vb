Option Strict Off
Option Explicit On

Public Class cntMeniProizvodnja
    Private _visina As Integer = 116

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntMeniProizvodnja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()

        If Not _povratak Then
            _korak_nazad.SetValue(Me.Name.ToString, zadnji_zapis(_korak_nazad))
            _korak_labHead.SetValue(Me.Name.ToString, zadnji_zapis(_korak_labHead))
        End If
        _labHead.Text = Ispisi_label()
        _povratak = False
    End Sub

    Private Sub pocetak()
        panGlavni.Height = 192
        podesi_kontrole()
        podesi_visinu()
        podesi_boje()
    End Sub

    Private Sub podesi_kontrole()
        _mPanSastavnica_kontejn = panSastavnice_Kontejner
        _mPanSastavnica_meni = panSastavnice_meni
        _mLinkSastavnica_search = linkSastavnica_search

        _mPanLabDn_kontejn = panLab_Dn_Kontejner
        _mPanLabDn_meni = panLab_Dn_meni
        _mLinkLabDn_search = linkLabDn_search

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

#Region "sastavnice"
    Private Sub btnSastavnice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSastavnice.Click
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntSastavnica
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _mSpliter.SplitterDistance = 190

        Dim myControl1 As New cntSastavnica_search
        myControl1.Parent = _mSpliter.Panel1
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnSastavnice.BackColor = Color.LightSteelBlue
        btnSastavnice.Enabled = False
        btnSastavnice.FlatStyle = FlatStyle.Standard

        _labHead.Text = Ispisi_label() + My.Resources.text_sastavnice

        podesi_visinu()
        _mTableButtons.RowStyles.Item(1).Height = 112
        panGlavni.Height = _visina - 8 + _mTableButtons.RowStyles.Item(1).Height + 76 '26

        ID_vrsta_dokumenta = 0

    End Sub

    Private Sub linkSastavnica_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkSastavnica_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 190

        Dim myControl As New cntSastavnica_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_sastavnice + My.Resources.text_search  ' " : kalkulacija" + " - pretraga"
        podesi_boje_linkova(panSastavnice_meni)
        linkSastavnica_search.BackColor = Color.GhostWhite
        linkSastavnica_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkSastavnica_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkSastavnica_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntSastavnica_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()
        '***
        _labHead.Text = Ispisi_label() + My.Resources.text_proizvodnja + My.Resources.text_add
        podesi_boje_linkova(panSastavnice_meni)
        linkSastavnica_add.BackColor = Color.GhostWhite
        linkSastavnica_add.LinkColor = Color.MidnightBlue
        disable_linkove(panSastavnice_meni)
        disable_linkove(tableButtons)
    End Sub

    Private Sub linkSastavnica_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkSastavnica_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati dokument")
                Exit Sub
            Else
                _sas_art_sifra = RTrim(_lista.SelectedItems.Item(0).Text)
                selektuj_sastavnicu(RTrim(_sas_art_sifra), Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntSastavnica_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + My.Resources.text_robno + My.Resources.text_edit
                podesi_boje_linkova(panSastavnice_meni)
                linkSastavnica_edit.BackColor = Color.GhostWhite
                linkSastavnica_edit.LinkColor = Color.MidnightBlue
                'disable_linkove(tableButtons)
            End If
        End If
    End Sub

    Private Sub linkSastavnica_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkSastavnica_del.LinkClicked
        cntSastavnica.myDelete()
    End Sub

    Private Sub linkSastavnica_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkSastavnica_print.LinkClicked
        If IsNothing(_mCntSastavnica_search) Then
            Dim myControl As New cntSastavnica_search
            myControl.Parent = _mSpliter.Panel1
            myControl.Dock = DockStyle.Fill
            myControl.Show()
        End If
        cntSastavnica_search.prn()
    End Sub

#End Region

#Region "laboratorijski dnevnik"

    Private Sub btnLab_Dn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLab_Dn.Click
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntLab_Dn
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _mSpliter.SplitterDistance = 240

        Dim myControl1 As New cntLab_Dn_search
        myControl1.Parent = _mSpliter.Panel1
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnLab_Dn.BackColor = Color.LightSteelBlue
        btnLab_Dn.Enabled = False
        btnLab_Dn.FlatStyle = FlatStyle.Standard

        _labHead.Text = Ispisi_label() + My.Resources.text_sastavnice

        podesi_visinu()
        _mTableButtons.RowStyles.Item(3).Height = 112
        panGlavni.Height = _visina - 8 + _mTableButtons.RowStyles.Item(3).Height + 76 '26

        ID_vrsta_dokumenta = 21
    End Sub

    Private Sub linkLabDn_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLabDn_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 240

        Dim myControl As New cntLab_Dn_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_sastavnice + My.Resources.text_search  ' " : kalkulacija" + " - pretraga"
        podesi_boje_linkova(panLab_Dn_meni)
        linkLabDn_search.BackColor = Color.GhostWhite
        linkLabDn_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkLabDn_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLabDn_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntLab_Dn_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()
        '***
        _labHead.Text = Ispisi_label() + My.Resources.text_proizvodnja + My.Resources.text_add
        podesi_boje_linkova(panLab_Dn_meni)
        linkLabDn_add.BackColor = Color.GhostWhite
        linkLabDn_add.LinkColor = Color.MidnightBlue
        disable_linkove(panLab_Dn_meni)
        'disable_linkove(tableButtons)
    End Sub

    Private Sub linkLabDn_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLabDn_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati kalkulaciju")
                Exit Sub
            Else
                _lab_dn_broj = RTrim(_lista.SelectedItems.Item(0).Text)
                selektuj_lab_dn(RTrim(_lab_dn_broj), Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntLab_Dn_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + My.Resources.text_robno + My.Resources.text_edit
                podesi_boje_linkova(panLab_Dn_meni)
                linkLabDn_edit.BackColor = Color.GhostWhite
                linkLabDn_edit.LinkColor = Color.MidnightBlue
                disable_linkove(panLab_Dn_meni)
                'disable_linkove(tableButtons)
            End If
        End If
    End Sub

    Private Sub linkLabDn_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLabDn_del.LinkClicked
        cntLab_Dn.myDelete()
    End Sub

    Private Sub linkLabDn_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLabDn_print.LinkClicked
        If IsNothing(_mCntSastavnica_search) Then
            Dim myControl As New cntSastavnica_search
            myControl.Parent = _mSpliter.Panel1
            myControl.Dock = DockStyle.Fill
            myControl.Show()
        End If
        cntLab_Dn_search.prn()
    End Sub
#End Region

#Region "izvestaji"
    Private Sub btnIzvestaji_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzvestaji.Click
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntLab_Dn
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _mSpliter.SplitterDistance = 240

        Dim myControl1 As New cntLab_Dn_search
        myControl1.Parent = _mSpliter.Panel1
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnIzvestaji.BackColor = Color.LightSteelBlue
        btnIzvestaji.Enabled = False
        btnIzvestaji.FlatStyle = FlatStyle.Standard

        _labHead.Text = Ispisi_label() + My.Resources.text_sastavnice

        podesi_visinu()
        _mTableButtons.RowStyles.Item(5).Height = 112
        panGlavni.Height = _visina - 8 + _mTableButtons.RowStyles.Item(5).Height + 76 '26

        ID_vrsta_dokumenta = 21
    End Sub

    Private Sub linkDnevlabIzrade_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkDnevlabIzrade.LinkClicked
        If IsNothing(_mCntSastavnica_search) Then
            Dim myControl As New cntSastavnica_search
            myControl.Parent = _mSpliter.Panel1
            myControl.Dock = DockStyle.Fill
            myControl.Show()
        End If
        _sve = True
        cntLab_Dn_search.dnevnik()
    End Sub

    Private Sub linkRekapLabIzrade_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkRekapLabIzrade.LinkClicked
        If IsNothing(_mCntSastavnica_search) Then
            Dim myControl As New cntSastavnica_search
            myControl.Parent = _mSpliter.Panel1
            myControl.Dock = DockStyle.Fill
            myControl.Show()
        End If
        cntLab_Dn_search.rekapitulacija()
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
    End Sub

End Class
