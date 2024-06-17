Imports System.Data.SqlClient
Imports System.Data
Imports HT_Connection
Imports Microsoft.Data.SqlClient

Public Class bs_ReasonCodes
    Inherits Dataprovider
    Public Function GetAllReasonCodes() As dsReasonCodes.HT_ReasonCodesDataTable
        GetAllReasonCodes = New dsReasonCodes.HT_ReasonCodesDataTable
        Dim Sqlcn As New SqlConnection(GetConnection)
        Dim Sqlcm As New SqlCommand("stp_GetAllReasonCodes", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Try
            Sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(Sqlcm)
            sqlda.Fill(GetAllReasonCodes)
        Catch ex As Exception
            Errors("GetAllReasonCodes")
        Finally
            Sqlcn.Close()
        End Try
        Return GetAllReasonCodes
    End Function
    Public Function GetReasonCodebyUID(ByVal ReasonUID As Integer) As dsReasonCodes.HT_ReasonCodesRow
        Dim dtReasons As New dsReasonCodes.HT_ReasonCodesDataTable
        GetReasonCodebyUID = dtReasons.NewHT_ReasonCodesRow
        Dim Sqlcn As New SqlConnection(GetConnection)
        Dim Sqlcm As New SqlCommand("stp_GetReasonCodebyUID", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@ReasonUID", ReasonUID)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(dtReasons)
        Catch ex As Exception
            Errors("GetReasonCodeByUID")
        Finally
            Sqlcn.Close()
        End Try
    End Function
End Class
