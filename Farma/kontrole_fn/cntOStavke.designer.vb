<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntOStavke
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
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel
        Me.Label26 = New System.Windows.Forms.Label
        Me.lvOS = New System.Windows.Forms.ListView
        Me.cBrojOS = New System.Windows.Forms.ColumnHeader
        Me.cPartnerOS = New System.Windows.Forms.ColumnHeader
        Me.cDatumOD = New System.Windows.Forms.ColumnHeader
        Me.cValutaOS = New System.Windows.Forms.ColumnHeader
        Me.cDugujeOS = New System.Windows.Forms.ColumnHeader
        Me.cPotrazujeOS = New System.Windows.Forms.ColumnHeader
        Me.cSaldoOS = New System.Windows.Forms.ColumnHeader
        Me.cmbPartnerOS = New System.Windows.Forms.ComboBox
        Me.chkRn = New System.Windows.Forms.CheckBox
        Me.chkPrimRn = New System.Windows.Forms.CheckBox
        Me.TableLayoutPanel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 3
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.Label26, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.lvOS, 0, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.cmbPartnerOS, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.chkRn, 1, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.chkPrimRn, 2, 1)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 3
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(715, 474)
        Me.TableLayoutPanel7.TabIndex = 8
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label26.Location = New System.Drawing.Point(3, 2)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(41, 13)
        Me.Label26.TabIndex = 5
        Me.Label26.Text = "Partner"
        '
        'lvOS
        '
        Me.lvOS.BackColor = System.Drawing.Color.GhostWhite
        Me.lvOS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cBrojOS, Me.cPartnerOS, Me.cDatumOD, Me.cValutaOS, Me.cDugujeOS, Me.cPotrazujeOS, Me.cSaldoOS})
        Me.TableLayoutPanel7.SetColumnSpan(Me.lvOS, 3)
        Me.lvOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvOS.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lvOS.FullRowSelect = True
        Me.lvOS.GridLines = True
        Me.lvOS.Location = New System.Drawing.Point(3, 49)
        Me.lvOS.Name = "lvOS"
        Me.lvOS.Size = New System.Drawing.Size(709, 422)
        Me.lvOS.TabIndex = 13
        Me.lvOS.UseCompatibleStateImageBehavior = False
        Me.lvOS.View = System.Windows.Forms.View.Details
        '
        'cBrojOS
        '
        Me.cBrojOS.Text = "Broj"
        Me.cBrojOS.Width = 80
        '
        'cPartnerOS
        '
        Me.cPartnerOS.Text = "Partner"
        Me.cPartnerOS.Width = 150
        '
        'cDatumOD
        '
        Me.cDatumOD.Text = "Dat. Faktirusanja"
        Me.cDatumOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cDatumOD.Width = 100
        '
        'cValutaOS
        '
        Me.cValutaOS.Text = "Valuta"
        Me.cValutaOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cValutaOS.Width = 100
        '
        'cDugujeOS
        '
        Me.cDugujeOS.Text = "Duguje"
        Me.cDugujeOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cDugujeOS.Width = 100
        '
        'cPotrazujeOS
        '
        Me.cPotrazujeOS.Text = "Potražuje"
        Me.cPotrazujeOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cPotrazujeOS.Width = 100
        '
        'cSaldoOS
        '
        Me.cSaldoOS.Text = "Saldo"
        Me.cSaldoOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cSaldoOS.Width = 100
        '
        'cmbPartnerOS
        '
        Me.cmbPartnerOS.FormattingEnabled = True
        Me.cmbPartnerOS.Location = New System.Drawing.Point(3, 21)
        Me.cmbPartnerOS.Name = "cmbPartnerOS"
        Me.cmbPartnerOS.Size = New System.Drawing.Size(121, 21)
        Me.cmbPartnerOS.TabIndex = 14
        '
        'chkRn
        '
        Me.chkRn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkRn.AutoSize = True
        Me.chkRn.Location = New System.Drawing.Point(143, 23)
        Me.chkRn.Name = "chkRn"
        Me.chkRn.Size = New System.Drawing.Size(83, 17)
        Me.chkRn.TabIndex = 15
        Me.chkRn.Text = "Izdati računi"
        Me.chkRn.UseVisualStyleBackColor = True
        '
        'chkPrimRn
        '
        Me.chkPrimRn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkPrimRn.AutoSize = True
        Me.chkPrimRn.Location = New System.Drawing.Point(283, 23)
        Me.chkPrimRn.Name = "chkPrimRn"
        Me.chkPrimRn.Size = New System.Drawing.Size(96, 17)
        Me.chkPrimRn.TabIndex = 16
        Me.chkPrimRn.Text = "PrimljFarma računi"
        Me.chkPrimRn.UseVisualStyleBackColor = True
        '
        'cntOStavke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.TableLayoutPanel7)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntOStavke"
        Me.Size = New System.Drawing.Size(715, 474)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lvOS As System.Windows.Forms.ListView
    Friend WithEvents cBrojOS As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPartnerOS As System.Windows.Forms.ColumnHeader
    Friend WithEvents cDatumOD As System.Windows.Forms.ColumnHeader
    Friend WithEvents cValutaOS As System.Windows.Forms.ColumnHeader
    Friend WithEvents cDugujeOS As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPotrazujeOS As System.Windows.Forms.ColumnHeader
    Friend WithEvents cSaldoOS As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbPartnerOS As System.Windows.Forms.ComboBox
    Friend WithEvents chkRn As System.Windows.Forms.CheckBox
    Friend WithEvents chkPrimRn As System.Windows.Forms.CheckBox

End Class
