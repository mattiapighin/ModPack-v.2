Public Class Form_ModificaImballo

    Dim R As ModPackDBDataSet.ImballiRow

    Private Sub Form_ModificaImballo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ImballiTableAdapter.Fill(Me.ModPackDBDataSet.Imballi)
    End Sub
    Private Sub EliminaImballo()

        Dim IdImballo As Integer = R.Id
        Dim NomeImballo As String = R.Imballo

        If MsgBox("Eliminare tutti i dati relativi all'imballo [" & IdImballo & "] " & NomeImballo & "?", vbYesNo, "Elimina") = MsgBoxResult.Yes Then
            If MsgBox("Sicuro?", vbYesNo, "Elimina") = MsgBoxResult.Yes Then
                SQL.Query("DELETE FROM Imballi WHERE Id = '" & IdImballo & "'")
                SQL.Query("DELETE FROM Indici WHERE Imballo = '" & NomeImballo & "'")
                SQL.Query("DELETE FROM Distinta WHERE Imballo = '" & NomeImballo & "'")
                LOG.Write("Id " & IdImballo & " - " & NomeImballo & " eliminato")
            End If
        End If

        PulisciTutto()
        Me.ImballiTableAdapter.Fill(Me.ModPackDBDataSet.Imballi)

    End Sub
    Private Sub CaricaCodice()
        Try
            R = CType(ImballiBindingSource.Current, DataRowView).Row

            If CbImballo.Text = R.Imballo Then

                Me.DistintaTableAdapter.Fill(Me.ModPackDBDataSet.Distinta)
                Me.IndiciTableAdapter.Fill(Me.ModPackDBDataSet.Indici)
                DGWDistinta.DataSource = ImballiDistintaBindingSource
                DgwIndici.DataSource = ImballiIndiciBindingSource

                txtL.Text = R.L
                txtP.Text = R.P
                txtH.Text = R.H
                txtTipo.Text = R.Tipo
                txtZoccoli.Text = R.Zoccoli
                ckRivestimento.Checked = R.Rivestimento
                txtTipoRivestimento.Text = R.Tipo_Rivestimento
                ckHT.Checked = R.HT
                ckBM.Checked = R.BM
                ckDT.Checked = R.DT
                ckDiagonali.Checked = R.Diagonali
                txtGradiF.Text = R.Gradi_F
                txtGradiT.Text = R.Gradi_T
                txtPrimoMorale.Text = R.Primo_Morale
                txtM2.Text = R.M2
                txtM3.Text = R.M3
                txtPrezzo.Text = R.Prezzo
                TxtSottoMF.Text = R.SottoMF
                TxtSopraMF.Text = R.SopraMF
                TxtSottoMT.Text = R.SottoMT
                TxtSopraMT.Text = R.SopraMT

                If Not R.IsImgNull Then PbImg.BackgroundImage = Immagine.ConvertFromBytes(R.Img)


                PanelCodice.Enabled = False
                PanelModifica.Enabled = True
                PanelButtons.Enabled = True

            Else
                MsgBox("L'imballo non esiste", vbInformation, "Modifica")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub CaricaCodiceNoEdit()
        Try
            R = CType(ImballiBindingSource.Current, DataRowView).Row

            If CbImballo.Text = R.Imballo Then

                Me.DistintaTableAdapter.Fill(Me.ModPackDBDataSet.Distinta)
                Me.IndiciTableAdapter.Fill(Me.ModPackDBDataSet.Indici)
                DGWDistinta.DataSource = ImballiDistintaBindingSource
                DgwIndici.DataSource = ImballiIndiciBindingSource

                txtL.Text = R.L
                txtP.Text = R.P
                txtH.Text = R.H
                txtTipo.Text = R.Tipo
                txtZoccoli.Text = R.Zoccoli
                ckRivestimento.Checked = R.Rivestimento
                txtTipoRivestimento.Text = R.Tipo_Rivestimento
                ckHT.Checked = R.HT
                ckBM.Checked = R.BM
                ckDT.Checked = R.DT
                ckDiagonali.Checked = R.Diagonali
                txtGradiF.Text = R.Gradi_F
                txtGradiT.Text = R.Gradi_T
                txtPrimoMorale.Text = R.Primo_Morale
                txtM2.Text = R.M2
                txtM3.Text = R.M3
                txtPrezzo.Text = R.Prezzo
                TxtSottoMF.Text = R.SottoMF
                TxtSopraMF.Text = R.SopraMF
                TxtSottoMT.Text = R.SottoMT
                TxtSopraMT.Text = R.SopraMT

                If Not R.IsImgNull Then PbImg.BackgroundImage = Immagine.ConvertFromBytes(R.Img)

            Else
                MsgBox("L'imballo non esiste", vbInformation, "Modifica")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub PulisciTutto()
        txtL.Text = ""
        txtP.Text = ""
        txtH.Text = ""
        txtTipo.Text = ""
        txtZoccoli.Text = ""
        txtTipoRivestimento.Text = ""
        txtGradiT.Text = ""
        txtGradiF.Text = ""
        txtPrimoMorale.Text = ""
        txtM2.Text = ""
        txtM3.Text = ""
        txtPrezzo.Text = ""
        PbImg.BackgroundImage = Nothing
        DGWDistinta.DataSource = Nothing
        DgwIndici.DataSource = Nothing
        PanelModifica.Enabled = False
        PanelCodice.Enabled = True
        PanelButtons.Enabled = False
        Me.ImballiTableAdapter.Fill(Me.ModPackDBDataSet.Imballi)
    End Sub
    Private Sub Bt_StartEdit_Click(sender As Object, e As EventArgs) Handles Bt_StartEdit.Click
        CaricaCodice()

    End Sub
    Private Sub Bt_LoadImage_Click(sender As Object, e As EventArgs) Handles Bt_LoadImage.Click
        Dim LoadImage As New OpenFileDialog With {.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|Bitmap (*.bmp)|*.bmp"}
        If LoadImage.ShowDialog = DialogResult.OK Then

            Dim infoReader As System.IO.FileInfo
            infoReader = My.Computer.FileSystem.GetFileInfo(LoadImage.FileName)
            If infoReader.Length <= 512000 Then
                PbImg.BackgroundImage = Image.FromFile(LoadImage.FileName)
            Else
                MsgBox("Selezionare un'immagine di dimensioni inferiori a 500kb")
            End If

        End If
    End Sub
    Private Sub Bt_Salva_Click(sender As Object, e As EventArgs) Handles Bt_Salva.Click
        If MsgBox("ATTENZIONE: Le modifiche colpiranno tutti gli indici associati all'imballo. Continuare?", vbYesNo) = MsgBoxResult.Yes Then

            Dim IR As ModPackDBDataSet.ImballiRow = CType(ImballiBindingSource.Current, DataRowView).Row

            'Aggiorno la distinta
            DistintaTableAdapter.Update(ModPackDBDataSet)
            LOG.Write("Aggiornamento Distinta: " & IR.Imballo)

            IndiciTableAdapter.Update(ModPackDBDataSet)
            LOG.Write("Aggiornamento Indici: " & IR.Imballo)

            'Aggiorno le altre righe
            IR.L = txtL.Text
            IR.P = txtP.Text
            IR.H = txtH.Text
            IR.Tipo = txtTipo.Text
            IR.Zoccoli = txtZoccoli.Text
            IR.Rivestimento = ckRivestimento.Checked
            IR.Tipo_Rivestimento = txtTipoRivestimento.Text
            IR.HT = ckHT.Checked
            IR.BM = ckBM.Checked
            IR.DT = ckDT.Checked
            IR.Diagonali = ckDiagonali.Checked
            IR.Gradi_F = txtGradiF.Text
            IR.Gradi_T = txtGradiT.Text
            IR.Primo_Morale = txtPrimoMorale.Text
            IR.M2 = txtM2.Text
            IR.M3 = txtM3.Text
            IR.Prezzo = txtPrezzo.Text
            IR.SottoMF = TxtSottoMF.Text
            IR.SopraMF = TxtSopraMF.Text
            IR.SottoMT = TxtSottoMT.Text
            IR.SopraMT = TxtSopraMT.Text

            LOG.Write("Aggiornamento riga imballo: " & IR.Imballo)

            'Converte l'immagine in bytes e la salva
            If Not PbImg.BackgroundImage Is Nothing Then
                IR.Img = Immagine.ConvertToBytes(PbImg.BackgroundImage)
            Else
                IR.Img = Nothing
            End If

            ImballiTableAdapter.Update(IR)

            Dim PrezzoVecchio As Single = IR.Prezzo

            Try
                Select Case IR.Tipo
                    Case "GDA"
                        If MsgBox("Ricalcolare automaticamente m² ?", vbYesNo, "Ricalcolo m²") = MsgBoxResult.Yes Then IR.M2 = Imballo.Ricalcolo_M2(IR.Imballo)
                        If MsgBox("Ricalcolare automaticamente m³ ?", vbYesNo, "Ricalcolo m³") = MsgBoxResult.Yes Then IR.M3 = Imballo.Ricalcolo_M3(IR.Imballo)
                        If MsgBox("Ricalcolare automaticamente prezzo ?", vbYesNo, "Ricalcolo Prezzo") = MsgBoxResult.Yes Then IR.Prezzo = Prezzi.Base(IR.Tipo, IR.M3, IR.M2, IR.Tipo_Rivestimento, IR.HT)
                        LOG.Write("Ricalcolato prezzo " & IR.Imballo & " - Vecchio: €" & PrezzoVecchio & " Nuovo: €" & IR.Prezzo)
                    Case "G"
                        If MsgBox("Ricalcolare automaticamente m² ?", vbYesNo, "Ricalcolo m²") = MsgBoxResult.Yes Then IR.M2 = Imballo.Ricalcolo_M2(IR.Imballo)
                        If MsgBox("Ricalcolare automaticamente m³ ?", vbYesNo, "Ricalcolo m³") = MsgBoxResult.Yes Then IR.M3 = Imballo.Ricalcolo_M3(IR.Imballo)
                        If MsgBox("Ricalcolare automaticamente prezzo ?", vbYesNo, "Ricalcolo Prezzo") = MsgBoxResult.Yes Then IR.Prezzo = Prezzi.Base(IR.Tipo, IR.M3, IR.M2, IR.Tipo_Rivestimento, IR.HT)
                        LOG.Write("Ricalcolato prezzo " & IR.Imballo & " - Vecchio: €" & PrezzoVecchio & " Nuovo: €" & IR.Prezzo)
                    Case "P"
                        If MsgBox("Ricalcolare automaticamente m² ?", vbYesNo, "Ricalcolo m²") = MsgBoxResult.Yes Then IR.M2 = Imballo.Ricalcolo_M2(IR.Imballo)
                        If MsgBox("Ricalcolare automaticamente m³ ?", vbYesNo, "Ricalcolo m³") = MsgBoxResult.Yes Then IR.M3 = Imballo.Ricalcolo_M3(IR.Imballo)
                        If MsgBox("Ricalcolare automaticamente prezzo ?", vbYesNo, "Ricalcolo Prezzo") = MsgBoxResult.Yes Then IR.Prezzo = Prezzi.Base(IR.Tipo, IR.M3, IR.M2, IR.Tipo_Rivestimento, IR.HT)
                        LOG.Write("Ricalcolato prezzo " & IR.Imballo & " - Vecchio: €" & PrezzoVecchio & " Nuovo: €" & IR.Prezzo)
                    Case "T"
                        If MsgBox("Ricalcolare automaticamente m² ?", vbYesNo, "Ricalcolo m²") = MsgBoxResult.Yes Then IR.M2 = Imballo.Ricalcolo_M2(IR.Imballo)
                        If MsgBox("Ricalcolare automaticamente m³ ?", vbYesNo, "Ricalcolo m³") = MsgBoxResult.Yes Then IR.M3 = Imballo.Ricalcolo_M3(IR.Imballo)
                        If MsgBox("Ricalcolare automaticamente prezzo ?", vbYesNo, "Ricalcolo Prezzo") = MsgBoxResult.Yes Then IR.Prezzo = Prezzi.Base(IR.Tipo, IR.M3, IR.M2, IR.Tipo_Rivestimento, IR.HT)
                        LOG.Write("Ricalcolato prezzo " & IR.Imballo & " - Vecchio: €" & PrezzoVecchio & " Nuovo: €" & IR.Prezzo)
                    Case "GST"
                        If MsgBox("Ricalcolare automaticamente m² ?", vbYesNo, "Ricalcolo m²") = MsgBoxResult.Yes Then IR.M2 = Imballo.Ricalcolo_M2(IR.Imballo)
                        If MsgBox("Ricalcolare automaticamente m³ ?", vbYesNo, "Ricalcolo m³") = MsgBoxResult.Yes Then IR.M3 = Imballo.Ricalcolo_M3(IR.Imballo)
                        If MsgBox("Ricalcolare automaticamente prezzo ?", vbYesNo, "Ricalcolo Prezzo") = MsgBoxResult.Yes Then IR.Prezzo = Prezzi.GST(IR.M3, IR.L, IR.P, IR.H, IR.Tipo_Rivestimento, IR.HT)
                        LOG.Write("Ricalcolato prezzo " & IR.Imballo & " - Vecchio: €" & PrezzoVecchio & " Nuovo: €" & IR.Prezzo)
                    Case "C"
                        If MsgBox("Ricalcolare automaticamente m² ?", vbYesNo, "Ricalcolo m²") = MsgBoxResult.Yes Then IR.M2 = Imballo.Ricalcolo_M2(IR.Imballo)
                        If MsgBox("Ricalcolare automaticamente m³ ?", vbYesNo, "Ricalcolo m³") = MsgBoxResult.Yes Then IR.M3 = Imballo.Ricalcolo_M3_Morali(IR.Imballo)
                        If MsgBox("Ricalcolare automaticamente prezzo ?", vbYesNo, "Ricalcolo Prezzo") = MsgBoxResult.Yes Then IR.Prezzo = Prezzi.C(IR.M3, IR.L, IR.P, IR.H, IR.Tipo)
                        LOG.Write("Ricalcolato prezzo " & IR.Imballo & " - Vecchio: €" & PrezzoVecchio & " Nuovo: €" & IR.Prezzo)
                    Case "CL"
                        If MsgBox("Ricalcolare automaticamente m² ?", vbYesNo, "Ricalcolo m²") = MsgBoxResult.Yes Then IR.M2 = Imballo.Ricalcolo_M2(IR.Imballo)
                        If MsgBox("Ricalcolare automaticamente m³ ?", vbYesNo, "Ricalcolo m³") = MsgBoxResult.Yes Then IR.M3 = Imballo.Ricalcolo_M3_Morali(IR.Imballo)
                        If MsgBox("Ricalcolare automaticamente prezzo ?", vbYesNo, "Ricalcolo Prezzo") = MsgBoxResult.Yes Then IR.Prezzo = Prezzi.C(IR.M3, IR.L, IR.P, IR.H, IR.Tipo)
                        LOG.Write("Ricalcolato prezzo " & IR.Imballo & " - Vecchio: €" & PrezzoVecchio & " Nuovo: €" & IR.Prezzo)
                    Case "GRO"
                        If MsgBox("Ricalcolare automaticamente m² ?", vbYesNo, "Ricalcolo m²") = MsgBoxResult.Yes Then IR.M2 = Imballo.Ricalcolo_M2(IR.Imballo)
                        If MsgBox("Ricalcolare automaticamente m³ ?", vbYesNo, "Ricalcolo m³") = MsgBoxResult.Yes Then IR.M3 = Imballo.Ricalcolo_M3_Morali(IR.Imballo)
                        If MsgBox("Ricalcolare automaticamente prezzo ?", vbYesNo, "Ricalcolo Prezzo") = MsgBoxResult.Yes Then IR.Prezzo = Prezzi.Base(IR.M3, IR.L, IR.P, IR.H, IR.Tipo)
                        LOG.Write("Ricalcolato prezzo " & IR.Imballo & " - Vecchio: €" & PrezzoVecchio & " Nuovo: €" & IR.Prezzo)
                    Case Else
                        MsgBox("Tipo non riconosciuto")
                End Select

                ImballiTableAdapter.Update(IR)
                MsgBox("Modifiche salvate!", vbInformation, "Salva")

                Dim Imba As String = IR.Imballo

                PulisciTutto()
                CbImballo.Text = Imba
                CaricaCodiceNoEdit()

            Catch ex As Exception


                MsgBox(ex)
            End Try

        End If


    End Sub

    Private Sub Bt_Cancel_Click(sender As Object, e As EventArgs) Handles Bt_Cancel.Click
        PulisciTutto()
    End Sub

    Private Sub Bt_NoImg_Click(sender As Object, e As EventArgs) Handles Bt_NoImg.Click
        PbImg.BackgroundImage = Nothing
    End Sub

    Private Sub Bt_EliminaCodice_Click(sender As Object, e As EventArgs) Handles Bt_EliminaCodice.Click
        EliminaImballo()
    End Sub

    Private Sub Bt_Duplica_Click(sender As Object, e As EventArgs) Handles Bt_Duplica.Click
        Try


            If MsgBox("Vuoi duplicare l'imballo selezionato?", vbYesNo, "Duplica") = MsgBoxResult.Yes Then

                Dim NuovoNome As String = NomeImballo.CreaNome(R.Tipo, R.HT)

                If MsgBox("Assegnare un nome personalizzato?", vbYesNo, "Nome imballo") = MsgBoxResult.Yes Then
                    NuovoNome = InputBox("Nome imballo", "Nome", NuovoNome)
                    If String.IsNullOrEmpty(NuovoNome) Then NuovoNome = NomeImballo.CreaNome(R.Tipo, R.HT)
                End If

                MsgBox("Il nuovo imballo non avrà indici associati", vbInformation, "Duplica")

                'Copia riga imballo
                Using TA As New ModPackDBDataSetTableAdapters.ImballiTableAdapter

                    TA.Insert(NuovoNome, R.L, R.P, R.H, R.Tipo, R.Zoccoli, R.Rivestimento, R.Tipo_Rivestimento, R.HT, R.DT, R.BM, R.Diagonali, R.Gradi_F,
                              R.Gradi_T, R.Primo_Morale, R.M2, R.M3, R.Prezzo, Nothing, R.Data_Creazione, R.SottoMF, R.SottoMT, R.SopraMF, R.SopraMT)
                End Using

                'Copia righe distinta
                Using TA As New ModPackDBDataSetTableAdapters.DistintaTableAdapter
                    For Each row As ModPackDBDataSet.DistintaRow In ModPackDBDataSet.Distinta.Rows
                        If row.Imballo = R.Imballo Then
                            TA.Insert(NuovoNome, row.Riga, row.Part, row.X, row.Y, row.Z, row.N, row.Tag)
                            If NuovoNome = NomeImballo.CreaNome(R.Tipo, R.HT) Then NomeImballo.AggiornaConteggio()
                        End If
                    Next
                End Using


                LOG.Write("Creata nuova riga imballo: " & NuovoNome & " Duplicato di " & R.Imballo)
                PulisciTutto()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Bt_SpostaIndice_Click(sender As Object, e As EventArgs) Handles Bt_SpostaIndice.Click
        If Not DgwIndici.SelectedCells.Count = 0 Then
            If MsgBox("Vuoi assegnare l'indice selezionato ad un altro imballo?", vbYesNo, "Assegna indice") = MsgBoxResult.Yes Then
                Dim Imballo As String = InputBox("Imballo a cui assegnare l'indice:", "", "")

                If Not String.IsNullOrEmpty(Imballo) Then
                    If Ordine.ImballoNomeEXIST(Imballo) Then
                        SQL.SendIndex(Imballo, DgwIndici.CurrentRow.Cells(2).Value, DgwIndici.CurrentRow.Cells(3).Value, DgwIndici.CurrentRow.Cells(4).Value, DgwIndici.CurrentRow.Cells(5).Value)
                        MsgBox("Indice assegnato all'imballo " & Imballo & "!", vbInformation, "Sposta indice")
                        CaricaCodice()
                    Else
                        MsgBox("L'imballo " & Imballo & "non esiste in memoria", vbInformation, "Sposta indice")
                    End If

                End If

                End If
        End If
    End Sub

    Private Sub Bt_AddIndice_Click(sender As Object, e As EventArgs) Handles Bt_AddIndice.Click
        Dim Indice As String = InputBox("Indice:", "Inserisci indice", "")

        If Not String.IsNullOrEmpty(Indice) Then

            If Not Ordine.IndiceEXIST(Indice) Then
                SQL.SendIndex(CbImballo.Text, Indice, "", "", "")
                CaricaCodice()
            Else

                Dim VecchioImballo As String = Ordine.ConvertIndiceToImballo(Indice)

                If MsgBox("L'indice è già associato ad un altro imballo! (" & VecchioImballo & ")" & vbCrLf & "Vuoi spostarlo dall'imballo vecchio a questo?" & vbCrLf &
                          "(In questo modo andranno persi il codice e tutte le note. Per spostare l'indice correttamente" & vbCrLf & "recarsi su modifica imballo " & VecchioImballo & " e usare la funzione 'Sposta indice'", vbYesNo, "Inserisci indice") = MsgBoxResult.Yes Then
                    SQL.SendIndex(CbImballo.Text, Indice, "", "", "")
                    CaricaCodice()
                End If
            End If

        End If

    End Sub

    Private Sub Bt_EliminaIndice_Click(sender As Object, e As EventArgs) Handles Bt_EliminaIndice.Click
        If Not DgwIndici.SelectedCells.Count = 0 Then
            Dim Indice As String = InputBox("Indice:", "Inserisci indice", DgwIndici.CurrentRow.Cells("IndiceDataGridViewTextBoxColumn").Value)
            Dim IndiceConferma As String = InputBox("Conferma eliminazione indice:", "Inserisci indice", "")

            If Not String.IsNullOrEmpty(Indice) And Not String.IsNullOrEmpty(IndiceConferma) And Indice = IndiceConferma Then

                If MsgBox("Eliminare definitivamente l'indice " & Indice & "?", vbYesNo, "Elimina indice") = MsgBoxResult.Yes Then
                    SQL.Query("DELETE FROM Indici WHERE Indice = '" & Indice & "'")
                    CaricaCodice()
                    MsgBox("Indice " & Indice & " eliminato!", vbInformation, "Elimina indice")
                End If

            End If

        End If

    End Sub


End Class

