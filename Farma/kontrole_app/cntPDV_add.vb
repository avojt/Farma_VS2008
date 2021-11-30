Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class cntPDV_add

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntPDV_add_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'If _ima_promena Then
        '    If MsgBox("Načinili ste promene. Dali želite da ih snimite?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '        snimi()
        '    End If
        'End If
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntPDV
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _mSpliter.SplitterDistance = 180

        Dim myControl1 As New cntPDV_search
        myControl1.Parent = _mSpliter.Panel1
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        _labHead.Text = Ispisi_label() + " : PDV" + " - pretraga"
        cntMeniArtikli.podesi_boje_linkova(_mPanPDV_meni)
        _mLinkPDV_search.BackColor = Color.GhostWhite
        _mLinkPDV_search.ForeColor = Color.MidnightBlue
        cntMeniMaticniPodaci.enable_linkove(_mPanPDV_meni)
    End Sub

    Private Sub cntPDV_add_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tblMain.Dock = DockStyle.Fill
        tblMain.ColumnStyles.Item(0).Width = 150

        pocetak()
    End Sub

    Private Sub pocetak()

        txtNaziv.Text = ""
        txtSifra.Text = ""
        txtStopa.Text = ""
        dateStupanja.Value = Today

        _ima_promena = False

    End Sub

    Private Sub snimi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        Try
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "app_pdv_add"
                    .Parameters.AddWithValue("@pdv_sifra", txtSifra.Text)
                    .Parameters.AddWithValue("@pdv_opis", txtNaziv.Text)
                    .Parameters.AddWithValue("@pdv_stopa", txtStopa.Text)
                    .Parameters.AddWithValue("@pdv_dat_stupanja", dateStupanja.Value.Date)
                    .Parameters.AddWithValue("@pdv_aktivan", 0)
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
        pocetak()
    End Sub
    Private Sub btnSnimi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnSnimi.KeyPress
        If e.KeyChar = Chr(13) Then
            snimi()
            pocetak()
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
            txtStopa.Select()
        End If
    End Sub
    Private Sub txtNaziv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNaziv.TextChanged
        _ima_promena = True
    End Sub

    Private Sub txtStopa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStopa.KeyPress
        If e.KeyChar = Chr(13) Then
            dateStupanja.Select()
        End If
    End Sub
    Private Sub txtStopa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStopa.TextChanged
        _ima_promena = True
    End Sub

    Private Sub dateStupanja_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dateStupanja.KeyPress
        If e.KeyChar = Chr(13) Then
            btnSnimi.Select()
        End If
    End Sub
    Private Sub dateStupanja_CloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateStupanja.CloseUp
        _ima_promena = True
    End Sub

End Class
