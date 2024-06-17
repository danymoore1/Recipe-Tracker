Public Class frmlstCustomerItems
    Public UserUID As Integer
    Private Sub frmlstCustomerItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub
    Private Sub LoadGrid()
        Dim bsCusPackHdr As New bsCustomerPackHdr
        dgvCustomerItem.DataSource = bsCusPackHdr.GetCustomerPackLst
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        Dim frmCustomerItem As New frmCustomerItem
        frmCustomerItem.UserUID = UserUID
        frmCustomerItem.ShowDialog()
        LoadGrid()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim FrmCustomerItem As New frmCustomerItem
        FrmCustomerItem.UserUID = UserUID
        Try

            FrmCustomerItem.CuspackUID = dgvCustomerItem.CurrentRow.Cells(0).Value

        Catch ex As Exception

        End Try
        FrmCustomerItem.ShowDialog()
        LoadGrid()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class