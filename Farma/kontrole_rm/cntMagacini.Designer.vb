<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntMagacini
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
        Me.lvMagacini = New System.Windows.Forms.ListView
        Me.cSifra = New System.Windows.Forms.ColumnHeader
        Me.cNaziv = New System.Windows.Forms.ColumnHeader
        Me.cVrsta_mag = New System.Windows.Forms.ColumnHeader
        Me.cVodjenje_zaliha = New System.Windows.Forms.ColumnHeader
        Me.cId_vodjenja_zaliha = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSifra = New System.Windows.Forms.TextBox
        Me.txtNaziv = New System.Windows.Forms.TextBox
        Me.picRefresh = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.picRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 472.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lvMagacini, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtSifra, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNaziv, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.picRefresh, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(649, 444)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'lvMagacini
        '
        Me.lvMagacini.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvMagacini.BackColor = System.Drawing.Color.GhostWhite
        Me.lvMagacini.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cSifra, Me.cNaziv, Me.cVrsta_mag, Me.cVodjenje_zaliha, Me.cId_vodjenja_zaliha})
        Me.TableLayoutPanel1.SetColumnSpan(Me.lvMagacini, 3)
        Me.lvMagacini.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvMagacini.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lvMagacini.FullRowSelect = True
        Me.lvMagacini.GridLines = True
        Me.lvMagacini.LabelEdit = True
        Me.lvMagacini.Location = New System.Drawing.Point(3, 51)
        Me.lvMagacini.Name = "lvMagacini"
        Me.lvMagacini.Size = New System.Drawing.Size(706, 390)
        Me.lvMagacini.TabIndex = 19
        Me.lvMagacini.UseCompatibleStateImageBehavior = False
        Me.lvMagacini.View = System.Windows.Forms.View.Details
        '
        'cSifra
        '
        Me.cSifra.Tag = "Šifra magacina"
        Me.cSifra.Text = "Šifra"
        Me.cSifra.Width = 85
        '
        'cNaziv
        '
        Me.cNaziv.Tag = "Naziv magacina"
        Me.cNaziv.Text = "Naziv"
        Me.cNaziv.Width = 200
        '
        'cVrsta_mag
        '
        Me.cVrsta_mag.Text = "Vrsta magacina"
        Me.cVrsta_mag.Width = 90
        '
        'cVodjenje_zaliha
        '
        Me.cVodjenje_zaliha.Tag = "Dali se vode zalihe ili ne?"
        Me.cVodjenje_zaliha.Text = "Vodjenje zaliha"
        Me.cVodjenje_zaliha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cVodjenje_zaliha.Width = 90
        '
        'cId_vodjenja_zaliha
        '
        Me.cId_vodjenja_zaliha.Tag = "Način vodjenja zaliha"
        Me.cId_vodjenja_zaliha.Text = "Način vodjenja zaliha"
        Me.cId_vodjenja_zaliha.Width = 100
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
        'picRefresh
        '
        Me.picRefresh.Image = Global.Farma.My.Resources.Resources.reload1
        Me.picRefresh.Location = New System.Drawing.Point(243, 25)
        Me.picRefresh.Name = "picRefresh"
        Me.picRefresh.Size = New System.Drawing.Size(20, 20)
        Me.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRefresh.TabIndex = 13
        Me.picRefresh.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(243, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Osveži"
        '
        'cntMagacini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntMagacini"
        Me.Size = New System.Drawing.Size(649, 444)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.picRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvMagacini As System.Windows.Forms.ListView
    Friend WithEvents cSifra As System.Windows.Forms.ColumnHeader
    Friend WithEvents cNaziv As System.Windows.Forms.ColumnHeader
    Friend WithEvents cVrsta_mag As System.Windows.Forms.ColumnHeader
    Friend WithEvents cVodjenje_zaliha As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSifra As System.Windows.Forms.TextBox
    Friend WithEvents txtNaziv As System.Windows.Forms.TextBox
    Friend WithEvents picRefresh As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cId_vodjenja_zaliha As System.Windows.Forms.ColumnHeader

End Class
