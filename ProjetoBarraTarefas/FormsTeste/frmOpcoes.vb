Public Class frmOpcoes

    Private intBackground As Integer = 0

    Private Sub frmOpcoes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.transparecia_menu = IIf(RadioButton1.Checked, 0, 1)
        My.Settings.background = intBackground
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub frmOpcoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.transparecia_menu = 0 Then
            RadioButton1.Checked = True
        Else
            RadioButton2.Checked = True
        End If

        intBackground = My.Settings.background
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        frmDashboard.menuTarefas.BackColor = Color.Black
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        frmDashboard.menuTarefas.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmDashboard.BackgroundImage = My.Resources.bg1
        intBackground = 1
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmDashboard.BackgroundImage = My.Resources.bg2
        intBackground = 2
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        frmDashboard.BackgroundImage = My.Resources.bg3
        intBackground = 3
    End Sub
End Class