﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fkelola_supir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fkelola_supir))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tnohp = New System.Windows.Forms.TextBox()
        Me.Bcancel = New System.Windows.Forms.Button()
        Me.Bexit = New System.Windows.Forms.Button()
        Me.Bedit = New System.Windows.Forms.Button()
        Me.Tnm_supir = New System.Windows.Forms.TextBox()
        Me.Bsave = New System.Windows.Forms.Button()
        Me.DGproduk = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuAksi = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Medit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mhapus = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGproduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuAksi.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Tnohp)
        Me.GroupBox1.Controls.Add(Me.Bcancel)
        Me.GroupBox1.Controls.Add(Me.Bexit)
        Me.GroupBox1.Controls.Add(Me.Bedit)
        Me.GroupBox1.Controls.Add(Me.Tnm_supir)
        Me.GroupBox1.Controls.Add(Me.Bsave)
        Me.GroupBox1.Controls.Add(Me.DGproduk)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(437, 316)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "KELOLA DATA SUPIR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Daftar Supir"
        '
        'Tnohp
        '
        Me.Tnohp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tnohp.Location = New System.Drawing.Point(130, 53)
        Me.Tnohp.Name = "Tnohp"
        Me.Tnohp.Size = New System.Drawing.Size(289, 23)
        Me.Tnohp.TabIndex = 14
        '
        'Bcancel
        '
        Me.Bcancel.BackColor = System.Drawing.Color.Tan
        Me.Bcancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bcancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bcancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bcancel.Location = New System.Drawing.Point(130, 102)
        Me.Bcancel.Name = "Bcancel"
        Me.Bcancel.Size = New System.Drawing.Size(75, 23)
        Me.Bcancel.TabIndex = 5
        Me.Bcancel.Text = "BATAL"
        Me.Bcancel.UseVisualStyleBackColor = False
        '
        'Bexit
        '
        Me.Bexit.BackColor = System.Drawing.Color.Gray
        Me.Bexit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bexit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bexit.Location = New System.Drawing.Point(344, 287)
        Me.Bexit.Name = "Bexit"
        Me.Bexit.Size = New System.Drawing.Size(75, 23)
        Me.Bexit.TabIndex = 2
        Me.Bexit.Text = "KELUAR"
        Me.Bexit.UseVisualStyleBackColor = False
        '
        'Bedit
        '
        Me.Bedit.BackColor = System.Drawing.Color.Tan
        Me.Bedit.Enabled = False
        Me.Bedit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bedit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bedit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bedit.Location = New System.Drawing.Point(236, 102)
        Me.Bedit.Name = "Bedit"
        Me.Bedit.Size = New System.Drawing.Size(75, 23)
        Me.Bedit.TabIndex = 3
        Me.Bedit.Text = "UBAH"
        Me.Bedit.UseVisualStyleBackColor = False
        '
        'Tnm_supir
        '
        Me.Tnm_supir.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tnm_supir.Location = New System.Drawing.Point(130, 24)
        Me.Tnm_supir.Name = "Tnm_supir"
        Me.Tnm_supir.Size = New System.Drawing.Size(289, 23)
        Me.Tnm_supir.TabIndex = 13
        '
        'Bsave
        '
        Me.Bsave.BackColor = System.Drawing.Color.Tan
        Me.Bsave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bsave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bsave.Location = New System.Drawing.Point(344, 102)
        Me.Bsave.Name = "Bsave"
        Me.Bsave.Size = New System.Drawing.Size(75, 23)
        Me.Bsave.TabIndex = 1
        Me.Bsave.Text = "SIMPAN"
        Me.Bsave.UseVisualStyleBackColor = False
        '
        'DGproduk
        '
        Me.DGproduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGproduk.Location = New System.Drawing.Point(16, 153)
        Me.DGproduk.Name = "DGproduk"
        Me.DGproduk.ReadOnly = True
        Me.DGproduk.Size = New System.Drawing.Size(403, 128)
        Me.DGproduk.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nomor Handphone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Supir"
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
        'Fkelola_supir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(456, 337)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fkelola_supir"
        Me.Text = "Kelola Supir"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGproduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuAksi.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGproduk As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Bsave As System.Windows.Forms.Button
    Friend WithEvents Bexit As System.Windows.Forms.Button
    Friend WithEvents Tnm_supir As System.Windows.Forms.TextBox
    Friend WithEvents Bcancel As System.Windows.Forms.Button
    Friend WithEvents Bedit As System.Windows.Forms.Button
    Friend WithEvents MenuAksi As ContextMenuStrip
    Friend WithEvents Medit As ToolStripMenuItem
    Friend WithEvents Mhapus As ToolStripMenuItem
    Friend WithEvents Tnohp As TextBox
    Friend WithEvents Label1 As Label
End Class
