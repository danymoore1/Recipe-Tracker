<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchase
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabItems = New System.Windows.Forms.TabPage
        Me.dgvPurchase = New System.Windows.Forms.DataGridView
        Me.tabMessages = New System.Windows.Forms.TabPage
        Me.dgvPONotes = New System.Windows.Forms.DataGridView
        Me.POMessageUID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BornOn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PoNotes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tabOther = New System.Windows.Forms.TabPage
        Me.btnPOReceived = New System.Windows.Forms.Button
        Me.btnPrintPO = New System.Windows.Forms.Button
        Me.txtFreightAmt = New System.Windows.Forms.MaskedTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.ddlDeliveryTerms = New System.Windows.Forms.ComboBox
        Me.ddlDeliveryMethod = New System.Windows.Forms.ComboBox
        Me.ddlFreightTerms = New System.Windows.Forms.ComboBox
        Me.ddlPaymentTerms = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.dtmBornOn = New System.Windows.Forms.DateTimePicker
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.ddlVendor = New MTGCComboBox
        Me.dtmActDelvDate = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtmEstDelvDate = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblPOStatus = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblZip = New System.Windows.Forms.Label
        Me.lblState = New System.Windows.Forms.Label
        Me.lblCity = New System.Windows.Forms.Label
        Me.lblAddr1 = New System.Windows.Forms.Label
        Me.lblVendorName = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ddlPurchaseOrder = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl1.SuspendLayout()
        Me.TabItems.SuspendLayout()
        CType(Me.dgvPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMessages.SuspendLayout()
        CType(Me.dgvPONotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOther.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TabControl1.Controls.Add(Me.TabItems)
        Me.TabControl1.Controls.Add(Me.tabMessages)
        Me.TabControl1.Controls.Add(Me.tabOther)
        Me.TabControl1.Location = New System.Drawing.Point(3, 198)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(851, 359)
        Me.TabControl1.TabIndex = 48
        '
        'TabItems
        '
        Me.TabItems.Controls.Add(Me.dgvPurchase)
        Me.TabItems.Location = New System.Drawing.Point(4, 22)
        Me.TabItems.Name = "TabItems"
        Me.TabItems.Padding = New System.Windows.Forms.Padding(3)
        Me.TabItems.Size = New System.Drawing.Size(843, 333)
        Me.TabItems.TabIndex = 0
        Me.TabItems.Text = "Items"
        Me.TabItems.UseVisualStyleBackColor = True
        '
        'dgvPurchase
        '
        Me.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPurchase.Location = New System.Drawing.Point(7, 7)
        Me.dgvPurchase.Name = "dgvPurchase"
        Me.dgvPurchase.Size = New System.Drawing.Size(816, 314)
        Me.dgvPurchase.TabIndex = 0
        '
        'tabMessages
        '
        Me.tabMessages.Controls.Add(Me.dgvPONotes)
        Me.tabMessages.Location = New System.Drawing.Point(4, 22)
        Me.tabMessages.Name = "tabMessages"
        Me.tabMessages.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMessages.Size = New System.Drawing.Size(843, 333)
        Me.tabMessages.TabIndex = 1
        Me.tabMessages.Text = "Notes"
        Me.tabMessages.UseVisualStyleBackColor = True
        '
        'dgvPONotes
        '
        Me.dgvPONotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPONotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.POMessageUID, Me.UserName, Me.BornOn, Me.PoNotes})
        Me.dgvPONotes.Location = New System.Drawing.Point(6, 6)
        Me.dgvPONotes.Name = "dgvPONotes"
        Me.dgvPONotes.Size = New System.Drawing.Size(816, 301)
        Me.dgvPONotes.TabIndex = 0
        '
        'POMessageUID
        '
        Me.POMessageUID.DataPropertyName = "POMessageUID"
        Me.POMessageUID.HeaderText = "Column1"
        Me.POMessageUID.Name = "POMessageUID"
        Me.POMessageUID.Visible = False
        '
        'UserName
        '
        Me.UserName.DataPropertyName = "UserName"
        Me.UserName.HeaderText = "User #"
        Me.UserName.Name = "UserName"
        '
        'BornOn
        '
        Me.BornOn.DataPropertyName = "BornOn"
        Me.BornOn.HeaderText = "Date Added"
        Me.BornOn.Name = "BornOn"
        '
        'PoNotes
        '
        Me.PoNotes.DataPropertyName = "PoNotes"
        Me.PoNotes.HeaderText = "Message"
        Me.PoNotes.Name = "PoNotes"
        Me.PoNotes.Width = 450
        '
        'tabOther
        '
        Me.tabOther.Controls.Add(Me.btnPOReceived)
        Me.tabOther.Controls.Add(Me.btnPrintPO)
        Me.tabOther.Location = New System.Drawing.Point(4, 22)
        Me.tabOther.Name = "tabOther"
        Me.tabOther.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOther.Size = New System.Drawing.Size(843, 333)
        Me.tabOther.TabIndex = 2
        Me.tabOther.Text = "Other"
        Me.tabOther.UseVisualStyleBackColor = True
        '
        'btnPOReceived
        '
        Me.btnPOReceived.Location = New System.Drawing.Point(54, 54)
        Me.btnPOReceived.Name = "btnPOReceived"
        Me.btnPOReceived.Size = New System.Drawing.Size(142, 23)
        Me.btnPOReceived.TabIndex = 3
        Me.btnPOReceived.Text = "Print PO Received Report"
        Me.btnPOReceived.UseVisualStyleBackColor = True
        '
        'btnPrintPO
        '
        Me.btnPrintPO.Location = New System.Drawing.Point(54, 12)
        Me.btnPrintPO.Name = "btnPrintPO"
        Me.btnPrintPO.Size = New System.Drawing.Size(142, 23)
        Me.btnPrintPO.TabIndex = 2
        Me.btnPrintPO.Text = "Print Purchase Order"
        Me.btnPrintPO.UseVisualStyleBackColor = True
        '
        'txtFreightAmt
        '
        Me.txtFreightAmt.Location = New System.Drawing.Point(731, 150)
        Me.txtFreightAmt.Name = "txtFreightAmt"
        Me.txtFreightAmt.Size = New System.Drawing.Size(100, 20)
        Me.txtFreightAmt.TabIndex = 68
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(626, 151)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Freight Amt:"
        '
        'ddlDeliveryTerms
        '
        Me.ddlDeliveryTerms.DisplayMember = "DeliveryTerms"
        Me.ddlDeliveryTerms.FormattingEnabled = True
        Me.ddlDeliveryTerms.Location = New System.Drawing.Point(731, 116)
        Me.ddlDeliveryTerms.Name = "ddlDeliveryTerms"
        Me.ddlDeliveryTerms.Size = New System.Drawing.Size(121, 21)
        Me.ddlDeliveryTerms.TabIndex = 36
        Me.ddlDeliveryTerms.ValueMember = "DeliveryTUID"
        '
        'ddlDeliveryMethod
        '
        Me.ddlDeliveryMethod.DisplayMember = "DeliveryCode"
        Me.ddlDeliveryMethod.FormattingEnabled = True
        Me.ddlDeliveryMethod.Location = New System.Drawing.Point(731, 87)
        Me.ddlDeliveryMethod.Name = "ddlDeliveryMethod"
        Me.ddlDeliveryMethod.Size = New System.Drawing.Size(121, 21)
        Me.ddlDeliveryMethod.TabIndex = 66
        Me.ddlDeliveryMethod.ValueMember = "DeliveryUID"
        '
        'ddlFreightTerms
        '
        Me.ddlFreightTerms.DisplayMember = "ShipTerms"
        Me.ddlFreightTerms.FormattingEnabled = True
        Me.ddlFreightTerms.Location = New System.Drawing.Point(731, 58)
        Me.ddlFreightTerms.Name = "ddlFreightTerms"
        Me.ddlFreightTerms.Size = New System.Drawing.Size(121, 21)
        Me.ddlFreightTerms.TabIndex = 65
        Me.ddlFreightTerms.ValueMember = "ShipTermsUID"
        '
        'ddlPaymentTerms
        '
        Me.ddlPaymentTerms.DisplayMember = "NetTerms"
        Me.ddlPaymentTerms.FormattingEnabled = True
        Me.ddlPaymentTerms.Location = New System.Drawing.Point(731, 29)
        Me.ddlPaymentTerms.Name = "ddlPaymentTerms"
        Me.ddlPaymentTerms.Size = New System.Drawing.Size(121, 21)
        Me.ddlPaymentTerms.TabIndex = 64
        Me.ddlPaymentTerms.ValueMember = "NetTermsUID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(623, 116)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 13)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Delivery Terms:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(623, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "Delivery Method:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(623, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Freight Terms:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(623, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Payment Terms:"
        '
        'dtmBornOn
        '
        Me.dtmBornOn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmBornOn.Location = New System.Drawing.Point(480, 58)
        Me.dtmBornOn.Name = "dtmBornOn"
        Me.dtmBornOn.Size = New System.Drawing.Size(123, 20)
        Me.dtmBornOn.TabIndex = 59
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(614, 597)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 58
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(1, 609)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 57
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'ddlVendor
        '
        Me.ddlVendor.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.ddlVendor.ArrowColor = System.Drawing.Color.Black
        Me.ddlVendor.BindedControl = Nothing
        Me.ddlVendor.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.ddlVendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ddlVendor.ColumnNum = 3
        Me.ddlVendor.ColumnWidth = "50;120;5"
        Me.ddlVendor.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.ddlVendor.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.ddlVendor.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.ddlVendor.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.ddlVendor.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.ddlVendor.DisplayMember = "Text"
        Me.ddlVendor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ddlVendor.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ddlVendor.DropDownForeColor = System.Drawing.Color.Black
        Me.ddlVendor.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.ddlVendor.DropDownWidth = 195
        Me.ddlVendor.GridLineColor = System.Drawing.Color.LightGray
        Me.ddlVendor.GridLineHorizontal = False
        Me.ddlVendor.GridLineVertical = False
        Me.ddlVendor.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.ddlVendor.Location = New System.Drawing.Point(122, 75)
        Me.ddlVendor.ManagingFastMouseMoving = True
        Me.ddlVendor.ManagingFastMouseMovingInterval = 30
        Me.ddlVendor.Name = "ddlVendor"
        Me.ddlVendor.SelectedItem = Nothing
        Me.ddlVendor.SelectedValue = Nothing
        Me.ddlVendor.Size = New System.Drawing.Size(121, 21)
        Me.ddlVendor.TabIndex = 56
        Me.ddlVendor.ValueMember = "VendorUID"
        '
        'dtmActDelvDate
        '
        Me.dtmActDelvDate.Enabled = False
        Me.dtmActDelvDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmActDelvDate.Location = New System.Drawing.Point(480, 107)
        Me.dtmActDelvDate.Name = "dtmActDelvDate"
        Me.dtmActDelvDate.Size = New System.Drawing.Size(123, 20)
        Me.dtmActDelvDate.TabIndex = 55
        Me.dtmActDelvDate.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(313, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Actual Delivery Date:"
        '
        'dtmEstDelvDate
        '
        Me.dtmEstDelvDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmEstDelvDate.Location = New System.Drawing.Point(480, 80)
        Me.dtmEstDelvDate.Name = "dtmEstDelvDate"
        Me.dtmEstDelvDate.Size = New System.Drawing.Size(123, 20)
        Me.dtmEstDelvDate.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(313, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Estimated Delv Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(313, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Order Date:"
        '
        'lblPOStatus
        '
        Me.lblPOStatus.AutoSize = True
        Me.lblPOStatus.Location = New System.Drawing.Point(474, 38)
        Me.lblPOStatus.Name = "lblPOStatus"
        Me.lblPOStatus.Size = New System.Drawing.Size(39, 13)
        Me.lblPOStatus.TabIndex = 50
        Me.lblPOStatus.Text = "Label7"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(313, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Purchase Order Status:"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(357, 146)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(45, 13)
        Me.lblZip.TabIndex = 47
        Me.lblZip.Text = "Label10"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(271, 146)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(39, 13)
        Me.lblState.TabIndex = 46
        Me.lblState.Text = "Label9"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(122, 146)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(39, 13)
        Me.lblCity.TabIndex = 45
        Me.lblCity.Text = "Label8"
        '
        'lblAddr1
        '
        Me.lblAddr1.AutoSize = True
        Me.lblAddr1.Location = New System.Drawing.Point(122, 127)
        Me.lblAddr1.Name = "lblAddr1"
        Me.lblAddr1.Size = New System.Drawing.Size(39, 13)
        Me.lblAddr1.TabIndex = 44
        Me.lblAddr1.Text = "Label7"
        '
        'lblVendorName
        '
        Me.lblVendorName.AutoSize = True
        Me.lblVendorName.Location = New System.Drawing.Point(122, 108)
        Me.lblVendorName.Name = "lblVendorName"
        Me.lblVendorName.Size = New System.Drawing.Size(39, 13)
        Me.lblVendorName.TabIndex = 43
        Me.lblVendorName.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "City/State/Zip:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Vendor:"
        '
        'ddlPurchaseOrder
        '
        Me.ddlPurchaseOrder.DisplayMember = "PONO"
        Me.ddlPurchaseOrder.FormattingEnabled = True
        Me.ddlPurchaseOrder.Location = New System.Drawing.Point(122, 40)
        Me.ddlPurchaseOrder.Name = "ddlPurchaseOrder"
        Me.ddlPurchaseOrder.Size = New System.Drawing.Size(121, 21)
        Me.ddlPurchaseOrder.TabIndex = 38
        Me.ddlPurchaseOrder.ValueMember = "POheaderUID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Purchase Order #:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(866, 24)
        Me.MenuStrip1.TabIndex = 37
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
        'frmPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 643)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtFreightAmt)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ddlDeliveryTerms)
        Me.Controls.Add(Me.ddlDeliveryMethod)
        Me.Controls.Add(Me.ddlFreightTerms)
        Me.Controls.Add(Me.ddlPaymentTerms)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtmBornOn)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.ddlVendor)
        Me.Controls.Add(Me.dtmActDelvDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtmEstDelvDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblPOStatus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddr1)
        Me.Controls.Add(Me.lblVendorName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ddlPurchaseOrder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmPurchase"
        Me.Text = "frmPurchase"
        Me.TabControl1.ResumeLayout(False)
        Me.TabItems.ResumeLayout(False)
        CType(Me.dgvPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMessages.ResumeLayout(False)
        CType(Me.dgvPONotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOther.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabItems As System.Windows.Forms.TabPage
    Friend WithEvents dgvPurchase As System.Windows.Forms.DataGridView
    Friend WithEvents tabMessages As System.Windows.Forms.TabPage
    Friend WithEvents dgvPONotes As System.Windows.Forms.DataGridView
    Friend WithEvents POMessageUID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BornOn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PoNotes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tabOther As System.Windows.Forms.TabPage
    Friend WithEvents btnPOReceived As System.Windows.Forms.Button
    Friend WithEvents btnPrintPO As System.Windows.Forms.Button
    Friend WithEvents txtFreightAmt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ddlDeliveryTerms As System.Windows.Forms.ComboBox
    Friend WithEvents ddlDeliveryMethod As System.Windows.Forms.ComboBox
    Friend WithEvents ddlFreightTerms As System.Windows.Forms.ComboBox
    Friend WithEvents ddlPaymentTerms As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtmBornOn As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents ddlVendor As MTGCComboBox
    Friend WithEvents dtmActDelvDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtmEstDelvDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblPOStatus As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblAddr1 As System.Windows.Forms.Label
    Friend WithEvents lblVendorName As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ddlPurchaseOrder As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
