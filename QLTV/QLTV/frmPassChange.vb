Public Class frmPassChange
    Private _DBAccess As New DataBaseAccess

    Private Function ChangePass() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE dbo.tbl_NHANVIEN SET matKhau = '{0}' WHERE EmailNV = '{1}'", txtnewpass.Text, userName)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Function Check() As Boolean
        If (String.IsNullOrEmpty(txtcurrentpass.Text)) Then
            MessageBox.Show("Bạn phải nhập mật khẩu hiện tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtcurrentpass.Focus()
            Return False
        ElseIf (txtcurrentpass.Text <> pass) Then
            MessageBox.Show("Mật khẩu cũ không khớp!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtcurrentpass.Focus()
            Return False
        ElseIf (String.IsNullOrEmpty(txtnewpass.Text)) Then
            MessageBox.Show("Bạn phải nhập mật khẩu mới!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtnewpass.Focus()
            Return False
        ElseIf (String.IsNullOrEmpty(txtnewpass1.Text)) Then
            MessageBox.Show("Bạn phải nhập lại mật khẩu mới!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtnewpass1.Focus()
            Return False
        ElseIf (txtnewpass.Text = txtcurrentpass.Text) Then
            MessageBox.Show("Mật khẩu mới phải khác mật khẩu hiện tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtnewpass.Text = ""
            txtnewpass1.Text = ""
            txtnewpass.Focus()
            Return False
        ElseIf (txtnewpass.Text <> txtnewpass1.Text) Then
            MessageBox.Show("Mật khẩu mới không khớp!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtnewpass.Text = ""
            txtnewpass1.Text = ""
            txtnewpass.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub frmPassChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtcurrentpass.Select()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If Check() = True Then
            If ChangePass() Then
                MessageBox.Show("Thay đổi mật khẩu thành công!, mời bạn đăng nhập lại!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.Yes
            Else
                MessageBox.Show("Thay đổi mật khẩu thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DialogResult = Windows.Forms.DialogResult.No
            End If
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class