Imports System.Data.OleDb
Public Class Connection
    Public cnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\CHRIS\Documents\Visual Studio 2010\Projects\GestionEleve\GestionEleve\bin\Debug\DataBase.accdb;Persist Security Info=False;"
    Public cn As New OleDbConnection
    Public Cmd As New OleDbCommand
    Public da As New OleDbDataAdapter
    Public dr As OleDbDataReader
    Private Sub btn_Conn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Conn.Click
        ' If txt_Nom.Text = My.Settings.Username And
        'txt_Pwd.Text = My.Settings.Password Then
        '     MsgBox("Connection a la Base de donnee reussie")
        '     Me.Close()
        '     Main.Show()
        ' Else
        '     MsgBox("Une erreur s'est produite lors du tentative d'acces a la base de donnee", vbCritical)
        ' End If
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        Try
            With Cmd
                .Connection = cn
                .CommandText = "SELECT * FROM Connection WHERE Username= @field1 and Password= @field2"
                .Parameters.AddWithValue("@field1", txt_Nom.Text)
                .Parameters.AddWithValue("@field2", txt_Pwd.Text)
                .ExecuteNonQuery()

            End With
            dr = Cmd.ExecuteReader
            If (dr.Read()) Then
                MsgBox("Connection reusssie", vbInformation)
                Me.Close()
                Main.Show()
            End If
            'MsgBox("Suppression Reussie", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then
            txt_Pwd.PasswordChar = "@"
        Else
            txt_Pwd.PasswordChar = ""
        End If
    End Sub

    Private Sub Connection_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click

    End Sub

    Private Sub Connection_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lnk_edit.Enabled = False
        lnk_New.Enabled = False
        Try
            cn.ConnectionString = cnString
            cn.Open()
            MsgBox("Connection Reussie a la Base des Donnees", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
    End Sub

    Private Sub cb_Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Type.SelectedIndexChanged
        Try
            cb_Type.SelectedText = "ADMIN"
            txt_User.Show()
            Me.Hide()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub lnk_New_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnk_New.LinkClicked
        Me.Hide()
        newCompte.Show()
    End Sub

    Private Sub lnk_edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnk_edit.LinkClicked
        Me.Hide()
        EditCompte.Show()
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class