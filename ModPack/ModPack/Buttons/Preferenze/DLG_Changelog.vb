Public Class DLG_Changelog
    Private Sub DLG_Changelog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lb_Changelog.Text = My.Resources.ChangeLog
    End Sub
End Class