Imports Newtonsoft.Json

Module Module_GeneraFileCO

    Public Sub Genera_File(ByVal DS As DataSet, ByVal NomeFile As String, ByRef SaveFile As String)

        'Genera file conferma d'ordine per MODINE per automatizzare la creazione degli ordini

        Dim SFDialog As New SaveFileDialog With {.FileName = NomeFile, .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments, .Title = "Scegliere destinazione per file CO", .Filter = "Conferma D'Ordine|*.*"}

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
    Public Sub Genera_Temp(ByVal DS As DataSet, ByVal Nomefile As String, ByRef savefile As String)
        savefile = My.Computer.FileSystem.SpecialDirectories.Temp & "\" & Nomefile

        Select Case My.Settings.CO_Tipo

            Case "xml"
                savefile += ".xml"
                Genera_XML(DS, Nomefile, savefile)

            Case "txt"
                savefile += ".txt"
                Genera_TXT(DS, Nomefile, savefile)

            Case Else
                MsgBox("Controllare tipo CO inserito (in preferenze)")

        End Select
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
        DS.Tables(0).WriteXml(SaveFile)
    End Sub

End Module
