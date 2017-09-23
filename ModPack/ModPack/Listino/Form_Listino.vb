Public Class Form_Listino

    Private Sub BloccaDGW()
        DGW_Materiali.ReadOnly = True
        DGW_Rivestimenti.ReadOnly = True
        DGW_Tipi.ReadOnly = True
    End Sub

    Private Sub SbloccaDGW()
        DGW_Tipi.ReadOnly = False
        DGW_Tipi.Columns("TipoDataGridViewTextBoxColumn").ReadOnly = True
        DGW_Tipi.Columns("DescrizioneDataGridViewTextBoxColumn").ReadOnly = True

        DGW_Rivestimenti.ReadOnly = False
        DGW_Rivestimenti.Columns("TipoRivestimentoDataGridViewTextBoxColumn").ReadOnly = True
        DGW_Rivestimenti.Columns("DescrizioneDataGridViewTextBoxColumn1").ReadOnly = True

        DGW_Materiali.ReadOnly = False
        DGW_Materiali.Columns("MaterialeDataGridViewTextBoxColumn").ReadOnly = True
        DGW_Materiali.Columns("DescrizioneDataGridViewTextBoxColumn2").ReadOnly = True
        DGW_Materiali.Columns("UMDataGridViewTextBoxColumn").ReadOnly = True
    End Sub

    Private Sub Form_Listino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaterialiTableAdapter.Fill(Me.ModPackDBDataSet.Materiali)
        Me.RivestimentiTableAdapter.Fill(Me.ModPackDBDataSet.Rivestimenti)
        Me.TipiTableAdapter.Fill(Me.ModPackDBDataSet.Tipi)
        BloccaDGW()
    End Sub

    Private Sub BT_Edit_Click(sender As Object, e As EventArgs) Handles BT_Edit.Click
        If MsgBox("Le modifiche al listino andranno a incidere solo sui codici inseriti dal momento della modifica." & vbCrLf & "Sicuro di voler modificare?", vbYesNo, "Modifica") = MsgBoxResult.Yes Then
            SbloccaDGW()
            MsgBox("Modifiche ora attive", vbOKOnly, "Modifica")
        End If
    End Sub

    Private Sub Bt_Salva_Click(sender As Object, e As EventArgs) Handles Bt_Salva.Click
        If MsgBox("Salvare le modifiche?", vbYesNo, "Salva") = MsgBoxResult.Yes Then
            Try
                Me.MaterialiTableAdapter.Update(Me.ModPackDBDataSet.Materiali)
                Me.RivestimentiTableAdapter.Update(Me.ModPackDBDataSet.Rivestimenti)
                Me.TipiTableAdapter.Update(Me.ModPackDBDataSet.Tipi)
                LOG.Write("Modificato listino")
                BloccaDGW()
                MsgBox("Modifiche salvate!", vbOKOnly, "Salva")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub DGW_Tipi_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGW_Tipi.CellEndEdit
        Dim DGW As DataGridView = CType(sender, DataGridView)
        Dim VecchioValore = DGW.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

        If Not DGW.Columns(e.ColumnIndex).ToString.Contains("PREZZO") Then
            DGW.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = VecchioValore
            Exit Sub
        End If

    End Sub

    Private Sub Bt_Annulla_Click(sender As Object, e As EventArgs) Handles Bt_Annulla.Click
        If MsgBox("Annullare tutte le modifiche?", vbYesNo, "Annulla") = MsgBoxResult.Yes Then
            Me.MaterialiTableAdapter.Fill(Me.ModPackDBDataSet.Materiali)
            Me.RivestimentiTableAdapter.Fill(Me.ModPackDBDataSet.Rivestimenti)
            Me.TipiTableAdapter.Fill(Me.ModPackDBDataSet.Tipi)
            BloccaDGW()
        End If
    End Sub
End Class