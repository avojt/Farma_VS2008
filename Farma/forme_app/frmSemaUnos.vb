Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmSemaUnos
    Private indeks As Integer = 0
    Private _pocetak As Boolean = True

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmSemaUnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.fn_konta' table. You can move, or remove it, as needed.
        Me.KontaTableAdapter.Fill(Me.DataSet1.fn_konta)

        pocetak()
        _pocetak = False

        popuni_sifre()

    End Sub

    Private Sub pocetak()
        'txtSifra.Text = ""
        txtNaziv.Text = ""
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
            '    cmbSifra.SelectedText = _sema_sifra
            'Else
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
                .CommandText = "fn_sema_za_knjizenje_head_add"
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
        Dim i As Integer

        _id_sema = Nadji_id(Imena.tabele.fn_sema_za_knjizenje_head.ToString)
        For i = 0 To dgStavke.Rows.Count - 2
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "fn_sema_za_knjizenje_stavka_add"
                    .Parameters.AddWithValue("@id_sema", _id_sema)
                    .Parameters.AddWithValue("@rb", RTrim(dgStavke.Rows(i).Cells(0).Value))
                    .Parameters.AddWithValue("@konto", RTrim(dgStavke.Rows(i).Cells(1).Value))
                    .Parameters.AddWithValue("@grupa", RTrim(dgStavke.Rows(i).Cells(2).Value))
                    .Parameters.AddWithValue("@strana", RTrim(dgStavke.Rows(i).Cells(3).Value))
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

#End Region

    Private Sub redni_broj()
        Dim i As Integer

        For i = 0 To dgStavke.RowCount - 2
            dgStavke.Rows(i).Cells(0).Value = i + 1
        Next
    End Sub


End Class

