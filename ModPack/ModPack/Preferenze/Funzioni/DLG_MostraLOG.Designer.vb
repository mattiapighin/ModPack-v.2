<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DLG_MostraLOG
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
        Me.DGW_Log = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MessageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModPackDBDataSet = New ModPack.ModPackDBDataSet()
        Me.LogTableAdapter = New ModPack.ModPackDBDataSetTableAdapters.LogTableAdapter()
        CType(Me.DGW_Log, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModPackDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGW_Log
        '
        Me.DGW_Log.AllowUserToAddRows = False
        Me.DGW_Log.AllowUserToDeleteRows = False
        Me.DGW_Log.AllowUserToResizeColumns = False
        Me.DGW_Log.AllowUserToResizeRows = False
        Me.DGW_Log.AutoGenerateColumns = False
        Me.DGW_Log.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGW_Log.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGW_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_Log.ColumnHeadersVisible = False
        Me.DGW_Log.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.DataDataGridViewTextBoxColumn, Me.OraDataGridViewTextBoxColumn, Me.UserDataGridViewTextBoxColumn, Me.MessageDataGridViewTextBoxColumn})
        Me.DGW_Log.DataSource = Me.LogBindingSource
        Me.DGW_Log.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGW_Log.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGW_Log.Location = New System.Drawing.Point(0, 0)
        Me.DGW_Log.Name = "DGW_Log"
        Me.DGW_Log.ReadOnly = True
        Me.DGW_Log.RowHeadersVisible = False
        Me.DGW_Log.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGW_Log.Size = New System.Drawing.Size(733, 582)
        Me.DGW_Log.TabIndex = 1
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        Me.IdDataGridViewTextBoxColumn.Width = 22
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "Data"
        Me.DataDataGridViewTextBoxColumn.HeaderText = "Data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        Me.DataDataGridViewTextBoxColumn.ReadOnly = True
        Me.DataDataGridViewTextBoxColumn.Width = 5
        '
        'OraDataGridViewTextBoxColumn
        '
        Me.OraDataGridViewTextBoxColumn.DataPropertyName = "Ora"
        Me.OraDataGridViewTextBoxColumn.HeaderText = "Ora"
        Me.OraDataGridViewTextBoxColumn.Name = "OraDataGridViewTextBoxColumn"
        Me.OraDataGridViewTextBoxColumn.ReadOnly = True
        Me.OraDataGridViewTextBoxColumn.Width = 5
        '
        'UserDataGridViewTextBoxColumn
        '
        Me.UserDataGridViewTextBoxColumn.DataPropertyName = "User"
        Me.UserDataGridViewTextBoxColumn.HeaderText = "User"
        Me.UserDataGridViewTextBoxColumn.Name = "UserDataGridViewTextBoxColumn"
        Me.UserDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserDataGridViewTextBoxColumn.Width = 5
        '
        'MessageDataGridViewTextBoxColumn
        '
        Me.MessageDataGridViewTextBoxColumn.DataPropertyName = "Message"
        Me.MessageDataGridViewTextBoxColumn.HeaderText = "Message"
        Me.MessageDataGridViewTextBoxColumn.Name = "MessageDataGridViewTextBoxColumn"
        Me.MessageDataGridViewTextBoxColumn.ReadOnly = True
        Me.MessageDataGridViewTextBoxColumn.Width = 5
        '
        'LogBindingSource
        '
        Me.LogBindingSource.DataMember = "Log"
        Me.LogBindingSource.DataSource = Me.ModPackDBDataSet
        '
        'ModPackDBDataSet
        '
        Me.ModPackDBDataSet.DataSetName = "ModPackDBDataSet"
        Me.ModPackDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LogTableAdapter
        '
        Me.LogTableAdapter.ClearBeforeFill = True
        '
        'DLG_MostraLOG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 582)
        Me.Controls.Add(Me.DGW_Log)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DLG_MostraLOG"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LOG"
        CType(Me.DGW_Log, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModPackDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGW_Log As DataGridView
    Friend WithEvents ModPackDBDataSet As ModPackDBDataSet
    Friend WithEvents LogBindingSource As BindingSource
    Friend WithEvents LogTableAdapter As ModPackDBDataSetTableAdapters.LogTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MessageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
