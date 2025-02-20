<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblReserve = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.numGuest = New System.Windows.Forms.NumericUpDown()
        Me.lblGuest = New System.Windows.Forms.Label()
        Me.lblTable = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cbTable3 = New System.Windows.Forms.CheckBox()
        Me.cbTable2 = New System.Windows.Forms.CheckBox()
        Me.cbTable1 = New System.Windows.Forms.CheckBox()
        Me.tbPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblName2 = New System.Windows.Forms.Label()
        Me.lblName1 = New System.Windows.Forms.Label()
        Me.tbName2 = New System.Windows.Forms.TextBox()
        Me.tbName1 = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.numGuest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblReserve
        '
        Me.lblReserve.AutoSize = True
        Me.lblReserve.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReserve.Location = New System.Drawing.Point(12, 9)
        Me.lblReserve.Name = "lblReserve"
        Me.lblReserve.Size = New System.Drawing.Size(530, 69)
        Me.lblReserve.TabIndex = 0
        Me.lblReserve.Text = "Reservation Table"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.numGuest)
        Me.Panel1.Controls.Add(Me.lblGuest)
        Me.Panel1.Controls.Add(Me.lblTable)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.cbTable3)
        Me.Panel1.Controls.Add(Me.cbTable2)
        Me.Panel1.Controls.Add(Me.cbTable1)
        Me.Panel1.Controls.Add(Me.tbPhone)
        Me.Panel1.Controls.Add(Me.lblPhone)
        Me.Panel1.Controls.Add(Me.tbEmail)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.lblName2)
        Me.Panel1.Controls.Add(Me.lblName1)
        Me.Panel1.Controls.Add(Me.tbName2)
        Me.Panel1.Controls.Add(Me.tbName1)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Location = New System.Drawing.Point(12, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(718, 572)
        Me.Panel1.TabIndex = 1
        '
        'numGuest
        '
        Me.numGuest.Location = New System.Drawing.Point(133, 319)
        Me.numGuest.Name = "numGuest"
        Me.numGuest.Size = New System.Drawing.Size(120, 26)
        Me.numGuest.TabIndex = 15
        '
        'lblGuest
        '
        Me.lblGuest.AutoSize = True
        Me.lblGuest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuest.Location = New System.Drawing.Point(27, 319)
        Me.lblGuest.Name = "lblGuest"
        Me.lblGuest.Size = New System.Drawing.Size(64, 25)
        Me.lblGuest.TabIndex = 14
        Me.lblGuest.Text = "Guest"
        '
        'lblTable
        '
        Me.lblTable.AutoSize = True
        Me.lblTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTable.Location = New System.Drawing.Point(27, 206)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(62, 25)
        Me.lblTable.TabIndex = 13
        Me.lblTable.Text = "Table"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.ComboBox1.Location = New System.Drawing.Point(236, 209)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 12
        Me.ComboBox1.Text = "How Many?"
        '
        'cbTable3
        '
        Me.cbTable3.AutoSize = True
        Me.cbTable3.Location = New System.Drawing.Point(133, 266)
        Me.cbTable3.Name = "cbTable3"
        Me.cbTable3.Size = New System.Drawing.Size(106, 24)
        Me.cbTable3.TabIndex = 11
        Me.cbTable3.Text = "20 person"
        Me.cbTable3.UseVisualStyleBackColor = True
        '
        'cbTable2
        '
        Me.cbTable2.AutoSize = True
        Me.cbTable2.Location = New System.Drawing.Point(133, 236)
        Me.cbTable2.Name = "cbTable2"
        Me.cbTable2.Size = New System.Drawing.Size(97, 24)
        Me.cbTable2.TabIndex = 10
        Me.cbTable2.Text = "8 person"
        Me.cbTable2.UseVisualStyleBackColor = True
        '
        'cbTable1
        '
        Me.cbTable1.AutoSize = True
        Me.cbTable1.Location = New System.Drawing.Point(133, 206)
        Me.cbTable1.Name = "cbTable1"
        Me.cbTable1.Size = New System.Drawing.Size(97, 24)
        Me.cbTable1.TabIndex = 9
        Me.cbTable1.Text = "4 person"
        Me.cbTable1.UseVisualStyleBackColor = True
        '
        'tbPhone
        '
        Me.tbPhone.Location = New System.Drawing.Point(133, 151)
        Me.tbPhone.Name = "tbPhone"
        Me.tbPhone.Size = New System.Drawing.Size(262, 26)
        Me.tbPhone.TabIndex = 8
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(27, 150)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(69, 25)
        Me.lblPhone.TabIndex = 7
        Me.lblPhone.Text = "Phone"
        '
        'tbEmail
        '
        Me.tbEmail.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.tbEmail.Location = New System.Drawing.Point(133, 95)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(262, 26)
        Me.tbEmail.TabIndex = 6
        Me.tbEmail.Text = "ex: myname@example.com"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(27, 96)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(60, 25)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "Email"
        '
        'lblName2
        '
        Me.lblName2.AutoSize = True
        Me.lblName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblName2.Location = New System.Drawing.Point(264, 60)
        Me.lblName2.Name = "lblName2"
        Me.lblName2.Size = New System.Drawing.Size(76, 17)
        Me.lblName2.TabIndex = 4
        Me.lblName2.Text = "Last Name"
        '
        'lblName1
        '
        Me.lblName1.AutoSize = True
        Me.lblName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblName1.Location = New System.Drawing.Point(130, 60)
        Me.lblName1.Name = "lblName1"
        Me.lblName1.Size = New System.Drawing.Size(76, 17)
        Me.lblName1.TabIndex = 3
        Me.lblName1.Text = "First Name"
        '
        'tbName2
        '
        Me.tbName2.Location = New System.Drawing.Point(267, 31)
        Me.tbName2.Name = "tbName2"
        Me.tbName2.Size = New System.Drawing.Size(128, 26)
        Me.tbName2.TabIndex = 2
        '
        'tbName1
        '
        Me.tbName1.Location = New System.Drawing.Point(133, 31)
        Me.tbName1.Name = "tbName1"
        Me.tbName1.Size = New System.Drawing.Size(128, 26)
        Me.tbName1.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(27, 30)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 25)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Full Name"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(19, 78)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(478, 25)
        Me.lblDesc.TabIndex = 2
        Me.lblDesc.Text = "please fill the form below to enable us serve you better"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.ComboBox2.Location = New System.Drawing.Point(236, 234)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox2.TabIndex = 16
        Me.ComboBox2.Text = "How Many?"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.ComboBox3.Location = New System.Drawing.Point(236, 264)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox3.TabIndex = 17
        Me.ComboBox3.Text = "How Many?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 690)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblReserve)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.numGuest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblReserve As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblName2 As Label
    Friend WithEvents lblName1 As Label
    Friend WithEvents tbName2 As TextBox
    Friend WithEvents tbName1 As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents tbPhone As TextBox
    Friend WithEvents cbTable1 As CheckBox
    Friend WithEvents lblTable As Label
    Friend WithEvents cbTable3 As CheckBox
    Friend WithEvents cbTable2 As CheckBox
    Friend WithEvents numGuest As NumericUpDown
    Friend WithEvents lblGuest As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
End Class
