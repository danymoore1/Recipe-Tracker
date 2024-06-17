Imports Microsoft.Reporting.WinForms
Public Class rptWriter
    Public rptdoc As String
    Public datasetName1 As String
    Public DatasetName2 As String
    Public Datatable2 As New DataTable
    Public Datatable1 As New DataTable
    Private Sub rptWriter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HotTrakDataSet.stp_PurchaseOrderHDRrpt' table. You can move, or remove it, as needed.
        GetReportLoaded()
    End Sub
    Public Sub GetReportLoaded()
        rvReport.LocalReport.ReportPath = rptdoc
        rvReport.LocalReport.DataSources.Add(New ReportDataSource(datasetName1, Datatable1))
        If Datatable2.Rows.Count > 0 And DatasetName2 > "" Then
            rvReport.LocalReport.DataSources.Add(New ReportDataSource(DatasetName2, Datatable2))
        End If
        Me.rvReport.RefreshReport()
    End Sub


End Class