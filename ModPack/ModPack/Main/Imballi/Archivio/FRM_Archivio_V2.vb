
Public Class FRM_Archivio_V2

    Dim DS As New ModPackDBDataSet
    Dim ImballiTable As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
    Dim OrdiniTable As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
    Dim RivestimentiTable As New ModPackDBDataSetTableAdapters.RivestimentiTableAdapter
    Dim NoteTable As New ModPackDBDataSetTableAdapters.NoteImballiTableAdapter

    Dim Lista As New List(Of String())

    Private Sub FillDS()
        ImballiTable.Fill(DS.Imballi)
        OrdiniTable.Fill(DS.Ordini)
        RivestimentiTable.Fill(DS.Rivestimenti)
        NoteTable.Fill(DS.NoteImballi)

        ImballiTable.Dispose()
        OrdiniTable.Dispose()
        RivestimentiTable.Dispose()
        NoteTable.Dispose()
    End Sub
    Private Sub Get_Info(ByVal ID As Integer)

        LB_Tipo.Text = ""
        LB_Zoccoli.Text = ""
        LB_Rivestimento.Text = ""
        LB_M2.Text = ""
        LB_M3.Text = ""
        LB_Prezzo.Text = ""
        PB_Img.BackgroundImage = Nothing

        CK_BM.Checked = False
        CK_Diagonali.Checked = False
        CK_DT.Checked = False
        CK_HT.Checked = False

        Dim RigaINFO As ModPackDBDataSet.ImballiRow = DS.Imballi.Where(Function(X) X.Id = ID).First

        With RigaINFO

            LB_Tipo.Text = .Tipo
            LB_Zoccoli.Text = .Zoccoli
            LB_Rivestimento.Text = DS.Rivestimenti.Where(Function(X) X.Tipo_Rivestimento = .Tipo_Rivestimento).Select(Function(y) y.Descrizione).FirstOrDefault
            LB_M2.Text = .M2
            LB_M3.Text = .M3
            LB_Prezzo.Text = "€ " & .Prezzo

            CK_BM.Checked = .BM
            CK_Diagonali.Checked = .Diagonali
            CK_DT.Checked = .DT
            CK_HT.Checked = .HT

            If Not .IsImgNull Then PB_Img.BackgroundImage = Immagine.ConvertFromBytes(.Img)
            TX_Note.Text = DS.NoteImballi.Where(Function(X) X.Imballo = .Imballo).Select(Function(y) y.Nota).FirstOrDefault

        End With

        Dim ListaRigheOrdine As List(Of ModPackDBDataSet.OrdiniRow)
        ListaRigheOrdine = DS.Ordini.Where(Function(X) X.Imballo = RigaINFO.Imballo).ToList

        DG_InfoOrdini.Rows.Clear()

        For Each Row As ModPackDBDataSet.OrdiniRow In ListaRigheOrdine
            DG_InfoOrdini.Rows.Add({Row.Id, Row.Codice, Row.Commessa, Row.Qt, Row.Evaso, Row.Data_Consegna.ToShortDateString})
        Next

        LST_Codici.DataSource = DS.Ordini.Where(Function(X) X.Imballo = RigaINFO.Imballo).Select(Function(y) y.Codice).Distinct.ToList

    End Sub
    Public Sub FillArchivio(ByVal Lista As List(Of ModPackDBDataSet.ImballiRow))
        DG_Archivio.Rows.Clear()

        Lista.Reverse()

        For Each Row As ModPackDBDataSet.ImballiRow In Lista.Take(My.Settings.Archivio_V2_NRecord)
            With Row

                DG_Archivio.Rows.Add({ .Id, .Imballo, .Tipo, .L, .P, .H, .Rivestimento, .Data_Creazione.ToShortDateString})

            End With
        Next

    End Sub

    Private Sub FRM_Archivio_V2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDS()
        FillArchivio(DS.Imballi.ToList)
        CB_NElementi.Text = My.Settings.Archivio_V2_NRecord
    End Sub

    Private Sub BT_SearchCode_Click(sender As Object, e As EventArgs) Handles BT_SearchCode.Click
        FillArchivio(DS.Imballi.Where(Function(X) X.Imballo.Contains(Txt_Code.Text.ToUpper)).ToList)
    End Sub

    'INFO IMBALLO
    Private Sub DG_Archivio_SelectionChanged(sender As Object, e As EventArgs) Handles DG_Archivio.SelectionChanged
        If Not DG_Archivio.CurrentRow Is Nothing Then
            Get_Info(DG_Archivio.Rows(DG_Archivio.CurrentRow.Index).Cells(0).Value)
        End If
    End Sub
    Private Sub DG_InfoOrdini_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_InfoOrdini.CellDoubleClick
        Dim Lista As New List(Of ModPackDBDataSet.OrdiniRow)
        Lista.Add(DS.Ordini.Where(Function(X) X.Id = DG_InfoOrdini.Rows(e.RowIndex).Cells(0).Value).First)
        Distinta.Stampa(Lista, True)
    End Sub

    Private Sub BT_Filtro_Click(sender As Object, e As EventArgs) Handles BT_Filtro.Click
        Archivio_Filtro.Show()
    End Sub

    Private Sub CB_NElementi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_NElementi.SelectedIndexChanged
        My.Settings.Archivio_V2_NRecord = CB_NElementi.SelectedItem
        My.Settings.Save()
    End Sub

    Private Sub BT_ModificaImballo_Click(sender As Object, e As EventArgs) Handles BT_ModificaImballo.Click
        If Not DG_Archivio.CurrentRow Is Nothing Then
            Form_ModificaImballo.Show()
            Form_ModificaImballo.CbImballo.Text = DG_Archivio.CurrentRow.Cells(1).Value
            Form_ModificaImballo.CaricaCodiceNoEdit()
        End If

    End Sub

    Private Sub DG_Archivio_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Archivio.CellDoubleClick

        Dim Imballo As ModPackDBDataSet.ImballiRow = DS.Imballi.Where(Function(X) X.Id = DG_Archivio.Rows(e.RowIndex).Cells(0).Value).First

        Dim Riga As ModPackDBDataSet.OrdiniRow = DS.Ordini.NewOrdiniRow

            With Riga
            'Crea riga d'ordine fittizia

            .Id = 0
            .Ordine = ""
                .Riga = 1
                .Imballo = Imballo.Imballo
                .Indice = 0
                .Qt = 1
                .Cliente = ""
                .Codice = ""
                .Commessa = ""
                .L = Imballo.L
                .P = Imballo.P
                .H = Imballo.H
                .Tipo = Imballo.Tipo
                .Zoccoli = Imballo.Zoccoli
                .Rivestimento = Imballo.Rivestimento
                .Tipo_Rivestimento = Imballo.Tipo_Rivestimento
            .Note = ""
            .Data_Consegna = Date.Today.Date
                .HT = Imballo.HT
                .BM = Imballo.BM
                .DT = Imballo.DT
            .Rivest_Tot = ""
            .Magazzino = ""
                .Diagonali = Imballo.Diagonali
                .Stampato = False
                .Evaso = False
                .Produzione = False
                .Data_Ordine = Date.Today.Date

            End With

            Dim Lista As New List(Of ModPackDBDataSet.OrdiniRow)
            Lista.Add(Riga)

            Distinta.Stampa(Lista, True)

    End Sub

    Private Sub Bt_SalvaNote_Click(sender As Object, e As EventArgs) Handles Bt_SalvaNote.Click

        Dim RigaNote As ModPackDBDataSet.NoteImballiRow = DS.NoteImballi.Where(Function(X) X.Imballo = DG_Archivio.CurrentRow.Cells(1).Value).FirstOrDefault

        If Not RigaNote Is Nothing Then
            RigaNote.Nota = TX_Note.Text
            NoteTable.Update(RigaNote)
            NoteTable.Update(DS.NoteImballi)
        Else
            NoteTable.Insert(DG_Archivio.CurrentRow.Cells(1).Value, TX_Note.Text)
            NoteTable.Update(DS.NoteImballi)
        End If

        NoteTable.Fill(DS.NoteImballi)

        MsgBox("Note", vbOKOnly, "Nota salvata!")

    End Sub
End Class