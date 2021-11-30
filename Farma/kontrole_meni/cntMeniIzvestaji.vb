Option Strict Off
Option Explicit On

Public Class cntMeniIzvestaji

    Private _visina As Integer = 144

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntMeniIzvestaji_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

        _mPanPromet_kontejn = panPromet_Kontejner
        _mPanPromet_meni  = panPromet_meni
        _mLinkKartica = linkKartica
        _mLinkMagacin = linkMagacin
        _mLinkNeslaganje = linkNeslaganje

        _mPanSpecifikacije_kontejn = panSpecifikacije_Kontejner
        _mPanSpecifikacije_meni = panSpecifikacije_meni
        _mLinkSpec_ulaz = linkAnaliza_ulaz
        _mLinkSpec_izlaz = linkAnaliza_izlaz
        _mLinkSpec_nivelacije = linkSpec_nivelacije

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

#Region "artikli"
    Private Sub btnArtikliPromet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArtikliPromet.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntIzvestaji
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnArtikliPromet.BackColor = Color.LightSteelBlue
        btnArtikliPromet.Enabled = False

        _labHead.Text = Ispisi_label() + My.Resources.text_artikli_promet

        podesi_visinu()
        _mTableButtons.RowStyles.Item(1).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(1).Height

        ID_vrsta_dokumenta = 0
    End Sub

    Private Sub linkKartica_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKartica.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 335

        Dim myControl As New cntIzvestaji_kartica
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_artikli_promet + My.Resources.text_search
        podesi_boje_linkova(panPromet_meni)
        linkKartica.BackColor = Color.GhostWhite
        linkKartica.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkMagacin_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkMagacin.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 325

        Dim myControl As New cntIzvestaji_stanje
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_artikli_promet + My.Resources.text_search
        podesi_boje_linkova(panPromet_meni)
        linkMagacin.BackColor = Color.GhostWhite
        linkMagacin.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkNeslaganje_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkNeslaganje.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 335

        Dim myControl As New cntIzvestaji_neslaganja
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_artikli_promet + My.Resources.text_search
        podesi_boje_linkova(panPromet_meni)
        linkNeslaganje.BackColor = Color.GhostWhite
        linkNeslaganje.ForeColor = Color.MidnightBlue
    End Sub
#End Region

#Region "specifikacije"
    Private Sub btnSpecifikacije_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpecifikacije.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntSpecifikacije
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnSpecifikacije.BackColor = Color.LightSteelBlue
        btnSpecifikacije.Enabled = False

        _labHead.Text = Ispisi_label() + My.Resources.text_spec_ulaz

        podesi_visinu()
        _mTableButtons.RowStyles.Item(3).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(3).Height

        ID_vrsta_dokumenta = 0
    End Sub

    Private Sub linkSpecifikacija_ulaza_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkSpecifikacija_ulaza.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next

        Dim myControl As New cntSpecifikacija_ulaza
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _mSpliter.SplitterDistance = 325

        _labHead.Text = Ispisi_label() + My.Resources.text_spec_ulaz
        podesi_boje_linkova(panSpecifikacije_meni)
        linkSpecifikacija_ulaza.BackColor = Color.GhostWhite
        linkSpecifikacija_ulaza.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkSpecifikacija_izlaza_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkSpecifikacija_izlaza.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next

        Dim myControl As New cntSpecifikacija_izlaza
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _mSpliter.SplitterDistance = 325

        _labHead.Text = Ispisi_label() + My.Resources.text_spec_izlaz
        podesi_boje_linkova(panSpecifikacije_meni)
        linkSpecifikacija_izlaza.BackColor = Color.GhostWhite
        linkSpecifikacija_izlaza.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkSpec_nivelacije_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkSpec_nivelacije.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 325

        Dim myControl As New cntSpecifikacije_nivelacije
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_specifikacije + My.Resources.text_nivelacija
        podesi_boje_linkova(panSpecifikacije_meni)
        linkSpec_nivelacije.BackColor = Color.GhostWhite
        linkSpec_nivelacije.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkLager_lista_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLager_lista.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 325

        Dim myControl As New cntSpecifikacija_lager
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_lager
        podesi_boje_linkova(panSpecifikacije_meni)
        linkLager_lista.BackColor = Color.GhostWhite
        linkLager_lista.ForeColor = Color.MidnightBlue
    End Sub

#End Region

#Region "analize"
    Private Sub btnAnalize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnalize.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntAnaliza
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnAnalize.BackColor = Color.LightSteelBlue
        btnAnalize.Enabled = False

        _labHead.Text = Ispisi_label() + My.Resources.text_specifikacije

        podesi_visinu()
        _mTableButtons.RowStyles.Item(5).Height = 112
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(5).Height

        ID_vrsta_dokumenta = 0
    End Sub

    Private Sub linkAnaliza_ulaz_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkAnaliza_ulaz.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 325

        Dim myControl As New cntAnaliza_ulaz
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_specifikacije + My.Resources.text_spec_ulaz
        podesi_boje_linkova(panAnaliza_meni)
        linkAnaliza_ulaz.BackColor = Color.GhostWhite
        linkAnaliza_ulaz.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkAnaliza_izlaz_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkAnaliza_izlaz.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 325

        Dim myControl As New cntAnaliza_izlaz
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_specifikacije + My.Resources.text_spec_izlaz
        podesi_boje_linkova(panAnaliza_meni)
        linkAnaliza_izlaz.BackColor = Color.GhostWhite
        linkAnaliza_izlaz.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkAnaliza_lager_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkAnaliza_lager.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 325

        Dim myControl As New cntAnaliza_lagera
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_specifikacije + My.Resources.text_lager
        podesi_boje_linkova(panAnaliza_meni)
        linkAnaliza_lager.BackColor = Color.GhostWhite
        linkAnaliza_lager.ForeColor = Color.MidnightBlue
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
