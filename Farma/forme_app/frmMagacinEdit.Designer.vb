<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMagacinEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMagacinEdit))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tlbSnimi = New System.Windows.Forms.ToolStripButton
        Me.tlbEnd = New System.Windows.Forms.ToolStripButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbVodjenjeZliha = New System.Windows.Forms.ComboBox
        Me.cmbVrstaMagacin = New System.Windows.Forms.ComboBox
        Me.chkVodjenjeZaliha = New System.Windows.Forms.CheckBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtNaziv = New System.Windows.Forms.TextBox
        Me.txtSifra = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbSnimi, Me.tlbEnd})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(388, 25)
        Me.ToolStrip1.TabIndex = 5
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Vrsta magacina"
        '
        'cmbVodjenjeZliha
        '
        Me.cmbVodjenjeZliha.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbVodjenjeZliha.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbVodjenjeZliha.FormattingEnabled = True
        Me.cmbVodjenjeZliha.Location = New System.Drawing.Point(131, 147)
        Me.cmbVodjenjeZliha.Name = "cmbVodjenjeZliha"
        Me.cmbVodjenjeZliha.Size = New System.Drawing.Size(241, 21)
        Me.cmbVodjenjeZliha.TabIndex = 33
        '
        'cmbVrstaMagacin
        '
        Me.cmbVrstaMagacin.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbVrstaMagacin.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbVrstaMagacin.FormattingEnabled = True
        Me.cmbVrstaMagacin.Location = New System.Drawing.Point(131, 120)
        Me.cmbVrstaMagacin.Name = "cmbVrstaMagacin"
        Me.cmbVrstaMagacin.Size = New System.Drawing.Size(241, 21)
        Me.cmbVrstaMagacin.TabIndex = 32
        '
        'chkVodjenjeZaliha
        '
        Me.chkVodjenjeZaliha.AutoSize = True
        Me.chkVodjenjeZaliha.Location = New System.Drawing.Point(28, 151)
        Me.chkVodjenjeZaliha.Name = "chkVodjenjeZaliha"
        Me.chkVodjenjeZaliha.Size = New System.Drawing.Size(97, 17)
        Me.chkVodjenjeZaliha.TabIndex = 30
        Me.chkVodjenjeZaliha.Text = "Vodjenje zaliha"
        Me.chkVodjenjeZaliha.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel1.Controls.Add(Me.txtNaziv)
        Me.Panel1.Controls.Add(Me.txtSifra)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 64)
        Me.Panel1.TabIndex = 31
        '
        'txtNaziv
        '
        Me.txtNaziv.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNaziv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNaziv.Location = New System.Drawing.Point(74, 25)
        Me.txtNaziv.Name = "txtNaziv"
        Me.txtNaziv.Size = New System.Drawing.Size(270, 20)
        Me.txtNaziv.TabIndex = 2
        '
        'txtSifra
        '
        Me.txtSifra.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSifra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSifra.Location = New System.Drawing.Point(11, 25)
        Me.txtSifra.Name = "txtSifra"
        Me.txtSifra.Size = New System.Drawing.Size(57, 20)
        Me.txtSifra.TabIndex = 1
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
        Me.Label2.Location = New System.Drawing.Point(74, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Naziv"
        '
        'frmMagacinEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(388, 204)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbVodjenjeZliha)
        Me.Controls.Add(Me.cmbVrstaMagacin)
        Me.Controls.Add(Me.chkVodjenjeZaliha)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMagacinEdit"
        Me.Text = "Magacin - Edit"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbSnimi As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbEnd As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbVodjenjeZliha As System.Windows.Forms.ComboBox
    Friend WithEvents cmbVrstaMagacin As System.Windows.Forms.ComboBox
    Friend WithEvents chkVodjenjeZaliha As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtNaziv As System.Windows.Forms.TextBox
    Friend WithEvents txtSifra As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
