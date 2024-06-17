Imports Microsoft.Data.SqlClient
Imports HT_Connection
Imports HT_PurchaseModule.HT_PurchaseModule
Public Class bsPONotes
    Inherits HT_Connection.DataProvider
    Private Sqlcn As New SqlConnection(GetConnection)
    Public Function GetPONotesbyHeader(ByVal PoheaderUID As Integer) As dsPoNotes.PONotesDataTable

        GetPONotesbyHeader = New dsPoNotes.PONotesDataTable
        Dim sqlcm As New SqlCommand("stp_GetPoNotesbyHeader", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@PoHeaderUID", PoheaderUID)
        Try
            Sqlcn.Open()
            Dim sqlda As New SqlDataAdapter(sqlcm)
            sqlda.Fill(GetPONotesbyHeader)
        Catch ex As Exception
            Errors("GetPoNotesbyHeader")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Sub UpdatePONote(ByVal rwPOnote As dsPoNotes.PONotesRow)
        Dim sqlcm As New SqlCommand("stp_UpdatePoNote", Sqlcn)
        sqlcm.CommandType = CommandType.StoredProcedure
        With rwPOnote
            sqlcm.Parameters.AddWithValue("@PoHeaderUID", .POheaderUID)
            sqlcm.Parameters.AddWithValue("@UserUID", .UserUID)
            sqlcm.Parameters.AddWithValue("@Ponotes", rwPOnote.PONotes)
            sqlcm.Parameters.AddWithValue("@PoMessageUID", rwPOnote.POMessageUID)
            Try
                Sqlcn.Open()
                sqlcm.ExecuteNonQuery()
            Catch ex As Exception
                Errors("UpdatePoNotes")
            Finally
                Sqlcn.Close()
            End Try
        End With
    End Sub
    Public Function InsertPoNotes(ByVal rwponote As dsPoNotes.PONotesRow) As Integer
        Dim sqlcm As New SqlCommand("stp_InsertPoNotes", Sqlcn)
        InsertPoNotes = 1
        sqlcm.CommandType = CommandType.StoredProcedure
        sqlcm.Parameters.AddWithValue("@POheaderUID", rwponote.POheaderUID)
        sqlcm.Parameters.AddWithValue("@UserUID", rwponote.UserUID)
        sqlcm.Parameters.AddWithValue("@Ponotes", rwponote.PONotes)
        sqlcm.Parameters.AddWithValue("@POMessageUID", 0)
        sqlcm.Parameters(3).Direction = ParameterDirection.Output
        Try
            Sqlcn.Open()
            sqlcm.ExecuteNonQuery()
            InsertPoNotes = sqlcm.Parameters(3).Value
        Catch ex As Exception
            Errors("InsertPoNotes")
        Finally
            Sqlcn.Close()
        End Try
    End Function
    Public Sub DeletePONote(ByVal POmessageUID As Integer)
        Dim Sqlcm As New SqlCommand("stp_DeletePONote")
        Sqlcm.CommandType = CommandType.StoredProcedure
        Sqlcm.Parameters.AddWithValue("@PoMessageUID", POmessageUID)
        Try
            Sqlcn.Open()
            Sqlcm.ExecuteNonQuery()
        Catch ex As Exception
            Errors("DeletePoNote")
        Finally
            Sqlcn.Close()
        End Try
    End Sub
End Class
