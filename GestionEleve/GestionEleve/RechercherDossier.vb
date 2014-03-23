Public Class RechercherDossier

    Private Sub RechercherDossier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.Dossier' table. You can move, or remove it, as needed.
        Me.DossierTableAdapter.Fill(Me.DataSet.Dossier)
        'TODO: This line of code loads data into the 'DataSet.Dossier' table. You can move, or remove it, as needed.
        Me.DossierTableAdapter.Fill(Me.DataSet.Dossier)

    End Sub
End Class