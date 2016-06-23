Public Class frmNhanVien
    Private _DBAccess As New DataBaseAccess

    Private Function InsertNV() As Boolean
        Dim sqlQuery As String = "INSERT INTO dbo.tbl_NHANVIEN ( tenNV , gioiTinhNV ,ngaySinhNV ,dienThoaiNV ,diaChiNV , emailNV , ngayVaoLam, matKhau )"
        sqlQuery += String.Format("VALUES  (N'{0}','{1}','{2}','{3}',N'{4}','{5}','{6}','{7}')", txttennv.Text, rdbtNam.Checked, dtpkns.Value, txtsdt.Text, txtdc.Text, txtemail.Text, dtpkngayvl.Value, "123456")
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function


    Private Function isEmpty() As Boolean
        Return (String.IsNullOrEmpty(txttennv.Text) OrElse String.IsNullOrEmpty(txtsdt.Text) OrElse String.IsNullOrEmpty(txtdc.Text) _
            OrElse String.IsNullOrEmpty(txtemail.Text) OrElse dtpkngayvl.Value <= dtpkns.Value OrElse Not IsNumeric(txtsdt.Text))
    End Function

    Private Function UpdateNV() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE dbo.tbl_NHANVIEN SET tenNV = N'{0}', gioiTinhNV = '{1}', ngaySinhNV = '{2}', dienThoaiNV = '{3}', diaChiNV = N'{4}',emailNV = '{5}',ngayVaoLam = '{6}' WHERE maNV = '{7}'", _
                                               txttennv.Text, rdbtNam.Checked, dtpkns.Value, txtsdt.Text, txtdc.Text, txtemail.Text, dtpkngayvl.Value, txtmanv.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If isEmpty() Then
            MessageBox.Show("Bạn phải nhập đầy đủ thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
                If _isEdit Then
                If txtmanv.Text = maNV.ToString AndAlso UpdateNV() Then
                    MessageBox.Show("Update thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.Yes
                Else
                    If txtmanv.Text <> maNV.ToString Then
                        MessageBox.Show("Bạn chỉ có thể sửa thông tin cá nhân!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Update không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
                Else
                    If InsertNV() Then
                        MessageBox.Show("Inster thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = Windows.Forms.DialogResult.Yes
                    Else
                        MessageBox.Show("Inster không thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.DialogResult = Windows.Forms.DialogResult.No
                    End If
                End If
                Me.Close()
            End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    'Khai báo hàm kiểm tra khi nào thêm,khi nào sửa
    Private _isEdit As Boolean = False
    Public Sub New(IsEdit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _isEdit = IsEdit
    End Sub

    Private Sub frmNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txttennv.Select()
    End Sub
End Class