<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntMeniRobno
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
        Me.panGlavni = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnRobno = New System.Windows.Forms.Button
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.tableButtons = New System.Windows.Forms.TableLayoutPanel
        Me.btnIzvestaji = New System.Windows.Forms.Button
        Me.panUlazRobe_Kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.Label10 = New System.Windows.Forms.Label
        Me.panUlazRobe_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkUlazniDok_print = New System.Windows.Forms.LinkLabel
        Me.linkUlazniDok_del = New System.Windows.Forms.LinkLabel
        Me.linkUlazniDok_search = New System.Windows.Forms.LinkLabel
        Me.linkUlazniDok_edit = New System.Windows.Forms.LinkLabel
        Me.linkUlazniDok_add = New System.Windows.Forms.LinkLabel
        Me.btnUlaz = New System.Windows.Forms.Button
        Me.panPovracajRobe_Kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.panPovracajRobe_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkPovracajRobe_edit = New System.Windows.Forms.LinkLabel
        Me.linkPovracajRobe_add = New System.Windows.Forms.LinkLabel
        Me.linkPovracajRobe_print = New System.Windows.Forms.LinkLabel
        Me.linkPovracajRobe_del = New System.Windows.Forms.LinkLabel
        Me.linkPovracajRobe_search = New System.Windows.Forms.LinkLabel
        Me.Label8 = New System.Windows.Forms.Label
        Me.panIzlazRobe_Kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.Label3 = New System.Windows.Forms.Label
        Me.panIzlazRobe_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkIzlazniDok_del = New System.Windows.Forms.LinkLabel
        Me.linkIzlazniDok_edit = New System.Windows.Forms.LinkLabel
        Me.linkIzlazniDok_add = New System.Windows.Forms.LinkLabel
        Me.linkIzlazniDok_search = New System.Windows.Forms.LinkLabel
        Me.linkIzlazniDok_print = New System.Windows.Forms.LinkLabel
        Me.btnIzlaz = New System.Windows.Forms.Button
        Me.btnOstalo = New System.Windows.Forms.Button
        Me.btnNazad = New System.Windows.Forms.Button
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.panGlavni.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.tableButtons.SuspendLayout()
        Me.panUlazRobe_Kontejner.SuspendLayout()
        Me.panUlazRobe_meni.SuspendLayout()
        Me.panPovracajRobe_Kontejner.SuspendLayout()
        Me.panPovracajRobe_meni.SuspendLayout()
        Me.panIzlazRobe_Kontejner.SuspendLayout()
        Me.panIzlazRobe_meni.SuspendLayout()
        Me.SuspendLayout()
        '
        'panGlavni
        '
        Me.panGlavni.ColumnCount = 2
        Me.panGlavni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.panGlavni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panGlavni.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.panGlavni.Controls.Add(Me.btnRobno, 0, 0)
        Me.panGlavni.Controls.Add(Me.tableButtons, 1, 2)
        Me.panGlavni.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panGlavni.Location = New System.Drawing.Point(0, 180)
        Me.panGlavni.Name = "panGlavni"
        Me.panGlavni.RowCount = 3
        Me.panGlavni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panGlavni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.panGlavni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panGlavni.Size = New System.Drawing.Size(235, 226)
        Me.panGlavni.TabIndex = 1
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
        'btnRobno
        '
        Me.panGlavni.SetColumnSpan(Me.btnRobno, 2)
        Me.btnRobno.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnRobno.Location = New System.Drawing.Point(3, 3)
        Me.btnRobno.Name = "btnRobno"
        Me.btnRobno.Size = New System.Drawing.Size(198, 24)
        Me.btnRobno.TabIndex = 9
        Me.btnRobno.Text = "ROBNO"
        Me.btnRobno.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 147)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(162, 2)
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
        'tableButtons
        '
        Me.tableButtons.ColumnCount = 1
        Me.tableButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableButtons.Controls.Add(Me.panUlazRobe_Kontejner, 0, 1)
        Me.tableButtons.Controls.Add(Me.btnUlaz, 0, 0)
        Me.tableButtons.Controls.Add(Me.TableLayoutPanel2, 0, 7)
        Me.tableButtons.Controls.Add(Me.panPovracajRobe_Kontejner, 0, 5)
        Me.tableButtons.Controls.Add(Me.panIzlazRobe_Kontejner, 0, 3)
        Me.tableButtons.Controls.Add(Me.btnNazad, 0, 8)
        Me.tableButtons.Controls.Add(Me.btnIzlaz, 0, 2)
        Me.tableButtons.Controls.Add(Me.btnOstalo, 0, 4)
        Me.tableButtons.Controls.Add(Me.btnIzvestaji, 0, 6)
        Me.tableButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableButtons.Location = New System.Drawing.Point(18, 41)
        Me.tableButtons.Name = "tableButtons"
        Me.tableButtons.RowCount = 9
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.Size = New System.Drawing.Size(214, 182)
        Me.tableButtons.TabIndex = 5
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
        'panUlazRobe_Kontejner
        '
        Me.panUlazRobe_Kontejner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panUlazRobe_Kontejner.ColumnCount = 2
        Me.panUlazRobe_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panUlazRobe_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panUlazRobe_Kontejner.Controls.Add(Me.Label10, 0, 0)
        Me.panUlazRobe_Kontejner.Controls.Add(Me.panUlazRobe_meni, 1, 0)
        Me.panUlazRobe_Kontejner.Location = New System.Drawing.Point(3, 33)
        Me.panUlazRobe_Kontejner.Name = "panUlazRobe_Kontejner"
        Me.panUlazRobe_Kontejner.RowCount = 1
        Me.panUlazRobe_Kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panUlazRobe_Kontejner.Size = New System.Drawing.Size(162, 2)
        Me.panUlazRobe_Kontejner.TabIndex = 10
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
        'panUlazRobe_meni
        '
        Me.panUlazRobe_meni.ColumnCount = 1
        Me.panUlazRobe_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panUlazRobe_meni.Controls.Add(Me.linkUlazniDok_print, 0, 4)
        Me.panUlazRobe_meni.Controls.Add(Me.linkUlazniDok_del, 0, 3)
        Me.panUlazRobe_meni.Controls.Add(Me.linkUlazniDok_search, 0, 0)
        Me.panUlazRobe_meni.Controls.Add(Me.linkUlazniDok_edit, 0, 2)
        Me.panUlazRobe_meni.Controls.Add(Me.linkUlazniDok_add, 0, 1)
        Me.panUlazRobe_meni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panUlazRobe_meni.Location = New System.Drawing.Point(33, 3)
        Me.panUlazRobe_meni.Name = "panUlazRobe_meni"
        Me.panUlazRobe_meni.RowCount = 5
        Me.panUlazRobe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panUlazRobe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panUlazRobe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panUlazRobe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panUlazRobe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panUlazRobe_meni.Size = New System.Drawing.Size(126, 1)
        Me.panUlazRobe_meni.TabIndex = 22
        '
        'linkUlazniDok_print
        '
        Me.linkUlazniDok_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkUlazniDok_print.AutoSize = True
        Me.linkUlazniDok_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkUlazniDok_print.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkUlazniDok_print.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkUlazniDok_print.Location = New System.Drawing.Point(3, 83)
        Me.linkUlazniDok_print.Name = "linkUlazniDok_print"
        Me.linkUlazniDok_print.Size = New System.Drawing.Size(120, 13)
        Me.linkUlazniDok_print.TabIndex = 4
        Me.linkUlazniDok_print.TabStop = True
        Me.linkUlazniDok_print.Text = "Štampanje"
        '
        'linkUlazniDok_del
        '
        Me.linkUlazniDok_del.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkUlazniDok_del.AutoSize = True
        Me.linkUlazniDok_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkUlazniDok_del.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkUlazniDok_del.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkUlazniDok_del.Location = New System.Drawing.Point(3, 63)
        Me.linkUlazniDok_del.Name = "linkUlazniDok_del"
        Me.linkUlazniDok_del.Size = New System.Drawing.Size(120, 13)
        Me.linkUlazniDok_del.TabIndex = 9
        Me.linkUlazniDok_del.TabStop = True
        Me.linkUlazniDok_del.Text = "Brisanje"
        '
        'linkUlazniDok_search
        '
        Me.linkUlazniDok_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkUlazniDok_search.AutoSize = True
        Me.linkUlazniDok_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkUlazniDok_search.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkUlazniDok_search.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkUlazniDok_search.Location = New System.Drawing.Point(3, 3)
        Me.linkUlazniDok_search.Name = "linkUlazniDok_search"
        Me.linkUlazniDok_search.Size = New System.Drawing.Size(120, 13)
        Me.linkUlazniDok_search.TabIndex = 11
        Me.linkUlazniDok_search.TabStop = True
        Me.linkUlazniDok_search.Text = "Pretraga"
        '
        'linkUlazniDok_edit
        '
        Me.linkUlazniDok_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkUlazniDok_edit.AutoSize = True
        Me.linkUlazniDok_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkUlazniDok_edit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkUlazniDok_edit.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkUlazniDok_edit.Location = New System.Drawing.Point(3, 43)
        Me.linkUlazniDok_edit.Name = "linkUlazniDok_edit"
        Me.linkUlazniDok_edit.Size = New System.Drawing.Size(120, 13)
        Me.linkUlazniDok_edit.TabIndex = 4
        Me.linkUlazniDok_edit.TabStop = True
        Me.linkUlazniDok_edit.Text = "Izmene"
        '
        'linkUlazniDok_add
        '
        Me.linkUlazniDok_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkUlazniDok_add.AutoSize = True
        Me.linkUlazniDok_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkUlazniDok_add.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkUlazniDok_add.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkUlazniDok_add.Location = New System.Drawing.Point(3, 23)
        Me.linkUlazniDok_add.Name = "linkUlazniDok_add"
        Me.linkUlazniDok_add.Size = New System.Drawing.Size(120, 13)
        Me.linkUlazniDok_add.TabIndex = 11
        Me.linkUlazniDok_add.TabStop = True
        Me.linkUlazniDok_add.Text = "Unos"
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
        Me.panPovracajRobe_Kontejner.Size = New System.Drawing.Size(162, 2)
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
        Me.panPovracajRobe_meni.Size = New System.Drawing.Size(126, 1)
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
        Me.linkPovracajRobe_edit.Size = New System.Drawing.Size(120, 13)
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
        Me.linkPovracajRobe_add.Size = New System.Drawing.Size(120, 13)
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
        Me.linkPovracajRobe_print.Size = New System.Drawing.Size(120, 13)
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
        Me.linkPovracajRobe_del.Size = New System.Drawing.Size(120, 13)
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
        Me.linkPovracajRobe_search.Size = New System.Drawing.Size(120, 13)
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
        'panIzlazRobe_Kontejner
        '
        Me.panIzlazRobe_Kontejner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panIzlazRobe_Kontejner.ColumnCount = 2
        Me.panIzlazRobe_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panIzlazRobe_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panIzlazRobe_Kontejner.Controls.Add(Me.Label3, 0, 0)
        Me.panIzlazRobe_Kontejner.Controls.Add(Me.panIzlazRobe_meni, 1, 0)
        Me.panIzlazRobe_Kontejner.Location = New System.Drawing.Point(3, 71)
        Me.panIzlazRobe_Kontejner.Name = "panIzlazRobe_Kontejner"
        Me.panIzlazRobe_Kontejner.RowCount = 1
        Me.panIzlazRobe_Kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panIzlazRobe_Kontejner.Size = New System.Drawing.Size(162, 2)
        Me.panIzlazRobe_Kontejner.TabIndex = 9
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
        'panIzlazRobe_meni
        '
        Me.panIzlazRobe_meni.ColumnCount = 1
        Me.panIzlazRobe_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panIzlazRobe_meni.Controls.Add(Me.linkIzlazniDok_del, 0, 3)
        Me.panIzlazRobe_meni.Controls.Add(Me.linkIzlazniDok_edit, 0, 2)
        Me.panIzlazRobe_meni.Controls.Add(Me.linkIzlazniDok_add, 0, 1)
        Me.panIzlazRobe_meni.Controls.Add(Me.linkIzlazniDok_search, 0, 0)
        Me.panIzlazRobe_meni.Controls.Add(Me.linkIzlazniDok_print, 0, 4)
        Me.panIzlazRobe_meni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panIzlazRobe_meni.Location = New System.Drawing.Point(33, 3)
        Me.panIzlazRobe_meni.Name = "panIzlazRobe_meni"
        Me.panIzlazRobe_meni.RowCount = 5
        Me.panIzlazRobe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panIzlazRobe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panIzlazRobe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panIzlazRobe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panIzlazRobe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panIzlazRobe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panIzlazRobe_meni.Size = New System.Drawing.Size(126, 1)
        Me.panIzlazRobe_meni.TabIndex = 22
        '
        'linkIzlazniDok_del
        '
        Me.linkIzlazniDok_del.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkIzlazniDok_del.AutoSize = True
        Me.linkIzlazniDok_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkIzlazniDok_del.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkIzlazniDok_del.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkIzlazniDok_del.Location = New System.Drawing.Point(3, 63)
        Me.linkIzlazniDok_del.Name = "linkIzlazniDok_del"
        Me.linkIzlazniDok_del.Size = New System.Drawing.Size(120, 13)
        Me.linkIzlazniDok_del.TabIndex = 9
        Me.linkIzlazniDok_del.TabStop = True
        Me.linkIzlazniDok_del.Text = "Brisanje"
        '
        'linkIzlazniDok_edit
        '
        Me.linkIzlazniDok_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkIzlazniDok_edit.AutoSize = True
        Me.linkIzlazniDok_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkIzlazniDok_edit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkIzlazniDok_edit.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkIzlazniDok_edit.Location = New System.Drawing.Point(3, 43)
        Me.linkIzlazniDok_edit.Name = "linkIzlazniDok_edit"
        Me.linkIzlazniDok_edit.Size = New System.Drawing.Size(120, 13)
        Me.linkIzlazniDok_edit.TabIndex = 3
        Me.linkIzlazniDok_edit.TabStop = True
        Me.linkIzlazniDok_edit.Text = "Izmene"
        '
        'linkIzlazniDok_add
        '
        Me.linkIzlazniDok_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkIzlazniDok_add.AutoSize = True
        Me.linkIzlazniDok_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkIzlazniDok_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.linkIzlazniDok_add.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkIzlazniDok_add.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkIzlazniDok_add.Location = New System.Drawing.Point(3, 23)
        Me.linkIzlazniDok_add.Name = "linkIzlazniDok_add"
        Me.linkIzlazniDok_add.Size = New System.Drawing.Size(120, 13)
        Me.linkIzlazniDok_add.TabIndex = 2
        Me.linkIzlazniDok_add.TabStop = True
        Me.linkIzlazniDok_add.Text = "Unos"
        '
        'linkIzlazniDok_search
        '
        Me.linkIzlazniDok_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkIzlazniDok_search.AutoSize = True
        Me.linkIzlazniDok_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkIzlazniDok_search.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkIzlazniDok_search.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkIzlazniDok_search.Location = New System.Drawing.Point(3, 3)
        Me.linkIzlazniDok_search.Name = "linkIzlazniDok_search"
        Me.linkIzlazniDok_search.Size = New System.Drawing.Size(120, 13)
        Me.linkIzlazniDok_search.TabIndex = 11
        Me.linkIzlazniDok_search.TabStop = True
        Me.linkIzlazniDok_search.Text = "Pretraga"
        '
        'linkIzlazniDok_print
        '
        Me.linkIzlazniDok_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkIzlazniDok_print.AutoSize = True
        Me.linkIzlazniDok_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkIzlazniDok_print.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkIzlazniDok_print.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkIzlazniDok_print.Location = New System.Drawing.Point(3, 83)
        Me.linkIzlazniDok_print.Name = "linkIzlazniDok_print"
        Me.linkIzlazniDok_print.Size = New System.Drawing.Size(120, 13)
        Me.linkIzlazniDok_print.TabIndex = 4
        Me.linkIzlazniDok_print.TabStop = True
        Me.linkIzlazniDok_print.Text = "Štampanje"
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
        'btnNazad
        '
        Me.btnNazad.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnNazad.Location = New System.Drawing.Point(3, 155)
        Me.btnNazad.Name = "btnNazad"
        Me.btnNazad.Size = New System.Drawing.Size(162, 24)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(235, 117)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'cntMeniRobno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.panGlavni)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntMeniRobno"
        Me.Size = New System.Drawing.Size(235, 406)
        Me.panGlavni.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.tableButtons.ResumeLayout(False)
        Me.panUlazRobe_Kontejner.ResumeLayout(False)
        Me.panUlazRobe_meni.ResumeLayout(False)
        Me.panUlazRobe_meni.PerformLayout()
        Me.panPovracajRobe_Kontejner.ResumeLayout(False)
        Me.panPovracajRobe_meni.ResumeLayout(False)
        Me.panPovracajRobe_meni.PerformLayout()
        Me.panIzlazRobe_Kontejner.ResumeLayout(False)
        Me.panIzlazRobe_meni.ResumeLayout(False)
        Me.panIzlazRobe_meni.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panGlavni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnNazad As System.Windows.Forms.Button
    Friend WithEvents tableButtons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnIzvestaji As System.Windows.Forms.Button
    Friend WithEvents panUlazRobe_Kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents panUlazRobe_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkUlazniDok_add As System.Windows.Forms.LinkLabel
    Friend WithEvents linkUlazniDok_edit As System.Windows.Forms.LinkLabel
    Friend WithEvents btnUlaz As System.Windows.Forms.Button
    Friend WithEvents panPovracajRobe_Kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panPovracajRobe_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkPovracajRobe_edit As System.Windows.Forms.LinkLabel
    Friend WithEvents linkPovracajRobe_add As System.Windows.Forms.LinkLabel
    Friend WithEvents linkPovracajRobe_print As System.Windows.Forms.LinkLabel
    Friend WithEvents linkPovracajRobe_del As System.Windows.Forms.LinkLabel
    Friend WithEvents linkPovracajRobe_search As System.Windows.Forms.LinkLabel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents panIzlazRobe_Kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents panIzlazRobe_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkIzlazniDok_del As System.Windows.Forms.LinkLabel
    Friend WithEvents linkIzlazniDok_edit As System.Windows.Forms.LinkLabel
    Friend WithEvents linkIzlazniDok_add As System.Windows.Forms.LinkLabel
    Friend WithEvents linkIzlazniDok_search As System.Windows.Forms.LinkLabel
    Friend WithEvents linkIzlazniDok_print As System.Windows.Forms.LinkLabel
    Friend WithEvents btnIzlaz As System.Windows.Forms.Button
    Friend WithEvents btnOstalo As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRobno As System.Windows.Forms.Button
    Friend WithEvents linkUlazniDok_print As System.Windows.Forms.LinkLabel
    Friend WithEvents linkUlazniDok_del As System.Windows.Forms.LinkLabel
    Friend WithEvents linkUlazniDok_search As System.Windows.Forms.LinkLabel

End Class
