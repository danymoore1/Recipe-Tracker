Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Imports HT_Connection
Public Class bsTerms
    Inherits HT_Connection.Dataprovider
    Private Sqlcn As New SqlConnection(GetConnection)
    Public Function GetAllShipTerms() As dsTerms.ShipTermsDataTable
        GetAllShipTerms = New dsTerms.ShipTermsDataTable
        Dim sqlcm As New SqlCommand("stp_GetAllShipTerms", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        Try
            Sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(sqlcm)
            sqlda.Fill(GetAllShipTerms)
        Catch ex As Exception
            Errors("GetAllShipTerms")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetAllNetTerms() As dsTerms.NetTermsDataTable
        GetAllNetTerms = New dsTerms.NetTermsDataTable
        Dim sqlcm As New SqlCommand("stp_GetAllNetTerms", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        Try
            Sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(sqlcm)
            sqlda.Fill(GetAllNetTerms)
        Catch ex As Exception
            Errors("GetAllNetTerms")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetNetTermbyUID(ByVal NetTermUID As Integer) As dsTerms.NetTermsRow
        Dim dtTerms As New dsTerms.NetTermsDataTable
        GetNetTermbyUID = dtTerms.NewNetTermsRow
        Dim sqlcm As New SqlCommand("stp_GetNetTermbyUID", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@NetTermsUID", NetTermUID)
        Try
            Sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(sqlcm)
            sqlda.Fill(dtTerms)
            For Each GetNetTermbyUID In dtTerms
                Return GetNetTermbyUID
                Exit For
            Next
        Catch ex As Exception
            Errors("GetNetTermbyUID")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetShipTermbyUID(ByVal ShipTermUID As Integer) As dsTerms.ShipTermsRow
        Dim dtShipTerm As New dsTerms.ShipTermsDataTable
        GetShipTermbyUID = dtShipTerm.NewShipTermsRow
        Dim sqlcm As New SqlCommand("stp_GetShipTermbyUID", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@ShipTermsUID", ShipTermUID)
        Try
            Sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(sqlcm)
            sqlda.Fill(dtShipTerm)
            For Each GetShipTermbyUID In dtShipTerm
                Return GetShipTermbyUID
                Exit For
            Next
        Catch ex As Exception
            Errors("GetShipTermbyUID")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Sub UpdateNetTerms(ByVal rwNetTerms As dsTerms.NetTermsRow)
        Dim Sqlcm As New SqlCommand("stp_UpdateNetTerms", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@NetTerms", rwNetTerms.NetTerms)
        Sqlcm.Parameters.AddWithValue("@NetTermsDesc", rwNetTerms.NetTermsDesc)
        Sqlcm.Parameters.AddWithValue("@NetTermsUID", rwNetTerms.NetTermsUID)
        Try
            Sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("UpdateNetTerms")
        Finally
            Sqlcn.Close()
        End Try
    End Sub
    Public Sub UpdateShipTerms(ByVal rwshipTerms As dsTerms.ShipTermsRow)
        Dim sqlcm As New SqlCommand("stp_UpdateShipTerms", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@ShipTerms", rwshipTerms.ShipTerms)
        sqlcm.Parameters.AddWithValue("@ShipTermDesc", rwshipTerms.ShipTermDesc)
        sqlcm.Parameters.AddWithValue("@ShipTermsUID", rwshipTerms.ShipTermsUID)
        Try
            Sqlcn.Open()
            sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("UpdateShipTerms")
        Finally
            Sqlcn.Close()
        End Try
    End Sub
    Public Function InsertNetTerms(ByVal rwNetTerms As dsTerms.NetTermsRow) As Integer
        InsertNetTerms = 0
        Dim sqlcm As New SqlCommand("stp_InsertNetTerms", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@NetTerms", rwNetTerms.NetTerms)
        sqlcm.Parameters.AddWithValue("@NetTermsDesc", rwNetTerms.NetTermsDesc)
        sqlcm.Parameters.AddWithValue("@NetTermsUID", 0)
        sqlcm.Parameters(2).Direction = ParameterDirection.Output
        Try
            Sqlcn.Open()
            sqlcm.ExecuteNonQuery()
            InsertNetTerms = sqlcm.Parameters(2).Value
        Catch ex As Exception
            Errors("InsertNetTerms")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function InsertShipTerms(ByVal rwShipTerms As dsTerms.ShipTermsRow) As Integer
        InsertShipTerms = 0
        Dim sqlcm As New SqlCommand("stp_InsertShipTerms", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@ShipTerms", rwShipTerms.ShipTerms)
        sqlcm.Parameters.AddWithValue("@ShipTermDesc", rwShipTerms.ShipTermDesc)
        sqlcm.Parameters.AddWithValue("@ShipTermsUID", 0)
        sqlcm.Parameters(2).Direction = ParameterDirection.Output
        Try
            Sqlcn.Open()
            sqlcm.ExecuteNonQuery()
            InsertShipTerms = sqlcm.Parameters(2).Value
        Catch ex As Exception
            Errors("InsertShipTerms")
        Finally
            Sqlcn.Close()
        End Try
    End Function
End Class
