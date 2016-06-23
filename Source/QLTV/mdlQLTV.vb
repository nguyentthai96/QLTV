Module mdlQLTV
    'Lưu tên tk hiện thời
    Public userName As String = ""
    'Lưu mật khẩu hiện thời=> Check khi đổi pass
    Public pass As String = ""
    'Đếm số sách của 1 phiếu mượn
    Public _isAddBook As Integer = 1
    'Lưu mã nhân viên hiện tại
    Public maNV As Integer = 0
    'Đếm số sách trả một lần
    Public countMS As Integer = 1
    Public Sub Export_to_Excel(ByVal _DataSet As DataTable, ByVal _List_Col As String, ByVal Path As String)
        '- _Dataset: lưu dữu liệu cần Export
        '- _List_Col: Danh sách tên cột hiển thị. Tên cột cách nhau dấu ','
        '- Path: Đường dẫn lưu file excel

        Dim col, row As Integer
        Dim arrListcol() As String
        arrListcol = _List_Col.Split(",")

        If _DataSet.Rows.Count <= 0 Then
            Exit Sub
        End If

        Dim Excel As Object = CreateObject("Excel.Application")
        If Excel Is Nothing Then
            MessageBox.Show("Để xuất ra Excel, máy bạn phải cài đặt bộ phần mềm Microsoft Office.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'Export to Excel process
        Try
            With Excel
                .SheetsInNewWorkbook = 1
                .Workbooks.Add()
                .Worksheets(1).Select()

                Dim i As Integer = 2
                .cells(1, 3).value = "Date:" + Format(Now, "MMM-dd-yyyy")
                ' .cells(1, 4).value = Format(Now, "MMM-dd-yyyy")
                .cells(2, i).value = "No"
                .cells(2, i).EntireRow.Font.Bold = True
                For col = 0 To arrListcol.Length - 1
                    i += 1
                    .cells(2, i).value = arrListcol(col).ToUpper()
                    .cells(2, i).EntireRow.Font.Name = "Times New Roman"
                    .cells(2, i).EntireRow.Font.Size = 10
                    .cells(2, i).EntireRow.Font.Bold = True
                Next
                i = 3
                Dim k As Integer = 3

                For col = 0 To _DataSet.Columns.Count - 1
                    i = 3

                    For row = 0 To _DataSet.Rows.Count - 1
                        .Cells(i, 2).Value = i - 2
                        .Cells(i, k).Value = _DataSet.Rows(row).ItemArray(col)
                        i += 1
                    Next
                    k += 1
                Next
                .Columns.AutoFit()
                .ActiveCell.Worksheet.SaveAs(Path)
            End With
            System.Runtime.InteropServices.Marshal.ReleaseComObject(Excel)
            Excel = Nothing
            MessageBox.Show("Xuất dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim proc As System.Diagnostics.Process
            For Each proc In System.Diagnostics.Process.GetProcessesByName("EXCEL")
                proc.Kill()
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
