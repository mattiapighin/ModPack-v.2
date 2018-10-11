<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Archivio_Filtro
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Tx_Codice = New System.Windows.Forms.TextBox()
        Me.Tx_Commessa = New System.Windows.Forms.TextBox()
        Me.Data_Ordine_Da = New System.Windows.Forms.DateTimePicker()
        Me.Data_Ordine_A = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.NU_H_DA = New System.Windows.Forms.NumericUpDown()
        Me.NU_P_DA = New System.Windows.Forms.NumericUpDown()
        Me.NU_L_DA = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NU_H_A = New System.Windows.Forms.NumericUpDown()
        Me.NU_P_A = New System.Windows.Forms.NumericUpDown()
        Me.NU_L_A = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BT_Filtra = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CKL_Tipi = New System.Windows.Forms.CheckedListBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.NU_H_DA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NU_P_DA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NU_L_DA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NU_H_A, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NU_P_A, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NU_L_A, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codice"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Commessa"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.38983!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.61017!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Tx_Codice, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Tx_Commessa, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(306, 66)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Tx_Codice
        '
        Me.Tx_Codice.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tx_Codice.Location = New System.Drawing.Point(89, 6)
        Me.Tx_Codice.Name = "Tx_Codice"
        Me.Tx_Codice.Size = New System.Drawing.Size(214, 20)
        Me.Tx_Codice.TabIndex = 2
        '
        'Tx_Commessa
        '
        Me.Tx_Commessa.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tx_Commessa.Location = New System.Drawing.Point(89, 39)
        Me.Tx_Commessa.Name = "Tx_Commessa"
        Me.Tx_Commessa.Size = New System.Drawing.Size(214, 20)
        Me.Tx_Commessa.TabIndex = 3
        '
        'Data_Ordine_Da
        '
        Me.Data_Ordine_Da.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Data_Ordine_Da.Location = New System.Drawing.Point(62, 6)
        Me.Data_Ordine_Da.Name = "Data_Ordine_Da"
        Me.Data_Ordine_Da.Size = New System.Drawing.Size(241, 20)
        Me.Data_Ordine_Da.TabIndex = 3
        '
        'Data_Ordine_A
        '
        Me.Data_Ordine_A.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Data_Ordine_A.Location = New System.Drawing.Point(62, 39)
        Me.Data_Ordine_A.Name = "Data_Ordine_A"
        Me.Data_Ordine_A.Size = New System.Drawing.Size(241, 20)
        Me.Data_Ordine_A.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Da"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "A"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.5!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Data_Ordine_A, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Data_Ordine_Da, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(306, 66)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 91)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dati"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 91)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Ordine"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 344)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(318, 142)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dimensioni"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.11689!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.11688!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.76624!))
        Me.TableLayoutPanel3.Controls.Add(Me.NU_H_DA, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.NU_P_DA, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.NU_L_DA, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.NU_H_A, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.NU_P_A, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.NU_L_A, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label9, 2, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(306, 116)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'NU_H_DA
        '
        Me.NU_H_DA.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NU_H_DA.Location = New System.Drawing.Point(3, 91)
        Me.NU_H_DA.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NU_H_DA.Name = "NU_H_DA"
        Me.NU_H_DA.Size = New System.Drawing.Size(95, 20)
        Me.NU_H_DA.TabIndex = 4
        '
        'NU_P_DA
        '
        Me.NU_P_DA.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NU_P_DA.Location = New System.Drawing.Point(3, 62)
        Me.NU_P_DA.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NU_P_DA.Name = "NU_P_DA"
        Me.NU_P_DA.Size = New System.Drawing.Size(95, 20)
        Me.NU_P_DA.TabIndex = 4
        '
        'NU_L_DA
        '
        Me.NU_L_DA.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NU_L_DA.Location = New System.Drawing.Point(3, 33)
        Me.NU_L_DA.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NU_L_DA.Name = "NU_L_DA"
        Me.NU_L_DA.Size = New System.Drawing.Size(95, 20)
        Me.NU_L_DA.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(144, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "H"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(144, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "P"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(145, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "L"
        '
        'NU_H_A
        '
        Me.NU_H_A.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NU_H_A.Location = New System.Drawing.Point(205, 91)
        Me.NU_H_A.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NU_H_A.Name = "NU_H_A"
        Me.NU_H_A.Size = New System.Drawing.Size(98, 20)
        Me.NU_H_A.TabIndex = 4
        '
        'NU_P_A
        '
        Me.NU_P_A.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NU_P_A.Location = New System.Drawing.Point(205, 62)
        Me.NU_P_A.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NU_P_A.Name = "NU_P_A"
        Me.NU_P_A.Size = New System.Drawing.Size(98, 20)
        Me.NU_P_A.TabIndex = 4
        '
        'NU_L_A
        '
        Me.NU_L_A.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NU_L_A.Location = New System.Drawing.Point(205, 33)
        Me.NU_L_A.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NU_L_A.Name = "NU_L_A"
        Me.NU_L_A.Size = New System.Drawing.Size(98, 20)
        Me.NU_L_A.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Da"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(247, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "A"
        '
        'BT_Filtra
        '
        Me.BT_Filtra.Location = New System.Drawing.Point(253, 492)
        Me.BT_Filtra.Name = "BT_Filtra"
        Me.BT_Filtra.Size = New System.Drawing.Size(75, 23)
        Me.BT_Filtra.TabIndex = 11
        Me.BT_Filtra.Text = "Filtra"
        Me.BT_Filtra.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CKL_Tipi)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 201)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(318, 137)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo"
        '
        'CKL_Tipi
        '
        Me.CKL_Tipi.FormattingEnabled = True
        Me.CKL_Tipi.Location = New System.Drawing.Point(6, 19)
        Me.CKL_Tipi.Name = "CKL_Tipi"
        Me.CKL_Tipi.Size = New System.Drawing.Size(303, 109)
        Me.CKL_Tipi.TabIndex = 0
        '
        'Archivio_Filtro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(340, 524)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BT_Filtra)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Archivio_Filtro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtro"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.NU_H_DA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NU_P_DA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NU_L_DA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NU_H_A, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NU_P_A, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NU_L_A, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Data_Ordine_Da As DateTimePicker
    Friend WithEvents Data_Ordine_A As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents NU_H_DA As NumericUpDown
    Friend WithEvents NU_P_DA As NumericUpDown
    Friend WithEvents NU_L_DA As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NU_H_A As NumericUpDown
    Friend WithEvents NU_P_A As NumericUpDown
    Friend WithEvents NU_L_A As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BT_Filtra As Button
    Friend WithEvents Tx_Codice As TextBox
    Friend WithEvents Tx_Commessa As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CKL_Tipi As CheckedListBox
End Class
