<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opzioni
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Bt_BrowseFolders = New System.Windows.Forms.Button()
        Me.TxtFolder = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Bt_ColoreAvviso = New System.Windows.Forms.Button()
        Me.Ck_Avviso = New System.Windows.Forms.CheckBox()
        Me.Nu_Timer = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Bt_SfondoTabella = New System.Windows.Forms.Button()
        Me.CBFonts = New System.Windows.Forms.ComboBox()
        Me.Ck_Nascondi = New System.Windows.Forms.CheckBox()
        Me.Bt_TestoSelezione = New System.Windows.Forms.Button()
        Me.Ck_Fullscreen = New System.Windows.Forms.CheckBox()
        Me.Bt_Selezione = New System.Windows.Forms.Button()
        Me.Nu_SizeFont = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Nu_Timer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Nu_SizeFont, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(255, 301)
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
        Me.GroupBox1.Controls.Add(Me.Bt_BrowseFolders)
        Me.GroupBox1.Controls.Add(Me.TxtFolder)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 48)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Folder"
        '
        'Bt_BrowseFolders
        '
        Me.Bt_BrowseFolders.Location = New System.Drawing.Point(348, 19)
        Me.Bt_BrowseFolders.Name = "Bt_BrowseFolders"
        Me.Bt_BrowseFolders.Size = New System.Drawing.Size(33, 23)
        Me.Bt_BrowseFolders.TabIndex = 1
        Me.Bt_BrowseFolders.Text = "..."
        Me.Bt_BrowseFolders.UseVisualStyleBackColor = True
        '
        'TxtFolder
        '
        Me.TxtFolder.Location = New System.Drawing.Point(6, 19)
        Me.TxtFolder.Name = "TxtFolder"
        Me.TxtFolder.Size = New System.Drawing.Size(336, 20)
        Me.TxtFolder.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Bt_ColoreAvviso)
        Me.GroupBox2.Controls.Add(Me.Ck_Avviso)
        Me.GroupBox2.Controls.Add(Me.Nu_Timer)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(389, 81)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Aggiornamento"
        '
        'Bt_ColoreAvviso
        '
        Me.Bt_ColoreAvviso.Location = New System.Drawing.Point(107, 50)
        Me.Bt_ColoreAvviso.Name = "Bt_ColoreAvviso"
        Me.Bt_ColoreAvviso.Size = New System.Drawing.Size(144, 21)
        Me.Bt_ColoreAvviso.TabIndex = 5
        Me.Bt_ColoreAvviso.Text = "Colore avviso"
        Me.Bt_ColoreAvviso.UseVisualStyleBackColor = True
        '
        'Ck_Avviso
        '
        Me.Ck_Avviso.AutoSize = True
        Me.Ck_Avviso.Location = New System.Drawing.Point(9, 53)
        Me.Ck_Avviso.Name = "Ck_Avviso"
        Me.Ck_Avviso.Size = New System.Drawing.Size(92, 17)
        Me.Ck_Avviso.TabIndex = 2
        Me.Ck_Avviso.Text = "Mostra avviso"
        Me.Ck_Avviso.UseVisualStyleBackColor = True
        '
        'Nu_Timer
        '
        Me.Nu_Timer.Location = New System.Drawing.Point(91, 20)
        Me.Nu_Timer.Name = "Nu_Timer"
        Me.Nu_Timer.Size = New System.Drawing.Size(120, 20)
        Me.Nu_Timer.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Timer (secondi)"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Bt_SfondoTabella)
        Me.GroupBox3.Controls.Add(Me.CBFonts)
        Me.GroupBox3.Controls.Add(Me.Ck_Nascondi)
        Me.GroupBox3.Controls.Add(Me.Bt_TestoSelezione)
        Me.GroupBox3.Controls.Add(Me.Ck_Fullscreen)
        Me.GroupBox3.Controls.Add(Me.Bt_Selezione)
        Me.GroupBox3.Controls.Add(Me.Nu_SizeFont)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 153)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(389, 136)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Interfaccia"
        '
        'Bt_SfondoTabella
        '
        Me.Bt_SfondoTabella.Location = New System.Drawing.Point(233, 105)
        Me.Bt_SfondoTabella.Name = "Bt_SfondoTabella"
        Me.Bt_SfondoTabella.Size = New System.Drawing.Size(144, 21)
        Me.Bt_SfondoTabella.TabIndex = 7
        Me.Bt_SfondoTabella.Text = "Sfondo tabella"
        Me.Bt_SfondoTabella.UseVisualStyleBackColor = True
        '
        'CBFonts
        '
        Me.CBFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFonts.FormattingEnabled = True
        Me.CBFonts.Location = New System.Drawing.Point(233, 24)
        Me.CBFonts.Name = "CBFonts"
        Me.CBFonts.Size = New System.Drawing.Size(144, 21)
        Me.CBFonts.TabIndex = 4
        '
        'Ck_Nascondi
        '
        Me.Ck_Nascondi.AutoSize = True
        Me.Ck_Nascondi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ck_Nascondi.Location = New System.Drawing.Point(24, 79)
        Me.Ck_Nascondi.Name = "Ck_Nascondi"
        Me.Ck_Nascondi.Size = New System.Drawing.Size(203, 17)
        Me.Ck_Nascondi.TabIndex = 4
        Me.Ck_Nascondi.Text = "Riduci a icona di notifica quando esci"
        Me.Ck_Nascondi.UseVisualStyleBackColor = True
        '
        'Bt_TestoSelezione
        '
        Me.Bt_TestoSelezione.Location = New System.Drawing.Point(233, 78)
        Me.Bt_TestoSelezione.Name = "Bt_TestoSelezione"
        Me.Bt_TestoSelezione.Size = New System.Drawing.Size(144, 21)
        Me.Bt_TestoSelezione.TabIndex = 5
        Me.Bt_TestoSelezione.Text = "Testo cella selezionata"
        Me.Bt_TestoSelezione.UseVisualStyleBackColor = True
        '
        'Ck_Fullscreen
        '
        Me.Ck_Fullscreen.AutoSize = True
        Me.Ck_Fullscreen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ck_Fullscreen.Location = New System.Drawing.Point(130, 53)
        Me.Ck_Fullscreen.Name = "Ck_Fullscreen"
        Me.Ck_Fullscreen.Size = New System.Drawing.Size(97, 17)
        Me.Ck_Fullscreen.TabIndex = 6
        Me.Ck_Fullscreen.Text = "Schermo intero"
        Me.Ck_Fullscreen.UseVisualStyleBackColor = True
        '
        'Bt_Selezione
        '
        Me.Bt_Selezione.Location = New System.Drawing.Point(233, 51)
        Me.Bt_Selezione.Name = "Bt_Selezione"
        Me.Bt_Selezione.Size = New System.Drawing.Size(144, 21)
        Me.Bt_Selezione.TabIndex = 4
        Me.Bt_Selezione.Text = "Sfondo cella selezionata"
        Me.Bt_Selezione.UseVisualStyleBackColor = True
        '
        'Nu_SizeFont
        '
        Me.Nu_SizeFont.Location = New System.Drawing.Point(155, 24)
        Me.Nu_SizeFont.Name = "Nu_SizeFont"
        Me.Nu_SizeFont.Size = New System.Drawing.Size(72, 20)
        Me.Nu_SizeFont.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dimensione carattere tabella: "
        '
        'Opzioni
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(413, 342)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Opzioni"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Opzioni"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Nu_Timer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Nu_SizeFont, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Bt_BrowseFolders As Button
    Friend WithEvents TxtFolder As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Ck_Avviso As CheckBox
    Friend WithEvents Nu_Timer As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Nu_SizeFont As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Bt_Selezione As Button
    Friend WithEvents Bt_TestoSelezione As Button
    Friend WithEvents Ck_Nascondi As CheckBox
    Friend WithEvents Ck_Fullscreen As CheckBox
    Friend WithEvents CBFonts As ComboBox
    Friend WithEvents Bt_ColoreAvviso As Button
    Friend WithEvents Bt_SfondoTabella As Button
End Class
