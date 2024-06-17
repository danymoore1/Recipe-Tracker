Imports Microsoft.Data.SqlClient
Imports HT_Connection
Public Class bsOrderShip
    Inherits Dataprovider
    Private Sqlcn As New SqlConnection(GetConnection)
    Public Function InsertOrderShip(ByVal rwOrderShip As dsOrderShip.OrderShipRow) As Integer
        InsertOrderShip = 0
        Dim Sqlcm As New SqlCommand("stp_InsertOrderShip", Sqlcn)
        Sqlcm.CommandType = CommandType.StoredProcedure
        With rwOrderShip
            Sqlcm.Parameters.AddWithValue("@OrderHeaderUID", .OrderHeaderUID)
            Sqlcm.Parameters.AddWithValue("@InventUID", .InventUID)
            Sqlcm.Parameters.AddWithValue("@Qty", .Qty)
            Sqlcm.Parameters.AddWithValue("@ShipUID", 0)
            Sqlcm.Parameters(3).Direction = ParameterDirection.Output
        End With
        Try
            Sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
            InsertOrderShip = Sqlcm.Parameters(3).Value
        Catch ex As Exception
            Errors("InsertOrderShip")
        Finally
            Sqlcn.Close()
        End Try
    End Function
End Class
