<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Preferenze_Email
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Mail_Username = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Txt_Mail_ServerSMTP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Mail_PortaSMTP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGWDestinatari = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinatariEmailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModPackDBDataSet = New ModPack.ModPackDBDataSet()
        Me.Bt_Salva = New System.Windows.Forms.Button()
        Me.Bt_TestMail = New System.Windows.Forms.Button()
        Me.DestinatariEmailTableAdapter = New ModPack.ModPackDBDataSetTableAdapters.DestinatariEmailTableAdapter()
        Me.Txt_Mail_Password = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGWDestinatari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinatariEmailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModPackDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_Mail_Password)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Txt_Mail_Username)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 73)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Credenziali"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Txt_Mail_Username
        '
        Me.Txt_Mail_Username.Location = New System.Drawing.Point(65, 19)
        Me.Txt_Mail_Username.Name = "Txt_Mail_Username"
        Me.Txt_Mail_Username.Size = New System.Drawing.Size(243, 20)
        Me.Txt_Mail_Username.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Txt_Mail_ServerSMTP)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Txt_Mail_PortaSMTP)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(314, 49)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Smtp"
        '
        'Txt_Mail_ServerSMTP
        '
        Me.Txt_Mail_ServerSMTP.Location = New System.Drawing.Point(65, 19)
        Me.Txt_Mail_ServerSMTP.Name = "Txt_Mail_ServerSMTP"
        Me.Txt_Mail_ServerSMTP.Size = New System.Drawing.Size(151, 20)
        Me.Txt_Mail_ServerSMTP.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Server"
        '
        'Txt_Mail_PortaSMTP
        '
        Me.Txt_Mail_PortaSMTP.Location = New System.Drawing.Point(260, 19)
        Me.Txt_Mail_PortaSMTP.Name = "Txt_Mail_PortaSMTP"
        Me.Txt_Mail_PortaSMTP.Size = New System.Drawing.Size(48, 20)
        Me.Txt_Mail_PortaSMTP.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(222, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Porta"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGWDestinatari)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 146)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(314, 130)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Destinatari"
        '
        'DGWDestinatari
        '
        Me.DGWDestinatari.AutoGenerateColumns = False
        Me.DGWDestinatari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGWDestinatari.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGWDestinatari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGWDestinatari.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DGWDestinatari.DataSource = Me.DestinatariEmailBindingSource
        Me.DGWDestinatari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGWDestinatari.Location = New System.Drawing.Point(3, 16)
        Me.DGWDestinatari.Name = "DGWDestinatari"
        Me.DGWDestinatari.RowHeadersWidth = 15
        Me.DGWDestinatari.Size = New System.Drawing.Size(308, 111)
        Me.DGWDestinatari.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        Me.IdDataGridViewTextBoxColumn.Width = 41
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "Nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "Nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        Me.NomeDataGridViewTextBoxColumn.Width = 60
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 57
        '
        'DestinatariEmailBindingSource
        '
        Me.DestinatariEmailBindingSource.DataMember = "DestinatariEmail"
        Me.DestinatariEmailBindingSource.DataSource = Me.ModPackDBDataSet
        '
        'ModPackDBDataSet
        '
        Me.ModPackDBDataSet.DataSetName = "ModPackDBDataSet"
        Me.ModPackDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Bt_Salva
        '
        Me.Bt_Salva.Location = New System.Drawing.Point(250, 282)
        Me.Bt_Salva.Name = "Bt_Salva"
        Me.Bt_Salva.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Salva.TabIndex = 3
        Me.Bt_Salva.Text = "Salva"
        Me.Bt_Salva.UseVisualStyleBackColor = True
        '
        'Bt_TestMail
        '
        Me.Bt_TestMail.Location = New System.Drawing.Point(11, 282)
        Me.Bt_TestMail.Name = "Bt_TestMail"
        Me.Bt_TestMail.Size = New System.Drawing.Size(75, 23)
        Me.Bt_TestMail.TabIndex = 4
        Me.Bt_TestMail.Text = "Test"
        Me.Bt_TestMail.UseVisualStyleBackColor = True
        '
        'DestinatariEmailTableAdapter
        '
        Me.DestinatariEmailTableAdapter.ClearBeforeFill = True
        '
        'Txt_Mail_Password
        '
        Me.Txt_Mail_Password.Location = New System.Drawing.Point(65, 44)
        Me.Txt_Mail_Password.Name = "Txt_Mail_Password"
        Me.Txt_Mail_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Mail_Password.Size = New System.Drawing.Size(243, 20)
        Me.Txt_Mail_Password.TabIndex = 5
        '
        'Form_Preferenze_Email
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 314)
        Me.Controls.Add(Me.Bt_TestMail)
        Me.Controls.Add(Me.Bt_Salva)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_Preferenze_Email"
        Me.Text = "Opzioni Email"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGWDestinatari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinatariEmailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModPackDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Mail_Username As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Txt_Mail_ServerSMTP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_Mail_PortaSMTP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Bt_Salva As Button
    Friend WithEvents Bt_TestMail As Button
    Friend WithEvents DGWDestinatari As DataGridView
    Friend WithEvents ModPackDBDataSet As ModPackDBDataSet
    Friend WithEvents DestinatariEmailBindingSource As BindingSource
    Friend WithEvents DestinatariEmailTableAdapter As ModPackDBDataSetTableAdapters.DestinatariEmailTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Txt_Mail_Password As MaskedTextBox
End Class
