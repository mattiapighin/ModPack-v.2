Imports System.Windows.Forms

Public Class Mail_ScegliDestinatari

    Public ListaDestinatari As List(Of DestinatarioMail)

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Mail.ListaDestinatari.Clear()

        For Each row As DataGridViewRow In DgwDestinatari.SelectedRows
            Dim Destinatario As New DestinatarioMail With {.Nome = row.Cells(1).Value, .Email = row.Cells(2).Value}
            Mail.ListaDestinatari.Add(Destinatario)
        Next

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Mail_ScegliDestinatari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'ModPackDBDataSet.DestinatariEmail'. È possibile spostarla o rimuoverla se necessario.
        Me.DestinatariEmailTableAdapter.Fill(Me.ModPackDBDataSet.DestinatariEmail)

    End Sub
End Class

