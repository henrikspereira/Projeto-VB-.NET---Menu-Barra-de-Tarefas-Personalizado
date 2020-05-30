Public Class MinimizedApps

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fade_in.Tick

        Me.Opacity += 0.1
        If Me.Opacity = 1 Then Fade_in.Stop()

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Location_changer.Tick
        If Cursor.Position.X < Me.Width / 2 Then
            Me.Location = New Point(10, Screen.PrimaryScreen.Bounds.Height - frmDashboard.menuTarefas.Height - Me.Height - 10)
        Else
            Me.Location = New Point(Cursor.Position.X - (Me.Width / 2), Screen.PrimaryScreen.Bounds.Height - frmDashboard.menuTarefas.Height - Me.Height - 10)
        End If
    End Sub

End Class