Public Class frmQLMuon
    Private _DBAccess As DataBaseAccess

    Private Sub LoadDataSachOnMaSach()
        Dim maPhieu As Integer
        With frmMain.dtgrCTPM
            maPhieu = .Rows(.CurrentCell.RowIndex).Cells("maPhieu").Value
        End With
        Dim sqlQuery As String = String.Format("SELECT maSach FROM  dbo.tbl_CTPHIEUMUON WHERE maPhieu = '{0}'", maPhieu)
        Dim dtTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbmsMS.DataSource = dtTable
        With Me.cmbmsMS
            Me.cmbmsMS.ValueMember = "maPhieu"
            Me.cmbmsMS.DisplayMember = "maPhieu"
        End With
    End Sub


    Private Sub frmQLMuon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataSachOnMaSach()
    End Sub
End Class