<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepack
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
        Me.TabHeader = New System.Windows.Forms.TabPage
        Me.lblRecipeDesc = New System.Windows.Forms.Label
        Me.lnkAdd = New System.Windows.Forms.LinkLabel
        Me.numRecipeQty = New System.Windows.Forms.NumericUpDown
        Me.Label12 = New System.Windows.Forms.Label
        Me.ddlRecipeLotno = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.ddlRecipe = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dgvRecipeInvent = New System.Windows.Forms.DataGridView
        Me.InventUID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnPackUID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RecipeLotno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RecipeQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnHeaderUpdate = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.ddlRunno = New System.Windows.Forms.ComboBox
        Me.dtmRunDate = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.tabUnpack = New System.Windows.Forms.TabPage
        Me.ddlCustomerItem = New System.Windows.Forms.ComboBox
        Me.btnUnPackAdd = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.dgvDumped = New System.Windows.Forms.DataGridView
        Me.DUnpack = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DinventUID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.unpackItemNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnpackLotNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.unpackQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.numQty = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.tabRepack = New System.Windows.Forms.TabPage
        Me.dgvCreated = New System.Windows.Forms.DataGridView
        Me.CInventUID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CItemNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Clotno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.btnCancel = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabHeader.SuspendLayout()
        CType(Me.numRecipeQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRecipeInvent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabUnpack.SuspendLayout()
        CType(Me.dgvDumped, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRepack.SuspendLayout()
        CType(Me.dgvCreated, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabHeader)
        Me.TabControl1.Controls.Add(Me.tabUnpack)
        Me.TabControl1.Controls.Add(Me.tabRepack)
        Me.TabControl1.Location = New System.Drawing.Point(12, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(840, 433)
        Me.TabControl1.TabIndex = 3
        '
        'TabHeader
        '
        Me.TabHeader.Controls.Add(Me.lblRecipeDesc)
        Me.TabHeader.Controls.Add(Me.lnkAdd)
        Me.TabHeader.Controls.Add(Me.numRecipeQty)
        Me.TabHeader.Controls.Add(Me.Label12)
        Me.TabHeader.Controls.Add(Me.ddlRecipeLotno)
        Me.TabHeader.Controls.Add(Me.Label11)
        Me.TabHeader.Controls.Add(Me.ddlRecipe)
        Me.TabHeader.Controls.Add(Me.Label5)
        Me.TabHeader.Controls.Add(Me.dgvRecipeInvent)
        Me.TabHeader.Controls.Add(Me.btnHeaderUpdate)
        Me.TabHeader.Controls.Add(Me.Label10)
        Me.TabHeader.Controls.Add(Me.ddlRunno)
        Me.TabHeader.Controls.Add(Me.dtmRunDate)
        Me.TabHeader.Controls.Add(Me.Label9)
        Me.TabHeader.Location = New System.Drawing.Point(4, 24)
        Me.TabHeader.Name = "TabHeader"
        Me.TabHeader.Size = New System.Drawing.Size(832, 405)
        Me.TabHeader.TabIndex = 2
        Me.TabHeader.Text = "Run Header"
        Me.TabHeader.UseVisualStyleBackColor = True
        '
        'lblRecipeDesc
        '
        Me.lblRecipeDesc.AutoSize = True
        Me.lblRecipeDesc.Location = New System.Drawing.Point(210, 58)
        Me.lblRecipeDesc.Name = "lblRecipeDesc"
        Me.lblRecipeDesc.Size = New System.Drawing.Size(0, 15)
        Me.lblRecipeDesc.TabIndex = 19
        '
        'lnkAdd
        '
        Me.lnkAdd.AutoSize = True
        Me.lnkAdd.Location = New System.Drawing.Point(402, 104)
        Me.lnkAdd.Name = "lnkAdd"
        Me.lnkAdd.Size = New System.Drawing.Size(95, 15)
        Me.lnkAdd.TabIndex = 18
        Me.lnkAdd.TabStop = True
        Me.lnkAdd.Text = "Add Lot To Run"
        '
        'numRecipeQty
        '
        Me.numRecipeQty.Location = New System.Drawing.Point(210, 104)
        Me.numRecipeQty.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.numRecipeQty.Name = "numRecipeQty"
        Me.numRecipeQty.Size = New System.Drawing.Size(120, 20)
        Me.numRecipeQty.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(207, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 15)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Qty:"
        '
        'ddlRecipeLotno
        '
        Me.ddlRecipeLotno.DisplayMember = "Lotno"
        Me.ddlRecipeLotno.FormattingEnabled = True
        Me.ddlRecipeLotno.Location = New System.Drawing.Point(14, 102)
        Me.ddlRecipeLotno.Name = "ddlRecipeLotno"
        Me.ddlRecipeLotno.Size = New System.Drawing.Size(121, 23)
        Me.ddlRecipeLotno.TabIndex = 15
        Me.ddlRecipeLotno.ValueMember = "InventUID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 15)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Lot#:"
        '
        'ddlRecipe
        '
        Me.ddlRecipe.DisplayMember = "ItemNo"
        Me.ddlRecipe.FormattingEnabled = True
        Me.ddlRecipe.Location = New System.Drawing.Point(210, 28)
        Me.ddlRecipe.Name = "ddlRecipe"
        Me.ddlRecipe.Size = New System.Drawing.Size(121, 23)
        Me.ddlRecipe.TabIndex = 13
        Me.ddlRecipe.ValueMember = "ItemUID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(207, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Recipe Tray Item:"
        '
        'dgvRecipeInvent
        '
        Me.dgvRecipeInvent.AllowUserToAddRows = False
        Me.dgvRecipeInvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecipeInvent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InventUID, Me.UnPackUID, Me.RecipeLotno, Me.RecipeQty})
        Me.dgvRecipeInvent.Location = New System.Drawing.Point(4, 134)
        Me.dgvRecipeInvent.Name = "dgvRecipeInvent"
        Me.dgvRecipeInvent.ReadOnly = True
        Me.dgvRecipeInvent.Size = New System.Drawing.Size(810, 237)
        Me.dgvRecipeInvent.TabIndex = 11
        '
        'InventUID
        '
        Me.InventUID.DataPropertyName = "InventUID"
        Me.InventUID.HeaderText = "InventUID"
        Me.InventUID.Name = "InventUID"
        Me.InventUID.ReadOnly = True
        Me.InventUID.Visible = False
        '
        'UnPackUID
        '
        Me.UnPackUID.DataPropertyName = "unPackUID"
        Me.UnPackUID.HeaderText = "UnPackUID"
        Me.UnPackUID.Name = "UnPackUID"
        Me.UnPackUID.ReadOnly = True
        Me.UnPackUID.Visible = False
        '
        'RecipeLotno
        '
        Me.RecipeLotno.DataPropertyName = "Lotno"
        Me.RecipeLotno.HeaderText = "Lot #"
        Me.RecipeLotno.Name = "RecipeLotno"
        Me.RecipeLotno.ReadOnly = True
        '
        'RecipeQty
        '
        Me.RecipeQty.DataPropertyName = "qty"
        Me.RecipeQty.HeaderText = "Qty"
        Me.RecipeQty.Name = "RecipeQty"
        Me.RecipeQty.ReadOnly = True
        '
        'btnHeaderUpdate
        '
        Me.btnHeaderUpdate.Location = New System.Drawing.Point(4, 377)
        Me.btnHeaderUpdate.Name = "btnHeaderUpdate"
        Me.btnHeaderUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnHeaderUpdate.TabIndex = 10
        Me.btnHeaderUpdate.Text = "Update"
        Me.btnHeaderUpdate.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(402, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 15)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Run #:"
        '
        'ddlRunno
        '
        Me.ddlRunno.DisplayMember = "Runno"
        Me.ddlRunno.FormattingEnabled = True
        Me.ddlRunno.Location = New System.Drawing.Point(402, 28)
        Me.ddlRunno.Name = "ddlRunno"
        Me.ddlRunno.Size = New System.Drawing.Size(121, 23)
        Me.ddlRunno.TabIndex = 1
        Me.ddlRunno.Tag = "Enter 0 to Create New Run"
        Me.ddlRunno.ValueMember = "RunUID"
        '
        'dtmRunDate
        '
        Me.dtmRunDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmRunDate.Location = New System.Drawing.Point(13, 30)
        Me.dtmRunDate.Name = "dtmRunDate"
        Me.dtmRunDate.Size = New System.Drawing.Size(121, 20)
        Me.dtmRunDate.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Run Date:"
        '
        'tabUnpack
        '
        Me.tabUnpack.Controls.Add(Me.ddlCustomerItem)
        Me.tabUnpack.Controls.Add(Me.btnUnPackAdd)
        Me.tabUnpack.Controls.Add(Me.Label4)
        Me.tabUnpack.Controls.Add(Me.dgvDumped)
        Me.tabUnpack.Controls.Add(Me.Label3)
        Me.tabUnpack.Controls.Add(Me.numQty)
        Me.tabUnpack.Controls.Add(Me.Label2)
        Me.tabUnpack.Location = New System.Drawing.Point(4, 24)
        Me.tabUnpack.Name = "tabUnpack"
        Me.tabUnpack.Padding = New System.Windows.Forms.Padding(3)
        Me.tabUnpack.Size = New System.Drawing.Size(832, 405)
        Me.tabUnpack.TabIndex = 0
        Me.tabUnpack.Text = "Placed onto Run"
        Me.tabUnpack.UseVisualStyleBackColor = True
        '
        'ddlCustomerItem
        '
        Me.ddlCustomerItem.DisplayMember = "Itemno"
        Me.ddlCustomerItem.FormattingEnabled = True
        Me.ddlCustomerItem.Location = New System.Drawing.Point(15, 33)
        Me.ddlCustomerItem.Name = "ddlCustomerItem"
        Me.ddlCustomerItem.Size = New System.Drawing.Size(121, 23)
        Me.ddlCustomerItem.TabIndex = 16
        Me.ddlCustomerItem.ValueMember = "CusPackUID"
        '
        'btnUnPackAdd
        '
        Me.btnUnPackAdd.Location = New System.Drawing.Point(151, 90)
        Me.btnUnPackAdd.Name = "btnUnPackAdd"
        Me.btnUnPackAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnUnPackAdd.TabIndex = 4
        Me.btnUnPackAdd.Text = "Add"
        Me.btnUnPackAdd.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Current Items on Run:"
        '
        'dgvDumped
        '
        Me.dgvDumped.AllowUserToAddRows = False
        Me.dgvDumped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDumped.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DUnpack, Me.DinventUID, Me.unpackItemNo, Me.UnpackLotNo, Me.unpackQty})
        Me.dgvDumped.Location = New System.Drawing.Point(12, 163)
        Me.dgvDumped.Name = "dgvDumped"
        Me.dgvDumped.ReadOnly = True
        Me.dgvDumped.Size = New System.Drawing.Size(812, 189)
        Me.dgvDumped.TabIndex = 14
        '
        'DUnpack
        '
        Me.DUnpack.DataPropertyName = "UnpackUID"
        Me.DUnpack.HeaderText = "UnpackUID"
        Me.DUnpack.Name = "DUnpack"
        Me.DUnpack.ReadOnly = True
        Me.DUnpack.Visible = False
        '
        'DinventUID
        '
        Me.DinventUID.DataPropertyName = "InventUID"
        Me.DinventUID.HeaderText = "InventUID"
        Me.DinventUID.Name = "DinventUID"
        Me.DinventUID.ReadOnly = True
        Me.DinventUID.Visible = False
        '
        'unpackItemNo
        '
        Me.unpackItemNo.DataPropertyName = "ItemNo"
        Me.unpackItemNo.HeaderText = "Item #"
        Me.unpackItemNo.Name = "unpackItemNo"
        Me.unpackItemNo.ReadOnly = True
        '
        'UnpackLotNo
        '
        Me.UnpackLotNo.DataPropertyName = "Lotno"
        Me.UnpackLotNo.HeaderText = "Lot #"
        Me.UnpackLotNo.Name = "UnpackLotNo"
        Me.UnpackLotNo.ReadOnly = True
        '
        'unpackQty
        '
        Me.unpackQty.DataPropertyName = "Qty"
        Me.unpackQty.HeaderText = "Qty"
        Me.unpackQty.Name = "unpackQty"
        Me.unpackQty.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Qty"
        '
        'numQty
        '
        Me.numQty.Location = New System.Drawing.Point(15, 90)
        Me.numQty.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.numQty.Name = "numQty"
        Me.numQty.Size = New System.Drawing.Size(98, 20)
        Me.numQty.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Item #:"
        '
        'tabRepack
        '
        Me.tabRepack.Controls.Add(Me.dgvCreated)
        Me.tabRepack.Controls.Add(Me.Label7)
        Me.tabRepack.Controls.Add(Me.Label8)
        Me.tabRepack.Location = New System.Drawing.Point(4, 24)
        Me.tabRepack.Name = "tabRepack"
        Me.tabRepack.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRepack.Size = New System.Drawing.Size(832, 405)
        Me.tabRepack.TabIndex = 1
        Me.tabRepack.Text = "Created From Run"
        Me.tabRepack.UseVisualStyleBackColor = True
        '
        'dgvCreated
        '
        Me.dgvCreated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCreated.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CInventUID, Me.CItemNo, Me.Clotno, Me.CQty})
        Me.dgvCreated.Location = New System.Drawing.Point(12, 179)
        Me.dgvCreated.Name = "dgvCreated"
        Me.dgvCreated.Size = New System.Drawing.Size(812, 189)
        Me.dgvCreated.TabIndex = 22
        '
        'CInventUID
        '
        Me.CInventUID.DataPropertyName = "InventUID"
        Me.CInventUID.HeaderText = "InventUID "
        Me.CInventUID.Name = "CInventUID"
        Me.CInventUID.Visible = False
        '
        'CItemNo
        '
        Me.CItemNo.DataPropertyName = "Itemno"
        Me.CItemNo.HeaderText = "Item #"
        Me.CItemNo.Name = "CItemNo"
        '
        'Clotno
        '
        Me.Clotno.DataPropertyName = "Lotno"
        Me.Clotno.HeaderText = "Lot #"
        Me.Clotno.Name = "Clotno"
        '
        'CQty
        '
        Me.CQty.DataPropertyName = "Qty"
        Me.CQty.HeaderText = "Qty"
        Me.CQty.Name = "CQty"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 15)
        Me.Label7.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 15)
        Me.Label8.TabIndex = 16
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Lot #"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ItemNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Item #"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "&Close"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(871, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(772, 479)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'FrmRepack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 518)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnCancel)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmRepack"
        Me.Text = "Customer Item Packaging"
        Me.TabControl1.ResumeLayout(False)
        Me.TabHeader.ResumeLayout(False)
        Me.TabHeader.PerformLayout()
        CType(Me.numRecipeQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRecipeInvent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabUnpack.ResumeLayout(False)
        Me.tabUnpack.PerformLayout()
        CType(Me.dgvDumped, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRepack.ResumeLayout(False)
        Me.tabRepack.PerformLayout()
        CType(Me.dgvCreated, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabHeader As System.Windows.Forms.TabPage
    Friend WithEvents lnkAdd As System.Windows.Forms.LinkLabel
    Friend WithEvents numRecipeQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ddlRecipeLotno As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ddlRecipe As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvRecipeInvent As System.Windows.Forms.DataGridView
    Friend WithEvents btnHeaderUpdate As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ddlRunno As System.Windows.Forms.ComboBox
    Friend WithEvents dtmRunDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tabUnpack As System.Windows.Forms.TabPage
    Friend WithEvents btnUnPackAdd As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvDumped As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents numQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tabRepack As System.Windows.Forms.TabPage
    Friend WithEvents dgvCreated As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents InventUID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnPackUID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecipeLotno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecipeQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblRecipeDesc As System.Windows.Forms.Label
    Friend WithEvents ddlCustomerItem As System.Windows.Forms.ComboBox
    Friend WithEvents DUnpack As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DinventUID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unpackItemNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnpackLotNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unpackQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CInventUID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CItemNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Clotno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CQty As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
