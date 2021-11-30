<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArtikl_pick
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArtikl_pick))
        Me.txtNaziv = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnUnesi = New System.Windows.Forms.Button
        Me.lvLista = New System.Windows.Forms.ListView
        Me.cSifra = New System.Windows.Forms.ColumnHeader
        Me.cNaziv = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'txtNaziv
        '
        Me.txtNaziv.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNaziv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNaziv.Location = New System.Drawing.Point(83, 12)
        Me.txtNaziv.Name = "txtNaziv"
        Me.txtNaziv.Size = New System.Drawing.Size(234, 20)
        Me.txtNaziv.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Naziv artikla"
        '
        'btnUnesi
        '
        Me.btnUnesi.Location = New System.Drawing.Point(242, 191)
        Me.btnUnesi.Name = "btnUnesi"
        Me.btnUnesi.Size = New System.Drawing.Size(75, 23)
        Me.btnUnesi.TabIndex = 3
        Me.btnUnesi.Text = "UNESI"
        Me.btnUnesi.UseVisualStyleBackColor = True
        '
        'lvLista
        '
        Me.lvLista.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvLista.AutoArrange = False
        Me.lvLista.BackColor = System.Drawing.Color.GhostWhite
        Me.lvLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cSifra, Me.cNaziv})
        Me.lvLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lvLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lvLista.FullRowSelect = True
        Me.lvLista.GridLines = True
        Me.lvLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvLista.HideSelection = False
        Me.lvLista.LabelEdit = True
        Me.lvLista.Location = New System.Drawing.Point(12, 38)
        Me.lvLista.MultiSelect = False
        Me.lvLista.Name = "lvLista"
        Me.lvLista.Size = New System.Drawing.Size(305, 147)
        Me.lvLista.TabIndex = 21
        Me.lvLista.UseCompatibleStateImageBehavior = False
        Me.lvLista.View = System.Windows.Forms.View.Details
        '
        'cSifra
        '
        Me.cSifra.Text = "Šifra"
        Me.cSifra.Width = 90
        '
        'cNaziv
        '
        Me.cNaziv.Text = "Naziv"
        Me.cNaziv.Width = 210
        '
        'frmArtikl_pick
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(331, 222)
        Me.Controls.Add(Me.lvLista)
        Me.Controls.Add(Me.btnUnesi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNaziv)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmArtikl_pick"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Artikli"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNaziv As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUnesi As System.Windows.Forms.Button
    Friend WithEvents lvLista As System.Windows.Forms.ListView
    Friend WithEvents cSifra As System.Windows.Forms.ColumnHeader
    Friend WithEvents cNaziv As System.Windows.Forms.ColumnHeader
End Class
