<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntDPromet
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
        Me.lvArtikl = New System.Windows.Forms.ListView
        Me.Datum = New System.Windows.Forms.ColumnHeader
        Me.SifraMag = New System.Windows.Forms.ColumnHeader
        Me.VrstaDok = New System.Windows.Forms.ColumnHeader
        Me.BrDok = New System.Windows.Forms.ColumnHeader
        Me.Sifra = New System.Windows.Forms.ColumnHeader
        Me.Naziv = New System.Windows.Forms.ColumnHeader
        Me.Ulaz = New System.Windows.Forms.ColumnHeader
        Me.Izlaz = New System.Windows.Forms.ColumnHeader
        Me.Stanje = New System.Windows.Forms.ColumnHeader
        Me.Cena = New System.Windows.Forms.ColumnHeader
        Me.lvLista = New System.Windows.Forms.ListView
        Me.cDatum = New System.Windows.Forms.ColumnHeader
        Me.cMagacin = New System.Windows.Forms.ColumnHeader
        Me.cRbDok = New System.Windows.Forms.ColumnHeader
        Me.cVrDok = New System.Windows.Forms.ColumnHeader
        Me.cZakljuceno = New System.Windows.Forms.ColumnHeader
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
        Me.spSpliter.Location = New System.Drawing.Point(14, 12)
        Me.spSpliter.Name = "spSpliter"
        Me.spSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.spSpliter.Panel1MinSize = 2
        '
        'spSpliter.Panel2
        '
        Me.spSpliter.Panel2.Controls.Add(Me.lvArtikl)
        Me.spSpliter.Panel2.Controls.Add(Me.lvLista)
        Me.spSpliter.Size = New System.Drawing.Size(820, 425)
        Me.spSpliter.SplitterDistance = 225
        Me.spSpliter.SplitterWidth = 2
        Me.spSpliter.TabIndex = 1
        '
        'lvArtikl
        '
        Me.lvArtikl.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvArtikl.AutoArrange = False
        Me.lvArtikl.BackColor = System.Drawing.Color.GhostWhite
        Me.lvArtikl.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Datum, Me.SifraMag, Me.VrstaDok, Me.BrDok, Me.Sifra, Me.Naziv, Me.Ulaz, Me.Izlaz, Me.Stanje, Me.Cena})
        Me.lvArtikl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lvArtikl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lvArtikl.FullRowSelect = True
        Me.lvArtikl.GridLines = True
        Me.lvArtikl.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvArtikl.HideSelection = False
        Me.lvArtikl.LabelEdit = True
        Me.lvArtikl.Location = New System.Drawing.Point(0, 89)
        Me.lvArtikl.MultiSelect = False
        Me.lvArtikl.Name = "lvArtikl"
        Me.lvArtikl.Size = New System.Drawing.Size(813, 83)
        Me.lvArtikl.TabIndex = 21
        Me.lvArtikl.UseCompatibleStateImageBehavior = False
        Me.lvArtikl.View = System.Windows.Forms.View.Details
        Me.lvArtikl.Visible = False
        '
        'Datum
        '
        Me.Datum.Text = "Datum"
        Me.Datum.Width = 70
        '
        'SifraMag
        '
        Me.SifraMag.Text = "Šifra Mag."
        Me.SifraMag.Width = 70
        '
        'VrstaDok
        '
        Me.VrstaDok.Text = "Vrsta Dok."
        Me.VrstaDok.Width = 70
        '
        'BrDok
        '
        Me.BrDok.Text = "Br.Dok."
        Me.BrDok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BrDok.Width = 55
        '
        'Sifra
        '
        Me.Sifra.Text = "Šifra"
        Me.Sifra.Width = 65
        '
        'Naziv
        '
        Me.Naziv.Text = "Naziv"
        Me.Naziv.Width = 240
        '
        'Ulaz
        '
        Me.Ulaz.Text = "Ulaz"
        Me.Ulaz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Ulaz.Width = 70
        '
        'Izlaz
        '
        Me.Izlaz.Text = "Izlaz"
        Me.Izlaz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Izlaz.Width = 70
        '
        'Stanje
        '
        Me.Stanje.Text = "Stanje"
        Me.Stanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Stanje.Width = 70
        '
        'Cena
        '
        Me.Cena.Text = "Cena"
        Me.Cena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Cena.Width = 70
        '
        'lvLista
        '
        Me.lvLista.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvLista.AutoArrange = False
        Me.lvLista.BackColor = System.Drawing.Color.GhostWhite
        Me.lvLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cDatum, Me.cMagacin, Me.cRbDok, Me.cVrDok, Me.cZakljuceno})
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
        Me.lvLista.Size = New System.Drawing.Size(799, 83)
        Me.lvLista.TabIndex = 20
        Me.lvLista.UseCompatibleStateImageBehavior = False
        Me.lvLista.View = System.Windows.Forms.View.Details
        Me.lvLista.Visible = False
        '
        'cDatum
        '
        Me.cDatum.Text = "Datum"
        Me.cDatum.Width = 100
        '
        'cMagacin
        '
        Me.cMagacin.Text = "Magacin"
        Me.cMagacin.Width = 350
        '
        'cRbDok
        '
        Me.cRbDok.Text = "Rb.Dokumenta"
        Me.cRbDok.Width = 70
        '
        'cVrDok
        '
        Me.cVrDok.Text = "Dokument"
        Me.cVrDok.Width = 100
        '
        'cZakljuceno
        '
        Me.cZakljuceno.Text = "Zaključeno"
        Me.cZakljuceno.Width = 100
        '
        'cntDPromet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.spSpliter)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntDPromet"
        Me.Size = New System.Drawing.Size(854, 454)
        Me.spSpliter.Panel2.ResumeLayout(False)
        Me.spSpliter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spSpliter As System.Windows.Forms.SplitContainer
    Friend WithEvents lvLista As System.Windows.Forms.ListView
    Friend WithEvents cDatum As System.Windows.Forms.ColumnHeader
    Friend WithEvents cVrDok As System.Windows.Forms.ColumnHeader
    Friend WithEvents cMagacin As System.Windows.Forms.ColumnHeader
    Friend WithEvents cZakljuceno As System.Windows.Forms.ColumnHeader
    Friend WithEvents cRbDok As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvArtikl As System.Windows.Forms.ListView
    Friend WithEvents Datum As System.Windows.Forms.ColumnHeader
    Friend WithEvents Sifra As System.Windows.Forms.ColumnHeader
    Friend WithEvents Naziv As System.Windows.Forms.ColumnHeader
    Friend WithEvents Ulaz As System.Windows.Forms.ColumnHeader
    Friend WithEvents Izlaz As System.Windows.Forms.ColumnHeader
    Friend WithEvents Stanje As System.Windows.Forms.ColumnHeader
    Friend WithEvents VrstaDok As System.Windows.Forms.ColumnHeader
    Friend WithEvents BrDok As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cena As System.Windows.Forms.ColumnHeader
    Friend WithEvents SifraMag As System.Windows.Forms.ColumnHeader

End Class
