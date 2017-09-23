Public Class NuovoImballo

    '########## CREAZIONE DI UN NUOVO TIPO DI IMBALLO: ISTRUZIONI ##########
    '1) Creare la sua funzione per la distinta se necessario su (Distinte\Creazione Distinte\Nuovoimballo)
    '2) Aggiungere Tipo al Select Case (NUOVOIMBALLO/CREA DA ORDINE)
    '3) Aggiungere il tipo al select case (MODIFICA IMBALLO/ BT-SALVA CLICK)
    '4) Creare la sua funzione per il prezzo se necessario su (Distinte\Module_Prezzi)
    '5) Se si vuole inserire un'immagine personalizzata caricarla nelle resources e inserire in (NUOVOIMBALLO\INSERTIMBALLO)
    '#######################################################################

    '1. CREARE DISTINTA
    '2. CREARE RIGA IMBALLO
    '3. CREARE RIGA INDICE

    Private _RigaOrdine As RigaOrdineINPUT
    Public Property RigaOrdine() As RigaOrdineINPUT
        Get
            Return _RigaOrdine
        End Get
        Set(ByVal value As RigaOrdineINPUT)
            _RigaOrdine = value
        End Set
    End Property

    Dim Distinta As New List(Of Riga_Distinta)

    Private R_NomeImballo As String
    Public Property Nome() As String
        Get
            Return R_NomeImballo
        End Get
        Set(value As String)
            R_NomeImballo = value
        End Set
    End Property

    Private R_Riga As Integer
    Private R_Indice As Integer
    Private R_Qt As Integer
    Private R_Cliente As String
    Private R_Codice As String
    Private R_Commessa As String
    Private R_Lunghezza As Integer
    Private R_Profondità As Integer
    Private R_Altezza As Integer
    Private R_Type As String
    Private R_Zoccoli As String
    Private R_Rivestimento As Boolean
    Private R_TipoRivestimento As String
    Private R_Note As String
    Private R_DataConsegna As String
    Private R_HT As Boolean
    Private R_DT As Boolean
    Private R_BM As Boolean
    Private R_Rivest_Tot As String
    Private R_Diagonali As Boolean
    Private R_GradiF As Integer
    Private R_GradiT As Integer
    Private R_PrimoMOR As Integer
    Private R_M2 As Single
    Private R_M3 As Single
    Private R_Prezzo As Single
    Private R_SottoMF As Decimal
    Private R_SottoMT As Decimal
    Private R_SopraMF As Decimal
    Private R_SopraMT As Decimal

    Private Sub CaricaVariabiliDaOrdine()
        Try
            R_Riga = _RigaOrdine.Riga
            R_Indice = _RigaOrdine.Indice
            R_Qt = _RigaOrdine.Qt
            R_Cliente = _RigaOrdine.Cliente
            R_Codice = _RigaOrdine.Codice
            R_Commessa = _RigaOrdine.Commessa
            R_Lunghezza = _RigaOrdine.L
            R_Profondità = _RigaOrdine.P
            R_Altezza = _RigaOrdine.H
            R_Type = _RigaOrdine.Tipo
            R_Zoccoli = _RigaOrdine.Zoccoli
            R_Rivestimento = _RigaOrdine.Rivestimento
            R_TipoRivestimento = _RigaOrdine.TipoRivestimento
            R_Note = _RigaOrdine.Note
            R_DataConsegna = _RigaOrdine.DataConsegna
            R_HT = _RigaOrdine.HT
            R_DT = _RigaOrdine.DT
            R_BM = _RigaOrdine.BM
            R_Rivest_Tot = _RigaOrdine.Rivest_Tot
            R_Diagonali = _RigaOrdine.Diagonali
        Catch ex As Exception
            Errore.Show("CaricaVariabiliDaOrdine \ NuovoImballo", ex.Message)
        End Try

    End Sub

    Public Sub CreaDaOrdine(ByVal RigaOrdine As RigaOrdineINPUT, Optional _InsertDistinta As Boolean = True, Optional _InsertImballo As Boolean = True, Optional _InsertIndice As Boolean = True)
        Try

            CaricaVariabiliDaOrdine()

            Debug.WriteLine("(## Creazione nuovo imballo " & R_NomeImballo & " Tipo: " & R_Type & " Dimensioni " & R_Lunghezza & " x " & R_Profondità & " x " & R_Altezza & " ##)")

            Select Case R_Type
                Case "GDA"
                    Distinta = Crea_GDA(R_Lunghezza, R_Profondità, R_Altezza, R_Type, R_Zoccoli, R_DT, R_BM, R_Diagonali, R_HT)
                Case "G"
                    Distinta = Crea_G(R_Lunghezza, R_Profondità, R_Altezza, R_Type, R_Zoccoli, R_DT, R_BM, R_Diagonali, R_HT)
                Case "P"
                    Distinta = Crea_P_T(R_Lunghezza, R_Profondità, 0, R_Type, R_Zoccoli, R_DT, R_BM, R_Diagonali, R_HT)
                Case "T"
                    Distinta = Crea_P_T(R_Lunghezza, R_Profondità, 0, R_Type, R_Zoccoli, R_DT, R_BM, R_Diagonali, R_HT)
                Case "GST"
                    Distinta = Crea_GST(R_Lunghezza, R_Profondità, R_Altezza, R_Type, R_Zoccoli, R_DT, R_BM, R_Diagonali, R_HT)
                Case "C"
                    Distinta = Crea_C(R_Lunghezza, R_Profondità, R_Altezza, R_Type, R_Zoccoli, R_DT, R_BM, R_Diagonali, R_HT)
                Case "CL"
                    Distinta = Crea_C(R_Lunghezza, R_Profondità, R_Altezza, R_Type, R_Zoccoli, R_DT, R_BM, R_Diagonali, R_HT)
                Case "GRO"
                    Distinta = Crea_GRO(R_Lunghezza, R_Profondità, R_Altezza, R_Type, R_Zoccoli, R_DT, R_BM, R_Diagonali, R_HT)
                Case Else
                    MsgBox("Tipo non riconosciuto (" & R_Type & ")")
                    Exit Sub
            End Select


            If _InsertDistinta = True Then
                InsertDistinta()
            End If

            If _InsertImballo = True Then
                InsertImballo()
            End If

            If _InsertIndice = True Then
                InsertIndice()
            End If

        Catch ex As Exception
            Errore.Show("CreaDaOrdine \ NuovoImballo", ex.Message)
        End Try

    End Sub

    Private Sub InsertDistinta()
        Try
            Using DA As New ModPackDBDataSetTableAdapters.DistintaTableAdapter

                Dim I As Integer = 1
                For Each R As Riga_Distinta In Distinta
                    DA.Insert(R_NomeImballo, I, R.Part.ToUpper, R.X, R.Y, R.Z, R.N, R.Tag.ToUpper)
                    I += 1
                Next

                I = 0
                Distinta.Clear()

            End Using
        Catch ex As Exception
            Errore.Show("Inserimento distinta " & R_NomeImballo & " riga (" & R_Riga & ")", ex.Message)
        End Try

    End Sub
    Private Sub InsertImballo()
        Try

            If My.Settings.CheckInserimentoImballo = True Then
                MsgBox("Inserimento imballo " & R_NomeImballo & vbCrLf &
                       "L " & R_Lunghezza & " P " & R_Profondità & " H " & R_Altezza & vbCrLf &
                       "Tipo: & " & R_Type & vbCrLf & "Zoccoli: " & R_Zoccoli & vbCrLf & "Rivestimento: " & R_Rivestimento & " " & R_TipoRivestimento & vbCrLf &
                       "HT:" & R_HT & vbCrLf & "DT: " & R_DT & " BM: " & R_BM & vbCrLf &
                       "Diagonali: " & R_Diagonali & " F° " & R_GradiF & " T° " & R_GradiT & vbCrLf &
                       "Primo Morale: " & R_PrimoMOR & vbCrLf &
                       "M3: " & R_M3 & " M2: " & R_M2 & " € " & R_Prezzo, vbOKOnly, R_NomeImballo)
            End If

            Dim IMG As Byte() = Nothing
            If R_Type = "GDA" Then IMG = Immagine.ConvertToBytes(My.Resources.GDA)
            If R_Type = "GST" Then IMG = Immagine.ConvertToBytes(My.Resources.GST)
            If R_Type = "GRO" Then IMG = Immagine.ConvertToBytes(My.Resources.ROV)

            Using DA As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
                DA.Insert(R_NomeImballo, R_Lunghezza, R_Profondità, R_Altezza, R_Type, R_Zoccoli, R_Rivestimento, R_TipoRivestimento, R_HT, R_DT, R_BM, R_Diagonali, R_GradiF, R_GradiT, R_PrimoMOR, R_M2, R_M3, R_Prezzo, IMG, Date.Today.Date, R_SottoMF, R_SottoMT, R_SopraMF, R_SopraMT)
            End Using

        Catch ex As Exception
            Errore.Show("Inserimento imballo " & R_NomeImballo & " riga (" & R_Riga & ")", ex.Message)
        End Try
    End Sub
    Private Sub InsertIndice()
        Try

            Using DT As New ModPackDBDataSetTableAdapters.IndiciTableAdapter
                DT.Insert(R_NomeImballo, R_Indice, R_Codice, R_Note, R_Rivest_Tot, "")
            End Using

        Catch ex As Exception
            Errore.Show("Inserimento indice " & R_NomeImballo & " riga (" & R_Riga & ")", ex.Message)
        End Try

    End Sub

    Private Function CalcoloM3(ByVal LIST As List(Of Riga_Distinta)) As Single
        Dim M3 As Single

        Try


            For Each R As Riga_Distinta In LIST
                M3 += (R.X * R.Y * R.Z * R.N)
            Next

            M3 = Math.Round(M3 * 10 ^ (-6), 3)

        Catch ex As Exception
            Errore.Show("Calcolo M3 " & R_NomeImballo, ex.Message)
        End Try



        Return M3
    End Function
    Private Function CalcoloM2(L, P, H) As Single
        Dim M2 As Single

        Try

            M2 = ((L * P) + (L * H) + (P * H)) * 2
            M2 = Math.Round(M2 * 10 ^ (-4), 2)

        Catch EX As Exception
            Errore.Show("Calcolo M2 " & R_NomeImballo, EX.Message)
        End Try


        Return M2
    End Function


    '############################# CREAZIONE DISTINTE #############################
    Private Function Crea_G(L, P, H, Type, Zoccoli, DT, BM, Diagonali, HT) As List(Of Riga_Distinta)


        Dim D As New List(Of Riga_Distinta)
        D.Clear()

        Try

            Dim TIPO As Tipo = Imballo.GetTipo(Type)

            Dim Ltav As Integer = 10
            If L <= My.Settings.LimiteTavole8 Then Ltav = 8

            Dim MontanteSottoF As Decimal = -3.6
            Dim MontanteSottoT As Decimal = -3.6

            '############ BANCALE ############

            Dim Primomorale As Integer = Imballo.CalcoloPrimoMorale(L + 4)
            Dim NMorali As Integer = Imballo.NumeroMorali(L + 4, Primomorale, TIPO.InterasseMax)
            Dim NBTL As Integer = Imballo.NumeroTavole(P + 4, TIPO.SpazioBTL, Ltav)

            Select Case Zoccoli
                Case "2V"
                    Dim Mor As New Riga_Distinta With {.X = 5, .Y = 10, .Z = (P + 4), .N = NMorali, .Tag = "Mor", .Part = "B"}
                    D.Add(Mor)

                Case "EUR"
                    Dim TTB As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (P + 4), .N = NMorali, .Tag = "TTB", .Part = "B"}
                    Dim ZOC As New Riga_Distinta With {.X = 10, .Y = 8, .Z = 10, .N = NMorali * 3, .Tag = "ZOC", .Part = "B"}
                    Dim TTT As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (P + 4), .N = NMorali, .Tag = "TTT", .Part = "B"}
                    D.AddRange({TTB, ZOC, TTT})
            End Select

            Dim BTL As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (L + 4), .N = NBTL, .Tag = "BTL", .Part = "B"}

            If DT = True Then
                BTL.N *= 2
                MontanteSottoF = 5
                MontanteSottoT = 5
            End If

            If BM = True Then
                BTL.Y = 5
                MontanteSottoF = 5
                MontanteSottoT = 5
            End If

            D.Add(BTL)

            Dim InterasseMaxTavoleTraIMorali As Integer = TIPO.SpazioBTT

            Dim InterasseMorali As Single = (BTL.Z - (Primomorale * 2)) / (NMorali - 1)
            Dim TavoleTraIMorali As Integer = (Imballo.NumeroTavoleSopra(InterasseMorali, InterasseMaxTavoleTraIMorali)) * (NMorali - 1)


            Dim BTT As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (P + 4), .N = NMorali + TavoleTraIMorali + 2, .Tag = "BTT", .Part = "B"}
            D.Add(BTT)


            '############ COPERCHIO ############

            Dim CTL As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = L + 8, .N = Imballo.NumeroTavole(P + 8, TIPO.SpazioCTL, Ltav), .Tag = "CTL", .Part = "C"}
            Dim CTT As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = P + 8, .N = NMorali, .Tag = "CTT", .Part = "C"}

            D.AddRange({CTL, CTT})

            Dim SpazioFraMontantiF As Integer = (((L + 4) - (Primomorale * 2)) / (NMorali - 1)) - Ltav
            Dim SpazioFraMontantiT As Integer = (P + 4 - (Imballo.NumeroTavole(P, TIPO.SpazioMT, Ltav) * Ltav)) \ (Imballo.NumeroTavole(P, TIPO.SpazioMT, Ltav) - 1)

            Dim LdiagF As Integer = Imballo.Diagonali_lunghezza(SpazioFraMontantiF, H, Ltav)
            Dim GRADIdiagF As Single = Imballo.Diagonali_gradi(SpazioFraMontantiF, H, Ltav)

            Dim NdiagF As Integer = Imballo.CalcoloDiagonaliF(NMorali)

            Dim LdiagT As Integer = Imballo.Diagonali_lunghezza(SpazioFraMontantiT, H, Ltav)
            Dim GRADIdiagT As Single = Imballo.Diagonali_gradi(SpazioFraMontantiT, H, Ltav)
            Dim NdiagT As Single = Imballo.NumeroTavole(P, TIPO.SpazioMT, Ltav)

            'se spazio maggiore di x diagonali si

            If Imballo.NumeroTavole(P, TIPO.SpazioMT, Ltav) Mod 2 <> 0 Then
                NdiagT = 0
            End If

            If GRADIdiagF < 0 Then GRADIdiagF = 0
            If GRADIdiagT < 0 Then GRADIdiagT = 0

            If Diagonali = False Then
                GRADIdiagT = 0
                GRADIdiagF = 0
            End If


            '############ FIANCATE ############

            Dim FTL As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = L + 8, .N = Imballo.NumeroTavole(H, TIPO.SpazioFTL, Ltav) * 2, .Tag = "FTL", .Part = "F"}
            Dim FM As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = H, .N = NMorali * 2, .Tag = "FM", .Part = "F"}

            D.AddRange({FTL, FM})

            If Diagonali = True Then
                Dim FD As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = LdiagF, .N = NdiagF, .Tag = "FD", .Part = "F"}
                D.Add(FD)
            End If

            '############ TESTE ############

            Dim TTL As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = P + 4, .N = FTL.N, .Tag = "TTL", .Part = "T"}
            Dim TM As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = H, .N = Imballo.NumeroTavole(P, TIPO.SpazioMT, Ltav) * 2, .Tag = "TM", .Part = "T"}

            D.AddRange({TTL, TM})

            If H >= 100 And NdiagT > 0 Then
                Dim TD As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = LdiagT, .N = NdiagT, .Tag = "TD", .Part = "T"}
                D.Add(TD)
            End If

            '############ INFO ############

            R_GradiF = GRADIdiagF
            R_GradiT = GRADIdiagT
            R_PrimoMOR = Primomorale
            R_M2 = CalcoloM2(L, P, H)
            R_M3 = CalcoloM3(D)
            R_Prezzo = Prezzi.Base(R_Type, R_M3, R_M2, R_TipoRivestimento, R_HT)
            R_SottoMF = MontanteSottoF
            R_SottoMT = MontanteSottoT
            R_SopraMF = 0
            R_SopraMT = 0

        Catch ex As Exception
            Errore.Show("Creazione distinta " & R_NomeImballo, ex.Message)
        End Try

        Return D
    End Function
    Private Function Crea_P_T(L, P, H, Type, Zoccoli, DT, BM, Diagonali, HT) As List(Of Riga_Distinta)
        Dim D As New List(Of Riga_Distinta)

        D.Clear()

        Try

            Dim TIPO As Tipo = Imballo.GetTipo(Type)

            Dim Ltav As Integer = 10
            If L <= My.Settings.LimiteTavole8 Then Ltav = 8

            Dim MontanteSottoF As Integer = 0
            Dim MontanteSottoT As Integer = 0

            '############ BANCALE ############

            Dim Primomorale As Integer = Imballo.CalcoloPrimoMorale(L + 4)
            Dim NMorali As Integer = Imballo.NumeroMorali(L + 4, Primomorale, TIPO.InterasseMax)
            Dim NBTL As Integer = Imballo.NumeroTavole(P + 4, TIPO.SpazioBTL, Ltav)

            Select Case Zoccoli
                Case "2V"
                    Dim Mor As New Riga_Distinta With {.X = 5, .Y = 10, .Z = (P), .N = NMorali, .Tag = "Mor", .Part = "B"}
                    D.Add(Mor)

                Case "EUR"
                    Dim TTB As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (P), .N = NMorali, .Tag = "TTB", .Part = "B"}
                    Dim ZOC As New Riga_Distinta With {.X = 10, .Y = 8, .Z = 10, .N = NMorali * 3, .Tag = "ZOC", .Part = "B"}
                    Dim TTT As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (P), .N = NMorali, .Tag = "TTT", .Part = "B"}
                    D.AddRange({TTB, ZOC, TTT})
            End Select

            Dim BTL As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (L), .N = NBTL, .Tag = "BTL", .Part = "B"}

            If DT = True Then
                BTL.N *= 2
            End If

            If BM = True Then
                BTL.Y = 5
            End If

            D.Add(BTL)

            Dim InterasseMaxTavoleTraIMorali As Integer = TIPO.SpazioBTT

            Dim InterasseMorali As Single = (BTL.Z - (Primomorale * 2)) / (NMorali - 1)
            Dim TavoleTraIMorali As Integer = (Imballo.NumeroTavoleSopra(InterasseMorali, InterasseMaxTavoleTraIMorali)) * (NMorali - 1)


            Dim BTT As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (P), .N = NMorali + TavoleTraIMorali + 2, .Tag = "BTT", .Part = "B"}
            D.Add(BTT)


            '############ COPERCHIO ############

            Dim CTL As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = L, .N = Imballo.NumeroTavole(P + 4, TIPO.SpazioCTL, Ltav), .Tag = "CTL", .Part = "C"}
            Dim CTT As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = P, .N = NMorali, .Tag = "CTT", .Part = "C"}

            D.AddRange({CTL, CTT})



            '############ INFO ############


            R_GradiF = 0
            R_GradiT = 0
            R_PrimoMOR = Primomorale
            R_M2 = CalcoloM2(L, P, H)
            R_M3 = CalcoloM3(D)
            R_Prezzo = Prezzi.Base(R_Type, R_M3, R_M2, R_TipoRivestimento, R_HT)
            R_SottoMF = 0
            R_SottoMT = 0
            R_SopraMF = 0
            R_SopraMT = 0

        Catch ex As Exception
            Errore.Show("Creazione distinta " & R_NomeImballo, ex.Message)
        End Try

        Return D

    End Function
    Private Function Crea_C(L, P, H, Type, Zoccoli, DT, BM, Diagonali, HT) As List(Of Riga_Distinta)
        Dim D As New List(Of Riga_Distinta)

        Dim M3MOR As Single


        D.Clear()

        Try

            Dim TIPO As Tipo = Imballo.GetTipo(Type)

            '############ BANCALE ############

            Dim Primomorale As Integer = 6
            Dim NMorali As Integer = Imballo.NumeroMorali(L, Primomorale, TIPO.InterasseMax)

            Dim Mor As New Riga_Distinta With {.X = 5, .Y = 10, .Z = (P + 2), .N = NMorali, .Tag = "Mor", .Part = "B"}
            Dim BAS As New Riga_Distinta With {.X = L, .Y = 1.2, .Z = P, .N = 1, .Tag = "BAS", .Part = "B"}
            D.AddRange({Mor, BAS})

            M3MOR = (10 * 5 * (P + 2) * NMorali) * (10 ^ -6)


            '############ COPERCHIO ############

            Dim COP As New Riga_Distinta With {.X = L + 2.5, .Y = 0.9, .Z = P + 2, .N = 1, .Tag = "COP", .Part = "C"}
            D.Add(COP)



            '############ FIANCATE ############


            Dim FIA As New Riga_Distinta With {.X = L + 2.5, .Y = 0.9, .Z = H + 1.5, .N = 2, .Tag = "FIA", .Part = "F"}
            D.Add(FIA)



            '############ TESTE ############

            Dim TES As New Riga_Distinta With {.X = P, .Y = 1.2, .Z = H + 1.5, .N = 2, .Tag = "TES", .Part = "T"}
            D.Add(TES)



            '############ INFO ############

            R_GradiF = 0
            R_GradiT = 0
            R_PrimoMOR = Primomorale

            R_M2 = CalcoloM2(L, P, H)
            R_M3 = M3MOR

            R_SottoMF = 0
            R_SottoMT = 0
            R_SopraMF = 0
            R_SopraMT = 0


            R_Prezzo = Prezzi.C(M3MOR, L, P, H, "C")

        Catch ex As Exception
            Errore.Show("Creazione distinta " & R_NomeImballo, ex.Message)
        End Try

        Return D
    End Function
    Private Function Crea_GDA(L, P, H, Type, Zoccoli, DT, BM, Diagonali, HT) As List(Of Riga_Distinta)
        Dim D As New List(Of Riga_Distinta)

        D.Clear()


        Try


            Dim TIPO As Tipo = Imballo.GetTipo(Type)

            Dim Ltav As Integer = 10
            If L <= My.Settings.LimiteTavole8 Then Ltav = 8

            Dim MontanteSottoF As Integer = 11
            Dim MontanteSottoT As Integer = 4

            '############ BANCALE ############

            Dim Primomorale As Integer = Imballo.CalcoloPrimoMorale(L + 4)
            Dim NMorali As Integer = Imballo.NumeroMorali(L + 4, Primomorale, TIPO.InterasseMax)
            Dim NBTL As Integer = Imballo.NumeroTavole(P + 4, TIPO.SpazioBTL, Ltav)

            Select Case Zoccoli
                Case "2V"
                    Dim Mor As New Riga_Distinta With {.X = 5, .Y = 10, .Z = (P + 4), .N = NMorali, .Tag = "Mor", .Part = "B"}
                    D.Add(Mor)

                Case "EUR"
                    Dim TTB As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (P + 4), .N = NMorali, .Tag = "TTB", .Part = "B"}
                    Dim ZOC As New Riga_Distinta With {.X = 10, .Y = 8, .Z = 10, .N = NMorali * 3, .Tag = "ZOC", .Part = "B"}
                    Dim TTT As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (P + 4), .N = NMorali, .Tag = "TTT", .Part = "B"}
                    D.AddRange({TTB, ZOC, TTT})
            End Select

            Dim BTL As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (L + 4), .N = NBTL, .Tag = "BTL", .Part = "B"}

            If DT = True Then
                BTL.N *= 2
                MontanteSottoF += 1
                MontanteSottoT += 1
            End If

            If BM = True Then
                BTL.Y = 5
                MontanteSottoF += 2
                MontanteSottoT += 2
            End If

            D.Add(BTL)

            Dim InterasseMaxTavoleTraIMorali As Integer = TIPO.SpazioBTT

            Dim InterasseMorali As Single = (BTL.Z - (Primomorale * 2)) / (NMorali - 1)
            Dim TavoleTraIMorali As Integer = (Imballo.NumeroTavoleSopra(InterasseMorali, InterasseMaxTavoleTraIMorali)) * (NMorali - 1)


            Dim BTT As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (P + 4), .N = NMorali + TavoleTraIMorali + 2 + 2, .Tag = "BTT", .Part = "B"}
            D.Add(BTT)


            '############ COPERCHIO ############

            Dim CTL As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = L + 4, .N = Imballo.NumeroTavole(P + 4, TIPO.SpazioCTL, Ltav), .Tag = "CTL", .Part = "C"}
            Dim CTT As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = P + 4, .N = NMorali, .Tag = "CTT", .Part = "C"}

            D.AddRange({CTL, CTT})

            'Calcoli per Diagonali

            Dim SpazioFraMontantiF As Integer = (((L) - (Primomorale * 2)) / (NMorali - 1)) - Ltav
            Dim SpazioFraMontantiT As Integer = P - (Imballo.NumeroTavole(P, TIPO.SpazioMT, Ltav) * Ltav)

            Dim LdiagF As Integer = Imballo.Diagonali_lunghezza(SpazioFraMontantiF, H, Ltav)
            Dim GRADIdiagF As Single = Imballo.Diagonali_gradi(SpazioFraMontantiF, H, Ltav)
            Dim NdiagF As Integer = Imballo.CalcoloDiagonaliF(NMorali)

            Dim LdiagT As Integer = Imballo.Diagonali_lunghezza(SpazioFraMontantiT, H, Ltav)
            Dim GRADIdiagT As Single = Imballo.Diagonali_gradi(SpazioFraMontantiT, H, Ltav)
            Dim NdiagT As Single = Imballo.NumeroTavole(P, TIPO.SpazioMT, Ltav)

            If Imballo.NumeroTavole(P, TIPO.SpazioMT, Ltav) Mod 2 <> 0 Then
                NdiagT = 0
            End If

            If GRADIdiagF < 0 Then GRADIdiagF = 0
            If GRADIdiagT < 0 Then GRADIdiagT = 0

            '############ FIANCATE ############

            '-- TODO -- Diagonali e gradi diagonali

            Dim FTL As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = L + 8, .N = (Imballo.NumeroTavole(H - 20, TIPO.SpazioFTL, Ltav) * 2) + 4, .Tag = "FTL", .Part = "F"}
            Dim FM As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (H + MontanteSottoF + 4), .N = NMorali * 2, .Tag = "FM", .Part = "F"}
            Dim FD As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = LdiagF, .N = NdiagF, .Tag = "FD", .Part = "F"}
            D.AddRange({FTL, FM, FD})

            '############ TESTE ############

            '-- TODO -- Diagonali e gradi diagonali

            Dim TTL As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = P, .N = FTL.N - 2, .Tag = "TTL", .Part = "T"}
            Dim TM As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = H + MontanteSottoT + 2, .N = Imballo.NumeroTavole(P, TIPO.SpazioMT, Ltav) * 2, .Tag = "TM", .Part = "T"}

            D.AddRange({TTL, TM})

            If NdiagT > 0 Then
                Dim TD As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = LdiagT, .N = NdiagT, .Tag = "TD", .Part = "T"}
                D.Add(TD)
            End If

            '############ INFO ############

            R_GradiF = GRADIdiagF
            R_GradiT = GRADIdiagT
            R_PrimoMOR = Primomorale
            R_M2 = CalcoloM2(L, P, H)
            R_M3 = CalcoloM3(D)
            R_Prezzo = Prezzi.Base("GDA", R_M3, R_M2, R_TipoRivestimento, R_HT)
            R_SottoMF = MontanteSottoF
            R_SottoMT = MontanteSottoT
            R_SopraMF = 4
            R_SopraMT = 2

        Catch ex As Exception
            Errore.Show("Creazione distinta " & R_NomeImballo, ex.Message)
        End Try

        Return D

    End Function
    Private Function Crea_GST(L, P, H, Type, Zoccoli, DT, BM, Diagonali, HT) As List(Of Riga_Distinta)
        Dim D As New List(Of Riga_Distinta)

        D.Clear()

        Try

            Dim TIPO As Tipo = Imballo.GetTipo(Type)

            Dim Ltav As Integer = 10
            'If L <= My.Settings.LimiteTavole8 Then Ltav = 8

            Dim MontanteSottoF As Single = 1.8
            Dim MontanteSottoT As Single = 1.8

            '############ BANCALE ############

            Dim Primomorale As Integer = 0
            Dim NMorali As Integer = Imballo.NumeroMorali(L + 4, Primomorale, TIPO.InterasseMax)
            Dim NBTL As Integer = Imballo.NumeroTavole(P + 4, TIPO.SpazioBTL, Ltav)

            Dim TTB As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (L + 8), .N = Imballo.NumeroTavole(P, TIPO.SpazioMT, Ltav), .Tag = "SCV", .Part = "B"}
            Dim TTT As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (P + 8), .N = NMorali, .Tag = "TEL", .Part = "B"}
            Dim ZOC As New Riga_Distinta With {.X = 10, .Y = 8, .Z = 10, .N = TTT.N * TTB.N, .Tag = "ZOC", .Part = "B"}

            Dim BTL As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (L + 4), .N = NBTL, .Tag = "BTL", .Part = "B"}

            If DT = True Then
                BTL.N *= 2
                MontanteSottoF += 1.8
                MontanteSottoT += 1.8
            End If

            If BM = True Then
                BTL.Y = 5
                MontanteSottoF += 4.5
                MontanteSottoT += 4.5
            End If

            D.AddRange({TTT, ZOC, TTB, BTL})


            '############ COPERCHIO ############

            Dim CTL As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = TTB.Z, .N = TTB.N, .Tag = "CTL", .Part = "C"}
            Dim CTT As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = TTT.Z, .N = TTT.N, .Tag = "CTT", .Part = "C"}

            D.AddRange({CTL, CTT})

            'Calcoli per Diagonali

            Dim SpazioFraMontantiF As Integer = ((L + 8) - (TTT.N * Ltav)) / (TTT.N - 1)
            Dim SpazioFraMontantiT As Integer = ((P + 4) - (TTB.N * Ltav)) / (TTB.N - 1)

            Dim LdiagF As Integer = Imballo.Diagonali_lunghezza(SpazioFraMontantiF, H, Ltav)
            Dim GRADIdiagF As Single = Imballo.Diagonali_gradi(SpazioFraMontantiF, H, Ltav)
            Dim NdiagF As Integer = (NMorali - 1) * 2

            Dim LdiagT As Integer = Imballo.Diagonali_lunghezza(SpazioFraMontantiT, H, Ltav)
            Dim GRADIdiagT As Single = Imballo.Diagonali_gradi(SpazioFraMontantiT, H, Ltav)
            Dim NdiagT As Single = Imballo.NumeroTavole(P, TIPO.SpazioMT, Ltav)

            If NdiagT Mod 2 > 0 Then NdiagT += 1

            If GRADIdiagF < 0 Then GRADIdiagF = 0
            If GRADIdiagT < 0 Then GRADIdiagT = 0


            '############ FIANCATE ############

            '-- TODO -- Diagonali e gradi diagonali

            Dim FTL As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = L + 4, .N = Imballo.NumeroTavole(H, TIPO.SpazioFTL, Ltav) * 2, .Tag = "FTL", .Part = "F"}
            Dim FM As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (H + MontanteSottoF), .N = NMorali * 2, .Tag = "FM", .Part = "F"}
            Dim FD As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = LdiagF, .N = NdiagF, .Tag = "FD", .Part = "F"}
            D.AddRange({FTL, FM, FD})

            '############ TESTE ############

            '-- TODO -- Diagonali e gradi diagonali

            Dim TTL As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = P, .N = FTL.N, .Tag = "TTL", .Part = "T"}
            Dim TM As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = H + MontanteSottoT, .N = Imballo.NumeroTavole(P, TIPO.SpazioMT, Ltav) * 2, .Tag = "TM", .Part = "T"}
            Dim TD As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = LdiagT, .N = NdiagT, .Tag = "TD", .Part = "T"}

            D.AddRange({TTL, TM, TD})


            '############ INFO ############

            Dim Prezzo_Materiale As Single = SQL.GetSQLValue("SELECT PrezzoM3HT FROM Tipi WHERE Tipo = '" & Type & "'")
            Dim Prezzo_Rivestimento As Single = SQL.GetSQLValue("SELECT Prezzo_m2 FROM Rivestimenti WHERE Tipo_Rivestimento = '" & R_TipoRivestimento & "'")
            Dim Prezzo_Faesite As Single = SQL.GetSQLValue("SELECT Prezzo FROM Materiali WHERE Materiale = 'FAES'")

            R_Zoccoli = "EUR"
            R_GradiF = GRADIdiagF
            R_GradiT = GRADIdiagT
            R_PrimoMOR = Primomorale
            R_M2 = CalcoloM2(L, P, H)
            R_M3 = CalcoloM3(D)
            R_SottoMF = MontanteSottoF
            R_SottoMT = MontanteSottoT
            R_SopraMF = 0
            R_SopraMT = 0

            R_Prezzo = Prezzi.GST(R_M3, R_Lunghezza, R_Profondità, R_Altezza, R_TipoRivestimento, R_HT)


        Catch ex As Exception
            Errore.Show("Creazione distinta " & R_NomeImballo, ex.Message)
        End Try

        Return D
    End Function
    Private Function Crea_GRO(L, P, H, Type, Zoccoli, DT, BM, Diagonali, HT) As List(Of Riga_Distinta)
        'La vecchia G ora non usata
        Dim D As New List(Of Riga_Distinta)

        D.Clear()

        Try

            Dim TIPO As Tipo = Imballo.GetTipo(Type)

            Dim Ltav As Integer = 10
            If L <= My.Settings.LimiteTavole8 Then Ltav = 8

            Dim MontanteSottoF As Integer = 11
            Dim MontanteSottoT As Integer = 4

            '############ BANCALE ############

            Dim Primomorale As Integer = Imballo.CalcoloPrimoMorale(L + 4)
            Dim NMorali As Integer = Imballo.NumeroMorali(L + 4, Primomorale, TIPO.InterasseMax)
            Dim NBTL As Integer = Imballo.NumeroTavole(P + 4, TIPO.SpazioBTL, Ltav)

            Select Case Zoccoli
                Case "2V"
                    Dim Mor As New Riga_Distinta With {.X = 5, .Y = 10, .Z = (P + 4), .N = NMorali, .Tag = "Mor", .Part = "B"}
                    D.Add(Mor)

                Case "EUR"
                    Dim TTB As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (P + 4), .N = NMorali, .Tag = "TTB", .Part = "B"}
                    Dim ZOC As New Riga_Distinta With {.X = 10, .Y = 8, .Z = 10, .N = NMorali * 3, .Tag = "ZOC", .Part = "B"}
                    Dim TTT As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (P + 4), .N = NMorali, .Tag = "TTT", .Part = "B"}
                    D.AddRange({TTB, ZOC, TTT})
            End Select

            Dim BTL As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (L + 4), .N = NBTL, .Tag = "BTL", .Part = "B"}

            If DT = True Then
                BTL.N *= 2
                MontanteSottoF += 1
                MontanteSottoT += 1
            End If

            If BM = True Then
                BTL.Y = 5
                MontanteSottoF += 2
                MontanteSottoT += 2
            End If

            D.Add(BTL)

            Dim InterasseMaxTavoleTraIMorali As Integer = TIPO.SpazioBTT

            Dim InterasseMorali As Single = (BTL.Z - (Primomorale * 2)) / (NMorali - 1)
            Dim TavoleTraIMorali As Integer = (Imballo.NumeroTavoleSopra(InterasseMorali, InterasseMaxTavoleTraIMorali)) * (NMorali - 1)


            Dim BTT As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (P + 4), .N = NMorali + TavoleTraIMorali + 2, .Tag = "BTT", .Part = "B"}
            D.Add(BTT)


            '############ COPERCHIO ############

            Dim CTL As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = L + 4, .N = Imballo.NumeroTavole(P + 4, TIPO.SpazioCTL, Ltav), .Tag = "CTL", .Part = "C"}
            Dim CTT As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = P + 4, .N = NMorali, .Tag = "CTT", .Part = "C"}

            D.AddRange({CTL, CTT})

            Dim SpazioFraMontantiF As Integer = (((L) - (Primomorale * 2)) / (NMorali - 1)) - Ltav
            Dim SpazioFraMontantiT As Integer = P - (Imballo.NumeroTavole(P, TIPO.SpazioMT, Ltav) * Ltav)

            Dim LdiagF As Integer = Imballo.Diagonali_lunghezza(SpazioFraMontantiF, H, Ltav)
            Dim GRADIdiagF As Single = Imballo.Diagonali_gradi(SpazioFraMontantiF, H, Ltav)
            Dim NdiagF As Integer = (NMorali - 1) * 2

            Dim LdiagT As Integer = Imballo.Diagonali_lunghezza(SpazioFraMontantiT, H, Ltav)
            Dim GRADIdiagT As Single = Imballo.Diagonali_gradi(SpazioFraMontantiT, H, Ltav)
            Dim NdiagT As Single = Imballo.NumeroTavole(P, TIPO.SpazioMT, Ltav)

            If GRADIdiagF < 0 Then GRADIdiagF = 0
            If GRADIdiagT < 0 Then GRADIdiagT = 0

            If Diagonali = False Then
                GRADIdiagT = 0
                GRADIdiagF = 0
            End If


            '############ FIANCATE ############

            Dim FTL As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = L + 8, .N = Imballo.NumeroTavole(H, TIPO.SpazioFTL, Ltav) * 2, .Tag = "FTL", .Part = "F"}
            Dim FM As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (H + MontanteSottoF + 4), .N = NMorali * 2, .Tag = "FM", .Part = "F"}

            D.AddRange({FTL, FM})

            If Diagonali = True Then
                Dim FD As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = LdiagF, .N = NdiagF, .Tag = "FD", .Part = "F"}
                D.Add(FD)
            End If

            '############ TESTE ############

            Dim TTL As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = P, .N = FTL.N, .Tag = "TTL", .Part = "T"}
            Dim TM As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = H + MontanteSottoT + 2, .N = Imballo.NumeroTavole(P, TIPO.SpazioMT, Ltav) * 2, .Tag = "TM", .Part = "T"}

            D.AddRange({TTL, TM})

            If Diagonali = True Then
                Dim TD As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = LdiagT, .N = NdiagT, .Tag = "TD", .Part = "T"}
                D.Add(TD)
            End If

            '############ INFO ############

            R_GradiF = GRADIdiagF
            R_GradiT = GRADIdiagT
            R_PrimoMOR = Primomorale
            R_M2 = CalcoloM2(L, P, H)
            R_M3 = CalcoloM3(D)
            R_Prezzo = Prezzi.Base(R_Type, R_M3, R_M2, R_TipoRivestimento, R_HT)
            R_SottoMF = MontanteSottoF
            R_SottoMT = MontanteSottoT
            R_SopraMF = 4
            R_SopraMT = 2

        Catch ex As Exception
            Errore.Show("Creazione distinta " & R_NomeImballo, ex.Message)
        End Try

        Return D

    End Function

End Class
