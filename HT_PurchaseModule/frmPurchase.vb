Imports System.Windows.Forms
Imports HT_Business
Imports HT_PurchaseModule.HT_PurchaseModule
Public Class frmPurchase
    Public TUserName As String
    Public UserUID As Integer
    Private DetailUpdated As Integer
    Private DetailAdded As Integer
    Public POHeaderUID As Integer
    Public NewPO As Integer
    Public TransItemUID As Integer
    Private FirstTime As Integer
    Private poNoteAdded As Integer
    Private poNoteUpdated As Integer
    Public PoNotes1 As Integer
    Private Sub frmPurchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FirstTime = 1
        LoadDropDowns()
        ResetLabels()
        If TransItemUID > 0 Then
            ddlPurchaseOrder.Text = 0
        End If
        PoNotes1 = 0
    End Sub
    Private Sub ResetLabels()
        lblVendorName.Text = ""
        lblAddr1.Text = ""
        lblCity.Text = ""
        lblState.Text = ""
        lblZip.Text = ""
        dtmBornOn.Text = ""
        lblPOStatus.Text = ""
    End Sub
    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        CloseFormNoSave()
    End Sub
    Private Sub LoadDropDowns()
        'Load The Purchase Order Drop Downs
        LoadPODrop()
        LoadVendors()
        LoadShipTerms()
        LoadNetTerms()
        LoadDeliveryMethods()
        LoadDeliveryTerms()
    End Sub
    Private Sub LoadShipTerms()
        Dim bs As New bsTerms
        ddlFreightTerms.DataSource = bs.GetAllShipTerms
    End Sub
    Private Sub LoadNetTerms()
        Dim bs As New bsTerms
        ddlPaymentTerms.DataSource = bs.GetAllNetTerms
    End Sub
    Private Sub LoadDeliveryTerms()
        Dim bs As New bsDelivery
        ddlDeliveryTerms.DataSource = bs.GetAllDeliveryTerms
    End Sub
    Private Sub LoadDeliveryMethods()
        Dim bs As New bsDelivery
        ddlDeliveryMethod.DataSource = bs.GetAllDeliveryMethods
    End Sub
    Private Sub LoadPODrop()
        Dim bs As New bsPOHeader
        ddlPurchaseOrder.DataSource = bs.GetAllPOHeader
        ddlPurchaseOrder.SelectedIndex = -1
        FirstTime = 0
    End Sub
    Private Sub LoadVendors()
        Dim bs As New bsVendors
        Dim dt As New dsVendor.VendorDataTable
        dt = bs.GetAllVendors
        Dim Vend As New DataTable("Vendor")
        Vend.Columns.Add("VendorUID", System.Type.GetType("System.Int32"))
        Vend.Columns.Add("VendorCode", System.Type.GetType("System.String"))
        Vend.Columns.Add("VendorName", System.Type.GetType("System.String"))
        Dim rw As dsVendor.VendorRow
        For Each rw In dt
            Dim dr As DataRow = Vend.NewRow
            dr("VendorUID") = rw.VendorUID
            dr("VendorCode") = rw.VendorCode
            dr("VendorName") = rw.VendorName
            Vend.Rows.Add(dr)
        Next
        ddlVendor.SelectedIndex = -1
        ddlVendor.Items.Clear()
        ddlVendor.SourceDataString = New String(2) {"VendorCode", "VendorName", "VendorUID"}
        ddlVendor.SourceDataTable = Vend
    End Sub

    Private Sub ddlPurchaseOrder_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlPurchaseOrder.Leave
        'FindPO()
    End Sub
    Private Sub FindPO()
        txtFreightAmt.Text = 0
        If Not FirstTime = 1 Then
            Dim Found As Integer = ddlPurchaseOrder.FindString(ddlPurchaseOrder.Text)
            If Found > -1 Then
                Text = "Updating Purchase Order " & ddlPurchaseOrder.Text
                btnupdate.Text = "Update"
                POHeaderUID = Me.ddlPurchaseOrder.SelectedValue
                NewPO = 0
                LoadPoHeaderInfo()
            Else
                'Here we have to get the next Purchase Order #
                Dim bs As New NextOrderNo
                Dim po As Integer = bs.GetNextNum("PO")
                FirstTime = 1
                ddlPurchaseOrder.Text = po
                FirstTime = 0
                Text = "Adding Purchase Order " & ddlPurchaseOrder.Text
                btnupdate.Text = "Add"
                dtmActDelvDate.Text = "01/01/1900"
                POHeaderUID = 0
                NewPO = 1
                dtmBornOn.Text = Today.Date
                ddlVendor.Enabled = True
                ddlVendor.SelectedIndex = -1
            End If
            LoadPodetailInfo()
            LoadPONotes()
            If TransItemUID > 0 Then
                'If TransItemUID is greater than 0, this means that we have an ItemUID to add to a new Purchase Order
                'First we have to load the Vendor so we can capture the address and etc...
                Dim bs As New bsItemMaster
                Dim dt As New DsItemMaster.ItemMasterDataTable
                Dim rw As DsItemMaster.ItemMasterRow
                rw = dt.NewItemMasterRow
                rw = bs.GetItemMasterByItemUID(TransItemUID)
                ddlVendor.SelectedValue = rw.DefaultVendorUID
                dgvPurchase.Focus()
                dgvPurchase.Rows.Add()
                DetailAdded = 1
                dgvPurchase.Rows(0).Cells(1).Value = TransItemUID
                'dgvPurchase.Rows(0).Cells(1).Value = rw.ItemNo

            End If
        End If
    End Sub
    Private Sub LoadPoHeaderInfo()
        Dim bs As New bsPOHeader
        Dim rw As dsPOHeader.POheaderRow

        rw = bs.GetpoheaderbyUID(CInt(ddlPurchaseOrder.SelectedValue))
        With rw
            ddlVendor.SelectedValue = .VendorUID
            ddlVendor.Enabled = False
            dtmActDelvDate.Text = .ActDeliveryDte
            dtmEstDelvDate.Text = .EstDeliveryDate
            dtmBornOn.Text = .BornOn
            lblPOStatus.Text = .POStatus
            ddlDeliveryMethod.SelectedValue = .DeliveryUID
            ddlDeliveryTerms.SelectedValue = .DeliveryTUID
            ddlFreightTerms.SelectedValue = .ShipTermsUID
            ddlPaymentTerms.SelectedValue = .NetTermsUID
            txtFreightAmt.Text = .FreightAmt
        End With
    End Sub
    Private Sub LoadPodetailInfo()
        dgvPurchase.Columns.Clear()
        dgvPurchase.AutoGenerateColumns = False
        'Here we are going to Create the info in the detail grid
        'Creating the PODetailUID
        Dim POdetailUID As New DataGridViewTextBoxColumn
        POdetailUID.Visible = False
        POdetailUID.DataPropertyName = "PODetailUID"
        POdetailUID.Name = "PODetailUID"
        dgvPurchase.Columns.Add(POdetailUID)
        dgvPurchase.Columns(0).Visible = False
        'Creates Item Drop Down list
        Dim ItemNo As New DataGridViewComboBoxColumn
        ItemNo.HeaderText = "Item #"
        ItemNo.DisplayMember = "ItemNo"
        ItemNo.ValueMember = "ItemUID"
        ItemNo.DataPropertyName = "ItemNo"
        ItemNo.Name = "ItemUID"
        ItemNo.Width = 100
        Dim bsItem As New bsItemMaster
        ItemNo.DataSource = bsItem.GetAllItemMaster
        dgvPurchase.Columns.Add(ItemNo)
        'This Loads the description of the Item #
        Dim ItemDesc As New DataGridViewTextBoxColumn
        ItemDesc.HeaderText = "Item Description"
        ItemDesc.ReadOnly = True
        ItemDesc.DataPropertyName = "ItemDesc"
        ItemDesc.Name = "ItemDesc"
        ItemDesc.Width = 200
        dgvPurchase.Columns.Add(ItemDesc)
        'This Loads the Qty Field
        Dim Qty As New DataGridViewTextBoxColumn
        Qty.HeaderText = "Qty Ordered"
        Qty.Width = 75
        Qty.DataPropertyName = "Qty"
        Qty.Name = "Qty"
        dgvPurchase.Columns.Add(Qty)
        'This Loads the lstReceivedDate
        Dim RecevDte As New DataGridViewTextBoxColumn
        RecevDte.HeaderText = "Last Recv Date"
        RecevDte.Name = "lstReceiveDte"
        RecevDte.DataPropertyName = "lstReceiveDte"
        RecevDte.ReadOnly = True
        dgvPurchase.Columns.Add(RecevDte)
        'This Loads the Received Qty
        Dim RecvQty As New DataGridViewTextBoxColumn
        RecvQty.HeaderText = "Received Qty"
        RecvQty.Name = "ReceivedQty"
        RecvQty.DataPropertyName = "ReceivedQty"
        RecvQty.Width = 75
        RecvQty.ReadOnly = True
        dgvPurchase.Columns.Add(RecvQty)
        'This Loads the Lotno that it was received On
        Dim Lotno As New DataGridViewTextBoxColumn
        Lotno.ReadOnly = True
        Lotno.HeaderText = "Received Lot #"
        Lotno.DataPropertyName = "Lotno"
        Lotno.Name = "Lotno"
        dgvPurchase.Columns.Add(Lotno)
        Dim Price As New DataGridViewTextBoxColumn
        Price.HeaderText = "Price"
        Price.DataPropertyName = "Price"
        Price.Name = "Price"
        dgvPurchase.Columns.Add(Price)
        'Now We are going to Load the Grid with Data linking from the POHeader if there is any
        If Not ddlPurchaseOrder.SelectedValue Is Nothing Then
            Dim bsPodetail As New bsPODetail
            Dim podetaildt As New dsPODetail.POdetailDataTable
            podetaildt = bsPodetail.GetPodetailGrid(ddlPurchaseOrder.SelectedValue)
            Dim rw As dsPODetail.POdetailRow
            For Each rw In podetaildt
                Dim rw1 As New DataGridViewRow
                Dim dvcell As DataGridViewCell
                dvcell = New DataGridViewTextBoxCell
                dvcell.Value = rw.POdetailUID
                rw1.Cells.Add(dvcell)
                dvcell = New DataGridViewTextBoxCell
                dvcell.Value = rw.ItemNo
                rw1.Cells.Add(dvcell)
                dvcell = New DataGridViewTextBoxCell
                dvcell.Value = rw.ItemDesc
                rw1.Cells.Add(dvcell)
                dvcell = New DataGridViewTextBoxCell
                dvcell.Value = rw.Qty
                rw1.Cells.Add(dvcell)
                dvcell = New DataGridViewTextBoxCell
                dvcell.Value = rw.lstReceiveDte
                rw1.Cells.Add(dvcell)
                dvcell = New DataGridViewTextBoxCell
                dvcell.Value = rw.ReceivedQty
                rw1.Cells.Add(dvcell)
                dvcell = New DataGridViewTextBoxCell
                dvcell.Value = rw.Lotno
                rw1.Cells.Add(dvcell)
                dvcell = New DataGridViewTextBoxCell
                dvcell.Value = rw.Price
                rw1.Cells.Add(dvcell)
                dgvPurchase.Rows.Add(rw1)
            Next
        End If
    End Sub
    Private Sub LoadPONotes()
        dgvPONotes.AutoGenerateColumns = False
        Dim bs As New bsPONotes
        dgvPONotes.DataSource = bs.GetPONotesbyHeader(ddlPurchaseOrder.SelectedValue)

    End Sub
    Private Sub ddlVendor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlVendor.SelectedIndexChanged
        Dim bs As New bsVendors
        Dim rw As dsVendor.VendorRow
        If Not ddlVendor.SelectedIndex = -1 Then
            rw = bs.GetVendorbyUID(ddlVendor.SelectedItem.Col3)
            With rw
                lblVendorName.Text = .VendorName
                lblAddr1.Text = .Addr1
                lblCity.Text = .City
                lblState.Text = .State
                lblZip.Text = .Zip
            End With
        Else
            ResetLabels()
        End If
    End Sub
    Private Sub dgvPurchase_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPurchase.CellValueChanged
        If dgvPurchase.CurrentCell.ColumnIndex = 1 Then
            Dim bs As New bsItemMaster
            If Not dgvPurchase.CurrentRow.Cells(1).Value Is Nothing Then
                '  dgvPurchase.CurrentRow.Cells(2).Value = bs.GetItemDescription(dgvPurchase.CurrentRow.Cells(1).Value)
                Dim dt As New DsItemMaster.ItemMasterDataTable
                Dim rw As DsItemMaster.ItemMasterRow
                rw = dt.NewItemMasterRow
                rw = bs.GetItemMasterByItemUID(dgvPurchase.CurrentRow.Cells(1).Value)
                dgvPurchase.CurrentRow.Cells(2).Value = rw.ItemDesc
                dgvPurchase.CurrentRow.Cells(7).Value = rw.Price
            End If
        End If
        If DetailAdded = 0 Then
            DetailUpdated = 1
        End If
    End Sub

    Private Sub dgvPurchase_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvPurchase.GotFocus
        If POHeaderUID = 0 Then
            'if PO header is zero, then we need to add the PO
            Dim bs As New bsPOHeader
            Dim dt As New dsPOHeader.POheaderDataTable
            Dim rw As dsPOHeader.POheaderRow
            rw = dt.NewPOheaderRow
            With rw
                .PONO = ddlPurchaseOrder.Text
                .VendorUID = Me.ddlVendor.SelectedItem.Col3
                .PODate = dtmBornOn.Text
                .UserUID = UserUID
                .POStatus = "O"
                .EstDeliveryDate = dtmEstDelvDate.Text
                .ActDeliveryDte = "01/01/1900"
                .CurrencyUID = 1
                .NetTermsUID = ddlPaymentTerms.SelectedValue
                .DeliveryTUID = ddlDeliveryTerms.SelectedValue
                .DeliveryUID = ddlDeliveryMethod.SelectedValue
                .ShipTermsUID = ddlFreightTerms.SelectedValue
                If txtFreightAmt.Text = 0 Or txtFreightAmt.Text = "" Then
                    .FreightAmt = 0
                Else
                    .FreightAmt = txtFreightAmt.Text
                End If
            End With
            POHeaderUID = bs.InsertPoHeader(rw)
        End If
    End Sub

    Private Sub dgvPurchase_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvPurchase.RowValidating
        If DetailAdded = 1 Or DetailUpdated = 1 Then
            Dim bs As New bsPODetail
            Dim dt As New dsPODetail.POdetailDataTable
            Dim rw As dsPODetail.POdetailRow
            rw = dt.NewPOdetailRow
            With rw
                .BornOn = Now
                .ItemUID = dgvPurchase.CurrentRow.Cells(1).Value
                .Qty = dgvPurchase.CurrentRow.Cells(3).Value
                .UserUID = UserUID
                .POHeaderUID = POHeaderUID
                .Price = dgvPurchase.CurrentRow.Cells(7).Value
            End With
            If DetailAdded = 1 Then
                rw.Lotno = ""
                rw.lstReceiveDte = "01/01/1900"
                rw.ReceivedQty = 0
                dgvPurchase.CurrentRow.Cells(0).Value = bs.InsertPoDetail(rw)
                DetailAdded = 0
            End If
            If DetailUpdated = 1 Then
                rw.Lotno = dgvPurchase.CurrentRow.Cells(6).Value
                rw.lstReceiveDte = dgvPurchase.CurrentRow.Cells(4).Value
                rw.POdetailUID = dgvPurchase.CurrentRow.Cells(0).Value
                rw.ReceivedQty = dgvPurchase.CurrentRow.Cells(5).Value
                bs.UpdatePodetail(rw)
                DetailUpdated = 0
            End If
        End If
    End Sub

    Private Sub dgvPurchase_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgvPurchase.UserAddedRow
        DetailAdded = 1
    End Sub

    Private Sub dgvPurchase_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles dgvPurchase.UserDeletingRow
        Dim bs As New bsPODetail
        bs.DeletePOdetail(dgvPurchase.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        CloseFormNoSave()
    End Sub
    Private Sub CloseFormNoSave()
        If NewPO = 1 Then
            Dim bs As New bsPOHeader
            bs.DeletePoHeader(POHeaderUID)
        End If
        Me.Close()
    End Sub

    Private Sub btnPrintPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPO.Click
        Dim rptwriter As New Ht_rptWriter.rptWriter
        rptwriter.rptdoc = "rptPurchaseOrder.rdlc"
        Dim bsPOheader As New bsPOHeader
        Dim bsPoDetail As New bsPODetail
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        dt = bsPOheader.GetPurchaseOrderReport(POHeaderUID)
        dt2 = bsPoDetail.GetrptPODetail(POHeaderUID)
        If dt.Rows.Count > 0 Then
            rptwriter.Datatable1 = dt
            rptwriter.datasetName1 = "HotTrakDataSet_stp_PurchaseOrderHDRrpt"
            rptwriter.DatasetName2 = "HotTrakDataSet1_stp_rptPODetail"
            rptwriter.Datatable2 = dt2
            rptwriter.ShowDialog()
        Else
            MsgBox("There was an issue retrieving the data for this PO, Please contact Support")
        End If

    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Dim dt As New dsPOHeader.POheaderDataTable
        Dim rw As dsPOHeader.POheaderRow
        Dim bs As New bsPOHeader
        rw = bs.GetpoheaderbyUID(POHeaderUID)
        With rw
            .CurrencyUID = 1
            .POheaderUID = ddlPurchaseOrder.SelectedValue
            .DeliveryTUID = ddlDeliveryTerms.SelectedValue
            .DeliveryUID = ddlDeliveryMethod.SelectedValue
            .ShipTermsUID = ddlFreightTerms.SelectedValue
            .PODate = dtmBornOn.Text
            .EstDeliveryDate = dtmEstDelvDate.Text
            .ActDeliveryDte = dtmActDelvDate.Text
            .VendorUID = ddlVendor.SelectedItem.Col3
            .FreightAmt = txtFreightAmt.Text
        End With
        bs.UpdatePoHeader(rw)
    End Sub

    Private Sub txtFreightAmt_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFreightAmt.Validated
        'Display the value as local currency.
        Me.txtFreightAmt.Text = Decimal.Parse(Me.txtFreightAmt.Text).ToString("c")

    End Sub

    Private Sub txtFreightAmt_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFreightAmt.Validating
        Dim currency As Decimal

        'Convert the current value to currency, with or without a currency symbol.
        If Not Decimal.TryParse(Me.txtFreightAmt.Text, _
                                Globalization.NumberStyles.Currency, _
                                Nothing, _
                                currency) Then
            'Don't let the user leave the field if the value is invalid.
            With Me.txtFreightAmt
                .HideSelection = False
                .SelectAll()

                MessageBox.Show("Please enter a valid currency amount.", _
                                "Invalid Value", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Error)

                .HideSelection = True
            End With

            e.Cancel = True
        End If
    End Sub

    Private Sub ddlPurchaseOrder_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlPurchaseOrder.SelectedIndexChanged
        ' FindPO()
    End Sub
    Private Sub ddlPurchaseOrder_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlPurchaseOrder.TextChanged
        FindPO()
    End Sub

    Private Sub dgvPONotes_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPONotes.CellValueChanged
        If PoNotes1 = 0 Then
            If Not poNoteAdded = 1 Then
                poNoteUpdated = 1
            End If
        End If
    End Sub

    Private Sub dgvPONotes_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvPONotes.RowValidating
        If poNoteAdded = 1 Then
            'Here we are going to add the Notes to the Purchase Order
            Dim bs As New bsPONotes
            Dim dt As New dsPoNotes.PONotesDataTable
            Dim rw As dsPoNotes.PONotesRow
            rw = dt.NewPONotesRow
            With rw
                .BornOn = Now.Date
                .POheaderUID = POHeaderUID
                .PONotes = dgvPONotes.CurrentRow.Cells(3).Value
                .UserUID = UserUID
            End With

            dgvPONotes.CurrentRow.Cells(0).Value = bs.InsertPoNotes(rw)
            dgvPONotes.CurrentRow.Cells(1).Value = TUserName
            dgvPONotes.CurrentRow.Cells(2).Value = Now.Date
        ElseIf poNoteUpdated = 1 Then
            'Here we are going to update the notes added to the purchase Order
            Dim bs As New bsPONotes
            Dim dt As New dsPoNotes.PONotesDataTable
            Dim rw As dsPoNotes.PONotesRow
            rw = dt.NewPONotesRow
            With rw
                .POMessageUID = dgvPONotes.CurrentRow.Cells(0).Value
                .POheaderUID = POHeaderUID
                .UserUID = UserUID
                .BornOn = Now.Date
                .PONotes = dgvPONotes.CurrentRow.Cells(3).Value
            End With
            bs.updatePONote(rw)
        End If
        poNoteAdded = 0
        poNoteUpdated = 0
        'LoadPONotes()
    End Sub

    Private Sub dgvPONotes_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgvPONotes.UserAddedRow
        poNoteAdded = 1
    End Sub

    Private Sub dgvPONotes_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles dgvPONotes.UserDeletingRow
        Dim bs As New bsPONotes
        bs.DeletePoNote(dgvPONotes.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub btnPOReceived_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPOReceived.Click

    End Sub
End Class