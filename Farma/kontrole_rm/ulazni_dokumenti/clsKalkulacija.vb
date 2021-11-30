
Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class clsKalkulacija


    Private Sub popuni_parnere()
        'Dim CN As SqlConnection = New SqlConnection(CNNString)
        'Dim CM As New SqlCommand
        'Dim DR As SqlDataReader

        'cmbPartneri.Items.Clear()

        'CN.Open()
        'CM = New SqlCommand()
        'If CN.State = ConnectionState.Open Then
        '    With CM
        '        .Connection = CN
        '        .CommandType = CommandType.Text
        '        .CommandText = "select dbo.app_partneri.* from dbo.app_partneri"
        '        DR = .ExecuteReader
        '    End With
        '    Do While DR.Read
        '        cmbPartneri.Items.Add(DR.Item("partner_naziv"))
        '    Loop
        '    DR.Close()
        'End If
        'If cmbPartneri.Items.Count > 0 Then
        '    cmbPartneri.SelectedIndex = 0
        'End If
        'CM.Dispose()
        'CN.Close()
    End Sub

    Private Sub popuni_magacine()
        'Dim CN As SqlConnection = New SqlConnection(CNNString)
        'Dim CM As New SqlCommand
        'Dim DR As SqlDataReader

        'cmbMagacin.Items.Clear()
        'cmbMagacin.Items.Add("")
        'CN.Open()
        'CM = New SqlCommand()
        'If CN.State = ConnectionState.Open Then
        '    With CM
        '        .Connection = CN
        '        .CommandType = CommandType.Text
        '        .CommandText = "select dbo.rm_magacin.* from dbo.rm_magacin"
        '        DR = .ExecuteReader
        '    End With
        '    Do While DR.Read
        '        cmbMagacin.Items.Add(DR.Item("magacin_naziv"))
        '    Loop
        '    DR.Close()
        'End If
        'If cmbMagacin.Items.Count > 0 Then
        '    cmbMagacin.SelectedIndex = 0
        'End If
        'CM.Dispose()
        'CN.Close()
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
                .CommandText = "select dbo.app_partneri.* from dbo.app_partneri where partner_naziv = '" & _partner & "'"
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

    Private Sub redni_broj()
        'Dim i As Integer

        'For i = 0 To dgStavke.RowCount - 2
        '    dgStavke.Rows(i).Cells(0).Value = i + 1
        'Next
    End Sub

    Private Sub popuni_robu(ByVal _roba As String)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        'Dim DR As SqlDataReader

        'sifra = ""
        'naziv = ""
        'c_JM = ""
        'c_Grupa = ""
        'c_cena_nab = 0
        'c_cena_vp = 0
        'c_cena_mp = 0
        ''trenutna_kolicina = 0
        'c_pdv = 1
        'c_rabat = 0
        'c_marza = 0

        'CN.Open()
        'If CN.State = ConnectionState.Open Then
        '    CM = New SqlCommand()
        '    With CM
        '        .Connection = CN
        '        .CommandType = CommandType.Text
        '        .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli where dbo.rm_artikli.artikl_sifra = '" & RTrim(_roba) & "'"
        '        DR = .ExecuteReader
        '    End With

        '    'Dim id As Integer = 0
        '    Dim id_pdv As Integer = 0
        '    Dim id_grupa As Integer = 0
        '    Dim id_jm As Integer = 0
        '    Do While DR.Read
        '        If Not IsDBNull(DR.Item("id_artikl")) Then lId = DR.Item("id_artikl")
        '        If Not IsDBNull(DR.Item("artikl_naziv")) Then naziv = DR.Item("artikl_naziv")
        '        If Not IsDBNull(DR.Item("id_grup_artikla")) Then id_grupa = DR.Item("id_grup_artikla")
        '        If Not IsDBNull(DR.Item("id_jm")) Then id_jm = DR.Item("id_jm")
        '        sifra = RTrim(_roba)
        '    Loop
        '    DR.Close()
        '    CM.Dispose()

        '    CM = New SqlCommand()
        '    With CM
        '        .Connection = CN
        '        .CommandType = CommandType.Text
        '        .CommandText = "select dbo.app_jm.* from dbo.app_jm where id_jm = " & id_jm
        '        DR = .ExecuteReader
        '    End With
        '    Do While DR.Read
        '        If Not IsDBNull(DR.Item("jm_oznaka")) Then c_JM = DR.Item("jm_oznaka")
        '        If Not IsDBNull(DR.Item("jm_br_decimala")) Then
        '            broj_decimala.SetValue(DR.Item("jm_br_decimala"), indeks)
        '        Else
        '            broj_decimala.SetValue(3, indeks)
        '        End If
        '    Loop
        '    DR.Close()
        '    CM.Dispose()

        '    CM = New SqlCommand()
        '    With CM
        '        .Connection = CN
        '        .CommandType = CommandType.Text
        '        .CommandText = "select dbo.rm_artikli_cene.* from dbo.rm_artikli_cene where id_artikl = " & lId & " and id_magacin = " & magacinID
        '        DR = .ExecuteReader
        '    End With

        '    Dim id_cene As Integer = 0
        '    Do While DR.Read
        '        id_cene = DR.Item("id_cena_robe")
        '        If Not IsDBNull(DR.Item("cena_nab_zadnja")) Then c_cena_nab = DR.Item("cena_nab_zadnja")
        '        If Not IsDBNull(DR.Item("cena_vp1")) Then c_cena_vp = DR.Item("cena_vp1")
        '        'If Not IsDBNull(DR.Item("pdv")) Then c_pdv = DR.Item("pdv")
        '        If Not IsDBNull(DR.Item("rabat")) Then c_rabat = DR.Item("rabat")
        '        'If Not IsDBNull(DR.Item("marza")) Then c_marza = DR.Item("marza")
        '        'If Not IsDBNull(DR.Item("cena_mp")) Then c_cena_mp = DR.Item("cena_mp")
        '    Loop
        '    DR.Close()
        '    CM.Dispose()

        '    'If id_cene = 0 Then
        '    'MsgBox("Traženom artiklu u ovom magacinu do sada nije zadata cena.", MsgBoxStyle.OkOnly)
        '    CM = New SqlCommand()
        '    With CM
        '        .Connection = CN
        '        .CommandType = CommandType.Text
        '        .CommandText = "select dbo.app_artikl_grupa.* from dbo.app_artikl_grupa where id_grup_artikla = " & id_grupa '& " and id_magacin = " & magacinID
        '        DR = .ExecuteReader
        '    End With
        '    Do While DR.Read
        '        If Not IsDBNull(DR.Item("gr_artikla_skraceno")) Then c_Grupa = RTrim(DR.Item("gr_artikla_skraceno"))
        '        If Not IsDBNull(DR.Item("gr_artikla_pdv")) Then c_pdv = DR.Item("gr_artikla_pdv")
        '        If Not IsDBNull(DR.Item("gr_artikla_marza")) Then c_marza = DR.Item("gr_artikla_marza")
        '    Loop
        '    DR.Close()
        '    CM.Dispose()
        '    'End If

        'End If

        'CN.Close()
    End Sub

    Private Sub lager()
        'Dim CN As SqlConnection = New SqlConnection(CNNString)
        'Dim CM As New SqlCommand
        'Dim DR As SqlDataReader

        'lSifra = ""
        'lNaziv = ""
        'lKol = 0
        'lCena = 0

        'CN.Open()
        'If CN.State = ConnectionState.Open Then
        '    CM = New SqlCommand()
        '    With CM
        '        .Connection = CN
        '        .CommandType = CommandType.Text
        '        .CommandText = "select * from dbo.rm_dnevni_promet_stavka where dbo.rm_dnevni_promet_stavka.id_artikl = " & lId '& " and dbo.rm_dnevni_promet_stavka.dp_zakljucen = 0"
        '        DR = .ExecuteReader
        '    End With

        '    Do While DR.Read
        '        If Not IsDBNull(DR.Item("dp_art_stanje")) Then lKol = DR.Item("dp_art_stanje")
        '        If Not IsDBNull(DR.Item("dp_art_cena")) Then lCena = DR.Item("dp_art_cena")
        '    Loop
        '    DR.Close()
        '    CM.Dispose()

        '    CM = New SqlCommand()
        '    With CM
        '        .Connection = CN
        '        .CommandType = CommandType.Text
        '        .CommandText = "select * from dbo.rm_artikli where dbo.rm_artikli.id_artikl = " & lId
        '        DR = .ExecuteReader
        '    End With
        '    Do While DR.Read
        '        If Not IsDBNull(DR.Item("artikl_sifra")) Then lSifra = DR.Item("artikl_sifra")
        '        If Not IsDBNull(DR.Item("artikl_naziv")) Then lNaziv = DR.Item("artikl_naziv")
        '    Loop
        '    DR.Close()
        '    CM.Dispose()

        'End If
        'CN.Close()

        'labLager.Text = RTrim(lSifra) & " - " & lNaziv & " - kol: " & lKol & " - cena: " & lCena

    End Sub

    Private Sub zatvori_formu()
        'If _unesen Then
        '    panHeader.Enabled = False
        '    Panel1.Enabled = False
        '    cmbMagacin.Enabled = False

        '    dgStavke.AllowUserToAddRows = False
        '    dgStavke.Enabled = False
        '    lvLista.Enabled = False

        '    txtIznosCena.Enabled = False
        '    txtIznosPdv.Enabled = False
        '    txtIznosRabat.Enabled = False
        '    txtIznosZanaplatu.Enabled = False
        '    txtOsnovica.Enabled = False

        '    btnSnimi.Enabled = False
        '    btnZakljuci.Enabled = False
        'End If
    End Sub

    Private Sub popuni_stavke()

        'With dgStavke
        '    Dim i As Integer = 0

        '    _citam_stavke = True
        '    For i = 0 To _kalkulacija_broj_stavki - 1
        '        .Rows.Add(1)
        '        .Rows(i).Cells(0).Value = i + 1
        '        .Rows(i).Cells(1).Value = _artikli(i, 0)
        '        .Rows(i).Cells(3).Value = CSng(_artikli(i, 1))
        '        .Rows(i).Cells(4).Value = CSng(_artikli(i, 2))
        '        .Rows(i).Cells(5).Value = CSng(_artikli(i, 3))
        '        .Rows(i).Cells(10).Value = CInt(_artikli(i, 4))
        '    Next
        'End With
        '_citam_stavke = False
    End Sub

#Region "Troskovi"

    'Private Sub chkProcenat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProcenat.CheckedChanged
    '    'Select Case chkProcenat.CheckState
    '    '    Case CheckState.Checked
    '    '        chkIznos.Checked = False
    '    '        txtZTIznos.Enabled = False
    '    '    Case CheckState.Unchecked
    '    '        chkIznos.Checked = True
    '    '        txtZTIznos.Enabled = True
    '    '        txtZTIznos.Text = 0
    '    '        txtProporcija.Text = 0
    '    'End Select
    'End Sub

    'Private Sub chkIznos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIznos.CheckedChanged
    '    Select Case chkIznos.CheckState
    '        Case CheckState.Checked
    '            chkProcenat.Checked = False
    '            txtZTProcenat.Enabled = False
    '        Case CheckState.Unchecked
    '            chkProcenat.Checked = True
    '            txtZTProcenat.Enabled = True
    '            txtZTProcenat.Text = 0
    '    End Select
    'End Sub

    'Private Sub chkZT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkZT.CheckedChanged
    '    Select Case chkZT.CheckState
    '        Case CheckState.Checked
    '            tableZT.Enabled = True
    '            chkProcenat.Checked = True
    '        Case CheckState.Unchecked
    '            tableZT.Enabled = False
    '    End Select
    'End Sub

    Private Sub raspodeli_troskove()
        'Dim i As Integer

        'If chkIznos.CheckState = CheckState.Checked Then
        '    If txtZTIznos.Text <> "" Then
        '        If jeste_broj(txtZTIznos.Text) Then
        '            Dim suma As Single = 0
        '            With dgStavke
        '                For i = 0 To .RowCount - 2
        '                    Dim kol As Single = .Rows(i).Cells(3).Value
        '                    Dim cena As Single = .Rows(i).Cells(4).Value
        '                    Dim rabat As Integer = .Rows(i).Cells(5).Value
        '                    suma += kol * (cena * (1 - (rabat / 100)))
        '                Next

        '                If suma > 0 Then
        '                    txtProporcija.Text = CStr(CSng(txtZTIznos.Text) / suma * 100) & "%"
        '                Else
        '                    txtProporcija.Text = CSng(txtZTIznos.Text)
        '                End If

        '                For i = 0 To .RowCount - 2
        '                    If suma > 0 Then
        '                        ztroskovi_stavka = .Rows(i).Cells(4).Value * CSng(txtZTIznos.Text) / suma
        '                        .Rows(i).Cells(6).Value = .Rows(i).Cells(4).Value * CSng(txtZTIznos.Text) / suma
        '                    Else
        '                        ztroskovi_stavka = CSng(txtZTIznos.Text)
        '                        .Rows(i).Cells(6).Value = CSng(txtZTIznos.Text)
        '                    End If
        '                Next
        '            End With
        '        Else
        '            MsgBox("Uneli ste slovni karakter ili neki drugi znak." & vbLf & "Molimo Vas ispravite gresku", MsgBoxStyle.OkOnly)
        '        End If
        '    Else
        '        ztroskovi_stavka = 0
        '        dgStavke.Rows(i).Cells(6).Value = 0
        '    End If

        'Else 'na procenat
        '    If chkProcenat.CheckState = CheckState.Checked Then
        '        If txtZTProcenat.Text <> "" Then
        '            If jeste_broj(txtZTProcenat.Text) Then
        '                Dim suma As Single = 0
        '                With dgStavke
        '                    For i = 0 To .RowCount - 2
        '                        Dim kol As Single = .Rows(i).Cells(3).Value
        '                        Dim cena As Single = .Rows(i).Cells(4).Value
        '                        Dim rabat As Integer = .Rows(i).Cells(5).Value
        '                        suma += kol * (cena * (1 - (rabat / 100)))
        '                    Next

        '                    If suma > 0 Then
        '                        txtUkupnoPrc.Text = suma * CSng(txtZTProcenat.Text) / 100
        '                    Else
        '                        txtUkupnoPrc.Text = 0
        '                    End If

        '                    For i = 0 To .RowCount - 2
        '                        If suma > 0 Then
        '                            ztroskovi_stavka = .Rows(i).Cells(4).Value * CSng(txtZTProcenat.Text) / 100
        '                            .Rows(i).Cells(6).Value = .Rows(i).Cells(4).Value * CSng(txtZTProcenat.Text) / 100
        '                        Else
        '                            ztroskovi_stavka = 0
        '                            .Rows(i).Cells(6).Value = 0
        '                        End If
        '                    Next
        '                End With
        '            Else
        '                MsgBox("Uneli ste slovni karakter ili neki drugi znak." & vbLf & "Molimo Vas ispravite gresku", MsgBoxStyle.OkOnly)
        '            End If
        '        Else
        '            ztroskovi_stavka = 0
        '            dgStavke.Rows(i).Cells(6).Value = 0
        '        End If
        '    End If
        'End If
    End Sub

    'Private Sub txtZTIznos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZTIznos.TextChanged
    '    raspodeli_troskove()
    'End Sub

    'Private Sub txtZTProcenat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZTProcenat.TextChanged
    '    raspodeli_troskove()
    'End Sub
#End Region

    Private Sub preracunaj()
        'Dim i As Integer

        's_nab_vrednost = 0
        's_pdv = 0
        's_rab = 0
        's_ztr = 0
        's_marza = 0
        's_prod_vrednost = 0
        's_pdv_osnovica = 0

        'Try
        '    For i = 0 To dgStavke.Rows.Count - 2
        '        Dim kol As Single = CDec(dgStavke.Rows(i).Cells(5).Value)
        '        Dim cena As Single = CDec(dgStavke.Rows(i).Cells(6).Value)
        '        Dim rab As Decimal ''= CSng(dgStavke.Rows(i).Cells(7).Value)
        '        Dim ztr As Single = CDec(dgStavke.Rows(i).Cells(8).Value)
        '        'Dim nabcena As Single = CSng(dgStavke.Rows(i).Cells(9).Value)
        '        Dim nabvr As Single = CDec(dgStavke.Rows(i).Cells(10).Value)
        '        Dim mar As Single = 0 ' CDec(dgStavke.Rows(i).Cells(11).Value)
        '        Dim pdv As Single = CDec(dgStavke.Rows(i).Cells(12).Value)
        '        Dim mp_cena As Single = CDec(dgStavke.Rows(i).Cells(13).Value)
        '        Dim pdv_iznos As Single = CDec(dgStavke.Rows(i).Cells(14).Value)
        '        Dim pr_vred As Single = CDec(dgStavke.Rows(i).Cells(15).Value)

        '        rab = cena * CDec(dgStavke.Rows(i).Cells(7).Value) / 100

        '        s_nab_vrednost += CDec(nabvr)
        '        s_rab += rab
        '        s_marza += 0 ' (nabvr * mar / 100)
        '        's_pdv += (kol * pr_vred * pdv / 100)
        '        s_pdv += CDec(kol * (mp_cena * (1 - (1 / (1 + (pdv / 100))))))
        '        's_pdv = 0
        '        s_prod_vrednost += CDec(pr_vred)
        '        s_pdv_osnovica += CDec(kol * mp_cena / (1 + (pdv / 100)))
        '        's_pdv_osnovica = 0
        '    Next
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        ''If Not _unesen Then
        'txtIznosCena.Text = Format(s_nab_vrednost, "##,##0.00")
        'txtIznosRabat.Text = Format(s_rab, "##,##0.00")
        'txtRazlikauceni.Text = Format(s_marza, "##,##0.00")
        'txtOsnovica.Text = Format(s_pdv_osnovica, "##,##0.00")
        'txtIznosPdv.Text = Format(s_pdv, "##,##0.00")
        'txtIznosZanaplatu.Text = Format(s_prod_vrednost, "##,##0.00")
        ''End If

    End Sub

#Region "Snimi"
    'Private Sub btnSnimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSnimi.Click
    '    snimi_head()
    '    snimi_pdv()
    '    snimi_stavku()
    '    snimi_cene()

    '    'unesi_dnevni_promet_head(Today.Date, Now, _id_magacin, 0, Partner_id(cmbPartneri.Text), _
    '    '                ID_vrsta_dokumenta, _id_kalkulacija, txtBroj.Text, txtIznosCena.Text, _
    '    '                0, 1, 0, vrsta_promene.unos)

    '    '_id_dnevni_promet = Nadji_id(Imena.tabele.rm_dnevni_promet_head.ToString)

    '    'Dim i As Integer
    '    'For i = 0 To dgStavke.Rows.Count - 2
    '    '    selektuj_artikl(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)
    '    '    unesi_dnevni_promet_stavka(_id_dnevni_promet, _id_magacin, _id_artikl, dgStavke.Rows(i).Cells(5).Value, 0, _
    '    '            CSng(dgStavke.Rows(i).Cells(9).Value), dgStavke.Rows(i).Cells(12).Value, True, False)
    '    'Next

    '    'pocetak()
    'End Sub

    Private Sub snimi_head()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim ztros As Single = 0

        ''Dim DR As SqlDataReader
        'If chkZT.CheckState = CheckState.Checked Then
        '    If chkIznos.CheckState = CheckState.Checked Then
        '        ztros = CSng(txtZTIznos.Text)
        '    Else
        '        If chkProcenat.CheckState = CheckState.Checked Then
        '            ztros = CSng(txtUkupnoPrc.Text)
        '        Else
        '            ztros = 0
        '        End If
        '    End If
        'Else
        '    ztros = 0
        'End If

        'selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)

        'CN.Open()
        'CM = New SqlCommand()
        'If CN.State = ConnectionState.Open Then
        '    With CM
        '        .Connection = CN
        '        .CommandType = CommandType.StoredProcedure
        '        .CommandText = "rm_kalkulacija_head_add"
        '        .Parameters.AddWithValue("@kalk_broj", txtBroj.Text)
        '        .Parameters.AddWithValue("@id_magacina", _id_magacin)
        '        .Parameters.AddWithValue("@id_dobavljac", Partner(cmbPartneri.Text))
        '        .Parameters.AddWithValue("@kalk_datum_fakture", dateFaktura.Value.Date)
        '        .Parameters.AddWithValue("@kalk_datum", dateKalkulacija.Value.Date)
        '        .Parameters.AddWithValue("@kalk_opis", txtFaktura.Text)
        '        .Parameters.AddWithValue("@kalk_ukupno", CSng(txtIznosCena.Text))
        '        .Parameters.AddWithValue("@kalk_ztroskovi", ztros)
        '        .Parameters.AddWithValue("@kalk_rabat", CSng(txtIznosRabat.Text))
        '        .Parameters.AddWithValue("@kalk_razlika_uceni", CSng(txtRazlikauceni.Text))
        '        .Parameters.AddWithValue("@kalk_pdv_osnovica", CSng(txtOsnovica.Text))
        '        .Parameters.AddWithValue("@kalk_pdv", CSng(txtIznosPdv.Text))
        '        .Parameters.AddWithValue("@kalk_svega", CSng(txtIznosZanaplatu.Text))
        '        .Parameters.AddWithValue("@kalk_zakljucena", 0)
        '        .Parameters.AddWithValue("@id_vrsta_dokumenta", ID_vrsta_dokumenta)
        '        .ExecuteScalar()
        '    End With
        'End If
        'CM.Dispose()
        'CN.Close()
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
                If Not IsDBNull(DR.Item("pdv_stopa")) Then _porezi.SetValue(CSng(DR.Item("pdv_stopa")), i * 3)
                _porezi.SetValue(saberi_osnovice(DR.Item("pdv_stopa")), (i * 3) + 1)
                _porezi.SetValue(saberi_pdv(DR.Item("pdv_stopa")), (i * 3) + 2)
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
                        .Parameters.AddWithValue("@iznos", _porezi((i * 3) + 2))
                        .ExecuteScalar()
                    End With
                End If
                CM.Dispose()
            End If
        Next
        CN.Close()
    End Sub

    Private Function saberi_pdv(ByVal _stopa) As Single
        'Dim i As Integer

        'saberi_pdv = 0
        'For i = 0 To dgStavke.Rows.Count - 2
        '    If dgStavke.Rows(i).Cells(12).Value = _stopa Then saberi_pdv += dgStavke.Rows(i).Cells(14).Value 'dgStavke.Rows(i).Cells(5).Value * dgStavke.Rows(i).Cells(13).Value
        'Next
    End Function

    Private Function saberi_osnovice(ByVal _stopa) As Single
        'Dim i As Integer

        'saberi_osnovice = 0
        'For i = 0 To dgStavke.Rows.Count - 2
        '    If dgStavke.Rows(i).Cells(12).Value = _stopa Then saberi_osnovice += dgStavke.Rows(i).Cells(13).Value / (1 + (dgStavke.Rows(i).Cells(12).Value / 100))
        'Next
    End Function

    Private Sub snimi_stavku()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        'Dim i As Integer

        _id_kalkulacija = Nadji_id(Imena.tabele.rm_kalkulacija_head.ToString)

        'For i = 0 To dgStavke.Rows.Count - 2
        '    CN.Open()
        '    CM = New SqlCommand()
        '    If CN.State = ConnectionState.Open Then
        '        With CM
        '            .Connection = CN
        '            .CommandType = CommandType.StoredProcedure
        '            .CommandText = "rm_kalkulacija_stavka_add"
        '            .Parameters.AddWithValue("@id_kalkulacija", _id_kalkulacija) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
        '            .Parameters.AddWithValue("@rb", dgStavke.Rows(i).Cells(0).Value)
        '            selektuj_artikl(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)
        '            .Parameters.AddWithValue("@id_artikl", _id_artikl)
        '            .Parameters.AddWithValue("@roba_sifra", dgStavke.Rows(i).Cells(1).Value)
        '            .Parameters.AddWithValue("@roba", dgStavke.Rows(i).Cells(2).Value)
        '            .Parameters.AddWithValue("@kolicina", dgStavke.Rows(i).Cells(5).Value)
        '            .Parameters.AddWithValue("@nab_cena", CSng(dgStavke.Rows(i).Cells(6).Value))
        '            .Parameters.AddWithValue("@rabat", CSng(dgStavke.Rows(i).Cells(7).Value))
        '            .Parameters.AddWithValue("@zav_troskovi", CSng(dgStavke.Rows(i).Cells(8).Value))
        '            .Parameters.AddWithValue("@cena_kostanja", CSng(dgStavke.Rows(i).Cells(9).Value))
        '            .Parameters.AddWithValue("@nab_vred", CSng(dgStavke.Rows(i).Cells(10).Value))
        '            .Parameters.AddWithValue("@marza", CSng(dgStavke.Rows(i).Cells(11).Value))
        '            .Parameters.AddWithValue("@pdv", dgStavke.Rows(i).Cells(12).Value)
        '            .Parameters.AddWithValue("@prod_cena", CSng(dgStavke.Rows(i).Cells(13).Value))
        '            .Parameters.AddWithValue("@pdv_iznos", CSng(dgStavke.Rows(i).Cells(14).Value))
        '            .Parameters.AddWithValue("@prod_vred", CSng(dgStavke.Rows(i).Cells(15).Value))
        '            .ExecuteScalar()
        '        End With
        '    End If
        '    CM.Dispose()
        '    CN.Close()
        'Next
    End Sub

    Private Sub snimi_cene()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        'Dim DR As SqlDataReader
        'Dim i As Integer

        'For i = 0 To dgStavke.Rows.Count - 2
        '    CN.Open()

        '    selektuj_artikl(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)

        '    CM = New SqlCommand()
        '    With CM
        '        .Connection = CN
        '        .CommandType = CommandType.Text
        '        .CommandText = "select dbo.rm_artikli_cene.* from dbo.rm_artikli_cene where id_artikl = " & _id_artikl & " and id_magacin = " & magacinID
        '        DR = .ExecuteReader
        '    End With
        '    _id_artikl_cena = 0
        '    Do While DR.Read
        '        _id_artikl_cena = DR.Item("id_cena_robe")
        '    Loop
        '    DR.Close()
        '    CM.Dispose()

        '    If CN.State = ConnectionState.Open Then
        '        CM = New SqlCommand()
        '        With CM
        '            .Connection = CN
        '            .CommandType = CommandType.StoredProcedure
        '            Select Case _id_artikl_cena
        '                Case Is <> 0
        '                    .CommandText = "rm_artikli_cene_update"
        '                    .Parameters.AddWithValue("@id_cena_robe", _id_artikl_cena)
        '                Case Is = 0
        '                    .CommandText = "rm_artikli_cene_add"
        '                    .Parameters.AddWithValue("@id_artikl", _id_artikl)
        '                    'selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)
        '                    .Parameters.AddWithValue("@id_magacin", magacinID)
        '            End Select
        '            .Parameters.AddWithValue("@cena_nab_zadnja", dgStavke.Rows(i).Cells(6).Value)
        '            Dim a As Single = dgStavke.Rows(i).Cells(6).Value 'dgStavke.Rows(i).Cells(13).Value / (1 + (dgStavke.Rows(i).Cells(12).Value / 100))
        '            .Parameters.AddWithValue("@cena_vp1", dgStavke.Rows(i).Cells(6).Value) ' dgStavke.Rows(i).Cells(13).Value / (1 + (dgStavke.Rows(i).Cells(12).Value / 100)))
        '            .Parameters.AddWithValue("@cena_vp2", 0)
        '            .Parameters.AddWithValue("@cena_vp3", 0)
        '            Dim nab As Single = dgStavke.Rows(i).Cells(6).Value
        '            Dim mar As Single = dgStavke.Rows(i).Cells(11).Value
        '            Dim por As Single = dgStavke.Rows(i).Cells(12).Value
        '            Dim b As Single = nab * (1 + (mar / 100)) * (1 + (por / 100))
        '            .Parameters.AddWithValue("@cena_mp", nab * (1 + (mar / 100)) * (1 + (por / 100)))
        '            .Parameters.AddWithValue("@pdv", CSng(dgStavke.Rows(i).Cells(12).Value))
        '            .Parameters.AddWithValue("@rabat", CSng(dgStavke.Rows(i).Cells(8).Value))
        '            .Parameters.AddWithValue("@marza", CSng(dgStavke.Rows(i).Cells(11).Value))
        '            .ExecuteScalar()
        '        End With
        '        CM.Dispose()
        '    End If
        '    CN.Close()
        'Next
    End Sub

#End Region

#Region "Zakljuci"
    'Private Sub btnZakljuci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZakljuci.Click
    '    _id_oj = 0
    '    'selektuj_partnera(cmbPartneri.Text, Selekcija.po_nazivu)

    '    'prebaci_u_magacin_promene(_id_magacin, 4, txtBroj.Text)
    '    'prebaci_u_magacin_promene_stavka(_id_dnevni_promet)
    '    'zakljuci_dokument()
    '    'labProknjizen.Visible = True
    '    'btnZakljuci.Visible = False
    'End Sub

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
                .CommandText = "rm_kalkulacija_zakljuci"
                .Parameters.AddWithValue("@id_kalkulacija", _id_kalkulacija)
                .Parameters.AddWithValue("@kalk_zakljucena", 1)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
        _unesen = True
        zatvori_formu()
    End Sub
#End Region

End Class
