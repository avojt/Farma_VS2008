Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class cntMeniRobno_brisati

    Private _visina As Integer = 68

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntMeniRobno_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not _povratak Then
            _korak_nazad.SetValue(Me.Name.ToString, zadnji_zapis(_korak_nazad))
            _korak_labHead.SetValue(Me.Name.ToString, zadnji_zapis(_korak_labHead))
        End If
        _labHead.Text = Ispisi_label()
        _povratak = False

    End Sub

    Private Sub btnIODoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIODoc.Click
        mdiMain.zatvori_kontrolu_levo()

        Dim myControl As New cntMeniRobno
        myControl.Parent = mdiMain.splGlavni.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()
    End Sub

End Class
