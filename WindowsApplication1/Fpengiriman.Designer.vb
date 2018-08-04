<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fpengiriman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fpengiriman))
        Me.Bcancel = New System.Windows.Forms.Button()
        Me.Bexit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Ckota = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tno_do = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Tuang_jalan = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Ttotal_ongkos = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tsisa = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tton = New System.Windows.Forms.NumericUpDown()
        Me.Tsak = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Badd = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Ttotal_tarif = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Ttotal_biaya_truk = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Ttarif = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Tbiaya_truk = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Ctruk = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Cagen = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Tnohp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Csupir = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Ttgl_sampai = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Ttgl_berangkat = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tketerangan = New System.Windows.Forms.TextBox()
        Me.MenuAksi = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Mhapus = New System.Windows.Forms.ToolStripMenuItem()
        Me.BWsimpan = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.Tuang_jalan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ttotal_ongkos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tsisa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.Tton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tsak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Ttotal_tarif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ttotal_biaya_truk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ttarif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbiaya_truk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuAksi.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bcancel
        '
        Me.Bcancel.BackColor = System.Drawing.Color.Tan
        Me.Bcancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bcancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bcancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bcancel.Location = New System.Drawing.Point(566, 240)
        Me.Bcancel.Name = "Bcancel"
        Me.Bcancel.Size = New System.Drawing.Size(98, 23)
        Me.Bcancel.TabIndex = 5
        Me.Bcancel.Text = "RESET"
        Me.Bcancel.UseVisualStyleBackColor = False
        '
        'Bexit
        '
        Me.Bexit.BackColor = System.Drawing.Color.Gray
        Me.Bexit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bexit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bexit.Location = New System.Drawing.Point(626, 323)
        Me.Bexit.Name = "Bexit"
        Me.Bexit.Size = New System.Drawing.Size(240, 23)
        Me.Bexit.TabIndex = 2
        Me.Bexit.Text = "KEMBALI KE DAFTAR PENGIRIMAN ->"
        Me.Bexit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBox1.Controls.Add(Me.Bexit)
        Me.GroupBox1.Controls.Add(Me.Ckota)
        Me.GroupBox1.Controls.Add(Me.Bcancel)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Tno_do)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.Badd)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Ttgl_sampai)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Ttgl_berangkat)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Tketerangan)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(879, 361)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Pengiriman Semen"
        '
        'Ckota
        '
        Me.Ckota.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Ckota.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Ckota.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ckota.FormattingEnabled = True
        Me.Ckota.Items.AddRange(New Object() {"q"})
        Me.Ckota.Location = New System.Drawing.Point(608, 41)
        Me.Ckota.Name = "Ckota"
        Me.Ckota.Size = New System.Drawing.Size(185, 23)
        Me.Ckota.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(605, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 15)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Kota Tujuan"
        '
        'Tno_do
        '
        Me.Tno_do.Location = New System.Drawing.Point(22, 41)
        Me.Tno_do.Name = "Tno_do"
        Me.Tno_do.Size = New System.Drawing.Size(157, 23)
        Me.Tno_do.TabIndex = 41
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(19, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 15)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Nomor DO"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.Tuang_jalan)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.Ttotal_ongkos)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.Tsisa)
        Me.GroupBox7.Location = New System.Drawing.Point(21, 253)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(536, 93)
        Me.GroupBox7.TabIndex = 48
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Data Biaya Perjalanan"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(281, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 15)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Uang Jalan"
        '
        'Tuang_jalan
        '
        Me.Tuang_jalan.Location = New System.Drawing.Point(389, 54)
        Me.Tuang_jalan.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.Tuang_jalan.Name = "Tuang_jalan"
        Me.Tuang_jalan.Size = New System.Drawing.Size(137, 23)
        Me.Tuang_jalan.TabIndex = 35
        Me.Tuang_jalan.ThousandsSeparator = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(281, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Total Ongkos"
        '
        'Ttotal_ongkos
        '
        Me.Ttotal_ongkos.Location = New System.Drawing.Point(389, 25)
        Me.Ttotal_ongkos.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.Ttotal_ongkos.Name = "Ttotal_ongkos"
        Me.Ttotal_ongkos.Size = New System.Drawing.Size(137, 23)
        Me.Ttotal_ongkos.TabIndex = 33
        Me.Ttotal_ongkos.ThousandsSeparator = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 15)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Sisa Uang Jalan"
        '
        'Tsisa
        '
        Me.Tsisa.Location = New System.Drawing.Point(105, 27)
        Me.Tsisa.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.Tsisa.Name = "Tsisa"
        Me.Tsisa.Size = New System.Drawing.Size(145, 23)
        Me.Tsisa.TabIndex = 31
        Me.Tsisa.ThousandsSeparator = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Tton)
        Me.GroupBox6.Controls.Add(Me.Tsak)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Location = New System.Drawing.Point(563, 70)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(303, 81)
        Me.GroupBox6.TabIndex = 47
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Data Semen"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Volume (Ton)"
        '
        'Tton
        '
        Me.Tton.Location = New System.Drawing.Point(93, 22)
        Me.Tton.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.Tton.Name = "Tton"
        Me.Tton.Size = New System.Drawing.Size(193, 23)
        Me.Tton.TabIndex = 20
        Me.Tton.ThousandsSeparator = True
        '
        'Tsak
        '
        Me.Tsak.Increment = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.Tsak.Location = New System.Drawing.Point(93, 51)
        Me.Tsak.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.Tsak.Name = "Tsak"
        Me.Tsak.Size = New System.Drawing.Size(193, 23)
        Me.Tsak.TabIndex = 21
        Me.Tsak.ThousandsSeparator = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Volume (Sak)"
        '
        'Badd
        '
        Me.Badd.BackColor = System.Drawing.Color.Tan
        Me.Badd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Badd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Badd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Badd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Badd.Location = New System.Drawing.Point(781, 240)
        Me.Badd.Name = "Badd"
        Me.Badd.Size = New System.Drawing.Size(85, 23)
        Me.Badd.TabIndex = 6
        Me.Badd.Text = "SIMPAN"
        Me.Badd.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Ttotal_tarif)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Ttotal_biaya_truk)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Ttarif)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Tbiaya_truk)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Location = New System.Drawing.Point(22, 158)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(535, 89)
        Me.GroupBox5.TabIndex = 46
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Data Tarif"
        '
        'Ttotal_tarif
        '
        Me.Ttotal_tarif.Location = New System.Drawing.Point(388, 24)
        Me.Ttotal_tarif.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.Ttotal_tarif.Name = "Ttotal_tarif"
        Me.Ttotal_tarif.Size = New System.Drawing.Size(137, 23)
        Me.Ttotal_tarif.TabIndex = 47
        Me.Ttotal_tarif.ThousandsSeparator = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(280, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 15)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "Total Tarif (PTSP)"
        '
        'Ttotal_biaya_truk
        '
        Me.Ttotal_biaya_truk.Location = New System.Drawing.Point(388, 53)
        Me.Ttotal_biaya_truk.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.Ttotal_biaya_truk.Name = "Ttotal_biaya_truk"
        Me.Ttotal_biaya_truk.Size = New System.Drawing.Size(137, 23)
        Me.Ttotal_biaya_truk.TabIndex = 45
        Me.Ttotal_biaya_truk.ThousandsSeparator = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(280, 51)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 15)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Total Tarif(Agen)"
        '
        'Ttarif
        '
        Me.Ttarif.Location = New System.Drawing.Point(109, 22)
        Me.Ttarif.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.Ttarif.Name = "Ttarif"
        Me.Ttarif.Size = New System.Drawing.Size(141, 23)
        Me.Ttarif.TabIndex = 43
        Me.Ttarif.ThousandsSeparator = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 15)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "Tarif (PTSP)/Ton"
        '
        'Tbiaya_truk
        '
        Me.Tbiaya_truk.Location = New System.Drawing.Point(109, 51)
        Me.Tbiaya_truk.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.Tbiaya_truk.Name = "Tbiaya_truk"
        Me.Tbiaya_truk.Size = New System.Drawing.Size(141, 23)
        Me.Tbiaya_truk.TabIndex = 29
        Me.Tbiaya_truk.ThousandsSeparator = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 15)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Tarif(Agen)/Ton"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Ctruk)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Cagen)
        Me.GroupBox4.Location = New System.Drawing.Point(22, 70)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(265, 79)
        Me.GroupBox4.TabIndex = 45
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Data Truk"
        '
        'Ctruk
        '
        Me.Ctruk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Ctruk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Ctruk.FormattingEnabled = True
        Me.Ctruk.Items.AddRange(New Object() {"1"})
        Me.Ctruk.Location = New System.Drawing.Point(87, 19)
        Me.Ctruk.Name = "Ctruk"
        Me.Ctruk.Size = New System.Drawing.Size(163, 23)
        Me.Ctruk.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Truk"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 15)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Agen Truk"
        '
        'Cagen
        '
        Me.Cagen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Cagen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cagen.FormattingEnabled = True
        Me.Cagen.Items.AddRange(New Object() {"1"})
        Me.Cagen.Location = New System.Drawing.Point(87, 48)
        Me.Cagen.Name = "Cagen"
        Me.Cagen.Size = New System.Drawing.Size(163, 23)
        Me.Cagen.TabIndex = 41
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Tnohp)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Csupir)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(293, 70)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(264, 79)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Supir"
        '
        'Tnohp
        '
        Me.Tnohp.Location = New System.Drawing.Point(87, 49)
        Me.Tnohp.Name = "Tnohp"
        Me.Tnohp.Size = New System.Drawing.Size(167, 23)
        Me.Tnohp.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Supir"
        '
        'Csupir
        '
        Me.Csupir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Csupir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Csupir.FormattingEnabled = True
        Me.Csupir.Items.AddRange(New Object() {"1"})
        Me.Csupir.Location = New System.Drawing.Point(87, 19)
        Me.Csupir.Name = "Csupir"
        Me.Csupir.Size = New System.Drawing.Size(167, 23)
        Me.Csupir.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 15)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "NOHP"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(389, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 15)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Tanggal Sampai"
        '
        'Ttgl_sampai
        '
        Me.Ttgl_sampai.CustomFormat = "dd MMMM yyyy"
        Me.Ttgl_sampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Ttgl_sampai.Location = New System.Drawing.Point(392, 41)
        Me.Ttgl_sampai.Name = "Ttgl_sampai"
        Me.Ttgl_sampai.Size = New System.Drawing.Size(200, 23)
        Me.Ttgl_sampai.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(192, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 15)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Tanggal Berangkat"
        '
        'Ttgl_berangkat
        '
        Me.Ttgl_berangkat.CustomFormat = "dd MMMM yyyy"
        Me.Ttgl_berangkat.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Ttgl_berangkat.Location = New System.Drawing.Point(195, 41)
        Me.Ttgl_berangkat.Name = "Ttgl_berangkat"
        Me.Ttgl_berangkat.Size = New System.Drawing.Size(176, 23)
        Me.Ttgl_berangkat.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(563, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Keterangan"
        '
        'Tketerangan
        '
        Me.Tketerangan.Location = New System.Drawing.Point(566, 185)
        Me.Tketerangan.Multiline = True
        Me.Tketerangan.Name = "Tketerangan"
        Me.Tketerangan.Size = New System.Drawing.Size(300, 49)
        Me.Tketerangan.TabIndex = 32
        '
        'MenuAksi
        '
        Me.MenuAksi.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mhapus})
        Me.MenuAksi.Name = "MenuAksi"
        Me.MenuAksi.Size = New System.Drawing.Size(109, 26)
        '
        'Mhapus
        '
        Me.Mhapus.Image = CType(resources.GetObject("Mhapus.Image"), System.Drawing.Image)
        Me.Mhapus.Name = "Mhapus"
        Me.Mhapus.Size = New System.Drawing.Size(108, 22)
        Me.Mhapus.Text = "Hapus"
        '
        'Fpengiriman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(901, 384)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fpengiriman"
        Me.Text = "Daftar Pengiriman Semen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.Tuang_jalan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ttotal_ongkos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tsisa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.Tton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tsak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.Ttotal_tarif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ttotal_biaya_truk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ttarif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbiaya_truk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuAksi.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bcancel As Button
    Friend WithEvents Bexit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Badd As Button
    Friend WithEvents Tsak As NumericUpDown
    Friend WithEvents Tton As NumericUpDown
    Friend WithEvents Ctruk As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Csupir As ComboBox
    Friend WithEvents MenuAksi As ContextMenuStrip
    Friend WithEvents Mhapus As ToolStripMenuItem
    Friend WithEvents Label7 As Label
    Friend WithEvents Ckota As ComboBox
    Friend WithEvents Tbiaya_truk As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Tketerangan As TextBox
    Friend WithEvents Tsisa As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Tuang_jalan As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Ttotal_ongkos As NumericUpDown
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Cagen As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Tnohp As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Ttgl_sampai As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Ttgl_berangkat As DateTimePicker
    Friend WithEvents Ttarif As NumericUpDown
    Friend WithEvents Tno_do As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Ttotal_tarif As NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents Ttotal_biaya_truk As NumericUpDown
    Friend WithEvents Label18 As Label
    Friend WithEvents BWsimpan As System.ComponentModel.BackgroundWorker
End Class
