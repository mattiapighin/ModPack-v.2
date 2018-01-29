Public Class Form_Preferenze

    Private Sub Bt_FormatoStampa_Click(sender As Object, e As EventArgs) Handles Bt_FormatoStampa.Click
        FRM_FormatoStampa.ShowDialog()
    End Sub
    Private Sub CaricaSettingsEtichette()
        With My.Settings
            Txt_MargineBottom.Text = .Etichette_MargineBottom
            Txt_MargineTop.Text = .Etichette_MargineTop
            Txt_MargineRight.Text = .Etichette_MargineRight
            Txt_MargineLeft.Text = .Etichette_MargineLeft
            Txt_mmX.Text = .Etichette_DimensioneX
            Txt_mmY.Text = .Etichette_DimensioneY
            Txt_NomeStampante.Text = .Etichette_Stampante
        End With
    End Sub
    Private Sub SalvaSettingsEtichette()
        With My.Settings
            .Etichette_MargineBottom = Txt_MargineBottom.Text
            .Etichette_MargineTop = Txt_MargineTop.Text
            .Etichette_MargineRight = Txt_MargineRight.Text
            .Etichette_MargineLeft = Txt_MargineLeft.Text
            .Etichette_DimensioneX = Txt_mmX.Text
            .Etichette_DimensioneY = Txt_mmY.Text
            .Etichette_Stampante = Txt_NomeStampante.Text
            My.Settings.Save()
        End With
    End Sub

    Private Sub CaricaSettingsCK()
        Ck_Evaso.Checked = My.Settings.CK_ConfermaEvaso
        Ck_ColoraScaduti.Checked = My.Settings.OrdiniAperti_ColoraScaduti
        Ck_ColoraEvasi.Checked = My.Settings.OrdiniAperti_ColoraEvasi
        Ck_CheckCaricamento.Checked = My.Settings.CheckInserimentoImballo
        CkNoteDinamico.Checked = My.Settings.NoteDinamico
        Ck_TextMain.Checked = My.Settings.TestoIconeMain
        Ck_TreeView.Checked = My.Settings.TreeView
        CK_DescrizioneClipboard.Checked = My.Settings.NumeroOrdineClipboard
    End Sub
    Private Sub SalvaSettingsCK()
        My.Settings.CK_ConfermaEvaso = Ck_Evaso.Checked
        My.Settings.OrdiniAperti_ColoraScaduti = Ck_ColoraScaduti.Checked
        My.Settings.OrdiniAperti_ColoraEvasi = Ck_ColoraEvasi.Checked
        My.Settings.CheckInserimentoImballo = Ck_CheckCaricamento.Checked
        My.Settings.NoteDinamico = CkNoteDinamico.Checked
        My.Settings.TestoIconeMain = Ck_TextMain.Checked
        My.Settings.TreeView = Ck_TreeView.Checked
        My.Settings.NumeroOrdineClipboard = CK_DescrizioneClipboard.Checked
    End Sub

    Private Sub CaricaSettingsDistinta()
        Ck_Barcode.Checked = My.Settings.StampaBarcodeDistinte
        CkCodiceQT.Checked = Not My.Settings.StampaBarcodeSoloCodice
        CkBarcodeSoloCodice.Checked = My.Settings.StampaBarcodeSoloCodice
        Nu_FontDistinta.Value = My.Settings.DimensioneFontDistinta
        Nu_RigheDistinta.Value = My.Settings.NumeroRigheDistinta
    End Sub
    Private Sub SalvaSettingsDistinta()
        My.Settings.StampaBarcodeDistinte = Ck_Barcode.Checked
        My.Settings.StampaBarcodeSoloCodice = CkBarcodeSoloCodice.Checked
        My.Settings.DimensioneFontDistinta = Nu_FontDistinta.Value
        My.Settings.NumeroRigheDistinta = Nu_RigheDistinta.Value
    End Sub

    Private Sub CaricaRiferimenti()
        Txt_utente.Text = My.Settings.Utente
        Txt_LimiteStorico.Text = My.Settings.OrdiniNRecords
        RBexcel_nuovi.Checked = My.Settings.ListaNuoviExcel
        RBtext_nuovi.Checked = Not My.Settings.ListaNuoviExcel
        TxtScegliExcel.Text = My.Settings.ExcelPath
    End Sub
    Private Sub SalvaRiferimenti()
        If Not String.IsNullOrEmpty(Txt_utente.Text) Then My.Settings.Utente = Txt_utente.Text
        If Not String.IsNullOrEmpty(Txt_LimiteStorico.Text) Then My.Settings.OrdiniNRecords = Txt_LimiteStorico.Text
        My.Settings.ListaNuoviExcel = RBexcel_nuovi.Checked
        My.Settings.ListaNuoviExcel = Not RBtext_nuovi.Checked
        If Not String.IsNullOrEmpty(TxtScegliExcel.Text) Then My.Settings.ExcelPath = TxtScegliExcel.Text
    End Sub


    Private Sub Form_Preferenze_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CaricaSettingsEtichette()
        Catch ex As Exception
            Errore.Show("Caricamento settings etichette", ex.Message)
        End Try

        Try
            CaricaSettingsCK()
        Catch ex As Exception
            Errore.Show("Caricamento settings CheckBox", ex.Message)
        End Try

        Try
            CaricaSettingsDistinta()
        Catch ex As Exception
            Errore.Show("Caricamento settings Distinta", ex.Message)
        End Try

        Try
            CaricaRiferimenti()
        Catch ex As Exception
            Errore.Show("Caricamento riferimenti", ex.Message)
        End Try

        Box_Developer.Enabled = My.Settings.Developer

    End Sub
    Private Sub Bt_Salva_Click(sender As Object, e As EventArgs) Handles Bt_Salva.Click
        If MsgBox("Salvare le modifiche?", vbYesNo, "Preferenze") = MsgBoxResult.Yes Then
            If Txt_utente.Text <> My.Settings.Utente Then LOG.Write("Utente modificato da [" & My.Settings.Utente & "] a [" & Txt_utente.Text & "]")
            SalvaSettingsEtichette()
            SalvaSettingsCK()
            SalvaSettingsDistinta()
            SalvaRiferimenti()

            MsgBox("Modifiche salvate", vbOKOnly, "Preferenze")
            LOG.Write("Modificate preferenze")


        End If

    End Sub

    Private Sub Bt_SettingsEmail_Click(sender As Object, e As EventArgs) Handles Bt_SettingsEmail.Click
        Form_Preferenze_Email.Show()
    End Sub

    Private Sub Bt_TestConnessioni_Click(sender As Object, e As EventArgs) Handles Bt_TestConnessioni.Click
        FRM_TestConnessioni.Show()
    End Sub

    Private Sub Bt_ScegliExcel_Click(sender As Object, e As EventArgs) Handles Bt_ScegliExcel.Click
        Dim Dialog As New OpenFileDialog With {.Filter = ("Excel|*.exe"), .FileName = "Excel.exe", .Title = "Riferimento a Excel.exe"}
        If Dialog.ShowDialog = DialogResult.OK Then
            TxtScegliExcel.Text = Dialog.FileName
        End If
    End Sub

    Private Sub Bt_EliminaOrdine_Click(sender As Object, e As EventArgs) Handles Bt_EliminaOrdine.Click
        Dim Ordine As String = ""
        Dim OrdineControllo As String = ""

        If MsgBox("Attenzione: L'ordine selezionato verrà eliminato definitivamente dal database" & vbCrLf & "Sei sicuro di voler continuare?", vbYesNo, "Elimina Ordine") = MsgBoxResult.Yes Then

            Ordine = InputBox("Inserisci ordine da eliminare", "Elimina Ordine", "")
            OrdineControllo = InputBox("Inserisci nuovamente ordine da eliminare", "Elimina Ordine", "")

            If Not Ordine = OrdineControllo Then
                MsgBox("I due numeri di ordine inseriti non corrispondono", MsgBoxStyle.Critical, "Elimina Ordine")
                Exit Sub
            End If

            If MsgBox("Vuoi eliminare anche gli indici degli imballi contenuti nell'ordine?", vbYesNo, "Elimina Ordine") = MsgBoxResult.No Then
                SQL.Query("DELETE FROM Ordini WHERE Ordine = '" & Ordine & "'")
                LOG.Write("Eliminato ordine " & Ordine)
                MsgBox("Eliminazione completata!", vbInformation, "Elimina Ordine")
            Else

                Dim ListaIndici As New List(Of Integer)

                Using Table As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
                    Using DS As New ModPackDBDataSet.OrdiniDataTable
                        Table.Fill(DS)

                        Dim Rows() As DataRow = DS.Select("Ordine = '" & Ordine & "'")

                        For Each R As DataRow In Rows
                            ListaIndici.Add(R(4))
                        Next

                    End Using
                End Using

                '-------

                For Each Indice As Integer In ListaIndici
                    SQL.Query("DELETE FROM Indici WHERE Indice = '" & Indice & "'")
                    LOG.Write("Eliminato indice " & Indice)
                Next

                SQL.Query("DELETE FROM Ordini WHERE Ordine = '" & Ordine & "'")
                LOG.Write("Eliminato ordine " & Ordine)

                MsgBox("Eliminazione completata!", vbInformation, "Elimina Ordine")

            End If
        End If
    End Sub

    Private Sub Bt_PulisciImballi_Click(sender As Object, e As EventArgs) Handles Bt_PulisciImballi.Click

        If MsgBox("Questa funzione permette di eliminare dal database le righe imballi senza alcun indice associato." & vbCrLf & "Attenzione, potrebbero essere eliminati imballi ancora da produrre" & vbCrLf & "Sei sicuro di voler continuare?", vbYesNo, "Pulizia imballi") = MsgBoxResult.Yes Then

            Dim ListaImballi As New List(Of String)
            Dim ListaEliminare As New List(Of String)

            Using Indici As New ModPackDBDataSetTableAdapters.IndiciTableAdapter
                Using DS As New ModPackDBDataSet.IndiciDataTable
                    Indici.Fill(DS)

                    For Each Row As ModPackDBDataSet.IndiciRow In DS
                        If Not ListaImballi.Contains(Row.Imballo) Then ListaImballi.Add(Row.Imballo)
                    Next

                End Using
            End Using
            Using Imballi As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
                Using DS As New ModPackDBDataSet.ImballiDataTable
                    Imballi.Fill(DS)

                    For Each Row As ModPackDBDataSet.ImballiRow In DS
                        If Not ListaImballi.Contains(Row.Imballo) Then
                            ListaEliminare.Add(Row.Imballo)
                        End If
                    Next

                End Using
            End Using

            For Each Imballo As String In ListaEliminare
                If MsgBox("Eliminare " & Imballo & "?", vbYesNo, "Pulizia imballi") = MsgBoxResult.Yes Then
                    SQL.Query("DELETE FROM Imballi WHERE Imballo = '" & Imballo & "'")
                    LOG.Write("Eliminato imballo " & Imballo)
                End If
            Next

            If ListaEliminare.Count = 0 Then MsgBox("Non ci sono imballi da eliminare!", vbInformation, "Pulizia imballi")

        End If

    End Sub

    Private Sub Bt_GestioneTipi_Click(sender As Object, e As EventArgs) Handles Bt_GestioneTipi.Click
        Form_GestioneTipi.Show()
    End Sub

    Private Sub Bt_Log_Click(sender As Object, e As EventArgs) Handles Bt_Log.Click
        DLG_MostraLOG.ShowDialog()
        'Process.Start(My.Settings.FileLogPath)
    End Sub

    Private Sub BT_SetupRives_Click(sender As Object, e As EventArgs) Handles BT_SetupRives.Click
        FRM_SetupRivestimenti.Show()
    End Sub

    Private Sub Bt_AzzeraDB_Click(sender As Object, e As EventArgs) Handles Bt_AzzeraDB.Click

        If MsgBox("Questa operazione azzera completamente tutti i dati caricati, continuare? (3)", vbYesNo, "Azzera") = MsgBoxResult.Yes Then
            If MsgBox("Questa operazione azzera completamente tutti i dati caricati, continuare? (2)", vbYesNo, "Azzera") = MsgBoxResult.Yes Then
                If MsgBox("Questa operazione azzera completamente tutti i dati caricati, continuare? (1)", vbYesNo, "Azzera") = MsgBoxResult.Yes Then

                    If MsgBox("Troncare tabella DISTINTA?", vbYesNo, "Azzera") = MsgBoxResult.Yes Then
                        SQL.Query("TRUNCATE TABLE Distinta")
                    End If

                    If MsgBox("Troncare tabella IMBALLI?", vbYesNo, "Azzera") = MsgBoxResult.Yes Then
                        SQL.Query("TRUNCATE TABLE Imballi")
                    End If

                    If MsgBox("Troncare tabella INDICI?", vbYesNo, "Azzera") = MsgBoxResult.Yes Then
                        SQL.Query("TRUNCATE TABLE Indici")
                    End If

                    If MsgBox("Troncare tabella ORDINI?", vbYesNo, "Azzera") = MsgBoxResult.Yes Then
                        SQL.Query("TRUNCATE TABLE Ordini")
                    End If

                    If MsgBox("Troncare tabella NOTE IMBALLI?", vbYesNo, "Azzera") = MsgBoxResult.Yes Then
                        SQL.Query("TRUNCATE TABLE NoteImballi")
                    End If

                    If MsgBox("Troncare tabella MEMO?", vbYesNo, "Azzera") = MsgBoxResult.Yes Then
                        SQL.Query("TRUNCATE TABLE Memo")
                    End If

                    If MsgBox("Ripristinare file XML?", vbYesNo, "Azzera") = MsgBoxResult.Yes Then
                        IO.File.Delete(My.Settings.XMLpath)
                        XML.CreaXML()
                    End If

                    Debug.WriteLine("Operazione completata!")

                End If
            End If
        End If



    End Sub

    Private Sub Bt_InviaQuery_Click(sender As Object, e As EventArgs) Handles Bt_InviaQuery.Click
        Try
            Dim Query As String = InputBox("Query", "Query", "")

            If Not String.IsNullOrEmpty(Query) Then
                SQL.Query(Query)
            End If

        Catch ex As Exception

        End Try
    End Sub




    Private Sub Form_Preferenze_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.Alt And e.KeyCode = Keys.F10 Then
            My.Settings.Developer = Not My.Settings.Developer
            My.Settings.Save()
            Box_Developer.Enabled = My.Settings.Developer
            If My.Settings.Developer = True Then
                MsgBox("Opzioni sviluppatore attivate!", vbInformation, "Developer")
            Else
                MsgBox("Opzioni sviluppatore disattivate!", vbInformation, "Developer")
            End If

        End If
    End Sub

    Private Sub Bt_ResetSettings_Click(sender As Object, e As EventArgs) Handles Bt_ResetSettings.Click

        If MsgBox("Reimpostare i settings a default?", vbYesNo, "Reset Settings") = MsgBoxResult.Yes Then
            My.Settings.Reset()
            MsgBox("Reset completato!", vbInformation, "Reset Settings")
        End If

    End Sub

    Private Sub Bt_PuliziaOrdini_Click(sender As Object, e As EventArgs) Handles Bt_PuliziaOrdini.Click
        Form_PuliziaOrdini.ShowDialog()
    End Sub

    Private Sub Bt_GestMagazzini_Click(sender As Object, e As EventArgs) Handles Bt_GestMagazzini.Click
        FRM_GestioneMagazzini.ShowDialog()
    End Sub
End Class