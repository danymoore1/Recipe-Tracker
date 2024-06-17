Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Imports HT_Connection
Public Class bsCustomerPricing
    Inherits Dataprovider
    Private Sqlcn As New SqlConnection(GetConnection)
    Public Function GetItemPricebyDate(ByVal CuspackUID As Integer, ByVal Dte As Date) As Decimal
        GetItemPricebyDate = 0
        Dim sqlcm As New SqlCommand("stp_GetCustomerPricebyDte", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@ItemUID", CuspackUID)
        sqlcm.Parameters.AddWithValue("@Dte", Dte)
        sqlcm.Parameters.AddWithValue("@CaseCost", 0)
        sqlcm.Parameters(2).Direction = ParameterDirection.Output
        Try
            Sqlcn.Open()
            sqlcm.ExecuteNonQuery()
            GetItemPricebyDate = sqlcm.Parameters(2).Value
        Catch ex As Exception
            Errors("GetITemPriceByDate")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetPricebyCustPriceUID(ByVal CusPackPrice As Integer) As dsCustomerPricing.CustomerPricingRow
        Dim DtCustPrice As New dsCustomerPricing.CustomerPricingDataTable
        GetPricebyCustPriceUID = DtCustPrice.NewCustomerPricingRow
        Dim Sqlcm As New SqlCommand("stp_GetPriceByCustPriceUID", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@CustPriceUID", CusPackPrice)
        Try
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(DtCustPrice)
            For Each GetPricebyCustPriceUID In DtCustPrice.Rows
                Return GetPricebyCustPriceUID
                Exit For
            Next
        Catch ex As Exception
            Errors("GetPriceByCustPrice")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function InsertCustomerPricing(ByVal rwCustPrice As dsCustomerPricing.CustomerPricingRow) As Integer
        Dim Sqlcm As New SqlCommand("stp_InsertCustomerPricing", Sqlcn)
        InsertCustomerPricing = 0
        Sqlcm.CommandType = CommandType.StoredProcedure
        With rwCustPrice
            Sqlcm.Parameters.AddWithValue("@CuspackUID", .CuspackUID)
            Sqlcm.Parameters.AddWithValue("@frmDte", .FrmDte)
            Sqlcm.Parameters.AddWithValue("@ToDte", .ToDte)
            Sqlcm.Parameters.AddWithValue("@TrayCost", .TrayCost)
            Sqlcm.Parameters.AddWithValue("@CaseCost", .CaseCost)
            Sqlcm.Parameters.AddWithValue("@CustPriceUID", 0)
            Sqlcm.Parameters(5).Direction = ParameterDirection.Output
        End With
        Try
            Sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
            InsertCustomerPricing = Sqlcm.Parameters(5).Value
        Catch ex As Exception
            Errors("InsertCustomerPricing")
        Finally
            Sqlcn.Close()
        End Try

    End Function
    Public Sub UpdateCustomerPricing(ByVal rwcustprice As dsCustomerPricing.CustomerPricingRow)
        Dim sqlcm As New SqlCommand("stp_UpdateCustomerPricing", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        With rwcustprice
            sqlcm.Parameters.AddWithValue("@CuspackUID", .CuspackUID)
            sqlcm.Parameters.AddWithValue("@frmDte", .FrmDte)
            sqlcm.Parameters.AddWithValue("@ToDte", .ToDte)
            sqlcm.Parameters.AddWithValue("@TrayCost", .TrayCost)
            sqlcm.Parameters.AddWithValue("@CaseCost", .CaseCost)
            sqlcm.Parameters.AddWithValue("@CustPriceUID", .CustPriceUID)
            Try
                Sqlcn.Open()
                sqlcm.ExecuteNonQuery()
            Catch ex As Exception
                Errors("UpdateCustomerPricing")
            Finally
                Sqlcn.Close()
            End Try
        End With
    End Sub
    Public Sub DeleteCustomerPricing(ByVal CustPriceUID As Integer)
        Dim sqlcm As New SqlCommand("stp_DeleteCustomerPricing", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@CustPriceUID", CustPriceUID)
        Try
            Sqlcn.Open()
            sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("DeleteCustomerPricing")
        Finally
            Sqlcn.Close()
        End Try
    End Sub
    Public Function GetCusPricebyCusPackUID(ByVal CuspackUID As Integer) As dsCustomerPricing.CustomerPricingDataTable
        GetCusPricebyCusPackUID = New dsCustomerPricing.CustomerPricingDataTable
        Dim Sqlcm As New SqlCommand("stp_GetCusPriceByCusPackUID", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@CusPackUID", CuspackUID)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetCusPricebyCusPackUID)
        Catch ex As Exception
            Errors("GetCusPriceByCusPackUID")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetCustomerPricesLst(ByVal CusPackUID As Integer) As DataTable
        GetCustomerPricesLst = New DataTable
        Dim Sqlcm As New SqlCommand("stp_GetCustomerPricesbyCusPackUID", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@CusPackUID", CusPackUID)
        Try
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetCustomerPricesLst)
        Catch ex As Exception
            Errors("GetCustomerPriceLst")
        Finally
            Sqlcn.Close()
        End Try
    End Function
End Class
