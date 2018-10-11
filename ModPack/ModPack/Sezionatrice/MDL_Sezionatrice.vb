Namespace Sezionatrice
    Module MDL_Sezionatrice

        Dim DS As New ModPackDBDataSet
        Dim TableRivestimenti As New ModPackDBDataSetTableAdapters.RivestimentiTableAdapter
        Dim TableSetupRivest As New ModPackDBDataSetTableAdapters.Setup_RivestTableAdapter
        Dim TableOrdini As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter

        'ID | Magazzino | Settimana | Ordine | Imballo | TipoImballo | Disegno | Commessa | Qt | Rivestimento | TipoRivestimento | BX | BY | BN | CX | CY | CN | FX | FY | FN | TX | TY | TN | NOTE

        Private Structure RigaRivestimento

            Dim ID As Integer
            Dim Magazzino As String
            Dim Settimana As String
            Dim Ordine As String
            Dim Imballo As String
            Dim TipoImballo As String
            Dim Disegno, Commessa As String
            Dim Qt As Integer
            Dim Rivestimento As Boolean
            Dim TipoRivestimento As String

            Dim BX, BY, BN As Integer
            Dim CX, CY, CN As Integer
            Dim FX, FY, FN As Integer
            Dim TX, TY, TN As Integer

            Dim Note As String
            Dim Fatto As Boolean

        End Structure

        Private Sub FillAll()
            TableRivestimenti.Fill(DS.Rivestimenti)
            TableSetupRivest.Fill(DS.Setup_Rivest)
            TableOrdini.Fill(DS.Ordini)
        End Sub
        Private Sub DisposeAll()
            DS.Dispose()
            TableRivestimenti.Dispose()
            TableSetupRivest.Dispose()
            TableOrdini.Dispose()
        End Sub
        Public Sub Crea_File_Rivestimenti(ByVal Destinazione As String, ByVal Ordine As String)

            FillAll() 'Riempie i dataset

            Dim ListaDaScrivere As New List(Of String) 'Creo una lista in cui verranno inserite tutte le righe da scrivere sul file

            For Each Row As ModPackDBDataSet.OrdiniRow In DS.Ordini.Where(Function(X) X.Ordine = Ordine).Where(Function(y) Not String.IsNullOrEmpty(y.Tipo_Rivestimento)).ToList

                Dim Riga As String = CreaRiga(Row)
                ListaDaScrivere.Add(Riga)

            Next

            IO.File.AppendAllLines(Destinazione, ListaDaScrivere) 'Scrive tutte le righe NON DOPPIE appena create sul file destinazione

            MsgBox("File creato!", vbInformation, "Invio rivestimenti")

        End Sub
        Private Function CreaRiga(ByVal Row As ModPackDBDataSet.OrdiniRow) As String

            Dim DescRiv As String = DS.Rivestimenti.Where(Function(X) X.Tipo_Rivestimento = Row.Tipo_Rivestimento).Select(Function(y) y.Descrizione).FirstOrDefault

            Dim Stringa As String = ""

            Dim RigaRIV As New RigaRivestimento With {
                                .ID = Row.Id,
                                .Magazzino = Row.Magazzino,
                                .Settimana = DatePart(DateInterval.WeekOfYear, Row.Data_Consegna, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFourDays),
                                .Ordine = Row.Ordine,
                .Imballo = Row.Imballo,
                .TipoImballo = Row.Tipo,
                .Disegno = Row.Codice,
                .Commessa = Row.Commessa,
                .Qt = Row.Qt,
                .Rivestimento = Row.Rivestimento,
                .TipoRivestimento = DescRiv,
                .BX = 0, .BY = 0, .BN = 0,
                .CX = 0, .CY = 0, .CN = 0,
                .FX = 0, .FY = 0, .FN = 0,
                .TX = 0, .TY = 0, .TN = 0,
                .Note = Row.Note & " " & Row.Rivest_Tot,
                .Fatto = False}

            If Row.Rivestimento = True Then
                With RigaRIV

                    Dim RowRivestimento As ModPackDBDataSet.RivestimentiRow
                    RowRivestimento = DS.Rivestimenti.Where(Function(X) X.Tipo_Rivestimento = Row.Tipo_Rivestimento).First

                    Dim SetupRow As ModPackDBDataSet.Setup_RivestRow
                    SetupRow = DS.Setup_Rivest.Where(Function(X) X.Tipo = Row.Tipo).First


                    .BX = Row.L + SetupRow._BX_
                    .BY = Row.P + SetupRow._BY_
                    .BN = Row.Qt * SetupRow.NB

                    .CX = Row.L + SetupRow._CX_
                    .CY = Row.P + SetupRow._CY_
                    .CN = Row.Qt * SetupRow.NC

                    .FX = Row.L + SetupRow._FX_
                    .FY = Row.H + SetupRow._FY_
                    .FN = Row.Qt * SetupRow.NF

                    .TX = Row.P + SetupRow._TX_
                    .TY = Row.H + SetupRow._TY_
                    .TN = Row.Qt * SetupRow.NT

                    If Not SetupRow.IsNoteNull Then .Note += " " & SetupRow.Note

                End With
            End If

            Stringa = RigaRIV.ID & ";" & RigaRIV.Magazzino & ";" & RigaRIV.Settimana & ";" & RigaRIV.Ordine & ";" & RigaRIV.Imballo & ";" & RigaRIV.TipoImballo & ";" & RigaRIV.Disegno & ";" & RigaRIV.Commessa & ";" & RigaRIV.Qt & ";" & RigaRIV.Rivestimento & ";" & RigaRIV.TipoRivestimento & ";" &
                RigaRIV.BX & ";" & RigaRIV.BY & ";" & RigaRIV.BN & ";" &
                RigaRIV.CX & ";" & RigaRIV.CY & ";" & RigaRIV.CN & ";" &
                RigaRIV.FX & ";" & RigaRIV.FY & ";" & RigaRIV.FN & ";" &
                RigaRIV.TX & ";" & RigaRIV.TY & ";" & RigaRIV.TN & ";" &
                RigaRIV.Note & ";" &
                RigaRIV.Fatto.ToString

            Debug.WriteLine(Stringa)

            Return Stringa
        End Function

        Public Sub RivCreaTemp(ByVal Ordine As String)
            Dim SaveFile As New SaveFileDialog With {.FileName = Ordine, .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop}

            If SaveFile.ShowDialog = DialogResult.OK Then
                Crea_File_Rivestimenti(SaveFile.FileName, Ordine)
            End If

        End Sub


    End Module
End Namespace