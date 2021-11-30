Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class cntNaselja_add

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntNaselja_add_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'If _ima_promena Then
        '    If MsgBox("Načinili ste promene. Dali želite da ih snimite?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '        snimi()
        '    End If
        'End If

        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntNaselja
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _mSpliter.SplitterDistance = 205

        Dim myControl1 As New cntNaselja_search
        myControl1.Parent = _mSpliter.Panel1
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()

        _labHead.Text = Ispisi_label() + My.Resources.text_naselja + My.Resources.text_search
        cntMeniPartneri.podesi_boje_linkova(_mPanNaselja_meni)
        _mLinkNaselja_search.BackColor = Color.GhostWhite
        _mLinkNaselja_search.ForeColor = Color.MidnightBlue
        cntMeniPartneri.enable_linkove(_mPanNaselja_meni)
    End Sub

    Private Sub cntNaselja_add_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()
    End Sub

    Private Sub pocetak()
        txtNaziv.Text = ""
        txtPorJed.Text = ""
        txtPttBroj.Text = ""
        txtNaziv.Focus()
        popuni_opstine()
        popuni_gradove()
        tlbMain.Dock = DockStyle.Fill
        rbtGradovi.Checked = True
    End Sub

    Private Sub popuni_opstine()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbOpstine.Items.Clear()

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
                cmbOpstine.Items.Add(DR.Item("opstine_naziv"))
            Loop
            DR.Close()
        End If
        If cmbOpstine.Items.Count > 0 Then
            cmbOpstine.SelectedIndex = 0 'Partner_naziv(_id_partner)
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_gradove()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbGradovi.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_gradovi.* from dbo.app_gradovi"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbGradovi.Items.Add(DR.Item("grad_naziv"))
            Loop
            DR.Close()
        End If
        If cmbGradovi.Items.Count > 0 Then
            cmbGradovi.SelectedIndex = 0 'Partner_naziv(_id_partner)
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub snimi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        CN.Open()
        Select Case _naselja
            Case Imena.naselja.grad
                CM = New SqlCommand()
                If CN.State = ConnectionState.Open Then
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "app_gradovi_add"
                        .Parameters.AddWithValue("@grad_naziv", txtNaziv.Text)
                        .Parameters.AddWithValue("@grad_ptt_br", txtPttBroj.Text)
                        .Parameters.AddWithValue("@grad_porjed", txtPorJed.Text)
                        .Parameters.AddWithValue("@grad_aktivan", 0)
                        .ExecuteScalar()
                    End With
                End If
                CM.Dispose()
            Case Imena.naselja.opstina
                CM = New SqlCommand()
                If CN.State = ConnectionState.Open Then
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "app_opstine_add"
                        selektuj_grad(cmbGradovi.Text, Selekcija.po_nazivu)
                        .Parameters.AddWithValue("@id_grad", _id_grad)
                        .Parameters.AddWithValue("@opstine_naziv", txtNaziv.Text)
                        .Parameters.AddWithValue("@opstine_ptt_br", txtPttBroj.Text)
                        .Parameters.AddWithValue("@opstine_porjed", txtPorJed.Text)
                        .Parameters.AddWithValue("@opstine_aktivan", 0)
                        .ExecuteScalar()
                    End With
                End If
                CM.Dispose()
            Case Imena.naselja.mesto
                CM = New SqlCommand()
                If CN.State = ConnectionState.Open Then
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "app_mesta_add"
                        selektuj_opstine(cmbOpstine.Text, Selekcija.po_nazivu)
                        .Parameters.AddWithValue("@id_opstine", _id_opstina)
                        .Parameters.AddWithValue("@mesto_naziv", txtNaziv.Text)
                        .Parameters.AddWithValue("@mesto_ptt_br", txtPttBroj.Text)
                        .Parameters.AddWithValue("@mesto_porjed", txtPorJed.Text)
                        .Parameters.AddWithValue("@mesto_aktivan", 0)
                        .ExecuteScalar()
                    End With
                End If
                CM.Dispose()
        End Select
        CN.Close()

    End Sub

    Private Sub rbtGradovi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtGradovi.CheckedChanged
        Select Case rbtGradovi.Checked
            Case True
                _naselja = Imena.naselja.grad
                cmbOpstine.Enabled = False
                cmbGradovi.Enabled = False
            Case False
                _naselja = ""
                cmbOpstine.Enabled = False
                cmbGradovi.Enabled = False
        End Select
    End Sub

    Private Sub rbtOpstine_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtOpstine.CheckedChanged
        Select Case rbtOpstine.Checked
            Case True
                _naselja = Imena.naselja.opstina
                cmbOpstine.Enabled = False
                cmbGradovi.Enabled = True
            Case False
                _naselja = ""
                cmbOpstine.Enabled = False
                cmbGradovi.Enabled = False
        End Select
    End Sub

    Private Sub rbtMesta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtMesta.CheckedChanged
        Select Case rbtMesta.Checked
            Case True
                _naselja = Imena.naselja.mesto
                cmbOpstine.Enabled = True
                cmbGradovi.Enabled = False
            Case False
                _naselja = ""
                cmbOpstine.Enabled = False
                cmbGradovi.Enabled = False
        End Select
    End Sub

    Private Sub btnSnimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSnimi.Click
        snimi()
        pocetak()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class
