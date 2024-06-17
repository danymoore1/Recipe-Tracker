Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports HT_Connection
Public Class bsOrderHeader
    Inherits Dataprovider
    Private Sqlcn As New SqlConnection(GetConnection)
    Public Function GetOrderByStatus(ByVal OrderStatus As String) As dsOrderHeader.OrderHeaderDataTable
        GetOrderByStatus = New dsOrderHeader.OrderHeaderDataTable
        Dim Sqlcm As New SqlCommand("stp_GetOrderHeaderbyStatus", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@OrderStatus", OrderStatus)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetOrderByStatus)
        Catch ex As Exception
            Errors("GetOrderByStatus")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetOrderbyOrderNo(ByVal OrderNo As String) As dsOrderHeader.OrderHeaderDataTable
        GetOrderbyOrderNo = New dsOrderHeader.OrderHeaderDataTable
        Dim Sqlcm As New SqlCommand("stp_GetOrderHdrbyOrderNo", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@OrderNo", OrderNo)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetOrderbyOrderNo)
        Catch ex As Exception
            Errors("GetOrderbyOrderNo")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Sub OrderHeaderStatus(ByVal ORderheaderUID As Integer, ByVal Orderstatus As String)
        Dim Sqlcm As New SqlCommand("stp_UpdateOrderStatus", sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@OrderHeaderUID", ORderheaderUID)
        Sqlcm.Parameters.AddWithValue("@OrderStatus", Orderstatus)
        Try
            Sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("OrderheaderStatus")
        Finally
            Sqlcn.Close()
        End Try
    End Sub
    Public Sub UpdateOrderHeader(ByVal rwOrderHdr As dsOrderHeader.OrderHeaderRow)
        Dim sqlcm As New SqlCommand("stp_UpdateOrderHeader", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        With rwOrderHdr
            sqlcm.Parameters.AddWithValue("@OrderDate", .OrderDate)
            sqlcm.Parameters.AddWithValue("@ShipDate ", .ShipDate)
            sqlcm.Parameters.AddWithValue("@DeliveryDate ", .DeliveryDate)
            sqlcm.Parameters.AddWithValue("@PickUpDate ", .PickUpDate)
            sqlcm.Parameters.AddWithValue("@PONO", .PONO)
            sqlcm.Parameters.AddWithValue("@BillToCode", .BillToCode)
            sqlcm.Parameters.AddWithValue("@ShipToCode", .ShipToCode)
            sqlcm.Parameters.AddWithValue("@ShipToAddr1", .ShipToAddr1)
            sqlcm.Parameters.AddWithValue("@ShipToAddr2", .ShipToAddr2)
            sqlcm.Parameters.AddWithValue("@ShipToCity", .ShipToCity)
            sqlcm.Parameters.AddWithValue("@ShiptoState", .ShiptoState)
            sqlcm.Parameters.AddWithValue("@ShipToZip", .ShipToZip)
            sqlcm.Parameters.AddWithValue("@Salesperson", .Salesperson)
            sqlcm.Parameters.AddWithValue("@OrderStatus", .OrderStatus)
            sqlcm.Parameters.AddWithValue("@ShipTermsUID", .ShipTermsUID)
            sqlcm.Parameters.AddWithValue("@NetTermsUID", .NetTermsUID)
            sqlcm.Parameters.AddWithValue("@ShipToName", .ShipToName)
            sqlcm.Parameters.AddWithValue("@ShipmentNo", .ShipmentNo)
            sqlcm.Parameters.AddWithValue("@CustOrderNo", .CustOrderNo)
            sqlcm.Parameters.AddWithValue("@OrderHeaderUID", .OrdrHeaderUID)
        End With
        Try
            Sqlcn.Open()
            sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("UpdateOrderHeader")
        Finally
            Sqlcn.Close()
        End Try
    End Sub

    Public Function InsertOrderHeader(ByVal rwOrderHdr As dsOrderHeader.OrderHeaderRow) As Integer
        Dim sqlcm As New SqlCommand("stp_InsertOrderHeader", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure

        With rwOrderHdr
            sqlcm.Parameters.AddWithValue("@OrderNo", .OrderNo)
            sqlcm.Parameters.AddWithValue("@OrderDate", .OrderDate)
            sqlcm.Parameters.AddWithValue("@ShipDate ", .ShipDate)
            sqlcm.Parameters.AddWithValue("@DeliveryDate ", .DeliveryDate)
            sqlcm.Parameters.AddWithValue("@PickUpDate ", .PickUpDate)
            sqlcm.Parameters.AddWithValue("@PONO", .PONO)
            sqlcm.Parameters.AddWithValue("@BillToCode", .BillToCode)
            sqlcm.Parameters.AddWithValue("@ShipToCode", .ShipToCode)
            sqlcm.Parameters.AddWithValue("@ShipToAddr1", .ShipToAddr1)
            sqlcm.Parameters.AddWithValue("@ShipToAddr2", .ShipToAddr2)
            sqlcm.Parameters.AddWithValue("@ShipToCity", .ShipToCity)
            sqlcm.Parameters.AddWithValue("@ShiptoState", .ShiptoState)
            sqlcm.Parameters.AddWithValue("@ShipToZip", .ShipToZip)
            sqlcm.Parameters.AddWithValue("@Salesperson", .Salesperson)
            sqlcm.Parameters.AddWithValue("@OrderStatus", .OrderStatus)
            sqlcm.Parameters.AddWithValue("@ShipTermsUID", .ShipTermsUID)
            sqlcm.Parameters.AddWithValue("@NetTermsUID", .NetTermsUID)
            sqlcm.Parameters.AddWithValue("@ShipToName", .ShipToName)
            sqlcm.Parameters.AddWithValue("@ShipmentNo", .ShipmentNo)
            sqlcm.Parameters.AddWithValue("@CustOrderNo", .CustOrderNo)
            sqlcm.Parameters.AddWithValue("@OrderHeaderUID", .OrdrHeaderUID)
            sqlcm.Parameters(20).Direction = ParameterDirection.Output

        End With
        Try
            Sqlcn.Open()
            sqlcm.ExecuteNonQuery()
            InsertOrderHeader = sqlcm.Parameters(20).Value
        Catch ex As Exception
            Errors("InsertOrderHeader")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Sub DeleteOrderHeader(ByVal OrderHeaderUID As Integer)

    End Sub
    Public Function GetAutoShipping(ByVal DelDte As Date) As DataTable
        GetAutoShipping = New DataTable
        Dim sql As String = "stp_AutoShippingOrders '" & DelDte & "'"
        Dim sqlcn As New SqlConnection(GetConnection)
        Dim sqlcm As New SqlCommand(sql, sqlcn)
        Try
            sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(sqlcm)
            sqlda.Fill(GetAutoShipping)
            sqlcn.Close()
        Catch ex As Exception
            sqlcn.Close()
            Errors("GetAutoShipping")
        End Try
    End Function
    Public Sub DeletewktmpInv()
        Dim Sqlcm As New SqlCommand("stp_DeleteWktmpInv", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Try
            Sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("DeleteWkTmpInv")
        Finally
            Sqlcn.Close()
        End Try
    End Sub
    Public Sub InsertwkTmpInv(ByVal InvoiceNo As String)
        Dim Sqlcm As New SqlCommand("stp_InsertWkTmpInv", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@InvoiceNo", InvoiceNo)
        Try
            Sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("InsertWktmpInv")
        Finally
            Sqlcn.Close()
        End Try
    End Sub
    Public Function GetInvoiceHeader() As dsOrderHeader.invRptDataTable
        GetInvoiceHeader = New dsOrderHeader.invRptDataTable
        Dim Sqlcm As New SqlCommand("stp_InvoiceReprt", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetInvoiceHeader)
        Catch ex As Exception
            Errors("GetInvoiceHeader")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Sub CompleteInvoice()
        Dim Sqlcm As New SqlCommand("stp_CompleteInvoice", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Try
            Sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("CompleteInvoicing")
        Finally
            Sqlcn.Close()
        End Try
    End Sub
End Class
