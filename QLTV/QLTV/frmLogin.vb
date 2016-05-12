Public Class frmLogin
    Private _DBAccess As New DataBaseAccess



    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim sqlQuery As String = String.Format("SELECT * FROM tbl_NhanVien where EmailNV = '{0}' and MatKhau = '{1}'", txtusername.Text, txtpassword.Text)
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        If dtTable.Rows.Count > 0 Then
            MessageBox.Show("Bạn đã đăng nhập với tên " & txtusername.Text)
            'Dim frm = New frmMain
            frmMain.Show()
            Me.Hide()
        Else
            MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtusername.Focus()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub frmLogin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusername.Focus()
    End Sub
End Class