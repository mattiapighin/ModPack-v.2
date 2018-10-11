Public Class Form_Memo
    Private Sub RbData_CheckedChanged(sender As Object, e As EventArgs) Handles RbData.CheckedChanged
        DatePicker.Enabled = RbData.Checked

    End Sub

    Private Sub Bt_Ok_Click(sender As Object, e As EventArgs) Handles Bt_Ok.Click
        If TxtMemo.Text <> "" Then
            Try
                Dim Table As New ModPackDBDataSetTableAdapters.MemoTableAdapter
                Dim DS As New ModPackDBDataSet.MemoDataTable

                If RbData.Checked = True Then
                    Table.Insert(DatePicker.Value, TxtMemo.Text, Nothing)
                Else
                    Table.Insert(Nothing, TxtMemo.Text, "")
                End If

                Table.Update(DS)

                MsgBox("Memo salvato!", vbInformation, "Memo")

                DatePicker.Value = Date.Today

                TxtMemo.Text = ""

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub



    Private Sub Bt_Agenda_Click(sender As Object, e As EventArgs) Handles Bt_Agenda.Click
        Form_Agenda.Show()
    End Sub

    Private Sub Form_Memo_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Main.CaricaMemo()
    End Sub
End Class