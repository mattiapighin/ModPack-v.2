Public Class FRM_FormatoStampa

    Private Sub Carica()
        With My.Settings
            Tx_Top.Text = .Stampa_MargineTop
            Tx_Bottom.Text = .Stampa_MargineBottom
            Tx_Left.Text = .Stampa_MargineLeft
            Tx_Right.Text = .Stampa_MargineRight
            Ck_Colore.Checked = .Stampa_Color
            Ck_Landscape.Checked = .Stampa_LandScape
        End With
    End Sub

    Private Sub Salva()
        With My.Settings
            .Stampa_MargineTop = Tx_Top.Text
            .Stampa_MargineBottom = Tx_Bottom.Text
            .Stampa_MargineLeft = Tx_Left.Text
            .Stampa_MargineRight = Tx_Right.Text
            .Stampa_Color = Ck_Colore.Checked
            .Stampa_LandScape = Ck_Landscape.Checked
            .Save()
        End With
    End Sub

    Private Sub FRM_FormatoStampa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carica()
    End Sub

    Private Sub Bt_Salva_Click(sender As Object, e As EventArgs) Handles Bt_Salva.Click
        Salva()
        Me.Close()
    End Sub
End Class