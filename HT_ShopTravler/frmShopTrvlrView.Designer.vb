<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShopTrvlrView
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
        Me.ReceiveShopTravelerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddShopTravelerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditShopTravelerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.dgvShopTraveler = New System.Windows.Forms.DataGridView
        Me.TravelerUID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TravelerNum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RecipeHdrUID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RecipeDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RunDte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CompleteDte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CompletedQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WasteQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Printed = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CompleteTravelerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditShopTravelerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.dgvShopTraveler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReceiveShopTravelerToolStripMenuItem
        '
        Me.ReceiveShopTravelerToolStripMenuItem.Name = "ReceiveShopTravelerToolStripMenuItem"
        Me.ReceiveShopTravelerToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ReceiveShopTravelerToolStripMenuItem.Text = "&Receive Shop Traveler"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddShopTravelerToolStripMenuItem, Me.EditShopTravelerToolStripMenuItem, Me.ReceiveShopTravelerToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(190, 70)
        '
        'AddShopTravelerToolStripMenuItem
        '
        Me.AddShopTravelerToolStripMenuItem.Name = "AddShopTravelerToolStripMenuItem"
        Me.AddShopTravelerToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.AddShopTravelerToolStripMenuItem.Text = "&Add Shop Traveler"
        '
        'EditShopTravelerToolStripMenuItem
        '
        Me.EditShopTravelerToolStripMenuItem.Name = "EditShopTravelerToolStripMenuItem"
        Me.EditShopTravelerToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.EditShopTravelerToolStripMenuItem.Text = "&Edit Shop Traveler"
        '
        'dgvShopTraveler
        '
        Me.dgvShopTraveler.AllowUserToAddRows = False
        Me.dgvShopTraveler.AllowUserToDeleteRows = False
        Me.dgvShopTraveler.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvShopTraveler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShopTraveler.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TravelerUID, Me.TravelerNum, Me.RecipeHdrUID, Me.RecipeDesc, Me.qty, Me.RunDte, Me.CompleteDte, Me.CompletedQty, Me.WasteQty, Me.Printed, Me.UserName})
        Me.dgvShopTraveler.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvShopTraveler.Location = New System.Drawing.Point(12, 27)
        Me.dgvShopTraveler.Name = "dgvShopTraveler"
        Me.dgvShopTraveler.Size = New System.Drawing.Size(1050, 469)
        Me.dgvShopTraveler.TabIndex = 2
        '
        'TravelerUID
        '
        Me.TravelerUID.DataPropertyName = "TravelerUID"
        Me.TravelerUID.HeaderText = ""
        Me.TravelerUID.Name = "TravelerUID"
        Me.TravelerUID.Visible = False
        '
        'TravelerNum
        '
        Me.TravelerNum.DataPropertyName = "TravelerNum"
        Me.TravelerNum.HeaderText = "Traveler #"
        Me.TravelerNum.Name = "TravelerNum"
        Me.TravelerNum.ReadOnly = True
        '
        'RecipeHdrUID
        '
        Me.RecipeHdrUID.DataPropertyName = "RecipeHdrUID"
        Me.RecipeHdrUID.HeaderText = ""
        Me.RecipeHdrUID.Name = "RecipeHdrUID"
        Me.RecipeHdrUID.Visible = False
        '
        'RecipeDesc
        '
        Me.RecipeDesc.DataPropertyName = "RecipeDesc"
        Me.RecipeDesc.HeaderText = "Recipe Description"
        Me.RecipeDesc.Name = "RecipeDesc"
        Me.RecipeDesc.ReadOnly = True
        Me.RecipeDesc.Width = 200
        '
        'qty
        '
        Me.qty.DataPropertyName = "Qty"
        Me.qty.HeaderText = "Qty"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        '
        'RunDte
        '
        Me.RunDte.DataPropertyName = "RunDte"
        Me.RunDte.HeaderText = "Run Date"
        Me.RunDte.Name = "RunDte"
        Me.RunDte.ReadOnly = True
        '
        'CompleteDte
        '
        Me.CompleteDte.DataPropertyName = "CompleteDte"
        Me.CompleteDte.HeaderText = "Completed Date"
        Me.CompleteDte.Name = "CompleteDte"
        '
        'CompletedQty
        '
        Me.CompletedQty.DataPropertyName = "CompletedQty"
        Me.CompletedQty.HeaderText = "Completed Qty"
        Me.CompletedQty.Name = "CompletedQty"
        '
        'WasteQty
        '
        Me.WasteQty.DataPropertyName = "WasteQty"
        Me.WasteQty.HeaderText = "Waste"
        Me.WasteQty.Name = "WasteQty"
        '
        'Printed
        '
        Me.Printed.DataPropertyName = "Printed"
        Me.Printed.HeaderText = "Printed"
        Me.Printed.Name = "Printed"
        '
        'UserName
        '
        Me.UserName.DataPropertyName = "UserName"
        Me.UserName.HeaderText = "User"
        Me.UserName.Name = "UserName"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.CompleteTravelerToolStripMenuItem, Me.EditShopTravelerToolStripMenuItem1, Me.CloseToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CloseToolStripMenuItem.Text = "&Add Shop Traveler"
        '
        'CompleteTravelerToolStripMenuItem
        '
        Me.CompleteTravelerToolStripMenuItem.Name = "CompleteTravelerToolStripMenuItem"
        Me.CompleteTravelerToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CompleteTravelerToolStripMenuItem.Text = "Com&plete Traveler"
        '
        'EditShopTravelerToolStripMenuItem1
        '
        Me.EditShopTravelerToolStripMenuItem1.Name = "EditShopTravelerToolStripMenuItem1"
        Me.EditShopTravelerToolStripMenuItem1.Size = New System.Drawing.Size(171, 22)
        Me.EditShopTravelerToolStripMenuItem1.Text = "&Edit Shop Traveler"
        '
        'CloseToolStripMenuItem1
        '
        Me.CloseToolStripMenuItem1.Name = "CloseToolStripMenuItem1"
        Me.CloseToolStripMenuItem1.Size = New System.Drawing.Size(171, 22)
        Me.CloseToolStripMenuItem1.Text = "&Close"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1074, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'frmShopTrvlrView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 508)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvShopTraveler)
        Me.Name = "frmShopTrvlrView"
        Me.Text = "Shop Traveler View"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.dgvShopTraveler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReceiveShopTravelerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddShopTravelerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditShopTravelerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvShopTraveler As System.Windows.Forms.DataGridView
    Friend WithEvents TravelerUID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TravelerNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecipeHdrUID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecipeDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RunDte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompleteDte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompletedQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WasteQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Printed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompleteTravelerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditShopTravelerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
End Class
