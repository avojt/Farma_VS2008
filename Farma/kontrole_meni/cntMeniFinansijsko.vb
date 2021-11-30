Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class cntMeniFinansijsko
    Private _visina As Integer = 230

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntMeniFinansijsko_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()

        If Not _povratak Then
            _korak_nazad.SetValue(Me.Name.ToString, zadnji_zapis(_korak_nazad))
            _korak_labHead.SetValue(Me.Name.ToString, zadnji_zapis(_korak_labHead))
        End If
        _labHead.Text = Ispisi_label()
        _povratak = False
    End Sub

    Private Sub pocetak()
        panGlavni.Height = 252
        podesi_kontrole()
        podesi_visinu()
        podesi_boje()
    End Sub

    Private Sub podesi_kontrole()
        _mPanNalog_kontejn = panNalog_kontejner
        _mPanNalog_meni = panNalog_meni
        _mLinkNalog_search = linkNalog_search
        _mLinkNalog_edit = linkNalog_edit

        _mPanKartice_kontejn = panKartice_kontejner
        _mPanKartice_meni = panKartice_meni
        _mLinkKartice_search = linkKartice_GKnjige
      
        _mPanAnalPart_kontejn = panAnalPart_kontejner
        _mPanAnalPart_meni = panAnalPart_meni
        _mLinkAnalPart_search = linkAnalitPart_search

        _mPanAnalOstalo_kontejn = panAnalOstalo_kontejner
        _mPanAnalOstalo_meni = panAnalOstalo_meni

        _mPanAlati_kontejn = panAlati_kontejner
        _mPanAlati_meni = panAlati_meni

        _mTableButtons = tableButtons
    End Sub

    Private Sub podesi_visinu()
        With _mTableButtons
            .Height = _visina
            .RowStyles.Item(1).Height = 8
            .RowStyles.Item(3).Height = 8
            .RowStyles.Item(5).Height = 8
            .RowStyles.Item(7).Height = 8
            .RowStyles.Item(9).Height = 8
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

#Region "Nalozi za knjizenje"
    Private Sub btnNalozi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNalozi.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntNalog
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        _mSpliter.SplitterDistance = 215

        Dim myControl As New cntNalog_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        podesi_boje()
        btnNalozi.BackColor = Color.LightSteelBlue
        btnNalozi.Enabled = False

        _labHead.Text = Ispisi_label() + My.Resources.text_nalog + My.Resources.text_search

        podesi_visinu()
        _mTableButtons.RowStyles.Item(1).Height = 130
        panGlavni.Height = _visina - 8 + _mTableButtons.RowStyles.Item(1).Height + 26

    End Sub

    Private Sub linkNalog_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkNalog_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 215

        Dim myControl As New cntNalog_search
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_nalog + My.Resources.text_search
        podesi_boje_linkova(panNalog_meni)
        linkNalog_search.BackColor = Color.GhostWhite
        linkNalog_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkNalog_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkNalog_add.LinkClicked
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntNalog_add
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_nalog + My.Resources.text_add
        podesi_boje_linkova(panNalog_meni)
        linkNalog_add.BackColor = Color.GhostWhite
        linkNalog_add.LinkColor = Color.MidnightBlue
        disable_linkove(panNalog_meni)
        disable_buttons(tableButtons)
    End Sub

    Private Sub linkNalog_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkNalog_edit.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati nalog")
                Exit Sub
            Else
                _nal_broj = _lista.SelectedItems.Item(0).SubItems(1).Text
                _nal_vrsta = _lista.SelectedItems.Item(0).Text
                selektuj_nalog(RTrim(_nal_broj), Selekcija.po_sifri, _nal_vrsta)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntNalog_edit
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + My.Resources.text_nalog + My.Resources.text_edit
                podesi_boje_linkova(panNalog_meni)
                linkNalog_edit.BackColor = Color.GhostWhite
                linkNalog_edit.LinkColor = Color.MidnightBlue
                disable_linkove(panNalog_meni)
                disable_buttons(tableButtons)
            End If
        End If
    End Sub

    Private Sub linknalog_storno_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linknalog_storno.LinkClicked
        If Not IsNothing(_lista) Then
            If _lista.SelectedItems.Count = 0 Then
                MsgBox("Prvo morate izabrati nalog")
                Exit Sub
            Else
                _nal_broj = _lista.SelectedItems.Item(0).SubItems(1).Text
                _nal_vrsta = _lista.SelectedItems.Item(0).Text
                selektuj_nalog(RTrim(_nal_broj), Selekcija.po_sifri, _nal_vrsta)

                mdiMain.zatvori_kontrolu_desno()
                Dim myControl As New cntNalog_storno
                myControl.Parent = mdiMain.splRadni.Panel2
                myControl.Dock = DockStyle.Fill
                myControl.Show()

                _labHead.Text = Ispisi_label() + My.Resources.text_nalog + My.Resources.text_edit
                podesi_boje_linkova(panNalog_meni)
                linkNalog_edit.BackColor = Color.GhostWhite
                linkNalog_edit.LinkColor = Color.MidnightBlue
                disable_linkove(panNalog_meni)
                disable_buttons(tableButtons)
            End If
        End If
    End Sub

    Private Sub linkNalog_del_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkNalog_del.LinkClicked
        cntNalog.myDelete()
    End Sub

    Private Sub linkNalog_Print_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkNalog_Print.LinkClicked
        cntNalog.prn()
    End Sub

#End Region

#Region "prebacivanje iz njihove baze"
    Private CNN_PBS = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=PBS;Data Source=" & msp.Server
    Public c_MyConnStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\RZZO.mdb" ';Mode=Share Deny None"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Dim CN1 As SqlConnection = New SqlConnection(CNN_PBS)
        Dim CM1 As New SqlCommand
        Dim DR1 As SqlDataReader

        CN1.Open()
        CN.Open()
        'If CN1.State = ConnectionState.Open Then
        'CM1 = New SqlCommand()
        'With CM1
        '    .Connection = CN1
        '    .CommandType = CommandType.Text
        '    .CommandText = "SELECT dbo.Konto.* from dbo.Konto"
        '    DR1 = .ExecuteReader
        'End With

        'Dim Konto_Sifra As String = ""
        'Dim Naziv_L1 As String = ""
        'Dim Dozvoljeno_Knjizenje As Boolean = False
        'Dim Devizno_Knjizenje As Boolean = False
        'Dim Pocetno_Stanje As Boolean = False
        'Dim Aktiva_Pasiva As String = ""
        'Dim Bilansno_Vanbilansno As String = ""
        'Dim Vazi_Do As DateTime
        'Dim Podatak_Neaktivan As Boolean = False
        'Dim Konto_Ispravke As Boolean = False
        'Dim Vrsta_Analitike_Sifra As String = ""
        'Dim Nivo_Pocetnog_Stanja As String = ""
        'Dim Nivo_Zatvaranja As String = ""
        'Dim artikl_aktivan As Boolean = False

        'While DR1.Read
        'Konto_Sifra = DR1.Item("Konto_Sifra").ToString
        'Naziv_L1 = DR1.Item("Naziv_L1").ToString
        'Dozvoljeno_Knjizenje = DR1.Item("Dozvoljeno_Knjizenje").ToString
        'Devizno_Knjizenje = DR1.Item("Devizno_Knjizenje").ToString
        'Pocetno_Stanje = DR1.Item("Pocetno_Stanje").ToString
        'Aktiva_Pasiva = DR1.Item("Aktiva_Pasiva").ToString
        'Bilansno_Vanbilansno = DR1.Item("Bilansno_Vanbilansno").ToString
        'If Not IsDBNull(DR1.Item("Vazi_Do")) Then Vazi_Do = DR1.Item("Vazi_Do")
        'Konto_Ispravke = DR1.Item("Konto_Ispravke").ToString
        'Podatak_Neaktivan = DR1.Item("Podatak_Neaktivan").ToString
        'Vrsta_Analitike_Sifra = DR1.Item("Vrsta_Analitike_Sifra").ToString
        'Nivo_Pocetnog_Stanja = DR1.Item("Nivo_Pocetnog_Stanja").ToString
        'Nivo_Zatvaranja = DR1.Item("Nivo_Zatvaranja").ToString

        'CM = New SqlCommand()
        'With CM
        '    .Connection = CN
        '    .CommandType = CommandType.StoredProcedure
        '    .CommandText = "fn_nalog_opisi_add"
        '    .Parameters.AddWithValue("@konto", Konto_Sifra)
        '    .Parameters.AddWithValue("@naziv", Naziv_L1)
        '    If Vrsta_Analitike_Sifra <> "" Then
        '        .Parameters.AddWithValue("@ima_analitiku", 0)
        '    Else
        '        .Parameters.AddWithValue("@ima_analitiku", 1)
        '    End If
        '    .ExecuteScalar()
        'End With
        'CM.Dispose()

        CM = New SqlCommand()
        With CM
            .Connection = CN
            .CommandType = CommandType.Text
            .CommandText = "SELECT dbo.fn_konto.* from dbo.fn_konto"
            DR1 = .ExecuteReader
        End With
        CM.Dispose()
        Dim i As Integer = 0
        Do While DR1.Read
            uabci(DR1.Item("Konto_Sifra"), i)
            i += 1

        Loop

        'End While
        DR1.Close()
        CM1.Dispose()
        'End If
        CN.Close()
        CN1.Close()
    End Sub

    Private Sub uabci(ByVal sifra, ByVal id)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        CM = New SqlCommand()
        With CM
            .Connection = CN
            .CommandType = CommandType.StoredProcedure
            .CommandText = "fn_konto_update_id"
            .Parameters.AddWithValue("@id_konto", id)
            .Parameters.AddWithValue("@Konto_Sifra", sifra)
            .ExecuteScalar()
        End With
        CM.Dispose()
        CN.Close()
    End Sub

#End Region

#Region "kartice"
    Private Sub btnKartice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKartice.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntFin_izvestaji
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnKartice.BackColor = Color.LightSteelBlue
        btnKartice.Enabled = False

        _labHead.Text = Ispisi_label() + My.Resources.text_fin_kartice

        podesi_visinu()
        _mTableButtons.RowStyles.Item(3).Height = 112
        panGlavni.Height = _visina - 8 + _mTableButtons.RowStyles.Item(3).Height + 26

        ID_vrsta_dokumenta = 0 ' vrsta_dokumenta.kalkulacija
    End Sub

    Private Sub linkKartice_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKartice_GKnjige.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 160

        Dim myControl As New cntKarticaGKnjige
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_nalog + My.Resources.text_search
        podesi_boje_linkova(panKartice_meni)
        linkKartice_GKnjige.BackColor = Color.GhostWhite
        linkKartice_GKnjige.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkAnallit_pregled_po_kontima_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkAnallit_pregled_po_kontima.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 200

        Dim myControl As New cntAnalitika_pregled_po_kontima
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_nalog + My.Resources.text_search
        podesi_boje_linkova(panKartice_meni)
        linkAnallit_pregled_po_kontima.BackColor = Color.GhostWhite
        linkAnallit_pregled_po_kontima.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkBruto_bilans_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkBruto_bilans.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 200

        Dim myControl As New cntBruto_bilans
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_nalog + My.Resources.text_search
        podesi_boje_linkova(panKartice_meni)
        linkBruto_bilans.BackColor = Color.GhostWhite
        linkBruto_bilans.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkPovezana_konta_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPovezana_konta.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = _mSpliter.Height - 5 ' 575

        Dim myControl As New cntPovezana_konta
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_otvorene_stavke '+ My.Resources.text_search
        podesi_boje_linkova(panKartice_meni)
        linkPovezana_konta.BackColor = Color.GhostWhite
        linkPovezana_konta.ForeColor = Color.MidnightBlue
    End Sub

#End Region

#Region "analitika"
    Private Sub btnAnlitikaPart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnlitikaPart.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntFin_izvestaji
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnAnlitikaPart.BackColor = Color.LightSteelBlue
        btnAnlitikaPart.Enabled = False

        _labHead.Text = Ispisi_label() + My.Resources.text_fin_analitika

        podesi_visinu()
        _mTableButtons.RowStyles.Item(5).Height = 112
        panGlavni.Height = _visina - 8 + _mTableButtons.RowStyles.Item(5).Height + 26

        ID_vrsta_dokumenta = 0 ' vrsta_dokumenta.kalkulacija
    End Sub

    Private Sub linkAnalitPart_search_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkAnalitPart_search.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 185

        _oj = False
        Dim myControl As New cntAnalitika_kumulativ
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_nalog + My.Resources.text_search
        podesi_boje_linkova(panAnalPart_meni)
        linkKartice_GKnjige.BackColor = Color.GhostWhite
        linkKartice_GKnjige.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkAnallitKatrica_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkAnallitKatrica_dob.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 185

        Dim myControl As New cntAnalitika_kartica_partneri
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_nalog + My.Resources.text_search
        podesi_boje_linkova(panAnalPart_meni)
        linkAnallitKatrica_dob.BackColor = Color.GhostWhite
        linkAnallitKatrica_dob.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkAnallitKatrica_kup_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkAnallitKatrica_kup.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 185

        Dim myControl As New cntAnalitika_kartica_kup
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_nalog + My.Resources.text_search
        podesi_boje_linkova(panAnalPart_meni)
        linkAnallitKatrica_kup.BackColor = Color.GhostWhite
        linkAnallitKatrica_kup.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkOtvorene_stavke_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkOtvorene_stavke.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = _mSpliter.Height - 5 ' 575

        Dim myControl As New cntOtvorene_stavke
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_otvorene_stavke '+ My.Resources.text_search
        podesi_boje_linkova(panAnalPart_meni)
        linkOtvorene_stavke.BackColor = Color.GhostWhite
        linkOtvorene_stavke.ForeColor = Color.MidnightBlue
    End Sub
#End Region

#Region "ostalo"
    Private Sub btnAnalitikaOstalo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnalitikaOstalo.Click
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntFin_izvestaji
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        podesi_boje()
        btnAnalitikaOstalo.BackColor = Color.LightSteelBlue
        btnAnalitikaOstalo.Enabled = False

        _labHead.Text = Ispisi_label() + My.Resources.text_nalog

        podesi_visinu()
        _mTableButtons.RowStyles.Item(7).Height = 112
        panGlavni.Height = _visina - 8 + _mTableButtons.RowStyles.Item(7).Height + 26

        ID_vrsta_dokumenta = 0 ' vrsta_dokumenta.kalkulacija
    End Sub

    Private Sub linkAnallitKatrica_oj_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkAnallitKatrica_oj.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 185

        _oj = True
        Dim myControl As New cntAnalitika_kumulativ
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_nalog + My.Resources.text_search
        podesi_boje_linkova(panAnalOstalo_meni)
        linkAnallitKatrica_oj.BackColor = Color.GhostWhite
        linkAnallitKatrica_oj.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub linkKartice_analitika_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkKartice_analitika.LinkClicked
        Dim tControl As Control
        For Each tControl In _mSpliter.Panel1.Controls
            tControl.Dispose()
        Next
        _mSpliter.SplitterDistance = 185

        Dim myControl As New cntKartice_po_analititici
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_nalog + My.Resources.text_search
        podesi_boje_linkova(panAnalOstalo_meni)
        linkKartice_analitika.BackColor = Color.GhostWhite
        linkKartice_analitika.ForeColor = Color.MidnightBlue
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
    End Sub

End Class
