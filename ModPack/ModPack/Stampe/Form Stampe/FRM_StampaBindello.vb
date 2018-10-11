Public Class FRM_StampaBindello

    Dim DS As New ModPackDBDataSet
    Dim TableMagazzini As New ModPackDBDataSetTableAdapters.MagazziniTableAdapter

    Private Sub Clear()

        TableMagazzini.Fill(DS.Magazzini)

        DatePicker.Value = Date.Today
        Tx_Cliente.Text = ""
        Tx_Disegno.Text = ""
        Tx_Commessa.Text = ""
        Tx_Imballo.Text = ""
        Tx_Ordine.Text = ""

        NU_Qt.Value = 1
        CB_Magazzini.DataSource = DS.Magazzini.Select(Function(X) X.Descrizione).Distinct.ToList


    End Sub
    Private Sub Bt_Stampa_Click(sender As Object, e As EventArgs) Handles Bt_Stampa.Click

        Dim Riga As ModPackDBDataSet.OrdiniRow = DS.Ordini.NewOrdiniRow

        With Riga
            .Data_Consegna = DatePicker.Value
            .Magazzino = DS.Magazzini.Where(Function(X) X.Descrizione = CB_Magazzini.Text).Select(Function(Y) Y.Codice).FirstOrDefault
            .Cliente = Tx_Cliente.Text
            .Codice = Tx_Disegno.Text
            .Commessa = Tx_Commessa.Text
            .Imballo = Tx_Imballo.Text
            .Qt = NU_Qt.Value
            .Ordine = Tx_Ordine.Text
        End With

        Bindelli.Stampa({Riga}.ToList, True)

    End Sub
    Private Sub FRM_StampaBindello_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
    End Sub
End Class