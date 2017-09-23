<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_SetupRivestimenti
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TX_BY = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TX_BX = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TX_CY = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TX_CX = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TX_FY = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TX_FX = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TX_TY = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TX_TX = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TX_Note = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DGW_Tipi = New System.Windows.Forms.DataGridView()
        Me.BT_Salva = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGW_Tipi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TX_BY)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TX_BX)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 49)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BANCALE"
        '
        'TX_BY
        '
        Me.TX_BY.Location = New System.Drawing.Point(133, 19)
        Me.TX_BY.Name = "TX_BY"
        Me.TX_BY.Size = New System.Drawing.Size(50, 20)
        Me.TX_BY.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "P = "
        '
        'TX_BX
        '
        Me.TX_BX.Location = New System.Drawing.Point(42, 19)
        Me.TX_BX.Name = "TX_BX"
        Me.TX_BX.Size = New System.Drawing.Size(50, 20)
        Me.TX_BX.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "L = "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TX_CY)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TX_CX)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 103)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 49)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "COPERCHIO"
        '
        'TX_CY
        '
        Me.TX_CY.Location = New System.Drawing.Point(133, 19)
        Me.TX_CY.Name = "TX_CY"
        Me.TX_CY.Size = New System.Drawing.Size(50, 20)
        Me.TX_CY.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "P = "
        '
        'TX_CX
        '
        Me.TX_CX.Location = New System.Drawing.Point(42, 19)
        Me.TX_CX.Name = "TX_CX"
        Me.TX_CX.Size = New System.Drawing.Size(50, 20)
        Me.TX_CX.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "L = "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TX_FY)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TX_FX)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 158)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(192, 49)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "FIANCATE"
        '
        'TX_FY
        '
        Me.TX_FY.Location = New System.Drawing.Point(133, 19)
        Me.TX_FY.Name = "TX_FY"
        Me.TX_FY.Size = New System.Drawing.Size(50, 20)
        Me.TX_FY.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(101, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "H = "
        '
        'TX_FX
        '
        Me.TX_FX.Location = New System.Drawing.Point(42, 19)
        Me.TX_FX.Name = "TX_FX"
        Me.TX_FX.Size = New System.Drawing.Size(50, 20)
        Me.TX_FX.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "L = "
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TX_TY)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.TX_TX)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 213)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(192, 49)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TESTE"
        '
        'TX_TY
        '
        Me.TX_TY.Location = New System.Drawing.Point(133, 19)
        Me.TX_TY.Name = "TX_TY"
        Me.TX_TY.Size = New System.Drawing.Size(50, 20)
        Me.TX_TY.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(101, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "H = "
        '
        'TX_TX
        '
        Me.TX_TX.Location = New System.Drawing.Point(42, 19)
        Me.TX_TX.Name = "TX_TX"
        Me.TX_TX.Size = New System.Drawing.Size(50, 20)
        Me.TX_TX.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "P = "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(178, 26)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "VARIAZIONI RISPETTO ALLE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DIMENSIONI INTERNE"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Location = New System.Drawing.Point(289, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(225, 269)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TX_Note)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(289, 287)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(225, 68)
        Me.Panel2.TabIndex = 6
        '
        'TX_Note
        '
        Me.TX_Note.Location = New System.Drawing.Point(13, 33)
        Me.TX_Note.Name = "TX_Note"
        Me.TX_Note.Size = New System.Drawing.Size(197, 20)
        Me.TX_Note.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(91, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "NOTE"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGW_Tipi
        '
        Me.DGW_Tipi.AllowUserToAddRows = False
        Me.DGW_Tipi.AllowUserToDeleteRows = False
        Me.DGW_Tipi.AllowUserToResizeColumns = False
        Me.DGW_Tipi.AllowUserToResizeRows = False
        Me.DGW_Tipi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGW_Tipi.BackgroundColor = System.Drawing.Color.White
        Me.DGW_Tipi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_Tipi.ColumnHeadersVisible = False
        Me.DGW_Tipi.GridColor = System.Drawing.Color.White
        Me.DGW_Tipi.Location = New System.Drawing.Point(12, 12)
        Me.DGW_Tipi.MultiSelect = False
        Me.DGW_Tipi.Name = "DGW_Tipi"
        Me.DGW_Tipi.ReadOnly = True
        Me.DGW_Tipi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGW_Tipi.RowHeadersVisible = False
        Me.DGW_Tipi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGW_Tipi.Size = New System.Drawing.Size(271, 376)
        Me.DGW_Tipi.TabIndex = 7
        '
        'BT_Salva
        '
        Me.BT_Salva.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Salva.Location = New System.Drawing.Point(289, 361)
        Me.BT_Salva.Name = "BT_Salva"
        Me.BT_Salva.Size = New System.Drawing.Size(225, 27)
        Me.BT_Salva.TabIndex = 9
        Me.BT_Salva.Text = "SALVA"
        Me.BT_Salva.UseVisualStyleBackColor = True
        '
        'FRM_SetupRivestimenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(521, 397)
        Me.Controls.Add(Me.BT_Salva)
        Me.Controls.Add(Me.DGW_Tipi)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FRM_SetupRivestimenti"
        Me.Text = "Setup Rivestimenti"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGW_Tipi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TX_BY As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TX_BX As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TX_CY As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TX_CX As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TX_FY As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TX_FX As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TX_TY As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TX_TX As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TX_Note As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DGW_Tipi As DataGridView
    Friend WithEvents BT_Salva As Button
End Class
