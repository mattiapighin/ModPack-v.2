Namespace Rivestimenti
    Module Invio_Rivestimenti

        Dim B As String
        Dim C As String
        Dim F As String
        Dim T As String
        Dim Note1 As String
        Dim Note2 As String

        Dim SetupRiv As New ModPackDBDataSet.Setup_RivestDataTable

        Public Sub RiempiDataSetRivestimenti()
            Using TA As New ModPackDBDataSetTableAdapters.Setup_RivestTableAdapter
                TA.Fill(SetupRiv)
            End Using
        End Sub


        Public Sub Invia(ByVal Ordine As String)

            RiempiDataSetRivestimenti()

            Dim xml = XDocument.Load(My.Settings.XMLpath)
            Dim Ip_sezionatrice As String = xml.<Data>.<IP_Sezionatrice>.Value

            'Controlla che il pc della sezionatrice sia connesso
            If My.Computer.Network.Ping(Ip_sezionatrice) Then

                Try

                    Dim Path As String = "\\" & Ip_sezionatrice & "\sezionatrice\ModPack"
                    'Dim Path As String = My.Computer.FileSystem.SpecialDirectories.Desktop

                    Dim Righe As New List(Of String)
                    Dim Magazzino As String = ""

                    Using TA As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
                        Using Table As New ModPackDBDataSet.OrdiniDataTable

                            TA.Fill(Table)

                            For Each Row As ModPackDBDataSet.OrdiniRow In Table.Rows
                                If Row.Ordine = Ordine Then
                                    If Row.Rivestimento = True Then

                                        If Not Row.IsMagazzinoNull Then
                                            Magazzino = Row.Magazzino
                                        End If

                                        Dim ID As String = Row.Riga & DateTime.Now.Second & DateTime.Now.Millisecond & Row.Indice & Row.Id
                                        Dim Imballo As String = Row.Imballo & " (" & Row.Codice & ")"
                                        Dim Qt As String = Row.Qt
                                        Dim Rivestimento As String = ""
                                        If Not Row.IsTipo_RivestimentoNull Then Rivestimento = SQL.GetSQLValue("SELECT Descrizione FROM Rivestimenti WHERE Tipo_Rivestimento = '" & Row.Tipo_Rivestimento & "'")


                                        B = ""
                                        C = ""
                                        F = ""
                                        T = ""
                                        Note1 = ""
                                        Note2 = ""

                                        RiempiStringa(Row)

                                        If Not Row.IsNoteNull Then Note2 = Row.Note
                                        If Not Row.IsRivest_TotNull Then Note2 += " " & Row.Rivest_Tot

                                        Righe.Add(Imballo & "|" & Qt & "|" & Rivestimento & "|" & B & "|" & C & "|" & F & "|" & T & "|" & Note1 & "|" & Note2 & "|" & ID)

                                    End If
                                End If
                            Next

                        End Using
                    End Using

                    Dim NomeFile As String = Path & "\" & "MAG" & Magazzino & " RIV-" & Ordine & ".riv"

                    If Not My.Computer.FileSystem.DirectoryExists(Path) Then
                        'Controlla che esista la directory ModPack se no la crea
                        My.Computer.FileSystem.CreateDirectory(Path)
                        MsgBox("Directory Creata")
                    End If

                    If IO.File.Exists(NomeFile) Then
                        'Controlla che non sia già stata creata la lista
                        If MsgBox("Il file esiste già, vuoi dargli un'altro nome?", vbYesNo, "Nome") = MsgBoxResult.Yes Then
                            Dim NuovoNome As String = InputBox("Nome:", "Rivestimenti", IO.Path.GetFileNameWithoutExtension(NomeFile))
                            If String.IsNullOrEmpty(NomeFile) Then Exit Sub

                            NomeFile = ""
                            NomeFile = Path & "\" & "MAG" & Magazzino & " RIV-" & NuovoNome & ".riv"

                        Else
                            Exit Sub
                        End If

                    End If

                    IO.File.WriteAllLines(NomeFile, Righe)
                    MsgBox("File '" & IO.Path.GetFileNameWithoutExtension(NomeFile) & "' inviato!", vbInformation, "Rivestimenti")
                Catch ex As Exception
                    MsgBox(ex)
                End Try

            Else
                MsgBox("Sezionatrice non raggiungibile!" & vbCrLf & "Controllare la connessione", vbCritical, "Test")
            End If


        End Sub
        Public Sub RiempiStringa(riga As ModPackDBDataSet.OrdiniRow)

            B = ""
            C = ""
            F = ""
            T = ""

            RiempiDataSetRivestimenti()
            Dim Row As ModPackDBDataSet.Setup_RivestRow = SetupRiv.Where(Function(X) X.Tipo = riga.Tipo).FirstOrDefault

            B = "B) " & riga.L + Row._BX_ & " x " & riga.P + Row._BY_ & " = " & riga.Qt
            C = "C) " & riga.L + Row._CX_ & " x " & riga.P + Row._CY_ & " = " & riga.Qt
            F = "F) " & riga.L + Row._FX_ & " x " & riga.H + Row._FY_ & " = " & riga.Qt * 2
            T = "T) " & riga.P + Row._TX_ & " x " & riga.H + Row._TY_ & " = " & riga.Qt * 2

            If Not Row.IsNoteNull Then Note1 = Row.Note

            ' #### ECCEZIONI ####

            Select Case Row.Tipo
                Case "GST"
                    B = ""
            End Select

        End Sub

        Public Sub InviaPerSettimana(ByVal Ordine As String)

            Dim DS As New ModPackDBDataSet
            Dim OrdiniTable As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
            Dim RivestTable As New ModPackDBDataSetTableAdapters.RivestimentiTableAdapter
            Dim RivSettings As New ModPackDBDataSetTableAdapters.Setup_RivestTableAdapter

            OrdiniTable.Fill(DS.Ordini)
            RivestTable.Fill(DS.Rivestimenti)
            RivSettings.Fill(DS.Setup_Rivest)

            Dim xml = XDocument.Load(My.Settings.XMLpath)
            Dim Ip_sezionatrice As String = xml.<Data>.<IP_Sezionatrice>.Value
            Dim Messaggio As Boolean = False

            'Controlla che il pc della sezionatrice sia connesso
            If My.Computer.Network.Ping(Ip_sezionatrice) Then

                Try

                    Dim Path As String = "\\" & Ip_sezionatrice & "\sezionatrice\ModPack"
                    'Dim path As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\ProvaRivest"

                    If Not My.Computer.FileSystem.DirectoryExists(Path) Then
                        'Controlla che esista la directory ModPack se no la crea
                        My.Computer.FileSystem.CreateDirectory(Path)
                        MsgBox("Directory Creata")
                    End If

                    Dim ListaRighe As List(Of ModPackDBDataSet.OrdiniRow)
                    ListaRighe = DS.Ordini.Where(Function(X) X.Ordine = Ordine).Where(Function(y) y.Rivestimento = True).Where(Function(z) z.Evaso = False).ToList

                    DLG_ProgressBar.LB_Descrizione.Text = "Invio file rivestimenti"
                    DLG_ProgressBar.PBar.Maximum = ListaRighe.Count
                    DLG_ProgressBar.PBar.Value = 0
                    DLG_ProgressBar.Show()

                    For Each Row As ModPackDBDataSet.OrdiniRow In ListaRighe

                        DLG_ProgressBar.PBar.Value += 1

                        B = ""
                        C = ""
                        F = ""
                        T = ""
                        Note1 = ""
                        Note2 = ""

                        Dim ID As String = Row.Indice & Row.Id
                        Dim Imballo As String = Row.Imballo & " (" & Row.Codice & ")"
                        Dim Qt As String = Row.Qt
                        Dim Rivestimento As String = DS.Rivestimenti.Where(Function(X) X.Tipo_Rivestimento = Row.Tipo_Rivestimento).Select(Function(y) y.Descrizione).FirstOrDefault
                        Dim Magazzino As String = Row.Magazzino

                        Dim SetupRiv As ModPackDBDataSet.Setup_RivestRow
                        SetupRiv = DS.Setup_Rivest.Where(Function(X) X.Tipo = Row.Tipo).FirstOrDefault

                        With SetupRiv
                            B = "B) " & Row.L + ._BX_ & " x " & Row.P + ._BY_ & " = " & .NB * Row.Qt
                            C = "C) " & Row.L + ._CX_ & " x " & Row.P + ._CY_ & " = " & .NC * Row.Qt
                            F = "F) " & Row.L + ._FX_ & " x " & Row.H + ._FY_ & " = " & .NF * Row.Qt
                            T = "T) " & Row.P + ._TX_ & " x " & Row.H + ._TY_ & " = " & .NT * Row.Qt
                        End With

                        Note2 = Row.Note
                        Note2 += " " & Row.Rivest_Tot

                        Dim Riga As String = Imballo & "|" & Qt & "|" & Rivestimento & "|" & B & "|" & C & "|" & F & "|" & T & "|" & Note1 & "|" & Note2 & "|" & ID & "|" & Row.Data_Consegna & vbCrLf

                        '-------------------------------------------------------
                        'CONTROLLA CHE SUL FILE NON SIA GIA STATA SCRITTA LA STESSA RIGA (INDICE+ID ORDINE)
                        Dim Scrivere As Boolean = True

                        If IO.File.Exists(Path & "\" & "MAG" & Magazzino & "-SETT " & FunzioniVarie.Get_WK(Row.Data_Consegna) & ".riv") Then

                            Dim RigheSulFile() As String = IO.File.ReadAllLines(Path & "\" & "MAG" & Magazzino & "-SETT " & FunzioniVarie.Get_WK(Row.Data_Consegna) & ".riv")

                            For Each RigaFile As String In RigheSulFile

                                If Split(RigaFile, "|")(9) = ID Then
                                    Scrivere = False
                                    Messaggio = True
                                End If

                            Next

                        End If
                        '-------------------------------------------------------

                        If Scrivere = True Then IO.File.AppendAllText(Path & "\" & "MAG" & Magazzino & "-SETT " & FunzioniVarie.Get_WK(Row.Data_Consegna) & ".riv", Riga)

                    Next

                    DLG_ProgressBar.Close()

                    If Messaggio = True Then MsgBox("Il file conteneva righe già inviate alla sezionatrice che non sono state scritte", vbOKOnly, "Invio rivestimenti")
                    MsgBox("Rivestimenti inviati!", vbOKOnly, "Invia Rivestimenti")

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Else
                MsgBox("Sezionatrice non raggiungibile!" & vbCrLf & "Controllare la connessione", vbCritical, "Test")
            End If

        End Sub

    End Module
End Namespace