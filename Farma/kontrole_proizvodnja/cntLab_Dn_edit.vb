Option Strict Off
Option Explicit On

Imports System.Xml
Imports System.ComponentModel
Imports System.IO

Imports System.Data.SqlClient

Public Class cntLab_Dn_edit

#Region "dekleracija"
    Private kol_mag As Single = 0
    Private kol As Single = 0
    Private cena As Single = 0
    Private c_JM As String = ""
    Private lSifra As String = ""
    Private lNaziv As String = ""
    Private lKol As Single = 0
    Private lCena As Single = 0
    Private lId As Integer = 0
    Private ztroskovi_stavka As Single = 0
    Private s_vred_prep As Single = 0
    Private s_vred_mat As Single = 0
    Private s_rad_taksa As Single = 0
    Private sifra As String = ""
    Private naziv As String = ""
    Private indeks As Integer = 0
    Private broj_decimala() As Integer

    Private _pocetak As Boolean = True
    Private _citam_stavke As Boolean = True
    Private _promenjena_marza As Boolean = False
    Private _promenjena_nabav_cena As Boolean = False
    Private _prod_cena_promenjena As Boolean = False
    Private _popunjavam_robu As Boolean = False
    Private _izabran_magacin As Boolean = False
    Private magacinID As Integer = 0
    Private magacinSifra As String = ""

    Private _tab As String = ""

    Private upit As String = ""
    Shared sql As String = ""
#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntLab_Dn_edit_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'If _ima_promena Then
        '    If MsgBox("Naèinili ste promene. Dali želite da ih snimite?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '        'snimi()
        '    End If
        'End If
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntLab_Dn
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _mSpliter.SplitterDistance = 240

        Dim myControl1 As New cntLab_Dn_search
        myControl1.Parent = _mSpliter.Panel1
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_proizvodnja + My.Resources.text_search
        cntMeniProizvodnja.podesi_boje_linkova(_mPanLabDn_meni)
        _mLinkLabDn_search.BackColor = Color.GhostWhite
        _mLinkLabDn_search.ForeColor = Color.MidnightBlue
        cntMeniProizvodnja.enable_linkove(_mPanLabDn_meni)
    End Sub

    Private Sub cntLab_Dn_edit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sSpliter.Dock = DockStyle.Fill
        sSpliter.SplitterDistance = 270
        dgStavke.Dock = DockStyle.Fill

        mProiz_kontrola.tb_sifra = txtSifra
        mProiz_kontrola.tb_naziv = txtNaziv
        mProiz_kontrola.tb_jm = txtJM
        mProiz_kontrola.tb_cena = txtCena
        mProiz_kontrola.tb_kol = txtKol
        mProiz_kontrola.tb_rad_taksa = txtRadnaTaksa

        _mLabel = labLager
        _forma = Imena.tabele.pr_lab_dn.ToString ' Me.Name

        _pocetak = True

        popuni_magacine()

        pocetak()

    End Sub

    Private Sub pocetak()
        _pocetak = True

        dgStavke.Rows.Clear()
        labLager.Text = "--"

        txtBroj.Text = _lab_dn_broj ' Nadji_rb(Imena.tabele.pr_lab_dn_head.ToString, 1)
        nova_stavka()

        popuni_stavke()

        _pocetak = False
        _izabran_magacin = True
        'kontrole()

    End Sub

    Private Sub nova_stavka()
        txtSifra.Text = ""
        txtNaziv.Text = ""
        txtJM.Text = ""
        txtKol.Text = 0
        txtCena.Text = 0
        txtVred.Text = 0
        txtRadnaTaksa.Text = 0
        txtSifra.Select()

        dateDokument.Value = Today
    End Sub
    Private Sub kontrole()
        Select Case _izabran_magacin
            Case True
                tlbMain.Enabled = True
                btnSnimi.Enabled = True
                btnZakljuci.Enabled = True
                btnNovi.Enabled = True
            Case False
                tlbMain.Enabled = False
                btnSnimi.Enabled = False
                btnZakljuci.Enabled = False
                btnNovi.Enabled = False
        End Select
        btnCancel.Enabled = True
    End Sub

    Private Sub popuni_magacine()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbMagacin.Items.Clear()
        cmbMagacin.Items.Add("")
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_magacin.* from dbo.rm_magacin"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbMagacin.Items.Add(DR.Item("magacin_naziv"))
            Loop
            DR.Close()
        End If
        If cmbMagacin.Items.Count > 0 Then
            cmbMagacin.SelectedText = "GALENSKA LABORATORIJA-Gotovi proizvodi"
        End If
        CM.Dispose()
        CN.Close()
    End Sub

#Region "grid"
    Private _row_index As Integer = 0
    Private Sub dgStavke_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgStavke.RowHeaderMouseDoubleClick
        nova_stavka()
        'If tlbMain.RowStyles.Item(5).Height = 1 Then tlbMain.RowStyles.Item(5).Height = 175
        If sSpliter.SplitterDistance < 230 Then sSpliter.SplitterDistance = 230
        PictureBox1.BackgroundImage = My.Resources._3_Up
        With dgStavke
            _row_index = e.RowIndex
            txtSifra.Text = .Rows(e.RowIndex).Cells(1).Value
            txtNaziv.Text = .Rows(e.RowIndex).Cells(2).Value
            txtJM.Text = .Rows(e.RowIndex).Cells(3).Value
            txtKol.Text = .Rows(e.RowIndex).Cells(4).Value
            txtCena.Text = .Rows(e.RowIndex).Cells(5).Value
            txtVred.Text = .Rows(e.RowIndex).Cells(6).Value
            If .Rows(e.RowIndex).Cells(7).Value <> 0 Then
                _radna_taksa = CSng(.Rows(e.RowIndex).Cells(7).Value) / CSng(.Rows(e.RowIndex).Cells(4).Value)
                txtRadnaTaksa.Text = .Rows(e.RowIndex).Cells(7).Value
            Else
                radna_taksa(.Rows(e.RowIndex).Cells(1).Value)
            End If
        End With
        btnUnesi.Visible = False
        btnNastavi.Visible = True
        btnIzmeni.Visible = True
        btnIzbrisi.Visible = True
    End Sub

    Private Sub dgStavke_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgStavke.RowsAdded
        dgStavke.Rows(e.RowIndex).Selected = True
        dgStavke.FirstDisplayedScrollingRowIndex = e.RowIndex
    End Sub

    Private Sub dgStavke_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgStavke.RowsRemoved
        Dim i As Integer = 0
        For i = 0 To dgStavke.RowCount - 2
            dgStavke.Rows(i).Cells(0).Value = i + 1
        Next
        preracunaj()
    End Sub
#End Region

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Select Case sSpliter.SplitterDistance < 230
            Case True
                sSpliter.SplitterDistance = 230 ' 5
                PictureBox1.BackgroundImage = My.Resources._3_Up
            Case False
                sSpliter.SplitterDistance = 35
                PictureBox1.BackgroundImage = My.Resources._3_Down
        End Select
    End Sub

    Private Sub btnUnesi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnesi.Click
        unesi()
        nova_stavka()
    End Sub

    Private Sub btnIzbrisi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzbrisi.Click
        If _row_index <= dgStavke.RowCount - 2 Then
            dgStavke.Rows.RemoveAt(_row_index)
            nova_stavka()
        End If

    End Sub

    Private Sub btnIzmeni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzmeni.Click
        With dgStavke
            If txtSifra.Text <> "" Then .Rows(_row_index).Cells(1).Value = RTrim(txtSifra.Text)
            If txtNaziv.Text <> "" Then .Rows(_row_index).Cells(2).Value = RTrim(txtNaziv.Text)
            If txtJM.Text <> "" Then .Rows(_row_index).Cells(3).Value = RTrim(txtJM.Text)
            If txtKol.Text <> "" Then
                .Rows(_row_index).Cells(4).Value = RTrim(txtKol.Text)
            Else
                .Rows(_row_index).Cells(4).Value = 0
            End If
            If txtCena.Text <> "" Then
                .Rows(_row_index).Cells(5).Value = RTrim(txtCena.Text)
            Else
                .Rows(_row_index).Cells(5).Value = 0
            End If
            If txtVred.Text <> "" Then
                .Rows(_row_index).Cells(6).Value = RTrim(txtVred.Text)
            Else
                .Rows(_row_index).Cells(6).Value = 0
            End If
            If txtRadnaTaksa.Text <> "" Then
                .Rows(_row_index).Cells(7).Value = RTrim(txtRadnaTaksa.Text)
            Else
                .Rows(_row_index).Cells(7).Value = 0
            End If
        End With

        preracunaj()
    End Sub

    Private Sub btnNastavi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNastavi.Click
        nova_stavka()
        btnUnesi.Visible = True
        btnNastavi.Visible = False
        btnIzmeni.Visible = False
    End Sub

    Private Sub novi()

        dgStavke.Rows.Clear()

        txtBroj.Text = Nadji_rb(_tab, 2)
        txtSifra.Text = ""
        txtNaziv.Text = ""
        txtJM.Text = ""
        txtKol.Text = 0
        txtCena.Text = 0
        txtVred.Text = 0

        _ima_promena = False
    End Sub

    Private Function radna_taksa(ByVal sifra) As Single
        selektuj_sastavnicu(sifra, Selekcija.po_sifri)
        radna_taksa = _sas_radna_taksa
    End Function

    Private Sub unesi()
        With dgStavke
            Dim i As Integer = dgStavke.RowCount - 1
            .Rows.Add(1)
            .Rows(i).Cells(0).Value = i + 1
            If txtSifra.Text <> "" Then .Rows(i).Cells(1).Value = RTrim(txtSifra.Text)
            If txtNaziv.Text <> "" Then .Rows(i).Cells(2).Value = RTrim(txtNaziv.Text)
            If txtJM.Text <> "" Then .Rows(i).Cells(3).Value = RTrim(txtJM.Text)
            If txtKol.Text <> "" Then
                .Rows(i).Cells(4).Value = RTrim(txtKol.Text)
            Else
                .Rows(i).Cells(4).Value = 0
            End If
            If txtCena.Text <> "" Then
                .Rows(i).Cells(5).Value = RTrim(txtCena.Text)
            Else
                .Rows(i).Cells(5).Value = 0
            End If
            If txtVred.Text <> "" Then
                .Rows(i).Cells(6).Value = RTrim(txtVred.Text)
            Else
                .Rows(i).Cells(6).Value = 0
            End If
            If txtRadnaTaksa.Text <> "" Then
                .Rows(i).Cells(7).Value = RTrim(txtRadnaTaksa.Text)
            Else
                .Rows(i).Cells(7).Value = 0
            End If

        End With
        preracunaj()

    End Sub

    Private Sub preracunaj()
        Dim i As Integer

        s_vred_prep = 0
        's_vred_mat = 0
        s_rad_taksa = 0

        Try
            For i = 0 To dgStavke.Rows.Count - 1
                Dim vred_prep As Single = CSng(dgStavke.Rows(i).Cells(6).Value)
                Dim rad_taksa As Single = CSng(dgStavke.Rows(i).Cells(7).Value)

                s_vred_prep += vred_prep
                s_rad_taksa += rad_taksa
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txtVredPrep.Text = Format(s_vred_prep, "#,##0.00")
        txtVredMat.Text = Format(s_vred_prep - s_rad_taksa, "#,##0.00")
        txtVredRadnaTaksa.Text = Format(s_rad_taksa, "#,##0.00")

    End Sub

    Private Sub zatvori_formu()
        'If _unesen Then
        '    panHeader.Enabled = False
        '    Panel1.Enabled = False
        '    cmbMagacin.Enabled = False

        '    dgStavke.AllowUserToAddRows = False
        '    dgStavke.Enabled = False
        '    lvLista.Enabled = False

        '    txtIznosCena.Enabled = False
        '    txtIznosPdv.Enabled = False
        '    txtIznosRabat.Enabled = False
        '    txtIznosZanaplatu.Enabled = False
        '    txtOsnovica.Enabled = False

        '    btnSnimi.Enabled = False
        '    btnZakljuci.Enabled = False
        'End If
    End Sub

#Region "Snimi"

    Private Sub btnSnimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSnimi.Click
        snimi_head()
        snimi_stavku()

        selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)

        unesi_dnevni_promet_head(Today.Date, Now, _id_magacin, 0, 0, _
                         ID_vrsta_dokumenta, _id_dokument, txtBroj.Text, CSng(txtVredPrep.Text), _
                        0, 1, 0, vrsta_promene.editovanje)

        _id_dnevni_promet = Nadji_id(Imena.tabele.rm_dnevni_promet_head.ToString)

        Dim i As Integer
        For i = 0 To dgStavke.Rows.Count - 2
            selektuj_artikl(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)
            selektuj_pdv(_artikl_id_pdv, Selekcija.po_id)
            unesi_dnevni_promet_stavka(_id_dnevni_promet, _id_magacin, _id_artikl, dgStavke.Rows(i).Cells(4).Value, 0, _
                    CSng(dgStavke.Rows(i).Cells(5).Value), _pdv_stopa, True, False)
        Next

        pocetak()
    End Sub

    Private Sub snimi_head()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "pr_lab_dn_head_update"
                .Parameters.AddWithValue("@id_lab_dn", _id_lab_dn)
                .Parameters.AddWithValue("@lab_dn_broj", CInt(txtBroj.Text))
                .Parameters.AddWithValue("@lab_dn_datum", dateDokument.Value.Date)
                .Parameters.AddWithValue("@lab_dn_vred_preparata", CSng(txtVredPrep.Text))
                .Parameters.AddWithValue("@lab_dn_vred_materijala", CSng(txtVredMat.Text))
                .Parameters.AddWithValue("@lab_dn_radna_taksa", CSng(txtVredRadnaTaksa.Text))
                .Parameters.AddWithValue("@lab_dn_zakljuen", _lab_dn_zakljuen)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub snimi_stavku()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim i, n As Integer

        '_id_lab_dn = Nadji_id(Imena.tabele.pr_lab_dn_head.ToString)

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "pr_lab_dn_stavka_utroseno_del_labDN"
                .Parameters.AddWithValue("@id_lab_dn", _id_lab_dn)
                .ExecuteScalar()
            End With
            CM.Dispose()

            If _id_lab_dn_stavka.Length > dgStavke.Rows.Count - 1 Then
                n = _id_lab_dn_stavka.Length - 1
            Else
                n = dgStavke.Rows.Count - 2
            End If
            For i = 0 To n
                If (i <= dgStavke.Rows.Count - 2 Or Not _id_lab_dn_stavka.Length > dgStavke.Rows.Count - 1) _
                    Or _id_lab_dn_stavka.Length = 0 Then

                    If i > _id_lab_dn_stavka.Length - 1 Then
                        CM = New SqlCommand()
                        With CM
                            .Connection = CN
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "pr_lab_dn_stavka_add"
                            .Parameters.AddWithValue("@id_lab_dn", _id_lab_dn)
                            .Parameters.AddWithValue("@lab_dn_st_rb", dgStavke.Rows(i).Cells(0).Value)
                            .Parameters.AddWithValue("@lab_dn_st_sifra", dgStavke.Rows(i).Cells(1).Value)
                            .Parameters.AddWithValue("@lab_dn_st_naziv", dgStavke.Rows(i).Cells(2).Value)
                            .Parameters.AddWithValue("@lab_dn_st_jm", dgStavke.Rows(i).Cells(3).Value)
                            .Parameters.AddWithValue("@lab_dn_st_kolicina", CSng(dgStavke.Rows(i).Cells(4).Value))
                            .Parameters.AddWithValue("@lab_dn_st_cena", CSng(dgStavke.Rows(i).Cells(5).Value))
                            .Parameters.AddWithValue("@lab_dn_st_vrednost", CSng(dgStavke.Rows(i).Cells(6).Value))
                            .Parameters.AddWithValue("@lab_dn_st_rad_taksa", CSng(dgStavke.Rows(i).Cells(7).Value))
                            .ExecuteScalar()
                        End With
                        CM.Dispose()
                    Else
                        CM = New SqlCommand()
                        If CN.State = ConnectionState.Open Then
                            With CM
                                .Connection = CN
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "pr_lab_dn_stavka_update"
                                .Parameters.AddWithValue("@id_lab_dn_st", _id_lab_dn_stavka(i))
                                .Parameters.AddWithValue("@lab_dn_st_rb", dgStavke.Rows(i).Cells(0).Value)
                                .Parameters.AddWithValue("@lab_dn_st_sifra", dgStavke.Rows(i).Cells(1).Value)
                                .Parameters.AddWithValue("@lab_dn_st_naziv", dgStavke.Rows(i).Cells(2).Value)
                                .Parameters.AddWithValue("@lab_dn_st_jm", dgStavke.Rows(i).Cells(3).Value)
                                .Parameters.AddWithValue("@lab_dn_st_kolicina", CSng(dgStavke.Rows(i).Cells(4).Value))
                                .Parameters.AddWithValue("@lab_dn_st_cena", CSng(dgStavke.Rows(i).Cells(5).Value))
                                .Parameters.AddWithValue("@lab_dn_st_vrednost", CSng(dgStavke.Rows(i).Cells(6).Value))
                                .Parameters.AddWithValue("@lab_dn_st_rad_taksa", CSng(dgStavke.Rows(i).Cells(7).Value))
                                .ExecuteScalar()
                            End With
                        End If
                        CM.Dispose()
                    End If
                    If Not IsNothing(dgStavke.Rows(i).Cells(1).Value) Then
                        selektuj_sastavnicu(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)
                        snimi_stavke_utrosak(CSng(dgStavke.Rows(i).Cells(4).Value))
                    End If
                Else
                    CM = New SqlCommand()
                    If CN.State = ConnectionState.Open Then
                        With CM
                            .Connection = CN
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "pr_lab_dn_stavka_delete"
                            .Parameters.AddWithValue("@id_lab_dn_st", _id_lab_dn_stavka(i))
                            .ExecuteScalar()
                        End With
                    End If
                    CM.Dispose()
                End If
            Next
        End If
        CN.Close()

    End Sub

    Private Sub snimi_stavke_utrosak(ByVal kol)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim CM1 As New SqlCommand
        Dim DR As SqlDataReader

        _id_lab_dn_st = Nadji_id(Imena.tabele.pr_lab_dn_stavka.ToString)

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM1 = New SqlCommand()
            With CM1
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.pr_sastavnica_stavka where dbo.pr_sastavnica_stavka.id_sastavnica = " & _id_sastavnica
                DR = .ExecuteReader
            End With

            Do While DR.Read
                snimi(RTrim(DR.Item("id_magacin")), RTrim(DR.Item("sas_st_sifra")), DR.Item("sas_st_naziv"), _
                    kol * DR.Item("sas_st_kolicina"), kol * DR.Item("sas_st_kolicina_skladistenja"), _
                    DR.Item("sas_st_cena"), kol * DR.Item("sas_st_vrednist"))
            Loop
        End If
        CN.Close()
    End Sub

    Private Sub snimi(ByVal id_mag, ByVal sifra, ByVal naziv, ByVal kolicina, ByVal kol_sklad, ByVal cena, ByVal vred)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "pr_lab_dn_stavka_utroseno_add"
                .Parameters.AddWithValue("@id_lab_dn_st", _id_lab_dn_st)
                .Parameters.AddWithValue("@id_lab_dn", _id_lab_dn)
                .Parameters.AddWithValue("@id_magacin", id_mag)
                .Parameters.AddWithValue("@lab_dn_st_ut_sifra", sifra)
                .Parameters.AddWithValue("@lab_dn_st_ut_naziv", naziv)
                .Parameters.AddWithValue("@lab_dn_st_ut_kolicina", kolicina)
                .Parameters.AddWithValue("@lab_dn_st_ut_kol_sklad", kol_sklad)
                .Parameters.AddWithValue("@lab_dn_st_ut_cena", cena)
                .Parameters.AddWithValue("@lab_dn_st_ut_vrednost", vred)
                .Parameters.AddWithValue("@lab_dn_st_ut_rad_taksa", vred)
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If
        CN.Close()

    End Sub

#End Region

#Region "Zakljuci"
    'Private Sub btnZakljuci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZakljuci.Click
    '    _id_oj = 0
    '    'selektuj_partnera(cmbPartneri.Text, Selekcija.po_nazivu)

    '    'prebaci_u_magacin_promene(_id_magacin, 4, txtBroj.Text)
    '    'prebaci_u_magacin_promene_stavka(_id_dnevni_promet)
    '    'zakljuci_dokument()
    '    'labProknjizen.Visible = True
    '    'btnZakljuci.Visible = False
    'End Sub

    Private Sub zakljuci_dokument()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        '_id_dokumenta = Nadji_id(Imena.tabele.rm_kalkulacija_head.ToString)

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = mRob_Dokument.KonamdTekst & "_zakljuci"
                .Parameters.AddWithValue("@id_kalkulacija", _id_dokument)
                .Parameters.AddWithValue("@kalk_zakljucena", 1)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
        _unesen = True
        zatvori_formu()
    End Sub
#End Region

    Private Sub cmbMagacin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMagacin.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbMagacin.Text <> "" Then
                selektuj_magacin(RTrim(cmbMagacin.Text), Selekcija.po_nazivu)
            End If
            dateDokument.Select()
        End If
    End Sub

    Private Sub cmbMagacin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMagacin.SelectedIndexChanged
        If Not _pocetak Then
            If cmbMagacin.Text <> "" Then
                _izabran_magacin = True
                selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)
                magacinID = _id_magacin
                magacinSifra = _magacin_sifra
            End If
            kontrole()
        End If
    End Sub

    Private Sub dateKalkulacija_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dateDokument.KeyPress

    End Sub

    Private Sub txtSifra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSifra.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtSifra.Text = "" Then
                txtNaziv.Select()
            Else
                If txtSifra.Text <> "" And txtNaziv.Text = "" Then
                    sastavnica()
                End If
                txtKol.Select()
            End If
        End If
    End Sub

    Private Sub sastavnica()
        selektuj_sastavnicu(RTrim(txtSifra.Text), Selekcija.po_sifri)
        txtNaziv.Text = _sas_art_naziv
        txtSifra.Text = _sas_art_sifra
        txtJM.Text = _sas_jm_recept
        txtCena.Text = _sas_art_cena
    End Sub

    Private Sub txtNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNaziv.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtNaziv.Text = "" Then
                If txtSifra.Text <> "" Then
                    If MsgBox("Uneli ste šifru. Dali želite da nastavite da radite sa njom?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                        sastavnica()
                    Else
                        Dim mForm As New frmArtikl_pick
                        mForm.Show()
                    End If
                Else

                    Dim mForm As New frmArtikl_pick
                    mForm.Show()
                End If
            Else
                If txtNaziv.Text <> "" Then
                    selektuj_sastavnicu(RTrim(txtNaziv.Text), Selekcija.po_nazivu)
                    txtSifra.Text = _sas_art_sifra
                End If
            End If
        End If
        txtKol.Select()
    End Sub

    Private Sub txtKol_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKol.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtCena.Text <> "" Then
                If jeste_broj(txtCena.Text) Then
                    txtKol.Text = Format(CSng(txtKol.Text), "#,##0")
                End If
            End If
            txtCena.Select()
        End If
    End Sub
    Private Sub txtKol_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKol.TextChanged
        If txtKol.Text <> "" And txtCena.Text <> "" Then
            If jeste_broj(txtKol.Text) And jeste_broj(txtCena.Text) Then
                txtVred.Text = Format(CSng(txtCena.Text) * CSng(txtKol.Text), "#,##0.00")
                txtRadnaTaksa.Text = Format(CSng(_radna_taksa) * CSng(txtKol.Text), "#,##0.00")
            End If
        End If
    End Sub

    Private Sub txtCena_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCena.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtCena.Text <> "" Then
                If jeste_broj(txtCena.Text) Then
                    txtCena.Text = Format(CSng(txtCena.Text), "#,##0.00")
                    btnUnesi.Select()
                End If
            End If
        End If
    End Sub
    Private Sub txtCena_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCena.TextChanged
        If txtKol.Text <> "" And txtCena.Text <> "" Then
            If jeste_broj(txtKol.Text) And jeste_broj(txtCena.Text) Then
                txtVred.Text = Format(CSng(txtCena.Text) * CSng(txtKol.Text), "#,##0.00")
            End If
        End If
    End Sub

  

    Private Sub btnZakljuci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZakljuci.Click

    End Sub

    Private Sub btnNovi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovi.Click

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub popuni_stavke()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        _citam_stavke = True

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.pr_lab_dn_stavka where " & _
                                "dbo.pr_lab_dn_stavka.id_lab_dn = " & _id_lab_dn
                DR = .ExecuteReader
            End With

            _broj_stavki = 0
            Do While DR.Read
                _broj_stavki += 1
            Loop
            DR.Close()

            _id_lab_dn_stavka = New Integer() {}
            ReDim _id_lab_dn_stavka(_broj_stavki - 1)

            With dgStavke
                Dim i As Integer = 0
                DR = CM.ExecuteReader
                Do While DR.Read
                    .Rows.Add(1)
                    If Not IsDBNull(DR.Item("id_lab_dn_st")) Then _id_lab_dn_stavka.SetValue(DR.Item("id_lab_dn_st"), i)
                    If Not IsDBNull(DR.Item("lab_dn_st_rb")) Then .Rows(i).Cells(0).Value = RTrim(DR.Item("lab_dn_st_rb"))
                    If Not IsDBNull(DR.Item("lab_dn_st_sifra")) Then .Rows(i).Cells(1).Value = DR.Item("lab_dn_st_sifra")
                    If Not IsDBNull(DR.Item("lab_dn_st_naziv")) Then .Rows(i).Cells(2).Value = DR.Item("lab_dn_st_naziv")
                    If Not IsDBNull(DR.Item("lab_dn_st_jm")) Then .Rows(i).Cells(3).Value = RTrim(DR.Item("lab_dn_st_jm"))
                    If Not IsDBNull(DR.Item("lab_dn_st_kolicina")) Then .Rows(i).Cells(4).Value = DR.Item("lab_dn_st_kolicina")
                    If Not IsDBNull(DR.Item("lab_dn_st_cena")) Then .Rows(i).Cells(5).Value = DR.Item("lab_dn_st_cena")
                    If Not IsDBNull(DR.Item("lab_dn_st_vrednost")) Then .Rows(i).Cells(6).Value = DR.Item("lab_dn_st_vrednost")
                    If Not IsDBNull(DR.Item("lab_dn_st_rad_taksa")) Then .Rows(i).Cells(7).Value = DR.Item("lab_dn_st_rad_taksa")
                    i += 1
                Loop
                DR.Close()
            End With
        End If
        CM.Dispose()
        CN.Close()

        _citam_stavke = False
        _popunjavam_robu = False

        preracunaj()
    End Sub

End Class
