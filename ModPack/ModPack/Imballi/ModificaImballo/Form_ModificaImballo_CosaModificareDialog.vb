Public Class Form_ModificaImballo_CosaModificareDialog

    Public Ric_M2 As Boolean
    Public Ric_M3 As Boolean
    Public Ric_Prz As Boolean


    Private Sub Bt_Salva_Click(sender As Object, e As EventArgs) Handles Bt_Salva.Click

        Ric_M2 = Ck_RicalcoloM2.Checked
        Ric_M3 = Ck_RicalcoloM3.Checked
        Ric_Prz = Ck_RicalcoloPrezzo.Checked

        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub
End Class