<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_GestioneTipi
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
        Me.DGW_Tipi = New System.Windows.Forms.DataGridView()
        Me.ModPackDBDataSet = New ModPack.ModPackDBDataSet()
        Me.TipiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipiTableAdapter = New ModPack.ModPackDBDataSetTableAdapters.TipiTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterasseMaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpazioBTLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpazioBTTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpazioCTLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpazioFTLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpazioMTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InfoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrezzoM3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrezzoM3HTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FresataMoraliDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Bt_Salva = New System.Windows.Forms.Button()
        CType(Me.DGW_Tipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModPackDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGW_Tipi
        '
        Me.DGW_Tipi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGW_Tipi.AutoGenerateColumns = False
        Me.DGW_Tipi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_Tipi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.DescrizioneDataGridViewTextBoxColumn, Me.InterasseMaxDataGridViewTextBoxColumn, Me.SpazioBTLDataGridViewTextBoxColumn, Me.SpazioBTTDataGridViewTextBoxColumn, Me.SpazioCTLDataGridViewTextBoxColumn, Me.SpazioFTLDataGridViewTextBoxColumn, Me.SpazioMTDataGridViewTextBoxColumn, Me.InfoDataGridViewTextBoxColumn, Me.PrezzoM3DataGridViewTextBoxColumn, Me.PrezzoM3HTDataGridViewTextBoxColumn, Me.FresataMoraliDataGridViewCheckBoxColumn})
        Me.DGW_Tipi.DataSource = Me.TipiBindingSource
        Me.DGW_Tipi.Location = New System.Drawing.Point(12, 12)
        Me.DGW_Tipi.Name = "DGW_Tipi"
        Me.DGW_Tipi.Size = New System.Drawing.Size(1065, 336)
        Me.DGW_Tipi.TabIndex = 0
        '
        'ModPackDBDataSet
        '
        Me.ModPackDBDataSet.DataSetName = "ModPackDBDataSet"
        Me.ModPackDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TipiBindingSource
        '
        Me.TipiBindingSource.DataMember = "Tipi"
        Me.TipiBindingSource.DataSource = Me.ModPackDBDataSet
        '
        'TipiTableAdapter
        '
        Me.TipiTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        '
        'DescrizioneDataGridViewTextBoxColumn
        '
        Me.DescrizioneDataGridViewTextBoxColumn.DataPropertyName = "Descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn.Name = "DescrizioneDataGridViewTextBoxColumn"
        '
        'InterasseMaxDataGridViewTextBoxColumn
        '
        Me.InterasseMaxDataGridViewTextBoxColumn.DataPropertyName = "InterasseMax"
        Me.InterasseMaxDataGridViewTextBoxColumn.HeaderText = "InterasseMax"
        Me.InterasseMaxDataGridViewTextBoxColumn.Name = "InterasseMaxDataGridViewTextBoxColumn"
        '
        'SpazioBTLDataGridViewTextBoxColumn
        '
        Me.SpazioBTLDataGridViewTextBoxColumn.DataPropertyName = "SpazioBTL"
        Me.SpazioBTLDataGridViewTextBoxColumn.HeaderText = "SpazioBTL"
        Me.SpazioBTLDataGridViewTextBoxColumn.Name = "SpazioBTLDataGridViewTextBoxColumn"
        '
        'SpazioBTTDataGridViewTextBoxColumn
        '
        Me.SpazioBTTDataGridViewTextBoxColumn.DataPropertyName = "SpazioBTT"
        Me.SpazioBTTDataGridViewTextBoxColumn.HeaderText = "SpazioBTT"
        Me.SpazioBTTDataGridViewTextBoxColumn.Name = "SpazioBTTDataGridViewTextBoxColumn"
        '
        'SpazioCTLDataGridViewTextBoxColumn
        '
        Me.SpazioCTLDataGridViewTextBoxColumn.DataPropertyName = "SpazioCTL"
        Me.SpazioCTLDataGridViewTextBoxColumn.HeaderText = "SpazioCTL"
        Me.SpazioCTLDataGridViewTextBoxColumn.Name = "SpazioCTLDataGridViewTextBoxColumn"
        '
        'SpazioFTLDataGridViewTextBoxColumn
        '
        Me.SpazioFTLDataGridViewTextBoxColumn.DataPropertyName = "SpazioFTL"
        Me.SpazioFTLDataGridViewTextBoxColumn.HeaderText = "SpazioFTL"
        Me.SpazioFTLDataGridViewTextBoxColumn.Name = "SpazioFTLDataGridViewTextBoxColumn"
        '
        'SpazioMTDataGridViewTextBoxColumn
        '
        Me.SpazioMTDataGridViewTextBoxColumn.DataPropertyName = "SpazioMT"
        Me.SpazioMTDataGridViewTextBoxColumn.HeaderText = "SpazioMT"
        Me.SpazioMTDataGridViewTextBoxColumn.Name = "SpazioMTDataGridViewTextBoxColumn"
        '
        'InfoDataGridViewTextBoxColumn
        '
        Me.InfoDataGridViewTextBoxColumn.DataPropertyName = "Info"
        Me.InfoDataGridViewTextBoxColumn.HeaderText = "Info"
        Me.InfoDataGridViewTextBoxColumn.Name = "InfoDataGridViewTextBoxColumn"
        '
        'PrezzoM3DataGridViewTextBoxColumn
        '
        Me.PrezzoM3DataGridViewTextBoxColumn.DataPropertyName = "PrezzoM3"
        Me.PrezzoM3DataGridViewTextBoxColumn.HeaderText = "PrezzoM3"
        Me.PrezzoM3DataGridViewTextBoxColumn.Name = "PrezzoM3DataGridViewTextBoxColumn"
        '
        'PrezzoM3HTDataGridViewTextBoxColumn
        '
        Me.PrezzoM3HTDataGridViewTextBoxColumn.DataPropertyName = "PrezzoM3HT"
        Me.PrezzoM3HTDataGridViewTextBoxColumn.HeaderText = "PrezzoM3HT"
        Me.PrezzoM3HTDataGridViewTextBoxColumn.Name = "PrezzoM3HTDataGridViewTextBoxColumn"
        '
        'FresataMoraliDataGridViewCheckBoxColumn
        '
        Me.FresataMoraliDataGridViewCheckBoxColumn.DataPropertyName = "FresataMorali"
        Me.FresataMoraliDataGridViewCheckBoxColumn.HeaderText = "FresataMorali"
        Me.FresataMoraliDataGridViewCheckBoxColumn.Name = "FresataMoraliDataGridViewCheckBoxColumn"
        '
        'Bt_Salva
        '
        Me.Bt_Salva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Salva.Location = New System.Drawing.Point(977, 354)
        Me.Bt_Salva.Name = "Bt_Salva"
        Me.Bt_Salva.Size = New System.Drawing.Size(100, 45)
        Me.Bt_Salva.TabIndex = 1
        Me.Bt_Salva.Text = "Salva"
        Me.Bt_Salva.UseVisualStyleBackColor = True
        '
        'Form_GestioneTipi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 411)
        Me.Controls.Add(Me.Bt_Salva)
        Me.Controls.Add(Me.DGW_Tipi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form_GestioneTipi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestione Tipi"
        CType(Me.DGW_Tipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModPackDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGW_Tipi As DataGridView
    Friend WithEvents ModPackDBDataSet As ModPackDBDataSet
    Friend WithEvents TipiBindingSource As BindingSource
    Friend WithEvents TipiTableAdapter As ModPackDBDataSetTableAdapters.TipiTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescrizioneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InterasseMaxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpazioBTLDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpazioBTTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpazioCTLDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpazioFTLDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpazioMTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InfoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrezzoM3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrezzoM3HTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FresataMoraliDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents Bt_Salva As Button
End Class
