<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntPartneri
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
        Me.cSifra = New System.Windows.Forms.ColumnHeader
        Me.cNaziv = New System.Windows.Forms.ColumnHeader
        Me.cMesto = New System.Windows.Forms.ColumnHeader
        Me.cPIB = New System.Windows.Forms.ColumnHeader
        Me.cProizvodjac = New System.Windows.Forms.ColumnHeader
        Me.cDobavljac = New System.Windows.Forms.ColumnHeader
        Me.cKupac = New System.Windows.Forms.ColumnHeader
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
        Me.spSpliter.Location = New System.Drawing.Point(30, 25)
        Me.spSpliter.Name = "spSpliter"
        Me.spSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.spSpliter.Panel1MinSize = 2
        '
        'spSpliter.Panel2
        '
        Me.spSpliter.Panel2.Controls.Add(Me.lvLista)
        Me.spSpliter.Size = New System.Drawing.Size(734, 421)
        Me.spSpliter.SplitterDistance = 225
        Me.spSpliter.SplitterWidth = 2
        Me.spSpliter.TabIndex = 1
        '
        'lvLista
        '
        Me.lvLista.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvLista.AutoArrange = False
        Me.lvLista.BackColor = System.Drawing.Color.GhostWhite
        Me.lvLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cSifra, Me.cNaziv, Me.cMesto, Me.cPIB, Me.cProizvodjac, Me.cDobavljac, Me.cKupac})
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
        Me.lvLista.Size = New System.Drawing.Size(730, 190)
        Me.lvLista.TabIndex = 20
        Me.lvLista.UseCompatibleStateImageBehavior = False
        Me.lvLista.View = System.Windows.Forms.View.Details
        Me.lvLista.Visible = False
        '
        'cSifra
        '
        Me.cSifra.Text = "Šifra"
        Me.cSifra.Width = 80
        '
        'cNaziv
        '
        Me.cNaziv.Text = "Naziv"
        Me.cNaziv.Width = 200
        '
        'cMesto
        '
        Me.cMesto.Text = "Mesto"
        Me.cMesto.Width = 100
        '
        'cPIB
        '
        Me.cPIB.Text = "PIB"
        Me.cPIB.Width = 100
        '
        'cProizvodjac
        '
        Me.cProizvodjac.Text = "Proizvodjač"
        Me.cProizvodjac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cProizvodjac.Width = 80
        '
        'cDobavljac
        '
        Me.cDobavljac.Text = "Dobavljač"
        Me.cDobavljac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cDobavljac.Width = 80
        '
        'cKupac
        '
        Me.cKupac.Text = "Kupac"
        Me.cKupac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cKupac.Width = 80
        '
        'cntPartneri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.spSpliter)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntPartneri"
        Me.Size = New System.Drawing.Size(784, 479)
        Me.spSpliter.Panel2.ResumeLayout(False)
        Me.spSpliter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spSpliter As System.Windows.Forms.SplitContainer
    Friend WithEvents lvLista As System.Windows.Forms.ListView
    Friend WithEvents cSifra As System.Windows.Forms.ColumnHeader
    Friend WithEvents cNaziv As System.Windows.Forms.ColumnHeader
    Friend WithEvents cMesto As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPIB As System.Windows.Forms.ColumnHeader
    Friend WithEvents cProizvodjac As System.Windows.Forms.ColumnHeader
    Friend WithEvents cDobavljac As System.Windows.Forms.ColumnHeader
    Friend WithEvents cKupac As System.Windows.Forms.ColumnHeader


End Class
