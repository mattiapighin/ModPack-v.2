Imports System.ComponentModel

Public Class Main

    Dim FullSCR As Boolean
    Dim C As Integer


    Private Sub Mostra()
        If ListaFiles.SelectedItems.Count > 0 Then
            DGW_Lista.Rows.Clear()

            For Each File As String In ListaFiles.SelectedItems

                Dim Lista() As String = IO.File.ReadAllLines(My.Settings.Folder & "\" & File & ".riv")

                For Each Riga As String In Lista
                    Dim Cella() As String = Split(Riga, "|")

                    Dim Stringa As String
                    Dim ID As String = Cella(9)
                    Dim Ordine As String = File

                    Stringa = Cella(0) & " [pz. " & Cella(1) & "]" & vbCrLf & Cella(2) & vbCrLf & Cella(3) & vbCrLf & Cella(4) & vbCrLf & Cella(5) & vbCrLf & Cella(6)
                    If Not String.IsNullOrEmpty(Cella(7)) Then Stringa += vbCrLf & "--------------------" & vbCrLf & Cella(7)
                    If Not String.IsNullOrEmpty(Cella(8)) Then Stringa += vbCrLf & "--------------------" & vbCrLf & Cella(8)

                    Dim Row() As String = {Stringa, Riga, File}

                    DGW_Lista.Rows.Add(Row)
                Next

                Dim Font As New Font(My.Settings.Font, My.Settings.FontSize)
                DGW_Lista.DefaultCellStyle.Font = Font
                DGW_Lista.DefaultCellStyle.SelectionBackColor = My.Settings.ColoreSelezione
                DGW_Lista.DefaultCellStyle.SelectionForeColor = My.Settings.TestoSelezione
                DGW_Lista.BackgroundColor = My.Settings.SfondoTabella
            Next
        End If
    End Sub
    Private Sub RefreshList()
        ListaFiles.Items.Clear()
        If My.Computer.FileSystem.DirectoryExists(My.Settings.Folder) Then
            For Each File As String In My.Computer.FileSystem.GetFiles(My.Settings.Folder)
                If IO.Path.GetExtension(File) = ".riv" Then
                    ListaFiles.Items.Add(IO.Path.GetFileNameWithoutExtension(File))
                End If
            Next
        End If
        ListaFiles.Sorted = True
    End Sub
    Private Sub EliminaRiga()
        Try
            Dim File As String = DGW_Lista.Rows(DGW_Lista.CurrentRow.Index).Cells(2).Value
            Dim ID As String = DGW_Lista.Rows(DGW_Lista.CurrentRow.Index).Cells(1).Value

            Dim PATH As String = My.Settings.Folder & "\" & File & ".riv"

            Dim NuovoFile As New List(Of String)

            For Each Riga As String In IO.File.ReadAllLines(PATH)
                If Not Riga = ID Then
                    NuovoFile.Add(Riga)
                End If
            Next

            IO.File.WriteAllLines(PATH, NuovoFile)
            DGW_Lista.Rows.Remove(DGW_Lista.CurrentRow)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = My.Settings.Timer * 1000
        Timer1.Start()
        ListaFiles.Items.Clear()

        RefreshList()

        Me.Text = Me.Text & " V." & My.Application.Info.Version.ToString

        If My.Settings.FullScreen = True Then
            Me.FormBorderStyle = FormBorderStyle.None
            Me.Size = Screen.PrimaryScreen.WorkingArea.Size
            Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Controlla quando vengono inseriti nuovi files per aggiornare la listbox e mostrare l'avviso

        Dim D As Integer

        C = ListaFiles.Items.Count  'Numero di file attualmente nella listbox
        D = 0                       'Numero di file nella cartella rivestimenti

        If My.Computer.FileSystem.DirectoryExists(My.Settings.Folder) Then
            For Each File As String In My.Computer.FileSystem.GetFiles(My.Settings.Folder)
                If IO.Path.GetExtension(File) = ".riv" Then
                    D += 1 'Conta i file nella cartella rivestimenti
                End If
            Next
        End If

        Select Case D
            Case > C
                'Se maggiori di quelli nella listbox mostra avviso e refresh listbox
                RefreshList()
                Form_Avviso.ShowDialog()

            Case < C
                'Se minori di quelli nella listbox refresh listbox
                RefreshList()

            Case Else
                'Se uguali suka
        End Select

    End Sub

    Private Sub Bt_Mostra_Click(sender As Object, e As EventArgs) Handles Bt_Mostra.Click

        Mostra()

    End Sub

    Private Sub DGW_Lista_KeyDown(sender As Object, e As KeyEventArgs) Handles DGW_Lista.KeyDown
        If e.KeyCode = Keys.Delete Then
            EliminaRiga()
        End If
    End Sub

    Private Sub Bt_Elimina_Click(sender As Object, e As EventArgs) Handles Bt_Elimina.Click

        If IO.File.Exists(My.Settings.Folder & "\" & ListaFiles.SelectedItem & ".riv") Then

            IO.File.Delete(My.Settings.Folder & "\" & ListaFiles.SelectedItem & ".riv")
            RefreshList()


        End If
    End Sub

    Private Sub Bt_Opzioni_Click(sender As Object, e As EventArgs) Handles Bt_Opzioni.Click
        Opzioni.ShowDialog()
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If My.Settings.Nascondi = True Then
            If e.CloseReason = CloseReason.UserClosing Then
                e.Cancel = True
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub ListaFiles_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListaFiles.MouseDoubleClick

        Mostra()

    End Sub


End Class
