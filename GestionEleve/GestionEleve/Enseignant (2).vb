Imports System.Data.OleDb
Public Class Enseignant
    Public cnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\CHRIS\Documents\Visual Studio 2010\Projects\GestionEleve\GestionEleve\bin\Debug\DataBase.accdb;Persist Security Info=False;"
    Public cn As New OleDbConnection
    Public Cmd As New OleDbCommand
    Public da As New OleDbDataAdapter
    Private Sub Effaccer()
        txt_Matricul.Text = ""
        txt_Nom.Text = ""
        txt_Postnom.Text = ""
        cb_Sexe.ValueMember = ""
        txt_Datedenaissance.Text = ""
        txt_Lieudenaissance.Text = ""
        cb_Etatcivil.SelectedItem = ""
        cb_Niveauetude.SelectedItem = ""
        txt_Religion.Text = ""
        cb_Nationalite.SelectedItem = ""
        txt_Addresse.Text = ""
        txt_Tel.Text = ""
    End Sub
    Private Sub btn_Recherche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Recherche.Click
        RechercherEnseignant.Show()
    End Sub

    Private Sub Enseignant_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cn.ConnectionString = cnString
            cn.Open()
            MsgBox("Connection Reussie a la Base des Donnees", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
    End Sub

    Private Sub btn_Add_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Add.Click
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        Try
            With Cmd
                .Connection = cn
                .CommandText = "INSERT INTO Enseignant (Matricul,Nom,Postnom,Sexe,Datedenaissance,Lieudenaissance,Etatcivil,Niveaudetude,Religion,Nationalite,Addresse,Tel) " & " VALUES ('" & Me.txt_Matricul.Text & "','" & Me.txt_Nom.Text & "','" & Me.txt_Postnom.Text & "','" & Me.cb_Sexe.Text & "','" & Me.txt_Datedenaissance.Text & "','" & Me.txt_Lieudenaissance.Text & "','" & Me.cb_Etatcivil.Text & "','" & Me.cb_Niveauetude.Text & "','" & Me.txt_Religion.Text & "','" & Me.cb_Nationalite.Text & "','" & Me.txt_Addresse.Text & "','" & Me.txt_Tel.Text & "') "
                .ExecuteNonQuery()
            End With
            MsgBox("Enregistrement reussie a la base de donnee", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
    End Sub

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        Effaccer()
    End Sub

    Private Sub btn_Parcourrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Parcourrir.Click
        Dim open As New OpenFileDialog
        open.ShowDialog()
        open.Filter = "Images (*.png)|*.png|(*.jpg)|*.jpg|(*.bmp)|*.bmp|All Files(*.*)|*.*"
        'open.Filter = "Text files (*.txt)|*.txt"
        Pic_Elece.ImageLocation = open.FileName
        txt_Pict.Text = open.SafeFileName
    End Sub

    Private Sub btn_Del_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Del.Click
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        Try
            With Cmd
                .Connection = cn
                .CommandText = "DELETE FROM Enseignant WHERE Matricul= '" & txt_Matricul.Text & "'"
                MsgBox("Voulez-vous vraiment Supprimer Cette eleve", vbYesNo)
                .ExecuteNonQuery()

            End With
            MsgBox("Suppression Reussie", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
    End Sub
End Class