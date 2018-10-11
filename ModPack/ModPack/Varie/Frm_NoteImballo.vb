Public Class Frm_NoteImballo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not String.IsNullOrEmpty(Tx_Nota.Text) Then
            Try

                Using Table As New ModPackDBDataSetTableAdapters.NoteImballiTableAdapter
                    Using DS As New ModPackDBDataSet.NoteImballiDataTable

                        Table.Insert(Tx_Imballo.Text, Tx_Nota.Text)
                        Table.Update(DS)

                        MsgBox("Nota aggiunta!", vbInformation, "Aggiungi")
                        Tx_Nota.Text = ""

                        Me.Close()

                    End Using
                End Using

            Catch ex As Exception
                Errore.Show("Inserimento nota su " & Tx_Imballo.Text, ex.Message)
            End Try
        End If
    End Sub
End Class