<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntKontniPlan_edit
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
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSnimi = New System.Windows.Forms.Button
        Me.tlbMain_sub = New System.Windows.Forms.TableLayoutPanel
        Me.txtTip = New System.Windows.Forms.TextBox
        Me.txtNivo_zatvaranja = New System.Windows.Forms.TextBox
        Me.cmbBil_Vanbil = New System.Windows.Forms.ComboBox
        Me.cmbVrsta_subanalitike = New System.Windows.Forms.ComboBox
        Me.cmbVrsta_analitike = New System.Windows.Forms.ComboBox
        Me.chkPocetno_stanje = New System.Windows.Forms.CheckBox
        Me.chkPasiviziran = New System.Windows.Forms.CheckBox
        Me.chkIspravka = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.panHeader = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtSifra = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNaziv = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.labLager = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbAkt_Pas = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtNivo_poc_stanja = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.chkDozvoljeno = New System.Windows.Forms.CheckBox
        Me.chkDevizno = New System.Windows.Forms.CheckBox
        Me.chkIma_analitiku = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.datVaziDo = New System.Windows.Forms.DateTimePicker
        Me.txtMesto_troska = New System.Windows.Forms.TextBox
        Me.cmbNivo = New System.Windows.Forms.ComboBox
        Me.tlbMain.SuspendLayout()
        Me.tlbMain_sub.SuspendLayout()
        Me.panHeader.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlbMain
        '
        Me.tlbMain.ColumnCount = 2
        Me.tlbMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlbMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlbMain.Controls.Add(Me.btnCancel, 1, 1)
        Me.tlbMain.Controls.Add(Me.btnSnimi, 0, 1)
        Me.tlbMain.Controls.Add(Me.tlbMain_sub, 0, 0)
        Me.tlbMain.Location = New System.Drawing.Point(18, 13)
        Me.tlbMain.Name = "tlbMain"
        Me.tlbMain.RowCount = 2
        Me.tlbMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlbMain.Size = New System.Drawing.Size(733, 623)
        Me.tlbMain.TabIndex = 130
        '
        'btnCancel
        '
        Me.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCancel.Location = New System.Drawing.Point(369, 594)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 24)
        Me.btnCancel.TabIndex = 160
        Me.btnCancel.Text = "OTKAŽI"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSnimi
        '
        Me.btnSnimi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSnimi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSnimi.Location = New System.Drawing.Point(276, 594)
        Me.btnSnimi.Name = "btnSnimi"
        Me.btnSnimi.Size = New System.Drawing.Size(87, 24)
        Me.btnSnimi.TabIndex = 159
        Me.btnSnimi.Text = "SNIMI"
        Me.btnSnimi.UseVisualStyleBackColor = True
        '
        'tlbMain_sub
        '
        Me.tlbMain_sub.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlbMain_sub.BackColor = System.Drawing.Color.Lavender
        Me.tlbMain_sub.ColumnCount = 3
        Me.tlbMain.SetColumnSpan(Me.tlbMain_sub, 2)
        Me.tlbMain_sub.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273.0!))
        Me.tlbMain_sub.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196.0!))
        Me.tlbMain_sub.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbMain_sub.Controls.Add(Me.txtTip, 1, 5)
        Me.tlbMain_sub.Controls.Add(Me.txtNivo_zatvaranja, 1, 12)
        Me.tlbMain_sub.Controls.Add(Me.cmbBil_Vanbil, 1, 14)
        Me.tlbMain_sub.Controls.Add(Me.cmbVrsta_subanalitike, 1, 8)
        Me.tlbMain_sub.Controls.Add(Me.cmbVrsta_analitike, 1, 7)
        Me.tlbMain_sub.Controls.Add(Me.chkPocetno_stanje, 1, 10)
        Me.tlbMain_sub.Controls.Add(Me.chkPasiviziran, 1, 17)
        Me.tlbMain_sub.Controls.Add(Me.chkIspravka, 1, 16)
        Me.tlbMain_sub.Controls.Add(Me.Label10, 0, 7)
        Me.tlbMain_sub.Controls.Add(Me.Label8, 0, 5)
        Me.tlbMain_sub.Controls.Add(Me.TableLayoutPanel4, 0, 19)
        Me.tlbMain_sub.Controls.Add(Me.panHeader, 0, 0)
        Me.tlbMain_sub.Controls.Add(Me.TableLayoutPanel3, 0, 21)
        Me.tlbMain_sub.Controls.Add(Me.Panel3, 0, 20)
        Me.tlbMain_sub.Controls.Add(Me.Label3, 0, 13)
        Me.tlbMain_sub.Controls.Add(Me.cmbAkt_Pas, 1, 13)
        Me.tlbMain_sub.Controls.Add(Me.Label6, 0, 12)
        Me.tlbMain_sub.Controls.Add(Me.Label13, 0, 11)
        Me.tlbMain_sub.Controls.Add(Me.txtNivo_poc_stanja, 1, 11)
        Me.tlbMain_sub.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.tlbMain_sub.Controls.Add(Me.Label5, 0, 14)
        Me.tlbMain_sub.Controls.Add(Me.Label12, 0, 8)
        Me.tlbMain_sub.Controls.Add(Me.Label14, 0, 9)
        Me.tlbMain_sub.Controls.Add(Me.chkDozvoljeno, 1, 3)
        Me.tlbMain_sub.Controls.Add(Me.chkDevizno, 1, 4)
        Me.tlbMain_sub.Controls.Add(Me.chkIma_analitiku, 1, 6)
        Me.tlbMain_sub.Controls.Add(Me.Label2, 0, 15)
        Me.tlbMain_sub.Controls.Add(Me.datVaziDo, 1, 15)
        Me.tlbMain_sub.Controls.Add(Me.txtMesto_troska, 1, 9)
        Me.tlbMain_sub.Controls.Add(Me.cmbNivo, 2, 12)
        Me.tlbMain_sub.ForeColor = System.Drawing.Color.MidnightBlue
        Me.tlbMain_sub.Location = New System.Drawing.Point(3, 3)
        Me.tlbMain_sub.Name = "tlbMain_sub"
        Me.tlbMain_sub.RowCount = 22
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlbMain_sub.Size = New System.Drawing.Size(727, 582)
        Me.tlbMain_sub.TabIndex = 123
        '
        'txtTip
        '
        Me.txtTip.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTip.BackColor = System.Drawing.Color.GhostWhite
        Me.txtTip.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTip.Location = New System.Drawing.Point(276, 149)
        Me.txtTip.Name = "txtTip"
        Me.txtTip.Size = New System.Drawing.Size(190, 21)
        Me.txtTip.TabIndex = 208
        '
        'txtNivo_zatvaranja
        '
        Me.txtNivo_zatvaranja.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNivo_zatvaranja.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNivo_zatvaranja.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNivo_zatvaranja.Location = New System.Drawing.Point(276, 355)
        Me.txtNivo_zatvaranja.Name = "txtNivo_zatvaranja"
        Me.txtNivo_zatvaranja.Size = New System.Drawing.Size(190, 21)
        Me.txtNivo_zatvaranja.TabIndex = 176
        '
        'cmbBil_Vanbil
        '
        Me.cmbBil_Vanbil.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbBil_Vanbil.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbBil_Vanbil.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbBil_Vanbil.FormattingEnabled = True
        Me.cmbBil_Vanbil.Location = New System.Drawing.Point(276, 415)
        Me.cmbBil_Vanbil.Name = "cmbBil_Vanbil"
        Me.cmbBil_Vanbil.Size = New System.Drawing.Size(190, 23)
        Me.cmbBil_Vanbil.TabIndex = 197
        '
        'cmbVrsta_subanalitike
        '
        Me.cmbVrsta_subanalitike.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbVrsta_subanalitike.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbVrsta_subanalitike.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbVrsta_subanalitike.FormattingEnabled = True
        Me.cmbVrsta_subanalitike.Location = New System.Drawing.Point(276, 237)
        Me.cmbVrsta_subanalitike.Name = "cmbVrsta_subanalitike"
        Me.cmbVrsta_subanalitike.Size = New System.Drawing.Size(190, 23)
        Me.cmbVrsta_subanalitike.TabIndex = 131
        '
        'cmbVrsta_analitike
        '
        Me.cmbVrsta_analitike.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbVrsta_analitike.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbVrsta_analitike.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbVrsta_analitike.FormattingEnabled = True
        Me.cmbVrsta_analitike.Location = New System.Drawing.Point(276, 207)
        Me.cmbVrsta_analitike.Name = "cmbVrsta_analitike"
        Me.cmbVrsta_analitike.Size = New System.Drawing.Size(190, 23)
        Me.cmbVrsta_analitike.TabIndex = 130
        '
        'chkPocetno_stanje
        '
        Me.chkPocetno_stanje.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkPocetno_stanje.AutoSize = True
        Me.chkPocetno_stanje.Location = New System.Drawing.Point(276, 297)
        Me.chkPocetno_stanje.Name = "chkPocetno_stanje"
        Me.chkPocetno_stanje.Size = New System.Drawing.Size(110, 19)
        Me.chkPocetno_stanje.TabIndex = 205
        Me.chkPocetno_stanje.Text = "Početno stanje"
        Me.chkPocetno_stanje.UseVisualStyleBackColor = True
        '
        'chkPasiviziran
        '
        Me.chkPasiviziran.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkPasiviziran.AutoSize = True
        Me.chkPasiviziran.Location = New System.Drawing.Point(276, 503)
        Me.chkPasiviziran.Name = "chkPasiviziran"
        Me.chkPasiviziran.Size = New System.Drawing.Size(87, 19)
        Me.chkPasiviziran.TabIndex = 204
        Me.chkPasiviziran.Text = "Pasiviziran"
        Me.chkPasiviziran.UseVisualStyleBackColor = True
        '
        'chkIspravka
        '
        Me.chkIspravka.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkIspravka.AutoSize = True
        Me.chkIspravka.Location = New System.Drawing.Point(276, 475)
        Me.chkIspravka.Name = "chkIspravka"
        Me.chkIspravka.Size = New System.Drawing.Size(112, 19)
        Me.chkIspravka.TabIndex = 203
        Me.chkIspravka.Text = "Konto ispravke"
        Me.chkIspravka.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(152, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 15)
        Me.Label10.TabIndex = 130
        Me.Label10.Text = "Vrsta analitike šifra"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(210, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 15)
        Me.Label8.TabIndex = 130
        Me.Label8.Text = "Tip konta"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.tlbMain_sub.SetColumnSpan(Me.TableLayoutPanel4, 3)
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 540)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(721, 2)
        Me.TableLayoutPanel4.TabIndex = 172
        '
        'panHeader
        '
        Me.panHeader.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tlbMain_sub.SetColumnSpan(Me.panHeader, 3)
        Me.panHeader.Controls.Add(Me.Label11)
        Me.panHeader.Controls.Add(Me.txtSifra)
        Me.panHeader.Controls.Add(Me.Label1)
        Me.panHeader.Controls.Add(Me.txtNaziv)
        Me.panHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panHeader.Location = New System.Drawing.Point(3, 3)
        Me.panHeader.Name = "panHeader"
        Me.panHeader.Size = New System.Drawing.Size(721, 64)
        Me.panHeader.TabIndex = 102
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(143, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 15)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Opis konta"
        '
        'txtSifra
        '
        Me.txtSifra.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSifra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSifra.Location = New System.Drawing.Point(19, 27)
        Me.txtSifra.Name = "txtSifra"
        Me.txtSifra.Size = New System.Drawing.Size(115, 21)
        Me.txtSifra.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Konto"
        '
        'txtNaziv
        '
        Me.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtNaziv.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNaziv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNaziv.Location = New System.Drawing.Point(146, 29)
        Me.txtNaziv.Name = "txtNaziv"
        Me.txtNaziv.Size = New System.Drawing.Size(437, 21)
        Me.txtNaziv.TabIndex = 20
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.tlbMain_sub.SetColumnSpan(Me.TableLayoutPanel3, 3)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 577)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(721, 2)
        Me.TableLayoutPanel3.TabIndex = 172
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tlbMain_sub.SetColumnSpan(Me.Panel3, 3)
        Me.Panel3.Controls.Add(Me.labLager)
        Me.Panel3.Location = New System.Drawing.Point(3, 548)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(719, 23)
        Me.Panel3.TabIndex = 174
        '
        'labLager
        '
        Me.labLager.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labLager.AutoSize = True
        Me.labLager.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labLager.ForeColor = System.Drawing.Color.LightSlateGray
        Me.labLager.Location = New System.Drawing.Point(-257, 5)
        Me.labLager.Name = "labLager"
        Me.labLager.Size = New System.Drawing.Size(16, 16)
        Me.labLager.TabIndex = 22
        Me.labLager.Text = ".."
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(185, 388)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 15)
        Me.Label3.TabIndex = 180
        Me.Label3.Text = "Aktiva/Pasiva"
        '
        'cmbAkt_Pas
        '
        Me.cmbAkt_Pas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbAkt_Pas.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbAkt_Pas.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbAkt_Pas.FormattingEnabled = True
        Me.cmbAkt_Pas.Location = New System.Drawing.Point(276, 385)
        Me.cmbAkt_Pas.Name = "cmbAkt_Pas"
        Me.cmbAkt_Pas.Size = New System.Drawing.Size(190, 23)
        Me.cmbAkt_Pas.TabIndex = 196
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(173, 358)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Nivo zatvaranja"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label13.Location = New System.Drawing.Point(143, 328)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 15)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Nivo početnog stanja"
        '
        'txtNivo_poc_stanja
        '
        Me.txtNivo_poc_stanja.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNivo_poc_stanja.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNivo_poc_stanja.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNivo_poc_stanja.Location = New System.Drawing.Point(276, 325)
        Me.txtNivo_poc_stanja.Name = "txtNivo_poc_stanja"
        Me.txtNivo_poc_stanja.Size = New System.Drawing.Size(190, 21)
        Me.txtNivo_poc_stanja.TabIndex = 175
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.tlbMain_sub.SetColumnSpan(Me.TableLayoutPanel1, 3)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 73)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(721, 2)
        Me.TableLayoutPanel1.TabIndex = 172
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(141, 418)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 15)
        Me.Label5.TabIndex = 182
        Me.Label5.Text = "Bilansno/Vanbilansno"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label12.Location = New System.Drawing.Point(132, 240)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(138, 15)
        Me.Label12.TabIndex = 197
        Me.Label12.Text = "Vrsta subanalitike šifra"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label14.Location = New System.Drawing.Point(125, 270)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(145, 15)
        Me.Label14.TabIndex = 198
        Me.Label14.Text = "Vrsta mesta troška šifra"
        '
        'chkDozvoljeno
        '
        Me.chkDozvoljeno.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkDozvoljeno.AutoSize = True
        Me.chkDozvoljeno.Location = New System.Drawing.Point(276, 93)
        Me.chkDozvoljeno.Name = "chkDozvoljeno"
        Me.chkDozvoljeno.Size = New System.Drawing.Size(146, 19)
        Me.chkDozvoljeno.TabIndex = 200
        Me.chkDozvoljeno.Text = "Dozvoljeno knjiženje"
        Me.chkDozvoljeno.UseVisualStyleBackColor = True
        '
        'chkDevizno
        '
        Me.chkDevizno.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkDevizno.AutoSize = True
        Me.chkDevizno.Location = New System.Drawing.Point(276, 121)
        Me.chkDevizno.Name = "chkDevizno"
        Me.chkDevizno.Size = New System.Drawing.Size(128, 19)
        Me.chkDevizno.TabIndex = 201
        Me.chkDevizno.Text = "Devizno knjiženje"
        Me.chkDevizno.UseVisualStyleBackColor = True
        '
        'chkIma_analitiku
        '
        Me.chkIma_analitiku.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkIma_analitiku.AutoSize = True
        Me.chkIma_analitiku.Location = New System.Drawing.Point(276, 179)
        Me.chkIma_analitiku.Name = "chkIma_analitiku"
        Me.chkIma_analitiku.Size = New System.Drawing.Size(101, 19)
        Me.chkIma_analitiku.TabIndex = 202
        Me.chkIma_analitiku.Text = "Ima analitiku"
        Me.chkIma_analitiku.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(219, 448)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Važi Do"
        '
        'datVaziDo
        '
        Me.datVaziDo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.datVaziDo.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.datVaziDo.Location = New System.Drawing.Point(276, 445)
        Me.datVaziDo.Name = "datVaziDo"
        Me.datVaziDo.Size = New System.Drawing.Size(146, 21)
        Me.datVaziDo.TabIndex = 206
        '
        'txtMesto_troska
        '
        Me.txtMesto_troska.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMesto_troska.BackColor = System.Drawing.Color.GhostWhite
        Me.txtMesto_troska.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMesto_troska.Location = New System.Drawing.Point(276, 267)
        Me.txtMesto_troska.Name = "txtMesto_troska"
        Me.txtMesto_troska.Size = New System.Drawing.Size(190, 21)
        Me.txtMesto_troska.TabIndex = 207
        '
        'cmbNivo
        '
        Me.cmbNivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNivo.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbNivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbNivo.FormattingEnabled = True
        Me.cmbNivo.Location = New System.Drawing.Point(472, 355)
        Me.cmbNivo.Name = "cmbNivo"
        Me.cmbNivo.Size = New System.Drawing.Size(252, 23)
        Me.cmbNivo.TabIndex = 13
        Me.cmbNivo.Visible = False
        '
        'cntKontniPlan_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.tlbMain)
        Me.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntKontniPlan_edit"
        Me.Size = New System.Drawing.Size(783, 657)
        Me.tlbMain.ResumeLayout(False)
        Me.tlbMain_sub.ResumeLayout(False)
        Me.tlbMain_sub.PerformLayout()
        Me.panHeader.ResumeLayout(False)
        Me.panHeader.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlbMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSnimi As System.Windows.Forms.Button
    Friend WithEvents tlbMain_sub As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtTip As System.Windows.Forms.TextBox
    Friend WithEvents txtNivo_zatvaranja As System.Windows.Forms.TextBox
    Friend WithEvents cmbBil_Vanbil As System.Windows.Forms.ComboBox
    Friend WithEvents cmbVrsta_subanalitike As System.Windows.Forms.ComboBox
    Friend WithEvents cmbVrsta_analitike As System.Windows.Forms.ComboBox
    Friend WithEvents chkPocetno_stanje As System.Windows.Forms.CheckBox
    Friend WithEvents chkPasiviziran As System.Windows.Forms.CheckBox
    Friend WithEvents chkIspravka As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panHeader As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSifra As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNaziv As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents labLager As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbAkt_Pas As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtNivo_poc_stanja As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chkDozvoljeno As System.Windows.Forms.CheckBox
    Friend WithEvents chkDevizno As System.Windows.Forms.CheckBox
    Friend WithEvents chkIma_analitiku As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents datVaziDo As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtMesto_troska As System.Windows.Forms.TextBox
    Friend WithEvents cmbNivo As System.Windows.Forms.ComboBox

End Class
