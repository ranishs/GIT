Imports System.Windows.Forms

Public Class frmSyncData

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Dim Rslcl As New ADODB.Recordset
            Dim RsRmt As New ADODB.Recordset

            LstStatus.Items.Clear()

            LstStatus.Items.Add("Connecting Remote Server")
            LstStatus.Items.Add(cnWebCon.State)


            Rslcl = New ADODB.Recordset
            RsRmt = New ADODB.Recordset
            Rslcl.Open("Select * from BranchMas where Sync = 0 ", cnLclCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            If Rslcl.EOF = False Then
                LstStatus.Items.Add("Sync the Branch")
                RsRmt = New ADODB.Recordset
                RsRmt.Open("Select * from BranchMas ", cnWebCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
                Do While Rslcl.EOF = False
                    RsRmt.AddNew()

                    RsRmt.Fields("BranchID").Value = Rslcl.Fields("BranchID").Value
                    RsRmt.Fields("BranchName").Value = Rslcl.Fields("BranchName").Value

                    RsRmt.Update()
                    Rslcl.Fields("SYNC").Value = 1
                    Rslcl.Update()
                    Rslcl.MoveNext()
                Loop
                RsRmt.Close()
            End If
            Rslcl.Close()

            LstStatus.Items.Add("Sync the User")


            Rslcl = New ADODB.Recordset
            RsRmt = New ADODB.Recordset
            Rslcl.Open("Select * from UserMas where Sync = 0 ", cnLclCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            If Rslcl.EOF = False Then
                LstStatus.Items.Add("User Sync Started")
                Do While Rslcl.EOF = False
                    RsRmt = New ADODB.Recordset
                    RsRmt.Open("Select * from UserMas  where username ='" & Rslcl.Fields("UserName").Value & "'", cnWebCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

                    If RsRmt.EOF Then
                        RsRmt.AddNew()
                    End If

                    RsRmt.Fields("UserName").Value = Rslcl.Fields("UserName").Value
                    RsRmt.Fields("Password").Value = Rslcl.Fields("Password").Value
                    RsRmt.Fields("UserType").Value = Rslcl.Fields("UserType").Value
                    RsRmt.Fields("BranchID").Value = Rslcl.Fields("BranchID").Value
                    Rslcl.Fields("SYNC").Value = 1
                    Rslcl.Update()
                    RsRmt.Update()
                    Rslcl.MoveNext()
                Loop
                RsRmt.Close()
                LstStatus.Items.Add("User Sync Completed")
            End If
            Rslcl.Close()

            LstStatus.Items.Add("Sync the ItemMaster")


            Rslcl = New ADODB.Recordset
            RsRmt = New ADODB.Recordset
            Rslcl.Open("Select * from ItemMaster where Sync = 0 ", cnLclCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            If Rslcl.EOF = False Then
                LstStatus.Items.Add("Item Sync Started")
                Do While Rslcl.EOF = False
                    RsRmt = New ADODB.Recordset
                    RsRmt.Open("Select * from ItemMaster  where Itemcode ='" & Rslcl.Fields("Itemcode").Value & "'", cnWebCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

                    If RsRmt.EOF Then
                        RsRmt.AddNew()
                    End If

                    RsRmt.Fields("Itemcode").Value = Rslcl.Fields("Itemcode").Value
                    RsRmt.Fields("ItemName").Value = Rslcl.Fields("ItemName").Value
                    RsRmt.Fields("QOH").Value = Rslcl.Fields("QOH").Value
                    RsRmt.Fields("Rate").Value = Rslcl.Fields("Rate").Value
                    Rslcl.Fields("SYNC").Value = 1
                    Rslcl.Update()
                    RsRmt.Update()
                    Rslcl.MoveNext()
                Loop
                RsRmt.Close()
                LstStatus.Items.Add("Item Sync Completed")
            End If
            Rslcl.Close()


            LstStatus.Items.Add("Download the Order Master")

            Rslcl = New ADODB.Recordset
            RsRmt = New ADODB.Recordset
            RsRmt.Open("Select * from OrderMaster where Sync = 0 ", cnWebCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            If RsRmt.EOF = False Then
                LstStatus.Items.Add("Order Master started ")
                Do While RsRmt.EOF = False
                    Rslcl = New ADODB.Recordset
                    Rslcl.Open("Select * from OrderMaster  where OrderNo ='" & RsRmt.Fields("OrderNo").Value & "'", cnLclCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

                    If Rslcl.EOF Then
                        Rslcl.AddNew()
                    End If

                    Rslcl.Fields("OrderNo").Value = RsRmt.Fields("OrderNo").Value
                    Rslcl.Fields("OrderDate").Value = RsRmt.Fields("OrderDate").Value
                    Rslcl.Fields("BranchCode").Value = RsRmt.Fields("BranchCode").Value
                    Rslcl.Fields("BranchName").Value = RsRmt.Fields("BranchName").Value
                    Rslcl.Fields("ExpDelvyDate").Value = RsRmt.Fields("ExpDelvyDate").Value
                    Rslcl.Fields("Comments").Value = RsRmt.Fields("Comments").Value
                    Rslcl.Fields("AddOn1").Value = RsRmt.Fields("AddOn1").Value
                    Rslcl.Fields("AddOn2").Value = RsRmt.Fields("AddOn2").Value
                    Rslcl.Fields("AddOn3").Value = RsRmt.Fields("AddOn3").Value
                    Rslcl.Fields("ItemCount").Value = RsRmt.Fields("ItemCount").Value
                    Rslcl.Fields("TotalQty").Value = RsRmt.Fields("TotalQty").Value
                    Rslcl.Fields("status").Value = "Recieved"
                    Rslcl.Fields("SYNC").Value = 1
                    Rslcl.Update()

                    If RsRmt.Fields("status").Value = "Upload" Then
                        RsRmt.Fields("status").Value = "Recieved"
                    End If
                    RsRmt.Fields("SYNC").Value = 1
                    RsRmt.Update()
                    RsRmt.MoveNext()


                Loop
                Rslcl.Close()
                LstStatus.Items.Add("Order Master Sync Completed")
            End If
            RsRmt.Close()

            LstStatus.Items.Add("Download the Order Items")
            Rslcl = New ADODB.Recordset
            RsRmt = New ADODB.Recordset
            RsRmt.Open("Select * from OrderItems where Sync = 0 ", cnWebCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            If RsRmt.EOF = False Then
                LstStatus.Items.Add("Order Items started ")
                Do While RsRmt.EOF = False
                    Rslcl = New ADODB.Recordset
                    Rslcl.Open("Select * from OrderItems  where OrderNo ='" & RsRmt.Fields("OrderNo").Value & "'", cnLclCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

                    If Rslcl.EOF Then
                        Rslcl.AddNew()
                    End If

                    Rslcl.Fields("Itemcode").Value = RsRmt.Fields("Itemcode").Value
                    Rslcl.Fields("AvailableQTY").Value = RsRmt.Fields("AvailableQTY").Value
                    Rslcl.Fields("Qty").Value = RsRmt.Fields("Qty").Value
                    Rslcl.Fields("Rate").Value = RsRmt.Fields("Rate").Value
                    Rslcl.Fields("Amount").Value = RsRmt.Fields("Amount").Value
                    Rslcl.Fields("OrderNo").Value = RsRmt.Fields("OrderNo").Value
                    Rslcl.Fields("WrkFlwSts").Value = 1
                    Rslcl.Fields("SYNC").Value = 1
                    Rslcl.Update()

                    RsRmt.Fields("SYNC").Value = 1
                    RsRmt.Update()
                    RsRmt.MoveNext()


                Loop
                Rslcl.Close()
                LstStatus.Items.Add(" OrderItems Sync Completed")
            End If
            RsRmt.Close()


            LstStatus.Items.Add("Order STATUS Sync Completed")

            Rslcl = New ADODB.Recordset
            RsRmt = New ADODB.Recordset
            Rslcl.Open("Select * from OrderMaster where Sync = 0 ", cnLclCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            If Rslcl.EOF = False Then
                LstStatus.Items.Add("Sync the Order Status")
                Do While Rslcl.EOF = False
                    RsRmt = New ADODB.Recordset
                    RsRmt.Open("Select * from OrderMaster   where OrderNo ='" & Rslcl.Fields("OrderNo").Value & "'", cnWebCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
                    If RsRmt.EOF = False Then
                        RsRmt.Fields("status").Value = Rslcl.Fields("status").Value
                        RsRmt.Update()
                        Rslcl.Fields("SYNC").Value = 1
                        Rslcl.Update()
                    Else
                        LstStatus.Items.Add("Serious Error  " & Rslcl.Fields("OrderNo").Value & " Not Found in the WEB Database")
                    End If
                    Rslcl.MoveNext()
                Loop
                RsRmt.Close()
            End If
            Rslcl.Close()

            LstStatus.Items.Add("Sync the Order Status Completed ")


            LstStatus.Items.Add("SYNC Completed")

        Catch Er As Exception
            LstStatus.Items.Add("Error in Process")
            LstStatus.Items.Add(Er.Message)
        End Try



    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
