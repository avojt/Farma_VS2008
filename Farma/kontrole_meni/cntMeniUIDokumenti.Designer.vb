<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntMeniUIDokumenti
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
        Me.tableButtons = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.pan = New System.Windows.Forms.TableLayoutPanel
        Me.Label9 = New System.Windows.Forms.Label
        Me.tableButtons_podmeni = New System.Windows.Forms.TableLayoutPanel
        Me.btnIzvestaji = New System.Windows.Forms.Button
        Me.panDnProm_Kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.Label10 = New System.Windows.Forms.Label
        Me.panDnProm_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkDPromet_search = New System.Windows.Forms.LinkLabel
        Me.linkDPromet_print = New System.Windows.Forms.LinkLabel
        Me.btnUlaz = New System.Windows.Forms.Button
        Me.panPovracajRobe_Kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.panPovracajRobe_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkPovracajRobe_edit = New System.Windows.Forms.LinkLabel
        Me.linkPovracajRobe_add = New System.Windows.Forms.LinkLabel
        Me.linkPovracajRobe_print = New System.Windows.Forms.LinkLabel
        Me.linkPovracajRobe_del = New System.Windows.Forms.LinkLabel
        Me.linkPovracajRobe_search = New System.Windows.Forms.LinkLabel
        Me.Label8 = New System.Windows.Forms.Label
        Me.panKalk_Kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.Label3 = New System.Windows.Forms.Label
        Me.panKalk_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkKalk_del = New System.Windows.Forms.LinkLabel
        Me.linkKalk_edit = New System.Windows.Forms.LinkLabel
        Me.linkKalk_add = New System.Windows.Forms.LinkLabel
        Me.linkKalk_search = New System.Windows.Forms.LinkLabel
        Me.linkKalk_print = New System.Windows.Forms.LinkLabel
        Me.btnIzlaz = New System.Windows.Forms.Button
        Me.btnOstalo = New System.Windows.Forms.Button
        Me.btnObrada = New System.Windows.Forms.Button
        Me.btnNazad = New System.Windows.Forms.Button
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.tableButtons.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.pan.SuspendLayout()
        Me.tableButtons_podmeni.SuspendLayout()
        Me.panDnProm_Kontejner.SuspendLayout()
        Me.panDnProm_meni.SuspendLayout()
        Me.panPovracajRobe_Kontejner.SuspendLayout()
        Me.panPovracajRobe_meni.SuspendLayout()
        Me.panKalk_Kontejner.SuspendLayout()
        Me.panKalk_meni.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableButtons
        '
        Me.tableButtons.ColumnCount = 2
        Me.tableButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableButtons.Controls.Add(Me.TableLayoutPanel2, 0, 3)
        Me.tableButtons.Controls.Add(Me.pan, 0, 1)
        Me.tableButtons.Controls.Add(Me.tableButtons_podmeni, 1, 2)
        Me.tableButtons.Controls.Add(Me.btnObrada, 0, 0)
        Me.tableButtons.Controls.Add(Me.btnNazad, 0, 4)
        Me.tableButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tableButtons.Location = New System.Drawing.Point(0, 226)
        Me.tableButtons.Name = "tableButtons"
        Me.tableButtons.RowCount = 5
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.Size = New System.Drawing.Size(214, 226)
        Me.tableButtons.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.tableButtons.SetColumnSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 191)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(200, 2)
        Me.TableLayoutPanel2.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lavender
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 2)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "O P C  I  J  E"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pan
        '
        Me.pan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pan.ColumnCount = 2
        Me.tableButtons.SetColumnSpan(Me.pan, 2)
        Me.pan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.pan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pan.Controls.Add(Me.Label9, 0, 0)
        Me.pan.Location = New System.Drawing.Point(3, 33)
        Me.pan.Name = "pan"
        Me.pan.RowCount = 1
        Me.pan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pan.Size = New System.Drawing.Size(200, 2)
        Me.pan.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Lavender
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 2)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "O P C  I  J  E"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tableButtons_podmeni
        '
        Me.tableButtons_podmeni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableButtons_podmeni.ColumnCount = 1
        Me.tableButtons_podmeni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableButtons_podmeni.Controls.Add(Me.btnIzvestaji, 0, 6)
        Me.tableButtons_podmeni.Controls.Add(Me.panDnProm_Kontejner, 0, 1)
        Me.tableButtons_podmeni.Controls.Add(Me.btnUlaz, 0, 0)
        Me.tableButtons_podmeni.Controls.Add(Me.panPovracajRobe_Kontejner, 0, 5)
        Me.tableButtons_podmeni.Controls.Add(Me.panKalk_Kontejner, 0, 3)
        Me.tableButtons_podmeni.Controls.Add(Me.btnIzlaz, 0, 2)
        Me.tableButtons_podmeni.Controls.Add(Me.btnOstalo, 0, 4)
        Me.tableButtons_podmeni.Location = New System.Drawing.Point(23, 41)
        Me.tableButtons_podmeni.Name = "tableButtons_podmeni"
        Me.tableButtons_podmeni.RowCount = 7
        Me.tableButtons_podmeni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons_podmeni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tableButtons_podmeni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons_podmeni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tableButtons_podmeni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons_podmeni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tableButtons_podmeni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons_podmeni.Size = New System.Drawing.Size(188, 144)
        Me.tableButtons_podmeni.TabIndex = 5
        '
        'btnIzvestaji
        '
        Me.btnIzvestaji.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnIzvestaji.Location = New System.Drawing.Point(3, 117)
        Me.btnIzvestaji.Name = "btnIzvestaji"
        Me.btnIzvestaji.Size = New System.Drawing.Size(160, 24)
        Me.btnIzvestaji.TabIndex = 5
        Me.btnIzvestaji.Text = "IZVEŠTAJI"
        Me.btnIzvestaji.UseVisualStyleBackColor = True
        '
        'panDnProm_Kontejner
        '
        Me.panDnProm_Kontejner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panDnProm_Kontejner.ColumnCount = 2
        Me.panDnProm_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panDnProm_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panDnProm_Kontejner.Controls.Add(Me.Label10, 0, 0)
        Me.panDnProm_Kontejner.Controls.Add(Me.panDnProm_meni, 1, 0)
        Me.panDnProm_Kontejner.Location = New System.Drawing.Point(3, 33)
        Me.panDnProm_Kontejner.Name = "panDnProm_Kontejner"
        Me.panDnProm_Kontejner.RowCount = 1
        Me.panDnProm_Kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panDnProm_Kontejner.Size = New System.Drawing.Size(170, 2)
        Me.panDnProm_Kontejner.TabIndex = 10
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
        'panDnProm_meni
        '
        Me.panDnProm_meni.ColumnCount = 1
        Me.panDnProm_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panDnProm_meni.Controls.Add(Me.linkDPromet_search, 0, 0)
        Me.panDnProm_meni.Controls.Add(Me.linkDPromet_print, 0, 1)
        Me.panDnProm_meni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panDnProm_meni.Location = New System.Drawing.Point(33, 3)
        Me.panDnProm_meni.Name = "panDnProm_meni"
        Me.panDnProm_meni.RowCount = 3
        Me.panDnProm_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panDnProm_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panDnProm_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panDnProm_meni.Size = New System.Drawing.Size(134, 1)
        Me.panDnProm_meni.TabIndex = 22
        '
        'linkDPromet_search
        '
        Me.linkDPromet_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkDPromet_search.AutoSize = True
        Me.linkDPromet_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkDPromet_search.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkDPromet_search.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkDPromet_search.Location = New System.Drawing.Point(3, 3)
        Me.linkDPromet_search.Name = "linkDPromet_search"
        Me.linkDPromet_search.Size = New System.Drawing.Size(128, 13)
        Me.linkDPromet_search.TabIndex = 11
        Me.linkDPromet_search.TabStop = True
        Me.linkDPromet_search.Text = "Pretraga"
        '
        'linkDPromet_print
        '
        Me.linkDPromet_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkDPromet_print.AutoSize = True
        Me.linkDPromet_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkDPromet_print.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkDPromet_print.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkDPromet_print.Location = New System.Drawing.Point(3, 23)
        Me.linkDPromet_print.Name = "linkDPromet_print"
        Me.linkDPromet_print.Size = New System.Drawing.Size(128, 13)
        Me.linkDPromet_print.TabIndex = 4
        Me.linkDPromet_print.TabStop = True
        Me.linkDPromet_print.Text = "Štampanje"
        '
        'btnUlaz
        '
        Me.btnUlaz.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnUlaz.Location = New System.Drawing.Point(3, 3)
        Me.btnUlaz.Name = "btnUlaz"
        Me.btnUlaz.Size = New System.Drawing.Size(160, 24)
        Me.btnUlaz.TabIndex = 5
        Me.btnUlaz.Text = "ULAZ ROBE"
        Me.btnUlaz.UseVisualStyleBackColor = True
        '
        'panPovracajRobe_Kontejner
        '
        Me.panPovracajRobe_Kontejner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panPovracajRobe_Kontejner.ColumnCount = 2
        Me.panPovracajRobe_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panPovracajRobe_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panPovracajRobe_Kontejner.Controls.Add(Me.panPovracajRobe_meni, 1, 0)
        Me.panPovracajRobe_Kontejner.Controls.Add(Me.Label8, 0, 0)
        Me.panPovracajRobe_Kontejner.Location = New System.Drawing.Point(3, 109)
        Me.panPovracajRobe_Kontejner.Name = "panPovracajRobe_Kontejner"
        Me.panPovracajRobe_Kontejner.RowCount = 1
        Me.panPovracajRobe_Kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panPovracajRobe_Kontejner.Size = New System.Drawing.Size(170, 2)
        Me.panPovracajRobe_Kontejner.TabIndex = 33
        '
        'panPovracajRobe_meni
        '
        Me.panPovracajRobe_meni.ColumnCount = 1
        Me.panPovracajRobe_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panPovracajRobe_meni.Controls.Add(Me.linkPovracajRobe_edit, 0, 2)
        Me.panPovracajRobe_meni.Controls.Add(Me.linkPovracajRobe_add, 0, 1)
        Me.panPovracajRobe_meni.Controls.Add(Me.linkPovracajRobe_print, 0, 4)
        Me.panPovracajRobe_meni.Controls.Add(Me.linkPovracajRobe_del, 0, 3)
        Me.panPovracajRobe_meni.Controls.Add(Me.linkPovracajRobe_search, 0, 0)
        Me.panPovracajRobe_meni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panPovracajRobe_meni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panPovracajRobe_meni.Location = New System.Drawing.Point(33, 3)
        Me.panPovracajRobe_meni.Name = "panPovracajRobe_meni"
        Me.panPovracajRobe_meni.RowCount = 5
        Me.panPovracajRobe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panPovracajRobe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panPovracajRobe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panPovracajRobe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panPovracajRobe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panPovracajRobe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panPovracajRobe_meni.Size = New System.Drawing.Size(134, 1)
        Me.panPovracajRobe_meni.TabIndex = 28
        '
        'linkPovracajRobe_edit
        '
        Me.linkPovracajRobe_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkPovracajRobe_edit.AutoSize = True
        Me.linkPovracajRobe_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkPovracajRobe_edit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkPovracajRobe_edit.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkPovracajRobe_edit.Location = New System.Drawing.Point(3, 43)
        Me.linkPovracajRobe_edit.Name = "linkPovracajRobe_edit"
        Me.linkPovracajRobe_edit.Size = New System.Drawing.Size(128, 13)
        Me.linkPovracajRobe_edit.TabIndex = 2
        Me.linkPovracajRobe_edit.TabStop = True
        Me.linkPovracajRobe_edit.Text = "Izmene"
        '
        'linkPovracajRobe_add
        '
        Me.linkPovracajRobe_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkPovracajRobe_add.AutoSize = True
        Me.linkPovracajRobe_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkPovracajRobe_add.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkPovracajRobe_add.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkPovracajRobe_add.Location = New System.Drawing.Point(3, 23)
        Me.linkPovracajRobe_add.Name = "linkPovracajRobe_add"
        Me.linkPovracajRobe_add.Size = New System.Drawing.Size(128, 13)
        Me.linkPovracajRobe_add.TabIndex = 1
        Me.linkPovracajRobe_add.TabStop = True
        Me.linkPovracajRobe_add.Text = "Unos"
        '
        'linkPovracajRobe_print
        '
        Me.linkPovracajRobe_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkPovracajRobe_print.AutoSize = True
        Me.linkPovracajRobe_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkPovracajRobe_print.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkPovracajRobe_print.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkPovracajRobe_print.Location = New System.Drawing.Point(3, 83)
        Me.linkPovracajRobe_print.Name = "linkPovracajRobe_print"
        Me.linkPovracajRobe_print.Size = New System.Drawing.Size(128, 13)
        Me.linkPovracajRobe_print.TabIndex = 3
        Me.linkPovracajRobe_print.TabStop = True
        Me.linkPovracajRobe_print.Text = "Štampanje"
        '
        'linkPovracajRobe_del
        '
        Me.linkPovracajRobe_del.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkPovracajRobe_del.AutoSize = True
        Me.linkPovracajRobe_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkPovracajRobe_del.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkPovracajRobe_del.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkPovracajRobe_del.Location = New System.Drawing.Point(3, 63)
        Me.linkPovracajRobe_del.Name = "linkPovracajRobe_del"
        Me.linkPovracajRobe_del.Size = New System.Drawing.Size(128, 13)
        Me.linkPovracajRobe_del.TabIndex = 5
        Me.linkPovracajRobe_del.TabStop = True
        Me.linkPovracajRobe_del.Text = "Brisanje"
        '
        'linkPovracajRobe_search
        '
        Me.linkPovracajRobe_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkPovracajRobe_search.AutoSize = True
        Me.linkPovracajRobe_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkPovracajRobe_search.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkPovracajRobe_search.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkPovracajRobe_search.Location = New System.Drawing.Point(3, 3)
        Me.linkPovracajRobe_search.Name = "linkPovracajRobe_search"
        Me.linkPovracajRobe_search.Size = New System.Drawing.Size(128, 13)
        Me.linkPovracajRobe_search.TabIndex = 11
        Me.linkPovracajRobe_search.TabStop = True
        Me.linkPovracajRobe_search.Text = "Pretraga"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Lavender
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 2)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "O P C  I  J  E"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panKalk_Kontejner
        '
        Me.panKalk_Kontejner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panKalk_Kontejner.ColumnCount = 2
        Me.panKalk_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panKalk_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panKalk_Kontejner.Controls.Add(Me.Label3, 0, 0)
        Me.panKalk_Kontejner.Controls.Add(Me.panKalk_meni, 1, 0)
        Me.panKalk_Kontejner.Location = New System.Drawing.Point(3, 71)
        Me.panKalk_Kontejner.Name = "panKalk_Kontejner"
        Me.panKalk_Kontejner.RowCount = 1
        Me.panKalk_Kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panKalk_Kontejner.Size = New System.Drawing.Size(170, 2)
        Me.panKalk_Kontejner.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lavender
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 2)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "O P C  I  J  E"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panKalk_meni
        '
        Me.panKalk_meni.ColumnCount = 1
        Me.panKalk_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panKalk_meni.Controls.Add(Me.linkKalk_del, 0, 3)
        Me.panKalk_meni.Controls.Add(Me.linkKalk_edit, 0, 2)
        Me.panKalk_meni.Controls.Add(Me.linkKalk_add, 0, 1)
        Me.panKalk_meni.Controls.Add(Me.linkKalk_search, 0, 0)
        Me.panKalk_meni.Controls.Add(Me.linkKalk_print, 0, 4)
        Me.panKalk_meni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panKalk_meni.Location = New System.Drawing.Point(33, 3)
        Me.panKalk_meni.Name = "panKalk_meni"
        Me.panKalk_meni.RowCount = 5
        Me.panKalk_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panKalk_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panKalk_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panKalk_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panKalk_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panKalk_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panKalk_meni.Size = New System.Drawing.Size(134, 1)
        Me.panKalk_meni.TabIndex = 22
        '
        'linkKalk_del
        '
        Me.linkKalk_del.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkKalk_del.AutoSize = True
        Me.linkKalk_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkKalk_del.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkKalk_del.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkKalk_del.Location = New System.Drawing.Point(3, 63)
        Me.linkKalk_del.Name = "linkKalk_del"
        Me.linkKalk_del.Size = New System.Drawing.Size(128, 13)
        Me.linkKalk_del.TabIndex = 9
        Me.linkKalk_del.TabStop = True
        Me.linkKalk_del.Text = "Brisanje"
        '
        'linkKalk_edit
        '
        Me.linkKalk_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkKalk_edit.AutoSize = True
        Me.linkKalk_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkKalk_edit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkKalk_edit.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkKalk_edit.Location = New System.Drawing.Point(3, 43)
        Me.linkKalk_edit.Name = "linkKalk_edit"
        Me.linkKalk_edit.Size = New System.Drawing.Size(128, 13)
        Me.linkKalk_edit.TabIndex = 3
        Me.linkKalk_edit.TabStop = True
        Me.linkKalk_edit.Text = "Izmene"
        '
        'linkKalk_add
        '
        Me.linkKalk_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkKalk_add.AutoSize = True
        Me.linkKalk_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkKalk_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.linkKalk_add.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkKalk_add.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkKalk_add.Location = New System.Drawing.Point(3, 23)
        Me.linkKalk_add.Name = "linkKalk_add"
        Me.linkKalk_add.Size = New System.Drawing.Size(128, 13)
        Me.linkKalk_add.TabIndex = 2
        Me.linkKalk_add.TabStop = True
        Me.linkKalk_add.Text = "Unos"
        '
        'linkKalk_search
        '
        Me.linkKalk_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkKalk_search.AutoSize = True
        Me.linkKalk_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkKalk_search.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkKalk_search.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkKalk_search.Location = New System.Drawing.Point(3, 3)
        Me.linkKalk_search.Name = "linkKalk_search"
        Me.linkKalk_search.Size = New System.Drawing.Size(128, 13)
        Me.linkKalk_search.TabIndex = 11
        Me.linkKalk_search.TabStop = True
        Me.linkKalk_search.Text = "Pretraga"
        '
        'linkKalk_print
        '
        Me.linkKalk_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkKalk_print.AutoSize = True
        Me.linkKalk_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkKalk_print.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkKalk_print.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkKalk_print.Location = New System.Drawing.Point(3, 83)
        Me.linkKalk_print.Name = "linkKalk_print"
        Me.linkKalk_print.Size = New System.Drawing.Size(128, 13)
        Me.linkKalk_print.TabIndex = 4
        Me.linkKalk_print.TabStop = True
        Me.linkKalk_print.Text = "Štampanje"
        '
        'btnIzlaz
        '
        Me.btnIzlaz.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnIzlaz.Location = New System.Drawing.Point(3, 41)
        Me.btnIzlaz.Name = "btnIzlaz"
        Me.btnIzlaz.Size = New System.Drawing.Size(160, 24)
        Me.btnIzlaz.TabIndex = 4
        Me.btnIzlaz.Text = "IZLAZ ROBE"
        Me.btnIzlaz.UseVisualStyleBackColor = True
        '
        'btnOstalo
        '
        Me.btnOstalo.Location = New System.Drawing.Point(3, 79)
        Me.btnOstalo.Name = "btnOstalo"
        Me.btnOstalo.Size = New System.Drawing.Size(160, 23)
        Me.btnOstalo.TabIndex = 16
        Me.btnOstalo.Text = "OSTALA DOKUMENTA"
        Me.btnOstalo.UseVisualStyleBackColor = True
        '
        'btnObrada
        '
        Me.tableButtons.SetColumnSpan(Me.btnObrada, 2)
        Me.btnObrada.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnObrada.Location = New System.Drawing.Point(3, 3)
        Me.btnObrada.Name = "btnObrada"
        Me.btnObrada.Size = New System.Drawing.Size(183, 24)
        Me.btnObrada.TabIndex = 3
        Me.btnObrada.Text = "OBRADA PODATAKA"
        Me.btnObrada.UseVisualStyleBackColor = True
        '
        'btnNazad
        '
        Me.tableButtons.SetColumnSpan(Me.btnNazad, 2)
        Me.btnNazad.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnNazad.Location = New System.Drawing.Point(3, 199)
        Me.btnNazad.Name = "btnNazad"
        Me.btnNazad.Size = New System.Drawing.Size(183, 24)
        Me.btnNazad.TabIndex = 4
        Me.btnNazad.Text = "NAZAD"
        Me.btnNazad.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackgroundImage = Global.Farma.My.Resources.Resources.Dossiers_Panneau_de_configuration
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(214, 117)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'cntMeniUIDokumenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.tableButtons)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntMeniUIDokumenti"
        Me.Size = New System.Drawing.Size(214, 452)
        Me.tableButtons.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.pan.ResumeLayout(False)
        Me.tableButtons_podmeni.ResumeLayout(False)
        Me.panDnProm_Kontejner.ResumeLayout(False)
        Me.panDnProm_meni.ResumeLayout(False)
        Me.panDnProm_meni.PerformLayout()
        Me.panPovracajRobe_Kontejner.ResumeLayout(False)
        Me.panPovracajRobe_meni.ResumeLayout(False)
        Me.panPovracajRobe_meni.PerformLayout()
        Me.panKalk_Kontejner.ResumeLayout(False)
        Me.panKalk_meni.ResumeLayout(False)
        Me.panKalk_meni.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tableButtons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnObrada As System.Windows.Forms.Button
    Friend WithEvents btnNazad As System.Windows.Forms.Button
    Friend WithEvents tableButtons_podmeni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnIzvestaji As System.Windows.Forms.Button
    Friend WithEvents panDnProm_Kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents panDnProm_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkDPromet_search As System.Windows.Forms.LinkLabel
    Friend WithEvents linkDPromet_print As System.Windows.Forms.LinkLabel
    Friend WithEvents btnUlaz As System.Windows.Forms.Button
    Friend WithEvents panPovracajRobe_Kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panPovracajRobe_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkPovracajRobe_edit As System.Windows.Forms.LinkLabel
    Friend WithEvents linkPovracajRobe_add As System.Windows.Forms.LinkLabel
    Friend WithEvents linkPovracajRobe_print As System.Windows.Forms.LinkLabel
    Friend WithEvents linkPovracajRobe_del As System.Windows.Forms.LinkLabel
    Friend WithEvents linkPovracajRobe_search As System.Windows.Forms.LinkLabel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents panKalk_Kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents panKalk_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkKalk_del As System.Windows.Forms.LinkLabel
    Friend WithEvents linkKalk_edit As System.Windows.Forms.LinkLabel
    Friend WithEvents linkKalk_add As System.Windows.Forms.LinkLabel
    Friend WithEvents linkKalk_search As System.Windows.Forms.LinkLabel
    Friend WithEvents linkKalk_print As System.Windows.Forms.LinkLabel
    Friend WithEvents btnIzlaz As System.Windows.Forms.Button
    Friend WithEvents btnOstalo As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pan As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
