Public Class cntMeniStart

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntMeniStart_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()
        'podesi_boje()

        If Not _povratak Then
            _korak_nazad.SetValue(Me.Name.ToString, zadnji_zapis(_korak_nazad))
            _korak_labHead.SetValue(Me.Name.ToString, zadnji_zapis(_korak_labHead))
        End If
        _povratak = False
        _labHead.Text = Ispisi_label()
        _spRadni.Panel2.BackgroundImage = My.Resources.LaST__Cobalt__Books
    End Sub

    Private Sub pocetak()
        _mTableButtons = tableButtons
        With _mTableButtons
            .Height = 144
            .RowStyles.Item(1).Height = 8
            .RowStyles.Item(3).Height = 8
        End With
    End Sub

    Private Sub podesi_boje()
        Dim tControl As Control
        For Each tControl In tableButtons.Controls
            tControl.BackColor = Color.MintCream
            tControl.Enabled = True
        Next
    End Sub

    Private Sub btnRobno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRobno.Click
        mdiMain.zatvori_kontrolu_levo()

        Dim mControl As New cntMeniRobno
        mControl.Parent = mdiMain.splGlavni.Panel1
        mControl.Dock = DockStyle.Fill
        mControl.Show()
        _spRadni.Panel2.BackgroundImage = My.Resources.Dossiers_Panneau_de_configuration
    End Sub

    Private Sub btnFinansijsko_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinansijsko.Click
        mdiMain.zatvori_kontrolu_levo()

        Dim mControl As New cntMeniFinansijsko
        mControl.Parent = mdiMain.splGlavni.Panel1
        mControl.Dock = DockStyle.Fill
        mControl.Show()
        _spRadni.Panel2.BackgroundImage = My.Resources.Pan_setting

    End Sub

    Private Sub btnMaticni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaticni.Click
        mdiMain.zatvori_kontrolu_levo()

        Dim myControl As New cntMeniMaticniPodaci
        myControl.Parent = mdiMain.splGlavni.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()
        _spRadni.Panel2.BackgroundImage = My.Resources.Control_Panel_Alt
    End Sub

    Private Sub btnProizvodnja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProizvodnja.Click
        mdiMain.zatvori_kontrolu_levo()

        Dim mControl As New cntMeniProizvodnja
        mControl.Parent = mdiMain.splGlavni.Panel1
        mControl.Dock = DockStyle.Fill
        mControl.Show()
        _spRadni.Panel2.BackgroundImage = My.Resources.Dossiers_Config_
    End Sub
End Class
