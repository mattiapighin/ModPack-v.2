<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DLG_ModificaOrdine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DLG_ModificaOrdine))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Bt_CaricaOrdine = New System.Windows.Forms.Button()
        Me.Tx_PathOrdine = New System.Windows.Forms.TextBox()
        Me.DG_Ordine = New System.Windows.Forms.DataGridView()
        Me.Riga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Indice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Disegno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Commessa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.L = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.H = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Zoccoli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rivestimento = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TipoRiv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Consegna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HT = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DT = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BM = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Note2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diagonali = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Bt_Salva = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.PB_Avanzamento = New System.Windows.Forms.ToolStripProgressBar()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Bt_Cancella = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_Ordine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Bt_CaricaOrdine)
        Me.GroupBox1.Controls.Add(Me.Tx_PathOrdine)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 52)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ordine da modificare"
        '
        'Bt_CaricaOrdine
        '
        Me.Bt_CaricaOrdine.Location = New System.Drawing.Point(533, 19)
        Me.Bt_CaricaOrdine.Name = "Bt_CaricaOrdine"
        Me.Bt_CaricaOrdine.Size = New System.Drawing.Size(33, 20)
        Me.Bt_CaricaOrdine.TabIndex = 1
        Me.Bt_CaricaOrdine.Text = "..."
        Me.Bt_CaricaOrdine.UseVisualStyleBackColor = True
        '
        'Tx_PathOrdine
        '
        Me.Tx_PathOrdine.Location = New System.Drawing.Point(6, 19)
        Me.Tx_PathOrdine.Name = "Tx_PathOrdine"
        Me.Tx_PathOrdine.Size = New System.Drawing.Size(521, 20)
        Me.Tx_PathOrdine.TabIndex = 0
        '
        'DG_Ordine
        '
        Me.DG_Ordine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Ordine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Ordine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Riga, Me.Indice, Me.Qt, Me.Cliente, Me.Disegno, Me.Commessa, Me.L, Me.P, Me.H, Me.Tipo, Me.Zoccoli, Me.Rivestimento, Me.TipoRiv, Me.Note, Me.Consegna, Me.HT, Me.DT, Me.BM, Me.Note2, Me.Diagonali})
        Me.DG_Ordine.Location = New System.Drawing.Point(12, 70)
        Me.DG_Ordine.Name = "DG_Ordine"
        Me.DG_Ordine.Size = New System.Drawing.Size(700, 208)
        Me.DG_Ordine.TabIndex = 1
        '
        'Riga
        '
        Me.Riga.HeaderText = "Riga"
        Me.Riga.Name = "Riga"
        '
        'Indice
        '
        Me.Indice.HeaderText = "Indice"
        Me.Indice.Name = "Indice"
        '
        'Qt
        '
        Me.Qt.HeaderText = "Qt"
        Me.Qt.Name = "Qt"
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        '
        'Disegno
        '
        Me.Disegno.HeaderText = "Disegno"
        Me.Disegno.Name = "Disegno"
        '
        'Commessa
        '
        Me.Commessa.HeaderText = "Commessa"
        Me.Commessa.Name = "Commessa"
        '
        'L
        '
        Me.L.HeaderText = "L"
        Me.L.Name = "L"
        '
        'P
        '
        Me.P.HeaderText = "P"
        Me.P.Name = "P"
        '
        'H
        '
        Me.H.HeaderText = "H"
        Me.H.Name = "H"
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        '
        'Zoccoli
        '
        Me.Zoccoli.HeaderText = "Zoccoli"
        Me.Zoccoli.Name = "Zoccoli"
        '
        'Rivestimento
        '
        Me.Rivestimento.HeaderText = "Rivestimento"
        Me.Rivestimento.Name = "Rivestimento"
        Me.Rivestimento.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Rivestimento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TipoRiv
        '
        Me.TipoRiv.HeaderText = "Tipo Rivestimento"
        Me.TipoRiv.Name = "TipoRiv"
        Me.TipoRiv.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Note
        '
        Me.Note.HeaderText = "Note"
        Me.Note.Name = "Note"
        '
        'Consegna
        '
        Me.Consegna.HeaderText = "Consegna"
        Me.Consegna.Name = "Consegna"
        '
        'HT
        '
        Me.HT.HeaderText = "HT"
        Me.HT.Name = "HT"
        Me.HT.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DT
        '
        Me.DT.HeaderText = "DT"
        Me.DT.Name = "DT"
        Me.DT.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'BM
        '
        Me.BM.HeaderText = "BM"
        Me.BM.Name = "BM"
        Me.BM.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Note2
        '
        Me.Note2.HeaderText = "Note2"
        Me.Note2.Name = "Note2"
        '
        'Diagonali
        '
        Me.Diagonali.HeaderText = "Diagonali"
        Me.Diagonali.Name = "Diagonali"
        Me.Diagonali.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Diagonali.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Bt_Salva
        '
        Me.Bt_Salva.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Bt_Salva.BackgroundImage = CType(resources.GetObject("Bt_Salva.BackgroundImage"), System.Drawing.Image)
        Me.Bt_Salva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_Salva.FlatAppearance.BorderSize = 0
        Me.Bt_Salva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Salva.Location = New System.Drawing.Point(74, 5)
        Me.Bt_Salva.Name = "Bt_Salva"
        Me.Bt_Salva.Size = New System.Drawing.Size(35, 35)
        Me.Bt_Salva.TabIndex = 2
        Me.Bt_Salva.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PB_Avanzamento})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 292)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(724, 23)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'PB_Avanzamento
        '
        Me.PB_Avanzamento.Name = "PB_Avanzamento"
        Me.PB_Avanzamento.Size = New System.Drawing.Size(120, 17)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Bt_Cancella, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Bt_Salva, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(590, 18)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(122, 46)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Bt_Cancella
        '
        Me.Bt_Cancella.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Bt_Cancella.BackgroundImage = CType(resources.GetObject("Bt_Cancella.BackgroundImage"), System.Drawing.Image)
        Me.Bt_Cancella.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_Cancella.FlatAppearance.BorderSize = 0
        Me.Bt_Cancella.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Cancella.Location = New System.Drawing.Point(13, 5)
        Me.Bt_Cancella.Name = "Bt_Cancella"
        Me.Bt_Cancella.Size = New System.Drawing.Size(35, 35)
        Me.Bt_Cancella.TabIndex = 3
        Me.Bt_Cancella.UseVisualStyleBackColor = True
        '
        'DLG_ModificaOrdine
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 315)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DG_Ordine)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(740, 354)
        Me.Name = "DLG_ModificaOrdine"
        Me.Text = "Modifica Ordine"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_Ordine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Bt_CaricaOrdine As Button
    Friend WithEvents Tx_PathOrdine As TextBox
    Friend WithEvents DG_Ordine As DataGridView
    Friend WithEvents Bt_Salva As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents PB_Avanzamento As ToolStripProgressBar
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Riga As DataGridViewTextBoxColumn
    Friend WithEvents Indice As DataGridViewTextBoxColumn
    Friend WithEvents Qt As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Disegno As DataGridViewTextBoxColumn
    Friend WithEvents Commessa As DataGridViewTextBoxColumn
    Friend WithEvents L As DataGridViewTextBoxColumn
    Friend WithEvents P As DataGridViewTextBoxColumn
    Friend WithEvents H As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Zoccoli As DataGridViewTextBoxColumn
    Friend WithEvents Rivestimento As DataGridViewCheckBoxColumn
    Friend WithEvents TipoRiv As DataGridViewTextBoxColumn
    Friend WithEvents Note As DataGridViewTextBoxColumn
    Friend WithEvents Consegna As DataGridViewTextBoxColumn
    Friend WithEvents HT As DataGridViewCheckBoxColumn
    Friend WithEvents DT As DataGridViewCheckBoxColumn
    Friend WithEvents BM As DataGridViewCheckBoxColumn
    Friend WithEvents Note2 As DataGridViewTextBoxColumn
    Friend WithEvents Diagonali As DataGridViewCheckBoxColumn
    Friend WithEvents Bt_Cancella As Button
End Class
