<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecipeDtl
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
        Me.lnkDeleteMat = New System.Windows.Forms.LinkLabel
        Me.lnkEditMat = New System.Windows.Forms.LinkLabel
        Me.lnkAddMat = New System.Windows.Forms.LinkLabel
        Me.Label2 = New System.Windows.Forms.Label
        Me.lstMaterials = New System.Windows.Forms.ListBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.pnlMat = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.ddlItemType = New System.Windows.Forms.ComboBox
        Me.lnkMatCancel = New System.Windows.Forms.LinkLabel
        Me.lnkMatUpdate = New System.Windows.Forms.LinkLabel
        Me.numMatQty = New System.Windows.Forms.NumericUpDown
        Me.ddlMatUOM = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.ddlMaterial = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.pnlMat.SuspendLayout()
        CType(Me.numMatQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lnkDeleteMat
        '
        Me.lnkDeleteMat.AutoSize = True
        Me.lnkDeleteMat.Location = New System.Drawing.Point(281, 134)
        Me.lnkDeleteMat.Name = "lnkDeleteMat"
        Me.lnkDeleteMat.Size = New System.Drawing.Size(42, 15)
        Me.lnkDeleteMat.TabIndex = 4
        Me.lnkDeleteMat.TabStop = True
        Me.lnkDeleteMat.Text = "Delete"
        '
        'lnkEditMat
        '
        Me.lnkEditMat.AutoSize = True
        Me.lnkEditMat.Location = New System.Drawing.Point(281, 98)
        Me.lnkEditMat.Name = "lnkEditMat"
        Me.lnkEditMat.Size = New System.Drawing.Size(30, 15)
        Me.lnkEditMat.TabIndex = 3
        Me.lnkEditMat.TabStop = True
        Me.lnkEditMat.Text = "Edit"
        '
        'lnkAddMat
        '
        Me.lnkAddMat.AutoSize = True
        Me.lnkAddMat.Location = New System.Drawing.Point(281, 62)
        Me.lnkAddMat.Name = "lnkAddMat"
        Me.lnkAddMat.Size = New System.Drawing.Size(29, 15)
        Me.lnkAddMat.TabIndex = 2
        Me.lnkAddMat.TabStop = True
        Me.lnkAddMat.Text = "Add"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Ingredients -- Materials"
        '
        'lstMaterials
        '
        Me.lstMaterials.DisplayMember = "ItemNo"
        Me.lstMaterials.FormattingEnabled = True
        Me.lstMaterials.ItemHeight = 15
        Me.lstMaterials.Location = New System.Drawing.Point(12, 62)
        Me.lstMaterials.Name = "lstMaterials"
        Me.lstMaterials.Size = New System.Drawing.Size(252, 304)
        Me.lstMaterials.TabIndex = 7
        Me.lstMaterials.ValueMember = "RecipeDtlUID"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(605, 24)
        Me.MenuStrip1.TabIndex = 12
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
        'pnlMat
        '
        Me.pnlMat.Controls.Add(Me.Label1)
        Me.pnlMat.Controls.Add(Me.ddlItemType)
        Me.pnlMat.Controls.Add(Me.lnkMatCancel)
        Me.pnlMat.Controls.Add(Me.lnkMatUpdate)
        Me.pnlMat.Controls.Add(Me.numMatQty)
        Me.pnlMat.Controls.Add(Me.ddlMatUOM)
        Me.pnlMat.Controls.Add(Me.Label6)
        Me.pnlMat.Controls.Add(Me.Label7)
        Me.pnlMat.Controls.Add(Me.ddlMaterial)
        Me.pnlMat.Controls.Add(Me.Label8)
        Me.pnlMat.Location = New System.Drawing.Point(365, 62)
        Me.pnlMat.Name = "pnlMat"
        Me.pnlMat.Size = New System.Drawing.Size(203, 271)
        Me.pnlMat.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Item Type:"
        '
        'ddlItemType
        '
        Me.ddlItemType.DisplayMember = "ItemType"
        Me.ddlItemType.FormattingEnabled = True
        Me.ddlItemType.Location = New System.Drawing.Point(5, 33)
        Me.ddlItemType.Name = "ddlItemType"
        Me.ddlItemType.Size = New System.Drawing.Size(121, 23)
        Me.ddlItemType.TabIndex = 8
        Me.ddlItemType.ValueMember = "ItemTypeUID"
        '
        'lnkMatCancel
        '
        Me.lnkMatCancel.AutoSize = True
        Me.lnkMatCancel.Location = New System.Drawing.Point(131, 253)
        Me.lnkMatCancel.Name = "lnkMatCancel"
        Me.lnkMatCancel.Size = New System.Drawing.Size(45, 15)
        Me.lnkMatCancel.TabIndex = 13
        Me.lnkMatCancel.TabStop = True
        Me.lnkMatCancel.Text = "Cancel"
        '
        'lnkMatUpdate
        '
        Me.lnkMatUpdate.AutoSize = True
        Me.lnkMatUpdate.Location = New System.Drawing.Point(8, 253)
        Me.lnkMatUpdate.Name = "lnkMatUpdate"
        Me.lnkMatUpdate.Size = New System.Drawing.Size(46, 15)
        Me.lnkMatUpdate.TabIndex = 12
        Me.lnkMatUpdate.TabStop = True
        Me.lnkMatUpdate.Text = "Update"
        '
        'numMatQty
        '
        Me.numMatQty.DecimalPlaces = 2
        Me.numMatQty.Location = New System.Drawing.Point(5, 192)
        Me.numMatQty.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.numMatQty.Name = "numMatQty"
        Me.numMatQty.Size = New System.Drawing.Size(145, 20)
        Me.numMatQty.TabIndex = 10
        '
        'ddlMatUOM
        '
        Me.ddlMatUOM.DisplayMember = "UOM"
        Me.ddlMatUOM.FormattingEnabled = True
        Me.ddlMatUOM.Location = New System.Drawing.Point(5, 137)
        Me.ddlMatUOM.Name = "ddlMatUOM"
        Me.ddlMatUOM.Size = New System.Drawing.Size(140, 23)
        Me.ddlMatUOM.TabIndex = 10
        Me.ddlMatUOM.ValueMember = "UOMUID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Unit Of Measure"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Qty"
        '
        'ddlMaterial
        '
        Me.ddlMaterial.DisplayMember = "ItemNo"
        Me.ddlMaterial.FormattingEnabled = True
        Me.ddlMaterial.Location = New System.Drawing.Point(5, 82)
        Me.ddlMaterial.Name = "ddlMaterial"
        Me.ddlMaterial.Size = New System.Drawing.Size(140, 23)
        Me.ddlMaterial.TabIndex = 9
        Me.ddlMaterial.ValueMember = "ItemUID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Items:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(284, 434)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmRecipeDtl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 469)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.pnlMat)
        Me.Controls.Add(Me.lnkDeleteMat)
        Me.Controls.Add(Me.lnkEditMat)
        Me.Controls.Add(Me.lnkAddMat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstMaterials)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmRecipeDtl"
        Me.Text = "frmRecipeDtl"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlMat.ResumeLayout(False)
        Me.pnlMat.PerformLayout()
        CType(Me.numMatQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lnkDeleteMat As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkEditMat As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkAddMat As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstMaterials As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlMat As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ddlItemType As System.Windows.Forms.ComboBox
    Friend WithEvents lnkMatCancel As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkMatUpdate As System.Windows.Forms.LinkLabel
    Friend WithEvents numMatQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents ddlMatUOM As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ddlMaterial As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
