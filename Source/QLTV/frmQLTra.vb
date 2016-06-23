Public Class frmQLTra
    Private _DBAccess As New DataBaseAccess
    Private DataItem As DataGridViewRow

    Private Sub LoadMPOnCbbBox_QLT()
        Dim sqlQuery As String = "SELECT maPhieu from tbl_PHIEUMUON"
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbmp.DataSource = dtTable
        With Me.cmbmp
            Me.cmbmp.DisplayMember = "maPhieu"
            Me.cmbmp.ValueMember = "maPhieu"
        End With
        cmbmp.SelectedIndex = -1
    End Sub

    Private Sub LoadMNVOnCbbBox_QLT()
        Dim sqlQuery As String = "select distinct manv from tbl_NHANVIEN"
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbmnv.DataSource = dtTable
        With Me.cmbmnv
            Me.cmbmnv.DisplayMember = "maNV"
            Me.cmbmnv.ValueMember = "maNV"
        End With
        cmbmnv.SelectedValue = maNV
    End Sub

    Private Sub frmQLTra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbmp.Select()
        LoadMPOnCbbBox_QLT()
        LoadMNVOnCbbBox_QLT()
        If Not DataItem Is Nothing Then
            LoadData(DataItem)
        End If
    End Sub
    'Ham nay duoc goi khi them phieu tra
    Private Sub LoadMSOnCbbBox_QLT()
        Dim sqlQuery As String = String.Format("SELECT maSach from tbl_CTPHIEUMUON WHERE maPhieu LIKE '{0}'  AND maSach NOT IN (SELECT maSach FROm tbl_TRASACH WHERE maPhieu LIKE '{1}')", cmbmp.SelectedValue, cmbmp.SelectedValue)
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbms.DataSource = dtTable
        With Me.cmbms
            Me.cmbms.DisplayMember = "maSach"
            Me.cmbms.ValueMember = "maSach"
        End With
        cmbms.SelectedIndex = -1
    End Sub

    Private Sub LoadMSOnCbbBox_QLT2()
        Dim sqlQuery As String = String.Format("SELECT maSach from tbl_CTPHIEUMUON WHERE maPhieu LIKE '{0}'  AND maSach NOT IN (SELECT maSach FROm tbl_TRASACH WHERE maPhieu LIKE '{1}')", cmbmp.SelectedValue, cmbmp.SelectedValue)
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbms2.DataSource = dtTable
        With Me.cmbms2
            Me.cmbms2.DisplayMember = "maSach"
            Me.cmbms2.ValueMember = "maSach"
        End With
        cmbms2.SelectedIndex = -1
    End Sub

    Private Sub LoadMSOnCbbBox_QLT3()
        Dim sqlQuery As String = String.Format("SELECT maSach from tbl_CTPHIEUMUON WHERE maPhieu LIKE '{0}'  AND maSach NOT IN (SELECT maSach FROm tbl_TRASACH WHERE maPhieu LIKE '{1}')", cmbmp.SelectedValue, cmbmp.SelectedValue)
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbms3.DataSource = dtTable
        With Me.cmbms3
            Me.cmbms3.DisplayMember = "maSach"
            Me.cmbms3.ValueMember = "maSach"
        End With
        cmbms3.SelectedIndex = -1
    End Sub

    'Ham nay duoc goi khi sua thong tin phieu tra (Co them chuc nang view toan bo sach trong CTPHIEUMUON)
    Private Sub LoadMSOnCbbBox_QLT1()
        Dim sqlQuery As String = String.Format("SELECT maSach from tbl_CTPHIEUMUON WHERE maPhieu LIKE '{0}'", cmbmp.SelectedValue)
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbms.DataSource = dtTable
        With Me.cmbms
            Me.cmbms.DisplayMember = "maSach"
            Me.cmbms.ValueMember = "maSach"
        End With
        cmbms.SelectedIndex = -1
    End Sub

    Private Sub cmbmp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmp.SelectedIndexChanged
        If cmbmp.SelectedIndex <> -1 And _isEdit = False Then
            LoadMSOnCbbBox_QLT()
            LoadMSOnCbbBox_QLT2()
            LoadMSOnCbbBox_QLT3()
        Else
            LoadMSOnCbbBox_QLT1()
        End If
    End Sub

    Private Function TinhPhatQuaHan(maSach As String) As Double
        Dim total As Double = 0
        Dim sqlQuery As String = String.Format("SELECT DATEDIFF(day,hanTra,'{0}') From tbl_CTPhieuMuon, tbl_Trasach where tbl_CTPhieuMuon.maPhieu = '{1}' and tbl_CTPhieuMuon.maSach = '{2}'", dtpknt.Value, cmbmp.SelectedValue, maSach)
        Dim dateDiff As Double = _DBAccess.GetScalar(sqlQuery)
        If dateDiff > 0 Then
            total = dateDiff * 1000
        End If
        Return total
    End Function

    Private Function TongThanhToan(maSach As String, phatHuHong As String) As Double
        phatHuHong = Double.Parse(phatHuHong)
        Dim sqlQuery As String = String.Format("SELECT tienCoc FROM tbl_CTPHIEUMUON where maPhieu = '{0}' and maSach = '{1}'", cmbmp.SelectedValue, maSach)
        Dim tienCoc As Double = _DBAccess.GetScalar(sqlQuery)
        Return (TinhPhatQuaHan(maSach) + phatHuHong - tienCoc)
    End Function

    Private Sub DisplayCost()
        Dim phatQuaHan As Double = TinhPhatQuaHan(cmbms.SelectedValue)
        Dim thanhToan As Double = TongThanhToan(cmbms.SelectedValue, Double.Parse(nbhh1.Value))
        If countMS > 1 Then
            phatQuaHan += TinhPhatQuaHan(cmbms2.SelectedValue)
            thanhToan += TongThanhToan(cmbms2.SelectedValue, Double.Parse(nbhh2.Value))
        End If
        If countMS > 2 Then
            phatQuaHan += TinhPhatQuaHan(cmbms3.SelectedValue)
            thanhToan += TongThanhToan(cmbms3.SelectedValue, Double.Parse(nbhh3.Value))
        End If
        txtpqh.Text = phatQuaHan
        txttt.Text = thanhToan
    End Sub

    Private Sub btnTinh_Click(sender As Object, e As EventArgs) Handles btnTinh.Click
        DisplayCost()
    End Sub

    Private Function ThemSachTra(maSach As String, phatHuHong As String, phatQuaHan As Double, tongTien As Double) As Boolean
        phatHuHong = Double.Parse(phatHuHong)
        Dim sqlQuery As String = "INSERT INTO [dbo].[tbl_TRASACH]([maPhieu],[maSach],[maNV],[ngayTra],[phatHuHong],[phatQuaHan],[thanhToan])"
        sqlQuery += String.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", cmbmp.SelectedValue, maSach, cmbmnv.SelectedValue, dtpknt.Value, phatHuHong, phatQuaHan, tongTien)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Function SuaSachTra() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE dbo.tbl_TRASACH SET maPhieu = '{0}', maSach = '{1}', maNV = '{2}', phatHuHong = '{3}', thanhToan = N'{4}' WHERE STT = '{5}'", _
                                               cmbmp.SelectedValue, cmbms.SelectedValue, cmbmnv.SelectedValue, nbhh1.Value, txttt.Text, txtstt.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Function isEmpty() As Boolean
        If countMS = 1 Then
            Return (cmbms.SelectedIndex = -1 OrElse String.IsNullOrEmpty(txttt.Text))
        ElseIf countMS = 2 Then
            Return (cmbms.SelectedIndex = -1 OrElse String.IsNullOrEmpty(txttt.Text) _
                    OrElse cmbms2.SelectedIndex = -1 OrElse cmbms.SelectedIndex = cmbms2.SelectedIndex)
        ElseIf countMS = 3 Then
            Return (cmbms.SelectedIndex = -1 OrElse String.IsNullOrEmpty(txttt.Text) _
                    OrElse cmbms2.SelectedIndex = -1 OrElse cmbms.SelectedIndex = cmbms2.SelectedIndex _
                    OrElse cmbms3.SelectedIndex = -1 OrElse cmbms3.SelectedIndex = cmbms.SelectedIndex OrElse cmbms3.SelectedIndex = cmbms2.SelectedIndex)
        End If
    End Function

    Private _isEdit As Boolean = False
    Public Sub New(IsEdit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _isEdit = IsEdit
    End Sub

    Public Sub New(IsEdit As Boolean, Data As DataGridViewRow)
        InitializeComponent()

        _isEdit = IsEdit
        DataItem = Data
    End Sub

    Private Sub LoadData(data As DataGridViewRow)
        txtstt.Text = data.Cells("STT").Value
        cmbmp.SelectedValue = data.Cells("maPhieu").Value
        cmbms.SelectedValue = data.Cells(2).Value
        cmbmnv.SelectedValue = data.Cells("maNV").Value
        dtpknt.Text = data.Cells("ngayTra").Value
        nbhh1.Value = data.Cells("phatHuHong").Value
        txtpqh.Text = data.Cells("phatQuaHan").Value
        txttt.Text = data.Cells("thanhToan").Value
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim count As Integer = 0
        If isEmpty() Then
            MessageBox.Show("Bạn phải nhập đầy đủ thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If _isEdit Then
                If SuaSachTra() Then
                    MessageBox.Show("Update thành công!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.Yes
                Else
                    MessageBox.Show("Update không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            Else
                If ThemSachTra(cmbms.SelectedValue, nbhh1.Value, TinhPhatQuaHan(cmbms.SelectedValue), TongThanhToan(cmbms.SelectedValue, nbhh1.Value)) Then
                    count += 1
                Else
                    MessageBox.Show("Insert không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
                If countMS > 1 Then
                    If ThemSachTra(cmbms2.SelectedValue, nbhh2.Value, TinhPhatQuaHan(cmbms2.SelectedValue), TongThanhToan(cmbms2.SelectedValue, nbhh2.Value)) Then
                        count += 1
                    Else
                        MessageBox.Show("Insert không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.DialogResult = Windows.Forms.DialogResult.No
                    End If
                End If
                If countMS > 2 Then
                    If ThemSachTra(cmbms3.SelectedValue, nbhh3.Value, TinhPhatQuaHan(cmbms3.SelectedValue), TongThanhToan(cmbms3.SelectedValue, nbhh3.Value)) Then
                        count += 1
                    Else
                        MessageBox.Show("Insert không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.DialogResult = Windows.Forms.DialogResult.No
                    End If
                End If
                If count > 0 Then
                    MessageBox.Show("Insert " + count.ToString + " rows thành công !", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.Yes
                End If
            End If
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        If MessageBox.Show("Thêm sách trả ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            countMS += 1
            If countMS = 2 Then
                lblms2.Visible = True
                cmbms2.Visible = True
                lblphh2.Visible = True
                nbhh2.Visible = True
                Me.btnAddBook.Location = New Point(490, 140)
            ElseIf countMS = 3 Then
                lblms3.Visible = True
                cmbms3.Visible = True
                lblphh3.Visible = True
                nbhh3.Visible = True
                Me.btnAddBook.Visible = False
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cmbmp.SelectedIndex = -1
        cmbms.SelectedIndex = -1
        nbhh1.Value = 0
        txtpqh.Text = ""
        txttt.Text = ""
        Me.btnAddBook.Visible = True
        Me.btnAddBook.Location = New Point(490, 50)
        If countMS > 1 Then
            lblms2.Visible = False
            cmbms2.Visible = False
            cmbms2.SelectedIndex = -1
            lblphh2.Visible = False
            nbhh2.Visible = False
            nbhh2.Value = 0
        End If
        If countMS > 2 Then
            lblms3.Visible = False
            cmbms3.Visible = False
            cmbms3.SelectedIndex = -1
            lblphh3.Visible = False
            nbhh3.Visible = False
            nbhh3.Value = 0
        End If
        countMS = 1
    End Sub

    Private Sub frmQLTra_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        countMS = 1
    End Sub
End Class