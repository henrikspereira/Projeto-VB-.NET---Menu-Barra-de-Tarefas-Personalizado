Public Class frmMenu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenForm(frmFinancas, My.Resources.finance_24px)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenForm(frmUsuarios, My.Resources.account_24px)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenForm(frmNotificacoes, My.Resources.notification_24px)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OpenForm(frmMensagens, My.Resources.message_24px)
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub
End Class