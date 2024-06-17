<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLowInventory
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
        Me.components = New System.ComponentModel.Container
        Me.dgvGrid = New System.Windows.Forms.DataGridView
        Me.ItemUID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OnHandQTy = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AllocatedQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhInventory = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LeadDays = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SafetyNetAmt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VendorName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrderedQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CreateNewPurchaseOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewAllocatedOrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvGrid
        '
        Me.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemUID, Me.ItemNo, Me.ItemDesc, Me.OnHandQTy, Me.AllocatedQty, Me.PhInventory, Me.LeadDays, Me.SafetyNetAmt, Me.VendorName, Me.OrderedQty})
        Me.dgvGrid.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvGrid.Location = New System.Drawing.Point(12, 27)
        Me.dgvGrid.Name = "dgvGrid"
        Me.dgvGrid.Size = New System.Drawing.Size(989, 545)
        Me.dgvGrid.TabIndex = 1
        '
        'ItemUID
        '
        Me.ItemUID.DataPropertyName = "ItemUId"
        Me.ItemUID.Frozen = True
        Me.ItemUID.HeaderText = ""
        Me.ItemUID.Name = "ItemUID"
        Me.ItemUID.Visible = False
        '
        'ItemNo
        '
        Me.ItemNo.DataPropertyName = "ItemNo"
        Me.ItemNo.Frozen = True
        Me.ItemNo.HeaderText = "Item #"
        Me.ItemNo.Name = "ItemNo"
        '
        'ItemDesc
        '
        Me.ItemDesc.DataPropertyName = "ItemDesc"
        Me.ItemDesc.HeaderText = "Item Description"
        Me.ItemDesc.Name = "ItemDesc"
        '
        'OnHandQTy
        '
        Me.OnHandQTy.DataPropertyName = "OnHandQty"
        Me.OnHandQTy.HeaderText = "On Hand Qty"
        Me.OnHandQTy.Name = "OnHandQTy"
        Me.OnHandQTy.ToolTipText = "This is system Caculated Inventory"
        '
        'AllocatedQty
        '
        Me.AllocatedQty.DataPropertyName = "AllocatedQty"
        Me.AllocatedQty.HeaderText = "Allocated Qty"
        Me.AllocatedQty.Name = "AllocatedQty"
        Me.AllocatedQty.ToolTipText = "This is Allocated to Shop Travelers"
        '
        'PhInventory
        '
        Me.PhInventory.DataPropertyName = "PhInventory"
        Me.PhInventory.HeaderText = "Phys. Inventory"
        Me.PhInventory.Name = "PhInventory"
        Me.PhInventory.ToolTipText = "Manual Entry Inventory"
        '
        'LeadDays
        '
        Me.LeadDays.DataPropertyName = "LeadDays"
        Me.LeadDays.HeaderText = "Lead Days"
        Me.LeadDays.Name = "LeadDays"
        Me.LeadDays.ToolTipText = "Amount of Days for Product to be received once Ordered"
        '
        'SafetyNetAmt
        '
        Me.SafetyNetAmt.DataPropertyName = "SafetyNetAmt"
        Me.SafetyNetAmt.HeaderText = "Safety Net Amt"
        Me.SafetyNetAmt.Name = "SafetyNetAmt"
        Me.SafetyNetAmt.ToolTipText = "Need to Order if OnHand Qty is close to this qty"
        '
        'VendorName
        '
        Me.VendorName.DataPropertyName = "VendorName"
        Me.VendorName.HeaderText = "Default Vendor"
        Me.VendorName.Name = "VendorName"
        Me.VendorName.ToolTipText = "Default Vendor that HC orders from"
        '
        'OrderedQty
        '
        Me.OrderedQty.DataPropertyName = "Orderedqty"
        Me.OrderedQty.HeaderText = "Ordered Qty"
        Me.OrderedQty.Name = "OrderedQty"
        Me.OrderedQty.ToolTipText = "Qty that has been alreaded Ordered. Existing PO not yet received"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateNewPurchaseOrderToolStripMenuItem, Me.ViewAllocatedOrdersToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(220, 48)
        '
        'CreateNewPurchaseOrderToolStripMenuItem
        '
        Me.CreateNewPurchaseOrderToolStripMenuItem.Name = "CreateNewPurchaseOrderToolStripMenuItem"
        Me.CreateNewPurchaseOrderToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.CreateNewPurchaseOrderToolStripMenuItem.Text = "Create New &Purchase Order"
        '
        'ViewAllocatedOrdersToolStripMenuItem
        '
        Me.ViewAllocatedOrdersToolStripMenuItem.Enabled = False
        Me.ViewAllocatedOrdersToolStripMenuItem.Name = "ViewAllocatedOrdersToolStripMenuItem"
        Me.ViewAllocatedOrdersToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ViewAllocatedOrdersToolStripMenuItem.Text = "View &Allocated Orders"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 2
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
        'frmLowInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 587)
        Me.Controls.Add(Me.dgvGrid)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmLowInventory"
        Me.Text = "Low Inventory"
        CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvGrid As System.Windows.Forms.DataGridView
    Friend WithEvents ItemUID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OnHandQTy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AllocatedQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhInventory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LeadDays As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SafetyNetAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VendorName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderedQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CreateNewPurchaseOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAllocatedOrdersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
