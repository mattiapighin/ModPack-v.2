Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' Per MyApplication sono disponibili gli eventi seguenti:
    ' Startup: generato all'avvio dell'applicazione, prima della creazione del form di avvio.
    ' Shutdown: generato dopo la chiusura di tutti i form dell'applicazione. Questo evento non viene generato se l'applicazione termina in modo anomalo.
    ' UnhandledException: generato se nell'applicazione si verifica un'eccezione non gestita.
    ' StartupNextInstance: generato all'avvio di un'applicazione a istanza singola se l'applicazione è già attiva. 
    ' NetworkAvailabilityChanged: generato quando la connessione di rete viene connessa o disconnessa.

    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            If MultiUtente.Controllo = True Then
                MsgBox("Un altro utente sta utilizzando l'applicazione (" & IO.File.ReadAllText(My.Settings.Root & "\usage") & ")", vbInformation, "Multiutente disattivato")
                e.Cancel = True
            Else
                MultiUtente.CreaFile()
            End If
        End Sub

        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
            MultiUtente.CancellaFile()
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            MultiUtente.CancellaFile()
        End Sub
    End Class
End Namespace
