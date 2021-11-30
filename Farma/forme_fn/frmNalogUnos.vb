Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmNalogUnos
    Private duguje As Decimal = 0
    Private potrazuje As Decimal = 0
    Private saldo As Decimal = 0
    Private proknjizen As Boolean = False
    Private indeks As Integer = 0
    Private sifra As String = ""
    Private naziv As String = ""

    Private _pocetak As Boolean = True
    Private _citam_stavke As Boolean = True

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmNalogUnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.app_partneri' table. You can move, or remove it, as needed.
        Me.PartneriTableAdapter.Fill(Me.DataSet1.app_partneri)
        'TODO: This line of code loads data into the 'DataSet1.fn_konta' table. You can move, or remove it, as needed.
        Me.KontaTableAdapter.Fill(Me.DataSet1.fn_konta)

        pocetak()
        _pocetak = False

    End Sub

    Private Sub pocetak()

        txtBroj.Text = Nadji_rb(Imena.tabele.fn_nalog_head.ToString, 1)
        dateKnjizenja.Value = Today
        labProknjizen.Visible = False

        If Not _po_semi Then
            txtDuguje.Text = 0
            txtPotrazuje.Text = 0
            txtSaldo.Text = 0
        Else
            _pocetak = False
            po_semi()
        End If
    End Sub

    Private Sub snimi_head()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        'Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "fn_nalog_head_add"
                .Parameters.AddWithValue("@broj", txtBroj.Text)
                .Parameters.AddWithValue("@datum", dateKnjizenja.Value.Date)
                .Parameters.AddWithValue("@duguje", CSng(txtDuguje.Text))
                .Parameters.AddWithValue("@potrazuje", CSng(txtPotrazuje.Text))
                .Parameters.AddWithValue("@proknjizen", proknjizen)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub snimi_stavku()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim i As Integer

        _id_nalog = Nadji_id(Imena.tabele.fn_nalog_head.ToString)
        For i = 0 To dgStavke.Rows.Count - 2
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "fn_nalog_stavka_add"
                    .Parameters.AddWithValue("@id_nalog", _id_nalog)
                    .Parameters.AddWithValue("@datum", dateKnjizenja.Value.Date)
                    .Parameters.AddWithValue("@rb", RTrim(dgStavke.Rows(i).Cells(0).Value))
                    .Parameters.AddWithValue("@konto", RTrim(dgStavke.Rows(i).Cells(1).Value))
                    .Parameters.AddWithValue("@partner", RTrim(dgStavke.Rows(i).Cells(2).Value))
                    .Parameters.AddWithValue("@opis", RTrim(dgStavke.Rows(i).Cells(3).Value))
                    .Parameters.AddWithValue("@duguje", CDec(dgStavke.Rows(i).Cells(4).Value))
                    .Parameters.AddWithValue("@potrazuje", CDec(dgStavke.Rows(i).Cells(5).Value))
                    .ExecuteScalar()
                End With
            End If
            CM.Dispose()
            CN.Close()
        Next
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Select Case e.ClickedItem.Name
            Case "tlbSnimi"
                snimi_head()
                snimi_stavku()
                pocetak()
                dgStavke.Rows.Clear()
            Case "tlbIzdaj"
                proknjizi()
                proknjizen = True
                zatvori_formu()
            Case "tlbEnd"
                Me.Dispose()
        End Select
    End Sub

#Region "Grid 1"
    Private Sub dgStavke_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgStavke.MouseHover
        'If Not IsDBNull(dgStavke.CurrentRow.Cells(1).Value) Then

        '    popuni_robu(RTrim(dgStavke.CurrentRow.Cells(1).Value.ToString))
        '    'dgStavke.CurrentRow.Tag = naziv
        '    dgStavke.CurrentRow.Cells(1).ToolTipText = naziv
        '    dgStavke.CurrentRow.Cells(2).ToolTipText = Partner_naziv(dgStavke.CurrentRow.Cells(2).Value.ToString)
        'End If
    End Sub

    Private Sub dgStavke_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgStavke.CellValueChanged
        If Not _pocetak Then
            With dgStavke
                Try
                    indeks = e.RowIndex
                    redni_broj()
                    Select Case e.ColumnIndex
                        Case 1
                            '.Rows(e.RowIndex).Cells(0).Value = e.RowIndex + 1
                        Case 4
                            preracunaj()
                        Case 5
                            preracunaj()
                    End Select
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

    Private Sub dgStavke_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgStavke.RowsRemoved
        preracunaj()
    End Sub

#End Region

    Private Sub popuni_robu(ByVal _sifra As String)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.fn_konta.* from dbo.fn_konta where konto = '" & _sifra & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                sifra = DR.Item("konto")
                naziv = DR.Item("naziv")
            Loop
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub redni_broj()
        Dim i As Integer

        For i = 0 To dgStavke.RowCount - 2
            dgStavke.Rows(i).Cells(0).Value = i + 1
        Next
    End Sub

    Private Sub proknjizi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "fn_nalog_proknjizi"
                .Parameters.AddWithValue("@id_nalog", _id_nalog)
                .Parameters.AddWithValue("@proknjizen", 1)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        _proknjizen = True
        zatvori_formu()

    End Sub

    Private Sub zatvori_formu()
        'If _izdat Then
        Panel1.Enabled = False
        dgStavke.AllowUserToAddRows = False
        dgStavke.Enabled = False

        ToolStrip1.Items(0).Enabled = False
        ToolStrip1.Items(1).Enabled = False

        txtDuguje.Enabled = False
        txtPotrazuje.Enabled = False
        txtSaldo.Enabled = False
        labProknjizen.Visible = True
        'End If
    End Sub

    Private Sub preracunaj()
        Dim i As Integer

        duguje = 0
        potrazuje = 0
        saldo = 0
       
        Try
            For i = 0 To dgStavke.Rows.Count - 2
                Dim dug As Decimal = CDec(dgStavke.Rows(i).Cells(4).Value)
                Dim pot As Decimal = CDec(dgStavke.Rows(i).Cells(5).Value)
                duguje += dug
                potrazuje += pot
                saldo = duguje - potrazuje
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txtDuguje.Text = Format(duguje, 2)
        txtPotrazuje.Text = Format(potrazuje, 2)
        txtSaldo.Text = Format(saldo, 2)

    End Sub

    Private Sub po_semi()

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.fn_sema_za_knjizenje_head.* from dbo.fn_sema_za_knjizenje_head " & _
                               "where dbo.fn_sema_za_knjizenje_head.sifra = '" & _sema_sifra & "'"
                DR = .ExecuteReader
            End With

            Do While DR.Read
                _id_sema = DR.Item("id_sema")
            Loop
            DR.Close()
            CM.Dispose()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.sema_za_knjizenje_stavka.* from dbo.sema_za_knjizenje_stavka " & _
                               "where dbo.sema_za_knjizenje_stavka.id_sema = " & _id_sema
                DR = .ExecuteReader
            End With

            With dgStavke
                Dim i As Integer = 0
                Do While DR.Read
                    .Rows.Add(1)
                    Select Case DR.Item("grupa").ToString
                        Case "0"
                            If Not IsDBNull(DR.Item("konto")) Then .Rows(i).Cells(1).Value = RTrim(DR.Item("konto"))
                            .Rows(i).Cells(3).Value = _opis
                            Select Case DR.Item("strana").ToString
                                Case "d"
                                    .Rows(i).Cells(4).Value = _iznos ' _osnovica
                                Case "p"
                                    .Rows(i).Cells(5).Value = _iznos '_osnovica
                            End Select
                        Case "1"
                            If Not IsDBNull(DR.Item("konto")) Then .Rows(i).Cells(1).Value = RTrim(DR.Item("konto"))
                            .Rows(i).Cells(3).Value = _opis
                            Select Case DR.Item("strana").ToString
                                Case "d"
                                    .Rows(i).Cells(4).Value = _iznos ' _osnovica
                                Case "p"
                                    .Rows(i).Cells(5).Value = _iznos '_osnovica
                            End Select

                        Case "2"
                            If Not IsDBNull(DR.Item("konto")) Then .Rows(i).Cells(1).Value = RTrim(DR.Item("konto"))
                            .Rows(i).Cells(3).Value = _opis
                            If DR.Item("konto") Like "202*" Then
                                .Rows(i).Cells(2).Value = _partner_sifra
                                Select Case DR.Item("strana").ToString
                                    Case "d"
                                        .Rows(i).Cells(4).Value = _iznos
                                    Case "p"
                                        .Rows(i).Cells(5).Value = _iznos
                                End Select
                            End If
                            If DR.Item("konto") Like "27*" Then
                                .Rows(i).Cells(5).Value = _pdv_iznos
                            End If

                        Case "3"

                        Case "4"
                            If Not IsDBNull(DR.Item("konto")) Then .Rows(i).Cells(1).Value = RTrim(DR.Item("konto"))
                            If DR.Item("konto") Like "43*" Then
                                .Rows(i).Cells(2).Value = _partner_sifra
                                Select Case DR.Item("strana").ToString
                                    Case "d"
                                        .Rows(i).Cells(4).Value = _iznos
                                    Case "p"
                                        .Rows(i).Cells(5).Value = _osnovica ' _iznos
                                End Select
                            End If
                            .Rows(i).Cells(3).Value = _opis
                            If DR.Item("konto") Like "47*" Then
                                .Rows(i).Cells(4).Value = _pdv_iznos
                            End If

                        Case "5"
                            If Not IsDBNull(DR.Item("konto")) Then .Rows(i).Cells(1).Value = RTrim(DR.Item("konto"))
                            .Rows(i).Cells(3).Value = _opis
                            Select Case DR.Item("strana").ToString
                                Case "d"
                                    .Rows(i).Cells(4).Value = _iznos ' _osnovica
                                Case "p"
                                    .Rows(i).Cells(5).Value = _iznos ' _osnovica
                            End Select

                        Case "6"
                            If Not IsDBNull(DR.Item("konto")) Then .Rows(i).Cells(1).Value = RTrim(DR.Item("konto"))
                            .Rows(i).Cells(3).Value = _opis
                            Select Case DR.Item("strana").ToString
                                Case "d"
                                    .Rows(i).Cells(4).Value = _osnovica
                                Case "p"
                                    .Rows(i).Cells(5).Value = _osnovica
                            End Select

                        Case "7"

                        Case "8"

                        Case "9"
                    End Select
                    i += 1
                Loop
            End With
        End If

        CM.Dispose()
        CN.Close()
        _citam_stavke = False
    End Sub

    Private Sub btnNoviPartner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoviPartner.Click
        Dim mForm As New frmPartneriUnos
        mForm.Show()
    End Sub

    Private Sub btnOsvezi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOsvezi.Click
        dgStavke.Rows(indeks).Cells(1).Value = _novi_artikl_sifra
    End Sub
End Class