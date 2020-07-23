
Public Class frmWorkOrderGeneration

    Dim RsV As New ADODB.Recordset
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        RsV = New ADODB.Recordset
        RsV.Open("Select Distinct(workOrderno) from Prod_Order ", cnLclCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        SetGrid()
    End Sub

    Private Sub cmdView_Click(sender As System.Object, e As System.EventArgs) Handles cmdView.Click
        Dim RsORd As New ADODB.Recordset
        Dim Idx As Integer
        Dim ArrItm(3) As String
        DTGRIDVIEW.Rows.Clear()
        RsORd.Open("Select Itm.Itemcode, itm.ItemName, sum(ORD.QTY)  from OrderItems ORD , ItemMaster itm         where(ORD.Itemcode = itm.Itemcode And WrkFlwSts = 1) group by Itemname , Itm.Itemcode ", cnLclCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If RsORd.EOF Then
            MsgBox("No Items Available for Production Plan", vbInformation)
            Exit Sub
        Else

            Idx = 0
            Do While RsORd.EOF = False
                Idx = Idx + 1
                ArrItm(0) = Idx
                For I = 1 To 3
                    ArrItm(I) = ""
                    ArrItm(I) = RsORd.Fields(I - 1).Value
                Next
                DTGRIDVIEW.Rows.Add(ArrItm)

                RsORd.MoveNext()
            Loop

        End If
        RsORd.Close()
        RsORd = Nothing
        If DTGRIDVIEW.Rows.Count > 1 Then cmdAllocate.Enabled = True
    End Sub
    Private Sub cmdMovePrv_Click(sender As System.Object, e As System.EventArgs) Handles cmdMovePrv.Click
        cmdAllocate.Enabled = False
        RsV.MovePrevious()
        If RsV.BOF Then
            RsV.MoveFirst()
            MsgBox("First Record", vbInformation)
        End If

        DisplayFields()



    End Sub

    Private Sub cmdMoveNext_Click(sender As System.Object, e As System.EventArgs) Handles cmdMoveNext.Click
        cmdAllocate.Enabled = False
        RsV.MoveNext()
        If RsV.EOF Then
            RsV.MoveLast()
            MsgBox("Last Record", vbInformation)
        End If

        DisplayFields()

    End Sub
    Private Sub DisplayFields()
        Dim Idx As Integer
        Dim Prod_Order As New ADODB.Recordset

        Dim ArrItm(4) As String

        DTGRIDVIEW.Rows.Clear()
        Idx = 0
        rtbText.Text = ""

        Prod_Order = New ADODB.Recordset
        Prod_Order.Open("Select P.workOrderNo, P.ItemCode, I.Itemname, P.QTY from   Prod_Order   P , ItemMaster I where I.Itemcode = p.itemcode and  WorkOrderNo = '" & RsV.Fields("WorkOrderNo").Value & "'", cnLclCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Prod_Order.EOF = False Then
            Do While Prod_Order.EOF = False
                
                For I = 0 To 3
                    ArrItm(I) = ""
                    ArrItm(I) = Prod_Order.Fields(I).Value
                Next
                DTGRIDVIEW.Rows.Add(ArrItm)
                Prod_Order.MoveNext()
            Loop
        Else
            MsgBox("Order Items not found for this Work Order", vbCritical)
        End If
        Prod_Order.Close()
        Prod_Order = Nothing

    End Sub

    Private Sub SetGrid()
        DTGRIDVIEW.Rows.Clear()
        DTGRIDVIEW.Columns.Clear()

        DTGRIDVIEW.Columns.Add("Sno", "Sno")
        DTGRIDVIEW.Columns.Add("Code", "Code")
        DTGRIDVIEW.Columns.Add("Name", "Name")
        DTGRIDVIEW.Columns.Add("Qty", "Qty")

        DTGRIDVIEW.Columns.Item(0).Width = 100
        DTGRIDVIEW.Columns.Item(1).Width = 100
        DTGRIDVIEW.Columns.Item(2).Width = 175
        DTGRIDVIEW.Columns.Item(3).Width = 50


    End Sub

    Private Sub DTGRIDVIEW_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DTGRIDVIEW.CellContentClick

    End Sub

    Private Sub cmdAllocate_Click(sender As System.Object, e As System.EventArgs) Handles cmdAllocate.Click
        Dim WkOrdNo As String

        If DTGRIDVIEW.SelectedRows.Count > 0 Then
            Dim RsProdORd As New ADODB.Recordset
            Dim RsWorkORd As New ADODB.Recordset
            Dim itmCode As String
            Dim ItmQty As Integer
            Dim OrderCreated As Boolean = False

            RsProdORd.Open("Select max(WorkOrderNo) from Prod_order", cnLclCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            If RsProdORd.EOF Then
                WkOrdNo = "WO00001"
            Else
                WkOrdNo = RsProdORd.Fields(0).Value
                WkOrdNo = WkOrdNo.Substring(0, 2) & Strings.Right("00000" & Trim(Str(Val(WkOrdNo.Substring(3, 4)) + 1)), 5)

            End If
            RsProdORd.Close()
            RsProdORd.Open("Select * from Prod_order", cnLclCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

            For I = 0 To DTGRIDVIEW.Rows.Count - 1
                If DTGRIDVIEW.Rows(I).Selected Then

                    itmCode = DTGRIDVIEW.Rows.Item(I).Cells(1).Value ' itemCode
                    ItmQty = Val(DTGRIDVIEW.Rows.Item(I).Cells(3).Value) ' QTY
                    cnLclCon.Execute("Insert into Prod_Order  Values ('" & WkOrdNo & "','" & itmCode & "','" & ItmQty & "')")
                    OrderCreated = True
                    RsWorkORd = New ADODB.Recordset
                    RsWorkORd.Open("Select distinct(Orderno)  from OrderItems where Itemcode = '" & itmCode & "' and WrkFlwSts = 1", cnLclCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
                    Do While Not RsWorkORd.EOF
                        cnLclCon.Execute("Insert into WorkOrdersref values ( '" & WkOrdNo & "','" & RsWorkORd.Fields(0).Value & "','" & itmCode & "')")
                        cnLclCon.Execute("Update OrderMaster set Status = 'Allocted', SYNC = 0  where  OrderNo = '" & RsWorkORd.Fields(0).Value & "'")
                        RsWorkORd.MoveNext()
                    Loop
                    RsWorkORd.Close()
                    RsWorkORd = Nothing
                    cnLclCon.Execute("Update OrderItems set WrkFlwSts = 2  where  WrkFlwSts = 1 and itemcode = '" & itmCode & "'")

                End If
            Next
            If OrderCreated Then
                MsgBox("Work Order Created " & WkOrdNo)
                PrintWorkOrder(WkOrdNo)

            End If

            cmdAllocate.Enabled = False
            cmdView_Click(sender, e)
        Else
            MsgBox("Unable to Allocate as No Items Selected")
        End If
    End Sub
    Private Sub PrintWorkOrder(OrderNo As String)
        Dim Print As New myPrinter 'Declares Print as a new myPrinter class.
        Dim myprintdialog As New PrintDialog 'Creates Print Dialog.
        With myprintdialog
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                '//------
                printer = .PrinterSettings.PrinterName 'Sets variable printer to selected
                'printers name.
                '\\------
                '//------
                copies = .PrinterSettings.Copies 'Sets ammount of copies to number specified
                ' in dialog.
                '\\------
                '//------
                Dim Prod_Order As New ADODB.Recordset
                Dim ArrItm(4) As String
                Dim Idx As Integer
                Dim RowText As String

                Idx = 0
                Prod_Order = New ADODB.Recordset
                Prod_Order.Open("Select P.workOrderNo, P.ItemCode, I.Itemname, P.QTY from   Prod_Order   P , ItemMaster I where I.Itemcode = p.itemcode and  WorkOrderNo = '" & OrderNo & "'", cnLclCon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
                rtbText.Text = "Order Number " & OrderNo & vbCr & vbCr
                If Prod_Order.EOF = False Then
                    Do While Prod_Order.EOF = False

                        RowText = Strings.Left(Prod_Order.Fields(1).Value & Space(10), 10)
                        RowText = RowText & Strings.Left(Prod_Order.Fields(2).Value & Space(25), 25)
                        RowText = RowText & Strings.Left(Prod_Order.Fields(3).Value & Space(10), 10)

                        rtbText.Text = rtbText.Text & RowText & vbCr
                        RowText = ""
                        Prod_Order.MoveNext()
                    Loop
                Else
                    MsgBox("Order Items not found for this Work Order", vbCritical)
                End If

                Prod_Order.Close()
                Prod_Order = Nothing


                Print.prt(rtbText.Text.Trim) 'calls the prt sub in
                'the myPrinter class with text (a string) set to the text in the rtb.
                'Basicly starts the printing process...
                '\\------
            End If
        End With
    End Sub
    Private Sub cmdExit_Click(sender As System.Object, e As System.EventArgs) Handles cmdExit.Click
        Me.Close()

    End Sub

    Private Sub cmdPrint_Click(sender As System.Object, e As System.EventArgs) Handles cmdPrint.Click
        PrintWorkOrder(RsV.Fields(0).Value)
    End Sub
End Class