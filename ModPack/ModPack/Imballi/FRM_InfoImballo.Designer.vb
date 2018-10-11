<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_InfoImballo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_InfoImballo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lb_imballo = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Lb_Tipo = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Lbl_L = New System.Windows.Forms.Label()
        Me.Lbl_x1 = New System.Windows.Forms.Label()
        Me.Lbl_P = New System.Windows.Forms.Label()
        Me.Lbl_x2 = New System.Windows.Forms.Label()
        Me.Lbl_H = New System.Windows.Forms.Label()
        Me.Ck_Morali = New System.Windows.Forms.CheckBox()
        Me.Ck_DoppiaTav = New System.Windows.Forms.CheckBox()
        Me.Ck_Diagonali = New System.Windows.Forms.CheckBox()
        Me.Ck_Rivestimento = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Ck_Ht = New System.Windows.Forms.CheckBox()
        Me.PB_Img = New System.Windows.Forms.PictureBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Lb_Zoccoli = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Lb_m2 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Lb_m3 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Lb_Creazione = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Lb_Rivestimento = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Lst_Disegni = New System.Windows.Forms.ListBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Lb_Note = New System.Windows.Forms.Label()
        Me.DG_Distinta = New System.Windows.Forms.DataGridView()
        Me.Part = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.X = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Y = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Z = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Bt_Apri = New System.Windows.Forms.Button()
        Me.Bt_Elimina = New System.Windows.Forms.Button()
        Me.Bt_Duplica = New System.Windows.Forms.Button()
        Me.Bt_Modifica = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PB_Img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.DG_Distinta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lb_imballo)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 50)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Imballo"
        '
        'Lb_imballo
        '
        Me.Lb_imballo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lb_imballo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_imballo.Location = New System.Drawing.Point(3, 16)
        Me.Lb_imballo.Name = "Lb_imballo"
        Me.Lb_imballo.Size = New System.Drawing.Size(249, 31)
        Me.Lb_imballo.TabIndex = 8
        Me.Lb_imballo.Text = "Imballo"
        Me.Lb_imballo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lb_Tipo)
        Me.GroupBox2.Location = New System.Drawing.Point(272, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(85, 50)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo"
        '
        'Lb_Tipo
        '
        Me.Lb_Tipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lb_Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Tipo.Location = New System.Drawing.Point(3, 16)
        Me.Lb_Tipo.Name = "Lb_Tipo"
        Me.Lb_Tipo.Size = New System.Drawing.Size(79, 31)
        Me.Lb_Tipo.TabIndex = 8
        Me.Lb_Tipo.Text = "Tipo"
        Me.Lb_Tipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 59)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(255, 47)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dimensioni Interne"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Lbl_L, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Lbl_x1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Lbl_P, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Lbl_x2, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Lbl_H, 4, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(249, 28)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Lbl_L
        '
        Me.Lbl_L.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_L.AutoSize = True
        Me.Lbl_L.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_L.Location = New System.Drawing.Point(22, 4)
        Me.Lbl_L.Name = "Lbl_L"
        Me.Lbl_L.Size = New System.Drawing.Size(18, 20)
        Me.Lbl_L.TabIndex = 8
        Me.Lbl_L.Text = "L"
        '
        'Lbl_x1
        '
        Me.Lbl_x1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_x1.AutoSize = True
        Me.Lbl_x1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_x1.Location = New System.Drawing.Point(69, 4)
        Me.Lbl_x1.Name = "Lbl_x1"
        Me.Lbl_x1.Size = New System.Drawing.Size(16, 20)
        Me.Lbl_x1.TabIndex = 8
        Me.Lbl_x1.Text = "x"
        '
        'Lbl_P
        '
        Me.Lbl_P.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_P.AutoSize = True
        Me.Lbl_P.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_P.Location = New System.Drawing.Point(114, 4)
        Me.Lbl_P.Name = "Lbl_P"
        Me.Lbl_P.Size = New System.Drawing.Size(19, 20)
        Me.Lbl_P.TabIndex = 8
        Me.Lbl_P.Text = "P"
        '
        'Lbl_x2
        '
        Me.Lbl_x2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_x2.AutoSize = True
        Me.Lbl_x2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_x2.Location = New System.Drawing.Point(162, 4)
        Me.Lbl_x2.Name = "Lbl_x2"
        Me.Lbl_x2.Size = New System.Drawing.Size(16, 20)
        Me.Lbl_x2.TabIndex = 8
        Me.Lbl_x2.Text = "x"
        '
        'Lbl_H
        '
        Me.Lbl_H.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_H.AutoSize = True
        Me.Lbl_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_H.Location = New System.Drawing.Point(207, 4)
        Me.Lbl_H.Name = "Lbl_H"
        Me.Lbl_H.Size = New System.Drawing.Size(21, 20)
        Me.Lbl_H.TabIndex = 8
        Me.Lbl_H.Text = "H"
        '
        'Ck_Morali
        '
        Me.Ck_Morali.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Ck_Morali.AutoCheck = False
        Me.Ck_Morali.AutoSize = True
        Me.Ck_Morali.Location = New System.Drawing.Point(3, 7)
        Me.Ck_Morali.Name = "Ck_Morali"
        Me.Ck_Morali.Size = New System.Drawing.Size(124, 17)
        Me.Ck_Morali.TabIndex = 3
        Me.Ck_Morali.Text = "BASE CON MORALI"
        Me.Ck_Morali.UseVisualStyleBackColor = True
        '
        'Ck_DoppiaTav
        '
        Me.Ck_DoppiaTav.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Ck_DoppiaTav.AutoCheck = False
        Me.Ck_DoppiaTav.AutoSize = True
        Me.Ck_DoppiaTav.Location = New System.Drawing.Point(3, 38)
        Me.Ck_DoppiaTav.Name = "Ck_DoppiaTav"
        Me.Ck_DoppiaTav.Size = New System.Drawing.Size(142, 17)
        Me.Ck_DoppiaTav.TabIndex = 4
        Me.Ck_DoppiaTav.Text = "BASE DOPPIA TAVOLA"
        Me.Ck_DoppiaTav.UseVisualStyleBackColor = True
        '
        'Ck_Diagonali
        '
        Me.Ck_Diagonali.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Ck_Diagonali.AutoCheck = False
        Me.Ck_Diagonali.AutoSize = True
        Me.Ck_Diagonali.Location = New System.Drawing.Point(3, 69)
        Me.Ck_Diagonali.Name = "Ck_Diagonali"
        Me.Ck_Diagonali.Size = New System.Drawing.Size(110, 17)
        Me.Ck_Diagonali.TabIndex = 5
        Me.Ck_Diagonali.Text = "CON DIAGONALI"
        Me.Ck_Diagonali.UseVisualStyleBackColor = True
        '
        'Ck_Rivestimento
        '
        Me.Ck_Rivestimento.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Ck_Rivestimento.AutoCheck = False
        Me.Ck_Rivestimento.AutoSize = True
        Me.Ck_Rivestimento.Location = New System.Drawing.Point(6, 20)
        Me.Ck_Rivestimento.Name = "Ck_Rivestimento"
        Me.Ck_Rivestimento.Size = New System.Drawing.Size(15, 14)
        Me.Ck_Rivestimento.TabIndex = 6
        Me.Ck_Rivestimento.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox4.Location = New System.Drawing.Point(272, 112)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(163, 146)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Caratteristiche"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Ck_Morali, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Ck_DoppiaTav, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Ck_Diagonali, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Ck_Ht, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(157, 127)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Ck_Ht
        '
        Me.Ck_Ht.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Ck_Ht.AutoCheck = False
        Me.Ck_Ht.AutoSize = True
        Me.Ck_Ht.Location = New System.Drawing.Point(3, 101)
        Me.Ck_Ht.Name = "Ck_Ht"
        Me.Ck_Ht.Size = New System.Drawing.Size(41, 17)
        Me.Ck_Ht.TabIndex = 6
        Me.Ck_Ht.Text = "HT"
        Me.Ck_Ht.UseVisualStyleBackColor = True
        '
        'PB_Img
        '
        Me.PB_Img.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PB_Img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PB_Img.Location = New System.Drawing.Point(11, 109)
        Me.PB_Img.Name = "PB_Img"
        Me.PB_Img.Size = New System.Drawing.Size(255, 252)
        Me.PB_Img.TabIndex = 8
        Me.PB_Img.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Lb_Zoccoli)
        Me.GroupBox5.Location = New System.Drawing.Point(360, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(75, 50)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Zoccoli"
        '
        'Lb_Zoccoli
        '
        Me.Lb_Zoccoli.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lb_Zoccoli.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Zoccoli.Location = New System.Drawing.Point(3, 16)
        Me.Lb_Zoccoli.Name = "Lb_Zoccoli"
        Me.Lb_Zoccoli.Size = New System.Drawing.Size(69, 31)
        Me.Lb_Zoccoli.TabIndex = 8
        Me.Lb_Zoccoli.Text = "2V"
        Me.Lb_Zoccoli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Lb_m2)
        Me.GroupBox6.Location = New System.Drawing.Point(272, 314)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(85, 47)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "M²"
        '
        'Lb_m2
        '
        Me.Lb_m2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lb_m2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_m2.Location = New System.Drawing.Point(3, 16)
        Me.Lb_m2.Name = "Lb_m2"
        Me.Lb_m2.Size = New System.Drawing.Size(79, 28)
        Me.Lb_m2.TabIndex = 8
        Me.Lb_m2.Text = "Tipo"
        Me.Lb_m2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Lb_m3)
        Me.GroupBox7.Location = New System.Drawing.Point(360, 314)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(75, 47)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "M³"
        '
        'Lb_m3
        '
        Me.Lb_m3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lb_m3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_m3.Location = New System.Drawing.Point(3, 16)
        Me.Lb_m3.Name = "Lb_m3"
        Me.Lb_m3.Size = New System.Drawing.Size(69, 28)
        Me.Lb_m3.TabIndex = 8
        Me.Lb_m3.Text = "2V"
        Me.Lb_m3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Lb_Creazione)
        Me.GroupBox8.Location = New System.Drawing.Point(272, 65)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(163, 41)
        Me.GroupBox8.TabIndex = 1
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Data Creazione"
        '
        'Lb_Creazione
        '
        Me.Lb_Creazione.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lb_Creazione.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Creazione.Location = New System.Drawing.Point(3, 16)
        Me.Lb_Creazione.Name = "Lb_Creazione"
        Me.Lb_Creazione.Size = New System.Drawing.Size(157, 22)
        Me.Lb_Creazione.TabIndex = 8
        Me.Lb_Creazione.Text = "Creazione"
        Me.Lb_Creazione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Left
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PB_Img)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox7)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox10)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox9)
        Me.SplitContainer1.Size = New System.Drawing.Size(447, 563)
        Me.SplitContainer1.SplitterDistance = 375
        Me.SplitContainer1.TabIndex = 9
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Lb_Rivestimento)
        Me.GroupBox11.Controls.Add(Me.Ck_Rivestimento)
        Me.GroupBox11.Location = New System.Drawing.Point(272, 264)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(163, 44)
        Me.GroupBox11.TabIndex = 9
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Rivestimento"
        '
        'Lb_Rivestimento
        '
        Me.Lb_Rivestimento.Location = New System.Drawing.Point(27, 16)
        Me.Lb_Rivestimento.Name = "Lb_Rivestimento"
        Me.Lb_Rivestimento.ReadOnly = True
        Me.Lb_Rivestimento.Size = New System.Drawing.Size(130, 20)
        Me.Lb_Rivestimento.TabIndex = 7
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Lst_Disegni)
        Me.GroupBox10.Location = New System.Drawing.Point(249, 3)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(193, 168)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Disegni Associati"
        '
        'Lst_Disegni
        '
        Me.Lst_Disegni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lst_Disegni.FormattingEnabled = True
        Me.Lst_Disegni.Location = New System.Drawing.Point(3, 16)
        Me.Lst_Disegni.Name = "Lst_Disegni"
        Me.Lst_Disegni.Size = New System.Drawing.Size(187, 149)
        Me.Lst_Disegni.TabIndex = 0
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Lb_Note)
        Me.GroupBox9.Location = New System.Drawing.Point(11, 3)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(232, 168)
        Me.GroupBox9.TabIndex = 0
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Note"
        '
        'Lb_Note
        '
        Me.Lb_Note.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lb_Note.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Note.Location = New System.Drawing.Point(3, 16)
        Me.Lb_Note.Name = "Lb_Note"
        Me.Lb_Note.Size = New System.Drawing.Size(226, 149)
        Me.Lb_Note.TabIndex = 0
        '
        'DG_Distinta
        '
        Me.DG_Distinta.AllowUserToAddRows = False
        Me.DG_Distinta.AllowUserToDeleteRows = False
        Me.DG_Distinta.AllowUserToOrderColumns = True
        Me.DG_Distinta.AllowUserToResizeColumns = False
        Me.DG_Distinta.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DG_Distinta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Distinta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Distinta.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DG_Distinta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DG_Distinta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Distinta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_Distinta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Distinta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Part, Me.X, Me.Y, Me.Z, Me.N})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_Distinta.DefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Distinta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Distinta.GridColor = System.Drawing.SystemColors.Control
        Me.DG_Distinta.Location = New System.Drawing.Point(447, 0)
        Me.DG_Distinta.Name = "DG_Distinta"
        Me.DG_Distinta.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Distinta.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DG_Distinta.RowHeadersVisible = False
        Me.DG_Distinta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Distinta.Size = New System.Drawing.Size(302, 563)
        Me.DG_Distinta.TabIndex = 10
        '
        'Part
        '
        Me.Part.HeaderText = "Part"
        Me.Part.Name = "Part"
        Me.Part.ReadOnly = True
        '
        'X
        '
        Me.X.HeaderText = "X"
        Me.X.Name = "X"
        Me.X.ReadOnly = True
        '
        'Y
        '
        Me.Y.HeaderText = "Y"
        Me.Y.Name = "Y"
        Me.Y.ReadOnly = True
        '
        'Z
        '
        Me.Z.HeaderText = "Z"
        Me.Z.Name = "Z"
        Me.Z.ReadOnly = True
        '
        'N
        '
        Me.N.HeaderText = "N"
        Me.N.Name = "N"
        Me.N.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(749, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(77, 563)
        Me.Panel1.TabIndex = 11
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Bt_Apri, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Bt_Elimina, 0, 13)
        Me.TableLayoutPanel3.Controls.Add(Me.Bt_Duplica, 0, 12)
        Me.TableLayoutPanel3.Controls.Add(Me.Bt_Modifica, 0, 11)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 14
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(77, 563)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Bt_Apri
        '
        Me.Bt_Apri.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Apri.AutoEllipsis = True
        Me.Bt_Apri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Apri.Location = New System.Drawing.Point(3, 3)
        Me.Bt_Apri.Name = "Bt_Apri"
        Me.Bt_Apri.Size = New System.Drawing.Size(71, 34)
        Me.Bt_Apri.TabIndex = 0
        Me.Bt_Apri.Text = "Disegno"
        Me.Bt_Apri.UseVisualStyleBackColor = True
        '
        'Bt_Elimina
        '
        Me.Bt_Elimina.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Elimina.AutoEllipsis = True
        Me.Bt_Elimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Elimina.Location = New System.Drawing.Point(3, 523)
        Me.Bt_Elimina.Name = "Bt_Elimina"
        Me.Bt_Elimina.Size = New System.Drawing.Size(71, 37)
        Me.Bt_Elimina.TabIndex = 0
        Me.Bt_Elimina.Text = "Elimina"
        Me.Bt_Elimina.UseVisualStyleBackColor = True
        '
        'Bt_Duplica
        '
        Me.Bt_Duplica.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Duplica.AutoEllipsis = True
        Me.Bt_Duplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Duplica.Location = New System.Drawing.Point(3, 483)
        Me.Bt_Duplica.Name = "Bt_Duplica"
        Me.Bt_Duplica.Size = New System.Drawing.Size(71, 34)
        Me.Bt_Duplica.TabIndex = 0
        Me.Bt_Duplica.Text = "Duplica"
        Me.Bt_Duplica.UseVisualStyleBackColor = True
        '
        'Bt_Modifica
        '
        Me.Bt_Modifica.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Modifica.AutoEllipsis = True
        Me.Bt_Modifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Modifica.Location = New System.Drawing.Point(3, 443)
        Me.Bt_Modifica.Name = "Bt_Modifica"
        Me.Bt_Modifica.Size = New System.Drawing.Size(71, 34)
        Me.Bt_Modifica.TabIndex = 0
        Me.Bt_Modifica.Text = "Modifica"
        Me.Bt_Modifica.UseVisualStyleBackColor = True
        '
        'FRM_InfoImballo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(826, 563)
        Me.Controls.Add(Me.DG_Distinta)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_InfoImballo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "INFO - "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PB_Img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.DG_Distinta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Ck_Morali As CheckBox
    Friend WithEvents Ck_DoppiaTav As CheckBox
    Friend WithEvents Ck_Diagonali As CheckBox
    Friend WithEvents Ck_Rivestimento As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Lbl_L As Label
    Friend WithEvents Lbl_P As Label
    Friend WithEvents Lbl_H As Label
    Friend WithEvents Lbl_x1 As Label
    Friend WithEvents Lbl_x2 As Label
    Friend WithEvents Lb_imballo As Label
    Friend WithEvents Lb_Tipo As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Ck_Ht As CheckBox
    Friend WithEvents PB_Img As PictureBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Lb_Zoccoli As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Lb_m2 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Lb_m3 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Lb_Creazione As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Lst_Disegni As ListBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Lb_Note As Label
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents Lb_Rivestimento As TextBox
    Friend WithEvents DG_Distinta As DataGridView
    Friend WithEvents Part As DataGridViewTextBoxColumn
    Friend WithEvents X As DataGridViewTextBoxColumn
    Friend WithEvents Y As DataGridViewTextBoxColumn
    Friend WithEvents Z As DataGridViewTextBoxColumn
    Friend WithEvents N As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Bt_Modifica As Button
    Friend WithEvents Bt_Apri As Button
    Friend WithEvents Bt_Elimina As Button
    Friend WithEvents Bt_Duplica As Button
End Class
