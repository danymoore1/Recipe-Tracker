Public Class FrmCustpackDtl
    Public CustomerItemHdr As Integer
    Public CustomerItemDtUID As Integer
    Public UserUID As Integer
    Private Sub FrmCustpackDtl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadListbox()
        LoadDropDown()
        pnlItemDtl.Visible = False
    End Sub
    Public Sub LoadListbox()
        Dim bs As New bsCustomerpackDTL
        lstCustomerItemDtl.DataSource = bs.GetCustItemdtl_lst(CustomerItemHdr)
    End Sub
    Public Sub LoadDropDown()
        Dim bs As New bsItemMaster
        ddlItem.DataSource = bs.GetAllItemMaster
    End Sub

    Private Sub lnkAdd_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAdd.LinkClicked
        pnlItemDtl.Visible = True
        numQty.Value = 0
        CustomerItemDtUID = 0
        lnkUpdate.Text = "Add"
    End Sub

    Private Sub lnkEdit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkEdit.LinkClicked
        If lstCustomerItemDtl.SelectedValue > 0 Then
            CustomerItemDtUID = lstCustomerItemDtl.SelectedValue
            pnlItemDtl.Visible = True
            Dim bs As New bsCustomerPackDTL
            Dim dt As New dsCustomerPackDTL.CustomerPackDTLDataTable
            Dim rw As dsCustomerPackDTL.CustomerPackDTLRow
            rw = dt.NewRow
            rw = bs.GetCustomerPackDtl(CustomerItemDtUID)
            With rw
                ddlItem.SelectedValue = .ItemNoUID
                numQty.Value = .Qty
                CustomerItemDtUID = .CusDtlUID
            End With
            lnkUpdate.Text = "Update"
        Else
            MsgBox("Please Select An Item Before Attempting To Edit", MsgBoxStyle.Information, "Hot Trak")
        End If
    End Sub

    Private Sub lnkUpdate_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkUpdate.LinkClicked
        Dim bs As New bsCustomerPackDTL
        Dim dt As New dsCustomerPackDTL.CustomerPackDTLDataTable
        Dim rw As dsCustomerPackDTL.CustomerPackDTLRow
        rw = dt.NewRow
        With rw
            .ItemNoUID = ddlItem.SelectedValue
            .Qty = numQty.Value
            .CustPackUID = CustomerItemHdr
        End With
        If lnkUpdate.Text = "Update" Then
            rw.CusDtlUID = CustomerItemDtUID
            bs.UpdateCustomerPackDtl(rw)
        ElseIf lnkUpdate.Text = "Add" Then
            bs.InsertCustomerPackDtl(rw)
        End If
        LoadListbox()
        pnlItemDtl.Visible = False
    End Sub

    Private Sub lnkCancel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCancel.LinkClicked
        pnlItemDtl.Visible = False
    End Sub

    Private Sub lnkDelete_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkDelete.LinkClicked
        If lstCustomerItemDtl.SelectedValue > 0 Then
            CustomerItemDtUID = lstCustomerItemDtl.SelectedValue
            Dim bs As New bsCustomerPackDTL
            bs.DeleteCuspackDtl(CustomerItemDtUID)
            LoadListbox()
        Else
            MsgBox("Please Select An Item Before Attempting To Delete")
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class