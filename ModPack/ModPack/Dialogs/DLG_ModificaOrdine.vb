Imports System.ComponentModel

Public Class DLG_ModificaOrdine

    Dim Modificato As Boolean = False

    Private Sub Bt_CaricaOrdine_Click(sender As Object, e As EventArgs) Handles Bt_CaricaOrdine.Click
        Dim OpenFile As New OpenFileDialog With {.Filter = "Ordine Modine|*.txt", .Title = "Carica Ordine"}

        If OpenFile.ShowDialog = DialogResult.OK Then

            Tx_PathOrdine.Text = OpenFile.FileName

            MsgBox("ATTENZIONE: Le modifiche apportate non formattate correttamente potrebbero rendere l'ordine inutilizzabile")

            For Each Row As String In IO.File.ReadAllLines(OpenFile.FileName)

                Dim Riga() As String = Split(Row, ";")
                DG_Ordine.Rows.Add(Riga)
                DG_Ordine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            Next

            Bt_Salva.Enabled = True

        End If

    End Sub
    Private Sub Bt_Salva_Click(sender As Object, e As EventArgs) Handles Bt_Salva.Click

        'Crea una nuova lista di stringhe vuota
        Dim NuovoFile As New List(Of String)

        If MsgBox("Salvare le modifiche?", vbYesNo, "Salva") = MsgBoxResult.Yes Then

            PB_Avanzamento.Value = 0
            PB_Avanzamento.Maximum = DG_Ordine.RowCount - 1


            For Each Row As DataGridViewRow In DG_Ordine.Rows

                Try



                    'Se non è l'ultima riga
                    If Not Row.Index = DG_Ordine.RowCount - 1 Then

                        'Crea una riga vuota che andrà riempita con il contenuto della riga della DG
                        Dim Riga As String = ""

                        For Each Column As DataGridViewColumn In DG_Ordine.Columns

                            Riga += DG_Ordine.Rows(Row.Index).Cells(Column.Index).Value.ToString
                            Debug.WriteLine("Sto copiando Riga: " & Row.Index & " Col: " & Column.Index & " - " & DG_Ordine.Rows(Row.Index).Cells(Column.Index).Value.ToString)
                            If Not Column.Index = DG_Ordine.ColumnCount - 1 Then Riga += ";"


                        Next

                        PB_Avanzamento.Value += 1
                        NuovoFile.Add(Riga)

                    End If

                Catch ex As Exception
                    MsgBox("Errore durante la scrittura della riga " & Row.Index & vbCrLf & ex.Message)
                End Try

            Next

            '#### SALVATAGGIO DEL FILE MODIFICATO ####

            Dim SalvaFile As New SaveFileDialog With {.Filter = "File Ordine Modine|*.txt", .InitialDirectory = IO.Path.GetDirectoryName(Tx_PathOrdine.Text), .Title = "Salva", .FileName = IO.Path.GetFileName(Tx_PathOrdine.Text)}

            If SalvaFile.ShowDialog = DialogResult.OK Then

                Try
                    IO.File.WriteAllLines(SalvaFile.FileName, NuovoFile)
                    MsgBox("Modifiche Salvate!", vbInformation, "Salva")

                    Tx_PathOrdine.Text = ""
                    Bt_Salva.Enabled = False
                    DG_Ordine.Rows.Clear()

                Catch ex As Exception

                    MsgBox("Errore durante la scrittura del file" & vbCrLf & ex.Message, vbCritical, "Salva")

                End Try

            End If


        End If


    End Sub

    Private Sub DG_Ordine_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Ordine.CellEndEdit
        Modificato = True
    End Sub

    Private Sub DLG_ModificaOrdine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tx_PathOrdine.Text = ""
        Bt_Salva.Enabled = False
        DG_Ordine.Rows.Clear()
        Modificato = False
    End Sub

    Private Sub DLG_ModificaOrdine_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Modificato = True Then
            If MsgBox("Uscire senza salvare?", vbYesNo, "Esci") = MsgBoxResult.Yes Then
                Bt_Salva.Enabled = False
                Exit Sub
            Else
                e.Cancel = True
            End If
        End If
    End Sub

End Class