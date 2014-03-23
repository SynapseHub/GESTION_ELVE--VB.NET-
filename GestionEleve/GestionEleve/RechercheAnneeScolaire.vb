Public Class RechercheAnneeScolaire

    Private Sub RechercheAnneeScolaire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.Anneescolaire' table. You can move, or remove it, as needed.
        Me.AnneescolaireTableAdapter.Fill(Me.DataSet.Anneescolaire)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        My.Forms.AnneeScolaire.txt_Matricul.Text = DataGridView1.Item(0, i).Value
        My.Forms.AnneeScolaire.txt_AnneeScolaire.Text = DataGridView1.Item(1, i).Value
        'My.Forms.Eleve.txt_Postnom.Text = DataGridView1.Item(2, i).Value
        'My.Forms.Eleve.cb_Sexe.Text = DataGridView1.Item(3, i).Value
        'My.Forms.Eleve.txt_Datedenaissance.Text = DataGridView1.Item(4, i).Value
        'My.Forms.Eleve.txt_Lieudenaissance.Text = DataGridView1.Item(5, i).Value
        'My.Forms.Eleve.txt_Nomdupere.Text = DataGridView1.Item(5, i).Value
        'My.Forms.Eleve.txt_Nomdelamere.Text = DataGridView1.Item(5, i).Value
        'My.Forms.Eleve.txt_Religion.Text = DataGridView1.Item(5, i).Value
        'My.Forms.Eleve.txt_Ecoledeprov.Text = DataGridView1.Item(5, i).Value
        'My.Forms.Eleve.cb_Inscritdans.Text = DataGridView1.Item(5, i).Value
        'My.Forms.Eleve.txt_Addresse.Text = DataGridView1.Item(5, i).Value
        'My.Forms.Eleve.txt_Tel.Text = DataGridView1.Item(5, i).Value

    End Sub
End Class