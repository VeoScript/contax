Public Class Dashboard

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property

    Private Sub btnCollapseMenu_Click(sender As Object, e As EventArgs) Handles btnCollapseMenu.Click
        If pnlSideBar.Width = 45 Then
            'Expand the Sidebar
            pnlSideBar.Visible = False
            pnlSideBar.Width = 263
            BunifuTransition1.ShowSync(pnlSideBar)
        Else
            'Collapse the Sidebar
            pnlSideBar.Visible = False
            pnlSideBar.Width = 45
            BunifuTransition1.ShowSync(pnlSideBar)
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Hide()
        Login.Show()
    End Sub
End Class