<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntOtvorene_stavke_ispravke
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
        Me.mPanel = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel16 = New System.Windows.Forms.TableLayoutPanel
        Me.btnLevoK = New System.Windows.Forms.Button
        Me.btnDesnoK = New System.Windows.Forms.Button
        Me.TableLayoutPanel17 = New System.Windows.Forms.TableLayoutPanel
        Me.labKNaziv = New System.Windows.Forms.Label
        Me.labKonto = New System.Windows.Forms.Label
        Me.mPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.lKontoOD = New System.Windows.Forms.Label
        Me.cmbAnalitikaOD = New System.Windows.Forms.ComboBox
        Me.cmbKontoOD = New System.Windows.Forms.ComboBox
        Me.chkAnalitika = New System.Windows.Forms.CheckBox
        Me.chkKonto = New System.Windows.Forms.CheckBox
        Me.chkDatum = New System.Windows.Forms.CheckBox
        Me.datDatOD = New System.Windows.Forms.DateTimePicker
        Me.lPartnerOD = New System.Windows.Forms.Label
        Me.chkKupci = New System.Windows.Forms.CheckBox
        Me.chkDobavljaci = New System.Windows.Forms.CheckBox
        Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel
        Me.btnLevoAn = New System.Windows.Forms.Button
        Me.btnDesnoAn = New System.Windows.Forms.Button
        Me.TableLayoutPanel15 = New System.Windows.Forms.TableLayoutPanel
        Me.labPartner = New System.Windows.Forms.Label
        Me.labAnalitika = New System.Windows.Forms.Label
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel
        Me.btnDodaj = New System.Windows.Forms.Button
        Me.btnOdvezi = New System.Windows.Forms.Button
        Me.btnZavrsi = New System.Windows.Forms.Button
        Me.txtSaldo = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnPovezi = New System.Windows.Forms.Button
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.btnOK = New System.Windows.Forms.Button
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.labCount = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Spliter_tabele = New System.Windows.Forms.SplitContainer
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel
        Me.Label7 = New System.Windows.Forms.Label
        Me.lvLista_duguje = New System.Windows.Forms.ListView
        Me.cVeza = New System.Windows.Forms.ColumnHeader
        Me.cDatum = New System.Windows.Forms.ColumnHeader
        Me.cVrsta = New System.Windows.Forms.ColumnHeader
        Me.cBr = New System.Windows.Forms.ColumnHeader
        Me.cDatDok = New System.Windows.Forms.ColumnHeader
        Me.cBrDok = New System.Windows.Forms.ColumnHeader
        Me.cDuguje = New System.Windows.Forms.ColumnHeader
        Me.cId_st = New System.Windows.Forms.ColumnHeader
        Me.cId_os = New System.Windows.Forms.ColumnHeader
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel
        Me.txtSum_duguje = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel
        Me.txtSum_potrazuje = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel
        Me.Label9 = New System.Windows.Forms.Label
        Me.lvLista_potrazuje = New System.Windows.Forms.ListView
        Me.Veza = New System.Windows.Forms.ColumnHeader
        Me.Datum = New System.Windows.Forms.ColumnHeader
        Me.Vrsta = New System.Windows.Forms.ColumnHeader
        Me.Br = New System.Windows.Forms.ColumnHeader
        Me.DatDok = New System.Windows.Forms.ColumnHeader
        Me.BrDok = New System.Windows.Forms.ColumnHeader
        Me.cPotrazuje = New System.Windows.Forms.ColumnHeader
        Me.ccId_st = New System.Windows.Forms.ColumnHeader
        Me.ccId_os = New System.Windows.Forms.ColumnHeader
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel
        Me.mPanel.SuspendLayout()
        Me.TableLayoutPanel16.SuspendLayout()
        Me.TableLayoutPanel17.SuspendLayout()
        Me.mPanel2.SuspendLayout()
        Me.TableLayoutPanel14.SuspendLayout()
        Me.TableLayoutPanel15.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Spliter_tabele.Panel1.SuspendLayout()
        Me.Spliter_tabele.Panel2.SuspendLayout()
        Me.Spliter_tabele.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'mPanel
        '
        Me.mPanel.ColumnCount = 1
        Me.mPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mPanel.Controls.Add(Me.TableLayoutPanel16, 0, 6)
        Me.mPanel.Controls.Add(Me.mPanel2, 0, 2)
        Me.mPanel.Controls.Add(Me.TableLayoutPanel14, 0, 7)
        Me.mPanel.Controls.Add(Me.TableLayoutPanel13, 0, 9)
        Me.mPanel.Controls.Add(Me.TableLayoutPanel1, 0, 4)
        Me.mPanel.Controls.Add(Me.TableLayoutPanel2, 0, 3)
        Me.mPanel.Controls.Add(Me.Label3, 0, 0)
        Me.mPanel.Controls.Add(Me.Spliter_tabele, 0, 8)
        Me.mPanel.Controls.Add(Me.TableLayoutPanel12, 0, 5)
        Me.mPanel.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.mPanel.Location = New System.Drawing.Point(18, 19)
        Me.mPanel.Name = "mPanel"
        Me.mPanel.RowCount = 11
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.mPanel.Size = New System.Drawing.Size(840, 795)
        Me.mPanel.TabIndex = 52
        '
        'TableLayoutPanel16
        '
        Me.TableLayoutPanel16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel16.ColumnCount = 3
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel16.Controls.Add(Me.btnLevoK, 0, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.btnDesnoK, 2, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.TableLayoutPanel17, 1, 0)
        Me.TableLayoutPanel16.Location = New System.Drawing.Point(3, 209)
        Me.TableLayoutPanel16.Name = "TableLayoutPanel16"
        Me.TableLayoutPanel16.RowCount = 1
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel16.Size = New System.Drawing.Size(834, 30)
        Me.TableLayoutPanel16.TabIndex = 54
        '
        'btnLevoK
        '
        Me.btnLevoK.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnLevoK.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnLevoK.Location = New System.Drawing.Point(93, 3)
        Me.btnLevoK.Name = "btnLevoK"
        Me.btnLevoK.Size = New System.Drawing.Size(24, 24)
        Me.btnLevoK.TabIndex = 29
        Me.btnLevoK.Text = "<"
        Me.btnLevoK.UseVisualStyleBackColor = True
        '
        'btnDesnoK
        '
        Me.btnDesnoK.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnDesnoK.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnDesnoK.Location = New System.Drawing.Point(717, 3)
        Me.btnDesnoK.Name = "btnDesnoK"
        Me.btnDesnoK.Size = New System.Drawing.Size(24, 24)
        Me.btnDesnoK.TabIndex = 5
        Me.btnDesnoK.Text = ">"
        Me.btnDesnoK.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel17
        '
        Me.TableLayoutPanel17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel17.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel17.ColumnCount = 2
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33333!))
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.66666!))
        Me.TableLayoutPanel17.Controls.Add(Me.labKNaziv, 1, 0)
        Me.TableLayoutPanel17.Controls.Add(Me.labKonto, 0, 0)
        Me.TableLayoutPanel17.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TableLayoutPanel17.Location = New System.Drawing.Point(123, 3)
        Me.TableLayoutPanel17.Name = "TableLayoutPanel17"
        Me.TableLayoutPanel17.RowCount = 1
        Me.TableLayoutPanel17.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel17.Size = New System.Drawing.Size(588, 24)
        Me.TableLayoutPanel17.TabIndex = 38
        '
        'labKNaziv
        '
        Me.labKNaziv.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.labKNaziv.AutoSize = True
        Me.labKNaziv.Location = New System.Drawing.Point(140, 4)
        Me.labKNaziv.Name = "labKNaziv"
        Me.labKNaziv.Size = New System.Drawing.Size(12, 15)
        Me.labKNaziv.TabIndex = 34
        Me.labKNaziv.Text = "."
        '
        'labKonto
        '
        Me.labKonto.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.labKonto.AutoSize = True
        Me.labKonto.Location = New System.Drawing.Point(122, 4)
        Me.labKonto.Name = "labKonto"
        Me.labKonto.Size = New System.Drawing.Size(12, 15)
        Me.labKonto.TabIndex = 33
        Me.labKonto.Text = "."
        '
        'mPanel2
        '
        Me.mPanel2.ColumnCount = 6
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104.0!))
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208.0!))
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mPanel2.Controls.Add(Me.lKontoOD, 2, 1)
        Me.mPanel2.Controls.Add(Me.cmbAnalitikaOD, 1, 2)
        Me.mPanel2.Controls.Add(Me.cmbKontoOD, 1, 1)
        Me.mPanel2.Controls.Add(Me.chkAnalitika, 0, 2)
        Me.mPanel2.Controls.Add(Me.chkKonto, 0, 1)
        Me.mPanel2.Controls.Add(Me.chkDatum, 0, 3)
        Me.mPanel2.Controls.Add(Me.datDatOD, 1, 3)
        Me.mPanel2.Controls.Add(Me.lPartnerOD, 2, 2)
        Me.mPanel2.Controls.Add(Me.chkKupci, 1, 0)
        Me.mPanel2.Controls.Add(Me.chkDobavljaci, 4, 0)
        Me.mPanel2.Location = New System.Drawing.Point(3, 41)
        Me.mPanel2.Name = "mPanel2"
        Me.mPanel2.RowCount = 4
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.Size = New System.Drawing.Size(816, 108)
        Me.mPanel2.TabIndex = 31
        '
        'lKontoOD
        '
        Me.lKontoOD.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lKontoOD.AutoSize = True
        Me.lKontoOD.Location = New System.Drawing.Point(235, 33)
        Me.lKontoOD.Name = "lKontoOD"
        Me.lKontoOD.Size = New System.Drawing.Size(39, 15)
        Me.lKontoOD.TabIndex = 58
        Me.lKontoOD.Text = "lK_od"
        '
        'cmbAnalitikaOD
        '
        Me.cmbAnalitikaOD.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmbAnalitikaOD.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbAnalitikaOD.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbAnalitikaOD.FormattingEnabled = True
        Me.cmbAnalitikaOD.Location = New System.Drawing.Point(107, 57)
        Me.cmbAnalitikaOD.Name = "cmbAnalitikaOD"
        Me.cmbAnalitikaOD.Size = New System.Drawing.Size(119, 23)
        Me.cmbAnalitikaOD.TabIndex = 8
        '
        'cmbKontoOD
        '
        Me.cmbKontoOD.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmbKontoOD.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbKontoOD.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbKontoOD.FormattingEnabled = True
        Me.cmbKontoOD.Location = New System.Drawing.Point(107, 30)
        Me.cmbKontoOD.Name = "cmbKontoOD"
        Me.cmbKontoOD.Size = New System.Drawing.Size(119, 23)
        Me.cmbKontoOD.TabIndex = 62
        '
        'chkAnalitika
        '
        Me.chkAnalitika.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkAnalitika.AutoSize = True
        Me.chkAnalitika.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkAnalitika.Location = New System.Drawing.Point(3, 58)
        Me.chkAnalitika.Name = "chkAnalitika"
        Me.chkAnalitika.Size = New System.Drawing.Size(89, 19)
        Me.chkAnalitika.TabIndex = 25
        Me.chkAnalitika.Text = "ANALITIKA"
        Me.chkAnalitika.UseVisualStyleBackColor = True
        '
        'chkKonto
        '
        Me.chkKonto.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkKonto.AutoSize = True
        Me.chkKonto.Location = New System.Drawing.Point(3, 31)
        Me.chkKonto.Name = "chkKonto"
        Me.chkKonto.Size = New System.Drawing.Size(67, 19)
        Me.chkKonto.TabIndex = 60
        Me.chkKonto.Text = "KONTO"
        Me.chkKonto.UseVisualStyleBackColor = True
        '
        'chkDatum
        '
        Me.chkDatum.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkDatum.AutoSize = True
        Me.chkDatum.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkDatum.Location = New System.Drawing.Point(3, 85)
        Me.chkDatum.Name = "chkDatum"
        Me.chkDatum.Size = New System.Drawing.Size(67, 19)
        Me.chkDatum.TabIndex = 23
        Me.chkDatum.Text = "DATUM"
        Me.chkDatum.UseVisualStyleBackColor = True
        '
        'datDatOD
        '
        Me.datDatOD.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.datDatOD.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.datDatOD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datDatOD.Location = New System.Drawing.Point(107, 84)
        Me.datDatOD.Name = "datDatOD"
        Me.datDatOD.Size = New System.Drawing.Size(99, 21)
        Me.datDatOD.TabIndex = 39
        '
        'lPartnerOD
        '
        Me.lPartnerOD.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lPartnerOD.AutoSize = True
        Me.lPartnerOD.Location = New System.Drawing.Point(235, 60)
        Me.lPartnerOD.Name = "lPartnerOD"
        Me.lPartnerOD.Size = New System.Drawing.Size(38, 15)
        Me.lPartnerOD.TabIndex = 34
        Me.lPartnerOD.Text = "lP_od"
        '
        'chkKupci
        '
        Me.chkKupci.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkKupci.AutoSize = True
        Me.chkKupci.Location = New System.Drawing.Point(107, 4)
        Me.chkKupci.Name = "chkKupci"
        Me.chkKupci.Size = New System.Drawing.Size(63, 19)
        Me.chkKupci.TabIndex = 44
        Me.chkKupci.Text = "KUPCI"
        Me.chkKupci.UseVisualStyleBackColor = True
        '
        'chkDobavljaci
        '
        Me.chkDobavljaci.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkDobavljaci.AutoSize = True
        Me.chkDobavljaci.Location = New System.Drawing.Point(477, 4)
        Me.chkDobavljaci.Name = "chkDobavljaci"
        Me.chkDobavljaci.Size = New System.Drawing.Size(101, 19)
        Me.chkDobavljaci.TabIndex = 45
        Me.chkDobavljaci.Text = "DOBAVLJAČI"
        Me.chkDobavljaci.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel14
        '
        Me.TableLayoutPanel14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel14.ColumnCount = 3
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel14.Controls.Add(Me.btnLevoAn, 0, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.btnDesnoAn, 2, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.TableLayoutPanel15, 1, 0)
        Me.TableLayoutPanel14.Location = New System.Drawing.Point(3, 245)
        Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
        Me.TableLayoutPanel14.RowCount = 1
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel14.Size = New System.Drawing.Size(834, 30)
        Me.TableLayoutPanel14.TabIndex = 52
        '
        'btnLevoAn
        '
        Me.btnLevoAn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnLevoAn.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnLevoAn.Location = New System.Drawing.Point(93, 3)
        Me.btnLevoAn.Name = "btnLevoAn"
        Me.btnLevoAn.Size = New System.Drawing.Size(24, 24)
        Me.btnLevoAn.TabIndex = 29
        Me.btnLevoAn.Text = "<"
        Me.btnLevoAn.UseVisualStyleBackColor = True
        '
        'btnDesnoAn
        '
        Me.btnDesnoAn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnDesnoAn.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnDesnoAn.Location = New System.Drawing.Point(717, 3)
        Me.btnDesnoAn.Name = "btnDesnoAn"
        Me.btnDesnoAn.Size = New System.Drawing.Size(24, 24)
        Me.btnDesnoAn.TabIndex = 5
        Me.btnDesnoAn.Text = ">"
        Me.btnDesnoAn.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel15
        '
        Me.TableLayoutPanel15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel15.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel15.ColumnCount = 2
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.1579!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.8421!))
        Me.TableLayoutPanel15.Controls.Add(Me.labPartner, 1, 0)
        Me.TableLayoutPanel15.Controls.Add(Me.labAnalitika, 0, 0)
        Me.TableLayoutPanel15.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TableLayoutPanel15.Location = New System.Drawing.Point(123, 3)
        Me.TableLayoutPanel15.Name = "TableLayoutPanel15"
        Me.TableLayoutPanel15.RowCount = 1
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel15.Size = New System.Drawing.Size(588, 24)
        Me.TableLayoutPanel15.TabIndex = 38
        '
        'labPartner
        '
        Me.labPartner.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.labPartner.AutoSize = True
        Me.labPartner.Location = New System.Drawing.Point(80, 4)
        Me.labPartner.Name = "labPartner"
        Me.labPartner.Size = New System.Drawing.Size(12, 15)
        Me.labPartner.TabIndex = 34
        Me.labPartner.Text = "."
        '
        'labAnalitika
        '
        Me.labAnalitika.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.labAnalitika.AutoSize = True
        Me.labAnalitika.Location = New System.Drawing.Point(62, 4)
        Me.labAnalitika.Name = "labAnalitika"
        Me.labAnalitika.Size = New System.Drawing.Size(12, 15)
        Me.labAnalitika.TabIndex = 33
        Me.labAnalitika.Text = "."
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.ColumnCount = 6
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.btnDodaj, 2, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.btnOdvezi, 1, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.btnZavrsi, 3, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.txtSaldo, 5, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.Label10, 4, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.btnPovezi, 0, 0)
        Me.TableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(3, 716)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 1
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(834, 30)
        Me.TableLayoutPanel13.TabIndex = 56
        '
        'btnDodaj
        '
        Me.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnDodaj.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnDodaj.Location = New System.Drawing.Point(203, 4)
        Me.btnDodaj.Name = "btnDodaj"
        Me.btnDodaj.Size = New System.Drawing.Size(75, 23)
        Me.btnDodaj.TabIndex = 54
        Me.btnDodaj.Text = "DODAJ"
        Me.btnDodaj.UseVisualStyleBackColor = True
        '
        'btnOdvezi
        '
        Me.btnOdvezi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnOdvezi.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnOdvezi.Location = New System.Drawing.Point(103, 4)
        Me.btnOdvezi.Name = "btnOdvezi"
        Me.btnOdvezi.Size = New System.Drawing.Size(75, 23)
        Me.btnOdvezi.TabIndex = 54
        Me.btnOdvezi.Text = "ODVEŽI"
        Me.btnOdvezi.UseVisualStyleBackColor = True
        '
        'btnZavrsi
        '
        Me.btnZavrsi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnZavrsi.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnZavrsi.Location = New System.Drawing.Point(303, 4)
        Me.btnZavrsi.Name = "btnZavrsi"
        Me.btnZavrsi.Size = New System.Drawing.Size(75, 23)
        Me.btnZavrsi.TabIndex = 53
        Me.btnZavrsi.Text = "ZAVRŠI"
        Me.btnZavrsi.UseVisualStyleBackColor = True
        '
        'txtSaldo
        '
        Me.txtSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSaldo.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(737, 5)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(94, 21)
        Me.txtSaldo.TabIndex = 0
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.Location = New System.Drawing.Point(403, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(328, 16)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "∑ Saldo"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnPovezi
        '
        Me.btnPovezi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnPovezi.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPovezi.Location = New System.Drawing.Point(3, 4)
        Me.btnPovezi.Name = "btnPovezi"
        Me.btnPovezi.Size = New System.Drawing.Size(75, 23)
        Me.btnPovezi.TabIndex = 34
        Me.btnPovezi.Text = "SNIMI"
        Me.btnPovezi.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 163)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(834, 32)
        Me.TableLayoutPanel1.TabIndex = 43
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnOK.Location = New System.Drawing.Point(3, 4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(98, 24)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "PRIKAZ"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.09678!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.90322!))
        Me.TableLayoutPanel4.Controls.Add(Me.labCount, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel4.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(107, 4)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(724, 24)
        Me.TableLayoutPanel4.TabIndex = 38
        '
        'labCount
        '
        Me.labCount.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.labCount.AutoSize = True
        Me.labCount.Location = New System.Drawing.Point(271, 4)
        Me.labCount.Name = "labCount"
        Me.labCount.Size = New System.Drawing.Size(12, 15)
        Me.labCount.TabIndex = 34
        Me.labCount.Text = "."
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 15)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Izveštaj za period:"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 155)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(834, 2)
        Me.TableLayoutPanel2.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(834, 32)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "IZABERITE OPCIJE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Spliter_tabele
        '
        Me.Spliter_tabele.Location = New System.Drawing.Point(3, 281)
        Me.Spliter_tabele.Name = "Spliter_tabele"
        '
        'Spliter_tabele.Panel1
        '
        Me.Spliter_tabele.Panel1.Controls.Add(Me.TableLayoutPanel3)
        '
        'Spliter_tabele.Panel2
        '
        Me.Spliter_tabele.Panel2.Controls.Add(Me.TableLayoutPanel7)
        Me.Spliter_tabele.Size = New System.Drawing.Size(831, 397)
        Me.Spliter_tabele.SplitterDistance = 415
        Me.Spliter_tabele.SplitterWidth = 5
        Me.Spliter_tabele.TabIndex = 52
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lvLista_duguje, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel8, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(415, 397)
        Me.TableLayoutPanel3.TabIndex = 54
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.24138!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel5.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(409, 21)
        Me.TableLayoutPanel5.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(403, 15)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "DUGUJE"
        '
        'lvLista_duguje
        '
        Me.lvLista_duguje.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvLista_duguje.AutoArrange = False
        Me.lvLista_duguje.BackColor = System.Drawing.Color.GhostWhite
        Me.lvLista_duguje.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cVeza, Me.cDatum, Me.cVrsta, Me.cBr, Me.cDatDok, Me.cBrDok, Me.cDuguje, Me.cId_st, Me.cId_os})
        Me.lvLista_duguje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvLista_duguje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lvLista_duguje.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lvLista_duguje.FullRowSelect = True
        Me.lvLista_duguje.GridLines = True
        Me.lvLista_duguje.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvLista_duguje.HideSelection = False
        Me.lvLista_duguje.LabelEdit = True
        Me.lvLista_duguje.Location = New System.Drawing.Point(3, 30)
        Me.lvLista_duguje.MultiSelect = False
        Me.lvLista_duguje.Name = "lvLista_duguje"
        Me.lvLista_duguje.Size = New System.Drawing.Size(409, 321)
        Me.lvLista_duguje.TabIndex = 53
        Me.lvLista_duguje.UseCompatibleStateImageBehavior = False
        Me.lvLista_duguje.View = System.Windows.Forms.View.Details
        '
        'cVeza
        '
        Me.cVeza.Text = "Veza"
        Me.cVeza.Width = 50
        '
        'cDatum
        '
        Me.cDatum.Text = "Datum"
        Me.cDatum.Width = 70
        '
        'cVrsta
        '
        Me.cVrsta.Text = "Vrsta"
        Me.cVrsta.Width = 40
        '
        'cBr
        '
        Me.cBr.Text = "Br."
        Me.cBr.Width = 35
        '
        'cDatDok
        '
        Me.cDatDok.Text = "Dat.dok."
        '
        'cBrDok
        '
        Me.cBrDok.Text = "Br.Dok."
        Me.cBrDok.Width = 50
        '
        'cDuguje
        '
        Me.cDuguje.Text = "Duguje"
        Me.cDuguje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cDuguje.Width = 90
        '
        'cId_st
        '
        Me.cId_st.Text = "I"
        Me.cId_st.Width = 5
        '
        'cId_os
        '
        Me.cId_os.Text = "IDos"
        Me.cId_os.Width = 5
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.24138!))
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 357)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(409, 37)
        Me.TableLayoutPanel8.TabIndex = 56
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.txtSum_duguje, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(180, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(226, 31)
        Me.TableLayoutPanel6.TabIndex = 56
        '
        'txtSum_duguje
        '
        Me.txtSum_duguje.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSum_duguje.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtSum_duguje.Location = New System.Drawing.Point(105, 5)
        Me.txtSum_duguje.Name = "txtSum_duguje"
        Me.txtSum_duguje.Size = New System.Drawing.Size(118, 21)
        Me.txtSum_duguje.TabIndex = 0
        Me.txtSum_duguje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 15)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "∑ duguje"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel9, 0, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel11, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.lvLista_potrazuje, 0, 1)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 3
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(411, 397)
        Me.TableLayoutPanel7.TabIndex = 55
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel9.ColumnCount = 1
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.24138!))
        Me.TableLayoutPanel9.Controls.Add(Me.TableLayoutPanel10, 0, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 362)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(405, 32)
        Me.TableLayoutPanel9.TabIndex = 56
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel10.ColumnCount = 2
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.txtSum_potrazuje, 1, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(176, 3)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 1
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(226, 26)
        Me.TableLayoutPanel10.TabIndex = 55
        '
        'txtSum_potrazuje
        '
        Me.txtSum_potrazuje.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtSum_potrazuje.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtSum_potrazuje.Location = New System.Drawing.Point(105, 3)
        Me.txtSum_potrazuje.Name = "txtSum_potrazuje"
        Me.txtSum_potrazuje.Size = New System.Drawing.Size(118, 21)
        Me.txtSum_potrazuje.TabIndex = 0
        Me.txtSum_potrazuje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 15)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "∑ potražuje"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel11.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel11.ColumnCount = 1
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.24138!))
        Me.TableLayoutPanel11.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel11.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(405, 21)
        Me.TableLayoutPanel11.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(399, 15)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "POTRAŽUJE"
        '
        'lvLista_potrazuje
        '
        Me.lvLista_potrazuje.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvLista_potrazuje.AutoArrange = False
        Me.lvLista_potrazuje.BackColor = System.Drawing.Color.GhostWhite
        Me.lvLista_potrazuje.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Veza, Me.Datum, Me.Vrsta, Me.Br, Me.DatDok, Me.BrDok, Me.cPotrazuje, Me.ccId_st, Me.ccId_os})
        Me.lvLista_potrazuje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvLista_potrazuje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lvLista_potrazuje.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lvLista_potrazuje.FullRowSelect = True
        Me.lvLista_potrazuje.GridLines = True
        Me.lvLista_potrazuje.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvLista_potrazuje.HideSelection = False
        Me.lvLista_potrazuje.LabelEdit = True
        Me.lvLista_potrazuje.Location = New System.Drawing.Point(3, 30)
        Me.lvLista_potrazuje.MultiSelect = False
        Me.lvLista_potrazuje.Name = "lvLista_potrazuje"
        Me.lvLista_potrazuje.Size = New System.Drawing.Size(405, 326)
        Me.lvLista_potrazuje.TabIndex = 53
        Me.lvLista_potrazuje.UseCompatibleStateImageBehavior = False
        Me.lvLista_potrazuje.View = System.Windows.Forms.View.Details
        '
        'Veza
        '
        Me.Veza.Text = "Veza"
        Me.Veza.Width = 50
        '
        'Datum
        '
        Me.Datum.Text = "Datum"
        Me.Datum.Width = 70
        '
        'Vrsta
        '
        Me.Vrsta.Text = "Vrsta"
        Me.Vrsta.Width = 40
        '
        'Br
        '
        Me.Br.Text = "Br."
        Me.Br.Width = 35
        '
        'DatDok
        '
        Me.DatDok.Text = "Dat.Dok."
        '
        'BrDok
        '
        Me.BrDok.Text = "Br.Dok."
        Me.BrDok.Width = 50
        '
        'cPotrazuje
        '
        Me.cPotrazuje.Text = "Potražuje"
        Me.cPotrazuje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cPotrazuje.Width = 90
        '
        'ccId_st
        '
        Me.ccId_st.Text = "Ist"
        Me.ccId_st.Width = 5
        '
        'ccId_os
        '
        Me.ccId_os.Text = "Idos"
        Me.ccId_os.Width = 5
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel12.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel12.ColumnCount = 6
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(3, 201)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 1
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(834, 2)
        Me.TableLayoutPanel12.TabIndex = 52
        '
        'cntOtvorene_stavke_ispravke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.mPanel)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntOtvorene_stavke_ispravke"
        Me.Size = New System.Drawing.Size(884, 853)
        Me.mPanel.ResumeLayout(False)
        Me.mPanel.PerformLayout()
        Me.TableLayoutPanel16.ResumeLayout(False)
        Me.TableLayoutPanel17.ResumeLayout(False)
        Me.TableLayoutPanel17.PerformLayout()
        Me.mPanel2.ResumeLayout(False)
        Me.mPanel2.PerformLayout()
        Me.TableLayoutPanel14.ResumeLayout(False)
        Me.TableLayoutPanel15.ResumeLayout(False)
        Me.TableLayoutPanel15.PerformLayout()
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.TableLayoutPanel13.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Spliter_tabele.Panel1.ResumeLayout(False)
        Me.Spliter_tabele.Panel2.ResumeLayout(False)
        Me.Spliter_tabele.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents mPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lKontoOD As System.Windows.Forms.Label
    Friend WithEvents cmbAnalitikaOD As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKontoOD As System.Windows.Forms.ComboBox
    Friend WithEvents chkAnalitika As System.Windows.Forms.CheckBox
    Friend WithEvents chkKonto As System.Windows.Forms.CheckBox
    Friend WithEvents chkDatum As System.Windows.Forms.CheckBox
    Friend WithEvents datDatOD As System.Windows.Forms.DateTimePicker
    Friend WithEvents lPartnerOD As System.Windows.Forms.Label
    Friend WithEvents chkKupci As System.Windows.Forms.CheckBox
    Friend WithEvents chkDobavljaci As System.Windows.Forms.CheckBox
    Friend WithEvents TableLayoutPanel14 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnLevoAn As System.Windows.Forms.Button
    Friend WithEvents btnDesnoAn As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel15 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents labPartner As System.Windows.Forms.Label
    Friend WithEvents labAnalitika As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel13 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents btnPovezi As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents labCount As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Spliter_tabele As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lvLista_duguje As System.Windows.Forms.ListView
    Friend WithEvents cVeza As System.Windows.Forms.ColumnHeader
    Friend WithEvents cDatum As System.Windows.Forms.ColumnHeader
    Friend WithEvents cVrsta As System.Windows.Forms.ColumnHeader
    Friend WithEvents cBr As System.Windows.Forms.ColumnHeader
    Friend WithEvents cDatDok As System.Windows.Forms.ColumnHeader
    Friend WithEvents cBrDok As System.Windows.Forms.ColumnHeader
    Friend WithEvents cDuguje As System.Windows.Forms.ColumnHeader
    Friend WithEvents cId_st As System.Windows.Forms.ColumnHeader
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtSum_duguje As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel10 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtSum_potrazuje As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel11 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lvLista_potrazuje As System.Windows.Forms.ListView
    Friend WithEvents Veza As System.Windows.Forms.ColumnHeader
    Friend WithEvents Datum As System.Windows.Forms.ColumnHeader
    Friend WithEvents Vrsta As System.Windows.Forms.ColumnHeader
    Friend WithEvents Br As System.Windows.Forms.ColumnHeader
    Friend WithEvents DatDok As System.Windows.Forms.ColumnHeader
    Friend WithEvents BrDok As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPotrazuje As System.Windows.Forms.ColumnHeader
    Friend WithEvents ccId_st As System.Windows.Forms.ColumnHeader
    Friend WithEvents TableLayoutPanel12 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnZavrsi As System.Windows.Forms.Button
    Friend WithEvents btnDodaj As System.Windows.Forms.Button
    Friend WithEvents btnOdvezi As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel16 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnLevoK As System.Windows.Forms.Button
    Friend WithEvents btnDesnoK As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel17 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents labKNaziv As System.Windows.Forms.Label
    Friend WithEvents labKonto As System.Windows.Forms.Label
    Friend WithEvents cId_os As System.Windows.Forms.ColumnHeader
    Friend WithEvents ccId_os As System.Windows.Forms.ColumnHeader

End Class
