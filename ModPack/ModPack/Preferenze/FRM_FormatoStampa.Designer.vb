<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_FormatoStampa
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tx_Top = New System.Windows.Forms.TextBox()
        Me.Tx_Bottom = New System.Windows.Forms.TextBox()
        Me.Tx_Left = New System.Windows.Forms.TextBox()
        Me.Tx_Right = New System.Windows.Forms.TextBox()
        Me.Ck_Colore = New System.Windows.Forms.CheckBox()
        Me.Ck_Landscape = New System.Windows.Forms.CheckBox()
        Me.Bt_Salva = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Margine TOP"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Tx_Top, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Tx_Bottom, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Tx_Left, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Tx_Right, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Ck_Colore, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Ck_Landscape, 1, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(239, 170)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Margine BOTTOM"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Margine LEFT"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Margine RIGHT"
        '
        'Tx_Top
        '
        Me.Tx_Top.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tx_Top.Location = New System.Drawing.Point(129, 7)
        Me.Tx_Top.Name = "Tx_Top"
        Me.Tx_Top.Size = New System.Drawing.Size(100, 20)
        Me.Tx_Top.TabIndex = 2
        '
        'Tx_Bottom
        '
        Me.Tx_Bottom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tx_Bottom.Location = New System.Drawing.Point(129, 41)
        Me.Tx_Bottom.Name = "Tx_Bottom"
        Me.Tx_Bottom.Size = New System.Drawing.Size(100, 20)
        Me.Tx_Bottom.TabIndex = 3
        '
        'Tx_Left
        '
        Me.Tx_Left.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tx_Left.Location = New System.Drawing.Point(129, 75)
        Me.Tx_Left.Name = "Tx_Left"
        Me.Tx_Left.Size = New System.Drawing.Size(100, 20)
        Me.Tx_Left.TabIndex = 4
        '
        'Tx_Right
        '
        Me.Tx_Right.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tx_Right.Location = New System.Drawing.Point(129, 109)
        Me.Tx_Right.Name = "Tx_Right"
        Me.Tx_Right.Size = New System.Drawing.Size(100, 20)
        Me.Tx_Right.TabIndex = 5
        '
        'Ck_Colore
        '
        Me.Ck_Colore.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Ck_Colore.AutoSize = True
        Me.Ck_Colore.Location = New System.Drawing.Point(31, 144)
        Me.Ck_Colore.Name = "Ck_Colore"
        Me.Ck_Colore.Size = New System.Drawing.Size(56, 17)
        Me.Ck_Colore.TabIndex = 6
        Me.Ck_Colore.Text = "Colore"
        Me.Ck_Colore.UseVisualStyleBackColor = True
        '
        'Ck_Landscape
        '
        Me.Ck_Landscape.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Ck_Landscape.AutoSize = True
        Me.Ck_Landscape.Location = New System.Drawing.Point(139, 144)
        Me.Ck_Landscape.Name = "Ck_Landscape"
        Me.Ck_Landscape.Size = New System.Drawing.Size(79, 17)
        Me.Ck_Landscape.TabIndex = 7
        Me.Ck_Landscape.Text = "Landscape"
        Me.Ck_Landscape.UseVisualStyleBackColor = True
        '
        'Bt_Salva
        '
        Me.Bt_Salva.Location = New System.Drawing.Point(11, 188)
        Me.Bt_Salva.Name = "Bt_Salva"
        Me.Bt_Salva.Size = New System.Drawing.Size(239, 23)
        Me.Bt_Salva.TabIndex = 2
        Me.Bt_Salva.Text = "Salva"
        Me.Bt_Salva.UseVisualStyleBackColor = True
        '
        'FRM_FormatoStampa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 219)
        Me.Controls.Add(Me.Bt_Salva)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FRM_FormatoStampa"
        Me.Text = "Formato Stampa"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Tx_Top As TextBox
    Friend WithEvents Tx_Bottom As TextBox
    Friend WithEvents Tx_Left As TextBox
    Friend WithEvents Tx_Right As TextBox
    Friend WithEvents Ck_Colore As CheckBox
    Friend WithEvents Ck_Landscape As CheckBox
    Friend WithEvents Bt_Salva As Button
End Class
