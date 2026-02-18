Public Class loading
    Private Sub loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Show()
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
    Public Async Function load() As Task(Of String)
        Me.Hide()
        Return 0
    End Function
End Class