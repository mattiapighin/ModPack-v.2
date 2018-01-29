Public Class FRM_GestioneMagazzini
    Private Sub FRM_GestioneMagazzini_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'ModPackDBDataSet.Magazzini'. È possibile spostarla o rimuoverla se necessario.
        Me.MagazziniTableAdapter.Fill(Me.ModPackDBDataSet.Magazzini)

    End Sub

    Private Sub Bt_Salva_Click(sender As Object, e As EventArgs) Handles Bt_Salva.Click
        If MsgBox("Salvare le modifiche?", vbYesNo, "Salva") = MsgBoxResult.Yes Then
            MagazziniTableAdapter.Update(ModPackDBDataSet)
        End If
    End Sub
End Class