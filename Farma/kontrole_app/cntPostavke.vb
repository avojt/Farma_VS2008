Public Class cntPostavke

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region "pdv"
    Private Sub picPDV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPDV.Click
        mdiMain.zatvori_kontrolu_desno()
        'mdiMain.zatvori_kontrolu_levo()

        Dim mControl1 As New cntPDV
        mControl1.Parent = mdiMain.splGlavni.Panel2
        mControl1.Dock = DockStyle.Fill
        mControl1.Show()
    End Sub

    Private Sub linkPDV_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPDV.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        'mdiMain.zatvori_kontrolu_levo()

        Dim mControl1 As New cntPDV
        mControl1.Parent = mdiMain.splGlavni.Panel2
        mControl1.Dock = DockStyle.Fill
        mControl1.Show()
    End Sub
#End Region

#Region "partneri"
    Private Sub picPartneri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPartneri.Click
        mdiMain.zatvori_kontrolu_desno()
        'mdiMain.zatvori_kontrolu_levo()

        Dim mControl1 As New cntPartneri
        mControl1.Parent = mdiMain.splGlavni.Panel2
        mControl1.Dock = DockStyle.Fill
        mControl1.Show()
    End Sub

    Private Sub linkPartneri_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPartneri.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        'mdiMain.zatvori_kontrolu_levo()

        Dim mControl1 As New cntPartneri
        mControl1.Parent = mdiMain.splGlavni.Panel2
        mControl1.Dock = DockStyle.Fill
        mControl1.Show()
    End Sub

#End Region

#Region "odlozeno"
    Private Sub picOdlozeno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picOdlozeno.Click
        mdiMain.zatvori_kontrolu_desno()
        'mdiMain.zatvori_kontrolu_levo()

        Dim mControl1 As New cntOdlozeno
        mControl1.Parent = mdiMain.splGlavni.Panel2
        mControl1.Dock = DockStyle.Fill
        mControl1.Show()
    End Sub

    Private Sub linkOdlozeno_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkOdlozeno.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        'mdiMain.zatvori_kontrolu_levo()

        Dim mControl1 As New cntOdlozeno
        mControl1.Parent = mdiMain.splGlavni.Panel2
        mControl1.Dock = DockStyle.Fill
        mControl1.Show()
    End Sub

#End Region

#Region "kategorije"
    Private Sub picKategorije_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picVrsteArtikla.Click
        mdiMain.zatvori_kontrolu_desno()
        'mdiMain.zatvori_kontrolu_levo()

        Dim mControl1 As New cntKategorije
        mControl1.Parent = mdiMain.splGlavni.Panel2
        mControl1.Dock = DockStyle.Fill
        mControl1.Show()
    End Sub

    Private Sub linkKategorije_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkVrsteArtikla.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        'mdiMain.zatvori_kontrolu_levo()

        Dim mControl1 As New cntKategorije
        mControl1.Parent = mdiMain.splGlavni.Panel2
        mControl1.Dock = DockStyle.Fill
        mControl1.Show()
    End Sub
#End Region

#Region "sifre placanja"
    Private Sub picSifrePlacanja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSifrePlacanja.Click
        mdiMain.zatvori_kontrolu_desno()
        'mdiMain.zatvori_kontrolu_levo()

        'Dim mControl1 As New cntSeme
        'mControl1.Parent = mdiMain.SplitContainer1.Panel2
        'mControl1.Dock = DockStyle.Fill
        'mControl1.Show()
    End Sub

    Private Sub linkSifrePlacanja_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkSifrePlacanja.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        'mdiMain.zatvori_kontrolu_levo()

        'Dim mControl1 As New cntSeme
        'mControl1.Parent = mdiMain.SplitContainer1.Panel2
        'mControl1.Dock = DockStyle.Fill
        'mControl1.Show()

    End Sub
#End Region

#Region "seme"
    Private Sub picSeme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSeme.Click
        mdiMain.zatvori_kontrolu_desno()
        'mdiMain.zatvori_kontrolu_levo()

        Dim mControl1 As New cntSeme
        mControl1.Parent = mdiMain.splGlavni.Panel2
        mControl1.Dock = DockStyle.Fill
        mControl1.Show()

    End Sub

    Private Sub linkSeme_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkSeme.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        'mdiMain.zatvori_kontrolu_levo()

        Dim mControl1 As New cntSeme
        mControl1.Parent = mdiMain.splGlavni.Panel2
        mControl1.Dock = DockStyle.Fill
        mControl1.Show()
    End Sub
#End Region

#Region "Kontni Plan"
    Private Sub picKontniPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picKontniPlan.Click
        mdiMain.zatvori_kontrolu_desno()
        'mdiMain.zatvori_kontrolu_levo()

        Dim mControl1 As New cntKontniPlan
        mControl1.Parent = mdiMain.splGlavni.Panel2
        mControl1.Dock = DockStyle.Fill
        mControl1.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        'mdiMain.zatvori_kontrolu_levo()

        Dim mControl1 As New cntKontniPlan
        mControl1.Parent = mdiMain.splGlavni.Panel2
        mControl1.Dock = DockStyle.Fill
        mControl1.Show()
    End Sub
#End Region


    Private Sub btnAlati_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlati.Click
        'cntMFarmaPostavke.postavi_panel(Imena.tabele.rm_magacini.ToString)
        mdiMain.zatvori_kontrolu_desno()
        mdiMain.zatvori_kontrolu_levo()

        Dim myControl As New cntAlati
        myControl.Parent = mdiMain.splGlavni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()
    End Sub

#Region "Organizacione jedinice"
    Private Sub linkOJ_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkOJ.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        'mdiMain.zatvori_kontrolu_levo()

        Dim myControl As New cntOJ
        myControl.Parent = mdiMain.splGlavni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()
    End Sub

    Private Sub picOJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picOJ.Click
        mdiMain.zatvori_kontrolu_desno()
        'mdiMain.zatvori_kontrolu_levo()

        Dim myControl As New cntOJ
        myControl.Parent = mdiMain.splGlavni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()
    End Sub
#End Region

#Region "naselja"
    Private Sub picNaselja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picNaselja.Click
        _tab = Imena.tabele.app_gradovi.ToString
        mdiMain.zatvori_kontrolu_desno()
        'mdiMain.zatvori_kontrolu_levo()

        Dim myControl As New cntNaselja
        myControl.Parent = mdiMain.splGlavni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()
    End Sub

    Private Sub linkGradovi_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkGradovi.LinkClicked
        _tab = Imena.tabele.app_gradovi.ToString
        mdiMain.zatvori_kontrolu_desno()
        'mdiMain.zatvori_kontrolu_levo()

        Dim myControl As New cntNaselja
        myControl.Parent = mdiMain.splGlavni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()
    End Sub

#End Region

#Region "grupe artikla"
    Private Sub picGrupeArtikla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picGrupeArtikla.Click
        mdiMain.zatvori_kontrolu_desno()
        'mdiMain.zatvori_kontrolu_levo()

        Dim myControl As New cntGrupeArt
        myControl.Parent = mdiMain.splGlavni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()
    End Sub

    Private Sub linkGrupeArtikla_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkGrupeArtikla.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        'mdiMain.zatvori_kontrolu_levo()

        Dim myControl As New cntGrupeArt
        myControl.Parent = mdiMain.splGlavni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()
    End Sub
#End Region

    Private Sub picJKL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picJKL.Click
        _tab = Imena.tabele.app_jkl.ToString
        mdiMain.zatvori_kontrolu_desno()
        'mdiMain.zatvori_kontrolu_levo()

        Dim myControl As New cntNaselja
        myControl.Parent = mdiMain.splGlavni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()
    End Sub

End Class
