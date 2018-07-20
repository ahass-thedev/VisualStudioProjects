Public Class Form1
    Dim choice As String
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim x As String
        x = TextBox1.Text
        MessageBox.Show("The text in the box is " & x)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If ComboBox1.Text.ToLower() = "male" Then
            MessageBox.Show("You are a manly Man")
        ElseIf ComboBox1.Text.ToLower() = "female" Then
            MessageBox.Show("You are a pretty Woman")
        ElseIf ComboBox1.Text.ToLower() = "alien" Then
            MessageBox.Show("You are an Alien, strange")
        Else
            MessageBox.Show("You are a(n) " & ComboBox1.Text & " I don’t know what to say")
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        ComboBox1.Items.Add("Alien")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If TextBox2.Text = "100" Then
            MessageBox.Show("That is correct")
        Else
            MessageBox.Show("That is not correct")
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        choice = TextBox3.Text
        ComboBox1.Items.Add(choice)
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If ComboBox2.Text.ToLower() = "red" Then
            Me.BackColor = Color.Red
        ElseIf ComboBox2.Text.ToLower() = "green" Then
            Me.BackColor = Color.GreenYellow
        ElseIf ComboBox2.Text.ToLower() = "blue" Then
            Me.BackColor = Color.DodgerBlue
        ElseIf ComboBox2.Text.ToLower() = "black" Then
            Me.BackColor = Color.Black
        ElseIf ComboBox2.Text.ToLower() = "white" Then
            Me.BackColor = Color.White
        Else
            MessageBox.Show("Not a choice")
            Me.BackColor = DefaultBackColor
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        ComboBox1.Items.Remove("Alien")
        ComboBox1.Items.Remove(choice)
    End Sub
End Class
