Module FunzioniVarie

    Public Function Get_WK(ByVal Data As Date) As Integer
        Return DatePart(DateInterval.WeekOfYear, Data, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFourDays)
    End Function

End Module
