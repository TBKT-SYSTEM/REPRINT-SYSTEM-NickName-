Module DragFormHelper
    Private drag As Boolean
    Private mouseX As Integer
    Private mouseY As Integer

    Public Sub EnableDrag(ByVal frm As Form)
        AddHandler frm.MouseDown, AddressOf Form_MouseDown
        AddHandler frm.MouseMove, AddressOf Form_MouseMove
        AddHandler frm.MouseUp, AddressOf Form_MouseUp
    End Sub

    Private Sub Form_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        drag = True
        Dim frm As Form = CType(sender, Form)
        mouseX = Windows.Forms.Cursor.Position.X - frm.Left
        mouseY = Windows.Forms.Cursor.Position.Y - frm.Top
    End Sub

    Private Sub Form_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
        If drag Then
            Dim frm As Form = CType(sender, Form)
            frm.Top = Windows.Forms.Cursor.Position.Y - mouseY
            frm.Left = Windows.Forms.Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub Form_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        drag = False
    End Sub
End Module
