Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Welcome to VB")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim username As String
        username = "Bob"
        username = InputBox("What is your name?")
        MessageBox.Show(username)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        MessageBox.Show("This is my first Visual Basic Program")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim fav As String
        fav = "5"
        fav = InputBox("What is your favortie number?")
        MessageBox.Show(fav)
    End Sub
End Class
