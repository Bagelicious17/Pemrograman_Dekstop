<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Utama
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
        Me.lblTamplianPlat = New System.Windows.Forms.Label()
        Me.lblNomorPlat = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.cbJenis = New System.Windows.Forms.ComboBox()
        Me.btnMasuk = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.lblBiayaParkir = New System.Windows.Forms.Label()
        Me.lblShowBiaya = New System.Windows.Forms.Label()
        Me.lblKendaraanParkir = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblInformasi = New System.Windows.Forms.Label()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.lblJam = New System.Windows.Forms.Label()
        Me.lblJenisKendaraan = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AturProfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LanggananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BantuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BantuanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTamplianPlat
        '
        Me.lblTamplianPlat.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblTamplianPlat.Location = New System.Drawing.Point(13, 39)
        Me.lblTamplianPlat.Name = "lblTamplianPlat"
        Me.lblTamplianPlat.Size = New System.Drawing.Size(557, 117)
        Me.lblTamplianPlat.TabIndex = 3
        '
        'lblNomorPlat
        '
        Me.lblNomorPlat.AutoSize = True
        Me.lblNomorPlat.Location = New System.Drawing.Point(13, 167)
        Me.lblNomorPlat.Name = "lblNomorPlat"
        Me.lblNomorPlat.Size = New System.Drawing.Size(91, 20)
        Me.lblNomorPlat.TabIndex = 4
        Me.lblNomorPlat.Text = "Nomor Plat:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(110, 167)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(170, 26)
        Me.TextBox1.TabIndex = 5
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Location = New System.Drawing.Point(12, 207)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(50, 20)
        Me.lblJenis.TabIndex = 6
        Me.lblJenis.Text = "Jenis:"
        '
        'cbJenis
        '
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Location = New System.Drawing.Point(110, 207)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(121, 28)
        Me.cbJenis.TabIndex = 7
        '
        'btnMasuk
        '
        Me.btnMasuk.Location = New System.Drawing.Point(124, 241)
        Me.btnMasuk.Name = "btnMasuk"
        Me.btnMasuk.Size = New System.Drawing.Size(74, 54)
        Me.btnMasuk.TabIndex = 8
        Me.btnMasuk.Text = "Masuk"
        Me.btnMasuk.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(204, 241)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(74, 54)
        Me.btnKeluar.TabIndex = 9
        Me.btnKeluar.Text = "keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'lblBiayaParkir
        '
        Me.lblBiayaParkir.AutoSize = True
        Me.lblBiayaParkir.Location = New System.Drawing.Point(12, 308)
        Me.lblBiayaParkir.Name = "lblBiayaParkir"
        Me.lblBiayaParkir.Size = New System.Drawing.Size(92, 20)
        Me.lblBiayaParkir.TabIndex = 10
        Me.lblBiayaParkir.Text = "Biaya Parkir"
        '
        'lblShowBiaya
        '
        Me.lblShowBiaya.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblShowBiaya.Location = New System.Drawing.Point(106, 308)
        Me.lblShowBiaya.Name = "lblShowBiaya"
        Me.lblShowBiaya.Size = New System.Drawing.Size(174, 80)
        Me.lblShowBiaya.TabIndex = 11
        '
        'lblKendaraanParkir
        '
        Me.lblKendaraanParkir.AutoSize = True
        Me.lblKendaraanParkir.Location = New System.Drawing.Point(319, 167)
        Me.lblKendaraanParkir.Name = "lblKendaraanParkir"
        Me.lblKendaraanParkir.Size = New System.Drawing.Size(229, 20)
        Me.lblKendaraanParkir.TabIndex = 12
        Me.lblKendaraanParkir.Text = "Kendaraan yang sedang parkir:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(323, 199)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(247, 245)
        Me.DataGridView1.TabIndex = 13
        '
        'lblInformasi
        '
        Me.lblInformasi.AutoSize = True
        Me.lblInformasi.Location = New System.Drawing.Point(12, 440)
        Me.lblInformasi.Name = "lblInformasi"
        Me.lblInformasi.Size = New System.Drawing.Size(79, 20)
        Me.lblInformasi.TabIndex = 14
        Me.lblInformasi.Text = "Informasi:"
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Location = New System.Drawing.Point(12, 479)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(156, 20)
        Me.lblTanggal.TabIndex = 15
        Me.lblTanggal.Text = "Tanggal: 12-34-5678"
        '
        'lblJam
        '
        Me.lblJam.AutoSize = True
        Me.lblJam.Location = New System.Drawing.Point(199, 479)
        Me.lblJam.Name = "lblJam"
        Me.lblJam.Size = New System.Drawing.Size(109, 20)
        Me.lblJam.TabIndex = 16
        Me.lblJam.Text = "Jam: 00:00:00"
        '
        'lblJenisKendaraan
        '
        Me.lblJenisKendaraan.AutoSize = True
        Me.lblJenisKendaraan.Location = New System.Drawing.Point(13, 535)
        Me.lblJenisKendaraan.Name = "lblJenisKendaraan"
        Me.lblJenisKendaraan.Size = New System.Drawing.Size(316, 20)
        Me.lblJenisKendaraan.TabIndex = 17
        Me.lblJenisKendaraan.Text = "O Motor, O Mobil, O Taksi, O Spd, O bis/truk"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemToolStripMenuItem, Me.AdminToolStripMenuItem, Me.BantuanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(639, 33)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemToolStripMenuItem
        '
        Me.SistemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AturProfilToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.SistemToolStripMenuItem.Name = "SistemToolStripMenuItem"
        Me.SistemToolStripMenuItem.Size = New System.Drawing.Size(81, 29)
        Me.SistemToolStripMenuItem.Text = "Sistem"
        '
        'AturProfilToolStripMenuItem
        '
        Me.AturProfilToolStripMenuItem.Name = "AturProfilToolStripMenuItem"
        Me.AturProfilToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.AturProfilToolStripMenuItem.Text = "Atur Profil"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LanggananToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(81, 29)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'LanggananToolStripMenuItem
        '
        Me.LanggananToolStripMenuItem.Name = "LanggananToolStripMenuItem"
        Me.LanggananToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.LanggananToolStripMenuItem.Text = "Langganan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'BantuanToolStripMenuItem
        '
        Me.BantuanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BantuanToolStripMenuItem1, Me.TentangToolStripMenuItem})
        Me.BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        Me.BantuanToolStripMenuItem.Size = New System.Drawing.Size(92, 29)
        Me.BantuanToolStripMenuItem.Text = "Bantuan"
        '
        'BantuanToolStripMenuItem1
        '
        Me.BantuanToolStripMenuItem1.Name = "BantuanToolStripMenuItem1"
        Me.BantuanToolStripMenuItem1.Size = New System.Drawing.Size(270, 34)
        Me.BantuanToolStripMenuItem1.Text = "Bantuan"
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.TentangToolStripMenuItem.Text = "Tentang"
        '
        'Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 564)
        Me.Controls.Add(Me.lblJenisKendaraan)
        Me.Controls.Add(Me.lblJam)
        Me.Controls.Add(Me.lblTanggal)
        Me.Controls.Add(Me.lblInformasi)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblKendaraanParkir)
        Me.Controls.Add(Me.lblShowBiaya)
        Me.Controls.Add(Me.lblBiayaParkir)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnMasuk)
        Me.Controls.Add(Me.cbJenis)
        Me.Controls.Add(Me.lblJenis)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblNomorPlat)
        Me.Controls.Add(Me.lblTamplianPlat)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Utama"
        Me.Text = "Utama"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTamplianPlat As Label
    Friend WithEvents lblNomorPlat As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblJenis As Label
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents btnMasuk As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents lblBiayaParkir As Label
    Friend WithEvents lblShowBiaya As Label
    Friend WithEvents lblKendaraanParkir As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblInformasi As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblJam As Label
    Friend WithEvents lblJenisKendaraan As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AturProfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LanggananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
End Class
