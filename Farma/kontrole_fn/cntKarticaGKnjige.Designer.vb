<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntKarticaGKnjige
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
        Me.lKontoDO = New System.Windows.Forms.Label
        Me.lKontoOD = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.btnPronadji = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.labCount = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.chkKonto = New System.Windows.Forms.CheckBox
        Me.cmbKontoOD = New System.Windows.Forms.ComboBox
        Me.chkDatum = New System.Windows.Forms.CheckBox
        Me.datDatOD = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbKontoDO = New System.Windows.Forms.ComboBox
        Me.datDatDO = New System.Windows.Forms.DateTimePicker
        Me.mPanel.SuspendLayout()
        Me.mPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'mPanel
        '
        Me.mPanel.ColumnCount = 1
        Me.mPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.mPanel.Controls.Add(Me.Label3, 0, 0)
        Me.mPanel.Controls.Add(Me.mPanel2, 0, 2)
        Me.mPanel.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.mPanel.Location = New System.Drawing.Point(14, 12)
        Me.mPanel.Name = "mPanel"
        Me.mPanel.RowCount = 3
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 169.0!))
        Me.mPanel.Size = New System.Drawing.Size(828, 173)
        Me.mPanel.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(822, 32)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "IZABERITE OPCIJE IZVEŠTAJA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mPanel2
        '
        Me.mPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mPanel2.ColumnCount = 6
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104.0!))
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208.0!))
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mPanel2.Controls.Add(Me.lKontoDO, 5, 0)
        Me.mPanel2.Controls.Add(Me.lKontoOD, 2, 0)
        Me.mPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 4)
        Me.mPanel2.Controls.Add(Me.TableLayoutPanel2, 0, 3)
        Me.mPanel2.Controls.Add(Me.chkKonto, 0, 0)
        Me.mPanel2.Controls.Add(Me.cmbKontoOD, 1, 0)
        Me.mPanel2.Controls.Add(Me.chkDatum, 0, 1)
        Me.mPanel2.Controls.Add(Me.datDatOD, 1, 1)
        Me.mPanel2.Controls.Add(Me.Label4, 3, 0)
        Me.mPanel2.Controls.Add(Me.Label1, 3, 1)
        Me.mPanel2.Controls.Add(Me.cmbKontoDO, 4, 0)
        Me.mPanel2.Controls.Add(Me.datDatDO, 4, 1)
        Me.mPanel2.Location = New System.Drawing.Point(3, 41)
        Me.mPanel2.Name = "mPanel2"
        Me.mPanel2.RowCount = 6
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mPanel2.Size = New System.Drawing.Size(822, 123)
        Me.mPanel2.TabIndex = 31
        '
        'lKontoDO
        '
        Me.lKontoDO.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lKontoDO.AutoSize = True
        Me.lKontoDO.Location = New System.Drawing.Point(608, 6)
        Me.lKontoDO.Name = "lKontoDO"
        Me.lKontoDO.Size = New System.Drawing.Size(39, 15)
        Me.lKontoDO.TabIndex = 34
        Me.lKontoDO.Text = "lK_do"
        '
        'lKontoOD
        '
        Me.lKontoOD.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lKontoOD.AutoSize = True
        Me.lKontoOD.Location = New System.Drawing.Point(235, 6)
        Me.lKontoOD.Name = "lKontoOD"
        Me.lKontoOD.Size = New System.Drawing.Size(39, 15)
        Me.lKontoOD.TabIndex = 34
        Me.lKontoOD.Text = "lK_od"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.mPanel2.SetColumnSpan(Me.TableLayoutPanel1, 6)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnPronadji, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 80)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(816, 30)
        Me.TableLayoutPanel1.TabIndex = 43
        '
        'btnPronadji
        '
        Me.btnPronadji.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnPronadji.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPronadji.Location = New System.Drawing.Point(47, 3)
        Me.btnPronadji.Name = "btnPronadji"
        Me.btnPronadji.Size = New System.Drawing.Size(100, 24)
        Me.btnPronadji.TabIndex = 29
        Me.btnPronadji.Text = "PRONADJI"
        Me.btnPronadji.UseVisualStyleBackColor = True
        Me.btnPronadji.Visible = False
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnOK.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnOK.Location = New System.Drawing.Point(176, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 24)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "PRIKAZ"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.09678!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.90322!))
        Me.TableLayoutPanel4.Controls.Add(Me.labCount, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel4.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(257, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(556, 24)
        Me.TableLayoutPanel4.TabIndex = 38
        '
        'labCount
        '
        Me.labCount.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.labCount.AutoSize = True
        Me.labCount.Location = New System.Drawing.Point(209, 4)
        Me.labCount.Name = "labCount"
        Me.labCount.Size = New System.Drawing.Size(12, 15)
        Me.labCount.TabIndex = 34
        Me.labCount.Text = "."
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 15)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Izveštaj za period:"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.mPanel2.SetColumnSpan(Me.TableLayoutPanel2, 6)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 72)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(816, 2)
        Me.TableLayoutPanel2.TabIndex = 37
        '
        'chkKonto
        '
        Me.chkKonto.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkKonto.AutoSize = True
        Me.chkKonto.Location = New System.Drawing.Point(3, 4)
        Me.chkKonto.Name = "chkKonto"
        Me.chkKonto.Size = New System.Drawing.Size(67, 19)
        Me.chkKonto.TabIndex = 40
        Me.chkKonto.Text = "KONTO"
        Me.chkKonto.UseVisualStyleBackColor = True
        '
        'cmbKontoOD
        '
        Me.cmbKontoOD.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmbKontoOD.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbKontoOD.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbKontoOD.FormattingEnabled = True
        Me.cmbKontoOD.Location = New System.Drawing.Point(107, 3)
        Me.cmbKontoOD.Name = "cmbKontoOD"
        Me.cmbKontoOD.Size = New System.Drawing.Size(119, 23)
        Me.cmbKontoOD.TabIndex = 42
        '
        'chkDatum
        '
        Me.chkDatum.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkDatum.AutoSize = True
        Me.chkDatum.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkDatum.Location = New System.Drawing.Point(3, 31)
        Me.chkDatum.Name = "chkDatum"
        Me.chkDatum.Size = New System.Drawing.Size(67, 19)
        Me.chkDatum.TabIndex = 23
        Me.chkDatum.Text = "DATUM"
        Me.chkDatum.UseVisualStyleBackColor = True
        '
        'datDatOD
        '
        Me.datDatOD.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.datDatOD.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.datDatOD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datDatOD.Location = New System.Drawing.Point(107, 30)
        Me.datDatOD.Name = "datDatOD"
        Me.datDatOD.Size = New System.Drawing.Size(99, 21)
        Me.datDatOD.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(443, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 15)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "DO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(443, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "DO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbKontoDO
        '
        Me.cmbKontoDO.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmbKontoDO.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbKontoDO.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbKontoDO.FormattingEnabled = True
        Me.cmbKontoDO.Location = New System.Drawing.Point(483, 3)
        Me.cmbKontoDO.Name = "cmbKontoDO"
        Me.cmbKontoDO.Size = New System.Drawing.Size(119, 23)
        Me.cmbKontoDO.TabIndex = 43
        '
        'datDatDO
        '
        Me.datDatDO.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.datDatDO.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.datDatDO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datDatDO.Location = New System.Drawing.Point(483, 30)
        Me.datDatDO.Name = "datDatDO"
        Me.datDatDO.Size = New System.Drawing.Size(99, 21)
        Me.datDatDO.TabIndex = 40
        '
        'cntKarticaGKnjige
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.mPanel)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntKarticaGKnjige"
        Me.Size = New System.Drawing.Size(864, 196)
        Me.mPanel.ResumeLayout(False)
        Me.mPanel.PerformLayout()
        Me.mPanel2.ResumeLayout(False)
        Me.mPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lKontoDO As System.Windows.Forms.Label
    Friend WithEvents lKontoOD As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnPronadji As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents labCount As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkKonto As System.Windows.Forms.CheckBox
    Friend WithEvents cmbKontoOD As System.Windows.Forms.ComboBox
    Friend WithEvents chkDatum As System.Windows.Forms.CheckBox
    Friend WithEvents datDatOD As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbKontoDO As System.Windows.Forms.ComboBox
    Friend WithEvents datDatDO As System.Windows.Forms.DateTimePicker

End Class
