<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntMeniArtikli
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
        Me.panJM_Kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.panJM_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkJM_edit = New System.Windows.Forms.LinkLabel
        Me.linkJM_add = New System.Windows.Forms.LinkLabel
        Me.linkJM_print = New System.Windows.Forms.LinkLabel
        Me.linkJM_del = New System.Windows.Forms.LinkLabel
        Me.linkJM_search = New System.Windows.Forms.LinkLabel
        Me.Label5 = New System.Windows.Forms.Label
        Me.panFO_Kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.panFO_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkFO_edit = New System.Windows.Forms.LinkLabel
        Me.linkFO_add = New System.Windows.Forms.LinkLabel
        Me.linkFO_print = New System.Windows.Forms.LinkLabel
        Me.linkFO_del = New System.Windows.Forms.LinkLabel
        Me.linkFO_search = New System.Windows.Forms.LinkLabel
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnFO = New System.Windows.Forms.Button
        Me.panArtikli_Kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.panArtikli_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkPozitivna_lista = New System.Windows.Forms.LinkLabel
        Me.linkArtikli_del = New System.Windows.Forms.LinkLabel
        Me.linkArtikli_edit = New System.Windows.Forms.LinkLabel
        Me.linkArtikli_add = New System.Windows.Forms.LinkLabel
        Me.linkArtikli_search = New System.Windows.Forms.LinkLabel
        Me.linkArtikli_print = New System.Windows.Forms.LinkLabel
        Me.btnNazad = New System.Windows.Forms.Button
        Me.btnArtikli = New System.Windows.Forms.Button
        Me.btnJm = New System.Windows.Forms.Button
        Me.btnGrupeArt = New System.Windows.Forms.Button
        Me.btnGenericko = New System.Windows.Forms.Button
        Me.panGrupe_Kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.Label4 = New System.Windows.Forms.Label
        Me.panGrupe_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkGrupe_edit = New System.Windows.Forms.LinkLabel
        Me.linkGrupe_add = New System.Windows.Forms.LinkLabel
        Me.linkGrupe_print = New System.Windows.Forms.LinkLabel
        Me.linkGrupe_search = New System.Windows.Forms.LinkLabel
        Me.linkGrupe_del = New System.Windows.Forms.LinkLabel
        Me.panGenerIme_Kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.panGenerIme_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkGenericko_edit = New System.Windows.Forms.LinkLabel
        Me.linkGenericko_add = New System.Windows.Forms.LinkLabel
        Me.linkGenericko_print = New System.Windows.Forms.LinkLabel
        Me.linkGenericko_del = New System.Windows.Forms.LinkLabel
        Me.linkGenericko_search = New System.Windows.Forms.LinkLabel
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnAlati = New System.Windows.Forms.Button
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Label6 = New System.Windows.Forms.Label
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel
        Me.tableButtons.SuspendLayout()
        Me.panJM_Kontejner.SuspendLayout()
        Me.panJM_meni.SuspendLayout()
        Me.panFO_Kontejner.SuspendLayout()
        Me.panFO_meni.SuspendLayout()
        Me.panArtikli_Kontejner.SuspendLayout()
        Me.panArtikli_meni.SuspendLayout()
        Me.panGrupe_Kontejner.SuspendLayout()
        Me.panGrupe_meni.SuspendLayout()
        Me.panGenerIme_Kontejner.SuspendLayout()
        Me.panGenerIme_meni.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableButtons
        '
        Me.tableButtons.ColumnCount = 1
        Me.tableButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableButtons.Controls.Add(Me.panJM_Kontejner, 0, 9)
        Me.tableButtons.Controls.Add(Me.panFO_Kontejner, 0, 7)
        Me.tableButtons.Controls.Add(Me.btnFO, 0, 6)
        Me.tableButtons.Controls.Add(Me.panArtikli_Kontejner, 0, 1)
        Me.tableButtons.Controls.Add(Me.btnNazad, 0, 10)
        Me.tableButtons.Controls.Add(Me.btnArtikli, 0, 0)
        Me.tableButtons.Controls.Add(Me.btnJm, 0, 8)
        Me.tableButtons.Controls.Add(Me.btnGrupeArt, 0, 2)
        Me.tableButtons.Controls.Add(Me.btnGenericko, 0, 4)
        Me.tableButtons.Controls.Add(Me.panGrupe_Kontejner, 0, 3)
        Me.tableButtons.Controls.Add(Me.panGenerIme_Kontejner, 0, 5)
        Me.tableButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tableButtons.Location = New System.Drawing.Point(0, 65)
        Me.tableButtons.Name = "tableButtons"
        Me.tableButtons.RowCount = 11
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.Size = New System.Drawing.Size(225, 220)
        Me.tableButtons.TabIndex = 3
        '
        'panJM_Kontejner
        '
        Me.panJM_Kontejner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panJM_Kontejner.ColumnCount = 2
        Me.panJM_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panJM_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panJM_Kontejner.Controls.Add(Me.panJM_meni, 1, 0)
        Me.panJM_Kontejner.Controls.Add(Me.Label5, 0, 0)
        Me.panJM_Kontejner.Location = New System.Drawing.Point(3, 185)
        Me.panJM_Kontejner.Name = "panJM_Kontejner"
        Me.panJM_Kontejner.RowCount = 1
        Me.panJM_Kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panJM_Kontejner.Size = New System.Drawing.Size(180, 2)
        Me.panJM_Kontejner.TabIndex = 31
        '
        'panJM_meni
        '
        Me.panJM_meni.ColumnCount = 1
        Me.panJM_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panJM_meni.Controls.Add(Me.linkJM_edit, 0, 2)
        Me.panJM_meni.Controls.Add(Me.linkJM_add, 0, 1)
        Me.panJM_meni.Controls.Add(Me.linkJM_print, 0, 4)
        Me.panJM_meni.Controls.Add(Me.linkJM_del, 0, 3)
        Me.panJM_meni.Controls.Add(Me.linkJM_search, 0, 0)
        Me.panJM_meni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panJM_meni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panJM_meni.Location = New System.Drawing.Point(33, 3)
        Me.panJM_meni.Name = "panJM_meni"
        Me.panJM_meni.RowCount = 5
        Me.panJM_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panJM_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panJM_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panJM_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panJM_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panJM_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panJM_meni.Size = New System.Drawing.Size(144, 1)
        Me.panJM_meni.TabIndex = 28
        '
        'linkJM_edit
        '
        Me.linkJM_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkJM_edit.AutoSize = True
        Me.linkJM_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkJM_edit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkJM_edit.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkJM_edit.Location = New System.Drawing.Point(3, 43)
        Me.linkJM_edit.Name = "linkJM_edit"
        Me.linkJM_edit.Size = New System.Drawing.Size(138, 13)
        Me.linkJM_edit.TabIndex = 2
        Me.linkJM_edit.TabStop = True
        Me.linkJM_edit.Text = "Izmene"
        '
        'linkJM_add
        '
        Me.linkJM_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkJM_add.AutoSize = True
        Me.linkJM_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkJM_add.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkJM_add.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkJM_add.Location = New System.Drawing.Point(3, 23)
        Me.linkJM_add.Name = "linkJM_add"
        Me.linkJM_add.Size = New System.Drawing.Size(138, 13)
        Me.linkJM_add.TabIndex = 1
        Me.linkJM_add.TabStop = True
        Me.linkJM_add.Text = "Unos"
        '
        'linkJM_print
        '
        Me.linkJM_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkJM_print.AutoSize = True
        Me.linkJM_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkJM_print.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkJM_print.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkJM_print.Location = New System.Drawing.Point(3, 83)
        Me.linkJM_print.Name = "linkJM_print"
        Me.linkJM_print.Size = New System.Drawing.Size(138, 13)
        Me.linkJM_print.TabIndex = 3
        Me.linkJM_print.TabStop = True
        Me.linkJM_print.Text = "Štampanje"
        '
        'linkJM_del
        '
        Me.linkJM_del.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkJM_del.AutoSize = True
        Me.linkJM_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkJM_del.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkJM_del.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkJM_del.Location = New System.Drawing.Point(3, 63)
        Me.linkJM_del.Name = "linkJM_del"
        Me.linkJM_del.Size = New System.Drawing.Size(138, 13)
        Me.linkJM_del.TabIndex = 5
        Me.linkJM_del.TabStop = True
        Me.linkJM_del.Text = "Brisanje"
        '
        'linkJM_search
        '
        Me.linkJM_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkJM_search.AutoSize = True
        Me.linkJM_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkJM_search.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkJM_search.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkJM_search.Location = New System.Drawing.Point(3, 3)
        Me.linkJM_search.Name = "linkJM_search"
        Me.linkJM_search.Size = New System.Drawing.Size(138, 13)
        Me.linkJM_search.TabIndex = 11
        Me.linkJM_search.TabStop = True
        Me.linkJM_search.Text = "Pretraga"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lavender
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 2)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "O P C  I  J  E"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panFO_Kontejner
        '
        Me.panFO_Kontejner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panFO_Kontejner.ColumnCount = 2
        Me.panFO_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panFO_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panFO_Kontejner.Controls.Add(Me.panFO_meni, 1, 0)
        Me.panFO_Kontejner.Controls.Add(Me.Label2, 0, 0)
        Me.panFO_Kontejner.Location = New System.Drawing.Point(3, 147)
        Me.panFO_Kontejner.Name = "panFO_Kontejner"
        Me.panFO_Kontejner.RowCount = 1
        Me.panFO_Kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panFO_Kontejner.Size = New System.Drawing.Size(180, 2)
        Me.panFO_Kontejner.TabIndex = 31
        '
        'panFO_meni
        '
        Me.panFO_meni.ColumnCount = 1
        Me.panFO_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panFO_meni.Controls.Add(Me.linkFO_edit, 0, 2)
        Me.panFO_meni.Controls.Add(Me.linkFO_add, 0, 1)
        Me.panFO_meni.Controls.Add(Me.linkFO_print, 0, 4)
        Me.panFO_meni.Controls.Add(Me.linkFO_del, 0, 3)
        Me.panFO_meni.Controls.Add(Me.linkFO_search, 0, 0)
        Me.panFO_meni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panFO_meni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panFO_meni.Location = New System.Drawing.Point(33, 3)
        Me.panFO_meni.Name = "panFO_meni"
        Me.panFO_meni.RowCount = 5
        Me.panFO_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panFO_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panFO_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panFO_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panFO_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panFO_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panFO_meni.Size = New System.Drawing.Size(144, 1)
        Me.panFO_meni.TabIndex = 28
        '
        'linkFO_edit
        '
        Me.linkFO_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkFO_edit.AutoSize = True
        Me.linkFO_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkFO_edit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkFO_edit.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkFO_edit.Location = New System.Drawing.Point(3, 43)
        Me.linkFO_edit.Name = "linkFO_edit"
        Me.linkFO_edit.Size = New System.Drawing.Size(138, 13)
        Me.linkFO_edit.TabIndex = 2
        Me.linkFO_edit.TabStop = True
        Me.linkFO_edit.Text = "Izmene"
        '
        'linkFO_add
        '
        Me.linkFO_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkFO_add.AutoSize = True
        Me.linkFO_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkFO_add.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkFO_add.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkFO_add.Location = New System.Drawing.Point(3, 23)
        Me.linkFO_add.Name = "linkFO_add"
        Me.linkFO_add.Size = New System.Drawing.Size(138, 13)
        Me.linkFO_add.TabIndex = 1
        Me.linkFO_add.TabStop = True
        Me.linkFO_add.Text = "Unos"
        '
        'linkFO_print
        '
        Me.linkFO_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkFO_print.AutoSize = True
        Me.linkFO_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkFO_print.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkFO_print.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkFO_print.Location = New System.Drawing.Point(3, 83)
        Me.linkFO_print.Name = "linkFO_print"
        Me.linkFO_print.Size = New System.Drawing.Size(138, 13)
        Me.linkFO_print.TabIndex = 3
        Me.linkFO_print.TabStop = True
        Me.linkFO_print.Text = "Štampanje"
        '
        'linkFO_del
        '
        Me.linkFO_del.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkFO_del.AutoSize = True
        Me.linkFO_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkFO_del.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkFO_del.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkFO_del.Location = New System.Drawing.Point(3, 63)
        Me.linkFO_del.Name = "linkFO_del"
        Me.linkFO_del.Size = New System.Drawing.Size(138, 13)
        Me.linkFO_del.TabIndex = 5
        Me.linkFO_del.TabStop = True
        Me.linkFO_del.Text = "Brisanje"
        '
        'linkFO_search
        '
        Me.linkFO_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkFO_search.AutoSize = True
        Me.linkFO_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkFO_search.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkFO_search.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkFO_search.Location = New System.Drawing.Point(3, 3)
        Me.linkFO_search.Name = "linkFO_search"
        Me.linkFO_search.Size = New System.Drawing.Size(138, 13)
        Me.linkFO_search.TabIndex = 11
        Me.linkFO_search.TabStop = True
        Me.linkFO_search.Text = "Pretraga"
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
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "O P C  I  J  E"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFO
        '
        Me.btnFO.Location = New System.Drawing.Point(3, 117)
        Me.btnFO.Name = "btnFO"
        Me.btnFO.Size = New System.Drawing.Size(194, 23)
        Me.btnFO.TabIndex = 18
        Me.btnFO.Text = "FARMACEUTSKI OBLIK"
        Me.btnFO.UseVisualStyleBackColor = True
        '
        'panArtikli_Kontejner
        '
        Me.panArtikli_Kontejner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panArtikli_Kontejner.ColumnCount = 2
        Me.panArtikli_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panArtikli_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panArtikli_Kontejner.Controls.Add(Me.Label1, 0, 0)
        Me.panArtikli_Kontejner.Controls.Add(Me.panArtikli_meni, 1, 0)
        Me.panArtikli_Kontejner.Location = New System.Drawing.Point(3, 33)
        Me.panArtikli_Kontejner.Name = "panArtikli_Kontejner"
        Me.panArtikli_Kontejner.RowCount = 1
        Me.panArtikli_Kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panArtikli_Kontejner.Size = New System.Drawing.Size(180, 2)
        Me.panArtikli_Kontejner.TabIndex = 9
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
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "O P C  I  J  E"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panArtikli_meni
        '
        Me.panArtikli_meni.ColumnCount = 1
        Me.panArtikli_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panArtikli_meni.Controls.Add(Me.linkPozitivna_lista, 0, 5)
        Me.panArtikli_meni.Controls.Add(Me.linkArtikli_del, 0, 3)
        Me.panArtikli_meni.Controls.Add(Me.linkArtikli_edit, 0, 2)
        Me.panArtikli_meni.Controls.Add(Me.linkArtikli_add, 0, 1)
        Me.panArtikli_meni.Controls.Add(Me.linkArtikli_search, 0, 0)
        Me.panArtikli_meni.Controls.Add(Me.linkArtikli_print, 0, 4)
        Me.panArtikli_meni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panArtikli_meni.Location = New System.Drawing.Point(33, 3)
        Me.panArtikli_meni.Name = "panArtikli_meni"
        Me.panArtikli_meni.RowCount = 6
        Me.panArtikli_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panArtikli_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panArtikli_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panArtikli_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panArtikli_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panArtikli_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panArtikli_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panArtikli_meni.Size = New System.Drawing.Size(144, 1)
        Me.panArtikli_meni.TabIndex = 22
        '
        'linkPozitivna_lista
        '
        Me.linkPozitivna_lista.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkPozitivna_lista.AutoSize = True
        Me.linkPozitivna_lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkPozitivna_lista.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkPozitivna_lista.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkPozitivna_lista.Location = New System.Drawing.Point(3, 103)
        Me.linkPozitivna_lista.Name = "linkPozitivna_lista"
        Me.linkPozitivna_lista.Size = New System.Drawing.Size(138, 13)
        Me.linkPozitivna_lista.TabIndex = 11
        Me.linkPozitivna_lista.TabStop = True
        Me.linkPozitivna_lista.Text = "Pozitivna lista"
        '
        'linkArtikli_del
        '
        Me.linkArtikli_del.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkArtikli_del.AutoSize = True
        Me.linkArtikli_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkArtikli_del.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkArtikli_del.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkArtikli_del.Location = New System.Drawing.Point(3, 63)
        Me.linkArtikli_del.Name = "linkArtikli_del"
        Me.linkArtikli_del.Size = New System.Drawing.Size(138, 13)
        Me.linkArtikli_del.TabIndex = 9
        Me.linkArtikli_del.TabStop = True
        Me.linkArtikli_del.Text = "Brisanje"
        '
        'linkArtikli_edit
        '
        Me.linkArtikli_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkArtikli_edit.AutoSize = True
        Me.linkArtikli_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkArtikli_edit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkArtikli_edit.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkArtikli_edit.Location = New System.Drawing.Point(3, 43)
        Me.linkArtikli_edit.Name = "linkArtikli_edit"
        Me.linkArtikli_edit.Size = New System.Drawing.Size(138, 13)
        Me.linkArtikli_edit.TabIndex = 3
        Me.linkArtikli_edit.TabStop = True
        Me.linkArtikli_edit.Text = "Izmene"
        '
        'linkArtikli_add
        '
        Me.linkArtikli_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkArtikli_add.AutoSize = True
        Me.linkArtikli_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkArtikli_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.linkArtikli_add.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkArtikli_add.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkArtikli_add.Location = New System.Drawing.Point(3, 23)
        Me.linkArtikli_add.Name = "linkArtikli_add"
        Me.linkArtikli_add.Size = New System.Drawing.Size(138, 13)
        Me.linkArtikli_add.TabIndex = 2
        Me.linkArtikli_add.TabStop = True
        Me.linkArtikli_add.Text = "Unos"
        '
        'linkArtikli_search
        '
        Me.linkArtikli_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkArtikli_search.AutoSize = True
        Me.linkArtikli_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkArtikli_search.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkArtikli_search.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkArtikli_search.Location = New System.Drawing.Point(3, 3)
        Me.linkArtikli_search.Name = "linkArtikli_search"
        Me.linkArtikli_search.Size = New System.Drawing.Size(138, 13)
        Me.linkArtikli_search.TabIndex = 11
        Me.linkArtikli_search.TabStop = True
        Me.linkArtikli_search.Text = "Pretraga"
        '
        'linkArtikli_print
        '
        Me.linkArtikli_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkArtikli_print.AutoSize = True
        Me.linkArtikli_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkArtikli_print.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkArtikli_print.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkArtikli_print.Location = New System.Drawing.Point(3, 83)
        Me.linkArtikli_print.Name = "linkArtikli_print"
        Me.linkArtikli_print.Size = New System.Drawing.Size(138, 13)
        Me.linkArtikli_print.TabIndex = 4
        Me.linkArtikli_print.TabStop = True
        Me.linkArtikli_print.Text = "Štampanje"
        '
        'btnNazad
        '
        Me.btnNazad.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnNazad.Location = New System.Drawing.Point(3, 193)
        Me.btnNazad.Name = "btnNazad"
        Me.btnNazad.Size = New System.Drawing.Size(205, 24)
        Me.btnNazad.TabIndex = 10
        Me.btnNazad.Text = "NAZAD"
        Me.btnNazad.UseVisualStyleBackColor = True
        '
        'btnArtikli
        '
        Me.btnArtikli.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnArtikli.Location = New System.Drawing.Point(3, 3)
        Me.btnArtikli.Name = "btnArtikli"
        Me.btnArtikli.Size = New System.Drawing.Size(194, 24)
        Me.btnArtikli.TabIndex = 4
        Me.btnArtikli.Text = "ARTIKLI"
        Me.btnArtikli.UseVisualStyleBackColor = True
        '
        'btnJm
        '
        Me.btnJm.Location = New System.Drawing.Point(3, 155)
        Me.btnJm.Name = "btnJm"
        Me.btnJm.Size = New System.Drawing.Size(194, 23)
        Me.btnJm.TabIndex = 13
        Me.btnJm.Text = "JM"
        Me.btnJm.UseVisualStyleBackColor = True
        '
        'btnGrupeArt
        '
        Me.btnGrupeArt.Location = New System.Drawing.Point(3, 41)
        Me.btnGrupeArt.Name = "btnGrupeArt"
        Me.btnGrupeArt.Size = New System.Drawing.Size(194, 23)
        Me.btnGrupeArt.TabIndex = 16
        Me.btnGrupeArt.Text = "GRUPE ARTIKLA"
        Me.btnGrupeArt.UseVisualStyleBackColor = True
        '
        'btnGenericko
        '
        Me.btnGenericko.Location = New System.Drawing.Point(3, 79)
        Me.btnGenericko.Name = "btnGenericko"
        Me.btnGenericko.Size = New System.Drawing.Size(194, 23)
        Me.btnGenericko.TabIndex = 17
        Me.btnGenericko.Text = "GENERIČKO IME"
        Me.btnGenericko.UseVisualStyleBackColor = True
        '
        'panGrupe_Kontejner
        '
        Me.panGrupe_Kontejner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panGrupe_Kontejner.ColumnCount = 2
        Me.panGrupe_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panGrupe_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panGrupe_Kontejner.Controls.Add(Me.Label4, 0, 0)
        Me.panGrupe_Kontejner.Controls.Add(Me.panGrupe_meni, 1, 0)
        Me.panGrupe_Kontejner.Location = New System.Drawing.Point(3, 71)
        Me.panGrupe_Kontejner.Name = "panGrupe_Kontejner"
        Me.panGrupe_Kontejner.RowCount = 1
        Me.panGrupe_Kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panGrupe_Kontejner.Size = New System.Drawing.Size(180, 2)
        Me.panGrupe_Kontejner.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lavender
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 2)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "O P C  I  J  E"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panGrupe_meni
        '
        Me.panGrupe_meni.ColumnCount = 1
        Me.panGrupe_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panGrupe_meni.Controls.Add(Me.linkGrupe_edit, 0, 2)
        Me.panGrupe_meni.Controls.Add(Me.linkGrupe_add, 0, 1)
        Me.panGrupe_meni.Controls.Add(Me.linkGrupe_print, 0, 4)
        Me.panGrupe_meni.Controls.Add(Me.linkGrupe_search, 0, 0)
        Me.panGrupe_meni.Controls.Add(Me.linkGrupe_del, 0, 3)
        Me.panGrupe_meni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panGrupe_meni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panGrupe_meni.Location = New System.Drawing.Point(33, 3)
        Me.panGrupe_meni.Name = "panGrupe_meni"
        Me.panGrupe_meni.RowCount = 5
        Me.panGrupe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panGrupe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panGrupe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panGrupe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panGrupe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panGrupe_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panGrupe_meni.Size = New System.Drawing.Size(144, 1)
        Me.panGrupe_meni.TabIndex = 14
        '
        'linkGrupe_edit
        '
        Me.linkGrupe_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkGrupe_edit.AutoSize = True
        Me.linkGrupe_edit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkGrupe_edit.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkGrupe_edit.Location = New System.Drawing.Point(3, 43)
        Me.linkGrupe_edit.Name = "linkGrupe_edit"
        Me.linkGrupe_edit.Size = New System.Drawing.Size(138, 13)
        Me.linkGrupe_edit.TabIndex = 2
        Me.linkGrupe_edit.TabStop = True
        Me.linkGrupe_edit.Text = "Izmene"
        '
        'linkGrupe_add
        '
        Me.linkGrupe_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkGrupe_add.AutoSize = True
        Me.linkGrupe_add.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkGrupe_add.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkGrupe_add.Location = New System.Drawing.Point(3, 23)
        Me.linkGrupe_add.Name = "linkGrupe_add"
        Me.linkGrupe_add.Size = New System.Drawing.Size(138, 13)
        Me.linkGrupe_add.TabIndex = 1
        Me.linkGrupe_add.TabStop = True
        Me.linkGrupe_add.Text = "Unos"
        '
        'linkGrupe_print
        '
        Me.linkGrupe_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkGrupe_print.AutoSize = True
        Me.linkGrupe_print.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkGrupe_print.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkGrupe_print.Location = New System.Drawing.Point(3, 83)
        Me.linkGrupe_print.Name = "linkGrupe_print"
        Me.linkGrupe_print.Size = New System.Drawing.Size(138, 13)
        Me.linkGrupe_print.TabIndex = 3
        Me.linkGrupe_print.TabStop = True
        Me.linkGrupe_print.Text = "Štampanje"
        '
        'linkGrupe_search
        '
        Me.linkGrupe_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkGrupe_search.AutoSize = True
        Me.linkGrupe_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkGrupe_search.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkGrupe_search.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkGrupe_search.Location = New System.Drawing.Point(3, 3)
        Me.linkGrupe_search.Name = "linkGrupe_search"
        Me.linkGrupe_search.Size = New System.Drawing.Size(138, 13)
        Me.linkGrupe_search.TabIndex = 11
        Me.linkGrupe_search.TabStop = True
        Me.linkGrupe_search.Text = "Pretraga"
        '
        'linkGrupe_del
        '
        Me.linkGrupe_del.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkGrupe_del.AutoSize = True
        Me.linkGrupe_del.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkGrupe_del.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkGrupe_del.Location = New System.Drawing.Point(3, 63)
        Me.linkGrupe_del.Name = "linkGrupe_del"
        Me.linkGrupe_del.Size = New System.Drawing.Size(138, 13)
        Me.linkGrupe_del.TabIndex = 5
        Me.linkGrupe_del.TabStop = True
        Me.linkGrupe_del.Text = "Brisanje"
        '
        'panGenerIme_Kontejner
        '
        Me.panGenerIme_Kontejner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panGenerIme_Kontejner.ColumnCount = 2
        Me.panGenerIme_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panGenerIme_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panGenerIme_Kontejner.Controls.Add(Me.panGenerIme_meni, 1, 0)
        Me.panGenerIme_Kontejner.Controls.Add(Me.Label3, 0, 0)
        Me.panGenerIme_Kontejner.Location = New System.Drawing.Point(3, 109)
        Me.panGenerIme_Kontejner.Name = "panGenerIme_Kontejner"
        Me.panGenerIme_Kontejner.RowCount = 1
        Me.panGenerIme_Kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panGenerIme_Kontejner.Size = New System.Drawing.Size(180, 2)
        Me.panGenerIme_Kontejner.TabIndex = 30
        '
        'panGenerIme_meni
        '
        Me.panGenerIme_meni.ColumnCount = 1
        Me.panGenerIme_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panGenerIme_meni.Controls.Add(Me.linkGenericko_edit, 0, 2)
        Me.panGenerIme_meni.Controls.Add(Me.linkGenericko_add, 0, 1)
        Me.panGenerIme_meni.Controls.Add(Me.linkGenericko_print, 0, 4)
        Me.panGenerIme_meni.Controls.Add(Me.linkGenericko_del, 0, 3)
        Me.panGenerIme_meni.Controls.Add(Me.linkGenericko_search, 0, 0)
        Me.panGenerIme_meni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panGenerIme_meni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panGenerIme_meni.Location = New System.Drawing.Point(33, 3)
        Me.panGenerIme_meni.Name = "panGenerIme_meni"
        Me.panGenerIme_meni.RowCount = 5
        Me.panGenerIme_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panGenerIme_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panGenerIme_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panGenerIme_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panGenerIme_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panGenerIme_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panGenerIme_meni.Size = New System.Drawing.Size(144, 1)
        Me.panGenerIme_meni.TabIndex = 28
        '
        'linkGenericko_edit
        '
        Me.linkGenericko_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkGenericko_edit.AutoSize = True
        Me.linkGenericko_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkGenericko_edit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkGenericko_edit.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkGenericko_edit.Location = New System.Drawing.Point(3, 43)
        Me.linkGenericko_edit.Name = "linkGenericko_edit"
        Me.linkGenericko_edit.Size = New System.Drawing.Size(138, 13)
        Me.linkGenericko_edit.TabIndex = 2
        Me.linkGenericko_edit.TabStop = True
        Me.linkGenericko_edit.Text = "Izmene"
        '
        'linkGenericko_add
        '
        Me.linkGenericko_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkGenericko_add.AutoSize = True
        Me.linkGenericko_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkGenericko_add.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkGenericko_add.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkGenericko_add.Location = New System.Drawing.Point(3, 23)
        Me.linkGenericko_add.Name = "linkGenericko_add"
        Me.linkGenericko_add.Size = New System.Drawing.Size(138, 13)
        Me.linkGenericko_add.TabIndex = 1
        Me.linkGenericko_add.TabStop = True
        Me.linkGenericko_add.Text = "Unos"
        '
        'linkGenericko_print
        '
        Me.linkGenericko_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkGenericko_print.AutoSize = True
        Me.linkGenericko_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkGenericko_print.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkGenericko_print.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkGenericko_print.Location = New System.Drawing.Point(3, 83)
        Me.linkGenericko_print.Name = "linkGenericko_print"
        Me.linkGenericko_print.Size = New System.Drawing.Size(138, 13)
        Me.linkGenericko_print.TabIndex = 3
        Me.linkGenericko_print.TabStop = True
        Me.linkGenericko_print.Text = "Štampanje"
        '
        'linkGenericko_del
        '
        Me.linkGenericko_del.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkGenericko_del.AutoSize = True
        Me.linkGenericko_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkGenericko_del.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkGenericko_del.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkGenericko_del.Location = New System.Drawing.Point(3, 63)
        Me.linkGenericko_del.Name = "linkGenericko_del"
        Me.linkGenericko_del.Size = New System.Drawing.Size(138, 13)
        Me.linkGenericko_del.TabIndex = 5
        Me.linkGenericko_del.TabStop = True
        Me.linkGenericko_del.Text = "Brisanje"
        '
        'linkGenericko_search
        '
        Me.linkGenericko_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkGenericko_search.AutoSize = True
        Me.linkGenericko_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkGenericko_search.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkGenericko_search.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkGenericko_search.Location = New System.Drawing.Point(3, 3)
        Me.linkGenericko_search.Name = "linkGenericko_search"
        Me.linkGenericko_search.Size = New System.Drawing.Size(138, 13)
        Me.linkGenericko_search.TabIndex = 11
        Me.linkGenericko_search.TabStop = True
        Me.linkGenericko_search.Text = "Pretraga"
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
        'btnAlati
        '
        Me.btnAlati.Location = New System.Drawing.Point(9, 12)
        Me.btnAlati.Name = "btnAlati"
        Me.btnAlati.Size = New System.Drawing.Size(49, 23)
        Me.btnAlati.TabIndex = 4
        Me.btnAlati.Text = "Alati"
        Me.btnAlati.UseVisualStyleBackColor = True
        Me.btnAlati.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(17, 41)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(180, 18)
        Me.TableLayoutPanel1.TabIndex = 10
        Me.TableLayoutPanel1.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lavender
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "O P C  I  J  E"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.LinkLabel1, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.LinkLabel2, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.LinkLabel3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LinkLabel4, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LinkLabel5, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LinkLabel6, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.LinkLabel7, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.LinkLabel8, 0, 6)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(33, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(144, 12)
        Me.TableLayoutPanel2.TabIndex = 22
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.MidnightBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 103)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(138, 13)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Pozitivna lista"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.MidnightBlue
        Me.LinkLabel2.Location = New System.Drawing.Point(3, 63)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(138, 13)
        Me.LinkLabel2.TabIndex = 9
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Brisanje"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel3.LinkColor = System.Drawing.Color.MidnightBlue
        Me.LinkLabel3.Location = New System.Drawing.Point(3, 43)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(138, 13)
        Me.LinkLabel3.TabIndex = 3
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Izmene"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LinkLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel4.LinkColor = System.Drawing.Color.MidnightBlue
        Me.LinkLabel4.Location = New System.Drawing.Point(3, 23)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(138, 13)
        Me.LinkLabel4.TabIndex = 2
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Unos"
        '
        'LinkLabel5
        '
        Me.LinkLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LinkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel5.LinkColor = System.Drawing.Color.MidnightBlue
        Me.LinkLabel5.Location = New System.Drawing.Point(3, 3)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(138, 13)
        Me.LinkLabel5.TabIndex = 11
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Pretraga"
        '
        'LinkLabel6
        '
        Me.LinkLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LinkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel6.LinkColor = System.Drawing.Color.MidnightBlue
        Me.LinkLabel6.Location = New System.Drawing.Point(3, 83)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(138, 13)
        Me.LinkLabel6.TabIndex = 4
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "Štampanje"
        '
        'LinkLabel7
        '
        Me.LinkLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LinkLabel7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LinkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel7.LinkColor = System.Drawing.Color.MidnightBlue
        Me.LinkLabel7.Location = New System.Drawing.Point(3, 143)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(138, 13)
        Me.LinkLabel7.TabIndex = 5
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "Napravi trebovanje"
        '
        'LinkLabel8
        '
        Me.LinkLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LinkLabel8.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel8.LinkColor = System.Drawing.Color.MidnightBlue
        Me.LinkLabel8.Location = New System.Drawing.Point(3, 123)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(138, 13)
        Me.LinkLabel8.TabIndex = 10
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "Postavi cenovnik"
        '
        'cntMeniArtikli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnAlati)
        Me.Controls.Add(Me.tableButtons)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntMeniArtikli"
        Me.Size = New System.Drawing.Size(225, 285)
        Me.tableButtons.ResumeLayout(False)
        Me.panJM_Kontejner.ResumeLayout(False)
        Me.panJM_meni.ResumeLayout(False)
        Me.panJM_meni.PerformLayout()
        Me.panFO_Kontejner.ResumeLayout(False)
        Me.panFO_meni.ResumeLayout(False)
        Me.panFO_meni.PerformLayout()
        Me.panArtikli_Kontejner.ResumeLayout(False)
        Me.panArtikli_meni.ResumeLayout(False)
        Me.panArtikli_meni.PerformLayout()
        Me.panGrupe_Kontejner.ResumeLayout(False)
        Me.panGrupe_meni.ResumeLayout(False)
        Me.panGrupe_meni.PerformLayout()
        Me.panGenerIme_Kontejner.ResumeLayout(False)
        Me.panGenerIme_meni.ResumeLayout(False)
        Me.panGenerIme_meni.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tableButtons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnJm As System.Windows.Forms.Button
    Friend WithEvents btnGrupeArt As System.Windows.Forms.Button
    Friend WithEvents btnGenericko As System.Windows.Forms.Button
    Friend WithEvents btnArtikli As System.Windows.Forms.Button
    Friend WithEvents panArtikli_Kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panArtikli_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkArtikli_print As System.Windows.Forms.LinkLabel
    Friend WithEvents linkArtikli_del As System.Windows.Forms.LinkLabel
    Friend WithEvents linkArtikli_edit As System.Windows.Forms.LinkLabel
    Friend WithEvents linkArtikli_add As System.Windows.Forms.LinkLabel
    Friend WithEvents linkArtikli_search As System.Windows.Forms.LinkLabel
    Friend WithEvents btnNazad As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panGrupe_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkGrupe_edit As System.Windows.Forms.LinkLabel
    Friend WithEvents linkGrupe_add As System.Windows.Forms.LinkLabel
    Friend WithEvents linkGrupe_print As System.Windows.Forms.LinkLabel
    Friend WithEvents linkGrupe_del As System.Windows.Forms.LinkLabel
    Friend WithEvents linkGrupe_search As System.Windows.Forms.LinkLabel
    Friend WithEvents panGrupe_Kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents panGenerIme_Kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panGenerIme_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkGenericko_edit As System.Windows.Forms.LinkLabel
    Friend WithEvents linkGenericko_add As System.Windows.Forms.LinkLabel
    Friend WithEvents linkGenericko_print As System.Windows.Forms.LinkLabel
    Friend WithEvents linkGenericko_del As System.Windows.Forms.LinkLabel
    Friend WithEvents linkGenericko_search As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAlati As System.Windows.Forms.Button
    Friend WithEvents panFO_Kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panFO_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkFO_edit As System.Windows.Forms.LinkLabel
    Friend WithEvents linkFO_add As System.Windows.Forms.LinkLabel
    Friend WithEvents linkFO_print As System.Windows.Forms.LinkLabel
    Friend WithEvents linkFO_del As System.Windows.Forms.LinkLabel
    Friend WithEvents linkFO_search As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnFO As System.Windows.Forms.Button
    Friend WithEvents panJM_Kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panJM_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkJM_edit As System.Windows.Forms.LinkLabel
    Friend WithEvents linkJM_add As System.Windows.Forms.LinkLabel
    Friend WithEvents linkJM_print As System.Windows.Forms.LinkLabel
    Friend WithEvents linkJM_del As System.Windows.Forms.LinkLabel
    Friend WithEvents linkJM_search As System.Windows.Forms.LinkLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents linkPozitivna_lista As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel6 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel7 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel8 As System.Windows.Forms.LinkLabel

End Class
