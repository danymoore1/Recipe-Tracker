Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Imports HT_Connection.Dataprovider
Public Class bsUOMConversion
    Inherits HT_Connection.Dataprovider
    Private Sqlcn As New SqlConnection(GetConnection)
    Public Function GetUOMConversion(ByVal frmUOMUID As Integer, ByVal ToUOMUID As Integer) As Decimal
        GetUOMConversion = 0
        Dim sqlcm As New SqlCommand("stp_GetUOMConversion", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@frmUOMUID", frmUOMUID)
        sqlcm.Parameters.AddWithValue("@ToUOMUID", ToUOMUID)
        sqlcm.Parameters.AddWithValue("@Conversion", 0)
        sqlcm.Parameters(2).SqlDbType = SqlDbType.Decimal
        sqlcm.Parameters(2).Direction = ParameterDirection.Output
        Try
            Sqlcn.Open()
            sqlcm.ExecuteNonQuery()
            GetUOMConversion = sqlcm.Parameters(2).Value
        Catch ex As Exception
            Errors("GetUOMConversion")
        Finally
            Sqlcn.Close()
        End Try
    End Function
End Class
