<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntMeniIzvestaji
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
        Me.panAnaliza_Kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.Label2 = New System.Windows.Forms.Label
        Me.panAnaliza_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkAnaliza_lager = New System.Windows.Forms.LinkLabel
        Me.linkAnaliza_izlaz = New System.Windows.Forms.LinkLabel
        Me.linkAnaliza_ulaz = New System.Windows.Forms.LinkLabel
        Me.btnAnalize = New System.Windows.Forms.Button
        Me.panPromet_Kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.Label10 = New System.Windows.Forms.Label
        Me.panPromet_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkKartica = New System.Windows.Forms.LinkLabel
        Me.linkNeslaganje = New System.Windows.Forms.LinkLabel
        Me.linkMagacin = New System.Windows.Forms.LinkLabel
        Me.btnArtikliPromet = New System.Windows.Forms.Button
        Me.btnNazad = New System.Windows.Forms.Button
        Me.btnSpecifikacije = New System.Windows.Forms.Button
        Me.panSpecifikacije_Kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.panSpecifikacije_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkLager_lista = New System.Windows.Forms.LinkLabel
        Me.linkSpec_nivelacije = New System.Windows.Forms.LinkLabel
        Me.linkSpecifikacija_izlaza = New System.Windows.Forms.LinkLabel
        Me.linkSpecifikacija_ulaza = New System.Windows.Forms.LinkLabel
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.tableButtons.SuspendLayout()
        Me.panAnaliza_Kontejner.SuspendLayout()
        Me.panAnaliza_meni.SuspendLayout()
        Me.panPromet_Kontejner.SuspendLayout()
        Me.panPromet_meni.SuspendLayout()
        Me.panSpecifikacije_Kontejner.SuspendLayout()
        Me.panSpecifikacije_meni.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableButtons
        '
        Me.tableButtons.ColumnCount = 1
        Me.tableButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableButtons.Controls.Add(Me.panAnaliza_Kontejner, 0, 5)
        Me.tableButtons.Controls.Add(Me.btnAnalize, 0, 4)
        Me.tableButtons.Controls.Add(Me.panPromet_Kontejner, 0, 1)
        Me.tableButtons.Controls.Add(Me.btnArtikliPromet, 0, 0)
        Me.tableButtons.Controls.Add(Me.btnNazad, 0, 6)
        Me.tableButtons.Controls.Add(Me.btnSpecifikacije, 0, 2)
        Me.tableButtons.Controls.Add(Me.panSpecifikacije_Kontejner, 0, 3)
        Me.tableButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tableButtons.Location = New System.Drawing.Point(0, 190)
        Me.tableButtons.Name = "tableButtons"
        Me.tableButtons.RowCount = 7
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.Size = New System.Drawing.Size(191, 352)
        Me.tableButtons.TabIndex = 6
        '
        'panAnaliza_Kontejner
        '
        Me.panAnaliza_Kontejner.ColumnCount = 2
        Me.panAnaliza_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panAnaliza_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panAnaliza_Kontejner.Controls.Add(Me.Label2, 0, 0)
        Me.panAnaliza_Kontejner.Controls.Add(Me.panAnaliza_meni, 1, 0)
        Me.panAnaliza_Kontejner.Location = New System.Drawing.Point(3, 213)
        Me.panAnaliza_Kontejner.Name = "panAnaliza_Kontejner"
        Me.panAnaliza_Kontejner.RowCount = 1
        Me.panAnaliza_Kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panAnaliza_Kontejner.Size = New System.Drawing.Size(185, 106)
        Me.panAnaliza_Kontejner.TabIndex = 10
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
        'panAnaliza_meni
        '
        Me.panAnaliza_meni.ColumnCount = 1
        Me.panAnaliza_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panAnaliza_meni.Controls.Add(Me.linkAnaliza_lager, 0, 2)
        Me.panAnaliza_meni.Controls.Add(Me.linkAnaliza_izlaz, 0, 1)
        Me.panAnaliza_meni.Controls.Add(Me.linkAnaliza_ulaz, 0, 0)
        Me.panAnaliza_meni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panAnaliza_meni.Location = New System.Drawing.Point(33, 3)
        Me.panAnaliza_meni.Name = "panAnaliza_meni"
        Me.panAnaliza_meni.RowCount = 5
        Me.panAnaliza_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panAnaliza_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panAnaliza_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panAnaliza_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panAnaliza_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panAnaliza_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panAnaliza_meni.Size = New System.Drawing.Size(149, 100)
        Me.panAnaliza_meni.TabIndex = 22
        '
        'linkAnaliza_lager
        '
        Me.linkAnaliza_lager.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkAnaliza_lager.AutoSize = True
        Me.linkAnaliza_lager.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkAnaliza_lager.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkAnaliza_lager.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkAnaliza_lager.Location = New System.Drawing.Point(3, 43)
        Me.linkAnaliza_lager.Name = "linkAnaliza_lager"
        Me.linkAnaliza_lager.Size = New System.Drawing.Size(143, 13)
        Me.linkAnaliza_lager.TabIndex = 12
        Me.linkAnaliza_lager.TabStop = True
        Me.linkAnaliza_lager.Text = "Analiza lagera"
        '
        'linkAnaliza_izlaz
        '
        Me.linkAnaliza_izlaz.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.linkAnaliza_izlaz.AutoSize = True
        Me.linkAnaliza_izlaz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkAnaliza_izlaz.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkAnaliza_izlaz.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkAnaliza_izlaz.Location = New System.Drawing.Point(3, 23)
        Me.linkAnaliza_izlaz.Name = "linkAnaliza_izlaz"
        Me.linkAnaliza_izlaz.Size = New System.Drawing.Size(70, 13)
        Me.linkAnaliza_izlaz.TabIndex = 6
        Me.linkAnaliza_izlaz.TabStop = True
        Me.linkAnaliza_izlaz.Text = "Analiza izlaza"
        '
        'linkAnaliza_ulaz
        '
        Me.linkAnaliza_ulaz.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.linkAnaliza_ulaz.AutoSize = True
        Me.linkAnaliza_ulaz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkAnaliza_ulaz.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkAnaliza_ulaz.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkAnaliza_ulaz.Location = New System.Drawing.Point(3, 3)
        Me.linkAnaliza_ulaz.Name = "linkAnaliza_ulaz"
        Me.linkAnaliza_ulaz.Size = New System.Drawing.Size(69, 13)
        Me.linkAnaliza_ulaz.TabIndex = 11
        Me.linkAnaliza_ulaz.TabStop = True
        Me.linkAnaliza_ulaz.Text = "Analiza ulaza"
        '
        'btnAnalize
        '
        Me.btnAnalize.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnalize.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnAnalize.Location = New System.Drawing.Point(3, 183)
        Me.btnAnalize.Name = "btnAnalize"
        Me.btnAnalize.Size = New System.Drawing.Size(185, 24)
        Me.btnAnalize.TabIndex = 8
        Me.btnAnalize.Text = "ANALIZE"
        Me.btnAnalize.UseVisualStyleBackColor = True
        '
        'panPromet_Kontejner
        '
        Me.panPromet_Kontejner.ColumnCount = 2
        Me.panPromet_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panPromet_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panPromet_Kontejner.Controls.Add(Me.Label10, 0, 0)
        Me.panPromet_Kontejner.Controls.Add(Me.panPromet_meni, 1, 0)
        Me.panPromet_Kontejner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panPromet_Kontejner.Location = New System.Drawing.Point(3, 33)
        Me.panPromet_Kontejner.Name = "panPromet_Kontejner"
        Me.panPromet_Kontejner.RowCount = 1
        Me.panPromet_Kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panPromet_Kontejner.Size = New System.Drawing.Size(185, 2)
        Me.panPromet_Kontejner.TabIndex = 10
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
        'panPromet_meni
        '
        Me.panPromet_meni.ColumnCount = 1
        Me.panPromet_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panPromet_meni.Controls.Add(Me.linkKartica, 0, 0)
        Me.panPromet_meni.Controls.Add(Me.linkNeslaganje, 0, 2)
        Me.panPromet_meni.Controls.Add(Me.linkMagacin, 0, 1)
        Me.panPromet_meni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panPromet_meni.Location = New System.Drawing.Point(33, 3)
        Me.panPromet_meni.Name = "panPromet_meni"
        Me.panPromet_meni.RowCount = 4
        Me.panPromet_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panPromet_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panPromet_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panPromet_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panPromet_meni.Size = New System.Drawing.Size(149, 1)
        Me.panPromet_meni.TabIndex = 22
        '
        'linkKartica
        '
        Me.linkKartica.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkKartica.AutoSize = True
        Me.linkKartica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkKartica.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkKartica.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkKartica.Location = New System.Drawing.Point(3, 3)
        Me.linkKartica.Name = "linkKartica"
        Me.linkKartica.Size = New System.Drawing.Size(143, 13)
        Me.linkKartica.TabIndex = 11
        Me.linkKartica.TabStop = True
        Me.linkKartica.Text = "Kartica"
        Me.linkKartica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'linkNeslaganje
        '
        Me.linkNeslaganje.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkNeslaganje.AutoSize = True
        Me.linkNeslaganje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkNeslaganje.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkNeslaganje.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkNeslaganje.Location = New System.Drawing.Point(3, 43)
        Me.linkNeslaganje.Name = "linkNeslaganje"
        Me.linkNeslaganje.Size = New System.Drawing.Size(143, 13)
        Me.linkNeslaganje.TabIndex = 4
        Me.linkNeslaganje.TabStop = True
        Me.linkNeslaganje.Text = "Neusaglašene sa lagerom"
        Me.linkNeslaganje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'linkMagacin
        '
        Me.linkMagacin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkMagacin.AutoSize = True
        Me.linkMagacin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkMagacin.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkMagacin.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkMagacin.Location = New System.Drawing.Point(3, 23)
        Me.linkMagacin.Name = "linkMagacin"
        Me.linkMagacin.Size = New System.Drawing.Size(143, 13)
        Me.linkMagacin.TabIndex = 8
        Me.linkMagacin.TabStop = True
        Me.linkMagacin.Text = "Pregled stanja magacina"
        Me.linkMagacin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnArtikliPromet
        '
        Me.btnArtikliPromet.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArtikliPromet.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnArtikliPromet.Location = New System.Drawing.Point(3, 3)
        Me.btnArtikliPromet.Name = "btnArtikliPromet"
        Me.btnArtikliPromet.Size = New System.Drawing.Size(185, 24)
        Me.btnArtikliPromet.TabIndex = 5
        Me.btnArtikliPromet.Text = "ARTIKLI - PROMET"
        Me.btnArtikliPromet.UseVisualStyleBackColor = True
        '
        'btnNazad
        '
        Me.btnNazad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNazad.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnNazad.Location = New System.Drawing.Point(3, 325)
        Me.btnNazad.Name = "btnNazad"
        Me.btnNazad.Size = New System.Drawing.Size(185, 24)
        Me.btnNazad.TabIndex = 10
        Me.btnNazad.Text = "NAZAD"
        Me.btnNazad.UseVisualStyleBackColor = True
        '
        'btnSpecifikacije
        '
        Me.btnSpecifikacije.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSpecifikacije.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSpecifikacije.Location = New System.Drawing.Point(3, 41)
        Me.btnSpecifikacije.Name = "btnSpecifikacije"
        Me.btnSpecifikacije.Size = New System.Drawing.Size(185, 24)
        Me.btnSpecifikacije.TabIndex = 4
        Me.btnSpecifikacije.Text = "SPECIFIKACIJE"
        Me.btnSpecifikacije.UseVisualStyleBackColor = True
        '
        'panSpecifikacije_Kontejner
        '
        Me.panSpecifikacije_Kontejner.ColumnCount = 2
        Me.panSpecifikacije_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panSpecifikacije_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panSpecifikacije_Kontejner.Controls.Add(Me.Label1, 0, 0)
        Me.panSpecifikacije_Kontejner.Controls.Add(Me.panSpecifikacije_meni, 1, 0)
        Me.panSpecifikacije_Kontejner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panSpecifikacije_Kontejner.Location = New System.Drawing.Point(3, 71)
        Me.panSpecifikacije_Kontejner.Name = "panSpecifikacije_Kontejner"
        Me.panSpecifikacije_Kontejner.RowCount = 1
        Me.panSpecifikacije_Kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panSpecifikacije_Kontejner.Size = New System.Drawing.Size(185, 106)
        Me.panSpecifikacije_Kontejner.TabIndex = 9
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
        'panSpecifikacije_meni
        '
        Me.panSpecifikacije_meni.ColumnCount = 1
        Me.panSpecifikacije_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panSpecifikacije_meni.Controls.Add(Me.linkLager_lista, 0, 3)
        Me.panSpecifikacije_meni.Controls.Add(Me.linkSpec_nivelacije, 0, 2)
        Me.panSpecifikacije_meni.Controls.Add(Me.linkSpecifikacija_izlaza, 0, 1)
        Me.panSpecifikacije_meni.Controls.Add(Me.linkSpecifikacija_ulaza, 0, 0)
        Me.panSpecifikacije_meni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panSpecifikacije_meni.Location = New System.Drawing.Point(33, 3)
        Me.panSpecifikacije_meni.Name = "panSpecifikacije_meni"
        Me.panSpecifikacije_meni.RowCount = 5
        Me.panSpecifikacije_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panSpecifikacije_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panSpecifikacije_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panSpecifikacije_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panSpecifikacije_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panSpecifikacije_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panSpecifikacije_meni.Size = New System.Drawing.Size(149, 100)
        Me.panSpecifikacije_meni.TabIndex = 22
        '
        'linkLager_lista
        '
        Me.linkLager_lista.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkLager_lista.AutoSize = True
        Me.linkLager_lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkLager_lista.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkLager_lista.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkLager_lista.Location = New System.Drawing.Point(3, 63)
        Me.linkLager_lista.Name = "linkLager_lista"
        Me.linkLager_lista.Size = New System.Drawing.Size(143, 13)
        Me.linkLager_lista.TabIndex = 13
        Me.linkLager_lista.TabStop = True
        Me.linkLager_lista.Text = "Lager lista"
        '
        'linkSpec_nivelacije
        '
        Me.linkSpec_nivelacije.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkSpec_nivelacije.AutoSize = True
        Me.linkSpec_nivelacije.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkSpec_nivelacije.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkSpec_nivelacije.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkSpec_nivelacije.Location = New System.Drawing.Point(3, 43)
        Me.linkSpec_nivelacije.Name = "linkSpec_nivelacije"
        Me.linkSpec_nivelacije.Size = New System.Drawing.Size(143, 13)
        Me.linkSpec_nivelacije.TabIndex = 12
        Me.linkSpec_nivelacije.TabStop = True
        Me.linkSpec_nivelacije.Text = "Specifikacija nivelacije"
        '
        'linkSpecifikacija_izlaza
        '
        Me.linkSpecifikacija_izlaza.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkSpecifikacija_izlaza.AutoSize = True
        Me.linkSpecifikacija_izlaza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkSpecifikacija_izlaza.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkSpecifikacija_izlaza.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkSpecifikacija_izlaza.Location = New System.Drawing.Point(3, 23)
        Me.linkSpecifikacija_izlaza.Name = "linkSpecifikacija_izlaza"
        Me.linkSpecifikacija_izlaza.Size = New System.Drawing.Size(143, 13)
        Me.linkSpecifikacija_izlaza.TabIndex = 6
        Me.linkSpecifikacija_izlaza.TabStop = True
        Me.linkSpecifikacija_izlaza.Text = "Specifikacija izlaza"
        '
        'linkSpecifikacija_ulaza
        '
        Me.linkSpecifikacija_ulaza.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkSpecifikacija_ulaza.AutoSize = True
        Me.linkSpecifikacija_ulaza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkSpecifikacija_ulaza.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkSpecifikacija_ulaza.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkSpecifikacija_ulaza.Location = New System.Drawing.Point(3, 3)
        Me.linkSpecifikacija_ulaza.Name = "linkSpecifikacija_ulaza"
        Me.linkSpecifikacija_ulaza.Size = New System.Drawing.Size(143, 13)
        Me.linkSpecifikacija_ulaza.TabIndex = 11
        Me.linkSpecifikacija_ulaza.TabStop = True
        Me.linkSpecifikacija_ulaza.Text = "Specifikacija ulaza"
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(191, 117)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'cntMeniIzvestaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.tableButtons)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntMeniIzvestaji"
        Me.Size = New System.Drawing.Size(191, 542)
        Me.tableButtons.ResumeLayout(False)
        Me.panAnaliza_Kontejner.ResumeLayout(False)
        Me.panAnaliza_meni.ResumeLayout(False)
        Me.panAnaliza_meni.PerformLayout()
        Me.panPromet_Kontejner.ResumeLayout(False)
        Me.panPromet_meni.ResumeLayout(False)
        Me.panPromet_meni.PerformLayout()
        Me.panSpecifikacije_Kontejner.ResumeLayout(False)
        Me.panSpecifikacije_meni.ResumeLayout(False)
        Me.panSpecifikacije_meni.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tableButtons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panPromet_Kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents panPromet_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkKartica As System.Windows.Forms.LinkLabel
    Friend WithEvents linkNeslaganje As System.Windows.Forms.LinkLabel
    Friend WithEvents btnArtikliPromet As System.Windows.Forms.Button
    Friend WithEvents btnNazad As System.Windows.Forms.Button
    Friend WithEvents btnSpecifikacije As System.Windows.Forms.Button
    Friend WithEvents panSpecifikacije_Kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panSpecifikacije_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkSpec_nivelacije As System.Windows.Forms.LinkLabel
    Friend WithEvents linkAnaliza_izlaz As System.Windows.Forms.LinkLabel
    Friend WithEvents linkAnaliza_ulaz As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkMagacin As System.Windows.Forms.LinkLabel
    Friend WithEvents panAnaliza_Kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents panAnaliza_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkSpecifikacija_izlaza As System.Windows.Forms.LinkLabel
    Friend WithEvents linkSpecifikacija_ulaza As System.Windows.Forms.LinkLabel
    Friend WithEvents btnAnalize As System.Windows.Forms.Button
    Friend WithEvents linkAnaliza_lager As System.Windows.Forms.LinkLabel
    Friend WithEvents linkLager_lista As System.Windows.Forms.LinkLabel

End Class
