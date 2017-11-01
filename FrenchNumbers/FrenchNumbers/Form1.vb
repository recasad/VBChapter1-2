Public Class Form1

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        MessageBox.Show("Un")
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        MessageBox.Show("Deux")
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        MessageBox.Show("Trois")
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        MessageBox.Show("Quatre")
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        MessageBox.Show("Cinq")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
