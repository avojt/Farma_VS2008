Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class frmRobaUnos
    Private _bod As Decimal = 1
    Private _marza As Decimal = 0
    Private _nab As Decimal = 0
    Private _nabE As Decimal = 0
    Private _prod As Decimal = 0
    Private _prodE As Decimal = 0
    Private _rabat As Decimal = 0

    Private Sub frmRobaUnos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()
    End Sub

    Private Sub pocetak()
        txtCena.Text = 0
        txtEuro.Text = 0
        txtJM.Text = ""
        txtKolicina.Text = 0
        txtMinKolicina.Text = 0
        txtNabavna.Text = 0
        txtNaziv.Text = ""
        txtRabat.Text = 0
        txtSifra.Text = ""
        txtSifraOpis.Text = ""
        txtBod.Text = 0
        txtnabavnaE.Text = 0
        txtMarza.Text = 0

        popuni_pdv()
        popuni_kategorije()
    End Sub

    Private Sub snimi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
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
                .CommandText = "rm_artikli_add"
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
                .Parameters.AddWithValue("@marza", CDec(txtMarza.Text))
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
                pocetak()
            Case "tlbEnd"
                Me.Dispose()
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
            cmbPDV.SelectedIndex = 0
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
            cmbKategorija.SelectedIndex = 0
        End If
        DR = Nothing
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub chkBod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBod.CheckedChanged
        If chkBod.CheckState = CheckState.Checked Then
            txtBod.Select()
        End If
    End Sub

    Private Sub txtBod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBod.TextChanged

        If txtBod.Text <> "" And jeste_broj(txtBod.Text) Then
            _bod = CDec(txtBod.Text)
        Else
            _bod = 1
        End If

        preracunaj()
    End Sub

    Private Sub txtNabavna_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNabavna.TextChanged

        If txtNabavna.Text <> "" And jeste_broj(txtNabavna.Text) Then
            _nab = CDec(txtNabavna.Text)
        Else
            _nab = 0
        End If

        preracunaj()
    End Sub

    Private Sub txtnabavnaE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnabavnaE.TextChanged

        If txtnabavnaE.Text <> "" And jeste_broj(txtnabavnaE.Text) Then
            _nabE = CDec(txtnabavnaE.Text)
        Else
            _nabE = 0
        End If

        preracunaj()
    End Sub

    Private Sub txtEuro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEuro.TextChanged

        If txtEuro.Text <> "" And jeste_broj(txtEuro.Text) Then
            _prodE = CDec(txtEuro.Text)
        Else
            _prodE = 0
        End If

        preracunaj()
    End Sub

    Private Sub txtRabat_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRabat.TextChanged

        If txtRabat.Text <> "" And jeste_broj(txtRabat.Text) Then
            _rabat = CDec(txtRabat.Text)
        Else
            _rabat = 0
        End If

        preracunaj()
    End Sub

    Private Sub txtMarza_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMarza.TextChanged

        If txtMarza.Text <> "" And jeste_broj(txtMarza.Text) Then
            _marza = CDec(txtMarza.Text)
        Else
            _marza = 0
        End If

        preracunaj()
    End Sub

    Private Sub preracunaj()

        If chkBod.CheckState = CheckState.Checked Then txtNabavna.Text = _nabE * _bod
        txtEuro.Text = Decimal.Round((_nabE * (1 - (_rabat / 100))) * (1 + (_marza / 100)), 2)
        txtCena.Text = Decimal.Round((_nab * (1 - (_rabat / 100))) * (1 + (_marza / 100)), 2)

    End Sub

    Private Sub cmbKategorija_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbKategorija.SelectedValueChanged
        txtSifra.Text = nova_sifra(cmbKategorija.Text) '(Mid(cmbKategorija.Text, 1, 2))
    End Sub

    Private Function nova_sifra(ByVal _kategorija) As String
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        nova_sifra = ""
        CN.Open()

        If CN.State = ConnectionState.Open Then
            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_kategorizacija.* from dbo.rm_kategorizacija where dbo.rm_kategorizacija.naziv = '" & _kategorija & "'"
                DR = .ExecuteReader
            End With

            Dim prefix As String = ""
            Do While DR.Read
                prefix = RTrim(DR.Item("prefix"))
            Loop
            CM.Dispose()
            DR.Close()

            Dim n As Integer = 0

            If prefix <> "" Then
                CM = New SqlCommand()
                Dim sql As String = "select dbo.rm_artikli.* from dbo.rm_artikli where dbo.rm_artikli.sifra like '" & prefix & "%' order by dbo.rm_artikli.sifra"
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = sql
                    DR = .ExecuteReader
                End With

                Do While DR.Read
                    Try
                        n = CInt(Mid(DR.Item("sifra"), prefix.Length + 1, DR.Item("sifra").ToString.Length))
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OkOnly)
                    End Try
                Loop
                DR.Close()
                CM.Dispose()
            End If

            Dim i As Integer = 0
            For i = 0 To 3 - n.ToString.Length - 1
                nova_sifra += "0"
            Next
            nova_sifra = prefix & nova_sifra & CStr(n + 1)


        End If

        CN.Close()
    End Function

End Class