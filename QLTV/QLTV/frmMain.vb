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

    Private Sub LoadDataSachOnGridviewMuon()
        Dim sqlQuery As String = "SELECT [maSach],[tenSach],[soTrang],[gia],[soLuong],[ngayNhap],[maNXB],[maTL],[maTG],[maNN],[tinhTrang] = (CASE [tinhTrang] WHEN 'True' THEN N'Còn' WHEN 'False' THEN N'Hết' end) FROM dbo.tbl_SACH"
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

    Private Sub LoadMSVOnCbbBox()
        Dim sqlQuery As String = "SELECT masv from tbl_SINHVIEN"
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbmsvMS.DataSource = dtTable
        With Me.cmbmsvMS
            Me.cmbmsvMS.DisplayMember = "maSV"
            Me.cmbmsvMS.ValueMember = "maSV"
        End With
        cmbmsvMS.SelectedIndex = -1
    End Sub


    Private Sub LoadMNVOnCmbBoxMS()
        Dim sqlQuery As String = "SELECT maNV FROM dbo.tbl_NHANVIEN"
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbmnvMS.DataSource = dtTable
        With Me.cmbmnvMS
            Me.cmbmnvMS.DisplayMember = "maNV"
            Me.cmbmnvMS.ValueMember = "maNV"
        End With
        cmbmnvMS.SelectedIndex = -1
    End Sub

    Private Sub LoadMSOnCbbBox()
        Dim sqlQuery As String = "SELECT maSach FROM dbo.tbl_SACH"
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbmsMS.DataSource = dtTable
        With Me.cmbmsMS
            Me.cmbmsMS.DisplayMember = "maSach"
            Me.cmbmsMS.ValueMember = "maSach"
        End With
        cmbmsMS.SelectedIndex = -1
    End Sub

    Private Sub LoadMSOnCbbBox1()
        Dim sqlQuery As String = "SELECT maSach FROM dbo.tbl_SACH"
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbmsMS1.DataSource = dtTable
        With Me.cmbmsMS1
            Me.cmbmsMS1.DisplayMember = "maSach"
            Me.cmbmsMS1.ValueMember = "maSach"
        End With
        cmbmsMS1.SelectedIndex = -1
    End Sub

    Private Sub LoadMSOnCbbBox2()
        Dim sqlQuery As String = "SELECT maSach FROM dbo.tbl_SACH"
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbmsMS2.DataSource = dtTable
        With Me.cmbmsMS2
            Me.cmbmsMS2.DisplayMember = "maSach"
            Me.cmbmsMS2.ValueMember = "maSach"
        End With
        cmbmsMS2.SelectedIndex = -1
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


    Private Sub SearchNXBOnGridView()
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


    Private Sub LoadDataMuonOnGridview()
        Dim sqlQuery As String = "SELECT * FROM dbo.tbl_SINHVIEN"
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


    Private Sub LoadDataQLTraOnGridView()
        Dim sqlQuery As String = "SELECT * FROM dbo.tbl_TRASACH"
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dtgrQLTra.DataSource = dtTable
        With Me.dtgrQLTra
            .Columns(0).HeaderText = "Số thứ tự"
            .Columns(1).HeaderText = "Mã phiếu"
            .Columns(2).HeaderText = "Mã sách"
            .Columns(3).HeaderText = "Mã nhân viên"
            .Columns(4).HeaderText = "Ngày trả"
            .Columns(5).HeaderText = "Phạt hư hỏng"
            .Columns(6).HeaderText = "Phạt quá hạn"
            .Columns(7).HeaderText = "Thanh toán"
        End With
    End Sub

    Private Sub SearchDataQLTraOnGridView()
        Dim sqlQuery
        If cmbfilterQLTra.SelectedIndex = 0 Then
            sqlQuery = String.Format("SELECT * FROM dbo.tbl_TRASACH WHERE STT LIKE '%{0}%'", txtSearchQLTra.Text)
        ElseIf cmbfilterQLTra.SelectedIndex = 1 Then
            sqlQuery = String.Format("SELECT * FROM dbo.tbl_TRASACH WHERE maPhieu LIKE '%{0}%'", txtSearchQLTra.Text)
        ElseIf cmbfilterQLTra.SelectedIndex = 2 Then
            sqlQuery = String.Format("SELECT * FROM dbo.tbl_TRASACH WHERE maSach LIKE '%{0}%'", txtSearchQLTra.Text)
        Else
            sqlQuery = String.Format("SELECT * FROM dbo.tbl_TRASACH WHERE maNV LIKE '%{0}%'", txtSearchQLTra.Text)
        End If
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dtgrQLTra.DataSource = dtTable
        With Me.dtgrQLTra
            .Columns(0).HeaderText = "Số thứ tự"
            .Columns(1).HeaderText = "Mã phiếu"
            .Columns(2).HeaderText = "Mã sách"
            .Columns(3).HeaderText = "Mã nhân viên"
            .Columns(4).HeaderText = "Ngày trả"
            .Columns(5).HeaderText = "Phạt hư hỏng"
            .Columns(6).HeaderText = "Phạt quá hạn"
            .Columns(7).HeaderText = "Thanh toán"
        End With
    End Sub

    Private Sub SearchBookOnTbl_MS()
        Dim sqlQuery As String
        If cmbfilterMS.SelectedIndex = 0 Then
            sqlQuery = String.Format("SELECT [maSach],[tenSach],[soTrang],[gia],[soLuong],[ngayNhap],[maNXB],[maTL],[maTG],[maNN],[tinhTrang] = (CASE [tinhTrang] WHEN 'True' THEN N'Còn' WHEN 'False' THEN N'Hết' end) FROM dbo.tbl_SACH WHERE maSach = '{0}'", txtSearchMS.Text)
        ElseIf cmbfilterMS.SelectedIndex = 1 Then
            sqlQuery = String.Format("SELECT [maSach],[tenSach],[soTrang],[gia],[soLuong],[ngayNhap],[maNXB],[maTL],[maTG],[maNN],[tinhTrang] = (CASE [tinhTrang] WHEN 'True' THEN N'Còn' WHEN 'False' THEN N'Hết' end) FROM dbo.tbl_SACH WHERE tenSach LIKE  N'%{0}%'", txtSearchMS.Text)
        Else
            sqlQuery = String.Format("SELECT [maSach],[tenSach],[soTrang],[gia],[soLuong],[ngayNhap],[maNXB],[maTL],[maTG],[maNN],[tinhTrang] = (CASE [tinhTrang] WHEN 'True' THEN N'Còn' WHEN 'False' THEN N'Hết' end) FROM dbo.tbl_SACH WHERE tenSach LIKE  N'%{0}%'", txtSearchMS.Text)
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


    Private Sub SearchSVOnGridView()
        Dim sqlQuery As String = String.Format("SELECT [maSV],[hoTenSV],[gioiTinhSV] = (CASE gioiTinhSV WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END),[ngaySinhSV],[lopSV],[ngayLamThe],[ngayHetHan] FROM dbo.tbl_SINHVIEN WHERE hoTenSV like N'%{0}%'", txtSearchSV.Text)
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
    Private Sub SearchNVOnGridView()
        Dim sqlQuery As String = String.Format("SELECT maNV,tenNV,gioiTinhNV = (CASE gioiTinhNV WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END),ngaySinhNV,dienThoaiNV,diaChiNV,emailNV,ngayVaoLam,matKhau FROM dbo.tbl_NHANVIEN where tennv like N'%{0}%'", txtSearchNV.Text)
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

    Private Sub SearchNNOnGridView()
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

    Private Sub SearchTGOnGridView()
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

    Private Sub SearchTLOnGridView()
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

    Private Sub SearchSachOnGridView()
        Dim sqlQuery As String = String.Format("SELECT [maSach],[tenSach],[soTrang],[gia],[soLuong],[ngayNhap],[maNXB],[maTL],[maTG],[maNN],[tinhTrang] = (CASE [tinhTrang] WHEN 'True' THEN N'Còn' WHEN 'False' THEN N'Hết' end) FROM dbo.tbl_SACH where TenSach like N'%{0}%'", txtSearch.Text)
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

    Private Sub SearchInfoOnQLMuon()
        Dim sqlQuery, sqlQuery1 As String
        If cmbQLMuon.SelectedIndex = 0 Then
            sqlQuery = String.Format("SELECT * FROM dbo.tbl_PHIEUMUON WHERE maPhieu LIKE '%{0}%'", txtSearchQLM.Text)
            sqlQuery1 = String.Format("SELECT * FROM dbo.tbl_CTPHIEUMUON WHERE maPhieu LIKE '%{0}%'", txtSearchQLM.Text)
            Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
            Me.dtgrPM.DataSource = dtTable
            With Me.dtgrPM
                .Columns(0).HeaderText = "Mã phiếu"
                .Columns(1).HeaderText = "Mã sinh viên"
                .Columns(2).HeaderText = "Ngày mượn"
                .Columns(3).HeaderText = "Mã nhân viên"
            End With

            Dim dtTable1 As DataTable = _DBAccess.GetDataTable(sqlQuery1)
            Me.dtgrCTPM.DataSource = dtTable1
            With Me.dtgrCTPM
                .Columns(0).HeaderText = "Mã phiếu"
                .Columns(1).HeaderText = "Mã sách"
                .Columns(2).HeaderText = "Hạn trả"
                .Columns(3).HeaderText = "Tiền cọc"
            End With
        ElseIf cmbQLMuon.SelectedIndex = 1 Then
            sqlQuery = String.Format("SELECT * FROM dbo.tbl_PHIEUMUON WHERE maSV LIKE '%{0}%'", txtSearchQLM.Text)
            Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
            Me.dtgrPM.DataSource = dtTable
            With Me.dtgrPM
                .Columns(0).HeaderText = "Mã phiếu"
                .Columns(1).HeaderText = "Mã sinh viên"
                .Columns(2).HeaderText = "Ngày mượn"
                .Columns(3).HeaderText = "Mã nhân viên"
            End With
        Else
            sqlQuery1 = String.Format("SELECT * FROM dbo.tbl_CTPHIEUMUON WHERE maSach LIKE '%{0}%'", txtSearchQLM.Text)
            Dim dtTable1 As DataTable = _DBAccess.GetDataTable(sqlQuery1)
            Me.dtgrCTPM.DataSource = dtTable1
            With Me.dtgrCTPM
                .Columns(0).HeaderText = "Mã phiếu"
                .Columns(1).HeaderText = "Mã sách"
                .Columns(2).HeaderText = "Hạn trả"
                .Columns(3).HeaderText = "Tiền cọc"
            End With
        End If
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs)

    End Sub

    'Insert Sach on tbl_PhieuMuon and tbl_CTPhieuMuon(Thêm mượn sách)
    Private Function OnLoanBookOfLibrary_PhieuMuon() As Boolean
        Dim sqlQuery As String = "INSERT dbo.tbl_PHIEUMUON ( maSV, ngayMuon, maNV )"
        sqlQuery += String.Format("VALUES ('{0}','{1}','{2}')", cmbmsvMS.SelectedValue, dtpkngaymuonMS.Value, cmbmnvMS.SelectedValue)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Function OnLoanBookOfLibrary_CTPhieuMuon() As Boolean
            LoadDataPMOnGridView()
            Dim sqlQuery As String = "INSERT dbo.tbl_CTPHIEUMUON ( maPhieu, maSach, hanTra, tienCoc )"
                sqlQuery += String.Format("VALUES ('{0}','{1}','{2}','{3}')", Me.dtgrPM.Rows(Me.dtgrPM.RowCount - 1).Cells("maPhieu").Value, cmbmsMS.Text, dtpkhtMS.Value, txttcMS.Text)
            Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Function OnLoanBookOfLibrary_CTPhieuMuon1() As Boolean
        LoadDataPMOnGridView()
        Dim sqlQuery As String = "INSERT dbo.tbl_CTPHIEUMUON ( maPhieu, maSach, hanTra, tienCoc )"
        sqlQuery += String.Format("VALUES ('{0}','{1}','{2}','{3}')", Me.dtgrPM.Rows(Me.dtgrPM.RowCount - 1).Cells("maPhieu").Value, cmbmsMS1.Text, dtpkhtMS1.Value, txttcMS1.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Function OnLoanBookOfLibrary_CTPhieuMuon2() As Boolean
        LoadDataPMOnGridView()
        Dim sqlQuery As String = "INSERT dbo.tbl_CTPHIEUMUON ( maPhieu, maSach, hanTra, tienCoc )"
        sqlQuery += String.Format("VALUES ('{0}','{1}','{2}','{3}')", Me.dtgrPM.Rows(Me.dtgrPM.RowCount - 1).Cells("maPhieu").Value, cmbmsMS2.Text, dtpkhtMS2.Value, txttcMS2.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cmbfilterMS.SelectedIndex = -1 Then
            cmbfilterMS.SelectedItem = "Mã Sách"
        End If
        If cmbfilterQLTra.SelectedIndex = -1 Then
            cmbfilterQLTra.SelectedItem = "Số thứ tự"
        End If
        If cmbQLMuon.SelectedIndex = -1 Then
            cmbQLMuon.SelectedItem = "Mã phiếu"
        End If

        dtpkngaymuonMS.Value = Date.Today()

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
        LoadDataSachOnGridviewMuon()
        LoadDataQLTraOnGridView()

        LoadMSVOnCbbBox()
        LoadMNVOnCmbBoxMS()
        LoadMSOnCbbBox()

    End Sub

    
    Private Sub txtSearchTL_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchTL.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchTLOnGridView()
        End If
    End Sub


    Private Sub txtSearchTL_TextChanged(sender As Object, e As EventArgs) Handles txtSearchTL.TextChanged

    End Sub

    Private Sub txtSearchTG_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchTG.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchTGOnGridView()
        End If
    End Sub

    Private Sub txtSearchTG_TextChanged(sender As Object, e As EventArgs) Handles txtSearchTG.TextChanged

    End Sub

    Private Sub txtSearchNN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchNN.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchNN.Focus()
            SearchNNOnGridView()
        End If
    End Sub

    Private Sub txtSearchNN_TextChanged(sender As Object, e As EventArgs) Handles txtSearchNN.TextChanged

    End Sub

    Private Sub txtSearchNXB_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchNXB.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchNXB.Focus()
            SearchNXBOnGridView()
        End If
    End Sub

    Private Sub txtSearchNXB_TextChanged(sender As Object, e As EventArgs) Handles txtSearchNXB.TextChanged

    End Sub

    Private Sub txtSearchNV_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchNV.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchNV.Focus()
            SearchNVOnGridView()
        End If
    End Sub

    Private Sub txtSearchNV_TextChanged(sender As Object, e As EventArgs) Handles txtSearchNV.TextChanged

    End Sub

    Private Sub txtSearchSV_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchSV.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchSV.Focus()
            SearchSVOnGridView()
        End If
    End Sub

    Private Sub txtSearchSV_TextChanged(sender As Object, e As EventArgs) Handles txtSearchSV.TextChanged

    End Sub

    Private Sub submenu41_Click(sender As Object, e As EventArgs) Handles submenu41.Click
        If TabControl1.SelectedIndex <> 8 Then
            TabControl1.SelectTab(8)

        End If
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchSachOnGridView()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub txtSearchMS_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchMS.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchMS.Focus()
            SearchBookOnTbl_MS()
        End If
    End Sub

    Private Sub txtSearchMS_TextChanged(sender As Object, e As EventArgs) Handles txtSearchMS.TextChanged

    End Sub

    Private Sub cmbfilterMS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfilterMS.SelectedIndexChanged
        SearchBookOnTbl_MS()
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
        Dim sqlQuery As String = String.Format("DELETE tbl_THELOAI WHERE maTL  = '{0}'", maTl)
        If MessageBox.Show("Bạn muốn xóa bản ghi này ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
                MessageBox.Show("Delete thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadDataTLOnGridview()
            Else
                MessageBox.Show("Delete không thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
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
        If MessageBox.Show("Bạn muốn xóa bản ghi này ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
                MessageBox.Show("Delete thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadDataTGOnGridview()
            Else
                MessageBox.Show("Delete không thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
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
        If MessageBox.Show("Bạn muốn xóa bản ghi này ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
                MessageBox.Show("Delete thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadDataNNOnGridview()
            Else
                MessageBox.Show("Delete không thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
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
        If MessageBox.Show("Bạn muốn xóa bản ghi này ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
                MessageBox.Show("Delete thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadDataNXBOnGridview()
            Else
                MessageBox.Show("Delete không thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
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
        If MessageBox.Show("Bạn muốn xóa bản ghi này ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
                MessageBox.Show("Delete thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadDataSachOnGridview()
            Else
                MessageBox.Show("Delete không thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub txtEdit_Click(sender As Object, e As EventArgs) Handles btnEditSach.Click
        Dim frm = New frmSach(True, dtgvSach.CurrentRow)
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
        SearchSachOnGridView()
    End Sub

    Private Sub btnSearchTl_Click(sender As Object, e As EventArgs) Handles btnSearchTl.Click
        SearchTLOnGridView()
    End Sub

    Private Sub btnSearchTG_Click(sender As Object, e As EventArgs) Handles btnSearchTG.Click
        SearchTGOnGridView()
    End Sub

    Private Sub btnSearchNN_Click(sender As Object, e As EventArgs) Handles btnSearchNN.Click
        SearchNNOnGridView()
    End Sub

    Private Sub btnSearchNXB_Click(sender As Object, e As EventArgs) Handles btnSearchNXB.Click
        SearchNXBOnGridView()
    End Sub

    Private Sub btnSearchNV_Click(sender As Object, e As EventArgs) Handles btnSearchNV.Click
        SearchNVOnGridView()
    End Sub

    Private Sub btnSearchSV_Click(sender As Object, e As EventArgs) Handles btnSearchSV.Click
        SearchSVOnGridView()
    End Sub

    Private Sub btnSearchMS_Click(sender As Object, e As EventArgs) Handles btnSearchMS.Click
        SearchBookOnTbl_MS()
    End Sub

    Private Sub btnSearchQLM_Click(sender As Object, e As EventArgs) Handles btnSearchQLM.Click
        SearchInfoOnQLMuon()
    End Sub


    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnRefreshSach_Click(sender As Object, e As EventArgs) Handles btnRefreshSach.Click
        LoadDataSachOnGridview()
    End Sub

    Private Sub btnRefreshTL_Click(sender As Object, e As EventArgs) Handles btnRefreshTL.Click
        LoadDataTLOnGridview()
    End Sub

    Private Sub btnRefreshTG_Click(sender As Object, e As EventArgs) Handles btnRefreshTG.Click
        LoadDataTGOnGridview()
    End Sub

    Private Sub btnRefreshNN_Click(sender As Object, e As EventArgs) Handles btnRefreshNN.Click
        LoadDataNNOnGridview()
    End Sub

    Private Sub btnRefreshNXB_Click(sender As Object, e As EventArgs) Handles btnRefreshNXB.Click
        LoadDataNXBOnGridview()
    End Sub

    Private Sub btnRefreshNV_Click(sender As Object, e As EventArgs) Handles btnRefreshNV.Click
        LoadDataNVOnGridview()
    End Sub

    Private Sub btnRefreshSV_Click(sender As Object, e As EventArgs) Handles btnRefreshSV.Click
        LoadDataSVOnGridview()
    End Sub

    Private Sub btnreFreshMS_Click(sender As Object, e As EventArgs) Handles btnreFreshMS.Click
        LoadDataSachOnGridviewMuon()
    End Sub

    Private Sub txtSearchQLM_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchQLM.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchQLM.Focus()
            SearchInfoOnQLMuon()
        End If
    End Sub

    Private Sub txtSearchQLM_TextChanged(sender As Object, e As EventArgs) Handles txtSearchQLM.TextChanged

    End Sub

    Private Sub btnRefreshQLM_Click(sender As Object, e As EventArgs) Handles btnRefreshQLM.Click
        LoadDataCTPMOnGridView()
        LoadDataPMOnGridView()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadDataQLTraOnGridView()
    End Sub

    Private Sub btnQLtra_Click(sender As Object, e As EventArgs) Handles btnQLtra.Click
        SearchDataQLTraOnGridView()
    End Sub

    Private Sub txtSearchQLTra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchQLTra.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchDataQLTraOnGridView()
        End If
    End Sub

    Private Sub txtSearchQLTra_TextChanged(sender As Object, e As EventArgs) Handles txtSearchQLTra.TextChanged

    End Sub

    Private Function Check_Input_MS()
        If _isAddBook = 1 Then
            Return (cmbmsvMS.SelectedIndex = -1 OrElse cmbmnvMS.SelectedIndex = -1 OrElse cmbmsMS.SelectedIndex = -1 _
                    OrElse dtpkhtMS.Value <= dtpkngaymuonMS.Value)
        ElseIf _isAddBook = 2 Then
            Return (cmbmsvMS.SelectedIndex = -1 OrElse cmbmnvMS.SelectedIndex = -1 OrElse cmbmsMS.SelectedIndex = -1 _
                    OrElse dtpkhtMS.Value <= dtpkngaymuonMS.Value OrElse cmbmsMS1.SelectedIndex = -1 _
                    OrElse dtpkhtMS1.Value <= dtpkngaymuonMS.Value OrElse (cmbmsMS1.SelectedIndex = cmbmsMS.SelectedIndex))
        Else
            Return (cmbmsvMS.SelectedIndex = -1 OrElse cmbmnvMS.SelectedIndex = -1 OrElse cmbmsMS.SelectedIndex = -1 _
                    OrElse dtpkhtMS.Value <= dtpkngaymuonMS.Value OrElse cmbmsMS1.SelectedIndex = -1 _
                    OrElse dtpkhtMS1.Value <= dtpkngaymuonMS.Value OrElse cmbmsMS2.SelectedIndex = -1 Or dtpkhtMS2.Value <= dtpkngaymuonMS.Value _
                    OrElse (cmbmsMS2.SelectedIndex = cmbmsMS.SelectedIndex Or cmbmsMS2.SelectedIndex = cmbmsMS1.SelectedIndex))
        End If
    End Function

    Private Sub btnOkMS_Click(sender As Object, e As EventArgs) Handles btnOkMS.Click
        If Check_Input_MS() Then
            MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If _isAddBook = 1 Then
                If OnLoanBookOfLibrary_PhieuMuon() And OnLoanBookOfLibrary_CTPhieuMuon() Then
                    MessageBox.Show("Nhập liệu thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Nhập liệu thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            ElseIf _isAddBook = 2 Then
                If OnLoanBookOfLibrary_PhieuMuon() And OnLoanBookOfLibrary_CTPhieuMuon() And OnLoanBookOfLibrary_CTPhieuMuon1() Then
                    MessageBox.Show("Nhập liệu thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Nhập liệu thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                If OnLoanBookOfLibrary_PhieuMuon() And OnLoanBookOfLibrary_CTPhieuMuon() And OnLoanBookOfLibrary_CTPhieuMuon1() And OnLoanBookOfLibrary_CTPhieuMuon2() Then
                    MessageBox.Show("Nhập liệu thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Nhập liệu thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub dtgrPM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgrPM.CellContentClick

    End Sub

    Private Sub b_Click(sender As Object, e As EventArgs) Handles b.Click
        Dim frm = New frmNhanVien(False)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.Yes Then
            LoadDataNVOnGridview()
        End If
    End Sub

    Private Sub btnCancelMS_Click(sender As Object, e As EventArgs) Handles btnCancelMS.Click
        cmbmsvMS.SelectedIndex = -1
        cmbmnvMS.SelectedIndex = -1
        cmbmsMS.SelectedIndex = -1
        dtpkhtMS.Value = Date.Today
        txttcMS.Text = ""
    End Sub

    Private Sub btnEditNV_Click(sender As Object, e As EventArgs) Handles btnEditNV.Click
        Dim frm = New frmNhanVien(True)
        With Me.dtgrNV
            frm.txtmanv.Text = .Rows(.CurrentCell.RowIndex).Cells(0).Value
            frm.txttennv.Text = .Rows(.CurrentCell.RowIndex).Cells(1).Value
            If .Rows(.CurrentCell.RowIndex).Cells(2).Value.ToString = "Nam" Then
                frm.rdbtNam.Checked = True
            Else
                frm.rdbtNu.Checked = True
            End If
            frm.dtpkns.Value = .Rows(.CurrentCell.RowIndex).Cells(3).Value
            frm.txtsdt.Text = .Rows(.CurrentCell.RowIndex).Cells(4).Value
            frm.txtdc.Text = .Rows(.CurrentCell.RowIndex).Cells(5).Value
            frm.txtemail.Text = .Rows(.CurrentCell.RowIndex).Cells(6).Value
            frm.dtpkngayvl.Value = .Rows(.CurrentCell.RowIndex).Cells(7).Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.Yes Then
            LoadDataNVOnGridview()
        End If
    End Sub

    Private Sub dtpkhtMS_ValueChanged(sender As Object, e As EventArgs) Handles dtpkhtMS.ValueChanged

    End Sub

    Private Sub btnDeleteNV_Click(sender As Object, e As EventArgs) Handles btnDeleteNV.Click
        Dim maNV As Integer = Val(Me.dtgrNV.Rows(Me.dtgrNV.CurrentCell.RowIndex).Cells("MaNV").Value)
        'Xóa
        Dim sqlQuery As String = String.Format("DELETE tbl_NHANVIEN WHERE maNV  = '{0}'", maNV)
        If MessageBox.Show("Bạn muốn xóa bản ghi này ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
                MessageBox.Show("Delete thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadDataSachOnGridview()
            Else
                MessageBox.Show("Delete không thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnAddSV_Click(sender As Object, e As EventArgs) Handles btnAddSV.Click
        Dim frm = New frmSinhVien(False)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.Yes Then
            LoadDataSVOnGridview()
        End If
    End Sub

    Private Sub btnEditSV_Click(sender As Object, e As EventArgs) Handles btnEditSV.Click
        Dim frm = New frmSinhVien(True)
        frm.txtmsv.ReadOnly = True
        With Me.dtgrSV
            frm.txtmsv.Text = .Rows(.CurrentCell.RowIndex).Cells(0).Value
            frm.txttsv.Text = .Rows(.CurrentCell.RowIndex).Cells(1).Value
            If .Rows(.CurrentCell.RowIndex).Cells(2).Value.ToString = "Nam" Then
                frm.rdbtNam.Checked = True
            Else
                frm.rdbtNu.Checked = True
            End If
            frm.dtpkns.Value = .Rows(.CurrentCell.RowIndex).Cells(3).Value
            frm.txtlop.Text = .Rows(.CurrentCell.RowIndex).Cells(4).Value
            frm.dtpkngaylamthe.Value = .Rows(.CurrentCell.RowIndex).Cells(5).Value
            frm.dtpkngayhethan.Text = .Rows(.CurrentCell.RowIndex).Cells(6).Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.Yes Then
            LoadDataSVOnGridview()
        End If
    End Sub

    Private Sub btnDeleteSV_Click(sender As Object, e As EventArgs) Handles btnDeleteSV.Click
        Dim maSV As String = Me.dtgrSV.Rows(Me.dtgrSV.CurrentCell.RowIndex).Cells(0).Value
        'Xóa
        Dim sqlQuery As String = String.Format("DELETE dbo.tbl_SINHVIEN WHERE maSV = '{0}'", maSV)
        If MessageBox.Show("Bạn muốn xóa bản ghi này ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
                MessageBox.Show("Delete thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadDataSVOnGridview()
            Else
                MessageBox.Show("Delete không thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        TabControl1.SelectTab(9)
        LoadDataCTPMOnGridView()
        LoadDataPMOnGridView()
    End Sub


    Private Sub btnGiahanQLMuon_Click(sender As Object, e As EventArgs) Handles btnGiahanQLMuon.Click
        Dim frm = New frmQLMuon
        With Me.dtgrCTPM
            frm.txtmp.Text = .Rows(.CurrentCell.RowIndex).Cells("maPhieu").Value
            frm.txtms.Text = .Rows(.CurrentCell.RowIndex).Cells("maSach").Value
            frm.dtpkht.Value = .Rows(.CurrentCell.RowIndex).Cells("hanTra").Value
            If .Rows(.CurrentCell.RowIndex).Cells("tienCoc").Value.ToString <> "" Then
                frm.txttc.Text = .Rows(.CurrentCell.RowIndex).Cells("tienCoc").Value
            End If
        End With
        For i As Integer = 0 To Me.dtgrPM.RowCount - 1
            If Me.dtgrPM.Rows(i).Cells("maPhieu").Value = frm.txtmp.Text Then
                'Me.dtgrPM.ClearSelection()
                'Me.dtgrPM.Rows(i).Selected = True
                frm.txtmsv.Text = Me.dtgrPM.Rows(i).Cells("maSV").Value
                frm.dtpkngaymuon.Value = Me.dtgrPM.Rows(i).Cells("ngayMuon").Value
                frm.txtmnv.Text = Me.dtgrPM.Rows(i).Cells("maNV").Value
                Exit For
            End If
        Next
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.Yes Then
            LoadDataCTPMOnGridView()
            LoadDataPMOnGridView()
        End If
    End Sub

    Private Sub cmbmnvMS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmnvMS.SelectedIndexChanged

    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        If MessageBox.Show("Thêm sách mượn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            _isAddBook += 1
            If _isAddBook = 2 Then
                Me.btnAddBook.Location = New Point(920, 129)
                Me.cmbmsMS1.Visible = True
                Me.dtpkhtMS1.Visible = True
                Me.txttcMS1.Visible = True
                LoadMSOnCbbBox1()
            Else
                Me.cmbmsMS2.Visible = True
                Me.dtpkhtMS2.Visible = True
                Me.txttcMS2.Visible = True
                btnAddBook.Visible = False
                LoadMSOnCbbBox2()
            End If
            TabPage8.Refresh()
        End If
    End Sub

    Private Sub cmbmsMS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmsMS.SelectedIndexChanged

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        End
    End Sub

    Private Sub QLSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QLSáchToolStripMenuItem.Click
        If TabControl1.SelectedIndex <> 1 Then
            TabControl1.SelectTab(1)
        End If
    End Sub

    Private Sub QLThểLoạiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QLThểLoạiToolStripMenuItem.Click
        If TabControl1.SelectedIndex <> 2 Then
            TabControl1.SelectTab(2)
        End If
    End Sub

    Private Sub QLTácGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QLTácGiảToolStripMenuItem.Click
        If TabControl1.SelectedIndex <> 3 Then
            TabControl1.SelectTab(3)
        End If
    End Sub

    Private Sub QLNgônNgữToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QLNgônNgữToolStripMenuItem.Click
        If TabControl1.SelectedIndex <> 4 Then
            TabControl1.SelectTab(4)
        End If
    End Sub

    Private Sub QLNhàXuấtBảnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QLNhàXuấtBảnToolStripMenuItem.Click
        If TabControl1.SelectedIndex <> 5 Then
            TabControl1.SelectTab(5)
        End If
    End Sub

    Private Sub QLNhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QLNhânViênToolStripMenuItem.Click
        If TabControl1.SelectedIndex <> 6 Then
            TabControl1.SelectTab(6)
        End If
    End Sub

    Private Sub QLĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QLĐộcGiảToolStripMenuItem.Click
        If TabControl1.SelectedIndex <> 7 Then
            TabControl1.SelectTab(7)
        End If
    End Sub

    Private Sub QLMượnSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QLMượnSáchToolStripMenuItem.Click
        If TabControl1.SelectedIndex <> 9 Then
            TabControl1.SelectTab(9)
        End If
    End Sub

    Private Sub LậpPhiếuMượnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LậpPhiếuMượnToolStripMenuItem.Click
        If TabControl1.SelectedIndex <> 8 Then
            TabControl1.SelectTab(8)
        End If
    End Sub

    Private Sub QLTrảSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QLTrảSáchToolStripMenuItem.Click
        If TabControl1.SelectedIndex <> 10 Then
            TabControl1.SelectTab(10)
        End If
    End Sub
End Class
