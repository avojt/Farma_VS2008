<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntDPromet_search
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.mPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.chkSve = New System.Windows.Forms.CheckBox
        Me.chkDatum = New System.Windows.Forms.CheckBox
        Me.cmbMagacin = New System.Windows.Forms.ComboBox
        Me.chkMagacin = New System.Windows.Forms.CheckBox
        Me.chkZakljuceno = New System.Windows.Forms.CheckBox
        Me.chkVrDok = New System.Windows.Forms.CheckBox
        Me.cmbVrDok = New System.Windows.Forms.ComboBox
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel
        Me.chkABC = New System.Windows.Forms.CheckBox
        Me.btnPronadji = New System.Windows.Forms.Button
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.datDatum = New System.Windows.Forms.DateTimePicker
        Me.chkArtikl = New System.Windows.Forms.CheckBox
        Me.cmbArtikl = New System.Windows.Forms.ComboBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.tlbABC = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.labCount = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.mPanel.SuspendLayout()
        Me.mPanel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'mPanel
        '
        Me.mPanel.ColumnCount = 2
        Me.mPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.mPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.mPanel.Controls.Add(Me.Label3, 0, 0)
        Me.mPanel.Controls.Add(Me.mPanel2, 0, 2)
        Me.mPanel.Controls.Add(Me.TableLayoutPanel1, 1, 2)
        Me.mPanel.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.mPanel.Location = New System.Drawing.Point(8, 8)
        Me.mPanel.Name = "mPanel"
        Me.mPanel.RowCount = 3
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 169.0!))
        Me.mPanel.Size = New System.Drawing.Size(803, 286)
        Me.mPanel.TabIndex = 1
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
        Me.Label3.Size = New System.Drawing.Size(797, 32)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "IZABERITE OPCIJE PRETRAGE "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mPanel2
        '
        Me.mPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mPanel2.ColumnCount = 2
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mPanel2.Controls.Add(Me.chkSve, 0, 0)
        Me.mPanel2.Controls.Add(Me.chkDatum, 0, 1)
        Me.mPanel2.Controls.Add(Me.cmbMagacin, 1, 2)
        Me.mPanel2.Controls.Add(Me.chkMagacin, 0, 2)
        Me.mPanel2.Controls.Add(Me.chkZakljuceno, 0, 5)
        Me.mPanel2.Controls.Add(Me.chkVrDok, 0, 4)
        Me.mPanel2.Controls.Add(Me.cmbVrDok, 1, 4)
        Me.mPanel2.Controls.Add(Me.TableLayoutPanel5, 0, 8)
        Me.mPanel2.Controls.Add(Me.TableLayoutPanel2, 0, 7)
        Me.mPanel2.Controls.Add(Me.datDatum, 1, 1)
        Me.mPanel2.Controls.Add(Me.chkArtikl, 0, 3)
        Me.mPanel2.Controls.Add(Me.cmbArtikl, 1, 3)
        Me.mPanel2.Location = New System.Drawing.Point(3, 41)
        Me.mPanel2.Name = "mPanel2"
        Me.mPanel2.RowCount = 10
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mPanel2.Size = New System.Drawing.Size(435, 235)
        Me.mPanel2.TabIndex = 31
        '
        'chkSve
        '
        Me.chkSve.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkSve.AutoSize = True
        Me.chkSve.Location = New System.Drawing.Point(3, 4)
        Me.chkSve.Name = "chkSve"
        Me.chkSve.Size = New System.Drawing.Size(92, 19)
        Me.chkSve.TabIndex = 41
        Me.chkSve.Text = "SVI ZAPISI"
        Me.chkSve.UseVisualStyleBackColor = True
        '
        'chkDatum
        '
        Me.chkDatum.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkDatum.AutoSize = True
        Me.chkDatum.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkDatum.Location = New System.Drawing.Point(3, 31)
        Me.chkDatum.Name = "chkDatum"
        Me.chkDatum.Size = New System.Drawing.Size(67, 19)
        Me.chkDatum.TabIndex = 22
        Me.chkDatum.Text = "DATUM"
        Me.chkDatum.UseVisualStyleBackColor = True
        '
        'cmbMagacin
        '
        Me.cmbMagacin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMagacin.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbMagacin.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmbMagacin.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbMagacin.FormattingEnabled = True
        Me.cmbMagacin.Location = New System.Drawing.Point(145, 57)
        Me.cmbMagacin.Name = "cmbMagacin"
        Me.cmbMagacin.Size = New System.Drawing.Size(287, 23)
        Me.cmbMagacin.TabIndex = 27
        '
        'chkMagacin
        '
        Me.chkMagacin.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkMagacin.AutoSize = True
        Me.chkMagacin.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkMagacin.Location = New System.Drawing.Point(3, 58)
        Me.chkMagacin.Name = "chkMagacin"
        Me.chkMagacin.Size = New System.Drawing.Size(82, 19)
        Me.chkMagacin.TabIndex = 23
        Me.chkMagacin.Text = "MAGACIN"
        Me.chkMagacin.UseVisualStyleBackColor = True
        '
        'chkZakljuceno
        '
        Me.chkZakljuceno.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkZakljuceno.AutoSize = True
        Me.chkZakljuceno.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkZakljuceno.Location = New System.Drawing.Point(3, 139)
        Me.chkZakljuceno.Name = "chkZakljuceno"
        Me.chkZakljuceno.Size = New System.Drawing.Size(98, 19)
        Me.chkZakljuceno.TabIndex = 25
        Me.chkZakljuceno.Text = "ZAKLJUČENI"
        Me.chkZakljuceno.UseVisualStyleBackColor = True
        '
        'chkVrDok
        '
        Me.chkVrDok.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkVrDok.AutoSize = True
        Me.chkVrDok.Location = New System.Drawing.Point(3, 112)
        Me.chkVrDok.Name = "chkVrDok"
        Me.chkVrDok.Size = New System.Drawing.Size(116, 19)
        Me.chkVrDok.TabIndex = 35
        Me.chkVrDok.Text = "VRSTA DOKUM."
        Me.chkVrDok.UseVisualStyleBackColor = True
        '
        'cmbVrDok
        '
        Me.cmbVrDok.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbVrDok.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbVrDok.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbVrDok.FormattingEnabled = True
        Me.cmbVrDok.Location = New System.Drawing.Point(145, 111)
        Me.cmbVrDok.Name = "cmbVrDok"
        Me.cmbVrDok.Size = New System.Drawing.Size(287, 23)
        Me.cmbVrDok.TabIndex = 36
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
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 193)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(429, 30)
        Me.TableLayoutPanel5.TabIndex = 38
        '
        'chkABC
        '
        Me.chkABC.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkABC.AutoSize = True
        Me.chkABC.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkABC.Location = New System.Drawing.Point(3, 5)
        Me.chkABC.Name = "chkABC"
        Me.chkABC.Size = New System.Drawing.Size(263, 19)
        Me.chkABC.TabIndex = 0
        Me.chkABC.Text = "Složi po abecednom redu"
        Me.chkABC.UseVisualStyleBackColor = True
        '
        'btnPronadji
        '
        Me.btnPronadji.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnPronadji.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPronadji.Location = New System.Drawing.Point(326, 3)
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 185)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(429, 2)
        Me.TableLayoutPanel2.TabIndex = 37
        '
        'datDatum
        '
        Me.datDatum.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.datDatum.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.datDatum.CalendarTitleForeColor = System.Drawing.Color.GhostWhite
        Me.datDatum.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datDatum.Location = New System.Drawing.Point(145, 30)
        Me.datDatum.Name = "datDatum"
        Me.datDatum.Size = New System.Drawing.Size(98, 21)
        Me.datDatum.TabIndex = 39
        '
        'chkArtikl
        '
        Me.chkArtikl.AutoSize = True
        Me.chkArtikl.Location = New System.Drawing.Point(3, 84)
        Me.chkArtikl.Name = "chkArtikl"
        Me.chkArtikl.Size = New System.Drawing.Size(68, 19)
        Me.chkArtikl.TabIndex = 42
        Me.chkArtikl.Text = "ARTIKL"
        Me.chkArtikl.UseVisualStyleBackColor = True
        '
        'cmbArtikl
        '
        Me.cmbArtikl.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbArtikl.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbArtikl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbArtikl.FormattingEnabled = True
        Me.cmbArtikl.Location = New System.Drawing.Point(145, 84)
        Me.cmbArtikl.Name = "cmbArtikl"
        Me.cmbArtikl.Size = New System.Drawing.Size(287, 23)
        Me.cmbArtikl.TabIndex = 43
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tlbABC, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(444, 41)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 181.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(356, 235)
        Me.TableLayoutPanel1.TabIndex = 40
        '
        'tlbABC
        '
        Me.tlbABC.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tlbABC.ColumnCount = 1
        Me.TableLayoutPanel1.SetColumnSpan(Me.tlbABC, 3)
        Me.tlbABC.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlbABC.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlbABC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlbABC.Location = New System.Drawing.Point(3, 184)
        Me.tlbABC.Name = "tlbABC"
        Me.tlbABC.RowCount = 1
        Me.tlbABC.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbABC.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlbABC.Size = New System.Drawing.Size(350, 2)
        Me.tlbABC.TabIndex = 33
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel4, 3)
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.78685!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.21315!))
        Me.TableLayoutPanel4.Controls.Add(Me.labCount, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel4.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 192)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(350, 24)
        Me.TableLayoutPanel4.TabIndex = 38
        '
        'labCount
        '
        Me.labCount.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.labCount.AutoSize = True
        Me.labCount.Location = New System.Drawing.Point(121, 4)
        Me.labCount.Name = "labCount"
        Me.labCount.Size = New System.Drawing.Size(12, 15)
        Me.labCount.TabIndex = 34
        Me.labCount.Text = "."
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Pronadjeno je"
        '
        'cntDPromet_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.mPanel)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntDPromet_search"
        Me.Size = New System.Drawing.Size(826, 306)
        Me.mPanel.ResumeLayout(False)
        Me.mPanel.PerformLayout()
        Me.mPanel2.ResumeLayout(False)
        Me.mPanel2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkDatum As System.Windows.Forms.CheckBox
    Friend WithEvents cmbMagacin As System.Windows.Forms.ComboBox
    Friend WithEvents chkMagacin As System.Windows.Forms.CheckBox
    Friend WithEvents chkVrDok As System.Windows.Forms.CheckBox
    Friend WithEvents cmbVrDok As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkABC As System.Windows.Forms.CheckBox
    Friend WithEvents btnPronadji As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlbABC As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents labCount As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkZakljuceno As System.Windows.Forms.CheckBox
    Friend WithEvents datDatum As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkSve As System.Windows.Forms.CheckBox
    Friend WithEvents chkArtikl As System.Windows.Forms.CheckBox
    Friend WithEvents cmbArtikl As System.Windows.Forms.ComboBox

End Class
