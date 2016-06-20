Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsNumeric(NumericUpDown1.Value) Then
            MessageBox.Show("NaN")
        Else
            MessageBox.Show(Double.Parse(NumericUpDown1.Value))
        End If
    End Sub
End Class
