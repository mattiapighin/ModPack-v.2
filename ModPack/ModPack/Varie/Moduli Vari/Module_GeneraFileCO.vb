Module Module_GeneraFileCO

    Public Sub Genera_File(ByVal DS As DataSet, ByVal NomeFile As String)

        'Genera file conferma d'ordine per MODINE per automatizzare la creazione degli ordini
        Dim SaveFile As String = ""

        Genera_XML(DS, NomeFile, SaveFile)

        'Lista dei files da allegare all'email
        Dim ListaFiles As New List(Of String)
        ListaFiles.Add(SaveFile) 'solo il file appena generato

        If MsgBox("Vuoi selezionare il file PDF da allegare all'email?", vbYesNo, "Invio conferma d'ordine") = MsgBoxResult.Yes Then
            'Se si stampa su pdf selezionare il file per allegare anche quello alla mail, altrimenti inviare solo il file txt
            Dim OpenFile As New OpenFileDialog With {.Filter = "File PDF Conferma Ordine|*.pdf", .DefaultExt = "*.pdf", .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop}
            If OpenFile.ShowDialog = DialogResult.OK Then
                'Aggiunge il file pdf agli allegati
                ListaFiles.Add(OpenFile.FileName)
            End If

        End If

        Mail.Invia("Invio Conferma Ordine " & IO.Path.GetFileNameWithoutExtension(SaveFile), "ATTENZIONE: Questo è un messaggio generato automaticamente. Si prega pertanto di non rispondere alla casella mittente. Per eventuali comunicazioni contatta il numero di telefono 0432-823973 o l'indirizzo e-mail  imballaggi@bicciatoserafino.com.", ListaFiles, True)

    End Sub

    Private Sub Genera_TXT(ByVal DS As DataSet, ByVal NomeFile As String, ByRef SaveFile As String)

        SaveFile = My.Computer.FileSystem.SpecialDirectories.Temp & "\CO" & NomeFile & ".txt" 'percorso in cui verrà salvato il file
        Dim Righe As New List(Of String) 'Righe dell'ordine

        For Each Line As DataRow In DS.Tables(0).Rows
            'Dataset riempito al momento della stampa della CO
            With Line
                Righe.Add(.Item(15) & "|" & .Item(0) & "|" & .Item(1) & "|" & .Item(12) & "|" & .Item(13) & "|" & .Item(2) & "|" & .Item(10) & "|" & .Item(11))
            End With
        Next
        'Salva tutte le righe sul file
        IO.File.AppendAllLines(SaveFile, Righe)
    End Sub

    Private Sub Genera_XML(ByVal DS As DataSet, ByVal NomeFile As String, ByRef SaveFile As String)

        SaveFile = My.Computer.FileSystem.SpecialDirectories.Temp & "\CO" & NomeFile & ".xml"

        Dim settings As New System.Xml.XmlWriterSettings() With {.Indent = True}
        Dim XmlWrt As System.Xml.XmlWriter = System.Xml.XmlWriter.Create(SaveFile, settings)

        NomeFile = "CO" & NomeFile

        With XmlWrt

            .WriteStartDocument()
            .WriteComment("CONFERMA D'ORDINE - " & Date.Today.Date)
            .WriteStartElement(NomeFile.ToString)

            For Each Line As DataRow In DS.Tables(0).Rows

                .WriteStartElement("CODICE")
                .WriteValue(Line.Item(1))

                .WriteStartElement("DISEGNO")
                .WriteValue(Line.Item(12))
                .WriteEndElement()

                .WriteStartElement("COMMESSA")
                .WriteValue(Line.Item(13))
                .WriteEndElement()

                .WriteStartElement("QT")
                .WriteValue(Line.Item(2))
                .WriteEndElement()

                .WriteStartElement("PREZZO")
                .WriteValue(Line.Item(10))
                .WriteEndElement()

                .WriteStartElement("DATA_CONSEGNA")
                .WriteValue(Line.Item(11))
                .WriteEndElement()

                .WriteEndElement()
            Next

            .WriteEndElement()
            .Close()

        End With


    End Sub
End Module
