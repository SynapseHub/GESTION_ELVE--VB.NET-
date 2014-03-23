<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newCompte
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.txt_NewPwd2 = New System.Windows.Forms.TextBox()
        Me.txt_NewPwd = New System.Windows.Forms.TextBox()
        Me.txt_NewName = New System.Windows.Forms.TextBox()
        Me.btn_Creat = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_Cancel)
        Me.Panel1.Controls.Add(Me.txt_NewPwd2)
        Me.Panel1.Controls.Add(Me.txt_NewPwd)
        Me.Panel1.Controls.Add(Me.txt_NewName)
        Me.Panel1.Controls.Add(Me.btn_Creat)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(452, 307)
        Me.Panel1.TabIndex = 0
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackgroundImage = Global.GestionEleve.My.Resources.Resources.user_remove_icon
        Me.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cancel.Location = New System.Drawing.Point(289, 199)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 58)
        Me.btn_Cancel.TabIndex = 16
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'txt_NewPwd2
        '
        Me.txt_NewPwd2.Location = New System.Drawing.Point(238, 144)
        Me.txt_NewPwd2.Name = "txt_NewPwd2"
        Me.txt_NewPwd2.Size = New System.Drawing.Size(158, 20)
        Me.txt_NewPwd2.TabIndex = 15
        '
        'txt_NewPwd
        '
        Me.txt_NewPwd.Location = New System.Drawing.Point(238, 118)
        Me.txt_NewPwd.Name = "txt_NewPwd"
        Me.txt_NewPwd.Size = New System.Drawing.Size(158, 20)
        Me.txt_NewPwd.TabIndex = 14
        '
        'txt_NewName
        '
        Me.txt_NewName.Location = New System.Drawing.Point(238, 92)
        Me.txt_NewName.Name = "txt_NewName"
        Me.txt_NewName.Size = New System.Drawing.Size(158, 20)
        Me.txt_NewName.TabIndex = 13
        '
        'btn_Creat
        '
        Me.btn_Creat.BackgroundImage = Global.GestionEleve.My.Resources.Resources.user_add_icon
        Me.btn_Creat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Creat.Location = New System.Drawing.Point(180, 199)
        Me.btn_Creat.Name = "btn_Creat"
        Me.btn_Creat.Size = New System.Drawing.Size(75, 58)
        Me.btn_Creat.TabIndex = 12
        Me.btn_Creat.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(98, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "CONFIRMER MPS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(98, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "MOT DE PASSE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "NOM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 22)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "NOUVEAU COMPTE"
        '
        'newCompte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 307)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "newCompte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "newCompte"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_NewPwd2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_NewPwd As System.Windows.Forms.TextBox
    Friend WithEvents txt_NewName As System.Windows.Forms.TextBox
    Friend WithEvents btn_Creat As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
End Class
