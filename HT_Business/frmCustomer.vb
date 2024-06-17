Public Class frmCustomer
    Public CustUID As Integer
    Public dtCust As New dsCustomer.CustomerDataTable
    Private Sub Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCustomerDrop()
        LoaddDropDowns()
    End Sub
    Private Sub LoadCustomerDrop()
        Dim bscust As New bsCustomer
        Dim bsTerms As New bsTerms
        'Loading the Customer Code drop Down
        dtCust = bscust.GetAllCustomers
        Dim rw As dsCustomer.CustomerRow
        rw = dtCust.NewCustomerRow
        'rw.Item(3) = "Select One"
        'dtCust.Rows.Add(rw)
        Me.ddlCustCode.DataSource = dtCust
        'Me.ddlCustCode.SelectedIndex = Me.ddlCustCode.FindString("Select One")
        ddlCustCode.Text = "Select One"
    End Sub
    ''' <summary>
    ''' This loads all Combo Drop Downs for the Form
    ''' Developer: Danny Moore
    ''' Date:      12/24/2009
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoaddDropDowns()
        Dim bscust As New bsCustomer
        Dim bsTerms As New bsTerms
        'Loading the Customer Code drop Down
        dtCust = bscust.GetAllCustomers
        '    Dim rw As dsCustomer.CustomerRow
        '     rw = dtCust.NewCustomerRow
        'rw.Item(3) = "Select One"
        'dtCust.Rows.Add(rw)
        '      Me.ddlCustCode.DataSource = dtCust
        'Me.ddlCustCode.SelectedIndex = Me.ddlCustCode.FindString("Select One")
        '       ddlCustCode.Text = "Select One"
        'Loading the BillTo Customer Drop Down
        Dim dt As New DataTable
        dt = bscust.GetBillToCustomers
        Dim rw1 As DataRow
        rw1 = dt.NewRow
        ' rw1.Item(0) = "Select One"
        dt.Rows.Add(rw1)
        Me.ddlBillTo.DataSource = dt
        Me.ddlBillTo.SelectedIndex = Me.ddlBillTo.FindString("Select One")
        'Loading the ShipTerms Drop Down
        dt = New DataTable
        dt = bsTerms.GetAllShipTerms
        rw1 = dt.NewRow
        'rw1.Item(1) = "Select One"
        'dt.Rows.Add(rw1)
        Me.ddlShipTerms.DataSource = dt
        'Me.ddlShipTerms.SelectedIndex = Me.ddlShipTerms.FindString("Select One")
        ddlShipTerms.Text = "Select One"
        'Loading the NetTerms drop Down
        dt = New DataTable
        dt = bsTerms.GetAllNetTerms
        rw1 = dt.NewRow
        'rw1.Item(1) = "Select One"
        'dt.Rows.Add(rw1)
        Me.ddlNetTerms.DataSource = dt
        'Me.ddlNetTerms.SelectedIndex = Me.ddlNetTerms.FindString("Select One")
        ddlNetTerms.Text = "Select One"
    End Sub
    ''' <summary>
    ''' Developer:    Danny Moore
    ''' Date:         12/24/2009
    ''' Description:  Determines if adding a customer or updating Customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ddlCustCode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlCustCode.Leave

        Dim CustCode As String = Me.ddlCustCode.Text
        Dim Found As Integer = Me.ddlCustCode.FindString(CustCode)
        If Found < 0 Then
            Me.Text = "Add Customer: " & ddlCustCode.Text
            Me.btnUpdate.Text = "Add"
            chkInactive.Checked = False
        Else
            Me.Text = "Update Customer: " & ddlCustCode.Text
            Me.btnUpdate.Text = "Update"
            LoadAllFields()
        End If
    End Sub
    ''' <summary>
    ''' Developer:   Danny Moore
    ''' Date:        12/24/2009
    ''' Description: Load All fields on Form if Customer Code is found
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadAllFields()
        Dim bs As New bsCustomer
        Dim rwCustomer As dsCustomer.CustomerRow
        rwCustomer = bs.GetCustomerByCustCode(Me.ddlCustCode.Text)
        Me.txtName.Text = rwCustomer.CustName
        Me.txtAddr1.Text = rwCustomer.Address1
        Me.txtaddr2.Text = rwCustomer.Address2
        Me.txtCity.Text = rwCustomer.City
        Me.txtState.Text = rwCustomer.State
        Me.txtZip.Text = rwCustomer.Zip
        Me.txtPhone.Text = rwCustomer.Phone
        Me.txtFax.Text = rwCustomer.Fax
        Me.txtContact.Text = rwCustomer.Contact
        Me.txtEmail.Text = rwCustomer.Email
        Me.numShelfLive.Value = rwCustomer.AllowDays
        If rwCustomer.Inactive > 0 Then
            chkInactive.Checked = True
        Else
            chkInactive.Checked = False
        End If
        Me.ddlBillTo.SelectedValue = rwCustomer.BillToCode
        Me.ddlNetTerms.SelectedValue = rwCustomer.NetTermsUID
        Me.ddlShipTerms.SelectedValue = rwCustomer.ShipTermsUID
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim BillCode As String
        If ddlBillTo.Text = "Select One" Then
            BillCode = 0
        Else
            BillCode = ddlBillTo.SelectedValue
        End If
        Dim bs As New bsCustomer
        Dim rw As dsCustomer.CustomerRow
        Dim dt As New dsCustomer.CustomerDataTable
        rw = dt.NewCustomerRow
        rw.AllowDays = Me.numShelfLive.Value
        rw.Address1 = txtAddr1.Text
        rw.Address2 = txtaddr2.Text
        rw.City = txtCity.Text
        rw.State = txtState.Text
        rw.Zip = txtZip.Text
        rw.Phone = txtPhone.Text
        rw.Fax = txtFax.Text
        rw.Email = txtEmail.Text
        rw.Contact = txtContact.Text
        rw.NetTermsUID = ddlNetTerms.SelectedValue
        rw.ShipTermsUID = ddlShipTerms.SelectedValue
        rw.BillToCode = BillCode
        rw.CustName = txtName.Text
        rw.Inactive = chkInactive.Checked
        rw.CustCode = ddlCustCode.Text
        Select Case Me.btnUpdate.Text
            Case "Update"
                rw.CustUID = ddlCustCode.SelectedValue
                bs.UpdateCustomer(rw)
            Case "Add"
                bs.InsertCustomer(rw)
        End Select
        LoadCustomerDrop()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub CloseToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class