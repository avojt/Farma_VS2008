<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUlazniRacuniEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUlazniRacuniEdit))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tlbSnimi = New System.Windows.Forms.ToolStripButton
        Me.tlbStanje = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tlbKalkulacija = New System.Windows.Forms.ToolStripButton
        Me.tlbUbaci = New System.Windows.Forms.ToolStripButton
        Me.tlbProknjizi = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tlbEnd = New System.Windows.Forms.ToolStripButton
        Me.cmbPDV = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtZTroskovi = New System.Windows.Forms.TextBox
        Me.txtNeoporezivo = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
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
        Me.dgStavke = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnNoviPartner = New System.Windows.Forms.Button
        Me.btnNoviArtkl = New System.Windows.Forms.Button
        Me.btnOsvezi = New System.Windows.Forms.Button
        Me.cmbOdlozeno = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtBrFakture = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dateValuta = New System.Windows.Forms.DateTimePicker
        Me.dateFakturisanja = New System.Windows.Forms.DateTimePicker
        Me.cmbPartneri = New System.Windows.Forms.ComboBox
        Me.txtSifra = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DataSet1 = New Farma.DataSet1
        Me.RmartikliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rm_artikliTableAdapter = New Farma.DataSet1TableAdapters.rm_artikliTableAdapter
        Me.ApppdvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.App_pdvTableAdapter = New Farma.DataSet1TableAdapters.app_pdvTableAdapter
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
        CType(Me.RmartikliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApppdvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbSnimi, Me.tlbStanje, Me.ToolStripSeparator2, Me.tlbKalkulacija, Me.tlbUbaci, Me.tlbProknjizi, Me.ToolStripSeparator1, Me.tlbEnd})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(910, 25)
        Me.ToolStrip1.TabIndex = 73
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tlbKalkulacija
        '
        Me.tlbKalkulacija.Image = Global.Farma.My.Resources.Resources.Files_text
        Me.tlbKalkulacija.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbKalkulacija.Name = "tlbKalkulacija"
        Me.tlbKalkulacija.Size = New System.Drawing.Size(76, 22)
        Me.tlbKalkulacija.Text = "Kalkulacija"
        '
        'tlbUbaci
        '
        Me.tlbUbaci.Image = Global.Farma.My.Resources.Resources.LaST__Cobalt__Text_File
        Me.tlbUbaci.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbUbaci.Name = "tlbUbaci"
        Me.tlbUbaci.Size = New System.Drawing.Size(83, 22)
        Me.tlbUbaci.Text = "Unesi račun"
        '
        'tlbProknjizi
        '
        Me.tlbProknjizi.Image = Global.Farma.My.Resources.Resources.Files_text
        Me.tlbProknjizi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbProknjizi.Name = "tlbProknjizi"
        Me.tlbProknjizi.Size = New System.Drawing.Size(66, 22)
        Me.tlbProknjizi.Text = "Proknjiži"
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
        'cmbPDV
        '
        Me.cmbPDV.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbPDV.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbPDV.FormattingEnabled = True
        Me.cmbPDV.Location = New System.Drawing.Point(443, 370)
        Me.cmbPDV.Name = "cmbPDV"
        Me.cmbPDV.Size = New System.Drawing.Size(59, 21)
        Me.cmbPDV.TabIndex = 110
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label15.Location = New System.Drawing.Point(440, 354)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(25, 13)
        Me.Label15.TabIndex = 109
        Me.Label15.Text = "pdv"
        '
        'txtZTroskovi
        '
        Me.txtZTroskovi.BackColor = System.Drawing.Color.GhostWhite
        Me.txtZTroskovi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtZTroskovi.Location = New System.Drawing.Point(336, 370)
        Me.txtZTroskovi.Name = "txtZTroskovi"
        Me.txtZTroskovi.Size = New System.Drawing.Size(100, 20)
        Me.txtZTroskovi.TabIndex = 108
        Me.txtZTroskovi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNeoporezivo
        '
        Me.txtNeoporezivo.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNeoporezivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNeoporezivo.Location = New System.Drawing.Point(336, 422)
        Me.txtNeoporezivo.Name = "txtNeoporezivo"
        Me.txtNeoporezivo.Size = New System.Drawing.Size(100, 20)
        Me.txtNeoporezivo.TabIndex = 107
        Me.txtNeoporezivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label14.Location = New System.Drawing.Point(333, 406)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 13)
        Me.Label14.TabIndex = 106
        Me.Label14.Text = "Neoporezovani iznos"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label13.Location = New System.Drawing.Point(333, 354)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 13)
        Me.Label13.TabIndex = 105
        Me.Label13.Text = "Z.troškovi - ukupno"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label12.Location = New System.Drawing.Point(12, 324)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 104
        Me.Label12.Text = "Napomena"
        '
        'txtNapomena
        '
        Me.txtNapomena.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNapomena.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNapomena.Location = New System.Drawing.Point(12, 340)
        Me.txtNapomena.Multiline = True
        Me.txtNapomena.Name = "txtNapomena"
        Me.txtNapomena.Size = New System.Drawing.Size(295, 102)
        Me.txtNapomena.TabIndex = 103
        '
        'txtOsnovica
        '
        Me.txtOsnovica.BackColor = System.Drawing.Color.GhostWhite
        Me.txtOsnovica.Enabled = False
        Me.txtOsnovica.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtOsnovica.Location = New System.Drawing.Point(798, 366)
        Me.txtOsnovica.Name = "txtOsnovica"
        Me.txtOsnovica.Size = New System.Drawing.Size(100, 20)
        Me.txtOsnovica.TabIndex = 102
        Me.txtOsnovica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label11.Location = New System.Drawing.Point(715, 373)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "PDV Osnovica"
        '
        'txtIznosZanaplatu
        '
        Me.txtIznosZanaplatu.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIznosZanaplatu.Enabled = False
        Me.txtIznosZanaplatu.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtIznosZanaplatu.Location = New System.Drawing.Point(798, 418)
        Me.txtIznosZanaplatu.Name = "txtIznosZanaplatu"
        Me.txtIznosZanaplatu.Size = New System.Drawing.Size(100, 20)
        Me.txtIznosZanaplatu.TabIndex = 100
        Me.txtIznosZanaplatu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIznosPdv
        '
        Me.txtIznosPdv.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIznosPdv.Enabled = False
        Me.txtIznosPdv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtIznosPdv.Location = New System.Drawing.Point(798, 392)
        Me.txtIznosPdv.Name = "txtIznosPdv"
        Me.txtIznosPdv.Size = New System.Drawing.Size(100, 20)
        Me.txtIznosPdv.TabIndex = 99
        Me.txtIznosPdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIznosRabat
        '
        Me.txtIznosRabat.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIznosRabat.Enabled = False
        Me.txtIznosRabat.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtIznosRabat.Location = New System.Drawing.Point(798, 340)
        Me.txtIznosRabat.Name = "txtIznosRabat"
        Me.txtIznosRabat.Size = New System.Drawing.Size(100, 20)
        Me.txtIznosRabat.TabIndex = 98
        Me.txtIznosRabat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIznosCena
        '
        Me.txtIznosCena.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIznosCena.Enabled = False
        Me.txtIznosCena.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtIznosCena.Location = New System.Drawing.Point(798, 313)
        Me.txtIznosCena.Name = "txtIznosCena"
        Me.txtIznosCena.Size = New System.Drawing.Size(100, 20)
        Me.txtIznosCena.TabIndex = 97
        Me.txtIznosCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(734, 425)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 96
        Me.Label10.Text = "Za naplatu"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(763, 399)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "PDV"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(756, 347)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Rabat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(747, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Ukupno"
        '
        'dgStavke
        '
        Me.dgStavke.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.dgStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStavke.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cRb, Me.cSifra, Me.cOpis, Me.cKol, Me.cCena, Me.cRabat, Me.cPdv, Me.cZanaplatu})
        Me.dgStavke.Location = New System.Drawing.Point(12, 110)
        Me.dgStavke.Name = "dgStavke"
        Me.dgStavke.Size = New System.Drawing.Size(886, 197)
        Me.dgStavke.TabIndex = 112
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel1.Controls.Add(Me.btnNoviPartner)
        Me.Panel1.Controls.Add(Me.btnNoviArtkl)
        Me.Panel1.Controls.Add(Me.btnOsvezi)
        Me.Panel1.Controls.Add(Me.cmbOdlozeno)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtBrFakture)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dateValuta)
        Me.Panel1.Controls.Add(Me.dateFakturisanja)
        Me.Panel1.Controls.Add(Me.cmbPartneri)
        Me.Panel1.Controls.Add(Me.txtSifra)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(886, 64)
        Me.Panel1.TabIndex = 111
        '
        'btnNoviPartner
        '
        Me.btnNoviPartner.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnNoviPartner.Location = New System.Drawing.Point(647, 22)
        Me.btnNoviPartner.Name = "btnNoviPartner"
        Me.btnNoviPartner.Size = New System.Drawing.Size(75, 23)
        Me.btnNoviPartner.TabIndex = 112
        Me.btnNoviPartner.Text = "Novi Prtner"
        Me.btnNoviPartner.UseVisualStyleBackColor = True
        '
        'btnNoviArtkl
        '
        Me.btnNoviArtkl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnNoviArtkl.Location = New System.Drawing.Point(728, 22)
        Me.btnNoviArtkl.Name = "btnNoviArtkl"
        Me.btnNoviArtkl.Size = New System.Drawing.Size(75, 23)
        Me.btnNoviArtkl.TabIndex = 111
        Me.btnNoviArtkl.Text = "Novi Artkl"
        Me.btnNoviArtkl.UseVisualStyleBackColor = True
        '
        'btnOsvezi
        '
        Me.btnOsvezi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnOsvezi.Location = New System.Drawing.Point(809, 22)
        Me.btnOsvezi.Name = "btnOsvezi"
        Me.btnOsvezi.Size = New System.Drawing.Size(64, 23)
        Me.btnOsvezi.TabIndex = 110
        Me.btnOsvezi.Text = "Osveži"
        Me.btnOsvezi.UseVisualStyleBackColor = True
        '
        'cmbOdlozeno
        '
        Me.cmbOdlozeno.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbOdlozeno.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbOdlozeno.FormattingEnabled = True
        Me.cmbOdlozeno.Location = New System.Drawing.Point(476, 24)
        Me.cmbOdlozeno.Name = "cmbOdlozeno"
        Me.cmbOdlozeno.Size = New System.Drawing.Size(63, 21)
        Me.cmbOdlozeno.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label16.Location = New System.Drawing.Point(286, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Broj fakture"
        '
        'txtBrFakture
        '
        Me.txtBrFakture.BackColor = System.Drawing.Color.GhostWhite
        Me.txtBrFakture.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBrFakture.Location = New System.Drawing.Point(286, 26)
        Me.txtBrFakture.Name = "txtBrFakture"
        Me.txtBrFakture.Size = New System.Drawing.Size(88, 20)
        Me.txtBrFakture.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(542, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Datum - valuta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(473, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Odloženo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(380, 8)
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
        Me.dateValuta.Location = New System.Drawing.Point(545, 25)
        Me.dateValuta.Name = "dateValuta"
        Me.dateValuta.Size = New System.Drawing.Size(90, 20)
        Me.dateValuta.TabIndex = 15
        '
        'dateFakturisanja
        '
        Me.dateFakturisanja.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.dateFakturisanja.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.dateFakturisanja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFakturisanja.Location = New System.Drawing.Point(380, 25)
        Me.dateFakturisanja.Name = "dateFakturisanja"
        Me.dateFakturisanja.Size = New System.Drawing.Size(90, 20)
        Me.dateFakturisanja.TabIndex = 14
        '
        'cmbPartneri
        '
        Me.cmbPartneri.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbPartneri.FormattingEnabled = True
        Me.cmbPartneri.Location = New System.Drawing.Point(102, 25)
        Me.cmbPartneri.Name = "cmbPartneri"
        Me.cmbPartneri.Size = New System.Drawing.Size(178, 21)
        Me.cmbPartneri.TabIndex = 13
        '
        'txtSifra
        '
        Me.txtSifra.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSifra.Location = New System.Drawing.Point(11, 26)
        Me.txtSifra.Name = "txtSifra"
        Me.txtSifra.Size = New System.Drawing.Size(55, 20)
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
        Me.Label2.Location = New System.Drawing.Point(99, 9)
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
        'RmartikliBindingSource
        '
        Me.RmartikliBindingSource.DataMember = "rm_artikli"
        Me.RmartikliBindingSource.DataSource = Me.DataSet1
        '
        'Rm_artikliTableAdapter
        '
        Me.Rm_artikliTableAdapter.ClearBeforeFill = True
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
        'cRb
        '
        Me.cRb.HeaderText = "Rb"
        Me.cRb.Name = "cRb"
        Me.cRb.Width = 50
        '
        'cSifra
        '
        Me.cSifra.DataSource = Me.RmartikliBindingSource
        Me.cSifra.DisplayMember = "sifra"
        Me.cSifra.HeaderText = "Šifra"
        Me.cSifra.Name = "cSifra"
        Me.cSifra.ValueMember = "sifra"
        Me.cSifra.Width = 110
        '
        'cOpis
        '
        Me.cOpis.HeaderText = "Opis"
        Me.cOpis.Name = "cOpis"
        Me.cOpis.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cOpis.Width = 280
        '
        'cKol
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cKol.DefaultCellStyle = DataGridViewCellStyle1
        Me.cKol.HeaderText = "Kol"
        Me.cKol.Name = "cKol"
        Me.cKol.Width = 70
        '
        'cCena
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = "0"
        Me.cCena.DefaultCellStyle = DataGridViewCellStyle2
        Me.cCena.HeaderText = "Cena"
        Me.cCena.Name = "cCena"
        '
        'cRabat
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.cRabat.DefaultCellStyle = DataGridViewCellStyle3
        Me.cRabat.HeaderText = "Rabat"
        Me.cRabat.Name = "cRabat"
        Me.cRabat.Width = 50
        '
        'cPdv
        '
        Me.cPdv.DataSource = Me.ApppdvBindingSource
        Me.cPdv.DisplayMember = "sifra"
        Me.cPdv.HeaderText = "PDV"
        Me.cPdv.Name = "cPdv"
        Me.cPdv.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cPdv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cPdv.ValueMember = "sifra"
        Me.cPdv.Width = 65
        '
        'cZanaplatu
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N3"
        DataGridViewCellStyle4.NullValue = "0"
        Me.cZanaplatu.DefaultCellStyle = DataGridViewCellStyle4
        Me.cZanaplatu.HeaderText = "Ukupno"
        Me.cZanaplatu.Name = "cZanaplatu"
        Me.cZanaplatu.Width = 115
        '
        'frmUlazniRacuniEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(910, 453)
        Me.Controls.Add(Me.dgStavke)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmbPDV)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtZTroskovi)
        Me.Controls.Add(Me.txtNeoporezivo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
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
        Me.Controls.Add(Me.ToolStrip1)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUlazniRacuniEdit"
        Me.Text = "Ulazni Računi - Edit"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgStavke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RmartikliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApppdvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbSnimi As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbStanje As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbUbaci As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbEnd As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbPDV As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtZTroskovi As System.Windows.Forms.TextBox
    Friend WithEvents txtNeoporezivo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
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
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbKalkulacija As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbProknjizi As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgStavke As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNoviPartner As System.Windows.Forms.Button
    Friend WithEvents btnNoviArtkl As System.Windows.Forms.Button
    Friend WithEvents btnOsvezi As System.Windows.Forms.Button
    Friend WithEvents cmbOdlozeno As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtBrFakture As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dateValuta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateFakturisanja As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbPartneri As System.Windows.Forms.ComboBox
    Friend WithEvents txtSifra As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As Farma.DataSet1
    Friend WithEvents RmartikliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rm_artikliTableAdapter As Farma.DataSet1TableAdapters.rm_artikliTableAdapter
    Friend WithEvents ApppdvBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents App_pdvTableAdapter As Farma.DataSet1TableAdapters.app_pdvTableAdapter
    Friend WithEvents cRb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSifra As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cOpis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cKol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCena As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cRabat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPdv As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cZanaplatu As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
