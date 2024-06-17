Imports System.Windows.Forms

Public Class frmAddShopTrvlr
    Public TravelerUID As Integer  'Use through out Form - Holds current Traveler ---- Could be passed into screen for Update or Delete
    Public UserUID As Integer 'This is passed in from the Main Forms
    Private RecordAdded As Integer
    Private Sub frmAddShopTrvlr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load Recipe Drop Down
        Load_ddlRecipe()
        If TravelerUID <> 0 Then
            btnUpdate.Text = "Update"
            'Get and Load the Shop Traveler
            GetTravelerUID()
            BuildGrid()
            txtShopTraveler.ReadOnly = True
        Else
            btnUpdate.Text = "Add"
            'Get Next Shop Traveler Number
            GetNewTravelerNum()
            txtShopTraveler.ReadOnly = True
        End If
    End Sub
    ''' <summary>
    ''' Loads the Combo Box ddlRecipe from RecipeHDR table
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Load_ddlRecipe()
        Dim bsRecipeHdr As New HT_Recipe.bsRecipeHdr
        Dim dt As New HT_Recipe.HT_Recipe.dsRecipeHdr.RecipeHdrDataTable

        dt = bsRecipeHdr.GetAllRecipeHdr
        Dim Recipe As New DataTable("Recipe")
        Dim rw As HT_Recipe.HT_Recipe.dsRecipeHdr.RecipeHdrRow
        Recipe.Columns.Add("RecipeHdrUID", System.Type.GetType("System.Int32"))
        Recipe.Columns.Add("recipeName", System.Type.GetType("System.String"))
        Recipe.Columns.Add("RecipeDesc", System.Type.GetType("System.String"))
        For Each rw In dt
            Dim dr As DataRow = Recipe.NewRow
            dr("RecipeHdrUID") = rw.RecipeHdrUID
            dr("recipeName") = rw.RecipeName
            dr("RecipeDesc") = rw.RecipeDesc
            Recipe.Rows.Add(dr)
        Next
        ddlRecipe.SelectedIndex = -1
        ddlRecipe.Items.Clear()
        ddlRecipe.SourceDataString = New String(2) {"RecipeName", "RecipeDesc", "RecipeHdrUID"}
        ddlRecipe.SourceDataTable = Recipe
    End Sub
    Private Sub GetNewTravelerNum()
        Dim bsBusiness As New HT_Business.NextOrderNo
        txtShopTraveler.Text = bsBusiness.GetNextNum("TRV")
    End Sub
    Private Sub GetTravelerUID()
        Dim bsShopTrvlr As New bsShopTravelerHdr
        Dim rw As dsShopTrvlrHdr.ShopTravelerRow
        rw = bsShopTrvlr.GetShopTrvlrHdrByTrvlrUID(TravelerUID)
        numQty.Value = rw.Qty
        dtmRunDate.Text = rw.RunDte
        txtShopTraveler.Text = rw.Travelernum
        ddlRecipe.SelectedValue = rw.RecipeHdrUID

    End Sub
    ''' <summary>
    ''' Builds the data Grid View and loads default info if it was selected
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BuildGrid()
        'Lets build the grid
        'dgvDetails.Columns.Clear()
        dgvDetails.AutoGenerateColumns = False
        ''Key field
        'Dim ShopdtlUID As New DataGridViewTextBoxColumn
        'ShopdtlUID.Visible = False
        'ShopdtlUID.Name = "ShopdtlUID"
        'ShopdtlUID.DataPropertyName = "ShopDtlUID"
        'dgvDetails.Columns.Add(ShopdtlUID)
        'dgvDetails.Columns(0).Visible = False
        'Dim ItemNo As New DataGridViewComboBoxColumn
        'ItemNo.DisplayMember = "ItemNo"
        'ItemNo.ValueMember = "ItemUID"
        'ItemNo.HeaderText = "Item #"
        'ItemNo.Name = "ItemUID"
        'ItemNo.DataPropertyName = "ItemNo"
        ''Now we got to load the Combo box
        'Dim itembs As New HT_Business.bsItemMaster
        'ItemNo.DataSource = itembs.GetAllItemMaster
        'dgvDetails.Columns.Add(ItemNo)
        ''Load the Lot
        'Dim Lotno As New DataGridViewTextBoxColumn
        'Lotno.DataPropertyName = "Lotno"
        'Lotno.Name = "Lotno"
        'Lotno.HeaderText = "Lot #"
        'dgvDetails.Columns.Add(Lotno)
        ''Load qty for Order
        'Dim Qty As New DataGridViewTextBoxColumn
        'Qty.DataPropertyName = "Qty"
        'Qty.Name = "Qty"
        'Qty.HeaderText = "Qty"
        'dgvDetails.Columns.Add(Qty)
        ''Load the actual grid
        Dim gridbs As New bsShopTravelerDtl
        'Dim dt As New DataTable
        'Dim rw As DataRow
        'rw = dt.NewRow
        RecordAdded = 0
        dgvDetails.DataSource = gridbs.GetShopDtlGrid(TravelerUID)
        'dt = gridbs.GetShopDtlGrid(TravelerUID)
        'For Each rw In dt.Rows
        '    Dim rw1 As New DataGridViewRow
        '    Dim dvcell As DataGridViewCell
        '    dvcell = New DataGridViewTextBoxCell
        '    dvcell.Value = rw(0)
        '    rw1.Cells.Add(dvcell)
        '    dvcell = New DataGridViewTextBoxCell
        '    dvcell.Value = rw(2)
        '    rw1.Cells.Add(dvcell)
        '    dvcell = New DataGridViewTextBoxCell
        '    dvcell.Value = rw(3)
        '    rw1.Cells.Add(dvcell)
        '    dvcell = New DataGridViewTextBoxCell
        '    dvcell.Value = rw(4)
        '    rw1.Cells.Add(dvcell)
        '    dgvDetails.Rows.Add(rw1)
        'Next
    End Sub
    ''' <summary>
    ''' User Click on Cancel on the screen, Button acutally closes the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' User Clicked on Close from the Menu Drop Down
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' This Builds the actual Shop Traveler details
    ''' Places into Shop Detail table then displays on screen
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BuildShopDtl()
        Dim bsRecipeDtl As New HT_Recipe.bsRecipeDtl
        Dim dtRecipeDtl As New HT_Recipe.HT_Recipe.dsRecipeDtl.RecipeDTLDataTable
        dtRecipeDtl = bsRecipeDtl.GetRecipeDtlbyHeaderUID(ddlRecipe.SelectedItem.Col3)
        Dim rw As HT_Recipe.HT_Recipe.dsRecipeDtl.RecipeDTLRow
        'Loop Through Each Recipe Detail and Get Info
        For Each rw In dtRecipeDtl
            Dim QtyNeed As Decimal = 0
            Dim bsInvent As New Ht_Inventory.bsInvent
            Dim dtInvent As New HT_Inventory.HT_Inventory.dsInventory.InventDataTable
            Dim rwInvent As HT_Inventory.HT_Inventory.dsInventory.InventRow
            dtInvent = bsInvent.GetAvailInventbyItemUID(rw.ItemUID)
            'Find Avail Inventory for Shop Traveler based on Recipe Record
            Dim FirstEv As Integer = 1
            Dim ItemUID As Integer = 0
            For Each rwInvent In dtInvent
                If Not rw.Qty = QtyNeed Then
                    'Now we must Convert the UOM for Qty Purposes
                    Dim Conversion As Decimal = 0
                    Dim bsUOMConv As New HT_Business.bsUOMConversion
                    If Not rwInvent.UOMUID = rw.UOMUID Then
                        Conversion = bsUOMConv.GetUOMConversion(rwInvent.UOMUID, rw.UOMUID)
                    Else
                        Conversion = 1
                    End If
                    'Here we have to add the Item to the ShopDetail
                    Dim dtShopDtl As New dsShopTrvlrDtl.shopTravelerDtlDataTable
                    Dim rwShopDtl As dsShopTrvlrDtl.shopTravelerDtlRow
                    rwShopDtl = dtShopDtl.NewshopTravelerDtlRow
                    rwShopDtl.TravelerUID = TravelerUID
                    If QtyNeed + (rwInvent.Qty * Conversion) > rw.Qty Then
                        rwShopDtl.Qty = rw.Qty - QtyNeed
                    Else
                        rwShopDtl.Qty = (rwInvent.Qty * Conversion)
                    End If
                    rwShopDtl.ItemUID = rw.ItemUID
                    QtyNeed += rwShopDtl.Qty
                    rwShopDtl.InventUID = rwInvent.InventUID
                    rwShopDtl.TravelerUID = TravelerUID
                    'Need to add the Shop Detail Record
                    Dim bsShopdtl As New bsShopTravelerDtl
                    bsShopdtl.InsertShoptrvlrDtl(rwShopDtl)
                Else
                    Exit For
                End If
            Next
            If QtyNeed <> rw.Qty Then
                Dim bsItemMaster As New HT_Business.bsItemMaster
                Dim rwItemMaster As HT_Business.DsItemMaster.ItemMasterRow
                rwItemMaster = bsItemMaster.GetItemMasterByItemUID(rw.ItemUID)
                Dim bsshopdtl As New bsShopTravelerDtl
                Dim dtShopDtl As New dsShopTrvlrDtl.shopTravelerDtlDataTable
                Dim rwShopDtl As dsShopTrvlrDtl.shopTravelerDtlRow
                rwShopDtl = dtShopDtl.NewshopTravelerDtlRow
                rwShopDtl.TravelerUID = TravelerUID
                If rw.ItemUID = 0 Then
                    MsgBox("TEST")
                End If
                rwShopDtl.ItemUID = rw.ItemUID
                rwShopDtl.Qty = rw.Qty - QtyNeed
                rwShopDtl.InventUID = 0
                bsshopdtl.InsertShoptrvlrDtl(rwShopDtl)
                MsgBox("Not Enough Inventory for Item : " & rwItemMaster.ItemNo & " Qty Short: " & rw.Qty - QtyNeed, MsgBoxStyle.Information, "Hot Trak")
            End If
        Next
    End Sub
    ''' <summary>
    ''' Button Update or Add was clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If TravelerUID <= 0 Then
            InsertTraveler()
            BuildShopDtl()
            BuildGrid()
            MsgBox("Shop Traveler Add")
        Else
            UpdateShopTravelerHdr()
            MsgBox("Shop Traveler Updated")
        End If

    End Sub
    ''' <summary>
    ''' Creates a Shop Traveler HDR record so user can view details 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InsertTraveler()
        Dim bsShopTraveler As New bsShopTravelerHdr
        Dim dtShopHdr As New dsShopTrvlrHdr.ShopTravelerDataTable
        Dim rwShopHdr As dsShopTrvlrHdr.ShopTravelerRow
        rwShopHdr = dtShopHdr.NewShopTravelerRow
        With rwShopHdr
            .Travelernum = txtShopTraveler.Text
            .RecipeHdrUID = ddlRecipe.SelectedItem.Col3
            .Qty = numQty.Value
            .RunDte = dtmRunDate.Text
            .CompletedQty = 0
            .CompleteDte = "01/01/1900"
            .WasteQty = 0
            .Printed = 0
            .Lotno = txtShopTraveler.Text
            .UserUID = UserUID
            .Complete = False
        End With
        TravelerUID = bsShopTraveler.InsertShopTrvlrHdr(rwShopHdr)
    End Sub
    ''' <summary>
    ''' Updates Shop Traveler HDR table based on info on Form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateShopTravelerHdr()
        Dim bsShopTraveler As New bsShopTravelerHdr
        Dim dtShopHdr As New dsShopTrvlrHdr.ShopTravelerDataTable
        Dim rwShopHdr As dsShopTrvlrHdr.ShopTravelerRow
        rwShopHdr = dtShopHdr.NewShopTravelerRow
        With rwShopHdr
            .Travelernum = txtShopTraveler.Text
            .RecipeHdrUID = ddlRecipe.SelectedItem.Col3
            .Qty = numQty.Value
            .RunDte = dtmRunDate.Text
            .CompletedQty = 0
            .CompleteDte = "01/01/1900"
            .WasteQty = 0
            .Printed = 0
            .Lotno = txtShopTraveler.Text
            .UserUID = UserUID
            .TravelerUID = TravelerUID
            .Complete = False
        End With
        bsShopTraveler.UpdateShopTrvlrHdr(rwShopHdr)
    End Sub

    Private Sub dgvDetails_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetails.CellValueChanged
        RecordAdded = 1
    End Sub

    ''' <summary>
    ''' Here we are going to add the Record into the Table and then output the ShopDetailUID to the grid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvDetails_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvDetails.RowValidating
        'Added a new Record
        If RecordAdded = 1 Then
            'First check to see if Lot # is valid and has enough qty
            Dim bsInvent As New Ht_Inventory.bsInvent
            Dim rw As HT_Inventory.HT_Inventory.dsInventory.InventRow
            rw = bsInvent.GetInventByITemUIDLotno(dgvDetails.CurrentRow.Cells(2).Value, dgvDetails.CurrentRow.Cells(3).Value)
            If rw.InventUID > 0 Then
                Dim bsshopdtl As New bsShopTravelerDtl
                Dim dtShopdtl As New dsShopTrvlrDtl.shopTravelerDtlDataTable
                Dim rwShopdtl As dsShopTrvlrDtl.shopTravelerDtlRow
                rwShopdtl = dtShopdtl.NewshopTravelerDtlRow
                With rwShopdtl
                    .Qty = dgvDetails.CurrentRow.Cells(3).Value
                    .InventUID = rw.InventUID
                    .TravelerUID = TravelerUID
                End With
                dgvDetails.CurrentRow.Cells(0).Value = bsshopdtl.InsertShoptrvlrDtl(rwShopdtl)
            Else
                MsgBox("Could Not Find Record, Please try again")
                dgvDetails.CurrentRow.Cells(1).Value = ""
                dgvDetails.CurrentRow.Cells(3).Value = 0
                dgvDetails.CurrentRow.Selected = True
            End If
            RecordAdded = 0
        End If
    End Sub

    Private Sub dgvDetails_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgvDetails.UserAddedRow
        RecordAdded = 1
    End Sub

    ''' <summary>
    ''' This deletes the record from the Shop Traveler DTL table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvDetails_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles dgvDetails.UserDeletingRow
        Dim bsShopTrvlrDtl As New bsShopTravelerDtl
        bsShopTrvlrDtl.DeleteShopTrvlrDTL(dgvDetails.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

    End Sub
End Class