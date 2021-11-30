Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO

Public Class cntPDV_search
    Shared upit As String = ""

    Shared upit_sifra As String = ""
    Shared upit_naziv As String = ""

    Shared sql_start As String = "SELECT * FROM dbo.app_pdv"
    Shared sql As String = ""
    Private _pocetak As Boolean = True
    Private aktivan_chk As Boolean
    Private aktivan_chk1 As Boolean
    Private aktivan_chk2 As Boolean

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntPDV_search_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtOpis.Enabled = False
        txtOpis.BackColor = Color.Lavender
        txtSifra.Enabled = False
        txtSifra.BackColor = Color.Lavender

        _lCount = labCount
    End Sub

    Shared Sub filter()
        On Error Resume Next

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
                    Dim podatak As New ListViewItem(CStr(DR.Item("pdv_sifra")))

                    podatak.SubItems.Add(DR.Item("pdv_opis").ToString)
                    podatak.SubItems.Add(DR.Item("pdv_stopa").ToString)
                    podatak.SubItems.Add(CDate(DR.Item("pdv_dat_stupanja")).Date)

                    _lista.Items.AddRange(New ListViewItem() {podatak})
                End While
                DR.Close()
            End If

            CM.Dispose()
            CN.Close()
        End If

        _lCount.Text = _lista.Items.Count.ToString + " zapisa"

    End Sub

    Shared Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function

    Private Sub chkSve_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSve.CheckedChanged
        Select Case chkSve.CheckState
            Case CheckState.Checked
                'aktivan_chk2 = True
                chkNaziv.Checked = False
                chkSifra.Checked = False
                sql = sql_start
                Lista()
            Case CheckState.Unchecked
                'aktivan_chk2 = False
                upit = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub chkNaziv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNaziv.CheckedChanged
        Select Case chkNaziv.CheckState
            Case CheckState.Checked
                txtOpis.Enabled = True
                txtOpis.BackColor = Color.GhostWhite
                chkSve.Checked = False
                'aktivan_chk = True
            Case CheckState.Unchecked
                txtOpis.Enabled = False
                txtOpis.BackColor = Color.Lavender
                'aktivan_chk = False
                upit_naziv = ""
                txtOpis.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub chkSifra_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSifra.CheckedChanged
        Select Case chkSifra.CheckState
            Case CheckState.Checked
                txtSifra.Enabled = True
                txtSifra.BackColor = Color.GhostWhite
                chkSve.Checked = False
                'aktivan_chk1 = True
            Case CheckState.Unchecked
                txtSifra.Enabled = False
                txtSifra.BackColor = Color.Lavender
                'aktivan_chk1 = False
                upit_sifra = ""
                txtSifra.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub txtNaziv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOpis.TextChanged
        If txtOpis.Text <> "" Then
            upit_naziv = "dbo.app_pdv.pdv_opis LIKE N'" & txtOpis.Text & "%'"
        Else
            upit_naziv = ""
        End If
        'filter()
    End Sub
    Private Sub txtNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOpis.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtOpis.Text <> "" Then
                upit_naziv = "dbo.app_pdv.pdv_opis LIKE N'" & txtOpis.Text & "%'"
            Else
                upit_naziv = ""
            End If
            filter()
        End If
    End Sub

    Private Sub txtSifra_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSifra.TextChanged
        If txtSifra.Text <> "" Then
            upit_sifra = "dbo.app_pdv.pdv_sifra LIKE N'" & txtSifra.Text & "%'"
        Else
            upit_sifra = ""
        End If
        'filter()
    End Sub
    Private Sub txtSifra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSifra.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtSifra.Text <> "" Then
                upit_sifra = "dbo.app_pdv.pdv_sifra LIKE N'" & txtSifra.Text & "%'"
            Else
                upit_sifra = ""
            End If
            filter()
        End If
    End Sub

    Private Sub proveri_formu()
        'Dim mCont As Control ' CheckBox
        Dim mChack As Object

        aktivan_chk = False
        For Each mChack In mPanel2.Controls
            If mChack.name = "chkNaziv" Or mChack.name = "chkSifra" Or mChack.name = "chkSve" Then
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
         _raport = Imena.tabele.app_pdv.ToString
        Dim mForm As New frmPrint
        mForm.Show()
    End Sub

    Shared Sub pripremi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Dim xmlw As XmlTextWriter = Nothing
        Dim putanja As String = _win_temp_path
        Dim fajl As String = putanja & "rptPDV.xml"

        Dim fi As FileInfo = New FileInfo(fajl)

        If fi.Exists Then fi.Delete()

        xmlw = New XmlTextWriter(fajl, Nothing)

        CN.Open()
        If CN.State = ConnectionState.Open Then

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from app_pdv"  '_sql
                DR = .ExecuteReader
            End With

            _pdv_opis = ""
            _pdv_stopa = ""
            _pdv_sifra = 0
            _pdv_datum = Today
            Dim _aktivan As String = ""

            xmlw.Formatting = Formatting.Indented
            xmlw.WriteStartDocument()
            xmlw.WriteStartElement("pdv")

            Do While DR.Read
                If Not IsDBNull(DR.Item("pdv_sifra")) Then
                    _pdv_sifra = RTrim(DR.Item("pdv_sifra"))
                Else
                    _pdv_sifra = ""
                End If
                If Not IsDBNull(DR.Item("pdv_opis")) Then
                    _pdv_opis = RTrim(DR.Item("pdv_opis"))
                Else
                    _pdv_opis = ""
                End If
                If Not IsDBNull(DR.Item("pdv_stopa")) Then
                    _pdv_stopa = RTrim(DR.Item("pdv_stopa"))
                Else
                    _pdv_stopa = ""
                End If
                If Not IsDBNull(DR.Item("pdv_dat_stupanja")) Then
                    _pdv_datum = RTrim(DR.Item("pdv_dat_stupanja"))
                Else
                    _pdv_datum = ""
                End If

                If Not IsDBNull(DR.Item("pdv_aktivan")) Then
                    _aktivan = da_ne(DR.Item("pdv_aktivan"))
                Else
                    _aktivan = ""
                End If

                xmlw.WriteStartElement("podatak")
                xmlw.WriteElementString("sifra", _pdv_sifra)
                xmlw.WriteElementString("naziv", _pdv_opis)
                xmlw.WriteElementString("stopa", _pdv_stopa)
                xmlw.WriteElementString("datum", _pdv_datum)
                xmlw.WriteElementString("aktivan", _aktivan)
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

    Shared Sub unesi(ByVal _sifra, ByVal _naziv, ByVal _oznaka)
        'Dim CN As SqlConnection = New SqlConnection(CNNString)
        'Dim CM As New SqlCommand

        'CN.Open()
        'If CN.State = ConnectionState.Open Then
        '    CM = New SqlCommand()
        '    With CM
        '        .Connection = CN
        '        .CommandType = CommandType.StoredProcedure
        '        .CommandText = "prn_jm_add"
        '        .Parameters.AddWithValue("@jm_sifra", _sifra)
        '        .Parameters.AddWithValue("@jm_naziv", _naziv)
        '        .Parameters.AddWithValue("@jm_oznaka", _oznaka)
        '        .ExecuteScalar()
        '    End With
        '    CM.Dispose()
        'End If
        'CN.Close()
    End Sub

#End Region

End Class
