<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntArtikli
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
        Me.cNaziv_n = New System.Windows.Forms.ColumnHeader
        Me.cJm_n = New System.Windows.Forms.ColumnHeader
        Me.cGrupaNa_n = New System.Windows.Forms.ColumnHeader
        Me.cJkl_n = New System.Windows.Forms.ColumnHeader
        Me.cProizvodjac_n = New System.Windows.Forms.ColumnHeader
        Me.lvLista = New System.Windows.Forms.ListView
        Me.cSifra_n = New System.Windows.Forms.ColumnHeader
        Me.cGrupaSi_n = New System.Windows.Forms.ColumnHeader
        Me.cGenericko_n = New System.Windows.Forms.ColumnHeader
        Me.cL1_n = New System.Windows.Forms.ColumnHeader
        Me.cFOsifra = New System.Windows.Forms.ColumnHeader
        Me.cFOnaziv = New System.Windows.Forms.ColumnHeader
        Me.spSpliter = New System.Windows.Forms.SplitContainer
        Me.spSpliter.Panel2.SuspendLayout()
        Me.spSpliter.SuspendLayout()
        Me.SuspendLayout()
        '
        'cNaziv_n
        '
        Me.cNaziv_n.Text = "Naziv"
        Me.cNaziv_n.Width = 200
        '
        'cJm_n
        '
        Me.cJm_n.Text = "jm"
        Me.cJm_n.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cJm_n.Width = 50
        '
        'cGrupaNa_n
        '
        Me.cGrupaNa_n.Text = "Grupa - naziv"
        Me.cGrupaNa_n.Width = 150
        '
        'cJkl_n
        '
        Me.cJkl_n.Text = "JKL šifra"
        Me.cJkl_n.Width = 80
        '
        'cProizvodjac_n
        '
        Me.cProizvodjac_n.Text = "Proizvodjač"
        Me.cProizvodjac_n.Width = 200
        '
        'lvLista
        '
        Me.lvLista.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvLista.AutoArrange = False
        Me.lvLista.BackColor = System.Drawing.Color.GhostWhite
        Me.lvLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cSifra_n, Me.cNaziv_n, Me.cGrupaSi_n, Me.cGrupaNa_n, Me.cJkl_n, Me.cGenericko_n, Me.cL1_n, Me.cJm_n, Me.cFOsifra, Me.cFOnaziv, Me.cProizvodjac_n})
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
        'cSifra_n
        '
        Me.cSifra_n.Text = "Šifra"
        Me.cSifra_n.Width = 80
        '
        'cGrupaSi_n
        '
        Me.cGrupaSi_n.Text = "Grupa - šifra"
        Me.cGrupaSi_n.Width = 100
        '
        'cGenericko_n
        '
        Me.cGenericko_n.Text = "Gen.naziv"
        Me.cGenericko_n.Width = 100
        '
        'cL1_n
        '
        Me.cL1_n.Text = "L1"
        Me.cL1_n.Width = 50
        '
        'cFOsifra
        '
        Me.cFOsifra.Text = "FO Šifra"
        '
        'cFOnaziv
        '
        Me.cFOnaziv.Text = "FO Naziv"
        Me.cFOnaziv.Width = 80
        '
        'spSpliter
        '
        Me.spSpliter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.spSpliter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.spSpliter.ForeColor = System.Drawing.Color.MidnightBlue
        Me.spSpliter.IsSplitterFixed = True
        Me.spSpliter.Location = New System.Drawing.Point(13, 15)
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
        Me.spSpliter.TabIndex = 0
        '
        'cntArtikli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.spSpliter)
        Me.Name = "cntArtikli"
        Me.Size = New System.Drawing.Size(784, 462)
        Me.spSpliter.Panel2.ResumeLayout(False)
        Me.spSpliter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvLista As System.Windows.Forms.ListView
    Friend WithEvents cNaziv_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cJm_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cGrupaNa_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cJkl_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cProizvodjac_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents spSpliter As System.Windows.Forms.SplitContainer
    Friend WithEvents cSifra_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cGrupaSi_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cGenericko_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cL1_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cFOsifra As System.Windows.Forms.ColumnHeader
    Friend WithEvents cFOnaziv As System.Windows.Forms.ColumnHeader

End Class
