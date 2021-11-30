Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO

Public Class cntKontniPlan_search

#Region "dekleracija"
    Shared upit As String = ""
    Shared upit_sifra As String = ""
    Shared upit_dozvoljeno As String = ""

    Shared sql_start As String = _
                "SELECT  * FROM dbo.app_konto"

    Shared sql As String = ""
    Private _pocetak As Boolean = True
    Shared _poABCedi As Boolean = False
    Private aktivan_chk As Boolean
#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntKontniPlan_search_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtSifra.Enabled = False
        txtSifra.BackColor = Color.Lavender

        chkDozvoljenoKnj.CheckState = CheckState.Unchecked
        chkSifra.CheckState = CheckState.Unchecked

        _lCount = labCount

        mPanel.Dock = DockStyle.Fill
    End Sub

    Shared Sub filter()

        upit = ""
        sql = ""

        If upit_sifra <> "" Then upit = upit_sifra

        If upit_dozvoljeno <> "" And upit <> "" Then
            upit = upit & " and " & upit_dozvoljeno
        Else
            If upit_dozvoljeno <> "" Then upit = upit_dozvoljeno
        End If

        sql = sql_start
        If upit <> "" Then
            sql += " WHERE " & upit
        End If

        If _poABCedi Then sql += " ORDER BY dbo.app_konto.naziv"
        lista()

    End Sub

    Shared Sub lista()
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
                    Dim podatak As New ListViewItem(CStr(DR.Item("Konto_Sifra")))
                    podatak.SubItems.Add(DR.Item("naziv").ToString)
                    podatak.SubItems.Add(da_ne(DR.Item("Dozvoljeno_Knjizenje").ToString))
                    podatak.SubItems.Add(da_ne(DR.Item("ima_analitiku").ToString))
                    podatak.SubItems.Add(da_ne(DR.Item("Pocetno_Stanje").ToString))
                    podatak.SubItems.Add(DR.Item("Aktiva_Pasiva").ToString)
                    podatak.SubItems.Add(DR.Item("Bilansno_Vanbilansno").ToString)
                    If Not IsDBNull(DR.Item("Vazi_Do")) Then
                        podatak.SubItems.Add(DR.Item("Vazi_Do"))
                    Else
                        podatak.SubItems.Add(" ")
                    End If
                    podatak.SubItems.Add(da_ne(DR.Item("Pasiviziran").ToString))

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

    Private Sub chkABC_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        filter()
    End Sub

    Private Sub chkSifra_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSifra.CheckedChanged
        Select Case chkSifra.CheckState
            Case CheckState.Checked
                txtSifra.Enabled = True
                txtSifra.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                txtSifra.Enabled = False
                txtSifra.BackColor = Color.Lavender
                upit_sifra = ""
                txtSifra.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub chkDozvoljenoKnj_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDozvoljenoKnj.CheckedChanged
        Select Case chkDozvoljenoKnj.CheckState
            Case CheckState.Checked
                upit_dozvoljeno = "Dozvoljeno_Knjizenje = 1"
            Case CheckState.Unchecked
                upit_dozvoljeno = "Dozvoljeno_Knjizenje = 0"
        End Select
    End Sub

    Private Sub txtSifra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSifra.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtSifra.Text <> "" Then
                upit_sifra = "Konto_Sifra LIKE N'" & txtSifra.Text & "%'"
            Else
                upit_sifra = ""
            End If
            filter()
        End If
    End Sub
    Private Sub txtSifra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSifra.TextChanged
        If txtSifra.Text <> "" Then
            upit_sifra = "Konto_Sifra LIKE N'" & txtSifra.Text & "%'"
        Else
            upit_sifra = ""
        End If
        'filter()
    End Sub

    Private Sub proveri_formu()
        Dim mChack As Object

        aktivan_chk = False
        For Each mChack In mPanel2.Controls
            If mChack.name = "chkSifra" Or mChack.name = "chkDozvoljenoKnj" Then
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

    Shared Sub prn()
        'filter()

        pripremi()
        _raport = Imena.tabele.app_konto.ToString

        Dim mForm As New frmPrint
        mForm.Show()
    End Sub

    Shared Sub pripremi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Dim xmlw As XmlTextWriter = Nothing
        Dim putanja As String = _win_temp_path
        Dim fajl As String = putanja & "rptKontniPlan.xml"

        Dim fi As FileInfo = New FileInfo(fajl)

        If fi.Exists Then fi.Delete()

        xmlw = New XmlTextWriter(fajl, Nothing)

        CN.Open()
        If CN.State = ConnectionState.Open Then

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from app_konto"
                DR = .ExecuteReader
            End With

            _konto_naziv = ""
            _konto_Sifra = ""

            xmlw.Formatting = Formatting.Indented
            xmlw.WriteStartDocument()
            xmlw.WriteStartElement("konto")

            Do While DR.Read
                If Not IsDBNull(DR.Item("Konto_Sifra")) Then
                    _konto_naziv = RTrim(DR.Item("Konto_Sifra"))
                Else
                    _konto_naziv = ""
                End If

                If Not IsDBNull(DR.Item("Naziv")) Then
                    _konto_Sifra = RTrim(DR.Item("Naziv"))
                Else
                    _konto_Sifra = ""
                End If

                xmlw.WriteStartElement("podatak")
                xmlw.WriteElementString("sifra", _konto_naziv)
                xmlw.WriteElementString("naziv", _konto_Sifra)
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

End Class
