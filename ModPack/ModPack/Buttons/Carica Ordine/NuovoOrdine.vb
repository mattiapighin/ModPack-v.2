Namespace Ordine
    Public Module Ordine

        Dim ImballoName As String
        Public ListaNuovi As New List(Of String)

        Public Lista As New List(Of RigaOrdineINPUT)

        Dim OrdiniTable As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter With {.ClearBeforeFill = True}
        Dim IndiciTable As New ModPackDBDataSetTableAdapters.IndiciTableAdapter With {.ClearBeforeFill = True}
        Dim ImballiTable As New ModPackDBDataSetTableAdapters.ImballiTableAdapter With {.ClearBeforeFill = True}
        Dim DistintaTable As New ModPackDBDataSetTableAdapters.DistintaTableAdapter With {.ClearBeforeFill = True}
        Dim DS As New ModPackDBDataSet

        Public Function OrdineEXIST(ByVal Ordine As String) As Boolean
            Using Table As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
                Using DS As New ModPackDBDataSet.OrdiniDataTable
                    Table.Fill(DS)

                    Return DS.Where(Function(x) x.Ordine = Ordine).Any

                End Using
            End Using
        End Function
        Public Function IndiceEXIST(ByVal Indice As Integer) As Boolean
            Using Table As New ModPackDBDataSetTableAdapters.IndiciTableAdapter
                Using DS As New ModPackDBDataSet.IndiciDataTable

                    Table.Fill(DS)

                    Return DS.Where(Function(X) X.Indice = Indice).Any

                End Using
            End Using
        End Function
        Public Function ConvertIndiceToImballo(ByVal Indice As Integer) As String
            Using Table As New ModPackDBDataSetTableAdapters.IndiciTableAdapter
                Using DS As New ModPackDBDataSet.IndiciDataTable

                    Table.Fill(DS)

                    Dim IndiceRow As ModPackDBDataSet.IndiciRow = DS.Where(Function(X) X.Indice = Indice).FirstOrDefault

                    If Not IndiceRow Is Nothing Then
                        Return IndiceRow.Imballo
                    Else
                        Return ""
                    End If


                End Using
            End Using
        End Function
        Public Function ImballoNomeEXIST(ByVal Imballo As String) As Boolean
            Using Table As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
                Using DS As New ModPackDBDataSet.ImballiDataTable

                    Table.Fill(DS)

                    Return DS.Where(Function(x) x.Imballo = Imballo).Any

                End Using
            End Using


        End Function

        Public Function New_CheckRIga(ByVal Riga As RigaOrdineINPUT, ByVal Nome As String) As Boolean

            Return DS.Imballi.Where(Function(X) X.Imballo = Nome And
                                                                                     X.L = Riga.L And
                                                                                     X.P = Riga.P And
                                                                                     X.H = Riga.H And
                                                                                     X.Tipo = Riga.Tipo And
                                                                                     X.Zoccoli = Riga.Zoccoli And
                                                                                     X.Rivestimento = Riga.Rivestimento And
                                                                                     X.Tipo_Rivestimento = Riga.TipoRivestimento And
                                                                                     X.HT = Riga.HT And
                                                                                     X.DT = Riga.DT And
                                                                                     X.BM = Riga.BM And
                                                                                     X.Diagonali = Riga.Diagonali
                                                                                     ).Any

            Debug.WriteLine("Check riga " & Nome)

        End Function
        Public Function New_ConfrontoImballi(ByVal Riga As RigaOrdineINPUT) As Boolean
            Dim Esiste As Boolean = False



            Dim ImballoTrovato As ModPackDBDataSet.ImballiRow = DS.Imballi.Where(Function(X) X.L = Riga.L And
                                                                                     X.P = Riga.P And
                                                                                     X.H = Riga.H And
                                                                                     X.Tipo = Riga.Tipo And
                                                                                     X.Zoccoli = Riga.Zoccoli And
                                                                                     X.Rivestimento = Riga.Rivestimento And
                                                                                     X.Tipo_Rivestimento = Riga.TipoRivestimento And
                                                                                     X.HT = Riga.HT And
                                                                                     X.DT = Riga.DT And
                                                                                     X.BM = Riga.BM And
                                                                                     X.Diagonali = Riga.Diagonali
                                                                                     ).FirstOrDefault

            If Not ImballoTrovato Is Nothing Then

                        Esiste = True
                        ImballoName = ImballoTrovato.Imballo

                    End If

            Return Esiste
        End Function

        Public Sub CaricaFileOrdine(Optional Progressbar As ToolStripProgressBar = Nothing, Optional Label As ToolStripStatusLabel = Nothing, Optional Notify As NotifyIcon = Nothing)
            Dim OpenFile As New OpenFileDialog With {.Filter = "Ordine modine|*.txt", .Title = "Carica Ordine", .Multiselect = False, .FileName = "Ordine"}
            If OpenFile.ShowDialog = DialogResult.OK Then
                CaricaOrdine(OpenFile.FileName, Progressbar, Label, Notify)

            End If
        End Sub
        Public Sub CaricaOrdine(ByVal FileOrdine As String, Optional Progressbar As ToolStripProgressBar = Nothing, Optional Label As ToolStripStatusLabel = Nothing, Optional Notify As NotifyIcon = Nothing)

            Dim ContaNuovi As Integer = 0
            Dim ListaTipi As List(Of String) = Controlli.RiempiListaTipi
            Dim ListaRivestimenti As List(Of String) = Controlli.RiempiListaRivestimenti

            If Not Label Is Nothing Then Label.Text = "Caricamento ordine"
            Dim NumeroOrdine As String = IO.Path.GetFileNameWithoutExtension(FileOrdine)
            LOG.Write("[[============ CARICAMENTO ORDINE " & NumeroOrdine & " ============]]")

            '1 - Controlla che l'ordine non sia già stato caricato (in base al nome del file)
            Try
                If Ordine.OrdineEXIST(IO.Path.GetFileNameWithoutExtension(FileOrdine)) = True Then
                    LOG.Write("Ordine " & NumeroOrdine & " già in carico")
                    If MsgBox("L'ordine che si stà cercando di caricare è già presente!" & vbCrLf & "Vuoi proseguire lo stesso?", vbYesNo, "Carica ordine") = MsgBoxResult.Yes Then
                        Dim NuovoNome As String = InputBox("Nuovo numero d'ordine:", "Carica Ordine", NumeroOrdine)

                        If Not String.IsNullOrEmpty(NuovoNome) Then
                            NumeroOrdine = NuovoNome
                            LOG.Write("Nuovo numero d'ordine: " & NumeroOrdine)
                        Else
                            LOG.Write("Caricamento annullato")
                            Exit Sub
                        End If

                    Else
                        Exit Sub
                    End If
                End If

                '2 - Pulisce le liste "imballi da caricare" e "nuovi imballi trovati da codificare"
                Lista.Clear()
                'ListaNuovi.Clear()

                '3 - Legge tutte le righe del file ordine e le inserisce in array RIGHE()
                Dim RIGHE() As String = IO.File.ReadAllLines(FileOrdine)

                For Each Record As String In RIGHE

                    '4 - Trasforma ogni riga letta in un oggetto RigaOrdineINPUT
                    Dim R() As String = Split(Record, ";")

                    If R.Length = 20 Then ' Controlla che la riga sia formattata correttamente (non prende in considerazione righe vuote o sbagliate

                        Dim Riga_INPUT As New RigaOrdineINPUT With
                            {.Riga = R(0), .Indice = R(1), .Qt = R(2), .Cliente = R(3), .Codice = R(4).ToString.TrimEnd("-"), .Commessa = R(5).ToString.TrimEnd("-"), .L = R(6), .P = R(7), .H = R(8), .Tipo = R(9), .Zoccoli = R(10),
                            .Rivestimento = R(11), .TipoRivestimento = R(12), .Note = R(13), .DataConsegna = R(14), .HT = R(15), .DT = R(16), .BM = R(17), .Rivest_Tot = R(18), .Diagonali = R(19),
                            .NumeroOrdine = NumeroOrdine}

                        If Riga_INPUT.Rivestimento = False Then Riga_INPUT.TipoRivestimento = "" 'Se rivestimento = false non ci deve essere il tipo rivestimento

                        If Controlli.CheckTipiRivestimenti(Riga_INPUT, ListaTipi, ListaRivestimenti) = True Then
                            'Controlli sulla riga input

                            'Se è un pallet non tiene conto di altezza, diagonali e rivestimento
                            If R(9) = "P" Or R(9) = "T" Then
                                Riga_INPUT.H = 0
                                Riga_INPUT.Diagonali = False
                                Riga_INPUT.Rivestimento = False
                                Riga_INPUT.TipoRivestimento = ""
                            End If
                            'Se è una cassa non tiene conto di diagonali e rivestimento
                            If R(9) = "C" Then
                                Riga_INPUT.Diagonali = False
                                Riga_INPUT.Rivestimento = False
                                Riga_INPUT.TipoRivestimento = ""
                            End If

                            If My.Settings.MisurePari = True Then
                                'Se la misura è dispari aumenta 1
                                If Riga_INPUT.L Mod 2 <> 0 Then Riga_INPUT.L += 1
                                If Riga_INPUT.P Mod 2 <> 0 Then Riga_INPUT.P += 1
                                If Riga_INPUT.H Mod 2 <> 0 Then Riga_INPUT.H += 1
                                'Se attivato arrL5 la lunghezza viene arrotondata al 5 più vicino
                                If My.Settings.ArrL5 = True Then Riga_INPUT.L = (Math.Round(Riga_INPUT.L / 5)) * 5
                            End If

                            '5 - Aggiunge l'oggetto appena creato alla lista "imballi da caricare"
                            Lista.Add(Riga_INPUT)

                        End If


                    Else
                        Errore.Show("Controllo integrità ordine", "Attenzione, è stata trovata una riga vuota o non formattata correttamente:" & vbCrLf & "[" & Record & "]")
                    End If

                Next

                If Not Progressbar Is Nothing Then
                    Progressbar.Value = 0
                    Progressbar.Maximum = Lista.Count
                End If
                If Not Label Is Nothing Then Label.Text = "Caricamento ordine"

            Catch ex As Exception
                Errore.Show("Presa in carico ordine", ex.Message)
                Exit Sub
            End Try

            '################################# ELABORA LA LISTA APPENA CREATA ###############################

            Dim ProgC As String ' Crea una stringa sul file di log per seguire il percorso compiuto 
            Dim ts1 As New TimeSpan(Now.Ticks)

            Try
                If Not Label Is Nothing Then Label.Text = "Elaborazione Ordine"
                'Dim Magazzino As String = InputBox("ORDINE: " & NumeroOrdine & vbCrLf & "Sono stati trovati " & Lista.Count & " imballi" & vbCrLf & "Selezionare magazzino:", "Carica ordine", "1")

                Dim Magazzino As String

                If Not Label Is Nothing Then Label.Text = "Scelta magazzino"

                DLG_ScegliMagazzino.LblOrdine.Text = NumeroOrdine
                DLG_ScegliMagazzino.LblRighe.Text = Lista.Count

                If DLG_ScegliMagazzino.ShowDialog = DialogResult.OK Then

                    Magazzino = DLG_ScegliMagazzino.Valore
                Else
                    Exit Sub
                End If
                If String.IsNullOrEmpty(Magazzino) Then Exit Sub

                '6 - Legge la lista appena creata e controlla se esistono in memoria imballi corrispondenti

                OrdiniTable.Fill(DS.Ordini)

                If Not Label Is Nothing Then Label.Text = "Creazione Lista"

                For Each PACK As RigaOrdineINPUT In Lista

                    Dim ts3 As New TimeSpan(Now.Ticks)

                    ImballiTable.Fill(DS.Imballi)
                    IndiciTable.Fill(DS.Indici)

                    ProgC = "Riga: (" & PACK.Riga & ") - Progress: 0"

                    If Not Progressbar Is Nothing Then Progressbar.Value += 1

                    Dim IndiceRow As ModPackDBDataSet.IndiciRow = DS.Indici.Where(Function(x) x.Indice = PACK.Indice).FirstOrDefault
                    Dim IndiceEsiste As Boolean = Not IsNothing(IndiceRow)



                    If IndiceEsiste = True Then
                        ProgC += " 1"
                        '6.1 - Prima controlla che sia già stato caricato in passato uno uguale (in base al suo indice)
                        ImballoName = IndiceRow.Imballo


                        If DS.Imballi.Where(Function(x) x.Imballo = ImballoName).Any Then

                            ProgC += " 2"
                            '6.1.1 - Se trova un indice corrispondente controlla che esista effettivamente anche un imballo
                            '        corrispondente, se è tutto a posto carica la riga nella OrdiniTable

                            If New_CheckRIga(PACK, ImballoName) Then
                                ProgC += " 3 "


                                With PACK
                                    OrdiniTable.Insert(.NumeroOrdine, .Riga, ImballoName, .Indice, .Qt, .Cliente, .Codice, .Commessa, .L, .P, .H, .Tipo, .Zoccoli,
                                                       .Rivestimento, .TipoRivestimento, .Note, .DataConsegna, .HT, .DT, .BM, .Rivest_Tot, Magazzino, .Diagonali, False, False, False, Date.Today.Date)
                                End With

                                ProgC += " 4 "

                            Else

                                Dim NuovoNome As String = NomeImballo.CreaNome(PACK.Tipo, PACK.HT)

                                '6.1.1 - L'indice esiste, l'imballo esiste ma le righe non corrispondono. Elimina l'indice si comporta come se fosse una nuovariga
                                ProgC += " 6 "

                                LOG.Write("Riga (" & PACK.Riga & ") l'indice " & PACK.Indice & " non corrisponde a " & ImballoName & " verrà cercato un imballo corrispondente o creato " & NuovoNome)

                                ImballoName = NuovoNome
                                IndiciTable.Delete(IndiceRow.Id, IndiceRow.Imballo, IndiceRow.Indice, IndiceRow.Codice)
                                IndiciTable.Update(DS.Indici)
                                IndiceEsiste = False
                                ProgC += " 7 "


                            End If

                        Else

                            DistintaTable.Fill(DS.Distinta)

                            ProgC += " 9"

                            '6.1.1 - Se esiste in memoria un indice, ma non la riga imballo qualcuno ha messo mani dove non doveva
                            '        Permette comunque di aggiustare le cose CREANDO una riga imballo e una distinta con il vecchio
                            '        Nome dell'imballo
                            Errore.Show("Elaborazione ordine", "Errore relativo al codice " & ImballoName & "." & vbCrLf & "E' stato trovato il suo indice di riferimento ma non la riga relativa all'imballo" & vbCrLf & "La riga verrà ora ricreata dinamicamente con l'imballo che vi era associato")

                            Dim Nuovo As New NuovoImballo With {.RigaOrdine = PACK, .Nome = ImballoName}

                            If DS.Distinta.Where(Function(x) x.Imballo = ImballoName).Any = True Then

                                '6.1.1 - Esiste la distinta ma non la riga imballo - Viene creata solo la riga imballo
                                Nuovo.CreaDaOrdine(PACK, False, True, False)

                                With PACK
                                    OrdiniTable.Insert(.NumeroOrdine, .Riga, ImballoName, .Indice, .Qt, .Cliente, .Codice, .Commessa, .L, .P, .H, .Tipo, .Zoccoli,
                                                       .Rivestimento, .TipoRivestimento, .Note, .DataConsegna, .HT, .DT, .BM, .Rivest_Tot, Magazzino, .Diagonali, False, False, False, Date.Today.Date)
                                End With

                                ProgC += " 10"


                            Else

                                '6.1.1 - Non esiste nè distinta nè riga imballo - Vengono create entrambe
                                Nuovo.CreaDaOrdine(PACK, True, True, False)

                                Dim Row As RigaOrdineINPUT = SQL.GetImballInputFromImballoName(ImballoName)

                                With PACK
                                    OrdiniTable.Insert(.NumeroOrdine, .Riga, ImballoName, .Indice, .Qt, .Cliente, .Codice, .Commessa, .L, .P, .H, .Tipo, .Zoccoli,
                                                       .Rivestimento, .TipoRivestimento, .Note, .DataConsegna, .HT, .DT, .BM, .Rivest_Tot, Magazzino, .Diagonali, False, False, False, Date.Today.Date)
                                End With

                                ProgC += " 11"


                            End If

                        End If

                    End If

                    If IndiceEsiste = False Then
                        ProgC += " 12"
                        '6.2 - Non esiste in memoria un indice come quello della riga dell'ordine

                        '6.3 - Associa il nome progressivo disponibile all'imballo che si sta creando (potrebbe anche non essere
                        '      Utilizzato, in caso venga trovato un imballo corrispondente

                        ImballoName = NomeImballo.CreaNome(PACK.Tipo, PACK.HT)

                        '7 - Confronta le caratteristiche dell'imballo in input con gli altri in memoria e cerca un'imballo corrispondente

                        'If CONFRONTO_IMBALLI(PACK) = False Then
                        If New_ConfrontoImballi(PACK) = False Then

                            ProgC += " 13"
                            '7.1 - Se non trova niente, crea l'imballo da zero con il codice creato in precedenza
                            If Not Label Is Nothing Then Label.Text = "Creazione imballo " & ImballoName

                            Dim Nuovo As New NuovoImballo With {.RigaOrdine = PACK, .Nome = ImballoName}
                            Nuovo.CreaDaOrdine(PACK, True, True, True) ' INSERT in Distinta, Imballi, Indici
                            NomeImballo.AggiornaConteggio()
                            '7.1.1 - L'imballo appena creato viene trasformato in oggetto RigaOrdine

                            With PACK
                                OrdiniTable.Insert(.NumeroOrdine, .Riga, ImballoName, .Indice, .Qt, .Cliente, .Codice, .Commessa, .L, .P, .H, .Tipo, .Zoccoli,
                                                       .Rivestimento, .TipoRivestimento, .Note, .DataConsegna, .HT, .DT, .BM, .Rivest_Tot, Magazzino, .Diagonali, False, False, False, Date.Today.Date)
                            End With

                            ListaNuovi.Add(ImballoName)
                            ContaNuovi += 1
                            ProgC += " 14"

                        Else
                            '7.2 - Se trova un imballo corrispondente associa il nome di quell'imballo all'indice di quello in input
                            ProgC += " 15"
                            'Debug.WriteLine("E' stato trovato un imballo corrispondente: " & PACK.Indice & " = " & ImballoName)

                            Dim Nuovo As New NuovoImballo With {.RigaOrdine = PACK, .Nome = ImballoName}
                            Nuovo.CreaDaOrdine(PACK, False, False, True) 'INSERT in Indici

                            '7.2.1 - L'imballo appena creato viene trasformato in oggetto RigaOrdine
                            With PACK
                                OrdiniTable.Insert(.NumeroOrdine, .Riga, ImballoName, .Indice, .Qt, .Cliente, .Codice, .Commessa, .L, .P, .H, .Tipo, .Zoccoli,
                                                       .Rivestimento, .TipoRivestimento, .Note, .DataConsegna, .HT, .DT, .BM, .Rivest_Tot, Magazzino, .Diagonali, False, False, False, Date.Today.Date)
                            End With
                            ProgC += " 16"

                        End If
                    End If

                    Dim ts4 As New TimeSpan(Now.Ticks)
                    ProgC += " Completed! (" & ImballoName & ") Time " & (ts4 - ts1).TotalSeconds.ToString
                    LOG.Write(ProgC)



                Next

            Catch ex As Exception
                Errore.Show("Elaborazione ordine", ex.Message)
            End Try

            Try

                Dim ts2 As New TimeSpan(Now.Ticks)

                If Not Notify Is Nothing Then
                    Notify.BalloonTipTitle = "ModPack"
                    Notify.BalloonTipText = "Caricamento ordine '" & NumeroOrdine & "' completato in " & (ts2 - ts1).TotalSeconds.ToString & " secondi"
                    Notify.ShowBalloonTip(2000)
                End If

                LOG.Write("Tempo elaborazione ordine: " & (ts2 - ts1).TotalSeconds.ToString & " secondi")

                If Not Progressbar Is Nothing Then Progressbar.Value = 0
                If Not Label Is Nothing Then Label.Text = "Caricamento completato in " & (ts2 - ts1).TotalSeconds.ToString & " secondi"

                '8 - Se la lista dei nuovi imballi non è vuota permette di stamparla 
                If ListaNuovi.Count > 0 Then
                    If MsgBox("Durante la presa in carico dell'ordine sono stati creati" & vbCrLf &
                    ContaNuovi & " imballi nuovi. Vuoi stampare la lista? (Totale: " & ListaNuovi.Count & ")" & vbCrLf & "(La lista resterà in memoria fino alla chiusura dell'applicazione)", vbYesNo, "Imballi Nuovi") = MsgBoxResult.Yes Then
                        MostraNuovi()
                    End If
                End If

            Catch ex As Exception
                Errore.Show("Fine elaborazione ordine", ex.Message)
            End Try


        End Sub

        Public Sub MostraNuovi()
            If ListaNuovi.Count > 0 Then

                If My.Settings.ListaNuoviExcel = True Then

                    If My.Computer.FileSystem.FileExists(My.Settings.ExcelPath) Then
                        ListaNuoviExcel(ListaNuovi)
                    Else
                        MsgBox("Non è stato trovato l'eseguibile Excel indicato")
                        ListaNuoviTesto(ListaNuovi)
                    End If
            Else
                    ListaNuoviTesto(ListaNuovi)
                End If
            End If
        End Sub
        Private Sub ListaNuoviTesto(ByVal Lista As List(Of String))

            If Not Lista.Count = 0 Then
                'Se la lista contiene imballi nuovi permette la stampa degli stessi


                Dim TABLE As New ModPackDBDataSet.ImballiDataTable

                    Using DA As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
                        DA.Fill(TABLE)
                    End Using

                    Dim ListaNuovi As New List(Of RigaImballi)

                    For Each N As String In Lista
                        For Each R As ModPackDBDataSet.ImballiRow In TABLE
                            If R.Imballo = N Then

                                Dim Nuovo As New RigaImballi With {
                                    .Nome = R.Imballo,
                                    .L = R.L,
                                    .P = R.P,
                                    .H = R.H,
                                    .TIpo = R.Tipo,
                                    .Zoccoli = R.Zoccoli,
                                    .Rivestimento = R.Rivestimento,
                                    .TipoRivestimento = R.Tipo_Rivestimento,
                                    .HT = R.HT,
                                    .DT = R.DT,
                                    .BM = R.BM,
                                    .Diagonali = R.Diagonali,
                                    .GradiF = R.Gradi_F,
                                    .GradiT = R.Gradi_T,
                                    .PrimoMorale = R.Primo_Morale,
                                    .M2 = R.M2,
                                    .M3 = R.M3,
                                    .Prezzo = R.Prezzo,
                                    .DataCreazione = R.Data_Creazione}

                                ListaNuovi.Add(Nuovo)
                            End If

                        Next
                    Next


                    Dim File As String = My.Computer.FileSystem.SpecialDirectories.Temp & "Output.txt"

                    IO.File.WriteAllText(File, "")

                    For Each R As RigaImballi In ListaNuovi

                        Dim Descrizione As String = NomeImballo.CreaDescrizione(R.L, R.P, R.H, R.Zoccoli, R.TIpo, R.HT, R.DT, R.BM, R.M3, R.Rivestimento, R.TipoRivestimento)
                        IO.File.AppendAllText(File, R.Nome & vbTab & vbTab & Descrizione & vbTab & vbTab & "€ " & R.Prezzo.ToString("f2") & vbCrLf)

                    Next
                    ListaNuovi.Clear()
                    Process.Start(File)

                End If

        End Sub
        Private Sub ListaNuoviExcel(ByVal lista As List(Of String))



            Dim Descrizione As String
                Dim TABLE As New ModPackDBDataSet.ImballiDataTable

                Using DA As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
                    DA.Fill(TABLE)
                End Using

                Dim ListaNuovi As New List(Of RigaImballi)

                For Each N As String In lista
                    For Each R As ModPackDBDataSet.ImballiRow In TABLE
                        If R.Imballo = N Then

                            Dim Nuovo As New RigaImballi With {
                                        .Nome = R.Imballo,
                                        .L = R.L,
                                        .P = R.P,
                                        .H = R.H,
                                        .TIpo = R.Tipo,
                                        .Zoccoli = R.Zoccoli,
                                        .Rivestimento = R.Rivestimento,
                                        .TipoRivestimento = R.Tipo_Rivestimento,
                                        .HT = R.HT,
                                        .DT = R.DT,
                                        .BM = R.BM,
                                        .Diagonali = R.Diagonali,
                                        .GradiF = R.Gradi_F,
                                        .GradiT = R.Gradi_T,
                                        .PrimoMorale = R.Primo_Morale,
                                        .M2 = R.M2,
                                        .M3 = R.M3,
                                        .Prezzo = R.Prezzo,
                                        .DataCreazione = R.Data_Creazione}
                            ListaNuovi.Add(Nuovo)
                        End If

                    Next
                Next


                Dim DTB = New DataTable, RWS As Integer

                DTB.Columns.Add("Codice")
                DTB.Columns.Add("Descrizione")
                DTB.Columns.Add("M³")
                DTB.Columns.Add("Prezzo")


                Dim DRW As DataRow

                'For RWS = 0 To lista.Count - 1 ' FILL DTB WITH DATAGRIDVIEW
                For RWS = 0 To ListaNuovi.Count - 1
                    DRW = DTB.NewRow

                    With ListaNuovi.Item(RWS)
                        Descrizione = NomeImballo.CreaDescrizione(.L, .P, .H, .Zoccoli, .TIpo, .HT, .DT, .BM, .M3, .Rivestimento, .TipoRivestimento)
                    End With


                    DRW(DTB.Columns(0).ColumnName.ToString) = lista.Item(RWS)
                    DRW(DTB.Columns(1).ColumnName.ToString) = Descrizione
                    DRW(DTB.Columns(2).ColumnName.ToString) = ListaNuovi.Item(RWS).M3
                DRW(DTB.Columns(3).ColumnName.ToString) = ListaNuovi.Item(RWS).Prezzo

                DTB.Rows.Add(DRW)

                Next

                DTB.AcceptChanges()

                Dim DST As New DataSet
                DST.Tables.Add(DTB)
                Dim FLE As String = My.Computer.FileSystem.SpecialDirectories.Temp & "Output.xml" ' PATH AND FILE NAME WHERE THE XML WIL BE CREATED (EXEMPLE: C:\REPS\XML.xml)
                DTB.WriteXml(FLE)
                Dim EXL As String = My.Settings.ExcelPath ' PATH OF/ EXCEL.EXE IN YOUR MICROSOFT OFFICE
                Shell(Chr(34) & EXL & Chr(34) & " " & Chr(34) & FLE & Chr(34), vbNormalFocus) ' OPEN XML WITH EXCEL

        End Sub


    End Module
End Namespace
