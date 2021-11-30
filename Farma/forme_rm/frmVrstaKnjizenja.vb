Option Strict Off
Option Explicit On

Public Class frmVrstaKnjizenja

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmVrstaKnjizenja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()
    End Sub

    Private Sub pocetak()
        chkMaterijal.Checked = False
        chkOS.Checked = False
        chkRoba.Checked = False
        chkTroskovi.Checked = False
        chkUsluge.Checked = False
    End Sub

    Private Sub chkRoba_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRoba.CheckedChanged
        If chkRoba.Checked = True Then

            _sema_sifra = "urn-r"

            chkMaterijal.Checked = False
            chkOS.Checked = False
            chkUsluge.Checked = False
            chkTroskovi.Checked = False
        End If
    End Sub

    Private Sub chkMaterijal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMaterijal.CheckedChanged
        If chkMaterijal.Checked = True Then

            _sema_sifra = "urn-m"

            chkRoba.Checked = False
            chkOS.Checked = False
            chkUsluge.Checked = False
            chkTroskovi.Checked = False
        End If
    End Sub

    Private Sub chkOS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOS.CheckedChanged
        If chkOS.Checked = True Then

            _sema_sifra = "urn-os"

            chkMaterijal.Checked = False
            chkRoba.Checked = False
            chkUsluge.Checked = False
            chkTroskovi.Checked = False
        End If
    End Sub

    Private Sub chkUsluge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUsluge.CheckedChanged
        If chkUsluge.Checked = True Then

            _sema_sifra = "urn-u"

            chkMaterijal.Checked = False
            chkOS.Checked = False
            chkRoba.Checked = False
            chkTroskovi.Checked = False
        End If
    End Sub

    Private Sub chkTroskovi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTroskovi.CheckedChanged
        If chkTroskovi.Checked = True Then

            _sema_sifra = "urn-t"

            chkMaterijal.Checked = False
            chkOS.Checked = False
            chkUsluge.Checked = False
            chkRoba.Checked = False
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If _sema_sifra <> "" Then
            Dim mForm As New cntNalog_add
            mForm.Show()
            Me.Dispose()
        Else
            MsgBox("Obavezno morate ozadbari jednu opciju", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
    End Sub
End Class