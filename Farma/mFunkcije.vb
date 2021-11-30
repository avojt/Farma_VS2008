Option Strict Off
Option Explicit On
Option Compare Binary

Imports System.Data.SqlClient

Module mFunkcije

    Public Sub obrisi_poslednji_korak()
        _korak_nazad.SetValue("", zadnji_zapis(_korak_nazad))
    End Sub
    Public Sub obrisi_poslednji_korak_header()
        _korak_labHead.SetValue("", zadnji_zapis(_korak_labHead))
    End Sub

    Public Function zadnji_zapis(ByVal _niz) As Integer
        Dim i As Integer = 0
        zadnji_zapis = 0

        For i = 0 To _niz.Length - 1
            If Not _niz(i) Is Nothing Then
                If _niz(i).ToString <> "" Then
                    zadnji_zapis = i + 1
                End If
            End If
        Next
    End Function

    Public Sub obrisi_korake()
        Dim i As Integer = 0

        For i = 0 To _korak_nazad.Length - 1
            _korak_nazad.SetValue("", i)
        Next
    End Sub
    Public Sub obrisi_korake_header()
        Dim i As Integer = 0

        For i = 0 To _korak_labHead.Length - 1
            _korak_labHead.SetValue("", i)
        Next
    End Sub
    Public Function Ispisi_label()
        Dim i As Integer = 0
        Ispisi_label = ""
        For i = 0 To _korak_labHead.Length - 1
            If Not _korak_labHead(i) Is Nothing Then
                If _korak_labHead(i).ToString <> "" Then
                    If Ispisi_label <> "" Then
                        Ispisi_label += " - " & naziv(_korak_labHead(i).ToString)
                    Else
                        Ispisi_label += naziv(_korak_labHead(i).ToString)
                    End If
                End If
            End If
        Next
    End Function
    Public Function naziv(ByVal _forma As String) As String
        naziv = ""
        Select Case _forma
            Case "cntRobno"
                naziv = "ROBNO"
            Case "cntArtikli"
                naziv = "ARTIKLI"
            Case _forma Like "%Unos"
                naziv = "UNOS"
            Case _forma Like "%Edit"
                naziv = "AŽURIRANJE"
            Case "cntMagacini"
                naziv = "MAGACINI"
            Case "cntCenovnik"
                naziv = "CENOVNIK"
            Case "cntRacuni"
                naziv = "RAČUNI"
            Case "cntOstaliDok"
                naziv = "OSTALI DOKUMENTI"
            Case "cntUlazniRacuni"
                naziv = "ULAZNI RAČUNI"
            Case "cntFinansijsko"
                naziv = "FINANSIJSKO"
            Case "cntIzvodi"
                naziv = "IZVODI"
            Case "cntNalozi"
                naziv = "NALOZI"
            Case "cntOStavke"
                naziv = "OTVORENE STAVKE"
            Case "cntAlati"
                naziv = "ALATI"
            Case "cntGrupeArt"
                naziv = "GR.ARTIKLA"
            Case "cntJKL"
                naziv = "JKL"
            Case "cntKategorije"
                naziv = "KATEGORIJE"
            Case "cntKontniPlan"
                naziv = "KONTNI PLAN"
            Case "cntNaselja"
                naziv = "NASELJA"
            Case "cntOdlozeno"
                naziv = "ODLOŽENO"
            Case "cntOJ"
                naziv = "ORG.JEDINICE"
            Case "cntPartneri"
                naziv = "PARTNERI"
            Case "cntPDV"
                naziv = "PDV"
            Case "cntPostavke"
                naziv = "POSTAVKE"
            Case "cntSeme"
                naziv = "ŠEME"
            Case "cntMaticniPodaci"
                naziv = "MATIČNI PODACI"
            Case "cntMeniArtikli"
                naziv = "ARTIKLI"
            Case "cntMeniFinansijsko"
                naziv = "FINANSIJSKO"
            Case "cntMeniMaticniPodaci"
                naziv = "MATIČNI PODACI"
            Case "cntMeniPartneri"
                naziv = "PARTNERI"
            Case "cntMeniRobno"
                naziv = "ULAZNO-IZLAZNI DOKUMENTI" ' "ROBNO"
                'Case "cntMeniUIDokumenti"
                '    naziv = "ULAZNO-IZLAZNI DOKUMENTI"
            Case "cntMeniObradaPod"
                naziv = "OBRADA PODATAKA"
            Case "cntMeniStart"
                naziv = "FARMA"
        End Select
    End Function

    Public Function predhodna_forma(ByVal _forma As String) As Control
        predhodna_forma = Nothing
        Select Case _forma
            Case "cntRobno"
                'predhodna_forma = New cntRobno
            Case "cntArtikli"
                predhodna_forma = New cntArtikli
            Case "cntMagacini"
                predhodna_forma = New cntMagacini
            Case "cntCenovnik"
                predhodna_forma = New cntCenovnik
            Case "cntRacuni"
                predhodna_forma = New cntRacuni
            Case "cntOstaliDok"
                'predhodna_forma = New cntOstaliDok
            Case "cntUlazniRacuni"
                predhodna_forma = New cntUlazniRacuni
            Case "cntFinansijsko"
                predhodna_forma = New cntNalog
            Case "cntIzvodi"
                predhodna_forma = New cntIzvodi
            Case "cntNalozi"
                predhodna_forma = New cntNalozi_staro
            Case "cntAlati"
                predhodna_forma = New cntAlati
            Case "cntGrupeArt"
                predhodna_forma = New cntGrupeArt
            Case "cntJKL"
                predhodna_forma = New cntJKL
            Case "cntKategorije"
                predhodna_forma = New cntKategorije
            Case "cntKontniPlan"
                predhodna_forma = New cntKontniPlan
            Case "cntNaselja"
                predhodna_forma = New cntNaselja
            Case "cntOdlozeno"
                predhodna_forma = New cntOdlozeno
            Case "cntOJ"
                predhodna_forma = New cntOJ
            Case "cntPartneri"
                predhodna_forma = New cntPartneri
            Case "cntPDV"
                predhodna_forma = New cntPDV
            Case "cntPostavke"
                predhodna_forma = New cntPostavke
            Case "cntSeme"
                predhodna_forma = New cntSeme
            Case "cntMaticniPodaci"
                predhodna_forma = New cntMaticniPodaci
            Case "cntMeniArtikli"
                predhodna_forma = New cntMeniArtikli
            Case "cntMeniFinansijsko"
                predhodna_forma = New cntMeniFinansijsko
            Case "cntMeniMaticniPodaci"
                predhodna_forma = New cntMeniMaticniPodaci
            Case "cntMeniPartneri"
                predhodna_forma = New cntMeniPartneri
            Case "cntMeniRobno"
                predhodna_forma = New cntMeniRobno
                'Case "cntMeniUIDokumenti"
                '    predhodna_forma = New cntMeniRobno ' "ULAZNO-IZLAZNI DOKUMENTI"
            Case "cntMeniStart"
                predhodna_forma = New cntMeniStart
        End Select
    End Function

    Public Function Nadji_id(ByVal _tabela As String) As Integer
        Dim CN As System.Data.SqlClient.SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim _sql As String = "select * from dbo." & _tabela

        Nadji_id = 0
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql ' "select * from " & _tabela
                '.ExecuteNonQuery()
                DR = .ExecuteReader
            End With
            Try
                Do While DR.Read()
                    If DR.Item(0) > Nadji_id Then Nadji_id = DR.Item(0) '("id_stranka") > NadjiRB Then NadjiRB = DR.Item("id_stranka")
                Loop
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End If
        CM.Dispose()
        CN.Close()
        'NadjiRB += 1
    End Function

    Public Function Nadji_rb(ByVal _tabela As String, ByVal _pozicija As Integer, Optional ByVal _vrsta As String = "") As Integer
        Dim CN As System.Data.SqlClient.SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim _sql As String = "select * from dbo." & _tabela

        If _tabela = Imena.tabele.fn_nalog_head.ToString And _vrsta <> "" Then
            _sql += " where nal_vrsta = N'" & RTrim(_vrsta) & "'"
        End If

        Nadji_rb = 0
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With
            Try
                Do While DR.Read()
                    If Not IsDBNull(DR.Item(_pozicija)) And Not RTrim(DR.Item(_pozicija).ToString) = "" Then
                        If CInt(DR.Item(_pozicija)) > Nadji_rb Then Nadji_rb = CInt(DR.Item(_pozicija)) '("id_stranka") > NadjiRB Then NadjiRB = DR.Item("id_stranka")
                    End If
                Loop
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                MsgBox(ex.Message, MsgBoxStyle.OkOnly)
            End Try
        End If
        CM.Dispose()
        CN.Close()
        Nadji_rb += 1
    End Function

    Public Function Nadji_rb_dokument(ByVal _tabela As String, ByVal _pozicija As Integer, ByVal _vrsta As Integer, ByVal ostalo As Boolean) As Integer
        Dim CN As System.Data.SqlClient.SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim _sql As String = "select * from dbo." & _tabela '& " where id_vrsta_dokumenta = " & _vrsta

        If Not ostalo Then
            _sql += " where id_vrsta_dokumenta = " & _vrsta
        End If

        Nadji_rb_dokument = 0
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With
            Try
                Do While DR.Read()
                    If Not IsDBNull(DR.Item(_pozicija)) And Not RTrim(DR.Item(_pozicija).ToString) = "" Then
                        If CInt(DR.Item(_pozicija)) > Nadji_rb_dokument Then Nadji_rb_dokument = CInt(DR.Item(_pozicija)) '("id_stranka") > NadjiRB Then NadjiRB = DR.Item("id_stranka")
                    End If
                Loop
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                MsgBox(ex.Message, MsgBoxStyle.OkOnly)
            End Try
        End If
        CM.Dispose()
        CN.Close()
        Nadji_rb_dokument += 1
    End Function

    Public Function NadjiRacun(ByVal _tabela As String, ByVal _tip As Integer) As Integer
        Dim CN As System.Data.SqlClient.SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim _sql As String = "select * from racun where id_oglas = " & _tabela & " tip_oglasa = " & _tip

        NadjiRacun = 0
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql ' "select * from " & _tabela
                '.ExecuteNonQuery()
                DR = .ExecuteReader
            End With
            Try
                Do While DR.Read()
                    If DR.Item(0) > NadjiRacun Then NadjiRacun = DR.Item(0) '("id_stranka") > NadjiRB Then NadjiRB = DR.Item("id_stranka")
                Loop
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End If
        CM.Dispose()
        CN.Close()
        'NadjiRB += 1
    End Function

    Public Function izdvoj_sifru(ByVal _str As String)
        Dim i As Integer

        izdvoj_sifru = ""

        'If Len(_str) > 0 Then
        '    For i = 1 To Len(_str)
        '        If Mid(_str, i, 1) = "-" Then
        '            Izdvoj_sifru = RTrim(Mid(_str, i - 1, 1))
        '            Exit For
        '        End If
        '    Next
        'Else
        '    Izdvoj_sifru = ""
        'End If
        For i = 1 To _str.Length
            Dim a
            a = Mid(_str, i, 1)
            If Mid(_str, i, 1) <> "-" Then
                izdvoj_sifru += Mid(_str, i, 1)
            Else
                Izdvoj_sifru = RTrim(Izdvoj_sifru)
                Exit For
            End If
        Next
    End Function

    Public Function Partner_id(ByVal _partner) As Integer
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_partneri.* from dbo.app_partneri where dbo.app_partneri.partner_naziv = N'" & _partner & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                Partner_id = DR.Item("id_partner")
            Loop
        End If
        CM.Dispose()
        CN.Close()

        Return Partner_id

    End Function

    Public Function Partner_id_sif(ByVal _partner) As Integer
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_partneri.* from dbo.app_partneri where dbo.app_partneri.partner_sifra = '" & RTrim(_partner) & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                Partner_id_sif = DR.Item("id_partner")
            Loop
        End If
        CM.Dispose()
        CN.Close()

        Return Partner_id_sif

    End Function

    Public Function Partner_naziv(ByVal _partner) As String
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Partner_naziv = ""
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_partneri.* from dbo.app_partneri where dbo.app_partneri.id_partner = " & _partner '& "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                Partner_naziv = DR.Item("partner_naziv")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Public Function Partner_sifra(ByVal _partner) As String
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Partner_sifra = ""
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
                Partner_sifra = RTrim(DR.Item("sifra"))
            Loop
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Public Sub selektuj_partnera(ByVal _upit As String, ByVal _selekcija As Integer)
        On Error Resume Next
        Dim _sql As String = "select * from dbo.app_partneri where dbo.app_partneri."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_partner = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "partner_naziv = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "partner_sifra = N'" & _upit & "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            _id_partner = 0
            _partner_sifra = ""
            _partner_naziv = ""
            _partner_adresa = ""
            _partner_opstina = ""
            _partner_mesto = ""
            _partner_drazava = ""
            _partner_pib = ""
            _partner_maticni = ""
            _partner_registarski = ""
            _partner_zr = ""
            _partner_delatnost = ""
            _partner_proizvodjac = False
            _partner_dobavljac = False
            _partner_kupac = False
            
            Do While DR.Read
                If Not IsDBNull(DR.Item("id_partner")) Then _id_partner = DR.Item("id_partner")
                If Not IsDBNull(DR.Item("partner_sifra")) Then _partner_sifra = RTrim(DR.Item("partner_sifra"))
                If Not IsDBNull(DR.Item("partner_naziv")) Then _partner_naziv = RTrim(DR.Item("partner_naziv"))
                If Not IsDBNull(DR.Item("partner_adresa")) Then _partner_adresa = RTrim(DR.Item("partner_adresa"))
                If Not IsDBNull(DR.Item("partner_opstina")) Then _partner_opstina = RTrim(DR.Item("partner_opstina"))
                If Not IsDBNull(DR.Item("partner_mesto")) Then _partner_mesto = RTrim(DR.Item("partner_mesto"))
                If Not IsDBNull(DR.Item("partner_drazava")) Then _partner_drazava = RTrim(DR.Item("partner_drazava"))
                If Not IsDBNull(DR.Item("partner_pib")) Then _partner_pib = RTrim(DR.Item("partner_pib"))
                If Not IsDBNull(DR.Item("partner_maticni")) Then _partner_maticni = RTrim(DR.Item("partner_maticni"))
                If Not IsDBNull(DR.Item("partner_registarski")) Then _partner_registarski = RTrim(DR.Item("partner_registarski"))
                If Not IsDBNull(DR.Item("partner_zr")) Then _partner_zr = RTrim(DR.Item("partner_zr"))
                If Not IsDBNull(DR.Item("partner_delatnost")) Then _partner_delatnost = RTrim(DR.Item("partner_delatnost"))
                If Not IsDBNull(DR.Item("partner_proizvodjac")) Then _partner_proizvodjac = RTrim(DR.Item("partner_proizvodjac"))
                If Not IsDBNull(DR.Item("partner_dobavljac")) Then _partner_dobavljac = RTrim(DR.Item("partner_dobavljac"))
                If Not IsDBNull(DR.Item("partner_kupac")) Then _partner_kupac = RTrim(DR.Item("partner_kupac"))
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Function kategorija_naziv(ByVal _id) As String
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        kategorija_naziv = ""
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_artikl_grupa.* from dbo.app_artikl_grupa where dbo.app_artikl_grupa.id_grup_artikla = " & _id '& "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                kategorija_naziv = DR.Item("gr_artikla_naziv")
            Loop
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Public Function kategorija_id(ByVal _naziv) As String
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        kategorija_id = ""
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_artikl_vrsta.* from dbo.app_artikl_vrsta where dbo.app_artikl_vrsta.vrsta_sifra = '" & _naziv & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                kategorija_id = DR.Item("id_vrsta")
            Loop
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Public Function grupa_naziv(ByVal _id) As String
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        grupa_naziv = ""
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_artikl_grupa.* from dbo.app_artikl_grupa where dbo.app_artikl_grupa.id_grup_artikla = " & _id '& "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                grupa_naziv = DR.Item("gr_artikla_naziv")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Public Function grupa_id(ByVal _naziv) As String
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        grupa_id = ""
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_artikl_grupa.* from dbo.app_artikl_grupa where dbo.app_artikl_grupa.gr_artikla_sifra = '" & _naziv & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                grupa_id = DR.Item("id_grup_artikla")
            Loop
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Public Function jkl_naziv(ByVal _id) As String
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        jkl_naziv = ""
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_jkl.* from dbo.app_jkl where dbo.app_jkl.id_jkl = '" & _id & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                jkl_naziv = RTrim(DR.Item("jkl_sifra").ToString)
            Loop
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Public Function jkl_id(ByVal _naziv) As String
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        jkl_id = ""
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_jkl.* from dbo.app_jkl where dbo.app_jkl.jkl_sifra = '" & _naziv & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                jkl_id = RTrim(DR.Item("id_jkl").ToString)
            Loop
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Public Function pdv_stopa(ByVal _id) As Integer
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        pdv_stopa = 0
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_pdv.* from dbo.app_pdv where dbo.app_pdv.id_pdv = '" & _id & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                pdv_stopa = DR.Item("pdv_stopa")
            Loop
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Public Function pdv_id(ByVal _naziv) As String
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        pdv_id = ""
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_pdv.* from dbo.app_pdv where dbo.app_pdv.pdv_stopa = '" & _naziv & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                pdv_id = DR.Item("id_pdv")
            Loop
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Public Sub selektuj_jm(ByVal _upit As String, ByVal _selekcija As Integer)
        On Error Resume Next
        Dim _sql As String = "select * from dbo.app_jm where dbo.app_jm."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_jm = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "jm_naziv = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "jm_sifra = N'" & _upit & "'"
            Case Selekcija.po_oznaci
                _sql += "jm_oznaka = N'" & _upit & "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            _id_jm = 0
            _jm_sifra = ""
            _jm_naziv = ""
            _jm_oznaka = ""
            _jm_br_decimala = 0

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_jm")) Then _id_jm = DR.Item("id_jm")
                If Not IsDBNull(DR.Item("jm_sifra")) Then _jm_sifra = RTrim(DR.Item("jm_sifra"))
                If Not IsDBNull(DR.Item("jm_naziv")) Then _jm_naziv = RTrim(DR.Item("jm_naziv"))
                If Not IsDBNull(DR.Item("jm_oznaka")) Then _jm_oznaka = DR.Item("jm_oznaka")
                If Not IsDBNull(DR.Item("jm_br_decimala")) Then _jm_br_decimala = DR.Item("jm_br_decimala")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()

    End Sub

    Public Function mesto_naziv(ByVal _id) As String
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        mesto_naziv = ""
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_mesta.* from dbo.app_mesta where dbo.app_mesta.id_mesta = '" & _id & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                mesto_naziv = DR.Item("mesto_naziv")
            Loop
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Public Function mesto_id(ByVal _naziv) As Integer
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_mesta.* from dbo.app_mesta where dbo.app_mesta.mesto_naziv = N'" & _naziv & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                mesto_id = DR.Item("id_mesta")
            Loop
        End If
        CM.Dispose()
        CN.Close()

        Return mesto_id

    End Function

    Public Function vrstaOJ_naziv(ByVal _id) As String
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        vrstaOJ_naziv = ""
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_vrsta_oj.* from dbo.app_vrsta_oj where dbo.app_vrsta_oj.id_vrsta_oj = '" & _id & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                vrstaOJ_naziv = DR.Item("vrsta_oj_naziv")
            Loop
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Public Function vrstaOJ_id(ByVal _naziv) As Integer 'ponazivu za sad, mozda bi trebalo da se prebaci u sifru
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_vrsta_oj.* from dbo.app_vrsta_oj where dbo.app_vrsta_oj.vrsta_oj_naziv = N'" & _naziv & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                vrstaOJ_id = DR.Item("id_vrsta_oj")
            Loop
        End If
        CM.Dispose()
        CN.Close()

        Return vrstaOJ_id

    End Function

    Public Function vrsta_vodjenjaZ_naziv(ByVal _id) As String
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        vrsta_vodjenjaZ_naziv = ""
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_vodjenje_zaliha.* from dbo.rm_vodjenje_zaliha where dbo.rm_vodjenje_zaliha.id_vedjenje_zaliha = '" & _id & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                vrsta_vodjenjaZ_naziv = DR.Item("naziv")
            Loop
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Public Function vrsta_vodjenjaZ_id(ByVal _naziv) As Integer 'ponazivu za sad, mozda bi trebalo da se prebaci u sifru
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_vodjenje_zaliha.* from dbo.rm_vodjenje_zaliha where dbo.rm_vodjenje_zaliha.naziv = N'" & _naziv & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                vrsta_vodjenjaZ_id = DR.Item("id_vedjenje_zaliha")
            Loop
        End If
        CM.Dispose()
        CN.Close()

        Return vrsta_vodjenjaZ_id

    End Function

    Public Function doza_naziv(ByVal _id) As String
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        doza_naziv = ""
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_doze.* from dbo.app_doze where dbo.app_doze.id_doza = '" & _id & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                doza_naziv = DR.Item("doza_sifra")
            Loop
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Public Function doza_id(ByVal _naziv) As Integer
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_doze.* from dbo.app_doze where dbo.app_doze.doza_sifra = N'" & _naziv & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                doza_id = DR.Item("id_doza")
            Loop
        End If
        CM.Dispose()
        CN.Close()

        Return doza_id

    End Function

    Public Function doza_broj(ByVal _id) As Integer
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        doza_broj = 0
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_doze.* from dbo.app_doze where dbo.app_doze.id_doza = '" & _id & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                doza_broj = DR.Item("doza_brD")
            Loop
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Public Sub selektuj_racun(ByVal _bukmark)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select racun_head.* from racun_head where racun_head.sifra = " & _bukmark
                .ExecuteScalar()
                DR = .ExecuteReader
            End With
            'Dim 'conn As New SqlConnection()
            'conn.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Northwind.mdf;Integrated Security=True;User Instance=True"
            _id_racun = ""
            _sifra_racun = _bukmark
            _id_partner = 0
            _datum_fakturisanja = Today
            _datum_prometa = Today
            _valuta = 0
            _cena = 0
            _rabat = 0
            _pdv_iznos = 0
            _iznos = 0
            _izdat = False
            _placeno = False
            _napomena = ""

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_racun_head")) Then _id_racun = DR.Item("id_racun_head")
                'If Not IsDBNull(DR.Item("sifra")) Then _sifra_racun = DR.Item("sifra")
                If Not IsDBNull(DR.Item("id_partner")) Then _id_partner = DR.Item("id_partner")
                If Not IsDBNull(DR.Item("datum_fakturisanja")) Then _datum_fakturisanja = DR.Item("datum_fakturisanja")
                If Not IsDBNull(DR.Item("datum_prometa")) Then _datum_prometa = DR.Item("datum_prometa")
                If Not IsDBNull(DR.Item("valuta")) Then _valuta = DR.Item("valuta")
                If Not IsDBNull(DR.Item("iznos_cena")) Then _cena = DR.Item("iznos_cena")
                If Not IsDBNull(DR.Item("iznos_rabat")) Then _rabat = DR.Item("iznos_rabat")
                If Not IsDBNull(DR.Item("iznos_pdv")) Then _pdv_iznos = DR.Item("iznos_pdv")
                If Not IsDBNull(DR.Item("iznos_zanaplatu")) Then _iznos = DR.Item("iznos_zanaplatu")
                If Not IsDBNull(DR.Item("izdat")) Then _izdat = DR.Item("izdat")
                If Not IsDBNull(DR.Item("napomena")) Then _napomena = DR.Item("napomena")
                'If DR.Item("izdat") = 1 Then
                '    _izdat = True
                'Else
                '    _izdat = False
                'End If
                'End If
                If Not IsDBNull(DR.Item("placeno")) Then _placeno = DR.Item("placeno")
                'If DR.Item("placeno") = 1 Then
                '    _placeno = True
                'Else
                '    _placeno = False
                'End If
                'End If

            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub racun_print()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()

        If CN.State = ConnectionState.Open Then

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prnRacun_delete"
                .ExecuteScalar()
            End With
            CM.Dispose()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_partneri.* from dbo.app_partneri where dbo.app_partneri.id_partner = " & _id_partner
                DR = .ExecuteReader
            End With
            _partner_naziv = ""
            _partner_pib = ""
            _partner_mesto = ""
            _partner_adresa = ""
            Do While DR.Read
                If Not IsDBNull(DR.Item("naziv")) Then _partner_naziv = DR.Item("naziv")
                If Not IsDBNull(DR.Item("adresa")) Then _partner_adresa = DR.Item("adresa")
                If Not IsDBNull(DR.Item("mesto")) Then _partner_mesto = DR.Item("mesto")
                If Not IsDBNull(DR.Item("pib")) Then _partner_pib = DR.Item("pib")
            Loop
            DR.Close()
            CM.Dispose()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.racun_stavka.* from dbo.racun_stavka where dbo.racun_stavka.id_racun_head = " & _id_racun
                DR = .ExecuteReader
            End With

            Dim i As Integer = 0
            Dim stavka_rb() As Integer = New Integer(20) {}
            Dim stavka_roba() As String = New String(20) {}
            Dim stavka_kol() As Single = New Single(20) {}
            Dim stavka_cena() As Single = New Single(20) {}
            Dim stavka_rabat() As Single = New Single(20) {}
            Dim stavka_pdv() As Single = New Single(20) {}
            Dim stavka_zanaplatu() As Single = New Single(20) {}

            'ReDim stavka_prvred(5)

            Do While DR.Read
                If Not IsDBNull(DR.Item("rb")) Then stavka_rb.SetValue(DR.Item("rb"), i)
                If Not IsDBNull(DR.Item("stavka")) Then stavka_roba.SetValue(DR.Item("stavka"), i)
                If Not IsDBNull(DR.Item("kolicina")) Then stavka_kol.SetValue(CSng(DR.Item("kolicina")), i)
                If Not IsDBNull(DR.Item("cena")) Then stavka_cena.SetValue(CSng(DR.Item("cena")), i)
                If Not IsDBNull(DR.Item("rabat")) Then stavka_rabat.SetValue(CSng(DR.Item("rabat")), i)
                If Not IsDBNull(DR.Item("pdv")) Then stavka_pdv.SetValue(CSng(DR.Item("pdv")), i)
                If Not IsDBNull(DR.Item("zanaplatu")) Then stavka_zanaplatu.SetValue(CSng(DR.Item("zanaplatu")), i)
                i += 1
            Loop
            DR.Close()
            CM.Dispose()

            Dim j As Integer = 0
            For j = 0 To i - 1
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "prnRacun_add"
                    '.Parameters.AddWithValue("@id_kalk", _id_kalkulacija)
                    .Parameters.AddWithValue("@sifra", _sifra_racun)
                    .Parameters.AddWithValue("@datum_fakturisanja", _datum_fakturisanja)
                    .Parameters.AddWithValue("@datum_prometa", _datum_prometa)
                    .Parameters.AddWithValue("@valuta", _valuta)
                    .Parameters.AddWithValue("@iznos_cena", _cena)
                    .Parameters.AddWithValue("@iznos_rabat", _rabat)
                    .Parameters.AddWithValue("@iznos_pdv", _pdv_iznos)
                    .Parameters.AddWithValue("@iznos_zanaplatu", _iznos)
                    .Parameters.AddWithValue("@napomena", _napomena)

                    .Parameters.AddWithValue("@naziv", _partner_naziv)
                    .Parameters.AddWithValue("@adresa", _partner_adresa)
                    .Parameters.AddWithValue("@mesto", _partner_mesto)
                    .Parameters.AddWithValue("@pib", _partner_pib)

                    .Parameters.AddWithValue("@rb", stavka_rb(j))
                    .Parameters.AddWithValue("@stavka", stavka_roba(j))
                    .Parameters.AddWithValue("@kolicina", stavka_kol(j))
                    .Parameters.AddWithValue("@cena", stavka_cena(j))
                    .Parameters.AddWithValue("@rabat", stavka_rabat(j))
                    .Parameters.AddWithValue("@pdv", stavka_pdv(j))
                    .Parameters.AddWithValue("@zanaplatu", stavka_zanaplatu(j))
                    .ExecuteScalar()
                End With
                CM.Dispose()
            Next
        End If
        CN.Close()
    End Sub

    Public Sub selektuj_predracun(ByVal _bukmark)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_predracun_head.* from dbo.rm_predracun_head where dbo.rm_predracun_head.sifra = " & _bukmark
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            _id_predracun = ""
            _sifra_predracun = _bukmark
            _id_partner = 0
            _datum_fakturisanja = Today
            _datum_prometa = Today
            _valuta = 0
            _cena = 0
            _osnovica = 0
            _rabat = 0
            _pdv = 0
            _iznos = 0
            _napomena = ""

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_predracun_head")) Then _id_predracun = DR.Item("id_predracun_head")
                'If Not IsDBNull(DR.Item("sifra")) Then _sifra_predracun = DR.Item("sifra")
                If Not IsDBNull(DR.Item("id_partner")) Then _id_partner = DR.Item("id_partner")
                If Not IsDBNull(DR.Item("datum_fakturisanja")) Then _datum_fakturisanja = DR.Item("datum_fakturisanja")
                If Not IsDBNull(DR.Item("datum_prometa")) Then _datum_prometa = DR.Item("datum_prometa")
                If Not IsDBNull(DR.Item("valuta")) Then _valuta = DR.Item("valuta")
                If Not IsDBNull(DR.Item("iznos_cena")) Then _cena = DR.Item("iznos_cena")
                If Not IsDBNull(DR.Item("iznos_rabat")) Then _rabat = DR.Item("iznos_rabat")
                If Not IsDBNull(DR.Item("iznos_pdv")) Then _pdv = DR.Item("iznos_pdv")
                If Not IsDBNull(DR.Item("iznos_zanaplatu")) Then _iznos = DR.Item("iznos_zanaplatu")
                If Not IsDBNull(DR.Item("napomena")) Then _napomena = DR.Item("napomena")
            Loop
            DR.Close()
            _osnovica = _cena - _rabat
            _partner_naziv = Partner_naziv(_id_partner)
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub selektuj_stavke(ByVal _bukmark, ByVal _sql)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader


        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            Dim i As Integer = 0
            Do While DR.Read
                If Not IsDBNull(DR.Item("rb")) Then _
                    _artikli.SetValue(DR.Item("rb").ToString, i, 0)
                If Not IsDBNull(DR.Item("sifra")) Then _
                    _artikli.SetValue(DR.Item("sifra"), i, 1)
                If Not IsDBNull(DR.Item("stavka")) Then _
                    _artikli.SetValue(RTrim(DR.Item("stavka")), i, 2)
                If Not IsDBNull(DR.Item("kolicina")) Then _
                    _artikli.SetValue(DR.Item("kolicina").ToString, i, 3)
                If Not IsDBNull(DR.Item("cena")) Then _
                    _artikli.SetValue(DR.Item("cena").ToString, i, 4)
                If Not IsDBNull(DR.Item("rabat")) Then _
                    _artikli.SetValue(DR.Item("rabat").ToString, i, 5)
                If Not IsDBNull(DR.Item("pdv")) Then _
                    _artikli.SetValue(DR.Item("pdv").ToString, i, 6)
                If Not IsDBNull(DR.Item("zanaplatu")) Then _
                    _artikli.SetValue(DR.Item("zanaplatu").ToString, i, 7)
                i += 1
            Loop
            DR.Close()
            _broj_stavki = i
        End If
        CM.Dispose()
        CN.Close()

    End Sub

    Public Sub selektuj_ulazni_racun(ByVal _bukmark)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select ulazni_racuni_head.* from ulazni_racuni_head where ulazni_racuni_head.sifra = " & _bukmark
                .ExecuteScalar()
                DR = .ExecuteReader
            End With
            'Dim 'conn As New SqlConnection()
            'conn.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Northwind.mdf;Integrated Security=True;User Instance=True"
            _id_racun = ""
            _sifra_racun = _bukmark
            _id_partner = 0
            _datum_fakturisanja = Today
            _datum_valuta = Today
            _valuta = 0
            _cena = 0
            _rabat = 0
            _pdv = 0
            _iznos = 0
            _unesen = False
            _placeno = False
            _broj_fakture = ""
            _napomena = ""

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_racun_head")) Then _id_racun = DR.Item("id_racun_head")
                'If Not IsDBNull(DR.Item("sifra")) Then _sifra_racun = DR.Item("sifra")
                If Not IsDBNull(DR.Item("id_partner")) Then _id_partner = DR.Item("id_partner")
                If Not IsDBNull(DR.Item("br_fakture")) Then _broj_fakture = DR.Item("br_fakture")
                If Not IsDBNull(DR.Item("datum_fakturisanja")) Then _datum_fakturisanja = DR.Item("datum_fakturisanja")
                If Not IsDBNull(DR.Item("datum_valuta")) Then _datum_valuta = DR.Item("datum_valuta")
                If Not IsDBNull(DR.Item("valuta")) Then _valuta = DR.Item("valuta")
                If Not IsDBNull(DR.Item("iznos_cena")) Then _cena = DR.Item("iznos_cena")
                If Not IsDBNull(DR.Item("iznos_rabat")) Then _rabat = DR.Item("iznos_rabat")
                If Not IsDBNull(DR.Item("iznos_pdv")) Then _pdv = DR.Item("iznos_pdv")
                If Not IsDBNull(DR.Item("iznos_zanaplatu")) Then _iznos = DR.Item("iznos_zanaplatu")
                If Not IsDBNull(DR.Item("napomena")) Then _napomena = DR.Item("napomena")
                If Not IsDBNull(DR.Item("unesen")) Then _unesen = DR.Item("unesen")
                'If DR.Item("unesen") = True Then
                '    _unesen = True
                'Else
                '    _unesen = False
                'End If
                'End If
                If Not IsDBNull(DR.Item("placeno")) Then _placeno = DR.Item("placeno")
                'If DR.Item("placeno") = True Then
                '    _placeno = True
                'Else
                '    _placeno = False
                'End If
                'End If

            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub selektuj_radni_nalog(ByVal tBroj)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_radni_nalog_head.* from dbo.rm_radni_nalog_head where dbo.rm_radni_nalog_head.broj = " & tBroj
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            _id_radni_nalog = 0
            _broj = tBroj
            _partner_naziv = ""
            _grad_nalog = ""
            _objekat = ""
            _adresa_nalog = ""
            _telefon_nalog = ""
            _kontakt_nalog = ""
            _montaza = False
            _popravka = False
            _servis = False
            _ispitivanje = False
            _preventiva = False
            _polazak_datum = Today
            _polazak_vreme = ""
            _povratak_datum = Today
            _povratak_vreme = ""
            _vozilo_naziv = ""
            _vozilo_registracija = ""
            _kilometraza = ""
            _opis = ""

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_radninalog")) Then _id_radni_nalog = DR.Item("id_radninalog")
                'If Not IsDBNull(DR.Item("broj")) Then _broj = DR.Item("broj")
                If Not IsDBNull(DR.Item("firma")) Then _partner_naziv = DR.Item("firma")
                If Not IsDBNull(DR.Item("mesto")) Then _grad_nalog = DR.Item("mesto")
                If Not IsDBNull(DR.Item("objekat")) Then _objekat = DR.Item("objekat")
                If Not IsDBNull(DR.Item("adresa")) Then _adresa_nalog = DR.Item("adresa")
                If Not IsDBNull(DR.Item("telefon")) Then _telefon_nalog = DR.Item("telefon")
                If Not IsDBNull(DR.Item("kontakt")) Then _kontakt_nalog = DR.Item("kontakt")
                If Not IsDBNull(DR.Item("monatza")) Then _montaza = DR.Item("monatza")
                If Not IsDBNull(DR.Item("popravka")) Then _popravka = DR.Item("popravka")
                If Not IsDBNull(DR.Item("servisiranje")) Then _servis = DR.Item("servisiranje")
                If Not IsDBNull(DR.Item("ispitivanje")) Then _ispitivanje = DR.Item("ispitivanje")
                If Not IsDBNull(DR.Item("preventiva")) Then _preventiva = DR.Item("preventiva")
                If Not IsDBNull(DR.Item("polazak_datum")) Then _polazak_datum = DR.Item("polazak_datum")
                If Not IsDBNull(DR.Item("polazak_vreme")) Then _polazak_vreme = DR.Item("polazak_vreme")
                If Not IsDBNull(DR.Item("povratak_datum")) Then _povratak_datum = DR.Item("povratak_datum")
                If Not IsDBNull(DR.Item("povratak_vreme")) Then _povratak_vreme = DR.Item("povratak_vreme")
                If Not IsDBNull(DR.Item("vozilo_naziv")) Then _vozilo_naziv = DR.Item("vozilo_naziv")
                If Not IsDBNull(DR.Item("vozilo_registracija")) Then _vozilo_registracija = DR.Item("vozilo_registracija")
                If Not IsDBNull(DR.Item("kilometraza")) Then _kilometraza = DR.Item("kilometraza")
                If Not IsDBNull(DR.Item("opis")) Then _opis = DR.Item("opis")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub selektuj_potvrdu(ByVal tId)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.radni_nalog_potvrda.* " & _
                               "from dbo.radni_nalog_potvrda " & _
                               "where dbo.radni_nalog_potvrda.broj = " & tId
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            _id_radni_nalog_potvrda = 0
            _id_radni_nalog = tId
            _broj = 0
            _montaza = False
            _montaza_end = False
            _montaza_datum = Today
            _popravka = False
            _popravka_end = False
            _popravka_datum = Today
            _servis = False
            _servis_end = False
            _servis_datum = Today
            _ispitivanje = False
            _ispitivanje_end = False
            _ispitivanje_datum = Today
            _ugovor = False
            _ugovor_end = False
            _ugovor_datum = Today
            _napomene = ""
            _izdat = False

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_radninalog_potvrda")) Then _id_radni_nalog_potvrda = DR.Item("id_radninalog_potvrda")
                'If Not IsDBNull(DR.Item("id_radninalog")) Then _id_radni_nalog = DR.Item("id_radninalog")
                If Not IsDBNull(DR.Item("broj")) Then _broj = DR.Item("broj")
                If Not IsDBNull(DR.Item("montaza")) Then _montaza = DR.Item("montaza")
                If Not IsDBNull(DR.Item("montaza_end")) Then _montaza_end = DR.Item("montaza_end")
                If Not IsDBNull(DR.Item("montaza_datum")) Then _montaza_datum = DR.Item("montaza_datum")
                If Not IsDBNull(DR.Item("popravka")) Then _popravka = DR.Item("popravka")
                If Not IsDBNull(DR.Item("popravka_end")) Then _popravka_end = DR.Item("popravka_end")
                If Not IsDBNull(DR.Item("popravka_datum")) Then _popravka_datum = DR.Item("popravka_datum")
                If Not IsDBNull(DR.Item("servis")) Then _servis = DR.Item("servis")
                If Not IsDBNull(DR.Item("servis_end")) Then _servis_end = DR.Item("servis_end")
                If Not IsDBNull(DR.Item("servis_datum")) Then _servis_datum = DR.Item("servis_datum")
                If Not IsDBNull(DR.Item("ispitivanje")) Then _ispitivanje = DR.Item("ispitivanje")
                If Not IsDBNull(DR.Item("ispitivanje_end")) Then _ispitivanje_end = DR.Item("ispitivanje_end")
                If Not IsDBNull(DR.Item("ispitivanje_datum")) Then _ispitivanje_datum = DR.Item("ispitivanje_datum")
                If Not IsDBNull(DR.Item("ugovor")) Then _ugovor = DR.Item("ugovor")
                If Not IsDBNull(DR.Item("ugovor_end")) Then _ugovor_end = DR.Item("ugovor_end")
                If Not IsDBNull(DR.Item("ugovor_datum")) Then _ugovor_datum = DR.Item("ugovor_datum")
                If Not IsDBNull(DR.Item("napomene")) Then _napomene = DR.Item("napomene")
                If Not IsDBNull(DR.Item("izdata")) Then _izdat = DR.Item("izdata")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    '***********************************

    Public Sub selektuj_dokument_ul(ByVal _upit As String, ByVal _selekcija As Integer)
        On Error Resume Next
        Dim _sql As String = "select * from dbo.rm_ulazni_dokument_head where dbo.rm_ulazni_dokument_head."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_dokument = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "dok_opis = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "dok_broj = " & _upit '& "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                If _sve Then
                    .CommandText = _sql
                Else
                    .CommandText = _sql & " and id_vrsta_dokumenta = " & mRob_Dokument.dokumenta_id
                End If
                DR = .ExecuteReader
            End With

            _id_dokument = 0
            _dok_id_vrsta_dokumenta = 0
            _dok_sifra_dokumenta = ""
            _dok_broj = 0
            _dok_id_magacina = 0
            _dok_id_partner = 0
            _dok_datum_fakture = Today
            _dok_datum = Today
            _dok_opis = 0
            _dok_ukupno = 0
            _dok_ztroskovi = 0
            _dok_rabat = 0
            _dok_razlika_uceni = 0
            _dok_pdv_osnovica = 0
            _dok_pdv = 0
            _dok_svega = 0
            _dok_zakljucen = False


            Do While DR.Read
                If Not IsDBNull(DR.Item("id_dokument")) Then _id_dokument = DR.Item("id_dokument")
                If Not IsDBNull(DR.Item("id_vrsta_dokumenta")) Then _dok_id_vrsta_dokumenta = DR.Item("id_vrsta_dokumenta")
                If Not IsDBNull(DR.Item("sifra_dokumenta")) Then _dok_sifra_dokumenta = RTrim(DR.Item("sifra_dokumenta"))
                If Not IsDBNull(DR.Item("dok_broj")) Then _dok_broj = DR.Item("dok_broj")
                If Not IsDBNull(DR.Item("id_magacina")) Then _dok_id_magacina = DR.Item("id_magacina")
                If Not IsDBNull(DR.Item("id_partner")) Then _dok_id_partner = DR.Item("id_partner")
                If Not IsDBNull(DR.Item("dok_datum_fakture")) Then _datum_fakturisanja = DR.Item("dok_datum_fakture")
                If Not IsDBNull(DR.Item("dok_datum")) Then _dok_datum = DR.Item("dok_datum")
                If Not IsDBNull(DR.Item("dok_opis")) Then _dok_opis = DR.Item("dok_opis")
                If Not IsDBNull(DR.Item("dok_ukupno")) Then _dok_ukupno = DR.Item("dok_ukupno")
                If Not IsDBNull(DR.Item("dok_ztroskovi")) Then _dok_ztroskovi = DR.Item("dok_ztroskovi")
                If Not IsDBNull(DR.Item("dok_rabat")) Then _dok_rabat = DR.Item("dok_rabat")
                If Not IsDBNull(DR.Item("dok_razlika_uceni")) Then _dok_razlika_uceni = DR.Item("dok_razlika_uceni")
                If Not IsDBNull(DR.Item("dok_pdv_osnovica")) Then _dok_pdv_osnovica = DR.Item("dok_pdv_osnovica")
                If Not IsDBNull(DR.Item("dok_pdv")) Then _dok_pdv = DR.Item("dok_pdv")
                If Not IsDBNull(DR.Item("dok_svega")) Then _dok_svega = DR.Item("dok_svega")
                If Not IsDBNull(DR.Item("dok_zakljucen")) Then _dok_zakljucen = DR.Item("dok_zakljucen")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub dokument_ul_print()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim CM1 As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_ulazni_dokument_prn_delete"
                .ExecuteScalar()
            End With
            CM.Dispose()

            CM1 = New SqlCommand()
            With CM1
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.rm_ulazni_dokument_stavka where dbo.rm_ulazni_dokument_stavka.id_dokument = " & _id_dokument
                DR = .ExecuteReader
            End With

            Dim i As Integer = 0
            Dim st_rb() As String = New String(100) {}
            'Dim st_id() As Integer = New Integer(100) {}
            Dim st_roba_sifra() As String = New String(100) {}
            Dim st_roba_naziv() As String = New String(100) {}
            Dim st_roba_grupa_sifra() As String = New String(100) {}
            Dim st_roba_grupa_oznaka() As String = New String(100) {}
            Dim st_jkl() As String = New String(100) {}
            Dim st_jm() As String = New String(100) {}
            Dim st_kol() As Single = New Single(100) {}
            Dim st_ncena() As Single = New Single(100) {}
            Dim st_rabat() As Single = New Single(100) {}
            Dim st_ztros() As Single = New Single(100) {}
            Dim st_ckostanja() As Single = New Single(100) {}
            Dim st_nvred() As Single = New Single(100) {}
            Dim st_marza() As Single = New Single(100) {}
            Dim st_pdv() As Single = New Single(100) {}
            Dim st_prcena() As Single = New Single(100) {}
            Dim st_pdv_iznos() As Single = New Single(100) {}
            Dim st_prvred() As Single = New Single(100) {}

            Do While DR.Read
                'If Not IsDBNull(DR.Item("id_dokument")) Then st_id.SetValue(DR.Item("id_dokument"), i)
                If Not IsDBNull(DR.Item("dok_st_rb")) Then st_rb.SetValue(DR.Item("dok_st_rb"), i)
                If Not IsDBNull(DR.Item("dok_st_roba_sifra")) Then st_roba_sifra.SetValue(DR.Item("dok_st_roba_sifra"), i)
                If Not IsDBNull(DR.Item("dok_st_roba_naziv")) Then st_roba_naziv.SetValue(DR.Item("dok_st_roba_naziv"), i)
                If Not IsDBNull(DR.Item("dok_st_roba_grupa_sifra")) Then st_roba_grupa_sifra.SetValue(DR.Item("dok_st_roba_grupa_sifra"), i)
                If Not IsDBNull(DR.Item("dok_st_roba_grupa_oznaka")) Then st_roba_grupa_oznaka.SetValue(DR.Item("dok_st_roba_grupa_oznaka"), i)
                If Not IsDBNull(DR.Item("dok_st_roba_jkl")) Then st_jkl.SetValue(DR.Item("dok_st_roba_jkl"), i)
                If Not IsDBNull(DR.Item("dok_st_roba_jm")) Then st_jm.SetValue(DR.Item("dok_st_roba_jm"), i)
                If Not IsDBNull(DR.Item("dok_st_kolicina")) Then st_kol.SetValue(CSng(DR.Item("dok_st_kolicina")), i)
                If Not IsDBNull(DR.Item("dok_st_nab_cena")) Then st_ncena.SetValue(CSng(DR.Item("dok_st_nab_cena")), i)
                If Not IsDBNull(DR.Item("dok_st_rabat")) Then st_rabat.SetValue(CSng(DR.Item("dok_st_rabat")), i)
                If Not IsDBNull(DR.Item("dok_st_zav_troskovi")) Then st_ztros.SetValue(CSng(DR.Item("dok_st_zav_troskovi")), i)
                If Not IsDBNull(DR.Item("dok_st_cena_kostanja")) Then st_ckostanja.SetValue(CSng(DR.Item("dok_st_cena_kostanja")), i)
                If Not IsDBNull(DR.Item("dok_st_nab_vred")) Then st_nvred.SetValue(CSng(DR.Item("dok_st_nab_vred")), i)
                If Not IsDBNull(DR.Item("dok_st_marza")) Then st_marza.SetValue(CSng(DR.Item("dok_st_marza")), i)
                If Not IsDBNull(DR.Item("dok_st_pdv")) Then st_pdv.SetValue(DR.Item("dok_st_pdv"), i)
                If Not IsDBNull(DR.Item("dok_st_prod_cena")) Then st_prcena.SetValue(CSng(DR.Item("dok_st_prod_cena")), i)
                If Not IsDBNull(DR.Item("dok_st_pdv_iznos")) Then st_pdv_iznos.SetValue(CSng(DR.Item("dok_st_pdv_iznos")), i)
                If Not IsDBNull(DR.Item("dok_st_prod_vred")) Then st_prvred.SetValue(CSng(DR.Item("dok_st_prod_vred")), i)
                i += 1
            Loop
            DR.Close()
            CM1.Dispose()

            Dim j As Integer = 0
            For j = 0 To i - 1
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_ulazni_dokument_prn_add"
                    .Parameters.AddWithValue("@id_dokument", _id_dokument)
                    .Parameters.AddWithValue("@id_vrsta_dokumenta", _dok_id_vrsta_dokumenta)
                    .Parameters.AddWithValue("@sifra_dokumenta", _dok_sifra_dokumenta)
                    .Parameters.AddWithValue("@dok_broj", _dok_broj)
                    .Parameters.AddWithValue("@id_magacina", _dok_id_magacina)
                    .Parameters.AddWithValue("@id_partner", _dok_id_partner)
                    .Parameters.AddWithValue("@dok_datum_fakture", _dok_datum)
                    .Parameters.AddWithValue("@dok_datum", _dok_datum_fakture)
                    .Parameters.AddWithValue("@dok_opis", _dok_opis)
                    .Parameters.AddWithValue("@dok_ukupno", _dok_ukupno)
                    .Parameters.AddWithValue("@dok_ztroskovi", _dok_ztroskovi)
                    .Parameters.AddWithValue("@dok_rabat", _dok_rabat)
                    .Parameters.AddWithValue("@dok_razlika_uceni", _dok_razlika_uceni)
                    .Parameters.AddWithValue("@dok_pdv_osnovica", _dok_pdv_osnovica)
                    .Parameters.AddWithValue("@dok_pdv", _dok_pdv)
                    .Parameters.AddWithValue("@dok_svega", _dok_svega)
                    .Parameters.AddWithValue("@dok_zakljucen", _dok_zakljucen)
                    .Parameters.AddWithValue("@dok_st_rb", st_rb(j))
                    .Parameters.AddWithValue("@dok_st_roba_sifra", st_roba_sifra(j))
                    .Parameters.AddWithValue("@dok_st_roba_naziv", st_roba_naziv(j))
                    .Parameters.AddWithValue("@dok_st_roba_grupa_sifra", st_roba_grupa_sifra(j))
                    .Parameters.AddWithValue("@dok_st_roba_grupa_oznaka", st_roba_grupa_oznaka(j))
                    .Parameters.AddWithValue("@dok_st_roba_jkl", st_jkl(j))
                    .Parameters.AddWithValue("@dok_st_roba_jm", st_jm(j))
                    .Parameters.AddWithValue("@dok_st_kolicina", st_kol(j))
                    .Parameters.AddWithValue("@dok_st_nab_cena", st_ncena(j))
                    .Parameters.AddWithValue("@dok_st_rabat", st_rabat(j))
                    .Parameters.AddWithValue("@dok_st_zav_troskovi", st_ztros(j))
                    .Parameters.AddWithValue("@dok_st_cena_kostanja", st_ckostanja(j))
                    .Parameters.AddWithValue("@dok_st_nab_vred", st_nvred(j))
                    .Parameters.AddWithValue("@dok_st_marza", st_marza(j))
                    .Parameters.AddWithValue("@dok_st_pdv", st_pdv(j))
                    .Parameters.AddWithValue("@dok_st_prod_cena", st_prcena(j))
                    .Parameters.AddWithValue("@dok_st_pdv_iznos", st_pdv_iznos(j))
                    .Parameters.AddWithValue("@dok_st_prod_vred", st_prvred(j))
                    .ExecuteScalar()
                End With
                CM.Dispose()
            Next
        End If
        CN.Close()
    End Sub

    Public Sub selektuj_dokument_izl(ByVal _upit As String, ByVal _selekcija As Integer)
        On Error Resume Next
        Dim _sql As String = "select * from dbo.rm_izlazni_dokument_head where dbo.rm_izlazni_dokument_head."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_dokument = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "dok_opis = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "dok_broj = " & _upit '& "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                If _sve Then
                    .CommandText = _sql
                Else
                    .CommandText = _sql & " and id_vrsta_dokumenta = " & mRob_Dokument.dokumenta_id
                End If
                DR = .ExecuteReader
            End With

            _id_dokument = 0
            _dok_id_vrsta_dokumenta = 0
            _dok_sifra_dokumenta = ""
            _dok_broj = 0
            _dok_id_magacina = 0
            _dok_id_partner = 0
            _dok_datum_fakture = Today
            _dok_datum = Today
            _dok_opis = 0
            _dok_ukupno = 0
            _dok_ztroskovi = 0
            _dok_marza = 0
            _dok_rabat = 0
            _dok_razlika_uceni = 0
            _dok_pdv_osnovica = 0
            _dok_pdv = 0
            _dok_svega = 0
            _dok_zakljucen = False

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_dokument")) Then _id_dokument = DR.Item("id_dokument")
                If Not IsDBNull(DR.Item("id_vrsta_dokumenta")) Then _dok_id_vrsta_dokumenta = DR.Item("id_vrsta_dokumenta")
                If Not IsDBNull(DR.Item("sifra_dokumenta")) Then _dok_sifra_dokumenta = DR.Item("sifra_dokumenta")
                If Not IsDBNull(DR.Item("dok_broj")) Then _dok_broj = DR.Item("dok_broj")
                If Not IsDBNull(DR.Item("id_magacina")) Then _dok_id_magacina = DR.Item("id_magacina")
                If Not IsDBNull(DR.Item("id_partner")) Then _dok_id_partner = DR.Item("id_partner")
                If Not IsDBNull(DR.Item("dok_datum_fakture")) Then _datum_fakturisanja = DR.Item("dok_datum_fakture")
                If Not IsDBNull(DR.Item("dok_datum")) Then _dok_datum = DR.Item("dok_datum")
                If Not IsDBNull(DR.Item("dok_opis")) Then _dok_opis = DR.Item("dok_opis")
                If Not IsDBNull(DR.Item("dok_ukupno")) Then _dok_ukupno = DR.Item("dok_ukupno")
                If Not IsDBNull(DR.Item("dok_ztroskovi")) Then _dok_ztroskovi = DR.Item("dok_ztroskovi")
                If Not IsDBNull(DR.Item("dok_marza")) Then _dok_marza = DR.Item("dok_marza")
                If Not IsDBNull(DR.Item("dok_rabat")) Then _dok_rabat = DR.Item("dok_rabat")
                If Not IsDBNull(DR.Item("dok_razlika_uceni")) Then _dok_razlika_uceni = DR.Item("dok_razlika_uceni")
                If Not IsDBNull(DR.Item("dok_pdv_osnovica")) Then _dok_pdv_osnovica = DR.Item("dok_pdv_osnovica")
                If Not IsDBNull(DR.Item("dok_pdv")) Then _dok_pdv = DR.Item("dok_pdv")
                If Not IsDBNull(DR.Item("dok_svega")) Then _dok_svega = DR.Item("dok_svega")
                If Not IsDBNull(DR.Item("dok_zakljucen")) Then _dok_zakljucen = DR.Item("dok_zakljucen")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub dokument_izl_print()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim CM1 As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_izlazni_dokument_prn_delete"
                .ExecuteScalar()
            End With
            CM.Dispose()

            CM1 = New SqlCommand()
            With CM1
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.rm_izlazni_dokument_stavka where dbo.rm_izlazni_dokument_stavka.id_dokument = " & _id_dokument
                DR = .ExecuteReader
            End With

            Dim i As Integer = 0
            Dim st_rb() As String = New String(100) {}
            'Dim st_id() As Integer = New Integer(100) {}
            Dim st_roba_sifra() As String = New String(100) {}
            Dim st_roba_naziv() As String = New String(100) {}
            Dim st_roba_grupa_sifra() As String = New String(100) {}
            Dim st_roba_grupa_oznaka() As String = New String(100) {}
            Dim st_jkl() As String = New String(100) {}
            Dim st_jm() As String = New String(100) {}
            Dim st_kol() As Single = New Single(100) {}
            Dim st_ncena() As Single = New Single(100) {}
            Dim st_marza() As Single = New Single(100) {}
            Dim st_rabat() As Single = New Single(100) {}
            Dim st_ztros() As Single = New Single(100) {}
            Dim st_ckostanja() As Single = New Single(100) {}
            Dim st_nvred() As Single = New Single(100) {}
            Dim st_pdv() As Single = New Single(100) {}
            Dim st_prcena() As Single = New Single(100) {}
            Dim st_pdv_iznos() As Single = New Single(100) {}
            Dim st_prvred() As Single = New Single(100) {}

            Do While DR.Read
                'If Not IsDBNull(DR.Item("id_dokument")) Then st_id.SetValue(DR.Item("id_dokument"), i)
                If Not IsDBNull(DR.Item("dok_st_rb")) Then st_rb.SetValue(DR.Item("dok_st_rb"), i)
                If Not IsDBNull(DR.Item("dok_st_roba_sifra")) Then st_roba_sifra.SetValue(DR.Item("dok_st_roba_sifra"), i)
                If Not IsDBNull(DR.Item("dok_st_roba_naziv")) Then st_roba_naziv.SetValue(DR.Item("dok_st_roba_naziv"), i)
                If Not IsDBNull(DR.Item("dok_st_roba_grupa_sifra")) Then st_roba_grupa_sifra.SetValue(DR.Item("dok_st_roba_grupa_sifra"), i)
                If Not IsDBNull(DR.Item("dok_st_roba_grupa_oznaka")) Then st_roba_grupa_oznaka.SetValue(DR.Item("dok_st_roba_grupa_oznaka"), i)
                If Not IsDBNull(DR.Item("dok_st_roba_jkl")) Then st_jkl.SetValue(DR.Item("dok_st_roba_jkl"), i)
                If Not IsDBNull(DR.Item("dok_st_roba_jm")) Then st_jm.SetValue(DR.Item("dok_st_roba_jm"), i)
                If Not IsDBNull(DR.Item("dok_st_kolicina")) Then st_kol.SetValue(CSng(DR.Item("dok_st_kolicina")), i)
                If Not IsDBNull(DR.Item("dok_st_nab_cena")) Then st_ncena.SetValue(CSng(DR.Item("dok_st_nab_cena")), i)
                If Not IsDBNull(DR.Item("dok_st_rabat")) Then st_rabat.SetValue(CSng(DR.Item("dok_st_rabat")), i)
                If Not IsDBNull(DR.Item("dok_st_zav_troskovi")) Then st_ztros.SetValue(CSng(DR.Item("dok_st_zav_troskovi")), i)
                If Not IsDBNull(DR.Item("dok_st_cena_kostanja")) Then st_ckostanja.SetValue(CSng(DR.Item("dok_st_cena_kostanja")), i)
                If Not IsDBNull(DR.Item("dok_st_nab_vred")) Then st_nvred.SetValue(CSng(DR.Item("dok_st_nab_vred")), i)
                If Not IsDBNull(DR.Item("dok_st_marza")) Then st_marza.SetValue(CSng(DR.Item("dok_st_marza")), i)
                If Not IsDBNull(DR.Item("dok_st_pdv")) Then st_pdv.SetValue(DR.Item("dok_st_pdv"), i)
                If Not IsDBNull(DR.Item("dok_st_prod_cena")) Then st_prcena.SetValue(CSng(DR.Item("dok_st_prod_cena")), i)
                If Not IsDBNull(DR.Item("dok_st_pdv_iznos")) Then st_pdv_iznos.SetValue(CSng(DR.Item("dok_st_pdv_iznos")), i)
                If Not IsDBNull(DR.Item("dok_st_prod_vred")) Then st_prvred.SetValue(CSng(DR.Item("dok_st_prod_vred")), i)
                i += 1
            Loop
            DR.Close()
            CM1.Dispose()

            Dim j As Integer = 0
            For j = 0 To i - 1
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_izlazni_dokument_prn_add"
                    .Parameters.AddWithValue("@id_dokument", _id_dokument)
                    .Parameters.AddWithValue("@id_vrsta_dokumenta", _dok_id_vrsta_dokumenta)
                    .Parameters.AddWithValue("@sifra_dokumenta", _dok_sifra_dokumenta)
                    .Parameters.AddWithValue("@dok_broj", _dok_broj)
                    .Parameters.AddWithValue("@id_magacina", _dok_id_magacina)
                    .Parameters.AddWithValue("@id_partner", _dok_id_partner)
                    .Parameters.AddWithValue("@dok_datum_fakture", _dok_datum)
                    .Parameters.AddWithValue("@dok_datum", _dok_datum_fakture)
                    .Parameters.AddWithValue("@dok_opis", _dok_opis)
                    .Parameters.AddWithValue("@dok_ukupno", _dok_ukupno)
                    .Parameters.AddWithValue("@dok_ztroskovi", _dok_ztroskovi)
                    .Parameters.AddWithValue("@dok_marza", _dok_marza)
                    .Parameters.AddWithValue("@dok_rabat", _dok_rabat)
                    .Parameters.AddWithValue("@dok_razlika_uceni", _dok_razlika_uceni)
                    .Parameters.AddWithValue("@dok_pdv_osnovica", _dok_pdv_osnovica)
                    .Parameters.AddWithValue("@dok_pdv", _dok_pdv)
                    .Parameters.AddWithValue("@dok_svega", _dok_svega)
                    .Parameters.AddWithValue("@dok_zakljucen", _dok_zakljucen)
                    .Parameters.AddWithValue("@dok_st_rb", st_rb(j))
                    .Parameters.AddWithValue("@dok_st_roba_sifra", st_roba_sifra(j))
                    .Parameters.AddWithValue("@dok_st_roba_naziv", st_roba_naziv(j))
                    .Parameters.AddWithValue("@dok_st_roba_grupa_sifra", st_roba_grupa_sifra(j))
                    .Parameters.AddWithValue("@dok_st_roba_grupa_oznaka", st_roba_grupa_oznaka(j))
                    .Parameters.AddWithValue("@dok_st_roba_jkl", st_jkl(j))
                    .Parameters.AddWithValue("@dok_st_roba_jm", st_jm(j))
                    .Parameters.AddWithValue("@dok_st_kolicina", st_kol(j))
                    .Parameters.AddWithValue("@dok_st_nab_cena", st_ncena(j))
                    .Parameters.AddWithValue("@dok_st_rabat", st_rabat(j))
                    .Parameters.AddWithValue("@dok_st_zav_troskovi", st_ztros(j))
                    .Parameters.AddWithValue("@dok_st_cena_kostanja", st_ckostanja(j))
                    .Parameters.AddWithValue("@dok_st_nab_vred", st_nvred(j))
                    .Parameters.AddWithValue("@dok_st_marza", st_marza(j))
                    .Parameters.AddWithValue("@dok_st_pdv", st_pdv(j))
                    .Parameters.AddWithValue("@dok_st_prod_cena", st_prcena(j))
                    .Parameters.AddWithValue("@dok_st_pdv_iznos", st_pdv_iznos(j))
                    .Parameters.AddWithValue("@dok_st_prod_vred", st_prvred(j))
                    .ExecuteScalar()
                End With
                CM.Dispose()
            Next
        End If
        CN.Close()
    End Sub

    Public Sub storno_dokument(ByVal id, ByVal broj, ByVal id_vrsta, ByVal ui)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        If CN.State = ConnectionState.Open Then
           
            If MsgBox("Dali želite istovremeno i da zaključite storno dokument?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                _dok_zakljucen = True
            Else
                _dok_zakljucen = False
            End If

            _dok_storno_broj = Nadji_rb_dokument("rm_ulazni_dokument_head", 3, 22, False)

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_ulazni_dokument_head_add"
                .Parameters.AddWithValue("@id_vrsta_dokumenta", 22) '_dok_id_vrsta_dokumenta)
                .Parameters.AddWithValue("@sifra_dokumenta", 999) ' _dok_sifra_dokumenta)
                .Parameters.AddWithValue("@dok_broj", _dok_storno_broj)
                .Parameters.AddWithValue("@id_magacina", _dok_id_magacina)
                .Parameters.AddWithValue("@id_partner", _dok_id_partner)
                .Parameters.AddWithValue("@dok_datum_fakture", _dok_datum_fakture)
                .Parameters.AddWithValue("@dok_datum", Today.Date) ' _dok_datum)
                selektuj_VrsteDokumenta(_dok_id_vrsta_dokumenta, Selekcija.po_id)
                .Parameters.AddWithValue("@dok_opis", "STORNO " & _vrsta_dok_naziv & " " & _dok_broj) ' _dok_opis)
                .Parameters.AddWithValue("@dok_ukupno", (-1) * _dok_ukupno)
                .Parameters.AddWithValue("@dok_ztroskovi", (-1) * _dok_ztroskovi)
                .Parameters.AddWithValue("@dok_rabat", (-1) * _dok_rabat)
                .Parameters.AddWithValue("@dok_razlika_uceni", (-1) * _dok_razlika_uceni)
                .Parameters.AddWithValue("@dok_pdv_osnovica", (-1) * _dok_pdv_osnovica)
                .Parameters.AddWithValue("@dok_pdv", (-1) * _dok_pdv)
                .Parameters.AddWithValue("@dok_svega", (-1) * _dok_svega)
                .Parameters.AddWithValue("@dok_zakljucen", _dok_zakljucen)
                .ExecuteScalar()
            End With
            CM.Dispose()

            _id_storno = Nadji_id("rm_ulazni_dokument_head")

            unesi_dnevni_promet_head(Today.Date, Now, _dok_id_magacina, 0, _dok_id_partner, 22, _
                            _id_storno, _dok_storno_broj, _dok_ukupno, 0, 1, 0, vrsta_promene.unos)


            _id_dnevni_promet = Nadji_id(Imena.tabele.rm_dnevni_promet_head.ToString)

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.rm_ulazni_dokument_stavka where dbo.rm_ulazni_dokument_stavka.id_dokument = " & _id_dokument
                DR = .ExecuteReader
            End With

            Dim i As Integer = 0
            Dim st_rb() As String = New String(100) {}
            Dim st_roba_sifra() As String = New String(100) {}
            Dim st_roba_naziv() As String = New String(100) {}
            Dim st_roba_grupa_sifra() As String = New String(100) {}
            Dim st_roba_grupa_oznaka() As String = New String(100) {}
            Dim st_jkl() As String = New String(100) {}
            Dim st_jm() As String = New String(100) {}
            Dim st_kol() As Single = New Single(100) {}
            Dim st_ncena() As Single = New Single(100) {}
            Dim st_rabat() As Single = New Single(100) {}
            Dim st_ztros() As Single = New Single(100) {}
            Dim st_ckostanja() As Single = New Single(100) {}
            Dim st_nvred() As Single = New Single(100) {}
            Dim st_marza() As Single = New Single(100) {}
            Dim st_pdv() As Single = New Single(100) {}
            Dim st_prcena() As Single = New Single(100) {}
            Dim st_pdv_iznos() As Single = New Single(100) {}
            Dim st_prvred() As Single = New Single(100) {}

            Do While DR.Read
                If Not IsDBNull(DR.Item("dok_st_rb")) Then st_rb.SetValue(DR.Item("dok_st_rb"), i)
                If Not IsDBNull(DR.Item("dok_st_roba_sifra")) Then st_roba_sifra.SetValue(DR.Item("dok_st_roba_sifra"), i)
                If Not IsDBNull(DR.Item("dok_st_roba_naziv")) Then st_roba_naziv.SetValue(DR.Item("dok_st_roba_naziv"), i)
                If Not IsDBNull(DR.Item("dok_st_roba_grupa_sifra")) Then st_roba_grupa_sifra.SetValue(DR.Item("dok_st_roba_grupa_sifra"), i)
                If Not IsDBNull(DR.Item("dok_st_roba_grupa_oznaka")) Then st_roba_grupa_oznaka.SetValue(DR.Item("dok_st_roba_grupa_oznaka"), i)
                If Not IsDBNull(DR.Item("dok_st_roba_jkl")) Then st_jkl.SetValue(DR.Item("dok_st_roba_jkl"), i)
                If Not IsDBNull(DR.Item("dok_st_roba_jm")) Then st_jm.SetValue(DR.Item("dok_st_roba_jm"), i)
                If Not IsDBNull(DR.Item("dok_st_kolicina")) Then st_kol.SetValue(CSng(DR.Item("dok_st_kolicina")), i)
                If Not IsDBNull(DR.Item("dok_st_nab_cena")) Then st_ncena.SetValue(CSng(DR.Item("dok_st_nab_cena")), i)
                If Not IsDBNull(DR.Item("dok_st_rabat")) Then st_rabat.SetValue(CSng(DR.Item("dok_st_rabat")), i)
                If Not IsDBNull(DR.Item("dok_st_zav_troskovi")) Then st_ztros.SetValue(CSng(DR.Item("dok_st_zav_troskovi")), i)
                If Not IsDBNull(DR.Item("dok_st_cena_kostanja")) Then st_ckostanja.SetValue(CSng(DR.Item("dok_st_cena_kostanja")), i)
                If Not IsDBNull(DR.Item("dok_st_nab_vred")) Then st_nvred.SetValue(CSng(DR.Item("dok_st_nab_vred")), i)
                If Not IsDBNull(DR.Item("dok_st_marza")) Then st_marza.SetValue(CSng(DR.Item("dok_st_marza")), i)
                If Not IsDBNull(DR.Item("dok_st_pdv")) Then st_pdv.SetValue(DR.Item("dok_st_pdv"), i)
                If Not IsDBNull(DR.Item("dok_st_prod_cena")) Then st_prcena.SetValue(CSng(DR.Item("dok_st_prod_cena")), i)
                If Not IsDBNull(DR.Item("dok_st_pdv_iznos")) Then st_pdv_iznos.SetValue(CSng(DR.Item("dok_st_pdv_iznos")), i)
                If Not IsDBNull(DR.Item("dok_st_prod_vred")) Then st_prvred.SetValue(CSng(DR.Item("dok_st_prod_vred")), i)
                i += 1
            Loop
            DR.Close()
            CM.Dispose()

            Dim j As Integer = 0
            For j = 0 To i - 1
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_ulazni_dokument_stavka_add"
                    .Parameters.AddWithValue("@id_dokument", _id_storno)
                    .Parameters.AddWithValue("@dok_st_rb", st_rb(j))
                    .Parameters.AddWithValue("@dok_st_roba_sifra", st_roba_sifra(j))
                    .Parameters.AddWithValue("@dok_st_roba_naziv", st_roba_naziv(j))
                    .Parameters.AddWithValue("@dok_st_roba_grupa_sifra", st_roba_grupa_sifra(j))
                    .Parameters.AddWithValue("@dok_st_roba_grupa_oznaka", st_roba_grupa_oznaka(j))
                    .Parameters.AddWithValue("@dok_st_roba_jkl", st_jkl(j))
                    .Parameters.AddWithValue("@dok_st_roba_jm", st_jm(j))
                    .Parameters.AddWithValue("@dok_st_kolicina", (-1) * st_kol(j))
                    .Parameters.AddWithValue("@dok_st_nab_cena", st_ncena(j))
                    .Parameters.AddWithValue("@dok_st_rabat", st_rabat(j))
                    .Parameters.AddWithValue("@dok_st_zav_troskovi", st_ztros(j))
                    .Parameters.AddWithValue("@dok_st_cena_kostanja", st_ckostanja(j))
                    .Parameters.AddWithValue("@dok_st_nab_vred", st_nvred(j))
                    .Parameters.AddWithValue("@dok_st_marza", st_marza(j))
                    .Parameters.AddWithValue("@dok_st_pdv", st_pdv(j))
                    .Parameters.AddWithValue("@dok_st_prod_cena", st_prcena(j))
                    .Parameters.AddWithValue("@dok_st_pdv_iznos", st_pdv_iznos(j))
                    .Parameters.AddWithValue("@dok_st_prod_vred", st_prvred(j))
                    .ExecuteScalar()

                    selektuj_artikl(st_roba_sifra(j), Selekcija.po_sifri)
                    unesi_dnevni_promet_stavka(_id_dnevni_promet, _dok_id_magacina, _id_artikl, _
                                        st_nvred(j), 0, st_ncena(j), st_pdv(j), True, False)

                End With
                CM.Dispose()
            Next

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_ulazni_dokument_storno_add"
                .Parameters.AddWithValue("@id_storno", _id_storno)
                .Parameters.AddWithValue("@id_dokument", _id_dokument)
                .Parameters.AddWithValue("@dok_storno_broj", Nadji_rb_dokument("rm_ulazni_dokument_head", 3, 22, False))
                .Parameters.AddWithValue("@dok_vrsta", _dok_sifra_dokumenta)
                .Parameters.AddWithValue("@dok_broj", _dok_broj)
                .ExecuteScalar()
            End With
            CM.Dispose()

            If _dok_zakljucen Then
                prebaci_u_magacin_promene(_dok_id_magacina, 22, _dok_storno_broj)
                prebaci_u_magacin_promene_stavka(_id_dnevni_promet)
            End If

        End If
        CN.Close()
    End Sub

    ' *******************

    Public Sub selektuj_povracaj_robe(ByVal _upit As String, ByVal _selekcija As Integer)
        On Error Resume Next
        Dim _sql As String = "select * from dbo.rm_povracaj_robe_head where dbo.rm_povracaj_robe_head."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_povracaj = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "pov_robe_opis = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "pov_robe_broj = " & _upit '& "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            _id_povracaj = 0
            _pov_robe_broj = 0
            _pov_robe_id_magacina = 0
            _pov_robe_id_dobavljac = 0
            _pov_robe_datum_fakture = Today
            _pov_robe_datum = Today
            _pov_robe_opis = ""
            _pov_robe_ukupno = 0
            _pov_robe_ztroskovi = 0
            _pov_robe_rabat = 0
            _pov_robe_razlika_uceni = 0
            _pov_robe_pdv_osnovica = 0
            _pov_robe_pdv = 0
            _pov_robe_svega = 0
            _pov_robe_zakljucena = False
            _pov_robe_id_vrsta_dokumenta = 0

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_povracaj")) Then _id_povracaj = DR.Item("id_povracaj")
                If Not IsDBNull(DR.Item("pov_robe_broj")) Then _pov_robe_broj = DR.Item("pov_robe_broj")
                If Not IsDBNull(DR.Item("id_magacina")) Then _pov_robe_id_magacina = DR.Item("id_magacina")
                If Not IsDBNull(DR.Item("id_dobavljac")) Then _pov_robe_id_dobavljac = DR.Item("id_dobavljac")
                If Not IsDBNull(DR.Item("pov_robe_datum_fakture")) Then _pov_robe_datum_fakture = DR.Item("pov_robe_datum_fakture")
                If Not IsDBNull(DR.Item("pov_robe_datum")) Then _pov_robe_datum = DR.Item("pov_robe_datum")
                If Not IsDBNull(DR.Item("pov_robe_opis")) Then _pov_robe_opis = DR.Item("pov_robe_opis")
                If Not IsDBNull(DR.Item("pov_robe_ukupno")) Then _pov_robe_ukupno = DR.Item("pov_robe_ukupno")
                If Not IsDBNull(DR.Item("pov_robe_ztroskovi")) Then _pov_robe_ztroskovi = DR.Item("pov_robe_ztroskovi")
                If Not IsDBNull(DR.Item("pov_robe_rabat")) Then _pov_robe_rabat = DR.Item("pov_robe_rabat")
                If Not IsDBNull(DR.Item("pov_robe_razlika_uceni")) Then _pov_robe_razlika_uceni = DR.Item("pov_robe_razlika_uceni")
                If Not IsDBNull(DR.Item("pov_robe_pdv_osnovica")) Then _pov_robe_pdv_osnovica = DR.Item("pov_robe_pdv_osnovica")
                If Not IsDBNull(DR.Item("pov_robe_pdv")) Then _pov_robe_pdv = DR.Item("pov_robe_pdv")
                If Not IsDBNull(DR.Item("pov_robe_svega")) Then _pov_robe_svega = DR.Item("pov_robe_svega")
                If Not IsDBNull(DR.Item("pov_robe_zakljucena")) Then _pov_robe_zakljucena = DR.Item("pov_robe_zakljucena")
                If Not IsDBNull(DR.Item("id_vrsta_dokumenta")) Then _pov_robe_id_vrsta_dokumenta = DR.Item("id_vrsta_dokumenta")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub povracaj_robe_print()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim CM1 As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()

        If CN.State = ConnectionState.Open Then

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prn_povracaj_robe_delete"
                .ExecuteScalar()
            End With
            CM.Dispose()

            CM1 = New SqlCommand()
            With CM1
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.rm_povracaj_robe_stavka where dbo.rm_povracaj_robe_stavka.id_povracaj = " & _id_povracaj
                DR = .ExecuteReader
            End With

            Dim i As Integer = 0
            Dim stavka_rb() As String = New String(50) {}
            Dim stavka_id() As Integer = New Integer(50) {}
            Dim stavka_roba() As String = New String(50) {}
            Dim stavka_jkl() As String = New String(50) {}
            Dim stavka_grupa() As String = New String(50) {}
            Dim stavka_kol() As Single = New Single(50) {}
            Dim stavka_ncena() As Single = New Single(50) {}
            Dim stavka_rabat() As Single = New Single(50) {}
            Dim stavka_ztros() As Single = New Single(50) {}
            Dim stavka_ckostanja() As Single = New Single(50) {}
            Dim stavka_nvred() As Single = New Single(50) {}
            Dim stavka_marza() As Single = New Single(50) {}
            Dim stavka_pdv() As Single = New Single(50) {}
            Dim stavka_prcena() As Single = New Single(50) {}
            Dim stavka_pdv_iznos() As Single = New Single(50) {}
            Dim stavka_prvred() As Single = New Single(50) {}

            'ReDim stavka_prvred(5)

            Do While DR.Read
                If Not IsDBNull(DR.Item("pov_robe_st_rb")) Then stavka_rb.SetValue(DR.Item("pov_robe_st_rb"), i)
                If Not IsDBNull(DR.Item("id_artikl")) Then stavka_id.SetValue(DR.Item("id_artikl"), i)
                'If Not IsDBNull(DR.Item("roba_sifra")) Then stavka_roba.SetValue(DR.Item("roba_sifra"), i)
                'If Not IsDBNull(DR.Item("roba")) Then stavka_jkl.SetValue(DR.Item("roba"), i)
                'If Not IsDBNull(DR.Item("roba")) Then stavka_grupa.SetValue(DR.Item("roba"), i)
                If Not IsDBNull(DR.Item("pov_robe_st_kolicina")) Then stavka_kol.SetValue(CSng(DR.Item("pov_robe_st_kolicina")), i)
                If Not IsDBNull(DR.Item("pov_robe_st_nab_cena")) Then stavka_ncena.SetValue(CSng(DR.Item("pov_robe_st_nab_cena")), i)
                If Not IsDBNull(DR.Item("pov_robe_st_rabat")) Then stavka_rabat.SetValue(CSng(DR.Item("pov_robe_st_rabat")), i)
                If Not IsDBNull(DR.Item("pov_robe_st_zav_troskovi")) Then stavka_ztros.SetValue(CSng(DR.Item("pov_robe_st_zav_troskovi")), i)
                If Not IsDBNull(DR.Item("pov_robe_st_cena_kostanja")) Then stavka_ckostanja.SetValue(CSng(DR.Item("pov_robe_st_cena_kostanja")), i)
                If Not IsDBNull(DR.Item("pov_robe_st_nab_vred")) Then stavka_nvred.SetValue(CSng(DR.Item("pov_robe_st_nab_vred")), i)
                If Not IsDBNull(DR.Item("pov_robe_st_marza")) Then stavka_marza.SetValue(CSng(DR.Item("pov_robe_st_marza")), i)
                If Not IsDBNull(DR.Item("pov_robe_st_pdv")) Then stavka_pdv.SetValue(CSng(DR.Item("pov_robe_st_pdv")), i)
                If Not IsDBNull(DR.Item("pov_robe_st_prod_cena")) Then stavka_prcena.SetValue(CSng(DR.Item("pov_robe_st_prod_cena")), i)
                If Not IsDBNull(DR.Item("pov_robe_st_pdv_iznos")) Then stavka_pdv_iznos.SetValue(CSng(DR.Item("pov_robe_st_pdv_iznos")), i)
                If Not IsDBNull(DR.Item("pov_robe_st_prod_vred")) Then stavka_prvred.SetValue(CSng(DR.Item("pov_robe_st_prod_vred")), i)
                i += 1
            Loop
            DR.Close()
            CM1.Dispose()

            Dim j As Integer = 0
            For j = 0 To i - 1
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "prn_povracaj_robe_add"
                    .Parameters.AddWithValue("@id_pr", _id_povracaj)
                    .Parameters.AddWithValue("@broj", _pov_robe_broj)
                    .Parameters.AddWithValue("@id_magacina", _pov_robe_id_magacina)
                    .Parameters.AddWithValue("@id_partner", _pov_robe_id_dobavljac)
                    .Parameters.AddWithValue("@datum", _pov_robe_datum)
                    .Parameters.AddWithValue("@datum_fakt", _pov_robe_datum_fakture)
                    .Parameters.AddWithValue("@br_fakture", _pov_robe_opis)
                    .Parameters.AddWithValue("@ukupno", _pov_robe_ukupno)
                    .Parameters.AddWithValue("@z_troskovi", _pov_robe_ztroskovi)
                    .Parameters.AddWithValue("@rabat", _pov_robe_rabat)
                    .Parameters.AddWithValue("@razlika_uceni", _pov_robe_razlika_uceni)
                    .Parameters.AddWithValue("@pdv_osnovica", _pov_robe_pdv_osnovica)
                    .Parameters.AddWithValue("@pdv", _pov_robe_pdv)
                    .Parameters.AddWithValue("@svega", _pov_robe_svega)
                    .Parameters.AddWithValue("@stavka_rb", stavka_rb(j))
                    .Parameters.AddWithValue("@stavka_id_artikl", stavka_id(j))
                    .Parameters.AddWithValue("@stavka_kol", stavka_kol(j))
                    .Parameters.AddWithValue("@stavka_ncena", stavka_ncena(j))
                    .Parameters.AddWithValue("@stavka_rabat", stavka_rabat(j))
                    .Parameters.AddWithValue("@stavka_ztros", stavka_ztros(j))
                    .Parameters.AddWithValue("@stavka_ckostanja", stavka_ckostanja(j))
                    .Parameters.AddWithValue("@stavka_nvred", stavka_nvred(j))
                    .Parameters.AddWithValue("@stavka_marza", stavka_marza(j))
                    .Parameters.AddWithValue("@stavka_pdv", stavka_pdv(j))
                    .Parameters.AddWithValue("@stavka_prcena", stavka_prcena(j))
                    .Parameters.AddWithValue("@stavka_pdv_iznos", stavka_pdv_iznos(j))
                    .Parameters.AddWithValue("@stavka_prvred", stavka_prvred(j))
                    .ExecuteScalar()
                End With
                CM.Dispose()
            Next
        End If
        CN.Close()
    End Sub

    Public Sub selektuj_popis(ByVal _upit As String, ByVal _selekcija As Integer)
        On Error Resume Next
        Dim _sql As String = "select * from dbo.rm_popis_head where dbo.rm_popis_head."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_popis = " & CInt(_upit)
                'Case Selekcija.po_nazivu
                '    _sql += "pov_robe_opis = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "pop_broj = " & _upit '& "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            _id_popis = 0
            _pop_broj = 0
            _pop_datum = Today
            _pop_id_magacina = 0
            _pop_vrednost = 0
            _pop_zakljucen = False

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_popis")) Then _id_popis = DR.Item("id_popis")
                If Not IsDBNull(DR.Item("pop_broj")) Then _pop_broj = DR.Item("pop_broj")
                If Not IsDBNull(DR.Item("pop_datum")) Then _pop_datum = DR.Item("pop_datum")
                If Not IsDBNull(DR.Item("id_magacin")) Then _pop_id_magacina = DR.Item("id_magacin")
                If Not IsDBNull(DR.Item("pop_vrednost")) Then _pop_vrednost = DR.Item("pop_vrednost")
                If Not IsDBNull(DR.Item("pop_zakljucen")) Then _pop_zakljucen = DR.Item("pop_zakljucen")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub popis_print()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()

        If CN.State = ConnectionState.Open Then

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prn_popis_delete"
                .ExecuteScalar()
            End With
            CM.Dispose()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.rm_popis_stavka where dbo.rm_popis_stavka.id_popis = " & _id_popis
                DR = .ExecuteReader
            End With

            Dim i As Integer = 0
            Dim stavka_rb() As String = New String(50) {}
            Dim stavka_artikl_id() As Integer = New Integer(50) {}
            Dim stavka_grupa_id() As Integer = New Integer(50) {}
            Dim stavka_cena() As Single = New Single(50) {}
            Dim stavka_stanje_popis() As Single = New Single(50) {}
            Dim stavka_stanje_magacin() As Single = New Single(50) {}
            Dim stavka_vrednost_popis() As Single = New Single(50) {}

            Do While DR.Read
                If Not IsDBNull(DR.Item("pop_st_rb")) Then stavka_rb.SetValue(DR.Item("pop_st_rb"), i)
                If Not IsDBNull(DR.Item("id_artikl")) Then stavka_artikl_id.SetValue(DR.Item("id_artikl"), i)
                If Not IsDBNull(DR.Item("id_grupa")) Then stavka_grupa_id.SetValue(DR.Item("id_grupa"), i)
                If Not IsDBNull(DR.Item("cena")) Then stavka_cena.SetValue(CSng(DR.Item("cena")), i)
                If Not IsDBNull(DR.Item("stanje_popis")) Then stavka_stanje_popis.SetValue(CSng(DR.Item("stanje_popis")), i)
                If Not IsDBNull(DR.Item("stanje_magacin")) Then stavka_stanje_magacin.SetValue(CSng(DR.Item("stanje_magacin")), i)
                If Not IsDBNull(DR.Item("vrednost_popis")) Then stavka_vrednost_popis.SetValue(CSng(DR.Item("vrednost_popis")), i)
                i += 1
            Loop
            DR.Close()
            CM.Dispose()

            Dim j As Integer = 0
            For j = 0 To i - 1
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "prn_popis_add"
                    .Parameters.AddWithValue("@pop_broj", _pop_broj)
                    .Parameters.AddWithValue("@pop_datum", _pop_datum)
                    .Parameters.AddWithValue("@id_magacin", _pop_id_magacina)
                    .Parameters.AddWithValue("@pop_vrednost", _pop_vrednost)
                    .Parameters.AddWithValue("@pop_zakljucen", _pop_zakljucen)
                    .Parameters.AddWithValue("@pop_st_rb", stavka_rb(j))
                    .Parameters.AddWithValue("@id_artikl", stavka_artikl_id(j))
                    .Parameters.AddWithValue("@id_grupa", stavka_grupa_id(j))
                    .Parameters.AddWithValue("@cena", stavka_cena(j))
                    .Parameters.AddWithValue("@stanje_popis", stavka_stanje_popis(j))
                    .Parameters.AddWithValue("@stanje_magacin", stavka_stanje_magacin(j))
                    .Parameters.AddWithValue("@vrednost_popis", stavka_vrednost_popis(j))
                    .ExecuteScalar()
                End With
                CM.Dispose()
            Next
        End If
        CN.Close()
    End Sub

    Public Sub selektuj_lager(ByVal _magacin As Integer, ByVal _grupa As Integer, ByVal _selekcija As Integer)
        'On Error Resume Next
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim i As Integer = 0

        Dim _sql As String = "SELECT dbo.rm_artikli.id_artikl, dbo.rm_artikli.artikl_sifra, " & _
                                "dbo.rm_artikli.artikl_naziv, dbo.app_artikl_grupa.gr_artikla_sifra, " & _
                                "dbo.app_artikl_grupa.gr_artikla_naziv, dbo.rm_artikli.jkl, dbo.app_jm.jm_oznaka " & _
                            "FROM dbo.app_artikl_grupa INNER JOIN " & _
                                "dbo.rm_artikli ON dbo.app_artikl_grupa.id_grup_artikla = dbo.rm_artikli.id_grup_artikla " & _
                                "INNER JOIN dbo.app_jm ON dbo.rm_artikli.id_jm = dbo.app_jm.id_jm"

        If _grupa <> 0 Then _sql += " WHERE dbo.rm_artikli.id_grup_artikla = " & _grupa



        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            _id_artikl = 0
            _artikl_sifra = ""
            _artikl_naziv = ""
            _artikl_jkl = ""
            _gr_art_sifra = ""
            _gr_art_naziv = ""
            _jm_oznaka = ""

            Do While DR.Read
                _mag_art_stanje = 0
                _mag_suma_stanje = 0
                _ima_promena = False

                If Not IsDBNull(DR.Item("id_artikl")) Then _id_artikl = DR.Item("id_artikl")
                If Not IsDBNull(DR.Item("artikl_sifra")) Then _artikl_sifra = DR.Item("artikl_sifra")
                If Not IsDBNull(DR.Item("artikl_naziv")) Then _artikl_naziv = DR.Item("artikl_naziv")
                If Not IsDBNull(DR.Item("jkl")) Then _artikl_jkl = DR.Item("jkl")
                If Not IsDBNull(DR.Item("gr_artikla_sifra")) Then _gr_art_sifra = DR.Item("gr_artikla_sifra")
                If Not IsDBNull(DR.Item("gr_artikla_naziv")) Then _gr_art_naziv = DR.Item("gr_artikla_naziv")
                If Not IsDBNull(DR.Item("jm_oznaka")) Then _jm_oznaka = DR.Item("jm_oznaka")

                magacin(_magacin, _id_artikl)
                dnevni_promet(_magacin, _id_artikl)

                If _dp_art_cena = 0 Then _dp_art_cena = cena(_id_artikl)

                _mag_art_stanje += _dp_art_stanje
                _mag_suma_stanje += _dp_suma_stanje


                Select Case _selekcija
                    Case Lager.lager
                        If Not _mag_art_stanje = 0 Then upisiLager(_magacin)
                    Case Lager.popis
                        If _ima_promena Then upisi_Prazan_Popis(_magacin)
                    Case Lager.trebovanje
                        With _grid
                            .Rows.Add(1)
                            .Rows(i).Cells(0).Value = i + 1
                            .Rows(i).Cells(1).Value = _artikl_sifra
                            If RTrim(_artikl_jkl) <> "" Then
                                .Rows(i).Cells(2).Value = _artikl_jkl
                            Else
                                .Rows(i).Cells(2).Value = "*******"
                            End If
                            .Rows(i).Cells(3).Value = _artikl_naziv
                            .Rows(i).Cells(4).Value = _jm_oznaka
                            .Rows(i).Cells(5).Value = 0
                            .Rows(i).Cells(6).Value = _mag_art_stanje
                            .Rows(i).Cells(7).Value = _dp_art_cena
                            .Rows(i).Cells(8).Value = 0
                        End With
                        i += 1
                End Select
            Loop
        End If
    End Sub

    Private Sub upisiLager(ByVal _magacin)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prn_Lager_add"
                selektuj_magacin(_magacin, Selekcija.po_id)
                .Parameters.AddWithValue("magacin_sifra", _magacin_sifra)
                .Parameters.AddWithValue("magacin_naziv", _magacin_naziv)
                .Parameters.AddWithValue("mag_art_stanje", _mag_art_stanje)
                .Parameters.AddWithValue("mag_art_cena", _dp_art_cena)
                .Parameters.AddWithValue("mag_suma_stanje", _mag_suma_stanje)
                .Parameters.AddWithValue("artikl_sifra", _artikl_sifra)
                .Parameters.AddWithValue("artikl_naziv", _artikl_naziv)
                .Parameters.AddWithValue("jm_oznaka", _jm_oznaka)
                .Parameters.AddWithValue("gr_artikla_sifra", _gr_art_sifra)
                .Parameters.AddWithValue("gr_artikla_naziv", _gr_art_naziv)
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If
    End Sub

    Private Sub upisi_Prazan_Popis(ByVal _magacin)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prn_Lager_add"
                selektuj_magacin(_magacin, Selekcija.po_id)
                .Parameters.AddWithValue("magacin_sifra", _magacin_sifra)
                .Parameters.AddWithValue("magacin_naziv", _magacin_naziv)
                .Parameters.AddWithValue("mag_art_stanje", _mag_art_stanje)
                .Parameters.AddWithValue("mag_art_cena", _dp_art_cena)
                .Parameters.AddWithValue("mag_suma_stanje", _mag_suma_stanje)
                .Parameters.AddWithValue("artikl_sifra", _artikl_sifra)
                .Parameters.AddWithValue("artikl_naziv", _artikl_naziv)
                .Parameters.AddWithValue("jm_oznaka", _jm_oznaka)
                .Parameters.AddWithValue("gr_artikla_sifra", _gr_art_sifra)
                .Parameters.AddWithValue("gr_artikla_naziv", _gr_art_naziv)
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If
    End Sub

    Public Sub magacin(ByVal _magacin As Integer, ByVal _id_artikl As Integer)
        'On Error Resume Next
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Dim _sql As String = "SELECT dbo.rm_magacin.id_magacin, dbo.rm_magacin.magacin_sifra,  " & _
                "dbo.rm_magacin.magacin_naziv, dbo.rm_magacin_promene_stavka.id_artikl, " & _
                "dbo.rm_magacin_promene_stavka.mag_art_stanje, dbo.rm_magacin_promene_stavka.mag_suma_stanje " & _
            "FROM dbo.rm_magacin INNER JOIN " & _
                "dbo.rm_magacin_promene_stavka ON dbo.rm_magacin.id_magacin = dbo.rm_magacin_promene_stavka.id_magacin " & _
                "WHERE dbo.rm_magacin.id_magacin = " & _magacin & " AND dbo.rm_magacin_promene_stavka.id_artikl = " & _id_artikl
        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            _id_magacin = _magacin
            _magacin_naziv = ""
            _magacin_sifra = ""
            _mag_art_stanje = 0
            _mag_art_cena = 0
            _mag_suma_stanje = 0

            Do While DR.Read
                If Not IsDBNull(DR.Item("magacin_naziv")) Then _magacin_naziv = DR.Item("magacin_naziv")
                If Not IsDBNull(DR.Item("magacin_sifra")) Then _magacin_sifra = DR.Item("magacin_sifra")
                If Not IsDBNull(DR.Item("mag_art_stanje")) Then _mag_art_stanje = DR.Item("mag_art_stanje")
                If Not IsDBNull(DR.Item("mag_art_cena")) Then _mag_art_cena = DR.Item("mag_art_cena")
                If Not IsDBNull(DR.Item("mag_suma_stanje")) Then _mag_suma_stanje = DR.Item("mag_suma_stanje")
                _ima_promena = True
            Loop
            DR.Close()
            CM.Dispose()
        End If
        CN.Close()
    End Sub

    Public Sub dnevni_promet(ByVal _magacin As Integer, ByVal _id_artikl As Integer)
        'On Error Resume Next
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Dim upit_dp As String = "SELECT dbo.rm_dnevni_promet_stavka.id_magacin, dbo.rm_dnevni_promet_stavka.id_artikl," & _
                "dbo.rm_dnevni_promet_stavka.dp_art_cena, dbo.rm_dnevni_promet_stavka.dp_art_stanje, " & _
                "dbo.rm_dnevni_promet_stavka.dp_suma_stanje, dbo.rm_dnevni_promet_head.dp_zakljucen " & _
            "FROM dbo.rm_dnevni_promet_head RIGHT OUTER JOIN " & _
                "dbo.rm_dnevni_promet_stavka ON " & _
                "dbo.rm_dnevni_promet_head.id_dnevni_promet = dbo.rm_dnevni_promet_stavka.id_dnevni_promet " & _
            "WHERE dbo.rm_dnevni_promet_head.dp_zakljucen = 0 AND dbo.rm_dnevni_promet_stavka.id_magacin = " & _magacin & _
                " AND dbo.rm_dnevni_promet_stavka.id_artikl = " & _id_artikl

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = upit_dp
                DR = .ExecuteReader
            End With

            _dp_art_stanje = 0
            _dp_art_cena = 0
            _dp_suma_stanje = 0

            Do While DR.Read
                If Not IsDBNull(DR.Item("dp_art_stanje")) Then _dp_art_stanje = DR.Item("dp_art_stanje")
                If Not IsDBNull(DR.Item("dp_art_cena")) Then _dp_art_cena = DR.Item("dp_art_cena")
                If Not IsDBNull(DR.Item("dp_suma_stanje")) Then _dp_suma_stanje = DR.Item("dp_suma_stanje")
                _ima_promena = True
            Loop
            DR.Close()
            CM.Dispose()
        End If
        CN.Close()
    End Sub

    Private Function cena(ByVal _id_artikl) As Single
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Dim _sql As String = "SELECT dbo.rm_artikli_cene.id_artikl, dbo.rm_artikli_cene.cena_nab_zadnja " & _
                "FROM dbo.rm_artikli_cene WHERE dbo.rm_artikli_cene.id_artikl = " & _id_artikl

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With
            Do While DR.Read
                If Not IsDBNull(DR.Item("cena_nab_zadnja")) Then cena = DR.Item("cena_nab_zadnja")
            Loop
            DR.Close()
            CM.Dispose()
        End If
    End Function

    Public Sub selektuj_trebovanje(ByVal _upit As String, ByVal _selekcija As Integer)
        On Error Resume Next
        Dim _sql As String = "select * from dbo.rm_trebovanje_head where dbo.rm_trebovanje_head."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_trebovanje = " & CInt(_upit)
                'Case Selekcija.po_nazivu
                '    _sql += "pov_robe_opis = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "treb_broj = " & _upit '& "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            _id_trebovanje = 0
            _treb_broj = ""
            _treb_datum = Today
            _treb_id_magacin = 0
            _treb_vrednost = 0
            _treb_zakljuceno = False

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_trebovanje")) Then _id_trebovanje = DR.Item("id_trebovanje")
                If Not IsDBNull(DR.Item("treb_broj")) Then _treb_broj = DR.Item("treb_broj")
                If Not IsDBNull(DR.Item("treb_datum")) Then _treb_datum = DR.Item("treb_datum")
                If Not IsDBNull(DR.Item("id_magacin")) Then _treb_id_magacin = DR.Item("id_magacin")
                If Not IsDBNull(DR.Item("treb_vrednost")) Then _treb_vrednost = DR.Item("treb_vrednost")
                If Not IsDBNull(DR.Item("treb_zakljuceno")) Then _treb_zakljuceno = DR.Item("treb_zakljuceno")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub trebovanje_print()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()

        If CN.State = ConnectionState.Open Then

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prn_trebovanje_delete"
                .ExecuteScalar()
            End With
            CM.Dispose()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.rm_trebovanje_stavka where dbo.rm_trebovanje_stavka.id_trebovanje = " & _id_trebovanje
                DR = .ExecuteReader
            End With

            Dim i As Integer = 0
            Dim stavka_rb() As String = New String(50) {}
            Dim stavka_artikl_id() As Integer = New Integer(50) {}
            Dim stavka_grupa_id() As Integer = New Integer(50) {}
            Dim stavka_kolicina() As Single = New Single(50) {}
            Dim stavka_mag_stanje() As Single = New Single(50) {}
            Dim stavka_cena() As Single = New Single(50) {}
            Dim stavka_vrednost() As Single = New Single(50) {}

            Do While DR.Read
                If Not IsDBNull(DR.Item("treb_st_rb")) Then stavka_rb.SetValue(DR.Item("treb_st_rb"), i)
                If Not IsDBNull(DR.Item("id_artikl")) Then stavka_artikl_id.SetValue(DR.Item("id_artikl"), i)
                If Not IsDBNull(DR.Item("id_grupa")) Then stavka_grupa_id.SetValue(DR.Item("id_grupa"), i)
                Dim a As Single = DR.Item("treb_st_kolicina")
                If Not IsDBNull(DR.Item("treb_st_kolicina")) Then stavka_kolicina.SetValue(CSng(DR.Item("treb_st_kolicina")), i)
                If Not IsDBNull(DR.Item("treb_st_mag_stanje")) Then stavka_mag_stanje.SetValue(CSng(DR.Item("treb_st_mag_stanje")), i)
                If Not IsDBNull(DR.Item("treb_st_cena")) Then stavka_cena.SetValue(CSng(DR.Item("treb_st_cena")), i)
                If Not IsDBNull(DR.Item("treb_st_vrednost")) Then stavka_vrednost.SetValue(CSng(DR.Item("treb_st_vrednost")), i)
                i += 1
            Loop
            DR.Close()
            CM.Dispose()

            Dim j As Integer = 0
            For j = 0 To i - 1
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "prn_trebovanje_add"
                    .Parameters.AddWithValue("@treb_broj", _treb_broj)
                    .Parameters.AddWithValue("@treb_datum", _treb_datum)
                    .Parameters.AddWithValue("@id_magacin", _treb_id_magacin)
                    .Parameters.AddWithValue("@treb_vrednost", _treb_vrednost)
                    .Parameters.AddWithValue("@treb_zakljuceno", _treb_zakljuceno)
                    .Parameters.AddWithValue("@treb_st_rb", stavka_rb(j))
                    .Parameters.AddWithValue("@id_artikl", stavka_artikl_id(j))
                    .Parameters.AddWithValue("@id_grupa", stavka_grupa_id(j))
                    .Parameters.AddWithValue("@treb_st_kolicina", stavka_kolicina(j))
                    .Parameters.AddWithValue("@treb_st_mag_stanje", stavka_mag_stanje(j))
                    .Parameters.AddWithValue("@treb_st_cena", stavka_cena(j))
                    .Parameters.AddWithValue("@treb_st_vrednost", stavka_vrednost(j))
                    .ExecuteScalar()
                End With
                CM.Dispose()
            Next
        End If
        CN.Close()
    End Sub

    Public Sub selektuj_izvod(ByVal _bukmark)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.fn_izvodi_head.* from dbo.fn_izvodi_head where dbo.fn_izvodi_head.broj = " & _bukmark
                DR = .ExecuteReader
            End With

            _id_izvod = 0
            _izvod_datum = Today
            _izvod_broj = _bukmark
            _izvod_svega_duguje = 0
            _izvod_svega_potrazuje = 0
            _izvod_stanje = 0
            _izvod_proknjizen = False

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_izvod")) Then _id_izvod = DR.Item("id_izvod")
                'If Not IsDBNull(DR.Item("broj")) Then _izvod_broj = DR.Item("broj")
                If Not IsDBNull(DR.Item("datum")) Then _izvod_datum = DR.Item("datum")
                If Not IsDBNull(DR.Item("svega_duguje")) Then _izvod_svega_duguje = DR.Item("svega_duguje")
                If Not IsDBNull(DR.Item("svega_potrazuje")) Then _izvod_svega_potrazuje = DR.Item("svega_potrazuje")
                If Not IsDBNull(DR.Item("stanje")) Then _izvod_stanje = DR.Item("stanje")
                If Not IsDBNull(DR.Item("proknjizen")) Then _izvod_proknjizen = DR.Item("proknjizen")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub os_print(ByVal _sql As String, ByVal _dok As String)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()

        If CN.State = ConnectionState.Open Then

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prnOS_delete"
                .ExecuteScalar()
            End With
            CM.Dispose()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            Dim i As Integer = 0
            Dim broj() As Integer = New Integer(20) {}
            Dim partner() As String = New String(20) {}
            Dim datum_fakt() As Date = New Date(20) {}
            Dim datum_valuta() As Date = New Date(20) {}
            Dim iznos_duguje() As Single = New Single(20) {}
            Dim iznos_potrazuje() As Single = New Single(20) {}
            Dim saldo() As Single = New Single(20) {}
            Dim saldo_os As Single = 0
            'ReDim stavka_prvred(5)

            Do While DR.Read
                If Not IsDBNull(DR.Item("sifra")) Then broj.SetValue(CInt(DR.Item("sifra")), i)
                If Not IsDBNull(DR.Item("id_partner")) Then partner.SetValue(Partner_naziv(DR.Item("id_partner")), i)
                If Not IsDBNull(DR.Item("datum_fakturisanja")) Then datum_fakt.SetValue(DR.Item("datum_fakturisanja"), i)
                If Not IsDBNull(DR.Item("datum_valuta")) Then datum_valuta.SetValue(DR.Item("datum_valuta"), i)

                Select Case _dok
                    Case Imena.strana_knjizenja.duguje
                        iznos_duguje.SetValue(CSng(DR.Item("iznos_zanaplatu")), i)
                        iznos_potrazuje.SetValue(0, i)
                        saldo_os += Format(DR.Item("iznos_zanaplatu"), 2)
                        saldo.SetValue(saldo_os, i)
                    Case Imena.strana_knjizenja.potrazuje
                        iznos_duguje.SetValue(0, i)
                        iznos_potrazuje.SetValue(CSng(DR.Item("iznos_zanaplatu")), i)
                        saldo_os -= Format(DR.Item("iznos_zanaplatu"), 2)
                        saldo.SetValue(saldo_os, i)
                End Select
                'saldo.SetValue(saldo_os, i)
                i += 1
            Loop
            DR.Close()
            CM.Dispose()

            Dim j As Integer = 0
            For j = 0 To i - 1
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "prnOS_add"
                    .Parameters.AddWithValue("@broj", broj(j))
                    .Parameters.AddWithValue("@partner", partner(j))
                    .Parameters.AddWithValue("@datum_fakt", datum_fakt(j))
                    .Parameters.AddWithValue("@datum_valuta", datum_valuta(j))
                    .Parameters.AddWithValue("@iznos_duguje", iznos_duguje(j))
                    .Parameters.AddWithValue("@iznos_potrazuje", iznos_potrazuje(j))
                    .Parameters.AddWithValue("@saldo", saldo(j))
                    .ExecuteScalar()
                End With
                CM.Dispose()
            Next
        End If
        CN.Close()

        '_raport = Imena.tabele.fn_otvorene_stavke.ToString
        'Dim mForm As New frmPrint
        'mForm.Show()
    End Sub

    Public Sub selektuj_putni_nalog(ByVal _bukmark)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.fn_putni_nalog.* from dbo.putni_nalog where dbo.fn_putni_nalog.broj = " & _bukmark
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            _id_pnalog = 0
            _pnalog_broj = _bukmark
            _pnalog_organizacija = ""
            _pnalog_radnik = ""
            _pnalog_radno_mesto = ""
            _pnalog_dana = Today
            _pnalog_mesto = ""
            _pnalog_zadatak = ""
            _pnalog_prevoz = ""
            _pnalog_dnevnica = 0
            _pnalog_zadrzavanje = Today
            _pnalog_nateret = ""
            _pnalog_akontacija = 0

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_pnalog")) Then _id_pnalog = DR.Item("id_pnalog")
                'If Not IsDBNull(DR.Item("broj")) Then _nivelacije_datum = DR.Item("broj")
                If Not IsDBNull(DR.Item("naziv_organizacije")) Then _pnalog_organizacija = DR.Item("naziv_organizacije")
                If Not IsDBNull(DR.Item("radnik")) Then _pnalog_radnik = DR.Item("radnik")
                If Not IsDBNull(DR.Item("radno_mesto")) Then _pnalog_radno_mesto = DR.Item("radno_mesto")
                If Not IsDBNull(DR.Item("dana")) Then _pnalog_dana = DR.Item("dana")
                If Not IsDBNull(DR.Item("mesto")) Then _pnalog_mesto = DR.Item("mesto")
                If Not IsDBNull(DR.Item("zadatak")) Then _pnalog_zadatak = DR.Item("zadatak")
                If Not IsDBNull(DR.Item("prevoz")) Then _pnalog_prevoz = DR.Item("prevoz")
                If Not IsDBNull(DR.Item("dnevnica")) Then _pnalog_dnevnica = DR.Item("dnevnica")
                If Not IsDBNull(DR.Item("zadrzavanje")) Then _pnalog_zadrzavanje = DR.Item("zadrzavanje")
                If Not IsDBNull(DR.Item("nateret")) Then _pnalog_nateret = DR.Item("nateret")
                If Not IsDBNull(DR.Item("akontacija")) Then _pnalog_akontacija = DR.Item("akontacija")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub selektuj_putni_racun(ByVal _bukmark)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.fn_putni_racun.* from dbo.putni_racun where dbo.fn_putni_racun.id_putni_nalog = " & _bukmark
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            _id_putni_racun = 0
            _id_pnalog = _bukmark
            _pnalog_odlazak = ""
            _pnalog_odlazak_sat = 0
            _pnalog_povratak = ""
            _pnalog_povratak_sat = 0
            _pnalog_broj_sati = 0
            _pnalog_broj_dnevnica = 0
            _pnalog_dinara = 0
            _pnalog_svega_dnevnica = 0
            _pnalog_svega = 0
            _pnalog_za_isplatu = 0
            _pnalog_broj_priloga = 0
            _pnalog_u = ""
            _pnalog_racun_dana = Today

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_putni_racun")) Then _id_putni_racun = DR.Item("id_putni_racun")
                If Not IsDBNull(DR.Item("odlazak")) Then _pnalog_odlazak = DR.Item("odlazak")
                If Not IsDBNull(DR.Item("odlazak_sat")) Then _pnalog_odlazak_sat = DR.Item("odlazak_sat")
                If Not IsDBNull(DR.Item("povratak")) Then _pnalog_povratak = DR.Item("povratak")
                If Not IsDBNull(DR.Item("povratak_sat")) Then _pnalog_povratak_sat = DR.Item("povratak_sat")
                If Not IsDBNull(DR.Item("broj_sati")) Then _pnalog_broj_sati = DR.Item("broj_sati")
                If Not IsDBNull(DR.Item("broj_dnevnica")) Then _pnalog_broj_dnevnica = DR.Item("broj_dnevnica")
                If Not IsDBNull(DR.Item("dinara")) Then _pnalog_dinara = DR.Item("dinara")
                If Not IsDBNull(DR.Item("svega_dnevnica")) Then _pnalog_svega_dnevnica = DR.Item("svega_dnevnica")
                If Not IsDBNull(DR.Item("svega")) Then _pnalog_svega = DR.Item("svega")
                If Not IsDBNull(DR.Item("za_isplatu")) Then _pnalog_za_isplatu = DR.Item("za_isplatu")
                If Not IsDBNull(DR.Item("broj_priloga")) Then _pnalog_broj_priloga = DR.Item("broj_priloga")
                If Not IsDBNull(DR.Item("u")) Then _pnalog_u = DR.Item("u")
                If Not IsDBNull(DR.Item("dana")) Then _pnalog_racun_dana = DR.Item("dana")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub selektuj_pdv(ByVal _upit As String, ByVal _selekcija As Integer)
        On Error Resume Next
        Dim _sql As String = "select * from dbo.app_pdv where dbo.app_pdv."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_pdv = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "pdv_stopa = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "pdv_sifra = N'" & _upit & "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            _id_pdv = 0
            _pdv_sifra = ""
            _pdv_stopa = ""
            _pdv_opis = ""
            _pdv_datum = ""
            _pdv_aktivan = ""

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_pdv")) Then _id_pdv = DR.Item("id_pdv")
                If Not IsDBNull(DR.Item("sifra")) Then _pdv_sifra = DR.Item("sifra")
                If Not IsDBNull(DR.Item("pdv_opis")) Then _pdv_opis = DR.Item("pdv_opis")
                If Not IsDBNull(DR.Item("pdv_stopa")) Then _pdv_stopa = DR.Item("pdv_stopa")
                If Not IsDBNull(DR.Item("pdv_dat_stupanja")) Then _pdv_datum = DR.Item("pdv_dat_stupanja")
                If Not IsDBNull(DR.Item("pdv_aktivan")) Then _pdv_aktivan = DR.Item("pdv_aktivan")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub selektuj_kategoriju(ByVal tSifra)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_kategorizacija.* " & _
                               "from dbo.rm_kategorizacija " & _
                               "where dbo.rm_kategorizacija.sifra = " & tSifra
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            _id_kategorija = 0
            _kategorija_naziv = ""
            _kategorija_sifra = tSifra

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_kategorija")) Then _id_kategorija = DR.Item("id_kategorija")
                'If Not IsDBNull(DR.Item("sifra")) Then _kategorija_sifra = DR.Item("sifra")
                If Not IsDBNull(DR.Item("naziv")) Then _kategorija_naziv = DR.Item("naziv")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub selektuj_odlozeno(ByVal tSifra)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_odlozeno.* " & _
                               "from dbo.app_odlozeno " & _
                               "where dbo.app_odlozeno.sifra = " & tSifra
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            _id_odlozeno = 0
            _odlozeno_odlozeno = ""
            _odlozeno_opis = ""
            _odlozeno_sifra = tSifra

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_odlozeno")) Then _id_odlozeno = DR.Item("id_odlozeno")
                'If Not IsDBNull(DR.Item("sifra")) Then _odlozeno_sifra = DR.Item("sifra")
                If Not IsDBNull(DR.Item("opis")) Then _odlozeno_opis = DR.Item("opis")
                If Not IsDBNull(DR.Item("odlozeno")) Then _odlozeno_odlozeno = DR.Item("odlozeno")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub selektuj_grad(ByVal _upit As String, ByVal _selekcija As Integer)
        Dim _sql As String = "select * from dbo.app_gradovi where dbo.app_gradovi."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_grad = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "grad_naziv = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "grad_ptt_br = N'" & _upit & "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With
            'Dim 'conn As New SqlConnection()
            'conn.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Northwind.mdf;Integrated Security=True;User Instance=True"
            _id_grad = 0
            _grad_naziv = ""
            _grad_ptt = ""
            _grad_pj = ""
            _grad_aktivan = False

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_grad")) Then _id_grad = DR.Item("id_grad")
                If Not IsDBNull(DR.Item("grad_naziv")) Then _grad_naziv = DR.Item("grad_naziv")
                If Not IsDBNull(DR.Item("grad_ptt_br")) Then _grad_ptt = RTrim(DR.Item("grad_ptt_br"))
                If Not IsDBNull(DR.Item("grad_porjed")) Then _grad_pj = RTrim(DR.Item("grad_porjed"))
                If Not IsDBNull(DR.Item("grad_aktivan")) Then _grad_aktivan = DR.Item("grad_aktivan")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub selektuj_opstine(ByVal _upit As String, ByVal _selekcija As Integer)
        Dim _sql As String = "select * from dbo.app_opstine where dbo.app_opstine."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_opstine = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "opstine_naziv = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "opstine_ptt_br = N'" & _upit & "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            _id_grad = 0
            _id_opstina = 0
            _opstina_naziv = ""
            _opstina_ptt = ""
            _opstina_pj = ""
            _opstina_aktivan = False

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_opstine")) Then _id_opstina = DR.Item("id_opstine")
                If Not IsDBNull(DR.Item("id_grad")) Then _id_grad = DR.Item("id_grad")
                If Not IsDBNull(DR.Item("opstine_naziv")) Then _opstina_naziv = DR.Item("opstine_naziv")
                If Not IsDBNull(DR.Item("opstine_ptt_br")) Then _opstina_ptt = DR.Item("opstine_ptt_br")
                If Not IsDBNull(DR.Item("opstine_porjed")) Then _opstina_pj = DR.Item("opstine_porjed")
                If Not IsDBNull(DR.Item("opstine_aktivan")) Then _opstina_aktivan = DR.Item("opstine_aktivan")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub selektuj_mesto(ByVal _upit As String, ByVal _selekcija As Integer)
        On Error Resume Next
        Dim _sql As String = "select * from dbo.app_mesta where dbo.app_mesta."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_mesta = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "mesto_naziv = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "mesto_ptt_br = N'" & _upit & "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            _id_opstina = 0
            _id_mesto = 0
            _mesto_naziv = ""
            _mesto_ptt = ""
            _mesto_pj = ""
            _mesto_aktivan = False

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_mesta")) Then _id_mesto = DR.Item("id_mesta")
                If Not IsDBNull(DR.Item("id_opstine")) Then _id_opstina = DR.Item("id_opstine")
                If Not IsDBNull(DR.Item("mesto_naziv")) Then _mesto_naziv = DR.Item("mesto_naziv")
                If Not IsDBNull(DR.Item("mesto_ptt_br")) Then _mesto_ptt = DR.Item("mesto_ptt_br")
                If Not IsDBNull(DR.Item("mesto_porjed")) Then _mesto_pj = DR.Item("mesto_porjed")
                If Not IsDBNull(DR.Item("mesto_aktivan")) Then _mesto_aktivan = DR.Item("mesto_aktivan")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub naselja_print(ByVal _upit As String)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Dim ime As String = ""
        Dim id As Integer = 0
        Dim id1 As Integer = 0
        Dim naziv As String = ""
        Dim ptt As String = ""
        Dim pj As String = ""
        Dim akt As Boolean = True

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prn_naselja_delete"
                .ExecuteScalar()
            End With
            CM.Dispose()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _upit
                DR = .ExecuteReader
            End With

            Do While DR.Read
                Select Case _naselja
                    Case Imena.naselja.grad
                        ime = "grad"
                        id = 0
                        id1 = 0
                    Case Imena.naselja.opstina
                        ime = "opstine_"
                        id = DR.Item("id_grad")
                        id1 = 0
                    Case Imena.naselja.mesto
                        ime = "mesto_"
                        id = 0
                        id1 = DR.Item("id_opstine")
                End Select
                unesi(id, id1, DR.Item(ime + "_naziv"), DR.Item(ime + "_ptt_br"), DR.Item(ime + "_porjed"), DR.Item(ime + "_aktivan"))
            Loop
            DR.Close()
            CM.Dispose()
        End If
        CN.Close()

    End Sub

    Private Sub unesi(ByVal id, ByVal id1, ByVal naziv, ByVal ptt, ByVal pj, ByVal akt)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prn_naselja_add"
                .Parameters.AddWithValue("@id_grad", id)
                .Parameters.AddWithValue("@id_opstine", id1)
                .Parameters.AddWithValue("@naziv", naziv)
                .Parameters.AddWithValue("@ptt_br", ptt)
                .Parameters.AddWithValue("@porjed", pj)
                .Parameters.AddWithValue("@aktivan", akt)
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If

    End Sub
    Public Sub selektuj_GrupeArt(ByVal _upit As String, ByVal _selekcija As Integer)
        On Error Resume Next
        Dim _sql As String = "select * from dbo.app_artikl_grupa where dbo.app_artikl_grupa."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_grup_artikla = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "gr_artikla_naziv = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "gr_artikla_sifra = N'" & _upit & "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            _id_gr_art = 0
            _gr_art_sifra = ""
            _gr_art_naziv = ""
            _gr_art_skraceno = ""
            _gr_art_nadredj_gr = ""
            _gr_art_poslednji_nivo = False
            _gr_art_marza = 0
            _gr_art_pdv = 0
            _gr_art_aktivno = False
            _gr_art_lek = False
            _gr_art_L1 = False
            _gr_art_izdajesena = ""
            _id_vrsta_dok = 0

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_grup_artikla")) Then _id_gr_art = DR.Item("id_grup_artikla")
                If Not IsDBNull(DR.Item("gr_artikla_sifra")) Then _gr_art_sifra = RTrim(DR.Item("gr_artikla_sifra"))
                If Not IsDBNull(DR.Item("gr_artikla_naziv")) Then _gr_art_naziv = DR.Item("gr_artikla_naziv")
                If Not IsDBNull(DR.Item("gr_artikla_skraceno")) Then _gr_art_skraceno = RTrim(DR.Item("gr_artikla_skraceno"))
                If Not IsDBNull(DR.Item("gr_artikla_nadredj_gr")) Then _gr_art_nadredj_gr = RTrim(DR.Item("gr_artikla_nadredj_gr"))
                If Not IsDBNull(DR.Item("gr_artikla_poslednji_nivo")) Then _gr_art_poslednji_nivo = DR.Item("gr_artikla_poslednji_nivo")
                If Not IsDBNull(DR.Item("gr_artikla_marza")) Then _gr_art_marza = DR.Item("gr_artikla_marza")
                If Not IsDBNull(DR.Item("gr_artikla_pdv")) Then _gr_art_pdv = DR.Item("gr_artikla_pdv")
                If Not IsDBNull(DR.Item("gr_artikla_aktivno")) Then _gr_art_aktivno = DR.Item("gr_artikla_aktivno")
                If Not IsDBNull(DR.Item("gr_artikla_lek	")) Then _gr_art_lek = DR.Item("gr_artikla_lek")
                If Not IsDBNull(DR.Item("gr_artikla_L1")) Then _gr_art_L1 = DR.Item("gr_artikla_L1")
                If Not IsDBNull(DR.Item("gr_artikla_izdajesena")) Then _gr_art_izdajesena = DR.Item("gr_artikla_izdajesena")
                If Not IsDBNull(DR.Item("id_vrsta_dokumenta")) Then _id_vrsta_dok = DR.Item("id_vrsta_dokumenta")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub selektuj_jkl(ByVal _upit As String, ByVal _selekcija As Integer)
        On Error Resume Next
        Dim _sql As String = "select * from dbo.app_jkl where dbo.app_jkl."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_jkl = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "jkl_naziv = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "jkl_sifra = N'" & _upit & "'"
        End Select


        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            _id_jkl = 0
            _jkl_sifra = ""
            _jkl_naziv = ""
            _jkl_pozitivna_lista = False

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_jkl")) Then _id_jkl = DR.Item("id_jkl")
                If Not IsDBNull(DR.Item("jkl_sifra")) Then _jkl_sifra = DR.Item("jkl_sifra")
                If Not IsDBNull(DR.Item("jkl_naziv")) Then _jkl_naziv = DR.Item("jkl_naziv")
                If Not IsDBNull(DR.Item("jkl_pozitivna_lista")) Then _jkl_pozitivna_lista = DR.Item("jkl_pozitivna_lista")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub selektuj_poz_listu(ByVal _upit As String, ByVal _selekcija As Integer)
        On Error Resume Next
        Dim _sql As String = "select * from dbo.app_pozitivna_lista where dbo.app_pozitivna_lista."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_poz_lista = " & CInt(_upit)
            Case Selekcija.po_nazivu
                '_sql += "jkl_naziv = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "jkl_sifra = N'" & _upit & "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            _id_poz_lista = 0
            _poz_lista_dat_promene = Today
            _poz_lista_jkl_sifra_l1 = ""
            _poz_lista_L1 = False
            _poz_lista_l1_dat_OD = "01/01/" & Now.Year.ToString
            _poz_lista_l1_dat_DO = "12/31/" & Now.Year.ToString

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_poz_lista")) Then _id_poz_lista = DR.Item("id_poz_lista")
                If Not IsDBNull(DR.Item("datum_promene")) Then _poz_lista_dat_promene = DR.Item("datum_promene")
                If Not IsDBNull(DR.Item("jkl_sifra")) Then _poz_lista_jkl_sifra_l1 = DR.Item("jkl_sifra")
                If Not IsDBNull(DR.Item("L1")) Then _poz_lista_L1 = DR.Item("L1")
                If Not IsDBNull(DR.Item("l1_datum_OD")) Then _poz_lista_l1_dat_OD = DR.Item("l1_datum_OD")
                If Not IsDBNull(DR.Item("l1_datum_DO")) Then _poz_lista_l1_dat_DO = DR.Item("l1_datum_DO")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub selektuj_genericko(ByVal _upit As String, ByVal _selekcija As Integer)
        On Error Resume Next
        Dim _sql As String = "select * from dbo.app_genericko_ime where dbo.app_genericko_ime."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_genericko = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "genericko_ime = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "genericko_sifra = N'" & _upit & "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            _id_genericko = 0
            _genericko_sifra = ""
            _genericko_naziv = ""
            _genericko_ime_aktivan = False

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_genericko")) Then _id_genericko = DR.Item("id_genericko")
                If Not IsDBNull(DR.Item("genericko_sifra")) Then _genericko_sifra = RTrim(DR.Item("genericko_sifra"))
                If Not IsDBNull(DR.Item("genericko_ime")) Then _genericko_naziv = RTrim(DR.Item("genericko_ime"))
                If Not IsDBNull(DR.Item("genericko_ime_aktivan")) Then _genericko_ime_aktivan = DR.Item("genericko_ime_aktivan")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()

    End Sub

    Public Sub selektuj_fo(ByVal _upit As String, ByVal _selekcija As Integer)
        On Error Resume Next
        Dim _sql As String = "select * from dbo.app_fo where dbo.app_fo."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_fo = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "fo_naziv = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "fo_sifra = N'" & _upit & "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            _id_fo = 0
            _fo_sifra = ""
            _fo_naziv = ""
            _fo_skraceno = ""

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_fo")) Then _id_fo = DR.Item("id_fo")
                If Not IsDBNull(DR.Item("fo_sifra")) Then _fo_sifra = RTrim(DR.Item("fo_sifra"))
                If Not IsDBNull(DR.Item("fo_naziv")) Then _fo_naziv = RTrim(DR.Item("fo_naziv"))
                If Not IsDBNull(DR.Item("fo_skraceno")) Then _fo_skraceno = DR.Item("fo_skraceno")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()

    End Sub

    Public Sub selektuj_VrsteDokumenta(ByVal _upit As String, ByVal _selekcija As Integer)
        On Error Resume Next
        Dim _sql As String = "select * from dbo.app_vrste_dokumenata where dbo.app_vrste_dokumenata."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_vrsta_dok = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "vrsta_dok_naziv = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "vrsta_dok_sifra = N'" & _upit & "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            _id_vrsta_dok = 0
            _vrsta_dok_sifra = 0
            _vrsta_dok_opis = ""
            _vrsta_dok_naziv = ""
            _vrsta_dok_konto = ""
            _vrsta_dok_str_knjizenja = ""

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_vrsta_dok")) Then _id_vrsta_dok = DR.Item("id_vrsta_dok")
                If Not IsDBNull(DR.Item("vrsta_dok_sifra")) Then _vrsta_dok_sifra = RTrim(DR.Item("vrsta_dok_sifra"))
                If Not IsDBNull(DR.Item("vrsta_dok_opis")) Then _vrsta_dok_opis = DR.Item("vrsta_dok_opis")
                If Not IsDBNull(DR.Item("vrsta_dok_naziv")) Then _vrsta_dok_naziv = RTrim(DR.Item("vrsta_dok_naziv"))
                If Not IsDBNull(DR.Item("vrsta_dok_konto")) Then _vrsta_dok_konto = RTrim(DR.Item("vrsta_dok_konto"))
                If Not IsDBNull(DR.Item("vrsta_dok_strana_knjizenja")) Then _vrsta_dok_str_knjizenja = DR.Item("vrsta_dok_strana_knjizenja")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub selektuj_VrsteArtikla(ByVal _upit As String, ByVal _selekcija As Integer)
        On Error Resume Next
        Dim _sql As String = "select * from dbo.app_artikl_vrsta where dbo.app_artikl_vrsta."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_vrsta = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "vrsta_naziv = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "vrsta_sifra = N'" & _upit & "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            _id_vrsta = 0
            _vrsta_sifra = ""
            _vrsta_naziv = ""
            _vrsta_prefix = ""
            _vrsta_izdajesena = ""

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_vrsta")) Then _id_vrsta = DR.Item("id_vrsta")
                If Not IsDBNull(DR.Item("vrsta_sifra")) Then _vrsta_sifra = RTrim(DR.Item("vrsta_sifra"))
                If Not IsDBNull(DR.Item("vrsta_naziv")) Then _vrsta_naziv = RTrim(DR.Item("vrsta_naziv"))
                If Not IsDBNull(DR.Item("vrsta_prefix")) Then _vrsta_prefix = DR.Item("vrsta_prefix")
                If Not IsDBNull(DR.Item("vrsta_izdajesena")) Then _vrsta_izdajesena = DR.Item("vrsta_izdajesena")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()

    End Sub

    Public Sub selektuj_DPromet(ByVal _upit As String, ByVal _selekcija As Integer)
        On Error Resume Next
        Dim _sql As String = "select * from dbo.rm_dnevni_promet_head where dbo.rm_dnevni_promet_head."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_dnevni_promet = " & CInt(_upit)
            Case Selekcija.po_nazivu
                '_sql += "vrsta_naziv = N'" & _upit & "'"
            Case Selekcija.po_sifri
                '_sql += "vrsta_sifra = N'" & _upit & "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            _id_dnevni_promet = 0
            _dp_datum_promene = Today
            _dp_datum_vreme_promene = Today
            _dp_id_magacin = 0
            _dp_rb = 0
            _dp_id_vrsta_dok = 0
            _dp_broj_dok = ""
            _dp_id_dokumenta = 0
            _dp_ukupno_ulaz = 0
            _dp_ukupno_izlaz = 0
            _dp_ukupno_stanje = 0
            _dp_novo_stanje = False
            _dp_zakljucen = False

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_dnevni_promet")) Then _id_dnevni_promet = DR.Item("id_dnevni_promet")
                If Not IsDBNull(DR.Item("dp_datum_promene")) Then _dp_datum_promene = DR.Item("dp_datum_promene")
                If Not IsDBNull(DR.Item("dp_datum_vreme_promene")) Then _dp_datum_vreme_promene = DR.Item("dp_datum_vreme_promene")
                If Not IsDBNull(DR.Item("id_magacin")) Then _id_magacin = DR.Item("id_magacin")
                If Not IsDBNull(DR.Item("dp_rb")) Then _dp_rb = DR.Item("dp_rb")
                If Not IsDBNull(DR.Item("id_vrsta_dok")) Then _id_vrsta_dok = DR.Item("id_vrsta_dok")
                If Not IsDBNull(DR.Item("id_dokumenta")) Then _dp_id_dokumenta = DR.Item("id_dokumenta")
                If Not IsDBNull(DR.Item("dp_broj_dok")) Then _dp_broj_dok = DR.Item("dp_broj_dok")
                If Not IsDBNull(DR.Item("dp_ukupno_ulaz")) Then _dp_ukupno_ulaz = DR.Item("dp_ukupno_ulaz")
                If Not IsDBNull(DR.Item("dp_ukupno_izlaz")) Then _dp_ukupno_izlaz = DR.Item("dp_ukupno_izlaz")
                If Not IsDBNull(DR.Item("dp_ukupno_stanje")) Then _dp_ukupno_stanje = DR.Item("dp_ukupno_stanje")
                If Not IsDBNull(DR.Item("dp_novo_stanje")) Then _dp_novo_stanje = DR.Item("dp_novo_stanje")
                If Not IsDBNull(DR.Item("dp_zakljucen")) Then _dp_zakljucen = DR.Item("dp_zakljucen")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()

    End Sub

    Public Sub selektuj_nivelaciju(ByVal _upit As String, ByVal _selekcija As Integer)

        Dim _sql As String = "select * from dbo.rm_nivelacije_head where dbo.rm_nivelacije_head."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_nivelacija = " & CInt(_upit)
                'Case Selekcija.po_nazivu
                '    _sql += "kz_iz_opis = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "broj = " & _upit '& "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            _id_nivelacije = 0
            _nivelacije_datum = Today
            _nivelacije_broj = 0
            _nivelacije_stara_vrednost = 0
            _nivelacije_nova_vrednost = 0
            _nivelacije_razlika_uceni = 0
            _nivelacije_stari_iznos_pdv = 0
            _nivelacije_novi_iznos_pdv = 0
            _nivelacije_razlika_pdv = 0
            _nivelacije_unesena = 0
            _nivelacije_id_magacin = 0
            _nivelacije_automatska = False
            _nivelacije_vezni_dokument_id = ""
            _nivelacije_vezni_dokument_broj = ""

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_nivelacija")) Then _id_nivelacije = DR.Item("id_nivelacija")
                If Not IsDBNull(DR.Item("id_magacin")) Then _nivelacije_id_magacin = DR.Item("id_magacin")
                If Not IsDBNull(DR.Item("broj")) Then _nivelacije_broj = DR.Item("broj")
                If Not IsDBNull(DR.Item("datum")) Then _nivelacije_datum = DR.Item("datum")
                If Not IsDBNull(DR.Item("stara_vrednost")) Then _nivelacije_stara_vrednost = DR.Item("stara_vrednost")
                If Not IsDBNull(DR.Item("nova_vrednost")) Then _nivelacije_nova_vrednost = DR.Item("nova_vrednost")
                If Not IsDBNull(DR.Item("razlika_uceni")) Then _nivelacije_razlika_uceni = DR.Item("razlika_uceni")
                If Not IsDBNull(DR.Item("stari_iznos_pdv")) Then _nivelacije_stari_iznos_pdv = DR.Item("stari_iznos_pdv")
                If Not IsDBNull(DR.Item("novi_iznos_pdv")) Then _nivelacije_novi_iznos_pdv = DR.Item("novi_iznos_pdv")
                If Not IsDBNull(DR.Item("razlika_pdv")) Then _nivelacije_razlika_pdv = DR.Item("razlika_pdv")
                If Not IsDBNull(DR.Item("unesena")) Then _nivelacije_unesena = DR.Item("unesena")
                If Not IsDBNull(DR.Item("automatska")) Then _nivelacije_automatska = DR.Item("automatska")
                If Not IsDBNull(DR.Item("vezni_dokument_id")) Then _nivelacije_vezni_dokument_id = DR.Item("vezni_dokument_id")
                If Not IsDBNull(DR.Item("vezni_dokument_broj")) Then _nivelacije_vezni_dokument_broj = DR.Item("vezni_dokument_broj")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub nivelacija_print()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()

        If CN.State = ConnectionState.Open Then

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prn_nivelacija_delete"
                .ExecuteScalar()
            End With
            CM.Dispose()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.rm_nivelacije_stavka where dbo.rm_nivelacije_stavka.id_nivelacija = " & _id_nivelacije
                DR = .ExecuteReader
            End With

            Dim i As Integer = 0
            Dim stavka_rb() As String = New String(50) {}
            Dim stavka_id() As Integer = New Integer(50) {}
            Dim stavka_roba() As String = New String(50) {}
            Dim stavka_kol() As Single = New Single(50) {}
            Dim stavka_st_cena() As Single = New Single(50) {}
            Dim stavka_st_vred() As Single = New Single(50) {}
            Dim stavka_n_cena() As Single = New Single(50) {}
            Dim stavka_n_vred() As Single = New Single(50) {}
            Dim stavka_razlika() As Single = New Single(50) {}
            Dim stavka_st_pdv() As Single = New Single(50) {}
            Dim stavka_st_izn_pdv() As Single = New Single(50) {}
            Dim stavka_n_pdv() As Single = New Single(50) {}
            Dim stavka_n_izn_pdv() As Single = New Single(50) {}
            Dim stavka_razlika_pdv() As Single = New Single(50) {}

            Do While DR.Read
                If Not IsDBNull(DR.Item("rb")) Then stavka_rb.SetValue(DR.Item("rb"), i)
                If Not IsDBNull(DR.Item("id_artikl")) Then stavka_id.SetValue(DR.Item("id_artikl"), i)
                If Not IsDBNull(DR.Item("kolicina")) Then stavka_kol.SetValue(CSng(DR.Item("kolicina")), i)
                If Not IsDBNull(DR.Item("stara_cena")) Then stavka_st_cena.SetValue(CSng(DR.Item("stara_cena")), i)
                If Not IsDBNull(DR.Item("stara_vrednost")) Then stavka_st_vred.SetValue(CSng(DR.Item("stara_vrednost")), i)
                If Not IsDBNull(DR.Item("nova_cena")) Then stavka_n_cena.SetValue(CSng(DR.Item("nova_cena")), i)
                If Not IsDBNull(DR.Item("nova_vrednost")) Then stavka_n_vred.SetValue(CSng(DR.Item("nova_vrednost")), i)
                If Not IsDBNull(DR.Item("razlika_cena")) Then stavka_razlika.SetValue(CSng(DR.Item("razlika_cena")), i)
                If Not IsDBNull(DR.Item("stari_pdv")) Then stavka_st_pdv.SetValue(CSng(DR.Item("stari_pdv")), i)
                If Not IsDBNull(DR.Item("stari_iznos_pdv")) Then stavka_st_izn_pdv.SetValue(CSng(DR.Item("stari_iznos_pdv")), i)
                If Not IsDBNull(DR.Item("novi_pdv")) Then stavka_n_pdv.SetValue(CSng(DR.Item("novi_pdv")), i)
                If Not IsDBNull(DR.Item("novi_iznos_pdv")) Then stavka_n_izn_pdv.SetValue(CSng(DR.Item("novi_iznos_pdv")), i)
                If Not IsDBNull(DR.Item("razlika_pdv")) Then stavka_razlika_pdv.SetValue(CSng(DR.Item("razlika_pdv")), i)
                i += 1
            Loop
            DR.Close()
            CM.Dispose()

            Dim j As Integer = 0
            For j = 0 To i - 1
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "prn_nivelacija_add"
                    .Parameters.AddWithValue("@broj", CStr(_nivelacije_broj))
                    .Parameters.AddWithValue("@id_magacin", _nivelacije_id_magacin)
                    .Parameters.AddWithValue("@datum", _nivelacije_datum)
                    .Parameters.AddWithValue("@stara_vrednost", _nivelacije_stara_vrednost)
                    .Parameters.AddWithValue("@nova_vrednost", _nivelacije_nova_vrednost)
                    .Parameters.AddWithValue("@razlika_uceni", _nivelacije_razlika_uceni)
                    .Parameters.AddWithValue("@stari_iznos_pdv", _nivelacije_stari_iznos_pdv)
                    .Parameters.AddWithValue("@novi_iznos_pdv", _nivelacije_novi_iznos_pdv)
                    .Parameters.AddWithValue("@razlika_pdv", _nivelacije_razlika_pdv)
                    .Parameters.AddWithValue("@unesena", _nivelacije_unesena)
                    .Parameters.AddWithValue("@rb", stavka_rb(j))
                    .Parameters.AddWithValue("@id_artikl", stavka_id(j))
                    selektuj_artikl(stavka_id(j), Selekcija.po_id)
                    .Parameters.AddWithValue("@atr_jkl", _artikl_jkl)
                    .Parameters.AddWithValue("@roba_sifra", _artikl_sifra)
                    .Parameters.AddWithValue("@id_grupa", _artikl_id_grupa)
                    .Parameters.AddWithValue("@roba_naziv", _artikl_naziv)
                    .Parameters.AddWithValue("@id_jm", _artikl_id_jm)
                    .Parameters.AddWithValue("@kolicina", stavka_kol(j))
                    .Parameters.AddWithValue("@stav_stara_cena", stavka_st_cena(j))
                    .Parameters.AddWithValue("@stav_stara_vrednost", stavka_st_vred(j))
                    .Parameters.AddWithValue("@stav_nova_cena", stavka_n_cena(j))
                    .Parameters.AddWithValue("@stav_nova_vrednost", stavka_n_vred(j))
                    .Parameters.AddWithValue("@stav_razlika_cena", stavka_razlika(j))
                    .Parameters.AddWithValue("@stav_stari_pdv", stavka_st_pdv(j))
                    .Parameters.AddWithValue("@stav_stari_iznos_pdv", stavka_st_izn_pdv(j))
                    .Parameters.AddWithValue("@stav_novi_pdv", stavka_n_pdv(j))
                    .Parameters.AddWithValue("@stav_novi_iznos_pdv", stavka_n_izn_pdv(j))
                    .Parameters.AddWithValue("@stav_razlika_pdv", stavka_razlika_pdv(j))
                    .Parameters.AddWithValue("@mag_datum_promene_od", Today)
                    .Parameters.AddWithValue("@mag_datum_promene_do", Today)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            Next
        End If
        CN.Close()
    End Sub

#Region "roba"

    Public Function artikl_naziv(ByVal _id) As String
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        artikl_naziv = ""
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli where dbo.rm_artikli.id_artikl = '" & _id & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                artikl_naziv = DR.Item("artikl_naziv")
            Loop
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Public Function artikl_id(ByVal _naziv) As Integer
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Try
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli where dbo.rm_artikli.artikl_naziv = N'" & _naziv & "'"
                    DR = .ExecuteReader
                End With
                Do While DR.Read
                    artikl_id = DR.Item("id_artikl")
                Loop
                DR.Close()
            End If
            CM.Dispose()
            CN.Close()

            Return artikl_id
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try


    End Function

    Public Function artikl_sifra(ByVal _id) As Integer
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli where dbo.rm_artikli.id_artikl = '" & _id & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                artikl_sifra = DR.Item("artikl_sifra")
            Loop
        End If
        CM.Dispose()
        CN.Close()

        Return artikl_sifra

    End Function

    Public Sub selektuj_artikl(ByVal _upit As String, ByVal _selekcija As Integer)
        On Error Resume Next
        Dim _sql As String = "select * from dbo.rm_artikli where dbo.rm_artikli."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_artikl = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "artikl_naziv = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "artikl_sifra = N'" & _upit & "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            _id_artikl = 0
            _artikl_naziv = ""
            _artikl_sifra = ""
            _artikl_id_grupa = 0
            _artikl_id_podgrupa = 0
            _artikl_jkl = ""
            _artikl_lek = False
            _artikl_id_jm = 0
            _artikl_id_pdv = 0
            _artikl_id_fo = 0
            _artikl_id_proizvodjac = 0
            _artikl_genericko_ime = ""
            _artikl_bar_kod = ""
            _artikl_humanitarna_pomoc = False
            _zal_po_serbr = False
            _zal_po_roku_trajanja = False
            _zal_po_reg_adresi = False
            _artikl_aktivan = False

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_artikl")) Then _id_artikl = DR.Item("id_artikl")
                If Not IsDBNull(DR.Item("artikl_sifra")) Then _artikl_sifra = RTrim(DR.Item("artikl_sifra"))
                If Not IsDBNull(DR.Item("artikl_naziv")) Then _artikl_naziv = DR.Item("artikl_naziv")
                If Not IsDBNull(DR.Item("id_grup_artikla")) Then _artikl_id_grupa = DR.Item("id_grup_artikla")
                If Not IsDBNull(DR.Item("id_podgrup_artikla")) Then _artikl_id_podgrupa = DR.Item("id_podgrup_artikla")
                If Not IsDBNull(DR.Item("jkl")) Then _artikl_jkl = RTrim(DR.Item("jkl"))
                If Not IsDBNull(DR.Item("artikl_lek")) Then _artikl_lek = RTrim(DR.Item("artikl_lek"))
                If Not IsDBNull(DR.Item("id_jm")) Then _artikl_id_jm = DR.Item("id_jm")
                If Not IsDBNull(DR.Item("id_pdv")) Then _artikl_id_pdv = DR.Item("id_pdv")
                If Not IsDBNull(DR.Item("id_fo")) Then _artikl_id_fo = DR.Item("id_fo")
                If Not IsDBNull(DR.Item("id_proizvodjac")) Then _artikl_id_proizvodjac = DR.Item("id_proizvodjac")
                If Not IsDBNull(DR.Item("artikl_genericko_ime")) Then _artikl_genericko_ime = DR.Item("artikl_genericko_ime")
                If Not IsDBNull(DR.Item("artikl_bar_kod")) Then _artikl_bar_kod = DR.Item("artikl_bar_kod")
                If Not IsDBNull(DR.Item("artikl_human_pomoc")) Then _artikl_humanitarna_pomoc = DR.Item("artikl_human_pomoc")
                If Not IsDBNull(DR.Item("zal_po_serbr")) Then _zal_po_serbr = DR.Item("zal_po_serbr")
                If Not IsDBNull(DR.Item("zal_po_roku_trajanja")) Then _zal_po_roku_trajanja = DR.Item("zal_po_roku_trajanja")
                If Not IsDBNull(DR.Item("zal_po_reg_adresi")) Then _zal_po_reg_adresi = DR.Item("zal_po_reg_adresi")
                If Not IsDBNull(DR.Item("artikl_aktivan")) Then _artikl_aktivan = DR.Item("artikl_aktivan")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub selektuj_artikl_cenu(ByVal _artID As Integer, ByVal magacinID As Integer)
        'On Error Resume Next
        Dim _sql As String = "select * from dbo.rm_artikli_cene where dbo.rm_artikli_cene.id_artikl = " & _
                            _artID & " and dbo.rm_artikli_cene.id_magacin = " & magacinID

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            _id_cena_robe = 0
            _cena_nab_zadnja = 0
            _cena_vp1 = 0
            _cena_vp2 = 0
            _cena_vp3 = 0
            _cena_mp = 0
            _pdv = 0
            _rabat = 0
            _marza = 0

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_cena_robe")) Then _id_cena_robe = DR.Item("id_cena_robe")
                If Not IsDBNull(DR.Item("cena_nab_zadnja")) Then _cena_nab_zadnja = RTrim(DR.Item("cena_nab_zadnja"))
                If Not IsDBNull(DR.Item("cena_vp1")) Then _cena_vp1 = DR.Item("cena_vp1")
                If Not IsDBNull(DR.Item("cena_vp2")) Then _cena_vp2 = DR.Item("cena_vp2")
                If Not IsDBNull(DR.Item("cena_vp3")) Then _cena_vp3 = DR.Item("cena_vp3")
                If Not IsDBNull(DR.Item("cena_mp")) Then _cena_mp = RTrim(DR.Item("cena_mp"))
                If Not IsDBNull(DR.Item("pdv")) Then _pdv = RTrim(DR.Item("pdv"))
                If Not IsDBNull(DR.Item("rabat")) Then _rabat = DR.Item("rabat")
                If Not IsDBNull(DR.Item("marza")) Then _marza = DR.Item("marza")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub izdaj_robu(ByVal roba As Array, ByVal N As Integer)
        Dim i As Integer
        Try
            For i = 0 To N - 1
                Dim CN As SqlConnection = New SqlConnection(CNNString)
                Dim CM As New SqlCommand
                Dim DR As SqlDataReader

                CN.Open()
                CM = New SqlCommand()
                If CN.State = ConnectionState.Open Then
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.Text
                        .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli where dbo.rm_artikli.sifra = '" & _nazivi(i, 0) & "'"
                        DR = .ExecuteReader
                    End With
                    Do While DR.Read
                        roba_promena_stanja(DR.Item("id_roba"), DR.Item("kolicina") + _nazivi(i, 1))
                    Loop
                End If
                CM.Dispose()
                CN.Close()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub izdaj_povratnicu(ByVal roba As Array, ByVal N As Integer)
        Dim i As Integer
        Try
            For i = 0 To N - 1
                Dim CN As SqlConnection = New SqlConnection(CNNString)
                Dim CM As New SqlCommand
                Dim DR As SqlDataReader

                CN.Open()
                CM = New SqlCommand()
                If CN.State = ConnectionState.Open Then
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.Text
                        .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli where dbo.rm_artikli.sifra = '" & _nazivi(i, 0) & "'"
                        DR = .ExecuteReader
                    End With
                    Do While DR.Read
                        roba_promena_stanja(DR.Item("id_roba"), DR.Item("kolicina") - _nazivi(i, 1))
                    Loop
                End If
                CM.Dispose()
                CN.Close()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub roba_promena_stanja(ByVal id, ByVal kol)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "roba_promena_stanja"
                .Parameters.AddWithValue("@id_roba", id)
                .Parameters.AddWithValue("@kolicina", kol)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub proveri_stanje(ByVal imena As Array, ByVal N As Integer)
        Dim i As Integer
        Dim listView1 As New ListView()
        'Dim imena = New Array.CreateInstance(GetType(String), 50, 3)

        listView1.View = View.Details
        listView1.LabelEdit = True
        listView1.AllowColumnReorder = True
        listView1.FullRowSelect = True
        listView1.GridLines = True
        listView1.Dock = DockStyle.Fill
        listView1.BringToFront()
        listView1.ForeColor = Color.MidnightBlue

        listView1.Columns.Add("Šifra", 60, HorizontalAlignment.Left)
        listView1.Columns.Add("Šifra - opis", 60, HorizontalAlignment.Left)
        listView1.Columns.Add("Naziv", 180, HorizontalAlignment.Left)
        listView1.Columns.Add("kolicina", 85, HorizontalAlignment.Right)
        listView1.Columns.Add("kategorija", 85, HorizontalAlignment.Right)

        Try
            For i = 0 To N - 1
                Dim CN As SqlConnection = New SqlConnection(CNNString)
                Dim CM As New SqlCommand
                Dim DR As SqlDataReader

                CN.Open()
                CM = New SqlCommand()
                If CN.State = ConnectionState.Open Then
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.Text
                        .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli where dbo.rm_artikli.sifra = '" & _nazivi(i, 0) & "'"
                        DR = .ExecuteReader
                    End With
                    Do While DR.Read
                        Dim roba As New ListViewItem(DR.Item("sifra").ToString, 0)
                        roba.SubItems.Add(DR.Item("sifra_opis").ToString)
                        roba.SubItems.Add(DR.Item("naziv").ToString)
                        If DR.Item("kolicina") < _nazivi(i, 1) Then 'imena(i, 1) Then 
                            roba.ForeColor = Color.Red
                        Else
                            roba.ForeColor = Color.MidnightBlue
                        End If
                        roba.SubItems.Add(DR.Item("kolicina").ToString)
                        roba.SubItems.Add(DR.Item("kategorija").ToString)

                        listView1.Items.AddRange(New ListViewItem() {roba})
                    Loop
                    DR.Close()
                End If
                CM.Dispose()
                CN.Close()
            Next

            _lista = listView1
            'Dim mForm As New frmLista
            'mForm.Panel1.Controls.Add(listView1)
            'mForm.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub proveri_stanje_glavni()
        Dim listView1 As New ListView()
        listView1.View = View.Details
        listView1.LabelEdit = True
        listView1.AllowColumnReorder = True
        listView1.FullRowSelect = True
        listView1.GridLines = True
        listView1.Dock = DockStyle.Fill
        listView1.BringToFront()
        listView1.ForeColor = Color.MidnightBlue

        listView1.Columns.Add("Šifra", 60, HorizontalAlignment.Left)
        listView1.Columns.Add("Šifra - opis", 60, HorizontalAlignment.Left)
        listView1.Columns.Add("Naziv", 195, HorizontalAlignment.Left)
        listView1.Columns.Add("kolicina", 70, HorizontalAlignment.Right)
        listView1.Columns.Add("min.kolicina", 70, HorizontalAlignment.Right)
        listView1.Columns.Add("kategorija", 100, HorizontalAlignment.Left)

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Try
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli"
                    DR = .ExecuteReader
                End With
                Do While DR.Read
                    Dim roba As New ListViewItem(DR.Item("sifra").ToString, 0)
                    roba.SubItems.Add(DR.Item("sifra_opis").ToString)
                    roba.SubItems.Add(DR.Item("naziv").ToString)
                    If CSng(DR.Item("kolicina")) <= CSng(DR.Item("min_kolicina")) Then
                        roba.ForeColor = Color.Red
                    Else
                        roba.ForeColor = Color.MidnightBlue
                    End If
                    roba.SubItems.Add(DR.Item("kolicina"))
                    roba.SubItems.Add(DR.Item("min_kolicina"))
                    roba.SubItems.Add(DR.Item("kategorija"))

                    listView1.Items.AddRange(New ListViewItem() {roba})
                Loop
                DR.Close()
            End If
            _lista = listView1
            'Dim mForm As New frmLista
            'mForm.Panel1.Controls.Add(listView1)
            'mForm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CM.Dispose()
            CN.Close()
        End Try
    End Sub

#End Region

    Public Sub obrisi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        'Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()

        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prnRacun_delete"
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub upisi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prnRacun_add"
                .Parameters.AddWithValue("@id_racun", _id_racun)
                .Parameters.AddWithValue("@sifra", _sifra_racun)

                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub slobodni_nalozi(ByVal _tabela As String)
        Dim listView1 As New ListView()
        listView1.View = View.Details
        listView1.LabelEdit = True
        listView1.AllowColumnReorder = True
        listView1.FullRowSelect = True
        listView1.GridLines = True
        listView1.CheckBoxes = True
        listView1.Dock = DockStyle.None
        listView1.BringToFront()
        listView1.ForeColor = Color.MidnightBlue

        listView1.Bounds = New Rectangle(New Point(12, 12), New Size(268, 213))
        listView1.Columns.Add("Broj radnog naloga", -2, HorizontalAlignment.Center)
        'listView1.Columns.Add("Broj", 200, HorizontalAlignment.Left)

        Dim sql As String = ""
        Select Case _tabela
            Case Imena.tabele.rm_radni_nalog_head.ToString
                sql = "select dbo.rm_radni_nalog_head.* from dbo.rm_radni_nalog_head where dbo.rm_radni_nalog_head.potvrda = 0"
                _mTabela = Imena.tabele.rm_radni_nalog_head.ToString
            Case Imena.tabele.fn_putni_nalog.ToString
                sql = "select dbo.fn_putni_nalog.* from dbo.putni_nalog where dbo.fn_putni_nalog.racun = 0"
                _mTabela = Imena.tabele.fn_putni_nalog.ToString
        End Select

        Try
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
                Do While DR.Read
                    Dim item As New ListViewItem(DR.Item("broj").ToString, 0)
                    listView1.Items.AddRange(New ListViewItem() {item})
                Loop
                DR.Close()
            End If

            CM.Dispose()
            CN.Close()

            _lista = listView1
            Dim mForm As New frmSlobodniNalozi
            mForm.Controls.Add(listView1)
            mForm.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub prispeli_racuni(ByVal tRacuni As String)
        Dim listView1 As New ListView()

        'listView1.Bounds = New Rectangle(New Point(12, 12), New Size(544, 335))
        listView1.View = View.Details
        listView1.LabelEdit = True
        listView1.AllowColumnReorder = True
        listView1.FullRowSelect = True
        listView1.GridLines = True
        listView1.Dock = DockStyle.Fill
        listView1.BringToFront()
        listView1.ForeColor = Color.MidnightBlue

        listView1.Columns.Add("Šifra", 55, HorizontalAlignment.Left)
        listView1.Columns.Add("Partnera", 80, HorizontalAlignment.Left)
        listView1.Columns.Add("Dat.Faktur.", 70, HorizontalAlignment.Right)
        listView1.Columns.Add("Dat.Valuta", 70, HorizontalAlignment.Right)
        listView1.Columns.Add("Cena", 75, HorizontalAlignment.Right)
        listView1.Columns.Add("Rabat", 45, HorizontalAlignment.Right)
        listView1.Columns.Add("pdv", 70, HorizontalAlignment.Right)
        listView1.Columns.Add("Za uplatu", 85, HorizontalAlignment.Right)

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim sql As String = ""

        Select Case tRacuni.ToString
            Case Imena.tabele.rm_racun_head.ToString
                sql = "select dbo.rm_racun_head.* " & _
                      "from dbo.rm_racun_head " & _
                      "where dbo.rm_racun_head.placeno = 0" '& False
                '"where dbo.rm_racun_head.datum_valuta <= '#" & Today & "#'" 
            Case Imena.tabele.rm_ulazni_racuni.ToString
                sql = "select dbo.rm_ulazni_racuni_head.* " & _
                      "from dbo.rm_ulazni_racuni_head " & _
                      "where dbo.rm_ulazni_racuni_head.placeno = 0"
                '"where dbo.rm_ulazni_racuni_head.datum_valuta <= '#" & Today & "#'"
        End Select
        Try
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = sql
                    DR = .ExecuteReader
                End With
                If DR.HasRows = True Then
                    Do While DR.Read
                        If DR.Item("datum_valuta") <= Today Then
                            Dim racun As New ListViewItem(DR.Item("sifra").ToString, 0)

                            If DR.Item("datum_valuta") < Today Then
                                racun.ForeColor = Color.Red
                            Else
                                racun.ForeColor = Color.MidnightBlue
                            End If

                            racun.SubItems.Add(Partner_naziv(DR.Item("id_partner")))
                            racun.SubItems.Add(DR.Item("datum_fakturisanja"))
                            racun.SubItems.Add(DR.Item("datum_valuta"))
                            racun.SubItems.Add(DR.Item("iznos_cena"))
                            racun.SubItems.Add(DR.Item("iznos_rabat"))
                            racun.SubItems.Add(DR.Item("iznos_pdv"))
                            racun.SubItems.Add(DR.Item("iznos_zanaplatu"))

                            listView1.Items.AddRange(New ListViewItem() {racun})
                        End If
                    Loop
                    DR.Close()
                End If
            End If
            _lista = listView1
            Dim mForm As New frmPrispece

            mForm.Panel1.Controls.Add(listView1)
            mForm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CM.Dispose()
            CN.Close()
        End Try
    End Sub

    Public Sub izdvoj_dokumente(ByVal _partner, ByVal _dug_pot)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        If CN.State = ConnectionState.Open Then

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_dokumenti_delete"
                .ExecuteScalar()
            End With
            CM.Dispose()

            Dim sql As String = ""
            Dim vrsta As Integer
            Select Case _dug_pot
                Case "d"
                    sql = "select dbo.rm_ulazni_racuni_head.* from dbo.rm_ulazni_racuni_head where dbo.rm_ulazni_racuni_head.id_partner = " & RTrim(_partner) & " and dbo.rm_ulazni_racuni_head.placeno = 0"
                    vrsta = 3
                Case "p"
                    sql = "select dbo.rm_racun_head.* from dbo.rm_racun_head where dbo.rm_racun_head.id_partner = " & RTrim(_partner) & " and dbo.rm_racun_head.placeno = 0"
                    vrsta = 2
            End Select

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql
                DR = .ExecuteReader
            End With

            _mCombo.Items.Clear()
            Do While DR.Read
                Dim dok As String = ""
                Select Case _dug_pot
                    Case "d"
                        dok = DR.Item("br_fakture")
                    Case "p"
                        dok = DR.Item("sifra")
                End Select

                dokumenti(DR.Item(0), _partner, dok, DR.Item("iznos_zanaplatu"), vrsta)
                _mCombo.Items.Add(dok)
            Loop
            If _mCombo.Items.Count > 0 Then
                _mCombo.SelectedIndex = 0
            End If
            DR.Close()
            DR.Close()
            CM.Dispose()
        End If
        CN.Close()
    End Sub

    Public Sub dokumenti(ByVal _id, ByVal _partner, ByVal _br_dokumenta, ByVal _iznos, ByVal _vrsta)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_dokumenti_add"
                .Parameters.AddWithValue("id_dokument", _id)
                .Parameters.AddWithValue("vrsta_dokumenta", _vrsta)
                .Parameters.AddWithValue("id_partner", _partner)
                .Parameters.AddWithValue("broj_dokumneta", _br_dokumenta)
                .Parameters.AddWithValue("iznos_za_naplatu", _iznos)
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If
        CN.Close()
    End Sub

    Public Sub dokument_opis(ByVal _broj)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_dokumenti.* from dbo.rm_dokumenti where dbo.rm_dokumenti.broj_dokumneta = '" & RTrim(_broj.ToString) & "'"
                DR = .ExecuteReader
            End With

            _broj_dokumenta = ""
            _id_dokument = 0
            _vrsta_dokumenta = 0
            _za_naplatu = 0
            _id_partner = 0

            Do While DR.Read
                _broj_dokumenta = RTrim(DR.Item("broj_dokumneta").ToString)
                _id_dokument = DR.Item("id_dokument")
                _vrsta_dokumenta = DR.Item("vrsta_dokumenta")
                _id_partner = DR.Item("id_partner")
                _za_naplatu = CDec(DR.Item("iznos_za_naplatu"))
            Loop
            DR.Close()
            DR.Close()
            CM.Dispose()
        End If
        CN.Close()
    End Sub

    Public Function rm_vrste_magacina_naziv(ByVal _id) As String
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        rm_vrste_magacina_naziv = ""
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_vrste_magacina.* from dbo.rm_vrste_magacina where dbo.rm_vrste_magacina.id_vrsta_magacina = '" & _id & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                rm_vrste_magacina_naziv = DR.Item("naziv")
            Loop
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Public Function rm_vodjenje_zaliha_naziv(ByVal _id) As String
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        rm_vodjenje_zaliha_naziv = ""
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_vodjenje_zaliha.* from dbo.rm_vodjenje_zaliha where dbo.rm_vodjenje_zaliha.id_vedjenje_zaliha = '" & _id & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                rm_vodjenje_zaliha_naziv = DR.Item("naziv")
            Loop
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Public Sub selektuj_magacin(ByVal _upit As String, ByVal _selekcija As Integer, Optional ByVal _like As String = "")
        'On Error Resume Next
        Dim _sql As String = "select * from dbo.rm_magacin where dbo.rm_magacin."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_magacin = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "magacin_naziv = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "magacin_sifra = N'" & _upit & "'"
            Case Selekcija._like
                _sql += "magacin_naziv " & _like
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            _id_magacin = 0
            _magacin_sifra = ""
            _magacin_naziv = ""
            _magacin_id_vrsta = 0
            _magacin_vodjenje_zaliha = False
            _magacin_id_zaliha = 0

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_magacin")) Then _id_magacin = DR.Item("id_magacin")
                If Not IsDBNull(DR.Item("magacin_sifra")) Then _magacin_sifra = RTrim(DR.Item("magacin_sifra"))
                If Not IsDBNull(DR.Item("magacin_naziv")) Then _magacin_naziv = DR.Item("magacin_naziv")
                If Not IsDBNull(DR.Item("id_vrsta_magacina")) Then _magacin_id_vrsta = DR.Item("id_vrsta_magacina")
                If Not IsDBNull(DR.Item("magacin_vodjenje_zaliha")) Then _magacin_vodjenje_zaliha = DR.Item("magacin_vodjenje_zaliha")
                If Not IsDBNull(DR.Item("id_vodjenje_zaliha")) Then _magacin_id_zaliha = DR.Item("id_vodjenje_zaliha")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub selektuj_vrste_magacina(ByVal _upit As String, ByVal _selekcija As Integer)
        'On Error Resume Next
        Dim _sql As String = "select * from dbo.rm_vrste_magacina where dbo.rm_vrste_magacina."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_vrsta_mag = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "vrsta_mag_naziv = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "vrsta_mag_sifra = N'" & _upit & "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            _id_vrsta_mag = 0
            _vrsta_mag_sifra = ""
            _vrsta_mag_naziv = ""

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_vrsta_mag")) Then _id_magacin = DR.Item("id_vrsta_mag")
                If Not IsDBNull(DR.Item("vrsta_mag_sifra")) Then _vrsta_mag_sifra = DR.Item("vrsta_mag_sifra")
                If Not IsDBNull(DR.Item("vrsta_mag_naziv")) Then _vrsta_mag_naziv = DR.Item("vrsta_mag_naziv")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub selektuj_oj(ByVal _upit As String, ByVal _selekcija As Integer)

        Dim _sql As String = "select * from dbo.app_organizacione_jedinice where dbo.app_organizacione_jedinice."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_orgjed = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "oj_naziv = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "oj_sifra = N'" & _upit & "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            _id_oj = 0
            _oj_sifra = ""
            _oj_naziv = ""
            _oj_adresa = ""
            _oj_id_opstine = 0
            _oj_id_mesta = 0
            _oj_strukturna = False
            _oj_aktivan = False
            _id_grad = 0

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_orgjed")) Then _id_oj = DR.Item("id_orgjed")
                If Not IsDBNull(DR.Item("oj_sifra")) Then _oj_sifra = DR.Item("oj_sifra")
                If Not IsDBNull(DR.Item("oj_naziv")) Then _oj_naziv = DR.Item("oj_naziv")
                If Not IsDBNull(DR.Item("oj_adresa")) Then _oj_adresa = DR.Item("oj_adresa")
                If Not IsDBNull(DR.Item("id_grad")) Then _id_grad = DR.Item("id_grad")
                If Not IsDBNull(DR.Item("id_opstine")) Then _oj_id_opstine = DR.Item("id_opstine")
                If Not IsDBNull(DR.Item("id_mesta")) Then _oj_id_mesta = DR.Item("id_mesta")
                If Not IsDBNull(DR.Item("id_vrsta")) Then _id_vrsta = DR.Item("id_vrsta")
                If Not IsDBNull(DR.Item("oj_strukturna")) Then _oj_strukturna = DR.Item("oj_strukturna")
                If Not IsDBNull(DR.Item("oj_aktivan")) Then _oj_aktivan = DR.Item("oj_aktivan")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub selektuj_vrstu_oj(ByVal _upit As String, ByVal _selekcija As Integer)

        Dim _sql As String = "select * from dbo.app_vrsta_oj where dbo.app_vrsta_oj."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_vrsta_oj = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "vrsta_oj_naziv = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "vrsta_oj_sifra = N'" & _upit & "'"
        End Select

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = _sql
                DR = .ExecuteReader
            End With

            _id_vrsta_oj = 0
            _vrsta_oj_sifra = ""
            _vrsta_oj_naziv = ""
            _vrsta_oj_vodjenje_zaliha = True
            _vrsta_oj_obj_robnog_poslovanja = True
            _vrsta_oj_obj_blagajnickog_poslovanja = True
            _vrsta_oj_prodajni_objekat = True
            _vrsta_oj_fakturise = True
            _id_vrsta_cenovnika = ""
            _vrsta_oj_minusne_zalihe = True
            _vrsta_oj_auto_promena_cene = True
            _vrsta_oj_minusne_rezervacije = True

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_vrsta_oj")) Then _id_vrsta_oj = DR.Item("id_vrsta_oj")
                If Not IsDBNull(DR.Item("vrsta_oj_sifra")) Then _vrsta_oj_sifra = DR.Item("vrsta_oj_sifra")
                If Not IsDBNull(DR.Item("vrsta_oj_naziv")) Then _vrsta_oj_naziv = DR.Item("vrsta_oj_naziv")
                If Not IsDBNull(DR.Item("vrsta_oj_vodjenje_zaliha")) Then _vrsta_oj_vodjenje_zaliha = DR.Item("vrsta_oj_vodjenje_zaliha")
                If Not IsDBNull(DR.Item("vrsta_oj_obj_robnog_poslovanja")) Then _vrsta_oj_obj_robnog_poslovanja = DR.Item("vrsta_oj_obj_robnog_poslovanja")
                If Not IsDBNull(DR.Item("vrsta_oj_obj_blagajnickog_poslovanja")) Then _vrsta_oj_obj_blagajnickog_poslovanja = DR.Item("vrsta_oj_obj_blagajnickog_poslovanja")
                If Not IsDBNull(DR.Item("vrsta_oj_prodajni_objekat")) Then _vrsta_oj_prodajni_objekat = DR.Item("vrsta_oj_prodajni_objekat")
                If Not IsDBNull(DR.Item("vrsta_oj_fakturise")) Then _vrsta_oj_fakturise = DR.Item("vrsta_oj_fakturise")
                If Not IsDBNull(DR.Item("id_vrsta_cenovnika")) Then _id_vrsta_cenovnika = DR.Item("id_vrsta_cenovnika")
                If Not IsDBNull(DR.Item("vrsta_oj_minusne_zalihe")) Then _vrsta_oj_minusne_zalihe = DR.Item("vrsta_oj_minusne_zalihe")
                If Not IsDBNull(DR.Item("vrsta_oj_auto_promena_cene")) Then _vrsta_oj_auto_promena_cene = DR.Item("vrsta_oj_auto_promena_cene")
                If Not IsDBNull(DR.Item("vrsta_oj_minusne_rezervacije")) Then _vrsta_oj_minusne_rezervacije = DR.Item("vrsta_oj_minusne_rezervacije")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Function jeste_broj(ByVal fText As String) As Boolean
        Dim i As Integer

        If Len(fText) > 0 Then
            For i = 1 To fText.Length
                Dim a = Asc(Mid(fText, i, 1))
                If Asc(Mid(fText, i, 1)) >= 48 And _
                    Asc(Mid(fText, i, 1)) <= 57 Or _
                    Asc(Mid(fText, i, 1)) = 32 Or _
                    Asc(Mid(fText, i, 1)) = 44 Or _
                    Asc(Mid(fText, i, 1)) = 45 Or _
                    Asc(Mid(fText, i, 1)) = 46 Then
                    jeste_broj = True
                Else
                    jeste_broj = False
                    Exit For
                End If
            Next
        End If
        If Not jeste_broj Then MsgBox("Uneli ste slovo ili neki drugi znak u polje rezervisano za cifre" & vbLf & "Molimo Vas da ispravite grešku", MsgBoxStyle.OkOnly)
    End Function

    Public Function jesu_cifre(ByVal fText As String) As Boolean
        Dim i As Integer

        If Len(fText) > 0 Then
            For i = 1 To fText.Length
                If Asc(Mid(fText, i, 1)) >= 48 And _
                    Asc(Mid(fText, i, 1)) <= 57 Then
                    jesu_cifre = True
                Else
                    jesu_cifre = False
                    Exit For
                End If
            Next
        End If
        If Not jesu_cifre Then MsgBox("Uneli ste slovo ili neki drugi znak u polje rezervisano za cifre" & vbLf & "Molimo Vas da ispravite grešku", MsgBoxStyle.OkOnly)
    End Function


End Module
