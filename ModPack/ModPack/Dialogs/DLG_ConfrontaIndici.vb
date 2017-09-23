Imports System.Windows.Forms

Public Class DLG_ConfrontaIndici

    Dim VecchioNome As String
    Dim NuovoNome As String
    Dim VecchioRiga As RigaOrdineINPUT
    Dim NuovaRiga As RigaOrdineINPUT

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Public Sub MostraDifferenze(NomeVecchio As String, Vecchio As RigaOrdineINPUT, NomeNuovo As String, Nuovo As RigaOrdineINPUT)
        DGW_Confronto.Rows.Clear()
        Dim RowVecio() = {NomeVecchio, Vecchio.L, Vecchio.P, Vecchio.H, Vecchio.Tipo, Vecchio.Zoccoli, Vecchio.Rivestimento, Vecchio.TipoRivestimento, Vecchio.HT, Vecchio.DT, Vecchio.BM, Vecchio.Diagonali}
        Dim RowNuovo() = {"", Nuovo.L, Nuovo.P, Nuovo.H, Nuovo.Tipo, Nuovo.Zoccoli, Nuovo.Rivestimento, Nuovo.TipoRivestimento, Nuovo.HT, Nuovo.DT, Nuovo.BM, Nuovo.Diagonali}

        Lbl_Info1.Text = "D: [" & Nuovo.Codice & "] C: [" & Nuovo.Commessa & "] Pz. " & Nuovo.Qt

        DGW_Confronto.Rows.Add(RowVecio)
        DGW_Confronto.Rows.Add(RowNuovo)

        For Each Column As DataGridViewColumn In DGW_Confronto.Columns
            If Not Column.Index = 0 Then
                If DGW_Confronto.Rows(0).Cells(Column.Index).Value <> DGW_Confronto.Rows(1).Cells(Column.Index).Value Then
                    Column.DefaultCellStyle.BackColor = Color.Red
                Else
                    Column.DefaultCellStyle.BackColor = Color.White
                End If
            End If
        Next

        VecchioRiga = Vecchio
        NuovaRiga = Nuovo
        VecchioNome = NomeVecchio
        NuovoNome = NomeNuovo


        OK_Button.Text = "CREA" & vbCrLf & "(" & NuovoNome & ")"
        Cancel_Button.Text = "MANTIENI" & vbCrLf & "(" & VecchioNome & ")"
    End Sub

    Private Sub DLG_ConfrontaIndici_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Stringa As String = "L'indice " & NuovaRiga.Indice & " non corrisponde all'imballo " & VecchioNome & " a cui era stato associato." & vbCrLf & "Vuoi cercare l'imballo nuovo (" & NuovoNome & ") o mantenere il vecchio?"

        Lbl_Info.Text = Stringa
    End Sub
End Class

