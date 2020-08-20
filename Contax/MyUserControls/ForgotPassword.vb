Public Class ForgotPassword

    Private Sub linkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLogin.LinkClicked
        Login.BunifuTransition1.HideSync(Login.ForgotPassword1)
        Login.pnlLogin.Visible = True
        Login.ClearAll()
    End Sub
End Class
