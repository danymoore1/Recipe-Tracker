Imports Microsoft.Data.SqlClient
Imports HT_Connection
Imports HT_PurchaseModule.HT_PurchaseModule
Public Class bsPOHeader
    Inherits DataProvider
    Private Sqlcn As New SqlConnection(GetConnection)
    Public Sub ClosePO(ByVal PoheaderUID As Integer, ByVal postatus As String)
        Dim sql As String = "stp_UpdatePOStatus " & PoheaderUID & ",'" & postatus & "'"
        Dim sqlcn As New SqlConnection(GetConnection)
        Dim sqlcm As New SqlCommand(sql, sqlcn)
        Try
            sqlcn.Open()
            sqlcm.ExecuteNonQuery()
            sqlcn.Close()
        Catch ex As Exception
            sqlcn.Close()
            Errors("ClosePO")
        End Try
    End Sub
    Public Function GetPOHeaderByStatus(ByVal POStatus As String) As dsPOHeader.POheaderDataTable
        GetPOHeaderByStatus = New dsPOHeader.POheaderDataTable
        Dim Sqlcm As New SqlCommand("stp_GetPOHeaderByStatus", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@PoStatus", POStatus)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetPOHeaderByStatus)
        Catch ex As Exception
            Errors("GetPOHeaderByStatus")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Sub DeletePoHeader(ByVal PoHeaderUID As Integer)
        Dim Sqlcm As New SqlCommand("stp_DeletePoHeader", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@POheaderUID", PoHeaderUID)
        Try
            Sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("DeletePoheaderUID")
        Finally
            Sqlcn.Close()
        End Try
    End Sub
    Public Sub UpdatePOHeader(ByVal rwPOHeader As dsPOHeader.POheaderRow)
        Dim sqlcm As New SqlCommand("stp_UpdatePOHeader", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@CurrencyUID", rwPOHeader.CurrencyUID)
        With rwPOHeader
            sqlcm.Parameters.AddWithValue("@DeliveryTUID", .DeliveryTUID)
            sqlcm.Parameters.AddWithValue("@DeliveryUID", .DeliveryUID)
            sqlcm.Parameters.AddWithValue("@ShipTermsUID", .ShipTermsUID)
            sqlcm.Parameters.AddWithValue("@NetTermsUID", .NetTermsUID)
            sqlcm.Parameters.AddWithValue("@ActDeliveryDte", .ActDeliveryDte)
            sqlcm.Parameters.AddWithValue("@EstDeliveryDate", .EstDeliveryDate)
            sqlcm.Parameters.AddWithValue("@POStatus", .POStatus)
            sqlcm.Parameters.AddWithValue("@UserUID", .UserUID)
            sqlcm.Parameters.AddWithValue("@PODate", .PODate)
            sqlcm.Parameters.AddWithValue("@VendorUID", .VendorUID)
            sqlcm.Parameters.AddWithValue("@PONO", .PONO)
            sqlcm.Parameters.AddWithValue("POheaderUID", .POheaderUID)
            sqlcm.Parameters.AddWithValue("@FreightAmt", .FreightAmt)
            Try
                Sqlcn.Open()
                sqlcm.ExecuteNonQuery()
            Catch ex As Exception
                Errors("UpdatePoHeader")
            Finally
                Sqlcn.Close()
            End Try
        End With
    End Sub
    Public Function InsertPOHeader(ByVal rwPoHeader As dsPOHeader.POheaderRow) As Integer
        Dim sqlcm As New SqlCommand("stp_InsertPOHeader", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@CurrencyUID", rwPoHeader.CurrencyUID)
        With rwPoHeader
            sqlcm.Parameters.AddWithValue("@DeliveryTUID", .DeliveryTUID)
            sqlcm.Parameters.AddWithValue("@DeliveryUID", .DeliveryUID)
            sqlcm.Parameters.AddWithValue("@ShipTermsUID", .ShipTermsUID)
            sqlcm.Parameters.AddWithValue("@NetTermsUID", .NetTermsUID)
            sqlcm.Parameters.AddWithValue("@ActDeliveryDte", .ActDeliveryDte)
            sqlcm.Parameters.AddWithValue("@EstDeliveryDate", .EstDeliveryDate)
            sqlcm.Parameters.AddWithValue("@POStatus", .POStatus)
            sqlcm.Parameters.AddWithValue("@UserUID", .UserUID)
            sqlcm.Parameters.AddWithValue("@PODate", .PODate)
            sqlcm.Parameters.AddWithValue("@VendorUID", .VendorUID)
            sqlcm.Parameters.AddWithValue("@PONO", .PONO)
            sqlcm.Parameters.AddWithValue("POheaderUID", .POheaderUID)
            sqlcm.Parameters(12).Direction = ParameterDirection.Output
            sqlcm.Parameters.AddWithValue("@FreightAmt", .FreightAmt)
            Try
                Sqlcn.Open()
                sqlcm.ExecuteNonQuery()
                InsertPOHeader = sqlcm.Parameters(12).Value
            Catch ex As Exception
                Errors("insertPoHeader")
            Finally
                Sqlcn.Close()
            End Try
        End With
    End Function
    Public Function GetAllPOHeader() As dsPOHeader.POheaderDataTable

        GetAllPOHeader = New dsPOHeader.POheaderDataTable
        Dim Sqlcm As New SqlCommand("stp_GetAllPoHeader", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Try
            Sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(Sqlcm)
            sqlda.Fill(GetAllPOHeader)
        Catch ex As Exception
            Errors("GetAllPOHeader")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetpoheaderbyUID(ByVal PoHeaderUID As Integer) As dsPOHeader.POheaderRow
        Dim dtPoheader As New dsPOHeader.POheaderDataTable
        GetpoheaderbyUID = dtPoheader.NewPOheaderRow
        Dim sqlcm As New SqlCommand("stp_GetpoHeaderbyUID", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@PoheaderUID", PoHeaderUID)
        Try
            Sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(sqlcm)
            sqlda.Fill(dtPoheader)
            For Each GetpoheaderbyUID In dtPoheader
                Return GetpoheaderbyUID
                Exit For
            Next
        Catch ex As Exception
            Errors("GetPoheaderbyUID")
        Finally
            Sqlcn.Close()
        End Try
    End Function

    Public Function GetPurchaseOrderReport(ByVal POheaderUID As Integer) As DataTable
        GetPurchaseOrderReport = New DataTable
        Dim Sqlcm As New SqlCommand("stp_PurchaseOrderHDRrpt", sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@PoHeaderUID", POheaderUID)
        Try
            Sqlcn.Open()
            Dim da As New SqlDataAdapter(Sqlcm)
            da.Fill(GetPurchaseOrderReport)
        Catch ex As Exception
            Errors("GetPurchaseOrderReport")
        Finally
            Sqlcn.Close()
        End Try
    End Function
End Class
