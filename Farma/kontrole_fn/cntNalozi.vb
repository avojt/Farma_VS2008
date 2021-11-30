Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntNalozi_staro
    Private upit As String = ""
    Private upit_broj As String = ""
    Private upit_datum_od As String = ""
    Private upit_datum_do As String = ""

    Private upit_konto As String = ""

    Private sql As String = "SELECT * FROM dbo.fn_nalog_head"
    Private sql_gl As String = "SELECT * FROM dbo.fn_nalog_stavka"

    Private _pocetak As Boolean = True

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntNalozi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        pocetak()
        _pocetak = False
        lista()

    End Sub

    Private Sub pocetak()
        txtBroj.Text = ""
        dateKnjizenjaOD.Value = Today

    End Sub

    Private Sub tabControl_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabControl.TabIndexChanged
        Select Case tabControl.SelectedIndex
            Case 0 ' "tabPredracuni"
                _tab = Imena.tabele.fn_dnevnik.ToString
                pocetak()
                lista()
                txtBroj.Enabled = True
                txtKonto.Enabled = False
            Case 1 '"tabRacuni"
                _tab = Imena.tabele.fn_glavna_knjiga.ToString
                pocetak()
                lista_gl()
                txtBroj.Enabled = False
                txtKonto.Enabled = True
        End Select
    End Sub

    Private Sub tabControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabControl.SelectedIndexChanged
        Select Case tabControl.SelectedIndex
            Case 0 ' "tabPredracuni"
                _tab = Imena.tabele.fn_dnevnik.ToString
                pocetak()
                lista()
                txtBroj.Enabled = True
                txtKonto.Enabled = False
            Case 1 '"tabRacuni"
                _tab = Imena.tabele.fn_glavna_knjiga.ToString
                pocetak()
                lista_gl()
                txtBroj.Enabled = False
                txtKonto.Enabled = True
        End Select
    End Sub

    Shared Sub myUpdate()
        If bukmark = 0 Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            Select Case _tab
                Case Imena.tabele.fn_dnevnik.ToString
                    selektuj_nalog(bukmark, _nal_vrsta, Selekcija.po_sifri)
                    Dim myChild As New cntNalog_edit
                    myChild.Show()
                Case Imena.tabele.fn_glavna_knjiga.ToString
                    MsgBox("Možete editovati samo naloge", MsgBoxStyle.OkOnly)
            End Select

        End If
    End Sub

    Shared Sub myDelete()
        If bukmark = 0 Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            Select Case _tab
                Case Imena.tabele.fn_dnevnik.ToString
                    Dim poruka As String = "Da li ste sigurno da želite da izbrišete zapis sa sifrom " & bukmark & " ?"
                    If MsgBox(poruka, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

                        selektuj_nalog(bukmark, _nal_vrsta, Selekcija.po_sifri)

                        Dim CN As SqlConnection = New SqlConnection(CNNString)
                        Dim CM As New SqlCommand

                        CN.Open()
                        If CN.State = ConnectionState.Open Then
                            CM = New SqlCommand()
                            With CM
                                .Connection = CN
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "fn_nalog_stavka_del_nalog"
                                .Parameters.AddWithValue("@id_nalog", _id_nalog)
                                .ExecuteScalar()
                            End With
                            CM.Dispose()
                        End If

                        If CN.State = ConnectionState.Open Then
                            CM = New SqlCommand()
                            With CM
                                .Connection = CN
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "fn_nalog_head_delete"
                                .Parameters.AddWithValue("@broj", _nal_broj)
                                .ExecuteScalar()
                            End With
                            CM.Dispose()
                        End If
                        CN.Close()
                    Else
                        Exit Sub
                    End If

                Case Imena.tabele.fn_glavna_knjiga.ToString
                    MsgBox("Možete brisati samo naloge", MsgBoxStyle.OkOnly)
            End Select


        End If
    End Sub

    Shared Sub nalog_prn()
        If bukmark = 0 Then
            MsgBox("Prvo morate izabrati stavku koji želite da štampate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            selektuj_nalog(bukmark, _nal_vrsta, Selekcija.po_sifri)
            nalog_print()

            _raport = Imena.tabele.fn_nalog.ToString
            Dim mForm As New frmPrint
            mForm.Show()
        End If
    End Sub

    Private Sub filter()

        On Error Resume Next
        If Not _pocetak Then
            If upit_broj <> "" Then upit = upit_broj

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

            If upit <> "" Then
                sql = "SELECT * FROM dbo.fn_nalog_head where dbo.fn_nalog_head." & upit
                lista()
            End If
        End If
        upit = ""
        'upit_broj = ""
        'upit_datum_knjizenja = ""
        sql = "SELECT * FROM dbo.fn_nalog_head"
    End Sub

    Private Sub lista()

        lvNalozi.Items.Clear()

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Dim duguje As Single = 0
        Dim potrazuje As Single = 0

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
                Dim podatak As New ListViewItem(CStr(DR.Item("nal_broj")), 0)
                podatak.SubItems.Add(DR.Item("nal_datum"))
                podatak.SubItems.Add(DR.Item("nal_duguje"))
                podatak.SubItems.Add(DR.Item("nal_potrazuje"))
                podatak.SubItems.Add(da_ne(DR.Item("nal_proknjizen")))

                lvNalozi.Items.AddRange(New ListViewItem() {podatak}) ', item2, item3})

                duguje += DR.Item("nal_duguje")
                potrazuje += DR.Item("nal_potrazuje")

            End While
            DR.Close()
        End If
        Dim podatak1 As New ListViewItem
        Dim podatak2 As New ListViewItem
        Dim podatak3 As New ListViewItem

        podatak1.Tag = " "
        podatak1.SubItems.Add("")
        podatak1.SubItems.Add("")
        podatak1.SubItems.Add("")
        podatak1.SubItems.Add("")
        podatak1.SubItems.Add("")

        podatak2.Tag = "Ukupno"
        podatak2.ForeColor = Color.Chocolate
        podatak2.SubItems.Add("Ukupno")
        podatak2.SubItems.Add(Format(duguje, "##,##0.00"))
        podatak2.SubItems.Add(Format(potrazuje, "##,##0.00"))
        podatak2.SubItems.Add("")

        podatak3.Tag = "Saldo"
        podatak3.ForeColor = Color.Chocolate
        podatak3.SubItems.Add("Saldo")
        podatak3.SubItems.Add("")
        podatak3.SubItems.Add(Format(duguje - potrazuje, "##,##0.00").ToString)
        podatak3.SubItems.Add("")

        lvNalozi.Items.AddRange(New ListViewItem() {podatak1, podatak2, podatak3})

        CM.Dispose()
        CN.Close()

        _lista = lvNalozi
    End Sub

    Private Sub filter_gl()
        On Error Resume Next
        If Not _pocetak Then
            If upit_konto <> "" And upit <> "" Then
                upit = upit & " and " & upit_konto
            Else
                If upit_konto <> "" Then upit = upit_konto
            End If

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

            If upit <> "" Then
                sql_gl = "SELECT * FROM dbo.nalog_stavka where dbo.nalog_stavka." & upit
                lista_gl()
            End If
        End If

        upit = ""
        'upit_konto = ""
        'upit_datum_knjizenja = ""
        sql_gl = "SELECT * FROM dbo.nalog_stavka"
    End Sub

    Private Sub lista_gl()

        lvGlavnaK.Items.Clear()

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Dim duguje As Single = 0
        Dim potrazuje As Single = 0

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql_gl
                DR = .ExecuteReader
            End With

            While DR.Read
                Dim podatak As New ListViewItem(datum(DR.Item("id_nalog")), 0)
                podatak.SubItems.Add(DR.Item("stavka_opis_sifra"))
                podatak.SubItems.Add(DR.Item("stavka_opis"))
                podatak.SubItems.Add(DR.Item("stavka_konto"))
                podatak.SubItems.Add(DR.Item("stavka_analitika"))
                podatak.SubItems.Add(DR.Item("stavka_duguje"))
                podatak.SubItems.Add(DR.Item("stavka_potrazuje"))
                podatak.SubItems.Add(DR.Item("stavka_brDok"))
                podatak.SubItems.Add(DR.Item("stavka_datDok"))

                lvGlavnaK.Items.AddRange(New ListViewItem() {podatak}) ', item2, item3})

                duguje += DR.Item("stavka_duguje")
                potrazuje += DR.Item("stavka_potrazuje")

            End While
            DR.Close()
        End If
        Dim podatak1 As New ListViewItem
        Dim podatak2 As New ListViewItem
        Dim podatak3 As New ListViewItem

        podatak1.Tag = " "
        podatak1.SubItems.Add("")
        podatak1.SubItems.Add("")
        podatak1.SubItems.Add("")
        podatak1.SubItems.Add("")
        podatak1.SubItems.Add("")
        podatak1.SubItems.Add("")

        podatak2.Tag = "Ukupno"
        podatak2.ForeColor = Color.Chocolate
        podatak2.SubItems.Add("")
        podatak2.SubItems.Add("")
        podatak2.SubItems.Add("Ukupno")
        'podatak2.SubItems.Add(Format(duguje), 2))
        'podatak2.SubItems.Add(Format(potrazuje), 2))
        podatak2.SubItems.Add(Format(duguje, "##,##0.00"))
        podatak2.SubItems.Add(Format(potrazuje, "##,##0.00"))

        podatak3.Tag = "Saldo"
        podatak3.ForeColor = Color.Chocolate
        podatak3.SubItems.Add("")
        podatak3.SubItems.Add("")
        podatak3.SubItems.Add("Saldo")
        podatak3.SubItems.Add("")
        podatak3.SubItems.Add(Format(duguje - potrazuje, "##,##0.00"))

        lvGlavnaK.Items.AddRange(New ListViewItem() {podatak1, podatak2, podatak3})

        CM.Dispose()
        CN.Close()

        _lista = lvGlavnaK
    End Sub

    Shared Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function

    Private Function datum(ByVal tId) As String
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        datum = ""

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select * from dbo.fn_nalog_head where dbo.fn_nalog_head.id_nalog = " & tId
                DR = .ExecuteReader
            End With

            While DR.Read
                datum = DR.Item("nal_datum")
            End While
            DR.Close()
        End If

        CM.Dispose()
        CN.Close()
    End Function

    Shared bukmark As Integer
    Private Sub lvNalozi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvNalozi.Click
        bukmark = lvNalozi.SelectedItems.Item(0).Text
        _nal_vrsta = lvNalozi.SelectedItems.Item(0).SubItems(1).Text
        _id = bukmark
        '_tab = Imena.tabele.fn_dnevnik.ToString
    End Sub

    Private Sub txtBroj_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBroj.TextChanged
        If Not _pocetak Then
            If txtBroj.Text <> "" Then
                upit_broj = "broj = '" & txtBroj.Text & "'"
            Else
                upit_broj = ""
            End If
            filter()
        End If
    End Sub

    Private Sub dateKnjizenjaOD_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateKnjizenjaOD.ValueChanged
        If Not _pocetak Then
            upit_datum_od = "datum >= '" & _
                dateKnjizenjaOD.Value.Month.ToString & "/" & _
                dateKnjizenjaOD.Value.Day.ToString & "/" & _
                dateKnjizenjaOD.Value.Year.ToString & "'"

            Select Case _tab
                Case Imena.tabele.fn_dnevnik.ToString
                    filter()
                Case Imena.tabele.fn_glavna_knjiga.ToString
                    filter_gl()
            End Select

        End If
    End Sub

    Private Sub dateKnjizenjaDO_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateKnjizenjaDO.ValueChanged
        If Not _pocetak Then
            upit_datum_do = "datum <= '" & _
                dateKnjizenjaOD.Value.Month.ToString & "/" & _
                dateKnjizenjaOD.Value.Day.ToString & "/" & _
                dateKnjizenjaOD.Value.Year.ToString & "'"

            Select Case _tab
                Case Imena.tabele.fn_dnevnik.ToString
                    filter()
                Case Imena.tabele.fn_glavna_knjiga.ToString
                    filter_gl()
            End Select

        End If
    End Sub

    Private Sub txtKonto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKonto.TextChanged
        If Not _pocetak Then
            If txtKonto.Text <> "" Then
                upit_konto = "konto like '" & txtKonto.Text & "%'"
            Else
                upit_konto = ""
            End If
            filter_gl()
        End If
    End Sub

    Private Sub picRefresh1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRefresh1.Click
        upit = ""
        upit_broj = ""
        upit_konto = ""
        upit_datum_od = ""
        upit_datum_do = ""

        Select Case _tab
            Case Imena.tabele.fn_dnevnik.ToString
                sql = "SELECT * FROM dbo.nalog_head"
                lista()
            Case Imena.tabele.fn_glavna_knjiga.ToString
                sql_gl = "SELECT * FROM dbo.nalog_stavka"
                lista_gl()
        End Select
        pocetak()
    End Sub
    Private Sub picRefresh1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRefresh1.MouseHover
        picRefresh1.Image = Global.Farma.My.Resources.Resources.reload
        picRefresh1.Cursor = Cursors.Hand
    End Sub
    Private Sub picRefresh1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRefresh1.MouseLeave
        picRefresh1.Image = Global.Farma.My.Resources.Resources.reload1
        picRefresh1.Cursor = Cursors.Default
    End Sub


End Class
