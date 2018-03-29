<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LST_Diagonali
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LST_Diagonali))
        Me.DGW_Diagonali = New System.Windows.Forms.DataGridView()
        Me.Imballo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HT = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Qt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoTavoleDiagF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LunTavF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradiDiagF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtDiagF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoTavoleDiagT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LunDiagT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradiDiagT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtDiagT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDiagonali = New System.Drawing.Printing.PrintDocument()
        Me.CB_OrdiniAperti = New System.Windows.Forms.ComboBox()
        Me.Bt_Ok = New System.Windows.Forms.Button()
        Me.Bt_Stampa = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Bt_Pulisci = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LabelOrdini = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.DGW_Diagonali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGW_Diagonali
        '
        Me.DGW_Diagonali.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGW_Diagonali.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGW_Diagonali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_Diagonali.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Imballo, Me.HT, Me.Qt, Me.TipoTavoleDiagF, Me.LunTavF, Me.GradiDiagF, Me.QtDiagF, Me.TipoTavoleDiagT, Me.LunDiagT, Me.GradiDiagT, Me.QtDiagT})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGW_Diagonali.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGW_Diagonali.Location = New System.Drawing.Point(12, 67)
        Me.DGW_Diagonali.Name = "DGW_Diagonali"
        Me.DGW_Diagonali.Size = New System.Drawing.Size(1171, 291)
        Me.DGW_Diagonali.TabIndex = 0
        '
        'Imballo
        '
        Me.Imballo.HeaderText = "Imballo"
        Me.Imballo.Name = "Imballo"
        '
        'HT
        '
        Me.HT.HeaderText = "HT"
        Me.HT.Name = "HT"
        '
        'Qt
        '
        Me.Qt.HeaderText = "Qt"
        Me.Qt.Name = "Qt"
        Me.Qt.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Qt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TipoTavoleDiagF
        '
        Me.TipoTavoleDiagF.HeaderText = "Tipo Tavole Fiancate"
        Me.TipoTavoleDiagF.Name = "TipoTavoleDiagF"
        Me.TipoTavoleDiagF.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TipoTavoleDiagF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'LunTavF
        '
        Me.LunTavF.HeaderText = "Lunghezza Diagonali Fiancate"
        Me.LunTavF.Name = "LunTavF"
        Me.LunTavF.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LunTavF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'GradiDiagF
        '
        Me.GradiDiagF.HeaderText = "Gradi Diagonali Fiancate"
        Me.GradiDiagF.Name = "GradiDiagF"
        '
        'QtDiagF
        '
        Me.QtDiagF.HeaderText = "Quantità Diagonali Fiancate"
        Me.QtDiagF.Name = "QtDiagF"
        '
        'TipoTavoleDiagT
        '
        Me.TipoTavoleDiagT.HeaderText = "Tipo Tavole Teste"
        Me.TipoTavoleDiagT.Name = "TipoTavoleDiagT"
        '
        'LunDiagT
        '
        Me.LunDiagT.HeaderText = "Lunghezza Diagonali Teste"
        Me.LunDiagT.Name = "LunDiagT"
        '
        'GradiDiagT
        '
        Me.GradiDiagT.HeaderText = "Gradi Diagonali Teste"
        Me.GradiDiagT.Name = "GradiDiagT"
        '
        'QtDiagT
        '
        Me.QtDiagT.HeaderText = "Quantità Diagonali Teste"
        Me.QtDiagT.Name = "QtDiagT"
        '
        'PrintDiagonali
        '
        '
        'CB_OrdiniAperti
        '
        Me.CB_OrdiniAperti.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_OrdiniAperti.FormattingEnabled = True
        Me.CB_OrdiniAperti.Location = New System.Drawing.Point(6, 19)
        Me.CB_OrdiniAperti.Name = "CB_OrdiniAperti"
        Me.CB_OrdiniAperti.Size = New System.Drawing.Size(955, 21)
        Me.CB_OrdiniAperti.TabIndex = 1
        '
        'Bt_Ok
        '
        Me.Bt_Ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Ok.Location = New System.Drawing.Point(967, 19)
        Me.Bt_Ok.Name = "Bt_Ok"
        Me.Bt_Ok.Size = New System.Drawing.Size(75, 21)
        Me.Bt_Ok.TabIndex = 2
        Me.Bt_Ok.Text = "OK"
        Me.Bt_Ok.UseVisualStyleBackColor = True
        '
        'Bt_Stampa
        '
        Me.Bt_Stampa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Bt_Stampa.BackgroundImage = CType(resources.GetObject("Bt_Stampa.BackgroundImage"), System.Drawing.Image)
        Me.Bt_Stampa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_Stampa.FlatAppearance.BorderSize = 0
        Me.Bt_Stampa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Stampa.Location = New System.Drawing.Point(67, 4)
        Me.Bt_Stampa.Name = "Bt_Stampa"
        Me.Bt_Stampa.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Stampa.TabIndex = 3
        Me.Bt_Stampa.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.CB_OrdiniAperti)
        Me.GroupBox1.Controls.Add(Me.Bt_Ok)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1048, 49)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ordine"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Bt_Pulisci, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Bt_Stampa, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1066, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(117, 49)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'Bt_Pulisci
        '
        Me.Bt_Pulisci.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Bt_Pulisci.BackgroundImage = CType(resources.GetObject("Bt_Pulisci.BackgroundImage"), System.Drawing.Image)
        Me.Bt_Pulisci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_Pulisci.FlatAppearance.BorderSize = 0
        Me.Bt_Pulisci.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Pulisci.Location = New System.Drawing.Point(9, 4)
        Me.Bt_Pulisci.Name = "Bt_Pulisci"
        Me.Bt_Pulisci.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Pulisci.TabIndex = 4
        Me.Bt_Pulisci.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelOrdini})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 373)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1195, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LabelOrdini
        '
        Me.LabelOrdini.Name = "LabelOrdini"
        Me.LabelOrdini.Size = New System.Drawing.Size(120, 17)
        Me.LabelOrdini.Text = "ToolStripStatusLabel1"
        '
        'LST_Diagonali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1195, 395)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGW_Diagonali)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1211, 434)
        Me.Name = "LST_Diagonali"
        Me.Text = "Lista Diagonali"
        CType(Me.DGW_Diagonali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGW_Diagonali As DataGridView
    Friend WithEvents PrintDiagonali As Printing.PrintDocument
    Friend WithEvents CB_OrdiniAperti As ComboBox
    Friend WithEvents Bt_Ok As Button
    Friend WithEvents Bt_Stampa As Button
    Friend WithEvents Imballo As DataGridViewTextBoxColumn
    Friend WithEvents HT As DataGridViewCheckBoxColumn
    Friend WithEvents Qt As DataGridViewTextBoxColumn
    Friend WithEvents TipoTavoleDiagF As DataGridViewTextBoxColumn
    Friend WithEvents LunTavF As DataGridViewTextBoxColumn
    Friend WithEvents GradiDiagF As DataGridViewTextBoxColumn
    Friend WithEvents QtDiagF As DataGridViewTextBoxColumn
    Friend WithEvents TipoTavoleDiagT As DataGridViewTextBoxColumn
    Friend WithEvents LunDiagT As DataGridViewTextBoxColumn
    Friend WithEvents GradiDiagT As DataGridViewTextBoxColumn
    Friend WithEvents QtDiagT As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Bt_Pulisci As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents LabelOrdini As ToolStripStatusLabel
End Class
