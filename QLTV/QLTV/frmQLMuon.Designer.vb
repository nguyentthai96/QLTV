<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLMuon
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
        Me.dtpkngaymuon = New System.Windows.Forms.DateTimePicker()
        Me.dtpkht = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txttc = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtmsv = New System.Windows.Forms.TextBox()
        Me.bntCancel = New System.Windows.Forms.Button()
        Me.txtmp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtms = New System.Windows.Forms.TextBox()
        Me.txtmnv = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'dtpkngaymuon
        '
        Me.dtpkngaymuon.CustomFormat = "MM/dd/yyyy"
        Me.dtpkngaymuon.Enabled = False
        Me.dtpkngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpkngaymuon.Location = New System.Drawing.Point(136, 148)
        Me.dtpkngaymuon.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpkngaymuon.Name = "dtpkngaymuon"
        Me.dtpkngaymuon.Size = New System.Drawing.Size(146, 20)
        Me.dtpkngaymuon.TabIndex = 52
        '
        'dtpkht
        '
        Me.dtpkht.CustomFormat = "MM/dd/yyyy"
        Me.dtpkht.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpkht.Location = New System.Drawing.Point(444, 148)
        Me.dtpkht.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpkht.Name = "dtpkht"
        Me.dtpkht.Size = New System.Drawing.Size(146, 20)
        Me.dtpkht.TabIndex = 51
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(362, 204)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "Tiền cọc"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(362, 155)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 13)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Hạn trả"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(362, 93)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 13)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Mã sách"
        '
        'txttc
        '
        Me.txttc.Location = New System.Drawing.Point(444, 201)
        Me.txttc.Name = "txttc"
        Me.txttc.Size = New System.Drawing.Size(146, 20)
        Me.txttc.TabIndex = 43
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(29, 204)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 13)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "Mã nhân viên"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(29, 154)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 13)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Ngày mượn"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 93)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Mã sinh viên"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(227, 277)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 31)
        Me.btnOK.TabIndex = 39
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtmsv
        '
        Me.txtmsv.Location = New System.Drawing.Point(136, 90)
        Me.txtmsv.Name = "txtmsv"
        Me.txtmsv.Size = New System.Drawing.Size(146, 20)
        Me.txtmsv.TabIndex = 53
        '
        'bntCancel
        '
        Me.bntCancel.Location = New System.Drawing.Point(365, 277)
        Me.bntCancel.Name = "bntCancel"
        Me.bntCancel.Size = New System.Drawing.Size(72, 31)
        Me.bntCancel.TabIndex = 54
        Me.bntCancel.Text = "&Cancel"
        Me.bntCancel.UseVisualStyleBackColor = True
        '
        'txtmp
        '
        Me.txtmp.Location = New System.Drawing.Point(289, 41)
        Me.txtmp.Name = "txtmp"
        Me.txtmp.ReadOnly = True
        Me.txtmp.Size = New System.Drawing.Size(146, 20)
        Me.txtmp.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(201, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Mã phiếu"
        '
        'txtms
        '
        Me.txtms.Location = New System.Drawing.Point(444, 90)
        Me.txtms.Name = "txtms"
        Me.txtms.ReadOnly = True
        Me.txtms.Size = New System.Drawing.Size(146, 20)
        Me.txtms.TabIndex = 57
        '
        'txtmnv
        '
        Me.txtmnv.Location = New System.Drawing.Point(136, 201)
        Me.txtmnv.Name = "txtmnv"
        Me.txtmnv.Size = New System.Drawing.Size(146, 20)
        Me.txtmnv.TabIndex = 58
        '
        'frmQLMuon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 370)
        Me.Controls.Add(Me.txtmnv)
        Me.Controls.Add(Me.txtms)
        Me.Controls.Add(Me.txtmp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bntCancel)
        Me.Controls.Add(Me.txtmsv)
        Me.Controls.Add(Me.dtpkngaymuon)
        Me.Controls.Add(Me.dtpkht)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txttc)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "frmQLMuon"
        Me.Text = "Quản Lý Mượn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpkngaymuon As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpkht As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txttc As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtmsv As System.Windows.Forms.TextBox
    Friend WithEvents bntCancel As System.Windows.Forms.Button
    Friend WithEvents txtmp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtms As System.Windows.Forms.TextBox
    Friend WithEvents txtmnv As System.Windows.Forms.TextBox
End Class
