Public Class frmusrmaster

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
        txtUser.Focus()

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
        txtUser.Clear()
        txtPassword.Clear()
        cmbBranchName.SelectedIndex = 0
        cmbUserType.SelectedIndex = 0
    End Sub



    Private Sub frmusrmaster_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        RsV = New ADODB.Recordset
        RsV.Open("Select * from UserMas order by UserName ", cnLclCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

        Dim RsBranch As New ADODB.Recordset
    
        RsBranch.Open("Select * from BranchMas", cnLclCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        cmbBranchName.Items.Clear()
        cmbBranchName.DisplayMember = "Text"
        cmbBranchName.ValueMember = "Value"
        Do While RsBranch.EOF = False
            cmbBranchName.Items.Add(New With {.Text = RsBranch.Fields("BranchName").Value, .Value = RsBranch.Fields("BranchID").Value})
            RsBranch.MoveNext()
        Loop
    End Sub

    Private Sub cmdEdit_Click(sender As System.Object, e As System.EventArgs) Handles cmdEdit.Click
        'ClearBox()
        ButtonVisible(True)
        txtUser.Enabled = False
        sSaveType = "E"
        txtPassword.Focus()

    End Sub

    Private Sub cmdDelete_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelete.Click
        MsgBox("Not Enabled", vbCritical, "Contact Admin")
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
        Dim Idx As Integer

        txtUser.Text = RsV.Fields("UserName").Value
        txtPassword.Text = RsV.Fields("Password").Value

        idx = -1
        For Each Items In cmbUserType.Items
            Idx = Idx + 1
            If Items.ToString.Substring(0, 2) = RsV.Fields("UserType").Value Then
                cmbUserType.SelectedIndex = Idx
                Exit For
            End If
        Next
        Idx = -1
        For Each Items In cmbBranchName.Items
            Idx = Idx + 1
            If Items.Value.ToString = RsV.Fields("BranchId").Value.ToString Then
                cmbBranchName.Text = GetBranchName(RsV.Fields("BranchId").Value)
                cmbBranchName.SelectedIndex = Idx
                Exit For
            End If
        Next



    End Sub

    Private Sub cmbUserType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbUserType.SelectedIndexChanged

    End Sub

    Private Sub cmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancel.Click
        ButtonVisible(False)
        txtUser.Enabled = True
        sSaveType = ""
    End Sub

    Private Sub cmdSave_Click(sender As System.Object, e As System.EventArgs) Handles cmdSave.Click

        Dim RsSaveUsr As New ADODB.Recordset
        RsSaveUsr.Open("Select * from UserMas where username ='" & txtUser.Text & "'", cnLclCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

        If sSaveType = "A" Then
            RsSaveUsr.AddNew()

            RsSaveUsr.Fields("UserName").Value = txtUser.Text
            RsSaveUsr.Fields("Password").Value = txtPassword.Text
            RsSaveUsr.Fields("UserType").Value = cmbUserType.SelectedItem.ToString.Substring(0, 2)
            RsSaveUsr.Fields("BranchId").Value = cmbBranchName.SelectedItem.value.ToString
            RsSaveUsr.Fields("sync").Value = 0
            RsSaveUsr.Update()
        End If


        If sSaveType = "E" Then
            If RsSaveUsr.EOF() Then
                MsgBox("User Not Found, So Adding New", vbInformation)
                RsSaveUsr.AddNew()
            End If

            RsSaveUsr.Fields("UserName").Value = txtUser.Text
            RsSaveUsr.Fields("Password").Value = txtPassword.Text
            RsSaveUsr.Fields("UserType").Value = cmbUserType.SelectedItem.ToString.Substring(0, 2)
            RsSaveUsr.Fields("BranchId").Value = cmbBranchName.SelectedItem.value.ToString
            RsSaveUsr.Fields("sync").Value = 0
            RsSaveUsr.Update()
        End If
        ButtonVisible(False)
        txtUser.Enabled = True
        sSaveType = ""
    End Sub
End Class