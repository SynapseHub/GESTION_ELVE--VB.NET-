Public Class RechercherEnseignant

    Private Sub RechercherEnseignant_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.EnseignantTableAdapter.Fill(Me.DataSet.Enseignant)
    End Sub
End Class