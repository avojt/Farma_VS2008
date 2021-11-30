Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntOStavke

    Private upit As String = ""
    Private upit_broj As String = ""
    Private upit_partner_os As String = ""

    Shared dokument As String = ""

    Shared sql_os As String = ""
    Private sql_os_rn As String = "SELECT * FROM dbo.rm_racun_head where dbo.rm_racun_head.placeno = 0"
    Private sql_os_prn As String = "SELECT * FROM dbo.rm_ulazni_racuni_head where dbo.rm_ulazni_racuni_head.placeno = 0"

    Private _pocetak As Boolean = True

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntOStavke_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sql_os = ""
        popuni_parnere()
        _pocetak = False
    End Sub

    Private Sub popuni_parnere()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbPartnerOS.Items.Clear()
        cmbPartnerOS.Items.Add(" ")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_partneri.* from dbo.app_partneri"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbPartnerOS.Items.Add(DR.Item("partner_naziv"))
            Loop
            DR.Close()
        End If
        If cmbPartnerOS.Items.Count > 0 Then
            cmbPartnerOS.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Function Partner(ByVal _partner) As Integer
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_partneri.* from dbo.app_partneri where partner_naziv = '" & _partner & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                Partner = DR.Item("id_partner")
            Loop
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Private Sub filter_OS()
        On Error Resume Next
        If Not _pocetak Then
            If upit_partner_os <> "" Then upit = upit_partner_os

            If upit <> "" Then
                Select Case dokument
                    Case chkRn.Text
                        sql_os = "SELECT * FROM dbo.rm_racun_head where dbo.rm_racun_head.placeno = 0 and dbo.rm_racun_head." & upit
                    Case chkPrimRn.Text
                        sql_os = "SELECT * FROM dbo.rm_ulazni_racuni_head where dbo.rm_ulazni_racuni_head.placeno = 0 and dbo.rm_ulazni_racuni_head." & upit
                End Select
            End If

            listaOS(sql_os)

        End If
        upit = ""
        sql_os = ""
        'sql_os_rn = "SELECT * FROM dbo.rm_racun_head where dbo.rm_racun_head.placeno = 0"
        'sql_os_prn = "SELECT * FROM dbo.rm_ulazni_racuni_head where dbo.rm_ulazni_racuni_head.placeno = 0"

    End Sub
    Private Sub listaOS(ByVal _sql As String)

        lvOS.Items.Clear()
        If _sql <> "" Then
            Dim CN As SqlConnection = New SqlConnection(CNNString)
            Dim CM As New SqlCommand
            Dim DR As SqlDataReader
            Dim _stanje As Single = 0

            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.Text
                    .CommandText = _sql
                    DR = .ExecuteReader
                End With

                Dim saldo_os As Single = 0
                While DR.Read
                    Dim podatak As New ListViewItem(CStr(DR.Item("sifra")), 0)
                    podatak.SubItems.Add(Partner_naziv(DR.Item("id_partner")))
                    podatak.SubItems.Add(DR.Item("datum_fakturisanja"))
                    podatak.SubItems.Add(DR.Item("datum_valuta"))
                    Select Case dokument
                        Case chkRn.Text
                            podatak.SubItems.Add(DR.Item("iznos_zanaplatu"))
                            podatak.SubItems.Add("0")
                            saldo_os += Format(DR.Item("iznos_zanaplatu"), 2)
                        Case chkPrimRn.Text
                            podatak.SubItems.Add("0")
                            podatak.SubItems.Add(DR.Item("iznos_zanaplatu"))
                            saldo_os -= Format(DR.Item("iznos_zanaplatu"), 2)
                    End Select
                    podatak.SubItems.Add(saldo_os)

                    lvOS.Items.AddRange(New ListViewItem() {podatak}) ', item2, item3})
                End While
                DR.Close()
            End If

            CM.Dispose()
            CN.Close()
        End If
        _lista = lvOS
        _sql_os = sql_os
    End Sub

    Private Sub cmbPartnerOS_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPartnerOS.SelectedIndexChanged
        If Not _pocetak Then
            If cmbPartnerOS.Text <> " " Then
                upit_partner_os = "id_partner = " & Partner(cmbPartnerOS.Text)
            Else
                upit_partner_os = ""
            End If
            filter_OS()
        End If
    End Sub
    Private Sub chkRn_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkRn.CheckedChanged
        Select Case chkRn.CheckState
            Case CheckState.Checked
                dokument = chkRn.Text
                _strana = Imena.strana_knjizenja.duguje
                chkPrimRn.Checked = False
            Case CheckState.Unchecked
                dokument = chkPrimRn.Text
                _strana = Imena.strana_knjizenja.potrazuje
                chkPrimRn.Checked = True
        End Select
        filter_OS()
    End Sub

    Private Sub chkPrimRn_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPrimRn.CheckedChanged
        Select Case chkPrimRn.CheckState
            Case CheckState.Checked
                dokument = chkPrimRn.Text
                chkRn.Checked = False
            Case CheckState.Unchecked
                dokument = chkRn.Text
                chkRn.Checked = True
        End Select
        filter_OS()
    End Sub

    Shared Sub os_prn()

        os_print(_sql_os, _strana)

        '_raport = Imena.tabele.fn_otvorene_stavke.ToString
        'Dim mForm As New frmPrint
        'mForm.Show()
    End Sub
End Class
