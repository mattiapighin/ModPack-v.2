<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Bt_Folder = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_Folder = New System.Windows.Forms.TextBox()
        Me.Bt_Crea = New System.Windows.Forms.Button()
        Me.Bt_Ripristina = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bt_Folder
        '
        Me.Bt_Folder.Location = New System.Drawing.Point(448, 22)
        Me.Bt_Folder.Name = "Bt_Folder"
        Me.Bt_Folder.Size = New System.Drawing.Size(75, 20)
        Me.Bt_Folder.TabIndex = 0
        Me.Bt_Folder.Text = "..."
        Me.Bt_Folder.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_Folder)
        Me.GroupBox1.Controls.Add(Me.Bt_Folder)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(529, 57)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Directory BackUp"
        '
        'Txt_Folder
        '
        Me.Txt_Folder.Location = New System.Drawing.Point(6, 22)
        Me.Txt_Folder.Name = "Txt_Folder"
        Me.Txt_Folder.Size = New System.Drawing.Size(436, 20)
        Me.Txt_Folder.TabIndex = 1
        '
        'Bt_Crea
        '
        Me.Bt_Crea.Location = New System.Drawing.Point(408, 99)
        Me.Bt_Crea.Name = "Bt_Crea"
        Me.Bt_Crea.Size = New System.Drawing.Size(133, 23)
        Me.Bt_Crea.TabIndex = 2
        Me.Bt_Crea.Text = "CREA"
        Me.Bt_Crea.UseVisualStyleBackColor = True
        '
        'Bt_Ripristina
        '
        Me.Bt_Ripristina.Location = New System.Drawing.Point(12, 99)
        Me.Bt_Ripristina.Name = "Bt_Ripristina"
        Me.Bt_Ripristina.Size = New System.Drawing.Size(133, 23)
        Me.Bt_Ripristina.TabIndex = 3
        Me.Bt_Ripristina.Text = "RIPRISTINA"
        Me.Bt_Ripristina.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(553, 134)
        Me.Controls.Add(Me.Bt_Ripristina)
        Me.Controls.Add(Me.Bt_Crea)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "ModPack BackUp"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Bt_Folder As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txt_Folder As TextBox
    Friend WithEvents Bt_Crea As Button
    Friend WithEvents Bt_Ripristina As Button
End Class
