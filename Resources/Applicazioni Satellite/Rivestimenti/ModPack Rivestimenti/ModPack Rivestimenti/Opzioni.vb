Imports System.Windows.Forms

Public Class Opzioni

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        My.Settings.SfondoTabella = Bt_SfondoTabella.BackColor
        My.Settings.Avviso = Ck_Avviso.Checked
        My.Settings.ColoreAvviso = Bt_ColoreAvviso.BackColor
        My.Settings.Folder = TxtFolder.Text
        My.Settings.Timer = Nu_Timer.Value
        My.Settings.FontSize = Nu_SizeFont.Value
        My.Settings.ColoreSelezione = Bt_Selezione.BackColor
        My.Settings.TestoSelezione = Bt_TestoSelezione.ForeColor
        My.Settings.Nascondi = Ck_Nascondi.Checked
        My.Settings.FullScreen = Ck_Fullscreen.Checked
        My.Settings.Font = CBFonts.SelectedItem
        My.Settings.Save()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Bt_BrowseFolders_Click(sender As Object, e As EventArgs) Handles Bt_BrowseFolders.Click
        Dim O As New FolderBrowserDialog With {.Description = "Cartella in cui sono contenuti i file rivestimento"}

        If O.ShowDialog = DialogResult.OK Then
            TxtFolder.Text = O.SelectedPath
        End If

    End Sub

    Private Sub Opzioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each oFont As FontFamily In FontFamily.Families
            CBFonts.Items.Add(oFont.Name)
        Next
        Bt_SfondoTabella.BackColor = My.Settings.SfondoTabella
        Bt_ColoreAvviso.BackColor = My.Settings.ColoreAvviso
        CBFonts.SelectedItem = My.Settings.Font
        Ck_Avviso.Checked = My.Settings.Avviso
        TxtFolder.Text = My.Settings.Folder
        Nu_Timer.Value = My.Settings.Timer
        Nu_SizeFont.Value = My.Settings.FontSize
        Bt_Selezione.BackColor = My.Settings.ColoreSelezione
        Bt_TestoSelezione.ForeColor = My.Settings.TestoSelezione
        Ck_Nascondi.Checked = My.Settings.Nascondi
        Ck_Fullscreen.Checked = My.Settings.FullScreen
    End Sub

    Private Sub Bt_Selezione_Click(sender As Object, e As EventArgs) Handles Bt_Selezione.Click
        Dim C As New ColorDialog
        If C.ShowDialog = DialogResult.OK Then
            Bt_Selezione.BackColor = C.Color
        End If
    End Sub

    Private Sub Bt_TestoSelezione_Click(sender As Object, e As EventArgs) Handles Bt_TestoSelezione.Click
        Dim C As New ColorDialog
        If C.ShowDialog = DialogResult.OK Then
            Bt_TestoSelezione.ForeColor = C.Color
        End If
    End Sub

    Private Sub Bt_ColoreAvviso_Click(sender As Object, e As EventArgs) Handles Bt_ColoreAvviso.Click
        Dim C As New ColorDialog
        If C.ShowDialog = DialogResult.OK Then
            Bt_ColoreAvviso.BackColor = C.Color
        End If
    End Sub

    Private Sub Bt_SfondoTabella_Click(sender As Object, e As EventArgs) Handles Bt_SfondoTabella.Click
        Dim C As New ColorDialog
        If C.ShowDialog = DialogResult.OK Then
            Bt_SfondoTabella.BackColor = C.Color
        End If
    End Sub
End Class
