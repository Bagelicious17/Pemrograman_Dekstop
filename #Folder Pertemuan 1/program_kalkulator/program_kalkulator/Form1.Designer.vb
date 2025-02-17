<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class program_kalkulator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Panel1 = New Panel()
        TextBox1 = New TextBox()
        Panel2 = New Panel()
        CmdEqual = New Button()
        CmdAddition = New Button()
        CmdInverse = New Button()
        CmdSubtract = New Button()
        CmdSqrt = New Button()
        CmdMultiply = New Button()
        CmdPowerOf = New Button()
        CmdDivision = New Button()
        CmdDecimal = New Button()
        CmdSign = New Button()
        Cmd0 = New Button()
        Cmd3 = New Button()
        Cmd2 = New Button()
        Cmd1 = New Button()
        Cmd6 = New Button()
        Cmd5 = New Button()
        Cmd4 = New Button()
        cmdC = New Button()
        cmdCE = New Button()
        Cmd9 = New Button()
        Cmd8 = New Button()
        Cmd7 = New Button()
        cmdBackspace = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(37, 33)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 74)
        Panel1.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(18, 10)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(262, 55)
        TextBox1.TabIndex = 0
        TextBox1.Text = "0"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(CmdEqual)
        Panel2.Controls.Add(CmdAddition)
        Panel2.Controls.Add(CmdInverse)
        Panel2.Controls.Add(CmdSubtract)
        Panel2.Controls.Add(CmdSqrt)
        Panel2.Controls.Add(CmdMultiply)
        Panel2.Controls.Add(CmdPowerOf)
        Panel2.Controls.Add(CmdDivision)
        Panel2.Controls.Add(CmdDecimal)
        Panel2.Controls.Add(CmdSign)
        Panel2.Controls.Add(Cmd0)
        Panel2.Controls.Add(Cmd3)
        Panel2.Controls.Add(Cmd2)
        Panel2.Controls.Add(Cmd1)
        Panel2.Controls.Add(Cmd6)
        Panel2.Controls.Add(Cmd5)
        Panel2.Controls.Add(Cmd4)
        Panel2.Controls.Add(cmdC)
        Panel2.Controls.Add(cmdCE)
        Panel2.Controls.Add(Cmd9)
        Panel2.Controls.Add(Cmd8)
        Panel2.Controls.Add(Cmd7)
        Panel2.Controls.Add(cmdBackspace)
        Panel2.Location = New Point(37, 113)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(300, 263)
        Panel2.TabIndex = 1
        ' 
        ' CmdEqual
        ' 
        CmdEqual.Location = New Point(234, 180)
        CmdEqual.Name = "CmdEqual"
        CmdEqual.Size = New Size(38, 34)
        CmdEqual.TabIndex = 20
        CmdEqual.Text = "="
        CmdEqual.UseVisualStyleBackColor = True
        ' 
        ' CmdAddition
        ' 
        CmdAddition.Location = New Point(190, 180)
        CmdAddition.Name = "CmdAddition"
        CmdAddition.Size = New Size(38, 34)
        CmdAddition.TabIndex = 19
        CmdAddition.Text = "+"
        CmdAddition.UseVisualStyleBackColor = True
        ' 
        ' CmdInverse
        ' 
        CmdInverse.Location = New Point(234, 140)
        CmdInverse.Name = "CmdInverse"
        CmdInverse.Size = New Size(46, 34)
        CmdInverse.TabIndex = 18
        CmdInverse.Text = "1/x"
        CmdInverse.UseVisualStyleBackColor = True
        ' 
        ' CmdSubtract
        ' 
        CmdSubtract.Location = New Point(190, 140)
        CmdSubtract.Name = "CmdSubtract"
        CmdSubtract.Size = New Size(38, 34)
        CmdSubtract.TabIndex = 3
        CmdSubtract.Text = "-"
        CmdSubtract.UseVisualStyleBackColor = True
        ' 
        ' CmdSqrt
        ' 
        CmdSqrt.Location = New Point(234, 100)
        CmdSqrt.Name = "CmdSqrt"
        CmdSqrt.Size = New Size(63, 34)
        CmdSqrt.TabIndex = 17
        CmdSqrt.Text = "SQRT"
        CmdSqrt.UseVisualStyleBackColor = True
        ' 
        ' CmdMultiply
        ' 
        CmdMultiply.Location = New Point(190, 100)
        CmdMultiply.Name = "CmdMultiply"
        CmdMultiply.Size = New Size(38, 34)
        CmdMultiply.TabIndex = 16
        CmdMultiply.Text = "*"
        CmdMultiply.UseVisualStyleBackColor = True
        ' 
        ' CmdPowerOf
        ' 
        CmdPowerOf.Location = New Point(234, 60)
        CmdPowerOf.Name = "CmdPowerOf"
        CmdPowerOf.Size = New Size(46, 34)
        CmdPowerOf.TabIndex = 15
        CmdPowerOf.Text = "X^ "
        CmdPowerOf.UseVisualStyleBackColor = True
        ' 
        ' CmdDivision
        ' 
        CmdDivision.Location = New Point(190, 60)
        CmdDivision.Name = "CmdDivision"
        CmdDivision.Size = New Size(38, 34)
        CmdDivision.TabIndex = 3
        CmdDivision.Text = "/"
        CmdDivision.UseVisualStyleBackColor = True
        ' 
        ' CmdDecimal
        ' 
        CmdDecimal.Location = New Point(115, 180)
        CmdDecimal.Name = "CmdDecimal"
        CmdDecimal.Size = New Size(38, 34)
        CmdDecimal.TabIndex = 14
        CmdDecimal.Text = "."
        CmdDecimal.UseVisualStyleBackColor = True
        ' 
        ' CmdSign
        ' 
        CmdSign.Location = New Point(62, 180)
        CmdSign.Name = "CmdSign"
        CmdSign.Size = New Size(47, 34)
        CmdSign.TabIndex = 13
        CmdSign.Text = "+/-"
        CmdSign.UseVisualStyleBackColor = True
        ' 
        ' Cmd0
        ' 
        Cmd0.Location = New Point(18, 180)
        Cmd0.Name = "Cmd0"
        Cmd0.Size = New Size(38, 34)
        Cmd0.TabIndex = 12
        Cmd0.Text = "0"
        Cmd0.UseVisualStyleBackColor = True
        ' 
        ' Cmd3
        ' 
        Cmd3.Location = New Point(106, 140)
        Cmd3.Name = "Cmd3"
        Cmd3.Size = New Size(38, 34)
        Cmd3.TabIndex = 11
        Cmd3.Text = "3"
        Cmd3.UseVisualStyleBackColor = True
        ' 
        ' Cmd2
        ' 
        Cmd2.Location = New Point(62, 140)
        Cmd2.Name = "Cmd2"
        Cmd2.Size = New Size(38, 34)
        Cmd2.TabIndex = 10
        Cmd2.Text = "2"
        Cmd2.UseVisualStyleBackColor = True
        ' 
        ' Cmd1
        ' 
        Cmd1.Location = New Point(18, 140)
        Cmd1.Name = "Cmd1"
        Cmd1.Size = New Size(38, 34)
        Cmd1.TabIndex = 9
        Cmd1.Text = "1"
        Cmd1.UseVisualStyleBackColor = True
        ' 
        ' Cmd6
        ' 
        Cmd6.Location = New Point(106, 100)
        Cmd6.Name = "Cmd6"
        Cmd6.Size = New Size(38, 34)
        Cmd6.TabIndex = 8
        Cmd6.Text = "6"
        Cmd6.UseVisualStyleBackColor = True
        ' 
        ' Cmd5
        ' 
        Cmd5.Location = New Point(62, 100)
        Cmd5.Name = "Cmd5"
        Cmd5.Size = New Size(38, 34)
        Cmd5.TabIndex = 7
        Cmd5.Text = "5"
        Cmd5.UseVisualStyleBackColor = True
        ' 
        ' Cmd4
        ' 
        Cmd4.Location = New Point(18, 100)
        Cmd4.Name = "Cmd4"
        Cmd4.Size = New Size(38, 34)
        Cmd4.TabIndex = 6
        Cmd4.Text = "4"
        Cmd4.UseVisualStyleBackColor = True
        ' 
        ' cmdC
        ' 
        cmdC.Location = New Point(234, 20)
        cmdC.Name = "cmdC"
        cmdC.Size = New Size(38, 34)
        cmdC.TabIndex = 5
        cmdC.Text = "C"
        cmdC.UseVisualStyleBackColor = True
        ' 
        ' cmdCE
        ' 
        cmdCE.Location = New Point(181, 20)
        cmdCE.Name = "cmdCE"
        cmdCE.Size = New Size(47, 34)
        cmdCE.TabIndex = 4
        cmdCE.Text = "CE"
        cmdCE.UseVisualStyleBackColor = True
        ' 
        ' Cmd9
        ' 
        Cmd9.Location = New Point(106, 60)
        Cmd9.Name = "Cmd9"
        Cmd9.Size = New Size(38, 34)
        Cmd9.TabIndex = 3
        Cmd9.Text = "9"
        Cmd9.UseVisualStyleBackColor = True
        ' 
        ' Cmd8
        ' 
        Cmd8.Location = New Point(62, 60)
        Cmd8.Name = "Cmd8"
        Cmd8.Size = New Size(38, 34)
        Cmd8.TabIndex = 2
        Cmd8.Text = "8"
        Cmd8.UseVisualStyleBackColor = True
        ' 
        ' Cmd7
        ' 
        Cmd7.Location = New Point(18, 60)
        Cmd7.Name = "Cmd7"
        Cmd7.Size = New Size(38, 34)
        Cmd7.TabIndex = 1
        Cmd7.Text = "7"
        Cmd7.UseVisualStyleBackColor = True
        ' 
        ' cmdBackspace
        ' 
        cmdBackspace.Location = New Point(18, 20)
        cmdBackspace.Name = "cmdBackspace"
        cmdBackspace.Size = New Size(103, 34)
        cmdBackspace.TabIndex = 0
        cmdBackspace.Text = "Backspace"
        cmdBackspace.UseVisualStyleBackColor = True
        ' 
        ' program_kalkulator
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(382, 404)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "program_kalkulator"
        Text = "calculator"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CmdSqrt As Button
    Friend WithEvents CmdMultiply As Button
    Friend WithEvents CmdPowerOf As Button
    Friend WithEvents CmdDivision As Button
    Friend WithEvents CmdDecimal As Button
    Friend WithEvents CmdSign As Button
    Friend WithEvents Cmd0 As Button
    Friend WithEvents Cmd3 As Button
    Friend WithEvents Cmd2 As Button
    Friend WithEvents Cmd1 As Button
    Friend WithEvents Cmd6 As Button
    Friend WithEvents Cmd5 As Button
    Friend WithEvents Cmd4 As Button
    Friend WithEvents cmdC As Button
    Friend WithEvents cmdCE As Button
    Friend WithEvents Cmd9 As Button
    Friend WithEvents Cmd8 As Button
    Friend WithEvents Cmd7 As Button
    Friend WithEvents cmdBackspace As Button
    Friend WithEvents CmdEqual As Button
    Friend WithEvents CmdAddition As Button
    Friend WithEvents CmdInverse As Button
    Friend WithEvents CmdSubtract As Button

End Class
