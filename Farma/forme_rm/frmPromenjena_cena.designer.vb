<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPromenjena_cena
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPromenjena_cena))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkNivelacija = New System.Windows.Forms.CheckBox
        Me.chkNoviArtikl = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnOdustani = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PromFarmali ste prodajnu cenu!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Izaberite opciju daljeg rada:"
        '
        'chkNivelacija
        '
        Me.chkNivelacija.AutoSize = True
        Me.chkNivelacija.Location = New System.Drawing.Point(41, 58)
        Me.chkNivelacija.Name = "chkNivelacija"
        Me.chkNivelacija.Size = New System.Drawing.Size(129, 17)
        Me.chkNivelacija.TabIndex = 2
        Me.chkNivelacija.Text = "Izrada nivelacije cena"
        Me.chkNivelacija.UseVisualStyleBackColor = True
        '
        'chkNoviArtikl
        '
        Me.chkNoviArtikl.AutoSize = True
        Me.chkNoviArtikl.Location = New System.Drawing.Point(41, 82)
        Me.chkNoviArtikl.Name = "chkNoviArtikl"
        Me.chkNoviArtikl.Size = New System.Drawing.Size(142, 17)
        Me.chkNoviArtikl.TabIndex = 3
        Me.chkNoviArtikl.Text = "Dodavanje novog artikla"
        Me.chkNoviArtikl.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(306, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Nastavi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnOdustani
        '
        Me.btnOdustani.Location = New System.Drawing.Point(225, 76)
        Me.btnOdustani.Name = "btnOdustani"
        Me.btnOdustani.Size = New System.Drawing.Size(75, 23)
        Me.btnOdustani.TabIndex = 5
        Me.btnOdustani.Text = "Odustani"
        Me.btnOdustani.UseVisualStyleBackColor = True
        '
        'frmPromenjena_cena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(393, 114)
        Me.Controls.Add(Me.btnOdustani)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkNoviArtikl)
        Me.Controls.Add(Me.chkNivelacija)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPromenjena_cena"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Promenjena cena artikla"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkNivelacija As System.Windows.Forms.CheckBox
    Friend WithEvents chkNoviArtikl As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnOdustani As System.Windows.Forms.Button
End Class
