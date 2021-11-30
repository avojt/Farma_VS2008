Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntMagIntPrenos_search

#Region "dekleracija"
    Private upit As String = ""

    Private upit_broj As String = ""
    Private upit_magacin As String = ""
    Private upit_magacin_u As String = ""
    Private upit_datum As String = ""
    Private upit_zakljcene As String = ""

    Shared sql_start As String = _
                "SELECT DISTINCT " & _
                    " id_magacina_iz, id_magacina_u, mip_broj, mip_datum, mip_ukupno, mip_svega, mip_zakljucena " & _
                "FROM rm_mag_interni_prenos_head "

    Shared sql As String = ""
    Private _pocetak As Boolean = True
    Private _poABCedi As Boolean = False
    Private aktivan_chk As Boolean
#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntMagIntPrenos_search_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        popuni_Magacine()
        popuni_magacin_U()

        txtBroj.Enabled = False
        cmbMagacin.Enabled = False
        cmbMagacin.BackColor = Color.Lavender
        cmbMagacin_U.Enabled = False
        cmbMagacin_U.BackColor = Color.Lavender

        chkBroj.CheckState = CheckState.Unchecked
        chkDatum.CheckState = CheckState.Unchecked
        chkMagacin.CheckState = CheckState.Unchecked
        chkMagacin_U.CheckState = CheckState.Unchecked

        rbtZaklj.Checked = False
        rbtNezaklj.Checked = False

        _lCount = labCount

        mPanel.Dock = DockStyle.Fill

    End Sub

    Private Sub popuni_Magacine()
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

    Private Sub popuni_magacin_U()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbMagacin_U.Items.Clear()
        cmbMagacin_U.Items.Add("")

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
                cmbMagacin_U.Items.Add(DR.Item("magacin_naziv"))
            Loop
            DR.Close()
        End If
        If cmbMagacin_U.Items.Count > 0 Then
            cmbMagacin_U.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub filter()
        On Error Resume Next

        upit = ""
        sql = ""

        If upit_magacin <> "" And upit <> "" Then
            upit = upit & " and " & upit_magacin
        Else
            If upit_magacin <> "" Then upit = upit_magacin
        End If

        If upit_magacin_u <> "" And upit <> "" Then
            upit = upit & " and " & upit_magacin_u
        Else
            If upit_magacin_u <> "" Then upit = upit_magacin_u
        End If

        If upit_datum <> "" And upit <> "" Then
            upit = upit & " and " & upit_datum
        Else
            If upit_datum <> "" Then upit = upit_datum
        End If

        If upit_broj <> "" And upit <> "" Then
            upit = upit & " and " & upit_broj
        Else
            If upit_broj <> "" Then upit = upit_broj
        End If

        If upit_zakljcene <> "" And upit <> "" Then
            upit = upit & " and " & upit_zakljcene
        Else
            If upit_zakljcene <> "" Then upit = upit_zakljcene
        End If

        If upit <> "" Then
            sql = sql_start & " WHERE " & upit & " ORDER BY rm_mag_interni_prenos_head.mip_datum DESC," & _
                                                 " rm_mag_interni_prenos_head.mip_broj DESC"
            'If _poABCedi Then sql += ", dbo.rm_kalkulacija_head.kalk_broj" 'ASC" DESC" 'ascending
        End If

        Lista()

    End Sub

    Shared Sub Lista()

        _lista.Visible = True
        _lista.Items.Clear()

        If sql <> sql_start Then
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

                '_lista.Groups.Add(New ListViewGroup("Neparna", HorizontalAlignment.Left))
                '_lista.Groups.Add(New ListViewGroup("Parna", HorizontalAlignment.Left))
                While DR.Read
                    Dim podatak As New ListViewItem(CStr(DR.Item("mip_broj")))

                    podatak.SubItems.Add(DR.Item("mip_datum"))
                    selektuj_magacin(DR.Item("id_magacina_iz").ToString, Selekcija.po_id)
                    podatak.SubItems.Add(_magacin_naziv)
                    selektuj_magacin(DR.Item("id_magacina_u").ToString, Selekcija.po_id)
                    podatak.SubItems.Add(_magacin_naziv)
                    podatak.SubItems.Add(DR.Item("mip_ukupno").ToString)
                    podatak.SubItems.Add(da_ne(DR.Item("mip_zakljucena").ToString))

                    _lista.Items.AddRange(New ListViewItem() {podatak})

                    Dim broj As Single = CDec(DR.Item("mip_broj"))
                    'If 0 = Decimal.Divide(broj, 2) Then
                    If broj Mod 2 = 0 Then
                        _lista.Items.Item(0).BackColor = Color.LightSteelBlue
                    Else
                        _lista.Items.Item(0).BackColor = Color.GhostWhite
                    End If
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

    Private Sub rbtZaklj_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtZaklj.CheckedChanged
        Select Case rbtZaklj.Checked
            Case True
                rbtNezaklj.Checked = False
                upit_zakljcene = "rm_mag_interni_prenos_head.mip_zakljucena = 1"
            Case False
                upit_zakljcene = ""
        End Select
        filter()
    End Sub

    Private Sub rbtNezaklj_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNezaklj.CheckedChanged
        Select Case rbtNezaklj.Checked
            Case True
                rbtZaklj.Checked = False
                upit_zakljcene = "rm_mag_interni_prenos_head.mip_zakljucena = 0"
            Case False
                upit_zakljcene = ""
        End Select
        filter()
    End Sub

    Private Sub chkSve_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSve.CheckedChanged
        upit_broj = ""
        upit_magacin = ""
        upit_datum = ""
        upit_magacin_u = ""
        Select Case chkSve.CheckState
            Case CheckState.Checked
                chkBroj.Checked = False
                chkDatum.Checked = False
                chkMagacin_U.Checked = False
                chkMagacin.Checked = False

                chkBroj.Enabled = False
                chkDatum.Enabled = False
                chkMagacin_U.Enabled = False
                chkMagacin.Enabled = False
                sql = sql_start + " ORDER BY rm_mag_interni_prenos_head.mip_datum DESC"
                'filter()
                Lista()
            Case CheckState.Unchecked
                chkBroj.Enabled = True
                chkDatum.Enabled = True
                chkMagacin_U.Enabled = True
                chkMagacin.Enabled = True
                _lista.Items.Clear()
        End Select
        'proveri_formu()
    End Sub

    Private Sub chkBroj_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkBroj.CheckedChanged
        Select Case chkBroj.CheckState
            Case CheckState.Checked
                txtBroj.Enabled = True
                txtBroj.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                txtBroj.Enabled = False
                txtBroj.BackColor = Color.Lavender
                upit_magacin = ""
                txtBroj.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub chkDatum_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDatum.CheckedChanged
        Select Case chkDatum.CheckState
            Case CheckState.Checked
                datDatum.Enabled = True
                datDatum.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                datDatum.Enabled = False
                datDatum.BackColor = Color.Lavender
                datDatum.Value = Today
                upit_datum = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub chkDobavljac_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMagacin_U.CheckedChanged
        Select Case chkMagacin_U.CheckState
            Case CheckState.Checked
                cmbMagacin_U.Enabled = True
                cmbMagacin_U.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbMagacin_U.Enabled = False
                cmbMagacin_U.BackColor = Color.Lavender
                upit_magacin = ""
                cmbMagacin_U.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub chkMagacin_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMagacin.CheckedChanged
        Select Case chkMagacin.CheckState
            Case CheckState.Checked
                cmbMagacin.Enabled = True
                cmbMagacin.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbMagacin.Enabled = False
                cmbMagacin.BackColor = Color.Lavender
                upit_magacin = ""
                cmbMagacin.Text = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub cmbMagacin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMagacin.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbMagacin.Text <> "" Then
                selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)
                upit_magacin = "rm_mag_interni_prenos_head.id_magacina_iz = " & _id_magacin
            Else
                upit_magacin = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbMagacin_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMagacin.SelectedIndexChanged
        If cmbMagacin.Text <> "" Then
            selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)
            upit_magacin = "rm_mag_interni_prenos_head.id_magacina_iz = " & _id_magacin
        Else
            upit_magacin = ""
        End If
    End Sub

    Private Sub cmbDobavljac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMagacin_U.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbMagacin_U.Text <> "" Then
                selektuj_magacin(cmbMagacin_U.Text, Selekcija.po_nazivu)
                upit_magacin_u = "rm_mag_interni_prenos_head.id_magacina_u = " & _id_magacin
            Else
                upit_magacin_u = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbDobavljac_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMagacin_U.SelectedIndexChanged
        If cmbMagacin_U.Text <> "" Then
            selektuj_magacin(cmbMagacin_U.Text, Selekcija.po_nazivu)
            upit_magacin_u = "rm_mag_interni_prenos_head.id_magacina_u = " & _id_magacin
        Else
            upit_magacin_u = ""
        End If
    End Sub

    Private Sub txtBroj_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBroj.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtBroj.Text <> "" Then
                upit_broj = "rm_mag_interni_prenos_head.mip_broj = " & txtBroj.Text '& "%'"
            Else
                upit_broj = ""
            End If
            filter()
        End If
    End Sub
    Private Sub txtBroj_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBroj.TextChanged
        If txtBroj.Text <> "" Then
            upit_broj = "rm_mag_interni_prenos_head.mip_broj = " & txtBroj.Text '& "%'"
        Else
            upit_broj = ""
        End If
        'filter()
    End Sub

    Private Sub datDatum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datDatum.KeyPress
        If e.KeyChar = Chr(13) Then
            upit_datum = "rm_mag_interni_prenos_head.mip_datum = '" & _
                                 datDatum.Value.Month.ToString & "/" & _
                                 datDatum.Value.Day.ToString & "/" & _
                                 datDatum.Value.Year.ToString & "'"
            filter()
        End If
    End Sub
    Private Sub datDatum_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles datDatum.ValueChanged
        upit_datum = "rm_mag_interni_prenos_head.mip_datum = '" & _
                              datDatum.Value.Month.ToString & "/" & _
                        datDatum.Value.Day.ToString & "/" & _
                        datDatum.Value.Year.ToString & "'" '& _
        '" ##:##:##"

        'filter()
    End Sub



    Private Sub chkABC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkABC.CheckedChanged
        Select Case chkABC.CheckState
            Case CheckState.Checked
                _poABCedi = True
            Case CheckState.Unchecked
                _poABCedi = False
        End Select
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

    Private Sub proveri_formu()
        'Dim mCont As Control ' CheckBox
        Dim mChack As Object

        aktivan_chk = False
        For Each mChack In mPanel2.Controls
            If mChack.name = "chkMagacin" Or mChack.name = "chkDatum" _
                    Or mChack.name = "chkBroj" Or mChack.name = "chkMagacin_U" Then
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

End Class
