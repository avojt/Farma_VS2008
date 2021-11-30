<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntMeniProizvodnja
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.panGlavni = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnProizvodnja = New System.Windows.Forms.Button
        Me.tableButtons = New System.Windows.Forms.TableLayoutPanel
        Me.panSastavnice_Kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.Label10 = New System.Windows.Forms.Label
        Me.panSastavnice_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkSastavnica_print = New System.Windows.Forms.LinkLabel
        Me.linkSastavnica_del = New System.Windows.Forms.LinkLabel
        Me.linkSastavnica_search = New System.Windows.Forms.LinkLabel
        Me.linkSastavnica_edit = New System.Windows.Forms.LinkLabel
        Me.linkSastavnica_add = New System.Windows.Forms.LinkLabel
        Me.panLab_Dn_Kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.Label3 = New System.Windows.Forms.Label
        Me.panLab_Dn_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkLabDn_del = New System.Windows.Forms.LinkLabel
        Me.linkLabDn_edit = New System.Windows.Forms.LinkLabel
        Me.linkLabDn_add = New System.Windows.Forms.LinkLabel
        Me.linkLabDn_search = New System.Windows.Forms.LinkLabel
        Me.linkLabDn_print = New System.Windows.Forms.LinkLabel
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.linkRekapLabIzrade = New System.Windows.Forms.LinkLabel
        Me.linkDnevlabIzrade = New System.Windows.Forms.LinkLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnLab_Dn = New System.Windows.Forms.Button
        Me.btnIzvestaji = New System.Windows.Forms.Button
        Me.btnNazad = New System.Windows.Forms.Button
        Me.btnSastavnice = New System.Windows.Forms.Button
        Me.panGlavni.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tableButtons.SuspendLayout()
        Me.panSastavnice_Kontejner.SuspendLayout()
        Me.panSastavnice_meni.SuspendLayout()
        Me.panLab_Dn_Kontejner.SuspendLayout()
        Me.panLab_Dn_meni.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackgroundImage = Global.Farma.My.Resources.Resources.Dossiers_Config_
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(218, 117)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'panGlavni
        '
        Me.panGlavni.ColumnCount = 2
        Me.panGlavni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.panGlavni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panGlavni.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.panGlavni.Controls.Add(Me.btnProizvodnja, 0, 0)
        Me.panGlavni.Controls.Add(Me.tableButtons, 1, 2)
        Me.panGlavni.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panGlavni.Location = New System.Drawing.Point(0, 165)
        Me.panGlavni.Name = "panGlavni"
        Me.panGlavni.RowCount = 3
        Me.panGlavni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panGlavni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.panGlavni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panGlavni.Size = New System.Drawing.Size(218, 396)
        Me.panGlavni.TabIndex = 10
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.panGlavni.SetColumnSpan(Me.TableLayoutPanel3, 2)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 33)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(200, 2)
        Me.TableLayoutPanel3.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lavender
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 2)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "O P C  I  J  E"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnProizvodnja
        '
        Me.panGlavni.SetColumnSpan(Me.btnProizvodnja, 2)
        Me.btnProizvodnja.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnProizvodnja.Location = New System.Drawing.Point(3, 3)
        Me.btnProizvodnja.Name = "btnProizvodnja"
        Me.btnProizvodnja.Size = New System.Drawing.Size(198, 23)
        Me.btnProizvodnja.TabIndex = 9
        Me.btnProizvodnja.Text = "PROIZVODNJA"
        Me.btnProizvodnja.UseVisualStyleBackColor = True
        '
        'tableButtons
        '
        Me.tableButtons.ColumnCount = 1
        Me.tableButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableButtons.Controls.Add(Me.panSastavnice_Kontejner, 0, 1)
        Me.tableButtons.Controls.Add(Me.panLab_Dn_Kontejner, 0, 3)
        Me.tableButtons.Controls.Add(Me.TableLayoutPanel2, 0, 5)
        Me.tableButtons.Controls.Add(Me.btnLab_Dn, 0, 2)
        Me.tableButtons.Controls.Add(Me.btnIzvestaji, 0, 4)
        Me.tableButtons.Controls.Add(Me.btnNazad, 0, 6)
        Me.tableButtons.Controls.Add(Me.btnSastavnice, 0, 0)
        Me.tableButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableButtons.Location = New System.Drawing.Point(18, 41)
        Me.tableButtons.Name = "tableButtons"
        Me.tableButtons.RowCount = 7
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.Size = New System.Drawing.Size(197, 352)
        Me.tableButtons.TabIndex = 5
        '
        'panSastavnice_Kontejner
        '
        Me.panSastavnice_Kontejner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panSastavnice_Kontejner.ColumnCount = 2
        Me.panSastavnice_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panSastavnice_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panSastavnice_Kontejner.Controls.Add(Me.Label10, 0, 0)
        Me.panSastavnice_Kontejner.Controls.Add(Me.panSastavnice_meni, 1, 0)
        Me.panSastavnice_Kontejner.Location = New System.Drawing.Point(3, 33)
        Me.panSastavnice_Kontejner.Name = "panSastavnice_Kontejner"
        Me.panSastavnice_Kontejner.RowCount = 1
        Me.panSastavnice_Kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panSastavnice_Kontejner.Size = New System.Drawing.Size(162, 2)
        Me.panSastavnice_Kontejner.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Lavender
        Me.Label10.Location = New System.Drawing.Point(3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 2)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "O P C  I  J  E"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panSastavnice_meni
        '
        Me.panSastavnice_meni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panSastavnice_meni.ColumnCount = 1
        Me.panSastavnice_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panSastavnice_meni.Controls.Add(Me.linkSastavnica_print, 0, 4)
        Me.panSastavnice_meni.Controls.Add(Me.linkSastavnica_del, 0, 3)
        Me.panSastavnice_meni.Controls.Add(Me.linkSastavnica_search, 0, 0)
        Me.panSastavnice_meni.Controls.Add(Me.linkSastavnica_edit, 0, 2)
        Me.panSastavnice_meni.Controls.Add(Me.linkSastavnica_add, 0, 1)
        Me.panSastavnice_meni.Location = New System.Drawing.Point(33, 3)
        Me.panSastavnice_meni.Name = "panSastavnice_meni"
        Me.panSastavnice_meni.RowCount = 5
        Me.panSastavnice_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panSastavnice_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panSastavnice_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panSastavnice_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panSastavnice_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panSastavnice_meni.Size = New System.Drawing.Size(126, 1)
        Me.panSastavnice_meni.TabIndex = 22
        '
        'linkSastavnica_print
        '
        Me.linkSastavnica_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkSastavnica_print.AutoSize = True
        Me.linkSastavnica_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkSastavnica_print.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkSastavnica_print.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkSastavnica_print.Location = New System.Drawing.Point(3, 83)
        Me.linkSastavnica_print.Name = "linkSastavnica_print"
        Me.linkSastavnica_print.Size = New System.Drawing.Size(120, 13)
        Me.linkSastavnica_print.TabIndex = 4
        Me.linkSastavnica_print.TabStop = True
        Me.linkSastavnica_print.Text = "Štampanje"
        '
        'linkSastavnica_del
        '
        Me.linkSastavnica_del.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkSastavnica_del.AutoSize = True
        Me.linkSastavnica_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkSastavnica_del.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkSastavnica_del.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkSastavnica_del.Location = New System.Drawing.Point(3, 63)
        Me.linkSastavnica_del.Name = "linkSastavnica_del"
        Me.linkSastavnica_del.Size = New System.Drawing.Size(120, 13)
        Me.linkSastavnica_del.TabIndex = 9
        Me.linkSastavnica_del.TabStop = True
        Me.linkSastavnica_del.Text = "Brisanje"
        '
        'linkSastavnica_search
        '
        Me.linkSastavnica_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkSastavnica_search.AutoSize = True
        Me.linkSastavnica_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkSastavnica_search.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkSastavnica_search.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkSastavnica_search.Location = New System.Drawing.Point(3, 3)
        Me.linkSastavnica_search.Name = "linkSastavnica_search"
        Me.linkSastavnica_search.Size = New System.Drawing.Size(120, 13)
        Me.linkSastavnica_search.TabIndex = 11
        Me.linkSastavnica_search.TabStop = True
        Me.linkSastavnica_search.Text = "Pretraga"
        '
        'linkSastavnica_edit
        '
        Me.linkSastavnica_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkSastavnica_edit.AutoSize = True
        Me.linkSastavnica_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkSastavnica_edit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkSastavnica_edit.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkSastavnica_edit.Location = New System.Drawing.Point(3, 43)
        Me.linkSastavnica_edit.Name = "linkSastavnica_edit"
        Me.linkSastavnica_edit.Size = New System.Drawing.Size(120, 13)
        Me.linkSastavnica_edit.TabIndex = 4
        Me.linkSastavnica_edit.TabStop = True
        Me.linkSastavnica_edit.Text = "Izmene"
        '
        'linkSastavnica_add
        '
        Me.linkSastavnica_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkSastavnica_add.AutoSize = True
        Me.linkSastavnica_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkSastavnica_add.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkSastavnica_add.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkSastavnica_add.Location = New System.Drawing.Point(3, 23)
        Me.linkSastavnica_add.Name = "linkSastavnica_add"
        Me.linkSastavnica_add.Size = New System.Drawing.Size(120, 13)
        Me.linkSastavnica_add.TabIndex = 11
        Me.linkSastavnica_add.TabStop = True
        Me.linkSastavnica_add.Text = "Unos"
        '
        'panLab_Dn_Kontejner
        '
        Me.panLab_Dn_Kontejner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panLab_Dn_Kontejner.ColumnCount = 2
        Me.panLab_Dn_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panLab_Dn_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panLab_Dn_Kontejner.Controls.Add(Me.Label3, 0, 0)
        Me.panLab_Dn_Kontejner.Controls.Add(Me.panLab_Dn_meni, 1, 0)
        Me.panLab_Dn_Kontejner.Location = New System.Drawing.Point(3, 71)
        Me.panLab_Dn_Kontejner.Name = "panLab_Dn_Kontejner"
        Me.panLab_Dn_Kontejner.RowCount = 1
        Me.panLab_Dn_Kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panLab_Dn_Kontejner.Size = New System.Drawing.Size(162, 106)
        Me.panLab_Dn_Kontejner.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lavender
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 106)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "O P C  I  J  E"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panLab_Dn_meni
        '
        Me.panLab_Dn_meni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panLab_Dn_meni.ColumnCount = 1
        Me.panLab_Dn_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panLab_Dn_meni.Controls.Add(Me.linkLabDn_del, 0, 3)
        Me.panLab_Dn_meni.Controls.Add(Me.linkLabDn_edit, 0, 2)
        Me.panLab_Dn_meni.Controls.Add(Me.linkLabDn_add, 0, 1)
        Me.panLab_Dn_meni.Controls.Add(Me.linkLabDn_search, 0, 0)
        Me.panLab_Dn_meni.Controls.Add(Me.linkLabDn_print, 0, 4)
        Me.panLab_Dn_meni.Location = New System.Drawing.Point(33, 3)
        Me.panLab_Dn_meni.Name = "panLab_Dn_meni"
        Me.panLab_Dn_meni.RowCount = 5
        Me.panLab_Dn_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panLab_Dn_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panLab_Dn_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panLab_Dn_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panLab_Dn_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panLab_Dn_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panLab_Dn_meni.Size = New System.Drawing.Size(126, 100)
        Me.panLab_Dn_meni.TabIndex = 22
        '
        'linkLabDn_del
        '
        Me.linkLabDn_del.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkLabDn_del.AutoSize = True
        Me.linkLabDn_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkLabDn_del.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkLabDn_del.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkLabDn_del.Location = New System.Drawing.Point(3, 63)
        Me.linkLabDn_del.Name = "linkLabDn_del"
        Me.linkLabDn_del.Size = New System.Drawing.Size(120, 13)
        Me.linkLabDn_del.TabIndex = 9
        Me.linkLabDn_del.TabStop = True
        Me.linkLabDn_del.Text = "Brisanje"
        '
        'linkLabDn_edit
        '
        Me.linkLabDn_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkLabDn_edit.AutoSize = True
        Me.linkLabDn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkLabDn_edit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkLabDn_edit.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkLabDn_edit.Location = New System.Drawing.Point(3, 43)
        Me.linkLabDn_edit.Name = "linkLabDn_edit"
        Me.linkLabDn_edit.Size = New System.Drawing.Size(120, 13)
        Me.linkLabDn_edit.TabIndex = 3
        Me.linkLabDn_edit.TabStop = True
        Me.linkLabDn_edit.Text = "Izmene"
        '
        'linkLabDn_add
        '
        Me.linkLabDn_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkLabDn_add.AutoSize = True
        Me.linkLabDn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkLabDn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.linkLabDn_add.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkLabDn_add.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkLabDn_add.Location = New System.Drawing.Point(3, 23)
        Me.linkLabDn_add.Name = "linkLabDn_add"
        Me.linkLabDn_add.Size = New System.Drawing.Size(120, 13)
        Me.linkLabDn_add.TabIndex = 2
        Me.linkLabDn_add.TabStop = True
        Me.linkLabDn_add.Text = "Unos"
        '
        'linkLabDn_search
        '
        Me.linkLabDn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkLabDn_search.AutoSize = True
        Me.linkLabDn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkLabDn_search.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkLabDn_search.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkLabDn_search.Location = New System.Drawing.Point(3, 3)
        Me.linkLabDn_search.Name = "linkLabDn_search"
        Me.linkLabDn_search.Size = New System.Drawing.Size(120, 13)
        Me.linkLabDn_search.TabIndex = 11
        Me.linkLabDn_search.TabStop = True
        Me.linkLabDn_search.Text = "Pretraga"
        '
        'linkLabDn_print
        '
        Me.linkLabDn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkLabDn_print.AutoSize = True
        Me.linkLabDn_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkLabDn_print.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkLabDn_print.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkLabDn_print.Location = New System.Drawing.Point(3, 83)
        Me.linkLabDn_print.Name = "linkLabDn_print"
        Me.linkLabDn_print.Size = New System.Drawing.Size(120, 13)
        Me.linkLabDn_print.TabIndex = 4
        Me.linkLabDn_print.TabStop = True
        Me.linkLabDn_print.Text = "Štampanje"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 213)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(191, 106)
        Me.TableLayoutPanel2.TabIndex = 29
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.linkRekapLabIzrade, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.linkDnevlabIzrade, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(33, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 5
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(126, 100)
        Me.TableLayoutPanel4.TabIndex = 23
        '
        'linkRekapLabIzrade
        '
        Me.linkRekapLabIzrade.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkRekapLabIzrade.AutoSize = True
        Me.linkRekapLabIzrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkRekapLabIzrade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.linkRekapLabIzrade.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkRekapLabIzrade.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkRekapLabIzrade.Location = New System.Drawing.Point(3, 23)
        Me.linkRekapLabIzrade.Name = "linkRekapLabIzrade"
        Me.linkRekapLabIzrade.Size = New System.Drawing.Size(120, 13)
        Me.linkRekapLabIzrade.TabIndex = 2
        Me.linkRekapLabIzrade.TabStop = True
        Me.linkRekapLabIzrade.Text = "Rekapit.Lab.Izrade"
        '
        'linkDnevlabIzrade
        '
        Me.linkDnevlabIzrade.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkDnevlabIzrade.AutoSize = True
        Me.linkDnevlabIzrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkDnevlabIzrade.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkDnevlabIzrade.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkDnevlabIzrade.Location = New System.Drawing.Point(3, 3)
        Me.linkDnevlabIzrade.Name = "linkDnevlabIzrade"
        Me.linkDnevlabIzrade.Size = New System.Drawing.Size(120, 13)
        Me.linkDnevlabIzrade.TabIndex = 11
        Me.linkDnevlabIzrade.TabStop = True
        Me.linkDnevlabIzrade.Text = "Dnevnik Lab.Izrade"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lavender
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 106)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "O P C  I  J  E"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLab_Dn
        '
        Me.btnLab_Dn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnLab_Dn.Location = New System.Drawing.Point(3, 41)
        Me.btnLab_Dn.Name = "btnLab_Dn"
        Me.btnLab_Dn.Size = New System.Drawing.Size(160, 24)
        Me.btnLab_Dn.TabIndex = 4
        Me.btnLab_Dn.Text = "LABORATORIJSKI DNEVNIK"
        Me.btnLab_Dn.UseVisualStyleBackColor = True
        '
        'btnIzvestaji
        '
        Me.btnIzvestaji.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnIzvestaji.Location = New System.Drawing.Point(3, 183)
        Me.btnIzvestaji.Name = "btnIzvestaji"
        Me.btnIzvestaji.Size = New System.Drawing.Size(160, 24)
        Me.btnIzvestaji.TabIndex = 5
        Me.btnIzvestaji.Text = "IZVEŠTAJI"
        Me.btnIzvestaji.UseVisualStyleBackColor = True
        '
        'btnNazad
        '
        Me.btnNazad.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnNazad.Location = New System.Drawing.Point(3, 325)
        Me.btnNazad.Name = "btnNazad"
        Me.btnNazad.Size = New System.Drawing.Size(162, 24)
        Me.btnNazad.TabIndex = 4
        Me.btnNazad.Text = "NAZAD"
        Me.btnNazad.UseVisualStyleBackColor = True
        '
        'btnSastavnice
        '
        Me.btnSastavnice.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSastavnice.Location = New System.Drawing.Point(3, 3)
        Me.btnSastavnice.Name = "btnSastavnice"
        Me.btnSastavnice.Size = New System.Drawing.Size(160, 24)
        Me.btnSastavnice.TabIndex = 5
        Me.btnSastavnice.Text = "SASTAVNICE"
        Me.btnSastavnice.UseVisualStyleBackColor = True
        '
        'cntMeniProizvodnja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.panGlavni)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntMeniProizvodnja"
        Me.Size = New System.Drawing.Size(218, 561)
        Me.panGlavni.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.tableButtons.ResumeLayout(False)
        Me.panSastavnice_Kontejner.ResumeLayout(False)
        Me.panSastavnice_meni.ResumeLayout(False)
        Me.panSastavnice_meni.PerformLayout()
        Me.panLab_Dn_Kontejner.ResumeLayout(False)
        Me.panLab_Dn_meni.ResumeLayout(False)
        Me.panLab_Dn_meni.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panGlavni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnProizvodnja As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tableButtons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnIzvestaji As System.Windows.Forms.Button
    Friend WithEvents panSastavnice_Kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents panSastavnice_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkSastavnica_print As System.Windows.Forms.LinkLabel
    Friend WithEvents linkSastavnica_del As System.Windows.Forms.LinkLabel
    Friend WithEvents linkSastavnica_search As System.Windows.Forms.LinkLabel
    Friend WithEvents linkSastavnica_edit As System.Windows.Forms.LinkLabel
    Friend WithEvents linkSastavnica_add As System.Windows.Forms.LinkLabel
    Friend WithEvents btnSastavnice As System.Windows.Forms.Button
    Friend WithEvents panLab_Dn_Kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents panLab_Dn_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkLabDn_del As System.Windows.Forms.LinkLabel
    Friend WithEvents linkLabDn_edit As System.Windows.Forms.LinkLabel
    Friend WithEvents linkLabDn_add As System.Windows.Forms.LinkLabel
    Friend WithEvents linkLabDn_search As System.Windows.Forms.LinkLabel
    Friend WithEvents linkLabDn_print As System.Windows.Forms.LinkLabel
    Friend WithEvents btnLab_Dn As System.Windows.Forms.Button
    Friend WithEvents btnNazad As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkRekapLabIzrade As System.Windows.Forms.LinkLabel
    Friend WithEvents linkDnevlabIzrade As System.Windows.Forms.LinkLabel

End Class
