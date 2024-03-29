Option Strict Off
Option Explicit On

Public Class cntMeniArtikli

    Private _visina As Integer = 220

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntMeniArtikli_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()

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
        podesi_boje()
    End Sub

    Private Sub podesi_kontrole()
        _mPanArtikli_kontejn = panArtikli_Kontejner
        _mPanArtikli_meni = panArtikli_meni
        _mLinkArtikli_search = linkArtikli_search
        _mLinkArtikli_edit = linkArtikli_edit
        _mLinkPozitivna_lista = linkPozitivna_lista

        _mPanGrupe_kontejn = panGrupe_Kontejner
        _mPanGrupe_meni = panGrupe_meni
        _mLinkGrupe_search = linkGrupe_search

        _mPanGenerIme_kontejn = panGenerIme_Kontejner
        _mPanGIme_meni = panGenerIme_meni
        _mLinkGIme_search = linkGenericko_search

        _mPanFO_kontejn = panFO_Kontejner
        _mPanFO_meni = panFO_meni
        _mLinkFO_search = linkFO_search

        _mPanJM_kontejn = panJM_Kontejner
        _mPanJM_meni = panJM_meni
        _mLinkJM_search = linkJM_search

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
            '.RowStyles.Item(11).Height = 8
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

#Region "artikli"
    Private Sub btnArtikli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArtikli.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntArtikli
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnArtikli.BackColor = Color.LightSteelBlue
        btnArtikli.Enabled = False

        _labHead.Text = Ispisi_label() + " : artikli"

        podesi_visinu()
        _mTableButtons.RowStyles.Item(1).Height = 132 ' 174
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(1).Height
    End Sub

    Private Sub linkArtikli_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkArtikli_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 235

        Dim myControl As New cntArtikli_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_artikli_promet + My.Resources.text_search  ' " : kalkulacija" + " - pretraga"
        podesi_boje_linkova(panArtikli_meni)
        linkArtikli_search.BackColor = Color.GhostWhite
        linkArtikli_search.ForeColor = Color.MidnightBlue

    End Sub

    Private Sub linkArtikli_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkArtikli_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntArtikliUnos
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : artikli" + " - unos"
        podesi_boje_linkova(panArtikli_meni)
        linkArtikli_add.BackColor = Color.GhostWhite
        linkArtikli_add.LinkColor = Color.MidnightBlue
        disable_linkove(panArtikli_meni)
        'disable_linkove(tableButtons)
    End Sub

    Private Sub linkArtikli_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkArtikli_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati artikl")
                Exit Sub
            Else
                _artikl_sifra = _lista.SelectedItems.Item(0).SubItems(0).Text
                selektuj_artikl(RTrim(_artikl_sifra), Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntArtiklEdit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + " : artikli" + " - ažuriranje"
                podesi_boje_linkova(panArtikli_meni)
                linkArtikli_edit.BackColor = Color.GhostWhite
                linkArtikli_edit.LinkColor = Color.MidnightBlue
                disable_linkove(panArtikli_meni)
            End If
        End If
    End Sub

    Private Sub linkArtikli_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkArtikli_del.LinkClicked
        cntArtikli.myDelete()
    End Sub

    Private Sub linkArtikli_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkArtikli_print.LinkClicked
        cntArtikli_search.prn()
    End Sub

    Private Sub linkPozitivna_lista_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPozitivna_lista.LinkClicked
       cntArtikli_search.prn()
    End Sub

    Private Sub linkArtikli_cenovnik_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        If Not IsNothing(_lista) Then
            If _lista.CheckedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati artikle")
                Exit Sub
            Else
                Dim i As Integer
                _artikl_lista_ponude = New String() {}
                ReDim _artikl_lista_ponude((_lista.CheckedItems.Count * 3) - 1)

                For i = 0 To _lista.CheckedItems.Count - 1
                    _artikl_lista_ponude.SetValue(RTrim(_lista.CheckedItems.Item(i).SubItems(0).Text), i * 3) 'sifra
                    _artikl_lista_ponude.SetValue(RTrim(_lista.CheckedItems.Item(i).SubItems(5).Text), (i * 3) + 1) 'pdv
                    '_roba_lista_ponude.SetValue(RTrim(_lista.CheckedItems.Item(i).SubItems(7).Text), (i * 3) + 2) '
                Next
                _ponuda_iz_robe = True
                'Dim mForm As New frmPredracuniUnos
                'mForm.Show()
                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntTrebovanjeUnos
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()
            End If
        End If
    End Sub

#End Region

#Region "Grupe artikla"
    Private Sub btnGrupeArt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrupeArt.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntGrupeArt
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnGrupeArt.BackColor = Color.LightSteelBlue
        btnGrupeArt.Enabled = False

        _labHead.Text = Ispisi_label() + " : Grupe artikla"

        podesi_visinu()
        _mTableButtons.RowStyles.Item(3).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(3).Height

    End Sub
    Private Sub linkGrupe_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkGrupe_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 170

        Dim myControl As New cntGrupeArt_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : Grupe artikla" + " - pretraga" ' My.Resources.text_artikli_promet + My.Resources.text_search  ' " : kalkulacija" + " - pretraga"
        podesi_boje_linkova(panArtikli_meni)
        linkGrupe_search.BackColor = Color.GhostWhite
        linkGrupe_search.ForeColor = Color.MidnightBlue

    End Sub

    Private Sub linkGrupe_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkGrupe_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntGrupeArt_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : Grupe artikla" + " - unos"
        podesi_boje_linkova(panGrupe_meni)
        linkGrupe_add.BackColor = Color.GhostWhite
        linkGrupe_add.LinkColor = Color.MidnightBlue
        disable_linkove(panGrupe_meni)
        'disable_linkove(tableButtons)
    End Sub

    Private Sub linkGrupe_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkGrupe_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati artikl")
                Exit Sub
            Else
                _gr_art_sifra = _lista.SelectedItems.Item(0).SubItems(0).Text
                selektuj_GrupeArt(RTrim(_gr_art_sifra), Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntGrupeArt_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + " : Grupe artikla" + " - ažuriranje"
                podesi_boje_linkova(panGrupe_meni)
                linkGrupe_edit.BackColor = Color.GhostWhite
                linkGrupe_edit.LinkColor = Color.MidnightBlue
                disable_linkove(panGrupe_meni)
            End If
        End If
    End Sub

    Private Sub linkGrupe_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkGrupe_del.LinkClicked
        cntGrupeArt.myDelete()
    End Sub

    Private Sub linkGrupe_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkGrupe_print.LinkClicked
        cntGrupeArt_search.prn()
    End Sub
#End Region

#Region "Genericko"
    Private Sub btnGenericko_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenericko.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntGenericko_ime
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnGenericko.BackColor = Color.LightSteelBlue
        btnGenericko.Enabled = False

        _labHead.Text = Ispisi_label() + " : Generičko ime"

        podesi_visinu()
        _mTableButtons.RowStyles.Item(5).Height = 110
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(5).Height
    End Sub

    Private Sub linkGenericko_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkGenericko_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 165

        Dim myControl As New cntGenericko_ime_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : Generičko ime" + " - pretraga"
        podesi_boje_linkova(panGenerIme_meni)
        linkGenericko_search.BackColor = Color.GhostWhite
        linkGenericko_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkGenericko_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkGenericko_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntGenericko_ime_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : Generičko ime" + " - unos"
        podesi_boje_linkova(panGenerIme_meni)
        linkGenericko_add.BackColor = Color.GhostWhite '_panGenerIme_meni dodeljen
        linkGenericko_add.LinkColor = Color.MidnightBlue '_panGenerIme_meni dodeljen
        disable_linkove(panGenerIme_meni)
      
    End Sub

    Private Sub linkGenericko_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkGenericko_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati artikl")
                Exit Sub
            Else
                _genericko_sifra = RTrim(_lista.SelectedItems.Item(0).SubItems(0).Text)
                selektuj_genericko(_genericko_sifra, Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntGenericko_ime_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + " : Generičko ime" + " - ažuriranje"
                podesi_boje_linkova(panGenerIme_meni)
                linkGenericko_edit.BackColor = Color.GhostWhite
                linkGenericko_edit.LinkColor = Color.MidnightBlue
                disable_linkove(panGenerIme_meni)
            End If
        End If
    End Sub

    Private Sub linkGenericko_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkGenericko_del.LinkClicked
        cntGenericko_ime.myDelete()
    End Sub

    Private Sub linkGenericko_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkGenericko_print.LinkClicked
        cntGenericko_ime_search.prn()
    End Sub
#End Region

#Region "FO"
    Private Sub btnFO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFO.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntFO
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnFO.BackColor = Color.LightSteelBlue
        btnFO.Enabled = False

        _labHead.Text = Ispisi_label() + " : Farmaceutski oblik"

        podesi_visinu()
        _mTableButtons.RowStyles.Item(7).Height = 120
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(7).Height

    End Sub

    Private Sub linkFO_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkFO_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 180

        Dim myControl As New cntFO_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : Farmaceutski oblik" + " - pretraga"
        podesi_boje_linkova(panFO_meni)
        linkGenericko_search.BackColor = Color.GhostWhite
        linkGenericko_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkFO_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkFO_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntFO_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : Farmaceutski oblik" + " - unos"
        podesi_boje_linkova(panArtikli_meni)
        linkGenericko_add.BackColor = Color.GhostWhite '_panGenerIme_meni dodeljen
        linkGenericko_add.LinkColor = Color.MidnightBlue '_panGenerIme_meni dodeljen
        disable_linkove(panArtikli_meni)
    End Sub

    Private Sub linkFO_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkFO_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati zapis")
                Exit Sub
            Else
                _fo_sifra = RTrim(_lista.SelectedItems.Item(0).SubItems(0).Text)
                selektuj_fo(_fo_sifra, Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntFO_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + " : Farmaceutski oblik" + " - ažuriranje"
                podesi_boje_linkova(panFO_meni)
                linkGenericko_edit.BackColor = Color.GhostWhite
                linkGenericko_edit.LinkColor = Color.MidnightBlue
                disable_linkove(panFO_meni)
            End If
        End If
    End Sub

    Private Sub linkFO_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkFO_del.LinkClicked
        cntFO.myDelete()
    End Sub

    Private Sub linkFO_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkFO_print.LinkClicked
        cntFO_search.prn()
    End Sub
#End Region

#Region "JM"
    Private Sub btnJm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJm.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntJM
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnJm.BackColor = Color.LightSteelBlue
        btnJm.Enabled = False

        _labHead.Text = Ispisi_label() + " : Jedinice mera"

        podesi_visinu()
        _mTableButtons.RowStyles.Item(9).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(9).Height
    End Sub

    Private Sub linkJM_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkJM_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 190

        Dim myControl As New cntJM_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : Jedinice mera" + " - pretraga"
        podesi_boje_linkova(panJM_meni)
        linkJM_search.BackColor = Color.GhostWhite
        linkJM_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkJM_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkJM_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntJM_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : Jedinice mera" + " - unos"
        podesi_boje_linkova(panJM_meni)
        linkJM_add.BackColor = Color.GhostWhite '_panGenerIme_meni dodeljen
        linkJM_add.LinkColor = Color.MidnightBlue '_panGenerIme_meni dodeljen
        disable_linkove(panJM_meni)
    End Sub

    Private Sub linkJM_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkJM_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati artikl")
                Exit Sub
            Else
                _jm_sifra = RTrim(_lista.SelectedItems.Item(0).SubItems(0).Text)
                selektuj_jm(_jm_sifra, Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntJM_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + " : Jedinice mera" + " - ažuriranje"
                podesi_boje_linkova(panJM_meni)
                linkJM_edit.BackColor = Color.GhostWhite
                linkJM_edit.LinkColor = Color.MidnightBlue
                disable_linkove(panJM_meni)
            End If
        End If

    End Sub

    Private Sub linkJM_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkJM_del.LinkClicked
        cntJM.myDelete()
    End Sub

    Private Sub linkJM_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkJM_print.LinkClicked
        cntJM_search.prn()
    End Sub
#End Region

    Private Sub btnNazad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNazad.Click
        mdiMain.zatvori_kontrolu_levo()

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

    Private Sub btnAlati_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlati.Click
        Dim myControl As New cntAlati
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()
    End Sub

End Class
