Public Class Form_Crea_Manuale

    'TODO: Controlli su inserimenti textbox solo numeri

    Dim ArrayTipi As New List(Of String)
    Dim ArrayRivestimenti As New List(Of String)

    Private Sub Sblocca()
        PANEL_EDIT.Enabled = True
        Bt_Salva.Enabled = True
        Bt_Annulla.Enabled = True
        Tx_CodiceImballo.Enabled = False
        Bt_CheckCodice.Enabled = False
    End Sub
    Private Sub Blocca()
        PANEL_EDIT.Enabled = False
        Bt_Salva.Enabled = False
        Bt_Annulla.Enabled = False
        Tx_CodiceImballo.Enabled = True
        Bt_CheckCodice.Enabled = True
    End Sub
    Private Sub Pulisci()

        Tx_CodiceImballo.Text = ""

        For Each Txt As TextBox In {Tx_L, Tx_P, Tx_H, Tx_M2, Tx_M3, Tx_SottoMF, Tx_SopraMF, Tx_SottoMT, Tx_SopraMT, Tx_PrimoMorale, Tx_DiagF, Tx_DiagT}
            Txt.Text = ""
        Next

        Cb_Tipo.SelectedIndex = 0
        Cb_Rivestimento.SelectedIndex = 0
        Rb_BaseSemplice.Checked = True
        Rb_NoZoccoli.Checked = True
        Ck_Diagonali.Checked = False
        Ck_HT.Checked = False
        Ck_Rivestimento.Checked = False

        PB_Img.BackgroundImage = Nothing

        DatePicker.Value = Date.Now.Date

    End Sub
    Private Sub Salva()

        Dim Progress As String = ""

        For Each Txt As TextBox In {Tx_L, Tx_P, Tx_H, Tx_M2, Tx_M3, Tx_SottoMF, Tx_SopraMF, Tx_SottoMT, Tx_SopraMT, Tx_PrimoMorale, Tx_DiagF, Tx_DiagT}
            If String.IsNullOrEmpty(Txt.Text) Then Txt.Text = 0
        Next

        Try

            Using Imballi As New ModPackDBDataSetTableAdapters.ImballiTableAdapter

                Dim IMG As Byte()
                If Not PB_Img.BackgroundImage Is Nothing Then IMG = Immagine.ConvertToBytes(PB_Img.BackgroundImage) Else IMG = Nothing

                Dim Zoccoli As String = ""
                If Rb_2Vie.Checked = True Then Zoccoli = "2V"
                If Rb_EUR.Checked = True Then Zoccoli = "EUR"

                Dim Rivestimento As String = ""
                If Ck_Rivestimento.Checked = True Then Rivestimento = Cb_Rivestimento.Text

                Imballi.Insert(Tx_CodiceImballo.Text, Tx_L.Text, Tx_P.Text, Tx_H.Text, Cb_Tipo.Text, Zoccoli, Ck_Rivestimento.Checked,
                       Rivestimento, Ck_HT.Checked, Rb_BaseDT.Checked, Rb_BaseMorali.Checked,
                       Ck_Diagonali.Checked, Tx_DiagF.Text, Tx_DiagT.Text, Tx_PrimoMorale.Text, Tx_M2.Text,
                       Tx_M3.Text, Nu_Prezzo.Value, IMG, DatePicker.Value, Tx_SottoMF.Text, Tx_SottoMT.Text, Tx_SopraMF.Text, Tx_SopraMT.Text)

                LOG.Write("Inserimento riga imballi ... ")
                Progress = "Inserimento riga imballi"
            End Using
            Using Indici As New ModPackDBDataSetTableAdapters.IndiciTableAdapter

                For Each Row As DataGridViewRow In DGW_Indici.Rows
                    If Not String.IsNullOrEmpty(Row.Cells(0).Value) Then
                        Indici.Insert(Tx_CodiceImballo.Text, Row.Cells(0).Value, Row.Cells(1).Value, Row.Cells(2).Value, Row.Cells(3).Value, Row.Cells(4).Value)
                        LOG.Write("Inserimento riga indici (riga " & Row.Index & " ) ... ")
                        Progress = "Inserimento riga " & Row.Index & " della tabella indici"
                    End If
                Next

            End Using
            Using Distinta As New ModPackDBDataSetTableAdapters.DistintaTableAdapter

                For Each Row As DataGridViewRow In DGW_Distinta.Rows
                    If Not String.IsNullOrEmpty(Row.Cells(0).Value) Then
                        Distinta.Insert(Tx_CodiceImballo.Text, Row.Index, Row.Cells(0).Value, Row.Cells(1).Value, Row.Cells(2).Value, Row.Cells(3).Value, Row.Cells(4).Value, Row.Cells(5).Value)
                        LOG.Write("Inserimento riga distinta (riga " & Row.Index & " ) ... ")
                        Progress = "Inserimento riga " & Row.Index & " della tabella distinta"
                    End If
                Next

            End Using

            CopiaDisegno()
            Progress = "Copia del disegno"

            If MsgBox("Codice salvato!" & vbCrLf & "Vuoi crearne un altro?", vbYesNo, "Salva") = MsgBoxResult.Yes Then
                Pulisci()
                Blocca()
            Else
                Pulisci()
                Blocca()
                Me.Close()
            End If

        Catch ex As Exception
            Errore.Show("Salva \ Crea imballo manuale", ex.Message)
        End Try

    End Sub

    Private Sub CaricaTipi()
        Try
            Cb_Tipo.Items.Clear()

            Using Table As New ModPackDBDataSetTableAdapters.TipiTableAdapter
                Using DS As New ModPackDBDataSet.TipiDataTable
                    Table.Fill(DS)

                    For Each Row As ModPackDBDataSet.TipiRow In DS.Rows
                        Cb_Tipo.Items.Add(Row.Tipo)
                        If Not Row.IsDescrizioneNull Then ArrayTipi.Add(Row.Descrizione) Else ArrayTipi.Add("")
                    Next

                End Using
            End Using

            Cb_Tipo.SelectedIndex = 0

        Catch ex As Exception
            Errore.Show("CaricaTipi() \ Creazione imballo manuale", ex.Message)
        End Try
    End Sub
    Private Sub CaricaRiv()
        Try
            Cb_Rivestimento.Items.Clear()

            Using Table As New ModPackDBDataSetTableAdapters.RivestimentiTableAdapter
                Using DS As New ModPackDBDataSet.RivestimentiDataTable
                    Table.Fill(DS)

                    For Each Row As ModPackDBDataSet.RivestimentiRow In DS.Rows
                        Cb_Rivestimento.Items.Add(Row.Tipo_Rivestimento)
                        If Not Row.IsDescrizioneNull Then ArrayRivestimenti.Add(Row.Descrizione) Else ArrayRivestimenti.Add("")
                    Next

                End Using
            End Using

            Cb_Rivestimento.SelectedIndex = 0
        Catch ex As Exception
            Errore.Show("CaricaRiv() \ Creazione imballo manuale", ex.Message)
        End Try
    End Sub
    Private Function CheckCodice() As Boolean

        Dim Esiste As Boolean = False
        Try
            Using Table As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
                Using DS As New ModPackDBDataSet.ImballiDataTable

                    Table.Fill(DS)

                    Dim Row() As DataRow = DS.Select("Imballo = '" & Tx_CodiceImballo.Text & "'")
                    If Row.Length > 0 Then Esiste = True
                End Using
            End Using

        Catch ex As Exception
            Errore.Show("CheckCodice() \ Creazione imballo manuale", ex.Message)
        End Try

        Return Esiste
    End Function
    Private Sub CopiaDisegno()
        If Not String.IsNullOrEmpty(Tx_Disegno.Text) Then
            If Tx_Disegno.Text.EndsWith(".pdf") Then
                If My.Computer.FileSystem.FileExists(Tx_Disegno.Text) Then

                    If Not My.Computer.FileSystem.DirectoryExists(My.Settings.Root & "/Disegni") Then My.Computer.FileSystem.CreateDirectory(My.Settings.Root & "/Disegni")
                    IO.File.Copy(Tx_Disegno.Text, My.Settings.Root & "/Disegni/" & Tx_CodiceImballo.Text & ".pdf")

                End If
            End If
        End If
    End Sub

    Private Function CalcoloM2() As Single

        Dim M2 As Single = 0
        Try
            Dim L As Integer = Tx_L.Text
            Dim P As Integer = Tx_P.Text
            Dim H As Integer = Tx_H.Text

            M2 = ((L * P * 2) + (L * H * 2) + (P * H * 2)) * (10 ^ -4)


        Catch ex As Exception
            Errore.Show("CalcoloM2() \ Creazione imballo manuale", ex.Message)
        End Try
        Return Math.Round(M2, 3)
    End Function
    Private Function CalcoloM3() As Single

        Dim M3 As Single = 0
        Try
            For Each Row As DataGridViewRow In DGW_Distinta.Rows
                M3 += (Row.Cells(1).Value * Row.Cells(2).Value * Row.Cells(3).Value * Row.Cells(4).Value)
            Next

            M3 = M3 * 10 ^ -6

        Catch ex As Exception
            Errore.Show("CalcoloM2() \ Creazione imballo manuale", ex.Message)
        End Try

        Return Math.Round(M3, 3)

    End Function

    Private Sub Bt_CaricaIMG_Click(sender As Object, e As EventArgs) Handles Bt_CaricaIMG.Click
        Try
            Dim LoadImage As New OpenFileDialog With {.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|Bitmap (*.bmp)|*.bmp"}
            If LoadImage.ShowDialog = DialogResult.OK Then

                Dim infoReader As System.IO.FileInfo
                infoReader = My.Computer.FileSystem.GetFileInfo(LoadImage.FileName)
                If infoReader.Length <= 512000 Then
                    PB_Img.BackgroundImage = Image.FromFile(LoadImage.FileName)
                Else
                    MsgBox("Selezionare un'immagine di dimensioni inferiori a 500kb")
                End If

            Else
                PB_Img.BackgroundImage = Nothing
            End If
        Catch ex As Exception
            Errore.Show("CaricaIMG() \ Creazione imballo manuale", ex.Message)
        End Try

    End Sub

    Private Sub Tx_H_TextChanged(sender As Object, e As EventArgs) Handles Tx_H.TextChanged
        Tx_MF.Text = Tx_H.Text
        Tx_MT.Text = Tx_H.Text
    End Sub
    Private Sub Cb_Tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Tipo.SelectedIndexChanged
        Lbl_Tipo.Text = ArrayTipi(Cb_Tipo.SelectedIndex)
    End Sub
    Private Sub Cb_Rivestimento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Rivestimento.SelectedIndexChanged
        Lbl_Rivestimento.Text = ArrayRivestimenti(Cb_Rivestimento.SelectedIndex)
    End Sub

    'Load
    Private Sub Form_Crea_Manuale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Blocca()
        CaricaTipi()
        CaricaRiv()
        Pulisci()
    End Sub

    'Buttons
    Private Sub Bt_CheckCodice_Click(sender As Object, e As EventArgs) Handles Bt_CheckCodice.Click
        If CheckCodice() = False Then
            If Not Tx_CodiceImballo.Text.StartsWith("M") Then
                Sblocca()
            Else
                MsgBox("I codici che iniziano con M sono riservati al conteggio progressivo")
            End If

        Else
            MsgBox("Il codice che stai cercando di creare esiste già", vbInformation, "Attenzione")
        End If
    End Sub
    Private Sub Bt_Salva_Click(sender As Object, e As EventArgs) Handles Bt_Salva.Click
        Salva()
    End Sub
    Private Sub Bt_Annulla_Click(sender As Object, e As EventArgs) Handles Bt_Annulla.Click
        Pulisci()
        Blocca()
    End Sub

    Private Sub Bt_CalcolaM2_Click(sender As Object, e As EventArgs) Handles Bt_CalcolaM2.Click
        Tx_M2.Text = CalcoloM2()
    End Sub
    Private Sub Bt_CalcolaM3_Click(sender As Object, e As EventArgs) Handles Bt_CalcolaM3.Click
        Tx_M3.Text = CalcoloM3()
    End Sub

    Private Sub Bt_AggDisegno_Click(sender As Object, e As EventArgs) Handles Bt_AggDisegno.Click
        Dim Find As New OpenFileDialog With {.Filter = "Disegni in .pdf | *.pdf"}

        If Find.ShowDialog = DialogResult.OK Then
            Tx_Disegno.Text = Find.FileName
        End If

    End Sub
End Class