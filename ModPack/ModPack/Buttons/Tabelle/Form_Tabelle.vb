Imports System.Data.SqlClient

Public Class Form_Tabelle

    Dim FileQueries As String = My.Settings.Root & "\SQLQueries.txt"

    Private Sub FillDGW(Query As String, DGW As DataGridView)

        If Not TxtQuery.Text.Contains("DELETE") Or TxtQuery.Text.Contains("TRUNCATE") Then

            Dim DS As New DataSet
            Using Con As New SqlConnection(My.Settings.ModPackDBConnectionString)

                Try

                    Con.Open()   'Apre la connessione al db

                    Using adapter As New SqlDataAdapter(Query, Con)   'Crea la nuova tabella

                        adapter.Fill(DS)    'Riempie la tabella coi risultati della query

                    End Using

                    If DS.Tables.Count > 0 Then
                        DGW.DataSource = DS.Tables(0)   'Assegna alla DGW la tabella creata
                    Else
                        MsgBox("Query inviata!", vbInformation, "Test")
                    End If

                    LOG.Write("QUERY: " & Query)

                Catch ex As Exception
                    '  MsgBox(ex.ToString)
                    Errore.Show("FillDGW / Tabelle", ex.Message)
                End Try
            End Using

        Else
            MsgBox("Non è possibile utilizzare i comandi DELETE e TRUNCATE da questa finestra")

        End If


    End Sub

    Private Sub CaricaTreeView()
        Try
            Dim DS As New ModPackDBDataSet

            Dim I As Integer = 0

            For Each Table As DataTable In DS.Tables
                Tree.Nodes.Add(Table.TableName)
                For Each Column As DataColumn In Table.Columns
                    Tree.Nodes(I).Nodes.Add(Column.ColumnName)
                Next
                I += 1
            Next
        Catch ex As Exception
            Errore.Show("CaricaTreeView \ Tabelle", ex.Message)
        End Try

    End Sub

    Private Sub Bt_Test_Click(sender As Object, e As EventArgs) Handles Bt_Test.Click
        FillDGW(TxtQuery.Text, DGW_Result)
    End Sub

    Private Sub Form_Stampe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CaricaTreeView()
        SQL.FillDGW_SQL("SELECT Nome FROM Queries", DGW_queries)

    End Sub

    Private Sub Bt_Salva_Click(sender As Object, e As EventArgs) Handles Bt_Salva.Click
        Try
            If Not TxtQuery.Text.Contains("DELETE") Or TxtQuery.Text.Contains("TRUNCATE") Then
                Dim Nome As String = InputBox("Nome della Query", "Query", TxtQuery.Text)

                If Not String.IsNullOrEmpty(Nome) Then
                    If Not Nome.Length > 50 Then


                        Using Table As New ModPackDBDataSetTableAdapters.QueriesTableAdapter
                            Using DS As New ModPackDBDataSet.QueriesDataTable
                                Table.Insert(Nome, TxtQuery.Text)
                                Table.Update(DS)
                            End Using
                        End Using
                        MsgBox("Query Salvata!", vbInformation, "Salva")
                        SQL.FillDGW_SQL("SELECT Nome FROM Queries", DGW_queries)
                    Else
                        MsgBox("Il nome della query non può superare i 50 Caratteri", vbCritical, "Query")
                    End If



                End If

            Else
                MsgBox("Non è possibile utilizzare i comandi DELETE e TRUNCATE da questa finestra", vbCritical, "Query")
            End If
        Catch EX As Exception
            Errore.Show("Salva Query / Tabelle", EX.Message)
        End Try

    End Sub

    Private Sub Bt_Esegui_Click(sender As Object, e As EventArgs) Handles Bt_Esegui.Click
        Try
            TxtQuery.Text = ""

            Using Table As New ModPackDBDataSetTableAdapters.QueriesTableAdapter
                Using DS As New ModPackDBDataSet.QueriesDataTable
                    Table.Fill(DS)

                    For Each Row As ModPackDBDataSet.QueriesRow In DS.Rows
                        If Row.Nome = DGW_queries.CurrentCell.Value Then
                            FillDGW(Row.Query, DGW_Result)
                            TxtQuery.Text = Row.Query
                        End If
                    Next

                End Using
            End Using
        Catch ex As Exception
            Errore.Show("Esegui \ Tabelle", ex.Message)
        End Try
    End Sub

    Private Sub Bt_Elimina_Click(sender As Object, e As EventArgs) Handles Bt_Elimina.Click
        Try
            If Not DGW_queries.SelectedCells.Count = 0 Then
                Dim Nome As String = DGW_queries.CurrentCell.Value
                If MsgBox("Eliminare la query '" & Nome & "'?", vbYesNo, "Elimina") Then
                    SQL.Query("DELETE FROM Queries WHERE Nome ='" & Nome & "'")
                    SQL.FillDGW_SQL("SELECT Nome FROM Queries", DGW_queries)
                End If
            End If
        Catch ex As Exception
            Errore.Show("Elimina \ Tabelle", ex.Message)
        End Try
    End Sub

    Private Sub Bt_Esporta_Click(sender As Object, e As EventArgs) Handles Bt_Esporta.Click
        If Not DGW_Result.Rows.Count = 0 Then
            Try

                Dim dgv As DataGridView = DGW_Result

                Dim DTB = New DataTable, RWS As Integer, CLS As Integer

                For CLS = 0 To dgv.ColumnCount - 1 ' COLUMNS OF DTB
                    DTB.Columns.Add(dgv.Columns(CLS).Name.ToString)
                Next

                Dim DRW As DataRow

                For RWS = 0 To dgv.Rows.Count - 1 ' FILL DTB WITH DATAGRIDVIEW
                    DRW = DTB.NewRow

                    For CLS = 0 To dgv.ColumnCount - 1
                        Try
                            DRW(DTB.Columns(CLS).ColumnName.ToString) = dgv.Rows(RWS).Cells(CLS).Value.ToString
                        Catch ex As Exception
                        End Try
                    Next

                    DTB.Rows.Add(DRW)
                Next

                DTB.AcceptChanges()

                Dim DST As New DataSet
                DST.Tables.Add(DTB)
                Dim FLE As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\Output.xml" ' PATH AND FILE NAME WHERE THE XML WIL BE CREATED (EXEMPLE: C:\REPS\XML.xml)
                DTB.WriteXml(FLE)
                Dim EXL As String = My.Settings.ExcelPath ' PATH OF/ EXCEL.EXE IN YOUR MICROSOFT OFFICE
                Shell(Chr(34) & EXL & Chr(34) & " " & Chr(34) & FLE & Chr(34), vbNormalFocus) ' OPEN XML WITH EXCEL

            Catch ex As Exception
                Errore.Show("Esporta \ Tabelle", ex.Message)
            End Try
        End If
    End Sub

    Private Sub Bt_Info_Click(sender As Object, e As EventArgs) Handles Bt_Info.Click
        If SplitContainer1.Panel2Collapsed = True Then
            SplitContainer1.Panel2Collapsed = False
        Else
            SplitContainer1.Panel2Collapsed = True
        End If

    End Sub

    Private Sub TxtQuery_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtQuery.KeyDown
        If e.KeyCode = Keys.Return Then
            Bt_Test_Click(sender, e)
        End If
    End Sub

    Private Sub Bt_Invia_Click(sender As Object, e As EventArgs) Handles Bt_Invia.Click
        If Not DGW_Result.Rows.Count = 0 Then
            Try

                Dim dgv As DataGridView = DGW_Result

                Dim DTB = New DataTable, RWS As Integer, CLS As Integer

                For CLS = 0 To dgv.ColumnCount - 1 ' COLUMNS OF DTB
                    DTB.Columns.Add(dgv.Columns(CLS).Name.ToString)
                Next

                Dim DRW As DataRow

                For RWS = 0 To dgv.Rows.Count - 1 ' FILL DTB WITH DATAGRIDVIEW
                    DRW = DTB.NewRow

                    For CLS = 0 To dgv.ColumnCount - 1
                        Try
                            DRW(DTB.Columns(CLS).ColumnName.ToString) = dgv.Rows(RWS).Cells(CLS).Value.ToString
                        Catch ex As Exception
                        End Try
                    Next

                    DTB.Rows.Add(DRW)
                Next

                DTB.AcceptChanges()

                Dim NomeFile As String = InputBox("Nome file:", "Invia", "Output")
                If String.IsNullOrEmpty(NomeFile) Then NomeFile = "Output"


                Dim DST As New DataSet
                DST.Tables.Add(DTB)
                Dim FLE As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\" & NomeFile & ".xml" ' PATH AND FILE NAME WHERE THE XML WIL BE CREATED (EXEMPLE: C:\REPS\XML.xml)
                DTB.WriteXml(FLE)
                'Dim EXL As String = My.Settings.ExcelPath ' PATH OF/ EXCEL.EXE IN YOUR MICROSOFT OFFICE
                'Shell(Chr(34) & EXL & Chr(34) & " " & Chr(34) & FLE & Chr(34), vbNormalFocus) ' OPEN XML WITH EXCEL

                Dim Allegati As New List(Of String)
                Allegati.Add(FLE)

                Mail.Invia("(" & My.Settings.Utente & ") Invio file: " & NomeFile, "Questa mail viene generata automaticamente, si prega di non rispondere." & vbCrLf & "This is an automatically generated email, please do not reply.", Allegati)

            Catch ex As Exception
                Errore.Show("Invia \ Tabelle", ex.Message)
            End Try
        End If
    End Sub


End Class