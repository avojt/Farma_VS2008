<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntTrebovanjeUnos
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tlbLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.tlbMagacin = New System.Windows.Forms.ToolStripComboBox
        Me.tlbSep = New System.Windows.Forms.ToolStripSeparator
        Me.tlbLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.tlbGrupaArtikla = New System.Windows.Forms.ToolStripComboBox
        Me.tlbSep1 = New System.Windows.Forms.ToolStripSeparator
        Me.tlbSnimi = New System.Windows.Forms.ToolStripButton
        Me.tlbSep2 = New System.Windows.Forms.ToolStripSeparator
        Me.tlbEnd = New System.Windows.Forms.ToolStripButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkCene = New System.Windows.Forms.CheckBox
        Me.btnNoviPartner = New System.Windows.Forms.Button
        Me.btnNoviArtkl = New System.Windows.Forms.Button
        Me.btnOsvezi = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.dateDatum = New System.Windows.Forms.DateTimePicker
        Me.cmbPartneri = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSifra = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtNapomena = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtIznosCena = New System.Windows.Forms.TextBox
        Me.txtIznosRabat = New System.Windows.Forms.TextBox
        Me.txtOsnovica = New System.Windows.Forms.TextBox
        Me.txtIznosPdv = New System.Windows.Forms.TextBox
        Me.txtIznosZanaplatu = New System.Windows.Forms.TextBox
        Me.dgStavke = New System.Windows.Forms.DataGridView
        Me.RmartikliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Farma.DataSet1
        Me.ApppdvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rm_artikliTableAdapter = New Farma.DataSet1TableAdapters.rm_artikliTableAdapter
        Me.App_pdvTableAdapter = New Farma.DataSet1TableAdapters.app_pdvTableAdapter
        Me.colRb = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colArtikl = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.colKol = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCena = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPdv = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.colUkupno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgStavke, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RmartikliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApppdvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNapomena, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtIznosCena, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtIznosRabat, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtOsnovica, 2, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txtIznosPdv, 2, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.txtIznosZanaplatu, 2, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.dgStavke, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 12
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(790, 480)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'ToolStrip1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ToolStrip1, 3)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbLabel1, Me.tlbMagacin, Me.tlbSep, Me.tlbLabel2, Me.tlbGrupaArtikla, Me.tlbSep1, Me.tlbSnimi, Me.tlbSep2, Me.tlbEnd})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(790, 22)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tlbLabel1
        '
        Me.tlbLabel1.AutoSize = False
        Me.tlbLabel1.Name = "tlbLabel1"
        Me.tlbLabel1.Size = New System.Drawing.Size(105, 19)
        Me.tlbLabel1.Text = "TREBOVANJE ZA"
        '
        'tlbMagacin
        '
        Me.tlbMagacin.BackColor = System.Drawing.Color.GhostWhite
        Me.tlbMagacin.ForeColor = System.Drawing.Color.MidnightBlue
        Me.tlbMagacin.Name = "tlbMagacin"
        Me.tlbMagacin.Size = New System.Drawing.Size(250, 22)
        '
        'tlbSep
        '
        Me.tlbSep.Margin = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.tlbSep.Name = "tlbSep"
        Me.tlbSep.Size = New System.Drawing.Size(6, 22)
        '
        'tlbLabel2
        '
        Me.tlbLabel2.AutoSize = False
        Me.tlbLabel2.Name = "tlbLabel2"
        Me.tlbLabel2.Size = New System.Drawing.Size(80, 19)
        Me.tlbLabel2.Text = "Grupa Artikla"
        '
        'tlbGrupaArtikla
        '
        Me.tlbGrupaArtikla.AutoSize = False
        Me.tlbGrupaArtikla.Name = "tlbGrupaArtikla"
        Me.tlbGrupaArtikla.Size = New System.Drawing.Size(150, 21)
        '
        'tlbSep1
        '
        Me.tlbSep1.AutoSize = False
        Me.tlbSep1.Margin = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.tlbSep1.Name = "tlbSep1"
        Me.tlbSep1.Size = New System.Drawing.Size(6, 22)
        '
        'tlbSnimi
        '
        Me.tlbSnimi.Image = Global.Farma.My.Resources.Resources.LaST__Cobalt__Floppy
        Me.tlbSnimi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbSnimi.Name = "tlbSnimi"
        Me.tlbSnimi.Size = New System.Drawing.Size(51, 19)
        Me.tlbSnimi.Text = "Snimi"
        '
        'tlbSep2
        '
        Me.tlbSep2.Name = "tlbSep2"
        Me.tlbSep2.Size = New System.Drawing.Size(6, 22)
        '
        'tlbEnd
        '
        Me.tlbEnd.Image = Global.Farma.My.Resources.Resources.logoff
        Me.tlbEnd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbEnd.Name = "tlbEnd"
        Me.tlbEnd.Size = New System.Drawing.Size(46, 19)
        Me.tlbEnd.Text = "Kraj"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel1, 3)
        Me.Panel1.Controls.Add(Me.chkCene)
        Me.Panel1.Controls.Add(Me.btnNoviPartner)
        Me.Panel1.Controls.Add(Me.btnNoviArtkl)
        Me.Panel1.Controls.Add(Me.btnOsvezi)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.dateDatum)
        Me.Panel1.Controls.Add(Me.cmbPartneri)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtSifra)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 66)
        Me.Panel1.TabIndex = 102
        '
        'chkCene
        '
        Me.chkCene.AutoSize = True
        Me.chkCene.Location = New System.Drawing.Point(430, 27)
        Me.chkCene.Name = "chkCene"
        Me.chkCene.Size = New System.Drawing.Size(106, 17)
        Me.chkCene.TabIndex = 119
        Me.chkCene.Text = "Unos sa cenama"
        Me.chkCene.UseVisualStyleBackColor = True
        '
        'btnNoviPartner
        '
        Me.btnNoviPartner.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnNoviPartner.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnNoviPartner.Location = New System.Drawing.Point(544, 21)
        Me.btnNoviPartner.Name = "btnNoviPartner"
        Me.btnNoviPartner.Size = New System.Drawing.Size(75, 23)
        Me.btnNoviPartner.TabIndex = 118
        Me.btnNoviPartner.Text = "Novi Prtner"
        Me.btnNoviPartner.UseVisualStyleBackColor = True
        '
        'btnNoviArtkl
        '
        Me.btnNoviArtkl.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnNoviArtkl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnNoviArtkl.Location = New System.Drawing.Point(625, 21)
        Me.btnNoviArtkl.Name = "btnNoviArtkl"
        Me.btnNoviArtkl.Size = New System.Drawing.Size(75, 23)
        Me.btnNoviArtkl.TabIndex = 117
        Me.btnNoviArtkl.Text = "Novi Artkl"
        Me.btnNoviArtkl.UseVisualStyleBackColor = True
        '
        'btnOsvezi
        '
        Me.btnOsvezi.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnOsvezi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnOsvezi.Location = New System.Drawing.Point(706, 21)
        Me.btnOsvezi.Name = "btnOsvezi"
        Me.btnOsvezi.Size = New System.Drawing.Size(64, 23)
        Me.btnOsvezi.TabIndex = 116
        Me.btnOsvezi.Text = "Osveži"
        Me.btnOsvezi.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(310, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Datum"
        '
        'dateDatum
        '
        Me.dateDatum.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.dateDatum.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.dateDatum.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateDatum.Location = New System.Drawing.Point(313, 24)
        Me.dateDatum.Name = "dateDatum"
        Me.dateDatum.Size = New System.Drawing.Size(85, 20)
        Me.dateDatum.TabIndex = 17
        '
        'cmbPartneri
        '
        Me.cmbPartneri.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbPartneri.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbPartneri.FormattingEnabled = True
        Me.cmbPartneri.Location = New System.Drawing.Point(107, 24)
        Me.cmbPartneri.Name = "cmbPartneri"
        Me.cmbPartneri.Size = New System.Drawing.Size(187, 21)
        Me.cmbPartneri.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(104, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Poslovni Partner"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(77, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "/07"
        '
        'txtSifra
        '
        Me.txtSifra.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSifra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSifra.Location = New System.Drawing.Point(11, 25)
        Me.txtSifra.Name = "txtSifra"
        Me.txtSifra.Size = New System.Drawing.Size(66, 20)
        Me.txtSifra.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(8, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Broj"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 287)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 170
        Me.Label12.Text = "Napomena"
        Me.Label12.Visible = False
        '
        'txtNapomena
        '
        Me.txtNapomena.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNapomena.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNapomena.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNapomena.Location = New System.Drawing.Point(3, 303)
        Me.txtNapomena.Multiline = True
        Me.txtNapomena.Name = "txtNapomena"
        Me.TableLayoutPanel1.SetRowSpan(Me.txtNapomena, 4)
        Me.txtNapomena.Size = New System.Drawing.Size(444, 98)
        Me.txtNapomena.TabIndex = 169
        Me.txtNapomena.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(609, 384)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 162
        Me.Label1.Text = "Za naplatu"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(638, 358)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 161
        Me.Label9.Text = "PDV"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(590, 332)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 167
        Me.Label11.Text = "PDV Osnovica"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(631, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 160
        Me.Label8.Text = "Rabat"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(622, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 159
        Me.Label2.Text = "Ukupno"
        '
        'txtIznosCena
        '
        Me.txtIznosCena.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIznosCena.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtIznosCena.Location = New System.Drawing.Point(673, 277)
        Me.txtIznosCena.Name = "txtIznosCena"
        Me.txtIznosCena.Size = New System.Drawing.Size(100, 20)
        Me.txtIznosCena.TabIndex = 163
        Me.txtIznosCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIznosRabat
        '
        Me.txtIznosRabat.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIznosRabat.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtIznosRabat.Location = New System.Drawing.Point(673, 303)
        Me.txtIznosRabat.Name = "txtIznosRabat"
        Me.txtIznosRabat.Size = New System.Drawing.Size(100, 20)
        Me.txtIznosRabat.TabIndex = 164
        Me.txtIznosRabat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOsnovica
        '
        Me.txtOsnovica.BackColor = System.Drawing.Color.GhostWhite
        Me.txtOsnovica.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtOsnovica.Location = New System.Drawing.Point(673, 329)
        Me.txtOsnovica.Name = "txtOsnovica"
        Me.txtOsnovica.Size = New System.Drawing.Size(100, 20)
        Me.txtOsnovica.TabIndex = 168
        Me.txtOsnovica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIznosPdv
        '
        Me.txtIznosPdv.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIznosPdv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtIznosPdv.Location = New System.Drawing.Point(673, 355)
        Me.txtIznosPdv.Name = "txtIznosPdv"
        Me.txtIznosPdv.Size = New System.Drawing.Size(100, 20)
        Me.txtIznosPdv.TabIndex = 165
        Me.txtIznosPdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIznosZanaplatu
        '
        Me.txtIznosZanaplatu.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIznosZanaplatu.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtIznosZanaplatu.Location = New System.Drawing.Point(673, 381)
        Me.txtIznosZanaplatu.Name = "txtIznosZanaplatu"
        Me.txtIznosZanaplatu.Size = New System.Drawing.Size(100, 20)
        Me.txtIznosZanaplatu.TabIndex = 166
        Me.txtIznosZanaplatu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgStavke
        '
        Me.dgStavke.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.dgStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStavke.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colRb, Me.colArtikl, Me.colKol, Me.colCena, Me.colPdv, Me.colUkupno})
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgStavke, 3)
        Me.dgStavke.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgStavke.Location = New System.Drawing.Point(3, 117)
        Me.dgStavke.Name = "dgStavke"
        Me.dgStavke.Size = New System.Drawing.Size(784, 144)
        Me.dgStavke.TabIndex = 171
        '
        'RmartikliBindingSource
        '
        Me.RmartikliBindingSource.DataMember = "rm_artikli"
        Me.RmartikliBindingSource.DataSource = Me.DataSet1
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
        'Rm_artikliTableAdapter
        '
        Me.Rm_artikliTableAdapter.ClearBeforeFill = True
        '
        'App_pdvTableAdapter
        '
        Me.App_pdvTableAdapter.ClearBeforeFill = True
        '
        'colRb
        '
        Me.colRb.HeaderText = "Rb"
        Me.colRb.Name = "colRb"
        Me.colRb.Width = 60
        '
        'colArtikl
        '
        Me.colArtikl.HeaderText = "Artikl"
        Me.colArtikl.Name = "colArtikl"
        Me.colArtikl.Width = 300
        '
        'colKol
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colKol.DefaultCellStyle = DataGridViewCellStyle1
        Me.colKol.HeaderText = "Kol"
        Me.colKol.Name = "colKol"
        Me.colKol.Width = 80
        '
        'colCena
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = "0"
        Me.colCena.DefaultCellStyle = DataGridViewCellStyle2
        Me.colCena.HeaderText = "Cena"
        Me.colCena.Name = "colCena"
        '
        'colPdv
        '
        Me.colPdv.HeaderText = "PDV"
        Me.colPdv.Name = "colPdv"
        Me.colPdv.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPdv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colPdv.Width = 80
        '
        'colUkupno
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N3"
        DataGridViewCellStyle3.NullValue = "0"
        Me.colUkupno.DefaultCellStyle = DataGridViewCellStyle3
        Me.colUkupno.HeaderText = "Ukupno"
        Me.colUkupno.Name = "colUkupno"
        Me.colUkupno.Width = 110
        '
        'cntTrebovanjeUnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntTrebovanjeUnos"
        Me.Size = New System.Drawing.Size(790, 480)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgStavke, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RmartikliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApppdvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbSnimi As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbEnd As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbSep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtSifra As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbPartneri As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dateDatum As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnNoviPartner As System.Windows.Forms.Button
    Friend WithEvents btnNoviArtkl As System.Windows.Forms.Button
    Friend WithEvents btnOsvezi As System.Windows.Forms.Button
    Friend WithEvents txtIznosZanaplatu As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOsnovica As System.Windows.Forms.TextBox
    Friend WithEvents txtIznosCena As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtIznosRabat As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIznosPdv As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNapomena As System.Windows.Forms.TextBox
    Friend WithEvents tlbLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tlbMagacin As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents dgStavke As System.Windows.Forms.DataGridView
    Friend WithEvents chkCene As System.Windows.Forms.CheckBox
    Friend WithEvents RmartikliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As Farma.DataSet1
    Friend WithEvents ApppdvBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rm_artikliTableAdapter As Farma.DataSet1TableAdapters.rm_artikliTableAdapter
    Friend WithEvents App_pdvTableAdapter As Farma.DataSet1TableAdapters.app_pdvTableAdapter
    Friend WithEvents tlbGrupaArtikla As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tlbLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tlbSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents colRb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colArtikl As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colKol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCena As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPdv As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colUkupno As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
