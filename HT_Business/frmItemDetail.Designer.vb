<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemDetail
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
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.ddlVendor = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.ddlUOM = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.numSafetyNetAmt = New System.Windows.Forms.NumericUpDown
        Me.Label10 = New System.Windows.Forms.Label
        Me.numLeadDays = New System.Windows.Forms.NumericUpDown
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtmPhDate = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.ddlItemGroup = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ddlItemType = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtItemDesc = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtItemNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        CType(Me.numSafetyNetAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numLeadDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 239)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 15)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Price"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(11, 256)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 55
        '
        'ddlVendor
        '
        Me.ddlVendor.DisplayMember = "VendorCode"
        Me.ddlVendor.FormattingEnabled = True
        Me.ddlVendor.Location = New System.Drawing.Point(321, 266)
        Me.ddlVendor.Name = "ddlVendor"
        Me.ddlVendor.Size = New System.Drawing.Size(125, 23)
        Me.ddlVendor.TabIndex = 54
        Me.ddlVendor.ValueMember = "vendorUID"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(321, 244)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 15)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Default Vendor"
        '
        'ddlUOM
        '
        Me.ddlUOM.DisplayMember = "UOM"
        Me.ddlUOM.FormattingEnabled = True
        Me.ddlUOM.Location = New System.Drawing.Point(321, 211)
        Me.ddlUOM.Name = "ddlUOM"
        Me.ddlUOM.Size = New System.Drawing.Size(125, 23)
        Me.ddlUOM.TabIndex = 52
        Me.ddlUOM.ValueMember = "UOMUID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(321, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 15)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Unit Of Measure"
        '
        'numSafetyNetAmt
        '
        Me.numSafetyNetAmt.Location = New System.Drawing.Point(321, 160)
        Me.numSafetyNetAmt.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.numSafetyNetAmt.Name = "numSafetyNetAmt"
        Me.numSafetyNetAmt.Size = New System.Drawing.Size(83, 20)
        Me.numSafetyNetAmt.TabIndex = 50
        Me.numSafetyNetAmt.Tag = "Qty Before Auto Alert And Creation Of PO"
        Me.numSafetyNetAmt.ThousandsSeparator = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(321, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 15)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Safety Net"
        '
        'numLeadDays
        '
        Me.numLeadDays.Location = New System.Drawing.Point(321, 109)
        Me.numLeadDays.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.numLeadDays.Name = "numLeadDays"
        Me.numLeadDays.Size = New System.Drawing.Size(83, 20)
        Me.numLeadDays.TabIndex = 48
        Me.numLeadDays.Tag = "Amount Of Days To Receive Product From Order Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(321, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 15)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Lead Days"
        '
        'dtmPhDate
        '
        Me.dtmPhDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmPhDate.Location = New System.Drawing.Point(321, 58)
        Me.dtmPhDate.Name = "dtmPhDate"
        Me.dtmPhDate.Size = New System.Drawing.Size(129, 20)
        Me.dtmPhDate.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(321, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 15)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Last Phy Date"
        '
        'ddlItemGroup
        '
        Me.ddlItemGroup.DisplayMember = "ItemGroup"
        Me.ddlItemGroup.FormattingEnabled = True
        Me.ddlItemGroup.Location = New System.Drawing.Point(11, 211)
        Me.ddlItemGroup.Name = "ddlItemGroup"
        Me.ddlItemGroup.Size = New System.Drawing.Size(140, 23)
        Me.ddlItemGroup.TabIndex = 38
        Me.ddlItemGroup.ValueMember = "ItemgrpUID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Item Group"
        '
        'ddlItemType
        '
        Me.ddlItemType.DisplayMember = "ItemType"
        Me.ddlItemType.FormattingEnabled = True
        Me.ddlItemType.Location = New System.Drawing.Point(11, 160)
        Me.ddlItemType.Name = "ddlItemType"
        Me.ddlItemType.Size = New System.Drawing.Size(140, 23)
        Me.ddlItemType.TabIndex = 36
        Me.ddlItemType.ValueMember = "ItemTypeUID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Item Type"
        '
        'txtItemDesc
        '
        Me.txtItemDesc.Location = New System.Drawing.Point(11, 109)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(212, 20)
        Me.txtItemDesc.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Item Description"
        '
        'txtItemNo
        '
        Me.txtItemNo.Location = New System.Drawing.Point(11, 58)
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Size = New System.Drawing.Size(215, 20)
        Me.txtItemNo.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Item #"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(499, 24)
        Me.MenuStrip1.TabIndex = 57
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
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(14, 405)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 58
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(375, 405)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 59
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmItemDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 440)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.ddlVendor)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ddlUOM)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.numSafetyNetAmt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.numLeadDays)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtmPhDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ddlItemGroup)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ddlItemType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtItemDesc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtItemNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmItemDetail"
        Me.Text = "Item Details"
        CType(Me.numSafetyNetAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numLeadDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents ddlVendor As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ddlUOM As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents numSafetyNetAmt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents numLeadDays As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtmPhDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ddlItemGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ddlItemType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtItemDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtItemNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
