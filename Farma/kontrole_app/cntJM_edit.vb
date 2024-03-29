Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class cntJM_edit
    Dim broj_decimala As Integer

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntJM_edit_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'If _ima_promena Then
        '    If MsgBox("Načinili ste promene. Dali želite da ih snimite?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '        snimi()
        '    End If
        'End If
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntJM
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _mSpliter.SplitterDistance = 190
        
        Dim myControl1 As New cntJM_search
        myControl1.Parent = _mSpliter.Panel1
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()
       
        _labHead.Text = Ispisi_label() + " : Jedinice mera" + " - pretraga"
        cntMeniArtikli.podesi_boje_linkova(_mPanJM_meni)
        _mLinkJM_search.BackColor = Color.GhostWhite
        _mLinkJM_search.ForeColor = Color.MidnightBlue
        cntMeniArtikli.enable_linkove(_mPanJM_meni)
    End Sub

    Private Sub cntJM_edit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'tblMain.Dock = DockStyle.Fill
        'tblMain.ColumnStyles.Item(0).Width = 340

        pocetak()
    End Sub

    Private Sub pocetak()

        txtNaziv.Text = _jm_naziv
        txtSifra.Text = _jm_sifra
        txtOznaka.Text = _jm_oznaka

        Select Case _jm_br_decimala
            Case 0
                rbt0.Checked = True
            Case 2
                rbt2.Checked = True
            Case 3
                rbt3.Checked = True
        End Select

        _ima_promena = False

    End Sub

    Private Sub snimi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim cena As Single = 0
        Dim kol As Single = 0

        Try
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "app_jm_update"
                    .Parameters.AddWithValue("@id_jm", _id_jm)
                    .Parameters.AddWithValue("@jm_sifra", txtSifra.Text)
                    .Parameters.AddWithValue("@jm_naziv", RTrim(txtNaziv.Text))
                    .Parameters.AddWithValue("@jm_oznaka", txtOznaka.Text)
                    .Parameters.AddWithValue("@jm_br_decimala", broj_decimala)
                    .ExecuteScalar()
                End With
            End If
            CM.Dispose()
            CN.Close()
            _ima_promena = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub btnSnimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSnimi.Click
        snimi()
        'pocetak()
    End Sub
    Private Sub btnSnimi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnSnimi.KeyPress
        If e.KeyChar = Chr(13) Then
            snimi()
            'pocetak()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
    Private Sub btnCancel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnCancel.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.Dispose()
        End If
    End Sub

    Private Sub txtSifra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSifra.KeyPress
        If e.KeyChar = Chr(13) Then
            txtNaziv.Select()
        End If
    End Sub
    Private Sub txtSifra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSifra.TextChanged
        _ima_promena = True
    End Sub

    Private Sub txtNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNaziv.KeyPress
        If e.KeyChar = Chr(13) Then
            txtOznaka.Select()
        End If
    End Sub
    Private Sub txtNaziv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNaziv.TextChanged
        _ima_promena = True
    End Sub

    Private Sub txtOznaka_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOznaka.KeyPress
        If e.KeyChar = Chr(13) Then
            btnSnimi.Select()
        End If
    End Sub
    Private Sub txtOznaka_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOznaka.TextChanged
        _ima_promena = True
    End Sub

    Private Sub rbt0_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt0.CheckedChanged
        Select Case rbt0.Checked
            Case True
                broj_decimala = 0
            Case False
                broj_decimala = 2
        End Select
    End Sub

    'Private Sub rbt2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt2.CheckedChanged
    '    Select Case rbt2.Checked
    '        Case True
    '            broj_decimala = 2
    '        Case False
    '            broj_decimala = 2
    '    End Select
    'End Sub

    Private Sub rbt3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt3.CheckedChanged
        Select Case rbt3.Checked
            Case True
                broj_decimala = 3
            Case False
                broj_decimala = 2
        End Select
    End Sub
End Class
