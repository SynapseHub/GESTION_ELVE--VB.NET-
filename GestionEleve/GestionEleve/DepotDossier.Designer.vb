<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepotDossier
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Nomeleve = New System.Windows.Forms.TextBox()
        Me.txt_Matriculdossier = New System.Windows.Forms.TextBox()
        Me.txt_Nomdossier = New System.Windows.Forms.TextBox()
        Me.cb_Matriculeleve = New System.Windows.Forms.ComboBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(463, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DEPOT DE DOSSIER  DE  L'ELEVE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NOM DE L'ELEVE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "MATRICUL DE L'ELEVE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "MATRICUL DOSSIER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "NOM DOSSIER"
        '
        'txt_Nomeleve
        '
        Me.txt_Nomeleve.Location = New System.Drawing.Point(242, 91)
        Me.txt_Nomeleve.Name = "txt_Nomeleve"
        Me.txt_Nomeleve.Size = New System.Drawing.Size(177, 20)
        Me.txt_Nomeleve.TabIndex = 7
        '
        'txt_Matriculdossier
        '
        Me.txt_Matriculdossier.Location = New System.Drawing.Point(242, 121)
        Me.txt_Matriculdossier.Name = "txt_Matriculdossier"
        Me.txt_Matriculdossier.Size = New System.Drawing.Size(122, 20)
        Me.txt_Matriculdossier.TabIndex = 8
        '
        'txt_Nomdossier
        '
        Me.txt_Nomdossier.Location = New System.Drawing.Point(242, 151)
        Me.txt_Nomdossier.Name = "txt_Nomdossier"
        Me.txt_Nomdossier.Size = New System.Drawing.Size(177, 20)
        Me.txt_Nomdossier.TabIndex = 9
        '
        'cb_Matriculeleve
        '
        Me.cb_Matriculeleve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Matriculeleve.FormattingEnabled = True
        Me.cb_Matriculeleve.Location = New System.Drawing.Point(243, 62)
        Me.cb_Matriculeleve.Name = "cb_Matriculeleve"
        Me.cb_Matriculeleve.Size = New System.Drawing.Size(121, 21)
        Me.cb_Matriculeleve.TabIndex = 10
        '
        'btn_search
        '
        Me.btn_search.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.Location = New System.Drawing.Point(154, 272)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(182, 41)
        Me.btn_search.TabIndex = 15
        Me.btn_search.Text = "RECHERCHER"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.BackgroundImage = Global.GestionEleve.My.Resources.Resources.btn_Delete_Image
        Me.btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_del.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del.Location = New System.Drawing.Point(366, 199)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(75, 59)
        Me.btn_del.TabIndex = 14
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.BackgroundImage = Global.GestionEleve.My.Resources.Resources._1295374829_desktop
        Me.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_update.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(260, 199)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 59)
        Me.btn_update.TabIndex = 13
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.BackgroundImage = Global.GestionEleve.My.Resources.Resources.accept_icon
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(154, 199)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 59)
        Me.btn_save.TabIndex = 12
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.BackgroundImage = Global.GestionEleve.My.Resources.Resources.add_1_icon
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_add.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(48, 199)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 59)
        Me.btn_add.TabIndex = 11
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'DepotDossier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 325)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.cb_Matriculeleve)
        Me.Controls.Add(Me.txt_Nomdossier)
        Me.Controls.Add(Me.txt_Matriculdossier)
        Me.Controls.Add(Me.txt_Nomeleve)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DepotDossier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DepotDossier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Nomeleve As System.Windows.Forms.TextBox
    Friend WithEvents txt_Matriculdossier As System.Windows.Forms.TextBox
    Friend WithEvents txt_Nomdossier As System.Windows.Forms.TextBox
    Friend WithEvents cb_Matriculeleve As System.Windows.Forms.ComboBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents btn_search As System.Windows.Forms.Button
End Class
