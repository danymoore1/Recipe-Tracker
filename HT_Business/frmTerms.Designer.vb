<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTerms
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
        Me.tabNetTerms = New System.Windows.Forms.TabPage
        Me.btnNetCancel = New System.Windows.Forms.Button
        Me.btnNetSave = New System.Windows.Forms.Button
        Me.txtNetTermsDesc = New System.Windows.Forms.TextBox
        Me.ddlNetTerms = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tabShipTerms = New System.Windows.Forms.TabPage
        Me.txtShipDesc = New System.Windows.Forms.TextBox
        Me.ddlshipterms = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnShipCancel = New System.Windows.Forms.Button
        Me.btnShipSave = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl1.SuspendLayout()
        Me.tabNetTerms.SuspendLayout()
        Me.tabShipTerms.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabNetTerms)
        Me.TabControl1.Controls.Add(Me.tabShipTerms)
        Me.TabControl1.Location = New System.Drawing.Point(14, 31)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(418, 244)
        Me.TabControl1.TabIndex = 1
        '
        'tabNetTerms
        '
        Me.tabNetTerms.Controls.Add(Me.btnNetCancel)
        Me.tabNetTerms.Controls.Add(Me.btnNetSave)
        Me.tabNetTerms.Controls.Add(Me.txtNetTermsDesc)
        Me.tabNetTerms.Controls.Add(Me.ddlNetTerms)
        Me.tabNetTerms.Controls.Add(Me.Label3)
        Me.tabNetTerms.Controls.Add(Me.Label1)
        Me.tabNetTerms.Location = New System.Drawing.Point(4, 24)
        Me.tabNetTerms.Name = "tabNetTerms"
        Me.tabNetTerms.Padding = New System.Windows.Forms.Padding(3)
        Me.tabNetTerms.Size = New System.Drawing.Size(410, 216)
        Me.tabNetTerms.TabIndex = 0
        Me.tabNetTerms.Text = "Net Terms"
        Me.tabNetTerms.UseVisualStyleBackColor = True
        '
        'btnNetCancel
        '
        Me.btnNetCancel.Location = New System.Drawing.Point(254, 136)
        Me.btnNetCancel.Name = "btnNetCancel"
        Me.btnNetCancel.Size = New System.Drawing.Size(99, 25)
        Me.btnNetCancel.TabIndex = 7
        Me.btnNetCancel.Text = "Cancel"
        Me.btnNetCancel.UseVisualStyleBackColor = True
        '
        'btnNetSave
        '
        Me.btnNetSave.Location = New System.Drawing.Point(6, 136)
        Me.btnNetSave.Name = "btnNetSave"
        Me.btnNetSave.Size = New System.Drawing.Size(99, 25)
        Me.btnNetSave.TabIndex = 6
        Me.btnNetSave.Text = "Save"
        Me.btnNetSave.UseVisualStyleBackColor = True
        '
        'txtNetTermsDesc
        '
        Me.txtNetTermsDesc.Location = New System.Drawing.Point(30, 110)
        Me.txtNetTermsDesc.Name = "txtNetTermsDesc"
        Me.txtNetTermsDesc.Size = New System.Drawing.Size(322, 20)
        Me.txtNetTermsDesc.TabIndex = 5
        '
        'ddlNetTerms
        '
        Me.ddlNetTerms.DisplayMember = "NetTerms"
        Me.ddlNetTerms.FormattingEnabled = True
        Me.ddlNetTerms.Location = New System.Drawing.Point(33, 45)
        Me.ddlNetTerms.Name = "ddlNetTerms"
        Me.ddlNetTerms.Size = New System.Drawing.Size(135, 23)
        Me.ddlNetTerms.TabIndex = 3
        Me.ddlNetTerms.ValueMember = "NetTermsUID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Terms"
        '
        'tabShipTerms
        '
        Me.tabShipTerms.Controls.Add(Me.txtShipDesc)
        Me.tabShipTerms.Controls.Add(Me.ddlshipterms)
        Me.tabShipTerms.Controls.Add(Me.Label4)
        Me.tabShipTerms.Controls.Add(Me.Label6)
        Me.tabShipTerms.Controls.Add(Me.btnShipCancel)
        Me.tabShipTerms.Controls.Add(Me.btnShipSave)
        Me.tabShipTerms.Location = New System.Drawing.Point(4, 24)
        Me.tabShipTerms.Name = "tabShipTerms"
        Me.tabShipTerms.Padding = New System.Windows.Forms.Padding(3)
        Me.tabShipTerms.Size = New System.Drawing.Size(410, 216)
        Me.tabShipTerms.TabIndex = 1
        Me.tabShipTerms.Text = "Shipping Terms"
        Me.tabShipTerms.UseVisualStyleBackColor = True
        '
        'txtShipDesc
        '
        Me.txtShipDesc.Location = New System.Drawing.Point(33, 109)
        Me.txtShipDesc.Name = "txtShipDesc"
        Me.txtShipDesc.Size = New System.Drawing.Size(322, 20)
        Me.txtShipDesc.TabIndex = 15
        '
        'ddlshipterms
        '
        Me.ddlshipterms.DisplayMember = "ShipTerms"
        Me.ddlshipterms.FormattingEnabled = True
        Me.ddlshipterms.Location = New System.Drawing.Point(33, 45)
        Me.ddlshipterms.Name = "ddlshipterms"
        Me.ddlshipterms.Size = New System.Drawing.Size(135, 23)
        Me.ddlshipterms.TabIndex = 13
        Me.ddlshipterms.ValueMember = "ShipTermsUID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Description"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Terms"
        '
        'btnShipCancel
        '
        Me.btnShipCancel.Location = New System.Drawing.Point(254, 135)
        Me.btnShipCancel.Name = "btnShipCancel"
        Me.btnShipCancel.Size = New System.Drawing.Size(99, 24)
        Me.btnShipCancel.TabIndex = 9
        Me.btnShipCancel.Text = "Cancel"
        Me.btnShipCancel.UseVisualStyleBackColor = True
        '
        'btnShipSave
        '
        Me.btnShipSave.Location = New System.Drawing.Point(6, 135)
        Me.btnShipSave.Name = "btnShipSave"
        Me.btnShipSave.Size = New System.Drawing.Size(99, 24)
        Me.btnShipSave.TabIndex = 8
        Me.btnShipSave.Text = "Save"
        Me.btnShipSave.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(439, 24)
        Me.MenuStrip1.TabIndex = 2
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
        'frmTerms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 287)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTerms"
        Me.Text = "frmTerms"
        Me.TabControl1.ResumeLayout(False)
        Me.tabNetTerms.ResumeLayout(False)
        Me.tabNetTerms.PerformLayout()
        Me.tabShipTerms.ResumeLayout(False)
        Me.tabShipTerms.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabNetTerms As System.Windows.Forms.TabPage
    Friend WithEvents btnNetCancel As System.Windows.Forms.Button
    Friend WithEvents btnNetSave As System.Windows.Forms.Button
    Friend WithEvents txtNetTermsDesc As System.Windows.Forms.TextBox
    Friend WithEvents ddlNetTerms As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabShipTerms As System.Windows.Forms.TabPage
    Friend WithEvents txtShipDesc As System.Windows.Forms.TextBox
    Friend WithEvents ddlshipterms As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnShipCancel As System.Windows.Forms.Button
    Friend WithEvents btnShipSave As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
