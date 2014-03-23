Public Class txt_User

    Private Sub btn_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exit.Click
        Me.Close()
        Connection.Show()
    End Sub

    Private Sub btn_Confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Confirm.Click
        'If txt_Confirm.Text = My.Settings.Password Then
        '    My.Forms.Connection.lnk_edit.Enabled = True
        '    My.Forms.Connection.lnk_New.Enabled = True
        '    MsgBox("Verification de Mot de Passe Admin Reussie avec Succes", vbInformation)
        '    Me.Close()
        '    Connection.Show()
        'Else
        '    MsgBox("Erreur, reesseyez encore", vbCritical)
        'End If

    End Sub
End Class