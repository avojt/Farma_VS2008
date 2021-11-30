Option Strict Off
Option Explicit On

Public Class cntMeniObrada_Izlaz
    Private _visina As Integer = 144

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntMeniObrada_Izlaz_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
        _mPanIntDosIzlaz_kontejn = panIntDostIzlaz_Kontejner
        _mPanIntDosIzlaz_meni = panIntDostIzlaz_meni
        _mLinkIntDosIzlaz_search = linkIntDostIzlaz_search

        _mPanKnjOdobIzlaz_kontejn = panKnjOdob_Kontejner
        _mPanKnjOdobIzlaz_meni = panKnjOdob_meni
        _mLinkKnjOdobIzlaz_search = linkKnjOdob_search

        _mPanKnjZaduzIzlaz_kontejn = panKnjZaduz_Kontejner
        _mPanKnjZaduzIzlaz_meni = panKnjZaduz_meni
        _mLinkKnjZaduzIzlaz_search = linkKnjZaduz_search

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

#Region "interne dostavnice - izlaz"
    Private Sub btnIntDost_izlaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntDost_izlaz.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntIntDostavIzlaz
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnIntDost_izlaz.BackColor = Color.LightSteelBlue
        btnIntDost_izlaz.Enabled = False

        _labHead.Text = Ispisi_label() + " : interna dostavnica (izlaz)"

        podesi_visinu()
        _mTableButtons.RowStyles.Item(1).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(1).Height

        ID_vrsta_dokumenta = vrsta_dokumenta.interna_dostavnica_izlaz
    End Sub

    Private Sub linkIntDostIzlaz_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkIntDostIzlaz_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 240
       
        Dim myControl As New cntIntDostavIzlaz_sreach
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()
       
        _labHead.Text = Ispisi_label() + " : interna dostavnica (izlaz)" + " - pretraga"
        podesi_boje_linkova(panIntDostIzlaz_meni)
        linkIntDostIzlaz_search.BackColor = Color.GhostWhite
        linkIntDostIzlaz_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkIntDostIzlaz_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkIntDostIzlaz_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntIntDostavIzlaz_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : interna dostavnica (izlaz)" + " - unos"
        podesi_boje_linkova(panIntDostIzlaz_meni)
        linkIntDostIzlaz_add.BackColor = Color.GhostWhite
        linkIntDostIzlaz_add.LinkColor = Color.MidnightBlue
    End Sub

    Private Sub linkIntDostIzlaz_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkIntDostIzlaz_edit.LinkClicked
        'If Not IsNothing(_lista) Then
        '    If _lista.SelectedItems.Count = 0 Then
        '        MsgBox("Prvo morate izabrati stavku")
        '        Exit Sub
        '    Else
        '        _int_dost_broj = _lista.SelectedItems.Item(0).Text ' _lista.SelectedItems.Item(0).SubItems(1).Text
        '        selektuj_intDost_izlaz(RTrim(_int_dost_broj), Selekcija.po_sifri)

        '        mdiMain.zatvori_kontrolu_desno()
        '        Dim myControl As New cntIntDostavIzlaz_edit
        '        myControl.Parent = mdiMain.splRadni.Panel2
        '        myControl.Dock = DockStyle.Fill
        '        myControl.Show()

        '        _labHead.Text = Ispisi_label() + " : interna dostavnica (izlaz)" + " - ažuriranje"
        '        podesi_boje_linkova(panIntDostIzlaz_meni)
        '        linkIntDostIzlaz_edit.BackColor = Color.GhostWhite
        '        linkIntDostIzlaz_edit.LinkColor = Color.MidnightBlue
        '    End If
        'End If
    End Sub

    Private Sub linkIntDostIzlaz_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkIntDostIzlaz_del.LinkClicked
        cntIntDostavIzlaz.myDelete()
    End Sub

    Private Sub linkIntDostIzlaz_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkIntDostIzlaz_print.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next

        _mSpliter.SplitterDistance = 240

        Dim myControl As New cntIntDostavIzlaz_print
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : interna dostavnica (izlaz)" + " - štampanje"
        podesi_boje_linkova(panIntDostIzlaz_meni)
        linkIntDostIzlaz_print.BackColor = Color.GhostWhite
        linkIntDostIzlaz_print.LinkColor = Color.MidnightBlue
    End Sub
#End Region

#Region "knjizno odobrenje - izlaz"
    Private Sub btnKnjiznoOdobrenje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKnjiznoOdobrenje.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntKnjizOdobIzlaz
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnKnjiznoOdobrenje.BackColor = Color.LightSteelBlue
        btnKnjiznoOdobrenje.Enabled = False

        _labHead.Text = Ispisi_label() + " : knjižno odobrenje (izlaz)"

        podesi_visinu()
        _mTableButtons.RowStyles.Item(3).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(3).Height

        ID_vrsta_dokumenta = vrsta_dokumenta.knjizno_odobrenje_izlaz
    End Sub

    Private Sub linkKnjOdob_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKnjOdob_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 240

        Dim myControl As New cntKnjizOdobIzlaz_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : knjižno odobrenje (izlaz)" + " - pretraga"
        podesi_boje_linkova(panKnjOdob_meni)
        linkKnjOdob_search.BackColor = Color.GhostWhite
        linkKnjOdob_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkKnjOdob_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKnjOdob_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntKnjizOdobIzlaz_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : knjižno odobrenje (izlaz)" + " - unos"
        podesi_boje_linkova(panKnjOdob_meni)
        linkKnjOdob_add.BackColor = Color.GhostWhite
        linkKnjOdob_add.LinkColor = Color.MidnightBlue
    End Sub

    Private Sub linkKnjOdob_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKnjOdob_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati stavku")
                Exit Sub
            Else
                _ko_iz_broj = _lista.SelectedItems.Item(0).Text ' _lista.SelectedItems.Item(0).SubItems(1).Text
                'selektuj_ko_izlaz(RTrim(_ko_iz_broj), Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntKnjizOdobIzlaz_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + " : knjižno odobrenje (izlaz)" + " - ažuriranje"
                podesi_boje_linkova(panKnjOdob_meni)
                linkKnjOdob_edit.BackColor = Color.GhostWhite
                linkKnjOdob_edit.LinkColor = Color.MidnightBlue
            End If
        End If
    End Sub

    Private Sub linkKnjOdob_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKnjOdob_del.LinkClicked
        cntKnjizOdobIzlaz.myDelete()
    End Sub

    Private Sub linkKnjOdob_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKnjOdob_print.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next

        _mSpliter.SplitterDistance = 240

        Dim myControl As New cntKnjizOdobIzlaz_print
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : knjižno odobrenje (izlaz)" + " - štampanje"
        podesi_boje_linkova(panKnjOdob_meni)
        linkKnjOdob_print.BackColor = Color.GhostWhite
        linkKnjOdob_print.LinkColor = Color.MidnightBlue
    End Sub

#End Region

#Region "knjizno zaduzenje - izlaz"
    Private Sub btnKnjiznoZaduzenje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKnjiznoZaduzenje.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntKnjizZaduzIzlaz
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnKnjiznoZaduzenje.BackColor = Color.LightSteelBlue
        btnKnjiznoZaduzenje.Enabled = False

        _labHead.Text = Ispisi_label() + " : knjižno zaduženje (izlaz)"

        podesi_visinu()
        _mTableButtons.RowStyles.Item(5).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(5).Height

        ID_vrsta_dokumenta = vrsta_dokumenta.knjizno_zaduzenje_izlaz
    End Sub

    Private Sub linkKnjZaduz_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKnjZaduz_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 240

        Dim myControl As New cntKnjizZaduzIzlaz_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : knjižno zaduženje (izlaz)" + " - pretraga"
        podesi_boje_linkova(panKnjZaduz_meni)
        linkKnjZaduz_search.BackColor = Color.GhostWhite
        linkKnjZaduz_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkKnjZaduz_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKnjZaduz_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntKnjizZaduzIzlaz_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : knjižno zaduženje (izlaz)" + " - unos"
        podesi_boje_linkova(panKnjZaduz_meni)
        linkKnjZaduz_add.BackColor = Color.GhostWhite
        linkKnjZaduz_add.LinkColor = Color.MidnightBlue
    End Sub

    Private Sub linkKnjZaduz_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKnjZaduz_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati stavku")
                Exit Sub
            Else
                _kz_iz_broj = _lista.SelectedItems.Item(0).Text ' _lista.SelectedItems.Item(0).SubItems(1).Text
                'selektuj_kz_izlaz(RTrim(_ko_iz_broj), Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntKnjizZaduzIzlaz_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + " : knjižno zaduženje (izlaz)" + " - ažuriranje"
                podesi_boje_linkova(panKnjZaduz_meni)
                linkKnjZaduz_edit.BackColor = Color.GhostWhite
                linkKnjZaduz_edit.LinkColor = Color.MidnightBlue
            End If
        End If
    End Sub

    Private Sub linkKnjZaduz_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKnjZaduz_del.LinkClicked
        cntKnjizZaduzIzlaz.myDelete()
    End Sub

    Private Sub linkKnjZaduz_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKnjZaduz_print.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next

        _mSpliter.SplitterDistance = 240

        Dim myControl As New cntKnjizZaduzIzlaz_print
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + " : knjižno zaduženje (izlaz)" + " - štampanje"
        podesi_boje_linkova(panKnjZaduz_meni)
        linkKnjZaduz_print.BackColor = Color.GhostWhite
        linkKnjZaduz_print.LinkColor = Color.MidnightBlue
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
