<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntMeniPartneri
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
        Me.panNaselja_Kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.Label2 = New System.Windows.Forms.Label
        Me.panNaselja_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkNaselja_search = New System.Windows.Forms.LinkLabel
        Me.linkNaseljaUnos = New System.Windows.Forms.LinkLabel
        Me.linkNaseljaEdit = New System.Windows.Forms.LinkLabel
        Me.linkNaseljaBrisanje = New System.Windows.Forms.LinkLabel
        Me.linkNaseljaPrint = New System.Windows.Forms.LinkLabel
        Me.btnNazad = New System.Windows.Forms.Button
        Me.btnPartneri = New System.Windows.Forms.Button
        Me.panPartneri_Kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.panPartneri_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkPartneri_print = New System.Windows.Forms.LinkLabel
        Me.linkPartneri_del = New System.Windows.Forms.LinkLabel
        Me.linkPartneri_edit = New System.Windows.Forms.LinkLabel
        Me.linkPartneri_add = New System.Windows.Forms.LinkLabel
        Me.linkPartneri_search = New System.Windows.Forms.LinkLabel
        Me.btnOJ = New System.Windows.Forms.Button
        Me.btnNaselja = New System.Windows.Forms.Button
        Me.panOJ_Kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.Label3 = New System.Windows.Forms.Label
        Me.panOJ_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkOJ_search = New System.Windows.Forms.LinkLabel
        Me.linkOJPrint = New System.Windows.Forms.LinkLabel
        Me.linkOJBrisanje = New System.Windows.Forms.LinkLabel
        Me.linkOJEdit = New System.Windows.Forms.LinkLabel
        Me.linkOJUnos = New System.Windows.Forms.LinkLabel
        Me.tableButtons.SuspendLayout()
        Me.panNaselja_Kontejner.SuspendLayout()
        Me.panNaselja_meni.SuspendLayout()
        Me.panPartneri_Kontejner.SuspendLayout()
        Me.panPartneri_meni.SuspendLayout()
        Me.panOJ_Kontejner.SuspendLayout()
        Me.panOJ_meni.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableButtons
        '
        Me.tableButtons.ColumnCount = 1
        Me.tableButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableButtons.Controls.Add(Me.panNaselja_Kontejner, 0, 5)
        Me.tableButtons.Controls.Add(Me.btnNazad, 0, 6)
        Me.tableButtons.Controls.Add(Me.btnPartneri, 0, 0)
        Me.tableButtons.Controls.Add(Me.panPartneri_Kontejner, 0, 1)
        Me.tableButtons.Controls.Add(Me.btnOJ, 0, 2)
        Me.tableButtons.Controls.Add(Me.btnNaselja, 0, 4)
        Me.tableButtons.Controls.Add(Me.panOJ_Kontejner, 0, 3)
        Me.tableButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tableButtons.Location = New System.Drawing.Point(0, 47)
        Me.tableButtons.Name = "tableButtons"
        Me.tableButtons.RowCount = 7
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.Size = New System.Drawing.Size(252, 460)
        Me.tableButtons.TabIndex = 3
        '
        'panNaselja_Kontejner
        '
        Me.panNaselja_Kontejner.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panNaselja_Kontejner.ColumnCount = 2
        Me.panNaselja_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panNaselja_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panNaselja_Kontejner.Controls.Add(Me.Label2, 0, 0)
        Me.panNaselja_Kontejner.Controls.Add(Me.panNaselja_meni, 1, 0)
        Me.panNaselja_Kontejner.Location = New System.Drawing.Point(3, 317)
        Me.panNaselja_Kontejner.Name = "panNaselja_Kontejner"
        Me.panNaselja_Kontejner.RowCount = 1
        Me.panNaselja_Kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panNaselja_Kontejner.Size = New System.Drawing.Size(246, 106)
        Me.panNaselja_Kontejner.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lavender
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 106)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "O P C  I  J  E"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panNaselja_meni
        '
        Me.panNaselja_meni.ColumnCount = 1
        Me.panNaselja_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panNaselja_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panNaselja_meni.Controls.Add(Me.linkNaselja_search, 0, 0)
        Me.panNaselja_meni.Controls.Add(Me.linkNaseljaUnos, 0, 1)
        Me.panNaselja_meni.Controls.Add(Me.linkNaseljaEdit, 0, 2)
        Me.panNaselja_meni.Controls.Add(Me.linkNaseljaBrisanje, 0, 3)
        Me.panNaselja_meni.Controls.Add(Me.linkNaseljaPrint, 0, 4)
        Me.panNaselja_meni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panNaselja_meni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panNaselja_meni.Location = New System.Drawing.Point(33, 3)
        Me.panNaselja_meni.Name = "panNaselja_meni"
        Me.panNaselja_meni.RowCount = 6
        Me.panNaselja_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panNaselja_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panNaselja_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panNaselja_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panNaselja_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panNaselja_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panNaselja_meni.Size = New System.Drawing.Size(210, 100)
        Me.panNaselja_meni.TabIndex = 22
        '
        'linkNaselja_search
        '
        Me.linkNaselja_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkNaselja_search.AutoSize = True
        Me.linkNaselja_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkNaselja_search.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkNaselja_search.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkNaselja_search.Location = New System.Drawing.Point(3, 3)
        Me.linkNaselja_search.Name = "linkNaselja_search"
        Me.linkNaselja_search.Size = New System.Drawing.Size(204, 13)
        Me.linkNaselja_search.TabIndex = 26
        Me.linkNaselja_search.TabStop = True
        Me.linkNaselja_search.Text = "Pretraga"
        '
        'linkNaseljaUnos
        '
        Me.linkNaseljaUnos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkNaseljaUnos.AutoSize = True
        Me.linkNaseljaUnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkNaseljaUnos.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkNaseljaUnos.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkNaseljaUnos.Location = New System.Drawing.Point(3, 23)
        Me.linkNaseljaUnos.Name = "linkNaseljaUnos"
        Me.linkNaseljaUnos.Size = New System.Drawing.Size(204, 13)
        Me.linkNaseljaUnos.TabIndex = 1
        Me.linkNaseljaUnos.TabStop = True
        Me.linkNaseljaUnos.Text = "Unos"
        '
        'linkNaseljaEdit
        '
        Me.linkNaseljaEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkNaseljaEdit.AutoSize = True
        Me.linkNaseljaEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkNaseljaEdit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkNaseljaEdit.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkNaseljaEdit.Location = New System.Drawing.Point(3, 43)
        Me.linkNaseljaEdit.Name = "linkNaseljaEdit"
        Me.linkNaseljaEdit.Size = New System.Drawing.Size(204, 13)
        Me.linkNaseljaEdit.TabIndex = 2
        Me.linkNaseljaEdit.TabStop = True
        Me.linkNaseljaEdit.Text = "Izmene"
        '
        'linkNaseljaBrisanje
        '
        Me.linkNaseljaBrisanje.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkNaseljaBrisanje.AutoSize = True
        Me.linkNaseljaBrisanje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkNaseljaBrisanje.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkNaseljaBrisanje.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkNaseljaBrisanje.Location = New System.Drawing.Point(3, 63)
        Me.linkNaseljaBrisanje.Name = "linkNaseljaBrisanje"
        Me.linkNaseljaBrisanje.Size = New System.Drawing.Size(204, 13)
        Me.linkNaseljaBrisanje.TabIndex = 5
        Me.linkNaseljaBrisanje.TabStop = True
        Me.linkNaseljaBrisanje.Text = "Brisanje"
        '
        'linkNaseljaPrint
        '
        Me.linkNaseljaPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkNaseljaPrint.AutoSize = True
        Me.linkNaseljaPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkNaseljaPrint.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkNaseljaPrint.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkNaseljaPrint.Location = New System.Drawing.Point(3, 83)
        Me.linkNaseljaPrint.Name = "linkNaseljaPrint"
        Me.linkNaseljaPrint.Size = New System.Drawing.Size(204, 13)
        Me.linkNaseljaPrint.TabIndex = 3
        Me.linkNaseljaPrint.TabStop = True
        Me.linkNaseljaPrint.Text = "Štampanje"
        '
        'btnNazad
        '
        Me.btnNazad.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnNazad.Location = New System.Drawing.Point(3, 429)
        Me.btnNazad.Name = "btnNazad"
        Me.btnNazad.Size = New System.Drawing.Size(218, 24)
        Me.btnNazad.TabIndex = 11
        Me.btnNazad.Text = "NAZAD"
        Me.btnNazad.UseVisualStyleBackColor = True
        '
        'btnPartneri
        '
        Me.btnPartneri.Location = New System.Drawing.Point(3, 3)
        Me.btnPartneri.Name = "btnPartneri"
        Me.btnPartneri.Size = New System.Drawing.Size(218, 24)
        Me.btnPartneri.TabIndex = 8
        Me.btnPartneri.Text = "PARTNERI"
        Me.btnPartneri.UseVisualStyleBackColor = True
        '
        'panPartneri_Kontejner
        '
        Me.panPartneri_Kontejner.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panPartneri_Kontejner.ColumnCount = 2
        Me.panPartneri_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panPartneri_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panPartneri_Kontejner.Controls.Add(Me.Label1, 0, 0)
        Me.panPartneri_Kontejner.Controls.Add(Me.panPartneri_meni, 1, 0)
        Me.panPartneri_Kontejner.Location = New System.Drawing.Point(3, 33)
        Me.panPartneri_Kontejner.Name = "panPartneri_Kontejner"
        Me.panPartneri_Kontejner.RowCount = 1
        Me.panPartneri_Kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panPartneri_Kontejner.Size = New System.Drawing.Size(246, 106)
        Me.panPartneri_Kontejner.TabIndex = 10
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
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "O P C  I  J  E"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panPartneri_meni
        '
        Me.panPartneri_meni.ColumnCount = 1
        Me.panPartneri_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panPartneri_meni.Controls.Add(Me.linkPartneri_print, 0, 4)
        Me.panPartneri_meni.Controls.Add(Me.linkPartneri_del, 0, 3)
        Me.panPartneri_meni.Controls.Add(Me.linkPartneri_edit, 0, 2)
        Me.panPartneri_meni.Controls.Add(Me.linkPartneri_add, 0, 1)
        Me.panPartneri_meni.Controls.Add(Me.linkPartneri_search, 0, 0)
        Me.panPartneri_meni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panPartneri_meni.Location = New System.Drawing.Point(33, 3)
        Me.panPartneri_meni.Name = "panPartneri_meni"
        Me.panPartneri_meni.RowCount = 5
        Me.panPartneri_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panPartneri_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panPartneri_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panPartneri_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panPartneri_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panPartneri_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panPartneri_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panPartneri_meni.Size = New System.Drawing.Size(210, 100)
        Me.panPartneri_meni.TabIndex = 22
        '
        'linkPartneri_print
        '
        Me.linkPartneri_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkPartneri_print.AutoSize = True
        Me.linkPartneri_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkPartneri_print.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkPartneri_print.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkPartneri_print.Location = New System.Drawing.Point(3, 83)
        Me.linkPartneri_print.Name = "linkPartneri_print"
        Me.linkPartneri_print.Size = New System.Drawing.Size(204, 13)
        Me.linkPartneri_print.TabIndex = 4
        Me.linkPartneri_print.TabStop = True
        Me.linkPartneri_print.Text = "Štampanje"
        '
        'linkPartneri_del
        '
        Me.linkPartneri_del.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkPartneri_del.AutoSize = True
        Me.linkPartneri_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkPartneri_del.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkPartneri_del.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkPartneri_del.Location = New System.Drawing.Point(3, 63)
        Me.linkPartneri_del.Name = "linkPartneri_del"
        Me.linkPartneri_del.Size = New System.Drawing.Size(204, 13)
        Me.linkPartneri_del.TabIndex = 9
        Me.linkPartneri_del.TabStop = True
        Me.linkPartneri_del.Text = "Brisanje"
        '
        'linkPartneri_edit
        '
        Me.linkPartneri_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkPartneri_edit.AutoSize = True
        Me.linkPartneri_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkPartneri_edit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkPartneri_edit.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkPartneri_edit.Location = New System.Drawing.Point(3, 43)
        Me.linkPartneri_edit.Name = "linkPartneri_edit"
        Me.linkPartneri_edit.Size = New System.Drawing.Size(204, 13)
        Me.linkPartneri_edit.TabIndex = 3
        Me.linkPartneri_edit.TabStop = True
        Me.linkPartneri_edit.Text = "Izmene"
        '
        'linkPartneri_add
        '
        Me.linkPartneri_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkPartneri_add.AutoSize = True
        Me.linkPartneri_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkPartneri_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.linkPartneri_add.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkPartneri_add.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkPartneri_add.Location = New System.Drawing.Point(3, 23)
        Me.linkPartneri_add.Name = "linkPartneri_add"
        Me.linkPartneri_add.Size = New System.Drawing.Size(204, 13)
        Me.linkPartneri_add.TabIndex = 2
        Me.linkPartneri_add.TabStop = True
        Me.linkPartneri_add.Text = "Unos"
        '
        'linkPartneri_search
        '
        Me.linkPartneri_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkPartneri_search.AutoSize = True
        Me.linkPartneri_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkPartneri_search.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkPartneri_search.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkPartneri_search.Location = New System.Drawing.Point(3, 3)
        Me.linkPartneri_search.Name = "linkPartneri_search"
        Me.linkPartneri_search.Size = New System.Drawing.Size(204, 13)
        Me.linkPartneri_search.TabIndex = 11
        Me.linkPartneri_search.TabStop = True
        Me.linkPartneri_search.Text = "Pretraga"
        '
        'btnOJ
        '
        Me.btnOJ.Location = New System.Drawing.Point(3, 145)
        Me.btnOJ.Name = "btnOJ"
        Me.btnOJ.Size = New System.Drawing.Size(218, 23)
        Me.btnOJ.TabIndex = 13
        Me.btnOJ.Text = "ORG. JEDINICE"
        Me.btnOJ.UseVisualStyleBackColor = True
        '
        'btnNaselja
        '
        Me.btnNaselja.Location = New System.Drawing.Point(3, 287)
        Me.btnNaselja.Name = "btnNaselja"
        Me.btnNaselja.Size = New System.Drawing.Size(218, 23)
        Me.btnNaselja.TabIndex = 14
        Me.btnNaselja.Text = "NASELJA"
        Me.btnNaselja.UseVisualStyleBackColor = True
        '
        'panOJ_Kontejner
        '
        Me.panOJ_Kontejner.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panOJ_Kontejner.ColumnCount = 2
        Me.panOJ_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panOJ_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panOJ_Kontejner.Controls.Add(Me.Label3, 0, 0)
        Me.panOJ_Kontejner.Controls.Add(Me.panOJ_meni, 1, 0)
        Me.panOJ_Kontejner.Location = New System.Drawing.Point(3, 175)
        Me.panOJ_Kontejner.Name = "panOJ_Kontejner"
        Me.panOJ_Kontejner.RowCount = 1
        Me.panOJ_Kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panOJ_Kontejner.Size = New System.Drawing.Size(246, 106)
        Me.panOJ_Kontejner.TabIndex = 25
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
        'panOJ_meni
        '
        Me.panOJ_meni.ColumnCount = 1
        Me.panOJ_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panOJ_meni.Controls.Add(Me.linkOJ_search, 0, 0)
        Me.panOJ_meni.Controls.Add(Me.linkOJPrint, 0, 4)
        Me.panOJ_meni.Controls.Add(Me.linkOJBrisanje, 0, 3)
        Me.panOJ_meni.Controls.Add(Me.linkOJEdit, 0, 2)
        Me.panOJ_meni.Controls.Add(Me.linkOJUnos, 0, 1)
        Me.panOJ_meni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panOJ_meni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panOJ_meni.Location = New System.Drawing.Point(33, 3)
        Me.panOJ_meni.Name = "panOJ_meni"
        Me.panOJ_meni.RowCount = 5
        Me.panOJ_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panOJ_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panOJ_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panOJ_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panOJ_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panOJ_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panOJ_meni.Size = New System.Drawing.Size(210, 100)
        Me.panOJ_meni.TabIndex = 23
        '
        'linkOJ_search
        '
        Me.linkOJ_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkOJ_search.AutoSize = True
        Me.linkOJ_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkOJ_search.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkOJ_search.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkOJ_search.Location = New System.Drawing.Point(3, 3)
        Me.linkOJ_search.Name = "linkOJ_search"
        Me.linkOJ_search.Size = New System.Drawing.Size(204, 13)
        Me.linkOJ_search.TabIndex = 26
        Me.linkOJ_search.TabStop = True
        Me.linkOJ_search.Text = "Pretraga"
        '
        'linkOJPrint
        '
        Me.linkOJPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkOJPrint.AutoSize = True
        Me.linkOJPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkOJPrint.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkOJPrint.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkOJPrint.Location = New System.Drawing.Point(3, 83)
        Me.linkOJPrint.Name = "linkOJPrint"
        Me.linkOJPrint.Size = New System.Drawing.Size(204, 13)
        Me.linkOJPrint.TabIndex = 3
        Me.linkOJPrint.TabStop = True
        Me.linkOJPrint.Text = "Štampanje"
        '
        'linkOJBrisanje
        '
        Me.linkOJBrisanje.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkOJBrisanje.AutoSize = True
        Me.linkOJBrisanje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkOJBrisanje.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkOJBrisanje.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkOJBrisanje.Location = New System.Drawing.Point(3, 63)
        Me.linkOJBrisanje.Name = "linkOJBrisanje"
        Me.linkOJBrisanje.Size = New System.Drawing.Size(204, 13)
        Me.linkOJBrisanje.TabIndex = 5
        Me.linkOJBrisanje.TabStop = True
        Me.linkOJBrisanje.Text = "Brisanje"
        '
        'linkOJEdit
        '
        Me.linkOJEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkOJEdit.AutoSize = True
        Me.linkOJEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkOJEdit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkOJEdit.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkOJEdit.Location = New System.Drawing.Point(3, 43)
        Me.linkOJEdit.Name = "linkOJEdit"
        Me.linkOJEdit.Size = New System.Drawing.Size(204, 13)
        Me.linkOJEdit.TabIndex = 2
        Me.linkOJEdit.TabStop = True
        Me.linkOJEdit.Text = "Izmene"
        '
        'linkOJUnos
        '
        Me.linkOJUnos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkOJUnos.AutoSize = True
        Me.linkOJUnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkOJUnos.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkOJUnos.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkOJUnos.Location = New System.Drawing.Point(3, 23)
        Me.linkOJUnos.Name = "linkOJUnos"
        Me.linkOJUnos.Size = New System.Drawing.Size(204, 13)
        Me.linkOJUnos.TabIndex = 1
        Me.linkOJUnos.TabStop = True
        Me.linkOJUnos.Text = "Unos"
        '
        'cntMeniPartneri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.tableButtons)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntMeniPartneri"
        Me.Size = New System.Drawing.Size(252, 507)
        Me.tableButtons.ResumeLayout(False)
        Me.panNaselja_Kontejner.ResumeLayout(False)
        Me.panNaselja_meni.ResumeLayout(False)
        Me.panNaselja_meni.PerformLayout()
        Me.panPartneri_Kontejner.ResumeLayout(False)
        Me.panPartneri_meni.ResumeLayout(False)
        Me.panPartneri_meni.PerformLayout()
        Me.panOJ_Kontejner.ResumeLayout(False)
        Me.panOJ_meni.ResumeLayout(False)
        Me.panOJ_meni.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tableButtons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnPartneri As System.Windows.Forms.Button
    Friend WithEvents btnOJ As System.Windows.Forms.Button
    Friend WithEvents btnNaselja As System.Windows.Forms.Button
    Friend WithEvents btnNazad As System.Windows.Forms.Button
    Friend WithEvents panPartneri_Kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panPartneri_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkPartneri_print As System.Windows.Forms.LinkLabel
    Friend WithEvents linkPartneri_del As System.Windows.Forms.LinkLabel
    Friend WithEvents linkPartneri_edit As System.Windows.Forms.LinkLabel
    Friend WithEvents linkPartneri_add As System.Windows.Forms.LinkLabel
    Friend WithEvents linkPartneri_search As System.Windows.Forms.LinkLabel
    Friend WithEvents panOJ_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkNaseljaEdit As System.Windows.Forms.LinkLabel
    Friend WithEvents linkNaseljaUnos As System.Windows.Forms.LinkLabel
    Friend WithEvents linkNaseljaPrint As System.Windows.Forms.LinkLabel
    Friend WithEvents linkNaseljaBrisanje As System.Windows.Forms.LinkLabel
    Friend WithEvents panNaselja_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkOJEdit As System.Windows.Forms.LinkLabel
    Friend WithEvents linkOJUnos As System.Windows.Forms.LinkLabel
    Friend WithEvents linkOJPrint As System.Windows.Forms.LinkLabel
    Friend WithEvents linkOJBrisanje As System.Windows.Forms.LinkLabel
    Friend WithEvents panNaselja_Kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents panOJ_Kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents linkOJ_search As System.Windows.Forms.LinkLabel
    Friend WithEvents linkNaselja_search As System.Windows.Forms.LinkLabel

End Class
