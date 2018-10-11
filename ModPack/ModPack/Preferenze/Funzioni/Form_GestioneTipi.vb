Public Class Form_GestioneTipi
    Private Sub Form_GestioneTipi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'ModPackDBDataSet.Tipi'. È possibile spostarla o rimuoverla se necessario.
        Me.TipiTableAdapter.Fill(Me.ModPackDBDataSet.Tipi)

    End Sub

    Private Sub Bt_Salva_Click(sender As Object, e As EventArgs) Handles Bt_Salva.Click
        If MsgBox("Salvare le modifiche?", vbYesNo, "Salva") = MsgBoxResult.Yes Then
            TipiTableAdapter.Update(ModPackDBDataSet.Tipi)
            MsgBox("Modifiche salvate", vbInformation, "Salva")
        End If

    End Sub
End Class