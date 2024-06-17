<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderEntry
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabOrderHeader = New System.Windows.Forms.TabPage
        Me.ddlShipToCode = New MTGCComboBox
        Me.ddlBillToCode = New MTGCComboBox
        Me.ddlSalesRep = New MTGCComboBox
        Me.txtRef = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.txtBillName = New System.Windows.Forms.TextBox
        Me.ddlOrderNo = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtOrderStatus = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtShipAddr2 = New System.Windows.Forms.TextBox
        Me.txtShipZip = New System.Windows.Forms.TextBox
        Me.txtShipState = New System.Windows.Forms.TextBox
        Me.txtShipCity = New System.Windows.Forms.TextBox
        Me.txtShipAddr1 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtBillZip = New System.Windows.Forms.TextBox
        Me.txtBillState = New System.Windows.Forms.TextBox
        Me.txtBillCity = New System.Windows.Forms.TextBox
        Me.txtBllAddr = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.ddlNetTerms = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ddlShipTerms = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtmShipDate = New System.Windows.Forms.DateTimePicker
        Me.txtPONO = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtmOrderDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabOrderDetail = New System.Windows.Forms.TabPage
        Me.dgvOrderDetail = New System.Windows.Forms.DataGridView
        Me.tabMessages = New System.Windows.Forms.TabPage
        Me.dgvOrderMessages = New System.Windows.Forms.DataGridView
        Me.MessageUID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BornOn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MessageNotes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Orderno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tabOther = New System.Windows.Forms.TabPage
        Me.btnPrintOrder = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabOrderHeader.SuspendLayout()
        Me.TabOrderDetail.SuspendLayout()
        CType(Me.dgvOrderDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMessages.SuspendLayout()
        CType(Me.dgvOrderMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOther.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1038, 24)
        Me.MenuStrip1.TabIndex = 3
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
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabOrderHeader)
        Me.TabControl1.Controls.Add(Me.TabOrderDetail)
        Me.TabControl1.Controls.Add(Me.tabMessages)
        Me.TabControl1.Controls.Add(Me.tabOther)
        Me.TabControl1.Location = New System.Drawing.Point(9, 33)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1017, 483)
        Me.TabControl1.TabIndex = 4
        '
        'tabOrderHeader
        '
        Me.tabOrderHeader.Controls.Add(Me.ddlShipToCode)
        Me.tabOrderHeader.Controls.Add(Me.ddlBillToCode)
        Me.tabOrderHeader.Controls.Add(Me.ddlSalesRep)
        Me.tabOrderHeader.Controls.Add(Me.txtRef)
        Me.tabOrderHeader.Controls.Add(Me.Label14)
        Me.tabOrderHeader.Controls.Add(Me.btnCancel)
        Me.tabOrderHeader.Controls.Add(Me.btnUpdate)
        Me.tabOrderHeader.Controls.Add(Me.txtShipName)
        Me.tabOrderHeader.Controls.Add(Me.txtBillName)
        Me.tabOrderHeader.Controls.Add(Me.ddlOrderNo)
        Me.tabOrderHeader.Controls.Add(Me.Label13)
        Me.tabOrderHeader.Controls.Add(Me.txtOrderStatus)
        Me.tabOrderHeader.Controls.Add(Me.Label12)
        Me.tabOrderHeader.Controls.Add(Me.txtShipAddr2)
        Me.tabOrderHeader.Controls.Add(Me.txtShipZip)
        Me.tabOrderHeader.Controls.Add(Me.txtShipState)
        Me.tabOrderHeader.Controls.Add(Me.txtShipCity)
        Me.tabOrderHeader.Controls.Add(Me.txtShipAddr1)
        Me.tabOrderHeader.Controls.Add(Me.Label11)
        Me.tabOrderHeader.Controls.Add(Me.Label10)
        Me.tabOrderHeader.Controls.Add(Me.Label9)
        Me.tabOrderHeader.Controls.Add(Me.txtBillZip)
        Me.tabOrderHeader.Controls.Add(Me.txtBillState)
        Me.tabOrderHeader.Controls.Add(Me.txtBillCity)
        Me.tabOrderHeader.Controls.Add(Me.txtBllAddr)
        Me.tabOrderHeader.Controls.Add(Me.Label8)
        Me.tabOrderHeader.Controls.Add(Me.ddlNetTerms)
        Me.tabOrderHeader.Controls.Add(Me.Label7)
        Me.tabOrderHeader.Controls.Add(Me.ddlShipTerms)
        Me.tabOrderHeader.Controls.Add(Me.Label6)
        Me.tabOrderHeader.Controls.Add(Me.Label5)
        Me.tabOrderHeader.Controls.Add(Me.DateTimePicker1)
        Me.tabOrderHeader.Controls.Add(Me.Label4)
        Me.tabOrderHeader.Controls.Add(Me.dtmShipDate)
        Me.tabOrderHeader.Controls.Add(Me.txtPONO)
        Me.tabOrderHeader.Controls.Add(Me.Label3)
        Me.tabOrderHeader.Controls.Add(Me.dtmOrderDate)
        Me.tabOrderHeader.Controls.Add(Me.Label2)
        Me.tabOrderHeader.Controls.Add(Me.Label1)
        Me.tabOrderHeader.Location = New System.Drawing.Point(4, 24)
        Me.tabOrderHeader.Name = "tabOrderHeader"
        Me.tabOrderHeader.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOrderHeader.Size = New System.Drawing.Size(1009, 455)
        Me.tabOrderHeader.TabIndex = 0
        Me.tabOrderHeader.Text = "Header"
        Me.tabOrderHeader.UseVisualStyleBackColor = True
        '
        'ddlShipToCode
        '
        Me.ddlShipToCode.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.ddlShipToCode.ArrowColor = System.Drawing.Color.Black
        Me.ddlShipToCode.BindedControl = Nothing
        Me.ddlShipToCode.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.ddlShipToCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ddlShipToCode.ColumnNum = 3
        Me.ddlShipToCode.ColumnWidth = "40;60;5"
        Me.ddlShipToCode.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.ddlShipToCode.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.ddlShipToCode.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.ddlShipToCode.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.ddlShipToCode.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.ddlShipToCode.DisplayMember = "Text"
        Me.ddlShipToCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ddlShipToCode.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ddlShipToCode.DropDownForeColor = System.Drawing.Color.Black
        Me.ddlShipToCode.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.ddlShipToCode.DropDownWidth = 141
        Me.ddlShipToCode.GridLineColor = System.Drawing.Color.LightGray
        Me.ddlShipToCode.GridLineHorizontal = False
        Me.ddlShipToCode.GridLineVertical = False
        Me.ddlShipToCode.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.ddlShipToCode.Location = New System.Drawing.Point(154, 112)
        Me.ddlShipToCode.ManagingFastMouseMoving = True
        Me.ddlShipToCode.ManagingFastMouseMovingInterval = 30
        Me.ddlShipToCode.Name = "ddlShipToCode"
        Me.ddlShipToCode.SelectedItem = Nothing
        Me.ddlShipToCode.SelectedValue = Nothing
        Me.ddlShipToCode.Size = New System.Drawing.Size(116, 21)
        Me.ddlShipToCode.TabIndex = 4
        '
        'ddlBillToCode
        '
        Me.ddlBillToCode.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.ddlBillToCode.ArrowColor = System.Drawing.Color.Black
        Me.ddlBillToCode.BindedControl = Nothing
        Me.ddlBillToCode.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.ddlBillToCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ddlBillToCode.ColumnNum = 3
        Me.ddlBillToCode.ColumnWidth = "40;65;5"
        Me.ddlBillToCode.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.ddlBillToCode.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.ddlBillToCode.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.ddlBillToCode.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.ddlBillToCode.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.ddlBillToCode.DisplayMember = "Text"
        Me.ddlBillToCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ddlBillToCode.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ddlBillToCode.DropDownForeColor = System.Drawing.Color.Black
        Me.ddlBillToCode.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.ddlBillToCode.DropDownWidth = 130
        Me.ddlBillToCode.GridLineColor = System.Drawing.Color.LightGray
        Me.ddlBillToCode.GridLineHorizontal = False
        Me.ddlBillToCode.GridLineVertical = True
        Me.ddlBillToCode.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.ddlBillToCode.Location = New System.Drawing.Point(387, 9)
        Me.ddlBillToCode.ManagingFastMouseMoving = True
        Me.ddlBillToCode.ManagingFastMouseMovingInterval = 30
        Me.ddlBillToCode.Name = "ddlBillToCode"
        Me.ddlBillToCode.SelectedItem = Nothing
        Me.ddlBillToCode.SelectedValue = Nothing
        Me.ddlBillToCode.Size = New System.Drawing.Size(102, 21)
        Me.ddlBillToCode.TabIndex = 1
        '
        'ddlSalesRep
        '
        Me.ddlSalesRep.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.ddlSalesRep.ArrowColor = System.Drawing.Color.Black
        Me.ddlSalesRep.BindedControl = Nothing
        Me.ddlSalesRep.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.ddlSalesRep.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ddlSalesRep.ColumnNum = 3
        Me.ddlSalesRep.ColumnWidth = "30;75;10"
        Me.ddlSalesRep.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.ddlSalesRep.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.ddlSalesRep.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.ddlSalesRep.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.ddlSalesRep.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.ddlSalesRep.DisplayMember = "Text"
        Me.ddlSalesRep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ddlSalesRep.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ddlSalesRep.DropDownForeColor = System.Drawing.Color.Black
        Me.ddlSalesRep.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.ddlSalesRep.DropDownWidth = 150
        Me.ddlSalesRep.GridLineColor = System.Drawing.Color.LightGray
        Me.ddlSalesRep.GridLineHorizontal = False
        Me.ddlSalesRep.GridLineVertical = True
        Me.ddlSalesRep.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.ddlSalesRep.Location = New System.Drawing.Point(863, 198)
        Me.ddlSalesRep.ManagingFastMouseMoving = True
        Me.ddlSalesRep.ManagingFastMouseMovingInterval = 30
        Me.ddlSalesRep.Name = "ddlSalesRep"
        Me.ddlSalesRep.SelectedItem = Nothing
        Me.ddlSalesRep.SelectedValue = Nothing
        Me.ddlSalesRep.Size = New System.Drawing.Size(72, 21)
        Me.ddlSalesRep.TabIndex = 17
        Me.ddlSalesRep.ValueMember = "SalesRepUID"
        '
        'txtRef
        '
        Me.txtRef.Location = New System.Drawing.Point(153, 70)
        Me.txtRef.Name = "txtRef"
        Me.txtRef.Size = New System.Drawing.Size(116, 20)
        Me.txtRef.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 73)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 15)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Customer Ref #:"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(811, 398)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 27)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(16, 398)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(87, 27)
        Me.btnUpdate.TabIndex = 18
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtShipName
        '
        Me.txtShipName.Location = New System.Drawing.Point(153, 145)
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.Size = New System.Drawing.Size(206, 20)
        Me.txtShipName.TabIndex = 5
        '
        'txtBillName
        '
        Me.txtBillName.Location = New System.Drawing.Point(387, 40)
        Me.txtBillName.Name = "txtBillName"
        Me.txtBillName.ReadOnly = True
        Me.txtBillName.Size = New System.Drawing.Size(243, 20)
        Me.txtBillName.TabIndex = 35
        Me.txtBillName.TabStop = False
        '
        'ddlOrderNo
        '
        Me.ddlOrderNo.DisplayMember = "OrderNo"
        Me.ddlOrderNo.FormattingEnabled = True
        Me.ddlOrderNo.Location = New System.Drawing.Point(153, 12)
        Me.ddlOrderNo.Name = "ddlOrderNo"
        Me.ddlOrderNo.Size = New System.Drawing.Size(116, 23)
        Me.ddlOrderNo.TabIndex = 0
        Me.ddlOrderNo.ValueMember = "OrdrHeaderUID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(759, 201)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 15)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Sales Rep:"
        '
        'txtOrderStatus
        '
        Me.txtOrderStatus.Location = New System.Drawing.Point(864, 168)
        Me.txtOrderStatus.Name = "txtOrderStatus"
        Me.txtOrderStatus.ReadOnly = True
        Me.txtOrderStatus.Size = New System.Drawing.Size(46, 20)
        Me.txtOrderStatus.TabIndex = 16
        Me.txtOrderStatus.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(741, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 15)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Order Status:"
        '
        'txtShipAddr2
        '
        Me.txtShipAddr2.Location = New System.Drawing.Point(153, 207)
        Me.txtShipAddr2.Name = "txtShipAddr2"
        Me.txtShipAddr2.Size = New System.Drawing.Size(206, 20)
        Me.txtShipAddr2.TabIndex = 7
        '
        'txtShipZip
        '
        Me.txtShipZip.Location = New System.Drawing.Point(350, 237)
        Me.txtShipZip.Name = "txtShipZip"
        Me.txtShipZip.Size = New System.Drawing.Size(100, 20)
        Me.txtShipZip.TabIndex = 10
        '
        'txtShipState
        '
        Me.txtShipState.Location = New System.Drawing.Point(278, 237)
        Me.txtShipState.Name = "txtShipState"
        Me.txtShipState.Size = New System.Drawing.Size(65, 20)
        Me.txtShipState.TabIndex = 9
        '
        'txtShipCity
        '
        Me.txtShipCity.Location = New System.Drawing.Point(153, 238)
        Me.txtShipCity.Name = "txtShipCity"
        Me.txtShipCity.Size = New System.Drawing.Size(116, 20)
        Me.txtShipCity.TabIndex = 8
        '
        'txtShipAddr1
        '
        Me.txtShipAddr1.Location = New System.Drawing.Point(153, 175)
        Me.txtShipAddr1.Name = "txtShipAddr1"
        Me.txtShipAddr1.Size = New System.Drawing.Size(206, 20)
        Me.txtShipAddr1.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(31, 240)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 15)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "City/State/Zip:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(75, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 15)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Address:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(76, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 15)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Ship To:"
        '
        'txtBillZip
        '
        Me.txtBillZip.Location = New System.Drawing.Point(638, 97)
        Me.txtBillZip.Name = "txtBillZip"
        Me.txtBillZip.ReadOnly = True
        Me.txtBillZip.Size = New System.Drawing.Size(89, 20)
        Me.txtBillZip.TabIndex = 19
        Me.txtBillZip.TabStop = False
        '
        'txtBillState
        '
        Me.txtBillState.Location = New System.Drawing.Point(580, 97)
        Me.txtBillState.Name = "txtBillState"
        Me.txtBillState.ReadOnly = True
        Me.txtBillState.Size = New System.Drawing.Size(51, 20)
        Me.txtBillState.TabIndex = 18
        Me.txtBillState.TabStop = False
        '
        'txtBillCity
        '
        Me.txtBillCity.Location = New System.Drawing.Point(389, 98)
        Me.txtBillCity.Name = "txtBillCity"
        Me.txtBillCity.ReadOnly = True
        Me.txtBillCity.Size = New System.Drawing.Size(184, 20)
        Me.txtBillCity.TabIndex = 17
        Me.txtBillCity.TabStop = False
        '
        'txtBllAddr
        '
        Me.txtBllAddr.Location = New System.Drawing.Point(389, 68)
        Me.txtBllAddr.Name = "txtBllAddr"
        Me.txtBllAddr.ReadOnly = True
        Me.txtBllAddr.Size = New System.Drawing.Size(242, 20)
        Me.txtBllAddr.TabIndex = 16
        Me.txtBllAddr.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(319, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Sold To:"
        '
        'ddlNetTerms
        '
        Me.ddlNetTerms.DisplayMember = "NetTerms"
        Me.ddlNetTerms.FormattingEnabled = True
        Me.ddlNetTerms.Location = New System.Drawing.Point(864, 133)
        Me.ddlNetTerms.Name = "ddlNetTerms"
        Me.ddlNetTerms.Size = New System.Drawing.Size(124, 23)
        Me.ddlNetTerms.TabIndex = 15
        Me.ddlNetTerms.ValueMember = "NetTermsUID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(755, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Net Terms:"
        '
        'ddlShipTerms
        '
        Me.ddlShipTerms.DisplayMember = "ShipTerms"
        Me.ddlShipTerms.FormattingEnabled = True
        Me.ddlShipTerms.Location = New System.Drawing.Point(864, 100)
        Me.ddlShipTerms.Name = "ddlShipTerms"
        Me.ddlShipTerms.Size = New System.Drawing.Size(124, 23)
        Me.ddlShipTerms.TabIndex = 14
        Me.ddlShipTerms.ValueMember = "ShipTermsUID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(745, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Ship Terms:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(732, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Delivery Date:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(864, 70)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(124, 20)
        Me.DateTimePicker1.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(756, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ship Date:"
        '
        'dtmShipDate
        '
        Me.dtmShipDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmShipDate.Location = New System.Drawing.Point(864, 39)
        Me.dtmShipDate.Name = "dtmShipDate"
        Me.dtmShipDate.Size = New System.Drawing.Size(124, 20)
        Me.dtmShipDate.TabIndex = 12
        '
        'txtPONO
        '
        Me.txtPONO.Location = New System.Drawing.Point(153, 43)
        Me.txtPONO.Name = "txtPONO"
        Me.txtPONO.Size = New System.Drawing.Size(182, 20)
        Me.txtPONO.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Purchase Order #:"
        '
        'dtmOrderDate
        '
        Me.dtmOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmOrderDate.Location = New System.Drawing.Point(864, 5)
        Me.dtmOrderDate.Name = "dtmOrderDate"
        Me.dtmOrderDate.Size = New System.Drawing.Size(124, 20)
        Me.dtmOrderDate.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(749, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Order Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order #:"
        '
        'TabOrderDetail
        '
        Me.TabOrderDetail.Controls.Add(Me.dgvOrderDetail)
        Me.TabOrderDetail.Location = New System.Drawing.Point(4, 24)
        Me.TabOrderDetail.Name = "TabOrderDetail"
        Me.TabOrderDetail.Padding = New System.Windows.Forms.Padding(3)
        Me.TabOrderDetail.Size = New System.Drawing.Size(1009, 455)
        Me.TabOrderDetail.TabIndex = 1
        Me.TabOrderDetail.Text = "Detail"
        Me.TabOrderDetail.UseVisualStyleBackColor = True
        '
        'dgvOrderDetail
        '
        Me.dgvOrderDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderDetail.Location = New System.Drawing.Point(9, 7)
        Me.dgvOrderDetail.Name = "dgvOrderDetail"
        Me.dgvOrderDetail.Size = New System.Drawing.Size(994, 438)
        Me.dgvOrderDetail.TabIndex = 0
        '
        'tabMessages
        '
        Me.tabMessages.Controls.Add(Me.dgvOrderMessages)
        Me.tabMessages.Location = New System.Drawing.Point(4, 24)
        Me.tabMessages.Name = "tabMessages"
        Me.tabMessages.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMessages.Size = New System.Drawing.Size(1009, 455)
        Me.tabMessages.TabIndex = 2
        Me.tabMessages.Text = "Messages"
        Me.tabMessages.UseVisualStyleBackColor = True
        '
        'dgvOrderMessages
        '
        Me.dgvOrderMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderMessages.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MessageUID, Me.UserName, Me.BornOn, Me.MessageNotes, Me.Orderno})
        Me.dgvOrderMessages.Location = New System.Drawing.Point(10, 8)
        Me.dgvOrderMessages.Name = "dgvOrderMessages"
        Me.dgvOrderMessages.Size = New System.Drawing.Size(904, 436)
        Me.dgvOrderMessages.TabIndex = 0
        '
        'MessageUID
        '
        Me.MessageUID.DataPropertyName = "MessageUID"
        Me.MessageUID.HeaderText = ""
        Me.MessageUID.Name = "MessageUID"
        Me.MessageUID.Visible = False
        '
        'UserName
        '
        Me.UserName.DataPropertyName = "UserName"
        Me.UserName.HeaderText = "User"
        Me.UserName.Name = "UserName"
        Me.UserName.ReadOnly = True
        '
        'BornOn
        '
        Me.BornOn.DataPropertyName = "BornOn"
        Me.BornOn.HeaderText = "Date Added"
        Me.BornOn.Name = "BornOn"
        Me.BornOn.ReadOnly = True
        Me.BornOn.Width = 125
        '
        'MessageNotes
        '
        Me.MessageNotes.DataPropertyName = "MessageNotes"
        Me.MessageNotes.FillWeight = 500.0!
        Me.MessageNotes.HeaderText = "Message"
        Me.MessageNotes.Name = "MessageNotes"
        Me.MessageNotes.Width = 500
        '
        'Orderno
        '
        Me.Orderno.DataPropertyName = "OrderNo"
        Me.Orderno.HeaderText = ""
        Me.Orderno.Name = "Orderno"
        Me.Orderno.Visible = False
        '
        'tabOther
        '
        Me.tabOther.Controls.Add(Me.btnPrintOrder)
        Me.tabOther.Location = New System.Drawing.Point(4, 24)
        Me.tabOther.Name = "tabOther"
        Me.tabOther.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOther.Size = New System.Drawing.Size(1009, 455)
        Me.tabOther.TabIndex = 3
        Me.tabOther.Text = "Other"
        Me.tabOther.UseVisualStyleBackColor = True
        '
        'btnPrintOrder
        '
        Me.btnPrintOrder.Location = New System.Drawing.Point(10, 31)
        Me.btnPrintOrder.Name = "btnPrintOrder"
        Me.btnPrintOrder.Size = New System.Drawing.Size(143, 27)
        Me.btnPrintOrder.TabIndex = 0
        Me.btnPrintOrder.Text = "Print Order"
        Me.btnPrintOrder.UseVisualStyleBackColor = True
        '
        'frmOrderEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 538)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmOrderEntry"
        Me.Text = "Order Entry"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabOrderHeader.ResumeLayout(False)
        Me.tabOrderHeader.PerformLayout()
        Me.TabOrderDetail.ResumeLayout(False)
        CType(Me.dgvOrderDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMessages.ResumeLayout(False)
        CType(Me.dgvOrderMessages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOther.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabOrderHeader As System.Windows.Forms.TabPage
    Friend WithEvents txtRef As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents txtBillName As System.Windows.Forms.TextBox
    Friend WithEvents ddlOrderNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtOrderStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtShipAddr2 As System.Windows.Forms.TextBox
    Friend WithEvents txtShipZip As System.Windows.Forms.TextBox
    Friend WithEvents txtShipState As System.Windows.Forms.TextBox
    Friend WithEvents txtShipCity As System.Windows.Forms.TextBox
    Friend WithEvents txtShipAddr1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBillZip As System.Windows.Forms.TextBox
    Friend WithEvents txtBillState As System.Windows.Forms.TextBox
    Friend WithEvents txtBillCity As System.Windows.Forms.TextBox
    Friend WithEvents txtBllAddr As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ddlNetTerms As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ddlShipTerms As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtmShipDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPONO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtmOrderDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabOrderDetail As System.Windows.Forms.TabPage
    Friend WithEvents dgvOrderDetail As System.Windows.Forms.DataGridView
    Friend WithEvents tabMessages As System.Windows.Forms.TabPage
    Friend WithEvents dgvOrderMessages As System.Windows.Forms.DataGridView
    Friend WithEvents MessageUID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BornOn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MessageNotes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Orderno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tabOther As System.Windows.Forms.TabPage
    Friend WithEvents btnPrintOrder As System.Windows.Forms.Button
    Friend WithEvents ddlShipToCode As MTGCComboBox
    Friend WithEvents ddlBillToCode As MTGCComboBox
    Friend WithEvents ddlSalesRep As MTGCComboBox
End Class
