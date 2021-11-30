Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class cntOJ_edit

#Region "dekleracija"

    Private _pocetak As Boolean = True
    Private _strukturna As Boolean = False

#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntOJ_edit_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'If _ima_promena Then
        '    If MsgBox("Načinili ste promene. Dali želite da ih snimite?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '        snimi()
        '    End If
        'End If

        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntPartneri
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _mSpliter.SplitterDistance = 240

        Dim myControl1 As New cntOJ_sreach
        myControl1.Parent = _mSpliter.Panel1
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_oj + My.Resources.text_search
        cntMeniPartneri.podesi_boje_linkova(_mPanOJ_meni)
        _mLinkPartneri_search.BackColor = Color.GhostWhite
        _mLinkPartneri_search.ForeColor = Color.MidnightBlue
        cntMeniPartneri.enable_linkove(_mPanOJ_meni)
    End Sub

    Private Sub cntOJ_edit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tlbMain.Dock = DockStyle.Fill
        pocetak()
    End Sub

    Private Sub pocetak()

        _pocetak = True

        popuni_mesta()
        popuni_opstine()

        txtAdresa.Text = _oj_adresa
        txtNaziv.Text = _oj_naziv
        txtSifra.Text = _oj_sifra ' Nadji_rb(Imena.tabele.app_partneri.ToString, 1)
        txtVrsta.Text = ""
        chkStrukturna.Checked = _oj_strukturna

        _pocetak = False

    End Sub

    Private Sub popuni_mesta()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbMesto.Items.Clear()
        cmbMesto.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_mesta.* from dbo.app_mesta"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbMesto.Items.Add(DR.Item("mesto_naziv"))
            Loop
            DR.Close()
        End If
        If cmbMesto.Items.Count > 0 Then
            selektuj_mesto(_oj_id_mesta, Selekcija.po_id)
            cmbMesto.SelectedText = _mesto_naziv
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_opstine()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbOpstina.Items.Clear()
        cmbOpstina.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_opstine.* from dbo.app_opstine"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbOpstina.Items.Add(DR.Item("opstine_naziv"))
            Loop
            DR.Close()
        End If
        If cmbOpstina.Items.Count > 0 Then
            selektuj_opstine(_oj_id_opstine, Selekcija.po_id)
            cmbOpstina.SelectedText = _opstina_naziv
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub txtSifra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSifra.KeyPress
        If e.KeyChar = Chr(13) Then
            txtNaziv.Select()
        End If
    End Sub

    Private Sub txtNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNaziv.KeyPress
        If e.KeyChar = Chr(13) Then
            txtAdresa.Select()
        End If
    End Sub

    Private Sub txtAdresa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdresa.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbOpstina.Select()
        End If
    End Sub

    Private Sub cmbOpstina_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOpstina.DropDownClosed
        cmbMesto.Select()
    End Sub

    Private Sub cmbOpstina_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbOpstina.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbMesto.Select()
        End If
    End Sub

    Private Sub cmbMesto_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMesto.DropDownClosed
        txtVrsta.Select()
    End Sub

    Private Sub cmbMesto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMesto.KeyPress
        If e.KeyChar = Chr(13) Then
            txtVrsta.Select()
        End If
    End Sub

    Private Sub txtVrsta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVrsta.KeyPress
        If e.KeyChar = Chr(13) Then
            chkStrukturna.Select()
        End If
    End Sub

    Private Sub chkStrukturna_CursorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkStrukturna.CursorChanged
        Select Case chkStrukturna.CheckState
            Case CheckState.Checked
                _strukturna = True
            Case CheckState.Unchecked
                _strukturna = False
        End Select
    End Sub

    Private Sub snimi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "app_organizacione_jedinice_update"
                .Parameters.AddWithValue("@id_orgjed", _id_oj)
                .Parameters.AddWithValue("@oj_sifra", txtSifra.Text)
                .Parameters.AddWithValue("@oj_naziv", txtNaziv.Text)
                .Parameters.AddWithValue("@oj_adresa", txtAdresa.Text)
                .Parameters.AddWithValue("@id_grad", "")
                selektuj_opstine(cmbOpstina.Text, Selekcija.po_nazivu)
                .Parameters.AddWithValue("@id_opstine", _id_opstina)
                selektuj_mesto(cmbMesto.Text, Selekcija.po_nazivu)
                .Parameters.AddWithValue("@id_mesta", _id_mesto)
                .Parameters.AddWithValue("@id_vrsta", 0)
                .Parameters.AddWithValue("@oj_strukturna", chkStrukturna.CheckState)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub btnSnimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSnimi.Click
        snimi()
        'pocetak()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class
