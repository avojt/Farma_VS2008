<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntArtiklEdit
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
        Me.tlbMain = New System.Windows.Forms.TableLayoutPanel
        Me.tlbLek = New System.Windows.Forms.TableLayoutPanel
        Me.Label6 = New System.Windows.Forms.Label
        Me.dateDO = New System.Windows.Forms.DateTimePicker
        Me.dateOD = New System.Windows.Forms.DateTimePicker
        Me.cmbFO = New System.Windows.Forms.ComboBox
        Me.cmbGenericko = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmbPodgrupa = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.chkPozitivna = New System.Windows.Forms.CheckBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtJKL_sifra = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtNaziv = New System.Windows.Forms.TextBox
        Me.txtSifra = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.tlbDetails = New System.Windows.Forms.TableLayoutPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbJM = New System.Windows.Forms.ComboBox
        Me.cmbProizvodjac = New System.Windows.Forms.ComboBox
        Me.chkRegAdr = New System.Windows.Forms.CheckBox
        Me.chkRokTr = New System.Windows.Forms.CheckBox
        Me.chkSerBr = New System.Windows.Forms.CheckBox
        Me.chkHumanitarna = New System.Windows.Forms.CheckBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.rtxOpisGrupe = New System.Windows.Forms.RichTextBox
        Me.cmbGrupaArtikla = New System.Windows.Forms.ComboBox
        Me.btnSnimi = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.tlbMain.SuspendLayout()
        Me.tlbLek.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tlbDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlbMain
        '
        Me.tlbMain.BackColor = System.Drawing.Color.Lavender
        Me.tlbMain.ColumnCount = 3
        Me.tlbMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 313.0!))
        Me.tlbMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlbMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbMain.Controls.Add(Me.tlbLek, 0, 5)
        Me.tlbMain.Controls.Add(Me.TableLayoutPanel1, 0, 2)
        Me.tlbMain.Controls.Add(Me.Panel1, 0, 1)
        Me.tlbMain.Controls.Add(Me.TableLayoutPanel2, 0, 4)
        Me.tlbMain.Controls.Add(Me.tlbDetails, 0, 3)
        Me.tlbMain.Controls.Add(Me.btnSnimi, 1, 6)
        Me.tlbMain.Controls.Add(Me.btnCancel, 2, 6)
        Me.tlbMain.ForeColor = System.Drawing.Color.MidnightBlue
        Me.tlbMain.Location = New System.Drawing.Point(15, 14)
        Me.tlbMain.Name = "tlbMain"
        Me.tlbMain.RowCount = 7
        Me.tlbMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tlbMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlbMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlbMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.tlbMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlbMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain.Size = New System.Drawing.Size(652, 533)
        Me.tlbMain.TabIndex = 12
        '
        'tlbLek
        '
        Me.tlbLek.ColumnCount = 2
        Me.tlbLek.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlbLek.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbLek.Controls.Add(Me.Label6, 0, 5)
        Me.tlbLek.Controls.Add(Me.dateDO, 1, 5)
        Me.tlbLek.Controls.Add(Me.dateOD, 1, 4)
        Me.tlbLek.Controls.Add(Me.cmbFO, 1, 7)
        Me.tlbLek.Controls.Add(Me.cmbGenericko, 1, 6)
        Me.tlbLek.Controls.Add(Me.Label10, 0, 7)
        Me.tlbLek.Controls.Add(Me.cmbPodgrupa, 1, 3)
        Me.tlbLek.Controls.Add(Me.Label9, 0, 6)
        Me.tlbLek.Controls.Add(Me.Label5, 0, 4)
        Me.tlbLek.Controls.Add(Me.Label4, 0, 3)
        Me.tlbLek.Controls.Add(Me.chkPozitivna, 1, 2)
        Me.tlbLek.Controls.Add(Me.Label13, 0, 1)
        Me.tlbLek.Controls.Add(Me.txtJKL_sifra, 1, 1)
        Me.tlbLek.Location = New System.Drawing.Point(3, 295)
        Me.tlbLek.Name = "tlbLek"
        Me.tlbLek.RowCount = 9
        Me.tlbLek.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlbLek.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlbLek.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlbLek.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlbLek.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlbLek.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlbLek.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlbLek.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlbLek.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbLek.Size = New System.Drawing.Size(300, 201)
        Me.tlbLek.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 13)
        Me.Label6.TabIndex = 168
        Me.Label6.Text = "Dat. prestanka važenja"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dateDO
        '
        Me.dateDO.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateDO.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.dateDO.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.dateDO.Location = New System.Drawing.Point(133, 117)
        Me.dateDO.Name = "dateDO"
        Me.dateDO.Size = New System.Drawing.Size(164, 20)
        Me.dateDO.TabIndex = 166
        '
        'dateOD
        '
        Me.dateOD.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateOD.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.dateOD.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.dateOD.Location = New System.Drawing.Point(133, 91)
        Me.dateOD.Name = "dateOD"
        Me.dateOD.Size = New System.Drawing.Size(164, 20)
        Me.dateOD.TabIndex = 165
        '
        'cmbFO
        '
        Me.cmbFO.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbFO.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbFO.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbFO.FormattingEnabled = True
        Me.cmbFO.Location = New System.Drawing.Point(133, 169)
        Me.cmbFO.Name = "cmbFO"
        Me.cmbFO.Size = New System.Drawing.Size(164, 21)
        Me.cmbFO.TabIndex = 169
        '
        'cmbGenericko
        '
        Me.cmbGenericko.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbGenericko.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbGenericko.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbGenericko.FormattingEnabled = True
        Me.cmbGenericko.Location = New System.Drawing.Point(133, 143)
        Me.cmbGenericko.Name = "cmbGenericko"
        Me.cmbGenericko.Size = New System.Drawing.Size(164, 21)
        Me.cmbGenericko.TabIndex = 164
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(100, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 170
        Me.Label10.Text = "F.O."
        '
        'cmbPodgrupa
        '
        Me.cmbPodgrupa.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPodgrupa.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbPodgrupa.FormattingEnabled = True
        Me.cmbPodgrupa.Location = New System.Drawing.Point(133, 65)
        Me.cmbPodgrupa.Name = "cmbPodgrupa"
        Me.cmbPodgrupa.Size = New System.Drawing.Size(164, 21)
        Me.cmbPodgrupa.TabIndex = 162
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(52, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 133
        Me.Label9.Text = "Generičko ime"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 167
        Me.Label5.Text = "Dat. početka važenja"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 161
        Me.Label4.Text = "Podgrupa"
        '
        'chkPozitivna
        '
        Me.chkPozitivna.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkPozitivna.AutoSize = True
        Me.chkPozitivna.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkPozitivna.Location = New System.Drawing.Point(133, 40)
        Me.chkPozitivna.Name = "chkPozitivna"
        Me.chkPozitivna.Size = New System.Drawing.Size(90, 17)
        Me.chkPozitivna.TabIndex = 147
        Me.chkPozitivna.Text = "Pozitivna lista"
        Me.chkPozitivna.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label13.Location = New System.Drawing.Point(80, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 134
        Me.Label13.Text = "JKL-šifra"
        '
        'txtJKL_sifra
        '
        Me.txtJKL_sifra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJKL_sifra.BackColor = System.Drawing.Color.GhostWhite
        Me.txtJKL_sifra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtJKL_sifra.Location = New System.Drawing.Point(133, 13)
        Me.txtJKL_sifra.Name = "txtJKL_sifra"
        Me.txtJKL_sifra.Size = New System.Drawing.Size(164, 20)
        Me.txtJKL_sifra.TabIndex = 163
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.tlbMain.SetColumnSpan(Me.TableLayoutPanel1, 3)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 98)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(646, 2)
        Me.TableLayoutPanel1.TabIndex = 172
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tlbMain.SetColumnSpan(Me.Panel1, 3)
        Me.Panel1.Controls.Add(Me.txtNaziv)
        Me.Panel1.Controls.Add(Me.txtSifra)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(3, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(646, 66)
        Me.Panel1.TabIndex = 102
        '
        'txtNaziv
        '
        Me.txtNaziv.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNaziv.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNaziv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNaziv.Location = New System.Drawing.Point(118, 25)
        Me.txtNaziv.Name = "txtNaziv"
        Me.txtNaziv.Size = New System.Drawing.Size(496, 20)
        Me.txtNaziv.TabIndex = 2
        Me.txtNaziv.Text = "naziv"
        '
        'txtSifra
        '
        Me.txtSifra.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtSifra.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSifra.Enabled = False
        Me.txtSifra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSifra.Location = New System.Drawing.Point(11, 25)
        Me.txtSifra.Name = "txtSifra"
        Me.txtSifra.Size = New System.Drawing.Size(101, 20)
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
        Me.Label8.Location = New System.Drawing.Point(115, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Naziv"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.tlbMain.SetColumnSpan(Me.TableLayoutPanel2, 3)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 287)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(646, 2)
        Me.TableLayoutPanel2.TabIndex = 171
        '
        'tlbDetails
        '
        Me.tlbDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlbDetails.BackColor = System.Drawing.Color.Lavender
        Me.tlbDetails.ColumnCount = 5
        Me.tlbMain.SetColumnSpan(Me.tlbDetails, 3)
        Me.tlbDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlbDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.tlbDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132.0!))
        Me.tlbDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlbDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbDetails.Controls.Add(Me.Label1, 0, 0)
        Me.tlbDetails.Controls.Add(Me.cmbJM, 4, 0)
        Me.tlbDetails.Controls.Add(Me.cmbProizvodjac, 4, 1)
        Me.tlbDetails.Controls.Add(Me.chkRegAdr, 4, 6)
        Me.tlbDetails.Controls.Add(Me.chkRokTr, 4, 5)
        Me.tlbDetails.Controls.Add(Me.chkSerBr, 4, 4)
        Me.tlbDetails.Controls.Add(Me.chkHumanitarna, 4, 3)
        Me.tlbDetails.Controls.Add(Me.Label2, 3, 0)
        Me.tlbDetails.Controls.Add(Me.rtxOpisGrupe, 1, 2)
        Me.tlbDetails.Controls.Add(Me.cmbGrupaArtikla, 1, 0)
        Me.tlbDetails.Controls.Add(Me.Label16, 3, 1)
        Me.tlbDetails.ForeColor = System.Drawing.Color.MidnightBlue
        Me.tlbDetails.Location = New System.Drawing.Point(3, 107)
        Me.tlbDetails.Name = "tlbDetails"
        Me.tlbDetails.RowCount = 7
        Me.tlbDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlbDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlbDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlbDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlbDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlbDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlbDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlbDetails.Size = New System.Drawing.Size(646, 168)
        Me.tlbDetails.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(9, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Grupa Artikla"
        '
        'cmbJM
        '
        Me.cmbJM.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbJM.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbJM.FormattingEnabled = True
        Me.cmbJM.Location = New System.Drawing.Point(403, 3)
        Me.cmbJM.Name = "cmbJM"
        Me.cmbJM.Size = New System.Drawing.Size(67, 21)
        Me.cmbJM.TabIndex = 153
        '
        'cmbProizvodjac
        '
        Me.cmbProizvodjac.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmbProizvodjac.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbProizvodjac.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbProizvodjac.FormattingEnabled = True
        Me.cmbProizvodjac.Location = New System.Drawing.Point(403, 29)
        Me.cmbProizvodjac.Name = "cmbProizvodjac"
        Me.cmbProizvodjac.Size = New System.Drawing.Size(234, 21)
        Me.cmbProizvodjac.TabIndex = 141
        '
        'chkRegAdr
        '
        Me.chkRegAdr.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkRegAdr.AutoSize = True
        Me.chkRegAdr.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkRegAdr.Location = New System.Drawing.Point(403, 145)
        Me.chkRegAdr.Name = "chkRegAdr"
        Me.chkRegAdr.Size = New System.Drawing.Size(176, 17)
        Me.chkRegAdr.TabIndex = 157
        Me.chkRegAdr.Text = "Praćenje zal. po  regalnoj adresi"
        Me.chkRegAdr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRegAdr.UseVisualStyleBackColor = True
        '
        'chkRokTr
        '
        Me.chkRokTr.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkRokTr.AutoSize = True
        Me.chkRokTr.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkRokTr.Location = New System.Drawing.Point(403, 118)
        Me.chkRokTr.Name = "chkRokTr"
        Me.chkRokTr.Size = New System.Drawing.Size(163, 17)
        Me.chkRokTr.TabIndex = 156
        Me.chkRokTr.Text = "Praćenje zal. po roku trajanja"
        Me.chkRokTr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRokTr.UseVisualStyleBackColor = True
        '
        'chkSerBr
        '
        Me.chkSerBr.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkSerBr.AutoSize = True
        Me.chkSerBr.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkSerBr.Location = New System.Drawing.Point(403, 92)
        Me.chkSerBr.Name = "chkSerBr"
        Me.chkSerBr.Size = New System.Drawing.Size(159, 17)
        Me.chkSerBr.TabIndex = 155
        Me.chkSerBr.Text = "Praćenje zal. po serijskim br."
        Me.chkSerBr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSerBr.UseVisualStyleBackColor = True
        '
        'chkHumanitarna
        '
        Me.chkHumanitarna.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkHumanitarna.AutoSize = True
        Me.chkHumanitarna.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkHumanitarna.Location = New System.Drawing.Point(403, 66)
        Me.chkHumanitarna.Name = "chkHumanitarna"
        Me.chkHumanitarna.Size = New System.Drawing.Size(121, 17)
        Me.chkHumanitarna.TabIndex = 154
        Me.chkHumanitarna.Text = "Humanitarna pomoć"
        Me.chkHumanitarna.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkHumanitarna.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label16.Location = New System.Drawing.Point(335, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 135
        Me.Label16.Text = "Proizvodjač"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(380, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 13)
        Me.Label2.TabIndex = 148
        Me.Label2.Text = "jm"
        '
        'rtxOpisGrupe
        '
        Me.rtxOpisGrupe.BackColor = System.Drawing.Color.Lavender
        Me.rtxOpisGrupe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tlbDetails.SetColumnSpan(Me.rtxOpisGrupe, 2)
        Me.rtxOpisGrupe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.rtxOpisGrupe.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rtxOpisGrupe.Location = New System.Drawing.Point(83, 55)
        Me.rtxOpisGrupe.Name = "rtxOpisGrupe"
        Me.rtxOpisGrupe.ReadOnly = True
        Me.tlbDetails.SetRowSpan(Me.rtxOpisGrupe, 5)
        Me.rtxOpisGrupe.Size = New System.Drawing.Size(224, 108)
        Me.rtxOpisGrupe.TabIndex = 9
        Me.rtxOpisGrupe.Text = ""
        '
        'cmbGrupaArtikla
        '
        Me.cmbGrupaArtikla.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbGrupaArtikla.BackColor = System.Drawing.Color.GhostWhite
        Me.tlbDetails.SetColumnSpan(Me.cmbGrupaArtikla, 2)
        Me.cmbGrupaArtikla.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbGrupaArtikla.FormattingEnabled = True
        Me.cmbGrupaArtikla.Location = New System.Drawing.Point(83, 3)
        Me.cmbGrupaArtikla.Name = "cmbGrupaArtikla"
        Me.cmbGrupaArtikla.Size = New System.Drawing.Size(224, 21)
        Me.cmbGrupaArtikla.TabIndex = 139
        '
        'btnSnimi
        '
        Me.btnSnimi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSnimi.Location = New System.Drawing.Point(316, 506)
        Me.btnSnimi.Name = "btnSnimi"
        Me.btnSnimi.Size = New System.Drawing.Size(75, 21)
        Me.btnSnimi.TabIndex = 159
        Me.btnSnimi.Text = "SNIMI"
        Me.btnSnimi.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCancel.Location = New System.Drawing.Point(406, 506)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 21)
        Me.btnCancel.TabIndex = 160
        Me.btnCancel.Text = "OTKAŽI"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cntArtiklEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.tlbMain)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntArtiklEdit"
        Me.Size = New System.Drawing.Size(682, 557)
        Me.tlbMain.ResumeLayout(False)
        Me.tlbLek.ResumeLayout(False)
        Me.tlbLek.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tlbDetails.ResumeLayout(False)
        Me.tlbDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlbMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlbLek As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dateDO As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateOD As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbFO As System.Windows.Forms.ComboBox
    Friend WithEvents cmbGenericko As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbPodgrupa As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkPozitivna As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtJKL_sifra As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtNaziv As System.Windows.Forms.TextBox
    Friend WithEvents txtSifra As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlbDetails As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbJM As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProizvodjac As System.Windows.Forms.ComboBox
    Friend WithEvents chkRegAdr As System.Windows.Forms.CheckBox
    Friend WithEvents chkRokTr As System.Windows.Forms.CheckBox
    Friend WithEvents chkSerBr As System.Windows.Forms.CheckBox
    Friend WithEvents chkHumanitarna As System.Windows.Forms.CheckBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbGrupaArtikla As System.Windows.Forms.ComboBox
    Friend WithEvents rtxOpisGrupe As System.Windows.Forms.RichTextBox
    Friend WithEvents btnSnimi As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button

End Class
