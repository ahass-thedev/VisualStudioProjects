Public Class Form7

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Button1.Text = Label2.Text
        Button1.Enabled = False
        If Label2.Text = "X" Then
            Label2.Text = "O"
        Else
            Label2.Text = "X"
        End If
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Button2.Text = Label2.Text
        Button2.Enabled = False
        If Label2.Text = "X" Then
            Label2.Text = "O"
        Else
            Label2.Text = "X"
        End If
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Button3.Text = Label2.Text
        Button3.Enabled = False
        If Label2.Text = "X" Then
            Label2.Text = "O"
        Else
            Label2.Text = "X"
        End If
    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Button4.Text = Label2.Text
        Button4.Enabled = False
        If Label2.Text = "X" Then
            Label2.Text = "O"
        Else
            Label2.Text = "X"
        End If
    End Sub
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Button5.Text = Label2.Text
        Button5.Enabled = False
        If Label2.Text = "X" Then
            Label2.Text = "O"
        Else
            Label2.Text = "X"
        End If
    End Sub
    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Button6.Text = Label2.Text
        Button6.Enabled = False
        If Label2.Text = "X" Then
            Label2.Text = "O"
        Else
            Label2.Text = "X"
        End If
    End Sub
    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Button7.Text = Label2.Text
        Button7.Enabled = False
        If Label2.Text = "X" Then
            Label2.Text = "O"
        Else
            Label2.Text = "X"
        End If
    End Sub
    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Button8.Text = Label2.Text
        Button8.Enabled = False
        If Label2.Text = "X" Then
            Label2.Text = "O"
        Else
            Label2.Text = "X"
        End If
    End Sub
    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Button9.Text = Label2.Text
        Button9.Enabled = False
        If Label2.Text = "X" Then
            Label2.Text = "O"
        Else
            Label2.Text = "X"
        End If
    End Sub
    Private Sub Form7_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        PictureBox1.Image = My.Resources.tttmarqlrg
        Me.BackgroundImage = My.Resources.Dark_Blue_Background_690x431
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Or Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Or Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Or Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Or Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Or Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Or Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            Label5.Text += 1
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
            Button6.Enabled = True
            Button7.Enabled = True
            Button8.Enabled = True
            Button9.Enabled = True
            Button1.Text = ""
            Button2.Text = ""
            Button3.Text = ""
            Button4.Text = ""
            Button5.Text = ""
            Button6.Text = ""
            Button7.Text = ""
            Button8.Text = ""
            Button9.Text = ""
            Label2.Text = "X"
        End If
        If Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Or Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Or Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Or Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Or Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Or Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Or Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
            Label6.Text += 1
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
            Button6.Enabled = True
            Button7.Enabled = True
            Button8.Enabled = True
            Button9.Enabled = True
            Button1.Text = ""
            Button2.Text = ""
            Button3.Text = ""
            Button4.Text = ""
            Button5.Text = ""
            Button6.Text = ""
            Button7.Text = ""
            Button8.Text = ""
            Button9.Text = ""
            Label2.Text = "O"
        End If
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
            Label6.Text += 1
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            'code in rest'
            Label2.Text = "O"
        End If
    End Sub
    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Label5.Text = "0"
        Label6.Text = "0"
    End Sub
End Class