﻿Namespace Imballo
    Module Funzioni_Distinte

        Public Function GetTipo(ByVal Tipo As String) As Tipo
            'Popola un oggetto TIPO con le sue proprietà in base alla stringa passata (es. G, P, GDA)
            Dim Oggetto As New Tipo

            Using TipiTable As New ModPackDBDataSetTableAdapters.TipiTableAdapter
                Using DS As New ModPackDBDataSet.TipiDataTable

                    TipiTable.Fill(DS)

                    Dim ROW As ModPackDBDataSet.TipiRow = DS.Where(Function(x) x.Tipo = Tipo).FirstOrDefault

                    Oggetto.Tipo = ROW.Tipo
                    If Not ROW.IsDescrizioneNull Then Oggetto.Descrizione = ROW.Descrizione
                    Oggetto.InterasseMax = ROW.InterasseMax
                    Oggetto.SpazioBTL = ROW.SpazioBTL
                    Oggetto.SpazioBTT = ROW.SpazioBTT
                    Oggetto.SpazioCTL = ROW.SpazioCTL
                    Oggetto.SpazioFTL = ROW.SpazioFTL
                    Oggetto.SpazioMT = ROW.SpazioMT
                    If Not ROW.IsInfoNull Then Oggetto.Info = ROW.Info
                    Oggetto.PrezzoM3 = ROW.PrezzoM3


                End Using
            End Using

            Return Oggetto
        End Function

        Public Function CalcoloPrimoMorale(L)
            'Calcola la quota del primo morale in base alla lunghezza della gabbia
            Dim Quota As Integer

            If L <= 50 Then Quota = 0
            If L > 50 And L < 100 Then Quota = 10
            If L >= 100 Then Quota = 20

            Return Quota

        End Function
        Public Function NumeroMorali(BTL, PrimoMorale, interasseMAX)
            Dim N As Integer = 1
            Dim Interasse As Single = interasseMAX + 10

            Do Until Interasse < interasseMAX
                N += 1
                Interasse = (BTL - (PrimoMorale * 2)) / (N - 1)
            Loop

            If BTL <= 150 Then N = 3
            If BTL <= 100 Then N = 2

            Return N
        End Function
        Public Function NumeroTavoleSopra(Interasse, interasseMAX)
            Dim N As Integer = 0

            Do Until Interasse < interasseMAX
                N += 1
                Interasse = (Interasse / (N + 1))
            Loop

            Return N
        End Function
        Public Function NumeroTavole(Superficie, SpazioMAX, Ltav)
            Dim N As Integer = 1
            Dim Spazio As Single = SpazioMAX + 100

            Do Until Spazio < SpazioMAX
                N += 1
                Spazio = (Superficie - (N * Ltav)) / (N - 1)
            Loop

            Return N
        End Function

        Function Diagonali_lunghezza(Base, Altezza, Ltav)
            Dim IPO As Object
            Dim Ltav1 As Object
            Dim radIPO As Object
            Dim radTAV As Object
            Dim radTOT As Object
            Dim GRADI As Object

            Dim A As Integer = Altezza

            IPO = Math.Sqrt((A ^ 2) + (Base ^ 2))
            Ltav1 = Math.Sqrt((IPO ^ 2) - (Ltav ^ 2))
            radIPO = Math.Atan(Base / A)
            radTAV = Math.Atan(Ltav / Ltav1)
            radTOT = radIPO - radTAV

            GRADI = radTOT * 180 / Math.PI

            If Ltav1 < 0 Then Ltav1 = 0

            Return Ltav1
        End Function
        Function Diagonali_gradi(Base, Altezza, Ltav)
            Dim IPO As Object
            Dim Ltav1 As Object
            Dim radIPO As Object
            Dim radTAV As Object
            Dim radTOT As Object
            Dim GRADI As Object

            IPO = Math.Sqrt((Altezza ^ 2) + (Base ^ 2))
            Ltav1 = Math.Sqrt((IPO ^ 2) - (Ltav ^ 2))
            radIPO = Math.Atan(Base / Altezza)
            radTAV = Math.Atan(Ltav / Ltav1)
            radTOT = radIPO - radTAV

            GRADI = radTOT * 180 / Math.PI
            If GRADI < 0 Then GRADI = 0

            Dim xml = XDocument.Load(My.Settings.XMLpath)

            If xml.<Data>.<Diagonali>.<Inverti>.Value = "True" Then
                If GRADI > xml.<Data>.<Diagonali>.<Max_Gradi>.Value Then

                    Dim BaseRov = Altezza
                    Dim AltezzaRov = Base

                    IPO = Math.Sqrt((AltezzaRov ^ 2) + (BaseRov ^ 2))
                    Ltav1 = Math.Sqrt((IPO ^ 2) - (Ltav ^ 2))
                    radIPO = Math.Atan(BaseRov / AltezzaRov)
                    radTAV = Math.Atan(Ltav / Ltav1)
                    radTOT = radIPO - radTAV

                    GRADI = radTOT * 180 / Math.PI

                End If
            End If

            Return GRADI
        End Function

        Function Ricalcolo_M3_Morali(ByVal Imballo As String) As Single

            Dim M3 As Single

            Dim TABLE As New ModPackDBDataSet.DistintaDataTable
            Using DA As New ModPackDBDataSetTableAdapters.DistintaTableAdapter
                DA.Fill(TABLE)
            End Using



            For Each Row As ModPackDBDataSet.DistintaRow In TABLE.Where(Function(x) x.Imballo = Imballo And x.Tag = "MOR")
                'If Row.Imballo = Imballo Then
                'If Row.Tag = "MOR" Then
                M3 = (Row.X * Row.Y * Row.Z) * Row.N
                '    End If
                'End If
            Next

            M3 = M3 * 10 ^ (-6)

            Return Math.Round(M3, 3)
        End Function
        Function Ricalcolo_M3(ByVal Imballo As String) As Single

            Dim M3 As Single

            Dim TABLE As New ModPackDBDataSet.DistintaDataTable
            Using DA As New ModPackDBDataSetTableAdapters.DistintaTableAdapter
                DA.Fill(TABLE)
            End Using



            For Each Row As ModPackDBDataSet.DistintaRow In TABLE.Where(Function(x) x.Imballo = Imballo)
                ' If Row.Imballo = Imballo Then

                Dim M3Riga As Single = (Row.X * Row.Y * Row.Z) * Row.N
                    M3 += M3Riga

                'End If
            Next

            M3 = M3 * 10 ^ (-6)

            Return Math.Round(M3, 3)
        End Function
        Function Ricalcolo_M2(ByVal Imballo As String) As Single
            Dim M2 As Double

            Dim TABLE As New ModPackDBDataSet.ImballiDataTable
            Using DA As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
                DA.Fill(TABLE)
            End Using

            For Each Row As ModPackDBDataSet.ImballiRow In TABLE.Where(Function(x) x.Imballo = Imballo)
                'If Row.Imballo = Imballo Then

                Dim L As Integer = Row.L
                    Dim P As Integer = Row.P
                    Dim H As Integer = Row.H


                    M2 = ((L * P) + (L * H) + (P * H)) * 2
                    M2 = Math.Round(M2 * 10 ^ (-4), 2)

                'End If
            Next


            Return Math.Round(M2, 3)
        End Function
        Function Ricalcolo_Prezzo(ByVal Imballo As String) As Single
            Dim prezzo As Single

            Dim Tipo As String = ""
            Dim PrezzoMateriale As Single = 0
            Dim PrezzoRivestimento As Single = 0
            Dim HT As Boolean
            Dim Riv As Boolean
            Dim TipoRivestimento As String = ""
            Dim M3 As Single = 0
            Dim M2 As Single = 0

            Dim TableImballi As New ModPackDBDataSet.ImballiDataTable
            Using DA As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
                DA.Fill(TableImballi)
            End Using

            For Each Row As ModPackDBDataSet.ImballiRow In TableImballi.Where(Function(x) x.Imballo = Imballo)
                    'If Row.Imballo = Imballo Then
                    Tipo = Row.Tipo
                        M3 = Row.M3
                        M2 = Row.M2
                        HT = Row.HT
                        Riv = Row.Rivestimento
                        TipoRivestimento = Row.Tipo_Rivestimento
                        Exit For
                    'End If
                Next


                Dim TableTipi As New ModPackDBDataSet.TipiDataTable
            Using DA As New ModPackDBDataSetTableAdapters.TipiTableAdapter
                DA.Fill(TableTipi)

                For Each Row As ModPackDBDataSet.TipiRow In TableTipi.Where(Function(X) X.Tipo = Tipo)
                    ' If Row.Tipo = Tipo Then

                    If HT = True Then
                            PrezzoMateriale = Row.PrezzoM3HT
                        Else
                            PrezzoMateriale = Row.PrezzoM3
                        End If

                    'End If
                Next
            End Using

            If Riv = True Then
                Dim TableRivestimenti As New ModPackDBDataSet.RivestimentiDataTable
                Using DA As New ModPackDBDataSetTableAdapters.RivestimentiTableAdapter
                    DA.Fill(TableRivestimenti)

                    For Each Row As ModPackDBDataSet.RivestimentiRow In TableRivestimenti.Where(Function(x) x.Tipo_Rivestimento = TipoRivestimento)
                        'If Row.Tipo_Rivestimento = TipoRivestimento Then
                        PrezzoRivestimento = Row.Prezzo_m2
                        'End If
                    Next
                End Using
            End If

            prezzo = (PrezzoMateriale * M3) + (PrezzoRivestimento * M2)

            Return Math.Round(prezzo, 1)
        End Function

        Function CalcoloDiagonaliF(Nmorali As Integer) As Integer
            Dim Ndiag As Integer

            If Nmorali Mod 2 = 0 Then
                Ndiag = Nmorali
            Else

                Select Case Nmorali
                    Case < 6
                        Ndiag = 4
                    Case > 6 And Nmorali < 10
                        Ndiag = 8
                    Case > 10
                        Ndiag = (Nmorali - 1) * 2
                End Select

            End If

            Return Ndiag
        End Function

        Function CalcoloZoccoli(ByVal LunghezzaTelarino As Integer) As Integer
            Dim N As Integer

            Dim QT As Integer = 1

            Dim xml = XDocument.Load(My.Settings.XMLpath)
            Dim SpazioMax As Integer = xml.<Data>.<Dist_Zoccoli>.Value
            Dim SpazioAtt As Integer = SpazioMax + 10

            Do Until SpazioAtt <= SpazioMax
                QT += 1
                SpazioAtt = (LunghezzaTelarino - (QT * 10)) / (QT - 1)
            Loop

            N = QT

            Return N
        End Function

        Function Get_Tavole_SpazioMassimo(ByVal Superficie As Integer, ByVal LarghezzaTavola As Integer, ByVal SpazioMassimo As Integer)

            Dim N As Integer = 0
            Dim SpazioReale = Superficie
            Dim SpazioTarget As Integer = SpazioReale

            'Calcola il numero di tavole da inserire in una determinata misura per arrivare allo spazio max diviso tra di esse
            'e lasciando uno spazio prima e uno dopo

            Do While SpazioTarget > SpazioMassimo
                N += 1
                SpazioTarget = (SpazioReale - (LarghezzaTavola * N)) / (N + 1)
            Loop

            Debug.WriteLine("Calcolato spazio: N.Tavole " & N & " - Spazio: " & SpazioTarget)
            Return N

        End Function
        Function MoraliCasse(ByVal L As Integer, ByVal SpazioMassimo As Integer)

            Dim N As Integer = 2


            Do While ((L - 12) / (N - 1)) > SpazioMassimo
                N += 1
            Loop

            Return N

        End Function

    End Module
End Namespace
