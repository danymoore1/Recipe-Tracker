Imports HT_Business
Imports HT_Recipe.HT_Recipe
Public Class frmRecipe
    Public RecipehdrUID As Integer
    Private Sub frmRecipe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load the Recipe Drop Down
        LoadRecipeDrop()
        'Load the Item Drop Down
        LoadItemDrop()
    End Sub
    Private Sub LoadRecipeDrop()
        Dim bsRecipeHdr As New bsRecipeHdr
        ddlRecipe.DataSource = bsRecipeHdr.GetAllRecipeHdr
    End Sub
    Private Sub LoadItemDrop()
        Dim bsItem As New bsItemMaster
        ddlItemNo.DataSource = bsItem.GetItemsByITemType("FIN")
        'ddlItemNo.DataSource = bsItem.GetItemsbyItemType("CT")
    End Sub

    Private Sub ddlRecipe_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlRecipe.Leave
        If ddlRecipe.SelectedValue > 0 Then
            Dim bsRecipeHDR As New bsRecipeHdr
            Dim rw As dsRecipeHdr.RecipeHdrRow
            rw = bsRecipeHDR.GetRecipeHdrbyHeaderUID(ddlRecipe.SelectedValue)
            RecipehdrUID = rw.RecipeHdrUID
            With rw
                txtChefName.Text = .RecipeChef
                txtRecipeDesc.Text = .RecipeDesc
                txtRecipeName.Text = .RecipeName
                ddlItemNo.SelectedValue = .FinishedItemUID
                numMinTrays.Value = .MinAmt
                numTrays.Value = .MaxAmt
                numShelfLife.Value = .ShelfLifeDays
            End With
        End If
        If ddlRecipe.Text <> "" And RecipehdrUID < 1 Then
            Text = "Adding New Recipe"
            btnSave.Text = "Add"
        Else
            Text = "Updating Recipe " & ddlRecipe.Text
            btnSave.Text = "Update"
        End If
        If ddlRecipe.Text = "" And RecipehdrUID < 1 Then
            MsgBox("You Must Select A Recipe First", MsgBoxStyle.Information, "Alert")

        End If
    End Sub

    Private Sub ddlRecipe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlRecipe.SelectedIndexChanged
        If Not ddlRecipe.SelectedIndex = -1 Then
            'Here we have to load the Recipe onto the Form
            Dim rwRecipeHdr As dsRecipeHdr.RecipeHdrRow

            Dim bsRecipeHdr As New bsRecipeHdr
            rwRecipeHdr = bsRecipeHdr.GetRecipeHdrbyHeaderUID(ddlRecipe.SelectedValue)
            numTrays.Value = rwRecipeHdr.MaxAmt
            numMinTrays.Value = rwRecipeHdr.MinAmt
            txtChefName.Text = rwRecipeHdr.RecipeChef
            txtRecipeDesc.Text = rwRecipeHdr.RecipeDesc
            txtRecipeName.Text = rwRecipeHdr.RecipeName
            numShelfLife.Value = rwRecipeHdr.ShelfLifeDays
            ddlItemNo.SelectedValue = rwRecipeHdr.FinishedItemUID
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim bsRecipe As New bsRecipeHdr
        Dim dtRecipe As New dsRecipeHdr.RecipeHdrDataTable
        Dim rwRecipe As dsRecipeHdr.RecipeHdrRow
        If RecipehdrUID > 0 Then
            rwRecipe = bsRecipe.GetRecipeHdrbyHeaderUID(RecipehdrUID)
        Else
            rwRecipe = dtRecipe.NewRecipeHdrRow
        End If
        'Either we are adding it or updating it.
        'Let's Check
        With rwRecipe
            .RecipeID = ddlRecipe.Text
            .RecipeChef = txtChefName.Text
            .RecipeDesc = txtRecipeDesc.Text
            .RecipeName = txtRecipeName.Text
            .MinAmt = numMinTrays.Value
            .MaxAmt = numTrays.Value
            .ShelfLifeDays = numShelfLife.Value
            .FinishedItemUID = ddlItemNo.SelectedValue
        End With
        If btnSave.Text = "Update" Then
            'Update Recipe
            'rwRecipe.RecipeHdrUID = 0
            bsRecipe.UpdateRecipeHdr(rwRecipe)
        ElseIf btnSave.Text = "Add" Then
            'insert the Recipe
            bsRecipe.InsertRecipeHdr(rwRecipe)
        End If
        LoadRecipeDrop()
    End Sub

    Private Sub lnkIngredients_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkIngredients.LinkClicked
        Dim frmRecipeDtl As New frmRecipeDtl
        frmRecipeDtl.RecipeHdrUID = RecipehdrUID
        frmRecipeDtl.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class