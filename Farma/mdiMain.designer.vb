<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiMain))
        Me.splGlavni = New System.Windows.Forms.SplitContainer
        Me.splRadni = New System.Windows.Forms.SplitContainer
        Me.labHeader = New System.Windows.Forms.Label
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.splGlavni.Panel2.SuspendLayout()
        Me.splGlavni.SuspendLayout()
        Me.splRadni.Panel1.SuspendLayout()
        Me.splRadni.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'splGlavni
        '
        Me.splGlavni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.splGlavni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splGlavni.ForeColor = System.Drawing.Color.MidnightBlue
        Me.splGlavni.Location = New System.Drawing.Point(3, 3)
        Me.splGlavni.Name = "splGlavni"
        '
        'splGlavni.Panel2
        '
        Me.splGlavni.Panel2.Controls.Add(Me.splRadni)
        Me.splGlavni.Size = New System.Drawing.Size(663, 420)
        Me.splGlavni.SplitterDistance = 131
        Me.splGlavni.SplitterWidth = 1
        Me.splGlavni.TabIndex = 3
        '
        'splRadni
        '
        Me.splRadni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.splRadni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splRadni.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splRadni.Location = New System.Drawing.Point(0, 0)
        Me.splRadni.Name = "splRadni"
        Me.splRadni.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splRadni.Panel1
        '
        Me.splRadni.Panel1.BackColor = System.Drawing.Color.Lavender
        Me.splRadni.Panel1.Controls.Add(Me.labHeader)
        '
        'splRadni.Panel2
        '
        Me.splRadni.Panel2.BackgroundImage = Global.Farma.My.Resources.Resources.LaST__Cobalt__Books
        Me.splRadni.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.splRadni.Size = New System.Drawing.Size(531, 420)
        Me.splRadni.SplitterDistance = 30
        Me.splRadni.SplitterWidth = 1
        Me.splRadni.TabIndex = 1
        '
        'labHeader
        '
        Me.labHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labHeader.AutoSize = True
        Me.labHeader.BackColor = System.Drawing.Color.Transparent
        Me.labHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labHeader.ForeColor = System.Drawing.Color.MidnightBlue
        Me.labHeader.Location = New System.Drawing.Point(3, 5)
        Me.labHeader.Name = "labHeader"
        Me.labHeader.Size = New System.Drawing.Size(51, 15)
        Me.labHeader.TabIndex = 9
        Me.labHeader.Text = "Label1"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(669, 22)
        Me.StatusStrip.TabIndex = 0
        Me.StatusStrip.Text = "StatusStrip"
        '
        'StatusLabel
        '
        Me.StatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.StatusLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.StatusLabel.ForeColor = System.Drawing.Color.MidnightBlue
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(74, 17)
        Me.StatusLabel.Text = "StatusLabel"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.splGlavni, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.StatusStrip, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(669, 450)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'mdiMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(669, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "mdiMain"
        Me.Text = "Farma d.o.o."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.splGlavni.Panel2.ResumeLayout(False)
        Me.splGlavni.ResumeLayout(False)
        Me.splRadni.Panel1.ResumeLayout(False)
        Me.splRadni.Panel1.PerformLayout()
        Me.splRadni.ResumeLayout(False)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents splGlavni As System.Windows.Forms.SplitContainer
    Friend WithEvents splRadni As System.Windows.Forms.SplitContainer
    Friend WithEvents labHeader As System.Windows.Forms.Label
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel

End Class
