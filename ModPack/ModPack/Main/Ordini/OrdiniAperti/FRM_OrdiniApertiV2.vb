Public Class FRM_OrdiniApertiV2

    Dim DS As New ModPackDBDataSet

    Dim OrdiniTable As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
    Dim ImballiTable As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
    Dim RiferTable As New ModPackDBDataSetTableAdapters.RiferOrdiniTableAdapter

    Dim OrdineAperto As String
    Dim ListaBindelli As List(Of ModPackDBDataSet.OrdiniRow)

    Private Sub FRM_OrdiniApertiV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillAll()

        Carica_OrdiniAperti()
        SplitContainer1.Panel1Collapsed = True

        Ck_AnteprimaStampa.Checked = My.Settings.New_AnteprimeStampa

    End Sub

    Private Sub FillAll()
        OrdiniTable.Fill(DS.Ordini)
        ImballiTable.Fill(DS.Imballi)
        RiferTable.Fill(DS.RiferOrdini)
    End Sub

    Private Sub Carica_OrdiniAperti()

        DGW_OrdiniAperti.Rows.Clear()

        Dim ListaOrdini As New List(Of String)
        ListaOrdini = DS.Ordini.Where(Function(x) x.Evaso = False).Select(Function(y) y.Ordine).Distinct.ToList

        ListaOrdini.Sort()

        For Each Ordine As String In ListaOrdini
            DGW_OrdiniAperti.Rows.Add(Ordine, DS.RiferOrdini.Where(Function(X) X.NumeroCO = Ordine).Select(Function(y) y.Ordine).FirstOrDefault)
        Next

        CB_ScegliSett.DataSource = DS.Ordini.Where(Function(X) X.Evaso = False).Select(Function(y) FunzioniVarie.Get_WK(y.Data_Consegna)).Distinct.ToList


    End Sub
    Private Sub Carica_Ordine(ByVal Ordine As String)
        GB_Stampe.Enabled = True
        GB_Produzione.Enabled = True
        DGW_Ordine.Rows.Clear()

        Dim ListaOrdine As New List(Of ModPackDBDataSet.OrdiniRow)
        ListaOrdine = DS.Ordini.Where(Function(X) X.Ordine = Ordine).ToList

        For Each Row As ModPackDBDataSet.OrdiniRow In ListaOrdine

            Dim IMGStato As Image = New Bitmap(24, 24)

            If Row.Stampato = False Then IMGStato = My.Resources.Status_Wait
            If Row.Evaso = True Then IMGStato = My.Resources.Status_Done

            Dim Week As Integer = DatePart(DateInterval.WeekOfYear, Row.Data_Consegna, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFourDays)
            DGW_Ordine.Rows.Add({Row.Id, Row.Ordine, Row.Riga, Row.Imballo, Row.Qt, Row.Tipo, Row.Codice, Row.Commessa, Row.HT, Week, IMGStato})
        Next

        DGW_Ordine.Columns(1).Visible = False

        'Colora le righe evase in grigio
        For Each row As DataGridViewRow In DGW_Ordine.Rows
            If DS.Ordini.Where(Function(x) x.Id = row.Cells(0).Value).First.Evaso = True Then
                row.DefaultCellStyle.ForeColor = Color.Silver
            End If
        Next

    End Sub
    Private Sub Carica_Settimana(ByVal Settimana As Integer)
        GB_Stampe.Enabled = False
        GB_Produzione.Enabled = False

        DGW_Ordine.Rows.Clear()

        Dim ListaOrdine As New List(Of ModPackDBDataSet.OrdiniRow)
        ListaOrdine = DS.Ordini.Where(Function(X) FunzioniVarie.Get_WK(X.Data_Consegna) = Settimana).ToList

        For Each Row As ModPackDBDataSet.OrdiniRow In ListaOrdine

            Dim IMGStato As Image = New Bitmap(24, 24)

            If Row.Stampato = False Then IMGStato = My.Resources.Status_Wait
            If Row.Evaso = True Then IMGStato = My.Resources.Status_Done

            Dim Week As Integer = DatePart(DateInterval.WeekOfYear, Row.Data_Consegna, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFourDays)
            DGW_Ordine.Rows.Add({Row.Id, Row.Ordine, Row.Riga, Row.Imballo, Row.Qt, Row.Tipo, Row.Codice, Row.Commessa, Row.HT, Week, IMGStato})

        Next

        DGW_Ordine.Columns(1).Visible = True

    End Sub

    Private Sub Bt_SeeAll_Click(sender As Object, e As EventArgs) Handles Bt_SeeAll.Click
        GB_Stampe.Enabled = False
        GB_Produzione.Enabled = False
        DGW_Ordine.Rows.Clear()

        Dim ListaOrdine As New List(Of ModPackDBDataSet.OrdiniRow)
        ListaOrdine = DS.Ordini.Where(Function(X) X.Evaso = False).ToList

        For Each Row As ModPackDBDataSet.OrdiniRow In ListaOrdine

            Dim IMGStato As Image = New Bitmap(24, 24)

            If Row.Stampato = False Then IMGStato = My.Resources.Status_Wait
            If Row.Evaso = True Then IMGStato = My.Resources.Status_Done

            Dim Week As Integer = DatePart(DateInterval.WeekOfYear, Row.Data_Consegna, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFourDays)
            DGW_Ordine.Rows.Add({Row.Id, Row.Ordine, Row.Riga, Row.Imballo, Row.Qt, Row.Tipo, Row.Codice, Row.Commessa, Row.HT, Week, IMGStato})

        Next

        DGW_Ordine.Columns(1).Visible = True

    End Sub

    Private Sub DGW_OrdiniAperti_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGW_OrdiniAperti.CellClick
        OrdineAperto = DGW_OrdiniAperti.CurrentRow.Cells(0).Value
        Carica_Ordine(OrdineAperto)
    End Sub

    '### Context menu strip
    Dim ListaDaStampare As New List(Of ModPackDBDataSet.OrdiniRow)
    Private Sub CM_Context_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CM_Context.Opening
        Select Case DGW_Ordine.Rows.GetRowCount(DataGridViewElementStates.Selected)
            Case = 1
                ELIMINARIGAToolStripMenuItem.Visible = True
                MODIFICAIMBALLOToolStripMenuItem.Visible = True
            Case Else
                ELIMINARIGAToolStripMenuItem.Visible = False
                MODIFICAIMBALLOToolStripMenuItem.Visible = False
        End Select
    End Sub
    Private Sub RICERCAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RICERCAToolStripMenuItem.Click
        SplitContainer1.Panel1Collapsed = Not SplitContainer1.Panel1Collapsed
    End Sub

    Private Sub Stampa_Sel_Bindelli_Click(sender As Object, e As EventArgs) Handles STAMPABINDELLOToolStripMenuItem.Click

        ListaDaStampare.Clear()

        For Each Row As DataGridViewRow In DGW_Ordine.SelectedRows
            ListaDaStampare.Add(DS.Ordini.Where(Function(X) X.Id = Row.Cells("Id").Value).First)
        Next

        If ListaDaStampare.Count > 0 Then
            Bindelli.Stampa(ListaDaStampare, Ck_AnteprimaStampa.Checked)
        End If

    End Sub
    Private Sub Stampa_Sel_Disegni_Click(sender As Object, e As EventArgs) Handles STAMPADISTINTAToolStripMenuItem.Click

        ListaDaStampare.Clear()

        For Each Row As DataGridViewRow In DGW_Ordine.SelectedRows
            ListaDaStampare.Add(DS.Ordini.Where(Function(X) X.Id = Row.Cells("Id").Value).First)
        Next

        If ListaDaStampare.Count > 0 Then
            Distinta.Stampa(ListaDaStampare, Ck_AnteprimaStampa.Checked)
        End If


    End Sub

    Private Sub MODIFICAIMBALLOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MODIFICAIMBALLOToolStripMenuItem.Click
        Form_ModificaImballo.Show()
        Form_ModificaImballo.CbImballo.Text = DGW_Ordine.CurrentRow.Cells("Imballo").Value
        Form_ModificaImballo.CaricaCodiceNoEdit()
    End Sub

    Private Sub ELIMINARIGAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARIGAToolStripMenuItem.Click

        Try

            Dim Row As ModPackDBDataSet.OrdiniRow = DS.Ordini.Where(Function(X) X.Id = DGW_Ordine.CurrentRow.Cells("Id").Value).First

            If MsgBox("Eliminare riga " & Row.Imballo & " - PZ. " & Row.Qt & "( D " & Row.Codice & " C " & Row.Commessa & " )" & vbCrLf & "L'operazione non può essere annullata!", vbYesNo, "Elimina riga") = MsgBoxResult.Yes Then

                Try

                    OrdiniTable.Delete(Row.Id, Row.Ordine, Row.Riga, Row.Imballo, Row.Indice, Row.Qt, Row.Cliente, Row.Codice, Row.Commessa, Row.L, Row.P, Row.H, Row.Tipo, Row.Zoccoli, Row.Rivestimento, Row.Tipo_Rivestimento, Row.Data_Consegna, Row.HT, Row.DT, Row.BM, Row.Magazzino, Row.Diagonali, Row.Stampato, Row.Produzione, Row.Evaso, Row.Data_Ordine)
                    OrdiniTable.Update(DS.Ordini)

                    LOG.Write("Elimina riga - Eliminata riga " & Row.Id & " dell'ordine " & Row.Ordine)
                    MsgBox("Riga eliminata!")

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If

            FillAll()
            Carica_Ordine(OrdineAperto)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ELIMINAORDINEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINAORDINEToolStripMenuItem.Click

        Dim OrdineDaEliminare As String = DGW_OrdiniAperti.CurrentRow.Cells(0).Value    ' Numero di ordine da eliminare dal DB

        Dim ListaRighe As New List(Of ModPackDBDataSet.OrdiniRow)                       ' Creo lista di righe riferite a quell'ordine
        ListaRighe = DS.Ordini.Where(Function(X) X.Ordine = OrdineDaEliminare).ToList   ' Riempio la lista

        If MsgBox("Elimnare intero ordine " & OrdineDaEliminare & "?", vbYesNo, "Elimina Ordine") = MsgBoxResult.Yes Then
            If MsgBox("Verranno eliminate definitivamente " & ListaRighe.Count & " righe. Gli imballi creati e i relativi indici non saranno toccati." & vbCrLf & "Continuare?", vbYesNo, "Elimina Ordine") = MsgBoxResult.Yes Then

                Try

                    For Each Row As ModPackDBDataSet.OrdiniRow In ListaRighe

                        OrdiniTable.Delete(Row.Id, Row.Ordine, Row.Riga, Row.Imballo, Row.Indice, Row.Qt, Row.Cliente, Row.Codice, Row.Commessa, Row.L, Row.P, Row.H, Row.Tipo, Row.Zoccoli, Row.Rivestimento, Row.Tipo_Rivestimento, Row.Data_Consegna, Row.HT, Row.DT, Row.BM, Row.Magazzino, Row.Diagonali, Row.Stampato, Row.Produzione, Row.Evaso, Row.Data_Ordine)
                        LOG.Write("Elimina Ordine - Eliminata riga " & Row.Id & " dell'ordine " & Row.Ordine)
                    Next

                    OrdiniTable.Update(DS.Ordini)
                    MsgBox("Ordine eliminato!")

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
        End If

        FillAll()
        DGW_Ordine.Rows.Clear()
        Carica_OrdiniAperti()

    End Sub

    '### PRODUZIONE ###
    Private Sub Bt_Open_ListaDiagonali_Click(sender As Object, e As EventArgs) Handles Bt_Open_ListaDiagonali.Click
        LST_Diagonali.Show()
        LST_Diagonali.CB_OrdiniAperti.SelectedItem = OrdineAperto
        LST_Diagonali.Bt_Ok_ORDINE.PerformClick()
    End Sub
    Private Sub Bt_Open_ListaMorali_Click(sender As Object, e As EventArgs) Handles Bt_Open_ListaMorali.Click
        LST_Morali.Show()
        LST_Morali.CB_OrdiniAperti.SelectedItem = OrdineAperto
        LST_Morali.Bt_Ok.PerformClick()
    End Sub
    Private Sub Bt_Send_Rivestimenti_Click(sender As Object, e As EventArgs) Handles Bt_Send_Rivestimenti.Click

        If MsgBox("Inviare alla sezionatrice il file rivestimenti dell'ordine " & OrdineAperto & "?", MsgBoxStyle.YesNo, "Rivestimenti") = MsgBoxResult.Yes Then

            If My.Settings.RivestimentiXML = True Then

                'Invio tramite xml
                Rivestimenti.CreaRivestimenti(DS.Ordini.Where(Function(X) X.Ordine = DGW_OrdiniAperti.CurrentRow.Cells(0).Value).ToList)

            Else

                If My.Settings.RivestimentiSettimana = True Then
                    Rivestimenti.InviaPerSettimana(OrdineAperto)
                Else
                    Rivestimenti.Invia(OrdineAperto)
                End If

            End If

        End If

    End Sub

    '### GESTIONE ###
    Private Sub Bt_Evaso_Click(sender As Object, e As EventArgs) Handles Bt_Evaso.Click


        Dim DGWRow As DataGridViewRow = DGW_Ordine.CurrentRow
        Dim RigaDaEvadere As ModPackDBDataSet.OrdiniRow = DS.Ordini.Where(Function(X) X.Id = DGWRow.Cells(0).Value).First

        Try

            If RigaDaEvadere.Evaso = False Then
                RigaDaEvadere.Evaso = True
                OrdiniTable.Update(RigaDaEvadere)
                DGWRow.Cells("Stato").Value = My.Resources.Status_Done
                DGWRow.DefaultCellStyle.ForeColor = Color.Silver
            Else
                If MsgBox(RigaDaEvadere.Imballo & " - ORD. " & RigaDaEvadere.Ordine & " Risulta già EVASO!" & vbCrLf & "Vuoi segnarlo come NON EVASO?", vbYesNo, "Evaso") = MsgBoxResult.Yes Then
                    RigaDaEvadere.Evaso = False
                    OrdiniTable.Update(RigaDaEvadere)
                    DGWRow.Cells("Stato").Value = New Bitmap(24, 24)
                    DGWRow.DefaultCellStyle.ForeColor = Color.Black
                End If
            End If

        Catch ex As Exception
            MsgBox("Errore durante l'aggiornamento della riga nel DB" & vbCrLf & ex.Message, vbCritical, "Errore")
        End Try

        Dim StringaDaCopiare As String = ""

        Try

            StringaDaCopiare = "D " & RigaDaEvadere.Codice & " C " & RigaDaEvadere.Commessa
            If My.Settings.NumeroOrdineClipboard = True Then StringaDaCopiare += " (" & RigaDaEvadere.Ordine & "[" & RigaDaEvadere.Riga & "]" & ")"

            If StringaDaCopiare.Length > 60 Then
                StringaDaCopiare.Remove(55)
                StringaDaCopiare += ".."
            End If

            Clipboard.SetText(StringaDaCopiare)

        Catch ex As Exception
            MsgBox("Errore durante la copia della stringa da incollare sul DDT" & vbCrLf & ex.Message, vbCritical, "Errore")
        End Try



    End Sub
    Private Sub Bt_InProduzione_Click(sender As Object, e As EventArgs) Handles Bt_InProduzione.Click
        Try

            Dim DGWRow As DataGridViewRow = DGW_Ordine.CurrentRow
            Dim RigaDaProduzione As ModPackDBDataSet.OrdiniRow = DS.Ordini.Where(Function(X) X.Id = DGWRow.Cells(0).Value).First

            If Not RigaDaProduzione.Evaso = True Then

                If RigaDaProduzione.Produzione = False Then
                    RigaDaProduzione.Produzione = True
                    OrdiniTable.Update(RigaDaProduzione)
                    DGWRow.Cells("Stato").Value = My.Resources.Status_Working
                Else
                    If MsgBox(RigaDaProduzione.Imballo & " - ORD. " & RigaDaProduzione.Ordine & " Risulta già IN PRODUZIONE!" & vbCrLf & "Vuoi segnarlo come NON IN PRODUZIONE?", vbYesNo, "Evaso") = MsgBoxResult.Yes Then
                        RigaDaProduzione.Produzione = False
                        OrdiniTable.Update(RigaDaProduzione)
                        DGWRow.Cells("Stato").Value = New Bitmap(24, 24)
                    End If
                End If

            Else
                MsgBox(RigaDaProduzione.Imballo & " risulta EVASO!" & vbCrLf & "Non è possibile segnarlo IN PRODUZIONE", vbInformation, "In produzione")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    '### STAMPE ###
    Private Sub Ck_AnteprimaStampa_CheckedChanged(sender As Object, e As EventArgs) Handles Ck_AnteprimaStampa.CheckedChanged
        My.Settings.New_AnteprimeStampa = Ck_AnteprimaStampa.Checked
        My.Settings.Save()
    End Sub
    Private Sub DGW_Ordine_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGW_Ordine.CellDoubleClick

        If DGW_Ordine.Rows.GetRowCount(DataGridViewElementStates.Selected) = 1 Then

            ListaDaStampare.Clear()
            ListaDaStampare.Add(DS.Ordini.Where(Function(X) X.Id = DGW_Ordine.CurrentRow.Cells("Id").Value).First)

            If ListaDaStampare.Count > 0 Then
                Distinta.Stampa(ListaDaStampare, True)
            End If

        End If

    End Sub

    'Stampa ordine intero

    Private Sub Bt_Bindelli_Click(sender As Object, e As EventArgs) Handles Bt_Bindelli.Click

        Dim ORDINE As String = DGW_OrdiniAperti.CurrentRow.Cells(0).Value

        If MsgBox("Stampare i bindelli dell'ordine " & ORDINE & "?", vbYesNo, "Stampa") = MsgBoxResult.Yes Then
            Bindelli.Stampa(DS.Ordini.Where(Function(X) X.Ordine = ORDINE).ToList, Ck_AnteprimaStampa.Checked)
        End If
    End Sub
    Private Sub Bt_Disegni_Click(sender As Object, e As EventArgs) Handles Bt_Disegni.Click
        Dim ORDINE As String = DGW_OrdiniAperti.CurrentRow.Cells(0).Value

        If MsgBox("Stampare i disegni dell'ordine " & ORDINE & "?", vbYesNo, "Stampa") = MsgBoxResult.Yes Then

            Dim ListaStampare As New List(Of ModPackDBDataSet.OrdiniRow)
            ListaDaStampare = DS.Ordini.Where(Function(X) X.Ordine = ORDINE).ToList
            Distinta.Stampa(ListaDaStampare, Ck_AnteprimaStampa.Checked)

            For Each Row As ModPackDBDataSet.OrdiniRow In ListaDaStampare
                'Segna come stampato
                SQL.Query("UPDATE Ordini SET Stampato = 'True' WHERE ID = '" & Row.Id & "'")
            Next

        End If
    End Sub
    Private Sub Bt_CheckList_Click(sender As Object, e As EventArgs) Handles Bt_CheckList.Click
        Dim ORDINE As String = DGW_OrdiniAperti.CurrentRow.Cells(0).Value

        If MsgBox("Stampare la checklist dell'ordine " & ORDINE & "?", vbYesNo, "Stampa") = MsgBoxResult.Yes Then
            CheckList.Stampa(ORDINE, Ck_AnteprimaStampa.Checked)
        End If
    End Sub
    Private Sub Bt_ConfermaOrdine_Click(sender As Object, e As EventArgs) Handles Bt_ConfermaOrdine.Click
        Dim ORDINE As String = DGW_OrdiniAperti.CurrentRow.Cells(0).Value

        ' ######### STAMPA CONFERMA ORDINE ############
        If My.Settings.CO_Stampa = True Then
            If MsgBox("Stampare la CO dell'ordine " & ORDINE & "?", vbYesNo, "Stampa") = MsgBoxResult.Yes Then
                ConfermaOrdine.Stampa(ORDINE, Ck_AnteprimaStampa.Checked)
            End If
        End If


        ' ########### GENERA E INVIA CONFERMA ORDINE ( sistemare ) #############

        'Crea il dataset con i dati necessari
        Dim ConfermaOrdineDS As New DataSet
            ConfermaOrdineDS.Clear()

            Dim Query As String = "SELECT Ordini.Riga, Ordini.Imballo, Ordini.Qt, Imballi.Tipo, Imballi.L, Imballi.P, Imballi.H, Ordini.indice, Imballi.m3, Imballi.Tipo_Rivestimento, Imballi.Prezzo, Ordini.Data_Consegna, Ordini.Codice, Ordini.Commessa, imballi.m2, Ordini.Ordine, Ordini.HT  FROM Ordini LEFT JOIN Imballi ON Ordini.Imballo = Imballi.Imballo WHERE Ordine = '" & ORDINE & "'"
        Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)
            Try
                Con.Open()
                Dim adapter As New System.Data.SqlClient.SqlDataAdapter(Query, Con)
                adapter.Fill(ConfermaOrdineDS)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using


        If My.Settings.CO_Invia = True Then     'GENERO FILE CO PER INVIO VIA MAIL (CARTELLA TEMP)

            Dim filesalvato As String = ""
            Dim ListaAllegati As New List(Of String)
            Module_GeneraFileCO.Genera_Temp(ConfermaOrdineDS, ORDINE, filesalvato)
            ListaAllegati.Add(filesalvato)
            Mail.Invia("Invio CO " & ORDINE & " - (" & System.Environment.UserName & ")", "Questo messaggio viene generato automaticamente, si prega di non rispondere a questo indirizzo" & vbCrLf & vbCrLf & "Per informazioni scrivere a imballaggi@bicciatoserafino.com", ListaAllegati, False)

        End If

        If My.Settings.CO_Genera = True Then    'GENERO FILE CO PER AUTOMAZIONE

            Dim FileSalvato As String = ""
            Module_GeneraFileCO.Genera_File(ConfermaOrdineDS, ORDINE, FileSalvato)

        End If


    End Sub

    'Stampa solo selezionati

    Private Sub Bt_Search_Click(sender As Object, e As EventArgs) Handles Bt_Search.Click

        DGW_Ordine.Rows.Clear()
        DGW_OrdiniAperti.ClearSelection()


        Dim ListaOrdine As New List(Of ModPackDBDataSet.OrdiniRow)

        If RB_Search_Evasi.Checked = True Then
            ListaOrdine = DS.Ordini.Where(Function(X) X.Ordine.Contains(Tx_Cerca_Ordine.Text.ToUpper)).Where(Function(y) y.Codice.Contains(Tx_Cerca_Disegno.Text.ToUpper)).Where(Function(z) z.Commessa.Contains(Tx_Cerca_Commessa.Text.ToUpper)).Where(Function(r) r.Imballo.Contains(Tx_Cerca_Imballo.Text.ToUpper)).Where(Function(q) q.Evaso = True).ToList
        End If

        If Rb_Search_NonEvasi.Checked = True Then
            ListaOrdine = DS.Ordini.Where(Function(X) X.Ordine.Contains(Tx_Cerca_Ordine.Text.ToUpper)).Where(Function(y) y.Codice.Contains(Tx_Cerca_Disegno.Text.ToUpper)).Where(Function(z) z.Commessa.Contains(Tx_Cerca_Commessa.Text.ToUpper)).Where(Function(r) r.Imballo.Contains(Tx_Cerca_Imballo.Text.ToUpper)).Where(Function(q) q.Evaso = False).ToList
        End If

        If RB_Search_Tutti.Checked = True Then
            ListaOrdine = DS.Ordini.Where(Function(X) X.Ordine.Contains(Tx_Cerca_Ordine.Text.ToUpper)).Where(Function(y) y.Codice.Contains(Tx_Cerca_Disegno.Text.ToUpper)).Where(Function(z) z.Commessa.Contains(Tx_Cerca_Commessa.Text.ToUpper)).Where(Function(r) r.Imballo.Contains(Tx_Cerca_Imballo.Text.ToUpper)).ToList
        End If


        For Each Row As ModPackDBDataSet.OrdiniRow In ListaOrdine

            Dim IMGStato As Image = New Bitmap(24, 24)

            If Row.Stampato = False Then IMGStato = My.Resources.Status_Wait
            If Row.Evaso = True Then IMGStato = My.Resources.Status_Done

            Dim Week As Integer = DatePart(DateInterval.WeekOfYear, Row.Data_Consegna, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFourDays)
            DGW_Ordine.Rows.Add({Row.Id, Row.Ordine, Row.Riga, Row.Imballo, Row.Qt, Row.Tipo, Row.Codice, Row.Commessa, Row.HT, Week, IMGStato})

        Next

        DGW_Ordine.Columns(1).Visible = True

    End Sub
    Private Sub Bt_Search_Chiudi_Click(sender As Object, e As EventArgs) Handles Bt_Search_Chiudi.Click
        SplitContainer1.Panel1Collapsed = True
    End Sub

    Private Sub RivToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RivToolStripMenuItem.Click
        Dim Ordine As String = DGW_OrdiniAperti.CurrentRow.Cells("Ordine").Value
        Sezionatrice.RivCreaTemp(Ordine)
    End Sub


    Private Sub COPIARIFORDINEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COPIARIFORDINEToolStripMenuItem.Click

        Try

            Dim Ordine As String = DGW_OrdiniAperti.CurrentRow.Cells(0).Value

            If DS.RiferOrdini.Where(Function(X) X.NumeroCO = Ordine).Any Then

                Dim RigaRiferimento As ModPackDBDataSet.RiferOrdiniRow = DS.RiferOrdini.Where(Function(X) X.NumeroCO = Ordine).FirstOrDefault

                Dim Stringa As String = "Rif. Vs. Ordine " & RigaRiferimento.Ordine & " del " & RigaRiferimento.DataOrdine.ToShortDateString
                Clipboard.SetText(Stringa)

            Else
                Clipboard.Clear()

            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub BT_CaricaSett_Click(sender As Object, e As EventArgs) Handles BT_CaricaSett.Click
        Carica_Settimana(CB_ScegliSett.Text)
    End Sub

    Private Sub Tx_Cerca_Ordine_KeyDown(sender As Object, e As KeyEventArgs) Handles Tx_Cerca_Ordine.KeyDown, Tx_Cerca_Disegno.KeyDown, Tx_Cerca_Imballo.KeyDown, Tx_Cerca_Ordine.KeyDown
        If e.KeyCode = Keys.Enter Then
            Bt_Search_Click(sender, e)
        End If
    End Sub

End Class