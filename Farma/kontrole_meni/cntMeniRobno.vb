Option Strict Off
Option Explicit On

Public Class cntMeniRobno
    Private _visina As Integer = 182

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntMeniRobno_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()

        If Not _povratak Then
            _korak_nazad.SetValue(Me.Name.ToString, zadnji_zapis(_korak_nazad))
            _korak_labHead.SetValue(Me.Name.ToString, zadnji_zapis(_korak_labHead))
        End If
        _labHead.Text = Ispisi_label()
        _povratak = False
    End Sub

    Private Sub pocetak()
        panGlavni.Height = 226
        podesi_kontrole()
        podesi_visinu()
        podesi_boje()
    End Sub

    Private Sub podesi_kontrole()
        _mTableButtons = tableButtons

        _mPanUlazRobe_kontejn = panUlazRobe_Kontejner
        _mPanUlazRobe_meni = panUlazRobe_meni
        _mLinkUlazRobe_search = linkUlazniDok_search
        _mLinkUlazRobe_edit = linkUlazniDok_edit

        _mPanIzlazRobe_kontejn = panIzlazRobe_Kontejner
        _mPanIzlazRobe_meni = panIzlazRobe_meni
        _mLinkIzlazRobe_search = linkIzlazniDok_search
        _mLinkIzlazRobe_edit = linkIzlazniDok_edit

    End Sub

    Private Sub podesi_visinu()
        With _mTableButtons
            .Height = _visina
            .RowStyles.Item(1).Height = 8
            .RowStyles.Item(3).Height = 8
            .RowStyles.Item(5).Height = 8
            .RowStyles.Item(7).Height = 8
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
        Dim tControl As Control
        For Each tControl In _panel.Controls
            If tControl.Name Like "btn*" Then
                tControl.Enabled = False
            End If
        Next
    End Sub

    Shared Sub enable_buttons(ByVal _panel As TableLayoutPanel)
        Dim tControl As Control
        For Each tControl In _panel.Controls
            If tControl.Name Like "btn*" Then
                tControl.Enabled = True
            End If
        Next
    End Sub

#Region "ulaz robe"

    Private Sub btnUlaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUlaz.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl As New cntRobno_ulaz
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _mSpliter.SplitterDistance = 240

        Dim myControl1 As New cntRobno_ulaz_search
        myControl1.Parent = _mSpliter.Panel1
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnUlaz.BackColor = Color.LightSteelBlue
        btnUlaz.Enabled = False
        'btnUlaz.FlatStyle = FlatStyle.Standard '!!!

        _labHead.Text = Ispisi_label() + My.Resources.text_add

        podesi_visinu()
        _mTableButtons.RowStyles.Item(1).Height = 112
        panGlavni.Height = _visina - 8 + _mTableButtons.RowStyles.Item(1).Height + 46

        ID_vrsta_dokumenta = 0 ' vrsta_dokumenta.kalkulacija

    End Sub

    Private Sub linkUlazniDok_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkUlazniDok_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 240

        Dim myControl As New cntRobno_ulaz_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_robno + My.Resources.text_search  ' " : kalkulacija" + " - pretraga"
        podesi_boje_linkova(panUlazRobe_meni)
        linkUlazniDok_search.BackColor = Color.GhostWhite
        linkUlazniDok_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkUlazniDok_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkUlazniDok_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntRobno_ulaz_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()
        '***
        _labHead.Text = Ispisi_label() + My.Resources.text_robno + My.Resources.text_add
        podesi_boje_linkova(panUlazRobe_meni)
        linkUlazniDok_add.BackColor = Color.GhostWhite
        linkUlazniDok_add.LinkColor = Color.MidnightBlue
        disable_linkove(panUlazRobe_meni)
        disable_buttons(tableButtons)
    End Sub

    Private Sub linkUlazniDok_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkUlazniDok_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati kalkulaciju")
                Exit Sub
            Else
                _dok_broj = _lista.SelectedItems.Item(0).Text ' _lista.SelectedItems.Item(0).SubItems(1).Text
                selektuj_dokument_ul(RTrim(_dok_broj), Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntRobno_ulaz_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + My.Resources.text_robno + My.Resources.text_edit
                podesi_boje_linkova(panUlazRobe_meni)
                linkUlazniDok_edit.BackColor = Color.GhostWhite
                linkUlazniDok_edit.LinkColor = Color.MidnightBlue
                disable_linkove(panUlazRobe_meni)
                disable_buttons(tableButtons)
            End If
        End If
    End Sub

    Private Sub linkUlazniDok_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkUlazniDok_del.LinkClicked
        cntRobno_ulaz.myDelete()
    End Sub

    Private Sub linkUlazniDok_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkUlazniDok_print.LinkClicked
        cntRobno_ulaz_search.prn()
    End Sub
#End Region

#Region "Izlaz robe"

    Private Sub btnIzlaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzlaz.Click
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntRobno_izlaz
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _mSpliter.SplitterDistance = 240

        Dim myControl1 As New cntRobno_izlaz_search
        myControl1.Parent = _mSpliter.Panel1
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnIzlaz.BackColor = Color.LightSteelBlue
        btnIzlaz.Enabled = False
        btnIzlaz.FlatStyle = FlatStyle.Standard '!!!

        _labHead.Text = Ispisi_label() + My.Resources.text_add

        podesi_visinu()
        _mTableButtons.RowStyles.Item(3).Height = 112
        panGlavni.Height = _visina - 8 + _mTableButtons.RowStyles.Item(3).Height + 46

        ID_vrsta_dokumenta = 0
    End Sub

    Private Sub linkIzlazniDok_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkIzlazniDok_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 240

        Dim myControl As New cntRobno_izlaz_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_robno + My.Resources.text_search  ' " : kalkulacija" + " - pretraga"
        podesi_boje_linkova(panIzlazRobe_meni)
        linkIzlazniDok_search.BackColor = Color.GhostWhite
        linkIzlazniDok_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkIzlazniDok_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkIzlazniDok_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntRobno_izlaz_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()
        '***
        _labHead.Text = Ispisi_label() + My.Resources.text_robno + My.Resources.text_add
        podesi_boje_linkova(panIzlazRobe_meni)
        linkIzlazniDok_add.BackColor = Color.GhostWhite
        linkIzlazniDok_add.LinkColor = Color.MidnightBlue
        disable_linkove(panIzlazRobe_meni)
        disable_buttons(tableButtons)
    End Sub

    Private Sub linkIzlazniDok_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkIzlazniDok_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati kalkulaciju")
                Exit Sub
            Else
                _dok_broj = _lista.SelectedItems.Item(0).Text ' _lista.SelectedItems.Item(0).SubItems(1).Text
                selektuj_dokument_izl(RTrim(_dok_broj), Selekcija.po_sifri)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntRobno_izlaz_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + My.Resources.text_robno + My.Resources.text_edit
                podesi_boje_linkova(panIzlazRobe_meni)
                linkIzlazniDok_edit.BackColor = Color.GhostWhite
                linkIzlazniDok_edit.LinkColor = Color.MidnightBlue
                disable_linkove(panIzlazRobe_meni)
                disable_buttons(tableButtons)
            End If
        End If
    End Sub

    Private Sub linkIzlazniDok_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkIzlazniDok_del.LinkClicked
        cntRobno_izlaz.myDelete()
    End Sub

    Private Sub linkIzlazniDok_print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkIzlazniDok_print.LinkClicked
        cntRobno_izlaz_search.prn()
    End Sub

#End Region

    Private Sub btnOstalo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOstalo.Click
        mdiMain.zatvori_kontrolu_levo()

        Dim myControl As New cntMeniObrada_ostalo
        myControl.Parent = mdiMain.splGlavni.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()
    End Sub

    Private Sub btnIzvestaji_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzvestaji.Click
        mdiMain.zatvori_kontrolu_levo()

        Dim myControl As New cntMeniIzvestaji
        myControl.Parent = mdiMain.splGlavni.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()
    End Sub

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
