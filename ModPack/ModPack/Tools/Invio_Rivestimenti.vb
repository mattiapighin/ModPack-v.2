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

            Dim TIPO As String = riga.Tipo


            For Each row As ModPackDBDataSet.Setup_RivestRow In SetupRiv
                If row.Tipo = TIPO Then

                    B = "B) " & riga.L + row._BX_ & " x " & riga.P + row._BY_ & " = " & riga.Qt
                    C = "C) " & riga.L + row._CX_ & " x " & riga.P + row._CY_ & " = " & riga.Qt
                    F = "F) " & riga.L + row._FX_ & " x " & riga.H + row._FY_ & " = " & riga.Qt * 2
                    T = "T) " & riga.P + row._TX_ & " x " & riga.H + row._TY_ & " = " & riga.Qt * 2

                    If Not row.IsNoteNull Then Note1 = row.Note

                End If
            Next



        End Sub

    End Module
End Namespace