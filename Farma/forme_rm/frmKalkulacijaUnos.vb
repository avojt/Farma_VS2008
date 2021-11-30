Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmKalkulacijaUnos

    Private kol As Decimal = 1
    Private cena As Decimal = 0
    Private c_cena As Decimal = 0
    Private pdv As Decimal = 1
    Private c_pdv As Integer = 18
    Private rabat As Decimal = 0
    Private marza As Decimal = 0
    Private ztroskovi_stavka As Decimal = 0
    Private s_nab_vrednost As Decimal = 0
    Private s_prod_vrednost As Decimal = 0
    Private s_pdv_osnovica As Decimal = 0
    Private s_pdv As Decimal = 0
    Private s_rab As Decimal = 0
    Private s_ztr As Decimal = 0
    Private s_marza As Decimal = 0
    Private s_ztroskovi As Decimal = 0
    Private s_ztros_proporcija As Decimal = 0
    Private valuta As Integer = 0
    Private nab_cena As Decimal = 0
    Private nab_vrednost As Decimal = 0
    Private prod_cena As Decimal = 0
    Private prod_vrednost As Decimal = 0
    Private trenutna_cena As Decimal = 0
    Private trenutna_kolicina As Decimal = 0
    Private sifra As String = ""
    Private naziv As String = ""
    Private indeks As Integer = 0

    Private _pocetak As Boolean = True
    Private _citam_stavke As Boolean = True
    Private _promenjena_marza As Boolean = False
    Private _promenjena_nabav_cena As Boolean = False
    Private _prod_cena_promenjena As Boolean = False
    Private _popunjavam_robu As Boolean = True


    Private Sub frmKalkulacijaUnos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataSet1.app_pdv' table. You can move, or remove it, as needed.
        Me.App_pdvTableAdapter.Fill(Me.DataSet1.app_pdv)
        'TODO: This line of code loads data into the 'DataSet1.rm_artikli' table. You can move, or remove it, as needed.
        Me.Rm_artikliTableAdapter.Fill(Me.DataSet1.rm_artikli)

        pocetak()
        _pocetak = False
    End Sub

    Private Sub pocetak()
        If _kalk_iz_racuna Then
            txtBroj.Text = _kalk_broj
            txtFaktura.Text = _broj_racuna
            txtIznosCena.Text = 0
            txtOsnovica.Text = 0
            txtIznosPdv.Text = 0
            txtIznosRabat.Text = 0
            txtIznosZanaplatu.Text = 0
            txtRazlikaucFarma.Text = 0
            cmbPartneri.Visible = True
            popuni_parnere()
            cmbPartneri.SelectedText = Partner_ime(_id_partner)
            tableZT.Enabled = False
            labProknjizen.Visible = False
            'txtPartneri.Visible = True
            'txtPartneri.Location = New Point(169, 22)
            'txtPartneri.Text = _naziv_partnera

            dateFaktura.Value = _datum_fakturisanja
            dateKalkulacija.Value = _kalk_datum_kalk
            If _troskovi_iz_racuna <> 0 Then
                chkZT.Checked = True
                'tableZT.Enabled = True
                chkIznos.Checked = True
                txtZTIznos.Text = _troskovi_iz_racuna
                raspodeli_troskove()
            End If
            _pocetak = False
            '_citam_stavke = True
            popuni_stavke()
        Else
            txtBroj.Text = Nadji_rb(Imena.tabele.rm_kalkulacija_head.ToString, 1)
            txtIznosCena.Text = 0
            txtOsnovica.Text = 0
            txtIznosPdv.Text = 0
            txtIznosRabat.Text = 0
            txtIznosZanaplatu.Text = 0
            txtPartneri.Visible = False
            txtFaktura.Text = ""
            txtIznosCena.Text = 0
            txtIznosZanaplatu.Text = 0
            txtRazlikaucFarma.Text = 0
            cmbPartneri.Visible = True

            dateFaktura.Value = Today
            dateKalkulacija.Value = Today
        End If


    End Sub

    Private Sub popuni_parnere()
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
                .CommandText = "select dbo.app_partneri.* from dbo.app_partneri"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbPartneri.Items.Add(DR.Item("naziv"))
            Loop
            DR.Close()
        End If
        If cmbPartneri.Items.Count > 0 Then
            cmbPartneri.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub snimi_head()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim ztros As Single = 0

        'Dim DR As SqlDataReader
        If chkZT.CheckState = CheckState.Checked Then
            If chkIznos.CheckState = CheckState.Checked Then
                ztros = CSng(txtZTIznos.Text)
            Else
                If chkProcenat.CheckState = CheckState.Checked Then
                    ztros = CSng(txtUkupnoPrc.Text)
                Else
                    ztros = 0
                End If
            End If
        Else
            ztros = 0
        End If

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_kalkulacija_head_add"
                .Parameters.AddWithValue("@broj", txtBroj.Text)
                If _kalk_iz_racuna Then
                    .Parameters.AddWithValue("@id_dobavljac", Partner(txtPartneri.Text))
                Else
                    .Parameters.AddWithValue("@id_dobavljac", Partner(cmbPartneri.Text))
                End If
                .Parameters.AddWithValue("@datum_fakture", dateFaktura.Value.Date)
                .Parameters.AddWithValue("@datum_kalk", dateKalkulacija.Value.Date)
                .Parameters.AddWithValue("@opis", txtFaktura.Text)
                .Parameters.AddWithValue("@ukupno", CSng(txtIznosCena.Text))
                .Parameters.AddWithValue("@ztroskovi", ztros)
                .Parameters.AddWithValue("@rabat", CSng(txtIznosRabat.Text))
                .Parameters.AddWithValue("@razlika_ucFarma", CSng(txtRazlikaucFarma.Text))
                .Parameters.AddWithValue("@pdv_osnovica", CSng(txtOsnovica.Text))
                .Parameters.AddWithValue("@pdv", CSng(txtIznosPdv.Text))
                .Parameters.AddWithValue("@svega", CSng(txtIznosZanaplatu.Text))
                .Parameters.AddWithValue("@unesena", 0)
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
                If Not IsDBNull(DR.Item("stopa")) Then _porezi.SetValue(CSng(DR.Item("stopa")), i * 3)
                _porezi.SetValue(saberi_osnovice(DR.Item("stopa")), (i * 3) + 1)
                _porezi.SetValue(saberi_pdv(DR.Item("stopa")), (i * 3) + 2)
                i += 1
            Loop
            DR.Close()
        End If
        CM.Dispose()

        _id_kalkulacija = Nadji_id(Imena.tabele.rm_kalkulacija_head.ToString)

        For i = 0 To (_porezi.Length / 3) - 1
            If _porezi((i * 3) + 1) <> 0 Then
                CM = New SqlCommand()
                If CN.State = ConnectionState.Open Then
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "rm_kalkulacija_pdv_add"
                        .Parameters.AddWithValue("@id_kalkulacija", _id_kalkulacija)
                        .Parameters.AddWithValue("@pdv", _porezi(i * 3))
                        .Parameters.AddWithValue("@osnovica", _porezi((i * 3) + 1))
                        .Parameters.AddWithValue("@iznos", _porezi((i * 2) + 2))
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
            If dgStavke.Rows(i).Cells(10).Value = _stopa Then saberi_pdv += dgStavke.Rows(i).Cells(3).Value * dgStavke.Rows(i).Cells(12).Value
        Next
    End Function

    Private Function saberi_osnovice(ByVal _stopa) As Single
        Dim i As Integer

        saberi_osnovice = 0
        For i = 0 To dgStavke.Rows.Count - 2
            If dgStavke.Rows(i).Cells(10).Value = _stopa Then saberi_osnovice += dgStavke.Rows(i).Cells(3).Value * dgStavke.Rows(i).Cells(11).Value
        Next
    End Function

    Private Sub snimi_stavku()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim i As Integer

        _id_kalkulacija = Nadji_id(Imena.tabele.rm_kalkulacija_head.ToString)

        For i = 0 To dgStavke.Rows.Count - 2
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_kalkulacija_stavka_add"
                    .Parameters.AddWithValue("@id_kalkulacija", _id_kalkulacija) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                    .Parameters.AddWithValue("@rb", dgStavke.Rows(i).Cells(0).Value)
                    .Parameters.AddWithValue("@roba_sifra", dgStavke.Rows(i).Cells(1).Value)
                    .Parameters.AddWithValue("@roba", dgStavke.Rows(i).Cells(2).Value)
                    .Parameters.AddWithValue("@kolicina", dgStavke.Rows(i).Cells(3).Value)
                    .Parameters.AddWithValue("@nab_cena", CSng(dgStavke.Rows(i).Cells(4).Value))
                    .Parameters.AddWithValue("@rabat", CSng(dgStavke.Rows(i).Cells(5).Value))
                    .Parameters.AddWithValue("@zav_troskovi", CSng(dgStavke.Rows(i).Cells(6).Value))
                    .Parameters.AddWithValue("@cena_kostanja", CSng(dgStavke.Rows(i).Cells(7).Value))
                    .Parameters.AddWithValue("@nab_vred", CSng(dgStavke.Rows(i).Cells(8).Value))
                    .Parameters.AddWithValue("@marza", CSng(dgStavke.Rows(i).Cells(9).Value))
                    .Parameters.AddWithValue("@pdv", dgStavke.Rows(i).Cells(10).Value)
                    .Parameters.AddWithValue("@prod_cena", CSng(dgStavke.Rows(i).Cells(11).Value))
                    .Parameters.AddWithValue("@pdv_iznos", CSng(dgStavke.Rows(i).Cells(12).Value))
                    .Parameters.AddWithValue("@prod_vred", CSng(dgStavke.Rows(i).Cells(13).Value))
                    .ExecuteScalar()
                End With
            End If
            CM.Dispose()
            CN.Close()
        Next
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Select Case e.ClickedItem.Name
            Case "tlbSnimi"
                snimi_head()
                snimi_pdv()
                snimi_stavku()
                'stanje()
                'unesi_robu()
                pocetak()
                dgStavke.Rows.Clear()
            Case "tlbStanje"
                stanje()
                proveri_stanje(_nazivi, dgStavke.Rows.Count - 1)
            Case "tlbProknjizi"
                snimi_head()
                snimi_pdv()
                snimi_stavku()
                kalkulacija()
                'unesi_robu()
                'unesi_kalkulacuju()
                'zatvori_formu()
                'stanje()
                'unesi_racun()
                labProknjizen.Visible = True
            Case "tlbEnd"
                Me.Dispose()
        End Select
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
                .CommandText = "select dbo.app_partneri.* from dbo.app_partneri where naziv = '" & _partner & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                Partner = DR.Item("id_partner")
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
                .CommandText = "select dbo.app_partneri.* from dbo.app_partneri where id_partner = '" & _id & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                Partner_ime = DR.Item("naziv")
            Loop
        End If
        CM.Dispose()
        CN.Close()

        Return Partner_ime

    End Function

#Region "Grid 1"
    'Private Sub dgStavke_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgStavke.MouseHover
    '    If dgStavke.CurrentRow.Displayed Then

    '        popuni_robu(RTrim(dgStavke.CurrentRow.Cells(1).Value.ToString))
    '        'dgStavke.CurrentRow.Tag = naziv
    '        dgStavke.CurrentRow.Cells(1).ToolTipText = naziv
    '    End If
    'End Sub

    Private Sub dgStavke_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgStavke.CellValueChanged

        If Not _pocetak Then
            With dgStavke
                Try
                    Select Case e.ColumnIndex
                        Case 1
                            indeks = e.RowIndex
                            If _novi_artikl And _prod_cena_promenjena Then Exit Sub
                            _popunjavam_robu = True
                            redni_broj()
                            '.Rows(e.RowIndex).Cells(0).Value = e.RowIndex + 1
                            If Not IsNothing(.Rows(e.RowIndex).Cells(1).Value) Then
                                If .Rows(e.RowIndex).Cells(1).Value.ToString <> "" Then

                                    popuni_robu(RTrim(dgStavke.Rows(e.RowIndex).Cells(1).Value.ToString))
                                    '.Rows(e.RowIndex).Cells(1).ToolTipText = naziv

                                    .Rows(e.RowIndex).Cells(2).Value = naziv
                                    .Rows(e.RowIndex).Cells(3).Value = 1
                                    .Rows(e.RowIndex).Cells(4).Value = 0
                                    .Rows(e.RowIndex).Cells(5).Value = 0
                                    .Rows(e.RowIndex).Cells(6).Value = 0
                                    .Rows(e.RowIndex).Cells(7).Value = 0
                                    .Rows(e.RowIndex).Cells(8).Value = 0
                                    .Rows(e.RowIndex).Cells(9).Value = 0
                                    .Rows(e.RowIndex).Cells(10).Value = c_pdv
                                    .Rows(e.RowIndex).Cells(11).Value = trenutna_cena
                                    .Rows(e.RowIndex).Cells(12).Value = trenutna_cena * c_pdv / 100
                                    .Rows(e.RowIndex).Cells(13).Value = trenutna_cena * CSng(dgStavke.Rows(e.RowIndex).Cells(3).Value)
                                    _popunjavam_robu = False
                                Else
                                    cena = 0
                                End If
                            End If
                        Case 4
                            _promenjena_nabav_cena = True
                        Case 5
                            _promenjena_nabav_cena = True
                        Case 6
                            _promenjena_nabav_cena = True
                        Case 9
                            If Not _popunjavam_robu Then
                                _promenjena_marza = True
                                _prod_cena_promenjena = True
                            End If
                        Case 11
                            If Not _popunjavam_robu Then
                                _prod_cena_promenjena = True
                            End If
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
                                rabat = cena * CSng(.Rows(e.RowIndex).Cells(5).Value) / 100
                            Else
                                rabat = 0
                            End If
                        End If

                        If Not IsNothing(.Rows(e.RowIndex).Cells(9).Value) Then
                            If .Rows(e.RowIndex).Cells(9).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(9).Value.ToString) Then
                                marza = CSng(.Rows(e.RowIndex).Cells(9).Value)
                            Else
                                marza = 0
                            End If
                        End If

                        If Not IsNothing(.Rows(e.RowIndex).Cells(10).Value) Then
                            If .Rows(e.RowIndex).Cells(10).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(10).Value.ToString) Then
                                pdv = 1 + (CSng(.Rows(e.RowIndex).Cells(10).Value) / 100)
                            Else
                                pdv = 1
                            End If
                        End If
                        If Not IsNothing(.Rows(e.RowIndex).Cells(11).Value) Then
                            If .Rows(e.RowIndex).Cells(11).Value.ToString <> "" And jeste_broj(.Rows(e.RowIndex).Cells(11).Value.ToString) Then
                                'Dim prc As Single = CSng(.Rows(e.RowIndex).Cells(11).Value)
                                'If _prod_cena_promenjena And Not _promenjena_nabav_cena And Not _citam_stavke Then
                                '    _roba_sifra = sifra
                                '    _roba_cena = prc
                                '    _roba_kolicina = CSng(.Rows(e.RowIndex).Cells(3).Value)
                                '    _roba_nabavna = CSng(.Rows(e.RowIndex).Cells(7).Value)
                                '    _roba_rabat = CSng(.Rows(e.RowIndex).Cells(5).Value)
                                '    rb_stavke = e.RowIndex
                                '    trenutna_cena = CSng(.Rows(e.RowIndex).Cells(11).Value)
                                '    Dim mForm As New frmPromenjena_cena
                                '    mForm.Show()
                                'End If
                                '_prod_cena_promenjena = False
                                prod_cena = .Rows(e.RowIndex).Cells(11).Value.ToString
                            Else
                                prod_cena = 0
                            End If
                        End If
                    Else
                        pdv = 1 + (c_pdv / 100)
                        prod_cena = trenutna_cena
                    End If

                    nab_cena = cena - rabat + ztroskovi_stavka
                    nab_vrednost = kol * nab_cena

                    If _promenjena_marza Then
                        'marza = CSng(.Rows(e.RowIndex).Cells(9).Value)
                        prod_cena = nab_cena * (1 + (marza / 100))
                    ElseIf _promenjena_nabav_cena Then
                        If nab_cena = 0 Then
                            marza = 0
                        Else
                            marza = ((prod_cena / nab_cena) - 1) * 100
                        End If
                        prod_cena = CSng(.Rows(e.RowIndex).Cells(11).Value)
                    ElseIf _prod_cena_promenjena Then
                        If nab_cena = 0 Then
                            marza = 0
                        Else
                            marza = ((prod_cena / nab_cena) - 1) * 100
                        End If
                        'prod_cena = CSng(.Rows(e.RowIndex).Cells(11).Value)
                    End If

                    prod_vrednost = kol * prod_cena * pdv

                    .Rows(e.RowIndex).Cells(7).Value = nab_cena
                    .Rows(e.RowIndex).Cells(8).Value = nab_vrednost
                    .Rows(e.RowIndex).Cells(9).Value = marza
                    .Rows(e.RowIndex).Cells(11).Value = prod_cena
                    .Rows(e.RowIndex).Cells(12).Value = prod_cena * (pdv - 1)
                    .Rows(e.RowIndex).Cells(13).Value = prod_vrednost

                    _promenjena_marza = False
                    _promenjena_nabav_cena = False
                    _prod_cena_promenjena = False

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

    Private Sub dgStavke_CellValueNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValueEventArgs) Handles dgStavke.CellValueNeeded
        ' If this is the row for new records, no values are needed.
        If e.RowIndex = Me.dgStavke.RowCount - 1 Then
            Return
        End If
        If store.ContainsKey(e.RowIndex) Then
            e.Value = store(e.RowIndex)
        ElseIf newRowNeeded AndAlso e.RowIndex = dgStavke.RowCount Then ' numberOfRows Then
            If dgStavke.IsCurrentCellInEditMode Then
                e.Value = initialValue
            Else
                e.Value = String.Empty
            End If
        Else
            e.Value = e.RowIndex
        End If
    End Sub

    Private Sub dgStavke_CellValuePushed(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValueEventArgs) Handles dgStavke.CellValuePushed
        store.Add(e.RowIndex, CInt(e.Value))
    End Sub

    Dim newRowNeeded As Boolean
    Private Sub dgStavke_NewRowNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgStavke.NewRowNeeded
        newRowNeeded = True
        dgStavke.Rows.Add(e.Row)
        dgStavke.Rows(e.Row.Index).Cells(2).Value = 1 'kolicina
        dgStavke.Rows(e.Row.Index).Cells(3).Value = 0 'cena
        dgStavke.Rows(e.Row.Index).Cells(4).Value = 0 'rabat
        dgStavke.Rows(e.Row.Index).Cells(5).Value = 0 'marza
        dgStavke.Rows(e.Row.Index).Cells(7).Value = 0 'iznos
        pdv = 1
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
                'sifra = _roba ' DR.Item("sifra")
                'naziv = DR.Item("naziv")
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
        Try
            For i = 0 To dgStavke.Rows.Count - 2
                _nazivi.SetValue(dgStavke.Rows(i).Cells(1).Value.ToString, i, 0)
                _nazivi.SetValue(dgStavke.Rows(i).Cells(2).Value.ToString, i, 1)
                _nazivi.SetValue(dgStavke.Rows(i).Cells(3).Value.ToString, i, 2)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub kalkulacija()
        Dim i As Integer
        Try
            For i = 0 To dgStavke.Rows.Count - 2
                Dim CN As SqlConnection = New SqlConnection(CNNString)
                Dim CM As New SqlCommand
                Dim DR As SqlDataReader

                CN.Open()
                CM = New SqlCommand()
                If CN.State = ConnectionState.Open Then
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.Text
                        .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli where dbo.rm_artikli.sifra = '" & _
                                    dgStavke.Rows(i).Cells(1).Value & "'"
                        DR = .ExecuteReader
                    End With
                    Do While DR.Read
                        trenutna_cena = DR.Item("cena")
                        trenutna_kolicina = DR.Item("kolicina")

                        roba(DR.Item("id_roba"), _
                            CSng(dgStavke.Rows(i).Cells(4).Value), _
                            CSng(dgStavke.Rows(i).Cells(5).Value), _
                            CSng(dgStavke.Rows(i).Cells(9).Value), _
                            CSng(dgStavke.Rows(i).Cells(11).Value), _
                            DR.Item("kolicina") + dgStavke.Rows(i).Cells(3).Value)
                    Loop
                End If
                CM.Dispose()
                CN.Close()
            Next
            unesi_kalkulacuju()
            If _kalk_iz_racuna Then
                stanje()
                unesi_racun()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub unesi_robu()
    '    Dim i As Integer
    '    Try
    '        For i = 0 To dgStavke.Rows.Count - 2
    '            Dim CN As SqlConnection = New SqlConnection(CNNString)
    '            Dim CM As New SqlCommand
    '            Dim DR As SqlDataReader

    '            CN.Open()
    '            CM = New SqlCommand()
    '            If CN.State = ConnectionState.Open Then
    '                With CM
    '                    .Connection = CN
    '                    .CommandType = CommandType.Text
    '                    .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli where dbo.rm_artikli.sifra = '" & _nazivi(i, 0) & "'"
    '                    DR = .ExecuteReader
    '                End With
    '                Do While DR.Read
    '                    trenutna_cena = DR.Item("cena")
    '                    trenutna_kolicina = DR.Item("kolicina")

    '                    roba(DR.Item("id_roba"), DR.Item("kolicina") + _nazivi(i, 2))
    '                Loop
    '            End If
    '            CM.Dispose()
    '            CN.Close()
    '        Next
    '        If _kalk_iz_racuna Then unesi_racun()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub roba(ByVal id, ByVal nab, ByVal rab, ByVal mar, ByVal pro, ByVal kol)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_roba_kalkulacija"
                .Parameters.AddWithValue("@id_roba", id)
                .Parameters.AddWithValue("@nabavna", nab)
                .Parameters.AddWithValue("@rabat", rab)
                .Parameters.AddWithValue("@marza", mar)
                .Parameters.AddWithValue("@cena", pro)
                .Parameters.AddWithValue("@kolicina", kol)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub unesi_racun()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim CM1 As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()

        If CN.State = ConnectionState.Open Then
            If Not _kalk_iz_racuna Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = "select * from ulazni_racuni_head where id_partner = " _
                                & Partner(cmbPartneri.Text) & " and br_fakture = '" & txtFaktura.Text & "'"
                    .ExecuteScalar()
                    DR = .ExecuteReader
                End With

                Do While DR.Read
                    _id_racun = DR.Item("id_racun_head")
                Loop
                DR.Close()
                CM.Dispose()
            End If

            If _id_racun <> "" Then
                CM1 = New SqlCommand()
                With CM1
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_unesi_racun"
                    .Parameters.AddWithValue("@id_racun_head", _id_racun)
                    .Parameters.AddWithValue("@unesen", 1)
                    .ExecuteScalar()
                End With
                CM1.Dispose()
                _unesen = True
            End If
        End If

    End Sub

    Private Sub unesi_kalkulacuju()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        _id_kalkulacija = Nadji_id(Imena.tabele.rm_kalkulacija_head.ToString)

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_kalkulacija_unesi"
                .Parameters.AddWithValue("@id_kalkulacija", _id_kalkulacija)
                .Parameters.AddWithValue("@unesena", 1)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
        _unesen = True
        zatvori_formu()
    End Sub

    Private Sub zatvori_formu()
        If _unesen Then
            Panel1.Enabled = False
            dgStavke.AllowUserToAddRows = False
            dgStavke.Enabled = False

            ToolStrip1.Items(0).Enabled = False
            ToolStrip1.Items(1).Enabled = False
            ToolStrip1.Items(2).Enabled = False

            txtIznosCena.Enabled = False
            txtIznosPdv.Enabled = False
            txtIznosRabat.Enabled = False
            txtIznosZanaplatu.Enabled = False
            txtOsnovica.Enabled = False
        End If
    End Sub

    Private Sub popuni_stavke()

        With dgStavke
            Dim i As Integer = 0

            _citam_stavke = True
            For i = 0 To _kalkulacija_broj_stavki - 1
                .Rows.Add(1)
                .Rows(i).Cells(0).Value = i + 1
                .Rows(i).Cells(1).Value = _artikli(i, 0)
                .Rows(i).Cells(3).Value = CSng(_artikli(i, 1))
                .Rows(i).Cells(4).Value = CSng(_artikli(i, 2))
                .Rows(i).Cells(5).Value = CSng(_artikli(i, 3))
                .Rows(i).Cells(10).Value = CInt(_artikli(i, 4))
            Next
        End With
        _citam_stavke = False
    End Sub

#Region "Troskovi"

    Private Sub chkProcenat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProcenat.CheckedChanged
        Select Case chkProcenat.CheckState
            Case CheckState.Checked
                chkIznos.Checked = False
                txtZTIznos.Enabled = False
            Case CheckState.Unchecked
                chkIznos.Checked = True
                txtZTIznos.Enabled = True
                txtZTIznos.Text = 0
                txtProporcija.Text = 0
        End Select
    End Sub

    Private Sub chkIznos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIznos.CheckedChanged
        Select Case chkIznos.CheckState
            Case CheckState.Checked
                chkProcenat.Checked = False
                txtZTProcenat.Enabled = False
            Case CheckState.Unchecked
                chkProcenat.Checked = True
                txtZTProcenat.Enabled = True
                txtZTProcenat.Text = 0
        End Select
    End Sub

    Private Sub chkZT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkZT.CheckedChanged
        Select Case chkZT.CheckState
            Case CheckState.Checked
                tableZT.Enabled = True
                chkProcenat.Checked = True
            Case CheckState.Unchecked
                tableZT.Enabled = False
        End Select
    End Sub

    Private Sub raspodeli_troskove()
        Dim i As Integer

        If chkIznos.CheckState = CheckState.Checked Then
            If txtZTIznos.Text <> "" Then
                If jeste_broj(txtZTIznos.Text) Then
                    Dim suma As Single = 0
                    With dgStavke
                        For i = 0 To .RowCount - 2
                            Dim kol As Single = .Rows(i).Cells(3).Value
                            Dim cena As Single = .Rows(i).Cells(4).Value
                            Dim rabat As Integer = .Rows(i).Cells(5).Value
                            suma += kol * (cena * (1 - (rabat / 100)))
                        Next

                        If suma > 0 Then
                            txtProporcija.Text = CStr(CSng(txtZTIznos.Text) / suma * 100) & "%"
                        Else
                            txtProporcija.Text = CSng(txtZTIznos.Text)
                        End If

                        For i = 0 To .RowCount - 2
                            If suma > 0 Then
                                ztroskovi_stavka = .Rows(i).Cells(4).Value * CSng(txtZTIznos.Text) / suma
                                .Rows(i).Cells(6).Value = .Rows(i).Cells(4).Value * CSng(txtZTIznos.Text) / suma
                            Else
                                ztroskovi_stavka = CSng(txtZTIznos.Text)
                                .Rows(i).Cells(6).Value = CSng(txtZTIznos.Text)
                            End If
                        Next
                    End With
                Else
                    MsgBox("Uneli ste slovni karakter ili neki drugi znak." & vbLf & "Molimo Vas ispravite gresku", MsgBoxStyle.OkOnly)
                End If
            Else
                ztroskovi_stavka = 0
                dgStavke.Rows(i).Cells(6).Value = 0
            End If

        Else 'na procenat
            If chkProcenat.CheckState = CheckState.Checked Then
                If txtZTProcenat.Text <> "" Then
                    If jeste_broj(txtZTProcenat.Text) Then
                        Dim suma As Single = 0
                        With dgStavke
                            For i = 0 To .RowCount - 2
                                Dim kol As Single = .Rows(i).Cells(3).Value
                                Dim cena As Single = .Rows(i).Cells(4).Value
                                Dim rabat As Integer = .Rows(i).Cells(5).Value
                                suma += kol * (cena * (1 - (rabat / 100)))
                            Next

                            If suma > 0 Then
                                txtUkupnoPrc.Text = suma * CSng(txtZTProcenat.Text) / 100
                            Else
                                txtUkupnoPrc.Text = 0
                            End If

                            For i = 0 To .RowCount - 2
                                If suma > 0 Then
                                    ztroskovi_stavka = .Rows(i).Cells(4).Value * CSng(txtZTProcenat.Text) / 100
                                    .Rows(i).Cells(6).Value = .Rows(i).Cells(4).Value * CSng(txtZTProcenat.Text) / 100
                                Else
                                    ztroskovi_stavka = 0
                                    .Rows(i).Cells(6).Value = 0
                                End If
                            Next
                        End With
                    Else
                        MsgBox("Uneli ste slovni karakter ili neki drugi znak." & vbLf & "Molimo Vas ispravite gresku", MsgBoxStyle.OkOnly)
                    End If
                Else
                    ztroskovi_stavka = 0
                    dgStavke.Rows(i).Cells(6).Value = 0
                End If
            End If
        End If
    End Sub

    Private Sub txtZTIznos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZTIznos.TextChanged
        raspodeli_troskove()
    End Sub

    Private Sub txtZTProcenat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZTProcenat.TextChanged
        raspodeli_troskove()
    End Sub
#End Region

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
            For i = 0 To dgStavke.Rows.Count - 2
                Dim kol As Decimal = CDec(dgStavke.Rows(i).Cells(3).Value)
                Dim cena As Decimal = CDec(dgStavke.Rows(i).Cells(4).Value)
                Dim rab As Decimal ''= CSng(dgStavke.Rows(i).Cells(5).Value)
                Dim ztr As Decimal = CDec(dgStavke.Rows(i).Cells(6).Value)
                'Dim nabcena As Single = CSng(dgStavke.Rows(i).Cells(7).Value)
                Dim nabvr As Decimal = CDec(dgStavke.Rows(i).Cells(8).Value)
                Dim mar As Decimal = CDec(dgStavke.Rows(i).Cells(9).Value)
                Dim pdv As Decimal = CDec(dgStavke.Rows(i).Cells(10).Value)
                Dim pr_cena As Decimal = CDec(dgStavke.Rows(i).Cells(11).Value)
                Dim pdv_iznos As Decimal = CDec(dgStavke.Rows(i).Cells(12).Value)
                Dim pr_vred As Decimal = CDec(dgStavke.Rows(i).Cells(13).Value)

                rab = cena * CDec(dgStavke.Rows(i).Cells(5).Value) / 100

                s_nab_vrednost += nabvr
                s_rab += rab
                s_marza += (nabvr * mar / 100)
                's_pdv += (kol * pr_vred * pdv / 100)
                s_pdv += kol * pr_cena * pdv / 100
                s_prod_vrednost += pr_vred
                s_pdv_osnovica += kol * pr_cena

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'If Not _unesen Then
        txtIznosCena.Text = Decimal.Round(s_nab_vrednost, 2)
        txtIznosRabat.Text = Decimal.Round(s_rab, 2)
        txtRazlikaucFarma.Text = Decimal.Round(s_marza, 2)
        txtOsnovica.Text = Decimal.Round(s_pdv_osnovica, 2)
        txtIznosPdv.Text = Decimal.Round(s_pdv, 2)
        txtIznosZanaplatu.Text = Decimal.Round(s_prod_vrednost, 2)
        'End If

    End Sub

    Private Sub btnOsvezi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOsvezi.Click
        Me.Rm_artikliTableAdapter.Update(Me.DataSet1.rm_artikli)
        Me.Rm_artikliTableAdapter.Fill(Me.DataSet1.rm_artikli)
        If _novi_artikl Then
            dgStavke.Rows(indeks).Cells(1).Value = _novi_artikl_sifra
            _prod_cena_promenjena = False
            _novi_artikl = False
        End If
        popuni_parnere()
    End Sub

    Private Sub btnNoviArtkl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoviArtkl.Click
        Dim mForm As New cntArtikliUnos
        mForm.Show()
    End Sub

    Private Sub btnNoviPartner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoviPartner.Click
        Dim mForm As New frmPartneriUnos
        mForm.Show()
    End Sub

    
End Class