<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UbahProfil
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
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblNewPW = New System.Windows.Forms.Label()
        Me.lblKetikLgi = New System.Windows.Forms.Label()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.tbNewPW = New System.Windows.Forms.TextBox()
        Me.tbKetikLgi = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(61, 71)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(154, 28)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "username"
        '
        'lblNewPW
        '
        Me.lblNewPW.AutoSize = True
        Me.lblNewPW.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblNewPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPW.Location = New System.Drawing.Point(61, 128)
        Me.lblNewPW.Name = "lblNewPW"
        Me.lblNewPW.Size = New System.Drawing.Size(154, 26)
        Me.lblNewPW.TabIndex = 1
        Me.lblNewPW.Text = "password baru"
        '
        'lblKetikLgi
        '
        Me.lblKetikLgi.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblKetikLgi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKetikLgi.Location = New System.Drawing.Point(61, 189)
        Me.lblKetikLgi.Name = "lblKetikLgi"
        Me.lblKetikLgi.Size = New System.Drawing.Size(154, 26)
        Me.lblKetikLgi.TabIndex = 2
        Me.lblKetikLgi.Text = "ketik lagi"
        '
        'tbUsername
        '
        Me.tbUsername.Location = New System.Drawing.Point(221, 73)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(301, 26)
        Me.tbUsername.TabIndex = 3
        '
        'tbNewPW
        '
        Me.tbNewPW.Location = New System.Drawing.Point(221, 128)
        Me.tbNewPW.Name = "tbNewPW"
        Me.tbNewPW.Size = New System.Drawing.Size(301, 26)
        Me.tbNewPW.TabIndex = 4
        '
        'tbKetikLgi
        '
        Me.tbKetikLgi.Location = New System.Drawing.Point(221, 189)
        Me.tbKetikLgi.Name = "tbKetikLgi"
        Me.tbKetikLgi.Size = New System.Drawing.Size(301, 26)
        Me.tbKetikLgi.TabIndex = 5
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(300, 248)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(103, 49)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(419, 248)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(103, 49)
        Me.btnTutup.TabIndex = 7
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'UbahProfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 335)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.tbKetikLgi)
        Me.Controls.Add(Me.tbNewPW)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.lblKetikLgi)
        Me.Controls.Add(Me.lblNewPW)
        Me.Controls.Add(Me.lblUsername)
        Me.Name = "UbahProfil"
        Me.Text = "UbahProfil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblNewPW As Label
    Friend WithEvents lblKetikLgi As Label
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents tbNewPW As TextBox
    Friend WithEvents tbKetikLgi As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnTutup As Button
End Class
