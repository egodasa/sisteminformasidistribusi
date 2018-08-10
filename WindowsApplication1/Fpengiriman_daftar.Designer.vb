<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fpengiriman_daftar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fpengiriman_daftar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tcari = New System.Windows.Forms.TextBox()
        Me.DGpengiriman = New System.Windows.Forms.DataGridView()
        Me.Badd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuAksi = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Medit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mhapus = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGpengiriman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuAksi.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(662, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pencarian"
        '
        'Tcari
        '
        Me.Tcari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tcari.Location = New System.Drawing.Point(723, 50)
        Me.Tcari.Name = "Tcari"
        Me.Tcari.Size = New System.Drawing.Size(167, 20)
        Me.Tcari.TabIndex = 1
        '
        'DGpengiriman
        '
        Me.DGpengiriman.AllowUserToAddRows = False
        Me.DGpengiriman.AllowUserToDeleteRows = False
        Me.DGpengiriman.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGpengiriman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGpengiriman.Location = New System.Drawing.Point(12, 76)
        Me.DGpengiriman.Name = "DGpengiriman"
        Me.DGpengiriman.ReadOnly = True
        Me.DGpengiriman.Size = New System.Drawing.Size(878, 310)
        Me.DGpengiriman.TabIndex = 0
        '
        'Badd
        '
        Me.Badd.BackColor = System.Drawing.Color.Tan
        Me.Badd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Badd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Badd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Badd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Badd.Location = New System.Drawing.Point(12, 50)
        Me.Badd.Name = "Badd"
        Me.Badd.Size = New System.Drawing.Size(159, 23)
        Me.Badd.TabIndex = 7
        Me.Badd.Text = "TAMBAH DATA BARU"
        Me.Badd.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(434, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Daftar Pengiriman Semen PT. Semen Padang"
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
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(777, 396)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "KELUAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Fpengiriman_daftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(902, 431)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Tcari)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Badd)
        Me.Controls.Add(Me.DGpengiriman)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fpengiriman_daftar"
        Me.Text = "Daftar Pengiriman"
        CType(Me.DGpengiriman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuAksi.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tcari As System.Windows.Forms.TextBox
    Friend WithEvents DGpengiriman As System.Windows.Forms.DataGridView
    Friend WithEvents Badd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuAksi As ContextMenuStrip
    Friend WithEvents Medit As ToolStripMenuItem
    Friend WithEvents Mhapus As ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
