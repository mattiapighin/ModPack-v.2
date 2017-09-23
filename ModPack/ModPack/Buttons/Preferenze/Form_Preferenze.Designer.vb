<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Preferenze
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Preferenze))
        Me.Bt_FormatoStampa = New System.Windows.Forms.Button()
        Me.GB_etichette = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Txt_mmX = New System.Windows.Forms.TextBox()
        Me.Txt_mmY = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Txt_MargineTop = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_MargineRight = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_MargineBottom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_MargineLeft = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_NomeStampante = New System.Windows.Forms.TextBox()
        Me.Bt_Salva = New System.Windows.Forms.Button()
        Me.Ck_Evaso = New System.Windows.Forms.CheckBox()
        Me.Ck_ColoraScaduti = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.CK_DescrizioneClipboard = New System.Windows.Forms.CheckBox()
        Me.CkNotificaCambioIndice = New System.Windows.Forms.CheckBox()
        Me.Ck_TextMain = New System.Windows.Forms.CheckBox()
        Me.CkNoteDinamico = New System.Windows.Forms.CheckBox()
        Me.Ck_ColoraEvasi = New System.Windows.Forms.CheckBox()
        Me.Ck_CheckCaricamento = New System.Windows.Forms.CheckBox()
        Me.Txt_LimiteStorico = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CkCodiceQT = New System.Windows.Forms.RadioButton()
        Me.CkBarcodeSoloCodice = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Nu_RigheDistinta = New System.Windows.Forms.NumericUpDown()
        Me.Nu_FontDistinta = New System.Windows.Forms.NumericUpDown()
        Me.Ck_Barcode = New System.Windows.Forms.CheckBox()
        Me.Ck_BiancoNero = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RBexcel_nuovi = New System.Windows.Forms.RadioButton()
        Me.RBtext_nuovi = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtScegliExcel = New System.Windows.Forms.Label()
        Me.Bt_ScegliExcel = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Bt_SettingsEmail = New System.Windows.Forms.Button()
        Me.Bt_TestConnessioni = New System.Windows.Forms.Button()
        Me.Bt_EliminaOrdine = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.BT_SetupRives = New System.Windows.Forms.Button()
        Me.Bt_Log = New System.Windows.Forms.Button()
        Me.Bt_GestioneTipi = New System.Windows.Forms.Button()
        Me.Bt_PulisciImballi = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txt_utente = New System.Windows.Forms.TextBox()
        Me.Bt_AzzeraDB = New System.Windows.Forms.Button()
        Me.Box_Developer = New System.Windows.Forms.GroupBox()
        Me.Bt_ResetSettings = New System.Windows.Forms.Button()
        Me.Bt_InviaQuery = New System.Windows.Forms.Button()
        Me.GB_etichette.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Nu_RigheDistinta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nu_FontDistinta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.Box_Developer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bt_FormatoStampa
        '
        Me.Bt_FormatoStampa.Location = New System.Drawing.Point(6, 20)
        Me.Bt_FormatoStampa.Name = "Bt_FormatoStampa"
        Me.Bt_FormatoStampa.Size = New System.Drawing.Size(101, 23)
        Me.Bt_FormatoStampa.TabIndex = 0
        Me.Bt_FormatoStampa.Text = "Formato Stampa"
        Me.Bt_FormatoStampa.UseVisualStyleBackColor = True
        '
        'GB_etichette
        '
        Me.GB_etichette.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_etichette.Controls.Add(Me.TableLayoutPanel2)
        Me.GB_etichette.Controls.Add(Me.TableLayoutPanel1)
        Me.GB_etichette.Controls.Add(Me.Txt_NomeStampante)
        Me.GB_etichette.Location = New System.Drawing.Point(12, 12)
        Me.GB_etichette.Name = "GB_etichette"
        Me.GB_etichette.Size = New System.Drawing.Size(402, 116)
        Me.GB_etichette.TabIndex = 1
        Me.GB_etichette.TabStop = False
        Me.GB_etichette.Text = "Etichette"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.22472!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.77528!))
        Me.TableLayoutPanel2.Controls.Add(Me.Txt_mmX, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Txt_mmY, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(176, 20)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(196, 64)
        Me.TableLayoutPanel2.TabIndex = 11
        '
        'Txt_mmX
        '
        Me.Txt_mmX.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Txt_mmX.Location = New System.Drawing.Point(140, 6)
        Me.Txt_mmX.Name = "Txt_mmX"
        Me.Txt_mmX.Size = New System.Drawing.Size(49, 20)
        Me.Txt_mmX.TabIndex = 10
        '
        'Txt_mmY
        '
        Me.Txt_mmY.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Txt_mmY.Location = New System.Drawing.Point(140, 38)
        Me.Txt_mmY.Name = "Txt_mmY"
        Me.Txt_mmY.Size = New System.Drawing.Size(49, 20)
        Me.Txt_mmY.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Dimensione Etichetta X"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Dimensione Etichetta Y"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.14634!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.85366!))
        Me.TableLayoutPanel1.Controls.Add(Me.Txt_MargineTop, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Txt_MargineRight, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Txt_MargineBottom, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Txt_MargineLeft, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(164, 93)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'Txt_MargineTop
        '
        Me.Txt_MargineTop.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Txt_MargineTop.Location = New System.Drawing.Point(99, 3)
        Me.Txt_MargineTop.Name = "Txt_MargineTop"
        Me.Txt_MargineTop.Size = New System.Drawing.Size(61, 20)
        Me.Txt_MargineTop.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Margine Right"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txt_MargineRight
        '
        Me.Txt_MargineRight.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Txt_MargineRight.Location = New System.Drawing.Point(99, 72)
        Me.Txt_MargineRight.Name = "Txt_MargineRight"
        Me.Txt_MargineRight.Size = New System.Drawing.Size(61, 20)
        Me.Txt_MargineRight.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Margine Left"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txt_MargineBottom
        '
        Me.Txt_MargineBottom.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Txt_MargineBottom.Location = New System.Drawing.Point(99, 26)
        Me.Txt_MargineBottom.Name = "Txt_MargineBottom"
        Me.Txt_MargineBottom.Size = New System.Drawing.Size(61, 20)
        Me.Txt_MargineBottom.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Margine Bottom"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txt_MargineLeft
        '
        Me.Txt_MargineLeft.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Txt_MargineLeft.Location = New System.Drawing.Point(99, 49)
        Me.Txt_MargineLeft.Name = "Txt_MargineLeft"
        Me.Txt_MargineLeft.Size = New System.Drawing.Size(61, 20)
        Me.Txt_MargineLeft.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Margine Top"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txt_NomeStampante
        '
        Me.Txt_NomeStampante.Location = New System.Drawing.Point(176, 91)
        Me.Txt_NomeStampante.Name = "Txt_NomeStampante"
        Me.Txt_NomeStampante.Size = New System.Drawing.Size(189, 20)
        Me.Txt_NomeStampante.TabIndex = 11
        '
        'Bt_Salva
        '
        Me.Bt_Salva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Salva.Location = New System.Drawing.Point(564, 649)
        Me.Bt_Salva.Name = "Bt_Salva"
        Me.Bt_Salva.Size = New System.Drawing.Size(90, 38)
        Me.Bt_Salva.TabIndex = 12
        Me.Bt_Salva.Text = "Salva"
        Me.Bt_Salva.UseVisualStyleBackColor = True
        '
        'Ck_Evaso
        '
        Me.Ck_Evaso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Ck_Evaso.AutoSize = True
        Me.Ck_Evaso.Location = New System.Drawing.Point(3, 3)
        Me.Ck_Evaso.Name = "Ck_Evaso"
        Me.Ck_Evaso.Size = New System.Drawing.Size(335, 28)
        Me.Ck_Evaso.TabIndex = 2
        Me.Ck_Evaso.Text = "Chiedi conferma prima di contrassegnare un imballo come EVASO"
        Me.Ck_Evaso.UseVisualStyleBackColor = True
        '
        'Ck_ColoraScaduti
        '
        Me.Ck_ColoraScaduti.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Ck_ColoraScaduti.AutoSize = True
        Me.Ck_ColoraScaduti.Location = New System.Drawing.Point(3, 37)
        Me.Ck_ColoraScaduti.Name = "Ck_ColoraScaduti"
        Me.Ck_ColoraScaduti.Size = New System.Drawing.Size(346, 28)
        Me.Ck_ColoraScaduti.TabIndex = 13
        Me.Ck_ColoraScaduti.Text = "Evidenzia gli imballi scaduti o in scadenza nel modulo ""Ordini Aperti"""
        Me.Ck_ColoraScaduti.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox1.Controls.Add(Me.Txt_LimiteStorico)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 335)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Preferenze"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.CK_DescrizioneClipboard, 0, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.CkNotificaCambioIndice, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.Ck_Evaso, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Ck_TextMain, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Ck_ColoraScaduti, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.CkNoteDinamico, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Ck_ColoraEvasi, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Ck_CheckCaricamento, 0, 3)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(9, 48)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 8
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(384, 279)
        Me.TableLayoutPanel3.TabIndex = 31
        '
        'CK_DescrizioneClipboard
        '
        Me.CK_DescrizioneClipboard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CK_DescrizioneClipboard.AutoSize = True
        Me.CK_DescrizioneClipboard.Location = New System.Drawing.Point(3, 241)
        Me.CK_DescrizioneClipboard.Name = "CK_DescrizioneClipboard"
        Me.CK_DescrizioneClipboard.Size = New System.Drawing.Size(250, 35)
        Me.CK_DescrizioneClipboard.TabIndex = 33
        Me.CK_DescrizioneClipboard.Text = "Aggiungi numero ordine alla descrizione copiata"
        Me.CK_DescrizioneClipboard.UseVisualStyleBackColor = True
        '
        'CkNotificaCambioIndice
        '
        Me.CkNotificaCambioIndice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CkNotificaCambioIndice.AutoSize = True
        Me.CkNotificaCambioIndice.Location = New System.Drawing.Point(3, 207)
        Me.CkNotificaCambioIndice.Name = "CkNotificaCambioIndice"
        Me.CkNotificaCambioIndice.Size = New System.Drawing.Size(299, 28)
        Me.CkNotificaCambioIndice.TabIndex = 32
        Me.CkNotificaCambioIndice.Text = "Notifica lo spostamento di un indice in fase di caricamento"
        Me.CkNotificaCambioIndice.UseVisualStyleBackColor = True
        '
        'Ck_TextMain
        '
        Me.Ck_TextMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Ck_TextMain.AutoSize = True
        Me.Ck_TextMain.Location = New System.Drawing.Point(3, 173)
        Me.Ck_TextMain.Name = "Ck_TextMain"
        Me.Ck_TextMain.Size = New System.Drawing.Size(156, 28)
        Me.Ck_TextMain.TabIndex = 30
        Me.Ck_TextMain.Text = "Didascalia icone Main Form"
        Me.Ck_TextMain.UseVisualStyleBackColor = True
        '
        'CkNoteDinamico
        '
        Me.CkNoteDinamico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CkNoteDinamico.AutoSize = True
        Me.CkNoteDinamico.Location = New System.Drawing.Point(3, 139)
        Me.CkNoteDinamico.Name = "CkNoteDinamico"
        Me.CkNoteDinamico.Size = New System.Drawing.Size(243, 28)
        Me.CkNoteDinamico.TabIndex = 29
        Me.CkNoteDinamico.Text = "Button ""Note"" dinamico nel modulo ""Archivio"""
        Me.CkNoteDinamico.UseVisualStyleBackColor = True
        '
        'Ck_ColoraEvasi
        '
        Me.Ck_ColoraEvasi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Ck_ColoraEvasi.AutoSize = True
        Me.Ck_ColoraEvasi.Location = New System.Drawing.Point(3, 71)
        Me.Ck_ColoraEvasi.Name = "Ck_ColoraEvasi"
        Me.Ck_ColoraEvasi.Size = New System.Drawing.Size(267, 28)
        Me.Ck_ColoraEvasi.TabIndex = 14
        Me.Ck_ColoraEvasi.Text = "Nascondi gli imballi evasi nel modulo ""Ordini Aperti"""
        Me.Ck_ColoraEvasi.UseVisualStyleBackColor = True
        '
        'Ck_CheckCaricamento
        '
        Me.Ck_CheckCaricamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Ck_CheckCaricamento.AutoSize = True
        Me.Ck_CheckCaricamento.Location = New System.Drawing.Point(3, 105)
        Me.Ck_CheckCaricamento.Name = "Ck_CheckCaricamento"
        Me.Ck_CheckCaricamento.Size = New System.Drawing.Size(228, 28)
        Me.Ck_CheckCaricamento.TabIndex = 15
        Me.Ck_CheckCaricamento.Text = "Controllo su caricamento di ogni riga ordine"
        Me.Ck_CheckCaricamento.UseVisualStyleBackColor = True
        '
        'Txt_LimiteStorico
        '
        Me.Txt_LimiteStorico.Location = New System.Drawing.Point(154, 22)
        Me.Txt_LimiteStorico.Name = "Txt_LimiteStorico"
        Me.Txt_LimiteStorico.Size = New System.Drawing.Size(48, 20)
        Me.Txt_LimiteStorico.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(257, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Carica nello storico ultimi                      ordini (0 = tutti)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.CkCodiceQT)
        Me.GroupBox2.Controls.Add(Me.CkBarcodeSoloCodice)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Nu_RigheDistinta)
        Me.GroupBox2.Controls.Add(Me.Nu_FontDistinta)
        Me.GroupBox2.Controls.Add(Me.Ck_Barcode)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 476)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 72)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Distinte"
        '
        'CkCodiceQT
        '
        Me.CkCodiceQT.AutoSize = True
        Me.CkCodiceQT.Location = New System.Drawing.Point(75, 44)
        Me.CkCodiceQT.Name = "CkCodiceQT"
        Me.CkCodiceQT.Size = New System.Drawing.Size(77, 17)
        Me.CkCodiceQT.TabIndex = 7
        Me.CkCodiceQT.TabStop = True
        Me.CkCodiceQT.Text = "Codice | Qt"
        Me.CkCodiceQT.UseVisualStyleBackColor = True
        '
        'CkBarcodeSoloCodice
        '
        Me.CkBarcodeSoloCodice.AutoSize = True
        Me.CkBarcodeSoloCodice.Checked = True
        Me.CkBarcodeSoloCodice.Location = New System.Drawing.Point(15, 44)
        Me.CkBarcodeSoloCodice.Name = "CkBarcodeSoloCodice"
        Me.CkBarcodeSoloCodice.Size = New System.Drawing.Size(54, 17)
        Me.CkBarcodeSoloCodice.TabIndex = 6
        Me.CkBarcodeSoloCodice.TabStop = True
        Me.CkBarcodeSoloCodice.Text = "Indice"
        Me.CkBarcodeSoloCodice.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(168, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Minimo Righe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(157, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Dimensione Font"
        '
        'Nu_RigheDistinta
        '
        Me.Nu_RigheDistinta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Nu_RigheDistinta.Location = New System.Drawing.Point(328, 40)
        Me.Nu_RigheDistinta.Name = "Nu_RigheDistinta"
        Me.Nu_RigheDistinta.Size = New System.Drawing.Size(65, 20)
        Me.Nu_RigheDistinta.TabIndex = 3
        '
        'Nu_FontDistinta
        '
        Me.Nu_FontDistinta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Nu_FontDistinta.Location = New System.Drawing.Point(328, 17)
        Me.Nu_FontDistinta.Name = "Nu_FontDistinta"
        Me.Nu_FontDistinta.Size = New System.Drawing.Size(65, 20)
        Me.Nu_FontDistinta.TabIndex = 2
        '
        'Ck_Barcode
        '
        Me.Ck_Barcode.AutoSize = True
        Me.Ck_Barcode.Location = New System.Drawing.Point(15, 20)
        Me.Ck_Barcode.Name = "Ck_Barcode"
        Me.Ck_Barcode.Size = New System.Drawing.Size(105, 17)
        Me.Ck_Barcode.TabIndex = 0
        Me.Ck_Barcode.Text = "Stampa Barcode"
        Me.Ck_Barcode.UseVisualStyleBackColor = True
        '
        'Ck_BiancoNero
        '
        Me.Ck_BiancoNero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ck_BiancoNero.AutoSize = True
        Me.Ck_BiancoNero.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ck_BiancoNero.Location = New System.Drawing.Point(171, 23)
        Me.Ck_BiancoNero.Name = "Ck_BiancoNero"
        Me.Ck_BiancoNero.Size = New System.Drawing.Size(52, 17)
        Me.Ck_BiancoNero.TabIndex = 6
        Me.Ck_BiancoNero.Text = "Colori"
        Me.Ck_BiancoNero.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.RBexcel_nuovi)
        Me.GroupBox3.Controls.Add(Me.RBtext_nuovi)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TxtScegliExcel)
        Me.GroupBox3.Controls.Add(Me.Bt_ScegliExcel)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 553)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(402, 89)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Riferimenti"
        '
        'RBexcel_nuovi
        '
        Me.RBexcel_nuovi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RBexcel_nuovi.AutoSize = True
        Me.RBexcel_nuovi.Location = New System.Drawing.Point(281, 16)
        Me.RBexcel_nuovi.Name = "RBexcel_nuovi"
        Me.RBexcel_nuovi.Size = New System.Drawing.Size(51, 17)
        Me.RBexcel_nuovi.TabIndex = 25
        Me.RBexcel_nuovi.TabStop = True
        Me.RBexcel_nuovi.Text = "Excel"
        Me.RBexcel_nuovi.UseVisualStyleBackColor = True
        '
        'RBtext_nuovi
        '
        Me.RBtext_nuovi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RBtext_nuovi.AutoSize = True
        Me.RBtext_nuovi.Location = New System.Drawing.Point(338, 16)
        Me.RBtext_nuovi.Name = "RBtext_nuovi"
        Me.RBtext_nuovi.Size = New System.Drawing.Size(46, 17)
        Me.RBtext_nuovi.TabIndex = 24
        Me.RBtext_nuovi.TabStop = True
        Me.RBtext_nuovi.Text = "Text"
        Me.RBtext_nuovi.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Eseguibile Excel"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(193, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Tipo di visualizzazione lista nuovi imballi"
        '
        'TxtScegliExcel
        '
        Me.TxtScegliExcel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtScegliExcel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtScegliExcel.Location = New System.Drawing.Point(59, 57)
        Me.TxtScegliExcel.Name = "TxtScegliExcel"
        Me.TxtScegliExcel.Size = New System.Drawing.Size(332, 23)
        Me.TxtScegliExcel.TabIndex = 19
        Me.TxtScegliExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Bt_ScegliExcel
        '
        Me.Bt_ScegliExcel.Location = New System.Drawing.Point(6, 57)
        Me.Bt_ScegliExcel.Name = "Bt_ScegliExcel"
        Me.Bt_ScegliExcel.Size = New System.Drawing.Size(47, 23)
        Me.Bt_ScegliExcel.TabIndex = 18
        Me.Bt_ScegliExcel.Text = "..."
        Me.Bt_ScegliExcel.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Bt_FormatoStampa)
        Me.GroupBox4.Controls.Add(Me.Ck_BiancoNero)
        Me.GroupBox4.Location = New System.Drawing.Point(425, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(229, 54)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Generali"
        '
        'Bt_SettingsEmail
        '
        Me.Bt_SettingsEmail.Location = New System.Drawing.Point(6, 20)
        Me.Bt_SettingsEmail.Name = "Bt_SettingsEmail"
        Me.Bt_SettingsEmail.Size = New System.Drawing.Size(217, 23)
        Me.Bt_SettingsEmail.TabIndex = 19
        Me.Bt_SettingsEmail.Text = "Opzioni Email"
        Me.Bt_SettingsEmail.UseVisualStyleBackColor = True
        '
        'Bt_TestConnessioni
        '
        Me.Bt_TestConnessioni.Image = CType(resources.GetObject("Bt_TestConnessioni.Image"), System.Drawing.Image)
        Me.Bt_TestConnessioni.Location = New System.Drawing.Point(6, 20)
        Me.Bt_TestConnessioni.Name = "Bt_TestConnessioni"
        Me.Bt_TestConnessioni.Size = New System.Drawing.Size(217, 40)
        Me.Bt_TestConnessioni.TabIndex = 20
        Me.Bt_TestConnessioni.Text = "   Test Connessioni"
        Me.Bt_TestConnessioni.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_TestConnessioni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bt_TestConnessioni.UseVisualStyleBackColor = True
        '
        'Bt_EliminaOrdine
        '
        Me.Bt_EliminaOrdine.Image = CType(resources.GetObject("Bt_EliminaOrdine.Image"), System.Drawing.Image)
        Me.Bt_EliminaOrdine.Location = New System.Drawing.Point(6, 66)
        Me.Bt_EliminaOrdine.Name = "Bt_EliminaOrdine"
        Me.Bt_EliminaOrdine.Size = New System.Drawing.Size(217, 40)
        Me.Bt_EliminaOrdine.TabIndex = 27
        Me.Bt_EliminaOrdine.Text = "   Elimina Ordine"
        Me.Bt_EliminaOrdine.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_EliminaOrdine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bt_EliminaOrdine.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.BT_SetupRives)
        Me.GroupBox5.Controls.Add(Me.Bt_Log)
        Me.GroupBox5.Controls.Add(Me.Bt_GestioneTipi)
        Me.GroupBox5.Controls.Add(Me.Bt_PulisciImballi)
        Me.GroupBox5.Controls.Add(Me.Bt_EliminaOrdine)
        Me.GroupBox5.Controls.Add(Me.Bt_TestConnessioni)
        Me.GroupBox5.Location = New System.Drawing.Point(425, 127)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(229, 299)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Funzioni"
        '
        'BT_SetupRives
        '
        Me.BT_SetupRives.Image = CType(resources.GetObject("BT_SetupRives.Image"), System.Drawing.Image)
        Me.BT_SetupRives.Location = New System.Drawing.Point(6, 250)
        Me.BT_SetupRives.Name = "BT_SetupRives"
        Me.BT_SetupRives.Size = New System.Drawing.Size(217, 40)
        Me.BT_SetupRives.TabIndex = 31
        Me.BT_SetupRives.Text = "   Setup Rivestimenti"
        Me.BT_SetupRives.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_SetupRives.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BT_SetupRives.UseVisualStyleBackColor = True
        '
        'Bt_Log
        '
        Me.Bt_Log.Image = CType(resources.GetObject("Bt_Log.Image"), System.Drawing.Image)
        Me.Bt_Log.Location = New System.Drawing.Point(6, 203)
        Me.Bt_Log.Name = "Bt_Log"
        Me.Bt_Log.Size = New System.Drawing.Size(217, 40)
        Me.Bt_Log.TabIndex = 30
        Me.Bt_Log.Text = "   Apri file di LOG"
        Me.Bt_Log.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Log.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bt_Log.UseVisualStyleBackColor = True
        '
        'Bt_GestioneTipi
        '
        Me.Bt_GestioneTipi.Image = CType(resources.GetObject("Bt_GestioneTipi.Image"), System.Drawing.Image)
        Me.Bt_GestioneTipi.Location = New System.Drawing.Point(6, 158)
        Me.Bt_GestioneTipi.Name = "Bt_GestioneTipi"
        Me.Bt_GestioneTipi.Size = New System.Drawing.Size(217, 40)
        Me.Bt_GestioneTipi.TabIndex = 29
        Me.Bt_GestioneTipi.Text = "   Gestione Tipi"
        Me.Bt_GestioneTipi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_GestioneTipi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bt_GestioneTipi.UseVisualStyleBackColor = True
        '
        'Bt_PulisciImballi
        '
        Me.Bt_PulisciImballi.Image = CType(resources.GetObject("Bt_PulisciImballi.Image"), System.Drawing.Image)
        Me.Bt_PulisciImballi.Location = New System.Drawing.Point(6, 112)
        Me.Bt_PulisciImballi.Name = "Bt_PulisciImballi"
        Me.Bt_PulisciImballi.Size = New System.Drawing.Size(217, 40)
        Me.Bt_PulisciImballi.TabIndex = 28
        Me.Bt_PulisciImballi.Text = "   Pulizia imballi"
        Me.Bt_PulisciImballi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_PulisciImballi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bt_PulisciImballi.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.Bt_SettingsEmail)
        Me.GroupBox6.Location = New System.Drawing.Point(425, 70)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(229, 52)
        Me.GroupBox6.TabIndex = 29
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Email"
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.Txt_utente)
        Me.GroupBox7.Location = New System.Drawing.Point(425, 429)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(229, 65)
        Me.GroupBox7.TabIndex = 30
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Utente"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(220, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Nome che verrà visualizzato nelle mail inviate"
        '
        'Txt_utente
        '
        Me.Txt_utente.Location = New System.Drawing.Point(6, 36)
        Me.Txt_utente.Name = "Txt_utente"
        Me.Txt_utente.Size = New System.Drawing.Size(217, 20)
        Me.Txt_utente.TabIndex = 0
        '
        'Bt_AzzeraDB
        '
        Me.Bt_AzzeraDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_AzzeraDB.Location = New System.Drawing.Point(7, 19)
        Me.Bt_AzzeraDB.Name = "Bt_AzzeraDB"
        Me.Bt_AzzeraDB.Size = New System.Drawing.Size(216, 30)
        Me.Bt_AzzeraDB.TabIndex = 31
        Me.Bt_AzzeraDB.Text = "Azzera database"
        Me.Bt_AzzeraDB.UseVisualStyleBackColor = True
        '
        'Box_Developer
        '
        Me.Box_Developer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Box_Developer.Controls.Add(Me.Bt_ResetSettings)
        Me.Box_Developer.Controls.Add(Me.Bt_InviaQuery)
        Me.Box_Developer.Controls.Add(Me.Bt_AzzeraDB)
        Me.Box_Developer.Location = New System.Drawing.Point(425, 501)
        Me.Box_Developer.Name = "Box_Developer"
        Me.Box_Developer.Size = New System.Drawing.Size(229, 142)
        Me.Box_Developer.TabIndex = 32
        Me.Box_Developer.TabStop = False
        Me.Box_Developer.Text = "Developer area"
        '
        'Bt_ResetSettings
        '
        Me.Bt_ResetSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_ResetSettings.Location = New System.Drawing.Point(7, 84)
        Me.Bt_ResetSettings.Name = "Bt_ResetSettings"
        Me.Bt_ResetSettings.Size = New System.Drawing.Size(216, 30)
        Me.Bt_ResetSettings.TabIndex = 32
        Me.Bt_ResetSettings.Text = "Reset Settings"
        Me.Bt_ResetSettings.UseVisualStyleBackColor = True
        '
        'Bt_InviaQuery
        '
        Me.Bt_InviaQuery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_InviaQuery.Location = New System.Drawing.Point(7, 51)
        Me.Bt_InviaQuery.Name = "Bt_InviaQuery"
        Me.Bt_InviaQuery.Size = New System.Drawing.Size(216, 30)
        Me.Bt_InviaQuery.TabIndex = 32
        Me.Bt_InviaQuery.Text = "Invia Query"
        Me.Bt_InviaQuery.UseVisualStyleBackColor = True
        '
        'Form_Preferenze
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(671, 699)
        Me.Controls.Add(Me.Box_Developer)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GB_etichette)
        Me.Controls.Add(Me.Bt_Salva)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.KeyPreview = True
        Me.Name = "Form_Preferenze"
        Me.Text = "Preferenze"
        Me.GB_etichette.ResumeLayout(False)
        Me.GB_etichette.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Nu_RigheDistinta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nu_FontDistinta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.Box_Developer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Bt_FormatoStampa As Button
    Friend WithEvents GB_etichette As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Txt_mmX As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_mmY As TextBox
    Friend WithEvents Txt_NomeStampante As TextBox
    Friend WithEvents Bt_Salva As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Txt_MargineTop As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_MargineRight As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_MargineBottom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_MargineLeft As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Ck_Evaso As CheckBox
    Friend WithEvents Ck_ColoraScaduti As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Ck_ColoraEvasi As CheckBox
    Friend WithEvents Ck_CheckCaricamento As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Ck_Barcode As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Nu_RigheDistinta As NumericUpDown
    Friend WithEvents Nu_FontDistinta As NumericUpDown
    Friend WithEvents Ck_BiancoNero As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Bt_SettingsEmail As Button
    Friend WithEvents Bt_TestConnessioni As Button
    Friend WithEvents TxtScegliExcel As Label
    Friend WithEvents Bt_ScegliExcel As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents RBexcel_nuovi As RadioButton
    Friend WithEvents RBtext_nuovi As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Txt_LimiteStorico As TextBox
    Friend WithEvents CkCodiceQT As RadioButton
    Friend WithEvents CkBarcodeSoloCodice As RadioButton
    Friend WithEvents Bt_EliminaOrdine As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Bt_PulisciImballi As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Bt_GestioneTipi As Button
    Friend WithEvents Bt_Log As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Txt_utente As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CkNoteDinamico As CheckBox
    Friend WithEvents BT_SetupRives As Button
    Friend WithEvents Bt_AzzeraDB As Button
    Friend WithEvents Ck_TextMain As CheckBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents CkNotificaCambioIndice As CheckBox
    Friend WithEvents Box_Developer As GroupBox
    Friend WithEvents Bt_InviaQuery As Button
    Friend WithEvents Bt_ResetSettings As Button
    Friend WithEvents CK_DescrizioneClipboard As CheckBox
End Class
