Public Class frmMain
    'Khai báo obj class DataBaseAccess
    Private _DBAccess As New DataBaseAccess

    'định nghia thu tuc load du lieu len combobox2
    Private Sub LoadDataOnComboBox()
        Dim sqlQuery As String
        If cmbfilter1.SelectedIndex = 0 Then
            sqlQuery = "SELECT maTL,tenTL FROM dbo.tbl_THELOAI"
        ElseIf cmbfilter1.SelectedIndex = 1 Then
            sqlQuery = "SELECT maTG,hoTenTG FROM dbo.tbl_TACGIA"
        ElseIf cmbfilter1.SelectedIndex = 2 Then
            sqlQuery = "SELECT maNN,tenNN FROM dbo.tbl_NGONNGHU"
        Else
            sqlQuery = "SELECT maNXB ,tenNXB FROM [dbo].[tbl_NHAXUATBAN]"
        End If
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)

        Me.cmbfilter2.DataSource = dtTable

        If cmbfilter1.SelectedIndex = 0 Then
            Me.cmbfilter2.ValueMember = "maTL"
            Me.cmbfilter2.DisplayMember = "tenTL"
        ElseIf cmbfilter1.SelectedIndex = 1 Then
            Me.cmbfilter2.ValueMember = "maTG"
            Me.cmbfilter2.DisplayMember = "hoTenTG"
        ElseIf cmbfilter1.SelectedIndex = 2 Then
            Me.cmbfilter2.ValueMember = "maNN"
            Me.cmbfilter2.DisplayMember = "tenNN"
        Else
            Me.cmbfilter2.ValueMember = "maNXB"
            Me.cmbfilter2.DisplayMember = "tenNXB"
        End If
    End Sub

    'Load Data Sach on GridView

    Private Sub LoadDataOnGridview(index As Integer, ID As String)
        Dim sqlQuery As String
        If index = 0 Then
            sqlQuery = String.Format("SELECT * FROM dbo.tbl_SACH WHERE maTL = '{0}'", ID)
        ElseIf index = 1 Then
            sqlQuery = String.Format("SELECT * FROM dbo.tbl_SACH WHERE maTG = '{0}'", ID)
        ElseIf index = 2 Then
            sqlQuery = String.Format("SELECT * FROM dbo.tbl_SACH WHERE maNN = '{0}'", ID)
        Else
            sqlQuery = String.Format("SELECT * FROM dbo.tbl_SACH WHERE maNXB = '{0}'", ID)
        End If
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
    Private Sub SearchBookAsName(index As Integer, ID As String, value As String)
        Dim sqlQuery As String
        If index = 0 Then
            sqlQuery = String.Format("SELECT * FROM dbo.tbl_SACH WHERE maTL = '{0}'", ID)
        ElseIf index = 1 Then
            sqlQuery = String.Format("SELECT * FROM dbo.tbl_SACH WHERE maTG = '{0}'", ID)
        ElseIf index = 2 Then
            sqlQuery = String.Format("SELECT * FROM dbo.tbl_SACH WHERE maNN = '{0}'", ID)
        Else
            sqlQuery = String.Format("SELECT * FROM dbo.tbl_SACH WHERE maNXB = '{0}'", ID)
        End If

        sqlQuery += String.Format("AND tenSach LIKE N'%{0}%'", value)

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

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        'If txtuser.Text = "admin" And txtpass.Text = "admin" Then
        '    _isLogin = True
        '    MessageBox.Show("Bạn đã đăng nhập với tên " & txtuser.Text)
        'Else
        '    txtuser.Focus()
        '    MessageBox.Show("Đăng nhập thất bại!")
        'End If
    End Sub

    Private Sub submenu11_Click(sender As Object, e As EventArgs) Handles submenu11.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub submenu21_Click(sender As Object, e As EventArgs) Handles submenu21.Click
        If TabControl1.SelectedIndex <> 1 Then
            Me.TabControl1.Controls.Add(TabPage2)
            TabControl1.SelectTab(1)
            LoadDataOnComboBox()
            LoadDataOnGridview(Me.cmbfilter1.SelectedIndex, Me.cmbfilter2.SelectedValue)
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TabControl1.Controls.Remove(TabPage2)
        Me.TabControl1.Controls.Remove(TabPage3)
        'Selected Item cmb1
        cmbfilter1.SelectedItem = "Thể Loại"
        'LoadDataOnComboBox()
        'LoadDataOnGridview(Me.cmbfilter1.SelectedIndex, Me.cmbfilter2.SelectedValue)
    End Sub

    Private Sub cmbfilter1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfilter1.SelectedIndexChanged
            LoadDataOnComboBox()
    End Sub

    Private Sub cmbfilter2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfilter2.SelectedIndexChanged
        LoadDataOnGridview(Me.cmbfilter1.SelectedIndex, Me.cmbfilter2.SelectedValue)
        SearchBookAsName(Me.cmbfilter1.SelectedIndex, Me.cmbfilter2.SelectedValue, Me.txtSearch.Text)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchBookAsName(Me.cmbfilter1.SelectedIndex, Me.cmbfilter2.SelectedValue, Me.txtSearch.Text)
    End Sub

    Private Sub txtadd_Click(sender As Object, e As EventArgs) Handles txtadd.Click
        Dim frm1 As New frmSach
        frm1.ShowDialog()
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl1.DrawItem

    End Sub
End Class
