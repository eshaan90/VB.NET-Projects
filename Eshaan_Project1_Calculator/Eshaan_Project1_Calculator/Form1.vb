Public Class MyForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        MsgBox("2" & "+" & "5" & "=" & 2 + 5)
        Me.Close()

    End Sub

    Private Sub MyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("My First Visual Basic 2013 Program")
        Me.Text = "My First VB2013 Program"
        Me.BackColor = Color.Blue
        Me.MaximizeBox = False
        Me.MinimizeBox = True
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Label1.Text = Val(Label1.Text) + Val(TextBox2.Text)
    End Sub
End Class
