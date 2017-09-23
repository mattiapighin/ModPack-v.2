Namespace Pdf
    Module Module_PDF

        Public Sub Stampa(ByVal Codice As String)
            If My.Computer.FileSystem.FileExists(My.Settings.Root & "\Disegni\" & Codice & ".pdf") Then
                If MsgBox("Stampare il disegno allegato a '" & Codice & "'", vbYesNo, "Disegno") = MsgBoxResult.Yes Then
                    Dim p As New System.Diagnostics.ProcessStartInfo()
                    p.Verb = "print"
                    p.WindowStyle = ProcessWindowStyle.Hidden
                    p.FileName = My.Settings.Root & "\Disegni\" & Codice & ".pdf"
                    p.UseShellExecute = True
                    System.Diagnostics.Process.Start(p)
                End If
            End If
        End Sub

    End Module
End Namespace
