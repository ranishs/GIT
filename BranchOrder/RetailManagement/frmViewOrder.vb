Public Class frmViewOrder
    Dim Rsv As New ADODB.Recordset
    Dim sSaveType As String

    Private Sub frmViewOrder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Rsv = New ADODB.Recordset
        Rsv.Open(" Select * from OrderMaster", cnLclCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        SetGrid()
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
        txtOrderNo.Clear()
        txtOrderDate.Clear()
        txtBranchName.Clear()
        txtExpectedDate.Clear()
        txtComments.Clear()
        txtItemCount.Clear()
        txtTotQTY.Clear()
        txtTotalAmount.Clear()
        lblStatus.Text = "Status "
    End Sub

    Private Sub SetGrid()
        DTGRIDVIEW.Rows.Clear()
        DTGRIDVIEW.Columns.Add("Sno", "Sno")
        DTGRIDVIEW.Columns.Add("Code", "Code")
        DTGRIDVIEW.Columns.Add("Name", "Name")
        DTGRIDVIEW.Columns.Add("QOH", "QOH")
        DTGRIDVIEW.Columns.Add("Qty", "Qty")
        DTGRIDVIEW.Columns.Add("Rate", "Rate")
        DTGRIDVIEW.Columns.Add("Amount", "Amount")

        DTGRIDVIEW.Columns.Item(0).Width = 50
        DTGRIDVIEW.Columns.Item(1).Width = 50
        DTGRIDVIEW.Columns.Item(2).Width = 150
        DTGRIDVIEW.Columns.Item(3).Width = 50
        DTGRIDVIEW.Columns.Item(4).Width = 50
        DTGRIDVIEW.Columns.Item(5).Width = 75
        DTGRIDVIEW.Columns.Item(6).Width = 75

    End Sub


    Private Sub cmdExit_Click(sender As System.Object, e As System.EventArgs) Handles cmdExit.Click
        Me.Hide()
    End Sub

    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs)
        ClearBox()
        ButtonVisible(True)
        sSaveType = "A"
        txtOrderNo.Focus()

    End Sub
    Private Sub cmdEdit_Click(sender As System.Object, e As System.EventArgs) Handles cmdEdit.Click
        'ClearBox()
        ButtonVisible(True)
        sSaveType = "E"
        txtOrderNo.Focus()

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
        Dim RsOrderItems As New ADODB.Recordset

        Dim ArrItm(7) As String

        txtOrderNo.Text = Rsv.Fields("OrderNo").Value
        txtOrderDate.Text = Rsv.Fields("OrderDate").Value
        txtBranchName.Text = Rsv.Fields("BranchName").Value
        txtExpectedDate.Text = Rsv.Fields("ExpDelvyDate").Value
        If Not IsDBNull(Rsv.Fields("Comments").Value) Then txtComments.Text = Rsv.Fields("Comments").Value
        If Not IsDBNull(Rsv.Fields("ItemCount").Value) Then txtItemCount.Text = Rsv.Fields("ItemCount").Value
        If Not IsDBNull(Rsv.Fields("TotalQty").Value) Then txtTotQTY.Text = Rsv.Fields("TotalQty").Value
        If Not IsDBNull(Rsv.Fields("TotalAmount").Value) Then txtTotalAmount.Text = Rsv.Fields("TotalAmount").Value
        If Not IsDBNull(Rsv.Fields("Status").Value) Then lblStatus.Text = Rsv.Fields("Status").Value
        DTGRIDVIEW.Rows.Clear()
        Idx = 0
        RsOrderItems = New ADODB.Recordset
        RsOrderItems.Open("Select ORD.Itemcode,itm.ItemName,AvailableQTY,QTY,ORd.Rate,Amount from OrderItems ORD , ItemMaster itm  where ORD.Itemcode = itm.Itemcode and  ORD.OrderNo = '" & Rsv.Fields("OrderNo").Value & "'", cnLclCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If RsOrderItems.EOF = False Then
            Do While RsOrderItems.EOF = False
                Idx = Idx + 1
                ArrItm(0) = Idx
                For I = 1 To 6
                    ArrItm(I) = ""
                    ArrItm(I) = RsOrderItems.Fields(I - 1).Value
                Next
                DTGRIDVIEW.Rows.Add(ArrItm)
                RsOrderItems.MoveNext()
            Loop
        Else
            MsgBox("Order Items not found for this Order Number", vbCritical)
        End If


    End Sub

    

    Private Sub cmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancel.Click
        ButtonVisible(False)
        txtOrderNo.Enabled = True
        sSaveType = ""
    End Sub

    Private Sub cmdSave_Click(sender As System.Object, e As System.EventArgs) Handles cmdSave.Click

        Dim RsSaveUsr As New ADODB.Recordset
        RsSaveUsr.Open("Select * from OrderMaster where OrderNo ='" & txtOrderNo.Text & "'", cnLclCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

        If sSaveType = "A" Then
            RsSaveUsr.AddNew()
            RsSaveUsr.Fields("OrderNo").Value = txtOrderNo.Text
            RsSaveUsr.Fields("OrderDate").Value = txtOrderDate.Text
            RsSaveUsr.Fields("BranchName").Value = txtBranchName.Text
            RsSaveUsr.Fields("ExpDelvyDate").Value = txtExpectedDate.Text
            RsSaveUsr.Fields("Comments").Value = txtComments.Text
            RsSaveUsr.Fields("ItemCount").Value = txtItemCount.Text
            RsSaveUsr.Fields("TotalQty").Value = txtTotQTY.Text
            RsSaveUsr.Fields("TotalAmount").Value = txtTotalAmount.Text
            RsSaveUsr.Update()
            RsSaveUsr.Close()

            RsSaveUsr.Open("Select * from OrderItems where OrderNo ='" & txtOrderNo.Text & "'", cnLclCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            For I = 0 To DTGRIDVIEW.RowCount
                With RsSaveUsr
                    .AddNew()
                    .Fields("ItemCode").Value = DTGRIDVIEW.Rows.Item(I).Cells(1).Value
                    .Fields("AvailableQTY").Value = Val(DTGRIDVIEW.Rows.Item(I).Cells(3).Value)
                    .Fields("QTY").Value = Val(DTGRIDVIEW.Rows.Item(I).Cells(4).Value)
                    .Fields("Rate").Value = Val(DTGRIDVIEW.Rows.Item(I).Cells(5).Value)
                    .Fields("Amount").Value = Val(DTGRIDVIEW.Rows.Item(I).Cells(6).Value)
                    .Fields("OrderNo").Value = txtOrderNo.Text
                    .Fields("SYNC").Value = 0
                    .Fields("WrkFlwSTS").Value = 1
                    .Update()
                End With
            Next I
        End If


        If sSaveType = "E" Then
            If RsSaveUsr.EOF() Then
                MsgBox("Order Details Not Found, So Adding New", vbInformation)
                RsSaveUsr.AddNew()
            End If

            RsSaveUsr.Fields("OrderNo").Value = txtOrderNo.Text
            RsSaveUsr.Fields("OrderDate").Value = txtOrderDate.Text
            RsSaveUsr.Fields("BranchName").Value = txtBranchName.Text
            RsSaveUsr.Fields("ExpDelvyDate").Value = txtExpectedDate.Text
            RsSaveUsr.Fields("Comments").Value = txtComments.Text
            RsSaveUsr.Fields("ItemCount").Value = txtItemCount.Text
            RsSaveUsr.Fields("TotalQty").Value = txtTotQTY.Text
            RsSaveUsr.Fields("TotalAmount").Value = Val(txtTotalAmount.Text)
            RsSaveUsr.Update()
            RsSaveUsr.Close()

            For I = 0 To DTGRIDVIEW.RowCount - 1
                With RsSaveUsr
                    .Open("Select * from OrderItems where OrderNo ='" & txtOrderNo.Text & "' and ItemCode ='" & DTGRIDVIEW.Rows.Item(I).Cells(1).Value & "'", cnLclCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
                    If .EOF And .BOF Then .AddNew()
                    .Fields("ItemCode").Value = DTGRIDVIEW.Rows.Item(I).Cells(1).Value
                    .Fields("AvailableQTY").Value = Val(DTGRIDVIEW.Rows.Item(I).Cells(3).Value)
                    .Fields("QTY").Value = Val(DTGRIDVIEW.Rows.Item(I).Cells(4).Value)
                    .Fields("Rate").Value = Val(DTGRIDVIEW.Rows.Item(I).Cells(5).Value)
                    .Fields("Amount").Value = Val(DTGRIDVIEW.Rows.Item(I).Cells(6).Value)
                    .Fields("OrderNo").Value = txtOrderNo.Text
                    .Fields("SYNC").Value = 0
                    .Fields("WrkFlwSTS").Value = 1
                    .Update()
                    .Close()
                End With
            Next I

        End If
        ButtonVisible(False)
        Rsv.Requery()
        sSaveType = ""
    End Sub

 

    Private Sub txtOrderNo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtOrderNo.Validating
        If txtOrderNo.Text <> "" Then

            Rsv.Find("OrderNo = '" & txtOrderNo.Text & "'")
            If Rsv.EOF Then
                MsgBox("This Order Number Not Found ", vbInformation)
                txtOrderNo.Text = ""
                Rsv.MoveFirst()
                cmdCancel_Click(sender, e)
                Exit Sub
            Else
                If Rsv.Fields("Status").Value = "Recieved" Then
                    DisplayFields()
                    Rsv.MovePrevious()
                Else
                    MsgBox("This Order is in " & Rsv.Fields("Status").Value & " Status", vbAbort, "Cannot Change this Order")
                    cmdCancel_Click(sender, e)
                    Exit Sub
                End If
            End If


        End If
    End Sub

    Private Sub txtOrderNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtOrderNo.TextChanged

    End Sub

    Private Sub DTGRIDVIEW_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DTGRIDVIEW.CellContentClick

    End Sub

    Private Sub DTGRIDVIEW_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DTGRIDVIEW.CellContentDoubleClick
        Dim Qty As Integer
        Qty = Val(InputBox("Please Enter the New Qty", "Current Qty is " & Val(DTGRIDVIEW.CurrentRow.Cells(4).Value), Val(DTGRIDVIEW.CurrentRow.Cells(4).Value)))
        If Qty > 0 Then
            DTGRIDVIEW.CurrentRow.Cells(4).Value = Qty
            DTGRIDVIEW.CurrentRow.Cells(6).Value = Qty * Val(DTGRIDVIEW.CurrentRow.Cells(5).Value)
            cmdSave.Focus()
        End If


    End Sub

    Private Sub DTGRIDVIEW_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DTGRIDVIEW.KeyDown
        If e.KeyCode = Keys.F9 Then
            Dim Qty As Integer
            Qty = Val(InputBox("Please Enter the New Qty", "Current Qty is " & Val(DTGRIDVIEW.CurrentRow.Cells(4).Value), Val(DTGRIDVIEW.CurrentRow.Cells(4).Value)))
            If Qty > 0 Then
                DTGRIDVIEW.CurrentRow.Cells(4).Value = Qty
                DTGRIDVIEW.CurrentRow.Cells(6).Value = Qty * Val(DTGRIDVIEW.CurrentRow.Cells(5).Value)
                cmdSave.Focus()
            End If
        End If
    End Sub
End Class