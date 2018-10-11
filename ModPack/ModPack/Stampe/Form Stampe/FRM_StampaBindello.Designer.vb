<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_StampaBindello
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_StampaBindello))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CB_Magazzini = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Tx_Cliente = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Tx_Disegno = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Tx_Commessa = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Tx_Imballo = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.NU_Qt = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Tx_Ordine = New System.Windows.Forms.TextBox()
        Me.Bt_Stampa = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.NU_Qt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DatePicker)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 47)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consegna"
        '
        'DatePicker
        '
        Me.DatePicker.Location = New System.Drawing.Point(6, 19)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(188, 20)
        Me.DatePicker.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CB_Magazzini)
        Me.GroupBox2.Location = New System.Drawing.Point(218, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 47)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Magazzino"
        '
        'CB_Magazzini
        '
        Me.CB_Magazzini.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Magazzini.FormattingEnabled = True
        Me.CB_Magazzini.Location = New System.Drawing.Point(6, 19)
        Me.CB_Magazzini.Name = "CB_Magazzini"
        Me.CB_Magazzini.Size = New System.Drawing.Size(188, 21)
        Me.CB_Magazzini.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Tx_Cliente)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(406, 49)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cliente"
        '
        'Tx_Cliente
        '
        Me.Tx_Cliente.Location = New System.Drawing.Point(6, 19)
        Me.Tx_Cliente.Name = "Tx_Cliente"
        Me.Tx_Cliente.Size = New System.Drawing.Size(394, 20)
        Me.Tx_Cliente.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Tx_Disegno)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 120)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 48)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Disegno"
        '
        'Tx_Disegno
        '
        Me.Tx_Disegno.Location = New System.Drawing.Point(6, 19)
        Me.Tx_Disegno.Name = "Tx_Disegno"
        Me.Tx_Disegno.Size = New System.Drawing.Size(188, 20)
        Me.Tx_Disegno.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Tx_Commessa)
        Me.GroupBox5.Location = New System.Drawing.Point(218, 120)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 48)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Commessa"
        '
        'Tx_Commessa
        '
        Me.Tx_Commessa.Location = New System.Drawing.Point(6, 19)
        Me.Tx_Commessa.Name = "Tx_Commessa"
        Me.Tx_Commessa.Size = New System.Drawing.Size(188, 20)
        Me.Tx_Commessa.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Tx_Imballo)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 174)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(146, 48)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Imballo"
        '
        'Tx_Imballo
        '
        Me.Tx_Imballo.Location = New System.Drawing.Point(6, 19)
        Me.Tx_Imballo.Name = "Tx_Imballo"
        Me.Tx_Imballo.Size = New System.Drawing.Size(132, 20)
        Me.Tx_Imballo.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.NU_Qt)
        Me.GroupBox7.Location = New System.Drawing.Point(164, 174)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(102, 48)
        Me.GroupBox7.TabIndex = 3
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Qt"
        '
        'NU_Qt
        '
        Me.NU_Qt.Location = New System.Drawing.Point(6, 19)
        Me.NU_Qt.Name = "NU_Qt"
        Me.NU_Qt.Size = New System.Drawing.Size(90, 20)
        Me.NU_Qt.TabIndex = 5
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Tx_Ordine)
        Me.GroupBox8.Location = New System.Drawing.Point(272, 174)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(146, 48)
        Me.GroupBox8.TabIndex = 3
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Ordine"
        '
        'Tx_Ordine
        '
        Me.Tx_Ordine.Location = New System.Drawing.Point(6, 19)
        Me.Tx_Ordine.Name = "Tx_Ordine"
        Me.Tx_Ordine.Size = New System.Drawing.Size(132, 20)
        Me.Tx_Ordine.TabIndex = 0
        '
        'Bt_Stampa
        '
        Me.Bt_Stampa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_Stampa.FlatAppearance.BorderSize = 0
        Me.Bt_Stampa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Stampa.Image = CType(resources.GetObject("Bt_Stampa.Image"), System.Drawing.Image)
        Me.Bt_Stampa.Location = New System.Drawing.Point(378, 224)
        Me.Bt_Stampa.Name = "Bt_Stampa"
        Me.Bt_Stampa.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Stampa.TabIndex = 5
        Me.Bt_Stampa.UseVisualStyleBackColor = True
        '
        'FRM_StampaBindello
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 267)
        Me.Controls.Add(Me.Bt_Stampa)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FRM_StampaBindello"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stampa Bindello"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.NU_Qt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DatePicker As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CB_Magazzini As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Tx_Cliente As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Tx_Disegno As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Tx_Commessa As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Tx_Imballo As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents NU_Qt As NumericUpDown
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Tx_Ordine As TextBox
    Friend WithEvents Bt_Stampa As Button
End Class
