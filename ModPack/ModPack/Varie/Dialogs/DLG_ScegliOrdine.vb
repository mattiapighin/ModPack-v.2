Imports System.Windows.Forms

Public Class DLG_ScegliOrdine

    Dim DS As New ModPackDBDataSet
    Dim TableOrdini As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
    Dim TableImballi As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
    Public OrdineScelto As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        OrdineScelto = LST_Ordini.SelectedItem
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DLG_ScegliOrdine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TableOrdini.Fill(DS.Ordini)
        TableImballi.Fill(DS.Imballi)
        LST_Ordini.DataSource = DS.Ordini.Select(Function(X) X.Ordine).Distinct.ToList
    End Sub

    Private Sub Tx_Search_TextChanged(sender As Object, e As EventArgs) Handles Tx_Search.TextChanged
        LST_Ordini.DataSource = DS.Ordini.Where(Function(X) X.Ordine.Contains(Tx_Search.Text)).Select(Function(y) y.Ordine).Distinct.ToList
    End Sub

    Private Sub LST_Ordini_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LST_Ordini.SelectedIndexChanged

        DGWAnteprima.Rows.Clear()

        For Each Riga As ModPackDBDataSet.OrdiniRow In DS.Ordini.Where(Function(X) X.Ordine = LST_Ordini.SelectedItem).ToList

            Dim Prezzo As String = DS.Imballi.Where(Function(X) X.Imballo = Riga.Imballo).Select(Function(Y) Y.Prezzo).First
            DGWAnteprima.Rows.Add({Riga.Id, Riga.Imballo, Riga.Qt, Riga.Tipo, Riga.Codice, Riga.Commessa, "€ " & Prezzo, Riga.Data_Consegna.ToShortDateString})


        Next
    End Sub
End Class
