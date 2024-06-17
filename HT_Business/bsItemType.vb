Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Data.SqlClient

Imports HT_Connection
Public Class bsItemType
    Inherits HT_Connection.Dataprovider
    Private sqlcn As New SqlConnection(GetConnection)
    Public Function GetAllItemTypes() As dsItemType.ItemTypeDataTable
        GetAllItemTypes = New dsItemType.ItemTypeDataTable
        Dim sqlcm As New SqlCommand("stp_GetAllItemTypes", sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        Try
            sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(sqlcm)
            sqlda.Fill(GetAllItemTypes)
        Catch ex As Exception
            Errors("GetAllItemTypes")
        Finally
            sqlcn.Close()
        End Try
    End Function
    Public Function GetItemType(ByVal ITemTypeUID As Integer) As dsItemType.ItemTypeRow
        Dim dtItemType As New dsItemType.ItemTypeDataTable
        GetItemType = dtItemType.NewItemTypeRow
        Dim Sqlcm As New SqlCommand("stp_GetItemType", sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@ItemTypeUID", ITemTypeUID)
        Try
            sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(dtItemType)
            For Each GetItemType In dtItemType
                Return GetItemType
                Exit For
            Next
        Catch ex As Exception
            Errors("GetItemType")
        Finally
            sqlcn.Close()
        End Try
    End Function
    Public Function InsertItemType(ByVal rwItemType As dsItemType.ItemTypeRow) As Integer
        InsertItemType = 0
        Dim Sqlcm As New SqlCommand("stp_InsertItemType", sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        With rwItemType
            Sqlcm.Parameters.AddWithValue("@ItemType", .ItemType)
            Sqlcm.Parameters.AddWithValue("@ItemTypeDesc", .ItemTypeDesc)
            Sqlcm.Parameters.AddWithValue("@ItemTypeUID", .ItemTypeUID)
            Sqlcm.Parameters(2).Direction = ParameterDirection.Output
        End With
        Try
            sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
            InsertItemType = Sqlcm.Parameters(2).Value
        Catch ex As Exception
            Errors("InsertItemType")
        Finally
            sqlcn.Close()
        End Try
    End Function
    Public Sub UpdateItemType(ByVal rwItemType As dsItemType.ItemTypeRow)
        Dim sqlcm As New SqlCommand("stp_UpdateItemType", sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        With rwItemType
            sqlcm.Parameters.AddWithValue("@ItemType", .ItemType)
            sqlcm.Parameters.AddWithValue("@ItemTypeDesc", .ItemTypeDesc)
            sqlcm.Parameters.AddWithValue("@ItemTypeUID", .ItemTypeUID)
        End With
        Try
            sqlcn.Open()
            sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("UpdateItemType")
        Finally
            sqlcn.Close()
        End Try
    End Sub
End Class
