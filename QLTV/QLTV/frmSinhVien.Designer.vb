<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSinhVien
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
        Me.rdbtNu = New System.Windows.Forms.RadioButton()
        Me.rdbtNam = New System.Windows.Forms.RadioButton()
        Me.dtpkns = New System.Windows.Forms.DateTimePicker()
        Me.dtpkngayhethan = New System.Windows.Forms.DateTimePicker()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtmsv = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtlop = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttsv = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpkngaylamthe = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'rdbtNu
        '
        Me.rdbtNu.AutoSize = True
        Me.rdbtNu.Location = New System.Drawing.Point(174, 139)
        Me.rdbtNu.Name = "rdbtNu"
        Me.rdbtNu.Size = New System.Drawing.Size(39, 17)
        Me.rdbtNu.TabIndex = 71
        Me.rdbtNu.Text = "Nữ"
        Me.rdbtNu.UseVisualStyleBackColor = True
        '
        'rdbtNam
        '
        Me.rdbtNam.AutoSize = True
        Me.rdbtNam.Checked = True
        Me.rdbtNam.Location = New System.Drawing.Point(91, 139)
        Me.rdbtNam.Name = "rdbtNam"
        Me.rdbtNam.Size = New System.Drawing.Size(47, 17)
        Me.rdbtNam.TabIndex = 70
        Me.rdbtNam.TabStop = True
        Me.rdbtNam.Text = "Nam"
        Me.rdbtNam.UseVisualStyleBackColor = True
        '
        'dtpkns
        '
        Me.dtpkns.CustomFormat = "MM/dd/yyyy"
        Me.dtpkns.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpkns.Location = New System.Drawing.Point(91, 183)
        Me.dtpkns.Name = "dtpkns"
        Me.dtpkns.Size = New System.Drawing.Size(154, 20)
        Me.dtpkns.TabIndex = 69
        '
        'dtpkngayhethan
        '
        Me.dtpkngayhethan.CustomFormat = "MM/dd/yyyy"
        Me.dtpkngayhethan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpkngayhethan.Location = New System.Drawing.Point(383, 183)
        Me.dtpkngayhethan.Name = "dtpkngayhethan"
        Me.dtpkngayhethan.Size = New System.Drawing.Size(153, 20)
        Me.dtpkngayhethan.TabIndex = 68
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(327, 249)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 36)
        Me.btnCancel.TabIndex = 65
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(174, 249)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 36)
        Me.btnOK.TabIndex = 64
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtmsv
        '
        Me.txtmsv.Location = New System.Drawing.Point(248, 40)
        Me.txtmsv.Name = "txtmsv"
        Me.txtmsv.Size = New System.Drawing.Size(154, 20)
        Me.txtmsv.TabIndex = 63
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(149, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Mã sinh viên"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(302, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Ngày hết hạn"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(303, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Ngày làm thẻ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Ngày sinh"
        '
        'txtlop
        '
        Me.txtlop.Location = New System.Drawing.Point(383, 84)
        Me.txtlop.Name = "txtlop"
        Me.txtlop.Size = New System.Drawing.Size(154, 20)
        Me.txtlop.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(303, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Lớp"
        '
        'txttsv
        '
        Me.txttsv.Location = New System.Drawing.Point(91, 92)
        Me.txttsv.Name = "txttsv"
        Me.txttsv.Size = New System.Drawing.Size(154, 20)
        Me.txttsv.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Tên sinh viên"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Giới tính"
        '
        'dtpkngaylamthe
        '
        Me.dtpkngaylamthe.CustomFormat = "MM/dd/yyyy"
        Me.dtpkngaylamthe.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpkngaylamthe.Location = New System.Drawing.Point(383, 135)
        Me.dtpkngaylamthe.Name = "dtpkngaylamthe"
        Me.dtpkngaylamthe.Size = New System.Drawing.Size(153, 20)
        Me.dtpkngaylamthe.TabIndex = 73
        '
        'frmSinhVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 327)
        Me.Controls.Add(Me.dtpkngaylamthe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rdbtNu)
        Me.Controls.Add(Me.rdbtNam)
        Me.Controls.Add(Me.dtpkns)
        Me.Controls.Add(Me.dtpkngayhethan)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtmsv)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtlop)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttsv)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSinhVien"
        Me.Text = "Quản Lý Sinh Viên"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdbtNu As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtNam As System.Windows.Forms.RadioButton
    Friend WithEvents dtpkns As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpkngayhethan As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtmsv As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtlop As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttsv As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpkngaylamthe As System.Windows.Forms.DateTimePicker
End Class
