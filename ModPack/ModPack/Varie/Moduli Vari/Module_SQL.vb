Imports System.Data.SqlClient

Namespace SQL
    Module Module_SQL

        Public Function GetID_RigaOrdine(ByVal Riga As RigaOrdine) As Integer
            Dim ID As Integer

            Using Table As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
                Using DS As New ModPackDBDataSet.OrdiniDataTable
                    Table.FillByNonEvaso(DS)

                    For Each Row As ModPackDBDataSet.OrdiniRow In DS

                        If Riga.Imballo = Row.Imballo And Riga.Codice = Row.Codice And Riga.Commessa = Row.Commessa And Riga.Qt = Row.Qt And Riga.L = Row.L And Riga.P = Row.P And Riga.H = Row.H And Riga.NumeroOrdine = Row.Ordine And Riga.DataConsegna = Row.Data_Consegna Then
                            ID = Row.Id
                        End If

                    Next

                End Using

            End Using

            Return ID
        End Function

        Public Sub InsertRigaOrdini(ByVal ROW As RigaOrdine)

            Using TA As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter

                TA.Insert(ROW.NumeroOrdine, ROW.Riga, ROW.Imballo, ROW.Indice, ROW.Qt, ROW.Cliente, ROW.Codice, ROW.Commessa, ROW.L, ROW.P, ROW.H, ROW.Tipo, ROW.Zoccoli,
                          ROW.Rivestimento, ROW.TipoRivestimento, ROW.Note, ROW.DataConsegna, ROW.HT, ROW.DT, ROW.BM, ROW.Rivest_Tot, ROW.Magazzino, ROW.Diagonali,
                          ROW.Stampato, ROW.Produzione, ROW.Evaso, Date.Today.Date)

            End Using

        End Sub

        Public Function GetSQLValue(Query As String)
            Dim Value As Object = Nothing

            Using Con As New SqlConnection(My.Settings.ModPackDBConnectionString)


                Using Cmd As New SqlCommand(Query, Con)

                    Try
                        Con.Open()  'Apre la connessione al db
                        Value = Cmd.ExecuteScalar()
                    Catch ex As System.Exception
                        MsgBox(ex.Message)
                    End Try

                End Using
            End Using

            Return Value
        End Function

        Public Sub Query(ByVal Query As String)

            Using Con As New SqlConnection(My.Settings.ModPackDBConnectionString)


                Using Cmd As New SqlCommand(Query, Con)

                    Try
                        Con.Open()  'Apre la connessione al db
                        Cmd.ExecuteNonQuery()
                    Catch ex As System.Exception
                        MsgBox(ex.Message)
                    End Try

                End Using
            End Using


        End Sub

        Public Function ConvertIDLISTtoListRigaOrdine(ByVal IDlist As List(Of Integer)) As List(Of RigaOrdine)
            Dim Rows As New List(Of RigaOrdine)

            Dim DS As New ModPackDBDataSet.OrdiniDataTable

            Using DTA As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
                DTA.Fill(DS)
            End Using

            For Each ID As Integer In IDlist
                For Each R As ModPackDBDataSet.OrdiniRow In DS.Rows
                    If R.Id = ID Then

                        Dim O As New RigaOrdine With {
                        .NumeroOrdine = R.Ordine, .Riga = R.Riga, .Imballo = R.Imballo, .Indice = R.Indice, .Qt = R.Qt, .Cliente = R.Cliente, .Codice = R.Codice,
                        .Commessa = R.Commessa, .L = R.L, .P = R.P, .H = R.H, .Tipo = R.Tipo, .Zoccoli = R.Zoccoli, .Rivestimento = R.Rivestimento, .TipoRivestimento = R.Tipo_Rivestimento,
                        .Note = R.Note, .DataConsegna = R.Data_Consegna, .HT = R.HT, .BM = R.BM, .DT = R.DT, .Rivest_Tot = R.Rivest_Tot, .Magazzino = R.Magazzino, .Diagonali = R.Diagonali,
                        .Stampato = R.Stampato, .Produzione = R.Produzione, .Evaso = R.Evaso, .Data_Ordine = R.Data_Ordine}

                        Rows.Add(O)
                    End If
                Next
            Next


            Return Rows
        End Function

        Public Function ImballoInOrdine(ByVal Imballo As String) As Boolean
            'Check on the OrdiniTable if the order was already loaded
            Dim Exist As Boolean = False
            Dim Count As Int16

            Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)
                Using Cmd As New System.Data.SqlClient.SqlCommand("SELECT COUNT(Imballo) FROM Ordini WHERE Imballo = '" & Imballo & "' AND Evaso = 'False'", Con)

                    Try
                        Con.Open()

                        Count = Convert.ToInt16(Cmd.ExecuteScalar())
                        If Count > 0 Then Exist = True

                    Catch ex As System.Exception
                        MsgBox(ex.Message & vbCrLf & "imballoOrdine")
                    End Try

                End Using
            End Using

            Return Exist
        End Function

        Public Sub FillDGW_SQL(Query As String, DGW As DataGridView)
            Dim DS As New DataSet
            Using Con As New SqlConnection(My.Settings.ModPackDBConnectionString)

                Try

                    Con.Open()   'Apre la connessione al db

                    Using adapter As New SqlDataAdapter(Query, Con)   'Crea la nuova tabella
                        adapter.Fill(DS)    'Riempie la tabella coi risultati della query
                    End Using

                    DGW.DataSource = DS.Tables(0)   'Assegna alla DGW la tabella creata

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try



            End Using
        End Sub

        Public Function GetPrezzoMateriale(ByVal Materiale As String) As Decimal
            Dim Prezzo As Decimal

            Using Table As New ModPackDBDataSetTableAdapters.MaterialiTableAdapter
                Using DS As New ModPackDBDataSet.MaterialiDataTable

                    Table.Fill(DS)

                    Dim Result() As DataRow = DS.Select("Materiale = '" & Materiale & "'")

                    Prezzo = Result(0)(4)

                End Using
            End Using


            Return Prezzo
        End Function

        Public Function GetInfoTipo(ByVal Tipo As String) As String
            Dim Info As String

            Using Table As New ModPackDBDataSetTableAdapters.TipiTableAdapter
                Using DS As New ModPackDBDataSet.TipiDataTable

                    Table.Fill(DS)

                    Dim Result() As DataRow = DS.Select("Tipo = '" & Tipo & "'")

                    If Not IsDBNull(Result(0)(9)) Then
                        Info = Result(0)(9)
                    Else
                        Info = ""
                    End If


                End Using
            End Using


            Return Info
        End Function

        Public Function GetImballInputFromImballoName(ByVal ImballoName As String) As RigaOrdineINPUT
            Dim Riga As New RigaOrdineINPUT

            Using Table As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
                Using DS As New ModPackDBDataSet.ImballiDataTable
                    Table.Fill(DS)

                    Dim Valori() As DataRow = DS.Select("Imballo = '" & ImballoName & "'")

                    Riga.L = Valori(0)(2)
                    Riga.P = Valori(0)(3)
                    Riga.H = Valori(0)(4)
                    Riga.Tipo = Valori(0)(5)
                    Riga.Zoccoli = Valori(0)(6)
                    Riga.Rivestimento = Valori(0)(7)
                    Riga.TipoRivestimento = Valori(0)(8)
                    Riga.HT = Valori(0)(9)
                    Riga.DT = Valori(0)(10)
                    Riga.BM = Valori(0)(11)
                    Riga.Diagonali = Valori(0)(12)



                End Using
            End Using

            Return Riga
        End Function

        Public Sub SendIndex(ByVal Imballo As String, ByVal Indice As String, Optional Codice As String = "", Optional Note As String = "", Optional Rivest_Tot As String = "", Optional Note_BiC As String = "")
            Using DS As New ModPackDBDataSet

                Using IndexTable As New ModPackDBDataSetTableAdapters.IndiciTableAdapter
                    Using ImballiTable As New ModPackDBDataSetTableAdapters.ImballiTableAdapter

                        IndexTable.Fill(DS.Indici)
                        ImballiTable.Fill(DS.Imballi)

                        Dim RowImballo() As DataRow = DS.Imballi.Select("Imballo = '" & Imballo & "'")

                        'Prima di fare qualsiasi cosa controlla che esista l'imballo a cui si vuole inviare l'indice
                        If RowImballo.Length > 0 Then

                            Dim RowIndice() As DataRow = DS.Indici.Select("Indice = '" & Indice & "'")
                            If RowIndice.Length > 0 Then
                                For K = 0 To RowIndice.Length - 1
                                    'Se l'indice esisteva già nella tabella lo elimina prima di assegnarlo ad nuovo imballo
                                    IndexTable.Delete(RowIndice(K)(0), RowIndice(K)(1), RowIndice(K)(2), RowIndice(K)(3))
                                    LOG.Write("Eliminato indice (" & RowIndice(K)(2) & ") Da (" & RowIndice(K)(1) & ")")
                                Next
                            End If

                            'Invia l'indice al nuovo imballo
                            IndexTable.Insert(Imballo.ToUpper, Indice, Codice, Note, Rivest_Tot, Note_BiC)

                            IndexTable.Update(DS.Indici)
                            LOG.Write("Inviato indice (" & Indice & ") -> (" & Imballo & ")")

                        Else
                            MsgBox("Non esiste nessun imballo '" & Imballo & "'")
                        End If

                    End Using
                End Using
            End Using
        End Sub

        Public Function Get_NoteBic(ByVal Indice As Integer)
            Dim Nota As String = ""

            Using DS As New ModPackDBDataSet.IndiciDataTable
                Using Table As New ModPackDBDataSetTableAdapters.IndiciTableAdapter
                    Table.Fill(DS)

                    Dim Row() As DataRow = DS.Select("Indice = '" & Indice & "'")

                    If Row.Length > 0 Then
                        Nota = Row(0)(6)
                    End If


                End Using
            End Using

            Return Nota
        End Function
        Public Function Get_NoteIMBALLO(ByVal Imballo As String) As String
            Dim Nota As String = ""

            Using DS As New ModPackDBDataSet.NoteImballiDataTable
                Using Table As New ModPackDBDataSetTableAdapters.NoteImballiTableAdapter
                    Table.Fill(DS)

                    Dim Row() As DataRow = DS.Select("Imballo = '" & Imballo & "'")

                    If Row.Length > 0 Then
                        For K = 0 To Row.Length - 1
                            Nota += Row(K)(2) & vbCrLf
                        Next
                    End If

                End Using
            End Using

            Return Nota
        End Function

        Public Sub ListaMorali(Ordini As List(Of String), Datagridview As DataGridView)
            Datagridview.DataSource = Nothing

            'Inizia la stringa degli ordini
            Dim StringaOrdini As String = "("
            For K = 0 To Ordini.Count - 1

                StringaOrdini += "Ordini.Ordine = '" & Ordini(K) & "'"

                If Not K = Ordini.Count - 1 Then
                    'Se non è l'ulimo della lista mette OR
                    StringaOrdini += " OR "
                Else
                    'Se è l'ultimo chiude la stringa
                    StringaOrdini += ")"
                End If

            Next

            Dim Query As String = "SELECT Distinta.X, Distinta.Y, Distinta.Z, SUM(Distinta.N * Ordini.QT) AS N, Ordini.HT FROM Ordini LEFT JOIN Distinta ON Ordini.Imballo = Distinta.Imballo WHERE " & StringaOrdini & " AND Distinta.Tag = 'Mor' GROUP BY X, Y, Z, HT ORDER BY HT ASC, Z DESC"
            SQL.FillDGW_SQL(Query, Datagridview)
        End Sub
        Public Sub ListaDiagonaliF(Ordini As List(Of String), Datagridview As DataGridView)
            Datagridview.DataSource = Nothing

            'Inizia la stringa degli ordini
            Dim StringaOrdini As String = "("
            For K = 0 To Ordini.Count - 1

                StringaOrdini += "Ordini.Ordine = '" & Ordini(K) & "'"

                If Not K = Ordini.Count - 1 Then
                    'Se non è l'ulimo della lista mette OR
                    StringaOrdini += " OR "
                Else
                    'Se è l'ultimo chiude la stringa
                    StringaOrdini += ")"
                End If

            Next

            Dim Query As String =
                "SELECT Ordini.Ordine, Ordini.Imballo, SUM(Ordini.QT) as QT, Distinta.X, Distinta.Y, Distinta.Z, concat(sum(Distinta.N * Ordini.QT), ' (F)') AS N, concat(Imballi.Gradi_F, '°')  AS GRADI, Ordini.HT " &
                "FROM Ordini LEFT JOIN Distinta ON Ordini.Imballo = Distinta.Imballo LEFT JOIN Imballi ON Distinta.Imballo = Imballi.Imballo " &
                "WHERE " & StringaOrdini & " AND Distinta.Tag = 'FD' " &
                "GROUP BY Ordini.Ordine, Ordini.Imballo, Imballi.Gradi_F, Distinta.X, Distinta.Y, Distinta.Z, Ordini.HT " &
                "ORDER BY HT ASC, Z DESC"



            SQL.FillDGW_SQL(Query, Datagridview)
        End Sub
        Public Sub ListaDiagonaliT(Ordini As List(Of String), Datagridview As DataGridView)
            Datagridview.DataSource = Nothing

            'Inizia la stringa degli ordini
            Dim StringaOrdini As String = "("
            For K = 0 To Ordini.Count - 1

                StringaOrdini += "Ordini.Ordine = '" & Ordini(K) & "'"

                If Not K = Ordini.Count - 1 Then
                    'Se non è l'ulimo della lista mette OR
                    StringaOrdini += " OR "
                Else
                    'Se è l'ultimo chiude la stringa
                    StringaOrdini += ")"
                End If

            Next

            Dim Query As String =
                "SELECT Ordini.Ordine, Ordini.Imballo, SUM(Ordini.QT) as QT, Distinta.X, Distinta.Y, Distinta.Z, concat(sum(Distinta.N * Ordini.QT), ' (T)') AS N, concat(Imballi.Gradi_T, '°')  AS GRADI, Ordini.HT " &
                "FROM Ordini LEFT JOIN Distinta ON Ordini.Imballo = Distinta.Imballo LEFT JOIN Imballi ON Distinta.Imballo = Imballi.Imballo " &
                "WHERE " & StringaOrdini & " AND Distinta.Tag = 'TD' " &
                "GROUP BY Ordini.Ordine, Ordini.Imballo, Imballi.Gradi_T, Distinta.X, Distinta.Y, Distinta.Z, Ordini.HT " &
                "ORDER BY HT ASC, Z DESC"



            SQL.FillDGW_SQL(Query, Datagridview)
        End Sub
        Public Sub ListaDiagonaliTOT(Ordini As List(Of String), Datagridview As DataGridView)
            Datagridview.DataSource = Nothing

            'Inizia la stringa degli ordini
            Dim StringaOrdini As String = "("
            For K = 0 To Ordini.Count - 1

                StringaOrdini += "Ordini.Ordine = '" & Ordini(K) & "'"

                If Not K = Ordini.Count - 1 Then
                    'Se non è l'ulimo della lista mette OR
                    StringaOrdini += " OR "
                Else
                    'Se è l'ultimo chiude la stringa
                    StringaOrdini += ")"
                End If

            Next

            Dim QueryFiancate As String =
                "SELECT Ordini.Ordine, Ordini.Imballo, SUM(Ordini.QT) as QT, Distinta.X, Distinta.Y, Distinta.Z, concat(sum(Distinta.N * Ordini.QT), ' (F)') AS N, concat(Imballi.Gradi_F, '°')  AS GRADI, Ordini.HT " &
                "FROM Ordini LEFT JOIN Distinta ON Ordini.Imballo = Distinta.Imballo LEFT JOIN Imballi ON Distinta.Imballo = Imballi.Imballo " &
                "WHERE " & StringaOrdini & " AND Distinta.Tag = 'FD' " &
                "GROUP BY Ordini.Ordine, Ordini.Imballo, Imballi.Gradi_F, Distinta.X, Distinta.Y, Distinta.Z, Ordini.HT "

            Dim QueryTeste As String =
                "SELECT Ordini.Ordine, Ordini.Imballo, SUM(Ordini.QT) as QT, Distinta.X, Distinta.Y, Distinta.Z, concat(sum(Distinta.N * Ordini.QT), ' (T)') AS N, concat(Imballi.Gradi_T, '°')  AS GRADI, Ordini.HT " &
                "FROM Ordini LEFT JOIN Distinta ON Ordini.Imballo = Distinta.Imballo LEFT JOIN Imballi ON Distinta.Imballo = Imballi.Imballo " &
                "WHERE " & StringaOrdini & " AND Distinta.Tag = 'TD' " &
                "GROUP BY Ordini.Ordine, Ordini.Imballo, Imballi.Gradi_T, Distinta.X, Distinta.Y, Distinta.Z, Ordini.HT "


            Dim Query As String = QueryFiancate & " UNION ALL " & QueryTeste & " ORDER BY HT DESC, Imballo ASC, Z DESC"


            SQL.FillDGW_SQL(Query, Datagridview)
        End Sub

        Public Sub PuliziaOrdini()
            Try
                Dim xml = XDocument.Load(My.Settings.XMLpath)

                Dim Pulizia As String = xml.<Data>.<Pulizia_Ordine>.Value

                If Pulizia = "True" Then

                    Dim Giorni As Integer = xml.<Data>.<Giorni_Memoria_Ordine>.Value
                    LOG.Write("Pulizia periodica ordini [START] Ultima data valida: " & Date.Today.Date.AddDays(-Giorni))

                    Dim ListaIndici As New List(Of Integer)
                    Dim UltimoId As Integer = 0


                    Using Table As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
                        Using DS As New ModPackDBDataSet.OrdiniDataTable
                            Table.Fill(DS)

                            For Each Row As ModPackDBDataSet.OrdiniRow In DS
                                If Row.Data_Ordine <= Date.Today.Date.AddDays(-Giorni) And Row.Evaso = True Then
                                    ListaIndici.Add(Row.Id)
                                End If
                            Next

                        End Using
                    End Using

                    If Not ListaIndici.Count = 0 Then
                        UltimoId = ListaIndici.Max
                        'Elimina tutte le righe di ordine con data inferiore a quella scelta e evasi
                        SQL.Query("DELETE FROM Ordini WHERE Id <= '" & UltimoId & "' AND Evaso = 'True'")
                        LOG.Write("Pulizia periodica ordini [STOP] Eliminate " & ListaIndici.Count & " righe con data ordine inferiore a " & Date.Today.Date.AddDays(-Giorni))
                    Else
                        LOG.Write("Pulizia periodica ordini [STOP] Non ci sono ordini da eliminare")
                    End If

                End If

            Catch ex As Exception
                MsgBox("Si è verificato un'errore durante la pulizia periodica degli ordini" & vbCrLf & ex.Message)
                LOG.Write("Errore durante pulizia periodica ordini")
            End Try



        End Sub

        Public Function Fresata(ByVal Tipo As String) As Boolean
            Dim Fres As Boolean = False
            Using Tipi As New ModPackDBDataSetTableAdapters.TipiTableAdapter
                Using DS As New ModPackDBDataSet.TipiDataTable
                    Tipi.Fill(DS)

                    Dim Row() As DataRow = DS.Select("Tipo = '" & Tipo & "'")

                    If Row.Length > 0 Then
                        Fres = Row(0)(12)
                    End If

                End Using
            End Using

            Return Fres
        End Function





    End Module
End Namespace
