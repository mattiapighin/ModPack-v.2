Namespace Errore
    Module Errore

        Public Sub Show(ByVal Localizzazione As String, ByVal Messaggio As String)
            ErrorBox.Show()
            ErrorBox.Lbl_LocErrore.Text = Localizzazione
            ErrorBox.Txt_Message.Text = Messaggio

            LOG.Write("----// ERRORE IN " & Localizzazione & " | " & Messaggio & " //----")

        End Sub

    End Module
End Namespace