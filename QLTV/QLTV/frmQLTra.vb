Public Class frmQLTra
    Private _DBAccess As New DataBaseAccess
    Private Sub LoadMPOnCbbBox_QLT()
        Dim sqlQuery As String = "SELECT maPhieu from tbl_PHIEUMUON"
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbmp.DataSource = dtTable
        With Me.cmbmp
            Me.cmbmp.DisplayMember = "maPhieu"
            Me.cmbmp.ValueMember = "maPhieu"
        End With
        cmbmp.SelectedIndex = -1
    End Sub

    Private Sub LoadMNVOnCbbBox_QLT()
        Dim sqlQuery As String = "SELECT maNV FROM dbo.tbl_NHANVIEN"
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbmnv.DataSource = dtTable
        With Me.cmbmnv
            Me.cmbmnv.DisplayMember = "maNV"
            Me.cmbmnv.ValueMember = "maNV"
        End With
        cmbmnv.SelectedIndex = -1
    End Sub

    Private Sub frmQLTra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMPOnCbbBox_QLT()
        LoadMNVOnCbbBox_QLT()
    End Sub

    Private Sub LoadMSOnCbbBox_QLT()
        Dim sqlQuery As String = String.Format("SELECT maSach from tbl_CTPHIEUMUON WHERE maPhieu LIKE '{0}'", cmbmp.SelectedValue)
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbms.DataSource = dtTable
        With Me.cmbms
            Me.cmbms.DisplayMember = "maSach"
            Me.cmbms.ValueMember = "maSach"
        End With
        cmbms.SelectedIndex = -1
    End Sub

    Private Sub cmbmp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmp.SelectedIndexChanged
        If cmbmp.SelectedIndex <> -1 Then
            LoadMSOnCbbBox_QLT()
        End If
    End Sub

    Private Sub btnTinh_Click(sender As Object, e As EventArgs) Handles btnTinh.Click
    End Sub
End Class