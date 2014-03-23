<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnneeScolaire
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Matricul = New System.Windows.Forms.TextBox()
        Me.txt_AnneeScolaire = New System.Windows.Forms.MaskedTextBox()
        Me.btn_Del = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Matricul"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nom"
        '
        'txt_Matricul
        '
        Me.txt_Matricul.Location = New System.Drawing.Point(128, 78)
        Me.txt_Matricul.Name = "txt_Matricul"
        Me.txt_Matricul.Size = New System.Drawing.Size(94, 20)
        Me.txt_Matricul.TabIndex = 6
        '
        'txt_AnneeScolaire
        '
        Me.txt_AnneeScolaire.Location = New System.Drawing.Point(128, 107)
        Me.txt_AnneeScolaire.Mask = "0000-0000"
        Me.txt_AnneeScolaire.Name = "txt_AnneeScolaire"
        Me.txt_AnneeScolaire.Size = New System.Drawing.Size(92, 20)
        Me.txt_AnneeScolaire.TabIndex = 7
        '
        'btn_Del
        '
        Me.btn_Del.BackgroundImage = Global.GestionEleve.My.Resources.Resources.btn_Delete_Image
        Me.btn_Del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Del.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Del.Location = New System.Drawing.Point(217, 149)
        Me.btn_Del.Name = "btn_Del"
        Me.btn_Del.Size = New System.Drawing.Size(64, 59)
        Me.btn_Del.TabIndex = 18
        Me.btn_Del.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.BackgroundImage = Global.GestionEleve.My.Resources.Resources._1295374829_desktop
        Me.btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Edit.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit.Location = New System.Drawing.Point(147, 149)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(64, 59)
        Me.btn_Edit.TabIndex = 17
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'btn_Add
        '
        Me.btn_Add.BackgroundImage = Global.GestionEleve.My.Resources.Resources.accept_icon
        Me.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Add.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.Location = New System.Drawing.Point(77, 149)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(64, 59)
        Me.btn_Add.TabIndex = 16
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.BackgroundImage = Global.GestionEleve.My.Resources.Resources.add_1_icon
        Me.btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_New.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_New.Location = New System.Drawing.Point(7, 149)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(64, 59)
        Me.btn_New.TabIndex = 15
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'btn_Search
        '
        Me.btn_Search.BackgroundImage = Global.GestionEleve.My.Resources.Resources.summary_icon
        Me.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Search.Location = New System.Drawing.Point(109, 214)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(75, 61)
        Me.btn_Search.TabIndex = 19
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ANNEE SCOLAIRE"
        '
        'AnneeScolaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 285)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.btn_Del)
        Me.Controls.Add(Me.btn_Edit)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.btn_New)
        Me.Controls.Add(Me.txt_AnneeScolaire)
        Me.Controls.Add(Me.txt_Matricul)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AnneeScolaire"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AnneeScolaire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Matricul As System.Windows.Forms.TextBox
    Friend WithEvents txt_AnneeScolaire As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_Del As System.Windows.Forms.Button
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents btn_New As System.Windows.Forms.Button
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
