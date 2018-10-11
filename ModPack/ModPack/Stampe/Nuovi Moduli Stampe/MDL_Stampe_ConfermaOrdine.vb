Namespace ConfermaOrdine
    Module MDL_Stampe_ConfermaOrdine

        Private NumeroOrdine As String
        Private ListaOrdine As List(Of ModPackDBDataSet.OrdiniRow)

        Private FMT As New StringFormat With {.Alignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter, .LineAlignment = StringAlignment.Center}
        Private WithEvents PRINTER As New System.Drawing.Printing.PrintDocument

        Private DataSet As New ModPackDBDataSet
        Private Imballi_Table As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
        Private Ordini_Table As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
        Private Distinta_Table As New ModPackDBDataSetTableAdapters.DistintaTableAdapter

        Public Sub Stampa(ByVal Ordine As String, Optional Anteprima As Boolean = False)

            Set_Settings(PRINTER, True, "CO" & Ordine)

            Dim DialogStampa As New PrintDialog With {.Document = PRINTER}

            If DialogStampa.ShowDialog = DialogResult.OK Then

                NumeroOrdine = Ordine

                Imballi_Table.Fill(DataSet.Imballi)
                Ordini_Table.Fill(DataSet.Ordini)
                Distinta_Table.Fill(DataSet.Distinta)

                ListaOrdine = DataSet.Ordini.Where(Function(X) X.Ordine = Ordine).ToList

                Select Case Anteprima

                    Case True
                        Using Ante As New PrintPreviewDialog
                            Ante.Document = PRINTER
                            Ante.ShowDialog()
                        End Using

                    Case False
                        PRINTER.Print()
                End Select

                DataSet.Dispose()
                Imballi_Table.Dispose()
                Ordini_Table.Dispose()
            End If

        End Sub


        Private Sub Conferma_Ordine_Print(sender As Object, e As Printing.PrintPageEventArgs) Handles PRINTER.PrintPage
            Dim FMT As StringFormat = Stampe.FMT

            Dim FontTitoloBold As New Font("Calibri", 16, FontStyle.Bold)
            Dim FontTitolo As New Font("Calibri", 16)
            Dim FontRighe As New Font("Calibri", 8)

            Dim RectLogo As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Top, 200, 50)
            Dim RectTitolo As New Rectangle(RectLogo.Right, e.MarginBounds.Top, e.MarginBounds.Width - 350, 50)
            Dim RectData As New Rectangle(RectTitolo.Right, e.MarginBounds.Top, 150, 50)

            Stampe.ImmagineInRettangolo(My.Resources.LogoBicc, RectLogo, e)
            e.Graphics.DrawRectangles(New Pen(Color.LightGray, 2), {RectLogo, RectTitolo, RectData})

            e.Graphics.DrawString("CONFERMA D'ORDINE", FontTitolo, Brushes.Gray, RectTitolo, FMT)
            e.Graphics.DrawString(Date.Today.Date, FontTitolo, Brushes.Gray, RectData, FMT)

            e.Graphics.FillRectangle(Brushes.LightGray, e.MarginBounds.Left, e.MarginBounds.Top + 55, e.MarginBounds.Width, 5)

            Dim RectNumeroOrdine As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Top + 65, e.MarginBounds.Width, 30)
            e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), RectNumeroOrdine)
            e.Graphics.DrawString(NumeroOrdine, FontTitolo, Brushes.Gray, RectNumeroOrdine, FMT)

            Dim RectTitoli As New Rectangle(e.MarginBounds.Left, RectNumeroOrdine.Bottom + 5, e.MarginBounds.Width, 20)
            e.Graphics.FillRectangle(Brushes.LightBlue, RectTitoli)
            e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), RectTitoli)

            Dim RectSotto As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Bottom - 30, e.MarginBounds.Width, 20)
            Dim RectSottoDisc As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Bottom - 8, e.MarginBounds.Width, 8)
            e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), RectSotto)


            e.Graphics.DrawString(My.Settings.StringaDisclaimer, New Font("Calibri", 6), Brushes.Gray, RectSottoDisc, FMT)

            Dim RectTabella As New Rectangle(e.MarginBounds.Left, RectNumeroOrdine.Bottom + 30, e.MarginBounds.Width, e.MarginBounds.Height - 125 - 35)
            'e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), RectTabella)

            Dim U As Single = RectTitoli.Width / 20

            Dim RectTitoloRiga As New Rectangle(RectTitoli.X, RectTitoli.Y, U, RectTitoli.Height)
            Dim RectTitoloImballo As New Rectangle(RectTitoloRiga.Right, RectTitoli.Y, U * 2, RectTitoli.Height)
            Dim RectTitoloQt As New Rectangle(RectTitoloImballo.Right, RectTitoli.Y, U, RectTitoli.Height)
            Dim RectTitoloDescrizione As New Rectangle(RectTitoloQt.Right, RectTitoli.Y, U * 5, RectTitoli.Height)
            Dim RectTitoloIndice As New Rectangle(RectTitoloDescrizione.Right, RectTitoli.Y, U * 2, RectTitoli.Height)
            Dim RectTitoloM3 As New Rectangle(RectTitoloIndice.Right, RectTitoli.Y, U * 2, RectTitoli.Height)
            Dim RectTitoloConsegna As New Rectangle(RectTitoloM3.Right, RectTitoli.Y, U * 3, RectTitoli.Height)
            Dim RectTitoloPrezzo As New Rectangle(RectTitoloConsegna.Right, RectTitoli.Y, U * 2, RectTitoli.Height)
            Dim RectTitoloPrezzoTot As New Rectangle(RectTitoloPrezzo.Right, RectTitoli.Y, U * 2, RectTitoli.Height)

            'e.Graphics.DrawRectangles(Pens.Black, {RectTitoloRiga, RectTitoloImballo, RectTitoloQt, RectTitoloDescrizione, RectTitoloIndice, RectTitoloM3, RectTitoloRivestimento, RectTitoloPrezzo, RectTitoloPrezzoTot})

            e.Graphics.DrawString("Riga", FontRighe, Brushes.Black, RectTitoloRiga, FMT)
            e.Graphics.DrawString("Imballo", FontRighe, Brushes.Black, RectTitoloImballo, FMT)
            e.Graphics.DrawString("Qt", FontRighe, Brushes.Black, RectTitoloQt, FMT)
            e.Graphics.DrawString("Descrizione", FontRighe, Brushes.Black, RectTitoloDescrizione, FMT)
            e.Graphics.DrawString("Indice", FontRighe, Brushes.Black, RectTitoloIndice, FMT)
            e.Graphics.DrawString("M³ \ M²", FontRighe, Brushes.Black, RectTitoloM3, FMT)
            e.Graphics.DrawString("Data Consegna", FontRighe, Brushes.Black, RectTitoloConsegna, FMT)
            e.Graphics.DrawString("Prezzo", FontRighe, Brushes.Black, RectTitoloPrezzo, FMT)
            e.Graphics.DrawString("Totale", FontRighe, Brushes.Black, RectTitoloPrezzoTot, FMT)

            '--- FINE INTESTAZIONE

            Static TotaleEuro As Decimal = 0
            Dim TotaleRighe As Integer = ListaOrdine.Count
            Static RigheStampate As Integer = 0
            Static PagineStampate As Integer = 0

            Dim PosX = RectTabella.Left
            Dim PosY = RectTabella.Top
            Dim Hriga = 35

            'Numero di righe che possono essere stampate in una pagina
            Dim righePerPagina As Integer = Math.Ceiling(RectTabella.Height / Hriga) 'Altezza righe

            'Calcola il numero di pagine che verranno stampate
            Dim nPagine As Integer

            If TotaleRighe Mod righePerPagina > 0 Then
                nPagine = (TotaleRighe \ righePerPagina) + 1
            Else
                nPagine = (TotaleRighe \ righePerPagina)
            End If

            PagineStampate += 1

            For i As Integer = RigheStampate To RigheStampate + righePerPagina - 2

                Dim RectRiga As New Rectangle(PosX, PosY, U, Hriga)
                Dim RectImballo As New Rectangle(RectTitoloRiga.Right, PosY, U * 2, Hriga)
                Dim RectQt As New Rectangle(RectTitoloImballo.Right, PosY, U, Hriga)
                Dim RectDescrizione As New Rectangle(RectTitoloQt.Right, PosY, U * 5, Hriga)
                Dim RectIndice As New Rectangle(RectTitoloDescrizione.Right, PosY, U * 2, Hriga)
                Dim RectM3 As New Rectangle(RectTitoloIndice.Right, PosY, U * 2, Hriga)
                Dim RectConsegna As New Rectangle(RectTitoloM3.Right, PosY, U * 3, Hriga)
                Dim RectPrezzo As New Rectangle(RectTitoloConsegna.Right, PosY, U * 2, Hriga)
                Dim RectPrezzoTot As New Rectangle(RectTitoloPrezzo.Right, PosY, U * 2, Hriga)

                If RigheStampate Mod 2 <> 0 Then e.Graphics.FillRectangle(Brushes.LightBlue, PosX, PosY, e.MarginBounds.Width, Hriga)
                e.Graphics.DrawRectangles(Pens.LightGray, {RectRiga, RectImballo, RectQt, RectDescrizione, RectIndice, RectM3, RectConsegna, RectPrezzo, RectPrezzoTot})

                With ListaOrdine(RigheStampate)

                    '// Estrae la righa IMBALLO relativa alla riga che sta scrivendo
                    Dim Imballo As ModPackDBDataSet.ImballiRow

                    Imballo = DataSet.Imballi.Where(Function(X) X.Imballo = .Imballo).First

                    'Se esiste una riga distinta con part:K (Corredo) aggiunge dicitura Corredo alla CO
                    'Dim Corredo As Boolean = DataSet.Distinta.Where(Function(X) X.Imballo = Imballo.Imballo).Where(Function(X) X.Part = "K").Any


                    Dim HT As Boolean = .HT

                    Dim Descrizione As String = " Cm " & Imballo.L & " x " & Imballo.P
                    If Not Imballo.H = 0 Then Descrizione += " x " & Imballo.H
                    Descrizione += " " & Imballo.Tipo
                    If .HT = True Then Descrizione += " HT"
                    If Not String.IsNullOrEmpty(.Tipo_Rivestimento) Then Descrizione += " (" & .Tipo_Rivestimento & ")"
                    Descrizione += vbCrLf & "D " & .Codice.ToString.TrimEnd("-") & " C " & .Commessa.ToString.TrimEnd("-")

                    'If Corredo = True Then Descrizione += " +CORREDO"


                    Dim prezzo As Decimal = Imballo.Prezzo
                    Dim PrezzoTot As Decimal = Imballo.Prezzo * .Qt

                    e.Graphics.DrawString(.Riga, FontRighe, Brushes.Black, RectRiga, FMT)                                'RIGA
                    e.Graphics.DrawString(.Imballo, FontRighe, Brushes.Black, RectImballo, FMT)                             'IMBALLO
                    e.Graphics.DrawString(.Qt, FontRighe, Brushes.Black, RectQt, FMT)                                  'QT
                    e.Graphics.DrawString(Descrizione, FontRighe, Brushes.Black, RectDescrizione, FMT)                      'DESCRIZIONE
                    e.Graphics.DrawString(.Indice, FontRighe, Brushes.Black, RectIndice, FMT)                              'INDICE
                    If String.IsNullOrEmpty(.Tipo_Rivestimento) Then e.Graphics.DrawString(Imballo.M3, FontRighe, Brushes.Black, RectM3, FMT) Else _
                    e.Graphics.DrawString(Imballo.M3 & " \ " & Math.Round(Imballo.M2, 1), FontRighe, Brushes.Black, RectM3, FMT) 'M3\M2
                    e.Graphics.DrawString(.Data_Consegna, FontRighe, Brushes.Black, RectConsegna, FMT)                           'CONSEGNA
                    e.Graphics.DrawString("€ " & prezzo.ToString("N2"), FontRighe, Brushes.Black, RectPrezzo, FMT)          'PREZZO
                    e.Graphics.DrawString("€ " & PrezzoTot.ToString("N2"), FontRighe, Brushes.Black, RectPrezzoTot, FMT)    'PREZZOTOTALE

                    TotaleEuro += PrezzoTot

                End With

                Dim RectTotaleEuro As New Rectangle(RectPrezzoTot.X, RectSotto.Y, RectPrezzoTot.Width, RectSotto.Height)
                Dim RectTotaleEuroTitolo As New Rectangle(RectTotaleEuro.X - 50, RectSotto.Y, 50, RectSotto.Height)
                Dim RectPagine As New Rectangle(RectSotto.X, RectSotto.Y, 100, RectSotto.Height)

                e.Graphics.DrawString("Pag. " & PagineStampate & "/" & nPagine, FontRighe, Brushes.Gray, RectPagine, FMT)

                'Se le righe stampate sono tutte interrompe il ciclo For…Next
                If i = TotaleRighe - 1 Then
                    e.Graphics.DrawRectangle(Pens.LightGray, RectTotaleEuro)
                    e.Graphics.DrawString("TOTALE", FontRighe, Brushes.Gray, RectTotaleEuroTitolo, FMT)
                    e.Graphics.DrawString("€ " & TotaleEuro.ToString("N2"), FontRighe, Brushes.Black, RectTotaleEuro, FMT)
                    e.HasMorePages = False
                    Exit For
                End If

                'stampa della riga

                RigheStampate += 1
                PosY += Hriga

            Next

            'Controlla se vi sono altre pagine da stampare
            If PagineStampate < nPagine Then
                e.HasMorePages = True
                PosY = e.MarginBounds.Top
            Else
                e.HasMorePages = False
                RigheStampate = 0
                PagineStampate = 0
                TotaleEuro = 0
            End If

        End Sub
        Private Sub Set_Settings(ByVal Document As Printing.PrintDocument, Optional Colore As Boolean = False, Optional Name As String = "")
            Document.DefaultPageSettings.Margins.Top = My.Settings.Stampa_MargineTop / 0.254
            Document.DefaultPageSettings.Margins.Bottom = My.Settings.Stampa_MargineBottom / 0.254
            Document.DefaultPageSettings.Margins.Left = My.Settings.Stampa_MargineLeft / 0.254
            Document.DefaultPageSettings.Margins.Right = My.Settings.Stampa_MargineRight / 0.254
            Document.DefaultPageSettings.Color = Colore
            Document.DefaultPageSettings.Landscape = My.Settings.Stampa_LandScape
            Document.DocumentName = Name
        End Sub

    End Module
End Namespace