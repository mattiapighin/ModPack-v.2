Namespace Controlli
    Module Module_Controlli

        Public Function RiempiListaTipi() As List(Of String)
            Dim TipiList As New List(Of String)

            Using Table As New ModPackDBDataSetTableAdapters.TipiTableAdapter
                Using DS As New ModPackDBDataSet.TipiDataTable

                    Table.Fill(DS)
                    For Each Row As ModPackDBDataSet.TipiRow In DS
                        TipiList.Add(Row.Tipo)
                    Next

                End Using
            End Using

            Return TipiList
        End Function
        Public Function RiempiListaRivestimenti() As List(Of String)
            Dim RivList As New List(Of String)

            Using Table As New ModPackDBDataSetTableAdapters.RivestimentiTableAdapter
                Using DS As New ModPackDBDataSet.RivestimentiDataTable

                    Table.Fill(DS)
                    For Each Row As ModPackDBDataSet.RivestimentiRow In DS
                        RivList.Add(Row.Tipo_Rivestimento)
                    Next

                End Using
            End Using

            Return RivList
        End Function
        Public Function CheckTipiRivestimenti(ByVal Riga As RigaOrdineINPUT, ByVal ListaTipi As List(Of String), ByVal ListaRivestimenti As List(Of String)) As Boolean
            Dim OK As Boolean = False

            If ListaTipi.Contains(Riga.Tipo) Then
                OK = True
            Else
                MsgBox("[Errore riga " & Riga.Riga & "]" & vbCrLf & "TIPO NON RICONSCIUTO - (" & Riga.Tipo & ")" & vbCrLf & "La riga non verrà caricata", vbOKOnly, "Errore")
                OK = False
                Return OK
                Exit Function
            End If

            If Riga.Rivestimento = True Then
                If ListaRivestimenti.Contains(Riga.TipoRivestimento) Then
                    OK = True
                Else
                    MsgBox("[Errore riga " & Riga.Riga & "]" & vbCrLf & "RIVESTIMENTO NON RICONSCIUTO - (" & Riga.TipoRivestimento & ")" & vbCrLf & "La riga non verrà caricata", vbOKOnly, "Errore")
                    OK = False
                    Return OK
                    Exit Function
                End If
            End If

            Return OK
        End Function

    End Module
End Namespace

