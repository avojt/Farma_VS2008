<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPredracuniUnos
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tlbSnimi = New System.Windows.Forms.ToolStripButton
        Me.tlbStanje = New System.Windows.Forms.ToolStripButton
        Me.tlbURacun = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tlbEnd = New System.Windows.Forms.ToolStripButton
        Me.dgStavke = New System.Windows.Forms.DataGridView
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtNapomena = New System.Windows.Forms.TextBox
        Me.txtOsnovica = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtIznosZanaplatu = New System.Windows.Forms.TextBox
        Me.txtIznosPdv = New System.Windows.Forms.TextBox
        Me.txtIznosRabat = New System.Windows.Forms.TextBox
        Me.txtIznosCena = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbOdlozeno = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dateValuta = New System.Windows.Forms.DateTimePicker
        Me.dateFakturisanja = New System.Windows.Forms.DateTimePicker
        Me.cmbPartneri = New System.Windows.Forms.ComboBox
        Me.txtSifra = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DataSet1 = New Farma.DataSet1
        Me.ApppdvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.App_pdvTableAdapter = New Farma.DataSet1TableAdapters.app_pdvTableAdapter
        Me.RmartikliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rm_artikliTableAdapter = New Farma.DataSet1TableAdapters.rm_artikliTableAdapter
        Me.cRb = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cSifra = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.cOpis = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cKol = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cCena = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cRabat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cPdv = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.cZanaplatu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgStavke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApppdvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RmartikliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbSnimi, Me.tlbStanje, Me.tlbURacun, Me.ToolStripSeparator1, Me.tlbEnd})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(727, 25)
        Me.ToolStrip1.TabIndex = 71
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
        'tlbStanje
        '
        Me.tlbStanje.Image = Global.Farma.My.Resources.Resources.LaST__Cobalt__Find
        Me.tlbStanje.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbStanje.Name = "tlbStanje"
        Me.tlbStanje.Size = New System.Drawing.Size(94, 22)
        Me.tlbStanje.Text = "Proveri stanje"
        '
        'tlbURacun
        '
        Me.tlbURacun.Image = Global.Farma.My.Resources.Resources.Files_text
        Me.tlbURacun.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbURacun.Name = "tlbURacun"
        Me.tlbURacun.Size = New System.Drawing.Size(94, 22)
        Me.tlbURacun.Text = "Napravi račun"
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
        'dgStavke
        '
        Me.dgStavke.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.dgStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStavke.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cRb, Me.cSifra, Me.cOpis, Me.cKol, Me.cCena, Me.cRabat, Me.cPdv, Me.cZanaplatu})
        Me.dgStavke.Location = New System.Drawing.Point(12, 109)
        Me.dgStavke.Name = "dgStavke"
        Me.dgStavke.Size = New System.Drawing.Size(703, 197)
        Me.dgStavke.TabIndex = 85
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label12.Location = New System.Drawing.Point(12, 331)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "Napomena"
        '
        'txtNapomena
        '
        Me.txtNapomena.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNapomena.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNapomena.Location = New System.Drawing.Point(12, 347)
        Me.txtNapomena.Multiline = True
        Me.txtNapomena.Name = "txtNapomena"
        Me.txtNapomena.Size = New System.Drawing.Size(475, 94)
        Me.txtNapomena.TabIndex = 83
        '
        'txtOsnovica
        '
        Me.txtOsnovica.BackColor = System.Drawing.Color.GhostWhite
        Me.txtOsnovica.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtOsnovica.Location = New System.Drawing.Point(615, 369)
        Me.txtOsnovica.Name = "txtOsnovica"
        Me.txtOsnovica.Size = New System.Drawing.Size(100, 20)
        Me.txtOsnovica.TabIndex = 82
        Me.txtOsnovica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label11.Location = New System.Drawing.Point(532, 376)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "PDV Osnovica"
        '
        'txtIznosZanaplatu
        '
        Me.txtIznosZanaplatu.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIznosZanaplatu.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtIznosZanaplatu.Location = New System.Drawing.Point(615, 421)
        Me.txtIznosZanaplatu.Name = "txtIznosZanaplatu"
        Me.txtIznosZanaplatu.Size = New System.Drawing.Size(100, 20)
        Me.txtIznosZanaplatu.TabIndex = 80
        Me.txtIznosZanaplatu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIznosPdv
        '
        Me.txtIznosPdv.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIznosPdv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtIznosPdv.Location = New System.Drawing.Point(615, 395)
        Me.txtIznosPdv.Name = "txtIznosPdv"
        Me.txtIznosPdv.Size = New System.Drawing.Size(100, 20)
        Me.txtIznosPdv.TabIndex = 79
        Me.txtIznosPdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIznosRabat
        '
        Me.txtIznosRabat.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIznosRabat.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtIznosRabat.Location = New System.Drawing.Point(615, 343)
        Me.txtIznosRabat.Name = "txtIznosRabat"
        Me.txtIznosRabat.Size = New System.Drawing.Size(100, 20)
        Me.txtIznosRabat.TabIndex = 78
        Me.txtIznosRabat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIznosCena
        '
        Me.txtIznosCena.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIznosCena.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtIznosCena.Location = New System.Drawing.Point(615, 316)
        Me.txtIznosCena.Name = "txtIznosCena"
        Me.txtIznosCena.Size = New System.Drawing.Size(100, 20)
        Me.txtIznosCena.TabIndex = 77
        Me.txtIznosCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(551, 428)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "Za naplatu"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(580, 402)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "PDV"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(573, 350)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Rabat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(564, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Ukupno"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel1.Controls.Add(Me.cmbOdlozeno)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dateValuta)
        Me.Panel1.Controls.Add(Me.dateFakturisanja)
        Me.Panel1.Controls.Add(Me.cmbPartneri)
        Me.Panel1.Controls.Add(Me.txtSifra)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(703, 64)
        Me.Panel1.TabIndex = 72
        '
        'cmbOdlozeno
        '
        Me.cmbOdlozeno.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbOdlozeno.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbOdlozeno.FormattingEnabled = True
        Me.cmbOdlozeno.Location = New System.Drawing.Point(532, 24)
        Me.cmbOdlozeno.Name = "cmbOdlozeno"
        Me.cmbOdlozeno.Size = New System.Drawing.Size(63, 21)
        Me.cmbOdlozeno.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(529, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Odloženo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(598, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Datum prometa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(436, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Dat. fakturisanja"
        '
        'dateValuta
        '
        Me.dateValuta.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.dateValuta.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.dateValuta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateValuta.Location = New System.Drawing.Point(601, 25)
        Me.dateValuta.Name = "dateValuta"
        Me.dateValuta.Size = New System.Drawing.Size(90, 20)
        Me.dateValuta.TabIndex = 15
        '
        'dateFakturisanja
        '
        Me.dateFakturisanja.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.dateFakturisanja.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.dateFakturisanja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFakturisanja.Location = New System.Drawing.Point(436, 25)
        Me.dateFakturisanja.Name = "dateFakturisanja"
        Me.dateFakturisanja.Size = New System.Drawing.Size(90, 20)
        Me.dateFakturisanja.TabIndex = 14
        '
        'cmbPartneri
        '
        Me.cmbPartneri.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbPartneri.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbPartneri.FormattingEnabled = True
        Me.cmbPartneri.Location = New System.Drawing.Point(120, 24)
        Me.cmbPartneri.Name = "cmbPartneri"
        Me.cmbPartneri.Size = New System.Drawing.Size(295, 21)
        Me.cmbPartneri.TabIndex = 13
        '
        'txtSifra
        '
        Me.txtSifra.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSifra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSifra.Location = New System.Drawing.Point(11, 25)
        Me.txtSifra.Name = "txtSifra"
        Me.txtSifra.Size = New System.Drawing.Size(62, 20)
        Me.txtSifra.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Broj"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(117, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Poslovni Partner"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(72, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "/07"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ApppdvBindingSource
        '
        Me.ApppdvBindingSource.DataMember = "app_pdv"
        Me.ApppdvBindingSource.DataSource = Me.DataSet1
        '
        'App_pdvTableAdapter
        '
        Me.App_pdvTableAdapter.ClearBeforeFill = True
        '
        'RmartikliBindingSource
        '
        Me.RmartikliBindingSource.DataMember = "rm_artikli"
        Me.RmartikliBindingSource.DataSource = Me.DataSet1
        '
        'Rm_artikliTableAdapter
        '
        Me.Rm_artikliTableAdapter.ClearBeforeFill = True
        '
        'cRb
        '
        Me.cRb.HeaderText = "Rb"
        Me.cRb.Name = "cRb"
        Me.cRb.Width = 40
        '
        'cSifra
        '
        Me.cSifra.DataSource = Me.RmartikliBindingSource
        Me.cSifra.DisplayMember = "sifra"
        Me.cSifra.HeaderText = "Šifra"
        Me.cSifra.Name = "cSifra"
        Me.cSifra.ValueMember = "sifra"
        '
        'cOpis
        '
        Me.cOpis.HeaderText = "Opis"
        Me.cOpis.Name = "cOpis"
        Me.cOpis.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cOpis.Width = 250
        '
        'cKol
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cKol.DefaultCellStyle = DataGridViewCellStyle1
        Me.cKol.HeaderText = "Kol"
        Me.cKol.Name = "cKol"
        Me.cKol.Width = 50
        '
        'cCena
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cCena.DefaultCellStyle = DataGridViewCellStyle2
        Me.cCena.HeaderText = "Cena"
        Me.cCena.Name = "cCena"
        '
        'cRabat
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cRabat.DefaultCellStyle = DataGridViewCellStyle3
        Me.cRabat.HeaderText = "Rabat"
        Me.cRabat.Name = "cRabat"
        Me.cRabat.Width = 50
        '
        'cPdv
        '
        Me.cPdv.DataSource = Me.ApppdvBindingSource
        Me.cPdv.DisplayMember = "stopa"
        Me.cPdv.HeaderText = "PDV"
        Me.cPdv.Name = "cPdv"
        Me.cPdv.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cPdv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cPdv.ValueMember = "stopa"
        Me.cPdv.Width = 65
        '
        'cZanaplatu
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cZanaplatu.DefaultCellStyle = DataGridViewCellStyle4
        Me.cZanaplatu.HeaderText = "Ukupno"
        Me.cZanaplatu.Name = "cZanaplatu"
        '
        'frmPredracuniUnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(727, 453)
        Me.Controls.Add(Me.dgStavke)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNapomena)
        Me.Controls.Add(Me.txtOsnovica)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtIznosZanaplatu)
        Me.Controls.Add(Me.txtIznosPdv)
        Me.Controls.Add(Me.txtIznosRabat)
        Me.Controls.Add(Me.txtIznosCena)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPredracuniUnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Predračuni - Unos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgStavke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApppdvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RmartikliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbSnimi As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbStanje As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbURacun As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbEnd As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgStavke As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNapomena As System.Windows.Forms.TextBox
    Friend WithEvents txtOsnovica As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtIznosZanaplatu As System.Windows.Forms.TextBox
    Friend WithEvents txtIznosPdv As System.Windows.Forms.TextBox
    Friend WithEvents txtIznosRabat As System.Windows.Forms.TextBox
    Friend WithEvents txtIznosCena As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbOdlozeno As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dateValuta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateFakturisanja As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbPartneri As System.Windows.Forms.ComboBox
    Friend WithEvents txtSifra As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As Farma.DataSet1
    Friend WithEvents ApppdvBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents App_pdvTableAdapter As Farma.DataSet1TableAdapters.app_pdvTableAdapter
    Friend WithEvents RmartikliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rm_artikliTableAdapter As Farma.DataSet1TableAdapters.rm_artikliTableAdapter
    Friend WithEvents cRb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSifra As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cOpis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cKol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCena As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cRabat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPdv As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cZanaplatu As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
