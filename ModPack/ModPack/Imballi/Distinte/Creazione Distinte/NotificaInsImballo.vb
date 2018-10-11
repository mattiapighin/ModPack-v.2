Imports System.Windows.Forms


Public Class NotificaInsImballo

    Private Sub Pulisci()
        Lb_Codice.Text = ""
        Lb_L.Text = ""
        Lb_P.Text = ""
        Lb_H.Text = ""
        Lb_Tipo.Text = ""
        Lb_Zoccoli.Text = ""
        Ck_Rivest.Checked = False
        Lb_Rivest.Text = ""
        Ck_HT.Checked = False
        Ck_DT.Checked = False
        Ck_Bm.Checked = False
        Lb_M3.Text = False
        Lb_M2.Text = False
        Lb_Prezzo.Text = False
    End Sub
    Public Sub MostraDialog(ByVal Imballo As RigaImballi)

        Pulisci()

        With Imballo
            Lb_Codice.Text = .Nome
            Lb_L.Text = .L
            Lb_P.Text = .P
            Lb_H.Text = .H
            Lb_Tipo.Text = .TIpo
            Lb_Zoccoli.Text = .Zoccoli
            Ck_Rivest.Checked = .Rivestimento
            Lb_Rivest.Text = .TipoRivestimento
            Ck_HT.Checked = .HT
            Ck_DT.Checked = .DT
            Ck_Bm.Checked = .BM
            Lb_M3.Text = .M3
            Lb_M2.Text = .M2
            Lb_Prezzo.Text = "€" & Math.Round(.Prezzo, 2)
        End With

        Me.ShowDialog()

    End Sub

    Private Sub Bt_Avanti_Click(sender As Object, e As EventArgs) Handles Bt_Avanti.Click
        Me.Close()
    End Sub

    Private Sub Bt_Evita_Click(sender As Object, e As EventArgs) Handles Bt_Evita.Click
        My.Settings.CheckInserimentoImballo = False
        My.Settings.Save()
        Me.Close()
    End Sub
End Class



