<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntUlazniRacuni
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
        Me.Label9 = New System.Windows.Forms.Label
        Me.lvRacuni = New System.Windows.Forms.ListView
        Me.cBroj = New System.Windows.Forms.ColumnHeader
        Me.cPartner = New System.Windows.Forms.ColumnHeader
        Me.cFaktura = New System.Windows.Forms.ColumnHeader
        Me.cDatumFakt = New System.Windows.Forms.ColumnHeader
        Me.cValuta = New System.Windows.Forms.ColumnHeader
        Me.cCena = New System.Windows.Forms.ColumnHeader
        Me.cRabat = New System.Windows.Forms.ColumnHeader
        Me.cPdv = New System.Windows.Forms.ColumnHeader
        Me.cUplata = New System.Windows.Forms.ColumnHeader
        Me.cNapomena = New System.Windows.Forms.ColumnHeader
        Me.cUnesen = New System.Windows.Forms.ColumnHeader
        Me.cPlacen = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBroj = New System.Windows.Forms.TextBox
        Me.cmbPartneri = New System.Windows.Forms.ComboBox
        Me.txtIznos = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dateFakturisanje = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtBrFaktura = New System.Windows.Forms.TextBox
        Me.picRefresh = New System.Windows.Forms.PictureBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.picNivelRefresh = New System.Windows.Forms.PictureBox
        Me.datFarmavelacije = New System.Windows.Forms.DateTimePicker
        Me.Label16 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.picRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNivelRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lvRacuni, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBroj, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbPartneri, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtIznos, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dateFakturisanje, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBrFaktura, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.picRefresh, 5, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(721, 477)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(603, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Osveži"
        '
        'lvRacuni
        '
        Me.lvRacuni.BackColor = System.Drawing.Color.GhostWhite
        Me.lvRacuni.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cBroj, Me.cPartner, Me.cFaktura, Me.cDatumFakt, Me.cValuta, Me.cCena, Me.cRabat, Me.cPdv, Me.cUplata, Me.cNapomena, Me.cUnesen, Me.cPlacen})
        Me.TableLayoutPanel1.SetColumnSpan(Me.lvRacuni, 6)
        Me.lvRacuni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvRacuni.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lvRacuni.FullRowSelect = True
        Me.lvRacuni.GridLines = True
        Me.lvRacuni.Location = New System.Drawing.Point(3, 51)
        Me.lvRacuni.Name = "lvRacuni"
        Me.lvRacuni.Size = New System.Drawing.Size(715, 423)
        Me.lvRacuni.TabIndex = 18
        Me.lvRacuni.UseCompatibleStateImageBehavior = False
        Me.lvRacuni.View = System.Windows.Forms.View.Details
        '
        'cBroj
        '
        Me.cBroj.Text = "Broj"
        Me.cBroj.Width = 50
        '
        'cPartner
        '
        Me.cPartner.Text = "Partner"
        Me.cPartner.Width = 100
        '
        'cFaktura
        '
        Me.cFaktura.Text = "Broj fakture"
        Me.cFaktura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cFaktura.Width = 70
        '
        'cDatumFakt
        '
        Me.cDatumFakt.Text = "Datum fakturisanja"
        Me.cDatumFakt.Width = 110
        '
        'cValuta
        '
        Me.cValuta.Text = "Valuta"
        Me.cValuta.Width = 110
        '
        'cCena
        '
        Me.cCena.Text = "Cena"
        Me.cCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cCena.Width = 100
        '
        'cRabat
        '
        Me.cRabat.Text = "Rabat"
        Me.cRabat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cRabat.Width = 80
        '
        'cPdv
        '
        Me.cPdv.Text = "PDV"
        Me.cPdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cPdv.Width = 80
        '
        'cUplata
        '
        Me.cUplata.Text = "Za uplatu"
        Me.cUplata.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cUplata.Width = 100
        '
        'cNapomena
        '
        Me.cNapomena.Text = "Napomena"
        Me.cNapomena.Width = 120
        '
        'cUnesen
        '
        Me.cUnesen.Text = "Unešen"
        Me.cUnesen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cUnesen.Width = 50
        '
        'cPlacen
        '
        Me.cPlacen.Text = "Plaćen"
        Me.cPlacen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cPlacen.Width = 50
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Rb. u KUR"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(123, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Naziv partnera"
        '
        'txtBroj
        '
        Me.txtBroj.BackColor = System.Drawing.Color.GhostWhite
        Me.txtBroj.Location = New System.Drawing.Point(3, 25)
        Me.txtBroj.Name = "txtBroj"
        Me.txtBroj.Size = New System.Drawing.Size(100, 20)
        Me.txtBroj.TabIndex = 9
        '
        'cmbPartneri
        '
        Me.cmbPartneri.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbPartneri.FormattingEnabled = True
        Me.cmbPartneri.Location = New System.Drawing.Point(123, 25)
        Me.cmbPartneri.Name = "cmbPartneri"
        Me.cmbPartneri.Size = New System.Drawing.Size(114, 21)
        Me.cmbPartneri.TabIndex = 15
        '
        'txtIznos
        '
        Me.txtIznos.BackColor = System.Drawing.Color.GhostWhite
        Me.txtIznos.Location = New System.Drawing.Point(483, 25)
        Me.txtIznos.Name = "txtIznos"
        Me.txtIznos.Size = New System.Drawing.Size(100, 20)
        Me.txtIznos.TabIndex = 14
        Me.txtIznos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(483, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Iznosi veći od..."
        '
        'dateFakturisanje
        '
        Me.dateFakturisanje.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFakturisanje.Location = New System.Drawing.Point(363, 25)
        Me.dateFakturisanje.Name = "dateFakturisanje"
        Me.dateFakturisanje.Size = New System.Drawing.Size(92, 20)
        Me.dateFakturisanje.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(363, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Datum fakturisanja"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(243, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Faktura"
        '
        'txtBrFaktura
        '
        Me.txtBrFaktura.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBrFaktura.BackColor = System.Drawing.Color.GhostWhite
        Me.txtBrFaktura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBrFaktura.Location = New System.Drawing.Point(243, 25)
        Me.txtBrFaktura.Name = "txtBrFaktura"
        Me.txtBrFaktura.Size = New System.Drawing.Size(100, 20)
        Me.txtBrFaktura.TabIndex = 17
        '
        'picRefresh
        '
        Me.picRefresh.Image = Global.Farma.My.Resources.Resources.reload1
        Me.picRefresh.Location = New System.Drawing.Point(603, 25)
        Me.picRefresh.Name = "picRefresh"
        Me.picRefresh.Size = New System.Drawing.Size(20, 20)
        Me.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRefresh.TabIndex = 19
        Me.picRefresh.TabStop = False
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 23)
        Me.Label17.TabIndex = 0
        '
        'picNivelRefresh
        '
        Me.picNivelRefresh.Location = New System.Drawing.Point(0, 0)
        Me.picNivelRefresh.Name = "picNivelRefresh"
        Me.picNivelRefresh.Size = New System.Drawing.Size(100, 50)
        Me.picNivelRefresh.TabIndex = 0
        Me.picNivelRefresh.TabStop = False
        '
        'datFarmavelacije
        '
        Me.datFarmavelacije.CalendarTitleForeColor = System.Drawing.Color.GhostWhite
        Me.datFarmavelacije.Location = New System.Drawing.Point(0, 0)
        Me.datFarmavelacije.Name = "datFarmavelacije"
        Me.datFarmavelacije.Size = New System.Drawing.Size(200, 20)
        Me.datFarmavelacije.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 23)
        Me.Label16.TabIndex = 0
        '
        'cntUlazniRacuni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntUlazniRacuni"
        Me.Size = New System.Drawing.Size(721, 477)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.picRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNivelRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBroj As System.Windows.Forms.TextBox
    Friend WithEvents dateFakturisanje As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtIznos As System.Windows.Forms.TextBox
    Friend WithEvents cmbPartneri As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBrFaktura As System.Windows.Forms.TextBox
    Friend WithEvents lvRacuni As System.Windows.Forms.ListView
    Friend WithEvents cBroj As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPartner As System.Windows.Forms.ColumnHeader
    Friend WithEvents cDatumFakt As System.Windows.Forms.ColumnHeader
    Friend WithEvents cValuta As System.Windows.Forms.ColumnHeader
    Friend WithEvents cCena As System.Windows.Forms.ColumnHeader
    Friend WithEvents cRabat As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPdv As System.Windows.Forms.ColumnHeader
    Friend WithEvents cUplata As System.Windows.Forms.ColumnHeader
    Friend WithEvents cNapomena As System.Windows.Forms.ColumnHeader
    Friend WithEvents cUnesen As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPlacen As System.Windows.Forms.ColumnHeader
    Friend WithEvents cFaktura As System.Windows.Forms.ColumnHeader
    Friend WithEvents picRefresh As System.Windows.Forms.PictureBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents picNivelRefresh As System.Windows.Forms.PictureBox
    Friend WithEvents datFarmavelacije As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
