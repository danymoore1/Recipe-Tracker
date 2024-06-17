Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Imports HT_Connection
Public Class bsRun
    Inherits Dataprovider
    Private Sqlcn As New SqlConnection(GetConnection)
    Public Function GetRunbyRunUID(ByVal RunUID As Integer) As dsRun.RunRow
        Dim dtRun As New dsRun.RunDataTable
        GetRunbyRunUID = dtRun.NewRunRow
        Dim Sqlcm As New SqlCommand("stp_GetRunByRunUID", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@RunUID", RunUID)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(dtRun)
            For Each GetRunbyRunUID In dtRun
                Return GetRunbyRunUID
                Exit For
            Next
        Catch ex As Exception
            Errors("GetRunbyRunUID")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function InsertRun(ByVal rwRun As dsRun.RunRow) As Integer
        InsertRun = 0
        Dim Sqlcm As New SqlCommand("stp_InsertRun", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        With rwRun
            Sqlcm.Parameters.AddWithValue("@Runno", .Runno)
            Sqlcm.Parameters.AddWithValue("@RecipeHdrUID", .RecipeHdrUID)
            Sqlcm.Parameters.AddWithValue("@Lotno", .Lotno)
            Sqlcm.Parameters.AddWithValue("@Qty", .Qty)
            Sqlcm.Parameters.AddWithValue("RunDate", .RunDate)
        End With
        Sqlcm.Parameters.AddWithValue("@RunUID", 0)
        Sqlcm.Parameters(5).Direction = ParameterDirection.Output
        Try
            Sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
            InsertRun = Sqlcm.Parameters(5).Value
        Catch ex As Exception
            Errors("InsertRun")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetRunbyDate(ByVal Dte As Date) As dsRun.RunDataTable
        GetRunbyDate = New dsRun.RunDataTable
        Dim Sqlcm As New SqlCommand("stp_GetrunByDte", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@Dte", Dte)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetRunbyDate)
        Catch ex As Exception
            Errors("GetrunbyDate")
        Finally
            Sqlcn.Close()
        End Try
    End Function
End Class
