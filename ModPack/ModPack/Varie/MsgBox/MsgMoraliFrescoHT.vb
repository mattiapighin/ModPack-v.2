Imports System.Windows.Forms

Public Class MsgMoraliFrescoHT


    Private Sub Bt_ListaMoraliFresco_Click(sender As Object, e As EventArgs) Handles Bt_ListaMoraliFresco.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub Bt_ListaMoraliHT_Click(sender As Object, e As EventArgs) Handles Bt_ListaMoraliHT.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub Bt_DiagFresco_Click(sender As Object, e As EventArgs) 
        Me.DialogResult = System.Windows.Forms.DialogResult.Retry
        Me.Close()
    End Sub

    Private Sub Bt_DiagHt_Click(sender As Object, e As EventArgs) 
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


End Class
