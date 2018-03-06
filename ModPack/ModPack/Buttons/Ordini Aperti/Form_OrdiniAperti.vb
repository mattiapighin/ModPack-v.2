Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Net.Mail


Public Class Form_OrdiniAperti

    Dim ConfermaOrdineDS As New DataSet
    Dim EtichetteDS As New DataSet
    Dim CheckListDS As New DataSet

    Dim Ordine As String
    Dim RowOrdine As New List(Of RigaOrdine)

    Dim OrdiniTable As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
    Dim DS As New ModPackDBDataSet


    Private Sub BloccaButtons()
        Bt_Etichette.Enabled = False
        Bt_ConfermaOrdine.Enabled = False
        Bt_Disegni.Enabled = False
        Bt_CheckList.Enabled = False
        Bt_ListaRivestimenti.Enabled = False
        Bt_QrCodes.Enabled = False
        Bt_Evaso.Enabled = False
        Bt_InProduzione.Enabled = False
    End Sub
    Private Sub SbloccaButtons()
        Bt_Etichette.Enabled = True
        Bt_ConfermaOrdine.Enabled = True
        Bt_Disegni.Enabled = True
        Bt_CheckList.Enabled = True
        Bt_ListaRivestimenti.Enabled = True
        Bt_QrCodes.Enabled = True
        Bt_Evaso.Enabled = True
        Bt_InProduzione.Enabled = True
    End Sub

    '### Qui avvengono le operazioni più importanti ###
    'Sono mostrati tutti gli ordini aperti, e selezionandoli è possibile stampare
    'I disegni, etichette, conferma d'ordine, liste varie ecc

    '### Per eseguire operazioni sulle righe selezionate ###
    'For Each Riga As DataGridViewRow In Dgw_Ordine.SelectedRows
    '        MsgBox(Riga.Cells("Imballo").Value)
    'Next

    Private Sub SSwrite(text As String)
        TX_Ss.Text = text

    End Sub
    Private Sub Form_OrdiniAperti_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ts1 As New TimeSpan(Now.Ticks)
        CaricaListaOrdiniAperti()
        'CaricaTuttiNonEvasi() rimosso perchè ora più performante
        BloccaButtons()
        Dim ts2 As New TimeSpan(Now.Ticks)

        Analysis.AddValue(1, (ts2 - ts1).TotalSeconds.ToString)
        Analysis.AddValue(2, SQL.GetSQLValue("SELECT COUNT(*) FROM Ordini"))

    End Sub
    Private Sub DGW_OrdiniAperti_Click(sender As Object, e As EventArgs) Handles DGW_OrdiniAperti.Click

        If DGW_OrdiniAperti.SelectedRows.Count > 0 Then
                CaricaOrdineSelezionato(DGW_OrdiniAperti.SelectedCells.Item(0).Value)
                Lbl_Ordine.Text = DGW_OrdiniAperti.SelectedCells.Item(0).Value
                Ordine = (DGW_OrdiniAperti.SelectedCells.Item(0).Value)
            End If

    End Sub

    Private Sub Dgw_Ordine_Sorted(sender As Object, e As EventArgs) Handles Dgw_Ordine.Sorted
        If My.Settings.OrdiniAperti_ColoraEvasi = True Then ColoraEvasi()
        If My.Settings.OrdiniAperti_ColoraScaduti = True Then ColoraDateConsegna()
        If My.Settings.OrdiniAperti_ColoraProduzione = True Then ColoraProduzione()
    End Sub
    Private Sub CaricaListaOrdiniAperti()

        DGW_OrdiniAperti.DataSource = Nothing
        'Riempie la tabella OrdiniAperti con i numeri d'ordine di ordini con ancora righe non evase
        Dim DS As New DataSet
        Dim Query As String = "SELECT DISTINCT Ordine FROM Ordini WHERE Evaso = 'False'"
        Using Con As New SqlConnection(My.Settings.ModPackDBConnectionString)

            Try
                Con.Open()
                Dim adapter As New SqlDataAdapter(Query, Con)
                adapter.Fill(DS)    '
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using

        DGW_OrdiniAperti.DataSource = DS.Tables(0)

    End Sub
    Private Sub CaricaOrdineSelezionato(ByVal Ordine As String)
        'Riempie la DGW Ordine con le righe non evase dell'ordine selezionato nella DGW ordini aperti
        Dgw_Ordine.DataSource = Nothing
        Dim DS As New DataSet
        Dim Query As String

        'Query senza in produzione
        'Query = "SELECT Ordini.Id, Ordini.Riga, Ordini.Imballo, Ordini.Tipo, Ordini.Qt, Ordini.Cliente, Ordini.Codice, Ordini.Commessa, Ordini.L, Ordini.P, Ordini.H, Ordini.indice, Ordini.Data_Consegna AS Consegna, Imballi.Prezzo, (Imballi.Prezzo * Ordini.Qt) AS Totale, Ordini.Stampato, Ordini.Evaso, Ordini.Data_Ordine AS 'Data Ordine' FROM Ordini LEFT JOIN Imballi ON Ordini.Imballo = Imballi.Imballo WHERE Ordine = '" & Ordine & "'"
        'Query con in produzione
        Query = "SELECT Ordini.Id, Ordini.Riga, Ordini.Imballo, Ordini.Tipo, Ordini.Qt, Ordini.Cliente, Ordini.Codice, Ordini.Commessa, Ordini.L, Ordini.P, Ordini.H, Ordini.indice, Ordini.Data_Consegna AS Consegna, Imballi.Prezzo, (Imballi.Prezzo * Ordini.Qt) AS Totale, Ordini.Stampato, Ordini.Produzione AS 'In Produzione', Ordini.Evaso, Ordini.Data_Ordine AS 'Data Ordine' FROM Ordini LEFT JOIN Imballi ON Ordini.Imballo = Imballi.Imballo WHERE Ordine = '" & Ordine & "'"

        Using Con As New SqlConnection(My.Settings.ModPackDBConnectionString)
            Try
                Con.Open()
                Dim adapter As New SqlDataAdapter(Query, Con)
                adapter.Fill(DS)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using

        Dgw_Ordine.DataSource = DS.Tables(0)

        ColoraProduzione()
        ColoraDateConsegna()
        ColoraEvasi()

        Dgw_Ordine.Columns(0).Visible = False
        SbloccaButtons()
    End Sub
    Private Sub CaricaTuttiNonEvasi()
        'Ignora la tabella OrdiniAperti e carica tutte le righe non evase
        Dgw_Ordine.DataSource = Nothing

        Dim DS As New DataSet
        Dim Query As String = "SELECT Ordini.Id, Ordini.Ordine, Ordini.Riga, Ordini.Imballo, Ordini.Qt, Ordini.Cliente, Ordini.Codice, Ordini.Commessa, Ordini.L, Ordini.P, Ordini.H, Ordini.indice, Ordini.Data_Consegna AS Consegna, Imballi.Prezzo, (Imballi.Prezzo * Ordini.Qt) AS Totale, Ordini.Stampato, Ordini.Evaso, Ordini.Data_Ordine AS 'Data Ordine' FROM Ordini LEFT JOIN Imballi ON Ordini.Imballo = Imballi.Imballo WHERE Evaso = 'False'"
        Using Con As New SqlConnection(My.Settings.ModPackDBConnectionString)

            Try

                Con.Open()

                Dim adapter As New SqlDataAdapter(Query, Con)
                adapter.Fill(DS)


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using

        Dgw_Ordine.DataSource = DS.Tables(0)  'Assegna alla DGW la tabella creata
        DGW_OrdiniAperti.Columns(0).Width = DGW_OrdiniAperti.Width - 3

        ColoraDateConsegna()
        Dgw_Ordine.Columns("Id").Visible = False
        DGW_OrdiniAperti.ClearSelection()
        Lbl_Ordine.Text = "ORDINI APERTI"

        BloccaButtons()
    End Sub
    Private Sub ColoraDateConsegna()
        If My.Settings.OrdiniAperti_ColoraScaduti = True Then
            For Each Row As DataGridViewRow In Dgw_Ordine.Rows
                Select Case Row.Cells("Consegna").Value
                    Case < Date.Today.Date
                        Row.DefaultCellStyle.ForeColor = Color.Red
                    Case = Date.Today.Date
                        Row.DefaultCellStyle.ForeColor = Color.Blue
                End Select
            Next
        End If
    End Sub
    Private Sub ColoraEvasi()
        If My.Settings.OrdiniAperti_ColoraEvasi = True Then
            For Each Row As DataGridViewRow In Dgw_Ordine.Rows
                Select Case Row.Cells("Evaso").Value
                    Case True
                        Row.DefaultCellStyle.ForeColor = Color.LightGray
                End Select
            Next
        End If
    End Sub
    Private Sub ColoraProduzione()
        If My.Settings.OrdiniAperti_ColoraProduzione = True Then
            For Each Row As DataGridViewRow In Dgw_Ordine.Rows
                Select Case Row.Cells("In Produzione").Value
                    Case True
                        Row.DefaultCellStyle.ForeColor = Color.SandyBrown
                End Select
            Next
        End If
    End Sub


    Private Function CopiaDescrizione(row As DataGridViewRow) As String
        Dim Descrizione As String = "D " & row.Cells(6).Value & " C " & row.Cells(7).Value
        If DGW_OrdiniAperti.SelectedCells.Count > 0 Then
            If My.Settings.NumeroOrdineClipboard = True Then Descrizione += " (Ordine: " & DGW_OrdiniAperti.CurrentCell.Value & ")"
        End If

        SSwrite(Descrizione & " evaso!")

        If Descrizione.Length > 60 Then
            Descrizione = Descrizione.Remove(58)
            Descrizione += ".."
        End If

        Return Descrizione
    End Function
    Private Sub Bt_InProduzione_Click(sender As Object, e As EventArgs) Handles Bt_InProduzione.Click
        If Not (Control.ModifierKeys = Keys.Control) Then
            For Each Row As DataGridViewRow In Dgw_Ordine.SelectedRows
                SQL.Query("UPDATE Ordini SET Produzione = 'True' WHERE Id = " & Row.Cells("Id").Value)
                LOG.Write("Imballo " & Row.Cells("Imballo").Value & "in produzione")
                Row.Cells("In Produzione").Value = True
            Next
        Else
            For Each Row As DataGridViewRow In Dgw_Ordine.SelectedRows
                SQL.Query("UPDATE Ordini SET Produzione = 'False' WHERE Id = " & Row.Cells("Id").Value)
                LOG.Write("Imballo " & Row.Cells("Imballo").Value & " non più in produzione")
                Row.Cells("In Produzione").Value = False
            Next
        End If
        ColoraProduzione()
    End Sub
    Private Sub Bt_Evaso_Click(sender As Object, e As EventArgs) Handles Bt_Evaso.Click
        If Not (Control.ModifierKeys = Keys.Control) Then
            For Each Row As DataGridViewRow In Dgw_Ordine.SelectedRows
                If My.Settings.CK_ConfermaEvaso = True Then
                    If MsgBox("Contrassegnare " & Row.Cells("Imballo").Value & "come evaso?", vbYesNo, "Segna come evaso") = MsgBoxResult.Yes Then
                        SQL.Query("UPDATE Ordini SET Evaso = 'True' WHERE Id = " & Row.Cells("Id").Value)
                        LOG.Write("Evaso imballo " & Row.Cells("Imballo").Value)
                        Row.Cells("Evaso").Value = True
                        Clipboard.SetText(CopiaDescrizione(Row))
                    End If
                Else
                    SQL.Query("UPDATE Ordini SET Evaso = 'True' WHERE Id = " & Row.Cells("Id").Value)
                    LOG.Write("Evaso imballo " & Row.Cells("Imballo").Value)
                    Row.Cells("Evaso").Value = True
                    Clipboard.SetText(CopiaDescrizione(Row))
                End If
            Next
        Else
            For Each Row As DataGridViewRow In Dgw_Ordine.SelectedRows
                SQL.Query("UPDATE Ordini SET Evaso = 'False' WHERE Id = " & Row.Cells("Id").Value)
                LOG.Write("Non più evaso imballo " & Row.Cells("Imballo").Value)
                Row.Cells("Evaso").Value = False
                Clipboard.SetText(CopiaDescrizione(Row))
            Next
        End If
        ColoraEvasi()
    End Sub
    Private Sub Bt_SeeAll_Click(sender As Object, e As EventArgs) Handles Bt_SeeAll.Click
        CaricaTuttiNonEvasi()
    End Sub

    Private Sub Bt_ConfermaOrdine_Click(sender As Object, e As EventArgs) Handles Bt_ConfermaOrdine.Click

        If Not DGW_OrdiniAperti.SelectedRows.Count = 0 Then

            Ordine = InputBox("Ordine:", "Stampa conferma d'ordine", DGW_OrdiniAperti.CurrentRow.Cells(0).Value)

            If ModPack.Ordine.OrdineEXIST(Ordine) = False Then
                MsgBox("L'ordine inserito non esiste", vbInformation, "Stampa conferma d'ordine")
                Exit Sub
            End If

            'Genero Dataset
            ConfermaOrdineDS.Clear()

            Dim Query As String = "SELECT Ordini.Riga, Ordini.Imballo, Ordini.Qt, Imballi.Tipo, Imballi.L, Imballi.P, Imballi.H, Ordini.indice, Imballi.m3, Imballi.Tipo_Rivestimento, Imballi.Prezzo, Ordini.Data_Consegna, Ordini.Codice, Ordini.Commessa, imballi.m2, Ordini.Ordine  FROM Ordini LEFT JOIN Imballi ON Ordini.Imballo = Imballi.Imballo WHERE Ordine = '" & Ordine & "'"
            Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)

                Try
                    Con.Open()
                    Dim adapter As New System.Data.SqlClient.SqlDataAdapter(Query, Con)
                    adapter.Fill(ConfermaOrdineDS)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            End Using


            If My.Settings.CO_Genera = True Then    'GENERO FILE CO PER AUTOMAZIONE

                Dim FileSalvato As String = ""
                Module_GeneraFileCO.Genera_File(ConfermaOrdineDS, Ordine, FileSalvato)

            End If

            If My.Settings.CO_Invia = True Then     'GENERO FILE CO PER INVIO VIA MAIL (CARTELLA TEMP)

                Dim filesalvato As String = ""
                Dim ListaAllegati As New List(Of String)
                Module_GeneraFileCO.Genera_Temp(ConfermaOrdineDS, Ordine, filesalvato)
                ListaAllegati.Add(filesalvato)
                Mail.Invia("Invio CO " & Ordine & " - (" & System.Environment.UserName & ")", "Questo messaggio viene generato automaticamente, si prega di non rispondere a questo indirizzo" & vbCrLf & vbCrLf & "Per informazioni scrivere a imballaggi@bicciatoserafino.com", ListaAllegati, False)

            End If

            '---------STAMPA DELLA CONFERMA D'ORDINE-----------
            If My.Settings.CO_Stampa = True Then

                Clipboard.SetText(Ordine)

                Dim DialogStampa As New PrintDialog
                If DialogStampa.ShowDialog = DialogResult.OK Then

                    'Ordine = DGW_OrdiniAperti.CurrentRow.Cells(0).Value

                    LOG.Write("Stampata conferma ordine " & Ordine)
                    Print_ConfermaOrdine.PrinterSettings = DialogStampa.PrinterSettings
                    Print_ConfermaOrdine.DocumentName = "CO" & Ordine
                    Stampe.Set_Settings(Print_ConfermaOrdine, True)
                    Print_ConfermaOrdine.Print()
                    SSwrite("Conferma d'ordine stampata " & Ordine)

                End If

            End If


        Else
                MsgBox("Selezionare prima un'ordine nella lista di sinistra", vbInformation, "Attenzione")
        End If

    End Sub
    Private Sub Bt_Etichette_Click(sender As Object, e As EventArgs) Handles Bt_Etichette.Click
        If Not DGW_OrdiniAperti.SelectedRows.Count = 0 Then

            'Salva nome dell'ordine per stamparlo su etichetta
            Ordine = DGW_OrdiniAperti.CurrentRow.Cells(0).Value

            ' ### SETTA STAMPANTE ###
            'Carica da my.settings tutti i settaggi per la stampante delle etichette
            Print_Etichette.PrinterSettings.PrinterName = My.Settings.Etichette_Stampante
            Dim psz As New Printing.PaperSize With {.RawKind = Printing.PaperKind.Custom, .Width = (My.Settings.Etichette_DimensioneX / 0.254), .Height = (My.Settings.Etichette_DimensioneY / 0.254)}
            Print_Etichette.DefaultPageSettings.PaperSize = psz

            With Print_Etichette.DefaultPageSettings.Margins
                .Top = (My.Settings.Etichette_MargineTop / 0.254)
                .Bottom = (My.Settings.Etichette_MargineBottom / 0.254)
                .Left = (My.Settings.Etichette_MargineLeft / 0.254)
                .Right = (My.Settings.Etichette_MargineRight / 0.254)
            End With
            ' ##############################

            If Not (Control.ModifierKeys = Keys.Control) Then
                'se è premuto CTRL stampa solo l'etichetta selezionata, altrimenti tutto l'ordine

                If MsgBox("Stampare etichette per l'ordine " & Ordine & "?", vbYesNo, "Etichette") = DialogResult.Yes Then

                    EtichetteDS.Clear()
                    Dim Query As String = "SELECT Magazzino, Cliente, Codice, Commessa, Imballo, Qt, Ordine FROM Ordini WHERE Ordine = '" & Ordine & "'"
                    Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)
                        'Riempie Dataset con i dati necessari
                        Try
                            Con.Open()
                            Dim adapter As New System.Data.SqlClient.SqlDataAdapter(Query, Con)
                            adapter.Fill(EtichetteDS)
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    End Using

                    LOG.Write("Stampata etichette " & Ordine)
                    Print_Etichette.DocumentName = "ET" & Ordine
                    'Print_Etichette.Print()

                    Dim Preveiw As New PrintPreviewDialog With {.Document = Print_Etichette}
                    Preveiw.ShowDialog()

                End If
            Else
                If Dgw_Ordine.SelectedRows.Count > 0 Then

                    Try

                        If MsgBox("Stampare etichetta per " & Dgw_Ordine.CurrentRow.Cells("Imballo").Value & "?", vbYesNo, "Etichette") = DialogResult.Yes Then

                            EtichetteDS.Clear()

                            Dim Query As String = "SELECT Magazzino, Cliente, Codice, Commessa, Imballo, Qt, Ordine FROM Ordini WHERE Id = '" & Dgw_Ordine.CurrentRow.Cells("Id").Value & "'"
                            Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)

                                Try
                                    Con.Open()
                                    Dim adapter As New System.Data.SqlClient.SqlDataAdapter(Query, Con)
                                    adapter.Fill(EtichetteDS)
                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                            End Using

                            LOG.Write("Stampata etichette " & Ordine)
                            Print_Etichette.DocumentName = "ET" & Ordine

                            Dim Preveiw As New PrintPreviewDialog With {.Document = Print_Etichette}
                            Preveiw.ShowDialog()
                            'Print_Etichette.Print()



                        End If

                    Catch ex As Exception

                    End Try
                End If
            End If
                Else
            MsgBox("Selezionare prima un'ordine nella lista di sinistra", vbInformation, "Attenzione")

        End If

    End Sub
    Private Sub Bt_CheckList_Click(sender As Object, e As EventArgs) Handles Bt_CheckList.Click
        If Not DGW_OrdiniAperti.SelectedRows.Count = 0 Then

            Dim DialogStampa As New PrintDialog

            If DialogStampa.ShowDialog = DialogResult.OK Then

                Ordine = DGW_OrdiniAperti.CurrentRow.Cells(0).Value
                CheckListDS.Clear()

                Dim Query As String = ""


                If MsgBox("Vuoi stampare anche gli imballi evasi?", MsgBoxStyle.YesNo, "Checklist") = MsgBoxResult.Yes Then
                    Query = "SELECT Ordini.Riga, Ordini.Imballo, Ordini.Qt, Ordini.Tipo, Ordini.L, Ordini.P, Ordini.H, Ordini.indice, Ordini.Evaso, Ordini.Codice, Ordini.Commessa FROM Ordini LEFT JOIN Imballi ON Ordini.Imballo = Imballi.Imballo WHERE Ordine = '" & Ordine & "'"
                Else
                    Query = "SELECT Ordini.Riga, Ordini.Imballo, Ordini.Qt, Ordini.Tipo, Ordini.L, Ordini.P, Ordini.H, Ordini.indice, Ordini.Evaso, Ordini.Codice, Ordini.Commessa FROM Ordini LEFT JOIN Imballi ON Ordini.Imballo = Imballi.Imballo WHERE Ordine = '" & Ordine & "' AND Ordini.Evaso = 'False'"
                End If


                Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)

                        Try
                            Con.Open()
                            Dim adapter As New System.Data.SqlClient.SqlDataAdapter(Query, Con)
                            adapter.Fill(CheckListDS)
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try

                    End Using


                    LOG.Write("Stampata checklist ordine " & Ordine)

                Print_CheckList.PrinterSettings = DialogStampa.PrinterSettings

                Print_CheckList.DocumentName = "CKL" & Ordine

                Stampe.Set_Settings(Print_CheckList, False)

                Print_CheckList.Print()
                End If
            Else
            MsgBox("Selezionare prima un'ordine nella lista di sinistra", vbInformation, "Attenzione")
        End If

    End Sub

    Private Sub Bt_Disegni_Click(sender As Object, e As EventArgs) Handles Bt_Disegni.Click

        Dim ListaMagazzini As New List(Of Magazzino)
        ListaMagazzini = SQL.GetMagazzini

        RowOrdine.Clear()
        Ordine = DGW_OrdiniAperti.CurrentRow.Cells(0).Value

        Using OrdineTable As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
            Using Ds As New ModPackDBDataSet.OrdiniDataTable

                OrdineTable.Fill(Ds)

                If Not My.Computer.Keyboard.CtrlKeyDown Then

                    'Se non è premuto CTRL stampa tutto l'ordine
                    For Each Row As ModPackDBDataSet.OrdiniRow In Ds.Rows
                        If Row.Ordine = Ordine Then
                            Dim Riga As New RigaOrdine With {.NumeroOrdine = Row.Ordine, .Riga = Row.Riga, .Imballo = Row.Imballo, .Indice = Row.Indice, .Qt = Row.Qt, .Cliente = Row.Cliente, .Codice = Row.Codice, .Commessa = Row.Commessa,
                                .L = Row.L, .P = Row.P, .H = Row.H, .Tipo = Row.Tipo, .Zoccoli = Row.Zoccoli, .Rivestimento = Row.Rivestimento, .TipoRivestimento = Row.Tipo_Rivestimento, .Note = Row.Note, .DataConsegna = Row.Data_Consegna,
                                .HT = Row.HT, .DT = Row.DT, .BM = Row.BM, .Rivest_Tot = Row.Rivest_Tot, .Magazzino = ModMagazzino.GetDescrizione(Row.Magazzino, ListaMagazzini), .Diagonali = Row.Diagonali, .Data_Ordine = Row.Data_Ordine, .Evaso = False, .Produzione = False, .Stampato = False, .ID_RigaOrdine = Row.Id}
                            RowOrdine.Add(Riga)
                            Row.Stampato = True
                        End If
                    Next
                Else

                    'Se è premuto CTRL stampa solo le righe selezionate
                    For Each Row As ModPackDBDataSet.OrdiniRow In Ds.Rows
                        For Each RigaSelezionata As DataGridViewRow In Dgw_Ordine.SelectedRows
                            If Row.Ordine = Ordine And Row.Id = RigaSelezionata.Cells(0).Value Then
                                Dim Riga As New RigaOrdine With {.NumeroOrdine = Row.Ordine, .Riga = Row.Riga, .Imballo = Row.Imballo, .Indice = Row.Indice, .Qt = Row.Qt, .Cliente = Row.Cliente, .Codice = Row.Codice, .Commessa = Row.Commessa,
                                    .L = Row.L, .P = Row.P, .H = Row.H, .Tipo = Row.Tipo, .Zoccoli = Row.Zoccoli, .Rivestimento = Row.Rivestimento, .TipoRivestimento = Row.Tipo_Rivestimento, .Note = Row.Note, .DataConsegna = Row.Data_Consegna,
                                    .HT = Row.HT, .DT = Row.DT, .BM = Row.BM, .Rivest_Tot = Row.Rivest_Tot, .Magazzino = ModMagazzino.GetDescrizione(Row.Magazzino, ListaMagazzini), .Diagonali = Row.Diagonali, .Data_Ordine = Row.Data_Ordine, .Evaso = False, .Produzione = False, .Stampato = False, .ID_RigaOrdine = Row.Id}
                                RowOrdine.Add(Riga)
                                Row.Stampato = True
                            End If
                        Next
                    Next

                End If

                If Not RowOrdine.Count = 0 Then
                    OrdineTable.Update(Ds)
                    Stampe.Set_Settings(Print_Distinte)
                    Dim L As New PrintPreviewDialog With {.Document = Print_Distinte, .TopMost = False, .WindowState = FormWindowState.Normal}
                    L.Show()
                End If

            End Using
        End Using
        CaricaOrdineSelezionato(Ordine)
    End Sub
    Private Sub Bt_ListaRivestimenti_Click(sender As Object, e As EventArgs) Handles Bt_ListaRivestimenti.Click
        If MsgBox("Inviare il file Rivestimenti alla sezionatrice?", vbYesNo, "Rivestimenti") = MsgBoxResult.Yes Then
            Rivestimenti.Invia(DGW_OrdiniAperti.CurrentCell.Value)
        End If
    End Sub

    '### STAMPE ###

    Private Sub Print_ConfermaOrdine_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Print_ConfermaOrdine.PrintPage
        Stampe.ConfermaDOrdine(sender, e, Ordine, ConfermaOrdineDS)
    End Sub
    Private Sub Print_Etichette_PrintPage(sender As Object, e As PrintPageEventArgs) Handles Print_Etichette.PrintPage
        Try

            Dim ListaMagazzini As New List(Of Magazzino)
            ListaMagazzini = SQL.GetMagazzini
            Static EtichetteStampate = 0
            Dim EtichetteTotali As Integer = EtichetteDS.Tables(0).Rows.Count - 1

            'MsgBox("ETICHETTE STAMPATE: " & EtichetteStampate & " ETICHETTE TOTALI: " & EtichetteTotali)

            With EtichetteDS.Tables(0).Rows(EtichetteStampate)
                Stampe.Etichetta(sender, e, ModMagazzino.GetDescrizione(.Item(0), ListaMagazzini), .Item(1), .Item(2), .Item(3), .Item(4), .Item(5), .Item(6))
            End With

            EtichetteStampate += 1

            If EtichetteStampate <= EtichetteTotali Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
                EtichetteStampate = 0
            End If

        Catch ex As Exception
            Errore.Show("Print etichette", ex.Message)
        End Try
    End Sub
    Private Sub Print_CheckList_PrintPage(sender As Object, e As PrintPageEventArgs) Handles Print_CheckList.PrintPage
        Stampe.CheckList(sender, e, Ordine, CheckListDS)
    End Sub
    Private Sub Print_Distinte_PrintPage(sender As Object, e As PrintPageEventArgs) Handles Print_Distinte.PrintPage

        Try
            Static PagineStampate = 0
            Dim DistinteTotali As Integer = RowOrdine.Count - 1

            Stampe.Stampa_Distinte(sender, e, RowOrdine.Item(PagineStampate))

            PagineStampate += 1

            If PagineStampate <= DistinteTotali Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
                PagineStampate = 0
            End If
        Catch ex As Exception
            Errore.Show("Print distinte", ex.Message)
        End Try
    End Sub

    Private Sub Print_QR_PrintPage(sender As Object, e As PrintPageEventArgs) Handles Print_QR.PrintPage
        Static QRstampati = 0
        Static EtichetteTotali As Integer = RowOrdine.Count - 1
        Stampe.EtichettaQR(sender, e, RowOrdine(QRstampati))
        QRstampati += 1

        If QRstampati <= EtichetteTotali Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            QRstampati = 0
        End If
    End Sub
    Private Sub Bt_QrCodes_Click(sender As Object, e As EventArgs) Handles Bt_QrCodes.Click
        ' ### SETTA STAMPANTE ###
        'Carica da my.settings tutti i settaggi per la stampante delle etichette
        Print_QR.PrinterSettings.PrinterName = My.Settings.Etichette_Stampante
        Dim psz As New Printing.PaperSize With {.RawKind = Printing.PaperKind.Custom, .Width = (My.Settings.Etichette_DimensioneX / 0.254), .Height = (My.Settings.Etichette_DimensioneY / 0.254)}
        Print_QR.DefaultPageSettings.PaperSize = psz

        With Print_QR.DefaultPageSettings.Margins
            .Top = (My.Settings.Etichette_MargineTop / 0.254)
            .Bottom = (My.Settings.Etichette_MargineBottom / 0.254)
            .Left = (My.Settings.Etichette_MargineLeft / 0.254)
            .Right = (My.Settings.Etichette_MargineRight / 0.254)
        End With
        ' ##############################

        RowOrdine.Clear()
        Ordine = DGW_OrdiniAperti.CurrentRow.Cells(0).Value

        Using OrdineTable As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
            Using Ds As New ModPackDBDataSet.OrdiniDataTable

                OrdineTable.Fill(Ds)

                If Not My.Computer.Keyboard.CtrlKeyDown Then

                    'Se non è premuto CTRL stampa tutto l'ordine
                    For Each Row As ModPackDBDataSet.OrdiniRow In Ds.Rows
                        If Row.Ordine = Ordine Then
                            Dim Riga As New RigaOrdine With {.NumeroOrdine = Row.Ordine, .Riga = Row.Riga, .Imballo = Row.Imballo, .Indice = Row.Indice, .Qt = Row.Qt, .Cliente = Row.Cliente, .Codice = Row.Codice, .Commessa = Row.Commessa,
                                .L = Row.L, .P = Row.P, .H = Row.H, .Tipo = Row.Tipo, .Zoccoli = Row.Zoccoli, .Rivestimento = Row.Rivestimento, .TipoRivestimento = Row.Tipo_Rivestimento, .Note = Row.Note, .DataConsegna = Row.Data_Consegna,
                                .HT = Row.HT, .DT = Row.DT, .BM = Row.BM, .Rivest_Tot = Row.Rivest_Tot, .Magazzino = Row.Magazzino, .Diagonali = Row.Diagonali, .Data_Ordine = Row.Data_Ordine, .Evaso = False, .Produzione = False, .Stampato = False}
                            RowOrdine.Add(Riga)
                        End If
                    Next
                Else

                    'Se è premuto CTRL stampa solo le righe selezionate
                    For Each Row As ModPackDBDataSet.OrdiniRow In Ds.Rows
                        For Each RigaSelezionata As DataGridViewRow In Dgw_Ordine.SelectedRows
                            If Row.Ordine = Ordine And Row.Id = RigaSelezionata.Cells(0).Value Then
                                Dim Riga As New RigaOrdine With {.NumeroOrdine = Row.Ordine, .Riga = Row.Riga, .Imballo = Row.Imballo, .Indice = Row.Indice, .Qt = Row.Qt, .Cliente = Row.Cliente, .Codice = Row.Codice, .Commessa = Row.Commessa,
                                    .L = Row.L, .P = Row.P, .H = Row.H, .Tipo = Row.Tipo, .Zoccoli = Row.Zoccoli, .Rivestimento = Row.Rivestimento, .TipoRivestimento = Row.Tipo_Rivestimento, .Note = Row.Note, .DataConsegna = Row.Data_Consegna,
                                    .HT = Row.HT, .DT = Row.DT, .BM = Row.BM, .Rivest_Tot = Row.Rivest_Tot, .Magazzino = Row.Magazzino, .Diagonali = Row.Diagonali, .Data_Ordine = Row.Data_Ordine, .Evaso = False, .Produzione = False, .Stampato = False}
                                RowOrdine.Add(Riga)
                            End If
                        Next
                    Next

                End If

                If Not RowOrdine.Count = 0 Then
                    Dim L As New PrintPreviewDialog With {.Document = Print_QR, .TopMost = False, .WindowState = FormWindowState.Normal}
                    L.Show()
                End If

            End Using
        End Using

    End Sub

    Private Sub Dgw_Ordine_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgw_Ordine.CellDoubleClick
        If Not DGW_OrdiniAperti.SelectedCells.Count = 0 Then

            RowOrdine.Clear()
        Ordine = DGW_OrdiniAperti.CurrentRow.Cells(0).Value

            Using OrdineTable As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
                Using Ds As New ModPackDBDataSet.OrdiniDataTable

                    OrdineTable.Fill(Ds)

                    For Each Row As ModPackDBDataSet.OrdiniRow In Ds.Rows
                        For Each RigaSelezionata As DataGridViewRow In Dgw_Ordine.SelectedRows
                            If Row.Ordine = Ordine And Row.Id = RigaSelezionata.Cells(0).Value Then
                                Dim Riga As New RigaOrdine With {.NumeroOrdine = Row.Ordine, .Riga = Row.Riga, .Imballo = Row.Imballo, .Indice = Row.Indice, .Qt = Row.Qt, .Cliente = Row.Cliente, .Codice = Row.Codice, .Commessa = Row.Commessa,
                                        .L = Row.L, .P = Row.P, .H = Row.H, .Tipo = Row.Tipo, .Zoccoli = Row.Zoccoli, .Rivestimento = Row.Rivestimento, .TipoRivestimento = Row.Tipo_Rivestimento, .Note = Row.Note, .DataConsegna = Row.Data_Consegna,
                                        .HT = Row.HT, .DT = Row.DT, .BM = Row.BM, .Rivest_Tot = Row.Rivest_Tot, .Magazzino = Row.Magazzino, .Diagonali = Row.Diagonali, .Data_Ordine = Row.Data_Ordine, .Evaso = False, .Produzione = False, .Stampato = False}
                                RowOrdine.Add(Riga)
                            End If
                        Next
                    Next


                    If Not RowOrdine.Count = 0 Then
                        OrdineTable.Update(Ds)
                        Stampe.Set_Settings(Print_Distinte)
                        Dim L As New PrintPreviewDialog With {.Document = Print_Distinte, .TopMost = True, .WindowState = FormWindowState.Normal}
                        L.Show()
                    End If

                End Using
            End Using

        End If

    End Sub

    Private Sub Dgw_Ordine_MouseEnter(sender As Object, e As EventArgs) Handles Dgw_Ordine.MouseEnter
        SSwrite("")
    End Sub


End Class