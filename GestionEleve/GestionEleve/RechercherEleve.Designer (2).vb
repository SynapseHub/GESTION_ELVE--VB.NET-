<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RechercherEleve
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RechercherEleve))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MatriculDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PostnomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatedenaissanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LieudenaissanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomdupereDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomdelamereDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReligionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EcoledeprovDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InscritdansDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EleveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New GestionEleve.DataSet()
        Me.EleveTableAdapter = New GestionEleve.DataSetTableAdapters.EleveTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EleveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RECHERCHER L'ELEVE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "RECHERCHER  NOM"
        '
        'txt_Search
        '
        Me.txt_Search.Location = New System.Drawing.Point(218, 74)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(192, 20)
        Me.txt_Search.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.GestionEleve.My.Resources.Resources.listshadow1
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(0, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(617, 258)
        Me.Panel1.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MatriculDataGridViewTextBoxColumn, Me.NomDataGridViewTextBoxColumn, Me.PostnomDataGridViewTextBoxColumn, Me.SexeDataGridViewTextBoxColumn, Me.DatedenaissanceDataGridViewTextBoxColumn, Me.LieudenaissanceDataGridViewTextBoxColumn, Me.NomdupereDataGridViewTextBoxColumn, Me.NomdelamereDataGridViewTextBoxColumn, Me.ReligionDataGridViewTextBoxColumn, Me.EcoledeprovDataGridViewTextBoxColumn, Me.InscritdansDataGridViewTextBoxColumn, Me.AddresseDataGridViewTextBoxColumn, Me.TelDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EleveBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(23, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(559, 220)
        Me.DataGridView1.TabIndex = 1
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
        'NomdupereDataGridViewTextBoxColumn
        '
        Me.NomdupereDataGridViewTextBoxColumn.DataPropertyName = "Nomdupere"
        Me.NomdupereDataGridViewTextBoxColumn.HeaderText = "Nomdupere"
        Me.NomdupereDataGridViewTextBoxColumn.Name = "NomdupereDataGridViewTextBoxColumn"
        Me.NomdupereDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomdelamereDataGridViewTextBoxColumn
        '
        Me.NomdelamereDataGridViewTextBoxColumn.DataPropertyName = "Nomdelamere"
        Me.NomdelamereDataGridViewTextBoxColumn.HeaderText = "Nomdelamere"
        Me.NomdelamereDataGridViewTextBoxColumn.Name = "NomdelamereDataGridViewTextBoxColumn"
        Me.NomdelamereDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReligionDataGridViewTextBoxColumn
        '
        Me.ReligionDataGridViewTextBoxColumn.DataPropertyName = "Religion"
        Me.ReligionDataGridViewTextBoxColumn.HeaderText = "Religion"
        Me.ReligionDataGridViewTextBoxColumn.Name = "ReligionDataGridViewTextBoxColumn"
        Me.ReligionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EcoledeprovDataGridViewTextBoxColumn
        '
        Me.EcoledeprovDataGridViewTextBoxColumn.DataPropertyName = "Ecoledeprov"
        Me.EcoledeprovDataGridViewTextBoxColumn.HeaderText = "Ecoledeprov"
        Me.EcoledeprovDataGridViewTextBoxColumn.Name = "EcoledeprovDataGridViewTextBoxColumn"
        Me.EcoledeprovDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InscritdansDataGridViewTextBoxColumn
        '
        Me.InscritdansDataGridViewTextBoxColumn.DataPropertyName = "Inscritdans"
        Me.InscritdansDataGridViewTextBoxColumn.HeaderText = "Inscritdans"
        Me.InscritdansDataGridViewTextBoxColumn.Name = "InscritdansDataGridViewTextBoxColumn"
        Me.InscritdansDataGridViewTextBoxColumn.ReadOnly = True
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
        'EleveBindingSource
        '
        Me.EleveBindingSource.DataMember = "Eleve"
        Me.EleveBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EleveTableAdapter
        '
        Me.EleveTableAdapter.ClearBeforeFill = True
        '
        'RechercherEleve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(616, 388)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RechercherEleve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RechercherEleve"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EleveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Search As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet As GestionEleve.DataSet
    Friend WithEvents EleveBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EleveTableAdapter As GestionEleve.DataSetTableAdapters.EleveTableAdapter
    Friend WithEvents MatriculDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PostnomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatedenaissanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LieudenaissanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomdupereDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomdelamereDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReligionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EcoledeprovDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InscritdansDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddresseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
