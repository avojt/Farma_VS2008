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

        _mSpliter.SplitterDistance = 345

        Select Case _forma_zapovratak.Name
            Case "cntIzvestaji_kartica"
                Dim myControl As New cntIzvestaji_kartica
                myControl.Parent = _mSpliter.Panel1
                myControl.Dock = DockStyle.Fill
                myControl.Show()
            Case "cntIzvestaji_stanje"
                Dim myControl As New cntIzvestaji_stanje
                myControl.Parent = _mSpliter.Panel1
                myControl.Dock = DockStyle.Fill
                myControl.Show()
            Case "cntIzvestaji_neslaganja"
                Dim myControl As New cntIzvestaji_neslaganja
                myControl.Parent = _mSpliter.Panel1
                myControl.Dock = DockStyle.Fill
                myControl.Show()
            Case "cntAnaliza_izlaz"
                Dim myControl As New cntAnaliza_izlaz
                myControl.Parent = _mSpliter.Panel1
                myControl.Dock = DockStyle.Fill
                myControl.Show()
            Case "cntAnaliza_ulaz"
                Dim myControl As New cntAnaliza_ulaz
                myControl.Parent = _mSpliter.Panel1
                myControl.Dock = DockStyle.Fill
                myControl.Show()
            Case "cntAnaliza_lagera"
                Dim myControl As New cntAnaliza_lagera
                myControl.Parent = _mSpliter.Panel1
                myControl.Dock = DockStyle.Fill
                myControl.Show()
            Case "cntSpecifikacije_nivelacije"
                Dim myControl As New cntSpecifikacije_nivelacije
                myControl.Parent = _mSpliter.Panel1
                myControl.Dock = DockStyle.Fill
                myControl.Show()
            Case "cntSpecifikacija_ulaza"
                Dim myControl As New cntSpecifikacija_ulaza
                myControl.Parent = _mSpliter.Panel1
                myControl.Dock = DockStyle.Fill
                myControl.Show()
            Case "cntSpecifikacija_izlaza"
                Dim myControl As New cntSpecifikacija_izlaza
                myControl.Parent = _mSpliter.Panel1
                myControl.Dock = DockStyle.Fill
                myControl.Show()
            Case "cntSpecifikacija_lager"
                Dim myControl As New cntSpecifikacija_lager
                myControl.Parent = _mSpliter.Panel1
                myControl.Dock = DockStyle.Fill
                myControl.Show()
        End Select
    End Sub

    Private Sub cntLista_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Panel.Dock = DockStyle.Fill
        labMagacin.Text = _text_magacin
        labOJ.Text = _text_oj
        labProizvodjac.Text = _text_partner
        If _forma_zapovratak.Name = "cntSpecifikacija_lager" Or _forma_zapovratak.Name = "cntAnaliza_lagera" Then
            labGrupa.Text = _text_grupa
            labDatum.Text = _text_datum
            labOJ.Visible = False
            Label3.Enabled = False
        End If
    End Sub

End Class
