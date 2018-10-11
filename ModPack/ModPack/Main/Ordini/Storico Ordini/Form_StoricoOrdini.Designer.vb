<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_StoricoOrdini
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_StoricoOrdini))
        Me.DGW_Ordini = New System.Windows.Forms.DataGridView()
        Me.DGW_Righe = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RigaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImballoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommessaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZoccoliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RivestimentoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TipoRivestimentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataConsegnaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HTDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DTDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BMDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RivestTotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MagazzinoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiagonaliDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.StampatoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProduzioneDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EvasoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataOrdineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdiniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModPackDBDataSet = New ModPack.ModPackDBDataSet()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TxtCerca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Cb_Colonna = New System.Windows.Forms.ToolStripComboBox()
        Me.Bt_Cerca = New System.Windows.Forms.ToolStripButton()
        Me.Bt_CancellaFiltro = New System.Windows.Forms.ToolStripButton()
        Me.Bt_FiltraPerData = New System.Windows.Forms.ToolStripButton()
        Me.Bt_Refresh = New System.Windows.Forms.ToolStripButton()
        Me.Bt_Colonne = New System.Windows.Forms.ToolStripButton()
        Me.OrdiniTableAdapter = New ModPack.ModPackDBDataSetTableAdapters.OrdiniTableAdapter()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.DGW_Ordini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGW_Righe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdiniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModPackDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGW_Ordini
        '
        Me.DGW_Ordini.AllowUserToAddRows = False
        Me.DGW_Ordini.AllowUserToDeleteRows = False
        Me.DGW_Ordini.AllowUserToOrderColumns = True
        Me.DGW_Ordini.AllowUserToResizeColumns = False
        Me.DGW_Ordini.AllowUserToResizeRows = False
        Me.DGW_Ordini.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DGW_Ordini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGW_Ordini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_Ordini.ColumnHeadersVisible = False
        Me.DGW_Ordini.Location = New System.Drawing.Point(12, 40)
        Me.DGW_Ordini.Name = "DGW_Ordini"
        Me.DGW_Ordini.ReadOnly = True
        Me.DGW_Ordini.RowHeadersVisible = False
        Me.DGW_Ordini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGW_Ordini.Size = New System.Drawing.Size(294, 686)
        Me.DGW_Ordini.TabIndex = 0
        '
        'DGW_Righe
        '
        Me.DGW_Righe.AllowUserToAddRows = False
        Me.DGW_Righe.AllowUserToDeleteRows = False
        Me.DGW_Righe.AllowUserToResizeColumns = False
        Me.DGW_Righe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGW_Righe.AutoGenerateColumns = False
        Me.DGW_Righe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGW_Righe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_Righe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.OrdineDataGridViewTextBoxColumn, Me.RigaDataGridViewTextBoxColumn, Me.ImballoDataGridViewTextBoxColumn, Me.IndiceDataGridViewTextBoxColumn, Me.QtDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.CodiceDataGridViewTextBoxColumn, Me.CommessaDataGridViewTextBoxColumn, Me.LDataGridViewTextBoxColumn, Me.PDataGridViewTextBoxColumn, Me.HDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.ZoccoliDataGridViewTextBoxColumn, Me.RivestimentoDataGridViewCheckBoxColumn, Me.TipoRivestimentoDataGridViewTextBoxColumn, Me.NoteDataGridViewTextBoxColumn, Me.DataConsegnaDataGridViewTextBoxColumn, Me.HTDataGridViewCheckBoxColumn, Me.DTDataGridViewCheckBoxColumn, Me.BMDataGridViewCheckBoxColumn, Me.RivestTotDataGridViewTextBoxColumn, Me.MagazzinoDataGridViewTextBoxColumn, Me.DiagonaliDataGridViewCheckBoxColumn, Me.StampatoDataGridViewCheckBoxColumn, Me.ProduzioneDataGridViewCheckBoxColumn, Me.EvasoDataGridViewCheckBoxColumn, Me.DataOrdineDataGridViewTextBoxColumn})
        Me.DGW_Righe.DataSource = Me.OrdiniBindingSource
        Me.DGW_Righe.Location = New System.Drawing.Point(312, 40)
        Me.DGW_Righe.Name = "DGW_Righe"
        Me.DGW_Righe.ReadOnly = True
        Me.DGW_Righe.Size = New System.Drawing.Size(862, 686)
        Me.DGW_Righe.TabIndex = 1
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
        'OrdineDataGridViewTextBoxColumn
        '
        Me.OrdineDataGridViewTextBoxColumn.DataPropertyName = "Ordine"
        Me.OrdineDataGridViewTextBoxColumn.HeaderText = "Ordine"
        Me.OrdineDataGridViewTextBoxColumn.Name = "OrdineDataGridViewTextBoxColumn"
        Me.OrdineDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrdineDataGridViewTextBoxColumn.Visible = False
        Me.OrdineDataGridViewTextBoxColumn.Width = 63
        '
        'RigaDataGridViewTextBoxColumn
        '
        Me.RigaDataGridViewTextBoxColumn.DataPropertyName = "Riga"
        Me.RigaDataGridViewTextBoxColumn.HeaderText = "Riga"
        Me.RigaDataGridViewTextBoxColumn.Name = "RigaDataGridViewTextBoxColumn"
        Me.RigaDataGridViewTextBoxColumn.ReadOnly = True
        Me.RigaDataGridViewTextBoxColumn.Width = 54
        '
        'ImballoDataGridViewTextBoxColumn
        '
        Me.ImballoDataGridViewTextBoxColumn.DataPropertyName = "Imballo"
        Me.ImballoDataGridViewTextBoxColumn.HeaderText = "Imballo"
        Me.ImballoDataGridViewTextBoxColumn.Name = "ImballoDataGridViewTextBoxColumn"
        Me.ImballoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImballoDataGridViewTextBoxColumn.Width = 65
        '
        'IndiceDataGridViewTextBoxColumn
        '
        Me.IndiceDataGridViewTextBoxColumn.DataPropertyName = "Indice"
        Me.IndiceDataGridViewTextBoxColumn.HeaderText = "Indice"
        Me.IndiceDataGridViewTextBoxColumn.Name = "IndiceDataGridViewTextBoxColumn"
        Me.IndiceDataGridViewTextBoxColumn.ReadOnly = True
        Me.IndiceDataGridViewTextBoxColumn.Width = 61
        '
        'QtDataGridViewTextBoxColumn
        '
        Me.QtDataGridViewTextBoxColumn.DataPropertyName = "Qt"
        Me.QtDataGridViewTextBoxColumn.HeaderText = "Qt"
        Me.QtDataGridViewTextBoxColumn.Name = "QtDataGridViewTextBoxColumn"
        Me.QtDataGridViewTextBoxColumn.ReadOnly = True
        Me.QtDataGridViewTextBoxColumn.Width = 43
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteDataGridViewTextBoxColumn.Width = 64
        '
        'CodiceDataGridViewTextBoxColumn
        '
        Me.CodiceDataGridViewTextBoxColumn.DataPropertyName = "Codice"
        Me.CodiceDataGridViewTextBoxColumn.HeaderText = "Codice"
        Me.CodiceDataGridViewTextBoxColumn.Name = "CodiceDataGridViewTextBoxColumn"
        Me.CodiceDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodiceDataGridViewTextBoxColumn.Width = 65
        '
        'CommessaDataGridViewTextBoxColumn
        '
        Me.CommessaDataGridViewTextBoxColumn.DataPropertyName = "Commessa"
        Me.CommessaDataGridViewTextBoxColumn.HeaderText = "Commessa"
        Me.CommessaDataGridViewTextBoxColumn.Name = "CommessaDataGridViewTextBoxColumn"
        Me.CommessaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CommessaDataGridViewTextBoxColumn.Width = 83
        '
        'LDataGridViewTextBoxColumn
        '
        Me.LDataGridViewTextBoxColumn.DataPropertyName = "L"
        Me.LDataGridViewTextBoxColumn.HeaderText = "L"
        Me.LDataGridViewTextBoxColumn.Name = "LDataGridViewTextBoxColumn"
        Me.LDataGridViewTextBoxColumn.ReadOnly = True
        Me.LDataGridViewTextBoxColumn.Width = 38
        '
        'PDataGridViewTextBoxColumn
        '
        Me.PDataGridViewTextBoxColumn.DataPropertyName = "P"
        Me.PDataGridViewTextBoxColumn.HeaderText = "P"
        Me.PDataGridViewTextBoxColumn.Name = "PDataGridViewTextBoxColumn"
        Me.PDataGridViewTextBoxColumn.ReadOnly = True
        Me.PDataGridViewTextBoxColumn.Width = 39
        '
        'HDataGridViewTextBoxColumn
        '
        Me.HDataGridViewTextBoxColumn.DataPropertyName = "H"
        Me.HDataGridViewTextBoxColumn.HeaderText = "H"
        Me.HDataGridViewTextBoxColumn.Name = "HDataGridViewTextBoxColumn"
        Me.HDataGridViewTextBoxColumn.ReadOnly = True
        Me.HDataGridViewTextBoxColumn.Width = 40
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDataGridViewTextBoxColumn.Width = 53
        '
        'ZoccoliDataGridViewTextBoxColumn
        '
        Me.ZoccoliDataGridViewTextBoxColumn.DataPropertyName = "Zoccoli"
        Me.ZoccoliDataGridViewTextBoxColumn.HeaderText = "Zoccoli"
        Me.ZoccoliDataGridViewTextBoxColumn.Name = "ZoccoliDataGridViewTextBoxColumn"
        Me.ZoccoliDataGridViewTextBoxColumn.ReadOnly = True
        Me.ZoccoliDataGridViewTextBoxColumn.Width = 67
        '
        'RivestimentoDataGridViewCheckBoxColumn
        '
        Me.RivestimentoDataGridViewCheckBoxColumn.DataPropertyName = "Rivestimento"
        Me.RivestimentoDataGridViewCheckBoxColumn.HeaderText = "Rivestimento"
        Me.RivestimentoDataGridViewCheckBoxColumn.Name = "RivestimentoDataGridViewCheckBoxColumn"
        Me.RivestimentoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.RivestimentoDataGridViewCheckBoxColumn.Width = 74
        '
        'TipoRivestimentoDataGridViewTextBoxColumn
        '
        Me.TipoRivestimentoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Rivestimento"
        Me.TipoRivestimentoDataGridViewTextBoxColumn.HeaderText = "Tipo_Rivestimento"
        Me.TipoRivestimentoDataGridViewTextBoxColumn.Name = "TipoRivestimentoDataGridViewTextBoxColumn"
        Me.TipoRivestimentoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoRivestimentoDataGridViewTextBoxColumn.Width = 120
        '
        'NoteDataGridViewTextBoxColumn
        '
        Me.NoteDataGridViewTextBoxColumn.DataPropertyName = "Note"
        Me.NoteDataGridViewTextBoxColumn.HeaderText = "Note"
        Me.NoteDataGridViewTextBoxColumn.Name = "NoteDataGridViewTextBoxColumn"
        Me.NoteDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoteDataGridViewTextBoxColumn.Width = 55
        '
        'DataConsegnaDataGridViewTextBoxColumn
        '
        Me.DataConsegnaDataGridViewTextBoxColumn.DataPropertyName = "Data_Consegna"
        Me.DataConsegnaDataGridViewTextBoxColumn.HeaderText = "Data_Consegna"
        Me.DataConsegnaDataGridViewTextBoxColumn.Name = "DataConsegnaDataGridViewTextBoxColumn"
        Me.DataConsegnaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DataConsegnaDataGridViewTextBoxColumn.Width = 109
        '
        'HTDataGridViewCheckBoxColumn
        '
        Me.HTDataGridViewCheckBoxColumn.DataPropertyName = "HT"
        Me.HTDataGridViewCheckBoxColumn.HeaderText = "HT"
        Me.HTDataGridViewCheckBoxColumn.Name = "HTDataGridViewCheckBoxColumn"
        Me.HTDataGridViewCheckBoxColumn.ReadOnly = True
        Me.HTDataGridViewCheckBoxColumn.Width = 28
        '
        'DTDataGridViewCheckBoxColumn
        '
        Me.DTDataGridViewCheckBoxColumn.DataPropertyName = "DT"
        Me.DTDataGridViewCheckBoxColumn.HeaderText = "DT"
        Me.DTDataGridViewCheckBoxColumn.Name = "DTDataGridViewCheckBoxColumn"
        Me.DTDataGridViewCheckBoxColumn.ReadOnly = True
        Me.DTDataGridViewCheckBoxColumn.Width = 28
        '
        'BMDataGridViewCheckBoxColumn
        '
        Me.BMDataGridViewCheckBoxColumn.DataPropertyName = "BM"
        Me.BMDataGridViewCheckBoxColumn.HeaderText = "BM"
        Me.BMDataGridViewCheckBoxColumn.Name = "BMDataGridViewCheckBoxColumn"
        Me.BMDataGridViewCheckBoxColumn.ReadOnly = True
        Me.BMDataGridViewCheckBoxColumn.Width = 29
        '
        'RivestTotDataGridViewTextBoxColumn
        '
        Me.RivestTotDataGridViewTextBoxColumn.DataPropertyName = "Rivest_Tot"
        Me.RivestTotDataGridViewTextBoxColumn.HeaderText = "Rivest_Tot"
        Me.RivestTotDataGridViewTextBoxColumn.Name = "RivestTotDataGridViewTextBoxColumn"
        Me.RivestTotDataGridViewTextBoxColumn.ReadOnly = True
        Me.RivestTotDataGridViewTextBoxColumn.Width = 84
        '
        'MagazzinoDataGridViewTextBoxColumn
        '
        Me.MagazzinoDataGridViewTextBoxColumn.DataPropertyName = "Magazzino"
        Me.MagazzinoDataGridViewTextBoxColumn.HeaderText = "Magazzino"
        Me.MagazzinoDataGridViewTextBoxColumn.Name = "MagazzinoDataGridViewTextBoxColumn"
        Me.MagazzinoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MagazzinoDataGridViewTextBoxColumn.Width = 83
        '
        'DiagonaliDataGridViewCheckBoxColumn
        '
        Me.DiagonaliDataGridViewCheckBoxColumn.DataPropertyName = "Diagonali"
        Me.DiagonaliDataGridViewCheckBoxColumn.HeaderText = "Diagonali"
        Me.DiagonaliDataGridViewCheckBoxColumn.Name = "DiagonaliDataGridViewCheckBoxColumn"
        Me.DiagonaliDataGridViewCheckBoxColumn.ReadOnly = True
        Me.DiagonaliDataGridViewCheckBoxColumn.Width = 57
        '
        'StampatoDataGridViewCheckBoxColumn
        '
        Me.StampatoDataGridViewCheckBoxColumn.DataPropertyName = "Stampato"
        Me.StampatoDataGridViewCheckBoxColumn.HeaderText = "Stampato"
        Me.StampatoDataGridViewCheckBoxColumn.Name = "StampatoDataGridViewCheckBoxColumn"
        Me.StampatoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.StampatoDataGridViewCheckBoxColumn.Visible = False
        Me.StampatoDataGridViewCheckBoxColumn.Width = 58
        '
        'ProduzioneDataGridViewCheckBoxColumn
        '
        Me.ProduzioneDataGridViewCheckBoxColumn.DataPropertyName = "Produzione"
        Me.ProduzioneDataGridViewCheckBoxColumn.HeaderText = "Produzione"
        Me.ProduzioneDataGridViewCheckBoxColumn.Name = "ProduzioneDataGridViewCheckBoxColumn"
        Me.ProduzioneDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ProduzioneDataGridViewCheckBoxColumn.Visible = False
        Me.ProduzioneDataGridViewCheckBoxColumn.Width = 66
        '
        'EvasoDataGridViewCheckBoxColumn
        '
        Me.EvasoDataGridViewCheckBoxColumn.DataPropertyName = "Evaso"
        Me.EvasoDataGridViewCheckBoxColumn.HeaderText = "Evaso"
        Me.EvasoDataGridViewCheckBoxColumn.Name = "EvasoDataGridViewCheckBoxColumn"
        Me.EvasoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.EvasoDataGridViewCheckBoxColumn.Visible = False
        Me.EvasoDataGridViewCheckBoxColumn.Width = 43
        '
        'DataOrdineDataGridViewTextBoxColumn
        '
        Me.DataOrdineDataGridViewTextBoxColumn.DataPropertyName = "Data_Ordine"
        Me.DataOrdineDataGridViewTextBoxColumn.HeaderText = "Data_Ordine"
        Me.DataOrdineDataGridViewTextBoxColumn.Name = "DataOrdineDataGridViewTextBoxColumn"
        Me.DataOrdineDataGridViewTextBoxColumn.ReadOnly = True
        Me.DataOrdineDataGridViewTextBoxColumn.Width = 92
        '
        'OrdiniBindingSource
        '
        Me.OrdiniBindingSource.DataMember = "Ordini"
        Me.OrdiniBindingSource.DataSource = Me.ModPackDBDataSet
        '
        'ModPackDBDataSet
        '
        Me.ModPackDBDataSet.DataSetName = "ModPackDBDataSet"
        Me.ModPackDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TxtCerca, Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.Cb_Colonna, Me.Bt_Cerca, Me.Bt_CancellaFiltro, Me.Bt_FiltraPerData, Me.Bt_Refresh, Me.Bt_Colonne})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1186, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TxtCerca
        '
        Me.TxtCerca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCerca.Name = "TxtCerca"
        Me.TxtCerca.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 22)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Cb_Colonna
        '
        Me.Cb_Colonna.Name = "Cb_Colonna"
        Me.Cb_Colonna.Size = New System.Drawing.Size(121, 25)
        '
        'Bt_Cerca
        '
        Me.Bt_Cerca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Bt_Cerca.Image = CType(resources.GetObject("Bt_Cerca.Image"), System.Drawing.Image)
        Me.Bt_Cerca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bt_Cerca.Name = "Bt_Cerca"
        Me.Bt_Cerca.Size = New System.Drawing.Size(23, 22)
        Me.Bt_Cerca.Text = "AggiungiFiltro"
        Me.Bt_Cerca.ToolTipText = "Filtra"
        '
        'Bt_CancellaFiltro
        '
        Me.Bt_CancellaFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Bt_CancellaFiltro.Image = CType(resources.GetObject("Bt_CancellaFiltro.Image"), System.Drawing.Image)
        Me.Bt_CancellaFiltro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bt_CancellaFiltro.Name = "Bt_CancellaFiltro"
        Me.Bt_CancellaFiltro.Size = New System.Drawing.Size(23, 22)
        Me.Bt_CancellaFiltro.ToolTipText = "Cancella Filtri"
        '
        'Bt_FiltraPerData
        '
        Me.Bt_FiltraPerData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Bt_FiltraPerData.Image = CType(resources.GetObject("Bt_FiltraPerData.Image"), System.Drawing.Image)
        Me.Bt_FiltraPerData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bt_FiltraPerData.Name = "Bt_FiltraPerData"
        Me.Bt_FiltraPerData.Size = New System.Drawing.Size(23, 22)
        Me.Bt_FiltraPerData.ToolTipText = "Filtra Per Data"
        '
        'Bt_Refresh
        '
        Me.Bt_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Bt_Refresh.Image = CType(resources.GetObject("Bt_Refresh.Image"), System.Drawing.Image)
        Me.Bt_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bt_Refresh.Name = "Bt_Refresh"
        Me.Bt_Refresh.Size = New System.Drawing.Size(23, 22)
        Me.Bt_Refresh.Text = "Refresh"
        '
        'Bt_Colonne
        '
        Me.Bt_Colonne.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Bt_Colonne.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Bt_Colonne.Image = CType(resources.GetObject("Bt_Colonne.Image"), System.Drawing.Image)
        Me.Bt_Colonne.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bt_Colonne.Name = "Bt_Colonne"
        Me.Bt_Colonne.Size = New System.Drawing.Size(23, 22)
        Me.Bt_Colonne.Text = "Colonne"
        '
        'OrdiniTableAdapter
        '
        Me.OrdiniTableAdapter.ClearBeforeFill = True
        '
        'Form_StoricoOrdini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(1186, 738)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DGW_Righe)
        Me.Controls.Add(Me.DGW_Ordini)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_StoricoOrdini"
        Me.Text = "Storico Ordini"
        CType(Me.DGW_Ordini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGW_Righe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdiniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModPackDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGW_Ordini As DataGridView
    Friend WithEvents DGW_Righe As DataGridView
    Friend WithEvents ModPackDBDataSet As ModPackDBDataSet
    Friend WithEvents OrdiniBindingSource As BindingSource
    Friend WithEvents OrdiniTableAdapter As ModPackDBDataSetTableAdapters.OrdiniTableAdapter
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TxtCerca As ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Cb_Colonna As ToolStripComboBox
    Friend WithEvents Bt_Cerca As ToolStripButton
    Friend WithEvents Bt_CancellaFiltro As ToolStripButton
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrdineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RigaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImballoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndiceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodiceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommessaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZoccoliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RivestimentoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TipoRivestimentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataConsegnaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HTDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DTDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents BMDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents RivestTotDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MagazzinoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiagonaliDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents StampatoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ProduzioneDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents EvasoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DataOrdineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Bt_FiltraPerData As ToolStripButton
    Friend WithEvents Bt_Refresh As ToolStripButton
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Bt_Colonne As ToolStripButton
End Class
