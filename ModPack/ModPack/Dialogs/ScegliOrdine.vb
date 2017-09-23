Imports System.Windows.Forms
Public Class ScegliOrdine

    Private _Ordine As String
    Public ReadOnly Property Ordine() As String
        Get
            Return _Ordine
        End Get

    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        _Ordine = ListBox1.SelectedItem
        Me.Close()
    End Sub

        Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

    Private Sub ScegliOrdine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        Dim Value As Object = Nothing

        Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)


            Using Cmd As New System.Data.SqlClient.SqlCommand("SELECT DISTINCT Ordine FROM Ordini WHERE Evaso = 'False'", Con)

                Try
                    Con.Open()  'Apre la connessione al db
                    Using Reader As System.Data.SqlClient.SqlDataReader = Cmd.ExecuteReader()

                        Do While Reader.Read
                            ListBox1.Items.Add(Reader.GetValue(0))
                        Loop

                    End Using
                Catch ex As System.Exception
                    MsgBox(ex.Message)
                End Try

            End Using
        End Using



    End Sub
End Class
