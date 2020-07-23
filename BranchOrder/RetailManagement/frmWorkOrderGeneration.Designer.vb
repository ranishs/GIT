<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkOrderGeneration
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
        Me.grpButtons = New System.Windows.Forms.GroupBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdMoveNext = New System.Windows.Forms.Button()
        Me.cmdMovePrv = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdAllocate = New System.Windows.Forms.Button()
        Me.cmdView = New System.Windows.Forms.Button()
        Me.DTGRIDVIEW = New System.Windows.Forms.DataGridView()
        Me.rtbText = New System.Windows.Forms.RichTextBox()
        Me.grpButtons.SuspendLayout()
        CType(Me.DTGRIDVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpButtons
        '
        Me.grpButtons.Controls.Add(Me.cmdPrint)
        Me.grpButtons.Controls.Add(Me.cmdMoveNext)
        Me.grpButtons.Controls.Add(Me.cmdMovePrv)
        Me.grpButtons.Controls.Add(Me.cmdExit)
        Me.grpButtons.Controls.Add(Me.cmdAllocate)
        Me.grpButtons.Controls.Add(Me.cmdView)
        Me.grpButtons.Location = New System.Drawing.Point(132, 268)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(378, 34)
        Me.grpButtons.TabIndex = 24
        Me.grpButtons.TabStop = False
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(161, 5)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(58, 23)
        Me.cmdPrint.TabIndex = 7
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdMoveNext
        '
        Me.cmdMoveNext.Location = New System.Drawing.Point(276, 6)
        Me.cmdMoveNext.Name = "cmdMoveNext"
        Me.cmdMoveNext.Size = New System.Drawing.Size(45, 23)
        Me.cmdMoveNext.TabIndex = 6
        Me.cmdMoveNext.Text = ">>>"
        Me.cmdMoveNext.UseVisualStyleBackColor = True
        '
        'cmdMovePrv
        '
        Me.cmdMovePrv.Location = New System.Drawing.Point(225, 6)
        Me.cmdMovePrv.Name = "cmdMovePrv"
        Me.cmdMovePrv.Size = New System.Drawing.Size(45, 23)
        Me.cmdMovePrv.TabIndex = 5
        Me.cmdMovePrv.Text = "<<<"
        Me.cmdMovePrv.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(327, 6)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(45, 23)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdAllocate
        '
        Me.cmdAllocate.Enabled = False
        Me.cmdAllocate.Location = New System.Drawing.Point(91, 6)
        Me.cmdAllocate.Name = "cmdAllocate"
        Me.cmdAllocate.Size = New System.Drawing.Size(58, 23)
        Me.cmdAllocate.TabIndex = 3
        Me.cmdAllocate.Text = "&Allocate"
        Me.cmdAllocate.UseVisualStyleBackColor = True
        '
        'cmdView
        '
        Me.cmdView.Location = New System.Drawing.Point(6, 6)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(79, 23)
        Me.cmdView.TabIndex = 2
        Me.cmdView.Text = "Orders"
        Me.cmdView.UseVisualStyleBackColor = True
        '
        'DTGRIDVIEW
        '
        Me.DTGRIDVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGRIDVIEW.Location = New System.Drawing.Point(12, 32)
        Me.DTGRIDVIEW.Name = "DTGRIDVIEW"
        Me.DTGRIDVIEW.Size = New System.Drawing.Size(668, 230)
        Me.DTGRIDVIEW.TabIndex = 33
        '
        'rtbText
        '
        Me.rtbText.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbText.Location = New System.Drawing.Point(132, 308)
        Me.rtbText.Name = "rtbText"
        Me.rtbText.ReadOnly = True
        Me.rtbText.Size = New System.Drawing.Size(383, 139)
        Me.rtbText.TabIndex = 34
        Me.rtbText.Text = ""
        '
        'frmWorkOrderGeneration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 414)
        Me.Controls.Add(Me.rtbText)
        Me.Controls.Add(Me.DTGRIDVIEW)
        Me.Controls.Add(Me.grpButtons)
        Me.Name = "frmWorkOrderGeneration"
        Me.Text = "WorkOrder Generation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpButtons.ResumeLayout(False)
        CType(Me.DTGRIDVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpButtons As System.Windows.Forms.GroupBox
    Friend WithEvents cmdMoveNext As System.Windows.Forms.Button
    Friend WithEvents cmdMovePrv As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdAllocate As System.Windows.Forms.Button
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents DTGRIDVIEW As System.Windows.Forms.DataGridView
    Friend WithEvents rtbText As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
End Class
