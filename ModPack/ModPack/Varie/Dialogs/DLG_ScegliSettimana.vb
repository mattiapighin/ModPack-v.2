Imports System.Windows.Forms

Public Class DLG_ScegliSettimana

    Public SettimanaScelta As Integer

    Dim DS As New ModPackDBDataSet
    Dim Table As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        SettimanaScelta = LST_Settimane.SelectedItem
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DLG_ScegliSettimana_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Table.Fill(DS.Ordini)
        LST_Settimane.DataSource = DS.Ordini.Where(Function(X) X.Evaso = False).Select(Function(y) FunzioniVarie.Get_WK(y.Data_Consegna)).Distinct.ToList

    End Sub
End Class
