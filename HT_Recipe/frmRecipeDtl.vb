Imports HT_Recipe.HT_Recipe

Public Class frmRecipeDtl
    Public RecipeHdrUID As Integer
    Private RecipeDtlUID As Integer
    Private Sub frmRecipeDtl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlMat.Visible = False
        LoadIngredients()
        LoadItemType()
        LoadUOM()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub LoadItemType()
        Dim bsItemType As New HT_Business.bsItemType
        ddlItemType.DataSource = bsItemType.GetAllItemTypes
    End Sub
    Private Sub LoadddlMaterial()
        ' ddlMaterial.Items.Clear()
        ddlMaterial.Text = ""
        Dim bsItem As New HT_Business.bsItemMaster
        ddlMaterial.DataSource = bsItem.GetItemsbyItemTypeUID(ddlItemType.SelectedValue)
    End Sub
    Private Sub LoadIngredients()
        'This loads the Materials List Box for RecipeHDRUID
        Dim bsRecipeDTl As New bsRecipeDtl
        lstMaterials.DataSource = bsRecipeDTl.GetRecipeDtlItemno(RecipeHdrUID)
    End Sub
    Private Sub LoadUOM()
        Dim bsUOM As New HT_Business.bsUOM
        ddlMatUOM.DataSource = bsUOM.GetAllUOM
    End Sub

    Private Sub lnkAddMat_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAddMat.LinkClicked
        lnkMatUpdate.Text = "Add"
        pnlMat.Visible = True
        numMatQty.Value = 0
        RecipeDtlUID = 0

    End Sub

    Private Sub lnkEditMat_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkEditMat.LinkClicked
        If Not lstMaterials.SelectedValue < 1 Then
            RecipeDtlUID = lstMaterials.SelectedValue
            Dim bsRecipeDtl As New bsRecipeDtl

            Dim rwRecipeDtl As HT_Recipe.dsRecipeDtl.RecipeDTLRow
            rwRecipeDtl = bsRecipeDtl.GetRecipeDtlbyUID(RecipeDtlUID)
            pnlMat.Visible = True
            ddlMaterial.SelectedValue = rwRecipeDtl.ItemUID
            numMatQty.Value = rwRecipeDtl.Qty
            ddlMatUOM.SelectedValue = rwRecipeDtl.UOMUID
            lnkMatUpdate.Text = "Update"
        Else
            MsgBox("You Must Select A Item To Edit", MsgBoxStyle.Information, "HotTrak Error")
        End If
    End Sub

    Private Sub lnkDeleteMat_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkDeleteMat.LinkClicked
        If Not lstMaterials.SelectedValue < 1 Then
            Dim bsRecipeDtl As New bsRecipeDtl
            bsRecipeDtl.DeleteRecipeDtl(lstMaterials.SelectedValue)
            LoadIngredients()
        Else
            MsgBox("You Must Select A Item To Delete", MsgBoxStyle.Information, "HotTrak Error")
        End If

    End Sub

    Private Sub lnkMatCancel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkMatCancel.LinkClicked
        pnlMat.Visible = False
    End Sub

    Private Sub lnkMatUpdate_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkMatUpdate.LinkClicked
        Dim bsRecipeDtl As New bsRecipeDtl
        Dim dtRecipeDtl As New dsRecipeDtl.RecipeDTLDataTable

        Dim rwRecipeDtl As dsRecipeDtl.RecipeDTLRow
        rwRecipeDtl = dtRecipeDtl.NewRecipeDTLRow

        With rwRecipeDtl
            .RecipeHDRUID = RecipeHdrUID
            .Qty = numMatQty.Value
            .ItemUID = ddlMaterial.SelectedValue
            .UOMUID = ddlMatUOM.SelectedValue
        End With
        If lnkMatUpdate.Text = "Update" Then
            rwRecipeDtl.RecipeDTLUID = RecipeDtlUID
            bsRecipeDtl.UpdateRecipeDtl(rwRecipeDtl)
        ElseIf lnkMatUpdate.Text = "Add" Then
            bsRecipeDtl.InsertRecipeDtl(rwRecipeDtl)
        End If
        LoadIngredients()
        pnlMat.Visible = False
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ddlItemType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlItemType.SelectedIndexChanged
        LoadddlMaterial()
    End Sub
End Class