<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cntMeniRobno_brisati
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
        Me.panIODok_Kontejner = New System.Windows.Forms.TableLayoutPanel
        Me.Label2 = New System.Windows.Forms.Label
        Me.panMagacini_meni = New System.Windows.Forms.TableLayoutPanel
        Me.linkIODokEdit = New System.Windows.Forms.LinkLabel
        Me.linkIODokUnos = New System.Windows.Forms.LinkLabel
        Me.linkIODokPrint = New System.Windows.Forms.LinkLabel
        Me.linkIODokBrisanje = New System.Windows.Forms.LinkLabel
        Me.linkIODok_search = New System.Windows.Forms.LinkLabel
        Me.btnIODoc = New System.Windows.Forms.Button
        Me.btnNazad = New System.Windows.Forms.Button
        Me.tableButtons.SuspendLayout()
        Me.panIODok_Kontejner.SuspendLayout()
        Me.panMagacini_meni.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableButtons
        '
        Me.tableButtons.ColumnCount = 1
        Me.tableButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableButtons.Controls.Add(Me.panIODok_Kontejner, 0, 1)
        Me.tableButtons.Controls.Add(Me.btnIODoc, 0, 0)
        Me.tableButtons.Controls.Add(Me.btnNazad, 0, 2)
        Me.tableButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tableButtons.Location = New System.Drawing.Point(0, 153)
        Me.tableButtons.Name = "tableButtons"
        Me.tableButtons.RowCount = 3
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableButtons.Size = New System.Drawing.Size(221, 68)
        Me.tableButtons.TabIndex = 0
        '
        'panIODok_Kontejner
        '
        Me.panIODok_Kontejner.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panIODok_Kontejner.ColumnCount = 2
        Me.panIODok_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panIODok_Kontejner.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panIODok_Kontejner.Controls.Add(Me.Label2, 0, 0)
        Me.panIODok_Kontejner.Controls.Add(Me.panMagacini_meni, 1, 0)
        Me.panIODok_Kontejner.Location = New System.Drawing.Point(3, 33)
        Me.panIODok_Kontejner.Name = "panIODok_Kontejner"
        Me.panIODok_Kontejner.RowCount = 1
        Me.panIODok_Kontejner.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panIODok_Kontejner.Size = New System.Drawing.Size(215, 2)
        Me.panIODok_Kontejner.TabIndex = 22
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
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "O P C  I  J  E"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panMagacini_meni
        '
        Me.panMagacini_meni.ColumnCount = 2
        Me.panMagacini_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.panMagacini_meni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panMagacini_meni.Controls.Add(Me.linkIODokEdit, 0, 2)
        Me.panMagacini_meni.Controls.Add(Me.linkIODokUnos, 0, 1)
        Me.panMagacini_meni.Controls.Add(Me.linkIODokPrint, 0, 4)
        Me.panMagacini_meni.Controls.Add(Me.linkIODokBrisanje, 0, 3)
        Me.panMagacini_meni.Controls.Add(Me.linkIODok_search, 0, 0)
        Me.panMagacini_meni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panMagacini_meni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panMagacini_meni.Location = New System.Drawing.Point(33, 3)
        Me.panMagacini_meni.Name = "panMagacini_meni"
        Me.panMagacini_meni.RowCount = 5
        Me.panMagacini_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panMagacini_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panMagacini_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panMagacini_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panMagacini_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panMagacini_meni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panMagacini_meni.Size = New System.Drawing.Size(179, 1)
        Me.panMagacini_meni.TabIndex = 20
        '
        'linkIODokEdit
        '
        Me.linkIODokEdit.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.linkIODokEdit.AutoSize = True
        Me.panMagacini_meni.SetColumnSpan(Me.linkIODokEdit, 2)
        Me.linkIODokEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkIODokEdit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkIODokEdit.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkIODokEdit.Location = New System.Drawing.Point(3, 43)
        Me.linkIODokEdit.Name = "linkIODokEdit"
        Me.linkIODokEdit.Size = New System.Drawing.Size(47, 13)
        Me.linkIODokEdit.TabIndex = 2
        Me.linkIODokEdit.TabStop = True
        Me.linkIODokEdit.Text = "Izmene"
        '
        'linkIODokUnos
        '
        Me.linkIODokUnos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.linkIODokUnos.AutoSize = True
        Me.panMagacini_meni.SetColumnSpan(Me.linkIODokUnos, 2)
        Me.linkIODokUnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkIODokUnos.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkIODokUnos.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkIODokUnos.Location = New System.Drawing.Point(3, 23)
        Me.linkIODokUnos.Name = "linkIODokUnos"
        Me.linkIODokUnos.Size = New System.Drawing.Size(36, 13)
        Me.linkIODokUnos.TabIndex = 1
        Me.linkIODokUnos.TabStop = True
        Me.linkIODokUnos.Text = "Unos"
        '
        'linkIODokPrint
        '
        Me.linkIODokPrint.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.linkIODokPrint.AutoSize = True
        Me.panMagacini_meni.SetColumnSpan(Me.linkIODokPrint, 2)
        Me.linkIODokPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkIODokPrint.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkIODokPrint.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkIODokPrint.Location = New System.Drawing.Point(3, 83)
        Me.linkIODokPrint.Name = "linkIODokPrint"
        Me.linkIODokPrint.Size = New System.Drawing.Size(66, 13)
        Me.linkIODokPrint.TabIndex = 3
        Me.linkIODokPrint.TabStop = True
        Me.linkIODokPrint.Text = "Štampanje"
        '
        'linkIODokBrisanje
        '
        Me.linkIODokBrisanje.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.linkIODokBrisanje.AutoSize = True
        Me.panMagacini_meni.SetColumnSpan(Me.linkIODokBrisanje, 2)
        Me.linkIODokBrisanje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkIODokBrisanje.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkIODokBrisanje.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkIODokBrisanje.Location = New System.Drawing.Point(3, 63)
        Me.linkIODokBrisanje.Name = "linkIODokBrisanje"
        Me.linkIODokBrisanje.Size = New System.Drawing.Size(52, 13)
        Me.linkIODokBrisanje.TabIndex = 5
        Me.linkIODokBrisanje.TabStop = True
        Me.linkIODokBrisanje.Text = "Brisanje"
        '
        'linkIODok_search
        '
        Me.linkIODok_search.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.linkIODok_search.AutoSize = True
        Me.panMagacini_meni.SetColumnSpan(Me.linkIODok_search, 2)
        Me.linkIODok_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkIODok_search.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkIODok_search.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkIODok_search.Location = New System.Drawing.Point(3, 3)
        Me.linkIODok_search.Name = "linkIODok_search"
        Me.linkIODok_search.Size = New System.Drawing.Size(55, 13)
        Me.linkIODok_search.TabIndex = 12
        Me.linkIODok_search.TabStop = True
        Me.linkIODok_search.Text = "Pretraga"
        '
        'btnIODoc
        '
        Me.btnIODoc.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnIODoc.Location = New System.Drawing.Point(3, 3)
        Me.btnIODoc.Name = "btnIODoc"
        Me.btnIODoc.Size = New System.Drawing.Size(187, 24)
        Me.btnIODoc.TabIndex = 2
        Me.btnIODoc.Text = "ULAZNO-IZLAZNI DOKUMENTI"
        Me.btnIODoc.UseVisualStyleBackColor = True
        '
        'btnNazad
        '
        Me.btnNazad.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnNazad.Location = New System.Drawing.Point(3, 41)
        Me.btnNazad.Name = "btnNazad"
        Me.btnNazad.Size = New System.Drawing.Size(187, 24)
        Me.btnNazad.TabIndex = 4
        Me.btnNazad.Text = "NAZAD"
        Me.btnNazad.UseVisualStyleBackColor = True
        '
        'cntMeniRobno_brisati
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.tableButtons)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "cntMeniRobno_brisati"
        Me.Size = New System.Drawing.Size(221, 221)
        Me.tableButtons.ResumeLayout(False)
        Me.panIODok_Kontejner.ResumeLayout(False)
        Me.panMagacini_meni.ResumeLayout(False)
        Me.panMagacini_meni.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tableButtons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnIODoc As System.Windows.Forms.Button
    Friend WithEvents btnNazad As System.Windows.Forms.Button
    Friend WithEvents panMagacini_meni As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkIODokEdit As System.Windows.Forms.LinkLabel
    Friend WithEvents linkIODokUnos As System.Windows.Forms.LinkLabel
    Friend WithEvents linkIODokPrint As System.Windows.Forms.LinkLabel
    Friend WithEvents linkIODokBrisanje As System.Windows.Forms.LinkLabel
    Friend WithEvents panIODok_Kontejner As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents linkIODok_search As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
