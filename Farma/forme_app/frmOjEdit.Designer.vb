<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOjEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOjEdit))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tlbSnimi = New System.Windows.Forms.ToolStripButton
        Me.tlbEnd = New System.Windows.Forms.ToolStripButton
        Me.cmbVrsta = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtNaziv = New System.Windows.Forms.TextBox
        Me.txtSifra = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkStrukturna = New System.Windows.Forms.CheckBox
        Me.txtAdreas = New System.Windows.Forms.TextBox
        Me.cmbGrad = New System.Windows.Forms.ComboBox
        Me.cmbOpstina = New System.Windows.Forms.ComboBox
        Me.cmbMesto = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbSnimi, Me.tlbEnd})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(417, 25)
        Me.ToolStrip1.TabIndex = 24
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
        'cmbVrsta
        '
        Me.cmbVrsta.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbVrsta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbVrsta.FormattingEnabled = True
        Me.cmbVrsta.Location = New System.Drawing.Point(71, 227)
        Me.cmbVrsta.Name = "cmbVrsta"
        Me.cmbVrsta.Size = New System.Drawing.Size(315, 21)
        Me.cmbVrsta.TabIndex = 67
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtNaziv)
        Me.Panel1.Controls.Add(Me.txtSifra)
        Me.Panel1.Location = New System.Drawing.Point(14, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(388, 64)
        Me.Panel1.TabIndex = 66
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(8, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Šifra"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(100, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Naziv"
        '
        'txtNaziv
        '
        Me.txtNaziv.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNaziv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNaziv.Location = New System.Drawing.Point(103, 25)
        Me.txtNaziv.Name = "txtNaziv"
        Me.txtNaziv.Size = New System.Drawing.Size(269, 20)
        Me.txtNaziv.TabIndex = 6
        '
        'txtSifra
        '
        Me.txtSifra.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSifra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSifra.Location = New System.Drawing.Point(11, 25)
        Me.txtSifra.Name = "txtSifra"
        Me.txtSifra.Size = New System.Drawing.Size(86, 20)
        Me.txtSifra.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Adresa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Grad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Opština"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Vrsta"
        '
        'chkStrukturna
        '
        Me.chkStrukturna.AutoSize = True
        Me.chkStrukturna.Location = New System.Drawing.Point(71, 254)
        Me.chkStrukturna.Name = "chkStrukturna"
        Me.chkStrukturna.Size = New System.Drawing.Size(114, 17)
        Me.chkStrukturna.TabIndex = 61
        Me.chkStrukturna.Text = "Strukturna jedinica"
        Me.chkStrukturna.UseVisualStyleBackColor = True
        '
        'txtAdreas
        '
        Me.txtAdreas.BackColor = System.Drawing.Color.GhostWhite
        Me.txtAdreas.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAdreas.Location = New System.Drawing.Point(71, 120)
        Me.txtAdreas.Name = "txtAdreas"
        Me.txtAdreas.Size = New System.Drawing.Size(315, 20)
        Me.txtAdreas.TabIndex = 60
        '
        'cmbGrad
        '
        Me.cmbGrad.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbGrad.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbGrad.FormattingEnabled = True
        Me.cmbGrad.Location = New System.Drawing.Point(71, 146)
        Me.cmbGrad.Name = "cmbGrad"
        Me.cmbGrad.Size = New System.Drawing.Size(315, 21)
        Me.cmbGrad.TabIndex = 59
        '
        'cmbOpstina
        '
        Me.cmbOpstina.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbOpstina.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbOpstina.FormattingEnabled = True
        Me.cmbOpstina.Location = New System.Drawing.Point(71, 173)
        Me.cmbOpstina.Name = "cmbOpstina"
        Me.cmbOpstina.Size = New System.Drawing.Size(315, 21)
        Me.cmbOpstina.TabIndex = 58
        '
        'cmbMesto
        '
        Me.cmbMesto.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbMesto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbMesto.FormattingEnabled = True
        Me.cmbMesto.Location = New System.Drawing.Point(71, 200)
        Me.cmbMesto.Name = "cmbMesto"
        Me.cmbMesto.Size = New System.Drawing.Size(315, 21)
        Me.cmbMesto.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Mesto"
        '
        'frmOjEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(417, 293)
        Me.Controls.Add(Me.cmbMesto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbVrsta)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkStrukturna)
        Me.Controls.Add(Me.txtAdreas)
        Me.Controls.Add(Me.cmbGrad)
        Me.Controls.Add(Me.cmbOpstina)
        Me.Controls.Add(Me.ToolStrip1)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOjEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Org.Jedinice - Edit"
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
    Friend WithEvents cmbVrsta As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNaziv As System.Windows.Forms.TextBox
    Friend WithEvents txtSifra As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkStrukturna As System.Windows.Forms.CheckBox
    Friend WithEvents txtAdreas As System.Windows.Forms.TextBox
    Friend WithEvents cmbGrad As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOpstina As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMesto As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
