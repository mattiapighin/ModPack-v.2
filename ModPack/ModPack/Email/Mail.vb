Imports System.Net.Mail

Namespace Mail
    Module Mail

        Public ListaDestinatari As New List(Of DestinatarioMail)

        Public Sub Invia(ByVal OGGETTO As String, ByVal CORPO As String, Optional ByVal Allegati As List(Of String) = Nothing)

            If Mail_ScegliDestinatari.ShowDialog() = DialogResult.OK Then
                'Apre la finestra per scegliere i destinatari dell'email

                Dim StringaDestinatari As String = ""
                For Each D As DestinatarioMail In ListaDestinatari
                    StringaDestinatari += vbCrLf & D.Email
                Next

                If MsgBox("Inviare mail ai seguenti indirizzi?" & StringaDestinatari, vbYesNo, "Email") = MsgBoxResult.Yes Then

                    Dim SmtpServer As New SmtpClient()
                    Dim mail As New MailMessage()

                    Try
                        SmtpServer.Credentials = New Net.NetworkCredential(My.Settings.MAIL_username, My.Settings.MAIL_password)
                        SmtpServer.Port = My.Settings.MAIL_port
                        SmtpServer.Host = My.Settings.MAIL_server
                        mail = New MailMessage()
                        mail.From = New MailAddress(My.Settings.MAIL_username)


                        For Each D As DestinatarioMail In ListaDestinatari
                            mail.To.Add(D.Email)
                        Next

                        If Not Allegati Is Nothing Then
                            For Each R As String In Allegati
                                Dim Allegato As New Attachment(R)
                                mail.Attachments.Add(Allegato)
                            Next
                        End If

                        mail.Subject = OGGETTO
                        mail.Body = CORPO

                        SmtpServer.Send(mail)
                        MsgBox("Email Inviata!", vbInformation, "Email")

                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try

                End If
            End If
        End Sub


    End Module
End Namespace