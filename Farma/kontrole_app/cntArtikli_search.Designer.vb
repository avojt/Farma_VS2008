<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntArtikli_search
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
        Me.mPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.rbtSvi = New System.Windows.Forms.RadioButton
        Me.rbtAtivni = New System.Windows.Forms.RadioButton
        Me.rbtAtivniPeriod = New System.Windows.Forms.RadioButton
        Me.dateDatumOd = New System.Windows.Forms.DateTimePicker
        Me.dateDatumDo = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.labDatumDo = New System.Windows.Forms.Label
        Me.labDatumOd = New System.Windows.Forms.Label
        Me.mPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.chkNaziv = New System.Windows.Forms.CheckBox
        Me.txtNaziv = New System.Windows.Forms.TextBox
        Me.cmbGrupa = New System.Windows.Forms.ComboBox
        Me.chkGrupa = New System.Windows.Forms.CheckBox
        Me.chkProizvodjac = New System.Windows.Forms.CheckBox
        Me.chkGenericko = New System.Windows.Forms.CheckBox
        Me.cmbGenericko = New System.Windows.Forms.ComboBox
        Me.cmbPartner = New System.Windows.Forms.ComboBox
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel
        Me.chkABC = New System.Windows.Forms.CheckBox
        Me.btnPronadji = New System.Windows.Forms.Button
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Label2 = New System.Windows.Forms.Label
        Me.labCount = New System.Windows.Forms.Label
        Me.tlbABC = New System.Windows.Forms.TableLayoutPanel
        Me.rbtL2 = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.mPanel = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Label4 = New System.Windows.Forms.Label
        Me.rbtSvi_lista = New System.Windows.Forms.RadioButton
        Me.rbtL1 = New System.Windows.Forms.RadioButton
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.mPanel3.SuspendLayout()
        Me.mPanel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.mPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'mPanel3
        '
        Me.mPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mPanel3.BackColor = System.Drawing.Color.Lavender
        Me.mPanel3.ColumnCount = 2
        Me.mPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.mPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mPanel3.Controls.Add(Me.rbtSvi, 0, 1)
        Me.mPanel3.Controls.Add(Me.rbtAtivni, 0, 2)
        Me.mPanel3.Controls.Add(Me.rbtAtivniPeriod, 0, 3)
        Me.mPanel3.Controls.Add(Me.dateDatumOd, 1, 4)
        Me.mPanel3.Controls.Add(Me.dateDatumDo, 1, 5)
        Me.mPanel3.Controls.Add(Me.Label5, 0, 0)
        Me.mPanel3.Controls.Add(Me.labDatumDo, 0, 5)
        Me.mPanel3.Controls.Add(Me.labDatumOd, 0, 4)
        Me.mPanel3.Location = New System.Drawing.Point(165, 3)
        Me.mPanel3.Name = "mPanel3"
        Me.mPanel3.RowCount = 6
        Me.mPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.mPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.mPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.mPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.mPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.mPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mPanel3.Size = New System.Drawing.Size(279, 138)
        Me.mPanel3.TabIndex = 32
        '
        'rbtSvi
        '
        Me.rbtSvi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbtSvi.AutoSize = True
        Me.rbtSvi.Location = New System.Drawing.Point(3, 26)
        Me.rbtSvi.Name = "rbtSvi"
        Me.rbtSvi.Size = New System.Drawing.Size(79, 17)
        Me.rbtSvi.TabIndex = 17
        Me.rbtSvi.TabStop = True
        Me.rbtSvi.Text = "Svi artikli"
        Me.rbtSvi.UseVisualStyleBackColor = True
        '
        'rbtAtivni
        '
        Me.rbtAtivni.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbtAtivni.AutoSize = True
        Me.rbtAtivni.Location = New System.Drawing.Point(3, 49)
        Me.rbtAtivni.Name = "rbtAtivni"
        Me.rbtAtivni.Size = New System.Drawing.Size(142, 17)
        Me.rbtAtivni.TabIndex = 18
        Me.rbtAtivni.TabStop = True
        Me.rbtAtivni.Text = "Aktivni u ovoj godini"
        Me.rbtAtivni.UseVisualStyleBackColor = True
        '
        'rbtAtivniPeriod
        '
        Me.rbtAtivniPeriod.AutoSize = True
        Me.rbtAtivniPeriod.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbtAtivniPeriod.Location = New System.Drawing.Point(3, 72)
        Me.rbtAtivniPeriod.Name = "rbtAtivniPeriod"
        Me.rbtAtivniPeriod.Size = New System.Drawing.Size(119, 17)
        Me.rbtAtivniPeriod.TabIndex = 26
        Me.rbtAtivniPeriod.TabStop = True
        Me.rbtAtivniPeriod.Text = "Aktivni u periodu"
        Me.rbtAtivniPeriod.UseCompatibleTextRendering = True
        Me.rbtAtivniPeriod.UseVisualStyleBackColor = True
        '
        'dateDatumOd
        '
        Me.dateDatumOd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dateDatumOd.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.dateDatumOd.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.dateDatumOd.CalendarTitleForeColor = System.Drawing.Color.GhostWhite
        Me.dateDatumOd.Font = New System.Drawing.Font("MS Reference Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.dateDatumOd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateDatumOd.Location = New System.Drawing.Point(152, 94)
        Me.dateDatumOd.Margin = New System.Windows.Forms.Padding(2)
        Me.dateDatumOd.Name = "dateDatumOd"
        Me.dateDatumOd.Size = New System.Drawing.Size(102, 18)
        Me.dateDatumOd.TabIndex = 10
        '
        'dateDatumDo
        '
        Me.dateDatumDo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dateDatumDo.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.dateDatumDo.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.dateDatumDo.CalendarTitleForeColor = System.Drawing.Color.GhostWhite
        Me.dateDatumDo.Font = New System.Drawing.Font("MS Reference Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.dateDatumDo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateDatumDo.Location = New System.Drawing.Point(152, 117)
        Me.dateDatumDo.Margin = New System.Windows.Forms.Padding(2)
        Me.dateDatumDo.Name = "dateDatumDo"
        Me.dateDatumDo.Size = New System.Drawing.Size(102, 18)
        Me.dateDatumDo.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.mPanel3.SetColumnSpan(Me.Label5, 2)
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(273, 23)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Aktivni artikli"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labDatumDo
        '
        Me.labDatumDo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.labDatumDo.AutoSize = True
        Me.labDatumDo.Location = New System.Drawing.Point(82, 119)
        Me.labDatumDo.Name = "labDatumDo"
        Me.labDatumDo.Size = New System.Drawing.Size(65, 15)
        Me.labDatumDo.TabIndex = 2
        Me.labDatumDo.Text = "Datum Do"
        '
        'labDatumOd
        '
        Me.labDatumOd.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.labDatumOd.AutoSize = True
        Me.labDatumOd.Location = New System.Drawing.Point(82, 96)
        Me.labDatumOd.Name = "labDatumOd"
        Me.labDatumOd.Size = New System.Drawing.Size(65, 15)
        Me.labDatumOd.TabIndex = 1
        Me.labDatumOd.Text = "Datum Od"
        '
        'mPanel2
        '
        Me.mPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mPanel2.ColumnCount = 2
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mPanel2.Controls.Add(Me.chkNaziv, 0, 0)
        Me.mPanel2.Controls.Add(Me.txtNaziv, 1, 0)
        Me.mPanel2.Controls.Add(Me.cmbGrupa, 1, 1)
        Me.mPanel2.Controls.Add(Me.chkGrupa, 0, 1)
        Me.mPanel2.Controls.Add(Me.chkProizvodjac, 0, 3)
        Me.mPanel2.Controls.Add(Me.chkGenericko, 0, 2)
        Me.mPanel2.Controls.Add(Me.cmbGenericko, 1, 2)
        Me.mPanel2.Controls.Add(Me.cmbPartner, 1, 3)
        Me.mPanel2.Controls.Add(Me.TableLayoutPanel5, 0, 6)
        Me.mPanel2.Controls.Add(Me.TableLayoutPanel2, 0, 5)
        Me.mPanel2.Location = New System.Drawing.Point(3, 41)
        Me.mPanel2.Name = "mPanel2"
        Me.mPanel2.RowCount = 8
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mPanel2.Size = New System.Drawing.Size(377, 203)
        Me.mPanel2.TabIndex = 31
        '
        'chkNaziv
        '
        Me.chkNaziv.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkNaziv.AutoSize = True
        Me.chkNaziv.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkNaziv.Location = New System.Drawing.Point(3, 4)
        Me.chkNaziv.Name = "chkNaziv"
        Me.chkNaziv.Size = New System.Drawing.Size(63, 19)
        Me.chkNaziv.TabIndex = 22
        Me.chkNaziv.Text = "NAZIV"
        Me.chkNaziv.UseVisualStyleBackColor = True
        '
        'txtNaziv
        '
        Me.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtNaziv.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNaziv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNaziv.Location = New System.Drawing.Point(123, 3)
        Me.txtNaziv.Name = "txtNaziv"
        Me.txtNaziv.Size = New System.Drawing.Size(232, 21)
        Me.txtNaziv.TabIndex = 14
        '
        'cmbGrupa
        '
        Me.cmbGrupa.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmbGrupa.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbGrupa.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmbGrupa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbGrupa.FormattingEnabled = True
        Me.cmbGrupa.Location = New System.Drawing.Point(123, 30)
        Me.cmbGrupa.Name = "cmbGrupa"
        Me.cmbGrupa.Size = New System.Drawing.Size(232, 23)
        Me.cmbGrupa.TabIndex = 27
        '
        'chkGrupa
        '
        Me.chkGrupa.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkGrupa.AutoSize = True
        Me.chkGrupa.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkGrupa.Location = New System.Drawing.Point(3, 31)
        Me.chkGrupa.Name = "chkGrupa"
        Me.chkGrupa.Size = New System.Drawing.Size(66, 19)
        Me.chkGrupa.TabIndex = 23
        Me.chkGrupa.Text = "GRUPA"
        Me.chkGrupa.UseVisualStyleBackColor = True
        '
        'chkProizvodjac
        '
        Me.chkProizvodjac.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkProizvodjac.AutoSize = True
        Me.chkProizvodjac.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkProizvodjac.Location = New System.Drawing.Point(3, 85)
        Me.chkProizvodjac.Name = "chkProizvodjac"
        Me.chkProizvodjac.Size = New System.Drawing.Size(111, 19)
        Me.chkProizvodjac.TabIndex = 25
        Me.chkProizvodjac.Text = "PROIZVODJAČ"
        Me.chkProizvodjac.UseVisualStyleBackColor = True
        '
        'chkGenericko
        '
        Me.chkGenericko.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkGenericko.AutoSize = True
        Me.chkGenericko.Location = New System.Drawing.Point(3, 58)
        Me.chkGenericko.Name = "chkGenericko"
        Me.chkGenericko.Size = New System.Drawing.Size(95, 19)
        Me.chkGenericko.TabIndex = 35
        Me.chkGenericko.Text = "GEN. NAZIV"
        Me.chkGenericko.UseVisualStyleBackColor = True
        '
        'cmbGenericko
        '
        Me.cmbGenericko.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmbGenericko.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbGenericko.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbGenericko.FormattingEnabled = True
        Me.cmbGenericko.Location = New System.Drawing.Point(123, 57)
        Me.cmbGenericko.Name = "cmbGenericko"
        Me.cmbGenericko.Size = New System.Drawing.Size(232, 23)
        Me.cmbGenericko.TabIndex = 36
        '
        'cmbPartner
        '
        Me.cmbPartner.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmbPartner.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbPartner.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbPartner.FormattingEnabled = True
        Me.cmbPartner.Location = New System.Drawing.Point(123, 84)
        Me.cmbPartner.Name = "cmbPartner"
        Me.cmbPartner.Size = New System.Drawing.Size(232, 23)
        Me.cmbPartner.TabIndex = 8
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.mPanel2.SetColumnSpan(Me.TableLayoutPanel5, 2)
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.80323!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.19677!))
        Me.TableLayoutPanel5.Controls.Add(Me.chkABC, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnPronadji, 1, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 157)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(371, 30)
        Me.TableLayoutPanel5.TabIndex = 38
        '
        'chkABC
        '
        Me.chkABC.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkABC.AutoSize = True
        Me.chkABC.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkABC.Location = New System.Drawing.Point(3, 5)
        Me.chkABC.Name = "chkABC"
        Me.chkABC.Size = New System.Drawing.Size(226, 19)
        Me.chkABC.TabIndex = 0
        Me.chkABC.Text = "Složi po abecednom redu"
        Me.chkABC.UseVisualStyleBackColor = True
        '
        'btnPronadji
        '
        Me.btnPronadji.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnPronadji.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPronadji.Location = New System.Drawing.Point(268, 3)
        Me.btnPronadji.Name = "btnPronadji"
        Me.btnPronadji.Size = New System.Drawing.Size(100, 24)
        Me.btnPronadji.TabIndex = 29
        Me.btnPronadji.Text = "PRONADJI"
        Me.btnPronadji.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.mPanel2.SetColumnSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 149)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(371, 2)
        Me.TableLayoutPanel2.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Pronadjeno je"
        '
        'labCount
        '
        Me.labCount.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.labCount.AutoSize = True
        Me.labCount.Location = New System.Drawing.Point(152, 4)
        Me.labCount.Name = "labCount"
        Me.labCount.Size = New System.Drawing.Size(12, 15)
        Me.labCount.TabIndex = 34
        Me.labCount.Text = "."
        '
        'tlbABC
        '
        Me.tlbABC.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tlbABC.ColumnCount = 1
        Me.TableLayoutPanel1.SetColumnSpan(Me.tlbABC, 3)
        Me.tlbABC.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlbABC.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlbABC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlbABC.Location = New System.Drawing.Point(3, 149)
        Me.tlbABC.Name = "tlbABC"
        Me.tlbABC.RowCount = 1
        Me.tlbABC.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbABC.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlbABC.Size = New System.Drawing.Size(441, 2)
        Me.tlbABC.TabIndex = 33
        '
        'rbtL2
        '
        Me.rbtL2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbtL2.AutoSize = True
        Me.rbtL2.Location = New System.Drawing.Point(3, 72)
        Me.rbtL2.Name = "rbtL2"
        Me.rbtL2.Size = New System.Drawing.Size(38, 17)
        Me.rbtL2.TabIndex = 0
        Me.rbtL2.TabStop = True
        Me.rbtL2.Text = "L2"
        Me.rbtL2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.mPanel.SetColumnSpan(Me.Label3, 2)
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(830, 32)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "IZABERITE OPCIJE PRETRAGE "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mPanel
        '
        Me.mPanel.ColumnCount = 2
        Me.mPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.8134!))
        Me.mPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.1866!))
        Me.mPanel.Controls.Add(Me.Label3, 0, 0)
        Me.mPanel.Controls.Add(Me.mPanel2, 0, 2)
        Me.mPanel.Controls.Add(Me.TableLayoutPanel1, 1, 2)
        Me.mPanel.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.mPanel.Location = New System.Drawing.Point(13, 19)
        Me.mPanel.Name = "mPanel"
        Me.mPanel.RowCount = 3
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 169.0!))
        Me.mPanel.Size = New System.Drawing.Size(836, 267)
        Me.mPanel.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tlbABC, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.mPanel3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(386, 41)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 146.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(447, 203)
        Me.TableLayoutPanel1.TabIndex = 40
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Lavender
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.rbtL2, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.rbtSvi_lista, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.rbtL1, 0, 2)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 6
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(146, 138)
        Me.TableLayoutPanel3.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 23)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Pozitivna lista"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rbtSvi_lista
        '
        Me.rbtSvi_lista.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbtSvi_lista.AutoSize = True
        Me.rbtSvi_lista.Location = New System.Drawing.Point(3, 26)
        Me.rbtSvi_lista.Name = "rbtSvi_lista"
        Me.rbtSvi_lista.Size = New System.Drawing.Size(79, 17)
        Me.rbtSvi_lista.TabIndex = 41
        Me.rbtSvi_lista.TabStop = True
        Me.rbtSvi_lista.Text = "Svi artikli"
        Me.rbtSvi_lista.UseVisualStyleBackColor = True
        '
        'rbtL1
        '
        Me.rbtL1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbtL1.AutoSize = True
        Me.rbtL1.Location = New System.Drawing.Point(3, 49)
        Me.rbtL1.Name = "rbtL1"
        Me.rbtL1.Size = New System.Drawing.Size(38, 17)
        Me.rbtL1.TabIndex = 42
        Me.rbtL1.TabStop = True
        Me.rbtL1.Text = "L1"
        Me.rbtL1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel4, 3)
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.78685!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.21315!))
        Me.TableLayoutPanel4.Controls.Add(Me.labCount, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel4.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 157)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(441, 24)
        Me.TableLayoutPanel4.TabIndex = 38
        '
        'cntArtikli_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.mPanel)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntArtikli_search"
        Me.Size = New System.Drawing.Size(867, 309)
        Me.mPanel3.ResumeLayout(False)
        Me.mPanel3.PerformLayout()
        Me.mPanel2.ResumeLayout(False)
        Me.mPanel2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.mPanel.ResumeLayout(False)
        Me.mPanel.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rbtSvi As System.Windows.Forms.RadioButton
    Friend WithEvents dateDatumDo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateDatumOd As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbtAtivni As System.Windows.Forms.RadioButton
    Friend WithEvents labDatumOd As System.Windows.Forms.Label
    Friend WithEvents rbtAtivniPeriod As System.Windows.Forms.RadioButton
    Friend WithEvents labDatumDo As System.Windows.Forms.Label
    Friend WithEvents mPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkNaziv As System.Windows.Forms.CheckBox
    Friend WithEvents chkProizvodjac As System.Windows.Forms.CheckBox
    Friend WithEvents txtNaziv As System.Windows.Forms.TextBox
    Friend WithEvents cmbGrupa As System.Windows.Forms.ComboBox
    Friend WithEvents chkGrupa As System.Windows.Forms.CheckBox
    Friend WithEvents cmbPartner As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnPronadji As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents labCount As System.Windows.Forms.Label
    Friend WithEvents chkGenericko As System.Windows.Forms.CheckBox
    Friend WithEvents cmbGenericko As System.Windows.Forms.ComboBox
    Friend WithEvents tlbABC As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkABC As System.Windows.Forms.CheckBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbtL2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbtSvi_lista As System.Windows.Forms.RadioButton
    Friend WithEvents rbtL1 As System.Windows.Forms.RadioButton
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel

End Class
