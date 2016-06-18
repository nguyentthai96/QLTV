Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsNumeric(TextBox1.Text) Then
            MessageBox.Show("NaN")
        Else
            MessageBox.Show(Double.Parse(TextBox1.Text))
        End If
    End Sub
End Class
