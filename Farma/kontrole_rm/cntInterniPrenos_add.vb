Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class cntInterniPrenos_add

#Region "dekleracija"
    Private kol As Single = 1
    Private cena As Single = 0
    Private mp_cena As Single = 0
    Private c_cena_nab As Single = 0
    Private c_cena_vp As Single = 0
    Private c_cena_mp As Single = 0
    Private pdv As Single = 1
    Private c_pdv As Integer = 18
    Private c_rabat As Integer = 0
    Private marza As Single = 0
    Private c_marza As Integer = 0
    Private c_id_grupa As Integer = 0
    Private lSifra As String = ""
    Private lNaziv As String = ""
    Private lKol As Single = 0
    Private lCena As Single = 0
    Private lId As Integer = 0
    Private c_JM As String = ""
    Private c_Grupa As String = ""
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
    'Private valuta As Integer = 0
    Private nab_cena As Single = 0
    Private nab_vrednost As Single = 0
    Private prod_cena As Single = 0
    Private prod_vrednost As Single = 0
    'Private trenutna_cena As Single = 0
    'Private trenutna_kolicina As Single = 0
    Private sifra As String = ""
    Private naziv As String = ""
    Private indeks As Integer = 0
    Private broj_decimala() As Integer
    Private id_predhodnog_stanja As Integer
    Private id_predhodnog_stanja_stavka As Integer

    Private _pocetak As Boolean = True
    Private _citam_stavke As Boolean = True
    Private _promenjena_marza As Boolean = False
    Private _promenjena_nabav_cena As Boolean = False
    Private _prod_cena_promenjena As Boolean = False
    Private _popunjavam_robu As Boolean = False
    Private _izabran_magacin As Boolean = False
    Private magacinID As Integer = 0
    Private cena_mp() As Single
    Private marza_stavka() As Single

    Private _radi_se_nivelacija As Boolean = False
    Private niv_id_artikl() As Single
    Private niv_kol() As Single
    Private niv_stara_cena() As Single
    Private niv_nova_cena() As Single
    Private niv_pdv() As Integer
    Private niv_stari_iznos_pdv() As Single
    Private niv_novi_iznos_pdv() As Single

    Private upit As String = ""
    Private upit_sifra As String = ""
    Private upit_lek As String = ""

    Shared sql_start As String = _
                    "SELECT DISTINCT " & _
                          "dbo.rm_artikli.artikl_sifra, dbo.rm_artikli.artikl_naziv, " & _
                          "dbo.rm_artikli.jkl, dbo.rm_artikli.artikl_genericko_ime, " & _
                          "dbo.app_artikl_grupa.gr_artikla_sifra, dbo.app_artikl_grupa.gr_artikla_naziv, " & _
                          "dbo.app_partneri.partner_naziv, dbo.app_fo.fo_sifra, dbo.app_fo.fo_naziv, " & _
                          "dbo.app_jm.jm_oznaka, dbo.app_pozitivna_lista.jkl_sifra, dbo.app_pozitivna_lista.L1, " & _
                          "dbo.app_pozitivna_lista.l1_datum_OD, dbo.app_pozitivna_lista.l1_datum_DO " & _
                    "FROM dbo.rm_artikli LEFT OUTER JOIN " & _
                          "dbo.app_pozitivna_lista ON dbo.rm_artikli.jkl = dbo.app_pozitivna_lista.jkl_sifra  " & _
                          "LEFT OUTER JOIN dbo.app_fo ON dbo.rm_artikli.id_fo = dbo.app_fo.id_fo LEFT OUTER JOIN " & _
                          "dbo.app_partneri ON dbo.rm_artikli.id_proizvodjac = dbo.app_partneri.id_partner " & _
                          "LEFT OUTER JOIN dbo.app_jm ON dbo.rm_artikli.id_jm = dbo.app_jm.id_jm LEFT OUTER JOIN " & _
                          "dbo.app_artikl_grupa ON dbo.rm_artikli.id_grup_artikla = dbo.app_artikl_grupa.id_grup_artikla"

    Shared sql As String = ""
#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntInterniPrenos_add_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'If _ima_promena Then
        '    If MsgBox("Načinili ste promene. Dali želite da ih snimite?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '        'snimi()
        '    End If
        'End If

        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntInterniPrenos
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _mSpliter.SplitterDistance = 210

        Dim myControl1 As New cntInterniPrenos_search
        myControl1.Parent = _mSpliter.Panel1
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_int_prenos + My.Resources.text_search
        cntMeniObrada_Izlaz.podesi_boje_linkova(_mPanIntPrenos_meni)
        _mLinkIntPrenos_search.BackColor = Color.GhostWhite
        _mLinkIntPrenos_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub cntInterniPrenos_add_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tlbMain.Dock = DockStyle.Fill
        _lista = Me.lvLista

        broj_decimala = New Integer() {}
        ReDim broj_decimala(100)

        pocetak()
    End Sub

    Private Sub pocetak()

        _pocetak = True

        popuni_magacine()

        dgStavke.Rows.Clear()
        lvLista.Items.Clear()

        '**
        magacinID = 0
        txtBroj.Text = Nadji_rb(Imena.tabele.rm_interni_prenos_head.ToString, 1)
        txtIznosCena.Text = 0
        txtOsnovica.Text = 0
        txtIznosPdv.Text = 0
        txtIznosZanaplatu.Text = 0

        dateKalkulacija.Value = Today

        _pocetak = False
        _izabran_magacin = False
        kontrole()

        cena_mp = New Single() {}
        marza_stavka = New Single() {}
        niv_id_artikl = New Single() {}
        niv_kol = New Single() {}
        niv_stara_cena = New Single() {}
        niv_nova_cena = New Single() {}
        niv_pdv = New Integer() {}
        niv_stari_iznos_pdv = New Single() {}
        niv_novi_iznos_pdv = New Single() {}

        ReDim cena_mp(100)
        ReDim marza_stavka(100)
        ReDim niv_id_artikl(100)
        ReDim niv_kol(100)
        ReDim niv_stara_cena(100)
        ReDim niv_nova_cena(100)
        ReDim niv_pdv(100)
        ReDim niv_stari_iznos_pdv(100)
        ReDim niv_novi_iznos_pdv(100)

    End Sub


#Region "Grid 1"

    Private Sub dgStavke_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgStavke.CellEndEdit
        If e.ColumnIndex = 5 And e.RowIndex = indeks Then
            If IsNothing(dgStavke.Rows(e.RowIndex).Cells(5).Value) Then
                Beep()
                MsgBox("Količina mora biti unešena!", MsgBoxStyle.OkOnly)
                dgStavke.Rows(e.RowIndex).Cells(5).Style.BackColor = Color.Red
            Else
                dgStavke.Rows(e.RowIndex).Cells(5).Style.BackColor = Color.GhostWhite
                dgStavke.Select()
                dgStavke.Rows(indeks).Cells(6).Selected = True
            End If
        End If
    End Sub

    Private Sub dgStavke_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgStavke.KeyPress
        If e.KeyChar = Chr(13) Then
            If dgStavke.CurrentRow.Cells.IndexOf(dgStavke.CurrentCell) = 5 Then
                dgStavke.Select()
                dgStavke.Rows(indeks).Cells(6).Selected = True
            Else
                dgStavke.Select()
                Dim ind As Integer = dgStavke.CurrentRow.Cells.IndexOf(dgStavke.CurrentCell) + 1
                If ind < 14 Then
                    If ind = 10 Then
                        dgStavke.Rows(indeks + 1).Cells(2).Selected = True
                        kol = 1
                        cena = 0
                        mp_cena = 0
                        pdv = 1
                        marza = 0
                        nab_cena = 0
                        nab_vrednost = 0
                        prod_cena = 0
                        prod_vrednost = 0
                    Else
                        dgStavke.Rows(indeks).Cells(6).Selected = True
                    End If
                    'dgStavke.CurrentRow.Cells.Item(ind).Selected = True  'Rows(indeks).Cells(13).Selected = True
                End If
            End If
        End If
    End Sub

    Private Sub dgStavke_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgStavke.CellValueChanged
        If Not _pocetak Then
            With dgStavke
                Try
                    Select Case e.ColumnIndex
                        Case 2
                            indeks = e.RowIndex
                            If Not _popunjavam_robu Then
                                upit_lek = "rm_artikli.artikl_naziv LIKE N'" & .Rows(e.RowIndex).Cells(2).Value.ToString & "%'"
                                filter()
                            End If
                        Case 6
                            If Not _popunjavam_robu Then
                                _promenjena_nabav_cena = True
                            End If
                    End Select

                    If Not _popunjavam_robu Then
                        If Not IsNothing(.Rows(e.RowIndex).Cells(5).Value) Then
                            If .Rows(e.RowIndex).Cells(5).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(5).Value.ToString) Then
                                kol = CSng(.Rows(e.RowIndex).Cells(5).Value)
                            Else
                                kol = 1
                            End If
                        End If
                        If Not IsNothing(.Rows(e.RowIndex).Cells(6).Value) Then
                            If .Rows(e.RowIndex).Cells(6).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(6).Value.ToString) Then
                                cena = CSng(.Rows(e.RowIndex).Cells(6).Value)
                            Else
                                cena = 0
                            End If
                        End If

                        If Not IsNothing(.Rows(e.RowIndex).Cells(8).Value) Then
                            If .Rows(e.RowIndex).Cells(8).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(8).Value.ToString) Then
                                marza = 0 ' c_marza ' CSng(.Rows(e.RowIndex).Cells(9).Value)
                            Else
                                marza = 0 ' c_marza
                            End If
                        End If

                        If Not IsNothing(.Rows(e.RowIndex).Cells(9).Value) Then
                            If .Rows(e.RowIndex).Cells(9).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(9).Value.ToString) Then
                                pdv = 1 + (CSng(.Rows(e.RowIndex).Cells(9).Value) / 100)
                            Else
                                pdv = 1
                            End If
                        End If
                        If Not IsNothing(.Rows(e.RowIndex).Cells(10).Value) Then
                            If .Rows(e.RowIndex).Cells(10).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(10).Value.ToString) Then
                                mp_cena = .Rows(e.RowIndex).Cells(10).Value.ToString
                            Else
                                mp_cena = 0
                            End If
                        End If
                    Else
                        cena = c_cena_nab
                        marza = 0 ' c_marza
                        pdv = 1 + (c_pdv / 100)
                        mp_cena = c_cena_mp '* pdv  ' trenutna_cena
                    End If

                    nab_vrednost = kol * cena

                    If _promenjena_marza Then
                        mp_cena = cena * (1 + (marza / 100))
                    ElseIf _promenjena_nabav_cena Then
                        If cena = 0 Then
                            marza = c_marza '  bilo 0
                        Else
                            marza = c_marza '  bilo 0' ((prod_cena / nab_cena) - 1) * 100
                        End If
                        mp_cena = (cena * (1 + (marza / 100))) * pdv ' CSng(.Rows(e.RowIndex).Cells(11).Value)
                    ElseIf _prod_cena_promenjena Then
                        If cena = 0 Then
                            marza = c_marza '  bilo 0
                        Else
                            marza = c_marza '  bilo 0' ((prod_cena / nab_cena) - 1) * 100
                        End If
                        'prod_cena = CSng(.Rows(e.RowIndex).Cells(11).Value)
                    End If

                    prod_vrednost = kol * mp_cena

                    .Rows(e.RowIndex).Cells(7).Value = nab_vrednost
                    .Rows(e.RowIndex).Cells(8).Value = marza
                    .Rows(e.RowIndex).Cells(10).Value = mp_cena 'prod_cena
                    .Rows(e.RowIndex).Cells(11).Value = kol * mp_cena - (mp_cena / pdv)
                    Dim a As Single = kol * mp_cena - (mp_cena / pdv)
                    .Rows(e.RowIndex).Cells(12).Value = prod_vrednost

                    _promenjena_marza = False
                    _promenjena_nabav_cena = False
                    _prod_cena_promenjena = False

                    Dim i As Integer = 0
                    For i = 0 To .Rows.Count - 2
                        .Rows(i).Cells(5).Style.Format = "N" & broj_decimala(i) 'DataGridViewCellStyle { Format=N3, Alignment=MiddleCenter }
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End With

        End If
        preracunaj()
    End Sub

    Private Sub dgStavke_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgStavke.RowsRemoved
        preracunaj()
    End Sub

#End Region

    Private Sub lvLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLista.DoubleClick
        If _novi_artikl And _prod_cena_promenjena Then Exit Sub

        redni_broj()
        With dgStavke
            If Not IsNothing(lvLista.Items(0).ToString) Then
                If lvLista.Items(0).ToString <> "" Then
                    _popunjavam_robu = True
                    popuni_robu(RTrim(lvLista.SelectedItems.Item(0).SubItems(0).Text))

                    .Rows(indeks).Cells(1).Value = sifra
                    .Rows(indeks).Cells(2).Value = naziv
                    .Rows(indeks).Cells(3).Value = c_JM
                    .Rows(indeks).Cells(4).Value = c_Grupa
                    .Rows(indeks).Cells(6).Value = c_cena_nab
                    .Rows(indeks).Cells(7).Value = 0
                    .Rows(indeks).Cells(8).Value = c_marza
                    .Rows(indeks).Cells(9).Value = c_pdv
                    .Rows(indeks).Cells(10).Value = c_cena_mp
                    .Rows(indeks).Cells(11).Value = c_marza
                    If c_pdv <> 1 Then
                        .Rows(indeks).Cells(12).Value = c_pdv
                    Else
                        .Rows(indeks).Cells(12).Value = 0
                    End If

                    'marza = c_marza

                    .Rows(indeks).Cells(13).Value = c_id_grupa
                    .Rows(indeks).Cells(14).Value = c_cena_nab
                    _popunjavam_robu = False

                    lager()

                Else
                    cena = 0
                End If
            End If
            .Rows(indeks).Cells(5).Style.Format = "N" & broj_decimala(indeks) 'DataGridViewCellStyle { Format=N3, Alignment=MiddleCenter }
            .Select()
            .Rows(indeks).Cells(5).Selected = True
        End With
    End Sub

    Private Sub filter()
        On Error Resume Next

        upit = ""
        sql = ""

        If upit_lek <> "" And upit <> "" Then
            upit = upit & " and " & upit_lek
        Else
            If upit_lek <> "" Then upit = upit_lek
        End If

        sql = sql_start
        If upit <> "" Then
            sql += " WHERE " & upit & " ORDER BY rm_artikli.artikl_naziv"
        End If
        'If _poABCedi Then sql += " ORDER BY rm_artikli.artikl_naziv" 'ASC" DESC" 'ascending

        Lista()

    End Sub

    Shared Sub Lista()

        _lista.Visible = True
        _lista.Items.Clear()

        If sql <> "" Then
            Dim CN As SqlConnection = New SqlConnection(CNNString)
            Dim CM As New SqlCommand
            Dim DR As SqlDataReader

            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = sql
                    DR = .ExecuteReader
                End With

                While DR.Read
                    Dim podatak As New ListViewItem(CStr(DR.Item("artikl_sifra")))

                    podatak.SubItems.Add(DR.Item("artikl_naziv").ToString)
                    podatak.SubItems.Add(DR.Item("gr_artikla_sifra").ToString)
                    podatak.SubItems.Add(DR.Item("gr_artikla_naziv").ToString)
                    podatak.SubItems.Add(DR.Item("jkl").ToString)
                    podatak.SubItems.Add(DR.Item("artikl_genericko_ime").ToString)
                    If Not IsDBNull(DR.Item("L1")) Then
                        podatak.SubItems.Add(da_ne(DR.Item("L1")))
                    Else
                        podatak.SubItems.Add("")
                    End If
                    'podatak.SubItems.Add(da_ne(DR.Item("L1")))
                    podatak.SubItems.Add(DR.Item("jm_oznaka").ToString)
                    podatak.SubItems.Add(DR.Item("fo_sifra").ToString)
                    podatak.SubItems.Add(DR.Item("fo_naziv").ToString)
                    podatak.SubItems.Add(DR.Item("partner_naziv").ToString)

                    _lista.Items.AddRange(New ListViewItem() {podatak})

                End While
                DR.Close()
            End If
            CM.Dispose()
            CN.Close()
        End If

        _lCount.Text = _lista.Items.Count.ToString + " zapisa"

    End Sub

    Shared Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function

    Private Sub btnOsvezi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOsvezi.Click
        If _novi_artikl Then
            dgStavke.Rows(indeks).Cells(1).Value = _novi_artikl_sifra
            _prod_cena_promenjena = False
            _novi_artikl = False
        End If
        popuni_magacine()
    End Sub

    Private Sub btnNoviArtkl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoviArtkl.Click
        Dim mForm As New cntArtikliUnos
        mForm.Show()
    End Sub

    Private Sub popuni_magacine()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbMagacin.Items.Clear()

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
            selektuj_magacin(_int_pr_id_magacina, Selekcija.po_id)
            cmbMagacin.SelectedText = _magacin_naziv
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub redni_broj()
        Dim i As Integer

        For i = 0 To dgStavke.RowCount - 2
            dgStavke.Rows(i).Cells(0).Value = i + 1
        Next
    End Sub

    Private Sub popuni_robu(ByVal _roba As String)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        sifra = ""
        naziv = ""
        c_JM = ""
        c_cena_nab = 0
        c_cena_vp = 0
        c_cena_mp = 0
        'trenutna_kolicina = 0
        c_pdv = 1
        c_marza = 0
        c_id_grupa = 0

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli where dbo.rm_artikli.artikl_sifra = '" & RTrim(_roba) & "'"
                DR = .ExecuteReader
            End With

            Dim id_pdv As Integer = 0
            Dim id_jm As Integer = 0
            Do While DR.Read
                If Not IsDBNull(DR.Item("id_artikl")) Then lId = DR.Item("id_artikl")
                If Not IsDBNull(DR.Item("artikl_naziv")) Then naziv = DR.Item("artikl_naziv")
                If Not IsDBNull(DR.Item("id_grup_artikla")) Then c_id_grupa = DR.Item("id_grup_artikla")
                If Not IsDBNull(DR.Item("id_jm")) Then id_jm = DR.Item("id_jm")
                sifra = RTrim(_roba)
            Loop
            DR.Close()
            CM.Dispose()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_jm.* from dbo.app_jm where id_jm = " & id_jm
                DR = .ExecuteReader
            End With
            Do While DR.Read
                If Not IsDBNull(DR.Item("jm_oznaka")) Then c_JM = DR.Item("jm_oznaka")
                If Not IsDBNull(DR.Item("jm_br_decimala")) Then
                    broj_decimala.SetValue(DR.Item("jm_br_decimala"), indeks)
                Else
                    broj_decimala.SetValue(0, indeks)
                End If
            Loop
            DR.Close()
            CM.Dispose()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.app_artikl_grupa where id_grup_artikla = " & c_id_grupa
                DR = .ExecuteReader
            End With
            Do While DR.Read
                If Not IsDBNull(DR.Item("gr_artikla_skraceno")) Then c_Grupa = DR.Item("gr_artikla_skraceno")
                If Not IsDBNull(DR.Item("gr_artikla_marza")) Then c_marza = DR.Item("gr_artikla_marza")
            Loop
            DR.Close()
            CM.Dispose()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_artikli_cene.* from dbo.rm_artikli_cene where id_artikl = " & lId & " and id_magacin = " & magacinID
                DR = .ExecuteReader
            End With

            Dim id_cene As Integer = 0
            Do While DR.Read
                id_cene = DR.Item("id_cena_robe")
                If Not IsDBNull(DR.Item("cena_nab_zadnja")) Then c_cena_nab = DR.Item("cena_nab_zadnja")
                If Not IsDBNull(DR.Item("cena_vp1")) Then c_cena_vp = DR.Item("cena_vp1")
                If Not IsDBNull(DR.Item("cena_mp")) Then c_cena_mp = DR.Item("cena_mp")
                If Not IsDBNull(DR.Item("pdv")) Then c_pdv = DR.Item("pdv")
                'If Not IsDBNull(DR.Item("rabat")) Then rabat.SetValue(CSng(DR.Item("rabat")), indeks)
                'If Not IsDBNull(DR.Item("marza")) Then c_marza = DR.Item("marza")
            Loop
            DR.Close()
            CM.Dispose()

            If id_cene = 0 Then
                MsgBox("Traženom artiklu u ovom magacinu do sada nije zadata cena.", MsgBoxStyle.OkOnly)
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = "select dbo.app_artikl_grupa.* from dbo.app_artikl_grupa where id_grup_artikla = " & c_id_grupa '& " and id_magacin = " & magacinID
                    DR = .ExecuteReader
                End With
                Do While DR.Read
                    If Not IsDBNull(DR.Item("gr_artikla_pdv")) Then c_pdv = DR.Item("gr_artikla_pdv")
                    If Not IsDBNull(DR.Item("gr_artikla_marza")) Then c_marza = DR.Item("gr_artikla_marza")
                Loop
                DR.Close()
                CM.Dispose()
            End If
        End If
        CN.Close()
    End Sub

    Private Sub lager()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        lSifra = ""
        lNaziv = ""
        lKol = 0
        lCena = 0

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.rm_dnevni_promet_stavka where dbo.rm_dnevni_promet_stavka.id_artikl = " & lId
                DR = .ExecuteReader
            End With

            Do While DR.Read
                If Not IsDBNull(DR.Item("dp_art_stanje")) Then lKol = DR.Item("dp_art_stanje")
                If Not IsDBNull(DR.Item("dp_art_cena")) Then lCena = DR.Item("dp_art_cena")
            Loop
            DR.Close()
            CM.Dispose()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.rm_artikli where dbo.rm_artikli.id_artikl = " & lId
                DR = .ExecuteReader
            End With
            Do While DR.Read
                If Not IsDBNull(DR.Item("artikl_sifra")) Then lSifra = DR.Item("artikl_sifra")
                If Not IsDBNull(DR.Item("artikl_naziv")) Then lNaziv = DR.Item("artikl_naziv")
            Loop
            DR.Close()
            CM.Dispose()

        End If
        CN.Close()

        labLager.Text = RTrim(lSifra) & " - " & lNaziv & " - kol: " & lKol & " - cena: " & lCena

    End Sub

    Private Sub zatvori_formu()
        If _unesen Then
            panHeader.Enabled = False
            Panel1.Enabled = False
            cmbMagacin.Enabled = False

            dgStavke.AllowUserToAddRows = False
            dgStavke.Enabled = False
            lvLista.Enabled = False

            txtIznosCena.Enabled = False
            txtIznosPdv.Enabled = False
            txtIznosRabat.Enabled = False
            txtIznosZanaplatu.Enabled = False
            txtOsnovica.Enabled = False

            btnSnimi.Enabled = False
            btnZakljuci.Enabled = False
        End If
    End Sub

    Private Sub preracunaj()
        Dim i As Integer

        s_nab_vrednost = 0
        s_pdv = 0
        's_rab = 0
        s_ztr = 0
        s_marza = 0
        s_prod_vrednost = 0
        s_pdv_osnovica = 0

        Try
            For i = 0 To dgStavke.Rows.Count - 2
                Dim kol As Single = CDec(dgStavke.Rows(i).Cells(5).Value)
                Dim cena As Single = CDec(dgStavke.Rows(i).Cells(6).Value)
                'Dim nabcena As Single = CSng(dgStavke.Rows(i).Cells(9).Value)
                Dim nabvr As Single = CDec(dgStavke.Rows(i).Cells(7).Value)
                Dim mar As Single = 0 ' CDec(dgStavke.Rows(i).Cells(8).Value)
                Dim pdv As Single = CDec(dgStavke.Rows(i).Cells(9).Value)
                Dim mp_cena As Single = CDec(dgStavke.Rows(i).Cells(10).Value)
                Dim pdv_iznos As Single = CDec(dgStavke.Rows(i).Cells(11).Value)
                Dim pr_vred As Single = CDec(dgStavke.Rows(i).Cells(12).Value)

                s_nab_vrednost += nabvr
                s_marza += 0 ' (nabvr * mar / 100)
                's_pdv += (kol * pr_vred * pdv / 100)
                s_pdv += kol * (mp_cena * (1 - (1 / (1 + (pdv / 100)))))
                's_pdv = 0
                s_prod_vrednost += pr_vred
                s_pdv_osnovica += kol * mp_cena / (1 + (pdv / 100))
                's_pdv_osnovica = 0
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'If Not _unesen Then
        txtIznosCena.Text = Format(s_nab_vrednost, "##,##0.00")
        'txtIznosRabat.Text = Format(s_rab,  "##,##0.00")
        txtRazlikauceni.Text = Format(s_marza, "##,##0.00")
        txtOsnovica.Text = Format(s_pdv_osnovica, "##,##0.00")
        txtIznosPdv.Text = Format(s_pdv, "##,##0.00")
        txtIznosZanaplatu.Text = Format(s_prod_vrednost, "##,##0.00")
        'End If

    End Sub

#Region "Snimi"
    Private Sub btnSnimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSnimi.Click
        snimi_head()
        snimi_pdv()
        snimi_stavku()
        'snimi_cene()

        unesi_dnevni_promet_head(Today.Date, Now, _id_magacin, _id_magacin, 0, ID_vrsta_dokumenta, _id_int_pr, _
                       txtBroj.Text, txtIznosCena.Text, 0, 1, 0, vrsta_promene.unos)

        _id_dnevni_promet = Nadji_id(Imena.tabele.rm_dnevni_promet_head.ToString)

        Dim i As Integer
        For i = 0 To dgStavke.Rows.Count - 2
            selektuj_artikl(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)
            unesi_dnevni_promet_stavka(_id_dnevni_promet, magacinID, _id_artikl, dgStavke.Rows(i).Cells(5).Value, 0, _
                   CSng(dgStavke.Rows(i).Cells(6).Value), dgStavke.Rows(i).Cells(9).Value, True, False)
        Next

        ispitaj_cene()

        pocetak()
    End Sub

    Private Sub snimi_head()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_interni_prenos_head_add"
                .Parameters.AddWithValue("@int_pr_broj", txtBroj.Text)
                .Parameters.AddWithValue("@id_magacina", _id_magacin)
                .Parameters.AddWithValue("@int_pr_datum", dateKalkulacija.Value.Date)
                .Parameters.AddWithValue("@int_pr_opis", "")
                .Parameters.AddWithValue("@int_pr_ukupno", CSng(txtIznosCena.Text))
                .Parameters.AddWithValue("@int_pr_pdv_osnovica", CSng(txtOsnovica.Text))
                .Parameters.AddWithValue("@int_pr_pdv", CSng(txtIznosPdv.Text))
                .Parameters.AddWithValue("@int_pr_svega", CSng(txtIznosZanaplatu.Text))
                .Parameters.AddWithValue("@int_pr_zakljucena", 0)
                .Parameters.AddWithValue("@id_vrsta_dokumenta", ID_vrsta_dokumenta)
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
        _porezi = New Single() {}

        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_interni_prenos_pdv_delete"
                .Parameters.AddWithValue("@id_int_pr", _id_int_pr)
                .ExecuteScalar()
            End With
            CM.Dispose()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_artikl_grupa.* from dbo.app_artikl_grupa"
                DR = .ExecuteReader
            End With

            _broj_stavki = 0
            Do While DR.Read
                _broj_stavki += 1
            Loop
            DR.Close()

            '**************************
            ReDim _porezi(_broj_stavki * 5)

            DR = CM.ExecuteReader
            Do While DR.Read
                If Not IsDBNull(DR.Item("gr_artikla_sifra")) Then
                    _porezi.SetValue(CSng(DR.Item("id_grup_artikla")), i * 5)
                    _porezi.SetValue(CSng(DR.Item("gr_artikla_marza")), (i * 5) + 1)
                    _porezi.SetValue(CSng(DR.Item("gr_artikla_pdv")), (i * 5) + 2)
                    _porezi.SetValue(saberi_osnovice(DR.Item("id_grup_artikla")), (i * 5) + 3)
                    _porezi.SetValue(saberi_pdv(DR.Item("id_grup_artikla")), (i * 5) + 4)
                    'naziv = DR.Item("gr_artikla_naziv")
                End If
                i += 1
            Loop
            DR.Close()
        End If
        CM.Dispose()

        For i = 0 To (_porezi.Length / 5) - 1
            If _porezi((i * 5) + 4) <> 0 Then
                CM = New SqlCommand()
                If CN.State = ConnectionState.Open Then
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "rm_interni_prenos_pdv_add"
                        .Parameters.AddWithValue("@id_int_pr", _id_int_pr)
                        .Parameters.AddWithValue("@id_drupa", _porezi(i * 5))
                        selektuj_GrupeArt(_porezi(i * 5), Selekcija.po_id)
                        .Parameters.AddWithValue("@grupa_naziv", _gr_art_naziv)
                        .Parameters.AddWithValue("@grupa_marza", _porezi((i * 5) + 1))
                        .Parameters.AddWithValue("@int_pr_pdv", _porezi((i * 5) + 2))
                        .Parameters.AddWithValue("@int_pr_osnovica", _porezi((i * 5) + 3))
                        .Parameters.AddWithValue("@int_pr_iznos", _porezi((i * 5) + 4))
                        .ExecuteScalar()
                    End With
                End If
                CM.Dispose()
            End If
        Next
        CN.Close()
    End Sub

    Private Function saberi_pdv(ByVal _id_gr) As Single
        Dim i As Integer

        saberi_pdv = 0
        For i = 0 To dgStavke.Rows.Count - 2
            If dgStavke.Rows(i).Cells(13).Value = _id_gr Then _
                saberi_pdv += dgStavke.Rows(i).Cells(5).Value * dgStavke.Rows(i).Cells(9).Value
        Next
    End Function

    Private Function saberi_osnovice(ByVal _id_gr) As Single
        Dim i As Integer = 0

        saberi_osnovice = 0
        For i = 0 To dgStavke.Rows.Count - 2
            If dgStavke.Rows(i).Cells(13).Value = _id_gr Then _
                saberi_osnovice += dgStavke.Rows(i).Cells(10).Value / (1 + (dgStavke.Rows(i).Cells(9).Value / 100))
        Next
    End Function

    Private Sub snimi_stavku()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim i As Integer

        _id_int_pr = Nadji_id(Imena.tabele.rm_interni_prenos_head.ToString)

        CN.Open()
        For i = 0 To dgStavke.Rows.Count - 2
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_interni_prenos_stavka_add"
                    .Parameters.AddWithValue("@id_int_pr", _id_int_pr)
                    .Parameters.AddWithValue("@int_pr_st_rb", dgStavke.Rows(i).Cells(0).Value)
                    selektuj_artikl(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)
                    .Parameters.AddWithValue("@id_artikl", _id_artikl)
                    .Parameters.AddWithValue("@int_pr_st_roba_sifra", dgStavke.Rows(i).Cells(1).Value)
                    .Parameters.AddWithValue("@int_pr_st_roba", dgStavke.Rows(i).Cells(2).Value)
                    .Parameters.AddWithValue("@int_pr_st_kolicina", dgStavke.Rows(i).Cells(5).Value)
                    .Parameters.AddWithValue("@int_pr_st_nab_cena", CSng(dgStavke.Rows(i).Cells(6).Value))
                    .Parameters.AddWithValue("@int_pr_st_nab_vred", CSng(dgStavke.Rows(i).Cells(7).Value))
                    .Parameters.AddWithValue("@int_pr_st_pdv", dgStavke.Rows(i).Cells(9).Value)
                    .Parameters.AddWithValue("@int_pr_st_prod_cena", CSng(dgStavke.Rows(i).Cells(10).Value))
                    .Parameters.AddWithValue("@int_pr_st_pdv_iznos", CSng(dgStavke.Rows(i).Cells(11).Value))
                    .Parameters.AddWithValue("@int_pr_st_prod_vred", CSng(dgStavke.Rows(i).Cells(12).Value))
                    .Parameters.AddWithValue("@id_grup_artikla", CSng(dgStavke.Rows(i).Cells(13).Value))
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
        Next
        CN.Close()
    End Sub

    ' ovde ide nivelacija
    Private Sub snimi_cene()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim i As Integer

        CN.Open()
        For i = 0 To dgStavke.Rows.Count - 2
            If dgStavke.Rows(i).Cells(14).Value = 0 Then
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

                CM = New SqlCommand()
                If CN.State = ConnectionState.Open Then
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
                                .Parameters.AddWithValue("@id_magacin", magacinID)
                        End Select
                        .Parameters.AddWithValue("@cena_nab_zadnja", dgStavke.Rows(i).Cells(6).Value)
                        .Parameters.AddWithValue("@cena_vp1", dgStavke.Rows(i).Cells(6).Value)
                        .Parameters.AddWithValue("@cena_vp2", 0)
                        .Parameters.AddWithValue("@cena_vp3", 0)
                        .Parameters.AddWithValue("@cena_mp", CSng(dgStavke.Rows(i).Cells(10).Value))
                        .Parameters.AddWithValue("@pdv", CSng(dgStavke.Rows(i).Cells(9).Value))
                        .Parameters.AddWithValue("@rabat", 0) 'rabat(i))
                        .Parameters.AddWithValue("@marza", CSng(dgStavke.Rows(i).Cells(8).Value))
                        .ExecuteScalar()
                    End With
                End If
                CM.Dispose()
            End If
        Next
        CN.Close()
    End Sub

    Private Sub ispitaj_cene()
        'nivelacija
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim i, broj_stavki As Integer

        CN.Open()
        For i = 0 To dgStavke.Rows.Count - 2
            If dgStavke.Rows(i).Cells(14).Value <> 0 And dgStavke.Rows(i).Cells(6).Value <> dgStavke.Rows(i).Cells(14).Value Then
                _radi_se_nivelacija = True
                broj_stavki = i
                selektuj_artikl(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)
                niv_id_artikl.SetValue(_id_artikl, i)
                niv_kol.SetValue(CSng(dgStavke.Rows(i).Cells(5).Value), i)
                niv_stara_cena.SetValue(CSng(dgStavke.Rows(i).Cells(6).Value), i)
                niv_nova_cena.SetValue(CSng(dgStavke.Rows(i).Cells(14).Value), i)
                niv_pdv.SetValue(dgStavke.Rows(i).Cells(9).Value, i)
                niv_stari_iznos_pdv.SetValue(CSng(dgStavke.Rows(i).Cells(5).Value * dgStavke.Rows(i).Cells(6).Value * dgStavke.Rows(i).Cells(9).Value / 100), i)
                niv_novi_iznos_pdv.SetValue(CSng(dgStavke.Rows(i).Cells(5).Value * dgStavke.Rows(i).Cells(14).Value * dgStavke.Rows(i).Cells(9).Value / 100), i)
            End If
        Next

        If _radi_se_nivelacija Then

            nivelacija_snimi_head(broj_stavki)
            nivelacija_snimi_pdv()
            nivelacija_snimi_stavku(broj_stavki)

            unesi_dnevni_promet_head(Today.Date, Now, magacinID, magacinID, 0, ID_vrsta_dokumenta, Nadji_id(Imena.tabele.rm_nivelacije_head.ToString), _
                           txtBroj.Text, txtRazlikauceni.Text, 0, 1, 0, vrsta_promene.unos)

            _id_dnevni_promet = Nadji_id(Imena.tabele.rm_dnevni_promet_head.ToString)

            For i = 0 To broj_stavki
                unesi_dnevni_promet_stavka(_id_dnevni_promet, magacinID, niv_id_artikl(i), niv_kol(i), 0, _
                        niv_nova_cena(i) - niv_stara_cena(i), niv_pdv(i), True, True)
            Next

        End If
    End Sub
#End Region

#Region "Snimi automatsku nivelaciju"

    Private Sub nivelacija_snimi_head(ByVal br_stavki As Integer)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim i As Integer

        Dim stara_vrednost As Single = 0
        Dim nova_vrednost As Single = 0
        Dim razlika_uceni As Single = 0
        Dim stari_iznos_pdv As Single = 0
        Dim novi_iznos_pdv As Single = 0
        Dim razlika_pdv As Single = 0

        For i = 0 To br_stavki
            stara_vrednost += niv_kol(i) * niv_stara_cena(i)
            nova_vrednost += niv_kol(i) * niv_nova_cena(i)
            razlika_uceni += nova_vrednost - stara_vrednost

            stari_iznos_pdv += niv_stari_iznos_pdv(i)
            novi_iznos_pdv += niv_novi_iznos_pdv(i)
            razlika_pdv += novi_iznos_pdv - stari_iznos_pdv
        Next

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_nivelacije_head_add"
                .Parameters.AddWithValue("@id_magacin", magacinID)
                .Parameters.AddWithValue("@broj", Nadji_rb(Imena.tabele.rm_nivelacije_head.ToString, 1))
                .Parameters.AddWithValue("@datum", dateKalkulacija.Value.Date)
                .Parameters.AddWithValue("@stara_vrednost", stara_vrednost)
                .Parameters.AddWithValue("@nova_vrednost", nova_vrednost)
                .Parameters.AddWithValue("@razlika_uceni", razlika_uceni)
                .Parameters.AddWithValue("@stari_iznos_pdv", stari_iznos_pdv)
                .Parameters.AddWithValue("@novi_iznos_pdv", novi_iznos_pdv)
                .Parameters.AddWithValue("@razlika_pdv", razlika_pdv)
                .Parameters.AddWithValue("@unesena", 0)
                .Parameters.AddWithValue("@automatska", 1)
                'selektuj_interni_prenos(txtBroj.Text, Selekcija.po_sifri)
                .Parameters.AddWithValue("@vezni_dokument_id", _id_int_pr)
                .Parameters.AddWithValue("@vezni_dokument_broj", txtBroj.Text)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub nivelacija_snimi_pdv()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim _porezi() As Single
        Dim i As Integer = 0

        CN.Open()
        CM = New SqlCommand()

        _porezi = New Single() {}

        If CN.State = ConnectionState.Open Then
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
                If Not IsDBNull(DR.Item("pdv_stopa")) Then _porezi.SetValue(CSng(DR.Item("pdv_stopa")), i * 3)
                _porezi.SetValue(saberi_osnovice(DR.Item("pdv_stopa")), (i * 3) + 1)
                _porezi.SetValue(saberi_pdv(DR.Item("pdv_stopa")), (i * 3) + 2)
                i += 1
            Loop
            DR.Close()
        End If
        CM.Dispose()

        _id_nivelacije = Nadji_id(Imena.tabele.rm_nivelacije_head.ToString)

        For i = 0 To (_porezi.Length / 3) - 1
            If _porezi((i * 3) + 1) <> 0 Then
                CM = New SqlCommand()
                If CN.State = ConnectionState.Open Then
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "rm_nivelacija_pdv_add"
                        .Parameters.AddWithValue("@id_nivelacije", _id_nivelacije)
                        .Parameters.AddWithValue("@niv_pdv", _porezi(i * 3))
                        .Parameters.AddWithValue("@niv_osnovica", _porezi((i * 3) + 1))
                        .Parameters.AddWithValue("@niv_iznos", _porezi((i * 3) + 2))
                        .ExecuteScalar()
                    End With
                End If
                CM.Dispose()
            End If
        Next
        CN.Close()
    End Sub

    Private Function nivelacija_saberi_pdv(ByVal _stopa) As Single
        Dim i As Integer

        nivelacija_saberi_pdv = 0
        For i = 0 To dgStavke.Rows.Count - 2
            If dgStavke.Rows(i).Cells(13).Value = _stopa Then _
                nivelacija_saberi_pdv += dgStavke.Rows(i).Cells(5).Value * dgStavke.Rows(i).Cells(8).Value * (dgStavke.Rows(i).Cells(13).Value / 100)
        Next
    End Function

    Private Function nivelacija_saberi_osnovice(ByVal _stopa) As Single
        Dim i As Integer

        nivelacija_saberi_osnovice = 0
        For i = 0 To dgStavke.Rows.Count - 2
            If dgStavke.Rows(i).Cells(13).Value = _stopa Then _
                nivelacija_saberi_osnovice += dgStavke.Rows(i).Cells(5).Value * dgStavke.Rows(i).Cells(8).Value / (1 + (dgStavke.Rows(i).Cells(13).Value / 100))
        Next
    End Function

    Private Sub nivelacija_snimi_stavku(ByVal br_stavki As Integer)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim i As Integer

        _id_nivelacije = Nadji_id(Imena.tabele.rm_nivelacije_head.ToString)

        CN.Open()
        For i = 0 To br_stavki
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_nivelacije_stavka_add"
                    .Parameters.AddWithValue("@id_nivelacija", _id_nivelacije) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                    .Parameters.AddWithValue("@rb", dgStavke.Rows(i).Cells(0).Value)
                    selektuj_artikl(CInt(niv_id_artikl(br_stavki)), Selekcija.po_id)
                    .Parameters.AddWithValue("@id_artikl", _id_artikl)
                    .Parameters.AddWithValue("@roba_sifra", _artikl_sifra)
                    .Parameters.AddWithValue("@roba_naziv", _artikl_naziv)
                    .Parameters.AddWithValue("@kolicina", niv_kol(br_stavki))
                    .Parameters.AddWithValue("@stara_cena", niv_stara_cena(br_stavki))
                    .Parameters.AddWithValue("@stara_vrednost", niv_stara_cena(br_stavki) * niv_kol(br_stavki))
                    .Parameters.AddWithValue("@nova_cena", niv_nova_cena(br_stavki))
                    .Parameters.AddWithValue("@nova_vrednost", niv_nova_cena(br_stavki) * niv_kol(br_stavki))
                    .Parameters.AddWithValue("@razlika_cena", niv_kol(br_stavki) * (niv_nova_cena(br_stavki) - niv_stara_cena(br_stavki)))
                    selektuj_pdv(_artikl_id_pdv, Selekcija.po_id)
                    .Parameters.AddWithValue("@stari_pdv", _pdv_stopa)
                    .Parameters.AddWithValue("@stari_iznos_pdv", niv_stari_iznos_pdv(br_stavki))
                    .Parameters.AddWithValue("@novi_pdv", _pdv_stopa)
                    .Parameters.AddWithValue("@novi_iznos_pdv", niv_novi_iznos_pdv(br_stavki))
                    .Parameters.AddWithValue("@razlika_pdv", niv_kol(br_stavki) * (niv_novi_iznos_pdv(br_stavki) - niv_stari_iznos_pdv(br_stavki)))
                    .ExecuteScalar()
                End With
            End If
            CM.Dispose()
        Next
        CN.Close()
    End Sub
#End Region

#Region "Zakljuci"
    Private Sub btnZakljuci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZakljuci.Click
        _id_oj = 0
        _id_partner = 0

        prebaci_u_magacin_promene(_id_magacin, ID_vrsta_dokumenta, txtBroj.Text)
        prebaci_u_magacin_promene_stavka(_id_dnevni_promet)
        zakljuci_dokument()
        labProknjizen.Visible = True

    End Sub

    Private Sub zakljuci_dokument()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        '_id_kalkulacija = Nadji_id(Imena.tabele.rm_kalkulacija_head.ToString)

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_interni_prenos_zakljuci"
                .Parameters.AddWithValue("@id_int_pr", _id_int_pr)
                .Parameters.AddWithValue("@int_pr_zakljucena", 1)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
        _unesen = True
        zatvori_formu()
    End Sub
#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub cmbMagacin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMagacin.SelectedIndexChanged
        If Not _pocetak Then
            If cmbMagacin.Text <> "" Then
                _izabran_magacin = True
                selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)
                magacinID = _id_magacin
            End If
        End If
        kontrole()
    End Sub

    Private Sub kontrole()
        Select Case _izabran_magacin
            Case True
                tlbMain_sub.Enabled = True
                btnSnimi.Enabled = True
            Case False
                tlbMain_sub.Enabled = False
                btnSnimi.Enabled = False
        End Select
    End Sub

    Private Sub txtIznosCena_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIznosCena.TextChanged
        If Not jeste_broj(txtIznosCena.Text) Then
            txtIznosCena.BackColor = Color.LavenderBlush
            txtIznosCena.Select()
        Else
            txtIznosCena.BackColor = Color.GhostWhite
        End If
    End Sub

    Private Sub txtIznosRabat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIznosRabat.TextChanged
        If Not jeste_broj(txtIznosCena.Text) Then
            txtIznosRabat.BackColor = Color.LavenderBlush
            txtIznosRabat.Select()
        Else
            txtIznosRabat.BackColor = Color.GhostWhite
        End If
    End Sub

    Private Sub txtRazlikauceni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRazlikauceni.TextChanged
        If Not jeste_broj(txtIznosCena.Text) Then
            txtRazlikauceni.BackColor = Color.LavenderBlush
            txtRazlikauceni.Select()
        Else
            txtRazlikauceni.BackColor = Color.GhostWhite
        End If
    End Sub

    Private Sub txtOsnovica_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOsnovica.TextChanged
        If Not jeste_broj(txtIznosCena.Text) Then
            txtOsnovica.BackColor = Color.LavenderBlush
            txtOsnovica.Select()
        Else
            txtOsnovica.BackColor = Color.GhostWhite
        End If
    End Sub

    Private Sub txtIznosPdv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIznosPdv.TextChanged
        If Not jeste_broj(txtIznosCena.Text) Then
            txtIznosPdv.BackColor = Color.LavenderBlush
            txtIznosPdv.Select()
        Else
            txtIznosPdv.BackColor = Color.GhostWhite
        End If
    End Sub

    Private Sub txtIznosZanaplatu_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIznosZanaplatu.TextChanged
        If Not jeste_broj(txtIznosCena.Text) Then
            txtIznosZanaplatu.BackColor = Color.LavenderBlush
            txtIznosZanaplatu.Select()
        Else
            txtIznosZanaplatu.BackColor = Color.GhostWhite
        End If
    End Sub




End Class
