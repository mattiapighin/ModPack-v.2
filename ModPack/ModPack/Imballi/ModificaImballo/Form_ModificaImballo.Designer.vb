<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_ModificaImballo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ModificaImballo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImballiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModPackDBDataSet = New ModPack.ModPackDBDataSet()
        Me.ImballiTableAdapter = New ModPack.ModPackDBDataSetTableAdapters.ImballiTableAdapter()
        Me.PanelCodice = New System.Windows.Forms.Panel()
        Me.Bt_StartEdit = New System.Windows.Forms.Button()
        Me.CbImballo = New System.Windows.Forms.ComboBox()
        Me.ImballiIndiciBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IndiciTableAdapter = New ModPack.ModPackDBDataSetTableAdapters.IndiciTableAdapter()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtTipoRivestimento = New System.Windows.Forms.TextBox()
        Me.txtZoccoli = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtH = New System.Windows.Forms.TextBox()
        Me.txtP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ckRivestimento = New System.Windows.Forms.CheckBox()
        Me.ckHT = New System.Windows.Forms.CheckBox()
        Me.ckDT = New System.Windows.Forms.CheckBox()
        Me.ckBM = New System.Windows.Forms.CheckBox()
        Me.ckDiagonali = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtL = New System.Windows.Forms.TextBox()
        Me.txtGradiF = New System.Windows.Forms.TextBox()
        Me.txtGradiT = New System.Windows.Forms.TextBox()
        Me.txtPrimoMorale = New System.Windows.Forms.TextBox()
        Me.txtM2 = New System.Windows.Forms.TextBox()
        Me.txtM3 = New System.Windows.Forms.TextBox()
        Me.txtPrezzo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Bt_LoadImage = New System.Windows.Forms.Button()
        Me.PbImg = New System.Windows.Forms.PictureBox()
        Me.DGWDistinta = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImballoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RigaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.XDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImballiDistintaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DistintaTableAdapter = New ModPack.ModPackDBDataSetTableAdapters.DistintaTableAdapter()
        Me.Bt_Salva = New System.Windows.Forms.Button()
        Me.PanelModifica = New System.Windows.Forms.Panel()
        Me.Bt_EliminaIndice = New System.Windows.Forms.Button()
        Me.Bt_AddIndice = New System.Windows.Forms.Button()
        Me.Bt_SpostaIndice = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtSottoMF = New System.Windows.Forms.TextBox()
        Me.TxtSopraMF = New System.Windows.Forms.TextBox()
        Me.TxtSottoMT = New System.Windows.Forms.TextBox()
        Me.TxtSopraMT = New System.Windows.Forms.TextBox()
        Me.DgwIndici = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImballoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RivestTotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteBICDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImballiIndiciBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Bt_NoImg = New System.Windows.Forms.Button()
        Me.Bt_Cancel = New System.Windows.Forms.Button()
        Me.PanelButtons = New System.Windows.Forms.Panel()
        Me.Bt_EliminaCodice = New System.Windows.Forms.Button()
        Me.Bt_Duplica = New System.Windows.Forms.Button()
        Me.ImballiIndiciBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tool = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ImballiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModPackDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCodice.SuspendLayout()
        CType(Me.ImballiIndiciBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PbImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGWDistinta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImballiDistintaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelModifica.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DgwIndici, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImballiIndiciBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelButtons.SuspendLayout()
        CType(Me.ImballiIndiciBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CODICE"
        '
        'ImballiBindingSource
        '
        Me.ImballiBindingSource.DataMember = "Imballi"
        Me.ImballiBindingSource.DataSource = Me.ModPackDBDataSet
        '
        'ModPackDBDataSet
        '
        Me.ModPackDBDataSet.DataSetName = "ModPackDBDataSet"
        Me.ModPackDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ImballiTableAdapter
        '
        Me.ImballiTableAdapter.ClearBeforeFill = True
        '
        'PanelCodice
        '
        Me.PanelCodice.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PanelCodice.Controls.Add(Me.Bt_StartEdit)
        Me.PanelCodice.Controls.Add(Me.CbImballo)
        Me.PanelCodice.Controls.Add(Me.Label1)
        Me.PanelCodice.Location = New System.Drawing.Point(12, 12)
        Me.PanelCodice.Name = "PanelCodice"
        Me.PanelCodice.Size = New System.Drawing.Size(334, 42)
        Me.PanelCodice.TabIndex = 2
        '
        'Bt_StartEdit
        '
        Me.Bt_StartEdit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Bt_StartEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bt_StartEdit.FlatAppearance.BorderSize = 0
        Me.Bt_StartEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_StartEdit.Image = CType(resources.GetObject("Bt_StartEdit.Image"), System.Drawing.Image)
        Me.Bt_StartEdit.Location = New System.Drawing.Point(295, 6)
        Me.Bt_StartEdit.Name = "Bt_StartEdit"
        Me.Bt_StartEdit.Size = New System.Drawing.Size(30, 30)
        Me.Bt_StartEdit.TabIndex = 2
        Me.Bt_StartEdit.UseVisualStyleBackColor = False
        '
        'CbImballo
        '
        Me.CbImballo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CbImballo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbImballo.DataSource = Me.ImballiBindingSource
        Me.CbImballo.DisplayMember = "Imballo"
        Me.CbImballo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CbImballo.FormattingEnabled = True
        Me.CbImballo.Location = New System.Drawing.Point(62, 11)
        Me.CbImballo.Name = "CbImballo"
        Me.CbImballo.Size = New System.Drawing.Size(227, 21)
        Me.CbImballo.TabIndex = 1
        '
        'ImballiIndiciBindingSource
        '
        Me.ImballiIndiciBindingSource.DataMember = "Imballi_Indici"
        Me.ImballiIndiciBindingSource.DataSource = Me.ImballiBindingSource
        '
        'IndiciTableAdapter
        '
        Me.IndiciTableAdapter.ClearBeforeFill = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtTipoRivestimento, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtZoccoli, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTipo, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtH, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtP, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ckRivestimento, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.ckHT, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.ckDT, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.ckBM, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.ckDiagonali, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.txtL, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtGradiF, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.txtGradiT, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPrimoMorale, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.txtM2, 1, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.txtM3, 1, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPrezzo, 1, 14)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 15
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(217, 495)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'txtTipoRivestimento
        '
        Me.txtTipoRivestimento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTipoRivestimento.Location = New System.Drawing.Point(112, 171)
        Me.txtTipoRivestimento.Name = "txtTipoRivestimento"
        Me.txtTipoRivestimento.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoRivestimento.TabIndex = 22
        Me.txtTipoRivestimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtZoccoli
        '
        Me.txtZoccoli.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtZoccoli.Location = New System.Drawing.Point(112, 138)
        Me.txtZoccoli.Name = "txtZoccoli"
        Me.txtZoccoli.Size = New System.Drawing.Size(100, 20)
        Me.txtZoccoli.TabIndex = 21
        Me.txtZoccoli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTipo
        '
        Me.txtTipo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTipo.Location = New System.Drawing.Point(112, 105)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(100, 20)
        Me.txtTipo.TabIndex = 20
        Me.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtH
        '
        Me.txtH.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtH.Location = New System.Drawing.Point(112, 72)
        Me.txtH.Name = "txtH"
        Me.txtH.Size = New System.Drawing.Size(100, 20)
        Me.txtH.TabIndex = 19
        Me.txtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtP
        '
        Me.txtP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtP.Location = New System.Drawing.Point(112, 39)
        Me.txtP.Name = "txtP"
        Me.txtP.Size = New System.Drawing.Size(100, 20)
        Me.txtP.TabIndex = 18
        Me.txtP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "L"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "P"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "H"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tipo"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Zoccoli"
        '
        'ckRivestimento
        '
        Me.ckRivestimento.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ckRivestimento.AutoSize = True
        Me.ckRivestimento.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckRivestimento.Location = New System.Drawing.Point(18, 173)
        Me.ckRivestimento.Name = "ckRivestimento"
        Me.ckRivestimento.Size = New System.Drawing.Size(87, 17)
        Me.ckRivestimento.TabIndex = 5
        Me.ckRivestimento.Text = "Rivestimento"
        Me.ckRivestimento.UseVisualStyleBackColor = True
        '
        'ckHT
        '
        Me.ckHT.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ckHT.AutoSize = True
        Me.ckHT.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckHT.Location = New System.Drawing.Point(64, 206)
        Me.ckHT.Name = "ckHT"
        Me.ckHT.Size = New System.Drawing.Size(41, 17)
        Me.ckHT.TabIndex = 6
        Me.ckHT.Text = "HT"
        Me.ckHT.UseVisualStyleBackColor = True
        '
        'ckDT
        '
        Me.ckDT.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ckDT.AutoSize = True
        Me.ckDT.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckDT.Location = New System.Drawing.Point(64, 239)
        Me.ckDT.Name = "ckDT"
        Me.ckDT.Size = New System.Drawing.Size(41, 17)
        Me.ckDT.TabIndex = 7
        Me.ckDT.Text = "DT"
        Me.ckDT.UseVisualStyleBackColor = True
        '
        'ckBM
        '
        Me.ckBM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ckBM.AutoSize = True
        Me.ckBM.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckBM.Location = New System.Drawing.Point(141, 239)
        Me.ckBM.Name = "ckBM"
        Me.ckBM.Size = New System.Drawing.Size(42, 17)
        Me.ckBM.TabIndex = 8
        Me.ckBM.Text = "BM"
        Me.ckBM.UseVisualStyleBackColor = True
        '
        'ckDiagonali
        '
        Me.ckDiagonali.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ckDiagonali.AutoSize = True
        Me.ckDiagonali.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckDiagonali.Location = New System.Drawing.Point(35, 272)
        Me.ckDiagonali.Name = "ckDiagonali"
        Me.ckDiagonali.Size = New System.Drawing.Size(70, 17)
        Me.ckDiagonali.TabIndex = 9
        Me.ckDiagonali.Text = "Diagonali"
        Me.ckDiagonali.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(64, 307)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Gradi F"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(63, 340)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Gradi T"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(37, 373)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Primo Morale"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(83, 406)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "M2"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(83, 439)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "M3"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(66, 472)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Prezzo"
        '
        'txtL
        '
        Me.txtL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtL.Location = New System.Drawing.Point(112, 6)
        Me.txtL.Name = "txtL"
        Me.txtL.Size = New System.Drawing.Size(100, 20)
        Me.txtL.TabIndex = 17
        Me.txtL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGradiF
        '
        Me.txtGradiF.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtGradiF.Location = New System.Drawing.Point(112, 303)
        Me.txtGradiF.Name = "txtGradiF"
        Me.txtGradiF.Size = New System.Drawing.Size(100, 20)
        Me.txtGradiF.TabIndex = 23
        Me.txtGradiF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGradiT
        '
        Me.txtGradiT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtGradiT.Location = New System.Drawing.Point(112, 336)
        Me.txtGradiT.Name = "txtGradiT"
        Me.txtGradiT.Size = New System.Drawing.Size(100, 20)
        Me.txtGradiT.TabIndex = 24
        Me.txtGradiT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrimoMorale
        '
        Me.txtPrimoMorale.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrimoMorale.Location = New System.Drawing.Point(112, 369)
        Me.txtPrimoMorale.Name = "txtPrimoMorale"
        Me.txtPrimoMorale.Size = New System.Drawing.Size(100, 20)
        Me.txtPrimoMorale.TabIndex = 25
        Me.txtPrimoMorale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtM2
        '
        Me.txtM2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtM2.Location = New System.Drawing.Point(112, 402)
        Me.txtM2.Name = "txtM2"
        Me.txtM2.Size = New System.Drawing.Size(100, 20)
        Me.txtM2.TabIndex = 26
        Me.txtM2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtM3
        '
        Me.txtM3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtM3.Location = New System.Drawing.Point(112, 435)
        Me.txtM3.Name = "txtM3"
        Me.txtM3.Size = New System.Drawing.Size(100, 20)
        Me.txtM3.TabIndex = 27
        Me.txtM3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrezzo
        '
        Me.txtPrezzo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrezzo.Location = New System.Drawing.Point(112, 468)
        Me.txtPrezzo.Name = "txtPrezzo"
        Me.txtPrezzo.Size = New System.Drawing.Size(100, 20)
        Me.txtPrezzo.TabIndex = 28
        Me.txtPrezzo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Immagine"
        '
        'Bt_LoadImage
        '
        Me.Bt_LoadImage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Bt_LoadImage.Location = New System.Drawing.Point(198, 4)
        Me.Bt_LoadImage.Name = "Bt_LoadImage"
        Me.Bt_LoadImage.Size = New System.Drawing.Size(75, 27)
        Me.Bt_LoadImage.TabIndex = 29
        Me.Bt_LoadImage.Text = "Carica"
        Me.Bt_LoadImage.UseVisualStyleBackColor = True
        '
        'PbImg
        '
        Me.PbImg.BackColor = System.Drawing.SystemColors.GrayText
        Me.PbImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PbImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbImg.Location = New System.Drawing.Point(3, 36)
        Me.PbImg.Name = "PbImg"
        Me.PbImg.Size = New System.Drawing.Size(269, 160)
        Me.PbImg.TabIndex = 4
        Me.PbImg.TabStop = False
        '
        'DGWDistinta
        '
        Me.DGWDistinta.AutoGenerateColumns = False
        Me.DGWDistinta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGWDistinta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGWDistinta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ImballoDataGridViewTextBoxColumn, Me.RigaDataGridViewTextBoxColumn, Me.PartDataGridViewTextBoxColumn, Me.XDataGridViewTextBoxColumn, Me.YDataGridViewTextBoxColumn, Me.ZDataGridViewTextBoxColumn, Me.NDataGridViewTextBoxColumn, Me.TagDataGridViewTextBoxColumn})
        Me.DGWDistinta.DataSource = Me.ImballiDistintaBindingSource
        Me.DGWDistinta.Location = New System.Drawing.Point(509, 3)
        Me.DGWDistinta.Name = "DGWDistinta"
        Me.DGWDistinta.RowHeadersWidth = 10
        Me.DGWDistinta.Size = New System.Drawing.Size(350, 339)
        Me.DGWDistinta.TabIndex = 5
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'ImballoDataGridViewTextBoxColumn
        '
        Me.ImballoDataGridViewTextBoxColumn.DataPropertyName = "Imballo"
        Me.ImballoDataGridViewTextBoxColumn.HeaderText = "Imballo"
        Me.ImballoDataGridViewTextBoxColumn.Name = "ImballoDataGridViewTextBoxColumn"
        Me.ImballoDataGridViewTextBoxColumn.Visible = False
        '
        'RigaDataGridViewTextBoxColumn
        '
        Me.RigaDataGridViewTextBoxColumn.DataPropertyName = "Riga"
        Me.RigaDataGridViewTextBoxColumn.HeaderText = "Riga"
        Me.RigaDataGridViewTextBoxColumn.Name = "RigaDataGridViewTextBoxColumn"
        '
        'PartDataGridViewTextBoxColumn
        '
        Me.PartDataGridViewTextBoxColumn.DataPropertyName = "Part"
        Me.PartDataGridViewTextBoxColumn.HeaderText = "Part"
        Me.PartDataGridViewTextBoxColumn.Name = "PartDataGridViewTextBoxColumn"
        '
        'XDataGridViewTextBoxColumn
        '
        Me.XDataGridViewTextBoxColumn.DataPropertyName = "X"
        Me.XDataGridViewTextBoxColumn.HeaderText = "X"
        Me.XDataGridViewTextBoxColumn.Name = "XDataGridViewTextBoxColumn"
        '
        'YDataGridViewTextBoxColumn
        '
        Me.YDataGridViewTextBoxColumn.DataPropertyName = "Y"
        Me.YDataGridViewTextBoxColumn.HeaderText = "Y"
        Me.YDataGridViewTextBoxColumn.Name = "YDataGridViewTextBoxColumn"
        '
        'ZDataGridViewTextBoxColumn
        '
        Me.ZDataGridViewTextBoxColumn.DataPropertyName = "Z"
        Me.ZDataGridViewTextBoxColumn.HeaderText = "Z"
        Me.ZDataGridViewTextBoxColumn.Name = "ZDataGridViewTextBoxColumn"
        '
        'NDataGridViewTextBoxColumn
        '
        Me.NDataGridViewTextBoxColumn.DataPropertyName = "N"
        Me.NDataGridViewTextBoxColumn.HeaderText = "N"
        Me.NDataGridViewTextBoxColumn.Name = "NDataGridViewTextBoxColumn"
        '
        'TagDataGridViewTextBoxColumn
        '
        Me.TagDataGridViewTextBoxColumn.DataPropertyName = "Tag"
        Me.TagDataGridViewTextBoxColumn.HeaderText = "Tag"
        Me.TagDataGridViewTextBoxColumn.Name = "TagDataGridViewTextBoxColumn"
        '
        'ImballiDistintaBindingSource
        '
        Me.ImballiDistintaBindingSource.DataMember = "Imballi_Distinta"
        Me.ImballiDistintaBindingSource.DataSource = Me.ImballiBindingSource
        '
        'DistintaTableAdapter
        '
        Me.DistintaTableAdapter.ClearBeforeFill = True
        '
        'Bt_Salva
        '
        Me.Bt_Salva.FlatAppearance.BorderSize = 0
        Me.Bt_Salva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Salva.Image = CType(resources.GetObject("Bt_Salva.Image"), System.Drawing.Image)
        Me.Bt_Salva.Location = New System.Drawing.Point(245, 1)
        Me.Bt_Salva.Name = "Bt_Salva"
        Me.Bt_Salva.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Salva.TabIndex = 6
        Me.Bt_Salva.UseVisualStyleBackColor = True
        '
        'PanelModifica
        '
        Me.PanelModifica.Controls.Add(Me.Bt_EliminaIndice)
        Me.PanelModifica.Controls.Add(Me.Bt_AddIndice)
        Me.PanelModifica.Controls.Add(Me.Bt_SpostaIndice)
        Me.PanelModifica.Controls.Add(Me.TableLayoutPanel2)
        Me.PanelModifica.Controls.Add(Me.DgwIndici)
        Me.PanelModifica.Controls.Add(Me.Panel1)
        Me.PanelModifica.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelModifica.Controls.Add(Me.DGWDistinta)
        Me.PanelModifica.Enabled = False
        Me.PanelModifica.Location = New System.Drawing.Point(12, 66)
        Me.PanelModifica.Name = "PanelModifica"
        Me.PanelModifica.Size = New System.Drawing.Size(866, 504)
        Me.PanelModifica.TabIndex = 7
        '
        'Bt_EliminaIndice
        '
        Me.Bt_EliminaIndice.Image = CType(resources.GetObject("Bt_EliminaIndice.Image"), System.Drawing.Image)
        Me.Bt_EliminaIndice.Location = New System.Drawing.Point(823, 422)
        Me.Bt_EliminaIndice.Name = "Bt_EliminaIndice"
        Me.Bt_EliminaIndice.Size = New System.Drawing.Size(36, 36)
        Me.Bt_EliminaIndice.TabIndex = 35
        Me.Bt_EliminaIndice.UseVisualStyleBackColor = True
        '
        'Bt_AddIndice
        '
        Me.Bt_AddIndice.Image = CType(resources.GetObject("Bt_AddIndice.Image"), System.Drawing.Image)
        Me.Bt_AddIndice.Location = New System.Drawing.Point(823, 462)
        Me.Bt_AddIndice.Name = "Bt_AddIndice"
        Me.Bt_AddIndice.Size = New System.Drawing.Size(36, 36)
        Me.Bt_AddIndice.TabIndex = 34
        Me.Bt_AddIndice.UseVisualStyleBackColor = True
        '
        'Bt_SpostaIndice
        '
        Me.Bt_SpostaIndice.Image = CType(resources.GetObject("Bt_SpostaIndice.Image"), System.Drawing.Image)
        Me.Bt_SpostaIndice.Location = New System.Drawing.Point(823, 348)
        Me.Bt_SpostaIndice.Name = "Bt_SpostaIndice"
        Me.Bt_SpostaIndice.Size = New System.Drawing.Size(36, 36)
        Me.Bt_SpostaIndice.TabIndex = 33
        Me.Tool.SetToolTip(Me.Bt_SpostaIndice, "Sposta indice su altro imballo")
        Me.Bt_SpostaIndice.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label18, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label14, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label17, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label15, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtSottoMF, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtSopraMF, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtSottoMT, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtSopraMT, 1, 3)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(226, 208)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(277, 134)
        Me.TableLayoutPanel2.TabIndex = 32
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(46, 110)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 13)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Sopra Montanti T"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(50, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Sotto Montanti F"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(47, 43)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 13)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Sopra Montanti F"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(49, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Sotto Montanti T"
        '
        'TxtSottoMF
        '
        Me.TxtSottoMF.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtSottoMF.Location = New System.Drawing.Point(157, 6)
        Me.TxtSottoMF.Name = "TxtSottoMF"
        Me.TxtSottoMF.Size = New System.Drawing.Size(100, 20)
        Me.TxtSottoMF.TabIndex = 18
        Me.TxtSottoMF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtSopraMF
        '
        Me.TxtSopraMF.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtSopraMF.Location = New System.Drawing.Point(157, 39)
        Me.TxtSopraMF.Name = "TxtSopraMF"
        Me.TxtSopraMF.Size = New System.Drawing.Size(100, 20)
        Me.TxtSopraMF.TabIndex = 19
        Me.TxtSopraMF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtSottoMT
        '
        Me.TxtSottoMT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtSottoMT.Location = New System.Drawing.Point(157, 72)
        Me.TxtSottoMT.Name = "TxtSottoMT"
        Me.TxtSottoMT.Size = New System.Drawing.Size(100, 20)
        Me.TxtSottoMT.TabIndex = 20
        Me.TxtSottoMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtSopraMT
        '
        Me.TxtSopraMT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtSopraMT.Location = New System.Drawing.Point(157, 106)
        Me.TxtSopraMT.Name = "TxtSopraMT"
        Me.TxtSopraMT.Size = New System.Drawing.Size(100, 20)
        Me.TxtSopraMT.TabIndex = 21
        Me.TxtSopraMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DgwIndici
        '
        Me.DgwIndici.AllowUserToAddRows = False
        Me.DgwIndici.AllowUserToResizeColumns = False
        Me.DgwIndici.AllowUserToResizeRows = False
        Me.DgwIndici.AutoGenerateColumns = False
        Me.DgwIndici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgwIndici.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgwIndici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgwIndici.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.ImballoDataGridViewTextBoxColumn1, Me.IndiceDataGridViewTextBoxColumn, Me.CodiceDataGridViewTextBoxColumn, Me.NoteDataGridViewTextBoxColumn, Me.RivestTotDataGridViewTextBoxColumn, Me.NoteBICDataGridViewTextBoxColumn})
        Me.DgwIndici.DataSource = Me.ImballiIndiciBindingSource2
        Me.DgwIndici.Location = New System.Drawing.Point(226, 348)
        Me.DgwIndici.Name = "DgwIndici"
        Me.DgwIndici.RowHeadersWidth = 10
        Me.DgwIndici.Size = New System.Drawing.Size(591, 150)
        Me.DgwIndici.TabIndex = 31
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn1.Visible = False
        '
        'ImballoDataGridViewTextBoxColumn1
        '
        Me.ImballoDataGridViewTextBoxColumn1.DataPropertyName = "Imballo"
        Me.ImballoDataGridViewTextBoxColumn1.HeaderText = "Imballo"
        Me.ImballoDataGridViewTextBoxColumn1.Name = "ImballoDataGridViewTextBoxColumn1"
        Me.ImballoDataGridViewTextBoxColumn1.Visible = False
        '
        'IndiceDataGridViewTextBoxColumn
        '
        Me.IndiceDataGridViewTextBoxColumn.DataPropertyName = "Indice"
        Me.IndiceDataGridViewTextBoxColumn.HeaderText = "Indice"
        Me.IndiceDataGridViewTextBoxColumn.Name = "IndiceDataGridViewTextBoxColumn"
        '
        'CodiceDataGridViewTextBoxColumn
        '
        Me.CodiceDataGridViewTextBoxColumn.DataPropertyName = "Codice"
        Me.CodiceDataGridViewTextBoxColumn.HeaderText = "Codice"
        Me.CodiceDataGridViewTextBoxColumn.Name = "CodiceDataGridViewTextBoxColumn"
        '
        'NoteDataGridViewTextBoxColumn
        '
        Me.NoteDataGridViewTextBoxColumn.DataPropertyName = "Note"
        Me.NoteDataGridViewTextBoxColumn.HeaderText = "Note1"
        Me.NoteDataGridViewTextBoxColumn.Name = "NoteDataGridViewTextBoxColumn"
        '
        'RivestTotDataGridViewTextBoxColumn
        '
        Me.RivestTotDataGridViewTextBoxColumn.DataPropertyName = "Rivest_Tot"
        Me.RivestTotDataGridViewTextBoxColumn.HeaderText = "Note2"
        Me.RivestTotDataGridViewTextBoxColumn.Name = "RivestTotDataGridViewTextBoxColumn"
        '
        'NoteBICDataGridViewTextBoxColumn
        '
        Me.NoteBICDataGridViewTextBoxColumn.DataPropertyName = "Note_BIC"
        Me.NoteBICDataGridViewTextBoxColumn.HeaderText = "Note Bicciato"
        Me.NoteBICDataGridViewTextBoxColumn.Name = "NoteBICDataGridViewTextBoxColumn"
        '
        'ImballiIndiciBindingSource2
        '
        Me.ImballiIndiciBindingSource2.DataMember = "Imballi_Indici"
        Me.ImballiIndiciBindingSource2.DataSource = Me.ImballiBindingSource
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Bt_NoImg)
        Me.Panel1.Controls.Add(Me.PbImg)
        Me.Panel1.Controls.Add(Me.Bt_LoadImage)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Location = New System.Drawing.Point(226, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(277, 199)
        Me.Panel1.TabIndex = 30
        '
        'Bt_NoImg
        '
        Me.Bt_NoImg.Location = New System.Drawing.Point(117, 5)
        Me.Bt_NoImg.Name = "Bt_NoImg"
        Me.Bt_NoImg.Size = New System.Drawing.Size(75, 26)
        Me.Bt_NoImg.TabIndex = 30
        Me.Bt_NoImg.Text = "Svuota"
        Me.Bt_NoImg.UseVisualStyleBackColor = True
        '
        'Bt_Cancel
        '
        Me.Bt_Cancel.FlatAppearance.BorderSize = 0
        Me.Bt_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Cancel.Image = CType(resources.GetObject("Bt_Cancel.Image"), System.Drawing.Image)
        Me.Bt_Cancel.Location = New System.Drawing.Point(291, 1)
        Me.Bt_Cancel.Name = "Bt_Cancel"
        Me.Bt_Cancel.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Cancel.TabIndex = 8
        Me.Bt_Cancel.UseVisualStyleBackColor = True
        '
        'PanelButtons
        '
        Me.PanelButtons.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PanelButtons.Controls.Add(Me.Bt_EliminaCodice)
        Me.PanelButtons.Controls.Add(Me.Bt_Duplica)
        Me.PanelButtons.Controls.Add(Me.Bt_Cancel)
        Me.PanelButtons.Controls.Add(Me.Bt_Salva)
        Me.PanelButtons.Enabled = False
        Me.PanelButtons.Location = New System.Drawing.Point(544, 12)
        Me.PanelButtons.Name = "PanelButtons"
        Me.PanelButtons.Size = New System.Drawing.Size(334, 42)
        Me.PanelButtons.TabIndex = 9
        '
        'Bt_EliminaCodice
        '
        Me.Bt_EliminaCodice.FlatAppearance.BorderSize = 0
        Me.Bt_EliminaCodice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_EliminaCodice.Image = CType(resources.GetObject("Bt_EliminaCodice.Image"), System.Drawing.Image)
        Me.Bt_EliminaCodice.Location = New System.Drawing.Point(49, 1)
        Me.Bt_EliminaCodice.Name = "Bt_EliminaCodice"
        Me.Bt_EliminaCodice.Size = New System.Drawing.Size(40, 40)
        Me.Bt_EliminaCodice.TabIndex = 10
        Me.Bt_EliminaCodice.UseVisualStyleBackColor = True
        '
        'Bt_Duplica
        '
        Me.Bt_Duplica.FlatAppearance.BorderSize = 0
        Me.Bt_Duplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Duplica.Image = CType(resources.GetObject("Bt_Duplica.Image"), System.Drawing.Image)
        Me.Bt_Duplica.Location = New System.Drawing.Point(3, 1)
        Me.Bt_Duplica.Name = "Bt_Duplica"
        Me.Bt_Duplica.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Duplica.TabIndex = 9
        Me.Bt_Duplica.UseVisualStyleBackColor = True
        '
        'ImballiIndiciBindingSource1
        '
        Me.ImballiIndiciBindingSource1.DataMember = "Imballi_Indici"
        Me.ImballiIndiciBindingSource1.DataSource = Me.ImballiBindingSource
        '
        'Form_ModificaImballo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(885, 576)
        Me.Controls.Add(Me.PanelButtons)
        Me.Controls.Add(Me.PanelModifica)
        Me.Controls.Add(Me.PanelCodice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Form_ModificaImballo"
        Me.Text = "Form_ModificaImballo"
        CType(Me.ImballiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModPackDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCodice.ResumeLayout(False)
        Me.PanelCodice.PerformLayout()
        CType(Me.ImballiIndiciBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PbImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGWDistinta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImballiDistintaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelModifica.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.DgwIndici, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImballiIndiciBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelButtons.ResumeLayout(False)
        CType(Me.ImballiIndiciBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ModPackDBDataSet As ModPackDBDataSet
    Friend WithEvents ImballiBindingSource As BindingSource
    Friend WithEvents ImballiTableAdapter As ModPackDBDataSetTableAdapters.ImballiTableAdapter
    Friend WithEvents PanelCodice As Panel
    Friend WithEvents Bt_StartEdit As Button
    Friend WithEvents ImballiIndiciBindingSource As BindingSource
    Friend WithEvents IndiciTableAdapter As ModPackDBDataSetTableAdapters.IndiciTableAdapter
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtTipoRivestimento As TextBox
    Friend WithEvents txtZoccoli As TextBox
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents txtH As TextBox
    Friend WithEvents txtP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ckRivestimento As CheckBox
    Friend WithEvents ckHT As CheckBox
    Friend WithEvents ckDT As CheckBox
    Friend WithEvents ckBM As CheckBox
    Friend WithEvents ckDiagonali As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtL As TextBox
    Friend WithEvents txtGradiF As TextBox
    Friend WithEvents txtGradiT As TextBox
    Friend WithEvents txtPrimoMorale As TextBox
    Friend WithEvents txtM2 As TextBox
    Friend WithEvents txtM3 As TextBox
    Friend WithEvents txtPrezzo As TextBox
    Friend WithEvents Bt_LoadImage As Button
    Friend WithEvents PbImg As PictureBox
    Friend WithEvents DGWDistinta As DataGridView
    Friend WithEvents ImballiDistintaBindingSource As BindingSource
    Friend WithEvents DistintaTableAdapter As ModPackDBDataSetTableAdapters.DistintaTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImballoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RigaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PartDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents XDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TagDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Bt_Salva As Button
    Friend WithEvents PanelModifica As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Bt_Cancel As Button
    Friend WithEvents PanelButtons As Panel
    Friend WithEvents DgwIndici As DataGridView
    Friend WithEvents Bt_NoImg As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtSottoMF As TextBox
    Friend WithEvents TxtSopraMF As TextBox
    Friend WithEvents TxtSottoMT As TextBox
    Friend WithEvents TxtSopraMT As TextBox
    Friend WithEvents Bt_EliminaCodice As Button
    Friend WithEvents Bt_Duplica As Button
    Friend WithEvents Bt_SpostaIndice As Button
    Friend WithEvents CbImballo As ComboBox
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ImballoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IndiceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodiceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RivestTotDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoteBICDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImballiIndiciBindingSource2 As BindingSource
    Friend WithEvents ImballiIndiciBindingSource1 As BindingSource
    Friend WithEvents Bt_AddIndice As Button
    Friend WithEvents Bt_EliminaIndice As Button
    Friend WithEvents Tool As ToolTip
End Class
