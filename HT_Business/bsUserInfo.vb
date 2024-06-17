Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports HT_Connection
Public Class bsUserInfo
    Inherits Dataprovider
    Private Sqlcn As New SqlConnection(GetConnection)
    Public Function GetUserGroup(ByVal UserUID As Integer) As Integer
        GetUserGroup = 0
        Dim sql As String = "stp_GetUsergroup " & UserUID
        Dim sqlcn As New SqlConnection(GetConnection)
        Dim sqlcm As New SqlCommand(sql, sqlcn)
        Try
            sqlcn.Open()
            Dim sqldr As SqlDataReader
            sqldr = sqlcm.ExecuteReader
            While sqldr.Read
                GetUserGroup = sqldr.GetInt32(0)
            End While
            sqlcn.Close()
        Catch ex As Exception
            sqlcn.Close()
            Errors("GetUserGroup")
        End Try
    End Function
    Public Function VerifyUser(ByVal UserName As String, ByVal Pswd As String) As Integer
        VerifyUser = 0
        Dim Sql As String = "stp_VerifyUser '" & UserName & "','" & Pswd & "'"
        Dim sqlcn As New SqlConnection(GetConnection)
        Dim sqlcm As New SqlCommand(Sql, sqlcn)
        Try
            sqlcn.Open()
            Dim sqldr As SqlDataReader
            sqldr = sqlcm.ExecuteReader
            While sqldr.Read
                VerifyUser = sqldr.GetInt32(0)
            End While
            sqlcn.Close()
        Catch ex As Exception
            sqlcn.Close()
            Errors("VerifyUser")
        End Try
    End Function
End Class
