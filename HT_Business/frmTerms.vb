Public Class frmTerms

    Private Sub frmTerms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadNetTerms()
        LoadShipTerms()
    End Sub

    Private Sub LoadNetTerms()
        Dim bsTerms As New bsTerms
        ddlNetTerms.DataSource = bsTerms.GetAllNetTerms
    End Sub
    Private Sub LoadShipTerms()
        Dim bsTerms As New bsTerms
        ddlshipterms.DataSource = bsTerms.GetAllShipTerms
    End Sub

    Private Sub ddlNetTerms_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlNetTerms.Leave
        Dim Found As Integer = ddlNetTerms.FindString(ddlNetTerms.Text)
        If Found > -1 Then
            'Load the form with selection
            ddlNetTerms.SelectedIndex = Found
            btnNetSave.Text = "Update"
            Dim bsTerm As New bsTerms
            Dim rwNetTerm As dsTerms.NetTermsRow
            rwNetTerm = bsTerm.GetNetTermbyUID(ddlNetTerms.SelectedValue)
            With rwNetTerm
                txtNetTermsDesc.Text = .NetTermsDesc

            End With
        Else
            'New Term, lay out form to add
            btnNetSave.Text = "Add"
        End If
    End Sub

    Private Sub ddlshipterms_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlshipterms.Leave
        Dim Found As Integer = ddlshipterms.FindString(ddlshipterms.Text)
        If Found > -1 Then
            ddlshipterms.SelectedIndex = Found
            'Load the form with selection
            btnShipSave.Text = "Update"
            Dim bsShipTerms As New bsTerms
            Dim rwShipTerm As dsTerms.ShipTermsRow
            rwShipTerm = bsShipTerms.GetShipTermbyUID(ddlshipterms.SelectedValue)
            With rwShipTerm
                txtShipDesc.Text = .ShipTermDesc
            End With
        Else
            'New Term, lay out form to add
            btnShipSave.Text = "Add"

        End If
    End Sub

    Private Sub btnNetCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNetCancel.Click
        Me.Close()
    End Sub

    Private Sub btnShipCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShipCancel.Click
        Me.Close()
    End Sub

    Private Sub btnShipSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShipSave.Click
        Dim bsTerms As New bsTerms
        Dim dtShipTerms As New dsTerms.ShipTermsDataTable
        Dim rwShipTerms As dsTerms.ShipTermsRow
        rwShipTerms = dtShipTerms.NewShipTermsRow
        With rwShipTerms
            .ShipTermDesc = txtShipDesc.Text
            .ShipTerms = ddlshipterms.Text
            .ShipTermsUID = ddlshipterms.SelectedValue
        End With
        If btnShipSave.Text = "Update" Then
            bsTerms.UpdateShipTerms(rwShipTerms)
        ElseIf btnShipSave.Text = "Add" Then
            bsTerms.InsertShipTerms(rwShipTerms)
        End If
        LoadShipTerms()
    End Sub

    Private Sub btnNetSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNetSave.Click
        Dim bsTerms As New bsTerms
        Dim dtNetTerms As New dsTerms.NetTermsDataTable
        Dim rwNetTerms As dsTerms.NetTermsRow
        rwNetTerms = dtNetTerms.NewNetTermsRow
        With rwNetTerms
            .NetTermsDesc = txtNetTermsDesc.Text
            .NetTerms = ddlNetTerms.Text
            .NetTermsUID = ddlNetTerms.SelectedValue
        End With
        If btnNetSave.Text = "Update" Then
            bsTerms.UpdateNetTerms(rwNetTerms)
        ElseIf btnNetSave.Text = "Add" Then
            bsTerms.InsertNetTerms(rwNetTerms)
        End If
        LoadNetTerms()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class