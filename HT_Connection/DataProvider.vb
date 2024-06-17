Public Class DataProvider
    Public Shared Function GetConnection() As String
        GetConnection = "Server = "
    End Function

    Public Shared Sub Errors(ByVal Procedure As String)
        MsgBox("There Was An Error While Processing Your Request Error: & " & Procedure & " Please Contact Support", MsgBoxStyle.MsgBoxHelp, "Hot Trak Issue")
    End Sub

End Class
