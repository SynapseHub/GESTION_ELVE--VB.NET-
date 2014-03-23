<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eleve
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Eleve))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_Matricul = New System.Windows.Forms.TextBox()
        Me.txt_Nom = New System.Windows.Forms.TextBox()
        Me.txt_Postnom = New System.Windows.Forms.TextBox()
        Me.txt_Lieudenaissance = New System.Windows.Forms.TextBox()
        Me.txt_Nomdupere = New System.Windows.Forms.TextBox()
        Me.txt_Nomdelamere = New System.Windows.Forms.TextBox()
        Me.txt_Addresse = New System.Windows.Forms.TextBox()
        Me.txt_Tel = New System.Windows.Forms.TextBox()
        Me.txt_Religion = New System.Windows.Forms.TextBox()
        Me.txt_Ecoledeprov = New System.Windows.Forms.TextBox()
        Me.cb_Sexe = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Pict = New System.Windows.Forms.TextBox()
        Me.btn_Parcourrir = New System.Windows.Forms.Button()
        Me.btn_Recherche = New System.Windows.Forms.Button()
        Me.btn_Deposdocs = New System.Windows.Forms.Button()
        Me.cb_Inscritdans = New System.Windows.Forms.ComboBox()
        Me.DataSet = New GestionEleve.DataSet()
        Me.txt_Datedenaissance = New System.Windows.Forms.MaskedTextBox()
        Me.btn_Del = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.Pic_Elece = New System.Windows.Forms.PictureBox()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Elece, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(340, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INSCRIPTION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(181, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MATRICULE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(181, 363)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ADDRESSE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(181, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "INSCRIT DANS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(181, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "NOM DU PERE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(181, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "SEXE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(181, 311)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "ECOLE DE PROV"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(181, 285)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 18)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "RELIGION"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(181, 207)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(154, 18)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "LIEU DE NAISSANCE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(181, 129)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 18)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "POSTNOM"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(181, 259)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(137, 18)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "NOM DE LA MERE"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(181, 389)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 18)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "TEL"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(181, 103)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 18)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "NOM"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(181, 181)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(156, 18)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "DATE DE NAISSANCE"
        '
        'txt_Matricul
        '
        Me.txt_Matricul.Location = New System.Drawing.Point(355, 71)
        Me.txt_Matricul.Name = "txt_Matricul"
        Me.txt_Matricul.Size = New System.Drawing.Size(100, 20)
        Me.txt_Matricul.TabIndex = 17
        '
        'txt_Nom
        '
        Me.txt_Nom.Location = New System.Drawing.Point(355, 97)
        Me.txt_Nom.Name = "txt_Nom"
        Me.txt_Nom.Size = New System.Drawing.Size(168, 20)
        Me.txt_Nom.TabIndex = 18
        '
        'txt_Postnom
        '
        Me.txt_Postnom.Location = New System.Drawing.Point(355, 123)
        Me.txt_Postnom.Name = "txt_Postnom"
        Me.txt_Postnom.Size = New System.Drawing.Size(168, 20)
        Me.txt_Postnom.TabIndex = 19
        '
        'txt_Lieudenaissance
        '
        Me.txt_Lieudenaissance.Location = New System.Drawing.Point(355, 207)
        Me.txt_Lieudenaissance.Name = "txt_Lieudenaissance"
        Me.txt_Lieudenaissance.Size = New System.Drawing.Size(168, 20)
        Me.txt_Lieudenaissance.TabIndex = 22
        '
        'txt_Nomdupere
        '
        Me.txt_Nomdupere.Location = New System.Drawing.Point(355, 233)
        Me.txt_Nomdupere.Name = "txt_Nomdupere"
        Me.txt_Nomdupere.Size = New System.Drawing.Size(168, 20)
        Me.txt_Nomdupere.TabIndex = 23
        '
        'txt_Nomdelamere
        '
        Me.txt_Nomdelamere.Location = New System.Drawing.Point(355, 259)
        Me.txt_Nomdelamere.Name = "txt_Nomdelamere"
        Me.txt_Nomdelamere.Size = New System.Drawing.Size(168, 20)
        Me.txt_Nomdelamere.TabIndex = 24
        '
        'txt_Addresse
        '
        Me.txt_Addresse.Location = New System.Drawing.Point(355, 363)
        Me.txt_Addresse.Name = "txt_Addresse"
        Me.txt_Addresse.Size = New System.Drawing.Size(168, 20)
        Me.txt_Addresse.TabIndex = 26
        '
        'txt_Tel
        '
        Me.txt_Tel.Location = New System.Drawing.Point(355, 389)
        Me.txt_Tel.Name = "txt_Tel"
        Me.txt_Tel.Size = New System.Drawing.Size(100, 20)
        Me.txt_Tel.TabIndex = 27
        '
        'txt_Religion
        '
        Me.txt_Religion.Location = New System.Drawing.Point(355, 285)
        Me.txt_Religion.Name = "txt_Religion"
        Me.txt_Religion.Size = New System.Drawing.Size(100, 20)
        Me.txt_Religion.TabIndex = 28
        '
        'txt_Ecoledeprov
        '
        Me.txt_Ecoledeprov.Location = New System.Drawing.Point(355, 311)
        Me.txt_Ecoledeprov.Name = "txt_Ecoledeprov"
        Me.txt_Ecoledeprov.Size = New System.Drawing.Size(168, 20)
        Me.txt_Ecoledeprov.TabIndex = 29
        '
        'cb_Sexe
        '
        Me.cb_Sexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Sexe.FormattingEnabled = True
        Me.cb_Sexe.Items.AddRange(New Object() {"MASCULIN", "FEMININ"})
        Me.cb_Sexe.Location = New System.Drawing.Point(355, 154)
        Me.cb_Sexe.Name = "cb_Sexe"
        Me.cb_Sexe.Size = New System.Drawing.Size(100, 21)
        Me.cb_Sexe.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(702, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 18)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "PHOTO"
        '
        'txt_Pict
        '
        Me.txt_Pict.Location = New System.Drawing.Point(676, 233)
        Me.txt_Pict.Name = "txt_Pict"
        Me.txt_Pict.Size = New System.Drawing.Size(111, 20)
        Me.txt_Pict.TabIndex = 33
        '
        'btn_Parcourrir
        '
        Me.btn_Parcourrir.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Parcourrir.Location = New System.Drawing.Point(676, 259)
        Me.btn_Parcourrir.Name = "btn_Parcourrir"
        Me.btn_Parcourrir.Size = New System.Drawing.Size(111, 28)
        Me.btn_Parcourrir.TabIndex = 34
        Me.btn_Parcourrir.Text = "PARCOURIR"
        Me.btn_Parcourrir.UseVisualStyleBackColor = True
        '
        'btn_Recherche
        '
        Me.btn_Recherche.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Recherche.Location = New System.Drawing.Point(660, 313)
        Me.btn_Recherche.Name = "btn_Recherche"
        Me.btn_Recherche.Size = New System.Drawing.Size(146, 44)
        Me.btn_Recherche.TabIndex = 36
        Me.btn_Recherche.Text = "RECHERCHER"
        Me.btn_Recherche.UseVisualStyleBackColor = True
        '
        'btn_Deposdocs
        '
        Me.btn_Deposdocs.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Deposdocs.Location = New System.Drawing.Point(660, 365)
        Me.btn_Deposdocs.Name = "btn_Deposdocs"
        Me.btn_Deposdocs.Size = New System.Drawing.Size(146, 44)
        Me.btn_Deposdocs.TabIndex = 40
        Me.btn_Deposdocs.Text = "DEPOS DOCS"
        Me.btn_Deposdocs.UseVisualStyleBackColor = True
        '
        'cb_Inscritdans
        '
        Me.cb_Inscritdans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Inscritdans.FormattingEnabled = True
        Me.cb_Inscritdans.Location = New System.Drawing.Point(355, 337)
        Me.cb_Inscritdans.Name = "cb_Inscritdans"
        Me.cb_Inscritdans.Size = New System.Drawing.Size(100, 21)
        Me.cb_Inscritdans.TabIndex = 41
        Me.cb_Inscritdans.ValueMember = "Nom"
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_Datedenaissance
        '
        Me.txt_Datedenaissance.Location = New System.Drawing.Point(355, 179)
        Me.txt_Datedenaissance.Mask = "00/00/0000"
        Me.txt_Datedenaissance.Name = "txt_Datedenaissance"
        Me.txt_Datedenaissance.Size = New System.Drawing.Size(112, 20)
        Me.txt_Datedenaissance.TabIndex = 42
        '
        'btn_Del
        '
        Me.btn_Del.BackgroundImage = Global.GestionEleve.My.Resources.Resources.btn_Delete_Image
        Me.btn_Del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Del.Location = New System.Drawing.Point(640, 425)
        Me.btn_Del.Name = "btn_Del"
        Me.btn_Del.Size = New System.Drawing.Size(75, 61)
        Me.btn_Del.TabIndex = 39
        Me.btn_Del.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.BackgroundImage = Global.GestionEleve.My.Resources.Resources._1295374829_desktop
        Me.btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Edit.Location = New System.Drawing.Point(486, 425)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(75, 61)
        Me.btn_Edit.TabIndex = 38
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'btn_Add
        '
        Me.btn_Add.BackgroundImage = Global.GestionEleve.My.Resources.Resources.user_accept_icon
        Me.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Add.Location = New System.Drawing.Point(332, 425)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(75, 61)
        Me.btn_Add.TabIndex = 37
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.BackgroundImage = Global.GestionEleve.My.Resources.Resources.user_add_icon
        Me.btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_New.Location = New System.Drawing.Point(178, 425)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(75, 61)
        Me.btn_New.TabIndex = 35
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'Pic_Elece
        '
        Me.Pic_Elece.BackgroundImage = Global.GestionEleve.My.Resources.Resources.student_icon
        Me.Pic_Elece.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Elece.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pic_Elece.Location = New System.Drawing.Point(676, 92)
        Me.Pic_Elece.Name = "Pic_Elece"
        Me.Pic_Elece.Size = New System.Drawing.Size(111, 133)
        Me.Pic_Elece.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Elece.TabIndex = 31
        Me.Pic_Elece.TabStop = False
        '
        'Eleve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(857, 506)
        Me.Controls.Add(Me.txt_Datedenaissance)
        Me.Controls.Add(Me.cb_Inscritdans)
        Me.Controls.Add(Me.btn_Deposdocs)
        Me.Controls.Add(Me.btn_Del)
        Me.Controls.Add(Me.btn_Edit)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.btn_Recherche)
        Me.Controls.Add(Me.btn_New)
        Me.Controls.Add(Me.btn_Parcourrir)
        Me.Controls.Add(Me.txt_Pict)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Pic_Elece)
        Me.Controls.Add(Me.cb_Sexe)
        Me.Controls.Add(Me.txt_Ecoledeprov)
        Me.Controls.Add(Me.txt_Religion)
        Me.Controls.Add(Me.txt_Tel)
        Me.Controls.Add(Me.txt_Addresse)
        Me.Controls.Add(Me.txt_Nomdelamere)
        Me.Controls.Add(Me.txt_Nomdupere)
        Me.Controls.Add(Me.txt_Lieudenaissance)
        Me.Controls.Add(Me.txt_Postnom)
        Me.Controls.Add(Me.txt_Nom)
        Me.Controls.Add(Me.txt_Matricul)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Eleve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eleve"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Elece, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_Matricul As System.Windows.Forms.TextBox
    Friend WithEvents txt_Nom As System.Windows.Forms.TextBox
    Friend WithEvents txt_Postnom As System.Windows.Forms.TextBox
    Friend WithEvents txt_Lieudenaissance As System.Windows.Forms.TextBox
    Friend WithEvents txt_Nomdupere As System.Windows.Forms.TextBox
    Friend WithEvents txt_Nomdelamere As System.Windows.Forms.TextBox
    Friend WithEvents txt_Addresse As System.Windows.Forms.TextBox
    Friend WithEvents txt_Tel As System.Windows.Forms.TextBox
    Friend WithEvents txt_Religion As System.Windows.Forms.TextBox
    Friend WithEvents txt_Ecoledeprov As System.Windows.Forms.TextBox
    Friend WithEvents cb_Sexe As System.Windows.Forms.ComboBox
    Friend WithEvents Pic_Elece As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Pict As System.Windows.Forms.TextBox
    Friend WithEvents btn_Parcourrir As System.Windows.Forms.Button
    Friend WithEvents btn_New As System.Windows.Forms.Button
    Friend WithEvents btn_Recherche As System.Windows.Forms.Button
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_Del As System.Windows.Forms.Button
    Friend WithEvents btn_Deposdocs As System.Windows.Forms.Button
    Friend WithEvents cb_Inscritdans As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Datedenaissance As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DataSet As GestionEleve.DataSet
End Class
