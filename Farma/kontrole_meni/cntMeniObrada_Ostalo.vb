Option Strict Off
Option Explicit On

Public Class cntMeniObrada_ostalo
    Private _visina As Integer = 182 ' 258

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntMeniObrada_ostalo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

        _mPanDnProm_kontejn = panDnProm_Kontejner
        _mPanDnProm_meni = panDnProm_meni
        _mLinkDnProm_search = linkDPromet_search

        _mPanIntPrenos_kontejn = panInterniPrenos_Kontejner
        _mPanIntPrenos_meni = panInterniPrenos_meni
        _mLinkIntPrenos_search = linkInterniPrenos_search

        _mPanPopis_kontejn = panPopis_Kontejner
        _mPanPopis_meni = panPopis_meni
        _mLinkPopis_search = linkPopis_search

        _mPanNivelacija_kontejn = panNivelacija_Kontejner
        _mPanNivelacija_meni = panNivelacija_meni
        _mLinkNivelacija_search = linkNivelacija_search

        _mPanTrebovanja_kontejn = panTreb_Kontejner
        _mPanTrebovanja_meni = panTreb_meni
        _mLinkTrebovanja_search = linkTreb_search

        _mPanMagIntPrenos_kontejn = panMagInterni_Kontejner
        _mPanMagIntPrenos_meni = panMagInterni_meni
        _mLinkMagIntPrenos_search = linkMagInterni_search

        _mTableButtons = tableButtons
    End Sub

    Private Sub podesi_visinu()
        With _mTableButtons
            .Height = _visina
            .RowStyles.Item(1).Height = 8
            .RowStyles.Item(3).Height = 8
            .RowStyles.Item(5).Height = 8
            .RowStyles.Item(7).Height = 8
            '.RowStyles.Item(9).Height = 8
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

#Region "dnevni promet"
    Private Sub btnDPromet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDPromet.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntDPromet
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnDPromet.BackColor = Color.LightSteelBlue
        btnDPromet.Enabled = False

        _labHead.Text = Ispisi_label() + My.Resources.text_dnevni_promet

        podesi_visinu()
        _mTableButtons.RowStyles.Item(1).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(1).Height

        ID_vrsta_dokumenta = 0
    End Sub

    Private Sub linkDPromet_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkDPromet_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 270

        Dim myControl As New cntDPromet_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_dnevni_promet + My.Resources.text_search
        podesi_boje_linkova(panDnProm_meni)
        linkDPromet_search.BackColor = Color.GhostWhite
        linkDPromet_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkDPromet_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkDPromet_print.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next

        _mSpliter.SplitterDistance = 270

        Dim myControl As New cntDPromet_print
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_dnevni_promet + My.Resources.text_print
        podesi_boje_linkova(panDnProm_meni)
        linkDPromet_print.BackColor = Color.GhostWhite
        linkDPromet_print.LinkColor = Color.MidnightBlue
    End Sub

#End Region

#Region "popis"
    Private Sub btnPopis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPopis.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntPopis
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnPopis.BackColor = Color.LightSteelBlue
        btnPopis.Enabled = False

        _labHead.Text = Ispisi_label() + " : popis"

        podesi_visinu()
        _mTableButtons.RowStyles.Item(3).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(3).Height

        ID_vrsta_dokumenta = 16
    End Sub

    Private Sub linkPopis_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPopis_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 240

        Dim myControl As New cntPopis_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : popis" + " - pretraga"
        podesi_boje_linkova(panPopis_meni)
        linkPopis_search.BackColor = Color.GhostWhite
        linkPopis_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkPopis_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPopis_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntPopis_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : popis" + " - unos"
        podesi_boje_linkova(panPopis_meni)
        linkPopis_add.BackColor = Color.GhostWhite
        linkPopis_add.LinkColor = Color.MidnightBlue
    End Sub

    Private Sub linkPopis_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPopis_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati stavku")
                Exit Sub
            Else
                _pop_broj = _lista.SelectedItems.Item(0).Text ' _lista.SelectedItems.Item(0).SubItems(1).Text
                selektuj_popis(RTrim(_pop_broj), Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntPopis_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + " : popis" + " - ažuriranje"
                podesi_boje_linkova(panPopis_meni)
                linkPopis_edit.BackColor = Color.GhostWhite
                linkPopis_edit.LinkColor = Color.MidnightBlue
            End If
        End If
    End Sub

    Private Sub linkPopis_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPopis_del.LinkClicked
        cntPopis.myDelete()
    End Sub

    Private Sub linkPopis_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPopis_print.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next

        _mSpliter.SplitterDistance = 240

        Dim myControl As New cntPopis_print
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : popis" + " - štampanje"
        podesi_boje_linkova(panPopis_meni)
        linkPopis_print.BackColor = Color.GhostWhite
        linkPopis_print.LinkColor = Color.MidnightBlue
    End Sub
#End Region

#Region "nivelacija"
    Private Sub btnNivelacija_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNivelacija.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntNivelacija
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnNivelacija.BackColor = Color.LightSteelBlue
        btnNivelacija.Enabled = False

        _labHead.Text = Ispisi_label() + My.Resources.text_nivelacija

        podesi_visinu()
        _mTableButtons.RowStyles.Item(5).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(5).Height

        ID_vrsta_dokumenta = 10
    End Sub

    Private Sub linkNivelacija_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkNivelacija_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 210

        Dim myControl As New cntNivelacija_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_nivelacija + My.Resources.text_search
        podesi_boje_linkova(panNivelacija_meni)
        linkNivelacija_search.BackColor = Color.GhostWhite
        linkNivelacija_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkNivelacija_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkNivelacija_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntNivelacija_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_nivelacija + My.Resources.text_add
        podesi_boje_linkova(panNivelacija_meni)
        linkNivelacija_add.BackColor = Color.GhostWhite
        linkNivelacija_add.LinkColor = Color.MidnightBlue
    End Sub

    Private Sub linkNivelacija_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkNivelacija_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati stavku")
                Exit Sub
            Else
                _nivelacije_broj = _lista.SelectedItems.Item(0).Text ' _lista.SelectedItems.Item(0).SubItems(1).Text
                selektuj_nivelaciju(RTrim(_nivelacije_broj), Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntNivelacija_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + My.Resources.text_nivelacija + My.Resources.text_edit
                podesi_boje_linkova(panNivelacija_meni)
                linkNivelacija_edit.BackColor = Color.GhostWhite
                linkNivelacija_edit.LinkColor = Color.MidnightBlue
            End If
        End If
    End Sub

    Private Sub linkNivelacija_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkNivelacija_del.LinkClicked
        cntNivelacija.myDelete()
    End Sub

    Private Sub linkNivelacija_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkNivelacija_print.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next

        _mSpliter.SplitterDistance = 210

        Dim myControl As New cntNivelacija_print
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_nivelacija + My.Resources.text_print
        podesi_boje_linkova(panNivelacija_meni)
        linkNivelacija_print.BackColor = Color.GhostWhite
        linkNivelacija_print.LinkColor = Color.MidnightBlue
    End Sub
#End Region

#Region "trebovanje"
    Private Sub btnTrebovanje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrebovanje.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntTrebovanje
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnTrebovanje.BackColor = Color.LightSteelBlue
        btnTrebovanje.Enabled = False

        _labHead.Text = Ispisi_label() + My.Resources.text_tebovanje ' " : trebovanje"

        podesi_visinu()
        _mTableButtons.RowStyles.Item(7).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(7).Height

        ID_vrsta_dokumenta = 17
    End Sub

    Private Sub linkTreb_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkTreb_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 210

        Dim myControl As New cntTrebovanje_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_tebovanje + My.Resources.text_search  '" : nivelacija" + " - pretraga"
        podesi_boje_linkova(panTreb_meni)
        linkTreb_search.BackColor = Color.GhostWhite
        linkTreb_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkTreb_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkTreb_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntTrebovanje_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_tebovanje + My.Resources.text_add  '" : nivelacija" + " - unos"
        podesi_boje_linkova(panTreb_meni)
        linkTreb_add.BackColor = Color.GhostWhite
        linkTreb_add.LinkColor = Color.MidnightBlue
    End Sub

    Private Sub linkTreb_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkTreb_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati stavku")
                Exit Sub
            Else
                _treb_broj = _lista.SelectedItems.Item(0).Text ' _lista.SelectedItems.Item(0).SubItems(1).Text
                selektuj_trebovanje(RTrim(_treb_broj), Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntTrebovanje_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + My.Resources.text_tebovanje + My.Resources.text_edit  '" : nivelacija" + " - ažuriranje"
                podesi_boje_linkova(panTreb_meni)
                linkTreb_edit.BackColor = Color.GhostWhite
                linkTreb_edit.LinkColor = Color.MidnightBlue
            End If
        End If
    End Sub

    Private Sub linkTreb_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkTreb_del.LinkClicked
        cntTrebovanje.myDelete()
    End Sub

    Private Sub linkTreb_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkTreb_print.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next

        _mSpliter.SplitterDistance = 210

        Dim myControl As New cntTrebovanje_print
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_tebovanje + My.Resources.text_print  '" : nivelacija" + " - štampanje"
        podesi_boje_linkova(panTreb_meni)
        linkTreb_print.BackColor = Color.GhostWhite
        linkTreb_print.LinkColor = Color.MidnightBlue
    End Sub
#End Region

#Region "magacin - interni prenos"
    Private Sub btnMagInterniPrenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMagInterniPrenos.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntMagIntPrenos
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnMagInterniPrenos.BackColor = Color.LightSteelBlue
        btnMagInterniPrenos.Enabled = False

        _labHead.Text = Ispisi_label() + My.Resources.text_mip

        podesi_visinu()
        _mTableButtons.RowStyles.Item(9).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(9).Height

        ID_vrsta_dokumenta = 18
    End Sub

    Private Sub linkMagInterni_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkMagInterni_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 240

        'Dim myControl As New cntMagIntPrenos_search
        'myControl.Parent = _mSpliter.Panel1
        'myControl.Dock = DockStyle.Fill
        'myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_mip + My.Resources.text_search  '" : nivelacija" + " - pretraga"
        podesi_boje_linkova(panMagInterni_meni)
        linkMagInterni_search.BackColor = Color.GhostWhite
        linkMagInterni_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkMagInterni_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkMagInterni_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntMagIntPrenos_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_mip + My.Resources.text_add
        podesi_boje_linkova(panMagInterni_meni)
        linkMagInterni_add.BackColor = Color.GhostWhite
        linkMagInterni_add.LinkColor = Color.MidnightBlue
    End Sub

    Private Sub linkMagInterni_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkMagInterni_edit.LinkClicked
        'If Not IsNothing(_lista) Then
        '    If _lista.SelectedItems.Count = 0 Then
        '        MsgBox("Prvo morate izabrati stavku")
        '        Exit Sub
        '    Else
        '        _mip_broj = _lista.SelectedItems.Item(0).Text ' _lista.SelectedItems.Item(0).SubItems(1).Text

        '        If _mip_broj Mod 2 = 0 Then
        '            MsgBox("Automatski generisani dokument ne možete menjati. Molimo Vas izaberite predhodni dokument sa neparnim brojem.")
        '            Exit Sub
        '        End If

        '        selektuj_mip(RTrim(_mip_broj), Selekcija.po_sifri)

        '        mdiMain.zatvori_kontrolu_desno()
        '        Dim myControl As New cntMagIntPrenos_edit
        '        myControl.Parent = mdiMain.splRadni.Panel2
        '        myControl.Dock = DockStyle.Fill
        '        myControl.Show()

        '        _labHead.Text = Ispisi_label() + My.Resources.text_tebovanje + My.Resources.text_edit  '" : nivelacija" + " - ažuriranje"
        '        podesi_boje_linkova(panMagInterni_meni)
        '        linkMagInterni_edit.BackColor = Color.GhostWhite
        '        linkMagInterni_edit.LinkColor = Color.MidnightBlue
        '    End If
        'End If
    End Sub

    Private Sub linkMagInterni_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkMagInterni_del.LinkClicked
        cntMagIntPrenos.myDelete()
    End Sub

    Private Sub linkMagInterni_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkMagInterni_print.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next

        _mSpliter.SplitterDistance = 240

        'Dim myControl As New cntMagIntPrenos_print
        'myControl.Parent = _mSpliter.Panel1
        'myControl.Dock = DockStyle.Fill
        'myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_mip + My.Resources.text_print  '" : nivelacija" + " - štampanje"
        podesi_boje_linkova(panMagInterni_meni)
        linkMagInterni_print.BackColor = Color.GhostWhite
        linkMagInterni_print.LinkColor = Color.MidnightBlue
    End Sub
#End Region

#Region "interni prenos"
    Private Sub btnInterniPrenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInterniPrenos.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntInterniPrenos
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnInterniPrenos.BackColor = Color.LightSteelBlue
        btnInterniPrenos.Enabled = False

        _labHead.Text = Ispisi_label() + My.Resources.text_int_prenos

        podesi_visinu()
        _mTableButtons.RowStyles.Item(11).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(11).Height

        ID_vrsta_dokumenta = 19
    End Sub

    Private Sub linkInterniPrenos_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkInterniPrenos_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 210

        Dim myControl As New cntInterniPrenos_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_int_prenos + My.Resources.text_search  '" : nivelacija" + " - pretraga"
        podesi_boje_linkova(panInterniPrenos_meni)
        linkInterniPrenos_search.BackColor = Color.GhostWhite
        linkInterniPrenos_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkInterniPrenos_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkInterniPrenos_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntInterniPrenos_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_int_prenos + My.Resources.text_add
        podesi_boje_linkova(panInterniPrenos_meni)
        linkInterniPrenos_add.BackColor = Color.GhostWhite
        linkInterniPrenos_add.LinkColor = Color.MidnightBlue
    End Sub

    Private Sub linkInterniPrenos_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkInterniPrenos_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati stavku")
                Exit Sub
            Else
                _int_pr_broj = _lista.SelectedItems.Item(0).Text ' _lista.SelectedItems.Item(0).SubItems(1).Text

                'selektuj_interni_prenos(RTrim(_int_pr_broj), Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntInterniPrenos_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + My.Resources.text_int_prenos + My.Resources.text_edit  '" : nivelacija" + " - ažuriranje"
                podesi_boje_linkova(panInterniPrenos_meni)
                linkInterniPrenos_edit.BackColor = Color.GhostWhite
                linkInterniPrenos_edit.LinkColor = Color.MidnightBlue
            End If
        End If
    End Sub

    Private Sub linkInterniPrenos_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkInterniPrenos_del.LinkClicked
        cntInterniPrenos.myDelete()
    End Sub

    Private Sub linkInterniPrenos_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkInterniPrenos_print.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next

        _mSpliter.SplitterDistance = 210

        Dim myControl As New cntInterniPrenos_print
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_int_prenos + My.Resources.text_print
        podesi_boje_linkova(panInterniPrenos_meni)
        linkInterniPrenos_print.BackColor = Color.GhostWhite
        linkInterniPrenos_print.LinkColor = Color.MidnightBlue
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