Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO

Public Class cntGrupeArt_search
    Shared upit As String = ""
    Shared upit_sifra As String = ""
    Shared upit_naziv As String = ""
    Shared sql_start As String = "SELECT * FROM dbo.app_artikl_grupa"
    Shared sql As String = ""

    Private _pocetak As Boolean = True

    Private aktivan_chk As Boolean
    'Private aktivan_chk1 As Boolean
    Shared _poABCedi As Boolean = False

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntGrupeArt_search_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
        If _poABCedi Then sql += " ORDER BY app_artikl_grupa.gr_artikla_naziv" 'ASC" DESC" 'ascending

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
                    Dim podatak As New ListViewItem(CStr(DR.Item("gr_artikla_sifra")))
                    podatak.SubItems.Add(DR.Item("gr_artikla_naziv").ToString)
                    podatak.SubItems.Add(DR.Item("gr_artikla_skraceno").ToString)
                    podatak.SubItems.Add(DR.Item("gr_artikla_nadredj_gr").ToString)
                    podatak.SubItems.Add(da_ne(DR.Item("gr_artikla_poslednji_nivo")))
                    podatak.SubItems.Add(DR.Item("gr_artikla_marza").ToString)
                    podatak.SubItems.Add(DR.Item("gr_artikla_pdv").ToString)
                    If Not IsDBNull(DR.Item("gr_artikla_lek")) Then
                        podatak.SubItems.Add(da_ne(DR.Item("gr_artikla_lek")))
                    Else
                        podatak.SubItems.Add("")
                    End If
                    If Not IsDBNull(DR.Item("gr_artikla_L1")) Then
                        podatak.SubItems.Add(da_ne(DR.Item("gr_artikla_L1")))
                    Else
                        podatak.SubItems.Add("")
                    End If
                    podatak.SubItems.Add(DR.Item("gr_artikla_izdajesena").ToString)

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

    Private Sub chkABC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkABC.CheckedChanged
        'Select Case chkABC.CheckState
        '    Case CheckState.Checked
        '        _poABCedi = True
        '    Case CheckState.Unchecked
        '        _poABCedi = False
        'End Select
        filter()
    End Sub

    Private Sub chkNaziv_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNaziv.CheckedChanged
        Select Case chkNaziv.CheckState
            Case CheckState.Checked
                txtNaziv.Enabled = True
                txtNaziv.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                txtNaziv.Enabled = False
                txtNaziv.BackColor = Color.Lavender
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
            Case CheckState.Unchecked
                txtSifra.Enabled = False
                txtSifra.BackColor = Color.Lavender
                upit_sifra = ""
                txtSifra.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub chkABC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkABC.KeyPress
        If e.KeyChar = Chr(13) Then
            Select Case chkABC.CheckState
                Case CheckState.Checked
                    _poABCedi = True
                Case CheckState.Unchecked
                    _poABCedi = True
            End Select
            filter()
        End If
    End Sub

    Private Sub txtNaziv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNaziv.TextChanged
        If txtNaziv.Text <> "" Then
            upit_naziv = "app_artikl_grupa.gr_artikla_naziv LIKE N'" & txtNaziv.Text & "%'"
        Else
            upit_naziv = ""
        End If
        'filter()
    End Sub
    Private Sub txtNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNaziv.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtNaziv.Text <> "" Then
                upit_naziv = "app_artikl_grupa.gr_artikla_naziv LIKE N'" & txtNaziv.Text & "%'"
            Else
                upit_naziv = ""
            End If
            filter()
        End If
    End Sub

    Private Sub txtSifra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSifra.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtSifra.Text <> "" Then
                upit_naziv = "app_artikl_grupa.gr_artikla_sifra LIKE N'" & txtSifra.Text & "%'"
            Else
                upit_naziv = ""
            End If
            filter()
        End If
    End Sub
    Private Sub txtSifra_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSifra.TextChanged
        If txtSifra.Text <> "" Then
            upit_naziv = "app_artikl_grupa.gr_artikla_sifra LIKE N'" & txtSifra.Text & "%'"
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
        _raport = Imena.tabele.app_artikl_grupa.ToString

        Dim mForm As New frmPrint
        mForm.Show()
       
    End Sub

    Shared Sub pripremi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Dim xmlw As XmlTextWriter = Nothing
        Dim putanja As String = _win_temp_path ' My.Application.Info.DirectoryPath & "\izvestaji\app\"
        Dim fajl As String = putanja & "rptGrupeArt.xml"

        Dim fi As FileInfo = New FileInfo(fajl)

        If fi.Exists Then fi.Delete()

        xmlw = New XmlTextWriter(fajl, Nothing)

        CN.Open()
        If CN.State = ConnectionState.Open Then

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from app_artikl_grupa"
                DR = .ExecuteReader
            End With

            _gr_art_sifra = ""
            _gr_art_naziv = ""
            _gr_art_skraceno = ""
            _gr_art_nadredj_gr = ""
            Dim _poslednji_nivo As String = ""
            _gr_art_marza = 0
            _gr_art_pdv = 0
            Dim _aktivno As String = ""
            Dim _L1 As String = ""
            Dim _lek As String = ""
            _gr_art_izdajesena = ""

            xmlw.Formatting = Formatting.Indented
            xmlw.WriteStartDocument()
            xmlw.WriteStartElement("grupa_art")

            Do While DR.Read
               
                If Not IsDBNull(DR.Item("gr_artikla_sifra")) Then
                    _gr_art_sifra = RTrim(DR.Item("gr_artikla_sifra"))
                Else
                    _gr_art_sifra = ""
                End If
                If Not IsDBNull(DR.Item("gr_artikla_naziv")) Then
                    _gr_art_naziv = RTrim(DR.Item("gr_artikla_naziv"))
                Else
                    _gr_art_naziv = ""
                End If
                If Not IsDBNull(DR.Item("gr_artikla_skraceno")) Then
                    _gr_art_skraceno = RTrim(DR.Item("gr_artikla_skraceno"))
                Else
                    _gr_art_skraceno = ""
                End If
                If Not IsDBNull(DR.Item("gr_artikla_nadredj_gr")) Then
                    _gr_art_nadredj_gr = RTrim(DR.Item("gr_artikla_nadredj_gr"))
                Else
                    _gr_art_nadredj_gr = ""
                End If
                If Not IsDBNull(DR.Item("gr_artikla_poslednji_nivo")) Then
                    _poslednji_nivo = da_ne(DR.Item("gr_artikla_poslednji_nivo"))
                Else
                    _gr_art_poslednji_nivo = ""
                End If
                If Not IsDBNull(DR.Item("gr_artikla_marza")) Then
                    _gr_art_marza = RTrim(DR.Item("gr_artikla_marza"))
                Else
                    _gr_art_marza = ""
                End If
                If Not IsDBNull(DR.Item("gr_artikla_pdv")) Then
                    _gr_art_pdv = RTrim(DR.Item("gr_artikla_pdv"))
                Else
                    _gr_art_pdv = ""
                End If
                If Not IsDBNull(DR.Item("gr_artikla_aktivno")) Then
                    _aktivno = da_ne(DR.Item("gr_artikla_aktivno"))
                Else
                    _aktivno = ""
                End If
                If Not IsDBNull(DR.Item("gr_artikla_L1")) Then
                    _L1 = da_ne(DR.Item("gr_artikla_L1"))
                Else
                    _L1 = ""
                End If
                If Not IsDBNull(DR.Item("gr_artikla_lek")) Then
                    _lek = da_ne(DR.Item("gr_artikla_lek"))
                Else
                    _lek = ""
                End If
                If Not IsDBNull(DR.Item("gr_artikla_izdajesena")) Then
                    _gr_art_izdajesena = RTrim(DR.Item("gr_artikla_izdajesena"))
                Else
                    _gr_art_izdajesena = ""
                End If

                xmlw.WriteStartElement("podatak")
                xmlw.WriteElementString("sifra", _gr_art_sifra)
                xmlw.WriteElementString("naziv", _gr_art_naziv)
                xmlw.WriteElementString("skraceno", _gr_art_skraceno)
                xmlw.WriteElementString("nadredjena", _gr_art_nadredj_gr)
                xmlw.WriteElementString("poslednji_nivo", _poslednji_nivo)
                xmlw.WriteElementString("marza", _gr_art_marza)
                xmlw.WriteElementString("pdv", _gr_art_pdv)
                xmlw.WriteElementString("aktivno", _aktivno)
                xmlw.WriteElementString("L1", _L1)
                xmlw.WriteElementString("lek", _aktivno)
                xmlw.WriteElementString("izdajesena", _gr_art_izdajesena)
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

#End Region

End Class
