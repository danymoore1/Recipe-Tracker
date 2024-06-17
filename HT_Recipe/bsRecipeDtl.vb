Imports System.Data
Imports Microsoft.Data.SqlClient
Imports HT_Connection.Dataprovider
Imports HT_Recipe.HT_Recipe
Public Class bsRecipeDtl
    Inherits HT_Connection.Dataprovider
    Private Sqlcn As New SqlConnection(GetConnection)
    Public Function GetRecipeDtlItemno(ByVal RecipeHdrUID As Integer) As DataTable
        GetRecipeDtlItemno = New DataTable
        Dim Sqlcm As New SqlCommand("stp_GetRecipeDtlItemno", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@RecipeHdrUID", RecipeHdrUID)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetRecipeDtlItemno)
        Catch ex As Exception
            Errors("GetRecipeDtlItemNo")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetRecipeDtlbyHeaderUID(ByVal RecipeHdrUID As Integer) As dsRecipeDtl.RecipeDTLDataTable

        GetRecipeDtlbyHeaderUID = New dsRecipeDtl.RecipeDTLDataTable
        Dim Sqlcm As New SqlCommand("stp_GetRecipeDtlbyHeaderUID", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@RecipeHdrUID", RecipeHdrUID)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetRecipeDtlbyHeaderUID)
        Catch ex As Exception
            Errors("GetRecipedtlByHeaderUID")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetRecipeDtlbyUID(ByVal RecipeDtlUID As Integer) As dsRecipeDtl.RecipeDTLRow
        Dim dtRecipeDtl As New dsRecipeDtl.RecipeDTLDataTable
        GetRecipeDtlbyUID = dtRecipeDtl.NewRecipeDTLRow
        Dim sqlcm As New SqlCommand("stp_GetRecipeDtlbyUID", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@RecipedtlUID", RecipeDtlUID)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(sqlcm)
            Sqlda.Fill(dtRecipeDtl)
            For Each GetRecipeDtlbyUID In dtRecipeDtl
                Return GetRecipeDtlbyUID
                Exit For
            Next
        Catch ex As Exception
            Errors("GetRecipeDtlbyUID")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Sub DeleteRecipeDtl(ByVal RecipeDtlUID As Integer)
        Dim sqlcm As New SqlCommand("stp_DeleteRecipeDtl", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@RecipeDtlUID", RecipeDtlUID)
        Try
            Sqlcn.Open()
            sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("DeleteRecipeDtl")
        Finally
            Sqlcn.Close()
        End Try
    End Sub
    Public Sub UpdateRecipeDtl(ByVal rwRecipeDtl As dsRecipeDtl.RecipeDTLRow)
        Dim Sqlcm As New SqlCommand("stp_UpdateRecipeDtl", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@RecipeHdrUID", rwRecipeDtl.RecipeHDRUID)
        Sqlcm.Parameters.AddWithValue("@ItemUID", rwRecipeDtl.ItemUID)
        Sqlcm.Parameters.AddWithValue("@Qty", rwRecipeDtl.Qty)
        Sqlcm.Parameters.AddWithValue("@UOMUID", rwRecipeDtl.UOMUID)
        Sqlcm.Parameters.AddWithValue("@RecipeDtlUID", rwRecipeDtl.RecipeDTLUID)
        Try
            Sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("UpdateRecipeDtl")
        Finally
            Sqlcn.Close()
        End Try
    End Sub
    Public Function InsertRecipeDtl(ByVal rwRecipeDtl As dsRecipeDtl.RecipeDTLRow) As Integer
        Dim Sqlcm As New SqlCommand("stp_InsertRecipeDtl", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@RecipeHdrUID", rwRecipeDtl.RecipeHDRUID)
        Sqlcm.Parameters.AddWithValue("@ItemUID", rwRecipeDtl.ItemUID)
        Sqlcm.Parameters.AddWithValue("@Qty", rwRecipeDtl.Qty)
        Sqlcm.Parameters.AddWithValue("@UOMUID", rwRecipeDtl.UOMUID)
        Sqlcm.Parameters.AddWithValue("@RecipeDtlUID", rwRecipeDtl.RecipeDTLUID)
        Sqlcm.Parameters(4).Direction = ParameterDirection.Output
        Try
            Sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
            InsertRecipeDtl = Sqlcm.Parameters(4).Value
        Catch ex As Exception
            Errors("InsertRecipeDtl")
        Finally
            Sqlcn.Close()
        End Try
    End Function
End Class
