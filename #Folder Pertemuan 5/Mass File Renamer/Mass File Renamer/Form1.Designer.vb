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
        Me.lblPath = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnPath = New System.Windows.Forms.Button()
        Me.lblExt = New System.Windows.Forms.Label()
        Me.txtExt = New System.Windows.Forms.TextBox()
        Me.lblOri = New System.Windows.Forms.Label()
        Me.lvOri = New System.Windows.Forms.ListView()
        Me.chFileName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExtension = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAttribute = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCreated = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAccessed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chModified = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.chFileName2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExtension2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAttribute2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCreated2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAccessed2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chModified2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpFileName = New System.Windows.Forms.TabPage()
        Me.txtLeftCropNCharF = New System.Windows.Forms.TextBox()
        Me.txtRightCropNCharF = New System.Windows.Forms.TextBox()
        Me.rbRightCropNCharF = New System.Windows.Forms.RadioButton()
        Me.txtInsertBeforeF = New System.Windows.Forms.TextBox()
        Me.txtInsertAfterF = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.txtWithThisF = New System.Windows.Forms.TextBox()
        Me.txtReplaceThisF = New System.Windows.Forms.TextBox()
        Me.lblWithThisF = New System.Windows.Forms.Label()
        Me.txtReplaceWithF = New System.Windows.Forms.TextBox()
        Me.lblCaseF = New System.Windows.Forms.Label()
        Me.cbCaseF = New System.Windows.Forms.ComboBox()
        Me.rbLeftCropNCharF = New System.Windows.Forms.RadioButton()
        Me.rbInsertBeforeF = New System.Windows.Forms.RadioButton()
        Me.rbReplaceThisF = New System.Windows.Forms.RadioButton()
        Me.rbReplaceWithF = New System.Windows.Forms.RadioButton()
        Me.tpExtension = New System.Windows.Forms.TabPage()
        Me.tpAutoNumber = New System.Windows.Forms.TabPage()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.txtLeftCropNCharE = New System.Windows.Forms.TextBox()
        Me.txtRightCropNCharE = New System.Windows.Forms.TextBox()
        Me.rbRightCropNCharE = New System.Windows.Forms.RadioButton()
        Me.txtInsertBeforeE = New System.Windows.Forms.TextBox()
        Me.txtInsertAfterE = New System.Windows.Forms.TextBox()
        Me.rbInsertAfterE = New System.Windows.Forms.RadioButton()
        Me.txtWithThisE = New System.Windows.Forms.TextBox()
        Me.txtReplaceThisE = New System.Windows.Forms.TextBox()
        Me.lblWithThisE = New System.Windows.Forms.Label()
        Me.txtReplaceWithE = New System.Windows.Forms.TextBox()
        Me.lblCaseE = New System.Windows.Forms.Label()
        Me.cbCaseE = New System.Windows.Forms.ComboBox()
        Me.rbLeftCropNCharE = New System.Windows.Forms.RadioButton()
        Me.rbInsertBeforeE = New System.Windows.Forms.RadioButton()
        Me.rbReplaceThisE = New System.Windows.Forms.RadioButton()
        Me.rbReplaceWithE = New System.Windows.Forms.RadioButton()
        Me.gbPlace = New System.Windows.Forms.GroupBox()
        Me.gbWith = New System.Windows.Forms.GroupBox()
        Me.rbAfterFileName = New System.Windows.Forms.RadioButton()
        Me.rbBeforeFileName = New System.Windows.Forms.RadioButton()
        Me.lblStartWithNumber = New System.Windows.Forms.Label()
        Me.lblIncrementBy = New System.Windows.Forms.Label()
        Me.nudStartWithNumber = New System.Windows.Forms.NumericUpDown()
        Me.nudIncrementBy = New System.Windows.Forms.NumericUpDown()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabControl1.SuspendLayout()
        Me.tpFileName.SuspendLayout()
        Me.tpExtension.SuspendLayout()
        Me.tpAutoNumber.SuspendLayout()
        Me.gbPlace.SuspendLayout()
        Me.gbWith.SuspendLayout()
        CType(Me.nudStartWithNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIncrementBy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(12, 9)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(41, 20)
        Me.lblPath.TabIndex = 0
        Me.lblPath.Text = "path"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(59, 12)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(461, 26)
        Me.txtPath.TabIndex = 1
        '
        'btnPath
        '
        Me.btnPath.Location = New System.Drawing.Point(526, 12)
        Me.btnPath.Name = "btnPath"
        Me.btnPath.Size = New System.Drawing.Size(75, 26)
        Me.btnPath.TabIndex = 2
        Me.btnPath.Text = "..."
        Me.btnPath.UseVisualStyleBackColor = True
        '
        'lblExt
        '
        Me.lblExt.AutoSize = True
        Me.lblExt.Location = New System.Drawing.Point(607, 18)
        Me.lblExt.Name = "lblExt"
        Me.lblExt.Size = New System.Drawing.Size(76, 20)
        Me.lblExt.TabIndex = 3
        Me.lblExt.Text = "File Mask"
        '
        'txtExt
        '
        Me.txtExt.Location = New System.Drawing.Point(688, 15)
        Me.txtExt.Name = "txtExt"
        Me.txtExt.Size = New System.Drawing.Size(100, 26)
        Me.txtExt.TabIndex = 4
        Me.txtExt.Text = "*.*"
        '
        'lblOri
        '
        Me.lblOri.AutoSize = True
        Me.lblOri.Location = New System.Drawing.Point(12, 41)
        Me.lblOri.Name = "lblOri"
        Me.lblOri.Size = New System.Drawing.Size(95, 20)
        Me.lblOri.TabIndex = 5
        Me.lblOri.Text = "Original File:"
        '
        'lvOri
        '
        Me.lvOri.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chFileName, Me.chExtension, Me.chAttribute, Me.chCreated, Me.chAccessed, Me.chModified})
        Me.lvOri.GridLines = True
        Me.lvOri.HideSelection = False
        Me.lvOri.Location = New System.Drawing.Point(16, 64)
        Me.lvOri.Name = "lvOri"
        Me.lvOri.Size = New System.Drawing.Size(370, 224)
        Me.lvOri.TabIndex = 6
        Me.lvOri.UseCompatibleStateImageBehavior = False
        Me.lvOri.View = System.Windows.Forms.View.Details
        '
        'chFileName
        '
        Me.chFileName.Text = "File Name"
        '
        'chExtension
        '
        Me.chExtension.Text = "Extension"
        '
        'chAttribute
        '
        Me.chAttribute.Text = "Attributes"
        '
        'chCreated
        '
        Me.chCreated.Text = "Date Created"
        '
        'chAccessed
        '
        Me.chAccessed.Text = "Date Accessed"
        '
        'chModified
        '
        Me.chModified.Text = "Date Modified"
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chFileName2, Me.chExtension2, Me.chAttribute2, Me.chCreated2, Me.chAccessed2, Me.chModified2})
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(392, 64)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(396, 224)
        Me.ListView2.TabIndex = 7
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'chFileName2
        '
        Me.chFileName2.Text = "File Name"
        '
        'chExtension2
        '
        Me.chExtension2.Text = " Extension"
        '
        'chAttribute2
        '
        Me.chAttribute2.Text = "Attributes"
        '
        'chCreated2
        '
        Me.chCreated2.Text = "Date Created"
        '
        'chAccessed2
        '
        Me.chAccessed2.Text = "Date Accessed"
        '
        'chModified2
        '
        Me.chModified2.Text = "Date Modified"
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.Location = New System.Drawing.Point(388, 41)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(96, 20)
        Me.lblPreview.TabIndex = 8
        Me.lblPreview.Text = "Preview File:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpFileName)
        Me.TabControl1.Controls.Add(Me.tpExtension)
        Me.TabControl1.Controls.Add(Me.tpAutoNumber)
        Me.TabControl1.Location = New System.Drawing.Point(16, 294)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(691, 172)
        Me.TabControl1.TabIndex = 9
        '
        'tpFileName
        '
        Me.tpFileName.Controls.Add(Me.txtLeftCropNCharF)
        Me.tpFileName.Controls.Add(Me.txtRightCropNCharF)
        Me.tpFileName.Controls.Add(Me.rbRightCropNCharF)
        Me.tpFileName.Controls.Add(Me.txtInsertBeforeF)
        Me.tpFileName.Controls.Add(Me.txtInsertAfterF)
        Me.tpFileName.Controls.Add(Me.RadioButton1)
        Me.tpFileName.Controls.Add(Me.txtWithThisF)
        Me.tpFileName.Controls.Add(Me.txtReplaceThisF)
        Me.tpFileName.Controls.Add(Me.lblWithThisF)
        Me.tpFileName.Controls.Add(Me.txtReplaceWithF)
        Me.tpFileName.Controls.Add(Me.lblCaseF)
        Me.tpFileName.Controls.Add(Me.cbCaseF)
        Me.tpFileName.Controls.Add(Me.rbLeftCropNCharF)
        Me.tpFileName.Controls.Add(Me.rbInsertBeforeF)
        Me.tpFileName.Controls.Add(Me.rbReplaceThisF)
        Me.tpFileName.Controls.Add(Me.rbReplaceWithF)
        Me.tpFileName.Location = New System.Drawing.Point(4, 29)
        Me.tpFileName.Name = "tpFileName"
        Me.tpFileName.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFileName.Size = New System.Drawing.Size(683, 139)
        Me.tpFileName.TabIndex = 0
        Me.tpFileName.Text = "Filename"
        Me.tpFileName.UseVisualStyleBackColor = True
        '
        'txtLeftCropNCharF
        '
        Me.txtLeftCropNCharF.Location = New System.Drawing.Point(160, 100)
        Me.txtLeftCropNCharF.Name = "txtLeftCropNCharF"
        Me.txtLeftCropNCharF.ReadOnly = True
        Me.txtLeftCropNCharF.Size = New System.Drawing.Size(116, 26)
        Me.txtLeftCropNCharF.TabIndex = 15
        '
        'txtRightCropNCharF
        '
        Me.txtRightCropNCharF.Location = New System.Drawing.Point(550, 100)
        Me.txtRightCropNCharF.Name = "txtRightCropNCharF"
        Me.txtRightCropNCharF.ReadOnly = True
        Me.txtRightCropNCharF.Size = New System.Drawing.Size(127, 26)
        Me.txtRightCropNCharF.TabIndex = 14
        '
        'rbRightCropNCharF
        '
        Me.rbRightCropNCharF.AutoSize = True
        Me.rbRightCropNCharF.Location = New System.Drawing.Point(386, 102)
        Me.rbRightCropNCharF.Name = "rbRightCropNCharF"
        Me.rbRightCropNCharF.Size = New System.Drawing.Size(158, 24)
        Me.rbRightCropNCharF.TabIndex = 13
        Me.rbRightCropNCharF.Text = "Right Crop n char"
        Me.rbRightCropNCharF.UseVisualStyleBackColor = True
        '
        'txtInsertBeforeF
        '
        Me.txtInsertBeforeF.Location = New System.Drawing.Point(139, 70)
        Me.txtInsertBeforeF.Name = "txtInsertBeforeF"
        Me.txtInsertBeforeF.ReadOnly = True
        Me.txtInsertBeforeF.Size = New System.Drawing.Size(291, 26)
        Me.txtInsertBeforeF.TabIndex = 12
        '
        'txtInsertAfterF
        '
        Me.txtInsertAfterF.Location = New System.Drawing.Point(550, 70)
        Me.txtInsertAfterF.Name = "txtInsertAfterF"
        Me.txtInsertAfterF.ReadOnly = True
        Me.txtInsertAfterF.Size = New System.Drawing.Size(127, 26)
        Me.txtInsertAfterF.TabIndex = 11
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(436, 70)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(114, 24)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.Text = "Insert After"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'txtWithThisF
        '
        Me.txtWithThisF.Location = New System.Drawing.Point(550, 38)
        Me.txtWithThisF.Name = "txtWithThisF"
        Me.txtWithThisF.ReadOnly = True
        Me.txtWithThisF.Size = New System.Drawing.Size(127, 26)
        Me.txtWithThisF.TabIndex = 9
        '
        'txtReplaceThisF
        '
        Me.txtReplaceThisF.Location = New System.Drawing.Point(141, 38)
        Me.txtReplaceThisF.Name = "txtReplaceThisF"
        Me.txtReplaceThisF.ReadOnly = True
        Me.txtReplaceThisF.Size = New System.Drawing.Size(319, 26)
        Me.txtReplaceThisF.TabIndex = 8
        '
        'lblWithThisF
        '
        Me.lblWithThisF.AutoSize = True
        Me.lblWithThisF.Location = New System.Drawing.Point(466, 38)
        Me.lblWithThisF.Name = "lblWithThisF"
        Me.lblWithThisF.Size = New System.Drawing.Size(78, 20)
        Me.lblWithThisF.TabIndex = 7
        Me.lblWithThisF.Text = "With This:"
        '
        'txtReplaceWithF
        '
        Me.txtReplaceWithF.Location = New System.Drawing.Point(141, 6)
        Me.txtReplaceWithF.Name = "txtReplaceWithF"
        Me.txtReplaceWithF.ReadOnly = True
        Me.txtReplaceWithF.Size = New System.Drawing.Size(353, 26)
        Me.txtReplaceWithF.TabIndex = 6
        '
        'lblCaseF
        '
        Me.lblCaseF.AutoSize = True
        Me.lblCaseF.Location = New System.Drawing.Point(500, 9)
        Me.lblCaseF.Name = "lblCaseF"
        Me.lblCaseF.Size = New System.Drawing.Size(50, 20)
        Me.lblCaseF.TabIndex = 5
        Me.lblCaseF.Text = "Case:"
        '
        'cbCaseF
        '
        Me.cbCaseF.FormattingEnabled = True
        Me.cbCaseF.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        Me.cbCaseF.Location = New System.Drawing.Point(556, 6)
        Me.cbCaseF.Name = "cbCaseF"
        Me.cbCaseF.Size = New System.Drawing.Size(121, 28)
        Me.cbCaseF.TabIndex = 4
        '
        'rbLeftCropNCharF
        '
        Me.rbLeftCropNCharF.AutoSize = True
        Me.rbLeftCropNCharF.Location = New System.Drawing.Point(6, 96)
        Me.rbLeftCropNCharF.Name = "rbLeftCropNCharF"
        Me.rbLeftCropNCharF.Size = New System.Drawing.Size(148, 24)
        Me.rbLeftCropNCharF.TabIndex = 3
        Me.rbLeftCropNCharF.Text = "Left Crop n char"
        Me.rbLeftCropNCharF.UseVisualStyleBackColor = True
        '
        'rbInsertBeforeF
        '
        Me.rbInsertBeforeF.AutoSize = True
        Me.rbInsertBeforeF.Location = New System.Drawing.Point(6, 66)
        Me.rbInsertBeforeF.Name = "rbInsertBeforeF"
        Me.rbInsertBeforeF.Size = New System.Drawing.Size(127, 24)
        Me.rbInsertBeforeF.TabIndex = 2
        Me.rbInsertBeforeF.Text = "Insert Before"
        Me.rbInsertBeforeF.UseVisualStyleBackColor = True
        '
        'rbReplaceThisF
        '
        Me.rbReplaceThisF.AutoSize = True
        Me.rbReplaceThisF.Location = New System.Drawing.Point(6, 36)
        Me.rbReplaceThisF.Name = "rbReplaceThisF"
        Me.rbReplaceThisF.Size = New System.Drawing.Size(126, 24)
        Me.rbReplaceThisF.TabIndex = 1
        Me.rbReplaceThisF.Text = "Replace This"
        Me.rbReplaceThisF.UseVisualStyleBackColor = True
        '
        'rbReplaceWithF
        '
        Me.rbReplaceWithF.AutoSize = True
        Me.rbReplaceWithF.Checked = True
        Me.rbReplaceWithF.Location = New System.Drawing.Point(6, 6)
        Me.rbReplaceWithF.Name = "rbReplaceWithF"
        Me.rbReplaceWithF.Size = New System.Drawing.Size(129, 24)
        Me.rbReplaceWithF.TabIndex = 0
        Me.rbReplaceWithF.TabStop = True
        Me.rbReplaceWithF.Text = "Replace With"
        Me.rbReplaceWithF.UseVisualStyleBackColor = True
        '
        'tpExtension
        '
        Me.tpExtension.Controls.Add(Me.txtLeftCropNCharE)
        Me.tpExtension.Controls.Add(Me.txtRightCropNCharE)
        Me.tpExtension.Controls.Add(Me.rbRightCropNCharE)
        Me.tpExtension.Controls.Add(Me.txtInsertBeforeE)
        Me.tpExtension.Controls.Add(Me.txtInsertAfterE)
        Me.tpExtension.Controls.Add(Me.rbInsertAfterE)
        Me.tpExtension.Controls.Add(Me.txtWithThisE)
        Me.tpExtension.Controls.Add(Me.txtReplaceThisE)
        Me.tpExtension.Controls.Add(Me.lblWithThisE)
        Me.tpExtension.Controls.Add(Me.txtReplaceWithE)
        Me.tpExtension.Controls.Add(Me.lblCaseE)
        Me.tpExtension.Controls.Add(Me.cbCaseE)
        Me.tpExtension.Controls.Add(Me.rbLeftCropNCharE)
        Me.tpExtension.Controls.Add(Me.rbInsertBeforeE)
        Me.tpExtension.Controls.Add(Me.rbReplaceThisE)
        Me.tpExtension.Controls.Add(Me.rbReplaceWithE)
        Me.tpExtension.Location = New System.Drawing.Point(4, 29)
        Me.tpExtension.Name = "tpExtension"
        Me.tpExtension.Padding = New System.Windows.Forms.Padding(3)
        Me.tpExtension.Size = New System.Drawing.Size(683, 139)
        Me.tpExtension.TabIndex = 1
        Me.tpExtension.Text = "Extension"
        Me.tpExtension.UseVisualStyleBackColor = True
        '
        'tpAutoNumber
        '
        Me.tpAutoNumber.Controls.Add(Me.gbWith)
        Me.tpAutoNumber.Controls.Add(Me.gbPlace)
        Me.tpAutoNumber.Location = New System.Drawing.Point(4, 29)
        Me.tpAutoNumber.Name = "tpAutoNumber"
        Me.tpAutoNumber.Size = New System.Drawing.Size(683, 139)
        Me.tpAutoNumber.TabIndex = 2
        Me.tpAutoNumber.Text = "Autonumber"
        Me.tpAutoNumber.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(706, 294)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(82, 29)
        Me.btnPreview.TabIndex = 10
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnRename
        '
        Me.btnRename.Location = New System.Drawing.Point(706, 329)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(82, 29)
        Me.btnRename.TabIndex = 11
        Me.btnRename.Text = "Rename"
        Me.btnRename.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(706, 364)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(82, 28)
        Me.btnUndo.TabIndex = 12
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'txtLeftCropNCharE
        '
        Me.txtLeftCropNCharE.Location = New System.Drawing.Point(160, 103)
        Me.txtLeftCropNCharE.Name = "txtLeftCropNCharE"
        Me.txtLeftCropNCharE.ReadOnly = True
        Me.txtLeftCropNCharE.Size = New System.Drawing.Size(116, 26)
        Me.txtLeftCropNCharE.TabIndex = 31
        '
        'txtRightCropNCharE
        '
        Me.txtRightCropNCharE.Location = New System.Drawing.Point(550, 103)
        Me.txtRightCropNCharE.Name = "txtRightCropNCharE"
        Me.txtRightCropNCharE.ReadOnly = True
        Me.txtRightCropNCharE.Size = New System.Drawing.Size(127, 26)
        Me.txtRightCropNCharE.TabIndex = 30
        '
        'rbRightCropNCharE
        '
        Me.rbRightCropNCharE.AutoSize = True
        Me.rbRightCropNCharE.Location = New System.Drawing.Point(386, 105)
        Me.rbRightCropNCharE.Name = "rbRightCropNCharE"
        Me.rbRightCropNCharE.Size = New System.Drawing.Size(158, 24)
        Me.rbRightCropNCharE.TabIndex = 29
        Me.rbRightCropNCharE.Text = "Right Crop n char"
        Me.rbRightCropNCharE.UseVisualStyleBackColor = True
        '
        'txtInsertBeforeE
        '
        Me.txtInsertBeforeE.Location = New System.Drawing.Point(139, 73)
        Me.txtInsertBeforeE.Name = "txtInsertBeforeE"
        Me.txtInsertBeforeE.ReadOnly = True
        Me.txtInsertBeforeE.Size = New System.Drawing.Size(291, 26)
        Me.txtInsertBeforeE.TabIndex = 28
        '
        'txtInsertAfterE
        '
        Me.txtInsertAfterE.Location = New System.Drawing.Point(550, 73)
        Me.txtInsertAfterE.Name = "txtInsertAfterE"
        Me.txtInsertAfterE.ReadOnly = True
        Me.txtInsertAfterE.Size = New System.Drawing.Size(127, 26)
        Me.txtInsertAfterE.TabIndex = 27
        '
        'rbInsertAfterE
        '
        Me.rbInsertAfterE.AutoSize = True
        Me.rbInsertAfterE.Location = New System.Drawing.Point(436, 73)
        Me.rbInsertAfterE.Name = "rbInsertAfterE"
        Me.rbInsertAfterE.Size = New System.Drawing.Size(114, 24)
        Me.rbInsertAfterE.TabIndex = 26
        Me.rbInsertAfterE.Text = "Insert After"
        Me.rbInsertAfterE.UseVisualStyleBackColor = True
        '
        'txtWithThisE
        '
        Me.txtWithThisE.Location = New System.Drawing.Point(550, 41)
        Me.txtWithThisE.Name = "txtWithThisE"
        Me.txtWithThisE.ReadOnly = True
        Me.txtWithThisE.Size = New System.Drawing.Size(127, 26)
        Me.txtWithThisE.TabIndex = 25
        '
        'txtReplaceThisE
        '
        Me.txtReplaceThisE.Location = New System.Drawing.Point(141, 41)
        Me.txtReplaceThisE.Name = "txtReplaceThisE"
        Me.txtReplaceThisE.ReadOnly = True
        Me.txtReplaceThisE.Size = New System.Drawing.Size(319, 26)
        Me.txtReplaceThisE.TabIndex = 24
        '
        'lblWithThisE
        '
        Me.lblWithThisE.AutoSize = True
        Me.lblWithThisE.Location = New System.Drawing.Point(466, 41)
        Me.lblWithThisE.Name = "lblWithThisE"
        Me.lblWithThisE.Size = New System.Drawing.Size(78, 20)
        Me.lblWithThisE.TabIndex = 23
        Me.lblWithThisE.Text = "With This:"
        '
        'txtReplaceWithE
        '
        Me.txtReplaceWithE.Location = New System.Drawing.Point(141, 9)
        Me.txtReplaceWithE.Name = "txtReplaceWithE"
        Me.txtReplaceWithE.ReadOnly = True
        Me.txtReplaceWithE.Size = New System.Drawing.Size(353, 26)
        Me.txtReplaceWithE.TabIndex = 22
        '
        'lblCaseE
        '
        Me.lblCaseE.AutoSize = True
        Me.lblCaseE.Location = New System.Drawing.Point(500, 12)
        Me.lblCaseE.Name = "lblCaseE"
        Me.lblCaseE.Size = New System.Drawing.Size(50, 20)
        Me.lblCaseE.TabIndex = 21
        Me.lblCaseE.Text = "Case:"
        '
        'cbCaseE
        '
        Me.cbCaseE.FormattingEnabled = True
        Me.cbCaseE.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        Me.cbCaseE.Location = New System.Drawing.Point(556, 9)
        Me.cbCaseE.Name = "cbCaseE"
        Me.cbCaseE.Size = New System.Drawing.Size(121, 28)
        Me.cbCaseE.TabIndex = 20
        '
        'rbLeftCropNCharE
        '
        Me.rbLeftCropNCharE.AutoSize = True
        Me.rbLeftCropNCharE.Location = New System.Drawing.Point(6, 99)
        Me.rbLeftCropNCharE.Name = "rbLeftCropNCharE"
        Me.rbLeftCropNCharE.Size = New System.Drawing.Size(148, 24)
        Me.rbLeftCropNCharE.TabIndex = 19
        Me.rbLeftCropNCharE.Text = "Left Crop n char"
        Me.rbLeftCropNCharE.UseVisualStyleBackColor = True
        '
        'rbInsertBeforeE
        '
        Me.rbInsertBeforeE.AutoSize = True
        Me.rbInsertBeforeE.Location = New System.Drawing.Point(6, 69)
        Me.rbInsertBeforeE.Name = "rbInsertBeforeE"
        Me.rbInsertBeforeE.Size = New System.Drawing.Size(127, 24)
        Me.rbInsertBeforeE.TabIndex = 18
        Me.rbInsertBeforeE.Text = "Insert Before"
        Me.rbInsertBeforeE.UseVisualStyleBackColor = True
        '
        'rbReplaceThisE
        '
        Me.rbReplaceThisE.AutoSize = True
        Me.rbReplaceThisE.Location = New System.Drawing.Point(6, 39)
        Me.rbReplaceThisE.Name = "rbReplaceThisE"
        Me.rbReplaceThisE.Size = New System.Drawing.Size(126, 24)
        Me.rbReplaceThisE.TabIndex = 17
        Me.rbReplaceThisE.Text = "Replace This"
        Me.rbReplaceThisE.UseVisualStyleBackColor = True
        '
        'rbReplaceWithE
        '
        Me.rbReplaceWithE.AutoSize = True
        Me.rbReplaceWithE.Checked = True
        Me.rbReplaceWithE.Location = New System.Drawing.Point(6, 9)
        Me.rbReplaceWithE.Name = "rbReplaceWithE"
        Me.rbReplaceWithE.Size = New System.Drawing.Size(129, 24)
        Me.rbReplaceWithE.TabIndex = 16
        Me.rbReplaceWithE.TabStop = True
        Me.rbReplaceWithE.Text = "Replace With"
        Me.rbReplaceWithE.UseVisualStyleBackColor = True
        '
        'gbPlace
        '
        Me.gbPlace.Controls.Add(Me.rbBeforeFileName)
        Me.gbPlace.Controls.Add(Me.rbAfterFileName)
        Me.gbPlace.Location = New System.Drawing.Point(3, 3)
        Me.gbPlace.Name = "gbPlace"
        Me.gbPlace.Size = New System.Drawing.Size(200, 133)
        Me.gbPlace.TabIndex = 0
        Me.gbPlace.TabStop = False
        Me.gbPlace.Text = "Place:"
        '
        'gbWith
        '
        Me.gbWith.Controls.Add(Me.nudIncrementBy)
        Me.gbWith.Controls.Add(Me.nudStartWithNumber)
        Me.gbWith.Controls.Add(Me.lblIncrementBy)
        Me.gbWith.Controls.Add(Me.lblStartWithNumber)
        Me.gbWith.Location = New System.Drawing.Point(209, 3)
        Me.gbWith.Name = "gbWith"
        Me.gbWith.Size = New System.Drawing.Size(471, 133)
        Me.gbWith.TabIndex = 1
        Me.gbWith.TabStop = False
        Me.gbWith.Text = "With:"
        '
        'rbAfterFileName
        '
        Me.rbAfterFileName.AutoSize = True
        Me.rbAfterFileName.Location = New System.Drawing.Point(6, 25)
        Me.rbAfterFileName.Name = "rbAfterFileName"
        Me.rbAfterFileName.Size = New System.Drawing.Size(133, 24)
        Me.rbAfterFileName.TabIndex = 0
        Me.rbAfterFileName.TabStop = True
        Me.rbAfterFileName.Text = "After filename"
        Me.rbAfterFileName.UseVisualStyleBackColor = True
        '
        'rbBeforeFileName
        '
        Me.rbBeforeFileName.AutoSize = True
        Me.rbBeforeFileName.Location = New System.Drawing.Point(6, 55)
        Me.rbBeforeFileName.Name = "rbBeforeFileName"
        Me.rbBeforeFileName.Size = New System.Drawing.Size(146, 24)
        Me.rbBeforeFileName.TabIndex = 1
        Me.rbBeforeFileName.TabStop = True
        Me.rbBeforeFileName.Text = "Before filename"
        Me.rbBeforeFileName.UseVisualStyleBackColor = True
        '
        'lblStartWithNumber
        '
        Me.lblStartWithNumber.AutoSize = True
        Me.lblStartWithNumber.Location = New System.Drawing.Point(6, 22)
        Me.lblStartWithNumber.Name = "lblStartWithNumber"
        Me.lblStartWithNumber.Size = New System.Drawing.Size(144, 20)
        Me.lblStartWithNumber.TabIndex = 1
        Me.lblStartWithNumber.Text = "Start With Number:"
        '
        'lblIncrementBy
        '
        Me.lblIncrementBy.AutoSize = True
        Me.lblIncrementBy.Location = New System.Drawing.Point(6, 54)
        Me.lblIncrementBy.Name = "lblIncrementBy"
        Me.lblIncrementBy.Size = New System.Drawing.Size(107, 20)
        Me.lblIncrementBy.TabIndex = 3
        Me.lblIncrementBy.Text = "Increment By:"
        '
        'nudStartWithNumber
        '
        Me.nudStartWithNumber.Location = New System.Drawing.Point(157, 20)
        Me.nudStartWithNumber.Name = "nudStartWithNumber"
        Me.nudStartWithNumber.Size = New System.Drawing.Size(120, 26)
        Me.nudStartWithNumber.TabIndex = 4
        Me.nudStartWithNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudIncrementBy
        '
        Me.nudIncrementBy.Location = New System.Drawing.Point(157, 52)
        Me.nudIncrementBy.Name = "nudIncrementBy"
        Me.nudIncrementBy.Size = New System.Drawing.Size(120, 26)
        Me.nudIncrementBy.TabIndex = 5
        Me.nudIncrementBy.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 478)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.lvOri)
        Me.Controls.Add(Me.lblOri)
        Me.Controls.Add(Me.txtExt)
        Me.Controls.Add(Me.lblExt)
        Me.Controls.Add(Me.btnPath)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.lblPath)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mass Renamer"
        Me.TabControl1.ResumeLayout(False)
        Me.tpFileName.ResumeLayout(False)
        Me.tpFileName.PerformLayout()
        Me.tpExtension.ResumeLayout(False)
        Me.tpExtension.PerformLayout()
        Me.tpAutoNumber.ResumeLayout(False)
        Me.gbPlace.ResumeLayout(False)
        Me.gbPlace.PerformLayout()
        Me.gbWith.ResumeLayout(False)
        Me.gbWith.PerformLayout()
        CType(Me.nudStartWithNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIncrementBy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPath As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnPath As Button
    Friend WithEvents lblExt As Label
    Friend WithEvents txtExt As TextBox
    Friend WithEvents lblOri As Label
    Friend WithEvents lvOri As ListView
    Friend WithEvents ListView2 As ListView
    Friend WithEvents lblPreview As Label
    Friend WithEvents chFileName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chAttribute As ColumnHeader
    Friend WithEvents chCreated As ColumnHeader
    Friend WithEvents chAccessed As ColumnHeader
    Friend WithEvents chModified As ColumnHeader
    Friend WithEvents chFileName2 As ColumnHeader
    Friend WithEvents chExtension2 As ColumnHeader
    Friend WithEvents chAttribute2 As ColumnHeader
    Friend WithEvents chCreated2 As ColumnHeader
    Friend WithEvents chAccessed2 As ColumnHeader
    Friend WithEvents chModified2 As ColumnHeader
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpFileName As TabPage
    Friend WithEvents tpExtension As TabPage
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnRename As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents rbLeftCropNCharF As RadioButton
    Friend WithEvents rbInsertBeforeF As RadioButton
    Friend WithEvents rbReplaceThisF As RadioButton
    Friend WithEvents rbReplaceWithF As RadioButton
    Friend WithEvents tpAutoNumber As TabPage
    Friend WithEvents lblCaseF As Label
    Friend WithEvents cbCaseF As ComboBox
    Friend WithEvents txtLeftCropNCharF As TextBox
    Friend WithEvents txtRightCropNCharF As TextBox
    Friend WithEvents rbRightCropNCharF As RadioButton
    Friend WithEvents txtInsertBeforeF As TextBox
    Friend WithEvents txtInsertAfterF As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents txtWithThisF As TextBox
    Friend WithEvents txtReplaceThisF As TextBox
    Friend WithEvents lblWithThisF As Label
    Friend WithEvents txtReplaceWithF As TextBox
    Friend WithEvents txtLeftCropNCharE As TextBox
    Friend WithEvents txtRightCropNCharE As TextBox
    Friend WithEvents rbRightCropNCharE As RadioButton
    Friend WithEvents txtInsertBeforeE As TextBox
    Friend WithEvents txtInsertAfterE As TextBox
    Friend WithEvents rbInsertAfterE As RadioButton
    Friend WithEvents txtWithThisE As TextBox
    Friend WithEvents txtReplaceThisE As TextBox
    Friend WithEvents lblWithThisE As Label
    Friend WithEvents txtReplaceWithE As TextBox
    Friend WithEvents lblCaseE As Label
    Friend WithEvents cbCaseE As ComboBox
    Friend WithEvents rbLeftCropNCharE As RadioButton
    Friend WithEvents rbInsertBeforeE As RadioButton
    Friend WithEvents rbReplaceThisE As RadioButton
    Friend WithEvents rbReplaceWithE As RadioButton
    Friend WithEvents gbWith As GroupBox
    Friend WithEvents gbPlace As GroupBox
    Friend WithEvents rbBeforeFileName As RadioButton
    Friend WithEvents rbAfterFileName As RadioButton
    Friend WithEvents lblStartWithNumber As Label
    Friend WithEvents lblIncrementBy As Label
    Friend WithEvents nudIncrementBy As NumericUpDown
    Friend WithEvents nudStartWithNumber As NumericUpDown
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
