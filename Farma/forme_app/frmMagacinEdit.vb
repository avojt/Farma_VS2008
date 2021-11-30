Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmMagacinEdit

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmMagacinEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        pocetak()
    End Sub

    Private Sub pocetak()
        txtSifra.Text = _magacin_sifra
        txtNaziv.Text = _magacin_naziv
        chkVodjenjeZaliha.Checked = _magacin_vodjenje_zaliha

        popuni_vrste_magacina()

    End Sub

    Private Sub snimi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_magacini_update"
                .Parameters.AddWithValue("@id_magacin", _id_magacin)
                .Parameters.AddWithValue("@sifra", txtSifra.Text)
                .Parameters.AddWithValue("@naziv", txtNaziv.Text)
                .Parameters.AddWithValue("@id_vrsta_magacina", magacin_id(cmbVrstaMagacin.Text))
                .Parameters.AddWithValue("@vodjenje_zaliha", chkVodjenjeZaliha.Checked)
                .Parameters.AddWithValue("@id_vodjenje_zaliha", 0) ' dozvoljena_id(cmbVodjenjeZliha.Text))
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Select Case e.ClickedItem.Name
            Case "tlbSnimi"
                snimi()
                'pocetak()
            Case "tlbEnd"
                Me.Close()
        End Select
    End Sub

    Private Sub popuni_vrste_magacina()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbVrstaMagacin.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_vrste_magacina.* from dbo.rm_vrste_magacina"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbVrstaMagacin.Items.Add(DR.Item("naziv"))
            Loop
            DR.Close()
        End If
        If cmbVrstaMagacin.Items.Count > 0 Then
            selektuj_vrste_magacina(_magacin_id_vrsta, Selekcija.po_nazivu)
            cmbVrstaMagacin.SelectedText = _vrsta_mag_naziv
        End If
        CM.Dispose()
        CN.Close()

        magacin_id(cmbVrstaMagacin.Text)

    End Sub

    Private Sub cmbVrstaMagacin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVrstaMagacin.SelectedIndexChanged
        dozvoljena_id(magacin_id(cmbVrstaMagacin.Text))
    End Sub

    Private Function magacin_id(ByVal _tMagacin)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        magacin_id = 0

        CN.Open()

        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_vrste_magacina.* from dbo.rm_vrste_magacina " & _
                               "where dbo.rm_vrste_magacina.naziv = '" & _tMagacin & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                magacin_id = DR.Item("id_vrsta_magacina")
            Loop
            DR.Close()
            CM.Dispose()
        End If
        CN.Close()
    End Function

    Private Sub dozvoljena_id(ByVal _tVodjenje)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()

        If CN.State = ConnectionState.Open Then
            'nalazi koji magacin kako moze da se vodi iz tabele dozvoljena_vodjenja_zaliha
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_dozvoljena_vodjenja_zaliha.* from dbo.rm_dozvoljena_vodjenja_zaliha " & _
                               "where dbo.rm_dozvoljena_vodjenja_zaliha.id_vrsta_magacina = '" & _tVodjenje & "'"
                DR = .ExecuteReader
            End With

            _broj_stavki = 0
            Do While DR.Read
                _broj_stavki += 1
            Loop
            DR.Close()

            'ubacuje njihove id-e u niz
            _magacin_id_dozvoljenih = New Integer() {}
            ReDim _magacin_id_dozvoljenih(_broj_stavki - 1)

            DR = CM.ExecuteReader
            Dim i As Integer = 0
            Do While DR.Read
                _magacin_id_dozvoljenih.SetValue(DR.Item("id_vodjenja_zaliha"), i)
                i += 1
            Loop
            DR.Close()
            CM.Dispose()
        End If
        CN.Close()

        popuni_zalihe()

    End Sub

    Private Sub popuni_zalihe() 'nacin vodjenja zaliha na osnovu vrste magacina
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbVodjenjeZliha.Items.Clear()

        CN.Open()
        If CN.State = ConnectionState.Open Then
            Dim i As Integer
            For i = 0 To _magacin_id_dozvoljenih.Length - 1
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = "select dbo.rm_vodjenje_zaliha.* from dbo.rm_vodjenje_zaliha " & _
                                   "where dbo.rm_vodjenje_zaliha.id_vedjenje_zaliha = " & _magacin_id_dozvoljenih(i)
                    DR = .ExecuteReader
                End With
                Do While DR.Read
                    cmbVodjenjeZliha.Items.Add(DR.Item("naziv"))
                Loop
                DR.Close()
            Next i
        End If
        If cmbVodjenjeZliha.Items.Count > 0 Then
            cmbVodjenjeZliha.SelectedIndex = 0
        End If

        CM.Dispose()
        CN.Close()
    End Sub

    Private Function vodjenja_id(ByVal _tVodjenje)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        vodjenja_id = 0

        CN.Open()

        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.vrste_magacina.* from dbo.vrste_magacina " & _
                               "where dbo.vrste_magacina.naziv = '" & _tVodjenje & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                vodjenja_id = DR.Item("id_vrsta_magacina")
            Loop
            DR.Close()
            CM.Dispose()
        End If
        CN.Close()
    End Function


End Class