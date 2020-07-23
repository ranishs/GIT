Public Class FrmMain

    Private Sub FrmMain_Disposed(sender As Object, e As System.EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub FrmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub



    Private Sub UserMasterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UserMasterToolStripMenuItem.Click
        frmusrmaster.ShowDialog(Me)
    End Sub

    Private Sub BranchMasterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BranchMasterToolStripMenuItem.Click
        Dim S As String
        S = InputBox("Enter The Branch Name", "New Branch")
        If S.Trim <> "" Then
            S = " INSERT INTO [dbo].[BranchMas]   ([BranchName])  VALUES   ('" & S & "')"
            cnLclCon.Execute(S)
            MsgBox("Branch Added")
        Else
            MsgBox("No Input and Branch is not added")
        End If
    End Sub

    Private Sub RetriveOrderToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RetriveOrderToolStripMenuItem.Click
        frmSyncData.ShowDialog()
    End Sub


    Private Sub YesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles YesToolStripMenuItem.Click
        End
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ItemMasterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ItemMasterToolStripMenuItem.Click
        frmItemmaster.ShowDialog()
    End Sub

    Private Sub ViewOrderDetailsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewOrderDetailsToolStripMenuItem.Click
        frmViewOrder.ShowDialog()

    End Sub

    Private Sub OrderMovementToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OrderMovementToolStripMenuItem.Click
        frmWorkOrderGeneration.ShowDialog()

    End Sub
End Class