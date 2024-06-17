<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddShopTrvlr
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.dgvDetails = New System.Windows.Forms.DataGridView
        Me.ShopdtlUID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemUID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InventUID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Lotno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtmRunDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.numQty = New System.Windows.Forms.NumericUpDown
        Me.txtShopTraveler = New System.Windows.Forms.TextBox
        Me.ddlRecipe = New MTGCComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnUpdate = New System.Windows.Forms.Button
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 15)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Details:"
        '
        'dgvDetails
        '
        Me.dgvDetails.AllowUserToOrderColumns = True
        Me.dgvDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ShopdtlUID, Me.ItemUID, Me.InventUID, Me.ItemNo, Me.Lotno, Me.Qty})
        Me.dgvDetails.Location = New System.Drawing.Point(12, 181)
        Me.dgvDetails.Name = "dgvDetails"
        Me.dgvDetails.Size = New System.Drawing.Size(479, 281)
        Me.dgvDetails.TabIndex = 25
        '
        'ShopdtlUID
        '
        Me.ShopdtlUID.DataPropertyName = "ShopdtlUID"
        Me.ShopdtlUID.HeaderText = "ShopdtlUID"
        Me.ShopdtlUID.Name = "ShopdtlUID"
        Me.ShopdtlUID.Visible = False
        '
        'ItemUID
        '
        Me.ItemUID.DataPropertyName = "ItemUID"
        Me.ItemUID.HeaderText = "ItemUID"
        Me.ItemUID.Name = "ItemUID"
        Me.ItemUID.Visible = False
        '
        'InventUID
        '
        Me.InventUID.DataPropertyName = "InventUID"
        Me.InventUID.HeaderText = "InventUID"
        Me.InventUID.Name = "InventUID"
        Me.InventUID.Visible = False
        '
        'ItemNo
        '
        Me.ItemNo.DataPropertyName = "ItemNo"
        Me.ItemNo.HeaderText = "Item #"
        Me.ItemNo.Name = "ItemNo"
        '
        'Lotno
        '
        Me.Lotno.DataPropertyName = "Lotno"
        Me.Lotno.HeaderText = "Lot #"
        Me.Lotno.Name = "Lotno"
        '
        'Qty
        '
        Me.Qty.DataPropertyName = "Qty"
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(397, 474)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 27)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(159, 474)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(153, 27)
        Me.btnPrint.TabIndex = 23
        Me.btnPrint.Text = "Print Documents"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Run Date:"
        '
        'dtmRunDate
        '
        Me.dtmRunDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmRunDate.Location = New System.Drawing.Point(12, 111)
        Me.dtmRunDate.Name = "dtmRunDate"
        Me.dtmRunDate.Size = New System.Drawing.Size(139, 20)
        Me.dtmRunDate.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(157, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Tray Qty:"
        '
        'numQty
        '
        Me.numQty.Location = New System.Drawing.Point(157, 111)
        Me.numQty.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.numQty.Name = "numQty"
        Me.numQty.Size = New System.Drawing.Size(140, 20)
        Me.numQty.TabIndex = 18
        '
        'txtShopTraveler
        '
        Me.txtShopTraveler.Location = New System.Drawing.Point(12, 57)
        Me.txtShopTraveler.Name = "txtShopTraveler"
        Me.txtShopTraveler.Size = New System.Drawing.Size(116, 20)
        Me.txtShopTraveler.TabIndex = 17
        '
        'ddlRecipe
        '
        Me.ddlRecipe.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.ddlRecipe.ArrowColor = System.Drawing.Color.Black
        Me.ddlRecipe.BindedControl = Nothing
        Me.ddlRecipe.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.ddlRecipe.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ddlRecipe.ColumnNum = 3
        Me.ddlRecipe.ColumnWidth = "121;100;5"
        Me.ddlRecipe.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.ddlRecipe.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.ddlRecipe.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.ddlRecipe.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.ddlRecipe.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.ddlRecipe.DisplayMember = "Text"
        Me.ddlRecipe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ddlRecipe.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ddlRecipe.DropDownForeColor = System.Drawing.Color.Black
        Me.ddlRecipe.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.ddlRecipe.DropDownWidth = 246
        Me.ddlRecipe.GridLineColor = System.Drawing.Color.LightGray
        Me.ddlRecipe.GridLineHorizontal = False
        Me.ddlRecipe.GridLineVertical = False
        Me.ddlRecipe.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.ddlRecipe.Location = New System.Drawing.Point(157, 57)
        Me.ddlRecipe.ManagingFastMouseMoving = True
        Me.ddlRecipe.ManagingFastMouseMovingInterval = 30
        Me.ddlRecipe.Name = "ddlRecipe"
        Me.ddlRecipe.SelectedItem = Nothing
        Me.ddlRecipe.SelectedValue = Nothing
        Me.ddlRecipe.Size = New System.Drawing.Size(139, 21)
        Me.ddlRecipe.TabIndex = 16
        Me.ddlRecipe.ValueMember = "RecipeHdrUID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Recipe:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Shop Traveler #:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(726, 24)
        Me.MenuStrip1.TabIndex = 27
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
        Me.btnUpdate.Location = New System.Drawing.Point(12, 474)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(87, 27)
        Me.btnUpdate.TabIndex = 22
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmAddShopTrvlr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 575)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvDetails)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtmRunDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.numQty)
        Me.Controls.Add(Me.txtShopTraveler)
        Me.Controls.Add(Me.ddlRecipe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAddShopTrvlr"
        Me.Text = "Add/Edit/Delete Shop Traveler"
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvDetails As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtmRunDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents numQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtShopTraveler As System.Windows.Forms.TextBox
    Friend WithEvents ddlRecipe As MTGCComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents ShopdtlUID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemUID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InventUID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lotno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
