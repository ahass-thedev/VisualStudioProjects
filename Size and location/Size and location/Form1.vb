Public Class Form1

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim x, y As Integer
        x = Button2.Width + 1
        y = Button2.Height + 1
        Button2.Size = New Size(x, y)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim x, y As Integer
        x = Label1.Location.X + 1
        y = Label1.Location.Y + 1
        Label1.Location = New Point(x, y)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        MessageBox.Show("Label's coordinates are: " & "(" & Label1.Location.X & " , " & Label1.Location.Y & ")")
        MessageBox.Show("Dummy’s Button Width: " & Button2.Width & " and Height: " & Button2.Height)

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim x, y As Integer
        x = Button2.Width - 1
        y = Button2.Height - 1
        Button2.Size = New Size(x, y)
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Dim label, button, buttonh, labelx As Integer
        label = Label1.Location.X
        labelx = Label1.Location.Y
        button = Button2.Height
        buttonh = Button2.Width
        Button2.Size = New Size(102, 23)
        Label1.Location = New Point(159, 96)
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim x, y, choicey, choicex As Integer
        choicex = InputBox("What do you want the new X coordinate to be?")
        choicey = InputBox("What do you want the new Y cooridnate to be?")

        x = Label1.Location.X = choicex
        y = Label1.Location.Y = choicey
        Label1.Location = New Point(choicex, choicey)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

    End Sub
End Class
