Module Module_GeneraFileCO

    Public Sub Genera_File(ByVal DS As DataSet, ByVal NomeFile As String, ByRef SaveFile As String)

        'Genera file conferma d'ordine per MODINE per automatizzare la creazione degli ordini

        Dim SFDialog As New SaveFileDialog With {.FileName = NomeFile, .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments, .Title = "Scegliere destinazione per file CO"}





        If SFDialog.ShowDialog = DialogResult.OK Then

            SaveFile = SFDialog.FileName

            Select Case My.Settings.CO_Tipo

                Case "xml"
                    SaveFile += ".xml"
                    Genera_XML(DS, NomeFile, SaveFile)

                Case "txt"
                    SaveFile += ".txt"
                    Genera_TXT(DS, NomeFile, SaveFile)

                Case Else
                    MsgBox("Controllare tipo CO inserito (in preferenze)")

            End Select



        End If

    End Sub

    Private Sub Genera_TXT(ByVal DS As DataSet, ByVal NomeFile As String, ByVal SaveFile As String)

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

    Private Sub Genera_XML(ByVal DS As DataSet, ByVal NomeFile As String, ByVal SaveFile As String)

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
                '.WriteValue(Line.Item(11).ToString)
                .WriteValue(FormatDateTime(Line.Item(11), DateFormat.ShortDate))
                .WriteEndElement()

                .WriteEndElement()

            Next

            .WriteEndElement()
            .Close()

        End With


    End Sub
End Module
