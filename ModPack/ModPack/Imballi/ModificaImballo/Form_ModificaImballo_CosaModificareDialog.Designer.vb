<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ModificaImballo_CosaModificareDialog
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
        Me.Ck_RicalcoloM2 = New System.Windows.Forms.CheckBox()
        Me.Ck_RicalcoloM3 = New System.Windows.Forms.CheckBox()
        Me.Ck_RicalcoloPrezzo = New System.Windows.Forms.CheckBox()
        Me.Bt_Salva = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ck_RicalcoloM2
        '
        Me.Ck_RicalcoloM2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Ck_RicalcoloM2.AutoSize = True
        Me.Ck_RicalcoloM2.Location = New System.Drawing.Point(162, 8)
        Me.Ck_RicalcoloM2.Name = "Ck_RicalcoloM2"
        Me.Ck_RicalcoloM2.Size = New System.Drawing.Size(85, 17)
        Me.Ck_RicalcoloM2.TabIndex = 0
        Me.Ck_RicalcoloM2.Text = "Ricalcolo M²"
        Me.Ck_RicalcoloM2.UseVisualStyleBackColor = True
        '
        'Ck_RicalcoloM3
        '
        Me.Ck_RicalcoloM3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Ck_RicalcoloM3.AutoSize = True
        Me.Ck_RicalcoloM3.Location = New System.Drawing.Point(162, 41)
        Me.Ck_RicalcoloM3.Name = "Ck_RicalcoloM3"
        Me.Ck_RicalcoloM3.Size = New System.Drawing.Size(85, 17)
        Me.Ck_RicalcoloM3.TabIndex = 1
        Me.Ck_RicalcoloM3.Text = "Ricalcolo M³"
        Me.Ck_RicalcoloM3.UseVisualStyleBackColor = True
        '
        'Ck_RicalcoloPrezzo
        '
        Me.Ck_RicalcoloPrezzo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Ck_RicalcoloPrezzo.AutoSize = True
        Me.Ck_RicalcoloPrezzo.Location = New System.Drawing.Point(152, 74)
        Me.Ck_RicalcoloPrezzo.Name = "Ck_RicalcoloPrezzo"
        Me.Ck_RicalcoloPrezzo.Size = New System.Drawing.Size(105, 17)
        Me.Ck_RicalcoloPrezzo.TabIndex = 2
        Me.Ck_RicalcoloPrezzo.Text = "Ricalcolo Prezzo"
        Me.Ck_RicalcoloPrezzo.UseVisualStyleBackColor = True
        '
        'Bt_Salva
        '
        Me.Bt_Salva.Location = New System.Drawing.Point(15, 141)
        Me.Bt_Salva.Name = "Bt_Salva"
        Me.Bt_Salva.Size = New System.Drawing.Size(410, 35)
        Me.Bt_Salva.TabIndex = 3
        Me.Bt_Salva.Text = "MODIFICA"
        Me.Bt_Salva.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ATTENZIONE: Le modifiche colpiranno tutti gli indici associati all'imballo. Conti" &
    "nuare?"""
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Ck_RicalcoloM2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Ck_RicalcoloPrezzo, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Ck_RicalcoloM3, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(15, 35)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(410, 100)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'Form_ModificaImballo_CosaModificareDialog
        '
        Me.AcceptButton = Me.Bt_Salva
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 188)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bt_Salva)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form_ModificaImballo_CosaModificareDialog"
        Me.Text = "Salva"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ck_RicalcoloM2 As CheckBox
    Friend WithEvents Ck_RicalcoloM3 As CheckBox
    Friend WithEvents Ck_RicalcoloPrezzo As CheckBox
    Friend WithEvents Bt_Salva As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
