Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class cntNalog_add

#Region "dekleracija"
    Private marza As Single = 0
    Private valuta As Integer = 0
    Private sifra As String = ""
    Private naziv As String = ""
    Private indeks As Integer = 0
    Private broj_decimala() As Integer

    Private _pocetak As Boolean = True
    Private _ima_promena As Boolean = True
    Private _snimljeno As Boolean = False
    Private _enter As Boolean = False
    Private _duguje As Boolean = False
    Private _potrazuje As Boolean = False
    Private _vrsta_analitike As String = ""
    Private _forma_zatvorena As Boolean = False
    Private _povezan_konto As Boolean = False
#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntNalog_add_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'If _ima_promena Then
        '    If MsgBox("Načinili ste promene. Dali želite da ih snimite?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '        snimi_head()
        '        snimi_stavku()
        '    End If
        'End If
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntNalog
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _mSpliter.SplitterDistance = 215

        Dim myControl1 As New cntNalog_search
        myControl1.Parent = _mSpliter.Panel1
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_nalog + My.Resources.text_search
        cntMeniFinansijsko.podesi_boje_linkova(_mPanNalog_meni)
        _mLinkNalog_search.BackColor = Color.GhostWhite
        _mLinkNalog_search.ForeColor = Color.MidnightBlue
        cntMeniFinansijsko.enable_linkove(_mPanNalog_meni)
        cntMeniFinansijsko.enable_buttons(_mTableButtons)
    End Sub

    Private Sub cntNalog_add_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tlbMain.Dock = DockStyle.Fill
        pocetak()
    End Sub

    Private Sub pocetak()
        novi()
        popuni_vrste_naloga()
        kontrole()
    End Sub

    Private Sub novi()

        'lvLista.Items.Clear()
        dgStavke.Rows.Clear()

        txtBroj.Text = Nadji_rb(Imena.tabele.fn_nalog_head.ToString, 2, cmbVrstNaloga.Text)
        txtNalogDuguje.Text = 0
        txtNalogPotrazuje.Text = 0
        txtNalogSaldo.Text = 0
        txtAnalitika.Text = ""
        txtAnalitika_opis.Text = ""
        txtBrDok.Text = ""
        txtDuguje.Text = "" ' 0
        txtKonto.Text = ""
        txtOpis.Text = ""
        txtOpisSifra.Text = ""
        txtPotrazuje.Text = "" ' 0
        txtDatumDok.Text = ""
        txtValuta.Text = ""

        'datValuta.Value = Today
        'datDatumNaloga.Value = Today

        _ima_promena = False
    End Sub

    Private Sub nova_stavka()
        txtAnalitika.Text = ""
        txtAnalitika_opis.Text = ""
        txtBrDok.Text = ""
        txtDuguje.Text = "" ' 0
        txtKonto.Text = ""
        txtKonto_opis.Text = ""
        txtOpis.Text = ""
        txtOpisSifra.Text = ""
        txtPotrazuje.Text = "" ' 0
        txtDatumDok.Text = ""
        txtValuta.Text = ""

        'datValuta.Value = Today
        'datDatumDok.Value = Today

        _duguje = False
        _potrazuje = False

        txtKonto.Select()
    End Sub

    Private Sub kontrole()
        Select Case _ima_promena
            Case True
                'tlbMain.Enabled = True
                btnSnimi.Enabled = True
            Case False
                'tlbMain.Enabled = False
                btnSnimi.Enabled = False
        End Select
    End Sub

    Private Sub popuni_vrste_naloga()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbVrstNaloga.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.fn_nalog_vrste order by vrsta_oznaka"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbVrstNaloga.Items.Add(DR.Item("vrsta_oznaka"))
            Loop
            DR.Close()
        End If
        If cmbVrstNaloga.Items.Count > 0 Then
            cmbVrstNaloga.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub unesi()
        With dgStavke
            Dim i As Integer = dgStavke.RowCount
            .Rows.Add(1)
            .Rows(i).Cells(0).Value = i + 1
            If txtKonto.Text <> "" Then .Rows(i).Cells(1).Value = txtKonto.Text
            If txtAnalitika.Text <> "" Then .Rows(i).Cells(2).Value = txtAnalitika.Text
            If txtOpisSifra.Text <> "" Then .Rows(i).Cells(3).Value = txtOpisSifra.Text
            If txtOpis.Text <> "" Then .Rows(i).Cells(4).Value = txtOpis.Text
            If txtDuguje.Text <> "" Then
                .Rows(i).Cells(5).Value = txtDuguje.Text
            Else
                .Rows(i).Cells(5).Value = 0
            End If
            If txtPotrazuje.Text <> "" Then
                .Rows(i).Cells(6).Value = txtPotrazuje.Text
            Else
                .Rows(i).Cells(6).Value = 0
            End If
            If txtBrDok.Text <> "" Then .Rows(i).Cells(7).Value = txtBrDok.Text
            .Rows(i).Cells(8).Value = txtDatumDok.Text
            .Rows(i).Cells(9).Value = txtValuta.Text
            .Rows(i).Cells(10).Value = 0
        End With

        Dim dug As Single = 0
        Dim pot As Single = 0
        With dgStavke
            Dim i As Integer = 0
            For i = 0 To .Rows.Count - 1
                dug += CSng(.Rows(i).Cells(5).Value)
                pot += CSng(.Rows(i).Cells(6).Value)
            Next
        End With
        txtNalogDuguje.Text = Format(CSng(dug), "##,##0.00")
        txtNalogPotrazuje.Text = Format(CSng(pot), "##,##0.00")
        txtNalogSaldo.Text = CSng(txtNalogDuguje.Text) - CSng(txtNalogPotrazuje.Text)
        txtNalogSaldo.Text = Format(CSng(txtNalogSaldo.Text), "##,##0.00")

        labBrStavki.Text = "Stavka broj: " & dgStavke.Rows.Count
    End Sub

    Private Sub btnSnimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSnimi.Click
        If CSng(txtNalogSaldo.Text) = 0 Then
            GoTo snimi
        Else
            If MsgBox("Nalog nije uravnotežen. Dali ste sigurni da želite da ga snimite?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                GoTo snimi
            End If
        End If
        Exit Sub
snimi:
        _snimljeno = False
        Try
            snimi_head()
            snimi_stavku()
            'selektuj_nalog(_id_nalog, Selekcija.po_id)
            novi()
            _snimljeno = True
        Catch ex As Exception
            MsgBox("Došlo je do greške. Zahtevana procedura nije izvršena.") 'ex.Message)
        End Try
    End Sub

    Private Sub snimi_head()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "fn_nalog_head_add"
                .Parameters.AddWithValue("@nal_vrsta", cmbVrstNaloga.Text)
                .Parameters.AddWithValue("@nal_broj", txtBroj.Text)
                .Parameters.AddWithValue("@nal_datum", datDatumNaloga.Value.Date)
                If txtNalogDuguje.Text <> "" Then
                    .Parameters.AddWithValue("@nal_duguje", CSng(txtNalogDuguje.Text))
                Else
                    .Parameters.AddWithValue("@nal_duguje", 0)
                End If
                If txtNalogPotrazuje.Text <> "" Then
                    .Parameters.AddWithValue("@nal_potrazuje", CSng(txtNalogPotrazuje.Text))
                Else
                    .Parameters.AddWithValue("@nal_potrazuje", 0)
                End If
                .Parameters.AddWithValue("@nal_proknjizen", 0)
                .Parameters.AddWithValue("@nal_storniran", 0)
                .Parameters.AddWithValue("@nal_napomena", "Neproknjižen nalog")
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If
        CN.Close()
    End Sub

    Private Sub snimi_stavku()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim i As Integer

        _id_nalog = Nadji_id(Imena.tabele.fn_nalog_head.ToString)

        CN.Open()
        For i = 0 To dgStavke.Rows.Count - 1
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "fn_nalog_stavka_add"
                    .Parameters.AddWithValue("@id_nalog", _id_nalog)
                    .Parameters.AddWithValue("@stavka_rb", dgStavke.Rows(i).Cells(0).Value)
                    .Parameters.AddWithValue("@stavka_konto", dgStavke.Rows(i).Cells(1).Value)
                    If Not IsDBNull(dgStavke.Rows(i).Cells(2).Value) And dgStavke.Rows(i).Cells(2).Value <> "" Then
                        .Parameters.AddWithValue("@stavka_analitika", dgStavke.Rows(i).Cells(2).Value)
                    Else
                        .Parameters.AddWithValue("@stavka_analitika", "")
                    End If
                    If Not IsDBNull(dgStavke.Rows(i).Cells(3).Value) And dgStavke.Rows(i).Cells(3).Value <> "" Then
                        .Parameters.AddWithValue("@stavka_opis_sifra", dgStavke.Rows(i).Cells(3).Value)
                    Else
                        .Parameters.AddWithValue("@stavka_opis_sifra", "")
                    End If
                    If Not IsDBNull(dgStavke.Rows(i).Cells(4).Value) And dgStavke.Rows(i).Cells(4).Value <> "" Then
                        .Parameters.AddWithValue("@stavka_opis", dgStavke.Rows(i).Cells(4).Value)
                    Else
                        .Parameters.AddWithValue("@stavka_opis", "")
                    End If
                    .Parameters.AddWithValue("@stavka_duguje", CSng(dgStavke.Rows(i).Cells(5).Value))
                    .Parameters.AddWithValue("@stavka_potrazuje", CSng(dgStavke.Rows(i).Cells(6).Value))
                    If Not IsDBNull(dgStavke.Rows(i).Cells(7).Value) And dgStavke.Rows(i).Cells(7).Value <> "" Then
                        .Parameters.AddWithValue("@stavka_brDok", dgStavke.Rows(i).Cells(7).Value)
                    Else
                        .Parameters.AddWithValue("@stavka_brDok", "")
                    End If
                    .Parameters.AddWithValue("@stavka_datDok", dgStavke.Rows(i).Cells(8).Value)
                    .Parameters.AddWithValue("@stavka_valuta", dgStavke.Rows(i).Cells(9).Value)
                    '.Parameters.AddWithValue("@stavka_zatvorena", dgStavke.Rows(i).Cells(10).Value)
                    .Parameters.AddWithValue("@stavka_zatvorena", 0)
                    .Parameters.AddWithValue("@stavka_konto_povezan", 0)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
        Next
        CN.Close()
    End Sub

    Private Sub btnNovi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovi.Click
        novi()
    End Sub

    Private Sub btnUnesi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnesi.Click
        unesi()
        nova_stavka()
    End Sub

    Private Sub cmbVrstNaloga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbVrstNaloga.KeyPress
        If e.KeyChar = Chr(13) Then
            txtBroj.Text = Nadji_rb(Imena.tabele.fn_nalog_head.ToString, 2, cmbVrstNaloga.Text) ' Nadji_rb_naloga(cmbVrstNaloga.Text)
            datDatumNaloga.Select()
        End If
    End Sub
    Private Sub cmbVrstNaloga_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbVrstNaloga.SelectedValueChanged
        txtBroj.Text = Nadji_rb(Imena.tabele.fn_nalog_head.ToString, 2, RTrim(cmbVrstNaloga.Text)) ' Nadji_rb_naloga(cmbVrstNaloga.Text)
        datDatumNaloga.Select()
    End Sub

    Private Sub datDatumNaloga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datDatumNaloga.KeyPress
        txtKonto.Select()
    End Sub

    Private Sub txtKonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKonto.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtKonto.Text <> "" Then
                If Len(txtKonto.Text) < 5 Then
                    MsgBox("Uneli manje od 5 cifara. Unesite ispravan račun.", MsgBoxStyle.OkOnly)
                Else
                    _enter = True
                    ispitaj_konto()
                End If
            End If
        End If
    End Sub
    Private Sub txtKonto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKonto.TextChanged
        If txtKonto.Text <> "" Then
            If Not jeste_broj(txtKonto.Text) Then
                txtKonto.BackColor = Color.LightPink
            Else
                txtKonto.BackColor = Color.GhostWhite
            End If
        End If
        ispitaj_kontrolu()
    End Sub
    Private Sub ispitaj_konto()
        If jesu_cifre(txtKonto.Text) Then
            txtKonto.BackColor = Color.GhostWhite
            If Len(txtKonto.Text) >= 5 Then
                Dim CN As SqlConnection = New SqlConnection(CNNString)
                Dim CM As New SqlCommand
                Dim DR As SqlDataReader

                CN.Open()
                If CN.State = ConnectionState.Open Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.Text
                        .CommandText = "select * from dbo.app_konto where dbo.app_konto.Konto_Sifra Like N'" & txtKonto.Text & "%'"
                        DR = .ExecuteReader()
                    End With

                    Dim i As Integer = 0
                    Do While DR.Read
                        i += 1
                    Loop
                    DR.Close()

                    Select Case i
                        Case 0
                            MsgBox("Račun koji ste uneli ne postoji u kontnom okviru. Istpravite grešku.", MsgBoxStyle.OkOnly)
                        Case 1
                            DR = CM.ExecuteReader()
                            DR.Read()
                            'If _enter Then
                            If DR.Item("Dozvoljeno_Knjizenje") Then
                                txtKonto.Text = RTrim(DR.Item("Konto_Sifra"))
                                txtKonto_opis.Text = DR.Item("Naziv")
                                If DR.Item("ima_analitiku") Then
                                    MsgBox("Na ovom računu je obavezna analitika!", MsgBoxStyle.OkOnly)
                                    _vrsta_analitike = DR.Item("Vrsta_Analitike_Sifra")
                                    txtAnalitika.Select()
                                Else
                                    txtOpisSifra.Select()
                                End If
                            Else
                                MsgBox("Na ovom računu nije dozvoljeno knjiženje!", MsgBoxStyle.OkOnly)
                                txtKonto.BackColor = Color.LightPink
                                txtKonto.Focus()
                                'txtKonto.Select()
                            End If
                            'End If
                        Case Is > 1
                            'If MsgBox("Pronadjeno je više od jednog računa sa ovim cifrana! Za nastavak sa ovim računom pritisnite 'OK'?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                            CM = New SqlCommand()
                            With CM
                                .Connection = CN
                                .CommandType = CommandType.Text
                                .CommandText = "select * from dbo.app_konto where dbo.app_konto.Konto_Sifra = '" & txtKonto.Text & "'"
                                DR = .ExecuteReader()
                            End With
                            Do While DR.Read
                                If DR.Item("Dozvoljeno_Knjizenje") Then
                                    txtKonto_opis.Text = DR.Item("Naziv")
                                    txtAnalitika.Select()
                                Else
                                    MsgBox("Na ovom računu nije dozvoljeno knjiženje!", MsgBoxStyle.OkOnly)
                                    txtKonto.BackColor = Color.LightPink
                                    txtKonto.Focus()
                                End If
                                If DR.Item("ima_analitiku") Then
                                    MsgBox("Na ovom računu je obavezna analitika!", MsgBoxStyle.OkOnly)
                                    _vrsta_analitike = DR.Item("Vrsta_Analitike_Sifra")
                                    txtAnalitika.Select()
                                Else
                                    txtOpisSifra.Select()
                                End If
                            Loop
                            DR.Close()
                            'End If
                    End Select
                    DR.Close()
                    CM.Dispose()
                    CN.Close()
                Else
                    txtAnalitika.Select()
                End If
            End If
        Else
            txtKonto.BackColor = Color.LightPink
        End If
        '_enter = False
    End Sub

    Private Sub txtAnalitika_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnalitika.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtAnalitika.Text <> "" Then
                If Len(txtKonto.Text) < 4 Then
                    MsgBox("Uneli manje od 4 cifara. Unesite ispravan račun.", MsgBoxStyle.OkOnly)
                Else
                    nadji_analitiku()
                End If
            End If
        End If
    End Sub
    Private Sub txtAnalitika_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAnalitika.TextChanged
        If txtAnalitika.Text <> "" Then
            If Not jeste_broj(txtAnalitika.Text) Then
                txtAnalitika.BackColor = Color.LightPink
            Else
                txtAnalitika.BackColor = Color.GhostWhite
            End If
        End If
        ispitaj_kontrolu()
    End Sub
    Private Sub nadji_analitiku()
        If jeste_broj(txtAnalitika.Text) Then
            txtAnalitika.BackColor = Color.GhostWhite
            Dim sql As String = ""
            Select Case _vrsta_analitike
                Case "001" 'partneri
                    'sql = "select * from app_partneri where partner_dobavljac = 1 or partner_kupac = 1 and partner_sifra = '"
                    sql = "select * from app_partneri where partner_sifra = '"
                Case "004" 'organizaciona jedinica
                    sql = "select * from app_organizacione_jedinice where app_organizacione_jedinice.oj_sifra = '"

            End Select

            'If Len(txtAnalitika.Text) >= 4 And sql <> "" Then
            Dim CN As SqlConnection = New SqlConnection(CNNString)
            Dim CM As New SqlCommand
            Dim DR As SqlDataReader

            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = sql & txtAnalitika.Text & "'"
                    DR = .ExecuteReader()
                End With

                If DR.HasRows Then
                    Do While DR.Read
                        txtAnalitika_opis.Text = DR.Item(2) '("partner_naziv")
                        txtOpisSifra.Select()
                    Loop
                Else
                    MsgBox("Šifra koju ste uneli ne postoji u šifrarniku. Istpravite grešku.", MsgBoxStyle.OkOnly)
                End If
                DR.Close()
                CM.Dispose()
                CN.Close()
                'Else
                '    MsgBox("Šifra koju ste uneli je kraća od 3 cifre. Istpravite grešku.", MsgBoxStyle.OkOnly)
                'End If
            End If
        Else
            txtAnalitika.BackColor = Color.LightPink
        End If
    End Sub

    Private Sub txtOpisSifra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOpisSifra.KeyPress
        If e.KeyChar = Chr(13) Then
            nadji_opis()
        End If
    End Sub
    Private Sub txtOpisSifra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOpisSifra.TextChanged
        If txtOpisSifra.Text <> "" Then
            If Not jeste_broj(txtOpisSifra.Text) Then
                txtOpisSifra.BackColor = Color.LightPink
            Else
                txtOpisSifra.BackColor = Color.GhostWhite
            End If
        End If
        ispitaj_kontrolu()
    End Sub
    Private Sub nadji_opis()
        If jeste_broj(txtOpisSifra.Text) Then
            txtOpisSifra.BackColor = Color.GhostWhite
            If Len(txtOpisSifra.Text) = 3 Then
                Dim CN As SqlConnection = New SqlConnection(CNNString)
                Dim CM As New SqlCommand
                Dim DR As SqlDataReader

                CN.Open()
                If CN.State = ConnectionState.Open Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.Text
                        .CommandText = "select * from dbo.fn_nalog_opisi where dbo.fn_nalog_opisi.opis_sifra Like N'" & txtOpisSifra.Text & "%'"
                        DR = .ExecuteReader()
                    End With

                    If DR.HasRows Then
                        Do While DR.Read
                            txtOpis.Text = DR.Item("opis_text")
                            txtOpis.Focus()
                            txtOpis.SelectionLength = 0
                            txtOpis.SelectionStart = txtOpis.TextLength + 1
                            'txtDuguje.Select()
                        Loop
                    Else
                        MsgBox("Šifra koju ste uneli ne postoji u šifrarniku. Istpravite grešku.", MsgBoxStyle.OkOnly)
                    End If
                    DR.Close()
                    CM.Dispose()
                    CN.Close()
                Else
                    MsgBox("Šifra koju ste uneli je kraća od 3 cifre. Istpravite grešku.", MsgBoxStyle.OkOnly)
                End If
            End If
        End If
    End Sub

    Private Sub txtOpis_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOpis.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDuguje.Select()
        End If
    End Sub
    Private Sub txtOpis_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOpis.TextChanged
        ispitaj_kontrolu()
    End Sub

    Private Sub txtDuguje_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDuguje.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtDuguje.Text <> "" And Not txtDuguje.Text = "0,00" Then
                If jeste_broj(txtDuguje.Text) Then
                    If Not _potrazuje Then
                        _duguje = True
                        txtPotrazuje.Text = "0,00"
                        txtBrDok.Select()
                    Else
                        If MsgBox("Uneli ste i dugovnu i potražnu vrednost. Morate uneti samo jedan iznos.", MsgBoxStyle.OkOnly) = MsgBoxResult.Ok Then
                            txtPotrazuje.Text = "0,00"
                            txtDuguje.Text = "0,00"
                            _duguje = False
                            _potrazuje = False
                            txtDuguje.Select()
                        End If
                    End If
                Else
                    _duguje = False
                    txtDuguje.Select()
                End If
            Else
                _duguje = False
                txtPotrazuje.Select()
            End If
            If txtDuguje.Text <> "" And Not txtDuguje.Text = "0,00" Then
                txtDuguje.Text = Format(CSng(txtDuguje.Text), "##,##0.00")
            Else
                txtDuguje.Text = Format(0, "##,##0.00")
            End If
        End If
    End Sub
    Private Sub txtDuguje_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDuguje.TextChanged
        ispitaj_kontrolu()
    End Sub

    Private Sub txtPotrazuje_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPotrazuje.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtPotrazuje.Text <> "" And Not txtPotrazuje.Text = "0,00" Then
                If jeste_broj(txtPotrazuje.Text) Then
                    If Not _potrazuje Then
                        _potrazuje = True
                        txtDuguje.Text = "0,00"
                        txtBrDok.Select()
                    Else
                        If MsgBox("Uneli ste i dugovnu i potražnu vrednost. Morate uneti samo jedan iznos.", MsgBoxStyle.OkOnly) = MsgBoxResult.Ok Then
                            txtPotrazuje.Text = "0,00"
                            txtDuguje.Text = "0,00"
                            _duguje = False
                            _potrazuje = False
                            txtDuguje.Select()
                        End If
                    End If
                Else
                    _potrazuje = False
                    txtPotrazuje.Select()
                End If
            Else
                _potrazuje = False
                txtDuguje.Select()
            End If
            If txtPotrazuje.Text <> "" And Not txtPotrazuje.Text = "0,00" Then
                txtPotrazuje.Text = Format(CSng(txtPotrazuje.Text), "##,##0.00")
            Else
                txtPotrazuje.Text = Format(0, "##,##0.00")
            End If
        End If
    End Sub
    Private Sub txtPotrazuje_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPotrazuje.TextChanged
        ispitaj_kontrolu()
    End Sub

    Private Sub txtBrDok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBrDok.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDatumDok.Select()
        End If
    End Sub
    Private Sub txtBrDok_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBrDok.TextChanged
        ispitaj_kontrolu()
    End Sub

    Private Sub txtDatumDok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDatumDok.KeyPress
        If e.KeyChar = Chr(13) Then
            txtValuta.Select()
            txtDatumDok.Text = Format(txtDatumDok.Text, "")
        End If
    End Sub
    Private Sub txtDatumDok_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDatumDok.TextChanged
        ispitaj_kontrolu()
    End Sub

    Private Sub txtValuta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValuta.KeyPress
        If e.KeyChar = Chr(13) Then
            btnUnesi.Select()
        End If
    End Sub
    Private Sub txtValuta_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValuta.TextChanged
        ispitaj_kontrolu()
    End Sub

    Private Sub datDatumDok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datDatumDok.KeyPress
        If e.KeyChar = Chr(13) Then
            datValuta.Select()
        End If
    End Sub

    Private Sub datValuta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datValuta.KeyPress
        If e.KeyChar = Chr(13) Then
            btnUnesi.Select()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Select Case panel.Visible
            Case True
                panel.Visible = False
                tlbMain.RowStyles.Item(5).Height = 1
                PictureBox1.BackgroundImage = My.Resources._3_Down
            Case False
                panel.Visible = True
                tlbMain.RowStyles.Item(5).Height = 175
                PictureBox1.BackgroundImage = My.Resources._3_Up
        End Select
    End Sub

    Private Sub ispitaj_kontrolu()
        If dgStavke.Rows.Count = 0 Then
            _ima_promena = False
            btnSnimi.Enabled = False
            Dim mTekst As Control ' TextBox
            For Each mTekst In panStavka.Controls
                If mTekst.Name Like "txt*" Then
                    If mTekst.Text <> "" Then
                        _ima_promena = True
                        _snimljeno = False
                        btnSnimi.Enabled = True
                        Exit For
                    End If
                End If
            Next
        Else
            _ima_promena = True
            _snimljeno = False
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

#Region "grid"
    Private _row_index As Integer = 0
    Private Sub dgStavke_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgStavke.RowHeaderMouseDoubleClick
        nova_stavka()
        If tlbMain.RowStyles.Item(5).Height = 1 Then tlbMain.RowStyles.Item(5).Height = 175
        If panel.Visible = False Then panel.Visible = True
        PictureBox1.BackgroundImage = My.Resources._3_Up
        With dgStavke
            _row_index = e.RowIndex
            txtKonto.Text = .Rows(e.RowIndex).Cells(1).Value
            ispitaj_konto()
            If Not IsDBNull(.Rows(e.RowIndex).Cells(2).Value) And .Rows(e.RowIndex).Cells(2).Value <> "" Then
                txtAnalitika.Text = .Rows(e.RowIndex).Cells(2).Value
                nadji_analitiku()
            Else
                txtAnalitika.Text = ""
            End If

            txtOpisSifra.Text = .Rows(e.RowIndex).Cells(3).Value
            txtOpis.Text = .Rows(e.RowIndex).Cells(4).Value
            txtDuguje.Text = .Rows(e.RowIndex).Cells(5).Value
            txtPotrazuje.Text = .Rows(e.RowIndex).Cells(6).Value
            txtBrDok.Text = .Rows(e.RowIndex).Cells(7).Value
            txtDatumDok.Text = .Rows(e.RowIndex).Cells(8).Value
            txtValuta.Text = .Rows(e.RowIndex).Cells(9).Value
            _povezan_konto = .Rows(e.RowIndex).Cells(11).Value

        End With
        btnUnesi.Visible = False
        btnNastavi.Visible = True
        btnIzmeni.Visible = True
    End Sub

    Private Sub dgStavke_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgStavke.RowsAdded
        dgStavke.Rows(e.RowIndex).Selected = True
        dgStavke.FirstDisplayedScrollingRowIndex = e.RowIndex
    End Sub

    Private Sub dgStavke_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgStavke.RowsRemoved
        With dgStavke
            Dim dug As Single = 0
            Dim pot As Single = 0
            With dgStavke
                Dim i As Integer = 0
                For i = 0 To .Rows.Count - 1
                    .Rows(i).Cells(0).Value = i + 1
                    dug += CSng(.Rows(i).Cells(5).Value)
                    pot += CSng(.Rows(i).Cells(6).Value)
                Next
            End With
            txtNalogDuguje.Text = Format(dug, "##,##0.00")
            txtNalogPotrazuje.Text = Format(pot, "##,##0.00")
            txtNalogSaldo.Text = dug - pot
            txtNalogSaldo.Text = Format(CSng(txtNalogSaldo.Text), "##,##0.00")
        End With
    End Sub
#End Region

    Private Sub btnIzmeni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzmeni.Click
        With dgStavke
            If txtKonto.Text <> "" Then .Rows(_row_index).Cells(1).Value = txtKonto.Text
            If txtAnalitika.Text <> "" Then .Rows(_row_index).Cells(2).Value = txtAnalitika.Text
            If txtOpisSifra.Text <> "" Then .Rows(_row_index).Cells(3).Value = txtOpisSifra.Text
            If txtOpis.Text <> "" Then .Rows(_row_index).Cells(4).Value = txtOpis.Text
            If txtDuguje.Text <> "" Then
                .Rows(_row_index).Cells(5).Value = txtDuguje.Text
            Else
                .Rows(_row_index).Cells(5).Value = 0
            End If
            If txtPotrazuje.Text <> "" Then
                .Rows(_row_index).Cells(6).Value = txtPotrazuje.Text
            Else
                .Rows(_row_index).Cells(6).Value = 0
            End If
            If txtBrDok.Text <> "" Then .Rows(_row_index).Cells(7).Value = txtBrDok.Text
            .Rows(_row_index).Cells(8).Value = txtDatumDok.Text
            .Rows(_row_index).Cells(9).Value = txtValuta.Text
            .Rows(_row_index).Cells(11).Value = _povezan_konto
        End With

        Dim dug As Single = 0
        Dim pot As Single = 0

        With dgStavke
            Dim i As Integer = 0
            For i = 0 To .Rows.Count - 1
                dug += CSng(.Rows(i).Cells(5).Value)
                pot += CSng(.Rows(i).Cells(6).Value)
            Next
        End With
        txtNalogDuguje.Text = Format(dug, "##,##0.00")
        txtNalogPotrazuje.Text = Format(pot, "##,##0.00")
        txtNalogSaldo.Text = dug - pot
        txtNalogSaldo.Text = Format(CSng(txtNalogSaldo.Text), "##,##0.00")
    End Sub

    Private Sub btnNastavi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNastavi.Click
        nova_stavka()
        btnUnesi.Visible = True
        btnNastavi.Visible = False
        btnIzmeni.Visible = False
    End Sub

    Private Sub btnProknjizi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProknjizi.Click
        If _snimljeno And Not _ima_promena Then
            proknjizi()
        Else
            MsgBox("Načinili ste prmene a koje nisu snimljene. Prvo proverite i snimite nalog.")
        End If

    End Sub

    Private Sub proknjizi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "fn_nalog_proknjizi"
                .Parameters.AddWithValue("@id_nalog", _id_nalog)
                .Parameters.AddWithValue("@nal_proknjizen", 1)
                .Parameters.AddWithValue("@nal_proknjizen_datum", Today)
                .Parameters.AddWithValue("@nal_napomena", "Proknjižen nalog")
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If
        CN.Close()

        selektuj_nalog(_id_nalog, Selekcija.po_id)
        novi()
        If _nal_proknjizen And _nal_storniran Then
            labStatusNaloga.Text = "Nalog JE proknjižen i storniran. Izmene nisu moguće."
            zatvori_formu()
        Else
            If _nal_proknjizen = False And _nal_storniran Then
                labStatusNaloga.Text = "Nalog JE storniran. Izmene nisu moguće."
                zatvori_formu()
            Else
                If _nal_proknjizen And _nal_storniran = False Then
                    labStatusNaloga.Text = "Nalog JE proknjižen. Izmene nisu moguće."
                    zatvori_formu()
                Else
                    labStatusNaloga.Text = "Nalog NIJE proknjižen. Možete izvršiti izmene."
                End If
            End If
        End If
    End Sub

    Private Sub zatvori_formu()
        panStavka.Enabled = False
        btnSnimi.Enabled = False
        btnProknjizi.Enabled = False
        cmbVrstNaloga.Enabled = False
        datDatumNaloga.Enabled = False
        _forma_zatvorena = True
    End Sub

    Private Sub btnIzbrisi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzbrisi.Click
        dgStavke.Rows.RemoveAt(_row_index)
        nova_stavka()
    End Sub

End Class
