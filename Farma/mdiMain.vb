Option Strict Off
Option Explicit On

Imports System.Windows.Forms

Public Class mdiMain

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Inicijalizacija()

        _labHead = labHeader
        _lStatus = StatusLabel
        _mStatusBar = StatusStrip
        _spGlavni = splGlavni
        _spRadni = splRadni

        _korak_nazad = New String() {}
        ReDim _korak_nazad(10)

        _korak_labHead = New String() {}
        ReDim _korak_labHead(10)

        Dim mControl As New cntMeniStart
        mControl.Parent = Me.splGlavni.Panel1
        mControl.Dock = DockStyle.Fill
        mControl.Show()
        splGlavni.SplitterDistance = 185

        _labHead.Text = Ispisi_label() '"ROBNO"
        _lStatus.Text = Ispisi_label()

    End Sub

    Public Sub zatvori_kontrolu_desno()
        Dim tControl As Control
        For Each tControl In splRadni.Panel2.Controls
            tControl.Dispose()
        Next
    End Sub

    Public Sub zatvori_kontrolu_levo()
        Dim tControl As Control
        For Each tControl In splGlavni.Panel1.Controls
            tControl.Dispose()
        Next
    End Sub

End Class
