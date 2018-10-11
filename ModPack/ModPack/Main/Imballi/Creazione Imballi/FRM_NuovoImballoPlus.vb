Public Class FRM_NuovoImballoPlus

    Dim DS As New ModPackDBDataSet

    Dim TableTipi As New ModPackDBDataSetTableAdapters.TipiTableAdapter
    Dim TableDistinta As New ModPackDBDataSetTableAdapters.DistintaTableAdapter
    Dim TableImballi As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
    Dim TableIndici As New ModPackDBDataSetTableAdapters.IndiciTableAdapter
    Dim TableRivestimenti As New ModPackDBDataSetTableAdapters.RivestimentiTableAdapter

    Private Sub Clear()
        Cb_Tipi.Items.Clear()
        Ck_AutoNome.Checked = False
        CK_Riv.Checked = False
        Cb_Rivestimenti.Enabled = False
    End Sub
    Private Sub FillDS()
        TableTipi.Fill(DS.Tipi)
        TableDistinta.Fill(DS.Distinta)
        TableImballi.Fill(DS.Imballi)
        TableIndici.Fill(DS.Indici)
        TableRivestimenti.Fill(DS.Rivestimenti)
    End Sub

    Private Function RigaOrdine() As RigaOrdineINPUT

        Dim Riga As New RigaOrdineINPUT With {
         .L = Tx_Lunghezza.Text,
        .P = Tx_Profondita.Text,
        .H = Tx_Altezza.Text,
        .Tipo = DS.Tipi.First(Function(X) X.Descrizione = Cb_Tipi.Text).Tipo,
        .Rivestimento = CK_Riv.Checked,
        .Zoccoli = Cb_Zoccoli.Text,
        .Diagonali = Ck_Diagonali.Checked,
        .BM = RB_BM.Checked,
        .DT = RB_DT.Checked,
        .HT = Ck_HT.Checked,
        .Note = Tx_Note1.Text,
        .Rivest_Tot = Tx_Note2.Text}

        If CK_Riv.Checked = True Then Riga.TipoRivestimento = DS.Rivestimenti.First(Function(y) y.Descrizione = Cb_Rivestimenti.Text).Tipo_Rivestimento

        Debug.WriteLine(Riga.Tipo)

        Return Riga
    End Function

    Private Sub FillComboBoxes()
        'Carica elementi nella Combobox Tipi
        Cb_Tipi.Items.AddRange(DS.Tipi.Select(Function(X) X.Descrizione).Distinct.ToArray)
        If Cb_Tipi.Items.Count > 0 Then Cb_Tipi.SelectedIndex = 0
        'Carica elementi nella Combobox Rivestimenti
        Cb_Rivestimenti.Items.AddRange(DS.Rivestimenti.Select(Function(X) X.Descrizione).ToArray)
        If Cb_Rivestimenti.Items.Count > 0 Then Cb_Rivestimenti.SelectedIndex = 0
        'Carica elementi nella Combobox Zoccoli
        Cb_Zoccoli.Items.AddRange({"2V", "EUR"})
        If Cb_Zoccoli.Items.Count > 0 Then Cb_Zoccoli.SelectedIndex = 0
    End Sub

    Private Sub FRM_NuovoImballoPlus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        FillDS()
        FillComboBoxes()


    End Sub

    Private Sub CB_Rivestimenti_Enabled(sender As Object, e As EventArgs) Handles CK_Riv.CheckedChanged
        Cb_Rivestimenti.Enabled = CK_Riv.Checked
    End Sub

    Private Sub Bt_CREA_Click(sender As Object, e As EventArgs) Handles Bt_CREA.Click
        Try

            Dim Imballo As New NuovoImballo
            Dim RigaInput As New RigaOrdineINPUT With {.L = Tx_Lunghezza.Text,
            .P = Tx_Profondita.Text,
            .H = Tx_Altezza.Text,
             .Tipo = DS.Tipi.First(Function(X) X.Descrizione = Cb_Tipi.Text).Tipo,
        .Rivestimento = CK_Riv.Checked,
        .Zoccoli = Cb_Zoccoli.Text,
        .Diagonali = Ck_Diagonali.Checked,
        .BM = RB_BM.Checked,
        .DT = RB_DT.Checked,
        .HT = Ck_HT.Checked,
        .Note = Tx_Note1.Text,
        .Rivest_Tot = Tx_Note2.Text,
        .Cliente = "",
        .Codice = "",
        .Commessa = "",
        .DataConsegna = Date.Today.Date,
        .Indice = 0,
        .NumeroOrdine = 0,
        .Qt = 1,
        .Riga = 0
        }


            If CK_Riv.Checked = True Then RigaInput.TipoRivestimento = DS.Rivestimenti.First(Function(y) y.Descrizione = Cb_Rivestimenti.Text).Tipo_Rivestimento

            If Ck_AutoNome.Checked = True Then
                Imballo.Nome = NomeImballo.CreaNome(RigaInput.Tipo, RigaInput.HT)
                NomeImballo.AggiornaConteggio()
            Else
                If MsgBox("ATTENZIONE: Non scegliere nomi che potrebbero essere assegnati ad imballi creati automaticamente! Continuare?", vbYesNo, "Attenzione") = MsgBoxResult.Yes Then
                    If Not DS.Imballi.Where(Function(X) X.Imballo = TxNome.Text).Any Then
                        Imballo.Nome = TxNome.Text
                    Else
                        MsgBox(TxNome.Text & " esiste già")
                    End If
                End If
            End If


            Imballo.RigaOrdine = RigaOrdine()
            Imballo.CreaDaOrdine(RigaInput, True, True, False)
            MsgBox("Imballo " & Imballo.Nome & " Creato con successo!")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ck_AutoNome_CheckedChanged(sender As Object, e As EventArgs) Handles Ck_AutoNome.CheckedChanged
        TxNome.Enabled = Not Ck_AutoNome.Checked
    End Sub
End Class