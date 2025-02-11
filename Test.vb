Public Class Test
    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As String = "GBK2M1312023072300149331-25082              20230724     6CG24                         2023072400152014"
        MsgBox(a.Substring(52, 6))
    End Sub
End Class