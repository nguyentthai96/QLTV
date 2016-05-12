Public Class frmMain

    Private Sub QToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub QuảnLýThểLoạiToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub QuảnLýSáchToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If _isLogin = True Then
            frmQLSach.ShowDialog()
        End If
    End Sub

    Private Sub ThôngTinPhiênBảnToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim about As String = "Phần mềm quản lý thư viện" & vbCrLf & "Phiên bản : 1.0.0"
        MessageBox.Show(about, "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub GiớiThiệuToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LiênHệToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtusername.Text = "admin" And txtpassword.Text = "admin" Then
            MessageBox.Show("Chào bạn " & txtusername.Text & "!")
            _isLogin = True
        Else
            MessageBox.Show("Đăng nhập thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtusername.Focus()
            Exit Sub
        End If
    End Sub
End Class