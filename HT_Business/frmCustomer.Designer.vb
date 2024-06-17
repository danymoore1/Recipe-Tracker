<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.numShelfLive = New System.Windows.Forms.NumericUpDown
        Me.Label13 = New System.Windows.Forms.Label
        Me.chkInactive = New System.Windows.Forms.CheckBox
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.ddlNetTerms = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.ddlShipTerms = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtFax = New System.Windows.Forms.MaskedTextBox
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtZip = New System.Windows.Forms.TextBox
        Me.txtState = New System.Windows.Forms.TextBox
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.txtaddr2 = New System.Windows.Forms.TextBox
        Me.txtAddr1 = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ddlCustCode = New System.Windows.Forms.ComboBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ddlBillTo = New System.Windows.Forms.ComboBox
        CType(Me.numShelfLive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'numShelfLive
        '
        Me.numShelfLive.Location = New System.Drawing.Point(136, 396)
        Me.numShelfLive.Name = "numShelfLive"
        Me.numShelfLive.Size = New System.Drawing.Size(65, 20)
        Me.numShelfLive.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 400)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 15)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Allowable Days:"
        '
        'chkInactive
        '
        Me.chkInactive.AutoSize = True
        Me.chkInactive.Location = New System.Drawing.Point(137, 432)
        Me.chkInactive.Name = "chkInactive"
        Me.chkInactive.Size = New System.Drawing.Size(70, 19)
        Me.chkInactive.TabIndex = 12
        Me.chkInactive.Text = "Inactive"
        Me.chkInactive.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUpdate.Location = New System.Drawing.Point(10, 464)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(101, 31)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancel.Location = New System.Drawing.Point(711, 464)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(101, 31)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ddlNetTerms
        '
        Me.ddlNetTerms.DisplayMember = "NetTerms"
        Me.ddlNetTerms.FormattingEnabled = True
        Me.ddlNetTerms.Location = New System.Drawing.Point(687, 116)
        Me.ddlNetTerms.Name = "ddlNetTerms"
        Me.ddlNetTerms.Size = New System.Drawing.Size(124, 23)
        Me.ddlNetTerms.TabIndex = 15
        Me.ddlNetTerms.ValueMember = "NetTermsUID"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(589, 123)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 15)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Net Terms:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(589, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 15)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Ship Terms:"
        '
        'ddlShipTerms
        '
        Me.ddlShipTerms.DisplayMember = "ShipTermDesc"
        Me.ddlShipTerms.FormattingEnabled = True
        Me.ddlShipTerms.Location = New System.Drawing.Point(687, 81)
        Me.ddlShipTerms.Name = "ddlShipTerms"
        Me.ddlShipTerms.Size = New System.Drawing.Size(124, 23)
        Me.ddlShipTerms.TabIndex = 14
        Me.ddlShipTerms.ValueMember = "ShipTermsUID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 325)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 15)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Contact:"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(137, 318)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(346, 20)
        Me.txtContact.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 361)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 15)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(136, 353)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(346, 20)
        Me.txtEmail.TabIndex = 10
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(136, 281)
        Me.txtFax.Mask = "(999) 000-0000"
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(135, 20)
        Me.txtFax.TabIndex = 8
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(136, 245)
        Me.txtPhone.Mask = "(999) 000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(135, 20)
        Me.txtPhone.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 290)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 15)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Fax:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 15)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Phone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 15)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "City/State/Zip:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Address 2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Address 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(589, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Bill To Code:"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(403, 190)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(135, 20)
        Me.txtZip.TabIndex = 6
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(349, 190)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(42, 20)
        Me.txtState.TabIndex = 5
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(136, 190)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(202, 20)
        Me.txtCity.TabIndex = 4
        '
        'txtaddr2
        '
        Me.txtaddr2.Location = New System.Drawing.Point(136, 154)
        Me.txtaddr2.Name = "txtaddr2"
        Me.txtaddr2.Size = New System.Drawing.Size(346, 20)
        Me.txtaddr2.TabIndex = 3
        '
        'txtAddr1
        '
        Me.txtAddr1.Location = New System.Drawing.Point(136, 117)
        Me.txtAddr1.Name = "txtAddr1"
        Me.txtAddr1.Size = New System.Drawing.Size(346, 20)
        Me.txtAddr1.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(136, 81)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(308, 20)
        Me.txtName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Customer Code:"
        '
        'ddlCustCode
        '
        Me.ddlCustCode.DisplayMember = "CustCode"
        Me.ddlCustCode.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ddlCustCode.FormattingEnabled = True
        Me.ddlCustCode.Location = New System.Drawing.Point(137, 44)
        Me.ddlCustCode.Name = "ddlCustCode"
        Me.ddlCustCode.Size = New System.Drawing.Size(114, 23)
        Me.ddlCustCode.TabIndex = 0
        Me.ddlCustCode.Tag = "Select Customer Code - or Insert New"
        Me.ddlCustCode.ValueMember = "CustUID"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(864, 24)
        Me.MenuStrip1.TabIndex = 63
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "&Close"
        '
        'ddlBillTo
        '
        Me.ddlBillTo.DisplayMember = "CustCode"
        Me.ddlBillTo.FormattingEnabled = True
        Me.ddlBillTo.Location = New System.Drawing.Point(687, 46)
        Me.ddlBillTo.Name = "ddlBillTo"
        Me.ddlBillTo.Size = New System.Drawing.Size(121, 23)
        Me.ddlBillTo.TabIndex = 13
        Me.ddlBillTo.ValueMember = "CustUID"
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 508)
        Me.Controls.Add(Me.ddlBillTo)
        Me.Controls.Add(Me.numShelfLive)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.chkInactive)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.ddlNetTerms)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ddlShipTerms)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtaddr2)
        Me.Controls.Add(Me.txtAddr1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ddlCustCode)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCustomer"
        Me.Text = "frmCustomer"
        CType(Me.numShelfLive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents numShelfLive As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chkInactive As System.Windows.Forms.CheckBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ddlNetTerms As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ddlShipTerms As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtFax As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtaddr2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddr1 As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ddlCustCode As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ddlBillTo As System.Windows.Forms.ComboBox
End Class
