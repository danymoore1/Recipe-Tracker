Imports System.Data.SqlClient
Imports System.Data
Imports HT_Connection.Dataprovider
Public Class bsUOM
    Inherits HT_Connection.Dataprovider
    Private SQlcn As New SqlConnection(GetConnection)
    Public Function GetAllUOM() As HT_Business.dsUOM.UOMDataTable
        GetAllUOM = New dsUOM.UOMDataTable
        Dim Sqlcm As New SqlCommand("stp_GetAllUOM", SQlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Try
            SQlcn.Open()
            Dim sqlda As New SqlDataAdapter(Sqlcm)
            sqlda.Fill(GetAllUOM)
        Catch ex As Exception
            Errors("GetAllUOM")
        Finally
            SQlcn.Close()
        End Try
    End Function

End Class
