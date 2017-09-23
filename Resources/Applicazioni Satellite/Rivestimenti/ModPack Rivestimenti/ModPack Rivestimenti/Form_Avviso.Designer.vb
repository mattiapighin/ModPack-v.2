<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Avviso
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
        Me.Bt_Chiudi = New System.Windows.Forms.Button()
        Me.LblRiv = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Bt_Chiudi
        '
        Me.Bt_Chiudi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Chiudi.Location = New System.Drawing.Point(296, 275)
        Me.Bt_Chiudi.Name = "Bt_Chiudi"
        Me.Bt_Chiudi.Size = New System.Drawing.Size(248, 62)
        Me.Bt_Chiudi.TabIndex = 0
        Me.Bt_Chiudi.Text = "OK"
        Me.Bt_Chiudi.UseVisualStyleBackColor = True
        '
        'LblRiv
        '
        Me.LblRiv.AutoSize = True
        Me.LblRiv.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRiv.Location = New System.Drawing.Point(193, 123)
        Me.LblRiv.Name = "LblRiv"
        Me.LblRiv.Size = New System.Drawing.Size(454, 26)
        Me.LblRiv.TabIndex = 1
        Me.LblRiv.Text = "SONO STATI AGGIUNTI NUOVI FILE RIVESTIMENTI !"
        Me.LblRiv.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form_Avviso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(841, 421)
        Me.Controls.Add(Me.LblRiv)
        Me.Controls.Add(Me.Bt_Chiudi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Avviso"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Avviso"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bt_Chiudi As Button
    Friend WithEvents LblRiv As Label
End Class
