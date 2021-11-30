Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class cntTrebovanje_edit

#Region "dekleracija"
    Private kol_tre As Single = 0
    Private kol_mag As Single = 0
    Private cena As Single = 0
    Private c_cena As Single = 0
    Private c_jkl As String = ""
    Private c_JM As String = ""
    Private c_Grupa As String = ""
    Private lSifra As String = ""
    Private lNaziv As String = ""
    Private lKol As Single = 0
    Private lCena As Single = 0
    Private lId As Integer = 0
    Private s_vred As Single = 0
    Private sifra As String = ""
    Private naziv As String = ""
    Private indeks As Integer = 0
    Private broj_decimala() As Integer
    Private id_predhodnog_stanja As Integer
    Private id_predhodnog_stanja_stavka As Integer

    Private _pocetak As Boolean = True
    Private _citam_stavke As Boolean = True
    Private _popunjavam_robu As Boolean = False
    Private _izabran_magacin As Boolean = False
    Private magacinID As Integer = 0
    Private magacinSifra As String = ""
    Private grupaID As Integer = 0
    Private _vise_grupa As Boolean = False

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

    Private Sub cntTrebovanje_edit_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'If _ima_promena Then
        '    If MsgBox("Načinili ste promene. Dali želite da ih snimite?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '        'snimi()
        '    End If
        'End If

        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntTrebovanje
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _mSpliter.SplitterDistance = 210

        Dim myControl1 As New cntTrebovanje_search
        myControl1.Parent = _mSpliter.Panel1
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_tebovanje + My.Resources.text_search
        cntMeniObrada_ostalo.podesi_boje_linkova(_mPanTrebovanja_meni)
        _mLinkTrebovanja_search.BackColor = Color.GhostWhite
        _mLinkTrebovanja_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub cntTrebovanje_edit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tlbMain.Dock = DockStyle.Fill

        broj_decimala = New Integer() {}
        ReDim broj_decimala(100)

        _grid = dgStavke
        _lista = Me.lvLista

        pocetak()
    End Sub

    Private Sub pocetak()

        _pocetak = True
        _izabran_magacin = False

        dgStavke.Rows.Clear()
        lvLista.Items.Clear()
        labLager.Text = "--"

        popuni_magacine()
        popuni_stavke()

        popuni_grupe()

        txtBroj.Text = _treb_broj
        txtIznosCena.Text = Format(_treb_vrednost, "##,##0.00")

        dateKalkulacija.Value = _treb_datum

        _pocetak = False

        'kontrole()

        If _treb_zakljuceno Then
            _unesen = True
            zatvori_formu()
        End If

        cmbGrupa.Enabled = False
        txtBroj.Enabled = False
        cmbMagacin.Enabled = False
    End Sub

#Region "Grid 1"

    Private Sub dgStavke_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgStavke.CellEndEdit
        If e.ColumnIndex = 1 And e.RowIndex = indeks Then
            'dgStavke.Select()
            dgStavke.Rows.Item(e.RowIndex).Selected = True
            'dgStavke.Rows(dgStavke.CurrentRow.Index).Cells(5).Selected = True
            dgStavke.Columns.Item(5).Selected = True ' Rows(e.RowIndex).Cells(5).Selected = True
        Else
            If e.ColumnIndex = 5 And e.RowIndex = indeks Then

                If IsNothing(dgStavke.Rows(e.RowIndex).Cells(5).Value) Or dgStavke.Rows(e.RowIndex).Cells(5).Value = 0 Then
                    Beep()
                    MsgBox("Količina mora biti unešena!", MsgBoxStyle.OkOnly)
                    dgStavke.Rows(e.RowIndex).Cells(5).Style.BackColor = Color.Red
                    dgStavke.Select()
                    dgStavke.Rows(e.RowIndex).Selected = True
                    'dgStavke.Rows(e.RowIndex).Cells(5).Selected = True
                Else
                    dgStavke.Rows(e.RowIndex).Cells(5).Style.BackColor = Color.GhostWhite
                    dgStavke.Select()
                    dgStavke.Rows(e.RowIndex + 1).Selected = True
                    dgStavke.Rows(e.RowIndex + 1).Cells(1).Selected = True
                End If
            End If
        End If
    End Sub

    Private Sub dgStavke_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgStavke.CellValueChanged
        If Not _pocetak Then
            With dgStavke
                Try
                    Select Case e.ColumnIndex
                        Case 3
                            indeks = e.RowIndex
                            If Not _popunjavam_robu Then
                                upit_lek = "rm_artikli.artikl_naziv LIKE N'" & .Rows(e.RowIndex).Cells(3).Value.ToString & "%'"
                                filter()
                            End If
                    End Select

                    If Not _popunjavam_robu Then
                        If Not IsNothing(.Rows(e.RowIndex).Cells(5).Value) Then
                            If .Rows(e.RowIndex).Cells(5).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(5).Value.ToString) Then
                                kol_tre = CSng(.Rows(e.RowIndex).Cells(5).Value)
                            Else
                                kol_tre = 0
                            End If
                        End If
                        If Not IsNothing(.Rows(e.RowIndex).Cells(7).Value) Then
                            If .Rows(e.RowIndex).Cells(7).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(7).Value.ToString) Then
                                cena = CSng(.Rows(e.RowIndex).Cells(7).Value)
                            Else
                                cena = 0
                            End If
                        End If
                    Else
                        cena = c_cena
                    End If

                    If RTrim(magacinSifra) = 1202 Then
                        .Rows(e.RowIndex).Cells(5).Style.Format = "N3"
                        .Rows(e.RowIndex).Cells(6).Style.Format = "N3"
                        .Rows(e.RowIndex).Cells(5).Value = Format(kol_tre, 3)
                        .Rows(e.RowIndex).Cells(6).Value = Format(kol_mag, 3)
                    End If
                    .Rows(e.RowIndex).Cells(8).Value = kol_tre * cena

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
        'If _novi_artikl And _prod_cena_promenjena Then Exit Sub

        redni_broj()
        With dgStavke
            If Not IsNothing(lvLista.Items(0).ToString) Then
                If lvLista.Items(0).ToString <> "" Then
                    _popunjavam_robu = True

                    popuni_robu(RTrim(lvLista.SelectedItems.Item(0).SubItems(0).Text))
                    'popuni_robu(.Rows(indeks).Cells(1).Value)
                    lager_lista()

                    .Rows(indeks).Cells(1).Value = sifra
                    .Rows(indeks).Cells(2).Value = c_jkl
                    .Rows(indeks).Cells(3).Value = naziv
                    .Rows(indeks).Cells(4).Value = c_JM 'c_Grupa
                    .Rows(indeks).Cells(5).Value = 0
                    .Rows(indeks).Cells(6).Value = lKol 'kol_mag
                    .Rows(indeks).Cells(7).Value = c_cena
                    .Rows(indeks).Cells(8).Value = 0

                    dgStavke.Rows(indeks).Selected = True
                    dgStavke.Rows(indeks).Cells(5).Selected = True

                    _popunjavam_robu = False


                Else
                    cena = 0
                End If
            End If
            .Rows(indeks).Cells(5).Style.Format = "N" & broj_decimala(indeks) 'DataGridViewCellStyle { Format=N3, Alignment=MiddleCenter }
            .Rows(indeks).Cells(6).Style.Format = "N" & broj_decimala(indeks)
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

    Private Sub lager_lista()
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
            _novi_artikl = False
        End If
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
            selektuj_magacin(_treb_id_magacin, Selekcija.po_id)
            cmbMagacin.SelectedText = _magacin_naziv
            magacinSifra = _magacin_sifra
            magacinID = _id_magacin
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_grupe()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbGrupa.Items.Clear()
        cmbGrupa.Items.Add("")
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
                cmbGrupa.Items.Add(DR.Item("gr_artikla_sifra") & " - " & DR.Item("gr_artikla_naziv"))
            Loop
            DR.Close()
        End If
        If cmbGrupa.Items.Count > 0 And Not _vise_grupa Then
            selektuj_GrupeArt(grupaID, Selekcija.po_id)
            cmbGrupa.SelectedText = _gr_art_sifra & " - " & _gr_art_naziv
            grupaID = _id_gr_art
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
        c_cena = 0
        c_jkl = ""

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
                If Not IsDBNull(DR.Item("jkl")) Then c_jkl = DR.Item("jkl")
                sifra = RTrim(_roba)
                If RTrim(c_jkl) = "" Then c_jkl = "*******"
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
                    broj_decimala.SetValue(3, indeks)
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
                If Not IsDBNull(DR.Item("cena_nab_zadnja")) Then c_cena = DR.Item("cena_nab_zadnja")
                'If Not IsDBNull(DR.Item("cena_vp1")) Then c_cena_vp = DR.Item("cena_vp1")
            Loop
            DR.Close()
            CM.Dispose()

            '**** MAGACIN
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.rm_magacin_promene_stavka where id_artikl = " & lId & _
                                " and id_magacin = " & magacinID
                DR = .ExecuteReader
            End With

            Do While DR.Read
                If Not IsDBNull(DR.Item("mag_art_stanje")) Then kol_mag = DR.Item("mag_art_stanje")
                'If Not IsDBNull(DR.Item("mag_art_cena")) Then c_cena = DR.Item("mag_art_cena")
            Loop
            DR.Close()
            CM.Dispose()

            labLager.Text = RTrim(sifra) & " - " & naziv & " - kol: " & kol_mag & " - cena: " & c_cena

        End If

        CN.Close()
    End Sub

    Private Sub zatvori_formu()
        If _unesen Then
            panHeader.Enabled = False
            cmbMagacin.Enabled = False

            dgStavke.AllowUserToAddRows = False
            dgStavke.Enabled = False

            txtIznosCena.Enabled = False

            btnSnimi.Enabled = False
            btnZakljuci.Enabled = False
        End If
    End Sub

    Private Sub preracunaj()
        Dim i As Integer

        s_vred = 0

        Try
            For i = 0 To dgStavke.Rows.Count - 2
                Dim kol As Single = CDec(dgStavke.Rows(i).Cells(5).Value)
                Dim cena As Single = CDec(dgStavke.Rows(i).Cells(7).Value)

                s_vred += kol * cena
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txtIznosCena.Text = Format(s_vred, 2)

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
                .CommandText = "select dbo.rm_trebovanje_stavka.* from dbo.rm_trebovanje_stavka where dbo.rm_trebovanje_stavka.id_trebovanje = " & _id_trebovanje
                DR = .ExecuteReader
            End With

            _broj_stavki = 0
            Do While DR.Read
                _broj_stavki += 1
            Loop
            DR.Close()

            _id_trebovanje_stavka = New Integer() {}
            ReDim _id_trebovanje_stavka(_broj_stavki - 1)

            With dgStavke
                Dim i As Integer = 0
                DR = CM.ExecuteReader
                Do While DR.Read
                    .Rows.Add(1)

                    If RTrim(magacinSifra) = 1202 Then
                        .Rows(i).Cells(5).Style.Format = "N3"
                        .Rows(i).Cells(6).Style.Format = "N3"
                    Else
                        .Rows(i).Cells(5).Style.Format = "N0"
                        .Rows(i).Cells(6).Style.Format = "N0"
                    End If

                    If Not IsDBNull(DR.Item("id_treb_stavka")) Then _id_trebovanje_stavka.SetValue(DR.Item("id_treb_stavka"), i)

                    If Not IsDBNull(DR.Item("treb_st_rb")) Then .Rows(i).Cells(0).Value = DR.Item("treb_st_rb")
                    selektuj_artikl(DR.Item("id_artikl"), Selekcija.po_id)

                    .Rows(i).Cells(1).Value = _artikl_sifra
                    If _artikl_jkl <> "" Then
                        .Rows(i).Cells(2).Value = _artikl_jkl
                    Else
                        .Rows(i).Cells(2).Value = "*******"
                    End If
                    .Rows(i).Cells(3).Value = _artikl_naziv
                    selektuj_jm(_artikl_id_jm, Selekcija.po_id)
                    .Rows(i).Cells(4).Value = _jm_oznaka
                    If Not IsDBNull(DR.Item("treb_st_kolicina")) Then .Rows(i).Cells(5).Value = DR.Item("treb_st_kolicina")
                    If Not IsDBNull(DR.Item("treb_st_mag_stanje")) Then .Rows(i).Cells(6).Value = DR.Item("treb_st_mag_stanje")
                    If Not IsDBNull(DR.Item("treb_st_cena")) Then .Rows(i).Cells(7).Value = DR.Item("treb_st_cena")
                    If Not IsDBNull(DR.Item("treb_st_vrednost")) Then .Rows(i).Cells(8).Value = DR.Item("treb_st_vrednost")

                    If Not IsDBNull(DR.Item("id_grupa")) And _
                       DR.Item("id_grupa") <> 0 And _
                       DR.Item("id_grupa") <> grupaID And _
                       grupaID <> 0 Then
                        _vise_grupa = True
                    End If

                    If Not IsDBNull(DR.Item("id_grupa")) Then grupaID = DR.Item("id_grupa")

                    'If RTrim(magacinSifra) = 1202 Then
                    '    .Rows(i).Cells(5).Style.Format = "N3"
                    '    .Rows(i).Cells(6).Style.Format = "N3"
                    '    .Rows(i).Cells(5).Value = Format(.Rows(i).Cells(5).Value, 3)
                    '    .Rows(i).Cells(6).Value = Format(.Rows(i).Cells(6).Value, 3)
                    'Else
                    '    .Rows(i).Cells(5).Style.Format = "N0"
                    '    .Rows(i).Cells(6).Style.Format = "N0"
                    'End If

                    i += 1
                Loop
                DR.Close()
            End With
        End If

        CM.Dispose()
        CN.Close()

        _citam_stavke = False
        _popunjavam_robu = False
    End Sub

#Region "Snimi"
    Private Sub btnSnimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSnimi.Click
        snimi_head()
        snimi_stavku()

        _treb_vrednost = CSng(txtIznosCena.Text)
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
                .CommandText = "rm_trebovanje_head_update"
                .Parameters.AddWithValue("@id_trebovanje", _id_trebovanje)
                .Parameters.AddWithValue("@treb_broj", txtBroj.Text)
                .Parameters.AddWithValue("@treb_datum", dateKalkulacija.Value.Date)
                .Parameters.AddWithValue("@id_magacin", _treb_id_magacin)
                .Parameters.AddWithValue("@treb_vrednost", CSng(txtIznosCena.Text))
                .Parameters.AddWithValue("@treb_zakljuceno", 0)
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

        _id_trebovanje = Nadji_id(Imena.tabele.rm_trebovanje_head.ToString)

        CN.Open()
        If _id_trebovanje_stavka.Length > dgStavke.Rows.Count - 1 Then
            n = _id_trebovanje_stavka.Length - 1
        Else
            n = dgStavke.Rows.Count - 2
        End If
        For i = 0 To n
            If (i <= dgStavke.Rows.Count - 2 Or Not _id_trebovanje_stavka.Length > dgStavke.Rows.Count - 1) _
                Or _id_trebovanje_stavka.Length = 0 Then
                If i > _id_trebovanje_stavka.Length - 1 Then
                    CM = New SqlCommand()
                    If CN.State = ConnectionState.Open Then
                        With CM
                            .Connection = CN
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "rm_trebovanje_stavka_add"
                            .Parameters.AddWithValue("@id_trebovanje", _id_trebovanje)
                            .Parameters.AddWithValue("@treb_st_rb", dgStavke.Rows(i).Cells(0).Value)
                            selektuj_artikl(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)
                            .Parameters.AddWithValue("@id_artikl", _id_artikl)
                            .Parameters.AddWithValue("@id_grupa", _artikl_id_grupa)
                            .Parameters.AddWithValue("@treb_st_kolicina", dgStavke.Rows(i).Cells(5).Value)
                            .Parameters.AddWithValue("@treb_st_mag_stanje", dgStavke.Rows(i).Cells(6).Value)
                            .Parameters.AddWithValue("@treb_st_cena", dgStavke.Rows(i).Cells(7).Value)
                            .Parameters.AddWithValue("@treb_st_vrednost", dgStavke.Rows(i).Cells(8).Value)
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
                            .CommandText = "rm_trebovanje_stavka_update"
                            .Parameters.AddWithValue("@id_treb_stavka", _id_trebovanje_stavka(i))
                            .Parameters.AddWithValue("@treb_st_rb", dgStavke.Rows(i).Cells(0).Value)
                            selektuj_artikl(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)
                            .Parameters.AddWithValue("@id_artikl", _id_artikl)
                            .Parameters.AddWithValue("@id_grupa", _artikl_id_grupa)
                            .Parameters.AddWithValue("@treb_st_kolicina", dgStavke.Rows(i).Cells(5).Value)
                            .Parameters.AddWithValue("@treb_st_mag_stanje", dgStavke.Rows(i).Cells(6).Value)
                            .Parameters.AddWithValue("@treb_st_cena", dgStavke.Rows(i).Cells(7).Value)
                            .Parameters.AddWithValue("@treb_st_vrednost", dgStavke.Rows(i).Cells(8).Value)
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
                        .CommandText = "rm_trebovanje_stavka_delete"
                        .Parameters.AddWithValue("@id_treb_stavka", _id_trebovanje_stavka(i)) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                        .ExecuteScalar()
                    End With
                End If
                CM.Dispose()
            End If
        Next
        CN.Close()

    End Sub

#End Region

#Region "Zakljuci"
    Private Sub btnZakljuci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZakljuci.Click
        prebaci_u_magacin_promene(_id_magacin, ID_vrsta_dokumenta, txtBroj.Text)
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
                .CommandText = "rm_trebovanje_head_zakljuci"
                .Parameters.AddWithValue("@id_trebovanje", _id_trebovanje)
                .Parameters.AddWithValue("@treb_zakljuceno", 1)
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

    Private Sub cmbGrupa_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbGrupa.SelectedIndexChanged
        If Not _pocetak Then
            If cmbGrupa.Text <> "" Then
                selektuj_GrupeArt(izdvoj_sifru(cmbGrupa.Text), Selekcija.po_sifri)
                grupaID = _id_gr_art
                dgStavke.Rows.Clear()
                selektuj_lager(magacinID, grupaID, Lager.trebovanje)
            End If
        End If
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

End Class
