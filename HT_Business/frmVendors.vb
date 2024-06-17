Public Class frmVendors

    Private Sub frmVendors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDropDowns()
    End Sub

    Private Sub LoadDropDowns()
        Dim bs As New bsVendors
        ddlVendor.DataSource = bs.GetAllVendors
    End Sub
    Private Sub ddlVendor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlVendor.Leave
        Dim Found As Integer = ddlVendor.FindString(ddlVendor.Text)
        If Found > -1 Then
            Text = "Updating Vendor Code " & ddlVendor.Text
            btnUpdate.Text = "Update"
            LoadVendor()
        Else
            Text = "Adding Vendor Code " & ddlVendor.Text
            btnUpdate.Text = "Add"
        End If
    End Sub
    Private Sub LoadVendor()
        Dim bs As New bsVendors
        Dim dt As New dsVendor.VendorDataTable
        Dim rw As dsVendor.VendorRow
        rw = bs.GetVendorbyUID(ddlVendor.SelectedValue)
        If Not rw Is Nothing Then
            With rw
                txtVendorName.Text = .VendorName
                txtAddr1.Text = .Addr1
                txtAddr2.Text = .Addr2
                txtCity.Text = .City
                txtState.Text = .State
                txtZip.Text = .Zip
                chkActive.Checked = .InActive
                txtPhone.Text = .Phone
                txtFax.Text = .Fax
            End With
        End If
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim bs As New bsVendors
        Dim dt As New dsVendor.VendorDataTable
        Dim rw As dsVendor.VendorRow
        rw = dt.NewVendorRow
        With rw
            .VendorCode = ddlVendor.Text
            .VendorName = txtVendorName.Text
            .Addr1 = txtAddr1.Text
            .Addr2 = txtAddr2.Text
            .City = txtCity.Text
            .State = txtState.Text
            .Zip = txtZip.Text
            .InActive = chkActive.Checked
            .Phone = txtPhone.Text
            .Fax = txtFax.Text
        End With
        If btnUpdate.Text = "Update" Then
            rw.VendorUID = ddlVendor.SelectedValue
            bs.UpdateVendor(rw)
            Text = "Vendor " & ddlVendor.Text & " Updated Successfully"
        ElseIf btnUpdate.Text = "Add" Then
            Dim IC As Integer = bs.InsertVendor(rw)
            If IC > 0 Then
                Text = "Added Vendor Code " & ddlVendor.Text & " Successfully"
            Else
                MsgBox("An Error Occured, Please Contact Support")
            End If
        End If
        LoadDropDowns()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub CToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CToolStripMenuItem.Click
        Me.Close()
    End Sub

  
End Class