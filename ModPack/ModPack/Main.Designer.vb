﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.DGW_Memo = New System.Windows.Forms.DataGridView()
        Me.Memo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notify = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.OrdiniTree = New System.Windows.Forms.TreeView()
        Me.ImmaginiTree = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TS_Ordini = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TS_CaricaOrdine = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_OrdiniAperti = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_StoricoOrdini = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASSOCIACOORDINEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_Imballi = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TS_Archivio = New System.Windows.Forms.ToolStripMenuItem()
        Me.INIZIOPRODUZIONEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CREAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MANUALEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CREAZIONEAUTOMATICAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LISTAIMBALLINUOVIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_Tools = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TS_ControlloOrdine = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODIFICAORDINEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_Listino = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODIFICACODICEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_ListaDiagonali = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_ListaMorali = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_Tabelle = New System.Windows.Forms.ToolStripButton()
        Me.Ts_Preferenze = New System.Windows.Forms.ToolStripButton()
        Me.TS_Memo = New System.Windows.Forms.ToolStripButton()
        Me.TS_Stampe = New System.Windows.Forms.ToolStripDropDownButton()
        Me.STAMPABINDELLOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STAMPACOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSBT_Dev = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Print_Distinta = New System.Drawing.Printing.PrintDocument()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BT_RefreshTree = New System.Windows.Forms.Button()
        Me.GDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DGW_Memo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStrip, Me.ProgressBar})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 460)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(839, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStrip
        '
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(0, 17)
        '
        'ProgressBar
        '
        Me.ProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(100, 16)
        Me.ProgressBar.Visible = False
        '
        'Calendario
        '
        Me.Calendario.Location = New System.Drawing.Point(3, 39)
        Me.Calendario.Name = "Calendario"
        Me.Calendario.ShowWeekNumbers = True
        Me.Calendario.TabIndex = 8
        '
        'DGW_Memo
        '
        Me.DGW_Memo.AllowUserToAddRows = False
        Me.DGW_Memo.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent
        Me.DGW_Memo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGW_Memo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DGW_Memo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGW_Memo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGW_Memo.BackgroundColor = System.Drawing.Color.White
        Me.DGW_Memo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_Memo.ColumnHeadersVisible = False
        Me.DGW_Memo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Memo})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGW_Memo.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGW_Memo.Location = New System.Drawing.Point(3, 203)
        Me.DGW_Memo.Name = "DGW_Memo"
        Me.DGW_Memo.ReadOnly = True
        Me.DGW_Memo.RowHeadersVisible = False
        Me.DGW_Memo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGW_Memo.Size = New System.Drawing.Size(249, 254)
        Me.DGW_Memo.TabIndex = 11
        '
        'Memo
        '
        Me.Memo.HeaderText = "Memo"
        Me.Memo.Name = "Memo"
        Me.Memo.ReadOnly = True
        '
        'Notify
        '
        Me.Notify.Icon = CType(resources.GetObject("Notify.Icon"), System.Drawing.Icon)
        Me.Notify.Text = "ModPack"
        Me.Notify.Visible = True
        '
        'OrdiniTree
        '
        Me.OrdiniTree.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrdiniTree.BackColor = System.Drawing.Color.White
        Me.OrdiniTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OrdiniTree.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrdiniTree.ImageIndex = 0
        Me.OrdiniTree.ImageList = Me.ImmaginiTree
        Me.OrdiniTree.Indent = 30
        Me.OrdiniTree.ItemHeight = 20
        Me.OrdiniTree.LineColor = System.Drawing.Color.DarkGray
        Me.OrdiniTree.Location = New System.Drawing.Point(255, 39)
        Me.OrdiniTree.Name = "OrdiniTree"
        Me.OrdiniTree.SelectedImageIndex = 0
        Me.OrdiniTree.ShowLines = False
        Me.OrdiniTree.ShowPlusMinus = False
        Me.OrdiniTree.ShowRootLines = False
        Me.OrdiniTree.Size = New System.Drawing.Size(580, 418)
        Me.OrdiniTree.TabIndex = 12
        '
        'ImmaginiTree
        '
        Me.ImmaginiTree.ImageStream = CType(resources.GetObject("ImmaginiTree.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImmaginiTree.TransparentColor = System.Drawing.Color.Transparent
        Me.ImmaginiTree.Images.SetKeyName(0, "002-job-search.png")
        Me.ImmaginiTree.Images.SetKeyName(1, "more.png")
        Me.ImmaginiTree.Images.SetKeyName(2, "001-gears.png")
        Me.ImmaginiTree.Images.SetKeyName(3, "003-checked.png")
        Me.ImmaginiTree.Images.SetKeyName(4, "star.png")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(10, 10)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_Ordini, Me.TS_Imballi, Me.TS_Tools, Me.TS_Tabelle, Me.Ts_Preferenze, Me.TS_Memo, Me.TS_Stampe, Me.TSBT_Dev})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(839, 36)
        Me.ToolStrip1.TabIndex = 14
        Me.ToolStrip1.Text = "ToolStrip"
        '
        'TS_Ordini
        '
        Me.TS_Ordini.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_CaricaOrdine, Me.TS_OrdiniAperti, Me.TS_StoricoOrdini, Me.ASSOCIACOORDINEToolStripMenuItem})
        Me.TS_Ordini.Image = CType(resources.GetObject("TS_Ordini.Image"), System.Drawing.Image)
        Me.TS_Ordini.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TS_Ordini.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TS_Ordini.Name = "TS_Ordini"
        Me.TS_Ordini.Size = New System.Drawing.Size(83, 33)
        Me.TS_Ordini.Text = "ORDINI"
        '
        'TS_CaricaOrdine
        '
        Me.TS_CaricaOrdine.Name = "TS_CaricaOrdine"
        Me.TS_CaricaOrdine.Size = New System.Drawing.Size(195, 22)
        Me.TS_CaricaOrdine.Text = "CARICA ORDINE"
        '
        'TS_OrdiniAperti
        '
        Me.TS_OrdiniAperti.Name = "TS_OrdiniAperti"
        Me.TS_OrdiniAperti.Size = New System.Drawing.Size(195, 22)
        Me.TS_OrdiniAperti.Text = "ORDINI APERTI"
        '
        'TS_StoricoOrdini
        '
        Me.TS_StoricoOrdini.Name = "TS_StoricoOrdini"
        Me.TS_StoricoOrdini.Size = New System.Drawing.Size(195, 22)
        Me.TS_StoricoOrdini.Text = "STORICO"
        '
        'ASSOCIACOORDINEToolStripMenuItem
        '
        Me.ASSOCIACOORDINEToolStripMenuItem.Name = "ASSOCIACOORDINEToolStripMenuItem"
        Me.ASSOCIACOORDINEToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ASSOCIACOORDINEToolStripMenuItem.Text = "ASSOCIA CO - ORDINE"
        '
        'TS_Imballi
        '
        Me.TS_Imballi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_Archivio, Me.INIZIOPRODUZIONEToolStripMenuItem, Me.CREAToolStripMenuItem, Me.LISTAIMBALLINUOVIToolStripMenuItem})
        Me.TS_Imballi.Image = CType(resources.GetObject("TS_Imballi.Image"), System.Drawing.Image)
        Me.TS_Imballi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TS_Imballi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TS_Imballi.Name = "TS_Imballi"
        Me.TS_Imballi.Size = New System.Drawing.Size(88, 33)
        Me.TS_Imballi.Text = "IMBALLI"
        '
        'TS_Archivio
        '
        Me.TS_Archivio.Name = "TS_Archivio"
        Me.TS_Archivio.Size = New System.Drawing.Size(189, 22)
        Me.TS_Archivio.Text = "ARCHIVIO"
        '
        'INIZIOPRODUZIONEToolStripMenuItem
        '
        Me.INIZIOPRODUZIONEToolStripMenuItem.Name = "INIZIOPRODUZIONEToolStripMenuItem"
        Me.INIZIOPRODUZIONEToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.INIZIOPRODUZIONEToolStripMenuItem.Text = "INIZIO PRODUZIONE"
        '
        'CREAToolStripMenuItem
        '
        Me.CREAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MANUALEToolStripMenuItem, Me.CREAZIONEAUTOMATICAToolStripMenuItem})
        Me.CREAToolStripMenuItem.Name = "CREAToolStripMenuItem"
        Me.CREAToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.CREAToolStripMenuItem.Text = "CREA"
        '
        'MANUALEToolStripMenuItem
        '
        Me.MANUALEToolStripMenuItem.Name = "MANUALEToolStripMenuItem"
        Me.MANUALEToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.MANUALEToolStripMenuItem.Text = "CREAZIONE MANUALE"
        '
        'CREAZIONEAUTOMATICAToolStripMenuItem
        '
        Me.CREAZIONEAUTOMATICAToolStripMenuItem.Name = "CREAZIONEAUTOMATICAToolStripMenuItem"
        Me.CREAZIONEAUTOMATICAToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.CREAZIONEAUTOMATICAToolStripMenuItem.Text = "CREAZIONE AUTOMATICA"
        '
        'LISTAIMBALLINUOVIToolStripMenuItem
        '
        Me.LISTAIMBALLINUOVIToolStripMenuItem.Name = "LISTAIMBALLINUOVIToolStripMenuItem"
        Me.LISTAIMBALLINUOVIToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.LISTAIMBALLINUOVIToolStripMenuItem.Text = "LISTA IMBALLI NUOVI"
        '
        'TS_Tools
        '
        Me.TS_Tools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_ControlloOrdine, Me.MODIFICAORDINEToolStripMenuItem, Me.TS_Listino, Me.MODIFICACODICEToolStripMenuItem, Me.TS_ListaDiagonali, Me.TS_ListaMorali})
        Me.TS_Tools.Image = CType(resources.GetObject("TS_Tools.Image"), System.Drawing.Image)
        Me.TS_Tools.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TS_Tools.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TS_Tools.Name = "TS_Tools"
        Me.TS_Tools.Size = New System.Drawing.Size(80, 33)
        Me.TS_Tools.Text = "TOOLS"
        '
        'TS_ControlloOrdine
        '
        Me.TS_ControlloOrdine.Name = "TS_ControlloOrdine"
        Me.TS_ControlloOrdine.Size = New System.Drawing.Size(243, 22)
        Me.TS_ControlloOrdine.Text = "CONTROLLO ORDINE_Nascosto"
        Me.TS_ControlloOrdine.Visible = False
        '
        'MODIFICAORDINEToolStripMenuItem
        '
        Me.MODIFICAORDINEToolStripMenuItem.Name = "MODIFICAORDINEToolStripMenuItem"
        Me.MODIFICAORDINEToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.MODIFICAORDINEToolStripMenuItem.Text = "MODIFICA ORDINE"
        '
        'TS_Listino
        '
        Me.TS_Listino.Name = "TS_Listino"
        Me.TS_Listino.Size = New System.Drawing.Size(243, 22)
        Me.TS_Listino.Text = "LISTINO"
        '
        'MODIFICACODICEToolStripMenuItem
        '
        Me.MODIFICACODICEToolStripMenuItem.Name = "MODIFICACODICEToolStripMenuItem"
        Me.MODIFICACODICEToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.MODIFICACODICEToolStripMenuItem.Text = "MODIFICA CODICE"
        '
        'TS_ListaDiagonali
        '
        Me.TS_ListaDiagonali.Name = "TS_ListaDiagonali"
        Me.TS_ListaDiagonali.Size = New System.Drawing.Size(243, 22)
        Me.TS_ListaDiagonali.Text = "LISTA DIAGONALI"
        '
        'TS_ListaMorali
        '
        Me.TS_ListaMorali.Name = "TS_ListaMorali"
        Me.TS_ListaMorali.Size = New System.Drawing.Size(243, 22)
        Me.TS_ListaMorali.Text = "LISTA MORALI"
        '
        'TS_Tabelle
        '
        Me.TS_Tabelle.Image = CType(resources.GetObject("TS_Tabelle.Image"), System.Drawing.Image)
        Me.TS_Tabelle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TS_Tabelle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TS_Tabelle.Name = "TS_Tabelle"
        Me.TS_Tabelle.Size = New System.Drawing.Size(80, 33)
        Me.TS_Tabelle.Text = "TABELLE"
        '
        'Ts_Preferenze
        '
        Me.Ts_Preferenze.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Ts_Preferenze.Image = CType(resources.GetObject("Ts_Preferenze.Image"), System.Drawing.Image)
        Me.Ts_Preferenze.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Ts_Preferenze.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Ts_Preferenze.Name = "Ts_Preferenze"
        Me.Ts_Preferenze.Size = New System.Drawing.Size(82, 33)
        Me.Ts_Preferenze.Text = "OPZIONI"
        Me.Ts_Preferenze.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'TS_Memo
        '
        Me.TS_Memo.Image = CType(resources.GetObject("TS_Memo.Image"), System.Drawing.Image)
        Me.TS_Memo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TS_Memo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TS_Memo.Name = "TS_Memo"
        Me.TS_Memo.Size = New System.Drawing.Size(72, 33)
        Me.TS_Memo.Text = "MEMO"
        '
        'TS_Stampe
        '
        Me.TS_Stampe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STAMPABINDELLOToolStripMenuItem, Me.STAMPACOToolStripMenuItem})
        Me.TS_Stampe.Image = CType(resources.GetObject("TS_Stampe.Image"), System.Drawing.Image)
        Me.TS_Stampe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TS_Stampe.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TS_Stampe.Name = "TS_Stampe"
        Me.TS_Stampe.Size = New System.Drawing.Size(88, 33)
        Me.TS_Stampe.Text = "STAMPE"
        '
        'STAMPABINDELLOToolStripMenuItem
        '
        Me.STAMPABINDELLOToolStripMenuItem.Name = "STAMPABINDELLOToolStripMenuItem"
        Me.STAMPABINDELLOToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.STAMPABINDELLOToolStripMenuItem.Text = "STAMPA BINDELLO"
        '
        'STAMPACOToolStripMenuItem
        '
        Me.STAMPACOToolStripMenuItem.Name = "STAMPACOToolStripMenuItem"
        Me.STAMPACOToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.STAMPACOToolStripMenuItem.Text = "STAMPA CONFERMA ORDINE"
        '
        'TSBT_Dev
        '
        Me.TSBT_Dev.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GDAToolStripMenuItem})
        Me.TSBT_Dev.Image = CType(resources.GetObject("TSBT_Dev.Image"), System.Drawing.Image)
        Me.TSBT_Dev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBT_Dev.Name = "TSBT_Dev"
        Me.TSBT_Dev.Size = New System.Drawing.Size(51, 33)
        Me.TSBT_Dev.Text = "DEV"
        '
        'Print_Distinta
        '
        '
        'BT_RefreshTree
        '
        Me.BT_RefreshTree.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_RefreshTree.BackColor = System.Drawing.Color.White
        Me.BT_RefreshTree.BackgroundImage = CType(resources.GetObject("BT_RefreshTree.BackgroundImage"), System.Drawing.Image)
        Me.BT_RefreshTree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_RefreshTree.FlatAppearance.BorderSize = 0
        Me.BT_RefreshTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_RefreshTree.Location = New System.Drawing.Point(815, 41)
        Me.BT_RefreshTree.Name = "BT_RefreshTree"
        Me.BT_RefreshTree.Size = New System.Drawing.Size(18, 18)
        Me.BT_RefreshTree.TabIndex = 15
        Me.BT_RefreshTree.UseVisualStyleBackColor = False
        '
        'GDAToolStripMenuItem
        '
        Me.GDAToolStripMenuItem.Name = "GDAToolStripMenuItem"
        Me.GDAToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GDAToolStripMenuItem.Text = "GDA"
        '
        'Main
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(839, 482)
        Me.Controls.Add(Me.BT_RefreshTree)
        Me.Controls.Add(Me.OrdiniTree)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Calendario)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DGW_Memo)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(588, 521)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModPack"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DGW_Memo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStrip As ToolStripStatusLabel
    Friend WithEvents ProgressBar As ToolStripProgressBar
    Friend WithEvents Calendario As MonthCalendar
    Friend WithEvents DGW_Memo As DataGridView
    Friend WithEvents Memo As DataGridViewTextBoxColumn
    Friend WithEvents Notify As NotifyIcon
    Friend WithEvents OrdiniTree As TreeView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TS_Ordini As ToolStripDropDownButton
    Friend WithEvents TS_CaricaOrdine As ToolStripMenuItem
    Friend WithEvents TS_StoricoOrdini As ToolStripMenuItem
    Friend WithEvents TS_Tabelle As ToolStripButton
    Friend WithEvents Ts_Preferenze As ToolStripButton
    Friend WithEvents TS_Memo As ToolStripButton
    Friend WithEvents TS_Tools As ToolStripDropDownButton
    Friend WithEvents TS_ControlloOrdine As ToolStripMenuItem
    Friend WithEvents TS_Imballi As ToolStripDropDownButton
    Friend WithEvents TS_Archivio As ToolStripMenuItem
    Friend WithEvents TS_Listino As ToolStripMenuItem
    Friend WithEvents ImmaginiTree As ImageList
    Friend WithEvents Print_Distinta As Printing.PrintDocument
    Friend WithEvents BT_RefreshTree As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents INIZIOPRODUZIONEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MODIFICAORDINEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CREAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MANUALEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CREAZIONEAUTOMATICAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MODIFICACODICEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TS_ListaDiagonali As ToolStripMenuItem
    Friend WithEvents TS_ListaMorali As ToolStripMenuItem
    Friend WithEvents TS_OrdiniAperti As ToolStripMenuItem
    Friend WithEvents TS_Stampe As ToolStripDropDownButton
    Friend WithEvents STAMPABINDELLOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents STAMPACOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LISTAIMBALLINUOVIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ASSOCIACOORDINEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSBT_Dev As ToolStripDropDownButton
    Friend WithEvents GDAToolStripMenuItem As ToolStripMenuItem
End Class
