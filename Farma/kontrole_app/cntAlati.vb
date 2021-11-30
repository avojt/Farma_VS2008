Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class cntAlati
    Private CNN_PBS = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=PBS;Data Source=" & msp.Server
    Public c_MyConnStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\RZZO.mdb" ';Mode=Share Deny None"

    Public MyConn As New ADODB.Connection
    Private _tabela As String = ""

    Public Sub Close_MyConnection()
        If MyConn.State = 1 Then MyConn.Close()
    End Sub

    Public Sub Open_MyConnection(Optional ByVal ConnMode As ADODB.ConnectModeEnum = ADODB.ConnectModeEnum.adModeReadWrite)

        If MyConn.State = 0 Then
            With MyConn
                .ConnectionString = c_MyConnStr
                .CursorLocation = ADODB.CursorLocationEnum.adUseClient
                .Mode = ADODB.ConnectModeEnum.adModeShareDenyNone
                'If IsMissing(ConnMode) Then
                '    .Mode = ADODB.ConnectModeEnum.adModeRead
                'Else
                '    .Mode = ConnMode
                'End If
                .Open(c_MyConnStr)
            End With
        End If
    End Sub

    Public Function Otvori_RS(ByVal tSql As String) As ADODB.Recordset
        On Error GoTo ErrorHandler

        Otvori_RS = New ADODB.Recordset
        With Otvori_RS
            .Open(tSql, MyConn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic, )
        End With
        Exit Function

ErrorHandler:
        MsgBox("Takav zapis nije pronadjen" & vbLf & "Pokusajte ponovo")
        Exit Function
    End Function

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Dim CN1 As SqlConnection = New SqlConnection(CNN_PBS)
        Dim CM1 As New SqlCommand
        Dim DR1 As SqlDataReader

        CN1.Open()
        CN.Open()
        If CN1.State = ConnectionState.Open Then
            CM1 = New SqlCommand()
            With CM1
                .Connection = CN1
                .CommandType = CommandType.Text
                .CommandText = "SELECT dbo.Artikal.* from dbo.Artikal"
                DR1 = .ExecuteReader
            End With

            Dim artikl_sifra As String = ""
            Dim artikl_naziv As String = ""
            Dim id_grup_artikla As Single = 0
            Dim jkl As String = ""
            Dim id_jm As Single = 0
            Dim id_pdv As Single = 0
            Dim id_proizvodjac As Single = 0
            Dim artikl_genericko_ime As String = ""
            Dim artikl_bar_kod As String = ""
            Dim artikl_human_pomoc As Boolean = False
            Dim zal_po_serbr As Boolean = False
            Dim zal_po_roku_trajanja As Boolean = False
            Dim zal_po_reg_adresi As Boolean = False
            Dim artikl_aktivan As Boolean = False

            While DR1.Read
                artikl_sifra = DR1.Item("Artikal_Sifra").ToString
                artikl_naziv = DR1.Item("Naziv_L1").ToString
                id_grup_artikla = grupa_id(DR1.Item("Grupa_Artikla_Sifra"))
                jkl = DR1.Item("Stara_Sifra").ToString
                selektuj_jm(DR1.Item("Jedinica_Mere_Sifra"), Selekcija.po_nazivu)
                id_jm = _id_jm

                Select Case RTrim(DR1.Item("Tarifa_Sifra").ToString)
                    Case "00"
                        id_pdv = 3
                    Case "01"
                        id_pdv = 4
                    Case "02"
                        id_pdv = 0
                    Case "03"
                        id_pdv = 0
                End Select
                id_proizvodjac = Partner_id_sif(DR1.Item("Proizvodjac_Sifra").ToString)
                artikl_genericko_ime = ""

                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_artikli_add"
                    .Parameters.AddWithValue("@artikl_sifra", artikl_sifra)
                    .Parameters.AddWithValue("@artikl_naziv", artikl_naziv)
                    .Parameters.AddWithValue("@id_grup_artikla", id_grup_artikla)
                    .Parameters.AddWithValue("@jkl", jkl)
                    .Parameters.AddWithValue("@id_jm", id_jm)
                    .Parameters.AddWithValue("@id_pdv", id_pdv)
                    .Parameters.AddWithValue("@id_proizvodjac", id_proizvodjac)
                    .Parameters.AddWithValue("@artikl_genericko_ime", artikl_genericko_ime)
                    .Parameters.AddWithValue("@artikl_bar_kod", artikl_human_pomoc)
                    .Parameters.AddWithValue("@artikl_human_pomoc", artikl_human_pomoc)
                    .Parameters.AddWithValue("@zal_po_serbr", zal_po_serbr)
                    .Parameters.AddWithValue("@zal_po_roku_trajanja", zal_po_roku_trajanja)
                    .Parameters.AddWithValue("@zal_po_reg_adresi", zal_po_reg_adresi)
                    .Parameters.AddWithValue("@artikl_aktivan", artikl_aktivan)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End While
            DR1.Close()
            CM1.Dispose()
        End If
        CN.Close()
        CN1.Close()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Dim CN1 As SqlConnection = New SqlConnection(CNN_PBS)
        Dim CM1 As New SqlCommand
        Dim DR1 As SqlDataReader

        CN1.Open()
        CN.Open()
        If CN1.State = ConnectionState.Open Then
            CM1 = New SqlCommand()
            With CM1
                .Connection = CN1
                .CommandType = CommandType.Text
                .CommandText = "SELECT dbo.Artikal.* from dbo.Artikal"
                DR1 = .ExecuteReader
            End With

            While DR1.Read
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "_UPDATE"
                    .Parameters.AddWithValue("@id_artikl", artikl_id(DR1.Item("Naziv_L1").ToString))
                    selektuj_fo(DR1.Item("FO_Sifra").ToString, Selekcija.po_sifri)
                    .Parameters.AddWithValue("@id_fo", _id_fo)
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End While
            DR1.Close()
            CM1.Dispose()
        End If
        CN.Close()
        CN1.Close()
    End Sub

    Private Function jkl(ByVal _jkl)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        jkl = ""
        CN.Open()
        CM = New SqlCommand()
        With CM
            .Connection = CN
            .CommandType = CommandType.Text
            .CommandText = "SELECT dbo.app_jkl.* from dbo.app_jkl where dbo.app_jkl.jkl_sifra = '" & _jkl & "'"
            DR = .ExecuteReader()
            While DR.Read
                jkl = DR.Item("id_jkl").ToString
            End While
            DR.Close()
        End With
        CM.Dispose()
        CN.Close()

    End Function

    Private Function jm(ByVal _jm)
        Dim CN As SqlConnection = New SqlConnection(CNN_PBS)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        jm = ""
        CN.Open()
        CM = New SqlCommand()
        With CM
            .Connection = CN
            .CommandType = CommandType.Text
            .CommandText = "SELECT dbo.Jedinica_Mere.* from dbo.Jedinica_Mere where dbo.Jedinica_Mere.Jedinica_Mere_Sifra = '" & _jm & "'"
            DR = .ExecuteReader()
            While DR.Read
                jm = DR.Item("Naziv_L1").ToString
            End While
            DR.Close()
        End With
        CM.Dispose()
        CN.Close()

    End Function

    Private Sub nadji_mesto(ByVal _ptt)
        Dim CN1 As SqlConnection = New SqlConnection(CNN_PBS)
        Dim CM1 As New SqlCommand
        Dim DR1 As SqlDataReader

        CN1.Open()
        If CN1.State = ConnectionState.Open Then
            CM1 = New SqlCommand()
            With CM1
                .Connection = CN1
                .CommandType = CommandType.Text
                .CommandText = "SELECT dbo.Mesto.* from dbo.Mesto where dbo.Mesto.Mesto_Sifra = '" & _ptt & "'"
                DR1 = .ExecuteReader
            End With

            While DR1.Read
                _grad_naziv = DR1.Item("Naziv_L1").ToString
            End While

            DR1.Close()
            CM1.Dispose()
        End If
        CN1.Close()
    End Sub

    Private Sub nadji_id(ByVal _mesto)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "SELECT dbo.app_gradovi.* from dbo.app_gradovi where dbo.app_gradovi.grad_naziv = N'" & _mesto & "'"
                DR = .ExecuteReader
            End With

            While DR.Read
                _id_grad = DR.Item("id_grad")
            End While
            DR.Close()
            CM.Dispose()
        End If
        CN.Close()
    End Sub

    Private Sub nadji_id_oj(ByVal _naziv_oj)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "SELECT dbo.app_organizacione_jedinice.* from dbo.app_organizacione_jedinice where dbo.app_organizacione_jedinice.oj_naziv = N'" & _naziv_oj & "'"
                DR = .ExecuteReader
            End With

            While DR.Read
                _id_oj = DR.Item("id_orgjed")
                _oj_sifra = DR.Item("oj_sifra")
                _oj_naziv = _naziv_oj
                _oj_adresa = DR.Item("oj_adresa")
                '_id_vrsta = DR.Item("id_vrsta")
                _oj_strukturna = DR.Item("oj_strukturna")
            End While
            DR.Close()
            CM.Dispose()
        End If
        CN.Close()
    End Sub

    Private Sub btnAccess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccess.Click
        If _tabela <> "" Then
            Try
                Open_MyConnection()

                Dim rs As New ADODB.Recordset
                rs = Otvori_RS("select * from " & _tabela)

                With rs
                    If .State = 1 Then
                        Dim _jkl As String = ""
                        Dim _atc As String = ""
                        Dim _inn As String = ""
                        Dim i As Integer = 0

                        .MoveFirst()
                        For i = 0 To .RecordCount - 1
                            If .Fields("ATC").Value.ToString <> "" Then
                                If .Fields("ATC").Value.ToString <> _atc Then
                                    _atc = .Fields("ATC").Value.ToString
                                    _inn = .Fields("INN").Value.ToString
                                    snimi_genIme(_atc, _inn)
                                End If
                            End If
                            .MoveNext()
                        Next
                    End If
                End With
                rs.Close()

                Close_MyConnection()
                MsgBox("Uspesno prebaceni podaci", MsgBoxStyle.OkOnly)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly)
            End Try
        End If

    End Sub
    Private Sub snimi_genIme(ByVal _atc, ByVal _inn)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        CM = New SqlCommand()
        With CM
            .Connection = CN
            .CommandType = CommandType.StoredProcedure
            .CommandText = "app_genericko_ime_add"
            .Parameters.AddWithValue("@genericko_sifra", _atc)
            .Parameters.AddWithValue("@genericko_ime", _inn)
            .ExecuteScalar()

        End With
        CM.Dispose()
        CN.Close()

    End Sub
    Private Sub txtTabela_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTabela.TextChanged
        If txtTabela.Text <> "" Then
            _tabela = txtTabela.Text
        Else
            _tabela = ""
        End If

    End Sub

    Private Sub btnL1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnL1.Click
        Dim CN As SqlConnection = New SqlConnection(CNN_PBS)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Try
            CN.Open()
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "SELECT * from dbo.Pozitivna_Lista"
                DR = .ExecuteReader()
            End With

            While DR.Read
                Dim _L1 As Boolean
                Dim _l1_od_datuma As Date
                Dim _l1_do_datuma As Date '= #0/0/0000 #
                Dim _kompletno As Boolean

                selektuj_artikl(RTrim(DR.Item("Artikal_Sifra").ToString), Selekcija.po_sifri)

                _l1_od_datuma = DR.Item("Datum_Vazenja_OD").ToString

                If IsDBNull(DR.Item("Datum_Vazenja_DO")) Then
                    _L1 = True
                    _kompletno = False ' "app_jkl_L1_add"
                Else
                    _L1 = False
                    _l1_do_datuma = DR.Item("Datum_Vazenja_DO")
                    _kompletno = True ' "app_jkl_L1_add_kompletno"
                End If

                snimi_L1(RTrim(_artikl_jkl), _L1, _l1_od_datuma, _l1_do_datuma, _kompletno)
            End While
            DR.Close()
            MsgBox("Uspesno prebaceni podaci", MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        Finally
            CM.Dispose()
            CN.Close()
        End Try
    End Sub
    Private Sub snimi_L1(ByVal _jkl, ByVal _l1, ByVal _od, ByVal _do, ByVal _kompletno)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        CM = New SqlCommand()
        With CM
            .Connection = CN
            .CommandType = CommandType.StoredProcedure
            If _kompletno = True Then
                .CommandText = "app_jkl_L1_add_kompletno"
                .Parameters.AddWithValue("@l1_datum_DO", _do)
            Else
                .CommandText = "app_jkl_L1_add"
            End If

            .Parameters.AddWithValue("@jkl_sifra", _jkl)
            .Parameters.AddWithValue("@L1", _l1)
            .Parameters.AddWithValue("@l1_datum_OD", _od)
            '.Parameters.AddWithValue("@l1_datum_DO", _do)

            .ExecuteScalar()
        End With
        CM.Dispose()
        CN.Close()

    End Sub

    Private Sub btnStara_uJKL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStara_uJKL.Click
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Try
            CN.Open()
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "SELECT * from dbo.rm_artikli"
                DR = .ExecuteReader()
            End With

            While DR.Read
                snimi_JKL(DR.Item("id_artikl"), DR.Item("artikl_sifra_stara"))
            End While
            DR.Close()
            MsgBox("Uspesno prebaceni podaci", MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        Finally
            CM.Dispose()
            CN.Close()
        End Try
    End Sub
    Private Sub snimi_JKL(ByVal _id, ByVal _jkl)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        CM = New SqlCommand()
        With CM
            .Connection = CN
            .CommandType = CommandType.StoredProcedure
            .CommandText = "_UPDATE"
            .Parameters.AddWithValue("@id_artikl", _id)
            .Parameters.AddWithValue("@jkl", _jkl)
            .ExecuteScalar()
        End With
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub btnDuplikati_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDuplikati.Click
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Try
            CN.Open()
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "SELECT * from dbo.app_genericko_ime"
                DR = .ExecuteReader()
            End With

            While DR.Read
                brisi_duplikate(RTrim(DR.Item("genericko_sifra")))
            End While
            DR.Close()
            MsgBox("Uspesno obrisani duplikati", MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        Finally
            CM.Dispose()
            CN.Close()
        End Try
    End Sub
    Private Sub brisi_duplikate(ByVal _sifra)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim i As Integer = 0

        Try
            CN.Open()
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "SELECT * from dbo.app_genericko_ime where dbo.app_genericko_ime.genericko_sifra = '" & _sifra & "'"
                DR = .ExecuteReader()
            End With

            While DR.Read
                If i > 0 Then
                    brisi(DR.Item("id_genericko"))
                End If
                i += 1
            End While
            DR.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        Finally
            CM.Dispose()
            CN.Close()
        End Try
    End Sub
    Private Sub brisi(ByVal _id)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "app_genericko_ime_delete"
                .Parameters.AddWithValue("@id_genericko", _id)
                .ExecuteScalar()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        Finally
            CM.Dispose()
            CN.Close()
        End Try
    End Sub

    Private Sub btnJkl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJkl.Click
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Try
            CN.Open()
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "SELECT * from dbo.rm_artikli"
                DR = .ExecuteReader()
            End With

            While DR.Read
                If RTrim(DR.Item("jkl").ToString) <> "" And Len(RTrim(DR.Item("jkl").ToString)) < 7 Then
                    brisi_JKL(DR.Item("id_artikl"))
                ElseIf RTrim(DR.Item("jkl").ToString) Like "999999*" Then
                    brisi_JKL(DR.Item("id_artikl"))
                End If

            End While
            DR.Close()
            MsgBox("Uspesno obrisani duplikati", MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        Finally
            CM.Dispose()
            CN.Close()
        End Try
    End Sub
    Private Sub brisi_JKL(ByVal _id)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        CM = New SqlCommand()
        With CM
            .Connection = CN
            .CommandType = CommandType.StoredProcedure
            .CommandText = "rm_artikli_update_jkl"
            .Parameters.AddWithValue("@id_artikl", _id)
            .Parameters.AddWithValue("@jkl", "")
            .ExecuteScalar()
        End With
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer = 0
        Dim ulozeno As Single = 0

        For i = 1 To 20
            ulozeno = (ulozeno * 1.02) + TextBox1.Text
        Next
        TextBox2.Text = ulozeno
    End Sub


End Class
