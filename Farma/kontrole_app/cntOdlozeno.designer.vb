<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntOdlozeno
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.lvOdlozeno = New System.Windows.Forms.ListView
        Me.cSifra = New System.Windows.Forms.ColumnHeader
        Me.cOpis = New System.Windows.Forms.ColumnHeader
        Me.cOdlozeno = New System.Windows.Forms.ColumnHeader
        Me.picRefresh = New System.Windows.Forms.PictureBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.picRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 605.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lvOdlozeno, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.picRefresh, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label15, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(654, 416)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'lvOdlozeno
        '
        Me.lvOdlozeno.BackColor = System.Drawing.Color.GhostWhite
        Me.lvOdlozeno.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cSifra, Me.cOpis, Me.cOdlozeno})
        Me.lvOdlozeno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvOdlozeno.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lvOdlozeno.FullRowSelect = True
        Me.lvOdlozeno.GridLines = True
        Me.lvOdlozeno.Location = New System.Drawing.Point(3, 49)
        Me.lvOdlozeno.Name = "lvOdlozeno"
        Me.lvOdlozeno.Size = New System.Drawing.Size(648, 364)
        Me.lvOdlozeno.TabIndex = 0
        Me.lvOdlozeno.UseCompatibleStateImageBehavior = False
        Me.lvOdlozeno.View = System.Windows.Forms.View.Details
        '
        'cSifra
        '
        Me.cSifra.Text = "Šifra"
        '
        'cOpis
        '
        Me.cOpis.Text = "Opis"
        Me.cOpis.Width = 350
        '
        'cOdlozeno
        '
        Me.cOdlozeno.Text = "Odlozeno"
        Me.cOdlozeno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picRefresh
        '
        Me.picRefresh.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.picRefresh.Image = Global.Farma.My.Resources.Resources.reload1
        Me.picRefresh.Location = New System.Drawing.Point(3, 22)
        Me.picRefresh.Name = "picRefresh"
        Me.picRefresh.Size = New System.Drawing.Size(20, 20)
        Me.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRefresh.TabIndex = 11
        Me.picRefresh.TabStop = False
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 2)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Osveži"
        '
        'cntOdlozeno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Name = "cntOdlozeno"
        Me.Size = New System.Drawing.Size(654, 416)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.picRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvOdlozeno As System.Windows.Forms.ListView
    Friend WithEvents cSifra As System.Windows.Forms.ColumnHeader
    Friend WithEvents cOpis As System.Windows.Forms.ColumnHeader
    Friend WithEvents cOdlozeno As System.Windows.Forms.ColumnHeader
    Friend WithEvents picRefresh As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label

End Class
