<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_NoteImballo
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
        Me.Tx_Imballo = New System.Windows.Forms.Label()
        Me.Tx_Nota = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Tx_Imballo
        '
        Me.Tx_Imballo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tx_Imballo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tx_Imballo.Location = New System.Drawing.Point(12, 9)
        Me.Tx_Imballo.Name = "Tx_Imballo"
        Me.Tx_Imballo.Size = New System.Drawing.Size(386, 31)
        Me.Tx_Imballo.TabIndex = 0
        Me.Tx_Imballo.Text = "IMBALLO"
        Me.Tx_Imballo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tx_Nota
        '
        Me.Tx_Nota.Location = New System.Drawing.Point(12, 45)
        Me.Tx_Nota.Multiline = True
        Me.Tx_Nota.Name = "Tx_Nota"
        Me.Tx_Nota.Size = New System.Drawing.Size(386, 155)
        Me.Tx_Nota.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.Location = New System.Drawing.Point(323, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Aggiungi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frm_NoteImballo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(410, 238)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tx_Nota)
        Me.Controls.Add(Me.Tx_Imballo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_NoteImballo"
        Me.Text = "Note Imballo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tx_Imballo As Label
    Friend WithEvents Tx_Nota As TextBox
    Friend WithEvents Button1 As Button
End Class
