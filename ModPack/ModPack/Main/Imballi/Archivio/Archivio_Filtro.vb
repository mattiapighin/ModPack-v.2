Public Class Archivio_Filtro

    Dim DS As New ModPackDBDataSet
    Dim TableImballi As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
    Dim TableOrdini As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter

    Private Sub Archivio_Filtro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TableImballi.Fill(DS.Imballi)
        TableOrdini.Fill(DS.Ordini)
        TableImballi.Dispose()
        TableOrdini.Dispose()

        NU_L_DA.Value = DS.Imballi.Select(Function(X) X.L).Min
        NU_P_DA.Value = DS.Imballi.Select(Function(X) X.P).Min
        NU_H_DA.Value = DS.Imballi.Select(Function(X) X.H).Min

        NU_L_A.Value = DS.Imballi.Select(Function(X) X.L).Max
        NU_P_A.Value = DS.Imballi.Select(Function(X) X.P).Max
        NU_H_A.Value = DS.Imballi.Select(Function(X) X.H).Max

        CKL_Tipi.DataSource = DS.Imballi.Select(Function(X) X.Tipo).Distinct.ToList

        For i As Integer = 0 To CKL_Tipi.Items.Count - 1
            CKL_Tipi.SetItemChecked(i, True)
        Next i

        Data_Ordine_Da.Value = DS.Ordini.Select(Function(X) X.Data_Ordine).Min
        Data_Ordine_A.Value = DS.Ordini.Select(Function(X) X.Data_Ordine).Max


    End Sub

    Dim LST As New List(Of ModPackDBDataSet.ImballiRow)

    Private Sub BT_Filtra_Click(sender As Object, e As EventArgs) Handles BT_Filtra.Click

        Dim TipiSelezionati() As String = CKL_Tipi.CheckedItems.OfType(Of String).ToArray


        Dim GetImballi As New List(Of String)

        GetImballi = DS.Ordini _
            .Where(Function(X) X.Codice.Contains(Tx_Codice.Text.ToUpper)) _
            .Where(Function(y) y.Commessa.Contains(Tx_Commessa.Text.ToUpper)) _
            .Where(Function(z) z.Data_Ordine <= Data_Ordine_A.Value.Date) _
            .Where(Function(q) q.Data_Ordine >= Data_Ordine_Da.Value.Date) _
            .Where(Function(w) w.L >= NU_L_DA.Value And w.L <= NU_L_A.Value) _
            .Where(Function(t) t.P >= NU_P_DA.Value And t.P <= NU_P_A.Value) _
            .Where(Function(r) r.H >= NU_H_DA.Value And r.H <= NU_H_A.Value) _
            .Where(Function(a) TipiSelezionati.Contains(a.Tipo)) _
        .Select(Function(X) X.Imballo).ToList

        FRM_Archivio_V2.FillArchivio(DS.Imballi.Where(Function(X) GetImballi.Contains(X.Imballo)).ToList)

    End Sub


End Class