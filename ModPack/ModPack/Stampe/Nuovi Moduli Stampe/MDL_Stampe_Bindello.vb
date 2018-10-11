Namespace Bindelli
    Module MDL_Stampe_Bindello

        Private ListaBindelli As New List(Of ModPackDBDataSet.OrdiniRow)
        Private FMT As New StringFormat With {.Alignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter, .LineAlignment = StringAlignment.Center}
        Private WithEvents PRINTER As New System.Drawing.Printing.PrintDocument

        Public Sub Stampa(Lista As List(Of ModPackDBDataSet.OrdiniRow), Optional Anteprima As Boolean = False)

            ListaBindelli = Lista
            Set_Settings()

            Select Case Anteprima

                Case True
                    Using Ante As New PrintPreviewDialog
                        Ante.Document = PRINTER
                        Ante.ShowDialog()
                    End Using

                Case False
                    PRINTER.Print()

            End Select



        End Sub

        Private Sub Set_Settings()
            PRINTER.PrinterSettings.PrinterName = My.Settings.Etichette_Stampante
            Dim psz As New Printing.PaperSize With {.RawKind = Printing.PaperKind.Custom, .Width = (My.Settings.Etichette_DimensioneX / 0.254), .Height = (My.Settings.Etichette_DimensioneY / 0.254)}
            PRINTER.DefaultPageSettings.PaperSize = psz
            With PRINTER.DefaultPageSettings.Margins
                .Top = (My.Settings.Etichette_MargineTop / 0.254)
                .Bottom = (My.Settings.Etichette_MargineBottom / 0.254)
                .Left = (My.Settings.Etichette_MargineLeft / 0.254)
                .Right = (My.Settings.Etichette_MargineRight / 0.254)
            End With
        End Sub
        Private Sub Stampa_Bindelli_Print(sender As Object, e As Printing.PrintPageEventArgs) Handles PRINTER.PrintPage

            Dim BindelliDaStampare As Integer = ListaBindelli.Count - 1
            Static BindelloAttuale As Integer = 0


            Dim Font As New Font("Calibri", 20, FontStyle.Regular)
            Dim FontCliente As New Font("Calibri", 23, FontStyle.Bold)
            Dim FontBold As New Font("Calibri", 20, FontStyle.Bold)
            Dim Piccolo As New Font("Calibri", 6, FontStyle.Regular)

            Dim Riga1 As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height / 5)
            Dim Riga2 As New Rectangle(e.MarginBounds.Left, Riga1.Bottom, e.MarginBounds.Width, e.MarginBounds.Height / 5)
            Dim Riga3 As New Rectangle(e.MarginBounds.Left, Riga2.Bottom, e.MarginBounds.Width, e.MarginBounds.Height / 5)
            Dim Riga4 As New Rectangle(e.MarginBounds.Left, Riga3.Bottom, e.MarginBounds.Width, e.MarginBounds.Height / 5)
            Dim Riga5 As New Rectangle(e.MarginBounds.Left, Riga4.Bottom, e.MarginBounds.Width, e.MarginBounds.Height / 5)

            e.Graphics.DrawRectangle(Pens.LightGray, Riga1)
            e.Graphics.DrawRectangle(Pens.LightGray, Riga2)
            e.Graphics.DrawRectangle(Pens.LightGray, Riga3)
            e.Graphics.DrawRectangle(Pens.LightGray, Riga4)
            ' e.Graphics.DrawRectangle(Pens.Black, Riga5)


            '# RIGA 1   -   LOGO, MAGAZZINO
            Dim RectLogo As New Rectangle(Riga1.Left, Riga1.Top, Riga1.Width / 3 * 2, Riga1.Height)
            Dim RectMagazzino As New Rectangle(RectLogo.Right, Riga1.Top, Riga1.Width / 3, Riga1.Height)

            e.Graphics.DrawRectangle(Pens.LightGray, RectLogo)

            '# RIGA 2   -   CLIENTE
            Dim RectCliente As New Rectangle(Riga2.Left, Riga2.Top, Riga2.Width, Riga2.Height)

            '# RIGA 3   -   DISEGNO
            Dim RectD As New Rectangle(Riga3.Left, Riga3.Top, Riga3.Width / 4, Riga3.Height)
            Dim RectDisegno As New Rectangle(RectD.Right, Riga3.Top, Riga3.Width / 4 * 3, Riga3.Height)

            e.Graphics.DrawRectangle(Pens.LightGray, RectD)

            '# RIGA 4   -   COMMESSA
            Dim RectC As New Rectangle(Riga4.Left, Riga4.Top, Riga4.Width / 4, Riga4.Height)
            Dim RectCommessa As New Rectangle(RectC.Right, Riga4.Top, Riga4.Width / 4 * 3, Riga4.Height)

            e.Graphics.DrawRectangle(Pens.LightGray, RectC)

            '# RIGA 5   -   CODICE, QT, ORDINE
            Dim RectCodice As New Rectangle(Riga5.Left, Riga5.Top, Riga5.Width / 5 * 2, Riga5.Height)
            Dim RectQt As New Rectangle(RectCodice.Right, Riga5.Top, Riga5.Width / 5, Riga5.Height)
            Dim RectOrdine As New Rectangle(RectQt.Right, Riga5.Top, Riga5.Width / 5 * 2, Riga5.Height)

            e.Graphics.FillRectangle(Brushes.LightGray, RectOrdine)
            e.Graphics.DrawRectangle(Pens.LightGray, Riga5)
            e.Graphics.DrawRectangle(Pens.LightGray, RectQt)

            With ListaBindelli(BindelloAttuale)

                'ImmagineInRettangolo(My.Resources.Logo, RectLogo, e)
                Dim DataConsegna As Date = .Data_Consegna
                Dim Week As Integer = DatePart(DateInterval.WeekOfYear, DataConsegna, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFourDays)

                Dim Mag_DESC As String = SQL.GetSQLValue("SELECT Descrizione FROM Magazzini WHERE Codice = '" & .Magazzino & "'")

                e.Graphics.DrawString("SETT. " & Week, New Font("Calibri", 28, FontStyle.Bold), Brushes.Black, RectLogo, FMT)

                ' ################################################################################################################

                e.Graphics.DrawString("MAGAZZINO", Piccolo, Brushes.Gray, RectMagazzino)
                e.Graphics.DrawString("CLIENTE", Piccolo, Brushes.Gray, RectCliente)
                e.Graphics.DrawString("CODICE", Piccolo, Brushes.Gray, RectCodice)
                e.Graphics.DrawString("QT", Piccolo, Brushes.Gray, RectQt)

                ' ################################################################################################################

                e.Graphics.DrawString(Mag_DESC, New Font("Calibri", FunzioniStampa.TestoInRettangolo(Mag_DESC, RectMagazzino, e), FontStyle.Bold), Brushes.Black, RectMagazzino, FMT)
                e.Graphics.DrawString(.Cliente, FontCliente, Brushes.Black, RectCliente, FMT)
                e.Graphics.DrawString("D", Font, Brushes.Black, RectD, FMT)
                e.Graphics.DrawString(.Codice, New Font("Calibri", FunzioniStampa.TestoInRettangolo(.Codice, RectDisegno, e), FontStyle.Regular), Brushes.Black, RectDisegno, FMT)
                e.Graphics.DrawString("C", Font, Brushes.Black, RectC, FMT)
                e.Graphics.DrawString(.Commessa, New Font("Calibri", FunzioniStampa.TestoInRettangolo(.Commessa, RectCommessa, e), FontStyle.Regular), Brushes.Black, RectCommessa, FMT)
                e.Graphics.DrawString(.Imballo, FontBold, Brushes.Black, RectCodice, FMT)
                e.Graphics.DrawString(.Qt, FontBold, Brushes.Black, RectQt, FMT)
                e.Graphics.DrawString(.Ordine, New Font("Calibri", 12, FontStyle.Bold), Brushes.Black, RectOrdine, FMT)

                LOG.Write("Stampata etichetta " & .Imballo & " - " & .Qt)
                BindelloAttuale += 1

                If BindelloAttuale <= BindelliDaStampare Then
                    e.HasMorePages = True
                Else
                    e.HasMorePages = False
                    BindelloAttuale = 0
                End If

            End With


        End Sub

    End Module
End Namespace