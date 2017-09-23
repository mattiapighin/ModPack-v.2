Namespace Stampe
    Module Modulo_Stampe

        Public Sub ImmagineInRettangolo(Immagine As Image, Rettangolo As Rectangle, e As Printing.PrintPageEventArgs)

            Dim xml = XDocument.Load(My.Settings.XMLpath)

            Dim TipoScala As Integer = xml.<Data>.<TipoScalaIMG>.Value
            'Tipo scala IMG 0 = scala normale
            'Tipo scala IMG 1 = scala XY

            If TipoScala = 0 Then
                Dim IMGScalata As New Size(((Rettangolo.Height * Immagine.Width) / Immagine.Height), Rettangolo.Height)
                Dim IMGScalataPoint As New Point((Rettangolo.X + (Rettangolo.Width / 2) - (IMGScalata.Width / 2)), Rettangolo.Y)
                e.Graphics.DrawImage(Immagine, IMGScalataPoint.X + 5, IMGScalataPoint.Y + 5, IMGScalata.Width - 10, IMGScalata.Height - 10)
            Else
                Dim imgscalata As New Size
                If Immagine.Height >= Immagine.Width Then
                    imgscalata.Height = Rettangolo.Height
                    imgscalata.Width = ((Rettangolo.Height * Immagine.Width) / Immagine.Height)
                Else
                    imgscalata.Width = Rettangolo.Width
                    imgscalata.Height = ((Immagine.Height * Rettangolo.Width) / Immagine.Width)
                End If
                Dim IMGScalataPoint As New Point((Rettangolo.X + (Rettangolo.Width / 2) - (imgscalata.Width / 2)), (Rettangolo.Y + (Rettangolo.Height / 2) - (imgscalata.Height / 2)))
                e.Graphics.DrawImage(Immagine, IMGScalataPoint.X + 15, IMGScalataPoint.Y + 15, imgscalata.Width - 30, imgscalata.Height - 30)
            End If

        End Sub

        Public FMT As New StringFormat With {.Alignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter, .LineAlignment = StringAlignment.Center}

        Public Sub CheckList(sender As Object, e As Printing.PrintPageEventArgs, Ordine As String, DS As DataSet)
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
            e.Graphics.DrawString(Ordine, FontTitolo, Brushes.Gray, RectNumeroOrdine, FMT)

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


            Dim TotaleRighe As Integer = DS.Tables(0).Rows.Count
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

                With DS.Tables(0).Rows(RigheStampate)

                    Dim Descrizione As String = " Cm " & .Item(4) & " x " & .Item(5)
                    If Not .Item(6) = 0 Then Descrizione += " x " & .Item(6)
                    Descrizione += " " & .Item(3)

                    e.Graphics.DrawString(.Item(0), FontRighe, Brushes.Black, RectRiga, FMT)
                    e.Graphics.DrawString(.Item(1), FontRighe, Brushes.Black, RectImballo, FMT)
                    e.Graphics.DrawString(.Item(2), FontRighe, Brushes.Black, RectQt, FMT)
                    e.Graphics.DrawString(Descrizione, FontRighe, Brushes.Black, RectDescrizione, FMT)
                    e.Graphics.DrawString(.Item(7), FontRighe, Brushes.Black, RectIndice, FMT)

                    e.Graphics.DrawString("D: " & .Item(9), FontRighe, Brushes.Black, RectD, FMT)
                    e.Graphics.DrawString("C: " & .Item(10), FontRighe, Brushes.Black, RectC, FMT)


                    e.Graphics.DrawString("⃝", FontRighe, Brushes.Black, RectFinito, FMT)
                    e.Graphics.DrawString("⃝", FontRighe, Brushes.Black, RectCaricato, FMT)
                    e.Graphics.DrawString("⃝", FontRighe, Brushes.Black, RectEvaso, FMT)

                    If .Item(8) = True Then

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
        Public Sub ConfermaDOrdine(sender As Object, e As Printing.PrintPageEventArgs, Ordine As String, DS As DataSet)
            Dim FMT As StringFormat = Stampe.FMT

            Dim FontTitoloBold As New Font("Calibri", 16, FontStyle.Bold)
            Dim FontTitolo As New Font("Calibri", 16)
            Dim FontRighe As New Font("Calibri", 8)

            Dim RectLogo As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Top, 200, 50)
            Dim RectTitolo As New Rectangle(RectLogo.Right, e.MarginBounds.Top, e.MarginBounds.Width - 350, 50)
            Dim RectData As New Rectangle(RectTitolo.Right, e.MarginBounds.Top, 150, 50)

            e.Graphics.DrawRectangles(New Pen(Color.LightGray, 2), {RectLogo, RectTitolo, RectData})

            Stampe.ImmagineInRettangolo(My.Resources.Logo, RectLogo, e)
            e.Graphics.DrawString("CONFERMA D'ORDINE", FontTitolo, Brushes.Gray, RectTitolo, FMT)
            e.Graphics.DrawString(Date.Today.Date, FontTitolo, Brushes.Gray, RectData, FMT)

            e.Graphics.FillRectangle(Brushes.LightGray, e.MarginBounds.Left, e.MarginBounds.Top + 55, e.MarginBounds.Width, 5)

            Dim RectNumeroOrdine As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Top + 65, e.MarginBounds.Width, 30)
            e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), RectNumeroOrdine)
            e.Graphics.DrawString(Ordine, FontTitolo, Brushes.Gray, RectNumeroOrdine, FMT)

            Dim RectTitoli As New Rectangle(e.MarginBounds.Left, RectNumeroOrdine.Bottom + 5, e.MarginBounds.Width, 20)
            e.Graphics.FillRectangle(Brushes.LightBlue, RectTitoli)
            e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), RectTitoli)

            Dim RectSotto As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Bottom - 30, e.MarginBounds.Width, 30)
            e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), RectSotto)

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
            e.Graphics.DrawString("M³", FontRighe, Brushes.Black, RectTitoloM3, FMT)
            e.Graphics.DrawString("Data Consegna", FontRighe, Brushes.Black, RectTitoloConsegna, FMT)
            e.Graphics.DrawString("Prezzo", FontRighe, Brushes.Black, RectTitoloPrezzo, FMT)
            e.Graphics.DrawString("Totale", FontRighe, Brushes.Black, RectTitoloPrezzoTot, FMT)

            '--- FINE INTESTAZIONE

            Static TotaleEuro As Decimal = 0
            Dim TotaleRighe As Integer = DS.Tables(0).Rows.Count
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

                With DS.Tables(0).Rows(RigheStampate)

                    Dim Descrizione As String = " Cm " & .Item(4) & " x " & .Item(5)
                    If Not .Item(6) = 0 Then Descrizione += " x " & .Item(6)
                    Descrizione += " " & .Item(3)
                    If Not String.IsNullOrEmpty(.Item(9)) Then Descrizione += " (" & .Item(9) & ")"
                    Descrizione += vbCrLf & "Commessa: " & .Item(13).ToString.TrimEnd("-")


                    Dim prezzo As Decimal = .Item(10)
                    Dim PrezzoTot As Decimal = prezzo * .Item(2)

                    e.Graphics.DrawString(.Item(0), FontRighe, Brushes.Black, RectRiga, FMT)
                    e.Graphics.DrawString(.Item(1), FontRighe, Brushes.Black, RectImballo, FMT)
                    e.Graphics.DrawString(.Item(2), FontRighe, Brushes.Black, RectQt, FMT)
                    e.Graphics.DrawString(Descrizione, FontRighe, Brushes.Black, RectDescrizione, FMT)
                    e.Graphics.DrawString(.Item(7), FontRighe, Brushes.Black, RectIndice, FMT)
                    e.Graphics.DrawString(.Item(8), FontRighe, Brushes.Black, RectM3, FMT)
                    e.Graphics.DrawString(.Item(11), FontRighe, Brushes.Black, RectConsegna, FMT)
                    e.Graphics.DrawString("€ " & prezzo.ToString("N2"), FontRighe, Brushes.Black, RectPrezzo, FMT)
                    e.Graphics.DrawString("€ " & PrezzoTot.ToString("N2"), FontRighe, Brushes.Black, RectPrezzoTot, FMT)

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
        Public Sub Etichetta(sender As Object, e As Printing.PrintPageEventArgs, Magazzino As String, Cliente As String, Disegno As String, Commessa As String, Imballo As String, Quantita As String, Ordine As String)
            Dim Font As New Font("Calibri", 20, FontStyle.Regular)
            Dim FontBold As New Font("Calibri", 20, FontStyle.Bold)
            Dim Piccolo As New Font("Calibri", 6, FontStyle.Regular)

            Dim Riga1 As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height / 5)
            Dim Riga2 As New Rectangle(e.MarginBounds.Left, Riga1.Bottom, e.MarginBounds.Width, e.MarginBounds.Height / 5)
            Dim Riga3 As New Rectangle(e.MarginBounds.Left, Riga2.Bottom, e.MarginBounds.Width, e.MarginBounds.Height / 5)
            Dim Riga4 As New Rectangle(e.MarginBounds.Left, Riga3.Bottom, e.MarginBounds.Width, e.MarginBounds.Height / 5)
            Dim Riga5 As New Rectangle(e.MarginBounds.Left, Riga4.Bottom, e.MarginBounds.Width, e.MarginBounds.Height / 5)

            e.Graphics.DrawRectangle(Pens.Black, Riga1)
            e.Graphics.DrawRectangle(Pens.Black, Riga2)
            e.Graphics.DrawRectangle(Pens.Black, Riga3)
            e.Graphics.DrawRectangle(Pens.Black, Riga4)
            ' e.Graphics.DrawRectangle(Pens.Black, Riga5)


            '# RIGA 1   -   LOGO, MAGAZZINO
            Dim RectLogo As New Rectangle(Riga1.Left, Riga1.Top, Riga1.Width / 3 * 2, Riga1.Height)
            Dim RectMagazzino As New Rectangle(RectLogo.Right, Riga1.Top, Riga1.Width / 3, Riga1.Height)

            e.Graphics.DrawRectangle(Pens.Black, RectLogo)

            '# RIGA 2   -   CLIENTE
            Dim RectCliente As New Rectangle(Riga2.Left, Riga2.Top, Riga2.Width, Riga2.Height)

            '# RIGA 3   -   DISEGNO
            Dim RectD As New Rectangle(Riga3.Left, Riga3.Top, Riga3.Width / 4, Riga3.Height)
            Dim RectDisegno As New Rectangle(RectD.Right, Riga3.Top, Riga3.Width / 4 * 3, Riga3.Height)

            e.Graphics.DrawRectangle(Pens.Black, RectD)

            '# RIGA 4   -   COMMESSA
            Dim RectC As New Rectangle(Riga4.Left, Riga4.Top, Riga4.Width / 4, Riga4.Height)
            Dim RectCommessa As New Rectangle(RectC.Right, Riga4.Top, Riga4.Width / 4 * 3, Riga4.Height)

            e.Graphics.DrawRectangle(Pens.Black, RectC)

            '# RIGA 5   -   CODICE, QT, ORDINE
            Dim RectCodice As New Rectangle(Riga5.Left, Riga5.Top, Riga5.Width / 5 * 2, Riga5.Height)
            Dim RectQt As New Rectangle(RectCodice.Right, Riga5.Top, Riga5.Width / 5, Riga5.Height)
            Dim RectOrdine As New Rectangle(RectQt.Right, Riga5.Top, Riga5.Width / 5 * 2, Riga5.Height)

            e.Graphics.FillRectangle(Brushes.LightGray, RectOrdine)
            e.Graphics.DrawRectangle(Pens.Black, Riga5)
            e.Graphics.DrawRectangle(Pens.Black, RectQt)

            ImmagineInRettangolo(My.Resources.Logo, RectLogo, e)

            ' ################################################################################################################

            e.Graphics.DrawString("MAGAZZINO", Piccolo, Brushes.Gray, RectMagazzino)
            e.Graphics.DrawString("CLIENTE", Piccolo, Brushes.Gray, RectCliente)
            e.Graphics.DrawString("CODICE", Piccolo, Brushes.Gray, RectCodice)
            e.Graphics.DrawString("QT", Piccolo, Brushes.Gray, RectQt)

            ' ################################################################################################################

            e.Graphics.DrawString("M" & Magazzino, FontBold, Brushes.Black, RectMagazzino, FMT)
            e.Graphics.DrawString(Cliente, Font, Brushes.Black, RectCliente, FMT)
            e.Graphics.DrawString("D", Font, Brushes.Black, RectD, FMT)
            e.Graphics.DrawString(Disegno, Font, Brushes.Black, RectDisegno, FMT)
            e.Graphics.DrawString("C", Font, Brushes.Black, RectC, FMT)
            e.Graphics.DrawString(Commessa, Font, Brushes.Black, RectCommessa, FMT)
            e.Graphics.DrawString(Imballo, FontBold, Brushes.Black, RectCodice, FMT)
            e.Graphics.DrawString(Quantita, FontBold, Brushes.Black, RectQt, FMT)
            e.Graphics.DrawString(Ordine, New Font("Calibri", 12, FontStyle.Bold), Brushes.Black, RectOrdine, FMT)

            LOG.Write("Stampa etichetta " & Imballo & " - " & Quantita)
        End Sub

        Public Sub EtichettaBarcode(sender As Object, e As Printing.PrintPageEventArgs, Magazzino As String, Cliente As String, Disegno As String, Commessa As String, Imballo As String, Quantita As String, Ordine As String)

            'Fa cagare perchè non si vede il codice a barre

            Dim Font As New Font("Calibri", 20, FontStyle.Regular)
            Dim FontBold As New Font("Calibri", 20, FontStyle.Bold)
            Dim Piccolo As New Font("Calibri", 6, FontStyle.Regular)

            Dim Riga1 As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height / 6)
            Dim Riga2 As New Rectangle(e.MarginBounds.Left, Riga1.Bottom, e.MarginBounds.Width, e.MarginBounds.Height / 6)
            Dim Riga3 As New Rectangle(e.MarginBounds.Left, Riga2.Bottom, e.MarginBounds.Width, e.MarginBounds.Height / 6)
            Dim Riga4 As New Rectangle(e.MarginBounds.Left, Riga3.Bottom, e.MarginBounds.Width, e.MarginBounds.Height / 6)
            Dim Riga5 As New Rectangle(e.MarginBounds.Left, Riga4.Bottom, e.MarginBounds.Width, (e.MarginBounds.Height / 6) * 2)


            e.Graphics.DrawRectangle(Pens.Black, Riga1)
            e.Graphics.DrawRectangle(Pens.Black, Riga2)
            e.Graphics.DrawRectangle(Pens.Black, Riga3)
            e.Graphics.DrawRectangle(Pens.Black, Riga4)
            ' e.Graphics.DrawRectangle(Pens.Black, Riga5)


            '# RIGA 1   -   LOGO, MAGAZZINO
            Dim RectLogo As New Rectangle(Riga1.Left, Riga1.Top, Riga1.Width / 3 * 2, Riga1.Height)
            Dim RectMagazzino As New Rectangle(RectLogo.Right, Riga1.Top, Riga1.Width / 3, Riga1.Height)

            e.Graphics.DrawRectangle(Pens.Black, RectLogo)

            '# RIGA 2   -   CLIENTE
            Dim RectCliente As New Rectangle(Riga2.Left, Riga2.Top, Riga2.Width, Riga2.Height)

            '# RIGA 3   -   DISEGNO
            Dim RectD As New Rectangle(Riga3.Left, Riga3.Top, Riga3.Width / 4, Riga3.Height)
            Dim RectDisegno As New Rectangle(RectD.Right, Riga3.Top, Riga3.Width / 4 * 3, Riga3.Height)

            e.Graphics.DrawRectangle(Pens.Black, RectD)

            '# RIGA 4   -   COMMESSA
            Dim RectC As New Rectangle(Riga4.Left, Riga4.Top, Riga4.Width / 4, Riga4.Height)
            Dim RectCommessa As New Rectangle(RectC.Right, Riga4.Top, Riga4.Width / 4 * 3, Riga4.Height)

            e.Graphics.DrawRectangle(Pens.Black, RectC)

            '# RIGA 5   -   CODICE, QT, ORDINE

            Dim IMG As Image = BarCode.Genera(Imballo & "_" & Quantita & "_" & Ordine, True, Riga5.Height - 10)
            Dim PointIMG As New PointF((Riga5.Width / 2) - (IMG.Width / 2), Riga5.Y + 10)
            e.Graphics.DrawImage(IMG, PointIMG)


            Dim RectCodice As New Rectangle(Riga5.Left, Riga5.Top, Riga5.Width / 5 * 2, Riga5.Height)
            Dim RectQt As New Rectangle(RectCodice.Right, Riga5.Top, Riga5.Width / 5, Riga5.Height)
            Dim RectOrdine As New Rectangle(RectQt.Right, Riga5.Top, Riga5.Width / 5 * 2, Riga5.Height)

            'e.Graphics.FillRectangle(Brushes.LightGray, RectOrdine)
            'e.Graphics.DrawRectangle(Pens.Black, Riga5)
            'e.Graphics.DrawRectangle(Pens.Black, RectQt)

            ImmagineInRettangolo(My.Resources.Logo, RectLogo, e)

            ' ################################################################################################################

            e.Graphics.DrawString("MAGAZZINO", Piccolo, Brushes.Gray, RectMagazzino)
            'e.Graphics.DrawString("CLIENTE", Piccolo, Brushes.Gray, RectCliente)
            'e.Graphics.DrawString("CODICE", Piccolo, Brushes.Gray, RectCodice)
            'e.Graphics.DrawString("QT", Piccolo, Brushes.Gray, RectQt)

            ' ################################################################################################################

            e.Graphics.DrawString("MAG." & Magazzino, FontBold, Brushes.Black, RectMagazzino, FMT)
            e.Graphics.DrawString(Cliente, Font, Brushes.Black, RectCliente, FMT)
            e.Graphics.DrawString("D", Font, Brushes.Black, RectD, FMT)
            e.Graphics.DrawString(Disegno, Font, Brushes.Black, RectDisegno, FMT)
            e.Graphics.DrawString("C", Font, Brushes.Black, RectC, FMT)
            e.Graphics.DrawString(Commessa, Font, Brushes.Black, RectCommessa, FMT)
            'e.Graphics.DrawString(Imballo, FontBold, Brushes.Black, RectCodice, FMT)
            'e.Graphics.DrawString(Quantita, FontBold, Brushes.Black, RectQt, FMT)
            'e.Graphics.DrawString(Ordine, New Font("Calibri", 12, FontStyle.Bold), Brushes.Black, RectOrdine, FMT)

            LOG.Write("Stampa etichetta " & Imballo & " - " & Quantita)
        End Sub
        Public Sub EtichettaQR(sender As Object, e As Printing.PrintPageEventArgs, Riga As RigaOrdine)
            Dim Bordo As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height)

            Dim STRINGA As String =
                           Riga.Imballo & " PZ. " & Riga.Qt & vbCrLf &
                           "ORD. " & Riga.NumeroOrdine & " DEL " & Riga.Data_Ordine & vbCrLf &
                            Riga.Cliente & vbCrLf &
                            Riga.Codice & vbCrLf &
                            Riga.Commessa & vbCrLf &
                           "MAG. " & Riga.Magazzino & vbCrLf &
                           "CONSEGNA " & Riga.DataConsegna & vbCrLf &
                           "ID " & Riga.Indice

            e.Graphics.DrawImage(BarCode.QR(STRINGA, Bordo.Height - 40), Bordo.Left, Bordo.Top + 20)
            e.Graphics.DrawRectangle(Pens.Black, Bordo.Left, Bordo.Top + 20, Bordo.Height - 40, Bordo.Height - 40)

            Dim Font1 As New Font("Calibri", 20, FontStyle.Bold)
            Dim Font2 As New Font("Calibri", 12, FontStyle.Bold)

            Dim Unit As Single = Bordo.Height / 4
            Dim Riga1 As New Rectangle(e.MarginBounds.Left + (Bordo.Width / 2), e.MarginBounds.Top, (Bordo.Width / 2), Unit)
            Dim Riga2 As New Rectangle(e.MarginBounds.Left + (Bordo.Width / 2), Riga1.Bottom, (Bordo.Width / 2), Unit)
            Dim Riga3 As New Rectangle(e.MarginBounds.Left + (Bordo.Width / 2), Riga2.Bottom, (Bordo.Width / 2), Unit)
            Dim Riga4 As New Rectangle(e.MarginBounds.Left + (Bordo.Width / 2), Riga3.Bottom, (Bordo.Width / 2), Unit)

            e.Graphics.DrawRectangles(Pens.Black, {Riga1, Riga2, Riga3, Riga4})

            e.Graphics.DrawString(Riga.Imballo & " - PZ. " & Riga.Qt, Font1, Brushes.Black, Riga1, FMT)
            e.Graphics.DrawString(Riga.NumeroOrdine, Font2, Brushes.Black, Riga2, FMT)
            e.Graphics.DrawString(Riga.DataConsegna, Font1, Brushes.Black, Riga3, FMT)
            e.Graphics.DrawString("MAG. " & Riga.Magazzino, Font2, Brushes.Black, Riga4, FMT)



        End Sub

    End Module
End Namespace