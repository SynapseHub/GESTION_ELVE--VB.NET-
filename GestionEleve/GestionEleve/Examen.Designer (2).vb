<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Examen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Matricul = New System.Windows.Forms.TextBox()
        Me.cb_Cours = New System.Windows.Forms.ComboBox()
        Me.btn_Del = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Nom = New System.Windows.Forms.TextBox()
        Me.txt_Cotes = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Postnom = New System.Windows.Forms.TextBox()
        Me.cb_Semestre = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Denomination = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 36)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "EXAMEN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Matricul"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cours"
        '
        'txt_Matricul
        '
        Me.txt_Matricul.Location = New System.Drawing.Point(200, 59)
        Me.txt_Matricul.Name = "txt_Matricul"
        Me.txt_Matricul.Size = New System.Drawing.Size(100, 20)
        Me.txt_Matricul.TabIndex = 10
        '
        'cb_Cours
        '
        Me.cb_Cours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Cours.FormattingEnabled = True
        Me.cb_Cours.Location = New System.Drawing.Point(200, 143)
        Me.cb_Cours.Name = "cb_Cours"
        Me.cb_Cours.Size = New System.Drawing.Size(121, 21)
        Me.cb_Cours.TabIndex = 11
        '
        'btn_Del
        '
        Me.btn_Del.BackgroundImage = Global.GestionEleve.My.Resources.Resources.btn_Delete_Image
        Me.btn_Del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Del.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Del.Location = New System.Drawing.Point(333, 279)
        Me.btn_Del.Name = "btn_Del"
        Me.btn_Del.Size = New System.Drawing.Size(64, 59)
        Me.btn_Del.TabIndex = 38
        Me.btn_Del.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.BackgroundImage = Global.GestionEleve.My.Resources.Resources._1295374829_desktop
        Me.btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Edit.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit.Location = New System.Drawing.Point(239, 279)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(64, 59)
        Me.btn_Edit.TabIndex = 37
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'btn_Add
        '
        Me.btn_Add.BackgroundImage = Global.GestionEleve.My.Resources.Resources.accept_icon
        Me.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Add.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.Location = New System.Drawing.Point(145, 279)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(64, 59)
        Me.btn_Add.TabIndex = 36
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.BackgroundImage = Global.GestionEleve.My.Resources.Resources.add_1_icon
        Me.btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_New.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_New.Location = New System.Drawing.Point(51, 279)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(64, 59)
        Me.btn_New.TabIndex = 35
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(112, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 18)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Eleve"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(112, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 18)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Cotes"
        '
        'txt_Nom
        '
        Me.txt_Nom.Location = New System.Drawing.Point(200, 175)
        Me.txt_Nom.Name = "txt_Nom"
        Me.txt_Nom.Size = New System.Drawing.Size(100, 20)
        Me.txt_Nom.TabIndex = 41
        '
        'txt_Cotes
        '
        Me.txt_Cotes.Location = New System.Drawing.Point(200, 206)
        Me.txt_Cotes.Name = "txt_Cotes"
        Me.txt_Cotes.Size = New System.Drawing.Size(72, 20)
        Me.txt_Cotes.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(278, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 17)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Points"
        '
        'txt_Postnom
        '
        Me.txt_Postnom.Location = New System.Drawing.Point(306, 175)
        Me.txt_Postnom.Name = "txt_Postnom"
        Me.txt_Postnom.Size = New System.Drawing.Size(100, 20)
        Me.txt_Postnom.TabIndex = 44
        '
        'cb_Semestre
        '
        Me.cb_Semestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Semestre.FormattingEnabled = True
        Me.cb_Semestre.Items.AddRange(New Object() {"1er Semestre", "2eme Semetre"})
        Me.cb_Semestre.Location = New System.Drawing.Point(200, 111)
        Me.cb_Semestre.Name = "cb_Semestre"
        Me.cb_Semestre.Size = New System.Drawing.Size(121, 21)
        Me.cb_Semestre.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(112, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 18)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Semestre"
        '
        'txt_Denomination
        '
        Me.txt_Denomination.Location = New System.Drawing.Point(200, 85)
        Me.txt_Denomination.Name = "txt_Denomination"
        Me.txt_Denomination.Size = New System.Drawing.Size(100, 20)
        Me.txt_Denomination.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(112, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 18)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Denomination"
        '
        'Examen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 361)
        Me.Controls.Add(Me.txt_Denomination)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cb_Semestre)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_Postnom)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_Cotes)
        Me.Controls.Add(Me.txt_Nom)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_Del)
        Me.Controls.Add(Me.btn_Edit)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.btn_New)
        Me.Controls.Add(Me.cb_Cours)
        Me.Controls.Add(Me.txt_Matricul)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Examen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Examen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Matricul As System.Windows.Forms.TextBox
    Friend WithEvents cb_Cours As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Del As System.Windows.Forms.Button
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents btn_New As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Nom As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cotes As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Postnom As System.Windows.Forms.TextBox
    Friend WithEvents cb_Semestre As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Denomination As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
