<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNXB
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtsdtnxb = New System.Windows.Forms.TextBox()
        Me.Đ = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txttennxb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmanxb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdiachinxb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtwebsitenxb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(251, 274)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 34)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtsdtnxb
        '
        Me.txtsdtnxb.Location = New System.Drawing.Point(178, 190)
        Me.txtsdtnxb.Name = "txtsdtnxb"
        Me.txtsdtnxb.Size = New System.Drawing.Size(199, 20)
        Me.txtsdtnxb.TabIndex = 10
        '
        'Đ
        '
        Me.Đ.AutoSize = True
        Me.Đ.Location = New System.Drawing.Point(74, 193)
        Me.Đ.Name = "Đ"
        Me.Đ.Size = New System.Drawing.Size(70, 13)
        Me.Đ.TabIndex = 9
        Me.Đ.Text = "Số điện thoại"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(130, 274)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 34)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txttennxb
        '
        Me.txttennxb.Location = New System.Drawing.Point(178, 112)
        Me.txttennxb.Name = "txttennxb"
        Me.txttennxb.Size = New System.Drawing.Size(199, 20)
        Me.txttennxb.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Tên nhà xuất bản"
        '
        'txtmanxb
        '
        Me.txtmanxb.Location = New System.Drawing.Point(178, 67)
        Me.txtmanxb.Name = "txtmanxb"
        Me.txtmanxb.ReadOnly = True
        Me.txtmanxb.Size = New System.Drawing.Size(199, 20)
        Me.txtmanxb.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Mã nhà xuất bản"
        '
        'txtdiachinxb
        '
        Me.txtdiachinxb.Location = New System.Drawing.Point(178, 150)
        Me.txtdiachinxb.Name = "txtdiachinxb"
        Me.txtdiachinxb.Size = New System.Drawing.Size(199, 20)
        Me.txtdiachinxb.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Địa chỉ"
        '
        'txtwebsitenxb
        '
        Me.txtwebsitenxb.Location = New System.Drawing.Point(178, 235)
        Me.txtwebsitenxb.Name = "txtwebsitenxb"
        Me.txtwebsitenxb.Size = New System.Drawing.Size(199, 20)
        Me.txtwebsitenxb.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Website"
        '
        'frmNXB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 320)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtwebsitenxb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtdiachinxb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttennxb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtmanxb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtsdtnxb)
        Me.Controls.Add(Me.Đ)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmNXB"
        Me.Text = "Quản Lý Nhà Xuất Bản"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtsdtnxb As System.Windows.Forms.TextBox
    Friend WithEvents Đ As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txttennxb As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtmanxb As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdiachinxb As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtwebsitenxb As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
