<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connection
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lnk_edit = New System.Windows.Forms.LinkLabel()
        Me.lnk_New = New System.Windows.Forms.LinkLabel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Conn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_Type = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Pwd = New System.Windows.Forms.TextBox()
        Me.txt_Nom = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.GestionEleve.My.Resources.Resources.new_title
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 325)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.lnk_edit)
        Me.Panel2.Controls.Add(Me.lnk_New)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.btn_Cancel)
        Me.Panel2.Controls.Add(Me.btn_Conn)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.cb_Type)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txt_Pwd)
        Me.Panel2.Controls.Add(Me.txt_Nom)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(40, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(408, 272)
        Me.Panel2.TabIndex = 0
        '
        'lnk_edit
        '
        Me.lnk_edit.AutoSize = True
        Me.lnk_edit.Location = New System.Drawing.Point(267, 246)
        Me.lnk_edit.Name = "lnk_edit"
        Me.lnk_edit.Size = New System.Drawing.Size(82, 13)
        Me.lnk_edit.TabIndex = 12
        Me.lnk_edit.TabStop = True
        Me.lnk_edit.Text = "Modiffier le Pwd"
        '
        'lnk_New
        '
        Me.lnk_New.AutoSize = True
        Me.lnk_New.Location = New System.Drawing.Point(267, 217)
        Me.lnk_New.Name = "lnk_New"
        Me.lnk_New.Size = New System.Drawing.Size(71, 13)
        Me.lnk_New.TabIndex = 11
        Me.lnk_New.TabStop = True
        Me.lnk_New.Text = "Creer Compte"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(66, 238)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(149, 21)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Cacher les Characteres"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackgroundImage = Global.GestionEleve.My.Resources.Resources.close_icon
        Me.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cancel.Location = New System.Drawing.Point(285, 162)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 49)
        Me.btn_Cancel.TabIndex = 9
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Conn
        '
        Me.btn_Conn.BackgroundImage = Global.GestionEleve.My.Resources.Resources.accept_icon
        Me.btn_Conn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Conn.Location = New System.Drawing.Point(193, 162)
        Me.btn_Conn.Name = "btn_Conn"
        Me.btn_Conn.Size = New System.Drawing.Size(75, 49)
        Me.btn_Conn.TabIndex = 8
        Me.btn_Conn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(190, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Type"
        '
        'cb_Type
        '
        Me.cb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Type.FormattingEnabled = True
        Me.cb_Type.Items.AddRange(New Object() {"ADMIN", "INVITE"})
        Me.cb_Type.Location = New System.Drawing.Point(239, 46)
        Me.cb_Type.Name = "cb_Type"
        Me.cb_Type.Size = New System.Drawing.Size(79, 21)
        Me.cb_Type.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(149, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mot de Passe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(151, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nom"
        '
        'txt_Pwd
        '
        Me.txt_Pwd.Location = New System.Drawing.Point(239, 125)
        Me.txt_Pwd.Name = "txt_Pwd"
        Me.txt_Pwd.Size = New System.Drawing.Size(132, 20)
        Me.txt_Pwd.TabIndex = 3
        '
        'txt_Nom
        '
        Me.txt_Nom.Location = New System.Drawing.Point(239, 85)
        Me.txt_Nom.Name = "txt_Nom"
        Me.txt_Nom.Size = New System.Drawing.Size(132, 20)
        Me.txt_Nom.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.GestionEleve.My.Resources.Resources.login_icon
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(3, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(128, 143)
        Me.Panel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CONNECTION"
        '
        'Connection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 325)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Connection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connection"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Pwd As System.Windows.Forms.TextBox
    Friend WithEvents txt_Nom As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Conn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cb_Type As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents lnk_edit As System.Windows.Forms.LinkLabel
    Friend WithEvents lnk_New As System.Windows.Forms.LinkLabel
End Class
