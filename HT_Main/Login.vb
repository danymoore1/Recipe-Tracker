Public Class Login

    
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        My.Settings.UserUID = 0
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim bs As New HT_Business.bsUserInfo
        My.Settings.UserUID = bs.VerifyUser(txtUserName.Text, txtPassword.Text)
        If My.Settings.UserUID = 0 Then
            MsgBox("Invalid UserName or Password")
            txtPassword.Text = ""
            txtUserName.Text = ""
        Else
            My.Settings.UserGroupUID = bs.GetUserGroup(My.Settings.UserUID)
            My.Settings.UserName = txtUserName.Text
            If My.Settings.UserGroupUID = 0 Then
                MsgBox("Your Account has not been completed, Please contact IT")
                My.Settings.UserUID = 0
                Me.Close()
            End If
            Me.Close()
        End If
    End Sub

    Private Sub Login_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class