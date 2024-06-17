Imports System.Data
Imports Microsoft.Data.SqlClient
Imports HT_Connection.Dataprovider
Imports HT_Recipe.HT_Recipe
Public Class bsRecipeHdr
    Inherits HT_Connection.Dataprovider
    Private sqlcn As New SqlConnection(GetConnection)
    Public Function GetAllRecipeHdr() As dsRecipeHdr.RecipeHdrDataTable

        GetAllRecipeHdr = New dsRecipeHdr.RecipeHdrDataTable
        Dim Sqlcm As New SqlCommand("stp_GetAllRecipeHdr", sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Try
            sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(Sqlcm)
            sqlda.Fill(GetAllRecipeHdr)
        Catch ex As Exception
            Errors("GetAllRecipeHdr")
        Finally
            sqlcn.Close()
        End Try
    End Function
    Public Function GetRecipeHdrbyHeaderUID(ByVal RecipeHdrUID As Integer) As dsRecipeHdr.RecipeHdrRow
        Dim dtRecipeHdr As New dsRecipeHdr.RecipeHdrDataTable
        GetRecipeHdrbyHeaderUID = dtRecipeHdr.NewRecipeHdrRow
        Dim Sqlcm As New SqlCommand("stp_GetRecipeHdrbyHeaderUID", sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@RecipeHdrUID", RecipeHdrUID)
        Try
            sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(dtRecipeHdr)
            For Each GetRecipeHdrbyHeaderUID In dtRecipeHdr
                Return GetRecipeHdrbyHeaderUID
                Exit For
            Next
        Catch ex As Exception
            Errors("GetRecipeHdrbyHeaderUID")
        Finally
            sqlcn.Close()
        End Try
    End Function
    Public Sub UpdateRecipeHdr(ByVal rwRecipeHdr As dsRecipeHdr.RecipeHdrRow)
        Dim Sqlcm As New SqlCommand("stp_UpdateRecipeHdr", sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@RecipeName", rwRecipeHdr.RecipeName)
        Sqlcm.Parameters.AddWithValue("@RecipeDesc", rwRecipeHdr.RecipeDesc)
        Sqlcm.Parameters.AddWithValue("@MaxAmt", rwRecipeHdr.MaxAmt)
        Sqlcm.Parameters.AddWithValue("@RecipeChef", rwRecipeHdr.RecipeChef)
        Sqlcm.Parameters.AddWithValue("@FinishedItemUID", rwRecipeHdr.FinishedItemUID)
        Sqlcm.Parameters.AddWithValue("@MinAmt", rwRecipeHdr.MinAmt)
        Sqlcm.Parameters.AddWithValue("@ShelfLifeDays", rwRecipeHdr.ShelfLifeDays)
        Sqlcm.Parameters.AddWithValue("RecipeHdrUID", rwRecipeHdr.RecipeHdrUID)
        Try
            sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("UpdateRecipeHdr")
        Finally
            sqlcn.Close()
        End Try
    End Sub
    Public Function InsertRecipeHdr(ByVal rwRecipeHdr As dsRecipeHdr.RecipeHdrRow) As Integer
        InsertRecipeHdr = 0
        Dim Sqlcm As New SqlCommand("stp_InsertRecipeHdr", sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@RecipeID", rwRecipeHdr.RecipeID)
        Sqlcm.Parameters.AddWithValue("@RecipeName", rwRecipeHdr.RecipeName)
        Sqlcm.Parameters.AddWithValue("@RecipeDesc", rwRecipeHdr.RecipeDesc)
        Sqlcm.Parameters.AddWithValue("@MaxAmt", rwRecipeHdr.MaxAmt)
        Sqlcm.Parameters.AddWithValue("@RecipeChef", rwRecipeHdr.RecipeChef)
        Sqlcm.Parameters.AddWithValue("@FinishedItemUID", rwRecipeHdr.FinishedItemUID)
        Sqlcm.Parameters.AddWithValue("@MinAmt", rwRecipeHdr.MinAmt)
        Sqlcm.Parameters.AddWithValue("@ShelfLifeDays", rwRecipeHdr.ShelfLifeDays)
        Sqlcm.Parameters.AddWithValue("RecipeHdrUID", 0)
        Sqlcm.Parameters(8).Direction = ParameterDirection.Output
        Try
            sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
            InsertRecipeHdr = Sqlcm.Parameters(8).Value
        Catch ex As Exception
            Errors("InsertRecipeHdr")
        Finally
            sqlcn.Close()
        End Try
    End Function
End Class
