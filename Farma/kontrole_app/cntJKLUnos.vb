Option Strict Off
Option Explicit On

Imports System.Data.SqlClient

Public Class cntJKLUnos

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntJKLUnos_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'If _ima_promena Then
        '    If MsgBox("Načinili ste promene. Dali želite da ih snimite?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '        snimi()
        '    End If
        'End If
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntJKL
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()
    End Sub

    Private Sub cntJKLUnos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pocetak()
    End Sub

    Private Sub pocetak()

        txtSifra.Text = Nadji_rb(Imena.tabele.app_jkl.ToString, 1)
        txtNaziv.Text = ""
        chkPozLista.Checked = False
        txtNaziv.Focus()

    End Sub

    Private Sub snimi()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        'Dim DR As SqlDataReader
        'Dim DA As SqlDataAdapter = New SqlDataAdapter(CM)

        Try
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "app_jkl_add"
                    .Parameters.AddWithValue("@jkl_sifra", txtSifra.Text)
                    .Parameters.AddWithValue("@jkl_naziv", txtNaziv.Text)
                    .Parameters.AddWithValue("@jkl_pozitivna_lista", chkPozLista.Checked)
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

    Private Sub txtSifra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSifra.KeyPress
        If e.KeyChar = Chr(13) Then
            txtNaziv.Select()
        End If
    End Sub
    Private Sub txtSifra_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSifra.TextChanged
        _ima_promena = True
    End Sub

    Private Sub txtNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNaziv.KeyPress
        If e.KeyChar = Chr(13) Then
            chkPozLista.Select()
        End If
    End Sub
    Private Sub txtNaziv_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNaziv.TextChanged
        _ima_promena = True
    End Sub

    Private Sub chkPozLista_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPozLista.CheckedChanged
        _ima_promena = True
    End Sub

    Private Sub btnSnimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSnimi.Click
        snimi()
        pocetak()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

End Class
