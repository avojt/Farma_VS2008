<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntGrupeArt
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
        Me.cSifra_n = New System.Windows.Forms.ColumnHeader
        Me.cNaziv_n = New System.Windows.Forms.ColumnHeader
        Me.cSkraceno_n = New System.Windows.Forms.ColumnHeader
        Me.cNadredjena_n = New System.Windows.Forms.ColumnHeader
        Me.cPoslednji_n = New System.Windows.Forms.ColumnHeader
        Me.cMarza_n = New System.Windows.Forms.ColumnHeader
        Me.cPdv_n = New System.Windows.Forms.ColumnHeader
        Me.cLek = New System.Windows.Forms.ColumnHeader
        Me.cL1 = New System.Windows.Forms.ColumnHeader
        Me.cIzdajese = New System.Windows.Forms.ColumnHeader
        Me.spSpliter.Panel2.SuspendLayout()
        Me.spSpliter.SuspendLayout()
        Me.SuspendLayout()
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
        Me.spSpliter.Panel2.Controls.Add(Me.lvLista)
        Me.spSpliter.Size = New System.Drawing.Size(662, 473)
        Me.spSpliter.SplitterDistance = 190
        Me.spSpliter.SplitterWidth = 2
        Me.spSpliter.TabIndex = 2
        '
        'lvLista
        '
        Me.lvLista.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvLista.AutoArrange = False
        Me.lvLista.BackColor = System.Drawing.Color.GhostWhite
        Me.lvLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cSifra_n, Me.cNaziv_n, Me.cSkraceno_n, Me.cNadredjena_n, Me.cPoslednji_n, Me.cMarza_n, Me.cPdv_n, Me.cLek, Me.cL1, Me.cIzdajese})
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
        Me.lvLista.Size = New System.Drawing.Size(658, 277)
        Me.lvLista.TabIndex = 20
        Me.lvLista.UseCompatibleStateImageBehavior = False
        Me.lvLista.View = System.Windows.Forms.View.Details
        Me.lvLista.Visible = False
        '
        'cSifra_n
        '
        Me.cSifra_n.Text = "Šifra"
        Me.cSifra_n.Width = 80
        '
        'cNaziv_n
        '
        Me.cNaziv_n.Text = "Naziv"
        Me.cNaziv_n.Width = 220
        '
        'cSkraceno_n
        '
        Me.cSkraceno_n.Text = "Skraćeno"
        Me.cSkraceno_n.Width = 80
        '
        'cNadredjena_n
        '
        Me.cNadredjena_n.Text = "Nadredj. gr."
        Me.cNadredjena_n.Width = 80
        '
        'cPoslednji_n
        '
        Me.cPoslednji_n.Text = "Poslednji nivo"
        Me.cPoslednji_n.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cPoslednji_n.Width = 90
        '
        'cMarza_n
        '
        Me.cMarza_n.Text = "Marza"
        Me.cMarza_n.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cPdv_n
        '
        Me.cPdv_n.Text = "Pdv"
        Me.cPdv_n.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cLek
        '
        Me.cLek.Text = "Lek"
        Me.cLek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cL1
        '
        Me.cL1.Text = "L1"
        Me.cL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cIzdajese
        '
        Me.cIzdajese.Text = "Dokument"
        Me.cIzdajese.Width = 90
        '
        'cntGrupeArt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.spSpliter)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntGrupeArt"
        Me.Size = New System.Drawing.Size(662, 473)
        Me.spSpliter.Panel2.ResumeLayout(False)
        Me.spSpliter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spSpliter As System.Windows.Forms.SplitContainer
    Friend WithEvents lvLista As System.Windows.Forms.ListView
    Friend WithEvents cSifra_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cNaziv_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cNadredjena_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPoslednji_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPdv_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cMarza_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cSkraceno_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cLek As System.Windows.Forms.ColumnHeader
    Friend WithEvents cL1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cIzdajese As System.Windows.Forms.ColumnHeader

End Class
