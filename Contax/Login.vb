Public Class Login

    Private Sub linkCreateAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkCreateAccount.LinkClicked
        If CreateAccount1.Visible = False Then
            pnlLogin.Visible = False
            BunifuTransition1.ShowSync(CreateAccount1)
            ClearAll()
        End If
    End Sub

    Private Sub linkForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkForgotPassword.LinkClicked
        If ForgotPassword1.Visible = False Then
            pnlLogin.Visible = False
            BunifuTransition1.ShowSync(ForgotPassword1)
            ClearAll()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ClearAll()
        Dashboard.Show()
        Hide()
    End Sub

    Public Sub ClearAll()
        'Login Form Controls
        txtUsername.Text = ""
        txtPassword.Text = ""
        'Create Account User Control Controls
        CreateAccount1.txtName.Text = ""
        CreateAccount1.txtPhone.Text = ""
        CreateAccount1.txtEmail.Text = ""
        CreateAccount1.txtUsername.Text = ""
        CreateAccount1.txtPassword.Text = ""
        CreateAccount1.txtRePassword.Text = ""
        'Forgot Password User Control Contrls
        ForgotPassword1.txtUsername.Text = ""
        ForgotPassword1.txtEmail.Text = ""
    End Sub
End Class
