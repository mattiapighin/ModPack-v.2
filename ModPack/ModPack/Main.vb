﻿Imports System.ComponentModel
Imports System.Xml

Public Class Main

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '                                                                        '
    '       ███╗   ███╗ ██████╗ █████╗  ██████╗  █████╗  ██████╗██╗  ██╗     '
    '       ████╗ ████║██╔═══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝██║ ██╔╝     '
    '       ██╔████╔██║██║   ██║██║  ██║██████╔╝███████║██║     █████╔╝      ' 
    '       ██║╚██╔╝██║██║   ██║██║  ██║██╔═══╝ ██╔══██║██║     ██╔═██╗      '
    '       ██║ ╚═╝ ██║╚██████╔╝█████╔╝ ██║     ██║  ██║╚██████╗██║  ██╗     '
    '       ╚═╝     ╚═╝ ╚═════╝ ╚════╝  ╚═╝     ╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝     '
    '                                                                        '
    '                       © 2017 - Mattia Pighin                           '
    '                                                                        ' 
    '                             *Disclaimer*                               '
    '   When I wrote this code, only God and I understood what I was doing   '
    '                         Now, God only knows                            '
    '                                                                        '   
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Dim ListaMemo As New List(Of Memo)
    Dim RowOrdine As New List(Of RigaOrdine)
    Dim RowIndici As New List(Of Integer)

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OperazioniPreliminari()
        CaricaOrdiniAperti()

        'DEVELOPER
        TSBT_Dev.Visible = My.Settings.Developer

    End Sub
    Private Sub Main_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        LOG.Write("Fine sessione")
        LOG.Clean()
    End Sub
    Private Sub OperazioniPreliminari()
        Try

            Mostra_Nascondi_Testo()

            If My.Settings.Utente = "Nuovo Utente" Then
                'Quando nuova installazione oppure se si vuole resettare le impostazioni
                Dim Utente As String = ""
                Utente = InputBox("Inserire nome utente", "Nuovo Utente", System.Environment.UserName)
                If Not String.IsNullOrEmpty(Utente) Then My.Settings.Utente = Utente

                If MsgBox("Azzerare formato stampa?", vbYesNo, "Nuovo Utente") = MsgBoxResult.Yes Then
                    With My.Settings
                        .Stampa_MargineTop = 5 '18.9
                        .Stampa_MargineRight = 15 '37.8
                        .Stampa_MargineLeft = 5 '18.9
                        .Stampa_MargineBottom = 15 '37.8
                        .Stampa_Color = False
                        .Stampa_LandScape = False
                    End With
                End If


                With My.Settings
                    .LogType = "normal"
                    .NumeroRigheDistinta = 15
                    .DimensioneFontDistinta = 12
                    .Developer = False
                    .Etichette_DimensioneX = 110
                    .Etichette_DimensioneY = 69
                    .Etichette_MargineBottom = 5
                    .Etichette_MargineLeft = 5
                    .Etichette_MargineRight = 5
                    .Etichette_MargineTop = 5
                End With

                My.Settings.Save()
                If MsgBox("Impostare subito le preferenze?", vbYesNo, "Preferenze") = MsgBoxResult.Yes Then Form_Preferenze.ShowDialog()
            End If

            If Not My.Computer.FileSystem.DirectoryExists(My.Settings.Root & "\Disegni") Then My.Computer.FileSystem.CreateDirectory(My.Settings.Root & "\Disegni")

            If Not My.Computer.FileSystem.FileExists(My.Settings.FileLogPath) Then
                IO.File.Create(My.Settings.FileLogPath)
            End If

            If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
                With System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion
                    Me.Text = "Modpack [ " & System.Environment.UserName & " ] - " & "V" & .Major & "." & .Minor & "." & .Build & "." & .Revision
                End With
            End If


            XML.CreaXML()
            LOG.Write("Inizio sessione")
            CaricaMemo()
            SQL.PuliziaOrdini() 'Se attivo elimina tutti gli ordini prima di una certa data (default false)

            My.Settings.Scarto = SQL.GetPrezzoMateriale("SCART") 'salva in memoria la percentuale di scarto in modo da non dover fare la query ogni volta
            My.Settings.Save()

        Catch ex As Exception
            Errore.Show("Operazioni Preliminari \ Main", ex.Message)
        End Try

    End Sub
    Private Sub Mostra_Nascondi_Testo()
        If My.Settings.TestoIconeMain = False Then
            TS_Ordini.DisplayStyle = ToolStripItemDisplayStyle.Image
            TS_Imballi.DisplayStyle = ToolStripItemDisplayStyle.Image
            TS_Tools.DisplayStyle = ToolStripItemDisplayStyle.Image
            TS_Tabelle.DisplayStyle = ToolStripItemDisplayStyle.Image
            TS_Memo.DisplayStyle = ToolStripItemDisplayStyle.Image
            Ts_Preferenze.DisplayStyle = ToolStripItemDisplayStyle.Image
        Else
            TS_Ordini.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            TS_Imballi.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            TS_Tools.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            TS_Tabelle.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            TS_Memo.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            Ts_Preferenze.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        End If
    End Sub

    '### CALENDARIO E MEMO ###
    Private Sub Calendario_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Calendario.DateChanged
        MostraMemo()
    End Sub
    Private Sub DGW_Memo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGW_Memo.CellContentClick
        DGW_Memo.ClearSelection()
    End Sub
    Public Sub CaricaMemo()
        Try
            Using MemoTable As New ModPackDBDataSetTableAdapters.MemoTableAdapter
                Using MemoDT As New ModPackDBDataSet.MemoDataTable
                    MemoTable.Fill(MemoDT)

                    ListaMemo.Clear()

                    For Each Row As ModPackDBDataSet.MemoRow In MemoDT.Rows
                        Dim Riga As New Memo
                        If Not Row.IsDataNull Then Riga.Data = Row.Data
                        If Not Row.IsMemoNull Then Riga.Memo = Row.Memo
                        If Not Row.IsImballoNull Then Riga.Imballo = Row.Imballo
                        ListaMemo.Add(Riga)
                    Next

                End Using
            End Using

        Catch ex As Exception
            Errore.Show("CaricaMemo \ Main", ex.Message)
        End Try

        MostraMemo()


    End Sub
    Private Sub MostraMemo()
        Try
            DGW_Memo.Rows.Clear()
            For Each Row As Memo In (From Riga In ListaMemo Where Riga.Data = Calendario.SelectionStart)
                DGW_Memo.Rows.Add(Row.Memo)
            Next

        Catch ex As Exception
            Errore.Show("MostraMemo \ Main", ex.Message)
        End Try
    End Sub

    '### DRAG & DROP ###
    Private Sub Main_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                e.Effect = DragDropEffects.All
            End If

        Catch ex As Exception
            Errore.Show("Drag&Drop \ Main", ex.Message)
        End Try
    End Sub
    Private Sub Main_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Try
            Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
            For Each FileOrdine In files
                If MsgBox("Caricare ordine '" & IO.Path.GetFileNameWithoutExtension(FileOrdine) & "' ?", vbYesNo, "Carica ordine") = MsgBoxResult.Yes Then
                    ProgressBar.Visible = True
                    Ordine.CaricaOrdine(FileOrdine, ProgressBar, ToolStrip, Notify)
                    ToolStrip.Text = ""
                    ProgressBar.Visible = False
                End If
            Next


        Catch ex As Exception
            Errore.Show("Drag&Drop \ Main", ex.Message)
        End Try
    End Sub

    '### TOOLSTRIP ###

    '   // Ordine \\
    Private Sub CARICA_ORDINE_Click(sender As Object, e As EventArgs) Handles TS_CaricaOrdine.Click
        ToolStrip.Text = "Selezione file ordine"
        ProgressBar.Visible = True
        'Ordine.CaricaOrdine(ProgressBar, ToolStrip, Notify)
        Ordine.CaricaFileOrdine(ProgressBar, ToolStrip, Notify)
        ToolStrip.Text = ""
        ProgressBar.Visible = False
    End Sub
    Private Sub ORDINI_APERTI(sender As Object, e As EventArgs) Handles TS_OrdiniAperti.Click
        FRM_OrdiniApertiV2.Show()
    End Sub
    Private Sub STORICO_ORDINI_Click(sender As Object, e As EventArgs) Handles TS_StoricoOrdini.Click
        Form_StoricoOrdini.Show()
    End Sub
    Private Sub ASSOCIA_CO_ORDINE_Click(sender As Object, e As EventArgs) Handles ASSOCIACOORDINEToolStripMenuItem.Click
        FRM_Associa.ShowDialog()
    End Sub

    '   // Imballi \\
    Private Sub ARCHIVIO_Click(sender As Object, e As EventArgs) Handles TS_Archivio.Click
        'Form_Imballi.Show()
        FRM_Archivio_V2.Show()
    End Sub
    Private Sub INIZIO_PRODUZIONE_Click(sender As Object, e As EventArgs) Handles INIZIOPRODUZIONEToolStripMenuItem.Click
        DLG_InProduzione.ShowDialog()
    End Sub
    Private Sub CREAZIONE_MANUALE_Click(sender As Object, e As EventArgs) Handles MANUALEToolStripMenuItem.Click
        Form_Crea_Manuale.ShowDialog()
    End Sub
    Private Sub CREAZIONE_AUTOMATICA_Click(sender As Object, e As EventArgs) Handles CREAZIONEAUTOMATICAToolStripMenuItem.Click
        FRM_NuovoImballoPlus.ShowDialog()
    End Sub
    Private Sub LISTA_NUOVI_Click(sender As Object, e As EventArgs) Handles LISTAIMBALLINUOVIToolStripMenuItem.Click
        Ordine.MostraNuovi()
    End Sub

    '   // Tools \\
    Private Sub CONTROLLO_ORDINE_Click(sender As Object, e As EventArgs) Handles TS_ControlloOrdine.Click
        Form_ControlloOrdineInput.Show()
    End Sub
    Private Sub MODIFICA_ORDINE_Click(sender As Object, e As EventArgs) Handles MODIFICAORDINEToolStripMenuItem.Click
        DLG_ModificaOrdine.ShowDialog()
    End Sub
    Private Sub LISTINO_Click(sender As Object, e As EventArgs) Handles TS_Listino.Click
        Form_Listino.Show()
    End Sub
    Private Sub MODIFICA_CODICE_Click(sender As Object, e As EventArgs) Handles MODIFICACODICEToolStripMenuItem.Click
        Form_ModificaCodice.ShowDialog()
    End Sub
    Private Sub LISTA_DIAGONALI_Click(sender As Object, e As EventArgs) Handles TS_ListaDiagonali.Click
        LST_Diagonali.ShowDialog()
    End Sub
    Private Sub LISTA_MORALI_Click(sender As Object, e As EventArgs) Handles TS_ListaMorali.Click
        LST_Morali.ShowDialog()
    End Sub
    '   // Tabelle \\
    Private Sub TABELLE_Click(sender As Object, e As EventArgs) Handles TS_Tabelle.Click
        Form_Tabelle.Show()
    End Sub
    '   // Memo
    Private Sub MEMO_Click(sender As Object, e As EventArgs) Handles TS_Memo.Click
        Form_Memo.Show()
    End Sub
    '   // Stampe \\
    Private Sub STAMPA_BINDELLO_Click(sender As Object, e As EventArgs) Handles STAMPABINDELLOToolStripMenuItem.Click
        FRM_StampaBindello.Show()
    End Sub
    Private Sub STAMPA_CONFERMA_ORDINE_Click(sender As Object, e As EventArgs) Handles STAMPACOToolStripMenuItem.Click
        If DLG_ScegliOrdine.ShowDialog = DialogResult.OK Then
            ConfermaOrdine.Stampa(DLG_ScegliOrdine.OrdineScelto, True)
        End If
    End Sub
    '   // Preferenze \\
    Private Sub PREFERENZE_Click(sender As Object, e As EventArgs) Handles Ts_Preferenze.Click
        Form_Preferenze.ShowDialog()
    End Sub

    '### TREEVIEW ###

    Dim DSxTREE As New ModPackDBDataSet
    Dim OrdiniTabxTree As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter

    Private Sub BT_RefreshTree_Click(sender As Object, e As EventArgs) Handles BT_RefreshTree.Click
        CaricaOrdiniAperti()
    End Sub
    Private Sub CaricaOrdiniAperti()
        OrdiniTree.Nodes.Clear()
        Try
            Using Table As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
                Using DS As New ModPackDBDataSet.OrdiniDataTable
                    Table.Fill(DS)
                    'Estrapola tutti gli ordini presenti in archivio

                    'Metodo1 
                    'Dim Ordini = From row In DS.AsEnumerable() Select row.Field(Of String)("Ordine") Distinct
                    'Metodo2
                    Dim Ordini2 = DS.Where(Function(X) X.Evaso = False).Select(Function(X) X.Ordine).ToArray.Distinct

                    Dim I As Integer = 0

                    For Each Ordine As String In Ordini2

                        Dim Evaso = True
                        'Dim row() As DataRow = DS.Select("Ordine = '" & Ordine & "'")
                        Dim row() As DataRow = DS.Where(Function(X) X.Ordine = Ordine).ToArray


                        For K = 0 To row.Length - 1
                            'Se in tutto l'ordine c'è almeno un imballo inevaso prosegue
                            If row(K)(26) = False Then Evaso = False
                        Next

                        If Evaso = False Then
                            'Se esiste un imballo inevaso carica il nodo Ordine
                            OrdiniTree.Nodes.Add("(" & row(0)(27) & ") - " & Ordine)

                            For K = 0 To row.Length - 1
                                'E poi carica gli imballi inevasi
                                If row(K)(26) = False Then
                                    'OrdiniTree.Nodes(I).Nodes.Add(row(K)(3) & "  (" & row(K)(5) & ")" & "  (" & row(K)(7) & ")  (" & row(K)(8) & ")")
                                    Dim Nodo As New TreeNode With {.Name = row(K)(0), .Text = row(K)(3) & "  (" & row(K)(5) & ")" & "  (" & row(K)(7) & ")  (" & row(K)(8) & ")", .ForeColor = Color.Black}
                                    OrdiniTree.Nodes(I).Nodes.Add(Nodo)
                                    'OrdiniTree.Nodes(I).Nodes(K).ForeColor = Color.Black

                                    If row(K)(24) = False Then
                                        'Se non è stampato icona "new"
                                        OrdiniTree.Nodes(I).Nodes(K).ForeColor = Color.SaddleBrown
                                        OrdiniTree.Nodes(I).Nodes(K).ImageIndex = 4
                                        OrdiniTree.Nodes(I).Nodes(K).SelectedImageIndex = 4
                                    Else
                                        'Se è stampato icona "attesa"
                                        OrdiniTree.Nodes(I).Nodes(K).ForeColor = Color.Blue
                                        OrdiniTree.Nodes(I).Nodes(K).ImageIndex = 1
                                        OrdiniTree.Nodes(I).Nodes(K).SelectedImageIndex = 1
                                    End If

                                    If row(K)(25) = True Then
                                        'Se è in produzione icona "lavoro"
                                        OrdiniTree.Nodes(I).Nodes(K).ForeColor = Color.Black
                                        OrdiniTree.Nodes(I).Nodes(K).ImageIndex = 2
                                        OrdiniTree.Nodes(I).Nodes(K).SelectedImageIndex = 2
                                    End If

                                Else
                                    Dim Nodo As New TreeNode With {.Name = row(K)(0), .Text = row(K)(3) & "  (" & row(K)(5) & ")" & "  (" & row(K)(7) & ")  (" & row(K)(8) & ")", .ForeColor = Color.Green}
                                    OrdiniTree.Nodes(I).Nodes.Add(Nodo)
                                    'Se è evaso icona check
                                    OrdiniTree.Nodes(I).Nodes(K).ImageIndex = 3
                                    OrdiniTree.Nodes(I).Nodes(K).SelectedImageIndex = 3
                                End If
                            Next
                            I += 1
                        End If

                    Next
                End Using
            End Using

            ToolTip.SetToolTip(BT_RefreshTree, "Ultimo aggiornamento: " & Date.Now.ToShortTimeString)

        Catch ex As Exception
            Errore.Show("CaricaOrdiniAperti \ Main", ex.Message)
        End Try

    End Sub
    Private Sub OrdiniTree_KeyDown(sender As Object, e As KeyEventArgs) Handles OrdiniTree.KeyDown
        If e.Control And e.KeyCode = Keys.C Then
            Clipboard.SetText(OrdiniTree.SelectedNode.Text)
        End If
    End Sub
    Private Sub Print_Distinta_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Print_Distinta.PrintPage
        Stampe.Stampa_Distinte(sender, e, RowOrdine.Item(0))
    End Sub
    Private Sub OrdiniTree_DoubleClick(sender As Object, e As EventArgs) Handles OrdiniTree.DoubleClick

        If Not OrdiniTree.SelectedNode Is Nothing Then
            If Not String.IsNullOrEmpty(OrdiniTree.SelectedNode.Name) Then


                OrdiniTabxTree.Fill(DSxTREE.Ordini)

                Dim ListaDaStampare As New List(Of ModPackDBDataSet.OrdiniRow)
                ListaDaStampare.Add(DSxTREE.Ordini.Where(Function(X) X.Id = OrdiniTree.SelectedNode.Name).First)

                If ListaDaStampare.Count > 0 Then
                    Distinta.Stampa(ListaDaStampare, True)
                End If


            End If
        End If



    End Sub

    Private Sub GDAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GDAToolStripMenuItem.Click
        DEV.Modifica_GDA_24102018()
    End Sub
End Class
