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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ShapeIsi = New System.Windows.Forms.PictureBox()
        Me.ShapeTepian = New System.Windows.Forms.PictureBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioElipsIsi = New System.Windows.Forms.RadioButton()
        Me.RadioKotakIsi = New System.Windows.Forms.RadioButton()
        Me.RadioElips = New System.Windows.Forms.RadioButton()
        Me.RadioKotak = New System.Windows.Forms.RadioButton()
        Me.RadioGaris = New System.Windows.Forms.RadioButton()
        Me.RadioBebas = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnGbrUlang = New System.Windows.Forms.Button()
        Me.btnBersihkan = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.Warna6 = New System.Windows.Forms.PictureBox()
        Me.Warna5 = New System.Windows.Forms.PictureBox()
        Me.Warna4 = New System.Windows.Forms.PictureBox()
        Me.Warna3 = New System.Windows.Forms.PictureBox()
        Me.Warna2 = New System.Windows.Forms.PictureBox()
        Me.Warna1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnRedo = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ShapeIsi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShapeTepian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Warna6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Warna5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Warna4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Warna3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Warna2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Warna1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(943, 414)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(943, 36)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BukaToolStripMenuItem, Me.SimpanToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 30)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BukaToolStripMenuItem
        '
        Me.BukaToolStripMenuItem.Name = "BukaToolStripMenuItem"
        Me.BukaToolStripMenuItem.Size = New System.Drawing.Size(174, 34)
        Me.BukaToolStripMenuItem.Text = "Buka"
        '
        'SimpanToolStripMenuItem
        '
        Me.SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        Me.SimpanToolStripMenuItem.Size = New System.Drawing.Size(174, 34)
        Me.SimpanToolStripMenuItem.Text = "Simpan"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(174, 34)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ShapeIsi)
        Me.GroupBox1.Controls.Add(Me.ShapeTepian)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RadioElipsIsi)
        Me.GroupBox1.Controls.Add(Me.RadioKotakIsi)
        Me.GroupBox1.Controls.Add(Me.RadioElips)
        Me.GroupBox1.Controls.Add(Me.RadioKotak)
        Me.GroupBox1.Controls.Add(Me.RadioGaris)
        Me.GroupBox1.Controls.Add(Me.RadioBebas)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 414)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tools"
        '
        'ShapeIsi
        '
        Me.ShapeIsi.BackColor = System.Drawing.Color.White
        Me.ShapeIsi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ShapeIsi.Location = New System.Drawing.Point(86, 342)
        Me.ShapeIsi.Name = "ShapeIsi"
        Me.ShapeIsi.Size = New System.Drawing.Size(50, 50)
        Me.ShapeIsi.TabIndex = 8
        Me.ShapeIsi.TabStop = False
        '
        'ShapeTepian
        '
        Me.ShapeTepian.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ShapeTepian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ShapeTepian.Location = New System.Drawing.Point(16, 342)
        Me.ShapeTepian.Name = "ShapeTepian"
        Me.ShapeTepian.Size = New System.Drawing.Size(50, 50)
        Me.ShapeTepian.TabIndex = 7
        Me.ShapeTepian.TabStop = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(16, 243)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 26)
        Me.NumericUpDown1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ukuran Garis Tepi"
        '
        'RadioElipsIsi
        '
        Me.RadioElipsIsi.AutoSize = True
        Me.RadioElipsIsi.Location = New System.Drawing.Point(12, 175)
        Me.RadioElipsIsi.Name = "RadioElipsIsi"
        Me.RadioElipsIsi.Size = New System.Drawing.Size(88, 24)
        Me.RadioElipsIsi.TabIndex = 5
        Me.RadioElipsIsi.TabStop = True
        Me.RadioElipsIsi.Text = "Elips Isi"
        Me.RadioElipsIsi.UseVisualStyleBackColor = True
        '
        'RadioKotakIsi
        '
        Me.RadioKotakIsi.AutoSize = True
        Me.RadioKotakIsi.Location = New System.Drawing.Point(12, 145)
        Me.RadioKotakIsi.Name = "RadioKotakIsi"
        Me.RadioKotakIsi.Size = New System.Drawing.Size(95, 24)
        Me.RadioKotakIsi.TabIndex = 4
        Me.RadioKotakIsi.TabStop = True
        Me.RadioKotakIsi.Text = "Kotak Isi"
        Me.RadioKotakIsi.UseVisualStyleBackColor = True
        '
        'RadioElips
        '
        Me.RadioElips.AutoSize = True
        Me.RadioElips.Location = New System.Drawing.Point(12, 115)
        Me.RadioElips.Name = "RadioElips"
        Me.RadioElips.Size = New System.Drawing.Size(68, 24)
        Me.RadioElips.TabIndex = 3
        Me.RadioElips.TabStop = True
        Me.RadioElips.Text = "Elips"
        Me.RadioElips.UseVisualStyleBackColor = True
        '
        'RadioKotak
        '
        Me.RadioKotak.AutoSize = True
        Me.RadioKotak.Location = New System.Drawing.Point(12, 85)
        Me.RadioKotak.Name = "RadioKotak"
        Me.RadioKotak.Size = New System.Drawing.Size(75, 24)
        Me.RadioKotak.TabIndex = 2
        Me.RadioKotak.TabStop = True
        Me.RadioKotak.Text = "Kotak"
        Me.RadioKotak.UseVisualStyleBackColor = True
        '
        'RadioGaris
        '
        Me.RadioGaris.AutoSize = True
        Me.RadioGaris.Location = New System.Drawing.Point(12, 55)
        Me.RadioGaris.Name = "RadioGaris"
        Me.RadioGaris.Size = New System.Drawing.Size(72, 24)
        Me.RadioGaris.TabIndex = 1
        Me.RadioGaris.TabStop = True
        Me.RadioGaris.Text = "Garis"
        Me.RadioGaris.UseVisualStyleBackColor = True
        '
        'RadioBebas
        '
        Me.RadioBebas.AutoSize = True
        Me.RadioBebas.Location = New System.Drawing.Point(12, 25)
        Me.RadioBebas.Name = "RadioBebas"
        Me.RadioBebas.Size = New System.Drawing.Size(80, 24)
        Me.RadioBebas.TabIndex = 0
        Me.RadioBebas.TabStop = True
        Me.RadioBebas.Text = "Bebas"
        Me.RadioBebas.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRedo)
        Me.GroupBox2.Controls.Add(Me.btnGbrUlang)
        Me.GroupBox2.Controls.Add(Me.btnBersihkan)
        Me.GroupBox2.Controls.Add(Me.btnUndo)
        Me.GroupBox2.Controls.Add(Me.Warna6)
        Me.GroupBox2.Controls.Add(Me.Warna5)
        Me.GroupBox2.Controls.Add(Me.Warna4)
        Me.GroupBox2.Controls.Add(Me.Warna3)
        Me.GroupBox2.Controls.Add(Me.Warna2)
        Me.GroupBox2.Controls.Add(Me.Warna1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(164, 350)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(779, 100)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Warna"
        '
        'btnGbrUlang
        '
        Me.btnGbrUlang.Location = New System.Drawing.Point(632, 44)
        Me.btnGbrUlang.Name = "btnGbrUlang"
        Me.btnGbrUlang.Size = New System.Drawing.Size(135, 36)
        Me.btnGbrUlang.TabIndex = 17
        Me.btnGbrUlang.Text = "Gambar Ulang"
        Me.btnGbrUlang.UseVisualStyleBackColor = True
        '
        'btnBersihkan
        '
        Me.btnBersihkan.Location = New System.Drawing.Point(501, 44)
        Me.btnBersihkan.Name = "btnBersihkan"
        Me.btnBersihkan.Size = New System.Drawing.Size(92, 36)
        Me.btnBersihkan.TabIndex = 16
        Me.btnBersihkan.Text = "Bersihkan"
        Me.btnBersihkan.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(389, 57)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(92, 36)
        Me.btnUndo.TabIndex = 15
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'Warna6
        '
        Me.Warna6.BackColor = System.Drawing.Color.Black
        Me.Warna6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Warna6.Location = New System.Drawing.Point(305, 38)
        Me.Warna6.Name = "Warna6"
        Me.Warna6.Size = New System.Drawing.Size(50, 50)
        Me.Warna6.TabIndex = 14
        Me.Warna6.TabStop = False
        '
        'Warna5
        '
        Me.Warna5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Warna5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Warna5.Location = New System.Drawing.Point(249, 38)
        Me.Warna5.Name = "Warna5"
        Me.Warna5.Size = New System.Drawing.Size(50, 50)
        Me.Warna5.TabIndex = 13
        Me.Warna5.TabStop = False
        '
        'Warna4
        '
        Me.Warna4.BackColor = System.Drawing.Color.Blue
        Me.Warna4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Warna4.Location = New System.Drawing.Point(193, 38)
        Me.Warna4.Name = "Warna4"
        Me.Warna4.Size = New System.Drawing.Size(50, 50)
        Me.Warna4.TabIndex = 12
        Me.Warna4.TabStop = False
        '
        'Warna3
        '
        Me.Warna3.BackColor = System.Drawing.Color.Green
        Me.Warna3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Warna3.Location = New System.Drawing.Point(137, 38)
        Me.Warna3.Name = "Warna3"
        Me.Warna3.Size = New System.Drawing.Size(50, 50)
        Me.Warna3.TabIndex = 11
        Me.Warna3.TabStop = False
        '
        'Warna2
        '
        Me.Warna2.BackColor = System.Drawing.Color.Yellow
        Me.Warna2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Warna2.Location = New System.Drawing.Point(81, 38)
        Me.Warna2.Name = "Warna2"
        Me.Warna2.Size = New System.Drawing.Size(50, 50)
        Me.Warna2.TabIndex = 10
        Me.Warna2.TabStop = False
        '
        'Warna1
        '
        Me.Warna1.BackColor = System.Drawing.Color.Red
        Me.Warna1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Warna1.Location = New System.Drawing.Point(25, 38)
        Me.Warna1.Name = "Warna1"
        Me.Warna1.Size = New System.Drawing.Size(50, 50)
        Me.Warna1.TabIndex = 9
        Me.Warna1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox3.Location = New System.Drawing.Point(796, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(147, 314)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 25)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(135, 286)
        Me.TextBox1.TabIndex = 0
        '
        'btnRedo
        '
        Me.btnRedo.Location = New System.Drawing.Point(389, 17)
        Me.btnRedo.Name = "btnRedo"
        Me.btnRedo.Size = New System.Drawing.Size(92, 36)
        Me.btnRedo.TabIndex = 18
        Me.btnRedo.Text = "Redo"
        Me.btnRedo.UseVisualStyleBackColor = True
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmUtama"
        Me.Text = "Utama"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ShapeIsi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShapeTepian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Warna6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Warna5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Warna4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Warna3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Warna2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Warna1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioElips As RadioButton
    Friend WithEvents RadioKotak As RadioButton
    Friend WithEvents RadioGaris As RadioButton
    Friend WithEvents RadioBebas As RadioButton
    Friend WithEvents RadioElipsIsi As RadioButton
    Friend WithEvents RadioKotakIsi As RadioButton
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents ShapeTepian As PictureBox
    Friend WithEvents ShapeIsi As PictureBox
    Friend WithEvents Warna6 As PictureBox
    Friend WithEvents Warna5 As PictureBox
    Friend WithEvents Warna4 As PictureBox
    Friend WithEvents Warna3 As PictureBox
    Friend WithEvents Warna2 As PictureBox
    Friend WithEvents Warna1 As PictureBox
    Friend WithEvents btnGbrUlang As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnRedo As Button
End Class
