<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LST_Morali
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LST_Morali))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Bt_Pulisci = New System.Windows.Forms.Button()
        Me.Bt_Stampa = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CB_OrdiniAperti = New System.Windows.Forms.ComboBox()
        Me.Bt_Ok = New System.Windows.Forms.Button()
        Me.DGW_Morali = New System.Windows.Forms.DataGridView()
        Me.Imballo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HT = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Qt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoMorali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LunghezzaMorali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtMorali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fresati = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PrintMorali = New System.Drawing.Printing.PrintDocument()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LabelOrdini = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CB_Settimana = New System.Windows.Forms.ComboBox()
        Me.Bt_Ok_Settimana = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGW_Morali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.TableLayoutPanel1.TabIndex = 8
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
        Me.GroupBox1.Size = New System.Drawing.Size(326, 49)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ordine"
        '
        'CB_OrdiniAperti
        '
        Me.CB_OrdiniAperti.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_OrdiniAperti.FormattingEnabled = True
        Me.CB_OrdiniAperti.Location = New System.Drawing.Point(6, 19)
        Me.CB_OrdiniAperti.Name = "CB_OrdiniAperti"
        Me.CB_OrdiniAperti.Size = New System.Drawing.Size(233, 21)
        Me.CB_OrdiniAperti.TabIndex = 1
        '
        'Bt_Ok
        '
        Me.Bt_Ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Ok.Location = New System.Drawing.Point(245, 19)
        Me.Bt_Ok.Name = "Bt_Ok"
        Me.Bt_Ok.Size = New System.Drawing.Size(75, 21)
        Me.Bt_Ok.TabIndex = 2
        Me.Bt_Ok.Text = "OK"
        Me.Bt_Ok.UseVisualStyleBackColor = True
        '
        'DGW_Morali
        '
        Me.DGW_Morali.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGW_Morali.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGW_Morali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_Morali.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Imballo, Me.HT, Me.Qt, Me.TipoMorali, Me.LunghezzaMorali, Me.QtMorali, Me.Fresati})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGW_Morali.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGW_Morali.Location = New System.Drawing.Point(12, 67)
        Me.DGW_Morali.Name = "DGW_Morali"
        Me.DGW_Morali.Size = New System.Drawing.Size(1171, 292)
        Me.DGW_Morali.TabIndex = 6
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
        'TipoMorali
        '
        Me.TipoMorali.HeaderText = "Tipo Morali"
        Me.TipoMorali.Name = "TipoMorali"
        Me.TipoMorali.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TipoMorali.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'LunghezzaMorali
        '
        Me.LunghezzaMorali.HeaderText = "Lunghezza Morali"
        Me.LunghezzaMorali.Name = "LunghezzaMorali"
        Me.LunghezzaMorali.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LunghezzaMorali.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'QtMorali
        '
        Me.QtMorali.HeaderText = "Quantità Morali"
        Me.QtMorali.Name = "QtMorali"
        '
        'Fresati
        '
        Me.Fresati.HeaderText = "Fresati"
        Me.Fresati.Name = "Fresati"
        '
        'PrintMorali
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelOrdini})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 373)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1195, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LabelOrdini
        '
        Me.LabelOrdini.Name = "LabelOrdini"
        Me.LabelOrdini.Size = New System.Drawing.Size(120, 17)
        Me.LabelOrdini.Text = "ToolStripStatusLabel1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.CB_Settimana)
        Me.GroupBox2.Controls.Add(Me.Bt_Ok_Settimana)
        Me.GroupBox2.Location = New System.Drawing.Point(344, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 49)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Settimana"
        '
        'CB_Settimana
        '
        Me.CB_Settimana.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_Settimana.FormattingEnabled = True
        Me.CB_Settimana.Location = New System.Drawing.Point(6, 19)
        Me.CB_Settimana.Name = "CB_Settimana"
        Me.CB_Settimana.Size = New System.Drawing.Size(233, 21)
        Me.CB_Settimana.TabIndex = 1
        '
        'Bt_Ok_Settimana
        '
        Me.Bt_Ok_Settimana.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Ok_Settimana.Location = New System.Drawing.Point(245, 19)
        Me.Bt_Ok_Settimana.Name = "Bt_Ok_Settimana"
        Me.Bt_Ok_Settimana.Size = New System.Drawing.Size(75, 21)
        Me.Bt_Ok_Settimana.TabIndex = 2
        Me.Bt_Ok_Settimana.Text = "OK"
        Me.Bt_Ok_Settimana.UseVisualStyleBackColor = True
        '
        'LST_Morali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 395)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGW_Morali)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1211, 434)
        Me.Name = "LST_Morali"
        Me.Text = "Lista Morali"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGW_Morali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Bt_Pulisci As Button
    Friend WithEvents Bt_Stampa As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CB_OrdiniAperti As ComboBox
    Friend WithEvents Bt_Ok As Button
    Friend WithEvents DGW_Morali As DataGridView
    Friend WithEvents Imballo As DataGridViewTextBoxColumn
    Friend WithEvents HT As DataGridViewCheckBoxColumn
    Friend WithEvents Qt As DataGridViewTextBoxColumn
    Friend WithEvents TipoMorali As DataGridViewTextBoxColumn
    Friend WithEvents LunghezzaMorali As DataGridViewTextBoxColumn
    Friend WithEvents QtMorali As DataGridViewTextBoxColumn
    Friend WithEvents Fresati As DataGridViewCheckBoxColumn
    Friend WithEvents PrintMorali As Printing.PrintDocument
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents LabelOrdini As ToolStripStatusLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CB_Settimana As ComboBox
    Friend WithEvents Bt_Ok_Settimana As Button
End Class
