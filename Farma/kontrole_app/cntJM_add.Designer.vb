<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntJM_add
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
        Me.txtOznaka = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNaziv = New System.Windows.Forms.TextBox
        Me.txtSifra = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnSnimi = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.rbt3 = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.rbt2 = New System.Windows.Forms.RadioButton
        Me.rbt0 = New System.Windows.Forms.RadioButton
        Me.tblMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblMain
        '
        Me.tblMain.BackColor = System.Drawing.Color.Lavender
        Me.tblMain.ColumnCount = 3
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340.0!))
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMain.Controls.Add(Me.Panel1, 0, 1)
        Me.tblMain.Controls.Add(Me.btnSnimi, 1, 3)
        Me.tblMain.Controls.Add(Me.rbt2, 1, 2)
        Me.tblMain.Controls.Add(Me.btnCancel, 2, 3)
        Me.tblMain.Controls.Add(Me.TableLayoutPanel1, 0, 2)
        Me.tblMain.ForeColor = System.Drawing.Color.MidnightBlue
        Me.tblMain.Location = New System.Drawing.Point(12, 3)
        Me.tblMain.Name = "tblMain"
        Me.tblMain.RowCount = 5
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMain.Size = New System.Drawing.Size(555, 205)
        Me.tblMain.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tblMain.SetColumnSpan(Me.Panel1, 3)
        Me.Panel1.Controls.Add(Me.txtOznaka)
        Me.Panel1.Controls.Add(Me.Label1)
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
        'txtOznaka
        '
        Me.txtOznaka.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtOznaka.BackColor = System.Drawing.Color.GhostWhite
        Me.txtOznaka.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtOznaka.Location = New System.Drawing.Point(435, 25)
        Me.txtOznaka.Name = "txtOznaka"
        Me.txtOznaka.Size = New System.Drawing.Size(100, 20)
        Me.txtOznaka.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(432, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Oznaka"
        '
        'txtNaziv
        '
        Me.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.Left
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
        Me.btnSnimi.Location = New System.Drawing.Point(343, 135)
        Me.btnSnimi.Name = "btnSnimi"
        Me.btnSnimi.Size = New System.Drawing.Size(75, 24)
        Me.btnSnimi.TabIndex = 159
        Me.btnSnimi.Text = "SNIMI"
        Me.btnSnimi.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCancel.Location = New System.Drawing.Point(443, 135)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 24)
        Me.btnCancel.TabIndex = 160
        Me.btnCancel.Text = "OTKAŽI"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.rbt0, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.rbt3, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 97)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(334, 32)
        Me.TableLayoutPanel1.TabIndex = 164
        '
        'rbt3
        '
        Me.rbt3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbt3.AutoSize = True
        Me.rbt3.Location = New System.Drawing.Point(197, 7)
        Me.rbt3.Name = "rbt3"
        Me.rbt3.Size = New System.Drawing.Size(31, 17)
        Me.rbt3.TabIndex = 2
        Me.rbt3.TabStop = True
        Me.rbt3.Text = "3"
        Me.rbt3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Broj decimala"
        '
        'rbt2
        '
        Me.rbt2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbt2.AutoSize = True
        Me.rbt2.Location = New System.Drawing.Point(343, 104)
        Me.rbt2.Name = "rbt2"
        Me.rbt2.Size = New System.Drawing.Size(31, 17)
        Me.rbt2.TabIndex = 1
        Me.rbt2.TabStop = True
        Me.rbt2.Text = "2"
        Me.rbt2.UseVisualStyleBackColor = True
        Me.rbt2.Visible = False
        '
        'rbt0
        '
        Me.rbt0.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbt0.AutoSize = True
        Me.rbt0.Location = New System.Drawing.Point(127, 7)
        Me.rbt0.Name = "rbt0"
        Me.rbt0.Size = New System.Drawing.Size(31, 17)
        Me.rbt0.TabIndex = 0
        Me.rbt0.TabStop = True
        Me.rbt0.Text = "0"
        Me.rbt0.UseVisualStyleBackColor = True
        '
        'cntJM_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.tblMain)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntJM_add"
        Me.Size = New System.Drawing.Size(591, 228)
        Me.tblMain.ResumeLayout(False)
        Me.tblMain.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtNaziv As System.Windows.Forms.TextBox
    Friend WithEvents txtSifra As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSnimi As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtOznaka As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rbt3 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbt2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbt0 As System.Windows.Forms.RadioButton

End Class
