<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNalogEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNalogEdit))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tlbSnimi = New System.Windows.Forms.ToolStripButton
        Me.tlbProknjizi = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tlbEnd = New System.Windows.Forms.ToolStripButton
        Me.txtSaldo = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtPotrazuje = New System.Windows.Forms.TextBox
        Me.txtDuguje = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dgStavke = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.labProknjizen = New System.Windows.Forms.Label
        Me.btnNoviPartner = New System.Windows.Forms.Button
        Me.btnOsvezi = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.dateKnjizenja = New System.Windows.Forms.DateTimePicker
        Me.txtBroj = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataSet1 = New Farma.DataSet1
        Me.KontaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KontaTableAdapter = New Farma.DataSet1TableAdapters.fn_kontaTableAdapter
        Me.PartneriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartneriTableAdapter = New Farma.DataSet1TableAdapters.app_partneriTableAdapter
        Me.cRb = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cKonto = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.cPartner = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.cOpis = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cIznos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cPotrazuje = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgStavke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KontaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartneriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbSnimi, Me.tlbProknjizi, Me.ToolStripSeparator1, Me.tlbEnd})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(669, 25)
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
        'tlbProknjizi
        '
        Me.tlbProknjizi.Image = Global.Farma.My.Resources.Resources.LaST__Cobalt__Text_File
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
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSaldo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSaldo.Location = New System.Drawing.Point(558, 359)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldo.TabIndex = 91
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(518, 366)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "Saldo"
        '
        'txtPotrazuje
        '
        Me.txtPotrazuje.BackColor = System.Drawing.Color.GhostWhite
        Me.txtPotrazuje.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPotrazuje.Location = New System.Drawing.Point(558, 333)
        Me.txtPotrazuje.Name = "txtPotrazuje"
        Me.txtPotrazuje.Size = New System.Drawing.Size(100, 20)
        Me.txtPotrazuje.TabIndex = 89
        Me.txtPotrazuje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDuguje
        '
        Me.txtDuguje.BackColor = System.Drawing.Color.GhostWhite
        Me.txtDuguje.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDuguje.Location = New System.Drawing.Point(452, 333)
        Me.txtDuguje.Name = "txtDuguje"
        Me.txtDuguje.Size = New System.Drawing.Size(100, 20)
        Me.txtDuguje.TabIndex = 88
        Me.txtDuguje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(401, 340)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Ukupno"
        '
        'dgStavke
        '
        Me.dgStavke.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.dgStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStavke.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cRb, Me.cKonto, Me.cPartner, Me.cOpis, Me.cIznos, Me.cPotrazuje})
        Me.dgStavke.Location = New System.Drawing.Point(11, 107)
        Me.dgStavke.Name = "dgStavke"
        Me.dgStavke.Size = New System.Drawing.Size(647, 220)
        Me.dgStavke.TabIndex = 86
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel1.Controls.Add(Me.labProknjizen)
        Me.Panel1.Controls.Add(Me.btnNoviPartner)
        Me.Panel1.Controls.Add(Me.btnOsvezi)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dateKnjizenja)
        Me.Panel1.Controls.Add(Me.txtBroj)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(11, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(647, 64)
        Me.Panel1.TabIndex = 85
        '
        'labProknjizen
        '
        Me.labProknjizen.AutoSize = True
        Me.labProknjizen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labProknjizen.ForeColor = System.Drawing.Color.MidnightBlue
        Me.labProknjizen.Location = New System.Drawing.Point(353, 25)
        Me.labProknjizen.Name = "labProknjizen"
        Me.labProknjizen.Size = New System.Drawing.Size(102, 16)
        Me.labProknjizen.TabIndex = 122
        Me.labProknjizen.Text = "PROKNJIŽEN"
        '
        'btnNoviPartner
        '
        Me.btnNoviPartner.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnNoviPartner.Location = New System.Drawing.Point(489, 22)
        Me.btnNoviPartner.Name = "btnNoviPartner"
        Me.btnNoviPartner.Size = New System.Drawing.Size(75, 23)
        Me.btnNoviPartner.TabIndex = 121
        Me.btnNoviPartner.Text = "Novi Prtner"
        Me.btnNoviPartner.UseVisualStyleBackColor = True
        '
        'btnOsvezi
        '
        Me.btnOsvezi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnOsvezi.Location = New System.Drawing.Point(570, 22)
        Me.btnOsvezi.Name = "btnOsvezi"
        Me.btnOsvezi.Size = New System.Drawing.Size(64, 23)
        Me.btnOsvezi.TabIndex = 120
        Me.btnOsvezi.Text = "Osveži"
        Me.btnOsvezi.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(76, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Dat. fakturisanja"
        '
        'dateKnjizenja
        '
        Me.dateKnjizenja.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.dateKnjizenja.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.dateKnjizenja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateKnjizenja.Location = New System.Drawing.Point(79, 25)
        Me.dateKnjizenja.Name = "dateKnjizenja"
        Me.dateKnjizenja.Size = New System.Drawing.Size(85, 20)
        Me.dateKnjizenja.TabIndex = 14
        '
        'txtBroj
        '
        Me.txtBroj.BackColor = System.Drawing.Color.GhostWhite
        Me.txtBroj.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBroj.Location = New System.Drawing.Point(11, 25)
        Me.txtBroj.Name = "txtBroj"
        Me.txtBroj.Size = New System.Drawing.Size(62, 20)
        Me.txtBroj.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Broj"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KontaBindingSource
        '
        Me.KontaBindingSource.DataMember = "konta"
        Me.KontaBindingSource.DataSource = Me.DataSet1
        '
        'KontaTableAdapter
        '
        Me.KontaTableAdapter.ClearBeforeFill = True
        '
        'PartneriBindingSource
        '
        Me.PartneriBindingSource.DataMember = "partneri"
        Me.PartneriBindingSource.DataSource = Me.DataSet1
        '
        'PartneriTableAdapter
        '
        Me.PartneriTableAdapter.ClearBeforeFill = True
        '
        'cRb
        '
        Me.cRb.HeaderText = "Rb"
        Me.cRb.Name = "cRb"
        Me.cRb.Width = 40
        '
        'cKonto
        '
        Me.cKonto.DataSource = Me.KontaBindingSource
        Me.cKonto.DisplayMember = "konto"
        Me.cKonto.HeaderText = "Konto"
        Me.cKonto.Name = "cKonto"
        Me.cKonto.ValueMember = "konto"
        Me.cKonto.Width = 80
        '
        'cPartner
        '
        Me.cPartner.DataSource = Me.PartneriBindingSource
        Me.cPartner.DisplayMember = "sifra"
        Me.cPartner.HeaderText = "Partner"
        Me.cPartner.Name = "cPartner"
        Me.cPartner.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cPartner.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cPartner.ValueMember = "sifra"
        Me.cPartner.Width = 70
        '
        'cOpis
        '
        Me.cOpis.HeaderText = "Opis"
        Me.cOpis.Name = "cOpis"
        Me.cOpis.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cOpis.Width = 230
        '
        'cIznos
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.cIznos.DefaultCellStyle = DataGridViewCellStyle1
        Me.cIznos.HeaderText = "Duguje"
        Me.cIznos.Name = "cIznos"
        Me.cIznos.Width = 90
        '
        'cPotrazuje
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.cPotrazuje.DefaultCellStyle = DataGridViewCellStyle2
        Me.cPotrazuje.HeaderText = "Potražuje"
        Me.cPotrazuje.Name = "cPotrazuje"
        Me.cPotrazuje.Width = 90
        '
        'frmNalogEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(669, 401)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPotrazuje)
        Me.Controls.Add(Me.txtDuguje)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgStavke)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNalogEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nalog - Edit"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgStavke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KontaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartneriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbSnimi As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbProknjizi As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbEnd As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPotrazuje As System.Windows.Forms.TextBox
    Friend WithEvents txtDuguje As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgStavke As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents labProknjizen As System.Windows.Forms.Label
    Friend WithEvents btnNoviPartner As System.Windows.Forms.Button
    Friend WithEvents btnOsvezi As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dateKnjizenja As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBroj As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As Farma.DataSet1
    Friend WithEvents KontaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KontaTableAdapter As Farma.DataSet1TableAdapters.fn_kontaTableAdapter
    Friend WithEvents PartneriBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartneriTableAdapter As Farma.DataSet1TableAdapters.app_partneriTableAdapter
    Friend WithEvents cRb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cKonto As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cPartner As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cOpis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cIznos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPotrazuje As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
