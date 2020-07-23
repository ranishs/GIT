<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BranchMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetriveOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewOrderDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderMovementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.OrderInfoToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(754, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserMasterToolStripMenuItem, Me.BranchMasterToolStripMenuItem, Me.ItemMasterToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(55, 20)
        Me.ToolStripMenuItem1.Text = "Master"
        '
        'UserMasterToolStripMenuItem
        '
        Me.UserMasterToolStripMenuItem.Name = "UserMasterToolStripMenuItem"
        Me.UserMasterToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.UserMasterToolStripMenuItem.Text = "UserMaster"
        '
        'BranchMasterToolStripMenuItem
        '
        Me.BranchMasterToolStripMenuItem.Name = "BranchMasterToolStripMenuItem"
        Me.BranchMasterToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.BranchMasterToolStripMenuItem.Text = "BranchMaster"
        '
        'ItemMasterToolStripMenuItem
        '
        Me.ItemMasterToolStripMenuItem.Name = "ItemMasterToolStripMenuItem"
        Me.ItemMasterToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ItemMasterToolStripMenuItem.Text = "ItemMaster"
        '
        'OrderInfoToolStripMenuItem
        '
        Me.OrderInfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RetriveOrderToolStripMenuItem, Me.ViewOrderDetailsToolStripMenuItem, Me.OrderMovementToolStripMenuItem})
        Me.OrderInfoToolStripMenuItem.Name = "OrderInfoToolStripMenuItem"
        Me.OrderInfoToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.OrderInfoToolStripMenuItem.Text = "OrderInfo"
        '
        'RetriveOrderToolStripMenuItem
        '
        Me.RetriveOrderToolStripMenuItem.Name = "RetriveOrderToolStripMenuItem"
        Me.RetriveOrderToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.RetriveOrderToolStripMenuItem.Text = "Retrive Order"
        '
        'ViewOrderDetailsToolStripMenuItem
        '
        Me.ViewOrderDetailsToolStripMenuItem.Name = "ViewOrderDetailsToolStripMenuItem"
        Me.ViewOrderDetailsToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ViewOrderDetailsToolStripMenuItem.Text = "View Order Details"
        '
        'OrderMovementToolStripMenuItem
        '
        Me.OrderMovementToolStripMenuItem.Name = "OrderMovementToolStripMenuItem"
        Me.OrderMovementToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.OrderMovementToolStripMenuItem.Text = "Order Movement"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YesToolStripMenuItem, Me.NoToolStripMenuItem})
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'YesToolStripMenuItem
        '
        Me.YesToolStripMenuItem.Name = "YesToolStripMenuItem"
        Me.YesToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.YesToolStripMenuItem.Text = "Yes"
        '
        'NoToolStripMenuItem
        '
        Me.NoToolStripMenuItem.Name = "NoToolStripMenuItem"
        Me.NoToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.NoToolStripMenuItem.Text = "No"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 439)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BranchMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RetriveOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewOrderDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderMovementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
