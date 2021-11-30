Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmRobaEdit
    Private _bod As Decimal = 1
    Private _marza As Decimal = 0
    Private _nab As Decimal = 0
    Private _nabE As Decimal = 0
    Private _prod As Decimal = 0
    Private _prodE As Decimal = 0
    Private _rabat As Decimal = 0
    Private _pocetak As Boolean = True

    Private Sub frmRobaEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()
        popuni_pdv() '_roba_pdv
        popuni_kategorije() '_roba_kategorija
    End Sub

    Private Sub pocetak()

        txtCena.Text = _roba_cena
        txtEuro.Text = _roba_euro
        txtJM.Text = _jm
        txtKolicina.Text = _roba_kolicina
        txtMinKolicina.Text = _roba_min_kolicina
        txtNabavna.Text = _roba_nabavna
        txtNaziv.Text = _naziv_robe
        txtRabat.Text = _roba_rabat
        txtSifra.Text = _roba_sifra
        txtSifraOpis.Text = _roba_sifra_opis
        txtBod.Text = _roba_bod_cena
        txtnabavnaE.Text = _roba_nabavna_euro
        txtMarza.Text = _roba_marza

        chkBod.Checked = _roba_bod

        _pocetak = False

    End Sub

    Private Sub snimi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        'Dim DR As SqlDataReader
        'Dim DA As SqlDataAdapter = New SqlDataAdapter(CM)
        Dim cena As Decimal = 0
        Dim kol As Decimal = 0

        If txtCena.Text <> "" Then cena = CDec(txtCena.Text)
        If txtKolicina.Text <> "" Then kol = CDec(txtKolicina.Text)

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rm_artikli_update"
                .Parameters.AddWithValue("@id_roba", _id_roba)
                .Parameters.AddWithValue("@sifra", txtSifra.Text)
                .Parameters.AddWithValue("@sifra_opis", txtSifraOpis.Text)
                .Parameters.AddWithValue("@naziv", txtNaziv.Text)
                .Parameters.AddWithValue("@jm", txtJM.Text)
                .Parameters.AddWithValue("@nabavna", CDec(txtNabavna.Text))
                .Parameters.AddWithValue("@nabavna_euro", CDec(txtnabavnaE.Text))
                .Parameters.AddWithValue("@rabat", CInt(txtRabat.Text))
                .Parameters.AddWithValue("@pdv", cmbPDV.Text)
                .Parameters.AddWithValue("@cena", cena)
                .Parameters.AddWithValue("@euro", CDec(txtEuro.Text))
                .Parameters.AddWithValue("@kolicina", kol)
                .Parameters.AddWithValue("@min_kolicina", CDec(txtMinKolicina.Text))
                .Parameters.AddWithValue("@kategorija", cmbKategorija.Text)
                .Parameters.AddWithValue("@marza", txtMarza.Text)
                .Parameters.AddWithValue("@bod", chkBod.Checked)
                .Parameters.AddWithValue("@bod_cena", CDec(txtBod.Text))
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

    Private Sub popuni_pdv()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbPDV.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_pdv.* from dbo.app_pdv"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbPDV.Items.Add(DR.Item("stopa"))
            Loop
        End If
        If cmbPDV.Items.Count > 0 Then
            cmbPDV.SelectedText = _roba_pdv
        End If
        DR = Nothing
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_kategorije()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbKategorija.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_kategorizacija.* from dbo.rm_kategorizacija"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbKategorija.Items.Add(DR.Item("naziv"))
            Loop
        End If
        If cmbKategorija.Items.Count > 0 Then
            cmbKategorija.SelectedText = _roba_kategorija
        End If
        DR = Nothing
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub chkBod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chkBod.CheckState = CheckState.Checked Then
            txtBod.Select()
        End If
    End Sub

    'Private Sub txtBod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '   
    'End Sub

    Private Sub preracunaj()
        If Not _pocetak Then
            If chkBod.CheckState = CheckState.Checked Then txtNabavna.Text = _nabE * _bod
            txtEuro.Text = Decimal.Round((_nabE * (1 - (_rabat / 100))) * (1 + (_marza / 100)), 2)
            txtCena.Text = Decimal.Round((_nab * (1 - (_rabat / 100))) * (1 + (_marza / 100)), 2)
        End If
    End Sub

    Private Sub txtNabavna_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNabavna.TextChanged
        If _pocetak Then
            _nab = _roba_nabavna
        Else
            If txtNabavna.Text <> "" And jeste_broj(txtNabavna.Text) Then
                _nab = CDec(txtNabavna.Text)
            Else
                _nab = 0
            End If

        End If
    End Sub

    Private Sub txtnabavnaE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnabavnaE.TextChanged
        If _pocetak Then
            _nabE = _roba_nabavna_euro
        Else
            If txtnabavnaE.Text <> "" And jeste_broj(txtnabavnaE.Text) Then
                _nabE = CDec(txtnabavnaE.Text)
            Else
                _nabE = 0
            End If
            preracunaj()
        End If
    End Sub

    Private Sub txtRabat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRabat.TextChanged
        If _pocetak Then
            _rabat = _roba_rabat
        Else
            If txtRabat.Text <> "" And jeste_broj(txtRabat.Text) Then
                _rabat = CDec(txtRabat.Text)
            Else
                _rabat = 0
            End If
            preracunaj()
        End If
    End Sub

    Private Sub txtMarza_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMarza.TextChanged
        If _pocetak Then
            _marza = _roba_marza
        Else
            If txtMarza.Text <> "" And jeste_broj(txtMarza.Text) Then
                _marza = CDec(txtMarza.Text)
            Else
                _marza = 0
            End If
            preracunaj()
        End If
    End Sub

    Private Sub txtEuro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEuro.TextChanged
        If _pocetak Then
            _prodE = _roba_euro
        Else
            If txtEuro.Text <> "" And jeste_broj(txtEuro.Text) Then
                _prodE = CDec(txtEuro.Text)
            Else
                _prodE = 0
            End If
            preracunaj()
        End If
    End Sub

    Private Sub txtBod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBod.TextChanged
        If _pocetak Then
            _bod = _roba_bod_cena
        Else
            If txtBod.Text <> "" And jeste_broj(txtBod.Text) Then
                _bod = CDec(txtBod.Text)
            Else
                _bod = 1
            End If
            preracunaj()
        End If
    End Sub
End Class