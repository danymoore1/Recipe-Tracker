Imports System.Data
Imports System.Data.SqlClient
Imports HT_Connection
Imports Microsoft.Data.SqlClient

Public Class bsDelivery
    Inherits Dataprovider
    Private Sqlcn As New SqlConnection(GetConnection)
    Public Function GetAllDeliveryMethods() As dsDelivery.DeliveryMethodDataTable
        GetAllDeliveryMethods = New dsDelivery.DeliveryMethodDataTable
        Dim Sqlcm As New SqlCommand("stp_GetAllDeliveryMethods", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Try
            Sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(Sqlcm)
            sqlda.Fill(GetAllDeliveryMethods)
        Catch ex As Exception
            Errors("GetAllDeliveryMethods")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetAllDeliveryTerms() As dsDelivery.DeliveryTermsDataTable
        GetAllDeliveryTerms = New dsDelivery.DeliveryTermsDataTable
        Dim Sqlcm As New SqlCommand("stp_GetAllDeliveryTerms", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetAllDeliveryTerms)
        Catch ex As Exception
            Errors("GetAllDeliveryTerms")
        Finally
            Sqlcn.Close()
        End Try
    End Function
End Class
