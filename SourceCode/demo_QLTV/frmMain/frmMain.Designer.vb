<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.menuHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenulogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenulogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuQuanLyDanhMuc = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenuQuanLySach = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýThểLoạiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýTácGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýNgônNghữToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuQuanLyNgiepVu = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýNhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýĐộcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuQuanLyMuonTra = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýMượnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýTrảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuThongKe = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuGioiThieu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinPhầnMềmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HướngDẫnSửDụngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu = New System.Windows.Forms.MenuStrip()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnt = New System.Windows.Forms.Button()
        Me.btndn = New System.Windows.Forms.Button()
        Me.ckbnhodn = New System.Windows.Forms.CheckBox()
        Me.llblqmk = New System.Windows.Forms.LinkLabel()
        Me.txtmk = New System.Windows.Forms.TextBox()
        Me.txttk = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgvSach = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.cmbfilter1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbfilter2 = New System.Windows.Forms.ComboBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.menu.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtgvSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuHome
        '
        Me.menuHome.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subMenulogin, Me.subMenulogout, Me.subMenuExit})
        Me.menuHome.Name = "menuHome"
        Me.menuHome.Size = New System.Drawing.Size(84, 20)
        Me.menuHome.Text = "Trang Chính"
        '
        'subMenulogin
        '
        Me.subMenulogin.Name = "subMenulogin"
        Me.subMenulogin.Size = New System.Drawing.Size(152, 22)
        Me.subMenulogin.Text = "Đăng Nhập"
        '
        'subMenulogout
        '
        Me.subMenulogout.Name = "subMenulogout"
        Me.subMenulogout.Size = New System.Drawing.Size(152, 22)
        Me.subMenulogout.Text = "Đăng Xuất"
        '
        'subMenuExit
        '
        Me.subMenuExit.Name = "subMenuExit"
        Me.subMenuExit.Size = New System.Drawing.Size(152, 22)
        Me.subMenuExit.Text = "Thoát "
        '
        'menuQuanLyDanhMuc
        '
        Me.menuQuanLyDanhMuc.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subMenuQuanLySach, Me.QuảnLýToolStripMenuItem, Me.QuảnLýThểLoạiToolStripMenuItem, Me.QuảnLýTácGiảToolStripMenuItem, Me.QuảnLýNgônNghữToolStripMenuItem})
        Me.menuQuanLyDanhMuc.Name = "menuQuanLyDanhMuc"
        Me.menuQuanLyDanhMuc.Size = New System.Drawing.Size(120, 20)
        Me.menuQuanLyDanhMuc.Text = "Quản Lý Danh Mục"
        '
        'subMenuQuanLySach
        '
        Me.subMenuQuanLySach.Name = "subMenuQuanLySach"
        Me.subMenuQuanLySach.Size = New System.Drawing.Size(192, 22)
        Me.subMenuQuanLySach.Text = "Quản Lý Sách"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.QuảnLýToolStripMenuItem.Text = "Quản Lý Nhà Xuất Bản"
        '
        'QuảnLýThểLoạiToolStripMenuItem
        '
        Me.QuảnLýThểLoạiToolStripMenuItem.Name = "QuảnLýThểLoạiToolStripMenuItem"
        Me.QuảnLýThểLoạiToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.QuảnLýThểLoạiToolStripMenuItem.Text = "Quản Lý Thể Loại"
        '
        'QuảnLýTácGiảToolStripMenuItem
        '
        Me.QuảnLýTácGiảToolStripMenuItem.Name = "QuảnLýTácGiảToolStripMenuItem"
        Me.QuảnLýTácGiảToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.QuảnLýTácGiảToolStripMenuItem.Text = "Quản Lý Tác Giả"
        '
        'QuảnLýNgônNghữToolStripMenuItem
        '
        Me.QuảnLýNgônNghữToolStripMenuItem.Name = "QuảnLýNgônNghữToolStripMenuItem"
        Me.QuảnLýNgônNghữToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.QuảnLýNgônNghữToolStripMenuItem.Text = "Quản Lý Ngôn Nghữ"
        '
        'menuQuanLyNgiepVu
        '
        Me.menuQuanLyNgiepVu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýNhânViênToolStripMenuItem, Me.QuảnLýĐộcGiảToolStripMenuItem})
        Me.menuQuanLyNgiepVu.Name = "menuQuanLyNgiepVu"
        Me.menuQuanLyNgiepVu.Size = New System.Drawing.Size(121, 20)
        Me.menuQuanLyNgiepVu.Text = "Quản Lý Nghiệp Vụ"
        '
        'QuảnLýNhânViênToolStripMenuItem
        '
        Me.QuảnLýNhânViênToolStripMenuItem.Name = "QuảnLýNhânViênToolStripMenuItem"
        Me.QuảnLýNhânViênToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.QuảnLýNhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên"
        '
        'QuảnLýĐộcGiảToolStripMenuItem
        '
        Me.QuảnLýĐộcGiảToolStripMenuItem.Name = "QuảnLýĐộcGiảToolStripMenuItem"
        Me.QuảnLýĐộcGiảToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.QuảnLýĐộcGiảToolStripMenuItem.Text = "Quản Lý Độc Giả"
        '
        'menuQuanLyMuonTra
        '
        Me.menuQuanLyMuonTra.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýMượnToolStripMenuItem, Me.QuảnLýTrảToolStripMenuItem})
        Me.menuQuanLyMuonTra.Name = "menuQuanLyMuonTra"
        Me.menuQuanLyMuonTra.Size = New System.Drawing.Size(78, 20)
        Me.menuQuanLyMuonTra.Text = "Mượn - Trả"
        '
        'QuảnLýMượnToolStripMenuItem
        '
        Me.QuảnLýMượnToolStripMenuItem.Name = "QuảnLýMượnToolStripMenuItem"
        Me.QuảnLýMượnToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.QuảnLýMượnToolStripMenuItem.Text = "Quản Lý Mượn"
        '
        'QuảnLýTrảToolStripMenuItem
        '
        Me.QuảnLýTrảToolStripMenuItem.Name = "QuảnLýTrảToolStripMenuItem"
        Me.QuảnLýTrảToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.QuảnLýTrảToolStripMenuItem.Text = "Quản Lý Trả "
        '
        'menuThongKe
        '
        Me.menuThongKe.Name = "menuThongKe"
        Me.menuThongKe.Size = New System.Drawing.Size(70, 20)
        Me.menuThongKe.Text = "Thống Kê"
        '
        'menuGioiThieu
        '
        Me.menuGioiThieu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThôngTinPhầnMềmToolStripMenuItem, Me.HướngDẫnSửDụngToolStripMenuItem})
        Me.menuGioiThieu.Name = "menuGioiThieu"
        Me.menuGioiThieu.Size = New System.Drawing.Size(73, 20)
        Me.menuGioiThieu.Text = "Giới Thiệu"
        '
        'ThôngTinPhầnMềmToolStripMenuItem
        '
        Me.ThôngTinPhầnMềmToolStripMenuItem.Name = "ThôngTinPhầnMềmToolStripMenuItem"
        Me.ThôngTinPhầnMềmToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ThôngTinPhầnMềmToolStripMenuItem.Text = "Thông Tin Phần Mềm"
        '
        'HướngDẫnSửDụngToolStripMenuItem
        '
        Me.HướngDẫnSửDụngToolStripMenuItem.Name = "HướngDẫnSửDụngToolStripMenuItem"
        Me.HướngDẫnSửDụngToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.HướngDẫnSửDụngToolStripMenuItem.Text = "Hướng Dẫn Sử Dụng"
        '
        'menu
        '
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuHome, Me.menuQuanLyDanhMuc, Me.menuQuanLyNgiepVu, Me.menuQuanLyMuonTra, Me.menuThongKe, Me.menuGioiThieu})
        Me.menu.Location = New System.Drawing.Point(0, 0)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(1306, 24)
        Me.menu.TabIndex = 1
        Me.menu.Text = "MenuStrip1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(5, 72)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1287, 547)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnt)
        Me.TabPage1.Controls.Add(Me.btndn)
        Me.TabPage1.Controls.Add(Me.ckbnhodn)
        Me.TabPage1.Controls.Add(Me.llblqmk)
        Me.TabPage1.Controls.Add(Me.txtmk)
        Me.TabPage1.Controls.Add(Me.txttk)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1279, 521)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.lblSearch)
        Me.TabPage2.Controls.Add(Me.cmbfilter2)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.cmbfilter1)
        Me.TabPage2.Controls.Add(Me.btnEdit)
        Me.TabPage2.Controls.Add(Me.btnDelete)
        Me.TabPage2.Controls.Add(Me.txtSearch)
        Me.TabPage2.Controls.Add(Me.dtgvSach)
        Me.TabPage2.Controls.Add(Me.btnAdd)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1279, 521)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnt
        '
        Me.btnt.Location = New System.Drawing.Point(528, 282)
        Me.btnt.Name = "btnt"
        Me.btnt.Size = New System.Drawing.Size(75, 23)
        Me.btnt.TabIndex = 20
        Me.btnt.Text = "&Thoát"
        Me.btnt.UseVisualStyleBackColor = True
        '
        'btndn
        '
        Me.btndn.Location = New System.Drawing.Point(397, 282)
        Me.btndn.Name = "btndn"
        Me.btndn.Size = New System.Drawing.Size(75, 23)
        Me.btndn.TabIndex = 19
        Me.btndn.Text = "&Đăng Nhập"
        Me.btndn.UseVisualStyleBackColor = True
        '
        'ckbnhodn
        '
        Me.ckbnhodn.AutoSize = True
        Me.ckbnhodn.Location = New System.Drawing.Point(397, 233)
        Me.ckbnhodn.Name = "ckbnhodn"
        Me.ckbnhodn.Size = New System.Drawing.Size(101, 17)
        Me.ckbnhodn.TabIndex = 18
        Me.ckbnhodn.Text = "Nhớ đăng nhập"
        Me.ckbnhodn.UseVisualStyleBackColor = True
        '
        'llblqmk
        '
        Me.llblqmk.AutoSize = True
        Me.llblqmk.Location = New System.Drawing.Point(544, 233)
        Me.llblqmk.Name = "llblqmk"
        Me.llblqmk.Size = New System.Drawing.Size(80, 13)
        Me.llblqmk.TabIndex = 17
        Me.llblqmk.TabStop = True
        Me.llblqmk.Text = "Quên mật khẩu"
        '
        'txtmk
        '
        Me.txtmk.Location = New System.Drawing.Point(397, 196)
        Me.txtmk.Name = "txtmk"
        Me.txtmk.Size = New System.Drawing.Size(206, 20)
        Me.txtmk.TabIndex = 16
        '
        'txttk
        '
        Me.txttk.Location = New System.Drawing.Point(397, 148)
        Me.txttk.Name = "txttk"
        Me.txttk.Size = New System.Drawing.Size(206, 20)
        Me.txttk.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(450, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Đăng Nhập Hệ Thống"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(287, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Mật Khẩu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Tài Khoản"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(358, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "HỆ THỐNG QUẢN LÝ THƯ VIỆN TRƯỜNG ĐẠI HỌC ĐIỆN LỰC"
        '
        'dtgvSach
        '
        Me.dtgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvSach.Location = New System.Drawing.Point(4, 100)
        Me.dtgvSach.Name = "dtgvSach"
        Me.dtgvSach.Size = New System.Drawing.Size(1269, 415)
        Me.dtgvSach.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(336, 41)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(311, 20)
        Me.txtSearch.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(740, 37)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 27)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Thêm"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(1040, 37)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(94, 27)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Xóa"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(888, 37)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(94, 27)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Sửa"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'cmbfilter1
        '
        Me.cmbfilter1.FormattingEnabled = True
        Me.cmbfilter1.Items.AddRange(New Object() {"(None)", "Thể Loại", "Ngôn Nghữ", "Nhà Xuất Bản", "Tác Giả"})
        Me.cmbfilter1.Location = New System.Drawing.Point(25, 43)
        Me.cmbfilter1.Name = "cmbfilter1"
        Me.cmbfilter1.Size = New System.Drawing.Size(121, 21)
        Me.cmbfilter1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Lọc Theo"
        '
        'cmbfilter2
        '
        Me.cmbfilter2.FormattingEnabled = True
        Me.cmbfilter2.Location = New System.Drawing.Point(175, 43)
        Me.cmbfilter2.Name = "cmbfilter2"
        Me.cmbfilter2.Size = New System.Drawing.Size(121, 21)
        Me.cmbfilter2.TabIndex = 11
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(333, 16)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(78, 13)
        Me.lblSearch.TabIndex = 12
        Me.lblSearch.Text = "Tìm Kiếm Sách"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(172, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Điều Kiện"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1306, 613)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.menu)
        Me.MainMenuStrip = Me.menu
        Me.Name = "frmMain"
        Me.Text = "Quản Lý Thư Viện"
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dtgvSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuHome As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subMenulogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subMenulogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subMenuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuQuanLyDanhMuc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subMenuQuanLySach As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýThểLoạiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýTácGiảToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýNgônNghữToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuQuanLyNgiepVu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýNhânViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýĐộcGiảToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuQuanLyMuonTra As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýMượnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýTrảToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuThongKe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuGioiThieu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThôngTinPhầnMềmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HướngDẫnSửDụngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu As System.Windows.Forms.MenuStrip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnt As System.Windows.Forms.Button
    Friend WithEvents btndn As System.Windows.Forms.Button
    Friend WithEvents ckbnhodn As System.Windows.Forms.CheckBox
    Friend WithEvents llblqmk As System.Windows.Forms.LinkLabel
    Friend WithEvents txtmk As System.Windows.Forms.TextBox
    Friend WithEvents txttk As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents cmbfilter2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbfilter1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dtgvSach As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button

End Class
