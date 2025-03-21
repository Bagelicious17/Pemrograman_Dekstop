<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLangganan
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
        Me.lblNamaPelanggan = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblNomorPlat = New System.Windows.Forms.Label()
        Me.lblTariflangganan = New System.Windows.Forms.Label()
        Me.lblBerlaku = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNoPlat = New System.Windows.Forms.TextBox()
        Me.txtBiaya = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblKendaraanPelanggan = New System.Windows.Forms.Label()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNamaPelanggan
        '
        Me.lblNamaPelanggan.AutoSize = True
        Me.lblNamaPelanggan.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblNamaPelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaPelanggan.Location = New System.Drawing.Point(25, 28)
        Me.lblNamaPelanggan.Name = "lblNamaPelanggan"
        Me.lblNamaPelanggan.Size = New System.Drawing.Size(181, 26)
        Me.lblNamaPelanggan.TabIndex = 0
        Me.lblNamaPelanggan.Text = "Nama Pelanggan"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(237, 158)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(269, 26)
        Me.DateTimePicker1.TabIndex = 1
        '
        'lblNomorPlat
        '
        Me.lblNomorPlat.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblNomorPlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomorPlat.Location = New System.Drawing.Point(25, 67)
        Me.lblNomorPlat.Name = "lblNomorPlat"
        Me.lblNomorPlat.Size = New System.Drawing.Size(181, 29)
        Me.lblNomorPlat.TabIndex = 2
        Me.lblNomorPlat.Text = "Nomor Plat"
        '
        'lblTariflangganan
        '
        Me.lblTariflangganan.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblTariflangganan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTariflangganan.Location = New System.Drawing.Point(25, 110)
        Me.lblTariflangganan.Name = "lblTariflangganan"
        Me.lblTariflangganan.Size = New System.Drawing.Size(181, 30)
        Me.lblTariflangganan.TabIndex = 3
        Me.lblTariflangganan.Text = "Tarif langganan"
        '
        'lblBerlaku
        '
        Me.lblBerlaku.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblBerlaku.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBerlaku.Location = New System.Drawing.Point(25, 152)
        Me.lblBerlaku.Name = "lblBerlaku"
        Me.lblBerlaku.Size = New System.Drawing.Size(181, 32)
        Me.lblBerlaku.TabIndex = 4
        Me.lblBerlaku.Text = "Berlaku Hingga"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(237, 28)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(332, 26)
        Me.txtNama.TabIndex = 5
        '
        'txtNoPlat
        '
        Me.txtNoPlat.Location = New System.Drawing.Point(237, 70)
        Me.txtNoPlat.Name = "txtNoPlat"
        Me.txtNoPlat.Size = New System.Drawing.Size(269, 26)
        Me.txtNoPlat.TabIndex = 6
        '
        'txtBiaya
        '
        Me.txtBiaya.Location = New System.Drawing.Point(237, 114)
        Me.txtBiaya.Name = "txtBiaya"
        Me.txtBiaya.Size = New System.Drawing.Size(269, 26)
        Me.txtBiaya.TabIndex = 7
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(575, 28)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(152, 26)
        Me.lblId.TabIndex = 8
        Me.lblId.Text = "Id Pelanggan :"
        '
        'lblJenis
        '
        Me.lblJenis.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJenis.Location = New System.Drawing.Point(512, 70)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(181, 29)
        Me.lblJenis.TabIndex = 9
        Me.lblJenis.Text = "Jenis:"
        '
        'cmbJenis
        '
        Me.cmbJenis.FormattingEnabled = True
        Me.cmbJenis.Location = New System.Drawing.Point(580, 71)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(121, 28)
        Me.cmbJenis.TabIndex = 10
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(517, 148)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(78, 50)
        Me.btnTambah.TabIndex = 11
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(601, 148)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(78, 50)
        Me.btnEdit.TabIndex = 12
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(685, 148)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(78, 50)
        Me.btnHapus.TabIndex = 13
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(27, 235)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(903, 161)
        Me.DataGridView1.TabIndex = 14
        '
        'lblKendaraanPelanggan
        '
        Me.lblKendaraanPelanggan.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblKendaraanPelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKendaraanPelanggan.Location = New System.Drawing.Point(25, 203)
        Me.lblKendaraanPelanggan.Name = "lblKendaraanPelanggan"
        Me.lblKendaraanPelanggan.Size = New System.Drawing.Size(298, 29)
        Me.lblKendaraanPelanggan.TabIndex = 15
        Me.lblKendaraanPelanggan.Text = "Kendaraan Terdaftar Pelanggan"
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(852, 402)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(78, 50)
        Me.btnTutup.TabIndex = 16
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(769, 158)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 37)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "No Plat"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nama Pemilik"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Biaya"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "Jenis"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "Expired"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'frmLangganan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 475)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.lblKendaraanPelanggan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.cmbJenis)
        Me.Controls.Add(Me.lblJenis)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.txtBiaya)
        Me.Controls.Add(Me.txtNoPlat)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.lblBerlaku)
        Me.Controls.Add(Me.lblTariflangganan)
        Me.Controls.Add(Me.lblNomorPlat)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblNamaPelanggan)
        Me.KeyPreview = True
        Me.Name = "frmLangganan"
        Me.Text = "Langganan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNamaPelanggan As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblNomorPlat As Label
    Friend WithEvents lblTariflangganan As Label
    Friend WithEvents lblBerlaku As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNoPlat As TextBox
    Friend WithEvents txtBiaya As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblKendaraanPelanggan As Label
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
