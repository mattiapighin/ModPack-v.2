Public Class Form_Agenda
    Private Sub Form_Agenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MemoTableAdapter.Fill(Me.ModPackDBDataSet.Memo)

    End Sub

    Private Sub Bt_Salva_Click(sender As Object, e As EventArgs) Handles Bt_Salva.Click
        If MsgBox("Salvare le modifiche apportate?", vbYesNo, "Salva") = MsgBoxResult.Yes Then
            MemoTableAdapter.Update(ModPackDBDataSet.Memo)
        End If
    End Sub

    Private Sub Bt_SvuotaMemo_Click(sender As Object, e As EventArgs) Handles Bt_SvuotaMemo.Click
        If MsgBox("Svuotare completamente l'agenda?", vbYesNo, "Svuota") = MsgBoxResult.Yes Then
            SQL.Query("TRUNCATE TABLE Memo")
            Me.MemoTableAdapter.Fill(Me.ModPackDBDataSet.Memo)
        End If
    End Sub
End Class