Imports System.IO.Compression

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'Elimina tutti i backup più vecchi di 30 giorni
            Dim directory As New IO.DirectoryInfo(My.Settings.DirectoryBackup)

            For Each file As IO.FileInfo In directory.GetFiles
                If (Now - file.CreationTime).Days > 30 Then file.Delete()
            Next

        Catch ex As Exception
            MsgBox("ModPack Backup: Errore nel cancellare i file da percorso di destinazione")
            Exit Sub
            Application.Exit()
        End Try

        Try
            'Crea lo zip file
            Dim startPath As String = "Z:\ModPack"
            Dim zipPath As String = My.Settings.DirectoryBackup & "\" & Date.Today.Day & "_" & Date.Today.Month & "_" & Date.Today.Year & "_" & Date.Now.Hour & Date.Now.Minute & ".zip"

            ZipFile.CreateFromDirectory(startPath, zipPath)
        Catch ex As Exception
            MsgBox("ModPack Backup: Errore nel creare il file")
            Exit Sub
            Application.Exit()
        End Try

        Application.Exit()

    End Sub

End Class
