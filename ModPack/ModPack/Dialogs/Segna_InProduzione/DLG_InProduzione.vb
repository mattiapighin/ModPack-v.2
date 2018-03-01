Public Class DLG_InProduzione

    Dim Table As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
    Dim DS As New ModPackDBDataSet.OrdiniDataTable

    Private Sub DLG_InProduzione_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        Table.Fill(DS)
        Lbl_Update.Text = "Ultimo aggiornamento DataSet: " & Date.Now.ToShortTimeString
    End Sub

    Private Sub CaricaRiga()

        If Not String.IsNullOrEmpty(Tx_ID.Text) Then

            Try

                Dim Riga As ModPackDBDataSet.OrdiniRow = DS.SingleOrDefault(Function(X) X.Id = Tx_ID.Text OrElse Nothing)

                If Not IsDBNull(Riga) Then

                    If Riga.Evaso = True Then

                        Lb_Cliente.Text = Riga.Cliente
                        LB_CodBicc.Text = Riga.Imballo
                        LB_CodModine.Text = Riga.Codice
                        Lb_Commessa.Text = Riga.Commessa
                        Lb_PZ.Text = "PZ. " & Riga.Qt

                        BT_InProduzione.ForeColor = Color.Green
                        BT_InProduzione.Text = "IMBALLO EVASO!"
                        BT_InProduzione.Enabled = False
                        Exit Sub
                    End If
                    If Riga.Produzione = True Then

                        Lb_Cliente.Text = Riga.Cliente
                        LB_CodBicc.Text = Riga.Imballo
                        LB_CodModine.Text = Riga.Codice
                        Lb_Commessa.Text = Riga.Commessa
                        Lb_PZ.Text = Riga.Qt

                        BT_InProduzione.ForeColor = Color.Blue
                        BT_InProduzione.Text = "IMBALLO GIA' IN PRODUZIONE!"
                        BT_InProduzione.Enabled = False
                        Exit Sub
                    End If

                    BT_InProduzione.ForeColor = Color.Black
                    BT_InProduzione.Enabled = True
                    BT_InProduzione.Text = "INIZIO PRODUZIONE"

                    Lb_Cliente.Text = Riga.Cliente
                    LB_CodBicc.Text = Riga.Imballo
                    LB_CodModine.Text = Riga.Codice
                    Lb_Commessa.Text = Riga.Commessa
                    Lb_PZ.Text = Riga.Qt

                    'Se è attiva l'opzione barcodescanner setta automaticamente come in produzione
                    If Ck_Barcode.Checked = True Then SetProduzione()

                End If

            Catch ex As Exception
                Lb_Cliente.Text = ""
                LB_CodBicc.Text = ""
                LB_CodModine.Text = ""
                Lb_Commessa.Text = ""
                Lb_PZ.Text = "PZ. "

                BT_InProduzione.ForeColor = Color.DarkSlateGray
                BT_InProduzione.Enabled = False
                BT_InProduzione.Text = "IMBALLO NON TROVATO"
            End Try

        End If

    End Sub

    Private Sub Clear()
        Tx_ID.Text = ""
        Lb_Cliente.Text = ""
        LB_CodBicc.Text = ""
        LB_CodModine.Text = ""
        Lb_Commessa.Text = ""
        Lb_PZ.Text = ""

        BT_InProduzione.ForeColor = Color.Black
        BT_InProduzione.Enabled = False
    End Sub



    Private Sub Tx_ID_TextChanged(sender As Object, e As EventArgs) Handles Tx_ID.TextChanged
        CaricaRiga()
    End Sub

    Private Sub BT_InProduzione_Click(sender As Object, e As EventArgs) Handles BT_InProduzione.Click
        SetProduzione()
    End Sub

    Private Sub SetProduzione()
        Try
            SQL.Query("UPDATE Ordini SET Produzione = 'True' WHERE ID = '" & Tx_ID.Text & "'")
            MsgBox(LB_CodBicc.Text & " IN PRODUZIONE", vbInformation, "Inizio produzione")
            Clear()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Ck_Barcode_CheckedChanged(sender As Object, e As EventArgs) Handles Ck_Barcode.CheckedChanged
        If Ck_Barcode.Checked = True Then MsgBox("Attivando questa opzione verranno automaticamente contrassegnati" & vbCrLf & "Come 'IN PRODUZIONE' i codici inseriti nella textbox")
    End Sub
End Class