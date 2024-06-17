Public Class frmCustomerPricing
    Public CusPackUID As Integer
    Public UserUID As Integer
    Private CustPriceUID As Integer
    Private Sub frmCustomerPricing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlItemInfo.Visible = False
        'Load drop down box
        LoadDropDown()
        lstPricing.DataSource = Nothing
        lstPricing.DisplayMember = "Custprice"
        lstPricing.ValueMember = "CustPriceUID"
        If CusPackUID > 0 Then
            ddlCustomerItem.SelectedValue = CusPackUID
        Else

        End If
    End Sub
    Private Sub LoadDropDown()
        Dim bs As New bsCustomerPackHdr
        ddlCustomerItem.DataSource = bs.GetAllCustomerPackHdr
        ddlCustomerItem.SelectedIndex = -1
    End Sub
    Private Sub LoadLstPricing()

        If Not ddlCustomerItem.SelectedIndex = -1 Then
            Dim bs As New bsCustomerPricing
            lstPricing.DataSource = bs.GetCustomerPricesLst(ddlCustomerItem.SelectedValue)
        End If
    End Sub

    Private Sub ddlCustomerItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlCustomerItem.SelectedIndexChanged
        LoadLstPricing()
        pnlItemInfo.Visible = False
    End Sub

    Private Sub lnkAdd_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAdd.LinkClicked
        If ddlCustomerItem.SelectedValue > 0 Then
            pnlItemInfo.Visible = True
            txtItemNo.Text = ddlCustomerItem.Text
            ctxtCasePrice.Text = "$0.00"
            CtxtTrayPrice.Text = "$0.00"
            CustPriceUID = 0
            CusPackUID = ddlCustomerItem.SelectedValue
        End If
    End Sub

    Private Sub lnkCancel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCancel.LinkClicked
        Me.pnlItemInfo.Visible = False
    End Sub

    Private Sub lnkEdit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkEdit.LinkClicked
        If ddlCustomerItem.SelectedValue > 0 Then
            If Not lstPricing.SelectedValue Is Nothing Then
                CustPriceUID = lstPricing.SelectedValue
                txtItemNo.Text = ddlCustomerItem.Text
                CusPackUID = ddlCustomerItem.SelectedValue
                Dim bs As New bsCustomerPricing
                Dim rw As dsCustomerPricing.CustomerPricingRow
                rw = bs.GetPricebyCustPriceUID(CustPriceUID)
                pnlItemInfo.Visible = True
                With rw
                    dtmfrmdate.Text = .FrmDte
                    dtmtodate.Text = .ToDte
                    CusPackUID = CusPackUID
                    CustPriceUID = .CustPriceUID
                    ctxtCasePrice.Text = .CaseCost
                    CtxtTrayPrice.Text = .TrayCost
                End With
            End If
        End If
    End Sub
    Private Sub lnkUpdate_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkUpdate.LinkClicked
        Dim dt As New dsCustomerPricing.CustomerPricingDataTable
        Dim rw As dsCustomerPricing.CustomerPricingRow
        Dim bs As New bsCustomerPricing
        rw = dt.NewCustomerPricingRow
        With rw
            .CaseCost = ctxtCasePrice.Text
            .CuspackUID = CusPackUID
            .CustPriceUID = CustPriceUID
            .TrayCost = CtxtTrayPrice.Text
            .FrmDte = dtmfrmdate.Text
            .ToDte = dtmtodate.Text
        End With
        If CustPriceUID = 0 Then
            bs.InsertCustomerPricing(rw)
        Else
            bs.UpdateCustomerPricing(rw)
        End If
        pnlItemInfo.Visible = False
        CustPriceUID = 0
        LoadLstPricing()
    End Sub

    Private Sub lnkDelete_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkDelete.LinkClicked
        If ddlCustomerItem.SelectedValue > 0 Then
            If Not lstPricing.SelectedValue Is Nothing Then
                Dim bs As New bsCustomerPricing
                bs.DeleteCustomerPricing(lstPricing.SelectedValue)
                LoadLstPricing()
            End If
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class