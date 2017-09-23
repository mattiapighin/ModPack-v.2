<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ListaElementi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ListaElementi))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Bt_ListaMorali = New System.Windows.Forms.Button()
        Me.DGW_Ordini = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Bt_Stampa = New System.Windows.Forms.Button()
        Me.Bt_Esporta = New System.Windows.Forms.Button()
        Me.Bt_DiagonaliTutte = New System.Windows.Forms.Button()
        Me.Bt_DiagonaliT = New System.Windows.Forms.Button()
        Me.Bt_DiagonaliF = New System.Windows.Forms.Button()
        Me.DGW_Result = New System.Windows.Forms.DataGridView()
        Me.PrintTabella = New System.Drawing.Printing.PrintDocument()
        CType(Me.DGW_Ordini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGW_Result, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bt_ListaMorali
        '
        Me.Bt_ListaMorali.Location = New System.Drawing.Point(6, 19)
        Me.Bt_ListaMorali.Name = "Bt_ListaMorali"
        Me.Bt_ListaMorali.Size = New System.Drawing.Size(203, 23)
        Me.Bt_ListaMorali.TabIndex = 0
        Me.Bt_ListaMorali.Text = "Morali"
        Me.Bt_ListaMorali.UseVisualStyleBackColor = True
        '
        'DGW_Ordini
        '
        Me.DGW_Ordini.AllowUserToAddRows = False
        Me.DGW_Ordini.AllowUserToDeleteRows = False
        Me.DGW_Ordini.AllowUserToResizeColumns = False
        Me.DGW_Ordini.AllowUserToResizeRows = False
        Me.DGW_Ordini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGW_Ordini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_Ordini.ColumnHeadersVisible = False
        Me.DGW_Ordini.Location = New System.Drawing.Point(12, 12)
        Me.DGW_Ordini.Name = "DGW_Ordini"
        Me.DGW_Ordini.ReadOnly = True
        Me.DGW_Ordini.RowHeadersVisible = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGW_Ordini.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGW_Ordini.Size = New System.Drawing.Size(215, 267)
        Me.DGW_Ordini.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Bt_Stampa)
        Me.GroupBox1.Controls.Add(Me.Bt_Esporta)
        Me.GroupBox1.Controls.Add(Me.Bt_DiagonaliTutte)
        Me.GroupBox1.Controls.Add(Me.Bt_DiagonaliT)
        Me.GroupBox1.Controls.Add(Me.Bt_DiagonaliF)
        Me.GroupBox1.Controls.Add(Me.Bt_ListaMorali)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 285)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 307)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elemento"
        '
        'Bt_Stampa
        '
        Me.Bt_Stampa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Bt_Stampa.FlatAppearance.BorderSize = 0
        Me.Bt_Stampa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Stampa.Image = CType(resources.GetObject("Bt_Stampa.Image"), System.Drawing.Image)
        Me.Bt_Stampa.Location = New System.Drawing.Point(123, 261)
        Me.Bt_Stampa.Name = "Bt_Stampa"
        Me.Bt_Stampa.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Stampa.TabIndex = 9
        Me.Bt_Stampa.UseVisualStyleBackColor = True
        '
        'Bt_Esporta
        '
        Me.Bt_Esporta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Bt_Esporta.FlatAppearance.BorderSize = 0
        Me.Bt_Esporta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Esporta.Image = CType(resources.GetObject("Bt_Esporta.Image"), System.Drawing.Image)
        Me.Bt_Esporta.Location = New System.Drawing.Point(169, 261)
        Me.Bt_Esporta.Name = "Bt_Esporta"
        Me.Bt_Esporta.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Esporta.TabIndex = 8
        Me.Bt_Esporta.UseVisualStyleBackColor = True
        '
        'Bt_DiagonaliTutte
        '
        Me.Bt_DiagonaliTutte.Location = New System.Drawing.Point(6, 106)
        Me.Bt_DiagonaliTutte.Name = "Bt_DiagonaliTutte"
        Me.Bt_DiagonaliTutte.Size = New System.Drawing.Size(203, 23)
        Me.Bt_DiagonaliTutte.TabIndex = 3
        Me.Bt_DiagonaliTutte.Text = "Tutte Le Diagonali"
        Me.Bt_DiagonaliTutte.UseVisualStyleBackColor = True
        '
        'Bt_DiagonaliT
        '
        Me.Bt_DiagonaliT.Location = New System.Drawing.Point(6, 77)
        Me.Bt_DiagonaliT.Name = "Bt_DiagonaliT"
        Me.Bt_DiagonaliT.Size = New System.Drawing.Size(203, 23)
        Me.Bt_DiagonaliT.TabIndex = 2
        Me.Bt_DiagonaliT.Text = "Diagonali Teste"
        Me.Bt_DiagonaliT.UseVisualStyleBackColor = True
        '
        'Bt_DiagonaliF
        '
        Me.Bt_DiagonaliF.Location = New System.Drawing.Point(6, 48)
        Me.Bt_DiagonaliF.Name = "Bt_DiagonaliF"
        Me.Bt_DiagonaliF.Size = New System.Drawing.Size(203, 23)
        Me.Bt_DiagonaliF.TabIndex = 1
        Me.Bt_DiagonaliF.Text = "Diagonali Fiancate"
        Me.Bt_DiagonaliF.UseVisualStyleBackColor = True
        '
        'DGW_Result
        '
        Me.DGW_Result.AllowUserToAddRows = False
        Me.DGW_Result.AllowUserToDeleteRows = False
        Me.DGW_Result.AllowUserToResizeColumns = False
        Me.DGW_Result.AllowUserToResizeRows = False
        Me.DGW_Result.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGW_Result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGW_Result.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGW_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGW_Result.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGW_Result.Location = New System.Drawing.Point(233, 12)
        Me.DGW_Result.Name = "DGW_Result"
        Me.DGW_Result.ReadOnly = True
        Me.DGW_Result.RowHeadersVisible = False
        Me.DGW_Result.Size = New System.Drawing.Size(612, 580)
        Me.DGW_Result.TabIndex = 3
        '
        'PrintTabella
        '
        '
        'Form_ListaElementi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 604)
        Me.Controls.Add(Me.DGW_Result)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGW_Ordini)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_ListaElementi"
        Me.Text = "Lista Elementi"
        CType(Me.DGW_Ordini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGW_Result, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Bt_ListaMorali As Button
    Friend WithEvents DGW_Ordini As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGW_Result As DataGridView
    Friend WithEvents Bt_DiagonaliF As Button
    Friend WithEvents Bt_DiagonaliT As Button
    Friend WithEvents Bt_DiagonaliTutte As Button
    Friend WithEvents Bt_Esporta As Button
    Friend WithEvents Bt_Stampa As Button
    Friend WithEvents PrintTabella As Printing.PrintDocument
End Class
