Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntSpecifikacije_nivelacije

#Region "dekleracija"
    Private upit As String = ""
    Private upit_datum_od As String = ""
    Private upit_datum_do As String = ""
    Private upit_magacin As String = ""

    Shared sql As String = ""

    Private sql_start As String = _
          "SELECT DISTINCT * FROM rm_nivelacije_head"

    Private _pocetak As Boolean = True
    Private _poABCedi As Boolean = False
    Private _poArtiklu As Boolean = False
    Private aktivan_chk As Boolean
    Private stanje As Single

    Private _ekran As Boolean = False
    Private _printer As Boolean = False
    Private _excell As Boolean = False
    Private _word As Boolean = False
    Private _pdf As Boolean = False
    Private _html As Boolean = False

    Private _cena As Single
    Private _stara_vred As Single
    Private _nova_vred As Single
    Private _razlika As Single

#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntSpecifikacije_nivelacije_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mPanel.Dock = DockStyle.Fill

        popuni_magacine()

        cmbMagacin.Enabled = False
        cmbMagacin.BackColor = Color.Lavender

        datDatumOd.Enabled = True
        datDatumDo.Enabled = True
        datDatumOd.Value = CDate("1/" & Today.Month.ToString & "/" & Today.Year.ToString)
        datDatumDo.Value = Today

        chkDatum.CheckState = CheckState.Checked
        chkMagacin.CheckState = CheckState.Unchecked

        rbtEkran.Checked = True
        rbtPrinter.Checked = False
        rbtExcel.Checked = False
        rbtHtml.Checked = False
        rbtPdf.Checked = False
        rbtWord.Checked = False

        _text_magacin = "Svi"
        _text_partner = "Svi"
        _text_oj = "Svi"
    End Sub

    Private Sub popuni_magacine()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbMagacin.Items.Clear()
        cmbMagacin.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_magacin.* from dbo.rm_magacin"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbMagacin.Items.Add(DR.Item("magacin_naziv"))
            Loop
            DR.Close()
        End If
        If cmbMagacin.Items.Count > 0 Then
            cmbMagacin.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub filter()

        upit = ""
        sql = sql_start

        If upit_datum_od <> "" And upit <> "" Then
            upit = upit & " and " & upit_datum_od
        Else
            If upit_datum_od <> "" Then upit = upit_datum_od
        End If

        If upit_datum_do <> "" And upit <> "" Then
            upit = upit & " and " & upit_datum_do
        Else
            If upit_datum_do <> "" Then upit = upit_datum_do
        End If

        If upit_magacin <> "" And upit <> "" Then
            upit = upit & " and " & upit_magacin
        Else
            If upit_magacin <> "" Then upit = upit_magacin
        End If

        If upit <> "" Then
            sql = sql_start & " WHERE " & upit & " ORDER BY id_nivelacija"
            'sql = sql_start & " and " & upit & " ORDER BY id_nivelacija"
            If _ekran Then Lista()
            If _printer Then stampanje()
            'If _Excel Then
            'If _html Then
            'If _pdf Then
            'If _word Then
        End If
    End Sub

    Private Sub Lista()
        Try
            Dim listView1 As New ListView()
            listView1.View = View.Details
            listView1.LabelEdit = True
            listView1.AllowColumnReorder = False
            listView1.FullRowSelect = True
            listView1.GridLines = True
            listView1.Dock = DockStyle.Fill
            listView1.BringToFront()
            listView1.ForeColor = Color.MidnightBlue

            listView1.Columns.Add("Br.dok.", 80, HorizontalAlignment.Left)
            listView1.Columns.Add("Datum", 80, HorizontalAlignment.Left)
            listView1.Columns.Add("Opis", 100, HorizontalAlignment.Left)
            listView1.Columns.Add("Predh.vred.", 90, HorizontalAlignment.Right)
            listView1.Columns.Add("Nova vred.", 90, HorizontalAlignment.Right)
            listView1.Columns.Add("Razlika", 90, HorizontalAlignment.Right)

            Dim CN As SqlConnection = New SqlConnection(CNNString)
            Dim CM As New SqlCommand
            Dim DR As SqlDataReader
            Dim myControl As New cntLista

            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = sql
                    DR = .ExecuteReader
                End With

                Do While DR.Read
                    Dim podatak As New ListViewItem(DR.Item("broj").ToString)
                    podatak.SubItems.Add(DR.Item("datum").ToString)
                    podatak.SubItems.Add("")
                    podatak.SubItems.Add(DR.Item("stara_vrednost").ToString)
                    podatak.SubItems.Add(DR.Item("nova_vrednost").ToString)
                    podatak.SubItems.Add(DR.Item("razlika_uceni").ToString)

                    listView1.Items.AddRange(New ListViewItem() {podatak})
                Loop
            End If

            mdiMain.zatvori_kontrolu_desno()

            _forma_zapovratak = Me

            listView1.Dock = DockStyle.Fill

            myControl.Parent = mdiMain.splRadni.Panel2
            myControl.Dock = DockStyle.Fill
            myControl.Panel.Controls.Add(listView1)
            myControl.Panel.SetRow(listView1, 1)
            myControl.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Shared Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function

    Private Sub chkDatum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDatum.CheckedChanged
        Select Case chkDatum.CheckState
            Case CheckState.Checked
                datDatumOd.Enabled = True
                datDatumOd.BackColor = Color.GhostWhite
                datDatumDo.Enabled = True
                datDatumDo.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                datDatumOd.Enabled = False
                datDatumOd.BackColor = Color.Lavender
                datDatumDo.Value = Today
                datDatumDo.Enabled = False
                datDatumDo.BackColor = Color.Lavender
                datDatumOd.Value = Today
                upit_datum_od = ""
                upit_datum_do = ""
        End Select
        'proveri_formu()
    End Sub

    Private Sub chkMagacin_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMagacin.CheckedChanged
        Select Case chkMagacin.CheckState
            Case CheckState.Checked
                cmbMagacin.Enabled = True
                cmbMagacin.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbMagacin.Enabled = False
                cmbMagacin.BackColor = Color.Lavender
                cmbMagacin.Text = ""
                upit_magacin = ""
        End Select
    End Sub

    Private Sub chkABC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case chkABC.CheckState
            Case CheckState.Checked
                _poABCedi = True
            Case CheckState.Unchecked
                _poABCedi = False
        End Select
    End Sub
    Private Sub chkABC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub datDatumOd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datDatumOd.KeyPress
        If e.KeyChar = Chr(13) Then
            upit_datum_od = "datum >= '" & _
                                 datDatumOd.Value.Month.ToString & "/" & _
                                 datDatumOd.Value.Day.ToString & "/" & _
                                 datDatumOd.Value.Year.ToString & "'"
        End If
    End Sub
    Private Sub datDatumOd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datDatumOd.ValueChanged
        upit_datum_od = "datum >= '" & _
                                datDatumOd.Value.Month.ToString & "/" & _
                                datDatumOd.Value.Day.ToString & "/" & _
                                datDatumOd.Value.Year.ToString & "'"
    End Sub

    Private Sub datDatumDo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datDatumDo.KeyPress
        If e.KeyChar = Chr(13) Then
            upit_datum_do = "datum <= '" & _
                                 datDatumDo.Value.Month.ToString & "/" & _
                                 datDatumDo.Value.Day.ToString & "/" & _
                                 datDatumDo.Value.Year.ToString & "'"
        End If
    End Sub
    Private Sub datDatumDo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datDatumDo.ValueChanged
        upit_datum_do = "datum <= '" & _
                                datDatumDo.Value.Month.ToString & "/" & _
                                datDatumDo.Value.Day.ToString & "/" & _
                                datDatumDo.Value.Year.ToString & "'"
    End Sub

    Private Sub cmbMagacin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMagacin.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbMagacin.Text <> "" Then
                selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)
                upit_magacin = "id_magacin = " & _id_magacin
                labMagacin.Text = cmbMagacin.Text
                _text_magacin = cmbMagacin.Text '+ " - PROIZVODJAČ: " + cmbPartner.Text
            Else
                upit_magacin = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbMagacin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMagacin.SelectedIndexChanged
        If cmbMagacin.Text <> "" Then
            selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)
            upit_magacin = "id_magacin = " & _id_magacin
            labMagacin.Text = cmbMagacin.Text
            _text_magacin = cmbMagacin.Text '+ " - PROIZVODJAČ: " + cmbPartner.Text
        Else
            upit_magacin = ""
        End If
    End Sub

    Private Sub rbtEkran_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtEkran.CheckedChanged
        Select Case rbtEkran.Checked
            Case True
                _ekran = True
            Case False
                _ekran = False
        End Select
    End Sub

    Private Sub rbtPrinter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPrinter.CheckedChanged
        Select Case rbtPrinter.Checked
            Case True
                _printer = True
            Case False
                _printer = False
        End Select
    End Sub

    Private Sub rbtHtml_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtHtml.CheckedChanged
        Select Case rbtHtml.Checked
            Case True
                _html = True
            Case False
                _html = False
        End Select
    End Sub

    Private Sub rbtPdf_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPdf.CheckedChanged
        Select Case rbtPdf.Checked
            Case True
                _pdf = True
            Case False
                _pdf = False
        End Select
    End Sub

    Private Sub rbtWord_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtWord.CheckedChanged
        Select Case rbtWord.Checked
            Case True
                _word = True
            Case False
                _word = False
        End Select
    End Sub

    Private Sub rbtExcel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtExcel.CheckedChanged
        Select Case rbtExcel.Checked
            Case True
                _excell = True
            Case False
                _excell = False
        End Select
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        filter()
    End Sub

#Region "STAMPANJE"
    Private id_promene As Integer = 0
    Private mag_datum_promene_od As Date '= datDatumOd.Value
    Private mag_datum_promene_do As Date '= datDatumDo.Value
    Private mag_datum_promene As Date = Today

    Private Sub stampanje()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prn_nivelacija_delete"
                .ExecuteScalar()
            End With
            CM.Dispose()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql_start & " WHERE " & upit & " ORDER BY id_nivelacija"
                DR = .ExecuteReader
            End With

            Do While DR.Read

                unesi(DR.Item("broj"), DR.Item("datum"), DR.Item("stara_vrednost"), _
                      DR.Item("nova_vrednost"), DR.Item("razlika_uceni"))

            Loop
            DR.Close()
            CM.Dispose()
        End If
        CN.Close()
        _raport = Imena.tabele.rm_specifikacija_nivelacija.ToString
        Dim mForm As New frmPrint
        mForm.Show()
    End Sub

    Private Sub unesi(ByVal broj, ByVal datum, ByVal stara_vred, ByVal nova_vred, ByVal razlika)

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prn_nivelacija_add"
                .Parameters.AddWithValue("@broj", broj)
                .Parameters.AddWithValue("@id_magacin", _id_magacin)
                .Parameters.AddWithValue("@datum", datum)
                .Parameters.AddWithValue("@stara_vrednost", stara_vred)
                .Parameters.AddWithValue("@nova_vrednost", nova_vred)
                .Parameters.AddWithValue("@razlika_uceni", razlika)
                .Parameters.AddWithValue("@stari_iznos_pdv", 0)
                .Parameters.AddWithValue("@novi_iznos_pdv", 0)
                .Parameters.AddWithValue("@razlika_pdv", 0)
                .Parameters.AddWithValue("@unesena", 0)
                .Parameters.AddWithValue("@rb", 0)
                .Parameters.AddWithValue("@id_artikl", 0)
                .Parameters.AddWithValue("@atr_jkl", "")
                .Parameters.AddWithValue("@roba_sifra", "")
                .Parameters.AddWithValue("@id_grupa", "")
                .Parameters.AddWithValue("@roba_naziv", "")
                .Parameters.AddWithValue("@id_jm", "")
                .Parameters.AddWithValue("@kolicina", 0)
                .Parameters.AddWithValue("@stav_stara_cena", 0)
                .Parameters.AddWithValue("@stav_stara_vrednost", 0)
                .Parameters.AddWithValue("@stav_nova_cena", 0)
                .Parameters.AddWithValue("@stav_nova_vrednost", 0)
                .Parameters.AddWithValue("@stav_razlika_cena", 0)
                .Parameters.AddWithValue("@stav_stari_pdv", 0)
                .Parameters.AddWithValue("@stav_stari_iznos_pdv", 0)
                .Parameters.AddWithValue("@stav_novi_pdv", 0)
                .Parameters.AddWithValue("@stav_novi_iznos_pdv", 0)
                .Parameters.AddWithValue("@stav_razlika_pdv", 0)
                .Parameters.AddWithValue("@mag_datum_promene_od", datDatumOd.Value.Date)
                .Parameters.AddWithValue("@mag_datum_promene_do", datDatumDo.Value.Date)
                .ExecuteScalar()
            End With
            CM.Dispose()
        End If
        CN.Close()
    End Sub

#End Region

End Class
