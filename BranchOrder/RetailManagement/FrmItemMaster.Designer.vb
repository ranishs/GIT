<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemmaster
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
        Me.cmdMoveNext = New System.Windows.Forms.Button()
        Me.cmdMovePrv = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.grpInputBox = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtItmName = New System.Windows.Forms.TextBox()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtQOH = New System.Windows.Forms.TextBox()
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
        Me.grpInputBox.Controls.Add(Me.txtRate)
        Me.grpInputBox.Controls.Add(Me.txtQOH)
        Me.grpInputBox.Controls.Add(Me.Label4)
        Me.grpInputBox.Controls.Add(Me.Label3)
        Me.grpInputBox.Controls.Add(Me.txtItmName)
        Me.grpInputBox.Controls.Add(Me.txtItemCode)
        Me.grpInputBox.Controls.Add(Me.Label2)
        Me.grpInputBox.Controls.Add(Me.Label1)
        Me.grpInputBox.Enabled = False
        Me.grpInputBox.Location = New System.Drawing.Point(157, 13)
        Me.grpInputBox.Name = "grpInputBox"
        Me.grpInputBox.Size = New System.Drawing.Size(290, 133)
        Me.grpInputBox.TabIndex = 18
        Me.grpInputBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Rate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "QOH"
        '
        'txtItmName
        '
        Me.txtItmName.Location = New System.Drawing.Point(65, 42)
        Me.txtItmName.MaxLength = 15
        Me.txtItmName.Name = "txtItmName"
        Me.txtItmName.Size = New System.Drawing.Size(219, 20)
        Me.txtItmName.TabIndex = 14
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(65, 11)
        Me.txtItemCode.MaxLength = 15
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(219, 20)
        Me.txtItemCode.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "ItemName"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Itemcode"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(65, 98)
        Me.txtRate.MaxLength = 15
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(219, 20)
        Me.txtRate.TabIndex = 22
        '
        'txtQOH
        '
        Me.txtQOH.Location = New System.Drawing.Point(65, 69)
        Me.txtQOH.MaxLength = 15
        Me.txtQOH.Name = "txtQOH"
        Me.txtQOH.Size = New System.Drawing.Size(219, 20)
        Me.txtQOH.TabIndex = 21
        '
        'frmItemmaster
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
        Me.Name = "frmItemmaster"
        Me.Text = "ItemMaster"
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtItmName As System.Windows.Forms.TextBox
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdMoveNext As System.Windows.Forms.Button
    Friend WithEvents cmdMovePrv As System.Windows.Forms.Button
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtQOH As System.Windows.Forms.TextBox
End Class
