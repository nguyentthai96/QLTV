Public Class frmNgonNgu
    Private _DBAccess As New DataBaseAccess

    Private Function InsertNN() As Boolean
        Dim sqlQuery As String = "INSERT INTO dbo.tbl_NgonNgu( tenNN )"
        sqlQuery += String.Format("VALUES  ( N'{0}')", txttennn.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function


    Private Function isEmpty() As Boolean
        Return String.IsNullOrEmpty(txttennn.Text)
    End Function

    Private Function UpdateNN() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE dbo.tbl_NgonNgu SET tenNN = N'{0}' WHERE MANN = '{1}'", Me.txttennn.Text, Me.txtmnn.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If isEmpty() Then
            MessageBox.Show("Bạn phải nhập tên tác giả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If _isEdit Then
                If UpdateNN() Then
                    MessageBox.Show("Update thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.Yes
                Else
                    MessageBox.Show("Update không thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            Else
                If InsertNN() Then
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

    Private Sub frmTheLoai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txttennn.Select()
    End Sub
End Class