<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceivePO
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
        Me.dtmPODate = New System.Windows.Forms.DateTimePicker
        Me.lotno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.receivedQty1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.dgvOrdered = New System.Windows.Forms.DataGridView
        Me.PODetailUID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReceivedQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label6 = New System.Windows.Forms.Label
        Me.ItemDesc1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtmEstDate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.POdetailUID1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnCancel = New System.Windows.Forms.Button
        Me.dgvPODetail = New System.Windows.Forms.DataGridView
        Me.lblPoStatus = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblVendorZip = New System.Windows.Forms.Label
        Me.lblVendorState = New System.Windows.Forms.Label
        Me.lblVendorCity = New System.Windows.Forms.Label
        Me.lblVendorAddr1 = New System.Windows.Forms.Label
        Me.lblVendorName = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkClose = New System.Windows.Forms.CheckBox
        Me.ddlPo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.dgvOrdered, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvPODetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtmPODate
        '
        Me.dtmPODate.Enabled = False
        Me.dtmPODate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmPODate.Location = New System.Drawing.Point(654, 48)
        Me.dtmPODate.Name = "dtmPODate"
        Me.dtmPODate.Size = New System.Drawing.Size(147, 20)
        Me.dtmPODate.TabIndex = 41
        '
        'lotno
        '
        Me.lotno.HeaderText = "Lot #:"
        Me.lotno.Name = "lotno"
        '
        'receivedQty1
        '
        Me.receivedQty1.DataPropertyName = "Receivedqty"
        Me.receivedQty1.HeaderText = "Received Qty"
        Me.receivedQty1.Name = "receivedQty1"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(14, 689)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(87, 27)
        Me.btnUpdate.TabIndex = 43
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'dgvOrdered
        '
        Me.dgvOrdered.AllowUserToAddRows = False
        Me.dgvOrdered.AllowUserToDeleteRows = False
        Me.dgvOrdered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrdered.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PODetailUID, Me.ItemDesc, Me.Qty, Me.ReceivedQty})
        Me.dgvOrdered.Location = New System.Drawing.Point(17, 242)
        Me.dgvOrdered.Name = "dgvOrdered"
        Me.dgvOrdered.Size = New System.Drawing.Size(923, 207)
        Me.dgvOrdered.TabIndex = 42
        '
        'PODetailUID
        '
        Me.PODetailUID.DataPropertyName = "POdetailUID"
        Me.PODetailUID.HeaderText = ""
        Me.PODetailUID.Name = "PODetailUID"
        Me.PODetailUID.Visible = False
        '
        'ItemDesc
        '
        Me.ItemDesc.DataPropertyName = "ItemDesc"
        Me.ItemDesc.HeaderText = "Item Description"
        Me.ItemDesc.Name = "ItemDesc"
        Me.ItemDesc.Width = 250
        '
        'Qty
        '
        Me.Qty.DataPropertyName = "Qty"
        Me.Qty.HeaderText = "Qty Ordered"
        Me.Qty.Name = "Qty"
        '
        'ReceivedQty
        '
        Me.ReceivedQty.DataPropertyName = "ReceivedQty"
        Me.ReceivedQty.HeaderText = "Received Qty"
        Me.ReceivedQty.Name = "ReceivedQty"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(484, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 15)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Estimated Delv Date:"
        '
        'ItemDesc1
        '
        Me.ItemDesc1.DataPropertyName = "ItemDesc"
        Me.ItemDesc1.HeaderText = "Item Description"
        Me.ItemDesc1.Name = "ItemDesc1"
        Me.ItemDesc1.ReadOnly = True
        Me.ItemDesc1.Width = 250
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(488, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 15)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "PO Date:"
        '
        'dtmEstDate
        '
        Me.dtmEstDate.Enabled = False
        Me.dtmEstDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmEstDate.Location = New System.Drawing.Point(654, 78)
        Me.dtmEstDate.Name = "dtmEstDate"
        Me.dtmEstDate.Size = New System.Drawing.Size(147, 20)
        Me.dtmEstDate.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Ordered:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 452)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Received:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(978, 24)
        Me.MenuStrip1.TabIndex = 23
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
        'POdetailUID1
        '
        Me.POdetailUID1.DataPropertyName = "POdetailUID"
        Me.POdetailUID1.HeaderText = ""
        Me.POdetailUID1.Name = "POdetailUID1"
        Me.POdetailUID1.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(853, 689)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 27)
        Me.btnCancel.TabIndex = 44
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dgvPODetail
        '
        Me.dgvPODetail.AllowUserToAddRows = False
        Me.dgvPODetail.AllowUserToDeleteRows = False
        Me.dgvPODetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPODetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.POdetailUID1, Me.ItemDesc1, Me.lotno, Me.receivedQty1})
        Me.dgvPODetail.Location = New System.Drawing.Point(14, 474)
        Me.dgvPODetail.Name = "dgvPODetail"
        Me.dgvPODetail.Size = New System.Drawing.Size(926, 208)
        Me.dgvPODetail.TabIndex = 35
        '
        'lblPoStatus
        '
        Me.lblPoStatus.AutoSize = True
        Me.lblPoStatus.Location = New System.Drawing.Point(651, 105)
        Me.lblPoStatus.Name = "lblPoStatus"
        Me.lblPoStatus.Size = New System.Drawing.Size(69, 15)
        Me.lblPoStatus.TabIndex = 34
        Me.lblPoStatus.Text = "lblPoStatus"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(484, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "PO Status:"
        '
        'lblVendorZip
        '
        Me.lblVendorZip.AutoSize = True
        Me.lblVendorZip.Location = New System.Drawing.Point(246, 182)
        Me.lblVendorZip.Name = "lblVendorZip"
        Me.lblVendorZip.Size = New System.Drawing.Size(80, 15)
        Me.lblVendorZip.TabIndex = 32
        Me.lblVendorZip.Text = "lblVendorZip"
        '
        'lblVendorState
        '
        Me.lblVendorState.AutoSize = True
        Me.lblVendorState.Location = New System.Drawing.Point(136, 182)
        Me.lblVendorState.Name = "lblVendorState"
        Me.lblVendorState.Size = New System.Drawing.Size(88, 15)
        Me.lblVendorState.TabIndex = 31
        Me.lblVendorState.Text = "lblVendorState"
        '
        'lblVendorCity
        '
        Me.lblVendorCity.AutoSize = True
        Me.lblVendorCity.Location = New System.Drawing.Point(14, 182)
        Me.lblVendorCity.Name = "lblVendorCity"
        Me.lblVendorCity.Size = New System.Drawing.Size(83, 15)
        Me.lblVendorCity.TabIndex = 30
        Me.lblVendorCity.Text = "lblVendorCity"
        '
        'lblVendorAddr1
        '
        Me.lblVendorAddr1.AutoSize = True
        Me.lblVendorAddr1.Location = New System.Drawing.Point(14, 160)
        Me.lblVendorAddr1.Name = "lblVendorAddr1"
        Me.lblVendorAddr1.Size = New System.Drawing.Size(95, 15)
        Me.lblVendorAddr1.TabIndex = 29
        Me.lblVendorAddr1.Text = "lblVendorAddr1"
        '
        'lblVendorName
        '
        Me.lblVendorName.AutoSize = True
        Me.lblVendorName.Location = New System.Drawing.Point(14, 138)
        Me.lblVendorName.Name = "lblVendorName"
        Me.lblVendorName.Size = New System.Drawing.Size(92, 15)
        Me.lblVendorName.TabIndex = 28
        Me.lblVendorName.Text = "lblVendorName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Vendor Info:"
        '
        'chkClose
        '
        Me.chkClose.AutoSize = True
        Me.chkClose.Location = New System.Drawing.Point(654, 128)
        Me.chkClose.Name = "chkClose"
        Me.chkClose.Size = New System.Drawing.Size(77, 19)
        Me.chkClose.TabIndex = 26
        Me.chkClose.Text = "Close PO"
        Me.chkClose.UseVisualStyleBackColor = True
        '
        'ddlPo
        '
        Me.ddlPo.DisplayMember = "PONO"
        Me.ddlPo.FormattingEnabled = True
        Me.ddlPo.Location = New System.Drawing.Point(14, 62)
        Me.ddlPo.Name = "ddlPo"
        Me.ddlPo.Size = New System.Drawing.Size(140, 23)
        Me.ddlPo.TabIndex = 25
        Me.ddlPo.ValueMember = "POheaderUID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "PO #:"
        '
        'frmReceivePO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 727)
        Me.Controls.Add(Me.dtmPODate)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dgvOrdered)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtmEstDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.dgvPODetail)
        Me.Controls.Add(Me.lblPoStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblVendorZip)
        Me.Controls.Add(Me.lblVendorState)
        Me.Controls.Add(Me.lblVendorCity)
        Me.Controls.Add(Me.lblVendorAddr1)
        Me.Controls.Add(Me.lblVendorName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkClose)
        Me.Controls.Add(Me.ddlPo)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmReceivePO"
        Me.Text = "frmReceivePO"
        CType(Me.dgvOrdered, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvPODetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtmPODate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lotno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents receivedQty1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents dgvOrdered As System.Windows.Forms.DataGridView
    Friend WithEvents PODetailUID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceivedQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ItemDesc1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtmEstDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POdetailUID1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents dgvPODetail As System.Windows.Forms.DataGridView
    Friend WithEvents lblPoStatus As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblVendorZip As System.Windows.Forms.Label
    Friend WithEvents lblVendorState As System.Windows.Forms.Label
    Friend WithEvents lblVendorCity As System.Windows.Forms.Label
    Friend WithEvents lblVendorAddr1 As System.Windows.Forms.Label
    Friend WithEvents lblVendorName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkClose As System.Windows.Forms.CheckBox
    Friend WithEvents ddlPo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
