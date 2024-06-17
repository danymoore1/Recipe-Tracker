Public Class frmItemMaster

    Private Sub frmItemMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadGrid()

    End Sub

    Private Sub LoadGrid()

        Dim bs As New bsItemMaster
        Dim dt As New DsItemMaster.ItemGridDataTable
        dt = bs.GetItemGrid
        dgItemMaster.AutoGenerateColumns = False
        dgItemMaster.DataSource = dt

    End Sub

    Private Sub dgItemMaster_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgItemMaster.DoubleClick
        Dim frmItemDetail As New frmItemDetail
        frmItemDetail.ItemUID = dgItemMaster.Item(0, dgItemMaster.CurrentRow.Index).Value
        frmItemDetail.ShowDialog()
        dgItemMaster.DataSource = Nothing
        LoadGrid()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub AddItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddItemToolStripMenuItem.Click
        Dim frmItemDetail As New frmItemDetail
        frmItemDetail.ShowDialog()
        dgItemMaster.DataSource = Nothing
        LoadGrid()
    End Sub
End Class