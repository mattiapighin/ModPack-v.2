Public Class Form_ListaElementi

    Private Sub CaricaElementi()

    End Sub

    Private Sub Form_ListaElementi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQL.FillDGW_SQL("SELECT DISTINCT Ordine FROM Ordini WHERE Evaso = 'False'", DGW_Ordini)
    End Sub

    Private Sub Bt_ListaMorali_Click(sender As Object, e As EventArgs) Handles Bt_ListaMorali.Click
        Dim Lista As New List(Of String)
        Dim StringaOrdini As String = "Ordini: "


        For Each row As DataGridViewCell In DGW_Ordini.SelectedCells
            Lista.Add(row.Value)
            StringaOrdini += row.Value & " "
        Next

        SQL.ListaMorali(Lista, DGW_Result)
        LOG.Write("Stampa lista Morali " & StringaOrdini)
    End Sub

    Private Sub Bt_DiagonaliF_Click(sender As Object, e As EventArgs) Handles Bt_DiagonaliF.Click
        Dim Lista As New List(Of String)
        Dim StringaOrdini As String = "Ordini: "

        For Each row As DataGridViewCell In DGW_Ordini.SelectedCells
            Lista.Add(row.Value)
            StringaOrdini += row.Value & " "
        Next

        SQL.ListaDiagonaliF(Lista, DGW_Result)
        LOG.Write("Stampa lista diagonali fiancate " & StringaOrdini)
    End Sub

    Private Sub Bt_DiagonaliT_Click(sender As Object, e As EventArgs) Handles Bt_DiagonaliT.Click
        Dim Lista As New List(Of String)
        Dim StringaOrdini As String = "Ordini: "

        For Each row As DataGridViewCell In DGW_Ordini.SelectedCells
            Lista.Add(row.Value)
            StringaOrdini += row.Value & " "
        Next

        SQL.ListaDiagonaliT(Lista, DGW_Result)
        LOG.Write("Stampa lista diagonali teste " & StringaOrdini)
    End Sub

    Private Sub Bt_DiagonaliTutte_Click(sender As Object, e As EventArgs) Handles Bt_DiagonaliTutte.Click
        Dim Lista As New List(Of String)
        Dim StringaOrdini As String = "Ordini: "

        For Each row As DataGridViewCell In DGW_Ordini.SelectedCells
            Lista.Add(row.Value)
            StringaOrdini += row.Value & " "
        Next

        SQL.ListaDiagonaliTOT(Lista, DGW_Result)
        LOG.Write("Stampa lista diagonali completa " & StringaOrdini)
    End Sub

    Private Sub Bt_Esporta_Click(sender As Object, e As EventArgs) Handles Bt_Esporta.Click
        If Not DGW_Result.Rows.Count = 0 Then
            Try

                Dim dgv As DataGridView = DGW_Result

                Dim DTB = New DataTable, RWS As Integer, CLS As Integer

                For CLS = 0 To dgv.ColumnCount - 1 ' COLUMNS OF DTB
                    DTB.Columns.Add(dgv.Columns(CLS).Name.ToString)
                Next

                Dim DRW As DataRow

                For RWS = 0 To dgv.Rows.Count - 1 ' FILL DTB WITH DATAGRIDVIEW
                    DRW = DTB.NewRow

                    For CLS = 0 To dgv.ColumnCount - 1
                        Try

                            Dim Valore As String = dgv.Rows(RWS).Cells(CLS).Value.ToString

                            If Valore = "False" Then Valore = ""
                            If Valore = "True" Then Valore = "HT"

                            DRW(DTB.Columns(CLS).ColumnName.ToString) = Valore
                        Catch ex As Exception
                        End Try
                    Next

                    DTB.Rows.Add(DRW)
                Next

                DTB.AcceptChanges()

                Dim DST As New DataSet
                DST.Tables.Add(DTB)
                Dim FLE As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\Output.xml" ' PATH AND FILE NAME WHERE THE XML WIL BE CREATED (EXEMPLE: C:\REPS\XML.xml)
                DTB.WriteXml(FLE)
                Dim EXL As String = My.Settings.ExcelPath ' PATH OF/ EXCEL.EXE IN YOUR MICROSOFT OFFICE
                Shell(Chr(34) & EXL & Chr(34) & " " & Chr(34) & FLE & Chr(34), vbNormalFocus) ' OPEN XML WITH EXCEL

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub



    Private Sub PrintTabella_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintTabella.PrintPage

        Dim FMT As New StringFormat With {.Trimming = StringTrimming.None, .LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center}
        Dim Intestazione As String = ""

        Dim RectIntestazione As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, 40)
        Dim RectTitoli As New Rectangle(e.MarginBounds.Left, RectIntestazione.Bottom + 5, e.MarginBounds.Width, 20)
        Dim RectTabella As New Rectangle(e.MarginBounds.Left, RectTitoli.Bottom + 5, e.MarginBounds.Width, e.MarginBounds.Height - RectIntestazione.Height - RectTitoli.Height - 10)

        For Each Cell As DataGridViewCell In DGW_Ordini.SelectedCells
            Intestazione += Cell.Value & " "
        Next


        e.Graphics.DrawString(Intestazione, New Font("Calibri", 16), Brushes.Black, RectIntestazione, FMT)

        Dim TotaleRighe As Integer = DGW_Result.Rows.Count
        Static RigheStampate As Integer = 0
        Static PagineStampate As Integer = 0

        Dim PosX = RectTabella.Left
        Dim PosY = RectTabella.Top
        Dim Hriga = 30

        Dim Lcell As Single = RectTabella.Width \ DGW_Result.ColumnCount

        'Scrive i titoli delle colonne
        For K As Integer = 0 To DGW_Result.ColumnCount - 1
            Dim R As New Rectangle(PosX, RectTitoli.Top, Lcell, Hriga)
            e.Graphics.DrawString(DGW_Result.Columns(K).Name, New Font("Calibri", 10, FontStyle.Bold), Brushes.Black, R, FMT)
            PosX += Lcell
        Next
        PosX = RectTabella.Left

        Dim righePerPagina As Integer = Math.Ceiling(RectTabella.Height / Hriga) 'Altezza righe
        Dim nPagine As Integer

        If TotaleRighe Mod righePerPagina > 0 Then
            nPagine = (TotaleRighe \ righePerPagina) + 1
        Else
            nPagine = (TotaleRighe \ righePerPagina)
        End If

        PagineStampate += 1

        For i As Integer = RigheStampate To RigheStampate + righePerPagina - 2

            If RigheStampate Mod 2 <> 0 Then e.Graphics.FillRectangle(Brushes.LightGray, PosX, PosY, e.MarginBounds.Width, Hriga)

            For K As Integer = 0 To DGW_Result.ColumnCount - 1
                Dim R As New Rectangle(PosX, PosY, Lcell, Hriga)
                'rimpicciolisce il font se non sta nella cella
                Dim FontHeight As Integer = 12
                Dim L As New SizeF With {.Width = e.Graphics.MeasureString(DGW_Result.Rows(RigheStampate).Cells(K).Value, New Font("Calibri", FontHeight)).Width, .Height = e.Graphics.MeasureString(DGW_Result.Rows(RigheStampate).Cells(K).Value, New Font("Calibri", FontHeight)).Height}

                Do Until L.Width < R.Width
                    FontHeight -= 1
                    L.Width = e.Graphics.MeasureString(DGW_Result.Rows(RigheStampate).Cells(K).Value, New Font("Calibri", FontHeight)).Width
                Loop
                '
                Dim Font As New Font("Calibri", FontHeight)
                e.Graphics.DrawString(DGW_Result.Rows(RigheStampate).Cells(K).Value, Font, Brushes.Black, R, FMT)
                PosX += Lcell
            Next
            PosX = RectTabella.Left

            If i = TotaleRighe - 1 Then
                e.HasMorePages = False
                Exit For
            End If

            RigheStampate += 1
            PosY += Hriga
            e.Graphics.DrawRectangles(Pens.Black, {RectIntestazione, RectTabella})

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

    Private Sub Bt_Stampa_Click(sender As Object, e As EventArgs) Handles Bt_Stampa.Click
        PrintTabella.DefaultPageSettings = My.Settings.FormatoStampa
        Dim G As New PrintPreviewDialog With {.Document = PrintTabella}
        G.ShowDialog()
    End Sub
End Class