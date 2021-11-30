Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmPutniRacunEdit
    Private _dani As Integer = 0
    Private _sati As Integer = 0
    Private _datum_od As Date = Today
    Private _datum_do As Date = Today
    Private _sati_od As Integer = 0
    Private _sati_do As Integer = 0
    Private _dnevnica As Single = 0
    Private _svega_dnevnice As Single = 0
    Private _svega_prevoz As Single = 0
    Private _svega_ostalo As Single = 0
    Private _broj_priloga As Integer = 0
    Private _prevoz1 As Single = 0
    Private _prevoz2 As Single = 0
    Private _prevoz3 As Single = 0
    Private _prevoz4 As Single = 0
    Private _prevoz5 As Single = 0
    Private _ostalo1 As Single = 0
    Private _ostalo2 As Single = 0
    Private _ostalo3 As Single = 0


    Private Sub frmPutniRacunEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()
    End Sub

    Private Sub pocetak()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.fn_putni_nalog.* from dbo.putni_nalog where dbo.fn_putni_nalog.id_pnalog = " & _id_pnalog
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            _pnalog_akontacija = 0
            _pnalog_broj = 0

            Do While DR.Read
                If Not IsDBNull(DR.Item("broj")) Then _pnalog_broj = DR.Item("broj")
                If Not IsDBNull(DR.Item("akontacija")) Then _pnalog_akontacija = DR.Item("akontacija")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()

        selektuj_putni_racun_prevoz(_id_pnalog)
        selektuj_putni_racun_ostalo(_id_pnalog)

        txtAkontacija.Text = _pnalog_akontacija
        txtBroj.Text = _pnalog_broj 'Nadji_rb(Imena.tabele.fn_putni_racun.ToString)
        txtBrCasova.Text = _pnalog_broj_sati
        txtBrDnevnica.Text = _pnalog_broj_dnevnica
        txtDnevDinara.Text = _pnalog_dinara
        txtDnevSvega.Text = _pnalog_svega_dnevnica
        txtOdlazakCasova.Text = _pnalog_odlazak_sat
        'txtOstalo1.Text = ""
        'txtOstalo2.Text = ""
        'txtOstalo3.Text = ""
        'txtOstaloDin1.Text = 0
        'txtOstaloDin2.Text = 0
        'txtOstaloDin3.Text = 0
        'txtOstaloSvega1.Text = 0
        'txtOstaloSvega2.Text = 0
        'txtOstaloSvega3.Text = 0
        txtPovratakCasova.Text = _pnalog_povratak_sat
        txtPreostalo.Text = _pnalog_za_isplatu
        'txtPrevozDin1.Text = 0
        'txtPrevozDin2.Text = 0
        'txtPrevozDin3.Text = 0
        'txtPrevozDin4.Text = 0
        'txtPrevozDin5.Text = 0
        'txtPrevozDo1.Text = ""
        'txtPrevozDo2.Text = ""
        'txtPrevozDo3.Text = ""
        'txtPrevozDo4.Text = ""
        'txtPrevozDo5.Text = ""
        'txtPrevozKm1.Text = 0
        'txtPrevozKm2.Text = 0
        'txtPrevozKm3.Text = 0
        'txtPrevozKm4.Text = 0
        'txtPrevozKm5.Text = 0
        'txtPrevozOd1.Text = ""
        'txtPrevozOd2.Text = ""
        'txtPrevozOd3.Text = ""
        'txtPrevozOd4.Text = ""
        'txtPrevozOd5.Text = ""
        'txtPrevozVrsta1.Text = ""
        'txtPrevozVrsta2.Text = ""
        'txtPrevozVrsta3.Text = ""
        'txtPrevozVrsta4.Text = ""
        'txtPrevozVrsta5.Text = ""
        txtSvega.Text = _pnalog_svega

        dateOdlazak.Value = _pnalog_odlazak
        datePovratak.Value = _pnalog_povratak

        labBrPriloga.Text = _pnalog_broj_priloga

    End Sub

    Private Sub selektuj_putni_racun_prevoz(ByVal _bukmark)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.putni_racun_prevoz.* from dbo.putni_racun_prevoz where dbo.putni_racun_prevoz.id_putni_nalog = " & _bukmark
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            _pn_racun_prevoz = New Integer() {}
            ReDim _pn_racun_prevoz(24)
            Dim i As Integer = 0
            Dim mText As Control

            Do While DR.Read
                For Each mText In grpPrevoz.Controls
                    Select Case mText.Name
                        Case "txtPrevozOd" & i + 1
                            If Not IsDBNull(DR.Item("od")) Then mText.Text = DR.Item("od").ToString
                        Case "txtPrevozDo" & i + 1
                            If Not IsDBNull(DR.Item("do")) Then mText.Text = DR.Item("do")
                        Case "txtPrevozVrsta" & i + 1
                            If Not IsDBNull(DR.Item("vrsta")) Then mText.Text = DR.Item("vrsta")
                        Case "txtPrevozKm" & i + 1
                            If Not IsDBNull(DR.Item("km")) Then mText.Text = DR.Item("km")
                        Case "txtPrevozDin" & i + 1
                            If Not IsDBNull(DR.Item("dinara")) Then mText.Text = DR.Item("dinara")
                    End Select
                Next
                _pn_racun_prevoz.SetValue(DR.Item("id_pr_prevoz"), i)
                i += 1
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub selektuj_putni_racun_ostalo(ByVal _bukmark)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader


        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.putni_racun_ostalo.* from dbo.putni_racun_ostalo where dbo.putni_racun_ostalo.id_putni_nalog = " & _bukmark
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            _pn_racun_ostalo = New Integer() {}
            ReDim _pn_racun_ostalo(9)
            Dim i As Integer = 0
            Dim mText As Control

            Do While DR.Read
                For Each mText In GroupBox2.Controls
                    Select Case mText.Name
                        Case "txtOstalo" & i + 1
                            If Not IsDBNull(DR.Item("opis")) Then mText.Text = DR.Item("opis")
                        Case "txtOstaloDin" & i + 1
                            If Not IsDBNull(DR.Item("dinara")) Then mText.Text = DR.Item("dinara")
                        Case "txtOstaloSvega" & i + 1
                            If Not IsDBNull(DR.Item("svega")) Then mText.Text = DR.Item("svega")
                    End Select

                Next
                _pn_racun_ostalo.SetValue(DR.Item("id_pr_ostalo"), i)
                i += 1
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Select Case e.ClickedItem.Name
            Case "tlbSnimi"
                snimi_racun()
                snimi_racun_prevoz()
                snimi_racun_ostalo()
                update_nalog()
                'Me.Dispose()
                'pocetak()
            Case "tlbEnd"
                Me.Dispose()
        End Select
    End Sub

    Private Sub snimi_racun()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        'Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "fn_putni_racun_update"
                .Parameters.AddWithValue("@id_putni_racun", _id_putni_racun)
                .Parameters.AddWithValue("@odlazak", dateOdlazak.Value.Date)
                .Parameters.AddWithValue("@odlazak_sat", txtOdlazakCasova.Text)
                .Parameters.AddWithValue("@povratak", datePovratak.Value.Date)
                .Parameters.AddWithValue("@povratak_sat", txtPovratakCasova.Text)
                .Parameters.AddWithValue("@broj_sati", CInt(txtBrCasova.Text))
                .Parameters.AddWithValue("@broj_dnevnica", CInt(txtBrDnevnica.Text))
                .Parameters.AddWithValue("@dinara", CInt(txtDnevDinara.Text))
                .Parameters.AddWithValue("@svega_dnevnica", CInt(txtDnevSvega.Text))
                .Parameters.AddWithValue("@svega", CDec(txtSvega.Text))
                .Parameters.AddWithValue("@akontacija", CDec(txtAkontacija.Text))
                .Parameters.AddWithValue("@za_isplatu", CDec(txtPreostalo.Text))
                .Parameters.AddWithValue("@broj_priloga", CDec(labBrPriloga.Text))
                .Parameters.AddWithValue("@u", "Nišu")
                .Parameters.AddWithValue("@dana", CDate(Today))
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub snimi_racun_prevoz()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        'Dim DR As SqlDataReader
        Dim i As Integer = 0
        Dim _prevoz() As String
        Dim mText As Control

        _prevoz = New String() {}
        ReDim _prevoz(24)

        For i = 0 To 4
            For Each mText In grpPrevoz.Controls
                Select Case mText.Name
                    Case "txtPrevozOd" & i + 1
                        _prevoz.SetValue(mText.Text, i * 5)
                    Case "txtPrevozDo" & i + 1
                        _prevoz.SetValue(mText.Text, (i * 5) + 1)
                    Case "txtPrevozVrsta" & i + 1
                        _prevoz.SetValue(mText.Text, (i * 5) + 2)
                    Case "txtPrevozKm" & i + 1
                        _prevoz.SetValue(mText.Text, (i * 5) + 3)
                    Case "txtPrevozDin" & i + 1
                        _prevoz.SetValue(mText.Text, (i * 5) + 4)
                End Select
            Next
        Next

        CN.Open()
        If CN.State = ConnectionState.Open Then
            For i = 0 To 4 '_prevoz.Length - 1
                If _prevoz(i * 5) <> "" And _pn_racun_prevoz(i) <> 0 Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "fn_putni_racun_prevoz_update"
                        .Parameters.AddWithValue("@id_pr_prevoz", _pn_racun_prevoz(i))
                        .Parameters.AddWithValue("@od", _prevoz(i * 5))
                        .Parameters.AddWithValue("@do", _prevoz((i * 5) + 1))
                        .Parameters.AddWithValue("@vrsta", _prevoz((i * 5) + 2))
                        .Parameters.AddWithValue("@km", CDec(_prevoz((i * 5) + 3)))
                        .Parameters.AddWithValue("@dinara", CDec(_prevoz((i * 5) + 4)))
                        .ExecuteScalar()
                    End With
                    CM.Dispose()
                Else
                    If _prevoz(i * 5) <> "" And _pn_racun_prevoz(i) = 0 Then
                        CM = New SqlCommand()
                        With CM
                            .Connection = CN
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "fn_putni_racun_prevoz_add"
                            .Parameters.AddWithValue("@id_putni_nalog", _id_pnalog)
                            .Parameters.AddWithValue("@od", _prevoz(i * 5))
                            .Parameters.AddWithValue("@do", _prevoz((i * 5) + 1))
                            .Parameters.AddWithValue("@vrsta", _prevoz((i * 5) + 2))
                            .Parameters.AddWithValue("@km", CDec(_prevoz((i * 5) + 3)))
                            .Parameters.AddWithValue("@dinara", CDec(_prevoz((i * 5) + 4)))
                            .ExecuteScalar()
                        End With
                        CM.Dispose()
                    Else
                        If _prevoz(i * 5) = "" And _pn_racun_prevoz(i) <> 0 Then
                            CM = New SqlCommand()
                            With CM
                                .Connection = CN
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "fn_putni_racun_prevoz_delete"
                                .Parameters.AddWithValue("@id_pr_prevoz", _pn_racun_prevoz(i))
                                .ExecuteScalar()
                            End With
                            CM.Dispose()
                        End If
                    End If
                End If
            Next
        End If
        CN.Close()
    End Sub

    Private Sub snimi_racun_ostalo()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        'Dim DR As SqlDataReader
        Dim i As Integer = 0
        Dim _ostalo() As String
        Dim mText As Control

        _ostalo = New String() {}
        ReDim _ostalo(9)

        For i = 0 To 8
            For Each mText In GroupBox2.Controls
                Select Case mText.Name
                    Case "txtOstalo" & i + 1
                        _ostalo.SetValue(mText.Text, i * 3)
                    Case "txtOstaloDin" & i + 1
                        _ostalo.SetValue(mText.Text, (i * 3) + 1)
                    Case "txtOstaloSvega" & i + 1
                        _ostalo.SetValue(mText.Text, (i * 3) + 2)
                End Select
            Next
        Next

        CN.Open()
        If CN.State = ConnectionState.Open Then
            For i = 0 To 3 '_ostalo.Length - 1
                If _ostalo(i * 3) <> "" And _pn_racun_ostalo(i) <> 0 Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "fn_putni_racun_ostalo_update"
                        .Parameters.AddWithValue("@id_pr_ostalo", _pn_racun_ostalo(i))
                        .Parameters.AddWithValue("@opis", _ostalo(i * 3))
                        .Parameters.AddWithValue("@dinara", CDec(_ostalo((i * 3) + 1)))
                        .Parameters.AddWithValue("@svega", CDec(_ostalo((i * 3) + 2)))
                        .ExecuteScalar()
                    End With
                    CM.Dispose()
                Else
                    If _ostalo(i * 3) <> "" And _pn_racun_ostalo(i) = 0 Then
                        CM = New SqlCommand()
                        With CM
                            .Connection = CN
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "fn_putni_racun_ostalo_add"
                            .Parameters.AddWithValue("@id_putni_nalog", _id_pnalog)
                            .Parameters.AddWithValue("@opis", _ostalo(i * 3))
                            .Parameters.AddWithValue("@dinara", CDec(_ostalo((i * 3) + 1)))
                            .Parameters.AddWithValue("@svega", CDec(_ostalo((i * 3) + 2)))
                            .ExecuteScalar()
                        End With
                        CM.Dispose()
                    Else
                        If _ostalo(i * 3) = "" And _pn_racun_ostalo(i) <> 0 Then
                            CM = New SqlCommand()
                            With CM
                                .Connection = CN
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "fn_putni_racun_ostalo_delete"
                                .Parameters.AddWithValue("@id_pr_ostalo", _pn_racun_ostalo(i))
                                .ExecuteScalar()
                            End With
                            CM.Dispose()
                        End If
                    End If
                End If
            Next
        End If
        CN.Close()
    End Sub

    Private Sub update_nalog()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        'Dim DR As SqlDataReader

        CN.Open()

        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "fn_putni_nalog_racun"
                .Parameters.AddWithValue("@id_pnalog", _id_pnalog)
                .Parameters.AddWithValue("@racun", 1)
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If
        CN.Close()
    End Sub

#Region "dnevnice"

    Private Sub dateOdlazak_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateOdlazak.ValueChanged
        _datum_od = dateOdlazak.Value.Date
        dnevnice()
    End Sub

    Private Sub datePovratak_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datePovratak.ValueChanged
        _datum_do = datePovratak.Value.Date
        dnevnice()
    End Sub

    Private Sub txtOdlazakCasova_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOdlazakCasova.TextChanged
        If txtOdlazakCasova.Text <> "" And jeste_broj(txtOdlazakCasova.Text) Then
            _sati_od = CInt(txtOdlazakCasova.Text)
        Else
            _sati_od = 0
        End If
        dnevnice()
    End Sub

    Private Sub txtPovratakCasova_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPovratakCasova.TextChanged
        If txtPovratakCasova.Text <> "" And jeste_broj(txtPovratakCasova.Text) Then
            _sati_do = CInt(txtPovratakCasova.Text)
        Else
            _sati_do = 0
        End If
        dnevnice()
    End Sub

    Private Sub txtDnevDinara_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDnevDinara.TextChanged
        If txtDnevDinara.Text <> "" And jeste_broj(txtDnevDinara.Text) Then
            _dnevnica = CInt(txtDnevDinara.Text)
        Else
            _dnevnica = 0
        End If
        dnevnice()
    End Sub

    Private Sub dnevnice()

        If _datum_od <> _datum_do Then
            If _sati_od <> 0 Or _sati_do <> 0 Then
                _sati = DateDiff(DateInterval.Hour, _datum_od, _datum_do) - _sati_od + _sati_do '- 24
            Else
                _sati = DateDiff(DateInterval.Hour, _datum_od, _datum_do)
            End If
        Else
            _sati = _sati_do - _sati_od
        End If


        If (_sati / 24) - (_sati \ 24) <> 0 Then
            txtBrDnevnica.Text = (_sati \ 24) + 1
        Else
            txtBrDnevnica.Text = (_sati \ 24)
        End If

        txtBrCasova.Text = _sati
        txtDnevSvega.Text = CInt(txtBrDnevnica.Text) * _dnevnica
        _svega_dnevnice = CInt(txtBrDnevnica.Text) * _dnevnica
        svega()
    End Sub

#End Region


    Private Sub svega()
        txtSvega.Text = Format(_svega_dnevnice + _svega_prevoz + _svega_ostalo, "##,##0.00")
        txtPreostalo.Text = Format(_svega_dnevnice + _svega_prevoz + _svega_ostalo - _pnalog_akontacija, "##,##0.00")
    End Sub

#Region "prevoz"

    Private Sub txtPrevozDin1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrevozDin1.TextChanged
        If txtPrevozDin1.Text <> "" And jeste_broj(txtPrevozDin1.Text) Then
            _prevoz1 = CInt(txtPrevozDin1.Text)
        Else
            _prevoz1 = 0
        End If
        svega_prevoz()
    End Sub

    Private Sub txtPrevozDin2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrevozDin2.TextChanged
        If txtPrevozDin2.Text <> "" And jeste_broj(txtPrevozDin2.Text) Then
            _prevoz2 = CInt(txtPrevozDin2.Text)
        Else
            _prevoz2 = 0
        End If
        svega_prevoz()
    End Sub

    Private Sub txtPrevozDin3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrevozDin3.TextChanged
        If txtPrevozDin3.Text <> "" And jeste_broj(txtPrevozDin3.Text) Then
            _prevoz3 = CInt(txtPrevozDin3.Text)
        Else
            _prevoz3 = 0
        End If
        svega_prevoz()
    End Sub

    Private Sub txtPrevozDin4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrevozDin4.TextChanged
        If txtPrevozDin4.Text <> "" And jeste_broj(txtPrevozDin4.Text) Then
            _prevoz4 = CInt(txtPrevozDin4.Text)
        Else
            _prevoz4 = 0
        End If
        svega_prevoz()
    End Sub

    Private Sub txtPrevozDin5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrevozDin5.TextChanged
        If txtPrevozDin5.Text <> "" And jeste_broj(txtPrevozDin5.Text) Then
            _prevoz5 = CInt(txtPrevozDin5.Text)
        Else
            _prevoz5 = 0
        End If
        svega_prevoz()
    End Sub

    Private Sub svega_prevoz()
        _svega_prevoz = _prevoz1 + _prevoz2 + _prevoz3 + _prevoz4 + _prevoz5
        svega()
    End Sub

#End Region

#Region "ostalo"

    Private Sub txtOstaloSvega1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOstaloSvega1.TextChanged
        If txtOstaloSvega1.Text <> "" And jeste_broj(txtOstaloSvega1.Text) Then
            _ostalo1 = CInt(txtOstaloSvega1.Text)
        Else
            _ostalo1 = 0
        End If
        svega_ostalo()
    End Sub

    Private Sub txtOstaloSvega2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOstaloSvega2.TextChanged
        If txtOstaloSvega2.Text <> "" And jeste_broj(txtOstaloSvega2.Text) Then
            _ostalo2 = CInt(txtOstaloSvega2.Text)
        Else
            _ostalo2 = 0
        End If
        svega_ostalo()
    End Sub

    Private Sub txtOstaloSvega3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOstaloSvega3.TextChanged
        If txtOstaloSvega3.Text <> "" And jeste_broj(txtOstaloSvega3.Text) Then
            _ostalo3 = CInt(txtOstaloSvega3.Text)
        Else
            _ostalo3 = 0
        End If
        svega_ostalo()
    End Sub

    Private Sub svega_ostalo()
        _svega_ostalo = _ostalo1 + _ostalo2 + _ostalo3
        svega()
    End Sub

#End Region

#Region "broj priloga"

    Dim prilog1 As Boolean = False
    Private Sub txtPrevozOd1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrevozOd1.TextChanged
        If txtPrevozOd1.Text <> "" And Not prilog1 Then
            prilog1 = True
        ElseIf txtPrevozOd1.Text = "" Then
            prilog1 = False
        End If
        broj_priloga()
    End Sub

    Dim prilog2 As Boolean = False
    Private Sub txtPrevozOd2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrevozOd2.TextChanged
        If txtPrevozOd2.Text <> "" And Not prilog2 Then
            prilog2 = True
        ElseIf txtPrevozOd2.Text = "" Then
            prilog2 = False
        End If
        broj_priloga()
    End Sub

    Dim prilog3 As Boolean = False
    Private Sub txtPrevozOd3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrevozOd3.TextChanged
        If txtPrevozOd3.Text <> "" And Not prilog3 Then
            prilog3 = True
        ElseIf txtPrevozOd3.Text = "" Then
            prilog3 = False
        End If
        broj_priloga()
    End Sub

    Dim prilog4 As Boolean = False
    Private Sub txtPrevozOd4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrevozOd4.TextChanged
        If txtPrevozOd4.Text <> "" And Not prilog4 Then
            prilog4 = True
        ElseIf txtPrevozOd4.Text = "" Then
            prilog4 = False
        End If
        broj_priloga()
    End Sub

    Dim prilog5 As Boolean = False
    Private Sub txtPrevozOd5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrevozOd5.TextChanged
        If txtPrevozOd5.Text <> "" And Not prilog5 Then
            prilog5 = True
        ElseIf txtPrevozOd5.Text = "" Then
            prilog5 = False
        End If
        broj_priloga()
    End Sub

    Dim prilog6 As Boolean = False
    Private Sub txtOstalo1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOstalo1.TextChanged
        If txtOstalo1.Text <> "" And Not prilog6 Then
            prilog6 = True
        ElseIf txtOstalo1.Text = "" Then
            prilog6 = False
        End If
        broj_priloga()
    End Sub

    Dim prilog7 As Boolean = False
    Private Sub txtOstalo2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOstalo2.TextChanged
        If txtOstalo2.Text <> "" And Not prilog7 Then
            prilog7 = True
        ElseIf txtOstalo2.Text = "" Then
            prilog7 = False
        End If
        broj_priloga()
    End Sub

    Dim prilog8 As Boolean = False
    Private Sub txtOstalo3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOstalo3.TextChanged
        If txtOstalo3.Text <> "" And Not prilog8 Then
            prilog8 = True
        ElseIf txtOstalo3.Text = "" Then
            prilog8 = False
        End If
        broj_priloga()
    End Sub

    Private Sub broj_priloga()
        _broj_priloga = 0
        If prilog1 Then _broj_priloga += 1
        If prilog2 Then _broj_priloga += 1
        If prilog3 Then _broj_priloga += 1
        If prilog4 Then _broj_priloga += 1
        If prilog5 Then _broj_priloga += 1
        If prilog6 Then _broj_priloga += 1
        If prilog7 Then _broj_priloga += 1
        If prilog8 Then _broj_priloga += 1
        labBrPriloga.Text = _broj_priloga
    End Sub
#End Region

End Class