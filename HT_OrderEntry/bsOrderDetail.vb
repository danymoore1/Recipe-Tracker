Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Imports HT_Connection
Imports HT_OrderEntry.HT_OrderEntry
Public Class bsOrderDetail
    Inherits DataProvider
    Private SQlcn As New SqlConnection(GetConnection)
    Public Function GetItemMasterDesc(ByVal ItemUID As Integer) As String
        GetItemMasterDesc = ""
        Dim Sqlcm As New SqlCommand("stp_GetITemMasterDesc", SQlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@ItemUID", ItemUID)
        Try
            SQlcn.Open()
            Dim Sqldr As SqlDataReader
            Sqldr = Sqlcm.ExecuteReader
            While Sqldr.Read
                GetItemMasterDesc = Sqldr.GetString(0)
            End While
        Catch ex As Exception
            Errors("GetItemMasterDesc")
        Finally
            SQlcn.Close()
        End Try
    End Function
    Public Function GetShippingItems(ByVal OrderHeaderUID As Integer) As DataTable
        GetShippingItems = New DataTable
        Dim sqlcm As New SqlCommand("stp_GetShippingItems", SQlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@OrderHeaderUID", OrderHeaderUID)
        Try
            SQlcn.Open()
            Dim da As New SqlDataAdapter(sqlcm)
            da.Fill(GetShippingItems)
        Catch ex As Exception
            Errors("GetShippingItems")
        Finally
            SQlcn.Close()
        End Try
    End Function
    Public Function InsertOrderDetail(ByVal rwOrderDtl As dsOrderDetail.OrderDetailRow) As Integer
        Dim Sqlcm As New SqlCommand("stp_InsertOrderDetail", SQlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        With rwOrderDtl
            Sqlcm.Parameters.AddWithValue("@OrderHeaderUID", .OrderHeaderUID)
            Sqlcm.Parameters.AddWithValue("@CusPackUID", .CusPackUID)
            Sqlcm.Parameters.AddWithValue("@Qty", .Qty)
            Sqlcm.Parameters.AddWithValue("@Price", .Price)
            Sqlcm.Parameters.AddWithValue("@OrderDetailUID", .OrderDetailUID)
            Sqlcm.Parameters(4).Direction = ParameterDirection.Output
            Try
                SQlcn.Open()
                Sqlcm.ExecuteNonQuery()
                InsertOrderDetail = Sqlcm.Parameters(4).Value
            Catch ex As Exception
                Errors("InsertOrderDetail")
            Finally
                SQlcn.Close()
            End Try
        End With

    End Function
    Public Sub UpdateOrderDetail(ByVal rwOrderDtl As dsOrderDetail.OrderDetailRow)
        Dim sqlcm As New SqlCommand("stp_UpdateOrderDetail", SQlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        With rwOrderDtl
            sqlcm.Parameters.AddWithValue("@OrderHeaderUID", .OrderHeaderUID)
            sqlcm.Parameters.AddWithValue("@CusPackUID", .CusPackUID)
            sqlcm.Parameters.AddWithValue("@Qty", .Qty)
            sqlcm.Parameters.AddWithValue("@Price", .Price)
            sqlcm.Parameters.AddWithValue("@OrderDetailUID", .OrderDetailUID)
            Try
                SQlcn.Open()
                sqlcm.ExecuteNonQuery()
            Catch ex As Exception
                Errors("UpdateOrderDetail")
            Finally
                SQlcn.Close()
            End Try
        End With
    End Sub
    Public Sub DeleteOrderDetail(ByVal ORderDetailUID As Integer)
        Dim sqlcm As New SqlCommand("stp_Deleteorderdetail", SQlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@OrderdetailUID", ORderDetailUID)
        Try
            SQlcn.Open()
            sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("DeleteOrderDetail")
        Finally
            SQlcn.Close()
        End Try
    End Sub
    Public Function GetOrderdetailgridN(ByVal OrderheaderUID As Integer) As DataTable
        GetOrderdetailgridN = New DataTable
        Dim sqlcm As New SqlCommand("stp_GetOrderDetailGridnew", SQlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@OrderHeaderUID", OrderheaderUID)
        Try
            SQlcn.Open()
            Dim sqlda As New SqlDataAdapter(sqlcm)
            sqlda.Fill(GetOrderdetailgridN)
        Catch ex As Exception
            Errors("GetOrderDetailgridn")
        Finally
            SQlcn.Close()
        End Try
    End Function
    Public Function GetOrderDetailGrid(ByVal OrderHeaderUID As Integer) As dsOrderDetail.OrderDetailGridDataTable
        GetOrderDetailGrid = New dsOrderDetail.OrderDetailGridDataTable
        Dim Sqlcm As New SqlCommand("stp_GetOrderDetailgrid", sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@OrderHeaderUID", OrderHeaderUID)
        Try
            SQlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetOrderDetailGrid)
        Catch ex As Exception
            Errors("GetOrderDetailGrid")
        Finally
            SQlcn.Close()
        End Try
    End Function
    'Public Function GetInvoiceDetail() As dsOrderDetail.InvoiceDetailDataTable
    '    GetInvoiceDetail = New dsOrderDetail.InvoiceDetailDataTable
    '    Dim Sqlcm As New SqlCommand("stp_InvoiceDetail", SQlcn)
    '    Sqlcm.CommandType = CommandType.StoredProcedure
    '    Try
    '        SQlcn.Open()
    '        Dim Sqlda As New SqlDataAdapter(Sqlcm)
    '        Sqlda.Fill(GetInvoiceDetail)
    '    Catch ex As Exception
    '        Errors("GetInvoiceDetail")
    '    Finally
    '        SQlcn.Close()
    '    End Try
    'End Function
    Public Function GetPickTicketData(ByVal OrderHeaderUID As Integer) As dsOrderDetail.dsrptPickTicketDataTable
        GetPickTicketData = New dsOrderDetail.dsrptPickTicketDataTable
        Dim Sqlcm As New SqlCommand("stp_rptPickTicket", SQlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@OrderHeaderUID", OrderHeaderUID)
        Try
            SQlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetPickTicketData)
        Catch ex As Exception
            Errors("GetPickTicket")
        Finally
            SQlcn.Close()
        End Try
    End Function
    Public Function GetBOLRpt(ByVal OrderheaderUID As Integer) As dsOrderDetail.dsrptBOLDataTable
        GetBOLRpt = New dsOrderDetail.dsrptBOLDataTable
        Dim SQlcm As New SqlCommand("stp_rptBOL", SQlcn)
        SQlcm.CommandType = CommandType.StoredProcedure
        SQlcm.Parameters.AddWithValue("@OrderheaderUID", OrderheaderUID)
        Try
            SQlcn.Open()
            Dim Sqlda As New SqlDataAdapter(SQlcm)
            Sqlda.Fill(GetBOLRpt)
        Catch ex As Exception
            Errors("GetBOLRpt")
        Finally
            SQlcn.Close()
        End Try
    End Function

End Class
