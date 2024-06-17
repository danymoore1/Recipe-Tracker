<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemMaster
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
        Me.dgItemMaster = New System.Windows.Forms.DataGridView
        Me.ItemUID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemGroup = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LeadDays = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SafetyNetAmt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UOM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VendorCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.dgItemMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgItemMaster
        '
        Me.dgItemMaster.AllowUserToOrderColumns = True
        Me.dgItemMaster.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgItemMaster.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemUID, Me.ItemNo, Me.ItemDesc, Me.ItemType, Me.ItemGroup, Me.LeadDays, Me.SafetyNetAmt, Me.UOM, Me.VendorCode, Me.Price})
        Me.dgItemMaster.Location = New System.Drawing.Point(14, 41)
        Me.dgItemMaster.Name = "dgItemMaster"
        Me.dgItemMaster.Size = New System.Drawing.Size(894, 501)
        Me.dgItemMaster.TabIndex = 1
        '
        'ItemUID
        '
        Me.ItemUID.DataPropertyName = "ItemUID"
        Me.ItemUID.Frozen = True
        Me.ItemUID.HeaderText = "ItemUID"
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
        Me.ItemDesc.Width = 150
        '
        'ItemType
        '
        Me.ItemType.DataPropertyName = "ItemType"
        Me.ItemType.HeaderText = "Item Type"
        Me.ItemType.Name = "ItemType"
        '
        'ItemGroup
        '
        Me.ItemGroup.DataPropertyName = "ItemGroup"
        Me.ItemGroup.HeaderText = "Item Group"
        Me.ItemGroup.Name = "ItemGroup"
        '
        'LeadDays
        '
        Me.LeadDays.DataPropertyName = "LeadDays"
        Me.LeadDays.HeaderText = "Lead Days"
        Me.LeadDays.Name = "LeadDays"
        '
        'SafetyNetAmt
        '
        Me.SafetyNetAmt.DataPropertyName = "SafetyNetAmt"
        Me.SafetyNetAmt.HeaderText = "Safety Amount"
        Me.SafetyNetAmt.Name = "SafetyNetAmt"
        '
        'UOM
        '
        Me.UOM.DataPropertyName = "UOM"
        Me.UOM.HeaderText = "Unit Of Measure"
        Me.UOM.Name = "UOM"
        '
        'VendorCode
        '
        Me.VendorCode.DataPropertyName = "VendorCode"
        Me.VendorCode.HeaderText = "Default Vendor"
        Me.VendorCode.Name = "VendorCode"
        '
        'Price
        '
        Me.Price.DataPropertyName = "Price"
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(948, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'AddItemToolStripMenuItem
        '
        Me.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem"
        Me.AddItemToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.AddItemToolStripMenuItem.Text = "&Add Item"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.CloseToolStripMenuItem.Text = "&Close"
        '
        'frmItemMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 576)
        Me.Controls.Add(Me.dgItemMaster)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmItemMaster"
        Me.Text = "Item Master"
        CType(Me.dgItemMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgItemMaster As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemUID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemGroup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LeadDays As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SafetyNetAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VendorCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
