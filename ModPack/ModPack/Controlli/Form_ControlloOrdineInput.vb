Public Class Form_ControlloOrdineInput
    Dim Ordine() As String
    Dim indice As Integer

    Private Sub Bt_OpenOrdine_Click(sender As Object, e As EventArgs) Handles Bt_OpenOrdine.Click
        indice = 0

        Dim G As New OpenFileDialog With {.Filter = "File Ordine|*.txt"}

        If G.ShowDialog = DialogResult.OK Then
            Lbl_NumeroOrdine.Text = IO.Path.GetFileNameWithoutExtension(G.FileName)
            Ordine = IO.File.ReadAllLines(G.FileName)
            LblTotRighe.Text = Ordine.Length
            Txt_TotRighe.Text = Ordine.Length

            Dim infoReader As System.IO.FileInfo
            infoReader = My.Computer.FileSystem.GetFileInfo(My.Settings.FileLogPath)

            Lbl_DataOrdine.Text = infoReader.CreationTime
        End If

        CaricaRiga(indice)
    End Sub

    Private Sub CaricaRiga(ByVal Index As Integer)
        If Not Index >= Ordine.Length Then
            Txt_VaiARiga.Text = Index + 1
            Dim R() As String = Split(Ordine(Index), ";")

            If R.Length = 20 Then
                Tx_Riga.Text = R(0)
                Tx_Indice.Text = R(1)
                Tx_Qt.Text = R(2)
                Tx_Cliente.Text = R(3)
                Tx_Codice.Text = R(4)
                Tx_Commessa.Text = R(5)
                Tx_L.Text = R(6)
                Tx_P.Text = R(7)
                Tx_H.Text = R(8)
                Tx_Tipo.Text = R(9)
                Tx_Zoccoli.Text = R(10)
                Ck_Rivestimento.Checked = R(11)
                Tx_Rivestimento.Text = R(12)
                Tx_Note1.Text = R(13)
                Tx_Consegna.Text = R(14)
                Ck_BM.Checked = R(17)
                Ck_DT.Checked = R(16)
                Ck_HT.Checked = R(15)
                Tx_Note2.Text = R(18)
                Ck_Diagonali.Checked = R(19)

                indice = Index
            Else
                Pulisci()
                MsgBox("Attenzione: Riga " & Index & " non formattata correttamente!", vbCritical, "Errore")
            End If
        End If
    End Sub

    Private Sub Bt_Right_Click(sender As Object, e As EventArgs) Handles Bt_Right.Click
        If Not indice = Ordine.Length - 1 Then
            indice += 1
            CaricaRiga(indice)
        End If

    End Sub

    Private Sub Bt_Left_Click(sender As Object, e As EventArgs) Handles Bt_Left.Click
        If Not indice = 0 Then
            indice -= 1
            CaricaRiga(indice)
        End If


    End Sub

    Private Sub Pulisci()
        Tx_Riga.Text = ""
        Tx_Indice.Text = ""
        Tx_Qt.Text = ""
        Tx_Cliente.Text = ""
        Tx_Codice.Text = ""
        Tx_Commessa.Text = ""
        Tx_L.Text = ""
        Tx_P.Text = ""
        Tx_H.Text = ""
        Tx_Tipo.Text = ""
        Tx_Zoccoli.Text = ""
        Ck_Rivestimento.Checked = False
        Tx_Rivestimento.Text = ""
        Tx_Note1.Text = ""
        Tx_Consegna.Text = ""
        Ck_BM.Checked = False
        Ck_DT.Checked = False
        Ck_HT.Checked = False
        Tx_Note2.Text = ""
        Ck_Diagonali.Checked = False
    End Sub

    Private Sub Txt_VaiARiga_TextChanged(sender As Object, e As EventArgs) Handles Txt_VaiARiga.TextChanged
        If Not String.IsNullOrEmpty(Lbl_NumeroOrdine.Text) Then
            If Not Txt_VaiARiga.Text = "" Then
                If Txt_VaiARiga.Text > 0 And Txt_VaiARiga.Text <= Ordine.Length And Not String.IsNullOrEmpty(Txt_VaiARiga.Text) Then
                    CaricaRiga(Txt_VaiARiga.Text - 1)
                Else
                    Pulisci()
                End If
            Else
                Pulisci()
            End If
        End If
    End Sub
End Class