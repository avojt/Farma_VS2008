<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntPartneri_sreach
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.mPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.chkMesto = New System.Windows.Forms.CheckBox
        Me.chkKupac = New System.Windows.Forms.CheckBox
        Me.chkAdresa = New System.Windows.Forms.CheckBox
        Me.chkDobavljac = New System.Windows.Forms.CheckBox
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel
        Me.chkABC = New System.Windows.Forms.CheckBox
        Me.btnPronadji = New System.Windows.Forms.Button
        Me.chkProizvodjac = New System.Windows.Forms.CheckBox
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.chkSifra = New System.Windows.Forms.CheckBox
        Me.cmbMesto = New System.Windows.Forms.ComboBox
        Me.txtAdresa = New System.Windows.Forms.TextBox
        Me.chkNaziv = New System.Windows.Forms.CheckBox
        Me.txtNaziv = New System.Windows.Forms.TextBox
        Me.txtSifra = New System.Windows.Forms.TextBox
        Me.chkOpstina = New System.Windows.Forms.CheckBox
        Me.cmbOpstina = New System.Windows.Forms.ComboBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.tlbABC = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.labCount = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.mPanel.SuspendLayout()
        Me.mPanel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'mPanel
        '
        Me.mPanel.ColumnCount = 2
        Me.mPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.71698!))
        Me.mPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.28302!))
        Me.mPanel.Controls.Add(Me.Label3, 0, 0)
        Me.mPanel.Controls.Add(Me.mPanel2, 0, 2)
        Me.mPanel.Controls.Add(Me.TableLayoutPanel1, 1, 2)
        Me.mPanel.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.mPanel.Location = New System.Drawing.Point(12, 14)
        Me.mPanel.Name = "mPanel"
        Me.mPanel.RowCount = 3
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.mPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 169.0!))
        Me.mPanel.Size = New System.Drawing.Size(742, 311)
        Me.mPanel.TabIndex = 1
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
        Me.Label3.Size = New System.Drawing.Size(736, 32)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "IZABERITE OPCIJE PRETRAGE "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mPanel2
        '
        Me.mPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mPanel2.ColumnCount = 2
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.mPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mPanel2.Controls.Add(Me.chkMesto, 0, 4)
        Me.mPanel2.Controls.Add(Me.chkKupac, 1, 7)
        Me.mPanel2.Controls.Add(Me.chkAdresa, 0, 2)
        Me.mPanel2.Controls.Add(Me.chkDobavljac, 1, 6)
        Me.mPanel2.Controls.Add(Me.TableLayoutPanel5, 0, 9)
        Me.mPanel2.Controls.Add(Me.chkProizvodjac, 1, 5)
        Me.mPanel2.Controls.Add(Me.TableLayoutPanel2, 0, 8)
        Me.mPanel2.Controls.Add(Me.chkSifra, 0, 0)
        Me.mPanel2.Controls.Add(Me.cmbMesto, 1, 4)
        Me.mPanel2.Controls.Add(Me.txtAdresa, 1, 2)
        Me.mPanel2.Controls.Add(Me.chkNaziv, 0, 1)
        Me.mPanel2.Controls.Add(Me.txtNaziv, 1, 1)
        Me.mPanel2.Controls.Add(Me.txtSifra, 1, 0)
        Me.mPanel2.Controls.Add(Me.chkOpstina, 0, 3)
        Me.mPanel2.Controls.Add(Me.cmbOpstina, 1, 3)
        Me.mPanel2.Location = New System.Drawing.Point(3, 41)
        Me.mPanel2.Name = "mPanel2"
        Me.mPanel2.RowCount = 11
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.mPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mPanel2.Size = New System.Drawing.Size(399, 262)
        Me.mPanel2.TabIndex = 31
        '
        'chkMesto
        '
        Me.chkMesto.AutoSize = True
        Me.chkMesto.Location = New System.Drawing.Point(3, 111)
        Me.chkMesto.Name = "chkMesto"
        Me.chkMesto.Size = New System.Drawing.Size(66, 19)
        Me.chkMesto.TabIndex = 2
        Me.chkMesto.Text = "MESTO"
        Me.chkMesto.UseVisualStyleBackColor = True
        '
        'chkKupac
        '
        Me.chkKupac.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkKupac.AutoSize = True
        Me.chkKupac.Location = New System.Drawing.Point(123, 193)
        Me.chkKupac.Name = "chkKupac"
        Me.chkKupac.Size = New System.Drawing.Size(61, 19)
        Me.chkKupac.TabIndex = 202
        Me.chkKupac.Text = "Kupac"
        Me.chkKupac.UseVisualStyleBackColor = True
        '
        'chkAdresa
        '
        Me.chkAdresa.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkAdresa.AutoSize = True
        Me.chkAdresa.Location = New System.Drawing.Point(3, 58)
        Me.chkAdresa.Name = "chkAdresa"
        Me.chkAdresa.Size = New System.Drawing.Size(74, 19)
        Me.chkAdresa.TabIndex = 35
        Me.chkAdresa.Text = "ADRESA"
        Me.chkAdresa.UseVisualStyleBackColor = True
        '
        'chkDobavljac
        '
        Me.chkDobavljac.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkDobavljac.AutoSize = True
        Me.chkDobavljac.Location = New System.Drawing.Point(123, 166)
        Me.chkDobavljac.Name = "chkDobavljac"
        Me.chkDobavljac.Size = New System.Drawing.Size(83, 19)
        Me.chkDobavljac.TabIndex = 201
        Me.chkDobavljac.Text = "Dobavljač"
        Me.chkDobavljac.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 227)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(393, 30)
        Me.TableLayoutPanel5.TabIndex = 38
        '
        'chkABC
        '
        Me.chkABC.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkABC.AutoSize = True
        Me.chkABC.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkABC.Location = New System.Drawing.Point(3, 5)
        Me.chkABC.Name = "chkABC"
        Me.chkABC.Size = New System.Drawing.Size(240, 19)
        Me.chkABC.TabIndex = 0
        Me.chkABC.Text = "Složi po abecednom redu"
        Me.chkABC.UseVisualStyleBackColor = True
        '
        'btnPronadji
        '
        Me.btnPronadji.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnPronadji.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPronadji.Location = New System.Drawing.Point(290, 3)
        Me.btnPronadji.Name = "btnPronadji"
        Me.btnPronadji.Size = New System.Drawing.Size(100, 24)
        Me.btnPronadji.TabIndex = 29
        Me.btnPronadji.Text = "PRONADJI"
        Me.btnPronadji.UseVisualStyleBackColor = True
        '
        'chkProizvodjac
        '
        Me.chkProizvodjac.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkProizvodjac.AutoSize = True
        Me.chkProizvodjac.Location = New System.Drawing.Point(123, 139)
        Me.chkProizvodjac.Name = "chkProizvodjac"
        Me.chkProizvodjac.Size = New System.Drawing.Size(92, 19)
        Me.chkProizvodjac.TabIndex = 200
        Me.chkProizvodjac.Text = "Proizvodjač"
        Me.chkProizvodjac.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.mPanel2.SetColumnSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 219)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(393, 2)
        Me.TableLayoutPanel2.TabIndex = 37
        '
        'chkSifra
        '
        Me.chkSifra.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkSifra.AutoSize = True
        Me.chkSifra.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkSifra.Location = New System.Drawing.Point(3, 4)
        Me.chkSifra.Name = "chkSifra"
        Me.chkSifra.Size = New System.Drawing.Size(61, 19)
        Me.chkSifra.TabIndex = 23
        Me.chkSifra.Text = "ŠIFRA"
        Me.chkSifra.UseVisualStyleBackColor = True
        '
        'cmbMesto
        '
        Me.cmbMesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMesto.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbMesto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbMesto.FormattingEnabled = True
        Me.cmbMesto.Location = New System.Drawing.Point(123, 111)
        Me.cmbMesto.Name = "cmbMesto"
        Me.cmbMesto.Size = New System.Drawing.Size(273, 23)
        Me.cmbMesto.TabIndex = 203
        '
        'txtAdresa
        '
        Me.txtAdresa.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAdresa.BackColor = System.Drawing.Color.GhostWhite
        Me.txtAdresa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtAdresa.Location = New System.Drawing.Point(123, 57)
        Me.txtAdresa.Name = "txtAdresa"
        Me.txtAdresa.Size = New System.Drawing.Size(273, 21)
        Me.txtAdresa.TabIndex = 198
        '
        'chkNaziv
        '
        Me.chkNaziv.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkNaziv.AutoSize = True
        Me.chkNaziv.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkNaziv.Location = New System.Drawing.Point(3, 31)
        Me.chkNaziv.Name = "chkNaziv"
        Me.chkNaziv.Size = New System.Drawing.Size(63, 19)
        Me.chkNaziv.TabIndex = 22
        Me.chkNaziv.Text = "NAZIV"
        Me.chkNaziv.UseVisualStyleBackColor = True
        '
        'txtNaziv
        '
        Me.txtNaziv.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNaziv.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNaziv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNaziv.Location = New System.Drawing.Point(123, 30)
        Me.txtNaziv.Name = "txtNaziv"
        Me.txtNaziv.Size = New System.Drawing.Size(273, 21)
        Me.txtNaziv.TabIndex = 14
        '
        'txtSifra
        '
        Me.txtSifra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSifra.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSifra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSifra.Location = New System.Drawing.Point(123, 3)
        Me.txtSifra.Name = "txtSifra"
        Me.txtSifra.Size = New System.Drawing.Size(273, 21)
        Me.txtSifra.TabIndex = 39
        '
        'chkOpstina
        '
        Me.chkOpstina.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkOpstina.AutoSize = True
        Me.chkOpstina.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chkOpstina.Location = New System.Drawing.Point(3, 85)
        Me.chkOpstina.Name = "chkOpstina"
        Me.chkOpstina.Size = New System.Drawing.Size(78, 19)
        Me.chkOpstina.TabIndex = 25
        Me.chkOpstina.Text = "OPŠTINA"
        Me.chkOpstina.UseVisualStyleBackColor = True
        '
        'cmbOpstina
        '
        Me.cmbOpstina.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbOpstina.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbOpstina.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbOpstina.FormattingEnabled = True
        Me.cmbOpstina.Location = New System.Drawing.Point(123, 84)
        Me.cmbOpstina.Name = "cmbOpstina"
        Me.cmbOpstina.Size = New System.Drawing.Size(273, 23)
        Me.cmbOpstina.TabIndex = 197
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tlbABC, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(408, 41)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(331, 262)
        Me.TableLayoutPanel1.TabIndex = 40
        '
        'tlbABC
        '
        Me.tlbABC.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tlbABC.ColumnCount = 1
        Me.TableLayoutPanel1.SetColumnSpan(Me.tlbABC, 3)
        Me.tlbABC.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlbABC.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlbABC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlbABC.Location = New System.Drawing.Point(3, 219)
        Me.tlbABC.Name = "tlbABC"
        Me.tlbABC.RowCount = 1
        Me.tlbABC.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlbABC.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlbABC.Size = New System.Drawing.Size(325, 2)
        Me.tlbABC.TabIndex = 33
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
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 227)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(325, 24)
        Me.TableLayoutPanel4.TabIndex = 38
        '
        'labCount
        '
        Me.labCount.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.labCount.AutoSize = True
        Me.labCount.Location = New System.Drawing.Point(112, 4)
        Me.labCount.Name = "labCount"
        Me.labCount.Size = New System.Drawing.Size(12, 15)
        Me.labCount.TabIndex = 34
        Me.labCount.Text = "."
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Pronadjeno je"
        '
        'cntPartneri_sreach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.mPanel)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntPartneri_sreach"
        Me.Size = New System.Drawing.Size(769, 339)
        Me.mPanel.ResumeLayout(False)
        Me.mPanel.PerformLayout()
        Me.mPanel2.ResumeLayout(False)
        Me.mPanel2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkNaziv As System.Windows.Forms.CheckBox
    Friend WithEvents txtNaziv As System.Windows.Forms.TextBox
    Friend WithEvents chkSifra As System.Windows.Forms.CheckBox
    Friend WithEvents chkOpstina As System.Windows.Forms.CheckBox
    Friend WithEvents chkAdresa As System.Windows.Forms.CheckBox
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkABC As System.Windows.Forms.CheckBox
    Friend WithEvents btnPronadji As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlbABC As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents labCount As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSifra As System.Windows.Forms.TextBox
    Friend WithEvents cmbOpstina As System.Windows.Forms.ComboBox
    Friend WithEvents txtAdresa As System.Windows.Forms.TextBox
    Friend WithEvents chkKupac As System.Windows.Forms.CheckBox
    Friend WithEvents chkDobavljac As System.Windows.Forms.CheckBox
    Friend WithEvents chkProizvodjac As System.Windows.Forms.CheckBox
    Friend WithEvents cmbMesto As System.Windows.Forms.ComboBox
    Friend WithEvents chkMesto As System.Windows.Forms.CheckBox

End Class
