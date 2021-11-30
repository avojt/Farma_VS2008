Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmIzvodiEdit

    Private ukupno_duguje As Single = 0
    Private ukupno_potrazuje As Single = 0
    Private saldo As Single = 0
    Private _staro_stanje As Single = 0
    Private _novo_stanje As Single = 0

    Private dug_pot As String = "d"
    Private indeks As Integer = 0
    Private broj_dok As String = ""
    Private id_dokt As Integer = 0
    Private vrsta_dok As Integer = 0
    Private id_part As Integer = 0
    Private za_naplatu As Single = 0

    Private _pocetak As Boolean = True
    Private _citam_stavke As Boolean = True
    Private sql As String = ""

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmIzvodiEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.app_partneri' table. You can move, or remove it, as needed.
        Me.PartneriTableAdapter.Fill(Me.DataSet1.app_partneri)
        'TODO: This line of code loads data into the 'DataSet1.fn_konta' table. You can move, or remove it, as needed.
        Me.KontaTableAdapter.Fill(Me.DataSet1.fn_konta)

        pocetak()
        _pocetak = False
        popuni_stavke()

    End Sub

    Private Sub pocetak()

        txtBroj.Text = _izvod_broj
        txtSvegaDuguje.Text = Format(_izvod_svega_duguje, 2)
        txtSvegaPotrazuje.Text = Format(_izvod_svega_potrazuje, 2)
        txtSaldo.Text = Format(_izvod_svega_duguje - _izvod_svega_potrazuje, 2)

        dateDatum.Value = _izvod_datum
        labProknjizen.Visible = False
        _pocetak = False

        txtStaroStanje.Text = Format(_izvod_stanje, 2)
        txtNovoStanje.Text = Format(_novo_stanje, 2)

        If _izvod_proknjizen Then
            zatvori_formu()
            labProknjizen.Visible = True
        End If

    End Sub

    Private Function staro_stanje() As Decimal
        If Not _pocetak Then
            Dim CN As SqlConnection = New SqlConnection(CNNString)
            Dim CM As New SqlCommand
            Dim DR As SqlDataReader

            CN.Open()
            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = "select dbo.fn_izvodi_head.* from dbo.fn_izvodi_head where dbo.fn_izvodi_head.broj = '" & CStr(CInt(txtBroj.Text) - 1) & "'"
                    DR = .ExecuteReader
                End With

                Do While DR.Read
                    staro_stanje = CDec(DR.Item("stanje"))
                Loop
                DR.Close()
                DR.Close()
                CM.Dispose()
            End If
            CN.Close()
        End If
    End Function

    Private Sub snimi_head()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "fn_izvodi_head_update"
                .Parameters.AddWithValue("@id_izvod", _id_izvod)
                .Parameters.AddWithValue("@broj", txtBroj.Text)
                .Parameters.AddWithValue("@datum", dateDatum.Value.Date)
                .Parameters.AddWithValue("@svega_duguje", CSng(txtSvegaDuguje.Text))
                .Parameters.AddWithValue("@svega_potrazuje", CSng(txtSvegaPotrazuje.Text))
                .Parameters.AddWithValue("@stanje", CSng(txtNovoStanje.Text))
                .Parameters.AddWithValue("@proknjizen", 0)
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If
        CN.Close()
    End Sub

    Private Sub snimi_stavku()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim i, n As Integer

        '_id_racun = Nadji_id(Imena.tabele.rm_racun_head.ToString)
        'dgStavke.Rows.GetFirstRow(0, 0)

        CN.Open()
        If _id_izvod_stavka.Length > dgStavke.Rows.Count - 1 Then
            n = _id_izvod_stavka.Length - 1
        Else
            n = dgStavke.Rows.Count - 2
        End If
        For i = 0 To n
            If (i <= dgStavke.Rows.Count - 2 Or Not _id_izvod_stavka.Length > dgStavke.Rows.Count - 1) Or _id_izvod_stavka.Length = 0 Then
                If i > _id_izvod_stavka.Length - 1 Then '_id_racun_stavka(i) = 0 Then
                    CM = New SqlCommand()
                    If CN.State = ConnectionState.Open Then
                        With CM
                            .Connection = CN
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "rm_racun_stavka_add"
                            .Parameters.AddWithValue("@id_izvod", _id_izvod) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                            .Parameters.AddWithValue("@rb", dgStavke.Rows(i).Cells(0).Value)
                            .Parameters.AddWithValue("@konto", dgStavke.Rows(i).Cells(1).Value)
                            .Parameters.AddWithValue("@partner", dgStavke.Rows(i).Cells(2).Value)
                            .Parameters.AddWithValue("@opis", dgStavke.Rows(i).Cells(3).Value)
                            .Parameters.AddWithValue("@duguje", dgStavke.Rows(i).Cells(4).Value)
                            .Parameters.AddWithValue("@potrazuje", dgStavke.Rows(i).Cells(5).Value)
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
                            .CommandText = "fn_izvodi_stavke_update"
                            .Parameters.AddWithValue("@id_izvod_stavka", _id_izvod_stavka(i)) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                            .Parameters.AddWithValue("@rb", dgStavke.Rows(i).Cells(0).Value)
                            .Parameters.AddWithValue("@konto", dgStavke.Rows(i).Cells(1).Value)
                            .Parameters.AddWithValue("@partner", dgStavke.Rows(i).Cells(2).Value)
                            .Parameters.AddWithValue("@opis", dgStavke.Rows(i).Cells(4).Value.ToString)
                            .Parameters.AddWithValue("@duguje", CSng(dgStavke.Rows(i).Cells(5).Value))
                            .Parameters.AddWithValue("@potrazuje", CSng(dgStavke.Rows(i).Cells(6).Value))
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
                        .CommandText = "fn_izvodi_stavke_delete"
                        .Parameters.AddWithValue("@id_izvod_stavka", _id_izvod_stavka(i)) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                        .ExecuteScalar()
                    End With
                End If
                CM.Dispose()
            End If
        Next
        CN.Close()
    End Sub

    Private Sub snimi_uplatu()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim i As Integer

        CN.Open()
        For i = 0 To dgStavke.RowCount - 2
            If dgStavke.Rows(i).Cells(2).Value <> "" Then
                If dgStavke.Rows(i).Cells(5).Value <> 0 Then
                    sql = "select dbo.rm_ulazni_racuni_head.* from dbo.rm_ulazni_racuni_head " & _
                          "where dbo.rm_ulazni_racuni_head.id_partner = " & dgStavke.Rows(i).Cells(2).Value & _
                          " and dbo.rm_ulazni_racuni_head.sifra = " & Mid(dgStavke.Rows(i).Cells(4).Value, 10) & _
                          " and dbo.rm_ulazni_racuni_head.placeno = 0"
                ElseIf dgStavke.Rows(i).Cells(6).Value <> 0 Then
                    sql = "select dbo.rm_racun_head.* from dbo.rm_racun_head " & _
                          "where dbo.rm_racun_head.id_partner = " & dgStavke.Rows(i).Cells(2).Value & _
                          " and dbo.rm_racun_head.sifra = " & Mid(dgStavke.Rows(i).Cells(4).Value, 10) & _
                          " and dbo.rm_racun_head.placeno = 0"
                End If

                If CN.State = ConnectionState.Open Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.Text
                        .CommandText = sql
                        DR = .ExecuteReader()
                    End With
                    CM.Dispose()

                    While DR.Read
                        _id_racun = DR.Item("id_racun_head")
                    End While
                    DR.Close()

                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "rm_racun_uplacen"
                        .Parameters.AddWithValue("@id_racun_head", _id_racun)
                        .Parameters.AddWithValue("@placeno", 1)
                        .ExecuteScalar()
                    End With
                    CM.Dispose()
                End If
            End If
        Next
        CN.Close()
    End Sub

    Private Sub proknjizi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "fn_izvodi_proknjizi"
                .Parameters.AddWithValue("@id_izvod", _id_izvod)
                .Parameters.AddWithValue("@proknjizen", 1)
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If
        CN.Close()
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Select Case e.ClickedItem.Name
            Case "tlbSnimi"
                snimi_head()
                snimi_stavku()
                pocetak()
                dgStavke.Rows.Clear()
                popuni_stavke()
            Case "tlbProknjizi"
                snimi_head()
                snimi_stavku()
                snimi_uplatu()
                proknjizi()
                zatvori_formu()
                labProknjizen.Visible = True
            Case "tlbEnd"
                Me.Dispose()
        End Select
    End Sub

#Region "Grid 1"

    Private Sub dgStavke_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgStavke.CellValueChanged
        If Not _pocetak Then
            With dgStavke
                Try
                    Select Case e.ColumnIndex
                        Case 1
                            '.Rows(e.RowIndex).Cells(0).Value = e.RowIndex + 1
                            redni_broj()
                            indeks = e.RowIndex
                            If Not IsNothing(.Rows(e.RowIndex).Cells(1).Value) Then
                                If .Rows(e.RowIndex).Cells(1).Value.ToString <> "" Then
                                    .Rows(e.RowIndex).Cells(5).Value = Format(0, 2)
                                    .Rows(e.RowIndex).Cells(6).Value = Format(0, 2)
                                    Select Case Mid(.Rows(e.RowIndex).Cells(1).Value.ToString, 1, 3)
                                        Case "202"
                                            dug_pot = "p"
                                        Case "433"
                                            dug_pot = "d"
                                    End Select
                                End If
                            End If
                        Case 2
                            cmbDokumenti.Text = ""
                            indeks = e.RowIndex
                            If Not IsNothing(.Rows(e.RowIndex).Cells(2).Value) Then
                                _mCombo = cmbDokumenti
                                izdvoj_dokumente(RTrim(.Rows(e.RowIndex).Cells(2).Value), dug_pot)
                            End If
                        Case 5
                            If Not IsNothing(.Rows(e.RowIndex).Cells(5).Value) Then
                                .Rows(e.RowIndex).Cells(5).Value = _
                                    Format(.Rows(e.RowIndex).Cells(5).Value, 2)
                            Else
                                .Rows(e.RowIndex).Cells(5).Value = Format(0, 2)
                            End If
                        Case 6
                            If Not IsNothing(.Rows(e.RowIndex).Cells(6).Value) Then
                                .Rows(e.RowIndex).Cells(6).Value = _
                                    Format(.Rows(e.RowIndex).Cells(6).Value, 2)
                            Else
                                .Rows(e.RowIndex).Cells(6).Value = Format(0, 2)
                            End If
                    End Select

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End With
        End If
        preracunaj()

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
        dgStavke.Rows(e.Row.Index).Cells(4).Value = 0
        dgStavke.Rows(e.Row.Index).Cells(5).Value = 0

    End Sub

    Private Sub dgStavke_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgStavke.RowsRemoved
        preracunaj()
    End Sub

#End Region

    Private Sub redni_broj()
        Dim i As Integer
        For i = 0 To dgStavke.RowCount - 2
            dgStavke.Rows(i).Cells(0).Value = i + 1
        Next
    End Sub

    Private Sub preracunaj()
        Dim i As Integer

        ukupno_duguje = 0
        ukupno_potrazuje = 0
        saldo = 0

        Try
            For i = 0 To dgStavke.Rows.Count - 2
                Dim duguje As Single = CDec(dgStavke.Rows(i).Cells(5).Value)
                Dim potrazuje As Single = CDec(dgStavke.Rows(i).Cells(6).Value)

                ukupno_duguje += duguje
                ukupno_potrazuje += potrazuje

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try

        saldo = ukupno_potrazuje - ukupno_duguje

        txtSvegaDuguje.Text = Format(ukupno_duguje, 2)
        txtSvegaPotrazuje.Text = Format(ukupno_potrazuje, 2)
        txtSaldo.Text = Format(saldo, 2)
        txtNovoStanje.Text = Format(staro_stanje() + saldo, 2)

    End Sub

    Private Sub cmbDokumenti_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDokumenti.SelectedValueChanged
        popuni()
    End Sub

    Private Sub popuni()
        dokument_opis(RTrim(cmbDokumenti.Text))
        '.Rows(e.RowIndex).Cells(4).Value = broj_dok
        If vrsta_dok = 1 Then
            dgStavke.Rows(indeks).Cells(4).Value = "Predracun br." & broj_dok
        ElseIf vrsta_dok = 2 Then
            dgStavke.Rows(indeks).Cells(4).Value = "Racun br." & broj_dok
        End If

        Select Case dug_pot
            Case "d"
                dgStavke.Rows(indeks).Cells(5).Value = Format(za_naplatu, 2)
                dgStavke.Rows(indeks).Cells(6).Value = Format(0, 2)
            Case "p"
                dgStavke.Rows(indeks).Cells(5).Value = Format(0, 2)
                dgStavke.Rows(indeks).Cells(6).Value = Format(za_naplatu, 2)
        End Select
    End Sub

    Private Sub btnOsvezi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOsvezi.Click
        Me.PartneriTableAdapter.Update(Me.DataSet1.app_partneri)
        Me.PartneriTableAdapter.Fill(Me.DataSet1.app_partneri)
        Me.KontaTableAdapter.Update(Me.DataSet1.fn_konta)
        Me.KontaTableAdapter.Fill(Me.DataSet1.fn_konta)
    End Sub

    Private Sub btnNoviPartner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoviPartner.Click
        'Dim mForm As New frmPartneriUnos
        'mForm.Show()
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
                .CommandText = "select dbo.fn_izvodi_stavke.* from dbo.fn_izvodi_stavke where dbo.fn_izvodi_stavke.id_izvod = " & _id_izvod
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            _broj_stavki = 0
            Do While DR.Read
                _broj_stavki += 1
            Loop
            DR.Close()

            _id_izvod_stavka = New Integer() {}
            ReDim _id_izvod_stavka(_broj_stavki - 1)

            With dgStavke
                Dim i As Integer = 0
                DR = CM.ExecuteReader
                Do While DR.Read
                    .Rows.Add(1)
                    If Not IsDBNull(DR.Item("id_izvod_stavka")) Then _id_izvod_stavka.SetValue(DR.Item("id_izvod_stavka"), i)
                    If Not IsDBNull(DR.Item("rb")) Then .Rows(i).Cells(0).Value = DR.Item("rb")
                    If Not IsDBNull(DR.Item("konto")) Then .Rows(i).Cells(1).Value = DR.Item("konto")
                    If Not IsDBNull(DR.Item("partner")) Then .Rows(i).Cells(2).Value = DR.Item("partner")
                    If Not IsDBNull(DR.Item("opis")) Then .Rows(i).Cells(4).Value = DR.Item("opis")
                    If Not IsDBNull(DR.Item("duguje")) Then .Rows(i).Cells(5).Value = DR.Item("duguje")
                    If Not IsDBNull(DR.Item("potrazuje")) Then .Rows(i).Cells(6).Value = DR.Item("potrazuje")
                    i += 1
                Loop
            End With
        End If

        CM.Dispose()
        CN.Close()
        _citam_stavke = False
    End Sub

    Private Sub zatvori_formu()
        'If _unesen Then
        Panel1.Enabled = False
        dgStavke.AllowUserToAddRows = False
        dgStavke.Enabled = False

        ToolStrip1.Items(0).Enabled = False
        ToolStrip1.Items(1).Enabled = False

        'End If
    End Sub

End Class