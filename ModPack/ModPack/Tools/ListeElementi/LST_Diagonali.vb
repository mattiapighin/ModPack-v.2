Public Class LST_Diagonali

    Dim DS As New ModPackDBDataSet
    Dim TableOrdini As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
    Dim TableImballi As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
    Dim TableDistinta As New ModPackDBDataSetTableAdapters.DistintaTableAdapter

    Dim ListaOrdini As New List(Of String)

    Structure Diagonale

        Dim Imballo As String
        Dim QT As Integer

        Dim TavFianco As String
        Dim DiagFianco As Integer
        Dim DiagFiancoQT As Integer
        Dim GradiFianco As String

        Dim TavTesta As String
        Dim DiagTesta As Integer
        Dim DiagTestaQT As Integer
        Dim GradiTesta As String

        Dim HT As Boolean

    End Structure

    Private Sub FRM_ListaDiagonali_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Riempie Dataset
        TableOrdini.Fill(DS.Ordini)
        TableImballi.Fill(DS.Imballi)
        TableDistinta.Fill(DS.Distinta)

        TableImballi.Dispose()
        TableOrdini.Dispose()
        TableDistinta.Dispose()

        Pulisci()
        GetOrdiniAperti()
        GetSettimane()

    End Sub


    Private Sub GetOrdiniAperti()
        'Riempie la CB_OrdiniAperti con i numeri d'ordine che hanno almeno una riga non evasa
        'Dim OrdiniAperti As New List(Of String)
        'OrdiniAperti = DS.Ordini.Where(Function(X) X.Evaso = False).Select(Function(y) y.Ordine).Distinct.ToList
        'CB_OrdiniAperti.DataSource = OrdiniAperti

        CB_OrdiniAperti.DataSource = DS.Ordini.Where(Function(X) X.Evaso = False).Select(Function(y) y.Ordine).Distinct.ToList
    End Sub
    Private Sub FillDGW_ORDINE(ORDINE)

        ListaOrdini.Add(ORDINE)

        For Each ROW As ModPackDBDataSet.OrdiniRow In DS.Ordini.Where(Function(X) X.Ordine = ORDINE).Where(Function(Y) Y.Evaso = False).ToList

            Dim RigaImballo As ModPackDBDataSet.ImballiRow = DS.Imballi.Where(Function(X) X.Imballo = ROW.Imballo).First
            Dim RigaDiagFiancate As ModPackDBDataSet.DistintaRow = DS.Distinta.Where(Function(X) X.Imballo = ROW.Imballo).Where(Function(y) y.Tag = "FD").FirstOrDefault
            Dim RigaDiagTeste As ModPackDBDataSet.DistintaRow = DS.Distinta.Where(Function(X) X.Imballo = ROW.Imballo).Where(Function(y) y.Tag = "TD").FirstOrDefault

            Dim IMBA As New Diagonale With {
                .Imballo = ROW.Imballo,
                .QT = ROW.Qt,
                .DiagFianco = 0, .DiagFiancoQT = 0, .GradiFianco = 0,
                .DiagTesta = 0, .DiagTestaQT = 0, .GradiTesta = 0,
                .HT = ROW.HT}

            If RigaDiagFiancate IsNot Nothing Or RigaDiagTeste IsNot Nothing Then
                'Se esiste almeno una diagonale tra fiancate e teste inserisce riga

                If Not RigaDiagFiancate Is Nothing Then
                    'Carica dati diagonale fiancata
                    IMBA.TavFianco = Int(RigaDiagFiancate.X) & " x " & RigaDiagFiancate.Y
                    IMBA.DiagFianco = RigaDiagFiancate.Z
                    IMBA.DiagFiancoQT = RigaDiagFiancate.N
                    IMBA.GradiFianco = RigaImballo.Gradi_F & "°"
                End If

                If Not RigaDiagTeste Is Nothing Then
                    'Carica dati diagonale testa
                    IMBA.TavTesta = Int(RigaDiagTeste.X) & " x " & RigaDiagTeste.Y
                    IMBA.DiagTesta = RigaDiagTeste.Z
                    IMBA.DiagTestaQT = RigaDiagTeste.N
                    IMBA.GradiTesta = RigaImballo.Gradi_T & "°"
                End If

                'Crea riga su datagrid
                DGW_Diagonali.Rows.Add({IMBA.Imballo, IMBA.HT, IMBA.QT, IMBA.TavFianco, IMBA.DiagFianco, IMBA.GradiFianco, IMBA.DiagFiancoQT * IMBA.QT, IMBA.TavTesta, IMBA.DiagTesta, IMBA.GradiTesta, IMBA.DiagTestaQT * IMBA.QT})
            End If
        Next

        For Each Row As DataGridViewRow In DGW_Diagonali.Rows
            If Row.Cells("HT").Value = True Then Row.DefaultCellStyle.ForeColor = Color.Red
        Next

        DGW_Diagonali.Sort(DGW_Diagonali.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Private Sub GetSettimane()
        CB_Settimane.DataSource = DS.Ordini.Where(Function(X) X.Evaso = False).Select(Function(y) FunzioniVarie.Get_WK(y.Data_Consegna)).Distinct.ToList
    End Sub
    Private Sub FillDGW_WK(WK)

        ListaOrdini.Add("SETT. " & WK)

        For Each ROW As ModPackDBDataSet.OrdiniRow In DS.Ordini.Where(Function(X) FunzioniVarie.Get_WK(X.Data_Consegna) = WK).Where(Function(Y) Y.Evaso = False).ToList

            Dim RigaImballo As ModPackDBDataSet.ImballiRow = DS.Imballi.Where(Function(X) X.Imballo = ROW.Imballo).First
            Dim RigaDiagFiancate As ModPackDBDataSet.DistintaRow = DS.Distinta.Where(Function(X) X.Imballo = ROW.Imballo).Where(Function(y) y.Tag = "FD").FirstOrDefault
            Dim RigaDiagTeste As ModPackDBDataSet.DistintaRow = DS.Distinta.Where(Function(X) X.Imballo = ROW.Imballo).Where(Function(y) y.Tag = "TD").FirstOrDefault

            Dim IMBA As New Diagonale With {
                .Imballo = ROW.Imballo,
                .QT = ROW.Qt,
                .DiagFianco = 0, .DiagFiancoQT = 0, .GradiFianco = 0,
                .DiagTesta = 0, .DiagTestaQT = 0, .GradiTesta = 0,
                .HT = ROW.HT}

            If RigaDiagFiancate IsNot Nothing Or RigaDiagTeste IsNot Nothing Then
                'Se esiste almeno una diagonale tra fiancate e teste inserisce riga

                If Not RigaDiagFiancate Is Nothing Then
                    'Carica dati diagonale fiancata
                    IMBA.TavFianco = Int(RigaDiagFiancate.X) & " x " & RigaDiagFiancate.Y
                    IMBA.DiagFianco = RigaDiagFiancate.Z
                    IMBA.DiagFiancoQT = RigaDiagFiancate.N
                    IMBA.GradiFianco = RigaImballo.Gradi_F & "°"
                End If

                If Not RigaDiagTeste Is Nothing Then
                    'Carica dati diagonale testa
                    IMBA.TavTesta = Int(RigaDiagTeste.X) & " x " & RigaDiagTeste.Y
                    IMBA.DiagTesta = RigaDiagTeste.Z
                    IMBA.DiagTestaQT = RigaDiagTeste.N
                    IMBA.GradiTesta = RigaImballo.Gradi_T & "°"
                End If

                'Crea riga su datagrid
                DGW_Diagonali.Rows.Add({IMBA.Imballo, IMBA.HT, IMBA.QT, IMBA.TavFianco, IMBA.DiagFianco, IMBA.GradiFianco, IMBA.DiagFiancoQT * IMBA.QT, IMBA.TavTesta, IMBA.DiagTesta, IMBA.GradiTesta, IMBA.DiagTestaQT * IMBA.QT})
            End If
        Next

        For Each Row As DataGridViewRow In DGW_Diagonali.Rows
            If Row.Cells("HT").Value = True Then Row.DefaultCellStyle.ForeColor = Color.Red
        Next

        DGW_Diagonali.Sort(DGW_Diagonali.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

    End Sub


    Private Sub Pulisci()
        ListaOrdini.Clear()
        DGW_Diagonali.Rows.Clear()
        LabelOrdini.Text = ""
    End Sub



    Private Sub BT_Ok_Click(sender As Object, e As EventArgs) Handles Bt_Ok_ORDINE.Click

        If DGW_Diagonali.Rows.Count = 1 OrElse MsgBox("Aggiungere l'ordine alla lista già creata?", vbYesNo, "Aggiungi") = MsgBoxResult.Yes Then
            FillDGW_ORDINE(CB_OrdiniAperti.Text)
        End If

        LabelOrdini.Text = ""

        For K = 0 To ListaOrdini.Count - 1
            LabelOrdini.Text += ListaOrdini(K)
            If Not K = ListaOrdini.Count - 1 Then LabelOrdini.Text += " - "
        Next

    End Sub

    Private Sub Bt_Ok_WK_Click(sender As Object, e As EventArgs) Handles Bt_Ok_WK.Click

        Pulisci()

        FillDGW_WK(CB_Settimane.Text)

    End Sub


    Private Sub Bt_Stampa_Click(sender As Object, e As EventArgs) Handles Bt_Stampa.Click


        Stampe.Set_Settings(PrintDiagonali, True)

        Dim PrintPreview As New PrintPreviewDialog With {.Document = PrintDiagonali}
        PrintPreview.ShowDialog()
    End Sub

    Private Sub PrintDiagonali_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDiagonali.PrintPage

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

        e.Graphics.DrawString("DIAGONALI", New Font("Calibri", 24), Brushes.Black, IntestazioneCENTRO, FMT)
        e.Graphics.DrawString(Date.Today.Date, New Font("Calibri", 18), Brushes.Black, IntestazioneDX, FMT)

        Dim StringaOrdini As String = ""

        For K = 0 To ListaOrdini.Count - 1
            StringaOrdini += ListaOrdini(K)
            If Not K = ListaOrdini.Count - 1 Then StringaOrdini += " - "
        Next

        e.Graphics.DrawString(StringaOrdini, New Font("Calibri", 18), Brushes.Black, RectOrdini, FMT)
        '###################################

        '############### TABELLA ###########
        Dim RectTabella As New Rectangle(e.MarginBounds.Left + 15, e.MarginBounds.Top + 105, e.MarginBounds.Width - 30, e.MarginBounds.Height - 120)
        e.Graphics.DrawRectangle(Pens.Black, RectTabella)

        Dim RigheTotali As Integer = DGW_Diagonali.Rows.Count
        Dim RighePerPagina As Integer = 16
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
            Dim Font As New Font("Calibri", 12)

            With DGW_Diagonali.Rows(K - 1)

                If .Cells(1).Value = True Then ColoreFont = Brushes.Red                                             'Se la riga è HT il font diventa rosso

                If K Mod 2 = 0 Then
                    e.Graphics.FillRectangle(Brushes.LightCyan, Riga)                                               'Sfondo azzurro alternato
                End If

                Dim RectImballo As New Rectangle(Punto.X, Punto.Y, RectTabella.Width / 11 * 2, Hriga)               'Rettangolo con nome imballo
                Dim RectPZ As New Rectangle(RectImballo.Right, Punto.Y, RectTabella.Width / 11, Hriga)              'Rettangolo con pezzi imballo

                Dim RectDF As New Rectangle(RectPZ.Right, Punto.Y, RectTabella.Width / 11, Hriga / 2)               'Rettangolo descrizione "diagonali fiancate"
                Dim RectDT As New Rectangle(RectPZ.Right, RectDF.Bottom, RectTabella.Width / 11, Hriga / 2)         'Rettangolo descrizione "diagonali teste"

                Dim DiagF As New Rectangle(RectDF.Right, Punto.Y, RectTabella.Width / 11 * 7, Hriga / 2)            'Rettangolo diagonali F
                Dim DiagT As New Rectangle(RectDT.Right, RectDF.Bottom, RectTabella.Width / 11 * 7, Hriga / 2)      'Rettangolo diagonali T

                e.Graphics.DrawRectangles(Pens.Gray, {RectImballo, RectDF, RectDT, DiagF, DiagT})                   'Disegna rettangolo in grigio chiaro

                e.Graphics.DrawString(.Cells(0).Value, FontImballo, Brushes.Black, RectImballo, FMT)                'Imballo
                e.Graphics.DrawString("PZ. " & .Cells(2).Value, FontPZ, Brushes.Black, RectPZ, FMT)                 'Pezzi

                e.Graphics.DrawString("Fiancate", Font, ColoreFont, RectDF, FMT)                                    'Fiancate (se ci sono tavole da tagliare)
                If Not .Cells(6).Value = 0 Then e.Graphics.DrawString(.Cells(3).Value & " x " & .Cells(4).Value & " = " & .Cells(6).Value & " (" & .Cells(5).Value & ")", Font, ColoreFont, DiagF, FMT)

                e.Graphics.DrawString("Teste", Font, ColoreFont, RectDT, FMT)                                       'Teste (se ci sono tavole da tagliare)
                If Not .Cells(10).Value = 0 Then e.Graphics.DrawString(.Cells(7).Value & " x " & .Cells(8).Value & " = " & .Cells(10).Value & " (" & .Cells(9).Value & ")", Font, ColoreFont, DiagT, FMT)

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
            PagineStampate = 0
            RigheStampate = 1
        End If


    End Sub

    Private Sub Bt_Pulisci_Click(sender As Object, e As EventArgs) Handles Bt_Pulisci.Click
        DGW_Diagonali.Rows.Clear()
    End Sub


End Class