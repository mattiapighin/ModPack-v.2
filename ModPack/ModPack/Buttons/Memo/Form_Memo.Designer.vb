<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Memo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Memo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.RbData = New System.Windows.Forms.RadioButton()
        Me.TxtMemo = New System.Windows.Forms.TextBox()
        Me.Bt_Agenda = New System.Windows.Forms.Button()
        Me.Bt_Ok = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DatePicker)
        Me.GroupBox1.Controls.Add(Me.RbData)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 53)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ricordami per"
        '
        'DatePicker
        '
        Me.DatePicker.Location = New System.Drawing.Point(81, 17)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(200, 20)
        Me.DatePicker.TabIndex = 1
        '
        'RbData
        '
        Me.RbData.AutoSize = True
        Me.RbData.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RbData.Checked = True
        Me.RbData.Location = New System.Drawing.Point(24, 19)
        Me.RbData.Name = "RbData"
        Me.RbData.Size = New System.Drawing.Size(48, 17)
        Me.RbData.TabIndex = 0
        Me.RbData.TabStop = True
        Me.RbData.Text = "Data"
        Me.RbData.UseVisualStyleBackColor = True
        '
        'TxtMemo
        '
        Me.TxtMemo.BackColor = System.Drawing.SystemColors.Info
        Me.TxtMemo.Location = New System.Drawing.Point(12, 71)
        Me.TxtMemo.Multiline = True
        Me.TxtMemo.Name = "TxtMemo"
        Me.TxtMemo.Size = New System.Drawing.Size(296, 228)
        Me.TxtMemo.TabIndex = 1
        '
        'Bt_Agenda
        '
        Me.Bt_Agenda.FlatAppearance.BorderSize = 0
        Me.Bt_Agenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Agenda.Image = CType(resources.GetObject("Bt_Agenda.Image"), System.Drawing.Image)
        Me.Bt_Agenda.Location = New System.Drawing.Point(12, 305)
        Me.Bt_Agenda.Name = "Bt_Agenda"
        Me.Bt_Agenda.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Agenda.TabIndex = 4
        Me.Bt_Agenda.UseVisualStyleBackColor = True
        '
        'Bt_Ok
        '
        Me.Bt_Ok.FlatAppearance.BorderSize = 0
        Me.Bt_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Ok.Image = CType(resources.GetObject("Bt_Ok.Image"), System.Drawing.Image)
        Me.Bt_Ok.Location = New System.Drawing.Point(268, 305)
        Me.Bt_Ok.Name = "Bt_Ok"
        Me.Bt_Ok.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Ok.TabIndex = 2
        Me.Bt_Ok.UseVisualStyleBackColor = True
        '
        'Form_Memo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 355)
        Me.Controls.Add(Me.Bt_Agenda)
        Me.Controls.Add(Me.Bt_Ok)
        Me.Controls.Add(Me.TxtMemo)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_Memo"
        Me.Text = "Memo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DatePicker As DateTimePicker
    Friend WithEvents RbData As RadioButton
    Friend WithEvents TxtMemo As TextBox
    Friend WithEvents Bt_Ok As Button
    Friend WithEvents Bt_Agenda As Button
End Class
