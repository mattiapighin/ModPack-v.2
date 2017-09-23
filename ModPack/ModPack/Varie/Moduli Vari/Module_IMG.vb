Namespace Immagine
    Module Module_IMG

        Public Function ConvertToBytes(Image As Image) As Byte()
            Dim ImmagineConvertita As Byte()

            Dim converter As New ImageConverter
            ImmagineConvertita = converter.ConvertTo(Image, GetType(Byte()))

            Return ImmagineConvertita
        End Function

        Public Function ConvertFromBytes(imgbytes As Byte()) As Image
            Dim lb() As Byte = imgbytes
            Dim lstr As New System.IO.MemoryStream(lb)
            Return Image.FromStream(lstr)
        End Function


    End Module
End Namespace

