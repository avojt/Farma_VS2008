<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntMeniFinansijsko
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
        Me.tableButtons = New System.Windows.Forms.TableLayoutPanel
        Me.panAnalOstalo_kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.Label6 = New System.Windows.Forms.Label
        Me.panAnalOstalo_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkKartice_analitika = New System.Windows.Forms.LinkLabel
        Me.linkAnallitKatrica_oj = New System.Windows.Forms.LinkLabel
        Me.panAnalPart_kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.Label4 = New System.Windows.Forms.Label
        Me.panAnalPart_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkAnalitPart_search = New System.Windows.Forms.LinkLabel
        Me.linkAnallitKatrica_dob = New System.Windows.Forms.LinkLabel
        Me.linkOtvorene_stavke = New System.Windows.Forms.LinkLabel
        Me.linkAnallitKatrica_kup = New System.Windows.Forms.LinkLabel
        Me.btnAlati = New System.Windows.Forms.Button
        Me.btnAnlitikaPart = New System.Windows.Forms.Button
        Me.panKartice_kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.Label5 = New System.Windows.Forms.Label
        Me.panKartice_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkPovezana_konta = New System.Windows.Forms.LinkLabel
        Me.linkKartice_GKnjige = New System.Windows.Forms.LinkLabel
        Me.linkAnallit_pregled_po_kontima = New System.Windows.Forms.LinkLabel
        Me.linkPotvrdaUnos = New System.Windows.Forms.LinkLabel
        Me.linkPotvrdaEdit = New System.Windows.Forms.LinkLabel
        Me.linkBruto_bilans = New System.Windows.Forms.LinkLabel
        Me.btnNazad = New System.Windows.Forms.Button
        Me.btnNalozi = New System.Windows.Forms.Button
        Me.panNalog_kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.Label3 = New System.Windows.Forms.Label
        Me.panNalog_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkNalog_add = New System.Windows.Forms.LinkLabel
        Me.linkNalog_edit = New System.Windows.Forms.LinkLabel
        Me.linkNalog_search = New System.Windows.Forms.LinkLabel
        Me.linkNalog_Print = New System.Windows.Forms.LinkLabel
        Me.linkNalog_del = New System.Windows.Forms.LinkLabel
        Me.linknalog_storno = New System.Windows.Forms.LinkLabel
        Me.btnKartice = New System.Windows.Forms.Button
        Me.btnAnalitikaOstalo = New System.Windows.Forms.Button
        Me.panAlati_kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.panAlati_meni = New System.Windows.Forms.TableLayoutPanel
        Me.Button1 = New System.Windows.Forms.Button
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.panGlavni = New System.Windows.Forms.TableLayoutPanel
        Me.btnFinansijsko = New System.Windows.Forms.Button
        Me.tableButtons.SuspendLayout()
        Me.panAnalOstalo_kontejner.SuspendLayout()
        Me.panAnalOstalo_meni.SuspendLayout()
        Me.panAnalPart_kontejner.SuspendLayout()
        Me.panAnalPart_meni.SuspendLayout()
        Me.panKartice_kontejner.SuspendLayout()
        Me.panKartice_meni.SuspendLayout()
        Me.panNalog_kontejner.SuspendLayout()
        Me.panNalog_meni.SuspendLayout()
        Me.panAlati_kontejner.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panGlavni.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableButtons
        '
        Me.tableButtons.ColumnCount = 1
        Me.tableButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableButtons.Controls.Add(Me.panAnalOstalo_kontejner, 0, 7)
        Me.tableButtons.Controls.Add(Me.panAnalPart_kontejner, 0, 5)
        Me.tableButtons.Controls.Add(Me.btnAlati, 0, 8)
        Me.tableButtons.Controls.Add(Me.btnAnlitikaPart, 0, 4)
        Me.tableButtons.Controls.Add(Me.panKartice_kontejner, 0, 3)
        Me.tableButtons.Controls.Add(Me.btnNazad, 0, 10)
        Me.tableButtons.Controls.Add(Me.btnNalozi, 0, 0)
        Me.tableButtons.Controls.Add(Me.panNalog_kontejner, 0, 1)
        Me.tableButtons.Controls.Add(Me.btnKartice, 0, 2)
        Me.tableButtons.Controls.Add(Me.btnAnalitikaOstalo, 0, 6)
        Me.tableButtons.Controls.Add(Me.panAlati_kontejner, 0, 9)
        Me.tableButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableButtons.Location = New System.Drawing.Point(21, 33)
        Me.tableButtons.Name = "tableButtons"
        Me.tableButtons.RowCount = 11
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.Size = New System.Drawing.Size(200, 639)
        Me.tableButtons.TabIndex = 1
        '
        'panAnalOstalo_kontejner
        '
        Me.panAnalOstalo_kontejner.ColumnCount = 2
        Me.panAnalOstalo_kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panAnalOstalo_kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panAnalOstalo_kontejner.Controls.Add(Me.Label6, 0, 0)
        Me.panAnalOstalo_kontejner.Controls.Add(Me.panAnalOstalo_meni, 1, 0)
        Me.panAnalOstalo_kontejner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panAnalOstalo_kontejner.Location = New System.Drawing.Point(3, 355)
        Me.panAnalOstalo_kontejner.Name = "panAnalOstalo_kontejner"
        Me.panAnalOstalo_kontejner.RowCount = 1
        Me.panAnalOstalo_kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panAnalOstalo_kontejner.Size = New System.Drawing.Size(194, 106)
        Me.panAnalOstalo_kontejner.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lavender
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 106)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "O P C  I  J  E"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panAnalOstalo_meni
        '
        Me.panAnalOstalo_meni.ColumnCount = 1
        Me.panAnalOstalo_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panAnalOstalo_meni.Controls.Add(Me.linkKartice_analitika, 0, 1)
        Me.panAnalOstalo_meni.Controls.Add(Me.linkAnallitKatrica_oj, 0, 0)
        Me.panAnalOstalo_meni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panAnalOstalo_meni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panAnalOstalo_meni.Location = New System.Drawing.Point(33, 3)
        Me.panAnalOstalo_meni.Name = "panAnalOstalo_meni"
        Me.panAnalOstalo_meni.RowCount = 5
        Me.panAnalOstalo_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panAnalOstalo_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panAnalOstalo_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panAnalOstalo_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panAnalOstalo_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panAnalOstalo_meni.Size = New System.Drawing.Size(158, 100)
        Me.panAnalOstalo_meni.TabIndex = 37
        '
        'linkKartice_analitika
        '
        Me.linkKartice_analitika.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkKartice_analitika.AutoSize = True
        Me.linkKartice_analitika.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkKartice_analitika.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkKartice_analitika.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkKartice_analitika.Location = New System.Drawing.Point(3, 23)
        Me.linkKartice_analitika.Name = "linkKartice_analitika"
        Me.linkKartice_analitika.Size = New System.Drawing.Size(152, 13)
        Me.linkKartice_analitika.TabIndex = 15
        Me.linkKartice_analitika.TabStop = True
        Me.linkKartice_analitika.Text = "Kartice po OJ"
        '
        'linkAnallitKatrica_oj
        '
        Me.linkAnallitKatrica_oj.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkAnallitKatrica_oj.AutoSize = True
        Me.linkAnallitKatrica_oj.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkAnallitKatrica_oj.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkAnallitKatrica_oj.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkAnallitKatrica_oj.Location = New System.Drawing.Point(3, 3)
        Me.linkAnallitKatrica_oj.Name = "linkAnallitKatrica_oj"
        Me.linkAnallitKatrica_oj.Size = New System.Drawing.Size(152, 13)
        Me.linkAnallitKatrica_oj.TabIndex = 13
        Me.linkAnallitKatrica_oj.TabStop = True
        Me.linkAnallitKatrica_oj.Text = "Kumulativ - OJ"
        '
        'panAnalPart_kontejner
        '
        Me.panAnalPart_kontejner.ColumnCount = 2
        Me.panAnalPart_kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panAnalPart_kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panAnalPart_kontejner.Controls.Add(Me.Label4, 0, 0)
        Me.panAnalPart_kontejner.Controls.Add(Me.panAnalPart_meni, 1, 0)
        Me.panAnalPart_kontejner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panAnalPart_kontejner.Location = New System.Drawing.Point(3, 213)
        Me.panAnalPart_kontejner.Name = "panAnalPart_kontejner"
        Me.panAnalPart_kontejner.RowCount = 1
        Me.panAnalPart_kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panAnalPart_kontejner.Size = New System.Drawing.Size(194, 106)
        Me.panAnalPart_kontejner.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lavender
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 106)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "O P C  I  J  E"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panAnalPart_meni
        '
        Me.panAnalPart_meni.ColumnCount = 1
        Me.panAnalPart_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panAnalPart_meni.Controls.Add(Me.linkAnalitPart_search, 0, 0)
        Me.panAnalPart_meni.Controls.Add(Me.linkAnallitKatrica_dob, 0, 1)
        Me.panAnalPart_meni.Controls.Add(Me.linkOtvorene_stavke, 0, 3)
        Me.panAnalPart_meni.Controls.Add(Me.linkAnallitKatrica_kup, 0, 2)
        Me.panAnalPart_meni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panAnalPart_meni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panAnalPart_meni.Location = New System.Drawing.Point(33, 3)
        Me.panAnalPart_meni.Name = "panAnalPart_meni"
        Me.panAnalPart_meni.RowCount = 5
        Me.panAnalPart_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panAnalPart_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panAnalPart_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panAnalPart_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panAnalPart_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panAnalPart_meni.Size = New System.Drawing.Size(158, 100)
        Me.panAnalPart_meni.TabIndex = 37
        '
        'linkAnalitPart_search
        '
        Me.linkAnalitPart_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkAnalitPart_search.AutoSize = True
        Me.linkAnalitPart_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkAnalitPart_search.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkAnalitPart_search.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkAnalitPart_search.Location = New System.Drawing.Point(3, 3)
        Me.linkAnalitPart_search.Name = "linkAnalitPart_search"
        Me.linkAnalitPart_search.Size = New System.Drawing.Size(152, 13)
        Me.linkAnalitPart_search.TabIndex = 13
        Me.linkAnalitPart_search.TabStop = True
        Me.linkAnalitPart_search.Text = "Kumulativ - partneri"
        '
        'linkAnallitKatrica_dob
        '
        Me.linkAnallitKatrica_dob.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkAnallitKatrica_dob.AutoSize = True
        Me.linkAnallitKatrica_dob.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkAnallitKatrica_dob.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkAnallitKatrica_dob.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkAnallitKatrica_dob.Location = New System.Drawing.Point(3, 23)
        Me.linkAnallitKatrica_dob.Name = "linkAnallitKatrica_dob"
        Me.linkAnallitKatrica_dob.Size = New System.Drawing.Size(152, 13)
        Me.linkAnallitKatrica_dob.TabIndex = 12
        Me.linkAnallitKatrica_dob.TabStop = True
        Me.linkAnallitKatrica_dob.Text = "Kartica - dobavljači"
        '
        'linkOtvorene_stavke
        '
        Me.linkOtvorene_stavke.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkOtvorene_stavke.AutoSize = True
        Me.linkOtvorene_stavke.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkOtvorene_stavke.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkOtvorene_stavke.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkOtvorene_stavke.Location = New System.Drawing.Point(3, 63)
        Me.linkOtvorene_stavke.Name = "linkOtvorene_stavke"
        Me.linkOtvorene_stavke.Size = New System.Drawing.Size(152, 13)
        Me.linkOtvorene_stavke.TabIndex = 15
        Me.linkOtvorene_stavke.TabStop = True
        Me.linkOtvorene_stavke.Text = "Otvorene stavke"
        '
        'linkAnallitKatrica_kup
        '
        Me.linkAnallitKatrica_kup.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkAnallitKatrica_kup.AutoSize = True
        Me.linkAnallitKatrica_kup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkAnallitKatrica_kup.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkAnallitKatrica_kup.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkAnallitKatrica_kup.Location = New System.Drawing.Point(3, 43)
        Me.linkAnallitKatrica_kup.Name = "linkAnallitKatrica_kup"
        Me.linkAnallitKatrica_kup.Size = New System.Drawing.Size(152, 13)
        Me.linkAnallitKatrica_kup.TabIndex = 13
        Me.linkAnallitKatrica_kup.TabStop = True
        Me.linkAnallitKatrica_kup.Text = "Kartica - kupci"
        '
        'btnAlati
        '
        Me.btnAlati.Location = New System.Drawing.Point(3, 467)
        Me.btnAlati.Name = "btnAlati"
        Me.btnAlati.Size = New System.Drawing.Size(185, 24)
        Me.btnAlati.TabIndex = 42
        Me.btnAlati.Text = "ALATI"
        Me.btnAlati.UseVisualStyleBackColor = True
        '
        'btnAnlitikaPart
        '
        Me.btnAnlitikaPart.Location = New System.Drawing.Point(3, 183)
        Me.btnAnlitikaPart.Name = "btnAnlitikaPart"
        Me.btnAnlitikaPart.Size = New System.Drawing.Size(185, 24)
        Me.btnAnlitikaPart.TabIndex = 41
        Me.btnAnlitikaPart.Text = "ANALITIKA - PARTNERI"
        Me.btnAnlitikaPart.UseVisualStyleBackColor = True
        '
        'panKartice_kontejner
        '
        Me.panKartice_kontejner.ColumnCount = 2
        Me.panKartice_kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panKartice_kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panKartice_kontejner.Controls.Add(Me.Label5, 0, 0)
        Me.panKartice_kontejner.Controls.Add(Me.panKartice_meni, 1, 0)
        Me.panKartice_kontejner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panKartice_kontejner.Location = New System.Drawing.Point(3, 71)
        Me.panKartice_kontejner.Name = "panKartice_kontejner"
        Me.panKartice_kontejner.RowCount = 1
        Me.panKartice_kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panKartice_kontejner.Size = New System.Drawing.Size(194, 106)
        Me.panKartice_kontejner.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lavender
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 106)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "O P C  I  J  E"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panKartice_meni
        '
        Me.panKartice_meni.ColumnCount = 1
        Me.panKartice_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panKartice_meni.Controls.Add(Me.linkPovezana_konta, 0, 3)
        Me.panKartice_meni.Controls.Add(Me.linkKartice_GKnjige, 0, 0)
        Me.panKartice_meni.Controls.Add(Me.linkAnallit_pregled_po_kontima, 0, 1)
        Me.panKartice_meni.Controls.Add(Me.linkPotvrdaUnos, 0, 6)
        Me.panKartice_meni.Controls.Add(Me.linkPotvrdaEdit, 0, 7)
        Me.panKartice_meni.Controls.Add(Me.linkBruto_bilans, 0, 2)
        Me.panKartice_meni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panKartice_meni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panKartice_meni.Location = New System.Drawing.Point(33, 3)
        Me.panKartice_meni.Name = "panKartice_meni"
        Me.panKartice_meni.RowCount = 7
        Me.panKartice_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panKartice_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panKartice_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panKartice_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panKartice_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panKartice_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.panKartice_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panKartice_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panKartice_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panKartice_meni.Size = New System.Drawing.Size(158, 100)
        Me.panKartice_meni.TabIndex = 5
        '
        'linkPovezana_konta
        '
        Me.linkPovezana_konta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkPovezana_konta.AutoSize = True
        Me.linkPovezana_konta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkPovezana_konta.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkPovezana_konta.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkPovezana_konta.Location = New System.Drawing.Point(3, 63)
        Me.linkPovezana_konta.Name = "linkPovezana_konta"
        Me.linkPovezana_konta.Size = New System.Drawing.Size(152, 13)
        Me.linkPovezana_konta.TabIndex = 16
        Me.linkPovezana_konta.TabStop = True
        Me.linkPovezana_konta.Text = "Povezana konta"
        '
        'linkKartice_GKnjige
        '
        Me.linkKartice_GKnjige.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkKartice_GKnjige.AutoSize = True
        Me.linkKartice_GKnjige.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkKartice_GKnjige.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkKartice_GKnjige.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkKartice_GKnjige.Location = New System.Drawing.Point(3, 3)
        Me.linkKartice_GKnjige.Name = "linkKartice_GKnjige"
        Me.linkKartice_GKnjige.Size = New System.Drawing.Size(152, 13)
        Me.linkKartice_GKnjige.TabIndex = 14
        Me.linkKartice_GKnjige.TabStop = True
        Me.linkKartice_GKnjige.Text = "Kartice glavne knjige"
        '
        'linkAnallit_pregled_po_kontima
        '
        Me.linkAnallit_pregled_po_kontima.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkAnallit_pregled_po_kontima.AutoSize = True
        Me.linkAnallit_pregled_po_kontima.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkAnallit_pregled_po_kontima.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkAnallit_pregled_po_kontima.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkAnallit_pregled_po_kontima.Location = New System.Drawing.Point(3, 23)
        Me.linkAnallit_pregled_po_kontima.Name = "linkAnallit_pregled_po_kontima"
        Me.linkAnallit_pregled_po_kontima.Size = New System.Drawing.Size(152, 13)
        Me.linkAnallit_pregled_po_kontima.TabIndex = 14
        Me.linkAnallit_pregled_po_kontima.TabStop = True
        Me.linkAnallit_pregled_po_kontima.Text = "Analit/Sintet. pregled"
        '
        'linkPotvrdaUnos
        '
        Me.linkPotvrdaUnos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.linkPotvrdaUnos.AutoSize = True
        Me.linkPotvrdaUnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkPotvrdaUnos.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkPotvrdaUnos.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkPotvrdaUnos.Location = New System.Drawing.Point(3, 118)
        Me.linkPotvrdaUnos.Name = "linkPotvrdaUnos"
        Me.linkPotvrdaUnos.Size = New System.Drawing.Size(92, 13)
        Me.linkPotvrdaUnos.TabIndex = 4
        Me.linkPotvrdaUnos.TabStop = True
        Me.linkPotvrdaUnos.Text = "Potvrda - Unos"
        '
        'linkPotvrdaEdit
        '
        Me.linkPotvrdaEdit.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.linkPotvrdaEdit.AutoSize = True
        Me.linkPotvrdaEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkPotvrdaEdit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkPotvrdaEdit.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkPotvrdaEdit.Location = New System.Drawing.Point(3, 138)
        Me.linkPotvrdaEdit.Name = "linkPotvrdaEdit"
        Me.linkPotvrdaEdit.Size = New System.Drawing.Size(103, 13)
        Me.linkPotvrdaEdit.TabIndex = 5
        Me.linkPotvrdaEdit.TabStop = True
        Me.linkPotvrdaEdit.Text = "Potvrda - Izmene"
        '
        'linkBruto_bilans
        '
        Me.linkBruto_bilans.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkBruto_bilans.AutoSize = True
        Me.linkBruto_bilans.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkBruto_bilans.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkBruto_bilans.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkBruto_bilans.Location = New System.Drawing.Point(3, 43)
        Me.linkBruto_bilans.Name = "linkBruto_bilans"
        Me.linkBruto_bilans.Size = New System.Drawing.Size(152, 13)
        Me.linkBruto_bilans.TabIndex = 15
        Me.linkBruto_bilans.TabStop = True
        Me.linkBruto_bilans.Text = "Bruto bilansi"
        '
        'btnNazad
        '
        Me.btnNazad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNazad.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnNazad.Location = New System.Drawing.Point(3, 610)
        Me.btnNazad.Name = "btnNazad"
        Me.btnNazad.Size = New System.Drawing.Size(194, 24)
        Me.btnNazad.TabIndex = 4
        Me.btnNazad.Text = "NAZAD"
        Me.btnNazad.UseVisualStyleBackColor = True
        '
        'btnNalozi
        '
        Me.btnNalozi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNalozi.Location = New System.Drawing.Point(3, 3)
        Me.btnNalozi.Name = "btnNalozi"
        Me.btnNalozi.Size = New System.Drawing.Size(194, 24)
        Me.btnNalozi.TabIndex = 8
        Me.btnNalozi.Text = "NALOZI ZA KNJIŽENJE"
        Me.btnNalozi.UseVisualStyleBackColor = True
        '
        'panNalog_kontejner
        '
        Me.panNalog_kontejner.ColumnCount = 2
        Me.panNalog_kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.panNalog_kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panNalog_kontejner.Controls.Add(Me.Label3, 0, 0)
        Me.panNalog_kontejner.Controls.Add(Me.panNalog_meni, 1, 0)
        Me.panNalog_kontejner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panNalog_kontejner.Location = New System.Drawing.Point(3, 33)
        Me.panNalog_kontejner.Name = "panNalog_kontejner"
        Me.panNalog_kontejner.RowCount = 1
        Me.panNalog_kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panNalog_kontejner.Size = New System.Drawing.Size(194, 2)
        Me.panNalog_kontejner.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lavender
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 2)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "O P C  I  J  E"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panNalog_meni
        '
        Me.panNalog_meni.ColumnCount = 1
        Me.panNalog_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panNalog_meni.Controls.Add(Me.linkNalog_add, 0, 1)
        Me.panNalog_meni.Controls.Add(Me.linkNalog_edit, 0, 2)
        Me.panNalog_meni.Controls.Add(Me.linkNalog_search, 0, 0)
        Me.panNalog_meni.Controls.Add(Me.linkNalog_Print, 0, 5)
        Me.panNalog_meni.Controls.Add(Me.linkNalog_del, 0, 3)
        Me.panNalog_meni.Controls.Add(Me.linknalog_storno, 0, 4)
        Me.panNalog_meni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panNalog_meni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panNalog_meni.Location = New System.Drawing.Point(34, 3)
        Me.panNalog_meni.Name = "panNalog_meni"
        Me.panNalog_meni.RowCount = 6
        Me.panNalog_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panNalog_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panNalog_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panNalog_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panNalog_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panNalog_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panNalog_meni.Size = New System.Drawing.Size(157, 1)
        Me.panNalog_meni.TabIndex = 21
        '
        'linkNalog_add
        '
        Me.linkNalog_add.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.linkNalog_add.AutoSize = True
        Me.linkNalog_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkNalog_add.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkNalog_add.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkNalog_add.Location = New System.Drawing.Point(3, 23)
        Me.linkNalog_add.Name = "linkNalog_add"
        Me.linkNalog_add.Size = New System.Drawing.Size(32, 13)
        Me.linkNalog_add.TabIndex = 1
        Me.linkNalog_add.TabStop = True
        Me.linkNalog_add.Text = "Unos"
        '
        'linkNalog_edit
        '
        Me.linkNalog_edit.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.linkNalog_edit.AutoSize = True
        Me.linkNalog_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkNalog_edit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkNalog_edit.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkNalog_edit.Location = New System.Drawing.Point(3, 43)
        Me.linkNalog_edit.Name = "linkNalog_edit"
        Me.linkNalog_edit.Size = New System.Drawing.Size(41, 13)
        Me.linkNalog_edit.TabIndex = 2
        Me.linkNalog_edit.TabStop = True
        Me.linkNalog_edit.Text = "Izmene"
        '
        'linkNalog_search
        '
        Me.linkNalog_search.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.linkNalog_search.AutoSize = True
        Me.linkNalog_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkNalog_search.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkNalog_search.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkNalog_search.Location = New System.Drawing.Point(3, 3)
        Me.linkNalog_search.Name = "linkNalog_search"
        Me.linkNalog_search.Size = New System.Drawing.Size(47, 13)
        Me.linkNalog_search.TabIndex = 12
        Me.linkNalog_search.TabStop = True
        Me.linkNalog_search.Text = "Pretraga"
        '
        'linkNalog_Print
        '
        Me.linkNalog_Print.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.linkNalog_Print.AutoSize = True
        Me.linkNalog_Print.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkNalog_Print.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkNalog_Print.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkNalog_Print.Location = New System.Drawing.Point(3, 103)
        Me.linkNalog_Print.Name = "linkNalog_Print"
        Me.linkNalog_Print.Size = New System.Drawing.Size(57, 13)
        Me.linkNalog_Print.TabIndex = 3
        Me.linkNalog_Print.TabStop = True
        Me.linkNalog_Print.Text = "Štampanje"
        '
        'linkNalog_del
        '
        Me.linkNalog_del.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.linkNalog_del.AutoSize = True
        Me.linkNalog_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkNalog_del.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkNalog_del.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkNalog_del.Location = New System.Drawing.Point(3, 63)
        Me.linkNalog_del.Name = "linkNalog_del"
        Me.linkNalog_del.Size = New System.Drawing.Size(44, 13)
        Me.linkNalog_del.TabIndex = 5
        Me.linkNalog_del.TabStop = True
        Me.linkNalog_del.Text = "Brisanje"
        '
        'linknalog_storno
        '
        Me.linknalog_storno.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.linknalog_storno.AutoSize = True
        Me.linknalog_storno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linknalog_storno.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linknalog_storno.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linknalog_storno.Location = New System.Drawing.Point(3, 83)
        Me.linknalog_storno.Name = "linknalog_storno"
        Me.linknalog_storno.Size = New System.Drawing.Size(57, 13)
        Me.linknalog_storno.TabIndex = 6
        Me.linknalog_storno.TabStop = True
        Me.linknalog_storno.Text = "Storniranje"
        '
        'btnKartice
        '
        Me.btnKartice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnKartice.Location = New System.Drawing.Point(3, 41)
        Me.btnKartice.Name = "btnKartice"
        Me.btnKartice.Size = New System.Drawing.Size(194, 24)
        Me.btnKartice.TabIndex = 9
        Me.btnKartice.Text = "KARTICE"
        Me.btnKartice.UseVisualStyleBackColor = True
        '
        'btnAnalitikaOstalo
        '
        Me.btnAnalitikaOstalo.Location = New System.Drawing.Point(3, 325)
        Me.btnAnalitikaOstalo.Name = "btnAnalitikaOstalo"
        Me.btnAnalitikaOstalo.Size = New System.Drawing.Size(185, 24)
        Me.btnAnalitikaOstalo.TabIndex = 42
        Me.btnAnalitikaOstalo.Text = "ANALITIKA - OSTALO"
        Me.btnAnalitikaOstalo.UseVisualStyleBackColor = True
        '
        'panAlati_kontejner
        '
        Me.panAlati_kontejner.ColumnCount = 2
        Me.panAlati_kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panAlati_kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panAlati_kontejner.Controls.Add(Me.Label1, 0, 0)
        Me.panAlati_kontejner.Controls.Add(Me.panAlati_meni, 1, 0)
        Me.panAlati_kontejner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panAlati_kontejner.Location = New System.Drawing.Point(3, 497)
        Me.panAlati_kontejner.Name = "panAlati_kontejner"
        Me.panAlati_kontejner.RowCount = 1
        Me.panAlati_kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panAlati_kontejner.Size = New System.Drawing.Size(194, 106)
        Me.panAlati_kontejner.TabIndex = 41
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
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "O P C  I  J  E"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panAlati_meni
        '
        Me.panAlati_meni.ColumnCount = 1
        Me.panAlati_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panAlati_meni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panAlati_meni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panAlati_meni.Location = New System.Drawing.Point(33, 3)
        Me.panAlati_meni.Name = "panAlati_meni"
        Me.panAlati_meni.RowCount = 4
        Me.panAlati_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panAlati_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panAlati_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panAlati_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panAlati_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panAlati_meni.Size = New System.Drawing.Size(158, 100)
        Me.panAlati_meni.TabIndex = 37
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(42, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackgroundImage = Global.Farma.My.Resources.Resources.LaST__Cobalt__Books
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(224, 117)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackgroundImage = Global.Farma.My.Resources.Resources.Pan_setting
        Me.TableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(218, 111)
        Me.TableLayoutPanel2.TabIndex = 9
        '
        'panGlavni
        '
        Me.panGlavni.ColumnCount = 2
        Me.panGlavni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.411215!))
        Me.panGlavni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.58878!))
        Me.panGlavni.Controls.Add(Me.btnFinansijsko, 0, 0)
        Me.panGlavni.Controls.Add(Me.tableButtons, 1, 1)
        Me.panGlavni.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panGlavni.Location = New System.Drawing.Point(0, 163)
        Me.panGlavni.Name = "panGlavni"
        Me.panGlavni.RowCount = 2
        Me.panGlavni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panGlavni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panGlavni.Size = New System.Drawing.Size(224, 675)
        Me.panGlavni.TabIndex = 11
        '
        'btnFinansijsko
        '
        Me.btnFinansijsko.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panGlavni.SetColumnSpan(Me.btnFinansijsko, 2)
        Me.btnFinansijsko.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnFinansijsko.Location = New System.Drawing.Point(3, 3)
        Me.btnFinansijsko.Name = "btnFinansijsko"
        Me.btnFinansijsko.Size = New System.Drawing.Size(218, 24)
        Me.btnFinansijsko.TabIndex = 12
        Me.btnFinansijsko.Text = "FINANSIJSKO"
        Me.btnFinansijsko.UseVisualStyleBackColor = True
        '
        'cntMeniFinansijsko
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.panGlavni)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntMeniFinansijsko"
        Me.Size = New System.Drawing.Size(224, 838)
        Me.tableButtons.ResumeLayout(False)
        Me.panAnalOstalo_kontejner.ResumeLayout(False)
        Me.panAnalOstalo_meni.ResumeLayout(False)
        Me.panAnalOstalo_meni.PerformLayout()
        Me.panAnalPart_kontejner.ResumeLayout(False)
        Me.panAnalPart_meni.ResumeLayout(False)
        Me.panAnalPart_meni.PerformLayout()
        Me.panKartice_kontejner.ResumeLayout(False)
        Me.panKartice_meni.ResumeLayout(False)
        Me.panKartice_meni.PerformLayout()
        Me.panNalog_kontejner.ResumeLayout(False)
        Me.panNalog_meni.ResumeLayout(False)
        Me.panNalog_meni.PerformLayout()
        Me.panAlati_kontejner.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.panGlavni.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tableButtons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnNazad As System.Windows.Forms.Button
    Friend WithEvents btnNalozi As System.Windows.Forms.Button
    Friend WithEvents btnKartice As System.Windows.Forms.Button
    Friend WithEvents panAnalPart_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkAnalitPart_search As System.Windows.Forms.LinkLabel
    Friend WithEvents panNalog_kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents panNalog_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkNalog_add As System.Windows.Forms.LinkLabel
    Friend WithEvents linkNalog_del As System.Windows.Forms.LinkLabel
    Friend WithEvents linkNalog_Print As System.Windows.Forms.LinkLabel
    Friend WithEvents linkNalog_edit As System.Windows.Forms.LinkLabel
    Friend WithEvents linkNalog_search As System.Windows.Forms.LinkLabel
    Friend WithEvents panAnalPart_kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents panKartice_kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents panKartice_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkKartice_GKnjige As System.Windows.Forms.LinkLabel
    Friend WithEvents linkPotvrdaUnos As System.Windows.Forms.LinkLabel
    Friend WithEvents linkPotvrdaEdit As System.Windows.Forms.LinkLabel
    Friend WithEvents btnAnlitikaPart As System.Windows.Forms.Button
    Friend WithEvents btnAlati As System.Windows.Forms.Button
    Friend WithEvents btnAnalitikaOstalo As System.Windows.Forms.Button
    Friend WithEvents panAnalOstalo_kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents panAnalOstalo_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panAlati_kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panAlati_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents linknalog_storno As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panGlavni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnFinansijsko As System.Windows.Forms.Button
    Friend WithEvents linkAnallitKatrica_dob As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkAnallitKatrica_oj As System.Windows.Forms.LinkLabel
    Friend WithEvents linkAnallitKatrica_kup As System.Windows.Forms.LinkLabel
    Friend WithEvents linkAnallit_pregled_po_kontima As System.Windows.Forms.LinkLabel
    Friend WithEvents linkKartice_analitika As System.Windows.Forms.LinkLabel
    Friend WithEvents linkOtvorene_stavke As System.Windows.Forms.LinkLabel
    Friend WithEvents linkBruto_bilans As System.Windows.Forms.LinkLabel
    Friend WithEvents linkPovezana_konta As System.Windows.Forms.LinkLabel

End Class
