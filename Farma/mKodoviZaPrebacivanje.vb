Module mKodoviZaPrebacivanje

    '************* VRSTA ORGANIZACIONE JEDINICE ADD **************

    'Dim CN As SqlConnection = New SqlConnection(CNNString)
    'Dim CM As New SqlCommand

    'Dim CN1 As SqlConnection = New SqlConnection(CNN)
    'Dim CM1 As New SqlCommand
    'Dim DR1 As SqlDataReader

    '    CN1.Open()
    '    CN.Open()
    '    If CN1.State = ConnectionState.Open Then
    '        CM1 = New SqlCommand()
    '        With CM1
    '            .Connection = CN1
    '            .CommandType = CommandType.Text
    '            .CommandText = "SELECT dbo.Vrsta_Organizacione_Jedinice.* from dbo.Vrsta_Organizacione_Jedinice"
    '            DR1 = .ExecuteReader
    '        End With

    'Dim vrsta_oj_sifra As String = ""
    'Dim vrsta_oj_naziv As String = ""
    'Dim vrsta_oj_vodjenje_zaliha As Boolean = False
    'Dim vrsta_oj_obj_robnog_poslovanja As Boolean = False
    'Dim vrsta_oj_obj_blagajnickog_poslovanja As Boolean = False
    'Dim vrsta_oj_prodajni_objekat As Boolean = False
    'Dim vrsta_oj_fakturise As Boolean = False
    'Dim id_vrsta_cenovnika As String = ""
    'Dim vrsta_oj_minusne_zalihe As Boolean = False
    'Dim vrsta_oj_auto_promena_cene As Boolean = False
    'Dim vrsta_oj_minusne_rezervacije As Boolean = False

    '        While DR1.Read
    '            vrsta_oj_sifra = DR1.Item("Vrsta_Orgjed_Sifra").ToString
    '            vrsta_oj_naziv = DR1.Item("Naziv_L1").ToString
    '            If Not IsDBNull(DR1.Item("Vrednovanje_Zaliha")) Then
    '                vrsta_oj_vodjenje_zaliha = DR1.Item("Vrednovanje_Zaliha").ToString
    '            End If
    '            vrsta_oj_obj_robnog_poslovanja = DR1.Item("Objekat_Robnog_Poslovanja")
    '            vrsta_oj_obj_blagajnickog_poslovanja = DR1.Item("Objekat_Blagajnickog_Poslovanja")
    '            vrsta_oj_prodajni_objekat = DR1.Item("Prodajni_Objekat")
    '            vrsta_oj_fakturise = DR1.Item("Fakturise")
    '            id_vrsta_cenovnika = DR1.Item("Vrsta_Cenovnika_Sifra").ToString
    '            vrsta_oj_minusne_zalihe = DR1.Item("Minusne_Zalihe")
    '            vrsta_oj_auto_promena_cene = DR1.Item("Automatska_Promena_Cene")
    '            If Not IsDBNull(DR1.Item("Minusne_Rezervacije")) Then
    '                vrsta_oj_minusne_rezervacije = DR1.Item("Minusne_Rezervacije")
    '            End If

    ''If Not IsDBNull(DR1.Item("Marza")) Then
    ''    marza = DR1.Item("Marza")
    ''End If

    '            CM = New SqlCommand()
    '            With CM
    '                .Connection = CN
    '                .CommandType = CommandType.StoredProcedure
    '                .CommandText = "app_vrsta_oj_add"
    '                .Parameters.AddWithValue("@vrsta_oj_sifra", vrsta_oj_sifra)
    '                .Parameters.AddWithValue("@vrsta_oj_naziv", vrsta_oj_naziv)
    '                .Parameters.AddWithValue("@vrsta_oj_vodjenje_zaliha", vrsta_oj_vodjenje_zaliha)
    '                .Parameters.AddWithValue("@vrsta_oj_obj_robnog_poslovanja", vrsta_oj_obj_robnog_poslovanja)
    '                .Parameters.AddWithValue("@vrsta_oj_obj_blagajnickog_poslovanja", vrsta_oj_obj_blagajnickog_poslovanja)
    '                .Parameters.AddWithValue("@vrsta_oj_prodajni_objekat", vrsta_oj_prodajni_objekat)
    '                .Parameters.AddWithValue("@vrsta_oj_fakturise", vrsta_oj_fakturise)
    '                .Parameters.AddWithValue("@id_vrsta_cenovnika", id_vrsta_cenovnika)
    '                .Parameters.AddWithValue("@vrsta_oj_minusne_zalihe", vrsta_oj_minusne_zalihe)
    '                .Parameters.AddWithValue("@vrsta_oj_auto_promena_cene", vrsta_oj_auto_promena_cene)
    '                .Parameters.AddWithValue("@vrsta_oj_minusne_rezervacije", vrsta_oj_minusne_rezervacije)
    '                .ExecuteScalar()
    '            End With
    '            CM.Dispose()
    '        End While
    '        DR1.Close()
    '        CM1.Dispose()
    '    End If
    '    CN.Close()
    '    CN1.Close()

    '************** ARTIKLI UPDATE *****************
    'Dim CN As SqlConnection = New SqlConnection(CNNString)
    'Dim CM As New SqlCommand

    'Dim CN1 As SqlConnection = New SqlConnection(CNN)
    'Dim CM1 As New SqlCommand
    'Dim DR1 As SqlDataReader

    '    CN1.Open()
    '    CN.Open()
    '    If CN1.State = ConnectionState.Open Then
    '        CM1 = New SqlCommand()
    '        With CM1
    '            .Connection = CN1
    '            .CommandType = CommandType.Text
    '            .CommandText = "SELECT dbo.Artikal.* from dbo.Artikal"
    '            DR1 = .ExecuteReader
    '        End With

    '        _id_artikl = ""
    '        _artikl_naziv = ""
    '        _artikl_sifra = ""
    '        _artikl_sifra_stara = ""
    '        _artikl_jm = ""
    '        _artikl_id_pdv = 0
    '        _artikl_id_kategorija = 0
    '        _artikl_aktivan = True
    '        _artikl_id_jkl = 0
    '        _artikl_artikl_vrsta = ""
    '        _artikl_id_proizvodjac = 0
    '        _artikl_fabricko_ime = 0
    '        _artikl_genericko_ime = 0
    '        _artikl_nacin_izdavanja = ""
    '        _artikl_bar_kod = 0
    '        _artikl_humanitarna_pomoc = False
    '        _artikl_aktivan = False

    'Dim i As Integer = 2
    '        While DR1.Read

    '            _id_artikl = ""
    '            _artikl_naziv = ""
    '            _artikl_sifra = ""
    '            _artikl_sifra_stara = ""
    '            _artikl_jm = ""
    '            _artikl_id_pdv = 0
    '            _artikl_id_kategorija = 0
    '            _artikl_aktivan = True
    '            _artikl_id_jkl = 0
    '            _artikl_artikl_vrsta = ""
    '            _artikl_id_proizvodjac = 0
    '            _artikl_fabricko_ime = 0
    '            _artikl_genericko_ime = 0
    '            _artikl_nacin_izdavanja = ""
    '            _artikl_bar_kod = 0
    '            _artikl_humanitarna_pomoc = False
    '            _artikl_aktivan = False

    '            _id_artikl = i
    '            _artikl_naziv = DR1.Item("Naziv_L1").ToString
    '            _artikl_sifra = DR1.Item("Artikal_Sifra").ToString
    '            _artikl_sifra_stara = RTrim(DR1.Item("Stara_Sifra").ToString)
    '            _artikl_jm = RTrim(DR1.Item("Jedinica_Mere_Sifra").ToString)
    '            Select Case RTrim(DR1.Item("Tarifa_Sifra").ToString)
    '                Case "00"
    '                    _artikl_id_pdv = 3
    '                Case "01"
    '                    _artikl_id_pdv = 4
    '                Case "03"
    '                    _artikl_id_pdv = 1
    '            End Select
    '            If Not RTrim(DR1.Item("JKL_Sifra").ToString) = "" Then
    '                _artikl_id_jkl = jkl(RTrim(DR1.Item("JKL_Sifra").ToString))
    '            End If

    '            _artikl_id_proizvodjac = Partner_id_sif(DR1.Item("Proizvodjac_Sifra").ToString)

    '            CM = New SqlCommand()
    '            With CM
    '                .Connection = CN
    '                .CommandType = CommandType.StoredProcedure
    '                .CommandText = "rm_artikli_update"
    '                .Parameters.AddWithValue("@id_artikl", _id_artikl)
    '                .Parameters.AddWithValue("@sifra", _artikl_sifra)
    '                .Parameters.AddWithValue("@sifra_stara", _artikl_sifra_stara)
    '                .Parameters.AddWithValue("@naziv", _artikl_naziv)
    '                .Parameters.AddWithValue("@id_jm", _artikl_jm)
    '                .Parameters.AddWithValue("@id_kategorija", _artikl_id_kategorija)
    '                .Parameters.AddWithValue("@id_pdv", _artikl_id_pdv)
    '                .Parameters.AddWithValue("@id_jkl", _artikl_id_jkl)
    '                .Parameters.AddWithValue("@artikl_vrsta", _artikl_artikl_vrsta)
    '                .Parameters.AddWithValue("@id_proizvodjac", _artikl_id_proizvodjac)
    '                .Parameters.AddWithValue("@fabricko_ime", _artikl_fabricko_ime)
    '                .Parameters.AddWithValue("@genericko_ime", _artikl_genericko_ime)
    '                .Parameters.AddWithValue("@nacin_izdavanja", _artikl_nacin_izdavanja)
    '                .Parameters.AddWithValue("@bar_kod", _artikl_bar_kod)
    '                .Parameters.AddWithValue("@humanitarna_pomoc", _artikl_humanitarna_pomoc)
    '                .Parameters.AddWithValue("@aktivan", _artikl_aktivan)
    '                .ExecuteScalar()
    '            End With
    '            CM.Dispose()
    '            i += 1
    '        End While
    '        DR1.Close()
    '        CM1.Dispose()
    '    End If
    '    CN.Close()
    '    CN1.Close()


    '************** MESTA I PTT BR UPDATE *****************
    'Dim CN As SqlConnection = New SqlConnection(CNNString)
    'Dim CM As New SqlCommand

    'Dim CN1 As SqlConnection = New SqlConnection(CNN)
    'Dim CM1 As New SqlCommand
    'Dim DR1 As SqlDataReader

    '    CN1.Open()
    '    CN.Open()
    '    If CN1.State = ConnectionState.Open Then
    '        CM1 = New SqlCommand()
    '        With CM1
    '            .Connection = CN1
    '            .CommandType = CommandType.Text
    '            .CommandText = "SELECT dbo.Mesto.* from dbo.Mesto"
    '            DR1 = .ExecuteReader
    '        End With

    'Dim mesto_sifra As String = ""

    '        _id_grad = 0
    '        _grad_naziv = ""
    '        _grad_ptt_br = ""
    '        _grad_aktivan = False

    'Dim i As Integer = 2
    '        While DR1.Read
    '            If Not RTrim(DR1.Item("mesto_sifra").ToString) = "" Then
    '                _grad_ptt_br = RTrim(DR1.Item("mesto_sifra").ToString)
    '                _grad_naziv = RTrim(DR1.Item("Naziv_L1").ToString)
    '            End If
    ''If _grad_ptt_br <> "" Then
    ''    nadji_mesto(_grad_ptt_br)
    ''    If _grad_naziv <> "" Then
    '            nadji_id(_grad_naziv)
    '            If _id_grad <> 0 Then
    '                CM = New SqlCommand()
    '                With CM
    '                    .Connection = CN
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "app_gradovi_update"
    '                    .Parameters.AddWithValue("@id_grad", _id_grad)
    '                    .Parameters.AddWithValue("@grad_naziv", _grad_naziv)
    '                    .Parameters.AddWithValue("@grad_ptt_br", _grad_ptt_br)
    '                    .Parameters.AddWithValue("@grad_porjed", 0)
    '                    .Parameters.AddWithValue("@grad_aktivan", _grad_aktivan)
    '                    .ExecuteScalar()
    '                End With
    '                CM.Dispose()
    '            Else
    '                CM = New SqlCommand()
    '                With CM
    '                    .Connection = CN
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "app_gradovi_add"
    '                    .Parameters.AddWithValue("@grad_naziv", _grad_naziv)
    '                    .Parameters.AddWithValue("@grad_ptt_br", _grad_ptt_br)
    '                    .Parameters.AddWithValue("@grad_porjed", 0)
    '                    .Parameters.AddWithValue("@grad_aktivan", _grad_aktivan)
    '                    .ExecuteScalar()
    '                End With
    '                CM.Dispose()

    '            End If
    ''End If
    '            _grad_ptt_br = ""
    ''End If

    '        End While
    '        DR1.Close()
    '        CM1.Dispose()
    '    End If
    '    CN.Close()
    '    CN1.Close()
    'End Sub

    'Private Function jkl(ByVal _jkl)
    '    Dim CN As SqlConnection = New SqlConnection(CNNString)
    '    Dim CM As New SqlCommand
    '    Dim DR As SqlDataReader

    '    jkl = ""
    '    CN.Open()
    '    CM = New SqlCommand()
    '    With CM
    '        .Connection = CN
    '        .CommandType = CommandType.Text
    '        .CommandText = "SELECT dbo.app_jkl.* from dbo.app_jkl where dbo.app_jkl.jkl_sifra = '" & _jkl & "'"
    '        DR = .ExecuteReader()
    '        While DR.Read
    '            jkl = DR.Item("id_jkl").ToString
    '        End While
    '        DR.Close()
    '    End With
    '    CM.Dispose()
    '    CN.Close()

    'End Function

    'Private Function jm(ByVal _jm)
    '    Dim CN As SqlConnection = New SqlConnection(CNN)
    '    Dim CM As New SqlCommand
    '    Dim DR As SqlDataReader

    '    jm = ""
    '    CN.Open()
    '    CM = New SqlCommand()
    '    With CM
    '        .Connection = CN
    '        .CommandType = CommandType.Text
    '        .CommandText = "SELECT dbo.Jedinica_Mere.* from dbo.Jedinica_Mere where dbo.Jedinica_Mere.Jedinica_Mere_Sifra = '" & _jm & "'"
    '        DR = .ExecuteReader()
    '        While DR.Read
    '            jm = DR.Item("Naziv_L1").ToString
    '        End While
    '        DR.Close()
    '    End With
    '    CM.Dispose()
    '    CN.Close()

    'End Function

    'Private Sub nadji_mesto(ByVal _ptt)
    '    Dim CN1 As SqlConnection = New SqlConnection(CNN)
    '    Dim CM1 As New SqlCommand
    '    Dim DR1 As SqlDataReader

    '    CN1.Open()
    '    If CN1.State = ConnectionState.Open Then
    '        CM1 = New SqlCommand()
    '        With CM1
    '            .Connection = CN1
    '            .CommandType = CommandType.Text
    '            .CommandText = "SELECT dbo.Mesto.* from dbo.Mesto where dbo.Mesto.Mesto_Sifra = '" & _ptt & "'"
    '            DR1 = .ExecuteReader
    '        End With

    '        While DR1.Read
    '            _grad_naziv = DR1.Item("Naziv_L1").ToString
    '        End While

    '        DR1.Close()
    '        CM1.Dispose()
    '    End If
    '    CN1.Close()
    'End Sub

    'Private Sub nadji_id(ByVal _mesto)
    '    Dim CN As SqlConnection = New SqlConnection(CNNString)
    '    Dim CM As New SqlCommand
    '    Dim DR As SqlDataReader

    '    CN.Open()
    '    If CN.State = ConnectionState.Open Then
    '        CM = New SqlCommand()
    '        With CM
    '            .Connection = CN
    '            .CommandType = CommandType.Text
    '            .CommandText = "SELECT dbo.app_gradovi.* from dbo.app_gradovi where dbo.app_gradovi.grad_naziv = N'" & _mesto & "'"
    '            DR = .ExecuteReader
    '        End With

    '        While DR.Read
    '            _id_grad = DR.Item("id_grad")
    '        End While
    '        DR.Close()
    '        CM.Dispose()
    '    End If
    '    CN.Close()
    'End Sub

    'Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
    '    Dim CN As SqlConnection = New SqlConnection(CNNString)
    '    Dim CM As New SqlCommand

    '    Dim CN1 As SqlConnection = New SqlConnection(CNN)
    '    Dim CM1 As New SqlCommand
    '    Dim DR1 As SqlDataReader

    '    CN1.Open()
    '    CN.Open()
    '    If CN1.State = ConnectionState.Open Then
    '        CM1 = New SqlCommand()
    '        With CM1
    '            .Connection = CN1
    '            .CommandType = CommandType.Text
    '            .CommandText = "SELECT dbo.Organizaciona_Jedinica.* from dbo.Organizaciona_Jedinica"
    '            DR1 = .ExecuteReader
    '        End With

    '        _id_grad = 0
    '        _grad_naziv = ""
    '        _grad_ptt = ""
    '        _grad_aktivan = False

    '        _oj_sifra = ""
    '        _oj_naziv = ""
    '        _oj_adresa = ""
    '        _oj_strukturna = False

    '        While DR1.Read
    '            If Not RTrim(DR1.Item("mesto_sifra").ToString) = "" Then
    '                _grad_ptt = RTrim(DR1.Item("mesto_sifra").ToString)
    '                _oj_naziv = RTrim(DR1.Item("Naziv_L1").ToString)
    '            End If
    '            If _grad_ptt <> "" Then
    '                nadji_mesto(_grad_ptt)

    '                If _grad_naziv <> "" Then

    '                    nadji_id(_grad_naziv)
    '                    nadji_id_oj(_oj_naziv)

    '                    If _id_oj <> 0 Then
    '                        CM = New SqlCommand()
    '                        With CM
    '                            .Connection = CN
    '                            .CommandType = CommandType.StoredProcedure
    '                            .CommandText = "app_organizacione_jedinice_update"
    '                            .Parameters.AddWithValue("@id_orgjed", _id_oj)
    '                            .Parameters.AddWithValue("@oj_sifra", RTrim(_oj_sifra))
    '                            .Parameters.AddWithValue("@oj_naziv", _oj_naziv)
    '                            .Parameters.AddWithValue("@oj_adresa", _oj_adresa)
    '                            .Parameters.AddWithValue("@id_mesto", _id_grad)
    '                            .Parameters.AddWithValue("@id_opstine", 0)
    '                            .Parameters.AddWithValue("@id_vrsta", 0)
    '                            .Parameters.AddWithValue("@oj_strukturna", _grad_aktivan)
    '                            .ExecuteScalar()
    '                        End With
    '                        CM.Dispose()
    '                        'Else
    '                        '    CM = New SqlCommand()
    '                        '    With CM
    '                        '        .Connection = CN
    '                        '        .CommandType = CommandType.StoredProcedure
    '                        '        .CommandText = "app_gradovi_add"
    '                        '        .Parameters.AddWithValue("@grad_naziv", _grad_naziv)
    '                        '        .Parameters.AddWithValue("@grad_ptt_br", _grad_ptt_br)
    '                        '        .Parameters.AddWithValue("@grad_porjed", 0)
    '                        '        .Parameters.AddWithValue("@grad_aktivan", _grad_aktivan)
    '                        '        .ExecuteScalar()
    '                        '    End With
    '                        '    CM.Dispose()

    '                    End If
    '                End If
    '                _grad_ptt = ""
    '                _oj_naziv = ""
    '            End If

    '        End While
    '        DR1.Close()
    '        CM1.Dispose()
    '    End If
    '    CN.Close()
    '    CN1.Close()
    'End Sub

End Module
