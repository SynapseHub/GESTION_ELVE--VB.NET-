<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Classe
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
        Me.txt_Matricul = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Classe = New System.Windows.Forms.TextBox()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.btn_Del = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_Matricul
        '
        Me.txt_Matricul.Location = New System.Drawing.Point(126, 67)
        Me.txt_Matricul.Name = "txt_Matricul"
        Me.txt_Matricul.Size = New System.Drawing.Size(94, 20)
        Me.txt_Matricul.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 18)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Matricul"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 36)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "CLASSE"
        '
        'txt_Classe
        '
        Me.txt_Classe.Location = New System.Drawing.Point(126, 98)
        Me.txt_Classe.Name = "txt_Classe"
        Me.txt_Classe.Size = New System.Drawing.Size(100, 20)
        Me.txt_Classe.TabIndex = 30
        '
        'btn_Search
        '
        Me.btn_Search.BackgroundImage = Global.GestionEleve.My.Resources.Resources.summary_icon
        Me.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Search.Location = New System.Drawing.Point(109, 205)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(75, 61)
        Me.btn_Search.TabIndex = 29
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'btn_Del
        '
        Me.btn_Del.BackgroundImage = Global.GestionEleve.My.Resources.Resources.btn_Delete_Image
        Me.btn_Del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Del.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Del.Location = New System.Drawing.Point(214, 140)
        Me.btn_Del.Name = "btn_Del"
        Me.btn_Del.Size = New System.Drawing.Size(64, 59)
        Me.btn_Del.TabIndex = 28
        Me.btn_Del.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.BackgroundImage = Global.GestionEleve.My.Resources.Resources._1295374829_desktop
        Me.btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Edit.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit.Location = New System.Drawing.Point(144, 140)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(64, 59)
        Me.btn_Edit.TabIndex = 27
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'btn_Add
        '
        Me.btn_Add.BackgroundImage = Global.GestionEleve.My.Resources.Resources.accept_icon
        Me.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Add.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.Location = New System.Drawing.Point(74, 140)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(64, 59)
        Me.btn_Add.TabIndex = 26
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.BackgroundImage = Global.GestionEleve.My.Resources.Resources.add_1_icon
        Me.btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_New.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_New.Location = New System.Drawing.Point(4, 140)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(64, 59)
        Me.btn_New.TabIndex = 25
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'Classe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 273)
        Me.Controls.Add(Me.txt_Classe)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.btn_Del)
        Me.Controls.Add(Me.btn_Edit)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.btn_New)
        Me.Controls.Add(Me.txt_Matricul)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Classe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Classe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents btn_Del As System.Windows.Forms.Button
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents btn_New As System.Windows.Forms.Button
    Friend WithEvents txt_Matricul As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Classe As System.Windows.Forms.TextBox
End Class
