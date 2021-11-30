Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmPotvrdaEdit
    Private sifra As String = ""
    Private naziv As String = ""

    Private _pocetak As Boolean = True
    Private Sub frmPotvrdaEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataSet1.rm_artikli' table. You can move, or remove it, as needed.
        Me.Rm_artikliTableAdapter.Fill(Me.DataSet1.rm_artikli)

        pocetak()
        _pocetak = False
        popuni_stavke()
        selektuj_izvrsioce()

        If _izdat Then zatvori_formu()

    End Sub

    Private Sub pocetak()
        txtSifra.Text = _broj
        txtSifra.Enabled = False
        labNaloga.Text = "Ispravka Potvrde za Nalog broj: " & _broj
        txtNapomene.Text = _napomene
     
        chkIspitivanje.Checked = _ispitivanje
        chkIspitivanjeEnd.Checked = _ispitivanje_end
        chkMontaza.Checked = _montaza
        chkMontazaEnd.Checked = _montaza_end
        chkPopravka.Checked = _popravka
        chkPopravkaEnd.Checked = _popravka_end
        chkServisiranje.Checked = _servis
        chkServisiranjeEnd.Checked = _servis_end
        chkUgovor.Checked = _ugovor
        chkUgovorEnd.Checked = _ugovor_end

        dateMontaza.Value = _montaza_datum
        dateIspitivanje.Value = _ispitivanje_datum
        datePopravka.Value = _popravka_datum
        dateServis.Value = _servis_datum
        dateUgovor.Value = _ugovor_datum

    End Sub

    Private Sub snimi_head()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        'Dim DR As SqlDataReader

        Try
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "rm_radni_nalog_potvrda_update"
                    .Parameters.AddWithValue("@id_radninalog_potvrda", _id_radni_nalog_potvrda)
                    .Parameters.AddWithValue("@id_radninalog", _id_radni_nalog)
                    .Parameters.AddWithValue("@broj", _broj)
                    .Parameters.AddWithValue("@montaza", chkMontaza.CheckState)
                    .Parameters.AddWithValue("@montaza_end", chkMontazaEnd.CheckState)
                    .Parameters.AddWithValue("@montaza_datum", dateMontaza.Value.Date)
                    .Parameters.AddWithValue("@popravka", chkPopravka.CheckState)
                    .Parameters.AddWithValue("@popravka_end", chkPopravkaEnd.CheckState)
                    .Parameters.AddWithValue("@popravka_datum", datePopravka.Value.Date)
                    .Parameters.AddWithValue("@servis", chkServisiranje.CheckState)
                    .Parameters.AddWithValue("@servis_end", chkServisiranjeEnd.CheckState)
                    .Parameters.AddWithValue("@servis_datum", dateServis.Value.Date)
                    .Parameters.AddWithValue("@ispitivanje", chkIspitivanje.CheckState)
                    .Parameters.AddWithValue("@ispitivanje_end", chkIspitivanjeEnd.CheckState)
                    .Parameters.AddWithValue("@ispitivanje_datum", dateIspitivanje.Value.Date)
                    .Parameters.AddWithValue("@ugovor", chkUgovor.CheckState)
                    .Parameters.AddWithValue("@ugovor_end", chkUgovorEnd.CheckState)
                    .Parameters.AddWithValue("@ugovor_datum", dateUgovor.Value.Date)
                    .Parameters.AddWithValue("@napomene", txtNapomene.Text)
                    .ExecuteScalar()
                End With
            End If
            CM.Dispose()
            CN.Close()
            'povezi_sanalogom()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub snimi_stavku()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim i, n As Integer

        CN.Open()
        If _id_radni_nalog_materijal.Length > dgStavke.Rows.Count - 1 Then
            n = _id_radni_nalog_materijal.Length - 1
        Else
            n = dgStavke.Rows.Count - 2
        End If

        For i = 0 To n
            If (i <= dgStavke.Rows.Count - 2 Or Not _id_radni_nalog_materijal.Length > dgStavke.Rows.Count - 1) Or _id_radni_nalog_materijal.Length = 0 Then
                If i > _id_radni_nalog_materijal.Length - 1 Then '_id_racun_stavka(i) = 0 Then
                    CM = New SqlCommand()
                    If CN.State = ConnectionState.Open Then
                        With CM
                            .Connection = CN
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "rm_radni_nalog_potvrda_stavka_add"
                            .Parameters.AddWithValue("@id_radninalog_potvrda", _id_radni_nalog_potvrda) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                            .Parameters.AddWithValue("@rb", dgStavke.Rows(i).Cells(0).Value)
                            .Parameters.AddWithValue("@materijal", dgStavke.Rows(i).Cells(1).Value)
                            .Parameters.AddWithValue("@kolicina", dgStavke.Rows(i).Cells(2).Value)
                            .ExecuteScalar()
                        End With
                    End If
                    CM.Dispose()
                Else
                    CM = New SqlCommand()
                    If CN.State = ConnectionState.Open Then
                        With CM
                            .Connection = CN
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "rm_radni_nalog_potvrda_stavka_update"
                            .Parameters.AddWithValue("@id_potvrda_stavka", _id_radni_nalog_materijal(i)) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                            .Parameters.AddWithValue("@rb", dgStavke.Rows(i).Cells(0).Value)
                            .Parameters.AddWithValue("@materijal", dgStavke.Rows(i).Cells(1).Value)
                            .Parameters.AddWithValue("@kolicina", dgStavke.Rows(i).Cells(2).Value)
                            .ExecuteScalar()
                        End With
                    End If
                    CM.Dispose()
                End If
            Else
                CM = New SqlCommand()
                If CN.State = ConnectionState.Open Then
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "rm_radni_nalog_potvrda_stavka_delete"
                        .Parameters.AddWithValue("@id_potvrda_stavka", _id_radni_nalog_materijal(i)) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                        .ExecuteScalar()
                    End With
                End If
                CM.Dispose()
            End If
        Next
        CN.Close()
    End Sub

    Private Sub snimi_izvrsioce()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim i As Integer
        Dim izvrsioc As String = ""
        Dim posao As String = ""
        Dim ctrl As Control

        For i = 1 To 6
            For Each ctrl In layoutPanel3.Controls ' Controls
                If TypeOf (ctrl) Is TextBox Then
                    Select Case ctrl.Name
                        Case "txtIzvrsilac" & i
                            izvrsioc = ctrl.Text
                        Case "txtPosao" & i
                            posao = ctrl.Text
                    End Select
                    If i = 1 Then posao = "Nosioc posla"
                End If
            Next
            If izvrsioc <> "" And posao <> "" Then
                If _id_radni_nalog_izvrsioci(i) = 0 Then
                    CN.Open()
                    CM = New SqlCommand()
                    If CN.State = ConnectionState.Open Then
                        With CM
                            .Connection = CN
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "rm_radni_nalog_izvrsioci_add"
                            .Parameters.AddWithValue("@id_radninalog_potvrda", _id_radni_nalog_potvrda)
                            .Parameters.AddWithValue("@rb", i)
                            .Parameters.AddWithValue("@izvrsioc", izvrsioc)
                            .Parameters.AddWithValue("@posao", posao)
                            .ExecuteScalar()
                        End With
                    End If
                    CM.Dispose()
                    CN.Close()
                Else
                    CN.Open()
                    CM = New SqlCommand()
                    If CN.State = ConnectionState.Open Then
                        With CM
                            .Connection = CN
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "rm_radni_nalog_izvrsioci_update"
                            .Parameters.AddWithValue("@id_izvrsioci", _id_radni_nalog_izvrsioci(i))
                            .Parameters.AddWithValue("@id_radninalog_potvrda", _id_radni_nalog_potvrda)
                            .Parameters.AddWithValue("@rb", i)
                            .Parameters.AddWithValue("@izvrsioc", izvrsioc)
                            .Parameters.AddWithValue("@posao", posao)
                            .ExecuteScalar()
                        End With
                    End If
                    CM.Dispose()
                    CN.Close()
                End If
                izvrsioc = ""
                posao = ""
            End If
        Next
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Select Case e.ClickedItem.Name
            Case "tlbSnimi"
                snimi_head()
                snimi_stavku()
                snimi_izvrsioce()
                'pocetak()
                dgStavke.Rows.Clear()
                popuni_stavke()
            Case "tlbStanje"
                stanje()
                proveri_stanje(_nazivi, dgStavke.Rows.Count - 1)
            Case "tlbIzdaj"
                stanje()
                izdaj_robu(_nazivi, dgStavke.Rows.Count - 1)
                izdat()
            Case "tlbEnd"
                Me.Dispose()
        End Select
    End Sub

    Private Sub stanje()
        Dim i As Integer
        For i = 0 To dgStavke.Rows.Count - 2
            _nazivi.SetValue(dgStavke.Rows(i).Cells(1).Value.ToString, i, 0)
            _nazivi.SetValue(dgStavke.Rows(i).Cells(3).Value.ToString, i, 1)
        Next
    End Sub

    Private Sub izdat()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_radni_nalog_potvrda_izdaj"
                .Parameters.AddWithValue("@id_radninalog_potvrda", _id_radni_nalog_potvrda)
                .Parameters.AddWithValue("@izdata", True)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
        _izdat = True
        zatvori_formu()
    End Sub

    Private Sub zatvori_formu()
        If _izdat Then
            Panel1.Enabled = False
            dgStavke.AllowUserToAddRows = False
            dgStavke.Enabled = False

            ToolStrip1.Items(0).Enabled = False
            ToolStrip1.Items(1).Enabled = False
            ToolStrip1.Items(2).Enabled = False

            txtNapomene.Enabled = False
            'txtIzvrsilac1.Enabled = False
            'txtIzvrsilac2.Enabled = False
            'txtIzvrsilac3.Enabled = False
            'txtIzvrsilac4.Enabled = False
            'txtIzvrsilac5.Enabled = False
            'txtIzvrsilac6.Enabled = False
            'txtPosao1.Enabled = False
            'txtPosao2.Enabled = False
            'txtPosao3.Enabled = False
            'txtPosao4.Enabled = False
            'txtPosao5.Enabled = False
            'txtSifra.Enabled = False
            'dateIspitivanje.Enabled = False
            'dateMontaza.Enabled = False
            'datePopravka.Enabled = False
            'datePreventiva.Enabled = False
            'dateServis.Enabled = False

            layoutPanel1.Enabled = False
            layoutPanel2.Enabled = False
            layoutPanel3.Enabled = False
        End If
    End Sub

#Region "Grid 1"
    Private Sub dgStavke_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgStavke.MouseHover
        If dgStavke.CurrentRow.Displayed Then

            popuni_robu(RTrim(dgStavke.CurrentRow.Cells(1).Value.ToString))
            'dgStavke.CurrentRow.Tag = naziv
            dgStavke.CurrentRow.Cells(1).ToolTipText = naziv
        End If
    End Sub

    Private Sub dgStavke_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgStavke.CellValueChanged
        If Not _pocetak Then
            With dgStavke
                Try
                    '.Rows(e.RowIndex).Cells(0).Value = e.RowIndex + 1
                    redni_broj()

                    popuni_robu(RTrim(dgStavke.Rows(e.RowIndex).Cells(1).Value.ToString))
                    '.Rows(e.RowIndex).Cells(1).ToolTipText = naziv

                    If Not IsNothing(dgStavke.Rows(e.RowIndex).Cells(1).Value) Then
                        If dgStavke.Rows(e.RowIndex).Cells(1).Value.ToString <> "" Then
                            If IsNothing(dgStavke.Rows(e.RowIndex).Cells(2).Value) Then
                                dgStavke.Rows(e.RowIndex).Cells(2).Value = 1
                            Else
                                If dgStavke.Rows(e.RowIndex).Cells(2).Value.ToString = "" _
                                    Then dgStavke.Rows(e.RowIndex).Cells(2).Value = 1
                            End If
                        End If
                    End If
                    If Not IsNothing(dgStavke.Rows(e.RowIndex).Cells(2).Value) Then
                        If Not dgStavke.Rows(e.RowIndex).Cells(2).Value.ToString <> "" _
                            And Not jeste_broj(dgStavke.Rows(e.RowIndex).Cells(2).Value.ToString) _
                            Then dgStavke.Rows(e.RowIndex).Cells(2).Value = 1
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End With
        End If
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
    End Sub

#End Region

    Private Sub redni_broj()
        Dim i As Integer

        For i = 0 To dgStavke.RowCount - 2
            dgStavke.Rows(i).Cells(0).Value = i + 1
        Next
    End Sub

    Private Sub popuni_stavke()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.radni_nalog_potvrda_stavka.* " & _
                               "from dbo.radni_nalog_potvrda_stavka " & _
                               "where dbo.radni_nalog_potvrda_stavka.id_radninalog_potvrda = " & _id_radni_nalog_potvrda
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            _broj_stavki = 0
            Do While DR.Read
                _broj_stavki += 1
            Loop
            DR.Close()

            _id_radni_nalog_materijal = New Integer() {}
            ReDim _id_radni_nalog_materijal(_broj_stavki - 1)

            With dgStavke
                Dim i As Integer = 0
                DR = CM.ExecuteReader

                Do While DR.Read
                    .Rows.Add(1)
                    If Not IsDBNull(DR.Item("id_potvrda_stavka")) Then _id_radni_nalog_materijal.SetValue(DR.Item("id_potvrda_stavka"), i)
                    'If Not IsDBNull(DR.Item("rb")) Then .Rows(i).Cells(0).Value = DR.Item("rb")

                    If Not IsDBNull(DR.Item("materijal")) Then
                        popuni_robu(RTrim(DR.Item("materijal")))
                        If naziv <> "" Then
                            .Rows(i).Cells(1).Value = RTrim(naziv)
                        Else
                            .Rows(i).Cells(1).Value = DBNull.Value
                        End If
                    End If

                    'If Not IsDBNull(DR.Item("materijal")) Then .Rows(i).Cells(1).Value = DR.Item("materijal")
                    If Not IsDBNull(DR.Item("kolicina")) Then .Rows(i).Cells(2).Value = DR.Item("kolicina")
                    i += 1
                Loop
            End With
        End If

        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_robu(ByVal _roba As String)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli where naziv = '" & _roba & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                sifra = RTrim(DR.Item("sifra"))
                naziv = DR.Item("naziv")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub selektuj_izvrsioce()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.radni_nalog_izvrsioci.* from dbo.radni_nalog_izvrsioci where dbo.radni_nalog_izvrsioci.id_radninalog_potvrda = " & _id_radni_nalog_potvrda
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            _id_radni_nalog_izvrsioci = New Integer() {}
            ReDim _id_radni_nalog_izvrsioci(10)

            Dim i As Integer = 1
            Dim ctrl As Control
            Do While DR.Read
                If Not IsDBNull(DR.Item("id_izvrsioci")) Then _
                        _id_radni_nalog_izvrsioci.SetValue(DR.Item("id_izvrsioci"), i)

                For Each ctrl In layoutPanel3.Controls ' Controls
                    If TypeOf (ctrl) Is TextBox Then
                        Select Case ctrl.Name
                            Case "txtIzvrsilac" & i
                                ctrl.Text = DR.Item("izvrsioc")
                            Case "txtPosao" & i
                                ctrl.Text = DR.Item("posao")
                        End Select
                    End If
                Next
                i += 1
            Loop
        End If

        CM.Dispose()
        CN.Close()
    End Sub

End Class