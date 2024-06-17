Imports System.Data
Imports Microsoft.Data.SqlClient
Imports HT_Connection
Public Class bsUnPack
    Inherits Dataprovider
    Private Sqlcn As New SqlConnection(GetConnection)
    Public Function InsertUnPack(ByVal rwUnpack As dsUnPack.UnpackRow) As Integer
        Dim Sqlcm As New SqlCommand("stp_InsertUnPack", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        With rwUnpack
            Sqlcm.Parameters.AddWithValue("@InventUID", .InventUID)
            Sqlcm.Parameters.AddWithValue("@Qty", .Qty)
            Sqlcm.Parameters.AddWithValue("@UserUID", .UserUID)
            Sqlcm.Parameters.AddWithValue("@RunUID", .RunUID)
            Sqlcm.Parameters.AddWithValue("@UnpackUID", 0)
            Sqlcm.Parameters(4).Direction = ParameterDirection.Output
        End With
        Try
            Sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
            InsertUnPack = Sqlcm.Parameters(4).Value
        Catch ex As Exception
            Errors("InsertUnPack")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetUnPackLotGrid(ByVal RunUID As Integer) As DataTable
        GetUnPackLotGrid = New DataTable
        Dim Sqlcm As New SqlCommand("stp_GetUnpackGrid", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@RunUID", RunUID)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetUnPackLotGrid)
        Catch ex As Exception
            Errors("GetUnPackLotGrid")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetUnpackLots(ByVal RunUID As Integer) As DataTable
        GetUnpackLots = New DataTable
        Dim Sqlcm As New SqlCommand("stp_GetUnpackLots", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@RunUID", RunUID)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetUnpackLots)
        Catch ex As Exception
            Errors("GetUnpackLots")
        End Try
    End Function
End Class
