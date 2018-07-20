Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        PictureBox1.Size = New Size(500, 500)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim x, y As Integer
        x = PictureBox1.Width + 5
        y = PictureBox1.Height + 5
        PictureBox1.Size = New Size(x, y)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim x, y As Integer
        x = PictureBox1.Width - 5
        y = PictureBox1.Height - 5
        PictureBox1.Size = New Size(x, y)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim x, y As Integer
        Dim answer As String
        answer = InputBox("Which direction do you want the picturebox to move?                                                                   your options are: left, right, up and down")
        answer = answer.ToLower()
        If answer = "up" Then
            x = PictureBox1.Location.X + 0
            y = PictureBox1.Location.Y - 10
        ElseIf answer = "down" Then
            x = PictureBox1.Location.X + 0
            y = PictureBox1.Location.Y + 10
        ElseIf answer = "right" Then
            x = PictureBox1.Location.X + 10
            y = PictureBox1.Location.Y + 0
        ElseIf answer = "left" Then
            x = PictureBox1.Location.X - 10
            y = PictureBox1.Location.Y + 0
        Else
            MessageBox.Show("I told you the options, why didn't you choose one of those options?")
        End If
        PictureBox1.Location = New Point(x, y)
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim x, y As Integer
        PictureBox1.Size = New Size(588, 392)
        x = PictureBox1.Location.X
        y = PictureBox1.Location.Y
        PictureBox1.Location = New Point(12, 12)
    End Sub
End Class
