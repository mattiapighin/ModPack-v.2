<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_TestConnessioni
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PN_s1 = New System.Windows.Forms.Panel()
        Me.Lbl_Nome1 = New System.Windows.Forms.Label()
        Me.Lbl_Ip1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lbl_Stato1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Lbl_Stato2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_Ip2 = New System.Windows.Forms.Label()
        Me.PN_s2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Lbl_Stato3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Lbl_Ip3 = New System.Windows.Forms.Label()
        Me.PN_s3 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'PN_s1
        '
        Me.PN_s1.Location = New System.Drawing.Point(7, 32)
        Me.PN_s1.Name = "PN_s1"
        Me.PN_s1.Size = New System.Drawing.Size(23, 23)
        Me.PN_s1.TabIndex = 0
        '
        'Lbl_Nome1
        '
        Me.Lbl_Nome1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Nome1.Location = New System.Drawing.Point(36, 9)
        Me.Lbl_Nome1.Name = "Lbl_Nome1"
        Me.Lbl_Nome1.Size = New System.Drawing.Size(212, 23)
        Me.Lbl_Nome1.TabIndex = 1
        Me.Lbl_Nome1.Text = "PC Sezionatrice"
        Me.Lbl_Nome1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Ip1
        '
        Me.Lbl_Ip1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Ip1.Location = New System.Drawing.Point(36, 32)
        Me.Lbl_Ip1.Name = "Lbl_Ip1"
        Me.Lbl_Ip1.Size = New System.Drawing.Size(212, 23)
        Me.Lbl_Ip1.TabIndex = 2
        Me.Lbl_Ip1.Text = "IP1"
        Me.Lbl_Ip1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Lbl_Stato1)
        Me.Panel2.Controls.Add(Me.Lbl_Nome1)
        Me.Panel2.Controls.Add(Me.Lbl_Ip1)
        Me.Panel2.Controls.Add(Me.PN_s1)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(256, 87)
        Me.Panel2.TabIndex = 3
        '
        'Lbl_Stato1
        '
        Me.Lbl_Stato1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Stato1.Location = New System.Drawing.Point(36, 55)
        Me.Lbl_Stato1.Name = "Lbl_Stato1"
        Me.Lbl_Stato1.Size = New System.Drawing.Size(212, 23)
        Me.Lbl_Stato1.TabIndex = 3
        Me.Lbl_Stato1.Text = "STATO1"
        Me.Lbl_Stato1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Lbl_Stato2)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Lbl_Ip2)
        Me.Panel3.Controls.Add(Me.PN_s2)
        Me.Panel3.Location = New System.Drawing.Point(12, 105)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(256, 87)
        Me.Panel3.TabIndex = 4
        '
        'Lbl_Stato2
        '
        Me.Lbl_Stato2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Stato2.Location = New System.Drawing.Point(36, 55)
        Me.Lbl_Stato2.Name = "Lbl_Stato2"
        Me.Lbl_Stato2.Size = New System.Drawing.Size(212, 23)
        Me.Lbl_Stato2.TabIndex = 3
        Me.Lbl_Stato2.Text = "STATO2"
        Me.Lbl_Stato2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(36, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PC Produzione"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Ip2
        '
        Me.Lbl_Ip2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Ip2.Location = New System.Drawing.Point(36, 32)
        Me.Lbl_Ip2.Name = "Lbl_Ip2"
        Me.Lbl_Ip2.Size = New System.Drawing.Size(212, 23)
        Me.Lbl_Ip2.TabIndex = 2
        Me.Lbl_Ip2.Text = "IP2"
        Me.Lbl_Ip2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PN_s2
        '
        Me.PN_s2.Location = New System.Drawing.Point(7, 32)
        Me.PN_s2.Name = "PN_s2"
        Me.PN_s2.Size = New System.Drawing.Size(23, 23)
        Me.PN_s2.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Lbl_Stato3)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Lbl_Ip3)
        Me.Panel5.Controls.Add(Me.PN_s3)
        Me.Panel5.Location = New System.Drawing.Point(12, 198)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(256, 87)
        Me.Panel5.TabIndex = 5
        '
        'Lbl_Stato3
        '
        Me.Lbl_Stato3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Stato3.Location = New System.Drawing.Point(36, 55)
        Me.Lbl_Stato3.Name = "Lbl_Stato3"
        Me.Lbl_Stato3.Size = New System.Drawing.Size(212, 23)
        Me.Lbl_Stato3.TabIndex = 3
        Me.Lbl_Stato3.Text = "STATO3"
        Me.Lbl_Stato3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(36, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(212, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "PC Riserva"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Ip3
        '
        Me.Lbl_Ip3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Ip3.Location = New System.Drawing.Point(36, 32)
        Me.Lbl_Ip3.Name = "Lbl_Ip3"
        Me.Lbl_Ip3.Size = New System.Drawing.Size(212, 23)
        Me.Lbl_Ip3.TabIndex = 2
        Me.Lbl_Ip3.Text = "IP3"
        Me.Lbl_Ip3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PN_s3
        '
        Me.PN_s3.Location = New System.Drawing.Point(7, 32)
        Me.PN_s3.Name = "PN_s3"
        Me.PN_s3.Size = New System.Drawing.Size(23, 23)
        Me.PN_s3.TabIndex = 0
        '
        'FRM_TestConnessioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 293)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FRM_TestConnessioni"
        Me.Text = "Test Connessioni"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PN_s1 As Panel
    Friend WithEvents Lbl_Nome1 As Label
    Friend WithEvents Lbl_Ip1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Lbl_Stato1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Lbl_Stato2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Lbl_Ip2 As Label
    Friend WithEvents PN_s2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Lbl_Stato3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Lbl_Ip3 As Label
    Friend WithEvents PN_s3 As Panel
End Class
