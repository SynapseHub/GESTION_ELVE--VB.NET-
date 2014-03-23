Public Class Main

    Private Sub EleveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EleveToolStripMenuItem.Click
        Eleve.Show()
    End Sub

    Private Sub EnseignantToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EnseignantToolStripMenuItem.Click
        Enseignant.Show()
    End Sub

    Private Sub ConnectionToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ConnectionToolStripMenuItem.Click
        Connection.Show()
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DocierToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DocierToolStripMenuItem.Click
        DepotDossier.Show()
    End Sub

    Private Sub AnneeScolaireToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnneeScolaireToolStripMenuItem.Click
        AnneeScolaire.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Cours.Show()
    End Sub

    Private Sub ClasseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClasseToolStripMenuItem.Click
        Examen.Show()
    End Sub

    Private Sub PointsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PointsToolStripMenuItem.Click
        Points.Show()
    End Sub

    Private Sub PalmaresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PalmaresToolStripMenuItem.Click
        Palmares.Show()
    End Sub

    Private Sub ClasseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClasseToolStripMenuItem1.Click
        Classe.Show()
    End Sub
End Class