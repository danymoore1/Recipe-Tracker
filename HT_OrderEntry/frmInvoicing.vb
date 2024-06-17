Public Class frmInvoicing

    Private Sub frmInvoicing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'here we have to load all invoices ready to be printed
        'we need to capture orders with an SC status.....SC = Shipping Complete
        LoadListbox()
    End Sub
    Private Sub LoadListbox()
        chklInvoices.Items.Clear()
        Dim bs As New bsOrderHeader
        Dim dt As New dsOrderHeader.OrderHeaderDataTable
        Dim rw As dsOrderHeader.OrderHeaderRow
        dt = bs.GetOrderByStatus("I")
        rw = dt.NewOrderHeaderRow
        For Each rw In dt
            chklInvoices.Items.Add(rw.OrderNo, False)
        Next
    End Sub
    Private Sub lnkSelectAll_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkSelectAll.LinkClicked
        Dim counter As Integer = chklInvoices.Items.Count
        Dim I As Integer = 0
        For I = 0 To counter - 1
            chklInvoices.SetItemChecked(I, True)
        Next
    End Sub
    Private Sub lnkDeselectAll_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkDeselectAll.LinkClicked
        Dim counter As Integer = chklInvoices.Items.Count
        Dim i As Integer = 0
        For i = 0 To counter - 1
            chklInvoices.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim Counter As Integer = chklInvoices.CheckedItems.Count
        Dim bsOrderHeader As New bsOrderHeader
        bsOrderHeader.DeletewktmpInv()
        Dim i As Integer = 0
        For i = 0 To Counter - 1
            Dim Orderno As String = chklInvoices.CheckedItems(i).ToString
            bsOrderHeader.InsertwkTmpInv(Orderno)
        Next
        PrintInvoices()
    End Sub
    Private Sub PrintInvoices()
        Dim rptWriter As New Ht_rptWriter.rptWriter
        Dim Dt As New DataTable
        Dim bsOrderheader As New bsOrderHeader
        Dt = bsOrderheader.GetInvoiceHeader
        rptWriter.rptdoc = "C:\Users\dmoore.SEALDSWEET\Documents\Visual Studio 2008\Projects\HT_OrderEntry\HT_OrderEntry\rptInv.rdlc"
        rptWriter.datasetName1 = "dsOrderHeader_invRpt"
        rptWriter.Datatable1 = Dt
        rptWriter.ShowDialog()
        bsOrderheader.CompleteInvoice()
        LoadListbox()
    End Sub
End Class