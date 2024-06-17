Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Imports HT_Connection
Public Class bsItemGroup
    Inherits HT_Connection.Dataprovider
    Private sqlcn As New SqlConnection(GetConnection)
    Public Function GetAllITemGroups() As dsItemGroup.ItemGroupDataTable
        GetAllITemGroups = New dsItemGroup.ItemGroupDataTable
        Dim Sqlcm As New SqlCommand("stp_GetAllItemGroup", sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Try
            sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(Sqlcm)
            sqlda.Fill(GetAllITemGroups)
        Catch ex As Exception
            Errors("GetAllITemGroups")
        Finally
            sqlcn.Close()
        End Try
    End Function
    Public Function GetItemGroupByUID(ByVal ItemgrpUID As Integer) As dsItemGroup.ItemGroupRow
        Dim dtItemGrp As New dsItemGroup.ItemGroupDataTable
        GetItemGroupByUID = dtItemGrp.NewItemGroupRow
        Dim sqlcm As New SqlCommand("stp_GetITemGroupbyUID", sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@ItemGrpUID", ItemgrpUID)
        Try
            sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(sqlcm)
            sqlda.Fill(dtItemGrp)
            For Each GetItemGroupByUID In dtItemGrp
                Return GetItemGroupByUID
                Exit For
            Next
        Catch ex As Exception
            Errors("GetITemGroupbyUID")
        Finally
            sqlcn.Close()
        End Try
    End Function
    Public Function GetItemGroupbyItemType(ByVal ItemTypeUID As Integer) As dsItemGroup.ItemGroupDataTable
        GetItemGroupbyItemType = New dsItemGroup.ItemGroupDataTable
        Dim sqlcm As New SqlCommand("stp_GetITemGrpbyItemType", sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@ItemTypeUID", ItemTypeUID)
        Try
            sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(sqlcm)
            sqlda.Fill(GetItemGroupbyItemType)
        Catch ex As Exception
            Errors("GetItemGroupbyItemType")
        Finally
            sqlcn.Close()
        End Try
    End Function
    Public Function InsertItemGrp(ByVal rwItemGrp As dsItemGroup.ItemGroupRow) As Integer
        InsertItemGrp = 0
        Dim Sqlcm As New SqlCommand("stp_InsertItemGrp", sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@ItemGroup", rwItemGrp.ItemGroup)
        Sqlcm.Parameters.AddWithValue("@ItemGrpDesc", rwItemGrp.ItemGrpDesc)
        Sqlcm.Parameters.AddWithValue("@ItemTypeUID", rwItemGrp.ItemTypeUID)
        Sqlcm.Parameters.AddWithValue("@ItemGrpUID", 0)
        Sqlcm.Parameters(3).Direction = ParameterDirection.Output
        Try
            sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
            InsertItemGrp = Sqlcm.Parameters(3).Value
        Catch ex As Exception
            Errors("InsertItemGroup")
        Finally
            sqlcn.Close()
        End Try
    End Function
    Public Sub UpdateItemGrp(ByVal rwItemGrp As dsItemGroup.ItemGroupRow)
        Dim sqlcm As New SqlCommand("stp_UpdateItemGrp", sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@ItemGroup", rwItemGrp.ItemGroup)
        sqlcm.Parameters.AddWithValue("@ItemGrpDesc", rwItemGrp.ItemGrpDesc)
        sqlcm.Parameters.AddWithValue("@ItemTypeUID", rwItemGrp.ItemTypeUID)
        sqlcm.Parameters.AddWithValue("@ItemGrpUID", rwItemGrp.ItemGrpUID)
        Try
            sqlcn.Open()
            sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("UpdateItemGrp")
        Finally
            sqlcn.Close()
        End Try
    End Sub
End Class
