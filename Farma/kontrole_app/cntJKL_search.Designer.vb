<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntJKL_search
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
        Me.mPanel = New System.Windows.Forms.TableLayoutPanel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.mPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.btnPronadji = New System.Windows.Forms.Button
        Me.chkSifra = New System.Windows.Forms.CheckBox
        Me.chkNaziv = New System.Windows.Forms.CheckBox
        Me.txtSifra = New System.Windows.Forms.TextBox
        Me.txtNaziv = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.labCount = New System.Windows.Forms.Label
        Me.mPanel.SuspendLayout()
        Me.mPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mPanel
        '
        Me.mPanel.ColumnCount = 2
        Me.mPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.07185!))
        Me.mPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.92814!))
        Me.mPanel.Controls.Add(Me.Panel2, 0, 1)
        Me.mPanel.Controls.Add(Me.Label3, 0, 0)
        Me.mPanel.Controls.Add(Me.mPanel2, 0, 2)
        Me.mPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mPanel.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.mPanel.Location = New System.Drawing.Point(0, 0)
        Me.mPanel.Name = "mPanel"
        Me.mPanel.RowCount = 3
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 169.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.mPanel.Size = New System.Drawing.Size(668, 175)
        Me.mPanel.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.mPanel.SetColumnSpan(Me.Panel2, 2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(662, 1)
        Me.Panel2.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 15)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "IZABERITE OPCIJE PRETRAGE "
        '
        'mPanel2
        '
        Me.mPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mPanel2.ColumnCount = 2
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.04038!))
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.95962!))
        Me.mPanel2.Controls.Add(Me.btnPronadji, 1, 3)
        Me.mPanel2.Controls.Add(Me.chkSifra, 0, 0)
        Me.mPanel2.Controls.Add(Me.chkNaziv, 0, 1)
        Me.mPanel2.Controls.Add(Me.txtSifra, 1, 0)
        Me.mPanel2.Controls.Add(Me.txtNaziv, 1, 1)
        Me.mPanel2.Controls.Add(Me.Label1, 0, 2)
        Me.mPanel2.Controls.Add(Me.labCount, 1, 2)
        Me.mPanel2.Location = New System.Drawing.Point(3, 44)
        Me.mPanel2.Name = "mPanel2"
        Me.mPanel2.RowCount = 5
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mPanel2.Size = New System.Drawing.Size(422, 125)
        Me.mPanel2.TabIndex = 31
        '
        'btnPronadji
        '
        Me.btnPronadji.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPronadji.Location = New System.Drawing.Point(100, 84)
        Me.btnPronadji.Name = "btnPronadji"
        Me.btnPronadji.Size = New System.Drawing.Size(100, 24)
        Me.btnPronadji.TabIndex = 29
        Me.btnPronadji.Text = "PRONADJI"
        Me.btnPronadji.UseVisualStyleBackColor = True
        '
        'chkSifra
        '
        Me.chkSifra.AutoSize = True
        Me.chkSifra.Location = New System.Drawing.Point(3, 3)
        Me.chkSifra.Name = "chkSifra"
        Me.chkSifra.Size = New System.Drawing.Size(53, 19)
        Me.chkSifra.TabIndex = 31
        Me.chkSifra.Text = "Šifra"
        Me.chkSifra.UseVisualStyleBackColor = True
        '
        'chkNaziv
        '
        Me.chkNaziv.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkNaziv.AutoSize = True
        Me.chkNaziv.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkNaziv.Location = New System.Drawing.Point(3, 31)
        Me.chkNaziv.Name = "chkNaziv"
        Me.chkNaziv.Size = New System.Drawing.Size(63, 19)
        Me.chkNaziv.TabIndex = 22
        Me.chkNaziv.Text = "NAZIV"
        Me.chkNaziv.UseVisualStyleBackColor = True
        '
        'txtSifra
        '
        Me.txtSifra.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtSifra.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSifra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSifra.Location = New System.Drawing.Point(100, 3)
        Me.txtSifra.Name = "txtSifra"
        Me.txtSifra.Size = New System.Drawing.Size(222, 21)
        Me.txtSifra.TabIndex = 30
        '
        'txtNaziv
        '
        Me.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtNaziv.BackColor = System.Drawing.Color.Lavender
        Me.txtNaziv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNaziv.Location = New System.Drawing.Point(100, 30)
        Me.txtNaziv.Name = "txtNaziv"
        Me.txtNaziv.Size = New System.Drawing.Size(222, 21)
        Me.txtNaziv.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Pronadjeno je"
        '
        'labCount
        '
        Me.labCount.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.labCount.AutoSize = True
        Me.labCount.Location = New System.Drawing.Point(100, 60)
        Me.labCount.Name = "labCount"
        Me.labCount.Size = New System.Drawing.Size(11, 15)
        Me.labCount.TabIndex = 33
        Me.labCount.Text = "."
        '
        'cntJKL_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.mPanel)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntJKL_search"
        Me.Size = New System.Drawing.Size(668, 175)
        Me.mPanel.ResumeLayout(False)
        Me.mPanel.PerformLayout()
        Me.mPanel2.ResumeLayout(False)
        Me.mPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkNaziv As System.Windows.Forms.CheckBox
    Friend WithEvents txtNaziv As System.Windows.Forms.TextBox
    Friend WithEvents btnPronadji As System.Windows.Forms.Button
    Friend WithEvents txtSifra As System.Windows.Forms.TextBox
    Friend WithEvents chkSifra As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents labCount As System.Windows.Forms.Label

End Class
