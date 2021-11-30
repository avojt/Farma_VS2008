Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class cntPartneri_add

#Region "dekleracija"

    Private _pocetak As Boolean = True
    Private _proizvodjac As Boolean = False
    Private _dobavljac As Boolean = False
    Private _kupac As Boolean = False

#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntPartneri_add_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'If _ima_promena Then
        '    If MsgBox("Načinili ste promene. Dali želite da ih snimite?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '        snimi()
        '    End If
        'End If

        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntPartneri
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _mSpliter.SplitterDistance = 310

        Dim myControl1 As New cntPartneri_sreach
        myControl1.Parent = _mSpliter.Panel1
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_partneri + My.Resources.text_search
        cntMeniPartneri.podesi_boje_linkova(_mPanPartneri_meni)
        _mLinkPartneri_search.BackColor = Color.GhostWhite
        _mLinkPartneri_search.ForeColor = Color.MidnightBlue
        cntMeniPartneri.enable_linkove(_mPanPartneri_meni)
    End Sub

    Private Sub cntPartneri_add_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tlbMain.Dock = DockStyle.Fill
        pocetak()
    End Sub

    Private Sub pocetak()

        _pocetak = True

        popuni_mesta()
        popuni_opstine()

        txtAdresa.Text = ""
        txtDelatnost.Text = ""
        txtDrzava.Text = ""
        txtMaticni.Text = ""
        txtNaziv.Text = ""
        txtPIB.Text = ""
        txtRegistarski.Text = ""
        txtSifra.Text = Nadji_rb(Imena.tabele.app_partneri.ToString, 1)
        txtTekuci.Text = ""
        chkDobavljac.CheckState = CheckState.Unchecked
        chkKupac.CheckState = CheckState.Unchecked
        chkProizvodjac.CheckState = CheckState.Unchecked

        _pocetak = False

    End Sub

    Private Sub popuni_mesta()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbMesto.Items.Clear()
        cmbMesto.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_mesta.* from dbo.app_mesta"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbMesto.Items.Add(DR.Item("mesto_naziv"))
            Loop
            DR.Close()
        End If
        If cmbMesto.Items.Count > 0 Then
            'selektuj_mesto(_partner_mesto, Selekcija.po_nazivu)
            cmbMesto.SelectedText = _partner_mesto
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_opstine()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbOpstina.Items.Clear()
        cmbOpstina.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_opstine.* from dbo.app_opstine"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbOpstina.Items.Add(DR.Item("opstine_naziv"))
            Loop
            DR.Close()
        End If
        If cmbOpstina.Items.Count > 0 Then
            'selektuj_mesto(_partner_mesto, Selekcija.po_nazivu)
            cmbOpstina.SelectedText = _partner_opstina
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub txtSifra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSifra.KeyPress
        If e.KeyChar = Chr(13) Then
            txtNaziv.Select()
        End If
    End Sub

    Private Sub txtNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNaziv.KeyPress
        If e.KeyChar = Chr(13) Then
            txtAdresa.Select()
        End If
    End Sub

    Private Sub txtAdresa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdresa.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbOpstina.Select()
        End If
    End Sub

    Private Sub cmbOpstina_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOpstina.DropDownClosed
        cmbMesto.Select()
    End Sub

    Private Sub cmbOpstina_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbOpstina.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbMesto.Select()
        End If
    End Sub

    Private Sub cmbMesto_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMesto.DropDownClosed
        txtDrzava.Select()
    End Sub

    Private Sub cmbMesto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMesto.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDrzava.Select()
        End If
    End Sub

    Private Sub txtDrzava_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDrzava.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPIB.Select()
        End If
    End Sub

    Private Sub txtPIB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPIB.KeyPress
        If e.KeyChar = Chr(13) Then
            txtMaticni.Select()
        End If
    End Sub

    Private Sub txtMaticni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMaticni.KeyPress
        If e.KeyChar = Chr(13) Then
            txtRegistarski.Select()
        End If
    End Sub

    Private Sub txtRegistarski_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRegistarski.KeyPress
        If e.KeyChar = Chr(13) Then
            txtTekuci.Select()
        End If
    End Sub

    Private Sub txtTekuci_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTekuci.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDelatnost.Select()
        End If
    End Sub

    Private Sub txtDelatnost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDelatnost.KeyPress
        If e.KeyChar = Chr(13) Then
            chkProizvodjac.Select()
        End If
    End Sub

    Private Sub chkProizvodjac_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProizvodjac.CheckedChanged
        Select Case chkDobavljac.CheckState
            Case CheckState.Checked
                _proizvodjac = True
            Case CheckState.Unchecked
                _proizvodjac = False
        End Select
    End Sub

    Private Sub chkDobavljac_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDobavljac.CheckedChanged
        Select Case chkDobavljac.CheckState
            Case CheckState.Checked
                _dobavljac = True
            Case CheckState.Unchecked
                _dobavljac = False
        End Select
    End Sub

    Private Sub chkKupac_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkKupac.CheckedChanged
        Select Case chkDobavljac.CheckState
            Case CheckState.Checked
                _kupac = True
            Case CheckState.Unchecked
                _kupac = False
        End Select
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
                .CommandText = "app_partneri_add"
                .Parameters.AddWithValue("@partner_sifra", txtSifra.Text)
                .Parameters.AddWithValue("@partner_naziv", txtNaziv.Text)
                .Parameters.AddWithValue("@partner_adresa", txtAdresa.Text)
                .Parameters.AddWithValue("@partner_mesto", cmbMesto.Text)
                .Parameters.AddWithValue("@partner_pib", txtPIB.Text)
                .Parameters.AddWithValue("@partner_maticni", txtMaticni.Text)
                .Parameters.AddWithValue("@partner_registarski", txtRegistarski.Text)
                .Parameters.AddWithValue("@partner_zr", txtTekuci.Text)
                .Parameters.AddWithValue("@partner_proizvodjac", chkProizvodjac.CheckState)
                .Parameters.AddWithValue("@partner_dobavljac", chkDobavljac.CheckState)
                .Parameters.AddWithValue("@partner_kupac", chkKupac.CheckState)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub btnSnimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSnimi.Click
        snimi()
        pocetak()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class
