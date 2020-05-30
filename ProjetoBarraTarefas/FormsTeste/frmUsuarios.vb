Public Class frmUsuarios

    Private Sub frmBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 20
            DataGridView1.Rows.Add(i, "Carlos Henrique")
        Next
    End Sub

End Class

