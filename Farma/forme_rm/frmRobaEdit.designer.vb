<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRobaEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRobaEdit))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tlbSnimi = New System.Windows.Forms.ToolStripButton
        Me.tlbEnd = New System.Windows.Forms.ToolStripButton
        Me.txtMarza = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtBod = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtnabavnaE = New System.Windows.Forms.TextBox
        Me.chkBod = New System.Windows.Forms.CheckBox
        Me.txtEuro = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtRabat = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtNabavna = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMinKolicina = New System.Windows.Forms.TextBox
        Me.cmbPDV = New System.Windows.Forms.ComboBox
        Me.cmbKategorija = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtSifraOpis = New System.Windows.Forms.TextBox
        Me.txtNaziv = New System.Windows.Forms.TextBox
        Me.txtSifra = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtKolicina = New System.Windows.Forms.TextBox
        Me.txtCena = New System.Windows.Forms.TextBox
        Me.txtJM = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbSnimi, Me.tlbEnd})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(464, 25)
        Me.ToolStrip1.TabIndex = 22
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
        'txtMarza
        '
        Me.txtMarza.BackColor = System.Drawing.Color.GhostWhite
        Me.txtMarza.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMarza.Location = New System.Drawing.Point(263, 227)
        Me.txtMarza.Name = "txtMarza"
        Me.txtMarza.Size = New System.Drawing.Size(50, 20)
        Me.txtMarza.TabIndex = 63
        Me.txtMarza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(260, 211)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 13)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "Marža"
        '
        'txtBod
        '
        Me.txtBod.BackColor = System.Drawing.Color.GhostWhite
        Me.txtBod.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBod.Location = New System.Drawing.Point(14, 142)
        Me.txtBod.Name = "txtBod"
        Me.txtBod.Size = New System.Drawing.Size(62, 20)
        Me.txtBod.TabIndex = 42
        Me.txtBod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 127)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Cena boda"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(92, 211)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "€"
        '
        'txtnabavnaE
        '
        Me.txtnabavnaE.BackColor = System.Drawing.Color.GhostWhite
        Me.txtnabavnaE.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtnabavnaE.Location = New System.Drawing.Point(95, 227)
        Me.txtnabavnaE.Name = "txtnabavnaE"
        Me.txtnabavnaE.Size = New System.Drawing.Size(50, 20)
        Me.txtnabavnaE.TabIndex = 50
        Me.txtnabavnaE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkBod
        '
        Me.chkBod.AutoSize = True
        Me.chkBod.Location = New System.Drawing.Point(14, 168)
        Me.chkBod.Name = "chkBod"
        Me.chkBod.Size = New System.Drawing.Size(83, 17)
        Me.chkBod.TabIndex = 40
        Me.chkBod.Text = "U bodovima"
        Me.chkBod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkBod.UseVisualStyleBackColor = True
        '
        'txtEuro
        '
        Me.txtEuro.BackColor = System.Drawing.Color.GhostWhite
        Me.txtEuro.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtEuro.Location = New System.Drawing.Point(400, 227)
        Me.txtEuro.Name = "txtEuro"
        Me.txtEuro.Size = New System.Drawing.Size(50, 20)
        Me.txtEuro.TabIndex = 54
        Me.txtEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label11.Location = New System.Drawing.Point(398, 211)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "€"
        '
        'txtRabat
        '
        Me.txtRabat.BackColor = System.Drawing.Color.GhostWhite
        Me.txtRabat.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtRabat.Location = New System.Drawing.Point(151, 227)
        Me.txtRabat.Name = "txtRabat"
        Me.txtRabat.Size = New System.Drawing.Size(50, 20)
        Me.txtRabat.TabIndex = 51
        Me.txtRabat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(148, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Rabat"
        '
        'txtNabavna
        '
        Me.txtNabavna.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNabavna.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNabavna.Location = New System.Drawing.Point(14, 227)
        Me.txtNabavna.Name = "txtNabavna"
        Me.txtNabavna.Size = New System.Drawing.Size(75, 20)
        Me.txtNabavna.TabIndex = 49
        Me.txtNabavna.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(11, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Nabavna cena"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(191, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Min.Kol."
        '
        'txtMinKolicina
        '
        Me.txtMinKolicina.BackColor = System.Drawing.Color.GhostWhite
        Me.txtMinKolicina.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMinKolicina.Location = New System.Drawing.Point(194, 141)
        Me.txtMinKolicina.Name = "txtMinKolicina"
        Me.txtMinKolicina.Size = New System.Drawing.Size(50, 20)
        Me.txtMinKolicina.TabIndex = 47
        Me.txtMinKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbPDV
        '
        Me.cmbPDV.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbPDV.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbPDV.FormattingEnabled = True
        Me.cmbPDV.Location = New System.Drawing.Point(138, 141)
        Me.cmbPDV.Name = "cmbPDV"
        Me.cmbPDV.Size = New System.Drawing.Size(50, 21)
        Me.cmbPDV.TabIndex = 46
        '
        'cmbKategorija
        '
        Me.cmbKategorija.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbKategorija.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbKategorija.FormattingEnabled = True
        Me.cmbKategorija.Location = New System.Drawing.Point(250, 141)
        Me.cmbKategorija.Name = "cmbKategorija"
        Me.cmbKategorija.Size = New System.Drawing.Size(200, 21)
        Me.cmbKategorija.TabIndex = 48
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtSifraOpis)
        Me.Panel1.Controls.Add(Me.txtNaziv)
        Me.Panel1.Controls.Add(Me.txtSifra)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(14, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(436, 64)
        Me.Panel1.TabIndex = 55
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(76, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Opis šifre"
        '
        'txtSifraOpis
        '
        Me.txtSifraOpis.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSifraOpis.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSifraOpis.Location = New System.Drawing.Point(79, 25)
        Me.txtSifraOpis.Name = "txtSifraOpis"
        Me.txtSifraOpis.Size = New System.Drawing.Size(95, 20)
        Me.txtSifraOpis.TabIndex = 12
        '
        'txtNaziv
        '
        Me.txtNaziv.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNaziv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNaziv.Location = New System.Drawing.Point(180, 25)
        Me.txtNaziv.Name = "txtNaziv"
        Me.txtNaziv.Size = New System.Drawing.Size(245, 20)
        Me.txtNaziv.TabIndex = 2
        '
        'txtSifra
        '
        Me.txtSifra.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSifra.Enabled = False
        Me.txtSifra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSifra.Location = New System.Drawing.Point(11, 25)
        Me.txtSifra.Name = "txtSifra"
        Me.txtSifra.Size = New System.Drawing.Size(62, 20)
        Me.txtSifra.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(8, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Šifra"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(180, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Naziv"
        '
        'txtKolicina
        '
        Me.txtKolicina.BackColor = System.Drawing.Color.GhostWhite
        Me.txtKolicina.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtKolicina.Location = New System.Drawing.Point(207, 227)
        Me.txtKolicina.Name = "txtKolicina"
        Me.txtKolicina.Size = New System.Drawing.Size(50, 20)
        Me.txtKolicina.TabIndex = 52
        Me.txtKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCena
        '
        Me.txtCena.BackColor = System.Drawing.Color.GhostWhite
        Me.txtCena.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCena.Location = New System.Drawing.Point(319, 227)
        Me.txtCena.Name = "txtCena"
        Me.txtCena.Size = New System.Drawing.Size(75, 20)
        Me.txtCena.TabIndex = 53
        Me.txtCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtJM
        '
        Me.txtJM.BackColor = System.Drawing.Color.GhostWhite
        Me.txtJM.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtJM.Location = New System.Drawing.Point(82, 142)
        Me.txtJM.Name = "txtJM"
        Me.txtJM.Size = New System.Drawing.Size(50, 20)
        Me.txtJM.TabIndex = 45
        Me.txtJM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(247, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Kategorija"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(204, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Količina"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(316, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Prodajna cena"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(135, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "PDV"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(81, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "jm"
        '
        'frmRobaEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(464, 278)
        Me.Controls.Add(Me.txtMarza)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtBod)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtnabavnaE)
        Me.Controls.Add(Me.chkBod)
        Me.Controls.Add(Me.txtEuro)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtRabat)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtNabavna)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMinKolicina)
        Me.Controls.Add(Me.cmbPDV)
        Me.Controls.Add(Me.cmbKategorija)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtKolicina)
        Me.Controls.Add(Me.txtCena)
        Me.Controls.Add(Me.txtJM)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRobaEdit"
        Me.Text = "Roba - Edit"
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
    Friend WithEvents txtMarza As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtBod As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtnabavnaE As System.Windows.Forms.TextBox
    Friend WithEvents chkBod As System.Windows.Forms.CheckBox
    Friend WithEvents txtEuro As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtRabat As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNabavna As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMinKolicina As System.Windows.Forms.TextBox
    Friend WithEvents cmbPDV As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKategorija As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSifraOpis As System.Windows.Forms.TextBox
    Friend WithEvents txtNaziv As System.Windows.Forms.TextBox
    Friend WithEvents txtSifra As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtKolicina As System.Windows.Forms.TextBox
    Friend WithEvents txtCena As System.Windows.Forms.TextBox
    Friend WithEvents txtJM As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
