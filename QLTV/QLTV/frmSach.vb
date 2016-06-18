Public Class frmSach
    Private _DBAccess As New DataBaseAccess
    Private DataItem As DataGridViewRow

    Private Sub loadMaNXBOnComboBox()
        Dim sqlQuery As String = "SELECT maNXB,tenNXB FROM dbo.tbl_NHAXUATBAN"
        Dim dataTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbmanxb.DataSource = dataTable
        Me.cmbmanxb.ValueMember = "maNXB"
        Me.cmbmanxb.DisplayMember = "tenNXB"
    End Sub

    Private Sub loadMaTLBOnComboBox()
        Dim sqlQuery As String = "SELECT maTL,tenTL FROM dbo.tbl_THELOAI"
        Dim dataTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbmatl.DataSource = dataTable
        Me.cmbmatl.ValueMember = "maTL"
        Me.cmbmatl.DisplayMember = "tenTL"
    End Sub

    Private Sub loadMaTGBOnComboBox()
        Dim sqlQuery As String = "SELECT maTG,hotenTG FROM dbo.tbl_TACGIA"
        Dim dataTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbmatg.DataSource = dataTable
        Me.cmbmatg.ValueMember = "maTG"
        Me.cmbmatg.DisplayMember = "hotenTG"
    End Sub

    Private Sub loadMaNNBOnComboBox()
        Dim sqlQuery As String = "SELECT maNN,tenNN FROM dbo.tbl_NGONNGU"
        Dim dataTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbmann.DataSource = dataTable
        Me.cmbmann.ValueMember = "maNN"
        Me.cmbmann.DisplayMember = "tenNN"
    End Sub

    Private Function InsertSach() As Boolean
        Dim sqlQuery As String = "INSERT INTO dbo.tbl_SACH( tenSach , soTrang , gia ,   soLuong ,ngayNhap ,maNXB ,maTL ,maTG ,maNN)"
        sqlQuery += String.Format("VALUES  (N'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", txtTenSach.Text, Val(txtSoTrang.Text), Val(txtGia.Text), Val(txtSoLuong.Text), _
                                  dtpkngaynhap.Value, cmbmanxb.SelectedValue, cmbmatl.SelectedValue, cmbmatg.SelectedValue, cmbmann.SelectedValue)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function


    Private Function isEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtTenSach.Text) OrElse String.IsNullOrEmpty(txtSoTrang.Text) OrElse String.IsNullOrEmpty(txtGia.Text) _
                OrElse String.IsNullOrEmpty(txtSoLuong.Text) OrElse cmbmanxb.SelectedIndex = -1 _
                OrElse cmbmatl.SelectedIndex = -1 OrElse cmbmatg.SelectedIndex = -1 OrElse cmbmann.SelectedIndex = -1 _
                OrElse Not IsNumeric(txtGia.Text) OrElse Not IsNumeric(txtSoLuong.Text) OrElse Not IsNumeric(txtSoTrang.Text))
    End Function

    Private Function UpdateSach() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE dbo.tbl_SACH SET tenSach = N'{0}', [soTrang] = '{1}', [gia] = '{2}' ,  soLuong = '{3}', ngayNhap = '{4}', maNXB = '{5}',maTL = '{6}', maTG = '{7}', maNN = '{8}' WHERE maSach = '{9}'", txtTenSach.Text, txtSoTrang.Text _
                                               , txtGia.Text, txtSoLuong.Text, dtpkngaynhap.Value, cmbmanxb.SelectedValue, cmbmatl.SelectedValue, cmbmatg.SelectedValue, cmbmann.SelectedValue, txtMaSach.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If isEmpty() Then
            MessageBox.Show("Bạn phải nhập chính xác và đầy đủ các thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If _isEdit Then
                If UpdateSach() Then
                    MessageBox.Show("Update thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.Yes
                Else
                    MessageBox.Show("Update không thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            Else
                If InsertSach() Then
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

    Public Sub New(IsEdit As Boolean, Data As DataGridViewRow)
        InitializeComponent()

        _isEdit = IsEdit
        DataItem = Data
    End Sub

    Private Sub LoadData(data As DataGridViewRow)
        txtMaSach.Text = data.Cells("maSach").Value
        txtTenSach.Text = data.Cells("TenSach").Value
        txtSoTrang.Text = data.Cells("soTrang").Value
        txtGia.Text = data.Cells("gia").Value
        txtSoLuong.Text = data.Cells("soLuong").Value
        dtpkngaynhap.Value = data.Cells("ngayNhap").Value

        cmbmanxb.SelectedValue = data.Cells("maNXB").Value
        cmbmatl.SelectedValue = data.Cells("maTL").Value
        cmbmatg.SelectedValue = data.Cells("maTG").Value
        cmbmann.SelectedValue = data.Cells("maNN").Value
    End Sub

    Private Sub frmSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTenSach.Select()
        'Gọi các thủ tục load dữ liệu lên cmbBox
        loadMaNXBOnComboBox()
        loadMaTLBOnComboBox()
        loadMaTGBOnComboBox()
        loadMaNNBOnComboBox()
        If Not DataItem Is Nothing Then
            LoadData(DataItem)
        End If
    End Sub

    Private Sub dtpkngaynhap_ValueChanged(sender As Object, e As EventArgs) Handles dtpkngaynhap.ValueChanged
    End Sub
End Class