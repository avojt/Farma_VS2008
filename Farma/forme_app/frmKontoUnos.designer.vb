<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKontoUnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKontoUnos))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tlbSnimi = New System.Windows.Forms.ToolStripButton
        Me.tlbEnd = New System.Windows.Forms.ToolStripButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkDevizni = New System.Windows.Forms.CheckBox
        Me.chkDozvoljeno = New System.Windows.Forms.CheckBox
        Me.txtNaziv = New System.Windows.Forms.TextBox
        Me.txtKonto = New System.Windows.Forms.TextBox
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
        Me.ToolStrip1.Size = New System.Drawing.Size(537, 25)
        Me.ToolStrip1.TabIndex = 3
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel1.Controls.Add(Me.chkDevizni)
        Me.Panel1.Controls.Add(Me.chkDozvoljeno)
        Me.Panel1.Controls.Add(Me.txtNaziv)
        Me.Panel1.Controls.Add(Me.txtKonto)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(511, 64)
        Me.Panel1.TabIndex = 25
        '
        'chkDevizni
        '
        Me.chkDevizni.AutoSize = True
        Me.chkDevizni.CheckAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.chkDevizni.Location = New System.Drawing.Point(440, 28)
        Me.chkDevizni.Name = "chkDevizni"
        Me.chkDevizni.Size = New System.Drawing.Size(61, 17)
        Me.chkDevizni.TabIndex = 13
        Me.chkDevizni.Text = "Devizni"
        Me.chkDevizni.UseVisualStyleBackColor = True
        '
        'chkDozvoljeno
        '
        Me.chkDozvoljeno.CheckAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.chkDozvoljeno.Location = New System.Drawing.Point(352, 15)
        Me.chkDozvoljeno.Name = "chkDozvoljeno"
        Me.chkDozvoljeno.Size = New System.Drawing.Size(82, 30)
        Me.chkDozvoljeno.TabIndex = 12
        Me.chkDozvoljeno.Text = "Dozvoljeno knjiženje"
        Me.chkDozvoljeno.UseVisualStyleBackColor = True
        '
        'txtNaziv
        '
        Me.txtNaziv.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNaziv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNaziv.Location = New System.Drawing.Point(74, 25)
        Me.txtNaziv.Name = "txtNaziv"
        Me.txtNaziv.Size = New System.Drawing.Size(272, 20)
        Me.txtNaziv.TabIndex = 2
        '
        'txtKonto
        '
        Me.txtKonto.BackColor = System.Drawing.Color.GhostWhite
        Me.txtKonto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtKonto.Location = New System.Drawing.Point(11, 25)
        Me.txtKonto.Name = "txtKonto"
        Me.txtKonto.Size = New System.Drawing.Size(57, 20)
        Me.txtKonto.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Konto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(74, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Opis"
        '
        'frmKontoUnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(537, 116)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKontoUnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Konto - Unos"
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkDevizni As System.Windows.Forms.CheckBox
    Friend WithEvents chkDozvoljeno As System.Windows.Forms.CheckBox
    Friend WithEvents txtNaziv As System.Windows.Forms.TextBox
    Friend WithEvents txtKonto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
