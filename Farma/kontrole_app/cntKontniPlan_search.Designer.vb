<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntKontniPlan_search
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.mPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.btnPronadji = New System.Windows.Forms.Button
        Me.txtSifra = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.chkSifra = New System.Windows.Forms.CheckBox
        Me.chkDozvoljenoKnj = New System.Windows.Forms.CheckBox
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.tlbABC = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.labCount = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.mPanel.SuspendLayout()
        Me.mPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'mPanel
        '
        Me.mPanel.ColumnCount = 2
        Me.mPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.95148!))
        Me.mPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.04852!))
        Me.mPanel.Controls.Add(Me.Label5, 0, 0)
        Me.mPanel.Controls.Add(Me.mPanel2, 0, 2)
        Me.mPanel.Controls.Add(Me.TableLayoutPanel3, 1, 2)
        Me.mPanel.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.mPanel.Location = New System.Drawing.Point(16, 19)
        Me.mPanel.Name = "mPanel"
        Me.mPanel.RowCount = 3
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 169.0!))
        Me.mPanel.Size = New System.Drawing.Size(742, 199)
        Me.mPanel.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.mPanel.SetColumnSpan(Me.Label5, 2)
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(736, 32)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "IZABERITE OPCIJE PRETRAGE "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mPanel2
        '
        Me.mPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mPanel2.ColumnCount = 2
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 5)
        Me.mPanel2.Controls.Add(Me.txtSifra, 1, 0)
        Me.mPanel2.Controls.Add(Me.TableLayoutPanel2, 0, 4)
        Me.mPanel2.Controls.Add(Me.chkSifra, 0, 0)
        Me.mPanel2.Controls.Add(Me.chkDozvoljenoKnj, 1, 2)
        Me.mPanel2.Location = New System.Drawing.Point(3, 41)
        Me.mPanel2.Name = "mPanel2"
        Me.mPanel2.RowCount = 7
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.mPanel2.Size = New System.Drawing.Size(423, 144)
        Me.mPanel2.TabIndex = 31
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.mPanel2.SetColumnSpan(Me.TableLayoutPanel1, 2)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.80323!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.19677!))
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPronadji, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 102)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(417, 30)
        Me.TableLayoutPanel1.TabIndex = 39
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.CheckBox1.Location = New System.Drawing.Point(3, 5)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(255, 19)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Složi po abecednom redu"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnPronadji
        '
        Me.btnPronadji.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnPronadji.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPronadji.Location = New System.Drawing.Point(314, 3)
        Me.btnPronadji.Name = "btnPronadji"
        Me.btnPronadji.Size = New System.Drawing.Size(100, 24)
        Me.btnPronadji.TabIndex = 29
        Me.btnPronadji.Text = "PRONADJI"
        Me.btnPronadji.UseVisualStyleBackColor = True
        '
        'txtSifra
        '
        Me.txtSifra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSifra.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSifra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSifra.Location = New System.Drawing.Point(123, 3)
        Me.txtSifra.Name = "txtSifra"
        Me.txtSifra.Size = New System.Drawing.Size(297, 21)
        Me.txtSifra.TabIndex = 9
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.mPanel2.SetColumnSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 94)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(417, 2)
        Me.TableLayoutPanel2.TabIndex = 37
        '
        'chkSifra
        '
        Me.chkSifra.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkSifra.AutoSize = True
        Me.chkSifra.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkSifra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkSifra.Location = New System.Drawing.Point(3, 4)
        Me.chkSifra.Name = "chkSifra"
        Me.chkSifra.Size = New System.Drawing.Size(61, 19)
        Me.chkSifra.TabIndex = 23
        Me.chkSifra.Text = "ŠIFRA"
        Me.chkSifra.UseVisualStyleBackColor = True
        '
        'chkDozvoljenoKnj
        '
        Me.chkDozvoljenoKnj.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkDozvoljenoKnj.AutoSize = True
        Me.chkDozvoljenoKnj.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkDozvoljenoKnj.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkDozvoljenoKnj.Location = New System.Drawing.Point(123, 58)
        Me.chkDozvoljenoKnj.Name = "chkDozvoljenoKnj"
        Me.chkDozvoljenoKnj.Size = New System.Drawing.Size(169, 19)
        Me.chkDozvoljenoKnj.TabIndex = 22
        Me.chkDozvoljenoKnj.Text = "DOZVOLJENO KNJIŽENJE"
        Me.chkDozvoljenoKnj.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.tlbABC, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(432, 41)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(307, 137)
        Me.TableLayoutPanel3.TabIndex = 40
        '
        'tlbABC
        '
        Me.tlbABC.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tlbABC.ColumnCount = 1
        Me.TableLayoutPanel3.SetColumnSpan(Me.tlbABC, 3)
        Me.tlbABC.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlbABC.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlbABC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlbABC.Location = New System.Drawing.Point(3, 94)
        Me.tlbABC.Name = "tlbABC"
        Me.tlbABC.RowCount = 1
        Me.tlbABC.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbABC.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlbABC.Size = New System.Drawing.Size(301, 2)
        Me.tlbABC.TabIndex = 33
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel3.SetColumnSpan(Me.TableLayoutPanel4, 3)
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.78685!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.21315!))
        Me.TableLayoutPanel4.Controls.Add(Me.labCount, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel4.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 102)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(301, 24)
        Me.TableLayoutPanel4.TabIndex = 38
        '
        'labCount
        '
        Me.labCount.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.labCount.AutoSize = True
        Me.labCount.Location = New System.Drawing.Point(104, 4)
        Me.labCount.Name = "labCount"
        Me.labCount.Size = New System.Drawing.Size(12, 15)
        Me.labCount.TabIndex = 34
        Me.labCount.Text = "."
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(11, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 24)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Pronadjeno je"
        '
        'cntKontniPlan_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.mPanel)
        Me.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntKontniPlan_search"
        Me.Size = New System.Drawing.Size(789, 236)
        Me.mPanel.ResumeLayout(False)
        Me.mPanel.PerformLayout()
        Me.mPanel2.ResumeLayout(False)
        Me.mPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtSifra As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkSifra As System.Windows.Forms.CheckBox
    Friend WithEvents chkDozvoljenoKnj As System.Windows.Forms.CheckBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlbABC As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents labCount As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnPronadji As System.Windows.Forms.Button

End Class
