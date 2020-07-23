Public Class frmItemmaster

    Dim Mode As String
    Dim RsV As New ADODB.Recordset
    Dim sSaveType As String



    Private Sub cmdExit_Click(sender As System.Object, e As System.EventArgs) Handles cmdExit.Click
        Me.Hide()
    End Sub

    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click
        ClearBox()
        ButtonVisible(True)
        sSaveType = "A"
        txtItemCode.Focus()

    End Sub

    Private Sub ButtonVisible(Flag As Boolean)
        grpButtons.Visible = Not Flag
        grpInputBox.Enabled = Flag
        cmdSave.Enabled = Flag
        cmdCancel.Enabled = Flag
        cmdSave.Visible = Flag
        cmdCancel.Visible = Flag
    End Sub


    Private Sub ClearBox()
        txtItemCode.Clear()
        txtItmName.Clear()
        txtQOH.Clear()
        txtRate.Clear()

    End Sub



    Private Sub frmusrmaster_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        RsV = New ADODB.Recordset
        RsV.Open("Select * from ItemMaster order by ItemName ", cnLclCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

       
    End Sub

    Private Sub cmdEdit_Click(sender As System.Object, e As System.EventArgs) Handles cmdEdit.Click
        'ClearBox()
        ButtonVisible(True)
        txtItemCode.Enabled = False
        sSaveType = "E"
        txtItmName.Focus()

    End Sub

    Private Sub cmdDelete_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelete.Click
        MsgBox("Not Enabled", vbAbort, "Contact Admin")
    End Sub

    Private Sub cmdMovePrv_Click(sender As System.Object, e As System.EventArgs) Handles cmdMovePrv.Click
        RsV.MovePrevious()
        If RsV.BOF Then
            RsV.MoveFirst()
            MsgBox("First Record", vbInformation)
        End If

        DisplayFields()



    End Sub

    Private Sub cmdMoveNext_Click(sender As System.Object, e As System.EventArgs) Handles cmdMoveNext.Click
        RsV.MoveNext()
        If RsV.EOF Then
            RsV.MoveLast()
            MsgBox("Last Record", vbInformation)
        End If

        DisplayFields()

    End Sub
    Private Sub DisplayFields()


        txtItemCode.Text = RsV.Fields("Itemcode").Value
        txtItmName.Text = RsV.Fields("ItemName").Value
        txtQOH.Text = RsV.Fields("QOH").Value
        txtRate.Text = RsV.Fields("Rate").Value


    End Sub

    Private Sub cmbUserType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancel.Click
        ButtonVisible(False)
        txtItemCode.Enabled = True
        sSaveType = ""
    End Sub

    Private Sub cmdSave_Click(sender As System.Object, e As System.EventArgs) Handles cmdSave.Click

        Dim RsSaveUsr As New ADODB.Recordset
        RsSaveUsr.Open("Select * from ItemMaster where Itemcode  ='" & txtItemCode.Text & "'", cnLclCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

        If sSaveType = "A" Then
            RsSaveUsr.AddNew()

            RsSaveUsr.Fields("Itemcode").Value = txtItemCode.Text
            RsSaveUsr.Fields("ItemName").Value = txtItmName.Text
            RsSaveUsr.Fields("QOH").Value = txtQOH.Text
            RsSaveUsr.Fields("Rate").Value = txtRate.Text
            RsSaveUsr.Fields("sync").Value = 0
            RsSaveUsr.Update()
        End If


        If sSaveType = "E" Then
            If RsSaveUsr.EOF() Then
                MsgBox("User Not Found, So Adding New", vbInformation)
                RsSaveUsr.AddNew()
            End If

            RsSaveUsr.Fields("Itemcode").Value = txtItemCode.Text
            RsSaveUsr.Fields("ItemName").Value = txtItmName.Text
            RsSaveUsr.Fields("QOH").Value = txtQOH.Text
            RsSaveUsr.Fields("Rate").Value = txtRate.Text
            RsSaveUsr.Fields("sync").Value = 0

            RsSaveUsr.Update()
        End If
        ButtonVisible(False)
        txtItemCode.Enabled = True
        sSaveType = ""
    End Sub
End Class