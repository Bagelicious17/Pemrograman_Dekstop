<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtama
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
        Me.pnlPlat = New System.Windows.Forms.Label()
        Me.lblBiayaParkir = New System.Windows.Forms.Label()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColNoPlat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMasuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColKeluar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColJenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblInformasi = New System.Windows.Forms.Label()
        Me.lblTgl = New System.Windows.Forms.Label()
        Me.lblJam = New System.Windows.Forms.Label()
        Me.lblJmlKendaraan = New System.Windows.Forms.Label()
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
        Me.pnlInput = New System.Windows.Forms.Panel()
        Me.lblInfoJenis = New System.Windows.Forms.Label()
        Me.lblTekan = New System.Windows.Forms.Label()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.txtNoPlat = New System.Windows.Forms.TextBox()
        Me.lblInputPlat = New System.Windows.Forms.Label()
        Me.pnlGrid = New System.Windows.Forms.Panel()
        Me.lblPlat = New System.Windows.Forms.Label()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.pnlHarga = New System.Windows.Forms.Panel()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlInput.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlHarga.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPlat
        '
        Me.pnlPlat.BackColor = System.Drawing.SystemColors.Control
        Me.pnlPlat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPlat.Location = New System.Drawing.Point(13, 39)
        Me.pnlPlat.Name = "pnlPlat"
        Me.pnlPlat.Size = New System.Drawing.Size(844, 202)
        Me.pnlPlat.TabIndex = 3
        '
        'lblBiayaParkir
        '
        Me.lblBiayaParkir.AutoSize = True
        Me.lblBiayaParkir.Location = New System.Drawing.Point(12, 252)
        Me.lblBiayaParkir.Name = "lblBiayaParkir"
        Me.lblBiayaParkir.Size = New System.Drawing.Size(92, 20)
        Me.lblBiayaParkir.TabIndex = 10
        Me.lblBiayaParkir.Text = "Biaya Parkir"
        '
        'dataGridView1
        '
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColNoPlat, Me.ColMasuk, Me.ColKeluar, Me.ColHarga, Me.ColJenis, Me.Id})
        Me.dataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.RowHeadersWidth = 62
        Me.dataGridView1.RowTemplate.Height = 28
        Me.dataGridView1.Size = New System.Drawing.Size(459, 285)
        Me.dataGridView1.TabIndex = 13
        '
        'ColNoPlat
        '
        Me.ColNoPlat.HeaderText = "No Plat"
        Me.ColNoPlat.MinimumWidth = 8
        Me.ColNoPlat.Name = "ColNoPlat"
        Me.ColNoPlat.Width = 150
        '
        'ColMasuk
        '
        Me.ColMasuk.HeaderText = "Masuk"
        Me.ColMasuk.MinimumWidth = 8
        Me.ColMasuk.Name = "ColMasuk"
        Me.ColMasuk.Width = 150
        '
        'ColKeluar
        '
        Me.ColKeluar.HeaderText = "Keluar"
        Me.ColKeluar.MinimumWidth = 8
        Me.ColKeluar.Name = "ColKeluar"
        Me.ColKeluar.Width = 150
        '
        'ColHarga
        '
        Me.ColHarga.HeaderText = "Harga"
        Me.ColHarga.MinimumWidth = 8
        Me.ColHarga.Name = "ColHarga"
        Me.ColHarga.Width = 150
        '
        'ColJenis
        '
        Me.ColJenis.HeaderText = "Jenis"
        Me.ColJenis.MinimumWidth = 8
        Me.ColJenis.Name = "ColJenis"
        Me.ColJenis.Width = 150
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.MinimumWidth = 8
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        Me.Id.Width = 150
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Delete})
        Me.ContextMenuStrip1.Name = "Delete"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(245, 36)
        Me.ContextMenuStrip1.Text = "Delete"
        '
        'Delete
        '
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(244, 32)
        Me.Delete.Text = "ToolStripMenuItem1"
        '
        'lblInformasi
        '
        Me.lblInformasi.AutoSize = True
        Me.lblInformasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformasi.Location = New System.Drawing.Point(12, 509)
        Me.lblInformasi.Name = "lblInformasi"
        Me.lblInformasi.Size = New System.Drawing.Size(89, 20)
        Me.lblInformasi.TabIndex = 14
        Me.lblInformasi.Text = "Informasi:"
        '
        'lblTgl
        '
        Me.lblTgl.AutoSize = True
        Me.lblTgl.Location = New System.Drawing.Point(12, 548)
        Me.lblTgl.Name = "lblTgl"
        Me.lblTgl.Size = New System.Drawing.Size(70, 20)
        Me.lblTgl.TabIndex = 15
        Me.lblTgl.Text = "Tanggal:"
        '
        'lblJam
        '
        Me.lblJam.AutoSize = True
        Me.lblJam.Location = New System.Drawing.Point(199, 548)
        Me.lblJam.Name = "lblJam"
        Me.lblJam.Size = New System.Drawing.Size(109, 20)
        Me.lblJam.TabIndex = 16
        Me.lblJam.Text = "Jam: 00:00:00"
        '
        'lblJmlKendaraan
        '
        Me.lblJmlKendaraan.AutoSize = True
        Me.lblJmlKendaraan.Location = New System.Drawing.Point(13, 604)
        Me.lblJmlKendaraan.Name = "lblJmlKendaraan"
        Me.lblJmlKendaraan.Size = New System.Drawing.Size(316, 20)
        Me.lblJmlKendaraan.TabIndex = 17
        Me.lblJmlKendaraan.Text = "O Motor, O Mobil, O Taksi, O Spd, O bis/truk"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemToolStripMenuItem, Me.AdminToolStripMenuItem, Me.BantuanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(857, 33)
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
        Me.AturProfilToolStripMenuItem.Size = New System.Drawing.Size(171, 34)
        Me.AturProfilToolStripMenuItem.Text = "Profil"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(171, 34)
        Me.LogOutToolStripMenuItem.Text = "Logout"
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
        Me.LanggananToolStripMenuItem.Size = New System.Drawing.Size(289, 34)
        Me.LanggananToolStripMenuItem.Text = "Kendaraan Langganan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(289, 34)
        Me.LaporanToolStripMenuItem.Text = "Laporan Pendapatan "
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
        Me.BantuanToolStripMenuItem1.Size = New System.Drawing.Size(178, 34)
        Me.BantuanToolStripMenuItem1.Text = "Bantuan"
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(178, 34)
        Me.TentangToolStripMenuItem.Text = "Tentang"
        '
        'pnlInput
        '
        Me.pnlInput.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlInput.Controls.Add(Me.lblInfoJenis)
        Me.pnlInput.Controls.Add(Me.lblTekan)
        Me.pnlInput.Controls.Add(Me.lblJenis)
        Me.pnlInput.Controls.Add(Me.txtNoPlat)
        Me.pnlInput.Controls.Add(Me.lblInputPlat)
        Me.pnlInput.Location = New System.Drawing.Point(13, 351)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Size = New System.Drawing.Size(373, 103)
        Me.pnlInput.TabIndex = 19
        '
        'lblInfoJenis
        '
        Me.lblInfoJenis.AutoSize = True
        Me.lblInfoJenis.Location = New System.Drawing.Point(332, 9)
        Me.lblInfoJenis.Name = "lblInfoJenis"
        Me.lblInfoJenis.Size = New System.Drawing.Size(0, 20)
        Me.lblInfoJenis.TabIndex = 4
        '
        'lblTekan
        '
        Me.lblTekan.AutoSize = True
        Me.lblTekan.Location = New System.Drawing.Point(41, 68)
        Me.lblTekan.Name = "lblTekan"
        Me.lblTekan.Size = New System.Drawing.Size(236, 20)
        Me.lblTekan.TabIndex = 3
        Me.lblTekan.Text = "tekan enter untuk masuk/ keluar"
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJenis.Location = New System.Drawing.Point(12, 45)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(323, 15)
        Me.lblJenis.TabIndex = 2
        Me.lblJenis.Text = "F1 - Motor, F2 - Mobil, F3 - Taksi, F4 - Sepeda, F5 Bis/Truk"
        '
        'txtNoPlat
        '
        Me.txtNoPlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoPlat.Location = New System.Drawing.Point(138, 6)
        Me.txtNoPlat.Name = "txtNoPlat"
        Me.txtNoPlat.Size = New System.Drawing.Size(187, 35)
        Me.txtNoPlat.TabIndex = 1
        '
        'lblInputPlat
        '
        Me.lblInputPlat.AutoSize = True
        Me.lblInputPlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputPlat.Location = New System.Drawing.Point(3, 9)
        Me.lblInputPlat.Name = "lblInputPlat"
        Me.lblInputPlat.Size = New System.Drawing.Size(129, 29)
        Me.lblInputPlat.TabIndex = 0
        Me.lblInputPlat.Text = "Input Plat:"
        '
        'pnlGrid
        '
        Me.pnlGrid.AutoScroll = True
        Me.pnlGrid.Controls.Add(Me.dataGridView1)
        Me.pnlGrid.Location = New System.Drawing.Point(392, 244)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(459, 285)
        Me.pnlGrid.TabIndex = 20
        '
        'lblPlat
        '
        Me.lblPlat.AutoSize = True
        Me.lblPlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlat.Location = New System.Drawing.Point(48, 54)
        Me.lblPlat.Name = "lblPlat"
        Me.lblPlat.Size = New System.Drawing.Size(770, 163)
        Me.lblPlat.TabIndex = 21
        Me.lblPlat.Text = "R 6872 ZH"
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHarga.Location = New System.Drawing.Point(18, 20)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(93, 52)
        Me.lblHarga.TabIndex = 22
        Me.lblHarga.Text = "Rp."
        '
        'pnlHarga
        '
        Me.pnlHarga.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlHarga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlHarga.Controls.Add(Me.lblHarga)
        Me.pnlHarga.Location = New System.Drawing.Point(110, 252)
        Me.pnlHarga.Name = "pnlHarga"
        Me.pnlHarga.Size = New System.Drawing.Size(276, 93)
        Me.pnlHarga.TabIndex = 23
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 668)
        Me.Controls.Add(Me.pnlHarga)
        Me.Controls.Add(Me.lblPlat)
        Me.Controls.Add(Me.pnlGrid)
        Me.Controls.Add(Me.pnlInput)
        Me.Controls.Add(Me.lblJmlKendaraan)
        Me.Controls.Add(Me.lblJam)
        Me.Controls.Add(Me.lblTgl)
        Me.Controls.Add(Me.lblInformasi)
        Me.Controls.Add(Me.lblBiayaParkir)
        Me.Controls.Add(Me.pnlPlat)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parkir System v.1.0"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlInput.ResumeLayout(False)
        Me.pnlInput.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlHarga.ResumeLayout(False)
        Me.pnlHarga.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlPlat As Label
    Friend WithEvents lblBiayaParkir As Label
    Friend WithEvents dataGridView1 As DataGridView
    Friend WithEvents lblInformasi As Label
    Friend WithEvents lblTgl As Label
    Friend WithEvents lblJam As Label
    Friend WithEvents lblJmlKendaraan As Label
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
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents pnlInput As Panel
    Friend WithEvents txtNoPlat As TextBox
    Friend WithEvents lblInputPlat As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents lblTekan As Label
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents lblPlat As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents pnlHarga As Panel
    Friend WithEvents lblInfoJenis As Label
    Friend WithEvents ColNoPlat As DataGridViewTextBoxColumn
    Friend WithEvents ColMasuk As DataGridViewTextBoxColumn
    Friend WithEvents ColKeluar As DataGridViewTextBoxColumn
    Friend WithEvents ColHarga As DataGridViewTextBoxColumn
    Friend WithEvents ColJenis As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Delete As ToolStripMenuItem
End Class
