<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Archivio_V2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Archivio_V2))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Txt_Code = New System.Windows.Forms.ToolStripTextBox()
        Me.BT_SearchCode = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BT_Filtro = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CB_NElementi = New System.Windows.Forms.ToolStripComboBox()
        Me.BT_ModificaImballo = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DG_Archivio = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Imballo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.L = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.H = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rivestimento = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Data_Creazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TX_Note = New System.Windows.Forms.TextBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.Bt_SalvaNote = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DG_InfoOrdini = New System.Windows.Forms.DataGridView()
        Me.Ordini_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ordini_Codice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ordini_Commessa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ordini_QT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ordini_Evaso = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Ordine_Consegna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CK_Diagonali = New System.Windows.Forms.CheckBox()
        Me.CK_HT = New System.Windows.Forms.CheckBox()
        Me.CK_DT = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CK_BM = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LB_Tipo = New System.Windows.Forms.Label()
        Me.LB_Zoccoli = New System.Windows.Forms.Label()
        Me.LB_Rivestimento = New System.Windows.Forms.Label()
        Me.LB_M2 = New System.Windows.Forms.Label()
        Me.LB_M3 = New System.Windows.Forms.Label()
        Me.LB_Prezzo = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LST_Codici = New System.Windows.Forms.ListBox()
        Me.PB_Img = New System.Windows.Forms.PictureBox()
        Me.ToolTipDGOrdini = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DG_Archivio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_InfoOrdini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PB_Img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Txt_Code, Me.BT_SearchCode, Me.ToolStripSeparator1, Me.BT_Filtro, Me.toolStripSeparator, Me.CB_NElementi, Me.BT_ModificaImballo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1034, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Txt_Code
        '
        Me.Txt_Code.Name = "Txt_Code"
        Me.Txt_Code.Size = New System.Drawing.Size(100, 25)
        '
        'BT_SearchCode
        '
        Me.BT_SearchCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_SearchCode.Image = CType(resources.GetObject("BT_SearchCode.Image"), System.Drawing.Image)
        Me.BT_SearchCode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_SearchCode.Name = "BT_SearchCode"
        Me.BT_SearchCode.Size = New System.Drawing.Size(23, 22)
        Me.BT_SearchCode.Text = "Cerca"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BT_Filtro
        '
        Me.BT_Filtro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_Filtro.Image = CType(resources.GetObject("BT_Filtro.Image"), System.Drawing.Image)
        Me.BT_Filtro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_Filtro.Name = "BT_Filtro"
        Me.BT_Filtro.Size = New System.Drawing.Size(23, 22)
        Me.BT_Filtro.Text = "Filtro"
        Me.BT_Filtro.ToolTipText = "Filtro"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'CB_NElementi
        '
        Me.CB_NElementi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CB_NElementi.AutoSize = False
        Me.CB_NElementi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_NElementi.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.CB_NElementi.Items.AddRange(New Object() {"10", "50", "100", "200", "500", "1000", "2000", "5000", "10000"})
        Me.CB_NElementi.Name = "CB_NElementi"
        Me.CB_NElementi.Size = New System.Drawing.Size(80, 23)
        Me.CB_NElementi.ToolTipText = "Numero di record da mostrare"
        '
        'BT_ModificaImballo
        '
        Me.BT_ModificaImballo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_ModificaImballo.Image = CType(resources.GetObject("BT_ModificaImballo.Image"), System.Drawing.Image)
        Me.BT_ModificaImballo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_ModificaImballo.Name = "BT_ModificaImballo"
        Me.BT_ModificaImballo.Size = New System.Drawing.Size(23, 22)
        Me.BT_ModificaImballo.Text = "Modifica Imballo"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.SeaShell
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DG_Archivio)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PB_Img)
        Me.SplitContainer1.Size = New System.Drawing.Size(1034, 855)
        Me.SplitContainer1.SplitterDistance = 707
        Me.SplitContainer1.TabIndex = 1
        '
        'DG_Archivio
        '
        Me.DG_Archivio.AllowUserToAddRows = False
        Me.DG_Archivio.AllowUserToDeleteRows = False
        Me.DG_Archivio.AllowUserToOrderColumns = True
        Me.DG_Archivio.AllowUserToResizeColumns = False
        Me.DG_Archivio.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DG_Archivio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Archivio.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DG_Archivio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Archivio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_Archivio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Archivio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Imballo, Me.Tipo, Me.L, Me.P, Me.H, Me.Rivestimento, Me.Data_Creazione})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_Archivio.DefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Archivio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Archivio.Location = New System.Drawing.Point(0, 0)
        Me.DG_Archivio.MultiSelect = False
        Me.DG_Archivio.Name = "DG_Archivio"
        Me.DG_Archivio.ReadOnly = True
        Me.DG_Archivio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DG_Archivio.RowHeadersVisible = False
        Me.DG_Archivio.RowHeadersWidth = 20
        Me.DG_Archivio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Archivio.Size = New System.Drawing.Size(707, 855)
        Me.DG_Archivio.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Imballo
        '
        Me.Imballo.HeaderText = "Imballo"
        Me.Imballo.Name = "Imballo"
        Me.Imballo.ReadOnly = True
        Me.Imballo.Width = 150
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 80
        '
        'L
        '
        Me.L.HeaderText = "L"
        Me.L.Name = "L"
        Me.L.ReadOnly = True
        Me.L.Width = 80
        '
        'P
        '
        Me.P.HeaderText = "P"
        Me.P.Name = "P"
        Me.P.ReadOnly = True
        Me.P.Width = 80
        '
        'H
        '
        Me.H.HeaderText = "H"
        Me.H.Name = "H"
        Me.H.ReadOnly = True
        Me.H.Width = 80
        '
        'Rivestimento
        '
        Me.Rivestimento.HeaderText = "Rivestimento"
        Me.Rivestimento.Name = "Rivestimento"
        Me.Rivestimento.ReadOnly = True
        Me.Rivestimento.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Rivestimento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Data_Creazione
        '
        Me.Data_Creazione.HeaderText = "Data Creazione"
        Me.Data_Creazione.Name = "Data_Creazione"
        Me.Data_Creazione.ReadOnly = True
        Me.Data_Creazione.Width = 110
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TX_Note)
        Me.Panel1.Controls.Add(Me.ToolStrip2)
        Me.Panel1.Location = New System.Drawing.Point(6, 650)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 202)
        Me.Panel1.TabIndex = 3
        '
        'TX_Note
        '
        Me.TX_Note.BackColor = System.Drawing.SystemColors.Info
        Me.TX_Note.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TX_Note.Location = New System.Drawing.Point(0, 25)
        Me.TX_Note.Multiline = True
        Me.TX_Note.Name = "TX_Note"
        Me.TX_Note.Size = New System.Drawing.Size(310, 175)
        Me.TX_Note.TabIndex = 1
        '
        'ToolStrip2
        '
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Bt_SalvaNote})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(310, 25)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'Bt_SalvaNote
        '
        Me.Bt_SalvaNote.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Bt_SalvaNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Bt_SalvaNote.Image = CType(resources.GetObject("Bt_SalvaNote.Image"), System.Drawing.Image)
        Me.Bt_SalvaNote.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bt_SalvaNote.Name = "Bt_SalvaNote"
        Me.Bt_SalvaNote.Size = New System.Drawing.Size(23, 22)
        Me.Bt_SalvaNote.Text = "ToolStripButton1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DG_InfoOrdini)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 516)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 131)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ultimi ordini"
        '
        'DG_InfoOrdini
        '
        Me.DG_InfoOrdini.AllowUserToAddRows = False
        Me.DG_InfoOrdini.AllowUserToDeleteRows = False
        Me.DG_InfoOrdini.AllowUserToOrderColumns = True
        Me.DG_InfoOrdini.AllowUserToResizeColumns = False
        Me.DG_InfoOrdini.AllowUserToResizeRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_InfoOrdini.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DG_InfoOrdini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_InfoOrdini.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ordini_ID, Me.Ordini_Codice, Me.Ordini_Commessa, Me.Ordini_QT, Me.Ordini_Evaso, Me.Ordine_Consegna})
        Me.DG_InfoOrdini.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_InfoOrdini.Location = New System.Drawing.Point(3, 16)
        Me.DG_InfoOrdini.Name = "DG_InfoOrdini"
        Me.DG_InfoOrdini.ReadOnly = True
        Me.DG_InfoOrdini.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DG_InfoOrdini.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DG_InfoOrdini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_InfoOrdini.Size = New System.Drawing.Size(309, 112)
        Me.DG_InfoOrdini.TabIndex = 1
        '
        'Ordini_ID
        '
        Me.Ordini_ID.HeaderText = "ID"
        Me.Ordini_ID.Name = "Ordini_ID"
        Me.Ordini_ID.ReadOnly = True
        Me.Ordini_ID.Visible = False
        '
        'Ordini_Codice
        '
        Me.Ordini_Codice.HeaderText = "Codice"
        Me.Ordini_Codice.Name = "Ordini_Codice"
        Me.Ordini_Codice.ReadOnly = True
        Me.Ordini_Codice.Visible = False
        '
        'Ordini_Commessa
        '
        Me.Ordini_Commessa.HeaderText = "Commessa"
        Me.Ordini_Commessa.Name = "Ordini_Commessa"
        Me.Ordini_Commessa.ReadOnly = True
        '
        'Ordini_QT
        '
        Me.Ordini_QT.HeaderText = "QT"
        Me.Ordini_QT.Name = "Ordini_QT"
        Me.Ordini_QT.ReadOnly = True
        Me.Ordini_QT.Width = 40
        '
        'Ordini_Evaso
        '
        Me.Ordini_Evaso.HeaderText = "Evaso"
        Me.Ordini_Evaso.Name = "Ordini_Evaso"
        Me.Ordini_Evaso.ReadOnly = True
        Me.Ordini_Evaso.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Ordini_Evaso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Ordini_Evaso.Width = 40
        '
        'Ordine_Consegna
        '
        Me.Ordine_Consegna.HeaderText = "Consegna"
        Me.Ordine_Consegna.Name = "Ordine_Consegna"
        Me.Ordine_Consegna.ReadOnly = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.SeaShell
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CK_Diagonali, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CK_HT, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CK_DT, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CK_BM, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LB_Tipo, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LB_Zoccoli, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LB_Rivestimento, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LB_M2, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LB_M3, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LB_Prezzo, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 2, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 236)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(315, 274)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TIPO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CK_Diagonali
        '
        Me.CK_Diagonali.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CK_Diagonali.AutoCheck = False
        Me.CK_Diagonali.BackColor = System.Drawing.Color.SeaShell
        Me.CK_Diagonali.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CK_Diagonali.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CK_Diagonali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CK_Diagonali.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CK_Diagonali.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CK_Diagonali.Location = New System.Drawing.Point(212, 138)
        Me.CK_Diagonali.Name = "CK_Diagonali"
        Me.CK_Diagonali.Size = New System.Drawing.Size(100, 39)
        Me.CK_Diagonali.TabIndex = 1
        Me.CK_Diagonali.Text = "CON DIAGONALI"
        Me.CK_Diagonali.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CK_Diagonali.UseVisualStyleBackColor = False
        '
        'CK_HT
        '
        Me.CK_HT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CK_HT.AutoCheck = False
        Me.CK_HT.BackColor = System.Drawing.Color.SeaShell
        Me.CK_HT.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CK_HT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CK_HT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CK_HT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CK_HT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CK_HT.Location = New System.Drawing.Point(212, 3)
        Me.CK_HT.Name = "CK_HT"
        Me.CK_HT.Size = New System.Drawing.Size(100, 39)
        Me.CK_HT.TabIndex = 1
        Me.CK_HT.Text = "HT"
        Me.CK_HT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CK_HT.UseVisualStyleBackColor = False
        '
        'CK_DT
        '
        Me.CK_DT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CK_DT.AutoCheck = False
        Me.CK_DT.BackColor = System.Drawing.Color.SeaShell
        Me.CK_DT.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CK_DT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CK_DT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CK_DT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CK_DT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CK_DT.Location = New System.Drawing.Point(212, 93)
        Me.CK_DT.Name = "CK_DT"
        Me.CK_DT.Size = New System.Drawing.Size(100, 39)
        Me.CK_DT.TabIndex = 1
        Me.CK_DT.Text = "DOPPIA TAVOLA"
        Me.CK_DT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CK_DT.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 34)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ZOCCOLI"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CK_BM
        '
        Me.CK_BM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CK_BM.AutoCheck = False
        Me.CK_BM.BackColor = System.Drawing.Color.SeaShell
        Me.CK_BM.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CK_BM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CK_BM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CK_BM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CK_BM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CK_BM.Location = New System.Drawing.Point(212, 48)
        Me.CK_BM.Name = "CK_BM"
        Me.CK_BM.Size = New System.Drawing.Size(100, 39)
        Me.CK_BM.TabIndex = 1
        Me.CK_BM.Text = "BASE MORALI"
        Me.CK_BM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CK_BM.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 34)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "RIVESTIMENTO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 34)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "M2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 34)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "M3"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 34)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "PREZZO"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LB_Tipo
        '
        Me.LB_Tipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_Tipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LB_Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Tipo.Location = New System.Drawing.Point(114, 5)
        Me.LB_Tipo.Name = "LB_Tipo"
        Me.LB_Tipo.Size = New System.Drawing.Size(92, 34)
        Me.LB_Tipo.TabIndex = 0
        Me.LB_Tipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LB_Zoccoli
        '
        Me.LB_Zoccoli.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_Zoccoli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LB_Zoccoli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Zoccoli.Location = New System.Drawing.Point(114, 50)
        Me.LB_Zoccoli.Name = "LB_Zoccoli"
        Me.LB_Zoccoli.Size = New System.Drawing.Size(92, 34)
        Me.LB_Zoccoli.TabIndex = 0
        Me.LB_Zoccoli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LB_Rivestimento
        '
        Me.LB_Rivestimento.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_Rivestimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LB_Rivestimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Rivestimento.Location = New System.Drawing.Point(114, 95)
        Me.LB_Rivestimento.Name = "LB_Rivestimento"
        Me.LB_Rivestimento.Size = New System.Drawing.Size(92, 34)
        Me.LB_Rivestimento.TabIndex = 0
        Me.LB_Rivestimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LB_M2
        '
        Me.LB_M2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_M2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LB_M2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_M2.Location = New System.Drawing.Point(114, 140)
        Me.LB_M2.Name = "LB_M2"
        Me.LB_M2.Size = New System.Drawing.Size(92, 34)
        Me.LB_M2.TabIndex = 0
        Me.LB_M2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LB_M3
        '
        Me.LB_M3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_M3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LB_M3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_M3.Location = New System.Drawing.Point(114, 185)
        Me.LB_M3.Name = "LB_M3"
        Me.LB_M3.Size = New System.Drawing.Size(92, 34)
        Me.LB_M3.TabIndex = 0
        Me.LB_M3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LB_Prezzo
        '
        Me.LB_Prezzo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_Prezzo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LB_Prezzo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Prezzo.Location = New System.Drawing.Point(114, 232)
        Me.LB_Prezzo.Name = "LB_Prezzo"
        Me.LB_Prezzo.Size = New System.Drawing.Size(92, 34)
        Me.LB_Prezzo.TabIndex = 0
        Me.LB_Prezzo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.LST_Codici)
        Me.GroupBox2.Location = New System.Drawing.Point(212, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.TableLayoutPanel1.SetRowSpan(Me.GroupBox2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(100, 88)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Codici"
        '
        'LST_Codici
        '
        Me.LST_Codici.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LST_Codici.FormattingEnabled = True
        Me.LST_Codici.Location = New System.Drawing.Point(3, 16)
        Me.LST_Codici.Name = "LST_Codici"
        Me.LST_Codici.Size = New System.Drawing.Size(94, 69)
        Me.LST_Codici.TabIndex = 0
        '
        'PB_Img
        '
        Me.PB_Img.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PB_Img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PB_Img.Location = New System.Drawing.Point(3, 3)
        Me.PB_Img.Name = "PB_Img"
        Me.PB_Img.Size = New System.Drawing.Size(315, 227)
        Me.PB_Img.TabIndex = 0
        Me.PB_Img.TabStop = False
        '
        'FRM_Archivio_V2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 880)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_Archivio_V2"
        Me.Text = "Imballi"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DG_Archivio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DG_InfoOrdini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PB_Img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents DG_Archivio As DataGridView
    Friend WithEvents PB_Img As PictureBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Imballo As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents L As DataGridViewTextBoxColumn
    Friend WithEvents P As DataGridViewTextBoxColumn
    Friend WithEvents H As DataGridViewTextBoxColumn
    Friend WithEvents Rivestimento As DataGridViewCheckBoxColumn
    Friend WithEvents Data_Creazione As DataGridViewTextBoxColumn
    Friend WithEvents CK_HT As CheckBox
    Friend WithEvents CK_Diagonali As CheckBox
    Friend WithEvents CK_DT As CheckBox
    Friend WithEvents CK_BM As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LB_Tipo As Label
    Friend WithEvents LB_Zoccoli As Label
    Friend WithEvents LB_Rivestimento As Label
    Friend WithEvents LB_M2 As Label
    Friend WithEvents LB_M3 As Label
    Friend WithEvents LB_Prezzo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DG_InfoOrdini As DataGridView
    Friend WithEvents ToolTipDGOrdini As ToolTip
    Friend WithEvents Ordini_ID As DataGridViewTextBoxColumn
    Friend WithEvents Ordini_Codice As DataGridViewTextBoxColumn
    Friend WithEvents Ordini_Commessa As DataGridViewTextBoxColumn
    Friend WithEvents Ordini_QT As DataGridViewTextBoxColumn
    Friend WithEvents Ordini_Evaso As DataGridViewCheckBoxColumn
    Friend WithEvents Ordine_Consegna As DataGridViewTextBoxColumn
    Friend WithEvents Txt_Code As ToolStripTextBox
    Friend WithEvents BT_SearchCode As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BT_Filtro As ToolStripButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LST_Codici As ListBox
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents CB_NElementi As ToolStripComboBox
    Friend WithEvents BT_ModificaImballo As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TX_Note As TextBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents Bt_SalvaNote As ToolStripButton
End Class
