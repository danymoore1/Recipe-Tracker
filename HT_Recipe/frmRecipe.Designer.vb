<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecipe
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
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtChefName = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.lnkIngredients = New System.Windows.Forms.LinkLabel
        Me.numShelfLife = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtRecipeDesc = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.numTrays = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtRecipeName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ddlRecipe = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ddlItemNo = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.numMinTrays = New System.Windows.Forms.NumericUpDown
        CType(Me.numShelfLife, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTrays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.numMinTrays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 356)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 15)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Finished Product Code:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Chef Name:"
        '
        'txtChefName
        '
        Me.txtChefName.Location = New System.Drawing.Point(12, 264)
        Me.txtChefName.Name = "txtChefName"
        Me.txtChefName.Size = New System.Drawing.Size(116, 20)
        Me.txtChefName.TabIndex = 6
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(342, 452)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 27)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 452)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 27)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lnkIngredients
        '
        Me.lnkIngredients.AutoSize = True
        Me.lnkIngredients.Location = New System.Drawing.Point(293, 411)
        Me.lnkIngredients.Name = "lnkIngredients"
        Me.lnkIngredients.Size = New System.Drawing.Size(117, 15)
        Me.lnkIngredients.TabIndex = 9
        Me.lnkIngredients.TabStop = True
        Me.lnkIngredients.Text = "Manage Ingreidents"
        '
        'numShelfLife
        '
        Me.numShelfLife.Location = New System.Drawing.Point(12, 317)
        Me.numShelfLife.Name = "numShelfLife"
        Me.numShelfLife.Size = New System.Drawing.Size(90, 20)
        Me.numShelfLife.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Shelf Life:"
        '
        'txtRecipeDesc
        '
        Me.txtRecipeDesc.Location = New System.Drawing.Point(12, 160)
        Me.txtRecipeDesc.Name = "txtRecipeDesc"
        Me.txtRecipeDesc.Size = New System.Drawing.Size(301, 20)
        Me.txtRecipeDesc.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Description:"
        '
        'numTrays
        '
        Me.numTrays.Location = New System.Drawing.Point(12, 205)
        Me.numTrays.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.numTrays.Name = "numTrays"
        Me.numTrays.Size = New System.Drawing.Size(85, 20)
        Me.numTrays.TabIndex = 4
        Me.numTrays.Tag = "Amount of Trays the Recipe Makes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Max Amount Of Trays:"
        '
        'txtRecipeName
        '
        Me.txtRecipeName.Location = New System.Drawing.Point(12, 110)
        Me.txtRecipeName.Name = "txtRecipeName"
        Me.txtRecipeName.Size = New System.Drawing.Size(222, 20)
        Me.txtRecipeName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Recipe Name:"
        '
        'ddlRecipe
        '
        Me.ddlRecipe.DisplayMember = "RecipeID"
        Me.ddlRecipe.FormattingEnabled = True
        Me.ddlRecipe.Location = New System.Drawing.Point(12, 63)
        Me.ddlRecipe.Name = "ddlRecipe"
        Me.ddlRecipe.Size = New System.Drawing.Size(140, 23)
        Me.ddlRecipe.TabIndex = 0
        Me.ddlRecipe.ValueMember = "RecipeHdrUID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Recipe:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(463, 24)
        Me.MenuStrip1.TabIndex = 40
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
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "&Close"
        '
        'ddlItemNo
        '
        Me.ddlItemNo.DisplayMember = "ItemNo"
        Me.ddlItemNo.FormattingEnabled = True
        Me.ddlItemNo.Location = New System.Drawing.Point(12, 375)
        Me.ddlItemNo.Name = "ddlItemNo"
        Me.ddlItemNo.Size = New System.Drawing.Size(121, 23)
        Me.ddlItemNo.TabIndex = 8
        Me.ddlItemNo.ValueMember = "ItemUID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(233, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 15)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Min Amount Of Trays:"
        '
        'numMinTrays
        '
        Me.numMinTrays.Location = New System.Drawing.Point(236, 205)
        Me.numMinTrays.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.numMinTrays.Name = "numMinTrays"
        Me.numMinTrays.Size = New System.Drawing.Size(85, 20)
        Me.numMinTrays.TabIndex = 5
        '
        'frmRecipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 512)
        Me.Controls.Add(Me.ddlItemNo)
        Me.Controls.Add(Me.numMinTrays)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtChefName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lnkIngredients)
        Me.Controls.Add(Me.numShelfLife)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRecipeDesc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.numTrays)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRecipeName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ddlRecipe)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmRecipe"
        Me.Text = "Recipe Maintenance"
        CType(Me.numShelfLife, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTrays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.numMinTrays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtChefName As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lnkIngredients As System.Windows.Forms.LinkLabel
    Friend WithEvents numShelfLife As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRecipeDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents numTrays As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRecipeName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ddlRecipe As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ddlItemNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents numMinTrays As System.Windows.Forms.NumericUpDown
End Class
