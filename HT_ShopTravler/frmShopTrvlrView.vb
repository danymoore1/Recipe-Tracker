Public Class frmShopTrvlrView
    Public UserUID As Integer
    Private Sub frmShopTrvlrView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadShopTravelers()
    End Sub
    Private Sub LoadShopTravelers()
        Dim bs As New bsShopTravelerDtl
        dgvShopTraveler.AutoGenerateColumns = False
        dgvShopTraveler.DataSource = bs.GetShopTravelerGrid

    End Sub

    Private Sub CloseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Dim frmShopTraveler As New frmAddShopTrvlr
        frmShopTraveler.UserUID = UserUID
        frmShopTraveler.ShowDialog()
        LoadShopTravelers()
    End Sub

    Private Sub CompleteTravelerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompleteTravelerToolStripMenuItem.Click
        If dgvShopTraveler.CurrentRow.Cells(7).Value = 0 Then
            Dim frmReceiveTraveler As New frmCompleteShopTrvlr
            frmReceiveTraveler.TravelerUID = dgvShopTraveler.CurrentRow.Cells(0).Value
            frmReceiveTraveler.ShowDialog()
        Else
            MsgBox("This ShopTraveler Has already been completed! Please Select Another")
        End If
    End Sub

    Private Sub ReceiveShopTravelerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiveShopTravelerToolStripMenuItem.Click
        If dgvShopTraveler.CurrentRow.Cells(7).Value = 0 Then
            Dim frmReceiveTraveler As New frmCompleteShopTrvlr
            frmReceiveTraveler.TravelerUID = dgvShopTraveler.CurrentRow.Cells(0).Value
            frmReceiveTraveler.ShowDialog()
        Else
            MsgBox("This ShopTraveler Has already been completed! Please Select Another")
        End If
    End Sub

    Private Sub EditShopTravelerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditShopTravelerToolStripMenuItem.Click
        If dgvShopTraveler.CurrentRow.Cells(7).Value = 0 Then
            Dim frmShopTraveler As New frmAddShopTrvlr
            frmShopTraveler.TravelerUID = dgvShopTraveler.CurrentRow.Cells(0).Value
            frmShopTraveler.UserUID = UserUID
            frmShopTraveler.Show()
        Else
            MsgBox("This ShopTraveler Has already been completed! Please Select Another")
        End If
    End Sub

    Private Sub EditShopTravelerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditShopTravelerToolStripMenuItem1.Click
        If dgvShopTraveler.CurrentRow.Cells(7).Value = 0 Then
            Dim frmShopTraveler As New frmAddShopTrvlr
            frmShopTraveler.TravelerUID = dgvShopTraveler.CurrentRow.Cells(0).Value
            frmShopTraveler.UserUID = UserUID
            frmShopTraveler.Show()
        Else
            MsgBox("This ShopTraveler Has already been completed! Please Select Another")
        End If
    End Sub

    Private Sub AddShopTravelerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddShopTravelerToolStripMenuItem.Click
        Dim frmShopTraveler As New frmAddShopTrvlr
        frmShopTraveler.UserUID = UserUID
        frmShopTraveler.ShowDialog()
        LoadShopTravelers()
    End Sub
End Class