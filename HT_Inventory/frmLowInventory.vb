Public Class frmLowInventory
    Public UserUID As Integer
    Private Sub frmLowInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadLowINventoryGrid()
    End Sub
    Private Sub LoadLowInventoryGrid()
        Dim bsInvent As New bsInvent
        dgvGrid.DataSource = bsInvent.GetLowINventory
    End Sub

    Private Sub CreateNewPurchaseOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNewPurchaseOrderToolStripMenuItem.Click
        Dim frmCreatePO As New ht_PurchaseModule.frmPurchase
        frmCreatePO.TransItemUID = dgvGrid.CurrentRow.Cells(0).Value
        frmCreatePO.UserUID = UserUID
    End Sub
End Class