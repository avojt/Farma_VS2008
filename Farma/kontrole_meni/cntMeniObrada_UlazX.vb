Option Strict Off
Option Explicit On

Public Class cntMeniObrada_UlazX
    Private _visina As Integer = 220


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntMeniObrada_Ulaz_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
        _mPanKalk_kontejn = panKalk_Kontejner
        _mPanKalk_meni = panKalk_meni
        _mLinkKalk_search = linkKalk_search

        _mPanIntDosUlaz_kontejn = panIntDostUlaz_Kontejner
        _mPanIntDosUlaz_meni = panIntDostUlaz_meni
        _mLinkIntDosUlaz_search = linkIntDostUlaz_search

        _mPanKnjOdobUlaz_kontejn = panKnjOdob_Kontejner
        _mPanKnjOdobUlaz_meni = panKnjOdob_meni
        _mLinkKnjOdobUlaz_search = linkKnjOdob_search

        _mPanKnjZaduzUlaz_kontejn = panKnjZaduz_Kontejner
        _mPanKnjZaduzUlaz_meni = panKnjZaduz_meni
        _mLinkKnjZaduzUlaz_search = linkKnjZaduz_search

        _mPanPovracajRobe_kontejn = panPovracajRobe_Kontejner
        _mPanPovracajRobe_meni = panPovracajRobe_meni
        _mlinkPovracajRobe_search = linkPovracajRobe_search

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

#Region "klakulacija"
    Private Sub btnKalkulacija_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKalkulacija.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntKalkulacija
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnKalkulacija.BackColor = Color.LightSteelBlue
        btnKalkulacija.Enabled = False

        _labHead.Text = Ispisi_label() + " : kalkulacija"

        podesi_visinu()
        _mTableButtons.RowStyles.Item(1).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(1).Height

        ID_vrsta_dokumenta = vrsta_dokumenta.kalkulacija
    End Sub

    Private Sub linkKalk_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKalk_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 240

        Dim myControl As New cntKalkulacija_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : kalkulacija" + " - pretraga"
        podesi_boje_linkova(panKalk_meni)
        linkKalk_search.BackColor = Color.GhostWhite
        linkKalk_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkKalk_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKalk_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntKalkulacija_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : kalkulacija" + " - unos"
        podesi_boje_linkova(panKalk_meni)
        linkKalk_add.BackColor = Color.GhostWhite
        linkKalk_add.LinkColor = Color.MidnightBlue
    End Sub

    Private Sub linkKalk_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKalk_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati kalkulaciju")
                Exit Sub
            Else
                _kalk_broj = _lista.SelectedItems.Item(0).Text ' _lista.SelectedItems.Item(0).SubItems(1).Text
                selektuj_kalkulaciju(RTrim(_kalk_broj), Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntKalkulacija_Edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + " : kalkulacija" + " - ažuriranje"
                podesi_boje_linkova(panKalk_meni)
                linkKalk_edit.BackColor = Color.GhostWhite
                linkKalk_edit.LinkColor = Color.MidnightBlue
            End If
        End If
    End Sub

    Private Sub linkKalk_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKalk_del.LinkClicked
        cntKalkulacija.myDelete()
    End Sub

    Private Sub linkKalk_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKalk_print.LinkClicked
        ''mdiMain.zatvori_kontrolu_desno()
        'Dim myControl As New cntKalkulacija_print
        'myControl.Parent = mdiMain.splRadni.Panel2
        'myControl.Dock = DockStyle.Fill
        'myControl.Show()

        '_labHead.Text = Ispisi_label() + " : kalkulacija" + " - štampanje"
        'podesi_boje_linkova(panKalk_meni)
        'linkKalk_print.BackColor = Color.GhostWhite
        'linkKalk_print.LinkColor = Color.MidnightBlue

        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next

        _mSpliter.SplitterDistance = 240
        Dim myControl As New cntKalkulacija_print
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : kalkulacija" + " - štampanje"
        podesi_boje_linkova(panKalk_meni)
        linkKalk_print.BackColor = Color.GhostWhite
        linkKalk_print.LinkColor = Color.MidnightBlue
    End Sub
#End Region

#Region "interne dostavnice - ulaz"
    Private Sub btnIntDost_ulaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntDost_ulaz.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntIntDostavUlaz
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnIntDost_ulaz.BackColor = Color.LightSteelBlue
        btnIntDost_ulaz.Enabled = False

        _labHead.Text = Ispisi_label() + " : interna dostavnica"

        podesi_visinu()
        _mTableButtons.RowStyles.Item(3).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(3).Height

        ID_vrsta_dokumenta = vrsta_dokumenta.interna_dostavnica_ulaz
    End Sub

    Private Sub linkIntDostUlaz_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkIntDostUlaz_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 240

        Dim myControl As New cntIntDostavUlaz_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : interna dostavnica" + " - pretraga"
        podesi_boje_linkova(panIntDostUlaz_meni)
        linkIntDostUlaz_search.BackColor = Color.GhostWhite
        linkIntDostUlaz_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkIntDostUlaz_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkIntDostUlaz_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntIntDostavUlaz_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : interna dostavnica" + " - unos"
        podesi_boje_linkova(panIntDostUlaz_meni)
        linkIntDostUlaz_add.BackColor = Color.GhostWhite
        linkIntDostUlaz_add.LinkColor = Color.MidnightBlue
    End Sub

    Private Sub linkIntDostUlaz_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkIntDostUlaz_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati stavku")
                Exit Sub
            Else
                _int_dost_broj = _lista.SelectedItems.Item(0).Text ' _lista.SelectedItems.Item(0).SubItems(1).Text
                selektuj_intDost_ulaz(RTrim(_int_dost_broj), Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntIntDostavUlaz_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + " : interna dostavnica" + " - ažuriranje"
                podesi_boje_linkova(panIntDostUlaz_meni)
                linkIntDostUlaz_edit.BackColor = Color.GhostWhite
                linkIntDostUlaz_edit.LinkColor = Color.MidnightBlue
            End If
        End If
    End Sub

    Private Sub linkIntDostUlaz_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkIntDostUlaz_del.LinkClicked
        cntIntDostavUlaz.myDelete()
    End Sub

    Private Sub linkIntDostUlaz_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkIntDostUlaz_print.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next

        _mSpliter.SplitterDistance = 240

        Dim myControl As New cntIntDostavUlaz_print
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : interna dostavnica" + " - štampanje"
        podesi_boje_linkova(panIntDostUlaz_meni)
        linkIntDostUlaz_print.BackColor = Color.GhostWhite
        linkIntDostUlaz_print.LinkColor = Color.MidnightBlue
    End Sub
#End Region

#Region "knjizno odobrenje"
    Private Sub btnKnjiznoOdobrenje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKnjiznoOdobrenje.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntKnjizOdobUlaz
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnKnjiznoOdobrenje.BackColor = Color.LightSteelBlue
        btnKnjiznoOdobrenje.Enabled = False

        _labHead.Text = Ispisi_label() + " : knjižno odobrenje"

        podesi_visinu()
        _mTableButtons.RowStyles.Item(5).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(5).Height

        ID_vrsta_dokumenta = vrsta_dokumenta.knjizno_odobrenje_ulaz
    End Sub

    Private Sub linkKnjOdob_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKnjOdob_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 240

        Dim myControl As New cntKnjizOdobUlaz_sreach
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : knjižno odobrenje" + " - pretraga"
        podesi_boje_linkova(panKnjOdob_meni)
        linkKnjOdob_search.BackColor = Color.GhostWhite
        linkKnjOdob_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkKnjOdob_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKnjOdob_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntKnjizOdobUlaz_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : knjižno odobrenje" + " - unos"
        podesi_boje_linkova(panKnjOdob_meni)
        linkKnjOdob_add.BackColor = Color.GhostWhite
        linkKnjOdob_add.LinkColor = Color.MidnightBlue
    End Sub

    Private Sub linkKnjOdob_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKnjOdob_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati dokument")
                Exit Sub
            Else
                _knjod_ulaz_broj = _lista.SelectedItems.Item(0).Text ' _lista.SelectedItems.Item(0).SubItems(1).Text
                selektuj_ko_ulaz(RTrim(_knjod_ulaz_broj), Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntKnjizOdobUlaz_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + " : knjižno odobrenje" + " - ažuriranje"
                podesi_boje_linkova(panKnjOdob_meni)
                linkKnjOdob_edit.BackColor = Color.GhostWhite
                linkKnjOdob_edit.LinkColor = Color.MidnightBlue
            End If
        End If
    End Sub

    Private Sub linkKnjOdob_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKnjOdob_del.LinkClicked
        cntKnjizOdobUlaz.myDelete()
    End Sub

    Private Sub linkKnjOdob_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKnjOdob_print.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next

        _mSpliter.SplitterDistance = 240
        Dim myControl As New cntKnjizOdobUlaz_print
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : knjižno odobrenje" + " - štampanje"
        podesi_boje_linkova(panKnjOdob_meni)
        linkKnjOdob_print.BackColor = Color.GhostWhite
        linkKnjOdob_print.LinkColor = Color.MidnightBlue
    End Sub
#End Region

#Region "knjizno zaduzenje"
    Private Sub btnKnjiznoZaduzenje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKnjiznoZaduzenje.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntKnjizZaduzUlaz
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnKnjiznoZaduzenje.BackColor = Color.LightSteelBlue
        btnKnjiznoZaduzenje.Enabled = False

        _labHead.Text = Ispisi_label() + " : knjižno zaduženje"

        podesi_visinu()
        _mTableButtons.RowStyles.Item(7).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(7).Height

        ID_vrsta_dokumenta = vrsta_dokumenta.knjizno_zaduzenje_ulaz
    End Sub

    Private Sub linkKnjZaduz_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKnjZaduz_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 240

        Dim myControl As New cntKnjizZaduzUlaz_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : knjižno zaduženje" + " - pretraga"
        podesi_boje_linkova(panKnjZaduz_meni)
        linkKnjZaduz_search.BackColor = Color.GhostWhite
        linkKnjZaduz_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkKnjZaduz_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKnjZaduz_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntKnjizZaduzUlaz_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : knjižno zaduženje" + " - unos"
        podesi_boje_linkova(panKnjZaduz_meni)
        linkKnjZaduz_add.BackColor = Color.GhostWhite
        linkKnjZaduz_add.LinkColor = Color.MidnightBlue
    End Sub

    Private Sub linkKnjZaduz_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKnjZaduz_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati dokument")
                Exit Sub
            Else
                _knjzadU_broj = _lista.SelectedItems.Item(0).Text ' _lista.SelectedItems.Item(0).SubItems(1).Text
                selektuj_kz_ulaz(RTrim(_knjzadU_broj), Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntKnjizZaduzUlaz_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + " : knjižno zaduženje" + " - ažuriranje"
                podesi_boje_linkova(panKnjZaduz_meni)
                linkKnjZaduz_edit.BackColor = Color.GhostWhite
                linkKnjZaduz_edit.LinkColor = Color.MidnightBlue
            End If
        End If
    End Sub

    Private Sub linkKnjZaduz_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKnjZaduz_del.LinkClicked
        cntKnjizZaduzUlaz.myDelete()
    End Sub

    Private Sub linkKnjZaduz_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKnjZaduz_print.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next

        _mSpliter.SplitterDistance = 240
        Dim myControl As New cntKnjizOdobUlaz_print
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : knjižno odobrenje" + " - štampanje"
        podesi_boje_linkova(panKnjZaduz_meni)
        linkKnjZaduz_print.BackColor = Color.GhostWhite
        linkKnjZaduz_print.LinkColor = Color.MidnightBlue
    End Sub
#End Region

#Region "povracaj robe"
    Private Sub btnPovracajRobe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPovracajRobe.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntPovracaj_roba
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnPovracajRobe.BackColor = Color.LightSteelBlue
        btnPovracajRobe.Enabled = False

        _labHead.Text = Ispisi_label() + " : povraćaj robe"

        podesi_visinu()
        _mTableButtons.RowStyles.Item(9).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(9).Height

        ID_vrsta_dokumenta = vrsta_dokumenta.povracaj_robe
    End Sub

    Private Sub linkPovracajRobe_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPovracajRobe_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 240

        Dim myControl As New cntPovracaj_roba_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : povraćaj robe" + " - pretraga"
        podesi_boje_linkova(panPovracajRobe_meni)
        linkPovracajRobe_search.BackColor = Color.GhostWhite
        linkPovracajRobe_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkPovracajRobe_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPovracajRobe_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntPovracaj_roba_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : povraćaj robe" + " - unos"
        podesi_boje_linkova(panPovracajRobe_meni)
        linkPovracajRobe_add.BackColor = Color.GhostWhite
        linkPovracajRobe_add.LinkColor = Color.MidnightBlue
    End Sub

    Private Sub linkPovracajRobe_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPovracajRobe_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati dokument")
                Exit Sub
            Else
                _pov_robe_broj = _lista.SelectedItems.Item(0).Text ' _lista.SelectedItems.Item(0).SubItems(1).Text
                selektuj_povracaj_robe(RTrim(_pov_robe_broj), Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntPovracaj_roba_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + " : povraćaj robe" + " - ažuriranje"
                podesi_boje_linkova(panPovracajRobe_meni)
                linkPovracajRobe_edit.BackColor = Color.GhostWhite
                linkPovracajRobe_edit.LinkColor = Color.MidnightBlue
            End If
        End If
    End Sub

    Private Sub linkPovracajRobe_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPovracajRobe_del.LinkClicked
        cntPovracaj_roba.myDelete()
    End Sub

    Private Sub linkPovracajRobe_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPovracajRobe_print.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next

        _mSpliter.SplitterDistance = 240
        Dim myControl As New cntPovracaj_roba_print
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : povraćaj robe" + " - štampanje"
        podesi_boje_linkova(panPovracajRobe_meni)
        linkPovracajRobe_print.BackColor = Color.GhostWhite
        linkPovracajRobe_print.LinkColor = Color.MidnightBlue
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
