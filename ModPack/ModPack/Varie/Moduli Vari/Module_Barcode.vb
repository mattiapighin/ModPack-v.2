
Namespace BarCode
    Module Module_BarCode

        Public Function Genera(ByVal Valore As String, Optional Testo As Boolean = False, Optional Height As Integer = 100, Optional SizeFont As Integer = 8) As System.Drawing.Image
            Try
                Dim Code As System.Drawing.Image
                Dim Estensione As String = Nothing

                Dim barcode As New iTextSharp.text.pdf.Barcode128() With {.BarHeight = Height, .AltText = Valore, .ChecksumText = True, .GenerateChecksum = True, .Code = Valore}


                Code = barcode.CreateDrawingImage(Color.Black, Color.White)

                If Testo = True Then

                    Dim FMT As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}

                    Dim G As Graphics
                    G = Graphics.FromImage(Code)

                    Dim MS As SizeF
                    MS = G.MeasureString(Valore, New Font(FontFamily.GenericMonospace, SizeFont))
                    MS.Width += 20
                    Dim Sfondo As New Rectangle(Code.Width / 2 - (MS.Width / 2), Code.Height - (MS.Height), MS.Width, MS.Height)

                    G.FillRectangle(Brushes.White, Sfondo)
                    G.DrawString(Valore, New Font("Calibri", SizeFont), Brushes.Black, Sfondo, FMT)
                End If


                Return Code
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function QR(ByVal Valore As String, Optional Height As Integer = 200) As System.Drawing.Image

            Dim IMAGE As Image

            Dim qrCode = New iTextSharp.text.pdf.qrcode.QRCodeWriter()
            Dim byteIMG = qrCode.Encode(Valore, Height, Height)
            Dim img = byteIMG.GetArray()
            Dim bmp = New Bitmap(Height, Height)
            Dim g = Graphics.FromImage(bmp)
            g.Clear(Color.White)

            For i = 0 To img.Length - 1
                For j = 0 To img.Length - 1

                    If (img(j)(i) = 0) Then
                        g.FillRectangle(Brushes.Black, i, j, 1, 1)
                    Else
                        g.FillRectangle(Brushes.White, i, j, 1, 1)
                    End If

                Next
            Next

            IMAGE = bmp

            Return IMAGE
        End Function

    End Module
End Namespace