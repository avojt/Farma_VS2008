Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmSemaEdit
    Private indeks As Integer = 0
    Private _pocetak As Boolean = True
    Private sifra As String = ""
    Private naziv As String = ""

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmSemaEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataSet1.fn_konta' table. You can move, or remove it, as needed.
        Me.KontaTableAdapter.Fill(Me.DataSet1.fn_konta)
        'TODO: This line of code loads data into the 'DataSet1.fn_konta' table. You can move, or remove it, as needed.
        Me.KontaTableAdapter.Fill(Me.DataSet1.fn_konta)

        pocetak()
        _pocetak = False

    End Sub

    Private Sub pocetak()
        'cmbSifra.Text = _sema_sifra
        txtNaziv.Text = _sema_naziv

        popuni_sifre()
        popuni_stavke()

    End Sub

    Private Sub popuni_sifre()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbSifra.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.sifre_sema.* from dbo.sifre_sema"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbSifra.Items.Add(DR.Item("sifra"))
            Loop
            DR.Close()
        End If
        If cmbSifra.Items.Count > 0 Then
            'If _iz_ponude Then
            cmbSifra.SelectedText = _sema_sifra
        Else
            cmbSifra.SelectedIndex = 0
            'End If
        End If
        CM.Dispose()
        CN.Close()
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
                .CommandText = "fn_sema_za_knjizenje_head_update"
                .Parameters.AddWithValue("@id_sema", _id_sema)
                .Parameters.AddWithValue("@sifra", cmbSifra.Text)
                .Parameters.AddWithValue("@naziv", txtNaziv.Text)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub snimi_stavku()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim i, n As Integer

        CN.Open()
        If _id_sema_stavka.Length > dgStavke.Rows.Count - 1 Then
            n = _id_sema_stavka.Length - 1
        Else
            n = dgStavke.Rows.Count - 2
        End If
        For i = 0 To n
            If (i <= dgStavke.Rows.Count - 2 Or Not _id_sema_stavka.Length > dgStavke.Rows.Count - 1) Or _id_sema_stavka.Length = 0 Then
                If i > _id_sema_stavka.Length - 1 Then
                    CM = New SqlCommand()
                    If CN.State = ConnectionState.Open Then
                        With CM
                            .Connection = CN
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "fn_sema_za_knjizenje_stavka_add"
                            .Parameters.AddWithValue("@id_nalog", _id_sema)
                            .Parameters.AddWithValue("@rb", RTrim(dgStavke.Rows(i).Cells(0).Value))
                            .Parameters.AddWithValue("@konto", RTrim(dgStavke.Rows(i).Cells(1).Value))
                            .Parameters.AddWithValue("@grupa", RTrim(dgStavke.Rows(i).Cells(2).Value))
                            .Parameters.AddWithValue("@strana", Mid(dgStavke.Rows(i).Cells(3).Value, 1, 1))
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
                            .CommandText = "fn_sema_za_knjizenje_stavka_update"
                            .Parameters.AddWithValue("@id_sema_stavka", _id_sema_stavka(i))
                            .Parameters.AddWithValue("@rb", RTrim(dgStavke.Rows(i).Cells(0).Value))
                            .Parameters.AddWithValue("@konto", RTrim(dgStavke.Rows(i).Cells(1).Value))
                            .Parameters.AddWithValue("@grupa", RTrim(dgStavke.Rows(i).Cells(2).Value))
                            .Parameters.AddWithValue("@strana", Mid(dgStavke.Rows(i).Cells(3).Value, 1, 1))
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
                        .CommandText = "fn_nalog_stavka_delete"
                        .Parameters.AddWithValue("@id_stavka", _id_nalog_stavka(i))
                        .ExecuteScalar()
                    End With
                End If
                CM.Dispose()
            End If
        Next
        CN.Close()

    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Select Case e.ClickedItem.Name
            Case "tlbSnimi"
                snimi_head()
                snimi_stavku()
                pocetak()
                dgStavke.Rows.Clear()
            Case "tlbEnd"
                Me.Dispose()
        End Select
    End Sub

#Region "Grid 1"

    Private Sub dgStavke_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgStavke.CellValueChanged
        If Not _pocetak Then
            With dgStavke
                Try
                    indeks = e.RowIndex
                    redni_broj()
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
    Private Sub dgStavke_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgStavke.MouseHover
        If dgStavke.CurrentRow.Displayed Then

            popuni_robu(RTrim(dgStavke.CurrentRow.Cells(1).Value.ToString))
            'dgStavke.CurrentRow.Tag = naziv
            dgStavke.CurrentRow.Cells(1).ToolTipText = naziv
        End If
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
                .CommandText = "select * from dbo.sema_za_knjizenje_stavka where dbo.sema_za_knjizenje_stavka.id_sema = " & _id_sema
                DR = .ExecuteReader
            End With

            _broj_stavki = 0
            Do While DR.Read
                _broj_stavki += 1
            Loop
            DR.Close()

            _id_sema_stavka = New Integer() {}
            ReDim _id_sema_stavka(_broj_stavki - 1)

            With dgStavke
                Dim i As Integer = 0
                DR = CM.ExecuteReader
                Do While DR.Read
                    .Rows.Add(1)
                    If Not IsDBNull(DR.Item("id_sema_stavka")) Then _id_sema_stavka.SetValue(DR.Item("id_sema_stavka"), i)
                    If Not IsDBNull(DR.Item("rb")) Then .Rows(i).Cells(0).Value = RTrim(DR.Item("rb"))
                    If Not IsDBNull(DR.Item("konto")) Then .Rows(i).Cells(1).Value = RTrim(DR.Item("konto"))
                    If Not IsDBNull(DR.Item("grupa")) Then .Rows(i).Cells(2).Value = (DR.Item("grupa"))

                    If Not IsDBNull(DR.Item("strana")) Then
                        If DR.Item("strana") = "d" Then
                            .Rows(i).Cells(3).Value = "duguje"
                        ElseIf DR.Item("strana") = "p" Then
                            .Rows(i).Cells(3).Value = "potrazuje"
                        End If
                    End If

                    i += 1
                Loop
            End With
        End If

        CM.Dispose()
        CN.Close()
    End Sub

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

End Class