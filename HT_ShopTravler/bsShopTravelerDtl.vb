Imports System.Data

Imports Microsoft.Data.SqlClient
Imports HT_Connection.Dataprovider


Public Class bsShopTravelerDtl
    Inherits HT_Connection.Dataprovider
    Private Sqlcn As New SqlConnection(GetConnection)
    Public Function GetShopTravelerGrid() As dsShopTrvlrDtl.shopTravelerDtlDataTable
        GetShopTravelerGrid = New dsShopTrvlrDtl.shopTravelerDtlDataTable
        Dim sqlcm As New SqlCommand("stpGetShopTravelerGrid", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        Try
            Sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(sqlcm)
            sqlda.Fill(GetShopTravelerGrid)
        Catch ex As Exception
            Errors("GetShopTravelerGrid")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetShopDtlGrid(ByVal TravelerUID As Integer) As DataTable
        GetShopDtlGrid = New DataTable
        Dim Sqlcm As New SqlCommand("stp_GetShopDtlGrid", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@TravelerUID", TravelerUID)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetShopDtlGrid)
        Catch ex As Exception
            Errors("GetShopDtlGrid")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function InsertShoptrvlrDtl(ByVal rwshopdtl As dsShopTrvlrDtl.shopTravelerDtlRow) As Integer
        Dim sqlcm As New SqlCommand("stp_InsertShoptrvlrDtl", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@Qty", rwshopdtl.Qty)
        sqlcm.Parameters.AddWithValue("@TravelerUID", rwshopdtl.TravelerUID)
        sqlcm.Parameters.AddWithValue("@InventUID", rwshopdtl.InventUID)
        sqlcm.Parameters.AddWithValue("@ItemUID", rwshopdtl.ItemUID)
        sqlcm.Parameters.AddWithValue("@ShopdtlUID", 0)
        sqlcm.Parameters(4).Direction = ParameterDirection.Output
        Try
            Sqlcn.Open()
            sqlcm.ExecuteNonQuery()
            InsertShoptrvlrDtl = sqlcm.Parameters(4).Value
        Catch ex As Exception
            Errors("InsertShopTrvlrDtl")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Sub DeleteShopTrvlrDTL(ByVal ShopdtlUID As Integer)
        Dim sqlcm As New SqlCommand("stp_DeleteShopTrvlr", Sqlcn)
        sqlcm.Parameters.AddWithValue("@ShopDtlUID", ShopdtlUID)
        Try
            Sqlcn.Open()
            sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("DeleteShopTrvlrDtl")
        Finally
            Sqlcn.Close()
        End Try
    End Sub
    Public Sub CreateShopTrays(ByVal TravelerUID As Integer, ByVal TrayCount As Integer, ByVal Dte As Date, ByVal UserUID As Integer)
        Dim Sqlcm As New SqlCommand("stp_CreateShopTrays", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@TravelerUID", TravelerUID)
        Sqlcm.Parameters.AddWithValue("@TrayCount", TrayCount)
        Sqlcm.Parameters.AddWithValue("@Dte", Dte)
        Sqlcm.Parameters.AddWithValue("@UserUID", userUID)
        Try
            Sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("CreateTrays")
        Finally
            Sqlcn.Close()
        End Try
    End Sub
End Class
