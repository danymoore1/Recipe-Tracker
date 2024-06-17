Public Class frmInventory
    Public UserUID As Integer
    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadInventoryGrid()
    End Sub
    Private Sub LoadInventoryGrid()
        Dim bsInvent As New bsInvent

        dgvGrid.DataSource = bsInvent.GetInventory
    End Sub

    Private Sub CreateNewPurchaseOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmCreatePO As New ht_PurchaseModule.frmPurchase

        frmCreatePO.TransItemUID = dgvGrid.CurrentRow.Cells(0).Value
        frmCreatePO.UserUID = UserUID
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class