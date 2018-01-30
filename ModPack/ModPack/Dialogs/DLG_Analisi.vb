Public Class DLG_Analisi

    Dim Dati As New List(Of Decimal)
    Dim Giorni As New List(Of String)
    Dim Ore As New List(Of String)

    Dim NumeroValori As Integer = 100
    Dim SecondoScala As Integer = 1

    Private Function Scala(ByVal Valore) As Integer
        Return Grafico.Height * Valore / SecondoScala
    End Function

    Private Sub DLG_Analisi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AnalysisTable.Fill(DS.Analysis)
        Analysis_DescrizioneTable.Fill(DS.Analysis_Descrizione)

        'Carica listbox con utenti
        LST_Utenti.DataSource = Nothing
        LST_Utenti.DataSource = DS.Analysis.Select(Function(X) X.Utente).Distinct.ToList


        DGW_Parametri.Rows.Clear()

        For Each Row As ModPackDBDataSet.Analysis_DescrizioneRow In DS.Analysis_Descrizione
            DGW_Parametri.Rows.Add({Row.Parametro, Row.Descrizione})
        Next


        NumeroValori = NU_Valori.Value

    End Sub

    Private Sub CaricaDati()
        Dati.Clear()

        NumeroValori = NU_Valori.Value

        Dim ListaValori As New List(Of ModPackDBDataSet.AnalysisRow)
        ListaValori = DS.Analysis.Where(Function(X) X.Utente = LST_Utenti.SelectedItem).Where(Function(y) y.Parametro = DGW_Parametri.Rows(DGW_Parametri.CurrentRow.Index).Cells(0).Value).ToList

        'Prende gli ultimi N valori dalle registrazioni prestazione dell'utente selezionato
        For Each Row As ModPackDBDataSet.AnalysisRow In ListaValori.Skip(ListaValori.Count - NumeroValori).ToList
            Dati.Add(Row.Valore)
            Ore.Add(Row.DataOra.Hour.ToString("D2") & "." & Row.DataOra.Minute.ToString("D2") & "." & Row.DataOra.Second.ToString("D2"))
            Giorni.Add(Row.DataOra.Day.ToString("D2") & "/" & Row.DataOra.Month.ToString("D2") & "/" & Row.DataOra.Year.ToString("D2"))
        Next

    End Sub

    Private Sub Bt_Mostra_Click(sender As Object, e As EventArgs) Handles Bt_Mostra.Click
        SecondoScala = Math.Ceiling(DS.Analysis.Where(Function(x) x.Parametro = DGW_Parametri.Rows(DGW_Parametri.CurrentRow.Index).Cells(0).Value).Select(Function(y) y.Valore).Max) + 1

        CaricaDati()
        Disegna()
    End Sub

    Private Sub Disegna()

        NumeroValori = NU_Valori.Value

        Dim G As Graphics = Grafico.CreateGraphics

        If Not CK_Sovrapponi.Checked Then G.Clear(Color.White)

        Dim PuntoGrafico As New Point(0, 300)

        For K = 0 To NumeroValori

            Dim P As Decimal = (Grafico.Width \ NumeroValori) * K

            If K > 0 Then
                G.DrawLine(Pens.LightGray, P, 0, P, Grafico.Height)
            End If

            If K < Dati.Count Then

                Dim H_etichette As Integer = 300 - Scala(Dati(K)) - 20
                If H_etichette <= 0 Then H_etichette = 300 - Scala(Dati(K)) + 20


                If Ck_Etichette.Checked Then G.DrawString(Dati(K) & "s", Font, Brushes.Black, P, H_etichette)
                If Ck_MostraData.Checked Then G.DrawString(Giorni(K), New Font("calibri", 8), Brushes.Black, P, 275)
                If Ck_MostraOra.Checked Then G.DrawString(Ore(K), New Font("calibri", 8), Brushes.Black, P, 285)

                If K > 0 Then
                    G.DrawLine(New Pen(Color.Red, 2), PuntoGrafico.X, PuntoGrafico.Y, P, 300 - Scala(Dati(K)))
                End If
                PuntoGrafico.X = P
                PuntoGrafico.Y = 300 - Scala(Dati(K))
            End If


        Next


    End Sub
End Class