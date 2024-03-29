Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class cntPopis_add
#Region "dekleracija"
    Private kol_pop As Single = 0
    Private kol_mag As Single = 0
    Private cena As Single = 0
    Private c_cena As Single = 0
    Private c_jkl As String = ""
    Private c_JM As String = ""
    Private c_Grupa As String = ""
    Private lId As Integer = 0
    Private s_vred_pop As Single = 0
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

    Private upit As String = ""
    Private upit_sifra As String = ""
    Private upit_lek As String = ""

    Shared sql_start As String = _
                    "SELECT DISTINCT " & _
                          "TOP (100) PERCENT dbo.rm_artikli.artikl_sifra, dbo.rm_artikli.artikl_naziv, " & _
                          "dbo.rm_artikli.jkl, " & _
                          "dbo.app_artikl_grupa.gr_artikla_sifra, dbo.app_artikl_grupa.gr_artikla_naziv, " & _
                          "dbo.app_jm.jm_oznaka, " & _
                    "FROM dbo.rm_artikli LEFT OUTER JOIN " & _
                          "dbo.app_jm ON dbo.rm_artikli.id_jm = dbo.app_jm.id_jm LEFT OUTER JOIN " & _
                          "dbo.app_artikl_grupa ON dbo.rm_artikli.id_grup_artikla = dbo.app_artikl_grupa.id_grup_artikla"

    Shared sql As String = ""
#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntPopis_add_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'If _ima_promena Then
        '    If MsgBox("Načinili ste promene. Dali želite da ih snimite?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '        'snimi()
        '    End If
        'End If

        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntPopis
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _mSpliter.SplitterDistance = 240

        Dim myControl1 As New cntPopis_search
        myControl1.Parent = _mSpliter.Panel1
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        _labHead.Text = Ispisi_label() + " : popis" + " - pretraga"
        cntMeniObrada_ostalo.podesi_boje_linkova(_mPanPopis_meni)
        _mLinkPopis_search.BackColor = Color.GhostWhite
        _mLinkPopis_search.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub cntPopis_add_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tlbMain.Dock = DockStyle.Fill

        broj_decimala = New Integer() {}
        ReDim broj_decimala(100)

        pocetak()
    End Sub

    Private Sub pocetak()

        _pocetak = True

        popuni_magacine()

        dgStavke.Rows.Clear()
        labLager.Text = "--"

        txtBroj.Text = Nadji_rb(Imena.tabele.rm_popis_head.ToString, 1)
        txtIznosCena.Text = 0

        dateKalkulacija.Value = Today

        _pocetak = False
        _izabran_magacin = False
        kontrole()

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
                        Case 1
                            indeks = e.RowIndex
                            If Not _popunjavam_robu Then
                                redni_broj()
                                popuni_robu(.Rows(e.RowIndex).Cells(1).Value)

                                .Rows(indeks).Cells(1).Value = sifra
                                .Rows(indeks).Cells(2).Value = c_jkl
                                .Rows(indeks).Cells(3).Value = naziv
                                .Rows(indeks).Cells(4).Value = c_JM 'c_Grupa
                                .Rows(indeks).Cells(5).Value = 0
                                .Rows(indeks).Cells(6).Value = kol_mag
                                .Rows(indeks).Cells(7).Value = c_cena
                                .Rows(indeks).Cells(8).Value = 0

                                dgStavke.Rows(e.RowIndex).Selected = True
                                dgStavke.Rows(e.RowIndex).Cells(5).Selected = True

                            End If
                    End Select

                    If Not _popunjavam_robu Then
                        If Not IsNothing(.Rows(e.RowIndex).Cells(5).Value) Then
                            If .Rows(e.RowIndex).Cells(5).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(5).Value.ToString) Then
                                kol_pop = CSng(.Rows(e.RowIndex).Cells(5).Value)
                            Else
                                kol_pop = 0
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
                        .Rows(indeks).Cells(5).Style.Format = "N3"
                        .Rows(e.RowIndex).Cells(5).Value = Format(kol_pop, 3)
                    End If
                    .Rows(e.RowIndex).Cells(8).Value = kol_pop * cena

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
            cmbMagacin.SelectedIndex = 0
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

        s_vred_pop = 0

        Try
            For i = 0 To dgStavke.Rows.Count - 2
                Dim kol_p As Single = CDec(dgStavke.Rows(i).Cells(5).Value)
                Dim kol_m As Single = CSng(dgStavke.Rows(i).Cells(6).Value)
                Dim cena As Single = CDec(dgStavke.Rows(i).Cells(7).Value)

                s_vred_pop += kol_p * cena
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txtIznosCena.Text = Format(s_vred_pop, "##,##0.00")

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

        selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_popis_head_add"
                .Parameters.AddWithValue("@pop_broj", txtBroj.Text)
                .Parameters.AddWithValue("@pop_datum", dateKalkulacija.Value.Date)
                .Parameters.AddWithValue("@id_magacin", _id_magacin)
                .Parameters.AddWithValue("@pop_vrednost", CSng(txtIznosCena.Text))
                .Parameters.AddWithValue("@pop_zakljucen", 0)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub snimi_stavku()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim i As Integer

        _id_popis = Nadji_id(Imena.tabele.rm_popis_head.ToString)

        For i = 0 To dgStavke.Rows.Count - 2
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_popis_stavka_add"
                    .Parameters.AddWithValue("@id_popis", _id_popis)
                    .Parameters.AddWithValue("@pop_st_rb", dgStavke.Rows(i).Cells(0).Value)
                    selektuj_artikl(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)
                    .Parameters.AddWithValue("@id_artikl", _id_artikl)
                    .Parameters.AddWithValue("@id_grupa", _artikl_id_grupa)
                    .Parameters.AddWithValue("@cena", dgStavke.Rows(i).Cells(7).Value)
                    .Parameters.AddWithValue("@stanje_popis", dgStavke.Rows(i).Cells(5).Value)
                    .Parameters.AddWithValue("@stanje_magacin", dgStavke.Rows(i).Cells(6).Value)
                    .Parameters.AddWithValue("@vrednost_popis", dgStavke.Rows(i).Cells(8).Value)
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
        _id_oj = 0
        _id_partner = 0

        prebaci_u_magacin_promene(_id_magacin, ID_vrsta_dokumenta, txtBroj.Text)
        prebaci_u_magacin_promene_stavka(_id_dnevni_promet)
        zakljuci_dokument()
    End Sub

    Private Sub zakljuci_dokument()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        _id_popis = Nadji_id(Imena.tabele.rm_popis_head.ToString)

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_popis_head_zakljuci"
                .Parameters.AddWithValue("@id_popis", _id_popis)
                .Parameters.AddWithValue("@pop_zakljucen", 1)
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

    Private Sub txtIznosCena_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIznosCena.TextChanged
        If Not jeste_broj(txtIznosCena.Text) Then
            txtIznosCena.BackColor = Color.LavenderBlush
            txtIznosCena.Select()
        Else
            txtIznosCena.BackColor = Color.GhostWhite
        End If
    End Sub

End Class
