<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RechercherEnseignant
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataSet = New GestionEleve.DataSet()
        Me.EnseignantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnseignantTableAdapter = New GestionEleve.DataSetTableAdapters.EnseignantTableAdapter()
        Me.MatriculDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PostnomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatedenaissanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LieudenaissanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtatcivilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NiveaudetudeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReligionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NationaliteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnseignantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(419, 36)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "RECHERCHER  L'ENSEIGNANT"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.GestionEleve.My.Resources.Resources.listshadow1
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(-13, 111)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(617, 258)
        Me.Panel1.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MatriculDataGridViewTextBoxColumn, Me.NomDataGridViewTextBoxColumn, Me.PostnomDataGridViewTextBoxColumn, Me.SexeDataGridViewTextBoxColumn, Me.DatedenaissanceDataGridViewTextBoxColumn, Me.LieudenaissanceDataGridViewTextBoxColumn, Me.EtatcivilDataGridViewTextBoxColumn, Me.NiveaudetudeDataGridViewTextBoxColumn, Me.ReligionDataGridViewTextBoxColumn, Me.NationaliteDataGridViewTextBoxColumn, Me.AddresseDataGridViewTextBoxColumn, Me.TelDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EnseignantBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(25, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(558, 223)
        Me.DataGridView1.TabIndex = 0
        '
        'txt_Search
        '
        Me.txt_Search.Location = New System.Drawing.Point(205, 55)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(192, 20)
        Me.txt_Search.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "RECHERCHER  NOM"
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EnseignantBindingSource
        '
        Me.EnseignantBindingSource.DataMember = "Enseignant"
        Me.EnseignantBindingSource.DataSource = Me.DataSet
        '
        'EnseignantTableAdapter
        '
        Me.EnseignantTableAdapter.ClearBeforeFill = True
        '
        'MatriculDataGridViewTextBoxColumn
        '
        Me.MatriculDataGridViewTextBoxColumn.DataPropertyName = "Matricul"
        Me.MatriculDataGridViewTextBoxColumn.HeaderText = "Matricul"
        Me.MatriculDataGridViewTextBoxColumn.Name = "MatriculDataGridViewTextBoxColumn"
        Me.MatriculDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomDataGridViewTextBoxColumn
        '
        Me.NomDataGridViewTextBoxColumn.DataPropertyName = "Nom"
        Me.NomDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.NomDataGridViewTextBoxColumn.Name = "NomDataGridViewTextBoxColumn"
        Me.NomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PostnomDataGridViewTextBoxColumn
        '
        Me.PostnomDataGridViewTextBoxColumn.DataPropertyName = "Postnom"
        Me.PostnomDataGridViewTextBoxColumn.HeaderText = "Postnom"
        Me.PostnomDataGridViewTextBoxColumn.Name = "PostnomDataGridViewTextBoxColumn"
        Me.PostnomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SexeDataGridViewTextBoxColumn
        '
        Me.SexeDataGridViewTextBoxColumn.DataPropertyName = "Sexe"
        Me.SexeDataGridViewTextBoxColumn.HeaderText = "Sexe"
        Me.SexeDataGridViewTextBoxColumn.Name = "SexeDataGridViewTextBoxColumn"
        Me.SexeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatedenaissanceDataGridViewTextBoxColumn
        '
        Me.DatedenaissanceDataGridViewTextBoxColumn.DataPropertyName = "Datedenaissance"
        Me.DatedenaissanceDataGridViewTextBoxColumn.HeaderText = "Datedenaissance"
        Me.DatedenaissanceDataGridViewTextBoxColumn.Name = "DatedenaissanceDataGridViewTextBoxColumn"
        Me.DatedenaissanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LieudenaissanceDataGridViewTextBoxColumn
        '
        Me.LieudenaissanceDataGridViewTextBoxColumn.DataPropertyName = "Lieudenaissance"
        Me.LieudenaissanceDataGridViewTextBoxColumn.HeaderText = "Lieudenaissance"
        Me.LieudenaissanceDataGridViewTextBoxColumn.Name = "LieudenaissanceDataGridViewTextBoxColumn"
        Me.LieudenaissanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtatcivilDataGridViewTextBoxColumn
        '
        Me.EtatcivilDataGridViewTextBoxColumn.DataPropertyName = "Etatcivil"
        Me.EtatcivilDataGridViewTextBoxColumn.HeaderText = "Etatcivil"
        Me.EtatcivilDataGridViewTextBoxColumn.Name = "EtatcivilDataGridViewTextBoxColumn"
        Me.EtatcivilDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NiveaudetudeDataGridViewTextBoxColumn
        '
        Me.NiveaudetudeDataGridViewTextBoxColumn.DataPropertyName = "Niveaudetude"
        Me.NiveaudetudeDataGridViewTextBoxColumn.HeaderText = "Niveaudetude"
        Me.NiveaudetudeDataGridViewTextBoxColumn.Name = "NiveaudetudeDataGridViewTextBoxColumn"
        Me.NiveaudetudeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReligionDataGridViewTextBoxColumn
        '
        Me.ReligionDataGridViewTextBoxColumn.DataPropertyName = "Religion"
        Me.ReligionDataGridViewTextBoxColumn.HeaderText = "Religion"
        Me.ReligionDataGridViewTextBoxColumn.Name = "ReligionDataGridViewTextBoxColumn"
        Me.ReligionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NationaliteDataGridViewTextBoxColumn
        '
        Me.NationaliteDataGridViewTextBoxColumn.DataPropertyName = "Nationalite"
        Me.NationaliteDataGridViewTextBoxColumn.HeaderText = "Nationalite"
        Me.NationaliteDataGridViewTextBoxColumn.Name = "NationaliteDataGridViewTextBoxColumn"
        Me.NationaliteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddresseDataGridViewTextBoxColumn
        '
        Me.AddresseDataGridViewTextBoxColumn.DataPropertyName = "Addresse"
        Me.AddresseDataGridViewTextBoxColumn.HeaderText = "Addresse"
        Me.AddresseDataGridViewTextBoxColumn.Name = "AddresseDataGridViewTextBoxColumn"
        Me.AddresseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelDataGridViewTextBoxColumn
        '
        Me.TelDataGridViewTextBoxColumn.DataPropertyName = "Tel"
        Me.TelDataGridViewTextBoxColumn.HeaderText = "Tel"
        Me.TelDataGridViewTextBoxColumn.Name = "TelDataGridViewTextBoxColumn"
        Me.TelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RechercherEnseignant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(591, 358)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.Label2)
        Me.Name = "RechercherEnseignant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RechercherEnseignant"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnseignantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_Search As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataSet As GestionEleve.DataSet
    Friend WithEvents EnseignantBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EnseignantTableAdapter As GestionEleve.DataSetTableAdapters.EnseignantTableAdapter
    Friend WithEvents MatriculDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PostnomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatedenaissanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LieudenaissanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EtatcivilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NiveaudetudeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReligionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NationaliteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddresseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
