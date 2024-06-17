Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Public Class bsCustomer
    Inherits HT_Connection.Dataprovider
    Private Sqlcn As New SqlConnection(GetConnection)
    Public Function GetAllCustomers() As dsCustomer.CustomerDataTable
        GetAllCustomers = New dsCustomer.CustomerDataTable
        Dim sqlcm As New SqlCommand("stp_GetAllCustomers", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(sqlcm)
            Sqlda.Fill(GetAllCustomers)
        Catch ex As Exception
            Errors("GetAllCustomers")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetBillToCustomers() As DataTable
        GetBillToCustomers = New DataTable
        Dim Sqlcm As New SqlCommand("stp_GetBillToCustomers", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Try
            Sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(Sqlcm)
            sqlda.Fill(GetBillToCustomers)
        Catch ex As Exception
            Errors("GetBillToCustomers")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetShipToCustomersbyBillTo(ByVal BillTocode As String) As dsCustomer.CustomerDataTable
        GetShipToCustomersbyBillTo = New dsCustomer.CustomerDataTable
        Dim Sqlcm As New SqlCommand("stp_GetShipToCustbyBillto", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@BillToCode", BillTocode)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetShipToCustomersbyBillTo)
        Catch ex As Exception
            Errors("GetSHipToCustomerbyBillTo")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetCustomerByCustCode(ByVal CustCode As String) As dsCustomer.CustomerRow
        Dim dtCustomer As New dsCustomer.CustomerDataTable
        GetCustomerByCustCode = dtCustomer.NewCustomerRow
        Dim sqlcm As New SqlCommand("stp_GetCustomerbyCustCode", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@CustCode", CustCode)
        Try
            Sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(sqlcm)
            sqlda.Fill(dtCustomer)
            For Each GetCustomerByCustCode In dtCustomer
                Return GetCustomerByCustCode
                Exit For
            Next
        Catch ex As Exception
            Errors("GetCustomerbyCustCode")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Sub UpdateCustomer(ByVal rwCustomer As dsCustomer.CustomerRow)
        Dim Sqlcm As New SqlCommand("stp_UpdateCustomer", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        With rwCustomer
            Sqlcm.Parameters.AddWithValue("@Address1", .Address1)
            Sqlcm.Parameters.AddWithValue("@Address2", .Address2)
            Sqlcm.Parameters.AddWithValue("@City", .City)
            Sqlcm.Parameters.AddWithValue("@State", .State)
            Sqlcm.Parameters.AddWithValue("@Zip", .Zip)
            Sqlcm.Parameters.AddWithValue("@Phone", .Phone)
            Sqlcm.Parameters.AddWithValue("@Fax", .Fax)
            Sqlcm.Parameters.AddWithValue("@Email", .Email)
            Sqlcm.Parameters.AddWithValue("@Contact", .Contact)
            Sqlcm.Parameters.AddWithValue("@NetTermsUID", .NetTermsUID)
            Sqlcm.Parameters.AddWithValue("@ShipTermsUID", .ShipTermsUID)
            Sqlcm.Parameters.AddWithValue("@BillToCode", .BillToCode)
            Sqlcm.Parameters.AddWithValue("@CustName", .CustName)
            Sqlcm.Parameters.AddWithValue("@Inactive", .Inactive)
            Sqlcm.Parameters.AddWithValue("@AllowDays", .AllowDays)
            Sqlcm.Parameters.AddWithValue("@CustUID", .CustUID)
        End With
        Try
            Sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("UpdateCustomer")
        Finally
            Sqlcn.Close()
        End Try
    End Sub
    Public Function InsertCustomer(ByVal rwCustomer As dsCustomer.CustomerRow) As Integer
        Dim sqlcm As New SqlCommand("stp_InsertCustomer", Sqlcn)
        InsertCustomer = 0
        sqlcm.CommandType = CommandType.StoredProcedure
        With rwCustomer
            sqlcm.Parameters.AddWithValue("@Address1", .Address1)
            sqlcm.Parameters.AddWithValue("@Address2", .Address2)
            sqlcm.Parameters.AddWithValue("@City", .City)
            sqlcm.Parameters.AddWithValue("@State", .State)
            sqlcm.Parameters.AddWithValue("@Zip", .Zip)
            sqlcm.Parameters.AddWithValue("@Phone", .Phone)
            sqlcm.Parameters.AddWithValue("@Fax", .Fax)
            sqlcm.Parameters.AddWithValue("@Email", .Email)
            sqlcm.Parameters.AddWithValue("@Contact", .Contact)
            sqlcm.Parameters.AddWithValue("@NetTermsUID", .NetTermsUID)
            sqlcm.Parameters.AddWithValue("@ShipTermsUID", .ShipTermsUID)
            sqlcm.Parameters.AddWithValue("@BillToCode", .BillToCode)
            sqlcm.Parameters.AddWithValue("@CustName", .CustName)
            sqlcm.Parameters.AddWithValue("@Inactive", .Inactive)
            sqlcm.Parameters.AddWithValue("@AllowDays", .AllowDays)
            sqlcm.Parameters.AddWithValue("@CustCode", .CustCode)
            sqlcm.Parameters.AddWithValue("@CustUID", .CustUID)
            sqlcm.Parameters(16).Direction = ParameterDirection.Output
        End With
        Try
            Sqlcn.Open()
            sqlcm.ExecuteNonQuery()
            InsertCustomer = sqlcm.Parameters(16).Value
        Catch ex As Exception
            Errors("InsertCustomer")
        Finally
            Sqlcn.Close()
        End Try
    End Function

End Class
