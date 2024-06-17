Public Class frmCustomerItem
    Public CuspackUID As Integer
    Public UserUID As Integer
    Private Sub frmCustomerItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCustomerItems()
        LoadCustomers()
        If CuspackUID > 0 Then
            'Here the Form was called so we are going to load the Customer ITem selected
            Dim bsCusPackHdr As New HT_Business.bsCustomerPackHdr
            Dim dtCusPackhdr As New HT_Business.dsCustomerPackHdr.CustomerPackHdrDataTable
            Dim RwCusPackHdr As HT_Business.dsCustomerPackHdr.CustomerPackHdrRow
            RwCusPackHdr = bsCusPackHdr.GetCustomerPackHdr(CuspackUID)
            With RwCusPackHdr
                txtCustomerItemNo.Text = .CustomerItemNo
                txtItemDesc.Text = .CusPackDesc
                ddlCustomerItem.SelectedValue = .ItemUID
                ddlCustomer.SelectedValue = .CustUID
            End With
        Else
            'Here we are going to add a new Customer Item #

        End If
    End Sub
    Private Sub LoadCustomerItems()
        Dim bsCustpackHdr As New HT_Business.bsItemMaster
        ddlCustomerItem.DataSource = bsCustpackHdr.GetAllCTTrays
    End Sub
    Private Sub LoadCustomers()
        Dim bsCustomer As New HT_Business.bsCustomer
        ddlCustomer.DataSource = bsCustomer.GetAllCustomers
    End Sub

    Private Sub lnkPrices_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkPrices.LinkClicked
        If CuspackUID <= 0 Then
            MsgBox("Please Click Update to Add Customer Item #")

        End If
    End Sub

    Private Sub lnkMangeItems_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkMangeItems.LinkClicked
        If CuspackUID <= 0 Then
            MsgBox("Please Click Update to Add Customer Item #")

        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim bsCusPackHdr As New HT_Business.bsCustomerPackHdr
        Dim dtCusPackHdr As New HT_Business.dsCustomerPackHdr.CustomerPackHdrDataTable
        Dim RwCusPackHdr As HT_Business.dsCustomerPackHdr.CustomerPackHdrRow
        RwCusPackHdr = dtCusPackHdr.NewCustomerPackHdrRow
        With RwCusPackHdr
            .CusPackDesc = txtItemDesc.Text
            .CustomerItemNo = txtCustomerItemNo.Text
            .CustUID = ddlCustomer.SelectedValue
            .ItemUID = ddlCustomerItem.SelectedValue
            .CusPackUID = CuspackUID
        End With
        If CuspackUID > 0 Then
            'Update Current
            bsCusPackHdr.UpdateCustomerPackHdr(RwCusPackHdr)
        Else
            'Add Current
            CuspackUID = bsCusPackHdr.InsertCustomerPackHdr(RwCusPackHdr)
        End If
    End Sub
End Class