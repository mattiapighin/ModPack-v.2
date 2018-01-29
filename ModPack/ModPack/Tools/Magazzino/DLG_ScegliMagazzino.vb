Imports System.Windows.Forms

Public Class DLG_ScegliMagazzino

    Public Function Valore() As String
        If Dgw_Magazzini.SelectedRows.Count > 0 Then
            Return Dgw_Magazzini.CurrentRow.Cells(1).Value
        Else
            Return ""
        End If
    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Me.DialogResult = DialogResult.OK
            Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DLG_ScegliMagazzino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'ModPackDBDataSet.Magazzini'. È possibile spostarla o rimuoverla se necessario.
        Me.MagazziniTableAdapter.Fill(Me.ModPackDBDataSet.Magazzini)

    End Sub
End Class
