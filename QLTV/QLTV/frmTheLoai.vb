Public Class frmTheLoai
    Private _DBAccess As New DataBaseAccess

    Private Function InsertTL() As Boolean
        Dim sqlQuery As String = "INSERT INTO dbo.tbl_THELOAI( tenTL )"
        sqlQuery += String.Format("VALUES  ( N'{0}')", txttentl.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function


    Private Function isEmpty() As Boolean
        Return String.IsNullOrEmpty(txttentl.Text)
    End Function

    Private Function UpdateTL() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE dbo.tbl_THELOAI SET tenTL = N'{0}' WHERE MATL = '{1}'", Me.txttentl.Text, Me.txtmtl.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If isEmpty() Then
            MessageBox.Show("Bạn phải nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If _isEdit Then
                If UpdateTL() Then
                    MessageBox.Show("Update thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.Yes
                Else
                    MessageBox.Show("Update không thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            Else
                If InsertTL() Then
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
        txttentl.Focus()
    End Sub
End Class