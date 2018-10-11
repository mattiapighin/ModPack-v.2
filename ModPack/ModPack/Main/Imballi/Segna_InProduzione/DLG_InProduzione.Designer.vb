<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DLG_InProduzione
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
        Me.Tx_ID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LB_CodBicc = New System.Windows.Forms.Label()
        Me.LB_CodModine = New System.Windows.Forms.Label()
        Me.Lb_Commessa = New System.Windows.Forms.Label()
        Me.Lb_Cliente = New System.Windows.Forms.Label()
        Me.Lb_PZ = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BT_InProduzione = New System.Windows.Forms.Button()
        Me.Ck_Barcode = New System.Windows.Forms.CheckBox()
        Me.Lbl_Update = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tx_ID
        '
        Me.Tx_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tx_ID.Location = New System.Drawing.Point(6, 16)
        Me.Tx_ID.Name = "Tx_ID"
        Me.Tx_ID.Size = New System.Drawing.Size(388, 20)
        Me.Tx_ID.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Tx_ID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 44)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ID Articolo"
        '
        'LB_CodBicc
        '
        Me.LB_CodBicc.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_CodBicc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LB_CodBicc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_CodBicc.Location = New System.Drawing.Point(3, 46)
        Me.LB_CodBicc.Name = "LB_CodBicc"
        Me.LB_CodBicc.Size = New System.Drawing.Size(262, 30)
        Me.LB_CodBicc.TabIndex = 2
        Me.LB_CodBicc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LB_CodModine
        '
        Me.LB_CodModine.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_CodModine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.LB_CodModine, 3)
        Me.LB_CodModine.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_CodModine.Location = New System.Drawing.Point(3, 87)
        Me.LB_CodModine.Name = "LB_CodModine"
        Me.LB_CodModine.Size = New System.Drawing.Size(394, 30)
        Me.LB_CodModine.TabIndex = 2
        Me.LB_CodModine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lb_Commessa
        '
        Me.Lb_Commessa.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb_Commessa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.Lb_Commessa, 3)
        Me.Lb_Commessa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Commessa.Location = New System.Drawing.Point(3, 128)
        Me.Lb_Commessa.Name = "Lb_Commessa"
        Me.Lb_Commessa.Size = New System.Drawing.Size(394, 30)
        Me.Lb_Commessa.TabIndex = 2
        Me.Lb_Commessa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lb_Cliente
        '
        Me.Lb_Cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.Lb_Cliente, 3)
        Me.Lb_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Cliente.Location = New System.Drawing.Point(3, 5)
        Me.Lb_Cliente.Name = "Lb_Cliente"
        Me.Lb_Cliente.Size = New System.Drawing.Size(394, 30)
        Me.Lb_Cliente.TabIndex = 2
        Me.Lb_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lb_PZ
        '
        Me.Lb_PZ.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb_PZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb_PZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_PZ.Location = New System.Drawing.Point(318, 46)
        Me.Lb_PZ.Name = "Lb_PZ"
        Me.Lb_PZ.Size = New System.Drawing.Size(79, 30)
        Me.Lb_PZ.TabIndex = 2
        Me.Lb_PZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.07937!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.92064!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Lb_Cliente, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Lb_Commessa, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LB_CodBicc, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LB_CodModine, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Lb_PZ, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 85)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(400, 164)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'BT_InProduzione
        '
        Me.BT_InProduzione.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_InProduzione.Location = New System.Drawing.Point(12, 255)
        Me.BT_InProduzione.Name = "BT_InProduzione"
        Me.BT_InProduzione.Size = New System.Drawing.Size(400, 36)
        Me.BT_InProduzione.TabIndex = 4
        Me.BT_InProduzione.Text = "INIZIO PRODUZIONE"
        Me.BT_InProduzione.UseVisualStyleBackColor = True
        '
        'Ck_Barcode
        '
        Me.Ck_Barcode.AutoSize = True
        Me.Ck_Barcode.Location = New System.Drawing.Point(303, 62)
        Me.Ck_Barcode.Name = "Ck_Barcode"
        Me.Ck_Barcode.Size = New System.Drawing.Size(109, 17)
        Me.Ck_Barcode.TabIndex = 5
        Me.Ck_Barcode.Text = "Barcode Scanner"
        Me.Ck_Barcode.UseVisualStyleBackColor = True
        '
        'Lbl_Update
        '
        Me.Lbl_Update.AutoSize = True
        Me.Lbl_Update.Location = New System.Drawing.Point(15, 63)
        Me.Lbl_Update.Name = "Lbl_Update"
        Me.Lbl_Update.Size = New System.Drawing.Size(157, 13)
        Me.Lbl_Update.TabIndex = 6
        Me.Lbl_Update.Text = "Ultimo aggiornamento DataSet: "
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(273, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PZ."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DLG_InProduzione
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(424, 305)
        Me.Controls.Add(Me.Lbl_Update)
        Me.Controls.Add(Me.Ck_Barcode)
        Me.Controls.Add(Me.BT_InProduzione)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DLG_InProduzione"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inizio Produzione"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tx_ID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LB_CodBicc As Label
    Friend WithEvents LB_CodModine As Label
    Friend WithEvents Lb_Commessa As Label
    Friend WithEvents Lb_Cliente As Label
    Friend WithEvents Lb_PZ As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BT_InProduzione As Button
    Friend WithEvents Ck_Barcode As CheckBox
    Friend WithEvents Lbl_Update As Label
    Friend WithEvents Label1 As Label
End Class
