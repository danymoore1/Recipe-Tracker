<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerPricing
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
        Me.lnkCancel = New System.Windows.Forms.LinkLabel
        Me.lnkUpdate = New System.Windows.Forms.LinkLabel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtmtodate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtmfrmdate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtItemNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnlItemInfo = New System.Windows.Forms.Panel
        Me.ctxtCasePrice = New CurrencyControl_VB.CurrencyText
        Me.CtxtTrayPrice = New CurrencyControl_VB.CurrencyText
        Me.lnkDelete = New System.Windows.Forms.LinkLabel
        Me.lnkEdit = New System.Windows.Forms.LinkLabel
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lnkAdd = New System.Windows.Forms.LinkLabel
        Me.lstPricing = New System.Windows.Forms.ListBox
        Me.ddlCustomerItem = New System.Windows.Forms.ComboBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.pnlItemInfo.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lnkCancel
        '
        Me.lnkCancel.AutoSize = True
        Me.lnkCancel.Location = New System.Drawing.Point(146, 273)
        Me.lnkCancel.Name = "lnkCancel"
        Me.lnkCancel.Size = New System.Drawing.Size(45, 15)
        Me.lnkCancel.TabIndex = 10
        Me.lnkCancel.TabStop = True
        Me.lnkCancel.Text = "Cancel"
        '
        'lnkUpdate
        '
        Me.lnkUpdate.AutoSize = True
        Me.lnkUpdate.Location = New System.Drawing.Point(7, 273)
        Me.lnkUpdate.Name = "lnkUpdate"
        Me.lnkUpdate.Size = New System.Drawing.Size(46, 15)
        Me.lnkUpdate.TabIndex = 9
        Me.lnkUpdate.TabStop = True
        Me.lnkUpdate.Text = "Update"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Case Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tray Price:"
        '
        'dtmtodate
        '
        Me.dtmtodate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmtodate.Location = New System.Drawing.Point(8, 117)
        Me.dtmtodate.Name = "dtmtodate"
        Me.dtmtodate.Size = New System.Drawing.Size(163, 20)
        Me.dtmtodate.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "To Date:"
        '
        'dtmfrmdate
        '
        Me.dtmfrmdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmfrmdate.Location = New System.Drawing.Point(8, 61)
        Me.dtmfrmdate.Name = "dtmfrmdate"
        Me.dtmfrmdate.Size = New System.Drawing.Size(163, 20)
        Me.dtmfrmdate.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Customer Item:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "From Date:"
        '
        'txtItemNo
        '
        Me.txtItemNo.Location = New System.Drawing.Point(54, 5)
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.ReadOnly = True
        Me.txtItemNo.Size = New System.Drawing.Size(158, 20)
        Me.txtItemNo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Item:"
        '
        'pnlItemInfo
        '
        Me.pnlItemInfo.Controls.Add(Me.ctxtCasePrice)
        Me.pnlItemInfo.Controls.Add(Me.CtxtTrayPrice)
        Me.pnlItemInfo.Controls.Add(Me.lnkCancel)
        Me.pnlItemInfo.Controls.Add(Me.lnkUpdate)
        Me.pnlItemInfo.Controls.Add(Me.Label6)
        Me.pnlItemInfo.Controls.Add(Me.Label5)
        Me.pnlItemInfo.Controls.Add(Me.dtmtodate)
        Me.pnlItemInfo.Controls.Add(Me.Label4)
        Me.pnlItemInfo.Controls.Add(Me.dtmfrmdate)
        Me.pnlItemInfo.Controls.Add(Me.Label3)
        Me.pnlItemInfo.Controls.Add(Me.txtItemNo)
        Me.pnlItemInfo.Controls.Add(Me.Label2)
        Me.pnlItemInfo.Location = New System.Drawing.Point(366, 97)
        Me.pnlItemInfo.Name = "pnlItemInfo"
        Me.pnlItemInfo.Size = New System.Drawing.Size(233, 300)
        Me.pnlItemInfo.TabIndex = 15
        '
        'ctxtCasePrice
        '
        Me.ctxtCasePrice.DollarValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ctxtCasePrice.Location = New System.Drawing.Point(12, 219)
        Me.ctxtCasePrice.Name = "ctxtCasePrice"
        Me.ctxtCasePrice.Size = New System.Drawing.Size(116, 20)
        Me.ctxtCasePrice.TabIndex = 8
        '
        'CtxtTrayPrice
        '
        Me.CtxtTrayPrice.DollarValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CtxtTrayPrice.Location = New System.Drawing.Point(12, 167)
        Me.CtxtTrayPrice.Name = "CtxtTrayPrice"
        Me.CtxtTrayPrice.Size = New System.Drawing.Size(116, 20)
        Me.CtxtTrayPrice.TabIndex = 7
        '
        'lnkDelete
        '
        Me.lnkDelete.AutoSize = True
        Me.lnkDelete.Location = New System.Drawing.Point(240, 380)
        Me.lnkDelete.Name = "lnkDelete"
        Me.lnkDelete.Size = New System.Drawing.Size(42, 15)
        Me.lnkDelete.TabIndex = 4
        Me.lnkDelete.TabStop = True
        Me.lnkDelete.Text = "Delete"
        '
        'lnkEdit
        '
        Me.lnkEdit.AutoSize = True
        Me.lnkEdit.Location = New System.Drawing.Point(240, 223)
        Me.lnkEdit.Name = "lnkEdit"
        Me.lnkEdit.Size = New System.Drawing.Size(30, 15)
        Me.lnkEdit.TabIndex = 3
        Me.lnkEdit.TabStop = True
        Me.lnkEdit.Text = "Edit"
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
        'lnkAdd
        '
        Me.lnkAdd.AutoSize = True
        Me.lnkAdd.Location = New System.Drawing.Point(240, 97)
        Me.lnkAdd.Name = "lnkAdd"
        Me.lnkAdd.Size = New System.Drawing.Size(29, 15)
        Me.lnkAdd.TabIndex = 2
        Me.lnkAdd.TabStop = True
        Me.lnkAdd.Text = "Add"
        '
        'lstPricing
        '
        Me.lstPricing.DisplayMember = "Custprice"
        Me.lstPricing.FormattingEnabled = True
        Me.lstPricing.ItemHeight = 15
        Me.lstPricing.Location = New System.Drawing.Point(15, 97)
        Me.lstPricing.Name = "lstPricing"
        Me.lstPricing.Size = New System.Drawing.Size(216, 289)
        Me.lstPricing.TabIndex = 1
        Me.lstPricing.ValueMember = "CustPriceUID"
        '
        'ddlCustomerItem
        '
        Me.ddlCustomerItem.DisplayMember = "CustomerItemNo"
        Me.ddlCustomerItem.FormattingEnabled = True
        Me.ddlCustomerItem.Location = New System.Drawing.Point(15, 59)
        Me.ddlCustomerItem.Name = "ddlCustomerItem"
        Me.ddlCustomerItem.Size = New System.Drawing.Size(140, 23)
        Me.ddlCustomerItem.TabIndex = 0
        Me.ddlCustomerItem.ValueMember = "CusPackUID"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(681, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'frmCustomerPricing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 456)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlItemInfo)
        Me.Controls.Add(Me.lnkDelete)
        Me.Controls.Add(Me.lnkEdit)
        Me.Controls.Add(Me.lnkAdd)
        Me.Controls.Add(Me.lstPricing)
        Me.Controls.Add(Me.ddlCustomerItem)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmCustomerPricing"
        Me.Text = "Customer Pricing"
        Me.pnlItemInfo.ResumeLayout(False)
        Me.pnlItemInfo.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lnkCancel As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkUpdate As System.Windows.Forms.LinkLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtmtodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtmfrmdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtItemNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlItemInfo As System.Windows.Forms.Panel
    Friend WithEvents lnkDelete As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkEdit As System.Windows.Forms.LinkLabel
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lnkAdd As System.Windows.Forms.LinkLabel
    Friend WithEvents lstPricing As System.Windows.Forms.ListBox
    Friend WithEvents ddlCustomerItem As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ctxtCasePrice As CurrencyControl_VB.CurrencyText
    Friend WithEvents CtxtTrayPrice As CurrencyControl_VB.CurrencyText
End Class
