<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPotvrdaEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPotvrdaEdit))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tlbSnimi = New System.Windows.Forms.ToolStripButton
        Me.tlbStanje = New System.Windows.Forms.ToolStripButton
        Me.tlbIzdaj = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tlbEnd = New System.Windows.Forms.ToolStripButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtNapomene = New System.Windows.Forms.TextBox
        Me.layoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPosao2 = New System.Windows.Forms.TextBox
        Me.txtPosao3 = New System.Windows.Forms.TextBox
        Me.txtPosao4 = New System.Windows.Forms.TextBox
        Me.txtPosao5 = New System.Windows.Forms.TextBox
        Me.txtPosao6 = New System.Windows.Forms.TextBox
        Me.txtIzvrsilac1 = New System.Windows.Forms.TextBox
        Me.txtIzvrsilac2 = New System.Windows.Forms.TextBox
        Me.txtIzvrsilac3 = New System.Windows.Forms.TextBox
        Me.txtIzvrsilac4 = New System.Windows.Forms.TextBox
        Me.txtIzvrsilac5 = New System.Windows.Forms.TextBox
        Me.txtIzvrsilac6 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.layoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.chkPreventiva = New System.Windows.Forms.CheckBox
        Me.chkPreventivaEnd = New System.Windows.Forms.CheckBox
        Me.chkMontazaEnd = New System.Windows.Forms.CheckBox
        Me.chkIspitivanje = New System.Windows.Forms.CheckBox
        Me.chkPopravka = New System.Windows.Forms.CheckBox
        Me.chkIspitivanjeEnd = New System.Windows.Forms.CheckBox
        Me.chkPopravkaEnd = New System.Windows.Forms.CheckBox
        Me.chkServisiranje = New System.Windows.Forms.CheckBox
        Me.chkMontaza = New System.Windows.Forms.CheckBox
        Me.chkServisiranjeEnd = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dateMontaza = New System.Windows.Forms.DateTimePicker
        Me.dateServis = New System.Windows.Forms.DateTimePicker
        Me.datePopravka = New System.Windows.Forms.DateTimePicker
        Me.dateIspitivanje = New System.Windows.Forms.DateTimePicker
        Me.datePreventiva = New System.Windows.Forms.DateTimePicker
        Me.chkUgovor = New System.Windows.Forms.CheckBox
        Me.chkUgovorEnd = New System.Windows.Forms.CheckBox
        Me.dateUgovor = New System.Windows.Forms.DateTimePicker
        Me.layoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.dgStavke = New System.Windows.Forms.DataGridView
        Me.Label16 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.labNaloga = New System.Windows.Forms.Label
        Me.btnIzaberiNalog = New System.Windows.Forms.Button
        Me.txtSifra = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.DataSet1 = New Farma.DataSet1
        Me.RmartikliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rm_artikliTableAdapter = New Farma.DataSet1TableAdapters.rm_artikliTableAdapter
        Me.cRb = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cMaterijal = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.cKol = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1.SuspendLayout()
        Me.layoutPanel3.SuspendLayout()
        Me.layoutPanel2.SuspendLayout()
        Me.layoutPanel1.SuspendLayout()
        CType(Me.dgStavke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RmartikliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbSnimi, Me.tlbStanje, Me.tlbIzdaj, Me.ToolStripSeparator1, Me.tlbEnd})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(524, 25)
        Me.ToolStrip1.TabIndex = 97
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
        'tlbIzdaj
        '
        Me.tlbIzdaj.Image = Global.Farma.My.Resources.Resources.LaST__Cobalt__Text_File
        Me.tlbIzdaj.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbIzdaj.Name = "tlbIzdaj"
        Me.tlbIzdaj.Size = New System.Drawing.Size(66, 22)
        Me.tlbIzdaj.Text = "Proknjiži"
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label12.Location = New System.Drawing.Point(264, 333)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 104
        Me.Label12.Text = "Npomena"
        '
        'txtNapomene
        '
        Me.txtNapomene.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNapomene.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNapomene.Location = New System.Drawing.Point(267, 349)
        Me.txtNapomene.Multiline = True
        Me.txtNapomene.Name = "txtNapomene"
        Me.txtNapomene.Size = New System.Drawing.Size(244, 124)
        Me.txtNapomene.TabIndex = 103
        '
        'layoutPanel3
        '
        Me.layoutPanel3.ColumnCount = 3
        Me.layoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.layoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.layoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.layoutPanel3.Controls.Add(Me.Label2, 2, 1)
        Me.layoutPanel3.Controls.Add(Me.Label3, 0, 0)
        Me.layoutPanel3.Controls.Add(Me.txtPosao2, 2, 2)
        Me.layoutPanel3.Controls.Add(Me.txtPosao3, 2, 3)
        Me.layoutPanel3.Controls.Add(Me.txtPosao4, 2, 4)
        Me.layoutPanel3.Controls.Add(Me.txtPosao5, 2, 5)
        Me.layoutPanel3.Controls.Add(Me.txtPosao6, 2, 6)
        Me.layoutPanel3.Controls.Add(Me.txtIzvrsilac1, 1, 1)
        Me.layoutPanel3.Controls.Add(Me.txtIzvrsilac2, 1, 2)
        Me.layoutPanel3.Controls.Add(Me.txtIzvrsilac3, 1, 3)
        Me.layoutPanel3.Controls.Add(Me.txtIzvrsilac4, 1, 4)
        Me.layoutPanel3.Controls.Add(Me.txtIzvrsilac5, 1, 5)
        Me.layoutPanel3.Controls.Add(Me.txtIzvrsilac6, 1, 6)
        Me.layoutPanel3.Controls.Add(Me.Label5, 0, 1)
        Me.layoutPanel3.Controls.Add(Me.Label6, 0, 2)
        Me.layoutPanel3.Controls.Add(Me.Label8, 0, 3)
        Me.layoutPanel3.Controls.Add(Me.Label9, 0, 4)
        Me.layoutPanel3.Controls.Add(Me.Label10, 0, 5)
        Me.layoutPanel3.Controls.Add(Me.Label11, 0, 6)
        Me.layoutPanel3.Location = New System.Drawing.Point(10, 112)
        Me.layoutPanel3.Margin = New System.Windows.Forms.Padding(1)
        Me.layoutPanel3.Name = "layoutPanel3"
        Me.layoutPanel3.RowCount = 7
        Me.layoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.layoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.layoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.layoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.layoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.layoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.layoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.layoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.layoutPanel3.Size = New System.Drawing.Size(244, 178)
        Me.layoutPanel3.TabIndex = 102
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(151, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 26)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "NOSILAC POSLA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.layoutPanel3.SetColumnSpan(Me.Label3, 3)
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(239, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "IZVRŠIOCI"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPosao2
        '
        Me.txtPosao2.BackColor = System.Drawing.Color.GhostWhite
        Me.txtPosao2.Location = New System.Drawing.Point(151, 49)
        Me.txtPosao2.Name = "txtPosao2"
        Me.txtPosao2.Size = New System.Drawing.Size(88, 20)
        Me.txtPosao2.TabIndex = 27
        '
        'txtPosao3
        '
        Me.txtPosao3.BackColor = System.Drawing.Color.GhostWhite
        Me.txtPosao3.Location = New System.Drawing.Point(151, 75)
        Me.txtPosao3.Name = "txtPosao3"
        Me.txtPosao3.Size = New System.Drawing.Size(88, 20)
        Me.txtPosao3.TabIndex = 28
        '
        'txtPosao4
        '
        Me.txtPosao4.BackColor = System.Drawing.Color.GhostWhite
        Me.txtPosao4.Location = New System.Drawing.Point(151, 101)
        Me.txtPosao4.Name = "txtPosao4"
        Me.txtPosao4.Size = New System.Drawing.Size(88, 20)
        Me.txtPosao4.TabIndex = 29
        '
        'txtPosao5
        '
        Me.txtPosao5.BackColor = System.Drawing.Color.GhostWhite
        Me.txtPosao5.Location = New System.Drawing.Point(151, 127)
        Me.txtPosao5.Name = "txtPosao5"
        Me.txtPosao5.Size = New System.Drawing.Size(88, 20)
        Me.txtPosao5.TabIndex = 30
        '
        'txtPosao6
        '
        Me.txtPosao6.BackColor = System.Drawing.Color.GhostWhite
        Me.txtPosao6.Location = New System.Drawing.Point(151, 153)
        Me.txtPosao6.Name = "txtPosao6"
        Me.txtPosao6.Size = New System.Drawing.Size(88, 20)
        Me.txtPosao6.TabIndex = 31
        '
        'txtIzvrsilac1
        '
        Me.txtIzvrsilac1.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIzvrsilac1.Location = New System.Drawing.Point(31, 23)
        Me.txtIzvrsilac1.Name = "txtIzvrsilac1"
        Me.txtIzvrsilac1.Size = New System.Drawing.Size(114, 20)
        Me.txtIzvrsilac1.TabIndex = 20
        '
        'txtIzvrsilac2
        '
        Me.txtIzvrsilac2.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIzvrsilac2.Location = New System.Drawing.Point(31, 49)
        Me.txtIzvrsilac2.Name = "txtIzvrsilac2"
        Me.txtIzvrsilac2.Size = New System.Drawing.Size(114, 20)
        Me.txtIzvrsilac2.TabIndex = 21
        '
        'txtIzvrsilac3
        '
        Me.txtIzvrsilac3.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIzvrsilac3.Location = New System.Drawing.Point(31, 75)
        Me.txtIzvrsilac3.Name = "txtIzvrsilac3"
        Me.txtIzvrsilac3.Size = New System.Drawing.Size(114, 20)
        Me.txtIzvrsilac3.TabIndex = 22
        '
        'txtIzvrsilac4
        '
        Me.txtIzvrsilac4.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIzvrsilac4.Location = New System.Drawing.Point(31, 101)
        Me.txtIzvrsilac4.Name = "txtIzvrsilac4"
        Me.txtIzvrsilac4.Size = New System.Drawing.Size(114, 20)
        Me.txtIzvrsilac4.TabIndex = 23
        '
        'txtIzvrsilac5
        '
        Me.txtIzvrsilac5.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIzvrsilac5.Location = New System.Drawing.Point(31, 127)
        Me.txtIzvrsilac5.Name = "txtIzvrsilac5"
        Me.txtIzvrsilac5.Size = New System.Drawing.Size(114, 20)
        Me.txtIzvrsilac5.TabIndex = 24
        '
        'txtIzvrsilac6
        '
        Me.txtIzvrsilac6.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIzvrsilac6.Location = New System.Drawing.Point(31, 153)
        Me.txtIzvrsilac6.Name = "txtIzvrsilac6"
        Me.txtIzvrsilac6.Size = New System.Drawing.Size(114, 20)
        Me.txtIzvrsilac6.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(3, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 26)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "1"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(3, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 26)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "2"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(3, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 26)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "3"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(3, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 26)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "4"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(3, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 26)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "5"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label11.Location = New System.Drawing.Point(3, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 28)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "6"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'layoutPanel2
        '
        Me.layoutPanel2.ColumnCount = 3
        Me.layoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.layoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.layoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.layoutPanel2.Controls.Add(Me.chkPreventiva, 0, 6)
        Me.layoutPanel2.Controls.Add(Me.chkPreventivaEnd, 1, 6)
        Me.layoutPanel2.Controls.Add(Me.chkMontazaEnd, 1, 5)
        Me.layoutPanel2.Controls.Add(Me.chkIspitivanje, 0, 5)
        Me.layoutPanel2.Controls.Add(Me.chkPopravka, 0, 4)
        Me.layoutPanel2.Controls.Add(Me.chkIspitivanjeEnd, 1, 4)
        Me.layoutPanel2.Controls.Add(Me.chkPopravkaEnd, 1, 3)
        Me.layoutPanel2.Controls.Add(Me.chkServisiranje, 0, 3)
        Me.layoutPanel2.Controls.Add(Me.chkMontaza, 0, 2)
        Me.layoutPanel2.Controls.Add(Me.chkServisiranjeEnd, 1, 2)
        Me.layoutPanel2.Controls.Add(Me.Label1, 2, 1)
        Me.layoutPanel2.Controls.Add(Me.Label15, 0, 0)
        Me.layoutPanel2.Controls.Add(Me.Label4, 1, 1)
        Me.layoutPanel2.Controls.Add(Me.dateMontaza, 2, 2)
        Me.layoutPanel2.Controls.Add(Me.dateServis, 2, 3)
        Me.layoutPanel2.Controls.Add(Me.datePopravka, 2, 4)
        Me.layoutPanel2.Controls.Add(Me.dateIspitivanje, 2, 5)
        Me.layoutPanel2.Controls.Add(Me.datePreventiva, 2, 6)
        Me.layoutPanel2.Controls.Add(Me.chkUgovor, 0, 7)
        Me.layoutPanel2.Controls.Add(Me.chkUgovorEnd, 1, 7)
        Me.layoutPanel2.Controls.Add(Me.dateUgovor, 2, 7)
        Me.layoutPanel2.Location = New System.Drawing.Point(267, 112)
        Me.layoutPanel2.Margin = New System.Windows.Forms.Padding(1)
        Me.layoutPanel2.Name = "layoutPanel2"
        Me.layoutPanel2.RowCount = 8
        Me.layoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.layoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.layoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.layoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.layoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.layoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.layoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.layoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.layoutPanel2.Size = New System.Drawing.Size(244, 208)
        Me.layoutPanel2.TabIndex = 101
        '
        'chkPreventiva
        '
        Me.chkPreventiva.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.chkPreventiva.AutoSize = True
        Me.chkPreventiva.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPreventiva.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkPreventiva.Location = New System.Drawing.Point(3, 157)
        Me.chkPreventiva.Name = "chkPreventiva"
        Me.chkPreventiva.Size = New System.Drawing.Size(94, 17)
        Me.chkPreventiva.TabIndex = 4
        Me.chkPreventiva.Text = "PREVENTIVA"
        Me.chkPreventiva.UseVisualStyleBackColor = True
        '
        'chkPreventivaEnd
        '
        Me.chkPreventivaEnd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkPreventivaEnd.AutoSize = True
        Me.chkPreventivaEnd.Location = New System.Drawing.Point(103, 158)
        Me.chkPreventivaEnd.Name = "chkPreventivaEnd"
        Me.chkPreventivaEnd.Size = New System.Drawing.Size(15, 14)
        Me.chkPreventivaEnd.TabIndex = 19
        Me.chkPreventivaEnd.UseVisualStyleBackColor = True
        '
        'chkMontazaEnd
        '
        Me.chkMontazaEnd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkMontazaEnd.AutoSize = True
        Me.chkMontazaEnd.Location = New System.Drawing.Point(103, 131)
        Me.chkMontazaEnd.Name = "chkMontazaEnd"
        Me.chkMontazaEnd.Size = New System.Drawing.Size(15, 14)
        Me.chkMontazaEnd.TabIndex = 15
        Me.chkMontazaEnd.UseVisualStyleBackColor = True
        '
        'chkIspitivanje
        '
        Me.chkIspitivanje.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.chkIspitivanje.AutoSize = True
        Me.chkIspitivanje.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkIspitivanje.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkIspitivanje.Location = New System.Drawing.Point(7, 130)
        Me.chkIspitivanje.Name = "chkIspitivanje"
        Me.chkIspitivanje.Size = New System.Drawing.Size(90, 17)
        Me.chkIspitivanje.TabIndex = 3
        Me.chkIspitivanje.Text = "ISPITIVANJE"
        Me.chkIspitivanje.UseVisualStyleBackColor = True
        '
        'chkPopravka
        '
        Me.chkPopravka.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.chkPopravka.AutoSize = True
        Me.chkPopravka.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPopravka.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkPopravka.Location = New System.Drawing.Point(13, 103)
        Me.chkPopravka.Name = "chkPopravka"
        Me.chkPopravka.Size = New System.Drawing.Size(84, 17)
        Me.chkPopravka.TabIndex = 1
        Me.chkPopravka.Text = "POPRAVKA"
        Me.chkPopravka.UseVisualStyleBackColor = True
        '
        'chkIspitivanjeEnd
        '
        Me.chkIspitivanjeEnd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkIspitivanjeEnd.AutoSize = True
        Me.chkIspitivanjeEnd.Location = New System.Drawing.Point(103, 104)
        Me.chkIspitivanjeEnd.Name = "chkIspitivanjeEnd"
        Me.chkIspitivanjeEnd.Size = New System.Drawing.Size(15, 14)
        Me.chkIspitivanjeEnd.TabIndex = 18
        Me.chkIspitivanjeEnd.UseVisualStyleBackColor = True
        '
        'chkPopravkaEnd
        '
        Me.chkPopravkaEnd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkPopravkaEnd.AutoSize = True
        Me.chkPopravkaEnd.Location = New System.Drawing.Point(103, 77)
        Me.chkPopravkaEnd.Name = "chkPopravkaEnd"
        Me.chkPopravkaEnd.Size = New System.Drawing.Size(15, 14)
        Me.chkPopravkaEnd.TabIndex = 16
        Me.chkPopravkaEnd.UseVisualStyleBackColor = True
        '
        'chkServisiranje
        '
        Me.chkServisiranje.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.chkServisiranje.AutoSize = True
        Me.chkServisiranje.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkServisiranje.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkServisiranje.Location = New System.Drawing.Point(3, 76)
        Me.chkServisiranje.Name = "chkServisiranje"
        Me.chkServisiranje.Size = New System.Drawing.Size(94, 17)
        Me.chkServisiranje.TabIndex = 2
        Me.chkServisiranje.Text = "SERVISIRANJE"
        Me.chkServisiranje.UseVisualStyleBackColor = True
        '
        'chkMontaza
        '
        Me.chkMontaza.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.chkMontaza.AutoSize = True
        Me.chkMontaza.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMontaza.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkMontaza.Location = New System.Drawing.Point(18, 49)
        Me.chkMontaza.Name = "chkMontaza"
        Me.chkMontaza.Size = New System.Drawing.Size(79, 17)
        Me.chkMontaza.TabIndex = 0
        Me.chkMontaza.Text = "MONTAŽA"
        Me.chkMontaza.UseVisualStyleBackColor = True
        '
        'chkServisiranjeEnd
        '
        Me.chkServisiranjeEnd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkServisiranjeEnd.AutoSize = True
        Me.chkServisiranjeEnd.Location = New System.Drawing.Point(103, 50)
        Me.chkServisiranjeEnd.Name = "chkServisiranjeEnd"
        Me.chkServisiranjeEnd.Size = New System.Drawing.Size(15, 14)
        Me.chkServisiranjeEnd.TabIndex = 17
        Me.chkServisiranjeEnd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(136, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 24)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Datum"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.LightSteelBlue
        Me.layoutPanel2.SetColumnSpan(Me.Label15, 3)
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label15.Location = New System.Drawing.Point(3, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(238, 20)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "VRSTA POSLA"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(103, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 24)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Nije zavr."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dateMontaza
        '
        Me.dateMontaza.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.dateMontaza.CalendarTitleForeColor = System.Drawing.Color.WhiteSmoke
        Me.dateMontaza.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateMontaza.Location = New System.Drawing.Point(136, 47)
        Me.dateMontaza.Name = "dateMontaza"
        Me.dateMontaza.Size = New System.Drawing.Size(104, 20)
        Me.dateMontaza.TabIndex = 27
        '
        'dateServis
        '
        Me.dateServis.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.dateServis.CalendarTitleForeColor = System.Drawing.Color.WhiteSmoke
        Me.dateServis.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateServis.Location = New System.Drawing.Point(136, 74)
        Me.dateServis.Name = "dateServis"
        Me.dateServis.Size = New System.Drawing.Size(104, 20)
        Me.dateServis.TabIndex = 28
        '
        'datePopravka
        '
        Me.datePopravka.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.datePopravka.CalendarTitleForeColor = System.Drawing.Color.WhiteSmoke
        Me.datePopravka.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePopravka.Location = New System.Drawing.Point(136, 101)
        Me.datePopravka.Name = "datePopravka"
        Me.datePopravka.Size = New System.Drawing.Size(104, 20)
        Me.datePopravka.TabIndex = 29
        '
        'dateIspitivanje
        '
        Me.dateIspitivanje.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.dateIspitivanje.CalendarTitleForeColor = System.Drawing.Color.WhiteSmoke
        Me.dateIspitivanje.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateIspitivanje.Location = New System.Drawing.Point(136, 128)
        Me.dateIspitivanje.Name = "dateIspitivanje"
        Me.dateIspitivanje.Size = New System.Drawing.Size(104, 20)
        Me.dateIspitivanje.TabIndex = 30
        '
        'datePreventiva
        '
        Me.datePreventiva.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.datePreventiva.CalendarTitleForeColor = System.Drawing.Color.WhiteSmoke
        Me.datePreventiva.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePreventiva.Location = New System.Drawing.Point(136, 155)
        Me.datePreventiva.Name = "datePreventiva"
        Me.datePreventiva.Size = New System.Drawing.Size(104, 20)
        Me.datePreventiva.TabIndex = 31
        '
        'chkUgovor
        '
        Me.chkUgovor.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.chkUgovor.AutoSize = True
        Me.chkUgovor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkUgovor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkUgovor.Location = New System.Drawing.Point(24, 185)
        Me.chkUgovor.Name = "chkUgovor"
        Me.chkUgovor.Size = New System.Drawing.Size(73, 17)
        Me.chkUgovor.TabIndex = 32
        Me.chkUgovor.Text = "UGOVOR"
        Me.chkUgovor.UseVisualStyleBackColor = True
        '
        'chkUgovorEnd
        '
        Me.chkUgovorEnd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkUgovorEnd.AutoSize = True
        Me.chkUgovorEnd.Location = New System.Drawing.Point(103, 186)
        Me.chkUgovorEnd.Name = "chkUgovorEnd"
        Me.chkUgovorEnd.Size = New System.Drawing.Size(15, 14)
        Me.chkUgovorEnd.TabIndex = 33
        Me.chkUgovorEnd.UseVisualStyleBackColor = True
        '
        'dateUgovor
        '
        Me.dateUgovor.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateUgovor.Location = New System.Drawing.Point(136, 182)
        Me.dateUgovor.Name = "dateUgovor"
        Me.dateUgovor.Size = New System.Drawing.Size(103, 20)
        Me.dateUgovor.TabIndex = 34
        '
        'layoutPanel1
        '
        Me.layoutPanel1.ColumnCount = 1
        Me.layoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.layoutPanel1.Controls.Add(Me.dgStavke, 0, 1)
        Me.layoutPanel1.Controls.Add(Me.Label16, 0, 0)
        Me.layoutPanel1.Location = New System.Drawing.Point(10, 298)
        Me.layoutPanel1.Margin = New System.Windows.Forms.Padding(1)
        Me.layoutPanel1.Name = "layoutPanel1"
        Me.layoutPanel1.RowCount = 2
        Me.layoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.layoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.layoutPanel1.Size = New System.Drawing.Size(244, 178)
        Me.layoutPanel1.TabIndex = 100
        '
        'dgStavke
        '
        Me.dgStavke.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.dgStavke.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgStavke.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStavke.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cRb, Me.cMaterijal, Me.cKol})
        Me.dgStavke.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgStavke.Location = New System.Drawing.Point(3, 23)
        Me.dgStavke.Name = "dgStavke"
        Me.dgStavke.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgStavke.RowHeadersWidth = 25
        Me.dgStavke.Size = New System.Drawing.Size(238, 152)
        Me.dgStavke.TabIndex = 90
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label16.Location = New System.Drawing.Point(3, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(238, 20)
        Me.Label16.TabIndex = 91
        Me.Label16.Text = "LISTA ISPORUKE"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel1.Controls.Add(Me.labNaloga)
        Me.Panel1.Controls.Add(Me.btnIzaberiNalog)
        Me.Panel1.Controls.Add(Me.txtSifra)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(12, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(499, 64)
        Me.Panel1.TabIndex = 99
        '
        'labNaloga
        '
        Me.labNaloga.AutoSize = True
        Me.labNaloga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labNaloga.ForeColor = System.Drawing.Color.MidnightBlue
        Me.labNaloga.Location = New System.Drawing.Point(130, 28)
        Me.labNaloga.Name = "labNaloga"
        Me.labNaloga.Size = New System.Drawing.Size(52, 15)
        Me.labNaloga.TabIndex = 12
        Me.labNaloga.Text = "Label13"
        '
        'btnIzaberiNalog
        '
        Me.btnIzaberiNalog.Location = New System.Drawing.Point(469, 25)
        Me.btnIzaberiNalog.Name = "btnIzaberiNalog"
        Me.btnIzaberiNalog.Size = New System.Drawing.Size(25, 20)
        Me.btnIzaberiNalog.TabIndex = 11
        Me.btnIzaberiNalog.Text = "..."
        Me.btnIzaberiNalog.UseVisualStyleBackColor = True
        Me.btnIzaberiNalog.Visible = False
        '
        'txtSifra
        '
        Me.txtSifra.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSifra.Location = New System.Drawing.Point(17, 27)
        Me.txtSifra.Name = "txtSifra"
        Me.txtSifra.Size = New System.Drawing.Size(61, 20)
        Me.txtSifra.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Potvrda broj"
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
        'cRb
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cRb.DefaultCellStyle = DataGridViewCellStyle2
        Me.cRb.HeaderText = "Rb"
        Me.cRb.Name = "cRb"
        Me.cRb.Width = 30
        '
        'cMaterijal
        '
        Me.cMaterijal.DataSource = Me.RmartikliBindingSource
        Me.cMaterijal.DisplayMember = "naziv"
        Me.cMaterijal.HeaderText = "Materijal"
        Me.cMaterijal.Name = "cMaterijal"
        Me.cMaterijal.ValueMember = "naziv"
        Me.cMaterijal.Width = 138
        '
        'cKol
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cKol.DefaultCellStyle = DataGridViewCellStyle3
        Me.cKol.HeaderText = "Kol"
        Me.cKol.Name = "cKol"
        Me.cKol.Width = 40
        '
        'frmPotvrdaEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(524, 489)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNapomene)
        Me.Controls.Add(Me.layoutPanel3)
        Me.Controls.Add(Me.layoutPanel2)
        Me.Controls.Add(Me.layoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPotvrdaEdit"
        Me.Text = "Potvrda - Edit"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.layoutPanel3.ResumeLayout(False)
        Me.layoutPanel3.PerformLayout()
        Me.layoutPanel2.ResumeLayout(False)
        Me.layoutPanel2.PerformLayout()
        Me.layoutPanel1.ResumeLayout(False)
        CType(Me.dgStavke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RmartikliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbSnimi As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbStanje As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbIzdaj As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbEnd As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNapomene As System.Windows.Forms.TextBox
    Friend WithEvents layoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPosao2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPosao3 As System.Windows.Forms.TextBox
    Friend WithEvents txtPosao4 As System.Windows.Forms.TextBox
    Friend WithEvents txtPosao5 As System.Windows.Forms.TextBox
    Friend WithEvents txtPosao6 As System.Windows.Forms.TextBox
    Friend WithEvents txtIzvrsilac1 As System.Windows.Forms.TextBox
    Friend WithEvents txtIzvrsilac2 As System.Windows.Forms.TextBox
    Friend WithEvents txtIzvrsilac3 As System.Windows.Forms.TextBox
    Friend WithEvents txtIzvrsilac4 As System.Windows.Forms.TextBox
    Friend WithEvents txtIzvrsilac5 As System.Windows.Forms.TextBox
    Friend WithEvents txtIzvrsilac6 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents layoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkPreventiva As System.Windows.Forms.CheckBox
    Friend WithEvents chkPreventivaEnd As System.Windows.Forms.CheckBox
    Friend WithEvents chkMontazaEnd As System.Windows.Forms.CheckBox
    Friend WithEvents chkIspitivanje As System.Windows.Forms.CheckBox
    Friend WithEvents chkPopravka As System.Windows.Forms.CheckBox
    Friend WithEvents chkIspitivanjeEnd As System.Windows.Forms.CheckBox
    Friend WithEvents chkPopravkaEnd As System.Windows.Forms.CheckBox
    Friend WithEvents chkServisiranje As System.Windows.Forms.CheckBox
    Friend WithEvents chkMontaza As System.Windows.Forms.CheckBox
    Friend WithEvents chkServisiranjeEnd As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dateMontaza As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateServis As System.Windows.Forms.DateTimePicker
    Friend WithEvents datePopravka As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateIspitivanje As System.Windows.Forms.DateTimePicker
    Friend WithEvents datePreventiva As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkUgovor As System.Windows.Forms.CheckBox
    Friend WithEvents chkUgovorEnd As System.Windows.Forms.CheckBox
    Friend WithEvents dateUgovor As System.Windows.Forms.DateTimePicker
    Friend WithEvents layoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgStavke As System.Windows.Forms.DataGridView
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents labNaloga As System.Windows.Forms.Label
    Friend WithEvents btnIzaberiNalog As System.Windows.Forms.Button
    Friend WithEvents txtSifra As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As Farma.DataSet1
    Friend WithEvents RmartikliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rm_artikliTableAdapter As Farma.DataSet1TableAdapters.rm_artikliTableAdapter
    Friend WithEvents cRb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMaterijal As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cKol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
