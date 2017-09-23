<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Tabelle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Tabelle))
        Me.DGW_Result = New System.Windows.Forms.DataGridView()
        Me.TxtQuery = New System.Windows.Forms.TextBox()
        Me.Bt_Test = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Bt_Salva = New System.Windows.Forms.Button()
        Me.DGW_queries = New System.Windows.Forms.DataGridView()
        Me.Bt_Esegui = New System.Windows.Forms.Button()
        Me.Bt_Elimina = New System.Windows.Forms.Button()
        Me.Bt_Esporta = New System.Windows.Forms.Button()
        Me.Tree = New System.Windows.Forms.TreeView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Bt_Invia = New System.Windows.Forms.Button()
        Me.Bt_Info = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DGW_Result, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGW_queries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGW_Result
        '
        Me.DGW_Result.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGW_Result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGW_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_Result.Location = New System.Drawing.Point(303, 80)
        Me.DGW_Result.Name = "DGW_Result"
        Me.DGW_Result.Size = New System.Drawing.Size(798, 529)
        Me.DGW_Result.TabIndex = 0
        '
        'TxtQuery
        '
        Me.TxtQuery.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtQuery.BackColor = System.Drawing.SystemColors.Info
        Me.TxtQuery.Location = New System.Drawing.Point(6, 19)
        Me.TxtQuery.Name = "TxtQuery"
        Me.TxtQuery.Size = New System.Drawing.Size(1086, 20)
        Me.TxtQuery.TabIndex = 1
        '
        'Bt_Test
        '
        Me.Bt_Test.Location = New System.Drawing.Point(5, 45)
        Me.Bt_Test.Name = "Bt_Test"
        Me.Bt_Test.Size = New System.Drawing.Size(75, 20)
        Me.Bt_Test.TabIndex = 2
        Me.Bt_Test.Text = "Test"
        Me.Bt_Test.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Bt_Salva)
        Me.GroupBox1.Controls.Add(Me.TxtQuery)
        Me.GroupBox1.Controls.Add(Me.Bt_Test)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1098, 71)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Query"
        '
        'Bt_Salva
        '
        Me.Bt_Salva.Location = New System.Drawing.Point(87, 45)
        Me.Bt_Salva.Name = "Bt_Salva"
        Me.Bt_Salva.Size = New System.Drawing.Size(75, 20)
        Me.Bt_Salva.TabIndex = 4
        Me.Bt_Salva.Text = "Salva"
        Me.Bt_Salva.UseVisualStyleBackColor = True
        '
        'DGW_queries
        '
        Me.DGW_queries.AllowUserToAddRows = False
        Me.DGW_queries.AllowUserToDeleteRows = False
        Me.DGW_queries.AllowUserToOrderColumns = True
        Me.DGW_queries.AllowUserToResizeColumns = False
        Me.DGW_queries.AllowUserToResizeRows = False
        Me.DGW_queries.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DGW_queries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGW_queries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_queries.ColumnHeadersVisible = False
        Me.DGW_queries.Location = New System.Drawing.Point(3, 80)
        Me.DGW_queries.Name = "DGW_queries"
        Me.DGW_queries.ReadOnly = True
        Me.DGW_queries.RowHeadersVisible = False
        Me.DGW_queries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGW_queries.Size = New System.Drawing.Size(294, 483)
        Me.DGW_queries.TabIndex = 4
        '
        'Bt_Esegui
        '
        Me.Bt_Esegui.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Bt_Esegui.FlatAppearance.BorderSize = 0
        Me.Bt_Esegui.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Esegui.Image = CType(resources.GetObject("Bt_Esegui.Image"), System.Drawing.Image)
        Me.Bt_Esegui.Location = New System.Drawing.Point(257, 569)
        Me.Bt_Esegui.Name = "Bt_Esegui"
        Me.Bt_Esegui.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Esegui.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Bt_Esegui, "Esegui")
        Me.Bt_Esegui.UseVisualStyleBackColor = True
        '
        'Bt_Elimina
        '
        Me.Bt_Elimina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Bt_Elimina.FlatAppearance.BorderSize = 0
        Me.Bt_Elimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Elimina.Image = CType(resources.GetObject("Bt_Elimina.Image"), System.Drawing.Image)
        Me.Bt_Elimina.Location = New System.Drawing.Point(3, 569)
        Me.Bt_Elimina.Name = "Bt_Elimina"
        Me.Bt_Elimina.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Elimina.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.Bt_Elimina, "Elimina la query selezionata")
        Me.Bt_Elimina.UseVisualStyleBackColor = True
        '
        'Bt_Esporta
        '
        Me.Bt_Esporta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Bt_Esporta.FlatAppearance.BorderSize = 0
        Me.Bt_Esporta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Esporta.Image = CType(resources.GetObject("Bt_Esporta.Image"), System.Drawing.Image)
        Me.Bt_Esporta.Location = New System.Drawing.Point(211, 569)
        Me.Bt_Esporta.Name = "Bt_Esporta"
        Me.Bt_Esporta.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Esporta.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.Bt_Esporta, "Esporta tabella")
        Me.Bt_Esporta.UseVisualStyleBackColor = True
        '
        'Tree
        '
        Me.Tree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tree.Location = New System.Drawing.Point(0, 0)
        Me.Tree.Name = "Tree"
        Me.Tree.Size = New System.Drawing.Size(96, 100)
        Me.Tree.TabIndex = 8
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.SplitContainer1.Panel1.Controls.Add(Me.Bt_Invia)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Bt_Info)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DGW_Result)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Bt_Esporta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DGW_queries)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Bt_Elimina)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Bt_Esegui)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Tree)
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Size = New System.Drawing.Size(1110, 616)
        Me.SplitContainer1.SplitterDistance = 884
        Me.SplitContainer1.TabIndex = 9
        '
        'Bt_Invia
        '
        Me.Bt_Invia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Bt_Invia.FlatAppearance.BorderSize = 0
        Me.Bt_Invia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Invia.Image = CType(resources.GetObject("Bt_Invia.Image"), System.Drawing.Image)
        Me.Bt_Invia.Location = New System.Drawing.Point(165, 569)
        Me.Bt_Invia.Name = "Bt_Invia"
        Me.Bt_Invia.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Invia.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.Bt_Invia, "Invia tabella")
        Me.Bt_Invia.UseVisualStyleBackColor = True
        '
        'Bt_Info
        '
        Me.Bt_Info.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Bt_Info.FlatAppearance.BorderSize = 0
        Me.Bt_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Info.Image = CType(resources.GetObject("Bt_Info.Image"), System.Drawing.Image)
        Me.Bt_Info.Location = New System.Drawing.Point(119, 569)
        Me.Bt_Info.Name = "Bt_Info"
        Me.Bt_Info.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Info.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.Bt_Info, "Mostra database")
        Me.Bt_Info.UseVisualStyleBackColor = True
        '
        'Form_Tabelle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 616)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Tabelle"
        Me.Text = "Tabelle"
        CType(Me.DGW_Result, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGW_queries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGW_Result As DataGridView
    Friend WithEvents TxtQuery As TextBox
    Friend WithEvents Bt_Test As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Bt_Salva As Button
    Friend WithEvents DGW_queries As DataGridView
    Friend WithEvents Bt_Esegui As Button
    Friend WithEvents Bt_Elimina As Button
    Friend WithEvents Bt_Esporta As Button
    Friend WithEvents Tree As TreeView
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Bt_Info As Button
    Friend WithEvents Bt_Invia As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
