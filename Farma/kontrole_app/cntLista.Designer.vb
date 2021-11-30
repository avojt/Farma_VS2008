<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntLista
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
        Me.btnZatvori = New System.Windows.Forms.Button
        Me.Panel = New System.Windows.Forms.TableLayoutPanel
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnZatvori
        '
        Me.btnZatvori.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnZatvori.Location = New System.Drawing.Point(544, 352)
        Me.btnZatvori.Name = "btnZatvori"
        Me.btnZatvori.Size = New System.Drawing.Size(75, 23)
        Me.btnZatvori.TabIndex = 1
        Me.btnZatvori.Text = "ZATVORI"
        Me.btnZatvori.UseVisualStyleBackColor = True
        '
        'Panel
        '
        Me.Panel.ColumnCount = 1
        Me.Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel.Controls.Add(Me.btnZatvori, 0, 1)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.RowCount = 2
        Me.Panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.32804!))
        Me.Panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.671957!))
        Me.Panel.Size = New System.Drawing.Size(622, 378)
        Me.Panel.TabIndex = 2
        '
        'cntLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.Panel)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntLista"
        Me.Size = New System.Drawing.Size(622, 378)
        Me.Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnZatvori As System.Windows.Forms.Button
    Friend WithEvents Panel As System.Windows.Forms.TableLayoutPanel

End Class
