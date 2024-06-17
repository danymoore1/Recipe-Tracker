<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerItem
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
        Me.ddlCustomer = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ddlCustomerItem = New System.Windows.Forms.ComboBox
        Me.txtCustomerItemNo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lnkPrices = New System.Windows.Forms.LinkLabel
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lnkMangeItems = New System.Windows.Forms.LinkLabel
        Me.txtItemDesc = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ddlCustomer
        '
        Me.ddlCustomer.DisplayMember = "CustCode"
        Me.ddlCustomer.FormattingEnabled = True
        Me.ddlCustomer.Location = New System.Drawing.Point(14, 242)
        Me.ddlCustomer.Name = "ddlCustomer"
        Me.ddlCustomer.Size = New System.Drawing.Size(163, 23)
        Me.ddlCustomer.TabIndex = 29
        Me.ddlCustomer.ValueMember = "CustUID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Customer:"
        '
        'ddlCustomerItem
        '
        Me.ddlCustomerItem.DisplayMember = "ItemNo"
        Me.ddlCustomerItem.FormattingEnabled = True
        Me.ddlCustomerItem.Location = New System.Drawing.Point(14, 67)
        Me.ddlCustomerItem.Name = "ddlCustomerItem"
        Me.ddlCustomerItem.Size = New System.Drawing.Size(163, 23)
        Me.ddlCustomerItem.TabIndex = 26
        Me.ddlCustomerItem.ValueMember = "ItemUID"
        '
        'txtCustomerItemNo
        '
        Me.txtCustomerItemNo.Location = New System.Drawing.Point(14, 184)
        Me.txtCustomerItemNo.Name = "txtCustomerItemNo"
        Me.txtCustomerItemNo.Size = New System.Drawing.Size(163, 20)
        Me.txtCustomerItemNo.TabIndex = 44
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 15)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Customer Item #:"
        '
        'lnkPrices
        '
        Me.lnkPrices.AutoSize = True
        Me.lnkPrices.Location = New System.Drawing.Point(140, 298)
        Me.lnkPrices.Name = "lnkPrices"
        Me.lnkPrices.Size = New System.Drawing.Size(88, 15)
        Me.lnkPrices.TabIndex = 45
        Me.lnkPrices.TabStop = True
        Me.lnkPrices.Text = "Manage Prices"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(14, 367)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(101, 31)
        Me.btnUpdate.TabIndex = 30
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(286, 367)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(101, 31)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
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
        'lnkMangeItems
        '
        Me.lnkMangeItems.AutoSize = True
        Me.lnkMangeItems.Location = New System.Drawing.Point(140, 317)
        Me.lnkMangeItems.Name = "lnkMangeItems"
        Me.lnkMangeItems.Size = New System.Drawing.Size(83, 15)
        Me.lnkMangeItems.TabIndex = 32
        Me.lnkMangeItems.TabStop = True
        Me.lnkMangeItems.Text = "Manage Items"
        '
        'txtItemDesc
        '
        Me.txtItemDesc.Location = New System.Drawing.Point(14, 131)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(272, 20)
        Me.txtItemDesc.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Item Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Item:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(433, 24)
        Me.MenuStrip1.TabIndex = 33
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'frmCustomerItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 425)
        Me.Controls.Add(Me.ddlCustomer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ddlCustomerItem)
        Me.Controls.Add(Me.txtCustomerItemNo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lnkPrices)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lnkMangeItems)
        Me.Controls.Add(Me.txtItemDesc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmCustomerItem"
        Me.Text = "Customer Items"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ddlCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ddlCustomerItem As System.Windows.Forms.ComboBox
    Friend WithEvents txtCustomerItemNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lnkPrices As System.Windows.Forms.LinkLabel
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lnkMangeItems As System.Windows.Forms.LinkLabel
    Friend WithEvents txtItemDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
End Class
