<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntMagIntPrenos_add
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
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
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
        Me.lvLista = New System.Windows.Forms.ListView
        Me.cSifra_n = New System.Windows.Forms.ColumnHeader
        Me.cNaziv_n = New System.Windows.Forms.ColumnHeader
        Me.cGrupaSi_n = New System.Windows.Forms.ColumnHeader
        Me.cGrupaNa_n = New System.Windows.Forms.ColumnHeader
        Me.cJkl_n = New System.Windows.Forms.ColumnHeader
        Me.cGenericko_n = New System.Windows.Forms.ColumnHeader
        Me.cL1_n = New System.Windows.Forms.ColumnHeader
        Me.cJm_n = New System.Windows.Forms.ColumnHeader
        Me.cFOsifra = New System.Windows.Forms.ColumnHeader
        Me.cFOnaziv = New System.Windows.Forms.ColumnHeader
        Me.cProizvodjac_n = New System.Windows.Forms.ColumnHeader
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.dgStavke = New System.Windows.Forms.DataGridView
        Me.panHeader = New System.Windows.Forms.Panel
        Me.txtBroj = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbMagacin_U = New System.Windows.Forms.ComboBox
        Me.dateKalkulacija = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtIznosCena = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnNoviPartner = New System.Windows.Forms.Button
        Me.btnNoviArtkl = New System.Windows.Forms.Button
        Me.btnOsvezi = New System.Windows.Forms.Button
        Me.labProknjizen = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtOsnovica = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtIznosPdv = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtIznosZanaplatu = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtRazlikauceni = New System.Windows.Forms.TextBox
        Me.cRb = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cSifra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cNaziv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.jm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Grupa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cKol = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cCenaKostanja = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cNabVrednost = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cMarza = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cPdv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cProdCena = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cIznosPDV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cProdVred = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ID_Grupa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tlbMain.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tlbMain_sub.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgStavke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.tlbMain.Location = New System.Drawing.Point(22, 15)
        Me.tlbMain.Name = "tlbMain"
        Me.tlbMain.RowCount = 3
        Me.tlbMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tlbMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tlbMain.Size = New System.Drawing.Size(859, 653)
        Me.tlbMain.TabIndex = 130
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
        Me.btnZakljuci.Location = New System.Drawing.Point(764, 7)
        Me.btnZakljuci.Name = "btnZakljuci"
        Me.btnZakljuci.Size = New System.Drawing.Size(75, 23)
        Me.btnZakljuci.TabIndex = 2
        Me.btnZakljuci.Text = "ZAKLJUČI"
        Me.btnZakljuci.UseVisualStyleBackColor = True
        '
        'cmbMagacin
        '
        Me.cmbMagacin.FormattingEnabled = True
        Me.cmbMagacin.Location = New System.Drawing.Point(124, 7)
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
        Me.Label16.Size = New System.Drawing.Size(103, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "IZ MAGACINA"
        '
        'btnCancel
        '
        Me.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCancel.Location = New System.Drawing.Point(432, 628)
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
        Me.btnSnimi.Location = New System.Drawing.Point(351, 628)
        Me.btnSnimi.Name = "btnSnimi"
        Me.btnSnimi.Size = New System.Drawing.Size(75, 21)
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
        Me.tlbMain_sub.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 373.0!))
        Me.tlbMain_sub.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbMain_sub.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115.0!))
        Me.tlbMain_sub.Controls.Add(Me.TableLayoutPanel4, 0, 6)
        Me.tlbMain_sub.Controls.Add(Me.Panel3, 0, 5)
        Me.tlbMain_sub.Controls.Add(Me.lvLista, 0, 7)
        Me.tlbMain_sub.Controls.Add(Me.TableLayoutPanel2, 0, 4)
        Me.tlbMain_sub.Controls.Add(Me.TableLayoutPanel1, 0, 2)
        Me.tlbMain_sub.Controls.Add(Me.dgStavke, 0, 3)
        Me.tlbMain_sub.Controls.Add(Me.panHeader, 0, 0)
        Me.tlbMain_sub.Controls.Add(Me.Label7, 1, 8)
        Me.tlbMain_sub.Controls.Add(Me.txtIznosCena, 2, 8)
        Me.tlbMain_sub.Controls.Add(Me.TableLayoutPanel3, 0, 12)
        Me.tlbMain_sub.Controls.Add(Me.Panel1, 0, 1)
        Me.tlbMain_sub.Controls.Add(Me.Label11, 1, 9)
        Me.tlbMain_sub.Controls.Add(Me.txtOsnovica, 2, 9)
        Me.tlbMain_sub.Controls.Add(Me.Label9, 1, 10)
        Me.tlbMain_sub.Controls.Add(Me.txtIznosPdv, 2, 10)
        Me.tlbMain_sub.Controls.Add(Me.Label10, 1, 11)
        Me.tlbMain_sub.Controls.Add(Me.txtIznosZanaplatu, 2, 11)
        Me.tlbMain_sub.Controls.Add(Me.Label3, 0, 10)
        Me.tlbMain_sub.Controls.Add(Me.txtRazlikauceni, 0, 11)
        Me.tlbMain_sub.ForeColor = System.Drawing.Color.MidnightBlue
        Me.tlbMain_sub.Location = New System.Drawing.Point(3, 45)
        Me.tlbMain_sub.Name = "tlbMain_sub"
        Me.tlbMain_sub.RowCount = 14
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlbMain_sub.Size = New System.Drawing.Size(853, 573)
        Me.tlbMain_sub.TabIndex = 123
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.tlbMain_sub.SetColumnSpan(Me.TableLayoutPanel4, 3)
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 325)
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
        Me.Panel3.Location = New System.Drawing.Point(3, 295)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(847, 24)
        Me.Panel3.TabIndex = 174
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
        'lvLista
        '
        Me.lvLista.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvLista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvLista.AutoArrange = False
        Me.lvLista.BackColor = System.Drawing.Color.GhostWhite
        Me.lvLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cSifra_n, Me.cNaziv_n, Me.cGrupaSi_n, Me.cGrupaNa_n, Me.cJkl_n, Me.cGenericko_n, Me.cL1_n, Me.cJm_n, Me.cFOsifra, Me.cFOnaziv, Me.cProizvodjac_n})
        Me.tlbMain_sub.SetColumnSpan(Me.lvLista, 3)
        Me.lvLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lvLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lvLista.FullRowSelect = True
        Me.lvLista.GridLines = True
        Me.lvLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvLista.HideSelection = False
        Me.lvLista.LabelEdit = True
        Me.lvLista.Location = New System.Drawing.Point(3, 333)
        Me.lvLista.MultiSelect = False
        Me.lvLista.Name = "lvLista"
        Me.lvLista.Size = New System.Drawing.Size(847, 114)
        Me.lvLista.TabIndex = 124
        Me.lvLista.UseCompatibleStateImageBehavior = False
        Me.lvLista.View = System.Windows.Forms.View.Details
        '
        'cSifra_n
        '
        Me.cSifra_n.Text = "Šifra"
        Me.cSifra_n.Width = 70
        '
        'cNaziv_n
        '
        Me.cNaziv_n.Text = "Naziv"
        Me.cNaziv_n.Width = 200
        '
        'cGrupaSi_n
        '
        Me.cGrupaSi_n.Text = "Grupa - šifra"
        Me.cGrupaSi_n.Width = 90
        '
        'cGrupaNa_n
        '
        Me.cGrupaNa_n.Text = "Grupa - naziv"
        Me.cGrupaNa_n.Width = 150
        '
        'cJkl_n
        '
        Me.cJkl_n.Text = "JKL šifra"
        Me.cJkl_n.Width = 80
        '
        'cGenericko_n
        '
        Me.cGenericko_n.Text = "Gen.naziv"
        Me.cGenericko_n.Width = 100
        '
        'cL1_n
        '
        Me.cL1_n.Text = "L1"
        Me.cL1_n.Width = 40
        '
        'cJm_n
        '
        Me.cJm_n.Text = "jm"
        Me.cJm_n.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cJm_n.Width = 40
        '
        'cFOsifra
        '
        Me.cFOsifra.Text = "FO Šifra"
        '
        'cFOnaziv
        '
        Me.cFOnaziv.Text = "FO Naziv"
        Me.cFOnaziv.Width = 70
        '
        'cProizvodjac_n
        '
        Me.cProizvodjac_n.Text = "Proizvodjač"
        Me.cProizvodjac_n.Width = 200
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.tlbMain_sub.SetColumnSpan(Me.TableLayoutPanel2, 3)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 287)
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 99)
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
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgStavke.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgStavke.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cRb, Me.cSifra, Me.cNaziv, Me.jm, Me.Grupa, Me.cKol, Me.cCenaKostanja, Me.cNabVrednost, Me.cMarza, Me.cPdv, Me.cProdCena, Me.cIznosPDV, Me.cProdVred, Me.ID_Grupa})
        Me.tlbMain_sub.SetColumnSpan(Me.dgStavke, 3)
        Me.dgStavke.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgStavke.DefaultCellStyle = DataGridViewCellStyle21
        Me.dgStavke.Location = New System.Drawing.Point(3, 107)
        Me.dgStavke.MultiSelect = False
        Me.dgStavke.Name = "dgStavke"
        Me.dgStavke.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgStavke.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgStavke.RowHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.dgStavke.RowHeadersWidth = 23
        Me.dgStavke.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgStavke.Size = New System.Drawing.Size(847, 174)
        Me.dgStavke.TabIndex = 108
        '
        'panHeader
        '
        Me.panHeader.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tlbMain_sub.SetColumnSpan(Me.panHeader, 3)
        Me.panHeader.Controls.Add(Me.txtBroj)
        Me.panHeader.Controls.Add(Me.Label2)
        Me.panHeader.Controls.Add(Me.Label1)
        Me.panHeader.Controls.Add(Me.cmbMagacin_U)
        Me.panHeader.Controls.Add(Me.dateKalkulacija)
        Me.panHeader.Controls.Add(Me.Label6)
        Me.panHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panHeader.Location = New System.Drawing.Point(3, 3)
        Me.panHeader.Name = "panHeader"
        Me.panHeader.Size = New System.Drawing.Size(847, 54)
        Me.panHeader.TabIndex = 102
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
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(384, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "PRELAZI U MAGACIN"
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
        'cmbMagacin_U
        '
        Me.cmbMagacin_U.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMagacin_U.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbMagacin_U.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbMagacin_U.FormattingEnabled = True
        Me.cmbMagacin_U.Location = New System.Drawing.Point(387, 23)
        Me.cmbMagacin_U.Name = "cmbMagacin_U"
        Me.cmbMagacin_U.Size = New System.Drawing.Size(449, 21)
        Me.cmbMagacin_U.TabIndex = 13
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
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Datum dostavnice"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(690, 456)
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
        Me.txtIznosCena.Location = New System.Drawing.Point(741, 453)
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
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 557)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(847, 2)
        Me.TableLayoutPanel3.TabIndex = 172
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tlbMain_sub.SetColumnSpan(Me.Panel1, 3)
        Me.Panel1.Controls.Add(Me.btnNoviPartner)
        Me.Panel1.Controls.Add(Me.btnNoviArtkl)
        Me.Panel1.Controls.Add(Me.btnOsvezi)
        Me.Panel1.Controls.Add(Me.labProknjizen)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(847, 30)
        Me.Panel1.TabIndex = 173
        '
        'btnNoviPartner
        '
        Me.btnNoviPartner.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNoviPartner.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnNoviPartner.Location = New System.Drawing.Point(601, 3)
        Me.btnNoviPartner.Name = "btnNoviPartner"
        Me.btnNoviPartner.Size = New System.Drawing.Size(75, 23)
        Me.btnNoviPartner.TabIndex = 109
        Me.btnNoviPartner.Text = "Novi Prtner"
        Me.btnNoviPartner.UseVisualStyleBackColor = True
        '
        'btnNoviArtkl
        '
        Me.btnNoviArtkl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNoviArtkl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnNoviArtkl.Location = New System.Drawing.Point(682, 3)
        Me.btnNoviArtkl.Name = "btnNoviArtkl"
        Me.btnNoviArtkl.Size = New System.Drawing.Size(75, 23)
        Me.btnNoviArtkl.TabIndex = 108
        Me.btnNoviArtkl.Text = "Novi Artkl"
        Me.btnNoviArtkl.UseVisualStyleBackColor = True
        '
        'btnOsvezi
        '
        Me.btnOsvezi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOsvezi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnOsvezi.Location = New System.Drawing.Point(763, 3)
        Me.btnOsvezi.Name = "btnOsvezi"
        Me.btnOsvezi.Size = New System.Drawing.Size(75, 23)
        Me.btnOsvezi.TabIndex = 107
        Me.btnOsvezi.Text = "Osveži"
        Me.btnOsvezi.UseVisualStyleBackColor = True
        '
        'labProknjizen
        '
        Me.labProknjizen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labProknjizen.AutoSize = True
        Me.labProknjizen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labProknjizen.ForeColor = System.Drawing.Color.MidnightBlue
        Me.labProknjizen.Location = New System.Drawing.Point(155, 7)
        Me.labProknjizen.Name = "labProknjizen"
        Me.labProknjizen.Size = New System.Drawing.Size(398, 16)
        Me.labProknjizen.TabIndex = 22
        Me.labProknjizen.Text = "DOKUMENT JE ZAKLJUČEN. NE MOŽETE GA MENJATI."
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label11.Location = New System.Drawing.Point(658, 482)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 117
        Me.Label11.Text = "PDV Osnovica"
        '
        'txtOsnovica
        '
        Me.txtOsnovica.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtOsnovica.BackColor = System.Drawing.Color.GhostWhite
        Me.txtOsnovica.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtOsnovica.Location = New System.Drawing.Point(741, 479)
        Me.txtOsnovica.Name = "txtOsnovica"
        Me.txtOsnovica.Size = New System.Drawing.Size(100, 20)
        Me.txtOsnovica.TabIndex = 118
        Me.txtOsnovica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(706, 508)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "PDV"
        '
        'txtIznosPdv
        '
        Me.txtIznosPdv.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtIznosPdv.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIznosPdv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtIznosPdv.Location = New System.Drawing.Point(741, 505)
        Me.txtIznosPdv.Name = "txtIznosPdv"
        Me.txtIznosPdv.Size = New System.Drawing.Size(100, 20)
        Me.txtIznosPdv.TabIndex = 115
        Me.txtIznosPdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(697, 534)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "Svega"
        '
        'txtIznosZanaplatu
        '
        Me.txtIznosZanaplatu.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtIznosZanaplatu.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIznosZanaplatu.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtIznosZanaplatu.Location = New System.Drawing.Point(741, 531)
        Me.txtIznosZanaplatu.Name = "txtIznosZanaplatu"
        Me.txtIznosZanaplatu.Size = New System.Drawing.Size(100, 20)
        Me.txtIznosZanaplatu.TabIndex = 116
        Me.txtIznosZanaplatu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(296, 508)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Razlika u ceni"
        Me.Label3.Visible = False
        '
        'txtRazlikauceni
        '
        Me.txtRazlikauceni.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtRazlikauceni.BackColor = System.Drawing.Color.GhostWhite
        Me.txtRazlikauceni.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtRazlikauceni.Location = New System.Drawing.Point(3, 531)
        Me.txtRazlikauceni.Name = "txtRazlikauceni"
        Me.txtRazlikauceni.Size = New System.Drawing.Size(100, 20)
        Me.txtRazlikauceni.TabIndex = 122
        Me.txtRazlikauceni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtRazlikauceni.Visible = False
        '
        'cRb
        '
        Me.cRb.HeaderText = "Rb"
        Me.cRb.Name = "cRb"
        Me.cRb.Width = 35
        '
        'cSifra
        '
        Me.cSifra.FillWeight = 70.0!
        Me.cSifra.HeaderText = "Šifra"
        Me.cSifra.Name = "cSifra"
        Me.cSifra.ReadOnly = True
        Me.cSifra.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cSifra.Width = 60
        '
        'cNaziv
        '
        Me.cNaziv.HeaderText = "Naziv"
        Me.cNaziv.Name = "cNaziv"
        Me.cNaziv.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cNaziv.Width = 185
        '
        'jm
        '
        Me.jm.HeaderText = "JM"
        Me.jm.Name = "jm"
        Me.jm.ReadOnly = True
        Me.jm.Width = 40
        '
        'Grupa
        '
        Me.Grupa.HeaderText = "Grupa"
        Me.Grupa.Name = "Grupa"
        Me.Grupa.ReadOnly = True
        Me.Grupa.Width = 55
        '
        'cKol
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cKol.DefaultCellStyle = DataGridViewCellStyle13
        Me.cKol.HeaderText = "Kol"
        Me.cKol.Name = "cKol"
        Me.cKol.Width = 40
        '
        'cCenaKostanja
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.cCenaKostanja.DefaultCellStyle = DataGridViewCellStyle14
        Me.cCenaKostanja.HeaderText = "Nab. Cena"
        Me.cCenaKostanja.Name = "cCenaKostanja"
        Me.cCenaKostanja.Width = 85
        '
        'cNabVrednost
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N2"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.cNabVrednost.DefaultCellStyle = DataGridViewCellStyle15
        Me.cNabVrednost.HeaderText = "Nab. Vrednost"
        Me.cNabVrednost.Name = "cNabVrednost"
        Me.cNabVrednost.ReadOnly = True
        Me.cNabVrednost.Width = 90
        '
        'cMarza
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "N2"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.cMarza.DefaultCellStyle = DataGridViewCellStyle16
        Me.cMarza.HeaderText = "Marža %"
        Me.cMarza.Name = "cMarza"
        Me.cMarza.ReadOnly = True
        Me.cMarza.Visible = False
        Me.cMarza.Width = 55
        '
        'cPdv
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cPdv.DefaultCellStyle = DataGridViewCellStyle17
        Me.cPdv.HeaderText = "PDV %"
        Me.cPdv.Name = "cPdv"
        Me.cPdv.ReadOnly = True
        Me.cPdv.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cPdv.Width = 50
        '
        'cProdCena
        '
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.Format = "N2"
        DataGridViewCellStyle18.NullValue = Nothing
        Me.cProdCena.DefaultCellStyle = DataGridViewCellStyle18
        Me.cProdCena.HeaderText = "MP Cena"
        Me.cProdCena.Name = "cProdCena"
        Me.cProdCena.ReadOnly = True
        Me.cProdCena.Width = 85
        '
        'cIznosPDV
        '
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.Format = "N2"
        DataGridViewCellStyle19.NullValue = Nothing
        Me.cIznosPDV.DefaultCellStyle = DataGridViewCellStyle19
        Me.cIznosPDV.HeaderText = "Iznos PDV"
        Me.cIznosPDV.Name = "cIznosPDV"
        Me.cIznosPDV.Visible = False
        Me.cIznosPDV.Width = 90
        '
        'cProdVred
        '
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Format = "N2"
        DataGridViewCellStyle20.NullValue = Nothing
        Me.cProdVred.DefaultCellStyle = DataGridViewCellStyle20
        Me.cProdVred.HeaderText = "MP Vrednost"
        Me.cProdVred.Name = "cProdVred"
        Me.cProdVred.ReadOnly = True
        Me.cProdVred.Width = 90
        '
        'ID_Grupa
        '
        Me.ID_Grupa.HeaderText = "ID_Grupa"
        Me.ID_Grupa.Name = "ID_Grupa"
        Me.ID_Grupa.Visible = False
        '
        'cntMagIntPrenos_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.tlbMain)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntMagIntPrenos_add"
        Me.Size = New System.Drawing.Size(903, 685)
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents lvLista As System.Windows.Forms.ListView
    Friend WithEvents cSifra_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cNaziv_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cGrupaSi_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cGrupaNa_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cJkl_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cGenericko_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cL1_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cJm_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents cFOsifra As System.Windows.Forms.ColumnHeader
    Friend WithEvents cFOnaziv As System.Windows.Forms.ColumnHeader
    Friend WithEvents cProizvodjac_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgStavke As System.Windows.Forms.DataGridView
    Friend WithEvents panHeader As System.Windows.Forms.Panel
    Friend WithEvents txtBroj As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbMagacin_U As System.Windows.Forms.ComboBox
    Friend WithEvents dateKalkulacija As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtIznosCena As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNoviPartner As System.Windows.Forms.Button
    Friend WithEvents btnNoviArtkl As System.Windows.Forms.Button
    Friend WithEvents btnOsvezi As System.Windows.Forms.Button
    Friend WithEvents labProknjizen As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRazlikauceni As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtOsnovica As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtIznosPdv As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtIznosZanaplatu As System.Windows.Forms.TextBox
    Friend WithEvents cRb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSifra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNaziv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Grupa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cKol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCenaKostanja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNabVrednost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMarza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPdv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cProdCena As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cIznosPDV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cProdVred As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_Grupa As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
