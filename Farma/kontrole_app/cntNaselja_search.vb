Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO

Public Class cntNaselja_search

#Region "dekleracija"
    Shared upit As String = ""
    Shared upit_naziv As String = ""
    Shared upit_ptt As String = ""
    Shared upit_opstina As String = ""
    Shared upit_grad As String = ""

    Shared sql_mesta As String = _
                "SELECT * FROM dbo.app_mesta"

    Shared sql_opstine As String = _
               "SELECT * FROM dbo.app_opstine"

    Shared sql_gradovi As String = _
               "SELECT * FROM dbo.app_gradovi"

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

    Private Sub cntNaselja_search_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        popuni_gradove()
        popuni_opstine()

        txtNaziv.Enabled = False
        txtNaziv.BackColor = Color.Lavender
        txtPtt.Enabled = False
        txtPtt.BackColor = Color.Lavender
        cmbGrad.Enabled = False
        cmbGrad.BackColor = Color.Lavender
        cmbOpstina.Enabled = False
        cmbOpstina.BackColor = Color.Lavender

        chkABC.CheckState = CheckState.Unchecked
        chkPtt.CheckState = CheckState.Unchecked
        chkGrad.CheckState = CheckState.Unchecked
        chkNaziv.CheckState = CheckState.Unchecked
        chkOpstina.CheckState = CheckState.Unchecked

        chkGrad.Enabled = False
        chkOpstina.Enabled = False

        rbtGradovi.Checked = True
        rbtMesta.Checked = False
        rbtOpstine.Checked = False

        _lCount = labCount
        _mCntNaselja_search = Me

        mPanel.Dock = DockStyle.Fill
    End Sub

    Private Sub popuni_gradove()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbGrad.Items.Clear()
        cmbGrad.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.app_gradovi"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbGrad.Items.Add(DR.Item("grad_naziv"))
            Loop
            DR.Close()
        End If
        If cmbGrad.Items.Count > 0 Then
            'selektuj_mesto(_partner_mesto, Selekcija.po_nazivu)
            cmbGrad.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_opstine()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbOpstina.Items.Clear()
        cmbOpstina.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_opstine.* from dbo.app_opstine"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbOpstina.Items.Add(DR.Item("opstine_naziv"))
            Loop
            DR.Close()
        End If
        If cmbOpstina.Items.Count > 0 Then
            'selektuj_mesto(_partner_mesto, Selekcija.po_nazivu)
            cmbOpstina.SelectedIndex = 0 ' _partner_opstina
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Shared Sub filter()

        upit = ""
        sql = ""

        If upit_naziv <> "" And upit <> "" Then
            upit = upit & " and " & upit_naziv
        Else
            If upit_naziv <> "" Then upit = upit_naziv
        End If

        If upit_ptt <> "" And upit <> "" Then
            upit = upit & " and " & upit_ptt
        Else
            If upit_ptt <> "" Then upit = upit_ptt
        End If

        If upit_opstina <> "" And upit <> "" Then
            upit = upit & " and " & upit_opstina
        Else
            If upit_opstina <> "" Then upit = upit_opstina
        End If

        If upit_grad <> "" And upit <> "" Then
            upit = upit & " and " & upit_grad
        Else
            If upit_grad <> "" Then upit = upit_grad
        End If

        Select Case _naselja
            Case Imena.naselja.grad
                sql = sql_gradovi
            Case Imena.naselja.opstina
                sql = sql_opstine
            Case Imena.naselja.mesto
                sql = sql_mesta
        End Select

        If upit <> "" Then
            sql += " WHERE " & upit '& ")"
        End If

        If _poABCedi Then
            Select Case _naselja
                Case Imena.naselja.grad
                    sql += " ORDER BY dbo.app_gradovi.grad_naziv"
                Case Imena.naselja.opstina
                    sql = " ORDER BY dbo.app_opstine.opstine_naziv"
                Case Imena.naselja.mesto
                    sql = " ORDER BY dbo.app_mesta.mesto_naziv"
            End Select
        End If

        lista()

    End Sub

    Shared Sub lista()

        Try
            _lista.View = View.Details
            _lista.LabelEdit = True
            _lista.AllowColumnReorder = False
            _lista.FullRowSelect = True
            _lista.GridLines = True
            _lista.Dock = DockStyle.Fill
            _lista.BringToFront()
            _lista.ForeColor = Color.MidnightBlue

            _lista.Clear()  'Items.Clear()

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

                Select Case _naselja
                    Case Imena.naselja.grad
                        _lista.Columns.Add("Naziv", 150, HorizontalAlignment.Left)
                        _lista.Columns.Add("PTT broj", 90, HorizontalAlignment.Left)
                        _lista.Columns.Add("Por.jedinica", 150, HorizontalAlignment.Left)
                    Case Imena.naselja.opstina
                        _lista.Columns.Add("Naziv", 150, HorizontalAlignment.Left)
                        _lista.Columns.Add("Grad.područje", 150, HorizontalAlignment.Left)
                        _lista.Columns.Add("PTT broj", 90, HorizontalAlignment.Left)
                        _lista.Columns.Add("Por.jedinica", 150, HorizontalAlignment.Left)
                    Case Imena.naselja.mesto
                        _lista.Columns.Add("Naziv", 150, HorizontalAlignment.Left)
                        _lista.Columns.Add("Opšt.područje", 150, HorizontalAlignment.Left)
                        _lista.Columns.Add("PTT broj", 90, HorizontalAlignment.Left)
                        _lista.Columns.Add("Por.jedinica", 150, HorizontalAlignment.Left)
                End Select

                While DR.Read
                    Dim _podatak As New ListViewItem(" ")
                    Select Case _naselja
                        Case Imena.naselja.grad
                            Dim podatak As New ListViewItem(DR.Item("grad_naziv").ToString)
                            podatak.SubItems.Add(DR.Item("grad_ptt_br").ToString)
                            podatak.SubItems.Add(DR.Item("grad_porjed").ToString)
                            _podatak = podatak
                        Case Imena.naselja.opstina
                            Dim podatak As New ListViewItem(DR.Item("opstine_naziv").ToString)
                            If Not IsDBNull(DR.Item("id_grad")) Then
                                selektuj_grad(DR.Item("id_grad"), Selekcija.po_id)
                                podatak.SubItems.Add(_grad_naziv)
                            Else
                                podatak.SubItems.Add("")
                            End If
                            'selektuj_grad(DR.Item("id_grad"), Selekcija.po_id)
                            'podatak.SubItems.Add(_grad_naziv)
                            podatak.SubItems.Add(DR.Item("opstine_ptt_br").ToString)
                            podatak.SubItems.Add(DR.Item("opstine_porjed").ToString)
                            _podatak = podatak
                        Case Imena.naselja.mesto
                            Dim podatak As New ListViewItem(DR.Item("mesto_naziv").ToString)
                            If Not IsDBNull(DR.Item("id_opstine")) Then
                                Dim a As Integer = DR.Item("id_opstine")
                                selektuj_opstine(DR.Item("id_opstine"), Selekcija.po_id)
                                podatak.SubItems.Add(_opstina_naziv)
                            Else
                                podatak.SubItems.Add("")
                            End If
                            podatak.SubItems.Add(DR.Item("mesto_ptt_br").ToString)
                            podatak.SubItems.Add(DR.Item("mesto_porjed").ToString)
                            _podatak = podatak
                    End Select

                    _lista.Items.AddRange(New ListViewItem() {_podatak})

                End While
                DR.Close()
            End If
            CM.Dispose()
            CN.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

        '_lCount.Text = _lista.Items.Count.ToString + " zapisa"

    End Sub

    Private Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function

    Private Sub chkABC_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkABC.CheckedChanged
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

    Private Sub chkPtt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPtt.CheckedChanged
        Select Case chkPtt.CheckState
            Case CheckState.Checked
                txtPtt.Enabled = True
                txtPtt.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                txtPtt.Enabled = False
                txtPtt.BackColor = Color.Lavender
                upit_ptt = ""
                txtPtt.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub chkOpstina_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkOpstina.CheckedChanged
        Select Case chkOpstina.CheckState
            Case CheckState.Checked
                cmbOpstina.Enabled = True
                cmbOpstina.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbOpstina.Enabled = False
                cmbOpstina.BackColor = Color.Lavender
                upit_opstina = ""
                cmbOpstina.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub chkGrad_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkGrad.CheckedChanged
        Select Case chkGrad.CheckState
            Case CheckState.Checked
                cmbGrad.Enabled = True
                cmbGrad.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbGrad.Enabled = False
                cmbGrad.BackColor = Color.Lavender
                upit_grad = ""
                cmbGrad.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub rbtMesta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtMesta.CheckedChanged
        Select Case rbtMesta.Checked
            Case True
                _naselja = Imena.naselja.mesto
                chkOpstina.Checked = False
                chkOpstina.Enabled = True
                chkGrad.Checked = False
                chkGrad.Enabled = False
            Case False
                _naselja = ""
                chkOpstina.Checked = False
                chkOpstina.Enabled = False
                chkGrad.Checked = False
                chkGrad.Enabled = False
        End Select
        obrisi_upite
    End Sub

    Private Sub rbtOpstine_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtOpstine.CheckedChanged
        Select Case rbtOpstine.Checked
            Case True
                _naselja = Imena.naselja.opstina
                chkOpstina.Checked = False
                chkOpstina.Enabled = False
                chkGrad.Checked = False
                chkGrad.Enabled = True
            Case False
                _naselja = ""
                chkOpstina.Checked = False
                chkOpstina.Enabled = False
                chkGrad.Checked = False
                chkGrad.Enabled = False
        End Select
       obrisi_upite
    End Sub

    Private Sub rbtGradovi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtGradovi.CheckedChanged
        Select Case rbtGradovi.Checked
            Case True
                _naselja = Imena.naselja.grad '.ToString
                chkOpstina.Checked = False
                chkOpstina.Enabled = False
                chkGrad.Checked = False
                chkGrad.Enabled = False
            Case False
                _naselja = ""
                chkOpstina.Checked = False
                chkOpstina.Enabled = False
                chkGrad.Checked = False
                chkGrad.Enabled = False
        End Select
        obrisi_upite()
    End Sub

    Private Sub txtNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNaziv.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtNaziv.Text <> "" Then
                Select Case _naselja
                    Case Imena.naselja.grad
                        upit_naziv = "app_gradovi.grad_naziv LIKE N'" & txtNaziv.Text & "%'"
                    Case Imena.naselja.opstina
                        upit_naziv = "app_opstine.opstine_naziv LIKE N'" & txtNaziv.Text & "%'"
                    Case Imena.naselja.mesto
                        upit_naziv = "app_mesta.mesto_naziv LIKE N'" & txtNaziv.Text & "%'"
                End Select
                filter()
            Else
                upit_naziv = ""
            End If
        End If
    End Sub
    Private Sub txtNaziv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNaziv.TextChanged
        If txtNaziv.Text <> "" Then
            Select Case _naselja
                Case Imena.naselja.grad
                    upit_naziv = "app_gradovi.grad_naziv LIKE N'" & txtNaziv.Text & "%'"
                Case Imena.naselja.opstina
                    upit_naziv = "app_opstine.opstine_naziv LIKE N'" & txtNaziv.Text & "%'"
                Case Imena.naselja.mesto
                    upit_naziv = "app_mesta.mesto_naziv LIKE N'" & txtNaziv.Text & "%'"
            End Select
        Else
            upit_naziv = ""
        End If
    End Sub

    Private Sub txtPtt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPtt.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtPtt.Text <> "" Then
                Select Case _naselja
                    Case Imena.naselja.grad
                        upit_ptt = "app_gradovi.grad_ptt_br LIKE N'" & txtPtt.Text & "%'"
                    Case Imena.naselja.opstina
                        upit_ptt = "app_opstine.opstine_ptt_br LIKE N'" & txtPtt.Text & "%'"
                    Case Imena.naselja.mesto
                        upit_ptt = "app_mesta.mesto_ptt_br LIKE N'" & txtPtt.Text & "%'"
                End Select
                filter()
            Else
                upit_ptt = ""
            End If
        End If

    End Sub
    Private Sub txtPtt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPtt.TextChanged
        If txtPtt.Text <> "" Then
            Select Case _naselja
                Case Imena.naselja.grad
                    upit_ptt = "app_gradovi.grad_ptt_br LIKE N'" & txtPtt.Text & "%'"
                Case Imena.naselja.opstina
                    upit_ptt = "app_opstine.opstine_ptt_br LIKE N'" & txtPtt.Text & "%'"
                Case Imena.naselja.mesto
                    upit_ptt = "app_mesta.mesto_ptt_br LIKE N'" & txtPtt.Text & "%'"
            End Select
        Else
            upit_ptt = ""
        End If
    End Sub

    Private Sub cmbOpstina_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbOpstina.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbOpstina.Text <> "" Then
                Select Case _naselja
                    Case Imena.naselja.grad
                        upit_opstina = ""
                    Case Imena.naselja.opstina
                        upit_opstina = ""
                    Case Imena.naselja.mesto
                        selektuj_opstine(cmbOpstina.Text, Selekcija.po_nazivu)
                        upit_opstina = "app_mesta.id_opstine =" & _id_opstina
                End Select
                filter()
            Else
                upit_opstina = ""
            End If
        End If
    End Sub
    Private Sub cmbOpstina_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOpstina.SelectedIndexChanged
        If cmbOpstina.Text <> "" Then
            Select Case _naselja
                Case Imena.naselja.grad
                    upit_opstina = ""
                Case Imena.naselja.opstina
                    upit_opstina = ""
                Case Imena.naselja.mesto
                    selektuj_opstine(cmbOpstina.Text, Selekcija.po_nazivu)
                    upit_opstina = "app_mesta.id_opstine =" & _id_opstina
            End Select
        Else
            upit_opstina = ""
        End If
    End Sub

    Private Sub cmbGrad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbGrad.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbGrad.Text <> "" Then
                Select Case _naselja
                    Case Imena.naselja.grad
                        upit_grad = ""
                    Case Imena.naselja.opstina
                        selektuj_grad(cmbGrad.Text, Selekcija.po_nazivu)
                        upit_grad = "app_opstine.id_grad =" & _id_grad
                    Case Imena.naselja.mesto
                        upit_grad = ""
                End Select
                filter()
            Else
                upit_grad = ""
            End If
        End If
    End Sub
    Private Sub cmbGrad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbGrad.SelectedIndexChanged
        If cmbGrad.Text <> "" Then
            selektuj_grad(cmbGrad.Text, Selekcija.po_nazivu)
            Select Case _naselja
                Case Imena.naselja.grad
                    upit_grad = ""
                Case Imena.naselja.opstina
                    upit_grad = "app_opstine.id_grad =" & _id_grad
                Case Imena.naselja.mesto
                    upit_grad = ""
            End Select
            'filter()
        Else
            upit_grad = ""
        End If
    End Sub

    Private Sub proveri_formu()
        Dim mChack As Object

        aktivan_chk = False
        For Each mChack In mPanel2.Controls
            If mChack.name = "chkNaziv" Or mChack.name = "chkPtt" _
                    Or mChack.name = "chkGrad" Or mChack.name = "chkOpstina" Or mChack.name = "chkMesto" Then
                If mChack.CheckState = CheckState.Checked Then
                    aktivan_chk = True
                End If
            End If
        Next
        If aktivan_chk = False Then
            _lista.Items.Clear()
            _lista.Visible = False
        Else
            _lista.Items.Clear()
            _lista.Visible = True
        End If
    End Sub

    Private Sub btnPronadji_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPronadji.Click
        filter()
    End Sub

    Private Sub obrisi_upite()
        upit_naziv = ""
        upit_ptt = ""
        upit_opstina = ""
        upit_grad = ""
        txtNaziv.Text = ""
        txtPtt.Text = ""
        cmbGrad.Text = ""
        cmbOpstina.Text = ""
    End Sub

#Region "STAMPANJE"
    Shared _tip As String
    Shared Sub prn()
        Select Case _naselja
            Case Imena.naselja.grad
                sql = "select * from app_gradovi" ' naselja_print("select * from app_gradovi")
                _tip = "Grad"
            Case Imena.naselja.opstina
                sql = "select * from app_opstine" 'naselja_print("select * from app_opstine")
                _tip = "Opština"
            Case Imena.naselja.mesto
                sql = "select * from app_mesta" 'naselja_print("select * from app_mesta")
                _tip = "Mesto"
        End Select

        'filter()

        pripremi()

        _raport = Imena.tabele.app_naselja.ToString
        Dim mForm As New frmPrint
        mForm.Show()
    End Sub

    Shared Sub pripremi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Dim xmlw As XmlTextWriter = Nothing
        Dim putanja As String = _win_temp_path
        Dim fajl As String = putanja & "rptNaselja.xml"

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

            Dim naziv As String = ""
            Dim ptt As String = ""
            Dim por_jed As String = ""
            Dim podrucje As String = ""

            xmlw.Formatting = Formatting.Indented
            xmlw.WriteStartDocument()
            xmlw.WriteStartElement("naselje")

            Do While DR.Read
                If _naselja = Imena.naselja.grad Then
                    If Not IsDBNull(DR.Item("grad_naziv")) Then
                        naziv = RTrim(DR.Item("grad_naziv"))
                    Else
                        naziv = ""
                    End If

                    If Not IsDBNull(DR.Item("grad_ptt_br")) Then
                        ptt = RTrim(DR.Item("grad_ptt_br"))
                    Else
                        ptt = ""
                    End If

                    If Not IsDBNull(DR.Item("grad_porjed")) Then
                        por_jed = RTrim(DR.Item("grad_porjed"))
                    Else
                        por_jed = ""
                    End If

                    podrucje = ""

                Else
                    If Not IsDBNull(DR.Item(2)) Then
                        naziv = RTrim(DR.Item(2))
                    Else
                        naziv = ""
                    End If

                    If Not IsDBNull(DR.Item(3)) Then
                        ptt = RTrim(DR.Item(3))
                    Else
                        ptt = ""
                    End If

                    If Not IsDBNull(DR.Item(4)) Then
                        por_jed = RTrim(DR.Item(4))
                    Else
                        por_jed = ""
                    End If

                    If Not IsDBNull(DR.Item(1)) Then
                        If _naselja = Imena.naselja.opstina Then
                            selektuj_grad(DR.Item(1), Selekcija.po_id)
                            podrucje = _grad_naziv
                        Else
                            selektuj_opstine(DR.Item(1), Selekcija.po_id)
                            podrucje = _opstina_naziv
                        End If
                    Else
                        podrucje = ""
                    End If
                End If

                xmlw.WriteStartElement("podatak")
                xmlw.WriteElementString("tip", _tip)
                xmlw.WriteElementString("naziv", naziv)
                xmlw.WriteElementString("ptt", ptt)
                xmlw.WriteElementString("por_jedinica", por_jed)
                xmlw.WriteElementString("podrucje", podrucje)
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
