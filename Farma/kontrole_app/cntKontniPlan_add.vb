Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class cntKontniPlan_add

#Region "dekleracija"

    Private _pocetak As Boolean = True
    Private _strukturna As Boolean = False

#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntKontniPlan_add_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'If _ima_promena Then
        '    If MsgBox("Načinili ste promene. Dali želite da ih snimite?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '        snimi()
        '    End If
        'End If

        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntKontniPlan
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _mSpliter.SplitterDistance = 180

        Dim myControl1 As New cntKontniPlan_search
        myControl1.Parent = _mSpliter.Panel1
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_konta + My.Resources.text_search
        cntMeniMaticniPodaci.podesi_boje_linkova(_mPanKonta_meni)
        _mLinkKonta_search.BackColor = Color.GhostWhite
        _mLinkKonta_search.ForeColor = Color.MidnightBlue
        cntMeniMaticniPodaci.enable_linkove(_mPanKonta_meni)
    End Sub

    Private Sub cntKontniPlan_add_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tlbMain.Dock = DockStyle.Fill
        pocetak()
    End Sub

    Private Sub pocetak()

        _pocetak = True

        popuni_vrstu_analitike()
        popuni_vrstu_subanalitike()
        popuni_vrstu_A_P()
        popuni_vrstu_B_V()

        txtNaziv.Text = ""
        txtMesto_troska.Text = ""
        txtNivo_poc_stanja.Text = ""
        txtNivo_zatvaranja.Text = ""
        txtSifra.Text = ""  'Nadji_rb(Imena.tabele.app_partneri.ToString, 1)
        txtTip.Text = ""

        datVaziDo.Value = CDate("01.01.2099")

        chkDevizno.CheckState = CheckState.Unchecked
        chkDozvoljeno.CheckState = CheckState.Unchecked
        chkIma_analitiku.CheckState = CheckState.Unchecked
        chkIspravka.CheckState = CheckState.Unchecked
        chkPasiviziran.CheckState = CheckState.Unchecked
        chkPocetno_stanje.CheckState = CheckState.Unchecked

        _pocetak = False

    End Sub

    Private Sub popuni_vrstu_analitike()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbVrsta_analitike.Items.Clear()
        cmbVrsta_analitike.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.fn_vrsta_analitike.* from dbo.fn_vrsta_analitike"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbVrsta_analitike.Items.Add(DR.Item("Vrsta_Analitike_Sifra"))
            Loop
            DR.Close()
        End If
        If cmbVrsta_analitike.Items.Count > 0 Then
            cmbVrsta_analitike.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_vrstu_subanalitike()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        'Dim DR As SqlDataReader

        cmbVrsta_subanalitike.Items.Clear()
        cmbVrsta_subanalitike.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            'With CM
            '    .Connection = CN
            '    .CommandType = CommandType.Text
            '    .CommandText = "select dbo.app_opstine.* from dbo.app_opstine"
            '    DR = .ExecuteReader
            'End With
            'Do While DR.Read
            'cmbVrsta_subanalitike.Items.Add(DR.Item("opstine_naziv"))
            'Loop
            'DR.Close()
        End If
        If cmbVrsta_subanalitike.Items.Count > 0 Then
            cmbVrsta_subanalitike.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_vrstu_A_P()
        
        cmbAkt_Pas.Items.Clear()
        cmbAkt_Pas.Items.Add("")
        cmbAkt_Pas.Items.Add("A")
        cmbAkt_Pas.Items.Add("P")

        If cmbAkt_Pas.Items.Count > 0 Then
            cmbAkt_Pas.SelectedIndex = 0
        End If
       
    End Sub

    Private Sub popuni_vrstu_B_V()

        cmbBil_Vanbil.Items.Clear()
        cmbBil_Vanbil.Items.Add("")
        cmbBil_Vanbil.Items.Add("B")
        cmbBil_Vanbil.Items.Add("V")

        If cmbBil_Vanbil.Items.Count > 0 Then
            cmbBil_Vanbil.SelectedIndex = 0
        End If

    End Sub

    Private Sub txtSifra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSifra.KeyPress
        If e.KeyChar = Chr(13) Then
            txtNaziv.Select()
        End If
    End Sub
    Private Sub txtSifra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSifra.TextChanged
        If Not _pocetak Then
            If Not jesu_cifre(txtSifra.Text) Then
                txtSifra.BackColor = Color.LightPink
            Else
                txtSifra.BackColor = Color.GhostWhite
            End If
        End If
    End Sub

    Private Sub txtNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNaziv.KeyPress
        If e.KeyChar = Chr(13) Then
            chkDozvoljeno.Select()
        End If
    End Sub

    Private Sub chkDozvoljeno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDozvoljeno.CheckedChanged
        chkDevizno.Select()
    End Sub
    Private Sub chkDozvoljeno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkDozvoljeno.KeyPress
        If e.KeyChar = Chr(13) Then
            chkDevizno.Select()
        End If
    End Sub

    Private Sub chkDevizno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDevizno.CheckedChanged
        txtTip.Select()
    End Sub
    Private Sub chkDevizno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkDevizno.KeyPress
        If e.KeyChar = Chr(13) Then
            txtTip.Select()
        End If
    End Sub

    Private Sub txtTip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTip.KeyPress
        If e.KeyChar = Chr(13) Then
            chkIma_analitiku.Select()
        End If
    End Sub

    Private Sub chkIma_analitiku_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIma_analitiku.CheckedChanged
        cmbVrsta_analitike.Select()
    End Sub
    Private Sub chkIma_analitiku_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkIma_analitiku.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbVrsta_analitike.Select()
        End If
    End Sub

    Private Sub cmbVrsta_analitike_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbVrsta_analitike.DropDownClosed
        cmbVrsta_subanalitike.Select()
    End Sub
    Private Sub cmbVrsta_analitike_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbVrsta_analitike.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbVrsta_subanalitike.Select()
        End If
    End Sub

    Private Sub cmbVrsta_subanalitike_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbVrsta_subanalitike.DropDownClosed
        txtMesto_troska.Select()
    End Sub
    Private Sub cmbVrsta_subanalitike_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbVrsta_subanalitike.KeyPress
        If e.KeyChar = Chr(13) Then
            txtMesto_troska.Select()
        End If
    End Sub

    Private Sub txtMesto_troska_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMesto_troska.KeyPress
        If e.KeyChar = Chr(13) Then
            chkPocetno_stanje.Select()
        End If
    End Sub

    Private Sub chkPocetno_stanje_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPocetno_stanje.CheckedChanged
        txtNivo_poc_stanja.Select()
    End Sub
    Private Sub chkPocetno_stanje_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkPocetno_stanje.KeyPress
        If e.KeyChar = Chr(13) Then
            txtNivo_poc_stanja.Select()
        End If
    End Sub

    Private Sub txtNivo_poc_stanja_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNivo_poc_stanja.KeyPress
        If e.KeyChar = Chr(13) Then
            txtNivo_zatvaranja.Select()
        End If
    End Sub

    Private Sub txtNivo_zatvaranja_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNivo_zatvaranja.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbAkt_Pas.Select()
        End If
    End Sub

    Private Sub cmbAkt_Pas_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAkt_Pas.DropDownClosed
        cmbBil_Vanbil.Select()
    End Sub
    Private Sub cmbAkt_Pas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbAkt_Pas.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbBil_Vanbil.Select()
        End If
    End Sub

    Private Sub cmbBil_Vanbil_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBil_Vanbil.DropDownClosed
        datVaziDo.Select()
    End Sub
    Private Sub cmbBil_Vanbil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbBil_Vanbil.KeyPress
        If e.KeyChar = Chr(13) Then
            datVaziDo.Select()
        End If
    End Sub

    Private Sub datVaziDo_CloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles datVaziDo.CloseUp
        chkIspravka.Select()
    End Sub
    Private Sub datVaziDo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datVaziDo.KeyPress
        If e.KeyChar = Chr(13) Then
            chkIspravka.Select()
        End If
    End Sub

    Private Sub chkIspravka_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIspravka.CheckedChanged
        chkPasiviziran.Select()
    End Sub
    Private Sub chkIspravka_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkIspravka.KeyPress
        If e.KeyChar = Chr(13) Then
            chkPasiviziran.Select()
        End If
    End Sub

    Private Sub chkPasiviziran_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPasiviziran.CheckedChanged
        btnSnimi.Select()
    End Sub
    Private Sub chkPasiviziran_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkPasiviziran.KeyPress
        If e.KeyChar = Chr(13) Then
            btnSnimi.Select()
        End If
    End Sub

    Private Sub snimi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "app_konto_add"
                .Parameters.AddWithValue("@Konto_Sifra", txtSifra.Text)
                .Parameters.AddWithValue("@Godina_Vaznosti_Od", Year(Today).ToString)
                .Parameters.AddWithValue("@Naziv", txtNaziv.Text)
                .Parameters.AddWithValue("@Dozvoljeno_Knjizenje", chkDozvoljeno.CheckState)
                .Parameters.AddWithValue("@Devizno_Knjizenje", chkDevizno.CheckState)
                .Parameters.AddWithValue("@Tip_Konta", txtTip.Text)
                .Parameters.AddWithValue("@ima_analitiku", chkIma_analitiku.CheckState)
                .Parameters.AddWithValue("@Vrsta_Analitike_Sifra", cmbVrsta_analitike.Text)
                .Parameters.AddWithValue("@Vrsta_Subanalitike_Sifra", cmbVrsta_subanalitike.Text)
                .Parameters.AddWithValue("@Vrsta_Mesta_Troska_Sifra", txtMesto_troska.Text)
                .Parameters.AddWithValue("@Pocetno_Stanje", chkPocetno_stanje.CheckState)
                .Parameters.AddWithValue("@Nivo_Pocetnog_Stanja", txtNivo_poc_stanja.Text)
                .Parameters.AddWithValue("@Nivo_Zatvaranja", txtNivo_zatvaranja.Text)
                .Parameters.AddWithValue("@Aktiva_Pasiva", cmbAkt_Pas.Text)
                .Parameters.AddWithValue("@Bilansno_Vanbilansno", cmbBil_Vanbil.Text)
                .Parameters.AddWithValue("@Vazi_Do", datVaziDo.Value.Date)
                .Parameters.AddWithValue("@Konto_Ispravke", chkIspravka.CheckState)
                .Parameters.AddWithValue("@Pasiviziran", chkPasiviziran.CheckState)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub btnSnimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSnimi.Click
        Try
            snimi()
            pocetak()
        Catch ex As Exception
            MsgBox(My.Resources.text_greska)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub


End Class
