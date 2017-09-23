Namespace MultiUtente
    Module ControlloMultiUtente

        Public Sub CreaFile()
            Dim xml = XDocument.Load(My.Settings.XMLpath)
            Dim Multiutente As String = xml.<Data>.<Pulizia_Ordine>.Value

            If Not Multiutente = "true" Then
                '  IO.File.Create(My.Settings.Root & "\usage")
                IO.File.WriteAllText(My.Settings.Root & "\usage", System.Environment.UserName)
            End If

        End Sub
        Public Sub CancellaFile()
            Dim xml = XDocument.Load(My.Settings.XMLpath)
            Dim Multiutente As String = xml.<Data>.<Pulizia_Ordine>.Value

            If Not Multiutente = "true" Then
                IO.File.Delete(My.Settings.Root & "\usage")
            End If

        End Sub
        Public Function Controllo() As Boolean
            Dim Giainuso As Boolean = False

            Dim xml = XDocument.Load(My.Settings.XMLpath)
            Dim Multiutente As String = xml.<Data>.<Pulizia_Ordine>.Value

            If Not Multiutente = "true" Then
                If My.Computer.FileSystem.FileExists(My.Settings.Root & "\usage") Then
                    Giainuso = True
                End If
            End If

            Return Giainuso
        End Function


    End Module
End Namespace