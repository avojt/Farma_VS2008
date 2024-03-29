Option Strict Off
Option Explicit On

Imports System.Data.SqlClient


Public Class cntGrupeArt_edit

    Private _pocetak As Boolean = True

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntGrupeArt_edit_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'If _ima_promena Then
        '    If MsgBox("Načinili ste promene. Dali želite da ih snimite?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '        snimi()
        '    End If
        'End If
        mdiMain.zatvori_kontrolu_desno()
        Dim myControl As New cntGrupeArt
        myControl.Parent = mdiMain.splRadni.Panel2
        myControl.Dock = DockStyle.Fill
        myControl.Show()

        _mSpliter.SplitterDistance = 170
        
        Dim myControl1 As New cntGrupeArt_search
        myControl1.Parent = _mSpliter.Panel1
        myControl1.Dock = DockStyle.Fill
        myControl1.Show()
      
        _labHead.Text = Ispisi_label() + " : Grupe artikla" + " - pretraga"
        cntMeniArtikli.podesi_boje_linkova(_mPanGrupe_meni)
        _mLinkGrupe_search.BackColor = Color.GhostWhite
        _mLinkGrupe_search.ForeColor = Color.MidnightBlue
        cntMeniArtikli.enable_linkove(_mPanGrupe_meni)
    End Sub

    Private Sub cntGrupeArt_edit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tblMain.Dock = DockStyle.Fill
        tblMain.ColumnStyles.Item(0).Width = 115

        _pocetak = True
        pocetak()
    End Sub

    Private Sub pocetak()

        txtMarza.Text = _gr_art_marza
        txtNaziv.Text = _gr_art_naziv
        txtSifra.Text = _gr_art_sifra
        txtSkraceno.Text = _gr_art_skraceno
        txtIzdajeSeNa.Text = _gr_art_izdajesena
        chkPoslednji.Checked = _gr_art_poslednji_nivo
        chkL1.Checked = _gr_art_L1
        chkLek.Checked = _gr_art_lek

        popuni_pdv()
        popuni_grupa()
        popuni_vrstu()

        _ima_promena = False
        _pocetak = False

    End Sub

    Private Sub popuni_pdv()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbPDV.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_pdv.* from dbo.app_pdv"
                DR = .ExecuteReader
            End With
            Do While DR.Read

                cmbPdv.Items.Add(DR.Item("pdv_stopa"))
            Loop
            DR.Close()
        End If
        If cmbPdv.Items.Count > 0 Then
            If _pocetak Then
                cmbPdv.SelectedText = _gr_art_pdv
            Else
                cmbPdv.SelectedItem = _gr_art_pdv
            End If
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_grupa()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbNadredjena.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_artikl_grupa.* from dbo.app_artikl_grupa"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbNadredjena.Items.Add(DR.Item("gr_artikla_sifra")) '(Mid(DR.Item("gr_artikla_sifra"), 1, 5) & " - " & DR.Item("gr_artikla_naziv"))
            Loop
            DR.Close()
        End If
        If cmbNadredjena.Items.Count > 0 Then
            If _pocetak Then
                cmbNadredjena.SelectedText = _gr_art_nadredj_gr
            Else
                cmbNadredjena.SelectedItem = _gr_art_nadredj_gr
            End If
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_vrstu()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbVrsta.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_artikl_vrsta.* from dbo.app_artikl_vrsta"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbVrsta.Items.Add(DR.Item("vrsta_naziv"))
            Loop
            DR.Close()
        End If
        If cmbVrsta.Items.Count > 0 Then
            selektuj_VrsteArtikla(_id_vrsta_dok, Selekcija.po_id)
            If _pocetak Then
                cmbVrsta.SelectedText = _vrsta_naziv
            Else
                cmbVrsta.SelectedItem = _vrsta_naziv
            End If
        End If
        CM.Dispose()
        CN.Close()
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
                    .CommandText = "app_artikl_grupa_update"
                    .Parameters.AddWithValue("@id_grup_artikla", _id_gr_art)
                    .Parameters.AddWithValue("@gr_artikla_sifra", txtSifra.Text)
                    .Parameters.AddWithValue("@gr_artikla_naziv", txtNaziv.Text)
                    .Parameters.AddWithValue("@gr_artikla_skraceno", txtSkraceno.Text)
                    .Parameters.AddWithValue("@gr_artikla_nadredj_gr", cmbNadredjena.Text)
                    .Parameters.AddWithValue("@gr_artikla_poslednji_nivo", chkPoslednji.Checked)
                    .Parameters.AddWithValue("@gr_artikla_marza", txtMarza.Text)
                    .Parameters.AddWithValue("@gr_artikla_pdv", cmbPdv.Text)
                    .Parameters.AddWithValue("@gr_artikla_aktivno", 0)
                    .Parameters.AddWithValue("@gr_artikla_L1", chkL1.Checked)
                    .Parameters.AddWithValue("@gr_artikla_lek", chkLek.Checked)
                    .Parameters.AddWithValue("@gr_artikla_izdajesena", txtIzdajeSeNa.Text)
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
    Private Sub txtSifra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSifra.TextChanged
        If Not _pocetak Then
            _ima_promena = True
        End If
    End Sub

    Private Sub txtNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNaziv.KeyPress
        If e.KeyChar = Chr(13) Then
            txtSkraceno.Select()
        End If
    End Sub
    Private Sub txtNaziv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNaziv.TextChanged
        If Not _pocetak Then
            _ima_promena = True
        End If
    End Sub

    Private Sub txtSkraceno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSkraceno.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbNadredjena.Select()
        End If
    End Sub
    Private Sub txtSkraceno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSkraceno.TextChanged
        If Not _pocetak Then
            _ima_promena = True
        End If
    End Sub

    Private Sub cmbNadredjena_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbNadredjena.KeyPress
        If e.KeyChar = Chr(13) Then
            chkPoslednji.Select()
        End If
    End Sub
    Private Sub cmbNadredjena_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNadredjena.SelectedIndexChanged
        If Not _pocetak Then
            _ima_promena = True
        End If
    End Sub

    Private Sub chkPoslednji_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPoslednji.CheckedChanged
        _ima_promena = True
    End Sub

    Private Sub txtMarza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMarza.KeyPress
        If e.KeyChar = Chr(13) Then
            cmbPdv.Select()
        End If
    End Sub
    Private Sub txtMarza_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMarza.TextChanged
        If Not _pocetak Then
            _ima_promena = True
        End If
    End Sub

    Private Sub cmbPdv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPdv.KeyPress
        cmbVrsta.Select()
    End Sub
    Private Sub cmbPdv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPdv.SelectedIndexChanged
        If Not _pocetak Then
            _ima_promena = True
        End If
    End Sub

    Private Sub cmbVrsta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbVrsta.KeyPress
        btnSnimi.Select()
    End Sub
    Private Sub cmbVrsta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVrsta.SelectedIndexChanged
        If Not _pocetak Then
            _ima_promena = True
        End If
        selektuj_VrsteArtikla(cmbVrsta.Text, Selekcija.po_nazivu)
        txtIzdajeSeNa.Text = _vrsta_izdajesena
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

End Class
