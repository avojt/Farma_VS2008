Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntUIDok
    Private upit As String = ""
    Private upit_sifra As String = ""
    Private upit_naziv As String = ""
    Private upit_kategorija As String = ""
    Private upit_vrsta As String = ""
    Private upit_proizvodjac As String = ""
    Private sql_start As String = "SELECT DISTINCT dbo.rm_artikli.artikl_naziv, rm_artikli.artikl_sifra, dbo.app_jm.jm_naziv, dbo.app_artikl_grupa.gr_artikla_naziv," & _
                                    " dbo.app_jkl.jkl_sifra, dbo.rm_artikli.artikl_vrsta, dbo.app_partneri.partner_naziv" & _
                                  " FROM dbo.rm_artikli" & _
                                    " LEFT OUTER JOIN dbo.app_jkl ON dbo.rm_artikli.id_jkl = dbo.app_jkl.id_jkl" & _
                                    " LEFT OUTER JOIN dbo.app_partneri ON dbo.rm_artikli.id_proizvodjac = dbo.app_partneri.id_partner" & _
                                    " LEFT OUTER JOIN dbo.app_jm ON dbo.rm_artikli.id_jm = dbo.app_jm.id_jm" & _
                                    " LEFT OUTER JOIN dbo.app_artikl_grupa ON dbo.rm_artikli.id_kategorija = dbo.app_artikl_grupa.id_grup_artikla"

    Private sql As String = ""
    Private _pocetak As Boolean = True

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntUIDok_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'If _labHead.Text <> "" Then
        '    _labHead = Mid(_labHead.Text, 1, _labHead.Text.Length - 11)
        '    obrisi_poslednji_korak_header()
        'End If
    End Sub

    Private Sub cntUIDok_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        spSpliter.Panel1Collapsed = True
        _mSpliter = spSpliter
        _mSpliter_zatvoren = True
        _lista = lvLista

        sql = sql_start
        _pocetak = False
        '_labHead = Ispisi_label() 
        '_txtHeader.Size = New Size(_txtHeader.TextLength * 9.5, _txtHeader.Height)
    End Sub

    Private Sub filter()

        On Error Resume Next
        If Not _pocetak Then
            'If upit_sifra <> "" Then upit = upit_sifra

            If upit_naziv <> "" And upit <> "" Then
                upit = upit & " and " & upit_naziv
            Else
                If upit_naziv <> "" Then upit = upit_naziv
            End If

            If upit_kategorija <> "" And upit <> "" Then
                upit = upit & " and " & upit_kategorija
            Else
                If upit_kategorija <> "" Then upit = upit_kategorija
            End If

            If upit_vrsta <> "" And upit <> "" Then
                upit = upit & " and " & upit_vrsta
            Else
                If upit_vrsta <> "" Then upit = upit_vrsta
            End If

            If upit_proizvodjac <> "" And upit <> "" Then
                upit = upit & " and " & upit_proizvodjac
            Else
                If upit_proizvodjac <> "" Then upit = upit_proizvodjac
            End If

            sql = sql_start
            If upit <> "" Then
                sql += " WHERE " & upit
            End If
            CreateMyListView()
        End If
        upit = ""

    End Sub

    Private Sub CreateMyListView()
        ''Dim listView1 As New ListView()
        ''listView1.Bounds = New Rectangle(New Point(10, 10), New Size(300, 200))
        ''If TableLayoutPanel1.Controls.Count > 0 Then TableLayoutPanel1.Controls.Clear() 'Remove(listView1)
        'lvLista.View = View.Details

        lvLista.Items.Clear()
        'lvLista.Clear()
        'lvLista.Columns.Add("id", -2, HorizontalAlignment.Left)
        lvLista.Columns.Add("Sifra", 100, HorizontalAlignment.Left)
        lvLista.Columns.Add("Naziv", 200, HorizontalAlignment.Left)
        lvLista.Columns.Add("jm", 50, HorizontalAlignment.Center)
        If sql <> "" Then
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
                    Dim podatak As New ListViewItem(CStr(DR.Item("artikl_naziv")))

                    podatak.SubItems.Add(DR.Item("artikl_sifra").ToString)
                    podatak.SubItems.Add(DR.Item("jm_naziv").ToString)
                    podatak.SubItems.Add(DR.Item("gr_artikla_naziv").ToString)
                    podatak.SubItems.Add(DR.Item("jkl_sifra").ToString)
                    podatak.SubItems.Add(DR.Item("artikl_vrsta").ToString)
                    podatak.SubItems.Add(DR.Item("partner_naziv").ToString)

                    lvLista.Items.AddRange(New ListViewItem() {podatak})
                End While
                DR.Close()
            End If

            CM.Dispose()
            CN.Close()
        End If
        'Me.Controls.Add(listView1)
        'Me.TableLayoutPanel1.Controls.Add(listView1)
        _lista = lvLista

    End Sub

    Private Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function

    Shared bukmark As String = 0 'broj potvrde
    Private Sub lvLista_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLista.Click
        If lvLista.SelectedItems.Count > 0 Then
            bukmark = lvLista.SelectedItems.Item(0).Text
        End If
    End Sub

    Shared Sub myDelete()
        If bukmark = "" Then
            MsgBox("Prvo morate izabrati stavku koji želite da izmFarmate", MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            Dim poruka As String = "Da li ste sigurno da želite da izbrišete zapis sa sifrom " & bukmark & " ?"
            If MsgBox(poruka, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim CN As SqlConnection = New SqlConnection(CNNString)
                Dim CM As New SqlCommand

                selektuj_artikl(RTrim(bukmark), Selekcija.po_sifri)

                CN.Open()
                If CN.State = ConnectionState.Open Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "rm_artikli_delete"
                        .Parameters.AddWithValue("@id_artikl", _id_artikl)
                        .ExecuteScalar()
                    End With
                    CM.Dispose()
                End If
            Else
                Exit Sub
            End If
        End If
    End Sub

End Class
