Option Strict Off
Option Explicit On
Option Compare Binary

Imports System.Data.SqlClient

Module mFunk_proizvodnja

    Public Sub selektuj_sastavnicu(ByVal _upit As String, ByVal _selekcija As Integer)
        On Error Resume Next
        Dim _sql As String = "select * from dbo.pr_sastavnica_head where dbo.pr_sastavnica_head."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_sastavnica = " & CInt(_upit)
            Case Selekcija.po_nazivu
                _sql += "sas_art_naziv = N'" & RTrim(_upit) & "'"
            Case Selekcija.po_sifri
                _sql += "sas_art_sifra = " & RTrim(_upit)
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

            _id_sastavnica = 0
            _sas_art_sifra = ""
            _sas_art_naziv = ""
            _sas_art_cena = 0
            _sas_jm_recept = ""
            _sas_kolicina = 0
            _sas_odobrena = False
            _sas_datum_unosa = Today
            _sas_datum_prestanka = Today
            _sas_ukupno = 0
            _sas_vrednost = 0
            _sas_radna_taksa = 0

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_sastavnica")) Then _id_sastavnica = RTrim(DR.Item("id_sastavnica"))
                If Not IsDBNull(DR.Item("sas_art_sifra")) Then _sas_art_sifra = RTrim(DR.Item("sas_art_sifra"))
                If Not IsDBNull(DR.Item("sas_art_naziv")) Then _sas_art_naziv = RTrim(DR.Item("sas_art_naziv"))
                If Not IsDBNull(DR.Item("sas_art_cena")) Then _sas_art_cena = RTrim(DR.Item("sas_art_cena"))
                If Not IsDBNull(DR.Item("sas_jm_recept")) Then _sas_jm_recept = RTrim(DR.Item("sas_jm_recept"))
                If Not IsDBNull(DR.Item("sas_kolicina")) Then _sas_kolicina = RTrim(DR.Item("sas_kolicina"))
                If Not IsDBNull(DR.Item("sas_odobrena")) Then _sas_odobrena = DR.Item("sas_odobrena")
                If Not IsDBNull(DR.Item("sas_datum_unosa")) Then _sas_datum_unosa = DR.Item("sas_datum_unosa")
                If Not IsDBNull(DR.Item("sas_datum_prestanka")) Then _sas_datum_prestanka = DR.Item("sas_datum_prestanka")
                If Not IsDBNull(DR.Item("sas_ukupno")) Then _sas_ukupno = DR.Item("sas_ukupno")
                If Not IsDBNull(DR.Item("sas_vrednost")) Then _sas_vrednost = DR.Item("sas_vrednost")
                If Not IsDBNull(DR.Item("sas_radna_taksa")) Then _sas_radna_taksa = DR.Item("sas_radna_taksa")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    'Public Sub sastavnica_print()
    '    Dim CN As SqlConnection = New SqlConnection(CNNString)
    '    Dim CM As New SqlCommand
    '    Dim CM1 As New SqlCommand
    '    Dim DR As SqlDataReader

    '    CN.Open()
    '    If CN.State = ConnectionState.Open Then
    '        CM = New SqlCommand()
    '        With CM
    '            .Connection = CN
    '            .CommandType = CommandType.StoredProcedure
    '            .CommandText = "pr_sastavnica_prn_delete"
    '            .ExecuteScalar()
    '        End With
    '        CM.Dispose()

    '        CM1 = New SqlCommand()
    '        With CM1
    '            .Connection = CN
    '            .CommandType = CommandType.Text
    '            .CommandText = "select * from dbo.pr_sastavnica_stavka where dbo.pr_sastavnica_stavka.id_sastavnica = " & _id_sastavnica
    '            DR = .ExecuteReader
    '        End With

    '        Dim i As Integer = 0
    '        Dim st_rb() As String = New String(50) {}
    '        Dim st_id() As Integer = New Integer(50) {}
    '        Dim st_sifra() As String = New String(50) {}
    '        Dim st_naziv() As String = New String(50) {}
    '        Dim st_cena() As Single = New Single(50) {}
    '        Dim st_radna_taksa() As Single = New Single(50) {}
    '        Dim st_jm() As String = New String(50) {}
    '        Dim st_kol() As Single = New Single(50) {}
    '        Dim st_jm_skladistenja() As String = New String(50) {}
    '        Dim st_kol_skladistenja() As Single = New Single(50) {}
    '        Dim st_vrednost() As Single = New Single(50) {}

    '        Do While DR.Read
    '            If Not IsDBNull(DR.Item("sas_st_rb")) Then st_rb.SetValue(DR.Item("sas_st_rb"), i)
    '            If Not IsDBNull(DR.Item("sas_st_sifra")) Then st_sifra.SetValue(DR.Item("sas_st_sifra"), i)
    '            If Not IsDBNull(DR.Item("sas_st_naziv")) Then st_naziv.SetValue(DR.Item("sas_st_naziv"), i)
    '            If Not IsDBNull(DR.Item("sas_st_radna_taksa")) Then st_radna_taksa.SetValue(CSng(DR.Item("sas_st_radna_taksa")), i)
    '            If Not IsDBNull(DR.Item("sas_st_jm")) Then st_jm.SetValue(DR.Item("sas_st_jm"), i)
    '            If Not IsDBNull(DR.Item("sas_st_kolicina")) Then st_kol.SetValue(CSng(DR.Item("sas_st_kolicina")), i)
    '            If Not IsDBNull(DR.Item("sas_st_jm_skladistenja")) Then st_jm_skladistenja.SetValue(DR.Item("sas_st_jm_skladistenja"), i)
    '            If Not IsDBNull(DR.Item("sas_st_kolicina_skladistenja")) Then st_kol_skladistenja.SetValue(CSng(DR.Item("sas_st_kolicina_skladistenja")), i)
    '            If Not IsDBNull(DR.Item("sas_st_cena")) Then st_cena.SetValue(CSng(DR.Item("sas_st_cena")), i)
    '            If Not IsDBNull(DR.Item("sas_st_vrednist")) Then st_vrednost.SetValue(CSng(DR.Item("sas_st_vrednist")), i)
    '            i += 1
    '        Loop
    '        DR.Close()
    '        CM1.Dispose()

    '        Dim j As Integer = 0
    '        For j = 0 To i - 1
    '            CM = New SqlCommand()
    '            With CM
    '                .Connection = CN
    '                .CommandType = CommandType.StoredProcedure
    '                .CommandText = "pr_sastavnica_prn_add"
    '                .Parameters.AddWithValue("@sas_art_sifra", _sas_art_sifra)
    '                .Parameters.AddWithValue("@sas_art_naziv", _sas_art_naziv)
    '                .Parameters.AddWithValue("@sas_art_cena", _sas_art_cena)
    '                .Parameters.AddWithValue("@sas_jm_recept", _sas_jm_recept)
    '                .Parameters.AddWithValue("@sas_kolicina", _sas_kolicina)
    '                .Parameters.AddWithValue("@sas_odobrena", _sas_odobrena)
    '                .Parameters.AddWithValue("@sas_datum_unosa", _sas_datum_unosa)
    '                .Parameters.AddWithValue("@sas_datum_prestanka", _sas_datum_prestanka)
    '                .Parameters.AddWithValue("@sas_ukupno", _sas_ukupno)
    '                .Parameters.AddWithValue("@sas_vrednost", _sas_vrednost)
    '                .Parameters.AddWithValue("@sas_radna_taksa", _sas_radna_taksa)
    '                .Parameters.AddWithValue("@sas_st_rb", st_rb(j))
    '                .Parameters.AddWithValue("@sas_st_sifra", st_sifra(j))
    '                .Parameters.AddWithValue("@sas_st_naziv", st_naziv(j))
    '                .Parameters.AddWithValue("@sas_st_radna_taksa", st_radna_taksa(j))
    '                .Parameters.AddWithValue("@sas_st_jm", st_jm(j))
    '                .Parameters.AddWithValue("@sas_st_kolicina", st_kol(j))
    '                .Parameters.AddWithValue("@sas_st_jm_skladistenja", st_jm_skladistenja(j))
    '                .Parameters.AddWithValue("@sas_st_kolicina_skladistenja", st_kol_skladistenja(j))
    '                .Parameters.AddWithValue("@sas_st_cena", st_cena(j))
    '                .Parameters.AddWithValue("@sas_st_vrednist", st_vrednost(j))
    '                .ExecuteScalar()
    '            End With
    '            CM.Dispose()
    '        Next
    '    End If
    '    CN.Close()
    'End Sub

    Public Sub selektuj_lab_dn(ByVal _upit As String, ByVal _selekcija As Integer)
        On Error Resume Next
        Dim _sql As String = "select * from dbo.pr_lab_dn_head where dbo.pr_lab_dn_head."
        Select Case _selekcija
            Case Selekcija.po_id
                _sql += "id_lab_dn = " & CInt(_upit)
            Case Selekcija.po_nazivu
                '_sql += "sas_art_naziv = N'" & RTrim(_upit) & "'"
            Case Selekcija.po_sifri
                _sql += "lab_dn_broj = " & RTrim(_upit)
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

            _id_lab_dn = 0
            _lab_dn_broj = ""
            _lab_dn_datum = Today
            _lab_dn_vred_preparata = 0
            _lab_dn_vred_materijala = 0
            _lab_dn_radna_taksa = 0
            _lab_dn_zakljuen = False

            Do While DR.Read
                If Not IsDBNull(DR.Item("id_lab_dn")) Then _id_lab_dn = RTrim(DR.Item("id_lab_dn"))
                If Not IsDBNull(DR.Item("lab_dn_broj")) Then _lab_dn_broj = RTrim(DR.Item("lab_dn_broj"))
                If Not IsDBNull(DR.Item("lab_dn_datum")) Then _lab_dn_datum = RTrim(DR.Item("lab_dn_datum"))
                If Not IsDBNull(DR.Item("lab_dn_vred_preparata")) Then _lab_dn_vred_preparata = RTrim(DR.Item("lab_dn_vred_preparata"))
                If Not IsDBNull(DR.Item("lab_dn_vred_materijala")) Then _lab_dn_vred_materijala = RTrim(DR.Item("lab_dn_vred_materijala"))
                If Not IsDBNull(DR.Item("lab_dn_radna_taksa")) Then _lab_dn_radna_taksa = RTrim(DR.Item("lab_dn_radna_taksa"))
                If Not IsDBNull(DR.Item("lab_dn_zakljuen")) Then _lab_dn_zakljuen = DR.Item("lab_dn_zakljuen")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    'Public Sub lab_dn_print()
    '    Dim CN As SqlConnection = New SqlConnection(CNNString)
    '    Dim CM As New SqlCommand
    '    Dim CM1 As New SqlCommand
    '    Dim DR As SqlDataReader

    '    CN.Open()
    '    If CN.State = ConnectionState.Open Then
    '        CM = New SqlCommand()
    '        With CM
    '            .Connection = CN
    '            .CommandType = CommandType.StoredProcedure
    '            .CommandText = "pr_lab_dn_prn_delete"
    '            .ExecuteScalar()
    '        End With
    '        CM.Dispose()

    '        CM1 = New SqlCommand()
    '        With CM1
    '            .Connection = CN
    '            .CommandType = CommandType.Text
    '            .CommandText = "SELECT " & _
    '                  "dbo.pr_lab_dn_stavka.lab_dn_st_rb, " & _
    '                  "dbo.pr_lab_dn_stavka.lab_dn_st_sifra, " & _
    '                  "dbo.pr_lab_dn_stavka.lab_dn_st_naziv, " & _
    '                  "dbo.pr_lab_dn_stavka.lab_dn_st_jm, " & _
    '                  "dbo.pr_lab_dn_stavka.lab_dn_st_kolicina, " & _
    '                  "dbo.pr_lab_dn_stavka.lab_dn_st_cena, " & _
    '                  "dbo.pr_lab_dn_stavka.lab_dn_st_vrednost, " & _
    '                  "dbo.pr_lab_dn_stavka.lab_dn_st_rad_taksa " & _
    '            "FROM dbo.pr_lab_dn_stavka " & _
    '            "WHERE dbo.pr_lab_dn_stavka.id_lab_dn = " & _id_lab_dn

    '            DR = .ExecuteReader
    '        End With

    '        Dim i As Integer = 0
    '        Dim st_rb() As String = New String(50) {}
    '        Dim st_id() As Integer = New Integer(50) {}
    '        Dim st_sifra() As String = New String(50) {}
    '        Dim st_naziv() As String = New String(50) {}
    '        Dim st_kol() As Single = New Single(50) {}
    '        Dim st_cena() As Single = New Single(50) {}
    '        Dim st_vrednost() As Single = New Single(50) {}
    '        Dim st_radna_taksa() As Single = New Single(50) {}

    '        Do While DR.Read
    '            If Not IsDBNull(DR.Item("lab_dn_st_rb")) Then st_rb.SetValue(DR.Item("lab_dn_st_rb").ToString, i)
    '            If Not IsDBNull(DR.Item("lab_dn_st_sifra")) Then st_sifra.SetValue(DR.Item("lab_dn_st_sifra"), i)
    '            If Not IsDBNull(DR.Item("lab_dn_st_naziv")) Then st_naziv.SetValue(DR.Item("lab_dn_st_naziv"), i)
    '            If Not IsDBNull(DR.Item("lab_dn_st_kolicina")) Then st_kol.SetValue(CSng(DR.Item("lab_dn_st_kolicina")), i)
    '            If Not IsDBNull(DR.Item("lab_dn_st_cena")) Then st_cena.SetValue(CSng(DR.Item("lab_dn_st_cena")), i)
    '            If Not IsDBNull(DR.Item("lab_dn_st_vrednost")) Then st_vrednost.SetValue(CSng(DR.Item("lab_dn_st_vrednost")), i)
    '            If Not IsDBNull(DR.Item("lab_dn_st_rad_taksa")) Then st_radna_taksa.SetValue(CSng(DR.Item("lab_dn_st_rad_taksa")), i)

    '            i += 1
    '        Loop
    '        DR.Close()
    '        CM1.Dispose()

    '        Dim j As Integer = 0
    '        For j = 0 To i - 1
    '            CM = New SqlCommand()
    '            With CM
    '                .Connection = CN
    '                .CommandType = CommandType.StoredProcedure
    '                .CommandText = "pr_lab_dn_prn_add"
    '                .Parameters.AddWithValue("@id_lab_dn", _id_lab_dn)
    '                .Parameters.AddWithValue("@lab_dn_broj", _lab_dn_broj)
    '                .Parameters.AddWithValue("@lab_dn_datum_od", Today)
    '                .Parameters.AddWithValue("@lab_dn_datum", _lab_dn_datum)
    '                .Parameters.AddWithValue("@lab_dn_vred_preparata", _lab_dn_vred_preparata)
    '                .Parameters.AddWithValue("@lab_dn_vred_materijala", _lab_dn_vred_materijala)
    '                .Parameters.AddWithValue("@lab_dn_radna_taksa", _lab_dn_radna_taksa)
    '                .Parameters.AddWithValue("@lab_dn_zakljuen", _lab_dn_zakljuen)

    '                .Parameters.AddWithValue("@lab_dn_st_rb", st_rb(j))
    '                .Parameters.AddWithValue("@lab_dn_st_sifra", st_sifra(j))
    '                .Parameters.AddWithValue("@lab_dn_st_naziv", st_naziv(j))
    '                .Parameters.AddWithValue("@lab_dn_st_kolicina", st_kol(j))
    '                .Parameters.AddWithValue("@lab_dn_st_cena", st_cena(j))
    '                .Parameters.AddWithValue("@lab_dn_st_vrednost", CSng(st_vrednost(j)))
    '                .Parameters.AddWithValue("@lab_dn_st_rad_taksa", st_radna_taksa(j))

    '                '.Parameters.AddWithValue("@id_magacin", 0)
    '                '.Parameters.AddWithValue("@lab_dn_st_ut_sifra", "")
    '                '.Parameters.AddWithValue("@lab_dn_st_ut_naziv", "")
    '                '.Parameters.AddWithValue("@lab_dn_st_ut_kolicina", 0)
    '                '.Parameters.AddWithValue("@lab_dn_st_ut_cena", 0)
    '                '.Parameters.AddWithValue("@lab_dn_st_ut_vrednost", 0)
    '                '.Parameters.AddWithValue("@lab_dn_st_ut_rad_taksa", 0)

    '                .ExecuteScalar()
    '            End With
    '            CM.Dispose()
    '        Next
    '    End If
    '    CN.Close()
    'End Sub

    'Public Sub lab_dn_trebovanje_print()
    '    Dim CN As SqlConnection = New SqlConnection(CNNString)
    '    Dim CM As New SqlCommand
    '    Dim CM1 As New SqlCommand
    '    Dim DR As SqlDataReader

    '    CN.Open()
    '    If CN.State = ConnectionState.Open Then
    '        CM = New SqlCommand()
    '        With CM
    '            .Connection = CN
    '            .CommandType = CommandType.StoredProcedure
    '            .CommandText = "pr_lab_dn_prn_delete"
    '            .ExecuteScalar()
    '        End With
    '        CM.Dispose()

    '        CM1 = New SqlCommand()
    '        With CM1
    '            .Connection = CN
    '            .CommandType = CommandType.Text
    '            .CommandText = "SELECT DISTINCT " & _
    '                  "dbo.pr_lab_dn_stavka_utroseno.id_magacin, " & _
    '                  "dbo.pr_lab_dn_stavka_utroseno.lab_dn_st_ut_sifra, " & _
    '                  "dbo.pr_lab_dn_stavka_utroseno.lab_dn_st_ut_naziv, " & _
    '                  "dbo.pr_lab_dn_stavka_utroseno.lab_dn_st_ut_kolicina, " & _
    '                  "dbo.pr_lab_dn_stavka_utroseno.lab_dn_st_ut_kol_sklad, " & _
    '                  "dbo.pr_lab_dn_stavka_utroseno.lab_dn_st_ut_cena, " & _
    '                  "dbo.pr_lab_dn_stavka_utroseno.lab_dn_st_ut_vrednost, " & _
    '                  "dbo.pr_lab_dn_stavka_utroseno.lab_dn_st_ut_rad_taksa " & _
    '            "FROM dbo.pr_lab_dn_stavka_utroseno " & _
    '            "WHERE dbo.pr_lab_dn_stavka_utroseno.id_lab_dn = " & _id_lab_dn

    '            DR = .ExecuteReader
    '        End With

    '        Dim i As Integer = 0

    '        Dim st_ut_id_mag() As Integer = New Integer(50) {}
    '        Dim lab_dn_st_ut_sifra() As String = New String(50) {}
    '        Dim lab_dn_st_ut_naziv() As String = New String(50) {}
    '        Dim lab_dn_st_ut_kolicina() As Single = New Single(50) {}
    '        Dim lab_dn_st_ut_kol_sklad() As Single = New Single(50) {}
    '        Dim lab_dn_st_ut_cena() As Single = New Single(50) {}
    '        Dim lab_dn_st_ut_vrednost() As Single = New Single(50) {}
    '        Dim lab_dn_st_ut_rad_taksa() As Single = New Single(50) {}

    '        Do While DR.Read
    '            If Not IsDBNull(DR.Item("id_magacin")) Then st_ut_id_mag.SetValue(DR.Item("id_magacin"), i)
    '            If Not IsDBNull(DR.Item("lab_dn_st_ut_sifra")) Then lab_dn_st_ut_sifra.SetValue(DR.Item("lab_dn_st_ut_sifra").ToString, i)
    '            If Not IsDBNull(DR.Item("lab_dn_st_ut_naziv")) Then lab_dn_st_ut_naziv.SetValue(DR.Item("lab_dn_st_ut_naziv"), i)
    '            If Not IsDBNull(DR.Item("lab_dn_st_ut_kolicina")) Then lab_dn_st_ut_kolicina.SetValue(CSng(DR.Item("lab_dn_st_ut_kolicina")), i)
    '            If Not IsDBNull(DR.Item("lab_dn_st_ut_kol_sklad")) Then lab_dn_st_ut_kol_sklad.SetValue(CSng(DR.Item("lab_dn_st_ut_kol_sklad")), i)
    '            If Not IsDBNull(DR.Item("lab_dn_st_ut_cena")) Then lab_dn_st_ut_cena.SetValue(CSng(DR.Item("lab_dn_st_ut_cena")), i)
    '            If Not IsDBNull(DR.Item("lab_dn_st_ut_vrednost")) Then lab_dn_st_ut_vrednost.SetValue(CSng(DR.Item("lab_dn_st_ut_vrednost")), i)
    '            If Not IsDBNull(DR.Item("lab_dn_st_ut_rad_taksa")) Then lab_dn_st_ut_rad_taksa.SetValue(CSng(DR.Item("lab_dn_st_ut_rad_taksa")), i)
    '            i += 1
    '        Loop
    '        DR.Close()
    '        CM1.Dispose()

    '        Dim j As Integer = 0
    '        For j = 0 To i - 1
    '            CM = New SqlCommand()
    '            With CM
    '                .Connection = CN
    '                .CommandType = CommandType.StoredProcedure
    '                .CommandText = "pr_lab_dn_prn_add"
    '                .Parameters.AddWithValue("@id_lab_dn", _id_lab_dn)
    '                .Parameters.AddWithValue("@lab_dn_broj", _lab_dn_broj)
    '                .Parameters.AddWithValue("@lab_dn_datum", _lab_dn_datum)
    '                .Parameters.AddWithValue("@lab_dn_vred_preparata", _lab_dn_vred_preparata)
    '                .Parameters.AddWithValue("@lab_dn_vred_materijala", _lab_dn_vred_materijala)
    '                .Parameters.AddWithValue("@lab_dn_radna_taksa", _lab_dn_radna_taksa)
    '                .Parameters.AddWithValue("@lab_dn_zakljuen", _lab_dn_zakljuen)

    '                .Parameters.AddWithValue("@lab_dn_st_rb", 0)
    '                .Parameters.AddWithValue("@lab_dn_st_sifra", "")
    '                .Parameters.AddWithValue("@lab_dn_st_naziv", "")
    '                .Parameters.AddWithValue("@lab_dn_st_kolicina", 0)
    '                .Parameters.AddWithValue("@lab_dn_st_cena", 0)
    '                .Parameters.AddWithValue("@lab_dn_st_vrednost", 0)
    '                .Parameters.AddWithValue("@lab_dn_st_rad_taksa", 0)

    '                .Parameters.AddWithValue("@id_magacin", st_ut_id_mag(j))
    '                If Not IsNothing(lab_dn_st_ut_sifra(j)) Then
    '                    .Parameters.AddWithValue("@lab_dn_st_ut_sifra", lab_dn_st_ut_sifra(j))
    '                Else
    '                    .Parameters.AddWithValue("@lab_dn_st_ut_sifra", "")
    '                End If
    '                If Not IsNothing(lab_dn_st_ut_naziv(j)) Then
    '                    .Parameters.AddWithValue("@lab_dn_st_ut_naziv", lab_dn_st_ut_naziv(j))
    '                Else
    '                    .Parameters.AddWithValue("@lab_dn_st_ut_naziv", "")
    '                End If
    '                .Parameters.AddWithValue("@lab_dn_st_ut_kolicina", lab_dn_st_ut_kol_sklad(j))
    '                .Parameters.AddWithValue("@lab_dn_st_ut_cena", lab_dn_st_ut_cena(j))
    '                .Parameters.AddWithValue("@lab_dn_st_ut_vrednost", lab_dn_st_ut_vrednost(j))
    '                .Parameters.AddWithValue("@lab_dn_st_ut_rad_taksa", lab_dn_st_ut_rad_taksa(j))
    '                .ExecuteScalar()
    '            End With
    '            CM.Dispose()
    '        Next
    '    End If
    '    CN.Close()
    'End Sub

    Public Function odnos_jedinica(ByVal jm1, ByVal jm2) As Single
        odnos_jedinica = 1

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = " select * from dbo.app_jedinice_mera_konverzije " & _
                                "where dbo.app_jedinice_mera_konverzije.Jedinica_Mere_Sifra = N'" & jm1 & _
                                "' and dbo.app_jedinice_mera_konverzije.Jedinica_Mere_Konverzije_Sifra = N'" & jm2 & "'"
                DR = .ExecuteReader
            End With

            Do While DR.Read
                odnos_jedinica = DR.Item("Faktor_Konverzije")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Function

End Module
