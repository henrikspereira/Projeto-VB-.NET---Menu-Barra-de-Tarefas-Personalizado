Public Class frmDashboard

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmFinalizar.Owner = Me
        frmFinalizar.ShowDialog()
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.transparecia_menu = 0 Then
            menuTarefas.BackColor = Color.Black
        Else
            menuTarefas.BackColor = Color.Transparent
        End If

        Select Case My.Settings.background
            Case 1
                Me.BackgroundImage = My.Resources.bg1
                Exit Select
            Case 2
                Me.BackgroundImage = My.Resources.bg2
                Exit Select                     
            Case 3
                Me.BackgroundImage = My.Resources.bg3
                Exit Select
        End Select

    End Sub

    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            frmOpcoes.Owner = Me
            frmOpcoes.ShowInTaskbar = False
            frmOpcoes.ShowDialog()
        Else
            If frmMenu.IsHandleCreated Then
                frmMenu.Select()
                frmMenu.BringToFront()
            Else
                frmMenu.Show()
                frmMenu.ShowInTaskbar = False
                frmMenu.Owner = Me
            End If           
        End If
    End Sub


End Class
