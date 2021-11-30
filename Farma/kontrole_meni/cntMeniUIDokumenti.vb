Option Strict Off
Option Explicit On

Public Class cntMeniUIDokumenti
    Private _visinaUI As Integer = 144
    Private _visina As Integer = 78

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntMeniUIDokumenti_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()
        podesi_boje()

        If Not _povratak Then
            _korak_nazad.SetValue(Me.Name.ToString, zadnji_zapis(_korak_nazad))
            _korak_labHead.SetValue(Me.Name.ToString, zadnji_zapis(_korak_labHead))
        End If
        _labHead.Text = Ispisi_label()
        _povratak = False
    End Sub

    Private Sub pocetak()
        podesi_kontrole()
        podesi_visinu()
    End Sub

    Private Sub podesi_kontrole()
        _mTableButtons = tableButtons
        _mTableButtons_podmeni = tableButtons_podmeni
    End Sub

    Private Sub podesi_visinu()

        With _mTableButtons
            .Height = _visina
            .RowStyles.Item(1).Height = 8
            .RowStyles.Item(2).Height = 8
            .RowStyles.Item(3).Height = 8
        End With

        With _mTableButtons_podmeni
            .Height = _visinaUI
            .RowStyles.Item(1).Height = 8
            .RowStyles.Item(3).Height = 8
            .RowStyles.Item(5).Height = 8
        End With
    End Sub

    Private Sub podesi_boje()
        Dim tControl As Control
        For Each tControl In tableButtons.Controls
            tControl.BackColor = Color.MintCream
            tControl.Enabled = True
        Next
        _mTableButtons_podmeni.BackColor = Color.Lavender
        For Each tControl In _mTableButtons_podmeni.Controls
            tControl.BackColor = Color.MintCream
            tControl.Enabled = True
        Next

        'Dim tControl As Control
        'For Each tControl In _mTableButtons.Controls
        '    If tControl.Name Like "btn*" Then
        '        tControl.BackColor = Color.MintCream
        '        tControl.Enabled = True
        '    End If
        '    If tControl.Name Like "pan*" Then
        '        tControl.BackColor = Color.LightSteelBlue
        '        tControl.Enabled = True
        '    End If
        'Next

        '_mTableButtons_podmeni.BackColor = Color.Lavender

        'For Each tControl In _mTableButtons_podmeni.Controls
        '    If tControl.Name Like "btn*" Then
        '        tControl.BackColor = Color.MintCream
        '        tControl.Enabled = True
        '    End If
        '    If tControl.Name Like "pan*" Then
        '        tControl.BackColor = Color.LightSteelBlue
        '        tControl.Enabled = True
        '    End If
        'Next
    End Sub

    'Shared Sub podesi_boje_linkova(ByVal _panel As TableLayoutPanel)
    '    Dim tLink As LinkLabel
    '    For Each tLink In _panel.Controls
    '        tLink.BackColor = Color.LightSteelBlue
    '        tLink.LinkColor = Color.MidnightBlue
    '        tLink.BorderStyle = Windows.Forms.BorderStyle.None
    '    Next
    'End Sub

    Private Sub btnObrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnObrada.Click

        podesi_boje()
        btnObrada.BackColor = Color.LightSteelBlue
        btnObrada.Enabled = False

        _labHead.Text = Ispisi_label() + My.Resources.text_obrada_podataka '+ My.Resources.text_search

        podesi_visinu()
        _mTableButtons.RowStyles.Item(2).Height = 152
        _mTableButtons.Height = _visina - 8 + _mTableButtons.RowStyles.Item(2).Height

        ID_vrsta_dokumenta = 0

    End Sub

#Region "obrada podataka"

    Private Sub btnUlaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUlaz.Click
        mdiMain.zatvori_kontrolu_levo()

        Dim myControl As New cntMeniObrada_Ulaz
        myControl.Parent = mdiMain.splGlavni.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()
    End Sub

    Private Sub btnIzlaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzlaz.Click
        mdiMain.zatvori_kontrolu_levo()

        Dim myControl As New cntMeniObrada_Izlaz
        myControl.Parent = mdiMain.splGlavni.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()
    End Sub

    Private Sub btnOstalo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOstalo.Click
        mdiMain.zatvori_kontrolu_levo()

        Dim myControl As New cntMeniObrada_ostalo
        myControl.Parent = mdiMain.splGlavni.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()
    End Sub

    Private Sub btnIzvestaji_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzvestaji.Click
        mdiMain.zatvori_kontrolu_levo()

        Dim myControl As New cntMeniIzvestaji
        myControl.Parent = mdiMain.splGlavni.Panel1
        myControl.Dock = DockStyle.Fill
        myControl.Show()
    End Sub

#End Region

    Private Sub btnNazad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNazad.Click
        mdiMain.zatvori_kontrolu_levo()

        _povratak = True
        If zadnji_zapis(_korak_nazad) <> 0 And zadnji_zapis(_korak_labHead) <> 0 Then
            _korak_nazad.SetValue("", zadnji_zapis(_korak_nazad) - 1)
            _korak_labHead.SetValue("", zadnji_zapis(_korak_labHead) - 1)
        End If
        If Not _korak_nazad(zadnji_zapis(_korak_nazad)) Is Nothing Or _
            _korak_nazad(zadnji_zapis(_korak_nazad)).ToString <> "" Then

            _forma_zapovratak = predhodna_forma(_korak_nazad(zadnji_zapis(_korak_nazad) - 1))
            _forma_zapovratak.Parent = mdiMain.splGlavni.Panel1
            _forma_zapovratak.Dock = DockStyle.Fill
            _forma_zapovratak.Show()
        End If
    End Sub

End Class
