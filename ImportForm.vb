Imports MySql.Data.MySqlClient
Imports Mysqlx.Resultset
Imports Excel = Microsoft.Office.Interop.Excel
Public Class ImportForm
    Dim xlApp As New Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Dim xlRange As Excel.Range
    Dim misValue As Object = System.Reflection.Missing.Value
    Public Property OpenFileDialog1 As New OpenFileDialog()
    Public Event DataSaved()

    Private Sub ImportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaultIcon(Me)
    End Sub

    Private Sub bttnImport_Click(sender As Object, e As EventArgs) Handles bttnImport.Click
        Dim strFileName As String
        Dim xlRow As Integer

        OpenFileDialog1.Filter = "Excel Office | *.xls; *.xlsx; *.xlsm"
        OpenFileDialog1.ShowDialog()
        strFileName = OpenFileDialog1.FileName

        If strFileName.Equals(String.Empty) Then
        Else
            xlApp = New Microsoft.Office.Interop.Excel.Application()
            xlWorkBook = xlApp.Workbooks.Open(strFileName)
            xlWorkSheet = xlWorkBook.Sheets("Sheet1")
            xlRange = xlWorkSheet.UsedRange
            dtStudentDS.Rows.Clear()

            For xlRow = 2 To xlRange.Rows.Count
                If xlRange.Cells(xlRow, 1).Value Is Nothing OrElse xlRange.Cells(xlRow, 1).Value.ToString().Trim() = "" Then
                    Continue For
                End If
                dtStudentDS.Rows.Add(xlRange.Cells(xlRow, 1).Text,
                                         xlRange.Cells(xlRow, 2).Text,
                                         xlRange.Cells(xlRow, 3).Text,
                                         xlRange.Cells(xlRow, 4).Text,
                                         xlRange.Cells(xlRow, 5).Text,
                                         xlRange.Cells(xlRow, 6).Text,
                                         xlRange.Cells(xlRow, 7).Text,
                                         xlRange.Cells(xlRow, 8).Text,
                                         xlRange.Cells(xlRow, 9).Text,
                                         xlRange.Cells(xlRow, 10).Text,
                                         xlRange.Cells(xlRow, 11).Text)
            Next
            xlApp.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
        End If
    End Sub

    Private Sub bttnSave_Click(sender As Object, e As EventArgs) Handles bttnSave.Click
        connection()
        If dtStudentDS.Rows.Count = 0 Then
            MessageBox.Show("No data to save. Please import data first.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            cn.Open()
            For Each dgRow As DataGridViewRow In dtStudentDS.Rows
                If Not dgRow.IsNewRow Then
                    Using cm As New MySqlCommand("INSERT INTO tblinfor 
            (studID, lastname, firstname, middlename, address, birthdate, gender, year, program, section, religion) 
            VALUES (@StudentID, @LName, @FName, @MName, @Address, @Birth, @Gender, @YearLevel, @Program, @Section, @Religion)", cn)
                        With cm.Parameters
                            .AddWithValue("@StudentID", dgRow.Cells(0).Value)
                            .AddWithValue("@LName", dgRow.Cells(1).Value)
                            .AddWithValue("@FName", dgRow.Cells(2).Value)
                            .AddWithValue("@MName", dgRow.Cells(3).Value)
                            .AddWithValue("@YearLevel", dgRow.Cells(4).Value)
                            .AddWithValue("@Program", dgRow.Cells(5).Value)
                            .AddWithValue("@Section", dgRow.Cells(6).Value)
                            .AddWithValue("@Gender", dgRow.Cells(7).Value)
                            .AddWithValue("@Birth", ConvertExcelDateToString(dgRow.Cells(8).Value))
                            .AddWithValue("@Religion", dgRow.Cells(9).Value)
                            .AddWithValue("@Address", dgRow.Cells(10).Value)
                        End With
                        cm.ExecuteNonQuery()
                    End Using
                End If
            Next
            MessageBox.Show("Data has successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
            RaiseEvent DataSaved()
        End Try

    End Sub

    Private Function ConvertExcelDateToString(value As Object) As String
        If value Is Nothing OrElse value.ToString().Trim() = "" Then
            Return DBNull.Value.ToString()
        End If

        Dim dt As DateTime
        If TypeOf value Is DateTime Then
            dt = CType(value, DateTime)
        ElseIf IsNumeric(value) Then
            ' Excel serial date to DateTime
            dt = DateTime.FromOADate(Convert.ToDouble(value))
        Else
            DateTime.TryParse(value.ToString(), dt)
        End If
        Return dt.ToString("yyyy-MM-dd")
    End Function
End Class