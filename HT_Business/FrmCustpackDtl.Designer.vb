<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustpackDtl
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
        Me.numQty = New System.Windows.Forms.NumericUpDown
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.ddlItem = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlItemDtl = New System.Windows.Forms.Panel
        Me.lnkDelete = New System.Windows.Forms.LinkLabel
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lnkEdit = New System.Windows.Forms.LinkLabel
        Me.lnkAdd = New System.Windows.Forms.LinkLabel
        Me.lstCustomerItemDtl = New System.Windows.Forms.ListBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlItemDtl.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lnkCancel
        '
        Me.lnkCancel.AutoSize = True
        Me.lnkCancel.Location = New System.Drawing.Point(171, 145)
        Me.lnkCancel.Name = "lnkCancel"
        Me.lnkCancel.Size = New System.Drawing.Size(45, 15)
        Me.lnkCancel.TabIndex = 5
        Me.lnkCancel.TabStop = True
        Me.lnkCancel.Text = "Cancel"
        '
        'lnkUpdate
        '
        Me.lnkUpdate.AutoSize = True
        Me.lnkUpdate.Location = New System.Drawing.Point(9, 145)
        Me.lnkUpdate.Name = "lnkUpdate"
        Me.lnkUpdate.Size = New System.Drawing.Size(46, 15)
        Me.lnkUpdate.TabIndex = 4
        Me.lnkUpdate.TabStop = True
        Me.lnkUpdate.Text = "Update"
        '
        'numQty
        '
        Me.numQty.Location = New System.Drawing.Point(6, 96)
        Me.numQty.Name = "numQty"
        Me.numQty.Size = New System.Drawing.Size(163, 20)
        Me.numQty.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(303, 442)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(87, 27)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Qty"
        '
        'ddlItem
        '
        Me.ddlItem.DisplayMember = "Itemno"
        Me.ddlItem.FormattingEnabled = True
        Me.ddlItem.Location = New System.Drawing.Point(9, 28)
        Me.ddlItem.Name = "ddlItem"
        Me.ddlItem.Size = New System.Drawing.Size(163, 23)
        Me.ddlItem.TabIndex = 1
        Me.ddlItem.ValueMember = "ItemUID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item:"
        '
        'pnlItemDtl
        '
        Me.pnlItemDtl.Controls.Add(Me.lnkCancel)
        Me.pnlItemDtl.Controls.Add(Me.lnkUpdate)
        Me.pnlItemDtl.Controls.Add(Me.numQty)
        Me.pnlItemDtl.Controls.Add(Me.Label2)
        Me.pnlItemDtl.Controls.Add(Me.ddlItem)
        Me.pnlItemDtl.Controls.Add(Me.Label1)
        Me.pnlItemDtl.Location = New System.Drawing.Point(388, 43)
        Me.pnlItemDtl.Name = "pnlItemDtl"
        Me.pnlItemDtl.Size = New System.Drawing.Size(237, 232)
        Me.pnlItemDtl.TabIndex = 13
        '
        'lnkDelete
        '
        Me.lnkDelete.AutoSize = True
        Me.lnkDelete.Location = New System.Drawing.Point(273, 188)
        Me.lnkDelete.Name = "lnkDelete"
        Me.lnkDelete.Size = New System.Drawing.Size(42, 15)
        Me.lnkDelete.TabIndex = 12
        Me.lnkDelete.TabStop = True
        Me.lnkDelete.Text = "Delete"
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
        'lnkEdit
        '
        Me.lnkEdit.AutoSize = True
        Me.lnkEdit.Location = New System.Drawing.Point(273, 117)
        Me.lnkEdit.Name = "lnkEdit"
        Me.lnkEdit.Size = New System.Drawing.Size(30, 15)
        Me.lnkEdit.TabIndex = 11
        Me.lnkEdit.TabStop = True
        Me.lnkEdit.Text = "Edit"
        '
        'lnkAdd
        '
        Me.lnkAdd.AutoSize = True
        Me.lnkAdd.Location = New System.Drawing.Point(273, 43)
        Me.lnkAdd.Name = "lnkAdd"
        Me.lnkAdd.Size = New System.Drawing.Size(29, 15)
        Me.lnkAdd.TabIndex = 10
        Me.lnkAdd.TabStop = True
        Me.lnkAdd.Text = "Add"
        '
        'lstCustomerItemDtl
        '
        Me.lstCustomerItemDtl.DisplayMember = "Itemno"
        Me.lstCustomerItemDtl.FormattingEnabled = True
        Me.lstCustomerItemDtl.ItemHeight = 15
        Me.lstCustomerItemDtl.Location = New System.Drawing.Point(14, 43)
        Me.lstCustomerItemDtl.Name = "lstCustomerItemDtl"
        Me.lstCustomerItemDtl.Size = New System.Drawing.Size(249, 319)
        Me.lstCustomerItemDtl.TabIndex = 9
        Me.lstCustomerItemDtl.ValueMember = "CusDtlUID"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(666, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FrmCustpackDtl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 489)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.pnlItemDtl)
        Me.Controls.Add(Me.lnkDelete)
        Me.Controls.Add(Me.lnkEdit)
        Me.Controls.Add(Me.lnkAdd)
        Me.Controls.Add(Me.lstCustomerItemDtl)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmCustpackDtl"
        Me.Text = "Customer Pack Details"
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlItemDtl.ResumeLayout(False)
        Me.pnlItemDtl.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lnkCancel As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkUpdate As System.Windows.Forms.LinkLabel
    Friend WithEvents numQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ddlItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlItemDtl As System.Windows.Forms.Panel
    Friend WithEvents lnkDelete As System.Windows.Forms.LinkLabel
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lnkEdit As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkAdd As System.Windows.Forms.LinkLabel
    Friend WithEvents lstCustomerItemDtl As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
End Class
