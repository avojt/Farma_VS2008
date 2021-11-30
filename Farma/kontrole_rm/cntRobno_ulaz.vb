Option Strict Off
Option Explicit On

Imports System.Xml
Imports System.ComponentModel
Imports System.IO

Imports System.Data.SqlClient

Public Class cntRobno_ulaz


#Region "dekleracija"
    Private kol_pop As Single = 0
    Private kol_mag As Single = 0
    Private kol As Single = 0
    Private cena As Single = 0
    Private mp_cena As Single = 0
    Private c_cena_nab As Single = 0
    Private c_cena_vp As Single = 0
    Private c_cena_mp As Single = 0
    Private pdv As Single = 1
    Private c_pdv As Integer = 18
    Private rabat As Single = 0
    Private c_rabat As Integer = 0
    Private c_JM As String = ""
    Private c_Grupa As String = ""
    Private marza As Single = 0
    Private c_marza As Integer = 0
    Private lSifra As String = ""
    Private lNaziv As String = ""
    Private lKol As Single = 0
    Private lCena As Single = 0
    Private lId As Integer = 0
    Private ztroskovi_stavka As Single = 0
    Private s_nab_vrednost As Single = 0
    Private s_prod_vrednost As Single = 0
    Private s_pdv_osnovica As Single = 0
    Private s_pdv As Single = 0
    Private s_rab As Single = 0
    Private s_ztr As Single = 0
    Private s_marza As Single = 0
    Private s_ztroskovi As Single = 0
    Private s_ztros_proporcija As Single = 0
    Private valuta As Integer = 0
    Private nab_cena As Single = 0
    Private nab_vrednost As Single = 0
    Private prod_cena As Single = 0
    Private prod_vrednost As Single = 0
    Private trenutna_cena As Single = 0
    Private trenutna_kolicina As Single = 0
    Private sifra As String = ""
    Private naziv As String = ""
    Private indeks As Integer = 0
    Private broj_decimala() As Integer
    'Private id_predhodnog_stanja As Integer
    'Private id_predhodnog_stanja_stavka As Integer

    Private _pocetak As Boolean = True
    Private _citam_stavke As Boolean = True
    Private _promenjena_marza As Boolean = False
    Private _promenjena_nabav_cena As Boolean = False
    Private _prod_cena_promenjena As Boolean = False
    Private _popunjavam_robu As Boolean = False
    Private _izabran_magacin As Boolean = False
    Private magacinID As Integer = 0
    Private magacinSifra As String = ""

    Private _tab As String = ""

    Private upit As String = ""
    Private upit_sifra As String = ""
    Private upit_lek As String = ""


    Shared sql_start As String = _
                    "SELECT DISTINCT " & _
                          "TOP (100) PERCENT dbo.rm_artikli.artikl_sifra, dbo.rm_artikli.artikl_naziv, " & _
                          "dbo.rm_artikli.jkl, dbo.rm_artikli.artikl_genericko_ime, " & _
                          "dbo.app_artikl_grupa.gr_artikla_sifra, dbo.app_artikl_grupa.gr_artikla_naziv, " & _
                          "dbo.app_partneri.partner_naziv, dbo.app_fo.fo_sifra, dbo.app_fo.fo_naziv, " & _
                          "dbo.app_jm.jm_oznaka, dbo.app_pozitivna_lista.jkl_sifra, dbo.app_pozitivna_lista.L1, " & _
                          "dbo.app_pozitivna_lista.l1_datum_OD, dbo.app_pozitivna_lista.l1_datum_DO " & _
                    "FROM dbo.rm_artikli LEFT OUTER JOIN " & _
                          "dbo.app_pozitivna_lista ON dbo.rm_artikli.jkl = dbo.app_pozitivna_lista.jkl_sifra  " & _
                          "LEFT OUTER JOIN dbo.app_fo ON dbo.rm_artikli.id_fo = dbo.app_fo.id_fo LEFT OUTER JOIN " & _
                          "dbo.app_partneri ON dbo.rm_artikli.id_proizvodjac = dbo.app_partneri.id_partner " & _
                          "LEFT OUTER JOIN dbo.app_jm ON dbo.rm_artikli.id_jm = dbo.app_jm.id_jm LEFT OUTER JOIN " & _
                          "dbo.app_artikl_grupa ON dbo.rm_artikli.id_grup_artikla = dbo.app_artikl_grupa.id_grup_artikla"

    Shared sql As String = ""

    Private _dokument As New clsRobno

#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cntRobno_ulaz_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.App_pdvTableAdapter.Fill(Me.DataSet1.app_pdv)
        'tlbMain.Dock = DockStyle.Fill
        sSpliter.Dock = DockStyle.Fill
        dgStavke.Dock = DockStyle.Fill

        '_lista = Me.lvLista

        broj_decimala = New Integer() {}
        ReDim broj_decimala(100)

        mRob_kontrola.tb_sifra = txtSifra
        mRob_kontrola.tb_naziv = txtNaziv
        mRob_kontrola.tb_grupa = txtGrupa
        mRob_kontrola.tb_grupa_naziv = txtGrupaNaziv
        mRob_kontrola.tb_jm = txtJM
        mRob_kontrola.tb_pdv = txtPdv
        mRob_kontrola.tb_nab_cena = txtNCena
        mRob_kontrola.tb_kol = txtKol

        _mLabel = labLager

        _pocetak = True

        popuni_magacine()
        popuni_parnere()
        popuni_vrste_dokumenta()

        pocetak()
        cmbVrstaDok.Focus()

    End Sub

    Private Sub pocetak()
        _pocetak = True

        dgStavke.Rows.Clear()
        labLager.Text = "--"

        txtBroj.Text = Nadji_rb(mRob_Dokument.tabela, 1)
        txtUkupno.Text = 0
        txtOsnovica.Text = 0
        txtIznosPdv.Text = 0
        txtRabat.Text = 0
        txtSvega.Text = 0
        txtFaktura.Text = ""
        cmbPartneri.Visible = True

        dateFaktura.Value = Today
        dateDokument.Value = Today

        _pocetak = False
        _izabran_magacin = False
        kontrole()

        

    End Sub

    Private Sub kontrole()
        Select Case _izabran_magacin
            Case True
                sSpliter.Panel2.Enabled = True
                btnSnimi.Enabled = True
            Case False
                sSpliter.Panel2.Enabled = False
                btnSnimi.Enabled = False
        End Select
    End Sub

    Private Sub popuni_parnere()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbPartneri.Items.Clear()

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_partneri.* from dbo.app_partneri"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbPartneri.Items.Add(DR.Item("partner_naziv"))
            Loop
            DR.Close()
        End If
        If cmbPartneri.Items.Count > 0 Then
            cmbPartneri.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_magacine()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbMagacin.Items.Clear()
        cmbMagacin.Items.Add("")
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_magacin.* from dbo.rm_magacin"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbMagacin.Items.Add(DR.Item("magacin_naziv"))
            Loop
            DR.Close()
        End If
        If cmbMagacin.Items.Count > 0 Then
            cmbMagacin.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub popuni_vrste_dokumenta()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        cmbVrstaDok.Items.Clear()
        'cmbVrstaDok.Items.Add("")
        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_vrste_dokumenata.* from dbo.app_vrste_dokumenata where vrsta_dok_strana_knjizenja = 'DUG' order by vrsta_dok_naziv"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                cmbVrstaDok.Items.Add(DR.Item("vrsta_dok_naziv"))
            Loop
            DR.Close()
        End If
        If cmbVrstaDok.Items.Count > 0 Then
            cmbVrstaDok.SelectedIndex = 0
        End If
        CM.Dispose()
        CN.Close()
    End Sub

#Region "grid"
    Private _row_index As Integer = 0
    Private Sub dgStavke_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgStavke.RowHeaderMouseDoubleClick
        nova_stavka()
        'If tlbMain.RowStyles.Item(5).Height = 1 Then tlbMain.RowStyles.Item(5).Height = 175
        If sSpliter.SplitterDistance < 230 Then sSpliter.SplitterDistance = 230
        PictureBox1.BackgroundImage = My.Resources._3_Up
        With dgStavke
            _row_index = e.RowIndex
            txtSifra.Text = .Rows(e.RowIndex).Cells(1).Value
            txtNaziv.Text = .Rows(e.RowIndex).Cells(2).Value
            txtJM.Text = .Rows(e.RowIndex).Cells(3).Value
            txtGrupaNaziv.Text = .Rows(e.RowIndex).Cells(4).Value
            selektuj_GrupeArt(.Rows(e.RowIndex).Cells(4).Value, Selekcija.po_nazivu)
            txtGrupa.Text = _gr_art_sifra
            txtKol.Text = .Rows(e.RowIndex).Cells(5).Value
            txtNCena.Text = .Rows(e.RowIndex).Cells(6).Value
            txtNVred.Text = .Rows(e.RowIndex).Cells(7).Value
            txtPdv.Text = .Rows(e.RowIndex).Cells(8).Value
            'txtPrCena.Text = .Rows(e.RowIndex).Cells(9).Value
            'txtPrVred.Text = .Rows(e.RowIndex).Cells(10).Value

        End With
        btnUnesi.Visible = False
        btnNastavi.Visible = True
        btnIzmeni.Visible = True
        btnIzbrisi.Visible = True
    End Sub

    Private Sub dgStavke_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgStavke.RowsAdded
        dgStavke.Rows(e.RowIndex).Selected = True
        dgStavke.FirstDisplayedScrollingRowIndex = e.RowIndex
    End Sub

    Private Sub dgStavke_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgStavke.RowsRemoved
        preracunaj()
    End Sub
#End Region

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Select Case sSpliter.SplitterDistance < 230
            Case True
                sSpliter.SplitterDistance = 230 ' 5
                'tlbMain.RowStyles.Item(5).Height = 272 ' 1
                PictureBox1.BackgroundImage = My.Resources._3_Up
            Case False
                sSpliter.SplitterDistance = 35
                'tlbMain.RowStyles.Item(5).Height = 1
                PictureBox1.BackgroundImage = My.Resources._3_Down
        End Select
    End Sub

    Private Sub btnUnesi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnesi.Click
        unesi()
        nova_stavka()
    End Sub

    Private Sub btnIzbrisi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzbrisi.Click
        dgStavke.Rows.RemoveAt(_row_index)
        nova_stavka()
    End Sub

    Private Sub btnIzmeni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzmeni.Click
        With dgStavke
            If txtSifra.Text <> "" Then .Rows(_row_index).Cells(1).Value = RTrim(txtSifra.Text)
            If txtNaziv.Text <> "" Then .Rows(_row_index).Cells(2).Value = RTrim(txtNaziv.Text)
            If txtJM.Text <> "" Then .Rows(_row_index).Cells(3).Value = RTrim(txtJM.Text)
            If txtGrupaNaziv.Text <> "" Then .Rows(_row_index).Cells(4).Value = RTrim(txtGrupaNaziv.Text)
            If txtKol.Text <> "" Then
                .Rows(_row_index).Cells(5).Value = RTrim(txtKol.Text)
            Else
                .Rows(_row_index).Cells(5).Value = 0
            End If
            If txtNCena.Text <> "" Then
                .Rows(_row_index).Cells(6).Value = RTrim(txtNCena.Text)
            Else
                .Rows(_row_index).Cells(6).Value = 0
            End If
            If txtRabat.Text <> "" Then
                .Rows(_row_index).Cells(7).Value = RTrim(txtRabat.Text) 'rabat u %
            Else
                .Rows(_row_index).Cells(7).Value = 0
            End If
            'If txtNCena.Text <> "" Then
            '    .Rows(i).Cells(8).Value = RTrim(txtNCena.Text)
            'Else
            .Rows(_row_index).Cells(8).Value = 0
            'End If
            Dim cena_kostanja As Single = CSng(txtNCena.Text) * (1 - (CSng(txtRabat.Text) / 100))
            If txtNCena.Text <> "" And txtRabat.Text <> "" Then
                .Rows(_row_index).Cells(9).Value = Format(cena_kostanja, "#,##0.00")
            Else
                .Rows(_row_index).Cells(9).Value = 0
            End If
            If txtNVred.Text <> "" Then
                .Rows(_row_index).Cells(10).Value = RTrim(txtNVred.Text)
            Else
                .Rows(_row_index).Cells(10).Value = 0
            End If
            .Rows(_row_index).Cells(11).Value = 0 '************
            If txtPdv.Text <> "" Then
                .Rows(_row_index).Cells(12).Value = RTrim(txtPdv.Text)
            Else
                .Rows(_row_index).Cells(12).Value = 0
            End If
            Dim pdv As Integer = CInt(txtPdv.Text)
            If txtPrCena.Text <> "" Then
                .Rows(_row_index).Cells(13).Value = cena_kostanja '* (1+ (pdv/100))
            Else
                .Rows(_row_index).Cells(13).Value = 0
            End If
            Dim mpc As Single = .Rows(_row_index).Cells(13).Value
            .Rows(_row_index).Cells(14).Value = cena_kostanja * (pdv / 100)
            .Rows(_row_index).Cells(15).Value = mpc * .Rows(_row_index).Cells(5).Value
        End With

        preracunaj()
    End Sub

    Private Sub btnNastavi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNastavi.Click
        nova_stavka()
        btnUnesi.Visible = True
        btnNastavi.Visible = False
        btnIzmeni.Visible = False
    End Sub

    Private Sub novi()

        dgStavke.Rows.Clear()

        txtBroj.Text = Nadji_rb(_tab, 2)
        txtSifra.Text = ""
        txtNaziv.Text = ""
        txtGrupa.Text = ""
        txtGrupaNaziv.Text = "" ' 0
        txtJM.Text = ""
        'txtMarza.Text = 0
        txtKol.Text = 0
        txtNCena.Text = 0
        txtNVred.Text = 0
        txtPdv.Text = 0
        txtPrCena.Text = 0
        txtPrVred.Text = 0

        _ima_promena = False
    End Sub

    Private Sub unesi()
        With dgStavke
            Dim i As Integer = dgStavke.RowCount - 1
            .Rows.Add(1)
            .Rows(i).Cells(0).Value = i + 1
            If txtSifra.Text <> "" Then .Rows(i).Cells(1).Value = RTrim(txtSifra.Text)
            If txtNaziv.Text <> "" Then .Rows(i).Cells(2).Value = RTrim(txtNaziv.Text)
            If txtJM.Text <> "" Then .Rows(i).Cells(3).Value = RTrim(txtJM.Text)
            If txtGrupaNaziv.Text <> "" Then .Rows(i).Cells(4).Value = RTrim(txtGrupaNaziv.Text)
            If txtKol.Text <> "" Then
                .Rows(i).Cells(5).Value = RTrim(txtKol.Text)
            Else
                .Rows(i).Cells(5).Value = 0
            End If
            If txtNCena.Text <> "" Then
                .Rows(i).Cells(6).Value = RTrim(txtNCena.Text)
            Else
                .Rows(i).Cells(6).Value = 0
            End If
            If txtRabat.Text <> "" Then
                .Rows(i).Cells(7).Value = RTrim(txtRabat.Text) 'rabat u %
            Else
                .Rows(i).Cells(7).Value = 0
            End If
            'If txtNCena.Text <> "" Then
            '    .Rows(i).Cells(8).Value = RTrim(txtNCena.Text)
            'Else
            .Rows(i).Cells(8).Value = 0
            'End If
            Dim cena_kostanja As Single = CSng(txtNCena.Text) * (1 - (CSng(txtRabat.Text) / 100))
            If txtNCena.Text <> "" And txtRabat.Text <> "" Then
                .Rows(i).Cells(9).Value = Format(cena_kostanja, "#,##0.00")
            Else
                .Rows(i).Cells(9).Value = 0
            End If
            If txtNVred.Text <> "" Then
                .Rows(i).Cells(10).Value = RTrim(txtNVred.Text)
            Else
                .Rows(i).Cells(10).Value = 0
            End If
            .Rows(i).Cells(11).Value = 0 '************
            If txtPdv.Text <> "" Then
                .Rows(i).Cells(12).Value = RTrim(txtPdv.Text)
            Else
                .Rows(i).Cells(12).Value = 0
            End If
            Dim pdv As Integer = CInt(txtPdv.Text)
            If txtPrCena.Text <> "" Then
                .Rows(i).Cells(13).Value = cena_kostanja '* (1+ (pdv/100))
            Else
                .Rows(i).Cells(13).Value = 0
            End If
            Dim mpc As Single = .Rows(i).Cells(13).Value
            .Rows(i).Cells(14).Value = cena_kostanja * (pdv / 100)
            .Rows(i).Cells(15).Value = mpc * .Rows(i).Cells(5).Value
            
        End With
        preracunaj()

        'labLager.Text = "Stavka broj: " & dgStavke.Rows.Count
    End Sub

    Private Sub nova_stavka()
        txtSifra.Text = ""
        txtNaziv.Text = ""
        txtGrupa.Text = ""
        txtGrupaNaziv.Text = "" ' 0
        txtJM.Text = ""
        'txtMarza.Text = 0
        txtKol.Text = 0
        txtNCena.Text = 0
        txtNVred.Text = 0
        txtPdv.Text = 0
        txtPrCena.Text = 0
        txtPrVred.Text = 0

        txtSifra.Select()
    End Sub

    Private Sub preracunaj()
        Dim i As Integer

        s_nab_vrednost = 0
        s_pdv = 0
        s_rab = 0
        s_ztr = 0
        s_marza = 0
        s_prod_vrednost = 0
        s_pdv_osnovica = 0

        Try
            For i = 0 To dgStavke.Rows.Count - 1
                Dim kol As Single = CSng(dgStavke.Rows(i).Cells(5).Value)
                Dim cena As Single = CSng(dgStavke.Rows(i).Cells(6).Value)
                Dim rab As Single = 0 'CSng(dgStavke.Rows(i).Cells(7).Value)
                Dim ztr As Single = CSng(dgStavke.Rows(i).Cells(8).Value)
                Dim nabcena As Single = CSng(dgStavke.Rows(i).Cells(9).Value)
                Dim nabvr As Single = CSng(dgStavke.Rows(i).Cells(10).Value)
                Dim mar As Single = 0 ' CSng(dgStavke.Rows(i).Cells(11).Value)
                Dim pdv As Single = CInt(dgStavke.Rows(i).Cells(12).Value)
                Dim mp_cena As Single = CSng(dgStavke.Rows(i).Cells(13).Value)
                Dim pdv_iznos As Single = CSng(dgStavke.Rows(i).Cells(14).Value)
                Dim pr_vred As Single = CSng(dgStavke.Rows(i).Cells(15).Value)

                rab = cena * CSng(dgStavke.Rows(i).Cells(7).Value) / 100

                s_nab_vrednost += CSng(nabvr)
                s_rab += rab
                s_marza += 0 ' (nabvr * mar / 100)
                s_pdv += (kol * pr_vred * pdv / 100)
                s_pdv += CSng(kol * (mp_cena * (1 - (1 / (1 + (pdv / 100))))))
                's_pdv = 0
                s_prod_vrednost += CSng(pr_vred)
                s_pdv_osnovica += CSng(kol * mp_cena / (1 + (pdv / 100)))
                's_pdv_osnovica = 0
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'If Not _unesen Then
        txtUkupno.Text = Format(s_nab_vrednost, "#,##0.00")
        txtRabat.Text = Format(s_rab, "#,##0.00")
        txtOsnovica.Text = Format(s_pdv_osnovica, "#,##0.00")
        txtIznosPdv.Text = Format(s_pdv, "#,##0.00")
        txtSvega.Text = Format(s_prod_vrednost, "#,##0.00")
        'End If

    End Sub

    Public Sub InitializeConfigure()

        Dim mxDoc As XmlDocument
        Dim xmlPath As String

        xmlPath = My.Application.Info.DirectoryPath & "\seme\" & "ulazni_dokumenti.xml"

        mxDoc = New XmlDocument()
        mxDoc.Load(xmlPath)

        Dim msw As New StringWriter()
        'Call ReadXMLFile(mxDoc, 0)

        'CNNString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & msp.База & ";Data Source=" & msp.Сервер
        'CNNString = "Data Source=" & msp.Сервер & ";Initial Catalog=" & msp.База & ";Persist Security Info=False;User ID=sa;Password=xxxx"

    End Sub


    'Public Sub ReadXMLFile(ByVal xNode As XmlNode, ByVal intLevel As Integer)
    '    'Dim xNodeLoop As XmlNode
    '    'If xNode.HasChildNodes Then
    '    '    With _dokument
    '    '        For Each xNodeLoop In xNode.ChildNodes
    '    '            ReadXMLFile(xNodeLoop, 0)
    '    '        Next xNodeLoop
    '    '        If xNode.Name = cmbVrstaDok.Text Then
    '    '            .KonamdTekst = xNode.InnerText
    '    '            .Broj_kolona = 11
    '    '            .dokumenta_id = 13
    '    '        End If
    '    '    End With
    '    'End If

    '    Dim mxDoc As XmlDocument
    '    Dim xmlPath As String = My.Application.Info.DirectoryPath & "\seme\" & "ulazni_dokumenti.xml"

    '    mxDoc = New XmlDocument()
    '    mxDoc.Load(xmlPath)

    '    Dim reader As New XmlTextReader(xmlPath)
    '    reader.MoveToContent() 'Move to the cd element node.
    '    'Create a node representing the cd element node.
    '    'Dim mDoc As XmlNode = mxDoc.ReadNode(reader)

    '    reader.MoveToContent()
    '    While reader.Read()
    '        If reader.Name = cmbVrstaDok.Name Then
    '            Select Case reader.Name
    '                Case "Tabela"
    '                    mRob_Dokument.tabela = reader.Value
    '                Case "KonamdTekst"
    '                    mRob_Dokument.KonamdTekst = reader.Value
    '                Case "Broj_kolona"
    '                    mRob_Dokument.Broj_kolona = reader.Value
    '                Case "dokumenta_id"
    '                    mRob_Dokument.dokumenta_id = reader.Value
    '                Case "kotrole"
    '                    mRob_Dokument.KonamdTekst = reader.Value
    '            End Select
    '        End If
    '        'Select Case reader.NodeType
    '        '    Case XmlNodeType.Element
    '        '        Console.Write("<{0}>", reader.Name)
    '        '    Case XmlNodeType.Text
    '        '        Console.Write(reader.Value)
    '        '    Case XmlNodeType.CDATA
    '        '        Console.Write("<![CDATA[{0}]]>", reader.Value)
    '        '    Case XmlNodeType.ProcessingInstruction
    '        '        Console.Write("<?{0} {1}?>", reader.Name, reader.Value)
    '        '    Case XmlNodeType.Comment
    '        '        Console.Write("<!--{0}-->", reader.Value)
    '        '    Case XmlNodeType.XmlDeclaration
    '        '        Console.Write("<?xml version='1.0'?>")
    '        '    Case XmlNodeType.Document
    '        '    Case XmlNodeType.DocumentType
    '        '        Console.Write("<!DOCTYPE {0} [{1}]", reader.Name, reader.Value)
    '        '    Case XmlNodeType.EntityReference
    '        '        Console.Write(reader.Name)
    '        '    Case XmlNodeType.EndElement
    '        '        Console.Write("</{0}>", reader.Name)
    '        'End Select
    '    End While

    '    'Insert the new node into the document.
    '    'mxDoc.DocumentElement.AppendChild(mDoc)

    '    'Console.WriteLine("Display the modified XML...")
    '    'mxDoc.Save(Console.Out)

    'End Sub

    Private Sub cmbVrstaDok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbVrstaDok.KeyPress
        cmbMagacin.Select()
    End Sub

    Private Sub cmbVrstaDok_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVrstaDok.SelectedIndexChanged

        txtSifra.Visible = True
        txtKol.Visible = True
        txtNCena.Visible = True
        txtNVred.Visible = True
        txtMarza.Visible = False
        Label3.Visible = False
        txtBroj.Visible = True
        txtFaktura.Visible = True
        txtGrupa.Visible = True
        txtGrupaNaziv.Visible = True
        txtIznosPdv.Visible = True
        txtJM.Visible = True
        txtNaziv.Visible = True
        txtOsnovica.Visible = True
        txtPdv.Visible = True
        'txtPrCena.Visible = True
        'txtPrVred.Visible = True
        txtRabat.Visible = True
        txtSvega.Visible = True
        txtUkupno.Visible = True

        Select Case cmbVrstaDok.Text
            Case "kalkulacija"
                mRob_Dokument.tabela = Imena.tabele.rm_kalkulacija_head.ToString
                mRob_Dokument.KonamdTekst = "rm_kalkulacija"
                mRob_Dokument.dokumenta_id = 4
                mRob_Dokument.Broj_kolona = 11

            Case "nivelacija cena"
                mRob_Dokument.tabela = Imena.tabele.rm_nivelacije_head.ToString
                mRob_Dokument.KonamdTekst = "rm_nivelacije"
                mRob_Dokument.dokumenta_id = 10
                mRob_Dokument.Broj_kolona = 11

            Case "knjizno odobrenje ulaz"
                mRob_Dokument.tabela = Imena.tabele.rm_knjizno_odobrenje_u_head.ToString
                mRob_Dokument.KonamdTekst = "rm_knjizno_odobrenje"
                mRob_Dokument.dokumenta_id = 11
                mRob_Dokument.Broj_kolona = 11

            Case "knjizno zaduzenje ulaz"
                mRob_Dokument.tabela = Imena.tabele.rm_knjizno_zaduzenje_ulaz_head.ToString
                mRob_Dokument.KonamdTekst = "rm_knjizno_zaduzenje_ulaz"
                mRob_Dokument.dokumenta_id = 12
                mRob_Dokument.Broj_kolona = 11

            Case "interna dostavnica ulaz"
                mRob_Dokument.tabela = Imena.tabele.rm_int_dostav_ulaz_head.ToString
                mRob_Dokument.KonamdTekst = "rm_int_dostav_ulaz"
                mRob_Dokument.dokumenta_id = 3
                mRob_Dokument.Broj_kolona = 11
                txtMarza.Visible = True
                Label3.Visible = True

            Case "povracaj robe"
                mRob_Dokument.tabela = Imena.tabele.rm_povracaj_robe_head.ToString
                mRob_Dokument.KonamdTekst = "rm_povracaj_robe"
                mRob_Dokument.dokumenta_id = 13
                mRob_Dokument.Broj_kolona = 11

            Case "popis"
                mRob_Dokument.tabela = Imena.tabele.rm_popis_head.ToString
                mRob_Dokument.KonamdTekst = "rm_popis"
                mRob_Dokument.dokumenta_id = 16
                mRob_Dokument.Broj_kolona = 11

            Case "magacinski interni prenos"
                mRob_Dokument.tabela = Imena.tabele.rm_mag_interni_prenos_head.ToString
                mRob_Dokument.KonamdTekst = "rm_mag_interni_prenos"
                mRob_Dokument.dokumenta_id = 18
                mRob_Dokument.Broj_kolona = 11

            Case "interni prenos"
                mRob_Dokument.tabela = Imena.tabele.rm_interni_prenos_head.ToString
                mRob_Dokument.KonamdTekst = "rm_interni_prenos"
                mRob_Dokument.dokumenta_id = 19
                mRob_Dokument.Broj_kolona = 11

        End Select
        pocetak()
        'Dim mxDoc As XmlDocument
        'Dim xmlPath As String

        'xmlPath = My.Application.Info.DirectoryPath & "\seme\" & "ulazni_dokumenti.xml"

        'mxDoc = New XmlDocument()
        'mxDoc.Load(xmlPath)

        'Dim msw As New StringWriter()
        'Call ReadXMLFile(mxDoc, 0)

    End Sub


    Private Function Partner(ByVal _partner) As Integer
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_partneri.* from dbo.app_partneri where partner_naziv = '" & _partner & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                Partner = DR.Item("id_partner")
            Loop
        End If
        CM.Dispose()
        CN.Close()
    End Function

    Private Function Partner_ime(ByVal _id) As String
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Partner_ime = ""

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_partneri.* from dbo.app_partneri where id_partner = '" & _id & "'"
                DR = .ExecuteReader
            End With
            Do While DR.Read
                Partner_ime = DR.Item("naziv")
            Loop
        End If
        CM.Dispose()
        CN.Close()

        Return Partner_ime

    End Function

    Private Sub redni_broj()
        'Dim i As Integer

        'For i = 0 To dgStavke.RowCount - 2
        '    dgStavke.Rows(i).Cells(0).Value = i + 1
        'Next
    End Sub

    Private Sub popuni_robu(ByVal _roba As String)
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        'Dim DR As SqlDataReader

        'sifra = ""
        'naziv = ""
        'c_JM = ""
        'c_Grupa = ""
        'c_cena_nab = 0
        'c_cena_vp = 0
        'c_cena_mp = 0
        ''trenutna_kolicina = 0
        'c_pdv = 1
        'c_rabat = 0
        'c_marza = 0

        'CN.Open()
        'If CN.State = ConnectionState.Open Then
        '    CM = New SqlCommand()
        '    With CM
        '        .Connection = CN
        '        .CommandType = CommandType.Text
        '        .CommandText = "select dbo.rm_artikli.* from dbo.rm_artikli where dbo.rm_artikli.artikl_sifra = '" & RTrim(_roba) & "'"
        '        DR = .ExecuteReader
        '    End With

        '    'Dim id As Integer = 0
        '    Dim id_pdv As Integer = 0
        '    Dim id_grupa As Integer = 0
        '    Dim id_jm As Integer = 0
        '    Do While DR.Read
        '        If Not IsDBNull(DR.Item("id_artikl")) Then lId = DR.Item("id_artikl")
        '        If Not IsDBNull(DR.Item("artikl_naziv")) Then naziv = DR.Item("artikl_naziv")
        '        If Not IsDBNull(DR.Item("id_grup_artikla")) Then id_grupa = DR.Item("id_grup_artikla")
        '        If Not IsDBNull(DR.Item("id_jm")) Then id_jm = DR.Item("id_jm")
        '        sifra = RTrim(_roba)
        '    Loop
        '    DR.Close()
        '    CM.Dispose()

        '    CM = New SqlCommand()
        '    With CM
        '        .Connection = CN
        '        .CommandType = CommandType.Text
        '        .CommandText = "select dbo.app_jm.* from dbo.app_jm where id_jm = " & id_jm
        '        DR = .ExecuteReader
        '    End With
        '    Do While DR.Read
        '        If Not IsDBNull(DR.Item("jm_oznaka")) Then c_JM = DR.Item("jm_oznaka")
        '        If Not IsDBNull(DR.Item("jm_br_decimala")) Then
        '            broj_decimala.SetValue(DR.Item("jm_br_decimala"), indeks)
        '        Else
        '            broj_decimala.SetValue(3, indeks)
        '        End If
        '    Loop
        '    DR.Close()
        '    CM.Dispose()

        '    CM = New SqlCommand()
        '    With CM
        '        .Connection = CN
        '        .CommandType = CommandType.Text
        '        .CommandText = "select dbo.rm_artikli_cene.* from dbo.rm_artikli_cene where id_artikl = " & lId & " and id_magacin = " & magacinID
        '        DR = .ExecuteReader
        '    End With

        '    Dim id_cene As Integer = 0
        '    Do While DR.Read
        '        id_cene = DR.Item("id_cena_robe")
        '        If Not IsDBNull(DR.Item("cena_nab_zadnja")) Then c_cena_nab = DR.Item("cena_nab_zadnja")
        '        If Not IsDBNull(DR.Item("cena_vp1")) Then c_cena_vp = DR.Item("cena_vp1")
        '        'If Not IsDBNull(DR.Item("pdv")) Then c_pdv = DR.Item("pdv")
        '        If Not IsDBNull(DR.Item("rabat")) Then c_rabat = DR.Item("rabat")
        '        'If Not IsDBNull(DR.Item("marza")) Then c_marza = DR.Item("marza")
        '        'If Not IsDBNull(DR.Item("cena_mp")) Then c_cena_mp = DR.Item("cena_mp")
        '    Loop
        '    DR.Close()
        '    CM.Dispose()

        '    'If id_cene = 0 Then
        '    'MsgBox("Traženom artiklu u ovom magacinu do sada nije zadata cena.", MsgBoxStyle.OkOnly)
        '    CM = New SqlCommand()
        '    With CM
        '        .Connection = CN
        '        .CommandType = CommandType.Text
        '        .CommandText = "select dbo.app_artikl_grupa.* from dbo.app_artikl_grupa where id_grup_artikla = " & id_grupa '& " and id_magacin = " & magacinID
        '        DR = .ExecuteReader
        '    End With
        '    Do While DR.Read
        '        If Not IsDBNull(DR.Item("gr_artikla_skraceno")) Then c_Grupa = RTrim(DR.Item("gr_artikla_skraceno"))
        '        If Not IsDBNull(DR.Item("gr_artikla_pdv")) Then c_pdv = DR.Item("gr_artikla_pdv")
        '        If Not IsDBNull(DR.Item("gr_artikla_marza")) Then c_marza = DR.Item("gr_artikla_marza")
        '    Loop
        '    DR.Close()
        '    CM.Dispose()
        '    'End If

        'End If

        'CN.Close()
    End Sub

    Private Sub lager()
        'Dim CN As SqlConnection = New SqlConnection(CNNString)
        'Dim CM As New SqlCommand
        'Dim DR As SqlDataReader

        'lSifra = ""
        'lNaziv = ""
        'lKol = 0
        'lCena = 0

        'CN.Open()
        'If CN.State = ConnectionState.Open Then
        '    CM = New SqlCommand()
        '    With CM
        '        .Connection = CN
        '        .CommandType = CommandType.Text
        '        .CommandText = "select * from dbo.rm_dnevni_promet_stavka where dbo.rm_dnevni_promet_stavka.id_artikl = " & lId '& " and dbo.rm_dnevni_promet_stavka.dp_zakljucen = 0"
        '        DR = .ExecuteReader
        '    End With

        '    Do While DR.Read
        '        If Not IsDBNull(DR.Item("dp_art_stanje")) Then lKol = DR.Item("dp_art_stanje")
        '        If Not IsDBNull(DR.Item("dp_art_cena")) Then lCena = DR.Item("dp_art_cena")
        '    Loop
        '    DR.Close()
        '    CM.Dispose()

        '    CM = New SqlCommand()
        '    With CM
        '        .Connection = CN
        '        .CommandType = CommandType.Text
        '        .CommandText = "select * from dbo.rm_artikli where dbo.rm_artikli.id_artikl = " & lId
        '        DR = .ExecuteReader
        '    End With
        '    Do While DR.Read
        '        If Not IsDBNull(DR.Item("artikl_sifra")) Then lSifra = DR.Item("artikl_sifra")
        '        If Not IsDBNull(DR.Item("artikl_naziv")) Then lNaziv = DR.Item("artikl_naziv")
        '    Loop
        '    DR.Close()
        '    CM.Dispose()

        'End If
        'CN.Close()

        'labLager.Text = RTrim(lSifra) & " - " & lNaziv & " - kol: " & lKol & " - cena: " & lCena

    End Sub

    Private Sub zatvori_formu()
        'If _unesen Then
        '    panHeader.Enabled = False
        '    Panel1.Enabled = False
        '    cmbMagacin.Enabled = False

        '    dgStavke.AllowUserToAddRows = False
        '    dgStavke.Enabled = False
        '    lvLista.Enabled = False

        '    txtIznosCena.Enabled = False
        '    txtIznosPdv.Enabled = False
        '    txtIznosRabat.Enabled = False
        '    txtIznosZanaplatu.Enabled = False
        '    txtOsnovica.Enabled = False

        '    btnSnimi.Enabled = False
        '    btnZakljuci.Enabled = False
        'End If
    End Sub

    Private Sub popuni_stavke()

        'With dgStavke
        '    Dim i As Integer = 0

        '    _citam_stavke = True
        '    For i = 0 To _kalkulacija_broj_stavki - 1
        '        .Rows.Add(1)
        '        .Rows(i).Cells(0).Value = i + 1
        '        .Rows(i).Cells(1).Value = _artikli(i, 0)
        '        .Rows(i).Cells(3).Value = CSng(_artikli(i, 1))
        '        .Rows(i).Cells(4).Value = CSng(_artikli(i, 2))
        '        .Rows(i).Cells(5).Value = CSng(_artikli(i, 3))
        '        .Rows(i).Cells(10).Value = CInt(_artikli(i, 4))
        '    Next
        'End With
        '_citam_stavke = False
    End Sub

#Region "Troskovi"

    'Private Sub chkProcenat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProcenat.CheckedChanged
    '    'Select Case chkProcenat.CheckState
    '    '    Case CheckState.Checked
    '    '        chkIznos.Checked = False
    '    '        txtZTIznos.Enabled = False
    '    '    Case CheckState.Unchecked
    '    '        chkIznos.Checked = True
    '    '        txtZTIznos.Enabled = True
    '    '        txtZTIznos.Text = 0
    '    '        txtProporcija.Text = 0
    '    'End Select
    'End Sub

    'Private Sub chkIznos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIznos.CheckedChanged
    '    Select Case chkIznos.CheckState
    '        Case CheckState.Checked
    '            chkProcenat.Checked = False
    '            txtZTProcenat.Enabled = False
    '        Case CheckState.Unchecked
    '            chkProcenat.Checked = True
    '            txtZTProcenat.Enabled = True
    '            txtZTProcenat.Text = 0
    '    End Select
    'End Sub

    'Private Sub chkZT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkZT.CheckedChanged
    '    Select Case chkZT.CheckState
    '        Case CheckState.Checked
    '            tableZT.Enabled = True
    '            chkProcenat.Checked = True
    '        Case CheckState.Unchecked
    '            tableZT.Enabled = False
    '    End Select
    'End Sub

    'Private Sub raspodeli_troskove()
    '    'Dim i As Integer

    '    'If chkIznos.CheckState = CheckState.Checked Then
    '    '    If txtZTIznos.Text <> "" Then
    '    '        If jeste_broj(txtZTIznos.Text) Then
    '    '            Dim suma As Single = 0
    '    '            With dgStavke
    '    '                For i = 0 To .RowCount - 2
    '    '                    Dim kol As Single = .Rows(i).Cells(3).Value
    '    '                    Dim cena As Single = .Rows(i).Cells(4).Value
    '    '                    Dim rabat As Integer = .Rows(i).Cells(5).Value
    '    '                    suma += kol * (cena * (1 - (rabat / 100)))
    '    '                Next

    '    '                If suma > 0 Then
    '    '                    txtProporcija.Text = CStr(CSng(txtZTIznos.Text) / suma * 100) & "%"
    '    '                Else
    '    '                    txtProporcija.Text = CSng(txtZTIznos.Text)
    '    '                End If

    '    '                For i = 0 To .RowCount - 2
    '    '                    If suma > 0 Then
    '    '                        ztroskovi_stavka = .Rows(i).Cells(4).Value * CSng(txtZTIznos.Text) / suma
    '    '                        .Rows(i).Cells(6).Value = .Rows(i).Cells(4).Value * CSng(txtZTIznos.Text) / suma
    '    '                    Else
    '    '                        ztroskovi_stavka = CSng(txtZTIznos.Text)
    '    '                        .Rows(i).Cells(6).Value = CSng(txtZTIznos.Text)
    '    '                    End If
    '    '                Next
    '    '            End With
    '    '        Else
    '    '            MsgBox("Uneli ste slovni karakter ili neki drugi znak." & vbLf & "Molimo Vas ispravite gresku", MsgBoxStyle.OkOnly)
    '    '        End If
    '    '    Else
    '    '        ztroskovi_stavka = 0
    '    '        dgStavke.Rows(i).Cells(6).Value = 0
    '    '    End If

    '    'Else 'na procenat
    '    '    If chkProcenat.CheckState = CheckState.Checked Then
    '    '        If txtZTProcenat.Text <> "" Then
    '    '            If jeste_broj(txtZTProcenat.Text) Then
    '    '                Dim suma As Single = 0
    '    '                With dgStavke
    '    '                    For i = 0 To .RowCount - 2
    '    '                        Dim kol As Single = .Rows(i).Cells(3).Value
    '    '                        Dim cena As Single = .Rows(i).Cells(4).Value
    '    '                        Dim rabat As Integer = .Rows(i).Cells(5).Value
    '    '                        suma += kol * (cena * (1 - (rabat / 100)))
    '    '                    Next

    '    '                    If suma > 0 Then
    '    '                        txtUkupnoPrc.Text = suma * CSng(txtZTProcenat.Text) / 100
    '    '                    Else
    '    '                        txtUkupnoPrc.Text = 0
    '    '                    End If

    '    '                    For i = 0 To .RowCount - 2
    '    '                        If suma > 0 Then
    '    '                            ztroskovi_stavka = .Rows(i).Cells(4).Value * CSng(txtZTProcenat.Text) / 100
    '    '                            .Rows(i).Cells(6).Value = .Rows(i).Cells(4).Value * CSng(txtZTProcenat.Text) / 100
    '    '                        Else
    '    '                            ztroskovi_stavka = 0
    '    '                            .Rows(i).Cells(6).Value = 0
    '    '                        End If
    '    '                    Next
    '    '                End With
    '    '            Else
    '    '                MsgBox("Uneli ste slovni karakter ili neki drugi znak." & vbLf & "Molimo Vas ispravite gresku", MsgBoxStyle.OkOnly)
    '    '            End If
    '    '        Else
    '    '            ztroskovi_stavka = 0
    '    '            dgStavke.Rows(i).Cells(6).Value = 0
    '    '        End If
    '    '    End If
    '    'End If
    'End Sub

    'Private Sub txtZTIznos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZTIznos.TextChanged
    '    raspodeli_troskove()
    'End Sub

    'Private Sub txtZTProcenat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZTProcenat.TextChanged
    '    raspodeli_troskove()
    'End Sub
#End Region

#Region "Snimi"

    Private Sub btnSnimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSnimi.Click
        snimi_head()
        snimi_pdv()
        snimi_stavku()
        snimi_cene()

        unesi_dnevni_promet_head(Today.Date, Now, _id_magacin, 0, Partner_id(cmbPartneri.Text), _
                        _dokument.dokumenta_id, mRob_Dokument.dokumenta_id, txtBroj.Text, txtSvega.Text, _
                        0, 1, 0, vrsta_promene.unos)

        _id_dnevni_promet = Nadji_id(Imena.tabele.rm_dnevni_promet_head.ToString)

        Dim i As Integer
        For i = 0 To dgStavke.Rows.Count - 2
            selektuj_artikl(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)
            unesi_dnevni_promet_stavka(_id_dnevni_promet, _id_magacin, _id_artikl, dgStavke.Rows(i).Cells(5).Value, 0, _
                    CSng(dgStavke.Rows(i).Cells(9).Value), dgStavke.Rows(i).Cells(12).Value, True, False)
        Next

        pocetak()
    End Sub

    Private Sub snimi_head()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim ztros As Single = 0

        ''Dim DR As SqlDataReader
        'If chkZT.CheckState = CheckState.Checked Then
        '    If chkIznos.CheckState = CheckState.Checked Then
        '        ztros = CSng(txtZTIznos.Text)
        '    Else
        '        If chkProcenat.CheckState = CheckState.Checked Then
        '            ztros = CSng(txtUkupnoPrc.Text)
        '        Else
        '            ztros = 0
        '        End If
        '    End If
        'Else
        '    ztros = 0
        'End If

        selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = mRob_Dokument.KonamdTekst & "_head_add"  '"rm_kalkulacija_head_add"
                '.Parameters.AddWithValue("@kalk_broj", txtBroj.Text)
                '.Parameters.AddWithValue("@id_magacina", _id_magacin)
                '.Parameters.AddWithValue("@id_dobavljac", Partner(cmbPartneri.Text))
                '.Parameters.AddWithValue("@kalk_datum_fakture", dateFaktura.Value.Date)
                '.Parameters.AddWithValue("@kalk_datum", dateDokument.Value.Date)
                '.Parameters.AddWithValue("@kalk_opis", txtFaktura.Text)
                '.Parameters.AddWithValue("@kalk_ukupno", CSng(txtUkupno.Text))
                '.Parameters.AddWithValue("@kalk_ztroskovi", ztros)
                '.Parameters.AddWithValue("@kalk_rabat", CSng(txtRabat.Text))
                '.Parameters.AddWithValue("@kalk_razlika_uceni", CSng(txtOsnovica.Text) - CSng(txtUkupno.Text) + CSng(txtRabat.Text))
                '.Parameters.AddWithValue("@kalk_pdv_osnovica", CSng(txtOsnovica.Text))
                '.Parameters.AddWithValue("@kalk_pdv", CSng(txtIznosPdv.Text))
                '.Parameters.AddWithValue("@kalk_svega", CSng(txtSvega.Text))
                '.Parameters.AddWithValue("@kalk_zakljucena", 0)
                '.Parameters.AddWithValue("@id_vrsta_dokumenta", mRob_Dokument.dokumenta_id) ' ID_vrsta_dokumenta)
                .Parameters.AddWithValue(0, txtBroj.Text)
                .Parameters.AddWithValue(1, _id_magacin)
                .Parameters.AddWithValue(2, Partner(cmbPartneri.Text))
                .Parameters.AddWithValue(3, dateFaktura.Value.Date)
                .Parameters.AddWithValue(4, dateDokument.Value.Date)
                .Parameters.AddWithValue(5, txtFaktura.Text)
                .Parameters.AddWithValue(6, CSng(txtUkupno.Text))
                .Parameters.AddWithValue(7, ztros)
                .Parameters.AddWithValue(8, CSng(txtRabat.Text))
                .Parameters.AddWithValue(9, CSng(txtOsnovica.Text) - CSng(txtUkupno.Text) + CSng(txtRabat.Text))
                .Parameters.AddWithValue(10, CSng(txtOsnovica.Text))
                .Parameters.AddWithValue(11, CSng(txtIznosPdv.Text))
                .Parameters.AddWithValue(12, CSng(txtSvega.Text))
                .Parameters.AddWithValue(13, 0)
                .Parameters.AddWithValue(14, mRob_Dokument.dokumenta_id) ' ID_vrsta_dokumenta)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
    End Sub

    Private Sub snimi_pdv()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim _porezi() As Single
        Dim i As Integer = 0

        CN.Open()
        CM = New SqlCommand()

        _porezi = New Single() {}

        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.app_pdv.* from dbo.app_pdv"
                .ExecuteScalar()
                DR = .ExecuteReader
            End With

            _broj_stavki = 0
            Do While DR.Read
                _broj_stavki += 1
            Loop
            DR.Close()

            ReDim _porezi(_broj_stavki * 3)

            DR = CM.ExecuteReader
            Do While DR.Read
                If Not IsDBNull(DR.Item("pdv_stopa")) Then _porezi.SetValue(CSng(DR.Item("pdv_stopa")), i * 3)
                _porezi.SetValue(saberi_osnovice(DR.Item("pdv_stopa")), (i * 3) + 1)
                _porezi.SetValue(saberi_pdv(DR.Item("pdv_stopa")), (i * 3) + 2)
                i += 1
            Loop
            DR.Close()
        End If
        CM.Dispose()

        _id_dokumenta = Nadji_id(mRob_Dokument.tabela.ToString)

        For i = 0 To (_porezi.Length / 3) - 1
            If _porezi((i * 3) + 1) <> 0 Then
                CM = New SqlCommand()
                If CN.State = ConnectionState.Open Then
                    With CM
                        .Connection = CN
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = mRob_Dokument.KonamdTekst & "_pdv_add"
                        '.Parameters.AddWithValue("@id_kalkulacija", _id_kalkulacija)
                        '.Parameters.AddWithValue("@pdv", _porezi(i * 3))
                        '.Parameters.AddWithValue("@osnovica", _porezi((i * 3) + 1))
                        '.Parameters.AddWithValue("@iznos", _porezi((i * 3) + 2))
                        .Parameters.AddWithValue(0, _id_dokumenta)
                        .Parameters.AddWithValue(1, _porezi(i * 3))
                        .Parameters.AddWithValue(2, _porezi((i * 3) + 1))
                        .Parameters.AddWithValue(3, _porezi((i * 3) + 2))
                        .ExecuteScalar()
                    End With
                End If
                CM.Dispose()
            End If
        Next
        CN.Close()
    End Sub

    Private Function saberi_pdv(ByVal _stopa) As Single
        Dim i As Integer

        saberi_pdv = 0
        For i = 0 To dgStavke.Rows.Count - 2
            If dgStavke.Rows(i).Cells(12).Value = _stopa Then saberi_pdv += dgStavke.Rows(i).Cells(14).Value 'dgStavke.Rows(i).Cells(5).Value * dgStavke.Rows(i).Cells(13).Value
        Next
    End Function

    Private Function saberi_osnovice(ByVal _stopa) As Single
        Dim i As Integer

        saberi_osnovice = 0
        For i = 0 To dgStavke.Rows.Count - 2
            If dgStavke.Rows(i).Cells(12).Value = _stopa Then saberi_osnovice += dgStavke.Rows(i).Cells(13).Value / (1 + (dgStavke.Rows(i).Cells(12).Value / 100))
        Next
    End Function

    Private Sub snimi_stavku()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim i As Integer

        _id_dokumenta = Nadji_id(mRob_Dokument.tabela.ToString)

        For i = 0 To dgStavke.Rows.Count - 2
            CN.Open()
            CM = New SqlCommand()
            If CN.State = ConnectionState.Open Then
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = mRob_Dokument.KonamdTekst & "_stavka_add"
                    '.Parameters.AddWithValue("@id_kalkulacija", _id_kalkulacija) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                    '.Parameters.AddWithValue("@rb", dgStavke.Rows(i).Cells(0).Value)
                    'selektuj_artikl(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)
                    '.Parameters.AddWithValue("@id_artikl", _id_artikl)
                    '.Parameters.AddWithValue("@roba_sifra", dgStavke.Rows(i).Cells(1).Value)
                    '.Parameters.AddWithValue("@roba", dgStavke.Rows(i).Cells(2).Value)
                    '.Parameters.AddWithValue("@kolicina", dgStavke.Rows(i).Cells(5).Value)
                    '.Parameters.AddWithValue("@nab_cena", CSng(dgStavke.Rows(i).Cells(6).Value))
                    '.Parameters.AddWithValue("@rabat", CSng(dgStavke.Rows(i).Cells(7).Value))
                    '.Parameters.AddWithValue("@zav_troskovi", CSng(dgStavke.Rows(i).Cells(8).Value))
                    '.Parameters.AddWithValue("@cena_kostanja", CSng(dgStavke.Rows(i).Cells(9).Value))
                    '.Parameters.AddWithValue("@nab_vred", CSng(dgStavke.Rows(i).Cells(10).Value))
                    '.Parameters.AddWithValue("@marza", CSng(dgStavke.Rows(i).Cells(11).Value))
                    '.Parameters.AddWithValue("@pdv", dgStavke.Rows(i).Cells(12).Value)
                    '.Parameters.AddWithValue("@prod_cena", CSng(dgStavke.Rows(i).Cells(13).Value))
                    '.Parameters.AddWithValue("@pdv_iznos", CSng(dgStavke.Rows(i).Cells(14).Value))
                    '.Parameters.AddWithValue("@prod_vred", CSng(dgStavke.Rows(i).Cells(15).Value))
                    .Parameters.AddWithValue(0, _id_dokumenta) ' Nadji_id(Imena.tabele.rm_predracun_head.ToString))
                    .Parameters.AddWithValue(1, dgStavke.Rows(i).Cells(0).Value)
                    selektuj_artikl(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)
                    .Parameters.AddWithValue(2, _id_artikl)
                    .Parameters.AddWithValue(3, dgStavke.Rows(i).Cells(1).Value)
                    .Parameters.AddWithValue(4, dgStavke.Rows(i).Cells(2).Value)
                    .Parameters.AddWithValue(5, dgStavke.Rows(i).Cells(5).Value)
                    .Parameters.AddWithValue(6, CSng(dgStavke.Rows(i).Cells(6).Value))
                    .Parameters.AddWithValue(7, CSng(dgStavke.Rows(i).Cells(7).Value))
                    .Parameters.AddWithValue(8, CSng(dgStavke.Rows(i).Cells(8).Value))
                    .Parameters.AddWithValue(9, CSng(dgStavke.Rows(i).Cells(9).Value))
                    .Parameters.AddWithValue(10, CSng(dgStavke.Rows(i).Cells(10).Value))
                    .Parameters.AddWithValue(11, CSng(dgStavke.Rows(i).Cells(11).Value))
                    .Parameters.AddWithValue(12, dgStavke.Rows(i).Cells(12).Value)
                    .Parameters.AddWithValue(13, CSng(dgStavke.Rows(i).Cells(13).Value))
                    .Parameters.AddWithValue(14, CSng(dgStavke.Rows(i).Cells(14).Value))
                    .Parameters.AddWithValue(15, CSng(dgStavke.Rows(i).Cells(15).Value))
                    .ExecuteScalar()
                End With
            End If
            CM.Dispose()
            CN.Close()
        Next
    End Sub

    Private Sub snimi_cene()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader
        Dim i As Integer

        For i = 0 To dgStavke.Rows.Count - 2
            CN.Open()

            selektuj_artikl(dgStavke.Rows(i).Cells(1).Value, Selekcija.po_sifri)

            CM = New SqlCommand()
            With CM
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = "select dbo.rm_artikli_cene.* from dbo.rm_artikli_cene where id_artikl = " & _id_artikl & " and id_magacin = " & magacinID
                DR = .ExecuteReader
            End With
            _id_artikl_cena = 0
            Do While DR.Read
                _id_artikl_cena = DR.Item("id_cena_robe")
            Loop
            DR.Close()
            CM.Dispose()

            If CN.State = ConnectionState.Open Then
                CM = New SqlCommand()
                With CM
                    .Connection = CN
                    .CommandType = CommandType.StoredProcedure
                    Select Case _id_artikl_cena
                        Case Is <> 0
                            .CommandText = "rm_artikli_cene_update"
                            .Parameters.AddWithValue("@id_cena_robe", _id_artikl_cena)
                        Case Is = 0
                            .CommandText = "rm_artikli_cene_add"
                            .Parameters.AddWithValue("@id_artikl", _id_artikl)
                            'selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)
                            .Parameters.AddWithValue("@id_magacin", magacinID)
                    End Select
                    .Parameters.AddWithValue("@cena_nab_zadnja", dgStavke.Rows(i).Cells(6).Value)
                    Dim a As Single = dgStavke.Rows(i).Cells(6).Value 'dgStavke.Rows(i).Cells(13).Value / (1 + (dgStavke.Rows(i).Cells(12).Value / 100))
                    .Parameters.AddWithValue("@cena_vp1", dgStavke.Rows(i).Cells(6).Value) ' dgStavke.Rows(i).Cells(13).Value / (1 + (dgStavke.Rows(i).Cells(12).Value / 100)))
                    .Parameters.AddWithValue("@cena_vp2", 0)
                    .Parameters.AddWithValue("@cena_vp3", 0)
                    Dim nab As Single = dgStavke.Rows(i).Cells(6).Value
                    Dim mar As Single = dgStavke.Rows(i).Cells(11).Value
                    Dim por As Single = dgStavke.Rows(i).Cells(12).Value
                    Dim b As Single = nab * (1 + (mar / 100)) * (1 + (por / 100))
                    .Parameters.AddWithValue("@cena_mp", nab * (1 + (mar / 100)) * (1 + (por / 100)))
                    .Parameters.AddWithValue("@pdv", CSng(dgStavke.Rows(i).Cells(12).Value))
                    .Parameters.AddWithValue("@rabat", CSng(dgStavke.Rows(i).Cells(8).Value))
                    .Parameters.AddWithValue("@marza", CSng(dgStavke.Rows(i).Cells(11).Value))
                    .ExecuteScalar()
                End With
                CM.Dispose()
            End If
            CN.Close()
        Next
    End Sub

#End Region

#Region "Zakljuci"
    'Private Sub btnZakljuci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZakljuci.Click
    '    _id_oj = 0
    '    'selektuj_partnera(cmbPartneri.Text, Selekcija.po_nazivu)

    '    'prebaci_u_magacin_promene(_id_magacin, 4, txtBroj.Text)
    '    'prebaci_u_magacin_promene_stavka(_id_dnevni_promet)
    '    'zakljuci_dokument()
    '    'labProknjizen.Visible = True
    '    'btnZakljuci.Visible = False
    'End Sub

    Private Sub zakljuci_dokument()
        Dim CN As SqlConnection = New SqlConnection(CNNString)
        Dim CM As New SqlCommand

        '_id_dokumenta = Nadji_id(Imena.tabele.rm_kalkulacija_head.ToString)

        CN.Open()
        CM = New SqlCommand()
        If CN.State = ConnectionState.Open Then
            With CM
                .Connection = CN
                .CommandType = CommandType.StoredProcedure
                .CommandText = mRob_Dokument.KonamdTekst & "_zakljuci"
                '.Parameters.AddWithValue("@id_kalkulacija", _id_kalkulacija)
                '.Parameters.AddWithValue("@kalk_zakljucena", 1)
                .Parameters.AddWithValue(0, _id_dokumenta)
                .Parameters.AddWithValue(1, 1)
                .ExecuteScalar()
            End With
        End If
        CM.Dispose()
        CN.Close()
        _unesen = True
        zatvori_formu()
    End Sub
#End Region

    Private Sub cmbMagacin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMagacin.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbMagacin.Text <> "" Then
                selektuj_magacin(RTrim(cmbMagacin.Text), Selekcija.po_nazivu)
            End If
            dateDokument.Select()
        End If
    End Sub

    Private Sub cmbMagacin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMagacin.SelectedIndexChanged
        If Not _pocetak Then
            If cmbMagacin.Text <> "" Then
                _izabran_magacin = True
                selektuj_magacin(cmbMagacin.Text, Selekcija.po_nazivu)
                magacinID = _id_magacin
                magacinSifra = _magacin_sifra
            End If
        End If
        kontrole()
    End Sub

    Private Sub dateKalkulacija_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dateDokument.KeyPress
        cmbPartneri.Select()
    End Sub

    Private Sub cmbPartneri_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPartneri.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbPartneri.Text <> "" Then
                selektuj_partnera(RTrim(cmbPartneri.Text), Selekcija.po_nazivu)
            End If
            txtFaktura.Select()
        End If
    End Sub

    Private Sub txtFaktura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFaktura.KeyPress
        If e.KeyChar = Chr(13) Then
            dateFaktura.Select()
        End If
    End Sub

    Private Sub dateFaktura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dateFaktura.KeyPress
        If e.KeyChar = Chr(13) Then
            txtSifra.Select()
        End If
    End Sub

    Private Sub dateFaktura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateFaktura.ValueChanged
        txtSifra.Select()
    End Sub

    Private Sub txtSifra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSifra.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtSifra.Text = "" Then
                txtNaziv.Select()
            End If
            If txtSifra.Text <> "" Then
                selektuj_artikl(RTrim(txtSifra.Text), Selekcija.po_sifri)
            End If
        End If
    End Sub

    Private Sub txtNaziv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNaziv.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtSifra.Text = "" Then
                Dim mForm As New frmArtikl_pick
                'mForm.MdiParent = mdiMain
                mForm.Show()
            End If
            If txtNaziv.Text <> "" Then
                selektuj_artikl(RTrim(txtSifra.Text), Selekcija.po_nazivu)
            End If
        End If
        txtKol.Select()
    End Sub

    Private Sub txtKol_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKol.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtKol.Text <> "" Then
                'txtKol.Text = Format(CSng(txtKol.Text), "#,##0.00")
                txtNCena.Select()
            End If
        End If
    End Sub

    Private Sub txtNCena_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNCena.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtNCena.Text <> "" Then
                txtNCena.Text = Format(CSng(txtNCena.Text), "#,##0.00")
                txtNVred.Text = Format(CSng(txtNCena.Text) * CSng(txtKol.Text), "#,##0.00")
                btnUnesi.Select()
            End If
        End If
    End Sub


End Class
