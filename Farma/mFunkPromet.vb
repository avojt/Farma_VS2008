Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Module mFunkPromet

    Public Sub prebaci_u_magacin_promene(ByVal id, ByVal vrsta, ByVal broj)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()

        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from rm_dnevni_promet_head where id_magacin = " & id & _
                                " and id_vrsta_dok = " & vrsta & " and dp_broj_dok = '" & broj & "'"
                DR = .ExecuteReader
            End With

            _id_dnevni_promet = 0
            _dp_datum_promene = Today
            _dp_datum_vreme_promene = Today
            _dp_id_magacin = 0
            _dp_id_oj = 0
            _dp_id_partnera = 0
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
                If Not IsDBNull(DR.Item("id_oj")) Then _dp_id_oj = DR.Item("id_oj")
                If Not IsDBNull(DR.Item("id_partner")) Then _dp_id_partnera = DR.Item("id_partner")
                If Not IsDBNull(DR.Item("dp_rb")) Then _dp_rb = DR.Item("dp_rb")
                If Not IsDBNull(DR.Item("id_vrsta_dok")) Then _id_vrsta_dok = DR.Item("id_vrsta_dok")
                If Not IsDBNull(DR.Item("id_dokumenta")) Then _dp_id_dokumenta = DR.Item("id_dokumenta")
                If Not IsDBNull(DR.Item("dp_broj_dok")) Then _dp_broj_dok = DR.Item("dp_broj_dok")
                If Not IsDBNull(DR.Item("dp_ukupno_ulaz")) Then _dp_ukupno_ulaz = DR.Item("dp_ukupno_ulaz")
                If Not IsDBNull(DR.Item("dp_ukupno_izlaz")) Then _dp_ukupno_izlaz = DR.Item("dp_ukupno_izlaz")
                If Not IsDBNull(DR.Item("dp_ukupno_stanje")) Then _dp_ukupno_stanje = DR.Item("dp_ukupno_stanje")
                If Not IsDBNull(DR.Item("dp_novo_stanje")) Then _dp_novo_stanje = DR.Item("dp_novo_stanje")
                If Not IsDBNull(DR.Item("dp_zakljucen")) Then _dp_zakljucen = DR.Item("dp_zakljucen")

                magacin_promena(_dp_datum_promene, _id_magacin, _dp_id_oj, _dp_id_partnera, _id_vrsta_dok, _
                    _dp_id_dokumenta, RTrim(_dp_broj_dok), _dp_ukupno_ulaz, _dp_ukupno_izlaz, _dp_ukupno_stanje, _dp_novo_stanje)

                zakljucaj_dnevni_promet(_id_dnevni_promet)
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub prebaci_u_magacin_promene_stavka(ByVal id)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()

        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from rm_dnevni_promet_stavka where id_dnevni_promet = " & id
                DR = .ExecuteReader
            End With

            _id_dp_stavka = 0
            '_id_dnevni_promet = 0
            _dp_id_artikl = 0
            _dp_art_ulaz = 0
            _dp_art_izlaz = 0
            _dp_art_stanje = 0
            _dp_art_cena = 0
            _dp_art_pdv = 0
            _dp_suma_ulaz = 0
            _dp_suma_izlaz = 0
            _dp_suma_stanje = 0
            _dp_novo_stanje_stavka = False

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_dp_stavka")) Then _id_dp_stavka = DR.Item("id_dp_stavka")
                If Not IsDBNull(DR.Item("id_dnevni_promet")) Then _id_dnevni_promet = DR.Item("id_dnevni_promet")
                If Not IsDBNull(DR.Item("id_magacin")) Then _id_magacin = DR.Item("id_magacin")
                If Not IsDBNull(DR.Item("id_artikl")) Then _dp_id_artikl = DR.Item("id_artikl")
                If Not IsDBNull(DR.Item("dp_art_ulaz")) Then _dp_art_ulaz = DR.Item("dp_art_ulaz")
                If Not IsDBNull(DR.Item("dp_art_izlaz")) Then _dp_art_izlaz = DR.Item("dp_art_izlaz")
                If Not IsDBNull(DR.Item("dp_art_stanje")) Then _dp_art_stanje = DR.Item("dp_art_stanje")
                If Not IsDBNull(DR.Item("dp_art_cena")) Then _dp_art_cena = DR.Item("dp_art_cena")
                If Not IsDBNull(DR.Item("dp_art_pdv")) Then _dp_art_pdv = DR.Item("dp_art_pdv")
                If Not IsDBNull(DR.Item("dp_suma_ulaz")) Then _dp_suma_ulaz = DR.Item("dp_suma_ulaz")
                If Not IsDBNull(DR.Item("dp_suma_izlaz")) Then _dp_suma_izlaz = DR.Item("dp_suma_izlaz")
                If Not IsDBNull(DR.Item("dp_suma_stanje")) Then _dp_suma_stanje = DR.Item("dp_suma_stanje")
                If Not IsDBNull(DR.Item("dp_novo_stanje")) Then _dp_novo_stanje_stavka = DR.Item("dp_novo_stanje")

                magacin_promena_stavka(_id_magacin, _dp_id_artikl, _dp_art_ulaz, _dp_art_izlaz, _
                         _dp_art_cena, _dp_art_pdv, _dp_suma_ulaz, _dp_suma_izlaz, _dp_suma_stanje)

                'brisi_dnevni_promet()
                'zakljucaj_dnevni_promet()
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub brisi_dnevni_promet(ByVal id)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_dnevni_promet_delete"
                    .Parameters.AddWithValue("@id_dnevni_promet", id)
                    .ExecuteScalar()
                End With
            End If
            CM.Dispose()
        End If
    End Sub

    Public Sub zakljucaj_dnevni_promet(ByVal id)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_dnevni_promet_head_zakljucaj"
                    .Parameters.AddWithValue("@id_dnevni_promet", id)
                    .ExecuteScalar()
                End With
            End If
            CM.Dispose()
        End If
    End Sub

    Public Sub magacin_promena(ByVal dp_datum_promene, ByVal id_magacin, ByVal id_oj, ByVal id_partner, ByVal id_vrsta_dok, _
    ByVal id_dokumenta, ByVal br_dok, ByVal dp_ukupno_ulaz, ByVal dp_ukupno_izlaz, _
    ByVal dp_ukupno_stanje, ByVal dp_novo_stanje)

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        'Dim i As Integer

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_magacin_promene_add"
                .Parameters.AddWithValue("@mag_datum_promene", dp_datum_promene)
                .Parameters.AddWithValue("@id_magacin", id_magacin)
                .Parameters.AddWithValue("@id_oj", id_oj)
                .Parameters.AddWithValue("@id_partner", id_partner)
                .Parameters.AddWithValue("@mag_rb", Nadji_rb(Imena.tabele.rm_magacin_promene.ToString, 3))
                .Parameters.AddWithValue("@id_vrsta_dok", id_vrsta_dok)
                .Parameters.AddWithValue("@id_dokumenta", id_dokumenta)
                .Parameters.AddWithValue("@mag_broj_dok", br_dok)
                .Parameters.AddWithValue("@mag_ukupno_ulaz", dp_ukupno_ulaz)
                .Parameters.AddWithValue("@mag_ukupno_izlaz", dp_ukupno_izlaz)
                Dim stanje As Single = stanje_iz_magacina(id_magacin)
                .Parameters.AddWithValue("@mag_ukupno_stanje", stanje + dp_ukupno_ulaz - dp_ukupno_izlaz)
                .Parameters.AddWithValue("@mag_novo_stanje", dp_novo_stanje)
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If
        CN.Close()
    End Sub

    Public Sub magacin_promena_stavka(ByVal id_magacin, ByVal dp_id_artikl, ByVal dp_art_ulaz, ByVal dp_art_izlaz, _
    ByVal dp_art_cena, ByVal dp_art_pdv, ByVal dp_ukupno_ulaz, ByVal dp_ukupno_izlaz, ByVal dp_art_stanje)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        'Dim i As Integer

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_magacin_promene_stavka_add"
                .Parameters.AddWithValue("@id_promene", Nadji_id("rm_magacin_promene"))
                .Parameters.AddWithValue("@id_magacin", id_magacin)
                .Parameters.AddWithValue("@id_artikl", dp_id_artikl)
                .Parameters.AddWithValue("@mag_art_ulaz", dp_art_ulaz)
                .Parameters.AddWithValue("@mag_art_izlaz", dp_art_izlaz)
                Dim stanje As Single = magacin_zadnje_stanje(dp_id_artikl, id_magacin)
                .Parameters.AddWithValue("@mag_art_stanje", stanje + dp_art_ulaz - dp_art_izlaz)
                .Parameters.AddWithValue("@mag_art_cena", dp_art_cena)
                .Parameters.AddWithValue("@mag_art_pdv", dp_art_pdv)
                .Parameters.AddWithValue("@mag_suma_ulaz", dp_ukupno_ulaz)
                .Parameters.AddWithValue("@mag_suma_izlaz", dp_ukupno_izlaz)
                .Parameters.AddWithValue("@mag_suma_stanje", dp_art_cena * (stanje + dp_art_ulaz - dp_art_izlaz))
                .Parameters.AddWithValue("@mag_stanje", 0)
                .Parameters.AddWithValue("@mag_zadnjapromena", Now)

                .ExecuteScalar()
            End With
            CM.Dispose()
        End If
        CN.Close()
    End Sub

    Public Function magacin_zadnje_stanje(ByVal id_artikl, ByVal id_magacin) As Single
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        magacin_zadnje_stanje = 0
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from rm_magacin_promene_stavka where id_artikl = " & id_artikl & _
                               " and id_magacin = " & id_magacin
                DR = .ExecuteReader
            End With

            Do While DR.Read
                If Not IsDBNull(DR.Item("mag_art_stanje")) Then magacin_zadnje_stanje = DR.Item("mag_art_stanje")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Function


    Public Sub obrisi_trenutni_DP(ByVal IDmagacin As Integer, ByVal broj As Integer, ByVal IDvrsta As Integer)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        CN.Open()
        If CN.State = ConnectionState.Open Then
            'nalazi zaglavlje
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from rm_dnevni_promet_head where id_magacin = " & IDmagacin & _
                               " and dp_broj_dok = N'" & broj & "' and id_vrsta_dok = " & IDvrsta
                DR = .ExecuteReader()
            End With
            While DR.Read
                If Not IsDBNull(DR.Item("id_dnevni_promet")) Then _id_dnevni_promet = DR.Item("id_dnevni_promet")
                If Not IsDBNull(DR.Item("dp_rb")) Then _dp_rb = DR.Item("dp_rb")
                If Not IsDBNull(DR.Item("dp_novo_stanje")) Then _dp_novo_stanje = DR.Item("dp_novo_stanje")
                If Not IsDBNull(DR.Item("dp_ukupno_ulaz")) Then _dp_ukupno_ulaz = DR.Item("dp_ukupno_ulaz")
            End While
            DR.Close()
            CM.Dispose()

            'brise stavku
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from rm_dnevni_promet_stavka where id_dnevni_promet = " & _id_dnevni_promet
                DR = .ExecuteReader()
            End With
            CM.Dispose()

            Dim i As Integer
            Dim id() As Integer

            id = New Integer() {}
            ReDim id(500)

            While DR.Read
                If Not IsDBNull(DR.Item("id_dp_stavka")) Then id.SetValue(DR.Item("id_dp_stavka"), i)
                i += 1
            End While
            DR.Close()

            Dim j As Integer = 0
            For j = 0 To i - 1
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_dnevni_promet_stavka_delete"
                    .Parameters.AddWithValue("@id_dp_stavka", id(j))
                    .ExecuteScalar()
                End With
                CM.Dispose()
            Next
            '************

            'brise head
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_dnevni_promet_head_delete"
                .Parameters.AddWithValue("@id_dnevni_promet", _id_dnevni_promet)
                .ExecuteScalar()
            End With
            CM.Dispose()
            '**************
        End If
        CN.Close()
    End Sub

    Public Sub unesi_dnevni_promet_head(ByVal datum As Date, ByVal vreme As Date, _
            ByVal IDmagacin As Integer, ByVal IDoj As Integer, ByVal IDpartner As Integer, _
            ByVal IDvrsta As Integer, ByVal IDdok As Integer, ByVal broj As Integer, _
            ByVal ulaz As Single, ByVal izlaz As Single, ByVal novo As Boolean, _
            ByVal zakljucen As Boolean, ByVal vrsta_prom As String)

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure

                Dim stanje As Single = zadnje_stanje(IDmagacin)

                Select Case vrsta_prom
                    Case vrsta_promene.unos
                        .CommandText = "rm_dnevni_promet_head_add"
                        .Parameters.AddWithValue("@dp_datum_promene", datum)
                        .Parameters.AddWithValue("@dp_datum_vreme_promene", vreme)
                        .Parameters.AddWithValue("@dp_rb", Nadji_rb(Imena.tabele.rm_dnevni_promet_head.ToString, 4))
                        .Parameters.AddWithValue("@id_vrsta_dok", IDvrsta)
                        .Parameters.AddWithValue("@id_dokumenta", IDdok)
                        .Parameters.AddWithValue("@dp_novo_stanje", novo)
                        .Parameters.AddWithValue("@dp_zakljucen", zakljucen)
                    Case vrsta_promene.editovanje
                        .CommandText = "rm_dnevni_promet_head_update"
                        nadji_DPromet(IDmagacin, IDvrsta, IDdok, broj)
                        'ulaz = ulaz_za_edit
                        'izlaz = izlaz_za_edit
                        stanje = stanje_za_edit - ulaz_za_edit + izlaz_za_edit
                        .Parameters.AddWithValue("@id_dnevni_promet", _id_dnevni_promet) 'ovog treba da nadje
                End Select

                .Parameters.AddWithValue("@id_magacin", IDmagacin)
                .Parameters.AddWithValue("@id_oj", IDoj)
                .Parameters.AddWithValue("@id_partner", IDpartner)
                .Parameters.AddWithValue("@dp_broj_dok", broj)
                .Parameters.AddWithValue("@dp_ukupno_ulaz", ulaz)
                .Parameters.AddWithValue("@dp_ukupno_izlaz", izlaz)
                .Parameters.AddWithValue("@dp_ukupno_stanje", stanje + ulaz - izlaz)
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If
        CN.Close()

        novo_stanje_u_DP(IDmagacin)
    End Sub

    Public Function zadnje_stanje(ByVal IDmagacin As Integer) As Single
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        zadnje_stanje = 0
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from rm_dnevni_promet_head where id_magacin = " & IDmagacin & _
                                " and dp_novo_stanje = 1"
                DR = .ExecuteReader
            End With

            Do While DR.Read
                If Not IsDBNull(DR.Item("dp_ukupno_stanje")) Then zadnje_stanje = DR.Item("dp_ukupno_stanje")
                id_predhodnog_stanja = DR.Item("id_dnevni_promet")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Public Sub novo_stanje_u_DP(ByVal IDmagacin As Integer)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim i As Integer = 0

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from rm_dnevni_promet_head where id_magacin = " & IDmagacin & _
                               " ORDER BY dp_rb"
                DR = .ExecuteReader()
            End With

            Dim id() As Integer
            Dim ulaz As Single = 0
            Dim izlaz As Single = 0
            Dim stanje() As Single

            id = New Integer() {}
            ReDim id(500)

            stanje = New Single() {}
            ReDim stanje(500)

            While DR.Read
                If Not IsDBNull(DR.Item("id_dnevni_promet")) Then id.SetValue(DR.Item("id_dnevni_promet"), i)
                If Not IsDBNull(DR.Item("dp_ukupno_ulaz")) Then ulaz = DR.Item("dp_ukupno_ulaz")
                If Not IsDBNull(DR.Item("dp_ukupno_izlaz")) Then izlaz = DR.Item("dp_ukupno_izlaz")
                If i = 0 Then
                    stanje.SetValue(stanje_iz_magacina(DR.Item("id_magacin")) + ulaz - izlaz, i)
                Else
                    stanje.SetValue(stanje(i - 1) + ulaz - izlaz, i)
                End If
                'If Not IsDBNull(DR.Item("dp_ukupno_stanje")) Then stanje = DR.Item("dp_ukupno_stanje")
                i += 1
            End While
            DR.Close()
            CM.Dispose()

            Dim j As Integer = 0
            For j = 0 To i - 1
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_dnevni_promet_head_novo_stanje"
                    .Parameters.AddWithValue("@id_dnevni_promet", id(j))
                    .Parameters.AddWithValue("@dp_ukupno_stanje", stanje(j))
                    .ExecuteScalar()
                End With
                CM.Dispose()
            Next
        End If

    End Sub

    Public Function stanje_iz_magacina(ByVal IDmagacin As Integer) As Single
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        stanje_iz_magacina = 0

        CN.Open()
        CM = New SqlCommand()
        With CM
            .Connection = CN
            .CommandType = CommandType.Text
            .CommandText = "select * from rm_magacin_promene_stavka where id_magacin = " & IDmagacin
            DR = .ExecuteReader()
        End With

        'Dim id As Integer = 0
        'Dim ulaz As Single = 0
        'Dim stanje As Single = 0
        While DR.Read
            If Not IsDBNull(DR.Item("mag_suma_stanje")) Then stanje_iz_magacina = DR.Item("mag_suma_stanje")
        End While
        DR.Close()
        CM.Dispose()
        CN.Close()
    End Function

    Private ulaz_za_edit As Single
    Private izlaz_za_edit As Single
    Private stanje_za_edit As Single

    Public Sub nadji_DPromet(ByVal IDmagacin As Integer, ByVal IDvrsta As Integer, ByVal IDdok As String, ByVal broj As Integer)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_dnevni_promet_head.* from dbo.rm_dnevni_promet_head " & _
                            "where dbo.rm_dnevni_promet_head.id_magacin	 = " & IDmagacin & _
                            " and dbo.rm_dnevni_promet_head.id_vrsta_dok = " & IDvrsta & _
                            " and dbo.rm_dnevni_promet_head.id_dokumenta = " & IDdok & _
                            " and dbo.rm_dnevni_promet_head.dp_broj_dok = " & broj
                DR = .ExecuteReader
            End With

            _id_dnevni_promet = 0

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_dnevni_promet")) Then _id_dnevni_promet = DR.Item("id_dnevni_promet")
                If Not IsDBNull(DR.Item("dp_ukupno_ulaz")) Then ulaz_za_edit = DR.Item("dp_ukupno_ulaz")
                If Not IsDBNull(DR.Item("dp_ukupno_izlaz")) Then izlaz_za_edit = DR.Item("dp_ukupno_izlaz")
                If Not IsDBNull(DR.Item("dp_ukupno_stanje")) Then stanje_za_edit = DR.Item("dp_ukupno_stanje")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Public Sub brisi_DPromet(ByVal IDmagacin As Integer, ByVal IDvrsta As Integer, ByVal IDdok As String, ByVal broj As Integer)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_dnevni_promet_head.* from dbo.rm_dnevni_promet_head " & _
                            "where dbo.rm_dnevni_promet_head.id_magacin	 = " & IDmagacin & _
                            " and dbo.rm_dnevni_promet_head.id_vrsta_dok = " & IDvrsta & _
                            " and dbo.rm_dnevni_promet_head.id_dokumenta = " & IDdok & _
                            " and dbo.rm_dnevni_promet_head.dp_broj_dok = " & broj
                DR = .ExecuteReader
            End With

            _id_dnevni_promet = 0

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_dnevni_promet")) Then _id_dnevni_promet = DR.Item("id_dnevni_promet")
            Loop
            DR.Close()
            CM.Dispose()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_dnevni_promet_head_delete"
                .Parameters.AddWithValue("@id_dnevni_promet", _id_dnevni_promet)
                .ExecuteScalar()
            End With
            CM.Dispose()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_dnevni_promet_head_delete"
                .Parameters.AddWithValue("@id_dnevni_promet", _id_dnevni_promet + 1)
                .ExecuteScalar()
            End With
            CM.Dispose()

        End If
        CM.Dispose()
        CN.Close()

        brisi_DPromet_stavka(_id_dnevni_promet)
    End Sub

    Public Sub unesi_dnevni_promet_stavka(ByVal IDDP As Integer, ByVal IDmagacin As Integer, ByVal IDartikl As Integer, _
        ByVal ulaz As Single, ByVal izlaz As Single, ByVal cena As Single, _
        ByVal pdv As Single, ByVal novo As Boolean, ByVal _nivelacija As Boolean) ', ByVal vrsta_prom As String)

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        '_id_dnevni_promet = Nadji_id(Imena.tabele.rm_dnevni_promet_head.ToString)

        CN.Open()

        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_dnevni_promet_stavka_add"

                .Parameters.AddWithValue("@id_dnevni_promet", IDDP)
                .Parameters.AddWithValue("@id_magacin", IDmagacin)
                .Parameters.AddWithValue("@id_artikl", IDartikl)
                Dim stanje As Single = zadnje_stanje_stavka(IDDP, IDmagacin, IDartikl)
                If _nivelacija Then
                    .Parameters.AddWithValue("@dp_art_ulaz", 0)
                    .Parameters.AddWithValue("@dp_art_izlaz", 0)
                    .Parameters.AddWithValue("@dp_art_stanje", stanje)
                    .Parameters.AddWithValue("@dp_art_cena", 0)
                    .Parameters.AddWithValue("@dp_art_pdv", 0)
                Else
                    .Parameters.AddWithValue("@dp_art_ulaz", ulaz)
                    .Parameters.AddWithValue("@dp_art_izlaz", izlaz)
                    .Parameters.AddWithValue("@dp_art_stanje", stanje + ulaz - izlaz)
                    .Parameters.AddWithValue("@dp_art_cena", cena)
                    .Parameters.AddWithValue("@dp_art_pdv", pdv)
                End If
                .Parameters.AddWithValue("@dp_suma_ulaz", cena * ulaz)
                .Parameters.AddWithValue("@dp_suma_izlaz", cena * izlaz)
                Dim suma_stanje As Single = zadnje_suma_stanje_stavka(IDmagacin, IDartikl)
                .Parameters.AddWithValue("@dp_suma_stanje", suma_stanje + (cena * (ulaz - izlaz)))
                .Parameters.AddWithValue("@dp_novo_stanje", novo)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        novo_stanje_u_DP_stavke(IDmagacin, IDartikl)

        CN.Close()
    End Sub

    Public Sub promeni_dnevni_promet_stavka(ByVal IDDP As Integer, ByVal IDmagacin As Integer, ByVal IDartikl As Integer, _
    ByVal ulaz As Single, ByVal izlaz As Single, ByVal cena As Single, _
    ByVal pdv As Single, ByVal novo As Boolean, ByVal _nivelacija As Boolean)

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand


        CN.Open()

        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                If _id_dp_stavka = 0 Then
                    unesi_dnevni_promet_stavka(IDDP, IDmagacin, IDartikl, _
                                ulaz, izlaz, cena, pdv, novo, _nivelacija)
                Else
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_dnevni_promet_stavka_update"
                    nadji_DPromet_stavka(IDDP, IDartikl)

                    .Parameters.AddWithValue("@id_dp_stavka", _id_dp_stavka)

                    Dim stanje As Single = zadnje_stanje_stavka(IDDP, IDmagacin, IDartikl)
                    If _nivelacija Then
                        .Parameters.AddWithValue("@dp_art_ulaz", 0)
                        .Parameters.AddWithValue("@dp_art_izlaz", 0)
                        .Parameters.AddWithValue("@dp_art_stanje", stanje)
                        .Parameters.AddWithValue("@dp_art_cena", 0)
                        .Parameters.AddWithValue("@dp_art_pdv", 0)
                    Else
                        .Parameters.AddWithValue("@dp_art_ulaz", ulaz)
                        .Parameters.AddWithValue("@dp_art_izlaz", izlaz)
                        .Parameters.AddWithValue("@dp_art_stanje", stanje + ulaz - izlaz)
                        .Parameters.AddWithValue("@dp_art_cena", cena)
                        .Parameters.AddWithValue("@dp_art_pdv", pdv)
                    End If
                    .Parameters.AddWithValue("@dp_suma_ulaz", cena * ulaz)
                    .Parameters.AddWithValue("@dp_suma_izlaz", cena * izlaz)
                    Dim suma_stanje As Single = zadnje_suma_stanje_stavka(IDmagacin, IDartikl)
                    .Parameters.AddWithValue("@dp_suma_stanje", suma_stanje + (cena * (ulaz - izlaz)))
                    .ExecuteScalar()
                End If
            End With
        End If
        CM.Dispose()
        novo_stanje_u_DP_stavke(IDmagacin, IDartikl)

        CN.Close()
    End Sub

    Public Function zadnje_stanje_stavka(ByVal IDDP As Integer, ByVal IDmagacin As Integer, ByVal IDartikl As Integer) As Single
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        zadnje_stanje_stavka = 0
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from rm_dnevni_promet_stavka where id_magacin = " & IDmagacin & _
                                " and id_artikl = " & IDartikl & " and dp_novo_stanje = 1"
                DR = .ExecuteReader
            End With

            Do While DR.Read
                If DR.Item("id_dnevni_promet") = IDDP Then Exit Do
                If Not IsDBNull(DR.Item("dp_art_stanje")) Then zadnje_stanje_stavka = DR.Item("dp_art_stanje")
                'id_predhodnog_stanja_stavka = DR.Item("id_dp_stavka")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Public Function zadnje_suma_stanje_stavka(ByVal IDmagacin As Integer, ByVal IDartikl As Integer) As Single
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        zadnje_suma_stanje_stavka = 0
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from rm_dnevni_promet_stavka where id_magacin = " & IDmagacin & _
                                " and id_artikl = " & IDartikl & " and dp_novo_stanje = 1"
                DR = .ExecuteReader
            End With

            Do While DR.Read
                If Not IsDBNull(DR.Item("dp_suma_stanje")) Then zadnje_suma_stanje_stavka = DR.Item("dp_suma_stanje")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Public Sub novo_stanje_u_DP_stavke(ByVal IDmagacin As Integer, ByVal IDartikl As Integer)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim i As Integer = 0

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from rm_dnevni_promet_stavka where id_magacin = " & IDmagacin & _
                               " and id_artikl = " & IDartikl '& " ORDER BY id_dp_stavka"
                DR = .ExecuteReader()
            End With

            Dim id() As Integer
            Dim cena As Single = 0
            Dim ulaz As Single = 0
            Dim izlaz As Single = 0
            Dim suma_ulaz As Single = 0
            Dim suma_izlaz As Single = 0
            Dim stanje() As Single
            Dim suma() As Single

            id = New Integer() {}
            ReDim id(500)

            stanje = New Single() {}
            ReDim stanje(500)

            suma = New Single() {}
            ReDim suma(500)
            i = 0
            While DR.Read
                If Not IsDBNull(DR.Item("id_dp_stavka")) Then id.SetValue(DR.Item("id_dp_stavka"), i)
                If Not IsDBNull(DR.Item("dp_art_ulaz")) Then ulaz = DR.Item("dp_art_ulaz")
                If Not IsDBNull(DR.Item("dp_art_izlaz")) Then izlaz = DR.Item("dp_art_izlaz")
                If Not IsDBNull(DR.Item("dp_art_cena")) Then cena = DR.Item("dp_art_cena")
                If Not IsDBNull(DR.Item("dp_suma_ulaz")) Then suma_ulaz = DR.Item("dp_suma_ulaz")
                If Not IsDBNull(DR.Item("dp_suma_izlaz")) Then suma_izlaz = DR.Item("dp_suma_izlaz")
                If Not IsDBNull(DR.Item("dp_art_cena")) Then cena = DR.Item("dp_art_cena")
                If i = 0 Then
                    stanje.SetValue(stanje_iz_magacina_stavka(DR.Item("id_magacin"), DR.Item("id_artikl")) + ulaz, i)
                    suma.SetValue(stanje_iz_magacina_stavka(DR.Item("id_magacin"), DR.Item("id_artikl")) + suma_ulaz, i)
                Else
                    stanje.SetValue(stanje(i - 1) + ulaz - izlaz, i)
                    suma.SetValue(suma(i - 1) + suma_ulaz - suma_izlaz, i)
                End If

                i += 1
            End While
            DR.Close()
            CM.Dispose()

            Dim j As Integer = 0
            For j = 0 To i - 1
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_dnevni_promet_stavka_novo_stanje"
                    .Parameters.AddWithValue("@id_dp_stavka", id(j))
                    .Parameters.AddWithValue("@dp_art_stanje", stanje(j))
                    .Parameters.AddWithValue("@dp_suma_stanje", suma(j))
                    .ExecuteScalar()
                End With
                CM.Dispose()
            Next
        End If

    End Sub

    Public Function stanje_iz_magacina_stavka(ByVal IDmagacin As Integer, ByVal IDartikl As Integer) As Single
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        stanje_iz_magacina_stavka = 0

        CN.Open()
        CM = New SqlCommand()
        With CM
            .Connection = CN
            .CommandType = CommandType.Text
            .CommandText = "select * from rm_magacin_promene_stavka where id_magacin = " & IDmagacin & _
                            " and id_artikl = " & IDartikl
            DR = .ExecuteReader()
        End With

        Dim id As Integer = 0
        Dim ulaz As Single = 0
        Dim stanje As Single = 0
        While DR.Read
            If Not IsDBNull(DR.Item("mag_art_stanje")) Then stanje_iz_magacina_stavka = DR.Item("mag_art_stanje")
        End While
        DR.Close()
        CM.Dispose()
        CN.Close()
    End Function

    Private Sub nadji_DPromet_stavka(ByVal IDDP As Integer, ByVal IDArtikl As Integer)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()

        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.rm_dnevni_promet_stavka " & _
                            "where dbo.rm_dnevni_promet_stavka.id_dnevni_promet	 = " & IDDP & _
                            " and dbo.rm_dnevni_promet_stavka.id_artikl = " & IDArtikl
                DR = .ExecuteReader
            End With

            _id_dp_stavka = 0

            Do While DR.Read
                'If DR.Item("id_dnevni_promet") = IDDP Then Exit Do
                If Not IsDBNull(DR.Item("id_dp_stavka")) Then _id_dp_stavka = DR.Item("id_dp_stavka")
                If Not IsDBNull(DR.Item("dp_art_stanje")) Then _dp_art_stanje = DR.Item("dp_art_stanje")
            Loop
            DR.Close()
            CM.Dispose()
        End If
        CN.Close()
    End Sub

    Private Sub brisi_DPromet_stavka(ByVal IDDP As Integer)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()

        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_dnevni_promet_stavka_del_DP"
                .Parameters.AddWithValue("@id_dnevni_promet", _id_dnevni_promet)
                .ExecuteScalar()
            End With
            CM.Dispose()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_dnevni_promet_stavka_del_DP"
                .Parameters.AddWithValue("@id_dnevni_promet", _id_dnevni_promet + 1)
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If
        CN.Close()
    End Sub


#Region "automatska nivelacija"

    'Public Sub nivelacija_snimi_head(ByVal IDmagacin As Integer, ByVal IDvrsta As Integer, _
    '      ByVal IDdok As String, ByVal broj As Integer, ByVal datum As Date, _
    '      ByVal nova_vred As Single, ByVal stara_vred As Single, _
    '      ByVal razlika As Single, ByVal stari_iznos_pdv As Single, ByVal novi_iznos_pdv As Single, _
    '      ByVal razlika_pdv As Single)

    '    Dim CN As SqlConnection = New SqlConnection(CNNString)
    '    Dim CM As New SqlCommand

    '    CN.Open()
    '    CM = New SqlCommand()
    '    If CN.State = ConnectionState.Open Then
    '        With CM
    '            .Connection = CN
    '            .CommandType = CommandType.StoredProcedure
    '            .CommandText = "rm_nivelacije_head_add"
    '            .Parameters.AddWithValue("@id_magacin", IDmagacin)
    '            .Parameters.AddWithValue("@broj", Nadji_rb(Imena.tabele.rm_nivelacije_head.ToString, 1))
    '            .Parameters.AddWithValue("@datum", datum)
    '            .Parameters.AddWithValue("@stara_vrednost", stara_vred)
    '            .Parameters.AddWithValue("@nova_vrednost", nova_vred)
    '            .Parameters.AddWithValue("@razlika_uceni", razlika)
    '            .Parameters.AddWithValue("@stari_iznos_pdv", stari_iznos_pdv)
    '            .Parameters.AddWithValue("@novi_iznos_pdv", novi_iznos_pdv)
    '            .Parameters.AddWithValue("@razlika_pdv", razlika_pdv)
    '            .Parameters.AddWithValue("@unesena", 0)
    '            .Parameters.AddWithValue("@automatska", 1)
    '            .Parameters.AddWithValue("@vezni_dokument_id", IDdok)
    '            .Parameters.AddWithValue("@vezni_dokument_broj", broj)
    '            .ExecuteScalar()
    '        End With
    '    End If
    '    CM.Dispose()
    '    CN.Close()
    'End Sub

    'Public Sub nivelacija_snimi_pdv()
    '    Dim CN As SqlConnection = New SqlConnection(CNNString)
    '    Dim CM As New SqlCommand
    '    Dim DR As SqlDataReader
    '    Dim _porezi() As Single
    '    Dim i As Integer = 0

    '    CN.Open()
    '    CM = New SqlCommand()

    '    _porezi = New Single() {}

    '    If CN.State = ConnectionState.Open Then
    '        With CM
    '            .Connection = CN
    '            .CommandType = CommandType.Text
    '            .CommandText = "select dbo.app_pdv.* from dbo.app_pdv"
    '            .ExecuteScalar()
    '            DR = .ExecuteReader
    '        End With

    '        _broj_stavki = 0
    '        Do While DR.Read
    '            _broj_stavki += 1
    '        Loop
    '        DR.Close()

    '        ReDim _porezi(_broj_stavki * 3)

    '        DR = CM.ExecuteReader
    '        Do While DR.Read
    '            If Not IsDBNull(DR.Item("pdv_stopa")) Then _porezi.SetValue(CSng(DR.Item("pdv_stopa")), i * 3)
    '            _porezi.SetValue(nivelacija_saberi_osnovice(DR.Item("pdv_stopa")), (i * 3) + 1)
    '            _porezi.SetValue(nivelacija_saberi_pdv(DR.Item("pdv_stopa")), (i * 3) + 2)
    '            i += 1
    '        Loop
    '        DR.Close()
    '    End If
    '    CM.Dispose()

    '    _id_nivelacije = Nadji_id(Imena.tabele.rm_nivelacije_head.ToString)

    '    For i = 0 To (_porezi.Length / 3) - 1
    '        If _porezi((i * 3) + 1) <> 0 Then
    '            CM = New SqlCommand()
    '            If CN.State = ConnectionState.Open Then
    '                With CM
    '                    .Connection = CN
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "rm_nivelacija_pdv_add"
    '                    .Parameters.AddWithValue("@id_nivelacije", _id_nivelacije)
    '                    .Parameters.AddWithValue("@niv_pdv", _porezi(i * 3))
    '                    .Parameters.AddWithValue("@niv_osnovica", _porezi((i * 3) + 1))
    '                    .Parameters.AddWithValue("@niv_iznos", _porezi((i * 3) + 2))
    '                    .ExecuteScalar()
    '                End With
    '            End If
    '            CM.Dispose()
    '        End If
    '    Next
    '    CN.Close()
    'End Sub

    'Public Function nivelacija_saberi_pdv(ByVal _dGrid As DataGridView, ByVal _stopa As Integer) As Single
    '    Dim i As Integer

    '    nivelacija_saberi_pdv = 0
    '    For i = 0 To _dGrid.Rows.Count - 2
    '        If _dGrid.Rows(i).Cells(13).Value = _stopa Then _
    '            nivelacija_saberi_pdv += _dGrid.Rows(i).Cells(5).Value * _dGrid.Rows(i).Cells(8).Value * (_dGrid.Rows(i).Cells(13).Value / 100)
    '    Next
    'End Function

    'Public Function nivelacija_saberi_osnovice(ByVal _dGrid As DataGridView, ByVal _stopa As Integer) As Single
    '    Dim i As Integer

    '    nivelacija_saberi_osnovice = 0
    '    For i = 0 To _dGrid.Rows.Count - 2
    '        If _dGrid.Rows(i).Cells(13).Value = _stopa Then _
    '            nivelacija_saberi_osnovice += _dGrid.Rows(i).Cells(5).Value * _dGrid.Rows(i).Cells(8).Value / (1 + (_dGrid.Rows(i).Cells(13).Value / 100))
    '    Next
    'End Function

    'Public Sub nivelacija_snimi_stavku(ByVal _dGrid As DataGridView)
    '    Dim CN As SqlConnection = New SqlConnection(CNNString)
    '    Dim CM As New SqlCommand
    '    Dim i As Integer

    '    _id_nivelacije = Nadji_id(Imena.tabele.rm_nivelacije_head.ToString)

    '    CN.Open()
    '    For i = 0 To _dGrid.Rows.Count - 2
    '        CM = New SqlCommand()
    '        If CN.State = ConnectionState.Open Then
    '            With CM
    '                .Connection = CN
    '                .CommandType = CommandType.StoredProcedure
    '                .CommandText = "rm_nivelacije_stavka_add"
    '                .Parameters.AddWithValue("@id_nivelacija", _id_nivelacije) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
    '                .Parameters.AddWithValue("@rb", _dGrid.Rows(i).Cells(0).Value)
    '                selektuj_artikl(_dGrid.Rows(i).Cells(1).Value, Selekcija.po_sifri)
    '                .Parameters.AddWithValue("@id_artikl", _id_artikl)
    '                .Parameters.AddWithValue("@roba_sifra", _dGrid.Rows(i).Cells(1).Value)
    '                .Parameters.AddWithValue("@roba_naziv", _dGrid.Rows(i).Cells(2).Value)
    '                .Parameters.AddWithValue("@kolicina", _dGrid.Rows(i).Cells(5).Value)
    '                .Parameters.AddWithValue("@stara_cena", CSng(_dGrid.Rows(i).Cells(6).Value))
    '                .Parameters.AddWithValue("@stara_vrednost", CSng(_dGrid.Rows(i).Cells(7).Value))
    '                .Parameters.AddWithValue("@nova_cena", CSng(_dGrid.Rows(i).Cells(8).Value))
    '                .Parameters.AddWithValue("@nova_vrednost", CSng(_dGrid.Rows(i).Cells(9).Value))
    '                .Parameters.AddWithValue("@razlika_cena", CSng(_dGrid.Rows(i).Cells(10).Value))
    '                .Parameters.AddWithValue("@stari_pdv", CSng(_dGrid.Rows(i).Cells(11).Value))
    '                .Parameters.AddWithValue("@stari_iznos_pdv", _dGrid.Rows(i).Cells(12).Value)
    '                .Parameters.AddWithValue("@novi_pdv", CSng(_dGrid.Rows(i).Cells(13).Value))
    '                .Parameters.AddWithValue("@novi_iznos_pdv", CSng(_dGrid.Rows(i).Cells(14).Value))
    '                .Parameters.AddWithValue("@razlika_pdv", CSng(_dGrid.Rows(i).Cells(15).Value))
    '                .ExecuteScalar()
    '            End With
    '        End If
    '        CM.Dispose()
    '    Next
    '    CN.Close()
    'End Sub

    'Public Sub nivelacija_snimi_cene(ByVal _dGrid As DataGridView, ByVal IDmagacin As Integer, ByVal marza() As Single, ByVal rabat() As Single)
    '    Dim CN As SqlConnection = New SqlConnection(CNNString)
    '    Dim CM As New SqlCommand
    '    Dim DR As SqlDataReader
    '    Dim i As Integer

    '    For i = 0 To _dGrid.Rows.Count - 2
    '        CN.Open()

    '        selektuj_artikl(_dGrid.Rows(i).Cells(1).Value, Selekcija.po_sifri)

    '        CM = New SqlCommand()
    '        With CM
    '            .Connection = CN
    '            .CommandType = CommandType.Text
    '            .CommandText = "select dbo.rm_artikli_cene.* from dbo.rm_artikli_cene where id_artikl = " & _id_artikl & " and id_magacin = " & IDmagacin
    '            DR = .ExecuteReader
    '        End With
    '        _id_artikl_cena = 0
    '        Do While DR.Read
    '            _id_artikl_cena = DR.Item("id_cena_robe")
    '        Loop
    '        DR.Close()
    '        CM.Dispose()

    '        CM = New SqlCommand()
    '        If CN.State = ConnectionState.Open Then
    '            With CM
    '                .Connection = CN
    '                .CommandType = CommandType.StoredProcedure
    '                Select Case _id_artikl_cena
    '                    Case Is <> 0
    '                        .CommandText = "rm_artikli_cene_update"
    '                        .Parameters.AddWithValue("@id_cena_robe", _id_artikl_cena)
    '                    Case Is = 0
    '                        .CommandText = "rm_artikli_cene_add"
    '                        .Parameters.AddWithValue("@id_artikl", _id_artikl)
    '                        'selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)
    '                        .Parameters.AddWithValue("@id_magacin", IDmagacin)
    '                End Select
    '                .Parameters.AddWithValue("@cena_nab_zadnja", _dGrid.Rows(i).Cells(8).Value)
    '                .Parameters.AddWithValue("@cena_vp1", _dGrid.Rows(i).Cells(8).Value)
    '                .Parameters.AddWithValue("@cena_vp2", 0)
    '                .Parameters.AddWithValue("@cena_vp3", 0)
    '                .Parameters.AddWithValue("@cena_mp", _dGrid.Rows(i).Cells(8).Value * (1 + (_dGrid.Rows(i).Cells(13).Value / 100))) ' mp_cena(i)) '!!!
    '                .Parameters.AddWithValue("@pdv", CSng(_dGrid.Rows(i).Cells(13).Value))
    '                .Parameters.AddWithValue("@rabat", rabat(i)) '!!!
    '                .Parameters.AddWithValue("@marza", marza(i))
    '                .ExecuteScalar()
    '            End With
    '        End If
    '        CM.Dispose()
    '        CN.Close()
    '    Next
    'End Sub
#End Region

    Public Sub unesi_promet_prn(ByVal id_promene, ByVal mag_datum_promene_od, ByVal mag_datum_promene_do, _
                        ByVal mag_datum_promene, ByVal id_magacin, ByVal magacin_naziv, ByVal vrsta_dok_naziv, _
                        ByVal mag_broj_dok, ByVal oj_naziv, ByVal partner_naziv, _
                        ByVal id_artikl, ByVal artikl_sifra, ByVal artikl_naziv, ByVal jkl, _
                        ByVal mag_art_ulaz, ByVal mag_art_izlaz, ByVal mag_art_stanje, _
                        ByVal mag_art_cena, ByVal mag_suma_ulaz, ByVal mag_suma_izlaz, _
                        ByVal mag_suma_stanje, ByVal jm_oznaka, ByVal opis, ByVal vezni, ByVal grupa)

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prn_promet_add"
                .Parameters.AddWithValue("@id_promene", id_promene)
                .Parameters.AddWithValue("@mag_datum_promene_od", mag_datum_promene_od)
                .Parameters.AddWithValue("@mag_datum_promene_do", mag_datum_promene_do)
                .Parameters.AddWithValue("@mag_datum_promene", mag_datum_promene)
                .Parameters.AddWithValue("@id_magacin", id_magacin)
                .Parameters.AddWithValue("@magacin_naziv", magacin_naziv)
                .Parameters.AddWithValue("@vrsta_dok_naziv", vrsta_dok_naziv)
                .Parameters.AddWithValue("@mag_broj_dok", mag_broj_dok)
                .Parameters.AddWithValue("@oj_naziv", oj_naziv)
                .Parameters.AddWithValue("@partner_naziv", partner_naziv)
                .Parameters.AddWithValue("@id_artikl", id_artikl)
                .Parameters.AddWithValue("@artikl_sifra", artikl_sifra)
                .Parameters.AddWithValue("@artikl_naziv", artikl_naziv)
                .Parameters.AddWithValue("@jkl", jkl)
                .Parameters.AddWithValue("@jm_oznaka", jm_oznaka)
                .Parameters.AddWithValue("@mag_art_ulaz", mag_art_ulaz)
                .Parameters.AddWithValue("@mag_art_izlaz", mag_art_izlaz)
                .Parameters.AddWithValue("@mag_art_stanje", mag_art_stanje)
                .Parameters.AddWithValue("@mag_art_cena", mag_art_cena)
                .Parameters.AddWithValue("@mag_suma_ulaz", mag_suma_ulaz)
                .Parameters.AddWithValue("@mag_suma_izlaz", mag_suma_izlaz)
                .Parameters.AddWithValue("@mag_suma_stanje", mag_suma_stanje)
                .Parameters.AddWithValue("@opis", opis)
                .Parameters.AddWithValue("@vezni_dokument", vezni)
                .Parameters.AddWithValue("@art_grupa", grupa)
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If
        CN.Close()
    End Sub

End Module
