<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntLab_Dn_search
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
        Me.datDatumDO = New System.Windows.Forms.DateTimePicker
        Me.chkTrebovanje = New System.Windows.Forms.CheckBox
        Me.chkDatum = New System.Windows.Forms.CheckBox
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel
        Me.btnPronadji = New System.Windows.Forms.Button
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkLab_Dn = New System.Windows.Forms.CheckBox
        Me.chkBroj = New System.Windows.Forms.CheckBox
        Me.chkSve = New System.Windows.Forms.CheckBox
        Me.txtBroj = New System.Windows.Forms.TextBox
        Me.datDatumOD = New System.Windows.Forms.DateTimePicker
        Me.rbtProknjizene = New System.Windows.Forms.TableLayoutPanel
        Me.tlbABC = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.labCount = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.rbtZaklj = New System.Windows.Forms.RadioButton
        Me.rbtNezaklj = New System.Windows.Forms.RadioButton
        Me.chkDo = New System.Windows.Forms.CheckBox
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
        Me.mPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.68688!))
        Me.mPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.31312!))
        Me.mPanel.Controls.Add(Me.Label3, 0, 0)
        Me.mPanel.Controls.Add(Me.mPanel2, 0, 2)
        Me.mPanel.Controls.Add(Me.rbtProknjizene, 1, 2)
        Me.mPanel.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.mPanel.Location = New System.Drawing.Point(13, 13)
        Me.mPanel.Name = "mPanel"
        Me.mPanel.RowCount = 3
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 169.0!))
        Me.mPanel.Size = New System.Drawing.Size(726, 253)
        Me.mPanel.TabIndex = 3
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
        Me.Label3.Size = New System.Drawing.Size(720, 32)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "IZABERITE OPCIJE PRETRAGE "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mPanel2
        '
        Me.mPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mPanel2.ColumnCount = 4
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149.0!))
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mPanel2.Controls.Add(Me.chkDo, 2, 3)
        Me.mPanel2.Controls.Add(Me.datDatumDO, 3, 3)
        Me.mPanel2.Controls.Add(Me.chkTrebovanje, 0, 2)
        Me.mPanel2.Controls.Add(Me.chkDatum, 0, 3)
        Me.mPanel2.Controls.Add(Me.TableLayoutPanel5, 0, 7)
        Me.mPanel2.Controls.Add(Me.TableLayoutPanel2, 0, 6)
        Me.mPanel2.Controls.Add(Me.chkLab_Dn, 0, 1)
        Me.mPanel2.Controls.Add(Me.chkBroj, 0, 4)
        Me.mPanel2.Controls.Add(Me.chkSve, 0, 0)
        Me.mPanel2.Controls.Add(Me.txtBroj, 1, 4)
        Me.mPanel2.Controls.Add(Me.datDatumOD, 1, 3)
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
        Me.mPanel2.Size = New System.Drawing.Size(412, 202)
        Me.mPanel2.TabIndex = 31
        '
        'datDatumDO
        '
        Me.datDatumDO.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.datDatumDO.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.datDatumDO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datDatumDO.Location = New System.Drawing.Point(310, 84)
        Me.datDatumDO.Name = "datDatumDO"
        Me.datDatumDO.Size = New System.Drawing.Size(94, 21)
        Me.datDatumDO.TabIndex = 40
        '
        'chkTrebovanje
        '
        Me.chkTrebovanje.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkTrebovanje.AutoSize = True
        Me.chkTrebovanje.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkTrebovanje.Location = New System.Drawing.Point(3, 58)
        Me.chkTrebovanje.Name = "chkTrebovanje"
        Me.chkTrebovanje.Size = New System.Drawing.Size(140, 19)
        Me.chkTrebovanje.TabIndex = 24
        Me.chkTrebovanje.Text = "SAMO TREBOVANJA"
        Me.chkTrebovanje.UseVisualStyleBackColor = True
        '
        'chkDatum
        '
        Me.chkDatum.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkDatum.AutoSize = True
        Me.chkDatum.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkDatum.Location = New System.Drawing.Point(3, 85)
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
        Me.mPanel2.SetColumnSpan(Me.TableLayoutPanel5, 4)
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.80323!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.19677!))
        Me.TableLayoutPanel5.Controls.Add(Me.btnPronadji, 1, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 161)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(406, 30)
        Me.TableLayoutPanel5.TabIndex = 38
        '
        'btnPronadji
        '
        Me.btnPronadji.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnPronadji.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPronadji.Location = New System.Drawing.Point(303, 3)
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
        Me.mPanel2.SetColumnSpan(Me.TableLayoutPanel2, 4)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 153)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(406, 2)
        Me.TableLayoutPanel2.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(247, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "DO"
        '
        'chkLab_Dn
        '
        Me.chkLab_Dn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkLab_Dn.AutoSize = True
        Me.chkLab_Dn.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkLab_Dn.Location = New System.Drawing.Point(3, 31)
        Me.chkLab_Dn.Name = "chkLab_Dn"
        Me.chkLab_Dn.Size = New System.Drawing.Size(143, 19)
        Me.chkLab_Dn.TabIndex = 25
        Me.chkLab_Dn.Text = "SAMO LAB.DNEVNIK"
        Me.chkLab_Dn.UseVisualStyleBackColor = True
        '
        'chkBroj
        '
        Me.chkBroj.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkBroj.AutoSize = True
        Me.chkBroj.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkBroj.Location = New System.Drawing.Point(3, 112)
        Me.chkBroj.Name = "chkBroj"
        Me.chkBroj.Size = New System.Drawing.Size(56, 19)
        Me.chkBroj.TabIndex = 22
        Me.chkBroj.Text = "BROJ"
        Me.chkBroj.UseVisualStyleBackColor = True
        '
        'chkSve
        '
        Me.chkSve.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkSve.AutoSize = True
        Me.chkSve.Location = New System.Drawing.Point(3, 4)
        Me.chkSve.Name = "chkSve"
        Me.chkSve.Size = New System.Drawing.Size(127, 19)
        Me.chkSve.TabIndex = 40
        Me.chkSve.Text = "SVA DOKUMENTA"
        Me.chkSve.UseVisualStyleBackColor = True
        '
        'txtBroj
        '
        Me.txtBroj.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBroj.BackColor = System.Drawing.Color.GhostWhite
        Me.mPanel2.SetColumnSpan(Me.txtBroj, 3)
        Me.txtBroj.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBroj.Location = New System.Drawing.Point(152, 111)
        Me.txtBroj.Name = "txtBroj"
        Me.txtBroj.Size = New System.Drawing.Size(257, 21)
        Me.txtBroj.TabIndex = 14
        '
        'datDatumOD
        '
        Me.datDatumOD.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.datDatumOD.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.datDatumOD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datDatumOD.Location = New System.Drawing.Point(152, 84)
        Me.datDatumOD.Name = "datDatumOD"
        Me.datDatumOD.Size = New System.Drawing.Size(94, 21)
        Me.datDatumOD.TabIndex = 39
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
        Me.rbtProknjizene.Location = New System.Drawing.Point(421, 41)
        Me.rbtProknjizene.Name = "rbtProknjizene"
        Me.rbtProknjizene.RowCount = 6
        Me.rbtProknjizene.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.rbtProknjizene.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.rbtProknjizene.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.rbtProknjizene.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.rbtProknjizene.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.rbtProknjizene.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.rbtProknjizene.Size = New System.Drawing.Size(302, 202)
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
        Me.tlbABC.Size = New System.Drawing.Size(296, 2)
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
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(296, 24)
        Me.TableLayoutPanel4.TabIndex = 38
        '
        'labCount
        '
        Me.labCount.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.labCount.AutoSize = True
        Me.labCount.Location = New System.Drawing.Point(112, 4)
        Me.labCount.Name = "labCount"
        Me.labCount.Size = New System.Drawing.Size(12, 15)
        Me.labCount.TabIndex = 34
        Me.labCount.Text = "."
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Pronadjeno je"
        '
        'rbtZaklj
        '
        Me.rbtZaklj.AutoSize = True
        Me.rbtZaklj.Location = New System.Drawing.Point(56, 3)
        Me.rbtZaklj.Name = "rbtZaklj"
        Me.rbtZaklj.Size = New System.Drawing.Size(88, 19)
        Me.rbtZaklj.TabIndex = 39
        Me.rbtZaklj.TabStop = True
        Me.rbtZaklj.Text = "Zaklju�ene"
        Me.rbtZaklj.UseVisualStyleBackColor = True
        '
        'rbtNezaklj
        '
        Me.rbtNezaklj.AutoSize = True
        Me.rbtNezaklj.Location = New System.Drawing.Point(56, 29)
        Me.rbtNezaklj.Name = "rbtNezaklj"
        Me.rbtNezaklj.Size = New System.Drawing.Size(101, 19)
        Me.rbtNezaklj.TabIndex = 40
        Me.rbtNezaklj.TabStop = True
        Me.rbtNezaklj.Text = "Nezaklju�ene"
        Me.rbtNezaklj.UseVisualStyleBackColor = True
        '
        'chkDo
        '
        Me.chkDo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkDo.AutoSize = True
        Me.chkDo.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkDo.Location = New System.Drawing.Point(254, 85)
        Me.chkDo.Name = "chkDo"
        Me.chkDo.Size = New System.Drawing.Size(50, 19)
        Me.chkDo.TabIndex = 42
        Me.chkDo.Text = "DO"
        Me.chkDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkDo.UseVisualStyleBackColor = True
        '
        'cntLab_Dn_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.mPanel)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntLab_Dn_search"
        Me.Size = New System.Drawing.Size(759, 290)
        Me.mPanel.ResumeLayout(False)
        Me.mPanel.PerformLayout()
        Me.mPanel2.ResumeLayout(False)
        Me.mPanel2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.rbtProknjizene.ResumeLayout(False)
        Me.rbtProknjizene.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkDatum As System.Windows.Forms.CheckBox
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnPronadji As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents datDatumOD As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkLab_Dn As System.Windows.Forms.CheckBox
    Friend WithEvents chkBroj As System.Windows.Forms.CheckBox
    Friend WithEvents txtBroj As System.Windows.Forms.TextBox
    Friend WithEvents chkSve As System.Windows.Forms.CheckBox
    Friend WithEvents rbtProknjizene As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlbABC As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents labCount As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbtZaklj As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNezaklj As System.Windows.Forms.RadioButton
    Friend WithEvents chkTrebovanje As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents datDatumDO As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkDo As System.Windows.Forms.CheckBox

End Class