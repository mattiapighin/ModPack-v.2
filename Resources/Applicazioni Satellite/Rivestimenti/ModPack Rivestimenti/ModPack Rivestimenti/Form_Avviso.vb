Public Class Form_Avviso
    Private Sub Bt_Chiudi_Click(sender As Object, e As EventArgs) Handles Bt_Chiudi.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub Form_Avviso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.ColoreAvviso
    End Sub
End Class