<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntSpecifikacije
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
        Me.cNaziv = New System.Windows.Forms.ColumnHeader
        Me.cCena = New System.Windows.Forms.ColumnHeader
        Me.cUlaz = New System.Windows.Forms.ColumnHeader
        Me.cIzlaz = New System.Windows.Forms.ColumnHeader
        Me.cStanje = New System.Windows.Forms.ColumnHeader
        Me.cDuguje = New System.Windows.Forms.ColumnHeader
        Me.cPotrazuje = New System.Windows.Forms.ColumnHeader
        Me.cSaldo = New System.Windows.Forms.ColumnHeader
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
        Me.spSpliter.Location = New System.Drawing.Point(13, 14)
        Me.spSpliter.Name = "spSpliter"
        Me.spSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.spSpliter.Panel1MinSize = 2
        '
        'spSpliter.Panel2
        '
        Me.spSpliter.Panel2.Controls.Add(Me.lvLista)
        Me.spSpliter.Size = New System.Drawing.Size(552, 390)
        Me.spSpliter.SplitterDistance = 225
        Me.spSpliter.SplitterWidth = 2
        Me.spSpliter.TabIndex = 3
        '
        'lvLista
        '
        Me.lvLista.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvLista.AutoArrange = False
        Me.lvLista.BackColor = System.Drawing.Color.GhostWhite
        Me.lvLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cNaziv, Me.cCena, Me.cUlaz, Me.cIzlaz, Me.cStanje, Me.cDuguje, Me.cPotrazuje, Me.cSaldo})
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
        Me.lvLista.Size = New System.Drawing.Size(548, 159)
        Me.lvLista.TabIndex = 21
        Me.lvLista.UseCompatibleStateImageBehavior = False
        Me.lvLista.View = System.Windows.Forms.View.Details
        Me.lvLista.Visible = False
        '
        'cNaziv
        '
        Me.cNaziv.Text = "Naziv"
        Me.cNaziv.Width = 200
        '
        'cCena
        '
        Me.cCena.Text = "Cena"
        Me.cCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cCena.Width = 90
        '
        'cUlaz
        '
        Me.cUlaz.Text = "Ulaz"
        Me.cUlaz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cUlaz.Width = 90
        '
        'cIzlaz
        '
        Me.cIzlaz.Text = "Izlaz"
        Me.cIzlaz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cIzlaz.Width = 90
        '
        'cStanje
        '
        Me.cStanje.Text = "Stanje"
        Me.cStanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cStanje.Width = 90
        '
        'cDuguje
        '
        Me.cDuguje.Text = "Duguje"
        Me.cDuguje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cDuguje.Width = 90
        '
        'cPotrazuje
        '
        Me.cPotrazuje.Text = "Potražuje"
        Me.cPotrazuje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cPotrazuje.Width = 90
        '
        'cSaldo
        '
        Me.cSaldo.Text = "Saldo"
        Me.cSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cSaldo.Width = 90
        '
        'cntSpecifikacije
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.spSpliter)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntSpecifikacije"
        Me.Size = New System.Drawing.Size(578, 421)
        Me.spSpliter.Panel2.ResumeLayout(False)
        Me.spSpliter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spSpliter As System.Windows.Forms.SplitContainer
    Friend WithEvents lvLista As System.Windows.Forms.ListView
    Friend WithEvents cNaziv As System.Windows.Forms.ColumnHeader
    Friend WithEvents cCena As System.Windows.Forms.ColumnHeader
    Friend WithEvents cUlaz As System.Windows.Forms.ColumnHeader
    Friend WithEvents cIzlaz As System.Windows.Forms.ColumnHeader
    Friend WithEvents cStanje As System.Windows.Forms.ColumnHeader
    Friend WithEvents cDuguje As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPotrazuje As System.Windows.Forms.ColumnHeader
    Friend WithEvents cSaldo As System.Windows.Forms.ColumnHeader

End Class
