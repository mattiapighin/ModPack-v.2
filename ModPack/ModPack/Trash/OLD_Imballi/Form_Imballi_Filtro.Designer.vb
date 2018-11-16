<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Imballi_Filtro
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.NU_H_A = New System.Windows.Forms.NumericUpDown()
        Me.NU_P_A = New System.Windows.Forms.NumericUpDown()
        Me.NU_L_A = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NU_L_Da = New System.Windows.Forms.NumericUpDown()
        Me.NU_P_Da = New System.Windows.Forms.NumericUpDown()
        Me.NU_H_Da = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.NU_Prezzo_A = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.NU_Prezzo_DA = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LST_Tipi = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LST_Zoccoli = New System.Windows.Forms.ListBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LST_Rivestimento = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.NU_H_A, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NU_P_A, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NU_L_A, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NU_L_Da, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NU_P_Da, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NU_H_Da, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.NU_Prezzo_A, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NU_Prezzo_DA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(283, 322)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Annulla"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 125)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dimensioni"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.77311!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.40336!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.21008!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.40336!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.21008!))
        Me.TableLayoutPanel2.Controls.Add(Me.NU_H_A, 4, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.NU_P_A, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.NU_L_A, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.NU_L_Da, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.NU_P_Da, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.NU_H_Da, 2, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(403, 100)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'NU_H_A
        '
        Me.NU_H_A.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NU_H_A.Location = New System.Drawing.Point(306, 73)
        Me.NU_H_A.Name = "NU_H_A"
        Me.NU_H_A.Size = New System.Drawing.Size(89, 20)
        Me.NU_H_A.TabIndex = 5
        '
        'NU_P_A
        '
        Me.NU_P_A.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NU_P_A.Location = New System.Drawing.Point(306, 39)
        Me.NU_P_A.Name = "NU_P_A"
        Me.NU_P_A.Size = New System.Drawing.Size(89, 20)
        Me.NU_P_A.TabIndex = 3
        '
        'NU_L_A
        '
        Me.NU_L_A.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NU_L_A.Location = New System.Drawing.Point(306, 6)
        Me.NU_L_A.Name = "NU_L_A"
        Me.NU_L_A.Size = New System.Drawing.Size(89, 20)
        Me.NU_L_A.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(137, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "DA"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ALTEZZA"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PROFONDITÀ"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LUNGHEZZA"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(137, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DA"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(137, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "DA"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(275, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "A"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(275, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "A"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(275, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "A"
        '
        'NU_L_Da
        '
        Me.NU_L_Da.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NU_L_Da.Location = New System.Drawing.Point(170, 6)
        Me.NU_L_Da.Name = "NU_L_Da"
        Me.NU_L_Da.Size = New System.Drawing.Size(90, 20)
        Me.NU_L_Da.TabIndex = 0
        '
        'NU_P_Da
        '
        Me.NU_P_Da.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NU_P_Da.Location = New System.Drawing.Point(170, 39)
        Me.NU_P_Da.Name = "NU_P_Da"
        Me.NU_P_Da.Size = New System.Drawing.Size(90, 20)
        Me.NU_P_Da.TabIndex = 2
        '
        'NU_H_Da
        '
        Me.NU_H_Da.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NU_H_Da.Location = New System.Drawing.Point(170, 73)
        Me.NU_H_Da.Name = "NU_H_Da"
        Me.NU_H_Da.Size = New System.Drawing.Size(90, 20)
        Me.NU_H_Da.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 62)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Prezzo"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.77311!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.40336!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.21008!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.40336!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.21008!))
        Me.TableLayoutPanel3.Controls.Add(Me.NU_Prezzo_A, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label10, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label16, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.NU_Prezzo_DA, 2, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(403, 35)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'NU_Prezzo_A
        '
        Me.NU_Prezzo_A.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NU_Prezzo_A.Location = New System.Drawing.Point(306, 7)
        Me.NU_Prezzo_A.Name = "NU_Prezzo_A"
        Me.NU_Prezzo_A.Size = New System.Drawing.Size(89, 20)
        Me.NU_Prezzo_A.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(137, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "DA"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(40, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "PREZZO"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(275, 11)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(14, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "A"
        '
        'NU_Prezzo_DA
        '
        Me.NU_Prezzo_DA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NU_Prezzo_DA.Location = New System.Drawing.Point(171, 7)
        Me.NU_Prezzo_DA.Name = "NU_Prezzo_DA"
        Me.NU_Prezzo_DA.Size = New System.Drawing.Size(89, 20)
        Me.NU_Prezzo_DA.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LST_Tipi)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 211)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(133, 100)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo"
        '
        'LST_Tipi
        '
        Me.LST_Tipi.FormattingEnabled = True
        Me.LST_Tipi.Location = New System.Drawing.Point(7, 19)
        Me.LST_Tipi.Name = "LST_Tipi"
        Me.LST_Tipi.Size = New System.Drawing.Size(120, 69)
        Me.LST_Tipi.TabIndex = 8
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LST_Zoccoli)
        Me.GroupBox4.Location = New System.Drawing.Point(151, 211)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(123, 100)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Zoccoli"
        '
        'LST_Zoccoli
        '
        Me.LST_Zoccoli.FormattingEnabled = True
        Me.LST_Zoccoli.Location = New System.Drawing.Point(6, 19)
        Me.LST_Zoccoli.Name = "LST_Zoccoli"
        Me.LST_Zoccoli.Size = New System.Drawing.Size(110, 69)
        Me.LST_Zoccoli.TabIndex = 9
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LST_Rivestimento)
        Me.GroupBox5.Location = New System.Drawing.Point(280, 211)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(147, 100)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Rivestimento"
        '
        'LST_Rivestimento
        '
        Me.LST_Rivestimento.FormattingEnabled = True
        Me.LST_Rivestimento.Location = New System.Drawing.Point(6, 19)
        Me.LST_Rivestimento.Name = "LST_Rivestimento"
        Me.LST_Rivestimento.Size = New System.Drawing.Size(132, 69)
        Me.LST_Rivestimento.TabIndex = 10
        '
        'Form_Imballi_Filtro
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(441, 363)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Imballi_Filtro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Filtro"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.NU_H_A, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NU_P_A, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NU_L_A, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NU_L_Da, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NU_P_Da, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NU_H_Da, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.NU_Prezzo_A, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NU_Prezzo_DA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents NU_H_A As NumericUpDown
    Friend WithEvents NU_P_A As NumericUpDown
    Friend WithEvents NU_L_A As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NU_L_Da As NumericUpDown
    Friend WithEvents NU_P_Da As NumericUpDown
    Friend WithEvents NU_H_Da As NumericUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents NU_Prezzo_A As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents NU_Prezzo_DA As NumericUpDown
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LST_Tipi As ListBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents LST_Zoccoli As ListBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents LST_Rivestimento As ListBox
End Class
