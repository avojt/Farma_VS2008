Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class cntNivelacija_edit

#Region "dekleracija"
    Private kol As Single = 1
    Private cena As Single = 0
    'Private mp_cena As Single = 0
    Private c_cena_nab As Single = 0
    Private c_cena_vp As Single = 0
    Private pdv As Single = 1
    Private c_pdv As Integer = 18
    'Private rabat As Single = 0
    Private c_rabat As Integer = 0
    Private c_JM As String = ""
    Private c_Grupa As String = ""
    'Private marza As Single = 0
    Private c_marza As Integer = 0
    Private lSifra As String = ""
    Private lNaziv As String = ""
    Private lKol As Single = 0
    Private lCena As Single = 0
    Private lId As Integer = 0

    Private stara_cena As Single = 0
    Private nova_cena As Single = 0
    Private stara_vred As Single = 0
    Private nova_vred As Single = 0
    Private razlika_uceni As Single = 0
    Private stari_pdv As Integer = 1
    Private novi_pdv As Integer = 1
    Private stara_vred_pdv As Single = 0
    Private nova_vred_pdv As Single = 0
    Private razlika_pdv As Single = 0
    Private sifra As String = ""
    Private naziv As String = ""
    Private indeks As Integer = 0
    Private broj_decimala() As Integer
    Private id_predhodnog_stanja As Integer
    Private id_predhodnog_stanja_stavka As Integer
    Private rabat() As Single
    Private mp_cena() As Single
    Private marza() As Single

    Private _pocetak As Boolean = True
    Private _citam_stavke As Boolean = True
    Private _promenjena_marza As Boolean = False
    Private _promenjena_nabav_cena As Boolean = False
    Private _prod_cena_promenjena As Boolean = False
    Private _popunjavam_robu As Boolean = False
    Private _izabran_magacin As Boolean = False
    Private magacinID As Integer = 0
    Private magacinSifra As String = ""

    Private upit As String = ""
    Private upit_sifra As String = ""
    Private upit_lek As String = ""

    Shared sql_start As String = _
                    "SELECT DISTINCT " & _
                          "TOP (100) PERCENT dbo.rm_artikli.artikl_sifra, dbo.rm_artikli.artikl_naziv, " & _
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

    Private Sub cntNivelacija_edit_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'If _ima_promena Then
        '    If MsgBox("Načinili ste promene. Dali želite da ih snimite?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '        'snimi()
        '    End If
        'End If

        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntNivelacija
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _mSpliter.SplitterDistance = 210

        Dim myControl1 As New cntNivelacija_search
        myControl1.Parent = _mSpliter.Panel1
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        _labHead.Text = Ispisi_label() + " : nivelacije" + " - pretraga"
        cntMeniObrada_ostalo.podesi_boje_linkova(_mPanNivelacija_meni)
        _mLinkNivelacija_search.BackColor = Color.GhostWhite
        _mLinkNivelacija_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub cntNivelacija_edit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
        labLager.Text = "--"

        txtBroj.Text = _nivelacije_broj
        txtStaraVred.Text = _nivelacije_stara_vrednost
        txtNovaVred.Text = _nivelacije_nova_vrednost
        txtRazlikauceni.Text = _nivelacije_razlika_uceni
        txtStariPDV.Text = _nivelacije_stari_iznos_pdv
        txtNoviPDV.Text = _nivelacije_novi_iznos_pdv
        txtRazlikaPDV.Text = _nivelacije_razlika_pdv

        dateKalkulacija.Value = _nivelacije_datum

        rabat = New Single() {}
        mp_cena = New Single() {}
        marza = New Single() {}

        ReDim rabat(100)
        ReDim mp_cena(100)
        ReDim marza(100)

        popuni_stavke()

        labProknjizen.Visible = False

        _pocetak = False
        _izabran_magacin = True
        kontrole()

        If _nivelacije_unesena Then
            labProknjizen.Visible = True
            zatvori_formu()
        Else
            labProknjizen.Visible = False
        End If

        If _nivelacije_automatska Then
            labProknjizen.Visible = True
            labProknjizen.Text = "AUTOMATSKA NIVELACIJA - NE MOŽETE JE MENJATI!!!"
            zatvori_formu()
        Else
            labProknjizen.Visible = False
        End If


    End Sub

#Region "Grid 1"

    Private Sub dgStavke_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgStavke.CellEndEdit
        If e.ColumnIndex = 5 And e.RowIndex = indeks Then
            If IsNothing(dgStavke.Rows(e.RowIndex).Cells(5).Value) Then
                Beep()
                MsgBox("Količina mora biti unešena!", MsgBoxStyle.OkOnly)
                dgStavke.Rows(e.RowIndex).Cells(5).Style.BackColor = Color.Red
                'dgStavke.Select()
                'dgStavke.Rows(e.RowIndex).Cells(5).Selected = True
            Else
                dgStavke.Rows(e.RowIndex).Cells(5).Style.BackColor = Color.GhostWhite
                dgStavke.Select()
                dgStavke.Rows(indeks).Cells(8).Selected = True
            End If
        End If
    End Sub

    Private Sub dgStavke_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgStavke.KeyPress
        If e.KeyChar = Chr(13) Then
            If dgStavke.CurrentRow.Cells.IndexOf(dgStavke.CurrentCell) = 5 Then
                dgStavke.Select()
                dgStavke.Rows(indeks).Cells(13).Selected = True
            Else
                dgStavke.Select()
                Dim ind As Integer = dgStavke.CurrentRow.Cells.IndexOf(dgStavke.CurrentCell) + 1
                If ind < 15 Then
                    If ind = 14 Then
                        dgStavke.Rows(indeks + 1).Cells(2).Selected = True
                        kol = 1
                        cena = 0
                        'mp_cena = 0
                        pdv = 1
                        'rabat = 0
                        'marza = 0

                    Else
                        dgStavke.Rows(indeks).Cells(13).Selected = True
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
                    End Select

                    If Not _popunjavam_robu Then
                        If Not IsNothing(.Rows(e.RowIndex).Cells(5).Value) Then
                            If .Rows(e.RowIndex).Cells(5).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(5).Value.ToString) Then
                                kol = CDec(.Rows(e.RowIndex).Cells(5).Value)
                            Else
                                kol = 1
                            End If
                        End If
                        If Not IsNothing(.Rows(e.RowIndex).Cells(6).Value) Then
                            If .Rows(e.RowIndex).Cells(6).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(6).Value.ToString) Then
                                stara_cena = CDec(.Rows(e.RowIndex).Cells(6).Value)
                            Else
                                stara_cena = 0
                            End If
                        End If
                        If Not IsNothing(.Rows(e.RowIndex).Cells(8).Value) Then
                            If .Rows(e.RowIndex).Cells(8).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(8).Value.ToString) Then
                                nova_cena = CDec(.Rows(e.RowIndex).Cells(8).Value)
                            Else
                                nova_cena = 0
                            End If
                        End If

                        If Not IsNothing(.Rows(e.RowIndex).Cells(11).Value) Then
                            If .Rows(e.RowIndex).Cells(11).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(11).Value.ToString) Then
                                stari_pdv = CDec(.Rows(e.RowIndex).Cells(11).Value)
                            Else
                                stari_pdv = 1
                            End If
                        End If

                        If Not IsNothing(.Rows(e.RowIndex).Cells(13).Value) Then
                            If .Rows(e.RowIndex).Cells(13).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(13).Value.ToString) Then
                                novi_pdv = CDec(.Rows(e.RowIndex).Cells(13).Value)
                            Else
                                novi_pdv = 1
                            End If
                        End If
                    End If

                    stara_vred = kol * stara_cena
                    nova_vred = kol * nova_cena

                    If nova_vred - stara_vred = 0 And stari_pdv = novi_pdv Then
                        stara_vred_pdv = 0
                        nova_vred_pdv = 0
                    Else
                        If nova_vred - stara_vred = 0 And stari_pdv <> novi_pdv Then
                            stara_vred_pdv = stara_vred * stari_pdv / 100
                            nova_vred_pdv = stara_vred * novi_pdv / 100
                        Else
                            If nova_vred - stara_vred <> 0 And stari_pdv = novi_pdv Then
                                stara_vred_pdv = stara_vred * stari_pdv / 100
                                nova_vred_pdv = nova_vred * stari_pdv / 100
                            Else
                                If nova_vred - stara_vred <> 0 And stari_pdv <> novi_pdv Then
                                    stara_vred_pdv = stara_vred * stari_pdv / 100
                                    nova_vred_pdv = nova_vred * novi_pdv / 100
                                End If
                            End If
                        End If
                    End If

                    .Rows(e.RowIndex).Cells(7).Style.Format = "N2"
                    .Rows(e.RowIndex).Cells(8).Style.Format = "N2"
                    .Rows(e.RowIndex).Cells(9).Style.Format = "N2"
                    .Rows(e.RowIndex).Cells(10).Style.Format = "N2"
                    .Rows(e.RowIndex).Cells(12).Style.Format = "N2"
                    .Rows(e.RowIndex).Cells(14).Style.Format = "N2"
                    .Rows(e.RowIndex).Cells(15).Style.Format = "N2"
                    .Rows(e.RowIndex).Cells(7).Value = Format(stara_vred, 2)
                    .Rows(e.RowIndex).Cells(8).Value = Format(.Rows(e.RowIndex).Cells(8).Value, 2)
                    .Rows(e.RowIndex).Cells(9).Value = Format(nova_vred, 2)
                    .Rows(e.RowIndex).Cells(10).Value = Format(nova_vred - stara_vred, 2)
                    .Rows(e.RowIndex).Cells(12).Value = Format(stara_vred_pdv, 2)
                    .Rows(e.RowIndex).Cells(14).Value = Format(nova_vred_pdv, 2)
                    .Rows(e.RowIndex).Cells(15).Value = Format(nova_vred_pdv - stara_vred_pdv, 2)

                    If RTrim(magacinSifra) = 1202 Then
                        .Rows(e.RowIndex).Cells(5).Style.Format = "N3"
                        .Rows(e.RowIndex).Cells(5).Value = Format(.Rows(e.RowIndex).Cells(5).Value, 3)
                    Else
                        .Rows(e.RowIndex).Cells(5).Style.Format = "N0"
                        .Rows(e.RowIndex).Cells(5).Value = CInt(.Rows(e.RowIndex).Cells(5).Value)
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End With

        End If
        preracunaj()

    End Sub

    Private Sub dgStavke_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgStavke.RowsRemoved
        preracunaj()
        If Not _pocetak Then indeks = dgStavke.Rows.Count - 2
    End Sub

#End Region

    Private Sub lvLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLista.DoubleClick
        If _novi_artikl And _prod_cena_promenjena Then Exit Sub

        redni_broj()
        '.Rows(e.RowIndex).Cells(0).Value = e.RowIndex + 1
        With dgStavke
            If Not IsNothing(lvLista.Items(0).ToString) Then
                If lvLista.Items(0).ToString <> "" Then
                    _popunjavam_robu = True
                    popuni_robu(RTrim(lvLista.SelectedItems.Item(0).SubItems(0).Text))
                    .Rows(indeks).Cells(1).Value = sifra
                    .Rows(indeks).Cells(2).Value = naziv
                    .Rows(indeks).Cells(3).Value = c_JM
                    .Rows(indeks).Cells(4).Value = c_Grupa
                    .Rows(indeks).Cells(5).Value = 0
                    .Rows(indeks).Cells(6).Value = c_cena_nab
                    .Rows(indeks).Cells(7).Value = 0
                    .Rows(indeks).Cells(8).Value = 0 ' stara_cena
                    .Rows(indeks).Cells(9).Value = 0
                    .Rows(indeks).Cells(10).Value = 0
                    If c_pdv <> 1 Then
                        .Rows(indeks).Cells(11).Value = c_pdv
                    Else
                        .Rows(indeks).Cells(11).Value = 0
                    End If
                    .Rows(indeks).Cells(12).Value = 0
                    .Rows(indeks).Cells(13).Value = c_pdv ' c_cena_vp ' trenutna_cena
                    .Rows(indeks).Cells(14).Value = 0 ' c_cena_vp * c_pdv / 100 ' trenutna_cena * c_pdv / 100
                    .Rows(indeks).Cells(15).Value = 0 'c_cena_vp * CSng(dgStavke.Rows(indeks).Cells(5).Value) ' trenutna_cena * CSng(dgStavke.Rows(indeks).Cells(3).Value)
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
    End Sub

    Private Sub btnNoviArtkl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoviArtkl.Click
        Dim mForm As New cntArtikliUnos
        mForm.Show()
    End Sub

    Private Sub btnNoviPartner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoviPartner.Click
        'Dim mForm As New frmPartneriUnos
        'mForm.Show()
    End Sub

    Private Sub popuni_magacine()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbMagacin.Text = ""
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
            selektuj_magacin(_nivelacije_id_magacin, Selekcija.po_id)
            cmbMagacin.SelectedText = _magacin_naziv
            magacinSifra = _magacin_sifra
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
        c_Grupa = ""
        c_cena_nab = 0
        c_cena_vp = 0
        'trenutna_kolicina = 0
        c_pdv = 1
        c_rabat = 0
        c_marza = 0

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli where dbo.rm_artikli.artikl_sifra = '" & RTrim(_roba) & "'"
                DR = .ExecuteReader
            End With

            'Dim id As Integer = 0
            Dim id_pdv As Integer = 0
            Dim id_grupa As Integer = 0
            Dim id_jm As Integer = 0
            Do While DR.Read
                If Not IsDBNull(DR.Item("id_artikl")) Then lId = DR.Item("id_artikl")
                If Not IsDBNull(DR.Item("artikl_naziv")) Then naziv = DR.Item("artikl_naziv")
                If Not IsDBNull(DR.Item("id_grup_artikla")) Then id_grupa = DR.Item("id_grup_artikla")
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
                    broj_decimala.SetValue(DR.Item("jm_br_decimala"), dgStavke.Rows.Count - 2)
                Else
                    broj_decimala.SetValue(3, dgStavke.Rows.Count - 2)
                End If
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
                If Not IsDBNull(DR.Item("pdv")) Then c_pdv = DR.Item("pdv")
                If Not IsDBNull(DR.Item("rabat")) Then rabat.SetValue(CSng(DR.Item("rabat")), indeks)
                'If Not IsDBNull(DR.Item("marza")) Then marza.SetValue(CSng(DR.Item("marza")), i)
                If Not IsDBNull(DR.Item("cena_mp")) Then mp_cena.SetValue(CSng(DR.Item("cena_mp")), indeks)
            Loop
            DR.Close()
            CM.Dispose()

            'If id_cene = 0 Then
            '    MsgBox("Traženom artiklu u ovom magacinu do sada nije zadata cena.", MsgBoxStyle.OkOnly)
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_artikl_grupa.* from dbo.app_artikl_grupa where id_grup_artikla = " & id_grupa '& " and id_magacin = " & magacinID
                DR = .ExecuteReader
            End With
            Do While DR.Read
                If Not IsDBNull(DR.Item("gr_artikla_skraceno")) Then c_Grupa = RTrim(DR.Item("gr_artikla_skraceno"))
                If Not IsDBNull(DR.Item("gr_artikla_pdv")) Then c_pdv = DR.Item("gr_artikla_pdv")
                If Not IsDBNull(DR.Item("gr_artikla_marza")) Then c_marza = DR.Item("gr_artikla_marza")
                If Not IsDBNull(DR.Item("gr_artikla_marza")) Then marza.SetValue(CSng(DR.Item("gr_artikla_marza")), indeks)
            Loop
            DR.Close()
            CM.Dispose()
            'End If

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
        'If _unesen Then
        panHeader.Enabled = False
        Panel1.Enabled = False
        cmbMagacin.Enabled = False

        dgStavke.AllowUserToAddRows = False
        dgStavke.Enabled = False
        lvLista.Enabled = False

        btnSnimi.Enabled = False
        'btnZakljuci.Enabled = False

        txtBroj.Enabled = False
        txtStaraVred.Enabled = False
        txtNovaVred.Enabled = False
        txtRazlikauceni.Enabled = False
        txtStariPDV.Enabled = False
        txtNoviPDV.Enabled = False
        txtRazlikaPDV.Enabled = False

        'End If
    End Sub

    Private Sub preracunaj()
        Dim i As Integer

        stara_vred = 0
        nova_vred = 0
        razlika_uceni = 0
        stara_vred_pdv = 0
        nova_vred_pdv = 0
        razlika_pdv = 0

        Try
            For i = 0 To dgStavke.Rows.Count - 2
                stara_vred += CDec(dgStavke.Rows(i).Cells(7).Value)
                dgStavke.Rows(i).Cells(9).Style.Format = "N2"
                nova_vred += CDec(dgStavke.Rows(i).Cells(9).Value)
                razlika_uceni += CDec(dgStavke.Rows(i).Cells(10).Value)

                stara_vred_pdv += CDec(dgStavke.Rows(i).Cells(12).Value)
                nova_vred_pdv += CDec(dgStavke.Rows(i).Cells(14).Value)
                razlika_pdv += CDec(dgStavke.Rows(i).Cells(15).Value)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'If Not _unesen Then
        txtStaraVred.Text = Format(stara_vred, 2)
        txtNovaVred.Text = Format(nova_vred, 2)
        txtRazlikauceni.Text = Format(razlika_uceni, 2)

        txtStariPDV.Text = Format(stara_vred_pdv, 2)
        txtNoviPDV.Text = Format(nova_vred_pdv, 2)
        txtRazlikaPDV.Text = Format(razlika_pdv, 2)
        'End If

    End Sub


#Region "Snimi"
    Private Sub btnSnimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSnimi.Click
        snimi_head()
        snimi_pdv()
        snimi_stavku()
        snimi_cene()

        unesi_dnevni_promet_head(Today.Date, Now, _id_magacin, _id_magacin, 0, ID_vrsta_dokumenta, _id_nivelacije, _
                       txtBroj.Text, txtRazlikauceni.Text, 0, 0, 0, vrsta_promene.editovanje)

        Dim i As Integer

        For i = 0 To dgStavke.Rows.Count - 2
            selektuj_artikl(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)

            'OVDE SAMO MENJA
            promeni_dnevni_promet_stavka(_id_dnevni_promet, _id_magacin, _id_artikl, dgStavke.Rows(i).Cells(5).Value, 0, _
                    CSng(dgStavke.Rows(i).Cells(8).Value), dgStavke.Rows(i).Cells(14).Value, True, True)
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
                .CommandText = "rm_nivelacije_head_update"
                .Parameters.AddWithValue("@id_nivelacija", _id_nivelacije)
                .Parameters.AddWithValue("@id_magacin", _id_magacin)
                .Parameters.AddWithValue("@broj", txtBroj.Text)
                .Parameters.AddWithValue("@datum", dateKalkulacija.Value.Date)
                .Parameters.AddWithValue("@stara_vrednost", CDec(txtStaraVred.Text))
                .Parameters.AddWithValue("@nova_vrednost", CDec(txtNovaVred.Text))
                .Parameters.AddWithValue("@razlika_uceni", CDec(txtRazlikauceni.Text))
                .Parameters.AddWithValue("@stari_iznos_pdv", CDec(txtStariPDV.Text))
                .Parameters.AddWithValue("@novi_iznos_pdv", CDec(txtNoviPDV.Text))
                .Parameters.AddWithValue("@razlika_pdv", CDec(txtRazlikaPDV.Text))
                .Parameters.AddWithValue("@unesena", _nivelacije_unesena)
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
                .CommandText = "rm_nivelacije_pdv_delete"
                .Parameters.AddWithValue("@id_nivelacije", _id_nivelacije)
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
                If Not IsDBNull(DR.Item("pdv_stopa")) Then _porezi.SetValue(CSng(DR.Item("pdv_stopa")), i * 3)
                _porezi.SetValue(saberi_osnovice(DR.Item("pdv_stopa")), (i * 3) + 1)
                _porezi.SetValue(saberi_pdv(DR.Item("pdv_stopa")), (i * 3) + 2)
                i += 1
            Loop
            DR.Close()
        End If
        CM.Dispose()

        '_id_nivelacije = Nadji_id(Imena.tabele.rm_nivelacije_head.ToString)

        For i = 0 To (_porezi.Length / 3) - 1
            If _porezi((i * 3) + 1) <> 0 Then
                CM = New SqlCommand()
                If CN.State = ConnectionState.Open Then
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "rm_nivelacije_pdv_add"
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

    Private Function saberi_pdv(ByVal _stopa) As Single
        Dim i As Integer

        saberi_pdv = 0
        For i = 0 To dgStavke.Rows.Count - 2
            If dgStavke.Rows(i).Cells(13).Value = _stopa Then saberi_pdv += dgStavke.Rows(i).Cells(5).Value * dgStavke.Rows(i).Cells(8).Value * (dgStavke.Rows(i).Cells(13).Value / 100)
        Next
    End Function

    Private Function saberi_osnovice(ByVal _stopa) As Single
        Dim i As Integer

        saberi_osnovice = 0
        For i = 0 To dgStavke.Rows.Count - 2
            If dgStavke.Rows(i).Cells(13).Value = _stopa Then saberi_osnovice += dgStavke.Rows(i).Cells(5).Value * dgStavke.Rows(i).Cells(8).Value / (1 + (dgStavke.Rows(i).Cells(13).Value / 100))
        Next
    End Function

    Private Sub snimi_stavku()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim i, n As Integer

        CN.Open()
        If _id_nivelacije_stavke.Length > dgStavke.Rows.Count - 1 Then
            n = _id_nivelacije_stavke.Length - 1
        Else
            n = dgStavke.Rows.Count - 2
        End If
        For i = 0 To n
            If (i <= dgStavke.Rows.Count - 2 Or Not _id_nivelacije_stavke.Length > dgStavke.Rows.Count - 1) Or _id_nivelacije_stavke.Length = 0 Then
                If i > _id_nivelacije_stavke.Length - 1 Then '_id_racun_stavka(i) = 0 Then
                    CM = New SqlCommand()
                    If CN.State = ConnectionState.Open Then
                        With CM
                            .Connection = CN
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "rm_nivelacije_stavka_add"
                            .Parameters.AddWithValue("@id_nivelacija", _id_nivelacije) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                            .Parameters.AddWithValue("@rb", dgStavke.Rows(i).Cells(0).Value)
                            selektuj_artikl(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)
                            .Parameters.AddWithValue("@id_artikl", _id_artikl)
                            .Parameters.AddWithValue("@roba_sifra", dgStavke.Rows(i).Cells(1).Value)
                            .Parameters.AddWithValue("@roba_naziv", dgStavke.Rows(i).Cells(2).Value)
                            .Parameters.AddWithValue("@kolicina", dgStavke.Rows(i).Cells(5).Value)
                            .Parameters.AddWithValue("@stara_cena", CSng(dgStavke.Rows(i).Cells(6).Value))
                            .Parameters.AddWithValue("@stara_vrednost", CSng(dgStavke.Rows(i).Cells(7).Value))
                            .Parameters.AddWithValue("@nova_cena", CSng(dgStavke.Rows(i).Cells(8).Value))
                            .Parameters.AddWithValue("@nova_vrednost", CSng(dgStavke.Rows(i).Cells(9).Value))
                            .Parameters.AddWithValue("@razlika_cena", CSng(dgStavke.Rows(i).Cells(10).Value))
                            .Parameters.AddWithValue("@stari_pdv", CSng(dgStavke.Rows(i).Cells(11).Value))
                            .Parameters.AddWithValue("@stari_iznos_pdv", dgStavke.Rows(i).Cells(12).Value)
                            .Parameters.AddWithValue("@novi_pdv", CSng(dgStavke.Rows(i).Cells(13).Value))
                            .Parameters.AddWithValue("@novi_iznos_pdv", CSng(dgStavke.Rows(i).Cells(14).Value))
                            .Parameters.AddWithValue("@razlika_pdv", CSng(dgStavke.Rows(i).Cells(15).Value))
                            .ExecuteScalar()
                        End With
                    End If
                    CM.Dispose()
                Else
                    If CN.State = ConnectionState.Open Then
                        CM = New SqlCommand()
                        With CM
                            .Connection = CN
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "rm_nivelacije_stavka_update"
                            .Parameters.AddWithValue("@id_nivelacija_stavka", _id_nivelacije_stavke(i)) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                            .Parameters.AddWithValue("@rb", dgStavke.Rows(i).Cells(0).Value)
                            selektuj_artikl(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)
                            .Parameters.AddWithValue("@id_artikl", _id_artikl)
                            .Parameters.AddWithValue("@roba_sifra", dgStavke.Rows(i).Cells(1).Value)
                            .Parameters.AddWithValue("@roba_naziv", dgStavke.Rows(i).Cells(2).Value)
                            .Parameters.AddWithValue("@kolicina", dgStavke.Rows(i).Cells(5).Value)
                            .Parameters.AddWithValue("@stara_cena", CSng(dgStavke.Rows(i).Cells(6).Value))
                            .Parameters.AddWithValue("@stara_vrednost", CSng(dgStavke.Rows(i).Cells(7).Value))
                            .Parameters.AddWithValue("@nova_cena", CSng(dgStavke.Rows(i).Cells(8).Value))
                            .Parameters.AddWithValue("@nova_vrednost", CSng(dgStavke.Rows(i).Cells(9).Value))
                            .Parameters.AddWithValue("@razlika_cena", CSng(dgStavke.Rows(i).Cells(10).Value))
                            .Parameters.AddWithValue("@stari_pdv", CSng(dgStavke.Rows(i).Cells(11).Value))
                            .Parameters.AddWithValue("@stari_iznos_pdv", dgStavke.Rows(i).Cells(12).Value)
                            .Parameters.AddWithValue("@novi_pdv", CSng(dgStavke.Rows(i).Cells(13).Value))
                            .Parameters.AddWithValue("@novi_iznos_pdv", CSng(dgStavke.Rows(i).Cells(14).Value))
                            .Parameters.AddWithValue("@razlika_pdv", CSng(dgStavke.Rows(i).Cells(15).Value))
                            .ExecuteScalar()
                        End With
                        CM.Dispose()
                    End If
                End If
            Else
                CM = New SqlCommand()
                If CN.State = ConnectionState.Open Then
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "rm_nivelacije_stavka_delete"
                        .Parameters.AddWithValue("@id_nivelacija_stavka", _id_nivelacije_stavke(i))
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

        For i = 0 To dgStavke.Rows.Count - 2
            CN.Open()

            selektuj_artikl(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_artikli_cene.* from dbo.rm_artikli_cene where id_artikl = " & _id_artikl & " and id_magacin = " & _id_magacin
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
                            'selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)
                            .Parameters.AddWithValue("@id_magacin", magacinID)
                    End Select
                    .Parameters.AddWithValue("@cena_nab_zadnja", dgStavke.Rows(i).Cells(8).Value)
                    .Parameters.AddWithValue("@cena_vp1", dgStavke.Rows(i).Cells(8).Value)
                    .Parameters.AddWithValue("@cena_vp2", 0)
                    .Parameters.AddWithValue("@cena_vp3", 0)
                    .Parameters.AddWithValue("@cena_mp", dgStavke.Rows(i).Cells(8).Value * (1 + (dgStavke.Rows(i).Cells(13).Value / 100))) ' mp_cena(i)) '!!!
                    .Parameters.AddWithValue("@pdv", CSng(dgStavke.Rows(i).Cells(13).Value))
                    .Parameters.AddWithValue("@rabat", rabat(i)) '!!!
                    .Parameters.AddWithValue("@marza", marza(i))
                    .ExecuteScalar()
                End With
            End If
            CM.Dispose()
            CN.Close()
        Next
    End Sub

#End Region

#Region "Zakljuci"
    Private Sub btnZakljuci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZakljuci.Click
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
                .CommandText = "rm_nivelacije_zakljuci"
                .Parameters.AddWithValue("@id_nivelacija", _id_nivelacije)
                .Parameters.AddWithValue("@unesena", 1)
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
                magacinSifra = _magacin_sifra
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


    Private Sub txtStaraVred_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStaraVred.TextChanged
        If Not jeste_broj(txtStaraVred.Text) Then
            txtStaraVred.BackColor = Color.LavenderBlush
            txtStaraVred.Select()
        Else
            txtStaraVred.BackColor = Color.GhostWhite
        End If
    End Sub

    Private Sub txtNovaVred_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNovaVred.TextChanged
        If Not jeste_broj(txtNovaVred.Text) Then
            txtNovaVred.BackColor = Color.LavenderBlush
            txtNovaVred.Select()
        Else
            txtNovaVred.BackColor = Color.GhostWhite
        End If
    End Sub

    Private Sub txtRazlikauceni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRazlikauceni.TextChanged
        If Not jeste_broj(txtStaraVred.Text) Then
            txtRazlikauceni.BackColor = Color.LavenderBlush
            txtRazlikauceni.Select()
        Else
            txtRazlikauceni.BackColor = Color.GhostWhite
        End If
    End Sub

    Private Sub txtStariPDV_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStariPDV.TextChanged
        If Not jeste_broj(txtStaraVred.Text) Then
            txtStariPDV.BackColor = Color.LavenderBlush
            txtStariPDV.Select()
        Else
            txtStariPDV.BackColor = Color.GhostWhite
        End If
    End Sub

    Private Sub txtNoviPDV_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoviPDV.TextChanged
        If Not jeste_broj(txtStaraVred.Text) Then
            txtNoviPDV.BackColor = Color.LavenderBlush
            txtNoviPDV.Select()
        Else
            txtNoviPDV.BackColor = Color.GhostWhite
        End If
    End Sub

    Private Sub txtRazlikaPDV_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRazlikaPDV.TextChanged
        If Not jeste_broj(txtStaraVred.Text) Then
            txtRazlikaPDV.BackColor = Color.LavenderBlush
            txtRazlikaPDV.Select()
        Else
            txtRazlikaPDV.BackColor = Color.GhostWhite
        End If
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
                .CommandText = "select * from dbo.rm_nivelacije_stavka where dbo.rm_nivelacije_stavka.id_nivelacija = " & _id_nivelacije
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            _broj_stavki = 0
            Do While DR.Read
                _broj_stavki += 1
            Loop
            DR.Close()

            _id_nivelacije_stavke = New Integer() {}
            ReDim _id_nivelacije_stavke(_broj_stavki - 1)

            With dgStavke
                Dim i As Integer = 0
                DR = CM.ExecuteReader
                Do While DR.Read
                    .Rows.Add(1)
                    redni_broj()
                    If Not IsDBNull(DR.Item("id_nivelacija_stavka")) Then _id_nivelacije_stavke.SetValue(DR.Item("id_nivelacija_stavka"), i)
                    'If Not IsDBNull(DR.Item("rb")) Then .Rows(i).Cells(0).Value = DR.Item("rb")

                    If Not IsDBNull(DR.Item("roba_sifra")) Then
                        popuni_robu(RTrim(DR.Item("roba_sifra")))
                        If sifra <> "" Then
                            .Rows(i).Cells(1).Value = RTrim(sifra)
                        Else
                            .Rows(i).Cells(1).Value = DBNull.Value
                        End If
                    End If

                    'If Not IsDBNull(DR.Item("roba_sifra")) Then .Rows(i).Cells(1).Value = DR.Item("roba_sifra").ToString
                    If Not IsDBNull(DR.Item("roba_naziv")) Then .Rows(i).Cells(2).Value = DR.Item("roba_naziv").ToString
                    selektuj_artikl(sifra, Selekcija.po_sifri)
                    selektuj_jm(_artikl_id_jm, Selekcija.po_id)
                    selektuj_GrupeArt(_artikl_id_grupa, Selekcija.po_id)
                    If Not IsDBNull(_jm_oznaka) Then .Rows(i).Cells(3).Value = _jm_oznaka
                    If Not IsDBNull(_gr_art_skraceno) Then .Rows(i).Cells(4).Value = _gr_art_skraceno
                    If Not IsDBNull(DR.Item("kolicina")) Then .Rows(i).Cells(5).Value = DR.Item("kolicina")
                    If Not IsDBNull(DR.Item("stara_cena")) Then .Rows(i).Cells(6).Value = DR.Item("stara_cena")
                    If Not IsDBNull(DR.Item("stara_vrednost")) Then .Rows(i).Cells(7).Value = DR.Item("stara_vrednost")
                    If Not IsDBNull(DR.Item("nova_cena")) Then .Rows(i).Cells(8).Value = DR.Item("nova_cena")
                    If Not IsDBNull(DR.Item("nova_vrednost")) Then .Rows(i).Cells(9).Value = DR.Item("nova_vrednost")
                    If Not IsDBNull(DR.Item("razlika_cena")) Then .Rows(i).Cells(10).Value = DR.Item("razlika_cena")
                    If Not IsDBNull(DR.Item("stari_pdv")) Then .Rows(i).Cells(11).Value = DR.Item("stari_pdv")
                    If Not IsDBNull(DR.Item("stari_iznos_pdv")) Then .Rows(i).Cells(12).Value = DR.Item("stari_iznos_pdv")
                    If Not IsDBNull(DR.Item("novi_pdv")) Then .Rows(i).Cells(13).Value = DR.Item("novi_pdv")
                    If Not IsDBNull(DR.Item("novi_iznos_pdv")) Then .Rows(i).Cells(14).Value = DR.Item("novi_iznos_pdv")
                    If Not IsDBNull(DR.Item("razlika_pdv")) Then .Rows(i).Cells(15).Value = DR.Item("razlika_pdv")

                    If RTrim(magacinSifra) = 1202 Then
                        .Rows(i).Cells(5).Style.Format = "N3"
                        .Rows(i).Cells(5).Value = Format(.Rows(i).Cells(5).Value, 3)
                    Else
                        .Rows(i).Cells(5).Style.Format = "N0"
                        .Rows(i).Cells(5).Value = CInt(.Rows(i).Cells(5).Value)
                    End If

                    i += 1
                Loop
                DR.Close()
            End With
        End If

        CM.Dispose()
        CN.Close()
        '_citam_stavke = False
    End Sub

End Class
