<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_Pendapatan_Parkir
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
        Me.lblPeriode = New System.Windows.Forms.Label()
        Me.lblLaporan = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblTahun = New System.Windows.Forms.Label()
        Me.btnTampil = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPeriode
        '
        Me.lblPeriode.AutoSize = True
        Me.lblPeriode.Location = New System.Drawing.Point(29, 33)
        Me.lblPeriode.Name = "lblPeriode"
        Me.lblPeriode.Size = New System.Drawing.Size(62, 20)
        Me.lblPeriode.TabIndex = 0
        Me.lblPeriode.Text = "periode"
        '
        'lblLaporan
        '
        Me.lblLaporan.AutoSize = True
        Me.lblLaporan.Location = New System.Drawing.Point(29, 73)
        Me.lblLaporan.Name = "lblLaporan"
        Me.lblLaporan.Size = New System.Drawing.Size(72, 20)
        Me.lblLaporan.TabIndex = 1
        Me.lblLaporan.Text = "Laporan:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(113, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 2
        '
        'lblTahun
        '
        Me.lblTahun.AutoSize = True
        Me.lblTahun.Location = New System.Drawing.Point(260, 36)
        Me.lblTahun.Name = "lblTahun"
        Me.lblTahun.Size = New System.Drawing.Size(54, 20)
        Me.lblTahun.TabIndex = 3
        Me.lblTahun.Text = "Tahun"
        '
        'btnTampil
        '
        Me.btnTampil.Location = New System.Drawing.Point(320, 30)
        Me.btnTampil.Name = "btnTampil"
        Me.btnTampil.Size = New System.Drawing.Size(96, 34)
        Me.btnTampil.TabIndex = 4
        Me.btnTampil.Text = "Tampilkan!"
        Me.btnTampil.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(33, 113)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(755, 241)
        Me.TextBox1.TabIndex = 5
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(693, 370)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(95, 36)
        Me.btnTutup.TabIndex = 6
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'Laporan_Pendapatan_Parkir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 424)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnTampil)
        Me.Controls.Add(Me.lblTahun)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblLaporan)
        Me.Controls.Add(Me.lblPeriode)
        Me.Name = "Laporan_Pendapatan_Parkir"
        Me.Text = "Laporan_Pendapatan_Parkir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPeriode As Label
    Friend WithEvents lblLaporan As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblTahun As Label
    Friend WithEvents btnTampil As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnTutup As Button
End Class
