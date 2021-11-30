<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntRobno_search
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.mPanel = New System.Windows.Forms.TableLayoutPanel
        Me.Label3 = New System.Windows.Forms.Label
        Me.mPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.chkDatum = New System.Windows.Forms.CheckBox
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel
        Me.chkABC = New System.Windows.Forms.CheckBox
        Me.btnPronadji = New System.Windows.Forms.Button
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.datDatum = New System.Windows.Forms.DateTimePicker
        Me.cmbMagacin = New System.Windows.Forms.ComboBox
        Me.chkMagacin = New System.Windows.Forms.CheckBox
        Me.chkDobavljac = New System.Windows.Forms.CheckBox
        Me.chkBroj = New System.Windows.Forms.CheckBox
        Me.cmbDobavljac = New System.Windows.Forms.ComboBox
        Me.txtBroj = New System.Windows.Forms.TextBox
        Me.chkSve = New System.Windows.Forms.CheckBox
        Me.rbtProknjizene = New System.Windows.Forms.TableLayoutPanel
        Me.tlbABC = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.labCount = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.rbtZaklj = New System.Windows.Forms.RadioButton
        Me.rbtNezaklj = New System.Windows.Forms.RadioButton
        Me.mPanel.SuspendLayout()
        Me.mPanel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.rbtProknjizene.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'mPanel
        '
        Me.mPanel.ColumnCount = 2
        Me.mPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.01093!))
        Me.mPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.98907!))
        Me.mPanel.Controls.Add(Me.Label3, 0, 0)
        Me.mPanel.Controls.Add(Me.mPanel2, 0, 2)
        Me.mPanel.Controls.Add(Me.rbtProknjizene, 1, 2)
        Me.mPanel.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.mPanel.Location = New System.Drawing.Point(16, 14)
        Me.mPanel.Name = "mPanel"
        Me.mPanel.RowCount = 3
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 169.0!))
        Me.mPanel.Size = New System.Drawing.Size(709, 254)
        Me.mPanel.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.mPanel.SetColumnSpan(Me.Label3, 2)
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(703, 32)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "IZABERITE OPCIJE PRETRAGE "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mPanel2
        '
        Me.mPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mPanel2.ColumnCount = 2
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138.0!))
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mPanel2.Controls.Add(Me.chkDatum, 0, 2)
        Me.mPanel2.Controls.Add(Me.TableLayoutPanel5, 0, 7)
        Me.mPanel2.Controls.Add(Me.TableLayoutPanel2, 0, 6)
        Me.mPanel2.Controls.Add(Me.cmbMagacin, 1, 1)
        Me.mPanel2.Controls.Add(Me.chkMagacin, 0, 1)
        Me.mPanel2.Controls.Add(Me.chkDobavljac, 0, 4)
        Me.mPanel2.Controls.Add(Me.chkBroj, 0, 3)
        Me.mPanel2.Controls.Add(Me.cmbDobavljac, 1, 4)
        Me.mPanel2.Controls.Add(Me.txtBroj, 1, 3)
        Me.mPanel2.Controls.Add(Me.chkSve, 0, 0)
        Me.mPanel2.Controls.Add(Me.datDatum, 1, 2)
        Me.mPanel2.Location = New System.Drawing.Point(3, 41)
        Me.mPanel2.Name = "mPanel2"
        Me.mPanel2.RowCount = 9
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mPanel2.Size = New System.Drawing.Size(391, 202)
        Me.mPanel2.TabIndex = 31
        '
        'chkDatum
        '
        Me.chkDatum.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkDatum.AutoSize = True
        Me.chkDatum.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkDatum.Location = New System.Drawing.Point(3, 58)
        Me.chkDatum.Name = "chkDatum"
        Me.chkDatum.Size = New System.Drawing.Size(67, 19)
        Me.chkDatum.TabIndex = 23
        Me.chkDatum.Text = "DATUM"
        Me.chkDatum.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.mPanel2.SetColumnSpan(Me.TableLayoutPanel5, 2)
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.80323!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.19677!))
        Me.TableLayoutPanel5.Controls.Add(Me.chkABC, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnPronadji, 1, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 161)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(385, 30)
        Me.TableLayoutPanel5.TabIndex = 38
        '
        'chkABC
        '
        Me.chkABC.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkABC.AutoSize = True
        Me.chkABC.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkABC.Location = New System.Drawing.Point(3, 5)
        Me.chkABC.Name = "chkABC"
        Me.chkABC.Size = New System.Drawing.Size(235, 19)
        Me.chkABC.TabIndex = 0
        Me.chkABC.Text = "Složi po abecednom redu"
        Me.chkABC.UseVisualStyleBackColor = True
        '
        'btnPronadji
        '
        Me.btnPronadji.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnPronadji.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPronadji.Location = New System.Drawing.Point(282, 3)
        Me.btnPronadji.Name = "btnPronadji"
        Me.btnPronadji.Size = New System.Drawing.Size(100, 24)
        Me.btnPronadji.TabIndex = 29
        Me.btnPronadji.Text = "PRONADJI"
        Me.btnPronadji.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.mPanel2.SetColumnSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 153)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(385, 2)
        Me.TableLayoutPanel2.TabIndex = 37
        '
        'datDatum
        '
        Me.datDatum.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.datDatum.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.datDatum.Location = New System.Drawing.Point(141, 57)
        Me.datDatum.Name = "datDatum"
        Me.datDatum.Size = New System.Drawing.Size(145, 21)
        Me.datDatum.TabIndex = 39
        '
        'cmbMagacin
        '
        Me.cmbMagacin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMagacin.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbMagacin.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbMagacin.FormattingEnabled = True
        Me.cmbMagacin.Location = New System.Drawing.Point(141, 30)
        Me.cmbMagacin.Name = "cmbMagacin"
        Me.cmbMagacin.Size = New System.Drawing.Size(247, 23)
        Me.cmbMagacin.TabIndex = 8
        '
        'chkMagacin
        '
        Me.chkMagacin.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkMagacin.AutoSize = True
        Me.chkMagacin.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkMagacin.Location = New System.Drawing.Point(3, 31)
        Me.chkMagacin.Name = "chkMagacin"
        Me.chkMagacin.Size = New System.Drawing.Size(82, 19)
        Me.chkMagacin.TabIndex = 25
        Me.chkMagacin.Text = "MAGACIN"
        Me.chkMagacin.UseVisualStyleBackColor = True
        '
        'chkDobavljac
        '
        Me.chkDobavljac.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkDobavljac.AutoSize = True
        Me.chkDobavljac.Location = New System.Drawing.Point(3, 112)
        Me.chkDobavljac.Name = "chkDobavljac"
        Me.chkDobavljac.Size = New System.Drawing.Size(96, 19)
        Me.chkDobavljac.TabIndex = 35
        Me.chkDobavljac.Text = "DOBAVLJAÈ"
        Me.chkDobavljac.UseVisualStyleBackColor = True
        '
        'chkBroj
        '
        Me.chkBroj.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkBroj.AutoSize = True
        Me.chkBroj.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkBroj.Location = New System.Drawing.Point(3, 85)
        Me.chkBroj.Name = "chkBroj"
        Me.chkBroj.Size = New System.Drawing.Size(56, 19)
        Me.chkBroj.TabIndex = 22
        Me.chkBroj.Text = "BROJ"
        Me.chkBroj.UseVisualStyleBackColor = True
        '
        'cmbDobavljac
        '
        Me.cmbDobavljac.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbDobavljac.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbDobavljac.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbDobavljac.FormattingEnabled = True
        Me.cmbDobavljac.Location = New System.Drawing.Point(141, 111)
        Me.cmbDobavljac.Name = "cmbDobavljac"
        Me.cmbDobavljac.Size = New System.Drawing.Size(247, 23)
        Me.cmbDobavljac.TabIndex = 36
        '
        'txtBroj
        '
        Me.txtBroj.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBroj.BackColor = System.Drawing.Color.GhostWhite
        Me.txtBroj.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBroj.Location = New System.Drawing.Point(141, 84)
        Me.txtBroj.Name = "txtBroj"
        Me.txtBroj.Size = New System.Drawing.Size(247, 21)
        Me.txtBroj.TabIndex = 14
        '
        'chkSve
        '
        Me.chkSve.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkSve.AutoSize = True
        Me.chkSve.Location = New System.Drawing.Point(3, 4)
        Me.chkSve.Name = "chkSve"
        Me.chkSve.Size = New System.Drawing.Size(121, 19)
        Me.chkSve.TabIndex = 40
        Me.chkSve.Text = "SVI DOKUMENTI"
        Me.chkSve.UseVisualStyleBackColor = True
        '
        'rbtProknjizene
        '
        Me.rbtProknjizene.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtProknjizene.ColumnCount = 3
        Me.rbtProknjizene.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.rbtProknjizene.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.rbtProknjizene.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.rbtProknjizene.Controls.Add(Me.tlbABC, 0, 3)
        Me.rbtProknjizene.Controls.Add(Me.TableLayoutPanel4, 0, 4)
        Me.rbtProknjizene.Controls.Add(Me.rbtZaklj, 2, 0)
        Me.rbtProknjizene.Controls.Add(Me.rbtNezaklj, 2, 1)
        Me.rbtProknjizene.Location = New System.Drawing.Point(400, 41)
        Me.rbtProknjizene.Name = "rbtProknjizene"
        Me.rbtProknjizene.RowCount = 6
        Me.rbtProknjizene.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.rbtProknjizene.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.rbtProknjizene.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.rbtProknjizene.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.rbtProknjizene.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.rbtProknjizene.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.rbtProknjizene.Size = New System.Drawing.Size(306, 202)
        Me.rbtProknjizene.TabIndex = 40
        '
        'tlbABC
        '
        Me.tlbABC.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tlbABC.ColumnCount = 1
        Me.rbtProknjizene.SetColumnSpan(Me.tlbABC, 3)
        Me.tlbABC.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlbABC.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlbABC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlbABC.Location = New System.Drawing.Point(3, 153)
        Me.tlbABC.Name = "tlbABC"
        Me.tlbABC.RowCount = 1
        Me.tlbABC.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbABC.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlbABC.Size = New System.Drawing.Size(300, 2)
        Me.tlbABC.TabIndex = 33
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.rbtProknjizene.SetColumnSpan(Me.TableLayoutPanel4, 3)
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.09678!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.90322!))
        Me.TableLayoutPanel4.Controls.Add(Me.labCount, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel4.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 161)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(300, 24)
        Me.TableLayoutPanel4.TabIndex = 38
        '
        'labCount
        '
        Me.labCount.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.labCount.AutoSize = True
        Me.labCount.Location = New System.Drawing.Point(114, 4)
        Me.labCount.Name = "labCount"
        Me.labCount.Size = New System.Drawing.Size(12, 15)
        Me.labCount.TabIndex = 34
        Me.labCount.Text = "."
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Pronadjeno je"
        '
        'rbtZaklj
        '
        Me.rbtZaklj.AutoSize = True
        Me.rbtZaklj.Location = New System.Drawing.Point(57, 3)
        Me.rbtZaklj.Name = "rbtZaklj"
        Me.rbtZaklj.Size = New System.Drawing.Size(84, 19)
        Me.rbtZaklj.TabIndex = 39
        Me.rbtZaklj.TabStop = True
        Me.rbtZaklj.Text = "Zakljuèeni"
        Me.rbtZaklj.UseVisualStyleBackColor = True
        '
        'rbtNezaklj
        '
        Me.rbtNezaklj.AutoSize = True
        Me.rbtNezaklj.Location = New System.Drawing.Point(57, 29)
        Me.rbtNezaklj.Name = "rbtNezaklj"
        Me.rbtNezaklj.Size = New System.Drawing.Size(97, 19)
        Me.rbtNezaklj.TabIndex = 40
        Me.rbtNezaklj.TabStop = True
        Me.rbtNezaklj.Text = "Nezakljuèeni"
        Me.rbtNezaklj.UseVisualStyleBackColor = True
        '
        'cntRobno_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.mPanel)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntRobno_search"
        Me.Size = New System.Drawing.Size(742, 286)
        Me.mPanel.ResumeLayout(False)
        Me.mPanel.PerformLayout()
        Me.mPanel2.ResumeLayout(False)
        Me.mPanel2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.rbtProknjizene.ResumeLayout(False)
        Me.rbtProknjizene.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkDatum As System.Windows.Forms.CheckBox
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkABC As System.Windows.Forms.CheckBox
    Friend WithEvents btnPronadji As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents datDatum As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbMagacin As System.Windows.Forms.ComboBox
    Friend WithEvents chkMagacin As System.Windows.Forms.CheckBox
    Friend WithEvents chkDobavljac As System.Windows.Forms.CheckBox
    Friend WithEvents chkBroj As System.Windows.Forms.CheckBox
    Friend WithEvents cmbDobavljac As System.Windows.Forms.ComboBox
    Friend WithEvents txtBroj As System.Windows.Forms.TextBox
    Friend WithEvents chkSve As System.Windows.Forms.CheckBox
    Friend WithEvents rbtProknjizene As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlbABC As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents labCount As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbtZaklj As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNezaklj As System.Windows.Forms.RadioButton

End Class
