Public Class Form_Listino

    Private Sub BloccaDGW()
        DGW_Materiali.ReadOnly = True
        DGW_Rivestimenti.ReadOnly = True
        DGW_Tipi.ReadOnly = True
        Bt_Salva.Enabled = False
        Bt_Annulla.Enabled = False
        BT_Ricalcola.Enabled = True
        BT_Edit.Enabled = True
    End Sub
    Private Sub SbloccaDGW()
        DGW_Tipi.ReadOnly = False
        DGW_Tipi.Columns("TipoDataGridViewTextBoxColumn").ReadOnly = True
        DGW_Tipi.Columns("DescrizioneDataGridViewTextBoxColumn").ReadOnly = True

        DGW_Rivestimenti.ReadOnly = False
        DGW_Rivestimenti.Columns("TipoRivestimentoDataGridViewTextBoxColumn").ReadOnly = True
        DGW_Rivestimenti.Columns("DescrizioneDataGridViewTextBoxColumn1").ReadOnly = True

        DGW_Materiali.ReadOnly = False
        DGW_Materiali.Columns("MaterialeDataGridViewTextBoxColumn").ReadOnly = True
        DGW_Materiali.Columns("DescrizioneDataGridViewTextBoxColumn2").ReadOnly = True
        DGW_Materiali.Columns("UMDataGridViewTextBoxColumn").ReadOnly = True

        Bt_Salva.Enabled = True
        Bt_Annulla.Enabled = True
        BT_Ricalcola.Enabled = False
        BT_Edit.Enabled = False
    End Sub

    Private Sub Form_Listino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaterialiTableAdapter.Fill(Me.ModPackDBDataSet.Materiali)
        Me.RivestimentiTableAdapter.Fill(Me.ModPackDBDataSet.Rivestimenti)
        Me.TipiTableAdapter.Fill(Me.ModPackDBDataSet.Tipi)
        BloccaDGW()
    End Sub
    Private Sub BT_Edit_Click(sender As Object, e As EventArgs) Handles BT_Edit.Click
        If MsgBox("Le modifiche al listino andranno a incidere solo sui codici inseriti dal momento della modifica." & vbCrLf & "Per modificare i prezzi dell'intero archivio utilizzare il pulsante 'Ricalcola'" & vbCrLf & "Sicuro di voler modificare?", vbYesNo, "Modifica") = MsgBoxResult.Yes Then
            SbloccaDGW()
            MsgBox("Modifiche ora attive", vbOKOnly, "Modifica")
        End If
    End Sub

    Private Sub Bt_Salva_Click(sender As Object, e As EventArgs) Handles Bt_Salva.Click
        If MsgBox("Salvare le modifiche?", vbYesNo, "Salva") = MsgBoxResult.Yes Then
            Try
                Me.MaterialiTableAdapter.Update(Me.ModPackDBDataSet.Materiali)
                Me.RivestimentiTableAdapter.Update(Me.ModPackDBDataSet.Rivestimenti)
                Me.TipiTableAdapter.Update(Me.ModPackDBDataSet.Tipi)
                LOG.Write("Modificato listino")
                BloccaDGW()

                My.Settings.Scarto = SQL.GetPrezzoMateriale("SCART")
                My.Settings.Save()

                If MsgBox("Modifiche salvate!" & vbCrLf & "E' consigliabile uscire e rientrare nell'applicazione. Uscire ora?", vbYesNo, "Salva") = MsgBoxResult.Yes Then
                    Application.Exit()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub DGW_Tipi_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGW_Tipi.CellEndEdit
        Dim DGW As DataGridView = CType(sender, DataGridView)
        Dim VecchioValore = DGW.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

        If Not DGW.Columns(e.ColumnIndex).ToString.Contains("PREZZO") Then
            DGW.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = VecchioValore
            Exit Sub
        End If

    End Sub

    Private Sub Bt_Annulla_Click(sender As Object, e As EventArgs) Handles Bt_Annulla.Click
        If MsgBox("Annullare tutte le modifiche?", vbYesNo, "Annulla") = MsgBoxResult.Yes Then
            Me.MaterialiTableAdapter.Fill(Me.ModPackDBDataSet.Materiali)
            Me.RivestimentiTableAdapter.Fill(Me.ModPackDBDataSet.Rivestimenti)
            Me.TipiTableAdapter.Fill(Me.ModPackDBDataSet.Tipi)
            BloccaDGW()
        End If
    End Sub

    Private Sub BT_Ricalcola_Click(sender As Object, e As EventArgs) Handles BT_Ricalcola.Click
        RicalcolaPrezzi()
    End Sub

    Public Sub RicalcolaPrezzi()
        If MsgBox("Sei sicuro di voler ricalcolare i prezzi di tutti gli imballi in archivio?", vbYesNo, "Ricalcola") = MsgBoxResult.Yes Then

            Try

                ProgressBar.Visible = True

                Using DS As New ModPackDBDataSet
                    Using ImballiTable As New ModPackDBDataSetTableAdapters.ImballiTableAdapter

                        ImballiTable.Fill(DS.Imballi)



                        ProgressBar.Maximum = DS.Imballi.Count + 1
                        ProgressBar.Value = 1

                        Dim I As Integer = 0 'contatore prezzi modificati
                        Dim ListaModifiche As New List(Of String())

                        For Each Imballo As ModPackDBDataSet.ImballiRow In DS.Imballi

                            ProgressBar.Value += 1

                            Dim PrezzoVecchio As Decimal = Imballo.Prezzo

                            Select Case Imballo.Tipo

                                'INSERIRE QUI SE AGGIUNTO NUOVO TIPO

                                Case "GST"
                                    Imballo.Prezzo = Prezzi.GST(Imballo.M3, Imballo.L, Imballo.P, Imballo.H, Imballo.Tipo_Rivestimento, Imballo.HT)

                                Case "C"
                                    Imballo.Prezzo = Prezzi.C(Imballo.M3, Imballo.L, Imballo.P, Imballo.H, Imballo.Tipo)

                                Case Else
                                    Imballo.Prezzo = Prezzi.Base(Imballo.Tipo, Imballo.M3, Imballo.M2, Imballo.Tipo_Rivestimento, Imballo.HT)

                            End Select

                            If PrezzoVecchio <> Imballo.Prezzo Then
                                ListaModifiche.Add({Imballo.Imballo, PrezzoVecchio, Imballo.Prezzo})
                                LOG.Write("Ricalco prezzo " & Imballo.Imballo & "  [ € " & PrezzoVecchio & " -> € " & Imballo.Prezzo & " ]")
                                I += 1
                            End If

                        Next

                        ImballiTable.Update(DS.Imballi)

                        If I > 0 Then
                            MsgBox("Ricalcolo completato con successo" & vbCrLf & I & " su " & DS.Imballi.Count & " prezzi aggiornati", vbInformation, "Ricalcolo")
                            CreaXML_Modifiche(ListaModifiche)
                        Else
                            MsgBox("Nessun imballo è stato interessato dalla modifica del listino!", vbInformation, "Ricalcolo")
                        End If


                        ProgressBar.Value = 0

                    End Using
                End Using

                ProgressBar.Visible = False

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub CreaXML_Modifiche(ByVal Lista As List(Of String()))

        Try



            Dim settings As New System.Xml.XmlWriterSettings() With {.Indent = True}
            Dim XmlWrt As System.Xml.XmlWriter = System.Xml.XmlWriter.Create(My.Computer.FileSystem.SpecialDirectories.Temp & "\Modifiche.xml", settings)

            With XmlWrt

                .WriteStartDocument()
                .WriteComment("Ricalcolo totale listino " & Date.Today.Date.ToShortDateString)
                .WriteStartElement("Modifiche")

                For Each Riga As String() In Lista

                    .WriteStartElement("Imballo_Modificato")


                    .WriteStartElement("Imballo")
                    .WriteValue(Riga(0))
                    .WriteEndElement()

                    .WriteStartElement("Prezzo_Vecchio")
                    .WriteValue(Riga(1))
                    .WriteEndElement()

                    .WriteStartElement("Prezzo_Nuovo")
                    .WriteValue(Riga(2))
                    .WriteEndElement()

                    .WriteEndElement()

                Next

                .WriteEndElement()
                .WriteEndDocument()
                .Close()

                Dim PathXML As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\Modifiche.xml"

                Dim Salva As New SaveFileDialog With {.Filter = "XML File|*.xml", .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments, .FileName = "Ricalcolo prezzi " & Date.Today.Day & "_" & Date.Today.Month & "_" & Date.Today.Year}

                If Salva.ShowDialog = DialogResult.OK Then
                    'Salvo il file appena creato e lo apro
                    My.Computer.FileSystem.CopyFile(PathXML, Salva.FileName)
                End If

                Dim FLE As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\Modifiche.xml" ' PATH AND FILE NAME WHERE THE XML WIL BE CREATED (EXEMPLE: C:\REPS\XML.xml)
                Dim EXL As String = My.Settings.ExcelPath ' PATH OF/ EXCEL.EXE IN YOUR MICROSOFT OFFICE
                Shell(Chr(34) & EXL & Chr(34) & " " & Chr(34) & FLE & Chr(34), vbNormalFocus) ' OPEN XML WITH EXCEL

            End With

        Catch ex As Exception
            Errore.Show("Ricalcolo prezzi", "Errore durante la creazione del file xml con le modifiche")
        End Try

    End Sub

End Class