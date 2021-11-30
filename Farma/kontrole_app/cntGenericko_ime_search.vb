Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO

Public Class cntGenericko_ime_search
    Shared upit As String = ""
    Shared upit_sifra As String = ""
    Shared upit_naziv As String = ""
    Shared sql_start As String = "SELECT * FROM dbo.app_genericko_ime"
    Shared sql As String = ""

    Private _pocetak As Boolean = True

    Private aktivan_chk As Boolean
    Private aktivan_chk1 As Boolean

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntGenericko_ime_search_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        txtNaziv.Enabled = False
        txtNaziv.BackColor = Color.Lavender
        txtSifra.Enabled = False
        txtSifra.BackColor = Color.Lavender

        chkSifra.CheckState = CheckState.Unchecked
        chkNaziv.CheckState = CheckState.Unchecked

        _lCount = labCount
    End Sub

    Shared Sub filter()

        On Error Resume Next
        'If Not _pocetak Then
        'If upit_magacin <> "" Then upit = upit_sifra

        upit = ""
        sql = ""

        If upit_sifra <> "" And upit <> "" Then
            upit = upit & " and " & upit_sifra
        Else
            If upit_sifra <> "" Then upit = upit_sifra
        End If

        If upit_naziv <> "" And upit <> "" Then
            upit = upit & " and " & upit_naziv
        Else
            If upit_naziv <> "" Then upit = upit_naziv
        End If

        sql = sql_start
        If upit <> "" Then
            sql += " WHERE " & upit
        End If

        Lista()
    End Sub

    Shared Sub Lista()

        _lista.Visible = True
        _lista.Items.Clear()

        If sql <> "" Then
            Dim CN As SqlConnection = New SqlConnection(CNNString)
            Dim CM As New SqlCommand
            Dim DR As SqlDataReader

            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = sql
                    DR = .ExecuteReader
                End With

                While DR.Read
                    Dim podatak As New ListViewItem(CStr(DR.Item("genericko_sifra")))

                    podatak.SubItems.Add(DR.Item("genericko_ime").ToString)

                    _lista.Items.AddRange(New ListViewItem() {podatak})

                End While
                DR.Close()
            End If

            CM.Dispose()
            CN.Close()
        End If
        _lCount.Text = _lista.Items.Count.ToString + " zapisa"

    End Sub

    Private Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function

    Private Sub chkNaziv_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNaziv.CheckedChanged
        Select Case chkNaziv.CheckState
            Case CheckState.Checked
                txtNaziv.Enabled = True
                txtNaziv.BackColor = Color.GhostWhite
                aktivan_chk1 = True
            Case CheckState.Unchecked
                txtNaziv.Enabled = False
                txtNaziv.BackColor = Color.Lavender
                aktivan_chk1 = False
                upit_naziv = ""
                txtNaziv.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub chkSifra_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSifra.CheckedChanged
        Select Case chkSifra.CheckState
            Case CheckState.Checked
                txtSifra.Enabled = True
                txtSifra.BackColor = Color.GhostWhite
                aktivan_chk = True
            Case CheckState.Unchecked
                txtSifra.Enabled = False
                txtSifra.BackColor = Color.Lavender
                aktivan_chk = False
                upit_sifra = ""
                txtSifra.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub txtNaziv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNaziv.TextChanged
        If txtNaziv.Text <> "" Then
            upit_naziv = "app_genericko_ime.genericko_ime LIKE N'" & txtNaziv.Text & "%'"
        Else
            upit_naziv = ""
        End If
        'filter()
    End Sub
    Private Sub txtNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNaziv.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtNaziv.Text <> "" Then
                upit_naziv = "app_genericko_ime.genericko_ime LIKE N'" & txtNaziv.Text & "%'"
            Else
                upit_naziv = ""
            End If
            filter()
        End If
    End Sub

    Private Sub txtSifra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSifra.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtSifra.Text <> "" Then
                upit_naziv = "app_genericko_ime.genericko_sifra LIKE N'" & txtSifra.Text & "%'"
            Else
                upit_naziv = ""
            End If
            filter()
        End If
    End Sub
    Private Sub txtSifra_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSifra.TextChanged
        If txtSifra.Text <> "" Then
            upit_naziv = "app_genericko_ime.genericko_sifra LIKE N'" & txtSifra.Text & "%'"
        Else
            upit_naziv = ""
        End If
    End Sub

    Private Sub proveri_formu()
        'Dim mCont As Control ' CheckBox
        Dim mChack As Object

        aktivan_chk = False
        For Each mChack In mPanel2.Controls
            If mChack.name = "chkNaziv" Or mChack.name = "chkSifra" Then
                If mChack.CheckState = CheckState.Checked Then
                    aktivan_chk = True
                End If
            End If
        Next

        If aktivan_chk = False Then
            _lista.Items.Clear()
            _lista.Visible = False
        End If
    End Sub

    Private Sub btnPronadji_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPronadji.Click
        filter()
    End Sub

#Region "STAMPANJE"
    Shared Sub prn()
        filter()

        pripremi()

        _raport = Imena.tabele.app_genericko_ime.ToString
        Dim mForm As New frmPrint
        mForm.Show()
    End Sub

    Shared Sub pripremi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Dim xmlw As XmlTextWriter = Nothing
        Dim putanja As String = _win_temp_path ' My.Application.Info.DirectoryPath & "\izvestaji\app\"
        Dim fajl As String = putanja & "rptGenericko.xml"

        Dim fi As FileInfo = New FileInfo(fajl)

        If fi.Exists Then fi.Delete()

        xmlw = New XmlTextWriter(fajl, Nothing)

        CN.Open()
        If CN.State = ConnectionState.Open Then

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql
                DR = .ExecuteReader
            End With

            _genericko_sifra = ""
            _genericko_naziv = ""

            xmlw.Formatting = Formatting.Indented
            xmlw.WriteStartDocument()
            xmlw.WriteStartElement("genericko")
            Do While DR.Read
                If Not IsDBNull(DR.Item("genericko_sifra")) Then
                    _genericko_sifra = RTrim(DR.Item("genericko_sifra"))
                Else
                    _genericko_sifra = ""
                End If

                If Not IsDBNull(DR.Item("genericko_ime")) Then
                    _genericko_naziv = RTrim(DR.Item("genericko_ime"))
                Else
                    _genericko_naziv = ""
                End If

                xmlw.WriteStartElement("podatak")
                xmlw.WriteElementString("sifra", _genericko_sifra)
                xmlw.WriteElementString("naziv", _genericko_naziv)
                xmlw.WriteEndElement()
            Loop
            xmlw.WriteEndElement()
            xmlw.WriteEndDocument()
            xmlw.Flush()
            xmlw.Close()

            DR.Close()
            CM.Dispose()

        End If
        CN.Close()
    End Sub

    Shared Sub unesi(ByVal _sifra, ByVal _naziv)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prn_genericko_ime_add"
                .Parameters.AddWithValue("@genericko_sifra", _sifra)
                .Parameters.AddWithValue("@genericko_ime", _naziv)
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If
        CN.Close()
    End Sub

#End Region
End Class
