Imports System.ComponentModel

Public Class Form_Imballi

    Dim Row As New RigaOrdine
    Dim DSNote As New ModPackDBDataSet.NoteImballiDataTable


    Private Sub Rinfresh()
        Bt_MostraNuovi.Text = "Imballi Nuovi (" & Ordine.ListaNuovi.Count & ")"

        Me.IndiciTableAdapter.Fill(Me.ModPackDBDataSet.Indici)
        Me.DistintaTableAdapter.Fill(Me.ModPackDBDataSet.Distinta)
        Me.ImballiTableAdapter.Fill(Me.ModPackDBDataSet.Imballi)
        Me.NoteImballiTableAdapter.Fill(Me.ModPackDBDataSet.NoteImballi)

        'Carica solo le ultime N righe da imballi
        If Not ModPackDBDataSet.Imballi.Count = 0 Then
            Dim IndiceMax As Integer = ModPackDBDataSet.Imballi.Compute("MAX(Id)", "")
            If Not My.Settings.ImballiNRecords = 0 Then
                ImballiBindingSource.Filter = "Id > '" & IndiceMax - My.Settings.ImballiNRecords & "'"
            Else
                ImballiBindingSource.Filter = Nothing
            End If
        End If

        FiltraColonne()

    End Sub

    Private Sub Form_Imballi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Rinfresh()
    End Sub

    Private Sub Bt_Modifica_Click(sender As Object, e As EventArgs) Handles Bt_Modifica.Click
        Form_ModificaImballo.Show()
        Form_ModificaImballo.CbImballo.Text = DgwImballi.CurrentRow.Cells(1).Value
        Form_ModificaImballo.CaricaCodiceNoEdit()
    End Sub

    Private Sub Bt_Refresh_Click(sender As Object, e As EventArgs) Handles Bt_Refresh.Click
        Rinfresh()
    End Sub

    Private Sub Bt_FiltroNome_Click(sender As Object, e As EventArgs) Handles Bt_FiltroNome.Click
        Dim Nome As String = InputBox("Ricerca imballo:", "Cerca per nome", "")
        If Not String.IsNullOrEmpty(Nome) Then
            ImballiBindingSource.Filter = "Imballo LIKE '" & Nome & "'"
        End If
    End Sub

    Private Sub Bt_PulisciNuovi_Click(sender As Object, e As EventArgs) Handles Bt_PulisciNuovi.Click
        If MsgBox("Sei sicuro di voler pulire la lista dei nuovi imballi?", vbYesNo, "Pulisci lista nuovi") = MsgBoxResult.Yes Then
            Ordine.ListaNuovi.Clear()
            MsgBox("Pulizia effettuata!", vbInformation, "Pulisci lista nuovi")
            LOG.Write("Lista nuovi codici pulita")
            Rinfresh()
        End If

    End Sub

    Private Sub Bt_MostraNuovi_Click(sender As Object, e As EventArgs) Handles Bt_MostraNuovi.Click
        Ordine.MostraNuovi()
    End Sub

    Private Sub Bt_StampaImballo_Click(sender As Object, e As EventArgs) Handles Bt_StampaImballo.Click
        If Not DgwImballi.SelectedCells.Count = 0 Then


            Dim Imballo As String = ""
            Dim L As Integer
            Dim P As Integer
            Dim H As Integer
            Dim Tipo As String
            Dim Zoccoli As String = ""
            Dim Rivestimento As Boolean
            Dim TipoRivestimento As String = ""
            Dim HT As Boolean
            Dim DT As Boolean
            Dim BM As Boolean
            Dim Diagonali As Boolean
            Dim Note As String = ""
            Dim Rivest_Tot As String = ""
            Dim Indice As Integer
            Dim Codice As String = ""

            'Carico le variabili in una falsa riga di ordine
            Using TableImballi As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
                Using TableIndex As New ModPackDBDataSetTableAdapters.IndiciTableAdapter

                    Using DS As New ModPackDBDataSet

                        TableImballi.Fill(DS.Imballi)
                        TableIndex.Fill(DS.Indici)

                        Dim RigaImballo() As DataRow = DS.Imballi.Select("Id = '" & DgwImballi.CurrentRow.Cells(0).Value & "'")

                        Imballo = RigaImballo(0)(1)
                        L = RigaImballo(0)(2)
                        P = RigaImballo(0)(3)
                        H = RigaImballo(0)(4)
                        Tipo = RigaImballo(0)(5)
                        Zoccoli = RigaImballo(0)(6)
                        Rivestimento = RigaImballo(0)(7)
                        TipoRivestimento = RigaImballo(0)(8)
                        HT = RigaImballo(0)(9)
                        DT = RigaImballo(0)(10)
                        BM = RigaImballo(0)(11)
                        Diagonali = RigaImballo(0)(12)

                        If Not DgwIndici.RowCount = 0 Then
                            Dim RigaIndice() As DataRow = DS.Indici.Select("Indice = '" & DgwIndici.CurrentRow.Cells(2).Value & "'")

                            Indice = RigaIndice(0)(2)
                            Note = RigaIndice(0)(4)
                            Rivest_Tot = RigaIndice(0)(5)
                            Codice = RigaIndice(0)(3)
                        End If

                    End Using
                End Using
            End Using

            With Row
                .NumeroOrdine = ""
                .Riga = 0
                .Imballo = Imballo
                .Indice = Indice
                .Qt = 0
                .Cliente = ""
                .Codice = Codice
                .Commessa = ""
                .L = L
                .P = P
                .H = H
                .Tipo = Tipo
                .Zoccoli = Zoccoli
                .Rivestimento = Rivestimento
                .TipoRivestimento = TipoRivestimento
                .Note = Note
                .DataConsegna = Nothing
                .HT = HT
                .BM = BM
                .DT = DT
                .Rivest_Tot = Rivest_Tot
                .Magazzino = ""
                .Diagonali = Diagonali
                .Data_Ordine = Date.Now.Date
                .Evaso = False
                .Produzione = False
                .Stampato = False
            End With

            PrintImballo.DefaultPageSettings = My.Settings.FormatoStampa

            Dim Preview As New PrintPreviewDialog With {.Document = PrintImballo, .StartPosition = FormStartPosition.CenterScreen, .TopMost = True, .WindowState = FormWindowState.Maximized}
            Preview.ShowDialog()
        End If
    End Sub

    Private Sub PrintImballo_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintImballo.PrintPage
        Stampe.Stampa_Distinte(sender, e, Row)
    End Sub

    Private Sub Bt_Filtro_Click(sender As Object, e As EventArgs) Handles Bt_Filtro.Click
        Dim Filtro As String = ""
        If Form_Imballi_Filtro.ShowDialog = DialogResult.OK Then
            Filtro = Form_Imballi_Filtro.Filtro

            '  ImballiBindingSource.Filter = Nothing
            If Not String.IsNullOrEmpty(Filtro) Then
                ImballiBindingSource.Filter = Filtro
            End If
        End If
    End Sub

    Private Sub FiltraColonne()

        Dim Filtro As String = My.Settings.FiltroColonneImballi

        If Filtro.Length = 21 Then
            For K = 0 To 20
                If Filtro(K) = "0" Then
                    DgwImballi.Columns(K).Visible = False
                Else
                    DgwImballi.Columns(K).Visible = True
                End If
            Next
        End If


    End Sub

    Private Sub Bt_Colonne_Click(sender As Object, e As EventArgs) Handles Bt_Colonne.Click
        If Form_Imballi_Colonne.ShowDialog = DialogResult.OK Then
            FiltraColonne()
            'Rinfresh()
        End If
    End Sub

    Private Sub DgwImballi_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgwImballi.CellDoubleClick
        Bt_StampaImballo_Click(sender, e)
        'Bt_Modifica_Click(sender, e)
    End Sub

    Private Sub Bt_Simili_Click(sender As Object, e As EventArgs) Handles Bt_Simili.Click
        If Not DgwImballi.SelectedCells.Count = 0 Then
            Dim Filtro As String = ""

            With DgwImballi.CurrentRow
                Filtro = "L = '" & .Cells("LDataGridViewTextBoxColumn").Value & "'"
                Filtro += " AND " & "P = '" & .Cells("PDataGridViewTextBoxColumn").Value & "'"
                Filtro += " AND " & "H = '" & .Cells("HDataGridViewTextBoxColumn").Value & "'"
            End With

            If Not String.IsNullOrEmpty(Filtro) Then
                ImballiBindingSource.Filter = Filtro
            End If
        End If
    End Sub

    Private Sub ImballiBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ImballiBindingSource.CurrentChanged
        Lbl_Conteggio.Text = ImballiBindingSource.Count.ToString
    End Sub

    Private Sub Bt_Note_Click(sender As Object, e As EventArgs) Handles Bt_Note.Click
        If DgwImballi.SelectedRows.Count > 0 Then
            Frm_NoteImballo.Tx_Imballo.Text = DgwImballi.CurrentRow.Cells("ImballoDataGridViewTextBoxColumn").Value
            If Frm_NoteImballo.ShowDialog = DialogResult.OK Then
                Me.NoteImballiTableAdapter.Fill(Me.ModPackDBDataSet.NoteImballi)
            End If
        End If

    End Sub

    Private Sub Bt_MostraDistinta_Click(sender As Object, e As EventArgs) Handles Bt_MostraDistinta.Click
        SplitSopra.Panel2Collapsed = Not SplitSopra.Panel2Collapsed
        DgwDistinta.Columns(0).Visible = False
        DgwDistinta.Columns(1).Visible = False

    End Sub
    Private Sub Bt_MostraInfo_Click(sender As Object, e As EventArgs) Handles Bt_MostraInfo.Click
        SplitIntero.Panel2Collapsed = Not SplitIntero.Panel2Collapsed
        SplitSotto.SplitterDistance = SplitSotto.Width / 2
        DGW_Note.Columns(0).Visible = False
        DGW_Note.Columns(1).Visible = False
        DgwIndici.Columns(0).Visible = False
        DgwIndici.Columns(1).Visible = False
    End Sub

    Private Sub Bt_NoteSave_Click(sender As Object, e As EventArgs) Handles Bt_NoteSave.Click
        If MsgBox("Salvare le modifiche apportate alle note?", MsgBoxStyle.YesNo, "Elimina") = MsgBoxResult.Yes Then
            Try
                Me.NoteImballiTableAdapter.Update(Me.ModPackDBDataSet.NoteImballi)
            Catch ex As Exception
                Errore.Show("Modifica nota imballo", ex.Message)
            End Try
        End If
    End Sub

    Private Sub Bt_NoteRemove_Click(sender As Object, e As EventArgs) Handles Bt_NoteRemove.Click
        If MsgBox("Eliminare nota selezionata?", MsgBoxStyle.YesNo, "Elimina") = MsgBoxResult.Yes Then
            Try

                Dim ID As Integer = DGW_Note.CurrentRow.Cells(0).Value
                Dim Imballo As String = DGW_Note.CurrentRow.Cells(1).Value
                Dim Nota As String = DGW_Note.CurrentRow.Cells(2).Value

                If Not Nota.Contains("'") Then
                    SQL.Query("DELETE FROM NoteImballi WHERE ID = '" & ID & "' AND Imballo = '" & Imballo & "' AND Nota = '" & Nota & "'")
                    Me.NoteImballiTableAdapter.Update(Me.ModPackDBDataSet.NoteImballi)
                    Me.NoteImballiTableAdapter.Fill(Me.ModPackDBDataSet.NoteImballi)
                Else
                    MsgBox("È necessario rimuovere il carattere ' dalla stringa per proseguire con l'eliminazione")
                End If

            Catch ex As Exception
                Errore.Show("Elimina nota imballo", ex.Message)
            End Try
        End If
    End Sub

    Private Sub Bt_Note_Add_Click(sender As Object, e As EventArgs) Handles Bt_Note_Add.Click
        Bt_Note_Click(sender, e)
    End Sub


    Private Sub DgwImballi_SelectionChanged(sender As Object, e As EventArgs) Handles DgwImballi.SelectionChanged
        If DgwImballi.SelectedRows.Count > 0 Then
            If My.Settings.NoteDinamico = True Then
                Dim FontG As New Font(Bt_Note.Font, FontStyle.Bold)
                Dim Font As New Font(Bt_Note.Font, FontStyle.Regular)
                Dim I As Integer = 0

                Bt_Note.Font = Font
                Bt_Note.Text = "Note"

                For Each row As ModPackDBDataSet.NoteImballiRow In ModPackDBDataSet.NoteImballi
                    If row.Imballo = DgwImballi.CurrentRow.Cells("ImballoDataGridViewTextBoxColumn").Value Then
                        I += 1
                    End If
                Next

                If I > 0 Then
                    Bt_Note.Font = FontG
                    Bt_Note.Text = "Note (" & I & ")"
                End If
            End If
            LBL_Descrizione.Text = Descrizione(DgwImballi.CurrentRow)
        End If

    End Sub

    'LBL DESCRIZIONE
    Private Function Descrizione(ByVal Riga As DataGridViewRow) As String
        With Riga

            Dim Desc As String = "CM " & .Cells(2).Value & " x " & .Cells(3).Value
            If Not .Cells(4).Value = 0 Then Desc += " x " & .Cells(4).Value
            Desc += " " & .Cells(5).Value
            Desc += " " & .Cells(6).Value
            If Not String.IsNullOrEmpty(.Cells(8).Value) Then Desc += " (" & .Cells(8).Value & " - M2 " & .Cells(16).Value & ")"
            Desc += " M3 " & .Cells(17).Value

            Return Desc
        End With
    End Function
    Private Sub LBL_Descrizione_MouseDown(sender As Object, e As MouseEventArgs) Handles LBL_Descrizione.MouseDown
        If e.Button = MouseButtons.Right Then
            CM_Copia.Show(MousePosition)
        End If
    End Sub
    Private Sub CopiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiaToolStripMenuItem.Click
        Clipboard.SetText(LBL_Descrizione.Text)
        LBL_Descrizione.Text = "Descrizione copiata!"
    End Sub
    Private Sub CopiaToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles LBL_Descrizione.MouseLeave
        If DgwImballi.SelectedRows.Count > 0 Then
            LBL_Descrizione.Text = Descrizione(DgwImballi.CurrentRow)
        End If
    End Sub

    'Context menu imballo


    Private Sub Bt_CM_Modifica_Click(sender As Object, e As EventArgs) Handles Bt_CM_Modifica.Click
        Bt_Modifica_Click(sender, e)
    End Sub
    Private Sub Bt_CM_ImbSimili_Click(sender As Object, e As EventArgs) Handles Bt_CM_ImbSimili.Click
        Bt_Simili_Click(sender, e)
    End Sub
    Private Sub Bt_CM_Stampa_Click(sender As Object, e As EventArgs) Handles Bt_CM_Stampa.Click
        Bt_StampaImballo_Click(sender, e)
    End Sub
    Private Sub Bt_CM_AggNota_Click(sender As Object, e As EventArgs) Handles Bt_CM_AggNota.Click
        Bt_Note_Click(sender, e)
    End Sub
    Private Sub Bt_Cm_MostraDistinta_Click(sender As Object, e As EventArgs) Handles Bt_Cm_MostraDistinta.Click
        Bt_MostraDistinta_Click(sender, e)
    End Sub
    Private Sub Bt_Cm_MostraIndici_Click(sender As Object, e As EventArgs) Handles Bt_Cm_MostraIndici.Click
        Bt_MostraInfo_Click(sender, e)
    End Sub

    Private Sub DgwImballi_MouseDown(sender As Object, e As MouseEventArgs) Handles DgwImballi.MouseDown
        If e.Button = MouseButtons.Right Then
            If Not DgwImballi.SelectedRows.Count = 0 Then
                Cm_Imballo.Show(MousePosition)
            End If
        End If
    End Sub


End Class



