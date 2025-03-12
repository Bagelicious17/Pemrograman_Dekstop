<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Langganan
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblIdPelanggan = New System.Windows.Forms.Label()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.cbJenis = New System.Windows.Forms.ComboBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblKendaraanPelanggan = New System.Windows.Forms.Label()
        Me.btnTutup = New System.Windows.Forms.Button()
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
        Me.lblTariflangganan.Text = "Tariflangganan"
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(237, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(332, 26)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(237, 70)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(269, 26)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(237, 114)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(269, 26)
        Me.TextBox3.TabIndex = 7
        '
        'lblIdPelanggan
        '
        Me.lblIdPelanggan.AutoSize = True
        Me.lblIdPelanggan.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblIdPelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdPelanggan.Location = New System.Drawing.Point(575, 28)
        Me.lblIdPelanggan.Name = "lblIdPelanggan"
        Me.lblIdPelanggan.Size = New System.Drawing.Size(152, 26)
        Me.lblIdPelanggan.TabIndex = 8
        Me.lblIdPelanggan.Text = "Id Pelanggan :"
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
        'cbJenis
        '
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Location = New System.Drawing.Point(580, 71)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(121, 28)
        Me.cbJenis.TabIndex = 10
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
        Me.DataGridView1.Location = New System.Drawing.Point(27, 235)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(736, 161)
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
        Me.btnTutup.Location = New System.Drawing.Point(685, 402)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(78, 50)
        Me.btnTutup.TabIndex = 16
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'Langganan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 475)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.lblKendaraanPelanggan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.cbJenis)
        Me.Controls.Add(Me.lblJenis)
        Me.Controls.Add(Me.lblIdPelanggan)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblBerlaku)
        Me.Controls.Add(Me.lblTariflangganan)
        Me.Controls.Add(Me.lblNomorPlat)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblNamaPelanggan)
        Me.Name = "Langganan"
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblIdPelanggan As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblKendaraanPelanggan As Label
    Friend WithEvents btnTutup As Button
End Class
