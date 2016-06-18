Public Class frmLogin
    Private _DBAccess As New DataBaseAccess



    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim sqlQuery As String = String.Format("SELECT * FROM tbl_NhanVien where EmailNV = '{0}' and MatKhau = '{1}'", txtusername.Text, txtpassword.Text)
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        If dtTable.Rows.Count > 0 Then
            MessageBox.Show("Bạn đã đăng nhập với tên " & txtusername.Text)
            userName = txtusername.Text
            pass = txtpassword.Text
            Dim sqlQuery1 As String = String.Format("SELECT maNV FROM tbl_NHANVIEN where EmailNV = '{0}' and MatKhau = '{1}'", txtusername.Text, txtpassword.Text)
            maNV = _DBAccess.ExecuteScalar(sqlQuery1)
            Me.Hide()
            frmMain.Show()
        Else
            MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtusername.Select()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusername.Select()
    End Sub

    Private Function sqlQuery1() As String
        Throw New NotImplementedException
    End Function

End Class