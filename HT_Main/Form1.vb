Public Class Form1

    Private Sub btnPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPO.Click
        Dim frmPO As New ht_PurchaseModule.frmPurchase
        frmPO.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frmRecipe As New HT_Recipe.frmRecipe
        frmRecipe.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim frmItemMaster As New HT_Business.frmItemMaster
        frmItemMaster.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim FrmItemtype As New HT_Business.frmItemDefin
        FrmItemtype.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim frmItemMaster As New HT_Business.frmItemMaster
        frmItemMaster.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim frmNetTerms As New HT_Business.frmTerms
        frmNetTerms.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim frmVendor As New HT_Business.frmVendors
        frmVendor.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim frmOrderEntry As New HT_OrderEntry.frmOrderEntry
        frmOrderEntry.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim frmshipping As New HT_OrderEntry.frmShip
        frmshipping.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim frmShopView As New HT_ShopTravler.frmShopTrvlrView
        'Dim frmShopView As New HT_ShopTraveler.frmShopTrvlrView
        frmShopView.UserUID = 1
        frmShopView.Show()

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim frmReceive As New ht_PurchaseModule.frmReceivePO
        frmReceive.UserUID = 1
        frmReceive.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim frmRepack As New Ht_Inventory.FrmRepack
        frmRepack.userUID = 1
        frmRepack.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim frmInvoicing As New HT_OrderEntry.frmInvoicing
        frmInvoicing.Show()
    End Sub


End Class
