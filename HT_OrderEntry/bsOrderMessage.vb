Imports System.Data

Imports HT_Connection
Imports Microsoft.Data.SqlClient
Public Class bsOrderMessage
    Inherits Dataprovider
    Private sqlcn As New SqlConnection(GetConnection)
    Public Function GetOrderMessages(ByVal OrderHeaderUID As Integer) As dsOrderMessage.OrderMessageDataTable
        GetOrderMessages = New dsOrderMessage.OrderMessageDataTable
        Dim sqlcm As New SqlCommand("stp_GetOrderMessages", sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@OrderHeaderUID", OrderHeaderUID)
        Try
            sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(sqlcm)
            Sqlda.Fill(GetOrderMessages)
        Catch ex As Exception
            Errors("GetOrderMessages")
        Finally
            sqlcn.Close()
        End Try
    End Function
    Public Sub UpdateOrderMessage(ByVal rwOrderMes As dsOrderMessage.OrderMessageRow)
        Dim Sqlcm As New SqlCommand("stp_UpdateOrderMessage", sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        With rwOrderMes
            Sqlcm.Parameters.AddWithValue("MessageUID", .MessageUID)
            Sqlcm.Parameters.AddWithValue("@MessageNotes", .MessageNotes)
        End With
        Try
            sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("UpdateOrderMessage")
        Finally
            sqlcn.Close()
        End Try
    End Sub
    Public Function InsertOrderMessage(ByVal rwOrderMes As dsOrderMessage.OrderMessageRow) As Integer
        InsertOrderMessage = 0
        Dim sqlcm As New SqlCommand("stp_InsertOrderMessage", sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        With rwOrderMes
            sqlcm.Parameters.AddWithValue("@OrderNo", .OrderNo)
            sqlcm.Parameters.AddWithValue("@MessageNotes", .MessageNotes)
            sqlcm.Parameters.AddWithValue("@UserUID", .UserUID)
            sqlcm.Parameters.AddWithValue("@MessageUID", 0)
            sqlcm.Parameters(3).Direction = ParameterDirection.Output
            Try
                sqlcn.Open()
                sqlcm.ExecuteNonQuery()
                InsertOrderMessage = sqlcm.Parameters(3).Value
            Catch ex As Exception
                Errors("InsertOrderMessage")
            Finally
                sqlcn.Close()
            End Try
        End With
    End Function
    Public Sub DeleteOrderMessage(ByVal OrderMessageUID As Integer)
        Dim Sqlcm As New SqlCommand("stp_DeleteOrderMessage", sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@MessageUID", OrderMessageUID)
        Try
            sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("DeleteOrderMessage")
        Finally
            sqlcn.Close()
        End Try
    End Sub
End Class
