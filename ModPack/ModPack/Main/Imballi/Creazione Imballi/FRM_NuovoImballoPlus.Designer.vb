<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_NuovoImballoPlus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_NuovoImballoPlus))
        Me.Cb_Tipi = New System.Windows.Forms.ComboBox()
        Me.Cb_Rivestimenti = New System.Windows.Forms.ComboBox()
        Me.Cb_Zoccoli = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CK_Riv = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tx_Lunghezza = New System.Windows.Forms.TextBox()
        Me.Tx_Profondita = New System.Windows.Forms.TextBox()
        Me.Tx_Altezza = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.RB_DT = New System.Windows.Forms.RadioButton()
        Me.RB_BM = New System.Windows.Forms.RadioButton()
        Me.RB_BS = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Ck_HT = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Ck_Diagonali = New System.Windows.Forms.CheckBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Tx_Note1 = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Tx_Note2 = New System.Windows.Forms.TextBox()
        Me.Bt_CREA = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Ck_AutoNome = New System.Windows.Forms.CheckBox()
        Me.TxNome = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cb_Tipi
        '
        Me.Cb_Tipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Tipi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cb_Tipi.FormattingEnabled = True
        Me.Cb_Tipi.Location = New System.Drawing.Point(11, 19)
        Me.Cb_Tipi.Name = "Cb_Tipi"
        Me.Cb_Tipi.Size = New System.Drawing.Size(166, 21)
        Me.Cb_Tipi.TabIndex = 0
        '
        'Cb_Rivestimenti
        '
        Me.Cb_Rivestimenti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Rivestimenti.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cb_Rivestimenti.FormattingEnabled = True
        Me.Cb_Rivestimenti.Location = New System.Drawing.Point(32, 19)
        Me.Cb_Rivestimenti.Name = "Cb_Rivestimenti"
        Me.Cb_Rivestimenti.Size = New System.Drawing.Size(145, 21)
        Me.Cb_Rivestimenti.TabIndex = 1
        '
        'Cb_Zoccoli
        '
        Me.Cb_Zoccoli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Zoccoli.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cb_Zoccoli.FormattingEnabled = True
        Me.Cb_Zoccoli.Location = New System.Drawing.Point(11, 19)
        Me.Cb_Zoccoli.Name = "Cb_Zoccoli"
        Me.Cb_Zoccoli.Size = New System.Drawing.Size(85, 21)
        Me.Cb_Zoccoli.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cb_Tipi)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(185, 48)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo Imballo"
        '
        'CK_Riv
        '
        Me.CK_Riv.AutoSize = True
        Me.CK_Riv.Location = New System.Drawing.Point(11, 22)
        Me.CK_Riv.Name = "CK_Riv"
        Me.CK_Riv.Size = New System.Drawing.Size(15, 14)
        Me.CK_Riv.TabIndex = 4
        Me.CK_Riv.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Cb_Rivestimenti)
        Me.GroupBox2.Controls.Add(Me.CK_Riv)
        Me.GroupBox2.Location = New System.Drawing.Point(315, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(185, 48)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rivestimento"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Cb_Zoccoli)
        Me.GroupBox3.Location = New System.Drawing.Point(203, 61)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(106, 48)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Zoccoli"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 115)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(488, 62)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dimensioni Interne"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.98784!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.98262!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.03215!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.98262!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.03215!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.98262!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Tx_Lunghezza, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Tx_Profondita, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Tx_Altezza, 5, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(482, 43)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(324, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Altezza"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Profondità"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Lunghezza"
        '
        'Tx_Lunghezza
        '
        Me.Tx_Lunghezza.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Tx_Lunghezza.Location = New System.Drawing.Point(70, 11)
        Me.Tx_Lunghezza.Name = "Tx_Lunghezza"
        Me.Tx_Lunghezza.Size = New System.Drawing.Size(90, 20)
        Me.Tx_Lunghezza.TabIndex = 11
        Me.Tx_Lunghezza.Text = "0"
        Me.Tx_Lunghezza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tx_Profondita
        '
        Me.Tx_Profondita.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Tx_Profondita.Location = New System.Drawing.Point(228, 11)
        Me.Tx_Profondita.Name = "Tx_Profondita"
        Me.Tx_Profondita.Size = New System.Drawing.Size(90, 20)
        Me.Tx_Profondita.TabIndex = 12
        Me.Tx_Profondita.Text = "0"
        Me.Tx_Profondita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tx_Altezza
        '
        Me.Tx_Altezza.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Tx_Altezza.Location = New System.Drawing.Point(386, 11)
        Me.Tx_Altezza.Name = "Tx_Altezza"
        Me.Tx_Altezza.Size = New System.Drawing.Size(93, 20)
        Me.Tx_Altezza.TabIndex = 13
        Me.Tx_Altezza.Text = "0"
        Me.Tx_Altezza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 183)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Caratteristiche"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.RB_DT, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.RB_BM, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.RB_BS, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(194, 81)
        Me.TableLayoutPanel2.TabIndex = 10
        '
        'RB_DT
        '
        Me.RB_DT.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RB_DT.AutoSize = True
        Me.RB_DT.Location = New System.Drawing.Point(3, 59)
        Me.RB_DT.Name = "RB_DT"
        Me.RB_DT.Size = New System.Drawing.Size(116, 17)
        Me.RB_DT.TabIndex = 1
        Me.RB_DT.Text = "Base doppia tavola"
        Me.RB_DT.UseVisualStyleBackColor = True
        '
        'RB_BM
        '
        Me.RB_BM.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RB_BM.AutoSize = True
        Me.RB_BM.Location = New System.Drawing.Point(3, 32)
        Me.RB_BM.Name = "RB_BM"
        Me.RB_BM.Size = New System.Drawing.Size(100, 17)
        Me.RB_BM.TabIndex = 0
        Me.RB_BM.Text = "Base con morali"
        Me.RB_BM.UseVisualStyleBackColor = True
        '
        'RB_BS
        '
        Me.RB_BS.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RB_BS.AutoSize = True
        Me.RB_BS.Checked = True
        Me.RB_BS.Location = New System.Drawing.Point(3, 5)
        Me.RB_BS.Name = "RB_BS"
        Me.RB_BS.Size = New System.Drawing.Size(93, 17)
        Me.RB_BS.TabIndex = 9
        Me.RB_BS.TabStop = True
        Me.RB_BS.Text = "Base semplice"
        Me.RB_BS.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Ck_HT)
        Me.GroupBox6.Location = New System.Drawing.Point(218, 183)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 49)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Trattamento"
        '
        'Ck_HT
        '
        Me.Ck_HT.Appearance = System.Windows.Forms.Appearance.Button
        Me.Ck_HT.AutoSize = True
        Me.Ck_HT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ck_HT.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Ck_HT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ck_HT.Location = New System.Drawing.Point(3, 16)
        Me.Ck_HT.Name = "Ck_HT"
        Me.Ck_HT.Size = New System.Drawing.Size(194, 30)
        Me.Ck_HT.TabIndex = 0
        Me.Ck_HT.Text = "HT"
        Me.Ck_HT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Ck_HT.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Ck_Diagonali)
        Me.GroupBox7.Location = New System.Drawing.Point(218, 238)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(200, 45)
        Me.GroupBox7.TabIndex = 10
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Diagonali"
        '
        'Ck_Diagonali
        '
        Me.Ck_Diagonali.AutoSize = True
        Me.Ck_Diagonali.Location = New System.Drawing.Point(6, 19)
        Me.Ck_Diagonali.Name = "Ck_Diagonali"
        Me.Ck_Diagonali.Size = New System.Drawing.Size(90, 17)
        Me.Ck_Diagonali.TabIndex = 0
        Me.Ck_Diagonali.Text = "Con diagonali"
        Me.Ck_Diagonali.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Tx_Note1)
        Me.GroupBox8.Location = New System.Drawing.Point(12, 289)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(200, 160)
        Me.GroupBox8.TabIndex = 11
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Note 1"
        '
        'Tx_Note1
        '
        Me.Tx_Note1.Location = New System.Drawing.Point(6, 19)
        Me.Tx_Note1.MaxLength = 200
        Me.Tx_Note1.Multiline = True
        Me.Tx_Note1.Name = "Tx_Note1"
        Me.Tx_Note1.Size = New System.Drawing.Size(188, 135)
        Me.Tx_Note1.TabIndex = 0
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Tx_Note2)
        Me.GroupBox9.Location = New System.Drawing.Point(218, 289)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(200, 160)
        Me.GroupBox9.TabIndex = 12
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Note 2"
        '
        'Tx_Note2
        '
        Me.Tx_Note2.Location = New System.Drawing.Point(9, 19)
        Me.Tx_Note2.MaxLength = 200
        Me.Tx_Note2.Multiline = True
        Me.Tx_Note2.Name = "Tx_Note2"
        Me.Tx_Note2.Size = New System.Drawing.Size(185, 135)
        Me.Tx_Note2.TabIndex = 1
        '
        'Bt_CREA
        '
        Me.Bt_CREA.Location = New System.Drawing.Point(424, 408)
        Me.Bt_CREA.Name = "Bt_CREA"
        Me.Bt_CREA.Size = New System.Drawing.Size(76, 41)
        Me.Bt_CREA.TabIndex = 13
        Me.Bt_CREA.Text = "CREA"
        Me.Bt_CREA.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Ck_AutoNome)
        Me.GroupBox10.Controls.Add(Me.TxNome)
        Me.GroupBox10.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(488, 49)
        Me.GroupBox10.TabIndex = 14
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Nome"
        '
        'Ck_AutoNome
        '
        Me.Ck_AutoNome.AutoSize = True
        Me.Ck_AutoNome.Location = New System.Drawing.Point(401, 21)
        Me.Ck_AutoNome.Name = "Ck_AutoNome"
        Me.Ck_AutoNome.Size = New System.Drawing.Size(79, 17)
        Me.Ck_AutoNome.TabIndex = 1
        Me.Ck_AutoNome.Text = "Automatico"
        Me.Ck_AutoNome.UseVisualStyleBackColor = True
        '
        'TxNome
        '
        Me.TxNome.Location = New System.Drawing.Point(11, 19)
        Me.TxNome.Name = "TxNome"
        Me.TxNome.Size = New System.Drawing.Size(384, 20)
        Me.TxNome.TabIndex = 0
        '
        'FRM_NuovoImballoPlus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 459)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.Bt_CREA)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_NuovoImballoPlus"
        Me.Text = "Nuovo Imballo PLUS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Cb_Tipi As ComboBox
    Friend WithEvents Cb_Rivestimenti As ComboBox
    Friend WithEvents Cb_Zoccoli As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CK_Riv As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Tx_Lunghezza As TextBox
    Friend WithEvents Tx_Profondita As TextBox
    Friend WithEvents Tx_Altezza As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents RB_DT As RadioButton
    Friend WithEvents RB_BM As RadioButton
    Friend WithEvents RB_BS As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Ck_HT As CheckBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Ck_Diagonali As CheckBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Tx_Note1 As TextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Tx_Note2 As TextBox
    Friend WithEvents Bt_CREA As Button
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Ck_AutoNome As CheckBox
    Friend WithEvents TxNome As TextBox
End Class
