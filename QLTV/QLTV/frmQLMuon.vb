Public Class frmQLMuon
    Private _DBAccess As New DataBaseAccess

    Private Function isEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtmsv.Text) OrElse String.IsNullOrEmpty(txtmnv.Text) OrElse String.IsNullOrEmpty(txtms.Text) _
                OrElse dtpkht.Value <= dtpkngaymuon.Value OrElse Not IsNumeric(txttc.Text))
    End Function

    Private Function UpdatePM() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE dbo.tbl_PHIEUMUON SET maSV = '{0}',maNV= '{1}' WHERE maPhieu = '{2}'", _
                                               txtmsv.Text, txtmnv.Text, txtmp.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Function UpdateCTPM() As Boolean
        Dim x As Double
        If String.IsNullOrEmpty(txttc.Text) Then
            x = 0
        Else
            x = Double.Parse(txttc.Text)
        End If
        Dim sqlQuery As String = String.Format("UPDATE dbo.tbl_CTPHIEUMUON SET  hanTra = '{0}',tienCoc = '{1}' WHERE maPhieu = '{2}' AND maSach = '{3}'", _
                             dtpkht.Value, x, txtmp.Text, txtms.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If isEmpty() Then
            MessageBox.Show("Bạn phải nhập đủ thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If UpdatePM() And UpdateCTPM() Then
                MessageBox.Show("Update thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.Yes
            Else
                MessageBox.Show("Update không thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DialogResult = Windows.Forms.DialogResult.No
            End If
        End If
        Me.Close()
    End Sub

    Private Sub frmTheLoai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtmsv.Select()
    End Sub

    Private Sub bntCancel_Click(sender As Object, e As EventArgs) Handles bntCancel.Click
        Me.Close()
    End Sub
End Class