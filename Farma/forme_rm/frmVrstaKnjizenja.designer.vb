<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVrstaKnjizenja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVrstaKnjizenja))
        Me.chkRoba = New System.Windows.Forms.CheckBox
        Me.chkMaterijal = New System.Windows.Forms.CheckBox
        Me.chkUsluge = New System.Windows.Forms.CheckBox
        Me.chkTroskovi = New System.Windows.Forms.CheckBox
        Me.chkOS = New System.Windows.Forms.CheckBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'chkRoba
        '
        Me.chkRoba.AutoSize = True
        Me.chkRoba.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkRoba.Location = New System.Drawing.Point(28, 22)
        Me.chkRoba.Name = "chkRoba"
        Me.chkRoba.Size = New System.Drawing.Size(123, 18)
        Me.chkRoba.TabIndex = 0
        Me.chkRoba.Text = "Ulazni računi - roba"
        Me.chkRoba.UseVisualStyleBackColor = True
        '
        'chkMaterijal
        '
        Me.chkMaterijal.AutoSize = True
        Me.chkMaterijal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkMaterijal.Location = New System.Drawing.Point(28, 45)
        Me.chkMaterijal.Name = "chkMaterijal"
        Me.chkMaterijal.Size = New System.Drawing.Size(140, 18)
        Me.chkMaterijal.TabIndex = 1
        Me.chkMaterijal.Text = "Ulazni računi - materijal"
        Me.chkMaterijal.UseVisualStyleBackColor = True
        '
        'chkUsluge
        '
        Me.chkUsluge.AutoSize = True
        Me.chkUsluge.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkUsluge.Location = New System.Drawing.Point(227, 22)
        Me.chkUsluge.Name = "chkUsluge"
        Me.chkUsluge.Size = New System.Drawing.Size(133, 18)
        Me.chkUsluge.TabIndex = 2
        Me.chkUsluge.Text = "Ulazni računi - usluge"
        Me.chkUsluge.UseVisualStyleBackColor = True
        '
        'chkTroskovi
        '
        Me.chkTroskovi.AutoSize = True
        Me.chkTroskovi.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkTroskovi.Location = New System.Drawing.Point(227, 45)
        Me.chkTroskovi.Name = "chkTroskovi"
        Me.chkTroskovi.Size = New System.Drawing.Size(139, 18)
        Me.chkTroskovi.TabIndex = 3
        Me.chkTroskovi.Text = "Ulazni računi - troškovi"
        Me.chkTroskovi.UseVisualStyleBackColor = True
        '
        'chkOS
        '
        Me.chkOS.AutoSize = True
        Me.chkOS.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkOS.Location = New System.Drawing.Point(28, 68)
        Me.chkOS.Name = "chkOS"
        Me.chkOS.Size = New System.Drawing.Size(189, 18)
        Me.chkOS.TabIndex = 4
        Me.chkOS.Text = "Ulazni računi - osnovno sterdstvo"
        Me.chkOS.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(316, 81)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "Uredu"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmVrstaKnjizenja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(403, 116)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.chkOS)
        Me.Controls.Add(Me.chkTroskovi)
        Me.Controls.Add(Me.chkUsluge)
        Me.Controls.Add(Me.chkMaterijal)
        Me.Controls.Add(Me.chkRoba)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVrstaKnjizenja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vrsta Knjiženja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkRoba As System.Windows.Forms.CheckBox
    Friend WithEvents chkMaterijal As System.Windows.Forms.CheckBox
    Friend WithEvents chkUsluge As System.Windows.Forms.CheckBox
    Friend WithEvents chkTroskovi As System.Windows.Forms.CheckBox
    Friend WithEvents chkOS As System.Windows.Forms.CheckBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
