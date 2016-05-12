<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSach
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.txtSoTrang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dtpkngaynhap = New System.Windows.Forms.DateTimePicker()
        Me.cmbmanxb = New System.Windows.Forms.ComboBox()
        Me.cmbmatl = New System.Windows.Forms.ComboBox()
        Me.cmbmatg = New System.Windows.Forms.ComboBox()
        Me.cmbmann = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên Sách"
        '
        'txtTenSach
        '
        Me.txtTenSach.Location = New System.Drawing.Point(128, 158)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(154, 20)
        Me.txtTenSach.TabIndex = 1
        '
        'txtSoTrang
        '
        Me.txtSoTrang.Location = New System.Drawing.Point(128, 207)
        Me.txtSoTrang.Name = "txtSoTrang"
        Me.txtSoTrang.Size = New System.Drawing.Size(154, 20)
        Me.txtSoTrang.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Số Trang"
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(128, 298)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(154, 20)
        Me.txtSoLuong.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 301)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Số Lượng"
        '
        'txtGia
        '
        Me.txtGia.Location = New System.Drawing.Point(128, 254)
        Me.txtGia.Name = "txtGia"
        Me.txtGia.Size = New System.Drawing.Size(154, 20)
        Me.txtGia.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Giá"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(341, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Ngày Nhập"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(341, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Nhà xuất bản"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(341, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Thể loại"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(341, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Tác Giả"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(341, 301)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Ngôn ngữ"
        '
        'txtMaSach
        '
        Me.txtMaSach.Location = New System.Drawing.Point(128, 108)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.ReadOnly = True
        Me.txtMaSach.Size = New System.Drawing.Size(154, 20)
        Me.txtMaSach.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(63, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Mã Sách"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(207, 352)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 36)
        Me.btnOK.TabIndex = 22
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(369, 352)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 36)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dtpkngaynhap
        '
        Me.dtpkngaynhap.CustomFormat = "dd/mm/yyyy"
        Me.dtpkngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpkngaynhap.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dtpkngaynhap.Location = New System.Drawing.Point(431, 104)
        Me.dtpkngaynhap.Name = "dtpkngaynhap"
        Me.dtpkngaynhap.Size = New System.Drawing.Size(154, 20)
        Me.dtpkngaynhap.TabIndex = 24
        '
        'cmbmanxb
        '
        Me.cmbmanxb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbmanxb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbmanxb.FormattingEnabled = True
        Me.cmbmanxb.Location = New System.Drawing.Point(431, 157)
        Me.cmbmanxb.Name = "cmbmanxb"
        Me.cmbmanxb.Size = New System.Drawing.Size(154, 21)
        Me.cmbmanxb.TabIndex = 25
        '
        'cmbmatl
        '
        Me.cmbmatl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbmatl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbmatl.FormattingEnabled = True
        Me.cmbmatl.Location = New System.Drawing.Point(431, 206)
        Me.cmbmatl.Name = "cmbmatl"
        Me.cmbmatl.Size = New System.Drawing.Size(154, 21)
        Me.cmbmatl.TabIndex = 26
        '
        'cmbmatg
        '
        Me.cmbmatg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbmatg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbmatg.FormattingEnabled = True
        Me.cmbmatg.Location = New System.Drawing.Point(431, 253)
        Me.cmbmatg.Name = "cmbmatg"
        Me.cmbmatg.Size = New System.Drawing.Size(154, 21)
        Me.cmbmatg.TabIndex = 27
        '
        'cmbmann
        '
        Me.cmbmann.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbmann.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbmann.FormattingEnabled = True
        Me.cmbmann.Location = New System.Drawing.Point(431, 297)
        Me.cmbmann.Name = "cmbmann"
        Me.cmbmann.Size = New System.Drawing.Size(154, 21)
        Me.cmbmann.TabIndex = 28
        '
        'frmSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 425)
        Me.Controls.Add(Me.cmbmann)
        Me.Controls.Add(Me.cmbmatg)
        Me.Controls.Add(Me.cmbmatl)
        Me.Controls.Add(Me.cmbmanxb)
        Me.Controls.Add(Me.dtpkngaynhap)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtMaSach)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtGia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSoTrang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTenSach)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSach"
        Me.Text = "Thông tin sách"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTenSach As System.Windows.Forms.TextBox
    Friend WithEvents txtSoTrang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSoLuong As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGia As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMaSach As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cmbmanxb As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmatl As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmatg As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmann As System.Windows.Forms.ComboBox
    Friend WithEvents dtpkngaynhap As System.Windows.Forms.DateTimePicker
End Class
