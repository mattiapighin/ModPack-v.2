<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_OrdiniAperti
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_OrdiniAperti))
        Me.DGW_OrdiniAperti = New System.Windows.Forms.DataGridView()
        Me.Dgw_Ordine = New System.Windows.Forms.DataGridView()
        Me.Bt_Disegni = New System.Windows.Forms.Button()
        Me.Bt_Etichette = New System.Windows.Forms.Button()
        Me.Bt_ConfermaOrdine = New System.Windows.Forms.Button()
        Me.Print_ConfermaOrdine = New System.Drawing.Printing.PrintDocument()
        Me.Print_Etichette = New System.Drawing.Printing.PrintDocument()
        Me.Bt_Evaso = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Bt_SeeAll = New System.Windows.Forms.Button()
        Me.Bt_CheckList = New System.Windows.Forms.Button()
        Me.Bt_ListaRivestimenti = New System.Windows.Forms.Button()
        Me.Bt_QrCodes = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Lbl_Ordine = New System.Windows.Forms.Label()
        Me.Print_CheckList = New System.Drawing.Printing.PrintDocument()
        Me.Print_Distinte = New System.Drawing.Printing.PrintDocument()
        Me.Print_Morali = New System.Drawing.Printing.PrintDocument()
        Me.Print_QR = New System.Drawing.Printing.PrintDocument()
        Me.SStrip = New System.Windows.Forms.StatusStrip()
        Me.TX_Ss = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.DGW_OrdiniAperti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgw_Ordine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGW_OrdiniAperti
        '
        Me.DGW_OrdiniAperti.AllowUserToAddRows = False
        Me.DGW_OrdiniAperti.AllowUserToDeleteRows = False
        Me.DGW_OrdiniAperti.AllowUserToResizeColumns = False
        Me.DGW_OrdiniAperti.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DGW_OrdiniAperti.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGW_OrdiniAperti.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DGW_OrdiniAperti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGW_OrdiniAperti.BackgroundColor = System.Drawing.Color.White
        Me.DGW_OrdiniAperti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_OrdiniAperti.ColumnHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGW_OrdiniAperti.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGW_OrdiniAperti.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DGW_OrdiniAperti.Location = New System.Drawing.Point(12, 12)
        Me.DGW_OrdiniAperti.MultiSelect = False
        Me.DGW_OrdiniAperti.Name = "DGW_OrdiniAperti"
        Me.DGW_OrdiniAperti.ReadOnly = True
        Me.DGW_OrdiniAperti.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DGW_OrdiniAperti.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGW_OrdiniAperti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGW_OrdiniAperti.Size = New System.Drawing.Size(202, 519)
        Me.DGW_OrdiniAperti.TabIndex = 0
        '
        'Dgw_Ordine
        '
        Me.Dgw_Ordine.AllowUserToAddRows = False
        Me.Dgw_Ordine.AllowUserToDeleteRows = False
        Me.Dgw_Ordine.AllowUserToResizeColumns = False
        Me.Dgw_Ordine.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.Dgw_Ordine.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Dgw_Ordine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgw_Ordine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgw_Ordine.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgw_Ordine.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Dgw_Ordine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgw_Ordine.DefaultCellStyle = DataGridViewCellStyle6
        Me.Dgw_Ordine.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.Dgw_Ordine.Location = New System.Drawing.Point(220, 41)
        Me.Dgw_Ordine.Name = "Dgw_Ordine"
        Me.Dgw_Ordine.ReadOnly = True
        Me.Dgw_Ordine.RowHeadersVisible = False
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.Dgw_Ordine.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.Dgw_Ordine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgw_Ordine.Size = New System.Drawing.Size(809, 490)
        Me.Dgw_Ordine.TabIndex = 0
        '
        'Bt_Disegni
        '
        Me.Bt_Disegni.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Disegni.FlatAppearance.BorderSize = 0
        Me.Bt_Disegni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Disegni.Image = CType(resources.GetObject("Bt_Disegni.Image"), System.Drawing.Image)
        Me.Bt_Disegni.Location = New System.Drawing.Point(3, 411)
        Me.Bt_Disegni.Name = "Bt_Disegni"
        Me.Bt_Disegni.Size = New System.Drawing.Size(44, 45)
        Me.Bt_Disegni.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.Bt_Disegni, "Stampa distinte (ctrl+click per stampare singola distinta)")
        Me.Bt_Disegni.UseVisualStyleBackColor = True
        '
        'Bt_Etichette
        '
        Me.Bt_Etichette.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Etichette.FlatAppearance.BorderSize = 0
        Me.Bt_Etichette.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Etichette.Image = CType(resources.GetObject("Bt_Etichette.Image"), System.Drawing.Image)
        Me.Bt_Etichette.Location = New System.Drawing.Point(3, 360)
        Me.Bt_Etichette.Name = "Bt_Etichette"
        Me.Bt_Etichette.Size = New System.Drawing.Size(44, 45)
        Me.Bt_Etichette.TabIndex = 4
        Me.ToolTip.SetToolTip(Me.Bt_Etichette, "Stampa etichette (ctrl+click per stampare singola etichetta)")
        Me.Bt_Etichette.UseVisualStyleBackColor = True
        '
        'Bt_ConfermaOrdine
        '
        Me.Bt_ConfermaOrdine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_ConfermaOrdine.FlatAppearance.BorderSize = 0
        Me.Bt_ConfermaOrdine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_ConfermaOrdine.Image = CType(resources.GetObject("Bt_ConfermaOrdine.Image"), System.Drawing.Image)
        Me.Bt_ConfermaOrdine.Location = New System.Drawing.Point(3, 462)
        Me.Bt_ConfermaOrdine.Name = "Bt_ConfermaOrdine"
        Me.Bt_ConfermaOrdine.Size = New System.Drawing.Size(44, 52)
        Me.Bt_ConfermaOrdine.TabIndex = 5
        Me.ToolTip.SetToolTip(Me.Bt_ConfermaOrdine, "Stampa conferma d'ordine")
        Me.Bt_ConfermaOrdine.UseVisualStyleBackColor = True
        '
        'Print_ConfermaOrdine
        '
        '
        'Print_Etichette
        '
        '
        'Bt_Evaso
        '
        Me.Bt_Evaso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Evaso.FlatAppearance.BorderSize = 0
        Me.Bt_Evaso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Evaso.Image = CType(resources.GetObject("Bt_Evaso.Image"), System.Drawing.Image)
        Me.Bt_Evaso.Location = New System.Drawing.Point(3, 3)
        Me.Bt_Evaso.Name = "Bt_Evaso"
        Me.Bt_Evaso.Size = New System.Drawing.Size(44, 45)
        Me.Bt_Evaso.TabIndex = 7
        Me.ToolTip.SetToolTip(Me.Bt_Evaso, "Segna come EVASO (ctrl+click per annullare)")
        Me.Bt_Evaso.UseVisualStyleBackColor = True
        '
        'ToolTip
        '
        Me.ToolTip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'Bt_SeeAll
        '
        Me.Bt_SeeAll.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_SeeAll.FlatAppearance.BorderSize = 0
        Me.Bt_SeeAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_SeeAll.Image = CType(resources.GetObject("Bt_SeeAll.Image"), System.Drawing.Image)
        Me.Bt_SeeAll.Location = New System.Drawing.Point(3, 105)
        Me.Bt_SeeAll.Name = "Bt_SeeAll"
        Me.Bt_SeeAll.Size = New System.Drawing.Size(44, 45)
        Me.Bt_SeeAll.TabIndex = 8
        Me.ToolTip.SetToolTip(Me.Bt_SeeAll, "Vedi tutti gli imballi da evadere")
        Me.Bt_SeeAll.UseVisualStyleBackColor = True
        '
        'Bt_CheckList
        '
        Me.Bt_CheckList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_CheckList.FlatAppearance.BorderSize = 0
        Me.Bt_CheckList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_CheckList.Image = CType(resources.GetObject("Bt_CheckList.Image"), System.Drawing.Image)
        Me.Bt_CheckList.Location = New System.Drawing.Point(3, 309)
        Me.Bt_CheckList.Name = "Bt_CheckList"
        Me.Bt_CheckList.Size = New System.Drawing.Size(44, 45)
        Me.Bt_CheckList.TabIndex = 9
        Me.ToolTip.SetToolTip(Me.Bt_CheckList, "Stampa lista di controllo")
        Me.Bt_CheckList.UseVisualStyleBackColor = True
        '
        'Bt_ListaRivestimenti
        '
        Me.Bt_ListaRivestimenti.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_ListaRivestimenti.FlatAppearance.BorderSize = 0
        Me.Bt_ListaRivestimenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_ListaRivestimenti.Image = CType(resources.GetObject("Bt_ListaRivestimenti.Image"), System.Drawing.Image)
        Me.Bt_ListaRivestimenti.Location = New System.Drawing.Point(3, 207)
        Me.Bt_ListaRivestimenti.Name = "Bt_ListaRivestimenti"
        Me.Bt_ListaRivestimenti.Size = New System.Drawing.Size(44, 45)
        Me.Bt_ListaRivestimenti.TabIndex = 10
        Me.ToolTip.SetToolTip(Me.Bt_ListaRivestimenti, "Invia lista rivestimenti")
        Me.Bt_ListaRivestimenti.UseVisualStyleBackColor = True
        '
        'Bt_QrCodes
        '
        Me.Bt_QrCodes.FlatAppearance.BorderSize = 0
        Me.Bt_QrCodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_QrCodes.Image = CType(resources.GetObject("Bt_QrCodes.Image"), System.Drawing.Image)
        Me.Bt_QrCodes.Location = New System.Drawing.Point(3, 258)
        Me.Bt_QrCodes.Name = "Bt_QrCodes"
        Me.Bt_QrCodes.Size = New System.Drawing.Size(44, 45)
        Me.Bt_QrCodes.TabIndex = 11
        Me.ToolTip.SetToolTip(Me.Bt_QrCodes, "Stampa QR Codes")
        Me.Bt_QrCodes.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Location = New System.Drawing.Point(1038, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(52, 519)
        Me.Panel1.TabIndex = 8
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Bt_ListaRivestimenti, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Bt_Evaso, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Bt_SeeAll, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Bt_ConfermaOrdine, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Bt_Disegni, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Bt_Etichette, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Bt_CheckList, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Bt_QrCodes, 0, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(50, 517)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'Lbl_Ordine
        '
        Me.Lbl_Ordine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Ordine.BackColor = System.Drawing.Color.PeachPuff
        Me.Lbl_Ordine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Ordine.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Ordine.Location = New System.Drawing.Point(220, 12)
        Me.Lbl_Ordine.Name = "Lbl_Ordine"
        Me.Lbl_Ordine.Size = New System.Drawing.Size(809, 23)
        Me.Lbl_Ordine.TabIndex = 9
        Me.Lbl_Ordine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Print_CheckList
        '
        '
        'Print_Distinte
        '
        '
        'Print_QR
        '
        '
        'SStrip
        '
        Me.SStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TX_Ss})
        Me.SStrip.Location = New System.Drawing.Point(0, 538)
        Me.SStrip.Name = "SStrip"
        Me.SStrip.Size = New System.Drawing.Size(1099, 22)
        Me.SStrip.SizingGrip = False
        Me.SStrip.Stretch = False
        Me.SStrip.TabIndex = 10
        '
        'TX_Ss
        '
        Me.TX_Ss.BackColor = System.Drawing.Color.Transparent
        Me.TX_Ss.Name = "TX_Ss"
        Me.TX_Ss.Size = New System.Drawing.Size(0, 17)
        '
        'Form_OrdiniAperti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(1099, 560)
        Me.Controls.Add(Me.SStrip)
        Me.Controls.Add(Me.Lbl_Ordine)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Dgw_Ordine)
        Me.Controls.Add(Me.DGW_OrdiniAperti)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(300, 550)
        Me.Name = "Form_OrdiniAperti"
        Me.Text = "Ordini Aperti"
        CType(Me.DGW_OrdiniAperti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgw_Ordine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.SStrip.ResumeLayout(False)
        Me.SStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGW_OrdiniAperti As DataGridView
    Friend WithEvents Dgw_Ordine As DataGridView
    Friend WithEvents Bt_Disegni As Button
    Friend WithEvents Bt_Etichette As Button
    Friend WithEvents Bt_ConfermaOrdine As Button
    Friend WithEvents Print_ConfermaOrdine As Printing.PrintDocument
    Friend WithEvents Print_Etichette As Printing.PrintDocument
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents Bt_Evaso As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Bt_SeeAll As Button
    Friend WithEvents Lbl_Ordine As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Bt_CheckList As Button
    Friend WithEvents Print_CheckList As Printing.PrintDocument
    Friend WithEvents Print_Distinte As Printing.PrintDocument
    Friend WithEvents Bt_ListaRivestimenti As Button
    Friend WithEvents Print_Morali As Printing.PrintDocument
    Friend WithEvents Bt_QrCodes As Button
    Friend WithEvents Print_QR As Printing.PrintDocument
    Friend WithEvents SStrip As StatusStrip
    Friend WithEvents TX_Ss As ToolStripStatusLabel
End Class
