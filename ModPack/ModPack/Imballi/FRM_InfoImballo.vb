Public Class FRM_InfoImballo

    Dim DS As New ModPackDBDataSet
    Dim TableImballi As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
    Dim TableNote As New ModPackDBDataSetTableAdapters.NoteImballiTableAdapter
    Dim TableIndici As New ModPackDBDataSetTableAdapters.IndiciTableAdapter
    Dim TableRivest As New ModPackDBDataSetTableAdapters.RivestimentiTableAdapter
    Dim TableDistinta As New ModPackDBDataSetTableAdapters.DistintaTableAdapter

    Private Sub Clear()
        Lb_imballo.Text = ""
        Lb_Tipo.Text = ""
        Lb_Zoccoli.Text = ""
        Lbl_L.Text = ""
        Lbl_P.Text = ""
        Lbl_H.Text = ""
        Lb_Creazione.Text = ""

        Ck_Morali.Checked = False
        Ck_DoppiaTav.Checked = False
        Ck_Diagonali.Checked = False
        Ck_Rivestimento.Checked = False
        Ck_Ht.Checked = False

        Lb_Rivestimento.Text = ""
        Lb_m2.Text = ""
        Lb_m3.Text = ""

        Lb_Note.Text = ""
        DG_Distinta.Rows.Clear()

    End Sub

    Public Sub CaricaInfo(ByVal ID As Integer)

        TableImballi.Fill(DS.Imballi)
        TableNote.Fill(DS.NoteImballi)
        TableIndici.Fill(DS.Indici)
        TableRivest.Fill(DS.Rivestimenti)
        TableDistinta.Fill(DS.Distinta)

        Dim Imballo As ModPackDBDataSet.ImballiRow = DS.Imballi.Where(Function(X) X.Id = ID).First

        Clear()

        With Imballo

            For Each Row As ModPackDBDataSet.DistintaRow In DS.Distinta.Where(Function(X) X.Imballo = .Imballo).OrderBy(Function(Z) Z.Riga).ToList
                DG_Distinta.Rows.Add({Row.Part, Row.X, Row.Y, Row.Z, Row.N})
            Next

            Me.Text = .Imballo

            Lb_imballo.Text = .Imballo
            Lb_Tipo.Text = .Tipo
            Lb_Zoccoli.Text = .Zoccoli
            Lbl_L.Text = .L
            Lbl_P.Text = .P
            Lbl_H.Text = .H
            Lb_Creazione.Text = .Data_Creazione
            Lb_m2.Text = .M2
            Lb_m3.Text = .M3

            If .Rivestimento = True Then
                Ck_Rivestimento.Checked = True
                Lb_Rivestimento.Text = DS.Rivestimenti.Where(Function(X) X.Tipo_Rivestimento = .Tipo_Rivestimento).Select(Function(y) y.Descrizione).FirstOrDefault
            End If

            Ck_Morali.Checked = Imballo.BM
            Ck_Diagonali.Checked = Imballo.Diagonali
            Ck_DoppiaTav.Checked = Imballo.DT
            Ck_Ht.Checked = Imballo.HT

            If Not .IsImgNull Then PB_Img.BackgroundImage = Immagine.ConvertFromBytes(.Img)

            For Each Nota As String In DS.NoteImballi.Where(Function(x) x.Imballo = Imballo.Imballo).Select(Function(Y) Y.Nota).ToList
                Lb_Note.Text += Nota & vbCrLf
            Next

            Lst_Disegni.DataSource = DS.Indici.Where(Function(X) X.Imballo = Imballo.Imballo).Select(Function(y) y.Codice).ToList

        End With

        ColoraDGW()

    End Sub



    Private Sub ColoraDGW()

        Dim Col1 As Color = Color.White
        Dim Col2 As Color = Color.PeachPuff

        Dim ValInit As String = DG_Distinta.Rows(0).Cells(0).Value

        Dim Colore As Color = Col1

        For Each row As DataGridViewRow In DG_Distinta.Rows

            If row.Cells(0).Value <> ValInit Then
                If Colore = Col1 Then Colore = Col2 Else Colore = Col1
                ValInit = row.Cells(0).Value
            End If

            row.DefaultCellStyle.BackColor = Colore
        Next



    End Sub


    Private Sub Bt_Modifica_Click(sender As Object, e As EventArgs) Handles Bt_Modifica.Click
        Form_ModificaImballo.Show()
        Form_ModificaImballo.CbImballo.Text = Lb_imballo.Text
        Form_ModificaImballo.CaricaCodiceNoEdit()
    End Sub

    Private Sub Duplica()

    End Sub

End Class