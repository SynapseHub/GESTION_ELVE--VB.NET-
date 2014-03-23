Public Class newCompte

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Creat.Click
        Try

            My.Settings.Username = txt_NewName.Text
            My.Settings.Password = txt_NewPwd.Text
            If txt_NewPwd.Text = txt_NewPwd2.Text Then
                My.Settings.Save()
            End If

            MsgBox("Creation du compte reussi", vbInformation)
            Me.Hide()
            Connection.Show()


        Catch ex As Exception
            MsgBox(e.ToString)
        End Try
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class