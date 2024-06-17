Imports System.Windows.Forms

Public Class frmShip
    Public OrderHeaderUID As Integer
    Public orderno As Integer
    Private Loading As Integer
    Private RowAdded As Integer
    Private RowUpdated As Integer
    Private Sub frmShip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDropDowns()
    End Sub
    Private Sub ClearLabels()
        lblShipToName.Text = ""
        lblShipToAddr1.Text = ""
        lblShipToAddr2.Text = ""
        lblShipToCity.Text = ""
        lblShipToState.Text = ""
        lblShipToZip.Text = ""
        lblPONO.Text = ""
    End Sub
    Private Sub LoadDropDowns()
        Dim bs As New bsOrderHeader
        Loading = 1
        ddlOrderNo.DataSource = bs.GetOrderByStatus("O")
        ddlOrderNo.SelectedIndex = -1
        Loading = 0
        If orderno > 0 Then
            'This means that the Order # was passed into the Form, so We are going to Load the info
            ddlOrderNo.SelectedIndex = ddlOrderNo.FindString(CStr(orderno))
        End If
    End Sub
    Private Sub ddlOrderNo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlOrderNo.SelectedIndexChanged
        If ddlOrderNo.SelectedIndex > -1 Then
            If Not Loading = 1 Then
                LoadOrder()
            End If
        End If
    End Sub
    Private Sub LoadOrder()
        loadOrderHeader()
        LoadDetailGrid()
    End Sub
    Private Sub loadOrderHeader()
        Dim bs As New bsOrderHeader
        Dim dt As New dsOrderHeader.OrderHeaderDataTable
        Dim rw As dsOrderHeader.OrderHeaderRow
        dt = bs.GetOrderbyOrderNo(ddlOrderNo.Text)
        For Each rw In dt
            With rw
                lblShipToName.Text = .ShipToName
                lblShipToAddr1.Text = .ShipToAddr1
                lblShipToAddr2.Text = .ShipToAddr2
                lblShipToCity.Text = .ShipToCity
                lblShipToState.Text = .ShiptoState
                lblShipToZip.Text = .ShipToZip
                lblPONO.Text = .PONO
                OrderHeaderUID = .OrdrHeaderUID
            End With
        Next
    End Sub
    Private Sub LoadDetailGrid()
        dgvShip.AutoGenerateColumns = False
        If Not ddlOrderNo.SelectedValue Is Nothing Then
            Dim bs As New bsOrderDetail
            dgvShip.DataSource = bs.GetShippingItems(ddlOrderNo.SelectedValue)
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        'He we take the info from the grid and update the Order Ship Table
        Dim rw As New DataGridViewRow
        For Each rw In dgvShip.Rows

        Next
    End Sub

    Private Sub dgvShip_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvShip.CellValueChanged
        If Not ddlOrderNo.SelectedIndex = -1 Then
            If Not RowAdded = 1 Then
                RowUpdated = 1
            End If
            If Not dgvShip.RowCount <= 0 Then
                'dgvOrderDetail.CurrentCell.ColumnIndex = 4
                If dgvShip.CurrentCell.ColumnIndex = 1 Then
                    'Get Item Description and display on the screen
                    Dim bsItemMaster As New HT_Business.bsItemMaster
                    dgvShip.CurrentRow.Cells(2).Value = bsItemMaster.GetItemDesc(dgvShip.CurrentRow.Cells(1).Value)
                End If
            End If
        End If
    End Sub

    Private Sub dgvShip_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvShip.RowValidating
        Dim PhInvent As New Ht_Inventory.bsInvent
        Dim InventUID As Integer
        If Not dgvShip.CurrentRow.Cells(3).Value Is System.DBNull.Value Then
            PhInvent.CheckInventory(dgvShip.CurrentRow.Cells(3).Value, dgvShip.CurrentRow.Cells(1).Value, dgvShip.CurrentRow.Cells(4).Value)
            'PhInvent.CheckInventory(dgvShip.CurrentRow.Cells(6).Value, dgvShip.CurrentRow.Cells(5).Value, dgvShip.CurrentRow.Cells(7).Value)
            If PhInvent._ItemQty <= 0 Then
                MsgBox("Lot # does not Exist or no Qty left to Ship")
                dgvShip.CurrentRow.Cells(3).Value = ""
                dgvShip.CurrentRow.Cells(4).Value = 0
                dgvShip.CurrentRow.Cells(4).Selected = True
                Exit Sub
            ElseIf PhInvent._ItemQty < dgvShip.CurrentRow.Cells(4).Value Then
                MsgBox("Available Qty is less than stated, defaulted to qty Remaining")
                dgvShip.CurrentRow.Cells(4).Value = PhInvent._ItemQty
            End If
            InventUID = PhInvent._InventUID
            'PhInvent._OrderdetailUID = dgvShip.CurrentRow.Cells(1).Value
            PhInvent._OrderheaderUID = ddlOrderNo.SelectedValue
            PhInvent._ItemQty = dgvShip.CurrentRow.Cells(4).Value
            If RowAdded = 1 Then
                Dim bsOrderShip As New bsOrderShip
                Dim dtOrderShip As New dsOrderShip.OrderShipDataTable
                Dim rwOrdership As dsOrderShip.OrderShipRow
                rwOrdership = dtOrderShip.NewOrderShipRow
                With rwOrdership
                    .OrderHeaderUID = OrderHeaderUID
                    .InventUID = PhInvent._InventUID
                    .Qty = dgvShip.CurrentRow.Cells(4).Value
                End With
                dgvShip.CurrentRow.Cells(0).Value = bsOrderShip.InsertOrderShip(rwOrdership)
            ElseIf RowUpdated = 1 Then
                If dgvShip.CurrentRow.Cells(0).Value > 0 Then
                    PhInvent._ItemQty = dgvShip.CurrentRow.Cells(7).Value
                    PhInvent.UpdateShip(dgvShip.CurrentRow.Cells(0).Value)
                         End If

            End If
            RowAdded = 0
            RowUpdated = 0
            'Here we have to mark the order for Shipping Status
            Dim OrderHeaderInfo As New bsOrderHeader
            OrderHeaderInfo.OrderHeaderStatus(ddlOrderNo.SelectedValue, "S")
        End If
    End Sub

    Private Sub dgvShip_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgvShip.UserAddedRow
        RowAdded = 1
    End Sub
    Private Sub btnBOL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBOL.Click
        'Get Data to populate Report
        Dim bsOrderdetail As New bsOrderDetail
        Dim dtrptBOL As New dsOrderDetail.dsrptBOLDataTable
        dtrptBOL = bsOrderdetail.GetBOLRpt(ddlOrderNo.SelectedValue)
        Dim rptWriter As New Ht_rptWriter.rptWriter
        If dtrptBOL.Rows.Count > 0 Then
            rptWriter.rptdoc = "C:\Users\dmoore.SEALDSWEET\Documents\Visual Studio 2008\Projects\HT_OrderEntry\HT_OrderEntry\rptBOL.rdlc"
            rptWriter.Datatable1 = dtrptBOL
            rptWriter.datasetName1 = "dsOrderDetail_dsrptBOL"
            rptWriter.Show()
        End If
        'Marking the Order for Invoicing
        Dim bsOrderheader As New bsOrderHeader
        bsOrderheader.OrderHeaderStatus(OrderHeaderUID, "I")
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnPrintTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintTicket.Click
        'Here we are going to print the Pick Ticket Report
        Dim rptWriter As New Ht_rptWriter.rptWriter
        Dim dsrptPickticket As New dsOrderDetail.dsrptPickTicketDataTable
        Dim bsOrderDetail As New bsOrderDetail
        dsrptPickticket = bsOrderDetail.GetPickTicketData(OrderHeaderUID)
        If dsrptPickticket.Rows.Count > 0 Then
            rptWriter.rptdoc = "C:\Users\dmoore.SEALDSWEET\Documents\Visual Studio 2008\Projects\HT_OrderEntry\HT_OrderEntry\rptPickTicket.rdlc"
            rptWriter.Datatable1 = dsrptPickticket
            rptWriter.datasetName1 = "dsOrderDetail_dsrptPickTicket"
            rptWriter.Show()
        Else
            MsgBox("There was an Error, No Items set to Ship")
        End If
    End Sub
End Class