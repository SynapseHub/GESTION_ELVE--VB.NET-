<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class txt_User
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
        Me.txt_Confirm = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_Confirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(185, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TEST ADMIN"
        '
        'txt_Confirm
        '
        Me.txt_Confirm.Location = New System.Drawing.Point(199, 51)
        Me.txt_Confirm.Name = "txt_Confirm"
        Me.txt_Confirm.Size = New System.Drawing.Size(235, 20)
        Me.txt_Confirm.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Entrer le Mot de Passe Admin"
        '
        'btn_Exit
        '
        Me.btn_Exit.BackgroundImage = Global.GestionEleve.My.Resources.Resources.close_icon
        Me.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Exit.Location = New System.Drawing.Point(294, 79)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(75, 44)
        Me.btn_Exit.TabIndex = 4
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'btn_Confirm
        '
        Me.btn_Confirm.BackgroundImage = Global.GestionEleve.My.Resources.Resources.accept_icon
        Me.btn_Confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Confirm.Location = New System.Drawing.Point(167, 77)
        Me.btn_Confirm.Name = "btn_Confirm"
        Me.btn_Confirm.Size = New System.Drawing.Size(75, 46)
        Me.btn_Confirm.TabIndex = 3
        Me.btn_Confirm.UseVisualStyleBackColor = True
        '
        'txt_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 135)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Confirm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Confirm)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "txt_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TestUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Confirm As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Confirm As System.Windows.Forms.Button
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
End Class
