﻿Imports System.Windows.Forms

Public Class DLG_MostraLOG


    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NRighe = InputBox("Numero di righe da mostrare (0 = tutte):", "LOG", "0")

        If IsNumeric(NRighe) Then
            'TODO: questa riga di codice carica i dati nella tabella 'ModPackDBDataSet.Log'. È possibile spostarla o rimuoverla se necessario.
            Me.LogTableAdapter.Fill(Me.ModPackDBDataSet.Log)

            If NRighe > 0 Then Me.LogBindingSource.Filter = "ID > MAX(ID) - " & NRighe

            LogBindingSource.Sort = "ID DESC"

        Else
            Me.Close()
        End If




    End Sub
End Class
