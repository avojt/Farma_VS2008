Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class cntSastavnica_add

#Region "dekleracija"
    Private kol_skl As Single = 0
    Private kol As Single = 0
    Private cena As Single = 0
    Private vrednost As Single = 0
    Private radna_taksa As Single = 0
    Private lSifra As String = ""
    Private lNaziv As String = ""
    Private lKol As Single = 0
    Private lCena As Single = 0
    Private naziv As String = ""

    Private _pocetak As Boolean = True
    Private _citam_stavke As Boolean = True
    Private _promenjena_nabav_cena As Boolean = False
    Private _prod_cena_promenjena As Boolean = False
    Private _popunjavam_robu As Boolean = False

    Private upit As String = ""
    Private upit_sifra As String = ""

    Shared sql_start As String = ""
    Shared sql As String = ""

    Private _dokument As New clsRobno
    Private _odnos_jedinica As Single = 1
    Private _jm1 As String
    Private _jm2 As String
#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntSastavnica_add_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'If _ima_promena Then
        '    If MsgBox("Načinili ste promene. Dali želite da ih snimite?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '        'snimi()
        '    End If
        'End If
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntSastavnica
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _mSpliter.SplitterDistance = 190

        Dim myControl1 As New cntSastavnica_search
        myControl1.Parent = _mSpliter.Panel1
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_robno + My.Resources.text_search
        cntMeniProizvodnja.podesi_boje_linkova(_mPanSastavnica_meni)
        _mLinkSastavnica_search.BackColor = Color.GhostWhite
        _mLinkSastavnica_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub cntSastavnica_add_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sSpliter.Dock = DockStyle.Fill
        sSpliter.SplitterDistance = 180
        dgStavke.Dock = DockStyle.Fill

        mRob_kontrola.tb_sifra = txtSifra
        mRob_kontrola.tb_naziv = txtNaziv
        mRob_kontrola.tb_jm = txtJMskl
        mRob_kontrola.tb_nab_cena = txtCena
        mRob_kontrola.tb_kol = txtKol

        _forma = Imena.tabele.pr_sastavnica.ToString ' "Sastavnica"

        _mLabel = labLager
        _pocetak = True

        pocetak()
    End Sub

    Private Sub pocetak()
        _pocetak = True

        txtJMRp.Text = ""
        txtKolicinaRp.Text = 1
        txtKolicinaRp.Enabled = False
        txtCenaPr.Text = 0
        txtUkupno.Text = 0
        txtVrednost.Text = 0
        txtUtroseno.Text = 0
        txtRTaksa.Text = 0

        dgStavke.Rows.Clear()
        labLager.Text = "--"

        dateSast.Value = Today

        popuni_artikle()
        popuni_jm()
        popuni_magacine()

        _pocetak = False

    End Sub

    Private Sub kontrole()
        'Select Case _izabran_magacin
        '    Case True
        '        'sSpliter.Panel2.Enabled = True
        '        tlbMain.Enabled = True
        '        btnSnimi.Enabled = True
        '        btnZakljuci.Enabled = True
        '        btnNovi.Enabled = True
        '    Case False
        '        'sSpliter.Panel2.Enabled = False
        '        tlbMain.Enabled = False
        '        btnSnimi.Enabled = False
        '        btnZakljuci.Enabled = False
        '        btnNovi.Enabled = False
        'End Select
        'btnCancel.Enabled = True
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

    Private Sub popuni_artikle()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbArtikl.Items.Clear()
        'cmbVrstaDok.Items.Add("")
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbArtikl.Items.Add(DR.Item("artikl_naziv"))
            Loop
            DR.Close()
        End If
        If cmbArtikl.Items.Count > 0 Then
            cmbArtikl.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_jm()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbJM.Items.Clear()
        'cmbVrstaDok.Items.Add("")
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_jm.* from dbo.app_jm"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbJM.Items.Add(DR.Item("jm_oznaka"))
            Loop
            DR.Close()
        End If
        If cmbJM.Items.Count > 0 Then
            cmbJM.SelectedIndex = 0
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
            txtKol.Text = .Rows(e.RowIndex).Cells(4).Value
            cmbJM.Text = .Rows(e.RowIndex).Cells(5).Value
            txtKOLskl.Text = .Rows(e.RowIndex).Cells(6).Value
            txtJMskl.Text = .Rows(e.RowIndex).Cells(7).Value
            txtCena.Text = .Rows(e.RowIndex).Cells(8).Value
            txtVred.Text = .Rows(e.RowIndex).Cells(9).Value
            selektuj_magacin(_id_magacin, Selekcija.po_id)
            cmbMagacin.Text = _magacin_naziv
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
        dgStavke.Rows.RemoveAt(_row_index)
        nova_stavka()
    End Sub

    Private Sub btnIzmeni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzmeni.Click
        With dgStavke
            If txtSifra.Text <> "" Then .Rows(_row_index).Cells(1).Value = RTrim(txtSifra.Text)
            If txtNaziv.Text <> "" Then .Rows(_row_index).Cells(2).Value = RTrim(txtNaziv.Text)

            .Rows(_row_index).Cells(3).Value = 0 ' radna taksa 

            If txtKol.Text <> "" Then
                .Rows(_row_index).Cells(4).Value = RTrim(txtKol.Text)
            Else
                .Rows(_row_index).Cells(4).Value = 0
            End If

            If cmbJM.Text <> "" Then
                .Rows(_row_index).Cells(5).Value = RTrim(cmbJM.Text)
            Else
                .Rows(_row_index).Cells(5).Value = ""
            End If

            If txtKOLskl.Text <> "" Then
                .Rows(_row_index).Cells(6).Value = RTrim(txtKOLskl.Text)
            Else
                .Rows(_row_index).Cells(6).Value = ""
            End If

            If txtJMskl.Text <> "" Then
                .Rows(_row_index).Cells(7).Value = RTrim(txtJMskl.Text)
            Else
                .Rows(_row_index).Cells(7).Value = ""
            End If

            If txtCena.Text <> "" Then
                .Rows(_row_index).Cells(8).Value = RTrim(txtCena.Text)
            Else
                .Rows(_row_index).Cells(8).Value = 0
            End If

            .Rows(_row_index).Cells(9).Value = Format( _
                                CSng(.Rows(_row_index).Cells(6).Value) * _
                                CSng(.Rows(_row_index).Cells(8).Value), "#,##0.00")

            selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)
            .Rows(_row_index).Cells(10).Value = _id_magacin

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

        txtSifra.Text = ""
        txtNaziv.Text = ""
        txtJMskl.Text = ""
        cmbJM.SelectedIndex = 0
        txtKol.Text = 0
        txtKOLskl.Text = 0
        txtCena.Text = 0
        txtVred.Text = 0

        txtSifra.Select()

        _ima_promena = False
    End Sub

    Private Sub unesi()
        With dgStavke
            Dim i As Integer = dgStavke.RowCount - 1
            .Rows.Add(1)
            .Rows(i).Cells(0).Value = i + 1
            If txtSifra.Text <> "" Then .Rows(i).Cells(1).Value = RTrim(txtSifra.Text)
            If txtNaziv.Text <> "" Then .Rows(i).Cells(2).Value = RTrim(txtNaziv.Text)

            .Rows(i).Cells(3).Value = 0 ' radna taksa 

            If txtKol.Text <> "" Then
                .Rows(i).Cells(4).Value = RTrim(txtKol.Text)
            Else
                .Rows(i).Cells(4).Value = 0
            End If

            If cmbJM.Text <> "" Then
                .Rows(i).Cells(5).Value = RTrim(cmbJM.Text)
            Else
                .Rows(i).Cells(5).Value = ""
            End If

            If txtKOLskl.Text <> "" Then
                .Rows(i).Cells(6).Value = RTrim(txtKOLskl.Text)
            Else
                .Rows(i).Cells(6).Value = ""
            End If

            If txtJMskl.Text <> "" Then
                .Rows(i).Cells(7).Value = RTrim(txtJMskl.Text)
            Else
                .Rows(i).Cells(7).Value = ""
            End If

            If txtCena.Text <> "" Then
                .Rows(i).Cells(8).Value = RTrim(txtCena.Text)
            Else
                .Rows(i).Cells(8).Value = 0
            End If

            .Rows(i).Cells(9).Value = Format( _
                                CSng(.Rows(i).Cells(6).Value) * _
                                CSng(.Rows(i).Cells(8).Value), "#,##0.00")

            selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)
            .Rows(i).Cells(10).Value = _id_magacin

        End With
        preracunaj()

        'labLager.Text = "Stavka broj: " & dgStavke.Rows.Count
    End Sub

    Private Sub nova_stavka()
        txtSifra.Text = ""
        txtNaziv.Text = ""
        txtJMskl.Text = ""
        cmbJM.SelectedIndex = 0
        txtKol.Text = 0
        txtKOLskl.Text = 0
        txtCena.Text = 0
        txtVred.Text = 0

        txtSifra.Select()
    End Sub

    Private Sub preracunaj()
        Dim i As Integer

        vrednost = 0

        Try
            For i = 0 To dgStavke.Rows.Count - 1
                'Dim kol As Single = CSng(dgStavke.Rows(i).Cells(4).Value)
                'Dim kol_skl As Single = CSng(dgStavke.Rows(i).Cells(6).Value)
                'Dim cena As Single = CSng(dgStavke.Rows(i).Cells(8).Value)
                Dim vred As Single = CSng(dgStavke.Rows(i).Cells(9).Value)
                vrednost += vred
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txtUkupno.Text = Format(vrednost, "#,##0.00")
        txtVrednost.Text = Format(CSng(txtCenaPr.Text) * CSng(txtKolicinaRp.Text), "#,##0.00")
        txtUtroseno.Text = Format(CSng(txtKolicinaRp.Text) * vrednost, "#,##0.00")
        txtRTaksa.Text = Format(CSng(txtVrednost.Text) - vrednost, "#,##0.00")

    End Sub

    Private Sub lager()
        'Dim CN As SqlConnection = New SqlConnection(CNNString)
        'Dim CM As New SqlCommand
        'Dim DR As SqlDataReader

        'lSifra = ""
        'lNaziv = ""
        'lKol = 0
        'lCena = 0

        'CN.Open()
        'If CN.State = ConnectionState.Open Then
        '    CM = New SqlCommand()
        '    With CM
        '        .Connection = CN
        '        .CommandType = CommandType.Text
        '        .CommandText = "select * from dbo.rm_dnevni_promet_stavka where dbo.rm_dnevni_promet_stavka.id_artikl = " & lId '& " and dbo.rm_dnevni_promet_stavka.dp_zakljucen = 0"
        '        DR = .ExecuteReader
        '    End With

        '    Do While DR.Read
        '        If Not IsDBNull(DR.Item("dp_art_stanje")) Then lKol = DR.Item("dp_art_stanje")
        '        If Not IsDBNull(DR.Item("dp_art_cena")) Then lCena = DR.Item("dp_art_cena")
        '    Loop
        '    DR.Close()
        '    CM.Dispose()

        '    CM = New SqlCommand()
        '    With CM
        '        .Connection = CN
        '        .CommandType = CommandType.Text
        '        .CommandText = "select * from dbo.rm_artikli where dbo.rm_artikli.id_artikl = " & lId
        '        DR = .ExecuteReader
        '    End With
        '    Do While DR.Read
        '        If Not IsDBNull(DR.Item("artikl_sifra")) Then lSifra = DR.Item("artikl_sifra")
        '        If Not IsDBNull(DR.Item("artikl_naziv")) Then lNaziv = DR.Item("artikl_naziv")
        '    Loop
        '    DR.Close()
        '    CM.Dispose()

        'End If
        'CN.Close()

        'labLager.Text = RTrim(lSifra) & " - " & lNaziv & " - kol: " & lKol & " - cena: " & lCena

    End Sub

#Region "Snimi"

    Private Sub btnSnimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSnimi.Click
        snimi_head()
        snimi_stavku()

        pocetak()
    End Sub

    Private Sub snimi_head()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim ztros As Single = 0

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "pr_sastavnica_head_add"
                selektuj_artikl(cmbArtikl.Text, Selekcija.po_nazivu)
                .Parameters.AddWithValue("@sas_art_sifra", _artikl_sifra)
                .Parameters.AddWithValue("@sas_art_naziv", cmbArtikl.Text)
                .Parameters.AddWithValue("@sas_art_cena", CSng(txtCenaPr.Text))
                .Parameters.AddWithValue("@sas_jm_recept", RTrim(txtJMRp.Text))
                .Parameters.AddWithValue("@sas_kolicina", txtKolicinaRp.Text)
                .Parameters.AddWithValue("@sas_odobrena", chkOdobrena.Checked)
                .Parameters.AddWithValue("@sas_datum_unosa", dateSast.Value.Date)
                .Parameters.AddWithValue("@sas_datum_prestanka", 0)
                .Parameters.AddWithValue("@sas_ukupno", CSng(txtUkupno.Text))
                .Parameters.AddWithValue("@sas_vrednost", CSng(txtVrednost.Text))
                .Parameters.AddWithValue("@sas_radna_taksa", CSng(txtRTaksa.Text))
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub snimi_pdv()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim _porezi() As Single
        Dim i As Integer = 0

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_ulazni_dokument_pdv_delete"
                .Parameters.AddWithValue("@id_dokument", _id_dokument)
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If

        _porezi = New Single() {}

        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_pdv.* from dbo.app_pdv"
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            _broj_stavki = 0
            Do While DR.Read
                _broj_stavki += 1
            Loop
            DR.Close()

            ReDim _porezi(_broj_stavki * 3)

            DR = CM.ExecuteReader
            Do While DR.Read
                If Not IsDBNull(DR.Item("pdv_stopa")) Then
                    _porezi.SetValue(CSng(DR.Item("pdv_stopa")), i * 3)
                    _porezi.SetValue(saberi_osnovice(DR.Item("pdv_stopa")), (i * 3) + 1)
                    _porezi.SetValue(saberi_pdv(DR.Item("pdv_stopa")), (i * 3) + 2)
                    i += 1
                End If
            Loop
            DR.Close()
            CM.Dispose()
        End If

        '_id_dokumenta = Nadji_id(mRob_Dokument.tabela.ToString)

        For i = 0 To (_porezi.Length / 3) - 1
            If _porezi((i * 3) + 1) <> 0 Then
                CM = New SqlCommand()
                If CN.State = ConnectionState.Open Then
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "rm_ulazni_dokument_pdv_add"
                        .Parameters.AddWithValue("@id_dokument", _id_dokument)
                        .Parameters.AddWithValue("@dok_pdv", _porezi(i * 3))
                        .Parameters.AddWithValue("@dok_osnovica", _porezi((i * 3) + 1))
                        .Parameters.AddWithValue("@dok_iznos", _porezi((i * 3) + 2))
                        .ExecuteScalar()
                    End With
                End If
                CM.Dispose()
            End If
        Next
        CN.Close()
    End Sub

    Private Function saberi_pdv(ByVal _stopa) As Single
        Dim i As Integer

        saberi_pdv = 0
        For i = 0 To dgStavke.Rows.Count - 2
            If dgStavke.Rows(i).Cells(12).Value = _stopa Then _
                saberi_pdv += dgStavke.Rows(i).Cells(14).Value 'dgStavke.Rows(i).Cells(5).Value * dgStavke.Rows(i).Cells(13).Value
        Next
    End Function

    Private Function saberi_osnovice(ByVal _stopa) As Single
        Dim i As Integer

        saberi_osnovice = 0
        For i = 0 To dgStavke.Rows.Count - 2
            If dgStavke.Rows(i).Cells(12).Value = _stopa Then _
                saberi_osnovice += dgStavke.Rows(i).Cells(5).Value * dgStavke.Rows(i).Cells(13).Value / (1 + (dgStavke.Rows(i).Cells(12).Value / 100))
        Next
    End Function

    Private Sub snimi_stavku()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim i As Integer

        _id_sastavnica = Nadji_id("pr_sastavnica_head")

        For i = 0 To dgStavke.Rows.Count - 2
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "pr_sastavnica_stavka_add"
                    .Parameters.AddWithValue("@id_sastavnica", _id_sastavnica)
                    .Parameters.AddWithValue("@id_magacin", dgStavke.Rows(i).Cells(10).Value)
                    .Parameters.AddWithValue("@sas_st_rb", dgStavke.Rows(i).Cells(0).Value)
                    .Parameters.AddWithValue("@sas_st_sifra", dgStavke.Rows(i).Cells(1).Value)
                    .Parameters.AddWithValue("@sas_st_naziv", dgStavke.Rows(i).Cells(2).Value)
                    .Parameters.AddWithValue("@sas_st_radna_taksa", CSng(dgStavke.Rows(i).Cells(3).Value))
                    .Parameters.AddWithValue("@sas_st_kolicina", CSng(dgStavke.Rows(i).Cells(4).Value))
                    .Parameters.AddWithValue("@sas_st_jm", dgStavke.Rows(i).Cells(5).Value)
                    .Parameters.AddWithValue("@sas_st_kolicina_skladistenja", CSng(dgStavke.Rows(i).Cells(6).Value))
                    .Parameters.AddWithValue("@sas_st_jm_skladistenja", dgStavke.Rows(i).Cells(7).Value)
                    .Parameters.AddWithValue("@sas_st_cena", CSng(dgStavke.Rows(i).Cells(8).Value))
                    .Parameters.AddWithValue("@sas_st_vrednist", CSng(dgStavke.Rows(i).Cells(9).Value))
                    .ExecuteScalar()
                End With
            End If
            CM.Dispose()
            CN.Close()
        Next
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
                '.Parameters.AddWithValue("@id_kalkulacija", _id_kalkulacija)
                '.Parameters.AddWithValue("@kalk_zakljucena", 1)
                .Parameters.AddWithValue(0, _id_dokument)
                .Parameters.AddWithValue(1, 1)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
        _unesen = True
        'zatvori_formu()
    End Sub
#End Region

    Private Sub cmbArtikl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbArtikl.KeyPress
        selektuj_artikl(RTrim(cmbArtikl.Text), Selekcija.po_nazivu)
        selektuj_magacin("", Selekcija._like, " LIKE N'%proizvo%'")
        selektuj_artikl_cenu(_id_artikl, _id_magacin)

        txtCenaPr.Text = _cena_nab_zadnja

        selektuj_jm(_artikl_id_jm, Selekcija.po_id)
        txtJMRp.Text = _jm_oznaka

        txtSifra.Select()
    End Sub

    Private Sub dateKalkulacija_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dateSast.KeyPress
        txtJMRp.Select()
    End Sub

    Private Sub txtJMRp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJMRp.KeyPress
        If e.KeyChar = Chr(13) Then
            txtKolicinaRp.Select()
        End If
    End Sub

    Private Sub txtKolicinaRp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKolicinaRp.KeyPress
        If e.KeyChar = Chr(13) Then
            txtKolicinaRp.Text = Format(CSng(txtKolicinaRp.Text), "#,##0.00000")
            txtCenaPr.Select()
        End If

    End Sub
    Private Sub txtKolicinaRp_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKolicinaRp.TextChanged
        If Not _pocetak Then
            Try
                preracunaj()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtCenaPr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCenaPr.KeyPress
        If e.KeyChar = Chr(13) Then
            txtSifra.Select()
        End If
    End Sub
    Private Sub txtCenaPr_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCenaPr.TextChanged
        If Not _pocetak Then
            Try
                preracunaj()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtSifra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSifra.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtSifra.Text = "" Then
                txtNaziv.Select()
            Else
                If txtSifra.Text <> "" And txtNaziv.Text = "" Then
                    artikl()
                End If
                txtKol.Select()
            End If
        End If
    End Sub

    Private Sub artikl()
        selektuj_artikl(RTrim(txtSifra.Text), Selekcija.po_sifri)
        txtNaziv.Text = _artikl_naziv

        selektuj_jm(_artikl_id_jm, Selekcija.po_id)
        txtJMskl.Text = _jm_oznaka
        _jm2 = _jm_sifra

    End Sub

    Private Sub txtNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNaziv.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtNaziv.Text = "" Then
                If txtSifra.Text <> "" Then
                    If MsgBox("Uneli ste šifru. Dali želite da nastavite da radite sa njom?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                        artikl()
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
                    selektuj_artikl(RTrim(txtNaziv.Text), Selekcija.po_nazivu)
                    txtSifra.Text = _artikl_sifra
                End If
            End If
        End If
        txtKol.Select()
    End Sub

    Private Sub txtKol_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKol.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                txtKol.Text = Format(CSng(txtKol.Text), "#,##0.00000")
                cmbJM.Select()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub txtKol_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKol.TextChanged
        Try
            If txtKol.Text <> "" Then
                txtKOLskl.Text = CSng(txtKol.Text) * _odnos_jedinica
            End If
            If txtKol.Text <> "" And txtCena.Text <> "" Then
                txtVred.Text = Format(CSng(txtCena.Text) * CSng(txtKOLskl.Text), "#,##0.00")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbJM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbJM.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                If cmbJM.SelectedText <> "" Then
                    txtCena.Select()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmbJM_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbJM.TextChanged
        Try
            If cmbJM.Text <> "" Then
                selektuj_jm(RTrim(cmbJM.Text), Selekcija.po_oznaci)
                _jm1 = _jm_sifra
                'txtCena.Select()
            End If
            _odnos_jedinica = odnos_jedinica(_jm1, _jm2)
            If txtKol.Text <> "" Then
                txtKOLskl.Text = CSng(txtKol.Text) * _odnos_jedinica
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtCena_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCena.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCena.Text = Format(CSng(txtCena.Text), "#,##0.00")
            btnUnesi.Select()
        End If
    End Sub
    Private Sub txtCena_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCena.TextChanged
        Try
            If txtKol.Text <> "" And txtCena.Text <> "" Then
                txtVred.Text = Format(CSng(txtCena.Text) * CSng(txtKOLskl.Text), "#,##0.00")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtJMskl_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJMskl.TextChanged
        Try
            If txtJMskl.Text <> "" Then
                selektuj_jm(txtJMskl.Text, Selekcija.po_oznaci)
                _jm2 = _jm_sifra
            End If
            _odnos_jedinica = odnos_jedinica(_jm1, _jm2)
            If txtKol.Text <> "" Then
                txtKOLskl.Text = CSng(txtKol.Text) * _odnos_jedinica
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnZakljuci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZakljuci.Click

    End Sub

    Private Sub btnNovi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovi.Click
        pocetak()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

End Class
