<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKalkulacijaEdit
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKalkulacijaEdit))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tlbSnimi = New System.Windows.Forms.ToolStripButton
        Me.tlbStanje = New System.Windows.Forms.ToolStripButton
        Me.tlbProknjizi = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tlbEnd = New System.Windows.Forms.ToolStripButton
        Me.txtRazlikaucFarma = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkZT = New System.Windows.Forms.CheckBox
        Me.tableZT = New System.Windows.Forms.TableLayoutPanel
        Me.btnPridruzi = New System.Windows.Forms.Button
        Me.chkProcenat = New System.Windows.Forms.CheckBox
        Me.txtZTProcenat = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkIznos = New System.Windows.Forms.CheckBox
        Me.txtZTIznos = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtUkupnoPrc = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtProporcija = New System.Windows.Forms.TextBox
        Me.txtOsnovica = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtIznosZanaplatu = New System.Windows.Forms.TextBox
        Me.txtIznosPdv = New System.Windows.Forms.TextBox
        Me.txtIznosRabat = New System.Windows.Forms.TextBox
        Me.txtIznosCena = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnNoviPartner = New System.Windows.Forms.Button
        Me.btnNoviArtkl = New System.Windows.Forms.Button
        Me.btnOsvezi = New System.Windows.Forms.Button
        Me.labProknjizen = New System.Windows.Forms.Label
        Me.txtPartneri = New System.Windows.Forms.TextBox
        Me.txtFaktura = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dateKalkulacija = New System.Windows.Forms.DateTimePicker
        Me.dateFaktura = New System.Windows.Forms.DateTimePicker
        Me.cmbPartneri = New System.Windows.Forms.ComboBox
        Me.txtBroj = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgStavke = New System.Windows.Forms.DataGridView
        Me.DataSet1 = New Farma.DataSet1
        Me.RmartikliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rm_artikliTableAdapter = New Farma.DataSet1TableAdapters.rm_artikliTableAdapter
        Me.ApppdvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.App_pdvTableAdapter = New Farma.DataSet1TableAdapters.app_pdvTableAdapter
        Me.cRb = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cSifra = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.cOpis = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cKol = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cCenaKostanja = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cRabat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cZTroskovi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cNab_cena = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cNabVrednost = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cMarza = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cPdv = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.cProdCena = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cIznosPDV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cProdVred = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1.SuspendLayout()
        Me.tableZT.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgStavke, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RmartikliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApppdvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbSnimi, Me.tlbStanje, Me.tlbProknjizi, Me.ToolStripSeparator1, Me.tlbEnd})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(904, 25)
        Me.ToolStrip1.TabIndex = 74
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
        'tlbProknjizi
        '
        Me.tlbProknjizi.Image = Global.Farma.My.Resources.Resources.Files_text
        Me.tlbProknjizi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbProknjizi.Name = "tlbProknjizi"
        Me.tlbProknjizi.Size = New System.Drawing.Size(66, 22)
        Me.tlbProknjizi.Text = "Proknjiži"
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
        'txtRazlikaucFarma
        '
        Me.txtRazlikaucFarma.BackColor = System.Drawing.Color.GhostWhite
        Me.txtRazlikaucFarma.Enabled = False
        Me.txtRazlikaucFarma.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtRazlikaucFarma.Location = New System.Drawing.Point(792, 364)
        Me.txtRazlikaucFarma.Name = "txtRazlikaucFarma"
        Me.txtRazlikaucFarma.Size = New System.Drawing.Size(100, 20)
        Me.txtRazlikaucFarma.TabIndex = 122
        Me.txtRazlikaucFarma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(712, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Razlika u cFarma"
        '
        'chkZT
        '
        Me.chkZT.AutoSize = True
        Me.chkZT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkZT.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkZT.Location = New System.Drawing.Point(12, 322)
        Me.chkZT.Name = "chkZT"
        Me.chkZT.Size = New System.Drawing.Size(142, 17)
        Me.chkZT.TabIndex = 120
        Me.chkZT.Text = "ZAVISNI TROŠKOVI"
        Me.chkZT.UseVisualStyleBackColor = True
        '
        'tableZT
        '
        Me.tableZT.ColumnCount = 5
        Me.tableZT.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tableZT.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tableZT.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.tableZT.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tableZT.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tableZT.Controls.Add(Me.btnPridruzi, 0, 2)
        Me.tableZT.Controls.Add(Me.chkProcenat, 0, 0)
        Me.tableZT.Controls.Add(Me.txtZTProcenat, 1, 0)
        Me.tableZT.Controls.Add(Me.Label5, 2, 0)
        Me.tableZT.Controls.Add(Me.chkIznos, 0, 1)
        Me.tableZT.Controls.Add(Me.txtZTIznos, 1, 1)
        Me.tableZT.Controls.Add(Me.Label12, 2, 1)
        Me.tableZT.Controls.Add(Me.txtUkupnoPrc, 4, 0)
        Me.tableZT.Controls.Add(Me.Label14, 3, 0)
        Me.tableZT.Controls.Add(Me.Label15, 3, 1)
        Me.tableZT.Controls.Add(Me.txtProporcija, 4, 1)
        Me.tableZT.Location = New System.Drawing.Point(12, 345)
        Me.tableZT.Name = "tableZT"
        Me.tableZT.RowCount = 3
        Me.tableZT.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableZT.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableZT.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tableZT.Size = New System.Drawing.Size(370, 91)
        Me.tableZT.TabIndex = 119
        '
        'btnPridruzi
        '
        Me.btnPridruzi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tableZT.SetColumnSpan(Me.btnPridruzi, 2)
        Me.btnPridruzi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnPridruzi.Location = New System.Drawing.Point(3, 62)
        Me.btnPridruzi.Name = "btnPridruzi"
        Me.btnPridruzi.Size = New System.Drawing.Size(102, 23)
        Me.btnPridruzi.TabIndex = 107
        Me.btnPridruzi.Text = "Pridruži troškove"
        Me.btnPridruzi.UseVisualStyleBackColor = True
        '
        'chkProcenat
        '
        Me.chkProcenat.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkProcenat.AutoSize = True
        Me.chkProcenat.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkProcenat.Location = New System.Drawing.Point(3, 5)
        Me.chkProcenat.Name = "chkProcenat"
        Me.chkProcenat.Size = New System.Drawing.Size(64, 17)
        Me.chkProcenat.TabIndex = 97
        Me.chkProcenat.Text = "Procenat"
        Me.chkProcenat.UseVisualStyleBackColor = True
        '
        'txtZTProcenat
        '
        Me.txtZTProcenat.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtZTProcenat.BackColor = System.Drawing.Color.GhostWhite
        Me.txtZTProcenat.Location = New System.Drawing.Point(73, 4)
        Me.txtZTProcenat.Name = "txtZTProcenat"
        Me.txtZTProcenat.Size = New System.Drawing.Size(54, 20)
        Me.txtZTProcenat.TabIndex = 99
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(133, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 13)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "%"
        '
        'chkIznos
        '
        Me.chkIznos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkIznos.AutoSize = True
        Me.chkIznos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkIznos.Location = New System.Drawing.Point(3, 33)
        Me.chkIznos.Name = "chkIznos"
        Me.chkIznos.Size = New System.Drawing.Size(51, 17)
        Me.chkIznos.TabIndex = 98
        Me.chkIznos.Text = "Iznos"
        Me.chkIznos.UseVisualStyleBackColor = True
        '
        'txtZTIznos
        '
        Me.txtZTIznos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtZTIznos.BackColor = System.Drawing.Color.GhostWhite
        Me.txtZTIznos.Location = New System.Drawing.Point(73, 32)
        Me.txtZTIznos.Name = "txtZTIznos"
        Me.txtZTIznos.Size = New System.Drawing.Size(54, 20)
        Me.txtZTIznos.TabIndex = 100
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label12.Location = New System.Drawing.Point(133, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 102
        Me.Label12.Text = "dinara"
        '
        'txtUkupnoPrc
        '
        Me.txtUkupnoPrc.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtUkupnoPrc.BackColor = System.Drawing.Color.GhostWhite
        Me.txtUkupnoPrc.Enabled = False
        Me.txtUkupnoPrc.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtUkupnoPrc.Location = New System.Drawing.Point(278, 4)
        Me.txtUkupnoPrc.Name = "txtUkupnoPrc"
        Me.txtUkupnoPrc.Size = New System.Drawing.Size(79, 20)
        Me.txtUkupnoPrc.TabIndex = 103
        Me.txtUkupnoPrc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label14.Location = New System.Drawing.Point(227, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 104
        Me.Label14.Text = "Ukupno"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label15.Location = New System.Drawing.Point(188, 35)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 13)
        Me.Label15.TabIndex = 105
        Me.Label15.Text = "Poroporcionalno"
        '
        'txtProporcija
        '
        Me.txtProporcija.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtProporcija.BackColor = System.Drawing.Color.GhostWhite
        Me.txtProporcija.Enabled = False
        Me.txtProporcija.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtProporcija.Location = New System.Drawing.Point(278, 32)
        Me.txtProporcija.Name = "txtProporcija"
        Me.txtProporcija.Size = New System.Drawing.Size(79, 20)
        Me.txtProporcija.TabIndex = 106
        Me.txtProporcija.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOsnovica
        '
        Me.txtOsnovica.BackColor = System.Drawing.Color.GhostWhite
        Me.txtOsnovica.Enabled = False
        Me.txtOsnovica.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtOsnovica.Location = New System.Drawing.Point(792, 390)
        Me.txtOsnovica.Name = "txtOsnovica"
        Me.txtOsnovica.Size = New System.Drawing.Size(100, 20)
        Me.txtOsnovica.TabIndex = 118
        Me.txtOsnovica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label11.Location = New System.Drawing.Point(709, 397)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 117
        Me.Label11.Text = "PDV Osnovica"
        '
        'txtIznosZanaplatu
        '
        Me.txtIznosZanaplatu.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIznosZanaplatu.Enabled = False
        Me.txtIznosZanaplatu.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtIznosZanaplatu.Location = New System.Drawing.Point(792, 442)
        Me.txtIznosZanaplatu.Name = "txtIznosZanaplatu"
        Me.txtIznosZanaplatu.Size = New System.Drawing.Size(100, 20)
        Me.txtIznosZanaplatu.TabIndex = 116
        Me.txtIznosZanaplatu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIznosPdv
        '
        Me.txtIznosPdv.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIznosPdv.Enabled = False
        Me.txtIznosPdv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtIznosPdv.Location = New System.Drawing.Point(792, 416)
        Me.txtIznosPdv.Name = "txtIznosPdv"
        Me.txtIznosPdv.Size = New System.Drawing.Size(100, 20)
        Me.txtIznosPdv.TabIndex = 115
        Me.txtIznosPdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIznosRabat
        '
        Me.txtIznosRabat.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIznosRabat.Enabled = False
        Me.txtIznosRabat.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtIznosRabat.Location = New System.Drawing.Point(792, 338)
        Me.txtIznosRabat.Name = "txtIznosRabat"
        Me.txtIznosRabat.Size = New System.Drawing.Size(100, 20)
        Me.txtIznosRabat.TabIndex = 114
        Me.txtIznosRabat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIznosCena
        '
        Me.txtIznosCena.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIznosCena.Enabled = False
        Me.txtIznosCena.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtIznosCena.Location = New System.Drawing.Point(792, 311)
        Me.txtIznosCena.Name = "txtIznosCena"
        Me.txtIznosCena.Size = New System.Drawing.Size(100, 20)
        Me.txtIznosCena.TabIndex = 113
        Me.txtIznosCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(748, 449)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "Svega"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(757, 423)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "PDV"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(750, 345)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "Rabat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(741, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "Ukupno"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel1.Controls.Add(Me.btnNoviPartner)
        Me.Panel1.Controls.Add(Me.btnNoviArtkl)
        Me.Panel1.Controls.Add(Me.btnOsvezi)
        Me.Panel1.Controls.Add(Me.labProknjizen)
        Me.Panel1.Controls.Add(Me.txtPartneri)
        Me.Panel1.Controls.Add(Me.txtFaktura)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dateKalkulacija)
        Me.Panel1.Controls.Add(Me.dateFaktura)
        Me.Panel1.Controls.Add(Me.cmbPartneri)
        Me.Panel1.Controls.Add(Me.txtBroj)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 64)
        Me.Panel1.TabIndex = 107
        '
        'btnNoviPartner
        '
        Me.btnNoviPartner.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnNoviPartner.Location = New System.Drawing.Point(642, 20)
        Me.btnNoviPartner.Name = "btnNoviPartner"
        Me.btnNoviPartner.Size = New System.Drawing.Size(75, 23)
        Me.btnNoviPartner.TabIndex = 109
        Me.btnNoviPartner.Text = "Novi Prtner"
        Me.btnNoviPartner.UseVisualStyleBackColor = True
        '
        'btnNoviArtkl
        '
        Me.btnNoviArtkl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnNoviArtkl.Location = New System.Drawing.Point(723, 20)
        Me.btnNoviArtkl.Name = "btnNoviArtkl"
        Me.btnNoviArtkl.Size = New System.Drawing.Size(75, 23)
        Me.btnNoviArtkl.TabIndex = 108
        Me.btnNoviArtkl.Text = "Novi Artkl"
        Me.btnNoviArtkl.UseVisualStyleBackColor = True
        '
        'btnOsvezi
        '
        Me.btnOsvezi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnOsvezi.Location = New System.Drawing.Point(804, 20)
        Me.btnOsvezi.Name = "btnOsvezi"
        Me.btnOsvezi.Size = New System.Drawing.Size(64, 23)
        Me.btnOsvezi.TabIndex = 107
        Me.btnOsvezi.Text = "Osveži"
        Me.btnOsvezi.UseVisualStyleBackColor = True
        '
        'labProknjizen
        '
        Me.labProknjizen.AutoSize = True
        Me.labProknjizen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labProknjizen.ForeColor = System.Drawing.Color.MidnightBlue
        Me.labProknjizen.Location = New System.Drawing.Point(520, 25)
        Me.labProknjizen.Name = "labProknjizen"
        Me.labProknjizen.Size = New System.Drawing.Size(102, 16)
        Me.labProknjizen.TabIndex = 22
        Me.labProknjizen.Text = "PROKNJIŽEN"
        '
        'txtPartneri
        '
        Me.txtPartneri.BackColor = System.Drawing.Color.GhostWhite
        Me.txtPartneri.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtPartneri.Location = New System.Drawing.Point(169, 39)
        Me.txtPartneri.Name = "txtPartneri"
        Me.txtPartneri.Size = New System.Drawing.Size(155, 20)
        Me.txtPartneri.TabIndex = 21
        '
        'txtFaktura
        '
        Me.txtFaktura.BackColor = System.Drawing.Color.GhostWhite
        Me.txtFaktura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtFaktura.Location = New System.Drawing.Point(330, 23)
        Me.txtFaktura.Name = "txtFaktura"
        Me.txtFaktura.Size = New System.Drawing.Size(77, 20)
        Me.txtFaktura.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label13.Location = New System.Drawing.Point(327, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Broj Fakture"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(70, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Datum kalkulacije"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(411, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Datum fakture"
        '
        'dateKalkulacija
        '
        Me.dateKalkulacija.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.dateKalkulacija.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.dateKalkulacija.CalendarTitleForeColor = System.Drawing.Color.GhostWhite
        Me.dateKalkulacija.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateKalkulacija.Location = New System.Drawing.Point(73, 23)
        Me.dateKalkulacija.Name = "dateKalkulacija"
        Me.dateKalkulacija.Size = New System.Drawing.Size(90, 20)
        Me.dateKalkulacija.TabIndex = 15
        '
        'dateFaktura
        '
        Me.dateFaktura.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.dateFaktura.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.dateFaktura.CalendarTitleForeColor = System.Drawing.Color.GhostWhite
        Me.dateFaktura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFaktura.Location = New System.Drawing.Point(413, 23)
        Me.dateFaktura.Name = "dateFaktura"
        Me.dateFaktura.Size = New System.Drawing.Size(90, 20)
        Me.dateFaktura.TabIndex = 14
        '
        'cmbPartneri
        '
        Me.cmbPartneri.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbPartneri.FormattingEnabled = True
        Me.cmbPartneri.Location = New System.Drawing.Point(169, 22)
        Me.cmbPartneri.Name = "cmbPartneri"
        Me.cmbPartneri.Size = New System.Drawing.Size(155, 21)
        Me.cmbPartneri.TabIndex = 13
        '
        'txtBroj
        '
        Me.txtBroj.BackColor = System.Drawing.Color.GhostWhite
        Me.txtBroj.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBroj.Location = New System.Drawing.Point(11, 23)
        Me.txtBroj.Name = "txtBroj"
        Me.txtBroj.Size = New System.Drawing.Size(56, 20)
        Me.txtBroj.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Broj"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(166, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Poslovni Partner"
        '
        'dgStavke
        '
        Me.dgStavke.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.dgStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStavke.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cRb, Me.cSifra, Me.cOpis, Me.cKol, Me.cCenaKostanja, Me.cRabat, Me.cZTroskovi, Me.cNab_cena, Me.cNabVrednost, Me.cMarza, Me.cPdv, Me.cProdCena, Me.cIznosPDV, Me.cProdVred})
        Me.dgStavke.Location = New System.Drawing.Point(12, 108)
        Me.dgStavke.Name = "dgStavke"
        Me.dgStavke.Size = New System.Drawing.Size(880, 197)
        Me.dgStavke.TabIndex = 123
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
        'ApppdvBindingSource
        '
        Me.ApppdvBindingSource.DataMember = "app_pdv"
        Me.ApppdvBindingSource.DataSource = Me.DataSet1
        '
        'App_pdvTableAdapter
        '
        Me.App_pdvTableAdapter.ClearBeforeFill = True
        '
        'cRb
        '
        Me.cRb.HeaderText = "Rb"
        Me.cRb.Name = "cRb"
        Me.cRb.Width = 40
        '
        'cSifra
        '
        Me.cSifra.DataSource = Me.RmartikliBindingSource
        Me.cSifra.DisplayMember = "sifra"
        Me.cSifra.HeaderText = "Šifra artikla"
        Me.cSifra.Name = "cSifra"
        Me.cSifra.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cSifra.ValueMember = "sifra"
        '
        'cOpis
        '
        Me.cOpis.HeaderText = "Opis"
        Me.cOpis.Name = "cOpis"
        Me.cOpis.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cOpis.Width = 200
        '
        'cKol
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cKol.DefaultCellStyle = DataGridViewCellStyle1
        Me.cKol.HeaderText = "Kol"
        Me.cKol.Name = "cKol"
        Me.cKol.Width = 50
        '
        'cCenaKostanja
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.cCenaKostanja.DefaultCellStyle = DataGridViewCellStyle2
        Me.cCenaKostanja.HeaderText = "Nabavna Cena"
        Me.cCenaKostanja.Name = "cCenaKostanja"
        Me.cCenaKostanja.Width = 95
        '
        'cRabat
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cRabat.DefaultCellStyle = DataGridViewCellStyle3
        Me.cRabat.HeaderText = "Rabat"
        Me.cRabat.Name = "cRabat"
        Me.cRabat.Width = 60
        '
        'cZTroskovi
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.cZTroskovi.DefaultCellStyle = DataGridViewCellStyle4
        Me.cZTroskovi.HeaderText = "Zav. Troškovi"
        Me.cZTroskovi.Name = "cZTroskovi"
        Me.cZTroskovi.Width = 80
        '
        'cNab_cena
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.cNab_cena.DefaultCellStyle = DataGridViewCellStyle5
        Me.cNab_cena.HeaderText = "Cena  koštanja"
        Me.cNab_cena.Name = "cNab_cena"
        Me.cNab_cena.Width = 95
        '
        'cNabVrednost
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.cNabVrednost.DefaultCellStyle = DataGridViewCellStyle6
        Me.cNabVrednost.HeaderText = "Nab. Vrednost"
        Me.cNabVrednost.Name = "cNabVrednost"
        '
        'cMarza
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.cMarza.DefaultCellStyle = DataGridViewCellStyle7
        Me.cMarza.HeaderText = "Marža"
        Me.cMarza.Name = "cMarza"
        Me.cMarza.Width = 60
        '
        'cPdv
        '
        Me.cPdv.DataSource = Me.ApppdvBindingSource
        Me.cPdv.DisplayMember = "stopa"
        Me.cPdv.HeaderText = "PDV"
        Me.cPdv.Name = "cPdv"
        Me.cPdv.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cPdv.ValueMember = "stopa"
        Me.cPdv.Width = 65
        '
        'cProdCena
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.cProdCena.DefaultCellStyle = DataGridViewCellStyle8
        Me.cProdCena.HeaderText = "Prod. Cena"
        Me.cProdCena.Name = "cProdCena"
        Me.cProdCena.Width = 95
        '
        'cIznosPDV
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.cIznosPDV.DefaultCellStyle = DataGridViewCellStyle9
        Me.cIznosPDV.HeaderText = "Iznos PDV"
        Me.cIznosPDV.Name = "cIznosPDV"
        Me.cIznosPDV.Width = 95
        '
        'cProdVred
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.cProdVred.DefaultCellStyle = DataGridViewCellStyle10
        Me.cProdVred.HeaderText = "Prod. Vrednost"
        Me.cProdVred.Name = "cProdVred"
        Me.cProdVred.Width = 95
        '
        'frmKalkulacijaEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(904, 473)
        Me.Controls.Add(Me.dgStavke)
        Me.Controls.Add(Me.txtRazlikaucFarma)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkZT)
        Me.Controls.Add(Me.tableZT)
        Me.Controls.Add(Me.txtOsnovica)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtIznosZanaplatu)
        Me.Controls.Add(Me.txtIznosPdv)
        Me.Controls.Add(Me.txtIznosRabat)
        Me.Controls.Add(Me.txtIznosCena)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKalkulacijaEdit"
        Me.Text = "Kalkulacija Edit"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tableZT.ResumeLayout(False)
        Me.tableZT.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgStavke, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RmartikliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApppdvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbSnimi As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbStanje As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbProknjizi As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbEnd As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtRazlikaucFarma As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkZT As System.Windows.Forms.CheckBox
    Friend WithEvents tableZT As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnPridruzi As System.Windows.Forms.Button
    Friend WithEvents chkProcenat As System.Windows.Forms.CheckBox
    Friend WithEvents txtZTProcenat As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkIznos As System.Windows.Forms.CheckBox
    Friend WithEvents txtZTIznos As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtUkupnoPrc As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtProporcija As System.Windows.Forms.TextBox
    Friend WithEvents txtOsnovica As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtIznosZanaplatu As System.Windows.Forms.TextBox
    Friend WithEvents txtIznosPdv As System.Windows.Forms.TextBox
    Friend WithEvents txtIznosRabat As System.Windows.Forms.TextBox
    Friend WithEvents txtIznosCena As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNoviPartner As System.Windows.Forms.Button
    Friend WithEvents btnNoviArtkl As System.Windows.Forms.Button
    Friend WithEvents btnOsvezi As System.Windows.Forms.Button
    Friend WithEvents labProknjizen As System.Windows.Forms.Label
    Friend WithEvents txtPartneri As System.Windows.Forms.TextBox
    Friend WithEvents txtFaktura As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dateKalkulacija As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateFaktura As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbPartneri As System.Windows.Forms.ComboBox
    Friend WithEvents txtBroj As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgStavke As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As Farma.DataSet1
    Friend WithEvents RmartikliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rm_artikliTableAdapter As Farma.DataSet1TableAdapters.rm_artikliTableAdapter
    Friend WithEvents ApppdvBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents App_pdvTableAdapter As Farma.DataSet1TableAdapters.app_pdvTableAdapter
    Friend WithEvents cRb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSifra As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cOpis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cKol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCenaKostanja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cRabat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cZTroskovi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNab_cena As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNabVrednost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMarza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPdv As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cProdCena As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cIznosPDV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cProdVred As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
