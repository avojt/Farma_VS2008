<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemaEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSemaEdit))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tlbSnimi = New System.Windows.Forms.ToolStripButton
        Me.tlbEnd = New System.Windows.Forms.ToolStripButton
        Me.dgStavke = New System.Windows.Forms.DataGridView
        Me.cRb = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cKonto = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.KontaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Farma.DataSet1
        Me.cPartner = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.cStrana = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbSifra = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNaziv = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.KontaTableAdapter = New Farma.DataSet1TableAdapters.fn_kontaTableAdapter
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgStavke, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KontaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbSnimi, Me.tlbEnd})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(379, 25)
        Me.ToolStrip1.TabIndex = 28
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
        'dgStavke
        '
        Me.dgStavke.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.dgStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStavke.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cRb, Me.cKonto, Me.cPartner, Me.cStrana})
        Me.dgStavke.Location = New System.Drawing.Point(12, 106)
        Me.dgStavke.Name = "dgStavke"
        Me.dgStavke.Size = New System.Drawing.Size(351, 220)
        Me.dgStavke.TabIndex = 89
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
        Me.cPartner.HeaderText = "Grupa"
        Me.cPartner.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cPartner.Name = "cPartner"
        Me.cPartner.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cPartner.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cPartner.Width = 60
        '
        'cStrana
        '
        Me.cStrana.HeaderText = "Strana"
        Me.cStrana.Items.AddRange(New Object() {"duguje", "potrazuje"})
        Me.cStrana.Name = "cStrana"
        Me.cStrana.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cStrana.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cStrana.Width = 120
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel1.Controls.Add(Me.cmbSifra)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtNaziv)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(351, 64)
        Me.Panel1.TabIndex = 88
        '
        'cmbSifra
        '
        Me.cmbSifra.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbSifra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbSifra.FormattingEnabled = True
        Me.cmbSifra.Location = New System.Drawing.Point(11, 24)
        Me.cmbSifra.Name = "cmbSifra"
        Me.cmbSifra.Size = New System.Drawing.Size(70, 21)
        Me.cmbSifra.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Šifra"
        '
        'txtNaziv
        '
        Me.txtNaziv.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNaziv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNaziv.Location = New System.Drawing.Point(87, 25)
        Me.txtNaziv.Name = "txtNaziv"
        Me.txtNaziv.Size = New System.Drawing.Size(250, 20)
        Me.txtNaziv.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(84, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Naziv šeme"
        '
        'KontaTableAdapter
        '
        Me.KontaTableAdapter.ClearBeforeFill = True
        '
        'frmSemaEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(379, 338)
        Me.Controls.Add(Me.dgStavke)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSemaEdit"
        Me.Text = "Šema - Edit"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgStavke, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KontaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbSnimi As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbEnd As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgStavke As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbSifra As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNaziv As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As Farma.DataSet1
    Friend WithEvents KontaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KontaTableAdapter As Farma.DataSet1TableAdapters.fn_kontaTableAdapter
    Friend WithEvents cRb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cKonto As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cPartner As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cStrana As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
