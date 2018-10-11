Namespace FunzioniStampa
    Module MDL_FunzioniStampa

        Public Sub ImmagineInRettangolo(Immagine As Image, Rettangolo As Rectangle, e As Printing.PrintPageEventArgs)

            Dim xml = XDocument.Load(My.Settings.XMLpath)

            Dim TipoScala As Integer = xml.<Data>.<TipoScalaIMG>.Value
            'Tipo scala IMG 0 = scala normale
            'Tipo scala IMG 1 = scala XY

            If TipoScala = 0 Then
                Dim IMGScalata As New Size(((Rettangolo.Height * Immagine.Width) / Immagine.Height), Rettangolo.Height)
                Dim IMGScalataPoint As New Point((Rettangolo.X + (Rettangolo.Width / 2) - (IMGScalata.Width / 2)), Rettangolo.Y)
                e.Graphics.DrawImage(Immagine, IMGScalataPoint.X + 5, IMGScalataPoint.Y + 5, IMGScalata.Width - 10, IMGScalata.Height - 10)
            Else
                Dim imgscalata As New Size
                If Immagine.Height >= Immagine.Width Then
                    imgscalata.Height = Rettangolo.Height
                    imgscalata.Width = ((Rettangolo.Height * Immagine.Width) / Immagine.Height)
                Else
                    imgscalata.Width = Rettangolo.Width
                    imgscalata.Height = ((Immagine.Height * Rettangolo.Width) / Immagine.Width)
                End If
                Dim IMGScalataPoint As New Point((Rettangolo.X + (Rettangolo.Width / 2) - (imgscalata.Width / 2)), (Rettangolo.Y + (Rettangolo.Height / 2) - (imgscalata.Height / 2)))
                e.Graphics.DrawImage(Immagine, IMGScalataPoint.X + 15, IMGScalataPoint.Y + 15, imgscalata.Width - 30, imgscalata.Height - 30)
            End If

        End Sub

        Public Function TestoInRettangolo(Testo As String, Rettangolo As Rectangle, e As Printing.PrintPageEventArgs) As Integer
            Dim Dimensione As Integer = 30
            Dim Larghezza As SizeF = e.Graphics.MeasureString(Testo, New Font("Calibri", Dimensione, FontStyle.Bold))

            Do Until Larghezza.Width < Rettangolo.Width
                Dimensione -= 1
                Larghezza = e.Graphics.MeasureString(Testo, New Font("Calibri", Dimensione, FontStyle.Bold))
            Loop

            Return Dimensione
        End Function



    End Module
End Namespace