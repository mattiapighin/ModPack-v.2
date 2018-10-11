<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DLG_Changelog
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
        Me.Lb_Changelog = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lb_Changelog
        '
        Me.Lb_Changelog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_Changelog.Location = New System.Drawing.Point(12, 9)
        Me.Lb_Changelog.Name = "Lb_Changelog"
        Me.Lb_Changelog.Size = New System.Drawing.Size(408, 243)
        Me.Lb_Changelog.TabIndex = 0
        Me.Lb_Changelog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DLG_Changelog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 261)
        Me.Controls.Add(Me.Lb_Changelog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DLG_Changelog"
        Me.Text = "Changelog"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lb_Changelog As Label
End Class
