<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntNaselja_edit
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
        Me.tlbMain = New System.Windows.Forms.TableLayoutPanel
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSnimi = New System.Windows.Forms.Button
        Me.tlbMain_sub = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.rbtGradovi = New System.Windows.Forms.RadioButton
        Me.rbtOpstine = New System.Windows.Forms.RadioButton
        Me.rbtMesta = New System.Windows.Forms.RadioButton
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.panHeader = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtNaziv = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.labLager = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.cmbGradovi = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbOpstine = New System.Windows.Forms.ComboBox
        Me.txtPorJed = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPttBroj = New System.Windows.Forms.TextBox
        Me.tlbMain.SuspendLayout()
        Me.tlbMain_sub.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.panHeader.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlbMain
        '
        Me.tlbMain.ColumnCount = 2
        Me.tlbMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlbMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlbMain.Controls.Add(Me.btnCancel, 1, 1)
        Me.tlbMain.Controls.Add(Me.btnSnimi, 0, 1)
        Me.tlbMain.Controls.Add(Me.tlbMain_sub, 0, 0)
        Me.tlbMain.Location = New System.Drawing.Point(16, 16)
        Me.tlbMain.Name = "tlbMain"
        Me.tlbMain.RowCount = 2
        Me.tlbMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tlbMain.Size = New System.Drawing.Size(628, 326)
        Me.tlbMain.TabIndex = 130
        '
        'btnCancel
        '
        Me.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCancel.Location = New System.Drawing.Point(317, 301)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 21)
        Me.btnCancel.TabIndex = 160
        Me.btnCancel.Text = "OTKAŽI"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSnimi
        '
        Me.btnSnimi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSnimi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSnimi.Location = New System.Drawing.Point(236, 301)
        Me.btnSnimi.Name = "btnSnimi"
        Me.btnSnimi.Size = New System.Drawing.Size(75, 21)
        Me.btnSnimi.TabIndex = 159
        Me.btnSnimi.Text = "SNIMI"
        Me.btnSnimi.UseVisualStyleBackColor = True
        '
        'tlbMain_sub
        '
        Me.tlbMain_sub.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlbMain_sub.BackColor = System.Drawing.Color.Lavender
        Me.tlbMain_sub.ColumnCount = 3
        Me.tlbMain.SetColumnSpan(Me.tlbMain_sub, 2)
        Me.tlbMain_sub.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126.0!))
        Me.tlbMain_sub.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380.0!))
        Me.tlbMain_sub.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbMain_sub.Controls.Add(Me.TableLayoutPanel2, 1, 2)
        Me.tlbMain_sub.Controls.Add(Me.TableLayoutPanel4, 0, 8)
        Me.tlbMain_sub.Controls.Add(Me.panHeader, 0, 0)
        Me.tlbMain_sub.Controls.Add(Me.TableLayoutPanel3, 0, 10)
        Me.tlbMain_sub.Controls.Add(Me.Panel3, 0, 9)
        Me.tlbMain_sub.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.tlbMain_sub.Controls.Add(Me.cmbGradovi, 1, 6)
        Me.tlbMain_sub.Controls.Add(Me.Label2, 0, 6)
        Me.tlbMain_sub.Controls.Add(Me.Label1, 0, 5)
        Me.tlbMain_sub.Controls.Add(Me.cmbOpstine, 1, 5)
        Me.tlbMain_sub.Controls.Add(Me.txtPorJed, 1, 4)
        Me.tlbMain_sub.Controls.Add(Me.Label4, 0, 4)
        Me.tlbMain_sub.Controls.Add(Me.Label3, 0, 3)
        Me.tlbMain_sub.Controls.Add(Me.txtPttBroj, 1, 3)
        Me.tlbMain_sub.ForeColor = System.Drawing.Color.MidnightBlue
        Me.tlbMain_sub.Location = New System.Drawing.Point(3, 3)
        Me.tlbMain_sub.Name = "tlbMain_sub"
        Me.tlbMain_sub.RowCount = 11
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlbMain_sub.Size = New System.Drawing.Size(622, 290)
        Me.tlbMain_sub.TabIndex = 123
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.rbtGradovi, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.rbtOpstine, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.rbtMesta, 2, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(129, 71)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(374, 24)
        Me.TableLayoutPanel2.TabIndex = 130
        '
        'rbtGradovi
        '
        Me.rbtGradovi.AutoSize = True
        Me.rbtGradovi.Location = New System.Drawing.Point(3, 3)
        Me.rbtGradovi.Name = "rbtGradovi"
        Me.rbtGradovi.Size = New System.Drawing.Size(48, 17)
        Me.rbtGradovi.TabIndex = 132
        Me.rbtGradovi.TabStop = True
        Me.rbtGradovi.Text = "Grad"
        Me.rbtGradovi.UseVisualStyleBackColor = True
        '
        'rbtOpstine
        '
        Me.rbtOpstine.AutoSize = True
        Me.rbtOpstine.Location = New System.Drawing.Point(127, 3)
        Me.rbtOpstine.Name = "rbtOpstine"
        Me.rbtOpstine.Size = New System.Drawing.Size(61, 17)
        Me.rbtOpstine.TabIndex = 130
        Me.rbtOpstine.TabStop = True
        Me.rbtOpstine.Text = "Opština"
        Me.rbtOpstine.UseVisualStyleBackColor = True
        '
        'rbtMesta
        '
        Me.rbtMesta.AutoSize = True
        Me.rbtMesta.Location = New System.Drawing.Point(251, 3)
        Me.rbtMesta.Name = "rbtMesta"
        Me.rbtMesta.Size = New System.Drawing.Size(54, 17)
        Me.rbtMesta.TabIndex = 131
        Me.rbtMesta.TabStop = True
        Me.rbtMesta.Text = "Mesto"
        Me.rbtMesta.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.tlbMain_sub.SetColumnSpan(Me.TableLayoutPanel4, 3)
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 251)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(616, 2)
        Me.TableLayoutPanel4.TabIndex = 172
        '
        'panHeader
        '
        Me.panHeader.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tlbMain_sub.SetColumnSpan(Me.panHeader, 3)
        Me.panHeader.Controls.Add(Me.Label11)
        Me.panHeader.Controls.Add(Me.txtNaziv)
        Me.panHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panHeader.Location = New System.Drawing.Point(3, 3)
        Me.panHeader.Name = "panHeader"
        Me.panHeader.Size = New System.Drawing.Size(616, 54)
        Me.panHeader.TabIndex = 102
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Naziv"
        '
        'txtNaziv
        '
        Me.txtNaziv.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNaziv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNaziv.Location = New System.Drawing.Point(15, 24)
        Me.txtNaziv.Name = "txtNaziv"
        Me.txtNaziv.Size = New System.Drawing.Size(277, 20)
        Me.txtNaziv.TabIndex = 43
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.tlbMain_sub.SetColumnSpan(Me.TableLayoutPanel3, 3)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 285)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(616, 2)
        Me.TableLayoutPanel3.TabIndex = 172
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tlbMain_sub.SetColumnSpan(Me.Panel3, 3)
        Me.Panel3.Controls.Add(Me.labLager)
        Me.Panel3.Location = New System.Drawing.Point(3, 259)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(616, 20)
        Me.Panel3.TabIndex = 174
        '
        'labLager
        '
        Me.labLager.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labLager.AutoSize = True
        Me.labLager.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labLager.ForeColor = System.Drawing.Color.LightSlateGray
        Me.labLager.Location = New System.Drawing.Point(-220, 4)
        Me.labLager.Name = "labLager"
        Me.labLager.Size = New System.Drawing.Size(16, 16)
        Me.labLager.TabIndex = 22
        Me.labLager.Text = ".."
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.tlbMain_sub.SetColumnSpan(Me.TableLayoutPanel1, 3)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 63)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(616, 2)
        Me.TableLayoutPanel1.TabIndex = 172
        '
        'cmbGradovi
        '
        Me.cmbGradovi.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbGradovi.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbGradovi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbGradovi.FormattingEnabled = True
        Me.cmbGradovi.Location = New System.Drawing.Point(129, 192)
        Me.cmbGradovi.Name = "cmbGradovi"
        Me.cmbGradovi.Size = New System.Drawing.Size(374, 21)
        Me.cmbGradovi.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Područje grada"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Područje opštine"
        '
        'cmbOpstine
        '
        Me.cmbOpstine.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbOpstine.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbOpstine.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbOpstine.FormattingEnabled = True
        Me.cmbOpstine.Location = New System.Drawing.Point(129, 162)
        Me.cmbOpstine.Name = "cmbOpstine"
        Me.cmbOpstine.Size = New System.Drawing.Size(374, 21)
        Me.cmbOpstine.TabIndex = 58
        '
        'txtPorJed
        '
        Me.txtPorJed.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPorJed.BackColor = System.Drawing.Color.GhostWhite
        Me.txtPorJed.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPorJed.Location = New System.Drawing.Point(129, 133)
        Me.txtPorJed.Name = "txtPorJed"
        Me.txtPorJed.Size = New System.Drawing.Size(374, 20)
        Me.txtPorJed.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Poreska jedinica"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "PTT broj"
        '
        'txtPttBroj
        '
        Me.txtPttBroj.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPttBroj.BackColor = System.Drawing.Color.GhostWhite
        Me.txtPttBroj.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPttBroj.Location = New System.Drawing.Point(129, 103)
        Me.txtPttBroj.Name = "txtPttBroj"
        Me.txtPttBroj.Size = New System.Drawing.Size(374, 20)
        Me.txtPttBroj.TabIndex = 40
        '
        'cntNaselja_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.tlbMain)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntNaselja_edit"
        Me.Size = New System.Drawing.Size(661, 359)
        Me.tlbMain.ResumeLayout(False)
        Me.tlbMain_sub.ResumeLayout(False)
        Me.tlbMain_sub.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.panHeader.ResumeLayout(False)
        Me.panHeader.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlbMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSnimi As System.Windows.Forms.Button
    Friend WithEvents tlbMain_sub As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rbtGradovi As System.Windows.Forms.RadioButton
    Friend WithEvents rbtOpstine As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMesta As System.Windows.Forms.RadioButton
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panHeader As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNaziv As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents labLager As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbGradovi As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbOpstine As System.Windows.Forms.ComboBox
    Friend WithEvents txtPorJed As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPttBroj As System.Windows.Forms.TextBox

End Class
