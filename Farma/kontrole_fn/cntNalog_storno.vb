Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class cntNalog_storno

#Region "dekleracija"
    Private marza As Single = 0
    Private valuta As Integer = 0
    Private sifra As String = ""
    Private naziv As String = ""
    Private indeks As Integer = 0
    Private broj_decimala() As Integer

    Private _pocetak As Boolean = True
    Private _ima_promena As Boolean = True
    Private _enter As Boolean = False
    Private _duguje As Boolean = False
    Private _potrazuje As Boolean = False
    Private _vrsta_analitike As String = ""
    Private _storno_broj As Integer = 0
    Private _povezan_konto As Boolean = False
#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntNalog_storno_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
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

    Private Sub cntNalog_storno_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tlbMain.Dock = DockStyle.Fill
        pocetak()
        dgStavke.Visible = True
    End Sub

    Private Sub pocetak()

        originalni_nalog()
        popuni_vrste_naloga()
        'kontrole()
        panStavka.Enabled = False
    End Sub

    Private Sub originalni_nalog()

        'lvLista.Items.Clear()
        dgStavke.Rows.Clear()

        txtBroj.Text = _nal_broj
        txtNalogDuguje.Text = Format(_nal_duguje, "##,##0.00")
        txtNalogPotrazuje.Text = Format(_nal_potrazuje, "##,##0.00")
        txtNalogSaldo.Text = Format(_nal_duguje - _nal_potrazuje, "##,##0.00")
        txtAnalitika.Text = ""
        txtAnalitika_opis.Text = ""
        txtBrDok.Text = ""
        txtDuguje.Text = "" ' 0
        txtKonto.Text = ""
        txtOpis.Text = ""
        txtOpisSifra.Text = ""
        txtPotrazuje.Text = "" ' 0
        datDatumNaloga.Value = _nal_datum

        dgStavke.Visible = True
        tlbMain.SetRow(dgStavke, 10)
        tlbMain.SetColumn(dgStavke, 1)

        btnStorno.Visible = True
        btnNazad.Visible = False
        btnSnimi.Visible = False
        btnCancel.Visible = True

        'tlbMain.SetRow(btnNazad, 12)
        'tlbMain.SetColumn(btnNazad, 1)
        'tlbMain.SetRow(btnSnimi, 12)
        'tlbMain.SetColumn(btnSnimi, 12)
        tlbMain.SetRow(btnStorno, 12)
        tlbMain.SetColumn(btnStorno, 14)
        'tlbMain.SetRow(btnCancel, 13)
        'tlbMain.SetColumn(btnCancel, 14)

        popuni_stavke()

        cmbVrstNaloga.Text = RTrim(_nal_vrsta)

        labStatusNaloga.Text = "Storniranje je u toku"
    End Sub

    Private Sub storno_nalog()

        'cmbVrstNaloga.FindString("ST")
        cmbVrstNaloga.Text = "ST"

        txtBroj.Text = _storno_broj
        txtNalogDuguje.Text = Format(-1 * _nal_duguje, "##,##0.00")
        txtNalogPotrazuje.Text = Format(-1 * _nal_potrazuje, "##,##0.00")
        txtNalogSaldo.Text = Format(-1 * (_nal_duguje - _nal_potrazuje), "##,##0.00")
        txtAnalitika.Text = ""
        txtAnalitika_opis.Text = ""
        txtBrDok.Text = ""
        txtDuguje.Text = "" ' 0
        txtKonto.Text = ""
        txtOpis.Text = ""
        txtOpisSifra.Text = ""
        txtPotrazuje.Text = "" ' 0
        datDatumNaloga.Value = Today
       
        dgStavke.Visible = False
        'tlbMain.SetRow(dgStavke, 12)
        'tlbMain.SetColumn(dgStavke, 1)

        dgStorno.Visible = True
        dgStorno.Dock = DockStyle.Fill
        tlbMain.SetColumnSpan(dgStorno, 15)
        tlbMain.SetRow(dgStorno, 10)
        tlbMain.SetColumn(dgStorno, 1)

        btnStorno.Visible = False
        btnSnimi.Visible = True
        btnNazad.Visible = True
        btnCancel.Visible = True

        tlbMain.SetRow(btnSnimi, 12)
        tlbMain.SetColumn(btnSnimi, 14)

        dgStorno.Rows.Clear()
        Dim a = dgStorno.Rows.Count

        With dgStorno
            Dim i As Integer = 0
            For i = 0 To dgStavke.RowCount - 1
                .Rows.Add(1)
                .Rows(i).Cells(0).Value = dgStavke.Rows(i).Cells(0).Value
                .Rows(i).Cells(1).Value = dgStavke.Rows(i).Cells(1).Value
                .Rows(i).Cells(2).Value = dgStavke.Rows(i).Cells(2).Value
                .Rows(i).Cells(3).Value = dgStavke.Rows(i).Cells(3).Value
                .Rows(i).Cells(4).Value = dgStavke.Rows(i).Cells(4).Value
                .Rows(i).Cells(5).Value = -1 * dgStavke.Rows(i).Cells(5).Value
                .Rows(i).Cells(6).Value = -1 * dgStavke.Rows(i).Cells(6).Value
                .Rows(i).Cells(7).Value = dgStavke.Rows(i).Cells(7).Value
                .Rows(i).Cells(8).Value = dgStavke.Rows(i).Cells(8).Value
                .Rows(i).Cells(9).Value = dgStavke.Rows(i).Cells(9).Value
            Next i
        End With
    End Sub

    Private Sub popuni_stavke()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.fn_nalog_stavka.* from dbo.fn_nalog_stavka where dbo.fn_nalog_stavka.id_nalog = " & _id_nalog
                DR = .ExecuteReader
            End With

            _broj_stavki = 0
            Do While DR.Read
                _broj_stavki += 1
            Loop
            DR.Close()

            _id_nalog_stavka = New Integer() {}
            ReDim _id_nalog_stavka(_broj_stavki - 1)

            With dgStavke
                Dim i As Integer = 0
                DR = CM.ExecuteReader
                Do While DR.Read
                    .Rows.Add(1)
                    If Not IsDBNull(DR.Item("id_stavka")) Then _id_nalog_stavka.SetValue(DR.Item("id_stavka"), i)

                    If Not IsDBNull(DR.Item("stavka_rb")) Then .Rows(i).Cells(0).Value = DR.Item("stavka_rb")
                    If Not IsDBNull(DR.Item("stavka_konto")) Then .Rows(i).Cells(1).Value = DR.Item("stavka_konto")
                    If Not IsDBNull(DR.Item("stavka_analitika")) Then .Rows(i).Cells(2).Value = DR.Item("stavka_analitika")
                    If Not IsDBNull(DR.Item("stavka_opis_sifra")) Then .Rows(i).Cells(3).Value = DR.Item("stavka_opis_sifra")
                    If Not IsDBNull(DR.Item("stavka_opis")) Then .Rows(i).Cells(4).Value = DR.Item("stavka_opis")
                    If Not IsDBNull(DR.Item("stavka_duguje")) Then .Rows(i).Cells(5).Value = DR.Item("stavka_duguje")
                    If Not IsDBNull(DR.Item("stavka_potrazuje")) Then .Rows(i).Cells(6).Value = DR.Item("stavka_potrazuje")
                    If Not IsDBNull(DR.Item("stavka_brDok")) Then .Rows(i).Cells(7).Value = DR.Item("stavka_brDok")
                    If Not IsDBNull(DR.Item("stavka_datDok")) Then .Rows(i).Cells(8).Value = DR.Item("stavka_datDok")
                    If Not IsDBNull(DR.Item("stavka_valuta")) Then .Rows(i).Cells(9).Value = DR.Item("stavka_valuta")
                    i += 1
                Loop
                DR.Close()
            End With
        End If

        CM.Dispose()
        CN.Close()

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

        _duguje = False
        _potrazuje = False

        txtKonto.Select()
    End Sub

    Private Sub kontrole()
        Select Case _ima_promena
            Case True
                'tlbMain.Enabled = True
                btnStorno.Enabled = True
            Case False
                'tlbMain.Enabled = False
                btnStorno.Enabled = False
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
        'If cmbVrstNaloga.Items.Count > 0 Then
        '    cmbVrstNaloga.SelectedText = RTrim(_nal_vrsta)
        'End If
        CM.Dispose()
        CN.Close()
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
                .Parameters.AddWithValue("@nal_broj", _storno_broj)
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
                .Parameters.AddWithValue("@nal_proknjizen", _nal_proknjizen)
                .Parameters.AddWithValue("@nal_storniran", _nal_storniran)
                .Parameters.AddWithValue("@nal_napomena", "STORNO NALOG " & _nal_vrsta & "-" & _nal_broj)
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

        _id_nalog_storno = Nadji_id(Imena.tabele.fn_nalog_head.ToString)

        CN.Open()
        If CN.State = ConnectionState.Open Then
            For i = 0 To dgStorno.Rows.Count - 2
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "fn_nalog_stavka_add"
                    .Parameters.AddWithValue("@id_nalog", _id_nalog_storno)
                    .Parameters.AddWithValue("@stavka_rb", RTrim(dgStorno.Rows(i).Cells(0).Value))
                    .Parameters.AddWithValue("@stavka_konto", dgStorno.Rows(i).Cells(1).Value)
                    If Not IsDBNull(dgStorno.Rows(i).Cells(2).Value) And dgStorno.Rows(i).Cells(2).Value <> "" Then
                        .Parameters.AddWithValue("@stavka_analitika", dgStorno.Rows(i).Cells(2).Value)
                    Else
                        .Parameters.AddWithValue("@stavka_analitika", "")
                    End If
                    If Not IsDBNull(dgStavke.Rows(i).Cells(3).Value) And RTrim(dgStorno.Rows(i).Cells(3).Value) <> "" Then
                        .Parameters.AddWithValue("@stavka_opis_sifra", dgStorno.Rows(i).Cells(3).Value)
                    Else
                        .Parameters.AddWithValue("@stavka_opis_sifra", "")
                    End If
                    If Not IsDBNull(dgStorno.Rows(i).Cells(4).Value) And RTrim(dgStorno.Rows(i).Cells(4).Value) <> "" Then
                        .Parameters.AddWithValue("@stavka_opis", dgStorno.Rows(i).Cells(4).Value)
                    Else
                        .Parameters.AddWithValue("@stavka_opis", "")
                    End If
                    .Parameters.AddWithValue("@stavka_duguje", CSng(dgStorno.Rows(i).Cells(5).Value))
                    .Parameters.AddWithValue("@stavka_potrazuje", CSng(dgStorno.Rows(i).Cells(6).Value))
                    If Not IsDBNull(dgStorno.Rows(i).Cells(7).Value) And RTrim(dgStorno.Rows(i).Cells(7).Value) <> "" Then
                        .Parameters.AddWithValue("@stavka_brDok", CSng(dgStorno.Rows(i).Cells(7).Value))
                    Else
                        .Parameters.AddWithValue("@stavka_brDok", "")
                    End If
                    .Parameters.AddWithValue("@stavka_datDok", dgStorno.Rows(i).Cells(8).Value)
                    .Parameters.AddWithValue("@stavka_valuta", dgStorno.Rows(i).Cells(9).Value)
                    .Parameters.AddWithValue("@stavka_zatvorena", 0)
                    .Parameters.AddWithValue("@stavka_konto_povezan", 0)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            Next
        End If
        CN.Close()
    End Sub

    Private Sub snimi_storno()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "fn_nalog_storno_add"
                .Parameters.AddWithValue("@id_nalog_storno", _id_nalog_storno)
                .Parameters.AddWithValue("@id_nalog", _id_nalog)
                .Parameters.AddWithValue("@nal_storno_broj", _storno_broj)
                .Parameters.AddWithValue("@nal_vrsta", _nal_vrsta)
                .Parameters.AddWithValue("@nal_broj", _nal_broj)
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If
        CN.Close()
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

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "fn_nalog_proknjizi"
                .Parameters.AddWithValue("@id_nalog", _id_nalog_storno)
                .Parameters.AddWithValue("@nal_proknjizen", 1)
                .Parameters.AddWithValue("@nal_proknjizen_datum", Today)
                .Parameters.AddWithValue("@nal_napomena", "Proknjižen nalog")
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If
        CN.Close()
    End Sub

    Private Sub storniraj()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "fn_nalog_storniraj"
                .Parameters.AddWithValue("@id_nalog", _id_nalog)
                .Parameters.AddWithValue("@nal_storniran", 1)
                .Parameters.AddWithValue("@nal_storniran_datum", Today)
                .Parameters.AddWithValue("@nal_napomena", "STORNIRAN NALOG")
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If
        CN.Close()
    End Sub

    Private Sub ispitaj_konto()
        If jeste_broj(txtKonto.Text) Then
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
                                .CommandText = "select * from dbo.fn_konto where dbo.fn_konto.Konto_Sifra = '" & txtKonto.Text & "'"
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

    Private Sub nadji_analitiku()
        If Trim(txtAnalitika.Text) <> "" Then
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
        End If
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
            btnStorno.Enabled = False
            Dim mTekst As Control ' TextBox
            For Each mTekst In panStavka.Controls
                If mTekst.Name Like "txt*" Then
                    If mTekst.Text <> "" Then
                        _ima_promena = True
                        btnStorno.Enabled = True
                        Exit For
                    End If
                End If
            Next
        Else
            _ima_promena = True
            btnStorno.Enabled = True
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
            '_povezan_konto = .Rows(e.RowIndex).Cells(11).Value

            'txtKonto_opis.Text = .Rows(e.RowIndex).Cells(1).Value
            'txtAnalitika_opis.Text = .Rows(e.RowIndex).Cells(1).Value
            'txtOpis.Text = .Rows(e.RowIndex).Cells(1).Value

            'nadji_opis()
        End With
        'btnUnesi.Visible = False
        'btnNastavi.Visible = True
        'btnIzmeni.Visible = True
    End Sub
#End Region

    Private Sub btnStorno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStorno.Click
        _storno_broj = Nadji_rb(Imena.tabele.fn_nalog_head.ToString, 2, "ST")
        storno_nalog()
    End Sub

    Private Sub btnNazad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNazad.Click
        originalni_nalog()
    End Sub

    Private Sub btnSnimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSnimi.Click
        If MsgBox(My.Resources.text_upit_storno, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            snimi_head()
            snimi_stavku()
            snimi_storno()
            proknjizi()
            storniraj()
            labStatusNaloga.Text = "Nalog je storniran"
            btnSnimi.Enabled = False
        End If
    End Sub

End Class
