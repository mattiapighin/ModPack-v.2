Namespace CheckList
    Module MDL_Stampe_CheckList

        Private NumeroOrdine As String
        Private ListaOrdine As List(Of ModPackDBDataSet.OrdiniRow)

        Private FMT As New StringFormat With {.Alignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter, .LineAlignment = StringAlignment.Center}
        Private WithEvents PRINTER As New System.Drawing.Printing.PrintDocument

        Private DataSet As New ModPackDBDataSet
        Private Imballi_Table As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
        Private Ordini_Table As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter


        Public Sub Stampa(ByVal Ordine As String, Optional Anteprima As Boolean = False)

            Set_Settings(PRINTER, True)

            NumeroOrdine = Ordine

            Imballi_Table.Fill(DataSet.Imballi)
            Ordini_Table.Fill(DataSet.Ordini)

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


        End Sub

        Public Sub CheckList_Print(sender As Object, e As Printing.PrintPageEventArgs) Handles PRINTER.PrintPage
            Dim FMT As StringFormat = Stampe.FMT

            Dim FontTitoloBold As New Font("Calibri", 14, FontStyle.Bold)
            Dim FontTitolo As New Font("Calibri", 10)
            Dim FontRighe As New Font("Calibri", 12)
            Dim FontEvaso As New Font("Calibri", 12, FontStyle.Strikeout)

            Dim RectLogo As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Top, 200, 50)
            Dim RectTitolo As New Rectangle(RectLogo.Right, e.MarginBounds.Top, e.MarginBounds.Width - 350, 50)
            Dim RectData As New Rectangle(RectTitolo.Right, e.MarginBounds.Top, 150, 50)

            e.Graphics.DrawRectangles(New Pen(Color.LightGray, 2), {RectLogo, RectTitolo, RectData})

            Stampe.ImmagineInRettangolo(My.Resources.Logo, RectLogo, e)
            e.Graphics.DrawString("CHECKLIST", FontTitolo, Brushes.Gray, RectTitolo, FMT)
            e.Graphics.DrawString(Date.Today.Date, FontTitolo, Brushes.Gray, RectData, FMT)

            e.Graphics.FillRectangle(Brushes.LightGray, e.MarginBounds.Left, e.MarginBounds.Top + 55, e.MarginBounds.Width, 5)

            Dim RectNumeroOrdine As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Top + 65, e.MarginBounds.Width, 30)
            e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), RectNumeroOrdine)
            e.Graphics.DrawString(NumeroOrdine, FontTitolo, Brushes.Gray, RectNumeroOrdine, FMT)

            Dim RectTitoli As New Rectangle(e.MarginBounds.Left, RectNumeroOrdine.Bottom + 5, e.MarginBounds.Width, 20)
            e.Graphics.FillRectangle(Brushes.LightBlue, RectTitoli)
            e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), RectTitoli)

            Dim RectSotto As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Bottom - 30, e.MarginBounds.Width, 30)
            e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), RectSotto)

            Dim RectTabella As New Rectangle(e.MarginBounds.Left, RectNumeroOrdine.Bottom + 30, e.MarginBounds.Width, e.MarginBounds.Height - 125 - 35)
            'e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), RectTabella)

            Dim U As Single = RectTitoli.Width / 19

            Dim RectTitoloRiga As New Rectangle(RectTitoli.X, RectTitoli.Y, U, RectTitoli.Height)
            Dim RectTitoloImballo As New Rectangle(RectTitoloRiga.Right, RectTitoli.Y, U * 2, RectTitoli.Height)
            Dim RectTitoloQt As New Rectangle(RectTitoloImballo.Right, RectTitoli.Y, U, RectTitoli.Height)
            Dim RectTitoloDC As New Rectangle(RectTitoloQt.Right, RectTitoli.Y, U * 4.5, RectTitoli.Height)
            Dim RectTitoloDescrizione As New Rectangle(RectTitoloDC.Right, RectTitoli.Y, U * 4, RectTitoli.Height)
            Dim RectTitoloIndice As New Rectangle(RectTitoloDescrizione.Right, RectTitoli.Y, U * 2, RectTitoli.Height)
            Dim RectTitoloFinito As New Rectangle(RectTitoloIndice.Right, RectTitoli.Y, U * 1.5, RectTitoli.Height)
            Dim RectTitoloCaricato As New Rectangle(RectTitoloFinito.Right, RectTitoli.Y, U * 1.5, RectTitoli.Height)
            Dim RectTitoloEvaso As New Rectangle(RectTitoloCaricato.Right, RectTitoli.Y, U * 1.5, RectTitoli.Height)


            'e.Graphics.DrawRectangles(Pens.Black, {RectTitoloRiga, RectTitoloImballo, RectTitoloQt, RectTitoloDescrizione, RectTitoloIndice, RectTitoloM3, RectTitoloRivestimento, RectTitoloPrezzo, RectTitoloPrezzoTot})

            e.Graphics.DrawString("Riga", FontRighe, Brushes.Black, RectTitoloRiga, FMT)
            e.Graphics.DrawString("Imballo", FontRighe, Brushes.Black, RectTitoloImballo, FMT)
            e.Graphics.DrawString("Qt", FontRighe, Brushes.Black, RectTitoloQt, FMT)
            e.Graphics.DrawString("Disegno \ Commessa", FontRighe, Brushes.Black, RectTitoloDC, FMT)
            e.Graphics.DrawString("Descrizione", FontRighe, Brushes.Black, RectTitoloDescrizione, FMT)
            e.Graphics.DrawString("Indice", FontRighe, Brushes.Black, RectTitoloIndice, FMT)
            e.Graphics.DrawString("Finito", FontRighe, Brushes.Black, RectTitoloFinito, FMT)
            e.Graphics.DrawString("Caricato", FontRighe, Brushes.Black, RectTitoloCaricato, FMT)
            e.Graphics.DrawString("Evaso", FontRighe, Brushes.Black, RectTitoloEvaso, FMT)


            '--- FINE INTESTAZIONE


            Dim TotaleRighe As Integer = ListaOrdine.Count
            Static RigheStampate As Integer = 0
            Static PagineStampate As Integer = 0

            Dim PosX = RectTabella.Left
            Dim PosY = RectTabella.Top
            Dim Hriga = 40

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
                Dim RectD As New Rectangle(RectTitoloQt.Right, PosY, U * 4.5, Hriga / 2)
                Dim RectC As New Rectangle(RectTitoloQt.Right, PosY + Hriga / 2, U * 4.5, Hriga / 2)
                Dim RectDescrizione As New Rectangle(RectTitoloDC.Right, PosY, U * 4, Hriga)
                Dim RectIndice As New Rectangle(RectTitoloDescrizione.Right, PosY, U * 2, Hriga)
                Dim RectFinito As New Rectangle(RectTitoloIndice.Right, PosY, U * 1.5, Hriga)
                Dim RectCaricato As New Rectangle(RectTitoloFinito.Right, PosY, U * 1.5, Hriga)
                Dim RectEvaso As New Rectangle(RectTitoloCaricato.Right, PosY, U * 1.5, Hriga)


                If RigheStampate Mod 2 <> 0 Then e.Graphics.FillRectangle(Brushes.LightBlue, PosX, PosY, e.MarginBounds.Width, Hriga)
                e.Graphics.DrawRectangles(Pens.LightGray, {RectRiga, RectImballo, RectQt, RectD, RectC, RectDescrizione, RectIndice, RectFinito, RectCaricato, RectEvaso})

                With ListaOrdine(RigheStampate)

                    Dim Descrizione As String = " Cm " & .L & " x " & .P
                    If Not .H = 0 Then Descrizione += " x " & .H
                    Descrizione += " " & .Tipo & .HT

                    e.Graphics.DrawString(.Riga, FontRighe, Brushes.Black, RectRiga, FMT)
                    e.Graphics.DrawString(.Imballo, FontRighe, Brushes.Black, RectImballo, FMT)
                    e.Graphics.DrawString(.Qt, FontRighe, Brushes.Black, RectQt, FMT)
                    e.Graphics.DrawString(Descrizione, FontRighe, Brushes.Black, RectDescrizione, FMT)
                    e.Graphics.DrawString(.Indice, FontRighe, Brushes.Black, RectIndice, FMT)

                    e.Graphics.DrawString("D: " & .Codice, FontRighe, Brushes.Black, RectD, FMT)
                    e.Graphics.DrawString("C: " & .Commessa, FontRighe, Brushes.Black, RectC, FMT)


                    e.Graphics.DrawString("⃝", FontRighe, Brushes.Black, RectFinito, FMT)
                    e.Graphics.DrawString("⃝", FontRighe, Brushes.Black, RectCaricato, FMT)
                    e.Graphics.DrawString("⃝", FontRighe, Brushes.Black, RectEvaso, FMT)

                    If .Evaso = True Then

                        e.Graphics.DrawString("X", FontRighe, Brushes.Black, RectFinito, FMT)
                        e.Graphics.DrawString("X", FontRighe, Brushes.Black, RectCaricato, FMT)
                        e.Graphics.DrawString("X", FontRighe, Brushes.Black, RectEvaso, FMT)

                    End If

                End With


                Dim RectPagine As New Rectangle(RectSotto.X, RectSotto.Y, 100, RectSotto.Height)

                e.Graphics.DrawString("Pag. " & PagineStampate & "/" & nPagine, FontRighe, Brushes.Gray, RectPagine, FMT)

                'Se le righe stampate sono tutte interrompe il ciclo For…Next
                If i = TotaleRighe - 1 Then
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
            End If

        End Sub

        Private Sub Set_Settings(ByVal Document As Printing.PrintDocument, Optional Colore As Boolean = False)
            Document.DefaultPageSettings.Margins.Top = My.Settings.Stampa_MargineTop / 0.254
            Document.DefaultPageSettings.Margins.Bottom = My.Settings.Stampa_MargineBottom / 0.254
            Document.DefaultPageSettings.Margins.Left = My.Settings.Stampa_MargineLeft / 0.254
            Document.DefaultPageSettings.Margins.Right = My.Settings.Stampa_MargineRight / 0.254
            Document.DefaultPageSettings.Color = Colore
            Document.DefaultPageSettings.Landscape = My.Settings.Stampa_LandScape
        End Sub

    End Module
End Namespace