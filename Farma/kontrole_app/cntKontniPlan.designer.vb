<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntKontniPlan
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
        Me.cDozvoljenoKnj = New System.Windows.Forms.ColumnHeader
        Me.cImaAnalitiku = New System.Windows.Forms.ColumnHeader
        Me.cPocetnoStanje = New System.Windows.Forms.ColumnHeader
        Me.cAktivaPasiva = New System.Windows.Forms.ColumnHeader
        Me.cBilanVanbilan = New System.Windows.Forms.ColumnHeader
        Me.cVazi_Do = New System.Windows.Forms.ColumnHeader
        Me.cPasiviziran = New System.Windows.Forms.ColumnHeader
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
        Me.spSpliter.Location = New System.Drawing.Point(13, 12)
        Me.spSpliter.Name = "spSpliter"
        Me.spSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.spSpliter.Panel1MinSize = 2
        '
        'spSpliter.Panel2
        '
        Me.spSpliter.Panel2.Controls.Add(Me.lvLista)
        Me.spSpliter.Size = New System.Drawing.Size(779, 473)
        Me.spSpliter.SplitterDistance = 225
        Me.spSpliter.SplitterWidth = 2
        Me.spSpliter.TabIndex = 3
        '
        'lvLista
        '
        Me.lvLista.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvLista.AutoArrange = False
        Me.lvLista.BackColor = System.Drawing.Color.GhostWhite
        Me.lvLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cSifra, Me.cNaziv, Me.cDozvoljenoKnj, Me.cImaAnalitiku, Me.cPocetnoStanje, Me.cAktivaPasiva, Me.cBilanVanbilan, Me.cVazi_Do, Me.cPasiviziran})
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
        Me.lvLista.Size = New System.Drawing.Size(775, 242)
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
        'cDozvoljenoKnj
        '
        Me.cDozvoljenoKnj.Text = "Dozv. Knj."
        Me.cDozvoljenoKnj.Width = 70
        '
        'cImaAnalitiku
        '
        Me.cImaAnalitiku.Text = "Ima Analit."
        Me.cImaAnalitiku.Width = 70
        '
        'cPocetnoStanje
        '
        Me.cPocetnoStanje.Text = "Poč.Stanje"
        Me.cPocetnoStanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cPocetnoStanje.Width = 75
        '
        'cAktivaPasiva
        '
        Me.cAktivaPasiva.Text = "Akt./Pas."
        Me.cAktivaPasiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cAktivaPasiva.Width = 70
        '
        'cBilanVanbilan
        '
        Me.cBilanVanbilan.Text = "Bil./Vanbil."
        Me.cBilanVanbilan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cBilanVanbilan.Width = 70
        '
        'cVazi_Do
        '
        Me.cVazi_Do.Text = "Važi Do"
        '
        'cPasiviziran
        '
        Me.cPasiviziran.Text = "Pasiviziran"
        Me.cPasiviziran.Width = 75
        '
        'cntKontniPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.spSpliter)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntKontniPlan"
        Me.Size = New System.Drawing.Size(813, 506)
        Me.spSpliter.Panel2.ResumeLayout(False)
        Me.spSpliter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spSpliter As System.Windows.Forms.SplitContainer
    Friend WithEvents lvLista As System.Windows.Forms.ListView
    Friend WithEvents cSifra As System.Windows.Forms.ColumnHeader
    Friend WithEvents cNaziv As System.Windows.Forms.ColumnHeader
    Friend WithEvents cDozvoljenoKnj As System.Windows.Forms.ColumnHeader
    Friend WithEvents cImaAnalitiku As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPocetnoStanje As System.Windows.Forms.ColumnHeader
    Friend WithEvents cAktivaPasiva As System.Windows.Forms.ColumnHeader
    Friend WithEvents cBilanVanbilan As System.Windows.Forms.ColumnHeader
    Friend WithEvents cVazi_Do As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPasiviziran As System.Windows.Forms.ColumnHeader

End Class
