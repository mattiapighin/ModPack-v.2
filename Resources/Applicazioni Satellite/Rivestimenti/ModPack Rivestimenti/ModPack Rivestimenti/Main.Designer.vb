<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.DGW_Lista = New System.Windows.Forms.DataGridView()
        Me.Colonna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ordine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bt_Mostra = New System.Windows.Forms.Button()
        Me.Bt_Elimina = New System.Windows.Forms.Button()
        Me.ListaFiles = New System.Windows.Forms.ListBox()
        Me.Bt_Opzioni = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.DGW_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGW_Lista
        '
        Me.DGW_Lista.AllowUserToAddRows = False
        Me.DGW_Lista.AllowUserToOrderColumns = True
        Me.DGW_Lista.AllowUserToResizeColumns = False
        Me.DGW_Lista.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGW_Lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGW_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGW_Lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGW_Lista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGW_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_Lista.ColumnHeadersVisible = False
        Me.DGW_Lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Colonna, Me.ID, Me.Ordine})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGW_Lista.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGW_Lista.Location = New System.Drawing.Point(221, 12)
        Me.DGW_Lista.Name = "DGW_Lista"
        Me.DGW_Lista.RowHeadersVisible = False
        Me.DGW_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGW_Lista.Size = New System.Drawing.Size(817, 530)
        Me.DGW_Lista.TabIndex = 9
        '
        'Colonna
        '
        Me.Colonna.HeaderText = "Colonna"
        Me.Colonna.Name = "Colonna"
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'Ordine
        '
        Me.Ordine.HeaderText = "Ordine"
        Me.Ordine.Name = "Ordine"
        Me.Ordine.Visible = False
        '
        'Bt_Mostra
        '
        Me.Bt_Mostra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Bt_Mostra.Image = CType(resources.GetObject("Bt_Mostra.Image"), System.Drawing.Image)
        Me.Bt_Mostra.Location = New System.Drawing.Point(175, 502)
        Me.Bt_Mostra.Name = "Bt_Mostra"
        Me.Bt_Mostra.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Mostra.TabIndex = 8
        Me.Bt_Mostra.UseVisualStyleBackColor = True
        '
        'Bt_Elimina
        '
        Me.Bt_Elimina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Bt_Elimina.Image = CType(resources.GetObject("Bt_Elimina.Image"), System.Drawing.Image)
        Me.Bt_Elimina.Location = New System.Drawing.Point(129, 502)
        Me.Bt_Elimina.Name = "Bt_Elimina"
        Me.Bt_Elimina.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Elimina.TabIndex = 7
        Me.Bt_Elimina.UseVisualStyleBackColor = True
        '
        'ListaFiles
        '
        Me.ListaFiles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListaFiles.FormattingEnabled = True
        Me.ListaFiles.Location = New System.Drawing.Point(12, 12)
        Me.ListaFiles.Name = "ListaFiles"
        Me.ListaFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListaFiles.Size = New System.Drawing.Size(203, 472)
        Me.ListaFiles.TabIndex = 6
        '
        'Bt_Opzioni
        '
        Me.Bt_Opzioni.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Bt_Opzioni.Image = CType(resources.GetObject("Bt_Opzioni.Image"), System.Drawing.Image)
        Me.Bt_Opzioni.Location = New System.Drawing.Point(12, 502)
        Me.Bt_Opzioni.Name = "Bt_Opzioni"
        Me.Bt_Opzioni.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Opzioni.TabIndex = 5
        Me.Bt_Opzioni.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Rivestimenti"
        Me.NotifyIcon1.Visible = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 547)
        Me.Controls.Add(Me.DGW_Lista)
        Me.Controls.Add(Me.Bt_Mostra)
        Me.Controls.Add(Me.Bt_Elimina)
        Me.Controls.Add(Me.ListaFiles)
        Me.Controls.Add(Me.Bt_Opzioni)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "ModPack Rivestimenti"
        CType(Me.DGW_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGW_Lista As DataGridView
    Friend WithEvents Bt_Mostra As Button
    Friend WithEvents Bt_Elimina As Button
    Friend WithEvents ListaFiles As ListBox
    Friend WithEvents Bt_Opzioni As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Colonna As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Ordine As DataGridViewTextBoxColumn
End Class
