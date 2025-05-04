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
        Me.lblNoPlat = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblBiaya = New System.Windows.Forms.Label()
        Me.lblExpired = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.txtNoPlat = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtBiaya = New System.Windows.Forms.TextBox()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblId = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNoPlat
        '
        Me.lblNoPlat.AutoSize = True
        Me.lblNoPlat.Location = New System.Drawing.Point(32, 37)
        Me.lblNoPlat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNoPlat.Name = "lblNoPlat"
        Me.lblNoPlat.Size = New System.Drawing.Size(72, 20)
        Me.lblNoPlat.TabIndex = 0
        Me.lblNoPlat.Text = "No Plat : "
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(32, 89)
        Me.lblNama.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(63, 20)
        Me.lblNama.TabIndex = 1
        Me.lblNama.Text = "Nama : "
        '
        'lblBiaya
        '
        Me.lblBiaya.AutoSize = True
        Me.lblBiaya.Location = New System.Drawing.Point(32, 142)
        Me.lblBiaya.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBiaya.Name = "lblBiaya"
        Me.lblBiaya.Size = New System.Drawing.Size(60, 20)
        Me.lblBiaya.TabIndex = 2
        Me.lblBiaya.Text = "Biaya : "
        '
        'lblExpired
        '
        Me.lblExpired.AutoSize = True
        Me.lblExpired.Location = New System.Drawing.Point(32, 194)
        Me.lblExpired.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExpired.Name = "lblExpired"
        Me.lblExpired.Size = New System.Drawing.Size(70, 20)
        Me.lblExpired.TabIndex = 3
        Me.lblExpired.Text = "Expired :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(36, 245)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(978, 269)
        Me.DataGridView1.TabIndex = 4
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
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Location = New System.Drawing.Point(460, 142)
        Me.lblJenis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(58, 20)
        Me.lblJenis.TabIndex = 5
        Me.lblJenis.Text = "Jenis : "
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(531, 194)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(112, 35)
        Me.btnTambah.TabIndex = 6
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(652, 195)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(112, 35)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(774, 194)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(112, 35)
        Me.btnHapus.TabIndex = 8
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'txtNoPlat
        '
        Me.txtNoPlat.Enabled = False
        Me.txtNoPlat.Location = New System.Drawing.Point(117, 37)
        Me.txtNoPlat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNoPlat.Name = "txtNoPlat"
        Me.txtNoPlat.Size = New System.Drawing.Size(283, 26)
        Me.txtNoPlat.TabIndex = 9
        '
        'txtNama
        '
        Me.txtNama.Enabled = False
        Me.txtNama.Location = New System.Drawing.Point(117, 89)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(428, 26)
        Me.txtNama.TabIndex = 10
        '
        'txtBiaya
        '
        Me.txtBiaya.Enabled = False
        Me.txtBiaya.Location = New System.Drawing.Point(117, 142)
        Me.txtBiaya.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBiaya.Name = "txtBiaya"
        Me.txtBiaya.Size = New System.Drawing.Size(283, 26)
        Me.txtBiaya.TabIndex = 11
        '
        'cmbJenis
        '
        Me.cmbJenis.Enabled = False
        Me.cmbJenis.FormattingEnabled = True
        Me.cmbJenis.Items.AddRange(New Object() {"Motor", "Mobil", "Taxi/Umum", "Truk", "Sepeda"})
        Me.cmbJenis.Location = New System.Drawing.Point(531, 142)
        Me.cmbJenis.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(180, 28)
        Me.cmbJenis.TabIndex = 13
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(117, 194)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(298, 26)
        Me.DateTimePicker1.TabIndex = 14
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(896, 195)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(448, 37)
        Me.lblId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(23, 20)
        Me.lblId.TabIndex = 16
        Me.lblId.Text = "Id"
        Me.lblId.Visible = False
        '
        'frmLangganan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 532)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cmbJenis)
        Me.Controls.Add(Me.txtBiaya)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNoPlat)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.lblJenis)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblExpired)
        Me.Controls.Add(Me.lblBiaya)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblNoPlat)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmLangganan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Langganan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNoPlat As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblBiaya As System.Windows.Forms.Label
    Friend WithEvents lblExpired As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblJenis As System.Windows.Forms.Label
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents txtNoPlat As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtBiaya As System.Windows.Forms.TextBox
    Friend WithEvents cmbJenis As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblId As System.Windows.Forms.Label
End Class
