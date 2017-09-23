Imports System.Xml

Namespace NomeImballo
    Module NomeImballo

        Dim Count As String



        Public Function CreaNome(ByVal Tipo As String, ByVal HT As Boolean) As String

            Dim xml = XDocument.Load(My.Settings.XMLpath)

            Count = xml.<Data>.<CodeCount>.Value + 1
            Dim Imballo As String = ""

            Dim Lettera As String = Tipo(0)

            'Eccezioni
            If Lettera = "T" Then Lettera = "P"
            Imballo = "M" & Lettera & Count
            If HT = True Then Imballo += "HT"

            Return Imballo
        End Function
        Public Sub AggiornaConteggio()
            Dim xml = XDocument.Load(My.Settings.XMLpath)
            xml.<Data>.<CodeCount>.Value = Count
            xml.Save(My.Settings.XMLpath)
        End Sub

        Public Function CreaDescrizione(ByVal L, P, H, Zoccoli, Tipo, HT, DT, BM, M3, Rivestimento, Optional TipoRivestimento = "") As String
            Dim Descrizione As String = ""

            Descrizione = "CM " & L & " x " & P
            If Tipo <> "P" And Tipo <> "T" Then Descrizione += " x " & H
            Descrizione += " " & Tipo & " " & Zoccoli

            If Rivestimento = True Then Descrizione += " (" & TipoRivestimento & ")"

            Descrizione += " - MC " & M3

            Return Descrizione
        End Function

    End Module
End Namespace