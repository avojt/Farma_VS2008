<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIzvodiEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIzvodiEdit))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tlbSnimi = New System.Windows.Forms.ToolStripButton
        Me.tlbProknjizi = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tlbEnd = New System.Windows.Forms.ToolStripButton
        Me.txtNovoStanje = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtStaroStanje = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSaldo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSvegaPotrazuje = New System.Windows.Forms.TextBox
        Me.txtSvegaDuguje = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.dgStavke = New System.Windows.Forms.DataGridView
        Me.cRb = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cSifra = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.KontaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Farma.DataSet1
        Me.cPartner = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.PartneriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cDokument = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.cOpis = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cCenaKostanja = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cRabat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.labProknjizen = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnNoviPartner = New System.Windows.Forms.Button
        Me.cmbDokumenti = New System.Windows.Forms.ComboBox
        Me.btnOsvezi = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.dateDatum = New System.Windows.Forms.DateTimePicker
        Me.txtBroj = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.KontaTableAdapter = New Farma.DataSet1TableAdapters.fn_kontaTableAdapter
        Me.PartneriTableAdapter = New Farma.DataSet1TableAdapters.app_partneriTableAdapter
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgStavke, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KontaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartneriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbSnimi, Me.tlbProknjizi, Me.ToolStripSeparator1, Me.tlbEnd})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(742, 25)
        Me.ToolStrip1.TabIndex = 75
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
        'txtNovoStanje
        '
        Me.txtNovoStanje.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNovoStanje.Enabled = False
        Me.txtNovoStanje.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNovoStanje.Location = New System.Drawing.Point(75, 308)
        Me.txtNovoStanje.Name = "txtNovoStanje"
        Me.txtNovoStanje.Size = New System.Drawing.Size(100, 20)
        Me.txtNovoStanje.TabIndex = 128
        Me.txtNovoStanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(5, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Novo stanje"
        '
        'txtStaroStanje
        '
        Me.txtStaroStanje.BackColor = System.Drawing.Color.GhostWhite
        Me.txtStaroStanje.Enabled = False
        Me.txtStaroStanje.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtStaroStanje.Location = New System.Drawing.Point(75, 282)
        Me.txtStaroStanje.Name = "txtStaroStanje"
        Me.txtStaroStanje.Size = New System.Drawing.Size(100, 20)
        Me.txtStaroStanje.TabIndex = 126
        Me.txtStaroStanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(6, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Staro stanje"
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSaldo.Location = New System.Drawing.Point(631, 334)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldo.TabIndex = 124
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(591, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "Saldo"
        '
        'txtSvegaPotrazuje
        '
        Me.txtSvegaPotrazuje.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSvegaPotrazuje.Enabled = False
        Me.txtSvegaPotrazuje.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSvegaPotrazuje.Location = New System.Drawing.Point(631, 308)
        Me.txtSvegaPotrazuje.Name = "txtSvegaPotrazuje"
        Me.txtSvegaPotrazuje.Size = New System.Drawing.Size(100, 20)
        Me.txtSvegaPotrazuje.TabIndex = 122
        Me.txtSvegaPotrazuje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSvegaDuguje
        '
        Me.txtSvegaDuguje.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSvegaDuguje.Enabled = False
        Me.txtSvegaDuguje.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSvegaDuguje.Location = New System.Drawing.Point(631, 282)
        Me.txtSvegaDuguje.Name = "txtSvegaDuguje"
        Me.txtSvegaDuguje.Size = New System.Drawing.Size(100, 20)
        Me.txtSvegaDuguje.TabIndex = 121
        Me.txtSvegaDuguje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(540, 315)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 120
        Me.Label8.Text = "Svega Potražuje"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(550, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 119
        Me.Label7.Text = "Svega Duguje"
        '
        'dgStavke
        '
        Me.dgStavke.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.dgStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStavke.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cRb, Me.cSifra, Me.cPartner, Me.cDokument, Me.cOpis, Me.cCenaKostanja, Me.cRabat})
        Me.dgStavke.Location = New System.Drawing.Point(12, 108)
        Me.dgStavke.Name = "dgStavke"
        Me.dgStavke.Size = New System.Drawing.Size(719, 168)
        Me.dgStavke.TabIndex = 118
        '
        'cRb
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cRb.DefaultCellStyle = DataGridViewCellStyle1
        Me.cRb.Frozen = True
        Me.cRb.HeaderText = "Rb"
        Me.cRb.Name = "cRb"
        Me.cRb.Width = 40
        '
        'cSifra
        '
        Me.cSifra.DataSource = Me.KontaBindingSource
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cSifra.DefaultCellStyle = DataGridViewCellStyle2
        Me.cSifra.DisplayMember = "konto"
        Me.cSifra.HeaderText = "Konto"
        Me.cSifra.Name = "cSifra"
        Me.cSifra.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cSifra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cSifra.ValueMember = "konto"
        Me.cSifra.Width = 80
        '
        'KontaBindingSource
        '
        Me.KontaBindingSource.DataMember = "konta"
        Me.KontaBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cPartner
        '
        Me.cPartner.DataSource = Me.PartneriBindingSource
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cPartner.DefaultCellStyle = DataGridViewCellStyle3
        Me.cPartner.DisplayMember = "sifra"
        Me.cPartner.HeaderText = "Partner"
        Me.cPartner.Name = "cPartner"
        Me.cPartner.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cPartner.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cPartner.ValueMember = "sifra"
        Me.cPartner.Width = 80
        '
        'PartneriBindingSource
        '
        Me.PartneriBindingSource.DataMember = "partneri"
        Me.PartneriBindingSource.DataSource = Me.DataSet1
        '
        'cDokument
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cDokument.DefaultCellStyle = DataGridViewCellStyle4
        Me.cDokument.HeaderText = "Dokument"
        Me.cDokument.Name = "cDokument"
        Me.cDokument.Visible = False
        Me.cDokument.Width = 70
        '
        'cOpis
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cOpis.DefaultCellStyle = DataGridViewCellStyle5
        Me.cOpis.HeaderText = "Opis"
        Me.cOpis.Name = "cOpis"
        Me.cOpis.Width = 270
        '
        'cCenaKostanja
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.cCenaKostanja.DefaultCellStyle = DataGridViewCellStyle6
        Me.cCenaKostanja.HeaderText = "Duguje"
        Me.cCenaKostanja.Name = "cCenaKostanja"
        '
        'cRabat
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.cRabat.DefaultCellStyle = DataGridViewCellStyle7
        Me.cRabat.HeaderText = "Potražuje"
        Me.cRabat.Name = "cRabat"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel1.Controls.Add(Me.labProknjizen)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnNoviPartner)
        Me.Panel1.Controls.Add(Me.cmbDokumenti)
        Me.Panel1.Controls.Add(Me.btnOsvezi)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dateDatum)
        Me.Panel1.Controls.Add(Me.txtBroj)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(719, 64)
        Me.Panel1.TabIndex = 117
        '
        'labProknjizen
        '
        Me.labProknjizen.AutoSize = True
        Me.labProknjizen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labProknjizen.ForeColor = System.Drawing.Color.MidnightBlue
        Me.labProknjizen.Location = New System.Drawing.Point(425, 31)
        Me.labProknjizen.Name = "labProknjizen"
        Me.labProknjizen.Size = New System.Drawing.Size(102, 16)
        Me.labProknjizen.TabIndex = 119
        Me.labProknjizen.Text = "PROKNJIŽEN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(249, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Broj dokumenta"
        '
        'btnNoviPartner
        '
        Me.btnNoviPartner.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnNoviPartner.Location = New System.Drawing.Point(561, 28)
        Me.btnNoviPartner.Name = "btnNoviPartner"
        Me.btnNoviPartner.Size = New System.Drawing.Size(75, 23)
        Me.btnNoviPartner.TabIndex = 109
        Me.btnNoviPartner.Text = "Novi Prtner"
        Me.btnNoviPartner.UseVisualStyleBackColor = True
        '
        'cmbDokumenti
        '
        Me.cmbDokumenti.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbDokumenti.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbDokumenti.FormattingEnabled = True
        Me.cmbDokumenti.Location = New System.Drawing.Point(252, 29)
        Me.cmbDokumenti.Name = "cmbDokumenti"
        Me.cmbDokumenti.Size = New System.Drawing.Size(135, 21)
        Me.cmbDokumenti.TabIndex = 117
        '
        'btnOsvezi
        '
        Me.btnOsvezi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnOsvezi.Location = New System.Drawing.Point(642, 28)
        Me.btnOsvezi.Name = "btnOsvezi"
        Me.btnOsvezi.Size = New System.Drawing.Size(64, 23)
        Me.btnOsvezi.TabIndex = 107
        Me.btnOsvezi.Text = "Osveži"
        Me.btnOsvezi.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(70, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Datum"
        '
        'dateDatum
        '
        Me.dateDatum.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.dateDatum.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.dateDatum.CalendarTitleForeColor = System.Drawing.Color.GhostWhite
        Me.dateDatum.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateDatum.Location = New System.Drawing.Point(73, 28)
        Me.dateDatum.Name = "dateDatum"
        Me.dateDatum.Size = New System.Drawing.Size(90, 20)
        Me.dateDatum.TabIndex = 15
        '
        'txtBroj
        '
        Me.txtBroj.BackColor = System.Drawing.Color.GhostWhite
        Me.txtBroj.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBroj.Location = New System.Drawing.Point(11, 28)
        Me.txtBroj.Name = "txtBroj"
        Me.txtBroj.Size = New System.Drawing.Size(56, 20)
        Me.txtBroj.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Broj"
        '
        'KontaTableAdapter
        '
        Me.KontaTableAdapter.ClearBeforeFill = True
        '
        'PartneriTableAdapter
        '
        Me.PartneriTableAdapter.ClearBeforeFill = True
        '
        'frmIzvodiEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(742, 366)
        Me.Controls.Add(Me.txtNovoStanje)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtStaroStanje)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSvegaPotrazuje)
        Me.Controls.Add(Me.txtSvegaDuguje)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgStavke)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIzvodiEdit"
        Me.Text = "Izvodi - Edit"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgStavke, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KontaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartneriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbSnimi As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbEnd As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtNovoStanje As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtStaroStanje As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSvegaPotrazuje As System.Windows.Forms.TextBox
    Friend WithEvents txtSvegaDuguje As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgStavke As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnNoviPartner As System.Windows.Forms.Button
    Friend WithEvents cmbDokumenti As System.Windows.Forms.ComboBox
    Friend WithEvents btnOsvezi As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dateDatum As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBroj As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As Farma.DataSet1
    Friend WithEvents KontaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KontaTableAdapter As Farma.DataSet1TableAdapters.fn_kontaTableAdapter
    Friend WithEvents PartneriBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartneriTableAdapter As Farma.DataSet1TableAdapters.app_partneriTableAdapter
    Friend WithEvents cRb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSifra As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cPartner As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cDokument As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cOpis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCenaKostanja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cRabat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tlbProknjizi As System.Windows.Forms.ToolStripButton
    Friend WithEvents labProknjizen As System.Windows.Forms.Label
End Class
