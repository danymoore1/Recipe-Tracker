<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemDefin
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
        Me.tabItemType = New System.Windows.Forms.TabPage
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.txtItemTypeDesc = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ddlItemType = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tabItemGrp = New System.Windows.Forms.TabPage
        Me.btnGCancel = New System.Windows.Forms.Button
        Me.btnGUpdate = New System.Windows.Forms.Button
        Me.txtItemgrpDesc = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ddlItemGrp = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl1.SuspendLayout()
        Me.tabItemType.SuspendLayout()
        Me.tabItemGrp.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabItemType)
        Me.TabControl1.Controls.Add(Me.tabItemGrp)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(354, 273)
        Me.TabControl1.TabIndex = 0
        '
        'tabItemType
        '
        Me.tabItemType.Controls.Add(Me.btnClose)
        Me.tabItemType.Controls.Add(Me.btnUpdate)
        Me.tabItemType.Controls.Add(Me.txtItemTypeDesc)
        Me.tabItemType.Controls.Add(Me.Label2)
        Me.tabItemType.Controls.Add(Me.ddlItemType)
        Me.tabItemType.Controls.Add(Me.Label1)
        Me.tabItemType.Location = New System.Drawing.Point(4, 24)
        Me.tabItemType.Name = "tabItemType"
        Me.tabItemType.Padding = New System.Windows.Forms.Padding(3)
        Me.tabItemType.Size = New System.Drawing.Size(346, 245)
        Me.tabItemType.TabIndex = 0
        Me.tabItemType.Text = "Item Types"
        Me.tabItemType.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(214, 162)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(13, 163)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Save"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtItemTypeDesc
        '
        Me.txtItemTypeDesc.Location = New System.Drawing.Point(13, 109)
        Me.txtItemTypeDesc.Name = "txtItemTypeDesc"
        Me.txtItemTypeDesc.Size = New System.Drawing.Size(270, 20)
        Me.txtItemTypeDesc.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Item Type Description"
        '
        'ddlItemType
        '
        Me.ddlItemType.DisplayMember = "ItemType"
        Me.ddlItemType.FormattingEnabled = True
        Me.ddlItemType.Location = New System.Drawing.Point(10, 43)
        Me.ddlItemType.Name = "ddlItemType"
        Me.ddlItemType.Size = New System.Drawing.Size(121, 23)
        Me.ddlItemType.TabIndex = 1
        Me.ddlItemType.ValueMember = "ItemTypeUID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item Type:"
        '
        'tabItemGrp
        '
        Me.tabItemGrp.Controls.Add(Me.btnGCancel)
        Me.tabItemGrp.Controls.Add(Me.btnGUpdate)
        Me.tabItemGrp.Controls.Add(Me.txtItemgrpDesc)
        Me.tabItemGrp.Controls.Add(Me.Label3)
        Me.tabItemGrp.Controls.Add(Me.ddlItemGrp)
        Me.tabItemGrp.Controls.Add(Me.Label4)
        Me.tabItemGrp.Location = New System.Drawing.Point(4, 24)
        Me.tabItemGrp.Name = "tabItemGrp"
        Me.tabItemGrp.Padding = New System.Windows.Forms.Padding(3)
        Me.tabItemGrp.Size = New System.Drawing.Size(346, 245)
        Me.tabItemGrp.TabIndex = 1
        Me.tabItemGrp.Text = "Item Group"
        Me.tabItemGrp.UseVisualStyleBackColor = True
        '
        'btnGCancel
        '
        Me.btnGCancel.Location = New System.Drawing.Point(210, 145)
        Me.btnGCancel.Name = "btnGCancel"
        Me.btnGCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnGCancel.TabIndex = 11
        Me.btnGCancel.Text = "Close"
        Me.btnGCancel.UseVisualStyleBackColor = True
        '
        'btnGUpdate
        '
        Me.btnGUpdate.Location = New System.Drawing.Point(9, 146)
        Me.btnGUpdate.Name = "btnGUpdate"
        Me.btnGUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnGUpdate.TabIndex = 10
        Me.btnGUpdate.Text = "Save"
        Me.btnGUpdate.UseVisualStyleBackColor = True
        '
        'txtItemgrpDesc
        '
        Me.txtItemgrpDesc.Location = New System.Drawing.Point(9, 92)
        Me.txtItemgrpDesc.Name = "txtItemgrpDesc"
        Me.txtItemgrpDesc.Size = New System.Drawing.Size(270, 20)
        Me.txtItemgrpDesc.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Item Group Description"
        '
        'ddlItemGrp
        '
        Me.ddlItemGrp.DisplayMember = "ItemGroup"
        Me.ddlItemGrp.FormattingEnabled = True
        Me.ddlItemGrp.Location = New System.Drawing.Point(6, 26)
        Me.ddlItemGrp.Name = "ddlItemGrp"
        Me.ddlItemGrp.Size = New System.Drawing.Size(121, 23)
        Me.ddlItemGrp.TabIndex = 7
        Me.ddlItemGrp.ValueMember = "ItemGrpUID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Item Group:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(383, 24)
        Me.MenuStrip1.TabIndex = 1
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
        'frmItemDefin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 323)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmItemDefin"
        Me.Text = "Item Types / Item Group"
        Me.TabControl1.ResumeLayout(False)
        Me.tabItemType.ResumeLayout(False)
        Me.tabItemType.PerformLayout()
        Me.tabItemGrp.ResumeLayout(False)
        Me.tabItemGrp.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabItemType As System.Windows.Forms.TabPage
    Friend WithEvents tabItemGrp As System.Windows.Forms.TabPage
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtItemTypeDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ddlItemType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnGCancel As System.Windows.Forms.Button
    Friend WithEvents btnGUpdate As System.Windows.Forms.Button
    Friend WithEvents txtItemgrpDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ddlItemGrp As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
