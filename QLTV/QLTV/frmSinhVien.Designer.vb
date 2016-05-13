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
        Me.dtpkngayvl = New System.Windows.Forms.DateTimePicker()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtdc = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtmanv = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttennv = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rdbtNu
        '
        Me.rdbtNu.AutoSize = True
        Me.rdbtNu.Location = New System.Drawing.Point(206, 139)
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
        Me.rdbtNam.Location = New System.Drawing.Point(123, 139)
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
        Me.dtpkns.Location = New System.Drawing.Point(111, 183)
        Me.dtpkns.Name = "dtpkns"
        Me.dtpkns.Size = New System.Drawing.Size(154, 20)
        Me.dtpkns.TabIndex = 69
        '
        'dtpkngayvl
        '
        Me.dtpkngayvl.CustomFormat = "MM/dd/yyyy"
        Me.dtpkngayvl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpkngayvl.Location = New System.Drawing.Point(420, 183)
        Me.dtpkngayvl.Name = "dtpkngayvl"
        Me.dtpkngayvl.Size = New System.Drawing.Size(153, 20)
        Me.dtpkngayvl.TabIndex = 68
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(418, 138)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(154, 20)
        Me.txtemail.TabIndex = 67
        '
        'txtdc
        '
        Me.txtdc.Location = New System.Drawing.Point(419, 92)
        Me.txtdc.Name = "txtdc"
        Me.txtdc.Size = New System.Drawing.Size(154, 20)
        Me.txtdc.TabIndex = 66
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(345, 249)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 36)
        Me.btnCancel.TabIndex = 65
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(170, 249)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 36)
        Me.btnOK.TabIndex = 64
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtmanv
        '
        Me.txtmanv.Location = New System.Drawing.Point(111, 42)
        Me.txtmanv.Name = "txtmanv"
        Me.txtmanv.ReadOnly = True
        Me.txtmanv.Size = New System.Drawing.Size(154, 20)
        Me.txtmanv.TabIndex = 63
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Mã nhân viên"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(331, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Ngày vào làm"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(331, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(331, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Địa chỉ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Ngày sinh"
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(419, 42)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(154, 20)
        Me.txtsdt.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(331, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Điện thoại"
        '
        'txttennv
        '
        Me.txttennv.Location = New System.Drawing.Point(111, 92)
        Me.txttennv.Name = "txttennv"
        Me.txttennv.Size = New System.Drawing.Size(154, 20)
        Me.txttennv.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Tên nhân viên"
        '
        'frmSinhVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 327)
        Me.Controls.Add(Me.rdbtNu)
        Me.Controls.Add(Me.rdbtNam)
        Me.Controls.Add(Me.dtpkns)
        Me.Controls.Add(Me.dtpkngayvl)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtdc)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtmanv)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttennv)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSinhVien"
        Me.Text = "frmSinhVien"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdbtNu As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtNam As System.Windows.Forms.RadioButton
    Friend WithEvents dtpkns As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpkngayvl As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtdc As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtmanv As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttennv As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
