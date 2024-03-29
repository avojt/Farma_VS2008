Option Strict Off
Option Explicit On

Imports System.Xml
Imports System.ComponentModel
Imports System.IO

Imports System.Data.SqlClient

Public Class cntRobno_izlaz_edit


#Region "dekleracija"
    Private kol_pop As Single = 0
    Private kol_mag As Single = 0
    Private kol As Single = 0
    Private cena As Single = 0
    Private mp_cena As Single = 0
    Private c_cena_nab As Single = 0
    Private c_cena_vp As Single = 0
    Private c_cena_mp As Single = 0
    Private pdv As Single = 1
    Private c_pdv As Integer = 18
    Private rabat As Single = 0
    Private c_rabat As Integer = 0
    Private c_JM As String = ""
    Private c_Grupa As String = ""
    Private marza As Single = 0
    Private c_marza As Integer = 0
    Private lSifra As String = ""
    Private lNaziv As String = ""
    Private lKol As Single = 0
    Private lCena As Single = 0
    Private lId As Integer = 0
    Private ztroskovi_stavka As Single = 0
    Private s_nab_vrednost As Single = 0
    Private s_prod_vrednost As Single = 0
    Private s_pdv_osnovica As Single = 0
    Private s_pdv As Single = 0
    Private s_rab As Single = 0
    Private s_ztr As Single = 0
    Private s_marza As Single = 0
    Private s_ztroskovi As Single = 0
    Private s_ztros_proporcija As Single = 0
    Private valuta As Integer = 0
    Private nab_cena As Single = 0
    Private nab_vrednost As Single = 0
    Private prod_cena As Single = 0
    Private prod_vrednost As Single = 0
    Private trenutna_cena As Single = 0
    Private trenutna_kolicina As Single = 0
    Private sifra As String = ""
    Private naziv As String = ""
    Private indeks As Integer = 0
    Private broj_decimala() As Integer
    'Private id_predhodnog_stanja As Integer
    'Private id_predhodnog_stanja_stavka As Integer

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
    Private upit_sifra As String = ""
    Private upit_lek As String = ""

    Shared sql_start As String = ""
    Shared sql As String = ""

    Private _dokument As New clsRobno

#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntRobno_izlaz_edit_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If _ima_promena Then
            If MsgBox("Načinili ste promene. Dali želite da ih snimite?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                'snimi()
            End If
        End If

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

        _labHead.Text = Ispisi_label() + My.Resources.text_robno + My.Resources.text_search
        cntMeniRobno.podesi_boje_linkova(_mPanIzlazRobe_meni)
        _mLinkIzlazRobe_search.BackColor = Color.GhostWhite
        _mLinkIzlazRobe_search.ForeColor = Color.MidnightBlue
        cntMeniRobno.enable_linkove(_mPanIzlazRobe_meni)
        cntMeniRobno.enable_buttons(_mTableButtons)
    End Sub

    Private Sub cntRobno_ulaz_edit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'tlbMain.Dock = DockStyle.Fill
        sSpliter.Dock = DockStyle.Fill
        sSpliter.SplitterDistance = 270
        dgStavke.Dock = DockStyle.Fill

        broj_decimala = New Integer() {}
        ReDim broj_decimala(100)

        mRob_kontrola.tb_sifra = txtSifra
        mRob_kontrola.tb_naziv = txtNaziv
        mRob_kontrola.tb_grupa = txtGrupa
        mRob_kontrola.tb_grupa_naziv = txtGrupaNaziv
        mRob_kontrola.tb_jm = txtJM
        mRob_kontrola.tb_pdv = txtPdv
        mRob_kontrola.tb_nab_cena = txtNCena
        mRob_kontrola.tb_kol = txtKol
        mRob_kontrola.tb_marza = txtMarza

        _forma = Imena.tabele.rm_izlazni_dokument_head.ToString
        _mLabel = labLager
        _pocetak = True

        pocetak()
    End Sub

    Private Sub pocetak()
        _pocetak = True

        dgStavke.Rows.Clear()
        labLager.Text = "--"

        txtRabat.Visible = False
        txtBroj.Text = _dok_broj
        txtUkupno.Text = _dok_ukupno
        txtOsnovica.Text = _dok_pdv_osnovica
        txtIznosPdv.Text = _dok_pdv
        txtMarzaUkupno.Text = _dok_marza
        txtSvega.Text = _dok_svega
        txtFaktura.Text = _dok_opis
        cmbPartneri.Visible = True

        dateFaktura.Value = _dok_datum_fakture
        dateDokument.Value = _dok_datum

        popuni_magacine()
        popuni_oj()
        popuni_vrste_dokumenta()

        popuni_stavke()

        If _dok_zakljucen Then
            zatvori_formu()
        End If

        _pocetak = False

    End Sub

    Private Sub kontrole()
        Select Case _izabran_magacin
            Case True
                tlbMain.Enabled = True
                btnSnimi.Enabled = True
                btnZakljuci.Enabled = True
            Case False
                tlbMain.Enabled = False
                btnSnimi.Enabled = False
                btnZakljuci.Enabled = False
        End Select
        btnCancel.Enabled = True
    End Sub

    Private Sub popuni_oj()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbPartneri.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_organizacione_jedinice.* from dbo.app_organizacione_jedinice"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbPartneri.Items.Add(DR.Item("oj_naziv"))
            Loop
            DR.Close()
        End If
        If cmbPartneri.Items.Count > 0 Then
            selektuj_oj(_dok_id_partner, Selekcija.po_id)
            cmbPartneri.SelectedItem = _oj_naziv
        End If
        CM.Dispose()
        CN.Close()
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
            selektuj_magacin(_dok_id_magacina, Selekcija.po_id)
            cmbMagacin.SelectedItem = _magacin_naziv
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_vrste_dokumenta()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbVrstaDok.Items.Clear()
        'cmbVrstaDok.Items.Add("")
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_vrste_dokumenata.* from dbo.app_vrste_dokumenata where vrsta_dok_strana_knjizenja = 'POT' order by vrsta_dok_naziv"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbVrstaDok.Items.Add(DR.Item("vrsta_dok_naziv"))
            Loop
            DR.Close()
        End If
        If cmbVrstaDok.Items.Count > 0 Then
            selektuj_VrsteDokumenta(_dok_id_vrsta_dokumenta, Selekcija.po_id)
            cmbVrstaDok.SelectedItem = _vrsta_dok_naziv
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
            txtGrupaNaziv.Text = .Rows(e.RowIndex).Cells(4).Value
            selektuj_GrupeArt(.Rows(e.RowIndex).Cells(4).Value, Selekcija.po_nazivu)
            txtGrupa.Text = _gr_art_sifra
            txtKol.Text = .Rows(e.RowIndex).Cells(5).Value
            txtNCena.Text = .Rows(e.RowIndex).Cells(6).Value
            txtNVred.Text = .Rows(e.RowIndex).Cells(10).Value
            txtMarza.Text = .Rows(e.RowIndex).Cells(11).Value
            txtPdv.Text = .Rows(e.RowIndex).Cells(12).Value
            'txtPrCena.Text = .Rows(e.RowIndex).Cells(9).Value
            'txtPrVred.Text = .Rows(e.RowIndex).Cells(10).Value

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
                'tlbMain.RowStyles.Item(5).Height = 272 ' 1
                PictureBox1.BackgroundImage = My.Resources._3_Up
            Case False
                sSpliter.SplitterDistance = 35
                'tlbMain.RowStyles.Item(5).Height = 1
                PictureBox1.BackgroundImage = My.Resources._3_Down
        End Select
    End Sub

    Private Sub btnUnesi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnesi.Click
        unesi()
        'nova_stavka()
    End Sub

    Private Sub btnIzbrisi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzbrisi.Click
        dgStavke.Rows.RemoveAt(_row_index)
        nova_stavka()
    End Sub

    Private Sub btnIzmeni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzmeni.Click
        If txtKol.Text <> "" And CSng(txtKol.Text) <> 0 Then
            With dgStavke
                If txtSifra.Text <> "" Then .Rows(_row_index).Cells(1).Value = RTrim(txtSifra.Text)
                If txtNaziv.Text <> "" Then .Rows(_row_index).Cells(2).Value = RTrim(txtNaziv.Text)
                If txtJM.Text <> "" Then .Rows(_row_index).Cells(3).Value = RTrim(txtJM.Text)
                If txtGrupaNaziv.Text <> "" Then .Rows(_row_index).Cells(4).Value = RTrim(txtGrupaNaziv.Text)
                If txtKol.Text <> "" Then
                    .Rows(_row_index).Cells(5).Value = RTrim(txtKol.Text)
                Else
                    .Rows(_row_index).Cells(5).Value = 0
                End If
                If txtNCena.Text <> "" Then
                    .Rows(_row_index).Cells(6).Value = RTrim(txtNCena.Text)
                Else
                    .Rows(_row_index).Cells(6).Value = 0
                End If
                If txtRabat.Text <> "" Then
                    .Rows(_row_index).Cells(7).Value = RTrim(txtRabat.Text) 'rabat u %
                Else
                    .Rows(_row_index).Cells(7).Value = 0
                End If

                .Rows(_row_index).Cells(8).Value = 0

                Dim cena_kostanja As Single = CSng(txtNCena.Text) * (1 - (CSng(txtMarzaUkupno.Text) / 100))
                If txtNCena.Text <> "" And txtMarzaUkupno.Text <> "" Then
                    .Rows(_row_index).Cells(9).Value = Format(cena_kostanja, "#,##0.00")
                Else
                    .Rows(_row_index).Cells(9).Value = 0
                End If
                If txtNVred.Text <> "" Then
                    .Rows(_row_index).Cells(10).Value = RTrim(txtNVred.Text)
                Else
                    .Rows(_row_index).Cells(10).Value = 0
                End If
                If txtMarza.Text <> "" Then
                    .Rows(_row_index).Cells(11).Value = RTrim(txtMarza.Text)
                Else
                    .Rows(_row_index).Cells(11).Value = 0
                End If
                If txtPdv.Text <> "" Then
                    .Rows(_row_index).Cells(12).Value = RTrim(txtPdv.Text)
                Else
                    .Rows(_row_index).Cells(12).Value = 0
                End If
                Dim pdv As Integer = CInt(txtPdv.Text)
                If cena_kostanja <> 0 Then
                    .Rows(_row_index).Cells(13).Value = cena_kostanja '* (1+ (pdv/100))
                Else
                    .Rows(_row_index).Cells(13).Value = 0
                End If
                Dim mpc As Single = .Rows(_row_index).Cells(13).Value
                .Rows(_row_index).Cells(14).Value = .Rows(_row_index).Cells(5).Value * cena_kostanja * (pdv / 100)
                .Rows(_row_index).Cells(15).Value = mpc * .Rows(_row_index).Cells(5).Value

            End With

            preracunaj()
        Else
            MsgBox("Količina mora biti veća od 0. Molimo Vas ispravite grešku.")
        End If

    End Sub

    Private Sub btnNastavi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNastavi.Click
        nova_stavka()
        btnUnesi.Visible = True
        btnNastavi.Visible = False
        btnIzmeni.Visible = False
        btnIzbrisi.Visible = False
    End Sub

    Private Sub unesi()
        If txtKol.Text <> "" And CSng(txtKol.Text) <> 0 Then
            With dgStavke
                Dim i As Integer = dgStavke.RowCount - 1
                .Rows.Add(1)
                .Rows(i).Cells(0).Value = i + 1
                If txtSifra.Text <> "" Then .Rows(i).Cells(1).Value = RTrim(txtSifra.Text)
                If txtNaziv.Text <> "" Then .Rows(i).Cells(2).Value = RTrim(txtNaziv.Text)
                If txtJM.Text <> "" Then .Rows(i).Cells(3).Value = RTrim(txtJM.Text)
                If txtGrupaNaziv.Text <> "" Then .Rows(i).Cells(4).Value = RTrim(txtGrupaNaziv.Text)
                If txtKol.Text <> "" Then
                    .Rows(i).Cells(5).Value = RTrim(txtKol.Text)
                Else
                    .Rows(i).Cells(5).Value = 0
                End If
                If txtNCena.Text <> "" Then
                    .Rows(i).Cells(6).Value = RTrim(txtNCena.Text)
                Else
                    .Rows(i).Cells(6).Value = 0
                End If
                If txtRabat.Text <> "" Then
                    .Rows(i).Cells(7).Value = RTrim(txtRabat.Text) 'rabat u %
                Else
                    .Rows(i).Cells(7).Value = 0
                End If

                .Rows(i).Cells(8).Value = 0

                Dim cena_kostanja As Single = CSng(txtNCena.Text) * (1 - (CSng(txtMarzaUkupno.Text) / 100))
                If txtNCena.Text <> "" And txtMarzaUkupno.Text <> "" Then
                    .Rows(i).Cells(9).Value = Format(cena_kostanja, "#,##0.00")
                Else
                    .Rows(i).Cells(9).Value = 0
                End If
                If txtNVred.Text <> "" Then
                    .Rows(i).Cells(10).Value = RTrim(txtNVred.Text)
                Else
                    .Rows(i).Cells(10).Value = 0
                End If
                If txtMarza.Text <> "" Then
                    .Rows(i).Cells(11).Value = RTrim(txtMarza.Text)
                Else
                    .Rows(i).Cells(11).Value = 0
                End If
                If txtPdv.Text <> "" Then
                    .Rows(i).Cells(12).Value = RTrim(txtPdv.Text)
                Else
                    .Rows(i).Cells(12).Value = 0
                End If
                Dim pdv As Integer = CInt(txtPdv.Text)
                If cena_kostanja <> 0 Then
                    .Rows(i).Cells(13).Value = cena_kostanja '* (1+ (pdv/100))
                Else
                    .Rows(i).Cells(13).Value = 0
                End If
                Dim mpc As Single = .Rows(i).Cells(13).Value
                .Rows(i).Cells(14).Value = .Rows(i).Cells(5).Value * cena_kostanja * (pdv / 100)
                .Rows(i).Cells(15).Value = mpc * .Rows(i).Cells(5).Value

            End With
            preracunaj()
            nova_stavka()
        Else
            MsgBox("Količina mora biti veća od 0. Molimo Vas ispravite grešku.")
            txtKol.Select()
        End If


        'labLager.Text = "Stavka broj: " & dgStavke.Rows.Count
    End Sub
    Private Sub nova_stavka()
        txtSifra.Text = ""
        txtNaziv.Text = ""
        txtGrupa.Text = ""
        txtGrupaNaziv.Text = "" ' 0
        txtJM.Text = ""
        txtFaktura.Text = ""
        txtMarza.Text = 0
        txtKol.Text = 0
        txtNCena.Text = 0
        txtNVred.Text = 0
        txtPdv.Text = 0
        txtPrCena.Text = 0
        txtPrVred.Text = 0

        txtSifra.Select()
    End Sub

    Private Sub preracunaj()
        Dim i As Integer

        s_nab_vrednost = 0
        s_pdv = 0
        s_rab = 0
        s_ztr = 0
        s_marza = 0
        s_prod_vrednost = 0
        s_pdv_osnovica = 0

        Try
            For i = 0 To dgStavke.Rows.Count - 1
                Dim kol As Single = CSng(dgStavke.Rows(i).Cells(5).Value)
                Dim cena As Single = CSng(dgStavke.Rows(i).Cells(6).Value) ' n.cena
                Dim rab As Single = CSng(dgStavke.Rows(i).Cells(7).Value) ' rab %
                Dim ztr As Single = CSng(dgStavke.Rows(i).Cells(8).Value)
                Dim nabcena As Single = CSng(dgStavke.Rows(i).Cells(9).Value)
                Dim nabvr As Single = CSng(dgStavke.Rows(i).Cells(10).Value)
                Dim mar As Single = CSng(dgStavke.Rows(i).Cells(11).Value) 'marza %
                Dim pdv As Single = CInt(dgStavke.Rows(i).Cells(12).Value) ' pdv %
                Dim mp_cena As Single = CSng(dgStavke.Rows(i).Cells(13).Value)
                Dim pdv_iznos As Single = CSng(dgStavke.Rows(i).Cells(14).Value)
                Dim pr_vred As Single = CSng(dgStavke.Rows(i).Cells(15).Value)

                's_nab_vrednost = 0
                s_nab_vrednost += CSng(nabvr)
                Dim rabat As Single = kol * cena * (rab / 100)
                's_rab = 0
                s_rab += kol * cena * (rab / 100) 'iznos rab
                Dim marza As Single = kol * cena * (mar / 100)
                's_marza = 0
                s_marza += kol * cena * (mar / 100) 'iznos mar 
                's_pdv = 0
                s_pdv += kol * (cena * (1 - (rab / 100)) * (1 + (mar / 100)) * (pdv / 100)) 'iznos pdv na kolicinu
                's_pdv_osnovica = 0
                s_pdv_osnovica += CSng((kol * cena) - rabat + marza) '/ (1 + (pdv / 100)))
                's_prod_vrednost = 0
                s_prod_vrednost = s_pdv_osnovica + s_pdv 'ukupna suma po kolicini

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txtUkupno.Text = Format(s_nab_vrednost, "#,##0.00")
        txtMarzaUkupno.Text = Format(s_marza, "#,##0.00")
        txtOsnovica.Text = Format(s_pdv_osnovica, "#,##0.00")
        txtIznosPdv.Text = Format(s_pdv, "#,##0.00")
        txtSvega.Text = Format(s_prod_vrednost, "#,##0.00")

    End Sub

    Public Sub InitializeConfigure()

        Dim mxDoc As XmlDocument
        Dim xmlPath As String

        xmlPath = My.Application.Info.DirectoryPath & "\seme\" & "ulazni_dokumenti.xml"

        mxDoc = New XmlDocument()
        mxDoc.Load(xmlPath)

        Dim msw As New StringWriter()
        'Call ReadXMLFile(mxDoc, 0)

        'CNNString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & msp.База & ";Data Source=" & msp.Сервер
        'CNNString = "Data Source=" & msp.Сервер & ";Initial Catalog=" & msp.База & ";Persist Security Info=False;User ID=sa;Password=xxxx"

    End Sub

    Private Sub cmbVrstaDok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbVrstaDok.KeyPress
        cmbMagacin.Select()
    End Sub

    Private Sub cmbVrstaDok_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVrstaDok.SelectedIndexChanged

        If Not _pocetak Then
            txtSifra.Visible = True
            txtKol.Visible = True
            txtNCena.Visible = True
            txtNVred.Visible = True
            txtMarza.Visible = False
            Label3.Visible = False
            txtBroj.Visible = True
            txtFaktura.Visible = True
            txtGrupa.Visible = True
            txtGrupaNaziv.Visible = True
            txtIznosPdv.Visible = True
            txtJM.Visible = True
            txtNaziv.Visible = True
            txtOsnovica.Visible = True
            txtPdv.Visible = True
            'txtPrCena.Visible = True
            'txtPrVred.Visible = True
            txtMarzaUkupno.Visible = True
            txtSvega.Visible = True
            txtUkupno.Visible = True

            _dok_kolone = New String() {}

            If cmbVrstaDok.Text = "nivelacija cena" Then
                mRob_Dokument.tabela = Imena.tabele.rm_nivelacije_head.ToString
                mRob_Dokument.KonamdTekst = "rm_nivelacije"
                mRob_Dokument.dokumenta_id = 10
                ReDim _dok_kolone(2)
                _dok_kolone.SetValue("", 0)
                _dok_kolone.SetValue("nivelacija", 1)
                _dok_kolone.SetValue("", 2)

                sql_start = "SELECT DISTINCT " & _
                             "dbo.rm_nivelacije_head.broj, dbo.rm_nivelacije_head.datum, " & _
                             "dbo.rm_nivelacije_head.stara_vrednost, dbo.rm_nivelacije_head.nova_vrednost, " & _
                             "dbo.rm_nivelacije_head.razlika_uceni, dbo.rm_magacin.magacin_naziv " & _
                           "FROM dbo.rm_nivelacije_head LEFT OUTER JOIN " & _
                             "dbo.rm_magacin ON dbo.rm_nivelacije_head.id_magacin = dbo.rm_magacin.id_magacin"

            ElseIf cmbVrstaDok.Text = "popis" Then
                mRob_Dokument.tabela = Imena.tabele.rm_popis_head.ToString
                mRob_Dokument.KonamdTekst = "rm_popis"
                mRob_Dokument.dokumenta_id = 16
                ReDim _dok_kolone(2)
                _dok_kolone.SetValue("pop_", 0)
                _dok_kolone.SetValue("pop", 1)
                _dok_kolone.SetValue("pop_st", 2)
                sql_start = "SELECT DISTINCT " & _
                                        "dbo.rm_popis_head.pop_broj, dbo.rm_popis_head.pop_datum, " & _
                                        "dbo.rm_popis_head.pop_vrednost, dbo.rm_popis_head.pop_zakljucen, " & _
                                        "dbo.rm_magacin.magacin_sifra, dbo.rm_magacin.magacin_naziv " & _
                                     "FROM dbo.rm_popis_head INNER JOIN " & _
                                        "dbo.rm_magacin ON dbo.rm_popis_head.id_magacin = dbo.rm_magacin.id_magacin"

            Else
                mRob_Dokument.tabela = Imena.tabele.rm_izlazni_dokument_head.ToString
                mRob_Dokument.KonamdTekst = "rm_izlazni_dokument_head"
                selektuj_VrsteDokumenta(cmbVrstaDok.Text, Selekcija.po_nazivu)
                mRob_Dokument.dokumenta_id = _id_vrsta_dok
                ReDim _dok_kolone(2)
                _dok_kolone.SetValue("dok_", 0)
                _dok_kolone.SetValue("dokument", 1)
                _dok_kolone.SetValue("dok_st", 2)

                sql_start = "SELECT " & _
                    "rm_izlazni_dokument_head.dok_broj, " & _
                    "rm_izlazni_dokument_head.dok_datum, " & _
                    "rm_izlazni_dokument_head.dok_pdv_osnovica, " & _
                    "rm_izlazni_dokument_head.dok_zakljucen, " & _
                    "rm_magacin.magacin_sifra, " & _
                    "rm_magacin.magacin_naziv, " & _
                    "app_partneri.partner_sifra, " & _
                    "app_partneri.partner_naziv " & _
                    "FROM rm_izlazni_dokument_head LEFT OUTER JOIN " & _
                    "rm_magacin ON rm_izlazni_dokument_head.id_magacina = rm_magacin.id_magacin LEFT OUTER JOIN " & _
                    "app_partneri ON rm_izlazni_dokument_head.id_partner = app_partneri.id_partner"
            End If
        End If
    End Sub

    Private Function Partner(ByVal _partner) As Integer
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_organizacione_jedinice.* from dbo.app_organizacione_jedinice where oj_naziv = '" & _partner & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                Partner = DR.Item("id_orgjed")
            Loop
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Private Function Partner_ime(ByVal _id) As String
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Partner_ime = ""

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_organizacione_jedinice.* from dbo.app_organizacione_jedinice where id_orgjed = '" & _id & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                Partner_ime = DR.Item("oj_naziv")
            Loop
        End If
        CM.Dispose()
        CN.Close()

        Return Partner_ime

    End Function

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
                .CommandText = "select * from dbo.rm_izlazni_dokument_stavka where " & _
                                "dbo.rm_izlazni_dokument_stavka.id_dokument = " & _id_dokument
                DR = .ExecuteReader
            End With

            _broj_stavki = 0
            Do While DR.Read
                _broj_stavki += 1
            Loop
            DR.Close()

            _id_dokument_stavka = New Integer() {}
            ReDim _id_dokument_stavka(_broj_stavki - 1)

            With dgStavke
                Dim i As Integer = 0
                DR = CM.ExecuteReader
                Do While DR.Read
                    .Rows.Add(1)
                    If Not IsDBNull(DR.Item("id_dok_st")) Then _id_dokument_stavka.SetValue(DR.Item("id_dok_st"), i)
                    If Not IsDBNull(DR.Item("dok_st_rb")) Then .Rows(i).Cells(0).Value = RTrim(DR.Item("dok_st_rb"))
                    If Not IsDBNull(DR.Item("dok_st_roba_sifra")) Then .Rows(i).Cells(1).Value = DR.Item("dok_st_roba_sifra")
                    If Not IsDBNull(DR.Item("dok_st_roba_naziv")) Then .Rows(i).Cells(2).Value = DR.Item("dok_st_roba_naziv")
                    If Not IsDBNull(DR.Item("dok_st_roba_jm")) Then .Rows(i).Cells(3).Value = RTrim(DR.Item("dok_st_roba_jm"))
                    If Not IsDBNull(DR.Item("dok_st_roba_grupa_oznaka")) Then .Rows(i).Cells(4).Value = DR.Item("dok_st_roba_grupa_oznaka")
                    If Not IsDBNull(DR.Item("dok_st_kolicina")) Then .Rows(i).Cells(5).Value = DR.Item("dok_st_kolicina")
                    If Not IsDBNull(DR.Item("dok_st_nab_cena")) Then .Rows(i).Cells(6).Value = DR.Item("dok_st_nab_cena")
                    If Not IsDBNull(DR.Item("dok_st_rabat")) Then .Rows(i).Cells(7).Value = DR.Item("dok_st_rabat")
                    If Not IsDBNull(DR.Item("dok_st_zav_troskovi")) Then .Rows(i).Cells(8).Value = DR.Item("dok_st_zav_troskovi")
                    If Not IsDBNull(DR.Item("dok_st_cena_kostanja")) Then .Rows(i).Cells(9).Value = DR.Item("dok_st_cena_kostanja")
                    If Not IsDBNull(DR.Item("dok_st_nab_vred")) Then .Rows(i).Cells(10).Value = DR.Item("dok_st_nab_vred")
                    If Not IsDBNull(DR.Item("dok_st_marza")) Then .Rows(i).Cells(11).Value = DR.Item("dok_st_marza")
                    If Not IsDBNull(DR.Item("dok_st_pdv")) Then .Rows(i).Cells(12).Value = DR.Item("dok_st_pdv")
                    If Not IsDBNull(DR.Item("dok_st_prod_cena")) Then .Rows(i).Cells(13).Value = DR.Item("dok_st_prod_cena")
                    If Not IsDBNull(DR.Item("dok_st_pdv_iznos")) Then .Rows(i).Cells(14).Value = DR.Item("dok_st_pdv_iznos")
                    If Not IsDBNull(DR.Item("dok_st_prod_vred")) Then .Rows(i).Cells(15).Value = DR.Item("dok_st_prod_vred")
                    i += 1
                Loop
                DR.Close()
            End With
        End If
        CM.Dispose()
        CN.Close()

        _citam_stavke = False
        _popunjavam_robu = False
        'preracunaj()

    End Sub

#Region "Troskovi"

    'Private Sub chkProcenat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProcenat.CheckedChanged
    '    'Select Case chkProcenat.CheckState
    '    '    Case CheckState.Checked
    '    '        chkIznos.Checked = False
    '    '        txtZTIznos.Enabled = False
    '    '    Case CheckState.Unchecked
    '    '        chkIznos.Checked = True
    '    '        txtZTIznos.Enabled = True
    '    '        txtZTIznos.Text = 0
    '    '        txtProporcija.Text = 0
    '    'End Select
    'End Sub

    'Private Sub chkIznos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIznos.CheckedChanged
    '    Select Case chkIznos.CheckState
    '        Case CheckState.Checked
    '            chkProcenat.Checked = False
    '            txtZTProcenat.Enabled = False
    '        Case CheckState.Unchecked
    '            chkProcenat.Checked = True
    '            txtZTProcenat.Enabled = True
    '            txtZTProcenat.Text = 0
    '    End Select
    'End Sub

    'Private Sub chkZT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkZT.CheckedChanged
    '    Select Case chkZT.CheckState
    '        Case CheckState.Checked
    '            tableZT.Enabled = True
    '            chkProcenat.Checked = True
    '        Case CheckState.Unchecked
    '            tableZT.Enabled = False
    '    End Select
    'End Sub

    'Private Sub raspodeli_troskove()
    '    'Dim i As Integer

    '    'If chkIznos.CheckState = CheckState.Checked Then
    '    '    If txtZTIznos.Text <> "" Then
    '    '        If jeste_broj(txtZTIznos.Text) Then
    '    '            Dim suma As Single = 0
    '    '            With dgStavke
    '    '                For i = 0 To .RowCount - 2
    '    '                    Dim kol As Single = .Rows(i).Cells(3).Value
    '    '                    Dim cena As Single = .Rows(i).Cells(4).Value
    '    '                    Dim rabat As Integer = .Rows(i).Cells(5).Value
    '    '                    suma += kol * (cena * (1 - (rabat / 100)))
    '    '                Next

    '    '                If suma > 0 Then
    '    '                    txtProporcija.Text = CStr(CSng(txtZTIznos.Text) / suma * 100) & "%"
    '    '                Else
    '    '                    txtProporcija.Text = CSng(txtZTIznos.Text)
    '    '                End If

    '    '                For i = 0 To .RowCount - 2
    '    '                    If suma > 0 Then
    '    '                        ztroskovi_stavka = .Rows(i).Cells(4).Value * CSng(txtZTIznos.Text) / suma
    '    '                        .Rows(i).Cells(6).Value = .Rows(i).Cells(4).Value * CSng(txtZTIznos.Text) / suma
    '    '                    Else
    '    '                        ztroskovi_stavka = CSng(txtZTIznos.Text)
    '    '                        .Rows(i).Cells(6).Value = CSng(txtZTIznos.Text)
    '    '                    End If
    '    '                Next
    '    '            End With
    '    '        Else
    '    '            MsgBox("Uneli ste slovni karakter ili neki drugi znak." & vbLf & "Molimo Vas ispravite gresku", MsgBoxStyle.OkOnly)
    '    '        End If
    '    '    Else
    '    '        ztroskovi_stavka = 0
    '    '        dgStavke.Rows(i).Cells(6).Value = 0
    '    '    End If

    '    'Else 'na procenat
    '    '    If chkProcenat.CheckState = CheckState.Checked Then
    '    '        If txtZTProcenat.Text <> "" Then
    '    '            If jeste_broj(txtZTProcenat.Text) Then
    '    '                Dim suma As Single = 0
    '    '                With dgStavke
    '    '                    For i = 0 To .RowCount - 2
    '    '                        Dim kol As Single = .Rows(i).Cells(3).Value
    '    '                        Dim cena As Single = .Rows(i).Cells(4).Value
    '    '                        Dim rabat As Integer = .Rows(i).Cells(5).Value
    '    '                        suma += kol * (cena * (1 - (rabat / 100)))
    '    '                    Next

    '    '                    If suma > 0 Then
    '    '                        txtUkupnoPrc.Text = suma * CSng(txtZTProcenat.Text) / 100
    '    '                    Else
    '    '                        txtUkupnoPrc.Text = 0
    '    '                    End If

    '    '                    For i = 0 To .RowCount - 2
    '    '                        If suma > 0 Then
    '    '                            ztroskovi_stavka = .Rows(i).Cells(4).Value * CSng(txtZTProcenat.Text) / 100
    '    '                            .Rows(i).Cells(6).Value = .Rows(i).Cells(4).Value * CSng(txtZTProcenat.Text) / 100
    '    '                        Else
    '    '                            ztroskovi_stavka = 0
    '    '                            .Rows(i).Cells(6).Value = 0
    '    '                        End If
    '    '                    Next
    '    '                End With
    '    '            Else
    '    '                MsgBox("Uneli ste slovni karakter ili neki drugi znak." & vbLf & "Molimo Vas ispravite gresku", MsgBoxStyle.OkOnly)
    '    '            End If
    '    '        Else
    '    '            ztroskovi_stavka = 0
    '    '            dgStavke.Rows(i).Cells(6).Value = 0
    '    '        End If
    '    '    End If
    '    'End If
    'End Sub

    'Private Sub txtZTIznos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZTIznos.TextChanged
    '    raspodeli_troskove()
    'End Sub

    'Private Sub txtZTProcenat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZTProcenat.TextChanged
    '    raspodeli_troskove()
    'End Sub
#End Region

#Region "Snimi"

    Private Sub btnSnimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSnimi.Click
        Dim i As Integer = 0
        Dim _dalje As Boolean = False

        For i = 0 To dgStavke.RowCount - 2
            If CSng(dgStavke.Rows(i).Cells(5).Value) = 0 Then
                MsgBox("Količina ne može da ostati neušena.")
                _dalje = False
                Exit For
            Else
                _dalje = True
            End If
        Next

        If _dalje Then
            snimi_head()
            snimi_pdv()
            snimi_stavku()
            snimi_cene()

            unesi_dnevni_promet_head(Today.Date, Now, _id_magacin, 0, Partner_id(cmbPartneri.Text), _
                             mRob_Dokument.dokumenta_id, _id_dokument, txtBroj.Text, txtSvega.Text, _
                             0, 1, 0, vrsta_promene.editovanje)

            _id_dnevni_promet = Nadji_id(Imena.tabele.rm_dnevni_promet_head.ToString)

            For i = 0 To dgStavke.Rows.Count - 2
                selektuj_artikl(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)
                unesi_dnevni_promet_stavka(_id_dnevni_promet, _id_magacin, _id_artikl, dgStavke.Rows(i).Cells(5).Value, 0, _
                        CSng(dgStavke.Rows(i).Cells(9).Value), dgStavke.Rows(i).Cells(12).Value, True, False)
            Next

            'selektuj_dokument(_id_dokumenta, Selekcija.po_id)
            'pocetak()

        End If

    End Sub

    Private Sub snimi_head()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim ztros As Single = 0

        selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_izlazni_dokument_head_update"
                .Parameters.AddWithValue("@id_dokument", _id_dokument)
                .Parameters.AddWithValue("@id_vrsta_dokumenta", mRob_Dokument.dokumenta_id)
                selektuj_VrsteDokumenta(mRob_Dokument.dokumenta_id, Selekcija.po_id)
                .Parameters.AddWithValue("@sifra_dokumenta", _vrsta_dok_vrsta)
                .Parameters.AddWithValue("@dok_broj", CInt(txtBroj.Text))
                .Parameters.AddWithValue("@id_magacina", _id_magacin)
                .Parameters.AddWithValue("@id_partner", Partner(cmbPartneri.Text))
                .Parameters.AddWithValue("@dok_datum_fakture", dateFaktura.Value.Date)
                .Parameters.AddWithValue("@dok_datum", dateDokument.Value.Date)
                .Parameters.AddWithValue("@dok_opis", txtFaktura.Text)
                .Parameters.AddWithValue("@dok_ukupno", CSng(txtUkupno.Text))
                .Parameters.AddWithValue("@dok_ztroskovi", ztros)
                .Parameters.AddWithValue("@dok_marza", CSng(txtMarzaUkupno.Text))
                .Parameters.AddWithValue("@dok_rabat", 0)
                .Parameters.AddWithValue("@dok_razlika_uceni", CSng(txtOsnovica.Text) - CSng(txtUkupno.Text) + CSng(txtMarzaUkupno.Text))
                .Parameters.AddWithValue("@dok_pdv_osnovica", CSng(txtOsnovica.Text))
                .Parameters.AddWithValue("@dok_pdv", CSng(txtIznosPdv.Text))
                .Parameters.AddWithValue("@dok_svega", CSng(txtSvega.Text))
                .Parameters.AddWithValue("@dok_zakljucen", _dok_zakljucen)
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
                .CommandText = "rm_izlazni_dokument_pdv_delete"
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
                        .CommandText = "rm_izlazni_dokument_pdv_add"
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
        Dim i, n As Integer

        '_id_kalkulacija = Nadji_id(Imena.tabele.rm_kalkulacija_head.ToString)

        CN.Open()
        If _id_dokument_stavka.Length > dgStavke.Rows.Count - 1 Then
            n = _id_dokument_stavka.Length - 1
        Else
            n = dgStavke.Rows.Count - 2
        End If
        For i = 0 To n
            If (i <= dgStavke.Rows.Count - 2 Or Not _id_dokument_stavka.Length > dgStavke.Rows.Count - 1) _
                Or _id_dokument_stavka.Length = 0 Then
                If i > _id_dokument_stavka.Length - 1 Then '_id_racun_stavka(i) = 0 Then
                    CM = New SqlCommand()
                    If CN.State = ConnectionState.Open Then
                        With CM
                            .Connection = CN
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "rm_izlazni_dokument_stavka_add"
                            .Parameters.AddWithValue("@id_dokument", _id_dokument) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                            .Parameters.AddWithValue("@dok_st_rb", RTrim(dgStavke.Rows(i).Cells(0).Value))
                            .Parameters.AddWithValue("@dok_st_roba_sifra", dgStavke.Rows(i).Cells(1).Value)
                            .Parameters.AddWithValue("@dok_st_roba_naziv", dgStavke.Rows(i).Cells(2).Value)
                            selektuj_artikl(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)
                            selektuj_GrupeArt(_artikl_id_grupa, Selekcija.po_id)
                            .Parameters.AddWithValue("@dok_st_roba_grupa_sifra", _gr_art_sifra)
                            .Parameters.AddWithValue("@dok_st_roba_grupa_oznaka", dgStavke.Rows(i).Cells(4).Value)
                            .Parameters.AddWithValue("@dok_st_roba_jkl", _artikl_jkl)
                            selektuj_jm(_artikl_id_jm, Selekcija.po_id)
                            .Parameters.AddWithValue("@dok_st_roba_jm", _jm_oznaka)
                            .Parameters.AddWithValue("@dok_st_kolicina", CSng(dgStavke.Rows(i).Cells(5).Value))
                            .Parameters.AddWithValue("@dok_st_nab_cena", CSng(dgStavke.Rows(i).Cells(6).Value))
                            .Parameters.AddWithValue("@dok_st_rabat", CSng(dgStavke.Rows(i).Cells(7).Value))
                            .Parameters.AddWithValue("@dok_st_zav_troskovi", CSng(dgStavke.Rows(i).Cells(8).Value))
                            .Parameters.AddWithValue("@dok_st_cena_kostanja", CSng(dgStavke.Rows(i).Cells(9).Value))
                            .Parameters.AddWithValue("@dok_st_nab_vred", CSng(dgStavke.Rows(i).Cells(10).Value))
                            .Parameters.AddWithValue("@dok_st_marza", CSng(dgStavke.Rows(i).Cells(11).Value))
                            .Parameters.AddWithValue("@dok_st_pdv", CSng(dgStavke.Rows(i).Cells(12).Value))
                            .Parameters.AddWithValue("@dok_st_prod_cena", CSng(dgStavke.Rows(i).Cells(13).Value))
                            .Parameters.AddWithValue("@dok_st_pdv_iznos", CSng(dgStavke.Rows(i).Cells(14).Value))
                            .Parameters.AddWithValue("@dok_st_prod_vred", CSng(dgStavke.Rows(i).Cells(15).Value))
                            .ExecuteScalar()
                        End With
                    End If
                    CM.Dispose()
                Else
                    CM = New SqlCommand()
                    If CN.State = ConnectionState.Open Then
                        With CM
                            .Connection = CN
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "rm_izlazni_dokument_stavka_update"
                            .Parameters.AddWithValue("@id_dok_st", _id_dokument_stavka(i))
                            .Parameters.AddWithValue("@dok_st_rb", RTrim(dgStavke.Rows(i).Cells(0).Value))
                            .Parameters.AddWithValue("@dok_st_roba_sifra", dgStavke.Rows(i).Cells(1).Value)
                            .Parameters.AddWithValue("@dok_st_roba_naziv", dgStavke.Rows(i).Cells(2).Value)
                            selektuj_artikl(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)
                            selektuj_GrupeArt(_artikl_id_grupa, Selekcija.po_id)
                            .Parameters.AddWithValue("@dok_st_roba_grupa_sifra", _gr_art_sifra)
                            .Parameters.AddWithValue("@dok_st_roba_grupa_oznaka", dgStavke.Rows(i).Cells(4).Value)
                            .Parameters.AddWithValue("@dok_st_roba_jkl", _artikl_jkl)
                            selektuj_jm(_artikl_id_jm, Selekcija.po_id)
                            .Parameters.AddWithValue("@dok_st_roba_jm", _jm_oznaka)
                            .Parameters.AddWithValue("@dok_st_kolicina", CSng(dgStavke.Rows(i).Cells(5).Value))
                            .Parameters.AddWithValue("@dok_st_nab_cena", CSng(dgStavke.Rows(i).Cells(6).Value))
                            .Parameters.AddWithValue("@dok_st_rabat", CSng(dgStavke.Rows(i).Cells(7).Value))
                            .Parameters.AddWithValue("@dok_st_zav_troskovi", CSng(dgStavke.Rows(i).Cells(8).Value))
                            .Parameters.AddWithValue("@dok_st_cena_kostanja", CSng(dgStavke.Rows(i).Cells(9).Value))
                            .Parameters.AddWithValue("@dok_st_nab_vred", CSng(dgStavke.Rows(i).Cells(10).Value))
                            .Parameters.AddWithValue("@dok_st_marza", CSng(dgStavke.Rows(i).Cells(11).Value))
                            .Parameters.AddWithValue("@dok_st_pdv", CSng(dgStavke.Rows(i).Cells(12).Value))
                            .Parameters.AddWithValue("@dok_st_prod_cena", CSng(dgStavke.Rows(i).Cells(13).Value))
                            .Parameters.AddWithValue("@dok_st_pdv_iznos", CSng(dgStavke.Rows(i).Cells(14).Value))
                            .Parameters.AddWithValue("@dok_st_prod_vred", CSng(dgStavke.Rows(i).Cells(15).Value))
                            .ExecuteScalar()
                        End With
                    End If
                    CM.Dispose()
                End If
            Else
                CM = New SqlCommand()
                If CN.State = ConnectionState.Open Then
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "rm_izlazni_dokument_stavka_delete"
                        .Parameters.AddWithValue("@id_dok_st", _id_dokument_stavka(i))
                        .ExecuteScalar()
                    End With
                End If
                CM.Dispose()
            End If
        Next
        CN.Close()
    End Sub

    Private Sub snimi_cene()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim i As Integer

        CN.Open()
        For i = 0 To dgStavke.Rows.Count - 2
            selektuj_artikl(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_artikli_cene.* from dbo.rm_artikli_cene where id_artikl = " & _id_artikl & " and id_magacin = " & magacinID
                DR = .ExecuteReader
            End With
            _id_artikl_cena = 0
            Do While DR.Read
                _id_artikl_cena = DR.Item("id_cena_robe")
            Loop
            DR.Close()
            CM.Dispose()

            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    Select Case _id_artikl_cena
                        Case Is <> 0
                            .CommandText = "rm_artikli_cene_update"
                            .Parameters.AddWithValue("@id_cena_robe", _id_artikl_cena)
                        Case Is = 0
                            .CommandText = "rm_artikli_cene_add"
                            .Parameters.AddWithValue("@id_artikl", _id_artikl)
                            'selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)
                            .Parameters.AddWithValue("@id_magacin", magacinID)
                    End Select

                    Dim nab As Single = dgStavke.Rows(i).Cells(6).Value
                    Dim mar As Single = dgStavke.Rows(i).Cells(11).Value
                    Dim por As Single = dgStavke.Rows(i).Cells(12).Value
                    Dim rab As Single = dgStavke.Rows(i).Cells(7).Value
                    Dim mpcena As Single = nab * (1 + (mar / 100)) * (1 + (por / 100))

                    .Parameters.AddWithValue("@cena_nab_zadnja", nab) ' dgStavke.Rows(i).Cells(6).Value)
                    .Parameters.AddWithValue("@cena_vp1", nab) ' dgStavke.Rows(i).Cells(6).Value) ' dgStavke.Rows(i).Cells(13).Value / (1 + (dgStavke.Rows(i).Cells(12).Value / 100)))
                    .Parameters.AddWithValue("@cena_vp2", 0)
                    .Parameters.AddWithValue("@cena_vp3", 0)
                    .Parameters.AddWithValue("@cena_mp", mpcena)
                    .Parameters.AddWithValue("@pdv", por)
                    .Parameters.AddWithValue("@rabat", rab)
                    .Parameters.AddWithValue("@marza", mar)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
        Next
        CN.Close()
    End Sub

#End Region

#Region "Zakljuci"
    Private Sub btnZakljuci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZakljuci.Click
        _id_partner = 0
        selektuj_oj(cmbPartneri.Text, Selekcija.po_nazivu)

        prebaci_u_magacin_promene(_id_magacin, mRob_Dokument.dokumenta_id, txtBroj.Text)
        prebaci_u_magacin_promene_stavka(_id_dnevni_promet)
        zakljuci_dokument()
    End Sub

    Private Sub zakljuci_dokument()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_izlazni_dokument_zakljuci"
                .Parameters.AddWithValue("@id_dokument", _id_dokument)
                .Parameters.AddWithValue("@dok_zakljucen", 1)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()

        zatvori_formu()
    End Sub
#End Region

    Private Sub zatvori_formu()
        TableLayoutPanel2.Enabled = False
        dgStavke.AllowUserToAddRows = False
        dgStavke.Enabled = False

        btnSnimi.Enabled = False
        btnZakljuci.Enabled = False
        btnZakljuci.Enabled = False

        labStatusNaloga.Text = "DOKUMENT JE ZAKLJUČEN. NE MOŽETE GA MENJATI."

    End Sub

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
        cmbPartneri.Select()
    End Sub

    Private Sub cmbPartneri_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPartneri.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbPartneri.Text <> "" Then
                selektuj_partnera(RTrim(cmbPartneri.Text), Selekcija.po_nazivu)
            End If
            txtFaktura.Select()
        End If
    End Sub

    Private Sub txtFaktura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFaktura.KeyPress
        If e.KeyChar = Chr(13) Then
            dateFaktura.Select()
        End If
    End Sub

    Private Sub dateFaktura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dateFaktura.KeyPress
        If e.KeyChar = Chr(13) Then
            txtSifra.Select()
        End If
    End Sub

    Private Sub dateFaktura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateFaktura.ValueChanged
        txtSifra.Select()
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
        selektuj_GrupeArt(_artikl_id_grupa, Selekcija.po_id)
        txtGrupa.Text = _gr_art_sifra
        txtMarza.Text = _gr_art_marza
        txtGrupaNaziv.Text = _gr_art_skraceno
        selektuj_jm(_artikl_id_jm, Selekcija.po_id)
        txtJM.Text = _jm_oznaka
        selektuj_pdv(_artikl_id_pdv, Selekcija.po_id)
        txtPdv.Text = _pdv_stopa
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
        If e.KeyChar = Chr(13) Then
            If txtKol.Text <> "" And txtNCena.Text <> "" Then
                txtKol.Text = Format(CSng(txtKol.Text), "#,##0")
            Else
                If txtKol.Text = "" Then
                    txtKol.Text = 0
                End If
            End If
            txtNCena.Select()
        End If
    End Sub
    Private Sub txtKol_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKol.TextChanged
        If txtKol.Text <> "" And txtNCena.Text <> "" Then
            txtNVred.Text = Format(CSng(txtNCena.Text) * CSng(txtKol.Text), "#,##0.00")
        End If
    End Sub

    Private Sub txtNCena_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNCena.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtKol.Text <> "" And txtNCena.Text <> "" Then
                txtNCena.Text = Format(CSng(txtNCena.Text), "#,##0.00")
            End If
            If txtRabat.Visible = True Then
                txtRabat.Select()
            Else
                btnUnesi.Select()
            End If
        End If
    End Sub
    Private Sub txtNCena_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNCena.TextChanged
        If txtKol.Text <> "" And txtNCena.Text <> "" Then
            txtNVred.Text = Format(CSng(txtNCena.Text) * CSng(txtKol.Text), "#,##0.00")
        End If
    End Sub

    Private Sub txtRabat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRabat.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtRabat.Text = "" Then
                txtRabat.Text = "0"
            End If
            If btnIzmeni.Visible = True Then
                btnIzmeni.Select()
            Else
                btnUnesi.Select()
            End If
        End If
    End Sub

    Private Sub btnNovi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class
