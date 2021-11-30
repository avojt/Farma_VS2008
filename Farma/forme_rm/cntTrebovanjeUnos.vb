Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class cntTrebovanjeUnos
    Private kol As Single = 1
    Private cena As Single = 0
    Private c_cena As Single = 0
    Private pdv As Single = 1
    Private c_pdv As Integer = 18
    Private rabat As Single = 0
    Private neoporezivo As Single = 0
    Private skol As Single = 1
    Private scena As Single = 0
    Private spdv As Single = 0
    Private srab As Single = 0
    Private valuta As Integer = 0
    Private sifra As String = ""
    Private naziv As String = ""

    Private _pocetak As Boolean = True
    Private _citam_stavke As Boolean = True
    Private _popunjavam_robu As Boolean = True
    Private _promenjen_rabat As Boolean = False
    Private _promenjena_cena As Boolean = False
    Private indeks As Integer = 0

    Private _filter As String = ""

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntTrebovanjeUnos_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'postavi_panel(Imena.tabele.ostali_dokumenti.ToString)
        mdiMain.zatvori_kontrolu_desno()
        'mdiMain.zatvori_kontrolu_levo()

        'Dim myControl As New cntOstaliDok
        'myControl.Parent = mdiMain.splGlavni.Panel2
        'myControl.Dock = DockStyle.Fill
        'myControl.Show()

        'postavi_panel(Imena.tabele.ostali_dokumenti.ToString)
    End Sub

    Private Sub cntTrebovanjeUnos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataSet1.app_pdv' table. You can move, or remove it, as needed.
        Me.App_pdvTableAdapter.Fill(Me.DataSet1.app_pdv)
        'TODO: This line of code loads data into the 'DataSet1.rm_artikli' table. You can move, or remove it, as needed.
        Me.Rm_artikliTableAdapter.Fill(Me.DataSet1.rm_artikli)

        pocetak()
        _pocetak = False

    End Sub

    Private Sub pocetak()

        txtSifra.Text = Nadji_rb(Imena.tabele.rm_racun_head.ToString, 1)
        popuni_parnere()
        popuni_magacine()
        popuni_grupe_artikla()
        popuni_artikle()

        dateDatum.Value = Today

        If Not _iz_ponude Then
            txtIznosCena.Text = 0
            txtOsnovica.Text = 0
            txtIznosPdv.Text = 0
            txtIznosRabat.Text = 0
            txtIznosZanaplatu.Text = 0
            txtNapomena.Text = ""
        Else
            txtIznosCena.Text = _cena
            txtOsnovica.Text = _osnovica
            txtIznosPdv.Text = _pdv
            txtIznosRabat.Text = _rabat
            txtIznosZanaplatu.Text = _iznos
            txtNapomena.Text = _napomena

            popuni_stavke()
        End If

        chkCene.Checked = False

        dgStavke.Columns(3).Visible = False
        dgStavke.Columns(4).Visible = False
        dgStavke.Columns(5).Visible = False

        dgStavke.Columns(1).Width = 480
        dgStavke.Columns(2).Width = 100

    End Sub

    Private Sub popuni_parnere()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbPartneri.Items.Clear()
        cmbPartneri.Items.Add(" ")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_partneri.* from dbo.app_partneri"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbPartneri.Items.Add(DR.Item("partner_naziv"))
            Loop
            DR.Close()
        End If
        If cmbPartneri.Items.Count > 0 Then
            If _iz_ponude Then
                cmbPartneri.SelectedText = _partner_naziv
            Else
                cmbPartneri.SelectedIndex = 0
            End If
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_magacine()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        tlbMagacin.Items.Clear()

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
                tlbMagacin.Items.Add(DR.Item("naziv"))
            Loop
            DR.Close()
        End If
        If tlbMagacin.Items.Count > 0 Then
            'If _iz_ponude Then
            '    tlbMagacin.SelectedText = _naziv_partnera
            'Else
            '    tlbMagacin.SelectedIndex = 0
            'End If
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_grupe_artikla()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        tlbGrupaArtikla.Items.Clear()

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
                tlbGrupaArtikla.Items.Add(DR.Item("gr_artikla_sifra"))
            Loop
            DR.Close()
        End If
        If tlbGrupaArtikla.Items.Count > 0 Then
            'If _iz_ponude Then
            '    tlbGrupaArtikla.SelectedText = _naziv_partnera
            'Else
            '    tlbGrupaArtikla.SelectedIndex = 0
            'End If
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_artikle()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        colArtikl.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_magacin_promene_stavka.* from dbo.rm_magacin_promene_stavka" & _
                               " where magacin_zadnjapromena = '01/01/" & Year(Today).ToString & "'"
                DR = .ExecuteReader
            End With

            Do While DR.Read
                colArtikl.Items.Add(artikl_naziv(DR.Item("gr_artikla_sifra")))
            Loop
            DR.Close()
        End If
        If tlbGrupaArtikla.Items.Count > 0 Then
            'If _iz_ponude Then
            '    tlbGrupaArtikla.SelectedText = _naziv_partnera
            'Else
            '    tlbGrupaArtikla.SelectedIndex = 0
            'End If
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub snimi_head()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        'Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_trebovanje_head_add"
                selektuj_magacin(tlbMagacin.Text, Selekcija.po_nazivu)
                .Parameters.AddWithValue("@trebovanje_odeljenje", _magacin_sifra) ' magacin_sifra(tlbMagacin.Text)) ' ToolStrip1.Items(4).Text))
                .Parameters.AddWithValue("@trebovanje_broj", txtSifra.Text)
                .Parameters.AddWithValue("@trebovanje_datum", dateDatum.Value.Date)
                .Parameters.AddWithValue("@id_partner", Partner_id(cmbPartneri.Text))
                .Parameters.AddWithValue("@trebovanje_iznos", CDec(txtIznosCena.Text))
                .Parameters.AddWithValue("@trebovanje_pdv", CDec(txtIznosPdv.Text))
                .Parameters.AddWithValue("@trebovanje_ukupno", CDec(txtIznosZanaplatu.Text))
                .Parameters.AddWithValue("@trebovanje_napomena", CDec(txtNapomena.Text))
                .Parameters.AddWithValue("@vrsta_dokumenta", 0)
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

        _id_racun = Nadji_id(Imena.tabele.rm_racun_head.ToString)
        For i = 0 To dgStavke.Rows.Count - 2
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_trebovanje_stavke"
                    .Parameters.AddWithValue("@id_trebovanje", _id_racun) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                    .Parameters.AddWithValue("@trebovanje_rb", dgStavke.Rows(i).Cells(0).Value)
                    .Parameters.AddWithValue("@trebovanje_sifra", dgStavke.Rows(i).Cells(1).Value)
                    .Parameters.AddWithValue("@trebovanje_stavka", dgStavke.Rows(i).Cells(2).Value)
                    .Parameters.AddWithValue("@trebovanje_kolicina", CSng(dgStavke.Rows(i).Cells(3).Value))
                    .Parameters.AddWithValue("@trebovanje_cena", CSng(dgStavke.Rows(i).Cells(4).Value))
                    .Parameters.AddWithValue("@trebovanje_pdv", CSng(dgStavke.Rows(i).Cells(5).Value))
                    .Parameters.AddWithValue("@trebovanje_zanaplatu", CInt(dgStavke.Rows(i).Cells(6).Value))
                    .Parameters.AddWithValue("@id_vrsta_dokumenta", 0)
                    .ExecuteScalar()
                End With
            End If
            CM.Dispose()
            CN.Close()
        Next
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Select Case e.ClickedItem.Name
            Case "tlbSnimi"
                snimi_head()
                snimi_stavku()
                pocetak()
                dgStavke.Rows.Clear()
            Case "tlbStanje"
                stanje()
                proveri_stanje(_nazivi, dgStavke.Rows.Count - 1)
            Case "tlbIzdaj"
                stanje()
                izdaj_robu(_nazivi, dgStavke.Rows.Count - 1)
                izdat()
            Case "tlbProknjizi"
                proknjizi()
            Case "tlbEnd"
                Me.Dispose()
        End Select
    End Sub

#Region "Grid 1"

    Private Sub dgStavke_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        'If dgStavke.CurrentRow.Displayed Then

        '    popuni_robu(RTrim(dgStavke.CurrentRow.Cells(1).Value.ToString))
        '    'dgStavke.CurrentRow.Tag = naziv
        '    dgStavke.CurrentRow.Cells(1).ToolTipText = naziv
        'End If
    End Sub

    Private Sub dgStavke_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgStavke.CellValueChanged
        If Not _pocetak Then
            With dgStavke
                Try
                    '.Rows(e.RowIndex).Cells(0).Value = e.RowIndex + 1
                    Select Case e.ColumnIndex
                        Case 1
                            _popunjavam_robu = True
                            indeks = e.RowIndex
                            redni_broj()
                            If Not IsNothing(.Rows(e.RowIndex).Cells(1).Value) Then
                                If .Rows(e.RowIndex).Cells(1).Value.ToString <> "" Then

                                    popuni_robu(RTrim(dgStavke.Rows(e.RowIndex).Cells(1).Value.ToString))
                                    .Rows(e.RowIndex).Cells(1).ToolTipText = naziv

                                    .Rows(e.RowIndex).Cells(2).Value = naziv
                                    .Rows(e.RowIndex).Cells(3).Value = 1
                                    .Rows(e.RowIndex).Cells(4).Value = c_cena
                                    .Rows(e.RowIndex).Cells(5).Value = 0
                                    .Rows(e.RowIndex).Cells(6).Value = c_pdv
                                    _popunjavam_robu = False

                                Else
                                    cena = 0
                                End If
                            End If
                        Case 4
                            _promenjena_cena = True
                        Case 5
                            _promenjen_rabat = True
                    End Select

                    If Not _popunjavam_robu Then
                        If Not IsNothing(.Rows(e.RowIndex).Cells(3).Value) Then
                            If .Rows(e.RowIndex).Cells(3).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(3).Value.ToString) Then
                                kol = CSng(.Rows(e.RowIndex).Cells(3).Value)
                            Else
                                kol = 1
                            End If
                        End If
                        If Not IsNothing(.Rows(e.RowIndex).Cells(4).Value) Then
                            If .Rows(e.RowIndex).Cells(4).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(4).Value.ToString) Then
                                cena = CSng(.Rows(e.RowIndex).Cells(4).Value)
                            Else
                                cena = 0
                            End If
                        End If
                        If Not IsNothing(.Rows(e.RowIndex).Cells(5).Value) Then
                            If .Rows(e.RowIndex).Cells(5).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(5).Value.ToString) Then
                                rabat = CSng(.Rows(e.RowIndex).Cells(4).Value) * CSng(.Rows(e.RowIndex).Cells(5).Value) / 100
                            Else
                                rabat = 0
                            End If
                        End If
                        If Not IsNothing(.Rows(e.RowIndex).Cells(6).Value) Then
                            If .Rows(e.RowIndex).Cells(6).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(6).Value.ToString) Then
                                pdv = 1 + (CSng(.Rows(e.RowIndex).Cells(6).Value) / 100)
                            Else
                                pdv = 1
                            End If
                        End If
                    Else
                        'cena = c_cena
                        pdv = 1 + (c_pdv / 100)
                        'rabat = 0
                    End If

                    .Rows(e.RowIndex).Cells(7).Value = Format(kol * (cena - rabat) * pdv, 3)

                    _promenjena_cena = False
                    _promenjen_rabat = False

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End With

        End If
        preracunaj()
    End Sub

    Dim store As System.Collections.Generic.Dictionary(Of Integer, Integer) = _
        New System.Collections.Generic.Dictionary(Of Integer, Integer)

    Const initialValue As Integer = -1
    Private Sub dgStavke_CellValuePushed(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValueEventArgs) Handles dgStavke.CellValuePushed
        store.Add(e.RowIndex, CInt(e.Value))
    End Sub

    Private Sub dgStavke_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgStavke.RowsRemoved
        preracunaj()
    End Sub


#End Region

    Private Sub redni_broj()
        Dim i As Integer

        For i = 0 To dgStavke.RowCount - 2
            dgStavke.Rows(i).Cells(0).Value = i + 1
        Next
    End Sub

    Private Sub dateDatum_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateDatum.ValueChanged
        dgStavke.Select()
    End Sub

    Private Function popuni_cenu(ByVal _roba As String) As Decimal
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli where naziv = '" & _roba & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                popuni_cenu = DR.Item("cena")
                c_pdv = DR.Item("pdv")
            Loop
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Private Sub popuni_robu(ByVal _roba As String)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        sifra = ""
        naziv = ""
        c_cena = 0
        'trenutna_kolicina = 0
        c_pdv = 1

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli where artikl_sifra = '" & _roba & "'"
                DR = .ExecuteReader
            End With

            Dim id As Integer = 0
            Dim id_pdv As Integer = 0
            Do While DR.Read
                id = DR.Item("id_artikl")
                'id_pdv = DR.Item("id_pdv")
                naziv = DR.Item("artikl_naziv")
                sifra = RTrim(_roba) ' DR.Item("sifra")
                'c_cena = DR.Item("cena")
                'trenutna_kolicina = DR.Item("kolicina")
                c_pdv = pdv_stopa(DR.Item("id_pdv"))
            Loop
            DR.Close()
            CM.Dispose()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_artikli_cene.* from dbo.rm_artikli_cene where id_artikl = " & id '& "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                c_cena = DR.Item("cena_vp1")
                'trenutna_kolicina = DR.Item("kolicina")
                'c_pdv = DR.Item("pdv")
            Loop
            DR.Close()
            CM.Dispose()
        End If

        CN.Close()
    End Sub

    Private Sub stanje()
        Dim i As Integer
        For i = 0 To dgStavke.Rows.Count - 2
            _nazivi.SetValue(dgStavke.Rows(i).Cells(2).Value.ToString, i, 0)
            _nazivi.SetValue(dgStavke.Rows(i).Cells(3).Value.ToString, i, 1)
        Next
    End Sub

    Private Sub izdat()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_racun_izdaj"
                .Parameters.AddWithValue("@id_racun_head", _id_racun)
                .Parameters.AddWithValue("@izdat", 1)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        _izdat = True
        zatvori_formu()
    End Sub

    Private Sub zatvori_formu()
        If _izdat Then
            Panel1.Enabled = False
            dgStavke.AllowUserToAddRows = False
            dgStavke.Enabled = False

            ToolStrip1.Items(0).Enabled = False
            ToolStrip1.Items(1).Enabled = False
            ToolStrip1.Items(2).Enabled = False

            txtNapomena.Enabled = False
            txtIznosCena.Enabled = False
            txtIznosPdv.Enabled = False
            txtIznosRabat.Enabled = False
            txtIznosZanaplatu.Enabled = False
            txtOsnovica.Enabled = False
        End If
    End Sub

    Private Sub preracunaj()
        Dim i As Integer

        cena = 0
        rabat = 0
        pdv = 0
        scena = 0
        srab = 0
        spdv = 0

        Try
            For i = 0 To dgStavke.Rows.Count - 2
                Dim kol As Single = CDec(dgStavke.Rows(i).Cells(3).Value)
                Dim cen As Single = CDec(dgStavke.Rows(i).Cells(4).Value)
                Dim rab As Single = CDec(dgStavke.Rows(i).Cells(5).Value)
                Dim pdv As Single = CDec(dgStavke.Rows(i).Cells(6).Value)
                scena = scena + (kol * cen)
                srab = srab + (kol * cen * rab / 100)
                spdv += kol * (cen * (1 - (rab / 100))) * (pdv / 100) '((kol * (cen * (1 - (rab / 100)))) * pdv / 100)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'If Not _unesen Then
        txtIznosCena.Text = Format(scena, "##,##0.00")
        txtIznosRabat.Text = Format(srab, "##,##0.00")
        txtOsnovica.Text = Format((scena - srab), "##,##0.00")
        txtIznosPdv.Text = Format((spdv), "##,##0.00")
        txtIznosZanaplatu.Text = Format((scena - srab + spdv), "##,##0.00")
        'End If


    End Sub

    Private Sub popuni_stavke()
        With dgStavke
            Dim i As Integer = 0

            _citam_stavke = True
            For i = 0 To _broj_stavki - 1
                .Rows.Add(1)
                .Rows(i).Cells(0).Value = _artikli(i, 0)
                .Rows(i).Cells(1).Value = _artikli(i, 1)
                .Rows(i).Cells(2).Value = _artikli(i, 2)
                .Rows(i).Cells(3).Value = CSng(_artikli(i, 3))
                .Rows(i).Cells(4).Value = CSng(_artikli(i, 4))
                .Rows(i).Cells(5).Value = CSng(_artikli(i, 5))
                .Rows(i).Cells(6).Value = CInt(_artikli(i, 6))
                .Rows(i).Cells(7).Value = CSng(_artikli(i, 7))
            Next
        End With
        _citam_stavke = False
    End Sub

    Private Sub proknjizi()
        _sema_sifra = "irn-r"
        _partner_sifra = Partner_sifra(cmbPartneri.Text)
        _osnovica = CSng(txtOsnovica.Text)
        _pdv_iznos = CSng(txtIznosPdv.Text)
        _iznos = CSng(txtIznosZanaplatu.Text)
        _opis = "Racun rb." & txtSifra.Text
        _po_semi = True

        Dim mForm As New cntNalog_add
        mForm.Show()
    End Sub

    Private Sub btnNoviPartner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoviPartner.Click
        Dim mForm As New cntPartneri_add
        mForm.Show()
    End Sub

    Private Sub btnNoviArtkl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoviArtkl.Click
        Dim mForm As New cntArtikliUnos
        mForm.Show()
    End Sub

    Private Sub btnOsvezi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOsvezi.Click
        Me.Rm_artikliTableAdapter.Update(Me.DataSet1.rm_artikli)
        Me.Rm_artikliTableAdapter.Fill(Me.DataSet1.rm_artikli)

        If _novi_artikl Then
            dgStavke.Rows(indeks).Cells(1).Value = _novi_artikl_sifra
            '_prod_cena_promenjena = False
            _novi_artikl = False
        End If
        popuni_parnere()
    End Sub

    Private Sub chkCene_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCene.CheckStateChanged
        Select Case chkCene.CheckState
            Case CheckState.Checked
                dgStavke.Columns(3).Visible = True
                dgStavke.Columns(4).Visible = True
                dgStavke.Columns(5).Visible = True

                dgStavke.Columns(1).Width = 300
                dgStavke.Columns(2).Width = 80

                txtIznosCena.Visible = True
                txtIznosPdv.Visible = True
                txtIznosRabat.Visible = True
                txtIznosZanaplatu.Visible = True
                txtOsnovica.Visible = True

            Case CheckState.Unchecked
                dgStavke.Columns(3).Visible = False
                dgStavke.Columns(4).Visible = False
                dgStavke.Columns(5).Visible = False

                dgStavke.Columns(1).Width = 480
                dgStavke.Columns(2).Width = 100

                txtIznosCena.Visible = False
                txtIznosPdv.Visible = False
                txtIznosRabat.Visible = False
                txtIznosZanaplatu.Visible = False
                txtOsnovica.Visible = False
        End Select
    End Sub

    Private Sub tlbMagacin_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles tlbMagacin.DropDownClosed
        'Me.RmmartikliBindingSource.Filter = "id_magacin = " & magacin_id(tlbMagacin.Text)
        'Me.Rm_artikliTableAdapter.Update(Me.DataSet1.rm_artikli)
        'Me.Rm_artikliTableAdapter.Fill(Me.DataSet1.rm_artikli)
    End Sub

    Private Sub tlbGrupaArtikla_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tlbGrupaArtikla.SelectedIndexChanged
        Dim filt As String = "id_kategorija = " & grupa_id(RTrim(tlbGrupaArtikla.Text))
        Me.RmartikliBindingSource.Filter = filt '"id_kategorija = " & grupa_id(tlbGrupaArtikla.Text)
        Me.Rm_artikliTableAdapter.Update(Me.DataSet1.rm_artikli)
        Me.Rm_artikliTableAdapter.Fill(Me.DataSet1.rm_artikli)
    End Sub

End Class
