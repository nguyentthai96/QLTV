Public Class frmMain
    'Khai báo obj class DataBaseAccess
    Private _DBAccess As New DataBaseAccess

    'Load Data Sach on GridView
    Private Sub LoadDataSachOnGridview()
        Dim sqlQuery As String = "SELECT [maSach],[tenSach],[soTrang],[gia],[soLuong],[ngayNhap],[maNXB],[maTL],[maTG],[maNN],[tinhTrang] = (CASE [tinhTrang] WHEN 'True' THEN N'Còn' WHEN 'False' THEN N'Hết' end) FROM dbo.tbl_SACH"
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dtgvSach.DataSource = dtTable
        With Me.dtgvSach
            .Columns(0).HeaderText = "Mã Sách"
            .Columns(1).HeaderText = "Tên Sách"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "Số Trang"
            .Columns(3).HeaderText = "Giá"
            .Columns(4).HeaderText = "Số Lượng"
            .Columns(5).HeaderText = "Ngày Nhập"
            .Columns(6).HeaderText = "Mã NXB"
            .Columns(7).HeaderText = "Mã TL"
            .Columns(8).HeaderText = "Mã TG"
            .Columns(9).HeaderText = "Mã NN"
            .Columns(10).HeaderText = "Tình Trạng"
        End With
    End Sub

    'Private Sub LoadDataSachOnGridviewMuon()
    '    Dim sqlQuery As String = "SELECT * FROM dbo.tbl_SACH"
    '    Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
    '    Me.dtgrMuonSach.DataSource = dtTable
    '    With Me.dtgrMuonSach
    '        .Columns(0).HeaderText = "Mã Sách"
    '        .Columns(1).HeaderText = "Tên Sách"
    '        .Columns(1).Width = 150
    '        .Columns(2).HeaderText = "Số Trang"
    '        .Columns(3).HeaderText = "Giá"
    '        .Columns(4).HeaderText = "Số Lượng"
    '        .Columns(5).HeaderText = "Ngày Nhập"
    '        .Columns(6).HeaderText = "Mã NXB"
    '        .Columns(7).HeaderText = "Mã TL"
    '        .Columns(8).HeaderText = "Mã TG"
    '        .Columns(9).HeaderText = "Mã NN"
    '        .Columns(10).HeaderText = "Tình Trạng"
    '    End With
    'End Sub

    Private Sub LoadDataTLOnGridview()
        Dim sqlQuery As String = "SELECT * FROM dbo.tbl_THELOAI"
        Dim dataTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dtgrTheLoai.DataSource = dataTable
        With Me.dtgrTheLoai
            .Columns(0).HeaderText = "Mã Thể Loại"
            .Columns(0).Width = 200
            .Columns(1).Width = 200
            .Columns(1).HeaderText = "Tên Thể Loại"
        End With
    End Sub

    Private Sub LoadDataTGOnGridview()
        Dim sqlQuery As String = "SELECT * FROM dbo.tbl_TACGIA"
        Dim dataTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dtgrTG.DataSource = dataTable
        With Me.dtgrTG
            .Columns(0).HeaderText = "Mã Tác Giả"
            .Columns(0).Width = 200
            .Columns(1).Width = 200
            .Columns(1).HeaderText = "Tên Tác Giả"
        End With
    End Sub

    Private Sub LoadDataNNOnGridview()
        Dim sqlQuery As String = "SELECT * FROM dbo.tbl_NgonNgu"
        Dim dataTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dtgrNN.DataSource = dataTable
        With Me.dtgrNN
            .Columns(0).HeaderText = "Mã Ngôn Ngữ"
            .Columns(0).Width = 200
            .Columns(1).Width = 200
            .Columns(1).HeaderText = "Tên Ngôn Ngữ"
        End With
    End Sub

    Private Sub LoadDataNXBOnGridview()
        Dim sqlQuery As String = "SELECT * FROM dbo.tbl_NHAXUATBAN"
        Dim dataTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dtgrNXB.DataSource = dataTable
        With Me.dtgrNXB
            .Columns(0).HeaderText = "Mã NXB"
            .Columns(1).HeaderText = "Tên NXB"
            .Columns(1).Width = 200
            .Columns(2).Width = 200
            .Columns(4).Width = 200
            .Columns(2).HeaderText = "Địa chỉ"
            .Columns(3).HeaderText = "Số điện thoại"
            .Columns(4).HeaderText = "Website"
        End With
    End Sub

    Private Sub LoadDataNVOnGridview()
        Dim sqlQuery As String = "SELECT maNV,tenNV,gioiTinhNV = (CASE gioiTinhNV WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END),ngaySinhNV,dienThoaiNV,diaChiNV,emailNV,ngayVaoLam,matKhau FROM dbo.tbl_NHANVIEN"
        Dim dataTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dtgrNV.DataSource = dataTable
        With Me.dtgrNV
            .Columns(0).HeaderText = "Mã NV"
            .Columns(1).HeaderText = "Tên NV"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "Giới Tính"
            .Columns(3).HeaderText = "Ngày Sinh"
            .Columns(4).HeaderText = "Điện Thoại"
            .Columns(5).HeaderText = "Địa Chỉ"
            .Columns(6).HeaderText = "Email"
            .Columns(7).HeaderText = "Ngày vào"
            .Columns(8).HeaderText = "Mật khẩu"
        End With
    End Sub


    Private Sub LoadDataSVOnGridview()
        Dim sqlQuery As String = "SELECT [maSV],[hoTenSV],[gioiTinhSV] = (CASE gioiTinhSV WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END),[ngaySinhSV],[lopSV],[ngayLamThe],[ngayHetHan] FROM dbo.tbl_SINHVIEN"
        Dim dataTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dtgrSV.DataSource = dataTable
        With Me.dtgrSV
            .Columns(0).HeaderText = "Mã sinh viên"
            .Columns(1).HeaderText = "Tên sinh viên"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "Giới Tính"
            .Columns(3).HeaderText = "Ngày Sinh"
            .Columns(4).HeaderText = "Lớp"
            .Columns(5).HeaderText = "Ngày Làm Thẻ"
            .Columns(6).HeaderText = "Ngày Hết Hạn"
        End With
    End Sub

    'Private Sub LoadDataMuonOnGridview()
    '    Dim sqlQuery As String = "SELECT * FROM dbo.tbl_SINHVIEN"
    '    Dim dataTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
    '    Me.dtgrSV.DataSource = dataTable
    '    With Me.dtgrSV
    '        .Columns(0).HeaderText = "Mã sinh viên"
    '        .Columns(1).HeaderText = "Tên sinh viên"
    '        .Columns(1).Width = 150
    '        .Columns(2).HeaderText = "Giới Tính"
    '        .Columns(3).HeaderText = "Ngày Sinh"
    '        .Columns(4).HeaderText = "Lớp"
    '        .Columns(5).HeaderText = "Ngày Làm Thẻ"
    '        .Columns(6).HeaderText = "Ngày Hết Hạn"
    '    End With
    'End Sub

    Private Sub LoadDataPMOnGridView()
        Dim sqlQuery As String = "SELECT * FROM dbo.tbl_PHIEUMUON"
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dtgrPM.DataSource = dtTable
        With Me.dtgrPM
            .Columns(0).HeaderText = "Mã phiếu"
            .Columns(1).HeaderText = "Mã sinh viên"
            .Columns(2).HeaderText = "Ngày mượn"
            .Columns(3).HeaderText = "Mã nhân viên"
        End With
    End Sub

    Private Sub LoadDataCTPMOnGridView()
        Dim sqlQuery As String = "SELECT * FROM dbo.tbl_CTPHIEUMUON"
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dtgrCTPM.DataSource = dtTable
        With Me.dtgrCTPM
            .Columns(0).HeaderText = "Mã phiếu"
            .Columns(1).HeaderText = "Mã sách"
            .Columns(2).HeaderText = "Hạn trả"
            .Columns(3).HeaderText = "Tiền cọc"
        End With
    End Sub

    Private Sub SearchBookOnTbl_MS()
        Dim sqlQuery As String
        If cmbfilterMS.SelectedIndex = 0 Then
            If txtSearchMS.Text <> "" Then
                sqlQuery = String.Format("SELECT * FROM dbo.tbl_SACH WHERE maSach = '{0}'", Val(txtSearchMS.Text))
            Else
                sqlQuery = "SELECT [maSach],[tenSach],[soTrang],[gia],[soLuong],[ngayNhap],[maNXB],[maTL],[maTG],[maNN],[tinhTrang] = (CASE [tinhTrang] WHEN 'True' THEN N'Còn' WHEN 'False' THEN N'Hết' end) FROM dbo.tbl_SACH"
            End If
        ElseIf cmbfilterMS.SelectedIndex = 1 Then
            sqlQuery = String.Format("SELECT * FROM dbo.tbl_SACH WHERE tenSach LIKE  N'%{0}%'", txtSearchMS.Text)
        Else
            sqlQuery = String.Format("SELECT * FROM dbo.tbl_SACH WHERE tenSach LIKE  N'%{0}%'", txtSearchMS.Text)
        End If
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dtgrMuonSach.DataSource = dtTable
        With Me.dtgrMuonSach
            .Columns(0).HeaderText = "Mã Sách"
            .Columns(1).HeaderText = "Tên Sách"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "Số Trang"
            .Columns(3).HeaderText = "Giá"
            .Columns(4).HeaderText = "Số Lượng"
            .Columns(5).HeaderText = "Ngày Nhập"
            .Columns(6).HeaderText = "Mã NXB"
            .Columns(7).HeaderText = "Mã TL"
            .Columns(8).HeaderText = "Mã TG"
            .Columns(9).HeaderText = "Mã NN"
            .Columns(10).HeaderText = "Tình Trạng"
        End With
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub submenu11_Click(sender As Object, e As EventArgs) Handles submenu11.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub submenu21_Click(sender As Object, e As EventArgs) Handles submenu21.Click
        If TabControl1.SelectedIndex <> 1 Then
            TabControl1.SelectTab(1)
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cmbfilterMS.SelectedIndex = -1 Then
            cmbfilterMS.SelectedItem = "Mã Sách"
        End If

        LoadDataNVOnGridview()
        LoadDataTLOnGridview()
        LoadDataTGOnGridview()
        LoadDataNNOnGridview()
        LoadDataNVOnGridview()
        LoadDataNXBOnGridview()
        LoadDataSVOnGridview()
        LoadDataSachOnGridview()
        LoadDataPMOnGridView()
        LoadDataCTPMOnGridView()


    End Sub

    Private Sub cmbfilter1_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub


    'Private Sub txtadd_Click(sender As Object, e As EventArgs) Handles txtadd.Click
    '    Dim frm1 As New frmSach
    '    frm1.ShowDialog()
    'End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl1.DrawItem

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub submenu22_Click(sender As Object, e As EventArgs) Handles submenu22.Click
        If TabControl1.SelectedIndex <> 2 Then
            TabControl1.SelectTab(2)

        End If
    End Sub

    Private Sub submenu23_Click(sender As Object, e As EventArgs) Handles submenu23.Click
        If TabControl1.SelectedIndex <> 3 Then
            TabControl1.SelectTab(3)

        End If
    End Sub

    Private Sub submenu24_Click(sender As Object, e As EventArgs) Handles submenu24.Click
        If TabControl1.SelectedIndex <> 4 Then
            TabControl1.SelectTab(4)

        End If
    End Sub

    Private Sub submenu25_Click(sender As Object, e As EventArgs) Handles submenu25.Click
        If TabControl1.SelectedIndex <> 5 Then
            TabControl1.SelectTab(5)

        End If
    End Sub

    Private Sub submenu31_Click(sender As Object, e As EventArgs) Handles submenu31.Click
        If TabControl1.SelectedIndex <> 6 Then
            TabControl1.SelectTab(6)

        End If
    End Sub

    Private Sub submenu32_Click(sender As Object, e As EventArgs) Handles submenu32.Click
        If TabControl1.SelectedIndex <> 7 Then
            TabControl1.SelectTab(7)

        End If
    End Sub


    Private Sub txtSearchTL_TextChanged(sender As Object, e As EventArgs) Handles txtSearchTL.TextChanged
        
    End Sub

    Private Sub txtSearchTG_TextChanged(sender As Object, e As EventArgs) Handles txtSearchTG.TextChanged
        
    End Sub

    Private Sub txtSearchNN_TextChanged(sender As Object, e As EventArgs) Handles txtSearchNN.TextChanged
        
    End Sub

    Private Sub txtSearchNXB_TextChanged(sender As Object, e As EventArgs) Handles txtSearchNXB.TextChanged
        
    End Sub

    Private Sub txtSearchNV_TextChanged(sender As Object, e As EventArgs) Handles txtSearchNV.TextChanged
        
    End Sub

    Private Sub txtSearchSV_TextChanged(sender As Object, e As EventArgs) Handles txtSearchSV.TextChanged
        
    End Sub

    Private Sub submenu41_Click(sender As Object, e As EventArgs) Handles submenu41.Click
        If TabControl1.SelectedIndex <> 8 Then
            TabControl1.SelectTab(8)

        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        
    End Sub

    Private Sub txtSearchMS_TextChanged(sender As Object, e As EventArgs) Handles txtSearchMS.TextChanged

    End Sub

    Private Sub cmbfilterMS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfilterMS.SelectedIndexChanged
        SearchBookOnTbl_MS()
    End Sub

    Private Sub dtgrMuonSach_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgrMuonSach.CellContentClick
        txtmsMS.Text = dtgrMuonSach.CurrentRow.Cells(0).Clone
    End Sub

    Private Sub btnAddTL_Click(sender As Object, e As EventArgs) Handles btnAddTL.Click
        Dim frm As New frmTheLoai(False)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.Yes Then
            LoadDataTLOnGridview()
        End If
    End Sub

    Private Sub btnEditTL_Click(sender As Object, e As EventArgs) Handles btnEditTL.Click
        Dim frm As New frmTheLoai(True)
        With Me.dtgrTheLoai
            frm.txtmtl.Text = .Rows(.CurrentCell.RowIndex).Cells("MaTl").Value
            frm.txttentl.Text = .Rows(.CurrentCell.RowIndex).Cells("TenTL").Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.Yes Then
            LoadDataTLOnGridview()
        End If
    End Sub

    Private Sub btnDeleteTL_Click(sender As Object, e As EventArgs) Handles btnDeleteTL.Click
        'Khai bao biens lay maTL trong dtgrv
        Dim maTl As Integer = Val(Me.dtgrTheLoai.Rows(Me.dtgrTheLoai.CurrentCell.RowIndex).Cells("MaTL").Value)
        'Xóa
        Dim sqlQuery As String = String.Format("DELETE tbl_THELOAI WHERE maTL  = '{0}'", maTL)

        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Delete thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDataTLOnGridview()
        Else
            MessageBox.Show("Delete không thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub submenu13_Click(sender As Object, e As EventArgs) Handles submenu13.Click
        End
    End Sub

    Private Sub submenu12_Click(sender As Object, e As EventArgs) Handles submenu12.Click
        'Dim frm = New frmMain
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddTG_Click(sender As Object, e As EventArgs) Handles btnAddTG.Click
        Dim frm = New frmTacGia(False)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.Yes Then
            LoadDataTGOnGridview()
        End If
    End Sub

    Private Sub btnEditTG_Click(sender As Object, e As EventArgs) Handles btnEditTG.Click
        Dim frm = New frmTacGia(True)
        With Me.dtgrTG
            frm.txtmtg.Text = .Rows(.CurrentCell.RowIndex).Cells("MaTg").Value
            frm.txttentg.Text = .Rows(.CurrentCell.RowIndex).Cells("hoTenTg").Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.Yes Then
            LoadDataTGOnGridview()
        End If
    End Sub

    Private Sub btnDeleteTG_Click(sender As Object, e As EventArgs) Handles btnDeleteTG.Click
        'Khai bao biens lay maTL trong dtgrv
        Dim maTG As Integer = Val(Me.dtgrTG.Rows(Me.dtgrTG.CurrentCell.RowIndex).Cells("MaTG").Value)
        'Xóa
        Dim sqlQuery As String = String.Format("DELETE tbl_TACGIA WHERE maTG  = '{0}'", maTG)

        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Delete thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDataTGOnGridview()
        Else
            MessageBox.Show("Delete không thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub btnAddNN_Click(sender As Object, e As EventArgs) Handles btnAddNN.Click
        Dim frm = New frmNgonNgu(False)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.Yes Then
            LoadDataNNOnGridview()
        End If
    End Sub

    Private Sub btnEditNN_Click(sender As Object, e As EventArgs) Handles btnEditNN.Click
        Dim frm = New frmNgonNgu(True)
        With Me.dtgrNN
            frm.txtmnn.Text = .Rows(.CurrentCell.RowIndex).Cells("MaNN").Value
            frm.txttennn.Text = .Rows(.CurrentCell.RowIndex).Cells("TenNN").Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.Yes Then
            LoadDataNNOnGridview()
        End If
    End Sub

    Private Sub btnDeleteNN_Click(sender As Object, e As EventArgs) Handles btnDeleteNN.Click
        'Khai bao biens lay maTL trong dtgrv
        Dim maNN As Integer = Val(Me.dtgrNN.Rows(Me.dtgrNN.CurrentCell.RowIndex).Cells("MaNN").Value)
        'Xóa
        Dim sqlQuery As String = String.Format("DELETE tbl_NgonNgu WHERE maNN  = '{0}'", maNN)

        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Delete thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDataNNOnGridview()
        Else
            MessageBox.Show("Delete không thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnAddNXB_Click(sender As Object, e As EventArgs) Handles btnAddNXB.Click
        Dim frm = New frmNXB(False)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.Yes Then
            LoadDataNXBOnGridview()
        End If
    End Sub

    Private Sub btnEditNXB_Click(sender As Object, e As EventArgs) Handles btnEditNXB.Click
        Dim frm = New frmNXB(True)
        With Me.dtgrNXB
            frm.txtmanxb.Text = .Rows(.CurrentCell.RowIndex).Cells("MaNXB").Value
            frm.txttennxb.Text = .Rows(.CurrentCell.RowIndex).Cells("TenNXB").Value
            If .Rows(.CurrentCell.RowIndex).Cells("diaChiNXB").Value.ToString <> "" Then
                frm.txtdiachinxb.Text = .Rows(.CurrentCell.RowIndex).Cells("diaChiNXB").Value
            End If
            If .Rows(.CurrentCell.RowIndex).Cells("dienThoaiNXB").Value.ToString <> "" Then
                frm.txtsdtnxb.Text = .Rows(.CurrentCell.RowIndex).Cells("dienThoaiNXB").Value
            End If
            If .Rows(.CurrentCell.RowIndex).Cells("websiteNXB").Value.ToString <> "" Then
                frm.txtwebsitenxb.Text = .Rows(.CurrentCell.RowIndex).Cells("websiteNXB").Value
            End If
        End With
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.Yes Then
            LoadDataNXBOnGridview()
        End If
    End Sub

    Private Sub btnDeleteNXB_Click(sender As Object, e As EventArgs) Handles btnDeleteNXB.Click
        'Khai bao biens lay maTL trong dtgrv
        Dim maNXB As Integer = Val(Me.dtgrNXB.Rows(Me.dtgrNXB.CurrentCell.RowIndex).Cells("MaNXB").Value)
        'Xóa
        Dim sqlQuery As String = String.Format("DELETE tbl_NHAXUATBAN WHERE maNXB  = '{0}'", maNXB)

        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Delete thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDataNXBOnGridview()
        Else
            MessageBox.Show("Delete không thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtadd_Click(sender As Object, e As EventArgs) Handles btnAddSach.Click
        Dim frm = New frmSach(False)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.Yes Then
            LoadDataSachOnGridview()
        End If
    End Sub



    Private Sub txtDelete_Click(sender As Object, e As EventArgs) Handles btnDeleteSach.Click
        'Khai bao biens lay maTL trong dtgrv
        Dim maSach As Integer = Val(Me.dtgvSach.Rows(Me.dtgvSach.CurrentCell.RowIndex).Cells("maSach").Value)
        'Xóa
        Dim sqlQuery As String = String.Format("DELETE tbl_SACH WHERE maSach  = '{0}'", maSach)

        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Delete thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDataSachOnGridview()
        Else
            MessageBox.Show("Delete không thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtEdit_Click(sender As Object, e As EventArgs) Handles btnEditSach.Click
        Dim frm = New frmSach(True, dtgvSach.CurrentRow)
        ''run thu xem
        'ai lai de control public het the nay, tao 1 constructor ben frmSach roi truyen cai row vao
        'With Me.dtgvSach
        '    frm.txtMaSach.Text = .CurrentRow.Cells("maSach").Value
        '    frm.txtTenSach.Text = .CurrentRow.Cells("TenSach").Value
        '    frm.txtSoTrang.Text = .CurrentRow.Cells("soTrang").Value
        '    frm.txtGia.Text = .CurrentRow.Cells("gia").Value
        '    frm.txtSoLuong.Text = .CurrentRow.Cells("soLuong").Value
        '    frm.dtpkngaynhap.Value = .CurrentRow.Cells("ngayNhap").Value

        '    frm.cmbmanxb.SelectedValue = .CurrentRow.Cells("maNXB").Value
        '    frm.cmbmatl.SelectedValue = .Rows(.CurrentCell.RowIndex).Cells("maTL").Value
        '    frm.cmbmatg.SelectedValue = .Rows(.CurrentCell.RowIndex).Cells("maTG").Value
        '    frm.cmbmann.SelectedValue = .CurrentRow.Cells("maNN").Value

        'End With
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.Yes Then
            LoadDataSachOnGridview()
        End If
    End Sub

    Private Sub TabPage10_Click(sender As Object, e As EventArgs) Handles TabPage10.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnSearchSach_Click(sender As Object, e As EventArgs) Handles btnSearchSach.Click
        Dim sqlQuery As String = String.Format("SELECT * FROM dbo.tbl_SACH where TenSach like N'%{0}%'", txtSearch.Text)
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dtgvSach.DataSource = dtTable
        With Me.dtgvSach
            .Columns(0).HeaderText = "Mã Sách"
            .Columns(1).HeaderText = "Tên Sách"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "Số Trang"
            .Columns(3).HeaderText = "Giá"
            .Columns(4).HeaderText = "Số Lượng"
            .Columns(5).HeaderText = "Ngày Nhập"
            .Columns(6).HeaderText = "Mã NXB"
            .Columns(7).HeaderText = "Mã TL"
            .Columns(8).HeaderText = "Mã TG"
            .Columns(9).HeaderText = "Mã NN"
            .Columns(10).HeaderText = "Tình Trạng"
        End With
    End Sub

    Private Sub btnSearchTl_Click(sender As Object, e As EventArgs) Handles btnSearchTl.Click
        Dim sqlQuery As String = String.Format("SELECT * FROM dbo.tbl_THELOAI Where tenTL LIKE N'%{0}%'", txtSearchTL.Text)
        Dim dataTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dtgrTheLoai.DataSource = dataTable
        With Me.dtgrTheLoai
            .Columns(0).HeaderText = "Mã Thể Loại"
            .Columns(0).Width = 200
            .Columns(1).Width = 200
            .Columns(1).HeaderText = "Tên Thể Loại"
        End With
    End Sub

    Private Sub btnSearchTG_Click(sender As Object, e As EventArgs) Handles btnSearchTG.Click
        Dim sqlQuery As String = String.Format("SELECT * FROM dbo.tbl_TACGIA WHERE hoTenTG LIKE N'%{0}%'", txtSearchTG.Text)
        Dim dataTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dtgrTG.DataSource = dataTable
        With Me.dtgrTG
            .Columns(0).HeaderText = "Mã Tác Giả"
            .Columns(0).Width = 200
            .Columns(1).Width = 200
            .Columns(1).HeaderText = "Tên Tác Giả"
        End With
    End Sub

    Private Sub btnSearchNN_Click(sender As Object, e As EventArgs) Handles btnSearchNN.Click
        Dim sqlQuery As String = String.Format("SELECT * FROM dbo.tbl_NgonNgu WHERE tennn like N'%{0}%'", txtSearchNN.Text)
        Dim dataTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dtgrNN.DataSource = dataTable
        With Me.dtgrNN
            .Columns(0).HeaderText = "Mã Ngôn Ngữ"
            .Columns(0).Width = 200
            .Columns(1).Width = 200
            .Columns(1).HeaderText = "Tên Ngôn Ngữ"
        End With
    End Sub

    Private Sub btnSearchNXB_Click(sender As Object, e As EventArgs) Handles btnSearchNXB.Click
        Dim sqlQuery As String = String.Format("SELECT * FROM dbo.tbl_NHAXUATBAN where tennxb like N'%{0}%'", txtSearchNXB.Text)
        Dim dataTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dtgrNXB.DataSource = dataTable
        With Me.dtgrNXB
            .Columns(0).HeaderText = "Mã NXB"
            .Columns(0).Width = 200
            .Columns(1).Width = 200
            .Columns(1).HeaderText = "Tên NXB"
        End With
    End Sub

    Private Sub btnSearchNV_Click(sender As Object, e As EventArgs) Handles btnSearchNV.Click
        Dim sqlQuery As String = String.Format("SELECT * FROM dbo.tbl_NHANVIEN where tennv like N'%{0}%'", txtSearchNV.Text)
        Dim dataTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dtgrNV.DataSource = dataTable
        With Me.dtgrNV
            .Columns(0).HeaderText = "Mã NV"
            .Columns(1).HeaderText = "Tên NV"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "gioiTinhNV"
            .Columns(3).HeaderText = "ngaySinhNV"
            .Columns(4).HeaderText = "dienThoaiNV"
            .Columns(5).HeaderText = "diaChiNV"
            .Columns(6).HeaderText = "emailNV"
            .Columns(7).HeaderText = "ngayVaoLam"
            .Columns(8).HeaderText = "matKhau"
        End With
    End Sub

    Private Sub btnSearchSV_Click(sender As Object, e As EventArgs) Handles btnSearchSV.Click
        Dim sqlQuery As String = String.Format("SELECT * FROM dbo.tbl_SINHVIEN WHERE hoTenSV like N'%{0}%'", txtSearchSV.Text)
        Dim dataTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dtgrSV.DataSource = dataTable
        With Me.dtgrSV
            .Columns(0).HeaderText = "Mã sinh viên"
            .Columns(1).HeaderText = "Tên sinh viên"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "Giới Tính"
            .Columns(3).HeaderText = "Ngày Sinh"
            .Columns(4).HeaderText = "Lớp"
            .Columns(5).HeaderText = "Ngày Làm Thẻ"
            .Columns(6).HeaderText = "Ngày Hết Hạn"
        End With
    End Sub

    Private Sub btnSearchMS_Click(sender As Object, e As EventArgs) Handles btnSearchMS.Click
        SearchBookOnTbl_MS()
    End Sub
End Class
