<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartneriEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPartneriEdit))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tlbSnimi = New System.Windows.Forms.ToolStripButton
        Me.tlbEnd = New System.Windows.Forms.ToolStripButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtNaziv = New System.Windows.Forms.TextBox
        Me.txtSifra = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTelefon = New System.Windows.Forms.TextBox
        Me.txtZR = New System.Windows.Forms.TextBox
        Me.txtRegistarski = New System.Windows.Forms.TextBox
        Me.txtMaticni = New System.Windows.Forms.TextBox
        Me.txtPib = New System.Windows.Forms.TextBox
        Me.txtMesto = New System.Windows.Forms.TextBox
        Me.txtAdresa = New System.Windows.Forms.TextBox
        Me.chkKupac = New System.Windows.Forms.CheckBox
        Me.chkDobavljac = New System.Windows.Forms.CheckBox
        Me.chkProizvodjac = New System.Windows.Forms.CheckBox
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbSnimi, Me.tlbEnd})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(427, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tlbSnimi
        '
        Me.tlbSnimi.Image = Global.Farma.My.Resources.Resources.LaST__Cobalt__Floppy
        Me.tlbSnimi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbSnimi.Name = "tlbSnimi"
        Me.tlbSnimi.Size = New System.Drawing.Size(51, 22)
        Me.tlbSnimi.Text = "Snimi"
        '
        'tlbEnd
        '
        Me.tlbEnd.Image = Global.Farma.My.Resources.Resources.logoff
        Me.tlbEnd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbEnd.Name = "tlbEnd"
        Me.tlbEnd.Size = New System.Drawing.Size(46, 22)
        Me.tlbEnd.Text = "Kraj"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel1.Controls.Add(Me.txtNaziv)
        Me.Panel1.Controls.Add(Me.txtSifra)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(13, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(404, 64)
        Me.Panel1.TabIndex = 34
        '
        'txtNaziv
        '
        Me.txtNaziv.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNaziv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNaziv.Location = New System.Drawing.Point(117, 25)
        Me.txtNaziv.Name = "txtNaziv"
        Me.txtNaziv.Size = New System.Drawing.Size(277, 20)
        Me.txtNaziv.TabIndex = 2
        '
        'txtSifra
        '
        Me.txtSifra.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSifra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSifra.Location = New System.Drawing.Point(11, 25)
        Me.txtSifra.Name = "txtSifra"
        Me.txtSifra.Size = New System.Drawing.Size(100, 20)
        Me.txtSifra.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Šifra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(117, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Naziv"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(8, 244)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Telefon"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(214, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Žiro račun"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(11, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Registarski broj"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(214, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Matični broj"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(12, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "PIB"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(214, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Mesto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(11, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Adresa"
        '
        'txtTelefon
        '
        Me.txtTelefon.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTelefon.Location = New System.Drawing.Point(11, 259)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(406, 20)
        Me.txtTelefon.TabIndex = 26
        '
        'txtZR
        '
        Me.txtZR.BackColor = System.Drawing.Color.GhostWhite
        Me.txtZR.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtZR.Location = New System.Drawing.Point(217, 219)
        Me.txtZR.Name = "txtZR"
        Me.txtZR.Size = New System.Drawing.Size(200, 20)
        Me.txtZR.TabIndex = 25
        '
        'txtRegistarski
        '
        Me.txtRegistarski.BackColor = System.Drawing.Color.GhostWhite
        Me.txtRegistarski.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtRegistarski.Location = New System.Drawing.Point(11, 219)
        Me.txtRegistarski.Name = "txtRegistarski"
        Me.txtRegistarski.Size = New System.Drawing.Size(200, 20)
        Me.txtRegistarski.TabIndex = 24
        '
        'txtMaticni
        '
        Me.txtMaticni.BackColor = System.Drawing.Color.GhostWhite
        Me.txtMaticni.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMaticni.Location = New System.Drawing.Point(217, 178)
        Me.txtMaticni.Name = "txtMaticni"
        Me.txtMaticni.Size = New System.Drawing.Size(200, 20)
        Me.txtMaticni.TabIndex = 23
        '
        'txtPib
        '
        Me.txtPib.BackColor = System.Drawing.Color.GhostWhite
        Me.txtPib.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPib.Location = New System.Drawing.Point(11, 178)
        Me.txtPib.Name = "txtPib"
        Me.txtPib.Size = New System.Drawing.Size(200, 20)
        Me.txtPib.TabIndex = 22
        '
        'txtMesto
        '
        Me.txtMesto.BackColor = System.Drawing.Color.GhostWhite
        Me.txtMesto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMesto.Location = New System.Drawing.Point(217, 139)
        Me.txtMesto.Name = "txtMesto"
        Me.txtMesto.Size = New System.Drawing.Size(200, 20)
        Me.txtMesto.TabIndex = 21
        '
        'txtAdresa
        '
        Me.txtAdresa.BackColor = System.Drawing.Color.GhostWhite
        Me.txtAdresa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAdresa.Location = New System.Drawing.Point(11, 139)
        Me.txtAdresa.Name = "txtAdresa"
        Me.txtAdresa.Size = New System.Drawing.Size(200, 20)
        Me.txtAdresa.TabIndex = 20
        '
        'chkKupac
        '
        Me.chkKupac.AutoSize = True
        Me.chkKupac.Location = New System.Drawing.Point(359, 299)
        Me.chkKupac.Name = "chkKupac"
        Me.chkKupac.Size = New System.Drawing.Size(57, 17)
        Me.chkKupac.TabIndex = 37
        Me.chkKupac.Text = "Kupac"
        Me.chkKupac.UseVisualStyleBackColor = True
        '
        'chkDobavljac
        '
        Me.chkDobavljac.AutoSize = True
        Me.chkDobavljac.Location = New System.Drawing.Point(176, 299)
        Me.chkDobavljac.Name = "chkDobavljac"
        Me.chkDobavljac.Size = New System.Drawing.Size(74, 17)
        Me.chkDobavljac.TabIndex = 36
        Me.chkDobavljac.Text = "Dobavljač"
        Me.chkDobavljac.UseVisualStyleBackColor = True
        '
        'chkProizvodjac
        '
        Me.chkProizvodjac.AutoSize = True
        Me.chkProizvodjac.Location = New System.Drawing.Point(11, 299)
        Me.chkProizvodjac.Name = "chkProizvodjac"
        Me.chkProizvodjac.Size = New System.Drawing.Size(81, 17)
        Me.chkProizvodjac.TabIndex = 35
        Me.chkProizvodjac.Text = "Proizvodjač"
        Me.chkProizvodjac.UseVisualStyleBackColor = True
        '
        'frmPartneriEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(427, 340)
        Me.Controls.Add(Me.chkKupac)
        Me.Controls.Add(Me.chkDobavljac)
        Me.Controls.Add(Me.chkProizvodjac)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTelefon)
        Me.Controls.Add(Me.txtZR)
        Me.Controls.Add(Me.txtRegistarski)
        Me.Controls.Add(Me.txtMaticni)
        Me.Controls.Add(Me.txtPib)
        Me.Controls.Add(Me.txtMesto)
        Me.Controls.Add(Me.txtAdresa)
        Me.Controls.Add(Me.ToolStrip1)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPartneriEdit"
        Me.Text = "Partneri - Ažuriranje"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbSnimi As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbEnd As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtNaziv As System.Windows.Forms.TextBox
    Friend WithEvents txtSifra As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTelefon As System.Windows.Forms.TextBox
    Friend WithEvents txtZR As System.Windows.Forms.TextBox
    Friend WithEvents txtRegistarski As System.Windows.Forms.TextBox
    Friend WithEvents txtMaticni As System.Windows.Forms.TextBox
    Friend WithEvents txtPib As System.Windows.Forms.TextBox
    Friend WithEvents txtMesto As System.Windows.Forms.TextBox
    Friend WithEvents txtAdresa As System.Windows.Forms.TextBox
    Friend WithEvents chkKupac As System.Windows.Forms.CheckBox
    Friend WithEvents chkDobavljac As System.Windows.Forms.CheckBox
    Friend WithEvents chkProizvodjac As System.Windows.Forms.CheckBox
End Class
