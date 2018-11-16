Namespace DEV
    Module MDL_Dev

        Sub Modifica_GDA_24102018()
            'Aggiunte 2 tavole sulle teste di tutte le GDA senza ricalcolare m3

            Dim DS As New ModPackDBDataSet
            Dim DistintaTable As New ModPackDBDataSetTableAdapters.DistintaTableAdapter
            Dim ImballiTable As New ModPackDBDataSetTableAdapters.ImballiTableAdapter

            ImballiTable.Fill(DS.Imballi)
            DistintaTable.Fill(DS.Distinta)

            Dim ListaGDA As New List(Of ModPackDBDataSet.ImballiRow)
            ListaGDA = DS.Imballi.Where(Function(X) X.Tipo = "GDA").ToList

            For Each GDA As ModPackDBDataSet.ImballiRow In ListaGDA

                Dim RigaTeste As ModPackDBDataSet.DistintaRow = DS.Distinta.Where(Function(X) X.Imballo = GDA.Imballo).Where(Function(y) y.Tag = "TTL").First
                Dim RigaFiancate As ModPackDBDataSet.DistintaRow = DS.Distinta.Where(Function(X) X.Imballo = GDA.Imballo).Where(Function(y) y.Tag = "FTL").First

                Dim VecchioValore As Integer = RigaTeste.N
                Dim NuovoValore As Integer = RigaFiancate.N

                'Modifica immagine
                GDA.Img = Immagine.ConvertToBytes(My.Resources.GDA2)
                Debug.WriteLine("Modificata immagine " & GDA.Imballo)
                'Modifica quantità
                RigaTeste.N = RigaFiancate.N
                Debug.WriteLine("Modificato " & GDA.Imballo & " da: " & VecchioValore & " a: " & NuovoValore)

            Next

            DistintaTable.Update(DS.Distinta)
            ImballiTable.Update(DS.Imballi)

        End Sub

    End Module
End Namespace