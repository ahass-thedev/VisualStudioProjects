Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim word As String
        word = InputBox("Name the form")
        Me.Text = word
        MessageBox.Show("Changing the color")
        Me.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Label1.Text = ("The new label")
        Label1.ForeColor = Color.Red
        Label1.BackColor = Color.Black
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Button1.Hide()
        Button2.Hide()
        Button3.Hide()
        Label1.Hide()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Button1.Show()
        Button2.Show()
        Button3.Show()
        Label1.Show()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim speak As String
        speak = InputBox("Name me")
        Label1.Text = speak
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Label1.Text = ("Label 1")
        Me.BackColor = DefaultBackColor
        Me.ForeColor = DefaultForeColor
        Label1.BackColor = DefaultBackColor
        Label1.ForeColor = DefaultForeColor
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
