Imports System.Text.RegularExpressions

Public Class FRM_TestConnessioni

    Public Function IPValido(ByVal IP As String) As Boolean

        Dim Address As System.Net.IPAddress = Nothing

        If System.Net.IPAddress.TryParse(IP, Address) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub FRM_TestConnessioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim IPaddress As System.Net.IPAddress = Nothing

        Dim xml = XDocument.Load(My.Settings.XMLpath)
        Dim Ip_produzione As String = xml.<Data>.<IP_Produzione>.Value
        Dim Ip_sezionatrice As String = xml.<Data>.<IP_Sezionatrice>.Value
        Dim Ip_riserva As String = xml.<Data>.<IP_Riserva>.Value

        Lbl_Ip1.Text = Ip_sezionatrice
        Lbl_Ip2.Text = Ip_produzione
        Lbl_Ip3.Text = Ip_riserva

        Try
            If My.Computer.Network.Ping(Ip_sezionatrice) Then
                PN_s1.BackColor = Color.LightGreen
                Lbl_Stato1.Text = "STATO: Connesso"
            Else
                PN_s1.BackColor = Color.Red
                Lbl_Stato1.Text = "STATO: Disconnesso"
            End If
        Catch
            PN_s1.BackColor = Color.Blue
            Lbl_Stato1.Text = "STATO: IP Non valido"
        End Try


        Try
            If My.Computer.Network.Ping(Ip_produzione) Then
                PN_s2.BackColor = Color.LightGreen
                Lbl_Stato2.Text = "STATO: Connesso"
            Else
                PN_s2.BackColor = Color.Red
                Lbl_Stato2.Text = "STATO: Disconnesso"
            End If
        Catch
            PN_s2.BackColor = Color.Blue
            Lbl_Stato2.Text = "STATO: IP Non valido"
        End Try


        Try
            If My.Computer.Network.Ping(Ip_riserva) Then
                PN_s3.BackColor = Color.LightGreen
                Lbl_Stato3.Text = "STATO: Connesso"
            Else
                PN_s3.BackColor = Color.Red
                Lbl_Stato3.Text = "STATO: Disconnesso"
            End If
        Catch
            PN_s3.BackColor = Color.Blue
            Lbl_Stato3.Text = "STATO: IP Non valido"
        End Try

    End Sub
End Class