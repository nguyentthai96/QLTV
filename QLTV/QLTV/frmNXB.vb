Public Class frmNXB
    Private _DBAccess As New DataBaseAccess

    Private Function InsertNXB() As Boolean
        Dim sqlQuery As String = "INSERT INTO dbo.tbl_NHAXUATBAN ( tenNXB , diaChiNXB , dienThoaiNXB , websiteNXB )"
        sqlQuery += String.Format("VALUES  ( N'{0}',N'{1}','{2}','{3}')", txttennxb.Text, txtdiachinxb.Text, txtsdtnxb.Text, txtwebsitenxb.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function


    Private Function isEmpty() As Boolean
        If txtsdtnxb.Text = "" And Not String.IsNullOrEmpty(txttennxb.Text) Then
            Return False
        Else
            Return String.IsNullOrEmpty(txttennxb.Text) OrElse Not IsNumeric(txtsdtnxb.Text)
        End If
    End Function

    Private Function UpdateNXB() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE dbo.tbl_NHAXUATBAN SET tenNXB = N'{0}', diaChiNXB = N'{1}', dienThoaiNXB = '{2}', websiteNXB = '{3}' WHERE maNXB = '{4}'", Me.txttennxb.Text, Me.txtdiachinxb.Text, _
                                               Me.txtsdtnxb.Text, Me.txtwebsitenxb.Text, txtmanxb.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If isEmpty() Then
            MessageBox.Show("Bạn phải nhập đầy đủ và chính xác các thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If _isEdit Then
                If UpdateNXB() Then
                    MessageBox.Show("Update thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.Yes
                Else
                    MessageBox.Show("Update không thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            Else
                If InsertNXB() Then
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
        txttennxb.Select()
    End Sub
End Class