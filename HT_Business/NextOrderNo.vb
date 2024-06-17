Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Imports HT_Connection.Dataprovider
Public Class NextOrderNo
    Inherits HT_Connection.Dataprovider
    Private Sqlcn As New SqlConnection(GetConnection)
    Public Function GetNextNum(ByVal NType As String) As Integer
        GetNextNum = 0
        Dim Sqlcm As New SqlCommand("stp_GetNextOrderNo", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@NextType", NType)
        Sqlcm.Parameters.AddWithValue("@NextOrderNo", 0)
        Sqlcm.Parameters(1).SqlDbType = SqlDbType.Int
        Sqlcm.Parameters(1).Direction = ParameterDirection.Output
        Try
            Sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
            GetNextNum = Sqlcm.Parameters(1).Value
        Catch ex As Exception
            Errors("GetNextNum with " & NType)
        Finally
            Sqlcn.Close()
        End Try
    End Function
End Class
