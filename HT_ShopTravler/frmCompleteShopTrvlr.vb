Imports System.Windows.Forms
Imports HT_Inventory.HT_Inventory
Public Class frmCompleteShopTrvlr
    Public TravelerUID As Integer
    Public UserUID As Integer
    Private Sub frmCompleteShopTrvlr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTrayQty.Text = ""
        'Load the Drop Down
        LoadDropDown()
        If TravelerUID > 0 Then
            ddlShopTraveler.SelectedValue = TravelerUID
        End If
    End Sub
    Private Sub LoadDropDown()
        Dim bsShopHdr As New bsShopTravelerHdr
        ddlShopTraveler.DataSource = bsShopHdr.GetAllShopTravelers
    End Sub
    Private Sub BuildGrid()
        'Lets build the grid
        dgvShopTraveler.Columns.Clear()
        dgvShopTraveler.AutoGenerateColumns = False
        'Key field
        Dim ShopdtlUID As New DataGridViewTextBoxColumn
        ShopdtlUID.Visible = False
        ShopdtlUID.Name = "ShopdtlUID"
        ShopdtlUID.DataPropertyName = "ShopDtlUID"
        dgvShopTraveler.Columns.Add(ShopdtlUID)
        dgvShopTraveler.Columns(0).Visible = False
        Dim ItemNo As New DataGridViewComboBoxColumn
        ItemNo.DisplayMember = "ItemNo"
        ItemNo.ValueMember = "ItemUID"
        ItemNo.HeaderText = "Item #"
        ItemNo.Name = "ItemUID"
        ItemNo.DataPropertyName = "ItemNo"
        'Now we got to load the Combo box
        Dim itembs As New HT_Business.bsItemMaster
        ItemNo.DataSource = itembs.GetAllItemMaster
        dgvShopTraveler.Columns.Add(ItemNo)
        'Load the Lot
        Dim Lotno As New DataGridViewTextBoxColumn
        Lotno.DataPropertyName = "Lotno"
        Lotno.Name = "Lotno"
        Lotno.HeaderText = "Lot #"
        dgvShopTraveler.Columns.Add(Lotno)
        'Load qty for Order
        Dim Qty As New DataGridViewTextBoxColumn
        Qty.DataPropertyName = "Qty"
        Qty.Name = "Qty"
        Qty.HeaderText = "Qty"
        dgvShopTraveler.Columns.Add(Qty)
        'Load the actual grid
        Dim gridbs As New bsShopTravelerDtl
        Dim dt As New DataTable
        Dim rw As DataRow
        rw = dt.NewRow
        dt = gridbs.GetShopDtlGrid(TravelerUID)
        For Each rw In dt.Rows
            Dim rw1 As New DataGridViewRow
            Dim dvcell As DataGridViewCell
            dvcell = New DataGridViewTextBoxCell
            dvcell.Value = rw(0)
            rw1.Cells.Add(dvcell)
            dvcell = New DataGridViewTextBoxCell
            dvcell.Value = rw(1)
            rw1.Cells.Add(dvcell)
            dvcell = New DataGridViewTextBoxCell
            dvcell.Value = rw(2)
            rw1.Cells.Add(dvcell)
            dvcell = New DataGridViewTextBoxCell
            dvcell.Value = rw(3)
            rw1.Cells.Add(dvcell)
            dgvShopTraveler.Rows.Add(rw1)
        Next
    End Sub

    Private Sub ddlShopTraveler_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlShopTraveler.SelectedIndexChanged
        If ddlShopTraveler.SelectedIndex > -1 Then
            TravelerUID = ddlShopTraveler.SelectedValue
            BuildGrid()
            'Here we also have to load the Qtys and default numtrays to total Amount to be Created
            Dim bsShopTrvlr As New bsShopTravelerHdr
            Dim rw As dsShopTrvlrHdr.ShopTravelerRow
            rw = bsShopTrvlr.GetShopTrvlrHdrByTrvlrUID(TravelerUID)
            lblTrayQty.Text = rw.Qty
            numTrays.Value = rw.Qty - rw.CompletedQty
        End If
    End Sub


    ''' <summary>
    ''' Here we are going to add the Record into the Table and then output the ShopDetailUID to the grid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvShopTraveler_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvShopTraveler.RowValidating
        'Added a new Record
        'First check to see if Lot # is valid and has enough qty
        Dim bsInvent As New HT_Inventory.bsInvent
        Dim rw As dsInventory.InventRow

        rw = bsInvent.GetInventByITemUIDLotno(dgvShopTraveler.CurrentRow.Cells(2).Value, dgvShopTraveler.CurrentRow.Cells(3).Value)
        If rw.InventUID > 0 Then
            Dim bsshopdtl As New bsShopTravelerDtl
            Dim dtShopdtl As New dsShopTrvlrDtl.shopTravelerDtlDataTable
            Dim rwShopdtl As dsShopTrvlrDtl.shopTravelerDtlRow
            rwShopdtl = dtShopdtl.NewshopTravelerDtlRow
            With rwShopdtl
                .Qty = dgvShopTraveler.CurrentRow.Cells(3).Value
                .InventUID = rw.InventUID
                .TravelerUID = TravelerUID
            End With
            dgvShopTraveler.CurrentRow.Cells(0).Value = bsshopdtl.InsertShoptrvlrDtl(rwShopdtl)
        Else
            MsgBox("Could Not Find Record, Please try again")
            dgvShopTraveler.CurrentRow.Cells(1).Value = ""
            dgvShopTraveler.CurrentRow.Cells(3).Value = 0
            dgvShopTraveler.CurrentRow.Selected = True
        End If
    End Sub

    ''' <summary>
    ''' This deletes the record from the Shop Traveler DTL table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvShopTraveler_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles dgvShopTraveler.UserDeletingRow
        Dim bsShopTrvlrDtl As New bsShopTravelerDtl
        bsShopTrvlrDtl.DeleteShopTrvlrDTL(dgvShopTraveler.CurrentRow.Cells(0).Value)
    End Sub
    Private Sub btnComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComplete.Click
        'First Check to see if we have already depleted Ingreidents
        If Not TravelerUID = 0 Then
            Dim bsShopTrvlr As New bsShopTravelerHdr
            Dim dtShopTrvlr As New dsShopTrvlrHdr.ShopTravelerDataTable
            Dim rwshoptrvlr As dsShopTrvlrHdr.ShopTravelerRow
            rwshoptrvlr = dtShopTrvlr.NewShopTravelerRow
            rwshoptrvlr = bsShopTrvlr.GetShopTrvlrHdrByTrvlrUID(TravelerUID)
            'if Completed is greater than 0, then already depleted Ingreidents.....Else
            If rwshoptrvlr.CompletedQty = 0 Then
                DepleteIngreidents()
            End If
            'Determine if Closing the shop Traveler
            Select Case chkClose.Checked
                Case True
                    'Create Trays in Inventory and Close Shop Traveler
                    With rwshoptrvlr
                        .Complete = True
                        .CompletedQty += numTrays.Value
                        .CompleteDte = Today.Date
                    End With
                Case False
                    'Create Trays in Inventory and Leave Shop Traveler Open
                    With rwshoptrvlr
                        .Complete = False
                        .CompletedQty += numTrays.Value
                        .CompleteDte = "01/01/1900"
                    End With
            End Select
            bsShopTrvlr.UpdateShopTrvlrHdr(rwshoptrvlr)
            CreateTrayInventory()
            If chkClose.Checked = True Then
                Me.Close()
            End If
        Else
            MsgBox("Must Select Traveler before completing", MsgBoxStyle.Information, "Hot Trak")
        End If
    End Sub
    Public Sub DepleteIngreidents()
        Dim bsInvent As New Ht_Inventory.bsInvent
        bsInvent.DepleteShopIngred(TravelerUID)
    End Sub
    Public Sub CreateTrayInventory()
        Dim bsShopDtl As New bsShopTravelerDtl
        bsShopDtl.CreateShopTrays(TravelerUID, numTrays.Value, Today.Date, UserUID)
    End Sub

    Private Sub CLoseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLoseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class