<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntPopis_edit
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.tlbMain = New System.Windows.Forms.TableLayoutPanel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnZakljuci = New System.Windows.Forms.Button
        Me.cmbMagacin = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSnimi = New System.Windows.Forms.Button
        Me.tlbMain_sub = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.labLager = New System.Windows.Forms.Label
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.dgStavke = New System.Windows.Forms.DataGridView
        Me.cRb = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cSifra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.jkl = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cNaziv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cNabVrednost = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.kol_magacin = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cCenaKostanja = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Vrednost = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.panHeader = New System.Windows.Forms.Panel
        Me.labProknjizen = New System.Windows.Forms.Label
        Me.btnOsvezi = New System.Windows.Forms.Button
        Me.btnNoviArtkl = New System.Windows.Forms.Button
        Me.txtBroj = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dateKalkulacija = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtIznosCena = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.tlbMain.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tlbMain_sub.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgStavke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlbMain
        '
        Me.tlbMain.ColumnCount = 2
        Me.tlbMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlbMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlbMain.Controls.Add(Me.Panel2, 0, 0)
        Me.tlbMain.Controls.Add(Me.btnCancel, 1, 2)
        Me.tlbMain.Controls.Add(Me.btnSnimi, 0, 2)
        Me.tlbMain.Controls.Add(Me.tlbMain_sub, 0, 1)
        Me.tlbMain.Location = New System.Drawing.Point(10, 10)
        Me.tlbMain.Name = "tlbMain"
        Me.tlbMain.RowCount = 3
        Me.tlbMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tlbMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tlbMain.Size = New System.Drawing.Size(859, 539)
        Me.tlbMain.TabIndex = 127
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlbMain.SetColumnSpan(Me.Panel2, 2)
        Me.Panel2.Controls.Add(Me.btnZakljuci)
        Me.Panel2.Controls.Add(Me.cmbMagacin)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(853, 36)
        Me.Panel2.TabIndex = 173
        '
        'btnZakljuci
        '
        Me.btnZakljuci.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnZakljuci.Location = New System.Drawing.Point(764, 5)
        Me.btnZakljuci.Name = "btnZakljuci"
        Me.btnZakljuci.Size = New System.Drawing.Size(75, 23)
        Me.btnZakljuci.TabIndex = 3
        Me.btnZakljuci.Text = "ZAKLJUČI"
        Me.btnZakljuci.UseVisualStyleBackColor = True
        '
        'cmbMagacin
        '
        Me.cmbMagacin.FormattingEnabled = True
        Me.cmbMagacin.Location = New System.Drawing.Point(92, 7)
        Me.cmbMagacin.Name = "cmbMagacin"
        Me.cmbMagacin.Size = New System.Drawing.Size(449, 21)
        Me.cmbMagacin.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(15, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "MAGACIN"
        '
        'btnCancel
        '
        Me.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCancel.Location = New System.Drawing.Point(432, 514)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 21)
        Me.btnCancel.TabIndex = 160
        Me.btnCancel.Text = "OTKAŽI"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSnimi
        '
        Me.btnSnimi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSnimi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSnimi.Location = New System.Drawing.Point(351, 514)
        Me.btnSnimi.Name = "btnSnimi"
        Me.btnSnimi.Size = New System.Drawing.Size(75, 21)
        Me.btnSnimi.TabIndex = 159
        Me.btnSnimi.Text = "SNIMI"
        Me.btnSnimi.UseVisualStyleBackColor = True
        '
        'tlbMain_sub
        '
        Me.tlbMain_sub.BackColor = System.Drawing.Color.Lavender
        Me.tlbMain_sub.ColumnCount = 3
        Me.tlbMain.SetColumnSpan(Me.tlbMain_sub, 2)
        Me.tlbMain_sub.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 373.0!))
        Me.tlbMain_sub.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbMain_sub.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115.0!))
        Me.tlbMain_sub.Controls.Add(Me.TableLayoutPanel4, 0, 5)
        Me.tlbMain_sub.Controls.Add(Me.Panel3, 0, 4)
        Me.tlbMain_sub.Controls.Add(Me.TableLayoutPanel2, 0, 3)
        Me.tlbMain_sub.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.tlbMain_sub.Controls.Add(Me.dgStavke, 0, 2)
        Me.tlbMain_sub.Controls.Add(Me.panHeader, 0, 0)
        Me.tlbMain_sub.Controls.Add(Me.Label7, 1, 6)
        Me.tlbMain_sub.Controls.Add(Me.txtIznosCena, 2, 6)
        Me.tlbMain_sub.Controls.Add(Me.TableLayoutPanel3, 0, 7)
        Me.tlbMain_sub.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbMain_sub.ForeColor = System.Drawing.Color.MidnightBlue
        Me.tlbMain_sub.Location = New System.Drawing.Point(3, 45)
        Me.tlbMain_sub.Name = "tlbMain_sub"
        Me.tlbMain_sub.RowCount = 9
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbMain_sub.Size = New System.Drawing.Size(853, 451)
        Me.tlbMain_sub.TabIndex = 123
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.tlbMain_sub.SetColumnSpan(Me.TableLayoutPanel4, 3)
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 389)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(847, 2)
        Me.TableLayoutPanel4.TabIndex = 172
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tlbMain_sub.SetColumnSpan(Me.Panel3, 3)
        Me.Panel3.Controls.Add(Me.labLager)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 359)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(847, 24)
        Me.Panel3.TabIndex = 175
        '
        'labLager
        '
        Me.labLager.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labLager.AutoSize = True
        Me.labLager.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labLager.ForeColor = System.Drawing.Color.LightSlateGray
        Me.labLager.Location = New System.Drawing.Point(11, 4)
        Me.labLager.Name = "labLager"
        Me.labLager.Size = New System.Drawing.Size(16, 16)
        Me.labLager.TabIndex = 22
        Me.labLager.Text = ".."
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.tlbMain_sub.SetColumnSpan(Me.TableLayoutPanel2, 3)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 351)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(847, 2)
        Me.TableLayoutPanel2.TabIndex = 171
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.tlbMain_sub.SetColumnSpan(Me.TableLayoutPanel1, 3)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 63)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(847, 2)
        Me.TableLayoutPanel1.TabIndex = 172
        '
        'dgStavke
        '
        Me.dgStavke.AllowUserToResizeColumns = False
        Me.dgStavke.AllowUserToResizeRows = False
        Me.dgStavke.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgStavke.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.dgStavke.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgStavke.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgStavke.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgStavke.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cRb, Me.cSifra, Me.jkl, Me.cNaziv, Me.JM, Me.cNabVrednost, Me.kol_magacin, Me.cCenaKostanja, Me.Vrednost})
        Me.tlbMain_sub.SetColumnSpan(Me.dgStavke, 3)
        Me.dgStavke.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgStavke.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgStavke.Location = New System.Drawing.Point(3, 71)
        Me.dgStavke.MultiSelect = False
        Me.dgStavke.Name = "dgStavke"
        Me.dgStavke.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgStavke.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgStavke.RowHeadersWidth = 23
        Me.dgStavke.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgStavke.Size = New System.Drawing.Size(847, 274)
        Me.dgStavke.TabIndex = 108
        '
        'cRb
        '
        Me.cRb.HeaderText = "Rb"
        Me.cRb.Name = "cRb"
        Me.cRb.Width = 55
        '
        'cSifra
        '
        Me.cSifra.FillWeight = 70.0!
        Me.cSifra.HeaderText = "Šifra"
        Me.cSifra.Name = "cSifra"
        Me.cSifra.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cSifra.Width = 60
        '
        'jkl
        '
        Me.jkl.HeaderText = "JKL"
        Me.jkl.Name = "jkl"
        Me.jkl.Width = 80
        '
        'cNaziv
        '
        Me.cNaziv.HeaderText = "Naziv"
        Me.cNaziv.Name = "cNaziv"
        Me.cNaziv.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cNaziv.Width = 265
        '
        'JM
        '
        Me.JM.HeaderText = "JM"
        Me.JM.Name = "JM"
        Me.JM.Width = 40
        '
        'cNabVrednost
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.cNabVrednost.DefaultCellStyle = DataGridViewCellStyle2
        Me.cNabVrednost.HeaderText = "Kol. po popisu"
        Me.cNabVrednost.Name = "cNabVrednost"
        '
        'kol_magacin
        '
        Me.kol_magacin.HeaderText = "kol.magacin"
        Me.kol_magacin.Name = "kol_magacin"
        Me.kol_magacin.Visible = False
        '
        'cCenaKostanja
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.cCenaKostanja.DefaultCellStyle = DataGridViewCellStyle3
        Me.cCenaKostanja.HeaderText = "Cena po popisu"
        Me.cCenaKostanja.Name = "cCenaKostanja"
        '
        'Vrednost
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.Vrednost.DefaultCellStyle = DataGridViewCellStyle4
        Me.Vrednost.HeaderText = "Vred. po popisu"
        Me.Vrednost.Name = "Vrednost"
        Me.Vrednost.Width = 120
        '
        'panHeader
        '
        Me.panHeader.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tlbMain_sub.SetColumnSpan(Me.panHeader, 3)
        Me.panHeader.Controls.Add(Me.labProknjizen)
        Me.panHeader.Controls.Add(Me.btnOsvezi)
        Me.panHeader.Controls.Add(Me.btnNoviArtkl)
        Me.panHeader.Controls.Add(Me.txtBroj)
        Me.panHeader.Controls.Add(Me.Label1)
        Me.panHeader.Controls.Add(Me.dateKalkulacija)
        Me.panHeader.Controls.Add(Me.Label6)
        Me.panHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panHeader.Location = New System.Drawing.Point(3, 3)
        Me.panHeader.Name = "panHeader"
        Me.panHeader.Size = New System.Drawing.Size(847, 54)
        Me.panHeader.TabIndex = 102
        '
        'labProknjizen
        '
        Me.labProknjizen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labProknjizen.AutoSize = True
        Me.labProknjizen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labProknjizen.ForeColor = System.Drawing.Color.MidnightBlue
        Me.labProknjizen.Location = New System.Drawing.Point(216, 24)
        Me.labProknjizen.Name = "labProknjizen"
        Me.labProknjizen.Size = New System.Drawing.Size(398, 16)
        Me.labProknjizen.TabIndex = 128
        Me.labProknjizen.Text = "DOKUMENT JE ZAKLJUČEN. NE MOŽETE GA MENJATI."
        Me.labProknjizen.Visible = False
        '
        'btnOsvezi
        '
        Me.btnOsvezi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOsvezi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnOsvezi.Location = New System.Drawing.Point(763, 21)
        Me.btnOsvezi.Name = "btnOsvezi"
        Me.btnOsvezi.Size = New System.Drawing.Size(75, 23)
        Me.btnOsvezi.TabIndex = 107
        Me.btnOsvezi.Text = "Osveži"
        Me.btnOsvezi.UseVisualStyleBackColor = True
        '
        'btnNoviArtkl
        '
        Me.btnNoviArtkl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNoviArtkl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnNoviArtkl.Location = New System.Drawing.Point(677, 21)
        Me.btnNoviArtkl.Name = "btnNoviArtkl"
        Me.btnNoviArtkl.Size = New System.Drawing.Size(75, 23)
        Me.btnNoviArtkl.TabIndex = 108
        Me.btnNoviArtkl.Text = "Novi Artkl"
        Me.btnNoviArtkl.UseVisualStyleBackColor = True
        '
        'txtBroj
        '
        Me.txtBroj.BackColor = System.Drawing.Color.GhostWhite
        Me.txtBroj.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBroj.Location = New System.Drawing.Point(15, 24)
        Me.txtBroj.Name = "txtBroj"
        Me.txtBroj.Size = New System.Drawing.Size(54, 20)
        Me.txtBroj.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Broj"
        '
        'dateKalkulacija
        '
        Me.dateKalkulacija.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.dateKalkulacija.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.dateKalkulacija.CalendarTitleForeColor = System.Drawing.Color.GhostWhite
        Me.dateKalkulacija.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateKalkulacija.Location = New System.Drawing.Point(75, 24)
        Me.dateKalkulacija.Name = "dateKalkulacija"
        Me.dateKalkulacija.Size = New System.Drawing.Size(90, 20)
        Me.dateKalkulacija.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(72, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Datum popisa"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(690, 402)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "Ukupno"
        '
        'txtIznosCena
        '
        Me.txtIznosCena.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtIznosCena.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIznosCena.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtIznosCena.Location = New System.Drawing.Point(741, 399)
        Me.txtIznosCena.Name = "txtIznosCena"
        Me.txtIznosCena.Size = New System.Drawing.Size(100, 20)
        Me.txtIznosCena.TabIndex = 113
        Me.txtIznosCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.tlbMain_sub.SetColumnSpan(Me.TableLayoutPanel3, 3)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 427)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(847, 2)
        Me.TableLayoutPanel3.TabIndex = 172
        '
        'cntPopis_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.tlbMain)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntPopis_edit"
        Me.Size = New System.Drawing.Size(891, 564)
        Me.tlbMain.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tlbMain_sub.ResumeLayout(False)
        Me.tlbMain_sub.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgStavke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panHeader.ResumeLayout(False)
        Me.panHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlbMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnZakljuci As System.Windows.Forms.Button
    Friend WithEvents cmbMagacin As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSnimi As System.Windows.Forms.Button
    Friend WithEvents tlbMain_sub As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents labLager As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgStavke As System.Windows.Forms.DataGridView
    Friend WithEvents cRb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSifra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jkl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNaziv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNabVrednost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kol_magacin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCenaKostanja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vrednost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents panHeader As System.Windows.Forms.Panel
    Friend WithEvents btnOsvezi As System.Windows.Forms.Button
    Friend WithEvents btnNoviArtkl As System.Windows.Forms.Button
    Friend WithEvents txtBroj As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dateKalkulacija As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtIznosCena As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents labProknjizen As System.Windows.Forms.Label

End Class
