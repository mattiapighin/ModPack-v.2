Namespace Stampe
    Module Stampe_Distinta

        Private Class RowDistinta
            Public R As Integer
            Public Part As String
            Public X, Y, Z, N As Single
            Public Tag As String
        End Class

        Dim FMT As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter}

        Dim PrimoMorale As Integer
        Dim L, P, H As Integer
        Dim Zocc As String
        Dim DT, BM As Boolean
        Dim DiagF, DiagT As Integer
        Dim m2, m3 As Single
        Dim SottoMF, SopraMF, SottoMT, SopraMT As Single

        Dim DescrizioneRivestimento As String

        Dim IMG As Image

        Dim Xmor As Single
        Dim Ymor As Single

        Dim Stringa1Riv As String
        Dim Stringa2Riv As String
        Dim Stringa3Riv As String
        Dim Stringa4Riv As String
        Dim stringa5riv As String
        Dim QT1Riv As Integer = 0
        Dim QT2Riv As Integer = 0
        Dim QT3Riv As Integer = 0
        Dim QT4Riv As Integer = 0

        Dim SetupRiv As New ModPackDBDataSet.Setup_RivestDataTable

        Public Sub RiempiDataSetRivestimenti()
            Using TA As New ModPackDBDataSetTableAdapters.Setup_RivestTableAdapter
                TA.Fill(SetupRiv)
            End Using
        End Sub


        Private Sub CaricaDati(Riga As RigaOrdine)
            PrimoMorale = 0
            L = 0
            P = 0
            H = 0
            Zocc = ""
            DT = False
            BM = False
            DiagF = 0
            DiagT = 0
            m2 = 0
            m3 = 0
            IMG = Nothing
            SottoMF = 0
            SopraMF = 0
            SottoMT = 0
            SopraMT = 0

            Try
                Using Table As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
                    Using DS As New ModPackDBDataSet.ImballiDataTable
                        Table.Fill(DS)

                        Dim ImballiRow As ModPackDBDataSet.ImballiRow = DS.Where(Function(X) X.Imballo = Riga.Imballo).FirstOrDefault

                        With ImballiRow

                            L = .L
                            P = .P
                            H = .H
                            Zocc = .Zoccoli
                            DT = .DT
                            BM = .BM
                            If Not .IsGradi_FNull Then DiagF = .Gradi_F
                            If Not .IsGradi_TNull Then DiagT = .Gradi_T
                            If Not .IsM2Null Then m2 = .M2
                            If Not .IsM3Null Then m3 = .M3
                            If Not .IsPrimo_MoraleNull Then PrimoMorale = .Primo_Morale
                            If Not .IsImgNull Then IMG = Immagine.ConvertFromBytes(.Img)
                            If Not .IsSopraMFNull Then SopraMF = .SopraMF
                            If Not .IsSopraMTNull Then SopraMT = .SopraMT
                            If Not .IsSottoMFNull Then SottoMF = .SottoMF
                            If Not .IsSottoMTNull Then SottoMT = .SottoMT

                        End With

                    End Using
                End Using


                'Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)
                '    Using Cmd As New System.Data.SqlClient.SqlCommand("SELECT L, P, H, Zoccoli, DT, BM, Gradi_F, Gradi_T, m2, m3, Primo_Morale, Img, SottoMF, SottoMT, SopraMF, SopraMT FROM Imballi WHERE Imballo = '" & Riga.Imballo & "'", Con)
                '        Try
                '            Con.Open()  'Apre la connessione al db
                '            Using R As System.Data.SqlClient.SqlDataReader = Cmd.ExecuteReader
                '                Do While R.Read
                '                    L = R.GetValue(0)
                '                    P = R.GetValue(1)
                '                    H = R.GetValue(2)
                '                    Zocc = R.GetValue(3)
                '                    DT = R.GetValue(4)
                '                    BM = R.GetValue(5)
                '                    DiagF = R.GetValue(6)
                '                    DiagT = R.GetValue(7)
                '                    m2 = R.GetValue(8)
                '                    m3 = R.GetValue(9)
                '                    PrimoMorale = R.GetValue(10)
                '                    If Not IsDBNull(R.GetValue(11)) Then IMG = Immagine.ConvertFromBytes(R.GetValue(11))
                '                    SottoMF = R.GetValue(12)
                '                    SottoMT = R.GetValue(13)
                '                    SopraMF = R.GetValue(14)
                '                    SopraMT = R.GetValue(15)
                '                Loop
                '            End Using

            Catch ex As System.Exception
                MsgBox(ex.Message)
                    End Try

            'End Using
            ' End Using
        End Sub

        Private Sub QR_Code(sender As Object, e As Printing.PrintPageEventArgs, riga As RigaOrdine, x As Integer, y As Integer, width As Integer)

            Dim STRINGA As String =
                            riga.Imballo & " PZ. " & riga.Qt & vbCrLf &
                            "ORD. " & riga.NumeroOrdine & " DEL " & riga.Data_Ordine & vbCrLf &
                            "D: " & riga.Codice & vbCrLf &
                            "C: " & riga.Commessa & vbCrLf &
                            "MAGAZZINO " & riga.Magazzino & vbCrLf &
                            "DATA CONSEGNA " & riga.DataConsegna & vbCrLf &
                            "INDICE " & riga.Indice

            e.Graphics.DrawImage(BarCode.QR(STRINGA, width), x, y)

        End Sub
        Private Sub Morale(sender As Object, e As Printing.PrintPageEventArgs, Riga As RigaOrdine, X As Integer, Y As Integer)
            If Riga.Zoccoli = "2V" Then

                Dim Fresata As Boolean = SQL.Fresata(Riga.Tipo)


                Dim Fontz As New Font("Calibri", 7)

                Dim Xmorale = Xmor * 2
                Dim Ymorale = Ymor * 2

                Dim R As New Rectangle(X, Y, 60, 60)
                e.Graphics.DrawRectangle(Pens.Gray, R)

                Dim Centro As New PointF(R.X + (R.Width / 2), R.Y + (R.Height / 2))
                Dim Morale As New Rectangle(Centro.X - (Xmorale / 2), Centro.Y - (Ymorale / 2), Xmorale, Ymorale)

                Dim RmisuraX As New Rectangle(R.X, R.Y, R.Width, 20)
                Dim RmisuraY As New Rectangle(R.Right - 20, R.Y, 20, R.Height)
                Dim Rfresato As New Rectangle(R.X, R.Bottom - 15, R.Width, 15)

                e.Graphics.FillRectangle(Brushes.Wheat, Morale)
                e.Graphics.DrawRectangle(Pens.Black, Morale)

                e.Graphics.DrawString(Xmor, Fontz, Brushes.Black, RmisuraX, FMT)
                e.Graphics.DrawString(Ymor, Fontz, Brushes.Black, RmisuraY, FMT)


                If Fresata = True Then
                    e.Graphics.DrawString("FRESARE", New Font("Calibri", 7, FontStyle.Bold), Brushes.Black, Rfresato, FMT)
                End If


            End If
        End Sub

        Private Sub Intestazione(sender As Object, e As Printing.PrintPageEventArgs, Riga As RigaOrdine)

            Dim FontRiga1 As New Font("Calibri", 16, FontStyle.Bold)
            Dim FontN As New Font("Calibri", 10)
            Dim FT As New Font("Calibri", 6)

            Dim Squadratura As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height)
            e.Graphics.DrawRectangle(Pens.LightGray, Squadratura)

            Dim RectIntestazione As New Rectangle(e.MarginBounds.Left + 5, e.MarginBounds.Top + 5, e.MarginBounds.Width - 10, 100)

            Dim Riga1 As New Rectangle(RectIntestazione.Left, RectIntestazione.Top, RectIntestazione.Width, 40)
            Dim Riga2 As New Rectangle(RectIntestazione.Left, Riga1.Bottom, RectIntestazione.Width, 20)
            Dim Riga3 As New Rectangle(RectIntestazione.Left, Riga2.Bottom, RectIntestazione.Width, 20)
            Dim Riga4 As New Rectangle(RectIntestazione.Left, Riga3.Bottom, RectIntestazione.Width, 20)

            Dim L As Single = RectIntestazione.Width / 40

            Dim RectLogo As New Rectangle(Riga1.Left, Riga1.Top, L * 10, Riga1.Height)
            Dim RectImballo As New Rectangle(RectLogo.Right, Riga1.Top, L * 18, Riga1.Height)
            Dim RectQT As New Rectangle(RectImballo.Right, Riga1.Top, L * 4, Riga1.Height)
            Dim RectHT As New Rectangle(RectQT.Right, Riga1.Top, L * 4, Riga1.Height)
            Dim RectTIPO As New Rectangle(RectHT.Right, Riga1.Top, L * 4, Riga1.Height)
            e.Graphics.DrawRectangles(Pens.LightGray, {RectLogo, RectImballo, RectQT, RectHT, RectTIPO})

            Dim RectCliente As New Rectangle(Riga2.Left, Riga2.Top, L * 21, Riga2.Height)
            Dim RectRivestimento As New Rectangle(RectCliente.Right, Riga2.Top, L * 10, Riga2.Height + Riga3.Height)
            Dim RectOrdine As New Rectangle(RectRivestimento.Right, Riga2.Top, L * 9, Riga2.Height)
            e.Graphics.DrawRectangles(Pens.LightGray, {RectCliente, RectRivestimento, RectOrdine})

            Dim RectCodice As New Rectangle(Riga3.Left, Riga3.Top, L * 13, Riga3.Height)
            Dim RectCommessa As New Rectangle(Riga4.Left, Riga4.Top, L * 13, Riga4.Height)
            Dim RectIndice As New Rectangle(RectCodice.Right, Riga3.Top, L * 8, Riga3.Height + Riga4.Height)
            Dim RectConsegna As New Rectangle(RectRivestimento.Right, Riga3.Top, L * 9, Riga3.Height)
            Dim RectVuoto As New Rectangle(RectIndice.Right, RectCommessa.Top, L * 19, Riga4.Height)
            e.Graphics.DrawRectangles(Pens.LightGray, {RectCodice, RectIndice, RectConsegna, RectCommessa, RectVuoto})
            e.Graphics.FillRectangle(Brushes.LightGray, RectVuoto)
            e.Graphics.DrawRectangle(New Pen(Color.LightGray, 3), RectIntestazione)

            Stampe.ImmagineInRettangolo(My.Resources.Logo, RectLogo, e)
            e.Graphics.DrawString(Riga.Imballo, FontRiga1, Brushes.Black, RectImballo, FMT)
            e.Graphics.DrawString(Riga.Qt, FontRiga1, Brushes.Black, RectQT, FMT)
            If Riga.HT = True Then e.Graphics.DrawString("HT", FontRiga1, Brushes.Black, RectHT, FMT)
            e.Graphics.DrawString(Riga.Tipo, FontRiga1, Brushes.Black, RectTIPO, FMT)

            e.Graphics.DrawString(Riga.Cliente, FontN, Brushes.Black, RectCliente, FMT)
            e.Graphics.DrawString(Riga.Codice, FontN, Brushes.Black, RectCodice, FMT)
            e.Graphics.DrawString(Riga.Commessa, FontN, Brushes.Black, RectCommessa, FMT)
            e.Graphics.DrawString(Riga.Indice, FontN, Brushes.Black, RectIndice, FMT)
            DescrizioneRivestimento = SQL.GetSQLValue("SELECT Descrizione FROM Rivestimenti WHERE Tipo_Rivestimento = '" & Riga.TipoRivestimento & "'")
            e.Graphics.DrawString(DescrizioneRivestimento, FontN, Brushes.Black, RectRivestimento, FMT)
            e.Graphics.DrawString(Riga.NumeroOrdine & " (" & Riga.Riga & ")", FontN, Brushes.Black, RectOrdine, FMT)
            e.Graphics.DrawString(Riga.DataConsegna, FontN, Brushes.Black, RectConsegna, FMT)

            'Intestazioni
            e.Graphics.DrawString("PZ", FT, Brushes.LightGray, RectQT)
            e.Graphics.DrawString("TIPO", FT, Brushes.LightGray, RectTIPO)
            e.Graphics.DrawString("CLIENTE", FT, Brushes.LightGray, RectCliente)
            e.Graphics.DrawString("DISEGNO", FT, Brushes.LightGray, RectCodice)
            e.Graphics.DrawString("COMMESSA", FT, Brushes.LightGray, RectCommessa)
            e.Graphics.DrawString("INDICE", FT, Brushes.LightGray, RectIndice)
            e.Graphics.DrawString("RIVESTIMENTO", FT, Brushes.LightGray, RectRivestimento)
            e.Graphics.DrawString("ORD", FT, Brushes.LightGray, RectOrdine)
            e.Graphics.DrawString("CONSEGNA", FT, Brushes.LightGray, RectConsegna)

        End Sub
        Private Sub PieDiPagina(sender As Object, e As Printing.PrintPageEventArgs, riga As RigaOrdine)
            Dim Riga1 As New Rectangle(e.MarginBounds.Left + 5, e.MarginBounds.Bottom - 45, e.MarginBounds.Width - 10, 20)
            Dim Riga2 As New Rectangle(e.MarginBounds.Left + 5, e.MarginBounds.Bottom - 25, e.MarginBounds.Width - 10, 20)
            e.Graphics.FillRectangle(Brushes.LightGray, Riga1)
            e.Graphics.DrawRectangles(New Pen(Color.LightGray, 3), {Riga1, Riga2})

            Dim FONT As New Font("Calibri", 10)

            Dim Q As Single = Riga1.Width / 12

            Dim RsL As New Rectangle(Riga1.Left, Riga1.Top, Q, Riga1.Height)
            Dim RsP As New Rectangle(RsL.Right, Riga1.Top, Q, Riga1.Height)
            Dim RsH As New Rectangle(RsP.Right, Riga1.Top, Q, Riga1.Height)
            Dim RsZocc As New Rectangle(RsH.Right, Riga1.Top, Q, Riga1.Height)
            Dim RsDTBM As New Rectangle(RsZocc.Right, Riga1.Top, Q, Riga1.Height)
            Dim RsDiag As New Rectangle(RsDTBM.Right, Riga1.Top, Q, Riga1.Height)
            Dim RsDiagF As New Rectangle(RsDiag.Right, Riga1.Top, Q, Riga1.Height)
            Dim RsDiagT As New Rectangle(RsDiagF.Right, Riga1.Top, Q, Riga1.Height)
            Dim RsVuoto2 As New Rectangle(RsDiagT.Right, Riga1.Top, Q * 2, Riga1.Height)
            Dim Rsm2 As New Rectangle(RsVuoto2.Right, Riga1.Top, Q, Riga1.Height)
            Dim Rsm3 As New Rectangle(Rsm2.Right, Riga1.Top, Q, Riga1.Height)

            Dim RbL As New Rectangle(Riga2.Left, Riga2.Top, Q, Riga2.Height)
            Dim RbP As New Rectangle(RbL.Right, Riga2.Top, Q, Riga2.Height)
            Dim RbH As New Rectangle(RbP.Right, Riga2.Top, Q, Riga2.Height)
            Dim RbZocc As New Rectangle(RbH.Right, Riga2.Top, Q, Riga2.Height)
            Dim RbDTBM As New Rectangle(RbZocc.Right, Riga2.Top, Q, Riga2.Height)
            Dim rbdiag As New Rectangle(RbDTBM.Right, Riga2.Top, Q, Riga2.Height)
            Dim RbDiagF As New Rectangle(rbdiag.Right, Riga2.Top, Q, Riga2.Height)
            Dim RbDiagT As New Rectangle(RbDiagF.Right, Riga2.Top, Q, Riga2.Height)
            Dim RbVuoto2 As New Rectangle(RbDiagT.Right, Riga2.Top, Q * 2, Riga2.Height)
            Dim Rbm2 As New Rectangle(RbVuoto2.Right, Riga2.Top, Q, Riga2.Height)
            Dim Rbm3 As New Rectangle(Rbm2.Right, Riga2.Top, Q, Riga2.Height)

            e.Graphics.DrawRectangles(Pens.LightGray, {RbL, RbP, RbH, RbZocc, RbDTBM, RsDiag, RbDiagF, RbDiagT, RbVuoto2, Rbm2})

            e.Graphics.DrawString("L", FONT, Brushes.Black, RsL, FMT)
            e.Graphics.DrawString("P", FONT, Brushes.Black, RsP, FMT)
            e.Graphics.DrawString("H", FONT, Brushes.Black, RsH, FMT)
            e.Graphics.DrawString("Zocc", FONT, Brushes.Black, RsZocc, FMT)
            e.Graphics.DrawString("DT\BM", FONT, Brushes.Black, RsDTBM, FMT)
            e.Graphics.DrawString("Diagonali", FONT, Brushes.Black, RsDiag, FMT)
            e.Graphics.DrawString("Gradi F", FONT, Brushes.Black, RsDiagF, FMT)
            e.Graphics.DrawString("Gradi T", FONT, Brushes.Black, RsDiagT, FMT)

            e.Graphics.DrawString("m²", FONT, Brushes.Black, Rsm2, FMT)
            e.Graphics.DrawString("m³", FONT, Brushes.Black, Rsm3, FMT)





            e.Graphics.DrawString(L, FONT, Brushes.Black, RbL, FMT)
            e.Graphics.DrawString(P, FONT, Brushes.Black, RbP, FMT)
            e.Graphics.DrawString(H, FONT, Brushes.Black, RbH, FMT)
            e.Graphics.DrawString(Zocc, FONT, Brushes.Black, RbZocc, FMT)

            If riga.Diagonali = True Then e.Graphics.DrawString("X", FONT, Brushes.Black, rbdiag, FMT)

            If DT = True Then e.Graphics.DrawString("DT", FONT, Brushes.Black, RbDTBM, FMT)
            If BM = True Then e.Graphics.DrawString("BM", FONT, Brushes.Black, RbDTBM, FMT)

            e.Graphics.DrawString(DiagF, FONT, Brushes.Black, RbDiagF, FMT)
            e.Graphics.DrawString(DiagT, FONT, Brushes.Black, RbDiagT, FMT)

            e.Graphics.DrawString(riga.Data_Ordine, FONT, Brushes.Gray, RbVuoto2, FMT)

            e.Graphics.DrawString(m2, FONT, Brushes.Black, Rbm2, FMT)
            e.Graphics.DrawString(m3, FONT, Brushes.Black, Rbm3, FMT)

        End Sub

        Private Sub Distinta(sender As Object, e As Printing.PrintPageEventArgs, riga As RigaOrdine)

            'QR_Code(sender, e, riga, e.MarginBounds.Right - 240, e.MarginBounds.Bottom - 215, 150)

            Dim DS As New DataSet
            Dim LST As New List(Of RowDistinta)

            Dim LunBTL As Integer
            Dim NMOR As Integer

            Dim Query As String = "Select * FROM Distinta WHERE Imballo = '" & riga.Imballo & "'"
            Dim Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)

            Dim cmd As System.Data.SqlClient.SqlCommand
            cmd = New System.Data.SqlClient.SqlCommand(Query, Con)

            Con.Open()
            Try
                Dim myreader As System.Data.SqlClient.SqlDataReader = cmd.ExecuteReader()
                Do While myreader.Read
                    Dim R As New RowDistinta With {.R = myreader.GetValue(2), .Part = myreader.GetValue(3), .X = myreader.GetValue(4), .Y = myreader.GetValue(5), .Z = myreader.GetValue(6), .N = myreader.GetValue(7), .Tag = myreader.GetValue(8)}
                    LST.Add(R)
                    If R.Tag = "BTL" Then LunBTL = R.Z 'se la riga è quella BTL salva la misura della tavola
                    If R.Tag = "BAS" Then LunBTL = R.X 'se la riga è quella BAS (nelle casse in compensato) salva la lunghezza 
                    If R.R = 1 Then NMOR = R.N ' se è la prima riga salva il numero di morali o telarini
                Loop
                myreader.Close()
            Catch ex As System.Exception
                MsgBox(ex.Message)
            End Try

            Con.Close()

            Dim fnt As New Font("Calibri", My.Settings.DimensioneFontDistinta)

            Dim TOTALE_RIGHE As Integer = LST.Count 'totale di righe nella tabella distinte che contengono il _Codice
            If TOTALE_RIGHE < My.Settings.NumeroRigheDistinta Then TOTALE_RIGHE = My.Settings.NumeroRigheDistinta 'Se ci sono troppe righe le stringe, se no resta formattato giusto

            Dim R_Misure As New Rectangle(e.MarginBounds.Left + 5, e.MarginBounds.Top + 110, e.MarginBounds.Width / 2 - 10, e.MarginBounds.Height - 450) '245)
            Dim Rect_Riga As New Rectangle(R_Misure.Left, R_Misure.Top, R_Misure.Width, R_Misure.Height / (TOTALE_RIGHE + 4))

            ' e.Graphics.DrawRectangle(Pens.Red, R_Misure)

            Dim QT As Integer = riga.Qt

            'CONTROLLA CHE CISIANO RIGHE PER OGNI TYPE DA SCRIVERE
            Dim BANCALE As Boolean = False
            Dim COPERCHIO As Boolean = False
            Dim FIANCATE As Boolean = False
            Dim TESTE As Boolean = False
            Dim CORREDO As Boolean = False
            Dim ALTRO As Boolean = False

            For Each K As RowDistinta In LST
                If K.Part = "B" Then BANCALE = True
                If K.Part = "C" Then COPERCHIO = True
                If K.Part = "F" Then FIANCATE = True
                If K.Part = "T" Then TESTE = True
                If K.Part = "K" Then CORREDO = True
                If K.Part <> "B" And K.Part <> "C" And K.Part <> "F" And K.Part <> "T" And K.Part <> "K" Then ALTRO = True
            Next

            '############### BANCALE #################
            If BANCALE = True Then
                e.Graphics.FillRectangle(Brushes.LightGray, Rect_Riga.X, Rect_Riga.Y + 3, Rect_Riga.Width - 3, Rect_Riga.Height - 6)
                e.Graphics.DrawRectangle(Pens.LightGray, Rect_Riga)
                e.Graphics.DrawString("BANCALE", fnt, Brushes.Black, Rect_Riga, FMT)
                Rect_Riga.Y += Rect_Riga.Height

                Xmor = LST(0).X
                Ymor = LST(0).Y


                For Each K As RowDistinta In (From row In LST Where row.Part = "B")
                    If Not K.N = 0 Then
                        e.Graphics.DrawRectangle(Pens.LightGray, Rect_Riga)
                        StampaRiga(sender, e, Rect_Riga, K.X, K.Y, K.Z, K.N, K.Tag, QT)
                        Rect_Riga.Y += Rect_Riga.Height
                    End If
                Next
            End If
            '############### COPERCHIO ################# 
            If COPERCHIO = True Then
                e.Graphics.FillRectangle(Brushes.LightGray, Rect_Riga.X, Rect_Riga.Y + 3, Rect_Riga.Width - 3, Rect_Riga.Height - 6)
                e.Graphics.DrawRectangle(Pens.LightGray, Rect_Riga)
                e.Graphics.DrawString("COPERCHIO", fnt, Brushes.Black, Rect_Riga, FMT)
                Rect_Riga.Y += Rect_Riga.Height

                For Each K As RowDistinta In (From row In LST Where row.Part = "C")
                    If Not K.N = 0 Then
                        e.Graphics.DrawRectangle(Pens.LightGray, Rect_Riga)
                        StampaRiga(sender, e, Rect_Riga, K.X, K.Y, K.Z, K.N, K.Tag, QT)
                        Rect_Riga.Y += Rect_Riga.Height
                    End If
                Next
            End If
            '############### FIANCATE ################# 
            If FIANCATE = True Then
                e.Graphics.FillRectangle(Brushes.LightGray, Rect_Riga.X, Rect_Riga.Y + 3, Rect_Riga.Width - 3, Rect_Riga.Height - 6)
                e.Graphics.DrawRectangle(Pens.LightGray, Rect_Riga)
                e.Graphics.DrawString("FIANCATE", fnt, Brushes.Black, Rect_Riga, FMT)
                Rect_Riga.Y += Rect_Riga.Height

                For Each K As RowDistinta In (From row In LST Where row.Part = "F")
                    If Not K.N = 0 Then
                        e.Graphics.DrawRectangle(Pens.LightGray, Rect_Riga)
                        StampaRiga(sender, e, Rect_Riga, K.X, K.Y, K.Z, K.N, K.Tag, QT)
                        Rect_Riga.Y += Rect_Riga.Height
                    End If
                Next
            End If
            '############### TESTE #################
            If TESTE = True Then
                e.Graphics.FillRectangle(Brushes.LightGray, Rect_Riga.X, Rect_Riga.Y + 3, Rect_Riga.Width - 3, Rect_Riga.Height - 6)
                e.Graphics.DrawRectangle(Pens.LightGray, Rect_Riga)
                e.Graphics.DrawString("TESTE", fnt, Brushes.Black, Rect_Riga, FMT)
                Rect_Riga.Y += Rect_Riga.Height

                For Each K As RowDistinta In (From row In LST Where row.Part = "T")
                    If Not K.N = 0 Then
                        e.Graphics.DrawRectangle(Pens.LightGray, Rect_Riga)
                        StampaRiga(sender, e, Rect_Riga, K.X, K.Y, K.Z, K.N, K.Tag, QT)
                        Rect_Riga.Y += Rect_Riga.Height
                    End If
                Next
            End If
            '############### CORREDO ################# 
            If CORREDO = True Then
                e.Graphics.FillRectangle(Brushes.LightGray, Rect_Riga.X, Rect_Riga.Y + 3, Rect_Riga.Width - 3, Rect_Riga.Height - 6)
                e.Graphics.DrawRectangle(Pens.LightGray, Rect_Riga)
                e.Graphics.DrawString("CORREDO", fnt, Brushes.Black, Rect_Riga, FMT)
                Rect_Riga.Y += Rect_Riga.Height


                For Each K As RowDistinta In (From row In LST Where row.Part = "K")
                    If Not K.N = 0 Then
                        e.Graphics.DrawRectangle(Pens.LightGray, Rect_Riga)
                        StampaRiga(sender, e, Rect_Riga, K.X, K.Y, K.Z, K.N, K.Tag, QT)
                        Rect_Riga.Y += Rect_Riga.Height
                    End If
                Next
            End If
            '############### ALTRE RIGHE ################# 
            If ALTRO = True Then
                e.Graphics.FillRectangle(Brushes.LightGray, Rect_Riga.X, Rect_Riga.Y + 3, Rect_Riga.Width - 3, Rect_Riga.Height - 6)
                e.Graphics.DrawRectangle(Pens.LightGray, Rect_Riga)
                e.Graphics.DrawString("", fnt, Brushes.Black, Rect_Riga, FMT)
                Rect_Riga.Y += Rect_Riga.Height

                For Each K As RowDistinta In (From row In LST Where row.Part <> "B" And row.Part <> "C" And row.Part <> "F" And row.Part <> "T" And row.Part <> "K")
                    If Not K.N = 0 Then
                        e.Graphics.DrawRectangle(Pens.LightGray, Rect_Riga)
                        StampaRiga(sender, e, Rect_Riga, K.X, K.Y, K.Z, K.N, K.Tag, QT)
                        Rect_Riga.Y += Rect_Riga.Height
                    End If
                Next
            End If
            '############### QUOTE MORALI ################# 
            Dim Quote_Morali As New Rectangle(e.MarginBounds.Left + 5, e.MarginBounds.Bottom - 80, e.MarginBounds.Width - 10, 30)

            e.Graphics.DrawString("QUOTE MORALI", New Font("Calibri", 8), Brushes.Gray, Quote_Morali)
            e.Graphics.DrawRectangle(Pens.LightGray, Quote_Morali)
            Riempi_QuoteMorali(sender, e, Quote_Morali, PrimoMorale, NMOR, LunBTL)


            '############## FOTO ##########################
            Dim RectIMG As New Rectangle(e.MarginBounds.Right - 305, e.MarginBounds.Top + 175, 300, 300)
            If Not IMG Is Nothing Then
                e.Graphics.DrawRectangle(Pens.LightGray, RectIMG)
                ImmagineInRettangolo(IMG, RectIMG, e)
            End If

            '############# MONTANTI #######################

            Dim RectMonT As New Rectangle(e.MarginBounds.Right - 55, e.MarginBounds.Bottom - 290, 50, 200)
            Dim RectMonF As New Rectangle(RectMonT.Left - 55, e.MarginBounds.Bottom - 290, 50, 200)

            Dim RectSopraF As New Rectangle(RectMonF.Left, RectMonF.Top, RectMonF.Width, 50)
            Dim RectSopraT As New Rectangle(RectMonT.Left, RectMonT.Top, RectMonT.Width, 50)
            Dim RectSottoF As New Rectangle(RectMonF.Left, RectMonF.Bottom - 50, RectMonF.Width, 50)
            Dim RectSottoT As New Rectangle(RectMonT.Left, RectMonT.Bottom - 50, RectMonT.Width, 50)

            Dim RectUP As New Rectangle(RectMonF.Left, RectMonF.Top - 45, 105, 40)

            e.Graphics.DrawString("MONTANTI", New Font("Calibri", 10), Brushes.Black, RectUP, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Near})
            e.Graphics.DrawString("Fiancate", New Font("Calibri", 10), Brushes.Black, RectUP, New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Far})
            e.Graphics.DrawString("Teste", New Font("Calibri", 10), Brushes.Black, RectUP, New StringFormat With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Far})

            e.Graphics.DrawRectangles(Pens.LightGray, {RectUP, RectMonF, RectMonT, RectSopraF, RectSopraT, RectSottoF, RectSottoT})

            e.Graphics.DrawString(SopraMF, fnt, Brushes.Black, RectSopraF, FMT)
            e.Graphics.DrawString(SopraMT, fnt, Brushes.Black, RectSopraT, FMT)
            e.Graphics.DrawString(SottoMF, fnt, Brushes.Black, RectSottoF, FMT)
            e.Graphics.DrawString(SottoMT, fnt, Brushes.Black, RectSottoT, FMT)
            e.Graphics.DrawString(H, fnt, Brushes.Black, RectMonF, FMT)
            e.Graphics.DrawString(H, fnt, Brushes.Black, RectMonT, FMT)

            '############ NOTE ###############

            Dim FormatNote As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center, .HotkeyPrefix = Drawing.Text.HotkeyPrefix.Show, .Trimming = StringTrimming.EllipsisCharacter}

            Dim RectNote1 As New Rectangle(e.MarginBounds.Left + 5, RectUP.Top, R_Misure.Width, 120)
            Dim RectNote2 As New Rectangle(RectNote1.Left, RectNote1.Bottom + 5, RectNote1.Width, 120)
            e.Graphics.DrawString("NOTE 1", New Font("Calibri", 8), Brushes.LightGray, RectNote1)
            e.Graphics.DrawString("NOTE 2", New Font("Calibri", 8), Brushes.LightGray, RectNote2)
            e.Graphics.DrawString(riga.Note & vbCrLf & riga.Rivest_Tot, fnt, Brushes.Black, RectNote1, FormatNote)
            e.Graphics.DrawString(SQL.Get_NoteIMBALLO(riga.Imballo) & SQL.Get_NoteBic(riga.Indice), fnt, Brushes.Black, RectNote2, FormatNote)
            e.Graphics.DrawRectangles(Pens.LightGray, {RectNote1, RectNote2})

            '######### BARCODE ############

            Dim RectBarcode As New Rectangle(e.MarginBounds.Right - 305, e.MarginBounds.Top + 110, 300, 60)

            If My.Settings.StampaBarcodeDistinte = True Then

                Dim Codice As Image

                If My.Settings.StampaBarcodeSoloCodice = True Then
                    'Stampa l'indice della tabella ordini riferito all'imballo
                    Codice = BarCode.Genera(SQL.GetID_RigaOrdine(riga), True, 50, 7)
                Else
                    'Stampa il nome dell'imballo | quantità
                    Codice = BarCode.Genera(riga.Imballo & "|" & riga.Qt, True, 50, 7)
                End If

                Dim P As New Point With {.X = RectBarcode.Right - (Codice.Width) - 20, .Y = RectBarcode.Y}
                e.Graphics.DrawImage(Codice, P)
            End If

            '######### RIVESTIMENTO ##########

            Dim RectRivestimento As New Rectangle(RectIMG.Left, RectIMG.Bottom + 5, RectIMG.Width, 150)

            If riga.Rivestimento = True Then

                Dim Riga1RIV As New Rectangle(RectIMG.Left, RectIMG.Bottom + 5, RectIMG.Width, 25)
                Dim Riga2RIV As New Rectangle(Riga1RIV.Left, Riga1RIV.Bottom, Riga1RIV.Width, Riga1RIV.Height)
                Dim Riga3RIV As New Rectangle(Riga1RIV.Left, Riga2RIV.Bottom, Riga1RIV.Width, Riga1RIV.Height)
                Dim Riga4RIV As New Rectangle(Riga1RIV.Left, Riga3RIV.Bottom, Riga1RIV.Width, Riga1RIV.Height)
                Dim Riga5RIV As New Rectangle(Riga1RIV.Left, Riga4RIV.Bottom, Riga1RIV.Width, Riga1RIV.Height)
                Dim RigaNoteRIV As New Rectangle(Riga1RIV.Left, Riga5RIV.Bottom, Riga1RIV.Width, Riga1RIV.Height)

                e.Graphics.DrawRectangles(Pens.LightGray, {Riga1RIV, Riga2RIV, Riga3RIV, Riga4RIV, Riga5RIV})

                Dim Q As Single = Riga1RIV.Width / 6

                Dim RectBRiv As New Rectangle(Riga2RIV.Left, Riga2RIV.Top, Q, Riga2RIV.Height)
                Dim RectCRiv As New Rectangle(Riga2RIV.Left, Riga3RIV.Top, Q, Riga2RIV.Height)
                Dim RectFRiv As New Rectangle(Riga3RIV.Left, Riga4RIV.Top, Q, Riga3RIV.Height)
                Dim RectTRiv As New Rectangle(Riga4RIV.Left, Riga5RIV.Top, Q, Riga4RIV.Height)

                Dim RectBRivValore As New Rectangle(RectBRiv.Right, Riga2RIV.Top, Q * 3, Riga2RIV.Height)
                Dim RectCRivValore As New Rectangle(RectBRiv.Right, Riga3RIV.Top, Q * 3, Riga2RIV.Height)
                Dim RectFRivValore As New Rectangle(RectFRiv.Right, Riga4RIV.Top, Q * 3, Riga3RIV.Height)
                Dim RectTRivValore As New Rectangle(RectTRiv.Right, Riga5RIV.Top, Q * 3, Riga4RIV.Height)

                Dim RectBRivQt As New Rectangle(RectBRivValore.Right, Riga2RIV.Top, Q, Riga2RIV.Height)
                Dim RectCRivQt As New Rectangle(RectCRivValore.Right, Riga3RIV.Top, Q, Riga2RIV.Height)
                Dim RectFRivQt As New Rectangle(RectFRivValore.Right, Riga4RIV.Top, Q, Riga3RIV.Height)
                Dim RectTRivQt As New Rectangle(RectTRivValore.Right, Riga5RIV.Top, Q, Riga4RIV.Height)

                Dim RectBRivQt2 As New Rectangle(RectBRivQt.Right, Riga2RIV.Top, Q, Riga2RIV.Height)
                Dim RectCRivQt2 As New Rectangle(RectBRivQt.Right, Riga3RIV.Top, Q, Riga2RIV.Height)
                Dim RectFRivQt2 As New Rectangle(RectFRivQt.Right, Riga4RIV.Top, Q, Riga3RIV.Height)
                Dim RectTRivQt2 As New Rectangle(RectTRivQt.Right, Riga5RIV.Top, Q, Riga4RIV.Height)


                e.Graphics.DrawRectangles(Pens.LightGray, {RectBRiv, RectCRiv, RectFRiv, RectTRiv, RectBRivQt, RectCRivQt, RectFRivQt, RectTRivQt})

                e.Graphics.DrawString("B", fnt, Brushes.Black, RectBRiv, FMT)
                e.Graphics.DrawString("C", fnt, Brushes.Black, RectCRiv, FMT)
                e.Graphics.DrawString("F", fnt, Brushes.Black, RectFRiv, FMT)
                e.Graphics.DrawString("T", fnt, Brushes.Black, RectTRiv, FMT)

                ScriviRivestimento(riga)

                e.Graphics.DrawString(Stringa1Riv, fnt, Brushes.Black, RectBRivValore, FMT)
                e.Graphics.DrawString(Stringa2Riv, fnt, Brushes.Black, RectCRivValore, FMT)
                e.Graphics.DrawString(Stringa3Riv, fnt, Brushes.Black, RectFRivValore, FMT)
                e.Graphics.DrawString(Stringa4Riv, fnt, Brushes.Black, RectTRivValore, FMT)

                e.Graphics.DrawString(stringa5riv, fnt, Brushes.Black, RigaNoteRIV, FMT)

                e.Graphics.DrawString(QT1Riv, fnt, Brushes.Black, RectBRivQt, FMT)
                e.Graphics.DrawString(QT2Riv, fnt, Brushes.Black, RectCRivQt, FMT)
                e.Graphics.DrawString(QT3Riv, fnt, Brushes.Black, RectFRivQt, FMT)
                e.Graphics.DrawString(QT4Riv, fnt, Brushes.Black, RectTRivQt, FMT)

                If riga.Qt > 1 Then
                    e.Graphics.DrawString("[" & riga.Qt * QT1Riv & "]", fnt, Brushes.Black, RectBRivQt2, FMT)
                    e.Graphics.DrawString("[" & riga.Qt * QT2Riv & "]", fnt, Brushes.Black, RectCRivQt2, FMT)
                    e.Graphics.DrawString("[" & riga.Qt * QT3Riv & "]", fnt, Brushes.Black, RectFRivQt2, FMT)
                    e.Graphics.DrawString("[" & riga.Qt * QT4Riv & "]", fnt, Brushes.Black, RectTRivQt2, FMT)
                End If

                e.Graphics.DrawString(DescrizioneRivestimento, New Font("Calibri", My.Settings.DimensioneFontDistinta, FontStyle.Bold), Brushes.Black, Riga1RIV, FMT)

                'Dim RectRIV As New Rectangle(Riga1RIV.Left, Riga1RIV.Top, Riga1RIV.Width, 125)
                e.Graphics.DrawRectangle(New Pen(Color.LightGray, 3), RectRivestimento)
            End If

            '######### INFO TIPO GABBIA ##########

            Morale(sender, e, riga, RectIMG.X, RectBarcode.Y) 'Disegno morale

            Dim InfoTipo As String = SQL.GetInfoTipo(riga.Tipo)

            If InfoTipo <> "" Then
                Dim RectInfoTipo As New Rectangle(RectRivestimento.Left, RectRivestimento.Bottom + 15, RectRivestimento.Width, 100)
                e.Graphics.FillRectangle(Brushes.LightYellow, RectInfoTipo)
                e.Graphics.DrawString(InfoTipo.ToUpper, New Font("Calibri", fnt.Size, FontStyle.Bold), Brushes.Black, RectInfoTipo, FMT)
            End If

        End Sub
        Private Sub StampaRiga(Sender As Object, e As Printing.PrintPageEventArgs, Riga As Rectangle, X As Decimal, Y As Decimal, Z As Decimal, N As Integer, Tag As String, QT As Integer)

            Dim Format As StringFormat = New StringFormat(StringFormatFlags.LineLimit) With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter}

            Dim FNT As New Font("Calibri", My.Settings.DimensioneFontDistinta)
            Dim FNTbold As New Font("Calibri", My.Settings.DimensioneFontDistinta, FontStyle.Bold)
            Dim FNT1 As New Font("Calibri", My.Settings.DimensioneFontDistinta - 2)
            Dim FNT_Tag As New Font("Calibri", 8, FontStyle.Italic)
            Dim FNT_TagBold As New Font("Calibri", 10, FontStyle.Underline Xor FontStyle.Bold)

            Dim Unit As Double = Riga.Width / 21

            If Y >= 4 Then FNT = FNTbold

            Dim R_CM As New Rectangle(Riga.Left, Riga.Top, Unit * 2, Riga.Height)
            Dim R_mX As New Rectangle(R_CM.Right, Riga.Top, Unit * 3, Riga.Height)
            Dim R_x1 As New Rectangle(R_mX.Right, Riga.Top, Unit, Riga.Height)
            Dim R_mY As New Rectangle(R_x1.Right, Riga.Top, Unit * 3, Riga.Height)
            Dim R_x2 As New Rectangle(R_mY.Right, Riga.Top, Unit, Riga.Height)
            Dim R_mZ As New Rectangle(R_x2.Right, Riga.Top, Unit * 3, Riga.Height)
            Dim R_Ug As New Rectangle(R_mZ.Right, Riga.Top, Unit, Riga.Height)
            Dim R_N As New Rectangle(R_Ug.Right, Riga.Top, Unit * 3, Riga.Height)
            Dim R_Ntot As New Rectangle(R_N.Right, Riga.Top, Unit * 4, Riga.Height)
            Dim R_Tag As New Rectangle(R_Ntot.Right, Riga.Top, Unit * 2, Riga.Height)

            'e.Graphics.DrawRectangle(New Pen(Color.LightGray, 0.5), R_Ntot)

            e.Graphics.DrawString("Cm", FNT1, Brushes.Black, R_CM, Format)
            e.Graphics.DrawString("x", FNT, Brushes.Black, R_x1, Format)
            e.Graphics.DrawString("x", FNT, Brushes.Black, R_x2, Format)
            e.Graphics.DrawString("=", FNT, Brushes.Black, R_Ug, Format)

            Dim R_mX_L As New Rectangle(R_mX.Left - Unit, R_mX.Top, R_mX.Width + (Unit * 2), R_mX.Height)
            Dim R_mY_L As New Rectangle(R_mY.Left - Unit, R_mY.Top, R_mY.Width + (Unit * 2), R_mY.Height)
            Dim R_mZ_L As New Rectangle(R_mZ.Left - Unit, R_mZ.Top, R_mZ.Width + (Unit * 2), R_mZ.Height)

            'Rettangoli più larghi cosi non si tronca
            e.Graphics.DrawString(X, FNT, Brushes.Black, R_mX_L, Format)
            e.Graphics.DrawString(Y, FNT, Brushes.Black, R_mY_L, Format)
            e.Graphics.DrawString(Z, FNT, Brushes.Black, R_mZ_L, Format)


            If Tag = "BTL" And DT = True Then
                e.Graphics.DrawString((N / 2) & "+" & (N / 2), FNT, Brushes.Black, R_N, Format)
            Else
                e.Graphics.DrawString(N, FNT, Brushes.Black, R_N, Format)
            End If

            If QT > 1 Then e.Graphics.DrawString("[" & N * QT & "]", FNT1, Brushes.Gray, R_Ntot, Format)

            If Tag = "FD" Or Tag = "TD" Then FNT_Tag = FNT_TagBold
            e.Graphics.DrawString(Tag, FNT_Tag, Brushes.Gray, R_Tag, Format)

        End Sub
        Private Sub Riempi_QuoteMorali(sender As Object, e As Printing.PrintPageEventArgs, Rect As Rectangle, PrimoMorale As Integer, Nmorali As Integer, LunghezzaTavola As Integer)

            Dim FONT As New Font("Helvetica", My.Settings.DimensioneFontDistinta - 4, FontStyle.Bold)

            Dim Format As StringFormat = New StringFormat(StringFormatFlags.LineLimit) With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter}


            Dim Quota As Integer = PrimoMorale
            Dim Interasse As Integer = (LunghezzaTavola - (PrimoMorale * 2)) / (Nmorali - 1)

            Dim Rwidth As Single = Rect.Width \ (Nmorali + 2)
            Dim sX As Single = Rect.Left
            Dim dX As Single = Rect.Right - Rwidth

            Dim RettangoloSX As New Rectangle(sX, Rect.Y, Rwidth, Rect.Height)
            Dim RettangoloDX As New Rectangle(dX, Rect.Y, Rwidth, Rect.Height)

            sX += Rwidth
            dX -= Rwidth

            For k = 1 To Math.Truncate(Nmorali / 2)

                RettangoloSX.X = sX
                RettangoloDX.X = dX

                e.Graphics.FillRectangle(Brushes.LightGray, sX, Rect.Y + 2, RettangoloSX.Width, 5)
                e.Graphics.FillRectangle(Brushes.LightGray, dX, Rect.Y + 2, RettangoloDX.Width, 5)
                e.Graphics.FillRectangle(Brushes.LightGray, sX + (Rwidth / 2) - 5, Rect.Y + 7, 10, 15)
                e.Graphics.FillRectangle(Brushes.LightGray, dX + (Rwidth / 2) - 5, Rect.Y + 7, 10, 15)

                e.Graphics.DrawString(Quota, FONT, Brushes.Black, RettangoloSX, FMT)
                e.Graphics.DrawString(Quota, FONT, Brushes.Black, RettangoloDX, FMT)

                sX += Rwidth
                dX -= Rwidth

                Quota += Interasse
            Next

            If Nmorali Mod 2 > 0 Then

                Dim Centro As Single = Rect.X + (Rect.Width / 2)
                e.Graphics.FillRectangle(Brushes.LightGray, sX, Rect.Y + 2, RettangoloSX.Width, 5)
                e.Graphics.FillRectangle(Brushes.LightGray, Centro - 5, Rect.Y + 7, 10, 15)

                e.Graphics.DrawString(LunghezzaTavola / 2, FONT, Brushes.Black, Rect, FMT)
            End If


        End Sub

        Public Sub Stampa_Distinte(sender As Object, e As Printing.PrintPageEventArgs, Riga As RigaOrdine)
            RiempiDataSetRivestimenti()

            Try
                CaricaDati(Riga)
                Intestazione(sender, e, Riga)
                PieDiPagina(sender, e, Riga)
                Distinta(sender, e, Riga)
                Pdf.Stampa(Riga.Imballo)
            Catch ex As Exception
                MsgBox("Errore durante la stampa della seguente riga:" & vbCrLf & "Ordine: " & Riga.NumeroOrdine & " Riga: " & Riga.Riga &
                       vbCrLf & "Imballo: " & Riga.Imballo & " Pz. " & Riga.Qt & vbCrLf & ex.Message)
            End Try

        End Sub

        Private Sub ScriviRivestimento(riga As RigaOrdine)

            Stringa1Riv = ""
            Stringa2Riv = ""
            Stringa3Riv = ""
            Stringa4Riv = ""
            stringa5riv = ""
            QT1Riv = 0
            QT2Riv = 0
            QT3Riv = 0
            QT4Riv = 0

            Dim TIPO As String = riga.Tipo


            For Each row As ModPackDBDataSet.Setup_RivestRow In SetupRiv
                If row.Tipo = TIPO Then

                    Stringa1Riv = riga.L + row._BX_ & " x " & riga.P + row._BY_
                    QT1Riv = 1

                    Stringa2Riv = riga.L + row._CX_ & " x " & riga.P + row._CY_
                    QT2Riv = 1

                    Stringa3Riv = riga.L + row._FX_ & " x " & riga.H + row._FY_
                    QT3Riv = 2

                    Stringa4Riv = riga.P + row._TX_ & " x " & riga.H + row._TY_
                    QT4Riv = 2

                    If Not row.IsNoteNull Then stringa5riv = row.Note

                End If
            Next

        End Sub

    End Module
End Namespace

