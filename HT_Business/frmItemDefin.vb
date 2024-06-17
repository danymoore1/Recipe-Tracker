Public Class frmItemDefin
    Private Sub tabItemGrp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabItemGrp.Click
      
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub ItemGrp()
        Dim bsItemGrp As New bsItemGroup
        ddlItemGrp.DataSource = bsItemGrp.GetItemGroupbyItemType(ddlItemType.SelectedValue)
    End Sub
    Private Sub ItemType()
        Dim bsItemType As New bsItemType
        ddlItemType.DataSource = bsItemType.GetAllItemTypes
        ddlItemType.SelectedIndex = -1
    End Sub



    Private Sub ddlItemType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlItemType.SelectedIndexChanged
        If Not ddlItemType.SelectedIndex = -1 Then
            Dim bsItemType As New bsItemType
            Dim rwItemType As dsItemType.ItemTypeRow
            rwItemType = bsItemType.GetItemType(ddlItemType.SelectedValue)
            txtItemTypeDesc.Text = rwItemType.ItemTypeDesc
        End If
    End Sub

    Private Sub frmItemDefin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ItemType()
    End Sub

    Private Sub btnGUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGUpdate.Click
        Dim Found As Integer = ddlItemGrp.FindString(ddlItemGrp.Text)
        Dim bsitemGrp As New bsItemGroup
        Dim dtItemgrp As New dsItemGroup.ItemGroupDataTable
        Dim rwItemgrp As dsItemGroup.ItemGroupRow
        Dim ReloadInt As Integer = -1
        rwItemgrp = dtItemgrp.NewItemGroupRow
        With rwItemgrp
            .ItemGroup = ddlItemGrp.Text
            .ItemGrpDesc = txtItemgrpDesc.Text
            .ItemGrpUID = ddlItemGrp.SelectedValue
            .ItemTypeUID = ddlItemType.SelectedValue
        End With
        If Found = -1 Then
            'insert
            ReloadInt = bsitemGrp.InsertItemGrp(rwItemgrp)
        Else
            'Update
            ReloadInt = ddlItemGrp.SelectedValue
            bsitemGrp.UpdateItemGrp(rwItemgrp)
        End If
        ItemGrp()
        ddlItemGrp.SelectedValue = ReloadInt
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim Found As Integer = ddlItemType.FindString(ddlItemType.Text)
        Dim bsItemType As New bsItemType
        Dim dtItemType As New dsItemType.ItemTypeDataTable
        Dim rwItemType As dsItemType.ItemTypeRow
        Dim ReloadInt As Integer = -1
        rwItemType = dtItemType.NewItemTypeRow
        With rwItemType
            .ItemTypeDesc = txtItemTypeDesc.Text
            .ItemType = ddlItemType.Text
            .ItemTypeUID = ddlItemType.SelectedValue

        End With
        If Found = -1 Then
            'OK did not find Record, so we are going to Assume that we Must Add it
            ReloadInt = bsItemType.InsertItemType(rwItemType)
        Else
            'Found Record so we are going to Update
            ReloadInt = ddlItemType.SelectedValue
            bsItemType.UpdateItemType(rwItemType)
        End If
        ItemType()
        Me.ddlItemType.SelectedValue = ReloadInt
    End Sub

    Private Sub ddlItemGrp_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlItemGrp.SelectedIndexChanged
        If Not ddlItemGrp.SelectedIndex = -1 Then
            'Load the description and allow to change
            Dim bsITemgrp As New bsItemGroup
            Dim rwItemGrp As dsItemGroup.ItemGroupRow
            rwItemGrp = bsITemgrp.GetItemGroupByUID(ddlItemGrp.SelectedValue)
            txtItemgrpDesc.Text = rwItemGrp.ItemGrpDesc
        End If
    End Sub

    Private Sub btnGCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGCancel.Click
        Me.Close()
    End Sub

    Private Sub tabItemType_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabItemType.Leave
        If ddlItemType.SelectedIndex = -1 Then
            MsgBox("You Must First Select an Item Type")
        Else
            ItemGrp()
        End If
    End Sub
End Class