<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntPartneri_edit
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
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.panHeader = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtSifra = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNaziv = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.labLager = New System.Windows.Forms.Label
        Me.chkKupac = New System.Windows.Forms.CheckBox
        Me.chkDobavljac = New System.Windows.Forms.CheckBox
        Me.chkProizvodjac = New System.Windows.Forms.CheckBox
        Me.txtDelatnost = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTekuci = New System.Windows.Forms.TextBox
        Me.txtRegistarski = New System.Windows.Forms.TextBox
        Me.txtMaticni = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPIB = New System.Windows.Forms.TextBox
        Me.txtDrzava = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbMesto = New System.Windows.Forms.ComboBox
        Me.cmbOpstina = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtAdresa = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
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
        Me.tlbMain.Location = New System.Drawing.Point(15, 15)
        Me.tlbMain.Name = "tlbMain"
        Me.tlbMain.RowCount = 2
        Me.tlbMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tlbMain.Size = New System.Drawing.Size(628, 509)
        Me.tlbMain.TabIndex = 126
        '
        'btnCancel
        '
        Me.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCancel.Location = New System.Drawing.Point(317, 484)
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
        Me.btnSnimi.Location = New System.Drawing.Point(236, 484)
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
        Me.tlbMain_sub.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126.0!))
        Me.tlbMain_sub.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380.0!))
        Me.tlbMain_sub.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbMain_sub.Controls.Add(Me.TableLayoutPanel4, 0, 14)
        Me.tlbMain_sub.Controls.Add(Me.panHeader, 0, 0)
        Me.tlbMain_sub.Controls.Add(Me.TableLayoutPanel3, 0, 16)
        Me.tlbMain_sub.Controls.Add(Me.Panel3, 0, 15)
        Me.tlbMain_sub.Controls.Add(Me.chkKupac, 1, 13)
        Me.tlbMain_sub.Controls.Add(Me.chkDobavljac, 1, 12)
        Me.tlbMain_sub.Controls.Add(Me.chkProizvodjac, 1, 11)
        Me.tlbMain_sub.Controls.Add(Me.txtDelatnost, 1, 10)
        Me.tlbMain_sub.Controls.Add(Me.Label10, 0, 10)
        Me.tlbMain_sub.Controls.Add(Me.Label9, 0, 9)
        Me.tlbMain_sub.Controls.Add(Me.Label8, 0, 8)
        Me.tlbMain_sub.Controls.Add(Me.txtTekuci, 1, 9)
        Me.tlbMain_sub.Controls.Add(Me.txtRegistarski, 1, 8)
        Me.tlbMain_sub.Controls.Add(Me.txtMaticni, 1, 7)
        Me.tlbMain_sub.Controls.Add(Me.Label7, 0, 7)
        Me.tlbMain_sub.Controls.Add(Me.Label5, 0, 6)
        Me.tlbMain_sub.Controls.Add(Me.txtPIB, 1, 6)
        Me.tlbMain_sub.Controls.Add(Me.txtDrzava, 1, 5)
        Me.tlbMain_sub.Controls.Add(Me.Label4, 0, 5)
        Me.tlbMain_sub.Controls.Add(Me.Label3, 0, 4)
        Me.tlbMain_sub.Controls.Add(Me.cmbMesto, 1, 4)
        Me.tlbMain_sub.Controls.Add(Me.cmbOpstina, 1, 3)
        Me.tlbMain_sub.Controls.Add(Me.Label6, 0, 3)
        Me.tlbMain_sub.Controls.Add(Me.Label13, 0, 2)
        Me.tlbMain_sub.Controls.Add(Me.txtAdresa, 1, 2)
        Me.tlbMain_sub.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.tlbMain_sub.ForeColor = System.Drawing.Color.MidnightBlue
        Me.tlbMain_sub.Location = New System.Drawing.Point(3, 3)
        Me.tlbMain_sub.Name = "tlbMain_sub"
        Me.tlbMain_sub.RowCount = 17
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbMain_sub.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlbMain_sub.Size = New System.Drawing.Size(622, 471)
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
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 431)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(616, 2)
        Me.TableLayoutPanel4.TabIndex = 172
        '
        'panHeader
        '
        Me.panHeader.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tlbMain_sub.SetColumnSpan(Me.panHeader, 3)
        Me.panHeader.Controls.Add(Me.Label11)
        Me.panHeader.Controls.Add(Me.txtSifra)
        Me.panHeader.Controls.Add(Me.Label2)
        Me.panHeader.Controls.Add(Me.Label1)
        Me.panHeader.Controls.Add(Me.txtNaziv)
        Me.panHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panHeader.Location = New System.Drawing.Point(3, 3)
        Me.panHeader.Name = "panHeader"
        Me.panHeader.Size = New System.Drawing.Size(616, 54)
        Me.panHeader.TabIndex = 102
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(123, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Naziv"
        '
        'txtSifra
        '
        Me.txtSifra.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSifra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSifra.Location = New System.Drawing.Point(16, 23)
        Me.txtSifra.Name = "txtSifra"
        Me.txtSifra.Size = New System.Drawing.Size(99, 20)
        Me.txtSifra.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(31, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Naziv"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Šifra"
        '
        'txtNaziv
        '
        Me.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtNaziv.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNaziv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNaziv.Location = New System.Drawing.Point(125, 24)
        Me.txtNaziv.Name = "txtNaziv"
        Me.txtNaziv.Size = New System.Drawing.Size(375, 20)
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
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 466)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(616, 2)
        Me.TableLayoutPanel3.TabIndex = 172
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tlbMain_sub.SetColumnSpan(Me.Panel3, 3)
        Me.Panel3.Controls.Add(Me.labLager)
        Me.Panel3.Location = New System.Drawing.Point(3, 439)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(616, 20)
        Me.Panel3.TabIndex = 174
        '
        'labLager
        '
        Me.labLager.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labLager.AutoSize = True
        Me.labLager.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labLager.ForeColor = System.Drawing.Color.LightSlateGray
        Me.labLager.Location = New System.Drawing.Point(-220, 4)
        Me.labLager.Name = "labLager"
        Me.labLager.Size = New System.Drawing.Size(16, 16)
        Me.labLager.TabIndex = 22
        Me.labLager.Text = ".."
        '
        'chkKupac
        '
        Me.chkKupac.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkKupac.AutoSize = True
        Me.chkKupac.Location = New System.Drawing.Point(129, 404)
        Me.chkKupac.Name = "chkKupac"
        Me.chkKupac.Size = New System.Drawing.Size(57, 17)
        Me.chkKupac.TabIndex = 195
        Me.chkKupac.Text = "Kupac"
        Me.chkKupac.UseVisualStyleBackColor = True
        '
        'chkDobavljac
        '
        Me.chkDobavljac.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkDobavljac.AutoSize = True
        Me.chkDobavljac.Location = New System.Drawing.Point(129, 374)
        Me.chkDobavljac.Name = "chkDobavljac"
        Me.chkDobavljac.Size = New System.Drawing.Size(74, 17)
        Me.chkDobavljac.TabIndex = 194
        Me.chkDobavljac.Text = "Dobavljač"
        Me.chkDobavljac.UseVisualStyleBackColor = True
        '
        'chkProizvodjac
        '
        Me.chkProizvodjac.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkProizvodjac.AutoSize = True
        Me.chkProizvodjac.Location = New System.Drawing.Point(129, 344)
        Me.chkProizvodjac.Name = "chkProizvodjac"
        Me.chkProizvodjac.Size = New System.Drawing.Size(81, 17)
        Me.chkProizvodjac.TabIndex = 193
        Me.chkProizvodjac.Text = "Proizvodjač"
        Me.chkProizvodjac.UseVisualStyleBackColor = True
        '
        'txtDelatnost
        '
        Me.txtDelatnost.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDelatnost.BackColor = System.Drawing.Color.GhostWhite
        Me.txtDelatnost.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDelatnost.Location = New System.Drawing.Point(129, 313)
        Me.txtDelatnost.Name = "txtDelatnost"
        Me.txtDelatnost.Size = New System.Drawing.Size(374, 20)
        Me.txtDelatnost.TabIndex = 192
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(71, 316)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 188
        Me.Label10.Text = "Delatnost"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(53, 286)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 185
        Me.Label9.Text = "Tekući račun"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(64, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 184
        Me.Label8.Text = "Registarski"
        '
        'txtTekuci
        '
        Me.txtTekuci.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTekuci.BackColor = System.Drawing.Color.GhostWhite
        Me.txtTekuci.Location = New System.Drawing.Point(129, 283)
        Me.txtTekuci.Name = "txtTekuci"
        Me.txtTekuci.Size = New System.Drawing.Size(374, 20)
        Me.txtTekuci.TabIndex = 187
        '
        'txtRegistarski
        '
        Me.txtRegistarski.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRegistarski.BackColor = System.Drawing.Color.GhostWhite
        Me.txtRegistarski.Location = New System.Drawing.Point(129, 253)
        Me.txtRegistarski.Name = "txtRegistarski"
        Me.txtRegistarski.Size = New System.Drawing.Size(374, 20)
        Me.txtRegistarski.TabIndex = 186
        '
        'txtMaticni
        '
        Me.txtMaticni.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMaticni.BackColor = System.Drawing.Color.GhostWhite
        Me.txtMaticni.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtMaticni.Location = New System.Drawing.Point(129, 223)
        Me.txtMaticni.Name = "txtMaticni"
        Me.txtMaticni.Size = New System.Drawing.Size(374, 20)
        Me.txtMaticni.TabIndex = 176
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(82, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 183
        Me.Label7.Text = "Matični"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 182
        Me.Label5.Text = "PIB"
        '
        'txtPIB
        '
        Me.txtPIB.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPIB.BackColor = System.Drawing.Color.GhostWhite
        Me.txtPIB.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPIB.Location = New System.Drawing.Point(129, 193)
        Me.txtPIB.Name = "txtPIB"
        Me.txtPIB.Size = New System.Drawing.Size(374, 20)
        Me.txtPIB.TabIndex = 179
        '
        'txtDrzava
        '
        Me.txtDrzava.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDrzava.BackColor = System.Drawing.Color.GhostWhite
        Me.txtDrzava.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDrzava.Location = New System.Drawing.Point(129, 163)
        Me.txtDrzava.Name = "txtDrzava"
        Me.txtDrzava.Size = New System.Drawing.Size(374, 20)
        Me.txtDrzava.TabIndex = 178
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 181
        Me.Label4.Text = "Drživa"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 180
        Me.Label3.Text = "Mesto"
        '
        'cmbMesto
        '
        Me.cmbMesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMesto.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbMesto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbMesto.FormattingEnabled = True
        Me.cmbMesto.Location = New System.Drawing.Point(129, 132)
        Me.cmbMesto.Name = "cmbMesto"
        Me.cmbMesto.Size = New System.Drawing.Size(374, 21)
        Me.cmbMesto.TabIndex = 196
        '
        'cmbOpstina
        '
        Me.cmbOpstina.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbOpstina.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbOpstina.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbOpstina.FormattingEnabled = True
        Me.cmbOpstina.Location = New System.Drawing.Point(129, 102)
        Me.cmbOpstina.Name = "cmbOpstina"
        Me.cmbOpstina.Size = New System.Drawing.Size(374, 21)
        Me.cmbOpstina.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(80, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Opština"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label13.Location = New System.Drawing.Point(83, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Adresa"
        '
        'txtAdresa
        '
        Me.txtAdresa.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAdresa.BackColor = System.Drawing.Color.GhostWhite
        Me.txtAdresa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAdresa.Location = New System.Drawing.Point(129, 73)
        Me.txtAdresa.Name = "txtAdresa"
        Me.txtAdresa.Size = New System.Drawing.Size(374, 20)
        Me.txtAdresa.TabIndex = 175
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(616, 2)
        Me.TableLayoutPanel1.TabIndex = 172
        '
        'cntPartneri_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.tlbMain)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntPartneri_edit"
        Me.Size = New System.Drawing.Size(661, 540)
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
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents labLager As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panHeader As System.Windows.Forms.Panel
    Friend WithEvents txtSifra As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbOpstina As System.Windows.Forms.ComboBox
    Friend WithEvents txtNaziv As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtAdresa As System.Windows.Forms.TextBox
    Friend WithEvents txtMaticni As System.Windows.Forms.TextBox
    Friend WithEvents txtDrzava As System.Windows.Forms.TextBox
    Friend WithEvents txtPIB As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtRegistarski As System.Windows.Forms.TextBox
    Friend WithEvents txtTekuci As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDelatnost As System.Windows.Forms.TextBox
    Friend WithEvents chkProizvodjac As System.Windows.Forms.CheckBox
    Friend WithEvents chkDobavljac As System.Windows.Forms.CheckBox
    Friend WithEvents chkKupac As System.Windows.Forms.CheckBox
    Friend WithEvents cmbMesto As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label

End Class
