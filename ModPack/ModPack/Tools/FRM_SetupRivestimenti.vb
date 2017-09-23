Public Class FRM_SetupRivestimenti

    Dim DS As New ModPackDBDataSet.Setup_RivestDataTable
    Dim TIPO As String

    Dim VecchiaRiga As ModPackDBDataSet.Setup_RivestRow

    Private Sub Clear()
        TX_BX.Text = ""
        TX_BY.Text = ""
        TX_CX.Text = ""
        TX_CY.Text = ""
        TX_FX.Text = ""
        TX_FY.Text = ""
        TX_TX.Text = ""
        TX_TY.Text = ""
        TX_Note.Text = ""
    End Sub
    Private Sub Rinfresca()
        Clear()

        Using TA As New ModPackDBDataSetTableAdapters.Setup_RivestTableAdapter
            TA.Fill(DS)
        End Using

        If DGW_Tipi.SelectedRows.Count > 0 Then

            TIPO = DGW_Tipi.Rows(DGW_Tipi.CurrentRow.Index).Cells(0).Value

            For Each ROW As ModPackDBDataSet.Setup_RivestRow In DS.Rows

                If ROW.Tipo = TIPO Then

                    VecchiaRiga = ROW

                    TX_BX.Text = ROW._BX_
                    TX_BY.Text = ROW._BY_
                    TX_CX.Text = ROW._CX_
                    TX_CY.Text = ROW._CY_
                    TX_FX.Text = ROW._FX_
                    TX_FY.Text = ROW._FY_
                    TX_TX.Text = ROW._TX_
                    TX_TY.Text = ROW._TY_
                    If Not ROW.IsNoteNull Then TX_Note.Text = ROW.Note

                End If

            Next

        End If
    End Sub

    Private Sub FRM_SetupRivestimenti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGW_Tipi.Rows.Clear()
        SQL.FillDGW_SQL("SELECT Setup_Rivest.Tipo, Tipi.Descrizione FROM Setup_Rivest LEFT JOIN Tipi ON Setup_Rivest.Tipo = Tipi.Tipo", DGW_Tipi)

        Rinfresca()

    End Sub

    Private Sub DGW_Tipi_SelectionChanged(sender As Object, e As EventArgs) Handles DGW_Tipi.SelectionChanged
        Rinfresca()
    End Sub

    Private Sub BT_Salva_Click(sender As Object, e As EventArgs) Handles BT_Salva.Click

        Dim Note As String = TX_Note.Text
        If TX_Note.Text = "" Then Note = Nothing

        Try
            Using TA As New ModPackDBDataSetTableAdapters.Setup_RivestTableAdapter

                TA.Update(TIPO, TX_BX.Text, TX_BY.Text, TX_CX.Text, TX_CY.Text, TX_FX.Text, TX_FY.Text, TX_TX.Text, TX_TY.Text, Note, VecchiaRiga.Id, VecchiaRiga.Tipo, VecchiaRiga._BX_, VecchiaRiga._BY_, VecchiaRiga._CX_, VecchiaRiga._CY_, VecchiaRiga._FX_, VecchiaRiga._FY_, VecchiaRiga._TX_, VecchiaRiga._TY_, VecchiaRiga.Id)
                MsgBox("Modifiche effettuate!", vbInformation, "Setup Rivestimenti")

                Rinfresca()

            End Using
        Catch ex As Exception
            Errore.Show("Salva modifiche a setup rivestimenti", ex.Message)

        End Try

    End Sub
End Class