﻿Imports System.Data.OleDb
Public Class Points
    Public cnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\CHRIS\Documents\Visual Studio 2010\Projects\GestionEleve\GestionEleve\bin\Debug\DataBase.accdb;Persist Security Info=False;"
    Public cn As New OleDbConnection
    Public Cmd As New OleDbCommand
    Public da As New OleDbDataAdapter
    Private Sub Points_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cn.ConnectionString = cnString
            cn.Open()
            MsgBox("Connection Reussie a la Base des Donnees", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
    End Sub

    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        Try
            With Cmd
                .Connection = cn
                .CommandText = "INSERT INTO Points (MatriculEleve,NomEleve,Cours,Periode1,Periode2,Examen1,Total,Periode3,Periode4,Examen2,Total2,Final) " & " VALUES ('" & Me.txt_Matricul.Text & "','" & Me.txt_Nom.Text & "','" & Me.cb_Cours.Text & "','" & Me.txt_Periode1.Text & "','" & Me.txt_Periode2.Text & "','" & Me.txt_Examen1.Text & "','" & Me.txt_Total1.Text & "','" & Me.txt_Periode3.Text & "','" & Me.txt_Periode4.Text & "','" & Me.txt_Examen2.Text & "','" & Me.txt_Total2.Text & "','" & Me.txt_Final.Text & "') "
                .ExecuteNonQuery()
            End With
            MsgBox("Enregistrement reussie a la base de donnee", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
    End Sub

    Private Sub btn_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Del.Click
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        Try
            With Cmd
                .Connection = cn
                .CommandText = "DELETE FROM Points WHERE MatriculEleve= '" & txt_Matricul.Text & "'"
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