Public Class Form1
    Private Sub btnDoSomething_Click(sender As Object, e As EventArgs) Handles btnDoSomething.Click
        Dim btn As Button = sender
        btn.Text = "Did Something"
        Me.rtbMessages.Text = "Sent a message!"


        Me.rtbMessages.Text += vbCrLf + "Another message!"
    End Sub
End Class
