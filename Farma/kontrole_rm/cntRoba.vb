Option Strict Off
Option Explicit On
Option Compare Text

Imports System.Data.SqlClient

Public Class cntRoba
    Private upit As String = ""
    Private upit_sifra As String = ""
    Private upit_naziv As String = ""
    Private upit_kategorija As String = ""
    Private sql As String = "SELECT * FROM dbo.rm_artikli order by sifra"
    Private _pocetak As Boolean = True

    Private Sub cntRoba_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'SplitContainer1.SplitterDistance = Me.Height * 0.9

        popuni_kategorije()

        CreateMyListView()
        _pocetak = False

    End Sub

    Private Sub txtSifra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSifra.TextChanged
        If txtSifra.Text <> "" Then
            upit_sifra = "dbo.rm_artikli.sifra like '" & txtSifra.Text & "%'"
        Else
            upit_sifra = ""
        End If
        filter()
    End Sub

    Private Sub txtNaziv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNaziv.TextChanged
        If txtNaziv.Text <> "" Then
            upit_naziv = "dbo.rm_artikli.naziv like '" & txtNaziv.Text & "%'"
        Else
            upit_naziv = ""
        End If
        filter()
    End Sub

    Private Sub cmbKategorija_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKategorija.SelectedIndexChanged
        If cmbKategorija.Text <> "" Then
            upit_kategorija = "dbo.rm_artikli.kategorija = '" & cmbKategorija.Text & "'"
        Else
            upit_kategorija = ""
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

            If upit_kategorija <> "" And upit <> "" Then
                upit = upit & " and " & upit_kategorija
            Else
                If upit_kategorija <> "" Then upit = upit_kategorija
            End If
            If upit <> "" Then
                sql = "SELECT * FROM dbo.rm_artikli where " & upit & " order by sifra"
            End If

            CreateMyListView()

        End If
        upit = ""
        sql = "SELECT * FROM dbo.rm_artikli order by sifra"
    End Sub

    Private Sub popuni_kategorije()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbKategorija.Items.Clear()
        cmbKategorija.Items.Add("")

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_kategorizacija.* from dbo.rm_kategorizacija"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbKategorija.Items.Add(DR.Item("naziv"))
            Loop
            DR = Nothing
        End If
        If cmbKategorija.Items.Count > 0 Then
            cmbKategorija.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub CreateMyListView()
        'Dim listView1 As New ListView()
        'listView1.Bounds = New Rectangle(New Point(10, 10), New Size(300, 200))
        'If TableLayoutPanel1.Controls.Count > 0 Then TableLayoutPanel1.Controls.Clear() 'Remove(listView1)
        lvRoba.View = View.Details
        lvRoba.LabelEdit = True
        lvRoba.AllowColumnReorder = True
        lvRoba.CheckBoxes = True
        lvRoba.FullRowSelect = True
        lvRoba.GridLines = True
        lvRoba.BackColor = Color.GhostWhite
        lvRoba.ForeColor = Color.MidnightBlue
        'listView1.Dock = DockStyle.Fill
        'listView1.Parent = Me.TableLayoutPanel1.Controls.Item("Row3")
        lvRoba.BringToFront()
        'tlbPanel.SetRow(listView1, 2)
        'listView1.Sorting = SortOrder.Ascending

        lvRoba.Items.Clear()
        'lvRoba.Clear()
        ''listView1.Columns.Add("id", -2, HorizontalAlignment.Left)
        'lvRoba.Columns.Add("Sifra", 100, HorizontalAlignment.Left)
        'lvRoba.Columns.Add("Naziv", 200, HorizontalAlignment.Left)
        'lvRoba.Columns.Add("jm", 50, HorizontalAlignment.Center)
        'lvRoba.Columns.Add("Nab.cena", 80, HorizontalAlignment.Right)
        'lvRoba.Columns.Add("Nab.€", 60, HorizontalAlignment.Right)
        'lvRoba.Columns.Add("Rabat", 60, HorizontalAlignment.Center)
        'lvRoba.Columns.Add("pdv", 60, HorizontalAlignment.Center)
        'lvRoba.Columns.Add("Cena", 80, HorizontalAlignment.Right)
        'lvRoba.Columns.Add("Cena €", 60, HorizontalAlignment.Right)
        'lvRoba.Columns.Add("Količina", 80, HorizontalAlignment.Right)
        'lvRoba.Columns.Add("Marža", 60, HorizontalAlignment.Right)
        'lvRoba.Columns.Add("Min.kol.", 80, HorizontalAlignment.Right)
        'lvRoba.Columns.Add("Kategorija", 100, HorizontalAlignment.Left)
        'lvRoba.Columns.Add("Bod", 60, HorizontalAlignment.Left)
        'lvRoba.Columns.Add("Cena boda", 100, HorizontalAlignment.Left)

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
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            While DR.Read
                Dim podatak As New ListViewItem(CStr(DR.Item("sifra")))
                podatak.SubItems.Add(DR.Item("sifra_opis").ToString)
                podatak.SubItems.Add(DR.Item("naziv"))
                podatak.SubItems.Add(DR.Item("jm"))
                podatak.SubItems.Add(DR.Item("nabavna").ToString)
                podatak.SubItems.Add(DR.Item("nabavna_euro").ToString)
                podatak.SubItems.Add(DR.Item("rabat").ToString)
                podatak.SubItems.Add(DR.Item("pdv"))
                podatak.SubItems.Add(DR.Item("cena").ToString)
                podatak.SubItems.Add(DR.Item("euro").ToString)
                podatak.SubItems.Add(DR.Item("kolicina").ToString)
                podatak.SubItems.Add(DR.Item("marza").ToString)
                podatak.SubItems.Add(DR.Item("min_kolicina").ToString)
                podatak.SubItems.Add(DR.Item("kategorija"))
                If Not IsDBNull(DR.Item("bod")) Then
                    podatak.SubItems.Add(da_ne(DR.Item("bod")))
                Else
                    podatak.SubItems.Add(0)
                End If
                If Not IsDBNull(DR.Item("bod_cena")) Then
                    podatak.SubItems.Add(DR.Item("bod_cena"))
                Else
                    podatak.SubItems.Add(0)
                End If

                lvRoba.Items.AddRange(New ListViewItem() {podatak})
            End While
            DR.Close()
        End If

        CM.Dispose()
        CN.Close()

        'Me.Controls.Add(listView1)
        'Me.TableLayoutPanel1.Controls.Add(listView1)
        _lista = lvRoba

    End Sub

    Private Function da_ne(ByVal val As Boolean) As String
        If val Then
            da_ne = "DA"
        Else
            da_ne = "NE"
        End If
    End Function

    Shared bukmark As String = 0 'broj potvrde
    Private Sub lvRoba_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvRoba.Click
        If lvRoba.SelectedItems.Count > 0 Then
            bukmark = lvRoba.SelectedItems.Item(0).Text
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

                robu_posifri(RTrim(bukmark))

                CN.Open()
                If CN.State = ConnectionState.Open Then
                    CM = New SqlCommand()
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "rm_artikli_delete"
                        .Parameters.AddWithValue("@id_artikl", _id_roba)
                        .ExecuteScalar()
                    End With
                    CM.Dispose()
                End If
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub picRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRefresh.Click
        sql = "SELECT * FROM dbo.rm_artikli order by sifra"
        CreateMyListView()
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
