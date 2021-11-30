Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient
Imports System.Globalization
Imports Microsoft.VisualBasic

Public Class cntOstaliDok
    Shared listaR As New ListView
    Shared listaUR As New ListView
    Shared listaS As New ListView
    Shared listaTr As New ListView

    Shared cena As Decimal = 0
    Shared rabat As Decimal = 0
    Shared pdv As Decimal = 0
    Shared ukupno As Decimal = 0
    Shared cenaU As Decimal = 0
    Shared rabatU As Decimal = 0
    Shared pdvU As Decimal = 0
    Shared ukupnoU As Decimal = 0

    Private upit As String = ""
    Private upit_broj As String = ""
    Private upit_partner As String = ""
    Private upit_datum_kalkulacije As String = ""
    Private upit_broj_fakture As String = ""
    Private upit_datum_fakture As String = ""
    Private upit_broj_nivelacije As String = ""
    Private upit_datum_nivelacije As String = ""
    Private upit_broj_izvod As String = ""
    Private upit_datum_izvod As String = ""
    Private upit_partner_os As String = ""
    Private upit_valuta As String = ""
    Private upit_datum As String = ""
    Private upit_mesto As String = ""
    Private upit_radnik As String = ""
    Private upit_dana As String = ""
    Private upit_odeljenje As String = ""

    Private dokument As String = ""
    Private pozicija As Integer = 0

    Private sql_kalk As String = "SELECT * FROM dbo.rm_kalkulacija_head"
    Private sql_nivel As String = "SELECT * FROM dbo.rm_nivelacije_head"
    Private sql_radniN As String = "SELECT * FROM dbo.rm_radni_nalog_head"
    Private sql_putniN As String = "SELECT * FROM dbo.putni_nalog"
    Private sql_treb As String = "SELECT * FROM dbo.rm_trebovanje_head"

    Private sql_izvod As String = "SELECT * FROM dbo.fn_izvodi_head"
    Private sql_os As String = ""
    Private sql_os_rn As String = "SELECT * FROM dbo.rm_racun_head where dbo.rm_racun_head.placeno = 0"
    Private sql_os_prn As String = "SELECT * FROM dbo.rm_ulazni_racuni_head where dbo.rm_ulazni_racuni_head.placeno = 0"

    Private _pocetak As Boolean = True

    Private Sub cntFinansije_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        listaR = lvRacuni
        listaUR = lvUlazniRacuni
        listaS = lvSuma
        listaTr = lvTrebovanja
        _pocetak = False

        popuni_parnere()
    End Sub

    Private Sub popuni_parnere()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbPartneri.Items.Clear()
        cmbPartneri.Items.Add(" ")

        cmbPartnerVirman.Items.Clear()
        cmbPartnerVirman.Items.Add(" ")

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
                cmbPartnerVirman.Items.Add(DR.Item("partner_naziv"))
            Loop
            DR.Close()
        End If
        If cmbPartneri.Items.Count > 0 Then
            cmbPartneri.SelectedIndex = 0
        End If
        If cmbPartnerVirman.Items.Count > 0 Then
            cmbPartnerVirman.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_odeljenja()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbOdeljenje.Items.Clear()
        cmbOdeljenje.Items.Add(" ")

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
                cmbPartneri.Items.Add(DR.Item("naziv"))
            Loop
            DR.Close()
        End If
        If cmbOdeljenje.Items.Count > 0 Then
            cmbOdeljenje.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
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



#Region "Obracun pdv-a"
    Shared Sub izdvoj_racune()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cena = 0
        rabat = 0
        pdv = 0
        ukupno = 0

        FormatNumber(cena, 2)
        FormatNumber(rabat, 2)
        FormatNumber(pdv, 2)
        FormatNumber(ukupno, 2)

        'upit_datumOd = "DatumIzdavanja >= #" & DateTimePicker1.Value & "#"
        'DateSerial(dateFakturisanja.Value.Year, dateFakturisanja.Value.Month, dateFakturisanja.Value.Day + valuta)

        listaR.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                Dim a As String = _datum_od.Value.Day & "/" & _datum_od.Value.Month & "/" & _datum_od.Value.Year
                Dim sql As String = "select dbo.rm_racun_head.* from dbo.rm_racun_head" '& _
                '"where dbo.rm_racun_head.datum_prometa = " & _datum_od.Value.Date & ""
                .CommandText = sql
                DR = .ExecuteReader
            End With

            If _stavke Then
                Do While DR.Read
                    If DR.Item("datum_prometa") >= _datum_od.Value.Date _
                      And DR.Item("datum_prometa") <= _datum_do.Value.Date Then
                        cena += DR.Item("iznos_cena")
                        rabat += DR.Item("iznos_rabat")
                        pdv += DR.Item("iznos_pdv")
                        ukupno += DR.Item("iznos_zanaplatu")

                        Dim racun As New ListViewItem(DR.Item("sifra").ToString, 0)
                        racun.Tag = DR.Item("sifra").ToString
                        racun.SubItems.Add(DR.Item("id_partner"))
                        racun.SubItems.Add(DR.Item("datum_fakturisanja"))
                        racun.SubItems.Add(DR.Item("datum_prometa"))
                        racun.SubItems.Add(DR.Item("iznos_cena"))
                        racun.SubItems.Add(DR.Item("iznos_rabat"))
                        racun.SubItems.Add(DR.Item("iznos_pdv"))
                        racun.SubItems.Add(DR.Item("iznos_zanaplatu"))
                        racun.SubItems.Add(DR.Item("napomena"))
                        racun.SubItems.Add(da_ne(DR.Item("izdat")))
                        racun.SubItems.Add(da_ne(DR.Item("placeno")))

                        listaR.Items.AddRange(New ListViewItem() {racun})
                    End If
                Loop

                Dim racun1 As New ListViewItem
                Dim racun2 As New ListViewItem
                Dim oSub As ListViewItem.ListViewSubItem

                racun1.Tag = " "
                racun1.SubItems.Add("")
                racun1.SubItems.Add("")
                racun1.SubItems.Add("")
                racun1.SubItems.Add("")
                racun1.SubItems.Add("")
                racun1.SubItems.Add("")
                racun1.SubItems.Add("")
                racun1.SubItems.Add("")

                racun2.Tag = "Ukupno"
                racun2.ForeColor = Color.Chocolate
                racun2.SubItems.Add("")
                racun2.SubItems.Add("")
                'racun2.SubItems.Add("")
                racun2.SubItems.Add("Ukupno")
                racun2.SubItems.Add(cena)
                racun2.SubItems.Add(rabat)
                racun2.SubItems.Add(pdv)
                racun2.SubItems.Add(ukupno)

                For Each oSub In racun2.SubItems
                    oSub.ForeColor = Drawing.Color.Chocolate  ' CornflowerBlue 'CadetBlue  
                Next
                listaR.Items.AddRange(New ListViewItem() {racun1, racun2})

            Else
                Do While DR.Read
                    If DR.Item("datum_prometa") >= _datum_od.Value.Date _
                      And DR.Item("datum_prometa") <= _datum_do.Value.Date Then
                        cena += DR.Item("iznos_cena")
                        rabat += DR.Item("iznos_rabat")
                        pdv += DR.Item("iznos_pdv")
                        ukupno += DR.Item("iznos_zanaplatu")
                    End If
                Loop
                Dim racun As New ListViewItem("Stanje za period od " & _datum_od.Value.Date & " do " & _datum_do.Value.Date, 0)
                racun.Tag = DR.Item("sifra").ToString
                racun.SubItems.Add("")
                racun.SubItems.Add("")
                'racun.SubItems.Add("")
                racun.SubItems.Add("Ukupno")
                racun.SubItems.Add(Decimal.Round(cena, 2))
                racun.SubItems.Add(Decimal.Round(rabat, 2))
                racun.SubItems.Add(Decimal.Round(pdv, 2))
                racun.SubItems.Add(Decimal.Round(ukupno, 2))

                listaR.Items.AddRange(New ListViewItem() {racun})
            End If
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Shared Sub izdvoj_ulazne_racune()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cenaU = 0
        rabatU = 0
        pdvU = 0
        ukupnoU = 0

        FormatNumber(cenaU, 2)
        FormatNumber(rabatU, 2)
        FormatNumber(pdvU, 2)
        FormatNumber(ukupnoU, 2)

        listaUR.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_ulazni_racuni_head.* " & _
                               "from dbo.rm_ulazni_racuni_head" '& _
                '"where dbo.rm_ulazni_racuni_head.datum_fakturisanja = '#" & _datum_do.Value.Date & "#'"
                DR = .ExecuteReader
            End With
            If _stavke Then
                Do While DR.Read
                    If DR.Item("datum_fakturisanja") >= _datum_od.Value.Date _
                      And DR.Item("datum_fakturisanja") <= _datum_do.Value.Date Then
                        cenaU += DR.Item("iznos_cena")
                        rabatU += DR.Item("iznos_rabat")
                        pdvU += DR.Item("iznos_pdv")
                        ukupnoU += DR.Item("iznos_zanaplatu")

                        Dim racun As New ListViewItem(DR.Item("sifra").ToString, 0)
                        racun.SubItems.Add(DR.Item("id_partner"))
                        racun.SubItems.Add(DR.Item("datum_fakturisanja"))
                        racun.SubItems.Add(DR.Item("iznos_cena"))
                        racun.SubItems.Add(DR.Item("iznos_rabat"))
                        racun.SubItems.Add(DR.Item("iznos_pdv"))
                        racun.SubItems.Add(DR.Item("iznos_zanaplatu"))
                        racun.SubItems.Add(DR.Item("napomena"))
                        racun.SubItems.Add(da_ne(DR.Item("unesen")))
                        racun.SubItems.Add(da_ne(DR.Item("placeno")))

                        listaUR.Items.AddRange(New ListViewItem() {racun})
                    End If
                Loop

                Dim racun1 As New ListViewItem
                Dim racun2 As New ListViewItem
                Dim oSub As ListViewItem.ListViewSubItem

                racun1.Tag = " "
                racun1.SubItems.Add("")
                racun1.SubItems.Add("")
                racun1.SubItems.Add("")
                racun1.SubItems.Add("")
                racun1.SubItems.Add("")
                racun1.SubItems.Add("")

                racun2.Tag = "Ukupno"
                racun2.ForeColor = Color.Chocolate
                racun2.SubItems.Add("")
                racun2.SubItems.Add("Ukupno")
                racun2.SubItems.Add(cenaU)
                racun2.SubItems.Add(rabatU)
                racun2.SubItems.Add(pdvU)
                racun2.SubItems.Add(ukupnoU)

                For Each oSub In racun2.SubItems
                    oSub.ForeColor = Drawing.Color.Chocolate  ' CornflowerBlue 'CadetBlue  
                Next
                listaUR.Items.AddRange(New ListViewItem() {racun1, racun2})

            Else
                Do While DR.Read
                    If DR.Item("datum_fakturisanja") >= _datum_od.Value.Date _
                      And DR.Item("datum_fakturisanja") <= _datum_do.Value.Date Then
                        cenaU = DR.Item("iznos_cena")
                        rabatU = DR.Item("iznos_rabat")
                        pdvU = DR.Item("iznos_pdv")
                        ukupnoU = DR.Item("iznos_zanaplatu")
                    End If
                Loop
                Dim racun As New ListViewItem("Stanje za period od " & _datum_od.Value.Date & " do " & _datum_do.Value.Date, 0)
                racun.SubItems.Add("")
                racun.SubItems.Add(DR.Item("datum_fakturisanja"))
                racun.SubItems.Add("")
                racun.SubItems.Add("Ukupno")
                racun.SubItems.Add(cenaU)
                racun.SubItems.Add(rabatU)
                racun.SubItems.Add(pdvU)
                racun.SubItems.Add(ukupnoU)

                listaUR.Items.AddRange(New ListViewItem() {racun})
            End If
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Shared Sub sumiraj()

        listaS.Items.Clear()

        Dim suma As New ListViewItem("Stanje za period od ") ' & _datum_od.Value.Date & " do " & _datum_do.Value.Date, 0)
        'suma.SubItems.Add(DR.Item("broj"))
        suma.SubItems.Add(_datum_od.Value.Date)
        suma.SubItems.Add(_datum_do.Value.Date)
        suma.SubItems.Add(cena - cenaU)
        suma.SubItems.Add(rabat - rabatU)
        suma.SubItems.Add(pdv - pdvU)
        suma.SubItems.Add(ukupno - ukupnoU)

        listaS.Items.AddRange(New ListViewItem() {suma})

    End Sub
#End Region

    Shared Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function

    Private Sub tabFinansije_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabFinansije.TabIndexChanged
        Select Case tabFinansije.SelectedIndex
            Case 0
                _tab_finansije = Imena.tabele.rm_trebovanje.ToString
                sql_treb = "SELECT * FROM dbo.rm_trebovanje_head"
                listaTrebovanje()
                popuni_odeljenja()
            Case 1
                _tab_finansije = Imena.tabele.rm_kalkulacija.ToString
                sql_kalk = "select dbo.rm_kalkulacija_head.* from dbo.rm_kalkulacija_head"
                listaKalkulacije()
                popuni_parnere()
            Case 2
                _tab_finansije = Imena.tabele.rm_nivelacije.ToString
                sql_nivel = "select dbo.rm_nivelacije_head.* from dbo.rm_nivelacije_head"
                listaNivelacije()
            Case 3 ' 
                _tab_finansije = Imena.tabele.fin_stanje.ToString
            Case 4
                _tab_finansije = Imena.tabele.rm_radni_nalog.ToString
                sql_radniN = "SELECT * FROM dbo.rm_radni_nalog_head"
                lista_radniN()
            Case 5
                _tab_finansije = Imena.tabele.fn_putni_nalog.ToString
                sql_putniN = "SELECT * FROM dbo.putni_nalog"
                lista_putniN()
            Case 6
                _tab_finansije = Imena.tabele.virmani.ToString

                _virmani_iznos = New Single() {}
                ReDim _virmani_iznos(5)

                _virmani_hitno = New Boolean() {}
                ReDim _virmani_hitno(5)

                virmani()

        End Select
        _promenjen_tab = True

    End Sub
    Private Sub tabFinansije_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabFinansije.SelectedIndexChanged
        Select Case tabFinansije.SelectedIndex
            Case 0
                _tab_finansije = Imena.tabele.rm_trebovanje.ToString
                sql_treb = "SELECT * FROM dbo.rm_trebovanje_head"
                listaTrebovanje()
                popuni_odeljenja()
            Case 1
                _tab_finansije = Imena.tabele.rm_kalkulacija.ToString
                sql_kalk = "select dbo.rm_kalkulacija_head.* from dbo.rm_kalkulacija_head"
                listaKalkulacije()
                popuni_parnere()
            Case 2
                _tab_finansije = Imena.tabele.rm_nivelacije.ToString
                sql_nivel = "select dbo.rm_nivelacije_head.* from dbo.rm_nivelacije_head"
                listaNivelacije()
            Case 3 ' 
                _tab_finansije = Imena.tabele.fin_stanje.ToString
            Case 4
                _tab_finansije = Imena.tabele.rm_radni_nalog.ToString
                sql_radniN = "SELECT * FROM dbo.rm_radni_nalog_head"
                lista_radniN()
            Case 5
                _tab_finansije = Imena.tabele.fn_putni_nalog.ToString
                sql_putniN = "SELECT * FROM dbo.putni_nalog"
                lista_putniN()
            Case 6
                _tab_finansije = Imena.tabele.virmani.ToString

                _virmani_iznos = New Single() {}
                ReDim _virmani_iznos(5)

                _virmani_hitno = New Boolean() {}
                ReDim _virmani_hitno(5)

                virmani()

        End Select

    End Sub

    Private Sub filter_Trebovanje()

        On Error Resume Next
        If Not _pocetak Then
            If upit_broj <> "" Then upit = upit_broj

            If upit_datum <> "" And upit <> "" Then
                upit = upit & " and " & upit_datum
            Else
                If upit_datum <> "" Then upit = upit_datum
            End If

            If upit_odeljenje <> "" And upit <> "" Then
                upit = upit & " and " & upit_odeljenje
            Else
                If upit_odeljenje <> "" Then upit = upit_odeljenje
            End If

            If upit <> "" Then
                sql_treb = "SELECT * FROM dbo.rm_trebovanje_head where dbo.rm_trebovanje_head." & upit
            End If
            listaTrebovanje()

        End If
        upit = ""
        sql_treb = "SELECT * FROM dbo.rm_trebovanje_head"
    End Sub
    Private Sub listaTrebovanje()

        lvTrebovanja.Items.Clear()

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql_treb
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            While DR.Read
                Dim podatak As New ListViewItem(CStr(DR.Item("trebovanje_broj")), 0)
                podatak.SubItems.Add(DR.Item("trebovanje_datum"))
                podatak.SubItems.Add(DR.Item("trebovanje_odeljenje"))
                
                lvTrebovanja.Items.AddRange(New ListViewItem() {podatak}) ', item2, item3})
            End While
            DR.Close()
        End If

        CM.Dispose()
        CN.Close()

        _lista = lvTrebovanja
    End Sub

    Private Sub filter_Kalkulacije()

        On Error Resume Next
        If Not _pocetak Then
            If upit_broj <> "" Then upit = upit_broj

            If upit_partner <> "" And upit <> "" Then
                upit = upit & " and " & upit_partner
            Else
                If upit_partner <> "" Then upit = upit_partner
            End If

            If upit_datum_kalkulacije <> "" And upit <> "" Then
                upit = upit & " and " & upit_datum_kalkulacije
            Else
                If upit_datum_kalkulacije <> "" Then upit = upit_datum_kalkulacije
            End If

            If upit_broj_fakture <> "" And upit <> "" Then
                upit = upit & " and " & upit_broj_fakture
            Else
                If upit_broj_fakture <> "" Then upit = upit_broj_fakture
            End If

            If upit_datum_fakture <> "" And upit <> "" Then
                upit = upit & " and " & upit_datum_fakture
            Else
                If upit_datum_fakture <> "" Then upit = upit_datum_fakture
            End If

            If upit <> "" Then
                sql_kalk = "SELECT * FROM dbo.rm_kalkulacija_head where dbo.rm_kalkulacija_head." & upit
            End If
            listaKalkulacije()

        End If
        upit = ""
        sql_kalk = "SELECT * FROM dbo.rm_kalkulacija_head"
    End Sub
    Private Sub listaKalkulacije()

        lvKalkulacije.Items.Clear()

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql_kalk
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            While DR.Read
                Dim podatak As New ListViewItem(CStr(DR.Item("broj")), 0)
                podatak.SubItems.Add(DR.Item("datum_kalk"))
                podatak.SubItems.Add(Partner_naziv(DR.Item("id_dobavljac")))
                podatak.SubItems.Add(DR.Item("datum_fakture"))
                podatak.SubItems.Add(DR.Item("opis"))

                lvKalkulacije.Items.AddRange(New ListViewItem() {podatak}) ', item2, item3})
            End While
            DR.Close()
        End If

        CM.Dispose()
        CN.Close()

        _lista = lvKalkulacije
    End Sub

    Private Sub filter_Nivelacije()

        On Error Resume Next
        If Not _pocetak Then
            If upit_broj_nivelacije <> "" Then upit = upit_broj_nivelacije

            If upit_datum_nivelacije <> "" And upit <> "" Then
                upit = upit & " and " & upit_datum_nivelacije
            Else
                If upit_datum_nivelacije <> "" Then upit = upit_datum_nivelacije
            End If

            If upit <> "" Then
                sql_nivel = "SELECT * FROM dbo.rm_nivelacije_head where dbo.rm_nivelacije_head." & upit
            End If

            listaNivelacije()

        End If
        upit = ""
        sql_nivel = "SELECT * FROM dbo.rm_nivelacije_head"
    End Sub
    Private Sub listaNivelacije()

        lvNivelacije.Items.Clear()

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql_nivel
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            While DR.Read
                Dim podatak As New ListViewItem(CStr(DR.Item("broj")), 0)
                podatak.SubItems.Add(DR.Item("datum"))
                podatak.SubItems.Add(DR.Item("stara_vrednost"))
                podatak.SubItems.Add(DR.Item("nova_vrednost"))
                podatak.SubItems.Add(DR.Item("razlika_ucFarma"))
                podatak.SubItems.Add(DR.Item("stari_iznos_pdv"))
                podatak.SubItems.Add(DR.Item("novi_iznos_pdv"))
                podatak.SubItems.Add(DR.Item("razlika_pdv"))

                lvNivelacije.Items.AddRange(New ListViewItem() {podatak}) ', item2, item3})
            End While
            DR.Close()
        End If

        CM.Dispose()
        CN.Close()

        _lista = lvNivelacije
    End Sub

    Private Sub filter_radniN()

        On Error Resume Next
        If Not _pocetak Then
            If upit_broj <> "" Then upit = upit_broj

            If upit_partner <> "" And upit <> "" Then
                upit = upit & " and " & upit_partner
            Else
                If upit_partner <> "" Then upit = upit_partner
            End If

            If upit_datum <> "" And upit <> "" Then
                upit = upit & " and " & upit_datum
            Else
                If upit_datum <> "" Then upit = upit_datum
            End If

            If upit_mesto <> "" And upit <> "" Then
                upit = upit & " and " & upit_mesto
            Else
                If upit_mesto <> "" Then upit = upit_mesto
            End If

            If upit <> "" Then
                sql_radniN = "SELECT * FROM dbo.rm_radni_nalog_head where dbo.rm_radni_nalog_head." & upit
            End If
            lista_radniN()

        End If
        upit = ""
        sql_radniN = "SELECT * FROM dbo.rm_radni_nalog_head"
    End Sub
    Private Sub lista_radniN()

        lvRadniN.Items.Clear()

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql_radniN
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            While DR.Read
                Dim podatak As New ListViewItem(CStr(DR.Item("broj")), 0)
                podatak.SubItems.Add(DR.Item("firma"))
                podatak.SubItems.Add(DR.Item("mesto"))
                podatak.SubItems.Add(DR.Item("telefon"))
                podatak.SubItems.Add(da_ne(DR.Item("monatza")))
                podatak.SubItems.Add(da_ne(DR.Item("popravka")))
                podatak.SubItems.Add(da_ne(DR.Item("servisiranje")))
                podatak.SubItems.Add(da_ne(DR.Item("ispitivanje")))
                podatak.SubItems.Add(da_ne(DR.Item("preventiva")))
                podatak.SubItems.Add(DR.Item("polazak_datum"))
                podatak.SubItems.Add(DR.Item("polazak_vreme"))
                podatak.SubItems.Add(DR.Item("povratak_datum"))
                podatak.SubItems.Add(DR.Item("povratak_vreme"))
                podatak.SubItems.Add(DR.Item("vozilo_naziv"))
                podatak.SubItems.Add(DR.Item("kilometraza"))
                podatak.SubItems.Add(DR.Item("opis"))

                lvRadniN.Items.AddRange(New ListViewItem() {podatak}) ', item2, item3})
            End While
            DR.Close()
        End If

        CM.Dispose()
        CN.Close()

        _lista = lvRadniN
    End Sub

    Private Sub filter_putniN()

        On Error Resume Next
        If Not _pocetak Then
            If upit_broj <> "" Then upit = upit_broj

            If upit_broj <> "" And upit <> "" Then
                upit = upit & " and " & upit_broj
            Else
                If upit_broj <> "" Then upit = upit_broj
            End If

            If upit_dana <> "" And upit <> "" Then
                upit = upit & " and " & upit_dana
            Else
                If upit_dana <> "" Then upit = upit_dana
            End If

            If upit_radnik <> "" And upit <> "" Then
                upit = upit & " and " & upit_radnik
            Else
                If upit_radnik <> "" Then upit = upit_radnik
            End If

            If upit_mesto <> "" And upit <> "" Then
                upit = upit & " and " & upit_mesto
            Else
                If upit_mesto <> "" Then upit = upit_mesto
            End If

            If upit <> "" Then
                sql_putniN = "SELECT * FROM dbo.putni_nalog where dbo.fn_putni_nalog." & upit
            End If
            lista_putniN()

        End If
        upit = ""
        sql_putniN = "SELECT * FROM dbo.putni_nalog"
    End Sub
    Private Sub lista_putniN()

        lvPutniN.Items.Clear()

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql_putniN
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            While DR.Read
                Dim nalog As New ListViewItem(CStr(DR.Item("broj")), 0)
                nalog.SubItems.Add(DR.Item("radnik"))
                nalog.SubItems.Add(DR.Item("dana"))
                nalog.SubItems.Add(DR.Item("mesto"))

                lvPutniN.Items.AddRange(New ListViewItem() {nalog}) ', item2, item3})
            End While
            DR.Close()
        End If

        CM.Dispose()
        CN.Close()

        _lista = lvPutniN
    End Sub

    Private Sub listaVirmani()
        Dim i As Integer

        lvVirmani.Items.Clear()
        For i = 0 To pozicija
            Dim podatak As New ListViewItem(_virmani(i, 1).ToString, 0)
            podatak.SubItems.Add(_virmani(i, 0).ToString)
            podatak.SubItems.Add(_virmani_iznos(i))

            lvVirmani.Items.AddRange(New ListViewItem() {podatak})
        Next i

    End Sub

    Private Sub txtTrebBroj_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTrebBroj.TextChanged
        If Not _pocetak Then
            If txtTrebBroj.Text <> "" Then
                upit_broj = "trebovanje_broj = '" & txtTrebBroj.Text & "'"
            Else
                upit_broj = ""
            End If
            filter_Trebovanje()
        End If
    End Sub

    Private Sub dateTrebDatum_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateTrebDatum.ValueChanged
        If Not _pocetak Then

            upit_datum_kalkulacije = "trebovanje_datum = '" & _
                dateKalkulacija.Value.Month.ToString & "/" & _
                dateKalkulacija.Value.Day.ToString & "/" & _
                dateKalkulacija.Value.Year.ToString & "'"

            filter_Trebovanje()
        End If
    End Sub

    Private Sub cmbOdeljenje_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOdeljenje.SelectedIndexChanged
        If Not _pocetak Then
            If cmbOdeljenje.Text <> "" Then
                upit_odeljenje = "trebovanje_odeljenje = '" & cmbOdeljenje.Text & "'"
            Else
                upit_odeljenje = ""
            End If
            filter_Trebovanje()
        End If
    End Sub


    Private Sub txtBrojKalkulacije_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBrojKalkulacije.TextChanged
        If Not _pocetak Then
            If txtBrojKalkulacije.Text <> "" Then
                upit_broj = "broj = '" & txtBrojKalkulacije.Text & "'"
            Else
                upit_broj = ""
            End If
            filter_Kalkulacije()
        End If
    End Sub
    Private Sub cmbPartneri_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPartneri.SelectedIndexChanged
        If Not _pocetak Then
            If cmbPartneri.Text <> " " Then
                upit_partner = "id_dobavljac = " & Partner(cmbPartneri.Text)
            Else
                upit_partner = ""
            End If
            filter_Kalkulacije()
        End If
    End Sub
    Private Sub dateKalkulacija_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateKalkulacija.ValueChanged
        If Not _pocetak Then

            upit_datum_kalkulacije = "datum_kalk = '" & _
                dateKalkulacija.Value.Month.ToString & "/" & _
                dateKalkulacija.Value.Day.ToString & "/" & _
                dateKalkulacija.Value.Year.ToString & "'"

            filter_Kalkulacije()
        End If
    End Sub

    Private Sub txtBrojFakture_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBrojFakture.TextChanged
        If txtBrojFakture.Text <> "" Then
            upit_broj_fakture = "opis like '" & txtBrojFakture.Text & "%'"
        Else
            upit_broj_fakture = ""
        End If
        filter_Kalkulacije()
    End Sub
    Private Sub dateFaktura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateFaktura.ValueChanged
        If Not _pocetak Then


            upit_datum_fakture = "datum_fakture = '" & _
              dateFaktura.Value.Month.ToString & "/" & _
              dateFaktura.Value.Day.ToString & "/" & _
              dateFaktura.Value.Year.ToString & "'"

            filter_Kalkulacije()
        End If
    End Sub

    Private Sub txtBrojNivel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBrojNivel.TextChanged
        If Not _pocetak Then
            If txtBrojNivel.Text <> "" Then
                upit_broj_nivelacije = "broj = '" & txtBrojNivel.Text & "'"
            Else
                upit_broj_nivelacije = ""
            End If
            filter_Nivelacije()
        End If
    End Sub
   
    Private Sub dateNivelacije_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateNivelacije.ValueChanged
        If Not _pocetak Then
            upit_datum_nivelacije = "datum = '" & dateNivelacije.Value.Month.ToString & "/" & dateNivelacije.Value.Day.ToString & "/" & dateNivelacije.Value.Year.ToString & "'" '.ToString("d") & "#'"
            filter_Nivelacije()
        End If
    End Sub
    Private Sub txtBroj_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBroj.TextChanged
        If Not _pocetak Then
            If txtBroj.Text <> "" Then
                upit_broj = "broj = '" & txtBroj.Text & "'"
            Else
                upit_broj = ""
            End If
            filter_radniN()
        End If
    End Sub
    Private Sub txtFirma_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirma.TextChanged
        If Not _pocetak Then
            If txtBroj.Text <> "" Then
                upit_broj = "broj = '" & txtBroj.Text & "'"
            Else
                upit_broj = ""
            End If
            filter_radniN()
        End If
    End Sub
    Private Sub txtMesto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMesto.TextChanged
        If Not _pocetak Then
            If txtBroj.Text <> "" Then
                upit_broj = "broj = '" & txtBroj.Text & "'"
            Else
                upit_broj = ""
            End If
            filter_radniN()
        End If
    End Sub
    Private Sub dateRadniN_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateRadniN.ValueChanged
        If Not _pocetak Then
            upit_datum = "datum_fakture = '" & _
                    dateDatum.Value.Month.ToString & "/" & _
                    dateDatum.Value.Day.ToString & "/" & _
                    dateDatum.Value.Year.ToString & "'"
            filter_radniN()
        End If
    End Sub

    Private Sub txtBrojPutniN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBrojPutniN.TextChanged
        If Not _pocetak Then
            If txtBrojPutniN.Text <> "" Then
                upit_broj = "broj = '" & txtBrojPutniN.Text & "'"
            Else
                upit_broj = ""
            End If
            lista_putniN()
        End If
    End Sub
    Private Sub datePutniN_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datePutniN.ValueChanged
        If Not _pocetak Then
            upit_dana = "dana = '" & _
                dateDatum.Value.Month.ToString & "/" & _
                dateDatum.Value.Day.ToString & "/" & _
                dateDatum.Value.Year.ToString & "'"

            lista_putniN()
        End If
    End Sub
    Private Sub txtRadnik_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRadnik.TextChanged
        If Not _pocetak Then
            If txtRadnik.Text <> "" Then
                upit_radnik = "radnik like '" & txtRadnik.Text & "%'"
            Else
                upit_radnik = ""
            End If
            lista_putniN()
        End If
    End Sub

    Private Sub txtMestoPutniN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMestoPutniN.TextChanged
        If Not _pocetak Then
            If txtMestoPutniN.Text <> "" Then
                upit_mesto = "mesto like '" & txtMestoPutniN.Text & "%'"
            Else
                upit_mesto = ""
            End If
            lista_putniN()
        End If
    End Sub

    Shared Sub myUpdate()
        If bukmark = 0 Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            Select Case _tab
                Case Imena.tabele.fin_stanje
                    Exit Select
                Case Imena.tabele.rm_trebovanje
                    'selektuj_kalkulaciju(bukmark)
                    'Dim myChild As New frmKalkulacijaEdit
                    'myChild.Show()
                Case Imena.tabele.rm_kalkulacija
                    'selektuj_kalkulaciju(bukmark, Selekcija.po_sifri)
                    'Dim myChild As New frmKalkulacijaEdit
                    'myChild.Show()
                Case Imena.tabele.rm_nivelacije
                    selektuj_nivelaciju(bukmark)
                    Dim myChild As New frmNivelacijaEdit
                    myChild.Show()
                Case Imena.tabele.rm_radni_nalog
                    selektuj_radni_nalog(bukmark)
                    Dim myChild As New frmRadniNalogEdit
                    myChild.Show()
                Case Imena.tabele.fn_putni_nalog
                    selektuj_putni_nalog(bukmark)
                    Dim myChild As New frmPutniNalogEdit
                    myChild.Show()
                Case Imena.tabele.fn_izvodi
                    selektuj_izvod(bukmark)
                    Dim myChild As New frmIzvodiEdit
                    myChild.Show()
            End Select
        End If
    End Sub

    Shared Sub myUpdate_potvrde()
        _izdat = False
        If bukmark_potvrde = 0 Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            selektuj_potvrdu(bukmark_potvrde)
            Dim myChild As New frmPotvrdaEdit
            myChild.Show()
        End If
    End Sub

    Shared Sub myUpdate_putracun()
        If bukmark = 0 Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            selektuj_putni_racun(bukmark)
            Dim myChild As New frmPutniRacunEdit
            myChild.Show()
        End If
    End Sub

    Shared Sub myDelete()
        If bukmark = 0 Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            Dim poruka As String = "Da li ste sigurno da želite da izbrišete zapis sa sifrom " & bukmark & " ?"
            If MsgBox(poruka, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Select Case _tab
                    Case Imena.tabele.fin_stanje.ToString
                        Exit Select
                    Case Imena.tabele.rm_trebovanje.ToString
                        selektuj_kalkulaciju(bukmark, Selekcija.po_sifri)
                        brisi_kalk_stavke(_id_kalkulacija)
                        brisi_kalk_pdv(_id_kalkulacija)
                        brisi_kalkulaciju(bukmark)
                    Case Imena.tabele.rm_kalkulacija.ToString
                        selektuj_kalkulaciju(bukmark, Selekcija.po_sifri)
                        brisi_kalk_stavke(_id_kalkulacija)
                        brisi_kalk_pdv(_id_kalkulacija)
                        brisi_kalkulaciju(bukmark)
                        'listaKalkulacije()
                    Case Imena.tabele.rm_nivelacije.ToString
                        selektuj_nivelaciju(bukmark)
                        brisi_nivel_stavke(_id_nivelacije)
                        brisi_nivelaciju(bukmark)
                    Case Imena.tabele.rm_radni_nalog.ToString
                        selektuj_radni_nalog(bukmark)
                        selektuj_potvrdu(_id_radni_nalog)
                        brisi_radni_nalog(_id_radni_nalog)
                End Select
            End If
        End If
    End Sub

    Shared bukmark As Integer = 0
    Private Sub lvKalkulacije_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvKalkulacije.Click
        bukmark = lvKalkulacije.SelectedItems.Item(0).Text
        _id = bukmark
        _tab = Imena.tabele.rm_kalkulacija
    End Sub
    Private Sub lvNivelacije_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvNivelacije.Click
        bukmark = lvNivelacije.SelectedItems.Item(0).Text
        _id = bukmark
        _tab = Imena.tabele.rm_nivelacije
    End Sub

    Private Sub lvRadniN_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvRadniN.Click
        bukmark = CInt(lvRadniN.SelectedItems(0).Text)
        izdvoj_potvrdu()
        _tab = Imena.tabele.rm_radni_nalog
    End Sub

    Shared bukmark_potvrde As Integer = 0 'broj potvrde
    Private Sub lvPotvrde_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvPotvrde.Click
        bukmark_potvrde = lvPotvrde.SelectedItems(0).Text
    End Sub
    Private Sub izdvoj_potvrdu()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        lvPotvrde.Items.Clear()
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.radni_nalog_potvrda.*" & _
                               "from dbo.radni_nalog_potvrda " & _
                               "where dbo.radni_nalog_potvrda.id_radninalog = " & bukmark
                DR = .ExecuteReader
            End With
            Do While DR.Read
                Dim roba As New ListViewItem(DR.Item("broj").ToString, 0)
                'roba.SubItems.Add(DR.Item("broj"))
                roba.SubItems.Add(da_ne(DR.Item("montaza")))
                roba.SubItems.Add(da_ne(DR.Item("montaza_end")))
                roba.SubItems.Add(da_ne(DR.Item("popravka")))
                roba.SubItems.Add(da_ne(DR.Item("popravka_end")))
                roba.SubItems.Add(da_ne(DR.Item("servis")))
                roba.SubItems.Add(da_ne(DR.Item("servis_end")))
                roba.SubItems.Add(da_ne(DR.Item("ispitivanje")))
                roba.SubItems.Add(da_ne(DR.Item("ispitivanje_end")))
                roba.SubItems.Add(da_ne(DR.Item("ugovor")))
                roba.SubItems.Add(da_ne(DR.Item("ugovor_end")))
                roba.SubItems.Add(DR.Item("napomene"))
                roba.SubItems.Add(da_ne(DR.Item("izdata")))

                lvPotvrde.Items.AddRange(New ListViewItem() {roba})
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub lvPutniN_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvPutniN.Click
        bukmark = lvPutniN.SelectedItems.Item(0).Text
        _id = bukmark
        izdvoj_pracun()
        _tab = Imena.tabele.fn_putni_nalog
    End Sub

    Shared bukmark_racun As Integer
    Private Sub lvPutniRacun_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvPutniRacun.Click
        bukmark_racun = CInt(lvPutniRacun.SelectedItems.Item(0).Text)
    End Sub
    Private Sub izdvoj_pracun()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        lvPutniRacun.Items.Clear()
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.fn_putni_racun.*" & _
                               "from dbo.putni_racun " & _
                               "where dbo.fn_putni_racun.id_putni_nalog = " & bukmark
                DR = .ExecuteReader
            End With
            Do While DR.Read
                Dim item As New ListViewItem(CDate(DR.Item("odlazak")).Date.ToString, 0)
                item.SubItems.Add(DR.Item("odlazak_sat"))
                item.SubItems.Add(DR.Item("povratak"))
                item.SubItems.Add(DR.Item("povratak_sat"))
                item.SubItems.Add(DR.Item("broj_sati"))
                item.SubItems.Add(DR.Item("akontacija"))
                item.SubItems.Add(DR.Item("svega"))


                lvPutniRacun.Items.AddRange(New ListViewItem() {item})
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Shared Sub Kalkulacija_prn()
        If bukmark = 0 Then
            MsgBox("Prvo morate izabrati stavku koji želite da štampate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            selektuj_kalkulaciju(bukmark, Selekcija.po_sifri)
            kalkulacija_print()

            _raport = Imena.tabele.rm_kalkulacija.ToString
            Dim mForm As New frmPrint
            mForm.Show()
        End If
    End Sub

    Shared Sub brisi_kalkulaciju(ByVal _bukmark)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_kalkulacija_head_delete"
                    .Parameters.AddWithValue("@broj", _bukmark)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox("Došlo je do greške prilikom izvršenja naredbe: " & ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Shared Sub brisi_kalk_stavke(ByVal _bukmark)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_kalkulacija_stavka_del_kalk"
                    .Parameters.AddWithValue("@id_kalkulacija", _bukmark)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox("Došlo je do greške prilikom izvršenja naredbe: " & ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Shared Sub brisi_kalk_pdv(ByVal _bukmark)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_kalkulacija_pdv_delete"
                    .Parameters.AddWithValue("@id_kalkulacija", _bukmark)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox("Došlo je do greške prilikom izvršenja naredbe: " & ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Shared Sub brisi_nivelaciju(ByVal _bukmark)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_nivelacije_head_delete"
                    .Parameters.AddWithValue("@broj", _bukmark)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox("Došlo je do greške prilikom izvršenja naredbe: " & ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Shared Sub brisi_nivel_stavke(ByVal _bukmark)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_nivelacije_stavka_del_nivel"
                    .Parameters.AddWithValue("@id_nivelacija", _bukmark)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
            CN.Close()
        Catch ex As Exception
            MsgBox("Došlo je do greške prilikom izvršenja naredbe: " & ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Shared Sub brisi_radni_nalog(ByVal _bukmark)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_radni_nalog_potvrda_stavka_delete_nalog"
                    .Parameters.AddWithValue("@id_radninalog_potvrda", _id_radni_nalog_potvrda)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If

            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_radni_nalog_izvrsioci_delete"
                    .Parameters.AddWithValue("@id_radninalog_potvrda", _id_radni_nalog_potvrda)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If

            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_radni_nalog_delete"
                    .Parameters.AddWithValue("@id_radninalog", _id_radni_nalog)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
        Catch ex As Exception
            MsgBox("Došlo je do greške prilikom izvršenja naredbe: " & ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Shared Sub brisi_putni_nalog(ByVal _bukmark)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        'selektuj_putni_nalog(bukmark)
        Try
            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "fn_putni_racun_delete"
                    .Parameters.AddWithValue("@id_putni_nalog", _id_pnalog)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "fn_putni_racun_ostalo_delete_nalog"
                    .Parameters.AddWithValue("@id_putni_nalog", _id_pnalog)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "fn_putni_racun_prevoz_delete_nalog"
                    .Parameters.AddWithValue("@id_putni_nalog", _id_pnalog)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If

            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "fn_putni_nalog_delete"
                    .Parameters.AddWithValue("@id_pnalog", _id_pnalog)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
        Catch ex As Exception
            MsgBox("Došlo je do greške prilikom izvršenja naredbe: " & ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub picKalkRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picKalkRefresh.Click
        sql_kalk = "SELECT * FROM dbo.rm_kalkulacija_head"
        listaKalkulacije()
    End Sub
    Private Sub picKalkRefresh_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picKalkRefresh.MouseHover
        picKalkRefresh.Image = Global.Farma.My.Resources.Resources.reload
        picKalkRefresh.Cursor = Cursors.Hand
    End Sub
    Private Sub picKalkRefresh_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picKalkRefresh.MouseLeave
        picKalkRefresh.Image = Global.Farma.My.Resources.Resources.reload1
        picKalkRefresh.Cursor = Cursors.Default
    End Sub

    Private Sub picNivelRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picNivelRefresh.Click
        sql_nivel = "SELECT * FROM dbo.rm_nivelacije_head"
        listaNivelacije()
    End Sub
    Private Sub picNivelRefresh_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picNivelRefresh.MouseHover
        picNivelRefresh.Image = Global.Farma.My.Resources.Resources.reload
        picNivelRefresh.Cursor = Cursors.Hand
    End Sub
    Private Sub picNivelRefresh_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picNivelRefresh.MouseLeave
        picNivelRefresh.Image = Global.Farma.My.Resources.Resources.reload1
        picNivelRefresh.Cursor = Cursors.Default
    End Sub

    Private Sub picRadniNRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRadniNRefresh.Click
        sql_radniN = "SELECT * FROM dbo.rm_radni_nalog_head"
        filter_radniN()
    End Sub
    Private Sub picRadniNRefresh_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRadniNRefresh.MouseHover
        picRadniNRefresh.Image = Global.Farma.My.Resources.Resources.reload
        picRadniNRefresh.Cursor = Cursors.Hand
    End Sub
    Private Sub picRadniNRefresh_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRadniNRefresh.MouseLeave
        picRadniNRefresh.Image = Global.Farma.My.Resources.Resources.reload1
        picRadniNRefresh.Cursor = Cursors.Default
    End Sub

    Private Sub picPutniNRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPutniNRefresh.Click
        sql_putniN = "SELECT * FROM dbo.fn_putni_nalog"
        lista_putniN()
    End Sub
    Private Sub picPutniNRefresh_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPutniNRefresh.MouseHover
        picRefresh.Image = Global.Farma.My.Resources.Resources.reload
        picRefresh.Cursor = Cursors.Hand
    End Sub
    Private Sub picPutniNRefresh_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPutniNRefresh.MouseLeave
        picRefresh.Image = Global.Farma.My.Resources.Resources.reload1
        picRefresh.Cursor = Cursors.Default
    End Sub

    Private Sub picTrebRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTrebRefresh.Click
        sql_putniN = "SELECT * FROM dbo.rm_trebovanje_head"
        listaTrebovanje()
    End Sub
    Private Sub picTrebRefresh_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picTrebRefresh.MouseHover
        picRefresh.Image = Global.Farma.My.Resources.Resources.reload
        picRefresh.Cursor = Cursors.Hand
    End Sub
    Private Sub picTrebRefresh_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picTrebRefresh.MouseLeave
        picRefresh.Image = Global.Farma.My.Resources.Resources.reload1
        picRefresh.Cursor = Cursors.Default
    End Sub

    Private Sub virmani()
        txtDuznik.Text = "Farma d.o.o. - Niš"
        txtRacunDuznika.Text = "265-4020310000303-60"
        txtSvrha.Text = ""
        txtPoverilac.Text = ""
        txtAdresaPoverioca.Text = ""
        txtSifraPlacanja.Text = ""
        txtValuta.Text = ""
        txtIznos.Text = ""
        txtModelZaduzenje.Text = ""
        txtPozNaBrZaduzenje.Text = ""
        txtRacunPrimaoca.Text = ""
        txtModelOdobrenje.Text = ""
        txtPozNaBrOdobrenje.Text = ""
        chkHitno.Checked = False

    End Sub

    Private Sub cmbPartnerVirman_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPartnerVirman.SelectedIndexChanged
        If Not _pocetak Then
            If cmbPartnerVirman.Text <> " " Then
                _id_partner = Partner(cmbPartnerVirman.Text)
                popuni_virman(_id_partner)
                _mCombo = cmbDokumenti
                izdvoj_dokumente(_id_partner, "d")
            End If
        End If
    End Sub

    Private Sub cmbDokumenti_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDokumenti.SelectedIndexChanged
        If Not _pocetak Then
            If cmbDokumenti.Text <> " " Then
                dokument_opis(RTrim(cmbDokumenti.Text.ToString))
                txtSvrha.Text = "Uplata po racunu br." & _broj_dokumenta.ToString
                txtIznos.Text = _za_naplatu
            End If
        End If
    End Sub

    Private Sub popuni_virman(ByVal tId)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        txtSvrha.Text = ""
        txtPoverilac.Text = ""
        txtAdresaPoverioca.Text = ""

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_partneri.* from dbo.app_partneri where id_partner = " & tId
                DR = .ExecuteReader
            End With
            Do While DR.Read
                txtPoverilac.Text = DR.Item("naziv")
                txtAdresaPoverioca.Text = DR.Item("adresa") & ", " & DR.Item("mesto")
                txtRacunPrimaoca.Text = DR.Item("zr")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Shared Sub virman_print()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        If _sa_cenom Then
            Dim i As Integer
            CN.Open()

            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "prn_Virman_delete"
                    .ExecuteScalar()
                End With
                CM.Dispose()

                'If (_virmani(i, 0) <> "" Or _virmani(i, 0) <> Nothing) And _
                '   (_virmani(1, 0) <> "" Or _virmani(1, 0) <> Nothing) And _
                '   (_virmani(2, 0) <> "" Or _virmani(2, 0) <> Nothing) Then
                For i = 0 To 2
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "prn_Virman_add"
                        If _virmani(i, 0) <> "" Then
                            .Parameters.AddWithValue("@svrha", _virmani(i, 0).ToString)
                        Else
                            .Parameters.AddWithValue("@svrha", "")
                        End If
                        If _virmani(i, 1) <> "" Then
                            .Parameters.AddWithValue("@poverilac", _virmani(i, 1).ToString)
                        Else
                            .Parameters.AddWithValue("@poverilac", "")
                        End If
                        If _virmani(i, 2) <> "" Then
                            .Parameters.AddWithValue("@adresa", _virmani(i, 2).ToString)
                        Else
                            .Parameters.AddWithValue("@adresa", "")
                        End If
                        If _virmani(i, 3) <> "" Then
                            .Parameters.AddWithValue("@sif_placanja", _virmani(i, 3).ToString)
                        Else
                            .Parameters.AddWithValue("@sif_placanja", "")
                        End If
                        If _virmani(i, 4) <> "" Then
                            .Parameters.AddWithValue("@valuta", _virmani(i, 4).ToString)
                        Else
                            .Parameters.AddWithValue("@valuta", "")
                        End If
                        If _virmani_iznos(i) <> 0 Then
                            .Parameters.AddWithValue("@iznos", CStr(_virmani_iznos(i)))
                        Else
                            .Parameters.AddWithValue("@iznos", "")
                        End If
                        If _virmani(i, 5) <> "" Then
                            .Parameters.AddWithValue("@mod_zaduzenje", _virmani(i, 5).ToString)
                        Else
                            .Parameters.AddWithValue("@mod_zaduzenje", "")
                        End If
                        If _virmani(i, 6) <> "" Then
                            .Parameters.AddWithValue("@pnb_zaduzenje", _virmani(i, 6).ToString)
                        Else
                            .Parameters.AddWithValue("@pnb_zaduzenje", "")
                        End If
                        If _virmani(i, 7) <> "" Then
                            .Parameters.AddWithValue("@rn_poverilac", _virmani(i, 7).ToString)
                        Else
                            .Parameters.AddWithValue("@rn_poverilac", "")
                        End If
                        If _virmani(i, 8) <> "" Then
                            .Parameters.AddWithValue("@mod_odobrenje", _virmani(i, 8).ToString)
                        Else
                            .Parameters.AddWithValue("@mod_odobrenje", "")
                        End If
                        If _virmani(i, 9) <> "" Then
                            .Parameters.AddWithValue("@pnb_odobrenje", _virmani(i, 9).ToString)
                        Else
                            .Parameters.AddWithValue("@pnb_odobrenje", "")
                        End If
                        .Parameters.AddWithValue("@hitno", _virmani_hitno(i))
                        .ExecuteScalar()
                    End With
                Next i
                CM.Dispose()
                'Else
                '    _sa_cenom = False
                'End If

            End If
            CN.Close()
        End If
        _raport = Imena.tabele.virmani.ToString
        Dim mForm As New frmPrint
        mForm.Show()
        _sa_cenom = False
    End Sub

    Private Sub txtSvrha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSvrha.TextChanged
        _virman_svrha = txtSvrha.Text
    End Sub
    Private Sub txtPoverilac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPoverilac.TextChanged
        _virman_poverilac = txtPoverilac.Text
    End Sub
    Private Sub txtAdresaPoverioca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdresaPoverioca.TextChanged
        _virman_adresa = txtAdresaPoverioca.Text
    End Sub
    Private Sub txtSifraPlacanja_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSifraPlacanja.TextChanged
        _virman_sif_placanja = txtSifraPlacanja.Text
    End Sub
    Private Sub txtValuta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValuta.TextChanged
        _virman_valuta = txtValuta.Text
    End Sub
    Private Sub txtIznos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIznos.TextChanged
        If txtIznos.Text <> "" And jeste_broj(txtIznos.Text) Then
            _virman_iznos = CSng(txtIznos.Text)
        Else
            _virman_iznos = 0
        End If
    End Sub
    Private Sub txtModelZaduzenje_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtModelZaduzenje.TextChanged
        _virman_mod_zaduzenje = txtModelZaduzenje.Text
    End Sub
    Private Sub txtPozNaBrZaduzenje_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPozNaBrZaduzenje.TextChanged
        _virman_pnb_zaduzenje = txtPozNaBrZaduzenje.Text
    End Sub
    Private Sub txtRacunPrimaoca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRacunPrimaoca.TextChanged
        _virman_rn_poverilac = txtRacunPrimaoca.Text
    End Sub
    Private Sub txtModelOdobrenje_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtModelOdobrenje.TextChanged
        _virman_mod_odobrenje = txtModelOdobrenje.Text
    End Sub
    Private Sub txtPozNaBrOdobrenje_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPozNaBrOdobrenje.TextChanged
        _virman_pnb_odobrenje = txtPozNaBrOdobrenje.Text
    End Sub
    Private Sub chkHitno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHitno.CheckedChanged
        _virman_hitno = chkHitno.CheckState
    End Sub

    Private Sub btnUbaciVirman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbaciVirman.Click

        If pozicija < 2 Then
            pozicija = lvVirmani.Items.Count

            _virmani.SetValue(_virman_svrha, pozicija, 0)
            _virmani.SetValue(_virman_poverilac, pozicija, 1)
            _virmani.SetValue(_virman_adresa, pozicija, 2)
            _virmani.SetValue(_virman_sif_placanja, pozicija, 3)
            _virmani.SetValue(_virman_valuta, pozicija, 4)
            _virmani.SetValue(_virman_mod_zaduzenje, pozicija, 5)
            _virmani.SetValue(_virman_pnb_zaduzenje, pozicija, 6)
            _virmani.SetValue(_virman_rn_poverilac, pozicija, 7)
            _virmani.SetValue(_virman_mod_odobrenje, pozicija, 8)
            _virmani.SetValue(_virman_pnb_odobrenje, pozicija, 9)

            _virmani_iznos.SetValue(_virman_iznos, pozicija)
            _virmani_hitno.SetValue(_virman_hitno, pozicija)

            listaVirmani()
            'virmani()
        Else
            MsgBox("Ne mozete stampati vise od 3 naloga!", MsgBoxStyle.OkOnly)
        End If

    End Sub

    Private Sub btnBrisi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrisi.Click

        _virmani_iznos = New Single() {}
        ReDim _virmani_iznos(5)

        _virmani_hitno = New Boolean() {}
        ReDim _virmani_hitno(5)

        Dim i As Integer = 0
        Dim j As Integer = 0
        For i = 0 To pozicija
            For j = 0 To 9
                _virmani.SetValue("", i, j)
            Next
        Next

        lvVirmani.Items.Clear()
        'listaVirmani()
        virmani()

        cmbPartnerVirman.SelectedIndex = 0
        cmbDokumenti.Items.Clear()
        cmbDokumenti.Text = ""
        pozicija = 0

    End Sub

    
   
   
End Class