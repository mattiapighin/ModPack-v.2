Public Class Form_PuliziaOrdini
    Private Sub BT_Ok_Click(sender As Object, e As EventArgs) Handles BT_Ok.Click
        Dim RigheDaEliminare() As ModPackDBDataSet.OrdiniRow

        Using TableOrdini As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
            Using DS As New ModPackDBDataSet.OrdiniDataTable
                TableOrdini.Fill(DS)

                RigheDaEliminare = DS.Where(Function(x) x.Data_Ordine <= DatePicker.Value.ToShortDateString).ToArray

                PB.Value = 0
                PB.Maximum = RigheDaEliminare.Count

                If MsgBox("Verranno eliminate " & RigheDaEliminare.Count & " righe di ordine. Continuare?", vbYesNo, "Pulizia ordini") = MsgBoxResult.Yes Then

                    Try
                        For Each Row As ModPackDBDataSet.OrdiniRow In RigheDaEliminare

                            TableOrdini.Delete(Row.Id, Row.Ordine, Row.Riga, Row.Imballo, Row.Indice, Row.Qt, Row.Cliente,
                                           Row.Codice, Row.Commessa, Row.L, Row.P, Row.H, Row.Tipo, Row.Zoccoli, Row.Rivestimento,
                                           Row.Tipo_Rivestimento, Row.Data_Consegna, Row.HT, Row.DT, Row.BM, Row.Magazzino, Row.Diagonali, Row.Stampato, Row.Produzione, Row.Evaso, Row.Data_Ordine)
                            PB.Value += 1
                        Next

                        MsgBox("Pulizia completata!", vbInformation, "Pulizia ordini")
                    Catch ex As Exception

                        MsgBox("Errore: " & ex.Message, MsgBoxStyle.Critical, "Pulizia ordini")

                    End Try

                    PB.Value = 0

                End If

            End Using
        End Using


    End Sub

    Private Sub Form_PuliziaOrdini_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class