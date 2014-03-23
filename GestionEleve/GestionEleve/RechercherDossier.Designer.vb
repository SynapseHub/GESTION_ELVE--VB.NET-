<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RechercherDossier
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
        Me.DossierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DossierTableAdapter = New GestionEleve.DataSetTableAdapters.DossierTableAdapter()
        Me.MatriculeleveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomEleveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatriculDossierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomDossierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DossierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(510, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "RECHERCHER DOSSIER  DE  L'ELEVE"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.GestionEleve.My.Resources.Resources.listshadow1
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(39, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 226)
        Me.Panel1.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MatriculeleveDataGridViewTextBoxColumn, Me.NomEleveDataGridViewTextBoxColumn, Me.MatriculDossierDataGridViewTextBoxColumn, Me.NomDossierDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DossierBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 14)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(444, 188)
        Me.DataGridView1.TabIndex = 0
        '
        'txt_Search
        '
        Me.txt_Search.Location = New System.Drawing.Point(243, 80)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(192, 20)
        Me.txt_Search.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(101, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "RECHERCHER  NOM"
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DossierBindingSource
        '
        Me.DossierBindingSource.DataMember = "Dossier"
        Me.DossierBindingSource.DataSource = Me.DataSet
        '
        'DossierTableAdapter
        '
        Me.DossierTableAdapter.ClearBeforeFill = True
        '
        'MatriculeleveDataGridViewTextBoxColumn
        '
        Me.MatriculeleveDataGridViewTextBoxColumn.DataPropertyName = "Matriculeleve"
        Me.MatriculeleveDataGridViewTextBoxColumn.HeaderText = "Matriculeleve"
        Me.MatriculeleveDataGridViewTextBoxColumn.Name = "MatriculeleveDataGridViewTextBoxColumn"
        Me.MatriculeleveDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomEleveDataGridViewTextBoxColumn
        '
        Me.NomEleveDataGridViewTextBoxColumn.DataPropertyName = "NomEleve"
        Me.NomEleveDataGridViewTextBoxColumn.HeaderText = "NomEleve"
        Me.NomEleveDataGridViewTextBoxColumn.Name = "NomEleveDataGridViewTextBoxColumn"
        Me.NomEleveDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MatriculDossierDataGridViewTextBoxColumn
        '
        Me.MatriculDossierDataGridViewTextBoxColumn.DataPropertyName = "MatriculDossier"
        Me.MatriculDossierDataGridViewTextBoxColumn.HeaderText = "MatriculDossier"
        Me.MatriculDossierDataGridViewTextBoxColumn.Name = "MatriculDossierDataGridViewTextBoxColumn"
        Me.MatriculDossierDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomDossierDataGridViewTextBoxColumn
        '
        Me.NomDossierDataGridViewTextBoxColumn.DataPropertyName = "NomDossier"
        Me.NomDossierDataGridViewTextBoxColumn.HeaderText = "NomDossier"
        Me.NomDossierDataGridViewTextBoxColumn.Name = "NomDossierDataGridViewTextBoxColumn"
        Me.NomDossierDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RechercherDossier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(571, 366)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RechercherDossier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RechercherDossier"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DossierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_Search As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataSet As GestionEleve.DataSet
    Friend WithEvents DossierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DossierTableAdapter As GestionEleve.DataSetTableAdapters.DossierTableAdapter
    Friend WithEvents MatriculeleveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomEleveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatriculDossierDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomDossierDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
