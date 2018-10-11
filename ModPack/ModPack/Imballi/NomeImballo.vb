Imports System.Xml

Namespace NomeImballo
    Module NomeImballo

        Dim Count As String

        Dim Ds As New ModPackDBDataSet
        Dim Table As New ModPackDBDataSetTableAdapters.ImballiTableAdapter

        'Public Function CreaNome(ByVal Tipo As String, ByVal HT As Boolean) As String
        '
        'Dim xml = XDocument.Load(My.Settings.XMLpath)
        '
        '   Count = xml.<Data>.<CodeCount>.Value + 1
        '
        'Dim Imballo As String = ""
        'Dim Lettera As String = Tipo(0)
        '
        'Eccezioni
        'If Lettera = "T" Then Lettera = "P"
        '   Imballo = "M" & Lettera & Count
        'If HT = True Then Imballo += "HT"
        '
        'Return Imballo
        '
        'End Function
        Public Function CreaNome(ByVal Tipo As String, ByVal HT As Boolean) As String

            'Modifica al 06/06/2018
            'Se il codice imballo che sta cercando di inserire esiste già lo salta e passa al prossimo numero

            Table.Fill(Ds.Imballi)

            Dim xml = XDocument.Load(My.Settings.XMLpath)
            Count = xml.<Data>.<CodeCount>.Value   'Valore progressivo codici già inseriti

            Dim NomeValido As Boolean = False
            Dim StringaLog As String = "Test nomi: "

            Dim Imballo As String = ""
            Dim Lettera As String = Tipo(0)

            Do
                Count += 1  'Aggiungo uno all'ultimo codice salvato

                'Eccezioni
                If Lettera = "T" Then Lettera = "P"
                Imballo = "M" & Lettera & Count     'Creo il nome dell'imballo
                If HT = True Then Imballo += "HT"

                NomeValido = Not Ds.Imballi.Any(Function(X) X.Imballo = Imballo)    'Se il nome non esiste già è valido
                StringaLog += Imballo & " "

            Loop Until NomeValido = True

            StringaLog += " ..OK!"
            LOG.Write(StringaLog)

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

            If HT = True Then Descrizione += " HT"

            If BM = True Then Descrizione += " BM"
            If DT = True Then Descrizione += " DT"

            If Rivestimento = True Then Descrizione += " (" & TipoRivestimento & ")"

            Descrizione += " - MC " & M3

            Return Descrizione
        End Function

    End Module
End Namespace