Imports System.Data
Imports System.Data.SqlClient
Imports HT_Connection
Imports Microsoft.Data.SqlClient
Public Class bsCustomerPackHdr
    Inherits Dataprovider
    Private Sqlcn As New SqlConnection(GetConnection)
    Public Function GetCustomeritemDescr(ByVal CusPackUID As Integer) As String
        GetCustomeritemDescr = ""
        Dim Sqlcm As New SqlCommand("stp_GetCustomerPackHDRDesc", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@CusPackUID", CusPackUID)
        Sqlcm.Parameters.AddWithValue("@ItemDesc", "")
        Try
            Sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
            GetCustomeritemDescr = Sqlcm.Parameters(1).Value
        Catch ex As Exception
            Errors("GetCustomerItemDescr")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetCustomerPackLst() As dsCustomerPackHdr.CustomerPackLstDataTable
        GetCustomerPackLst = New dsCustomerPackHdr.CustomerPackLstDataTable
        Dim Sqlcm As New SqlCommand("stp_GetCustomerItemLst", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetCustomerPackLst)
        Catch ex As Exception
            Errors("GetCustomerPackLst")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetCustomerPackbyITemUID(ByVal ITemUID As Integer) As dsCustomerPackHdr.CustomerPackHdrDataTable
        GetCustomerPackbyITemUID = New dsCustomerPackHdr.CustomerPackHdrDataTable
        Dim Sqlcm As New SqlCommand("stp_GetCustomerPackHDRbyITemUID", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@ItemUID", ITemUID)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetCustomerPackbyITemUID)
        Catch ex As Exception
            Errors("GetCustomerPackHdrbyItemUID")
        Finally
            Sqlcn.Close()
        End Try
    End Function

    Public Function GetCustomerPackHDrbyCust(ByVal CustUID As Integer) As dsCustomerPackHdr.CustomerPackHdrDataTable
        GetCustomerPackHDrbyCust = New dsCustomerPackHdr.CustomerPackHdrDataTable
        Dim Sqlcm As New SqlCommand("stp_GetCustomerPackHDRbyCust", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@CustUID", CustUID)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetCustomerPackHDrbyCust)
        Catch ex As Exception
            Errors("GetCustomerPackHdrbyCust")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetCustomerPackHdr(ByVal CusPackUID As Integer) As dsCustomerPackHdr.CustomerPackHdrRow
        Dim dtCuspack As New dsCustomerPackHdr.CustomerPackHdrDataTable
        GetCustomerPackHdr = dtCuspack.NewCustomerPackHdrRow
        Dim sqlcm As New SqlCommand("stp_GetCustomerPackHdr", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@CusPackUID", CusPackUID)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(sqlcm)
            Sqlda.Fill(dtCuspack)
            For Each GetCustomerPackHdr In dtCuspack
                Return GetCustomerPackHdr
                Exit For
            Next
        Catch ex As Exception
            Errors("GetCustomerPackHdr")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Sub UpdateCustomerPackHdr(ByVal rwCusPack As dsCustomerPackHdr.CustomerPackHdrRow)
        Dim sqlcm As New SqlCommand("stp_UpdateCustomerPackHdr", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        With rwCusPack
            sqlcm.Parameters.AddWithValue("@CustUID", .CustUID)
            sqlcm.Parameters.AddWithValue("@ItemUID", .ItemUID)
            sqlcm.Parameters.AddWithValue("@CusPackDesc", .CusPackDesc)
            sqlcm.Parameters.AddWithValue("@CustomerItemNo", .CustomerItemNo)
            sqlcm.Parameters.AddWithValue("@CusPackUID", .CusPackUID)
            sqlcm.Parameters.AddWithValue("@CaseQty", .CaseQty)
            Try
                Sqlcn.Open()
                sqlcm.ExecuteNonQuery()
            Catch ex As Exception
                Errors("UpdateCustomerPackHdr")
            Finally
                Sqlcn.Close()
            End Try
        End With
    End Sub
    Public Function InsertCustomerPackHdr(ByVal rwCustpack As dsCustomerPackHdr.CustomerPackHdrRow) As Integer
        InsertCustomerPackHdr = 0
        Dim Sqlcm As New SqlCommand("stp_InsertCustomerPackHdr", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        With rwCustpack
            Sqlcm.Parameters.AddWithValue("@CustUID", .CustUID)
            Sqlcm.Parameters.AddWithValue("@ItemUID", .ItemUID)
            Sqlcm.Parameters.AddWithValue("@CusPackDesc", .CusPackDesc)
            Sqlcm.Parameters.AddWithValue("@CustomerItemNo", .CustomerItemNo)
            Sqlcm.Parameters.AddWithValue("@CusPackUID", .CusPackUID)
            Sqlcm.Parameters(4).Direction = ParameterDirection.Output
            Sqlcm.Parameters.AddWithValue("@CaseQty", .CaseQty)
        End With
        Try
            Sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
            InsertCustomerPackHdr = Sqlcm.Parameters(4).Value
        Catch ex As Exception
            Errors("InsertCustomerPackHdr")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetAllCustomerPackHdr() As HT_Business.dsCustomerPackHdr.CustomerPackHdrDataTable
        GetAllCustomerPackHdr = New HT_Business.dsCustomerPackHdr.CustomerPackHdrDataTable
        Dim Sqlcm As New SqlCommand("stp_GetAllCustPackHDR", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetAllCustomerPackHdr)
        Catch ex As Exception
            Errors("GetAllCustomerPackHdr")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetCustomerPackHDRItems() As DataTable
        GetCustomerPackHDRItems = New DataTable
        Dim Sqlcm As New SqlCommand("Select * From vw_CustomerPackHDr", Sqlcn)
        Sqlcm.CommandType = CommandType.Text
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetCustomerPackHDRItems)
        Catch ex As Exception
            Errors("GetCustomerPackHdrItems")
        Finally
            Sqlcn.Close()
        End Try
    End Function
End Class
