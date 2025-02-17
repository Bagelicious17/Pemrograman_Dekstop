<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lblCelcius = New Label()
        btnConvert = New Button()
        btnQuit = New Button()
        txtCelcius = New TextBox()
        txtFahrenheit = New TextBox()
        txtReamur = New TextBox()
        txtKelvin = New TextBox()
        SuspendLayout()
        ' 
        ' lblCelcius
        ' 
        lblCelcius.AutoSize = True
        lblCelcius.Location = New Point(75, 185)
        lblCelcius.Name = "lblCelcius"
        lblCelcius.Size = New Size(66, 25)
        lblCelcius.TabIndex = 0
        lblCelcius.Text = "Celcius"
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(303, 180)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(112, 34)
        btnConvert.TabIndex = 1
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnQuit
        ' 
        btnQuit.Location = New Point(421, 180)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(112, 34)
        btnQuit.TabIndex = 2
        btnQuit.Text = "Quit"
        btnQuit.UseVisualStyleBackColor = True
        ' 
        ' txtCelcius
        ' 
        txtCelcius.Location = New Point(147, 183)
        txtCelcius.Name = "txtCelcius"
        txtCelcius.Size = New Size(150, 31)
        txtCelcius.TabIndex = 3
        ' 
        ' txtFahrenheit
        ' 
        txtFahrenheit.Location = New Point(75, 261)
        txtFahrenheit.Name = "txtFahrenheit"
        txtFahrenheit.Size = New Size(150, 31)
        txtFahrenheit.TabIndex = 4
        ' 
        ' txtReamur
        ' 
        txtReamur.Location = New Point(231, 261)
        txtReamur.Name = "txtReamur"
        txtReamur.Size = New Size(150, 31)
        txtReamur.TabIndex = 5
        ' 
        ' txtKelvin
        ' 
        txtKelvin.Location = New Point(387, 261)
        txtKelvin.Name = "txtKelvin"
        txtKelvin.Size = New Size(150, 31)
        txtKelvin.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtKelvin)
        Controls.Add(txtReamur)
        Controls.Add(txtFahrenheit)
        Controls.Add(txtCelcius)
        Controls.Add(btnQuit)
        Controls.Add(btnConvert)
        Controls.Add(lblCelcius)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCelcius As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents txtReamur As TextBox
    Friend WithEvents txtKelvin As TextBox

End Class
