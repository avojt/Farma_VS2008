<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntFO_edit
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tblMain = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSkraceno = New System.Windows.Forms.TextBox
        Me.txtNaziv = New System.Windows.Forms.TextBox
        Me.txtSifra = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnSnimi = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.tblMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblMain
        '
        Me.tblMain.BackColor = System.Drawing.Color.Lavender
        Me.tblMain.ColumnCount = 3
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 331.0!))
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104.0!))
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMain.Controls.Add(Me.Panel1, 0, 1)
        Me.tblMain.Controls.Add(Me.btnSnimi, 1, 3)
        Me.tblMain.Controls.Add(Me.btnCancel, 2, 3)
        Me.tblMain.ForeColor = System.Drawing.Color.MidnightBlue
        Me.tblMain.Location = New System.Drawing.Point(14, 14)
        Me.tblMain.Name = "tblMain"
        Me.tblMain.RowCount = 5
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMain.Size = New System.Drawing.Size(555, 308)
        Me.tblMain.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tblMain.SetColumnSpan(Me.Panel1, 3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtSkraceno)
        Me.Panel1.Controls.Add(Me.txtNaziv)
        Me.Panel1.Controls.Add(Me.txtSifra)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 66)
        Me.Panel1.TabIndex = 102
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(435, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Skraćeni naziv"
        '
        'txtSkraceno
        '
        Me.txtSkraceno.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtSkraceno.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSkraceno.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSkraceno.Location = New System.Drawing.Point(435, 25)
        Me.txtSkraceno.Name = "txtSkraceno"
        Me.txtSkraceno.Size = New System.Drawing.Size(100, 20)
        Me.txtSkraceno.TabIndex = 12
        '
        'txtNaziv
        '
        Me.txtNaziv.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNaziv.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNaziv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNaziv.Location = New System.Drawing.Point(118, 25)
        Me.txtNaziv.Name = "txtNaziv"
        Me.txtNaziv.Size = New System.Drawing.Size(311, 20)
        Me.txtNaziv.TabIndex = 2
        '
        'txtSifra
        '
        Me.txtSifra.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtSifra.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSifra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSifra.Location = New System.Drawing.Point(11, 25)
        Me.txtSifra.Name = "txtSifra"
        Me.txtSifra.Size = New System.Drawing.Size(101, 20)
        Me.txtSifra.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(8, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Šifra"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(115, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Naziv"
        '
        'btnSnimi
        '
        Me.btnSnimi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSnimi.Location = New System.Drawing.Point(334, 111)
        Me.btnSnimi.Name = "btnSnimi"
        Me.btnSnimi.Size = New System.Drawing.Size(75, 23)
        Me.btnSnimi.TabIndex = 159
        Me.btnSnimi.Text = "SNIMI"
        Me.btnSnimi.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCancel.Location = New System.Drawing.Point(438, 111)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 160
        Me.btnCancel.Text = "OTKAŽI"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cntFO_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.tblMain)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntFO_edit"
        Me.Size = New System.Drawing.Size(587, 341)
        Me.tblMain.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSkraceno As System.Windows.Forms.TextBox
    Friend WithEvents txtNaziv As System.Windows.Forms.TextBox
    Friend WithEvents txtSifra As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSnimi As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button

End Class
