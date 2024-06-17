Imports System.Data
Imports Microsoft.Data.SqlClient
Imports HT_Connection.DataProvider
Imports HT_Inventory.HT_Inventory


Public Class bsInvent
    Inherits HT_Connection.DataProvider
    Private sqlcn As New SqlConnection(GetConnection)

    Public _ItemNO As String
    Public _ItemQty As Integer
    Public _InventUID As Integer
    Public _OrderdetailUID As Integer
    Public _OrderheaderUID As Integer
    Public Sub New()
        _ItemNO = ""
        _ItemQty = 0
        _OrderdetailUID = 0
        _OrderheaderUID = 0

    End Sub
    Public Function GetRepackedInventory(ByVal RunUID As Integer) As DataTable
        GetRepackedInventory = New DataTable
        Dim Sqlcm As New SqlCommand("stp_GetRepackedInventorybyRun", sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@RunUID", RunUID)
        Try
            sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetRepackedInventory)
        Catch ex As Exception
            Errors("GetRepackedInventory")
        Finally
            sqlcn.Close()
        End Try
    End Function
    Public Function GetAllInvent() As dsInventory.InventDataTable

        GetAllInvent = New dsInventory.InventDataTable
        Dim sqlcm As New SqlCommand("stp_GetAllInvent", sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        Try
            sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(sqlcm)
            sqlda.Fill(GetAllInvent)
        Catch ex As Exception
            Errors("GetAllInvent")
        Finally
            sqlcn.Close()
        End Try
    End Function
    Public Function GetInventByInventUID(ByVal InventUID As Integer) As dsInventory.InventRow
        Dim dt As New dsInventory.InventDataTable
        Dim rw As dsInventory.InventRow
        GetInventByInventUID = dt.NewInventRow
        Dim sqlcm As New SqlCommand("stp_GetInventByInventUID", sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@InventUID", InventUID)
        Try
            sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(sqlcm)
            sqlda.Fill(dt)
            For Each rw In dt.Rows
                Return rw
                Exit For
            Next
        Catch ex As Exception
            Errors("GetInventByInventUID")
        Finally
            sqlcn.Close()
        End Try
    End Function

    Public Function GetAllAvailInventory() As dsInventory.InventDataTable
        GetAllAvailInventory = New dsInventory.InventDataTable
        Dim sqlcm As New SqlCommand("stp_GetAllAvailInventory", sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        Try
            sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(sqlcm)
            sqlda.Fill(GetAllAvailInventory)
        Catch ex As Exception
            Errors("GetAllAvailInventory")
        Finally
            sqlcn.Close()
        End Try
    End Function
    Public Function GetAvailInventbyItemUID(ByVal ItemUID As Integer) As dsInventory.InventDataTable
        GetAvailInventbyItemUID = New dsInventory.InventDataTable
        'Dim rw As dsInventory.InventRow
        Dim sqlcm As New SqlCommand("stp_GetAvailInventbyItemUID", sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@ItemUID", ItemUID)
        Try
            sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(sqlcm)
            sqlda.Fill(GetAvailInventbyItemUID)
        Catch ex As Exception
            Errors("GetAvailInventbyItemUID")
        Finally
            sqlcn.Close()
        End Try
    End Function
    Public Function InsertInvent(ByVal rw As dsInventory.InventRow) As Integer
        Dim sqlcm As New SqlCommand("stp_InsertInvent", sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@ItemUID", rw.ItemUID)
        sqlcm.Parameters.AddWithValue("@Qty", rw.Qty)
        sqlcm.Parameters.AddWithValue("@UomUID", rw.UOMUID)
        sqlcm.Parameters.AddWithValue("@Lotno", rw.Lotno)
        sqlcm.Parameters.AddWithValue("@PodetailUID", rw.POdetailUID)
        sqlcm.Parameters.AddWithValue("@PackDate", rw.PackDate)
        sqlcm.Parameters.AddWithValue("TravelerUID", rw.TravelerUID)
        sqlcm.Parameters.AddWithValue("PalletTagno", rw.PalletTagno)
        sqlcm.Parameters.AddWithValue("UserUID", rw.UserUID)
        sqlcm.Parameters.AddWithValue("@RunUID", rw.RunUID)
        sqlcm.Parameters.AddWithValue("@InventUID", 0)
        sqlcm.Parameters(10).SqlDbType = SqlDbType.Int
        sqlcm.Parameters(10).Direction = ParameterDirection.Output
        Try
            sqlcn.Open()
            sqlcm.ExecuteNonQuery()
            InsertInvent = sqlcm.Parameters(10).Value
        Catch ex As Exception
            Errors("Insertinvent")
        Finally
            sqlcn.Close()
        End Try
    End Function
    Public Function GetInventByITemUIDLotno(ByVal ItemUID As Integer, ByVal Lotno As String) As dsInventory.InventRow
        Dim dtInvent As New dsInventory.InventDataTable
        Dim rw As dsInventory.InventRow
        rw = dtInvent.NewInventRow
        GetInventByITemUIDLotno = dtInvent.NewInventRow
        Dim SQlcm As New SqlCommand("stp_GetInventbyItemUIDLotno", sqlcn)
        SQlcm.Parameters.AddWithValue("@ItemUID", ItemUID)
        SQlcm.Parameters.AddWithValue("@Lotno", Lotno)
        Try
            sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(SQlcm)
            sqlda.Fill(dtInvent)
            For Each rw In dtInvent
                Return rw
                Exit For
            Next
        Catch ex As Exception
            Errors("GetInventByItemUIDLotno")
        Finally
            sqlcn.Close()
        End Try
    End Function
    Public Sub DepleteShopIngred(ByVal TravelerUID As Integer)
        Dim sqlcm As New SqlCommand("stp_depleteShopIngred", sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@TravelerUID", TravelerUID)
        Try
            sqlcn.Open()
            sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("DepleteShopIngred")
        Finally
            sqlcn.Close()
        End Try
    End Sub
    Public Function CheckInventory(ByVal Lotno As String, ByVal ITemNo As String, ByVal qty As Integer) As bsInvent
        CheckInventory = New bsInvent
        Dim Sqlcm As New SqlCommand("stp_Checkinventory", sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@Lotno", Lotno)
        Sqlcm.Parameters.AddWithValue("@ItemNo", ITemNo)
        Dim sqldr As SqlDataReader
        Try
            sqlcn.Open()
            sqldr = sqlcm.ExecuteReader
            While sqldr.Read
                _ItemQty = sqldr.GetDecimal(0)
                _InventUID = sqldr.GetInt32(1)
            End While
        Catch ex As Exception
            Errors("CheckInventory")
        Finally
            sqlcn.Close()
        End Try
    End Function
    Public Sub UpdateShip(ByVal ShipUID As Integer)
        Dim Sqlcm As New SqlCommand("stp_UpdateShip", sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@ShipUID", ShipUID)
        Sqlcm.Parameters.AddWithValue("@inventUID", _InventUID)
        Sqlcm.Parameters.AddWithValue("@ItemQty", _ItemQty)
        Try
            sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("UpdateShip")
        Finally
            sqlcn.Close()
        End Try
    End Sub
    Public Function ShipItem(ByVal OrderHeaderUID As Integer, ByVal InventUID As Integer, ByVal ItemQty As Integer, ByVal OrderDetailUID As Integer) As Integer
        ShipItem = 0
        Dim Sqlcm As New SqlCommand("stp_InsertOrderShip", sqlcn)
        Sqlcm.Parameters.AddWithValue("@OrderHeaderUID", OrderHeaderUID)
        Sqlcm.Parameters.AddWithValue("@InventUID", InventUID)
        Sqlcm.Parameters.AddWithValue("@ItemQty", ItemQty)
        Sqlcm.Parameters.AddWithValue("@OrderDetailUID", OrderDetailUID)
        Try
            sqlcn.Open()
            Dim sqldr As SqlDataReader
            sqldr = Sqlcm.ExecuteReader
            While sqldr.Read
                ShipItem = sqldr.GetDecimal(0)
            End While
        Catch ex As Exception
            Errors("ShipItem")
        Finally
            sqlcn.Close()
        End Try
    End Function
    Public Function GetLowInventory() As DataTable
        GetLowInventory = New DataTable
        Dim Sqlcm As New SqlCommand("stp_GetLowInventory", sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Try
            sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetLowInventory)
        Catch ex As Exception
            Errors("GetLowInventory")
        Finally
            sqlcn.Close()
        End Try
    End Function
    Public Function GetInventory() As DataTable
        GetInventory = New DataTable
        Dim Sqlcm As New SqlCommand("stp_GetInventory", sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        Try
            sqlcn.Open()
            Dim Sqlda As New SqlDataAdapter(Sqlcm)
            Sqlda.Fill(GetInventory)
        Catch ex As Exception
            Errors("GetInventory")
        Finally
            sqlcn.Close()
        End Try
    End Function
End Class
