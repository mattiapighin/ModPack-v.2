<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DLG_Analisi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DLG_Analisi))
        Me.LST_Utenti = New System.Windows.Forms.ListBox()
        Me.GRP_Utenti = New System.Windows.Forms.GroupBox()
        Me.Grafico = New System.Windows.Forms.PictureBox()
        Me.Bt_Mostra = New System.Windows.Forms.Button()
        Me.NU_Valori = New System.Windows.Forms.NumericUpDown()
        Me.Ck_Etichette = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ck_MostraData = New System.Windows.Forms.CheckBox()
        Me.Ck_MostraOra = New System.Windows.Forms.CheckBox()
        Me.GRP_Opzioni = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CK_Sovrapponi = New System.Windows.Forms.CheckBox()
        Me.GRP_Parametri = New System.Windows.Forms.GroupBox()
        Me.DGW_Parametri = New System.Windows.Forms.DataGridView()
        Me.Parametro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descrizione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnalysisTable = New ModPack.ModPackDBDataSetTableAdapters.AnalysisTableAdapter()
        Me.DS = New ModPack.ModPackDBDataSet()
        Me.Analysis_DescrizioneTable = New ModPack.ModPackDBDataSetTableAdapters.Analysis_DescrizioneTableAdapter()
        Me.GRP_Utenti.SuspendLayout()
        CType(Me.Grafico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NU_Valori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRP_Opzioni.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GRP_Parametri.SuspendLayout()
        CType(Me.DGW_Parametri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LST_Utenti
        '
        Me.LST_Utenti.FormattingEnabled = True
        Me.LST_Utenti.Location = New System.Drawing.Point(6, 19)
        Me.LST_Utenti.Name = "LST_Utenti"
        Me.LST_Utenti.Size = New System.Drawing.Size(188, 186)
        Me.LST_Utenti.TabIndex = 0
        '
        'GRP_Utenti
        '
        Me.GRP_Utenti.Controls.Add(Me.LST_Utenti)
        Me.GRP_Utenti.Location = New System.Drawing.Point(3, 3)
        Me.GRP_Utenti.Name = "GRP_Utenti"
        Me.GRP_Utenti.Size = New System.Drawing.Size(200, 212)
        Me.GRP_Utenti.TabIndex = 1
        Me.GRP_Utenti.TabStop = False
        Me.GRP_Utenti.Text = "Utenti"
        '
        'Grafico
        '
        Me.Grafico.BackColor = System.Drawing.Color.White
        Me.Grafico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Grafico.Location = New System.Drawing.Point(12, 12)
        Me.Grafico.Name = "Grafico"
        Me.Grafico.Size = New System.Drawing.Size(1000, 300)
        Me.Grafico.TabIndex = 2
        Me.Grafico.TabStop = False
        '
        'Bt_Mostra
        '
        Me.Bt_Mostra.Location = New System.Drawing.Point(334, 192)
        Me.Bt_Mostra.Name = "Bt_Mostra"
        Me.Bt_Mostra.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Mostra.TabIndex = 3
        Me.Bt_Mostra.Text = "OK"
        Me.Bt_Mostra.UseVisualStyleBackColor = True
        '
        'NU_Valori
        '
        Me.NU_Valori.Location = New System.Drawing.Point(79, 19)
        Me.NU_Valori.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NU_Valori.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NU_Valori.Name = "NU_Valori"
        Me.NU_Valori.Size = New System.Drawing.Size(115, 20)
        Me.NU_Valori.TabIndex = 4
        Me.NU_Valori.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Ck_Etichette
        '
        Me.Ck_Etichette.AutoSize = True
        Me.Ck_Etichette.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ck_Etichette.Location = New System.Drawing.Point(107, 45)
        Me.Ck_Etichette.Name = "Ck_Etichette"
        Me.Ck_Etichette.Size = New System.Drawing.Size(87, 17)
        Me.Ck_Etichette.TabIndex = 5
        Me.Ck_Etichette.Text = "Mostra Valori"
        Me.Ck_Etichette.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "N Valori"
        '
        'Ck_MostraData
        '
        Me.Ck_MostraData.AutoSize = True
        Me.Ck_MostraData.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ck_MostraData.Location = New System.Drawing.Point(110, 68)
        Me.Ck_MostraData.Name = "Ck_MostraData"
        Me.Ck_MostraData.Size = New System.Drawing.Size(84, 17)
        Me.Ck_MostraData.TabIndex = 7
        Me.Ck_MostraData.Text = "Mostra Data"
        Me.Ck_MostraData.UseVisualStyleBackColor = True
        '
        'Ck_MostraOra
        '
        Me.Ck_MostraOra.AutoSize = True
        Me.Ck_MostraOra.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ck_MostraOra.Location = New System.Drawing.Point(116, 91)
        Me.Ck_MostraOra.Name = "Ck_MostraOra"
        Me.Ck_MostraOra.Size = New System.Drawing.Size(78, 17)
        Me.Ck_MostraOra.TabIndex = 8
        Me.Ck_MostraOra.Text = "Mostra Ora"
        Me.Ck_MostraOra.UseVisualStyleBackColor = True
        '
        'GRP_Opzioni
        '
        Me.GRP_Opzioni.Controls.Add(Me.NU_Valori)
        Me.GRP_Opzioni.Controls.Add(Me.Ck_MostraOra)
        Me.GRP_Opzioni.Controls.Add(Me.Ck_Etichette)
        Me.GRP_Opzioni.Controls.Add(Me.Ck_MostraData)
        Me.GRP_Opzioni.Controls.Add(Me.Label1)
        Me.GRP_Opzioni.Location = New System.Drawing.Point(209, 3)
        Me.GRP_Opzioni.Name = "GRP_Opzioni"
        Me.GRP_Opzioni.Size = New System.Drawing.Size(200, 118)
        Me.GRP_Opzioni.TabIndex = 9
        Me.GRP_Opzioni.TabStop = False
        Me.GRP_Opzioni.Text = "Visualizzazione"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel1.Controls.Add(Me.CK_Sovrapponi)
        Me.Panel1.Controls.Add(Me.GRP_Utenti)
        Me.Panel1.Controls.Add(Me.Bt_Mostra)
        Me.Panel1.Controls.Add(Me.GRP_Opzioni)
        Me.Panel1.Location = New System.Drawing.Point(12, 318)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(417, 223)
        Me.Panel1.TabIndex = 10
        '
        'CK_Sovrapponi
        '
        Me.CK_Sovrapponi.AutoSize = True
        Me.CK_Sovrapponi.Location = New System.Drawing.Point(248, 196)
        Me.CK_Sovrapponi.Name = "CK_Sovrapponi"
        Me.CK_Sovrapponi.Size = New System.Drawing.Size(80, 17)
        Me.CK_Sovrapponi.TabIndex = 12
        Me.CK_Sovrapponi.Text = "Sovrapponi"
        Me.CK_Sovrapponi.UseVisualStyleBackColor = True
        '
        'GRP_Parametri
        '
        Me.GRP_Parametri.Controls.Add(Me.DGW_Parametri)
        Me.GRP_Parametri.Location = New System.Drawing.Point(435, 321)
        Me.GRP_Parametri.Name = "GRP_Parametri"
        Me.GRP_Parametri.Size = New System.Drawing.Size(381, 220)
        Me.GRP_Parametri.TabIndex = 11
        Me.GRP_Parametri.TabStop = False
        Me.GRP_Parametri.Text = "Parametri"
        '
        'DGW_Parametri
        '
        Me.DGW_Parametri.AllowUserToAddRows = False
        Me.DGW_Parametri.AllowUserToDeleteRows = False
        Me.DGW_Parametri.AllowUserToOrderColumns = True
        Me.DGW_Parametri.AllowUserToResizeColumns = False
        Me.DGW_Parametri.AllowUserToResizeRows = False
        Me.DGW_Parametri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGW_Parametri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_Parametri.ColumnHeadersVisible = False
        Me.DGW_Parametri.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Parametro, Me.Descrizione})
        Me.DGW_Parametri.Location = New System.Drawing.Point(6, 19)
        Me.DGW_Parametri.Name = "DGW_Parametri"
        Me.DGW_Parametri.ReadOnly = True
        Me.DGW_Parametri.RowHeadersVisible = False
        Me.DGW_Parametri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGW_Parametri.Size = New System.Drawing.Size(369, 195)
        Me.DGW_Parametri.TabIndex = 1
        '
        'Parametro
        '
        Me.Parametro.HeaderText = "Parametro"
        Me.Parametro.Name = "Parametro"
        Me.Parametro.ReadOnly = True
        Me.Parametro.Visible = False
        '
        'Descrizione
        '
        Me.Descrizione.HeaderText = "Descrizione"
        Me.Descrizione.Name = "Descrizione"
        Me.Descrizione.ReadOnly = True
        '
        'AnalysisTable
        '
        Me.AnalysisTable.ClearBeforeFill = True
        '
        'DS
        '
        Me.DS.DataSetName = "ModPackDBDataSet"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Analysis_DescrizioneTable
        '
        Me.Analysis_DescrizioneTable.ClearBeforeFill = True
        '
        'DLG_Analisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1023, 552)
        Me.Controls.Add(Me.GRP_Parametri)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Grafico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DLG_Analisi"
        Me.Text = "Analisi Prestazioni"
        Me.GRP_Utenti.ResumeLayout(False)
        CType(Me.Grafico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NU_Valori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRP_Opzioni.ResumeLayout(False)
        Me.GRP_Opzioni.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GRP_Parametri.ResumeLayout(False)
        CType(Me.DGW_Parametri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AnalysisTable As ModPackDBDataSetTableAdapters.AnalysisTableAdapter
    Friend WithEvents DS As ModPackDBDataSet
    Friend WithEvents LST_Utenti As ListBox
    Friend WithEvents GRP_Utenti As GroupBox
    Friend WithEvents Grafico As PictureBox
    Friend WithEvents Bt_Mostra As Button
    Friend WithEvents NU_Valori As NumericUpDown
    Friend WithEvents Ck_Etichette As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Ck_MostraData As CheckBox
    Friend WithEvents Ck_MostraOra As CheckBox
    Friend WithEvents GRP_Opzioni As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GRP_Parametri As GroupBox
    Friend WithEvents CK_Sovrapponi As CheckBox
    Friend WithEvents DGW_Parametri As DataGridView
    Friend WithEvents Analysis_DescrizioneTable As ModPackDBDataSetTableAdapters.Analysis_DescrizioneTableAdapter
    Friend WithEvents Parametro As DataGridViewTextBoxColumn
    Friend WithEvents Descrizione As DataGridViewTextBoxColumn
End Class
