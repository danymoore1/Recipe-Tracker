Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Imports HT_Connection
Public Class bsSalesRep
    Inherits Dataprovider
    Private SqlCn As New SqlConnection(GetConnection)
    Public Function GetAllSalesRep() As dsSalesPerson.SalesRepDataTable
        GetAllSalesRep = New dsSalesPerson.SalesRepDataTable
        Dim Sqlcm As New SqlCommand("stp_GetAllSalesRep", SqlCn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Try
            SqlCn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetAllSalesRep)
        Catch ex As Exception
            Errors("GetAllSalesRep")
        Finally
            SqlCn.Close()
        End Try
    End Function
End Class
