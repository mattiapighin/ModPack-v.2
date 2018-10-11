<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Crea_Manuale
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
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Crea_Manuale))
        Me.DGW_Distinta = New System.Windows.Forms.DataGridView()
        Me.Column_Part = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_X = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Y = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Z = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_N = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Tag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGW_Indici = New System.Windows.Forms.DataGridView()
        Me.Column_Indice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Codice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_NOTE1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_NOTE2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_NOTEBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tx_CodiceImballo = New System.Windows.Forms.TextBox()
        Me.Bt_Annulla = New System.Windows.Forms.Button()
        Me.Bt_Salva = New System.Windows.Forms.Button()
        Me.Bt_CheckCodice = New System.Windows.Forms.Button()
        Me.PANEL_EDIT = New System.Windows.Forms.Panel()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Bt_CalcolaM2 = New System.Windows.Forms.Button()
        Me.Bt_CalcolaM3 = New System.Windows.Forms.Button()
        Me.Tx_M2 = New System.Windows.Forms.TextBox()
        Me.Tx_M3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Bt_CaricaIMG = New System.Windows.Forms.Button()
        Me.PB_Img = New System.Windows.Forms.PictureBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Tx_SottoMT = New System.Windows.Forms.TextBox()
        Me.Tx_SottoMF = New System.Windows.Forms.TextBox()
        Me.Tx_MT = New System.Windows.Forms.TextBox()
        Me.Tx_MF = New System.Windows.Forms.TextBox()
        Me.Tx_SopraMT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tx_SopraMF = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Tx_PrimoMorale = New System.Windows.Forms.TextBox()
        Me.Tx_DiagT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tx_DiagF = New System.Windows.Forms.TextBox()
        Me.Ck_HT = New System.Windows.Forms.CheckBox()
        Me.Ck_Diagonali = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Ck_Rivestimento = New System.Windows.Forms.CheckBox()
        Me.Lbl_Rivestimento = New System.Windows.Forms.Label()
        Me.Cb_Rivestimento = New System.Windows.Forms.ComboBox()
        Me.Base = New System.Windows.Forms.GroupBox()
        Me.Rb_BaseDT = New System.Windows.Forms.RadioButton()
        Me.Rb_BaseSemplice = New System.Windows.Forms.RadioButton()
        Me.Rb_BaseMorali = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Rb_EUR = New System.Windows.Forms.RadioButton()
        Me.Rb_NoZoccoli = New System.Windows.Forms.RadioButton()
        Me.Rb_2Vie = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Lbl_Tipo = New System.Windows.Forms.Label()
        Me.Cb_Tipo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tx_H = New System.Windows.Forms.TextBox()
        Me.Tx_P = New System.Windows.Forms.TextBox()
        Me.Tx_L = New System.Windows.Forms.TextBox()
        Me.Nu_Prezzo = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Bt_AggDisegno = New System.Windows.Forms.Button()
        Me.Tx_Disegno = New System.Windows.Forms.TextBox()
        CType(Me.DGW_Distinta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGW_Indici, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PANEL_EDIT.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PB_Img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Base.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Nu_Prezzo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGW_Distinta
        '
        Me.DGW_Distinta.AllowUserToResizeColumns = False
        Me.DGW_Distinta.AllowUserToResizeRows = False
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DGW_Distinta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle25
        Me.DGW_Distinta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGW_Distinta.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.DGW_Distinta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGW_Distinta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.DGW_Distinta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_Distinta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_Part, Me.Column_X, Me.Column_Y, Me.Column_Z, Me.Column_N, Me.Column_Tag})
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGW_Distinta.DefaultCellStyle = DataGridViewCellStyle27
        Me.DGW_Distinta.GridColor = System.Drawing.Color.White
        Me.DGW_Distinta.Location = New System.Drawing.Point(499, 3)
        Me.DGW_Distinta.Name = "DGW_Distinta"
        Me.DGW_Distinta.RowHeadersWidth = 15
        Me.DGW_Distinta.Size = New System.Drawing.Size(445, 705)
        Me.DGW_Distinta.TabIndex = 0
        '
        'Column_Part
        '
        Me.Column_Part.HeaderText = "PART"
        Me.Column_Part.Name = "Column_Part"
        '
        'Column_X
        '
        Me.Column_X.HeaderText = "X"
        Me.Column_X.Name = "Column_X"
        '
        'Column_Y
        '
        Me.Column_Y.HeaderText = "Y"
        Me.Column_Y.Name = "Column_Y"
        '
        'Column_Z
        '
        Me.Column_Z.HeaderText = "Z"
        Me.Column_Z.Name = "Column_Z"
        '
        'Column_N
        '
        Me.Column_N.HeaderText = "N"
        Me.Column_N.Name = "Column_N"
        '
        'Column_Tag
        '
        Me.Column_Tag.HeaderText = "TAG"
        Me.Column_Tag.Name = "Column_Tag"
        '
        'DGW_Indici
        '
        Me.DGW_Indici.AllowUserToResizeColumns = False
        Me.DGW_Indici.AllowUserToResizeRows = False
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DGW_Indici.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle28
        Me.DGW_Indici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGW_Indici.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.DGW_Indici.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGW_Indici.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle29
        Me.DGW_Indici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_Indici.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_Indice, Me.Column_Codice, Me.Column_NOTE1, Me.Column_NOTE2, Me.Column_NOTEBIC})
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGW_Indici.DefaultCellStyle = DataGridViewCellStyle30
        Me.DGW_Indici.GridColor = System.Drawing.Color.White
        Me.DGW_Indici.Location = New System.Drawing.Point(3, 576)
        Me.DGW_Indici.Name = "DGW_Indici"
        Me.DGW_Indici.RowHeadersWidth = 15
        Me.DGW_Indici.Size = New System.Drawing.Size(489, 132)
        Me.DGW_Indici.TabIndex = 1
        '
        'Column_Indice
        '
        Me.Column_Indice.HeaderText = "INDICE"
        Me.Column_Indice.Name = "Column_Indice"
        '
        'Column_Codice
        '
        Me.Column_Codice.HeaderText = "CODICE"
        Me.Column_Codice.Name = "Column_Codice"
        '
        'Column_NOTE1
        '
        Me.Column_NOTE1.HeaderText = "NOTE1"
        Me.Column_NOTE1.Name = "Column_NOTE1"
        '
        'Column_NOTE2
        '
        Me.Column_NOTE2.HeaderText = "NOTE2"
        Me.Column_NOTE2.Name = "Column_NOTE2"
        '
        'Column_NOTEBIC
        '
        Me.Column_NOTEBIC.HeaderText = "NOTE BIC"
        Me.Column_NOTEBIC.Name = "Column_NOTEBIC"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Tx_CodiceImballo)
        Me.Panel1.Controls.Add(Me.Bt_Annulla)
        Me.Panel1.Controls.Add(Me.Bt_Salva)
        Me.Panel1.Controls.Add(Me.Bt_CheckCodice)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(951, 43)
        Me.Panel1.TabIndex = 2
        '
        'Tx_CodiceImballo
        '
        Me.Tx_CodiceImballo.Location = New System.Drawing.Point(9, 9)
        Me.Tx_CodiceImballo.Name = "Tx_CodiceImballo"
        Me.Tx_CodiceImballo.Size = New System.Drawing.Size(193, 20)
        Me.Tx_CodiceImballo.TabIndex = 2
        '
        'Bt_Annulla
        '
        Me.Bt_Annulla.FlatAppearance.BorderSize = 0
        Me.Bt_Annulla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Annulla.Image = CType(resources.GetObject("Bt_Annulla.Image"), System.Drawing.Image)
        Me.Bt_Annulla.Location = New System.Drawing.Point(849, -1)
        Me.Bt_Annulla.Name = "Bt_Annulla"
        Me.Bt_Annulla.Size = New System.Drawing.Size(38, 38)
        Me.Bt_Annulla.TabIndex = 2
        Me.Bt_Annulla.UseVisualStyleBackColor = True
        '
        'Bt_Salva
        '
        Me.Bt_Salva.FlatAppearance.BorderSize = 0
        Me.Bt_Salva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Salva.Image = CType(resources.GetObject("Bt_Salva.Image"), System.Drawing.Image)
        Me.Bt_Salva.Location = New System.Drawing.Point(900, -1)
        Me.Bt_Salva.Name = "Bt_Salva"
        Me.Bt_Salva.Size = New System.Drawing.Size(38, 38)
        Me.Bt_Salva.TabIndex = 1
        Me.Bt_Salva.UseVisualStyleBackColor = True
        '
        'Bt_CheckCodice
        '
        Me.Bt_CheckCodice.FlatAppearance.BorderSize = 0
        Me.Bt_CheckCodice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_CheckCodice.Image = CType(resources.GetObject("Bt_CheckCodice.Image"), System.Drawing.Image)
        Me.Bt_CheckCodice.Location = New System.Drawing.Point(208, -1)
        Me.Bt_CheckCodice.Name = "Bt_CheckCodice"
        Me.Bt_CheckCodice.Size = New System.Drawing.Size(38, 38)
        Me.Bt_CheckCodice.TabIndex = 0
        Me.Bt_CheckCodice.UseVisualStyleBackColor = True
        '
        'PANEL_EDIT
        '
        Me.PANEL_EDIT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PANEL_EDIT.Controls.Add(Me.GroupBox11)
        Me.PANEL_EDIT.Controls.Add(Me.GroupBox10)
        Me.PANEL_EDIT.Controls.Add(Me.GroupBox9)
        Me.PANEL_EDIT.Controls.Add(Me.GroupBox8)
        Me.PANEL_EDIT.Controls.Add(Me.GroupBox7)
        Me.PANEL_EDIT.Controls.Add(Me.GroupBox6)
        Me.PANEL_EDIT.Controls.Add(Me.GroupBox5)
        Me.PANEL_EDIT.Controls.Add(Me.Ck_HT)
        Me.PANEL_EDIT.Controls.Add(Me.Ck_Diagonali)
        Me.PANEL_EDIT.Controls.Add(Me.GroupBox4)
        Me.PANEL_EDIT.Controls.Add(Me.Base)
        Me.PANEL_EDIT.Controls.Add(Me.GroupBox3)
        Me.PANEL_EDIT.Controls.Add(Me.GroupBox2)
        Me.PANEL_EDIT.Controls.Add(Me.GroupBox1)
        Me.PANEL_EDIT.Controls.Add(Me.DGW_Distinta)
        Me.PANEL_EDIT.Controls.Add(Me.DGW_Indici)
        Me.PANEL_EDIT.Location = New System.Drawing.Point(12, 61)
        Me.PANEL_EDIT.Name = "PANEL_EDIT"
        Me.PANEL_EDIT.Size = New System.Drawing.Size(951, 715)
        Me.PANEL_EDIT.TabIndex = 3
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.DatePicker)
        Me.GroupBox10.Location = New System.Drawing.Point(208, 471)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(145, 52)
        Me.GroupBox10.TabIndex = 15
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Data Creazione"
        '
        'DatePicker
        '
        Me.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePicker.Location = New System.Drawing.Point(6, 25)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(133, 20)
        Me.DatePicker.TabIndex = 16
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Nu_Prezzo)
        Me.GroupBox9.Controls.Add(Me.Label10)
        Me.GroupBox9.Location = New System.Drawing.Point(359, 471)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(132, 52)
        Me.GroupBox9.TabIndex = 14
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Prezzo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(111, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 18)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "€"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox8.Location = New System.Drawing.Point(3, 471)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(199, 99)
        Me.GroupBox8.TabIndex = 13
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Valori"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.45989!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.21925!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.7861!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label9, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Bt_CalcolaM2, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Bt_CalcolaM3, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Tx_M2, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Tx_M3, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(187, 74)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 18)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "m³"
        '
        'Bt_CalcolaM2
        '
        Me.Bt_CalcolaM2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Bt_CalcolaM2.BackColor = System.Drawing.SystemColors.Control
        Me.Bt_CalcolaM2.FlatAppearance.BorderSize = 0
        Me.Bt_CalcolaM2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_CalcolaM2.Image = CType(resources.GetObject("Bt_CalcolaM2.Image"), System.Drawing.Image)
        Me.Bt_CalcolaM2.Location = New System.Drawing.Point(153, 3)
        Me.Bt_CalcolaM2.Name = "Bt_CalcolaM2"
        Me.Bt_CalcolaM2.Size = New System.Drawing.Size(30, 30)
        Me.Bt_CalcolaM2.TabIndex = 0
        Me.Bt_CalcolaM2.UseVisualStyleBackColor = False
        '
        'Bt_CalcolaM3
        '
        Me.Bt_CalcolaM3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Bt_CalcolaM3.BackColor = System.Drawing.SystemColors.Control
        Me.Bt_CalcolaM3.FlatAppearance.BorderSize = 0
        Me.Bt_CalcolaM3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_CalcolaM3.Image = CType(resources.GetObject("Bt_CalcolaM3.Image"), System.Drawing.Image)
        Me.Bt_CalcolaM3.Location = New System.Drawing.Point(153, 40)
        Me.Bt_CalcolaM3.Name = "Bt_CalcolaM3"
        Me.Bt_CalcolaM3.Size = New System.Drawing.Size(30, 30)
        Me.Bt_CalcolaM3.TabIndex = 1
        Me.Bt_CalcolaM3.UseVisualStyleBackColor = False
        '
        'Tx_M2
        '
        Me.Tx_M2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tx_M2.Location = New System.Drawing.Point(45, 8)
        Me.Tx_M2.Name = "Tx_M2"
        Me.Tx_M2.Size = New System.Drawing.Size(100, 20)
        Me.Tx_M2.TabIndex = 2
        Me.Tx_M2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tx_M3
        '
        Me.Tx_M3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tx_M3.Location = New System.Drawing.Point(45, 45)
        Me.Tx_M3.Name = "Tx_M3"
        Me.Tx_M3.Size = New System.Drawing.Size(100, 20)
        Me.Tx_M3.TabIndex = 3
        Me.Tx_M3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "m²"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Bt_CaricaIMG)
        Me.GroupBox7.Controls.Add(Me.PB_Img)
        Me.GroupBox7.Location = New System.Drawing.Point(209, 170)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(283, 295)
        Me.GroupBox7.TabIndex = 12
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Immagine"
        '
        'Bt_CaricaIMG
        '
        Me.Bt_CaricaIMG.Location = New System.Drawing.Point(224, 18)
        Me.Bt_CaricaIMG.Name = "Bt_CaricaIMG"
        Me.Bt_CaricaIMG.Size = New System.Drawing.Size(53, 23)
        Me.Bt_CaricaIMG.TabIndex = 1
        Me.Bt_CaricaIMG.Text = "Carica"
        Me.Bt_CaricaIMG.UseVisualStyleBackColor = True
        '
        'PB_Img
        '
        Me.PB_Img.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PB_Img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PB_Img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PB_Img.Location = New System.Drawing.Point(6, 18)
        Me.PB_Img.Name = "PB_Img"
        Me.PB_Img.Size = New System.Drawing.Size(270, 270)
        Me.PB_Img.TabIndex = 0
        Me.PB_Img.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 298)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(199, 167)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Montanti"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Tx_SottoMT, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Tx_SottoMF, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Tx_MT, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Tx_MF, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Tx_SopraMT, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Tx_SopraMF, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(187, 142)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Tx_SottoMT
        '
        Me.Tx_SottoMT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tx_SottoMT.Location = New System.Drawing.Point(110, 113)
        Me.Tx_SottoMT.Name = "Tx_SottoMT"
        Me.Tx_SottoMT.Size = New System.Drawing.Size(60, 20)
        Me.Tx_SottoMT.TabIndex = 18
        Me.Tx_SottoMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tx_SottoMF
        '
        Me.Tx_SottoMF.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tx_SottoMF.Location = New System.Drawing.Point(16, 113)
        Me.Tx_SottoMF.Name = "Tx_SottoMF"
        Me.Tx_SottoMF.Size = New System.Drawing.Size(60, 20)
        Me.Tx_SottoMF.TabIndex = 17
        Me.Tx_SottoMF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tx_MT
        '
        Me.Tx_MT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tx_MT.Location = New System.Drawing.Point(110, 77)
        Me.Tx_MT.Name = "Tx_MT"
        Me.Tx_MT.ReadOnly = True
        Me.Tx_MT.Size = New System.Drawing.Size(60, 20)
        Me.Tx_MT.TabIndex = 16
        Me.Tx_MT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tx_MF
        '
        Me.Tx_MF.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tx_MF.Location = New System.Drawing.Point(16, 77)
        Me.Tx_MF.Name = "Tx_MF"
        Me.Tx_MF.ReadOnly = True
        Me.Tx_MF.Size = New System.Drawing.Size(60, 20)
        Me.Tx_MF.TabIndex = 15
        Me.Tx_MF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tx_SopraMT
        '
        Me.Tx_SopraMT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tx_SopraMT.Location = New System.Drawing.Point(110, 42)
        Me.Tx_SopraMT.Name = "Tx_SopraMT"
        Me.Tx_SopraMT.Size = New System.Drawing.Size(60, 20)
        Me.Tx_SopraMT.TabIndex = 14
        Me.Tx_SopraMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Fiancate"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(123, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Teste"
        '
        'Tx_SopraMF
        '
        Me.Tx_SopraMF.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tx_SopraMF.Location = New System.Drawing.Point(16, 42)
        Me.Tx_SopraMF.Name = "Tx_SopraMF"
        Me.Tx_SopraMF.Size = New System.Drawing.Size(60, 20)
        Me.Tx_SopraMF.TabIndex = 13
        Me.Tx_SopraMF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 170)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 122)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Altri Dati"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.17021!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.82979!))
        Me.TableLayoutPanel1.Controls.Add(Me.Tx_PrimoMorale, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Tx_DiagT, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Tx_DiagF, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(188, 97)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Tx_PrimoMorale
        '
        Me.Tx_PrimoMorale.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Tx_PrimoMorale.Location = New System.Drawing.Point(117, 70)
        Me.Tx_PrimoMorale.Name = "Tx_PrimoMorale"
        Me.Tx_PrimoMorale.Size = New System.Drawing.Size(68, 20)
        Me.Tx_PrimoMorale.TabIndex = 16
        Me.Tx_PrimoMorale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tx_DiagT
        '
        Me.Tx_DiagT.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Tx_DiagT.Location = New System.Drawing.Point(117, 38)
        Me.Tx_DiagT.Name = "Tx_DiagT"
        Me.Tx_DiagT.Size = New System.Drawing.Size(68, 20)
        Me.Tx_DiagT.TabIndex = 15
        Me.Tx_DiagT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Gradi Diag. F"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Gradi Diag. T"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Quota primo morale"
        '
        'Tx_DiagF
        '
        Me.Tx_DiagF.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Tx_DiagF.Location = New System.Drawing.Point(117, 6)
        Me.Tx_DiagF.Name = "Tx_DiagF"
        Me.Tx_DiagF.Size = New System.Drawing.Size(68, 20)
        Me.Tx_DiagF.TabIndex = 14
        Me.Tx_DiagF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Ck_HT
        '
        Me.Ck_HT.Appearance = System.Windows.Forms.Appearance.Button
        Me.Ck_HT.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Ck_HT.Location = New System.Drawing.Point(311, 127)
        Me.Ck_HT.Name = "Ck_HT"
        Me.Ck_HT.Size = New System.Drawing.Size(77, 30)
        Me.Ck_HT.TabIndex = 9
        Me.Ck_HT.Text = "HT"
        Me.Ck_HT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Ck_HT.UseVisualStyleBackColor = True
        '
        'Ck_Diagonali
        '
        Me.Ck_Diagonali.Location = New System.Drawing.Point(412, 126)
        Me.Ck_Diagonali.Name = "Ck_Diagonali"
        Me.Ck_Diagonali.Size = New System.Drawing.Size(80, 33)
        Me.Ck_Diagonali.TabIndex = 8
        Me.Ck_Diagonali.Text = "Con Diagonali"
        Me.Ck_Diagonali.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Ck_Rivestimento)
        Me.GroupBox4.Controls.Add(Me.Lbl_Rivestimento)
        Me.GroupBox4.Controls.Add(Me.Cb_Rivestimento)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 114)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(296, 50)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rivestimento"
        '
        'Ck_Rivestimento
        '
        Me.Ck_Rivestimento.AutoSize = True
        Me.Ck_Rivestimento.Location = New System.Drawing.Point(270, 23)
        Me.Ck_Rivestimento.Name = "Ck_Rivestimento"
        Me.Ck_Rivestimento.Size = New System.Drawing.Size(15, 14)
        Me.Ck_Rivestimento.TabIndex = 8
        Me.Ck_Rivestimento.UseVisualStyleBackColor = True
        '
        'Lbl_Rivestimento
        '
        Me.Lbl_Rivestimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Rivestimento.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Rivestimento.Location = New System.Drawing.Point(78, 19)
        Me.Lbl_Rivestimento.Name = "Lbl_Rivestimento"
        Me.Lbl_Rivestimento.Size = New System.Drawing.Size(185, 21)
        Me.Lbl_Rivestimento.TabIndex = 5
        Me.Lbl_Rivestimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cb_Rivestimento
        '
        Me.Cb_Rivestimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Rivestimento.FormattingEnabled = True
        Me.Cb_Rivestimento.Location = New System.Drawing.Point(6, 19)
        Me.Cb_Rivestimento.Name = "Cb_Rivestimento"
        Me.Cb_Rivestimento.Size = New System.Drawing.Size(65, 21)
        Me.Cb_Rivestimento.TabIndex = 3
        '
        'Base
        '
        Me.Base.Controls.Add(Me.Rb_BaseDT)
        Me.Base.Controls.Add(Me.Rb_BaseSemplice)
        Me.Base.Controls.Add(Me.Rb_BaseMorali)
        Me.Base.Location = New System.Drawing.Point(402, 3)
        Me.Base.Name = "Base"
        Me.Base.Size = New System.Drawing.Size(91, 105)
        Me.Base.TabIndex = 6
        Me.Base.TabStop = False
        Me.Base.Text = "Base"
        '
        'Rb_BaseDT
        '
        Me.Rb_BaseDT.AutoSize = True
        Me.Rb_BaseDT.Location = New System.Drawing.Point(6, 76)
        Me.Rb_BaseDT.Name = "Rb_BaseDT"
        Me.Rb_BaseDT.Size = New System.Drawing.Size(84, 17)
        Me.Rb_BaseDT.TabIndex = 8
        Me.Rb_BaseDT.Text = "Doppia Tav."
        Me.Rb_BaseDT.UseVisualStyleBackColor = True
        '
        'Rb_BaseSemplice
        '
        Me.Rb_BaseSemplice.AutoSize = True
        Me.Rb_BaseSemplice.Checked = True
        Me.Rb_BaseSemplice.Location = New System.Drawing.Point(6, 20)
        Me.Rb_BaseSemplice.Name = "Rb_BaseSemplice"
        Me.Rb_BaseSemplice.Size = New System.Drawing.Size(68, 17)
        Me.Rb_BaseSemplice.TabIndex = 6
        Me.Rb_BaseSemplice.TabStop = True
        Me.Rb_BaseSemplice.Text = "Semplice"
        Me.Rb_BaseSemplice.UseVisualStyleBackColor = True
        '
        'Rb_BaseMorali
        '
        Me.Rb_BaseMorali.AutoSize = True
        Me.Rb_BaseMorali.Location = New System.Drawing.Point(6, 48)
        Me.Rb_BaseMorali.Name = "Rb_BaseMorali"
        Me.Rb_BaseMorali.Size = New System.Drawing.Size(53, 17)
        Me.Rb_BaseMorali.TabIndex = 7
        Me.Rb_BaseMorali.Text = "Morali"
        Me.Rb_BaseMorali.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Rb_EUR)
        Me.GroupBox3.Controls.Add(Me.Rb_NoZoccoli)
        Me.GroupBox3.Controls.Add(Me.Rb_2Vie)
        Me.GroupBox3.Location = New System.Drawing.Point(305, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(91, 105)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Zoccoli"
        '
        'Rb_EUR
        '
        Me.Rb_EUR.AutoSize = True
        Me.Rb_EUR.Location = New System.Drawing.Point(6, 76)
        Me.Rb_EUR.Name = "Rb_EUR"
        Me.Rb_EUR.Size = New System.Drawing.Size(48, 17)
        Me.Rb_EUR.TabIndex = 8
        Me.Rb_EUR.Text = "EUR"
        Me.Rb_EUR.UseVisualStyleBackColor = True
        '
        'Rb_NoZoccoli
        '
        Me.Rb_NoZoccoli.AutoSize = True
        Me.Rb_NoZoccoli.Checked = True
        Me.Rb_NoZoccoli.Location = New System.Drawing.Point(6, 20)
        Me.Rb_NoZoccoli.Name = "Rb_NoZoccoli"
        Me.Rb_NoZoccoli.Size = New System.Drawing.Size(77, 17)
        Me.Rb_NoZoccoli.TabIndex = 6
        Me.Rb_NoZoccoli.TabStop = True
        Me.Rb_NoZoccoli.Text = "No Zoccoli"
        Me.Rb_NoZoccoli.UseVisualStyleBackColor = True
        '
        'Rb_2Vie
        '
        Me.Rb_2Vie.AutoSize = True
        Me.Rb_2Vie.Location = New System.Drawing.Point(6, 48)
        Me.Rb_2Vie.Name = "Rb_2Vie"
        Me.Rb_2Vie.Size = New System.Drawing.Size(49, 17)
        Me.Rb_2Vie.TabIndex = 7
        Me.Rb_2Vie.Text = "2 Vie"
        Me.Rb_2Vie.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lbl_Tipo)
        Me.GroupBox2.Controls.Add(Me.Cb_Tipo)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(296, 50)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo"
        '
        'Lbl_Tipo
        '
        Me.Lbl_Tipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Tipo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Tipo.Location = New System.Drawing.Point(78, 19)
        Me.Lbl_Tipo.Name = "Lbl_Tipo"
        Me.Lbl_Tipo.Size = New System.Drawing.Size(210, 21)
        Me.Lbl_Tipo.TabIndex = 5
        Me.Lbl_Tipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cb_Tipo
        '
        Me.Cb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Tipo.FormattingEnabled = True
        Me.Cb_Tipo.Location = New System.Drawing.Point(6, 19)
        Me.Cb_Tipo.Name = "Cb_Tipo"
        Me.Cb_Tipo.Size = New System.Drawing.Size(65, 21)
        Me.Cb_Tipo.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Tx_H)
        Me.GroupBox1.Controls.Add(Me.Tx_P)
        Me.GroupBox1.Controls.Add(Me.Tx_L)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 49)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dimensioni Interne"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "x"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "x"
        '
        'Tx_H
        '
        Me.Tx_H.Location = New System.Drawing.Point(218, 18)
        Me.Tx_H.Name = "Tx_H"
        Me.Tx_H.Size = New System.Drawing.Size(70, 20)
        Me.Tx_H.TabIndex = 5
        Me.Tx_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tx_P
        '
        Me.Tx_P.Location = New System.Drawing.Point(112, 18)
        Me.Tx_P.Name = "Tx_P"
        Me.Tx_P.Size = New System.Drawing.Size(70, 20)
        Me.Tx_P.TabIndex = 4
        Me.Tx_P.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tx_L
        '
        Me.Tx_L.Location = New System.Drawing.Point(6, 18)
        Me.Tx_L.Name = "Tx_L"
        Me.Tx_L.Size = New System.Drawing.Size(70, 20)
        Me.Tx_L.TabIndex = 3
        Me.Tx_L.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Nu_Prezzo
        '
        Me.Nu_Prezzo.DecimalPlaces = 2
        Me.Nu_Prezzo.Location = New System.Drawing.Point(7, 25)
        Me.Nu_Prezzo.Name = "Nu_Prezzo"
        Me.Nu_Prezzo.Size = New System.Drawing.Size(95, 20)
        Me.Nu_Prezzo.TabIndex = 16
        Me.Nu_Prezzo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Tx_Disegno)
        Me.GroupBox11.Controls.Add(Me.Bt_AggDisegno)
        Me.GroupBox11.Location = New System.Drawing.Point(208, 529)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(283, 41)
        Me.GroupBox11.TabIndex = 16
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Disegno"
        '
        'Bt_AggDisegno
        '
        Me.Bt_AggDisegno.BackgroundImage = CType(resources.GetObject("Bt_AggDisegno.BackgroundImage"), System.Drawing.Image)
        Me.Bt_AggDisegno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_AggDisegno.Location = New System.Drawing.Point(253, 15)
        Me.Bt_AggDisegno.Name = "Bt_AggDisegno"
        Me.Bt_AggDisegno.Size = New System.Drawing.Size(24, 20)
        Me.Bt_AggDisegno.TabIndex = 0
        Me.Bt_AggDisegno.UseVisualStyleBackColor = True
        '
        'Tx_Disegno
        '
        Me.Tx_Disegno.Location = New System.Drawing.Point(6, 15)
        Me.Tx_Disegno.Name = "Tx_Disegno"
        Me.Tx_Disegno.Size = New System.Drawing.Size(241, 20)
        Me.Tx_Disegno.TabIndex = 1
        '
        'Form_Crea_Manuale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(974, 787)
        Me.Controls.Add(Me.PANEL_EDIT)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_Crea_Manuale"
        Me.Text = "Crea Imballo"
        CType(Me.DGW_Distinta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGW_Indici, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PANEL_EDIT.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.PB_Img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Base.ResumeLayout(False)
        Me.Base.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Nu_Prezzo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGW_Distinta As DataGridView
    Friend WithEvents Column_Part As DataGridViewTextBoxColumn
    Friend WithEvents Column_X As DataGridViewTextBoxColumn
    Friend WithEvents Column_Y As DataGridViewTextBoxColumn
    Friend WithEvents Column_Z As DataGridViewTextBoxColumn
    Friend WithEvents Column_N As DataGridViewTextBoxColumn
    Friend WithEvents Column_Tag As DataGridViewTextBoxColumn
    Friend WithEvents DGW_Indici As DataGridView
    Friend WithEvents Column_Indice As DataGridViewTextBoxColumn
    Friend WithEvents Column_Codice As DataGridViewTextBoxColumn
    Friend WithEvents Column_NOTE1 As DataGridViewTextBoxColumn
    Friend WithEvents Column_NOTE2 As DataGridViewTextBoxColumn
    Friend WithEvents Column_NOTEBIC As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Tx_CodiceImballo As TextBox
    Friend WithEvents Bt_Annulla As Button
    Friend WithEvents Bt_Salva As Button
    Friend WithEvents Bt_CheckCodice As Button
    Friend WithEvents PANEL_EDIT As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Cb_Tipo As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Tx_H As TextBox
    Friend WithEvents Tx_P As TextBox
    Friend WithEvents Tx_L As TextBox
    Friend WithEvents Ck_Rivestimento As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Lbl_Rivestimento As Label
    Friend WithEvents Cb_Rivestimento As ComboBox
    Friend WithEvents Base As GroupBox
    Friend WithEvents Rb_BaseDT As RadioButton
    Friend WithEvents Rb_BaseSemplice As RadioButton
    Friend WithEvents Rb_BaseMorali As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Rb_EUR As RadioButton
    Friend WithEvents Rb_NoZoccoli As RadioButton
    Friend WithEvents Rb_2Vie As RadioButton
    Friend WithEvents Lbl_Tipo As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Tx_SottoMT As TextBox
    Friend WithEvents Tx_SottoMF As TextBox
    Friend WithEvents Tx_MT As TextBox
    Friend WithEvents Tx_MF As TextBox
    Friend WithEvents Tx_SopraMT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Tx_SopraMF As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Tx_PrimoMorale As TextBox
    Friend WithEvents Tx_DiagT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Tx_DiagF As TextBox
    Friend WithEvents Ck_HT As CheckBox
    Friend WithEvents Ck_Diagonali As CheckBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents PB_Img As PictureBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Bt_CalcolaM2 As Button
    Friend WithEvents Bt_CalcolaM3 As Button
    Friend WithEvents Tx_M2 As TextBox
    Friend WithEvents Tx_M3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Bt_CaricaIMG As Button
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents DatePicker As DateTimePicker
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Nu_Prezzo As NumericUpDown
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents Tx_Disegno As TextBox
    Friend WithEvents Bt_AggDisegno As Button
End Class
