<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntKnjizZaduzIzlaz
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
        Me.spSpliter = New System.Windows.Forms.SplitContainer
        Me.lvLista = New System.Windows.Forms.ListView
        Me.cBroj = New System.Windows.Forms.ColumnHeader
        Me.cDatum = New System.Windows.Forms.ColumnHeader
        Me.cMagacin = New System.Windows.Forms.ColumnHeader
        Me.cOJ = New System.Windows.Forms.ColumnHeader
        Me.cSvega = New System.Windows.Forms.ColumnHeader
        Me.cUnesena = New System.Windows.Forms.ColumnHeader
        Me.spSpliter.Panel2.SuspendLayout()
        Me.spSpliter.SuspendLayout()
        Me.SuspendLayout()
        '
        'spSpliter
        '
        Me.spSpliter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.spSpliter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.spSpliter.ForeColor = System.Drawing.Color.MidnightBlue
        Me.spSpliter.IsSplitterFixed = True
        Me.spSpliter.Location = New System.Drawing.Point(15, 13)
        Me.spSpliter.Name = "spSpliter"
        Me.spSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.spSpliter.Panel1MinSize = 2
        '
        'spSpliter.Panel2
        '
        Me.spSpliter.Panel2.Controls.Add(Me.lvLista)
        Me.spSpliter.Size = New System.Drawing.Size(718, 451)
        Me.spSpliter.SplitterDistance = 200
        Me.spSpliter.SplitterWidth = 2
        Me.spSpliter.TabIndex = 5
        '
        'lvLista
        '
        Me.lvLista.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvLista.AutoArrange = False
        Me.lvLista.BackColor = System.Drawing.Color.GhostWhite
        Me.lvLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cBroj, Me.cDatum, Me.cMagacin, Me.cOJ, Me.cSvega, Me.cUnesena})
        Me.lvLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lvLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lvLista.FullRowSelect = True
        Me.lvLista.GridLines = True
        Me.lvLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvLista.HideSelection = False
        Me.lvLista.LabelEdit = True
        Me.lvLista.Location = New System.Drawing.Point(0, 0)
        Me.lvLista.MultiSelect = False
        Me.lvLista.Name = "lvLista"
        Me.lvLista.Size = New System.Drawing.Size(714, 245)
        Me.lvLista.TabIndex = 20
        Me.lvLista.UseCompatibleStateImageBehavior = False
        Me.lvLista.View = System.Windows.Forms.View.Details
        Me.lvLista.Visible = False
        '
        'cBroj
        '
        Me.cBroj.Text = "Broj"
        Me.cBroj.Width = 50
        '
        'cDatum
        '
        Me.cDatum.Text = "Datum"
        Me.cDatum.Width = 85
        '
        'cMagacin
        '
        Me.cMagacin.Text = "Magacin"
        Me.cMagacin.Width = 320
        '
        'cOJ
        '
        Me.cOJ.Text = "Org.Jedinica"
        Me.cOJ.Width = 170
        '
        'cSvega
        '
        Me.cSvega.Text = "Svega"
        Me.cSvega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cSvega.Width = 100
        '
        'cUnesena
        '
        Me.cUnesena.Text = "Zakljuèena"
        Me.cUnesena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cUnesena.Width = 65
        '
        'cntKnjizZaduzIzlaz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.spSpliter)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntKnjizZaduzIzlaz"
        Me.Size = New System.Drawing.Size(744, 478)
        Me.spSpliter.Panel2.ResumeLayout(False)
        Me.spSpliter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spSpliter As System.Windows.Forms.SplitContainer
    Friend WithEvents lvLista As System.Windows.Forms.ListView
    Friend WithEvents cBroj As System.Windows.Forms.ColumnHeader
    Friend WithEvents cDatum As System.Windows.Forms.ColumnHeader
    Friend WithEvents cMagacin As System.Windows.Forms.ColumnHeader
    Friend WithEvents cOJ As System.Windows.Forms.ColumnHeader
    Friend WithEvents cSvega As System.Windows.Forms.ColumnHeader
    Friend WithEvents cUnesena As System.Windows.Forms.ColumnHeader

End Class
