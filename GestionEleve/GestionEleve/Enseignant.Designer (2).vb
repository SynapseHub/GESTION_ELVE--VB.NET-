<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enseignant
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
        Me.btn_Parcourrir = New System.Windows.Forms.Button()
        Me.txt_Pict = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cb_Sexe = New System.Windows.Forms.ComboBox()
        Me.txt_Religion = New System.Windows.Forms.TextBox()
        Me.txt_Lieudenaissance = New System.Windows.Forms.TextBox()
        Me.txt_Postnom = New System.Windows.Forms.TextBox()
        Me.txt_Nom = New System.Windows.Forms.TextBox()
        Me.txt_Matricul = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_Etatcivil = New System.Windows.Forms.ComboBox()
        Me.cb_Niveauetude = New System.Windows.Forms.ComboBox()
        Me.btn_Recherche = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_Nationalite = New System.Windows.Forms.ComboBox()
        Me.txt_Tel = New System.Windows.Forms.TextBox()
        Me.txt_Addresse = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_Del = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.Pic_Elece = New System.Windows.Forms.PictureBox()
        Me.txt_Datedenaissance = New System.Windows.Forms.MaskedTextBox()
        CType(Me.Pic_Elece, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Parcourrir
        '
        Me.btn_Parcourrir.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Parcourrir.Location = New System.Drawing.Point(582, 260)
        Me.btn_Parcourrir.Name = "btn_Parcourrir"
        Me.btn_Parcourrir.Size = New System.Drawing.Size(111, 28)
        Me.btn_Parcourrir.TabIndex = 57
        Me.btn_Parcourrir.Text = "PARCOURIR"
        Me.btn_Parcourrir.UseVisualStyleBackColor = True
        '
        'txt_Pict
        '
        Me.txt_Pict.Location = New System.Drawing.Point(582, 234)
        Me.txt_Pict.Name = "txt_Pict"
        Me.txt_Pict.Size = New System.Drawing.Size(111, 20)
        Me.txt_Pict.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(608, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 18)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "PHOTO"
        '
        'cb_Sexe
        '
        Me.cb_Sexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Sexe.FormattingEnabled = True
        Me.cb_Sexe.Items.AddRange(New Object() {"MASCULIN", "FEMININ"})
        Me.cb_Sexe.Location = New System.Drawing.Point(261, 150)
        Me.cb_Sexe.Name = "cb_Sexe"
        Me.cb_Sexe.Size = New System.Drawing.Size(100, 21)
        Me.cb_Sexe.TabIndex = 53
        '
        'txt_Religion
        '
        Me.txt_Religion.Location = New System.Drawing.Point(261, 283)
        Me.txt_Religion.Name = "txt_Religion"
        Me.txt_Religion.Size = New System.Drawing.Size(100, 20)
        Me.txt_Religion.TabIndex = 52
        '
        'txt_Lieudenaissance
        '
        Me.txt_Lieudenaissance.Location = New System.Drawing.Point(261, 203)
        Me.txt_Lieudenaissance.Name = "txt_Lieudenaissance"
        Me.txt_Lieudenaissance.Size = New System.Drawing.Size(168, 20)
        Me.txt_Lieudenaissance.TabIndex = 49
        '
        'txt_Postnom
        '
        Me.txt_Postnom.Location = New System.Drawing.Point(261, 124)
        Me.txt_Postnom.Name = "txt_Postnom"
        Me.txt_Postnom.Size = New System.Drawing.Size(168, 20)
        Me.txt_Postnom.TabIndex = 47
        '
        'txt_Nom
        '
        Me.txt_Nom.Location = New System.Drawing.Point(261, 98)
        Me.txt_Nom.Name = "txt_Nom"
        Me.txt_Nom.Size = New System.Drawing.Size(168, 20)
        Me.txt_Nom.TabIndex = 46
        '
        'txt_Matricul
        '
        Me.txt_Matricul.Location = New System.Drawing.Point(261, 72)
        Me.txt_Matricul.Name = "txt_Matricul"
        Me.txt_Matricul.Size = New System.Drawing.Size(100, 20)
        Me.txt_Matricul.TabIndex = 45
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(87, 182)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(156, 18)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "DATE DE NAISSANCE"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(87, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 18)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "NOM"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(87, 260)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 18)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "NIVEAU D'ETUDE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(87, 130)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 18)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "POSTNOM"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(87, 208)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(154, 18)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "LIEU DE NAISSANCE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(87, 286)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 18)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "RELIGION"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(87, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 18)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "SEXE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(87, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 18)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "ETAT CIVIL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(87, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 18)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "MATRICULE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(246, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 36)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "ENSEIGNANT"
        '
        'cb_Etatcivil
        '
        Me.cb_Etatcivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Etatcivil.FormattingEnabled = True
        Me.cb_Etatcivil.Items.AddRange(New Object() {"MARIE(E)", "CELIBATAIRE", "DIVORCE(E)", "VEUF(VE)"})
        Me.cb_Etatcivil.Location = New System.Drawing.Point(261, 229)
        Me.cb_Etatcivil.Name = "cb_Etatcivil"
        Me.cb_Etatcivil.Size = New System.Drawing.Size(100, 21)
        Me.cb_Etatcivil.TabIndex = 58
        '
        'cb_Niveauetude
        '
        Me.cb_Niveauetude.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Niveauetude.FormattingEnabled = True
        Me.cb_Niveauetude.Items.AddRange(New Object() {"DIPLOME (D6)", "GRADUAT", "LICENCIE", "ASSISTANT", "CT", "PROFESSEUR"})
        Me.cb_Niveauetude.Location = New System.Drawing.Point(261, 256)
        Me.cb_Niveauetude.Name = "cb_Niveauetude"
        Me.cb_Niveauetude.Size = New System.Drawing.Size(100, 21)
        Me.cb_Niveauetude.TabIndex = 59
        '
        'btn_Recherche
        '
        Me.btn_Recherche.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Recherche.Location = New System.Drawing.Point(569, 294)
        Me.btn_Recherche.Name = "btn_Recherche"
        Me.btn_Recherche.Size = New System.Drawing.Size(146, 44)
        Me.btn_Recherche.TabIndex = 65
        Me.btn_Recherche.Text = "RECHERCHER"
        Me.btn_Recherche.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(87, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 18)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "NATIONALITE"
        '
        'cb_Nationalite
        '
        Me.cb_Nationalite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Nationalite.FormattingEnabled = True
        Me.cb_Nationalite.Items.AddRange(New Object() {"CONGLAISE", "RWANDAISE", "UGANDAISE", "BURUNDAISE", "INDIENNE"})
        Me.cb_Nationalite.Location = New System.Drawing.Point(261, 307)
        Me.cb_Nationalite.Name = "cb_Nationalite"
        Me.cb_Nationalite.Size = New System.Drawing.Size(121, 21)
        Me.cb_Nationalite.TabIndex = 70
        '
        'txt_Tel
        '
        Me.txt_Tel.Location = New System.Drawing.Point(261, 360)
        Me.txt_Tel.Name = "txt_Tel"
        Me.txt_Tel.Size = New System.Drawing.Size(100, 20)
        Me.txt_Tel.TabIndex = 74
        '
        'txt_Addresse
        '
        Me.txt_Addresse.Location = New System.Drawing.Point(261, 334)
        Me.txt_Addresse.Name = "txt_Addresse"
        Me.txt_Addresse.Size = New System.Drawing.Size(168, 20)
        Me.txt_Addresse.TabIndex = 73
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(87, 360)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 18)
        Me.Label15.TabIndex = 72
        Me.Label15.Text = "TEL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(87, 334)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 18)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "ADDRESSE"
        '
        'btn_Del
        '
        Me.btn_Del.BackgroundImage = Global.GestionEleve.My.Resources.Resources.btn_Delete_Image
        Me.btn_Del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Del.Location = New System.Drawing.Point(569, 415)
        Me.btn_Del.Name = "btn_Del"
        Me.btn_Del.Size = New System.Drawing.Size(75, 61)
        Me.btn_Del.TabIndex = 68
        Me.btn_Del.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.BackgroundImage = Global.GestionEleve.My.Resources.Resources._1295374829_desktop
        Me.btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Edit.Location = New System.Drawing.Point(415, 415)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(75, 61)
        Me.btn_Edit.TabIndex = 67
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'btn_Add
        '
        Me.btn_Add.BackgroundImage = Global.GestionEleve.My.Resources.Resources.user_accept_icon
        Me.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Add.Location = New System.Drawing.Point(261, 415)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(75, 61)
        Me.btn_Add.TabIndex = 66
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.BackgroundImage = Global.GestionEleve.My.Resources.Resources.user_add_icon
        Me.btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_New.Location = New System.Drawing.Point(107, 415)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(75, 61)
        Me.btn_New.TabIndex = 64
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'Pic_Elece
        '
        Me.Pic_Elece.BackgroundImage = Global.GestionEleve.My.Resources.Resources._1295352996_administrator
        Me.Pic_Elece.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Elece.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pic_Elece.Location = New System.Drawing.Point(582, 93)
        Me.Pic_Elece.Name = "Pic_Elece"
        Me.Pic_Elece.Size = New System.Drawing.Size(111, 133)
        Me.Pic_Elece.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Elece.TabIndex = 54
        Me.Pic_Elece.TabStop = False
        '
        'txt_Datedenaissance
        '
        Me.txt_Datedenaissance.Location = New System.Drawing.Point(263, 177)
        Me.txt_Datedenaissance.Mask = "00/00/0000"
        Me.txt_Datedenaissance.Name = "txt_Datedenaissance"
        Me.txt_Datedenaissance.Size = New System.Drawing.Size(105, 20)
        Me.txt_Datedenaissance.TabIndex = 75
        '
        'Enseignant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 488)
        Me.Controls.Add(Me.txt_Datedenaissance)
        Me.Controls.Add(Me.txt_Tel)
        Me.Controls.Add(Me.txt_Addresse)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cb_Nationalite)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_Del)
        Me.Controls.Add(Me.btn_Edit)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.btn_Recherche)
        Me.Controls.Add(Me.btn_New)
        Me.Controls.Add(Me.cb_Niveauetude)
        Me.Controls.Add(Me.cb_Etatcivil)
        Me.Controls.Add(Me.btn_Parcourrir)
        Me.Controls.Add(Me.txt_Pict)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Pic_Elece)
        Me.Controls.Add(Me.cb_Sexe)
        Me.Controls.Add(Me.txt_Religion)
        Me.Controls.Add(Me.txt_Lieudenaissance)
        Me.Controls.Add(Me.txt_Postnom)
        Me.Controls.Add(Me.txt_Nom)
        Me.Controls.Add(Me.txt_Matricul)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Enseignant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enseignant"
        CType(Me.Pic_Elece, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Parcourrir As System.Windows.Forms.Button
    Friend WithEvents txt_Pict As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Pic_Elece As System.Windows.Forms.PictureBox
    Friend WithEvents cb_Sexe As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Religion As System.Windows.Forms.TextBox
    Friend WithEvents txt_Lieudenaissance As System.Windows.Forms.TextBox
    Friend WithEvents txt_Postnom As System.Windows.Forms.TextBox
    Friend WithEvents txt_Nom As System.Windows.Forms.TextBox
    Friend WithEvents txt_Matricul As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cb_Etatcivil As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Niveauetude As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Del As System.Windows.Forms.Button
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents btn_Recherche As System.Windows.Forms.Button
    Friend WithEvents btn_New As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cb_Nationalite As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Tel As System.Windows.Forms.TextBox
    Friend WithEvents txt_Addresse As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_Datedenaissance As System.Windows.Forms.MaskedTextBox
End Class
