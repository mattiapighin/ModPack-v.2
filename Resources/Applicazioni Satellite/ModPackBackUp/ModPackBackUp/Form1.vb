Imports System.IO.Compression

Public Class Form1
    Private Sub Bt_Folder_Click(sender As Object, e As EventArgs) Handles Bt_Folder.Click
        Dim G As New FolderBrowserDialog With {.Description = "Scegli la directory in cui verranno salvati i backup"}

        If G.ShowDialog = DialogResult.OK Then
            My.Settings.DirectoryBackup = G.SelectedPath
            My.Settings.Save()
        End If

        Txt_Folder.Text = My.Settings.DirectoryBackup
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(My.Settings.DirectoryBackup) Then Txt_Folder.Text = My.Settings.DirectoryBackup
    End Sub

    Private Sub Bt_Crea_Click(sender As Object, e As EventArgs) Handles Bt_Crea.Click

        Dim startPath As String = "Z:\ModPack"
        Dim zipPath As String = My.Settings.DirectoryBackup & "\" & Date.Today.Day & "_" & Date.Today.Month & "_" & Date.Today.Year & "_" & Date.Now.Hour & Date.Now.Minute & ".zip"

        If Not My.Computer.FileSystem.FileExists(zipPath) Then
            ZipFile.CreateFromDirectory(startPath, zipPath)
            MsgBox("Backup creato! (" & Date.Today.Day & "_" & Date.Today.Month & "_" & Date.Today.Year & "_" & Date.Now.Hour & Date.Now.Minute & ")", vbInformation, "Crea")
        Else
            MsgBox("E' appena stato fatto un backup")
        End If



    End Sub

    Private Sub Bt_Ripristina_Click(sender As Object, e As EventArgs) Handles Bt_Ripristina.Click

        Dim G As New OpenFileDialog With {.Filter = "ModPack Backup|*.zip", .Title = "Rpristina backup"}

        If G.ShowDialog = DialogResult.OK Then

            If MsgBox("Sei sicuro di voler ripristinare il backup " & IO.Path.GetFileNameWithoutExtension(G.FileName) & "?" & vbCrLf & "Tutte le modifiche seguenti andranno perse", vbYesNo, "Ripristina") = MsgBoxResult.Yes Then
                If MsgBox("Sicuro sicuro?", vbYesNo, "Ripristina") = MsgBoxResult.Yes Then
                    For Each _file As String In System.IO.Directory.GetFiles("Z:\ModPack")
                        System.IO.File.Delete(_file)
                    Next

                    Dim zipPath As String = G.FileName
                    Dim extractPath As String = "Z:\ModPack"

                    ZipFile.ExtractToDirectory(zipPath, extractPath)
                End If

            End If
        End If

    End Sub
End Class
