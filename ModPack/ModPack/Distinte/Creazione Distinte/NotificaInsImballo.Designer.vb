<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NotificaInsImballo
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
        Me.Lb_Codice = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Lb_H = New System.Windows.Forms.Label()
        Me.Lb_P = New System.Windows.Forms.Label()
        Me.Lb_L = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Lb_Tipo = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Lb_Zoccoli = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Ck_Rivest = New System.Windows.Forms.CheckBox()
        Me.Lb_Rivest = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Ck_Bm = New System.Windows.Forms.CheckBox()
        Me.Ck_DT = New System.Windows.Forms.CheckBox()
        Me.Ck_HT = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Lb_M3 = New System.Windows.Forms.Label()
        Me.Lb_M2 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Lb_Prezzo = New System.Windows.Forms.Label()
        Me.Bt_Avanti = New System.Windows.Forms.Button()
        Me.Bt_Evita = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lb_Codice
        '
        Me.Lb_Codice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_Codice.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Codice.Location = New System.Drawing.Point(18, 9)
        Me.Lb_Codice.Name = "Lb_Codice"
        Me.Lb_Codice.Size = New System.Drawing.Size(398, 40)
        Me.Lb_Codice.TabIndex = 1
        Me.Lb_Codice.Text = "CODICE"
        Me.Lb_Codice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Lb_H)
        Me.GroupBox1.Controls.Add(Me.Lb_P)
        Me.GroupBox1.Controls.Add(Me.Lb_L)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 64)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dimensioni"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(269, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "x"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(125, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "x"
        '
        'Lb_H
        '
        Me.Lb_H.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_H.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_H.Location = New System.Drawing.Point(294, 20)
        Me.Lb_H.Name = "Lb_H"
        Me.Lb_H.Size = New System.Drawing.Size(110, 31)
        Me.Lb_H.TabIndex = 4
        Me.Lb_H.Text = "H"
        Me.Lb_H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lb_P
        '
        Me.Lb_P.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_P.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_P.Location = New System.Drawing.Point(150, 20)
        Me.Lb_P.Name = "Lb_P"
        Me.Lb_P.Size = New System.Drawing.Size(110, 31)
        Me.Lb_P.TabIndex = 3
        Me.Lb_P.Text = "P"
        Me.Lb_P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lb_L
        '
        Me.Lb_L.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_L.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_L.Location = New System.Drawing.Point(6, 20)
        Me.Lb_L.Name = "Lb_L"
        Me.Lb_L.Size = New System.Drawing.Size(110, 31)
        Me.Lb_L.TabIndex = 2
        Me.Lb_L.Text = "L"
        Me.Lb_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lb_Tipo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(125, 64)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo"
        '
        'Lb_Tipo
        '
        Me.Lb_Tipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_Tipo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Tipo.Location = New System.Drawing.Point(6, 21)
        Me.Lb_Tipo.Name = "Lb_Tipo"
        Me.Lb_Tipo.Size = New System.Drawing.Size(110, 31)
        Me.Lb_Tipo.TabIndex = 3
        Me.Lb_Tipo.Text = "Tipo"
        Me.Lb_Tipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Lb_Zoccoli)
        Me.GroupBox3.Location = New System.Drawing.Point(143, 122)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(125, 64)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Zoccoli"
        '
        'Lb_Zoccoli
        '
        Me.Lb_Zoccoli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_Zoccoli.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Zoccoli.Location = New System.Drawing.Point(6, 21)
        Me.Lb_Zoccoli.Name = "Lb_Zoccoli"
        Me.Lb_Zoccoli.Size = New System.Drawing.Size(110, 31)
        Me.Lb_Zoccoli.TabIndex = 3
        Me.Lb_Zoccoli.Text = "Zocc"
        Me.Lb_Zoccoli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Ck_Rivest)
        Me.GroupBox4.Controls.Add(Me.Lb_Rivest)
        Me.GroupBox4.Location = New System.Drawing.Point(274, 122)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(149, 64)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rivestimento"
        '
        'Ck_Rivest
        '
        Me.Ck_Rivest.AutoSize = True
        Me.Ck_Rivest.Location = New System.Drawing.Point(8, 31)
        Me.Ck_Rivest.Name = "Ck_Rivest"
        Me.Ck_Rivest.Size = New System.Drawing.Size(15, 14)
        Me.Ck_Rivest.TabIndex = 6
        Me.Ck_Rivest.UseVisualStyleBackColor = True
        '
        'Lb_Rivest
        '
        Me.Lb_Rivest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_Rivest.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Rivest.Location = New System.Drawing.Point(32, 21)
        Me.Lb_Rivest.Name = "Lb_Rivest"
        Me.Lb_Rivest.Size = New System.Drawing.Size(110, 31)
        Me.Lb_Rivest.TabIndex = 3
        Me.Lb_Rivest.Text = "Rivest"
        Me.Lb_Rivest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Ck_Bm)
        Me.GroupBox5.Controls.Add(Me.Ck_DT)
        Me.GroupBox5.Controls.Add(Me.Ck_HT)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 192)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(125, 118)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Caratteristiche"
        '
        'Ck_Bm
        '
        Me.Ck_Bm.AutoSize = True
        Me.Ck_Bm.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ck_Bm.Location = New System.Drawing.Point(6, 83)
        Me.Ck_Bm.Name = "Ck_Bm"
        Me.Ck_Bm.Size = New System.Drawing.Size(47, 24)
        Me.Ck_Bm.TabIndex = 2
        Me.Ck_Bm.Text = "BM"
        Me.Ck_Bm.UseVisualStyleBackColor = True
        '
        'Ck_DT
        '
        Me.Ck_DT.AutoSize = True
        Me.Ck_DT.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ck_DT.Location = New System.Drawing.Point(6, 53)
        Me.Ck_DT.Name = "Ck_DT"
        Me.Ck_DT.Size = New System.Drawing.Size(46, 24)
        Me.Ck_DT.TabIndex = 1
        Me.Ck_DT.Text = "DT"
        Me.Ck_DT.UseVisualStyleBackColor = True
        '
        'Ck_HT
        '
        Me.Ck_HT.AutoSize = True
        Me.Ck_HT.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ck_HT.Location = New System.Drawing.Point(6, 23)
        Me.Ck_HT.Name = "Ck_HT"
        Me.Ck_HT.Size = New System.Drawing.Size(46, 24)
        Me.Ck_HT.TabIndex = 0
        Me.Ck_HT.Text = "HT"
        Me.Ck_HT.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.Lb_M3)
        Me.GroupBox6.Controls.Add(Me.Lb_M2)
        Me.GroupBox6.Location = New System.Drawing.Point(143, 192)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(280, 57)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(134, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 20)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "m²"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 20)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "m³"
        '
        'Lb_M3
        '
        Me.Lb_M3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_M3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_M3.Location = New System.Drawing.Point(34, 16)
        Me.Lb_M3.Name = "Lb_M3"
        Me.Lb_M3.Size = New System.Drawing.Size(96, 31)
        Me.Lb_M3.TabIndex = 4
        Me.Lb_M3.Text = "m3"
        Me.Lb_M3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lb_M2
        '
        Me.Lb_M2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_M2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_M2.Location = New System.Drawing.Point(162, 16)
        Me.Lb_M2.Name = "Lb_M2"
        Me.Lb_M2.Size = New System.Drawing.Size(110, 31)
        Me.Lb_M2.TabIndex = 4
        Me.Lb_M2.Text = "m2"
        Me.Lb_M2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.Lb_Prezzo)
        Me.GroupBox7.Location = New System.Drawing.Point(143, 255)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(280, 55)
        Me.GroupBox7.TabIndex = 8
        Me.GroupBox7.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 20)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "€"
        '
        'Lb_Prezzo
        '
        Me.Lb_Prezzo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_Prezzo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Prezzo.Location = New System.Drawing.Point(34, 15)
        Me.Lb_Prezzo.Name = "Lb_Prezzo"
        Me.Lb_Prezzo.Size = New System.Drawing.Size(238, 31)
        Me.Lb_Prezzo.TabIndex = 7
        Me.Lb_Prezzo.Text = "Prezzo"
        Me.Lb_Prezzo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Bt_Avanti
        '
        Me.Bt_Avanti.Location = New System.Drawing.Point(12, 316)
        Me.Bt_Avanti.Name = "Bt_Avanti"
        Me.Bt_Avanti.Size = New System.Drawing.Size(352, 26)
        Me.Bt_Avanti.TabIndex = 9
        Me.Bt_Avanti.Text = ">"
        Me.Bt_Avanti.UseVisualStyleBackColor = True
        '
        'Bt_Evita
        '
        Me.Bt_Evita.Location = New System.Drawing.Point(370, 316)
        Me.Bt_Evita.Name = "Bt_Evita"
        Me.Bt_Evita.Size = New System.Drawing.Size(53, 26)
        Me.Bt_Evita.TabIndex = 10
        Me.Bt_Evita.Text = "Esci"
        Me.Bt_Evita.UseVisualStyleBackColor = True
        '
        'NotificaInsImballo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 354)
        Me.Controls.Add(Me.Bt_Evita)
        Me.Controls.Add(Me.Bt_Avanti)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Lb_Codice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NotificaInsImballo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuovo Articolo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lb_Codice As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Lb_H As Label
    Friend WithEvents Lb_P As Label
    Friend WithEvents Lb_L As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Lb_Tipo As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Lb_Zoccoli As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Ck_Rivest As CheckBox
    Friend WithEvents Lb_Rivest As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Ck_Bm As CheckBox
    Friend WithEvents Ck_DT As CheckBox
    Friend WithEvents Ck_HT As CheckBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Lb_M3 As Label
    Friend WithEvents Lb_M2 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Lb_Prezzo As Label
    Friend WithEvents Bt_Avanti As Button
    Friend WithEvents Bt_Evita As Button
End Class
