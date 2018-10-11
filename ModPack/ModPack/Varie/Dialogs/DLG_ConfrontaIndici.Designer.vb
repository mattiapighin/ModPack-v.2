<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DLG_ConfrontaIndici
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DLG_ConfrontaIndici))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.DGW_Confronto = New System.Windows.Forms.DataGridView()
        Me.Imballo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.L = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.H = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Zoccoli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rivestimento = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TipoRivestimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HT = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DT = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BM = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Diagonali = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Lbl_Info = New System.Windows.Forms.Label()
        Me.Lbl_Info1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DGW_Confronto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(353, 218)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(352, 62)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.SystemColors.Control
        Me.OK_Button.Image = CType(resources.GetObject("OK_Button.Image"), System.Drawing.Image)
        Me.OK_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OK_Button.Location = New System.Drawing.Point(28, 6)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(119, 49)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "   Cerca Nuovo"
        Me.OK_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OK_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.OK_Button, "Verrà creato un imballo come da riga ordine. L'indice verrà rimosso dal vecchio i" &
        "mballo e assegnato al nuovo")
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackColor = System.Drawing.SystemColors.Control
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Image = CType(resources.GetObject("Cancel_Button.Image"), System.Drawing.Image)
        Me.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cancel_Button.Location = New System.Drawing.Point(204, 6)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(119, 49)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "   Mantieni"
        Me.Cancel_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.Cancel_Button, "Le differenze vengono ignorate e viene caricato l'imballo originale")
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'DGW_Confronto
        '
        Me.DGW_Confronto.AllowUserToAddRows = False
        Me.DGW_Confronto.AllowUserToDeleteRows = False
        Me.DGW_Confronto.AllowUserToOrderColumns = True
        Me.DGW_Confronto.AllowUserToResizeColumns = False
        Me.DGW_Confronto.AllowUserToResizeRows = False
        Me.DGW_Confronto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGW_Confronto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGW_Confronto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_Confronto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Imballo, Me.L, Me.P, Me.H, Me.Tipo, Me.Zoccoli, Me.Rivestimento, Me.TipoRivestimento, Me.HT, Me.DT, Me.BM, Me.Diagonali})
        Me.DGW_Confronto.Location = New System.Drawing.Point(8, 111)
        Me.DGW_Confronto.Name = "DGW_Confronto"
        Me.DGW_Confronto.ReadOnly = True
        Me.DGW_Confronto.RowHeadersVisible = False
        Me.DGW_Confronto.Size = New System.Drawing.Size(1043, 103)
        Me.DGW_Confronto.TabIndex = 1
        '
        'Imballo
        '
        Me.Imballo.HeaderText = "Imballo"
        Me.Imballo.Name = "Imballo"
        Me.Imballo.ReadOnly = True
        '
        'L
        '
        Me.L.HeaderText = "L"
        Me.L.Name = "L"
        Me.L.ReadOnly = True
        '
        'P
        '
        Me.P.HeaderText = "P"
        Me.P.Name = "P"
        Me.P.ReadOnly = True
        '
        'H
        '
        Me.H.HeaderText = "H"
        Me.H.Name = "H"
        Me.H.ReadOnly = True
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        '
        'Zoccoli
        '
        Me.Zoccoli.HeaderText = "Zoccoli"
        Me.Zoccoli.Name = "Zoccoli"
        Me.Zoccoli.ReadOnly = True
        '
        'Rivestimento
        '
        Me.Rivestimento.HeaderText = "Rivestimento"
        Me.Rivestimento.Name = "Rivestimento"
        Me.Rivestimento.ReadOnly = True
        '
        'TipoRivestimento
        '
        Me.TipoRivestimento.HeaderText = "Tipo Rivestimento"
        Me.TipoRivestimento.Name = "TipoRivestimento"
        Me.TipoRivestimento.ReadOnly = True
        '
        'HT
        '
        Me.HT.HeaderText = "HT"
        Me.HT.Name = "HT"
        Me.HT.ReadOnly = True
        Me.HT.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DT
        '
        Me.DT.HeaderText = "Doppia Tavola"
        Me.DT.Name = "DT"
        Me.DT.ReadOnly = True
        Me.DT.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'BM
        '
        Me.BM.HeaderText = "Base Morali"
        Me.BM.Name = "BM"
        Me.BM.ReadOnly = True
        Me.BM.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Diagonali
        '
        Me.Diagonali.HeaderText = "Diagonali"
        Me.Diagonali.Name = "Diagonali"
        Me.Diagonali.ReadOnly = True
        Me.Diagonali.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Diagonali.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Lbl_Info
        '
        Me.Lbl_Info.BackColor = System.Drawing.Color.White
        Me.Lbl_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Info.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Info.Location = New System.Drawing.Point(8, 49)
        Me.Lbl_Info.Name = "Lbl_Info"
        Me.Lbl_Info.Size = New System.Drawing.Size(1043, 59)
        Me.Lbl_Info.TabIndex = 3
        Me.Lbl_Info.Text = "Info"
        Me.Lbl_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Info1
        '
        Me.Lbl_Info1.BackColor = System.Drawing.Color.White
        Me.Lbl_Info1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Info1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Info1.Location = New System.Drawing.Point(8, 9)
        Me.Lbl_Info1.Name = "Lbl_Info1"
        Me.Lbl_Info1.Size = New System.Drawing.Size(1043, 37)
        Me.Lbl_Info1.TabIndex = 4
        Me.Lbl_Info1.Text = "Info"
        Me.Lbl_Info1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DLG_ConfrontaIndici
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(1058, 287)
        Me.ControlBox = False
        Me.Controls.Add(Me.Lbl_Info1)
        Me.Controls.Add(Me.Lbl_Info)
        Me.Controls.Add(Me.DGW_Confronto)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DLG_ConfrontaIndici"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DGW_Confronto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents DGW_Confronto As DataGridView
    Friend WithEvents Imballo As DataGridViewTextBoxColumn
    Friend WithEvents L As DataGridViewTextBoxColumn
    Friend WithEvents P As DataGridViewTextBoxColumn
    Friend WithEvents H As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Zoccoli As DataGridViewTextBoxColumn
    Friend WithEvents Rivestimento As DataGridViewCheckBoxColumn
    Friend WithEvents TipoRivestimento As DataGridViewTextBoxColumn
    Friend WithEvents HT As DataGridViewCheckBoxColumn
    Friend WithEvents DT As DataGridViewCheckBoxColumn
    Friend WithEvents BM As DataGridViewCheckBoxColumn
    Friend WithEvents Diagonali As DataGridViewCheckBoxColumn
    Friend WithEvents Lbl_Info As Label
    Friend WithEvents Lbl_Info1 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
