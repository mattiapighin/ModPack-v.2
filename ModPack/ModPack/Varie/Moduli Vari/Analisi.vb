Namespace Analysis

    Module Analisi

        'PARAMETRI:

        '1 - Apertura form Ordini Aperti


        Public Sub AddValue(ByVal Parametro As Integer, ByVal Valore As Decimal)

            Using Tabella As New ModPackDBDataSetTableAdapters.AnalysisTableAdapter
                Tabella.Insert(Parametro, System.Environment.UserName, Date.Now, Valore)
            End Using

        End Sub

    End Module

End Namespace