<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShip
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
        Me.btnBOL = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.dgvShip = New System.Windows.Forms.DataGridView
        Me.ShipUID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipItemNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CusPackDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Lotno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblPONO = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblShipToAddr2 = New System.Windows.Forms.Label
        Me.lblShipToZip = New System.Windows.Forms.Label
        Me.lblShipToState = New System.Windows.Forms.Label
        Me.lblShipToCity = New System.Windows.Forms.Label
        Me.lblShipToAddr1 = New System.Windows.Forms.Label
        Me.lblShipToName = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ddlOrderNo = New System.Windows.Forms.ComboBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnPrintTicket = New System.Windows.Forms.Button
        CType(Me.dgvShip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBOL
        '
        Me.btnBOL.Location = New System.Drawing.Point(533, 365)
        Me.btnBOL.Name = "btnBOL"
        Me.btnBOL.Size = New System.Drawing.Size(87, 27)
        Me.btnBOL.TabIndex = 29
        Me.btnBOL.Text = "Print BOL"
        Me.btnBOL.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(533, 449)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 27)
        Me.btnCancel.TabIndex = 28
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(533, 191)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(87, 27)
        Me.btnUpdate.TabIndex = 27
        Me.btnUpdate.Text = "OK"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'dgvShip
        '
        Me.dgvShip.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvShip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShip.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ShipUID, Me.ShipItemNo, Me.CusPackDesc, Me.Lotno, Me.ShipQty})
        Me.dgvShip.Location = New System.Drawing.Point(10, 191)
        Me.dgvShip.Name = "dgvShip"
        Me.dgvShip.Size = New System.Drawing.Size(517, 285)
        Me.dgvShip.TabIndex = 26
        '
        'ShipUID
        '
        Me.ShipUID.DataPropertyName = "ShipUID"
        Me.ShipUID.HeaderText = ""
        Me.ShipUID.Name = "ShipUID"
        Me.ShipUID.Visible = False
        '
        'ShipItemNo
        '
        Me.ShipItemNo.DataPropertyName = "ItemNo"
        Me.ShipItemNo.HeaderText = "Ship Item #"
        Me.ShipItemNo.Name = "ShipItemNo"
        '
        'CusPackDesc
        '
        Me.CusPackDesc.DataPropertyName = "ItemDesc"
        Me.CusPackDesc.HeaderText = "Description"
        Me.CusPackDesc.Name = "CusPackDesc"
        Me.CusPackDesc.Width = 150
        '
        'Lotno
        '
        Me.Lotno.DataPropertyName = "Lotno"
        Me.Lotno.HeaderText = "Lot #"
        Me.Lotno.Name = "Lotno"
        '
        'ShipQty
        '
        Me.ShipQty.DataPropertyName = "Qty"
        Me.ShipQty.HeaderText = "Ship Qty"
        Me.ShipQty.Name = "ShipQty"
        '
        'lblPONO
        '
        Me.lblPONO.AutoSize = True
        Me.lblPONO.Location = New System.Drawing.Point(394, 74)
        Me.lblPONO.Name = "lblPONO"
        Me.lblPONO.Size = New System.Drawing.Size(43, 15)
        Me.lblPONO.TabIndex = 25
        Me.lblPONO.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(353, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 15)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "PO:"
        '
        'lblShipToAddr2
        '
        Me.lblShipToAddr2.AutoSize = True
        Me.lblShipToAddr2.Location = New System.Drawing.Point(14, 153)
        Me.lblShipToAddr2.Name = "lblShipToAddr2"
        Me.lblShipToAddr2.Size = New System.Drawing.Size(43, 15)
        Me.lblShipToAddr2.TabIndex = 23
        Me.lblShipToAddr2.Text = "Label8"
        '
        'lblShipToZip
        '
        Me.lblShipToZip.AutoSize = True
        Me.lblShipToZip.Location = New System.Drawing.Point(324, 168)
        Me.lblShipToZip.Name = "lblShipToZip"
        Me.lblShipToZip.Size = New System.Drawing.Size(43, 15)
        Me.lblShipToZip.TabIndex = 22
        Me.lblShipToZip.Text = "Label7"
        '
        'lblShipToState
        '
        Me.lblShipToState.AutoSize = True
        Me.lblShipToState.Location = New System.Drawing.Point(230, 168)
        Me.lblShipToState.Name = "lblShipToState"
        Me.lblShipToState.Size = New System.Drawing.Size(43, 15)
        Me.lblShipToState.TabIndex = 21
        Me.lblShipToState.Text = "Label6"
        '
        'lblShipToCity
        '
        Me.lblShipToCity.AutoSize = True
        Me.lblShipToCity.Location = New System.Drawing.Point(14, 168)
        Me.lblShipToCity.Name = "lblShipToCity"
        Me.lblShipToCity.Size = New System.Drawing.Size(43, 15)
        Me.lblShipToCity.TabIndex = 20
        Me.lblShipToCity.Text = "Label5"
        '
        'lblShipToAddr1
        '
        Me.lblShipToAddr1.AutoSize = True
        Me.lblShipToAddr1.Location = New System.Drawing.Point(14, 138)
        Me.lblShipToAddr1.Name = "lblShipToAddr1"
        Me.lblShipToAddr1.Size = New System.Drawing.Size(43, 15)
        Me.lblShipToAddr1.TabIndex = 19
        Me.lblShipToAddr1.Text = "Label4"
        '
        'lblShipToName
        '
        Me.lblShipToName.AutoSize = True
        Me.lblShipToName.Location = New System.Drawing.Point(14, 123)
        Me.lblShipToName.Name = "lblShipToName"
        Me.lblShipToName.Size = New System.Drawing.Size(43, 15)
        Me.lblShipToName.TabIndex = 18
        Me.lblShipToName.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Ship To Info:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Order:"
        '
        'ddlOrderNo
        '
        Me.ddlOrderNo.DisplayMember = "OrderNo"
        Me.ddlOrderNo.FormattingEnabled = True
        Me.ddlOrderNo.Location = New System.Drawing.Point(14, 66)
        Me.ddlOrderNo.Name = "ddlOrderNo"
        Me.ddlOrderNo.Size = New System.Drawing.Size(163, 23)
        Me.ddlOrderNo.TabIndex = 15
        Me.ddlOrderNo.ValueMember = "OrdrHeaderUID"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(676, 24)
        Me.MenuStrip1.TabIndex = 30
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
        'btnPrintTicket
        '
        Me.btnPrintTicket.Location = New System.Drawing.Point(533, 265)
        Me.btnPrintTicket.Name = "btnPrintTicket"
        Me.btnPrintTicket.Size = New System.Drawing.Size(87, 47)
        Me.btnPrintTicket.TabIndex = 31
        Me.btnPrintTicket.Text = "Print Pick Ticket"
        Me.btnPrintTicket.UseVisualStyleBackColor = True
        '
        'frmShip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 490)
        Me.Controls.Add(Me.btnPrintTicket)
        Me.Controls.Add(Me.btnBOL)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dgvShip)
        Me.Controls.Add(Me.lblPONO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblShipToAddr2)
        Me.Controls.Add(Me.lblShipToZip)
        Me.Controls.Add(Me.lblShipToState)
        Me.Controls.Add(Me.lblShipToCity)
        Me.Controls.Add(Me.lblShipToAddr1)
        Me.Controls.Add(Me.lblShipToName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ddlOrderNo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmShip"
        Me.Text = "Shipping"
        CType(Me.dgvShip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBOL As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents dgvShip As System.Windows.Forms.DataGridView
    Friend WithEvents lblPONO As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblShipToAddr2 As System.Windows.Forms.Label
    Friend WithEvents lblShipToZip As System.Windows.Forms.Label
    Friend WithEvents lblShipToState As System.Windows.Forms.Label
    Friend WithEvents lblShipToCity As System.Windows.Forms.Label
    Friend WithEvents lblShipToAddr1 As System.Windows.Forms.Label
    Friend WithEvents lblShipToName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ddlOrderNo As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShipUID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipItemNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CusPackDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lotno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrintTicket As System.Windows.Forms.Button
End Class
