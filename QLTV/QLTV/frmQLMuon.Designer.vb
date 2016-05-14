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
        Me.dtpkngaymuonMS = New System.Windows.Forms.DateTimePicker()
        Me.dtpkhtMS = New System.Windows.Forms.DateTimePicker()
        Me.cmbmsMS = New System.Windows.Forms.ComboBox()
        Me.cmbmnvMS = New System.Windows.Forms.ComboBox()
        Me.cmbmsvMS = New System.Windows.Forms.ComboBox()
        Me.btnCancelMS = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txttcMS = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnOkMS = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtpkngaymuonMS
        '
        Me.dtpkngaymuonMS.CustomFormat = "MM/dd/yyyy"
        Me.dtpkngaymuonMS.Enabled = False
        Me.dtpkngaymuonMS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpkngaymuonMS.Location = New System.Drawing.Point(136, 148)
        Me.dtpkngaymuonMS.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpkngaymuonMS.Name = "dtpkngaymuonMS"
        Me.dtpkngaymuonMS.Size = New System.Drawing.Size(146, 20)
        Me.dtpkngaymuonMS.TabIndex = 52
        '
        'dtpkhtMS
        '
        Me.dtpkhtMS.CustomFormat = "MM/dd/yyyy"
        Me.dtpkhtMS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpkhtMS.Location = New System.Drawing.Point(444, 148)
        Me.dtpkhtMS.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpkhtMS.Name = "dtpkhtMS"
        Me.dtpkhtMS.Size = New System.Drawing.Size(146, 20)
        Me.dtpkhtMS.TabIndex = 51
        '
        'cmbmsMS
        '
        Me.cmbmsMS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbmsMS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbmsMS.FormattingEnabled = True
        Me.cmbmsMS.Location = New System.Drawing.Point(444, 90)
        Me.cmbmsMS.Name = "cmbmsMS"
        Me.cmbmsMS.Size = New System.Drawing.Size(146, 21)
        Me.cmbmsMS.TabIndex = 50
        '
        'cmbmnvMS
        '
        Me.cmbmnvMS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbmnvMS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbmnvMS.FormattingEnabled = True
        Me.cmbmnvMS.Location = New System.Drawing.Point(136, 201)
        Me.cmbmnvMS.Name = "cmbmnvMS"
        Me.cmbmnvMS.Size = New System.Drawing.Size(146, 21)
        Me.cmbmnvMS.TabIndex = 49
        '
        'cmbmsvMS
        '
        Me.cmbmsvMS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbmsvMS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbmsvMS.FormattingEnabled = True
        Me.cmbmsvMS.Location = New System.Drawing.Point(136, 90)
        Me.cmbmsvMS.Name = "cmbmsvMS"
        Me.cmbmsvMS.Size = New System.Drawing.Size(146, 21)
        Me.cmbmsvMS.TabIndex = 48
        '
        'btnCancelMS
        '
        Me.btnCancelMS.Location = New System.Drawing.Point(355, 259)
        Me.btnCancelMS.Name = "btnCancelMS"
        Me.btnCancelMS.Size = New System.Drawing.Size(75, 31)
        Me.btnCancelMS.TabIndex = 47
        Me.btnCancelMS.Text = "&Clear"
        Me.btnCancelMS.UseVisualStyleBackColor = True
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
        'txttcMS
        '
        Me.txttcMS.Location = New System.Drawing.Point(444, 201)
        Me.txttcMS.Name = "txttcMS"
        Me.txttcMS.Size = New System.Drawing.Size(146, 20)
        Me.txttcMS.TabIndex = 43
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
        'btnOkMS
        '
        Me.btnOkMS.Location = New System.Drawing.Point(217, 259)
        Me.btnOkMS.Name = "btnOkMS"
        Me.btnOkMS.Size = New System.Drawing.Size(72, 31)
        Me.btnOkMS.TabIndex = 39
        Me.btnOkMS.Text = "&OK"
        Me.btnOkMS.UseVisualStyleBackColor = True
        '
        'frmQLMuon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 370)
        Me.Controls.Add(Me.dtpkngaymuonMS)
        Me.Controls.Add(Me.dtpkhtMS)
        Me.Controls.Add(Me.cmbmsMS)
        Me.Controls.Add(Me.cmbmnvMS)
        Me.Controls.Add(Me.cmbmsvMS)
        Me.Controls.Add(Me.btnCancelMS)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txttcMS)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnOkMS)
        Me.Name = "frmQLMuon"
        Me.Text = "Quản Lý Mượn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpkngaymuonMS As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpkhtMS As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbmsMS As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmnvMS As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmsvMS As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelMS As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txttcMS As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnOkMS As System.Windows.Forms.Button
End Class
