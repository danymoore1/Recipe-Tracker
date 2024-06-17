Public Class frmAutoShipping

    Private Sub frmAutoShipping_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bs As New bsOrderHeader
        dgvshipping.DataSource = bs.GetAutoShipping(CDate(dtmSchShipDte.Text))
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Dim bs As New bsOrderHeader
        dgvshipping.AutoGenerateColumns = False
        dgvshipping.DataSource = bs.GetAutoShipping(CDate(dtmSchShipDte.Text))
    End Sub

    Private Sub dgvshipping_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvshipping.DoubleClick
        Dim frmShipping As New frmShip
        frmShipping.Orderno = dgvshipping.CurrentRow.Cells(0).Value
        frmShipping.Show()
    End Sub

    Private Sub btnPickTickets_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPickTickets.Click

    End Sub
End Class