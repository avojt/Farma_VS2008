<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartneriUnos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPartneriUnos))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tlbSnimi = New System.Windows.Forms.ToolStripButton
        Me.tlbEnd = New System.Windows.Forms.ToolStripButton
        Me.txtSifra = New System.Windows.Forms.TextBox
        Me.txtNaziv = New System.Windows.Forms.TextBox
        Me.txtAdresa = New System.Windows.Forms.TextBox
        Me.txtPib = New System.Windows.Forms.TextBox
        Me.txtMaticni = New System.Windows.Forms.TextBox
        Me.txtRegistarski = New System.Windows.Forms.TextBox
        Me.txtZR = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkProizvodjac = New System.Windows.Forms.CheckBox
        Me.chkDobavljac = New System.Windows.Forms.CheckBox
        Me.chkKupac = New System.Windows.Forms.CheckBox
        Me.btnTelefoni = New System.Windows.Forms.Button
        Me.dgTelefoni = New System.Windows.Forms.DataGridView
        Me.cTelefon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cVrsta = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.btnKontakti = New System.Windows.Forms.Button
        Me.dgKontakt = New System.Windows.Forms.DataGridView
        Me.dgTelKontakt = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.cmbMesto = New System.Windows.Forms.ComboBox
        Me.cmbOpstina = New System.Windows.Forms.ComboBox
        Me.cmbGrad = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cIme = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cPrezime = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cPozicija = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cRodjendan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cOstalo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgTelefoni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgKontakt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTelKontakt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbSnimi, Me.tlbEnd})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(784, 25)
        Me.ToolStrip1.TabIndex = 0
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
        'tlbEnd
        '
        Me.tlbEnd.Image = Global.Farma.My.Resources.Resources.logoff
        Me.tlbEnd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbEnd.Name = "tlbEnd"
        Me.tlbEnd.Size = New System.Drawing.Size(46, 22)
        Me.tlbEnd.Text = "Kraj"
        '
        'txtSifra
        '
        Me.txtSifra.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSifra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSifra.Location = New System.Drawing.Point(11, 25)
        Me.txtSifra.Name = "txtSifra"
        Me.txtSifra.Size = New System.Drawing.Size(100, 20)
        Me.txtSifra.TabIndex = 1
        '
        'txtNaziv
        '
        Me.txtNaziv.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNaziv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNaziv.Location = New System.Drawing.Point(117, 25)
        Me.txtNaziv.Name = "txtNaziv"
        Me.txtNaziv.Size = New System.Drawing.Size(277, 20)
        Me.txtNaziv.TabIndex = 2
        '
        'txtAdresa
        '
        Me.txtAdresa.BackColor = System.Drawing.Color.GhostWhite
        Me.txtAdresa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAdresa.Location = New System.Drawing.Point(10, 138)
        Me.txtAdresa.Name = "txtAdresa"
        Me.txtAdresa.Size = New System.Drawing.Size(200, 20)
        Me.txtAdresa.TabIndex = 3
        '
        'txtPib
        '
        Me.txtPib.BackColor = System.Drawing.Color.GhostWhite
        Me.txtPib.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPib.Location = New System.Drawing.Point(216, 138)
        Me.txtPib.Name = "txtPib"
        Me.txtPib.Size = New System.Drawing.Size(200, 20)
        Me.txtPib.TabIndex = 5
        '
        'txtMaticni
        '
        Me.txtMaticni.BackColor = System.Drawing.Color.GhostWhite
        Me.txtMaticni.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMaticni.Location = New System.Drawing.Point(216, 217)
        Me.txtMaticni.Name = "txtMaticni"
        Me.txtMaticni.Size = New System.Drawing.Size(200, 20)
        Me.txtMaticni.TabIndex = 6
        '
        'txtRegistarski
        '
        Me.txtRegistarski.BackColor = System.Drawing.Color.GhostWhite
        Me.txtRegistarski.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtRegistarski.Location = New System.Drawing.Point(216, 177)
        Me.txtRegistarski.Name = "txtRegistarski"
        Me.txtRegistarski.Size = New System.Drawing.Size(200, 20)
        Me.txtRegistarski.TabIndex = 7
        '
        'txtZR
        '
        Me.txtZR.BackColor = System.Drawing.Color.GhostWhite
        Me.txtZR.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtZR.Location = New System.Drawing.Point(216, 257)
        Me.txtZR.Name = "txtZR"
        Me.txtZR.Size = New System.Drawing.Size(200, 20)
        Me.txtZR.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Šifra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(117, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Naziv"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(10, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Adresa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(7, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Mesto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(213, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "PIB"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(213, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Matični broj"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(213, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Registarski broj"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(213, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Žiro račun"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel1.Controls.Add(Me.txtNaziv)
        Me.Panel1.Controls.Add(Me.txtSifra)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(404, 64)
        Me.Panel1.TabIndex = 19
        '
        'chkProizvodjac
        '
        Me.chkProizvodjac.AutoSize = True
        Me.chkProizvodjac.Location = New System.Drawing.Point(13, 294)
        Me.chkProizvodjac.Name = "chkProizvodjac"
        Me.chkProizvodjac.Size = New System.Drawing.Size(81, 17)
        Me.chkProizvodjac.TabIndex = 20
        Me.chkProizvodjac.Text = "Proizvodjač"
        Me.chkProizvodjac.UseVisualStyleBackColor = True
        '
        'chkDobavljac
        '
        Me.chkDobavljac.AutoSize = True
        Me.chkDobavljac.Location = New System.Drawing.Point(178, 294)
        Me.chkDobavljac.Name = "chkDobavljac"
        Me.chkDobavljac.Size = New System.Drawing.Size(74, 17)
        Me.chkDobavljac.TabIndex = 21
        Me.chkDobavljac.Text = "Dobavljač"
        Me.chkDobavljac.UseVisualStyleBackColor = True
        '
        'chkKupac
        '
        Me.chkKupac.AutoSize = True
        Me.chkKupac.Location = New System.Drawing.Point(362, 294)
        Me.chkKupac.Name = "chkKupac"
        Me.chkKupac.Size = New System.Drawing.Size(57, 17)
        Me.chkKupac.TabIndex = 22
        Me.chkKupac.Text = "Kupac"
        Me.chkKupac.UseVisualStyleBackColor = True
        '
        'btnTelefoni
        '
        Me.btnTelefoni.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTelefoni.Location = New System.Drawing.Point(766, 42)
        Me.btnTelefoni.Name = "btnTelefoni"
        Me.btnTelefoni.Size = New System.Drawing.Size(14, 30)
        Me.btnTelefoni.TabIndex = 23
        Me.btnTelefoni.Text = ">"
        Me.btnTelefoni.UseVisualStyleBackColor = True
        '
        'dgTelefoni
        '
        Me.dgTelefoni.BackgroundColor = System.Drawing.Color.Lavender
        Me.dgTelefoni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTelefoni.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cTelefon, Me.cVrsta})
        Me.dgTelefoni.Location = New System.Drawing.Point(434, 42)
        Me.dgTelefoni.Name = "dgTelefoni"
        Me.dgTelefoni.RowHeadersWidth = 28
        Me.dgTelefoni.Size = New System.Drawing.Size(325, 270)
        Me.dgTelefoni.TabIndex = 24
        '
        'cTelefon
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cTelefon.DefaultCellStyle = DataGridViewCellStyle1
        Me.cTelefon.HeaderText = "Telefon"
        Me.cTelefon.Name = "cTelefon"
        Me.cTelefon.Width = 150
        '
        'cVrsta
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cVrsta.DefaultCellStyle = DataGridViewCellStyle2
        Me.cVrsta.HeaderText = "Vrsta telefona"
        Me.cVrsta.Items.AddRange(New Object() {"Fiksni", "Faks", "Drugo..."})
        Me.cVrsta.Name = "cVrsta"
        Me.cVrsta.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cVrsta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cVrsta.Width = 150
        '
        'btnKontakti
        '
        Me.btnKontakti.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKontakti.Location = New System.Drawing.Point(766, 76)
        Me.btnKontakti.Name = "btnKontakti"
        Me.btnKontakti.Size = New System.Drawing.Size(14, 30)
        Me.btnKontakti.TabIndex = 25
        Me.btnKontakti.Text = ">"
        Me.btnKontakti.UseVisualStyleBackColor = True
        '
        'dgKontakt
        '
        Me.dgKontakt.BackgroundColor = System.Drawing.Color.Lavender
        Me.dgKontakt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgKontakt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cIme, Me.cPrezime, Me.cPozicija, Me.cRodjendan, Me.cOstalo})
        Me.dgKontakt.Location = New System.Drawing.Point(10, 330)
        Me.dgKontakt.Name = "dgKontakt"
        Me.dgKontakt.RowHeadersWidth = 28
        Me.dgKontakt.Size = New System.Drawing.Size(750, 145)
        Me.dgKontakt.TabIndex = 26
        '
        'dgTelKontakt
        '
        Me.dgTelKontakt.BackgroundColor = System.Drawing.Color.Lavender
        Me.dgTelKontakt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTelKontakt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewComboBoxColumn1})
        Me.dgTelKontakt.Location = New System.Drawing.Point(537, 145)
        Me.dgTelKontakt.Name = "dgTelKontakt"
        Me.dgTelKontakt.RowHeadersWidth = 28
        Me.dgTelKontakt.Size = New System.Drawing.Size(193, 130)
        Me.dgTelKontakt.TabIndex = 27
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle8.NullValue = " "
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn1.HeaderText = "Telefon"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewComboBoxColumn1
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle9.NullValue = " "
        Me.DataGridViewComboBoxColumn1.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewComboBoxColumn1.HeaderText = "Vrsta telefona"
        Me.DataGridViewComboBoxColumn1.Items.AddRange(New Object() {"Fiksni - poslovni", "Fiksni - privatni", "Mobilni - poslovni", "Mobilni - privatni", "Faks", "Drugo..."})
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn1.Width = 150
        '
        'cmbMesto
        '
        Me.cmbMesto.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbMesto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbMesto.FormattingEnabled = True
        Me.cmbMesto.Location = New System.Drawing.Point(10, 256)
        Me.cmbMesto.Name = "cmbMesto"
        Me.cmbMesto.Size = New System.Drawing.Size(200, 21)
        Me.cmbMesto.TabIndex = 28
        '
        'cmbOpstina
        '
        Me.cmbOpstina.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbOpstina.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbOpstina.FormattingEnabled = True
        Me.cmbOpstina.Location = New System.Drawing.Point(10, 216)
        Me.cmbOpstina.Name = "cmbOpstina"
        Me.cmbOpstina.Size = New System.Drawing.Size(200, 21)
        Me.cmbOpstina.TabIndex = 29
        '
        'cmbGrad
        '
        Me.cmbGrad.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbGrad.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbGrad.FormattingEnabled = True
        Me.cmbGrad.Location = New System.Drawing.Point(10, 176)
        Me.cmbGrad.Name = "cmbGrad"
        Me.cmbGrad.Size = New System.Drawing.Size(200, 21)
        Me.cmbGrad.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Grad"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 200)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Opština"
        '
        'cIme
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cIme.DefaultCellStyle = DataGridViewCellStyle3
        Me.cIme.HeaderText = "Ime"
        Me.cIme.Name = "cIme"
        Me.cIme.Width = 120
        '
        'cPrezime
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cPrezime.DefaultCellStyle = DataGridViewCellStyle4
        Me.cPrezime.HeaderText = "Prezime"
        Me.cPrezime.Name = "cPrezime"
        Me.cPrezime.Width = 150
        '
        'cPozicija
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cPozicija.DefaultCellStyle = DataGridViewCellStyle5
        Me.cPozicija.HeaderText = "Pozicija"
        Me.cPozicija.Name = "cPozicija"
        '
        'cRodjendan
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cRodjendan.DefaultCellStyle = DataGridViewCellStyle6
        Me.cRodjendan.HeaderText = "Rodjendan"
        Me.cRodjendan.Name = "cRodjendan"
        Me.cRodjendan.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cRodjendan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cRodjendan.Visible = False
        '
        'cOstalo
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cOstalo.DefaultCellStyle = DataGridViewCellStyle7
        Me.cOstalo.HeaderText = "Ostalo"
        Me.cOstalo.Name = "cOstalo"
        Me.cOstalo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cOstalo.Width = 340
        '
        'frmPartneriUnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(784, 488)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbGrad)
        Me.Controls.Add(Me.cmbOpstina)
        Me.Controls.Add(Me.cmbMesto)
        Me.Controls.Add(Me.dgTelKontakt)
        Me.Controls.Add(Me.dgKontakt)
        Me.Controls.Add(Me.btnKontakti)
        Me.Controls.Add(Me.btnTelefoni)
        Me.Controls.Add(Me.chkKupac)
        Me.Controls.Add(Me.chkDobavljac)
        Me.Controls.Add(Me.chkProizvodjac)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtZR)
        Me.Controls.Add(Me.txtRegistarski)
        Me.Controls.Add(Me.txtMaticni)
        Me.Controls.Add(Me.txtPib)
        Me.Controls.Add(Me.txtAdresa)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgTelefoni)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPartneriUnos"
        Me.Text = "Partneri - Unos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgTelefoni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgKontakt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTelKontakt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbSnimi As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbEnd As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtSifra As System.Windows.Forms.TextBox
    Friend WithEvents txtNaziv As System.Windows.Forms.TextBox
    Friend WithEvents txtAdresa As System.Windows.Forms.TextBox
    Friend WithEvents txtPib As System.Windows.Forms.TextBox
    Friend WithEvents txtMaticni As System.Windows.Forms.TextBox
    Friend WithEvents txtRegistarski As System.Windows.Forms.TextBox
    Friend WithEvents txtZR As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkProizvodjac As System.Windows.Forms.CheckBox
    Friend WithEvents chkDobavljac As System.Windows.Forms.CheckBox
    Friend WithEvents chkKupac As System.Windows.Forms.CheckBox
    Friend WithEvents btnTelefoni As System.Windows.Forms.Button
    Friend WithEvents dgTelefoni As System.Windows.Forms.DataGridView
    Friend WithEvents btnKontakti As System.Windows.Forms.Button
    Friend WithEvents cTelefon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cVrsta As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dgKontakt As System.Windows.Forms.DataGridView
    Friend WithEvents dgTelKontakt As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cmbMesto As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOpstina As System.Windows.Forms.ComboBox
    Friend WithEvents cmbGrad As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cIme As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPrezime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPozicija As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cRodjendan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cOstalo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
