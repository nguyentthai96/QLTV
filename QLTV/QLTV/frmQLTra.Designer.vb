<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLTra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQLTra))
        Me.txtstt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblms1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpqh = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cmbmp = New System.Windows.Forms.ComboBox()
        Me.cmbms = New System.Windows.Forms.ComboBox()
        Me.cmbmnv = New System.Windows.Forms.ComboBox()
        Me.btnTinh = New System.Windows.Forms.Button()
        Me.cmbms2 = New System.Windows.Forms.ComboBox()
        Me.cmbms3 = New System.Windows.Forms.ComboBox()
        Me.lblms2 = New System.Windows.Forms.Label()
        Me.lblms3 = New System.Windows.Forms.Label()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.lblnt3 = New System.Windows.Forms.Label()
        Me.dtpknt = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtphh = New System.Windows.Forms.TextBox()
        Me.lblphh2 = New System.Windows.Forms.Label()
        Me.txtphh2 = New System.Windows.Forms.TextBox()
        Me.lblphh3 = New System.Windows.Forms.Label()
        Me.txtphh3 = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtstt
        '
        Me.txtstt.Location = New System.Drawing.Point(102, 56)
        Me.txtstt.Name = "txtstt"
        Me.txtstt.ReadOnly = True
        Me.txtstt.Size = New System.Drawing.Size(135, 20)
        Me.txtstt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "STT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mã phiếu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Mã nhân viên"
        '
        'lblms1
        '
        Me.lblms1.AutoSize = True
        Me.lblms1.Location = New System.Drawing.Point(276, 56)
        Me.lblms1.Name = "lblms1"
        Me.lblms1.Size = New System.Drawing.Size(48, 13)
        Me.lblms1.TabIndex = 5
        Me.lblms1.Text = "Mã sách"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(559, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Thanh toán"
        '
        'txttt
        '
        Me.txttt.Location = New System.Drawing.Point(636, 211)
        Me.txttt.Name = "txttt"
        Me.txttt.ReadOnly = True
        Me.txttt.Size = New System.Drawing.Size(135, 20)
        Me.txttt.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(559, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Phạt quá hạn"
        '
        'txtpqh
        '
        Me.txtpqh.Location = New System.Drawing.Point(636, 139)
        Me.txtpqh.Name = "txtpqh"
        Me.txtpqh.ReadOnly = True
        Me.txtpqh.Size = New System.Drawing.Size(135, 20)
        Me.txtpqh.TabIndex = 12
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(209, 290)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 39)
        Me.btnOK.TabIndex = 16
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(583, 290)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 39)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cmbmp
        '
        Me.cmbmp.FormattingEnabled = True
        Me.cmbmp.Location = New System.Drawing.Point(102, 136)
        Me.cmbmp.Name = "cmbmp"
        Me.cmbmp.Size = New System.Drawing.Size(135, 21)
        Me.cmbmp.TabIndex = 18
        '
        'cmbms
        '
        Me.cmbms.FormattingEnabled = True
        Me.cmbms.Location = New System.Drawing.Point(353, 51)
        Me.cmbms.Name = "cmbms"
        Me.cmbms.Size = New System.Drawing.Size(135, 21)
        Me.cmbms.TabIndex = 19
        '
        'cmbmnv
        '
        Me.cmbmnv.Enabled = False
        Me.cmbmnv.FormattingEnabled = True
        Me.cmbmnv.Location = New System.Drawing.Point(102, 208)
        Me.cmbmnv.Name = "cmbmnv"
        Me.cmbmnv.Size = New System.Drawing.Size(135, 21)
        Me.cmbmnv.TabIndex = 20
        '
        'btnTinh
        '
        Me.btnTinh.Location = New System.Drawing.Point(777, 197)
        Me.btnTinh.Name = "btnTinh"
        Me.btnTinh.Size = New System.Drawing.Size(61, 47)
        Me.btnTinh.TabIndex = 22
        Me.btnTinh.Text = "Tính"
        Me.btnTinh.UseVisualStyleBackColor = True
        '
        'cmbms2
        '
        Me.cmbms2.FormattingEnabled = True
        Me.cmbms2.Location = New System.Drawing.Point(353, 136)
        Me.cmbms2.Name = "cmbms2"
        Me.cmbms2.Size = New System.Drawing.Size(135, 21)
        Me.cmbms2.TabIndex = 24
        Me.cmbms2.Visible = False
        '
        'cmbms3
        '
        Me.cmbms3.FormattingEnabled = True
        Me.cmbms3.Location = New System.Drawing.Point(353, 203)
        Me.cmbms3.Name = "cmbms3"
        Me.cmbms3.Size = New System.Drawing.Size(135, 21)
        Me.cmbms3.TabIndex = 26
        Me.cmbms3.Visible = False
        '
        'lblms2
        '
        Me.lblms2.AutoSize = True
        Me.lblms2.Location = New System.Drawing.Point(276, 139)
        Me.lblms2.Name = "lblms2"
        Me.lblms2.Size = New System.Drawing.Size(48, 13)
        Me.lblms2.TabIndex = 23
        Me.lblms2.Text = "Mã sách"
        Me.lblms2.Visible = False
        '
        'lblms3
        '
        Me.lblms3.AutoSize = True
        Me.lblms3.Location = New System.Drawing.Point(276, 206)
        Me.lblms3.Name = "lblms3"
        Me.lblms3.Size = New System.Drawing.Size(48, 13)
        Me.lblms3.TabIndex = 25
        Me.lblms3.Text = "Mã sách"
        Me.lblms3.Visible = False
        '
        'btnAddBook
        '
        Me.btnAddBook.Image = CType(resources.GetObject("btnAddBook.Image"), System.Drawing.Image)
        Me.btnAddBook.Location = New System.Drawing.Point(494, 56)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(41, 35)
        Me.btnAddBook.TabIndex = 40
        Me.btnAddBook.UseVisualStyleBackColor = True
        '
        'lblnt3
        '
        Me.lblnt3.AutoSize = True
        Me.lblnt3.Location = New System.Drawing.Point(559, 59)
        Me.lblnt3.Name = "lblnt3"
        Me.lblnt3.Size = New System.Drawing.Size(47, 13)
        Me.lblnt3.TabIndex = 43
        Me.lblnt3.Text = "Ngày trả"
        '
        'dtpknt
        '
        Me.dtpknt.CustomFormat = "MM/dd/yyyy"
        Me.dtpknt.Enabled = False
        Me.dtpknt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpknt.Location = New System.Drawing.Point(636, 56)
        Me.dtpknt.Name = "dtpknt"
        Me.dtpknt.Size = New System.Drawing.Size(135, 20)
        Me.dtpknt.TabIndex = 44
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(276, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Phạt hư hỏng"
        '
        'txtphh
        '
        Me.txtphh.Location = New System.Drawing.Point(353, 78)
        Me.txtphh.Name = "txtphh"
        Me.txtphh.Size = New System.Drawing.Size(135, 20)
        Me.txtphh.TabIndex = 45
        Me.txtphh.Text = "0"
        '
        'lblphh2
        '
        Me.lblphh2.AutoSize = True
        Me.lblphh2.Location = New System.Drawing.Point(276, 166)
        Me.lblphh2.Name = "lblphh2"
        Me.lblphh2.Size = New System.Drawing.Size(71, 13)
        Me.lblphh2.TabIndex = 48
        Me.lblphh2.Text = "Phạt hư hỏng"
        Me.lblphh2.Visible = False
        '
        'txtphh2
        '
        Me.txtphh2.Location = New System.Drawing.Point(353, 163)
        Me.txtphh2.Name = "txtphh2"
        Me.txtphh2.Size = New System.Drawing.Size(135, 20)
        Me.txtphh2.TabIndex = 47
        Me.txtphh2.Text = "0"
        Me.txtphh2.Visible = False
        '
        'lblphh3
        '
        Me.lblphh3.AutoSize = True
        Me.lblphh3.Location = New System.Drawing.Point(276, 233)
        Me.lblphh3.Name = "lblphh3"
        Me.lblphh3.Size = New System.Drawing.Size(71, 13)
        Me.lblphh3.TabIndex = 50
        Me.lblphh3.Text = "Phạt hư hỏng"
        Me.lblphh3.Visible = False
        '
        'txtphh3
        '
        Me.txtphh3.Location = New System.Drawing.Point(353, 230)
        Me.txtphh3.Name = "txtphh3"
        Me.txtphh3.Size = New System.Drawing.Size(135, 20)
        Me.txtphh3.TabIndex = 49
        Me.txtphh3.Text = "0"
        Me.txtphh3.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(390, 290)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 39)
        Me.btnClear.TabIndex = 51
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmQLTra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 357)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblphh3)
        Me.Controls.Add(Me.txtphh3)
        Me.Controls.Add(Me.lblphh2)
        Me.Controls.Add(Me.txtphh2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtphh)
        Me.Controls.Add(Me.dtpknt)
        Me.Controls.Add(Me.lblnt3)
        Me.Controls.Add(Me.btnAddBook)
        Me.Controls.Add(Me.cmbms3)
        Me.Controls.Add(Me.lblms3)
        Me.Controls.Add(Me.cmbms2)
        Me.Controls.Add(Me.lblms2)
        Me.Controls.Add(Me.btnTinh)
        Me.Controls.Add(Me.cmbmnv)
        Me.Controls.Add(Me.cmbms)
        Me.Controls.Add(Me.cmbmp)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txttt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtpqh)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblms1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtstt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmQLTra"
        Me.Text = "Quản Lý Trả Sách"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtstt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblms1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txttt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtpqh As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cmbmp As System.Windows.Forms.ComboBox
    Friend WithEvents cmbms As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmnv As System.Windows.Forms.ComboBox
    Friend WithEvents btnTinh As System.Windows.Forms.Button
    Friend WithEvents cmbms2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbms3 As System.Windows.Forms.ComboBox
    Friend WithEvents lblms2 As System.Windows.Forms.Label
    Friend WithEvents lblms3 As System.Windows.Forms.Label
    Friend WithEvents btnAddBook As System.Windows.Forms.Button
    Friend WithEvents lblnt3 As System.Windows.Forms.Label
    Friend WithEvents dtpknt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtphh As System.Windows.Forms.TextBox
    Friend WithEvents lblphh2 As System.Windows.Forms.Label
    Friend WithEvents txtphh2 As System.Windows.Forms.TextBox
    Friend WithEvents lblphh3 As System.Windows.Forms.Label
    Friend WithEvents txtphh3 As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
