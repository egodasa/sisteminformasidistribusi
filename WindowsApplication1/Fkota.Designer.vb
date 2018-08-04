<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fkota
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fkota))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Ttarif = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGsatuan = New System.Windows.Forms.DataGridView()
        Me.Tnm_kota = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Bexit = New System.Windows.Forms.Button()
        Me.Bcancel = New System.Windows.Forms.Button()
        Me.Bedit = New System.Windows.Forms.Button()
        Me.Bsave = New System.Windows.Forms.Button()
        Me.MenuAksi = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Medit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mhapus = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Ttarif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGsatuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuAksi.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Ttarif)
        Me.GroupBox1.Controls.Add(Me.Bedit)
        Me.GroupBox1.Controls.Add(Me.Bsave)
        Me.GroupBox1.Controls.Add(Me.Bexit)
        Me.GroupBox1.Controls.Add(Me.Bcancel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DGsatuan)
        Me.GroupBox1.Controls.Add(Me.Tnm_kota)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 350)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "KELOLA DATA KOTA"
        '
        'Ttarif
        '
        Me.Ttarif.Increment = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.Ttarif.Location = New System.Drawing.Point(91, 64)
        Me.Ttarif.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.Ttarif.Name = "Ttarif"
        Me.Ttarif.Size = New System.Drawing.Size(209, 23)
        Me.Ttarif.TabIndex = 14
        Me.Ttarif.ThousandsSeparator = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Tarif"
        '
        'DGsatuan
        '
        Me.DGsatuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGsatuan.Location = New System.Drawing.Point(6, 175)
        Me.DGsatuan.Name = "DGsatuan"
        Me.DGsatuan.ReadOnly = True
        Me.DGsatuan.Size = New System.Drawing.Size(294, 140)
        Me.DGsatuan.TabIndex = 12
        '
        'Tnm_kota
        '
        Me.Tnm_kota.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tnm_kota.Location = New System.Drawing.Point(91, 27)
        Me.Tnm_kota.Name = "Tnm_kota"
        Me.Tnm_kota.Size = New System.Drawing.Size(209, 23)
        Me.Tnm_kota.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Kota"
        '
        'Bexit
        '
        Me.Bexit.BackColor = System.Drawing.Color.Gray
        Me.Bexit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bexit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bexit.Location = New System.Drawing.Point(225, 321)
        Me.Bexit.Name = "Bexit"
        Me.Bexit.Size = New System.Drawing.Size(75, 23)
        Me.Bexit.TabIndex = 2
        Me.Bexit.Text = "KELUAR"
        Me.Bexit.UseVisualStyleBackColor = False
        '
        'Bcancel
        '
        Me.Bcancel.BackColor = System.Drawing.Color.Tan
        Me.Bcancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bcancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bcancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bcancel.Location = New System.Drawing.Point(10, 105)
        Me.Bcancel.Name = "Bcancel"
        Me.Bcancel.Size = New System.Drawing.Size(75, 23)
        Me.Bcancel.TabIndex = 5
        Me.Bcancel.Text = "BATAL"
        Me.Bcancel.UseVisualStyleBackColor = False
        '
        'Bedit
        '
        Me.Bedit.BackColor = System.Drawing.Color.Tan
        Me.Bedit.Enabled = False
        Me.Bedit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bedit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bedit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bedit.Location = New System.Drawing.Point(123, 105)
        Me.Bedit.Name = "Bedit"
        Me.Bedit.Size = New System.Drawing.Size(75, 23)
        Me.Bedit.TabIndex = 3
        Me.Bedit.Text = "UBAH"
        Me.Bedit.UseVisualStyleBackColor = False
        '
        'Bsave
        '
        Me.Bsave.BackColor = System.Drawing.Color.Tan
        Me.Bsave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bsave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bsave.Location = New System.Drawing.Point(225, 105)
        Me.Bsave.Name = "Bsave"
        Me.Bsave.Size = New System.Drawing.Size(75, 23)
        Me.Bsave.TabIndex = 1
        Me.Bsave.Text = "SIMPAN"
        Me.Bsave.UseVisualStyleBackColor = False
        '
        'MenuAksi
        '
        Me.MenuAksi.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Medit, Me.Mhapus})
        Me.MenuAksi.Name = "MenuAksi"
        Me.MenuAksi.Size = New System.Drawing.Size(109, 48)
        '
        'Medit
        '
        Me.Medit.Image = CType(resources.GetObject("Medit.Image"), System.Drawing.Image)
        Me.Medit.Name = "Medit"
        Me.Medit.Size = New System.Drawing.Size(108, 22)
        Me.Medit.Text = "Edit"
        '
        'Mhapus
        '
        Me.Mhapus.Image = CType(resources.GetObject("Mhapus.Image"), System.Drawing.Image)
        Me.Mhapus.Name = "Mhapus"
        Me.Mhapus.Size = New System.Drawing.Size(108, 22)
        Me.Mhapus.Text = "Hapus"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Daftar Tarif Kota"
        '
        'Fkota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(334, 371)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fkota"
        Me.Text = "Daftar Kota"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Ttarif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGsatuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuAksi.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGsatuan As System.Windows.Forms.DataGridView
    Friend WithEvents Tnm_kota As System.Windows.Forms.TextBox
    Friend WithEvents Bcancel As System.Windows.Forms.Button
    Friend WithEvents Bedit As System.Windows.Forms.Button
    Friend WithEvents Bexit As System.Windows.Forms.Button
    Friend WithEvents Bsave As System.Windows.Forms.Button
    Friend WithEvents MenuAksi As ContextMenuStrip
    Friend WithEvents Medit As ToolStripMenuItem
    Friend WithEvents Mhapus As ToolStripMenuItem
    Friend WithEvents Ttarif As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
