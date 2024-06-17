
Imports Microsoft.Data.SqlClient

Imports HT_Connection
Imports HT_PurchaseModule.HT_PurchaseModule
Public Class bsPODetail
    Inherits DataProvider
    Private Sqlcn As New SqlConnection(GetConnection)
    Public Sub DeletePODetail(ByVal POdetailUID As Integer)
        Dim sqlcm As New SqlCommand("stp_DeletePOdetail", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@POdetailUID", POdetailUID)
        Try
            Sqlcn.Open()
            sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("DeletePODetail")
        Finally
            Sqlcn.Close()
        End Try
    End Sub
    Public Function GetPodetailGrid(ByVal PoHeaderUID As Integer) As dsPODetail.POdetailDataTable

        GetPodetailGrid = New dsPODetail.POdetailDataTable
        Dim Sqlcm As New SqlCommand("stp_GetPoDetailgrid", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@PoHeaderUID", PoHeaderUID)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetPodetailGrid)
        Catch ex As Exception
            Errors("GetPoDetailGrid")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetPOdetailbyHeader(ByVal POheaderUID As Integer) As dsPODetail.POdetailDataTable
        GetPOdetailbyHeader = New dsPODetail.POdetailDataTable
        Dim sqlcm As New SqlCommand("stp_GetPOdetailbyHeader", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@PoheaderUID", POheaderUID)
        Try
            Sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(sqlcm)
            sqlda.Fill(GetPOdetailbyHeader)
        Catch ex As Exception
            Errors("GetPoDetailbyHeader")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Sub UpdatePodetail(ByVal rwPodetail As dsPODetail.POdetailRow)
        Dim sqlcm As New SqlCommand("stp_UpdatePOdetail", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@ItemUID", rwPodetail.ItemUID)
        With rwPodetail
            sqlcm.Parameters.AddWithValue("@Qty", .Qty)
            sqlcm.Parameters.AddWithValue("@Lotno", .Lotno)
            sqlcm.Parameters.AddWithValue("@lstReceiveDte", .lstReceiveDte)
            sqlcm.Parameters.AddWithValue("@ReceivedQty", .ReceivedQty)
            sqlcm.Parameters.AddWithValue("@UserUID", .UserUID)
            sqlcm.Parameters.AddWithValue("@PoHeaderUID", .POHeaderUID)
            sqlcm.Parameters.AddWithValue("@Price", .Price)
            sqlcm.Parameters.AddWithValue("@POdetailUID", .POdetailUID)
            Try
                Sqlcn.Open()
                sqlcm.ExecuteNonQuery()
            Catch ex As Exception
                Errors("UpdatePodetail")
            Finally
                Sqlcn.Close()
            End Try
        End With
    End Sub
    Public Function GetPOdetailOrdered(ByVal PoheaderUID As Integer) As DataTable
        GetPOdetailOrdered = New DataTable
        Dim sql As String = "stp_GetPOdetailOrdered " & PoheaderUID
        Dim sqlcn As New SqlConnection(GetConnection)
        Dim sqlcm As New SqlCommand(sql, sqlcn)
        Try
            sqlcn.Open()
            Dim da As New SqlDataAdapter(sqlcm)
            da.Fill(GetPOdetailOrdered)
            sqlcn.Close()
        Catch ex As Exception
            sqlcn.Close()
            Errors("GetPodetailOrdered")
        End Try
    End Function
    Public Function ReceivePOdetail(ByVal podetailUID As Integer, ByVal Lotno As String, ByVal QTy As Decimal, ByVal UserUID As Integer) As Integer
        ReceivePOdetail = 0
        'Here we must retrieve ItemUID and insert record into the ItemMasterInvent
        Dim Sql As String = "[stp_receivePOdetail] " & podetailUID & ",'" & Lotno & "'," & QTy & "," & UserUID
        Dim SQlcn As New SqlConnection(GetConnection)
        Dim Sqlcm As New SqlCommand(Sql, SQlcn)
        Try
            SQlcn.Open()
            Sqlcm.ExecuteNonQuery()
            SQlcn.Close()
            ReceivePOdetail = 1
            'UpdatePOdetailReceived(podetailUID, QTy, Lotno)
        Catch ex As Exception
            SQlcn.Close()
            Errors("ReceivePodetail")
            ReceivePOdetail = 0
        End Try
    End Function
    Public Sub UpdatePOdetailReceived(ByVal PodetailUID As Integer, ByVal Qty As Decimal, ByVal lotno As String)
        Dim Sql As String = "stp_UpdatePOdetailQty " & PodetailUID & "," & Qty & ",'" & lotno & "'"
        Dim sqlcn As New SqlConnection(GetConnection)
        Dim sqlcm As New SqlCommand(Sql, sqlcn)
        Try
            sqlcn.Open()
            sqlcm.ExecuteNonQuery()
            sqlcn.Close()
        Catch ex As Exception
            sqlcn.Close()
            Errors("UpdatePOdetailReceived")
        End Try
    End Sub
    Public Function InsertPodetail(ByVal rwPoDetail As dsPODetail.POdetailRow) As Integer
        InsertPodetail = 0
        Dim sqlcm As New SqlCommand("stp_InsertPOdetail", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@ItemUID", rwPoDetail.ItemUID)
        With rwPoDetail
            sqlcm.Parameters.AddWithValue("@Qty", .Qty)
            sqlcm.Parameters.AddWithValue("@Lotno", .Lotno)
            sqlcm.Parameters.AddWithValue("@lstReceiveDte", .lstReceiveDte)
            sqlcm.Parameters.AddWithValue("@ReceivedQty", .ReceivedQty)
            sqlcm.Parameters.AddWithValue("@UserUID", .UserUID)
            sqlcm.Parameters.AddWithValue("@PoHeaderUID", .POHeaderUID)
            sqlcm.Parameters.AddWithValue("@Price", .Price)
            sqlcm.Parameters.AddWithValue("@POdetailUID", .POdetailUID)
            sqlcm.Parameters(8).Direction = ParameterDirection.Output
            Try
                Sqlcn.Open()
                sqlcm.ExecuteNonQuery()
                InsertPodetail = sqlcm.Parameters(8).Value
            Catch ex As Exception
                Errors("UpdatePodetail")
            Finally
                Sqlcn.Close()
            End Try
        End With
    End Function
    Public Function GetrptPODetail(ByVal POheaderUID As Integer) As DataTable
        GetrptPODetail = New DataTable
        Dim Sqlcm As New SqlCommand("stp_rptPoDetail", sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@PoHeaderUID", POheaderUID)
        Try
            Sqlcn.Open()
            Dim da As New SqlDataAdapter(Sqlcm)
            da.Fill(GetrptPODetail)
        Catch ex As Exception
            Errors("GetRptPODetail")
        Finally
            Sqlcn.Close()
        End Try
    End Function

End Class
