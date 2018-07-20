Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim x, y As Integer
        If RadioButton1.Checked = True Then
            x = GroupBox1.Location.X + 0
            y = GroupBox1.Location.Y - 5
        ElseIf RadioButton2.Checked = True Then
            x = GroupBox1.Location.X + 0
            y = GroupBox1.Location.Y + 5
        ElseIf RadioButton3.Checked = True Then
            x = GroupBox1.Location.X - 5
            y = GroupBox1.Location.Y + 0
        ElseIf RadioButton4.Checked = True Then
            x = GroupBox1.Location.X + 5
            y = GroupBox1.Location.Y - 0
        Else
            MessageBox.Show("Select a button first")
        End If
        GroupBox1.Location = New Point(x, y)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        PictureBox1.Image = My.Resources.Black_Wallpaper
        Button2.Hide()
        Button5.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim x, y, choicey, choicex As Integer
        choicex = InputBox("Enter a new width")
        choicey = InputBox("Enter a new height")
        PictureBox1.Width = choicex
        PictureBox1.Height = choicey
        PictureBox1.Size = New Size(choicex, choicey)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim answer As Integer
        answer = InputBox("Enter a positive number to be factored")
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources._1509786_2
        Button5.Hide()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        PictureBox1.Image = My.Resources.Black_Wallpaper
        Button2.Show()
        Button5.Hide()
    End Sub
End Class
