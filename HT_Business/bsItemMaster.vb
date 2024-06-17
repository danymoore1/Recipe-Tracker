Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Imports HT_Connection.Dataprovider
Public Class bsItemMaster
    Inherits HT_Connection.Dataprovider
    Private Sqlcn As New SqlConnection(GetConnection)
    ''' <summary>
    ''' Gets All Items from the ItemMaster
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetAllItemMaster() As DsItemMaster.ItemMasterDataTable
        GetAllItemMaster = New DsItemMaster.ItemMasterDataTable
        Dim Sqlcm As New SqlCommand("stp_GetAllItemMaster", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetAllItemMaster)
        Catch ex As Exception
            Errors("GetAllItemMaster")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetCustomerPackCustUID(ByVal CustUID As Integer) As DsItemMaster.ItemMasterDataTable
        GetCustomerPackCustUID = New DsItemMaster.ItemMasterDataTable
        Dim Sqlcm As New SqlCommand("GetCustPackbyCustUID", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@CustUID", CustUID)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetCustomerPackCustUID)
        Catch ex As Exception
            Errors("GetCustomerPackCustUID")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetCustomerPackItems() As DsItemMaster.ItemMasterDataTable
        GetCustomerPackItems = New DsItemMaster.ItemMasterDataTable
        Dim Sqlcm As New SqlCommand("stp_GetCustomerPackItems", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetCustomerPackItems)
        Catch ex As Exception
            Errors("GetCustomerPackItems")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    ''' <summary>
    ''' Gets ItemMaster Record by ItemUID
    ''' </summary>
    ''' <param name="ItemUID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetItemMasterByItemUID(ByVal ItemUID As Integer) As DsItemMaster.ItemMasterRow
        Dim dtItemMaster As New DsItemMaster.ItemMasterDataTable
        GetItemMasterByItemUID = dtItemMaster.NewItemMasterRow
        Dim Sqlcm As New SqlCommand("stp_GetItemMasterItemUID", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@ItemUID", ItemUID)
        Try
            Sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(Sqlcm)
            sqlda.Fill(dtItemMaster)
            For Each GetItemMasterByItemUID In dtItemMaster
                Return GetItemMasterByItemUID
                Exit For
            Next
        Catch ex As Exception
            Errors("GetITemMasterItemUID")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetItemsByITemType(ByVal ItemType As String) As DsItemMaster.ItemMasterDataTable
        GetItemsByITemType = New DsItemMaster.ItemMasterDataTable
        Dim sqlcm As New SqlCommand("stp_GetItemsByItemType", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@ItemType", ItemType)
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(sqlcm)
            Sqlda.Fill(GetItemsByITemType)
        Catch ex As Exception
            Errors("GetITemsByItemType")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetItemsbyItemTypeUID(ByVal ItemTypeUID As Integer) As DsItemMaster.ItemMasterDataTable
        GetItemsbyItemTypeUID = New DsItemMaster.ItemMasterDataTable
        Dim Sqlcm As New SqlCommand("stp_GetItemsByItemTypeUID", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@ItemTypeUID", ItemTypeUID)
        Try
            Sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(Sqlcm)
            sqlda.Fill(GetItemsbyItemTypeUID)
        Catch ex As Exception
            Errors("GetItemsbyItemTypeUID")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Sub UpdateItemMaster(ByVal rwItem As DsItemMaster.ItemMasterRow)
        Dim sqlcm As New SqlCommand("stp_UpdateItemMaster", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        With rwItem
            sqlcm.Parameters.AddWithValue("@ItemNo", .ItemNo)
            sqlcm.Parameters.AddWithValue("@ItemDesc", .ItemDesc)
            sqlcm.Parameters.AddWithValue("@ItemTypeUID", .ItemTypeUID)
            sqlcm.Parameters.AddWithValue("@ItemGrpUID", .ItemGrpUID)
            sqlcm.Parameters.AddWithValue("@lstPhDate", .lstPhDate)
            sqlcm.Parameters.AddWithValue("@LeadDays", .LeadDays)
            sqlcm.Parameters.AddWithValue("@SafetyNetAmt", .SafetyNetAmt)
            sqlcm.Parameters.AddWithValue("@UOMUID", .UOMUID)
            sqlcm.Parameters.AddWithValue("@DefaultVendorUID", .DefaultVendorUID)
            sqlcm.Parameters.AddWithValue("@Price", .Price)
            sqlcm.Parameters.AddWithValue("@ItemUID", .ItemUID)
            Try
                Sqlcn.Open()
                sqlcm.ExecuteNonQuery()
            Catch ex As Exception
                Errors("UpdateItemMaster")
            Finally
                Sqlcn.Close()
            End Try
        End With
    End Sub
    Public Function InsertItemMaster(ByVal rwItem As DsItemMaster.ItemMasterRow) As Integer
        Dim sqlcm As New SqlCommand("stp_InsertItemMaster", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        With rwItem
            sqlcm.Parameters.AddWithValue("@ItemNo", .ItemNo)
            sqlcm.Parameters.AddWithValue("@ItemDesc", .ItemDesc)
            sqlcm.Parameters.AddWithValue("@ItemTypeUID", .ItemTypeUID)
            sqlcm.Parameters.AddWithValue("@ItemGrpUID", .ItemGrpUID)
            sqlcm.Parameters.AddWithValue("@lstPhDate", .lstPhDate)
            sqlcm.Parameters.AddWithValue("@LeadDays", .LeadDays)
            sqlcm.Parameters.AddWithValue("@SafetyNetAmt", .SafetyNetAmt)
            sqlcm.Parameters.AddWithValue("@UOMUID", .UOMUID)
            sqlcm.Parameters.AddWithValue("@DefaultVendorUID", .DefaultVendorUID)
            sqlcm.Parameters.AddWithValue("@Price", .Price)
            sqlcm.Parameters.AddWithValue("@ItemUID", .ItemUID)
            sqlcm.Parameters(10).Direction = ParameterDirection.Output
            Try
                Sqlcn.Open()
                sqlcm.ExecuteNonQuery()
                InsertItemMaster = sqlcm.Parameters(10).Value
            Catch ex As Exception
                Errors("InsertItemMaster")
            Finally
                Sqlcn.Close()
            End Try
        End With
    End Function
    Public Function GetItemDesc(ByVal ITemno As String) As String
        GetItemDesc = ""
        Dim Sqlcm As New SqlCommand("stp_GetItemDesc", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@Itemno", ITemno)
        Try
            Sqlcn.Open()
            Dim Sqldr As SqlDataReader
            Sqldr = Sqlcm.ExecuteReader()
            While Sqldr.Read
                GetItemDesc = Sqldr.GetString(0)
            End While
        Catch ex As Exception
            Errors("GetITemDesc")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetItemGrid() As DsItemMaster.ItemGridDataTable
        GetItemGrid = New DsItemMaster.ItemGridDataTable
        Dim Sqlcm As New SqlCommand("stp_GetItemGrid", sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Try
            Sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(Sqlcm)
            sqlda.Fill(GetItemGrid)
        Catch ex As Exception
            Errors("GetItemGrid")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetInventoryTrays() As DsItemMaster.ItemMasterDataTable
        GetInventoryTrays = New DsItemMaster.ItemMasterDataTable
        Dim Sqlcm As New SqlCommand("stp_GetInventoryTrays", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetInventoryTrays)
        Catch ex As Exception
            Errors("GetInventoryTrays")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Function GetAllCTTrays() As DsItemMaster.ItemMasterDataTable
        GetAllCTTrays = New DsItemMaster.ItemMasterDataTable
        Dim Sqlcm As New SqlCommand("stp_GetAllCTTray", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Try
            Sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetAllCTTrays)
        Catch ex As Exception
            Errors("GetAllCTTrays")
        Finally
            Sqlcn.Close()
        End Try
    End Function
End Class
