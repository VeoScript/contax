Public Class CreateAccount

    Private Sub linkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLogin.LinkClicked
        Login.BunifuTransition1.HideSync(Login.CreateAccount1)
        Login.pnlLogin.Visible = True
        Login.ClearAll()
    End Sub
End Class
