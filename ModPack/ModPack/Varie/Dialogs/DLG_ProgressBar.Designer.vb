<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DLG_ProgressBar
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
        Me.LB_Descrizione = New System.Windows.Forms.Label()
        Me.PBar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'LB_Descrizione
        '
        Me.LB_Descrizione.Location = New System.Drawing.Point(15, 9)
        Me.LB_Descrizione.Name = "LB_Descrizione"
        Me.LB_Descrizione.Size = New System.Drawing.Size(408, 23)
        Me.LB_Descrizione.TabIndex = 1
        Me.LB_Descrizione.Text = "Descrizione evento"
        Me.LB_Descrizione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PBar
        '
        Me.PBar.Location = New System.Drawing.Point(15, 39)
        Me.PBar.Name = "PBar"
        Me.PBar.Size = New System.Drawing.Size(408, 23)
        Me.PBar.TabIndex = 2
        '
        'DLG_ProgressBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 71)
        Me.Controls.Add(Me.PBar)
        Me.Controls.Add(Me.LB_Descrizione)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DLG_ProgressBar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LB_Descrizione As Label
    Friend WithEvents PBar As ProgressBar
End Class
