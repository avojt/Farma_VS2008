<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRadniNalogEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRadniNalogEdit))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tlbSnimi = New System.Windows.Forms.ToolStripButton
        Me.tlbStanje = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tlbEnd = New System.Windows.Forms.ToolStripButton
        Me.Label16 = New System.Windows.Forms.Label
        Me.dgStavke = New System.Windows.Forms.DataGridView
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtOpis = New System.Windows.Forms.TextBox
        Me.panVrstaPosla = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label15 = New System.Windows.Forms.Label
        Me.chkPreventiva = New System.Windows.Forms.CheckBox
        Me.chkMontaza = New System.Windows.Forms.CheckBox
        Me.chkIspitivanje = New System.Windows.Forms.CheckBox
        Me.chkPopravka = New System.Windows.Forms.CheckBox
        Me.chkServisiranje = New System.Windows.Forms.CheckBox
        Me.panOdrediste = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtKontakt = New System.Windows.Forms.TextBox
        Me.txtTelefon = New System.Windows.Forms.TextBox
        Me.txtAdresa = New System.Windows.Forms.TextBox
        Me.txtObjekat = New System.Windows.Forms.TextBox
        Me.txtMesto = New System.Windows.Forms.TextBox
        Me.cmbPartneri = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtVremePovratka = New System.Windows.Forms.TextBox
        Me.txtVremePolaska = New System.Windows.Forms.TextBox
        Me.txtKm = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.datePolazak = New System.Windows.Forms.DateTimePicker
        Me.txtRegistracija = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtVozilo = New System.Windows.Forms.TextBox
        Me.txtSifra = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.datePovratak = New System.Windows.Forms.DateTimePicker
        Me.DataSet1 = New Farma.DataSet1
        Me.RmartikliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rm_artikliTableAdapter = New Farma.DataSet1TableAdapters.rm_artikliTableAdapter
        Me.cRb = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cMaterijal = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.cKol = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgStavke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panVrstaPosla.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.panOdrediste.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RmartikliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbSnimi, Me.tlbStanje, Me.ToolStripSeparator1, Me.tlbEnd})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(671, 25)
        Me.ToolStrip1.TabIndex = 73
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tlbSnimi
        '
        Me.tlbSnimi.Image = Global.Farma.My.Resources.Resources.LaST__Cobalt__Floppy
        Me.tlbSnimi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbSnimi.Name = "tlbSnimi"
        Me.tlbSnimi.Size = New System.Drawing.Size(51, 22)
        Me.tlbSnimi.Text = "Snimi"
        '
        'tlbStanje
        '
        Me.tlbStanje.Image = Global.Farma.My.Resources.Resources.LaST__Cobalt__Find
        Me.tlbStanje.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbStanje.Name = "tlbStanje"
        Me.tlbStanje.Size = New System.Drawing.Size(94, 22)
        Me.tlbStanje.Text = "Proveri stanje"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tlbEnd
        '
        Me.tlbEnd.Image = Global.Farma.My.Resources.Resources.logoff
        Me.tlbEnd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbEnd.Name = "tlbEnd"
        Me.tlbEnd.Size = New System.Drawing.Size(46, 22)
        Me.tlbEnd.Text = "Kraj"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label16.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label16.Location = New System.Drawing.Point(447, 120)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(210, 20)
        Me.Label16.TabIndex = 96
        Me.Label16.Text = "LISTA ISPORUKE"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgStavke
        '
        Me.dgStavke.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.dgStavke.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgStavke.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStavke.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cRb, Me.cMaterijal, Me.cKol})
        Me.dgStavke.Location = New System.Drawing.Point(448, 141)
        Me.dgStavke.Name = "dgStavke"
        Me.dgStavke.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgStavke.RowHeadersWidth = 25
        Me.dgStavke.Size = New System.Drawing.Size(210, 322)
        Me.dgStavke.TabIndex = 95
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label8.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(14, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(427, 18)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "OPIS"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOpis
        '
        Me.txtOpis.BackColor = System.Drawing.Color.GhostWhite
        Me.txtOpis.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtOpis.Location = New System.Drawing.Point(14, 362)
        Me.txtOpis.Multiline = True
        Me.txtOpis.Name = "txtOpis"
        Me.txtOpis.Size = New System.Drawing.Size(427, 100)
        Me.txtOpis.TabIndex = 93
        '
        'panVrstaPosla
        '
        Me.panVrstaPosla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panVrstaPosla.Controls.Add(Me.Panel3)
        Me.panVrstaPosla.Controls.Add(Me.chkPreventiva)
        Me.panVrstaPosla.Controls.Add(Me.chkMontaza)
        Me.panVrstaPosla.Controls.Add(Me.chkIspitivanje)
        Me.panVrstaPosla.Controls.Add(Me.chkPopravka)
        Me.panVrstaPosla.Controls.Add(Me.chkServisiranje)
        Me.panVrstaPosla.Location = New System.Drawing.Point(305, 121)
        Me.panVrstaPosla.Name = "panVrstaPosla"
        Me.panVrstaPosla.Size = New System.Drawing.Size(137, 214)
        Me.panVrstaPosla.TabIndex = 92
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(135, 22)
        Me.Panel3.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label15.Location = New System.Drawing.Point(9, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 15)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "VRSTA POSLA"
        '
        'chkPreventiva
        '
        Me.chkPreventiva.AutoSize = True
        Me.chkPreventiva.Location = New System.Drawing.Point(18, 163)
        Me.chkPreventiva.Name = "chkPreventiva"
        Me.chkPreventiva.Size = New System.Drawing.Size(94, 17)
        Me.chkPreventiva.TabIndex = 4
        Me.chkPreventiva.Text = "PREVENTIVA"
        Me.chkPreventiva.UseVisualStyleBackColor = True
        '
        'chkMontaza
        '
        Me.chkMontaza.AutoSize = True
        Me.chkMontaza.Location = New System.Drawing.Point(18, 55)
        Me.chkMontaza.Name = "chkMontaza"
        Me.chkMontaza.Size = New System.Drawing.Size(79, 17)
        Me.chkMontaza.TabIndex = 0
        Me.chkMontaza.Text = "MONTAŽA"
        Me.chkMontaza.UseVisualStyleBackColor = True
        '
        'chkIspitivanje
        '
        Me.chkIspitivanje.AutoSize = True
        Me.chkIspitivanje.Location = New System.Drawing.Point(18, 136)
        Me.chkIspitivanje.Name = "chkIspitivanje"
        Me.chkIspitivanje.Size = New System.Drawing.Size(90, 17)
        Me.chkIspitivanje.TabIndex = 3
        Me.chkIspitivanje.Text = "ISPITIVANJE"
        Me.chkIspitivanje.UseVisualStyleBackColor = True
        '
        'chkPopravka
        '
        Me.chkPopravka.AutoSize = True
        Me.chkPopravka.Location = New System.Drawing.Point(18, 82)
        Me.chkPopravka.Name = "chkPopravka"
        Me.chkPopravka.Size = New System.Drawing.Size(84, 17)
        Me.chkPopravka.TabIndex = 1
        Me.chkPopravka.Text = "POPRAVKA"
        Me.chkPopravka.UseVisualStyleBackColor = True
        '
        'chkServisiranje
        '
        Me.chkServisiranje.AutoSize = True
        Me.chkServisiranje.Location = New System.Drawing.Point(18, 109)
        Me.chkServisiranje.Name = "chkServisiranje"
        Me.chkServisiranje.Size = New System.Drawing.Size(103, 17)
        Me.chkServisiranje.TabIndex = 2
        Me.chkServisiranje.Text = "SERVISIRANJE"
        Me.chkServisiranje.UseVisualStyleBackColor = True
        '
        'panOdrediste
        '
        Me.panOdrediste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panOdrediste.Controls.Add(Me.Panel2)
        Me.panOdrediste.Controls.Add(Me.Label6)
        Me.panOdrediste.Controls.Add(Me.Label5)
        Me.panOdrediste.Controls.Add(Me.Label4)
        Me.panOdrediste.Controls.Add(Me.Label3)
        Me.panOdrediste.Controls.Add(Me.Label2)
        Me.panOdrediste.Controls.Add(Me.Label1)
        Me.panOdrediste.Controls.Add(Me.txtKontakt)
        Me.panOdrediste.Controls.Add(Me.txtTelefon)
        Me.panOdrediste.Controls.Add(Me.txtAdresa)
        Me.panOdrediste.Controls.Add(Me.txtObjekat)
        Me.panOdrediste.Controls.Add(Me.txtMesto)
        Me.panOdrediste.Controls.Add(Me.cmbPartneri)
        Me.panOdrediste.Location = New System.Drawing.Point(13, 120)
        Me.panOdrediste.Name = "panOdrediste"
        Me.panOdrediste.Size = New System.Drawing.Size(286, 214)
        Me.panOdrediste.TabIndex = 91
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(284, 22)
        Me.Panel2.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label14.Location = New System.Drawing.Point(9, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 15)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "ODREDIŠTE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Kontakt osoba"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Telefon"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Adresa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Objekat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Mesto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Firma"
        '
        'txtKontakt
        '
        Me.txtKontakt.BackColor = System.Drawing.Color.GhostWhite
        Me.txtKontakt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtKontakt.Location = New System.Drawing.Point(94, 175)
        Me.txtKontakt.Name = "txtKontakt"
        Me.txtKontakt.Size = New System.Drawing.Size(173, 20)
        Me.txtKontakt.TabIndex = 5
        '
        'txtTelefon
        '
        Me.txtTelefon.BackColor = System.Drawing.Color.GhostWhite
        Me.txtTelefon.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTelefon.Location = New System.Drawing.Point(94, 148)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(173, 20)
        Me.txtTelefon.TabIndex = 4
        '
        'txtAdresa
        '
        Me.txtAdresa.BackColor = System.Drawing.Color.GhostWhite
        Me.txtAdresa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAdresa.Location = New System.Drawing.Point(94, 121)
        Me.txtAdresa.Name = "txtAdresa"
        Me.txtAdresa.Size = New System.Drawing.Size(173, 20)
        Me.txtAdresa.TabIndex = 3
        '
        'txtObjekat
        '
        Me.txtObjekat.BackColor = System.Drawing.Color.GhostWhite
        Me.txtObjekat.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObjekat.Location = New System.Drawing.Point(94, 94)
        Me.txtObjekat.Name = "txtObjekat"
        Me.txtObjekat.Size = New System.Drawing.Size(173, 20)
        Me.txtObjekat.TabIndex = 2
        '
        'txtMesto
        '
        Me.txtMesto.BackColor = System.Drawing.Color.GhostWhite
        Me.txtMesto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMesto.Location = New System.Drawing.Point(94, 67)
        Me.txtMesto.Name = "txtMesto"
        Me.txtMesto.Size = New System.Drawing.Size(173, 20)
        Me.txtMesto.TabIndex = 1
        '
        'cmbPartneri
        '
        Me.cmbPartneri.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbPartneri.FormattingEnabled = True
        Me.cmbPartneri.Location = New System.Drawing.Point(94, 39)
        Me.cmbPartneri.Name = "cmbPartneri"
        Me.cmbPartneri.Size = New System.Drawing.Size(173, 21)
        Me.cmbPartneri.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel1.Controls.Add(Me.txtVremePovratka)
        Me.Panel1.Controls.Add(Me.txtVremePolaska)
        Me.Panel1.Controls.Add(Me.txtKm)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.datePolazak)
        Me.Panel1.Controls.Add(Me.txtRegistracija)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtVozilo)
        Me.Panel1.Controls.Add(Me.txtSifra)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.datePovratak)
        Me.Panel1.Location = New System.Drawing.Point(13, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(644, 64)
        Me.Panel1.TabIndex = 90
        '
        'txtVremePovratka
        '
        Me.txtVremePovratka.BackColor = System.Drawing.Color.GhostWhite
        Me.txtVremePovratka.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtVremePovratka.Location = New System.Drawing.Point(270, 34)
        Me.txtVremePovratka.Name = "txtVremePovratka"
        Me.txtVremePovratka.Size = New System.Drawing.Size(76, 20)
        Me.txtVremePovratka.TabIndex = 86
        '
        'txtVremePolaska
        '
        Me.txtVremePolaska.BackColor = System.Drawing.Color.GhostWhite
        Me.txtVremePolaska.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtVremePolaska.Location = New System.Drawing.Point(270, 8)
        Me.txtVremePolaska.Name = "txtVremePolaska"
        Me.txtVremePolaska.Size = New System.Drawing.Size(76, 20)
        Me.txtVremePolaska.TabIndex = 85
        '
        'txtKm
        '
        Me.txtKm.BackColor = System.Drawing.Color.GhostWhite
        Me.txtKm.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtKm.Location = New System.Drawing.Point(575, 35)
        Me.txtKm.Name = "txtKm"
        Me.txtKm.Size = New System.Drawing.Size(56, 20)
        Me.txtKm.TabIndex = 84
        Me.txtKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(552, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 13)
        Me.Label13.TabIndex = 81
        Me.Label13.Text = "km"
        '
        'datePolazak
        '
        Me.datePolazak.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePolazak.Location = New System.Drawing.Point(175, 9)
        Me.datePolazak.Name = "datePolazak"
        Me.datePolazak.Size = New System.Drawing.Size(88, 20)
        Me.datePolazak.TabIndex = 77
        '
        'txtRegistracija
        '
        Me.txtRegistracija.BackColor = System.Drawing.Color.GhostWhite
        Me.txtRegistracija.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtRegistracija.Location = New System.Drawing.Point(426, 35)
        Me.txtRegistracija.Name = "txtRegistracija"
        Me.txtRegistracija.Size = New System.Drawing.Size(116, 20)
        Me.txtRegistracija.TabIndex = 83
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(129, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Polazak"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(377, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Reg.broj"
        '
        'txtVozilo
        '
        Me.txtVozilo.BackColor = System.Drawing.Color.GhostWhite
        Me.txtVozilo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtVozilo.Location = New System.Drawing.Point(426, 9)
        Me.txtVozilo.Name = "txtVozilo"
        Me.txtVozilo.Size = New System.Drawing.Size(205, 20)
        Me.txtVozilo.TabIndex = 82
        '
        'txtSifra
        '
        Me.txtSifra.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSifra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSifra.Location = New System.Drawing.Point(11, 25)
        Me.txtSifra.Name = "txtSifra"
        Me.txtSifra.Size = New System.Drawing.Size(79, 20)
        Me.txtSifra.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(389, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "Vozilo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Broj"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(124, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "Povratak"
        '
        'datePovratak
        '
        Me.datePovratak.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePovratak.Location = New System.Drawing.Point(175, 35)
        Me.datePovratak.Name = "datePovratak"
        Me.datePovratak.Size = New System.Drawing.Size(88, 20)
        Me.datePovratak.TabIndex = 78
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RmartikliBindingSource
        '
        Me.RmartikliBindingSource.DataMember = "rm_artikli"
        Me.RmartikliBindingSource.DataSource = Me.DataSet1
        '
        'Rm_artikliTableAdapter
        '
        Me.Rm_artikliTableAdapter.ClearBeforeFill = True
        '
        'cRb
        '
        Me.cRb.HeaderText = "Rb"
        Me.cRb.Name = "cRb"
        Me.cRb.Width = 30
        '
        'cMaterijal
        '
        Me.cMaterijal.DataSource = Me.RmartikliBindingSource
        Me.cMaterijal.DisplayMember = "sifra"
        Me.cMaterijal.HeaderText = "Materijal"
        Me.cMaterijal.Name = "cMaterijal"
        Me.cMaterijal.ValueMember = "sifra"
        Me.cMaterijal.Width = 110
        '
        'cKol
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cKol.DefaultCellStyle = DataGridViewCellStyle2
        Me.cKol.HeaderText = "Kol"
        Me.cKol.Name = "cKol"
        Me.cKol.Width = 40
        '
        'frmRadniNalogEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(671, 475)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.dgStavke)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtOpis)
        Me.Controls.Add(Me.panVrstaPosla)
        Me.Controls.Add(Me.panOdrediste)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRadniNalogEdit"
        Me.Text = "Radni Nalog - Edit"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgStavke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panVrstaPosla.ResumeLayout(False)
        Me.panVrstaPosla.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.panOdrediste.ResumeLayout(False)
        Me.panOdrediste.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RmartikliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbSnimi As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbStanje As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbEnd As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dgStavke As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtOpis As System.Windows.Forms.TextBox
    Friend WithEvents panVrstaPosla As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents chkPreventiva As System.Windows.Forms.CheckBox
    Friend WithEvents chkMontaza As System.Windows.Forms.CheckBox
    Friend WithEvents chkIspitivanje As System.Windows.Forms.CheckBox
    Friend WithEvents chkPopravka As System.Windows.Forms.CheckBox
    Friend WithEvents chkServisiranje As System.Windows.Forms.CheckBox
    Friend WithEvents panOdrediste As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKontakt As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefon As System.Windows.Forms.TextBox
    Friend WithEvents txtAdresa As System.Windows.Forms.TextBox
    Friend WithEvents txtObjekat As System.Windows.Forms.TextBox
    Friend WithEvents txtMesto As System.Windows.Forms.TextBox
    Friend WithEvents cmbPartneri As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtVremePovratka As System.Windows.Forms.TextBox
    Friend WithEvents txtVremePolaska As System.Windows.Forms.TextBox
    Friend WithEvents txtKm As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents datePolazak As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRegistracija As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtVozilo As System.Windows.Forms.TextBox
    Friend WithEvents txtSifra As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents datePovratak As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataSet1 As Farma.DataSet1
    Friend WithEvents RmartikliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rm_artikliTableAdapter As Farma.DataSet1TableAdapters.rm_artikliTableAdapter
    Friend WithEvents cRb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMaterijal As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cKol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
