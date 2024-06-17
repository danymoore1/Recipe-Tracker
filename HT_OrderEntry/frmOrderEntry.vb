Imports System.Windows.Forms

Public Class frmOrderEntry
    Public OrderHeaderUID As Integer
    Private OrderdetailRow As Integer
    Private OrderUpdateRow As Integer
    Private OrderMessageRow As Integer
    Private OrderMessageUpdate As Integer
    Public UserUID As Integer
    Public tUserName As String
    Private Sub frmOrderEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Loading the Order Header Tab
        OrderHeaderUID = 0
        LoadOrderNo()
        LoadBillTo()
        LoadShipTerms()
        LoadNetTerms()
        LoadSalesRep()
        ddlBillToCode.SelectedIndex = -1
        ddlShipToCode.SelectedIndex = -1
        ddlShipTerms.SelectedIndex = -1
        ddlNetTerms.SelectedIndex = -1
        ddlSalesRep.SelectedIndex = -1
    End Sub
#Region "Order Header Tab"
    Private Sub LoadOrderNo()
        Dim bs As New bsOrderHeader
        'Get All Orders in status O - Open
        ddlOrderNo.DataSource = bs.GetOrderByStatus("O")
        ddlOrderNo.SelectedIndex = -1
    End Sub
    Private Sub LoadBillTo()
        Dim bs As New HT_Business.bsCustomer
        Dim dt As New HT_Business.dsCustomer.CustomerDataTable
        Dim dtCust As New DataTable

        dtCust = bs.GetBillToCustomers
        Dim Bill As New DataTable("BillTo")
        Bill.Columns.Add("CustUID", System.Type.GetType("System.Int32"))
        Bill.Columns.Add("CustCode", System.Type.GetType("System.String"))
        Bill.Columns.Add("CustName", System.Type.GetType("System.String"))
        Dim rw As DataRow
        For Each rw In dtCust.Rows
            Dim dr As DataRow = Bill.NewRow
            dr("CustUID") = rw(0).ToString
            dr("CustCode") = rw(1).ToString
            dr("CustName") = rw(2).ToString
            Bill.Rows.Add(dr)
        Next
        ddlBillToCode.SelectedIndex = -1
        ddlBillToCode.Items.Clear()
        ddlBillToCode.SourceDataString = New String(2) {"CustCode", "CustName", "CustUID"}
        ddlBillToCode.SourceDataTable = Bill
    End Sub
    Private Sub LoadShipTo()
        Dim bs As New HT_Business.bsCustomer
        Dim dt As New HT_Business.dsCustomer.CustomerDataTable
        dt = bs.GetShipToCustomersbyBillTo(ddlBillToCode.SelectedItem.Col3)
        Dim Ship As New DataTable("ShipTo")
        Ship.Columns.Add("CustUID", System.Type.GetType("System.Int32"))
        Ship.Columns.Add("CustCode", System.Type.GetType("System.String"))
        Ship.Columns.Add("CustName", System.Type.GetType("System.String"))
        Dim rw As HT_Business.dsCustomer.CustomerRow
        For Each rw In dt
            Dim dr As DataRow = Ship.NewRow
            dr("CustUID") = rw.CustUID
            dr("CustCode") = rw.CustCode
            dr("CustName") = rw.CustName
            Ship.Rows.Add(dr)
        Next
        ddlShipToCode.SelectedIndex = -1
        ddlShipToCode.Items.Clear()
        ddlShipToCode.SourceDataString = New String(2) {"CustCode", "CustName", "CustUID"}
        ddlShipToCode.SourceDataTable = Ship
        ' ddlShipToCode.DataSource = bs.GetShipToCustomers
    End Sub
    Private Sub LoadShipTerms()
        Dim bs As New HT_Business.bsTerms
        ddlShipTerms.DataSource = bs.GetAllShipTerms
    End Sub
    Private Sub LoadNetTerms()
        Dim bs As New HT_Business.bsTerms
        ddlNetTerms.DataSource = bs.GetAllNetTerms
    End Sub
    Private Sub LoadSalesRep()
        Dim bs As New HT_Business.bsSalesRep
        Dim dt As New HT_Business.dsSalesPerson.SalesRepDataTable
        dt = bs.GetAllSalesRep
        Dim Rep As New DataTable("SalesRep")
        Rep.Columns.Add("SalesRepUID", System.Type.GetType("System.Int32"))
        Rep.Columns.Add("SalesRep", System.Type.GetType("System.String"))
        Rep.Columns.Add("SalesRepName", System.Type.GetType("System.String"))
        Dim rw As HT_Business.dsSalesPerson.SalesRepRow
        For Each rw In dt
            Dim dr As DataRow = Rep.NewRow
            dr("SalesRepUID") = rw.SalesRepUID.ToString
            dr("SalesRep") = rw.SalesRep.ToString
            dr("SalesRepName") = rw.SalesRepName
            Rep.Rows.Add(dr)
        Next
        ddlSalesRep.SelectedIndex = -1
        ddlSalesRep.Items.Clear()
        ddlSalesRep.SourceDataString = New String(2) {"SalesRep", "SalesRepName", "SalesRepUID"}
        ddlSalesRep.SourceDataTable = Rep
    End Sub
    Private Sub ddlOrderNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlOrderNo.Leave
        If ddlOrderNo.Text = "" Or ddlOrderNo.Text = "0" Then
            txtOrderStatus.Text = "O"
            Dim bs As New HT_Business.NextOrderNo
            ddlOrderNo.Text = CStr(bs.GetNextNum("INV"))
            OrderHeaderUID = 0
        Else
            Dim FindOrder As Integer = ddlOrderNo.FindString(ddlOrderNo.Text)

            If FindOrder > -1 Then
                OrderHeaderUID = CInt(ddlOrderNo.SelectedValue)
                LoadOrder()
                Text = "Updating Order"
            Else
                Text = "Adding Order "
            End If
        End If
    End Sub
    Private Sub LoadOrder()
        Dim bs As New bsOrderHeader
        Dim dt As New dsOrderHeader.OrderHeaderDataTable
        dt = bs.GetOrderbyOrderNo(CInt(ddlOrderNo.Text))
        Dim rw As dsOrderHeader.OrderHeaderRow
        For Each rw In dt
            With rw
                txtPONO.Text = .PONO
                dtmOrderDate.Text = CStr(.OrderDate)
                dtmShipDate.Text = CStr(.ShipDate)
                ddlBillToCode.SelectedValue = CStr(.BillToCode)
                ddlShipToCode.SelectedValue = CStr(.ShipToCode)
                txtShipAddr1.Text = .ShipToAddr1
                txtShipAddr2.Text = .ShipToAddr2
                txtShipCity.Text = .ShipToCity
                txtShipState.Text = .ShiptoState
                txtShipZip.Text = .ShipToZip
                ddlShipTerms.SelectedValue = .ShipTermsUID
                ddlNetTerms.SelectedValue = .NetTermsUID
                ddlSalesRep.SelectedValue = CStr(.Salesperson)
                txtOrderStatus.Text = .OrderStatus
                txtShipName.Text = .ShipToName
                txtRef.Text = .CustOrderNo
                ddlNetTerms.SelectedValue = .NetTermsUID
                ddlShipTerms.SelectedValue = .ShipTermsUID
            End With
        Next
    End Sub
    Private Sub ddlSalesRep_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlSalesRep.SelectedIndexChanged

    End Sub
    Private Sub ddlBillToCode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlBillToCode.Leave
        If ddlBillToCode.SelectedIndex <> -1 Then
            Dim bs As New HT_Business.bsCustomer
            Dim rw As HT_Business.dsCustomer.CustomerRow
            rw = bs.GetCustomerByCustCode(ddlBillToCode.SelectedItem.Col1)
            txtBillCity.Text = rw.City
            txtBillName.Text = rw.CustName
            txtBllAddr.Text = rw.Address1
            txtBillState.Text = rw.State
            txtBillZip.Text = rw.Zip
            ddlShipTerms.SelectedValue = rw.ShipTermsUID
            ddlNetTerms.SelectedValue = rw.NetTermsUID
        End If
    End Sub
    Private Sub ddlBillToCode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlBillToCode.SelectedIndexChanged
        If ddlBillToCode.SelectedIndex <> -1 Then
            Dim bs As New HT_Business.bsCustomer
            Dim dt As New HT_Business.dsCustomer.CustomerDataTable
            Dim rw As HT_Business.dsCustomer.CustomerRow
            rw = bs.GetCustomerByCustCode(ddlBillToCode.SelectedItem.Col1)
            txtBillCity.Text = rw.City
            txtBillName.Text = rw.CustName
            txtBllAddr.Text = rw.Address1
            txtBillState.Text = rw.State
            txtBillZip.Text = rw.Zip
            ddlShipTerms.SelectedValue = rw.ShipTermsUID
            ddlNetTerms.SelectedValue = rw.NetTermsUID
            LoadShipTo()
        End If
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim bs As New bsOrderHeader
        Dim dt As New dsOrderHeader.OrderHeaderDataTable
        Dim rw As dsOrderHeader.OrderHeaderRow
        rw = dt.NewOrderHeaderRow
        With rw
            .OrderNo = ddlOrderNo.Text
            .OrderDate = Today.Date
            .ShipDate = CDate(dtmShipDate.Text)
            .DeliveryDate = CDate(dtmShipDate.Text)
            .PONO = txtPONO.Text
            .BillToCode = CInt(ddlBillToCode.SelectedItem.Col3)
            .ShipToCode = CInt(ddlShipToCode.SelectedItem.Col3)
            .ShipToAddr1 = txtShipAddr1.Text
            .ShipToAddr2 = txtShipAddr2.Text
            .ShipToCity = txtShipCity.Text
            .ShiptoState = txtShipState.Text
            .ShipToZip = txtShipZip.Text
            .Salesperson = CInt(ddlSalesRep.SelectedItem.Col3)
            .OrderStatus = "O"
            .ShipTermsUID = CInt(ddlShipTerms.SelectedValue)
            .NetTermsUID = CInt(ddlNetTerms.SelectedValue)
            .ShipToName = txtShipName.Text
            .PickUpDate = CDate(dtmShipDate.Text)
            .CustOrderNo = txtRef.Text
        End With
        If OrderHeaderUID > 0 Then
            rw.OrdrHeaderUID = OrderHeaderUID
            bs.UpdateOrderHeader(rw)
        Else
            OrderHeaderUID = bs.InsertOrderHeader(rw)
        End If
    End Sub
    Private Sub ddlShipToCode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlShipToCode.Leave
        If ddlOrderNo.SelectedIndex <= -1 Then
            If ddlShipToCode.SelectedIndex <> -1 Then
                Dim bs As New HT_Business.bsCustomer
                Dim rw As HT_Business.dsCustomer.CustomerRow
                rw = bs.GetCustomerByCustCode(ddlShipToCode.SelectedItem.Col1)
                txtShipAddr1.Text = rw.Address1
                txtShipAddr2.Text = rw.Address2
                txtShipCity.Text = rw.City
                txtShipState.Text = rw.State
                txtShipZip.Text = rw.Zip
                txtShipName.Text = rw.CustName
            End If
        End If
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub tabOrderHeader_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabOrderHeader.Leave
        'Here we have to check to see if A Order has been loaded or Added
        'If Order is a new Order - Need to Insert into OrderHeader and then process moving to a different Tab
        'If Order already exist, then Update

        If OrderHeaderUID = 0 And ddlOrderNo.Text = "" Then
            MsgBox("Must Select An Order Before Leaving")
        End If
        If OrderHeaderUID = 0 And ddlOrderNo.Text > "" Then
            InsertOrderHeader()
        ElseIf ddlOrderNo.Text > "" And OrderHeaderUID > 0 Then
            InsertOrderHeader()
        End If
        If OrderHeaderUID = 0 Then
            tabOrderHeader.Focus()
        Else
            LoadMessages()
            LoadDetailGrid()
        End If
    End Sub
    Private Function InsertOrderHeader() As Integer
        Dim bs As New bsOrderHeader
        Dim dt As New dsOrderHeader.OrderHeaderDataTable
        Dim rw As dsOrderHeader.OrderHeaderRow
        rw = dt.NewOrderHeaderRow
        With rw
            .OrderNo = ddlOrderNo.Text
            .OrderDate = Today.Date
            .ShipDate = CDate(dtmShipDate.Text)
            .DeliveryDate = CDate(dtmShipDate.Text)
            .PONO = txtPONO.Text
            .BillToCode = CInt(ddlBillToCode.SelectedItem.Col3)
            .ShipToCode = CInt(ddlShipToCode.SelectedItem.Col3)
            .ShipToAddr1 = txtShipAddr1.Text
            .ShipToAddr2 = txtShipAddr2.Text
            .ShipToCity = txtShipCity.Text
            .ShiptoState = txtShipState.Text
            .ShipToZip = txtShipZip.Text
            .Salesperson = CInt(ddlSalesRep.SelectedItem.Col3)
            .OrderStatus = "O"
            .shipTermsUID = CInt(ddlShipTerms.SelectedValue)
            .NetTermsUID = CInt(ddlNetTerms.SelectedValue)
            .shiptoName = txtShipName.Text
            .PickUpDate = CDate(dtmShipDate.Text)
            .CustOrderNo = txtRef.Text
        End With
        If OrderHeaderUID > 0 Then
            rw.OrdrHeaderUID = OrderHeaderUID
            bs.UpdateOrderHeader(rw)
        Else
            OrderHeaderUID = bs.InsertOrderHeader(rw)
        End If
    End Function

#End Region
#Region "Message Tab"
    Private Sub LoadMessages()
        dgvOrderMessages.AutoGenerateColumns = False
        Dim bs As New bsOrderMessage
        dgvOrderMessages.DataSource = bs.GetOrderMessages(CInt(ddlOrderNo.SelectedValue))
    End Sub
    Private Sub dgvOrderMessages_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOrderMessages.CellValueChanged
        If OrderMessageRow = 0 Then
            OrderMessageUpdate = 1
        End If
    End Sub
    Private Sub dgvOrderMessages_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvOrderMessages.RowValidating
        Dim bs As New bsOrderMessage
        Dim dt As New dsOrderMessage.OrderMessageDataTable
        Dim rw As dsOrderMessage.OrderMessageRow
        rw = dt.NewOrderMessageRow
        If OrderMessageRow = 1 Then
            'Here we add the the Row to the Order Message table

            With rw
                .BornOn = Now
                .OrderNo = CInt(ddlOrderNo.SelectedValue)
                .MessageNotes = CStr(dgvOrderMessages.CurrentRow.Cells(3).Value)
                .UserUID = UserUID
            End With
            dgvOrderMessages.CurrentRow.Cells(0).Value = bs.InsertOrderMessage(rw)
            dgvOrderMessages.CurrentRow.Cells(4).Value = rw.OrderNo
            dgvOrderMessages.CurrentRow.Cells(1).Value = tUserName
            dgvOrderMessages.CurrentRow.Cells(2).Value = Now

            'resetting the row added for Messages
            OrderMessageRow = 0
        End If
        If OrderMessageUpdate = 1 Then
            With rw
                .BornOn = Now
                .OrderNo = CInt(ddlOrderNo.SelectedValue)
                .MessageNotes = CStr(dgvOrderMessages.CurrentRow.Cells(3).Value)
                .UserUID = UserUID
                .MessageUID = CInt(dgvOrderMessages.CurrentRow.Cells(0).Value)
            End With
            bs.UpdateOrderMessage(rw)
            OrderMessageUpdate = 0
        End If
    End Sub
    Private Sub dgvOrderMessages_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgvOrderMessages.UserAddedRow
        OrderMessageRow = 1
    End Sub
    Private Sub dgvOrderMessages_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles dgvOrderMessages.UserDeletingRow
        Dim bs As New bsOrderMessage
        bs.DeleteOrderMessage(CInt(dgvOrderMessages.CurrentRow.Cells(0).Value))
    End Sub
#End Region
#Region "Detail Tab"
    Private Sub LoadDetailGrid()
        dgvOrderDetail.Columns.Clear()
        dgvOrderDetail.AutoGenerateColumns = False
        'This Loads the OrderDetailUID for changes to the item
        Dim OrderDetailUID As New DataGridViewTextBoxColumn
        OrderDetailUID.Visible = False
        OrderDetailUID.DataPropertyName = "OrderDetailUID"
        OrderDetailUID.Name = "OrderDetailUID"
        dgvOrderDetail.Columns.Add(OrderDetailUID)
        dgvOrderDetail.Columns(0).Visible = False
        'This is loading the Customer Item numbers
        Dim CusPack As New DataGridViewComboBoxColumn
        CusPack.DisplayMember = "CustomerItemNo"
        CusPack.ValueMember = "CusPackUID"
        'CusPack.ValueMember = "CusPackUID"
        CusPack.HeaderText = "Item #"
        CusPack.Name = "CusPackUID"
        CusPack.DataPropertyName = "CustomerItemNo"
        CusPack.Width = 150
        Dim bsITemMaster As New HT_Business.bsItemMaster
        CusPack.DataSource = bsITemMaster.GetCustomerPackCustUID(ddlBillToCode.SelectedItem.Col3)
        ' CusPack.DataSource = bsITemMaster.GetCustomerPackItems
        ' Dim cusbs As New HT_Business.bsCustomerPackHdr
        ' CusPack.DataSource = cusbs.GetCustomerPackHDrbyCust(ddlBillToCode.SelectedItem.Col3)
        Me.dgvOrderDetail.Columns.Add(CusPack)

        'This loads the description of the Item #
        Dim CustItemDesc As New DataGridViewTextBoxColumn
        CustItemDesc.ReadOnly = True
        CustItemDesc.DataPropertyName = "ItemDesc"
        CustItemDesc.Name = "ItemDesc"
        CustItemDesc.HeaderText = "Item Description"
        CustItemDesc.Width = 200
        dgvOrderDetail.Columns.Add(CustItemDesc)

        'This Loads the Qty field 
        Dim numQty As New DataGridViewTextBoxColumn
        numQty.HeaderText = "Qty"
        numQty.DataPropertyName = "Qty"
        numQty.Name = "Qty"
        dgvOrderDetail.Columns.Add(numQty)


        'Contracted Price - read only - comes from Customer Pack
        Dim CPrice As New DataGridViewTextBoxColumn
        CPrice.HeaderText = "Contracted Price"
        CPrice.DataPropertyName = "Cprice"
        CPrice.Name = "Cprice"
        dgvOrderDetail.Columns.Add(CPrice)

        'This is the Extended Price Auto Caculate once Price is inputed
        Dim ExtPrice As New DataGridViewTextBoxColumn
        ExtPrice.HeaderText = "Extended Price"
        ExtPrice.ReadOnly = True
        ExtPrice.DataPropertyName = "ExtPrice"
        ExtPrice.Name = "ExtPrice"
        dgvOrderDetail.Columns.Add(ExtPrice)

        'Now we are going to load the DataGrid
        Dim gridbs As New bsOrderDetail
        Dim OrderDt As New dsOrderDetail.OrderDetailGridDataTable
        Dim dtOrder As New DataTable
        dtOrder = gridbs.GetOrderdetailgridN(OrderHeaderUID)
        Dim rw As DataRow
        For Each rw In dtOrder.Rows
            Dim rw1 As New DataGridViewRow
            Dim dvcell As DataGridViewCell
            dvcell = New DataGridViewTextBoxCell
            dvcell.Value = rw(0).ToString
            rw1.Cells.Add(dvcell)
            dvcell = New DataGridViewTextBoxCell
            dvcell.Value = rw(1).ToString
            rw1.Cells.Add(dvcell)
            dvcell = New DataGridViewTextBoxCell
            dvcell.Value = rw(2).ToString
            rw1.Cells.Add(dvcell)
            dvcell = New DataGridViewTextBoxCell
            dvcell.Value = rw(3).ToString
            rw1.Cells.Add(dvcell)
            dvcell = New DataGridViewTextBoxCell
            dvcell.Value = rw(4).ToString

            rw1.Cells.Add(dvcell)
            dvcell = New DataGridViewTextBoxCell
            dvcell.Value = rw(5).ToString
            rw1.Cells.Add(dvcell)
            dgvOrderDetail.Rows.Add(rw1)
        Next
        'dgvOrderDetail.DataSource = gridbs.GetOrderDetailGrid(OrderHeaderUID)



    End Sub
    Private Sub dgvOrderDetail_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOrderDetail.CellValueChanged
        If dgvOrderDetail.CurrentCell.ColumnIndex = 4 Or dgvOrderDetail.CurrentCell.ColumnIndex = 3 Then
            dgvOrderDetail.CurrentRow.Cells(5).Value = CDec(dgvOrderDetail.CurrentRow.Cells(3).Value) * CDec(dgvOrderDetail.CurrentRow.Cells(4).Value)
        End If
        If dgvOrderDetail.CurrentCell.ColumnIndex = 1 Then

            'This inserts the description into the Grid
            Dim bsOrderdetail As New bsOrderDetail
            dgvOrderDetail.CurrentRow.Cells(2).Value = bsOrderdetail.GetItemMasterDesc(CInt(dgvOrderDetail.CurrentRow.Cells(1).Value))
            'Dim bs As New HT_Business.bsCustomerPackHdr
            'dgvOrderDetail.CurrentRow.Cells(2).Value = bs.GetCustomeritemDescr(CInt(dgvOrderDetail.CurrentRow.Cells(1).Value))
            Dim bs1 As New HT_Business.bsCustomerPricing
            dgvOrderDetail.CurrentRow.Cells(4).Value = bs1.GetItemPricebyDate(CInt(dgvOrderDetail.CurrentRow.Cells(1).Value), CDate(dtmOrderDate.Text))
        End If

        If OrderdetailRow = 0 Then
            OrderUpdateRow = 1
        End If
    End Sub
    Private Sub dgvOrderDetail_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvOrderDetail.RowValidating
        If OrderdetailRow = 1 Then
            Dim bs As New bsOrderDetail
            Dim dt As New dsOrderDetail.OrderDetailDataTable
            Dim rw As dsOrderDetail.OrderDetailRow
            rw = dt.NewOrderDetailRow
            rw.OrderHeaderUID = OrderHeaderUID
            rw.CusPackUID = CInt(dgvOrderDetail.CurrentRow.Cells(1).Value)
            rw.Qty = CInt(dgvOrderDetail.CurrentRow.Cells(3).Value)
            rw.Price = CDec(dgvOrderDetail.CurrentRow.Cells(4).Value)
            dgvOrderDetail.CurrentRow.Cells(0).Value = bs.InsertOrderDetail(rw)
            OrderdetailRow = 0
        End If
        If OrderUpdateRow = 1 Then
            Dim bs As New bsOrderDetail
            Dim dt As New dsOrderDetail.OrderDetailDataTable
            Dim rw As dsOrderDetail.OrderDetailRow
            rw = dt.NewOrderDetailRow
            rw.OrderHeaderUID = OrderHeaderUID
            rw.CusPackUID = CInt(dgvOrderDetail.CurrentRow.Cells(1).Value)
            rw.Qty = CInt(dgvOrderDetail.CurrentRow.Cells(3).Value)
            rw.OrderDetailUID = CInt(dgvOrderDetail.CurrentRow.Cells(0).Value)
            bs.UpdateOrderDetail(rw)
            OrderUpdateRow = 0
        End If
    End Sub
    Private Sub dgvOrderDetail_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgvOrderDetail.UserAddedRow
        OrderdetailRow = 1
    End Sub
    Private Sub dgvOrderDetail_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles dgvOrderDetail.UserDeletingRow
        Dim bs As New bsOrderDetail
        bs.DeleteOrderDetail(CInt(dgvOrderDetail.CurrentRow.Cells(0).Value))
    End Sub
    Private Sub dgvOrderDetail_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dgvOrderDetail.Validating
        Dim rw As DataGridViewRow
        For Each rw In dgvOrderDetail.Rows
            Dim t As String = CStr(rw.Cells(1).Value)
        Next
    End Sub
#End Region

    Private Sub btnPrintOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintOrder.Click

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class