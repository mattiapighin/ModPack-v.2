Public Class Form_ModificaCodice

    Dim DS As New ModPackDBDataSet

    Dim ImballiTable As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
    Dim IndiciTable As New ModPackDBDataSetTableAdapters.IndiciTableAdapter
    Dim OrdiniTable As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
    Dim DistintaTable As New ModPackDBDataSetTableAdapters.DistintaTableAdapter


    Private Sub clear()

        CB_VecchioCodice.Items.Clear()
        CB_VecchioCodice.Text = ""

        Tx_NuovoCodice.Clear()

        CB_VecchioCodice.Enabled = True
        Bt_Cerca.Enabled = True

        Panel_Modifica.Enabled = False
        Lbl_Info.ResetText()
        Ck_TabDistinta.Checked = True
        Ck_TabImballi.Checked = True
        Ck_TabIndici.Checked = True
        Ck_TabOrdini.Checked = True

        Bt_Annulla.Enabled = False

        ImballiTable.Fill(DS.Imballi)
        IndiciTable.Fill(DS.Indici)
        OrdiniTable.Fill(DS.Ordini)
        DistintaTable.Fill(DS.Distinta)

        CB_VecchioCodice.Items.AddRange(DS.Imballi.Select(Function(X) X.Imballo).Distinct.ToArray)
        CB_VecchioCodice.Sorted = True
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()

    End Sub

    Private Sub Bt_Cerca_Click(sender As Object, e As EventArgs) Handles Bt_Cerca.Click

        Dim VecchioCodice As String = CB_VecchioCodice.Text

        'SE L'IMBALLO ESISTE IN ALMENO UNA TABELLA PERMETTE LA MODIFICA
        If DS.Imballi.Any(Function(x) x.Imballo = VecchioCodice) Or
            DS.Distinta.Any(Function(x) x.Imballo = VecchioCodice) Or
            DS.Ordini.Any(Function(x) x.Imballo = VecchioCodice) Or
            DS.Indici.Any(Function(x) x.Imballo = VecchioCodice) Then

            Panel_Modifica.Enabled = True
            CB_VecchioCodice.Enabled = False
            Bt_Cerca.Enabled = False
            Bt_Annulla.Enabled = True

            Dim RigheOrdine As Integer = DS.Ordini.Where(Function(X) X.Imballo = VecchioCodice).Count
            Dim RigheIndici As Integer = DS.Indici.Where(Function(X) X.Imballo = VecchioCodice).Count
            Dim RigheImballi As Integer = DS.Imballi.Where(Function(X) X.Imballo = VecchioCodice).Count
            Dim RigheDistinta As Integer = DS.Distinta.Where(Function(X) X.Imballo = VecchioCodice).Count

            Lbl_Info.Text = CB_VecchioCodice.Text & " è associato a: " &
                vbCrLf & RigheOrdine & " righe ordine" &
                vbCrLf & RigheIndici & " indici" &
                vbCrLf & RigheImballi & " imballi" &
                vbCrLf & RigheDistinta & " righe distinta"

            Progress.Value = 0
            Progress.Maximum = RigheOrdine + RigheIndici + RigheImballi + RigheDistinta

        Else

            Panel_Modifica.Enabled = False

        End If
    End Sub

    Private Sub BT_Start_Click(sender As Object, e As EventArgs) Handles BT_Start.Click

        Try

            Dim VecchioCodice As String = CB_VecchioCodice.Text
            Dim NuovoCodice As String = Tx_NuovoCodice.Text


            If ControlloCodice(NuovoCodice) = True Then
                If MsgBox("Sicuro di voler procedere con la modifica?" & vbCrLf & VecchioCodice & " --> " & NuovoCodice, vbYesNo, "Modifica") = MsgBoxResult.Yes Then

                    'MODIFICA SU TABELLA ORDINI
                    If Ck_TabOrdini.Checked = True Then

                        For Each Row As ModPackDBDataSet.OrdiniRow In DS.Ordini
                            If Row.Imballo = VecchioCodice Then Row.Imballo = NuovoCodice
                        Next

                        OrdiniTable.Update(DS.Ordini)
                        MsgBox("Tabella ORDINI aggiornata!", vbInformation, "Modifica codice")
                    End If

                    'MODIFICA SU TABELLA IMBALLI
                    If Ck_TabImballi.Checked = True Then

                        For Each Row As ModPackDBDataSet.ImballiRow In DS.Imballi
                            If Row.Imballo = VecchioCodice Then Row.Imballo = NuovoCodice
                        Next

                        ImballiTable.Update(DS.Imballi)
                        MsgBox("Tabella IMBALLI aggiornata!", vbInformation, "Modifica codice")
                    End If

                    'MODIFICA SU TABELLA INDICI
                    If Ck_TabIndici.Checked = True Then

                        For Each Row As ModPackDBDataSet.IndiciRow In DS.Indici
                            If Row.Imballo = VecchioCodice Then Row.Imballo = NuovoCodice
                        Next

                        IndiciTable.Update(DS.Indici)
                        MsgBox("Tabella INDICI aggiornata!", vbInformation, "Modifica codice")
                    End If

                    'MODIFICA SU TABELLA DISTINTA
                    If Ck_TabDistinta.Checked = True Then

                        For Each Row As ModPackDBDataSet.DistintaRow In DS.Distinta
                            If Row.Imballo = VecchioCodice Then Row.Imballo = NuovoCodice
                        Next

                        DistintaTable.Update(DS.Distinta)
                        MsgBox("Tabella DISTINTA aggiornata!", vbInformation, "Modifica codice")
                    End If

                End If

                MsgBox("Aggiornamento completato!", vbInformation, "Modifica codice")
                clear()
            Else
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function ControlloCodice(ByVal Codice As String) As Boolean
        Dim CodiceOK As Boolean = True

        If Codice.StartsWith("MC") Or Codice.StartsWith("MP") Or Codice.StartsWith("MG") Then
            CodiceOK = False
            MsgBox("Il nuovo codice non può iniziare con MC, MP o MG")
        End If

        If String.IsNullOrEmpty(Codice) Then
            CodiceOK = False
            MsgBox("Il nuovo codice non può essere vuoto")
        End If

        If DS.Imballi.Any(Function(X) X.Imballo = Codice) = True Then
            CodiceOK = False
            MsgBox("Il nuovo codice è già presente in memoria")
        End If

        Return CodiceOK
    End Function

    Private Sub Bt_Annulla_Click(sender As Object, e As EventArgs) Handles Bt_Annulla.Click
        clear()
    End Sub
End Class