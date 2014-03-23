Public Class Load

    Private Sub Load_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        Label1.Text = ProgressBar1.Value & "%"
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            Connection.Show()
        End If
    End Sub
End Class
