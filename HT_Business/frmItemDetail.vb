Public Class frmItemDetail
    Public ItemUID As Integer
    Private Sub frmItemDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPrice.Text = 0
        If ItemUID < 1 Then
            Text = "Adding New Item"
            btnUpdate.Text = "Add"
        ElseIf ItemUID >= 1 Then
            Text = "Updating Item"
            btnUpdate.Text = "Update"
        End If
        LoadItemTypes()
        LoadVendors()
        LoadUom()
        LoadItemInfo()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub LoadItemTypes()
        Dim bsItemType As New bsItemType
        ddlItemType.DataSource = bsItemType.GetAllItemTypes
    End Sub
    Private Sub LoadItemGroup()
        Dim bsITemGroup As New bsItemGroup
        ddlItemGroup.DataSource = bsITemGroup.GetItemGroupbyItemType(ddlItemType.SelectedValue)
    End Sub
    Private Sub LoadVendors()
        Dim bsVendor As New bsVendors
        ddlVendor.DataSource = bsVendor.GetAllVendors
    End Sub
    Private Sub LoadUom()
        Dim bsUOM As New bsUOM
        ddlUOM.DataSource = bsUOM.GetAllUOM
    End Sub
    Private Sub LoadItemInfo()
        If ItemUID > 0 Then
            Dim bsItem As New bsItemMaster
            Dim rwItem As DsItemMaster.ItemMasterRow
            rwItem = bsItem.GetItemMasterByItemUID(ItemUID)
            With rwItem
                txtItemDesc.Text = .ItemDesc
                txtItemNo.Text = .ItemNo
                ddlItemGroup.SelectedValue = .ItemGrpUID
                ddlItemType.SelectedValue = .ItemTypeUID
                ddlUOM.SelectedValue = .UOMUID
                dtmPhDate.Text = .lstPhDate
                numLeadDays.Value = .LeadDays
                numSafetyNetAmt.Value = .SafetyNetAmt
                ddlVendor.SelectedValue = .DefaultVendorUID
                txtPrice.Text = .Price
            End With
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub ddlItemType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlItemType.SelectedIndexChanged
        'Get All Item Groups Associated with Item Type
        LoadItemGroup()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim bsItem As New bsItemMaster
        Dim dtItem As New DsItemMaster.ItemMasterDataTable
        Dim rwItem As DsItemMaster.ItemMasterRow
        rwItem = dtItem.NewItemMasterRow
        With rwItem
            .ItemNo = txtItemNo.Text
            .ItemDesc = txtItemDesc.Text
            .ItemGrpUID = ddlItemGroup.SelectedValue
            .ItemTypeUID = ddlItemType.SelectedValue
            .UOMUID = ddlUOM.SelectedValue
            .lstPhDate = dtmPhDate.Text
            .LeadDays = numLeadDays.Value
            .SafetyNetAmt = numSafetyNetAmt.Value
            .DefaultVendorUID = ddlVendor.SelectedValue
            .Price = txtPrice.Text
        End With
        If btnUpdate.Text = "Update" Then
            rwItem.ItemUID = ItemUID
            bsItem.UpdateItemMaster(rwItem)
        Else
            ItemUID = bsItem.InsertItemMaster(rwItem)
        End If
    End Sub
End Class