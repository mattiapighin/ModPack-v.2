Namespace Rivestimenti
    Module XML_Sezionatrice

        Structure RigaParte
            Dim Descrizione, Materiale As String
            Dim X, Y As Decimal
            Dim Qt As Integer
        End Structure
        Structure Imballo
            Dim Imballo, Codice, Commessa, Cliente, Ordine, Magazzino, Consegna, Note As String
            Dim QT As Integer
            Dim Righe As List(Of RigaParte)
        End Structure

        Public Sub CreaXMLSezionatrice(ByVal Lista As List(Of Imballo), Optional Path As String = "")

            If Path = "" Then
                'Se non è impostata la directory alla chiamata la fa scegliere con una dialog
                Dim SaveFileD As New SaveFileDialog With {.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments, .DefaultExt = ".xml", .Filter = "file XML rivestimenti|*.xml", .FileName = Date.Today.Day & Date.Today.Month & Date.Today.Year}

                If SaveFileD.ShowDialog = DialogResult.OK Then
                    Path = SaveFileD.FileName
                    SaveFileD.Dispose()
                Else
                    SaveFileD.Dispose()
                    Exit Sub
                End If

            End If


            Dim settings As New System.Xml.XmlWriterSettings() With {.Indent = True}
                Dim XmlWrt As System.Xml.XmlWriter = System.Xml.XmlWriter.Create(Path, settings)

                With XmlWrt

                    .WriteStartDocument()
                    .WriteStartElement("Rivestimenti")

                    For Each Row As Imballo In Lista

                        .WriteStartElement("Riga")

                        .WriteStartElement("Imballo")
                        .WriteValue(Row.Imballo)
                        .WriteEndElement()

                        .WriteStartElement("Codice")
                        .WriteValue(Row.Codice)
                        .WriteEndElement()

                        .WriteStartElement("Commessa")
                        .WriteValue(Row.Commessa)
                        .WriteEndElement()

                        .WriteStartElement("Cliente")
                        .WriteValue("Modine")
                        .WriteEndElement()

                        .WriteStartElement("Ordine")
                        .WriteValue(Row.Ordine)
                        .WriteEndElement()

                        .WriteStartElement("Qt")
                        .WriteValue(Row.QT)
                        .WriteEndElement()

                        .WriteStartElement("Magazzino")
                        .WriteValue(Row.Magazzino)
                        .WriteEndElement()

                        .WriteStartElement("Consegna")
                        .WriteValue(Row.Consegna)
                        .WriteEndElement()

                        .WriteStartElement("Note")
                        .WriteValue(Row.Note)
                        .WriteEndElement()

                        .WriteStartElement("Rivestimenti")

                        For Each RivRow As RigaParte In Row.Righe

                            .WriteStartElement("Row")

                            .WriteStartElement("Descrizione")
                            .WriteValue(RivRow.Descrizione)
                            .WriteEndElement()

                            .WriteStartElement("X")
                            .WriteValue(RivRow.X)
                            .WriteEndElement()

                            .WriteStartElement("Y")
                            .WriteValue(RivRow.Y)
                            .WriteEndElement()

                            .WriteStartElement("Qt")
                            .WriteValue(RivRow.Qt)
                            .WriteEndElement()

                            .WriteStartElement("Materiale")
                            .WriteValue(RivRow.Materiale)
                            .WriteEndElement()

                            .WriteEndElement()

                        Next

                    '-------------------------------

                    .WriteEndElement()
                        .WriteEndElement()

                    Next

                    .WriteEndElement()
                    .WriteEndDocument()

                MsgBox("File " & IO.Path.GetFileNameWithoutExtension(Path) & " creato!", vbInformation, "Creazione XML sezionatrice")
                .Close()

                End With


        End Sub
        Public Sub CreaRivestimenti(ByVal List As List(Of ModPackDBDataSet.OrdiniRow))

            Dim ListaImballi As New List(Of Imballo)

            Dim DS As New ModPackDBDataSet
            Dim OrdiniTable As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
            Dim RivestTable As New ModPackDBDataSetTableAdapters.Setup_RivestTableAdapter
            Dim DescrizTable As New ModPackDBDataSetTableAdapters.RivestimentiTableAdapter

            OrdiniTable.Fill(DS.Ordini)
            RivestTable.Fill(DS.Setup_Rivest)
            DescrizTable.Fill(DS.Rivestimenti)

            For Each Row As ModPackDBDataSet.OrdiniRow In List.Where(Function(X) X.Rivestimento = True)

                Try

                    Dim Setup As ModPackDBDataSet.Setup_RivestRow = DS.Setup_Rivest.Where(Function(X) X.Tipo = Row.Tipo).First
                    Dim Descrizione As String = DS.Rivestimenti.Where(Function(X) X.Tipo_Rivestimento = Row.Tipo_Rivestimento).Select(Function(y) y.Descrizione).FirstOrDefault

                    Dim ImbaRow As New Imballo With {.Imballo = Row.Imballo, .Codice = Row.Codice, .Commessa = Row.Commessa, .Cliente = "Modine", .Consegna = "SETT. " & FunzioniVarie.Get_WK(Row.Data_Consegna), .Magazzino = Row.Magazzino, .Note = "", .Ordine = Row.Ordine, .QT = Row.Qt}

                    If Not Row.IsNoteNull Then ImbaRow.Note += Row.Note
                    If Not Row.IsRivest_TotNull Then ImbaRow.Note += vbCrLf & Row.Rivest_Tot

                    Dim BASE As New RigaParte With {.Descrizione = "B", .X = Row.L + Setup._BX_, .Y = Row.P + Setup._BY_, .Qt = Row.Qt * Setup.NB, .Materiale = Descrizione}
                    Dim COPERCHIO As New RigaParte With {.Descrizione = "C", .X = Row.L + Setup._CX_, .Y = Row.P + Setup._CY_, .Qt = Row.Qt * Setup.NC, .Materiale = Descrizione}
                    Dim FIANCATE As New RigaParte With {.Descrizione = "F", .X = Row.L + Setup._FX_, .Y = Row.H + Setup._FY_, .Qt = Row.Qt * Setup.NF, .Materiale = Descrizione}
                    Dim TESTE As New RigaParte With {.Descrizione = "T", .X = Row.P + Setup._TX_, .Y = Row.H + Setup._TY_, .Qt = Row.Qt * Setup.NT, .Materiale = Descrizione}

                    Dim ListaRighe As New List(Of RigaParte)
                    ListaRighe.AddRange({BASE, COPERCHIO, FIANCATE, TESTE})

                    ImbaRow.Righe = ListaRighe

                    ListaImballi.Add(ImbaRow)

                Catch ex As Exception
                    MsgBox("Errore su riga " & Row.Riga & " (" & Row.Imballo & ")")
                End Try

            Next

            Dim NomeFile As String = My.Settings.RivestimentiPATH & "\" & Date.Today.Day & Date.Today.Month & Date.Today.Year & "_" & Date.Now.Hour & Date.Now.Minute & Date.Now.Second & ".xml"

            CreaXMLSezionatrice(ListaImballi, NomeFile)

        End Sub

    End Module
End Namespace