Namespace Distinta
    Module MDL_Stampe_Distinta

        Private FMT As New StringFormat With {.Alignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter, .LineAlignment = StringAlignment.Center}
        Dim fnt As New Font("Calibri", My.Settings.DimensioneFontDistinta)
        Private WithEvents PRINTER As New System.Drawing.Printing.PrintDocument

        Private ListaDistinte As List(Of ModPackDBDataSet.OrdiniRow)

        '// DataSet e TableAdapters

        Private DataSet As New ModPackDBDataSet
        Private Imballi_Table As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
        Private Ordini_Table As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
        Private Distinta_Table As New ModPackDBDataSetTableAdapters.DistintaTableAdapter
        Private DescRivestimenti_Table As New ModPackDBDataSetTableAdapters.RivestimentiTableAdapter
        Private SetupRivestimenti_Table As New ModPackDBDataSetTableAdapters.Setup_RivestTableAdapter
        Private Magazzini_Table As New ModPackDBDataSetTableAdapters.MagazziniTableAdapter
        Private NoteImballi_Table As New ModPackDBDataSetTableAdapters.NoteImballiTableAdapter
        Private Tipi_Table As New ModPackDBDataSetTableAdapters.TipiTableAdapter
        Private Indici_Table As New ModPackDBDataSetTableAdapters.IndiciTableAdapter

        Public Sub Stampa(Lista As List(Of ModPackDBDataSet.OrdiniRow), Optional Anteprima As Boolean = False)

            Set_Settings(PRINTER, My.Settings.Stampa_Color)

            FillAll()
            ListaDistinte = Lista

            Select Case Anteprima

                Case True
                    Using Ante As New PrintPreviewDialog
                        Ante.Document = PRINTER
                        Ante.ShowDialog()
                    End Using

                Case False
                    PRINTER.Print()

            End Select

            DisposeAll()

        End Sub
        Private Sub Distinte_Print(sender As Object, e As Printing.PrintPageEventArgs) Handles PRINTER.PrintPage

            Static PagineStampate = 0
            Dim DistinteTotali As Integer = ListaDistinte.Count - 1

            Intestazione(e, ListaDistinte(PagineStampate))
            PieDiPagina(e, ListaDistinte(PagineStampate))
            Rivestimento(e, ListaDistinte(PagineStampate))
            Foto(e, ListaDistinte(PagineStampate))
            Note(e, ListaDistinte(PagineStampate))
            Morale(e, ListaDistinte(PagineStampate))
            CodiceABarre(e, ListaDistinte(PagineStampate))
            TipoBancale(e, ListaDistinte(PagineStampate))
            InfoTipo(e, ListaDistinte(PagineStampate))


            Distinta(e, ListaDistinte(PagineStampate))


            ' ########## DISEGNI ##########

            Select Case ListaDistinte(PagineStampate).Tipo

                Case "G"
                    Bancale_G(e, ListaDistinte(PagineStampate))
                    Montanti_G(e, ListaDistinte(PagineStampate))
                    Montanti_Testo(e, ListaDistinte(PagineStampate))

                Case "P"
                    Bancale_P_T(e, ListaDistinte(PagineStampate))

                Case "T"
                    Bancale_P_T(e, ListaDistinte(PagineStampate))

                Case "GDA"
                    Bancale_GDA(e, ListaDistinte(PagineStampate))
                    Montanti_GDA(e, ListaDistinte(PagineStampate))
                    Montanti_Testo(e, ListaDistinte(PagineStampate))

                Case "GST"
                    Bancale_GST(e, ListaDistinte(PagineStampate))
                    Montanti_G(e, ListaDistinte(PagineStampate))
                    Montanti_Testo(e, ListaDistinte(PagineStampate))

                Case "GRO"
                    Bancale_G(e, ListaDistinte(PagineStampate))
                    Montanti_G(e, ListaDistinte(PagineStampate))
                    Montanti_Testo(e, ListaDistinte(PagineStampate))

                Case "C"
                    Bancale_C(e, ListaDistinte(PagineStampate))

            End Select

            '##############################

            PagineStampate += 1

            If PagineStampate <= DistinteTotali Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
                PagineStampate = 0
            End If


        End Sub

        Private Sub DisposeAll()
            DataSet.Dispose()
            Imballi_Table.Dispose()
            Ordini_Table.Dispose()
            Distinta_Table.Dispose()
            DescRivestimenti_Table.Dispose()
            SetupRivestimenti_Table.Dispose()
            Magazzini_Table.Dispose()
            NoteImballi_Table.Dispose()
            Tipi_Table.Dispose()
            Indici_Table.Dispose()
        End Sub
        Private Sub FillAll()
            Indici_Table.Fill(DataSet.Indici)
            Imballi_Table.Fill(DataSet.Imballi)
            Ordini_Table.Fill(DataSet.Ordini)
            Distinta_Table.Fill(DataSet.Distinta)
            DescRivestimenti_Table.Fill(DataSet.Rivestimenti)
            SetupRivestimenti_Table.Fill(DataSet.Setup_Rivest)
            Magazzini_Table.Fill(DataSet.Magazzini)
            NoteImballi_Table.Fill(DataSet.NoteImballi)
            Tipi_Table.Fill(DataSet.Tipi)
        End Sub

        Private Sub Set_Settings(ByVal Document As Printing.PrintDocument, Optional Colore As Boolean = False)
            Document.DefaultPageSettings.Margins.Top = My.Settings.Stampa_MargineTop / 0.254
            Document.DefaultPageSettings.Margins.Bottom = My.Settings.Stampa_MargineBottom / 0.254
            Document.DefaultPageSettings.Margins.Left = My.Settings.Stampa_MargineLeft / 0.254
            Document.DefaultPageSettings.Margins.Right = My.Settings.Stampa_MargineRight / 0.254
            Document.DefaultPageSettings.Color = Colore
            Document.DefaultPageSettings.Landscape = My.Settings.Stampa_LandScape
        End Sub

        'Moduli
        Private Sub Intestazione(e As Printing.PrintPageEventArgs, Riga As ModPackDBDataSet.OrdiniRow)

            Try

                Dim FontRiga1 As New Font("Calibri", 16, FontStyle.Bold)
                Dim FontRiga1Big As New Font("Calibri", 20, FontStyle.Bold)
                Dim FontN As New Font("Calibri", 10)
                Dim FT As New Font("Calibri", 6)

                Dim Squadratura As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height)
                e.Graphics.DrawRectangle(Pens.LightGray, Squadratura)

                Dim RectIntestazione As New Rectangle(e.MarginBounds.Left + 5, e.MarginBounds.Top + 5, e.MarginBounds.Width - 10, 100)

                Dim Riga1 As New Rectangle(RectIntestazione.Left, RectIntestazione.Top, RectIntestazione.Width, 40)
                Dim Riga2 As New Rectangle(RectIntestazione.Left, Riga1.Bottom, RectIntestazione.Width, 20)
                Dim Riga3 As New Rectangle(RectIntestazione.Left, Riga2.Bottom, RectIntestazione.Width, 20)
                Dim Riga4 As New Rectangle(RectIntestazione.Left, Riga3.Bottom, RectIntestazione.Width, 20)

                Dim L As Single = RectIntestazione.Width / 40

                Dim RectLogo As New Rectangle(Riga1.Left, Riga1.Top, L * 10, Riga1.Height)
                Dim RectImballo As New Rectangle(RectLogo.Right, Riga1.Top, L * 18, Riga1.Height)
                Dim RectQT As New Rectangle(RectImballo.Right, Riga1.Top, L * 4, Riga1.Height)
                Dim RectHT As New Rectangle(RectQT.Right, Riga1.Top, L * 4, Riga1.Height)
                Dim RectTIPO As New Rectangle(RectHT.Right, Riga1.Top, L * 4, Riga1.Height)
                e.Graphics.DrawRectangles(Pens.LightGray, {RectLogo, RectImballo, RectQT, RectHT, RectTIPO})

                Dim RectCliente As New Rectangle(Riga2.Left, Riga2.Top, L * 21, Riga2.Height)
                Dim RectRivestimento As New Rectangle(RectCliente.Right, Riga2.Top, L * 10, Riga2.Height + Riga3.Height)
                Dim RectOrdine As New Rectangle(RectRivestimento.Right, Riga2.Top, L * 9, Riga2.Height)
                e.Graphics.DrawRectangles(Pens.LightGray, {RectCliente, RectRivestimento, RectOrdine})

                Dim RectCodice As New Rectangle(Riga3.Left, Riga3.Top, L * 13, Riga3.Height)
                Dim RectCommessa As New Rectangle(Riga4.Left, Riga4.Top, L * 13, Riga4.Height)
                Dim RectIndice As New Rectangle(RectCodice.Right, Riga3.Top, L * 8, Riga3.Height + Riga4.Height)
                Dim RectConsegna As New Rectangle(RectRivestimento.Right, Riga3.Top, L * 9, Riga3.Height)
                Dim RectVuoto As New Rectangle(RectIndice.Right, RectCommessa.Top, L * 19, Riga4.Height)
                e.Graphics.DrawRectangles(Pens.LightGray, {RectCodice, RectIndice, RectConsegna, RectCommessa, RectVuoto})
                e.Graphics.FillRectangle(Brushes.LightGray, RectVuoto)
                e.Graphics.DrawRectangle(New Pen(Color.LightGray, 3), RectIntestazione)

                FunzioniStampa.ImmagineInRettangolo(My.Resources.Logo, RectLogo, e)
                e.Graphics.DrawString(Riga.Imballo, FontRiga1, Brushes.Black, RectImballo, FMT)
                e.Graphics.DrawString("PZ " & Riga.Qt, FontRiga1Big, Brushes.Black, RectQT, FMT)
                If Riga.HT = True Then e.Graphics.DrawString("HT", FontRiga1Big, Brushes.Black, RectHT, FMT)
                e.Graphics.DrawString(Riga.Tipo, FontRiga1, Brushes.Black, RectTIPO, FMT)

                Dim DescRivestimento As String = DataSet.Rivestimenti.Where(Function(X) X.Tipo_Rivestimento = Riga.Tipo_Rivestimento).Select(Function(y) y.Descrizione).FirstOrDefault

                e.Graphics.DrawString(Riga.Cliente, FontN, Brushes.Black, RectCliente, FMT)
                e.Graphics.DrawString(Riga.Codice, FontN, Brushes.Black, RectCodice, FMT)
                e.Graphics.DrawString(Riga.Commessa, FontN, Brushes.Black, RectCommessa, FMT)
                e.Graphics.DrawString(Riga.Indice, FontN, Brushes.Black, RectIndice, FMT)
                e.Graphics.DrawString(DescRivestimento, FontN, Brushes.Black, RectRivestimento, FMT)
                e.Graphics.DrawString(Riga.Ordine & " (" & Riga.Riga & ")", FontN, Brushes.Black, RectOrdine, FMT)

                'e.Graphics.DrawString(Riga.DataConsegna, FontN, Brushes.Black, RectConsegna, FMT)
                Dim WK As Integer = DatePart(DateInterval.WeekOfYear, Riga.Data_Consegna, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFourDays)
                e.Graphics.DrawString("SETT. " & WK, FontN, Brushes.Black, RectConsegna, FMT)

                'Funzione get magazzino
                Dim DescrizioneMagazzino As String = DataSet.Magazzini.Where(Function(X) X.Codice = Riga.Magazzino).Select(Function(X) X.Descrizione).FirstOrDefault
                e.Graphics.DrawString(DescrizioneMagazzino, New Font("Calibri", 11, FontStyle.Bold), Brushes.Black, RectVuoto, FMT)

                'Intestazioni
                e.Graphics.DrawString("PZ", FT, Brushes.LightGray, RectQT)
                e.Graphics.DrawString("TIPO", FT, Brushes.LightGray, RectTIPO)
                e.Graphics.DrawString("CLIENTE", FT, Brushes.LightGray, RectCliente)
                e.Graphics.DrawString("DISEGNO", FT, Brushes.LightGray, RectCodice)
                e.Graphics.DrawString("COMMESSA", FT, Brushes.LightGray, RectCommessa)
                e.Graphics.DrawString("INDICE", FT, Brushes.LightGray, RectIndice)
                e.Graphics.DrawString("RIVESTIMENTO", FT, Brushes.LightGray, RectRivestimento)
                e.Graphics.DrawString("ORD", FT, Brushes.LightGray, RectOrdine)
                e.Graphics.DrawString("CONSEGNA", FT, Brushes.LightGray, RectConsegna)


            Catch ex As Exception
                MsgBox("Errore durante la stampa dell'intestazione" & vbCrLf & " ORDINE: " & Riga.Ordine & " RIGA: " & Riga.Riga & vbCrLf & ex.Message, vbCritical, "Errore")
            End Try

        End Sub
        Private Sub PieDiPagina(e As Printing.PrintPageEventArgs, Riga As ModPackDBDataSet.OrdiniRow)

            Try

                Dim Imballo As ModPackDBDataSet.ImballiRow
                Imballo = DataSet.Imballi.Where(Function(X) X.Imballo = Riga.Imballo).First

                Dim Riga1 As New Rectangle(e.MarginBounds.Left + 5, e.MarginBounds.Bottom - 45, e.MarginBounds.Width - 10, 15)
                Dim Riga2 As New Rectangle(e.MarginBounds.Left + 5, e.MarginBounds.Bottom - 30, e.MarginBounds.Width - 10, 15)
                Dim RigaDisclaimer As New Rectangle(e.MarginBounds.Left + 5, e.MarginBounds.Bottom - 15, e.MarginBounds.Width - 10, 15)

                If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
                    'Stampa versione di modpack in piedipagina
                    With System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion
                        e.Graphics.DrawString("ModPack - V " & .Major & "." & .Minor & "." & .Build & "." & .Revision, New Font("Calibri", 6, FontStyle.Bold), Brushes.Black, RigaDisclaimer.Left - 5, RigaDisclaimer.Bottom - 9)
                    End With
                End If


                'Dim Riga1 As New Rectangle(e.MarginBounds.Left + 5, e.MarginBounds.Bottom - 45, e.MarginBounds.Width - 10, 20)
                'Dim Riga2 As New Rectangle(e.MarginBounds.Left + 5, e.MarginBounds.Bottom - 25, e.MarginBounds.Width - 10, 20)

                e.Graphics.DrawString(My.Settings.StringaDisclaimer, New Font("Calibri", 6), Brushes.Gray, RigaDisclaimer, FMT)

                e.Graphics.FillRectangle(Brushes.LightGray, Riga1)
                e.Graphics.DrawRectangles(New Pen(Color.LightGray, 1), {Riga1, Riga2})

                Dim FONT As New Font("Calibri", 8)
                Dim FONTG As New Font("Calibri", 8, FontStyle.Bold)

                Dim Q As Single = Riga1.Width / 12

                Dim RsL As New Rectangle(Riga1.Left, Riga1.Top, Q, Riga1.Height)
                Dim RsP As New Rectangle(RsL.Right, Riga1.Top, Q, Riga1.Height)
                Dim RsH As New Rectangle(RsP.Right, Riga1.Top, Q, Riga1.Height)
                Dim RsZocc As New Rectangle(RsH.Right, Riga1.Top, Q, Riga1.Height)
                Dim RsDTBM As New Rectangle(RsZocc.Right, Riga1.Top, Q, Riga1.Height)
                Dim RsDiag As New Rectangle(RsDTBM.Right, Riga1.Top, Q, Riga1.Height)
                Dim RsDiagF As New Rectangle(RsDiag.Right, Riga1.Top, Q, Riga1.Height)
                Dim RsDiagT As New Rectangle(RsDiagF.Right, Riga1.Top, Q, Riga1.Height)
                Dim RsVuoto2 As New Rectangle(RsDiagT.Right, Riga1.Top, Q * 2, Riga1.Height)
                Dim Rsm2 As New Rectangle(RsVuoto2.Right, Riga1.Top, Q, Riga1.Height)
                Dim Rsm3 As New Rectangle(Rsm2.Right, Riga1.Top, Q, Riga1.Height)

                Dim RbL As New Rectangle(Riga2.Left, Riga2.Top, Q, Riga2.Height)
                Dim RbP As New Rectangle(RbL.Right, Riga2.Top, Q, Riga2.Height)
                Dim RbH As New Rectangle(RbP.Right, Riga2.Top, Q, Riga2.Height)
                Dim RbZocc As New Rectangle(RbH.Right, Riga2.Top, Q, Riga2.Height)
                Dim RbDTBM As New Rectangle(RbZocc.Right, Riga2.Top, Q, Riga2.Height)
                Dim rbdiag As New Rectangle(RbDTBM.Right, Riga2.Top, Q, Riga2.Height)
                Dim RbDiagF As New Rectangle(rbdiag.Right, Riga2.Top, Q, Riga2.Height)
                Dim RbDiagT As New Rectangle(RbDiagF.Right, Riga2.Top, Q, Riga2.Height)
                Dim RbVuoto2 As New Rectangle(RbDiagT.Right, Riga2.Top, Q * 2, Riga2.Height)
                Dim Rbm2 As New Rectangle(RbVuoto2.Right, Riga2.Top, Q, Riga2.Height)
                Dim Rbm3 As New Rectangle(Rbm2.Right, Riga2.Top, Q, Riga2.Height)

                e.Graphics.DrawRectangles(Pens.LightGray, {RbL, RbP, RbH, RbZocc, RbDTBM, RsDiag, RbDiagF, RbDiagT, RbVuoto2, Rbm2})

                e.Graphics.DrawString("L", FONTG, Brushes.Black, RsL, FMT)
                e.Graphics.DrawString("P", FONTG, Brushes.Black, RsP, FMT)
                e.Graphics.DrawString("H", FONTG, Brushes.Black, RsH, FMT)
                e.Graphics.DrawString("Zocc", FONTG, Brushes.Black, RsZocc, FMT)
                e.Graphics.DrawString("DT\BM", FONTG, Brushes.Black, RsDTBM, FMT)
                e.Graphics.DrawString("Diagonali", FONTG, Brushes.Black, RsDiag, FMT)
                e.Graphics.DrawString("Gradi F", FONTG, Brushes.Black, RsDiagF, FMT)
                e.Graphics.DrawString("Gradi T", FONTG, Brushes.Black, RsDiagT, FMT)
                e.Graphics.DrawString("Caricato", FONTG, Brushes.Black, RsVuoto2, FMT)
                e.Graphics.DrawString("m²", FONTG, Brushes.Black, Rsm2, FMT)
                e.Graphics.DrawString("m³", FONTG, Brushes.Black, Rsm3, FMT)

                e.Graphics.DrawString(Riga.L, FONT, Brushes.Black, RbL, FMT)
                e.Graphics.DrawString(Riga.P, FONT, Brushes.Black, RbP, FMT)
                e.Graphics.DrawString(Riga.H, FONT, Brushes.Black, RbH, FMT)
                e.Graphics.DrawString(Riga.Zoccoli, FONT, Brushes.Black, RbZocc, FMT)

                If Riga.Diagonali = True Then e.Graphics.DrawString("X", FONT, Brushes.Black, rbdiag, FMT)

                If Riga.DT = True Then e.Graphics.DrawString("DT", FONT, Brushes.Black, RbDTBM, FMT)
                If Riga.BM = True Then e.Graphics.DrawString("BM", FONT, Brushes.Black, RbDTBM, FMT)

                e.Graphics.DrawString(Imballo.Gradi_F, FONT, Brushes.Black, RbDiagF, FMT)
                e.Graphics.DrawString(Imballo.Gradi_T, FONT, Brushes.Black, RbDiagT, FMT)

                e.Graphics.DrawString(Riga.Data_Ordine, FONT, Brushes.Gray, RbVuoto2, FMT)

                e.Graphics.DrawString(Imballo.M2, FONT, Brushes.Black, Rbm2, FMT)
                e.Graphics.DrawString(Imballo.M3, FONT, Brushes.Black, Rbm3, FMT)

            Catch ex As Exception
                MsgBox("Errore durante la stampa del piè di pagina " & vbCrLf & " ORDINE: " & Riga.Ordine & " RIGA: " & Riga.Riga & vbCrLf & ex.Message, vbCritical, "Errore")
            End Try

        End Sub
        Private Sub Rivestimento(e As Printing.PrintPageEventArgs, Riga As ModPackDBDataSet.OrdiniRow)

            Try

                If Riga.Rivestimento = True Then

                    Dim Riga_Rivest As ModPackDBDataSet.RivestimentiRow
                    Riga_Rivest = DataSet.Rivestimenti.Where(Function(X) X.Tipo_Rivestimento = Riga.Tipo_Rivestimento).FirstOrDefault

                    Dim Riga_Setup As ModPackDBDataSet.Setup_RivestRow
                    Riga_Setup = DataSet.Setup_Rivest.Where(Function(X) X.Tipo = Riga.Tipo).FirstOrDefault

                    Dim RectRivestimento As New Rectangle(e.MarginBounds.Right - 305, e.MarginBounds.Top + 480, 300, 150)

                    Dim Riga1RIV As New Rectangle(RectRivestimento.Left, RectRivestimento.Top, RectRivestimento.Width, 25)
                    Dim Riga2RIV As New Rectangle(Riga1RIV.Left, Riga1RIV.Bottom, Riga1RIV.Width, Riga1RIV.Height)
                    Dim Riga3RIV As New Rectangle(Riga1RIV.Left, Riga2RIV.Bottom, Riga1RIV.Width, Riga1RIV.Height)
                    Dim Riga4RIV As New Rectangle(Riga1RIV.Left, Riga3RIV.Bottom, Riga1RIV.Width, Riga1RIV.Height)
                    Dim Riga5RIV As New Rectangle(Riga1RIV.Left, Riga4RIV.Bottom, Riga1RIV.Width, Riga1RIV.Height)
                    Dim RigaNoteRIV As New Rectangle(Riga1RIV.Left, Riga5RIV.Bottom, Riga1RIV.Width, Riga1RIV.Height)

                    e.Graphics.DrawRectangles(Pens.LightGray, {Riga1RIV, Riga2RIV, Riga3RIV, Riga4RIV, Riga5RIV})

                    Dim Q As Single = Riga1RIV.Width / 6

                    Dim RectBRiv As New Rectangle(Riga2RIV.Left, Riga2RIV.Top, Q, Riga2RIV.Height)
                    Dim RectCRiv As New Rectangle(Riga2RIV.Left, Riga3RIV.Top, Q, Riga2RIV.Height)
                    Dim RectFRiv As New Rectangle(Riga3RIV.Left, Riga4RIV.Top, Q, Riga3RIV.Height)
                    Dim RectTRiv As New Rectangle(Riga4RIV.Left, Riga5RIV.Top, Q, Riga4RIV.Height)

                    Dim RectBRivValore As New Rectangle(RectBRiv.Right, Riga2RIV.Top, Q * 3, Riga2RIV.Height)
                    Dim RectCRivValore As New Rectangle(RectBRiv.Right, Riga3RIV.Top, Q * 3, Riga2RIV.Height)
                    Dim RectFRivValore As New Rectangle(RectFRiv.Right, Riga4RIV.Top, Q * 3, Riga3RIV.Height)
                    Dim RectTRivValore As New Rectangle(RectTRiv.Right, Riga5RIV.Top, Q * 3, Riga4RIV.Height)

                    Dim RectBRivQt As New Rectangle(RectBRivValore.Right, Riga2RIV.Top, Q, Riga2RIV.Height)
                    Dim RectCRivQt As New Rectangle(RectCRivValore.Right, Riga3RIV.Top, Q, Riga2RIV.Height)
                    Dim RectFRivQt As New Rectangle(RectFRivValore.Right, Riga4RIV.Top, Q, Riga3RIV.Height)
                    Dim RectTRivQt As New Rectangle(RectTRivValore.Right, Riga5RIV.Top, Q, Riga4RIV.Height)

                    Dim RectBRivQt2 As New Rectangle(RectBRivQt.Right, Riga2RIV.Top, Q, Riga2RIV.Height)
                    Dim RectCRivQt2 As New Rectangle(RectBRivQt.Right, Riga3RIV.Top, Q, Riga2RIV.Height)
                    Dim RectFRivQt2 As New Rectangle(RectFRivQt.Right, Riga4RIV.Top, Q, Riga3RIV.Height)
                    Dim RectTRivQt2 As New Rectangle(RectTRivQt.Right, Riga5RIV.Top, Q, Riga4RIV.Height)


                    e.Graphics.DrawRectangles(Pens.LightGray, {RectBRiv, RectCRiv, RectFRiv, RectTRiv, RectBRivQt, RectCRivQt, RectFRivQt, RectTRivQt})





                    '// Riga 0 - DESCRIZIONE
                    If Not Riga_Rivest.IsDescrizioneNull Then e.Graphics.DrawString(Riga_Rivest.Descrizione, New Font("Calibri", My.Settings.DimensioneFontDistinta, FontStyle.Bold), Brushes.Black, Riga1RIV, FMT)

                    '// Riga 1 - BANCALE
                    If Riga_Setup.NB > 0 Then
                        Dim Stringa1riv As String = (Riga.L + Riga_Setup._BX_) & " X " & (Riga.P + Riga_Setup._BY_)
                        e.Graphics.DrawString("B", fnt, Brushes.Black, RectBRiv, FMT)
                        e.Graphics.DrawString(Stringa1riv, fnt, Brushes.Black, RectBRivValore, FMT)
                        e.Graphics.DrawString(Riga_Setup.NB, fnt, Brushes.Black, RectBRivQt, FMT)
                        If Riga.Qt > 1 Then e.Graphics.DrawString("[" & Riga.Qt * Riga_Setup.NB & "]", fnt, Brushes.Black, RectBRivQt2, FMT)
                    End If

                    '// Riga 2 - COPERCHIO
                    If Riga_Setup.NC > 0 Then
                        Dim Stringa2riv As String = (Riga.L + Riga_Setup._CX_) & " X " & (Riga.P + Riga_Setup._CY_)
                        e.Graphics.DrawString("C", fnt, Brushes.Black, RectCRiv, FMT)
                        e.Graphics.DrawString(Stringa2riv, fnt, Brushes.Black, RectCRivValore, FMT)
                        e.Graphics.DrawString(Riga_Setup.NC, fnt, Brushes.Black, RectCRivQt, FMT)
                        If Riga.Qt > 1 Then e.Graphics.DrawString("[" & Riga.Qt * Riga_Setup.NC & "]", fnt, Brushes.Black, RectCRivQt2, FMT)
                    End If

                    '// Riga 3 - FIANCATE
                    If Riga_Setup.NF > 0 Then
                        Dim Stringa3riv As String = (Riga.L + Riga_Setup._FX_) & " X " & (Riga.H + Riga_Setup._FY_)
                        e.Graphics.DrawString("F", fnt, Brushes.Black, RectFRiv, FMT)
                        e.Graphics.DrawString(Stringa3riv, fnt, Brushes.Black, RectFRivValore, FMT)
                        e.Graphics.DrawString(Riga_Setup.NF, fnt, Brushes.Black, RectFRivQt, FMT)
                        If Riga.Qt > 1 Then e.Graphics.DrawString("[" & Riga.Qt * Riga_Setup.NF & "]", fnt, Brushes.Black, RectFRivQt2, FMT)
                    End If

                    '// Riga 4 - TESTE
                    If Riga_Setup.NT > 0 Then
                        Dim Stringa4riv As String = (Riga.P + Riga_Setup._TX_) & " X " & (Riga.H + Riga_Setup._TY_)
                        e.Graphics.DrawString("T", fnt, Brushes.Black, RectTRiv, FMT)
                        e.Graphics.DrawString(Stringa4riv, fnt, Brushes.Black, RectTRivValore, FMT)
                        e.Graphics.DrawString(Riga_Setup.NT, fnt, Brushes.Black, RectTRivQt, FMT)
                        If Riga.Qt > 1 Then e.Graphics.DrawString("[" & Riga.Qt * Riga_Setup.NT & "]", fnt, Brushes.Black, RectTRivQt2, FMT)
                    End If

                    '// Riga 5 - NOTE
                    If Not Riga_Setup.IsNoteNull Then e.Graphics.DrawString(Riga_Setup.Note, fnt, Brushes.Black, RigaNoteRIV, FMT)


                    e.Graphics.DrawRectangle(New Pen(Color.LightGray, 3), RectRivestimento)

                End If

            Catch ex As Exception
                MsgBox("Errore durante la stampa della tabella rivestimento" & vbCrLf & " ORDINE: " & Riga.Ordine & " RIGA: " & Riga.Riga & vbCrLf & ex.Message, vbCritical, "Errore")
            End Try

        End Sub
        Private Sub Foto(e As Printing.PrintPageEventArgs, riga As ModPackDBDataSet.OrdiniRow)

            Try

                Dim RectIMG As New Rectangle(e.MarginBounds.Right - 305, e.MarginBounds.Top + 175, 300, 300)

                Dim RigaImballo As ModPackDBDataSet.ImballiRow
                RigaImballo = DataSet.Imballi.Where(Function(X) X.Imballo = riga.Imballo).FirstOrDefault

                If Not RigaImballo.IsImgNull Then
                    e.Graphics.DrawRectangle(Pens.LightGray, RectIMG)
                    FunzioniStampa.ImmagineInRettangolo(Immagine.ConvertFromBytes(RigaImballo.Img), RectIMG, e)
                End If

            Catch ex As Exception
                LOG.Write("Errore durante la stampa della foto" & vbCrLf & " ORDINE: " & riga.Ordine & " RIGA: " & riga.Riga & vbCrLf & ex.Message)
            End Try

        End Sub
        Private Sub Note(e As Printing.PrintPageEventArgs, riga As ModPackDBDataSet.OrdiniRow)

            Try

                Dim RigaIndice As ModPackDBDataSet.IndiciRow
                RigaIndice = DataSet.Indici.Where(Function(X) X.Indice = riga.Indice).FirstOrDefault

                Dim RigaNoteImballi As ModPackDBDataSet.NoteImballiRow
                RigaNoteImballi = DataSet.NoteImballi.Where(Function(X) X.Imballo = riga.Imballo).FirstOrDefault

                Dim FormatNote As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center, .HotkeyPrefix = Drawing.Text.HotkeyPrefix.Show, .Trimming = StringTrimming.EllipsisCharacter}

                Dim RectNote1 As New Rectangle(e.MarginBounds.Left + 5, e.MarginBounds.Bottom - 290, e.MarginBounds.Width / 2 - 10, 80)
                Dim RectNote2 As New Rectangle(RectNote1.Left, RectNote1.Bottom + 5, RectNote1.Width, 80)

                e.Graphics.DrawString("NOTE 1", New Font("Calibri", 8), Brushes.LightGray, RectNote1)
                e.Graphics.DrawString("NOTE 2", New Font("Calibri", 8), Brushes.LightGray, RectNote2)

                Dim NOTE1 As String = ""
                Dim NOTE2 As String = ""
                Dim NOTE3 As String = ""
                Dim NOTE4 As String = ""

                If Not riga.IsNoteNull Then NOTE1 = riga.Note
                If Not riga.IsRivest_TotNull Then NOTE2 = riga.Rivest_Tot
                If Not RigaNoteImballi Is Nothing Then NOTE3 = RigaNoteImballi.Nota

                If Not RigaIndice Is Nothing Then
                    If Not RigaIndice.IsNote_BICNull Then NOTE4 = RigaIndice.Note_BIC
                End If

                e.Graphics.DrawString(NOTE1 & vbCrLf & NOTE2, fnt, Brushes.Black, RectNote1, FormatNote)
                e.Graphics.DrawString(NOTE3 & vbCrLf & NOTE4, fnt, Brushes.Black, RectNote2, FormatNote)

                e.Graphics.DrawRectangles(Pens.LightGray, {RectNote1, RectNote2})

            Catch ex As Exception
                LOG.Write("Errore durante la stampa delle note" & vbCrLf & " ORDINE: " & riga.Ordine & " RIGA: " & riga.Riga & vbCrLf & ex.Message)
            End Try

        End Sub
        Private Sub Morale(e As Printing.PrintPageEventArgs, riga As ModPackDBDataSet.OrdiniRow)
            If riga.Zoccoli = "2V" Then

                Try


                    Dim RigaMorale As ModPackDBDataSet.DistintaRow
                    RigaMorale = DataSet.Distinta.Where(Function(X) X.Imballo = riga.Imballo).Where(Function(y) y.Tag = "MOR").FirstOrDefault

                    Dim RigaTipo As ModPackDBDataSet.TipiRow
                    RigaTipo = DataSet.Tipi.Where(Function(X) X.Tipo = riga.Tipo).FirstOrDefault


                    If Not RigaMorale Is Nothing Then

                        Dim Fontz As New Font("Calibri", 7)

                        Dim Xmorale = RigaMorale.X * 2
                        Dim Ymorale = RigaMorale.Y * 2

                        Dim R As New Rectangle(e.MarginBounds.Right - 305, e.MarginBounds.Top + 110, 60, 60)
                        e.Graphics.DrawRectangle(Pens.Gray, R)

                        Dim Centro As New PointF(R.X + (R.Width / 2), R.Y + (R.Height / 2))
                        Dim Morale As New Rectangle(Centro.X - (Xmorale / 2), Centro.Y - (Ymorale / 2), Xmorale, Ymorale)

                        Dim RmisuraX As New Rectangle(R.X, R.Y, R.Width, 20)
                        Dim RmisuraY As New Rectangle(R.Right - 20, R.Y, 20, R.Height)
                        Dim Rfresato As New Rectangle(R.X, R.Bottom - 15, R.Width, 15)

                        e.Graphics.FillRectangle(Brushes.Wheat, Morale)
                        e.Graphics.DrawRectangle(Pens.Black, Morale)

                        e.Graphics.DrawString(Convert.ToInt16(RigaMorale.X), Fontz, Brushes.Black, RmisuraX, FMT)
                        e.Graphics.DrawString(Convert.ToInt16(RigaMorale.Y), Fontz, Brushes.Black, RmisuraY, FMT)

                        If RigaTipo.FresataMorali = True Then
                            e.Graphics.DrawString("FRESARE", New Font("Calibri", 7, FontStyle.Bold), Brushes.Black, Rfresato, FMT)
                        End If
                    End If

                Catch ex As Exception
                    MsgBox("Errore durante la stampa del disegno del morale" & vbCrLf & " ORDINE: " & riga.Ordine & " RIGA: " & riga.Riga & vbCrLf & ex.Message, vbCritical, "Errore")
                End Try


            End If
        End Sub
        Private Sub CodiceABarre(e As Printing.PrintPageEventArgs, riga As ModPackDBDataSet.OrdiniRow)
            Try
                Dim RectBarcode As New Rectangle(e.MarginBounds.Right - 305, e.MarginBounds.Top + 110, 300, 60)

                If My.Settings.StampaBarcodeDistinte = True Then

                    Dim Codice As Image

                    If My.Settings.StampaBarcodeSoloCodice = True Then
                        'Stampa l'indice della tabella ordini riferito all'imballo
                        Codice = BarCode.Genera(riga.Id, True, 50, 7)
                    Else
                        'Stampa il nome dell'imballo | quantità
                        Codice = BarCode.Genera(riga.Imballo & "|" & riga.Qt, False, 50, 7)
                    End If

                    Dim P As New Point With {.X = RectBarcode.Right - (Codice.Width) - 20, .Y = RectBarcode.Y}
                    e.Graphics.DrawImage(Codice, P)
                End If

            Catch ex As Exception
                MsgBox("Errore durante la stampa del barcode" & vbCrLf & " ORDINE: " & riga.Ordine & " RIGA: " & riga.Riga & vbCrLf & ex.Message, vbCritical, "Errore")
            End Try

        End Sub
        Private Sub TipoBancale(e As Printing.PrintPageEventArgs, riga As ModPackDBDataSet.OrdiniRow)
            Try

                If Not String.IsNullOrEmpty(riga.Zoccoli) Then
                    If riga.Tipo = "C" Then Exit Sub
                    Dim RettangoloZocc As New Rectangle(398, e.MarginBounds.Top + 110, 60, 40)
                    e.Graphics.DrawRectangle(New Pen(Color.Black, 3), RettangoloZocc)
                    e.Graphics.DrawString(riga.Zoccoli, New Font("Calibri", 18, FontStyle.Bold), Brushes.Black, RettangoloZocc, FMT)
                End If

            Catch ex As Exception
            MsgBox("Errore durante la stampa del tipo bancale" & vbCrLf & " ORDINE: " & riga.Ordine & " RIGA: " & riga.Riga & vbCrLf & ex.Message, vbCritical, "Errore")
            End Try
        End Sub
        Private Sub InfoTipo(e As Printing.PrintPageEventArgs, riga As ModPackDBDataSet.OrdiniRow)
            Try


                Dim InfoTipo As ModPackDBDataSet.TipiRow = DataSet.Tipi.Where(Function(x) x.Tipo = riga.Tipo).FirstOrDefault

                If Not InfoTipo.IsInfoNull And Not InfoTipo Is Nothing Then
                    Dim RectInfoTipo As New Rectangle(e.MarginBounds.Right - 305, e.MarginBounds.Top + 495, 300, 50)
                    e.Graphics.FillRectangle(Brushes.LightYellow, RectInfoTipo)
                    e.Graphics.DrawRectangle(New Pen(Color.Black, 2), RectInfoTipo)
                    e.Graphics.DrawString(InfoTipo.Info.ToUpper, New Font("Calibri", fnt.Size, FontStyle.Bold), Brushes.Black, RectInfoTipo, FMT)
                End If

            Catch ex As Exception
                MsgBox("Errore durante la stampa delle info tipo" & vbCrLf & " ORDINE: " & riga.Ordine & " RIGA: " & riga.Riga & vbCrLf & ex.Message, vbCritical, "Errore")
            End Try

        End Sub
        Private Sub AvvisoEvaso(e As Printing.PrintPageEventArgs, riga As ModPackDBDataSet.OrdiniRow)
            Try
                If riga.Evaso = True Then
                    Dim FontEvaso As New Font("Calibri", 24, FontStyle.Bold)
                    Dim Point As New PointF((e.MarginBounds.Width \ 2) - (e.Graphics.MeasureString("IMBALLO EVASO", FontEvaso).Width / 2), (e.MarginBounds.Height \ 2) - (e.Graphics.MeasureString("IMBALLO EVASO", FontEvaso).Height / 2))
                    e.Graphics.DrawString("IMBALLO EVASO", FontEvaso, Brushes.Black, Point)
                End If
            Catch ex As Exception
                MsgBox("Errore durante la stampa dell'avviso IMBALLO EVASO" & vbCrLf & " ORDINE: " & riga.Ordine & " RIGA: " & riga.Riga & vbCrLf & ex.Message, vbCritical, "Errore")
            End Try
        End Sub
        Private Sub Montanti_Testo(e As Printing.PrintPageEventArgs, riga As ModPackDBDataSet.OrdiniRow)

            Try

                If riga.H > 0 Then

                    Dim Imballo As ModPackDBDataSet.ImballiRow
                    Imballo = DataSet.Imballi.Where(Function(X) X.Imballo = riga.Imballo).FirstOrDefault

                    Dim RectMonT As New Rectangle(e.MarginBounds.Right - 55, e.MarginBounds.Bottom - 330, 50, 200)
                    Dim RectMonF As New Rectangle(RectMonT.Left - 55, e.MarginBounds.Bottom - 330, 50, 200)

                    Dim RectSopraF As New Rectangle(RectMonF.Left, RectMonF.Top, RectMonF.Width, 50)
                    Dim RectSopraT As New Rectangle(RectMonT.Left, RectMonT.Top, RectMonT.Width, 50)
                    Dim RectSottoF As New Rectangle(RectMonF.Left, RectMonF.Bottom - 50, RectMonF.Width, 50)
                    Dim RectSottoT As New Rectangle(RectMonT.Left, RectMonT.Bottom - 50, RectMonT.Width, 50)

                    Dim RectUP As New Rectangle(RectMonF.Left, RectMonF.Top - 45, 105, 40)

                    e.Graphics.DrawString("MONTANTI", New Font("Calibri", 10), Brushes.Black, RectUP, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Near})
                    e.Graphics.DrawString("Fiancate", New Font("Calibri", 10), Brushes.Black, RectUP, New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Far})
                    e.Graphics.DrawString("Teste", New Font("Calibri", 10), Brushes.Black, RectUP, New StringFormat With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Far})

                    e.Graphics.DrawRectangles(Pens.LightGray, {RectUP}) ', RectMonF, RectMonT}) ', RectSopraF, RectSopraT, RectSottoF, RectSottoT})

                    'Fiancata
                    If Not Imballo.SopraMF = 0 Then e.Graphics.DrawString(Imballo.SopraMF.ToString("0.##"), fnt, Brushes.Black, RectSopraF, FMT)
                    If Not Imballo.SottoMF = 0 Then e.Graphics.DrawString(Imballo.SottoMF.ToString("0.##"), fnt, Brushes.Black, RectSottoF, FMT)
                    e.Graphics.DrawString(Imballo.H.ToString("0.##"), fnt, Brushes.Black, RectMonF, FMT)

                    'Testa
                    If Not Imballo.SopraMT = 0 Then e.Graphics.DrawString(Imballo.SopraMT.ToString("0.##"), fnt, Brushes.Black, RectSopraT, FMT)
                    If Not Imballo.SottoMT = 0 Then e.Graphics.DrawString(Imballo.SottoMT.ToString("0.##"), fnt, Brushes.Black, RectSottoT, FMT)
                    e.Graphics.DrawString(Imballo.H.ToString("0.##"), fnt, Brushes.Black, RectMonT, FMT)

                    End If

            Catch ex As Exception
                LOG.Write("Errore durante la stampa info montanti testuale" & vbCrLf & " ORDINE: " & riga.Ordine & " RIGA: " & riga.Riga & vbCrLf & ex.Message)
            End Try

        End Sub

        'Distinta
        Dim ListaDistinta As New List(Of ModPackDBDataSet.DistintaRow)
        Private Sub Distinta(e As Printing.PrintPageEventArgs, riga As ModPackDBDataSet.OrdiniRow)

            'Riempio lista delle righe distinta relative all'imballo che sto stampando
            ListaDistinta = DataSet.Distinta.Where(Function(X) X.Imballo = riga.Imballo).ToList
            ListaDistinta = ListaDistinta.OrderBy(Function(X) X.Riga).ToList

            Dim Imballo As ModPackDBDataSet.ImballiRow
            Imballo = DataSet.Imballi.Where(Function(x) x.Imballo = riga.Imballo).First

            Dim fnt As New Font("Calibri", My.Settings.DimensioneFontDistinta)

            Dim TOTALE_RIGHE As Integer = ListaDistinta.Count
            If TOTALE_RIGHE < My.Settings.NumeroRigheDistinta Then TOTALE_RIGHE = My.Settings.NumeroRigheDistinta 'Se ci sono troppe righe le stringe, se no resta formattato giusto

            Dim R_Misure As New Rectangle(e.MarginBounds.Left + 5, e.MarginBounds.Top + 110, e.MarginBounds.Width / 2 - 10, e.MarginBounds.Height - 450) '245)
            Dim Rect_Riga As New Rectangle(R_Misure.Left, R_Misure.Top, R_Misure.Width, R_Misure.Height / (TOTALE_RIGHE + 5)) ' era TOTALE_RIGHE +4

            '############### BANCALE #################
            If ListaDistinta.Any(Function(x) x.Part = "B") Then
                Riga_Descrizione_Part(e, Rect_Riga, "BANCALE")

                For Each K As ModPackDBDataSet.DistintaRow In ListaDistinta.Where(Function(x) x.Part = "B")
                    If Not K.N = 0 Then
                        Riga_Distinta(e, Rect_Riga, K, riga, Imballo)
                    End If
                Next
            End If

            '############### COPERCHIO ###############
            If ListaDistinta.Any(Function(x) x.Part = "C") Then
                Riga_Descrizione_Part(e, Rect_Riga, "COPERCHIO")

                For Each K As ModPackDBDataSet.DistintaRow In ListaDistinta.Where(Function(x) x.Part = "C")
                    If Not K.N = 0 Then
                        Riga_Distinta(e, Rect_Riga, K, riga, Imballo)
                    End If
                Next
            End If

            '############### FIANCATE ################
            If ListaDistinta.Any(Function(x) x.Part = "F") Then
                Riga_Descrizione_Part(e, Rect_Riga, "FIANCATE")

                For Each K As ModPackDBDataSet.DistintaRow In ListaDistinta.Where(Function(x) x.Part = "F")
                    If Not K.N = 0 Then
                        Riga_Distinta(e, Rect_Riga, K, riga, Imballo)
                    End If
                Next
            End If

            '############### TESTE ###################
            If ListaDistinta.Any(Function(x) x.Part = "T") Then
                Riga_Descrizione_Part(e, Rect_Riga, "TESTE")

                For Each K As ModPackDBDataSet.DistintaRow In ListaDistinta.Where(Function(x) x.Part = "T")
                    If Not K.N = 0 Then
                        Riga_Distinta(e, Rect_Riga, K, riga, Imballo)
                    End If
                Next
            End If

            '############### CORREDO #################
            If ListaDistinta.Any(Function(x) x.Part = "K") Then
                Riga_Descrizione_Part(e, Rect_Riga, "CORREDO")

                For Each K As ModPackDBDataSet.DistintaRow In ListaDistinta.Where(Function(x) x.Part = "K")
                    If Not K.N = 0 Then
                        Riga_Distinta(e, Rect_Riga, K, riga, Imballo)
                    End If
                Next
            End If

            '############### ZOCCOLI INTERNI ###################
            If ListaDistinta.Any(Function(x) x.Part = "I") Then
                Riga_Descrizione_Part(e, Rect_Riga, "ZOCCOLI INTERNI")

                For Each K As ModPackDBDataSet.DistintaRow In ListaDistinta.Where(Function(x) x.Part = "I")
                    If Not K.N = 0 Then
                        Riga_Distinta(e, Rect_Riga, K, riga, Imballo)
                    End If
                Next
            End If


            '############### ALTRO ###################
            'Tutte le righe che non sono B C F T o K, tranne N che non viene stampata
            If ListaDistinta.Any(Function(x) Not {"B", "C", "F", "T", "K", "N", "I"}.Contains(x.Part)) Then
                Riga_Descrizione_Part(e, Rect_Riga, "ALTRO")

                For Each K As ModPackDBDataSet.DistintaRow In ListaDistinta.Where(Function(x) Not {"B", "C", "F", "T", "K", "N", "I"}.Contains(x.Part))
                    If Not K.N = 0 Then
                        Riga_Distinta(e, Rect_Riga, K, riga, Imballo)
                    End If
                Next
            End If


        End Sub
        Private Sub Riga_Distinta(ByVal e As Printing.PrintPageEventArgs, ByRef Rect As Rectangle, ByVal Row As ModPackDBDataSet.DistintaRow, ByVal RigaOrdine As ModPackDBDataSet.OrdiniRow, ByVal RigaImballo As ModPackDBDataSet.ImballiRow)

            Dim Format As StringFormat = New StringFormat(StringFormatFlags.LineLimit) With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter}

            Dim FNT As New Font("Calibri", My.Settings.DimensioneFontDistinta)
            Dim FNTbold As New Font("Calibri", My.Settings.DimensioneFontDistinta + 2, FontStyle.Bold)
            Dim FNT1 As New Font("Calibri", My.Settings.DimensioneFontDistinta - 2)
            Dim FNT_Tag As New Font("Calibri", 8, FontStyle.Italic)
            Dim FNT_TagBold As New Font("Calibri", 10, FontStyle.Underline Xor FontStyle.Bold)

            Dim Unit As Double = Rect.Width / 21

            If Row.Y >= 4 Then FNT = FNTbold

            Dim R_CM As New Rectangle(Rect.Left, Rect.Top, Unit * 2, Rect.Height)
            Dim R_mX As New Rectangle(R_CM.Right, Rect.Top, Unit * 3, Rect.Height)
            Dim R_x1 As New Rectangle(R_mX.Right, Rect.Top, Unit, Rect.Height)
            Dim R_mY As New Rectangle(R_x1.Right, Rect.Top, Unit * 3, Rect.Height)
            Dim R_x2 As New Rectangle(R_mY.Right, Rect.Top, Unit, Rect.Height)
            Dim R_mZ As New Rectangle(R_x2.Right, Rect.Top, Unit * 3, Rect.Height)
            Dim R_Ug As New Rectangle(R_mZ.Right, Rect.Top, Unit, Rect.Height)
            Dim R_N As New Rectangle(R_Ug.Right, Rect.Top, Unit * 3, Rect.Height)
            Dim R_Ntot As New Rectangle(R_N.Right, Rect.Top, Unit * 4, Rect.Height)
            Dim R_Tag As New Rectangle(R_Ntot.Right, Rect.Top, Unit * 2, Rect.Height)

            'e.Graphics.DrawRectangle(New Pen(Color.LightGray, 0.5), R_Ntot)

            e.Graphics.DrawRectangle(Pens.LightGray, Rect)

            e.Graphics.DrawString("Cm", FNT1, Brushes.Black, R_CM, Format)
            e.Graphics.DrawString("x", FNT, Brushes.Black, R_x1, Format)
            e.Graphics.DrawString("x", FNT, Brushes.Black, R_x2, Format)
            e.Graphics.DrawString("=", FNT, Brushes.Black, R_Ug, Format)

            Dim R_mX_L As New Rectangle(R_mX.Left - Unit, R_mX.Top, R_mX.Width + (Unit * 2), R_mX.Height)
            Dim R_mY_L As New Rectangle(R_mY.Left - Unit, R_mY.Top, R_mY.Width + (Unit * 2), R_mY.Height)
            Dim R_mZ_L As New Rectangle(R_mZ.Left - Unit, R_mZ.Top, R_mZ.Width + (Unit * 2), R_mZ.Height)

            'Rettangoli più larghi cosi non si tronca
            e.Graphics.DrawString(Row.X.ToString("0.##"), FNT, Brushes.Black, R_mX_L, Format)
            e.Graphics.DrawString(Row.Y.ToString("0.##"), FNT, Brushes.Black, R_mY_L, Format)
            e.Graphics.DrawString(Row.Z.ToString("0.##"), FNT, Brushes.Black, R_mZ_L, Format)


            If Row.Tag = "BTL" And RigaImballo.DT = True Then
                e.Graphics.DrawString((Row.N / 2) & "+" & (Row.N / 2), FNT, Brushes.Black, R_N, Format)
            Else
                e.Graphics.DrawString(Row.N, FNT, Brushes.Black, R_N, Format)
            End If

            If RigaOrdine.Qt > 1 Then e.Graphics.DrawString("[" & Row.N * RigaOrdine.Qt & "]", FNT1, Brushes.Gray, R_Ntot, Format)

            '####### Scritta Diagonali ########
            Select Case Row.Tag

                Case "FD" ' Diagonali Fiancate
                    FNT_Tag = FNT_TagBold
                    e.Graphics.DrawString("Diag. " & RigaImballo.Gradi_F & "°", FNT_Tag, Brushes.Gray, R_Tag.X, R_Tag.Y)

                Case "TD" ' Diagonali Teste
                    FNT_Tag = FNT_TagBold
                    e.Graphics.DrawString("Diag. " & RigaImballo.Gradi_T & "°", FNT_Tag, Brushes.Gray, R_Tag.X, R_Tag.Y)
            End Select
            '###################################

            Rect.Y += Rect.Height

        End Sub
        Private Sub Riga_Descrizione_Part(ByVal e As Printing.PrintPageEventArgs, ByRef Rettangolo As Rectangle, ByVal Descrizione As String)
            e.Graphics.FillRectangle(Brushes.LightGray, Rettangolo.X, Rettangolo.Y + 3, Rettangolo.Width - 3, Rettangolo.Height - 6)
            e.Graphics.DrawRectangle(Pens.LightGray, Rettangolo)
            e.Graphics.DrawString(Descrizione.ToUpper, fnt, Brushes.Black, Rettangolo, FMT)
            Rettangolo.Y += Rettangolo.Height
        End Sub

        'Disegni
        Private Sub Bancale_G(e As Printing.PrintPageEventArgs, Riga As ModPackDBDataSet.OrdiniRow)

            Try

                Dim Imballo As ModPackDBDataSet.ImballiRow
                Imballo = DataSet.Imballi.Where(Function(X) X.Imballo = Riga.Imballo).FirstOrDefault

                Dim R_Bancale As New Rectangle(e.MarginBounds.Left + 5, e.MarginBounds.Bottom - 120, e.MarginBounds.Width - 10, 65)
                Dim Centro As New PointF(R_Bancale.Left + (R_Bancale.Width / 2), R_Bancale.Top + (R_Bancale.Height / 2))

                'Estrae le righe del bancale dalla distinta
                Dim Distinta As List(Of ModPackDBDataSet.DistintaRow)
                Distinta = DataSet.Distinta.Where(Function(X) X.Imballo = Riga.Imballo).Where(Function(y) y.Part = "B").ToList

                Dim N_Zoccoli As Integer = Distinta.Where(Function(X) X.Riga = 1).Select(Function(y) y.N).First
                Dim LunghezzaTavola As Integer = Distinta.Where(Function(X) X.Tag = "BTL").Select(Function(y) y.Z).First
                Dim N_TavoleSopra As Integer = Distinta.Where(Function(X) X.Tag = "BTT").Select(Function(y) y.N).First

                Dim Scala As Single
                Dim Primo As Single

                Select Case LunghezzaTavola
                    Case <= 120
                        'Bancale piccolo
                        Scala = (e.MarginBounds.Width - 40) / 3
                        Primo = 40
                    Case < 400
                        'Bancale medio
                        Scala = (e.MarginBounds.Width - 40) / 2
                        Primo = 40
                    Case >= 400
                        'Bancale grande
                        Scala = (e.MarginBounds.Width - 40)
                        Primo = 40
                End Select

                Tavola(Centro.X - (Scala / 2), Centro.Y - 2, Scala, 4, e)   'Tavola lunga

                Dim InterasseZoccoli As Single = (Scala - (Primo * 2)) / (N_Zoccoli - 1)                ' Interasse tra i morali ( su disegno )
                Dim NTavoleInMezzo As Integer = (N_TavoleSopra - N_Zoccoli - 2) / (N_Zoccoli - 1)       ' Numero di tavoel in mezzo ai morali

                Dim InterasseTavoleInMezzo As Single = InterasseZoccoli / (NTavoleInMezzo + 1)          ' Interasse tra le tavole in mezzo ( su disegno)

                Dim XZoccolo As Single = Centro.X - (Scala / 2) + Primo                                 ' Quota X primo zoccolo
                Dim XTavola As Single = XZoccolo + InterasseTavoleInMezzo                               ' Quota X prima tavola in mezzo 

                ' ##### DISEGNO ZOCCOLI E TAVOLE SOPRA #####

                Try

                    Tavola(Centro.X - (Scala \ 2), Centro.Y - 6, 20, 4, e)          'Tavola a sx
                    Tavola(Centro.X + (Scala \ 2) - 20, Centro.Y - 6, 20, 4, e)     'Tavola a dx

                    For K = 1 To N_Zoccoli
                        Tavola(XZoccolo - 10, Centro.Y - 6, 20, 4, e)               'Tavola sopra allo zoccolo
                        Zoccolo(XZoccolo, Centro.Y + 2, Riga.Zoccoli, e)            'Zoccolo

                        XTavola = XZoccolo + InterasseTavoleInMezzo                 'Quota X della prima tavola in mezzo ai morali

                        For C = 1 To NTavoleInMezzo
                            If Not K = N_Zoccoli Then
                                Tavola(XTavola - 10, Centro.Y - 6, 20, 4, e)        'Tavole in mezzo ai morali
                                XTavola += InterasseTavoleInMezzo
                            End If
                        Next

                        XZoccolo += InterasseZoccoli                                'Quota X dei morali
                    Next

                Catch ex As Exception
                    LOG.Write("Errore durante la stampa del disegno del bancale" & vbCrLf & " ORDINE: " & Riga.Ordine & " RIGA: " & Riga.Riga & vbCrLf & ex.Message)
                End Try

                ' ##### QUOTE #####

                Try

                    If N_Zoccoli Mod 2 > 0 Then
                        'Quota sotto al morale centrale se c'è
                        Quota(LunghezzaTavola / 2, Centro.X, Centro.Y + 22, e)
                    End If

                    Quota(LunghezzaTavola, Centro.X, Centro.Y - 22, e)

                    Dim Interasse As Integer = Math.Round((LunghezzaTavola - (Imballo.Primo_Morale * 2)) / (N_Zoccoli - 1), 0)  ' Calcolo distantra tra il centro dei due morali

                    'v.3.2 23/01/2019
                    AvvisoTranspallet(N_Zoccoli, Interasse, e)

                    Dim QuotaMorale As Integer = Imballo.Primo_Morale

                    Dim ZoccoloSX As Single = Centro.X - (Scala / 2) + Primo
                    Dim ZoccoloDX As Single = Centro.X + (Scala / 2) - Primo

                    For K = 1 To (N_Zoccoli / 2)
                        Quota(QuotaMorale, ZoccoloSX, Centro.Y + 22, e)
                        Quota(QuotaMorale, ZoccoloDX, Centro.Y + 22, e)

                        ZoccoloSX += InterasseZoccoli
                        ZoccoloDX -= InterasseZoccoli
                        QuotaMorale += Interasse
                    Next

                Catch ex As Exception
                    LOG.Write("Errore durante la stampa delle quote sul bancale" & vbCrLf & " ORDINE: " & Riga.Ordine & " RIGA: " & Riga.Riga & vbCrLf & ex.Message)
                End Try

            Catch ex As Exception
                LOG.Write("Errore durante il disegno del bancale" & vbCrLf & " ORDINE: " & Riga.Ordine & " RIGA: " & Riga.Riga & vbCrLf & ex.Message)
            End Try

        End Sub
        Private Sub Bancale_P_T(e As Printing.PrintPageEventArgs, Riga As ModPackDBDataSet.OrdiniRow)

            Try

                Dim Imballo As ModPackDBDataSet.ImballiRow
                Imballo = DataSet.Imballi.Where(Function(X) X.Imballo = Riga.Imballo).FirstOrDefault

                Dim R_Bancale As New Rectangle(e.MarginBounds.Left + 5, e.MarginBounds.Bottom - 120, e.MarginBounds.Width - 10, 65)
                Dim Centro As New PointF(R_Bancale.Left + (R_Bancale.Width / 2), R_Bancale.Top + (R_Bancale.Height / 2))

                'Estrae le righe del bancale dalla distinta
                Dim Distinta As List(Of ModPackDBDataSet.DistintaRow)
                Distinta = DataSet.Distinta.Where(Function(X) X.Imballo = Riga.Imballo).Where(Function(y) y.Part = "B").ToList

                Dim N_Zoccoli As Integer = Distinta.Where(Function(X) X.Riga = 1).Select(Function(y) y.N).FirstOrDefault
                Dim LunghezzaTavola As Integer = Distinta.Where(Function(X) X.Tag = "BTL").Select(Function(y) y.Z).FirstOrDefault
                Dim N_TavoleSopra As Integer = Distinta.Where(Function(X) X.Tag = "BTT").Select(Function(y) y.N).FirstOrDefault

                Dim Scala As Single
                Dim Primo As Single

                Select Case LunghezzaTavola
                    Case <= 120
                        'Bancale piccolo
                        Scala = (e.MarginBounds.Width - 40) / 3
                        Primo = 40
                    Case < 400
                        'Bancale medio
                        Scala = (e.MarginBounds.Width - 40) / 2
                        Primo = 40
                    Case >= 400
                        'Bancale grande
                        Scala = (e.MarginBounds.Width - 40)
                        Primo = 40
                End Select

                Tavola(Centro.X - (Scala / 2), Centro.Y - 2, Scala, 4, e)   'Tavola lunga

                Dim InterasseZoccoli As Single = (Scala - (Primo * 2)) / (N_Zoccoli - 1)                ' Interasse tra i morali ( su disegno )
                Dim XZoccolo As Single = Centro.X - (Scala / 2) + Primo                                 ' Quota X primo zoccolo
                ' Quota X prima tavola in mezzo 

                ' ##### DISEGNO ZOCCOLI E TAVOLE SOPRA #####

                Try

                    If N_TavoleSopra >= 2 Then 'Se sono segnate almeno due tavole sotto il bancale
                        Tavola(Centro.X - (Scala \ 2), Centro.Y + 2, 20, 4, e)          'Tavola a sx
                        Tavola(Centro.X + (Scala \ 2) - 20, Centro.Y + 2, 20, 4, e)     'Tavola a dx
                    End If

                    For K = 1 To N_Zoccoli

                        If K > 1 And K < N_Zoccoli And N_TavoleSopra > 0 Then

                            'WORKAROUND
                            'SOLO E PURAMENTE per fare disegnare la tavola attaccata al morale
                            '(altrimenti col 2v restava un po staccata)
                            Dim LarghezzaZoccolo As Integer = 20
                            If Riga.Zoccoli = "2V" Then LarghezzaZoccolo = 10
                            '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

                            If K <= N_Zoccoli / 2 Then
                                Tavola(XZoccolo - (LarghezzaZoccolo / 2) - 20, Centro.Y + 2, 20, 4, e) 'Tavola a sx dello zoccolo
                            Else
                                Tavola(XZoccolo + (LarghezzaZoccolo / 2), Centro.Y + 2, 20, 4, e)       'Tavola a dx dello zoccolo
                            End If

                            'PRIME JERE CUSI
                            'If K <= N_Zoccoli / 2 Then
                            'Tavola(XZoccolo - 30, Centro.Y + 2, 20, 4, e)
                            'Else
                            'Tavola(XZoccolo + 10, Centro.Y + 2, 20, 4, e)
                            'End If

                        End If

                        Zoccolo(XZoccolo, Centro.Y + 2, Riga.Zoccoli, e)            'Zoccolo

                        XZoccolo += InterasseZoccoli                                'Quota X dei morali

                    Next

                Catch ex As Exception
                    LOG.Write("Errore durante la stampa del disegno del bancale" & vbCrLf & " ORDINE: " & Riga.Ordine & " RIGA: " & Riga.Riga & vbCrLf & ex.Message)
                End Try

                ' ##### QUOTE #####

                Try

                    If N_Zoccoli Mod 2 > 0 Then
                        'Quota sotto al morale centrale se c'è
                        Quota(LunghezzaTavola / 2, Centro.X, Centro.Y + 22, e)
                    End If

                    Quota(LunghezzaTavola, Centro.X, Centro.Y - 22, e)

                    Dim Interasse As Integer = Math.Round((LunghezzaTavola - (Imballo.Primo_Morale * 2)) / (N_Zoccoli - 1), 0)  ' Calcolo distantra tra il centro dei due morali

                    'v.3.2 23/01/2019
                    AvvisoTranspallet(N_Zoccoli, Interasse, e)

                    Dim QuotaMorale As Integer = Imballo.Primo_Morale

                    Dim ZoccoloSX As Single = Centro.X - (Scala / 2) + Primo
                    Dim ZoccoloDX As Single = Centro.X + (Scala / 2) - Primo

                    For K = 1 To (N_Zoccoli / 2)
                        Quota(QuotaMorale, ZoccoloSX, Centro.Y + 22, e)
                        Quota(QuotaMorale, ZoccoloDX, Centro.Y + 22, e)

                        ZoccoloSX += InterasseZoccoli
                        ZoccoloDX -= InterasseZoccoli
                        QuotaMorale += Interasse
                    Next

                Catch ex As Exception
                    LOG.Write("Errore durante la stampa delle quote sul bancale" & vbCrLf & " ORDINE: " & Riga.Ordine & " RIGA: " & Riga.Riga & vbCrLf & ex.Message)
                End Try

            Catch ex As Exception
                LOG.Write("Errore durante il disegno del bancale" & vbCrLf & " ORDINE: " & Riga.Ordine & " RIGA: " & Riga.Riga & vbCrLf & ex.Message)
            End Try

        End Sub
        Private Sub Bancale_GDA(e As Printing.PrintPageEventArgs, Riga As ModPackDBDataSet.OrdiniRow)

            Try

                Dim Imballo As ModPackDBDataSet.ImballiRow
                Imballo = DataSet.Imballi.Where(Function(X) X.Imballo = Riga.Imballo).FirstOrDefault

                Dim R_Bancale As New Rectangle(e.MarginBounds.Left + 5, e.MarginBounds.Bottom - 120, e.MarginBounds.Width - 10, 65)
                Dim Centro As New PointF(R_Bancale.Left + (R_Bancale.Width / 2), R_Bancale.Top + (R_Bancale.Height / 2))

                'Estrae le righe del bancale dalla distinta
                Dim Distinta As List(Of ModPackDBDataSet.DistintaRow)
                Distinta = DataSet.Distinta.Where(Function(X) X.Imballo = Riga.Imballo).Where(Function(y) y.Part = "B").ToList

                Dim N_Zoccoli As Integer = Distinta.Where(Function(X) X.Riga = 1).Select(Function(y) y.N).FirstOrDefault
                Dim LunghezzaTavola As Integer = Distinta.Where(Function(X) X.Tag = "BTL").Select(Function(y) y.Z).FirstOrDefault
                Dim N_TavoleSopra As Integer = Distinta.Where(Function(X) X.Tag = "BTT").Select(Function(y) y.N).FirstOrDefault

                Dim Scala As Single
                Dim Primo As Single

                Select Case LunghezzaTavola
                    Case <= 120
                        'Bancale piccolo
                        Scala = (e.MarginBounds.Width - 40) / 3
                        Primo = 40
                    Case < 400
                        'Bancale medio
                        Scala = (e.MarginBounds.Width - 40) / 2
                        Primo = 40
                    Case >= 400
                        'Bancale grande
                        Scala = (e.MarginBounds.Width - 40)
                        Primo = 40
                End Select

                Tavola(Centro.X - (Scala / 2), Centro.Y - 2, Scala, 4, e)   'Tavola lunga

                Dim InterasseZoccoli As Single = (Scala - (Primo * 2)) / (N_Zoccoli - 1)                ' Interasse tra i morali ( su disegno )
                Dim NTavoleInMezzo As Integer = (N_TavoleSopra - 2 - N_Zoccoli - 2) / (N_Zoccoli - 1)       ' Numero di tavoel in mezzo ai morali

                Dim InterasseTavoleInMezzo As Single = InterasseZoccoli / (NTavoleInMezzo + 1)          ' Interasse tra le tavole in mezzo ( su disegno)

                Dim XZoccolo As Single = Centro.X - (Scala / 2) + Primo                                 ' Quota X primo zoccolo
                Dim XTavola As Single = XZoccolo + InterasseTavoleInMezzo                               ' Quota X prima tavola in mezzo 

                ' ##### DISEGNO ZOCCOLI E TAVOLE SOPRA #####

                Try

                    For K = 1 To N_Zoccoli
                        Tavola(XZoccolo - 10, Centro.Y - 6, 20, 4, e)               'Tavola sopra allo zoccolo
                        Zoccolo(XZoccolo, Centro.Y + 2, Riga.Zoccoli, e)            'Zoccolo

                        XTavola = XZoccolo + InterasseTavoleInMezzo                 'Quota X della prima tavola in mezzo ai morali

                        For C = 1 To NTavoleInMezzo
                            If Not K = N_Zoccoli Then
                                Tavola(XTavola - 10, Centro.Y - 6, 20, 4, e)        'Tavole in mezzo ai morali
                                XTavola += InterasseTavoleInMezzo
                            End If
                        Next

                        Tavola(Centro.X - (Scala \ 2), Centro.Y - 6, 20, 4, e)          'Tavola a sx
                        Tavola(Centro.X - (Scala \ 2) + 20, Centro.Y - 6, 20, 4, e)
                        Tavola(Centro.X - (Scala \ 2) + 40, Centro.Y - 6, 20, 4, e)

                        Tavola(Centro.X + (Scala \ 2) - 20, Centro.Y - 6, 20, 4, e)     'Tavola a dx
                        Tavola(Centro.X + (Scala \ 2) - 40, Centro.Y - 6, 20, 4, e)
                        Tavola(Centro.X + (Scala \ 2) - 60, Centro.Y - 6, 20, 4, e)


                        XZoccolo += InterasseZoccoli                                'Quota X dei morali
                    Next

                Catch ex As Exception
                    LOG.Write("Errore durante la stampa del disegno del bancale" & vbCrLf & " ORDINE: " & Riga.Ordine & " RIGA: " & Riga.Riga & vbCrLf & ex.Message)
                End Try

                ' ##### QUOTE #####

                Try

                    If N_Zoccoli Mod 2 > 0 Then
                        'Quota sotto al morale centrale se c'è
                        Quota(LunghezzaTavola / 2, Centro.X, Centro.Y + 22, e)
                    End If

                    Quota(LunghezzaTavola, Centro.X, Centro.Y - 22, e)

                    Dim Interasse As Integer = Math.Round((LunghezzaTavola - (Imballo.Primo_Morale * 2)) / (N_Zoccoli - 1), 0)  ' Calcolo distantra tra il centro dei due morali

                    'v.3.2 23/01/2019
                    AvvisoTranspallet(N_Zoccoli, Interasse, e)

                    Dim QuotaMorale As Integer = Imballo.Primo_Morale

                    Dim ZoccoloSX As Single = Centro.X - (Scala / 2) + Primo
                    Dim ZoccoloDX As Single = Centro.X + (Scala / 2) - Primo

                    For K = 1 To (N_Zoccoli / 2)
                        Quota(QuotaMorale, ZoccoloSX, Centro.Y + 22, e)
                        Quota(QuotaMorale, ZoccoloDX, Centro.Y + 22, e)

                        ZoccoloSX += InterasseZoccoli
                        ZoccoloDX -= InterasseZoccoli
                        QuotaMorale += Interasse
                    Next

                Catch ex As Exception
                    LOG.Write("Errore durante la stampa delle quote sul bancale" & vbCrLf & " ORDINE: " & Riga.Ordine & " RIGA: " & Riga.Riga & vbCrLf & ex.Message)
                End Try

            Catch ex As Exception
                LOG.Write("Errore durante il disegno del bancale" & vbCrLf & " ORDINE: " & Riga.Ordine & " RIGA: " & Riga.Riga & vbCrLf & ex.Message)
            End Try

        End Sub
        Private Sub Bancale_GST(e As Printing.PrintPageEventArgs, Riga As ModPackDBDataSet.OrdiniRow)

            Try

                Dim Imballo As ModPackDBDataSet.ImballiRow
                Imballo = DataSet.Imballi.Where(Function(X) X.Imballo = Riga.Imballo).FirstOrDefault

                Dim R_Bancale As New Rectangle(e.MarginBounds.Left + 5, e.MarginBounds.Bottom - 120, e.MarginBounds.Width - 10, 65)
                Dim Centro As New PointF(R_Bancale.Left + (R_Bancale.Width / 2), R_Bancale.Top + (R_Bancale.Height / 2))

                'Estrae le righe del bancale dalla distinta
                Dim Distinta As List(Of ModPackDBDataSet.DistintaRow)
                Distinta = DataSet.Distinta.Where(Function(X) X.Imballo = Riga.Imballo).Where(Function(y) y.Part = "B").ToList

                Dim N_Zoccoli As Integer = Distinta.Where(Function(X) X.Riga = 1).Select(Function(y) y.N).FirstOrDefault
                Dim LunghezzaTavola As Integer = Distinta.Where(Function(X) X.Tag = "BTL").Select(Function(y) y.Z).FirstOrDefault


                Dim Scala As Single
                Dim Primo As Single

                Select Case LunghezzaTavola
                    Case <= 120
                        'Bancale piccolo
                        Scala = (e.MarginBounds.Width - 40) / 3
                        Primo = 40
                    Case < 400
                        'Bancale medio
                        Scala = (e.MarginBounds.Width - 40) / 2
                        Primo = 40
                    Case >= 400
                        'Bancale grande
                        Scala = (e.MarginBounds.Width - 40)
                        Primo = 40
                End Select

                Tavola(Centro.X - (Scala / 2), Centro.Y - 2, Scala, 4, e)   'Tavola lunga

                Dim InterasseZoccoli As Single = (Scala) / (N_Zoccoli - 1)                ' Interasse tra i morali ( su disegno )
                Dim XZoccolo As Single = Centro.X - (Scala / 2) - 5                       ' Quota X primo zoccolo


                ' ##### DISEGNO ZOCCOLI E TAVOLA SOTTO #####

                Try

                    Zoccolo(Centro.X - (Scala / 2) + 3, Centro.Y + 2, "EUR", e)
                    Zoccolo(Centro.X + (Scala / 2) - 3, Centro.Y + 2, "EUR", e)

                    For K = 2 To N_Zoccoli - 1
                        XZoccolo += InterasseZoccoli
                        Zoccolo(XZoccolo, Centro.Y + 2, "EUR", e)            'Zoccolo
                    Next

                    Tavola(Centro.X - (Scala / 2) - 7, Centro.Y + 18, Scala + 14, 4, e)


                Catch ex As Exception
                    LOG.Write("Errore durante la stampa del disegno del bancale" & vbCrLf & " ORDINE: " & Riga.Ordine & " RIGA: " & Riga.Riga & vbCrLf & ex.Message)
                End Try

                ' ##### QUOTE #####

                Try

                    If N_Zoccoli Mod 2 > 0 Then
                        'Quota sotto al morale centrale se c'è
                        Quota((LunghezzaTavola + 4) / 2, Centro.X, Centro.Y + 22, e)
                    End If

                    Quota(LunghezzaTavola, Centro.X, Centro.Y - 22, e)

                    Quota("+2", Centro.X - (Scala / 2) - 5, Centro.Y - 22, e)
                    Quota("+2", Centro.X + (Scala / 2) + 5, Centro.Y - 22, e)

                    Quota("<- " & LunghezzaTavola + 4, Centro.X + (Scala / 2) + 30, Centro.Y + 12, e)


                    Dim Interasse As Decimal = ((LunghezzaTavola + 4 - 10) / (N_Zoccoli - 1)) ' Calcolo distantra tra il centro dei due morali

                    'v.3.2 23/01/2019
                    AvvisoTranspallet(N_Zoccoli, Interasse, e)

                    Dim QuotaMorale As Decimal = 0

                    Dim ZoccoloSX As Single = Centro.X - (Scala / 2)
                    Dim ZoccoloDX As Single = Centro.X + (Scala / 2)

                    For K = 1 To (N_Zoccoli / 2)

                        If K > 1 Then 'Salta la prima quota ( lo 0 )

                            Quota(Math.Round(QuotaMorale + 5, 0), ZoccoloSX, Centro.Y + 22, e)
                            Quota(Math.Round(QuotaMorale + 5, 0), ZoccoloDX, Centro.Y + 22, e)

                        End If

                        ZoccoloSX += InterasseZoccoli
                        ZoccoloDX -= InterasseZoccoli
                        QuotaMorale += Interasse

                    Next

                Catch ex As Exception
                    LOG.Write("Errore durante la stampa delle quote sul bancale" & vbCrLf & " ORDINE: " & Riga.Ordine & " RIGA: " & Riga.Riga & vbCrLf & ex.Message)
                End Try

            Catch ex As Exception
                LOG.Write("Errore durante il disegno del bancale" & vbCrLf & " ORDINE: " & Riga.Ordine & " RIGA: " & Riga.Riga & vbCrLf & ex.Message)
            End Try

        End Sub
        Private Sub Bancale_C(e As Printing.PrintPageEventArgs, Riga As ModPackDBDataSet.OrdiniRow)

            Try

                Dim Imballo As ModPackDBDataSet.ImballiRow
                Imballo = DataSet.Imballi.Where(Function(X) X.Imballo = Riga.Imballo).FirstOrDefault

                Dim R_Bancale As New Rectangle(e.MarginBounds.Left + 5, e.MarginBounds.Bottom - 120, e.MarginBounds.Width - 10, 65)
                Dim Centro As New PointF(R_Bancale.Left + (R_Bancale.Width / 2), R_Bancale.Top + (R_Bancale.Height / 2))

                'Estrae le righe del bancale dalla distinta
                Dim Distinta As List(Of ModPackDBDataSet.DistintaRow)
                Distinta = DataSet.Distinta.Where(Function(X) X.Imballo = Riga.Imballo).Where(Function(y) y.Part = "B").ToList

                If Distinta.Any(Function(x) x.Tag = "MOR") Then
                    'Prosegue solamente se ci sono zoccoli

                    Dim N_Zoccoli As Integer = Distinta.Where(Function(X) X.Tag = "MOR").Select(Function(y) y.N).FirstOrDefault

                    Dim LunghezzaBase As Integer = Distinta.Where(Function(X) X.Tag = "BAS").Select(Function(y) y.X).FirstOrDefault

                    Dim Scala As Single
                    Dim Primo As Single

                    Select Case LunghezzaBase
                        Case <= 120
                            'Bancale piccolo
                            Scala = (e.MarginBounds.Width - 40) / 3
                            Primo = 20
                        Case < 400
                            'Bancale medio
                            Scala = (e.MarginBounds.Width - 40) / 2
                            Primo = 20
                        Case >= 400
                            'Bancale grande
                            Scala = (e.MarginBounds.Width - 40)
                            Primo = 20
                    End Select

                    Tavola(Centro.X - (Scala / 2), Centro.Y - 2, Scala, 4, e)   'Tavola lunga

                    Dim InterasseZoccoli As Single = (Scala - (Primo * 2)) / (N_Zoccoli - 1)                ' Interasse tra i morali ( su disegno )
                    Dim XZoccolo As Single = Centro.X - (Scala / 2) + Primo                                 ' Quota X primo zoccolo

                    ' ##### DISEGNO ZOCCOLI E TAVOLE SOPRA #####

                    Try

                        For K = 1 To N_Zoccoli

                            Zoccolo(XZoccolo, Centro.Y + 2, "2V", e)            'Zoccolo
                            XZoccolo += InterasseZoccoli                                'Quota X dei morali

                        Next

                    Catch ex As Exception
                        LOG.Write("Errore durante la stampa del disegno del bancale" & vbCrLf & " ORDINE: " & Riga.Ordine & " RIGA: " & Riga.Riga & vbCrLf & ex.Message)
                    End Try

                    ' ##### QUOTE #####

                    Try

                        If N_Zoccoli Mod 2 > 0 Then
                            'Quota sotto al morale centrale se c'è
                            Quota(LunghezzaBase / 2, Centro.X, Centro.Y + 22, e)
                        End If

                        Quota(LunghezzaBase, Centro.X, Centro.Y - 22, e)

                        Dim Interasse As Integer = Math.Round((LunghezzaBase - (Imballo.Primo_Morale * 2)) / (N_Zoccoli - 1), 0)  ' Calcolo distantra tra il centro dei due morali

                        'v.3.2 23/01/2019
                        AvvisoTranspallet(N_Zoccoli, Interasse, e)

                        Dim QuotaMorale As Integer = Imballo.Primo_Morale

                        Dim ZoccoloSX As Single = Centro.X - (Scala / 2) + Primo
                        Dim ZoccoloDX As Single = Centro.X + (Scala / 2) - Primo

                        For K = 1 To (N_Zoccoli / 2)
                            Quota(QuotaMorale, ZoccoloSX, Centro.Y + 22, e)
                            Quota(QuotaMorale, ZoccoloDX, Centro.Y + 22, e)

                            ZoccoloSX += InterasseZoccoli
                            ZoccoloDX -= InterasseZoccoli
                            QuotaMorale += Interasse
                        Next

                    Catch ex As Exception
                        LOG.Write("Errore durante la stampa delle quote sul bancale" & vbCrLf & " ORDINE: " & Riga.Ordine & " RIGA: " & Riga.Riga & vbCrLf & ex.Message)
                    End Try

                End If

            Catch ex As Exception
                LOG.Write("Errore durante il disegno del bancale" & vbCrLf & " ORDINE: " & Riga.Ordine & " RIGA: " & Riga.Riga & vbCrLf & ex.Message)
            End Try

        End Sub

        Private Sub Montanti_G(e As Printing.PrintPageEventArgs, riga As ModPackDBDataSet.OrdiniRow)
            Try
                '(150 * Valore) / H --- Scala

                Dim Imballo As ModPackDBDataSet.ImballiRow = DataSet.Imballi.Where(Function(X) X.Imballo = riga.Imballo).FirstOrDefault

                Dim NTavoleF As Integer = DataSet.Distinta.Where(Function(X) X.Imballo = riga.Imballo).Where(Function(y) y.Tag = "FTL").Select(Function(z) z.N).FirstOrDefault \ 2
                Dim NTavoleT As Integer = DataSet.Distinta.Where(Function(X) X.Imballo = riga.Imballo).Where(Function(y) y.Tag = "TTL").Select(Function(z) z.N).FirstOrDefault \ 2

                Dim RectMonT As New Rectangle(e.MarginBounds.Right - 55, e.MarginBounds.Bottom - 330, 50, 200)
                Dim RectMonF As New Rectangle(RectMonT.Left - 55, e.MarginBounds.Bottom - 330, 50, 200)

                'Fiancate
                Tavola(RectMonF.X + 4, RectMonF.Y + 25, 4, 150, e)  'Montante
                Tavola(RectMonF.X, RectMonF.Y + 25 + Scala(Imballo.SopraMF, Imballo.H), 4, Scala(10, Imballo.H), e) 'Tavola sopra
                Tavola(RectMonF.X, RectMonF.Y + 175 - Scala(10, Imballo.H) - Scala(Imballo.SottoMF, Imballo.H), 4, Scala(10, Imballo.H), e) 'Tavola sotto

                'Teste
                Tavola(RectMonT.X + 4, RectMonT.Y + 25, 4, 150, e)  'Montante
                Tavola(RectMonT.X, RectMonT.Y + 25 + Scala(Imballo.SopraMT, Imballo.H), 4, Scala(10, Imballo.H), e) 'Tavola sopra
                Tavola(RectMonT.X, RectMonT.Y + 175 - Scala(10, Imballo.H) - Scala(Imballo.SottoMT, Imballo.H), 4, Scala(10, Imballo.H), e) 'Tavola sotto

                'Tavoel in mezzo fiancate
                Dim SpazioF As Decimal = (150 + Scala(Imballo.SopraMF, Imballo.H) - Scala(Imballo.SottoMF, Imballo.H) - Scala(10, Imballo.H)) / (NTavoleF - 1)
                Dim YTAVF As Single = SpazioF

                For K = 3 To NTavoleF

                    Tavola(RectMonF.X, RectMonF.Y + 25 - Scala(Imballo.SopraMF, Imballo.H) + YTAVF, 4, Scala(10, Imballo.H), e) 'Tavole in mezzo fiancate
                    YTAVF += SpazioF

                Next

                'Tavole in mezzo teste
                Dim SpazioT As Decimal = (150 + Scala(Imballo.SopraMT, Imballo.H) - Scala(Imballo.SottoMT, Imballo.H) - Scala(10, Imballo.H)) / (NTavoleT - 1)
                Dim YTAVT As Single = SpazioF

                For K = 3 To NTavoleT

                    Tavola(RectMonT.X, RectMonT.Y + 25 - Scala(Imballo.SopraMT, Imballo.H) + YTAVT, 4, Scala(10, Imballo.H), e) 'Tavole in mezzo fiancate
                    YTAVT += SpazioT

                Next
            Catch ex As Exception
                LOG.Write("Errore durante il disegno dei montanti " & vbCrLf & " ORDINE: " & riga.Ordine & " RIGA: " & riga.Riga & vbCrLf & ex.Message)
            End Try

        End Sub
        Private Sub Montanti_GDA(e As Printing.PrintPageEventArgs, riga As ModPackDBDataSet.OrdiniRow)
            Try
                '(150 * Valore) / H --- Scala

                Dim Imballo As ModPackDBDataSet.ImballiRow = DataSet.Imballi.Where(Function(X) X.Imballo = riga.Imballo).FirstOrDefault

                Dim NTavoleF As Integer = DataSet.Distinta.Where(Function(X) X.Imballo = riga.Imballo).Where(Function(y) y.Tag = "FTL").Select(Function(z) z.N).FirstOrDefault \ 2
                Dim NTavoleT As Integer = DataSet.Distinta.Where(Function(X) X.Imballo = riga.Imballo).Where(Function(y) y.Tag = "TTL").Select(Function(z) z.N).FirstOrDefault \ 2

                Dim RectMonT As New Rectangle(e.MarginBounds.Right - 55, e.MarginBounds.Bottom - 330, 50, 200)
                Dim RectMonF As New Rectangle(RectMonT.Left - 55, e.MarginBounds.Bottom - 330, 50, 200)

                'Fiancate
                Tavola(RectMonF.X + 4, RectMonF.Y + 25, 4, 150, e)  'Montante
                Tavola(RectMonF.X, RectMonF.Y + 25 + Scala(Imballo.SopraMF, Imballo.H), 4, Scala(10, Imballo.H), e) 'Tavola sopra
                Tavola(RectMonF.X, RectMonF.Y + 175 - Scala(10, Imballo.H) - Scala(Imballo.SottoMF, Imballo.H), 4, Scala(10, Imballo.H), e) 'Tavola sotto
                Tavola(RectMonF.X, RectMonF.Y + 175 - Scala(20, Imballo.H) - Scala(Imballo.SottoMF, Imballo.H), 4, Scala(10, Imballo.H), e) '2 Tavola sotto
                Tavola(RectMonF.X, RectMonF.Y + 175 - Scala(30, Imballo.H) - Scala(Imballo.SottoMF, Imballo.H), 4, Scala(10, Imballo.H), e) '3 Tavola sotto

                'Teste
                Tavola(RectMonT.X + 4, RectMonT.Y + 25, 4, 150, e)  'Montante
                Tavola(RectMonT.X, RectMonT.Y + 25 + Scala(Imballo.SopraMT, Imballo.H), 4, Scala(10, Imballo.H), e) 'Tavola sopra
                Tavola(RectMonT.X, RectMonT.Y + 175 - Scala(10, Imballo.H) - Scala(Imballo.SottoMT, Imballo.H), 4, Scala(10, Imballo.H), e) 'Tavola sotto

                Tavola(RectMonT.X, RectMonT.Y + 175 - Scala(20, Imballo.H) - Scala(Imballo.SottoMT, Imballo.H), 4, Scala(10, Imballo.H), e) 'Tavola sotto
                Tavola(RectMonT.X, RectMonT.Y + 175 - Scala(30, Imballo.H) - Scala(Imballo.SottoMT, Imballo.H), 4, Scala(10, Imballo.H), e) 'Tavola sotto


                'Tavole in mezzo fiancate
                Dim SpazioF As Decimal = (150 + Scala(Imballo.SopraMF, Imballo.H) - Scala(Imballo.SottoMF, Imballo.H) - Scala(30, Imballo.H)) / (NTavoleF - 3)
                Dim YTAVF As Single = SpazioF

                For K = 3 To NTavoleF - 2

                    Tavola(RectMonF.X, RectMonF.Y + 25 - Scala(Imballo.SopraMF, Imballo.H) + YTAVF, 4, Scala(10, Imballo.H), e) 'Tavole in mezzo fiancate
                    YTAVF += SpazioF

                Next
                'Tavole in mezzo teste
                Dim SpazioT As Decimal = (150 + Scala(Imballo.SopraMT, Imballo.H) - Scala(Imballo.SottoMT, Imballo.H) - Scala(30, Imballo.H)) / (NTavoleT - 3)
                Dim YTAVT As Single = SpazioF

                For K = 3 To NTavoleT - 2

                    Tavola(RectMonT.X, RectMonT.Y + 25 - Scala(Imballo.SopraMT, Imballo.H) + YTAVT, 4, Scala(10, Imballo.H), e) 'Tavole in mezzo fiancate
                    YTAVT += SpazioT

                Next
            Catch ex As Exception
                LOG.Write("Errore durante il disegno dei montanti" & vbCrLf & " ORDINE: " & riga.Ordine & " RIGA: " & riga.Riga & vbCrLf & ex.Message)
            End Try

        End Sub

        Private Sub AvvisoTranspallet(ByVal NMOR As Integer, ByVal Interasse As Single, ByVal e As Printing.PrintPageEventArgs)

            Dim Font As New Font("Arial", 8, FontStyle.Bold Or FontStyle.Underline)

            If NMOR Mod 2 = 0 Then
                If Interasse <= 65 Then
                    e.Graphics.DrawString("ATTENZIONE: Spazio per il transpallet almeno 60cm", Font, Brushes.Black, e.MarginBounds.Left + 5, e.MarginBounds.Bottom - 120)
                End If
            Else
                If Interasse * 2 <= 65 Then
                    e.Graphics.DrawString("ATTENZIONE: Spazio per il transpallet almeno 60cm", Font, Brushes.Black, e.MarginBounds.Left + 5, e.MarginBounds.Bottom - 120)
                End If

            End If


        End Sub

        '#####################################################################################################################################
        'API Disegni
        Private Sub Tavola(X As Single, Y As Single, Width As Single, Height As Single, e As Printing.PrintPageEventArgs)
            e.Graphics.FillRectangle(Brushes.Wheat, X, Y, Width, Height)
            e.Graphics.DrawRectangle(Pens.Gray, X, Y, Width, Height)
        End Sub
        Private Sub Zoccolo(X As Single, Y As Single, Tipo As String, e As Printing.PrintPageEventArgs)

            Select Case Tipo
                Case "2V"
                    e.Graphics.FillRectangle(Brushes.DarkGoldenrod, X - 5, Y, 10, 20)
                    e.Graphics.DrawRectangle(Pens.Gray, X - 5, Y, 10, 20)
                Case "EUR"
                    e.Graphics.FillRectangle(Brushes.Wheat, X - 10, Y, 20, 20)
                    e.Graphics.FillRectangle(Brushes.DarkGoldenrod, X - 10, Y + 4, 20, 12)
                    e.Graphics.DrawRectangle(Pens.Gray, X - 10, Y, 20, 20)
                    e.Graphics.DrawRectangle(Pens.Gray, X - 10, Y + 4, 20, 12)

            End Select

        End Sub
        Private Sub Quota(Stringa As String, X As Single, Y As Single, e As Printing.PrintPageEventArgs)
            Dim Dimensione As SizeF = e.Graphics.MeasureString(Stringa, New Font("Calibri", 10))
            e.Graphics.DrawString(Stringa, New Font("Calibri", 10), Brushes.Black, X - (Dimensione.Width / 2), Y)
        End Sub
        Private Function Scala(Valore, H) As Single
            Dim Scalato As Single = (150 * Valore) / H


            Return Scalato
        End Function



    End Module
    End Namespace