<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntRoba
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
        Me.lvRoba = New System.Windows.Forms.ListView
        Me.cSifra = New System.Windows.Forms.ColumnHeader
        Me.cSifraOpis = New System.Windows.Forms.ColumnHeader
        Me.cNaziv = New System.Windows.Forms.ColumnHeader
        Me.cjm = New System.Windows.Forms.ColumnHeader
        Me.cNabCena = New System.Windows.Forms.ColumnHeader
        Me.cNabE = New System.Windows.Forms.ColumnHeader
        Me.cRabat = New System.Windows.Forms.ColumnHeader
        Me.cPdv = New System.Windows.Forms.ColumnHeader
        Me.cCena = New System.Windows.Forms.ColumnHeader
        Me.cCenaE = New System.Windows.Forms.ColumnHeader
        Me.cKolicina = New System.Windows.Forms.ColumnHeader
        Me.cMarza = New System.Windows.Forms.ColumnHeader
        Me.cMinKol = New System.Windows.Forms.ColumnHeader
        Me.cKategorija = New System.Windows.Forms.ColumnHeader
        Me.cBod = New System.Windows.Forms.ColumnHeader
        Me.cCenaBoda = New System.Windows.Forms.ColumnHeader
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSifra = New System.Windows.Forms.TextBox
        Me.txtNaziv = New System.Windows.Forms.TextBox
        Me.cmbKategorija = New System.Windows.Forms.ComboBox
        Me.picRefresh = New System.Windows.Forms.PictureBox
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.picRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lvRoba, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtSifra, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNaziv, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbKategorija, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.picRefresh, 3, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(697, 480)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'lvRoba
        '
        Me.lvRoba.BackColor = System.Drawing.Color.GhostWhite
        Me.lvRoba.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cSifra, Me.cSifraOpis, Me.cNaziv, Me.cjm, Me.cNabCena, Me.cNabE, Me.cRabat, Me.cPdv, Me.cCena, Me.cCenaE, Me.cKolicina, Me.cMarza, Me.cMinKol, Me.cKategorija, Me.cBod, Me.cCenaBoda})
        Me.TableLayoutPanel1.SetColumnSpan(Me.lvRoba, 4)
        Me.lvRoba.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvRoba.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lvRoba.FullRowSelect = True
        Me.lvRoba.GridLines = True
        Me.lvRoba.Location = New System.Drawing.Point(3, 51)
        Me.lvRoba.Name = "lvRoba"
        Me.lvRoba.Size = New System.Drawing.Size(691, 426)
        Me.lvRoba.TabIndex = 19
        Me.lvRoba.UseCompatibleStateImageBehavior = False
        Me.lvRoba.View = System.Windows.Forms.View.Details
        '
        'cSifra
        '
        Me.cSifra.Text = "Šifra"
        Me.cSifra.Width = 85
        '
        'cSifraOpis
        '
        Me.cSifraOpis.Text = "Šifra opis"
        Me.cSifraOpis.Width = 80
        '
        'cNaziv
        '
        Me.cNaziv.Text = "Naziv"
        Me.cNaziv.Width = 160
        '
        'cjm
        '
        Me.cjm.Text = "jm"
        Me.cjm.Width = 50
        '
        'cNabCena
        '
        Me.cNabCena.Text = "Nab.cena"
        Me.cNabCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cNabCena.Width = 80
        '
        'cNabE
        '
        Me.cNabE.Text = "Nab.€"
        Me.cNabE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cRabat
        '
        Me.cRabat.Text = "Rabat"
        Me.cRabat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cPdv
        '
        Me.cPdv.Text = "PDV"
        Me.cPdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cCena
        '
        Me.cCena.Text = "Cena"
        Me.cCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cCena.Width = 80
        '
        'cCenaE
        '
        Me.cCenaE.Text = "Cena €"
        Me.cCenaE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cKolicina
        '
        Me.cKolicina.Text = "Količina"
        Me.cKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cKolicina.Width = 80
        '
        'cMarza
        '
        Me.cMarza.Text = "Marža"
        Me.cMarza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cMinKol
        '
        Me.cMinKol.Text = "Min.kol."
        Me.cMinKol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cMinKol.Width = 80
        '
        'cKategorija
        '
        Me.cKategorija.Text = "Kategorija"
        Me.cKategorija.Width = 100
        '
        'cBod
        '
        Me.cBod.Text = "Bod"
        '
        'cCenaBoda
        '
        Me.cCenaBoda.Text = "Cena boda"
        Me.cCenaBoda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cCenaBoda.Width = 80
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(393, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Osveži"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Šifra"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Naziv"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(243, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Kategorija"
        '
        'txtSifra
        '
        Me.txtSifra.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtSifra.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSifra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSifra.Location = New System.Drawing.Point(3, 25)
        Me.txtSifra.Name = "txtSifra"
        Me.txtSifra.Size = New System.Drawing.Size(100, 20)
        Me.txtSifra.TabIndex = 9
        '
        'txtNaziv
        '
        Me.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtNaziv.BackColor = System.Drawing.Color.GhostWhite
        Me.txtNaziv.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNaziv.Location = New System.Drawing.Point(123, 25)
        Me.txtNaziv.Name = "txtNaziv"
        Me.txtNaziv.Size = New System.Drawing.Size(100, 20)
        Me.txtNaziv.TabIndex = 10
        '
        'cmbKategorija
        '
        Me.cmbKategorija.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmbKategorija.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbKategorija.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbKategorija.FormattingEnabled = True
        Me.cmbKategorija.Location = New System.Drawing.Point(243, 25)
        Me.cmbKategorija.Name = "cmbKategorija"
        Me.cmbKategorija.Size = New System.Drawing.Size(114, 21)
        Me.cmbKategorija.TabIndex = 11
        '
        'picRefresh
        '
        Me.picRefresh.Image = Global.Farma.My.Resources.Resources.reload1
        Me.picRefresh.Location = New System.Drawing.Point(393, 25)
        Me.picRefresh.Name = "picRefresh"
        Me.picRefresh.Size = New System.Drawing.Size(20, 20)
        Me.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRefresh.TabIndex = 13
        Me.picRefresh.TabStop = False
        '
        'cntRoba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "cntRoba"
        Me.Size = New System.Drawing.Size(697, 480)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.picRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSifra As System.Windows.Forms.TextBox
    Friend WithEvents txtNaziv As System.Windows.Forms.TextBox
    Friend WithEvents cmbKategorija As System.Windows.Forms.ComboBox
    Friend WithEvents picRefresh As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lvRoba As System.Windows.Forms.ListView
    Friend WithEvents cSifra As System.Windows.Forms.ColumnHeader
    Friend WithEvents cNaziv As System.Windows.Forms.ColumnHeader
    Friend WithEvents cjm As System.Windows.Forms.ColumnHeader
    Friend WithEvents cNabCena As System.Windows.Forms.ColumnHeader
    Friend WithEvents cNabE As System.Windows.Forms.ColumnHeader
    Friend WithEvents cRabat As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPdv As System.Windows.Forms.ColumnHeader
    Friend WithEvents cCena As System.Windows.Forms.ColumnHeader
    Friend WithEvents cCenaE As System.Windows.Forms.ColumnHeader
    Friend WithEvents cKolicina As System.Windows.Forms.ColumnHeader
    Friend WithEvents cMarza As System.Windows.Forms.ColumnHeader
    Friend WithEvents cMinKol As System.Windows.Forms.ColumnHeader
    Friend WithEvents cKategorija As System.Windows.Forms.ColumnHeader
    Friend WithEvents cBod As System.Windows.Forms.ColumnHeader
    Friend WithEvents cCenaBoda As System.Windows.Forms.ColumnHeader
    Friend WithEvents cSifraOpis As System.Windows.Forms.ColumnHeader

End Class
