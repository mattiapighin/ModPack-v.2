<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ModificaCodice
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
        Me.Panel_Modifica = New System.Windows.Forms.Panel()
        Me.Tx_NuovoCodice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BT_Start = New System.Windows.Forms.Button()
        Me.Lbl_Info = New System.Windows.Forms.Label()
        Me.Progress = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Ck_TabDistinta = New System.Windows.Forms.CheckBox()
        Me.Ck_TabOrdini = New System.Windows.Forms.CheckBox()
        Me.Ck_TabIndici = New System.Windows.Forms.CheckBox()
        Me.Ck_TabImballi = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CB_VecchioCodice = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bt_Cerca = New System.Windows.Forms.Button()
        Me.Bt_Annulla = New System.Windows.Forms.Button()
        Me.Panel_Modifica.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Modifica
        '
        Me.Panel_Modifica.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel_Modifica.Controls.Add(Me.Tx_NuovoCodice)
        Me.Panel_Modifica.Controls.Add(Me.Label2)
        Me.Panel_Modifica.Controls.Add(Me.BT_Start)
        Me.Panel_Modifica.Controls.Add(Me.Lbl_Info)
        Me.Panel_Modifica.Controls.Add(Me.Progress)
        Me.Panel_Modifica.Controls.Add(Me.GroupBox1)
        Me.Panel_Modifica.Location = New System.Drawing.Point(12, 45)
        Me.Panel_Modifica.Name = "Panel_Modifica"
        Me.Panel_Modifica.Size = New System.Drawing.Size(329, 324)
        Me.Panel_Modifica.TabIndex = 13
        '
        'Tx_NuovoCodice
        '
        Me.Tx_NuovoCodice.Location = New System.Drawing.Point(95, 11)
        Me.Tx_NuovoCodice.Name = "Tx_NuovoCodice"
        Me.Tx_NuovoCodice.Size = New System.Drawing.Size(219, 20)
        Me.Tx_NuovoCodice.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nuovo Codice"
        '
        'BT_Start
        '
        Me.BT_Start.Location = New System.Drawing.Point(11, 237)
        Me.BT_Start.Name = "BT_Start"
        Me.BT_Start.Size = New System.Drawing.Size(303, 47)
        Me.BT_Start.TabIndex = 12
        Me.BT_Start.Text = "AVVIA MODIFICA"
        Me.BT_Start.UseVisualStyleBackColor = True
        '
        'Lbl_Info
        '
        Me.Lbl_Info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Info.Location = New System.Drawing.Point(11, 41)
        Me.Lbl_Info.Name = "Lbl_Info"
        Me.Lbl_Info.Size = New System.Drawing.Size(303, 76)
        Me.Lbl_Info.TabIndex = 4
        Me.Lbl_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Progress
        '
        Me.Progress.Location = New System.Drawing.Point(11, 290)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(303, 23)
        Me.Progress.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 111)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modificare"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Ck_TabDistinta, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Ck_TabOrdini, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Ck_TabIndici, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Ck_TabImballi, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(297, 92)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'Ck_TabDistinta
        '
        Me.Ck_TabDistinta.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Ck_TabDistinta.AutoSize = True
        Me.Ck_TabDistinta.Checked = True
        Me.Ck_TabDistinta.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Ck_TabDistinta.Location = New System.Drawing.Point(151, 60)
        Me.Ck_TabDistinta.Name = "Ck_TabDistinta"
        Me.Ck_TabDistinta.Size = New System.Drawing.Size(99, 17)
        Me.Ck_TabDistinta.TabIndex = 8
        Me.Ck_TabDistinta.Text = "Tabella Distinte"
        Me.Ck_TabDistinta.UseVisualStyleBackColor = True
        '
        'Ck_TabOrdini
        '
        Me.Ck_TabOrdini.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Ck_TabOrdini.AutoSize = True
        Me.Ck_TabOrdini.Checked = True
        Me.Ck_TabOrdini.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Ck_TabOrdini.Location = New System.Drawing.Point(3, 14)
        Me.Ck_TabOrdini.Name = "Ck_TabOrdini"
        Me.Ck_TabOrdini.Size = New System.Drawing.Size(91, 17)
        Me.Ck_TabOrdini.TabIndex = 5
        Me.Ck_TabOrdini.Text = "Tabella Ordini"
        Me.Ck_TabOrdini.UseVisualStyleBackColor = True
        '
        'Ck_TabIndici
        '
        Me.Ck_TabIndici.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Ck_TabIndici.AutoSize = True
        Me.Ck_TabIndici.Checked = True
        Me.Ck_TabIndici.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Ck_TabIndici.Location = New System.Drawing.Point(151, 14)
        Me.Ck_TabIndici.Name = "Ck_TabIndici"
        Me.Ck_TabIndici.Size = New System.Drawing.Size(89, 17)
        Me.Ck_TabIndici.TabIndex = 7
        Me.Ck_TabIndici.Text = "Tabella Indici"
        Me.Ck_TabIndici.UseVisualStyleBackColor = True
        '
        'Ck_TabImballi
        '
        Me.Ck_TabImballi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Ck_TabImballi.AutoSize = True
        Me.Ck_TabImballi.Checked = True
        Me.Ck_TabImballi.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Ck_TabImballi.Location = New System.Drawing.Point(3, 60)
        Me.Ck_TabImballi.Name = "Ck_TabImballi"
        Me.Ck_TabImballi.Size = New System.Drawing.Size(93, 17)
        Me.Ck_TabImballi.TabIndex = 6
        Me.Ck_TabImballi.Text = "Tabella Imballi"
        Me.Ck_TabImballi.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CB_VecchioCodice)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Bt_Cerca)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(329, 27)
        Me.Panel1.TabIndex = 12
        '
        'CB_VecchioCodice
        '
        Me.CB_VecchioCodice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_VecchioCodice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_VecchioCodice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_VecchioCodice.FormattingEnabled = True
        Me.CB_VecchioCodice.Location = New System.Drawing.Point(96, 3)
        Me.CB_VecchioCodice.MaxDropDownItems = 5
        Me.CB_VecchioCodice.Name = "CB_VecchioCodice"
        Me.CB_VecchioCodice.Size = New System.Drawing.Size(149, 21)
        Me.CB_VecchioCodice.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vecchio Codice"
        '
        'Bt_Cerca
        '
        Me.Bt_Cerca.Location = New System.Drawing.Point(251, 3)
        Me.Bt_Cerca.Name = "Bt_Cerca"
        Me.Bt_Cerca.Size = New System.Drawing.Size(75, 21)
        Me.Bt_Cerca.TabIndex = 2
        Me.Bt_Cerca.Text = "Cerca"
        Me.Bt_Cerca.UseVisualStyleBackColor = True
        '
        'Bt_Annulla
        '
        Me.Bt_Annulla.Location = New System.Drawing.Point(12, 375)
        Me.Bt_Annulla.Name = "Bt_Annulla"
        Me.Bt_Annulla.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Annulla.TabIndex = 14
        Me.Bt_Annulla.Text = "Annulla"
        Me.Bt_Annulla.UseVisualStyleBackColor = True
        '
        'Form_ModificaCodice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 407)
        Me.Controls.Add(Me.Bt_Annulla)
        Me.Controls.Add(Me.Panel_Modifica)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_ModificaCodice"
        Me.Text = "Form_ModificaCodice"
        Me.Panel_Modifica.ResumeLayout(False)
        Me.Panel_Modifica.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Modifica As Panel
    Friend WithEvents Tx_NuovoCodice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BT_Start As Button
    Friend WithEvents Lbl_Info As Label
    Friend WithEvents Progress As ProgressBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Ck_TabDistinta As CheckBox
    Friend WithEvents Ck_TabOrdini As CheckBox
    Friend WithEvents Ck_TabIndici As CheckBox
    Friend WithEvents Ck_TabImballi As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CB_VecchioCodice As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Bt_Cerca As Button
    Friend WithEvents Bt_Annulla As Button
End Class
