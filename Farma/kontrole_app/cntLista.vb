Public Class cntLista

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnZatvori_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZatvori.Click
        Me.Dispose()
        mdiMain.zatvori_kontrolu_desno()

        Dim myControl1 As New cntIzvestaji
        myControl1.Parent = mdiMain.splRadni.Panel2
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()
        _mSpliter.SplitterDistance = 370
        Dim myControl As New cntIzvestaji_kartica
        myControl.Parent = _mSpliter.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()

    End Sub
End Class
