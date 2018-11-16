<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_OrdiniApertiV2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_OrdiniApertiV2))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Bt_Evaso = New System.Windows.Forms.Button()
        Me.Bt_InProduzione = New System.Windows.Forms.Button()
        Me.Bt_SeeAll = New System.Windows.Forms.Button()
        Me.Bt_Send_Rivestimenti = New System.Windows.Forms.Button()
        Me.Bt_CheckList = New System.Windows.Forms.Button()
        Me.Bt_Bindelli = New System.Windows.Forms.Button()
        Me.Bt_Disegni = New System.Windows.Forms.Button()
        Me.Bt_ConfermaOrdine = New System.Windows.Forms.Button()
        Me.Bt_Open_ListaDiagonali = New System.Windows.Forms.Button()
        Me.Bt_Open_ListaMorali = New System.Windows.Forms.Button()
        Me.GB_Stampe = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Ck_AnteprimaStampa = New System.Windows.Forms.CheckBox()
        Me.GB_Produzione = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.GB_Gestione = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGW_OrdiniAperti = New System.Windows.Forms.DataGridView()
        Me.Ordine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Riferimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CM_Ordini = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.COPIARIFORDINEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DGW_Ordine = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOrdine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Riga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Imballo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Disegno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Commessa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HT = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Consegna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stato = New System.Windows.Forms.DataGridViewImageColumn()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.CM_Context = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RICERCAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.STAMPADISTINTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STAMPABINDELLOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODIFICAIMBALLOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ELIMINARIGAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ELIMINAORDINEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RivToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Tx_Cerca_Disegno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tx_Cerca_Ordine = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tx_Cerca_Commessa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.RB_Search_Evasi = New System.Windows.Forms.RadioButton()
        Me.RB_Search_Tutti = New System.Windows.Forms.RadioButton()
        Me.Rb_Search_NonEvasi = New System.Windows.Forms.RadioButton()
        Me.Tx_Cerca_Imballo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Bt_Search_Chiudi = New System.Windows.Forms.Button()
        Me.Bt_Search = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.BT_CaricaSett = New System.Windows.Forms.Button()
        Me.CB_ScegliSett = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GB_Stampe.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GB_Produzione.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GB_Gestione.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DGW_OrdiniAperti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CM_Ordini.SuspendLayout()
        CType(Me.DGW_Ordine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.CM_Context.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bt_Evaso
        '
        Me.Bt_Evaso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Evaso.BackColor = System.Drawing.Color.Linen
        Me.Bt_Evaso.FlatAppearance.BorderColor = System.Drawing.Color.Tan
        Me.Bt_Evaso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Evaso.Image = CType(resources.GetObject("Bt_Evaso.Image"), System.Drawing.Image)
        Me.Bt_Evaso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Evaso.Location = New System.Drawing.Point(3, 3)
        Me.Bt_Evaso.Name = "Bt_Evaso"
        Me.Bt_Evaso.Size = New System.Drawing.Size(130, 45)
        Me.Bt_Evaso.TabIndex = 8
        Me.Bt_Evaso.Text = "EVASO"
        Me.Bt_Evaso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip.SetToolTip(Me.Bt_Evaso, "Contrassegna l'imballo selezionato come EVASO")
        Me.Bt_Evaso.UseVisualStyleBackColor = False
        '
        'Bt_InProduzione
        '
        Me.Bt_InProduzione.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_InProduzione.BackColor = System.Drawing.Color.Linen
        Me.Bt_InProduzione.FlatAppearance.BorderColor = System.Drawing.Color.Tan
        Me.Bt_InProduzione.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_InProduzione.Image = CType(resources.GetObject("Bt_InProduzione.Image"), System.Drawing.Image)
        Me.Bt_InProduzione.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_InProduzione.Location = New System.Drawing.Point(3, 54)
        Me.Bt_InProduzione.Name = "Bt_InProduzione"
        Me.Bt_InProduzione.Size = New System.Drawing.Size(130, 46)
        Me.Bt_InProduzione.TabIndex = 12
        Me.Bt_InProduzione.Text = "IN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PRODUZIONE"
        Me.Bt_InProduzione.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip.SetToolTip(Me.Bt_InProduzione, "Contrassegna l'imballo selezionato come IN PRODUZIONE")
        Me.Bt_InProduzione.UseVisualStyleBackColor = False
        '
        'Bt_SeeAll
        '
        Me.Bt_SeeAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Bt_SeeAll.FlatAppearance.BorderColor = System.Drawing.Color.Tan
        Me.Bt_SeeAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_SeeAll.Image = CType(resources.GetObject("Bt_SeeAll.Image"), System.Drawing.Image)
        Me.Bt_SeeAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_SeeAll.Location = New System.Drawing.Point(3, 4)
        Me.Bt_SeeAll.Name = "Bt_SeeAll"
        Me.Bt_SeeAll.Size = New System.Drawing.Size(127, 45)
        Me.Bt_SeeAll.TabIndex = 13
        Me.Bt_SeeAll.Text = "PANORAMICA"
        Me.Bt_SeeAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip.SetToolTip(Me.Bt_SeeAll, "Mostra una panoramica di tutti gli imballi che risultano ancora da evadere")
        Me.Bt_SeeAll.UseVisualStyleBackColor = True
        '
        'Bt_Send_Rivestimenti
        '
        Me.Bt_Send_Rivestimenti.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Send_Rivestimenti.BackColor = System.Drawing.Color.PeachPuff
        Me.Bt_Send_Rivestimenti.FlatAppearance.BorderColor = System.Drawing.Color.Tan
        Me.Bt_Send_Rivestimenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Send_Rivestimenti.Image = CType(resources.GetObject("Bt_Send_Rivestimenti.Image"), System.Drawing.Image)
        Me.Bt_Send_Rivestimenti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Send_Rivestimenti.Location = New System.Drawing.Point(3, 105)
        Me.Bt_Send_Rivestimenti.Name = "Bt_Send_Rivestimenti"
        Me.Bt_Send_Rivestimenti.Size = New System.Drawing.Size(130, 46)
        Me.Bt_Send_Rivestimenti.TabIndex = 14
        Me.Bt_Send_Rivestimenti.Text = "INVIA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RIVESTIMENTI"
        Me.Bt_Send_Rivestimenti.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip.SetToolTip(Me.Bt_Send_Rivestimenti, "Invia alla sezionatrice il file rivestimenti per l'ordine selezionato")
        Me.Bt_Send_Rivestimenti.UseVisualStyleBackColor = False
        '
        'Bt_CheckList
        '
        Me.Bt_CheckList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_CheckList.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Bt_CheckList.FlatAppearance.BorderColor = System.Drawing.Color.Tan
        Me.Bt_CheckList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_CheckList.Image = CType(resources.GetObject("Bt_CheckList.Image"), System.Drawing.Image)
        Me.Bt_CheckList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_CheckList.Location = New System.Drawing.Point(3, 101)
        Me.Bt_CheckList.Name = "Bt_CheckList"
        Me.Bt_CheckList.Size = New System.Drawing.Size(130, 43)
        Me.Bt_CheckList.TabIndex = 16
        Me.Bt_CheckList.Text = "CHECKLIST"
        Me.Bt_CheckList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip.SetToolTip(Me.Bt_CheckList, "Stampa la checklist per l'ordine selezionato")
        Me.Bt_CheckList.UseVisualStyleBackColor = False
        '
        'Bt_Bindelli
        '
        Me.Bt_Bindelli.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Bindelli.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Bt_Bindelli.FlatAppearance.BorderColor = System.Drawing.Color.Tan
        Me.Bt_Bindelli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Bindelli.Image = CType(resources.GetObject("Bt_Bindelli.Image"), System.Drawing.Image)
        Me.Bt_Bindelli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Bindelli.Location = New System.Drawing.Point(3, 3)
        Me.Bt_Bindelli.Name = "Bt_Bindelli"
        Me.Bt_Bindelli.Size = New System.Drawing.Size(130, 43)
        Me.Bt_Bindelli.TabIndex = 17
        Me.Bt_Bindelli.Text = "BINDELLI"
        Me.Bt_Bindelli.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip.SetToolTip(Me.Bt_Bindelli, "Stampa i bindelli per l'ordine selezionato")
        Me.Bt_Bindelli.UseVisualStyleBackColor = False
        '
        'Bt_Disegni
        '
        Me.Bt_Disegni.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Disegni.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Bt_Disegni.FlatAppearance.BorderColor = System.Drawing.Color.Tan
        Me.Bt_Disegni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Disegni.Image = CType(resources.GetObject("Bt_Disegni.Image"), System.Drawing.Image)
        Me.Bt_Disegni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Disegni.Location = New System.Drawing.Point(3, 52)
        Me.Bt_Disegni.Name = "Bt_Disegni"
        Me.Bt_Disegni.Size = New System.Drawing.Size(130, 43)
        Me.Bt_Disegni.TabIndex = 18
        Me.Bt_Disegni.Text = "DISEGNI"
        Me.Bt_Disegni.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip.SetToolTip(Me.Bt_Disegni, "Stampa i disegni per l'ordine selezionato")
        Me.Bt_Disegni.UseVisualStyleBackColor = False
        '
        'Bt_ConfermaOrdine
        '
        Me.Bt_ConfermaOrdine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_ConfermaOrdine.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Bt_ConfermaOrdine.FlatAppearance.BorderColor = System.Drawing.Color.Tan
        Me.Bt_ConfermaOrdine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_ConfermaOrdine.Image = CType(resources.GetObject("Bt_ConfermaOrdine.Image"), System.Drawing.Image)
        Me.Bt_ConfermaOrdine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_ConfermaOrdine.Location = New System.Drawing.Point(3, 150)
        Me.Bt_ConfermaOrdine.Name = "Bt_ConfermaOrdine"
        Me.Bt_ConfermaOrdine.Size = New System.Drawing.Size(130, 43)
        Me.Bt_ConfermaOrdine.TabIndex = 19
        Me.Bt_ConfermaOrdine.Text = "CONFERMA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDINE"
        Me.Bt_ConfermaOrdine.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip.SetToolTip(Me.Bt_ConfermaOrdine, "Stampa e/o invia la conferma d'ordine per l'ordine selezionato")
        Me.Bt_ConfermaOrdine.UseVisualStyleBackColor = False
        '
        'Bt_Open_ListaDiagonali
        '
        Me.Bt_Open_ListaDiagonali.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Open_ListaDiagonali.BackColor = System.Drawing.Color.PeachPuff
        Me.Bt_Open_ListaDiagonali.FlatAppearance.BorderColor = System.Drawing.Color.Tan
        Me.Bt_Open_ListaDiagonali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Open_ListaDiagonali.Image = CType(resources.GetObject("Bt_Open_ListaDiagonali.Image"), System.Drawing.Image)
        Me.Bt_Open_ListaDiagonali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Open_ListaDiagonali.Location = New System.Drawing.Point(3, 3)
        Me.Bt_Open_ListaDiagonali.Name = "Bt_Open_ListaDiagonali"
        Me.Bt_Open_ListaDiagonali.Size = New System.Drawing.Size(130, 45)
        Me.Bt_Open_ListaDiagonali.TabIndex = 20
        Me.Bt_Open_ListaDiagonali.Text = "LISTA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DIAGONALI"
        Me.Bt_Open_ListaDiagonali.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip.SetToolTip(Me.Bt_Open_ListaDiagonali, "Apre una dialog per stampare la lista delle diagonali")
        Me.Bt_Open_ListaDiagonali.UseVisualStyleBackColor = False
        '
        'Bt_Open_ListaMorali
        '
        Me.Bt_Open_ListaMorali.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Open_ListaMorali.BackColor = System.Drawing.Color.PeachPuff
        Me.Bt_Open_ListaMorali.FlatAppearance.BorderColor = System.Drawing.Color.Tan
        Me.Bt_Open_ListaMorali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Open_ListaMorali.Image = CType(resources.GetObject("Bt_Open_ListaMorali.Image"), System.Drawing.Image)
        Me.Bt_Open_ListaMorali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Open_ListaMorali.Location = New System.Drawing.Point(3, 54)
        Me.Bt_Open_ListaMorali.Name = "Bt_Open_ListaMorali"
        Me.Bt_Open_ListaMorali.Size = New System.Drawing.Size(130, 45)
        Me.Bt_Open_ListaMorali.TabIndex = 21
        Me.Bt_Open_ListaMorali.Text = "LISTA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MORALI"
        Me.Bt_Open_ListaMorali.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip.SetToolTip(Me.Bt_Open_ListaMorali, "Apre una dialog per stampare la lista dei morali")
        Me.Bt_Open_ListaMorali.UseVisualStyleBackColor = False
        '
        'GB_Stampe
        '
        Me.GB_Stampe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Stampe.Controls.Add(Me.TableLayoutPanel1)
        Me.GB_Stampe.Location = New System.Drawing.Point(1029, 140)
        Me.GB_Stampe.Name = "GB_Stampe"
        Me.GB_Stampe.Size = New System.Drawing.Size(142, 252)
        Me.GB_Stampe.TabIndex = 22
        Me.GB_Stampe.TabStop = False
        Me.GB_Stampe.Text = "STAMPE"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Ck_AnteprimaStampa, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Bt_ConfermaOrdine, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Bt_CheckList, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Bt_Bindelli, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Bt_Disegni, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(136, 224)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Ck_AnteprimaStampa
        '
        Me.Ck_AnteprimaStampa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Ck_AnteprimaStampa.AutoSize = True
        Me.Ck_AnteprimaStampa.Location = New System.Drawing.Point(14, 201)
        Me.Ck_AnteprimaStampa.Name = "Ck_AnteprimaStampa"
        Me.Ck_AnteprimaStampa.Size = New System.Drawing.Size(108, 17)
        Me.Ck_AnteprimaStampa.TabIndex = 20
        Me.Ck_AnteprimaStampa.Text = "Mostra Anteprima"
        Me.Ck_AnteprimaStampa.UseVisualStyleBackColor = True
        '
        'GB_Produzione
        '
        Me.GB_Produzione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Produzione.Controls.Add(Me.TableLayoutPanel3)
        Me.GB_Produzione.Location = New System.Drawing.Point(1030, 403)
        Me.GB_Produzione.Name = "GB_Produzione"
        Me.GB_Produzione.Size = New System.Drawing.Size(142, 173)
        Me.GB_Produzione.TabIndex = 23
        Me.GB_Produzione.TabStop = False
        Me.GB_Produzione.Text = "PRODUZIONE"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Bt_Send_Rivestimenti, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Bt_Open_ListaDiagonali, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Bt_Open_ListaMorali, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(136, 154)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'GB_Gestione
        '
        Me.GB_Gestione.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Gestione.Controls.Add(Me.TableLayoutPanel2)
        Me.GB_Gestione.Location = New System.Drawing.Point(1030, 12)
        Me.GB_Gestione.Name = "GB_Gestione"
        Me.GB_Gestione.Size = New System.Drawing.Size(142, 122)
        Me.GB_Gestione.TabIndex = 24
        Me.GB_Gestione.TabStop = False
        Me.GB_Gestione.Text = "GESTIONE"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Bt_InProduzione, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Bt_Evaso, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(136, 103)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'DGW_OrdiniAperti
        '
        Me.DGW_OrdiniAperti.AllowUserToAddRows = False
        Me.DGW_OrdiniAperti.AllowUserToDeleteRows = False
        Me.DGW_OrdiniAperti.AllowUserToResizeColumns = False
        Me.DGW_OrdiniAperti.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGW_OrdiniAperti.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGW_OrdiniAperti.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DGW_OrdiniAperti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGW_OrdiniAperti.BackgroundColor = System.Drawing.Color.White
        Me.DGW_OrdiniAperti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_OrdiniAperti.ColumnHeadersVisible = False
        Me.DGW_OrdiniAperti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ordine, Me.Riferimento})
        Me.DGW_OrdiniAperti.ContextMenuStrip = Me.CM_Ordini
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cornsilk
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGW_OrdiniAperti.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGW_OrdiniAperti.GridColor = System.Drawing.Color.Tan
        Me.DGW_OrdiniAperti.Location = New System.Drawing.Point(12, 12)
        Me.DGW_OrdiniAperti.Name = "DGW_OrdiniAperti"
        Me.DGW_OrdiniAperti.ReadOnly = True
        Me.DGW_OrdiniAperti.RowHeadersVisible = False
        Me.DGW_OrdiniAperti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGW_OrdiniAperti.Size = New System.Drawing.Size(238, 506)
        Me.DGW_OrdiniAperti.TabIndex = 25
        '
        'Ordine
        '
        Me.Ordine.FillWeight = 131.9797!
        Me.Ordine.HeaderText = "Ordine"
        Me.Ordine.Name = "Ordine"
        Me.Ordine.ReadOnly = True
        '
        'Riferimento
        '
        Me.Riferimento.FillWeight = 68.02031!
        Me.Riferimento.HeaderText = "Riferimento"
        Me.Riferimento.Name = "Riferimento"
        Me.Riferimento.ReadOnly = True
        '
        'CM_Ordini
        '
        Me.CM_Ordini.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COPIARIFORDINEToolStripMenuItem})
        Me.CM_Ordini.Name = "CM_Ordini"
        Me.CM_Ordini.Size = New System.Drawing.Size(177, 26)
        '
        'COPIARIFORDINEToolStripMenuItem
        '
        Me.COPIARIFORDINEToolStripMenuItem.Name = "COPIARIFORDINEToolStripMenuItem"
        Me.COPIARIFORDINEToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.COPIARIFORDINEToolStripMenuItem.Text = "COPIA RIF. ORDINE"
        '
        'DGW_Ordine
        '
        Me.DGW_Ordine.AllowUserToAddRows = False
        Me.DGW_Ordine.AllowUserToDeleteRows = False
        Me.DGW_Ordine.AllowUserToResizeColumns = False
        Me.DGW_Ordine.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Linen
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSalmon
        Me.DGW_Ordine.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGW_Ordine.BackgroundColor = System.Drawing.Color.NavajoWhite
        Me.DGW_Ordine.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGW_Ordine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGW_Ordine.ColumnHeadersHeight = 30
        Me.DGW_Ordine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGW_Ordine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.NOrdine, Me.Riga, Me.Imballo, Me.Qt, Me.Tipo, Me.Disegno, Me.Commessa, Me.HT, Me.Consegna, Me.Stato})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSalmon
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGW_Ordine.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGW_Ordine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGW_Ordine.GridColor = System.Drawing.SystemColors.Control
        Me.DGW_Ordine.Location = New System.Drawing.Point(0, 0)
        Me.DGW_Ordine.Name = "DGW_Ordine"
        Me.DGW_Ordine.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGW_Ordine.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGW_Ordine.RowHeadersVisible = False
        Me.DGW_Ordine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGW_Ordine.Size = New System.Drawing.Size(766, 454)
        Me.DGW_Ordine.TabIndex = 26
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'NOrdine
        '
        Me.NOrdine.HeaderText = "Ordine"
        Me.NOrdine.Name = "NOrdine"
        Me.NOrdine.ReadOnly = True
        Me.NOrdine.Visible = False
        Me.NOrdine.Width = 120
        '
        'Riga
        '
        Me.Riga.HeaderText = "Riga"
        Me.Riga.Name = "Riga"
        Me.Riga.ReadOnly = True
        Me.Riga.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Riga.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Riga.Width = 50
        '
        'Imballo
        '
        Me.Imballo.HeaderText = "Imballo"
        Me.Imballo.Name = "Imballo"
        Me.Imballo.ReadOnly = True
        '
        'Qt
        '
        Me.Qt.HeaderText = "Qt"
        Me.Qt.Name = "Qt"
        Me.Qt.ReadOnly = True
        Me.Qt.Width = 50
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 50
        '
        'Disegno
        '
        Me.Disegno.HeaderText = "Disegno"
        Me.Disegno.Name = "Disegno"
        Me.Disegno.ReadOnly = True
        Me.Disegno.Width = 150
        '
        'Commessa
        '
        Me.Commessa.HeaderText = "Commessa"
        Me.Commessa.Name = "Commessa"
        Me.Commessa.ReadOnly = True
        Me.Commessa.Width = 150
        '
        'HT
        '
        Me.HT.HeaderText = "HT"
        Me.HT.Name = "HT"
        Me.HT.ReadOnly = True
        Me.HT.Width = 40
        '
        'Consegna
        '
        Me.Consegna.HeaderText = "Sett."
        Me.Consegna.Name = "Consegna"
        Me.Consegna.ReadOnly = True
        '
        'Stato
        '
        Me.Stato.HeaderText = "Stato"
        Me.Stato.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Stato.Name = "Stato"
        Me.Stato.ReadOnly = True
        Me.Stato.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Stato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Stato.Width = 50
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.ContextMenuStrip = Me.CM_Context
        Me.SplitContainer1.Location = New System.Drawing.Point(256, 12)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel4)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DGW_Ordine)
        Me.SplitContainer1.Size = New System.Drawing.Size(768, 564)
        Me.SplitContainer1.SplitterDistance = 100
        Me.SplitContainer1.SplitterWidth = 8
        Me.SplitContainer1.TabIndex = 27
        '
        'CM_Context
        '
        Me.CM_Context.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RICERCAToolStripMenuItem, Me.ToolStripSeparator1, Me.STAMPADISTINTAToolStripMenuItem, Me.STAMPABINDELLOToolStripMenuItem, Me.MODIFICAIMBALLOToolStripMenuItem, Me.ToolStripSeparator2, Me.ELIMINARIGAToolStripMenuItem, Me.ELIMINAORDINEToolStripMenuItem, Me.RivToolStripMenuItem})
        Me.CM_Context.Name = "CM_Ricerca"
        Me.CM_Context.Size = New System.Drawing.Size(184, 170)
        '
        'RICERCAToolStripMenuItem
        '
        Me.RICERCAToolStripMenuItem.Image = CType(resources.GetObject("RICERCAToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RICERCAToolStripMenuItem.Name = "RICERCAToolStripMenuItem"
        Me.RICERCAToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.RICERCAToolStripMenuItem.Text = "RICERCA"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(180, 6)
        '
        'STAMPADISTINTAToolStripMenuItem
        '
        Me.STAMPADISTINTAToolStripMenuItem.Name = "STAMPADISTINTAToolStripMenuItem"
        Me.STAMPADISTINTAToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.STAMPADISTINTAToolStripMenuItem.Text = "STAMPA DISTINTE"
        '
        'STAMPABINDELLOToolStripMenuItem
        '
        Me.STAMPABINDELLOToolStripMenuItem.Name = "STAMPABINDELLOToolStripMenuItem"
        Me.STAMPABINDELLOToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.STAMPABINDELLOToolStripMenuItem.Text = "STAMPA BINDELLI"
        '
        'MODIFICAIMBALLOToolStripMenuItem
        '
        Me.MODIFICAIMBALLOToolStripMenuItem.Name = "MODIFICAIMBALLOToolStripMenuItem"
        Me.MODIFICAIMBALLOToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.MODIFICAIMBALLOToolStripMenuItem.Text = "MODIFICA IMBALLO"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(180, 6)
        '
        'ELIMINARIGAToolStripMenuItem
        '
        Me.ELIMINARIGAToolStripMenuItem.Name = "ELIMINARIGAToolStripMenuItem"
        Me.ELIMINARIGAToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ELIMINARIGAToolStripMenuItem.Text = "ELIMINA RIGA"
        '
        'ELIMINAORDINEToolStripMenuItem
        '
        Me.ELIMINAORDINEToolStripMenuItem.Name = "ELIMINAORDINEToolStripMenuItem"
        Me.ELIMINAORDINEToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ELIMINAORDINEToolStripMenuItem.Text = "ELIMINA ORDINE"
        '
        'RivToolStripMenuItem
        '
        Me.RivToolStripMenuItem.Name = "RivToolStripMenuItem"
        Me.RivToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.RivToolStripMenuItem.Text = "_Riv"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Tx_Cerca_Disegno, 3, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Tx_Cerca_Ordine, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Tx_Cerca_Commessa, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Tx_Cerca_Imballo, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Bt_Search_Chiudi, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Bt_Search, 4, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(766, 98)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'Tx_Cerca_Disegno
        '
        Me.Tx_Cerca_Disegno.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tx_Cerca_Disegno.Location = New System.Drawing.Point(453, 38)
        Me.Tx_Cerca_Disegno.Name = "Tx_Cerca_Disegno"
        Me.Tx_Cerca_Disegno.Size = New System.Drawing.Size(246, 20)
        Me.Tx_Cerca_Disegno.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ordine"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(401, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Disegno"
        '
        'Tx_Cerca_Ordine
        '
        Me.Tx_Cerca_Ordine.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tx_Cerca_Ordine.Location = New System.Drawing.Point(102, 6)
        Me.Tx_Cerca_Ordine.Name = "Tx_Cerca_Ordine"
        Me.Tx_Cerca_Ordine.Size = New System.Drawing.Size(246, 20)
        Me.Tx_Cerca_Ordine.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(389, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Commessa"
        '
        'Tx_Cerca_Commessa
        '
        Me.Tx_Cerca_Commessa.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tx_Cerca_Commessa.Location = New System.Drawing.Point(453, 6)
        Me.Tx_Cerca_Commessa.Name = "Tx_Cerca_Commessa"
        Me.Tx_Cerca_Commessa.Size = New System.Drawing.Size(246, 20)
        Me.Tx_Cerca_Commessa.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Imballo"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.Controls.Add(Me.RB_Search_Evasi, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.RB_Search_Tutti, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Rb_Search_NonEvasi, 2, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(102, 67)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(246, 28)
        Me.TableLayoutPanel5.TabIndex = 9
        '
        'RB_Search_Evasi
        '
        Me.RB_Search_Evasi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RB_Search_Evasi.AutoSize = True
        Me.RB_Search_Evasi.Location = New System.Drawing.Point(97, 5)
        Me.RB_Search_Evasi.Name = "RB_Search_Evasi"
        Me.RB_Search_Evasi.Size = New System.Drawing.Size(51, 17)
        Me.RB_Search_Evasi.TabIndex = 0
        Me.RB_Search_Evasi.Text = "Evasi"
        Me.RB_Search_Evasi.UseVisualStyleBackColor = True
        '
        'RB_Search_Tutti
        '
        Me.RB_Search_Tutti.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.RB_Search_Tutti.AutoSize = True
        Me.RB_Search_Tutti.Checked = True
        Me.RB_Search_Tutti.Location = New System.Drawing.Point(18, 3)
        Me.RB_Search_Tutti.Name = "RB_Search_Tutti"
        Me.RB_Search_Tutti.Size = New System.Drawing.Size(46, 22)
        Me.RB_Search_Tutti.TabIndex = 2
        Me.RB_Search_Tutti.TabStop = True
        Me.RB_Search_Tutti.Text = "Tutti"
        Me.RB_Search_Tutti.UseVisualStyleBackColor = True
        '
        'Rb_Search_NonEvasi
        '
        Me.Rb_Search_NonEvasi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Rb_Search_NonEvasi.AutoSize = True
        Me.Rb_Search_NonEvasi.Location = New System.Drawing.Point(168, 5)
        Me.Rb_Search_NonEvasi.Name = "Rb_Search_NonEvasi"
        Me.Rb_Search_NonEvasi.Size = New System.Drawing.Size(74, 17)
        Me.Rb_Search_NonEvasi.TabIndex = 1
        Me.Rb_Search_NonEvasi.Text = "Non Evasi"
        Me.Rb_Search_NonEvasi.UseVisualStyleBackColor = True
        '
        'Tx_Cerca_Imballo
        '
        Me.Tx_Cerca_Imballo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tx_Cerca_Imballo.Location = New System.Drawing.Point(102, 38)
        Me.Tx_Cerca_Imballo.Name = "Tx_Cerca_Imballo"
        Me.Tx_Cerca_Imballo.Size = New System.Drawing.Size(246, 20)
        Me.Tx_Cerca_Imballo.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Cerca in"
        '
        'Bt_Search_Chiudi
        '
        Me.Bt_Search_Chiudi.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Search_Chiudi.BackgroundImage = CType(resources.GetObject("Bt_Search_Chiudi.BackgroundImage"), System.Drawing.Image)
        Me.Bt_Search_Chiudi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_Search_Chiudi.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Bt_Search_Chiudi.FlatAppearance.BorderSize = 0
        Me.Bt_Search_Chiudi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Bt_Search_Chiudi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Search_Chiudi.Location = New System.Drawing.Point(705, 4)
        Me.Bt_Search_Chiudi.Name = "Bt_Search_Chiudi"
        Me.Bt_Search_Chiudi.Size = New System.Drawing.Size(58, 23)
        Me.Bt_Search_Chiudi.TabIndex = 8
        Me.Bt_Search_Chiudi.UseVisualStyleBackColor = True
        '
        'Bt_Search
        '
        Me.Bt_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Search.BackgroundImage = CType(resources.GetObject("Bt_Search.BackgroundImage"), System.Drawing.Image)
        Me.Bt_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_Search.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Bt_Search.FlatAppearance.BorderSize = 0
        Me.Bt_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Bt_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Search.Location = New System.Drawing.Point(705, 35)
        Me.Bt_Search.Name = "Bt_Search"
        Me.Bt_Search.Size = New System.Drawing.Size(58, 25)
        Me.Bt_Search.TabIndex = 1
        Me.Bt_Search.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 579)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1184, 22)
        Me.StatusStrip1.TabIndex = 28
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel6)
        Me.GroupBox1.Location = New System.Drawing.Point(135, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(100, 45)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SETT."
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.42105!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.57895!))
        Me.TableLayoutPanel6.Controls.Add(Me.BT_CaricaSett, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.CB_ScegliSett, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(94, 26)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'BT_CaricaSett
        '
        Me.BT_CaricaSett.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_CaricaSett.BackgroundImage = CType(resources.GetObject("BT_CaricaSett.BackgroundImage"), System.Drawing.Image)
        Me.BT_CaricaSett.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_CaricaSett.Location = New System.Drawing.Point(67, 3)
        Me.BT_CaricaSett.Name = "BT_CaricaSett"
        Me.BT_CaricaSett.Size = New System.Drawing.Size(24, 20)
        Me.BT_CaricaSett.TabIndex = 27
        Me.BT_CaricaSett.UseVisualStyleBackColor = True
        '
        'CB_ScegliSett
        '
        Me.CB_ScegliSett.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ScegliSett.FormattingEnabled = True
        Me.CB_ScegliSett.Location = New System.Drawing.Point(3, 3)
        Me.CB_ScegliSett.Name = "CB_ScegliSett"
        Me.CB_ScegliSett.Size = New System.Drawing.Size(58, 21)
        Me.CB_ScegliSett.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.Controls.Add(Me.Bt_SeeAll)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 524)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 52)
        Me.Panel1.TabIndex = 29
        '
        'FRM_OrdiniApertiV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(1184, 601)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.DGW_OrdiniAperti)
        Me.Controls.Add(Me.GB_Gestione)
        Me.Controls.Add(Me.GB_Produzione)
        Me.Controls.Add(Me.GB_Stampe)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1000, 640)
        Me.Name = "FRM_OrdiniApertiV2"
        Me.Text = "Ordini Aperti"
        Me.GB_Stampe.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GB_Produzione.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.GB_Gestione.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.DGW_OrdiniAperti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CM_Ordini.ResumeLayout(False)
        CType(Me.DGW_Ordine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.CM_Context.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bt_Evaso As Button
    Friend WithEvents Bt_InProduzione As Button
    Friend WithEvents Bt_SeeAll As Button
    Friend WithEvents Bt_Send_Rivestimenti As Button
    Friend WithEvents Bt_CheckList As Button
    Friend WithEvents Bt_Bindelli As Button
    Friend WithEvents Bt_Disegni As Button
    Friend WithEvents Bt_ConfermaOrdine As Button
    Friend WithEvents Bt_Open_ListaDiagonali As Button
    Friend WithEvents Bt_Open_ListaMorali As Button
    Friend WithEvents GB_Stampe As GroupBox
    Friend WithEvents GB_Produzione As GroupBox
    Friend WithEvents GB_Gestione As GroupBox
    Friend WithEvents DGW_OrdiniAperti As DataGridView
    Friend WithEvents DGW_Ordine As DataGridView
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents CM_Context As ContextMenuStrip
    Friend WithEvents RICERCAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents NOrdine As DataGridViewTextBoxColumn
    Friend WithEvents Riga As DataGridViewTextBoxColumn
    Friend WithEvents Imballo As DataGridViewTextBoxColumn
    Friend WithEvents Qt As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Disegno As DataGridViewTextBoxColumn
    Friend WithEvents Commessa As DataGridViewTextBoxColumn
    Friend WithEvents HT As DataGridViewCheckBoxColumn
    Friend WithEvents Consegna As DataGridViewTextBoxColumn
    Friend WithEvents Stato As DataGridViewImageColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Ck_AnteprimaStampa As CheckBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Bt_Search As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Tx_Cerca_Ordine As TextBox
    Friend WithEvents Tx_Cerca_Disegno As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Tx_Cerca_Commessa As TextBox
    Friend WithEvents Tx_Cerca_Imballo As TextBox
    Friend WithEvents Bt_Search_Chiudi As Button
    Friend WithEvents STAMPADISTINTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents STAMPABINDELLOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MODIFICAIMBALLOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ELIMINARIGAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ELIMINAORDINEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents RB_Search_Evasi As RadioButton
    Friend WithEvents Rb_Search_NonEvasi As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents RivToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ordine As DataGridViewTextBoxColumn
    Friend WithEvents Riferimento As DataGridViewTextBoxColumn
    Friend WithEvents CM_Ordini As ContextMenuStrip
    Friend WithEvents COPIARIFORDINEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CB_ScegliSett As ComboBox
    Friend WithEvents BT_CaricaSett As Button
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RB_Search_Tutti As RadioButton
End Class
