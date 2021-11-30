Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class cntNaselja_edit

    Private _grad As String = ""
    Private _opstrina As String = ""

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntNaselja_edit_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
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

    Private Sub cntNaselja_edit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()
    End Sub

    Private Sub pocetak()
        Select Case _naselja
            Case Imena.naselja.grad
                txtNaziv.Text = _grad_naziv
                txtPorJed.Text = _grad_pj
                txtPttBroj.Text = _grad_ptt
                _grad = ""
                _opstrina = ""
                rbtGradovi.Checked = True
                rbtOpstine.Enabled = False
                rbtMesta.Enabled = False
            Case Imena.naselja.opstina
                txtNaziv.Text = _opstina_naziv
                txtPorJed.Text = _opstina_pj
                txtPttBroj.Text = _opstina_ptt
                selektuj_grad(_id_grad, Selekcija.po_id)
                _grad = _grad_naziv
                _opstrina = ""
                rbtOpstine.Checked = True
                rbtGradovi.Enabled = False
                rbtMesta.Enabled = False
                popuni_gradove()
            Case Imena.naselja.mesto
                txtNaziv.Text = _mesto_naziv
                txtPorJed.Text = _mesto_pj
                txtPttBroj.Text = _mesto_ptt
                selektuj_mesto(_id_opstina, Selekcija.po_id)
                _opstrina = _opstina_naziv
                selektuj_opstine(_id_grad, Selekcija.po_id)
                _grad = _grad_naziv
                rbtMesta.Checked = True
                rbtGradovi.Enabled = False
                rbtOpstine.Enabled = False
                popuni_opstine()
        End Select
       
        txtNaziv.Focus()

        tlbMain.Dock = DockStyle.Fill

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
                .CommandText = "select dbo.app_opstine.* from dbo.app_opstine order by opstine_naziv"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbOpstine.Items.Add(DR.Item("opstine_naziv"))
            Loop
            DR.Close()
        End If
        If cmbOpstine.Items.Count > 0 Then
            selektuj_opstine(_id_opstina, Selekcija.po_id)
            cmbOpstine.SelectedText = _opstina_naziv ' 0 
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
                .CommandText = "select dbo.app_gradovi.* from dbo.app_gradovi order by grad_naziv"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbGradovi.Items.Add(DR.Item("grad_naziv"))
            Loop
            DR.Close()
        End If
        If cmbGradovi.Items.Count > 0 Then
            selektuj_grad(_id_grad, Selekcija.po_id)
            cmbGradovi.SelectedText = _grad_naziv ' 0 
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
                        .CommandText = "app_gradovi_update"
                        .Parameters.AddWithValue("@id_grad", _id_grad)
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
                        .CommandText = "app_opstine_update"
                        .Parameters.AddWithValue("@id_opstine", _id_opstina)
                        If _id_grad = 0 Then
                            selektuj_grad(cmbGradovi.Text, Selekcija.po_nazivu)
                        End If
                        .Parameters.AddWithValue("@id_grad", _id_grad)
                        .Parameters.AddWithValue("@opstine_naziv", txtNaziv.Text)
                        .Parameters.AddWithValue("@opstine_ptt_br", txtPttBroj.Text)
                        .Parameters.AddWithValue("@opstine_porjed", RTrim(txtPorJed.Text))
                        .Parameters.AddWithValue("@opstine_aktivan", _opstina_aktivan)
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
                        .CommandText = "app_mesta_update"
                        .Parameters.AddWithValue("@id_mesta", _id_mesto)
                        If _id_opstina = 0 Then
                            selektuj_opstine(cmbOpstine.Text, Selekcija.po_nazivu)
                        End If
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
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class
