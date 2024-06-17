<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompleteShopTrvlr
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
        Me.dgvShopTraveler = New System.Windows.Forms.DataGridView
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CLoseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.numTrays = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnComplete = New System.Windows.Forms.Button
        Me.ddlShopTraveler = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkClose = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblTrayQty = New System.Windows.Forms.Label
        CType(Me.dgvShopTraveler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.numTrays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvShopTraveler
        '
        Me.dgvShopTraveler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShopTraveler.Location = New System.Drawing.Point(12, 89)
        Me.dgvShopTraveler.Name = "dgvShopTraveler"
        Me.dgvShopTraveler.ReadOnly = True
        Me.dgvShopTraveler.Size = New System.Drawing.Size(569, 402)
        Me.dgvShopTraveler.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(607, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CLoseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CLoseToolStripMenuItem
        '
        Me.CLoseToolStripMenuItem.Name = "CLoseToolStripMenuItem"
        Me.CLoseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CLoseToolStripMenuItem.Text = "&Close"
        '
        'numTrays
        '
        Me.numTrays.Location = New System.Drawing.Point(12, 530)
        Me.numTrays.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.numTrays.Name = "numTrays"
        Me.numTrays.Size = New System.Drawing.Size(140, 20)
        Me.numTrays.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 508)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Amount Of Trays Created:"
        '
        'btnComplete
        '
        Me.btnComplete.Location = New System.Drawing.Point(498, 508)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(87, 27)
        Me.btnComplete.TabIndex = 3
        Me.btnComplete.Text = "Complete"
        Me.btnComplete.UseVisualStyleBackColor = True
        '
        'ddlShopTraveler
        '
        Me.ddlShopTraveler.DisplayMember = "TravelerNum"
        Me.ddlShopTraveler.FormattingEnabled = True
        Me.ddlShopTraveler.Location = New System.Drawing.Point(18, 60)
        Me.ddlShopTraveler.Name = "ddlShopTraveler"
        Me.ddlShopTraveler.Size = New System.Drawing.Size(140, 23)
        Me.ddlShopTraveler.TabIndex = 0
        Me.ddlShopTraveler.ValueMember = "TravelerUID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Shop Traveler:"
        '
        'chkClose
        '
        Me.chkClose.AutoSize = True
        Me.chkClose.Location = New System.Drawing.Point(498, 60)
        Me.chkClose.Name = "chkClose"
        Me.chkClose.Size = New System.Drawing.Size(56, 19)
        Me.chkClose.TabIndex = 7
        Me.chkClose.Text = "Close"
        Me.chkClose.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Orignal Tray Qty:"
        '
        'lblTrayQty
        '
        Me.lblTrayQty.AutoSize = True
        Me.lblTrayQty.Location = New System.Drawing.Point(258, 57)
        Me.lblTrayQty.Name = "lblTrayQty"
        Me.lblTrayQty.Size = New System.Drawing.Size(43, 15)
        Me.lblTrayQty.TabIndex = 9
        Me.lblTrayQty.Text = "Label4"
        '
        'frmCompleteShopTrvlr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 565)
        Me.Controls.Add(Me.lblTrayQty)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ddlShopTraveler)
        Me.Controls.Add(Me.btnComplete)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numTrays)
        Me.Controls.Add(Me.dgvShopTraveler)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCompleteShopTrvlr"
        Me.Text = "Complete Shop Traveler"
        CType(Me.dgvShopTraveler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.numTrays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvShopTraveler As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CLoseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents numTrays As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnComplete As System.Windows.Forms.Button
    Friend WithEvents ddlShopTraveler As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkClose As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTrayQty As System.Windows.Forms.Label
End Class
