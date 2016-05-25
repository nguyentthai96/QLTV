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
        Me.txtstt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpqh = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtphh = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cmbmp = New System.Windows.Forms.ComboBox()
        Me.cmbms = New System.Windows.Forms.ComboBox()
        Me.cmbmnv = New System.Windows.Forms.ComboBox()
        Me.dtpknt = New System.Windows.Forms.DateTimePicker()
        Me.btnTinh = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtstt
        '
        Me.txtstt.Location = New System.Drawing.Point(98, 60)
        Me.txtstt.Name = "txtstt"
        Me.txtstt.ReadOnly = True
        Me.txtstt.Size = New System.Drawing.Size(135, 20)
        Me.txtstt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "STT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mã phiếu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Mã nhân viên"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Mã sách"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(304, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Thanh toán"
        '
        'txttt
        '
        Me.txttt.Location = New System.Drawing.Point(381, 215)
        Me.txttt.Name = "txttt"
        Me.txttt.ReadOnly = True
        Me.txttt.Size = New System.Drawing.Size(135, 20)
        Me.txttt.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(304, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Phạt quá hạn"
        '
        'txtpqh
        '
        Me.txtpqh.Location = New System.Drawing.Point(381, 163)
        Me.txtpqh.Name = "txtpqh"
        Me.txtpqh.ReadOnly = True
        Me.txtpqh.Size = New System.Drawing.Size(135, 20)
        Me.txtpqh.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(304, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Phạt hư hỏng"
        '
        'txtphh
        '
        Me.txtphh.Location = New System.Drawing.Point(381, 112)
        Me.txtphh.Name = "txtphh"
        Me.txtphh.Size = New System.Drawing.Size(135, 20)
        Me.txtphh.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(304, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Ngày trả"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(170, 287)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 16
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(297, 287)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cmbmp
        '
        Me.cmbmp.FormattingEnabled = True
        Me.cmbmp.Location = New System.Drawing.Point(98, 112)
        Me.cmbmp.Name = "cmbmp"
        Me.cmbmp.Size = New System.Drawing.Size(135, 21)
        Me.cmbmp.TabIndex = 18
        '
        'cmbms
        '
        Me.cmbms.FormattingEnabled = True
        Me.cmbms.Location = New System.Drawing.Point(98, 162)
        Me.cmbms.Name = "cmbms"
        Me.cmbms.Size = New System.Drawing.Size(135, 21)
        Me.cmbms.TabIndex = 19
        '
        'cmbmnv
        '
        Me.cmbmnv.FormattingEnabled = True
        Me.cmbmnv.Location = New System.Drawing.Point(99, 214)
        Me.cmbmnv.Name = "cmbmnv"
        Me.cmbmnv.Size = New System.Drawing.Size(135, 21)
        Me.cmbmnv.TabIndex = 20
        '
        'dtpknt
        '
        Me.dtpknt.CustomFormat = "MM/dd/yyyy"
        Me.dtpknt.Enabled = False
        Me.dtpknt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpknt.Location = New System.Drawing.Point(381, 60)
        Me.dtpknt.Name = "dtpknt"
        Me.dtpknt.Size = New System.Drawing.Size(135, 20)
        Me.dtpknt.TabIndex = 21
        '
        'btnTinh
        '
        Me.btnTinh.Location = New System.Drawing.Point(522, 213)
        Me.btnTinh.Name = "btnTinh"
        Me.btnTinh.Size = New System.Drawing.Size(75, 23)
        Me.btnTinh.TabIndex = 22
        Me.btnTinh.Text = "Tính"
        Me.btnTinh.UseVisualStyleBackColor = True
        '
        'frmQLTra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 357)
        Me.Controls.Add(Me.btnTinh)
        Me.Controls.Add(Me.dtpknt)
        Me.Controls.Add(Me.cmbmnv)
        Me.Controls.Add(Me.cmbms)
        Me.Controls.Add(Me.cmbmp)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txttt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtpqh)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtphh)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtstt)
        Me.Name = "frmQLTra"
        Me.Text = "Quản Lý Trả Sách"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtstt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txttt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtpqh As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtphh As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cmbmp As System.Windows.Forms.ComboBox
    Friend WithEvents cmbms As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmnv As System.Windows.Forms.ComboBox
    Friend WithEvents dtpknt As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnTinh As System.Windows.Forms.Button
End Class
