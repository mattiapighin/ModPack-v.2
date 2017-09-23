Imports System.Windows.Forms

Public Class Dialog_FiltraData

    Private _DataInizio As Date
    Public Property DataInizio() As Date
        Get
            Return _DataInizio
        End Get
        Set(ByVal value As Date)
            _DataInizio = value
        End Set
    End Property
    Private _DataFine As Date
    Public Property DataFine() As Date
        Get
            Return _DataFine
        End Get
        Set(ByVal value As Date)
            _DataFine = value
        End Set
    End Property


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        _DataInizio = DT_Inizio.Value
        _DataFine = DT_Fine.Value
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
