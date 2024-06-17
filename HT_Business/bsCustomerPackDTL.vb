Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Data.SqlClient

Imports HT_Connection
Public Class bsCustomerPackDTL
    Inherits Dataprovider
    Private Sqlcn As New SqlConnection(GetConnection)
    Public Sub DeleteCuspackDtl(ByVal CusDtlUID As Integer)
        Dim Sqlcm As New SqlCommand("stp_DeleteCustomerPackDTL", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@CusDtlUID", CusDtlUID)
        Try
            Sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("DeleteCusPackDtl")
        Finally
            Sqlcn.Close()
        End Try
    End Sub
    Public Function InsertCustomerPackDtl(ByVal rwCuspackDtl As dsCustomerPackDTL.CustomerPackDTLRow) As Integer
        InsertCustomerPackDtl = 0
        Dim Sqlcm As New SqlCommand("stp_InsertCustomerpackDtl", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        With rwCuspackDtl
            Sqlcm.Parameters.AddWithValue("@CustPackUID", .CustPackUID)
            Sqlcm.Parameters.AddWithValue("@ItemNoUID", .ItemNoUID)
            Sqlcm.Parameters.AddWithValue("@Qty", .Qty)
            Sqlcm.Parameters.AddWithValue("@CusdtlUID", 0)
            Sqlcm.Parameters(3).Direction = ParameterDirection.Output
            Try
                Sqlcn.Open()
                Sqlcm.ExecuteNonQuery()
                InsertCustomerPackDtl = Sqlcm.Parameters(3).Value
            Catch ex As Exception
                Errors("InsertCustomerPackDtl")
            Finally
                Sqlcn.Close()
            End Try
        End With
    End Function
    Public Function GetCustomerPackDtl(ByVal CusdtlUID As Integer) As dsCustomerPackDTL.CustomerPackDTLRow
        Dim dtCustDTL As New dsCustomerPackDTL.CustomerPackDTLDataTable
        GetCustomerPackDtl = dtCustDTL.NewCustomerPackDTLRow
        Dim Sqlcm As New SqlCommand("stp_GetCustomerPackDTL", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@CusdtlUID", CusdtlUID)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(dtCustDTL)
            For Each GetCustomerPackDtl In dtCustDTL
                Return GetCustomerPackDtl
                Exit For
            Next
        Catch ex As Exception
            Errors("GetCustomerPackDTl")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Sub UpdateCustomerPackDtl(ByVal RwCustDTL As dsCustomerPackDTL.CustomerPackDTLRow)
        Dim Sqlcm As New SqlCommand("stp_UpdateCustomerPackDTL", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        With RwCustDTL
            Sqlcm.Parameters.AddWithValue("@CustpackUID", .CustPackUID)
            Sqlcm.Parameters.AddWithValue("@ItemnoUID", .ItemNoUID)
            Sqlcm.Parameters.AddWithValue("@Qty", .Qty)
            Sqlcm.Parameters.AddWithValue("@CusDTLUID", .CusDtlUID)
        End With
        Try
            Sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("UpdateCustomerPackDTL")
        Finally
            Sqlcn.Close()
        End Try
    End Sub
    Public Function GetCustItemdtl_lst(ByVal CustPackUID As Integer) As DataTable
        GetCustItemdtl_lst = New DataTable
        Dim sql As String = "stp_GetCustomeritemdtl_lst " & CustPackUID
        Dim sqlcn As New SqlConnection(GetConnection)
        Dim Sqlcm As New SqlCommand(sql, sqlcn)
        Try
            sqlcn.Open()
            Dim da As New SqlDataAdapter(Sqlcm)
            da.Fill(GetCustItemdtl_lst)
            sqlcn.Close()
        Catch ex As Exception
            sqlcn.Close()
            Errors("GetCusItemDtl_lst")
        End Try
    End Function
    Public Function GetCustomerDTL(ByVal CustPackUID As Integer) As dsCustomerPackDTL.CustomerPackDTLDataTable
        GetCustomerDTL = New dsCustomerPackDTL.CustomerPackDTLDataTable
        Dim Sqlcm As New SqlCommand("stp_GetCustomerDTL", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@CustPackUID", CustPackUID)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetCustomerDTL)
        Catch ex As Exception
            Errors("GetCustomerDTL")
        Finally
            Sqlcn.Close()
        End Try
    End Function
End Class

