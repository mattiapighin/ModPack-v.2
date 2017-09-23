Imports System.Data.SqlClient

Public Class Form_StoricoOrdini

    Private Sub CaricaOrdini()

        'Riempie la tabella OrdiniAperti con i numeri d'ordine di ordini con ancora righe non evase
        Using DS As New DataSet

            Dim Query As String

            If My.Settings.OrdiniNRecords > 0 Then
                Query = "SELECT DISTINCT TOP(" & My.Settings.OrdiniNRecords & ") Ordine, Data_Ordine FROM Ordini ORDER BY Data_Ordine DESC"
            Else
                Query = "SELECT DISTINCT Ordine, Data_Ordine FROM Ordini ORDER BY Data_Ordine DESC"
            End If

            Using Con As New SqlConnection(My.Settings.ModPackDBConnectionString)

                Try
                    Con.Open()
                    Dim adapter As New SqlDataAdapter(Query, Con)
                    adapter.Fill(DS)    '
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using

            DGW_Ordini.DataSource = DS.Tables(0)

        End Using
        OrdiniBindingSource.Filter = "Ordine = 'XXXX'"
        FiltraColonne()



    End Sub
    Private Sub FiltraColonne()

        Dim Filtro As String = My.Settings.FiltroColonneOrdini

        For K = 0 To DGW_Righe.ColumnCount - 1
            If Filtro(K) = "1" Then
                DGW_Righe.Columns(K).Visible = True
            Else
                DGW_Righe.Columns(K).Visible = False
            End If
        Next

    End Sub

    Private Sub Form_StoricoOrdini_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'ModPackDBDataSet.Ordini'. È possibile spostarla o rimuoverla se necessario.
        Me.OrdiniTableAdapter.Fill(Me.ModPackDBDataSet.Ordini)

        Cb_Colonna.Items.Clear()
        For Each Column As DataColumn In ModPackDBDataSet.Ordini.Columns
            If Not Column.ColumnName.Contains("Data") Then

                Cb_Colonna.Items.Add(Column.ColumnName)
            End If

        Next

        CaricaOrdini()
    End Sub

    Private Sub DGW_Ordini_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGW_Ordini.CellClick
        OrdiniBindingSource.Filter = "Ordine = '" & DGW_Ordini.CurrentRow.Cells(0).Value & "'"
        DGW_Righe.Columns(1).Visible = False
        FiltraColonne()
    End Sub

    Private Sub Bt_Cerca_Click(sender As Object, e As EventArgs) Handles Bt_Cerca.Click
        Try
            If Not TxtCerca.Text = "" And Not Cb_Colonna.Text = "" Then
                OrdiniBindingSource.Filter = Cb_Colonna.Text & " LIKE '" & TxtCerca.Text & "'"
                DGW_Righe.Columns(1).Visible = True
                FiltraColonne()
            End If
        Catch EX As Exception

            If EX.HResult = -2146232032 Then 'se restituisce l'errore che non si può usare LIKE su interi
                OrdiniBindingSource.Filter = Cb_Colonna.Text & " = '" & TxtCerca.Text & "'"
                DGW_Righe.Columns(1).Visible = True
                FiltraColonne()
            End If
        End Try

    End Sub

    Private Sub Bt_CancellaFiltro_Click(sender As Object, e As EventArgs) Handles Bt_CancellaFiltro.Click
        TxtCerca.Text = ""
        Cb_Colonna.Text = ""
        OrdiniBindingSource.Filter = Nothing
        DGW_Righe.Columns(1).Visible = False
        FiltraColonne()
    End Sub

    Private Sub Bt_FiltraPerData_Click(sender As Object, e As EventArgs) Handles Bt_FiltraPerData.Click

        If Dialog_FiltraData.ShowDialog = DialogResult.OK Then

            Using DS As New DataSet

                Dim DA As String = Format(Dialog_FiltraData.DataInizio.Date, "MM/dd/yyyy")
                Dim A As String = Format(Dialog_FiltraData.DataFine.Date, "MM/dd/yyyy")

                Dim Query As String

                If My.Settings.OrdiniNRecords > 0 Then
                    Query = "SELECT DISTINCT TOP(" & My.Settings.OrdiniNRecords & ") Ordine, Data_Ordine FROM Ordini WHERE Data_Ordine BETWEEN '" & DA & "' AND '" & A & "' ORDER BY Data_Ordine DESC"
                Else
                    Query = "SELECT DISTINCT Ordine, Data_Ordine FROM Ordini WHERE Data_Ordine BETWEEN '" & Dialog_FiltraData.DataInizio.Date & "' AND '" & Dialog_FiltraData.DataFine.Date & "' ORDER BY Data_Ordine DESC"
                End If

                Using Con As New SqlConnection(My.Settings.ModPackDBConnectionString)

                    Try
                        Con.Open()
                        Dim adapter As New SqlDataAdapter(Query, Con)
                        adapter.Fill(DS)    '
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using

                DGW_Ordini.DataSource = DS.Tables(0)

            End Using
            OrdiniBindingSource.Filter = "Ordine = 'XXXX'"
            FiltraColonne()
        End If



    End Sub

    Private Sub Bt_Refresh_Click(sender As Object, e As EventArgs) Handles Bt_Refresh.Click
        CaricaOrdini()
    End Sub

    Private Sub Bt_Colonne_Click(sender As Object, e As EventArgs) Handles Bt_Colonne.Click
        Form_StoricoOrdini_ScegliColonne.ShowDialog()
        FiltraColonne()
    End Sub

End Class