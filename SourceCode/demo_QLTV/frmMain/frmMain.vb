Public Class frmMain
    'Private _DBAcess As New DataBaseAccess
    'Private Sub LoadDataOnComboBox()
    '    Dim sqlQuery As String
    '    If cmbfilter1.SelectedIndex = 1 Then
    '        sqlQuery = "SELECT * FROM dbo.tbl_THELOAI"
    '    ElseIf cmbfilter1.SelectedIndex = 2 Then
    '        sqlQuery = "SELECT * FROM dbo.tbl_NGONNGHU"
    '    ElseIf cmbfilter1.SelectedIndex = 3 Then
    '        sqlQuery = "SELECT * FROM dbo.tbl_NXB"
    '    ElseIf cmbfilter1.SelectedIndex = 4 Then
    '        sqlQuery = "SELECT * FROM dbo.tbl_TACGIA"
    '    End If
    '    Dim dtTable As DataTable = _DBAcess.GetDataTable(sqlQuery)
    '    Me.cmbfilter2.DataSource = dtTable
    '    If cmbfilter1.SelectedIndex = 1 Then
    '        Me.cmbfilter2.ValueMember = "maTL"
    '        Me.cmbfilter2.DisplayMember = "tenTL"
    '    ElseIf cmbfilter1.SelectedIndex = 2 Then
    '        Me.cmbfilter2.ValueMember = "maNN"
    '        Me.cmbfilter2.DisplayMember = "tenNN"
    '    ElseIf cmbfilter1.SelectedIndex = 3 Then
    '        Me.cmbfilter2.ValueMember = "maNXB"
    '        Me.cmbfilter2.DisplayMember = "tenNXB"
    '    ElseIf cmbfilter1.SelectedIndex = 4 Then
    '        Me.cmbfilter2.ValueMember = "maTG"
    '        Me.cmbfilter2.DisplayMember = "tenTG"
    '    End If
    'End Sub


    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tao mac dinh chon item 0
        cmbfilter1.SelectedIndex = 0
        'LoadDataOnComboBox()
    End Sub


    Private Sub btndn_Click(sender As Object, e As EventArgs)
        If txttk.Text = "admin" And txtmk.Text = "admin" Then
            MessageBox.Show("Bạn đã đăng nhập với tên " & txttk.Text)
            _isLogin = True
        Else
            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error)
            _isLogin = False
            txttk.Focus()
        End If
    End Sub

    Private Sub subMenuQuanLySach_Click(sender As Object, e As EventArgs) Handles subMenuQuanLySach.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub subMenulogin_Click(sender As Object, e As EventArgs) Handles subMenulogin.Click
        If _isLogin = False Then
            TabControl1.SelectTab(0)
        Else
            MessageBox.Show("Bạn đã đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btndn_Click_1(sender As Object, e As EventArgs) Handles btndn.Click
        If txttk.Text = "admin" And txtmk.Text = "admin" Then
            _isLogin = True
            MessageBox.Show("Bạn đã đăng nhập thành công với tên " & txttk.Text)
        Else
            txttk.Focus()
            MessageBox.Show("Sai Tài khoản hoặc Mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
    End Sub
End Class
