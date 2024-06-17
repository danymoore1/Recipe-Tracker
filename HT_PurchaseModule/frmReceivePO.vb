Imports System.Windows.Forms
Imports HT_PurchaseModule.HT_PurchaseModule

Public Class frmReceivePO
    Public UserUID As Integer
    Private Sub frmReceivePO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        loaddefaultdata()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub loaddefaultdata()
        'Loading the PO drop down ---- Only the open Purchase Orders
        ClearFields()
        Dim bs As New bsPOHeader
        ddlPo.DataSource = bs.GetPOHeaderByStatus("O")
        Me.ddlPo.SelectedIndex = -1
    End Sub
    Private Sub ClearFields()
        lblPoStatus.Text = ""
        lblVendorName.Text = ""
        lblVendorAddr1.Text = ""
        lblVendorCity.Text = ""
        lblVendorState.Text = ""
        lblVendorZip.Text = ""
        dtmEstDate.Text = Today
        dtmPODate.Text = Today
        dgvOrdered.DataSource = Nothing
        dgvPODetail.Rows.Clear()
    End Sub
    Private Sub LoadOrdered()
        'Now going to Load the Ordered Products

        If Not ddlPo.SelectedIndex = -1 Then
            Dim bsd As New bsPODetail
            dgvOrdered.AutoGenerateColumns = False
            dgvOrdered.DataSource = bsd.GetPOdetailOrdered(ddlPo.SelectedValue)
        End If
    End Sub
    Private Sub LoadPo()
        ClearFields()
        If Not ddlPo.SelectedIndex = -1 Then
            'Load Header Info
            Dim bs As New bsPOHeader
            Dim dt As New dsPOHeader.POheaderDataTable

            Dim rw As dsPOHeader.POheaderRow
            rw = bs.GetpoheaderbyUID(ddlPo.SelectedValue)
            If Not rw Is Nothing Then
                If rw.POStatus = "O" Then
                    lblPoStatus.Text = "OPEN"
                End If
                dtmEstDate.Text = rw.EstDeliveryDate
                dtmPODate.Text = rw.PODate
                LoadVendorInfo(rw.VendorUID)
            End If
            LoadOrdered()

        End If
    End Sub
    Private Sub LoadVendorInfo(ByVal VendorUID As Integer)
        Dim bs As New HT_Business.bsVendors
        Dim dt As New HT_Business.dsVendor.VendorDataTable
        Dim rw As HT_Business.dsVendor.VendorRow
        rw = bs.GetVendorbyUID(VendorUID)
        If Not rw Is Nothing Then
            lblVendorName.Text = rw.VendorName
            lblVendorAddr1.Text = rw.Addr1
            lblVendorCity.Text = rw.City
            lblVendorState.Text = rw.State
            lblVendorZip.Text = rw.Zip
        End If
    End Sub
    Private Sub ddlPo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlPo.SelectedIndexChanged
        LoadPo()
        chkClose.Checked = False
    End Sub
    Private Sub dgvOrdered_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOrdered.CellContentClick
        Dim POdetailUID As Integer = dgvOrdered.CurrentRow.Cells(0).Value
        Dim Trigger As Integer = 0
        Dim rw As DataGridViewRow
        For Each rw In dgvPODetail.Rows
            If POdetailUID = rw.Cells(0).Value Then
                Trigger = 1
            End If
        Next
        If Trigger = 0 Then
            'rw = New DataGridViewRow
            'rw.Cells(0).Value = dgvOrdered.CurrentRow.Cells(0).Value
            'rw.Cells(1).Value = dgvOrdered.CurrentRow.Cells(1).Value
            'rw.Cells(2).Value = 0
            'dgvPODetail.Rows.Add(rw)
            dgvPODetail.Rows.Add(dgvOrdered.CurrentRow.Cells(0).Value, dgvOrdered.CurrentRow.Cells(1).Value, " ", 0)
            'CStr(Today.Year) & CStr(Today.Month) & CStr(Today.Day)
        End If
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim rw As DataGridViewRow
        For Each rw In dgvPODetail.Rows
            If rw.Cells(3).Value > 0 Then
                Dim bs As New bsPODetail
                If bs.ReceivePOdetail(rw.Cells(0).Value, rw.Cells(2).Value, rw.Cells(3).Value, UserUID) = 0 Then
                    MsgBox("There was an Error while trying to Receive Item Description " & rw.Cells(2).Value & " Item not Received", MsgBoxStyle.Critical, "Error - Hot Trak")
                End If
            End If
        Next
        LoadPo()
        If chkClose.Checked = True Then
            'if this is checked then we are going to close the Purchase Order
            Dim bs As New bsPOHeader
            bs.ClosePO(ddlPo.SelectedValue, "C")
            lblPoStatus.Text = "CLOSED"
        End If
    End Sub
End Class