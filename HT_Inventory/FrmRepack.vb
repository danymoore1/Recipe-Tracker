Public Class FrmRepack
    Public userUID As Integer
    Public Runno As Integer
    Private Sub FrmRepack_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadRecipeDrop()
        LoadRunDrop()
        LoadCustomerITemDrop()
        LoadUnPackGrid()
        lblRecipeDesc.Text = ""
        ddlRecipeLotno.SelectedIndex = -1
        numRecipeQty.Value = 0
    End Sub

#Region "Run Header Tab"
    Private Sub LoadRunDrop()
        Dim bsRun As New HT_Business.bsRun
        ddlRunno.DataSource = bsRun.GetRunbyDate(dtmRunDate.Text)
        Me.ddlRunno.SelectedIndex = -1
    End Sub
    Private Sub LoadRecipeDrop()
        'Here is where we get inventory trays.
        Dim bsItemMaster As New HT_Business.bsItemMaster
        ddlRecipe.DataSource = bsItemMaster.GetInventoryTrays
        ddlRecipe.SelectedIndex = -1
    End Sub
    Private Sub ddlRecipe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlRecipe.SelectedIndexChanged
        'Load the available lots onto the screen for the selected Item Recipe
        If Not ddlRecipe.SelectedIndex = -1 Then
            Dim bsInvent As New bsInvent
            ddlRecipeLotno.DataSource = bsInvent.GetAvailInventbyItemUID(ddlRecipe.SelectedValue)
            Dim bsItemMaster As New HT_Business.bsItemMaster
            Dim rwItemMaster As HT_Business.DsItemMaster.ItemMasterRow
            rwItemMaster = bsItemMaster.GetItemMasterByItemUID(ddlRecipe.SelectedValue)
            lblRecipeDesc.Text = rwItemMaster.ItemDesc
        End If
    End Sub
    Private Sub ddlRecipeLotno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlRecipeLotno.SelectedIndexChanged
        'When we have the Lot selected, Enter in Max amount that we can pull
        If Not ddlRecipe.SelectedIndex = -1 Then
            Dim bsInvent As New bsInvent
            Dim rwInvent As Ht_Inventory.dsInventory.InventRow
            rwInvent = bsInvent.GetInventByInventUID(ddlRecipeLotno.SelectedValue)
            numRecipeQty.Value = rwInvent.Qty - rwInvent.Unpackqty - rwInvent.UsedQty
        End If
    End Sub
    Private Sub lnkAdd_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAdd.LinkClicked
        'Check to see if we are using a saved Run or a New Run
        If Runno = 0 Then
            'New Run - ---- Add Run
            Dim bsRun As New HT_Business.bsRun
            Dim DtRun As New HT_Business.dsRun.RunDataTable
            Dim rwRun As HT_Business.dsRun.RunRow
            rwRun = DtRun.NewRunRow
            With rwRun
                .Runno = ddlRunno.Text
                .RunDate = dtmRunDate.Text
                .Lotno = CStr(Today.Year) & CStr(Today.Month) & CStr(Today.Day) & ddlRunno.Text
                .Qty = numRecipeQty.Value
                .RecipeHdrUID = ddlRecipe.SelectedValue
            End With
            Runno = bsRun.InsertRun(rwRun)
        Else

        End If
        Dim bsUnpack As New HT_Business.bsUnPack
        Dim dtUnPack As New HT_Business.dsUnPack.UnpackDataTable
        Dim RwUnPack As HT_Business.dsUnPack.UnpackRow
        RwUnPack = dtUnPack.NewUnpackRow
        With RwUnPack
            .InventUID = ddlRecipeLotno.SelectedValue
            .Qty = numRecipeQty.Value
            .RunUID = Runno
            .UserUID = userUID
        End With
        'Add to the UnPack Table
        bsUnpack.InsertUnPack(RwUnPack)
        'Reload the grid
        LoadRunGrid()
    End Sub
    Private Sub LoadRunGrid()
        Dim bsUnPack As New HT_Business.bsUnPack
        dgvRecipeInvent.AutoGenerateColumns = False
        dgvRecipeInvent.DataSource = bsUnPack.GetUnPackLotGrid(Runno)
    End Sub
    Private Sub ddlRunno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlRunno.Leave
        'If it is a zero then we create a Run else get the run
        If Not ddlRunno.Text = "" Then
            Dim Found As Integer = ddlRunno.FindString(ddlRunno.Text)

            If ddlRunno.Text = 0 Or Found = -1 Then
                Dim bsNextNum As New HT_Business.NextOrderNo
                ddlRunno.Text = bsNextNum.GetNextNum("Run")
                Runno = 0
            Else
                'Do not allow the Recipe to be changed
                Runno = ddlRunno.SelectedValue
                Dim bsUnpack As New HT_Business.bsRun
                Dim rwRun As HT_Business.dsRun.RunRow
                rwRun = bsUnpack.GetRunbyRunUID(Runno)
                ddlRecipe.SelectedValue = rwRun.RecipeHdrUID
                LoadRunGrid()
                ddlRecipe.Enabled = False
                Dim bsItemMaster As New HT_Business.bsItemMaster
                Dim rwItemMaster As HT_Business.DsItemMaster.ItemMasterRow
                rwItemMaster = bsItemMaster.GetItemMasterByItemUID(ddlRecipe.SelectedValue)
                lblRecipeDesc.Text = rwItemMaster.ItemDesc
            End If
        End If
    End Sub
    Private Sub dtmRunDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtmRunDate.ValueChanged
        LoadRunDrop()
    End Sub
#End Region
#Region "Placed onto Run"
    Private Sub LoadCustomerITemDrop()
        Dim bsCusPackHDr As New HT_Business.bsCustomerPackHdr
        ddlCustomerItem.DataSource = bsCusPackHDr.GetCustomerPackHDRItems
    End Sub

    Private Sub btnUnPackAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnPackAdd.Click
        'Here we are going to get the Items associated with the Customer Item and drop them into unpack
        Dim dtCustDtl As New HT_Business.dsCustomerPackDTL.CustomerPackDTLDataTable
        Dim rwCustDTL As HT_Business.dsCustomerPackDTL.CustomerPackDTLRow
        Dim bsCustDTL As New HT_Business.bsCustomerPackDTL
        dtCustDtl = bsCustDTL.GetCustomerDTL(ddlCustomerItem.SelectedValue)
        Dim QtyNeeded As Decimal = 0
        For Each rwCustDTL In dtCustDtl
            'Loop through each record and get ITems to look for Inventory
            QtyNeeded = rwCustDTL.Qty * numQty.Value
            'Now we must retrieve inventory to build Unpack
            Dim Bsinvent As New bsInvent
            Dim dtInvent As New Ht_Inventory.dsInventory.InventDataTable
            Dim rwInvent As Ht_Inventory.dsInventory.InventRow
            dtInvent = Bsinvent.GetAvailInventbyItemUID(rwCustDTL.ItemNoUID)
            For Each rwInvent In dtInvent
                Dim qty As Decimal = rwInvent.Qty - rwInvent.Unpackqty - rwInvent.UsedQty
                If QtyNeeded <> 0 Then
                    If qty >= QtyNeeded Then
                        'If it is equal or greater than qty that is needed add the invent and end for the next loop
                        Dim BsUnpack As New HT_Business.bsUnPack
                        Dim dtUnpack As New HT_Business.dsUnPack.UnpackDataTable
                        Dim rwUnpack As HT_Business.dsUnPack.UnpackRow
                        rwUnpack = dtUnpack.NewUnpackRow
                        With rwUnpack
                            .RunUID = Runno
                            .InventUID = rwInvent.InventUID
                            .Qty = QtyNeeded
                            .UserUID = userUID
                        End With
                        BsUnpack.InsertUnPack(rwUnpack)
                        QtyNeeded = 0
                        Exit For
                    ElseIf qty > QtyNeeded Then
                        Dim BsUnpack As New HT_Business.bsUnPack
                        Dim dtUnpack As New HT_Business.dsUnPack.UnpackDataTable
                        Dim rwUnpack As HT_Business.dsUnPack.UnpackRow
                        rwUnpack = dtUnpack.NewUnpackRow
                        With rwUnpack
                            .RunUID = Runno
                            .InventUID = rwInvent.InventUID
                            .Qty = rwInvent.Qty
                            .UserUID = userUID
                        End With
                        BsUnpack.InsertUnPack(rwUnpack)
                        QtyNeeded = QtyNeeded - qty
                    End If
                Else
                    Exit For
                End If
            Next
            If QtyNeeded > 0 Then
                MsgBox("There was not enough Inventory to create this Repack, Inventory not deductible")
            End If
            'Build the Inventory for the Pallets Auto and populate the grid on form on Tab 3
            rwInvent = dtInvent.NewInventRow
            Dim bsItemMaster As New HT_Business.bsItemMaster
            Dim RwItemMaster As HT_Business.DsItemMaster.ItemMasterRow
            RwItemMaster = bsItemMaster.GetItemMasterByItemUID(rwCustDTL.ItemNoUID)
            With rwInvent
                .Qty = numQty.Value
                .ItemUID = RwItemMaster.ItemUID
                .UOMUID = 132 'UomUID of a Tray
                .Lotno = CStr(Today.Year) & CStr(Today.Month) & CStr(Today.Date) & CStr(ddlRunno.Text)
                .POdetailUID = 0
                .PackDate = Now.Date
                .TravelerUID = 0
                .PalletTagno = ""
                .UserUID = userUID
                .RunUID = Runno
            End With
            Bsinvent.InsertInvent(rwInvent)
            GetRepackedInventory()
        Next

        LoadUnPackGrid()
    End Sub
    Private Sub LoadUnPackGrid()
        Dim bsUnpack As New HT_Business.bsUnPack
        dgvDumped.AutoGenerateColumns = False
        dgvDumped.DataSource = bsUnpack.GetUnpackLots(Runno)
    End Sub

    Private Sub GetRepackedInventory()
        Dim bsInvent As New bsInvent
        dgvCreated.AutoGenerateColumns = False
        dgvCreated.DataSource = bsInvent.GetRepackedInventory(Runno)
    End Sub
#End Region


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class