<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoicing
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
        Me.lnkSelectAll = New System.Windows.Forms.LinkLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnPrint = New System.Windows.Forms.Button
        Me.chklInvoices = New System.Windows.Forms.CheckedListBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lnkDeselectAll = New System.Windows.Forms.LinkLabel
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lnkSelectAll
        '
        Me.lnkSelectAll.AutoSize = True
        Me.lnkSelectAll.Location = New System.Drawing.Point(379, 72)
        Me.lnkSelectAll.Name = "lnkSelectAll"
        Me.lnkSelectAll.Size = New System.Drawing.Size(60, 15)
        Me.lnkSelectAll.TabIndex = 10
        Me.lnkSelectAll.TabStop = True
        Me.lnkSelectAll.Text = "Select All"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Orders Ready For Invoicing"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(15, 413)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(152, 27)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "Print Invoices"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'chklInvoices
        '
        Me.chklInvoices.FormattingEnabled = True
        Me.chklInvoices.Location = New System.Drawing.Point(14, 72)
        Me.chklInvoices.Name = "chklInvoices"
        Me.chklInvoices.Size = New System.Drawing.Size(356, 319)
        Me.chklInvoices.TabIndex = 6
        Me.chklInvoices.ThreeDCheckBoxes = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(541, 24)
        Me.MenuStrip1.TabIndex = 7
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
        'lnkDeselectAll
        '
        Me.lnkDeselectAll.AutoSize = True
        Me.lnkDeselectAll.Location = New System.Drawing.Point(379, 390)
        Me.lnkDeselectAll.Name = "lnkDeselectAll"
        Me.lnkDeselectAll.Size = New System.Drawing.Size(74, 15)
        Me.lnkDeselectAll.TabIndex = 11
        Me.lnkDeselectAll.TabStop = True
        Me.lnkDeselectAll.Text = "Deselect All"
        '
        'frmInvoicing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 525)
        Me.Controls.Add(Me.lnkSelectAll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.chklInvoices)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lnkDeselectAll)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmInvoicing"
        Me.Text = "Invoicing"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lnkSelectAll As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents chklInvoices As System.Windows.Forms.CheckedListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lnkDeselectAll As System.Windows.Forms.LinkLabel
End Class
