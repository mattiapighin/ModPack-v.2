<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ControlloOrdineInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ControlloOrdineInput))
        Me.Bt_OpenOrdine = New System.Windows.Forms.Button()
        Me.Lbl_NumeroOrdine = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_DataOrdine = New System.Windows.Forms.Label()
        Me.LblTotRighe = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Bt_Left = New System.Windows.Forms.Button()
        Me.Bt_Right = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tx_Riga = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Tx_Commessa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tx_Indice = New System.Windows.Forms.TextBox()
        Me.Tx_Codice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tx_Cliente = New System.Windows.Forms.TextBox()
        Me.Tx_Qt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Tx_H = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tx_L = New System.Windows.Forms.TextBox()
        Me.Tx_P = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Tx_Tipo = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Tx_Zoccoli = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Ck_Rivestimento = New System.Windows.Forms.CheckBox()
        Me.Tx_Rivestimento = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Tx_Consegna = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Ck_Diagonali = New System.Windows.Forms.CheckBox()
        Me.Ck_DT = New System.Windows.Forms.CheckBox()
        Me.Ck_BM = New System.Windows.Forms.CheckBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Ck_HT = New System.Windows.Forms.CheckBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Tx_Note1 = New System.Windows.Forms.TextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Tx_Note2 = New System.Windows.Forms.TextBox()
        Me.Txt_VaiARiga = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_TotRighe = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bt_OpenOrdine
        '
        Me.Bt_OpenOrdine.FlatAppearance.BorderSize = 0
        Me.Bt_OpenOrdine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_OpenOrdine.Image = CType(resources.GetObject("Bt_OpenOrdine.Image"), System.Drawing.Image)
        Me.Bt_OpenOrdine.Location = New System.Drawing.Point(3, 3)
        Me.Bt_OpenOrdine.Name = "Bt_OpenOrdine"
        Me.Bt_OpenOrdine.Size = New System.Drawing.Size(40, 40)
        Me.Bt_OpenOrdine.TabIndex = 0
        Me.Bt_OpenOrdine.UseVisualStyleBackColor = True
        '
        'Lbl_NumeroOrdine
        '
        Me.Lbl_NumeroOrdine.BackColor = System.Drawing.Color.White
        Me.Lbl_NumeroOrdine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_NumeroOrdine.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_NumeroOrdine.Location = New System.Drawing.Point(49, 11)
        Me.Lbl_NumeroOrdine.Name = "Lbl_NumeroOrdine"
        Me.Lbl_NumeroOrdine.Size = New System.Drawing.Size(374, 25)
        Me.Lbl_NumeroOrdine.TabIndex = 1
        Me.Lbl_NumeroOrdine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.Lbl_DataOrdine)
        Me.Panel1.Controls.Add(Me.LblTotRighe)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Bt_OpenOrdine)
        Me.Panel1.Controls.Add(Me.Lbl_NumeroOrdine)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(434, 77)
        Me.Panel1.TabIndex = 2
        '
        'Lbl_DataOrdine
        '
        Me.Lbl_DataOrdine.BackColor = System.Drawing.Color.White
        Me.Lbl_DataOrdine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_DataOrdine.Location = New System.Drawing.Point(49, 45)
        Me.Lbl_DataOrdine.Name = "Lbl_DataOrdine"
        Me.Lbl_DataOrdine.Size = New System.Drawing.Size(218, 23)
        Me.Lbl_DataOrdine.TabIndex = 4
        Me.Lbl_DataOrdine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTotRighe
        '
        Me.LblTotRighe.BackColor = System.Drawing.Color.White
        Me.LblTotRighe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotRighe.Location = New System.Drawing.Point(323, 45)
        Me.LblTotRighe.Name = "LblTotRighe"
        Me.LblTotRighe.Size = New System.Drawing.Size(100, 23)
        Me.LblTotRighe.TabIndex = 3
        Me.LblTotRighe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(276, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "RIGHE"
        '
        'Bt_Left
        '
        Me.Bt_Left.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Bt_Left.FlatAppearance.BorderSize = 0
        Me.Bt_Left.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Left.Image = CType(resources.GetObject("Bt_Left.Image"), System.Drawing.Image)
        Me.Bt_Left.Location = New System.Drawing.Point(12, 470)
        Me.Bt_Left.Name = "Bt_Left"
        Me.Bt_Left.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Left.TabIndex = 3
        Me.Bt_Left.UseVisualStyleBackColor = True
        '
        'Bt_Right
        '
        Me.Bt_Right.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Right.FlatAppearance.BorderSize = 0
        Me.Bt_Right.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Right.Image = CType(resources.GetObject("Bt_Right.Image"), System.Drawing.Image)
        Me.Bt_Right.Location = New System.Drawing.Point(403, 470)
        Me.Bt_Right.Name = "Bt_Right"
        Me.Bt_Right.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Right.TabIndex = 4
        Me.Bt_Right.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Tx_Riga)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(76, 51)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Riga"
        '
        'Tx_Riga
        '
        Me.Tx_Riga.Location = New System.Drawing.Point(6, 22)
        Me.Tx_Riga.Name = "Tx_Riga"
        Me.Tx_Riga.Size = New System.Drawing.Size(64, 20)
        Me.Tx_Riga.TabIndex = 7
        Me.Tx_Riga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Tx_Commessa)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Tx_Indice)
        Me.GroupBox2.Controls.Add(Me.Tx_Codice)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Tx_Cliente)
        Me.GroupBox2.Controls.Add(Me.Tx_Qt)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(434, 100)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dati"
        '
        'Tx_Commessa
        '
        Me.Tx_Commessa.Location = New System.Drawing.Point(283, 70)
        Me.Tx_Commessa.Name = "Tx_Commessa"
        Me.Tx_Commessa.Size = New System.Drawing.Size(140, 20)
        Me.Tx_Commessa.TabIndex = 16
        Me.Tx_Commessa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(212, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Commessa"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tx_Indice
        '
        Me.Tx_Indice.Location = New System.Drawing.Point(65, 19)
        Me.Tx_Indice.Name = "Tx_Indice"
        Me.Tx_Indice.Size = New System.Drawing.Size(140, 20)
        Me.Tx_Indice.TabIndex = 12
        Me.Tx_Indice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tx_Codice
        '
        Me.Tx_Codice.Location = New System.Drawing.Point(65, 71)
        Me.Tx_Codice.Name = "Tx_Codice"
        Me.Tx_Codice.Size = New System.Drawing.Size(140, 20)
        Me.Tx_Codice.TabIndex = 15
        Me.Tx_Codice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Indice"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(14, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Codice"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tx_Cliente
        '
        Me.Tx_Cliente.Location = New System.Drawing.Point(65, 45)
        Me.Tx_Cliente.Name = "Tx_Cliente"
        Me.Tx_Cliente.Size = New System.Drawing.Size(358, 20)
        Me.Tx_Cliente.TabIndex = 13
        Me.Tx_Cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tx_Qt
        '
        Me.Tx_Qt.Location = New System.Drawing.Point(283, 20)
        Me.Tx_Qt.Name = "Tx_Qt"
        Me.Tx_Qt.Size = New System.Drawing.Size(140, 20)
        Me.Tx_Qt.TabIndex = 14
        Me.Tx_Qt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(227, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Qt"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(14, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cliente"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Tx_H)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Tx_L)
        Me.GroupBox3.Controls.Add(Me.Tx_P)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(94, 95)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(352, 51)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dimensioni interne"
        '
        'Tx_H
        '
        Me.Tx_H.Location = New System.Drawing.Point(277, 22)
        Me.Tx_H.Name = "Tx_H"
        Me.Tx_H.Size = New System.Drawing.Size(64, 20)
        Me.Tx_H.TabIndex = 13
        Me.Tx_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(4, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "L"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(224, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "H"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tx_L
        '
        Me.Tx_L.Location = New System.Drawing.Point(34, 22)
        Me.Tx_L.Name = "Tx_L"
        Me.Tx_L.Size = New System.Drawing.Size(64, 20)
        Me.Tx_L.TabIndex = 9
        Me.Tx_L.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tx_P
        '
        Me.Tx_P.Location = New System.Drawing.Point(154, 22)
        Me.Tx_P.Name = "Tx_P"
        Me.Tx_P.Size = New System.Drawing.Size(64, 20)
        Me.Tx_P.TabIndex = 11
        Me.Tx_P.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(104, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "P"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Tx_Tipo)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 258)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(76, 51)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo"
        '
        'Tx_Tipo
        '
        Me.Tx_Tipo.Location = New System.Drawing.Point(6, 22)
        Me.Tx_Tipo.Name = "Tx_Tipo"
        Me.Tx_Tipo.Size = New System.Drawing.Size(64, 20)
        Me.Tx_Tipo.TabIndex = 7
        Me.Tx_Tipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Tx_Zoccoli)
        Me.GroupBox5.Location = New System.Drawing.Point(101, 258)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(76, 51)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Zoccoli"
        '
        'Tx_Zoccoli
        '
        Me.Tx_Zoccoli.Location = New System.Drawing.Point(6, 22)
        Me.Tx_Zoccoli.Name = "Tx_Zoccoli"
        Me.Tx_Zoccoli.Size = New System.Drawing.Size(64, 20)
        Me.Tx_Zoccoli.TabIndex = 7
        Me.Tx_Zoccoli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Ck_Rivestimento)
        Me.GroupBox6.Controls.Add(Me.Tx_Rivestimento)
        Me.GroupBox6.Location = New System.Drawing.Point(183, 258)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(106, 51)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Rivestimento"
        '
        'Ck_Rivestimento
        '
        Me.Ck_Rivestimento.AutoSize = True
        Me.Ck_Rivestimento.Location = New System.Drawing.Point(81, 25)
        Me.Ck_Rivestimento.Name = "Ck_Rivestimento"
        Me.Ck_Rivestimento.Size = New System.Drawing.Size(15, 14)
        Me.Ck_Rivestimento.TabIndex = 11
        Me.Ck_Rivestimento.UseVisualStyleBackColor = True
        '
        'Tx_Rivestimento
        '
        Me.Tx_Rivestimento.Location = New System.Drawing.Point(11, 22)
        Me.Tx_Rivestimento.Name = "Tx_Rivestimento"
        Me.Tx_Rivestimento.Size = New System.Drawing.Size(64, 20)
        Me.Tx_Rivestimento.TabIndex = 7
        Me.Tx_Rivestimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Tx_Consegna)
        Me.GroupBox7.Location = New System.Drawing.Point(295, 258)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(151, 51)
        Me.GroupBox7.TabIndex = 11
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Data Consegna"
        '
        'Tx_Consegna
        '
        Me.Tx_Consegna.Location = New System.Drawing.Point(6, 22)
        Me.Tx_Consegna.Name = "Tx_Consegna"
        Me.Tx_Consegna.Size = New System.Drawing.Size(134, 20)
        Me.Tx_Consegna.TabIndex = 7
        Me.Tx_Consegna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Ck_Diagonali)
        Me.GroupBox8.Controls.Add(Me.Ck_DT)
        Me.GroupBox8.Controls.Add(Me.Ck_BM)
        Me.GroupBox8.Location = New System.Drawing.Point(12, 315)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(382, 44)
        Me.GroupBox8.TabIndex = 12
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Caratteristiche"
        '
        'Ck_Diagonali
        '
        Me.Ck_Diagonali.AutoSize = True
        Me.Ck_Diagonali.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ck_Diagonali.Location = New System.Drawing.Point(283, 19)
        Me.Ck_Diagonali.Name = "Ck_Diagonali"
        Me.Ck_Diagonali.Size = New System.Drawing.Size(90, 17)
        Me.Ck_Diagonali.TabIndex = 15
        Me.Ck_Diagonali.Text = "Con diagonali"
        Me.Ck_Diagonali.UseVisualStyleBackColor = True
        '
        'Ck_DT
        '
        Me.Ck_DT.AutoSize = True
        Me.Ck_DT.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ck_DT.Location = New System.Drawing.Point(138, 19)
        Me.Ck_DT.Name = "Ck_DT"
        Me.Ck_DT.Size = New System.Drawing.Size(117, 17)
        Me.Ck_DT.TabIndex = 14
        Me.Ck_DT.Text = "Base doppia tavola"
        Me.Ck_DT.UseVisualStyleBackColor = True
        '
        'Ck_BM
        '
        Me.Ck_BM.AutoSize = True
        Me.Ck_BM.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ck_BM.Location = New System.Drawing.Point(9, 19)
        Me.Ck_BM.Name = "Ck_BM"
        Me.Ck_BM.Size = New System.Drawing.Size(101, 17)
        Me.Ck_BM.TabIndex = 13
        Me.Ck_BM.Text = "Base con morali"
        Me.Ck_BM.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Ck_HT)
        Me.GroupBox9.Location = New System.Drawing.Point(401, 315)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(43, 44)
        Me.GroupBox9.TabIndex = 13
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "HT"
        '
        'Ck_HT
        '
        Me.Ck_HT.AutoSize = True
        Me.Ck_HT.Location = New System.Drawing.Point(14, 19)
        Me.Ck_HT.Name = "Ck_HT"
        Me.Ck_HT.Size = New System.Drawing.Size(15, 14)
        Me.Ck_HT.TabIndex = 11
        Me.Ck_HT.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Tx_Note1)
        Me.GroupBox10.Location = New System.Drawing.Point(12, 365)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(215, 100)
        Me.GroupBox10.TabIndex = 14
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Note 1"
        '
        'Tx_Note1
        '
        Me.Tx_Note1.Location = New System.Drawing.Point(6, 19)
        Me.Tx_Note1.Multiline = True
        Me.Tx_Note1.Name = "Tx_Note1"
        Me.Tx_Note1.Size = New System.Drawing.Size(203, 75)
        Me.Tx_Note1.TabIndex = 0
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Tx_Note2)
        Me.GroupBox11.Location = New System.Drawing.Point(233, 365)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(210, 100)
        Me.GroupBox11.TabIndex = 15
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Note 2"
        '
        'Tx_Note2
        '
        Me.Tx_Note2.Location = New System.Drawing.Point(6, 19)
        Me.Tx_Note2.Multiline = True
        Me.Tx_Note2.Name = "Tx_Note2"
        Me.Tx_Note2.Size = New System.Drawing.Size(196, 75)
        Me.Tx_Note2.TabIndex = 1
        '
        'Txt_VaiARiga
        '
        Me.Txt_VaiARiga.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Txt_VaiARiga.Location = New System.Drawing.Point(170, 482)
        Me.Txt_VaiARiga.Name = "Txt_VaiARiga"
        Me.Txt_VaiARiga.Size = New System.Drawing.Size(46, 20)
        Me.Txt_VaiARiga.TabIndex = 16
        Me.Txt_VaiARiga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(222, 486)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "/"
        '
        'Txt_TotRighe
        '
        Me.Txt_TotRighe.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Txt_TotRighe.Location = New System.Drawing.Point(240, 482)
        Me.Txt_TotRighe.Name = "Txt_TotRighe"
        Me.Txt_TotRighe.ReadOnly = True
        Me.Txt_TotRighe.Size = New System.Drawing.Size(46, 20)
        Me.Txt_TotRighe.TabIndex = 19
        Me.Txt_TotRighe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form_ControlloOrdineInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(456, 522)
        Me.Controls.Add(Me.Txt_TotRighe)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Txt_VaiARiga)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Bt_Right)
        Me.Controls.Add(Me.Bt_Left)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Form_ControlloOrdineInput"
        Me.Text = "Controllo Ordine Input"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bt_OpenOrdine As Button
    Friend WithEvents Lbl_NumeroOrdine As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Bt_Left As Button
    Friend WithEvents Bt_Right As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Tx_Riga As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Tx_Commessa As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Tx_Indice As TextBox
    Friend WithEvents Tx_Codice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Tx_Cliente As TextBox
    Friend WithEvents Tx_Qt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Tx_H As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Tx_L As TextBox
    Friend WithEvents Tx_P As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Tx_Tipo As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Tx_Zoccoli As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Ck_Rivestimento As CheckBox
    Friend WithEvents Tx_Rivestimento As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Tx_Consegna As TextBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Ck_Diagonali As CheckBox
    Friend WithEvents Ck_DT As CheckBox
    Friend WithEvents Ck_BM As CheckBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Ck_HT As CheckBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Tx_Note1 As TextBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents Tx_Note2 As TextBox
    Friend WithEvents LblTotRighe As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Lbl_DataOrdine As Label
    Friend WithEvents Txt_VaiARiga As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Txt_TotRighe As TextBox
End Class
