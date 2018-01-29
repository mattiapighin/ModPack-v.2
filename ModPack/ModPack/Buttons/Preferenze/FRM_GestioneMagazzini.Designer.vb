<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_GestioneMagazzini
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
        Me.DGW_Magazzini = New System.Windows.Forms.DataGridView()
        Me.ModPackDBDataSet = New ModPack.ModPackDBDataSet()
        Me.MagazziniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MagazziniTableAdapter = New ModPack.ModPackDBDataSetTableAdapters.MagazziniTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bt_Salva = New System.Windows.Forms.Button()
        CType(Me.DGW_Magazzini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModPackDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MagazziniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGW_Magazzini
        '
        Me.DGW_Magazzini.AutoGenerateColumns = False
        Me.DGW_Magazzini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGW_Magazzini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_Magazzini.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CodiceDataGridViewTextBoxColumn, Me.DescrizioneDataGridViewTextBoxColumn})
        Me.DGW_Magazzini.DataSource = Me.MagazziniBindingSource
        Me.DGW_Magazzini.Location = New System.Drawing.Point(12, 12)
        Me.DGW_Magazzini.Name = "DGW_Magazzini"
        Me.DGW_Magazzini.Size = New System.Drawing.Size(569, 252)
        Me.DGW_Magazzini.TabIndex = 0
        '
        'ModPackDBDataSet
        '
        Me.ModPackDBDataSet.DataSetName = "ModPackDBDataSet"
        Me.ModPackDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MagazziniBindingSource
        '
        Me.MagazziniBindingSource.DataMember = "Magazzini"
        Me.MagazziniBindingSource.DataSource = Me.ModPackDBDataSet
        '
        'MagazziniTableAdapter
        '
        Me.MagazziniTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'CodiceDataGridViewTextBoxColumn
        '
        Me.CodiceDataGridViewTextBoxColumn.DataPropertyName = "Codice"
        Me.CodiceDataGridViewTextBoxColumn.HeaderText = "Codice"
        Me.CodiceDataGridViewTextBoxColumn.Name = "CodiceDataGridViewTextBoxColumn"
        Me.CodiceDataGridViewTextBoxColumn.Width = 65
        '
        'DescrizioneDataGridViewTextBoxColumn
        '
        Me.DescrizioneDataGridViewTextBoxColumn.DataPropertyName = "Descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn.Name = "DescrizioneDataGridViewTextBoxColumn"
        Me.DescrizioneDataGridViewTextBoxColumn.Width = 87
        '
        'Bt_Salva
        '
        Me.Bt_Salva.Location = New System.Drawing.Point(506, 270)
        Me.Bt_Salva.Name = "Bt_Salva"
        Me.Bt_Salva.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Salva.TabIndex = 1
        Me.Bt_Salva.Text = "Salva"
        Me.Bt_Salva.UseVisualStyleBackColor = True
        '
        'FRM_GestioneMagazzini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 318)
        Me.Controls.Add(Me.Bt_Salva)
        Me.Controls.Add(Me.DGW_Magazzini)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FRM_GestioneMagazzini"
        Me.Text = "Gestione Magazzini"
        CType(Me.DGW_Magazzini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModPackDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MagazziniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGW_Magazzini As DataGridView
    Friend WithEvents ModPackDBDataSet As ModPackDBDataSet
    Friend WithEvents MagazziniBindingSource As BindingSource
    Friend WithEvents MagazziniTableAdapter As ModPackDBDataSetTableAdapters.MagazziniTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodiceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescrizioneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Bt_Salva As Button
End Class
