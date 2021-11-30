Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Module mFunk_finansijsko

    Public Function Nadji_rb_naloga(ByVal _vrsta As String) As Integer
        Dim CN As System.Data.SqlClient.SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim _sql As String = "select * from dbo.fn_nalog_head where nal_vrsta = " & _vrsta & "'"

        Nadji_rb_naloga = 0
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
                    If CInt(DR.Item("nal_broj")) > Nadji_rb_naloga Then Nadji_rb_naloga = CInt(DR.Item("nal_broj"))
                Loop
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                MsgBox(ex.Message, MsgBoxStyle.OkOnly)
            End Try
        End If
        CM.Dispose()
        CN.Close()
        Nadji_rb_naloga += 1
    End Function

    Public Sub selektuj_nalog(ByVal _upit As String, ByVal _selekcija As Integer, Optional ByVal _vrsta As String = "")
        'On Error Resume Next
        Dim _sql As String = "select * from dbo.fn_nalog_head where dbo.fn_nalog_head."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_nalog = " & CInt(_upit)
                'Case Selekcija.po_nazivu
                '    _sql += "nal_vrsta = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "nal_vrsta = N'" & RTrim(_vrsta) & "' and nal_broj = " & _upit & ""
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

            _id_nalog = 0
            _nal_datum = Today
            _nal_vrsta = ""
            _nal_broj = 0
            _nal_duguje = 0
            _nal_potrazuje = 0
            _nal_proknjizen = False
            _nal_storniran = False
            _nal_napomena = ""

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_nalog")) Then _id_nalog = DR.Item("id_nalog")
                If Not IsDBNull(DR.Item("nal_datum")) Then _nal_datum = DR.Item("nal_datum")
                If Not IsDBNull(DR.Item("nal_vrsta")) Then _nal_vrsta = RTrim(DR.Item("nal_vrsta"))
                If Not IsDBNull(DR.Item("nal_broj")) Then _nal_broj = DR.Item("nal_broj")
                If Not IsDBNull(DR.Item("nal_duguje")) Then _nal_duguje = DR.Item("nal_duguje")
                If Not IsDBNull(DR.Item("nal_potrazuje")) Then _nal_potrazuje = DR.Item("nal_potrazuje")
                If Not IsDBNull(DR.Item("nal_proknjizen")) Then _nal_proknjizen = DR.Item("nal_proknjizen")
                If Not IsDBNull(DR.Item("nal_storniran")) Then _nal_storniran = DR.Item("nal_storniran")
                If Not IsDBNull(DR.Item("nal_napomena")) Then _nal_napomena = DR.Item("nal_napomena")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub selektuj_nalog_stavka(ByVal _upit As String, ByVal _selekcija As Integer, Optional ByVal _vrsta As String = "")
        'On Error Resume Next
        Dim _sql As String = "select * from dbo.fn_nalog_stavka where dbo.fn_nalog_stavka."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_stavka = " & CInt(_upit)
                'Case Selekcija.po_nazivu
                '    _sql += "nal_vrsta = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "id_nalog = " & CInt(_upit)
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

            _id_nalog = 0
            _id_nal_stavka = 0
            _stavka_rb = 0
            _stavka_opis_sifra = ""
            _stavka_opis = ""
            _stavka_konto = ""
            _stavka_analitika = ""
            _stavka_duguje = 0
            _stavka_potrazuje = 0
            _stavka_brDok = ""
            _stavka_datDok = ""
            _stavka_valuta = ""
            _stavka_zatvorena = False

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_nalog")) Then _id_nalog = DR.Item("id_nalog")
                If Not IsDBNull(DR.Item("id_stavka")) Then _id_nal_stavka = DR.Item("id_stavka")
                If Not IsDBNull(DR.Item("stavka_rb")) Then _stavka_rb = RTrim(DR.Item("stavka_rb"))
                If Not IsDBNull(DR.Item("stavka_opis_sifra")) Then _stavka_opis_sifra = DR.Item("stavka_opis_sifra")
                If Not IsDBNull(DR.Item("stavka_opis")) Then _stavka_opis = DR.Item("stavka_opis")
                If Not IsDBNull(DR.Item("stavka_konto")) Then _stavka_konto = DR.Item("stavka_konto")
                If Not IsDBNull(DR.Item("stavka_analitika")) Then _stavka_analitika = DR.Item("stavka_analitika")
                If Not IsDBNull(DR.Item("stavka_duguje")) Then _stavka_duguje = DR.Item("stavka_duguje")
                If Not IsDBNull(DR.Item("stavka_potrazuje")) Then _stavka_potrazuje = DR.Item("stavka_potrazuje")
                If Not IsDBNull(DR.Item("stavka_brDok")) Then _stavka_brDok = DR.Item("stavka_brDok")
                If Not IsDBNull(DR.Item("stavka_datDok")) Then _stavka_datDok = DR.Item("stavka_datDok")
                If Not IsDBNull(DR.Item("stavka_valuta")) Then _stavka_valuta = DR.Item("stavka_valuta")
                If Not IsDBNull(DR.Item("stavka_zatvorena")) Then _stavka_zatvorena = DR.Item("stavka_zatvorena")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub nalog_print()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()

        If CN.State = ConnectionState.Open Then
            If Not _nal_print_all Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "prn_nalog_delete"
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.fn_nalog_stavka where dbo.fn_nalog_stavka.id_nalog = " & _id_nalog
                DR = .ExecuteReader
            End With

            Dim i As Integer = 0
            Dim stavka_rb() As String = New String(1000) {}
            Dim stavka_opis_sifra() As String = New String(1000) {}
            Dim stavka_opis() As String = New String(1000) {}
            Dim stavka_konto() As String = New String(1000) {}
            Dim stavka_analitika() As String = New String(1000) {}
            Dim stavka_duguje() As Single = New Single(1000) {}
            Dim stavka_potrazuje() As Single = New Single(1000) {}
            Dim stavka_brDok() As String = New String(1000) {}
            Dim stavka_datDok() As String = New String(1000) {}
            Dim stavka_valuta() As String = New String(1000) {}
            'ReDim stavka_prvred(5)

            Do While DR.Read
                If Not IsDBNull(DR.Item("stavka_rb")) Then stavka_rb.SetValue(DR.Item("stavka_rb"), i)
                If Not IsDBNull(DR.Item("stavka_opis_sifra")) Then stavka_opis_sifra.SetValue(DR.Item("stavka_opis_sifra"), i)
                If Not IsDBNull(DR.Item("stavka_opis")) Then stavka_opis.SetValue(DR.Item("stavka_opis"), i)
                If Not IsDBNull(DR.Item("stavka_konto")) Then stavka_konto.SetValue(DR.Item("stavka_konto"), i)
                If Not IsDBNull(DR.Item("stavka_analitika")) Then stavka_analitika.SetValue(DR.Item("stavka_analitika"), i)
                If Not IsDBNull(DR.Item("stavka_duguje")) Then stavka_duguje.SetValue(CSng(DR.Item("stavka_duguje")), i)
                If Not IsDBNull(DR.Item("stavka_potrazuje")) Then stavka_potrazuje.SetValue(CSng(DR.Item("stavka_potrazuje")), i)
                If Not IsDBNull(DR.Item("stavka_brDok")) Then stavka_brDok.SetValue(DR.Item("stavka_brDok"), i)
                If Not IsDBNull(DR.Item("stavka_datDok")) Then stavka_datDok.SetValue(DR.Item("stavka_datDok"), i)
                If Not IsDBNull(DR.Item("stavka_valuta")) Then stavka_valuta.SetValue(DR.Item("stavka_valuta"), i)
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
                    .CommandText = "prn_nalog_add"

                    .Parameters.AddWithValue("@nal_vrsta", _nal_vrsta)
                    .Parameters.AddWithValue("@nal_broj", _nal_broj)
                    .Parameters.AddWithValue("@nal_datum", _nal_datum)
                    .Parameters.AddWithValue("@nal_duguje", _nal_duguje)
                    .Parameters.AddWithValue("@nal_potrazuje", _nal_potrazuje)
                    .Parameters.AddWithValue("@nal_proknjizen", _nal_proknjizen)
                    .Parameters.AddWithValue("@nal_storniran", _nal_storniran)
                    .Parameters.AddWithValue("@nal_napomena", _nal_napomena)

                    .Parameters.AddWithValue("@stavka_rb", stavka_rb(j))
                    .Parameters.AddWithValue("@stavka_opis_sifra", stavka_opis_sifra(j))
                    .Parameters.AddWithValue("@stavka_opis", stavka_opis(j))
                    .Parameters.AddWithValue("@stavka_konto", stavka_konto(j))
                    .Parameters.AddWithValue("@stavka_analitika", stavka_analitika(j))
                    .Parameters.AddWithValue("@stavka_duguje", stavka_duguje(j))
                    .Parameters.AddWithValue("@stavka_potrazuje", stavka_potrazuje(j))
                    .Parameters.AddWithValue("@stavka_brDok", stavka_brDok(j))
                    .Parameters.AddWithValue("@stavka_datDok", stavka_datDok(j))
                    .Parameters.AddWithValue("@stavka_valuta", stavka_valuta(j))
                    .ExecuteScalar()
                End With
                CM.Dispose()
            Next
        End If
        CN.Close()
    End Sub

    Public Sub selektuj_konto(ByVal _upit As String, ByVal _selekcija As Integer)
        Dim _sql As String = "select * from dbo.app_konto where dbo.app_konto."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_konto = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "Naziv = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "Konto_Sifra = N'" & _upit & "'"
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

            _id_konto = 0
            _konto_Sifra = ""
            _konto_Godina_Vaznosti_Od = ""
            _konto_naziv = ""
            _konto_Dozvoljeno_Knjizenje = False
            _konto_Devizno_Knjizenje = False
            _konto_Tip_Konta = ""
            _konto_ima_analitiku = False
            _konto_Vrsta_Analitike_Sifra = ""
            _konto_Vrsta_Subanalitike_Sifra = ""
            _konto_Vrsta_Mesta_Troska_Sifra = ""
            _konto_Pocetno_Stanje = False
            _konto_Nivo_Pocetnog_Stanja = ""
            _konto_Nivo_Zatvaranja = ""
            _konto_Aktiva_Pasiva = ""
            _konto_Bilansno_Vanbilansno = ""
            _konto_Vazi_Do = Today
            _konto_Ispravke = False
            _konto_Pasiviziran = False

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_konto")) Then _id_konto = DR.Item("id_konto")
                If Not IsDBNull(DR.Item("Konto_Sifra")) Then _konto_Sifra = RTrim(DR.Item("Konto_Sifra"))
                If Not IsDBNull(DR.Item("Godina_Vaznosti_Od")) Then _konto_Godina_Vaznosti_Od = RTrim(DR.Item("Godina_Vaznosti_Od"))
                If Not IsDBNull(DR.Item("Naziv")) Then _konto_naziv = RTrim(DR.Item("Naziv"))
                If Not IsDBNull(DR.Item("Dozvoljeno_Knjizenje")) Then _konto_Dozvoljeno_Knjizenje = DR.Item("Dozvoljeno_Knjizenje")
                If Not IsDBNull(DR.Item("Devizno_Knjizenje")) Then _konto_Devizno_Knjizenje = DR.Item("Devizno_Knjizenje")
                If Not IsDBNull(DR.Item("Tip_Konta")) Then _konto_Tip_Konta = DR.Item("Tip_Konta")
                If Not IsDBNull(DR.Item("ima_analitiku")) Then _konto_ima_analitiku = DR.Item("ima_analitiku")
                If Not IsDBNull(DR.Item("Vrsta_Analitike_Sifra")) Then _konto_Vrsta_Analitike_Sifra = RTrim(DR.Item("Vrsta_Analitike_Sifra"))
                If Not IsDBNull(DR.Item("Vrsta_Subanalitike_Sifra")) Then _konto_Vrsta_Subanalitike_Sifra = RTrim(DR.Item("Vrsta_Subanalitike_Sifra"))
                If Not IsDBNull(DR.Item("Nivo_Pocetnog_Stanja")) Then _konto_Nivo_Pocetnog_Stanja = RTrim(DR.Item("Nivo_Pocetnog_Stanja"))
                If Not IsDBNull(DR.Item("Nivo_Zatvaranja")) Then _konto_Nivo_Zatvaranja = RTrim(DR.Item("Nivo_Zatvaranja"))
                If Not IsDBNull(DR.Item("Aktiva_Pasiva")) Then _konto_Aktiva_Pasiva = RTrim(DR.Item("Aktiva_Pasiva"))
                If Not IsDBNull(DR.Item("Bilansno_Vanbilansno")) Then _konto_Bilansno_Vanbilansno = RTrim(DR.Item("Bilansno_Vanbilansno"))
                If Not IsDBNull(DR.Item("Vazi_Do")) Then _konto_Vazi_Do = RTrim(DR.Item("Vazi_Do"))
                If Not IsDBNull(DR.Item("konto_Ispravke")) Then _konto_Ispravke = DR.Item("konto_Ispravke")
                If Not IsDBNull(DR.Item("Pasiviziran")) Then _konto_Pasiviziran = DR.Item("Pasiviziran")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub selektuj_semu(ByVal tSifra)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from sema_za_knjizenje_head where dbo.fn_sema_za_knjizenje_head.sifra = '" & tSifra & "'"
                DR = .ExecuteReader
            End With

            _id_sema = 0
            _sema_sifra = RTrim(tSifra)
            _sema_naziv = ""

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_sema")) Then _id_sema = DR.Item("id_sema")
                If Not IsDBNull(DR.Item("naziv")) Then _sema_naziv = DR.Item("naziv")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub upisi_prn_finansijsko(ByVal _datumOD As Date, ByVal _datumDO As Date, _
                    ByVal _vrsta As String, ByVal _broj As String, ByVal _datum As Date, _
                    ByVal _duguje As Single, ByVal _potrazuje As Single, ByVal _saldo As Single, _
                    ByVal _proknjizen As Boolean, ByVal _storniran As Boolean, _
                    ByVal _rb As String, ByVal _opis_sifra As String, ByVal _opis As String, _
                    ByVal _klasa_konta As String, ByVal _grupa_konta As String, _
                    ByVal _konto As String, ByVal _analitika As String, ByVal _analitika_naziv As String, _
                    ByVal _stavka_duguje As Single, ByVal _stavka_potrazuje As Single, ByVal _stavka_saldo As Single, _
                    ByVal _poc_st_dug As Single, ByVal _poc_st_pot As Single, ByVal _poc_st_saldo As Single, _
                    ByVal _donos_duguje As Single, ByVal _donos_potrazuje As Single, ByVal _donos_datumDO As Date, _
                    ByVal _promet_duguje As Single, ByVal _promet_potrazuje As Single, ByVal _promet_saldo As Single, _
                    ByVal _dok_br As String, ByVal _dok_dat As String)

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        CM = New SqlCommand()
        With CM
            .Connection = CN
            .CommandType = CommandType.StoredProcedure
            .CommandText = "prn_Finansijsko_add"

            .Parameters.AddWithValue("@datum_od", _datumOD)
            .Parameters.AddWithValue("@datum_do", _datumDO)
            .Parameters.AddWithValue("@nal_vrsta", _vrsta)
            .Parameters.AddWithValue("@nal_broj", _broj)
            .Parameters.AddWithValue("@nal_datum", _datum)
            .Parameters.AddWithValue("@nal_duguje", _duguje)
            .Parameters.AddWithValue("@nal_potrazuje", _potrazuje)
            .Parameters.AddWithValue("@nal_proknjizen", _proknjizen)
            .Parameters.AddWithValue("@nal_storniran", _storniran)
            .Parameters.AddWithValue("@nal_napomena", "")
            .Parameters.AddWithValue("@stavka_rb", _rb)
            .Parameters.AddWithValue("@stavka_opis_sifra", _opis_sifra)
            .Parameters.AddWithValue("@stavka_opis", _opis)
            .Parameters.AddWithValue("@klasa_konta", _klasa_konta)
            .Parameters.AddWithValue("@grupa_konta", _grupa_konta)
            .Parameters.AddWithValue("@stavka_konto", _konto)
            .Parameters.AddWithValue("@stavka_analitika", _analitika)
            .Parameters.AddWithValue("@stavka_analitika_naziv", _analitika_naziv)
            .Parameters.AddWithValue("@stavka_duguje", _stavka_duguje)
            .Parameters.AddWithValue("@stavka_potrazuje", _stavka_potrazuje)
            .Parameters.AddWithValue("@stavka_saldo", _stavka_saldo)
            .Parameters.AddWithValue("@poc_st_dug", _poc_st_dug)
            .Parameters.AddWithValue("@poc_st_pot", _poc_st_pot)
            .Parameters.AddWithValue("@poc_st_saldo", _poc_st_saldo)
            .Parameters.AddWithValue("@donos_duguje", _donos_duguje)
            .Parameters.AddWithValue("@donos_potrazuje", _donos_potrazuje)
            .Parameters.AddWithValue("@donos_datumDO", _donos_datumDO)
            .Parameters.AddWithValue("@promet_duguje", _promet_duguje)
            .Parameters.AddWithValue("@promet_potrazuje", _promet_potrazuje)
            .Parameters.AddWithValue("@promet_saldo", _promet_saldo)
            .Parameters.AddWithValue("@stavka_brDok", _dok_br)
            .Parameters.AddWithValue("@stavka_datDok", _dok_dat)
            .Parameters.AddWithValue("@stavka_valuta", Today)

            .ExecuteScalar()
        End With
        CM.Dispose()
        CN.Close()
    End Sub

    Public Function ima_promet(ByVal _sql As String) As Boolean
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        ima_promet = False
        CN.Open()
        CM = New SqlCommand()
        With CM
            .Connection = CN
            .CommandType = CommandType.Text
            .CommandText = _sql
            DR = .ExecuteReader
        End With
        If DR.HasRows Then ima_promet = True
        DR.Close()
        CM.Dispose()
        CN.Close()
    End Function

    Public Sub selektuj_osn_sred(ByVal _upit As String, ByVal _selekcija As Integer)
        Dim _sql As String = "select * from dbo.fn_otvorene_stavke where dbo.fn_otvorene_stavke."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_os = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "analitika = N'" & _upit & "'"
            Case Selekcija.po_sifri
                _sql += "konto = N'" & _upit & "'"
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

            _id_os = 0
            _os_red_broj = 0
            _os_konto = ""
            _os_analitika = ""
            _os_id_dug = 0
            _os_id_pot = 0
            _os_saldo = 0

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_os")) Then _id_os = DR.Item("id_os")
                If Not IsDBNull(DR.Item("red_broj")) Then _os_red_broj = RTrim(DR.Item("red_broj"))
                If Not IsDBNull(DR.Item("konto")) Then _os_konto = RTrim(DR.Item("konto"))
                If Not IsDBNull(DR.Item("analitika")) Then _os_analitika = RTrim(DR.Item("analitika"))
                If Not IsDBNull(DR.Item("id_dug")) Then _os_id_dug = DR.Item("id_dug")
                If Not IsDBNull(DR.Item("id_pot")) Then _os_id_pot = DR.Item("id_pot")
                If Not IsDBNull(DR.Item("saldo")) Then _os_saldo = DR.Item("saldo")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

End Module
