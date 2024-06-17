Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports HT_Connection
Public Class bsVendors
    Inherits HT_Connection.Dataprovider
    Private sqlcn As New SqlConnection(GetConnection)
    Public Function GetAllVendors() As dsVendor.VendorDataTable
        GetAllVendors = New dsVendor.VendorDataTable
        Dim sqlcm As New SqlCommand("stp_GetAllVendors", sqlcn)
        Try
            sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(sqlcm)
            sqlda.Fill(GetAllVendors)
        Catch ex As Exception
            Errors("GetAllVendors")
        Finally
            sqlcn.Close()
        End Try
    End Function
    Public Function GetVendorbyUID(ByVal VendorUID As Integer) As dsVendor.VendorRow
        Dim dtVendor As New dsVendor.VendorDataTable
        GetVendorbyUID = dtVendor.NewVendorRow
        Dim Sqlcm As New SqlCommand("stp_GetVendorbyUID", sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@VendorUID", VendorUID)
        Try
            sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(Sqlcm)
            sqlda.Fill(dtVendor)
            For Each GetVendorbyUID In dtVendor
                Return GetVendorbyUID
                Exit For
            Next
        Catch ex As Exception
            Errors("GetVendorByUID")
        Finally
            sqlcn.Close()
        End Try
    End Function
    Public Sub UpdateVendor(ByVal rwVendor As dsVendor.VendorRow)
        Dim sqlcm As New SqlCommand("stp_UpdateVendor", sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        With rwVendor
            sqlcm.Parameters.AddWithValue("@VendorCode", .VendorCode)
            sqlcm.Parameters.AddWithValue("@VendorName", .VendorName)
            sqlcm.Parameters.AddWithValue("@Addr1", .Addr1)
            sqlcm.Parameters.AddWithValue("@Addr2", .Addr2)
            sqlcm.Parameters.AddWithValue("@City", .City)
            sqlcm.Parameters.AddWithValue("@State", .State)
            sqlcm.Parameters.AddWithValue("@Zip", .Zip)
            sqlcm.Parameters.AddWithValue("@InActive", .InActive)
            sqlcm.Parameters.AddWithValue("@Phone", .Phone)
            sqlcm.Parameters.AddWithValue("@Fax", .Fax)
            sqlcm.Parameters.AddWithValue("@VendorUID", .VendorUID)
        End With
        Try
            sqlcn.Open()
            sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("UpdateVendor")
        Finally
            sqlcn.Close()
        End Try

    End Sub
    Public Function InsertVendor(ByVal rwVendor As dsVendor.VendorRow) As Integer
        InsertVendor = 0
        Dim Sqlcm As New SqlCommand("stp_InsertVendor", sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        With rwVendor
            sqlcm.Parameters.AddWithValue("@VendorCode", .VendorCode)
            sqlcm.Parameters.AddWithValue("@VendorName", .VendorName)
            sqlcm.Parameters.AddWithValue("@Addr1", .Addr1)
            sqlcm.Parameters.AddWithValue("@Addr2", .Addr2)
            sqlcm.Parameters.AddWithValue("@City", .City)
            sqlcm.Parameters.AddWithValue("@State", .State)
            sqlcm.Parameters.AddWithValue("@Zip", .Zip)
            sqlcm.Parameters.AddWithValue("@InActive", .InActive)
            Sqlcm.Parameters.AddWithValue("@Phone", .Phone)
            Sqlcm.Parameters.AddWithValue("@Fax", .Fax)
            Sqlcm.Parameters.AddWithValue("@VendorUID", .VendorUID)
            Sqlcm.Parameters(10).Direction = ParameterDirection.Output
        End With
        Try
            sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
            InsertVendor = Sqlcm.Parameters(10).Value
        Catch ex As Exception
            Errors("InsertVendor")
        Finally
            sqlcn.Close()
        End Try
    End Function
End Class
