<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntJKL
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
        Me.lvJkl = New System.Windows.Forms.ListView
        Me.cSifra = New System.Windows.Forms.ColumnHeader
        Me.cNaziv = New System.Windows.Forms.ColumnHeader
        Me.cPozLista = New System.Windows.Forms.ColumnHeader
        Me.spSpliter = New System.Windows.Forms.SplitContainer
        Me.spSpliter.Panel2.SuspendLayout()
        Me.spSpliter.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvJkl
        '
        Me.lvJkl.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvJkl.AutoArrange = False
        Me.lvJkl.BackColor = System.Drawing.Color.GhostWhite
        Me.lvJkl.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cSifra, Me.cNaziv, Me.cPozLista})
        Me.lvJkl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvJkl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lvJkl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lvJkl.FullRowSelect = True
        Me.lvJkl.GridLines = True
        Me.lvJkl.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvJkl.HideSelection = False
        Me.lvJkl.LabelEdit = True
        Me.lvJkl.Location = New System.Drawing.Point(0, 0)
        Me.lvJkl.MultiSelect = False
        Me.lvJkl.Name = "lvJkl"
        Me.lvJkl.Size = New System.Drawing.Size(736, 301)
        Me.lvJkl.TabIndex = 19
        Me.lvJkl.UseCompatibleStateImageBehavior = False
        Me.lvJkl.View = System.Windows.Forms.View.Details
        Me.lvJkl.Visible = False
        '
        'cSifra
        '
        Me.cSifra.Tag = "Šifra"
        Me.cSifra.Text = "Šifra"
        Me.cSifra.Width = 100
        '
        'cNaziv
        '
        Me.cNaziv.Tag = "Naziv"
        Me.cNaziv.Text = "Naziv"
        Me.cNaziv.Width = 327
        '
        'cPozLista
        '
        Me.cPozLista.Text = "Pozitivna lista "
        Me.cPozLista.Width = 110
        '
        'spSpliter
        '
        Me.spSpliter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.spSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spSpliter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.spSpliter.ForeColor = System.Drawing.Color.MidnightBlue
        Me.spSpliter.IsSplitterFixed = True
        Me.spSpliter.Location = New System.Drawing.Point(0, 0)
        Me.spSpliter.Name = "spSpliter"
        Me.spSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.spSpliter.Panel1MinSize = 2
        '
        'spSpliter.Panel2
        '
        Me.spSpliter.Panel2.Controls.Add(Me.lvJkl)
        Me.spSpliter.Size = New System.Drawing.Size(740, 497)
        Me.spSpliter.SplitterDistance = 190
        Me.spSpliter.SplitterWidth = 2
        Me.spSpliter.TabIndex = 9
        '
        'cntJKL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.spSpliter)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntJKL"
        Me.Size = New System.Drawing.Size(740, 497)
        Me.spSpliter.Panel2.ResumeLayout(False)
        Me.spSpliter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvJkl As System.Windows.Forms.ListView
    Friend WithEvents cSifra As System.Windows.Forms.ColumnHeader
    Friend WithEvents cNaziv As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPozLista As System.Windows.Forms.ColumnHeader
    Friend WithEvents spSpliter As System.Windows.Forms.SplitContainer

End Class
