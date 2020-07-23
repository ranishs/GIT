<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewOrder
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
        Me.grpInputBox = New System.Windows.Forms.GroupBox()
        Me.DTGRIDVIEW = New System.Windows.Forms.DataGridView()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.txtTotQTY = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtItemCount = New System.Windows.Forms.TextBox()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtExpectedDate = New System.Windows.Forms.TextBox()
        Me.txtBranchName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOrderDate = New System.Windows.Forms.TextBox()
        Me.txtOrderNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpButtons = New System.Windows.Forms.GroupBox()
        Me.cmdMoveNext = New System.Windows.Forms.Button()
        Me.cmdMovePrv = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.grpInputBox.SuspendLayout()
        CType(Me.DTGRIDVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInputBox
        '
        Me.grpInputBox.Controls.Add(Me.DTGRIDVIEW)
        Me.grpInputBox.Controls.Add(Me.lblStatus)
        Me.grpInputBox.Controls.Add(Me.txtTotalAmount)
        Me.grpInputBox.Controls.Add(Me.txtTotQTY)
        Me.grpInputBox.Controls.Add(Me.Label5)
        Me.grpInputBox.Controls.Add(Me.Label6)
        Me.grpInputBox.Controls.Add(Me.txtItemCount)
        Me.grpInputBox.Controls.Add(Me.txtComments)
        Me.grpInputBox.Controls.Add(Me.Label7)
        Me.grpInputBox.Controls.Add(Me.Label8)
        Me.grpInputBox.Controls.Add(Me.txtExpectedDate)
        Me.grpInputBox.Controls.Add(Me.txtBranchName)
        Me.grpInputBox.Controls.Add(Me.Label4)
        Me.grpInputBox.Controls.Add(Me.Label3)
        Me.grpInputBox.Controls.Add(Me.txtOrderDate)
        Me.grpInputBox.Controls.Add(Me.txtOrderNo)
        Me.grpInputBox.Controls.Add(Me.Label2)
        Me.grpInputBox.Controls.Add(Me.Label1)
        Me.grpInputBox.Enabled = False
        Me.grpInputBox.Location = New System.Drawing.Point(24, 12)
        Me.grpInputBox.Name = "grpInputBox"
        Me.grpInputBox.Size = New System.Drawing.Size(716, 400)
        Me.grpInputBox.TabIndex = 22
        Me.grpInputBox.TabStop = False
        '
        'DTGRIDVIEW
        '
        Me.DTGRIDVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGRIDVIEW.Location = New System.Drawing.Point(34, 164)
        Me.DTGRIDVIEW.Name = "DTGRIDVIEW"
        Me.DTGRIDVIEW.Size = New System.Drawing.Size(668, 230)
        Me.DTGRIDVIEW.TabIndex = 32
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(210, 136)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 31
        Me.lblStatus.Text = "Status"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Location = New System.Drawing.Point(480, 107)
        Me.txtTotalAmount.MaxLength = 15
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtTotalAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalAmount.TabIndex = 30
        '
        'txtTotQTY
        '
        Me.txtTotQTY.Location = New System.Drawing.Point(480, 76)
        Me.txtTotQTY.MaxLength = 15
        Me.txtTotQTY.Name = "txtTotQTY"
        Me.txtTotQTY.Size = New System.Drawing.Size(100, 20)
        Me.txtTotQTY.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(344, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Total Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(344, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Total Qty"
        '
        'txtItemCount
        '
        Me.txtItemCount.Location = New System.Drawing.Point(480, 41)
        Me.txtItemCount.MaxLength = 15
        Me.txtItemCount.Name = "txtItemCount"
        Me.txtItemCount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtItemCount.Size = New System.Drawing.Size(100, 20)
        Me.txtItemCount.TabIndex = 24
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(480, 10)
        Me.txtComments.MaxLength = 15
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(228, 20)
        Me.txtComments.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(344, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Item Count"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(344, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Comments"
        '
        'txtExpectedDate
        '
        Me.txtExpectedDate.Location = New System.Drawing.Point(167, 104)
        Me.txtExpectedDate.MaxLength = 15
        Me.txtExpectedDate.Name = "txtExpectedDate"
        Me.txtExpectedDate.Size = New System.Drawing.Size(100, 20)
        Me.txtExpectedDate.TabIndex = 22
        '
        'txtBranchName
        '
        Me.txtBranchName.Location = New System.Drawing.Point(167, 73)
        Me.txtBranchName.MaxLength = 15
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Size = New System.Drawing.Size(100, 20)
        Me.txtBranchName.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Expected Delivery Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Branch Name"
        '
        'txtOrderDate
        '
        Me.txtOrderDate.Location = New System.Drawing.Point(167, 38)
        Me.txtOrderDate.MaxLength = 15
        Me.txtOrderDate.Name = "txtOrderDate"
        Me.txtOrderDate.Size = New System.Drawing.Size(100, 20)
        Me.txtOrderDate.TabIndex = 14
        '
        'txtOrderNo
        '
        Me.txtOrderNo.Location = New System.Drawing.Point(167, 7)
        Me.txtOrderNo.MaxLength = 15
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.Size = New System.Drawing.Size(100, 20)
        Me.txtOrderNo.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Order Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Order No"
        '
        'grpButtons
        '
        Me.grpButtons.Controls.Add(Me.cmdMoveNext)
        Me.grpButtons.Controls.Add(Me.cmdMovePrv)
        Me.grpButtons.Controls.Add(Me.cmdExit)
        Me.grpButtons.Controls.Add(Me.cmdDelete)
        Me.grpButtons.Controls.Add(Me.cmdEdit)
        Me.grpButtons.Location = New System.Drawing.Point(218, 418)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(268, 34)
        Me.grpButtons.TabIndex = 21
        Me.grpButtons.TabStop = False
        '
        'cmdMoveNext
        '
        Me.cmdMoveNext.Location = New System.Drawing.Point(164, 6)
        Me.cmdMoveNext.Name = "cmdMoveNext"
        Me.cmdMoveNext.Size = New System.Drawing.Size(45, 23)
        Me.cmdMoveNext.TabIndex = 6
        Me.cmdMoveNext.Text = ">>>"
        Me.cmdMoveNext.UseVisualStyleBackColor = True
        '
        'cmdMovePrv
        '
        Me.cmdMovePrv.Location = New System.Drawing.Point(113, 6)
        Me.cmdMovePrv.Name = "cmdMovePrv"
        Me.cmdMovePrv.Size = New System.Drawing.Size(45, 23)
        Me.cmdMovePrv.TabIndex = 5
        Me.cmdMovePrv.Text = "<<<"
        Me.cmdMovePrv.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(215, 6)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(45, 23)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(57, 6)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(50, 23)
        Me.cmdDelete.TabIndex = 3
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(6, 6)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(45, 23)
        Me.cmdEdit.TabIndex = 2
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(274, 459)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 19
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        Me.cmdSave.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(351, 459)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 20
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.Visible = False
        '
        'frmViewOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 496)
        Me.Controls.Add(Me.grpInputBox)
        Me.Controls.Add(Me.grpButtons)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdCancel)
        Me.Name = "frmViewOrder"
        Me.Text = "frmViewOrder"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpInputBox.ResumeLayout(False)
        Me.grpInputBox.PerformLayout()
        CType(Me.DTGRIDVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpInputBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOrderDate As System.Windows.Forms.TextBox
    Friend WithEvents txtOrderNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpButtons As System.Windows.Forms.GroupBox
    Friend WithEvents cmdMoveNext As System.Windows.Forms.Button
    Friend WithEvents cmdMovePrv As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtTotQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtItemCount As System.Windows.Forms.TextBox
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtExpectedDate As System.Windows.Forms.TextBox
    Friend WithEvents txtBranchName As System.Windows.Forms.TextBox
    Friend WithEvents DTGRIDVIEW As System.Windows.Forms.DataGridView
End Class
