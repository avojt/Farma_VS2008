<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntIzvodi
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
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel
        Me.lvIzvodi = New System.Windows.Forms.ListView
        Me.cIzvodBroj = New System.Windows.Forms.ColumnHeader
        Me.cIzvodDatum = New System.Windows.Forms.ColumnHeader
        Me.cIzvodDuguje = New System.Windows.Forms.ColumnHeader
        Me.cIzvodPotrazuje = New System.Windows.Forms.ColumnHeader
        Me.cIzvodStanje = New System.Windows.Forms.ColumnHeader
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtBrojIzvod = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.dateIzvod = New System.Windows.Forms.DateTimePicker
        Me.picRefreshIzvod = New System.Windows.Forms.PictureBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.picRefreshIzvod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel6.Controls.Add(Me.lvIzvodi, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.Label20, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.txtBrojIzvod, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Label21, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.dateIzvod, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.picRefreshIzvod, 2, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Label22, 2, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 3
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(700, 460)
        Me.TableLayoutPanel6.TabIndex = 4
        '
        'lvIzvodi
        '
        Me.lvIzvodi.BackColor = System.Drawing.Color.GhostWhite
        Me.lvIzvodi.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cIzvodBroj, Me.cIzvodDatum, Me.cIzvodDuguje, Me.cIzvodPotrazuje, Me.cIzvodStanje})
        Me.TableLayoutPanel6.SetColumnSpan(Me.lvIzvodi, 3)
        Me.lvIzvodi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvIzvodi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lvIzvodi.FullRowSelect = True
        Me.lvIzvodi.GridLines = True
        Me.lvIzvodi.Location = New System.Drawing.Point(3, 49)
        Me.lvIzvodi.Name = "lvIzvodi"
        Me.lvIzvodi.Size = New System.Drawing.Size(694, 408)
        Me.lvIzvodi.TabIndex = 0
        Me.lvIzvodi.UseCompatibleStateImageBehavior = False
        Me.lvIzvodi.View = System.Windows.Forms.View.Details
        '
        'cIzvodBroj
        '
        Me.cIzvodBroj.Text = "Broj"
        '
        'cIzvodDatum
        '
        Me.cIzvodDatum.Text = "Datum nivelacije"
        Me.cIzvodDatum.Width = 120
        '
        'cIzvodDuguje
        '
        Me.cIzvodDuguje.Text = "Duguje"
        Me.cIzvodDuguje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cIzvodDuguje.Width = 100
        '
        'cIzvodPotrazuje
        '
        Me.cIzvodPotrazuje.Text = "Potražuje"
        Me.cIzvodPotrazuje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cIzvodPotrazuje.Width = 100
        '
        'cIzvodStanje
        '
        Me.cIzvodStanje.Text = "Stanje"
        Me.cIzvodStanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cIzvodStanje.Width = 100
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 2)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Redni broj"
        '
        'txtBrojIzvod
        '
        Me.txtBrojIzvod.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBrojIzvod.BackColor = System.Drawing.Color.GhostWhite
        Me.txtBrojIzvod.Location = New System.Drawing.Point(3, 22)
        Me.txtBrojIzvod.Name = "txtBrojIzvod"
        Me.txtBrojIzvod.Size = New System.Drawing.Size(100, 20)
        Me.txtBrojIzvod.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(123, 2)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(38, 13)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Datum"
        '
        'dateIzvod
        '
        Me.dateIzvod.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dateIzvod.CalendarForeColor = System.Drawing.Color.MidnightBlue
        Me.dateIzvod.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.dateIzvod.CalendarTitleForeColor = System.Drawing.Color.GhostWhite
        Me.dateIzvod.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateIzvod.Location = New System.Drawing.Point(123, 22)
        Me.dateIzvod.Name = "dateIzvod"
        Me.dateIzvod.Size = New System.Drawing.Size(99, 20)
        Me.dateIzvod.TabIndex = 8
        '
        'picRefreshIzvod
        '
        Me.picRefreshIzvod.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.picRefreshIzvod.Image = Global.Farma.My.Resources.Resources.reload1
        Me.picRefreshIzvod.Location = New System.Drawing.Point(243, 22)
        Me.picRefreshIzvod.Name = "picRefreshIzvod"
        Me.picRefreshIzvod.Size = New System.Drawing.Size(20, 20)
        Me.picRefreshIzvod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRefreshIzvod.TabIndex = 9
        Me.picRefreshIzvod.TabStop = False
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(243, 2)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(39, 13)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "Osveži"
        '
        'cntIzvodi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.TableLayoutPanel6)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntIzvodi"
        Me.Size = New System.Drawing.Size(700, 460)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        CType(Me.picRefreshIzvod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvIzvodi As System.Windows.Forms.ListView
    Friend WithEvents cIzvodBroj As System.Windows.Forms.ColumnHeader
    Friend WithEvents cIzvodDatum As System.Windows.Forms.ColumnHeader
    Friend WithEvents cIzvodDuguje As System.Windows.Forms.ColumnHeader
    Friend WithEvents cIzvodPotrazuje As System.Windows.Forms.ColumnHeader
    Friend WithEvents cIzvodStanje As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtBrojIzvod As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents dateIzvod As System.Windows.Forms.DateTimePicker
    Friend WithEvents picRefreshIzvod As System.Windows.Forms.PictureBox
    Friend WithEvents Label22 As System.Windows.Forms.Label

End Class
