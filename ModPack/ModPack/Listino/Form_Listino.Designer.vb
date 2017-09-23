<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Listino
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Listino))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGW_Tipi = New System.Windows.Forms.DataGridView()
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
        Me.TipiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModPackDBDataSet = New ModPack.ModPackDBDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGW_Rivestimenti = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoRivestimentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrizioneDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prezzom2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RivestimentiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGW_Materiali = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrizioneDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrezzoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipiTableAdapter = New ModPack.ModPackDBDataSetTableAdapters.TipiTableAdapter()
        Me.RivestimentiTableAdapter = New ModPack.ModPackDBDataSetTableAdapters.RivestimentiTableAdapter()
        Me.MaterialiTableAdapter = New ModPack.ModPackDBDataSetTableAdapters.MaterialiTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Bt_Salva = New System.Windows.Forms.Button()
        Me.Bt_Annulla = New System.Windows.Forms.Button()
        Me.BT_Edit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGW_Tipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModPackDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGW_Rivestimenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RivestimentiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGW_Materiali, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGW_Tipi)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(541, 175)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipi imballi"
        '
        'DGW_Tipi
        '
        Me.DGW_Tipi.AllowUserToAddRows = False
        Me.DGW_Tipi.AllowUserToDeleteRows = False
        Me.DGW_Tipi.AllowUserToResizeColumns = False
        Me.DGW_Tipi.AllowUserToResizeRows = False
        Me.DGW_Tipi.AutoGenerateColumns = False
        Me.DGW_Tipi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGW_Tipi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_Tipi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.DescrizioneDataGridViewTextBoxColumn, Me.InterasseMaxDataGridViewTextBoxColumn, Me.SpazioBTLDataGridViewTextBoxColumn, Me.SpazioBTTDataGridViewTextBoxColumn, Me.SpazioCTLDataGridViewTextBoxColumn, Me.SpazioFTLDataGridViewTextBoxColumn, Me.SpazioMTDataGridViewTextBoxColumn, Me.InfoDataGridViewTextBoxColumn, Me.PrezzoM3DataGridViewTextBoxColumn, Me.PrezzoM3HTDataGridViewTextBoxColumn, Me.FresataMoraliDataGridViewCheckBoxColumn})
        Me.DGW_Tipi.DataSource = Me.TipiBindingSource
        Me.DGW_Tipi.Location = New System.Drawing.Point(6, 19)
        Me.DGW_Tipi.Name = "DGW_Tipi"
        Me.DGW_Tipi.ReadOnly = True
        Me.DGW_Tipi.RowHeadersVisible = False
        Me.DGW_Tipi.Size = New System.Drawing.Size(528, 150)
        Me.DGW_Tipi.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescrizioneDataGridViewTextBoxColumn
        '
        Me.DescrizioneDataGridViewTextBoxColumn.DataPropertyName = "Descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn.Name = "DescrizioneDataGridViewTextBoxColumn"
        Me.DescrizioneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InterasseMaxDataGridViewTextBoxColumn
        '
        Me.InterasseMaxDataGridViewTextBoxColumn.DataPropertyName = "InterasseMax"
        Me.InterasseMaxDataGridViewTextBoxColumn.HeaderText = "InterasseMax"
        Me.InterasseMaxDataGridViewTextBoxColumn.Name = "InterasseMaxDataGridViewTextBoxColumn"
        Me.InterasseMaxDataGridViewTextBoxColumn.ReadOnly = True
        Me.InterasseMaxDataGridViewTextBoxColumn.Visible = False
        '
        'SpazioBTLDataGridViewTextBoxColumn
        '
        Me.SpazioBTLDataGridViewTextBoxColumn.DataPropertyName = "SpazioBTL"
        Me.SpazioBTLDataGridViewTextBoxColumn.HeaderText = "SpazioBTL"
        Me.SpazioBTLDataGridViewTextBoxColumn.Name = "SpazioBTLDataGridViewTextBoxColumn"
        Me.SpazioBTLDataGridViewTextBoxColumn.ReadOnly = True
        Me.SpazioBTLDataGridViewTextBoxColumn.Visible = False
        '
        'SpazioBTTDataGridViewTextBoxColumn
        '
        Me.SpazioBTTDataGridViewTextBoxColumn.DataPropertyName = "SpazioBTT"
        Me.SpazioBTTDataGridViewTextBoxColumn.HeaderText = "SpazioBTT"
        Me.SpazioBTTDataGridViewTextBoxColumn.Name = "SpazioBTTDataGridViewTextBoxColumn"
        Me.SpazioBTTDataGridViewTextBoxColumn.ReadOnly = True
        Me.SpazioBTTDataGridViewTextBoxColumn.Visible = False
        '
        'SpazioCTLDataGridViewTextBoxColumn
        '
        Me.SpazioCTLDataGridViewTextBoxColumn.DataPropertyName = "SpazioCTL"
        Me.SpazioCTLDataGridViewTextBoxColumn.HeaderText = "SpazioCTL"
        Me.SpazioCTLDataGridViewTextBoxColumn.Name = "SpazioCTLDataGridViewTextBoxColumn"
        Me.SpazioCTLDataGridViewTextBoxColumn.ReadOnly = True
        Me.SpazioCTLDataGridViewTextBoxColumn.Visible = False
        '
        'SpazioFTLDataGridViewTextBoxColumn
        '
        Me.SpazioFTLDataGridViewTextBoxColumn.DataPropertyName = "SpazioFTL"
        Me.SpazioFTLDataGridViewTextBoxColumn.HeaderText = "SpazioFTL"
        Me.SpazioFTLDataGridViewTextBoxColumn.Name = "SpazioFTLDataGridViewTextBoxColumn"
        Me.SpazioFTLDataGridViewTextBoxColumn.ReadOnly = True
        Me.SpazioFTLDataGridViewTextBoxColumn.Visible = False
        '
        'SpazioMTDataGridViewTextBoxColumn
        '
        Me.SpazioMTDataGridViewTextBoxColumn.DataPropertyName = "SpazioMT"
        Me.SpazioMTDataGridViewTextBoxColumn.HeaderText = "SpazioMT"
        Me.SpazioMTDataGridViewTextBoxColumn.Name = "SpazioMTDataGridViewTextBoxColumn"
        Me.SpazioMTDataGridViewTextBoxColumn.ReadOnly = True
        Me.SpazioMTDataGridViewTextBoxColumn.Visible = False
        '
        'InfoDataGridViewTextBoxColumn
        '
        Me.InfoDataGridViewTextBoxColumn.DataPropertyName = "Info"
        Me.InfoDataGridViewTextBoxColumn.HeaderText = "Info"
        Me.InfoDataGridViewTextBoxColumn.Name = "InfoDataGridViewTextBoxColumn"
        Me.InfoDataGridViewTextBoxColumn.ReadOnly = True
        Me.InfoDataGridViewTextBoxColumn.Visible = False
        '
        'PrezzoM3DataGridViewTextBoxColumn
        '
        Me.PrezzoM3DataGridViewTextBoxColumn.DataPropertyName = "PrezzoM3"
        Me.PrezzoM3DataGridViewTextBoxColumn.HeaderText = "Prezzo ( m³ )"
        Me.PrezzoM3DataGridViewTextBoxColumn.Name = "PrezzoM3DataGridViewTextBoxColumn"
        Me.PrezzoM3DataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrezzoM3HTDataGridViewTextBoxColumn
        '
        Me.PrezzoM3HTDataGridViewTextBoxColumn.DataPropertyName = "PrezzoM3HT"
        Me.PrezzoM3HTDataGridViewTextBoxColumn.HeaderText = "Prezzo HT ( m³ )"
        Me.PrezzoM3HTDataGridViewTextBoxColumn.Name = "PrezzoM3HTDataGridViewTextBoxColumn"
        Me.PrezzoM3HTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FresataMoraliDataGridViewCheckBoxColumn
        '
        Me.FresataMoraliDataGridViewCheckBoxColumn.DataPropertyName = "FresataMorali"
        Me.FresataMoraliDataGridViewCheckBoxColumn.HeaderText = "FresataMorali"
        Me.FresataMoraliDataGridViewCheckBoxColumn.Name = "FresataMoraliDataGridViewCheckBoxColumn"
        Me.FresataMoraliDataGridViewCheckBoxColumn.ReadOnly = True
        Me.FresataMoraliDataGridViewCheckBoxColumn.Visible = False
        '
        'TipiBindingSource
        '
        Me.TipiBindingSource.DataMember = "Tipi"
        Me.TipiBindingSource.DataSource = Me.ModPackDBDataSet
        '
        'ModPackDBDataSet
        '
        Me.ModPackDBDataSet.DataSetName = "ModPackDBDataSet"
        Me.ModPackDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGW_Rivestimenti)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 193)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(541, 175)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rivestimenti"
        '
        'DGW_Rivestimenti
        '
        Me.DGW_Rivestimenti.AllowUserToAddRows = False
        Me.DGW_Rivestimenti.AllowUserToDeleteRows = False
        Me.DGW_Rivestimenti.AllowUserToResizeColumns = False
        Me.DGW_Rivestimenti.AllowUserToResizeRows = False
        Me.DGW_Rivestimenti.AutoGenerateColumns = False
        Me.DGW_Rivestimenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGW_Rivestimenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_Rivestimenti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.TipoRivestimentoDataGridViewTextBoxColumn, Me.DescrizioneDataGridViewTextBoxColumn1, Me.Prezzom2DataGridViewTextBoxColumn})
        Me.DGW_Rivestimenti.DataSource = Me.RivestimentiBindingSource
        Me.DGW_Rivestimenti.Location = New System.Drawing.Point(6, 19)
        Me.DGW_Rivestimenti.Name = "DGW_Rivestimenti"
        Me.DGW_Rivestimenti.ReadOnly = True
        Me.DGW_Rivestimenti.RowHeadersVisible = False
        Me.DGW_Rivestimenti.Size = New System.Drawing.Size(528, 150)
        Me.DGW_Rivestimenti.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn1.Visible = False
        '
        'TipoRivestimentoDataGridViewTextBoxColumn
        '
        Me.TipoRivestimentoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Rivestimento"
        Me.TipoRivestimentoDataGridViewTextBoxColumn.HeaderText = "Rivestimento"
        Me.TipoRivestimentoDataGridViewTextBoxColumn.Name = "TipoRivestimentoDataGridViewTextBoxColumn"
        Me.TipoRivestimentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescrizioneDataGridViewTextBoxColumn1
        '
        Me.DescrizioneDataGridViewTextBoxColumn1.DataPropertyName = "Descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn1.HeaderText = "Descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn1.Name = "DescrizioneDataGridViewTextBoxColumn1"
        Me.DescrizioneDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Prezzom2DataGridViewTextBoxColumn
        '
        Me.Prezzom2DataGridViewTextBoxColumn.DataPropertyName = "Prezzo_m2"
        Me.Prezzom2DataGridViewTextBoxColumn.HeaderText = "Prezzo ( m² )"
        Me.Prezzom2DataGridViewTextBoxColumn.Name = "Prezzom2DataGridViewTextBoxColumn"
        Me.Prezzom2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'RivestimentiBindingSource
        '
        Me.RivestimentiBindingSource.DataMember = "Rivestimenti"
        Me.RivestimentiBindingSource.DataSource = Me.ModPackDBDataSet
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGW_Materiali)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 374)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(541, 175)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Materiali"
        '
        'DGW_Materiali
        '
        Me.DGW_Materiali.AllowUserToAddRows = False
        Me.DGW_Materiali.AllowUserToDeleteRows = False
        Me.DGW_Materiali.AllowUserToResizeColumns = False
        Me.DGW_Materiali.AllowUserToResizeRows = False
        Me.DGW_Materiali.AutoGenerateColumns = False
        Me.DGW_Materiali.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGW_Materiali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_Materiali.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn2, Me.MaterialeDataGridViewTextBoxColumn, Me.DescrizioneDataGridViewTextBoxColumn2, Me.UMDataGridViewTextBoxColumn, Me.PrezzoDataGridViewTextBoxColumn})
        Me.DGW_Materiali.DataSource = Me.MaterialiBindingSource
        Me.DGW_Materiali.Location = New System.Drawing.Point(6, 19)
        Me.DGW_Materiali.Name = "DGW_Materiali"
        Me.DGW_Materiali.ReadOnly = True
        Me.DGW_Materiali.RowHeadersVisible = False
        Me.DGW_Materiali.Size = New System.Drawing.Size(528, 150)
        Me.DGW_Materiali.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn2
        '
        Me.IdDataGridViewTextBoxColumn2.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn2.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn2.Name = "IdDataGridViewTextBoxColumn2"
        Me.IdDataGridViewTextBoxColumn2.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn2.Visible = False
        '
        'MaterialeDataGridViewTextBoxColumn
        '
        Me.MaterialeDataGridViewTextBoxColumn.DataPropertyName = "Materiale"
        Me.MaterialeDataGridViewTextBoxColumn.HeaderText = "Materiale"
        Me.MaterialeDataGridViewTextBoxColumn.Name = "MaterialeDataGridViewTextBoxColumn"
        Me.MaterialeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescrizioneDataGridViewTextBoxColumn2
        '
        Me.DescrizioneDataGridViewTextBoxColumn2.DataPropertyName = "Descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn2.HeaderText = "Descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn2.Name = "DescrizioneDataGridViewTextBoxColumn2"
        Me.DescrizioneDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'UMDataGridViewTextBoxColumn
        '
        Me.UMDataGridViewTextBoxColumn.DataPropertyName = "UM"
        Me.UMDataGridViewTextBoxColumn.HeaderText = "UM"
        Me.UMDataGridViewTextBoxColumn.Name = "UMDataGridViewTextBoxColumn"
        Me.UMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrezzoDataGridViewTextBoxColumn
        '
        Me.PrezzoDataGridViewTextBoxColumn.DataPropertyName = "Prezzo"
        Me.PrezzoDataGridViewTextBoxColumn.HeaderText = "Prezzo"
        Me.PrezzoDataGridViewTextBoxColumn.Name = "PrezzoDataGridViewTextBoxColumn"
        Me.PrezzoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaterialiBindingSource
        '
        Me.MaterialiBindingSource.DataMember = "Materiali"
        Me.MaterialiBindingSource.DataSource = Me.ModPackDBDataSet
        '
        'TipiTableAdapter
        '
        Me.TipiTableAdapter.ClearBeforeFill = True
        '
        'RivestimentiTableAdapter
        '
        Me.RivestimentiTableAdapter.ClearBeforeFill = True
        '
        'MaterialiTableAdapter
        '
        Me.MaterialiTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.Bt_Salva)
        Me.Panel1.Controls.Add(Me.Bt_Annulla)
        Me.Panel1.Controls.Add(Me.BT_Edit)
        Me.Panel1.Location = New System.Drawing.Point(559, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(50, 537)
        Me.Panel1.TabIndex = 3
        '
        'Bt_Salva
        '
        Me.Bt_Salva.FlatAppearance.BorderSize = 0
        Me.Bt_Salva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Salva.Image = CType(resources.GetObject("Bt_Salva.Image"), System.Drawing.Image)
        Me.Bt_Salva.Location = New System.Drawing.Point(5, 491)
        Me.Bt_Salva.Name = "Bt_Salva"
        Me.Bt_Salva.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Salva.TabIndex = 1
        Me.Bt_Salva.UseVisualStyleBackColor = True
        '
        'Bt_Annulla
        '
        Me.Bt_Annulla.FlatAppearance.BorderSize = 0
        Me.Bt_Annulla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Annulla.Image = CType(resources.GetObject("Bt_Annulla.Image"), System.Drawing.Image)
        Me.Bt_Annulla.Location = New System.Drawing.Point(5, 445)
        Me.Bt_Annulla.Name = "Bt_Annulla"
        Me.Bt_Annulla.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Annulla.TabIndex = 2
        Me.Bt_Annulla.UseVisualStyleBackColor = True
        '
        'BT_Edit
        '
        Me.BT_Edit.FlatAppearance.BorderSize = 0
        Me.BT_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Edit.Image = CType(resources.GetObject("BT_Edit.Image"), System.Drawing.Image)
        Me.BT_Edit.Location = New System.Drawing.Point(5, 3)
        Me.BT_Edit.Name = "BT_Edit"
        Me.BT_Edit.Size = New System.Drawing.Size(40, 40)
        Me.BT_Edit.TabIndex = 0
        Me.BT_Edit.UseVisualStyleBackColor = True
        '
        'Form_Listino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_Listino"
        Me.Text = "Listino"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGW_Tipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModPackDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGW_Rivestimenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RivestimentiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGW_Materiali, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGW_Tipi As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGW_Rivestimenti As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGW_Materiali As DataGridView
    Friend WithEvents ModPackDBDataSet As ModPackDBDataSet
    Friend WithEvents TipiBindingSource As BindingSource
    Friend WithEvents TipiTableAdapter As ModPackDBDataSetTableAdapters.TipiTableAdapter
    Friend WithEvents RivestimentiBindingSource As BindingSource
    Friend WithEvents RivestimentiTableAdapter As ModPackDBDataSetTableAdapters.RivestimentiTableAdapter
    Friend WithEvents MaterialiBindingSource As BindingSource
    Friend WithEvents MaterialiTableAdapter As ModPackDBDataSetTableAdapters.MaterialiTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Bt_Salva As Button
    Friend WithEvents Bt_Annulla As Button
    Friend WithEvents BT_Edit As Button
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TipoRivestimentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescrizioneDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Prezzom2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents MaterialeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescrizioneDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents UMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrezzoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
End Class
