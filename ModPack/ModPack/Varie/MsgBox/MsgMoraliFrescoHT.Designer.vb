<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MsgMoraliFrescoHT
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Bt_ListaMoraliFresco = New System.Windows.Forms.Button()
        Me.Bt_ListaMoraliHT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Bt_ListaMoraliFresco
        '
        Me.Bt_ListaMoraliFresco.Location = New System.Drawing.Point(12, 12)
        Me.Bt_ListaMoraliFresco.Name = "Bt_ListaMoraliFresco"
        Me.Bt_ListaMoraliFresco.Size = New System.Drawing.Size(188, 23)
        Me.Bt_ListaMoraliFresco.TabIndex = 2
        Me.Bt_ListaMoraliFresco.Text = "LISTA MORALI FRESCO"
        Me.Bt_ListaMoraliFresco.UseVisualStyleBackColor = True
        '
        'Bt_ListaMoraliHT
        '
        Me.Bt_ListaMoraliHT.Location = New System.Drawing.Point(12, 41)
        Me.Bt_ListaMoraliHT.Name = "Bt_ListaMoraliHT"
        Me.Bt_ListaMoraliHT.Size = New System.Drawing.Size(188, 23)
        Me.Bt_ListaMoraliHT.TabIndex = 3
        Me.Bt_ListaMoraliHT.Text = "LISTA MORALI HT"
        Me.Bt_ListaMoraliHT.UseVisualStyleBackColor = True
        '
        'MsgMoraliFrescoHT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(210, 76)
        Me.Controls.Add(Me.Bt_ListaMoraliHT)
        Me.Controls.Add(Me.Bt_ListaMoraliFresco)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MsgMoraliFrescoHT"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lista Morali"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bt_ListaMoraliFresco As Button
    Friend WithEvents Bt_ListaMoraliHT As Button
End Class
