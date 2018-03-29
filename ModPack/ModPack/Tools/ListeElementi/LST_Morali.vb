Public Class LST_Morali

    Dim DS As New ModPackDBDataSet
    Dim TableOrdini As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
    Dim TableImballi As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
    Dim TableDistinta As New ModPackDBDataSetTableAdapters.DistintaTableAdapter
    Dim TableTipi As New ModPackDBDataSetTableAdapters.TipiTableAdapter

    Dim ListaOrdini As New List(Of String)
    Dim ListaMorali As New List(Of Morali)


    Structure Morali

        Dim Imballo As String
        Dim HT As Boolean
        Dim QT As Integer

        Dim TipoMorale As String
        Dim LunghezzaMorale As Integer
        Dim QTMorali As Integer
        Dim Fresata As Boolean

    End Structure

    Private Sub GetOrdiniAperti()
        'Riempie la CB_OrdiniAperti con i numeri d'ordine che hanno almeno una riga non evasa
        Dim OrdiniAperti As New List(Of String)
        OrdiniAperti = DS.Ordini.Where(Function(X) X.Evaso = False).Select(Function(y) y.Ordine).Distinct.ToList
        CB_OrdiniAperti.DataSource = OrdiniAperti

    End Sub
    Private Sub FillDGW(ORDINE)

        ListaOrdini.Add(ORDINE)

        For Each ROW As ModPackDBDataSet.OrdiniRow In DS.Ordini.Where(Function(X) X.Ordine = ORDINE).ToList

            Dim RigaImballo As ModPackDBDataSet.ImballiRow = DS.Imballi.Where(Function(X) X.Imballo = ROW.Imballo).First
            Dim RigaMorale As ModPackDBDataSet.DistintaRow = DS.Distinta.Where(Function(X) X.Imballo = ROW.Imballo).Where(Function(y) y.Tag = "MOR").FirstOrDefault
            Dim RigaTipo As ModPackDBDataSet.TipiRow = DS.Tipi.Where(Function(X) X.Tipo = RigaImballo.Tipo).First

            If RigaMorale IsNot Nothing Then
                Dim Morale As New Morali With {.Imballo = ROW.Imballo, .Fresata = RigaTipo.FresataMorali, .HT = ROW.HT, .LunghezzaMorale = RigaMorale.Z, .QT = ROW.Qt, .QTMorali = ROW.Qt * RigaMorale.N, .TipoMorale = RigaMorale.X & " x " & RigaMorale.Y}
                ListaMorali.Add(Morale)
                DGW_Morali.Rows.Add({Morale.Imballo, Morale.HT, Morale.QT, Morale.TipoMorale, Morale.LunghezzaMorale, Morale.QTMorali, Morale.Fresata})
            End If

        Next

        For Each Row As DataGridViewRow In DGW_Morali.Rows
            If Row.Cells("HT").Value = True Then Row.DefaultCellStyle.ForeColor = Color.Red
        Next

    End Sub
    Private Sub Pulisci()
        ListaOrdini.Clear()
        DGW_Morali.Rows.Clear()
        LabelOrdini.Text = ""
    End Sub

    Private Sub Lst_Morali_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Riempie Dataset
        TableOrdini.Fill(DS.Ordini)
        TableImballi.Fill(DS.Imballi)
        TableDistinta.Fill(DS.Distinta)
        TableTipi.Fill(DS.Tipi)

        TableImballi.Dispose()
        TableOrdini.Dispose()
        TableDistinta.Dispose()
        TableTipi.Dispose()

        Pulisci()
        GetOrdiniAperti()

    End Sub

    Private Sub BT_Ok_Click(sender As Object, e As EventArgs) Handles Bt_Ok.Click

        If DGW_Morali.Rows.Count = 1 OrElse MsgBox("Aggiungere l'ordine alla lista già creata?", vbYesNo, "Aggiungi") = MsgBoxResult.Yes Then
            FillDGW(CB_OrdiniAperti.Text)
        End If

        LabelOrdini.Text = ""

        For K = 0 To ListaOrdini.Count - 1
            LabelOrdini.Text += ListaOrdini(K)
            If Not K = ListaOrdini.Count - 1 Then LabelOrdini.Text += " - "
        Next

    End Sub

    Private Sub Bt_Stampa_Click(sender As Object, e As EventArgs) Handles Bt_Stampa.Click

        If MsgBox("Ordinare per lunghezza decrescente?", vbYesNo, "Stampa") = MsgBoxResult.Yes Then
            DGW_Morali.Sort(DGW_Morali.Columns(4), System.ComponentModel.ListSortDirection.Descending) ' DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Descending
        End If

        Stampe.Set_Settings(PrintMorali, True)

        Dim PrintPreview As New PrintPreviewDialog With {.Document = PrintMorali}
        PrintPreview.ShowDialog()
    End Sub

    Private Sub PrintMorali_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintMorali.PrintPage

        Dim FMT As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}

        'Squadratura
        e.Graphics.DrawRectangle(New Pen(Color.Black, 3), e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height)

        '######## INTESTAZIONE ############
        Dim IntestazioneALL As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, 60)
        Dim IntestazioneSX As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width / 4, 60)
        Dim IntestazioneCENTRO As New Rectangle(IntestazioneSX.Right, e.MarginBounds.Top, e.MarginBounds.Width / 4 * 2, 60)
        Dim IntestazioneDX As New Rectangle(e.MarginBounds.Right - e.MarginBounds.Width / 4, e.MarginBounds.Top, e.MarginBounds.Width / 4, 60)
        Dim RectOrdini As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Top + 60, e.MarginBounds.Width, 30)

        e.Graphics.DrawRectangles(Pens.Black, {IntestazioneSX, IntestazioneDX, IntestazioneALL})
        Stampe.ImmagineInRettangolo(My.Resources.Logo, IntestazioneSX, e)

        e.Graphics.DrawString("MORALI", New Font("Calibri", 24), Brushes.Black, IntestazioneCENTRO, FMT)
        e.Graphics.DrawString(Date.Today.Date, New Font("Calibri", 18), Brushes.Black, IntestazioneDX, FMT)

        Dim StringaOrdini As String = ""

        For K = 0 To ListaOrdini.Count - 1
            StringaOrdini += ListaOrdini(K)
            If Not K = ListaOrdini.Count - 1 Then StringaOrdini += " - "
        Next

        e.Graphics.DrawString(StringaOrdini, New Font("Calibri", 10), Brushes.Black, RectOrdini, FMT)
        '###################################

        '############### TABELLA ###########
        Dim RectTabella As New Rectangle(e.MarginBounds.Left + 15, e.MarginBounds.Top + 105, e.MarginBounds.Width - 30, e.MarginBounds.Height - 120)
        e.Graphics.DrawRectangle(Pens.Black, RectTabella)

        Dim RigheTotali As Integer = DGW_Morali.Rows.Count
        Dim RighePerPagina As Integer = 25
        Dim TotPagine As Integer = Math.Ceiling(RigheTotali \ RighePerPagina) + 1

        Debug.WriteLine("Righe Totali {0} - Righe per pagina {1} - Totale pagine {2}", RigheTotali, RighePerPagina, TotPagine)

        If RigheTotali Mod RighePerPagina > 0 Then
            TotPagine = (RigheTotali \ RighePerPagina) + 1
        Else
            TotPagine = (RigheTotali \ RighePerPagina)
        End If

        Static PagineStampate As Integer = 0
        Static RigheStampate As Integer = 1 '0
        Dim Punto As New Point(RectTabella.X, RectTabella.Y)
        Dim Hriga As Single = RectTabella.Height / RighePerPagina

        PagineStampate += 1

        For K As Integer = RigheStampate To RigheStampate + RighePerPagina - 1

            'Se l'imballo è HT stampa la linea in rosso
            Dim ColoreFont As Brush = Brushes.Black

            'Riga da stampare che comprende fiancate e teste
            Dim Riga As New Rectangle(Punto.X, Punto.Y, RectTabella.Width, Hriga)

            Dim FontImballo As New Font("Calibri", 18, FontStyle.Bold)
            Dim FontPZ As New Font("Calibri", 15, FontStyle.Bold)
            Dim Font As New Font("Calibri", 15)

            With DGW_Morali.Rows(K - 1)

                If .Cells(1).Value = True Then ColoreFont = Brushes.Red                                             'Se la riga è HT il font diventa rosso

                If K Mod 2 = 0 Then
                    e.Graphics.FillRectangle(Brushes.LightCyan, Riga)                                               'Sfondo azzurro alternato
                End If

                Dim RectImballo As New Rectangle(Punto.X, Punto.Y, RectTabella.Width / 11 * 2, Hriga)
                Dim RectPZ As New Rectangle(RectImballo.Right, Punto.Y, RectTabella.Width / 11, Hriga)
                Dim RectMorali As New Rectangle(RectPZ.Right, Punto.Y, RectTabella.Width / 11 * 7, Hriga)               '
                Dim RectFresata As New Rectangle(RectMorali.Right, Punto.Y, RectTabella.Width / 11, Hriga)

                e.Graphics.DrawString(.Cells(0).Value, FontImballo, Brushes.Black, RectImballo, FMT)                'Imballo
                e.Graphics.DrawString("PZ. " & .Cells(2).Value, FontPZ, Brushes.Black, RectPZ, FMT)                 'Pezzi
                e.Graphics.DrawString(.Cells(3).Value & " x " & .Cells(4).Value & " = " & .Cells(5).Value, Font, Brushes.Black, RectMorali, FMT) 'Misure
                If .Cells(6).Value = True Then e.Graphics.DrawString("X", FontImballo, Brushes.Black, RectFresata, FMT) 'Fresata

                e.Graphics.DrawRectangle(New Pen(Color.Black, 3), Riga)                                             'Rettangolo riga in nero grosso

            End With


            If K = RigheTotali - 1 Then
                'Quando si arriva al numero totale di righe da stampare esce dal ciclo
                e.HasMorePages = False
                RigheStampate = 1
                Exit For
            End If

            Punto.Y += Hriga
            RigheStampate += 1

        Next

        If PagineStampate < TotPagine Then
            e.HasMorePages = True
            Punto.Y = RectTabella.Y
        Else
            e.HasMorePages = False
            RigheStampate = 1
        End If


    End Sub

End Class