Imports System.Data.OleDb
Public Class DepotDossier
    Public cnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\CHRIS\Documents\Visual Studio 2010\Projects\GestionEleve\GestionEleve\bin\Debug\DataBase.accdb;Persist Security Info=False;"
    Public cn As New OleDbConnection
    Public Cmd As New OleDbCommand
    Public dr As OleDb.OleDbDataReader
    Public da As New OleDbDataAdapter
    Sub fillcombo()
        cn.ConnectionString = cnString
        cn.Open()
        cnString = "SELECT * FROM Eleve"
        With Cmd
            .CommandText = cnString
            .Connection = cn
            dr = Cmd.ExecuteReader
        End With
        While (dr.Read())
            cb_Matriculeleve.Items.Add(dr.Item(0))
        End While
        Cmd.Dispose()
        dr.Close()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        RechercherDossier.Show()
    End Sub

    Private Sub DepotDossier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cn.ConnectionString = cnString
            cn.Open()
            MsgBox("Connection Reussie a la Base des Donnees", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
        Call fillcombo()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        Try
            With Cmd
                .Connection = cn
                .CommandText = "INSERT INTO Dossier (Matriculeleve,NomEleve,MatriculDossier,NomDossier) " & " VALUES ('" & Me.cb_Matriculeleve.Text & "','" & Me.txt_Nomeleve.Text & "','" & Me.txt_Matriculdossier.Text & "','" & Me.txt_Nomdossier.Text & "') "
                .ExecuteNonQuery()
            End With
            MsgBox("Enregistrement reussie a la base de donnee", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        Try
            With Cmd
                .Connection = cn
                .CommandText = "DELETE FROM Dossier WHERE MatriculDossier= '" & txt_Matriculdossier.Text & "'"
                MsgBox("Voulez-vous vraiment Supprimer Cette eleve", vbYesNo)
                .ExecuteNonQuery()

            End With
            MsgBox("Suppression Reussie", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        'MsgBox("Voulez-vous vraiment Modifier cet enregistrerment", vbYesNo)
        'If MsgBox(vbYes) Then
        Try
            With Cmd
                .Connection = cn
                .CommandText = "UPDATE Dossier SET Matriculeleve='" & Me.cb_Matriculeleve.Text & "',NomEleve='" & Me.txt_Nomeleve.Text & "',NomDossier='" & Me.txt_Nomdossier.Text & "' WHERE MatriculDossier= '" & txt_Matriculdossier.Text & "'"
                .ExecuteNonQuery()

            End With
            MsgBox("Modiffication Reussie", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
        'End If
    End Sub
End Class