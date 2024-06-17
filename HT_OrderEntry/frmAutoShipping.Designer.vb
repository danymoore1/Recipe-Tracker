<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutoShipping
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dtmSchShipDte = New System.Windows.Forms.DateTimePicker
        Me.CustName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PONO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnLoad = New System.Windows.Forms.Button
        Me.DeliveryDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrderNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnPickTickets = New System.Windows.Forms.Button
        Me.dgvshipping = New System.Windows.Forms.DataGridView
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvshipping, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtmSchShipDte
        '
        Me.dtmSchShipDte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmSchShipDte.Location = New System.Drawing.Point(215, 41)
        Me.dtmSchShipDte.Margin = New System.Windows.Forms.Padding(5)
        Me.dtmSchShipDte.Name = "dtmSchShipDte"
        Me.dtmSchShipDte.Size = New System.Drawing.Size(135, 20)
        Me.dtmSchShipDte.TabIndex = 5
        '
        'CustName
        '
        Me.CustName.DataPropertyName = "CustName"
        Me.CustName.HeaderText = "Customer"
        Me.CustName.Name = "CustName"
        '
        'PONO
        '
        Me.PONO.DataPropertyName = "PONO"
        Me.PONO.HeaderText = "PO #"
        Me.PONO.Name = "PONO"
        '
        'Qty
        '
        Me.Qty.DataPropertyName = "Qty"
        Me.Qty.HeaderText = "Total Qty"
        Me.Qty.Name = "Qty"
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(533, 37)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(87, 27)
        Me.btnLoad.TabIndex = 7
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'DeliveryDate
        '
        Me.DeliveryDate.DataPropertyName = "DeliveryDate"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = "01/01/1900"
        Me.DeliveryDate.DefaultCellStyle = DataGridViewCellStyle1
        Me.DeliveryDate.HeaderText = "Sch Ship Date"
        Me.DeliveryDate.Name = "DeliveryDate"
        '
        'OrderNo
        '
        Me.OrderNo.DataPropertyName = "OrderNo"
        Me.OrderNo.HeaderText = "Order #"
        Me.OrderNo.Name = "OrderNo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Choose Date:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(666, 24)
        Me.MenuStrip1.TabIndex = 9
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
        'btnPickTickets
        '
        Me.btnPickTickets.Location = New System.Drawing.Point(153, 595)
        Me.btnPickTickets.Name = "btnPickTickets"
        Me.btnPickTickets.Size = New System.Drawing.Size(131, 51)
        Me.btnPickTickets.TabIndex = 11
        Me.btnPickTickets.Text = "Print Pick Tickets"
        Me.btnPickTickets.UseVisualStyleBackColor = True
        '
        'dgvshipping
        '
        Me.dgvshipping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvshipping.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderNo, Me.DeliveryDate, Me.CustName, Me.PONO, Me.Qty})
        Me.dgvshipping.Location = New System.Drawing.Point(15, 79)
        Me.dgvshipping.Name = "dgvshipping"
        Me.dgvshipping.Size = New System.Drawing.Size(638, 508)
        Me.dgvshipping.TabIndex = 8
        '
        'frmAutoShipping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 651)
        Me.Controls.Add(Me.dtmSchShipDte)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnPickTickets)
        Me.Controls.Add(Me.dgvshipping)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmAutoShipping"
        Me.Text = "frmAutoShipping"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvshipping, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtmSchShipDte As System.Windows.Forms.DateTimePicker
    Friend WithEvents CustName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PONO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents DeliveryDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPickTickets As System.Windows.Forms.Button
    Friend WithEvents dgvshipping As System.Windows.Forms.DataGridView
End Class
