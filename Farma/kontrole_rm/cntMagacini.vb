Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntMagacini
    Private upit As String = ""
    Private upit_sifra As String = ""
    Private upit_naziv As String = ""
    Private sql As String = "SELECT * FROM dbo.rm_magacin order by sifra"
    Private _pocetak As Boolean = True

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntMagacini_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If _labHead.Text <> "" Then
            _labHead.Text = Mid(_labHead.Text, 1, _labHead.Text.Length - 12)
            obrisi_poslednji_korak_header()
        End If
    End Sub

    Private Sub cntMagacini_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lista()
        _pocetak = False

    End Sub

    Private Sub txtSifra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSifra.TextChanged
        If txtSifra.Text <> "" Then
            upit_sifra = "dbo.rm_magacin.sifra like '" & txtSifra.Text & "%'"
        Else
            upit_sifra = ""
        End If
        filter()
    End Sub
    Private Sub txtNaziv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNaziv.TextChanged
        If txtNaziv.Text <> "" Then
            upit_naziv = "dbo.rm_magacin.naziv like '" & txtNaziv.Text & "%'"
        Else
            upit_naziv = ""
        End If
        filter()
    End Sub

    Private Sub filter()

        On Error Resume Next
        If Not _pocetak Then
            If upit_sifra <> "" Then upit = upit_sifra

            If upit_naziv <> "" And upit <> "" Then
                upit = upit & " and " & upit_naziv
            Else
                If upit_naziv <> "" Then upit = upit_naziv
            End If

            If upit <> "" Then
                sql = "SELECT * FROM dbo.rm_magacin where " & upit & " order by sifra"
            End If

            lista()

        End If
        upit = ""
        sql = "SELECT * FROM dbo.rm_magacin order by sifra"
    End Sub

    Private Sub lista()

        lvMagacini.Items.Clear()

        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql
                DR = .ExecuteReader
            End With

            While DR.Read
                Dim podatak As New ListViewItem(CStr(DR.Item("sifra")))
                podatak.SubItems.Add(DR.Item("naziv").ToString)
                podatak.SubItems.Add(" ") 'rm_vrste_magacina_naziv(DR.Item("id_vrsta_magacina")))
                podatak.SubItems.Add(" ") '(da_ne(DR.Item("vodjenje_zaliha")))
                podatak.SubItems.Add(" ") '(rm_vodjenje_zaliha_naziv(DR.Item("id_vodjenje_zaliha")))

                lvMagacini.Items.AddRange(New ListViewItem() {podatak})
            End While
            DR.Close()
        End If
        CM.Dispose()
        CN.Close()

        _lista = lvMagacini

    End Sub

    Private Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function

    Shared bukmark As String = 0 'broj potvrde
    Private Sub lvMagacini_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvMagacini.Click
        If lvMagacini.SelectedItems.Count > 0 Then
            bukmark = lvMagacini.SelectedItems.Item(0).Text
        End If
    End Sub

    Shared Sub myUpdate()
        If bukmark = 0 Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            selektuj_magacin(bukmark, Selekcija.po_sifri)
            Dim myChild As New frmMagacinEdit
            myChild.Show()
        End If
    End Sub

    Shared Sub myDelete()
        If bukmark = 0 Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            Dim poruka As String = "Da li ste sigurno da želite da izbrišete zapis sa sifrom " & RTrim(bukmark) & " ?"
            If MsgBox(poruka, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim CN As SqlConnection = New SqlConnection(CNNString)
                Dim CM As New SqlCommand

                selektuj_magacin(RTrim(bukmark), Selekcija.po_sifri)

                CN.Open()
                If CN.State = ConnectionState.Open Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "magacini_delete"
                        .Parameters.AddWithValue("@id_magacin", _id_magacin)
                        .ExecuteScalar()
                    End With
                    CM.Dispose()
                End If
            Else
                Exit Sub
            End If
        End If
    End Sub

    Shared Sub myPrn()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM, CM1 As New SqlCommand
        Dim DR As SqlDataReader
        Dim sql As String = ""

        CN.Open()
        If CN.State = ConnectionState.Open Then
            Select Case _stampa
                Case Imena.vrsta_stampe.mag_lista.ToString
                    _raport = Imena.tabele.rm_magacini.ToString
                Case Imena.vrsta_stampe.mag_popisna_lista.ToString
                    _raport = Imena.tabele.rm_magacini.ToString
                    sql = "SELECT DISTINCT rm_magacin.sifra, rm_magacin.naziv, " & _
                            "rm_artikli.artikl_sifra, rm_artikli.artikl_naziv, app_jm.jm_oznaka " & _
                          "FROM app_jm " & _
                            "RIGHT OUTER JOIN rm_artikli " & _
                            "LEFT OUTER JOIN app_jkl ON rm_artikli.id_jkl = app_jkl.id_jkl ON app_jm.id_jm = rm_artikli.id_jm " & _
                            "RIGHT OUTER JOIN rm_magacin_promene " & _
                            "RIGHT OUTER JOIN rm_vrste_magacina " & _
                            "RIGHT OUTER JOIN rm_magacin " & _
                            "LEFT OUTER JOIN rm_vodjenje_zaliha " & _
                            "ON rm_magacin.id_vodjenje_zaliha = rm_vodjenje_zaliha.id_vedjenje_zaliha " & _
                            "ON rm_vrste_magacina.id_vrsta_magacina = rm_magacin.id_vrsta_magacina " & _
                            "ON rm_magacin_promene.id_magacin = rm_magacin.id_magacin " & _
                            "LEFT OUTER JOIN rm_magacin_promene_stavka " & _
                            "ON rm_magacin.id_magacin = rm_magacin_promene_stavka.id_magacin " & _
                            "ON rm_artikli.id_artikl = rm_magacin_promene.id_artikl " & _
                            "LEFT OUTER JOIN app_pdv ON rm_artikli.id_pdv = app_pdv.id_pdv"
                Case Imena.vrsta_stampe.mag_stanje.ToString
                    _raport = Imena.tabele.rm_magacini.ToString
            End Select

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = "prn_PopisnaLista_delete"
                .ExecuteScalar()
            End With
            CM.Dispose()

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sql
                DR = .ExecuteReader
            End With

            Dim i As Integer = 1
            Dim magacin_sifra As String = ""
            Dim magacin_naziv As String = ""
            Dim artikl_rb As Integer = 0
            Dim artikl_sifra As String = ""
            Dim artikl_naziv As String = ""
            Dim artikl_jm As String = ""
            Dim artikl_kolicina As Single = 0

            While DR.Read
                If Not IsDBNull(DR.Item("sifra")) Then magacin_sifra = DR.Item("sifra")
                If Not IsDBNull(DR.Item("naziv")) Then magacin_naziv = DR.Item("naziv")
                If Not IsDBNull(DR.Item("artikl_sifra")) Then artikl_sifra = DR.Item("artikl_sifra")
                If Not IsDBNull(DR.Item("artikl_naziv")) Then artikl_naziv = DR.Item("artikl_naziv")
                If Not IsDBNull(DR.Item("jm_oznaka")) Then artikl_jm = DR.Item("jm_oznaka")
                i += 1
                zapisi(magacin_sifra, magacin_naziv, i, artikl_sifra, artikl_naziv, artikl_jm, 0)

            End While
            DR.Close()
            CM.Dispose()
        End If

        Dim mForm As New frmPrint
        mForm.Show()

    End Sub

    Shared Sub zapisi(ByVal sif, ByVal naz, ByVal i, ByVal art_sif, ByVal art_naz, ByVal art_jm, ByVal art_kol)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
  
        CN.Open()
        CM = New SqlCommand()
        With CM
            .Connection = CN
            .CommandType = CommandType.StoredProcedure
            .CommandText = "prn_PopisnaLista_add"
            .Parameters.AddWithValue("@magacin_sifra", sif)
            .Parameters.AddWithValue("@magacin_naziv", naz)
            .Parameters.AddWithValue("@artikl_rb", i)
            .Parameters.AddWithValue("@artikl_sifra", art_sif)
            .Parameters.AddWithValue("@artikl_naziv", art_naz)
            .Parameters.AddWithValue("@artikl_jm", art_jm)
            .Parameters.AddWithValue("@artikl_kolicina", art_kol)
            .ExecuteScalar()
        End With
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub picRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRefresh.Click
        sql = "SELECT * FROM dbo.rm_magacin order by sifra"
        lista()
    End Sub

    Private Sub picRefresh_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRefresh.MouseHover
        picRefresh.Image = Global.Farma.My.Resources.Resources.reload
        picRefresh.Cursor = Cursors.Hand
    End Sub

    Private Sub picRefresh_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRefresh.MouseLeave
        picRefresh.Image = Global.Farma.My.Resources.Resources.reload1
        picRefresh.Cursor = Cursors.Default
    End Sub

   
End Class
