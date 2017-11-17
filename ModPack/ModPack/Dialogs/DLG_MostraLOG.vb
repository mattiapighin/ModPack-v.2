Imports System.Windows.Forms

Public Class DLG_MostraLOG


    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'ModPackDBDataSet.Log'. È possibile spostarla o rimuoverla se necessario.
        Me.LogTableAdapter.Fill(Me.ModPackDBDataSet.Log)
        LogBindingSource.Sort = "ID DESC"

    End Sub
End Class
