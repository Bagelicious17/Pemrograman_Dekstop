<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfil
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
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtRetype = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
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
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(221, 73)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(301, 26)
        Me.txtUsername.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(221, 128)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(301, 26)
        Me.txtPassword.TabIndex = 4
        '
        'txtRetype
        '
        Me.txtRetype.Location = New System.Drawing.Point(221, 189)
        Me.txtRetype.Name = "txtRetype"
        Me.txtRetype.Size = New System.Drawing.Size(301, 26)
        Me.txtRetype.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(300, 248)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 49)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Simpan"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(419, 248)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(103, 49)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Tutup"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmProfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 335)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtRetype)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblKetikLgi)
        Me.Controls.Add(Me.lblNewPW)
        Me.Controls.Add(Me.lblUsername)
        Me.Name = "frmProfil"
        Me.Text = "Form Profil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblNewPW As Label
    Friend WithEvents lblKetikLgi As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtRetype As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
End Class
