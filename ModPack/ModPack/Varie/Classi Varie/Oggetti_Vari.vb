
Public Class Tipo
    Private _Tipo As String
    Public Property Tipo() As String
        Get
            Return _Tipo
        End Get
        Set(ByVal value As String)
            _Tipo = value
        End Set
    End Property
    Private _Descizione As String
    Public Property Descrizione() As String
        Get
            Return _Descizione
        End Get
        Set(ByVal value As String)
            _Descizione = value
        End Set
    End Property
    Private _intMax As Integer
    Public Property InterasseMax() As Integer
        Get
            Return _intMax
        End Get
        Set(ByVal value As Integer)
            _intMax = value
        End Set
    End Property
    Private _SpazioBTL As Integer
    Public Property SpazioBTL() As Integer
        Get
            Return _SpazioBTL
        End Get
        Set(ByVal value As Integer)
            _SpazioBTL = value
        End Set
    End Property
    Private _SpazioBTT As Integer
    Public Property SpazioBTT() As Integer
        Get
            Return _SpazioBTT
        End Get
        Set(ByVal value As Integer)
            _SpazioBTT = value
        End Set
    End Property
    Private _SpazioCTL As Integer
    Public Property SpazioCTL() As Integer
        Get
            Return _SpazioCTL
        End Get
        Set(ByVal value As Integer)
            _SpazioCTL = value
        End Set
    End Property
    Private _SpazioFTL As Integer
    Public Property SpazioFTL() As Integer
        Get
            Return _SpazioFTL
        End Get
        Set(ByVal value As Integer)
            _SpazioFTL = value
        End Set
    End Property
    Private _SpazioMT As Integer
    Public Property SpazioMT() As Integer
        Get
            Return _SpazioMT
        End Get
        Set(ByVal value As Integer)
            _SpazioMT = value
        End Set
    End Property
    Private _Info As String
    Public Property Info() As String
        Get
            Return _Info
        End Get
        Set(ByVal value As String)
            _Info = value
        End Set
    End Property
    Private _PrezzoM3 As Single
    Public Property PrezzoM3() As Single
        Get
            Return _PrezzoM3
        End Get
        Set(ByVal value As Single)
            _PrezzoM3 = value
        End Set
    End Property
End Class

Public Class Riga_Distinta
    Private _Part As String
    Public Property Part() As String
        Get
            Return _Part
        End Get
        Set(ByVal value As String)
            _Part = value
        End Set
    End Property
    Private _X As Single
    Public Property X() As Single
        Get
            Return _X
        End Get
        Set(ByVal value As Single)
            _X = value
        End Set
    End Property
    Private _Y As Single
    Public Property Y() As Single
        Get
            Return _Y
        End Get
        Set(ByVal value As Single)
            _Y = value
        End Set
    End Property
    Private _Z As Single
    Public Property Z() As Single
        Get
            Return _Z
        End Get
        Set(ByVal value As Single)
            _Z = value
        End Set
    End Property
    Private _N As Integer
    Public Property N() As Integer
        Get
            Return _N
        End Get
        Set(ByVal value As Integer)
            _N = value
        End Set
    End Property
    Private _Tag As String
    Public Property Tag() As String
        Get
            Return _Tag
        End Get
        Set(ByVal value As String)
            _Tag = value
        End Set
    End Property
End Class

Public Class RigaOrdine
    Private _NumeroOrdine As String
    Public Property NumeroOrdine() As String
        Get
            Return _NumeroOrdine
        End Get
        Set(ByVal value As String)
            _NumeroOrdine = value
        End Set
    End Property

    Private _Riga As Integer
    Public Property Riga() As Integer
        Get
            Return _Riga
        End Get
        Set(ByVal value As Integer)
            _Riga = value
        End Set
    End Property

    Private _Imballo As String = ""
    Public Property Imballo() As String
        Get
            Return _Imballo
        End Get
        Set(ByVal value As String)
            _Imballo = value
        End Set
    End Property

    Private _Indice As Integer
    Public Property Indice() As Integer
        Get
            Return _Indice
        End Get
        Set(ByVal value As Integer)
            _Indice = value
        End Set
    End Property

    Private _Qt As Integer
    Public Property Qt() As Integer
        Get
            Return _Qt
        End Get
        Set(ByVal value As Integer)
            _Qt = value
        End Set
    End Property

    Private _Cliente As String
    Public Property Cliente() As String
        Get
            Return _Cliente
        End Get
        Set(ByVal value As String)
            _Cliente = value
        End Set
    End Property

    Private _Codice As String
    Public Property Codice() As String
        Get
            Return _Codice
        End Get
        Set(ByVal value As String)
            _Codice = value
        End Set
    End Property

    Private _Commessa As String
    Public Property Commessa() As String
        Get
            Return _Commessa
        End Get
        Set(ByVal value As String)
            _Commessa = value
        End Set
    End Property

    Private _L As Integer
    Public Property L() As Integer
        Get
            Return _L
        End Get
        Set(ByVal value As Integer)
            _L = value
        End Set
    End Property

    Private _P As Integer
    Public Property P() As Integer
        Get
            Return _P
        End Get
        Set(ByVal value As Integer)
            _P = value
        End Set
    End Property

    Private _H As Integer
    Public Property H() As Integer
        Get
            Return _H
        End Get
        Set(ByVal value As Integer)
            _H = value
        End Set
    End Property

    Private _Tipo As String
    Public Property Tipo() As String
        Get
            Return _Tipo
        End Get
        Set(ByVal value As String)
            _Tipo = value
        End Set
    End Property

    Private _Zoccoli As String
    Public Property Zoccoli() As String
        Get
            Return _Zoccoli
        End Get
        Set(ByVal value As String)
            _Zoccoli = value
        End Set
    End Property

    Private _Rivestimento As Boolean
    Public Property Rivestimento() As Boolean
        Get
            Return _Rivestimento
        End Get
        Set(ByVal value As Boolean)
            _Rivestimento = value
        End Set
    End Property

    Private _TipoRivestimento As String
    Public Property TipoRivestimento() As String
        Get
            Return _TipoRivestimento
        End Get
        Set(ByVal value As String)
            _TipoRivestimento = value
        End Set
    End Property

    Private _Note As String
    Public Property Note() As String
        Get
            Return _Note
        End Get
        Set(ByVal value As String)
            _Note = value
        End Set
    End Property

    Private _DataConsegna As Date
    Public Property DataConsegna() As Date
        Get
            Return _DataConsegna
        End Get
        Set(ByVal value As Date)
            _DataConsegna = value
        End Set
    End Property

    Private _HT As Boolean
    Public Property HT() As Boolean
        Get
            Return _HT
        End Get
        Set(ByVal value As Boolean)
            _HT = value
        End Set
    End Property

    Private _DT As Boolean
    Public Property DT() As Boolean
        Get
            Return _DT
        End Get
        Set(ByVal value As Boolean)
            _DT = value
        End Set
    End Property

    Private _BM As Boolean
    Public Property BM() As Boolean
        Get
            Return _BM
        End Get
        Set(ByVal value As Boolean)
            _BM = value
        End Set
    End Property

    Private _Rivest_Tot As String
    Public Property Rivest_Tot() As String
        Get
            Return _Rivest_Tot
        End Get
        Set(ByVal value As String)
            _Rivest_Tot = value
        End Set
    End Property

    Private _Magazzino As String
    Public Property Magazzino() As String
        Get
            Return _Magazzino
        End Get
        Set(ByVal value As String)
            _Magazzino = value
        End Set
    End Property

    Private _Diagonali As Boolean
    Public Property Diagonali() As Boolean
        Get
            Return _Diagonali
        End Get
        Set(ByVal value As Boolean)
            _Diagonali = value
        End Set
    End Property

    Private _Stampato As Boolean
    Public Property Stampato() As Boolean
        Get
            Return _Stampato
        End Get
        Set(ByVal value As Boolean)
            _Stampato = value
        End Set
    End Property

    Private _Produzione As Boolean
    Public Property Produzione() As Boolean
        Get
            Return _Produzione
        End Get
        Set(ByVal value As Boolean)
            _Produzione = value
        End Set
    End Property

    Private _Evaso As Boolean
    Public Property Evaso() As Boolean
        Get
            Return _Evaso
        End Get
        Set(ByVal value As Boolean)
            _Evaso = value
        End Set
    End Property

    Private _DataOrdine As Date
    Public Property Data_Ordine() As Date
        Get
            Return _DataOrdine
        End Get
        Set(ByVal value As Date)
            _DataOrdine = value
        End Set
    End Property
End Class

Public Class RigaOrdineINPUT
    Private _NumeroOrdine As String = ""
    Public Property NumeroOrdine() As String
        Get
            Return _NumeroOrdine
        End Get
        Set(ByVal value As String)
            _NumeroOrdine = value
        End Set
    End Property

    Private _Riga As Integer
    Public Property Riga() As Integer
        Get
            Return _Riga
        End Get
        Set(ByVal value As Integer)
            _Riga = value
        End Set
    End Property

    Private _Indice As Integer
    Public Property Indice() As Integer
        Get
            Return _Indice
        End Get
        Set(ByVal value As Integer)
            _Indice = value
        End Set
    End Property

    Private _Qt As Integer
    Public Property Qt() As Integer
        Get
            Return _Qt
        End Get
        Set(ByVal value As Integer)
            _Qt = value
        End Set
    End Property

    Private _Cliente As String = ""
    Public Property Cliente() As String
        Get
            Return _Cliente
        End Get
        Set(ByVal value As String)
            _Cliente = value
        End Set
    End Property

    Private _Codice As String = ""
    Public Property Codice() As String
        Get
            Return _Codice
        End Get
        Set(ByVal value As String)
            _Codice = value
        End Set
    End Property

    Private _Commessa As String = ""
    Public Property Commessa() As String
        Get
            Return _Commessa
        End Get
        Set(ByVal value As String)
            _Commessa = value
        End Set
    End Property

    Private _L As Integer
    Public Property L() As Integer
        Get
            Return _L
        End Get
        Set(ByVal value As Integer)
            _L = value
        End Set
    End Property

    Private _P As Integer
    Public Property P() As Integer
        Get
            Return _P
        End Get
        Set(ByVal value As Integer)
            _P = value
        End Set
    End Property

    Private _H As Integer
    Public Property H() As Integer
        Get
            Return _H
        End Get
        Set(ByVal value As Integer)
            _H = value
        End Set
    End Property

    Private _Tipo As String = ""
    Public Property Tipo() As String
        Get
            Return _Tipo
        End Get
        Set(ByVal value As String)
            _Tipo = value
        End Set
    End Property

    Private _Zoccoli As String = ""
    Public Property Zoccoli() As String
        Get
            Return _Zoccoli
        End Get
        Set(ByVal value As String)
            _Zoccoli = value
        End Set
    End Property

    Private _Rivestimento As Boolean
    Public Property Rivestimento() As Boolean
        Get
            Return _Rivestimento
        End Get
        Set(ByVal value As Boolean)
            _Rivestimento = value
        End Set
    End Property

    Private _TipoRivestimento As String = ""
    Public Property TipoRivestimento() As String
        Get
            Return _TipoRivestimento
        End Get
        Set(ByVal value As String)
            _TipoRivestimento = value
        End Set
    End Property

    Private _Note As String = ""
    Public Property Note() As String
        Get
            Return _Note
        End Get
        Set(ByVal value As String)
            _Note = value
        End Set
    End Property

    Private _DataConsegna As Date
    Public Property DataConsegna() As Date
        Get
            Return _DataConsegna
        End Get
        Set(ByVal value As Date)
            _DataConsegna = value
        End Set
    End Property

    Private _HT As Boolean
    Public Property HT() As Boolean
        Get
            Return _HT
        End Get
        Set(ByVal value As Boolean)
            _HT = value
        End Set
    End Property

    Private _DT As Boolean
    Public Property DT() As Boolean
        Get
            Return _DT
        End Get
        Set(ByVal value As Boolean)
            _DT = value
        End Set
    End Property

    Private _BM As Boolean
    Public Property BM() As Boolean
        Get
            Return _BM
        End Get
        Set(ByVal value As Boolean)
            _BM = value
        End Set
    End Property

    Private _Rivest_Tot As String = ""
    Public Property Rivest_Tot() As String
        Get
            Return _Rivest_Tot
        End Get
        Set(ByVal value As String)
            _Rivest_Tot = value
        End Set
    End Property

    Private _Diagonali As Boolean
    Public Property Diagonali() As Boolean
        Get
            Return _Diagonali
        End Get
        Set(ByVal value As Boolean)
            _Diagonali = value
        End Set
    End Property

End Class

Public Class RigaImballi
    Private _Nome As String
    Public Property Nome() As String
        Get
            Return _Nome
        End Get
        Set(ByVal value As String)
            _Nome = value
        End Set
    End Property
    Private _L As Integer
    Public Property L() As Integer
        Get
            Return _L
        End Get
        Set(ByVal value As Integer)
            _L = value
        End Set
    End Property
    Private _P As Integer
    Public Property P() As Integer
        Get
            Return _P
        End Get
        Set(ByVal value As Integer)
            _P = value
        End Set
    End Property
    Private _H As Integer
    Public Property H() As Integer
        Get
            Return _H
        End Get
        Set(ByVal value As Integer)
            _H = value
        End Set
    End Property
    Private _Tipo As String
    Public Property TIpo() As String
        Get
            Return _Tipo
        End Get
        Set(ByVal value As String)
            _Tipo = value
        End Set
    End Property
    Private _Zoccoli As String
    Public Property Zoccoli() As String
        Get
            Return _Zoccoli
        End Get
        Set(ByVal value As String)
            _Zoccoli = value
        End Set
    End Property
    Private _Rivestimento As Boolean
    Public Property Rivestimento() As Boolean
        Get
            Return _Rivestimento
        End Get
        Set(ByVal value As Boolean)
            _Rivestimento = value
        End Set
    End Property
    Private _TipoRiv As String
    Public Property TipoRivestimento() As String
        Get
            Return _TipoRiv
        End Get
        Set(ByVal value As String)
            _TipoRiv = value
        End Set
    End Property
    Private _HT As Boolean
    Public Property HT() As Boolean
        Get
            Return _Ht
        End Get
        Set(ByVal value As Boolean)
            _Ht = value
        End Set
    End Property
    Private _DT As Boolean
    Public Property DT() As Boolean
        Get
            Return _DT
        End Get
        Set(ByVal value As Boolean)
            _DT = value
        End Set
    End Property
    Private _BM As Boolean
    Public Property BM() As Boolean
        Get
            Return _BM
        End Get
        Set(ByVal value As Boolean)
            _BM = value
        End Set
    End Property
    Private _Diagonali As Boolean
    Public Property Diagonali() As Boolean
        Get
            Return _Diagonali
        End Get
        Set(ByVal value As Boolean)
            _Diagonali = value
        End Set
    End Property
    Private _GradiF As Integer
    Public Property GradiF() As Integer
        Get
            Return _GradiF
        End Get
        Set(ByVal value As Integer)
            _GradiF = value
        End Set
    End Property
    Private _GradiT As Integer
    Public Property GradiT() As Integer
        Get
            Return _GradiT
        End Get
        Set(ByVal value As Integer)
            _GradiT = value
        End Set
    End Property
    Private _PrimoMorale As Integer
    Public Property PrimoMorale() As Integer
        Get
            Return _PrimoMorale
        End Get
        Set(ByVal value As Integer)
            _PrimoMorale = value
        End Set
    End Property
    Private _M2 As Single
    Public Property M2() As Single
        Get
            Return _M2
        End Get
        Set(ByVal value As Single)
            _M2 = value
        End Set
    End Property
    Private _M3 As Single
    Public Property M3() As Single
        Get
            Return _M3
        End Get
        Set(ByVal value As Single)
            _M3 = value
        End Set
    End Property
    Private _Prezzo As Single
    Public Property Prezzo() As Single
        Get
            Return _Prezzo
        End Get
        Set(ByVal value As Single)
            _Prezzo = value
        End Set
    End Property
    Private _Image As Image
    Public Property Image() As Image
        Get
            Return _Image
        End Get
        Set(ByVal value As Image)
            _Image = value
        End Set
    End Property
    Private _DataCreazione As Date
    Public Property DataCreazione() As Date
        Get
            Return _DataCreazione
        End Get
        Set(ByVal value As Date)
            _DataCreazione = value
        End Set
    End Property
    Private _SottoMontanteF As Integer
    Public Property SottoMF() As Integer
        Get
            Return _SottoMontanteF
        End Get
        Set(ByVal value As Integer)
            _SottoMontanteF = value
        End Set
    End Property
    Private _SottoMontanteT As Integer
    Public Property SottoMT() As Integer
        Get
            Return _SottoMontanteT
        End Get
        Set(ByVal value As Integer)
            _SottoMontanteT = value
        End Set
    End Property
    Private _SopraMontanteF As Integer
    Public Property SopraMF() As Integer
        Get
            Return _SopraMontanteF
        End Get
        Set(ByVal value As Integer)
            _SopraMontanteF = value
        End Set
    End Property
    Private _SopraMontanteT As Integer
    Public Property SopraMT() As Integer
        Get
            Return _SopraMontanteT
        End Get
        Set(ByVal value As Integer)
            _SopraMontanteT = value
        End Set
    End Property

End Class

Public Class Memo
    Private _Data As Date
    Public Property Data() As Date
        Get
            Return _Data
        End Get
        Set(ByVal value As Date)
            _Data = value
        End Set
    End Property

    Private _Memo As String
    Public Property Memo() As String
        Get
            Return _Memo
        End Get
        Set(ByVal value As String)
            _Memo = value
        End Set
    End Property

    Private _Imballo As String
    Public Property Imballo() As String
        Get
            Return _Imballo
        End Get
        Set(ByVal value As String)
            _Imballo = value
        End Set
    End Property
End Class

Public Class DestinatarioMail
    Private _Nome As String
    Public Property Nome() As String
        Get
            Return _Nome
        End Get
        Set(ByVal value As String)
            _Nome = value
        End Set
    End Property

    Private _Email As String
    Public Property Email() As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            _Email = value
        End Set
    End Property
End Class