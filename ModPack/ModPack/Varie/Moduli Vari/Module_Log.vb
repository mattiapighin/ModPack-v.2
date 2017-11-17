Namespace LOG
    Module Module_Log

        Dim LOGTable As New ModPackDBDataSetTableAdapters.LogTableAdapter
        Dim FileLog As String = My.Settings.FileLogPath

        Public Sub CheckSize()

            Dim xml = XDocument.Load(My.Settings.XMLpath)
            Dim Valore As Integer = xml.<Data>.<Max_LOG>.Value

            Try
                'Se il log non esiste o è stato eliminato lo crea
                If Not My.Computer.FileSystem.FileExists(FileLog) Then
                    IO.File.Create(FileLog)
                Else

                    'Controlla la dimensione, se supera il mb ne crea una copia di backup e pulisce quello in uso
                    Dim infoReader As System.IO.FileInfo
                    infoReader = My.Computer.FileSystem.GetFileInfo(My.Settings.FileLogPath)

                    If infoReader.Length > Valore Then
                        IO.File.Copy(FileLog, infoReader.DirectoryName & "\Backup Log (" & Date.Today.Day & "-" & Date.Today.Month & "-" & Date.Today.Year & ").txt", True)
                        IO.File.Delete(FileLog)
                        IO.File.Create(My.Settings.FileLogPath)
                        MsgBox("Pulizia file log effettuata!")
                    End If

                End If

            Catch ex As Exception

            End Try
        End Sub

        Public Sub Clean()
            Try
                Dim Giorni As Integer
                Dim X = XDocument.Load(My.Settings.XMLpath)
                Giorni = X.<Data>.<Giorni_Memoria_LOG>.Value

                SQL.Query("DELETE FROM Log WHERE Data < GETDATE() - " & Giorni)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Public Sub Show()
            Try
                Process.Start(FileLog)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub Write(ByVal Stringa As String)
            Try

                LOGTable.Insert(Date.Now, TimeOfDay.TimeOfDay, System.Environment.UserName, Stringa)
                'IO.File.AppendAllText(FileLog, DateTime.Now & " [" & System.Environment.UserName & "] " & Stringa & vbCrLf)
                Debug.WriteLine(Stringa)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub


    End Module
End Namespace
