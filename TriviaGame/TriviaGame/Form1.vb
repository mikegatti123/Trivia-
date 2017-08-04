Public Class Form1
    Dim question As Integer
    Dim score As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            'MsgBox("You pressed ")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton3.Checked And question = 1 Then
            MsgBox("Correct")
            score = score + 1

        ElseIf RadioButton1.Checked And question = 2 Then
            MsgBox("Correct")
            score = score + 2
        ElseIf RadioButton4.Checked And question = 3 Then
            MsgBox("Correct")
            score = score + 3
        ElseIf RadioButton3.Checked And question = 4 Then
            MsgBox("Correct")
            score = score + 4
        Else
            MsgBox("Wrong")
        End If

        Label1.Text = score

        Panel1.Enabled = False


    End Sub

    Private Sub Q1_Click(sender As Object, e As EventArgs) Handles Q1.Click

        Panel1.Enabled = True
        Label1.Text = "Who was the creater of minecraft"
        RadioButton1.Text = ("Bob")
        RadioButton2.Text = ("Robin")
        RadioButton3.Text = ("Notch")
        RadioButton4.Text = ("Batman")
        question = 1
        Q1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Panel1.Enabled = True
        Label1.Text = "Who does SuperMarioLogan play as in his video"
        RadioButton1.Text = ("Mario")
        RadioButton2.Text = ("Jeffy")
        RadioButton3.Text = ("Spongebob Squarepants")
        RadioButton4.Text = ("Popeye")
        question = 2
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Enabled = True
        Label1.Text = ("What is 20 didvide by 5")
        RadioButton1.Text = ("6")
        RadioButton2.Text = ("9")
        RadioButton3.Text = ("3")
        RadioButton4.Text = ("4")
        question = 3
        Button3.Enabled = False
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Panel1.Enabled = True
        Label1.Text = ("What is the new iphone")
        RadioButton1.Text = ("iphone3")
        RadioButton2.Text = ("iphone5")
        RadioButton3.Text = ("iphone7")
        RadioButton4.Text = ("iphone2")
        question = 4
        Button4.Enabled = False
    End Sub

End Class
