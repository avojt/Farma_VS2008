<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntNalozi_staro
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
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.tabControl = New System.Windows.Forms.TabControl
        Me.tabDnevnik = New System.Windows.Forms.TabPage
        Me.lvNalozi = New System.Windows.Forms.ListView
        Me.cBroj = New System.Windows.Forms.ColumnHeader
        Me.cDatum = New System.Windows.Forms.ColumnHeader
        Me.cDuguje = New System.Windows.Forms.ColumnHeader
        Me.cPotrazuje = New System.Windows.Forms.ColumnHeader
        Me.cProknjižen = New System.Windows.Forms.ColumnHeader
        Me.tabGlavnaK = New System.Windows.Forms.TabPage
        Me.lvGlavnaK = New System.Windows.Forms.ListView
        Me.cDatumGl = New System.Windows.Forms.ColumnHeader
        Me.cKonto = New System.Windows.Forms.ColumnHeader
        Me.cAnalitika = New System.Windows.Forms.ColumnHeader
        Me.cOpis = New System.Windows.Forms.ColumnHeader
        Me.cDugujeGl = New System.Windows.Forms.ColumnHeader
        Me.cPotrazujeGl = New System.Windows.Forms.ColumnHeader
        Me.dateKnjizenjaOD = New System.Windows.Forms.DateTimePicker
        Me.Label21 = New System.Windows.Forms.Label
        Me.picRefresh1 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtKonto = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtBroj = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dateKnjizenjaDO = New System.Windows.Forms.DateTimePicker
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tabControl.SuspendLayout()
        Me.tabDnevnik.SuspendLayout()
        Me.tabGlavnaK.SuspendLayout()
        CType(Me.picRefresh1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.tabControl, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.dateKnjizenjaOD, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label21, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.picRefresh1, 4, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtKonto, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label18, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtBroj, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.dateKnjizenjaDO, 1, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(673, 453)
        Me.TableLayoutPanel3.TabIndex = 9
        '
        'tabControl
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.tabControl, 5)
        Me.tabControl.Controls.Add(Me.tabDnevnik)
        Me.tabControl.Controls.Add(Me.tabGlavnaK)
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl.Location = New System.Drawing.Point(3, 51)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(667, 399)
        Me.tabControl.TabIndex = 21
        '
        'tabDnevnik
        '
        Me.tabDnevnik.AutoScroll = True
        Me.tabDnevnik.BackColor = System.Drawing.Color.Lavender
        Me.tabDnevnik.Controls.Add(Me.lvNalozi)
        Me.tabDnevnik.Location = New System.Drawing.Point(4, 22)
        Me.tabDnevnik.Name = "tabDnevnik"
        Me.tabDnevnik.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDnevnik.Size = New System.Drawing.Size(659, 373)
        Me.tabDnevnik.TabIndex = 0
        Me.tabDnevnik.Text = "Dnevnik knjiženja"
        Me.tabDnevnik.UseVisualStyleBackColor = True
        '
        'lvNalozi
        '
        Me.lvNalozi.BackColor = System.Drawing.Color.GhostWhite
        Me.lvNalozi.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cBroj, Me.cDatum, Me.cDuguje, Me.cPotrazuje, Me.cProknjižen})
        Me.lvNalozi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvNalozi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lvNalozi.FullRowSelect = True
        Me.lvNalozi.GridLines = True
        Me.lvNalozi.Location = New System.Drawing.Point(3, 3)
        Me.lvNalozi.Name = "lvNalozi"
        Me.lvNalozi.Size = New System.Drawing.Size(653, 367)
        Me.lvNalozi.TabIndex = 18
        Me.lvNalozi.UseCompatibleStateImageBehavior = False
        Me.lvNalozi.View = System.Windows.Forms.View.Details
        '
        'cBroj
        '
        Me.cBroj.Text = "Broj"
        '
        'cDatum
        '
        Me.cDatum.Text = "Datum"
        Me.cDatum.Width = 100
        '
        'cDuguje
        '
        Me.cDuguje.Text = "Duguje"
        Me.cDuguje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cDuguje.Width = 110
        '
        'cPotrazuje
        '
        Me.cPotrazuje.Text = "Potražuje"
        Me.cPotrazuje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cPotrazuje.Width = 110
        '
        'cProknjižen
        '
        Me.cProknjižen.Text = "Proknjižen"
        Me.cProknjižen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cProknjižen.Width = 80
        '
        'tabGlavnaK
        '
        Me.tabGlavnaK.Controls.Add(Me.lvGlavnaK)
        Me.tabGlavnaK.Location = New System.Drawing.Point(4, 22)
        Me.tabGlavnaK.Name = "tabGlavnaK"
        Me.tabGlavnaK.Size = New System.Drawing.Size(659, 373)
        Me.tabGlavnaK.TabIndex = 1
        Me.tabGlavnaK.Text = "Glavna knjiga"
        Me.tabGlavnaK.UseVisualStyleBackColor = True
        '
        'lvGlavnaK
        '
        Me.lvGlavnaK.BackColor = System.Drawing.Color.GhostWhite
        Me.lvGlavnaK.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cDatumGl, Me.cKonto, Me.cAnalitika, Me.cOpis, Me.cDugujeGl, Me.cPotrazujeGl})
        Me.lvGlavnaK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvGlavnaK.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lvGlavnaK.FullRowSelect = True
        Me.lvGlavnaK.GridLines = True
        Me.lvGlavnaK.Location = New System.Drawing.Point(0, 0)
        Me.lvGlavnaK.Name = "lvGlavnaK"
        Me.lvGlavnaK.Size = New System.Drawing.Size(659, 373)
        Me.lvGlavnaK.TabIndex = 19
        Me.lvGlavnaK.UseCompatibleStateImageBehavior = False
        Me.lvGlavnaK.View = System.Windows.Forms.View.Details
        '
        'cDatumGl
        '
        Me.cDatumGl.Text = "Datum"
        Me.cDatumGl.Width = 100
        '
        'cKonto
        '
        Me.cKonto.Text = "Konto"
        Me.cKonto.Width = 70
        '
        'cAnalitika
        '
        Me.cAnalitika.Text = "Analitika"
        Me.cAnalitika.Width = 70
        '
        'cOpis
        '
        Me.cOpis.Text = "Opis"
        Me.cOpis.Width = 200
        '
        'cDugujeGl
        '
        Me.cDugujeGl.Text = "Duguje"
        Me.cDugujeGl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cDugujeGl.Width = 90
        '
        'cPotrazujeGl
        '
        Me.cPotrazujeGl.Text = "Potražuje"
        Me.cPotrazujeGl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cPotrazujeGl.Width = 90
        '
        'dateKnjizenjaOD
        '
        Me.dateKnjizenjaOD.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.dateKnjizenjaOD.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.dateKnjizenjaOD.CalendarTitleForeColor = System.Drawing.Color.GhostWhite
        Me.dateKnjizenjaOD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateKnjizenjaOD.Location = New System.Drawing.Point(3, 25)
        Me.dateKnjizenjaOD.Name = "dateKnjizenjaOD"
        Me.dateKnjizenjaOD.Size = New System.Drawing.Size(92, 20)
        Me.dateKnjizenjaOD.TabIndex = 12
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label21.Location = New System.Drawing.Point(3, 4)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(101, 13)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Datum knjiženja OD"
        '
        'picRefresh1
        '
        Me.picRefresh1.Image = Global.Farma.My.Resources.Resources.reload1
        Me.picRefresh1.Location = New System.Drawing.Point(483, 25)
        Me.picRefresh1.Name = "picRefresh1"
        Me.picRefresh1.Size = New System.Drawing.Size(20, 20)
        Me.picRefresh1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRefresh1.TabIndex = 19
        Me.picRefresh1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(483, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Osveži"
        '
        'txtKonto
        '
        Me.txtKonto.BackColor = System.Drawing.Color.GhostWhite
        Me.txtKonto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtKonto.Location = New System.Drawing.Point(363, 25)
        Me.txtKonto.Name = "txtKonto"
        Me.txtKonto.Size = New System.Drawing.Size(100, 20)
        Me.txtKonto.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(363, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Konto"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label18.Location = New System.Drawing.Point(243, 4)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Broj naloga"
        '
        'txtBroj
        '
        Me.txtBroj.BackColor = System.Drawing.Color.GhostWhite
        Me.txtBroj.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBroj.Location = New System.Drawing.Point(243, 25)
        Me.txtBroj.Name = "txtBroj"
        Me.txtBroj.Size = New System.Drawing.Size(100, 20)
        Me.txtBroj.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(123, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Datum knjiženja DO"
        '
        'dateKnjizenjaDO
        '
        Me.dateKnjizenjaDO.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.dateKnjizenjaDO.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.dateKnjizenjaDO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateKnjizenjaDO.Location = New System.Drawing.Point(123, 25)
        Me.dateKnjizenjaDO.Name = "dateKnjizenjaDO"
        Me.dateKnjizenjaDO.Size = New System.Drawing.Size(92, 20)
        Me.dateKnjizenjaDO.TabIndex = 25
        '
        'cntNalozi_staro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Name = "cntNalozi_staro"
        Me.Size = New System.Drawing.Size(673, 453)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.tabControl.ResumeLayout(False)
        Me.tabDnevnik.ResumeLayout(False)
        Me.tabGlavnaK.ResumeLayout(False)
        CType(Me.picRefresh1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tabControl As System.Windows.Forms.TabControl
    Friend WithEvents tabDnevnik As System.Windows.Forms.TabPage
    Friend WithEvents lvNalozi As System.Windows.Forms.ListView
    Friend WithEvents cBroj As System.Windows.Forms.ColumnHeader
    Friend WithEvents cDatum As System.Windows.Forms.ColumnHeader
    Friend WithEvents cDuguje As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPotrazuje As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtBroj As System.Windows.Forms.TextBox
    Friend WithEvents dateKnjizenjaOD As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents picRefresh1 As System.Windows.Forms.PictureBox
    Friend WithEvents cProknjižen As System.Windows.Forms.ColumnHeader
    Friend WithEvents tabGlavnaK As System.Windows.Forms.TabPage
    Friend WithEvents lvGlavnaK As System.Windows.Forms.ListView
    Friend WithEvents cDatumGl As System.Windows.Forms.ColumnHeader
    Friend WithEvents cKonto As System.Windows.Forms.ColumnHeader
    Friend WithEvents cAnalitika As System.Windows.Forms.ColumnHeader
    Friend WithEvents cDugujeGl As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPotrazujeGl As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKonto As System.Windows.Forms.TextBox
    Friend WithEvents cOpis As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dateKnjizenjaDO As System.Windows.Forms.DateTimePicker

End Class
