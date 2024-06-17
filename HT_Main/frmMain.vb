Imports HT_Business
Imports Ht_Inventory
Imports HT_OrderEntry
Imports ht_PurchaseModule
Imports HT_Recipe
Imports Ht_rptWriter
Imports HT_ShopTraveler

Public Class frmMain

    Private MainMenuStrip As New MenuStrip
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = False
        Dim frmLogin As New Login
        Login.ShowDialog()

        If HT_Main.My.Settings.UserID = 0 Then
            Me.Close()
            Exit Sub
        Else
            Me.Visible = True
        End If
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Left = 1
        Me.Top = 1
        GetConfigSettings()

        Dim ObjMenu As New DynamicMenu()
        'ObjMenu.XMLMenuFile = "C:\Program Files\Hot Cuisine\menu.xml"
        ObjMenu.XMLMenuFile = "C:\Users\DannyMoore\source\repos\HT_Main\Menu.xml"
        'ObjMenu.XMLMenuFile = "F:\HotTrak\Project\Hot Trak\Hot Trak\menu.xml"
        ObjMenu.objForm = Me
        MainMenuStrip = ObjMenu.LoadDynamicMenu()
        'Me.Menu = ObjMenu.LoadDynamicMenu()
    End Sub
#Region "Config Settings"
    ''' <summary>
    ''' This sets the default Inventory Type UID for sales
    ''' This sets the default Materials Item Type UID
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetConfigSettings()
        'Dim bs As New HotTrak_bs.ConfigInfo
        'My.Settings.MaterialsItemUID = bs.GetConfigMaterial
        'My.Settings.InventoryItemTypeUID = bs.GetConfigInventoryUID
        'My.Settings.IngredientsUID = bs.GetRawMaterialsUID
    End Sub
#End Region
#Region "Menu Options"
    Private Sub MenuItemOnClick_CustomerPack(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim frmlstCustomerITems As New HT_Business.frmlstCustomerItems
        frmlstCustomerITems.UserUID = HT_Main.My.Settings.UserID
        frmlstCustomerITems.Show()
    End Sub
    Private Sub MenuItemOnClick_ItemMaster(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim frmItemMaster As New HT_Business.frmItemMaster
        frmItemMaster.Show()
    End Sub
    Private Sub MenuItemOnClick_TermsMaintenance(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim FrmTerms As New HT_Business.frmTerms
        FrmTerms.Show()
    End Sub
    Private Sub MenuItemOnClick_VendorMaster(ByVal sender As Object, ByVal e As EventArgs)
        Dim frmVendor As New HT_Business.frmVendors
        frmVendor.Show()
    End Sub
    Private Sub MenuItemOnClick_CustomerPricing(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim frmCustPricing As New HT_Business.frmCustomerPricing
        frmCustPricing.UserUID = HT_Main.My.Settings.UserID
        frmCustPricing.Show()
    End Sub
    Private Sub MenuItemOnClick_RecipeMaster(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim frmRecipeMaster As New HT_Recipe.frmRecipe
        frmRecipeMaster.Show()
    End Sub
    Private Sub MenuItemOnClick_CustomerMaster(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim frmCustomerMaster As New HT_Business.frmCustomer
        frmCustomerMaster.Show()
    End Sub
    Private Sub MenuItemOnClick_ItemType(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim frmItemDefin As New HT_Business.frmItemDefin
        frmItemDefin.Show()
    End Sub
    Private Sub MenuItemOnClick_OrderEntry(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim frmOrderEntry As New HT_OrderEntry.frmOrderEntry
        frmOrderEntry.tUserName = HT_Main.My.Settings.UserName
        frmOrderEntry.UserUID = HT_Main.My.Settings.UserID
        frmOrderEntry.Show()
    End Sub
    Private Sub MenuItemOnClick_AutoShipping(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim frmAutoShip As New HT_OrderEntry.frmAutoShipping
        frmAutoShip.Show()
    End Sub
    Private Sub MenuItemOnClick_ShippingSales(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim FrmShipping As New HT_OrderEntry.frmShip
        FrmShipping.Show()
    End Sub
    Private Sub MenuItemOnClick_ViewShopTravelers(ByVal sender As Object, ByVal e As System.EventArgs)
        'Dim frmVShopTraveler As New HT_ShopTraveler.frmShopTrvlrView
        Dim frmVShopTraveler As New HT_ShopTravler.frmShopTrvlrView
        frmVShopTraveler.UserUID = HT_Main.My.Settings.UserID

        frmVShopTraveler.Show()
    End Sub
    Private Sub MenuItemOnClick_Invoice(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim FrmInv As New HT_OrderEntry.frmInvoicing
        FrmInv.Show()
    End Sub
    Private Sub MenuItemOnClick_PurchaseOrder(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim frmPurchaseOrder As New ht_PurchaseModule.frmPurchase
        frmPurchaseOrder.UserUID = HT_Main.My.Settings.UserID

        frmPurchaseOrder.TUserName = HT_Main.My.Settings.UserName
        frmPurchaseOrder.Show()
    End Sub
    Private Sub MenuItemOnClick_ReceivePo(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim FrmRecivePO As New ht_PurchaseModule.frmReceivePO
        FrmRecivePO.UserUID = HT_Main.My.Settings.UserID

        FrmRecivePO.Show()
    End Sub
    Private Sub MenuItemOnClick_LowStockInventory(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim frmLowInvent As New Ht_Inventory.frmLowInventory
        frmLowInvent.UserUID = HT_Main.My.Settings.UserID
        frmLowInvent.Show()
    End Sub
    Private Sub MenuItemOnClick_CreateCustomerPack(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim FrmRepack As New Ht_Inventory.FrmRepack
        FrmRepack.userUID = HT_Main.My.Settings.UserID
        FrmRepack.Show()
    End Sub
    Private Sub MenuItemOnClick_OnClose(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub MenuItemOnClick_ItemMasterInventory(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim frmInventory As New Ht_Inventory.frmInventory
        frmInventory.UserUID = HT_Main.My.Settings.UserID
        frmInventory.Show()
    End Sub
#End Region
End Class