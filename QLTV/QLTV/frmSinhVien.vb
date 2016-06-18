Public Class frmSinhVien
    Private _DBAccess As New DataBaseAccess

    Private Function InsertSV() As Boolean
        'Check trùng khóa chính
        Dim _sqlQuery As String = String.Format("SELECT * FROM tbl_SINHVIEN WHERE MASV = '{0}'", txtmsv.Text)
        Dim dtTable As DataTable = _DBAccess.GetDataTable(_sqlQuery)
        If dtTable.Rows.Count > 0 Then
            MessageBox.Show("Trùng khóa chính!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Dim sqlQuery As String = "INSERT INTO dbo.tbl_SINHVIEN( maSV ,hoTenSV ,gioiTinhSV ,ngaySinhSV ,lopSV ,ngayLamThe ,ngayHetHan)"
            sqlQuery += String.Format("VALUES  ( '{0}',N'{1}','{2}','{3}','{4}','{5}','{6}')", txtmsv.Text, txttsv.Text, rdbtNam.Checked, dtpkns.Value, txtlop.Text, dtpkngaylamthe.Value, dtpkngayhethan.Value)
            Return _DBAccess.ExecuteNoneQuery(sqlQuery)
        End If
    End Function


    Private Function isEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtmsv.Text) OrElse String.IsNullOrEmpty(txttsv.Text) OrElse (rdbtNam.Checked = False And rdbtNu.Checked = False) OrElse dtpkns.Value >= Date.Today OrElse String.IsNullOrEmpty(txtlop.Text) OrElse dtpkngaylamthe.Value >= Date.Today OrElse dtpkngayhethan.Value <= dtpkngaylamthe.Value)
    End Function

    Private Function UpdateSV() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE dbo.tbl_SINHVIEN SET hoTenSV = N'{0}', gioiTinhSV = '{1}', ngaySinhSV = '{2}', lopSV = '{3}',ngayLamThe= '{4}',ngayHetHan = '{5}'  WHERE maSV = '{6}'", _
              txttsv.Text, rdbtNam.Checked, dtpkns.Value, txtlop.Text, dtpkngaylamthe.Value, dtpkngayhethan.Value, txtmsv.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If isEmpty() Then
            MessageBox.Show("Bạn phải nhập đầy đủ thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If _isEdit Then
                If UpdateSV() Then
                    MessageBox.Show("Update thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.Yes
                Else
                    MessageBox.Show("Update không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            Else
                If InsertSV() Then
                    MessageBox.Show("Inster thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.Yes
                Else
                    MessageBox.Show("Inster không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub frmSinhVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txttsv.Select()
    End Sub
End Class