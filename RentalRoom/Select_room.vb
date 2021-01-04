Public Class Select_room
    Dim mov As Boolean
    Dim movx, movy As Integer

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        mov = True
        movx = Windows.Forms.Cursor.Position.X - Me.Left
        movy = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        mov = False
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If mov Then
            Me.Left = Windows.Forms.Cursor.Position.X - movx
            Me.Top = Windows.Forms.Cursor.Position.Y - movy
        End If
    End Sub

    Private Sub btnmmn_Click(sender As Object, e As EventArgs) Handles btnmmn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Button2.BackColor = Color.FromArgb(182, 182, 182)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Form1.Show()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub

End Class