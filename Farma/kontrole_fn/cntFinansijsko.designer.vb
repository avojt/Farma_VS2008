<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntNalog
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
        Me.spSpliter = New System.Windows.Forms.SplitContainer
        Me.lvLista = New System.Windows.Forms.ListView
        Me.cVrsta = New System.Windows.Forms.ColumnHeader
        Me.cBroj = New System.Windows.Forms.ColumnHeader
        Me.cDatum = New System.Windows.Forms.ColumnHeader
        Me.cDuguje = New System.Windows.Forms.ColumnHeader
        Me.cPotrazuje = New System.Windows.Forms.ColumnHeader
        Me.cSaldo = New System.Windows.Forms.ColumnHeader
        Me.cProknjizen = New System.Windows.Forms.ColumnHeader
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
        Me.spSpliter.Location = New System.Drawing.Point(15, 15)
        Me.spSpliter.Name = "spSpliter"
        Me.spSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.spSpliter.Panel1MinSize = 2
        '
        'spSpliter.Panel2
        '
        Me.spSpliter.Panel2.Controls.Add(Me.lvLista)
        Me.spSpliter.Size = New System.Drawing.Size(730, 422)
        Me.spSpliter.SplitterDistance = 200
        Me.spSpliter.SplitterWidth = 2
        Me.spSpliter.TabIndex = 2
        '
        'lvLista
        '
        Me.lvLista.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvLista.AutoArrange = False
        Me.lvLista.BackColor = System.Drawing.Color.GhostWhite
        Me.lvLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cVrsta, Me.cBroj, Me.cDatum, Me.cDuguje, Me.cPotrazuje, Me.cSaldo, Me.cProknjizen})
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
        Me.lvLista.Size = New System.Drawing.Size(726, 216)
        Me.lvLista.TabIndex = 20
        Me.lvLista.UseCompatibleStateImageBehavior = False
        Me.lvLista.View = System.Windows.Forms.View.Details
        Me.lvLista.Visible = False
        '
        'cVrsta
        '
        Me.cVrsta.Text = "Vrsta"
        Me.cVrsta.Width = 70
        '
        'cBroj
        '
        Me.cBroj.Text = "Broj"
        Me.cBroj.Width = 70
        '
        'cDatum
        '
        Me.cDatum.Text = "Datum"
        Me.cDatum.Width = 90
        '
        'cDuguje
        '
        Me.cDuguje.Text = "Duguje"
        Me.cDuguje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cDuguje.Width = 110
        '
        'cPotrazuje
        '
        Me.cPotrazuje.Text = "Potražuje"
        Me.cPotrazuje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cPotrazuje.Width = 110
        '
        'cSaldo
        '
        Me.cSaldo.Text = "Saldo"
        Me.cSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cSaldo.Width = 110
        '
        'cProknjizen
        '
        Me.cProknjizen.Text = "Proknjižen"
        Me.cProknjizen.Width = 75
        '
        'cntNalog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.spSpliter)
        Me.Name = "cntNalog"
        Me.Size = New System.Drawing.Size(775, 471)
        Me.spSpliter.Panel2.ResumeLayout(False)
        Me.spSpliter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spSpliter As System.Windows.Forms.SplitContainer
    Friend WithEvents lvLista As System.Windows.Forms.ListView
    Friend WithEvents cBroj As System.Windows.Forms.ColumnHeader
    Friend WithEvents cDatum As System.Windows.Forms.ColumnHeader
    Friend WithEvents cDuguje As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPotrazuje As System.Windows.Forms.ColumnHeader
    Friend WithEvents cVrsta As System.Windows.Forms.ColumnHeader
    Friend WithEvents cSaldo As System.Windows.Forms.ColumnHeader
    Friend WithEvents cProknjizen As System.Windows.Forms.ColumnHeader

End Class
