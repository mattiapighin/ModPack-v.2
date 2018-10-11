Public Class FRM_Associa

    Dim DS As New ModPackDBDataSet
    Dim OrdiniTable As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
    Dim AssocTable As New ModPackDBDataSetTableAdapters.RiferOrdiniTableAdapter

    Private Sub FillAll()
        OrdiniTable.Fill(DS.Ordini)
        AssocTable.Fill(DS.RiferOrdini)
    End Sub

    Private Sub FRM_Associa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Rinfresca()
    End Sub

    Private Sub Rinfresca()
        FillAll()
        CB_Ordini.DataSource = DS.Ordini.Where(Function(X) X.Evaso = False).Select(Function(y) y.Ordine).Distinct.ToList
        Tx_Ordine.Text = ""
        Date_Ordine.Value = Date.Today
        CB_Ordini.Text = ""
    End Sub

    Private Sub Bt_Ok_Click(sender As Object, e As EventArgs) Handles Bt_Ok.Click

        If DS.RiferOrdini.Where(Function(X) X.NumeroCO = CB_Ordini.Text).Any Then

            Dim RigaDaMod As ModPackDBDataSet.RiferOrdiniRow = DS.RiferOrdini.Where(Function(X) X.NumeroCO = CB_Ordini.Text).First

            RigaDaMod.Ordine = Tx_Ordine.Text
            RigaDaMod.DataOrdine = Date_Ordine.Value

            AssocTable.Update(DS.RiferOrdini)

            MsgBox("Associazione completata!", vbOKOnly, "Associa")
            Rinfresca()
        Else

            AssocTable.Insert(CB_Ordini.Text, Tx_Ordine.Text, Date_Ordine.Value.ToShortDateString)
            AssocTable.Update(DS.RiferOrdini)

            MsgBox("Associazione completata!", vbOKOnly, "Associa")
            Rinfresca()

        End If
    End Sub

    Private Sub CB_Ordini_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Ordini.SelectedIndexChanged

        If DS.RiferOrdini.Where(Function(X) X.NumeroCO = CB_Ordini.Text).Any Then
            Dim RigaDaMod As ModPackDBDataSet.RiferOrdiniRow = DS.RiferOrdini.Where(Function(X) X.NumeroCO = CB_Ordini.Text).First

            Tx_Ordine.Text = RigaDaMod.Ordine
            If Not RigaDaMod.IsDataOrdineNull Then Date_Ordine.Value = RigaDaMod.DataOrdine

        Else

            Tx_Ordine.Text = ""
            Date_Ordine.Value = Date.Today

        End If

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class