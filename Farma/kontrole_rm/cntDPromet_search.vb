Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntDPromet_search

    Private upit As String = ""

    Private upit_datum As String = ""
    Private upit_magacin As String = ""
    Private upit_artikl As String = ""
    Private upit_vrdok As String = ""
    Private upit_zakljuceno As String = ""

    Shared sql_start As String = "select * from rm_dnevni_promet_head"
    Private sql_artikl As String = _
        "SELECT rm_dnevni_promet_head.dp_datum_promene, rm_dnevni_promet_head.dp_rb, " & _
            "rm_artikli.artikl_sifra, rm_artikli.artikl_naziv, rm_dnevni_promet_stavka.dp_art_ulaz, " & _
            "rm_dnevni_promet_stavka.dp_art_izlaz, rm_dnevni_promet_stavka.dp_art_stanje, " & _
            "rm_dnevni_promet_stavka.dp_art_cena, rm_magacin.magacin_sifra, rm_magacin.magacin_naziv, app_vrste_dokumenata.vrsta_dok_naziv " & _
        "FROM app_vrste_dokumenata RIGHT OUTER JOIN " & _
            "rm_dnevni_promet_head ON app_vrste_dokumenata.id_vrsta_dok = rm_dnevni_promet_head.id_vrsta_dok " & _
            "LEFT OUTER JOIN rm_artikli LEFT OUTER JOIN rm_dnevni_promet_stavka ON " & _
            "rm_artikli.id_artikl = rm_dnevni_promet_stavka.id_artikl LEFT OUTER JOIN " & _
            "rm_magacin ON rm_dnevni_promet_stavka.id_magacin = rm_magacin.id_magacin ON " & _
            "rm_dnevni_promet_head.id_dnevni_promet = rm_dnevni_promet_stavka.id_dnevni_promet"

    Shared sql As String = ""
    Private _pocetak As Boolean = True
    Private _poABCedi As Boolean = False
    Private _poArtiklu As Boolean = False
    Private aktivan_chk As Boolean

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntDPromet_search_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mPanel.Dock = DockStyle.Fill

        popuni_magacine()
        popuni_vrste_dokumenta()
        popuni_artikle()

        cmbMagacin.Enabled = False
        cmbMagacin.BackColor = Color.Lavender
        cmbVrDok.Enabled = False
        cmbVrDok.BackColor = Color.Lavender
        cmbArtikl.Enabled = False
        cmbArtikl.BackColor = Color.Lavender

        chkSve.CheckState = CheckState.Unchecked
        chkDatum.CheckState = CheckState.Unchecked
        chkMagacin.CheckState = CheckState.Unchecked
        chkVrDok.CheckState = CheckState.Unchecked
        chkArtikl.CheckState = CheckState.Unchecked

        _lCount = labCount

        _sql_za_print = ""

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

    Private Sub popuni_artikle()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbArtikl.Items.Clear()
        cmbArtikl.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.rm_artikli order by artikl_naziv"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbArtikl.Items.Add(DR.Item("artikl_naziv"))
            Loop
            DR.Close()
        End If
        If cmbArtikl.Items.Count > 0 Then
            cmbArtikl.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_vrste_dokumenta()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbVrDok.Items.Clear()
        cmbVrDok.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_vrste_dokumenata.* from dbo.app_vrste_dokumenata"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbVrDok.Items.Add(DR.Item("vrsta_dok_naziv"))
            Loop
            DR.Close()
        End If
        If cmbVrDok.Items.Count > 0 Then
            cmbVrDok.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub filter()
        On Error Resume Next

        upit = ""
        sql = ""

        If upit_datum <> "" And upit <> "" Then
            upit = upit & " and " & upit_datum
        Else
            If upit_datum <> "" Then upit = upit_datum
        End If

        If upit_magacin <> "" And upit <> "" Then
            upit = upit & " and " & upit_magacin
        Else
            If upit_magacin <> "" Then upit = upit_magacin
        End If

        If upit_artikl <> "" And upit <> "" Then
            upit = upit & " and " & upit_artikl
        Else
            If upit_artikl <> "" Then upit = upit_artikl
        End If

        If upit_vrdok <> "" And upit <> "" Then
            upit = upit & " and " & upit_vrdok
        Else
            If upit_vrdok <> "" Then upit = upit_vrdok
        End If

        If upit_zakljuceno <> "" And upit <> "" Then
            upit = upit & " and " & upit_zakljuceno
        Else
            If upit_zakljuceno <> "" Then upit = upit_zakljuceno
        End If

        sql = sql_start
        If upit <> "" Then
            If _poArtiklu Then
                If upit_magacin <> "" Then
                    sql += " WHERE " & upit
                    Lista_Artikl()
                Else
                    MsgBox("Magacin morate obavezno izabrati. Ponovite pretragu.", MsgBoxStyle.OkOnly)
                End If
            Else
                sql += " WHERE " & upit & " ORDER BY rm_dnevni_promet_head.dp_datum_promene"
                Lista()
            End If
        End If

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
                    Dim podatak As New ListViewItem(CStr(CDate(DR.Item("dp_datum_promene")).Date))

                    selektuj_magacin(DR.Item("id_magacin").ToString, Selekcija.po_id)
                    podatak.SubItems.Add(_magacin_naziv)
                    podatak.SubItems.Add(DR.Item("dp_broj_dok").ToString)

                    selektuj_VrsteDokumenta(DR.Item("id_vrsta_dok").ToString, Selekcija.po_id)
                    podatak.SubItems.Add(_vrsta_dok_naziv)
                    podatak.SubItems.Add(da_ne(DR.Item("dp_zakljucen").ToString))

                    _lista.Items.AddRange(New ListViewItem() {podatak})

                End While
                DR.Close()
            End If

            CM.Dispose()
            CN.Close()
        End If

        _lCount.Text = _lista.Items.Count.ToString + " zapisa"

    End Sub

    Shared Sub Lista_Artikl()

        _listaArt.Visible = True
        _listaArt.Items.Clear()

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
                    Dim podatak As New ListViewItem(CStr(CDate(DR.Item("dp_datum_promene")).Date))

                    podatak.SubItems.Add(DR.Item("magacin_sifra").ToString)
                    podatak.SubItems.Add(DR.Item("vrsta_dok_naziv").ToString)
                    podatak.SubItems.Add(DR.Item("dp_rb").ToString)
                    podatak.SubItems.Add(DR.Item("artikl_sifra").ToString)
                    podatak.SubItems.Add(DR.Item("artikl_naziv").ToString)
                    podatak.SubItems.Add(CInt(DR.Item("dp_art_ulaz")).ToString)
                    podatak.SubItems.Add(CInt(DR.Item("dp_art_izlaz")).ToString)
                    podatak.SubItems.Add(CInt(DR.Item("dp_art_stanje")).ToString)
                    podatak.SubItems.Add(DR.Item("dp_art_cena").ToString)

                    _listaArt.Items.AddRange(New ListViewItem() {podatak})
                End While
                DR.Close()
            End If

            CM.Dispose()
            CN.Close()
        End If

        _lCount.Text = _listaArt.Items.Count.ToString + " zapisa"

    End Sub

    Shared Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function

    Private Sub chkSve_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSve.CheckedChanged
        upit_datum = ""
        upit_magacin = ""
        upit_vrdok = ""
        upit_zakljuceno = ""
        Select Case chkSve.CheckState
            Case CheckState.Checked
                chkDatum.Checked = False
                chkMagacin.Checked = False
                chkVrDok.Checked = False
                chkZakljuceno.Checked = False

                chkDatum.Enabled = False
                chkMagacin.Enabled = False
                chkVrDok.Enabled = False
                chkZakljuceno.Enabled = False
                chkArtikl.Enabled = False

                _lista.Visible = True
                _lista.Dock = DockStyle.Fill
                _listaArt.Visible = False
                _listaArt.Dock = DockStyle.None

                sql = sql_start + " ORDER BY dp_rb" 'rm_kalkulacija_head.kalk_datum DESC"
                Lista()
            Case CheckState.Unchecked
                chkDatum.Enabled = True
                chkMagacin.Enabled = True
                chkVrDok.Enabled = True
                chkZakljuceno.Enabled = True
                chkArtikl.Enabled = True
                _lista.Items.Clear()

        End Select
    End Sub

    Private Sub chkDatum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDatum.CheckedChanged
        Select Case chkDatum.CheckState
            Case CheckState.Checked
                datDatum.Enabled = True
                datDatum.BackColor = Color.GhostWhite
                upit_datum = "rm_dnevni_promet_head.dp_datum_promene = '" & _
                                 datDatum.Value.Month.ToString & "/" & _
                                 datDatum.Value.Day.ToString & "/" & _
                                 datDatum.Value.Year.ToString & "'"
            Case CheckState.Unchecked
                datDatum.Enabled = False
                datDatum.BackColor = Color.Lavender
                datDatum.Value = Today
                upit_datum = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub chkMagacin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMagacin.CheckedChanged
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
        proveri_formu()
    End Sub

    Private Sub chkArtikl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkArtikl.CheckedChanged
        Select Case chkArtikl.CheckState
            Case CheckState.Checked
                cmbArtikl.Enabled = True
                cmbArtikl.BackColor = Color.GhostWhite
                chkMagacin.Checked = True
                cmbMagacin.Enabled = True
                cmbMagacin.BackColor = Color.GhostWhite
                _poArtiklu = True
                _lista.Items.Clear()
                _lista.Visible = False
                _lista.Dock = DockStyle.None
                _listaArt.Visible = True
                _listaArt.Dock = DockStyle.Fill

            Case CheckState.Unchecked
                cmbArtikl.Enabled = False
                cmbArtikl.BackColor = Color.Lavender
                cmbArtikl.Text = ""
                chkMagacin.Checked = False
                cmbMagacin.Enabled = False
                cmbMagacin.BackColor = Color.Lavender
                cmbMagacin.Text = ""
                upit_artikl = ""
                upit_magacin = ""
                _lista.Visible = True
                _lista.Dock = DockStyle.Fill
                _listaArt.Items.Clear()
                _listaArt.Visible = False
                _listaArt.Dock = DockStyle.None

                _poArtiklu = False
        End Select
        proveri_formu()
    End Sub

    Private Sub chkVrDok_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVrDok.CheckedChanged
        Select Case chkVrDok.CheckState
            Case CheckState.Checked
                cmbVrDok.Enabled = True
                cmbVrDok.BackColor = Color.GhostWhite
            Case CheckState.Unchecked
                cmbVrDok.Enabled = False
                cmbVrDok.BackColor = Color.Lavender
                cmbVrDok.Text = ""
                upit_vrdok = ""
        End Select
        proveri_formu()
    End Sub

    Private Sub chkZakljuceno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkZakljuceno.CheckedChanged
        Select Case chkZakljuceno.CheckState
            Case CheckState.Checked
                upit_zakljuceno = "rm_dnevni_promet.dp_zakljucen = true"
            Case CheckState.Unchecked
                upit_zakljuceno = ""
        End Select
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

    Private Sub datDatum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles datDatum.KeyPress
        If e.KeyChar = Chr(13) Then
            upit_datum = "rm_dnevni_promet_head.dp_datum_promene = '" & _
                                 datDatum.Value.Month.ToString & "/" & _
                                 datDatum.Value.Day.ToString & "/" & _
                                 datDatum.Value.Year.ToString & "'"
            filter()
        End If
    End Sub
    Private Sub datDatum_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datDatum.ValueChanged
        upit_datum = "rm_dnevni_promet_head.dp_datum_promene = '" & _
                        datDatum.Value.Month.ToString & "/" & _
                        datDatum.Value.Day.ToString & "/" & _
                        datDatum.Value.Year.ToString & "'" '& _
        '" ##:##:##"
    End Sub

    Private Sub cmbMagacin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMagacin.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbMagacin.Text <> "" Then
                upit_magacin = "rm_magacin.magacin_naziv = N'" & cmbMagacin.Text & "'"
            Else
                upit_magacin = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbMagacin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMagacin.SelectedIndexChanged
        If cmbMagacin.Text <> "" Then
            'selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)
            upit_magacin = "magacin_naziv = N'" & cmbMagacin.Text & "'"
        Else
            upit_magacin = ""
        End If
    End Sub

    Private Sub cmbArtikl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbArtikl.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbArtikl.Text <> "" Then
                upit_artikl = "artikl_naziv = N'" & cmbArtikl.Text & "'"
            Else
                upit_artikl = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbArtikl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbArtikl.SelectedIndexChanged
        If cmbArtikl.Text <> "" Then
            'selektuj_artikl(cmbArtikl.Text, Selekcija.po_nazivu)
            upit_artikl = "artikl_naziv = N'" & cmbArtikl.Text & "'"
        Else
            upit_artikl = ""
        End If
    End Sub

    Private Sub cmbVrDok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbVrDok.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbVrDok.Text <> "" Then
                selektuj_VrsteDokumenta(cmbVrDok.Text, Selekcija.po_nazivu)
                upit_vrdok = "id_vrsta_dok = " & _id_vrsta_dok  '"app_vrste_dokumenata.vrsta_dok_naziv = N'" & cmbVrDok.Text & "'"
            Else
                upit_vrdok = ""
            End If
            filter()
        End If
    End Sub
    Private Sub cmbVrDok_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVrDok.SelectedIndexChanged
        If cmbVrDok.Text <> "" Then
            selektuj_VrsteDokumenta(cmbVrDok.Text, Selekcija.po_nazivu)
            upit_vrdok = "id_vrsta_dok = " & _id_vrsta_dok  '"app_vrste_dokumenata.vrsta_dok_naziv = N'" & cmbVrDok.Text & "'"
        Else
            upit_vrdok = ""
        End If
    End Sub

    Private Sub proveri_formu()
        'Dim mCont As Control ' CheckBox
        Dim mChack As Object

        aktivan_chk = False
        For Each mChack In mPanel2.Controls
            If mChack.name = "chkDatum" Or mChack.name = "chkMagacin" Or mChack.name = "chkVrDok" _
                    Or mChack.name = "chkZakljuceno" Then
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
