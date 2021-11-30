Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class cntArtikliUnos
    Private _pocetak As Boolean = True
    Private _lek, _L1, _jkl, _datOD, _datDO As Boolean '_jkl = dali je jkl sifra dobra i da li je prosla kontrolu

    Private sql_podgrupa As String = _
               "SELECT dbo.app_artikl_grupa.* FROM dbo.app_artikl_grupa "

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntArtikliUnos_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'If _ima_promena Then
        '    If MsgBox("Načinili ste promene. Dali želite da ih snimite?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '        snimi()
        '    End If
        'End If

        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntArtikli
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _mSpliter.SplitterDistance = 235

        Dim myControl1 As New cntArtikli_search
        myControl1.Parent = _mSpliter.Panel1
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_artikli_promet + My.Resources.text_search ' " : Artikli" + " - pretraga"
        cntMeniArtikli.podesi_boje_linkova(_mPanArtikli_meni)
        _mLinkArtikli_search.BackColor = Color.GhostWhite
        _mLinkArtikli_search.ForeColor = Color.MidnightBlue
        cntMeniArtikli.enable_linkove(_mPanArtikli_meni)

    End Sub

    Private Sub cntArtikliUnos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()
    End Sub

    Private Sub pocetak()
        rtxOpisGrupe.SelectionBullet = True
        rtxOpisGrupe.SelectionCharOffset = 2
        rtxOpisGrupe.SelectionStart = 5
        rtxOpisGrupe.Multiline = True
        rtxOpisGrupe.WordWrap = True

        _novi_jkl_unesen = False
        _novi_jkl_potreban = True
        _artikl_jkl = ""

        tlbMain.Dock = DockStyle.Fill

        'labAlert.Text = ""
        txtNaziv.Text = ""
        txtSifra.Text = Nadji_rb(Imena.tabele.rm_artikli.ToString, 1)

        popuni_partnere()
        popuni_grupa()
        popuni_jm()

        chkHumanitarna.Checked = False
        chkPozitivna.Checked = False
        chkRegAdr.Checked = False
        chkRokTr.Checked = False
        chkSerBr.Checked = False

        _gr_art_opis_sifra = ""
        _gr_art_opis_naziv = ""
        _gr_art_opis_marza = ""
        _gr_art_opis_pdv = ""
        _gr_art_opis_lek = ""
        _gr_art_opis_l1 = ""
        _gr_art_opis_dokument = ""

        rtxOpisGrupe.Text = "Šifra:....." & _gr_art_sifra & vbNewLine & _
                            "Naziv:...." & _gr_art_naziv & vbNewLine & _
                            "Marža:..." & _gr_art_marza & vbNewLine & _
                            "PDV:......" & _gr_art_pdv & vbNewLine & _
                            "Lek:......." & da_ne(_gr_art_lek) & vbNewLine & _
                            "L1:........." & da_ne(_gr_art_L1) & vbNewLine & _
                            "Izdaje se na: " & _vrsta_dok_naziv

        _ima_promena = False
        _pocetak = False

        tlbDetails.Enabled = False
        tlbLek.Visible = False
    End Sub

    Shared Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function

    Private Sub popuni_genericko()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbGenericko.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_genericko_ime.* from dbo.app_genericko_ime order by dbo.app_genericko_ime.genericko_ime"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbGenericko.Items.Add(DR.Item("genericko_ime"))
            Loop
            DR.Close()
        End If
        If cmbGenericko.Items.Count > 0 Then
            cmbGenericko.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_fo()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbFO.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_fo.* from dbo.app_fo"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbFO.Items.Add(DR.Item("fo_naziv"))
            Loop
            DR.Close()
        End If
        If cmbFO.Items.Count > 0 Then
            cmbFO.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_grupa()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbGrupaArtikla.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_artikl_grupa.* from dbo.app_artikl_grupa"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbGrupaArtikla.Items.Add(Mid(DR.Item("gr_artikla_sifra"), 1, 5)) '& " - " & DR.Item("gr_artikla_naziv"))
            Loop
            DR.Close()
        End If
        If cmbGrupaArtikla.Items.Count > 0 Then
            cmbGrupaArtikla.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_podgrupa()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbPodgrupa.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql_podgrupa
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbPodgrupa.Items.Add(Mid(DR.Item("gr_artikla_sifra"), 1, 5)) ' & " - " & DR.Item("gr_artikla_naziv"))
            Loop
            DR.Close()
        End If
        If cmbPodgrupa.Items.Count > 0 Then
            cmbPodgrupa.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_partnere()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbProizvodjac.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_partneri.* from dbo.app_partneri where " & _
                                "partner_proizvodjac = 1 ORDER BY partner_naziv"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbProizvodjac.Items.Add(DR.Item("partner_naziv"))
            Loop
            DR.Close()
        End If
        If cmbProizvodjac.Items.Count > 0 Then
            cmbProizvodjac.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_jm()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbJM.Items.Clear()

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

    Private Function nova_sifra(ByVal _kategorija) As String
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        nova_sifra = ""
        CN.Open()

        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_kategorizacija.* from dbo.rm_kategorizacija where dbo.rm_kategorizacija.naziv = '" & _kategorija & "'"
                DR = .ExecuteReader
            End With

            Dim prefix As String = ""
            Do While DR.Read
                prefix = RTrim(DR.Item("prefix"))
            Loop
            CM.Dispose()
            DR.Close()

            Dim n As Integer = 0

            If prefix <> "" Then
                CM = New SqlCommand()
                Dim sql As String = "select dbo.rm_artikli.* from dbo.rm_artikli where dbo.rm_artikli.sifra like '" & prefix & "%' order by dbo.rm_artikli.sifra"
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = sql
                    DR = .ExecuteReader
                End With

                Do While DR.Read
                    Try
                        n = CInt(Mid(DR.Item("sifra"), prefix.Length + 1, DR.Item("sifra").ToString.Length))
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OkOnly)
                    End Try
                Loop
                DR.Close()
                CM.Dispose()
            End If

            Dim i As Integer = 0
            For i = 0 To 3 - n.ToString.Length - 1
                nova_sifra += "0"
            Next
            nova_sifra = prefix & nova_sifra & CStr(n + 1)
        End If
        CN.Close()
    End Function

    Private Sub btnSnimi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSnimi.Click
        snimi()
    End Sub
    Private Sub btnSnimi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnSnimi.KeyPress
        If e.KeyChar = Chr(13) Then
            'snimi_jkl()
            snimi()
            'pocetak()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
    Private Sub btnCancel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnCancel.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.Dispose()
        End If
    End Sub

    Private Sub txtSifra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSifra.KeyPress
        If e.KeyChar = Chr(13) Then
            txtNaziv.Select()
        End If
    End Sub
    Private Sub txtSifra_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSifra.TextChanged
        If Not _pocetak Then
            _ima_promena = True
            _artikl_sifra = txtSifra.Text
        End If
    End Sub

    Private Sub txtNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNaziv.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbGrupaArtikla.Select()
        End If
    End Sub
    Private Sub txtNaziv_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNaziv.TextChanged
        If Not _pocetak Then
            _ima_promena = True
            _artikl_naziv = txtNaziv.Text

            If txtNaziv.Text <> "" Then
                tlbDetails.Enabled = True
            Else
                tlbDetails.Enabled = False
            End If
        End If
    End Sub

    Private Sub cmbGrupaArtikla_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbGrupaArtikla.KeyPress
        If e.KeyChar = Chr(13) Then
            chkPozitivna.Select()
        End If
    End Sub
    Private Sub cmbGrupaArtikla_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbGrupaArtikla.SelectedIndexChanged

        selektuj_GrupeArt(cmbGrupaArtikla.Text, Selekcija.po_sifri)
        selektuj_VrsteDokumenta(_id_vrsta_dok, Selekcija.po_id)

        rtxOpisGrupe.Text = ""
        rtxOpisGrupe.Text = "Šifra:....." & _gr_art_sifra & vbNewLine & _
                            "Naziv:...." & _gr_art_naziv & vbNewLine & _
                            "Marža:..." & _gr_art_marza & vbNewLine & _
                            "PDV:......" & _gr_art_pdv & vbNewLine & _
                            "Lek:......." & da_ne(_gr_art_lek) & vbNewLine & _
                            "L1:........." & da_ne(_gr_art_L1) & vbNewLine & _
                            "Izdaje se na: " & _vrsta_dok_naziv

        If Not _pocetak Then

            selektuj_GrupeArt(RTrim(cmbGrupaArtikla.Text), Selekcija.po_sifri)
            _artikl_id_grupa = _id_gr_art

            _ima_promena = True

            Dim poruka As String = "Promenili ste grupu artikla. "

            Select Case _gr_art_lek ' _gr_art_L1
                Case Is = True
                    _lek = True
                    tlbLek.Visible = True
                    dateOD.Value = "01/01/" & Now.Year.ToString
                    'dateDO.Value = "12/31/" & Now.Year.ToString
                    sql_podgrupa = "select dbo.app_artikl_grupa.* " & _
                                   "from dbo.app_artikl_grupa " & _
                                   "where gr_artikla_nadredj_gr = N'" & RTrim(cmbGrupaArtikla.Text) & "'"
                    popuni_podgrupa()
                    popuni_fo()
                    popuni_genericko()
                    poruka += "Nova grupa IMA svojstvo 'Leka i Pozitivne Liste'. U obavezi ste da unesete Datum početka važnosti."
                Case Is = False
                    _lek = False
                    cmbFO.Items.Clear()
                    cmbGenericko.Items.Clear()
                    cmbPodgrupa.Items.Clear()
                    tlbLek.Visible = False
                    poruka += "Nova grupa NEMA svojstvo 'Leka i Pozitivne Liste'. U obavezi ste da unesete Datum prestanka važnosti."
            End Select

            'Dim _sifra As String = ""
            'Dim i As Integer = 0

            'If jeste_broj(Mid((cmbGrupaArtikla.Text), 1, InStr(cmbGrupaArtikla.Text, " ") - 1)) Then
            '    _sifra += Mid((cmbGrupaArtikla.Text), 1, InStr(cmbGrupaArtikla.Text, " ") - 1)
            'End If
        End If
    End Sub
    'Private Sub btnL1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnL1.Click
    '    If _novi_jkl_potreban Then
    '        _vrsta_promene = vrsta_promene.unos
    '        _unesen_jkl = False
    '    Else
    '        _vrsta_promene = vrsta_promene.edit_iz_unosa
    '    End If

    '    _grupa_art = RTrim(cmbGrupaArtikla.Text)

    '    Dim mForm As New frmL1_promena
    '    mForm.Show()
    'End Sub

    Private Sub cmbJM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbJM.KeyPress
        If e.KeyChar = Chr(13) Then
            'cmbPDV.Select()
        End If
    End Sub
    Private Sub cmbJM_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbJM.SelectedIndexChanged
        If Not _pocetak Then
            _ima_promena = True

            selektuj_jm(cmbJM.Text, Selekcija.po_nazivu)
            _artikl_id_jm = _id_jm
        End If
    End Sub

    Private Sub cmbProizvodjac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbProizvodjac.KeyPress
        If e.KeyChar = Chr(13) Then
            chkHumanitarna.Select()
        End If
    End Sub
    Private Sub cmbProizvodjac_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProizvodjac.SelectedIndexChanged
        If Not _pocetak Then
            _ima_promena = True

            selektuj_partnera(cmbProizvodjac.Text, Selekcija.po_nazivu)
            _artikl_id_proizvodjac = _id_partner
        End If
    End Sub

    Private Sub chkHumanitarna_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkHumanitarna.KeyPress
        If e.KeyChar = Chr(13) Then
            chkSerBr.Select()
        End If
    End Sub
    Private Sub chkHumanitarna_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkHumanitarna.CheckedChanged
        If Not _pocetak Then
            _ima_promena = True

            _artikl_humanitarna_pomoc = chkHumanitarna.Checked
        End If
    End Sub

    Private Sub chkSerBr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkSerBr.KeyPress
        If e.KeyChar = Chr(13) Then
            chkRokTr.Select()
        End If
    End Sub
    Private Sub chkSerBr_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSerBr.CheckedChanged
        If Not _pocetak Then
            _ima_promena = True

            _zal_po_serbr = chkSerBr.Checked
        End If
    End Sub

    Private Sub chkRokTr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkRokTr.KeyPress
        If e.KeyChar = Chr(13) Then
            chkRegAdr.Select()
        End If
    End Sub
    Private Sub chkRokTr_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkRokTr.CheckedChanged
        _ima_promena = True

        _zal_po_roku_trajanja = chkRokTr.Checked
    End Sub

    Private Sub chkRegAdr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkRegAdr.KeyPress
        If e.KeyChar = Chr(13) Then
            chkRegAdr.Select()
        End If
    End Sub
    Private Sub chkRegAdr_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkRegAdr.CheckedChanged
        If Not _pocetak Then
            _ima_promena = True

            _zal_po_reg_adresi = chkRegAdr.Checked
        End If
    End Sub

    Private Sub txtJKL_sifra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJKL_sifra.KeyPress
        If e.KeyChar = Chr(13) Then
            chkPozitivna.Select()
        End If
    End Sub
    Private Sub txtJKL_sifra_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJKL_sifra.LostFocus
        If txtJKL_sifra.Text = "" Then
            _jkl = False
            Beep()
            txtJKL_sifra.BackColor = Color.LavenderBlush
            'MsgBox("JKL sifru morate obavezno uneti.", MsgBoxStyle.Information)
        Else
            If txtJKL_sifra.Text <> "" And Len(txtJKL_sifra.Text) = 7 And jeste_broj(txtJKL_sifra.Text) Then
                If jkl_postoji() Then
                    _jkl = False
                    Beep()
                    txtJKL_sifra.BackColor = Color.LavenderBlush
                    MsgBox("JKL sifra vec postoji u bazi. Molimo da ispravite gresku.", MsgBoxStyle.Information)
                Else
                    _jkl = True
                    txtJKL_sifra.BackColor = Color.GhostWhite
                End If
            Else
                Dim _poruka As String = "Niste uneli ispravnu šifru. Šifra je:"
                Select Case Len(txtJKL_sifra.Text)
                    Case Is > 7
                        _poruka += " duža od 7 cifara"
                    Case Is < 7
                        _poruka += " kraća od 7 cifara"
                End Select
                'Select Case jeste_broj(txtJKL_sifra.Text)
                '    Case True
                '        _poruka += "."
                '    Case False
                '        _poruka += ", ne sadrži samo cifre."
                'End Select
                _poruka += " Pokušajte ponovo."
                _jkl = False
                Beep()
                MsgBox(_poruka, MsgBoxStyle.OkOnly)
                txtJKL_sifra.BackColor = Color.LavenderBlush
            End If
        End If
    End Sub
    Private Sub txtJKL_sifra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJKL_sifra.TextChanged
        _ima_promena = True
    End Sub

    Private Sub chkPozitivna_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkPozitivna.KeyPress
        If e.KeyChar = Chr(13) Then
            dateOD.Select()
        End If
    End Sub
    Private Sub chkPozitivna_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPozitivna.CheckedChanged
        If Not _pocetak Then
            _ima_promena = True

            Select Case chkPozitivna.CheckState
                Case CheckState.Checked
                    _L1 = True
                    sql_podgrupa = "select dbo.app_artikl_grupa.* " & _
                                   "from dbo.app_artikl_grupa " & _
                                   "where gr_artikla_nadredj_gr = N'" & RTrim(cmbGrupaArtikla.Text) & "' and " & _
                                   "gr_artikla_L1 = 1"
                Case CheckState.Unchecked
                    _L1 = False
                    sql_podgrupa = "select dbo.app_artikl_grupa.* " & _
                                   "from dbo.app_artikl_grupa " & _
                                   "where gr_artikla_nadredj_gr = N'" & RTrim(cmbGrupaArtikla.Text) & "' and " & _
                                   "gr_artikla_L1 = 0"
            End Select

            popuni_podgrupa()
        End If
    End Sub

    Private Sub dateOD_CloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateOD.CloseUp

        _datOD = True
        '_datOD = False

    End Sub
    Private Sub dateOD_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateOD.EnabledChanged
        Select Case dateOD.Enabled
            Case True
                _datOD = True
            Case False
                _datOD = False
        End Select
    End Sub
    Private Sub dateOd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dateOD.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbGenericko.Select()
        End If
    End Sub
    Private Sub dateOd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateOD.ValueChanged
        If Not _pocetak Then
            _ima_promena = True
            _datOD = True
        End If
    End Sub

    'Private Sub dateDO_CloseUp(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If dateOD.Value.Date <= dateDO.Value.Date Then
    '        _datDO = True
    '    Else
    '        _datDO = False
    '        dateDO.Value = dateOD.Value
    '        MsgBox("Datum početka važenja L1 ne može biti veći datuma prestanka važenja. Pokušajte ponovo", MsgBoxStyle.OkOnly)
    '    End If
    'End Sub
    'Private Sub dateDO_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Select Case dateDO.Enabled
    '        Case True
    '            _datDO = True
    '        Case False
    '            _datDO = False
    '    End Select
    'End Sub
    'Private Sub dateDO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If e.KeyChar = Chr(13) Then
    '        cmbPodgrupa.Select()
    '    End If
    'End Sub
    'Private Sub dateDO_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not _pocetak Then
    '        _ima_promena = True
    '        _datDO = True
    '    End If
    'End Sub

    Private Sub cmbPodgrupa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPodgrupa.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbGenericko.Select()
        End If
    End Sub
    Private Sub cmbPodgrupa_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPodgrupa.SelectedIndexChanged
        If Not _pocetak Then
            _ima_promena = True
        End If
    End Sub

    Private Sub cmbGenericko_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbGenericko.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbFO.Select()
        End If
    End Sub
    Private Sub cmbGenericko_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGenericko.SelectedIndexChanged
        If Not _pocetak Then
            _ima_promena = True
        End If
    End Sub

    Private Sub cmbFO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbFO.KeyPress
        If e.KeyChar = Chr(13) Then
            btnSnimi.Select()
        End If
    End Sub
    Private Sub cmbFO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFO.SelectedIndexChanged
        If Not _pocetak Then
            _ima_promena = True
        End If
    End Sub

    Private Sub snimi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        If _lek Then
            If _jkl And Not jkl_postoji() Then
                GoTo snimi
            Else
                Dim _poruka As String = "Niste uneli sve podatke." & vbLf & _
                                        "Za GRUPU artikla LEK obavezna polja su: JKL Šifra, Datum početka važenja L1" & vbLf & _
                                        "Molimo Vas da isprevite sledeća polja: "
                Select Case _jkl
                    Case True
                        Dim _poruka1 As String = "Niste uneli ispravnu šifru. Šifra je:"
                        Select Case Len(txtJKL_sifra.Text)
                            Case Is > 7
                                _poruka1 += " duža od 7 cifara"
                            Case Is < 7
                                _poruka1 += " kraća od 7 cifara"
                        End Select
                        Select Case jeste_broj(txtJKL_sifra.Text)
                            Case True
                                _poruka1 += "."
                            Case False
                                _poruka1 += ", ne sadrži samo cifre."
                        End Select
                        If _poruka1 <> "" Then
                            _poruka1 += " Pokušajte ponovo."
                            _jkl = False
                            MsgBox(_poruka1, MsgBoxStyle.OkOnly)
                            txtJKL_sifra.BackColor = Color.LavenderBlush
                            _poruka1 = ""
                            Exit Select
                        End If
                        _poruka += ""
                        txtJKL_sifra.BackColor = Color.GhostWhite
                    Case False
                        _poruka += ", JKL Šifra"
                        txtJKL_sifra.BackColor = Color.LavenderBlush
                End Select
                Select Case _datOD
                    Case True
                        _poruka += ""
                        dateOD.CalendarMonthBackground = Color.GhostWhite
                    Case False
                        _poruka += ", Datum početka važenja L1"
                        dateOD.CalendarMonthBackground = Color.LavenderBlush
                End Select
                _poruka += "."
                Beep()
                MsgBox(_poruka, MsgBoxStyle.OkOnly)
            End If
        Else
            GoTo snimi
        End If
        Exit Sub

snimi:

        If _lek Then
            selektuj_fo(cmbFO.Text, Selekcija.po_nazivu)
            selektuj_GrupeArt(RTrim(cmbPodgrupa.Text), Selekcija.po_sifri)

            snimi_jkl()
            If _L1 Then snimi_pozitivnu_listu()
        End If

        Try
            selektuj_jm(RTrim(cmbJM.Text), Selekcija.po_oznaci)
            selektuj_GrupeArt(RTrim(cmbGrupaArtikla.Text), Selekcija.po_sifri)
            selektuj_pdv(_gr_art_pdv, Selekcija.po_nazivu)
            selektuj_partnera(cmbPodgrupa.Text, Selekcija.po_nazivu)

            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_artikli_add"
                    .Parameters.AddWithValue("@artikl_sifra", txtSifra.Text)
                    .Parameters.AddWithValue("@artikl_naziv", txtNaziv.Text)
                    .Parameters.AddWithValue("@id_grup_artikla", _id_gr_art)
                    .Parameters.AddWithValue("@id_podgrup_artikla", _artikl_id_podgrupa)
                    .Parameters.AddWithValue("@jkl", txtJKL_sifra.Text)
                    .Parameters.AddWithValue("@artikl_lek", _lek)
                    .Parameters.AddWithValue("@id_jm", _id_jm)
                    .Parameters.AddWithValue("@id_pdv", _id_pdv)
                    .Parameters.AddWithValue("@id_fo", _id_fo)
                    .Parameters.AddWithValue("@id_proizvodjac", Partner_id(cmbProizvodjac.Text))
                    .Parameters.AddWithValue("@artikl_genericko_ime", cmbGenericko.Text)
                    .Parameters.AddWithValue("@artikl_bar_kod", "")
                    .Parameters.AddWithValue("@artikl_human_pomoc", chkHumanitarna.CheckState)
                    .Parameters.AddWithValue("@zal_po_serbr", chkSerBr.CheckState)
                    .Parameters.AddWithValue("@zal_po_roku_trajanja", chkRokTr.CheckState)
                    .Parameters.AddWithValue("@zal_po_reg_adresi", chkRegAdr.CheckState)
                    .Parameters.AddWithValue("@artikl_aktivan", 0)
                    .ExecuteScalar()
                End With
                aktivan_fo()
                aktivan_grupa()
                aktivan_jm()
                aktivan_partner()
                aktivan_pdv()
            End If
            CM.Dispose()
            CN.Close()
            _ima_promena = False
            MsgBox("Snimanje završeno.", MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

        pocetak()

    End Sub

    Private Sub snimi_jkl()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "app_jkl_add"
                    .Parameters.AddWithValue("@jkl_sifra", txtJKL_sifra.Text)
                    .Parameters.AddWithValue("@jkl_naziv", txtNaziv.Text)
                    .Parameters.AddWithValue("@jkl_pozitivna_lista", chkPozitivna.CheckState)
                    .ExecuteScalar()
                End With
            End If
            CM.Dispose()
            CN.Close()
            _ima_promena = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Function jkl_postoji() As Boolean
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim i As Integer = 0

        jkl_postoji = True

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.rm_artikli where dbo.rm_artikli.jkl = '" & txtJKL_sifra.Text & "'"
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            Do While DR.Read
                i += 1
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
        If i > 0 Then
            jkl_postoji = True
            MsgBox("JKL Šifra koju ste uneli već postoji u bazi. Molimo Vas da ispravite unešene podatke.", MsgBoxStyle.OkOnly)
        Else
            jkl_postoji = False
        End If
    End Function

    Private Sub snimi_pozitivnu_listu()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Dim datOD, datDO As Date
        Dim _procedura As String = ""
        Dim _koji_unos As Integer = 0

        If _datOD = True And _datDO = True Then
            'datDO = dateDO.Value.Date
            datOD = dateOD.Value.Date
            _procedura = "app_pozitivna_lista_add_kompletno"
            _koji_unos = 1
        Else
            If _datOD = True And _datDO = False Then
                datOD = dateOD.Value.Date
                datDO = Nothing
                _procedura = "app_pozitivna_lista_add_od"
                _koji_unos = 2
            Else
                If _datOD = False And _datDO = True Then
                    datOD = Nothing
                    'datDO = dateDO.Value.Date
                    _procedura = "app_pozitivna_lista_add_do"
                    _koji_unos = 3
                Else
                    If _datOD = False And _datDO = False Then
                        datDO = "12/31/" & Now.Year.ToString
                        datOD = "01/01/" & Now.Year.ToString
                        _procedura = "app_pozitivna_lista_add_kompletno"
                        _koji_unos = 1
                    End If
                End If
            End If
        End If

        Try
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = _procedura
                    .Parameters.AddWithValue("@datum_promene", Today.Date)
                    .Parameters.AddWithValue("@jkl_sifra", txtJKL_sifra.Text)
                    .Parameters.AddWithValue("@L1", chkPozitivna.Checked)
                    Select Case _koji_unos
                        Case 1
                            .Parameters.AddWithValue("@l1_datum_OD", datOD.Date)
                            .Parameters.AddWithValue("@l1_datum_DO", datDO.Date)
                        Case 2
                            .Parameters.AddWithValue("@l1_datum_OD", datOD.Date)
                        Case 3
                            .Parameters.AddWithValue("@l1_datum_DO", datDO.Date)
                        Case 4
                    End Select
                    .ExecuteScalar()
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
            Exit Try
        Finally
            CM.Dispose()
            CN.Close()
            '_ima_promena = False
        End Try

    End Sub

    Private Sub pozitivna_lista()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.app_pozitivna_lista where dbo.app_pozitivna_lista.jkl_sifra = '" & _artikl_jkl & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                If Not IsDBNull(DR.Item("L1")) Then
                    chkPozitivna.Checked = DR.Item("L1")
                Else
                    MsgBox("Za izabranu šifru nije definisano na kojoj je listi." & vbLf & "Molimo Vas da ažurirate JKL listu.")
                End If
            Loop
            DR.Close()
        End If

        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub aktivan_grupa()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "app_artikl_grupa_active"
                    .Parameters.AddWithValue("@id_grup_artikla", _id_gr_art)
                    .ExecuteScalar()
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
            Exit Try
        Finally
            CM.Dispose()
            CN.Close()
        End Try

    End Sub

    Private Sub aktivan_jm()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "app_jm_active"
                    .Parameters.AddWithValue("@id_jm", _id_jm)
                    .ExecuteScalar()
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
            Exit Try
        Finally
            CM.Dispose()
            CN.Close()
        End Try

    End Sub

    Private Sub aktivan_pdv()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "app_pdv_active"
                    .Parameters.AddWithValue("@id_pdv", _id_pdv)
                    .ExecuteScalar()
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
            Exit Try
        Finally
            CM.Dispose()
            CN.Close()
        End Try

    End Sub

    Private Sub aktivan_fo()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "app_fo_active"
                    .Parameters.AddWithValue("@id_fo", _id_fo)
                    .ExecuteScalar()
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
            Exit Try
        Finally
            CM.Dispose()
            CN.Close()
        End Try

    End Sub

    Private Sub aktivan_partner()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "app_partneri_active"
                    .Parameters.AddWithValue("@id_partner", _id_partner)
                    .ExecuteScalar()
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
            Exit Try
        Finally
            CM.Dispose()
            CN.Close()
        End Try

    End Sub

   
End Class
