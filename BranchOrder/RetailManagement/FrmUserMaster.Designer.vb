<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmusrmaster
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
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.grpButtons = New System.Windows.Forms.GroupBox()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.grpInputBox = New System.Windows.Forms.GroupBox()
        Me.cmbBranchName = New System.Windows.Forms.ComboBox()
        Me.cmbUserType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdMoveNext = New System.Windows.Forms.Button()
        Me.cmdMovePrv = New System.Windows.Forms.Button()
        Me.grpButtons.SuspendLayout()
        Me.grpInputBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(299, 187)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 10
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(222, 187)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 9
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        Me.cmdSave.Visible = False
        '
        'grpButtons
        '
        Me.grpButtons.Controls.Add(Me.cmdMoveNext)
        Me.grpButtons.Controls.Add(Me.cmdMovePrv)
        Me.grpButtons.Controls.Add(Me.cmdExit)
        Me.grpButtons.Controls.Add(Me.cmdDelete)
        Me.grpButtons.Controls.Add(Me.cmdEdit)
        Me.grpButtons.Controls.Add(Me.cmdAdd)
        Me.grpButtons.Location = New System.Drawing.Point(157, 146)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(296, 34)
        Me.grpButtons.TabIndex = 17
        Me.grpButtons.TabStop = False
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(248, 5)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(45, 23)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(98, 5)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(50, 23)
        Me.cmdDelete.TabIndex = 3
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(50, 5)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(45, 23)
        Me.cmdEdit.TabIndex = 2
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(3, 5)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(45, 23)
        Me.cmdAdd.TabIndex = 1
        Me.cmdAdd.Text = "&Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'grpInputBox
        '
        Me.grpInputBox.Controls.Add(Me.cmbBranchName)
        Me.grpInputBox.Controls.Add(Me.cmbUserType)
        Me.grpInputBox.Controls.Add(Me.Label4)
        Me.grpInputBox.Controls.Add(Me.Label3)
        Me.grpInputBox.Controls.Add(Me.txtPassword)
        Me.grpInputBox.Controls.Add(Me.txtUser)
        Me.grpInputBox.Controls.Add(Me.Label2)
        Me.grpInputBox.Controls.Add(Me.Label1)
        Me.grpInputBox.Enabled = False
        Me.grpInputBox.Location = New System.Drawing.Point(184, 13)
        Me.grpInputBox.Name = "grpInputBox"
        Me.grpInputBox.Size = New System.Drawing.Size(233, 133)
        Me.grpInputBox.TabIndex = 18
        Me.grpInputBox.TabStop = False
        '
        'cmbBranchName
        '
        Me.cmbBranchName.FormattingEnabled = True
        Me.cmbBranchName.Location = New System.Drawing.Point(102, 107)
        Me.cmbBranchName.Name = "cmbBranchName"
        Me.cmbBranchName.Size = New System.Drawing.Size(100, 21)
        Me.cmbBranchName.Sorted = True
        Me.cmbBranchName.TabIndex = 17
        '
        'cmbUserType
        '
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Items.AddRange(New Object() {"Admin", "BranchCashier", "FactoryUser"})
        Me.cmbUserType.Location = New System.Drawing.Point(102, 76)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(100, 21)
        Me.cmbUserType.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "BranchName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "UserType"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(102, 42)
        Me.txtPassword.MaxLength = 15
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 14
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(102, 11)
        Me.txtUser.MaxLength = 15
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 20)
        Me.txtUser.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "User ID"
        '
        'cmdMoveNext
        '
        Me.cmdMoveNext.Location = New System.Drawing.Point(198, 6)
        Me.cmdMoveNext.Name = "cmdMoveNext"
        Me.cmdMoveNext.Size = New System.Drawing.Size(45, 23)
        Me.cmdMoveNext.TabIndex = 6
        Me.cmdMoveNext.Text = ">>>"
        Me.cmdMoveNext.UseVisualStyleBackColor = True
        '
        'cmdMovePrv
        '
        Me.cmdMovePrv.Location = New System.Drawing.Point(151, 6)
        Me.cmdMovePrv.Name = "cmdMovePrv"
        Me.cmdMovePrv.Size = New System.Drawing.Size(45, 23)
        Me.cmdMovePrv.TabIndex = 5
        Me.cmdMovePrv.Text = "<<<"
        Me.cmdMovePrv.UseVisualStyleBackColor = True
        '
        'frmusrmaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 231)
        Me.Controls.Add(Me.grpInputBox)
        Me.Controls.Add(Me.grpButtons)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdCancel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmusrmaster"
        Me.Text = "User Master"
        Me.grpButtons.ResumeLayout(False)
        Me.grpInputBox.ResumeLayout(False)
        Me.grpInputBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents grpButtons As System.Windows.Forms.GroupBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents grpInputBox As System.Windows.Forms.GroupBox
    Friend WithEvents cmbBranchName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbUserType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdMoveNext As System.Windows.Forms.Button
    Friend WithEvents cmdMovePrv As System.Windows.Forms.Button
End Class
