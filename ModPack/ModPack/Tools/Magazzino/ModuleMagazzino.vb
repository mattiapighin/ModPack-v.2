Namespace ModMagazzino
    Module ModuleMagazzino

        Public Function GetDescrizione(ByVal Codice As String, ByVal Lista As List(Of Magazzino)) As String

            For Each Row As Magazzino In Lista
                If Row.Codice = Codice Then
                    Return Row.Descrizione
                    Exit Function
                End If
            Next

            Return Codice

        End Function


    End Module
End Namespace