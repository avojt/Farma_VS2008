<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPutniNalogUnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPutniNalogUnos))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tlbSnimi = New System.Windows.Forms.ToolStripButton
        Me.tlbIzdaj = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tlbEnd = New System.Windows.Forms.ToolStripButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.labOrganizacija = New System.Windows.Forms.Label
        Me.txtBroj = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtRadnik = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.dateZadrzavanje = New System.Windows.Forms.DateTimePicker
        Me.dateDana = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtRadnoMesto = New System.Windows.Forms.TextBox
        Me.txtMesto = New System.Windows.Forms.TextBox
        Me.txtZadatak = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtPrevoz = New System.Windows.Forms.TextBox
        Me.txtNaTeret = New System.Windows.Forms.TextBox
        Me.txtDnevnica = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtAkontacija = New System.Windows.Forms.TextBox
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbSnimi, Me.tlbIzdaj, Me.ToolStripSeparator1, Me.tlbEnd})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(437, 25)
        Me.ToolStrip1.TabIndex = 72
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
        'tlbIzdaj
        '
        Me.tlbIzdaj.Image = Global.Farma.My.Resources.Resources.LaST__Cobalt__Text_File
        Me.tlbIzdaj.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbIzdaj.Name = "tlbIzdaj"
        Me.tlbIzdaj.Size = New System.Drawing.Size(81, 22)
        Me.tlbIzdaj.Text = "Izdaj račun"
        Me.tlbIzdaj.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        Me.Panel1.Controls.Add(Me.labOrganizacija)
        Me.Panel1.Controls.Add(Me.txtBroj)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(16, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(409, 64)
        Me.Panel1.TabIndex = 73
        '
        'labOrganizacija
        '
        Me.labOrganizacija.AutoSize = True
        Me.labOrganizacija.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labOrganizacija.ForeColor = System.Drawing.Color.MidnightBlue
        Me.labOrganizacija.Location = New System.Drawing.Point(81, 9)
        Me.labOrganizacija.Name = "labOrganizacija"
        Me.labOrganizacija.Size = New System.Drawing.Size(11, 13)
        Me.labOrganizacija.TabIndex = 16
        Me.labOrganizacija.Text = "."
        '
        'txtBroj
        '
        Me.txtBroj.BackColor = System.Drawing.Color.GhostWhite
        Me.txtBroj.Location = New System.Drawing.Point(43, 32)
        Me.txtBroj.Name = "txtBroj"
        Me.txtBroj.Size = New System.Drawing.Size(62, 20)
        Me.txtBroj.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Broj"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Organizacija"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(111, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "/07"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(209, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "NALOG ZA SLUŽBENO PUTOVANJE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label13.Location = New System.Drawing.Point(16, 228)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "sa zadatkom"
        '
        'txtRadnik
        '
        Me.txtRadnik.BackColor = System.Drawing.Color.GhostWhite
        Me.txtRadnik.Location = New System.Drawing.Point(112, 142)
        Me.txtRadnik.Name = "txtRadnik"
        Me.txtRadnik.Size = New System.Drawing.Size(313, 20)
        Me.txtRadnik.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(276, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "u"
        '
        'dateZadrzavanje
        '
        Me.dateZadrzavanje.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.dateZadrzavanje.CalendarTitleForeColor = System.Drawing.Color.GhostWhite
        Me.dateZadrzavanje.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateZadrzavanje.Location = New System.Drawing.Point(242, 342)
        Me.dateZadrzavanje.Name = "dateZadrzavanje"
        Me.dateZadrzavanje.Size = New System.Drawing.Size(85, 20)
        Me.dateZadrzavanje.TabIndex = 8
        '
        'dateDana
        '
        Me.dateDana.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.dateDana.CalendarTitleForeColor = System.Drawing.Color.GhostWhite
        Me.dateDana.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateDana.Location = New System.Drawing.Point(185, 194)
        Me.dateDana.Name = "dateDana"
        Me.dateDana.Size = New System.Drawing.Size(85, 20)
        Me.dateDana.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Radnik - ca*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(213, 13)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Raspoređen - na* na poslove radnog mesta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 13)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "upućuje se na službFarma put dana:"
        '
        'txtRadnoMesto
        '
        Me.txtRadnoMesto.BackColor = System.Drawing.Color.GhostWhite
        Me.txtRadnoMesto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtRadnoMesto.Location = New System.Drawing.Point(235, 168)
        Me.txtRadnoMesto.Name = "txtRadnoMesto"
        Me.txtRadnoMesto.Size = New System.Drawing.Size(190, 20)
        Me.txtRadnoMesto.TabIndex = 2
        '
        'txtMesto
        '
        Me.txtMesto.BackColor = System.Drawing.Color.GhostWhite
        Me.txtMesto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMesto.Location = New System.Drawing.Point(296, 193)
        Me.txtMesto.Name = "txtMesto"
        Me.txtMesto.Size = New System.Drawing.Size(129, 20)
        Me.txtMesto.TabIndex = 4
        '
        'txtZadatak
        '
        Me.txtZadatak.BackColor = System.Drawing.Color.GhostWhite
        Me.txtZadatak.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtZadatak.Location = New System.Drawing.Point(19, 244)
        Me.txtZadatak.Multiline = True
        Me.txtZadatak.Name = "txtZadatak"
        Me.txtZadatak.Size = New System.Drawing.Size(406, 40)
        Me.txtZadatak.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 297)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(218, 13)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "Na službenom putu koristi prevozno sredstvo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 323)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(298, 13)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Dnevnica za ovo službeno putovanje pripada u iznosu od din."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 348)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(220, 13)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "Na službenom putu će se zadržati najdalje do"
        '
        'txtPrevoz
        '
        Me.txtPrevoz.BackColor = System.Drawing.Color.GhostWhite
        Me.txtPrevoz.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPrevoz.Location = New System.Drawing.Point(240, 290)
        Me.txtPrevoz.Name = "txtPrevoz"
        Me.txtPrevoz.Size = New System.Drawing.Size(185, 20)
        Me.txtPrevoz.TabIndex = 6
        '
        'txtNaTeret
        '
        Me.txtNaTeret.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNaTeret.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNaTeret.Location = New System.Drawing.Point(19, 429)
        Me.txtNaTeret.Multiline = True
        Me.txtNaTeret.Name = "txtNaTeret"
        Me.txtNaTeret.Size = New System.Drawing.Size(406, 40)
        Me.txtNaTeret.TabIndex = 9
        '
        'txtDnevnica
        '
        Me.txtDnevnica.BackColor = System.Drawing.Color.GhostWhite
        Me.txtDnevnica.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDnevnica.Location = New System.Drawing.Point(344, 316)
        Me.txtDnevnica.Name = "txtDnevnica"
        Me.txtDnevnica.Size = New System.Drawing.Size(81, 20)
        Me.txtDnevnica.TabIndex = 7
        Me.txtDnevnica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(333, 349)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 86
        Me.Label12.Text = "godine."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 365)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(409, 39)
        Me.Label14.TabIndex = 87
        Me.Label14.Text = "a u roku od 48 časova po povratku sa službenog puta i dolasku na posao, podneće" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
            "pismFarma izveštaj o obavljenom službenom poslu. Račun o učinjFarmam putnim troškovi" & _
            "ma" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "podneti u roku od tri dana."
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(40, 413)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(148, 13)
        Me.Label15.TabIndex = 88
        Me.Label15.Text = "Putni troškovi padaju na teret:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(40, 481)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(236, 13)
        Me.Label16.TabIndex = 89
        Me.Label16.Text = "Odobravam isplatu akontacije u iznosu od dinara"
        '
        'txtAkontacija
        '
        Me.txtAkontacija.BackColor = System.Drawing.Color.GhostWhite
        Me.txtAkontacija.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAkontacija.Location = New System.Drawing.Point(282, 475)
        Me.txtAkontacija.Name = "txtAkontacija"
        Me.txtAkontacija.Size = New System.Drawing.Size(143, 20)
        Me.txtAkontacija.TabIndex = 10
        Me.txtAkontacija.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmPutniNalogUnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(437, 514)
        Me.Controls.Add(Me.txtAkontacija)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtDnevnica)
        Me.Controls.Add(Me.txtNaTeret)
        Me.Controls.Add(Me.txtPrevoz)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtZadatak)
        Me.Controls.Add(Me.txtMesto)
        Me.Controls.Add(Me.txtRadnoMesto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtRadnik)
        Me.Controls.Add(Me.dateDana)
        Me.Controls.Add(Me.dateZadrzavanje)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPutniNalogUnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Putni Nalog - Unos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbSnimi As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbIzdaj As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbEnd As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtRadnik As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents labOrganizacija As System.Windows.Forms.Label
    Friend WithEvents dateZadrzavanje As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateDana As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBroj As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRadnoMesto As System.Windows.Forms.TextBox
    Friend WithEvents txtMesto As System.Windows.Forms.TextBox
    Friend WithEvents txtZadatak As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPrevoz As System.Windows.Forms.TextBox
    Friend WithEvents txtNaTeret As System.Windows.Forms.TextBox
    Friend WithEvents txtDnevnica As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtAkontacija As System.Windows.Forms.TextBox
End Class
