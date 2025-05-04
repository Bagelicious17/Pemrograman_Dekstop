<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUtama
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
        Me.lblInfoUser = New System.Windows.Forms.Label()
        Me.lblTgl = New System.Windows.Forms.Label()
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
        Me.pnlPlat = New System.Windows.Forms.Panel()
        Me.lblPlat = New System.Windows.Forms.Label()
        Me.pnlHarga = New System.Windows.Forms.Panel()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.pnlInput = New System.Windows.Forms.Panel()
        Me.lblInfoJenis = New System.Windows.Forms.Label()
        Me.lblInfo2 = New System.Windows.Forms.Label()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.lblInputPlat = New System.Windows.Forms.Label()
        Me.txtNoPlat = New System.Windows.Forms.TextBox()
        Me.pnlGrid = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColNoPlat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMasuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColKeluar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColJenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlPlat.SuspendLayout()
        Me.pnlHarga.SuspendLayout()
        Me.pnlInput.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInfoUser
        '
        Me.lblInfoUser.AutoSize = True
        Me.lblInfoUser.Location = New System.Drawing.Point(12, 440)
        Me.lblInfoUser.Name = "lblInfoUser"
        Me.lblInfoUser.Size = New System.Drawing.Size(79, 20)
        Me.lblInfoUser.TabIndex = 14
        Me.lblInfoUser.Text = "Informasi:"
        '
        'lblTgl
        '
        Me.lblTgl.AutoSize = True
        Me.lblTgl.Location = New System.Drawing.Point(12, 479)
        Me.lblTgl.Name = "lblTgl"
        Me.lblTgl.Size = New System.Drawing.Size(70, 20)
        Me.lblTgl.TabIndex = 15
        Me.lblTgl.Text = "Tanggal:"
        '
        'lblJmlKendaraan
        '
        Me.lblJmlKendaraan.AutoSize = True
        Me.lblJmlKendaraan.Location = New System.Drawing.Point(12, 513)
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1114, 33)
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
        Me.AturProfilToolStripMenuItem.Size = New System.Drawing.Size(194, 34)
        Me.AturProfilToolStripMenuItem.Text = "Atur Profil"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(194, 34)
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
        Me.LanggananToolStripMenuItem.Size = New System.Drawing.Size(201, 34)
        Me.LanggananToolStripMenuItem.Text = "Langganan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(201, 34)
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
        Me.BantuanToolStripMenuItem1.Size = New System.Drawing.Size(178, 34)
        Me.BantuanToolStripMenuItem1.Text = "Bantuan"
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(178, 34)
        Me.TentangToolStripMenuItem.Text = "Tentang"
        '
        'pnlPlat
        '
        Me.pnlPlat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPlat.Controls.Add(Me.lblPlat)
        Me.pnlPlat.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPlat.Location = New System.Drawing.Point(0, 33)
        Me.pnlPlat.Name = "pnlPlat"
        Me.pnlPlat.Size = New System.Drawing.Size(1114, 182)
        Me.pnlPlat.TabIndex = 19
        '
        'lblPlat
        '
        Me.lblPlat.AutoSize = True
        Me.lblPlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlat.Location = New System.Drawing.Point(4, 13)
        Me.lblPlat.Name = "lblPlat"
        Me.lblPlat.Size = New System.Drawing.Size(859, 163)
        Me.lblPlat.TabIndex = 22
        Me.lblPlat.Text = "AB 1234 XY"
        '
        'pnlHarga
        '
        Me.pnlHarga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlHarga.Controls.Add(Me.lblHarga)
        Me.pnlHarga.Location = New System.Drawing.Point(0, 221)
        Me.pnlHarga.Name = "pnlHarga"
        Me.pnlHarga.Size = New System.Drawing.Size(317, 97)
        Me.pnlHarga.TabIndex = 20
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHarga.Location = New System.Drawing.Point(10, 22)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(93, 52)
        Me.lblHarga.TabIndex = 23
        Me.lblHarga.Text = "Rp."
        '
        'pnlInput
        '
        Me.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlInput.Controls.Add(Me.lblInfoJenis)
        Me.pnlInput.Controls.Add(Me.lblInfo2)
        Me.pnlInput.Controls.Add(Me.lblJenis)
        Me.pnlInput.Controls.Add(Me.lblInputPlat)
        Me.pnlInput.Controls.Add(Me.txtNoPlat)
        Me.pnlInput.Location = New System.Drawing.Point(0, 324)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Size = New System.Drawing.Size(317, 113)
        Me.pnlInput.TabIndex = 21
        '
        'lblInfoJenis
        '
        Me.lblInfoJenis.AutoSize = True
        Me.lblInfoJenis.Location = New System.Drawing.Point(258, 11)
        Me.lblInfoJenis.Name = "lblInfoJenis"
        Me.lblInfoJenis.Size = New System.Drawing.Size(0, 20)
        Me.lblInfoJenis.TabIndex = 3
        '
        'lblInfo2
        '
        Me.lblInfo2.AutoSize = True
        Me.lblInfo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo2.Location = New System.Drawing.Point(3, 86)
        Me.lblInfo2.Name = "lblInfo2"
        Me.lblInfo2.Size = New System.Drawing.Size(223, 17)
        Me.lblInfo2.TabIndex = 0
        Me.lblInfo2.Text = "Tekan Enter untuk Masuk / Keluar"
        '
        'lblJenis
        '
        Me.lblJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJenis.Location = New System.Drawing.Point(3, 49)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(307, 46)
        Me.lblJenis.TabIndex = 2
        Me.lblJenis.Text = "F1 - Motor, F2 - Mobil, F3 - Taksi, F4 - Sepeda, F5 - Bis/Truk"
        '
        'lblInputPlat
        '
        Me.lblInputPlat.AutoSize = True
        Me.lblInputPlat.Location = New System.Drawing.Point(3, 11)
        Me.lblInputPlat.Name = "lblInputPlat"
        Me.lblInputPlat.Size = New System.Drawing.Size(81, 20)
        Me.lblInputPlat.TabIndex = 1
        Me.lblInputPlat.Text = "Input Plat:"
        '
        'txtNoPlat
        '
        Me.txtNoPlat.Location = New System.Drawing.Point(90, 11)
        Me.txtNoPlat.Name = "txtNoPlat"
        Me.txtNoPlat.Size = New System.Drawing.Size(190, 26)
        Me.txtNoPlat.TabIndex = 0
        '
        'pnlGrid
        '
        Me.pnlGrid.AutoScroll = True
        Me.pnlGrid.Controls.Add(Me.DataGridView1)
        Me.pnlGrid.Location = New System.Drawing.Point(323, 221)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(791, 278)
        Me.pnlGrid.TabIndex = 22
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColNoPlat, Me.ColMasuk, Me.ColKeluar, Me.ColHarga, Me.ColJenis, Me.Column1})
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Location = New System.Drawing.Point(1, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(787, 271)
        Me.DataGridView1.TabIndex = 0
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
        'Column1
        '
        Me.Column1.HeaderText = "id"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 150
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(135, 36)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(134, 32)
        Me.ToolStripMenuItem1.Text = "Delete"
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 564)
        Me.Controls.Add(Me.pnlGrid)
        Me.Controls.Add(Me.pnlInput)
        Me.Controls.Add(Me.pnlHarga)
        Me.Controls.Add(Me.pnlPlat)
        Me.Controls.Add(Me.lblJmlKendaraan)
        Me.Controls.Add(Me.lblTgl)
        Me.Controls.Add(Me.lblInfoUser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmUtama"
        Me.Text = "Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlPlat.ResumeLayout(False)
        Me.pnlPlat.PerformLayout()
        Me.pnlHarga.ResumeLayout(False)
        Me.pnlHarga.PerformLayout()
        Me.pnlInput.ResumeLayout(False)
        Me.pnlInput.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInfoUser As Label
    Friend WithEvents lblTgl As Label
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
    Friend WithEvents pnlPlat As Panel
    Friend WithEvents pnlHarga As Panel
    Friend WithEvents pnlInput As Panel
    Friend WithEvents lblPlat As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents lblJenis As Label
    Friend WithEvents lblInputPlat As Label
    Friend WithEvents txtNoPlat As TextBox
    Friend WithEvents lblInfo2 As Label
    Friend WithEvents lblInfoJenis As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ColNoPlat As DataGridViewTextBoxColumn
    Friend WithEvents ColMasuk As DataGridViewTextBoxColumn
    Friend WithEvents ColKeluar As DataGridViewTextBoxColumn
    Friend WithEvents ColHarga As DataGridViewTextBoxColumn
    Friend WithEvents ColJenis As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
