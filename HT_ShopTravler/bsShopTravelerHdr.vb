Imports System.Data
Imports Microsoft.Data.SqlClient
Imports HT_Connection.Dataprovider
Public Class bsShopTravelerHdr
    Inherits HT_Connection.Dataprovider
    Private Sqlcn As New SqlConnection(GetConnection)
    ''' <summary>
    ''' Gets Shop Traveler Header Record by UID
    ''' </summary>
    ''' <param name="TravelerUID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetShopTrvlrHdrByTrvlrUID(ByVal TravelerUID As Integer) As dsShopTrvlrHdr.ShopTravelerRow
        Dim dt As New dsShopTrvlrHdr.ShopTravelerDataTable
        GetShopTrvlrHdrByTrvlrUID = dt.NewShopTravelerRow
        Dim Sqlcm As New SqlCommand("Stp_GetShopTrvlrHdrByTrvlrUID", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@TrvlrUID", TravelerUID)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(dt)
            For Each GetShopTrvlrHdrByTrvlrUID In dt
                Return GetShopTrvlrHdrByTrvlrUID
            Next
        Catch ex As Exception
            Errors("GetShopTrvlrHdrByTrvlrUID")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    ''' <summary>
    ''' Inserts a new record into the Shop Traveler HDR Table
    ''' </summary>
    ''' <param name="rwshophdr"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InsertShopTrvlrHdr(ByVal rwshophdr As dsShopTrvlrHdr.ShopTravelerRow) As Integer
        InsertShopTrvlrHdr = 0
        Dim sqlcm As New SqlCommand("stp_InsertShopTrvlrHdr", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@RecipeHdrUID", rwshophdr.RecipeHdrUID)
        sqlcm.Parameters.AddWithValue("@Qty", rwshophdr.Qty)
        sqlcm.Parameters.AddWithValue("@RunDte", rwshophdr.RunDte)
        sqlcm.Parameters.AddWithValue("CompleteDte", rwshophdr.CompleteDte)
        sqlcm.Parameters.AddWithValue("@CompletedQty", rwshophdr.CompletedQty)
        sqlcm.Parameters.AddWithValue("@WasteQty", 0)
        sqlcm.Parameters.AddWithValue("@UserUID", rwshophdr.UserUID)
        sqlcm.Parameters.AddWithValue("Printed", 0)
        sqlcm.Parameters.AddWithValue("@Lotno", rwshophdr.Lotno)
        sqlcm.Parameters.AddWithValue("TravelerNum", rwshophdr.Travelernum)
        sqlcm.Parameters.AddWithValue("@TravelerUID", 0)
        sqlcm.Parameters(10).Direction = ParameterDirection.Output
        Try
            Sqlcn.Open()
            sqlcm.ExecuteNonQuery()
            InsertShopTrvlrHdr = sqlcm.Parameters(10).Value
        Catch ex As Exception
            Errors("InsertShopTrvlrHdr")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Sub UpdateShopTrvlrHdr(ByVal rwshopHdr As dsShopTrvlrHdr.ShopTravelerRow)
        Dim sqlcm As New SqlCommand("stp_UpdateShopTrvlrHdr", Sqlcn)
        sqlcm.Parameters.AddWithValue("@TravelerNum", rwshopHdr.Travelernum)
        sqlcm.Parameters.AddWithValue("@RecipeHdrUID", rwshopHdr.RecipeHdrUID)
        sqlcm.Parameters.AddWithValue("@Qty", rwshopHdr.Qty)
        sqlcm.Parameters.AddWithValue("@RunDte", rwshopHdr.RunDte)
        sqlcm.Parameters.AddWithValue("@CompleteDte", rwshopHdr.CompleteDte)
        sqlcm.Parameters.AddWithValue("@CompletedQty", rwshopHdr.CompletedQty)
        sqlcm.Parameters.AddWithValue("@WasteQty", rwshopHdr.WasteQty)
        sqlcm.Parameters.AddWithValue("@UserUID", rwshopHdr.UserUID)
        sqlcm.Parameters.AddWithValue("@Printed", rwshopHdr.Printed)
        sqlcm.Parameters.AddWithValue("@Lotno", rwshopHdr.Lotno)
        sqlcm.Parameters.AddWithValue("@TravelerUID", rwshopHdr.TravelerUID)
        sqlcm.Parameters.AddWithValue("@Complete", rwshopHdr.Complete)
        Try
            Sqlcn.Open()
            sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("UpdateShopTrvlrHdr")
        Finally
            Sqlcn.Close()
        End Try
    End Sub
    Public Function GetAllShopTravelers() As dsShopTrvlrHdr.ShopTravelerDataTable
        GetAllShopTravelers = New dsShopTrvlrHdr.ShopTravelerDataTable
        Dim Sqlcm As New SqlCommand("stp_GetAllShopTravelers", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Try
            Sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(Sqlcm)
            sqlda.Fill(GetAllShopTravelers)
        Catch ex As Exception
            Errors("GetAllShopTravelers")
        Finally
            Sqlcn.Close()
        End Try
    End Function
End Class
