Namespace Prezzi
    Module Module_Prezzi

        Public Function Scarto(M3) As Single
            Dim Sk As Single = 0
            If M3 > 0 Then
                Sk = M3 * My.Settings.Scarto / 100
            End If
            Return Sk
        End Function

        Public Function Base(Tipo As String, M3 As Single, M2 As Single, Rivestimento As String, Ht As Boolean) As Single
            'MODULO VALIDO PER G, P, T, GDA

            Dim PrezzoTotale As Single = 0

            Try

                Dim PrezzoMateriale As Single = 0
                Dim PrezzoRivestimento As Single = 0

                Dim TableTipi As New ModPackDBDataSetTableAdapters.TipiTableAdapter
                Dim TableRivestimenti As New ModPackDBDataSetTableAdapters.RivestimentiTableAdapter

                Using DS As New ModPackDBDataSet

                    TableTipi.Fill(DS.Tipi)
                    TableRivestimenti.Fill(DS.Rivestimenti)

                    Dim TipiRow() As DataRow = DS.Tipi.Select("Tipo = '" & Tipo & "'")

                    If Not Rivestimento = "" Then
                        Dim RivRow() As DataRow = DS.Rivestimenti.Select("Tipo_Rivestimento = '" & Rivestimento & "'")

                        If RivRow.Length > 0 Then
                            PrezzoRivestimento = RivRow(0)(3)
                        Else
                            MsgBox("Errore: Tipo rivestimento non trovato (" & Rivestimento & ")")
                            PrezzoRivestimento = 0
                        End If

                    End If

                    If TipiRow.Length > 0 Then

                        Select Case Ht
                            Case True
                                PrezzoMateriale = TipiRow(0)(11)
                            Case False
                                PrezzoMateriale = TipiRow(0)(10)
                        End Select

                    Else
                        MsgBox("Errore: Tipo imballo non trovato (" & Tipo & ")")
                        PrezzoMateriale = 0
                    End If

                    PrezzoTotale = (PrezzoRivestimento * M2) + (PrezzoMateriale * M3) + (PrezzoMateriale * Scarto(M3))

                    LOG.Write("Materiale € " & (PrezzoMateriale * M3) & " - Rivestimento € " & (PrezzoRivestimento * M2) & " - Scarto € " & (PrezzoMateriale * Scarto(M3)) & " - TOTALE € " & Math.Round(PrezzoTotale, 1))

                    TableTipi.Dispose()
                    TableRivestimenti.Dispose()

                End Using

            Catch ex As Exception
                MsgBox("Si è verificato un'errore nel calcolo del prezzo" & vbCrLf & ex.Message)
            End Try


            Return Math.Round(PrezzoTotale, 1)

        End Function
        Public Function GST(M3 As Single, L As Integer, P As Integer, H As Integer, Rivestimento As String, Ht As Boolean) As Single
            Dim PrezzoTotale As Single = 0

            Try

                Dim PrezzoMateriale As Single = 0
                Dim PrezzoRivestimento As Single = 0
                Dim PrezzoFaesite As Single = 0


                Dim TableTipi As New ModPackDBDataSetTableAdapters.TipiTableAdapter
                Dim TableRivestimenti As New ModPackDBDataSetTableAdapters.RivestimentiTableAdapter
                Dim TableMateriali As New ModPackDBDataSetTableAdapters.MaterialiTableAdapter

                Using DS As New ModPackDBDataSet

                    TableTipi.Fill(DS.Tipi)
                    TableRivestimenti.Fill(DS.Rivestimenti)
                    TableMateriali.Fill(DS.Materiali)

                    Dim TipiRow() As DataRow = DS.Tipi.Select("Tipo = 'GST'")

                    If Not Rivestimento = "" Then
                        Dim RivRow() As DataRow = DS.Rivestimenti.Select("Tipo_Rivestimento = '" & Rivestimento & "'")

                        If RivRow.Length > 0 Then
                            PrezzoRivestimento = RivRow(0)(3)
                        Else
                            MsgBox("Errore: Tipo rivestimento non trovato (" & Rivestimento & ")")
                            PrezzoRivestimento = 0
                        End If

                        Dim MatRow() As DataRow = DS.Materiali.Select("Materiale = 'FAES'")

                        If MatRow.Length > 0 Then
                            PrezzoFaesite = MatRow(0)(4)
                        Else
                            MsgBox("Errore: Tipo materiale non trovato (FAES)")
                            PrezzoFaesite = 0
                        End If

                    End If

                    If TipiRow.Length > 0 Then
                        Select Case Ht
                            Case True
                                PrezzoMateriale = TipiRow(0)(11)
                            Case False
                                PrezzoMateriale = TipiRow(0)(10)
                        End Select
                    Else
                        MsgBox("Errore: Tipo imballo non trovato (GST)")
                        PrezzoMateriale = 0
                    End If


                    Dim M2_CP As Single = ((L * H * 2) + (P * H * 2) + (L * P)) * (10 ^ -4)
                    'Dal 20/09/2017 rimossa faesite sulla base
                    Dim M2_FF As Single = 0 ' (L * P) * (10 ^ -4)

                    PrezzoTotale = (PrezzoMateriale * M3) + (PrezzoRivestimento * M2_CP) + (PrezzoFaesite * M2_FF) + (PrezzoMateriale * Scarto(M3))

                    LOG.Write("Materiale € " & (PrezzoMateriale * M3) & " - Rivestimento € " & (PrezzoRivestimento * M2_CP) & " - Faesite € " & (PrezzoFaesite * M2_FF) & " - Scarto € " & (PrezzoMateriale * Scarto(M3)) & " - TOTALE € " & Math.Round(PrezzoTotale, 1))

                    TableTipi.Dispose()
                    TableRivestimenti.Dispose()
                    TableMateriali.Dispose()

                End Using

            Catch ex As Exception
                MsgBox("Si è verificato un'errore nel calcolo del prezzo" & vbCrLf & ex.Message)
            End Try

            Return Math.Round(PrezzoTotale, 1)

        End Function
        Public Function C(m3 As Single, L As Integer, P As Integer, H As Integer, Tipo As String)
            Dim PrezzoTotale As Single = 0

            Try


                Dim PrezzoOSB9 As Single = 0
                Dim PrezzoOSB12 As Single = 0
            Dim PrezzoZoccoli As Single = 0
            Dim PrezzoCostruzione As Single = 0


            Dim M2_09 As Single = (((L + 2.5) * (P + 2)) + ((L + 2.5) * (H + 1.5) * 2)) * (10 ^ -4)
            Dim M2_12 As Single = ((L * P) + (P * (H + 1.5) * 2)) * (10 ^ -4)

            Dim MaterialiTable As New ModPackDBDataSetTableAdapters.MaterialiTableAdapter
            Dim TipiTable As New ModPackDBDataSetTableAdapters.TipiTableAdapter

            Using DS As New ModPackDBDataSet
                MaterialiTable.Fill(DS.Materiali)
                TipiTable.Fill(DS.Tipi)

                    For Each Row As ModPackDBDataSet.MaterialiRow In DS.Materiali.Rows
                        If Row.Materiale = "OSB9" Then PrezzoOSB9 = Row.Prezzo
                        If Row.Materiale = "OSB12" Then PrezzoOSB12 = Row.Prezzo
                        If Row.Materiale = "COSTR" Then PrezzoCostruzione = Row.Prezzo
                    Next

                    If PrezzoOSB9 = 0 Then MsgBox("Errore: Tipo materiale trovato (OSB9)")
                    If PrezzoOSB12 = 0 Then MsgBox("Errore: Tipo materiale trovato (OSB12)")
                    If PrezzoCostruzione = 0 Then MsgBox("Errore: Tipo materiale trovato (COSTR)")

                    Dim RowTipo() As DataRow = DS.Tipi.Select("Tipo = '" & Tipo & "'")

                    If RowTipo.Length > 0 Then
                        PrezzoZoccoli = RowTipo(0)(11)
                    Else
                        MsgBox("Errore: Tipo non trovato (" & Tipo & ")")
                        PrezzoZoccoli = 0
                    End If


                    PrezzoTotale = (PrezzoOSB9 * M2_09) + (PrezzoOSB12 * M2_12) + (PrezzoZoccoli * m3) + PrezzoCostruzione + (PrezzoZoccoli * Scarto(m3))
                    LOG.Write("OSB € " & (PrezzoOSB9 * M2_09) + (PrezzoOSB12 * M2_12) & " - Zoccoli € " & (PrezzoZoccoli * m3) & " - Costruzione € " & PrezzoCostruzione & " - Scarto € " & (PrezzoZoccoli * Scarto(m3)) & " - TOTALE € " & Math.Round(PrezzoTotale, 1))

                    MaterialiTable.Dispose()
                TipiTable.Dispose()

            End Using


            Catch ex As Exception
                MsgBox("Si è verificato un'errore nel calcolo del prezzo" & vbCrLf & ex.Message)
            End Try

            Return Math.Round(PrezzoTotale, 1)
        End Function

    End Module
End Namespace